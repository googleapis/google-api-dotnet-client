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

namespace Google.Apis.Iam.v2beta
{
    /// <summary>The Iam Service.</summary>
    public class IamService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public IamService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public IamService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Policies = new PoliciesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "iam";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://iam.googleapis.com/";
        #else
            "https://iam.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://iam.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Identity and Access Management (IAM) API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>
        /// Available OAuth 2.0 scope constants for use with the Identity and Access Management (IAM) API.
        /// </summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Policies resource.</summary>
        public virtual PoliciesResource Policies { get; }
    }

    /// <summary>A base abstract class for Iam requests.</summary>
    public abstract class IamBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new IamBaseServiceRequest instance.</summary>
        protected IamBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Iam parameter list.</summary>
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
            Operations = new OperationsResource(service);
        }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

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
            /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
            /// result at intervals as recommended by the API service.
            /// </summary>
            /// <param name="name">The name of the operation resource.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
            /// result at intervals as recommended by the API service.
            /// </summary>
            public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v2beta.Data.GoogleLongrunningOperation>
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
                public override string RestPath => "v2beta/{+name}";

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
                        Pattern = @"^policies/[^/]+/[^/]+/[^/]+/operations/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Creates a policy.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. The resource that the policy is attached to, along with the kind of policy to create. Format:
        /// `policies/{attachment_point}/denypolicies` The attachment point is identified by its URL-encoded full
        /// resource name, which means that the forward-slash character, `/`, must be written as `%2F`. For example,
        /// `policies/cloudresourcemanager.googleapis.com%2Fprojects%2Fmy-project/denypolicies`. For organizations and
        /// folders, use the numeric ID in the full resource name. For projects, you can use the alphanumeric or the
        /// numeric ID.
        /// </param>
        public virtual CreatePolicyRequest CreatePolicy(Google.Apis.Iam.v2beta.Data.GoogleIamV2betaPolicy body, string parent)
        {
            return new CreatePolicyRequest(service, body, parent);
        }

        /// <summary>Creates a policy.</summary>
        public class CreatePolicyRequest : IamBaseServiceRequest<Google.Apis.Iam.v2beta.Data.GoogleLongrunningOperation>
        {
            /// <summary>Constructs a new CreatePolicy request.</summary>
            public CreatePolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v2beta.Data.GoogleIamV2betaPolicy body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource that the policy is attached to, along with the kind of policy to create. Format:
            /// `policies/{attachment_point}/denypolicies` The attachment point is identified by its URL-encoded full
            /// resource name, which means that the forward-slash character, `/`, must be written as `%2F`. For example,
            /// `policies/cloudresourcemanager.googleapis.com%2Fprojects%2Fmy-project/denypolicies`. For organizations
            /// and folders, use the numeric ID in the full resource name. For projects, you can use the alphanumeric or
            /// the numeric ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// The ID to use for this policy, which will become the final component of the policy's resource name. The
            /// ID must contain 3 to 63 characters. It can contain lowercase letters and numbers, as well as dashes
            /// (`-`) and periods (`.`). The first character must be a lowercase letter.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("policyId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PolicyId { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Iam.v2beta.Data.GoogleIamV2betaPolicy Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "createPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+parent}";

            /// <summary>Initializes CreatePolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^policies/[^/]+/[^/]+$",
                });
                RequestParameters.Add("policyId", new Google.Apis.Discovery.Parameter
                {
                    Name = "policyId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Deletes a policy. This action is permanent.</summary>
        /// <param name="name">
        /// Required. The resource name of the policy to delete. Format:
        /// `policies/{attachment_point}/denypolicies/{policy_id}` Use the URL-encoded full resource name, which means
        /// that the forward-slash character, `/`, must be written as `%2F`. For example,
        /// `policies/cloudresourcemanager.googleapis.com%2Fprojects%2Fmy-project/denypolicies/my-policy`. For
        /// organizations and folders, use the numeric ID in the full resource name. For projects, you can use the
        /// alphanumeric or the numeric ID.
        /// </param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>Deletes a policy. This action is permanent.</summary>
        public class DeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v2beta.Data.GoogleLongrunningOperation>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of the policy to delete. Format:
            /// `policies/{attachment_point}/denypolicies/{policy_id}` Use the URL-encoded full resource name, which
            /// means that the forward-slash character, `/`, must be written as `%2F`. For example,
            /// `policies/cloudresourcemanager.googleapis.com%2Fprojects%2Fmy-project/denypolicies/my-policy`. For
            /// organizations and folders, use the numeric ID in the full resource name. For projects, you can use the
            /// alphanumeric or the numeric ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Optional. The expected `etag` of the policy to delete. If the value does not match the value that is
            /// stored in IAM, the request fails with a `409` error code and `ABORTED` status. If you omit this field,
            /// the policy is deleted regardless of its current `etag`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Etag { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+name}";

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
                    Pattern = @"^policies/[^/]+/[^/]+/[^/]+$",
                });
                RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                {
                    Name = "etag",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets a policy.</summary>
        /// <param name="name">
        /// Required. The resource name of the policy to retrieve. Format:
        /// `policies/{attachment_point}/denypolicies/{policy_id}` Use the URL-encoded full resource name, which means
        /// that the forward-slash character, `/`, must be written as `%2F`. For example,
        /// `policies/cloudresourcemanager.googleapis.com%2Fprojects%2Fmy-project/denypolicies/my-policy`. For
        /// organizations and folders, use the numeric ID in the full resource name. For projects, you can use the
        /// alphanumeric or the numeric ID.
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Gets a policy.</summary>
        public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v2beta.Data.GoogleIamV2betaPolicy>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of the policy to retrieve. Format:
            /// `policies/{attachment_point}/denypolicies/{policy_id}` Use the URL-encoded full resource name, which
            /// means that the forward-slash character, `/`, must be written as `%2F`. For example,
            /// `policies/cloudresourcemanager.googleapis.com%2Fprojects%2Fmy-project/denypolicies/my-policy`. For
            /// organizations and folders, use the numeric ID in the full resource name. For projects, you can use the
            /// alphanumeric or the numeric ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+name}";

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
                    Pattern = @"^policies/[^/]+/[^/]+/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Retrieves the policies of the specified kind that are attached to a resource. The response lists only policy
        /// metadata. In particular, policy rules are omitted.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource that the policy is attached to, along with the kind of policy to list. Format:
        /// `policies/{attachment_point}/denypolicies` The attachment point is identified by its URL-encoded full
        /// resource name, which means that the forward-slash character, `/`, must be written as `%2F`. For example,
        /// `policies/cloudresourcemanager.googleapis.com%2Fprojects%2Fmy-project/denypolicies`. For organizations and
        /// folders, use the numeric ID in the full resource name. For projects, you can use the alphanumeric or the
        /// numeric ID.
        /// </param>
        public virtual ListPoliciesRequest ListPolicies(string parent)
        {
            return new ListPoliciesRequest(service, parent);
        }

        /// <summary>
        /// Retrieves the policies of the specified kind that are attached to a resource. The response lists only policy
        /// metadata. In particular, policy rules are omitted.
        /// </summary>
        public class ListPoliciesRequest : IamBaseServiceRequest<Google.Apis.Iam.v2beta.Data.GoogleIamV2betaListPoliciesResponse>
        {
            /// <summary>Constructs a new ListPolicies request.</summary>
            public ListPoliciesRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
            {
                Parent = parent;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource that the policy is attached to, along with the kind of policy to list. Format:
            /// `policies/{attachment_point}/denypolicies` The attachment point is identified by its URL-encoded full
            /// resource name, which means that the forward-slash character, `/`, must be written as `%2F`. For example,
            /// `policies/cloudresourcemanager.googleapis.com%2Fprojects%2Fmy-project/denypolicies`. For organizations
            /// and folders, use the numeric ID in the full resource name. For projects, you can use the alphanumeric or
            /// the numeric ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// The maximum number of policies to return. IAM ignores this value and uses the value 1000.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A page token received in a ListPoliciesResponse. Provide this token to retrieve the next page.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listPolicies";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+parent}";

            /// <summary>Initializes ListPolicies parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^policies/[^/]+/[^/]+$",
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
        /// Updates the specified policy. You can update only the rules and the display name for the policy. To update a
        /// policy, you should use a read-modify-write loop: 1. Use GetPolicy to read the current version of the policy.
        /// 2. Modify the policy as needed. 3. Use `UpdatePolicy` to write the updated policy. This pattern helps
        /// prevent conflicts between concurrent updates.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Immutable. The resource name of the `Policy`, which must be unique. Format:
        /// `policies/{attachment_point}/denypolicies/{policy_id}` The attachment point is identified by its URL-encoded
        /// full resource name, which means that the forward-slash character, `/`, must be written as `%2F`. For
        /// example, `policies/cloudresourcemanager.googleapis.com%2Fprojects%2Fmy-project/denypolicies/my-deny-policy`.
        /// For organizations and folders, use the numeric ID in the full resource name. For projects, requests can use
        /// the alphanumeric or the numeric ID. Responses always contain the numeric ID.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Iam.v2beta.Data.GoogleIamV2betaPolicy body, string name)
        {
            return new UpdateRequest(service, body, name);
        }

        /// <summary>
        /// Updates the specified policy. You can update only the rules and the display name for the policy. To update a
        /// policy, you should use a read-modify-write loop: 1. Use GetPolicy to read the current version of the policy.
        /// 2. Modify the policy as needed. 3. Use `UpdatePolicy` to write the updated policy. This pattern helps
        /// prevent conflicts between concurrent updates.
        /// </summary>
        public class UpdateRequest : IamBaseServiceRequest<Google.Apis.Iam.v2beta.Data.GoogleLongrunningOperation>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v2beta.Data.GoogleIamV2betaPolicy body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Immutable. The resource name of the `Policy`, which must be unique. Format:
            /// `policies/{attachment_point}/denypolicies/{policy_id}` The attachment point is identified by its
            /// URL-encoded full resource name, which means that the forward-slash character, `/`, must be written as
            /// `%2F`. For example,
            /// `policies/cloudresourcemanager.googleapis.com%2Fprojects%2Fmy-project/denypolicies/my-deny-policy`. For
            /// organizations and folders, use the numeric ID in the full resource name. For projects, requests can use
            /// the alphanumeric or the numeric ID. Responses always contain the numeric ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Iam.v2beta.Data.GoogleIamV2betaPolicy Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+name}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^policies/[^/]+/[^/]+/[^/]+$",
                });
            }
        }
    }
}
namespace Google.Apis.Iam.v2beta.Data
{
    /// <summary>
    /// Audit log information specific to Cloud IAM admin APIs. This message is serialized as an `Any` type in the
    /// `ServiceData` message of an `AuditLog` message.
    /// </summary>
    public class GoogleIamAdminV1AuditData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The permission_delta when when creating or updating a Role.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionDelta")]
        public virtual GoogleIamAdminV1AuditDataPermissionDelta PermissionDelta { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A PermissionDelta message to record the added_permissions and removed_permissions inside a role.
    /// </summary>
    public class GoogleIamAdminV1AuditDataPermissionDelta : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Added permissions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addedPermissions")]
        public virtual System.Collections.Generic.IList<string> AddedPermissions { get; set; }

        /// <summary>Removed permissions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removedPermissions")]
        public virtual System.Collections.Generic.IList<string> RemovedPermissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// One delta entry for Binding. Each individual change (only one member in each entry) to a binding will be a
    /// separate entry.
    /// </summary>
    public class GoogleIamV1BindingDelta : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The action that was performed on a Binding. Required</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>The condition that is associated with this binding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual GoogleTypeExpr Condition { get; set; }

        /// <summary>
        /// A single identity requesting access for a Google Cloud resource. Follows the same format of Binding.members.
        /// Required
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("member")]
        public virtual string Member { get; set; }

