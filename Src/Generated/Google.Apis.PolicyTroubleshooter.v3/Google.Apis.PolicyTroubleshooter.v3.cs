// Copyright 2026 Google LLC
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

namespace Google.Apis.PolicyTroubleshooter.v3
{
    /// <summary>The PolicyTroubleshooter Service.</summary>
    public class PolicyTroubleshooterService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v3";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public PolicyTroubleshooterService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public PolicyTroubleshooterService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Iam = new IamResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://policytroubleshooter.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://policytroubleshooter.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "policytroubleshooter";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Policy Troubleshooter API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Policy Troubleshooter API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Iam resource.</summary>
        public virtual IamResource Iam { get; }
    }

    /// <summary>A base abstract class for PolicyTroubleshooter requests.</summary>
    public abstract class PolicyTroubleshooterBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new PolicyTroubleshooterBaseServiceRequest instance.</summary>
        protected PolicyTroubleshooterBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes PolicyTroubleshooter parameter list.</summary>
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

    /// <summary>The "iam" collection of methods.</summary>
    public class IamResource
    {
        private const string Resource = "iam";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public IamResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Checks whether a principal has a specific permission for a specific resource, and explains why the principal
        /// does or doesn't have that permission.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual TroubleshootRequest Troubleshoot(Google.Apis.PolicyTroubleshooter.v3.Data.GoogleCloudPolicytroubleshooterIamV3TroubleshootIamPolicyRequest body)
        {
            return new TroubleshootRequest(this.service, body);
        }

        /// <summary>
        /// Checks whether a principal has a specific permission for a specific resource, and explains why the principal
        /// does or doesn't have that permission.
        /// </summary>
        public class TroubleshootRequest : PolicyTroubleshooterBaseServiceRequest<Google.Apis.PolicyTroubleshooter.v3.Data.GoogleCloudPolicytroubleshooterIamV3TroubleshootIamPolicyResponse>
        {
            /// <summary>Constructs a new Troubleshoot request.</summary>
            public TroubleshootRequest(Google.Apis.Services.IClientService service, Google.Apis.PolicyTroubleshooter.v3.Data.GoogleCloudPolicytroubleshooterIamV3TroubleshootIamPolicyRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.PolicyTroubleshooter.v3.Data.GoogleCloudPolicytroubleshooterIamV3TroubleshootIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "troubleshoot";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/iam:troubleshoot";

            /// <summary>Initializes Troubleshoot parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.PolicyTroubleshooter.v3.Data
{
    /// <summary>Information about the principal, resource, and permission to check.</summary>
    public class GoogleCloudPolicytroubleshooterIamV3AccessTuple : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Additional context for the request, such as the request time or IP address. This context allows
        /// Policy Troubleshooter to troubleshoot conditional role bindings and deny rules.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionContext")]
        public virtual GoogleCloudPolicytroubleshooterIamV3ConditionContext ConditionContext { get; set; }

        /// <summary>
        /// Required. The full resource name that identifies the resource. For example,
        /// `//compute.googleapis.com/projects/my-project/zones/us-central1-a/instances/my-instance`. For examples of
        /// full resource names for Google Cloud services, see
        /// https://cloud.google.com/iam/help/troubleshooter/full-resource-names.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; }

        /// <summary>
        /// Required. The IAM permission to check for, either in the `v1` permission format or the `v2` permission
        /// format. For a complete list of IAM permissions in the `v1` format, see
        /// https://cloud.google.com/iam/help/permissions/reference. For a list of IAM permissions in the `v2` format,
        /// see https://cloud.google.com/iam/help/deny/supported-permissions. For a complete list of predefined IAM
        /// roles and the permissions in each role, see https://cloud.google.com/iam/help/roles/reference.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permission")]
        public virtual string Permission { get; set; }

        /// <summary>Output only. The permission that Policy Troubleshooter checked for, in the `v2` format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionFqdn")]
        public virtual string PermissionFqdn { get; set; }

        /// <summary>
        /// Required. The email address of the principal whose access you want to check. For example,
        /// `alice@example.com` or `my-service-account@my-project.iam.gserviceaccount.com`. The principal must be a
        /// Google Account or a service account. Other types of principals are not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principal")]
        public virtual string Principal { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details about how a role binding in an allow policy affects a principal's ability to use a permission.
    /// </summary>
    public class GoogleCloudPolicytroubleshooterIamV3AllowBindingExplanation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Indicates whether _this role binding_ gives the specified permission to the specified principal on
        /// the specified resource. This field does _not_ indicate whether the principal actually has the permission on
        /// the resource. There might be another role binding that overrides this role binding. To determine whether the
        /// principal actually has the permission, use the `overall_access_state` field in the
        /// TroubleshootIamPolicyResponse.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowAccessState")]
        public virtual string AllowAccessState { get; set; }

        /// <summary>
        /// The combined result of all memberships. Indicates if the principal is included in any role binding, either
        /// directly or indirectly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("combinedMembership")]
        public virtual GoogleCloudPolicytroubleshooterIamV3AllowBindingExplanationAnnotatedAllowMembership CombinedMembership { get; set; }

        /// <summary>
        /// A condition expression that specifies when the role binding grants access. To learn about IAM Conditions,
        /// see https://cloud.google.com/iam/help/conditions/overview.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual GoogleTypeExpr Condition { get; set; }

        /// <summary>Condition evaluation state for this role binding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionExplanation")]
        public virtual GoogleCloudPolicytroubleshooterIamV3ConditionExplanation ConditionExplanation { get; set; }

        /// <summary>
        /// Indicates whether each role binding includes the principal specified in the request, either directly or
        /// indirectly. Each key identifies a principal in the role binding, and each value indicates whether the
        /// principal in the role binding includes the principal in the request. For example, suppose that a role
        /// binding includes the following principals: * `user:alice@example.com` * `group:product-eng@example.com` You
        /// want to troubleshoot access for `user:bob@example.com`. This user is a member of the group
        /// `group:product-eng@example.com`. For the first principal in the role binding, the key is
        /// `user:alice@example.com`, and the `membership` field in the value is set to `NOT_INCLUDED`. For the second
        /// principal in the role binding, the key is `group:product-eng@example.com`, and the `membership` field in the
        /// value is set to `INCLUDED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberships")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudPolicytroubleshooterIamV3AllowBindingExplanationAnnotatedAllowMembership> Memberships { get; set; }

        /// <summary>The relevance of this role binding to the overall determination for the entire policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relevance")]
        public virtual string Relevance { get; set; }

        /// <summary>
        /// The role that this role binding grants. For example, `roles/compute.admin`. For a complete list of
        /// predefined IAM roles, as well as the permissions in each role, see
        /// https://cloud.google.com/iam/help/roles/reference.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>
        /// Indicates whether the role granted by this role binding contains the specified permission.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolePermission")]
        public virtual string RolePermission { get; set; }

        /// <summary>
        /// The relevance of the permission's existence, or nonexistence, in the role to the overall determination for
        /// the entire policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolePermissionRelevance")]
        public virtual string RolePermissionRelevance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about whether the role binding includes the principal.</summary>
    public class GoogleCloudPolicytroubleshooterIamV3AllowBindingExplanationAnnotatedAllowMembership : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates whether the role binding includes the principal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membership")]
        public virtual string Membership { get; set; }

        /// <summary>
        /// The relevance of the principal's status to the overall determination for the role binding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relevance")]
        public virtual string Relevance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about how the relevant IAM allow policies affect the final access state.</summary>
    public class GoogleCloudPolicytroubleshooterIamV3AllowPolicyExplanation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates whether the principal has the specified permission for the specified resource, based on evaluating
        /// all applicable IAM allow policies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowAccessState")]
        public virtual string AllowAccessState { get; set; }

        /// <summary>
        /// List of IAM allow policies that were evaluated to check the principal's permissions, with annotations to
        /// indicate how each policy contributed to the final result. The list of policies includes the policy for the
        /// resource itself, as well as allow policies that are inherited from higher levels of the resource hierarchy,
        /// including the organization, the folder, and the project. To learn more about the resource hierarchy, see
        /// https://cloud.google.com/iam/help/resource-hierarchy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explainedPolicies")]
        public virtual System.Collections.Generic.IList<GoogleCloudPolicytroubleshooterIamV3ExplainedAllowPolicy> ExplainedPolicies { get; set; }

        /// <summary>The relevance of the allow policy type to the overall access state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relevance")]
        public virtual string Relevance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional context for troubleshooting conditional role bindings and deny rules.</summary>
    public class GoogleCloudPolicytroubleshooterIamV3ConditionContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The destination of a network activity, such as accepting a TCP connection. In a multi-hop network activity,
        /// the destination represents the receiver of the last hop.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual GoogleCloudPolicytroubleshooterIamV3ConditionContextPeer Destination { get; set; }

        /// <summary>
        /// Output only. The effective tags on the resource. The effective tags are fetched during troubleshooting.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveTags")]
        public virtual System.Collections.Generic.IList<GoogleCloudPolicytroubleshooterIamV3ConditionContextEffectiveTag> EffectiveTags { get; set; }

        /// <summary>Represents a network request, such as an HTTP request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual GoogleCloudPolicytroubleshooterIamV3ConditionContextRequest Request { get; set; }

        /// <summary>
        /// Represents a target resource that is involved with a network activity. If multiple resources are involved
        /// with an activity, this must be the primary one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual GoogleCloudPolicytroubleshooterIamV3ConditionContextResource Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A tag that applies to a resource during policy evaluation. Tags can be either directly bound to a resource or
    /// inherited from its ancestor. `EffectiveTag` contains the `name` and `namespaced_name` of the tag value and tag
    /// key, with additional fields of `inherited` to indicate the inheritance status of the effective tag.
    /// </summary>
    public class GoogleCloudPolicytroubleshooterIamV3ConditionContextEffectiveTag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Indicates the inheritance status of a tag value attached to the given resource. If the tag
        /// value is inherited from one of the resource's ancestors, inherited will be true. If false, then the tag
        /// value is directly attached to the resource, inherited will be false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inherited")]
        public virtual System.Nullable<bool> Inherited { get; set; }

        /// <summary>
        /// Output only. The namespaced name of the TagKey. Can be in the form `{organization_id}/{tag_key_short_name}`
        /// or `{project_id}/{tag_key_short_name}` or `{project_number}/{tag_key_short_name}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespacedTagKey")]
        public virtual string NamespacedTagKey { get; set; }

        /// <summary>
        /// Output only. The namespaced name of the TagValue. Can be in the form
        /// `{organization_id}/{tag_key_short_name}/{tag_value_short_name}` or
        /// `{project_id}/{tag_key_short_name}/{tag_value_short_name}` or
        /// `{project_number}/{tag_key_short_name}/{tag_value_short_name}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespacedTagValue")]
        public virtual string NamespacedTagValue { get; set; }

        /// <summary>Output only. The name of the TagKey, in the format `tagKeys/{id}`, such as `tagKeys/123`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagKey")]
        public virtual string TagKey { get; set; }

        /// <summary>
        /// The parent name of the tag key. Must be in the format `organizations/{organization_id}` or
        /// `projects/{project_number}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagKeyParentName")]
        public virtual string TagKeyParentName { get; set; }

        /// <summary>Output only. Resource name for TagValue in the format `tagValues/456`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagValue")]
        public virtual string TagValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This message defines attributes for a node that handles a network request. The node can be either a service or
    /// an application that sends, forwards, or receives the request. Service peers should fill in `principal` and
    /// `labels` as appropriate.
    /// </summary>
    public class GoogleCloudPolicytroubleshooterIamV3ConditionContextPeer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The IPv4 or IPv6 address of the peer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ip")]
        public virtual string Ip { get; set; }

        /// <summary>The network port of the peer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<long> Port { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This message defines attributes for an HTTP request. If the actual request is not an HTTP request, the runtime
    /// system should try to map the actual request to an equivalent HTTP request.
    /// </summary>
    public class GoogleCloudPolicytroubleshooterIamV3ConditionContextRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _receiveTimeRaw;

        private object _receiveTime;

        /// <summary>
        /// Optional. The timestamp when the destination service receives the first byte of the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("receiveTime")]
        public virtual string ReceiveTimeRaw
        {
            get => _receiveTimeRaw;
            set
            {
                _receiveTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _receiveTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReceiveTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReceiveTimeDateTimeOffset instead.")]
        public virtual object ReceiveTime
        {
            get => _receiveTime;
            set
            {
                _receiveTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _receiveTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReceiveTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReceiveTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReceiveTimeRaw);
            set => ReceiveTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Core attributes for a resource. A resource is an addressable (named) entity provided by the destination service.
    /// For example, a Compute Engine instance.
    /// </summary>
    public class GoogleCloudPolicytroubleshooterIamV3ConditionContextResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The stable identifier (name) of a resource on the `service`. A resource can be logically identified as
        /// `//{resource.service}/{resource.name}`. Unlike the resource URI, the resource name doesn't contain any
        /// protocol and version information. For a list of full resource name formats, see
        /// https://cloud.google.com/iam/help/troubleshooter/full-resource-names
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The name of the service that this resource belongs to, such as `compute.googleapis.com`. The service name
        /// might not match the DNS hostname that actually serves the request. For a full list of resource service
        /// values, see https://cloud.google.com/iam/help/conditions/resource-services
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>
        /// The type of the resource, in the format `{service}/{kind}`. For a full list of resource type values, see
        /// https://cloud.google.com/iam/help/conditions/resource-types
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Explanation for how a condition affects a principal's access</summary>
    public class GoogleCloudPolicytroubleshooterIamV3ConditionExplanation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Any errors that prevented complete evaluation of the condition expression.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> Errors { get; set; }

        /// <summary>
        /// The value of each statement of the condition expression. The value can be `true`, `false`, or `null`. The
        /// value is `null` if the statement can't be evaluated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationStates")]
        public virtual System.Collections.Generic.IList<GoogleCloudPolicytroubleshooterIamV3ConditionExplanationEvaluationState> EvaluationStates { get; set; }

        /// <summary>Value of the condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual object Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evaluated state of a condition expression.</summary>
    public class GoogleCloudPolicytroubleshooterIamV3ConditionExplanationEvaluationState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// End position of an expression in the condition, by character, end included, for example: the end position of
        /// the first part of `a==b || c==d` would be 4.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("end")]
        public virtual System.Nullable<int> End { get; set; }

        /// <summary>Any errors that prevented complete evaluation of the condition expression.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> Errors { get; set; }

        /// <summary>Start position of an expression in the condition, by character.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("start")]
        public virtual System.Nullable<int> Start { get; set; }

        /// <summary>Value of this expression.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual object Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about how the relevant IAM deny policies affect the final access state.</summary>
    public class GoogleCloudPolicytroubleshooterIamV3DenyPolicyExplanation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates whether the principal is denied the specified permission for the specified resource, based on
        /// evaluating all applicable IAM deny policies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denyAccessState")]
        public virtual string DenyAccessState { get; set; }

        /// <summary>
        /// List of resources with IAM deny policies that were evaluated to check the principal's denied permissions,
        /// with annotations to indicate how each policy contributed to the final result. The list of resources includes
        /// the policy for the resource itself, as well as policies that are inherited from higher levels of the
        /// resource hierarchy, including the organization, the folder, and the project. The order of the resources
        /// starts from the resource and climbs up the resource hierarchy. To learn more about the resource hierarchy,
        /// see https://cloud.google.com/iam/help/resource-hierarchy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explainedResources")]
        public virtual System.Collections.Generic.IList<GoogleCloudPolicytroubleshooterIamV3ExplainedDenyResource> ExplainedResources { get; set; }

        /// <summary>Indicates whether the permission to troubleshoot is supported in deny policies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionDeniable")]
        public virtual System.Nullable<bool> PermissionDeniable { get; set; }

        /// <summary>The relevance of the deny policy result to the overall access state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relevance")]
        public virtual string Relevance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details about how a deny rule in a deny policy affects a principal's ability to use a permission.
    /// </summary>
    public class GoogleCloudPolicytroubleshooterIamV3DenyRuleExplanation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates whether the permission in the request is listed as a denied permission in the deny rule.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("combinedDeniedPermission")]
        public virtual GoogleCloudPolicytroubleshooterIamV3DenyRuleExplanationAnnotatedPermissionMatching CombinedDeniedPermission { get; set; }

        /// <summary>
        /// Indicates whether the principal is listed as a denied principal in the deny rule, either directly or through
        /// membership in a principal set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("combinedDeniedPrincipal")]
        public virtual GoogleCloudPolicytroubleshooterIamV3DenyRuleExplanationAnnotatedDenyPrincipalMatching CombinedDeniedPrincipal { get; set; }

        /// <summary>
        /// Indicates whether the permission in the request is listed as an exception permission in the deny rule.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("combinedExceptionPermission")]
        public virtual GoogleCloudPolicytroubleshooterIamV3DenyRuleExplanationAnnotatedPermissionMatching CombinedExceptionPermission { get; set; }

        /// <summary>
        /// Indicates whether the principal is listed as an exception principal in the deny rule, either directly or
        /// through membership in a principal set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("combinedExceptionPrincipal")]
        public virtual GoogleCloudPolicytroubleshooterIamV3DenyRuleExplanationAnnotatedDenyPrincipalMatching CombinedExceptionPrincipal { get; set; }

        /// <summary>
        /// A condition expression that specifies when the deny rule denies the principal access. To learn about IAM
        /// Conditions, see https://cloud.google.com/iam/help/conditions/overview.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual GoogleTypeExpr Condition { get; set; }

        /// <summary>Condition evaluation state for this role binding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionExplanation")]
        public virtual GoogleCloudPolicytroubleshooterIamV3ConditionExplanation ConditionExplanation { get; set; }

        /// <summary>
        /// Lists all denied permissions in the deny rule and indicates whether each permission matches the permission
        /// in the request. Each key identifies a denied permission in the rule, and each value indicates whether the
        /// denied permission matches the permission in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deniedPermissions")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudPolicytroubleshooterIamV3DenyRuleExplanationAnnotatedPermissionMatching> DeniedPermissions { get; set; }

        /// <summary>
        /// Lists all denied principals in the deny rule and indicates whether each principal matches the principal in
        /// the request, either directly or through membership in a principal set. Each key identifies a denied
        /// principal in the rule, and each value indicates whether the denied principal matches the principal in the
        /// request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deniedPrincipals")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudPolicytroubleshooterIamV3DenyRuleExplanationAnnotatedDenyPrincipalMatching> DeniedPrincipals { get; set; }

        /// <summary>
        /// Required. Indicates whether _this rule_ denies the specified permission to the specified principal for the
        /// specified resource. This field does _not_ indicate whether the principal is actually denied on the
        /// permission for the resource. There might be another rule that overrides this rule. To determine whether the
        /// principal actually has the permission, use the `overall_access_state` field in the
        /// TroubleshootIamPolicyResponse.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denyAccessState")]
        public virtual string DenyAccessState { get; set; }

        /// <summary>
        /// Lists all exception permissions in the deny rule and indicates whether each permission matches the
        /// permission in the request. Each key identifies a exception permission in the rule, and each value indicates
        /// whether the exception permission matches the permission in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exceptionPermissions")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudPolicytroubleshooterIamV3DenyRuleExplanationAnnotatedPermissionMatching> ExceptionPermissions { get; set; }

        /// <summary>
        /// Lists all exception principals in the deny rule and indicates whether each principal matches the principal
        /// in the request, either directly or through membership in a principal set. Each key identifies a exception
        /// principal in the rule, and each value indicates whether the exception principal matches the principal in the
        /// request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exceptionPrincipals")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudPolicytroubleshooterIamV3DenyRuleExplanationAnnotatedDenyPrincipalMatching> ExceptionPrincipals { get; set; }

        /// <summary>The relevance of this role binding to the overall determination for the entire policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relevance")]
        public virtual string Relevance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details about whether the principal in the request is listed as a denied principal in the deny rule, either
    /// directly or through membership in a principal set.
    /// </summary>
    public class GoogleCloudPolicytroubleshooterIamV3DenyRuleExplanationAnnotatedDenyPrincipalMatching : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates whether the principal is listed as a denied principal in the deny rule, either directly or through
        /// membership in a principal set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membership")]
        public virtual string Membership { get; set; }

        /// <summary>
        /// The relevance of the principal's status to the overall determination for the role binding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relevance")]
        public virtual string Relevance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about whether the permission in the request is denied by the deny rule.</summary>
    public class GoogleCloudPolicytroubleshooterIamV3DenyRuleExplanationAnnotatedPermissionMatching : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates whether the permission in the request is denied by the deny rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionMatchingState")]
        public virtual string PermissionMatchingState { get; set; }

        /// <summary>The relevance of the permission status to the overall determination for the rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relevance")]
        public virtual string Relevance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about how a specific IAM allow policy contributed to the final access state.</summary>
    public class GoogleCloudPolicytroubleshooterIamV3ExplainedAllowPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Indicates whether _this policy_ provides the specified permission to the specified principal for
        /// the specified resource. This field does _not_ indicate whether the principal actually has the permission for
        /// the resource. There might be another policy that overrides this policy. To determine whether the principal
        /// actually has the permission, use the `overall_access_state` field in the TroubleshootIamPolicyResponse.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowAccessState")]
        public virtual string AllowAccessState { get; set; }

        /// <summary>
        /// Details about how each role binding in the policy affects the principal's ability, or inability, to use the
        /// permission for the resource. The order of the role bindings matches the role binding order in the policy. If
        /// the sender of the request does not have access to the policy, this field is omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindingExplanations")]
        public virtual System.Collections.Generic.IList<GoogleCloudPolicytroubleshooterIamV3AllowBindingExplanation> BindingExplanations { get; set; }

        /// <summary>
        /// The full resource name that identifies the resource. For example,
        /// `//compute.googleapis.com/projects/my-project/zones/us-central1-a/instances/my-instance`. If the sender of
        /// the request does not have access to the policy, this field is omitted. For examples of full resource names
        /// for Google Cloud services, see https://cloud.google.com/iam/help/troubleshooter/full-resource-names.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; }

        /// <summary>
        /// The IAM allow policy attached to the resource. If the sender of the request does not have access to the
        /// policy, this field is empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual GoogleIamV1Policy Policy { get; set; }

        /// <summary>
        /// The relevance of this policy to the overall access state in the TroubleshootIamPolicyResponse. If the sender
        /// of the request does not have access to the policy, this field is omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relevance")]
        public virtual string Relevance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about how a specific IAM deny policy Policy contributed to the access check.</summary>
    public class GoogleCloudPolicytroubleshooterIamV3ExplainedDenyPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Indicates whether _this policy_ denies the specified permission to the specified principal for the
        /// specified resource. This field does _not_ indicate whether the principal actually has the permission for the
        /// resource. There might be another policy that overrides this policy. To determine whether the principal
        /// actually has the permission, use the `overall_access_state` field in the TroubleshootIamPolicyResponse.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denyAccessState")]
        public virtual string DenyAccessState { get; set; }

        /// <summary>
        /// The IAM deny policy attached to the resource. If the sender of the request does not have access to the
        /// policy, this field is omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual GoogleIamV2Policy Policy { get; set; }

        /// <summary>
        /// The relevance of this policy to the overall access state in the TroubleshootIamPolicyResponse. If the sender
        /// of the request does not have access to the policy, this field is omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relevance")]
        public virtual string Relevance { get; set; }

        /// <summary>
        /// Details about how each rule in the policy affects the principal's inability to use the permission for the
        /// resource. The order of the deny rule matches the order of the rules in the deny policy. If the sender of the
        /// request does not have access to the policy, this field is omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleExplanations")]
        public virtual System.Collections.Generic.IList<GoogleCloudPolicytroubleshooterIamV3DenyRuleExplanation> RuleExplanations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about how a specific resource contributed to the deny policy evaluation.</summary>
    public class GoogleCloudPolicytroubleshooterIamV3ExplainedDenyResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Indicates whether any policies attached to _this resource_ deny the specific permission to the
        /// specified principal for the specified resource. This field does _not_ indicate whether the principal
        /// actually has the permission for the resource. There might be another policy that overrides this policy. To
        /// determine whether the principal actually has the permission, use the `overall_access_state` field in the
        /// TroubleshootIamPolicyResponse.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denyAccessState")]
        public virtual string DenyAccessState { get; set; }

        /// <summary>
        /// List of IAM deny policies that were evaluated to check the principal's denied permissions, with annotations
        /// to indicate how each policy contributed to the final result.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explainedPolicies")]
        public virtual System.Collections.Generic.IList<GoogleCloudPolicytroubleshooterIamV3ExplainedDenyPolicy> ExplainedPolicies { get; set; }

        /// <summary>
        /// The full resource name that identifies the resource. For example,
        /// `//compute.googleapis.com/projects/my-project/zones/us-central1-a/instances/my-instance`. If the sender of
        /// the request does not have access to the policy, this field is omitted. For examples of full resource names
        /// for Google Cloud services, see https://cloud.google.com/iam/help/troubleshooter/full-resource-names.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; }

        /// <summary>
        /// The relevance of this policy to the overall access state in the TroubleshootIamPolicyResponse. If the sender
        /// of the request does not have access to the policy, this field is omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relevance")]
        public virtual string Relevance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for TroubleshootIamPolicy.</summary>
    public class GoogleCloudPolicytroubleshooterIamV3TroubleshootIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The information to use for checking whether a principal has a permission for a resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessTuple")]
        public virtual GoogleCloudPolicytroubleshooterIamV3AccessTuple AccessTuple { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for TroubleshootIamPolicy.</summary>
    public class GoogleCloudPolicytroubleshooterIamV3TroubleshootIamPolicyResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The access tuple from the request, including any provided context used to evaluate the condition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessTuple")]
        public virtual GoogleCloudPolicytroubleshooterIamV3AccessTuple AccessTuple { get; set; }

        /// <summary>An explanation of how the applicable IAM allow policies affect the final access state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowPolicyExplanation")]
        public virtual GoogleCloudPolicytroubleshooterIamV3AllowPolicyExplanation AllowPolicyExplanation { get; set; }

        /// <summary>An explanation of how the applicable IAM deny policies affect the final access state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denyPolicyExplanation")]
        public virtual GoogleCloudPolicytroubleshooterIamV3DenyPolicyExplanation DenyPolicyExplanation { get; set; }

        /// <summary>
        /// Indicates whether the principal has the specified permission for the specified resource, based on evaluating
        /// all types of the applicable IAM policies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overallAccessState")]
        public virtual string OverallAccessState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies the audit configuration for a service. The configuration determines which permission types are logged,
    /// and what identities, if any, are exempted from logging. An AuditConfig must have one or more AuditLogConfigs. If
    /// there are AuditConfigs for both `allServices` and a specific service, the union of the two AuditConfigs is used
    /// for that service: the log_types specified in each AuditConfig are enabled, and the exempted_members in each
    /// AuditLogConfig are exempted. Example Policy with multiple AuditConfigs: { "audit_configs": [ { "service":
    /// "allServices", "audit_log_configs": [ { "log_type": "DATA_READ", "exempted_members": [ "user:jose@example.com" ]
    /// }, { "log_type": "DATA_WRITE" }, { "log_type": "ADMIN_READ" } ] }, { "service": "sampleservice.googleapis.com",
    /// "audit_log_configs": [ { "log_type": "DATA_READ" }, { "log_type": "DATA_WRITE", "exempted_members": [
    /// "user:aliya@example.com" ] } ] } ] } For sampleservice, this policy enables DATA_READ, DATA_WRITE and ADMIN_READ
    /// logging. It also exempts `jose@example.com` from DATA_READ logging, and `aliya@example.com` from DATA_WRITE
    /// logging.
    /// </summary>
    public class GoogleIamV1AuditConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for logging of each type of permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLogConfigs")]
        public virtual System.Collections.Generic.IList<GoogleIamV1AuditLogConfig> AuditLogConfigs { get; set; }

        /// <summary>
        /// Specifies a service that will be enabled for audit logging. For example, `storage.googleapis.com`,
        /// `cloudsql.googleapis.com`. `allServices` is a special value that covers all services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provides the configuration for logging a type of permissions. Example: { "audit_log_configs": [ { "log_type":
    /// "DATA_READ", "exempted_members": [ "user:jose@example.com" ] }, { "log_type": "DATA_WRITE" } ] } This enables
    /// 'DATA_READ' and 'DATA_WRITE' logging, while exempting jose@example.com from DATA_READ logging.
    /// </summary>
    public class GoogleIamV1AuditLogConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the identities that do not cause logging for this type of permission. Follows the same format of
        /// Binding.members.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exemptedMembers")]
        public virtual System.Collections.Generic.IList<string> ExemptedMembers { get; set; }

        /// <summary>The log type that this config enables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logType")]
        public virtual string LogType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Associates `members`, or principals, with a `role`.</summary>
    public class GoogleIamV1Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// principals in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual GoogleTypeExpr Condition { get; set; }

        /// <summary>
        /// Specifies the principals requesting access for a Google Cloud resource. `members` can have the following
        /// values: * `allUsers`: A special identifier that represents anyone who is on the internet; with or without a
        /// Google account. * `allAuthenticatedUsers`: A special identifier that represents anyone who is authenticated
        /// with a Google account or a service account. Does not include identities that come from external identity
        /// providers (IdPs) through identity federation. * `user:{emailid}`: An email address that represents a
        /// specific Google account. For example, `alice@example.com` . * `serviceAccount:{emailid}`: An email address
        /// that represents a Google service account. For example, `my-other-app@appspot.gserviceaccount.com`. *
        /// `serviceAccount:{projectid}.svc.id.goog[{namespace}/{kubernetes-sa}]`: An identifier for a [Kubernetes
        /// service account](https://cloud.google.com/kubernetes-engine/docs/how-to/kubernetes-service-accounts). For
        /// example, `my-project.svc.id.goog[my-namespace/my-kubernetes-sa]`. * `group:{emailid}`: An email address that
        /// represents a Google group. For example, `admins@example.com`. * `domain:{domain}`: The G Suite domain
        /// (primary) that represents all the users of that domain. For example, `google.com` or `example.com`. *
        /// `principal://iam.googleapis.com/locations/global/workforcePools/{pool_id}/subject/{subject_attribute_value}`:
        /// A single identity in a workforce identity pool. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/group/{group_id}`: All
        /// workforce identities in a group. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/attribute.{attribute_name}/{attribute_value}`:
        /// All workforce identities with a specific attribute value. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/*`: All identities in a
        /// workforce identity pool. *
        /// `principal://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/subject/{subject_attribute_value}`:
        /// A single identity in a workload identity pool. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/group/{group_id}`:
        /// A workload identity pool group. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/attribute.{attribute_name}/{attribute_value}`:
        /// All identities in a workload identity pool with a certain attribute. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/*`:
        /// All identities in a workload identity pool. * `deleted:user:{emailid}?uid={uniqueid}`: An email address
        /// (plus unique identifier) representing a user that has been recently deleted. For example,
        /// `alice@example.com?uid=123456789012345678901`. If the user is recovered, this value reverts to
        /// `user:{emailid}` and the recovered user retains the role in the binding. *
        /// `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a
        /// service account that has been recently deleted. For example,
        /// `my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted,
        /// this value reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the
        /// binding. * `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing
        /// a Google group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`.
        /// If the group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role
        /// in the binding. *
        /// `deleted:principal://iam.googleapis.com/locations/global/workforcePools/{pool_id}/subject/{subject_attribute_value}`:
        /// Deleted single identity in a workforce identity pool. For example,
        /// `deleted:principal://iam.googleapis.com/locations/global/workforcePools/my-pool-id/subject/my-subject-attribute-value`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Role that is assigned to the list of `members`, or principals. For example, `roles/viewer`, `roles/editor`,
        /// or `roles/owner`. For an overview of the IAM roles and permissions, see the [IAM
        /// documentation](https://cloud.google.com/iam/docs/roles-overview). For a list of the available pre-defined
        /// roles, see [here](https://cloud.google.com/iam/docs/understanding-roles).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Identity and Access Management (IAM) policy, which specifies access controls for Google Cloud resources. A
    /// `Policy` is a collection of `bindings`. A `binding` binds one or more `members`, or principals, to a single
    /// `role`. Principals can be user accounts, service accounts, Google groups, and domains (such as G Suite). A
    /// `role` is a named list of permissions; each `role` can be an IAM predefined role or a user-created custom role.
    /// For some types of Google Cloud resources, a `binding` can also specify a `condition`, which is a logical
    /// expression that allows access to a resource only if the expression evaluates to `true`. A condition can add
    /// constraints based on attributes of the request, the resource, or both. To learn which resources support
    /// conditions in their IAM policies, see the [IAM
    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:**
    /// ```
    /// {
    /// "bindings": [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 }
    /// ```
    /// **YAML
    /// example:**
    /// ```
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') etag: BwWWja0YfJA= version: 3
    /// ```
    /// For a description of IAM and its
    /// features, see the [IAM documentation](https://cloud.google.com/iam/docs/).
    /// </summary>
    public class GoogleIamV1Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<GoogleIamV1AuditConfig> AuditConfigs { get; set; }

        /// <summary>
        /// Associates a list of `members`, or principals, with a `role`. Optionally, may specify a `condition` that
        /// determines how and when the `bindings` are applied. Each of the `bindings` must contain at least one
        /// principal. The `bindings` in a `Policy` can refer to up to 1,500 principals; up to 250 of these principals
        /// can be Google groups. Each occurrence of a principal counts towards these limits. For example, if the
        /// `bindings` grant 50 different roles to `user:alice@example.com`, and not to any other principal, then you
        /// can add another 1,450 principals to the `bindings` in the `Policy`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<GoogleIamV1Binding> Bindings { get; set; }

        /// <summary>
        /// `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy
        /// from overwriting each other. It is strongly suggested that systems make use of the `etag` in the
        /// read-modify-write cycle to perform policy updates in order to avoid race conditions: An `etag` is returned
        /// in the response to `getIamPolicy`, and systems are expected to put that etag in the request to
        /// `setIamPolicy` to ensure that their change will be applied to the same version of the policy. **Important:**
        /// If you use IAM Conditions, you must include the `etag` field whenever you call `setIamPolicy`. If you omit
        /// this field, then IAM allows you to overwrite a version `3` policy with a version `1` policy, and all of the
        /// conditions in the version `3` policy are lost.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Specifies the format of the policy. Valid values are `0`, `1`, and `3`. Requests that specify an invalid
        /// value are rejected. Any operation that affects conditional role bindings must specify version `3`. This
        /// requirement applies to the following operations: * Getting a policy that includes a conditional role binding
        /// * Adding a conditional role binding to a policy * Changing a conditional role binding in a policy * Removing
        /// any role binding, with or without a condition, from a policy that includes conditions **Important:** If you
        /// use IAM Conditions, you must include the `etag` field whenever you call `setIamPolicy`. If you omit this
        /// field, then IAM allows you to overwrite a version `3` policy with a version `1` policy, and all of the
        /// conditions in the version `3` policy are lost. If a policy does not include any conditions, operations on
        /// that policy may specify any valid version or leave the field unset. To learn which resources support
        /// conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; }
    }

    /// <summary>A deny rule in an IAM deny policy.</summary>
    public class GoogleIamV2DenyRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that determines whether this deny rule applies to a request. If the condition expression
        /// evaluates to `true`, then the deny rule is applied; otherwise, the deny rule is not applied. Each deny rule
        /// is evaluated independently. If this deny rule does not apply to a request, other deny rules might still
        /// apply. The condition can use CEL functions that evaluate [resource
        /// tags](https://cloud.google.com/iam/help/conditions/resource-tags). Other functions and operators are not
        /// supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denialCondition")]
        public virtual GoogleTypeExpr DenialCondition { get; set; }

        /// <summary>
        /// The permissions that are explicitly denied by this rule. Each permission uses the format
        /// `{service_fqdn}/{resource}.{verb}`, where `{service_fqdn}` is the fully qualified domain name for the
        /// service. For example, `iam.googleapis.com/roles.list`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deniedPermissions")]
        public virtual System.Collections.Generic.IList<string> DeniedPermissions { get; set; }

        /// <summary>
        ///  The identities that are prevented from using one or more permissions on Google Cloud resources. This field
        /// can contain the following values: * `principal://goog/subject/{email_id}`: A specific Google Account.
        /// Includes Gmail, Cloud Identity, and Google Workspace user accounts. For example,
        /// `principal://goog/subject/alice@example.com`. *
        /// `principal://iam.googleapis.com/projects/-/serviceAccounts/{service_account_id}`: A Google Cloud service
        /// account. For example,
        /// `principal://iam.googleapis.com/projects/-/serviceAccounts/my-service-account@iam.gserviceaccount.com`. *
        /// `principalSet://goog/group/{group_id}`: A Google group. For example,
        /// `principalSet://goog/group/admins@example.com`. * `principalSet://goog/public:all`: A special identifier
        /// that represents any principal that is on the internet, even if they do not have a Google Account or are not
        /// logged in. * `principalSet://goog/cloudIdentityCustomerId/{customer_id}`: All of the principals associated
        /// with the specified Google Workspace or Cloud Identity customer ID. For example,
        /// `principalSet://goog/cloudIdentityCustomerId/C01Abc35`. *
        /// `principal://iam.googleapis.com/locations/global/workforcePools/{pool_id}/subject/{subject_attribute_value}`:
        /// A single identity in a workforce identity pool. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/group/{group_id}`: All
        /// workforce identities in a group. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/attribute.{attribute_name}/{attribute_value}`:
        /// All workforce identities with a specific attribute value. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/*`: All identities in a
        /// workforce identity pool. *
        /// `principal://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/subject/{subject_attribute_value}`:
        /// A single identity in a workload identity pool. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/group/{group_id}`:
        /// A workload identity pool group. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/attribute.{attribute_name}/{attribute_value}`:
        /// All identities in a workload identity pool with a certain attribute. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/*`:
        /// All identities in a workload identity pool. *
        /// `principalSet://cloudresourcemanager.googleapis.com/[projects|folders|organizations]/{project_number|folder_number|org_number}/type/ServiceAccount`:
        /// All service accounts grouped under a resource (project, folder, or organization). *
        /// `principalSet://cloudresourcemanager.googleapis.com/[projects|folders|organizations]/{project_number|folder_number|org_number}/type/ServiceAgent`:
        /// All service agents grouped under a resource (project, folder, or organization). *
        /// `deleted:principal://goog/subject/{email_id}?uid={uid}`: A specific Google Account that was deleted
        /// recently. For example, `deleted:principal://goog/subject/alice@example.com?uid=1234567890`. If the Google
        /// Account is recovered, this identifier reverts to the standard identifier for a Google Account. *
        /// `deleted:principalSet://goog/group/{group_id}?uid={uid}`: A Google group that was deleted recently. For
        /// example, `deleted:principalSet://goog/group/admins@example.com?uid=1234567890`. If the Google group is
        /// restored, this identifier reverts to the standard identifier for a Google group. *
        /// `deleted:principal://iam.googleapis.com/projects/-/serviceAccounts/{service_account_id}?uid={uid}`: A Google
        /// Cloud service account that was deleted recently. For example,
        /// `deleted:principal://iam.googleapis.com/projects/-/serviceAccounts/my-service-account@iam.gserviceaccount.com?uid=1234567890`.
        /// If the service account is undeleted, this identifier reverts to the standard identifier for a service
        /// account. *
        /// `deleted:principal://iam.googleapis.com/locations/global/workforcePools/{pool_id}/subject/{subject_attribute_value}`:
        /// Deleted single identity in a workforce identity pool. For example,
        /// `deleted:principal://iam.googleapis.com/locations/global/workforcePools/my-pool-id/subject/my-subject-attribute-value`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deniedPrincipals")]
        public virtual System.Collections.Generic.IList<string> DeniedPrincipals { get; set; }

        /// <summary>
        /// Specifies the permissions that this rule excludes from the set of denied permissions given by
        /// `denied_permissions`. If a permission appears in `denied_permissions` _and_ in `exception_permissions` then
        /// it will _not_ be denied. The excluded permissions can be specified using the same syntax as
        /// `denied_permissions`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exceptionPermissions")]
        public virtual System.Collections.Generic.IList<string> ExceptionPermissions { get; set; }

        /// <summary>
        /// The identities that are excluded from the deny rule, even if they are listed in the `denied_principals`. For
        /// example, you could add a Google group to the `denied_principals`, then exclude specific users who belong to
        /// that group. This field can contain the same values as the `denied_principals` field, excluding
        /// `principalSet://goog/public:all`, which represents all users on the internet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exceptionPrincipals")]
        public virtual System.Collections.Generic.IList<string> ExceptionPrincipals { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data for an IAM policy.</summary>
    public class GoogleIamV2Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A key-value map to store arbitrary metadata for the `Policy`. Keys can be up to 63 characters. Values can be
        /// up to 255 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the `Policy` was created.</summary>
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

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. The time when the `Policy` was deleted. Empty if the policy is not deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>A user-specified description of the `Policy`. This value can be up to 63 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// An opaque tag that identifies the current version of the `Policy`. IAM uses this value to help manage
        /// concurrent updates, so they do not cause one update to be overwritten by another. If this field is present
        /// in a CreatePolicyRequest, the value is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Output only. The kind of the `Policy`. Always contains the value `DenyPolicy`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Immutable. The resource name of the `Policy`, which must be unique. Format:
        /// `policies/{attachment_point}/denypolicies/{policy_id}` The attachment point is identified by its URL-encoded
        /// full resource name, which means that the forward-slash character, `/`, must be written as `%2F`. For
        /// example, `policies/cloudresourcemanager.googleapis.com%2Fprojects%2Fmy-project/denypolicies/my-deny-policy`.
        /// For organizations and folders, use the numeric ID in the full resource name. For projects, requests can use
        /// the alphanumeric or the numeric ID. Responses always contain the numeric ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// A list of rules that specify the behavior of the `Policy`. All of the rules should be of the `kind`
        /// specified in the `Policy`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<GoogleIamV2PolicyRule> Rules { get; set; }

        /// <summary>
        /// Immutable. The globally unique ID of the `Policy`. Assigned automatically when the `Policy` is created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when the `Policy` was last updated.</summary>
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

    /// <summary>A single rule in a `Policy`.</summary>
    public class GoogleIamV2PolicyRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A rule for a deny policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denyRule")]
        public virtual GoogleIamV2DenyRule DenyRule { get; set; }

        /// <summary>A user-specified description of the rule. This value can be up to 256 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

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

    /// <summary>
    /// Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression
    /// language. The syntax and semantics of CEL are documented at https://github.com/google/cel-spec. Example
    /// (Comparison): title: "Summary size limit" description: "Determines if a summary is less than 100 chars"
    /// expression: "document.summary.size() &amp;lt; 100" Example (Equality): title: "Requestor is owner" description:
    /// "Determines if requestor is the document owner" expression: "document.owner == request.auth.claims.email"
    /// Example (Logic): title: "Public documents" description: "Determine whether the document should be publicly
    /// visible" expression: "document.type != 'private' &amp;amp;&amp;amp; document.type != 'internal'" Example (Data
    /// Manipulation): title: "Notification string" description: "Create a notification string with a timestamp."
    /// expression: "'New message received at ' + string(document.create_time)" The exact variables and functions that
    /// may be referenced within an expression are determined by the service that evaluates it. See the service
    /// documentation for additional information.
    /// </summary>
    public class GoogleTypeExpr : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Description of the expression. This is a longer text which describes the expression, e.g. when
        /// hovered over it in a UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; }

        /// <summary>
        /// Optional. String indicating the location of the expression for error reporting, e.g. a file name and a
        /// position in the file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs
        /// which allow to enter the expression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
