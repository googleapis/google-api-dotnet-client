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

namespace Google.Apis.OrgPolicyAPI.v2
{
    /// <summary>The OrgPolicyAPI Service.</summary>
    public class OrgPolicyAPIService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public OrgPolicyAPIService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public OrgPolicyAPIService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Folders = new FoldersResource(this);
            Organizations = new OrganizationsResource(this);
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://orgpolicy.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://orgpolicy.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "orgpolicy";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Organization Policy API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Organization Policy API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Folders resource.</summary>
        public virtual FoldersResource Folders { get; }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for OrgPolicyAPI requests.</summary>
    public abstract class OrgPolicyAPIBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new OrgPolicyAPIBaseServiceRequest instance.</summary>
        protected OrgPolicyAPIBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes OrgPolicyAPI parameter list.</summary>
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

    /// <summary>The "folders" collection of methods.</summary>
    public class FoldersResource
    {
        private const string Resource = "folders";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public FoldersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Constraints = new ConstraintsResource(service);
            Policies = new PoliciesResource(service);
        }

        /// <summary>Gets the Constraints resource.</summary>
        public virtual ConstraintsResource Constraints { get; }

        /// <summary>The "constraints" collection of methods.</summary>
        public class ConstraintsResource
        {
            private const string Resource = "constraints";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ConstraintsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Lists constraints that could be applied on the specified resource.</summary>
            /// <param name="parent">
            /// Required. The Google Cloud resource that parents the constraint. Must be in one of the following forms:
            /// * `projects/{project_number}` * `projects/{project_id}` * `folders/{folder_id}` *
            /// `organizations/{organization_id}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists constraints that could be applied on the specified resource.</summary>
            public class ListRequest : OrgPolicyAPIBaseServiceRequest<Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2ListConstraintsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The Google Cloud resource that parents the constraint. Must be in one of the following
                /// forms: * `projects/{project_number}` * `projects/{project_id}` * `folders/{folder_id}` *
                /// `organizations/{organization_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Size of the pages to be returned. This is currently unsupported and will be ignored. The server may
                /// at any point start using this field to limit page size.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Page token used to retrieve the next page. This is currently unsupported and will be ignored. The
                /// server may at any point start using this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/constraints";

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
                        Pattern = @"^folders/[^/]+$",
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
            }

