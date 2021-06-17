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

namespace Google.Apis.CloudAsset.v1p1beta1
{
    /// <summary>The CloudAsset Service.</summary>
    public class CloudAssetService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1p1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudAssetService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudAssetService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            IamPolicies = new IamPoliciesResource(this);
            Resources = new ResourcesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudasset";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://cloudasset.googleapis.com/";
        #else
            "https://cloudasset.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://cloudasset.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Asset API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Asset API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the IamPolicies resource.</summary>
        public virtual IamPoliciesResource IamPolicies { get; }

        /// <summary>Gets the Resources resource.</summary>
        public virtual ResourcesResource Resources { get; }
    }

    /// <summary>A base abstract class for CloudAsset requests.</summary>
    public abstract class CloudAssetBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudAssetBaseServiceRequest instance.</summary>
        protected CloudAssetBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudAsset parameter list.</summary>
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

    /// <summary>The "iamPolicies" collection of methods.</summary>
    public class IamPoliciesResource
    {
        private const string Resource = "iamPolicies";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public IamPoliciesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Searches all the IAM policies within a given accessible CRM scope (project/folder/organization). This RPC
        /// gives callers especially administrators the ability to search all the IAM policies within a scope, even if
        /// they don't have `.getIamPolicy` permission of all the IAM policies. Callers should have
        /// `cloud.assets.SearchAllIamPolicies` permission on the requested scope, otherwise the request will be
        /// rejected.
        /// </summary>
        /// <param name="scope">
        /// Required. The relative name of an asset. The search is limited to the resources within the `scope`. The
        /// allowed value must be: * Organization number (such as "organizations/123") * Folder number(such as
        /// "folders/1234") * Project number (such as "projects/12345") * Project id (such as "projects/abc")
        /// </param>
        public virtual SearchAllRequest SearchAll(string scope)
        {
            return new SearchAllRequest(service, scope);
        }

        /// <summary>
        /// Searches all the IAM policies within a given accessible CRM scope (project/folder/organization). This RPC
        /// gives callers especially administrators the ability to search all the IAM policies within a scope, even if
        /// they don't have `.getIamPolicy` permission of all the IAM policies. Callers should have
        /// `cloud.assets.SearchAllIamPolicies` permission on the requested scope, otherwise the request will be
        /// rejected.
        /// </summary>
        public class SearchAllRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1p1beta1.Data.SearchAllIamPoliciesResponse>
        {
            /// <summary>Constructs a new SearchAll request.</summary>
            public SearchAllRequest(Google.Apis.Services.IClientService service, string scope) : base(service)
            {
                Scope = scope;
                InitParameters();
            }

            /// <summary>
            /// Required. The relative name of an asset. The search is limited to the resources within the `scope`. The
            /// allowed value must be: * Organization number (such as "organizations/123") * Folder number(such as
            /// "folders/1234") * Project number (such as "projects/12345") * Project id (such as "projects/abc")
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("scope", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Scope { get; private set; }

            /// <summary>
            /// Optional. The page size for search result pagination. Page size is capped at 500 even if a larger value
            /// is given. If set to zero, server will pick an appropriate default. Returned results may be fewer than
            /// requested. When this happens, there could be more results as long as `next_page_token` is returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. If present, retrieve the next batch of results from the preceding call to this method.
            /// `page_token` must be the value of `next_page_token` from the previous response. The values of all other
            /// method parameters must be identical to those in the previous call.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Optional. The query statement. Examples: * "policy:myuser@mydomain.com" * "policy:(myuser@mydomain.com
            /// viewer)"
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "searchAll";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1p1beta1/{+scope}/iamPolicies:searchAll";

            /// <summary>Initializes SearchAll parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("scope", new Google.Apis.Discovery.Parameter
                {
                    Name = "scope",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+/[^/]+$",
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
                RequestParameters.Add("query", new Google.Apis.Discovery.Parameter
                {
                    Name = "query",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "resources" collection of methods.</summary>
    public class ResourcesResource
    {
        private const string Resource = "resources";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ResourcesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Searches all the resources within a given accessible CRM scope (project/folder/organization). This RPC gives
        /// callers especially administrators the ability to search all the resources within a scope, even if they don't
        /// have `.get` permission of all the resources. Callers should have `cloud.assets.SearchAllResources`
        /// permission on the requested scope, otherwise the request will be rejected.
        /// </summary>
        /// <param name="scope">
        /// Required. The relative name of an asset. The search is limited to the resources within the `scope`. The
        /// allowed value must be: * Organization number (such as "organizations/123") * Folder number(such as
        /// "folders/1234") * Project number (such as "projects/12345") * Project id (such as "projects/abc")
        /// </param>
        public virtual SearchAllRequest SearchAll(string scope)
        {
            return new SearchAllRequest(service, scope);
        }

        /// <summary>
        /// Searches all the resources within a given accessible CRM scope (project/folder/organization). This RPC gives
        /// callers especially administrators the ability to search all the resources within a scope, even if they don't
        /// have `.get` permission of all the resources. Callers should have `cloud.assets.SearchAllResources`
        /// permission on the requested scope, otherwise the request will be rejected.
        /// </summary>
        public class SearchAllRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1p1beta1.Data.SearchAllResourcesResponse>
        {
            /// <summary>Constructs a new SearchAll request.</summary>
            public SearchAllRequest(Google.Apis.Services.IClientService service, string scope) : base(service)
            {
                Scope = scope;
                InitParameters();
            }

            /// <summary>
            /// Required. The relative name of an asset. The search is limited to the resources within the `scope`. The
            /// allowed value must be: * Organization number (such as "organizations/123") * Folder number(such as
            /// "folders/1234") * Project number (such as "projects/12345") * Project id (such as "projects/abc")
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("scope", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Scope { get; private set; }

            /// <summary>
            /// Optional. A list of asset types that this request searches for. If empty, it will search all the
            /// supported asset types.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("assetTypes", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> AssetTypes { get; set; }

            /// <summary>
            /// Optional. A comma separated list of fields specifying the sorting order of the results. The default
            /// order is ascending. Add ` DESC` after the field name to indicate descending order. Redundant space
            /// characters are ignored. For example, ` location DESC , name `.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>
            /// Optional. The page size for search result pagination. Page size is capped at 500 even if a larger value
            /// is given. If set to zero, server will pick an appropriate default. Returned results may be fewer than
            /// requested. When this happens, there could be more results as long as `next_page_token` is returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. If present, then retrieve the next batch of results from the preceding call to this method.
            /// `page_token` must be the value of `next_page_token` from the previous response. The values of all other
            /// method parameters, must be identical to those in the previous call.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Optional. The query statement.</summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "searchAll";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1p1beta1/{+scope}/resources:searchAll";

            /// <summary>Initializes SearchAll parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("scope", new Google.Apis.Discovery.Parameter
                {
                    Name = "scope",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+/[^/]+$",
                });
                RequestParameters.Add("assetTypes", new Google.Apis.Discovery.Parameter
                {
                    Name = "assetTypes",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                {
                    Name = "orderBy",
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
                RequestParameters.Add("query", new Google.Apis.Discovery.Parameter
                {
                    Name = "query",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.CloudAsset.v1p1beta1.Data
{
    /// <summary>A response message for AssetService.AnalyzeIamPolicyLongrunning.</summary>
    public class AnalyzeIamPolicyLongrunningResponse : Google.Apis.Requests.IDirectResponseSchema
    {
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
    /// logging. It also exempts jose@example.com from DATA_READ logging, and aliya@example.com from DATA_WRITE logging.
    /// </summary>
    public class AuditConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for logging of each type of permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLogConfigs")]
        public virtual System.Collections.Generic.IList<AuditLogConfig> AuditLogConfigs { get; set; }

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
    public class AuditLogConfig : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Associates `members` with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// members in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// Specifies the identities requesting access for a Cloud Platform resource. `members` can have the following
        /// values: * `allUsers`: A special identifier that represents anyone who is on the internet; with or without a
        /// Google account. * `allAuthenticatedUsers`: A special identifier that represents anyone who is authenticated
        /// with a Google account or a service account. * `user:{emailid}`: An email address that represents a specific
        /// Google account. For example, `alice@example.com` . * `serviceAccount:{emailid}`: An email address that
        /// represents a service account. For example, `my-other-app@appspot.gserviceaccount.com`. * `group:{emailid}`:
        /// An email address that represents a Google group. For example, `admins@example.com`. *
        /// `deleted:user:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a user that
        /// has been recently deleted. For example, `alice@example.com?uid=123456789012345678901`. If the user is
        /// recovered, this value reverts to `user:{emailid}` and the recovered user retains the role in the binding. *
        /// `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a
        /// service account that has been recently deleted. For example,
        /// `my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted,
        /// this value reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the
        /// binding. * `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing
        /// a Google group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`.
        /// If the group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role
        /// in the binding. * `domain:{domain}`: The G Suite domain (primary) that represents all the users of that
        /// domain. For example, `google.com` or `example.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Role that is assigned to `members`. For example, `roles/viewer`, `roles/editor`, or `roles/owner`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Explanation about the IAM policy search result.</summary>
    public class Explanation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The map from roles to their included permission matching the permission query (e.g. containing
        /// `policy.role.permissions:`). Example role string: "roles/compute.instanceAdmin". The roles can also be found
        /// in the returned `policy` bindings. Note that the map is populated only if requesting with a permission
        /// query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchedPermissions")]
        public virtual System.Collections.Generic.IDictionary<string, Permissions> MatchedPermissions { get; set; }

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
    public class Expr : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>
    /// An asset in Google Cloud. An asset can be any resource in the Google Cloud [resource
    /// hierarchy](https://cloud.google.com/resource-manager/docs/cloud-platform-resource-hierarchy), a resource outside
    /// the Google Cloud resource hierarchy (such as Google Kubernetes Engine clusters and objects), or a policy (e.g.
    /// Cloud IAM policy). See [Supported asset
    /// types](https://cloud.google.com/asset-inventory/docs/supported-asset-types) for more information.
    /// </summary>
    public class GoogleCloudAssetV1p7beta1Asset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Please also refer to the [access level user
        /// guide](https://cloud.google.com/access-context-manager/docs/overview#access-levels).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLevel")]
        public virtual GoogleIdentityAccesscontextmanagerV1AccessLevel AccessLevel { get; set; }

        /// <summary>
        /// Please also refer to the [access policy user
        /// guide](https://cloud.google.com/access-context-manager/docs/overview#access-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessPolicy")]
        public virtual GoogleIdentityAccesscontextmanagerV1AccessPolicy AccessPolicy { get; set; }

        /// <summary>
        /// The ancestry path of an asset in Google Cloud [resource
        /// hierarchy](https://cloud.google.com/resource-manager/docs/cloud-platform-resource-hierarchy), represented as
        /// a list of relative resource names. An ancestry path starts with the closest ancestor in the hierarchy and
        /// ends at root. If the asset is a project, folder, or organization, the ancestry path starts from the asset
        /// itself. Example: `["projects/123456789", "folders/5432", "organizations/1234"]`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ancestors")]
        public virtual System.Collections.Generic.IList<string> Ancestors { get; set; }

        /// <summary>
        /// The type of the asset. Example: `compute.googleapis.com/Disk` See [Supported asset
        /// types](https://cloud.google.com/asset-inventory/docs/supported-asset-types) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetType")]
        public virtual string AssetType { get; set; }

        /// <summary>
        /// A representation of the Cloud IAM policy set on a Google Cloud resource. There can be a maximum of one Cloud
        /// IAM policy set on any given resource. In addition, Cloud IAM policies inherit their granted access scope
        /// from any policies set on parent resources in the resource hierarchy. Therefore, the effectively policy is
        /// the union of both the policy set on this resource and each policy set on all of the resource's ancestry
        /// resource levels in the hierarchy. See [this topic](https://cloud.google.com/iam/docs/policies#inheritance)
        /// for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iamPolicy")]
        public virtual Policy IamPolicy { get; set; }

        /// <summary>
        /// The full name of the asset. Example:
        /// `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1` See [Resource
        /// names](https://cloud.google.com/apis/design/resource_names#full_resource_name) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// A representation of an [organization
        /// policy](https://cloud.google.com/resource-manager/docs/organization-policy/overview#organization_policy).
        /// There can be more than one organization policy with different constraints set on a given resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgPolicy")]
        public virtual System.Collections.Generic.IList<GoogleCloudOrgpolicyV1Policy> OrgPolicy { get; set; }

        /// <summary>
        /// The related assets of the asset of one relationship type. One asset only represents one type of
        /// relationship.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedAssets")]
        public virtual GoogleCloudAssetV1p7beta1RelatedAssets RelatedAssets { get; set; }

        /// <summary>A representation of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual GoogleCloudAssetV1p7beta1Resource Resource { get; set; }

        /// <summary>
        /// Please also refer to the [service perimeter user
        /// guide](https://cloud.google.com/vpc-service-controls/docs/overview).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicePerimeter")]
        public virtual GoogleIdentityAccesscontextmanagerV1ServicePerimeter ServicePerimeter { get; set; }

        /// <summary>
        /// The last update timestamp of an asset. update_time is updated when create/update/delete operation is
        /// performed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An asset identify in Google Cloud which contains its name, type and ancestors. An asset can be any resource in
    /// the Google Cloud [resource
    /// hierarchy](https://cloud.google.com/resource-manager/docs/cloud-platform-resource-hierarchy), a resource outside
    /// the Google Cloud resource hierarchy (such as Google Kubernetes Engine clusters and objects), or a policy (e.g.
    /// Cloud IAM policy). See [Supported asset
    /// types](https://cloud.google.com/asset-inventory/docs/supported-asset-types) for more information.
    /// </summary>
    public class GoogleCloudAssetV1p7beta1RelatedAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ancestors of an asset in Google Cloud [resource
        /// hierarchy](https://cloud.google.com/resource-manager/docs/cloud-platform-resource-hierarchy), represented as
        /// a list of relative resource names. An ancestry path starts with the closest ancestor in the hierarchy and
        /// ends at root. Example: `["projects/123456789", "folders/5432", "organizations/1234"]`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ancestors")]
        public virtual System.Collections.Generic.IList<string> Ancestors { get; set; }

        /// <summary>
        /// The full name of the asset. Example:
        /// `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1` See [Resource
        /// names](https://cloud.google.com/apis/design/resource_names#full_resource_name) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public virtual string Asset { get; set; }

        /// <summary>
        /// The type of the asset. Example: `compute.googleapis.com/Disk` See [Supported asset
        /// types](https://cloud.google.com/asset-inventory/docs/supported-asset-types) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetType")]
        public virtual string AssetType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The detailed related assets with the `relationship_type`.</summary>
    public class GoogleCloudAssetV1p7beta1RelatedAssets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The peer resources of the relationship.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assets")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssetV1p7beta1RelatedAsset> Assets { get; set; }

        /// <summary>The detailed relation attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relationshipAttributes")]
        public virtual GoogleCloudAssetV1p7beta1RelationshipAttributes RelationshipAttributes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The relationship attributes which include `type`, `source_resource_type`, `target_resource_type` and `action`.
    /// </summary>
    public class GoogleCloudAssetV1p7beta1RelationshipAttributes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The detail of the relationship, e.g. `contains`, `attaches`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>The source asset type. Example: `compute.googleapis.com/Instance`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceResourceType")]
        public virtual string SourceResourceType { get; set; }

        /// <summary>The target asset type. Example: `compute.googleapis.com/Disk`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetResourceType")]
        public virtual string TargetResourceType { get; set; }

        /// <summary>The unique identifier of the relationship type. Example: `INSTANCE_TO_INSTANCEGROUP`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A representation of a Google Cloud resource.</summary>
    public class GoogleCloudAssetV1p7beta1Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The content of the resource, in which some sensitive fields are removed and may not be present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual System.Collections.Generic.IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// The URL of the discovery document containing the resource's JSON schema. Example:
        /// `https://www.googleapis.com/discovery/v1/apis/compute/v1/rest` This value is unspecified for resources that
        /// do not have an API based on a discovery document, such as Cloud Bigtable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discoveryDocumentUri")]
        public virtual string DiscoveryDocumentUri { get; set; }

        /// <summary>
        /// The JSON schema name listed in the discovery document. Example: `Project` This value is unspecified for
        /// resources that do not have an API based on a discovery document, such as Cloud Bigtable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discoveryName")]
        public virtual string DiscoveryName { get; set; }

        /// <summary>
        /// The location of the resource in Google Cloud, such as its zone and region. For more information, see
        /// https://cloud.google.com/about/locations/.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// The full name of the immediate parent of this resource. See [Resource
        /// Names](https://cloud.google.com/apis/design/resource_names#full_resource_name) for more information. For
        /// Google Cloud assets, this value is the parent resource defined in the [Cloud IAM policy
        /// hierarchy](https://cloud.google.com/iam/docs/overview#policy_hierarchy). Example:
        /// `//cloudresourcemanager.googleapis.com/projects/my_project_123` For third-party assets, this field may be
        /// set differently.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// The REST URL for accessing the resource. An HTTP `GET` request using this URL returns the resource itself.
        /// Example: `https://cloudresourcemanager.googleapis.com/v1/projects/my-project-123` This value is unspecified
        /// for resources without a REST API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUrl")]
        public virtual string ResourceUrl { get; set; }

        /// <summary>The API version. Example: `v1`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Used in `policy_type` to specify how `boolean_policy` will behave at this resource.</summary>
    public class GoogleCloudOrgpolicyV1BooleanPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If `true`, then the `Policy` is enforced. If `false`, then any configuration is acceptable. Suppose you have
        /// a `Constraint` `constraints/compute.disableSerialPortAccess` with `constraint_default` set to `ALLOW`. A
        /// `Policy` for that `Constraint` exhibits the following behavior: - If the `Policy` at this resource has
        /// enforced set to `false`, serial port connection attempts will be allowed. - If the `Policy` at this resource
        /// has enforced set to `true`, serial port connection attempts will be refused. - If the `Policy` at this
        /// resource is `RestoreDefault`, serial port connection attempts will be allowed. - If no `Policy` is set at
        /// this resource or anywhere higher in the resource hierarchy, serial port connection attempts will be allowed.
        /// - If no `Policy` is set at this resource, but one exists higher in the resource hierarchy, the behavior is
        /// as if the`Policy` were set at this resource. The following examples demonstrate the different possible
        /// layerings: Example 1 (nearest `Constraint` wins): `organizations/foo` has a `Policy` with: {enforced: false}
        /// `projects/bar` has no `Policy` set. The constraint at `projects/bar` and `organizations/foo` will not be
        /// enforced. Example 2 (enforcement gets replaced): `organizations/foo` has a `Policy` with: {enforced: false}
        /// `projects/bar` has a `Policy` with: {enforced: true} The constraint at `organizations/foo` is not enforced.
        /// The constraint at `projects/bar` is enforced. Example 3 (RestoreDefault): `organizations/foo` has a `Policy`
        /// with: {enforced: true} `projects/bar` has a `Policy` with: {RestoreDefault: {}} The constraint at
        /// `organizations/foo` is enforced. The constraint at `projects/bar` is not enforced, because
        /// `constraint_default` for the `Constraint` is `ALLOW`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enforced")]
        public virtual System.Nullable<bool> Enforced { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Used in `policy_type` to specify how `list_policy` behaves at this resource. `ListPolicy` can define specific
    /// values and subtrees of Cloud Resource Manager resource hierarchy (`Organizations`, `Folders`, `Projects`) that
    /// are allowed or denied by setting the `allowed_values` and `denied_values` fields. This is achieved by using the
    /// `under:` and optional `is:` prefixes. The `under:` prefix is used to denote resource subtree values. The `is:`
    /// prefix is used to denote specific values, and is required only if the value contains a ":". Values prefixed with
    /// "is:" are treated the same as values with no prefix. Ancestry subtrees must be in one of the following formats:
    /// - "projects/", e.g. "projects/tokyo-rain-123" - "folders/", e.g. "folders/1234" - "organizations/", e.g.
    /// "organizations/1234" The `supports_under` field of the associated `Constraint` defines whether ancestry prefixes
    /// can be used. You can set `allowed_values` and `denied_values` in the same `Policy` if `all_values` is
    /// `ALL_VALUES_UNSPECIFIED`. `ALLOW` or `DENY` are used to allow or deny all values. If `all_values` is set to
    /// either `ALLOW` or `DENY`, `allowed_values` and `denied_values` must be unset.
    /// </summary>
    public class GoogleCloudOrgpolicyV1ListPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The policy all_values state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allValues")]
        public virtual string AllValues { get; set; }

        /// <summary>
        /// List of values allowed at this resource. Can only be set if `all_values` is set to `ALL_VALUES_UNSPECIFIED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedValues")]
        public virtual System.Collections.Generic.IList<string> AllowedValues { get; set; }

        /// <summary>
        /// List of values denied at this resource. Can only be set if `all_values` is set to `ALL_VALUES_UNSPECIFIED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deniedValues")]
        public virtual System.Collections.Generic.IList<string> DeniedValues { get; set; }

        /// <summary>
        /// Determines the inheritance behavior for this `Policy`. By default, a `ListPolicy` set at a resource
        /// supersedes any `Policy` set anywhere up the resource hierarchy. However, if `inherit_from_parent` is set to
        /// `true`, then the values from the effective `Policy` of the parent resource are inherited, meaning the values
        /// set in this `Policy` are added to the values inherited up the hierarchy. Setting `Policy` hierarchies that
        /// inherit both allowed values and denied values isn't recommended in most circumstances to keep the
        /// configuration simple and understandable. However, it is possible to set a `Policy` with `allowed_values` set
        /// that inherits a `Policy` with `denied_values` set. In this case, the values that are allowed must be in
        /// `allowed_values` and not present in `denied_values`. For example, suppose you have a `Constraint`
        /// `constraints/serviceuser.services`, which has a `constraint_type` of `list_constraint`, and with
        /// `constraint_default` set to `ALLOW`. Suppose that at the Organization level, a `Policy` is applied that
        /// restricts the allowed API activations to {`E1`, `E2`}. Then, if a `Policy` is applied to a project below the
        /// Organization that has `inherit_from_parent` set to `false` and field all_values set to DENY, then an attempt
        /// to activate any API will be denied. The following examples demonstrate different possible layerings for
        /// `projects/bar` parented by `organizations/foo`: Example 1 (no inherited values): `organizations/foo` has a
        /// `Policy` with values: {allowed_values: "E1" allowed_values:"E2"} `projects/bar` has `inherit_from_parent`
        /// `false` and values: {allowed_values: "E3" allowed_values: "E4"} The accepted values at `organizations/foo`
        /// are `E1`, `E2`. The accepted values at `projects/bar` are `E3`, and `E4`. Example 2 (inherited values):
        /// `organizations/foo` has a `Policy` with values: {allowed_values: "E1" allowed_values:"E2"} `projects/bar`
        /// has a `Policy` with values: {value: "E3" value: "E4" inherit_from_parent: true} The accepted values at
        /// `organizations/foo` are `E1`, `E2`. The accepted values at `projects/bar` are `E1`, `E2`, `E3`, and `E4`.
        /// Example 3 (inheriting both allowed and denied values): `organizations/foo` has a `Policy` with values:
        /// {allowed_values: "E1" allowed_values: "E2"} `projects/bar` has a `Policy` with: {denied_values: "E1"} The
        /// accepted values at `organizations/foo` are `E1`, `E2`. The value accepted at `projects/bar` is `E2`. Example
        /// 4 (RestoreDefault): `organizations/foo` has a `Policy` with values: {allowed_values: "E1"
        /// allowed_values:"E2"} `projects/bar` has a `Policy` with values: {RestoreDefault: {}} The accepted values at
        /// `organizations/foo` are `E1`, `E2`. The accepted values at `projects/bar` are either all or none depending
        /// on the value of `constraint_default` (if `ALLOW`, all; if `DENY`, none). Example 5 (no policy inherits
        /// parent policy): `organizations/foo` has no `Policy` set. `projects/bar` has no `Policy` set. The accepted
        /// values at both levels are either all or none depending on the value of `constraint_default` (if `ALLOW`,
        /// all; if `DENY`, none). Example 6 (ListConstraint allowing all): `organizations/foo` has a `Policy` with
        /// values: {allowed_values: "E1" allowed_values: "E2"} `projects/bar` has a `Policy` with: {all: ALLOW} The
        /// accepted values at `organizations/foo` are `E1`, E2`. Any value is accepted at `projects/bar`. Example 7
        /// (ListConstraint allowing none): `organizations/foo` has a `Policy` with values: {allowed_values: "E1"
        /// allowed_values: "E2"} `projects/bar` has a `Policy` with: {all: DENY} The accepted values at
        /// `organizations/foo` are `E1`, E2`. No value is accepted at `projects/bar`. Example 10 (allowed and denied
        /// subtrees of Resource Manager hierarchy): Given the following resource hierarchy O1-&amp;gt;{F1, F2};
        /// F1-&amp;gt;{P1}; F2-&amp;gt;{P2, P3}, `organizations/foo` has a `Policy` with values: {allowed_values:
        /// "under:organizations/O1"} `projects/bar` has a `Policy` with: {allowed_values: "under:projects/P3"}
        /// {denied_values: "under:folders/F2"} The accepted values at `organizations/foo` are `organizations/O1`,
        /// `folders/F1`, `folders/F2`, `projects/P1`, `projects/P2`, `projects/P3`. The accepted values at
        /// `projects/bar` are `organizations/O1`, `folders/F1`, `projects/P1`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inheritFromParent")]
        public virtual System.Nullable<bool> InheritFromParent { get; set; }

        /// <summary>
        /// Optional. The Google Cloud Console will try to default to a configuration that matches the value specified
        /// in this `Policy`. If `suggested_value` is not set, it will inherit the value specified higher in the
        /// hierarchy, unless `inherit_from_parent` is `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedValue")]
        public virtual string SuggestedValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines a Cloud Organization `Policy` which is used to specify `Constraints` for configurations of Cloud
    /// Platform resources.
    /// </summary>
    public class GoogleCloudOrgpolicyV1Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>For boolean `Constraints`, whether to enforce the `Constraint` or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("booleanPolicy")]
        public virtual GoogleCloudOrgpolicyV1BooleanPolicy BooleanPolicy { get; set; }

        /// <summary>
        /// The name of the `Constraint` the `Policy` is configuring, for example, `constraints/serviceuser.services`. A
        /// [list of available constraints](/resource-manager/docs/organization-policy/org-policy-constraints) is
        /// available. Immutable after creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraint")]
        public virtual string Constraint { get; set; }

        /// <summary>
        /// An opaque tag indicating the current version of the `Policy`, used for concurrency control. When the
        /// `Policy` is returned from either a `GetPolicy` or a `ListOrgPolicy` request, this `etag` indicates the
        /// version of the current `Policy` to use when executing a read-modify-write loop. When the `Policy` is
        /// returned from a `GetEffectivePolicy` request, the `etag` will be unset. When the `Policy` is used in a
        /// `SetOrgPolicy` method, use the `etag` value that was returned from a `GetOrgPolicy` request as part of a
        /// read-modify-write loop for concurrency control. Not setting the `etag`in a `SetOrgPolicy` request will
        /// result in an unconditional write of the `Policy`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>List of values either allowed or disallowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listPolicy")]
        public virtual GoogleCloudOrgpolicyV1ListPolicy ListPolicy { get; set; }

        /// <summary>Restores the default behavior of the constraint; independent of `Constraint` type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restoreDefault")]
        public virtual GoogleCloudOrgpolicyV1RestoreDefault RestoreDefault { get; set; }

        /// <summary>
        /// The time stamp the `Policy` was previously updated. This is set by the server, not specified by the caller,
        /// and represents the last time a call to `SetOrgPolicy` was made for that `Policy`. Any value set by the
        /// client will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>Version of the `Policy`. Default version is 0;</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; }
    }

    /// <summary>
    /// Ignores policies set above this resource and restores the `constraint_default` enforcement behavior of the
    /// specific `Constraint` at this resource. Suppose that `constraint_default` is set to `ALLOW` for the `Constraint`
    /// `constraints/serviceuser.services`. Suppose that organization foo.com sets a `Policy` at their Organization
    /// resource node that restricts the allowed service activations to deny all service activations. They could then
    /// set a `Policy` with the `policy_type` `restore_default` on several experimental projects, restoring the
    /// `constraint_default` enforcement of the `Constraint` for only those projects, allowing those projects to have
    /// all services activated.
    /// </summary>
    public class GoogleCloudOrgpolicyV1RestoreDefault : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An `AccessLevel` is a label that can be applied to requests to Google Cloud services, along with a list of
    /// requirements necessary for the label to be applied.
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1AccessLevel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A `BasicLevel` composed of `Conditions`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basic")]
        public virtual GoogleIdentityAccesscontextmanagerV1BasicLevel Basic { get; set; }

        /// <summary>A `CustomLevel` written in the Common Expression Language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("custom")]
        public virtual GoogleIdentityAccesscontextmanagerV1CustomLevel Custom { get; set; }

        /// <summary>Description of the `AccessLevel` and its use. Does not affect behavior.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. Resource name for the Access Level. The `short_name` component must begin with a letter and only
        /// include alphanumeric and '_'. Format: `accessPolicies/{policy_id}/accessLevels/{short_name}`. The maximum
        /// length of the `short_name` component is 50 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Human readable title. Must be unique within the Policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `AccessPolicy` is a container for `AccessLevels` (which define the necessary attributes to use Google Cloud
    /// services) and `ServicePerimeters` (which define regions of services able to freely pass data within a
    /// perimeter). An access policy is globally visible within an organization, and the restrictions it specifies apply
    /// to all projects within an organization.
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1AccessPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. An opaque identifier for the current version of the `AccessPolicy`. This will always be a
        /// strongly validated etag, meaning that two Access Polices will be identical if and only if their etags are
        /// identical. Clients should not expect this to be in any specific format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Output only. Resource name of the `AccessPolicy`. Format: `accessPolicies/{policy_id}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The parent of this `AccessPolicy` in the Cloud Resource Hierarchy. Currently immutable once
        /// created. Format: `organizations/{organization_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>Required. Human readable title. Does not affect behavior.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }
    }

    /// <summary>Identification for an API Operation.</summary>
    public class GoogleIdentityAccesscontextmanagerV1ApiOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// API methods or permissions to allow. Method or permission must belong to the service specified by
        /// `service_name` field. A single MethodSelector entry with `*` specified for the `method` field will allow all
        /// methods AND permissions for the service specified in `service_name`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("methodSelectors")]
        public virtual System.Collections.Generic.IList<GoogleIdentityAccesscontextmanagerV1MethodSelector> MethodSelectors { get; set; }

        /// <summary>
        /// The name of the API whose methods or permissions the IngressPolicy or EgressPolicy want to allow. A single
        /// ApiOperation with `service_name` field set to `*` will allow all methods AND permissions for all services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`BasicLevel` is an `AccessLevel` using a set of recommended features.</summary>
    public class GoogleIdentityAccesscontextmanagerV1BasicLevel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// How the `conditions` list should be combined to determine if a request is granted this `AccessLevel`. If AND
        /// is used, each `Condition` in `conditions` must be satisfied for the `AccessLevel` to be applied. If OR is
        /// used, at least one `Condition` in `conditions` must be satisfied for the `AccessLevel` to be applied.
        /// Default behavior is AND.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("combiningFunction")]
        public virtual string CombiningFunction { get; set; }

        /// <summary>Required. A list of requirements for the `AccessLevel` to be granted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleIdentityAccesscontextmanagerV1Condition> Conditions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A condition necessary for an `AccessLevel` to be granted. The Condition is an AND over its fields. So a
    /// Condition is true if: 1) the request IP is from one of the listed subnetworks AND 2) the originating device
    /// complies with the listed device policy AND 3) all listed access levels are granted AND 4) the request was sent
    /// at a time allowed by the DateTimeRestriction.
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1Condition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Device specific restrictions, all restrictions must hold for the Condition to be true. If not specified, all
        /// devices are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devicePolicy")]
        public virtual GoogleIdentityAccesscontextmanagerV1DevicePolicy DevicePolicy { get; set; }

        /// <summary>
        /// CIDR block IP subnetwork specification. May be IPv4 or IPv6. Note that for a CIDR IP address block, the
        /// specified IP address portion must be properly truncated (i.e. all the host bits must be zero) or the input
        /// is considered malformed. For example, "192.0.2.0/24" is accepted but "192.0.2.1/24" is not. Similarly, for
        /// IPv6, "2001:db8::/32" is accepted whereas "2001:db8::1/32" is not. The originating IP of a request must be
        /// in one of the listed subnets in order for this Condition to be true. If empty, all IP addresses are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipSubnetworks")]
        public virtual System.Collections.Generic.IList<string> IpSubnetworks { get; set; }

        /// <summary>
        /// The request must be made by one of the provided user or service accounts. Groups are not supported. Syntax:
        /// `user:{emailid}` `serviceAccount:{emailid}` If not specified, a request may come from any user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Whether to negate the Condition. If true, the Condition becomes a NAND over its non-empty fields, each field
        /// must be false for the Condition overall to be satisfied. Defaults to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negate")]
        public virtual System.Nullable<bool> Negate { get; set; }

        /// <summary>
        /// The request must originate from one of the provided countries/regions. Must be valid ISO 3166-1 alpha-2
        /// codes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regions")]
        public virtual System.Collections.Generic.IList<string> Regions { get; set; }

        /// <summary>
        /// A list of other access levels defined in the same `Policy`, referenced by resource name. Referencing an
        /// `AccessLevel` which does not exist is an error. All access levels listed must be granted for the Condition
        /// to be true. Example: "`accessPolicies/MY_POLICY/accessLevels/LEVEL_NAME"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiredAccessLevels")]
        public virtual System.Collections.Generic.IList<string> RequiredAccessLevels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `CustomLevel` is an `AccessLevel` using the Cloud Common Expression Language to represent the necessary
    /// conditions for the level to apply to a request. See CEL spec at: https://github.com/google/cel-spec
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1CustomLevel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A Cloud CEL expression evaluating to a boolean.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expr")]
        public virtual Expr Expr { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `DevicePolicy` specifies device specific restrictions necessary to acquire a given access level. A
    /// `DevicePolicy` specifies requirements for requests from devices to be granted access levels, it does not do any
    /// enforcement on the device. `DevicePolicy` acts as an AND over all specified fields, and each repeated field is
    /// an OR over its elements. Any unset fields are ignored. For example, if the proto is { os_type : DESKTOP_WINDOWS,
    /// os_type : DESKTOP_LINUX, encryption_status: ENCRYPTED}, then the DevicePolicy will be true for requests
    /// originating from encrypted Linux desktops and encrypted Windows desktops.
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1DevicePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Allowed device management levels, an empty list allows all management levels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedDeviceManagementLevels")]
        public virtual System.Collections.Generic.IList<string> AllowedDeviceManagementLevels { get; set; }

        /// <summary>Allowed encryptions statuses, an empty list allows all statuses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedEncryptionStatuses")]
        public virtual System.Collections.Generic.IList<string> AllowedEncryptionStatuses { get; set; }

        /// <summary>Allowed OS versions, an empty list allows all types and all versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osConstraints")]
        public virtual System.Collections.Generic.IList<GoogleIdentityAccesscontextmanagerV1OsConstraint> OsConstraints { get; set; }

        /// <summary>Whether the device needs to be approved by the customer admin.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireAdminApproval")]
        public virtual System.Nullable<bool> RequireAdminApproval { get; set; }

        /// <summary>Whether the device needs to be corp owned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireCorpOwned")]
        public virtual System.Nullable<bool> RequireCorpOwned { get; set; }

        /// <summary>
        /// Whether or not screenlock is required for the DevicePolicy to be true. Defaults to `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireScreenlock")]
        public virtual System.Nullable<bool> RequireScreenlock { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines the conditions under which an EgressPolicy matches a request. Conditions based on information about the
    /// source of the request. Note that if the destination of the request is also protected by a ServicePerimeter, then
    /// that ServicePerimeter must have an IngressPolicy which allows access in order for this request to succeed.
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1EgressFrom : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of identities that are allowed access through this [EgressPolicy]. Should be in the format of email
        /// address. The email address should represent individual user or service account only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identities")]
        public virtual System.Collections.Generic.IList<string> Identities { get; set; }

        /// <summary>
        /// Specifies the type of identities that are allowed access to outside the perimeter. If left unspecified, then
        /// members of `identities` field will be allowed access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityType")]
        public virtual string IdentityType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Policy for egress from perimeter. EgressPolicies match requests based on `egress_from` and `egress_to` stanzas.
    /// For an EgressPolicy to match, both `egress_from` and `egress_to` stanzas must be matched. If an EgressPolicy
    /// matches a request, the request is allowed to span the ServicePerimeter boundary. For example, an EgressPolicy
    /// can be used to allow VMs on networks within the ServicePerimeter to access a defined set of projects outside the
    /// perimeter in certain contexts (e.g. to read data from a Cloud Storage bucket or query against a BigQuery
    /// dataset). EgressPolicies are concerned with the *resources* that a request relates as well as the API services
    /// and API actions being used. They do not related to the direction of data movement. More detailed documentation
    /// for this concept can be found in the descriptions of EgressFrom and EgressTo.
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1EgressPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Defines conditions on the source of a request causing this EgressPolicy to apply.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("egressFrom")]
        public virtual GoogleIdentityAccesscontextmanagerV1EgressFrom EgressFrom { get; set; }

        /// <summary>
        /// Defines the conditions on the ApiOperation and destination resources that cause this EgressPolicy to apply.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("egressTo")]
        public virtual GoogleIdentityAccesscontextmanagerV1EgressTo EgressTo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines the conditions under which an EgressPolicy matches a request. Conditions are based on information about
    /// the ApiOperation intended to be performed on the `resources` specified. Note that if the destination of the
    /// request is also protected by a ServicePerimeter, then that ServicePerimeter must have an IngressPolicy which
    /// allows access in order for this request to succeed. The request must match `operations` AND `resources` fields
    /// in order to be allowed egress out of the perimeter.
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1EgressTo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of ApiOperations allowed to be performed by the sources specified in the corresponding EgressFrom. A
        /// request matches if it uses an operation/service in this list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<GoogleIdentityAccesscontextmanagerV1ApiOperation> Operations { get; set; }

        /// <summary>
        /// A list of resources, currently only projects in the form `projects/`, that are allowed to be accessed by
        /// sources defined in the corresponding EgressFrom. A request matches if it contains a resource in this list.
        /// If `*` is specified for `resources`, then this EgressTo rule will authorize access to all resources outside
        /// the perimeter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<string> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines the conditions under which an IngressPolicy matches a request. Conditions are based on information about
    /// the source of the request. The request must satisfy what is defined in `sources` AND identity related fields in
    /// order to match.
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1IngressFrom : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of identities that are allowed access through this ingress policy. Should be in the format of email
        /// address. The email address should represent individual user or service account only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identities")]
        public virtual System.Collections.Generic.IList<string> Identities { get; set; }

        /// <summary>
        /// Specifies the type of identities that are allowed access from outside the perimeter. If left unspecified,
        /// then members of `identities` field will be allowed access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityType")]
        public virtual string IdentityType { get; set; }

        /// <summary>Sources that this IngressPolicy authorizes access from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<GoogleIdentityAccesscontextmanagerV1IngressSource> Sources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Policy for ingress into ServicePerimeter. IngressPolicies match requests based on `ingress_from` and
    /// `ingress_to` stanzas. For an ingress policy to match, both the `ingress_from` and `ingress_to` stanzas must be
    /// matched. If an IngressPolicy matches a request, the request is allowed through the perimeter boundary from
    /// outside the perimeter. For example, access from the internet can be allowed either based on an AccessLevel or,
    /// for traffic hosted on Google Cloud, the project of the source network. For access from private networks, using
    /// the project of the hosting network is required. Individual ingress policies can be limited by restricting which
    /// services and/or actions they match using the `ingress_to` field.
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1IngressPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Defines the conditions on the source of a request causing this IngressPolicy to apply.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressFrom")]
        public virtual GoogleIdentityAccesscontextmanagerV1IngressFrom IngressFrom { get; set; }

        /// <summary>
        /// Defines the conditions on the ApiOperation and request destination that cause this IngressPolicy to apply.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressTo")]
        public virtual GoogleIdentityAccesscontextmanagerV1IngressTo IngressTo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The source that IngressPolicy authorizes access from.</summary>
    public class GoogleIdentityAccesscontextmanagerV1IngressSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An AccessLevel resource name that allow resources within the ServicePerimeters to be accessed from the
        /// internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent
        /// AccessLevel will cause an error. If no AccessLevel names are listed, resources within the perimeter can only
        /// be accessed via Google Cloud calls with request origins within the perimeter. Example:
        /// `accessPolicies/MY_POLICY/accessLevels/MY_LEVEL`. If a single `*` is specified for `access_level`, then all
        /// IngressSources will be allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLevel")]
        public virtual string AccessLevel { get; set; }

        /// <summary>
        /// A Google Cloud resource that is allowed to ingress the perimeter. Requests from these resources will be
        /// allowed to access perimeter data. Currently only projects are allowed. Format: `projects/{project_number}`
        /// The project may be in any Google Cloud organization, not just the organization that the perimeter is defined
        /// in. `*` is not allowed, the case of allowing all Google Cloud resources only is not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines the conditions under which an IngressPolicy matches a request. Conditions are based on information about
    /// the ApiOperation intended to be performed on the target resource of the request. The request must satisfy what
    /// is defined in `operations` AND `resources` in order to match.
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1IngressTo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of ApiOperations allowed to be performed by the sources specified in corresponding IngressFrom in
        /// this ServicePerimeter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<GoogleIdentityAccesscontextmanagerV1ApiOperation> Operations { get; set; }

        /// <summary>
        /// A list of resources, currently only projects in the form `projects/`, protected by this ServicePerimeter
        /// that are allowed to be accessed by sources defined in the corresponding IngressFrom. If a single `*` is
        /// specified, then access to all resources inside the perimeter are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<string> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An allowed method or permission of a service specified in ApiOperation.</summary>
    public class GoogleIdentityAccesscontextmanagerV1MethodSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Value for `method` should be a valid method name for the corresponding `service_name` in ApiOperation. If
        /// `*` used as value for `method`, then ALL methods and permissions are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; }

        /// <summary>
        /// Value for `permission` should be a valid Cloud IAM permission for the corresponding `service_name` in
        /// ApiOperation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permission")]
        public virtual string Permission { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A restriction on the OS type and version of devices making requests.</summary>
    public class GoogleIdentityAccesscontextmanagerV1OsConstraint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The minimum allowed OS version. If not set, any version of this OS satisfies the constraint. Format:
        /// `"major.minor.patch"`. Examples: `"10.5.301"`, `"9.2.1"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumVersion")]
        public virtual string MinimumVersion { get; set; }

        /// <summary>Required. The allowed OS type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osType")]
        public virtual string OsType { get; set; }

        /// <summary>
        /// Only allows requests from devices with a verified Chrome OS. Verifications includes requirements that the
        /// device is enterprise-managed, conformant to domain policies, and the caller has permission to call the API
        /// targeted by the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireVerifiedChromeOs")]
        public virtual System.Nullable<bool> RequireVerifiedChromeOs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `ServicePerimeter` describes a set of Google Cloud resources which can freely import and export data amongst
    /// themselves, but not export outside of the `ServicePerimeter`. If a request with a source within this
    /// `ServicePerimeter` has a target outside of the `ServicePerimeter`, the request will be blocked. Otherwise the
    /// request is allowed. There are two types of Service Perimeter - Regular and Bridge. Regular Service Perimeters
    /// cannot overlap, a single Google Cloud project can only belong to a single regular Service Perimeter. Service
    /// Perimeter Bridges can contain only Google Cloud projects as members, a single Google Cloud project may belong to
    /// multiple Service Perimeter Bridges.
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1ServicePerimeter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the `ServicePerimeter` and its use. Does not affect behavior.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. Resource name for the ServicePerimeter. The `short_name` component must begin with a letter and
        /// only include alphanumeric and '_'. Format: `accessPolicies/{policy_id}/servicePerimeters/{short_name}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Perimeter type indicator. A single project is allowed to be a member of single regular perimeter, but
        /// multiple service perimeter bridges. A project cannot be a included in a perimeter bridge without being
        /// included in regular perimeter. For perimeter bridges, the restricted service list as well as access level
        /// lists must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("perimeterType")]
        public virtual string PerimeterType { get; set; }

        /// <summary>
        /// Proposed (or dry run) ServicePerimeter configuration. This configuration allows to specify and test
        /// ServicePerimeter configuration without enforcing actual access restrictions. Only allowed to be set when the
        /// "use_explicit_dry_run_spec" flag is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual GoogleIdentityAccesscontextmanagerV1ServicePerimeterConfig Spec { get; set; }

        /// <summary>
        /// Current ServicePerimeter configuration. Specifies sets of resources, restricted services and access levels
        /// that determine perimeter content and boundaries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleIdentityAccesscontextmanagerV1ServicePerimeterConfig Status { get; set; }

        /// <summary>Human readable title. Must be unique within the Policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// Use explicit dry run spec flag. Ordinarily, a dry-run spec implicitly exists for all Service Perimeters, and
        /// that spec is identical to the status for those Service Perimeters. When this flag is set, it inhibits the
        /// generation of the implicit spec, thereby allowing the user to explicitly provide a configuration ("spec") to
        /// use in a dry-run version of the Service Perimeter. This allows the user to test changes to the enforced
        /// config ("status") without actually enforcing them. This testing is done through analyzing the differences
        /// between currently enforced and suggested restrictions. use_explicit_dry_run_spec must bet set to True if any
        /// of the fields in the spec are set to non-default values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useExplicitDryRunSpec")]
        public virtual System.Nullable<bool> UseExplicitDryRunSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `ServicePerimeterConfig` specifies a set of Google Cloud resources that describe specific Service Perimeter
    /// configuration.
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1ServicePerimeterConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of `AccessLevel` resource names that allow resources within the `ServicePerimeter` to be accessed
        /// from the internet. `AccessLevels` listed must be in the same policy as this `ServicePerimeter`. Referencing
        /// a nonexistent `AccessLevel` is a syntax error. If no `AccessLevel` names are listed, resources within the
        /// perimeter can only be accessed via Google Cloud calls with request origins within the perimeter. Example:
        /// `"accessPolicies/MY_POLICY/accessLevels/MY_LEVEL"`. For Service Perimeter Bridge, must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLevels")]
        public virtual System.Collections.Generic.IList<string> AccessLevels { get; set; }

        /// <summary>
        /// List of EgressPolicies to apply to the perimeter. A perimeter may have multiple EgressPolicies, each of
        /// which is evaluated separately. Access is granted if any EgressPolicy grants it. Must be empty for a
        /// perimeter bridge.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("egressPolicies")]
        public virtual System.Collections.Generic.IList<GoogleIdentityAccesscontextmanagerV1EgressPolicy> EgressPolicies { get; set; }

        /// <summary>
        /// List of IngressPolicies to apply to the perimeter. A perimeter may have multiple IngressPolicies, each of
        /// which is evaluated separately. Access is granted if any Ingress Policy grants it. Must be empty for a
        /// perimeter bridge.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressPolicies")]
        public virtual System.Collections.Generic.IList<GoogleIdentityAccesscontextmanagerV1IngressPolicy> IngressPolicies { get; set; }

        /// <summary>
        /// A list of Google Cloud resources that are inside of the service perimeter. Currently only projects are
        /// allowed. Format: `projects/{project_number}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<string> Resources { get; set; }

        /// <summary>
        /// Google Cloud services that are subject to the Service Perimeter restrictions. For example, if
        /// `storage.googleapis.com` is specified, access to the storage buckets inside the perimeter must meet the
        /// perimeter's access restrictions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictedServices")]
        public virtual System.Collections.Generic.IList<string> RestrictedServices { get; set; }

        /// <summary>Configuration for APIs allowed within Perimeter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcAccessibleServices")]
        public virtual GoogleIdentityAccesscontextmanagerV1VpcAccessibleServices VpcAccessibleServices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies how APIs are allowed to communicate within the Service Perimeter.</summary>
    public class GoogleIdentityAccesscontextmanagerV1VpcAccessibleServices : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of APIs usable within the Service Perimeter. Must be empty unless 'enable_restriction' is True. You
        /// can specify a list of individual services, as well as include the 'RESTRICTED-SERVICES' value, which
        /// automatically includes all of the services protected by the perimeter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedServices")]
        public virtual System.Collections.Generic.IList<string> AllowedServices { get; set; }

        /// <summary>
        /// Whether to restrict API calls within the Service Perimeter to the list of APIs specified in
        /// 'allowed_services'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableRestriction")]
        public virtual System.Nullable<bool> EnableRestriction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result for an IAM policy search.</summary>
    public class IamPolicySearchResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Explanation about the IAM policy search result. It contains additional information that explains why the
        /// search result matches the query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explanation")]
        public virtual Explanation Explanation { get; set; }

        /// <summary>
        /// The IAM policy attached to the specified resource. Note that the original IAM policy can contain multiple
        /// bindings. This only contains the bindings that match the given query. For queries that don't contain a
        /// constraint on policies (e.g. an empty query), this contains all the bindings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>
        /// The project that the associated Google Cloud resource belongs to, in the form of
        /// `projects/{project_number}`. If an IAM policy is set on a resource -- such as a Compute Engine instance or a
        /// Cloud Storage bucket -- the project field will indicate the project that contains the resource. If an IAM
        /// policy is set on a folder or orgnization, the project field will be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>
        /// The [full resource name](https://cloud.google.com/apis/design/resource_names#full_resource_name) of the
        /// resource associated with this IAM policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>IAM permissions.</summary>
    public class Permissions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of permissions. Example permission string: "compute.disk.get".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> PermissionsValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Identity and Access Management (IAM) policy, which specifies access controls for Google Cloud resources. A
    /// `Policy` is a collection of `bindings`. A `binding` binds one or more `members` to a single `role`. Members can
    /// be user accounts, service accounts, Google groups, and domains (such as G Suite). A `role` is a named list of
    /// permissions; each `role` can be an IAM predefined role or a user-created custom role. For some types of Google
    /// Cloud resources, a `binding` can also specify a `condition`, which is a logical expression that allows access to
    /// a resource only if the expression evaluates to `true`. A condition can add constraints based on attributes of
    /// the request, the resource, or both. To learn which resources support conditions in their IAM policies, see the
    /// [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:** {
    /// "bindings": [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 } **YAML example:**
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') - etag: BwWWja0YfJA= - version: 3 For a description of IAM and its
    /// features, see the [IAM documentation](https://cloud.google.com/iam/docs/).
    /// </summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<AuditConfig> AuditConfigs { get; set; }

        /// <summary>
        /// Associates a list of `members` to a `role`. Optionally, may specify a `condition` that determines how and
        /// when the `bindings` are applied. Each of the `bindings` must contain at least one member.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<Binding> Bindings { get; set; }

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

    /// <summary>Search all IAM policies response.</summary>
    public class SearchAllIamPoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Set if there are more results than those appearing in this response; to get the next set of results, call
        /// this method again, using this value as the `page_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// A list of IamPolicy that match the search query. Related information such as the associated resource is
        /// returned along with the policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<IamPolicySearchResult> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Search all resources response.</summary>
    public class SearchAllResourcesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If there are more results than those appearing in this response, then `next_page_token` is included. To get
        /// the next set of results, call this method again using the value of `next_page_token` as `page_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of resource that match the search query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<StandardResourceMetadata> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The standard metadata of a cloud resource.</summary>
    public class StandardResourceMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Additional searchable attributes of this resource. Informational only. The exact set of attributes is
        /// subject to change. For example: project id, DNS name etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalAttributes")]
        public virtual System.Collections.Generic.IList<string> AdditionalAttributes { get; set; }

        /// <summary>The type of this resource. For example: "compute.googleapis.com/Disk".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetType")]
        public virtual string AssetType { get; set; }

        /// <summary>
        /// One or more paragraphs of text description of this resource. Maximum length could be up to 1M bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The display name of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Labels associated with this resource. See [Labelling and grouping GCP
        /// resources](https://cloud.google.com/blog/products/gcp/labelling-and-grouping-your-google-cloud-platform-resources)
        /// for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Location can be "global", regional like "us-east1", or zonal like "us-west1-b".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// The full resource name. For example:
        /// `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1`. See [Resource
        /// Names](https://cloud.google.com/apis/design/resource_names#full_resource_name) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Network tags associated with this resource. Like labels, network tags are a type of annotations used to
        /// group GCP resources. See [Labelling GCP
        /// resources](lhttps://cloud.google.com/blog/products/gcp/labelling-and-grouping-your-google-cloud-platform-resources)
        /// for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkTags")]
        public virtual System.Collections.Generic.IList<string> NetworkTags { get; set; }

        /// <summary>The project that this resource belongs to, in the form of `projects/{project_number}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
