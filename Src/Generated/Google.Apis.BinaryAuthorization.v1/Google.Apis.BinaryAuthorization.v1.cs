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

namespace Google.Apis.BinaryAuthorization.v1
{
    /// <summary>The BinaryAuthorization Service.</summary>
    public class BinaryAuthorizationService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public BinaryAuthorizationService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public BinaryAuthorizationService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            Systempolicy = new SystempolicyResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://binaryauthorization.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://binaryauthorization.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "binaryauthorization";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Binary Authorization API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Binary Authorization API.</summary>
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

        /// <summary>Gets the Systempolicy resource.</summary>
        public virtual SystempolicyResource Systempolicy { get; }
    }

    /// <summary>A base abstract class for BinaryAuthorization requests.</summary>
    public abstract class BinaryAuthorizationBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new BinaryAuthorizationBaseServiceRequest instance.</summary>
        protected BinaryAuthorizationBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes BinaryAuthorization parameter list.</summary>
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
            Attestors = new AttestorsResource(service);
            Platforms = new PlatformsResource(service);
            Policy = new PolicyResource(service);
        }

        /// <summary>Gets the Attestors resource.</summary>
        public virtual AttestorsResource Attestors { get; }

        /// <summary>The "attestors" collection of methods.</summary>
        public class AttestorsResource
        {
            private const string Resource = "attestors";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AttestorsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates an attestor, and returns a copy of the new attestor. Returns `NOT_FOUND` if the project does not
            /// exist, `INVALID_ARGUMENT` if the request is malformed, `ALREADY_EXISTS` if the attestor already exists.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. The parent of this attestor.</param>
            public virtual CreateRequest Create(Google.Apis.BinaryAuthorization.v1.Data.Attestor body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates an attestor, and returns a copy of the new attestor. Returns `NOT_FOUND` if the project does not
            /// exist, `INVALID_ARGUMENT` if the request is malformed, `ALREADY_EXISTS` if the attestor already exists.
            /// </summary>
            public class CreateRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1.Data.Attestor>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BinaryAuthorization.v1.Data.Attestor body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The parent of this attestor.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Required. The attestors ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("attestorId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string AttestorId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.BinaryAuthorization.v1.Data.Attestor Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/attestors";

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
                    RequestParameters.Add("attestorId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "attestorId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes an attestor. Returns `NOT_FOUND` if the attestor does not exist.</summary>
            /// <param name="name">
            /// Required. The name of the attestors to delete, in the format `projects/*/attestors/*`.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes an attestor. Returns `NOT_FOUND` if the attestor does not exist.</summary>
            public class DeleteRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the attestors to delete, in the format `projects/*/attestors/*`.
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
                        Pattern = @"^projects/[^/]+/attestors/[^/]+$",
                    });
                }
            }

            /// <summary>Gets an attestor. Returns `NOT_FOUND` if the attestor does not exist.</summary>
            /// <param name="name">
            /// Required. The name of the attestor to retrieve, in the format `projects/*/attestors/*`.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets an attestor. Returns `NOT_FOUND` if the attestor does not exist.</summary>
            public class GetRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1.Data.Attestor>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the attestor to retrieve, in the format `projects/*/attestors/*`.
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
                        Pattern = @"^projects/[^/]+/attestors/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does
            /// not have a policy set.
            /// </summary>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual GetIamPolicyRequest GetIamPolicy(string resource)
            {
                return new GetIamPolicyRequest(this.service, resource);
            }

            /// <summary>
            /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does
            /// not have a policy set.
            /// </summary>
            public class GetIamPolicyRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1.Data.IamPolicy>
            {
                /// <summary>Constructs a new GetIamPolicy request.</summary>
                public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                {
                    Resource = resource;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>
                /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0, 1,
                /// and 3. Requests specifying an invalid value will be rejected. Requests for policies with any
                /// conditional role bindings must specify version 3. Policies with no conditional role bindings may
                /// specify any valid value or leave the field unset. The policy in the response might use the policy
                /// version that you specified, or it might use a lower policy version. For example, if you specify
                /// version 3, but the policy has no conditional role bindings, the response uses version 1. To learn
                /// which resources support conditions in their IAM policies, see the [IAM
                /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+resource}:getIamPolicy";

                /// <summary>Initializes GetIamPolicy parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resource",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/attestors/[^/]+$",
                    });
                    RequestParameters.Add("options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "options.requestedPolicyVersion",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists attestors. Returns `INVALID_ARGUMENT` if the project does not exist.</summary>
            /// <param name="parent">
            /// Required. The resource name of the project associated with the attestors, in the format `projects/*`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists attestors. Returns `INVALID_ARGUMENT` if the project does not exist.</summary>
            public class ListRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1.Data.ListAttestorsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the project associated with the attestors, in the format
                /// `projects/*`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Requested page size. The server may return fewer results than requested. If unspecified, the server
                /// will pick an appropriate default.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A token identifying a page of results the server should return. Typically, this is the value of
                /// ListAttestorsResponse.next_page_token returned from the previous call to the `ListAttestors` method.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/attestors";

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
            /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
            /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being specified. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.BinaryAuthorization.v1.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(this.service, body, resource);
            }

            /// <summary>
            /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
            /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
            /// </summary>
            public class SetIamPolicyRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1.Data.IamPolicy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BinaryAuthorization.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.BinaryAuthorization.v1.Data.SetIamPolicyRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "setIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+resource}:setIamPolicy";

                /// <summary>Initializes SetIamPolicy parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resource",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/attestors/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this
            /// will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be
            /// used for building permission-aware UIs and command-line tools, not for authorization checking. This
            /// operation may "fail open" without warning.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.BinaryAuthorization.v1.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(this.service, body, resource);
            }

            /// <summary>
            /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this
            /// will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be
            /// used for building permission-aware UIs and command-line tools, not for authorization checking. This
            /// operation may "fail open" without warning.
            /// </summary>
            public class TestIamPermissionsRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.BinaryAuthorization.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.BinaryAuthorization.v1.Data.TestIamPermissionsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "testIamPermissions";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+resource}:testIamPermissions";

                /// <summary>Initializes TestIamPermissions parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resource",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/attestors/[^/]+$",
                    });
                }
            }

            /// <summary>Updates an attestor. Returns `NOT_FOUND` if the attestor does not exist.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The resource name, in the format: `projects/*/attestors/*`. This field may not be updated.
            /// </param>
            public virtual UpdateRequest Update(Google.Apis.BinaryAuthorization.v1.Data.Attestor body, string name)
            {
                return new UpdateRequest(this.service, body, name);
            }

            /// <summary>Updates an attestor. Returns `NOT_FOUND` if the attestor does not exist.</summary>
            public class UpdateRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1.Data.Attestor>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.BinaryAuthorization.v1.Data.Attestor body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name, in the format: `projects/*/attestors/*`. This field may not be updated.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.BinaryAuthorization.v1.Data.Attestor Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^projects/[^/]+/attestors/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns whether the given `Attestation` for the given image URI was signed by the given `Attestor`
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="attestor">
            /// Required. The resource name of the Attestor of the occurrence, in the format `projects/*/attestors/*`.
            /// </param>
            public virtual ValidateAttestationOccurrenceRequest ValidateAttestationOccurrence(Google.Apis.BinaryAuthorization.v1.Data.ValidateAttestationOccurrenceRequest body, string attestor)
            {
                return new ValidateAttestationOccurrenceRequest(this.service, body, attestor);
            }

            /// <summary>
            /// Returns whether the given `Attestation` for the given image URI was signed by the given `Attestor`
            /// </summary>
            public class ValidateAttestationOccurrenceRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1.Data.ValidateAttestationOccurrenceResponse>
            {
                /// <summary>Constructs a new ValidateAttestationOccurrence request.</summary>
                public ValidateAttestationOccurrenceRequest(Google.Apis.Services.IClientService service, Google.Apis.BinaryAuthorization.v1.Data.ValidateAttestationOccurrenceRequest body, string attestor) : base(service)
                {
                    Attestor = attestor;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the Attestor of the occurrence, in the format
                /// `projects/*/attestors/*`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("attestor", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Attestor { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.BinaryAuthorization.v1.Data.ValidateAttestationOccurrenceRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "validateAttestationOccurrence";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+attestor}:validateAttestationOccurrence";

                /// <summary>Initializes ValidateAttestationOccurrence parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("attestor", new Google.Apis.Discovery.Parameter
                    {
                        Name = "attestor",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/attestors/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the Platforms resource.</summary>
        public virtual PlatformsResource Platforms { get; }

        /// <summary>The "platforms" collection of methods.</summary>
        public class PlatformsResource
        {
            private const string Resource = "platforms";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public PlatformsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Gke = new GkeResource(service);
                Policies = new PoliciesResource(service);
            }

            /// <summary>Gets the Gke resource.</summary>
            public virtual GkeResource Gke { get; }

            /// <summary>The "gke" collection of methods.</summary>
            public class GkeResource
            {
                private const string Resource = "gke";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public GkeResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Policies = new PoliciesResource(service);
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
                    /// Evaluates a Kubernetes object versus a GKE platform policy. Returns `NOT_FOUND` if the policy
                    /// doesn't exist, `INVALID_ARGUMENT` if the policy or request is malformed and `PERMISSION_DENIED`
                    /// if the client does not have sufficient permissions.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The name of the platform policy to evaluate in the format
                    /// `projects/*/platforms/*/policies/*`.
                    /// </param>
                    public virtual EvaluateRequest Evaluate(Google.Apis.BinaryAuthorization.v1.Data.EvaluateGkePolicyRequest body, string name)
                    {
                        return new EvaluateRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Evaluates a Kubernetes object versus a GKE platform policy. Returns `NOT_FOUND` if the policy
                    /// doesn't exist, `INVALID_ARGUMENT` if the policy or request is malformed and `PERMISSION_DENIED`
                    /// if the client does not have sufficient permissions.
                    /// </summary>
                    public class EvaluateRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1.Data.EvaluateGkePolicyResponse>
                    {
                        /// <summary>Constructs a new Evaluate request.</summary>
                        public EvaluateRequest(Google.Apis.Services.IClientService service, Google.Apis.BinaryAuthorization.v1.Data.EvaluateGkePolicyRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the platform policy to evaluate in the format
                        /// `projects/*/platforms/*/policies/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BinaryAuthorization.v1.Data.EvaluateGkePolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "evaluate";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:evaluate";

                        /// <summary>Initializes Evaluate parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/platforms/gke/policies/[^/]+$",
                            });
                        }
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
                /// Creates a platform policy, and returns a copy of it. Returns `NOT_FOUND` if the project or platform
                /// doesn't exist, `INVALID_ARGUMENT` if the request is malformed, `ALREADY_EXISTS` if the policy
                /// already exists, and `INVALID_ARGUMENT` if the policy contains a platform-specific policy that does
                /// not match the platform value specified in the URL.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The parent of this platform policy.</param>
                public virtual CreateRequest Create(Google.Apis.BinaryAuthorization.v1.Data.PlatformPolicy body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a platform policy, and returns a copy of it. Returns `NOT_FOUND` if the project or platform
                /// doesn't exist, `INVALID_ARGUMENT` if the request is malformed, `ALREADY_EXISTS` if the policy
                /// already exists, and `INVALID_ARGUMENT` if the policy contains a platform-specific policy that does
                /// not match the platform value specified in the URL.
                /// </summary>
                public class CreateRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1.Data.PlatformPolicy>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BinaryAuthorization.v1.Data.PlatformPolicy body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent of this platform policy.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. The platform policy ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("policyId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PolicyId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BinaryAuthorization.v1.Data.PlatformPolicy Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/policies";

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
                            Pattern = @"^projects/[^/]+/platforms/[^/]+$",
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

                /// <summary>Deletes a platform policy. Returns `NOT_FOUND` if the policy doesn't exist.</summary>
                /// <param name="name">
                /// Required. The name of the platform policy to delete, in the format
                /// `projects/*/platforms/*/policies/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a platform policy. Returns `NOT_FOUND` if the policy doesn't exist.</summary>
                public class DeleteRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the platform policy to delete, in the format
                    /// `projects/*/platforms/*/policies/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Used to prevent deleting the policy when another request has updated it since it was
                    /// retrieved.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

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
                            Pattern = @"^projects/[^/]+/platforms/[^/]+/policies/[^/]+$",
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

                /// <summary>Gets a platform policy. Returns `NOT_FOUND` if the policy doesn't exist.</summary>
                /// <param name="name">
                /// Required. The name of the platform policy to retrieve in the format
                /// `projects/*/platforms/*/policies/*`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a platform policy. Returns `NOT_FOUND` if the policy doesn't exist.</summary>
                public class GetRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1.Data.PlatformPolicy>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the platform policy to retrieve in the format
                    /// `projects/*/platforms/*/policies/*`.
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
                            Pattern = @"^projects/[^/]+/platforms/[^/]+/policies/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists platform policies owned by a project in the specified platform. Returns `INVALID_ARGUMENT` if
                /// the project or the platform doesn't exist.
                /// </summary>
                /// <param name="parent">
                /// Required. The resource name of the platform associated with the platform policies using the format
                /// `projects/*/platforms/*`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists platform policies owned by a project in the specified platform. Returns `INVALID_ARGUMENT` if
                /// the project or the platform doesn't exist.
                /// </summary>
                public class ListRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1.Data.ListPlatformPoliciesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the platform associated with the platform policies using the
                    /// format `projects/*/platforms/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Requested page size. The server may return fewer results than requested. If unspecified, the
                    /// server picks an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A token identifying a page of results the server should return. Typically, this is the value of
                    /// ListPlatformPoliciesResponse.next_page_token returned from the previous call to the
                    /// `ListPlatformPolicies` method.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/policies";

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
                            Pattern = @"^projects/[^/]+/platforms/[^/]+$",
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

                /// <summary>Replaces a platform policy. Returns `NOT_FOUND` if the policy doesn't exist.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. The relative resource name of the Binary Authorization platform policy, in the form of
                /// `projects/*/platforms/*/policies/*`.
                /// </param>
                public virtual ReplacePlatformPolicyRequest ReplacePlatformPolicy(Google.Apis.BinaryAuthorization.v1.Data.PlatformPolicy body, string name)
                {
                    return new ReplacePlatformPolicyRequest(this.service, body, name);
                }

                /// <summary>Replaces a platform policy. Returns `NOT_FOUND` if the policy doesn't exist.</summary>
                public class ReplacePlatformPolicyRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1.Data.PlatformPolicy>
                {
                    /// <summary>Constructs a new ReplacePlatformPolicy request.</summary>
                    public ReplacePlatformPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BinaryAuthorization.v1.Data.PlatformPolicy body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. The relative resource name of the Binary Authorization platform policy, in the form
                    /// of `projects/*/platforms/*/policies/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BinaryAuthorization.v1.Data.PlatformPolicy Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "replacePlatformPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes ReplacePlatformPolicy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/platforms/[^/]+/policies/[^/]+$",
                        });
                    }
                }
            }
        }

        /// <summary>Gets the Policy resource.</summary>
        public virtual PolicyResource Policy { get; }

        /// <summary>The "policy" collection of methods.</summary>
        public class PolicyResource
        {
            private const string Resource = "policy";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public PolicyResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does
            /// not have a policy set.
            /// </summary>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual GetIamPolicyRequest GetIamPolicy(string resource)
            {
                return new GetIamPolicyRequest(this.service, resource);
            }

            /// <summary>
            /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does
            /// not have a policy set.
            /// </summary>
            public class GetIamPolicyRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1.Data.IamPolicy>
            {
                /// <summary>Constructs a new GetIamPolicy request.</summary>
                public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                {
                    Resource = resource;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>
                /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0, 1,
                /// and 3. Requests specifying an invalid value will be rejected. Requests for policies with any
                /// conditional role bindings must specify version 3. Policies with no conditional role bindings may
                /// specify any valid value or leave the field unset. The policy in the response might use the policy
                /// version that you specified, or it might use a lower policy version. For example, if you specify
                /// version 3, but the policy has no conditional role bindings, the response uses version 1. To learn
                /// which resources support conditions in their IAM policies, see the [IAM
                /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+resource}:getIamPolicy";

                /// <summary>Initializes GetIamPolicy parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resource",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/policy$",
                    });
                    RequestParameters.Add("options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "options.requestedPolicyVersion",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
            /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being specified. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.BinaryAuthorization.v1.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(this.service, body, resource);
            }

            /// <summary>
            /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
            /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
            /// </summary>
            public class SetIamPolicyRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1.Data.IamPolicy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BinaryAuthorization.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.BinaryAuthorization.v1.Data.SetIamPolicyRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "setIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+resource}:setIamPolicy";

                /// <summary>Initializes SetIamPolicy parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resource",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/policy$",
                    });
                }
            }

            /// <summary>
            /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this
            /// will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be
            /// used for building permission-aware UIs and command-line tools, not for authorization checking. This
            /// operation may "fail open" without warning.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.BinaryAuthorization.v1.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(this.service, body, resource);
            }

            /// <summary>
            /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this
            /// will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be
            /// used for building permission-aware UIs and command-line tools, not for authorization checking. This
            /// operation may "fail open" without warning.
            /// </summary>
            public class TestIamPermissionsRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.BinaryAuthorization.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.BinaryAuthorization.v1.Data.TestIamPermissionsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "testIamPermissions";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+resource}:testIamPermissions";

                /// <summary>Initializes TestIamPermissions parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resource",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/policy$",
                    });
                }
            }
        }

        /// <summary>
        /// A policy specifies the attestors that must attest to a container image, before the project is allowed to
        /// deploy that image. There is at most one policy per project. All image admission requests are permitted if a
        /// project has no policy. Gets the policy for this project. Returns a default policy if the project does not
        /// have one.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the policy to retrieve, in the format `projects/*/policy`.
        /// </param>
        public virtual GetPolicyRequest GetPolicy(string name)
        {
            return new GetPolicyRequest(this.service, name);
        }

        /// <summary>
        /// A policy specifies the attestors that must attest to a container image, before the project is allowed to
        /// deploy that image. There is at most one policy per project. All image admission requests are permitted if a
        /// project has no policy. Gets the policy for this project. Returns a default policy if the project does not
        /// have one.
        /// </summary>
        public class GetPolicyRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1.Data.Policy>
        {
            /// <summary>Constructs a new GetPolicy request.</summary>
            public GetPolicyRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of the policy to retrieve, in the format `projects/*/policy`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes GetPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/policy$",
                });
            }
        }

        /// <summary>
        /// Creates or updates a project's policy, and returns a copy of the new policy. A policy is always updated as a
        /// whole, to avoid race conditions with concurrent policy enforcement (or management!) requests. Returns
        /// `NOT_FOUND` if the project does not exist, `INVALID_ARGUMENT` if the request is malformed.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Output only. The resource name, in the format `projects/*/policy`. There is at most one policy per project.
        /// </param>
        public virtual UpdatePolicyRequest UpdatePolicy(Google.Apis.BinaryAuthorization.v1.Data.Policy body, string name)
        {
            return new UpdatePolicyRequest(this.service, body, name);
        }

        /// <summary>
        /// Creates or updates a project's policy, and returns a copy of the new policy. A policy is always updated as a
        /// whole, to avoid race conditions with concurrent policy enforcement (or management!) requests. Returns
        /// `NOT_FOUND` if the project does not exist, `INVALID_ARGUMENT` if the request is malformed.
        /// </summary>
        public class UpdatePolicyRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1.Data.Policy>
        {
            /// <summary>Constructs a new UpdatePolicy request.</summary>
            public UpdatePolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BinaryAuthorization.v1.Data.Policy body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Output only. The resource name, in the format `projects/*/policy`. There is at most one policy per
            /// project.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.BinaryAuthorization.v1.Data.Policy Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updatePolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes UpdatePolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/policy$",
                });
            }
        }
    }

    /// <summary>The "systempolicy" collection of methods.</summary>
    public class SystempolicyResource
    {
        private const string Resource = "systempolicy";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SystempolicyResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets the current system policy in the specified location.</summary>
        /// <param name="name">
        /// Required. The resource name, in the format `locations/*/policy`. Note that the system policy is not
        /// associated with a project.
        /// </param>
        public virtual GetPolicyRequest GetPolicy(string name)
        {
            return new GetPolicyRequest(this.service, name);
        }

        /// <summary>Gets the current system policy in the specified location.</summary>
        public class GetPolicyRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1.Data.Policy>
        {
            /// <summary>Constructs a new GetPolicy request.</summary>
            public GetPolicyRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name, in the format `locations/*/policy`. Note that the system policy is not
            /// associated with a project.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes GetPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^locations/[^/]+/policy$",
                });
            }
        }
    }
}
namespace Google.Apis.BinaryAuthorization.v1.Data
{
    /// <summary>
    /// An admission rule specifies either that all container images used in a pod creation request must be attested to
    /// by one or more attestors, that all pod creations will be allowed, or that all pod creations will be denied.
    /// Images matching an admission allowlist pattern are exempted from admission rules and will never block a pod
    /// creation.
    /// </summary>
    public class AdmissionRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The action when a pod creation is denied by the admission rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enforcementMode")]
        public virtual string EnforcementMode { get; set; }