            /// <summary>
            /// Creates a policy. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the constraint does
            /// not exist. Returns a `google.rpc.Status` with `google.rpc.Code.ALREADY_EXISTS` if the policy already
            /// exists on the given Google Cloud resource.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The Google Cloud resource that will parent the new policy. Must be in one of the following
            /// forms: * `projects/{project_number}` * `projects/{project_id}` * `folders/{folder_id}` *
            /// `organizations/{organization_id}`
            /// </param>
            public virtual CreateRequest Create(Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates a policy. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the constraint does
            /// not exist. Returns a `google.rpc.Status` with `google.rpc.Code.ALREADY_EXISTS` if the policy already
            /// exists on the given Google Cloud resource.
            /// </summary>
            public class CreateRequest : OrgPolicyAPIBaseServiceRequest<Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The Google Cloud resource that will parent the new policy. Must be in one of the following
                /// forms: * `projects/{project_number}` * `projects/{project_id}` * `folders/{folder_id}` *
                /// `organizations/{organization_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/policies";

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
                        Pattern = @"^folders/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes a policy. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the constraint or
            /// organization policy does not exist.
            /// </summary>
            /// <param name="name">
            /// Required. Name of the policy to delete. See the policy entry for naming rules.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes a policy. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the constraint or
            /// organization policy does not exist.
            /// </summary>
            public class DeleteRequest : OrgPolicyAPIBaseServiceRequest<Google.Apis.OrgPolicyAPI.v2.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Name of the policy to delete. See the policy entry for naming rules.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. The current etag of policy. If an etag is provided and does not match the current etag of
                /// the policy, deletion will be blocked and an ABORTED error will be returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Etag { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^folders/[^/]+/policies/[^/]+$",
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

            /// <summary>
            /// Gets a policy on a resource. If no policy is set on the resource, `NOT_FOUND` is returned. The `etag`
            /// value can be used with `UpdatePolicy()` to update a policy during read-modify-write.
            /// </summary>
            /// <param name="name">Required. Resource name of the policy. See Policy for naming requirements.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>
            /// Gets a policy on a resource. If no policy is set on the resource, `NOT_FOUND` is returned. The `etag`
            /// value can be used with `UpdatePolicy()` to update a policy during read-modify-write.
            /// </summary>
            public class GetRequest : OrgPolicyAPIBaseServiceRequest<Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Resource name of the policy. See Policy for naming requirements.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^folders/[^/]+/policies/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets the effective policy on a resource. This is the result of merging policies in the resource
            /// hierarchy and evaluating conditions. The returned policy will not have an `etag` or `condition` set
            /// because it is an evaluated policy across multiple resources. Subtrees of Resource Manager resource
            /// hierarchy with 'under:' prefix will not be expanded.
            /// </summary>
            /// <param name="name">
            /// Required. The effective policy to compute. See Policy for naming requirements.
            /// </param>
            public virtual GetEffectivePolicyRequest GetEffectivePolicy(string name)
            {
                return new GetEffectivePolicyRequest(this.service, name);
            }

            /// <summary>
            /// Gets the effective policy on a resource. This is the result of merging policies in the resource
            /// hierarchy and evaluating conditions. The returned policy will not have an `etag` or `condition` set
            /// because it is an evaluated policy across multiple resources. Subtrees of Resource Manager resource
            /// hierarchy with 'under:' prefix will not be expanded.
            /// </summary>
            public class GetEffectivePolicyRequest : OrgPolicyAPIBaseServiceRequest<Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy>
            {
                /// <summary>Constructs a new GetEffectivePolicy request.</summary>
                public GetEffectivePolicyRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The effective policy to compute. See Policy for naming requirements.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getEffectivePolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}:getEffectivePolicy";

                /// <summary>Initializes GetEffectivePolicy parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^folders/[^/]+/policies/[^/]+$",
                    });
                }
            }

            /// <summary>Retrieves all of the policies that exist on a particular resource.</summary>
            /// <param name="parent">
            /// Required. The target Google Cloud resource that parents the set of constraints and policies that will be
            /// returned from this call. Must be in one of the following forms: * `projects/{project_number}` *
            /// `projects/{project_id}` * `folders/{folder_id}` * `organizations/{organization_id}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Retrieves all of the policies that exist on a particular resource.</summary>
            public class ListRequest : OrgPolicyAPIBaseServiceRequest<Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2ListPoliciesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The target Google Cloud resource that parents the set of constraints and policies that
                /// will be returned from this call. Must be in one of the following forms: *
                /// `projects/{project_number}` * `projects/{project_id}` * `folders/{folder_id}` *
                /// `organizations/{organization_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Size of the pages to be returned. This is currently unsupported and will be ignored. The server may
                /// at any point start using this field to limit page size.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Page token used to retrieve the next page. This is currently unsupported and will be ignored. The
                /// server may at any point start using this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/policies";

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
                        Pattern = @"^folders/[^/]+$",
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
            /// Updates a policy. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the constraint or
            /// the policy do not exist. Returns a `google.rpc.Status` with `google.rpc.Code.ABORTED` if the etag
            /// supplied in the request does not match the persisted etag of the policy Note: the supplied policy will
            /// perform a full overwrite of all fields.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Immutable. The resource name of the policy. Must be one of the following forms, where `constraint_name`
            /// is the name of the constraint which this policy configures: *
            /// `projects/{project_number}/policies/{constraint_name}` *
            /// `folders/{folder_id}/policies/{constraint_name}` *
            /// `organizations/{organization_id}/policies/{constraint_name}` For example,
            /// `projects/123/policies/compute.disableSerialPortAccess`. Note:
            /// `projects/{project_id}/policies/{constraint_name}` is also an acceptable name for API requests, but
            /// responses will return the name using the equivalent project number.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates a policy. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the constraint or
            /// the policy do not exist. Returns a `google.rpc.Status` with `google.rpc.Code.ABORTED` if the etag
            /// supplied in the request does not match the persisted etag of the policy Note: the supplied policy will
            /// perform a full overwrite of all fields.
            /// </summary>
            public class PatchRequest : OrgPolicyAPIBaseServiceRequest<Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Immutable. The resource name of the policy. Must be one of the following forms, where
                /// `constraint_name` is the name of the constraint which this policy configures: *
                /// `projects/{project_number}/policies/{constraint_name}` *
                /// `folders/{folder_id}/policies/{constraint_name}` *
                /// `organizations/{organization_id}/policies/{constraint_name}` For example,
                /// `projects/123/policies/compute.disableSerialPortAccess`. Note:
                /// `projects/{project_id}/policies/{constraint_name}` is also an acceptable name for API requests, but
                /// responses will return the name using the equivalent project number.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Field mask used to specify the fields to be overwritten in the policy by the set. The fields
                /// specified in the update_mask are relative to the policy, not the full request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^folders/[^/]+/policies/[^/]+$",
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

    /// <summary>The "organizations" collection of methods.</summary>
    public class OrganizationsResource
    {
        private const string Resource = "organizations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OrganizationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Constraints = new ConstraintsResource(service);
            CustomConstraints = new CustomConstraintsResource(service);
            Policies = new PoliciesResource(service);
        }

        /// <summary>Gets the Constraints resource.</summary>
        public virtual ConstraintsResource Constraints { get; }

        /// <summary>The "constraints" collection of methods.</summary>
        public class ConstraintsResource
        {
            private const string Resource = "constraints";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ConstraintsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Lists constraints that could be applied on the specified resource.</summary>
            /// <param name="parent">
            /// Required. The Google Cloud resource that parents the constraint. Must be in one of the following forms:
            /// * `projects/{project_number}` * `projects/{project_id}` * `folders/{folder_id}` *
            /// `organizations/{organization_id}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists constraints that could be applied on the specified resource.</summary>
            public class ListRequest : OrgPolicyAPIBaseServiceRequest<Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2ListConstraintsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The Google Cloud resource that parents the constraint. Must be in one of the following
                /// forms: * `projects/{project_number}` * `projects/{project_id}` * `folders/{folder_id}` *
                /// `organizations/{organization_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Size of the pages to be returned. This is currently unsupported and will be ignored. The server may
                /// at any point start using this field to limit page size.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Page token used to retrieve the next page. This is currently unsupported and will be ignored. The
                /// server may at any point start using this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/constraints";

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
                        Pattern = @"^organizations/[^/]+$",
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

        /// <summary>Gets the CustomConstraints resource.</summary>
        public virtual CustomConstraintsResource CustomConstraints { get; }

        /// <summary>The "customConstraints" collection of methods.</summary>
        public class CustomConstraintsResource
        {
            private const string Resource = "customConstraints";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CustomConstraintsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a custom constraint. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
            /// organization does not exist. Returns a `google.rpc.Status` with `google.rpc.Code.ALREADY_EXISTS` if the
            /// constraint already exists on the given organization.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Must be in the following form: * `organizations/{organization_id}`
            /// </param>
            public virtual CreateRequest Create(Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2CustomConstraint body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates a custom constraint. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
            /// organization does not exist. Returns a `google.rpc.Status` with `google.rpc.Code.ALREADY_EXISTS` if the
            /// constraint already exists on the given organization.
            /// </summary>
            public class CreateRequest : OrgPolicyAPIBaseServiceRequest<Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2CustomConstraint>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2CustomConstraint body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Must be in the following form: * `organizations/{organization_id}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2CustomConstraint Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/customConstraints";

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
                        Pattern = @"^organizations/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes a custom constraint. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
            /// constraint does not exist.
            /// </summary>
            /// <param name="name">
            /// Required. Name of the custom constraint to delete. See the custom constraint entry for naming rules.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes a custom constraint. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
            /// constraint does not exist.
            /// </summary>
            public class DeleteRequest : OrgPolicyAPIBaseServiceRequest<Google.Apis.OrgPolicyAPI.v2.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the custom constraint to delete. See the custom constraint entry for naming rules.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^organizations/[^/]+/customConstraints/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets a custom or managed constraint. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if
            /// the custom or managed constraint does not exist.
            /// </summary>
            /// <param name="name">
            /// Required. Resource name of the custom or managed constraint. See the custom constraint entry for naming
            /// requirements.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>
            /// Gets a custom or managed constraint. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if
            /// the custom or managed constraint does not exist.
            /// </summary>
            public class GetRequest : OrgPolicyAPIBaseServiceRequest<Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2CustomConstraint>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the custom or managed constraint. See the custom constraint entry for
                /// naming requirements.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^organizations/[^/]+/customConstraints/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Retrieves all of the custom constraints that exist on a particular organization resource.
            /// </summary>
            /// <param name="parent">
            /// Required. The target Google Cloud resource that parents the set of custom constraints that will be
            /// returned from this call. Must be in one of the following forms: * `organizations/{organization_id}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Retrieves all of the custom constraints that exist on a particular organization resource.
            /// </summary>
            public class ListRequest : OrgPolicyAPIBaseServiceRequest<Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2ListCustomConstraintsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The target Google Cloud resource that parents the set of custom constraints that will be
                /// returned from this call. Must be in one of the following forms: * `organizations/{organization_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Size of the pages to be returned. This is currently unsupported and will be ignored. The server may
                /// at any point start using this field to limit page size.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Page token used to retrieve the next page. This is currently unsupported and will be ignored. The
                /// server may at any point start using this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/customConstraints";

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
                        Pattern = @"^organizations/[^/]+$",
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
            /// Updates a custom constraint. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
            /// constraint does not exist. Note: the supplied policy will perform a full overwrite of all fields.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Immutable. Name of the constraint. This is unique within the organization. Format of the name should be
            /// * `organizations/{organization_id}/customConstraints/{custom_constraint_id}` Example:
            /// `organizations/123/customConstraints/custom.createOnlyE2TypeVms` The max length is 70 characters and the
            /// minimum length is 1. Note that the prefix `organizations/{organization_id}/customConstraints/` is not
            /// counted.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2CustomConstraint body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates a custom constraint. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
            /// constraint does not exist. Note: the supplied policy will perform a full overwrite of all fields.
            /// </summary>
            public class PatchRequest : OrgPolicyAPIBaseServiceRequest<Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2CustomConstraint>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2CustomConstraint body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Immutable. Name of the constraint. This is unique within the organization. Format of the name should
                /// be * `organizations/{organization_id}/customConstraints/{custom_constraint_id}` Example:
                /// `organizations/123/customConstraints/custom.createOnlyE2TypeVms` The max length is 70 characters and
                /// the minimum length is 1. Note that the prefix `organizations/{organization_id}/customConstraints/`
                /// is not counted.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2CustomConstraint Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^organizations/[^/]+/customConstraints/[^/]+$",
                    });
                }
            }
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
            }

            /// <summary>
            /// Creates a policy. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the constraint does
            /// not exist. Returns a `google.rpc.Status` with `google.rpc.Code.ALREADY_EXISTS` if the policy already
            /// exists on the given Google Cloud resource.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The Google Cloud resource that will parent the new policy. Must be in one of the following
            /// forms: * `projects/{project_number}` * `projects/{project_id}` * `folders/{folder_id}` *
            /// `organizations/{organization_id}`
            /// </param>
            public virtual CreateRequest Create(Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates a policy. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the constraint does
            /// not exist. Returns a `google.rpc.Status` with `google.rpc.Code.ALREADY_EXISTS` if the policy already
            /// exists on the given Google Cloud resource.
            /// </summary>
            public class CreateRequest : OrgPolicyAPIBaseServiceRequest<Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The Google Cloud resource that will parent the new policy. Must be in one of the following
                /// forms: * `projects/{project_number}` * `projects/{project_id}` * `folders/{folder_id}` *
                /// `organizations/{organization_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/policies";

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
                        Pattern = @"^organizations/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes a policy. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the constraint or
            /// organization policy does not exist.
            /// </summary>
            /// <param name="name">
            /// Required. Name of the policy to delete. See the policy entry for naming rules.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes a policy. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the constraint or
            /// organization policy does not exist.
            /// </summary>
            public class DeleteRequest : OrgPolicyAPIBaseServiceRequest<Google.Apis.OrgPolicyAPI.v2.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Name of the policy to delete. See the policy entry for naming rules.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. The current etag of policy. If an etag is provided and does not match the current etag of
                /// the policy, deletion will be blocked and an ABORTED error will be returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Etag { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^organizations/[^/]+/policies/[^/]+$",
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

            /// <summary>
            /// Gets a policy on a resource. If no policy is set on the resource, `NOT_FOUND` is returned. The `etag`
            /// value can be used with `UpdatePolicy()` to update a policy during read-modify-write.
            /// </summary>
            /// <param name="name">Required. Resource name of the policy. See Policy for naming requirements.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>
            /// Gets a policy on a resource. If no policy is set on the resource, `NOT_FOUND` is returned. The `etag`
            /// value can be used with `UpdatePolicy()` to update a policy during read-modify-write.
            /// </summary>
            public class GetRequest : OrgPolicyAPIBaseServiceRequest<Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Resource name of the policy. See Policy for naming requirements.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^organizations/[^/]+/policies/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets the effective policy on a resource. This is the result of merging policies in the resource
            /// hierarchy and evaluating conditions. The returned policy will not have an `etag` or `condition` set
            /// because it is an evaluated policy across multiple resources. Subtrees of Resource Manager resource
            /// hierarchy with 'under:' prefix will not be expanded.
            /// </summary>
            /// <param name="name">
            /// Required. The effective policy to compute. See Policy for naming requirements.
            /// </param>
            public virtual GetEffectivePolicyRequest GetEffectivePolicy(string name)
            {
                return new GetEffectivePolicyRequest(this.service, name);
            }

            /// <summary>
            /// Gets the effective policy on a resource. This is the result of merging policies in the resource
            /// hierarchy and evaluating conditions. The returned policy will not have an `etag` or `condition` set
            /// because it is an evaluated policy across multiple resources. Subtrees of Resource Manager resource
            /// hierarchy with 'under:' prefix will not be expanded.
            /// </summary>
            public class GetEffectivePolicyRequest : OrgPolicyAPIBaseServiceRequest<Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy>
            {
                /// <summary>Constructs a new GetEffectivePolicy request.</summary>
                public GetEffectivePolicyRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The effective policy to compute. See Policy for naming requirements.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getEffectivePolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}:getEffectivePolicy";

                /// <summary>Initializes GetEffectivePolicy parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/policies/[^/]+$",
                    });
                }
            }

            /// <summary>Retrieves all of the policies that exist on a particular resource.</summary>
            /// <param name="parent">
            /// Required. The target Google Cloud resource that parents the set of constraints and policies that will be
            /// returned from this call. Must be in one of the following forms: * `projects/{project_number}` *
            /// `projects/{project_id}` * `folders/{folder_id}` * `organizations/{organization_id}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Retrieves all of the policies that exist on a particular resource.</summary>
            public class ListRequest : OrgPolicyAPIBaseServiceRequest<Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2ListPoliciesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The target Google Cloud resource that parents the set of constraints and policies that
                /// will be returned from this call. Must be in one of the following forms: *
                /// `projects/{project_number}` * `projects/{project_id}` * `folders/{folder_id}` *
                /// `organizations/{organization_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Size of the pages to be returned. This is currently unsupported and will be ignored. The server may
                /// at any point start using this field to limit page size.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Page token used to retrieve the next page. This is currently unsupported and will be ignored. The
                /// server may at any point start using this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/policies";

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
                        Pattern = @"^organizations/[^/]+$",
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
            /// Updates a policy. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the constraint or
            /// the policy do not exist. Returns a `google.rpc.Status` with `google.rpc.Code.ABORTED` if the etag
            /// supplied in the request does not match the persisted etag of the policy Note: the supplied policy will
            /// perform a full overwrite of all fields.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Immutable. The resource name of the policy. Must be one of the following forms, where `constraint_name`
            /// is the name of the constraint which this policy configures: *
            /// `projects/{project_number}/policies/{constraint_name}` *
            /// `folders/{folder_id}/policies/{constraint_name}` *
            /// `organizations/{organization_id}/policies/{constraint_name}` For example,
            /// `projects/123/policies/compute.disableSerialPortAccess`. Note:
            /// `projects/{project_id}/policies/{constraint_name}` is also an acceptable name for API requests, but
            /// responses will return the name using the equivalent project number.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates a policy. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the constraint or
            /// the policy do not exist. Returns a `google.rpc.Status` with `google.rpc.Code.ABORTED` if the etag
            /// supplied in the request does not match the persisted etag of the policy Note: the supplied policy will
            /// perform a full overwrite of all fields.
            /// </summary>
            public class PatchRequest : OrgPolicyAPIBaseServiceRequest<Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Immutable. The resource name of the policy. Must be one of the following forms, where
                /// `constraint_name` is the name of the constraint which this policy configures: *
                /// `projects/{project_number}/policies/{constraint_name}` *
                /// `folders/{folder_id}/policies/{constraint_name}` *
                /// `organizations/{organization_id}/policies/{constraint_name}` For example,
                /// `projects/123/policies/compute.disableSerialPortAccess`. Note:
                /// `projects/{project_id}/policies/{constraint_name}` is also an acceptable name for API requests, but
                /// responses will return the name using the equivalent project number.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Field mask used to specify the fields to be overwritten in the policy by the set. The fields
                /// specified in the update_mask are relative to the policy, not the full request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^organizations/[^/]+/policies/[^/]+$",
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
            Constraints = new ConstraintsResource(service);
            Policies = new PoliciesResource(service);
        }

        /// <summary>Gets the Constraints resource.</summary>
        public virtual ConstraintsResource Constraints { get; }

        /// <summary>The "constraints" collection of methods.</summary>
        public class ConstraintsResource
        {
            private const string Resource = "constraints";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ConstraintsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Lists constraints that could be applied on the specified resource.</summary>
            /// <param name="parent">
            /// Required. The Google Cloud resource that parents the constraint. Must be in one of the following forms:
            /// * `projects/{project_number}` * `projects/{project_id}` * `folders/{folder_id}` *
            /// `organizations/{organization_id}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists constraints that could be applied on the specified resource.</summary>
            public class ListRequest : OrgPolicyAPIBaseServiceRequest<Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2ListConstraintsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The Google Cloud resource that parents the constraint. Must be in one of the following
                /// forms: * `projects/{project_number}` * `projects/{project_id}` * `folders/{folder_id}` *
                /// `organizations/{organization_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Size of the pages to be returned. This is currently unsupported and will be ignored. The server may
                /// at any point start using this field to limit page size.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Page token used to retrieve the next page. This is currently unsupported and will be ignored. The
                /// server may at any point start using this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/constraints";

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
            }

            /// <summary>
            /// Creates a policy. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the constraint does
            /// not exist. Returns a `google.rpc.Status` with `google.rpc.Code.ALREADY_EXISTS` if the policy already
            /// exists on the given Google Cloud resource.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The Google Cloud resource that will parent the new policy. Must be in one of the following
            /// forms: * `projects/{project_number}` * `projects/{project_id}` * `folders/{folder_id}` *
            /// `organizations/{organization_id}`
            /// </param>
            public virtual CreateRequest Create(Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates a policy. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the constraint does
            /// not exist. Returns a `google.rpc.Status` with `google.rpc.Code.ALREADY_EXISTS` if the policy already
            /// exists on the given Google Cloud resource.
            /// </summary>
            public class CreateRequest : OrgPolicyAPIBaseServiceRequest<Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The Google Cloud resource that will parent the new policy. Must be in one of the following
                /// forms: * `projects/{project_number}` * `projects/{project_id}` * `folders/{folder_id}` *
                /// `organizations/{organization_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/policies";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes a policy. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the constraint or
            /// organization policy does not exist.
            /// </summary>
            /// <param name="name">
            /// Required. Name of the policy to delete. See the policy entry for naming rules.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes a policy. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the constraint or
            /// organization policy does not exist.
            /// </summary>
            public class DeleteRequest : OrgPolicyAPIBaseServiceRequest<Google.Apis.OrgPolicyAPI.v2.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Name of the policy to delete. See the policy entry for naming rules.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. The current etag of policy. If an etag is provided and does not match the current etag of
                /// the policy, deletion will be blocked and an ABORTED error will be returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Etag { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^projects/[^/]+/policies/[^/]+$",
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

            /// <summary>
            /// Gets a policy on a resource. If no policy is set on the resource, `NOT_FOUND` is returned. The `etag`
            /// value can be used with `UpdatePolicy()` to update a policy during read-modify-write.
            /// </summary>
            /// <param name="name">Required. Resource name of the policy. See Policy for naming requirements.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>
            /// Gets a policy on a resource. If no policy is set on the resource, `NOT_FOUND` is returned. The `etag`
            /// value can be used with `UpdatePolicy()` to update a policy during read-modify-write.
            /// </summary>
            public class GetRequest : OrgPolicyAPIBaseServiceRequest<Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Resource name of the policy. See Policy for naming requirements.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^projects/[^/]+/policies/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets the effective policy on a resource. This is the result of merging policies in the resource
            /// hierarchy and evaluating conditions. The returned policy will not have an `etag` or `condition` set
            /// because it is an evaluated policy across multiple resources. Subtrees of Resource Manager resource
            /// hierarchy with 'under:' prefix will not be expanded.
            /// </summary>
            /// <param name="name">
            /// Required. The effective policy to compute. See Policy for naming requirements.
            /// </param>
            public virtual GetEffectivePolicyRequest GetEffectivePolicy(string name)
            {
                return new GetEffectivePolicyRequest(this.service, name);
            }

            /// <summary>
            /// Gets the effective policy on a resource. This is the result of merging policies in the resource
            /// hierarchy and evaluating conditions. The returned policy will not have an `etag` or `condition` set
            /// because it is an evaluated policy across multiple resources. Subtrees of Resource Manager resource
            /// hierarchy with 'under:' prefix will not be expanded.
            /// </summary>
            public class GetEffectivePolicyRequest : OrgPolicyAPIBaseServiceRequest<Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy>
            {
                /// <summary>Constructs a new GetEffectivePolicy request.</summary>
                public GetEffectivePolicyRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The effective policy to compute. See Policy for naming requirements.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getEffectivePolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}:getEffectivePolicy";

                /// <summary>Initializes GetEffectivePolicy parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/policies/[^/]+$",
                    });
                }
            }

            /// <summary>Retrieves all of the policies that exist on a particular resource.</summary>
            /// <param name="parent">
            /// Required. The target Google Cloud resource that parents the set of constraints and policies that will be
            /// returned from this call. Must be in one of the following forms: * `projects/{project_number}` *
            /// `projects/{project_id}` * `folders/{folder_id}` * `organizations/{organization_id}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Retrieves all of the policies that exist on a particular resource.</summary>
            public class ListRequest : OrgPolicyAPIBaseServiceRequest<Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2ListPoliciesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The target Google Cloud resource that parents the set of constraints and policies that
                /// will be returned from this call. Must be in one of the following forms: *
                /// `projects/{project_number}` * `projects/{project_id}` * `folders/{folder_id}` *
                /// `organizations/{organization_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Size of the pages to be returned. This is currently unsupported and will be ignored. The server may
                /// at any point start using this field to limit page size.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Page token used to retrieve the next page. This is currently unsupported and will be ignored. The
                /// server may at any point start using this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/policies";

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

            /// <summary>
            /// Updates a policy. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the constraint or
            /// the policy do not exist. Returns a `google.rpc.Status` with `google.rpc.Code.ABORTED` if the etag
            /// supplied in the request does not match the persisted etag of the policy Note: the supplied policy will
            /// perform a full overwrite of all fields.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Immutable. The resource name of the policy. Must be one of the following forms, where `constraint_name`
            /// is the name of the constraint which this policy configures: *
            /// `projects/{project_number}/policies/{constraint_name}` *
            /// `folders/{folder_id}/policies/{constraint_name}` *
            /// `organizations/{organization_id}/policies/{constraint_name}` For example,
            /// `projects/123/policies/compute.disableSerialPortAccess`. Note:
            /// `projects/{project_id}/policies/{constraint_name}` is also an acceptable name for API requests, but
            /// responses will return the name using the equivalent project number.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates a policy. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the constraint or
            /// the policy do not exist. Returns a `google.rpc.Status` with `google.rpc.Code.ABORTED` if the etag
            /// supplied in the request does not match the persisted etag of the policy Note: the supplied policy will
            /// perform a full overwrite of all fields.
            /// </summary>
            public class PatchRequest : OrgPolicyAPIBaseServiceRequest<Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Immutable. The resource name of the policy. Must be one of the following forms, where
                /// `constraint_name` is the name of the constraint which this policy configures: *
                /// `projects/{project_number}/policies/{constraint_name}` *
                /// `folders/{folder_id}/policies/{constraint_name}` *
                /// `organizations/{organization_id}/policies/{constraint_name}` For example,
                /// `projects/123/policies/compute.disableSerialPortAccess`. Note:
                /// `projects/{project_id}/policies/{constraint_name}` is also an acceptable name for API requests, but
                /// responses will return the name using the equivalent project number.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Field mask used to specify the fields to be overwritten in the policy by the set. The fields
                /// specified in the update_mask are relative to the policy, not the full request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.OrgPolicyAPI.v2.Data.GoogleCloudOrgpolicyV2Policy Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^projects/[^/]+/policies/[^/]+$",
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
namespace Google.Apis.OrgPolicyAPI.v2.Data
{
    /// <summary>
    /// Similar to PolicySpec but with an extra 'launch' field for launch reference. The PolicySpec here is specific for
    /// dry-run.
    /// </summary>
    public class GoogleCloudOrgpolicyV2AlternatePolicySpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Reference to the launch that will be used while audit logging and to control the launch. Should be set only
        /// in the alternate policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launch")]
        public virtual string Launch { get; set; }

