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

namespace Google.Apis.OSConfig.v1beta
{
    /// <summary>The OSConfig Service.</summary>
    public class OSConfigService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public OSConfigService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public OSConfigService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "osconfig";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://osconfig.googleapis.com/";
        #else
            "https://osconfig.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://osconfig.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the OS Config API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the OS Config API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for OSConfig requests.</summary>
    public abstract class OSConfigBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new OSConfigBaseServiceRequest instance.</summary>
        protected OSConfigBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes OSConfig parameter list.</summary>
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
            GuestPolicies = new GuestPoliciesResource(service);
            PatchDeployments = new PatchDeploymentsResource(service);
            PatchJobs = new PatchJobsResource(service);
            Zones = new ZonesResource(service);
        }

        /// <summary>Gets the GuestPolicies resource.</summary>
        public virtual GuestPoliciesResource GuestPolicies { get; }

        /// <summary>The "guestPolicies" collection of methods.</summary>
        public class GuestPoliciesResource
        {
            private const string Resource = "guestPolicies";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public GuestPoliciesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Create an OS Config guest policy.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource name of the parent using one of the following forms: `projects/{project_number}`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.OSConfig.v1beta.Data.GuestPolicy body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Create an OS Config guest policy.</summary>
            public class CreateRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1beta.Data.GuestPolicy>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.OSConfig.v1beta.Data.GuestPolicy body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the parent using one of the following forms:
                /// `projects/{project_number}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. The logical name of the guest policy in the project with the following restrictions: *
                /// Must contain only lowercase letters, numbers, and hyphens. * Must start with a letter. * Must be
                /// between 1-63 characters. * Must end with a number or a letter. * Must be unique within the project.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("guestPolicyId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string GuestPolicyId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.OSConfig.v1beta.Data.GuestPolicy Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/guestPolicies";

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
                    RequestParameters.Add("guestPolicyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "guestPolicyId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Delete an OS Config guest policy.</summary>
            /// <param name="name">
            /// Required. The resource name of the guest policy using one of the following forms:
            /// `projects/{project_number}/guestPolicies/{guest_policy_id}`.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Delete an OS Config guest policy.</summary>
            public class DeleteRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1beta.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the guest policy using one of the following forms:
                /// `projects/{project_number}/guestPolicies/{guest_policy_id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^projects/[^/]+/guestPolicies/[^/]+$",
                    });
                }
            }

            /// <summary>Get an OS Config guest policy.</summary>
            /// <param name="name">
            /// Required. The resource name of the guest policy using one of the following forms:
            /// `projects/{project_number}/guestPolicies/{guest_policy_id}`.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Get an OS Config guest policy.</summary>
            public class GetRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1beta.Data.GuestPolicy>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the guest policy using one of the following forms:
                /// `projects/{project_number}/guestPolicies/{guest_policy_id}`.
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
                        Pattern = @"^projects/[^/]+/guestPolicies/[^/]+$",
                    });
                }
            }

            /// <summary>Get a page of OS Config guest policies.</summary>
            /// <param name="parent">
            /// Required. The resource name of the parent using one of the following forms: `projects/{project_number}`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Get a page of OS Config guest policies.</summary>
            public class ListRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1beta.Data.ListGuestPoliciesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the parent using one of the following forms:
                /// `projects/{project_number}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>The maximum number of guest policies to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A pagination token returned from a previous call to `ListGuestPolicies` that indicates where this
                /// listing should continue from.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/guestPolicies";

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

            /// <summary>Update an OS Config guest policy.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Unique name of the resource in this project using one of the following forms:
            /// `projects/{project_number}/guestPolicies/{guest_policy_id}`.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.OSConfig.v1beta.Data.GuestPolicy body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Update an OS Config guest policy.</summary>
            public class PatchRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1beta.Data.GuestPolicy>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.OSConfig.v1beta.Data.GuestPolicy body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Unique name of the resource in this project using one of the following forms:
                /// `projects/{project_number}/guestPolicies/{guest_policy_id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Field mask that controls which fields of the guest policy should be updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.OSConfig.v1beta.Data.GuestPolicy Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^projects/[^/]+/guestPolicies/[^/]+$",
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

        /// <summary>Gets the PatchDeployments resource.</summary>
        public virtual PatchDeploymentsResource PatchDeployments { get; }

        /// <summary>The "patchDeployments" collection of methods.</summary>
        public class PatchDeploymentsResource
        {
            private const string Resource = "patchDeployments";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public PatchDeploymentsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Create an OS Config patch deployment.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The project to apply this patch deployment to in the form `projects/*`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.OSConfig.v1beta.Data.PatchDeployment body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Create an OS Config patch deployment.</summary>
            public class CreateRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1beta.Data.PatchDeployment>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.OSConfig.v1beta.Data.PatchDeployment body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The project to apply this patch deployment to in the form `projects/*`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. A name for the patch deployment in the project. When creating a name the following rules
                /// apply: * Must contain only lowercase letters, numbers, and hyphens. * Must start with a letter. *
                /// Must be between 1-63 characters. * Must end with a number or a letter. * Must be unique within the
                /// project.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("patchDeploymentId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PatchDeploymentId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.OSConfig.v1beta.Data.PatchDeployment Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/patchDeployments";

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
                    RequestParameters.Add("patchDeploymentId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "patchDeploymentId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Delete an OS Config patch deployment.</summary>
            /// <param name="name">
            /// Required. The resource name of the patch deployment in the form `projects/*/patchDeployments/*`.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Delete an OS Config patch deployment.</summary>
            public class DeleteRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1beta.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the patch deployment in the form `projects/*/patchDeployments/*`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^projects/[^/]+/patchDeployments/[^/]+$",
                    });
                }
            }

            /// <summary>Get an OS Config patch deployment.</summary>
            /// <param name="name">
            /// Required. The resource name of the patch deployment in the form `projects/*/patchDeployments/*`.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Get an OS Config patch deployment.</summary>
            public class GetRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1beta.Data.PatchDeployment>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the patch deployment in the form `projects/*/patchDeployments/*`.
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
                        Pattern = @"^projects/[^/]+/patchDeployments/[^/]+$",
                    });
                }
            }

            /// <summary>Get a page of OS Config patch deployments.</summary>
            /// <param name="parent">Required. The resource name of the parent in the form `projects/*`.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Get a page of OS Config patch deployments.</summary>
            public class ListRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1beta.Data.ListPatchDeploymentsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The resource name of the parent in the form `projects/*`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional. The maximum number of patch deployments to return. Default is 100.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A pagination token returned from a previous call to ListPatchDeployments that indicates
                /// where this listing should continue from.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/patchDeployments";

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

        /// <summary>Gets the PatchJobs resource.</summary>
        public virtual PatchJobsResource PatchJobs { get; }

        /// <summary>The "patchJobs" collection of methods.</summary>
        public class PatchJobsResource
        {
            private const string Resource = "patchJobs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public PatchJobsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                InstanceDetails = new InstanceDetailsResource(service);
            }

            /// <summary>Gets the InstanceDetails resource.</summary>
            public virtual InstanceDetailsResource InstanceDetails { get; }

            /// <summary>The "instanceDetails" collection of methods.</summary>
            public class InstanceDetailsResource
            {
                private const string Resource = "instanceDetails";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public InstanceDetailsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Get a list of instance details for a given patch job.</summary>
                /// <param name="parent">
                /// Required. The parent for the instances are in the form of `projects/*/patchJobs/*`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Get a list of instance details for a given patch job.</summary>
                public class ListRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1beta.Data.ListPatchJobInstanceDetailsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent for the instances are in the form of `projects/*/patchJobs/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// A filter expression that filters results listed in the response. This field supports filtering
                    /// results by instance zone, name, state, or `failure_reason`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>The maximum number of instance details records to return. Default is 100.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A pagination token returned from a previous call that indicates where this listing should
                    /// continue from.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/instanceDetails";

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
                            Pattern = @"^projects/[^/]+/patchJobs/[^/]+$",
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

            /// <summary>
            /// Cancel a patch job. The patch job must be active. Canceled patch jobs cannot be restarted.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. Name of the patch in the form `projects/*/patchJobs/*`</param>
            public virtual CancelRequest Cancel(Google.Apis.OSConfig.v1beta.Data.CancelPatchJobRequest body, string name)
            {
                return new CancelRequest(service, body, name);
            }

            /// <summary>
            /// Cancel a patch job. The patch job must be active. Canceled patch jobs cannot be restarted.
            /// </summary>
            public class CancelRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1beta.Data.PatchJob>
            {
                /// <summary>Constructs a new Cancel request.</summary>
                public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.OSConfig.v1beta.Data.CancelPatchJobRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Name of the patch in the form `projects/*/patchJobs/*`</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.OSConfig.v1beta.Data.CancelPatchJobRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "cancel";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}:cancel";

                /// <summary>Initializes Cancel parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/patchJobs/[^/]+$",
                    });
                }
            }

            /// <summary>Patch VM instances by creating and running a patch job.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. The project in which to run this patch in the form `projects/*`</param>
            public virtual ExecuteRequest Execute(Google.Apis.OSConfig.v1beta.Data.ExecutePatchJobRequest body, string parent)
            {
                return new ExecuteRequest(service, body, parent);
            }

            /// <summary>Patch VM instances by creating and running a patch job.</summary>
            public class ExecuteRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1beta.Data.PatchJob>
            {
                /// <summary>Constructs a new Execute request.</summary>
                public ExecuteRequest(Google.Apis.Services.IClientService service, Google.Apis.OSConfig.v1beta.Data.ExecutePatchJobRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The project in which to run this patch in the form `projects/*`</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.OSConfig.v1beta.Data.ExecutePatchJobRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "execute";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/patchJobs:execute";

                /// <summary>Initializes Execute parameter list.</summary>
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
            /// Get the patch job. This can be used to track the progress of an ongoing patch job or review the details
            /// of completed jobs.
            /// </summary>
            /// <param name="name">Required. Name of the patch in the form `projects/*/patchJobs/*`</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Get the patch job. This can be used to track the progress of an ongoing patch job or review the details
            /// of completed jobs.
            /// </summary>
            public class GetRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1beta.Data.PatchJob>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Name of the patch in the form `projects/*/patchJobs/*`</summary>
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
                        Pattern = @"^projects/[^/]+/patchJobs/[^/]+$",
                    });
                }
            }

            /// <summary>Get a list of patch jobs.</summary>
            /// <param name="parent">Required. In the form of `projects/*`</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Get a list of patch jobs.</summary>
            public class ListRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1beta.Data.ListPatchJobsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. In the form of `projects/*`</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// If provided, this field specifies the criteria that must be met by patch jobs to be included in the
                /// response. Currently, filtering is only available on the patch_deployment field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>The maximum number of instance status to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A pagination token returned from a previous call that indicates where this listing should continue
                /// from.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/patchJobs";

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

        /// <summary>Gets the Zones resource.</summary>
        public virtual ZonesResource Zones { get; }

        /// <summary>The "zones" collection of methods.</summary>
        public class ZonesResource
        {
            private const string Resource = "zones";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ZonesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Instances = new InstancesResource(service);
            }

            /// <summary>Gets the Instances resource.</summary>
            public virtual InstancesResource Instances { get; }

            /// <summary>The "instances" collection of methods.</summary>
            public class InstancesResource
            {
                private const string Resource = "instances";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public InstancesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Lookup the effective guest policy that applies to a VM instance. This lookup merges all policies
                /// that are assigned to the instance ancestry.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="instance">Required. The VM instance whose policies are being looked up.</param>
                public virtual LookupEffectiveGuestPolicyRequest LookupEffectiveGuestPolicy(Google.Apis.OSConfig.v1beta.Data.LookupEffectiveGuestPolicyRequest body, string instance)
                {
                    return new LookupEffectiveGuestPolicyRequest(service, body, instance);
                }

                /// <summary>
                /// Lookup the effective guest policy that applies to a VM instance. This lookup merges all policies
                /// that are assigned to the instance ancestry.
                /// </summary>
                public class LookupEffectiveGuestPolicyRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1beta.Data.EffectiveGuestPolicy>
                {
                    /// <summary>Constructs a new LookupEffectiveGuestPolicy request.</summary>
                    public LookupEffectiveGuestPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.OSConfig.v1beta.Data.LookupEffectiveGuestPolicyRequest body, string instance) : base(service)
                    {
                        Instance = instance;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The VM instance whose policies are being looked up.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Instance { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OSConfig.v1beta.Data.LookupEffectiveGuestPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "lookupEffectiveGuestPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+instance}:lookupEffectiveGuestPolicy";

                    /// <summary>Initializes LookupEffectiveGuestPolicy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                        {
                            Name = "instance",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/zones/[^/]+/instances/[^/]+$",
                        });
                    }
                }
            }
        }
    }
}
namespace Google.Apis.OSConfig.v1beta.Data
{
    /// <summary>
    /// Represents a single Apt package repository. This repository is added to a repo file that is stored at
    /// `/etc/apt/sources.list.d/google_osconfig.list`.
    /// </summary>
    public class AptRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type of archive files in this repository. The default behavior is DEB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("archiveType")]
        public virtual string ArchiveType { get; set; }

        /// <summary>Required. List of components for this repository. Must contain at least one item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("components")]
        public virtual System.Collections.Generic.IList<string> Components { get; set; }

        /// <summary>Required. Distribution of this repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distribution")]
        public virtual string Distribution { get; set; }

        /// <summary>
        /// URI of the key file for this repository. The agent maintains a keyring at
        /// `/etc/apt/trusted.gpg.d/osconfig_agent_managed.gpg` containing all the keys in any applied guest policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpgKey")]
        public virtual string GpgKey { get; set; }

        /// <summary>Required. URI for this repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Apt patching is completed by executing `apt-get update &amp;amp;&amp;amp; apt-get upgrade`. Additional options
    /// can be set to control how this is executed.
    /// </summary>
    public class AptSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of packages to exclude from update. These packages will be excluded</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludes")]
        public virtual System.Collections.Generic.IList<string> Excludes { get; set; }

        /// <summary>
        /// An exclusive list of packages to be updated. These are the only packages that will be updated. If these
        /// packages are not installed, they will be ignored. This field cannot be specified with any other patch
        /// configuration fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusivePackages")]
        public virtual System.Collections.Generic.IList<string> ExclusivePackages { get; set; }

        /// <summary>
        /// By changing the type to DIST, the patching is performed using `apt-get dist-upgrade` instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An assignment represents the group or groups of VM instances that the policy applies to. If an assignment is
    /// empty, it applies to all VM instances. Otherwise, the targeted VM instances must meet all the criteria
    /// specified. So if both labels and zones are specified, the policy applies to VM instances with those labels and
    /// in those zones.
    /// </summary>
    public class Assignment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Targets instances matching at least one of these label sets. This allows an assignment to target disparate
        /// groups, for example "env=prod or env=staging".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupLabels")]
        public virtual System.Collections.Generic.IList<AssignmentGroupLabel> GroupLabels { get; set; }

        /// <summary>
        /// Targets VM instances whose name starts with one of these prefixes. Like labels, this is another way to group
        /// VM instances when targeting configs, for example prefix="prod-". Only supported for project-level policies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceNamePrefixes")]
        public virtual System.Collections.Generic.IList<string> InstanceNamePrefixes { get; set; }

        /// <summary>
        /// Targets any of the instances specified. Instances are specified by their URI in the form
        /// `zones/[ZONE]/instances/[INSTANCE_NAME]`. Instance targeting is uncommon and is supported to facilitate the
        /// management of changes by the instance or to target specific VM instances for development and testing. Only
        /// supported for project-level policies and must reference instances within this project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<string> Instances { get; set; }

        /// <summary>
        /// Targets VM instances matching at least one of the following OS types. VM instances must match all supplied
        /// criteria for a given OsType to be included.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osTypes")]
        public virtual System.Collections.Generic.IList<AssignmentOsType> OsTypes { get; set; }

        /// <summary>
        /// Targets instances in any of these zones. Leave empty to target instances in any zone. Zonal targeting is
        /// uncommon and is supported to facilitate the management of changes by zone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zones")]
        public virtual System.Collections.Generic.IList<string> Zones { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a group of VM intances that can be identified as having all these labels, for example "env=prod and
    /// app=web".
    /// </summary>
    public class AssignmentGroupLabel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Compute Engine instance labels that must be present for an instance to be included in this assignment
        /// group.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines the criteria for selecting VM Instances by OS type.</summary>
    public class AssignmentOsType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Targets VM instances with OS Inventory enabled and having the following OS architecture.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osArchitecture")]
        public virtual string OsArchitecture { get; set; }

        /// <summary>
        /// Targets VM instances with OS Inventory enabled and having the following OS short name, for example "debian"
        /// or "windows".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osShortName")]
        public virtual string OsShortName { get; set; }

        /// <summary>
        /// Targets VM instances with OS Inventory enabled and having the following following OS version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osVersion")]
        public virtual string OsVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for canceling a patch job.</summary>
    public class CancelPatchJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The effective guest policy that applies to a VM instance.</summary>
    public class EffectiveGuestPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of package repository configurations assigned to the VM instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageRepositories")]
        public virtual System.Collections.Generic.IList<EffectiveGuestPolicySourcedPackageRepository> PackageRepositories { get; set; }

        /// <summary>List of package configurations assigned to the VM instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packages")]
        public virtual System.Collections.Generic.IList<EffectiveGuestPolicySourcedPackage> Packages { get; set; }

        /// <summary>List of recipes assigned to the VM instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("softwareRecipes")]
        public virtual System.Collections.Generic.IList<EffectiveGuestPolicySourcedSoftwareRecipe> SoftwareRecipes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A guest policy package including its source.</summary>
    public class EffectiveGuestPolicySourcedPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A software package to configure on the VM instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("package")]
        public virtual Package Package { get; set; }

        /// <summary>Name of the guest policy providing this config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A guest policy package repository including its source.</summary>
    public class EffectiveGuestPolicySourcedPackageRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A software package repository to configure on the VM instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageRepository")]
        public virtual PackageRepository PackageRepository { get; set; }

        /// <summary>Name of the guest policy providing this config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A guest policy recipe including its source.</summary>
    public class EffectiveGuestPolicySourcedSoftwareRecipe : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A software recipe to configure on the VM instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("softwareRecipe")]
        public virtual SoftwareRecipe SoftwareRecipe { get; set; }

        /// <summary>Name of the guest policy providing this config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

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

    /// <summary>A step that runs an executable for a PatchJob.</summary>
    public class ExecStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ExecStepConfig for all Linux VMs targeted by the PatchJob.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linuxExecStepConfig")]
        public virtual ExecStepConfig LinuxExecStepConfig { get; set; }

        /// <summary>The ExecStepConfig for all Windows VMs targeted by the PatchJob.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("windowsExecStepConfig")]
        public virtual ExecStepConfig WindowsExecStepConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Common configurations for an ExecStep.</summary>
    public class ExecStepConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Defaults to [0]. A list of possible return values that the execution can return to indicate a success.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedSuccessCodes")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> AllowedSuccessCodes { get; set; }

        /// <summary>A Google Cloud Storage object containing the executable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsObject")]
        public virtual GcsObject GcsObject { get; set; }

        /// <summary>
        /// The script interpreter to use to run the script. If no interpreter is specified the script will be executed
        /// directly, which will likely only succeed for scripts with [shebang lines]
        /// (https://en.wikipedia.org/wiki/Shebang_\(Unix\)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interpreter")]
        public virtual string Interpreter { get; set; }

        /// <summary>An absolute path to the executable on the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localPath")]
        public virtual string LocalPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request message to initiate patching across Compute Engine instances.</summary>
    public class ExecutePatchJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the patch job. Length of the description is limited to 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Display name for this patch job. This does not have to be unique.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>If this patch is a dry-run only, instances are contacted but will do nothing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dryRun")]
        public virtual System.Nullable<bool> DryRun { get; set; }

        /// <summary>Duration of the patch job. After the duration ends, the patch job times out.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>
        /// Required. Instances to patch, either explicitly or filtered by some criteria such as zone or labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceFilter")]
        public virtual PatchInstanceFilter InstanceFilter { get; set; }

        /// <summary>
        /// Patch configuration being applied. If omitted, instances are patched using the default configurations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("patchConfig")]
        public virtual PatchConfig PatchConfig { get; set; }

        /// <summary>Rollout strategy of the patch job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollout")]
        public virtual PatchRollout Rollout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message encapsulating a value that can be either absolute ("fixed") or relative ("percent") to a value.
    /// </summary>
    public class FixedOrPercent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies a fixed value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixed")]
        public virtual System.Nullable<int> Fixed__ { get; set; }

        /// <summary>
        /// Specifies the relative value defined as a percentage, which will be multiplied by a reference value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percent")]
        public virtual System.Nullable<int> Percent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Google Cloud Storage object representation.</summary>
    public class GcsObject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Bucket of the Google Cloud Storage object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>
        /// Required. Generation number of the Google Cloud Storage object. This is used to ensure that the ExecStep
        /// specified by this PatchJob does not change.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generationNumber")]
        public virtual System.Nullable<long> GenerationNumber { get; set; }

        /// <summary>Required. Name of the Google Cloud Storage object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("object")]
        public virtual string Object__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a Goo package repository. These is added to a repo file that is stored at
    /// C:/ProgramData/GooGet/repos/google_osconfig.repo.
    /// </summary>
    public class GooRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The url of the repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Googet patching is performed by running `googet update`.</summary>
    public class GooSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An OS Config resource representing a guest configuration policy. These policies represent the desired state for
    /// VM instance guest environments including packages to install or remove, package repository configurations, and
    /// software to install.
    /// </summary>
    public class GuestPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Specifies the VM instances that are assigned to this policy. This allows you to target sets or
        /// groups of VM instances by different parameters such as labels, names, OS, or zones. If left empty, all VM
        /// instances underneath this policy are targeted. At the same level in the resource hierarchy (that is within a
        /// project), the service prevents the creation of multiple policies that conflict with each other. For more
        /// information, see how the service [handles assignment
        /// conflicts](/compute/docs/os-config-management/create-guest-policy#handle-conflicts).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignment")]
        public virtual Assignment Assignment { get; set; }

        /// <summary>Output only. Time this guest policy was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Description of the guest policy. Length of the description is limited to 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The etag for this guest policy. If this is provided on update, it must match the server's etag.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Required. Unique name of the resource in this project using one of the following forms:
        /// `projects/{project_number}/guestPolicies/{guest_policy_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// A list of package repositories to configure on the VM instance. This is done before any other configs are
        /// applied so they can use these repos. Package repositories are only configured if the corresponding package
        /// manager(s) are available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageRepositories")]
        public virtual System.Collections.Generic.IList<PackageRepository> PackageRepositories { get; set; }

        /// <summary>The software packages to be managed by this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packages")]
        public virtual System.Collections.Generic.IList<Package> Packages { get; set; }

        /// <summary>A list of Recipes to install on the VM instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recipes")]
        public virtual System.Collections.Generic.IList<SoftwareRecipe> Recipes { get; set; }

        /// <summary>Output only. Last time this guest policy was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }
    }

    /// <summary>A response message for listing guest policies.</summary>
    public class ListGuestPoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of GuestPolicies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guestPolicies")]
        public virtual System.Collections.Generic.IList<GuestPolicy> GuestPolicies { get; set; }

        /// <summary>A pagination token that can be used to get the next page of guest policies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response message for listing patch deployments.</summary>
    public class ListPatchDeploymentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A pagination token that can be used to get the next page of patch deployments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of patch deployments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("patchDeployments")]
        public virtual System.Collections.Generic.IList<PatchDeployment> PatchDeployments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response message for listing the instances details for a patch job.</summary>
    public class ListPatchJobInstanceDetailsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A pagination token that can be used to get the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of instance status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("patchJobInstanceDetails")]
        public virtual System.Collections.Generic.IList<PatchJobInstanceDetails> PatchJobInstanceDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response message for listing patch jobs.</summary>
    public class ListPatchJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A pagination token that can be used to get the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of patch jobs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("patchJobs")]
        public virtual System.Collections.Generic.IList<PatchJob> PatchJobs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request message for getting the effective guest policy assigned to the instance.</summary>
    public class LookupEffectiveGuestPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Architecture of OS running on the instance. The OS Config agent only provides this field for targeting if OS
        /// Inventory is enabled for that instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osArchitecture")]
        public virtual string OsArchitecture { get; set; }

        /// <summary>
        /// Short name of the OS running on the instance. The OS Config agent only provides this field for targeting if
        /// OS Inventory is enabled for that instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osShortName")]
        public virtual string OsShortName { get; set; }

        /// <summary>
        /// Version of the OS running on the instance. The OS Config agent only provides this field for targeting if OS
        /// Inventory is enabled for that VM instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osVersion")]
        public virtual string OsVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a monthly schedule. An example of a valid monthly schedule is "on the third Tuesday of the month" or
    /// "on the 15th of the month".
    /// </summary>
    public class MonthlySchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. One day of the month. 1-31 indicates the 1st to the 31st day. -1 indicates the last day of the
        /// month. Months without the target day will be skipped. For example, a schedule to run "every month on the
        /// 31st" will not run in February, April, June, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monthDay")]
        public virtual System.Nullable<int> MonthDay { get; set; }

        /// <summary>Required. Week day in a month.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weekDayOfMonth")]
        public virtual WeekDayOfMonth WeekDayOfMonth { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// OS policy assignment operation metadata provided by OS policy assignment API methods that return long running
    /// operations.
    /// </summary>
    public class OSPolicyAssignmentOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The OS policy assignment API method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiMethod")]
        public virtual string ApiMethod { get; set; }

        /// <summary>
        /// Reference to the `OSPolicyAssignment` API resource. Format:
        /// `projects/{project_number}/locations/{location}/osPolicyAssignments/{os_policy_assignment_id@revision_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osPolicyAssignment")]
        public virtual string OsPolicyAssignment { get; set; }

        /// <summary>Rollout start time</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutStartTime")]
        public virtual object RolloutStartTime { get; set; }

        /// <summary>State of the rollout</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutState")]
        public virtual string RolloutState { get; set; }

        /// <summary>Rollout update time</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutUpdateTime")]
        public virtual object RolloutUpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Sets the time for a one time patch deployment. Timestamp is in [RFC3339](https://www.ietf.org/rfc/rfc3339.txt)
    /// text format.
    /// </summary>
    public class OneTimeSchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The desired patch job execution time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executeTime")]
        public virtual object ExecuteTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Package is a reference to the software package to be installed or removed. The agent on the VM instance uses the
    /// system package manager to apply the config. These are the commands that the agent uses to install or remove
    /// packages. Apt install: `apt-get update &amp;amp;&amp;amp; apt-get -y install package1 package2 package3` remove:
    /// `apt-get -y remove package1 package2 package3` Yum install: `yum -y install package1 package2 package3` remove:
    /// `yum -y remove package1 package2 package3` Zypper install: `zypper install package1 package2 package3` remove:
    /// `zypper rm package1 package2` Googet install: `googet -noconfirm install package1 package2 package3` remove:
    /// `googet -noconfirm remove package1 package2 package3`
    /// </summary>
    public class Package : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The desired_state the agent should maintain for this package. The default is to ensure the package is
        /// installed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredState")]
        public virtual string DesiredState { get; set; }

        /// <summary>
        /// Type of package manager that can be used to install this package. If a system does not have the package
        /// manager, the package is not installed or removed no error message is returned. By default, or if you specify
        /// `ANY`, the agent attempts to install and remove this package using the default package manager. This is
        /// useful when creating a policy that applies to different types of systems. The default behavior is ANY.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manager")]
        public virtual string Manager { get; set; }

        /// <summary>
        /// Required. The name of the package. A package is uniquely identified for conflict validation by checking the
        /// package name and the manager(s) that the package targets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A package repository.</summary>
    public class PackageRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An Apt Repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apt")]
        public virtual AptRepository Apt { get; set; }

        /// <summary>A Goo Repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goo")]
        public virtual GooRepository Goo { get; set; }

        /// <summary>A Yum Repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yum")]
        public virtual YumRepository Yum { get; set; }

        /// <summary>A Zypper Repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zypper")]
        public virtual ZypperRepository Zypper { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Patch configuration specifications. Contains details on how to apply the patch(es) to a VM instance.
    /// </summary>
    public class PatchConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Apt update settings. Use this setting to override the default `apt` patch rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apt")]
        public virtual AptSettings Apt { get; set; }

        /// <summary>Goo update settings. Use this setting to override the default `goo` patch rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goo")]
        public virtual GooSettings Goo { get; set; }

        /// <summary>The `ExecStep` to run after the patch update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postStep")]
        public virtual ExecStep PostStep { get; set; }

        /// <summary>The `ExecStep` to run before the patch update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preStep")]
        public virtual ExecStep PreStep { get; set; }

        /// <summary>Post-patch reboot settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rebootConfig")]
        public virtual string RebootConfig { get; set; }

        /// <summary>Windows update settings. Use this override the default windows patch rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("windowsUpdate")]
        public virtual WindowsUpdateSettings WindowsUpdate { get; set; }

        /// <summary>Yum update settings. Use this setting to override the default `yum` patch rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yum")]
        public virtual YumSettings Yum { get; set; }

        /// <summary>Zypper update settings. Use this setting to override the default `zypper` patch rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zypper")]
        public virtual ZypperSettings Zypper { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Patch deployments are configurations that individual patch jobs use to complete a patch. These configurations
    /// include instance filter, package repository settings, and a schedule. For more information about creating and
    /// managing patch deployments, see [Scheduling patch
    /// jobs](https://cloud.google.com/compute/docs/os-patch-management/schedule-patch-jobs).
    /// </summary>
    public class PatchDeployment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Time the patch deployment was created. Timestamp is in
        /// [RFC3339](https://www.ietf.org/rfc/rfc3339.txt) text format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Optional. Description of the patch deployment. Length of the description is limited to 1024 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. Duration of the patch. After the duration ends, the patch times out.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>Required. VM instances to patch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceFilter")]
        public virtual PatchInstanceFilter InstanceFilter { get; set; }

        /// <summary>
        /// Output only. The last time a patch job was started by this deployment. Timestamp is in
        /// [RFC3339](https://www.ietf.org/rfc/rfc3339.txt) text format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastExecuteTime")]
        public virtual object LastExecuteTime { get; set; }

        /// <summary>
        /// Unique name for the patch deployment resource in a project. The patch deployment name is in the form:
        /// `projects/{project_id}/patchDeployments/{patch_deployment_id}`. This field is ignored when you create a new
        /// patch deployment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Schedule a one-time execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oneTimeSchedule")]
        public virtual OneTimeSchedule OneTimeSchedule { get; set; }

        /// <summary>Optional. Patch configuration that is applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("patchConfig")]
        public virtual PatchConfig PatchConfig { get; set; }

        /// <summary>Required. Schedule recurring executions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recurringSchedule")]
        public virtual RecurringSchedule RecurringSchedule { get; set; }

        /// <summary>Optional. Rollout strategy of the patch job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollout")]
        public virtual PatchRollout Rollout { get; set; }

        /// <summary>
        /// Output only. Time the patch deployment was last updated. Timestamp is in
        /// [RFC3339](https://www.ietf.org/rfc/rfc3339.txt) text format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A filter to target VM instances for patching. The targeted VMs must meet all criteria specified. So if both
    /// labels and zones are specified, the patch job targets only VMs with those labels and in those zones.
    /// </summary>
    public class PatchInstanceFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Target all VM instances in the project. If true, no other criteria is permitted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("all")]
        public virtual System.Nullable<bool> All { get; set; }

        /// <summary>
        /// Targets VM instances matching at least one of these label sets. This allows targeting of disparate groups,
        /// for example "env=prod or env=staging".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupLabels")]
        public virtual System.Collections.Generic.IList<PatchInstanceFilterGroupLabel> GroupLabels { get; set; }

        /// <summary>
        /// Targets VMs whose name starts with one of these prefixes. Similar to labels, this is another way to group
        /// VMs when targeting configs, for example prefix="prod-".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceNamePrefixes")]
        public virtual System.Collections.Generic.IList<string> InstanceNamePrefixes { get; set; }

        /// <summary>
        /// Targets any of the VM instances specified. Instances are specified by their URI in the form
        /// `zones/[ZONE]/instances/[INSTANCE_NAME]`, `projects/[PROJECT_ID]/zones/[ZONE]/instances/[INSTANCE_NAME]`, or
        /// `https://www.googleapis.com/compute/v1/projects/[PROJECT_ID]/zones/[ZONE]/instances/[INSTANCE_NAME]`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<string> Instances { get; set; }

        /// <summary>
        /// Targets VM instances in ANY of these zones. Leave empty to target VM instances in any zone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zones")]
        public virtual System.Collections.Generic.IList<string> Zones { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a group of VMs that can be identified as having all these labels, for example "env=prod and app=web".
    /// </summary>
    public class PatchInstanceFilterGroupLabel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Compute Engine instance labels that must be present for a VM instance to be targeted by this filter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A high level representation of a patch job that is either in progress or has completed. Instance details are not
    /// included in the job. To paginate through instance details, use `ListPatchJobInstanceDetails`. For more
    /// information about patch jobs, see [Creating patch
    /// jobs](https://cloud.google.com/compute/docs/os-patch-management/create-patch-job).
    /// </summary>
    public class PatchJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Time this patch job was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Description of the patch job. Length of the description is limited to 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Display name for this patch job. This is not a unique identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// If this patch job is a dry run, the agent reports that it has finished without running any updates on the VM
        /// instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dryRun")]
        public virtual System.Nullable<bool> DryRun { get; set; }

        /// <summary>Duration of the patch job. After the duration ends, the patch job times out.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>If this patch job failed, this message provides information about the failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>Summary of instance details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceDetailsSummary")]
        public virtual PatchJobInstanceDetailsSummary InstanceDetailsSummary { get; set; }

        /// <summary>Instances to patch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceFilter")]
        public virtual PatchInstanceFilter InstanceFilter { get; set; }

        /// <summary>Unique identifier for this patch job in the form `projects/*/patchJobs/*`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Patch configuration being applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("patchConfig")]
        public virtual PatchConfig PatchConfig { get; set; }

        /// <summary>Output only. Name of the patch deployment that created this patch job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("patchDeployment")]
        public virtual string PatchDeployment { get; set; }

        /// <summary>
        /// Reflects the overall progress of the patch job in the range of 0.0 being no progress to 100.0 being
        /// complete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentComplete")]
        public virtual System.Nullable<double> PercentComplete { get; set; }

        /// <summary>Rollout strategy being applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollout")]
        public virtual PatchRollout Rollout { get; set; }

        /// <summary>The current state of the PatchJob.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Last time this patch job was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Patch details for a VM instance. For more information about reviewing VM instance details, see [Listing all VM
    /// instance details for a specific patch
    /// job](https://cloud.google.com/compute/docs/os-patch-management/manage-patch-jobs#list-instance-details).
    /// </summary>
    public class PatchJobInstanceDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of times the agent that the agent attempts to apply the patch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attemptCount")]
        public virtual System.Nullable<long> AttemptCount { get; set; }

        /// <summary>If the patch fails, this field provides the reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureReason")]
        public virtual string FailureReason { get; set; }

        /// <summary>The unique identifier for the instance. This identifier is defined by the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceSystemId")]
        public virtual string InstanceSystemId { get; set; }

        /// <summary>The instance name in the form `projects/*/zones/*/instances/*`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Current state of instance patch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A summary of the current patch state across all instances that this patch job affects. Contains counts of
    /// instances in different states. These states map to `InstancePatchState`. List patch job instance details to see
    /// the specific states of each instance.
    /// </summary>
    public class PatchJobInstanceDetailsSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of instances that have acked and will start shortly.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ackedInstanceCount")]
        public virtual System.Nullable<long> AckedInstanceCount { get; set; }

        /// <summary>Number of instances that are applying patches.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applyingPatchesInstanceCount")]
        public virtual System.Nullable<long> ApplyingPatchesInstanceCount { get; set; }

        /// <summary>Number of instances that are downloading patches.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadingPatchesInstanceCount")]
        public virtual System.Nullable<long> DownloadingPatchesInstanceCount { get; set; }

        /// <summary>Number of instances that failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedInstanceCount")]
        public virtual System.Nullable<long> FailedInstanceCount { get; set; }

        /// <summary>Number of instances that are inactive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inactiveInstanceCount")]
        public virtual System.Nullable<long> InactiveInstanceCount { get; set; }

        /// <summary>
        /// Number of instances that do not appear to be running the agent. Check to ensure that the agent is installed,
        /// running, and able to communicate with the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noAgentDetectedInstanceCount")]
        public virtual System.Nullable<long> NoAgentDetectedInstanceCount { get; set; }

        /// <summary>Number of instances notified about patch job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notifiedInstanceCount")]
        public virtual System.Nullable<long> NotifiedInstanceCount { get; set; }

        /// <summary>Number of instances pending patch job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingInstanceCount")]
        public virtual System.Nullable<long> PendingInstanceCount { get; set; }

        /// <summary>Number of instances that are running the post-patch step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postPatchStepInstanceCount")]
        public virtual System.Nullable<long> PostPatchStepInstanceCount { get; set; }

        /// <summary>Number of instances that are running the pre-patch step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prePatchStepInstanceCount")]
        public virtual System.Nullable<long> PrePatchStepInstanceCount { get; set; }

        /// <summary>Number of instances rebooting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rebootingInstanceCount")]
        public virtual System.Nullable<long> RebootingInstanceCount { get; set; }

        /// <summary>Number of instances that have started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startedInstanceCount")]
        public virtual System.Nullable<long> StartedInstanceCount { get; set; }

        /// <summary>Number of instances that have completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("succeededInstanceCount")]
        public virtual System.Nullable<long> SucceededInstanceCount { get; set; }

        /// <summary>Number of instances that require reboot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("succeededRebootRequiredInstanceCount")]
        public virtual System.Nullable<long> SucceededRebootRequiredInstanceCount { get; set; }

        /// <summary>Number of instances that exceeded the time out while applying the patch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timedOutInstanceCount")]
        public virtual System.Nullable<long> TimedOutInstanceCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Patch rollout configuration specifications. Contains details on the concurrency control when applying patch(es)
    /// to all targeted VMs.
    /// </summary>
    public class PatchRollout : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The maximum number (or percentage) of VMs per zone to disrupt at any given moment. The number of VMs
        /// calculated from multiplying the percentage by the total number of VMs in a zone is rounded up. During
        /// patching, a VM is considered disrupted from the time the agent is notified to begin until patching has
        /// completed. This disruption time includes the time to complete reboot and any post-patch steps. A VM
        /// contributes to the disruption budget if its patching operation fails either when applying the patches,
        /// running pre or post patch steps, or if it fails to respond with a success notification before timing out.
        /// VMs that are not running or do not have an active agent do not count toward this disruption budget. For
        /// zone-by-zone rollouts, if the disruption budget in a zone is exceeded, the patch job stops, because
        /// continuing to the next zone requires completion of the patch process in the previous zone. For example, if
        /// the disruption budget has a fixed value of `10`, and 8 VMs fail to patch in the current zone, the patch job
        /// continues to patch 2 VMs at a time until the zone is completed. When that zone is completed successfully,
        /// patching begins with 10 VMs at a time in the next zone. If 10 VMs in the next zone fail to patch, the patch
        /// job stops.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disruptionBudget")]
        public virtual FixedOrPercent DisruptionBudget { get; set; }

        /// <summary>Mode of the patch rollout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sets the time for recurring patch deployments.</summary>
    public class RecurringSchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The end time at which a recurring patch deployment schedule is no longer active.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Required. The frequency unit of this recurring schedule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frequency")]
        public virtual string Frequency { get; set; }

        /// <summary>Output only. The time the last patch job ran successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastExecuteTime")]
        public virtual object LastExecuteTime { get; set; }

        /// <summary>Required. Schedule with monthly executions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monthly")]
        public virtual MonthlySchedule Monthly { get; set; }

        /// <summary>Output only. The time the next patch job is scheduled to run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextExecuteTime")]
        public virtual object NextExecuteTime { get; set; }

        /// <summary>
        /// Optional. The time that the recurring schedule becomes effective. Defaults to `create_time` of the patch
        /// deployment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>Required. Time of the day to run a recurring deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOfDay")]
        public virtual TimeOfDay TimeOfDay { get; set; }

        /// <summary>
        /// Required. Defines the time zone that `time_of_day` is relative to. The rules for daylight saving time are
        /// determined by the chosen time zone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual TimeZone TimeZone { get; set; }

        /// <summary>Required. Schedule with weekly executions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weekly")]
        public virtual WeeklySchedule Weekly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A software recipe is a set of instructions for installing and configuring a piece of software. It consists of a
    /// set of artifacts that are downloaded, and a set of steps that install, configure, and/or update the software.
    /// Recipes support installing and updating software from artifacts in the following formats: Zip archive, Tar
    /// archive, Windows MSI, Debian package, and RPM package. Additionally, recipes support executing a script (either
    /// defined in a file or directly in this api) in bash, sh, cmd, and powershell. Updating a software recipe If a
    /// recipe is assigned to an instance and there is a recipe with the same name but a lower version already installed
    /// and the assigned state of the recipe is `UPDATED`, then the recipe is updated to the new version. Script Working
    /// Directories Each script or execution step is run in its own temporary directory which is deleted after
    /// completing the step.
    /// </summary>
    public class SoftwareRecipe : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resources available to be used in the steps in the recipe.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifacts")]
        public virtual System.Collections.Generic.IList<SoftwareRecipeArtifact> Artifacts { get; set; }

        /// <summary>
        /// Default is INSTALLED. The desired state the agent should maintain for this recipe. INSTALLED: The software
        /// recipe is installed on the instance but won't be updated to new versions. UPDATED: The software recipe is
        /// installed on the instance. The recipe is updated to a higher version, if a higher version of the recipe is
        /// assigned to this instance. REMOVE: Remove is unsupported for software recipes and attempts to create or
        /// update a recipe to the REMOVE state is rejected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredState")]
        public virtual string DesiredState { get; set; }

        /// <summary>
        /// Actions to be taken for installing this recipe. On failure it stops executing steps and does not attempt
        /// another installation. Any steps taken (including partially completed steps) are not rolled back.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installSteps")]
        public virtual System.Collections.Generic.IList<SoftwareRecipeStep> InstallSteps { get; set; }

        /// <summary>
        /// Required. Unique identifier for the recipe. Only one recipe with a given name is installed on an instance.
        /// Names are also used to identify resources which helps to determine whether guest policies have conflicts.
        /// This means that requests to create multiple recipes with the same name and version are rejected since they
        /// could potentially have conflicting assignments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Actions to be taken for updating this recipe. On failure it stops executing steps and does not attempt
        /// another update for this recipe. Any steps taken (including partially completed steps) are not rolled back.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateSteps")]
        public virtual System.Collections.Generic.IList<SoftwareRecipeStep> UpdateSteps { get; set; }

        /// <summary>
        /// The version of this software recipe. Version can be up to 4 period separated numbers (e.g. 12.34.56.78).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies a resource to be used in the recipe.</summary>
    public class SoftwareRecipeArtifact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Defaults to false. When false, recipes are subject to validations based on the artifact type: Remote: A
        /// checksum must be specified, and only protocols with transport-layer security are permitted. GCS: An object
        /// generation number must be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowInsecure")]
        public virtual System.Nullable<bool> AllowInsecure { get; set; }

        /// <summary>A Google Cloud Storage artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcs")]
        public virtual SoftwareRecipeArtifactGcs Gcs { get; set; }

        /// <summary>
        /// Required. Id of the artifact, which the installation and update steps of this recipe can reference.
        /// Artifacts in a recipe cannot have the same id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>A generic remote artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remote")]
        public virtual SoftwareRecipeArtifactRemote Remote { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies an artifact available as a Google Cloud Storage object.</summary>
    public class SoftwareRecipeArtifactGcs : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Bucket of the Google Cloud Storage object. Given an example URL:
        /// `https://storage.googleapis.com/my-bucket/foo/bar#1234567` this value would be `my-bucket`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>
        /// Must be provided if allow_insecure is false. Generation number of the Google Cloud Storage object.
        /// `https://storage.googleapis.com/my-bucket/foo/bar#1234567` this value would be `1234567`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>
        /// Name of the Google Cloud Storage object. As specified [here]
        /// (https://cloud.google.com/storage/docs/naming#objectnames) Given an example URL:
        /// `https://storage.googleapis.com/my-bucket/foo/bar#1234567` this value would be `foo/bar`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("object")]
        public virtual string Object__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies an artifact available via some URI.</summary>
    public class SoftwareRecipeArtifactRemote : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Must be provided if `allow_insecure` is `false`. SHA256 checksum in hex format, to compare to the checksum
        /// of the artifact. If the checksum is not empty and it doesn't match the artifact then the recipe installation
        /// fails before running any of the steps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checksum")]
        public virtual string Checksum { get; set; }

        /// <summary>
        /// URI from which to fetch the object. It should contain both the protocol and path following the format
        /// {protocol}://{location}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An action that can be taken as part of installing or updating a recipe.</summary>
    public class SoftwareRecipeStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Extracts an archive into the specified directory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("archiveExtraction")]
        public virtual SoftwareRecipeStepExtractArchive ArchiveExtraction { get; set; }

        /// <summary>Installs a deb file via dpkg.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dpkgInstallation")]
        public virtual SoftwareRecipeStepInstallDpkg DpkgInstallation { get; set; }

        /// <summary>Copies a file onto the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileCopy")]
        public virtual SoftwareRecipeStepCopyFile FileCopy { get; set; }

        /// <summary>Executes an artifact or local file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileExec")]
        public virtual SoftwareRecipeStepExecFile FileExec { get; set; }

        /// <summary>Installs an MSI file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("msiInstallation")]
        public virtual SoftwareRecipeStepInstallMsi MsiInstallation { get; set; }

        /// <summary>Installs an rpm file via the rpm utility.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rpmInstallation")]
        public virtual SoftwareRecipeStepInstallRpm RpmInstallation { get; set; }

        /// <summary>Runs commands in a shell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scriptRun")]
        public virtual SoftwareRecipeStepRunScript ScriptRun { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Copies the artifact to the specified path on the instance.</summary>
    public class SoftwareRecipeStepCopyFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The id of the relevant artifact in the recipe.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactId")]
        public virtual string ArtifactId { get; set; }

        /// <summary>Required. The absolute path on the instance to put the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual string Destination { get; set; }

        /// <summary>
        /// Whether to allow this step to overwrite existing files. If this is false and the file already exists the
        /// file is not overwritten and the step is considered a success. Defaults to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overwrite")]
        public virtual System.Nullable<bool> Overwrite { get; set; }

        /// <summary>
        /// Consists of three octal digits which represent, in order, the permissions of the owner, group, and other
        /// users for the file (similarly to the numeric mode used in the linux chmod utility). Each digit represents a
        /// three bit number with the 4 bit corresponding to the read permissions, the 2 bit corresponds to the write
        /// bit, and the one bit corresponds to the execute permission. Default behavior is 755. Below are some examples
        /// of permissions and their associated values: read, write, and execute: 7 read and execute: 5 read and write:
        /// 6 read only: 4
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual string Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Executes an artifact or local file.</summary>
    public class SoftwareRecipeStepExecFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Defaults to [0]. A list of possible return values that the program can return to indicate a success.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedExitCodes")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> AllowedExitCodes { get; set; }

        /// <summary>Arguments to be passed to the provided executable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>The id of the relevant artifact in the recipe.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactId")]
        public virtual string ArtifactId { get; set; }

        /// <summary>The absolute path of the file on the local filesystem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localPath")]
        public virtual string LocalPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Extracts an archive of the type specified in the specified directory.</summary>
    public class SoftwareRecipeStepExtractArchive : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The id of the relevant artifact in the recipe.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactId")]
        public virtual string ArtifactId { get; set; }

        /// <summary>Directory to extract archive to. Defaults to `/` on Linux or `C:\` on Windows.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual string Destination { get; set; }

        /// <summary>Required. The type of the archive to extract.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Installs a deb via dpkg.</summary>
    public class SoftwareRecipeStepInstallDpkg : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The id of the relevant artifact in the recipe.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactId")]
        public virtual string ArtifactId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Installs an MSI file.</summary>
    public class SoftwareRecipeStepInstallMsi : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Return codes that indicate that the software installed or updated successfully. Behaviour defaults to [0]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedExitCodes")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> AllowedExitCodes { get; set; }

        /// <summary>Required. The id of the relevant artifact in the recipe.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactId")]
        public virtual string ArtifactId { get; set; }

        /// <summary>The flags to use when installing the MSI defaults to ["/i"] (i.e. the install flag).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flags")]
        public virtual System.Collections.Generic.IList<string> Flags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Installs an rpm file via the rpm utility.</summary>
    public class SoftwareRecipeStepInstallRpm : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The id of the relevant artifact in the recipe.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactId")]
        public virtual string ArtifactId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Runs a script through an interpreter.</summary>
    public class SoftwareRecipeStepRunScript : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Return codes that indicate that the software installed or updated successfully. Behaviour defaults to [0]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedExitCodes")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> AllowedExitCodes { get; set; }

        /// <summary>
        /// The script interpreter to use to run the script. If no interpreter is specified the script is executed
        /// directly, which likely only succeed for scripts with [shebang
        /// lines](https://en.wikipedia.org/wiki/Shebang_\(Unix\)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interpreter")]
        public virtual string Interpreter { get; set; }

        /// <summary>Required. The shell script to be executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("script")]
        public virtual string Script { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a time of day. The date and time zone are either not significant or are specified elsewhere. An API
    /// may choose to allow leap seconds. Related types are google.type.Date and `google.protobuf.Timestamp`.
    /// </summary>
    public class TimeOfDay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for
        /// scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows
        /// leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a time zone from the [IANA Time Zone Database](https://www.iana.org/time-zones).</summary>
    public class TimeZone : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>IANA Time Zone Database time zone, e.g. "America/New_York".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. IANA Time Zone Database version number, e.g. "2019a".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents one week day in a month. An example is "the 4th Sunday".</summary>
    public class WeekDayOfMonth : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A day of the week.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dayOfWeek")]
        public virtual string DayOfWeek { get; set; }

        /// <summary>
        /// Required. Week number in a month. 1-4 indicates the 1st to 4th week of the month. -1 indicates the last week
        /// of the month.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weekOrdinal")]
        public virtual System.Nullable<int> WeekOrdinal { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a weekly schedule.</summary>
    public class WeeklySchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Day of the week.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dayOfWeek")]
        public virtual string DayOfWeek { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Windows patching is performed using the Windows Update Agent.</summary>
    public class WindowsUpdateSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Only apply updates of these windows update classifications. If empty, all updates are applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classifications")]
        public virtual System.Collections.Generic.IList<string> Classifications { get; set; }

        /// <summary>List of KBs to exclude from update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludes")]
        public virtual System.Collections.Generic.IList<string> Excludes { get; set; }

        /// <summary>
        /// An exclusive list of kbs to be updated. These are the only patches that will be updated. This field must not
        /// be used with other patch configurations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusivePatches")]
        public virtual System.Collections.Generic.IList<string> ExclusivePatches { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a single Yum package repository. This repository is added to a repo file that is stored at
    /// `/etc/yum.repos.d/google_osconfig.repo`.
    /// </summary>
    public class YumRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The location of the repository directory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseUrl")]
        public virtual string BaseUrl { get; set; }

        /// <summary>The display name of the repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>URIs of GPG keys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpgKeys")]
        public virtual System.Collections.Generic.IList<string> GpgKeys { get; set; }

        /// <summary>
        /// Required. A one word, unique name for this repository. This is the `repo id` in the Yum config file and also
        /// the `display_name` if `display_name` is omitted. This id is also used as the unique identifier when checking
        /// for guest policy conflicts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Yum patching is performed by executing `yum update`. Additional options can be set to control how this is
    /// executed. Note that not all settings are supported on all platforms.
    /// </summary>
    public class YumSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of packages to exclude from update. These packages are excluded by using the yum `--exclude` flag.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludes")]
        public virtual System.Collections.Generic.IList<string> Excludes { get; set; }

        /// <summary>
        /// An exclusive list of packages to be updated. These are the only packages that will be updated. If these
        /// packages are not installed, they will be ignored. This field must not be specified with any other patch
        /// configuration fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusivePackages")]
        public virtual System.Collections.Generic.IList<string> ExclusivePackages { get; set; }

        /// <summary>Will cause patch to run `yum update-minimal` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimal")]
        public virtual System.Nullable<bool> Minimal { get; set; }

        /// <summary>Adds the `--security` flag to `yum update`. Not supported on all platforms.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("security")]
        public virtual System.Nullable<bool> Security { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a single Zypper package repository. This repository is added to a repo file that is stored at
    /// `/etc/zypp/repos.d/google_osconfig.repo`.
    /// </summary>
    public class ZypperRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The location of the repository directory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseUrl")]
        public virtual string BaseUrl { get; set; }

        /// <summary>The display name of the repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>URIs of GPG keys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpgKeys")]
        public virtual System.Collections.Generic.IList<string> GpgKeys { get; set; }

        /// <summary>
        /// Required. A one word, unique name for this repository. This is the `repo id` in the zypper config file and
        /// also the `display_name` if `display_name` is omitted. This id is also used as the unique identifier when
        /// checking for guest policy conflicts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Zypper patching is performed by running `zypper patch`. See also https://en.opensuse.org/SDB:Zypper_manual.
    /// </summary>
    public class ZypperSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Install only patches with these categories. Common categories include security, recommended, and feature.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual System.Collections.Generic.IList<string> Categories { get; set; }

        /// <summary>List of patches to exclude from update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludes")]
        public virtual System.Collections.Generic.IList<string> Excludes { get; set; }

        /// <summary>
        /// An exclusive list of patches to be updated. These are the only patches that will be installed using 'zypper
        /// patch patch:' command. This field must not be used with any other patch configuration fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusivePatches")]
        public virtual System.Collections.Generic.IList<string> ExclusivePatches { get; set; }

        /// <summary>
        /// Install only patches with these severities. Common severities include critical, important, moderate, and
        /// low.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severities")]
        public virtual System.Collections.Generic.IList<string> Severities { get; set; }

        /// <summary>Adds the `--with-optional` flag to `zypper patch`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("withOptional")]
        public virtual System.Nullable<bool> WithOptional { get; set; }

        /// <summary>Adds the `--with-update` flag, to `zypper patch`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("withUpdate")]
        public virtual System.Nullable<bool> WithUpdate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
