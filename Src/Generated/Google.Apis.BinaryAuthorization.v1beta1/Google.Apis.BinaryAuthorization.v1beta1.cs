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

namespace Google.Apis.BinaryAuthorization.v1beta1
{
    /// <summary>The BinaryAuthorization Service.</summary>
    public class BinaryAuthorizationService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

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
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "binaryauthorization";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://binaryauthorization.googleapis.com/";
        #else
            "https://binaryauthorization.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://binaryauthorization.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Binary Authorization API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Binary Authorization API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
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
            /// Creates an attestor, and returns a copy of the new attestor. Returns NOT_FOUND if the project does not
            /// exist, INVALID_ARGUMENT if the request is malformed, ALREADY_EXISTS if the attestor already exists.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. The parent of this attestor.</param>
            public virtual CreateRequest Create(Google.Apis.BinaryAuthorization.v1beta1.Data.Attestor body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates an attestor, and returns a copy of the new attestor. Returns NOT_FOUND if the project does not
            /// exist, INVALID_ARGUMENT if the request is malformed, ALREADY_EXISTS if the attestor already exists.
            /// </summary>
            public class CreateRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1beta1.Data.Attestor>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BinaryAuthorization.v1beta1.Data.Attestor body, string parent) : base(service)
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
                Google.Apis.BinaryAuthorization.v1beta1.Data.Attestor Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/attestors";

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

            /// <summary>Deletes an attestor. Returns NOT_FOUND if the attestor does not exist.</summary>
            /// <param name="name">
            /// Required. The name of the attestors to delete, in the format `projects/*/attestors/*`.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes an attestor. Returns NOT_FOUND if the attestor does not exist.</summary>
            public class DeleteRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1beta1.Data.Empty>
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
                public override string RestPath => "v1beta1/{+name}";

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

            /// <summary>Gets an attestor. Returns NOT_FOUND if the attestor does not exist.</summary>
            /// <param name="name">
            /// Required. The name of the attestor to retrieve, in the format `projects/*/attestors/*`.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets an attestor. Returns NOT_FOUND if the attestor does not exist.</summary>
            public class GetRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1beta1.Data.Attestor>
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
                public override string RestPath => "v1beta1/{+name}";

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
            /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
            /// appropriate value for this field.
            /// </param>
            public virtual GetIamPolicyRequest GetIamPolicy(string resource)
            {
                return new GetIamPolicyRequest(service, resource);
            }

            /// <summary>
            /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does
            /// not have a policy set.
            /// </summary>
            public class GetIamPolicyRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1beta1.Data.IamPolicy>
            {
                /// <summary>Constructs a new GetIamPolicy request.</summary>
                public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                {
                    Resource = resource;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for
                /// the appropriate value for this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>
                /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests
                /// specifying an invalid value will be rejected. Requests for policies with any conditional bindings
                /// must specify version 3. Policies without any conditional bindings may specify any valid value or
                /// leave the field unset. To learn which resources support conditions in their IAM policies, see the
                /// [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+resource}:getIamPolicy";

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

            /// <summary>Lists attestors. Returns INVALID_ARGUMENT if the project does not exist.</summary>
            /// <param name="parent">
            /// Required. The resource name of the project associated with the attestors, in the format `projects/*`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists attestors. Returns INVALID_ARGUMENT if the project does not exist.</summary>
            public class ListRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1beta1.Data.ListAttestorsResponse>
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
                public override string RestPath => "v1beta1/{+parent}/attestors";

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
            /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
            /// appropriate value for this field.
            /// </param>
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.BinaryAuthorization.v1beta1.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(service, body, resource);
            }

            /// <summary>
            /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
            /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
            /// </summary>
            public class SetIamPolicyRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1beta1.Data.IamPolicy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BinaryAuthorization.v1beta1.Data.SetIamPolicyRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.BinaryAuthorization.v1beta1.Data.SetIamPolicyRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "setIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+resource}:setIamPolicy";

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
            /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation
            /// for the appropriate value for this field.
            /// </param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.BinaryAuthorization.v1beta1.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(service, body, resource);
            }