        /// <summary>Specify constraint for configurations of Google Cloud resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual GoogleCloudOrgpolicyV2PolicySpec Spec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A constraint describes a way to restrict resource's configuration. For example, you could enforce a constraint
    /// that controls which Google Cloud services can be activated across an organization, or whether a Compute Engine
    /// instance can have serial port connections established. Constraints can be configured by the organization policy
    /// administrator to fit the needs of the organization by setting a policy that includes constraints at different
    /// locations in the organization's resource hierarchy. Policies are inherited down the resource hierarchy from
    /// higher levels, but can also be overridden. For details about the inheritance rules, see `Policy`. Constraints
    /// have a default behavior determined by the `constraint_default` field, which is the enforcement behavior that is
    /// used in the absence of a policy being defined or inherited for the resource in question.
    /// </summary>
    public class GoogleCloudOrgpolicyV2Constraint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Defines this constraint as being a boolean constraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("booleanConstraint")]
        public virtual GoogleCloudOrgpolicyV2ConstraintBooleanConstraint BooleanConstraint { get; set; }

        /// <summary>The evaluation behavior of this constraint in the absence of a policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraintDefault")]
        public virtual string ConstraintDefault { get; set; }

        /// <summary>
        /// Detailed description of what this constraint controls as well as how and where it is enforced. Mutable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The human readable name. Mutable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Managed constraint and canned constraint sometimes can have equivalents. This field is used to store the
        /// equivalent constraint name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("equivalentConstraint")]
        public virtual string EquivalentConstraint { get; set; }

        /// <summary>Defines this constraint as being a list constraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listConstraint")]
        public virtual GoogleCloudOrgpolicyV2ConstraintListConstraint ListConstraint { get; set; }

        /// <summary>
        /// Immutable. The resource name of the constraint. Must be in one of the following forms: *
        /// `projects/{project_number}/constraints/{constraint_name}` *
        /// `folders/{folder_id}/constraints/{constraint_name}` *
        /// `organizations/{organization_id}/constraints/{constraint_name}` For example,
        /// "/projects/123/constraints/compute.disableSerialPortAccess".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Shows if dry run is supported for this constraint or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportsDryRun")]
        public virtual System.Nullable<bool> SupportsDryRun { get; set; }

        /// <summary>Shows if simulation is supported for this constraint or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportsSimulation")]
        public virtual System.Nullable<bool> SupportsSimulation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A constraint type is enforced or not enforced, which is configured in the `PolicyRule`. If
    /// `customConstraintDefinition` is defined, this constraint is a managed constraint.
    /// </summary>
    public class GoogleCloudOrgpolicyV2ConstraintBooleanConstraint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom constraint definition. Defines this as a managed constraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customConstraintDefinition")]
        public virtual GoogleCloudOrgpolicyV2ConstraintCustomConstraintDefinition CustomConstraintDefinition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Custom constraint definition. Defines this as a managed constraint.</summary>
    public class GoogleCloudOrgpolicyV2ConstraintCustomConstraintDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Allow or deny type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionType")]
        public virtual string ActionType { get; set; }

        /// <summary>
        /// Org policy condition/expression. For example: `resource.instanceName.matches("[production|test]_.*_(\d)+")`
        /// or, `resource.management.auto_upgrade == true` The max length of the condition is 1000 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; }

        /// <summary>All the operations being applied for this constraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("methodTypes")]
        public virtual System.Collections.Generic.IList<string> MethodTypes { get; set; }

        /// <summary>
        /// Stores the structure of `Parameters` used by the constraint condition. The key of `map` represents the name
        /// of the parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudOrgpolicyV2ConstraintCustomConstraintDefinitionParameter> Parameters { get; set; }

        /// <summary>
        /// The resource instance type on which this policy applies. Format will be of the form : `/` Example: *
        /// `compute.googleapis.com/Instance`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceTypes")]
        public virtual System.Collections.Generic.IList<string> ResourceTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines a parameter structure.</summary>
    public class GoogleCloudOrgpolicyV2ConstraintCustomConstraintDefinitionParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Sets the value of the parameter in an assignment if no value is given.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual object DefaultValue { get; set; }

        /// <summary>
        /// Determines the parameter's value structure. For example, `LIST` can be specified by defining `type: LIST`,
        /// and `item: STRING`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("item")]
        public virtual string Item { get; set; }

        /// <summary>Defines subproperties primarily used by the UI to display user-friendly information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual GoogleCloudOrgpolicyV2ConstraintCustomConstraintDefinitionParameterMetadata Metadata { get; set; }

        /// <summary>Type of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// Provides a CEL expression to specify the acceptable parameter values during assignment. For example,
        /// parameterName in ("parameterValue1", "parameterValue2")
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validValuesExpr")]
        public virtual string ValidValuesExpr { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines Metadata structure.</summary>
    public class GoogleCloudOrgpolicyV2ConstraintCustomConstraintDefinitionParameterMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detailed description of what this `parameter` is and use of it. Mutable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A constraint type that allows or disallows a list of string values, which are configured in the `PolicyRule`.
    /// </summary>
    public class GoogleCloudOrgpolicyV2ConstraintListConstraint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates whether values grouped into categories can be used in `Policy.allowed_values` and
        /// `Policy.denied_values`. For example, `"in:Python"` would match any value in the 'Python' group.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportsIn")]
        public virtual System.Nullable<bool> SupportsIn { get; set; }

        /// <summary>
        /// Indicates whether subtrees of the Resource Manager resource hierarchy can be used in `Policy.allowed_values`
        /// and `Policy.denied_values`. For example, `"under:folders/123"` would match any resource under the
        /// 'folders/123' folder.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportsUnder")]
        public virtual System.Nullable<bool> SupportsUnder { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A custom constraint defined by customers which can *only* be applied to the given resource types and
    /// organization. By creating a custom constraint, customers can apply policies of this custom constraint. *Creating
    /// a custom constraint itself does NOT apply any policy enforcement*.
    /// </summary>
    public class GoogleCloudOrgpolicyV2CustomConstraint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Allow or deny type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionType")]
        public virtual string ActionType { get; set; }

        /// <summary>
        /// A Common Expression Language (CEL) condition which is used in the evaluation of the constraint. For example:
        /// `resource.instanceName.matches("[production|test]_.*_(\d)+")` or, `resource.management.auto_upgrade == true`
        /// The max length of the condition is 1000 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; }

        /// <summary>
        /// Detailed information about this custom policy constraint. The max length of the description is 2000
        /// characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>One line display name for the UI. The max length of the display_name is 200 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>All the operations being applied for this constraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("methodTypes")]
        public virtual System.Collections.Generic.IList<string> MethodTypes { get; set; }

        /// <summary>
        /// Immutable. Name of the constraint. This is unique within the organization. Format of the name should be *
        /// `organizations/{organization_id}/customConstraints/{custom_constraint_id}` Example:
        /// `organizations/123/customConstraints/custom.createOnlyE2TypeVms` The max length is 70 characters and the
        /// minimum length is 1. Note that the prefix `organizations/{organization_id}/customConstraints/` is not
        /// counted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. The resource instance type on which this policy applies. Format will be of the form : `/`
        /// Example: * `compute.googleapis.com/Instance`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceTypes")]
        public virtual System.Collections.Generic.IList<string> ResourceTypes { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The last time this custom constraint was updated. This represents the last time that the
        /// `CreateCustomConstraint` or `UpdateCustomConstraint` methods were called.
        /// </summary>
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

    /// <summary>The response returned from the ListConstraints method.</summary>
    public class GoogleCloudOrgpolicyV2ListConstraintsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The collection of constraints that are available on the targeted resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraints")]
        public virtual System.Collections.Generic.IList<GoogleCloudOrgpolicyV2Constraint> Constraints { get; set; }

        /// <summary>Page token used to retrieve the next page. This is currently not used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The response returned from the ListCustomConstraints method. It will be empty if no custom or managed
    /// constraints are set on the organization resource.
    /// </summary>
    public class GoogleCloudOrgpolicyV2ListCustomConstraintsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// All custom and managed constraints that exist on the organization resource. It will be empty if no custom
        /// constraints are set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customConstraints")]
        public virtual System.Collections.Generic.IList<GoogleCloudOrgpolicyV2CustomConstraint> CustomConstraints { get; set; }

        /// <summary>
        /// Page token used to retrieve the next page. This is currently not used, but the server may at any point start
        /// supplying a valid token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The response returned from the ListPolicies method. It will be empty if no policies are set on the resource.
    /// </summary>
    public class GoogleCloudOrgpolicyV2ListPoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Page token used to retrieve the next page. This is currently not used, but the server may at any point start
        /// supplying a valid token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>All policies that exist on the resource. It will be empty if no policies are set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policies")]
        public virtual System.Collections.Generic.IList<GoogleCloudOrgpolicyV2Policy> Policies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines an organization policy which is used to specify constraints for configurations of Google Cloud
    /// resources.
    /// </summary>
    public class GoogleCloudOrgpolicyV2Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternate")]
        public virtual GoogleCloudOrgpolicyV2AlternatePolicySpec Alternate { get; set; }

        /// <summary>
        /// Dry-run policy. Audit-only policy, can be used to monitor how the policy would have impacted the existing
        /// and future resources if it's enforced.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dryRunSpec")]
        public virtual GoogleCloudOrgpolicyV2PolicySpec DryRunSpec { get; set; }

        /// <summary>
        /// Optional. An opaque tag indicating the current state of the policy, used for concurrency control. This
        /// 'etag' is computed by the server based on the value of other fields, and may be sent on update and delete
        /// requests to ensure the client has an up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Immutable. The resource name of the policy. Must be one of the following forms, where `constraint_name` is
        /// the name of the constraint which this policy configures: *
        /// `projects/{project_number}/policies/{constraint_name}` * `folders/{folder_id}/policies/{constraint_name}` *
        /// `organizations/{organization_id}/policies/{constraint_name}` For example,
        /// `projects/123/policies/compute.disableSerialPortAccess`. Note:
        /// `projects/{project_id}/policies/{constraint_name}` is also an acceptable name for API requests, but
        /// responses will return the name using the equivalent project number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Basic information about the organization policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual GoogleCloudOrgpolicyV2PolicySpec Spec { get; set; }
    }

    /// <summary>
    /// Defines a Google Cloud policy specification which is used to specify constraints for configurations of Google
    /// Cloud resources.
    /// </summary>
    public class GoogleCloudOrgpolicyV2PolicySpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An opaque tag indicating the current version of the policySpec, used for concurrency control. This field is
        /// ignored if used in a `CreatePolicy` request. When the policy is returned from either a `GetPolicy` or a
        /// `ListPolicies` request, this `etag` indicates the version of the current policySpec to use when executing a
        /// read-modify-write loop. When the policy is returned from a `GetEffectivePolicy` request, the `etag` will be
        /// unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Determines the inheritance behavior for this policy. If `inherit_from_parent` is true, policy rules set
        /// higher up in the hierarchy (up to the closest root) are inherited and present in the effective policy. If it
        /// is false, then no rules are inherited, and this policy becomes the new root for evaluation. This field can
        /// be set only for policies which configure list constraints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inheritFromParent")]
        public virtual System.Nullable<bool> InheritFromParent { get; set; }

        /// <summary>
        /// Ignores policies set above this resource and restores the `constraint_default` enforcement behavior of the
        /// specific constraint at this resource. This field can be set in policies for either list or boolean
        /// constraints. If set, `rules` must be empty and `inherit_from_parent` must be set to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reset")]
        public virtual System.Nullable<bool> Reset { get; set; }

        /// <summary>
        /// In policies for boolean constraints, the following requirements apply: - There must be one and only one
        /// policy rule where condition is unset. - Boolean policy rules with conditions must set `enforced` to the
        /// opposite of the policy rule without a condition. - During policy evaluation, policy rules with conditions
        /// that are true for a target resource take precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<GoogleCloudOrgpolicyV2PolicySpecPolicyRule> Rules { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The time stamp this was previously updated. This represents the last time a call to
        /// `CreatePolicy` or `UpdatePolicy` was made for that policy.
        /// </summary>
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

    /// <summary>A rule used to express this policy.</summary>
    public class GoogleCloudOrgpolicyV2PolicySpecPolicyRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Setting this to true means that all values are allowed. This field can be set only in policies for list
        /// constraints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowAll")]
        public virtual System.Nullable<bool> AllowAll { get; set; }

        /// <summary>
        /// A condition which determines whether this rule is used in the evaluation of the policy. When set, the
        /// `expression` field in the `Expr' must include from 1 to 10 subexpressions, joined by the "||" or
        /// "&amp;amp;&amp;amp;" operators. Each subexpression must be of the form
        /// "resource.matchTag('/tag_key_short_name, 'tag_value_short_name')". or "resource.matchTagId('tagKeys/key_id',
        /// 'tagValues/value_id')". where key_name and value_name are the resource names for Label Keys and Values.
        /// These names are available from the Tag Manager Service. An example expression is:
        /// "resource.matchTag('123456789/environment, 'prod')". or "resource.matchTagId('tagKeys/123',
        /// 'tagValues/456')".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual GoogleTypeExpr Condition { get; set; }

        /// <summary>
        /// Setting this to true means that all values are denied. This field can be set only in policies for list
        /// constraints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denyAll")]
        public virtual System.Nullable<bool> DenyAll { get; set; }

        /// <summary>
        /// If `true`, then the policy is enforced. If `false`, then any configuration is acceptable. This field can be
        /// set in policies for boolean constraints, custom constraints and managed constraints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enforce")]
        public virtual System.Nullable<bool> Enforce { get; set; }

        /// <summary>
        /// Optional. Required for managed constraints if parameters are defined. Passes parameter values when policy
        /// enforcement is enabled. Ensure that parameter value types match those defined in the constraint definition.
        /// For example: { "allowedLocations" : ["us-east1", "us-west1"], "allowAll" : true }
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// List of values to be used for this policy rule. This field can be set only in policies for list constraints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual GoogleCloudOrgpolicyV2PolicySpecPolicyRuleStringValues Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A message that holds specific allowed and denied values. This message can define specific values and subtrees of
    /// the Resource Manager resource hierarchy (`Organizations`, `Folders`, `Projects`) that are allowed or denied.
    /// This is achieved by using the `under:` and optional `is:` prefixes. The `under:` prefix is used to denote
    /// resource subtree values. The `is:` prefix is used to denote specific values, and is required only if the value
    /// contains a ":". Values prefixed with "is:" are treated the same as values with no prefix. Ancestry subtrees must
    /// be in one of the following formats: - `projects/` (for example, `projects/tokyo-rain-123`) - `folders/` (for
    /// example, `folders/1234`) - `organizations/` (for example, `organizations/1234`) The `supports_under` field of
    /// the associated `Constraint` defines whether ancestry prefixes can be used.
    /// </summary>
    public class GoogleCloudOrgpolicyV2PolicySpecPolicyRuleStringValues : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of values allowed at this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedValues")]
        public virtual System.Collections.Generic.IList<string> AllowedValues { get; set; }

        /// <summary>List of values denied at this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deniedValues")]
        public virtual System.Collections.Generic.IList<string> DeniedValues { get; set; }

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