        /// <summary>
        /// Role that is assigned to `members`. For example, `roles/viewer`, `roles/editor`, or `roles/owner`. Required
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Audit log information specific to Cloud IAM. This message is serialized as an `Any` type in the `ServiceData`
    /// message of an `AuditLog` message.
    /// </summary>
    public class GoogleIamV1LoggingAuditData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Policy delta between the original policy and the newly set policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyDelta")]
        public virtual GoogleIamV1PolicyDelta PolicyDelta { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The difference delta between two policies.</summary>
    public class GoogleIamV1PolicyDelta : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The delta for Bindings between two policies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindingDeltas")]
        public virtual System.Collections.Generic.IList<GoogleIamV1BindingDelta> BindingDeltas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A deny rule in an IAM deny policy.</summary>
    public class GoogleIamV2betaDenyRule : Google.Apis.Requests.IDirectResponseSchema
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
        /// The identities that are prevented from using one or more permissions on Google Cloud resources. This field
        /// can contain the following values: * `principalSet://goog/public:all`: A special identifier that represents
        /// any user who is on the internet, even if they do not have a Google Account or are not logged in. *
        /// `principal://goog/subject/{email_id}`: A specific Google Account. Includes Gmail, Cloud Identity, and Google
        /// Workspace user accounts. For example, `principal://goog/subject/alice@example.com`. *
        /// `deleted:principal://goog/subject/{email_id}?uid={uid}`: A specific Google Account that was deleted
        /// recently. For example, `deleted:principal://goog/subject/alice@example.com?uid=1234567890`. If the Google
        /// Account is recovered, this identifier reverts to the standard identifier for a Google Account. *
        /// `principalSet://goog/group/{group_id}`: A Google group. For example,
        /// `principalSet://goog/group/admins@example.com`. * `deleted:principalSet://goog/group/{group_id}?uid={uid}`:
        /// A Google group that was deleted recently. For example,
        /// `deleted:principalSet://goog/group/admins@example.com?uid=1234567890`. If the Google group is restored, this
        /// identifier reverts to the standard identifier for a Google group. *
        /// `principal://iam.googleapis.com/projects/-/serviceAccounts/{service_account_id}`: A Google Cloud service
        /// account. For example,
        /// `principal://iam.googleapis.com/projects/-/serviceAccounts/my-service-account@iam.gserviceaccount.com`. *
        /// `deleted:principal://iam.googleapis.com/projects/-/serviceAccounts/{service_account_id}?uid={uid}`: A Google
        /// Cloud service account that was deleted recently. For example,
        /// `deleted:principal://iam.googleapis.com/projects/-/serviceAccounts/my-service-account@iam.gserviceaccount.com?uid=1234567890`.
        /// If the service account is undeleted, this identifier reverts to the standard identifier for a service
        /// account. * `principalSet://goog/cloudIdentityCustomerId/{customer_id}`: All of the principals associated
        /// with the specified Google Workspace or Cloud Identity customer ID. For example,
        /// `principalSet://goog/cloudIdentityCustomerId/C01Abc35`.
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

    /// <summary>Response message for `ListPolicies`.</summary>
    public class GoogleIamV2betaListPoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A page token that you can use in a ListPoliciesRequest to retrieve the next page. If this field is omitted,
        /// there are no additional pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Metadata for the policies that are attached to the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policies")]
        public virtual System.Collections.Generic.IList<GoogleIamV2betaPolicy> Policies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data for an IAM policy.</summary>
    public class GoogleIamV2betaPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A key-value map to store arbitrary metadata for the `Policy`. Keys can be up to 63 characters. Values can be
        /// up to 255 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>Output only. The time when the `Policy` was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time when the `Policy` was deleted. Empty if the policy is not deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual object DeleteTime { get; set; }

        /// <summary>A user-specified description of the `Policy`. This value can be up to 63 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// An opaque tag that identifies the current version of the `Policy`. IAM uses this value to help manage
        /// concurrent updates, so they do not cause one update to be overwritten by another. If this field is present
        /// in a CreatePolicy request, the value is ignored.
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
        public virtual System.Collections.Generic.IList<GoogleIamV2betaPolicyRule> Rules { get; set; }

        /// <summary>
        /// Immutable. The globally unique ID of the `Policy`. Assigned automatically when the `Policy` is created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>Output only. The time when the `Policy` was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }
    }

    /// <summary>Metadata for long-running `Policy` operations.</summary>
    public class GoogleIamV2betaPolicyOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Timestamp when the `google.longrunning.Operation` was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single rule in a `Policy`.</summary>
    public class GoogleIamV2betaPolicyRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A rule for a deny policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denyRule")]
        public virtual GoogleIamV2betaDenyRule DenyRule { get; set; }

        /// <summary>A user-specified description of the rule. This value can be up to 256 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

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