            /// <summary>
            /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this
            /// will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be
            /// used for building permission-aware UIs and command-line tools, not for authorization checking. This
            /// operation may "fail open" without warning.
            /// </summary>
            public class TestIamPermissionsRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1beta1.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.BinaryAuthorization.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                /// documentation for the appropriate value for this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.BinaryAuthorization.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "testIamPermissions";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+resource}:testIamPermissions";

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

            /// <summary>Updates an attestor. Returns NOT_FOUND if the attestor does not exist.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The resource name, in the format: `projects/*/attestors/*`. This field may not be updated.
            /// </param>
            public virtual UpdateRequest Update(Google.Apis.BinaryAuthorization.v1beta1.Data.Attestor body, string name)
            {
                return new UpdateRequest(service, body, name);
            }

            /// <summary>Updates an attestor. Returns NOT_FOUND if the attestor does not exist.</summary>
            public class UpdateRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1beta1.Data.Attestor>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.BinaryAuthorization.v1beta1.Data.Attestor body, string name) : base(service)
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
                Google.Apis.BinaryAuthorization.v1beta1.Data.Attestor Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

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
            /// Returns whether the given Attestation for the given image URI was signed by the given Attestor
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="attestor">
            /// Required. The resource name of the Attestor of the occurrence, in the format `projects/*/attestors/*`.
            /// </param>
            public virtual ValidateAttestationOccurrenceRequest ValidateAttestationOccurrence(Google.Apis.BinaryAuthorization.v1beta1.Data.ValidateAttestationOccurrenceRequest body, string attestor)
            {
                return new ValidateAttestationOccurrenceRequest(service, body, attestor);
            }

            /// <summary>
            /// Returns whether the given Attestation for the given image URI was signed by the given Attestor
            /// </summary>
            public class ValidateAttestationOccurrenceRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1beta1.Data.ValidateAttestationOccurrenceResponse>
            {
                /// <summary>Constructs a new ValidateAttestationOccurrence request.</summary>
                public ValidateAttestationOccurrenceRequest(Google.Apis.Services.IClientService service, Google.Apis.BinaryAuthorization.v1beta1.Data.ValidateAttestationOccurrenceRequest body, string attestor) : base(service)
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
                Google.Apis.BinaryAuthorization.v1beta1.Data.ValidateAttestationOccurrenceRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "validateAttestationOccurrence";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+attestor}:validateAttestationOccurrence";

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
            /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
            /// appropriate value for this field.
            /// </param>
            public virtual GetIamPolicyRequest GetIamPolicy(string resource)
            {
                return new GetIamPolicyRequest(service, resource);
            }

            /// <summary>
            /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does
            /// not have a policy set.
            /// </summary>
            public class GetIamPolicyRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1beta1.Data.IamPolicy>
            {
                /// <summary>Constructs a new GetIamPolicy request.</summary>
                public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                {
                    Resource = resource;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for
                /// the appropriate value for this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>
                /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests
                /// specifying an invalid value will be rejected. Requests for policies with any conditional bindings
                /// must specify version 3. Policies without any conditional bindings may specify any valid value or
                /// leave the field unset. To learn which resources support conditions in their IAM policies, see the
                /// [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+resource}:getIamPolicy";

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
            /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
            /// appropriate value for this field.
            /// </param>
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.BinaryAuthorization.v1beta1.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(service, body, resource);
            }

            /// <summary>
            /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
            /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
            /// </summary>
            public class SetIamPolicyRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1beta1.Data.IamPolicy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BinaryAuthorization.v1beta1.Data.SetIamPolicyRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.BinaryAuthorization.v1beta1.Data.SetIamPolicyRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "setIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+resource}:setIamPolicy";

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
            /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation
            /// for the appropriate value for this field.
            /// </param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.BinaryAuthorization.v1beta1.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(service, body, resource);
            }

            /// <summary>
            /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this
            /// will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be
            /// used for building permission-aware UIs and command-line tools, not for authorization checking. This
            /// operation may "fail open" without warning.
            /// </summary>
            public class TestIamPermissionsRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1beta1.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.BinaryAuthorization.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                /// documentation for the appropriate value for this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.BinaryAuthorization.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "testIamPermissions";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+resource}:testIamPermissions";

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
            return new GetPolicyRequest(service, name);
        }

        /// <summary>
        /// A policy specifies the attestors that must attest to a container image, before the project is allowed to
        /// deploy that image. There is at most one policy per project. All image admission requests are permitted if a
        /// project has no policy. Gets the policy for this project. Returns a default policy if the project does not
        /// have one.
        /// </summary>
        public class GetPolicyRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1beta1.Data.Policy>
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
            public override string RestPath => "v1beta1/{+name}";

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
        /// NOT_FOUND if the project does not exist, INVALID_ARGUMENT if the request is malformed.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Output only. The resource name, in the format `projects/*/policy`. There is at most one policy per project.
        /// </param>
        public virtual UpdatePolicyRequest UpdatePolicy(Google.Apis.BinaryAuthorization.v1beta1.Data.Policy body, string name)
        {
            return new UpdatePolicyRequest(service, body, name);
        }

        /// <summary>
        /// Creates or updates a project's policy, and returns a copy of the new policy. A policy is always updated as a
        /// whole, to avoid race conditions with concurrent policy enforcement (or management!) requests. Returns
        /// NOT_FOUND if the project does not exist, INVALID_ARGUMENT if the request is malformed.
        /// </summary>
        public class UpdatePolicyRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1beta1.Data.Policy>
        {
            /// <summary>Constructs a new UpdatePolicy request.</summary>
            public UpdatePolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BinaryAuthorization.v1beta1.Data.Policy body, string name) : base(service)
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
            Google.Apis.BinaryAuthorization.v1beta1.Data.Policy Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updatePolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/{+name}";

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
            return new GetPolicyRequest(service, name);
        }

        /// <summary>Gets the current system policy in the specified location.</summary>
        public class GetPolicyRequest : BinaryAuthorizationBaseServiceRequest<Google.Apis.BinaryAuthorization.v1beta1.Data.Policy>
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
            public override string RestPath => "v1beta1/{+name}";

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
namespace Google.Apis.BinaryAuthorization.v1beta1.Data
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
        /// this field must be non-empty when the evaluation_mode field specifies REQUIRE_ATTESTATION, otherwise it must
        /// be empty.
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
        /// An image name pattern to allowlist, in the form `registry/path/to/image`. This supports a trailing `*` as a
        /// wildcard, but this is allowed only in text after the `registry/` part. `*` wildcard does not match `/`,
        /// i.e., gcr.io/nginx* matches gcr.io/nginx@latest, but it does not match gcr.io/nginx/image. This also
        /// supports a trailing `**` wildcard which matches subdirectories, i.e., gcr.io/nginx** matches
        /// gcr.io/nginx/image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namePattern")]
        public virtual string NamePattern { get; set; }

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
        /// Required. The resource name, in the format: `projects/*/attestors/*`. This field may not be updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Time when the attestor was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>A Drydock ATTESTATION_AUTHORITY Note, created by the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userOwnedDrydockNote")]
        public virtual UserOwnedDrydockNote UserOwnedDrydockNote { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An attestor public key that will be used to verify attestations signed by this attestor.</summary>
    public class AttestorPublicKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// ASCII-armored representation of a PGP public key, as the entire output by the command `gpg --export --armor
        /// foo@example.com` (either LF or CRLF line endings). When using this field, `id` should be left blank. The
        /// BinAuthz API handlers will calculate the ID and fill it in automatically. BinAuthz computes this ID as the
        /// OpenPGP RFC4880 V4 fingerprint, represented as upper-case hex. If `id` is provided by the caller, it will be
        /// overwritten by the API-calculated ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asciiArmoredPgpPublicKey")]
        public virtual string AsciiArmoredPgpPublicKey { get; set; }

        /// <summary>Optional. A descriptive comment. This field may be updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comment")]
        public virtual string Comment { get; set; }

        /// <summary>
        /// The ID of this public key. Signatures verified by BinAuthz must include the ID of the public key that can be
        /// used to verify them, and that ID must match the contents of this field exactly. Additional restrictions on
        /// this field can be imposed based on which public key type is encapsulated. See the documentation on
        /// `public_key` cases below for details.
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

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty JSON
    /// object `{}`.
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
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
    public class IamPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
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

    /// <summary>Response message for BinauthzManagementService.ListAttestors.</summary>
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

    /// <summary>
    /// A public key in the PkixPublicKey format (see https://tools.ietf.org/html/rfc5280#section-4.1.2.7 for details).
    /// Public keys of this type are typically textually encoded using the PEM format.
    /// </summary>
    public class PkixPublicKey : Google.Apis.Requests.IDirectResponseSchema
    {
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
        /// Optional. Per-cluster admission rules. Cluster spec format: `location.clusterId`. There can be at most one
        /// admission rule per cluster spec. A `location` is either a compute zone (e.g. us-central1-a) or a region
        /// (e.g. us-central1). For `clusterId` syntax restrictions see
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
        /// Optional. Controls the evaluation of a Google-maintained global admission policy for common system-level
        /// images. Images not covered by the global policy will be subject to the project admission policy. This
        /// setting has no effect when specified inside a global admission policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("globalPolicyEvaluationMode")]
        public virtual string GlobalPolicyEvaluationMode { get; set; }

        /// <summary>
        /// Optional. Per-istio-service-identity admission rules. Istio service identity spec format: spiffe:///ns//sa/
        /// or /ns//sa/ e.g. spiffe://example.com/ns/test-ns/sa/default
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("istioServiceIdentityAdmissionRules")]
        public virtual System.Collections.Generic.IDictionary<string, AdmissionRule> IstioServiceIdentityAdmissionRules { get; set; }

        /// <summary>
        /// Optional. Per-kubernetes-namespace admission rules. K8s namespace spec format: [a-z.-]+, e.g.
        /// 'some-namespace'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kubernetesNamespaceAdmissionRules")]
        public virtual System.Collections.Generic.IDictionary<string, AdmissionRule> KubernetesNamespaceAdmissionRules { get; set; }

        /// <summary>
        /// Optional. Per-kubernetes-service-account admission rules. Service account spec format:
        /// `namespace:serviceaccount`. e.g. 'test-ns:default'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kubernetesServiceAccountAdmissionRules")]
        public virtual System.Collections.Generic.IDictionary<string, AdmissionRule> KubernetesServiceAccountAdmissionRules { get; set; }

        /// <summary>
        /// Output only. The resource name, in the format `projects/*/policy`. There is at most one policy per project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Time when the policy was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Cloud Platform services (such as Projects) might
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

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of permissions to check for the `resource`. Permissions with wildcards (such as '*' or 'storage.*')
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
    /// An user owned drydock note references a Drydock ATTESTATION_AUTHORITY Note created by the user.
    /// </summary>
    public class UserOwnedDrydockNote : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. This field will contain the service account email address that this Attestor will use as the
        /// principal when querying Container Analysis. Attestor administrators must grant this service account the IAM
        /// role needed to read attestations from the note_reference in Container Analysis
        /// (`containeranalysis.notes.occurrences.viewer`). This email address is fixed for the lifetime of the
        /// Attestor, but callers should not make any other assumptions about the service account email; future versions
        /// may use an email based on a different naming pattern.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delegationServiceAccountEmail")]
        public virtual string DelegationServiceAccountEmail { get; set; }

        /// <summary>
        /// Required. The Drydock resource name of a ATTESTATION_AUTHORITY Note, created by the user, in the format:
        /// `projects/*/notes/*` (or the legacy `providers/*/notes/*`). This field may not be updated. An attestation by
        /// this attestor is stored as a Drydock ATTESTATION_AUTHORITY Occurrence that names a container image and that
        /// links to this Note. Drydock is an external dependency.
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
        /// Required. An AttestationOccurrence to be checked that it can be verified by the Attestor. It does not have
        /// to be an existing entity in Container Analysis. It must otherwise be a valid AttestationOccurrence.
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
}