        /// <summary>Required. How this admission rule will be evaluated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationMode")]
        public virtual string EvaluationMode { get; set; }

        /// <summary>
        /// Optional. The resource names of the attestors that must attest to a container image, in the format
        /// `projects/*/attestors/*`. Each attestor must exist before a policy can reference it. To add an attestor to a
        /// policy the principal issuing the policy change request must be able to read the attestor resource. Note:
        /// this field must be non-empty when the `evaluation_mode` field specifies `REQUIRE_ATTESTATION`, otherwise it
        /// must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireAttestationsBy")]
        public virtual System.Collections.Generic.IList<string> RequireAttestationsBy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An admission allowlist pattern exempts images from checks by admission rules.</summary>
    public class AdmissionWhitelistPattern : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An image name pattern to allowlist, in the form `registry/path/to/image`. This supports a trailing `*`
        /// wildcard, but this is allowed only in text after the `registry/` part. This also supports a trailing `**`
        /// wildcard which matches subdirectories of a given entry.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namePattern")]
        public virtual string NamePattern { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result of evaluating an image name allowlist.</summary>
    public class AllowlistResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The allowlist pattern that the image matched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchedPattern")]
        public virtual string MatchedPattern { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An attestation authenticator that will be used to verify attestations. Typically this is just a set of public
    /// keys. Conceptually, an authenticator can be treated as always returning either "authenticated" or "not
    /// authenticated" when presented with a signed attestation (almost always assumed to be a
    /// [DSSE](https://github.com/secure-systems-lab/dsse) attestation). The details of how an authenticator makes this
    /// decision are specific to the type of 'authenticator' that this message wraps.
    /// </summary>
    public class AttestationAuthenticator : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A user-provided name for this `AttestationAuthenticator`. This field has no effect on the policy
        /// evaluation behavior except to improve readability of messages in evaluation results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Optional. A set of raw PKIX SubjectPublicKeyInfo format public keys. If any public key in the set validates
        /// the attestation signature, then the signature is considered authenticated (i.e. any one key is sufficient to
        /// authenticate).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pkixPublicKeySet")]
        public virtual PkixPublicKeySet PkixPublicKeySet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Occurrence that represents a single "attestation". The authenticity of an attestation can be verified using the
    /// attached signature. If the verifier trusts the public key of the signer, then verifying the signature is
    /// sufficient to establish trust. In this circumstance, the authority to which this attestation is attached is
    /// primarily useful for lookup (how to find this attestation if you already know the authority and artifact to be
    /// verified) and intent (for which authority this attestation was intended to sign.
    /// </summary>
    public class AttestationOccurrence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// One or more JWTs encoding a self-contained attestation. Each JWT encodes the payload that it verifies within
        /// the JWT itself. Verifier implementation SHOULD ignore the `serialized_payload` field when verifying these
        /// JWTs. If only JWTs are present on this AttestationOccurrence, then the `serialized_payload` SHOULD be left
        /// empty. Each JWT SHOULD encode a claim specific to the `resource_uri` of this Occurrence, but this is not
        /// validated by Grafeas metadata API implementations. The JWT itself is opaque to Grafeas.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jwts")]
        public virtual System.Collections.Generic.IList<Jwt> Jwts { get; set; }

        /// <summary>Required. The serialized payload that is verified by one or more `signatures`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serializedPayload")]
        public virtual string SerializedPayload { get; set; }

        /// <summary>
        /// One or more signatures over `serialized_payload`. Verifier implementations should consider this attestation
        /// message verified if at least one `signature` verifies `serialized_payload`. See `Signature` in common.proto
        /// for more details on signature structure and verification.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signatures")]
        public virtual System.Collections.Generic.IList<Signature> Signatures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the locations for fetching the provenance attestations.</summary>
    public class AttestationSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The IDs of the Google Cloud projects that store the SLSA attestations as Container Analysis Occurrences, in
        /// the format `projects/[PROJECT_ID]`. Maximum number of `container_analysis_attestation_projects` allowed in
        /// each `AttestationSource` is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerAnalysisAttestationProjects")]
        public virtual System.Collections.Generic.IList<string> ContainerAnalysisAttestationProjects { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An attestor that attests to container image artifacts. An existing attestor cannot be modified except where
    /// indicated.
    /// </summary>
    public class Attestor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A descriptive comment. This field may be updated. The field may be displayed in chooser dialogs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. A checksum, returned by the server, that can be sent on update requests to ensure the attestor has
        /// an up-to-date value before attempting to update it. See https://google.aip.dev/154.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Required. The resource name, in the format: `projects/*/attestors/*`. This field may not be updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Time when the attestor was last updated.</summary>
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
        /// This specifies how an attestation will be read, and how it will be used during policy enforcement.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userOwnedGrafeasNote")]
        public virtual UserOwnedGrafeasNote UserOwnedGrafeasNote { get; set; }
    }

    /// <summary>An attestor public key that will be used to verify attestations signed by this attestor.</summary>
    public class AttestorPublicKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// ASCII-armored representation of a PGP public key, as the entire output by the command `gpg --export --armor
        /// foo@example.com` (either LF or CRLF line endings). When using this field, `id` should be left blank. The
        /// Binary Authorization API handlers will calculate the ID and fill it in automatically. Binary Authorization
        /// computes this ID as the OpenPGP RFC4880 V4 fingerprint, represented as upper-case hex. If `id` is provided
        /// by the caller, it will be overwritten by the API-calculated ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asciiArmoredPgpPublicKey")]
        public virtual string AsciiArmoredPgpPublicKey { get; set; }

        /// <summary>Optional. A descriptive comment. This field may be updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comment")]
        public virtual string Comment { get; set; }

        /// <summary>
        /// The ID of this public key. Signatures verified by Binary Authorization must include the ID of the public key
        /// that can be used to verify them, and that ID must match the contents of this field exactly. Additional
        /// restrictions on this field can be imposed based on which public key type is encapsulated. See the
        /// documentation on `public_key` cases below for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// A raw PKIX SubjectPublicKeyInfo format public key. NOTE: `id` may be explicitly provided by the caller when
        /// using this type of public key, but it MUST be a valid RFC3986 URI. If `id` is left blank, a default one will
        /// be computed based on the digest of the DER encoding of the public key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pkixPublicKey")]
        public virtual PkixPublicKey PkixPublicKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Associates `members`, or principals, with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// principals in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

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
    /// A single check to perform against a Pod. Checks are grouped into `CheckSet` objects, which are defined by the
    /// top-level policy.
    /// </summary>
    public class Check : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A special-case check that always denies. Note that this still only applies when the scope of the
        /// `CheckSet` applies and the image isn't exempted by an image allowlist. This check is primarily useful for
        /// testing, or to set the default behavior for all unmatched scopes to "deny".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alwaysDeny")]
        public virtual System.Nullable<bool> AlwaysDeny { get; set; }

        /// <summary>
        /// Optional. A user-provided name for this check. This field has no effect on the policy evaluation behavior
        /// except to improve readability of messages in evaluation results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Optional. Images exempted from this check. If any of the patterns match the image url, the check will not be
        /// evaluated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageAllowlist")]
        public virtual ImageAllowlist ImageAllowlist { get; set; }

        /// <summary>
        /// Optional. Require that an image is no older than a configured expiration time. Image age is determined by
        /// its upload time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageFreshnessCheck")]
        public virtual ImageFreshnessCheck ImageFreshnessCheck { get; set; }

        /// <summary>
        /// Optional. Require that an image was signed by Cosign with a trusted key. This check requires that both the
        /// image and signature are stored in Artifact Registry.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sigstoreSignatureCheck")]
        public virtual SigstoreSignatureCheck SigstoreSignatureCheck { get; set; }

        /// <summary>Optional. Require a SimpleSigning-type attestation for every image in the deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("simpleSigningAttestationCheck")]
        public virtual SimpleSigningAttestationCheck SimpleSigningAttestationCheck { get; set; }

        /// <summary>
        /// Optional. Require that an image was built by a trusted builder (such as Google Cloud Build), meets
        /// requirements for Supply chain Levels for Software Artifacts (SLSA), and was built from a trusted source code
        /// repostitory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slsaCheck")]
        public virtual SlsaCheck SlsaCheck { get; set; }

        /// <summary>Optional. Require that an image lives in a trusted directory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trustedDirectoryCheck")]
        public virtual TrustedDirectoryCheck TrustedDirectoryCheck { get; set; }

        /// <summary>
        /// Optional. Require that an image does not contain vulnerabilities that violate the configured rules, such as
        /// based on severity levels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vulnerabilityCheck")]
        public virtual VulnerabilityCheck VulnerabilityCheck { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result of evaluating one check.</summary>
    public class CheckResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the image was exempted by an allow_pattern in the check, contains the pattern that the image name
        /// matched.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowlistResult")]
        public virtual AllowlistResult AllowlistResult { get; set; }

        /// <summary>The name of the check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>If a check was evaluated, contains the result of the check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationResult")]
        public virtual EvaluationResult EvaluationResult { get; set; }

        /// <summary>Explanation of this check result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explanation")]
        public virtual string Explanation { get; set; }

        /// <summary>The index of the check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<long> Index { get; set; }

        /// <summary>The type of the check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result of evaluating one or more checks.</summary>
    public class CheckResults : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Per-check details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<CheckResult> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A conjunction of policy checks, scoped to a particular namespace or Kubernetes service account. In order for
    /// evaluation of a `CheckSet` to return "allowed" for a given image in a given Pod, one of the following conditions
    /// must be satisfied: * The image is explicitly exempted by an entry in `image_allowlist`, OR * ALL of the `checks`
    /// evaluate to "allowed".
    /// </summary>
    public class CheckSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The checks to apply. The ultimate result of evaluating the check set will be "allow" if and only
        /// if every check in `checks` evaluates to "allow". If `checks` is empty, the default behavior is "always
        /// allow".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checks")]
        public virtual System.Collections.Generic.IList<Check> Checks { get; set; }

        /// <summary>
        /// Optional. A user-provided name for this `CheckSet`. This field has no effect on the policy evaluation
        /// behavior except to improve readability of messages in evaluation results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Optional. Images exempted from this `CheckSet`. If any of the patterns match the image being evaluated, no
        /// checks in the `CheckSet` will be evaluated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageAllowlist")]
        public virtual ImageAllowlist ImageAllowlist { get; set; }

        /// <summary>
        /// Optional. The scope to which this `CheckSet` applies. If unset or an empty string (the default), applies to
        /// all namespaces and service accounts. See the `Scope` message documentation for details on scoping rules.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual Scope Scope { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result of evaluating one check set.</summary>
    public class CheckSetResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the image was exempted by an allow_pattern in the check set, contains the pattern that the image name
        /// matched.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowlistResult")]
        public virtual AllowlistResult AllowlistResult { get; set; }

        /// <summary>If checks were evaluated, contains the results of evaluating each check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checkResults")]
        public virtual CheckResults CheckResults { get; set; }

        /// <summary>The name of the check set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Explanation of this check set result. Only populated if no checks were evaluated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explanation")]
        public virtual string Explanation { get; set; }

        /// <summary>The index of the check set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<long> Index { get; set; }

        /// <summary>The scope of the check set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual Scope Scope { get; set; }

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

    /// <summary>Request message for PlatformPolicyEvaluationService.EvaluateGkePolicy.</summary>
    public class EvaluateGkePolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. JSON or YAML blob representing a Kubernetes resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual System.Collections.Generic.IDictionary<string, object> Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for PlatformPolicyEvaluationService.EvaluateGkePolicy.</summary>
    public class EvaluateGkePolicyResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Evaluation result for each Pod contained in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<PodResult> Results { get; set; }

        /// <summary>The result of evaluating all Pods in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verdict")]
        public virtual string Verdict { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result of evaluating one check.</summary>
    public class EvaluationResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result of evaluating this check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verdict")]
        public virtual string Verdict { get; set; }

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
    /// A Binary Authorization policy for a GKE cluster. This is one type of policy that can occur as a
    /// `PlatformPolicy`.
    /// </summary>
    public class GkePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The `CheckSet` objects to apply, scoped by namespace or namespace and service account. Exactly one
        /// `CheckSet` will be evaluated for a given Pod (unless the list is empty, in which case the behavior is
        /// "always allow"). If multiple `CheckSet` objects have scopes that match the namespace and service account of
        /// the Pod being evaluated, only the `CheckSet` with the MOST SPECIFIC scope will match. `CheckSet` objects
        /// must be listed in order of decreasing specificity, i.e. if a scope matches a given service account (which
        /// must include the namespace), it must come before a `CheckSet` with a scope matching just that namespace.
        /// This property is enforced by server-side validation. The purpose of this restriction is to ensure that if
        /// more than one `CheckSet` matches a given Pod, the `CheckSet` that will be evaluated will always be the first
        /// in the list to match (because if any other matches, it must be less specific). If `check_sets` is empty, the
        /// default behavior is to allow all images. If `check_sets` is non-empty, the last `check_sets` entry must
        /// always be a `CheckSet` with no scope set, i.e. a catchall to handle any situation not caught by the
        /// preceding `CheckSet` objects.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checkSets")]
        public virtual System.Collections.Generic.IList<CheckSet> CheckSets { get; set; }

        /// <summary>
        /// Optional. Images exempted from this policy. If any of the patterns match the image being evaluated, the rest
        /// of the policy will not be evaluated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageAllowlist")]
        public virtual ImageAllowlist ImageAllowlist { get; set; }

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
    public class IamPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Associates a list of `members`, or principals, with a `role`. Optionally, may specify a `condition` that
        /// determines how and when the `bindings` are applied. Each of the `bindings` must contain at least one
        /// principal. The `bindings` in a `Policy` can refer to up to 1,500 principals; up to 250 of these principals
        /// can be Google groups. Each occurrence of a principal counts towards these limits. For example, if the
        /// `bindings` grant 50 different roles to `user:alice@example.com`, and not to any other principal, then you
        /// can add another 1,450 principals to the `bindings` in the `Policy`.
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

    /// <summary>Images that are exempted from normal checks based on name pattern only.</summary>
    public class ImageAllowlist : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A disjunction of image patterns to allow. If any of these patterns match, then the image is
        /// considered exempted by this allowlist.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowPattern")]
        public virtual System.Collections.Generic.IList<string> AllowPattern { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An image freshness check, which rejects images that were uploaded before the set number of days ago to the
    /// supported repositories.
    /// </summary>
    public class ImageFreshnessCheck : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The max number of days that is allowed since the image was uploaded. Must be greater than zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxUploadAgeDays")]
        public virtual System.Nullable<int> MaxUploadAgeDays { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result of evaluating one image.</summary>
    public class ImageResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the image was exempted by a top-level allow_pattern, contains the allowlist pattern that the image name
        /// matched.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowlistResult")]
        public virtual AllowlistResult AllowlistResult { get; set; }

        /// <summary>
        /// If a check set was evaluated, contains the result of the check set. Empty if there were no check sets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checkSetResult")]
        public virtual CheckSetResult CheckSetResult { get; set; }

        /// <summary>Explanation of this image result. Only populated if no check sets were evaluated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explanation")]
        public virtual string Explanation { get; set; }

        /// <summary>Image URI from the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; }

        /// <summary>The result of evaluating this image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verdict")]
        public virtual string Verdict { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Jwt : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The compact encoding of a JWS, which is always three base64 encoded strings joined by periods. For details,
        /// see: https://tools.ietf.org/html/rfc7515.html#section-3.1
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compactJwt")]
        public virtual string CompactJwt { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BinauthzManagementServiceV1.ListAttestors.</summary>
    public class ListAttestorsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of attestors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attestors")]
        public virtual System.Collections.Generic.IList<Attestor> Attestors { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Pass this value in the ListAttestorsRequest.page_token field
        /// in the subsequent call to the `ListAttestors` method to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for PlatformPolicyManagementService.ListPlatformPolicies.</summary>
    public class ListPlatformPoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token to retrieve the next page of results. Pass this value in the ListPlatformPoliciesRequest.page_token
        /// field in the subsequent call to the `ListPlatformPolicies` method to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of platform policies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platformPolicies")]
        public virtual System.Collections.Generic.IList<PlatformPolicy> PlatformPolicies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A public key in the PkixPublicKey [format](https://tools.ietf.org/html/rfc5280#section-4.1.2.7). Public keys of
    /// this type are typically textually encoded using the PEM format.
    /// </summary>
    public class PkixPublicKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The ID of this public key. Signatures verified by Binary Authorization must include the ID of the
        /// public key that can be used to verify them. The ID must match exactly contents of the `key_id` field
        /// exactly. The ID may be explicitly provided by the caller, but it MUST be a valid RFC3986 URI. If `key_id` is
        /// left blank and this `PkixPublicKey` is not used in the context of a wrapper (see next paragraph), a default
        /// key ID will be computed based on the digest of the DER encoding of the public key. If this `PkixPublicKey`
        /// is used in the context of a wrapper that has its own notion of key ID (e.g. `AttestorPublicKey`), then this
        /// field can either match that value exactly, or be left blank, in which case it behaves exactly as though it
        /// is equal to that wrapper value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyId")]
        public virtual string KeyId { get; set; }

        /// <summary>A PEM-encoded public key, as described in https://tools.ietf.org/html/rfc7468#section-13</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKeyPem")]
        public virtual string PublicKeyPem { get; set; }

        /// <summary>
        /// The signature algorithm used to verify a message against a signature using this key. These signature
        /// algorithm must match the structure and any object identifiers encoded in `public_key_pem` (i.e. this
        /// algorithm must match that of the public key).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signatureAlgorithm")]
        public virtual string SignatureAlgorithm { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A bundle of PKIX public keys, used to authenticate attestation signatures. Generally, a signature is considered
    /// to be authenticated by a `PkixPublicKeySet` if any of the public keys verify it (i.e. it is an "OR" of the
    /// keys).
    /// </summary>
    public class PkixPublicKeySet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. `pkix_public_keys` must have at least one entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pkixPublicKeys")]
        public virtual System.Collections.Generic.IList<PkixPublicKey> PkixPublicKeys { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Binary Authorization platform policy for deployments on various platforms.</summary>
    public class PlatformPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A description comment about the policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Used to prevent updating the policy when another request has updated it since it was retrieved.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Optional. GKE platform-specific policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gkePolicy")]
        public virtual GkePolicy GkePolicy { get; set; }

        /// <summary>
        /// Output only. The relative resource name of the Binary Authorization platform policy, in the form of
        /// `projects/*/platforms/*/policies/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Time when the policy was last updated.</summary>
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

    /// <summary>Result of evaluating the whole GKE policy for one Pod.</summary>
    public class PodResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Per-image details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageResults")]
        public virtual System.Collections.Generic.IList<ImageResult> ImageResults { get; set; }

        /// <summary>The Kubernetes namespace of the Pod.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kubernetesNamespace")]
        public virtual string KubernetesNamespace { get; set; }

        /// <summary>The Kubernetes service account of the Pod.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kubernetesServiceAccount")]
        public virtual string KubernetesServiceAccount { get; set; }

        /// <summary>The name of the Pod.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("podName")]
        public virtual string PodName { get; set; }

        /// <summary>The result of evaluating this Pod.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verdict")]
        public virtual string Verdict { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A policy for container image binary authorization.</summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Admission policy allowlisting. A matching admission request will always be permitted. This feature
        /// is typically used to exclude Google or third-party infrastructure images from Binary Authorization policies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("admissionWhitelistPatterns")]
        public virtual System.Collections.Generic.IList<AdmissionWhitelistPattern> AdmissionWhitelistPatterns { get; set; }

        /// <summary>
        /// Optional. A valid policy has only one of the following rule maps non-empty, i.e. only one of
        /// `cluster_admission_rules`, `kubernetes_namespace_admission_rules`,
        /// `kubernetes_service_account_admission_rules`, or `istio_service_identity_admission_rules` can be non-empty.
        /// Per-cluster admission rules. Cluster spec format: `location.clusterId`. There can be at most one admission
        /// rule per cluster spec. A `location` is either a compute zone (e.g. us-central1-a) or a region (e.g.
        /// us-central1). For `clusterId` syntax restrictions see
        /// https://cloud.google.com/container-engine/reference/rest/v1/projects.zones.clusters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterAdmissionRules")]
        public virtual System.Collections.Generic.IDictionary<string, AdmissionRule> ClusterAdmissionRules { get; set; }

        /// <summary>
        /// Required. Default admission rule for a cluster without a per-cluster, per- kubernetes-service-account, or
        /// per-istio-service-identity admission rule.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultAdmissionRule")]
        public virtual AdmissionRule DefaultAdmissionRule { get; set; }

        /// <summary>Optional. A descriptive comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. A checksum, returned by the server, that can be sent on update requests to ensure the policy has
        /// an up-to-date value before attempting to update it. See https://google.aip.dev/154.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. Controls the evaluation of a Google-maintained global admission policy for common system-level
        /// images. Images not covered by the global policy will be subject to the project admission policy. This
        /// setting has no effect when specified inside a global admission policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("globalPolicyEvaluationMode")]
        public virtual string GlobalPolicyEvaluationMode { get; set; }

        /// <summary>
        /// Optional. Per-istio-service-identity admission rules. Istio service identity spec format:
        /// `spiffe:///ns//sa/` or `/ns//sa/` e.g. `spiffe://example.com/ns/test-ns/sa/default`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("istioServiceIdentityAdmissionRules")]
        public virtual System.Collections.Generic.IDictionary<string, AdmissionRule> IstioServiceIdentityAdmissionRules { get; set; }

        /// <summary>
        /// Optional. Per-kubernetes-namespace admission rules. K8s namespace spec format: `[a-z.-]+`, e.g.
        /// `some-namespace`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kubernetesNamespaceAdmissionRules")]
        public virtual System.Collections.Generic.IDictionary<string, AdmissionRule> KubernetesNamespaceAdmissionRules { get; set; }

        /// <summary>
        /// Optional. Per-kubernetes-service-account admission rules. Service account spec format:
        /// `namespace:serviceaccount`. e.g. `test-ns:default`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kubernetesServiceAccountAdmissionRules")]
        public virtual System.Collections.Generic.IDictionary<string, AdmissionRule> KubernetesServiceAccountAdmissionRules { get; set; }

        /// <summary>
        /// Output only. The resource name, in the format `projects/*/policy`. There is at most one policy per project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Time when the policy was last updated.</summary>
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

    /// <summary>A scope specifier for `CheckSet` objects.</summary>
    public class Scope : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Matches all Kubernetes service accounts in the provided namespace, unless a more specific
        /// `kubernetes_service_account` scope already matched.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kubernetesNamespace")]
        public virtual string KubernetesNamespace { get; set; }

        /// <summary>
        /// Optional. Matches a single Kubernetes service account, e.g. `my-namespace:my-service-account`.
        /// `kubernetes_service_account` scope is always more specific than `kubernetes_namespace` scope for the same
        /// namespace.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kubernetesServiceAccount")]
        public virtual string KubernetesServiceAccount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Google Cloud services (such as Projects) might
        /// reject them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual IamPolicy Policy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Verifiers (e.g. Kritis implementations) MUST verify signatures with respect to the trust anchors defined in
    /// policy (e.g. a Kritis policy). Typically this means that the verifier has been configured with a map from
    /// `public_key_id` to public key material (and any required parameters, e.g. signing algorithm). In particular,
    /// verification implementations MUST NOT treat the signature `public_key_id` as anything more than a key lookup
    /// hint. The `public_key_id` DOES NOT validate or authenticate a public key; it only provides a mechanism for
    /// quickly selecting a public key ALREADY CONFIGURED on the verifier through a trusted channel. Verification
    /// implementations MUST reject signatures in any of the following circumstances: * The `public_key_id` is not
    /// recognized by the verifier. * The public key that `public_key_id` refers to does not verify the signature with
    /// respect to the payload. The `signature` contents SHOULD NOT be "attached" (where the payload is included with
    /// the serialized `signature` bytes). Verifiers MUST ignore any "attached" payload and only verify signatures with
    /// respect to explicitly provided payload (e.g. a `payload` field on the proto message that holds this Signature,
    /// or the canonical serialization of the proto message that holds this signature).
    /// </summary>
    public class Signature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The identifier for the public key that verifies this signature. * The `public_key_id` is required. * The
        /// `public_key_id` SHOULD be an RFC3986 conformant URI. * When possible, the `public_key_id` SHOULD be an
        /// immutable reference, such as a cryptographic digest. Examples of valid `public_key_id`s: OpenPGP V4 public
        /// key fingerprint: * "openpgp4fpr:74FAF3B861BDA0870C7B6DEF607E48D2A663AEEA" See
        /// https://www.iana.org/assignments/uri-schemes/prov/openpgp4fpr for more details on this scheme. RFC6920
        /// digest-named SubjectPublicKeyInfo (digest of the DER serialization): *
        /// "ni:///sha-256;cD9o9Cq6LG3jD0iKXqEi_vdjJGecm_iXkbqVoScViaU" *
        /// "nih:///sha-256;703f68f42aba2c6de30f488a5ea122fef76324679c9bf89791ba95a1271589a5"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKeyId")]
        public virtual string PublicKeyId { get; set; }

        /// <summary>
        /// The content of the signature, an opaque bytestring. The payload that this signature verifies MUST be
        /// unambiguously provided with the Signature during verification. A wrapper message might provide the payload
        /// explicitly. Alternatively, a message might have a canonical serialization that can always be unambiguously
        /// computed to derive the payload.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signature")]
        public virtual string SignatureValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Sigstore authority, used to verify signatures that are created by Sigstore. An authority is analogous to an
    /// attestation authenticator, verifying that a signature is valid or invalid.
    /// </summary>
    public class SigstoreAuthority : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A user-provided name for this `SigstoreAuthority`. This field has no effect on the policy
        /// evaluation behavior except to improve readability of messages in evaluation results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Required. A simple set of public keys. A signature is considered valid if any keys in the set validate the
        /// signature.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKeySet")]
        public virtual SigstorePublicKeySet PublicKeySet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Sigstore public key. `SigstorePublicKey` is the public key material used to authenticate Sigstore signatures.
    /// </summary>
    public class SigstorePublicKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The public key material in PEM format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKeyPem")]
        public virtual string PublicKeyPem { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A bundle of Sigstore public keys, used to verify Sigstore signatures. A signature is authenticated by a
    /// `SigstorePublicKeySet` if any of the keys verify it.
    /// </summary>
    public class SigstorePublicKeySet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. `public_keys` must have at least one entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKeys")]
        public virtual System.Collections.Generic.IList<SigstorePublicKey> PublicKeys { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Sigstore signature check, which verifies the Sigstore signature associated with an image.</summary>
    public class SigstoreSignatureCheck : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The authorities required by this check to verify the signature. A signature only needs to be
        /// verified by one authority to pass the check.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sigstoreAuthorities")]
        public virtual System.Collections.Generic.IList<SigstoreAuthority> SigstoreAuthorities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Require a signed [DSSE](https://github.com/secure-systems-lab/dsse) attestation with type SimpleSigning.
    /// </summary>
    public class SimpleSigningAttestationCheck : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The authenticators required by this check to verify an attestation. Typically this is one or more
        /// PKIX public keys for signature verification. Only one authenticator needs to consider an attestation
        /// verified in order for an attestation to be considered fully authenticated. In otherwords, this list of
        /// authenticators is an "OR" of the authenticator results. At least one authenticator is required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attestationAuthenticators")]
        public virtual System.Collections.Generic.IList<AttestationAuthenticator> AttestationAuthenticators { get; set; }

        /// <summary>
        /// Optional. The projects where attestations are stored as Container Analysis Occurrences, in the format
        /// `projects/[PROJECT_ID]`. Only one attestation needs to successfully verify an image for this check to pass,
        /// so a single verified attestation found in any of `container_analysis_attestation_projects` is sufficient for
        /// the check to pass. A project ID must be used, not a project number. When fetching Occurrences from Container
        /// Analysis, only `AttestationOccurrence` kinds are considered. In the future, additional Occurrence kinds may
        /// be added to the query. Maximum number of `container_analysis_attestation_projects` allowed in each
        /// `SimpleSigningAttestationCheck` is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerAnalysisAttestationProjects")]
        public virtual System.Collections.Generic.IList<string> ContainerAnalysisAttestationProjects { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A SLSA provenance attestation check, which ensures that images are built by a trusted builder using source code
    /// from its trusted repositories only.
    /// </summary>
    public class SlsaCheck : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies a list of verification rules for the SLSA attestations. An image is considered compliant with the
        /// SlsaCheck if any of the rules are satisfied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<VerificationRule> Rules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of permissions to check for the `resource`. Permissions with wildcards (such as `*` or `storage.*`)
        /// are not allowed. For more information see [IAM
        /// Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A subset of `TestPermissionsRequest.permissions` that the caller is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A trusted directory check, which rejects images that do not come from the set of user-configured trusted
    /// directories.
    /// </summary>
    public class TrustedDirectoryCheck : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. List of trusted directory patterns. A pattern is in the form "registry/path/to/directory". The
        /// registry domain part is defined as two or more dot-separated words, e.g., `us.pkg.dev`, or `gcr.io`.
        /// Additionally, `*` can be used in three ways as wildcards: 1. leading `*` to match varying prefixes in
        /// registry subdomain (useful for location prefixes); 2. trailing `*` after registry/ to match varying endings;
        /// 3. trailing `**` after registry/ to match "/" as well. For example: -- `gcr.io/my-project/my-repo` is valid
        /// to match a single directory -- `*-docker.pkg.dev/my-project/my-repo` or `*.gcr.io/my-project` are valid to
        /// match varying prefixes -- `gcr.io/my-project/*` will match all direct directories in `my-project` --
        /// `gcr.io/my-project/**` would match all directories in `my-project` -- `gcr.i*` is not allowed since the
        /// registry is not completely specified -- `sub*domain.gcr.io/nginx` is not valid because only leading `*` or
        /// trailing `*` are allowed. -- `*pkg.dev/my-project/my-repo` is not valid because leading `*` can only match
        /// subdomain -- `**-docker.pkg.dev` is not valid because one leading `*` is allowed, and that it cannot match
        /// `/`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trustedDirPatterns")]
        public virtual System.Collections.Generic.IList<string> TrustedDirPatterns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An user owned Grafeas note references a Grafeas Attestation.Authority Note created by the user.
    /// </summary>
    public class UserOwnedGrafeasNote : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. This field will contain the service account email address that this attestor will use as the
        /// principal when querying Container Analysis. Attestor administrators must grant this service account the IAM
        /// role needed to read attestations from the note_reference in Container Analysis
        /// (`containeranalysis.notes.occurrences.viewer`). This email address is fixed for the lifetime of the
        /// attestor, but callers should not make any other assumptions about the service account email; future versions
        /// may use an email based on a different naming pattern.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delegationServiceAccountEmail")]
        public virtual string DelegationServiceAccountEmail { get; set; }

        /// <summary>
        /// Required. The Grafeas resource name of a Attestation.Authority Note, created by the user, in the format:
        /// `projects/[PROJECT_ID]/notes/*`. This field may not be updated. A project ID must be used, not a project
        /// number. An attestation by this attestor is stored as a Grafeas Attestation.Authority Occurrence that names a
        /// container image and that links to this Note. Grafeas is an external dependency.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noteReference")]
        public virtual string NoteReference { get; set; }

        /// <summary>
        /// Optional. Public keys that verify attestations signed by this attestor. This field may be updated. If this
        /// field is non-empty, one of the specified public keys must verify that an attestation was signed by this
        /// attestor for the image specified in the admission request. If this field is empty, this attestor always
        /// returns that no valid attestations exist.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKeys")]
        public virtual System.Collections.Generic.IList<AttestorPublicKey> PublicKeys { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ValidationHelperV1.ValidateAttestationOccurrence.</summary>
    public class ValidateAttestationOccurrenceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. An AttestationOccurrence to be checked that it can be verified by the `Attestor`. It does not have
        /// to be an existing entity in Container Analysis. It must otherwise be a valid `AttestationOccurrence`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attestation")]
        public virtual AttestationOccurrence Attestation { get; set; }

        /// <summary>Required. The resource name of the Note to which the containing Occurrence is associated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("occurrenceNote")]
        public virtual string OccurrenceNote { get; set; }

        /// <summary>
        /// Required. The URI of the artifact (e.g. container image) that is the subject of the containing Occurrence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("occurrenceResourceUri")]
        public virtual string OccurrenceResourceUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ValidationHelperV1.ValidateAttestationOccurrence.</summary>
    public class ValidateAttestationOccurrenceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The reason for denial if the Attestation couldn't be validated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denialReason")]
        public virtual string DenialReason { get; set; }

        /// <summary>The result of the Attestation validation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual string Result { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies verification rules for evaluating the SLSA attestations including: which builders to trust, where to
    /// fetch the SLSA attestations generated by those builders, and other builder-specific evaluation rules such as
    /// which source repositories are trusted. An image is considered verified by the rule if any of the fetched SLSA
    /// attestations is verified.
    /// </summary>
    public class VerificationRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies where to fetch the provenances attestations generated by the builder (group).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attestationSource")]
        public virtual AttestationSource AttestationSource { get; set; }

        /// <summary>
        /// If true, require the image to be built from a top-level configuration. `trusted_source_repo_patterns`
        /// specifies the repositories containing this configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configBasedBuildRequired")]
        public virtual System.Nullable<bool> ConfigBasedBuildRequired { get; set; }

        /// <summary>
        /// Optional. A CEL expression for specifying custom constraints on the provenance payload. This can be used
        /// when users want to specify expectations on provenance fields that are not covered by the general check. For
        /// example, users can use this field to require that certain parameters should never be used during the build
        /// process.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customConstraints")]
        public virtual string CustomConstraints { get; set; }

        /// <summary>
        /// Each verification rule is used for evaluation against provenances generated by a specific builder (group).
        /// For some of the builders, such as the Google Cloud Build, users don't need to explicitly specify their roots
        /// of trust in the policy since the evaluation service can automatically fetch them based on the builder
        /// (group).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trustedBuilder")]
        public virtual string TrustedBuilder { get; set; }

        /// <summary>
        /// List of trusted source code repository URL patterns. These patterns match the full repository URL without
        /// its scheme (e.g. `https://`). The patterns must not include schemes. For example, the pattern
        /// `source.cloud.google.com/my-project/my-repo-name` matches the following URLs: -
        /// `source.cloud.google.com/my-project/my-repo-name` -
        /// `git+ssh://source.cloud.google.com/my-project/my-repo-name` -
        /// `https://source.cloud.google.com/my-project/my-repo-name` A pattern matches a URL either exactly or with `*`
        /// wildcards. `*` can be used in only two ways: 1. trailing `*` after hosturi/ to match varying endings; 2.
        /// trailing `**` after hosturi/ to match `/` as well. `*` and `**` can only be used as wildcards and can only
        /// occur at the end of the pattern after a `/`. (So it's not possible to match a URL that contains literal
        /// `*`.) For example: - `github.com/my-project/my-repo` is valid to match a single repo -
        /// `github.com/my-project/*` will match all direct repos in `my-project` - `github.com/**` matches all repos in
        /// GitHub
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trustedSourceRepoPatterns")]
        public virtual System.Collections.Generic.IList<string> TrustedSourceRepoPatterns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An image vulnerability check, which rejects images that violate the configured vulnerability rules.
    /// </summary>
    public class VulnerabilityCheck : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A list of specific CVEs to ignore even if the vulnerability level violates
        /// `maximumUnfixableSeverity` or `maximumFixableSeverity`. CVEs are listed in the format of Container Analysis
        /// note id. For example: - CVE-2021-20305 - CVE-2020-10543 The CVEs are applicable regardless of note provider
        /// project, e.g., an entry of `CVE-2021-20305` will allow vulnerabilities with a note name of either
        /// `projects/goog-vulnz/notes/CVE-2021-20305` or `projects/CUSTOM-PROJECT/notes/CVE-2021-20305`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedCves")]
        public virtual System.Collections.Generic.IList<string> AllowedCves { get; set; }

        /// <summary>
        /// Optional. A list of specific CVEs to always raise warnings about even if the vulnerability level meets
        /// `maximumUnfixableSeverity` or `maximumFixableSeverity`. CVEs are listed in the format of Container Analysis
        /// note id. For example: - CVE-2021-20305 - CVE-2020-10543 The CVEs are applicable regardless of note provider
        /// project, e.g., an entry of `CVE-2021-20305` will block vulnerabilities with a note name of either
        /// `projects/goog-vulnz/notes/CVE-2021-20305` or `projects/CUSTOM-PROJECT/notes/CVE-2021-20305`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockedCves")]
        public virtual System.Collections.Generic.IList<string> BlockedCves { get; set; }

        /// <summary>
        /// Optional. The projects where vulnerabilities are stored as Container Analysis Occurrences. Each project is
        /// expressed in the resource format of `projects/[PROJECT_ID]`, e.g., `projects/my-gcp-project`. An attempt
        /// will be made for each project to fetch vulnerabilities, and all valid vulnerabilities will be used to check
        /// against the vulnerability policy. If no valid scan is found in all projects configured here, an error will
        /// be returned for the check. Maximum number of `container_analysis_vulnerability_projects` allowed in each
        /// `VulnerabilityCheck` is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerAnalysisVulnerabilityProjects")]
        public virtual System.Collections.Generic.IList<string> ContainerAnalysisVulnerabilityProjects { get; set; }

        /// <summary>
        /// Required. The threshold for severity for which a fix is currently available. This field is required and must
        /// be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumFixableSeverity")]
        public virtual string MaximumFixableSeverity { get; set; }

        /// <summary>
        /// Required. The threshold for severity for which a fix isn't currently available. This field is required and
        /// must be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumUnfixableSeverity")]
        public virtual string MaximumUnfixableSeverity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
