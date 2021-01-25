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

namespace Google.Apis.CertificateAuthorityService.v1beta1
{
    /// <summary>The CertificateAuthorityService Service.</summary>
    public class CertificateAuthorityServiceService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CertificateAuthorityServiceService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CertificateAuthorityServiceService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "privateca";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://privateca.googleapis.com/";
        #else
            "https://privateca.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://privateca.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Certificate Authority API.</summary>
        public class Scope
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Certificate Authority API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for CertificateAuthorityService requests.</summary>
    public abstract class CertificateAuthorityServiceBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CertificateAuthorityServiceBaseServiceRequest instance.</summary>
        protected CertificateAuthorityServiceBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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
            Value1,

            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
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
            Json,

            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,

            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
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

        /// <summary>Initializes CertificateAuthorityService parameter list.</summary>
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
                CertificateAuthorities = new CertificateAuthoritiesResource(service);
                Operations = new OperationsResource(service);
                ReusableConfigs = new ReusableConfigsResource(service);
            }

            /// <summary>Gets the CertificateAuthorities resource.</summary>
            public virtual CertificateAuthoritiesResource CertificateAuthorities { get; }

            /// <summary>The "certificateAuthorities" collection of methods.</summary>
            public class CertificateAuthoritiesResource
            {
                private const string Resource = "certificateAuthorities";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public CertificateAuthoritiesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    CertificateRevocationLists = new CertificateRevocationListsResource(service);
                    Certificates = new CertificatesResource(service);
                }

                /// <summary>Gets the CertificateRevocationLists resource.</summary>
                public virtual CertificateRevocationListsResource CertificateRevocationLists { get; }

                /// <summary>The "certificateRevocationLists" collection of methods.</summary>
                public class CertificateRevocationListsResource
                {
                    private const string Resource = "certificateRevocationLists";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public CertificateRevocationListsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Returns a CertificateRevocationList.</summary>
                    /// <param name="name">Required. The name of the CertificateRevocationList to get.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Returns a CertificateRevocationList.</summary>
                    public class GetRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.CertificateRevocationList>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the CertificateRevocationList to get.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/certificateAuthorities/[^/]+/certificateRevocationLists/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                    {
                        return new GetIamPolicyRequest(service, resource);
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    public class GetIamPolicyRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                        {
                            Resource = resource;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>
                        /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests
                        /// specifying an invalid value will be rejected. Requests for policies with any conditional
                        /// bindings must specify version 3. Policies without any conditional bindings may specify any
                        /// valid value or leave the field unset. To learn which resources support conditions in their
                        /// IAM policies, see the [IAM
                        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/certificateAuthorities/[^/]+/certificateRevocationLists/[^/]+$",
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

                    /// <summary>Lists CertificateRevocationLists.</summary>
                    /// <param name="parent">
                    /// Required. The resource name of the location associated with the CertificateRevocationLists, in
                    /// the format `projects/*/locations/*/certificateauthorities/*`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists CertificateRevocationLists.</summary>
                    public class ListRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.ListCertificateRevocationListsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the location associated with the CertificateRevocationLists,
                        /// in the format `projects/*/locations/*/certificateauthorities/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. Only include resources that match the filter in the response.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Optional. Specify how the results should be sorted.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. Limit on the number of CertificateRevocationLists to include in the response.
                        /// Further CertificateRevocationLists can subsequently be obtained by including the
                        /// ListCertificateRevocationListsResponse.next_page_token in a subsequent request. If
                        /// unspecified, the server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. Pagination token, returned earlier via
                        /// ListCertificateRevocationListsResponse.next_page_token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/certificateRevocationLists";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/certificateAuthorities/[^/]+$",
                            });
                            RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filter",
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
                        }
                    }

                    /// <summary>Update a CertificateRevocationList.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. The resource path for this CertificateRevocationList in the format
                    /// `projects/*/locations/*/certificateAuthorities/*/ certificateRevocationLists/*`.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CertificateAuthorityService.v1beta1.Data.CertificateRevocationList body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Update a CertificateRevocationList.</summary>
                    public class PatchRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1beta1.Data.CertificateRevocationList body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. The resource path for this CertificateRevocationList in the format
                        /// `projects/*/locations/*/certificateAuthorities/*/ certificateRevocationLists/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry
                        /// your request, the server will know to ignore the request if it has already been completed.
                        /// The server will guarantee that for at least 60 minutes since the first request. For example,
                        /// consider a situation where you make an initial request and t he request times out. If you
                        /// make the request again with the same request ID, the server can check if original operation
                        /// with the same request ID was received, and if so, will ignore the second request. This
                        /// prevents clients from accidentally creating duplicate commitments. The request ID must be a
                        /// valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Required. A list of fields to be updated in this request.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CertificateAuthorityService.v1beta1.Data.CertificateRevocationList Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/certificateAuthorities/[^/]+/certificateRevocationLists/[^/]+$",
                            });
                            RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "requestId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
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

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CertificateAuthorityService.v1beta1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    public class SetIamPolicyRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1beta1.Data.SetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being specified. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CertificateAuthorityService.v1beta1.Data.SetIamPolicyRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/certificateAuthorities/[^/]+/certificateRevocationLists/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CertificateAuthorityService.v1beta1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                        Google.Apis.CertificateAuthorityService.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/certificateAuthorities/[^/]+/certificateRevocationLists/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the Certificates resource.</summary>
                public virtual CertificatesResource Certificates { get; }

                /// <summary>The "certificates" collection of methods.</summary>
                public class CertificatesResource
                {
                    private const string Resource = "certificates";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public CertificatesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Create a new Certificate in a given Project, Location from a particular CertificateAuthority.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The resource name of the location and CertificateAuthority associated with the
                    /// Certificate, in the format `projects/*/locations/*/certificateAuthorities/*`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.CertificateAuthorityService.v1beta1.Data.Certificate body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Create a new Certificate in a given Project, Location from a particular CertificateAuthority.
                    /// </summary>
                    public class CreateRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.Certificate>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1beta1.Data.Certificate body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the location and CertificateAuthority associated with the
                        /// Certificate, in the format `projects/*/locations/*/certificateAuthorities/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. It must be unique within a location and match the regular expression
                        /// `[a-zA-Z0-9_-]{1,63}`. This field is required when using a CertificateAuthority in the
                        /// Enterprise CertificateAuthority.Tier, but is optional and its value is ignored otherwise.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("certificateId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string CertificateId { get; set; }

                        /// <summary>
                        /// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry
                        /// your request, the server will know to ignore the request if it has already been completed.
                        /// The server will guarantee that for at least 60 minutes since the first request. For example,
                        /// consider a situation where you make an initial request and t he request times out. If you
                        /// make the request again with the same request ID, the server can check if original operation
                        /// with the same request ID was received, and if so, will ignore the second request. This
                        /// prevents clients from accidentally creating duplicate commitments. The request ID must be a
                        /// valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CertificateAuthorityService.v1beta1.Data.Certificate Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/certificates";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/certificateAuthorities/[^/]+$",
                            });
                            RequestParameters.Add("certificateId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "certificateId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "requestId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Returns a Certificate.</summary>
                    /// <param name="name">Required. The name of the Certificate to get.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Returns a Certificate.</summary>
                    public class GetRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.Certificate>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the Certificate to get.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/certificateAuthorities/[^/]+/certificates/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists Certificates.</summary>
                    /// <param name="parent">
                    /// Required. The resource name of the location associated with the Certificates, in the format
                    /// `projects/*/locations/*/certificateauthorities/*`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists Certificates.</summary>
                    public class ListRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.ListCertificatesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the location associated with the Certificates, in the format
                        /// `projects/*/locations/*/certificateauthorities/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Only include resources that match the filter in the response. For details on
                        /// supported filters and syntax, see [Certificates Filtering
                        /// documentation](https://cloud.google.com/certificate-authority-service/docs/sorting-filtering-certificates#filtering_support).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Specify how the results should be sorted. For details on supported fields and
                        /// syntax, see [Certificates Sorting
                        /// documentation](https://cloud.google.com/certificate-authority-service/docs/sorting-filtering-certificates#sorting_support).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. Limit on the number of Certificates to include in the response. Further
                        /// Certificates can subsequently be obtained by including the
                        /// ListCertificatesResponse.next_page_token in a subsequent request. If unspecified, the server
                        /// will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. Pagination token, returned earlier via ListCertificatesResponse.next_page_token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/certificates";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/certificateAuthorities/[^/]+$",
                            });
                            RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filter",
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
                        }
                    }

                    /// <summary>
                    /// Update a Certificate. Currently, the only field you can update is the labels field.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. The resource path for this Certificate in the format
                    /// `projects/*/locations/*/certificateAuthorities/*/certificates/*`.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CertificateAuthorityService.v1beta1.Data.Certificate body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>
                    /// Update a Certificate. Currently, the only field you can update is the labels field.
                    /// </summary>
                    public class PatchRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.Certificate>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1beta1.Data.Certificate body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. The resource path for this Certificate in the format
                        /// `projects/*/locations/*/certificateAuthorities/*/certificates/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry
                        /// your request, the server will know to ignore the request if it has already been completed.
                        /// The server will guarantee that for at least 60 minutes since the first request. For example,
                        /// consider a situation where you make an initial request and t he request times out. If you
                        /// make the request again with the same request ID, the server can check if original operation
                        /// with the same request ID was received, and if so, will ignore the second request. This
                        /// prevents clients from accidentally creating duplicate commitments. The request ID must be a
                        /// valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Required. A list of fields to be updated in this request.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CertificateAuthorityService.v1beta1.Data.Certificate Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/certificateAuthorities/[^/]+/certificates/[^/]+$",
                            });
                            RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "requestId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
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

                    /// <summary>Revoke a Certificate.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource name for this Certificate in the format
                    /// `projects/*/locations/*/certificateAuthorities/*/certificates/*`.
                    /// </param>
                    public virtual RevokeRequest Revoke(Google.Apis.CertificateAuthorityService.v1beta1.Data.RevokeCertificateRequest body, string name)
                    {
                        return new RevokeRequest(service, body, name);
                    }

                    /// <summary>Revoke a Certificate.</summary>
                    public class RevokeRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.Certificate>
                    {
                        /// <summary>Constructs a new Revoke request.</summary>
                        public RevokeRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1beta1.Data.RevokeCertificateRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name for this Certificate in the format
                        /// `projects/*/locations/*/certificateAuthorities/*/certificates/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CertificateAuthorityService.v1beta1.Data.RevokeCertificateRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "revoke";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}:revoke";

                        /// <summary>Initializes Revoke parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/certificateAuthorities/[^/]+/certificates/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>
                /// Activate a CertificateAuthority that is in state PENDING_ACTIVATION and is of type SUBORDINATE.
                /// After the parent Certificate Authority signs a certificate signing request from
                /// FetchCertificateAuthorityCsr, this method can complete the activation process.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name for this CertificateAuthority in the format
                /// `projects/*/locations/*/certificateAuthorities/*`.
                /// </param>
                public virtual ActivateRequest Activate(Google.Apis.CertificateAuthorityService.v1beta1.Data.ActivateCertificateAuthorityRequest body, string name)
                {
                    return new ActivateRequest(service, body, name);
                }

                /// <summary>
                /// Activate a CertificateAuthority that is in state PENDING_ACTIVATION and is of type SUBORDINATE.
                /// After the parent Certificate Authority signs a certificate signing request from
                /// FetchCertificateAuthorityCsr, this method can complete the activation process.
                /// </summary>
                public class ActivateRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Activate request.</summary>
                    public ActivateRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1beta1.Data.ActivateCertificateAuthorityRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name for this CertificateAuthority in the format
                    /// `projects/*/locations/*/certificateAuthorities/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CertificateAuthorityService.v1beta1.Data.ActivateCertificateAuthorityRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "activate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}:activate";

                    /// <summary>Initializes Activate parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/certificateAuthorities/[^/]+$",
                        });
                    }
                }

                /// <summary>Create a new CertificateAuthority in a given Project and Location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource name of the location associated with the CertificateAuthorities, in the
                /// format `projects/*/locations/*`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CertificateAuthorityService.v1beta1.Data.CertificateAuthority body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Create a new CertificateAuthority in a given Project and Location.</summary>
                public class CreateRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1beta1.Data.CertificateAuthority body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the location associated with the CertificateAuthorities, in the
                    /// format `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. It must be unique within a location and match the regular expression
                    /// `[a-zA-Z0-9_-]{1,63}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("certificateAuthorityId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string CertificateAuthorityId { get; set; }

                    /// <summary>
                    /// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry your
                    /// request, the server will know to ignore the request if it has already been completed. The server
                    /// will guarantee that for at least 60 minutes since the first request. For example, consider a
                    /// situation where you make an initial request and t he request times out. If you make the request
                    /// again with the same request ID, the server can check if original operation with the same request
                    /// ID was received, and if so, will ignore the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CertificateAuthorityService.v1beta1.Data.CertificateAuthority Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/certificateAuthorities";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("certificateAuthorityId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "certificateAuthorityId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Disable a CertificateAuthority.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name for this CertificateAuthority in the format
                /// `projects/*/locations/*/certificateAuthorities/*`.
                /// </param>
                public virtual DisableRequest Disable(Google.Apis.CertificateAuthorityService.v1beta1.Data.DisableCertificateAuthorityRequest body, string name)
                {
                    return new DisableRequest(service, body, name);
                }

                /// <summary>Disable a CertificateAuthority.</summary>
                public class DisableRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Disable request.</summary>
                    public DisableRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1beta1.Data.DisableCertificateAuthorityRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name for this CertificateAuthority in the format
                    /// `projects/*/locations/*/certificateAuthorities/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CertificateAuthorityService.v1beta1.Data.DisableCertificateAuthorityRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "disable";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}:disable";

                    /// <summary>Initializes Disable parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/certificateAuthorities/[^/]+$",
                        });
                    }
                }

                /// <summary>Enable a CertificateAuthority.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name for this CertificateAuthority in the format
                /// `projects/*/locations/*/certificateAuthorities/*`.
                /// </param>
                public virtual EnableRequest Enable(Google.Apis.CertificateAuthorityService.v1beta1.Data.EnableCertificateAuthorityRequest body, string name)
                {
                    return new EnableRequest(service, body, name);
                }

                /// <summary>Enable a CertificateAuthority.</summary>
                public class EnableRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Enable request.</summary>
                    public EnableRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1beta1.Data.EnableCertificateAuthorityRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name for this CertificateAuthority in the format
                    /// `projects/*/locations/*/certificateAuthorities/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CertificateAuthorityService.v1beta1.Data.EnableCertificateAuthorityRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "enable";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}:enable";

                    /// <summary>Initializes Enable parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/certificateAuthorities/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Fetch a certificate signing request (CSR) from a CertificateAuthority that is in state
                /// PENDING_ACTIVATION and is of type SUBORDINATE. The CSR must then be signed by the desired parent
                /// Certificate Authority, which could be another CertificateAuthority resource, or could be an on-prem
                /// certificate authority. See also ActivateCertificateAuthority.
                /// </summary>
                /// <param name="name">
                /// Required. The resource name for this CertificateAuthority in the format
                /// `projects/*/locations/*/certificateAuthorities/*`.
                /// </param>
                public virtual FetchRequest Fetch(string name)
                {
                    return new FetchRequest(service, name);
                }

                /// <summary>
                /// Fetch a certificate signing request (CSR) from a CertificateAuthority that is in state
                /// PENDING_ACTIVATION and is of type SUBORDINATE. The CSR must then be signed by the desired parent
                /// Certificate Authority, which could be another CertificateAuthority resource, or could be an on-prem
                /// certificate authority. See also ActivateCertificateAuthority.
                /// </summary>
                public class FetchRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.FetchCertificateAuthorityCsrResponse>
                {
                    /// <summary>Constructs a new Fetch request.</summary>
                    public FetchRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name for this CertificateAuthority in the format
                    /// `projects/*/locations/*/certificateAuthorities/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "fetch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}:fetch";

                    /// <summary>Initializes Fetch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/certificateAuthorities/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns a CertificateAuthority.</summary>
                /// <param name="name">Required. The name of the CertificateAuthority to get.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Returns a CertificateAuthority.</summary>
                public class GetRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.CertificateAuthority>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the CertificateAuthority to get.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/certificateAuthorities/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                    {
                        Resource = resource;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>
                    /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests
                    /// specifying an invalid value will be rejected. Requests for policies with any conditional
                    /// bindings must specify version 3. Policies without any conditional bindings may specify any valid
                    /// value or leave the field unset. To learn which resources support conditions in their IAM
                    /// policies, see the [IAM
                    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/certificateAuthorities/[^/]+$",
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

                /// <summary>Lists CertificateAuthorities.</summary>
                /// <param name="parent">
                /// Required. The resource name of the location associated with the CertificateAuthorities, in the
                /// format `projects/*/locations/*`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists CertificateAuthorities.</summary>
                public class ListRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.ListCertificateAuthoritiesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the location associated with the CertificateAuthorities, in the
                    /// format `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Only include resources that match the filter in the response.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Specify how the results should be sorted.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. Limit on the number of CertificateAuthorities to include in the response. Further
                    /// CertificateAuthorities can subsequently be obtained by including the
                    /// ListCertificateAuthoritiesResponse.next_page_token in a subsequent request. If unspecified, the
                    /// server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. Pagination token, returned earlier via
                    /// ListCertificateAuthoritiesResponse.next_page_token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/certificateAuthorities";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
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
                    }
                }

                /// <summary>Update a CertificateAuthority.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. The resource name for this CertificateAuthority in the format
                /// `projects/*/locations/*/certificateAuthorities/*`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CertificateAuthorityService.v1beta1.Data.CertificateAuthority body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Update a CertificateAuthority.</summary>
                public class PatchRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1beta1.Data.CertificateAuthority body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. The resource name for this CertificateAuthority in the format
                    /// `projects/*/locations/*/certificateAuthorities/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry your
                    /// request, the server will know to ignore the request if it has already been completed. The server
                    /// will guarantee that for at least 60 minutes since the first request. For example, consider a
                    /// situation where you make an initial request and t he request times out. If you make the request
                    /// again with the same request ID, the server can check if original operation with the same request
                    /// ID was received, and if so, will ignore the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Required. A list of fields to be updated in this request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CertificateAuthorityService.v1beta1.Data.CertificateAuthority Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/certificateAuthorities/[^/]+$",
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
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

                /// <summary>Restore a CertificateAuthority that is scheduled for deletion.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name for this CertificateAuthority in the format
                /// `projects/*/locations/*/certificateAuthorities/*`.
                /// </param>
                public virtual RestoreRequest Restore(Google.Apis.CertificateAuthorityService.v1beta1.Data.RestoreCertificateAuthorityRequest body, string name)
                {
                    return new RestoreRequest(service, body, name);
                }

                /// <summary>Restore a CertificateAuthority that is scheduled for deletion.</summary>
                public class RestoreRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Restore request.</summary>
                    public RestoreRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1beta1.Data.RestoreCertificateAuthorityRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name for this CertificateAuthority in the format
                    /// `projects/*/locations/*/certificateAuthorities/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CertificateAuthorityService.v1beta1.Data.RestoreCertificateAuthorityRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "restore";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}:restore";

                    /// <summary>Initializes Restore parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/certificateAuthorities/[^/]+$",
                        });
                    }
                }

                /// <summary>Schedule a CertificateAuthority for deletion.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name for this CertificateAuthority in the format
                /// `projects/*/locations/*/certificateAuthorities/*`.
                /// </param>
                public virtual ScheduleDeleteRequest ScheduleDelete(Google.Apis.CertificateAuthorityService.v1beta1.Data.ScheduleDeleteCertificateAuthorityRequest body, string name)
                {
                    return new ScheduleDeleteRequest(service, body, name);
                }

                /// <summary>Schedule a CertificateAuthority for deletion.</summary>
                public class ScheduleDeleteRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new ScheduleDelete request.</summary>
                    public ScheduleDeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1beta1.Data.ScheduleDeleteCertificateAuthorityRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name for this CertificateAuthority in the format
                    /// `projects/*/locations/*/certificateAuthorities/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CertificateAuthorityService.v1beta1.Data.ScheduleDeleteCertificateAuthorityRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "scheduleDelete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}:scheduleDelete";

                    /// <summary>Initializes ScheduleDelete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/certificateAuthorities/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CertificateAuthorityService.v1beta1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1beta1.Data.SetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CertificateAuthorityService.v1beta1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/certificateAuthorities/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                /// documentation for the appropriate value for this field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CertificateAuthorityService.v1beta1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.CertificateAuthorityService.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/certificateAuthorities/[^/]+$",
                        });
                    }
                }
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
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(Google.Apis.CertificateAuthorityService.v1beta1.Data.CancelOperationRequest body, string name)
                {
                    return new CancelRequest(service, body, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
                /// </summary>
                public class CancelRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1beta1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CertificateAuthorityService.v1beta1.Data.CancelOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}:cancel";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes a long-running operation. This method indicates that the client is no longer interested in
                /// the operation result. It does not cancel the operation. If the server doesn't support this method,
                /// it returns `google.rpc.Code.UNIMPLEMENTED`.
                /// </summary>
                /// <param name="name">The name of the operation resource to be deleted.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a long-running operation. This method indicates that the client is no longer interested in
                /// the operation result. It does not cancel the operation. If the server doesn't support this method,
                /// it returns `google.rpc.Code.UNIMPLEMENTED`.
                /// </summary>
                public class DeleteRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be deleted.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }
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
                public class GetRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.Operation>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the
                /// binding to use different resource name schemes, such as `users/*/operations`. To override the
                /// binding, API services can add a binding such as `"/v1/{name=users/*}/operations"` to their service
                /// configuration. For backwards compatibility, the default name includes the operations collection id,
                /// however overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                /// <param name="name">The name of the operation's parent resource.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the
                /// binding to use different resource name schemes, such as `users/*/operations`. To override the
                /// binding, API services can add a binding such as `"/v1/{name=users/*}/operations"` to their service
                /// configuration. For backwards compatibility, the default name includes the operations collection id,
                /// however overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                public class ListRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.ListOperationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>The name of the operation's parent resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The standard list filter.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>The standard list page size.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The standard list page token.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}/operations";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
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

            /// <summary>Gets the ReusableConfigs resource.</summary>
            public virtual ReusableConfigsResource ReusableConfigs { get; }

            /// <summary>The "reusableConfigs" collection of methods.</summary>
            public class ReusableConfigsResource
            {
                private const string Resource = "reusableConfigs";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ReusableConfigsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Returns a ReusableConfig.</summary>
                /// <param name="name">Required. The name of the ReusableConfigs to get.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Returns a ReusableConfig.</summary>
                public class GetRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.ReusableConfig>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the ReusableConfigs to get.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/reusableConfigs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                    {
                        Resource = resource;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>
                    /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests
                    /// specifying an invalid value will be rejected. Requests for policies with any conditional
                    /// bindings must specify version 3. Policies without any conditional bindings may specify any valid
                    /// value or leave the field unset. To learn which resources support conditions in their IAM
                    /// policies, see the [IAM
                    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/reusableConfigs/[^/]+$",
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

                /// <summary>Lists ReusableConfigs.</summary>
                /// <param name="parent">
                /// Required. The resource name of the location associated with the ReusableConfigs, in the format
                /// `projects/*/locations/*`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists ReusableConfigs.</summary>
                public class ListRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.ListReusableConfigsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the location associated with the ReusableConfigs, in the format
                    /// `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Only include resources that match the filter in the response.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Specify how the results should be sorted.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. Limit on the number of ReusableConfigs to include in the response. Further
                    /// ReusableConfigs can subsequently be obtained by including the
                    /// ListReusableConfigsResponse.next_page_token in a subsequent request. If unspecified, the server
                    /// will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. Pagination token, returned earlier via ListReusableConfigsResponse.next_page_token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/reusableConfigs";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
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
                    }
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CertificateAuthorityService.v1beta1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1beta1.Data.SetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CertificateAuthorityService.v1beta1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/reusableConfigs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                /// documentation for the appropriate value for this field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CertificateAuthorityService.v1beta1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.CertificateAuthorityService.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/reusableConfigs/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.Location>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Resource name for the location.</summary>
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
                        Pattern = @"^projects/[^/]+/locations/[^/]+$",
                    });
                }
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1beta1.Data.ListLocationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>The resource that owns the locations collection, if applicable.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>The standard list filter.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>The standard list page size.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The standard list page token.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}/locations";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
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
    }
}
namespace Google.Apis.CertificateAuthorityService.v1beta1.Data
{
    /// <summary>URLs where a CertificateAuthority will publish content.</summary>
    public class AccessUrls : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The URL where this CertificateAuthority's CA certificate is published. This will only be set for CAs that
        /// have been activated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caCertificateAccessUrl")]
        public virtual string CaCertificateAccessUrl { get; set; }

        /// <summary>
        /// The URL where this CertificateAuthority's CRLs are published. This will only be set for CAs that have been
        /// activated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crlAccessUrl")]
        public virtual string CrlAccessUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CertificateAuthorityService.ActivateCertificateAuthority.</summary>
    public class ActivateCertificateAuthorityRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The signed CA certificate issued from FetchCertificateAuthorityCsrResponse.pem_csr.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pemCaCertificate")]
        public virtual string PemCaCertificate { get; set; }

        /// <summary>
        /// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry your request,
        /// the server will know to ignore the request if it has already been completed. The server will guarantee that
        /// for at least 60 minutes since the first request. For example, consider a situation where you make an initial
        /// request and t he request times out. If you make the request again with the same request ID, the server can
        /// check if original operation with the same request ID was received, and if so, will ignore the second
        /// request. This prevents clients from accidentally creating duplicate commitments. The request ID must be a
        /// valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>
        /// Required. Must include information about the issuer of 'pem_ca_certificate', and any further issuers until
        /// the self-signed CA.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subordinateConfig")]
        public virtual SubordinateConfig SubordinateConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AllowedConfigList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. All Certificates issued by the CertificateAuthority must match at least one listed
        /// ReusableConfigWrapper. If a ReusableConfigWrapper has an empty field, any value will be allowed for that
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedConfigValues")]
        public virtual System.Collections.Generic.IList<ReusableConfigWrapper> AllowedConfigValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// AllowedSubjectAltNames specifies the allowed values for SubjectAltNames by the CertificateAuthority when issuing
    /// Certificates.
    /// </summary>
    public class AllowedSubjectAltNames : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Specifies if to allow custom X509Extension values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowCustomSans")]
        public virtual System.Nullable<bool> AllowCustomSans { get; set; }

        /// <summary>
        /// Optional. Specifies if glob patterns used for allowed_dns_names allow wildcard certificates. If this is set,
        /// certificate requests with wildcard domains will be permitted to match a glob pattern specified in
        /// allowed_dns_names. Otherwise, certificate requests with wildcard domains will be permitted only if
        /// allowed_dns_names contains a literal wildcard.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowGlobbingDnsWildcards")]
        public virtual System.Nullable<bool> AllowGlobbingDnsWildcards { get; set; }

        /// <summary>
        /// Optional. Contains valid, fully-qualified host names. Glob patterns are also supported. To allow an explicit
        /// wildcard certificate, escape with backlash (i.e. "\*"). E.g. for globbed entries: '*bar.com' will allow
        /// 'foo.bar.com', but not '*.bar.com', unless the allow_globbing_dns_wildcards field is set. E.g. for wildcard
        /// entries: '\*.bar.com' will allow '*.bar.com', but not 'foo.bar.com'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedDnsNames")]
        public virtual System.Collections.Generic.IList<string> AllowedDnsNames { get; set; }

        /// <summary>Optional. Contains valid RFC 2822 E-mail addresses. Glob patterns are also supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedEmailAddresses")]
        public virtual System.Collections.Generic.IList<string> AllowedEmailAddresses { get; set; }

        /// <summary>
        /// Optional. Contains valid 32-bit IPv4 addresses and subnet ranges or RFC 4291 IPv6 addresses and subnet
        /// ranges. Subnet ranges are specified using the '/' notation (e.g. 10.0.0.0/8, 2001:700:300:1800::/64). Glob
        /// patterns are supported only for ip address entries (i.e. not for subnet ranges).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedIps")]
        public virtual System.Collections.Generic.IList<string> AllowedIps { get; set; }

        /// <summary>
        /// Optional. Contains valid RFC 3986 URIs. Glob patterns are also supported. To match across path seperators
        /// (i.e. '/') use the double star glob pattern (i.e. '**').
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedUris")]
        public virtual System.Collections.Generic.IList<string> AllowedUris { get; set; }

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

    /// <summary>Message for reporting billing requests through Eventstream.</summary>
    public class BillingView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Billing requests to be reported for cloud.eventstream.v2.ResourceEvent Each request contains billing
        /// operations to be reported under a service name. See go/billing-view-construction for documentation on
        /// constructing billing view report requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportRequests")]
        public virtual System.Collections.Generic.IList<GoogleApiServicecontrolV1ReportRequest> ReportRequests { get; set; }

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

    /// <summary>Describes values that are relevant in a CA certificate.</summary>
    public class CaOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Refers to the "CA" X.509 extension, which is a boolean value. When this value is missing, the
        /// extension will be omitted from the CA certificate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isCa")]
        public virtual System.Nullable<bool> IsCa { get; set; }

        /// <summary>
        /// Optional. Refers to the path length restriction X.509 extension. For a CA certificate, this value describes
        /// the depth of subordinate CA certificates that are allowed. If this value is less than 0, the request will
        /// fail. If this value is missing, the max path length will be omitted from the CA certificate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxIssuerPathLength")]
        public virtual System.Nullable<int> MaxIssuerPathLength { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Certificate corresponds to a signed X.509 certificate issued by a CertificateAuthority.</summary>
    public class Certificate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. A structured description of the issued X.509 certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateDescription")]
        public virtual CertificateDescription CertificateDescription { get; set; }

        /// <summary>Immutable. A description of the certificate and key that does not require X.509 or ASN.1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual CertificateConfig Config { get; set; }

        /// <summary>Output only. The time at which this Certificate was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Optional. Labels with user-defined metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. Immutable. The desired lifetime of a certificate. Used to create the "not_before_time" and
        /// "not_after_time" fields inside an X.509 certificate. Note that the lifetime may be truncated if it would
        /// extend past the life of any certificate authority in the issuing chain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifetime")]
        public virtual object Lifetime { get; set; }

        /// <summary>
        /// Output only. The resource path for this Certificate in the format
        /// `projects/*/locations/*/certificateAuthorities/*/certificates/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The pem-encoded, signed X.509 certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pemCertificate")]
        public virtual string PemCertificate { get; set; }

        /// <summary>
        /// Output only. The chain that may be used to verify the X.509 certificate. Expected to be in issuer-to-root
        /// order according to RFC 5246.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pemCertificateChain")]
        public virtual System.Collections.Generic.IList<string> PemCertificateChain { get; set; }

        /// <summary>Immutable. A pem-encoded X.509 certificate signing request (CSR).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pemCsr")]
        public virtual string PemCsr { get; set; }

        /// <summary>
        /// Output only. Details regarding the revocation of this Certificate. This Certificate is considered revoked if
        /// and only if this field is present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revocationDetails")]
        public virtual RevocationDetails RevocationDetails { get; set; }

        /// <summary>Output only. The time at which this Certificate was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A CertificateAuthority represents an individual Certificate Authority. A CertificateAuthority can be used to
    /// create Certificates.
    /// </summary>
    public class CertificateAuthority : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. URLs for accessing content published by this CA, such as the CA certificate and CRLs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessUrls")]
        public virtual AccessUrls AccessUrls { get; set; }

        /// <summary>
        /// Output only. A structured description of this CertificateAuthority's CA certificate and its issuers. Ordered
        /// as self-to-root.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caCertificateDescriptions")]
        public virtual System.Collections.Generic.IList<CertificateDescription> CaCertificateDescriptions { get; set; }

        /// <summary>
        /// Optional. The CertificateAuthorityPolicy to enforce when issuing Certificates from this
        /// CertificateAuthority.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificatePolicy")]
        public virtual CertificateAuthorityPolicy CertificatePolicy { get; set; }

        /// <summary>Required. Immutable. The config used to create a self-signed X.509 certificate or CSR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual CertificateConfig Config { get; set; }

        /// <summary>Output only. The time at which this CertificateAuthority was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Output only. The time at which this CertificateAuthority will be deleted, if scheduled for deletion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual object DeleteTime { get; set; }

        /// <summary>
        /// Immutable. The name of a Cloud Storage bucket where this CertificateAuthority will publish content, such as
        /// the CA certificate and CRLs. This must be a bucket name, without any prefixes (such as `gs://`) or suffixes
        /// (such as `.googleapis.com`). For example, to use a bucket named `my-bucket`, you would simply specify
        /// `my-bucket`. If not specified, a managed bucket will be created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsBucket")]
        public virtual string GcsBucket { get; set; }

        /// <summary>
        /// Optional. The IssuingOptions to follow when issuing Certificates from this CertificateAuthority.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuingOptions")]
        public virtual IssuingOptions IssuingOptions { get; set; }

        /// <summary>
        /// Required. Immutable. Used when issuing certificates for this CertificateAuthority. If this
        /// CertificateAuthority is a self-signed CertificateAuthority, this key is also used to sign the self-signed CA
        /// certificate. Otherwise, it is used to sign a CSR.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keySpec")]
        public virtual KeyVersionSpec KeySpec { get; set; }

        /// <summary>Optional. Labels with user-defined metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. The desired lifetime of the CA certificate. Used to create the "not_before_time" and
        /// "not_after_time" fields inside an X.509 certificate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifetime")]
        public virtual object Lifetime { get; set; }

        /// <summary>
        /// Output only. The resource name for this CertificateAuthority in the format
        /// `projects/*/locations/*/certificateAuthorities/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. This CertificateAuthority's certificate chain, including the current CertificateAuthority's
        /// certificate. Ordered such that the root issuer is the final element (consistent with RFC 5246). For a
        /// self-signed CA, this will only list the current CertificateAuthority's certificate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pemCaCertificates")]
        public virtual System.Collections.Generic.IList<string> PemCaCertificates { get; set; }

        /// <summary>Output only. The State for this CertificateAuthority.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Optional. If this is a subordinate CertificateAuthority, this field will be set with the subordinate
        /// configuration, which describes its issuers. This may be updated, but this CertificateAuthority must continue
        /// to validate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subordinateConfig")]
        public virtual SubordinateConfig SubordinateConfig { get; set; }

        /// <summary>Required. Immutable. The Tier of this CertificateAuthority.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tier")]
        public virtual string Tier { get; set; }

        /// <summary>Required. Immutable. The Type of this CertificateAuthority.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Output only. The time at which this CertificateAuthority was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The issuing policy for a CertificateAuthority. Certificates will not be successfully issued from this
    /// CertificateAuthority if they violate the policy.
    /// </summary>
    public class CertificateAuthorityPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If any value is specified here, then all Certificates issued by the CertificateAuthority must
        /// match at least one listed value. If no value is specified, all values will be allowed for this fied. Glob
        /// patterns are also supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedCommonNames")]
        public virtual System.Collections.Generic.IList<string> AllowedCommonNames { get; set; }

        /// <summary>
        /// Optional. All Certificates issued by the CertificateAuthority must match at least one listed
        /// ReusableConfigWrapper in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedConfigList")]
        public virtual AllowedConfigList AllowedConfigList { get; set; }

        /// <summary>
        /// Optional. If specified, then only methods allowed in the IssuanceModes may be used to issue Certificates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedIssuanceModes")]
        public virtual IssuanceModes AllowedIssuanceModes { get; set; }

        /// <summary>
        /// Optional. If any Subject is specified here, then all Certificates issued by the CertificateAuthority must
        /// match at least one listed Subject. If a Subject has an empty field, any value will be allowed for that
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedLocationsAndOrganizations")]
        public virtual System.Collections.Generic.IList<Subject> AllowedLocationsAndOrganizations { get; set; }

        /// <summary>
        /// Optional. If a AllowedSubjectAltNames is specified here, then all Certificates issued by the
        /// CertificateAuthority must match AllowedSubjectAltNames. If no value or an empty value is specified, any
        /// value will be allowed for the SubjectAltNames field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedSans")]
        public virtual AllowedSubjectAltNames AllowedSans { get; set; }

        /// <summary>
        /// Optional. The maximum lifetime allowed by the CertificateAuthority. Note that if the any part if the issuing
        /// chain expires before a Certificate's requested maximum_lifetime, the effective lifetime will be explicitly
        /// truncated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumLifetime")]
        public virtual object MaximumLifetime { get; set; }

        /// <summary>
        /// Optional. All Certificates issued by the CertificateAuthority will use the provided configuration values,
        /// overwriting any requested configuration values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overwriteConfigValues")]
        public virtual ReusableConfigWrapper OverwriteConfigValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A CertificateConfig describes an X.509 certificate or CSR that is to be created, as an alternative to using
    /// ASN.1.
    /// </summary>
    public class CertificateConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The public key that corresponds to this config. This is, for example, used when issuing
        /// Certificates, but not when creating a self-signed CertificateAuthority or CertificateAuthority CSR.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKey")]
        public virtual PublicKey PublicKey { get; set; }

        /// <summary>
        /// Required. Describes how some of the technical fields in a certificate should be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reusableConfig")]
        public virtual ReusableConfigWrapper ReusableConfig { get; set; }

        /// <summary>Required. Specifies some of the values in a certificate that are related to the subject.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subjectConfig")]
        public virtual SubjectConfig SubjectConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A CertificateDescription describes an X.509 certificate or CSR that has been issued, as an alternative to using
    /// ASN.1 / X.509.
    /// </summary>
    public class CertificateDescription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Describes lists of issuer CA certificate URLs that appear in the "Authority Information Access" extension in
        /// the certificate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aiaIssuingCertificateUrls")]
        public virtual System.Collections.Generic.IList<string> AiaIssuingCertificateUrls { get; set; }

        /// <summary>
        /// Identifies the subject_key_id of the parent certificate, per
        /// https://tools.ietf.org/html/rfc5280#section-4.2.1.1
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorityKeyId")]
        public virtual KeyId AuthorityKeyId { get; set; }

        /// <summary>The hash of the x.509 certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certFingerprint")]
        public virtual CertificateFingerprint CertFingerprint { get; set; }

        /// <summary>Describes some of the technical fields in a certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configValues")]
        public virtual ReusableConfigValues ConfigValues { get; set; }

        /// <summary>
        /// Describes a list of locations to obtain CRL information, i.e. the DistributionPoint.fullName described by
        /// https://tools.ietf.org/html/rfc5280#section-4.2.1.13
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crlDistributionPoints")]
        public virtual System.Collections.Generic.IList<string> CrlDistributionPoints { get; set; }

        /// <summary>The public key that corresponds to an issued certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKey")]
        public virtual PublicKey PublicKey { get; set; }

        /// <summary>
        /// Describes some of the values in a certificate that are related to the subject and lifetime.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subjectDescription")]
        public virtual SubjectDescription SubjectDescription { get; set; }

        /// <summary>
        /// Provides a means of identifiying certificates that contain a particular public key, per
        /// https://tools.ietf.org/html/rfc5280#section-4.2.1.2.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subjectKeyId")]
        public virtual KeyId SubjectKeyId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A group of fingerprints for the x509 certificate.</summary>
    public class CertificateFingerprint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The SHA 256 hash, encoded in hexadecimal, of the DER x509 certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256Hash")]
        public virtual string Sha256Hash { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A CertificateRevocationList corresponds to a signed X.509 certificate Revocation List (CRL). A CRL contains the
    /// serial numbers of certificates that should no longer be trusted.
    /// </summary>
    public class CertificateRevocationList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The location where 'pem_crl' can be accessed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessUrl")]
        public virtual string AccessUrl { get; set; }

        /// <summary>Output only. The time at which this CertificateRevocationList was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Optional. Labels with user-defined metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. The resource path for this CertificateRevocationList in the format
        /// `projects/*/locations/*/certificateAuthorities/*/ certificateRevocationLists/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The PEM-encoded X.509 CRL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pemCrl")]
        public virtual string PemCrl { get; set; }

        /// <summary>Output only. The revoked serial numbers that appear in pem_crl.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revokedCertificates")]
        public virtual System.Collections.Generic.IList<RevokedCertificate> RevokedCertificates { get; set; }

        /// <summary>Output only. The CRL sequence number that appears in pem_crl.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sequenceNumber")]
        public virtual System.Nullable<long> SequenceNumber { get; set; }

        /// <summary>Output only. The State for this CertificateRevocationList.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. The time at which this CertificateRevocationList was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CertificateAuthorityService.DisableCertificateAuthority.</summary>
    public class DisableCertificateAuthorityRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry your request,
        /// the server will know to ignore the request if it has already been completed. The server will guarantee that
        /// for at least 60 minutes since the first request. For example, consider a situation where you make an initial
        /// request and t he request times out. If you make the request again with the same request ID, the server can
        /// check if original operation with the same request ID was received, and if so, will ignore the second
        /// request. This prevents clients from accidentally creating duplicate commitments. The request ID must be a
        /// valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

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

    /// <summary>Request message for CertificateAuthorityService.EnableCertificateAuthority.</summary>
    public class EnableCertificateAuthorityRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry your request,
        /// the server will know to ignore the request if it has already been completed. The server will guarantee that
        /// for at least 60 minutes since the first request. For example, consider a situation where you make an initial
        /// request and t he request times out. If you make the request again with the same request ID, the server can
        /// check if original operation with the same request ID was received, and if so, will ignore the second
        /// request. This prevents clients from accidentally creating duplicate commitments. The request ID must be a
        /// valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Exemplars are example points that may be used to annotate aggregated distribution values. They are metadata that
    /// gives information about a particular value added to a Distribution bucket, such as a trace ID that was active
    /// when a value was added. They may contain further information, such as a example values and timestamps, origin,
    /// etc.
    /// </summary>
    public class Exemplar : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Contextual information about the example value. Examples are: Trace:
        /// type.googleapis.com/google.monitoring.v3.SpanContext Literal string:
        /// type.googleapis.com/google.protobuf.StringValue Labels dropped during aggregation:
        /// type.googleapis.com/google.monitoring.v3.DroppedLabels There may be only a single attachment of any given
        /// message type in a single exemplar, and this is enforced by the system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachments")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Attachments { get; set; }

        /// <summary>The observation (sampling) time of the above value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual object Timestamp { get; set; }

        /// <summary>Value of the exemplar point. This value determines to which bucket the exemplar belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value { get; set; }

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
    /// KeyUsage.ExtendedKeyUsageOptions has fields that correspond to certain common OIDs that could be specified as an
    /// extended key usage value.
    /// </summary>
    public class ExtendedKeyUsageOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Corresponds to OID 1.3.6.1.5.5.7.3.2. Officially described as "TLS WWW client authentication", though
        /// regularly used for non-WWW TLS.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientAuth")]
        public virtual System.Nullable<bool> ClientAuth { get; set; }

        /// <summary>
        /// Corresponds to OID 1.3.6.1.5.5.7.3.3. Officially described as "Signing of downloadable executable code
        /// client authentication".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codeSigning")]
        public virtual System.Nullable<bool> CodeSigning { get; set; }

        /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.4. Officially described as "Email protection".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailProtection")]
        public virtual System.Nullable<bool> EmailProtection { get; set; }

        /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.9. Officially described as "Signing OCSP responses".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ocspSigning")]
        public virtual System.Nullable<bool> OcspSigning { get; set; }

        /// <summary>
        /// Corresponds to OID 1.3.6.1.5.5.7.3.1. Officially described as "TLS WWW server authentication", though
        /// regularly used for non-WWW TLS.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverAuth")]
        public virtual System.Nullable<bool> ServerAuth { get; set; }

        /// <summary>
        /// Corresponds to OID 1.3.6.1.5.5.7.3.8. Officially described as "Binding the hash of an object to a time".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeStamping")]
        public virtual System.Nullable<bool> TimeStamping { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for CertificateAuthorityService.FetchCertificateAuthorityCsr.</summary>
    public class FetchCertificateAuthorityCsrResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The PEM-encoded signed certificate signing request (CSR).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pemCsr")]
        public virtual string PemCsr { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The allowed types for [VALUE] in a `[KEY]:[VALUE]` attribute.</summary>
    public class GoogleApiServicecontrolV1AttributeValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A Boolean value represented by `true` or `false`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; }

        /// <summary>A 64-bit signed integer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intValue")]
        public virtual System.Nullable<long> IntValue { get; set; }

        /// <summary>A string up to 256 bytes long.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual GoogleApiServicecontrolV1TruncatableString StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A set of attributes, each in the format `[KEY]:[VALUE]`.</summary>
    public class GoogleApiServicecontrolV1Attributes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of attributes. Each attribute's key can be up to 128 bytes long. The value can be a string up to 256
        /// bytes, a signed 64-bit integer, or the Boolean values `true` and `false`. For example: "/instance_id":
        /// "my-instance" "/http/user_agent": "" "/http/request_bytes": 300 "abc.com/myattribute": true
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeMap")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleApiServicecontrolV1AttributeValue> AttributeMap { get; set; }

        /// <summary>
        /// The number of attributes that were discarded. Attributes can be discarded because their keys are too long or
        /// because there are too many attributes. If this value is 0 then all attributes are valid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("droppedAttributesCount")]
        public virtual System.Nullable<int> DroppedAttributesCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Distribution represents a frequency distribution of double-valued sample points. It contains the size of the
    /// population of sample points plus additional optional information: - the arithmetic mean of the samples - the
    /// minimum and maximum of the samples - the sum-squared-deviation of the samples, used to compute variance - a
    /// histogram of the values of the sample points
    /// </summary>
    public class GoogleApiServicecontrolV1Distribution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of samples in each histogram bucket. `bucket_counts` are optional. If present, they must sum to
        /// the `count` value. The buckets are defined below in `bucket_option`. There are N buckets. `bucket_counts[0]`
        /// is the number of samples in the underflow bucket. `bucket_counts[1]` to `bucket_counts[N-1]` are the numbers
        /// of samples in each of the finite buckets. And `bucket_counts[N] is the number of samples in the overflow
        /// bucket. See the comments of `bucket_option` below for more details. Any suffix of trailing zeros may be
        /// omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketCounts")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> BucketCounts { get; set; }

        /// <summary>The total number of samples in the distribution. Must be &gt;= 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>Example points. Must be in increasing order of `value` field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exemplars")]
        public virtual System.Collections.Generic.IList<Exemplar> Exemplars { get; set; }

        /// <summary>Buckets with arbitrary user-provided width.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explicitBuckets")]
        public virtual GoogleApiServicecontrolV1ExplicitBuckets ExplicitBuckets { get; set; }

        /// <summary>Buckets with exponentially growing width.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exponentialBuckets")]
        public virtual GoogleApiServicecontrolV1ExponentialBuckets ExponentialBuckets { get; set; }

        /// <summary>Buckets with constant width.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linearBuckets")]
        public virtual GoogleApiServicecontrolV1LinearBuckets LinearBuckets { get; set; }

        /// <summary>The maximum of the population of values. Ignored if `count` is zero.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximum")]
        public virtual System.Nullable<double> Maximum { get; set; }

        /// <summary>
        /// The arithmetic mean of the samples in the distribution. If `count` is zero then this field must be zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mean")]
        public virtual System.Nullable<double> Mean { get; set; }

        /// <summary>The minimum of the population of values. Ignored if `count` is zero.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimum")]
        public virtual System.Nullable<double> Minimum { get; set; }

        /// <summary>
        /// The sum of squared deviations from the mean: Sum[i=1..count]((x_i - mean)^2) where each x_i is a sample
        /// values. If `count` is zero then this field must be zero, otherwise validation of the request fails.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sumOfSquaredDeviation")]
        public virtual System.Nullable<double> SumOfSquaredDeviation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describing buckets with arbitrary user-provided width.</summary>
    public class GoogleApiServicecontrolV1ExplicitBuckets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// 'bound' is a list of strictly increasing boundaries between buckets. Note that a list of length N-1 defines
        /// N buckets because of fenceposting. See comments on `bucket_options` for details. The i'th finite bucket
        /// covers the interval [bound[i-1], bound[i]) where i ranges from 1 to bound_size() - 1. Note that there are no
        /// finite buckets at all if 'bound' only contains a single element; in that special case the single bound
        /// defines the boundary between the underflow and overflow buckets. bucket number lower bound upper bound i ==
        /// 0 (underflow) -inf bound[i] 0 &amp;lt; i &amp;lt; bound_size() bound[i-1] bound[i] i == bound_size()
        /// (overflow) bound[i-1] +inf
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bounds")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> Bounds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describing buckets with exponentially growing width.</summary>
    public class GoogleApiServicecontrolV1ExponentialBuckets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The i'th exponential bucket covers the interval [scale * growth_factor^(i-1), scale * growth_factor^i) where
        /// i ranges from 1 to num_finite_buckets inclusive. Must be larger than 1.0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("growthFactor")]
        public virtual System.Nullable<double> GrowthFactor { get; set; }

        /// <summary>
        /// The number of finite buckets. With the underflow and overflow buckets, the total number of buckets is
        /// `num_finite_buckets` + 2. See comments on `bucket_options` for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numFiniteBuckets")]
        public virtual System.Nullable<int> NumFiniteBuckets { get; set; }

        /// <summary>
        /// The i'th exponential bucket covers the interval [scale * growth_factor^(i-1), scale * growth_factor^i) where
        /// i ranges from 1 to num_finite_buckets inclusive. Must be &amp;gt; 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scale")]
        public virtual System.Nullable<double> Scale { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A common proto for logging HTTP requests. Only contains semantics defined by the HTTP specification.
    /// Product-specific logging information MUST be defined in a separate message.
    /// </summary>
    public class GoogleApiServicecontrolV1HttpRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of HTTP response bytes inserted into cache. Set only when a cache fill was attempted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheFillBytes")]
        public virtual System.Nullable<long> CacheFillBytes { get; set; }

        /// <summary>Whether or not an entity was served from cache (with or without validation).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheHit")]
        public virtual System.Nullable<bool> CacheHit { get; set; }

        /// <summary>Whether or not a cache lookup was attempted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheLookup")]
        public virtual System.Nullable<bool> CacheLookup { get; set; }

        /// <summary>
        /// Whether or not the response was validated with the origin server before being served from cache. This field
        /// is only meaningful if `cache_hit` is True.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheValidatedWithOriginServer")]
        public virtual System.Nullable<bool> CacheValidatedWithOriginServer { get; set; }

        /// <summary>
        /// The request processing latency on the server, from the time the request was received until the response was
        /// sent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latency")]
        public virtual object Latency { get; set; }

        /// <summary>Protocol used for the request. Examples: "HTTP/1.1", "HTTP/2", "websocket"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>
        /// The referer URL of the request, as defined in [HTTP/1.1 Header Field
        /// Definitions](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referer")]
        public virtual string Referer { get; set; }

        /// <summary>
        /// The IP address (IPv4 or IPv6) of the client that issued the HTTP request. Examples: `"192.168.1.1"`,
        /// `"FE80::0202:B3FF:FE1E:8329"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remoteIp")]
        public virtual string RemoteIp { get; set; }

        /// <summary>The request method. Examples: `"GET"`, `"HEAD"`, `"PUT"`, `"POST"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestMethod")]
        public virtual string RequestMethod { get; set; }

        /// <summary>
        /// The size of the HTTP request message in bytes, including the request headers and the request body.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestSize")]
        public virtual System.Nullable<long> RequestSize { get; set; }

        /// <summary>
        /// The scheme (http, https), the host name, the path, and the query portion of the URL that was requested.
        /// Example: `"http://example.com/some/info?color=red"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestUrl")]
        public virtual string RequestUrl { get; set; }

        /// <summary>
        /// The size of the HTTP response message sent back to the client, in bytes, including the response headers and
        /// the response body.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseSize")]
        public virtual System.Nullable<long> ResponseSize { get; set; }

        /// <summary>The IP address (IPv4 or IPv6) of the origin server that the request was sent to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverIp")]
        public virtual string ServerIp { get; set; }

        /// <summary>The response code indicating the status of the response. Examples: 200, 404.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual System.Nullable<int> Status { get; set; }

        /// <summary>
        /// The user agent sent by the client. Example: `"Mozilla/4.0 (compatible; MSIE 6.0; Windows 98; Q312461; .NET
        /// CLR 1.0.3705)"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describing buckets with constant width.</summary>
    public class GoogleApiServicecontrolV1LinearBuckets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of finite buckets. With the underflow and overflow buckets, the total number of buckets is
        /// `num_finite_buckets` + 2. See comments on `bucket_options` for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numFiniteBuckets")]
        public virtual System.Nullable<int> NumFiniteBuckets { get; set; }

        /// <summary>
        /// The i'th linear bucket covers the interval [offset + (i-1) * width, offset + i * width) where i ranges from
        /// 1 to num_finite_buckets, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offset")]
        public virtual System.Nullable<double> Offset { get; set; }

        /// <summary>
        /// The i'th linear bucket covers the interval [offset + (i-1) * width, offset + i * width) where i ranges from
        /// 1 to num_finite_buckets, inclusive. Must be strictly positive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<double> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An individual log entry.</summary>
    public class GoogleApiServicecontrolV1LogEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Information about the HTTP request associated with this log entry, if applicable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpRequest")]
        public virtual GoogleApiServicecontrolV1HttpRequest HttpRequest { get; set; }

        /// <summary>
        /// A unique ID for the log entry used for deduplication. If omitted, the implementation will generate one based
        /// on operation_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertId")]
        public virtual string InsertId { get; set; }

        /// <summary>
        /// A set of user-defined (key, value) data that provides additional information about the log entry.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Required. The log to which this log entry belongs. Examples: `"syslog"`, `"book_log"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Information about an operation associated with the log entry, if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual GoogleApiServicecontrolV1LogEntryOperation Operation { get; set; }

        /// <summary>
        /// The log entry payload, represented as a protocol buffer that is expressed as a JSON object. The only
        /// accepted type currently is AuditLog.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protoPayload")]
        public virtual System.Collections.Generic.IDictionary<string, object> ProtoPayload { get; set; }

        /// <summary>The severity of the log entry. The default value is `LogSeverity.DEFAULT`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>Optional. Source code location information associated with the log entry, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceLocation")]
        public virtual GoogleApiServicecontrolV1LogEntrySourceLocation SourceLocation { get; set; }

        /// <summary>The log entry payload, represented as a structure that is expressed as a JSON object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structPayload")]
        public virtual System.Collections.Generic.IDictionary<string, object> StructPayload { get; set; }

        /// <summary>The log entry payload, represented as a Unicode string (UTF-8).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textPayload")]
        public virtual string TextPayload { get; set; }

        /// <summary>
        /// The time the event described by the log entry occurred. If omitted, defaults to operation start time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual object Timestamp { get; set; }

        /// <summary>
        /// Optional. Resource name of the trace associated with the log entry, if any. If this field contains a
        /// relative resource name, you can assume the name is relative to `//tracing.googleapis.com`. Example:
        /// `projects/my-projectid/traces/06796866738c859f2f19b7cfb3214824`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trace")]
        public virtual string Trace { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Additional information about a potentially long-running operation with which a log entry is associated.
    /// </summary>
    public class GoogleApiServicecontrolV1LogEntryOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Set this to True if this is the first log entry in the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("first")]
        public virtual System.Nullable<bool> First { get; set; }

        /// <summary>
        /// Optional. An arbitrary operation identifier. Log entries with the same identifier are assumed to be part of
        /// the same operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. Set this to True if this is the last log entry in the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("last")]
        public virtual System.Nullable<bool> Last { get; set; }

        /// <summary>
        /// Optional. An arbitrary producer identifier. The combination of `id` and `producer` must be globally unique.
        /// Examples for `producer`: `"MyDivision.MyBigCompany.com"`, `"github.com/MyProject/MyApplication"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("producer")]
        public virtual string Producer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional information about the source code location that produced the log entry.</summary>
    public class GoogleApiServicecontrolV1LogEntrySourceLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Source file name. Depending on the runtime environment, this might be a simple name or a
        /// fully-qualified name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("file")]
        public virtual string File { get; set; }

        /// <summary>
        /// Optional. Human-readable name of the function or method being invoked, with optional context such as the
        /// class or package name. This information may be used in contexts such as the logs viewer, where a file and
        /// line number are less meaningful. The format can vary by language. For example: `qual.if.ied.Class.method`
        /// (Java), `dir/package.func` (Go), `function` (Python).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("function")]
        public virtual string Function { get; set; }

        /// <summary>Optional. Line within the source file. 1-based; 0 indicates no line number available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("line")]
        public virtual System.Nullable<long> Line { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a single metric value.</summary>
    public class GoogleApiServicecontrolV1MetricValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A boolean value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; }

        /// <summary>A distribution value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distributionValue")]
        public virtual GoogleApiServicecontrolV1Distribution DistributionValue { get; set; }

        /// <summary>A double precision floating point value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        /// <summary>
        /// The end of the time period over which this metric value's measurement applies. If not specified,
        /// google.api.servicecontrol.v1.Operation.end_time will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>A signed 64-bit integer value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("int64Value")]
        public virtual System.Nullable<long> Int64Value { get; set; }

        /// <summary>
        /// The labels describing the metric value. See comments on google.api.servicecontrol.v1.Operation.labels for
        /// the overriding relationship. Note that this map must not contain monitored resource labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>A money value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moneyValue")]
        public virtual Money MoneyValue { get; set; }

        /// <summary>
        /// The start of the time period over which this metric value's measurement applies. The time period has
        /// different semantics for different metric types (cumulative, delta, and gauge). See the metric definition
        /// documentation in the service configuration for details. If not specified,
        /// google.api.servicecontrol.v1.Operation.start_time will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>A text string value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a set of metric values in the same metric. Each metric value in the set should have a unique
    /// combination of start time, end time, and label values.
    /// </summary>
    public class GoogleApiServicecontrolV1MetricValueSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The metric name defined in the service configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricName")]
        public virtual string MetricName { get; set; }

        /// <summary>The values in this metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricValues")]
        public virtual System.Collections.Generic.IList<GoogleApiServicecontrolV1MetricValue> MetricValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents information regarding an operation.</summary>
    public class GoogleApiServicecontrolV1Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identity of the consumer who is using the service. This field should be filled in for the operations
        /// initiated by a consumer, but not for service-initiated operations that are not related to a specific
        /// consumer. - This can be in one of the following formats: - project:PROJECT_ID, -
        /// project`_`number:PROJECT_NUMBER, - projects/PROJECT_ID or PROJECT_NUMBER, - folders/FOLDER_NUMBER, -
        /// organizations/ORGANIZATION_NUMBER, - api`_`key:API_KEY.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerId")]
        public virtual string ConsumerId { get; set; }

        /// <summary>
        /// End time of the operation. Required when the operation is used in ServiceController.Report, but optional
        /// when the operation is used in ServiceController.Check.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Unimplemented.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extensions")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Extensions { get; set; }

        /// <summary>DO NOT USE. This is an experimental field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importance")]
        public virtual string Importance { get; set; }

        /// <summary>
        /// Labels describing the operation. Only the following labels are allowed: - Labels describing monitored
        /// resources as defined in the service configuration. - Default labels of metric values. When specified, labels
        /// defined in the metric value override these default. - The following labels defined by Google Cloud Platform:
        /// - `cloud.googleapis.com/location` describing the location where the operation happened, -
        /// `servicecontrol.googleapis.com/user_agent` describing the user agent of the API request, -
        /// `servicecontrol.googleapis.com/service_agent` describing the service used to handle the API request (e.g.
        /// ESP), - `servicecontrol.googleapis.com/platform` describing the platform where the API is served, such as
        /// App Engine, Compute Engine, or Kubernetes Engine.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Represents information to be logged.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logEntries")]
        public virtual System.Collections.Generic.IList<GoogleApiServicecontrolV1LogEntry> LogEntries { get; set; }

        /// <summary>
        /// Represents information about this operation. Each MetricValueSet corresponds to a metric defined in the
        /// service configuration. The data type used in the MetricValueSet must agree with the data type specified in
        /// the metric definition. Within a single operation, it is not allowed to have more than one MetricValue
        /// instances that have the same metric names and identical label value combinations. If a request has such
        /// duplicated MetricValue instances, the entire request is rejected with an invalid argument error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricValueSets")]
        public virtual System.Collections.Generic.IList<GoogleApiServicecontrolV1MetricValueSet> MetricValueSets { get; set; }

        /// <summary>
        /// Identity of the operation. This must be unique within the scope of the service that generated the operation.
        /// If the service calls Check() and Report() on the same operation, the two calls should carry the same id.
        /// UUID version 4 is recommended, though not required. In scenarios where an operation is computed from
        /// existing information and an idempotent id is desirable for deduplication purpose, UUID version 5 is
        /// recommended. See RFC 4122 for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; }

        /// <summary>Fully qualified name of the operation. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationName")]
        public virtual string OperationName { get; set; }

        /// <summary>
        /// Represents the properties needed for quota check. Applicable only if this operation is for a quota check
        /// request. If this is not specified, no quota check will be performed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaProperties")]
        public virtual GoogleApiServicecontrolV1QuotaProperties QuotaProperties { get; set; }

        /// <summary>
        /// The resources that are involved in the operation. The maximum supported number of entries in this field is
        /// 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<GoogleApiServicecontrolV1ResourceInfo> Resources { get; set; }

        /// <summary>Required. Start time of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>
        /// Unimplemented. A list of Cloud Trace spans. The span names shall contain the id of the destination project
        /// which can be either the produce or the consumer project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traceSpans")]
        public virtual System.Collections.Generic.IList<GoogleApiServicecontrolV1TraceSpan> TraceSpans { get; set; }

        /// <summary>
        /// Private Preview. This feature is only available for approved services. User defined labels for the resource
        /// that this operation is associated with. Only a combination of 1000 user labels per consumer project are
        /// allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> UserLabels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the properties needed for quota operations.</summary>
    public class GoogleApiServicecontrolV1QuotaProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Quota mode for this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaMode")]
        public virtual string QuotaMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the Report method.</summary>
    public class GoogleApiServicecontrolV1ReportRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Operations to be reported. Typically the service should report one operation per request. Putting multiple
        /// operations into a single request is allowed, but should be used only when multiple operations are natually
        /// available at the time of the report. There is no limit on the number of operations in the same
        /// ReportRequest, however the ReportRequest size should be no larger than 1MB. See ReportResponse.report_errors
        /// for partial failure behavior.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<GoogleApiServicecontrolV1Operation> Operations { get; set; }

        /// <summary>
        /// Specifies which version of service config should be used to process the request. If unspecified or no
        /// matching version can be found, the latest one will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceConfigId")]
        public virtual string ServiceConfigId { get; set; }

        /// <summary>
        /// The service name as specified in its service configuration. For example, `"pubsub.googleapis.com"`. See
        /// [google.api.Service](https://cloud.google.com/service-management/reference/rpc/google.api#google.api.Service)
        /// for the definition of a service name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a resource associated with this operation.</summary>
    public class GoogleApiServicecontrolV1ResourceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The identifier of the parent of this resource instance. Must be in one of the following formats: -
        /// `projects/` - `folders/` - `organizations/`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceContainer")]
        public virtual string ResourceContainer { get; set; }

        /// <summary>
        /// The location of the resource. If not empty, the resource will be checked against location policy. The value
        /// must be a valid zone, region or multiregion. For example: "europe-west4" or "northamerica-northeast1-a"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceLocation")]
        public virtual string ResourceLocation { get; set; }

        /// <summary>Name of the resource. This is used for auditing purposes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A span represents a single operation within a trace. Spans can be nested to form a trace tree. Often, a trace
    /// contains a root span that describes the end-to-end latency, and one or more subspans for its sub-operations. A
    /// trace can also contain multiple root spans, or none at all. Spans do not need to be contiguous—there may be gaps
    /// or overlaps between spans in a trace.
    /// </summary>
    public class GoogleApiServicecontrolV1TraceSpan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A set of attributes on the span. You can have up to 32 attributes per span.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual GoogleApiServicecontrolV1Attributes Attributes { get; set; }

        /// <summary>
        /// An optional number of child spans that were generated while this span was active. If set, allows
        /// implementation to detect missing child spans.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childSpanCount")]
        public virtual System.Nullable<int> ChildSpanCount { get; set; }

        /// <summary>
        /// A description of the span's operation (up to 128 bytes). Stackdriver Trace displays the description in the
        /// Google Cloud Platform Console. For example, the display name can be a qualified method name or a file name
        /// and a line number where the operation is called. A best practice is to use the same display name within an
        /// application and at the same call point. This makes it easier to correlate spans in different traces.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual GoogleApiServicecontrolV1TruncatableString DisplayName { get; set; }

        /// <summary>
        /// The end time of the span. On the client side, this is the time kept by the local machine where the span
        /// execution ends. On the server side, this is the time when the server application handler stops running.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// The resource name of the span in the following format: projects/[PROJECT_ID]/traces/[TRACE_ID]/spans/SPAN_ID
        /// is a unique identifier for a trace within a project; it is a 32-character hexadecimal encoding of a 16-byte
        /// array. [SPAN_ID] is a unique identifier for a span within a trace; it is a 16-character hexadecimal encoding
        /// of an 8-byte array.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The [SPAN_ID] of this span's parent span. If this is a root span, then this field must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentSpanId")]
        public virtual string ParentSpanId { get; set; }

        /// <summary>
        /// (Optional) Set this parameter to indicate whether this span is in the same process as its parent. If you do
        /// not set this parameter, Stackdriver Trace is unable to take advantage of this helpful information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sameProcessAsParentSpan")]
        public virtual System.Nullable<bool> SameProcessAsParentSpan { get; set; }

        /// <summary>The [SPAN_ID] portion of the span's resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spanId")]
        public virtual string SpanId { get; set; }

        /// <summary>
        /// Distinguishes between spans generated in a particular context. For example, two spans with the same name may
        /// be distinguished using `CLIENT` (caller) and `SERVER` (callee) to identify an RPC call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spanKind")]
        public virtual string SpanKind { get; set; }

        /// <summary>
        /// The start time of the span. On the client side, this is the time kept by the local machine where the span
        /// execution starts. On the server side, this is the time when the server's application handler starts running.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>An optional final status for this span.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual Status Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a string that might be shortened to a specified length.</summary>
    public class GoogleApiServicecontrolV1TruncatableString : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of bytes removed from the original string. If this value is 0, then the string was not shortened.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("truncatedByteCount")]
        public virtual System.Nullable<int> TruncatedByteCount { get; set; }

        /// <summary>
        /// The shortened string. For example, if the original string is 500 bytes long and the limit of the string is
        /// 128 bytes, then `value` contains the first 128 bytes of the 500-byte string. Truncation always happens on a
        /// UTF8 character boundary. If there are multi-byte characters in the string, then the length of the shortened
        /// string might be less than the size limit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// IssuanceModes specifies the allowed ways in which Certificates may be requested from this CertificateAuthority.
    /// </summary>
    public class IssuanceModes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. When true, allows callers to create Certificates by specifying a CertificateConfig.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowConfigBasedIssuance")]
        public virtual System.Nullable<bool> AllowConfigBasedIssuance { get; set; }

        /// <summary>Required. When true, allows callers to create Certificates by specifying a CSR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowCsrBasedIssuance")]
        public virtual System.Nullable<bool> AllowCsrBasedIssuance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options that affect all certificates issued by a CertificateAuthority.</summary>
    public class IssuingOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. When true, includes a URL to the issuing CA certificate in the "authority information access"
        /// X.509 extension.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeCaCertUrl")]
        public virtual System.Nullable<bool> IncludeCaCertUrl { get; set; }

        /// <summary>
        /// Required. When true, includes a URL to the CRL corresponding to certificates issued from a
        /// CertificateAuthority. CRLs will expire 7 days from their creation. However, we will rebuild daily. CRLs are
        /// also rebuilt shortly after a certificate is revoked.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeCrlAccessUrl")]
        public virtual System.Nullable<bool> IncludeCrlAccessUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A KeyId identifies a specific public key, usually by hashing the public key.</summary>
    public class KeyId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The value of this KeyId encoded in lowercase hexadecimal. This is most likely the 160 bit SHA-1
        /// hash of the public key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyId")]
        public virtual string KeyIdValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A KeyUsage describes key usage values that may appear in an X.509 certificate.</summary>
    public class KeyUsage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Describes high-level ways in which a key may be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseKeyUsage")]
        public virtual KeyUsageOptions BaseKeyUsage { get; set; }

        /// <summary>Detailed scenarios in which a key may be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extendedKeyUsage")]
        public virtual ExtendedKeyUsageOptions ExtendedKeyUsage { get; set; }

        /// <summary>
        /// Used to describe extended key usages that are not listed in the KeyUsage.ExtendedKeyUsageOptions message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unknownExtendedKeyUsages")]
        public virtual System.Collections.Generic.IList<ObjectId> UnknownExtendedKeyUsages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// KeyUsage.KeyUsageOptions corresponds to the key usage values described in
    /// https://tools.ietf.org/html/rfc5280#section-4.2.1.3.
    /// </summary>
    public class KeyUsageOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The key may be used to sign certificates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certSign")]
        public virtual System.Nullable<bool> CertSign { get; set; }

        /// <summary>
        /// The key may be used for cryptographic commitments. Note that this may also be referred to as
        /// "non-repudiation".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentCommitment")]
        public virtual System.Nullable<bool> ContentCommitment { get; set; }

        /// <summary>The key may be used sign certificate revocation lists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crlSign")]
        public virtual System.Nullable<bool> CrlSign { get; set; }

        /// <summary>The key may be used to encipher data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataEncipherment")]
        public virtual System.Nullable<bool> DataEncipherment { get; set; }

        /// <summary>The key may be used to decipher only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("decipherOnly")]
        public virtual System.Nullable<bool> DecipherOnly { get; set; }

        /// <summary>The key may be used for digital signatures.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digitalSignature")]
        public virtual System.Nullable<bool> DigitalSignature { get; set; }

        /// <summary>The key may be used to encipher only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encipherOnly")]
        public virtual System.Nullable<bool> EncipherOnly { get; set; }

        /// <summary>The key may be used in a key agreement protocol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyAgreement")]
        public virtual System.Nullable<bool> KeyAgreement { get; set; }

        /// <summary>The key may be used to encipher other keys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyEncipherment")]
        public virtual System.Nullable<bool> KeyEncipherment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Cloud KMS key configuration that a CertificateAuthority will use.</summary>
    public class KeyVersionSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The algorithm to use for creating a managed Cloud KMS key for a for a simplified experience. All
        /// managed keys will be have their ProtectionLevel as `HSM`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("algorithm")]
        public virtual string Algorithm { get; set; }

        /// <summary>
        /// Required. The resource name for an existing Cloud KMS CryptoKeyVersion in the format
        /// `projects/*/locations/*/keyRings/*/cryptoKeys/*/cryptoKeyVersions/*`. This option enables full flexibility
        /// in the key's capabilities and properties.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudKmsKeyVersion")]
        public virtual string CloudKmsKeyVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for CertificateAuthorityService.ListCertificateAuthorities.</summary>
    public class ListCertificateAuthoritiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of CertificateAuthorities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateAuthorities")]
        public virtual System.Collections.Generic.IList<CertificateAuthority> CertificateAuthorities { get; set; }

        /// <summary>
        /// A token to retrieve next page of results. Pass this value in
        /// ListCertificateAuthoritiesRequest.next_page_token to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of locations (e.g. "us-west1") that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for CertificateAuthorityService.ListCertificateRevocationLists.</summary>
    public class ListCertificateRevocationListsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of CertificateRevocationLists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateRevocationLists")]
        public virtual System.Collections.Generic.IList<CertificateRevocationList> CertificateRevocationLists { get; set; }

        /// <summary>
        /// A token to retrieve next page of results. Pass this value in
        /// ListCertificateRevocationListsRequest.next_page_token to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of locations (e.g. "us-west1") that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for CertificateAuthorityService.ListCertificates.</summary>
    public class ListCertificatesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Certificates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificates")]
        public virtual System.Collections.Generic.IList<Certificate> Certificates { get; set; }

        /// <summary>
        /// A token to retrieve next page of results. Pass this value in ListCertificatesRequest.next_page_token to
        /// retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of locations (e.g. "us-west1") that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Locations.ListLocations.</summary>
    public class ListLocationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of locations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<Location> Locations { get; set; }

        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Operations.ListOperations.</summary>
    public class ListOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of operations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<Operation> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for CertificateAuthorityService.ListReusableConfigs.</summary>
    public class ListReusableConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token to retrieve next page of results. Pass this value in ListReusableConfigsRequest.next_page_token to
        /// retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of ReusableConfigs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reusableConfigs")]
        public virtual System.Collections.Generic.IList<ReusableConfig> ReusableConfigs { get; set; }

        /// <summary>A list of locations (e.g. "us-west1") that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that represents Google Cloud Platform location.</summary>
    public class Location : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The friendly name for this location, typically a nearby city name. For example, "Tokyo".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Cross-service attributes for the location. For example {"cloud.googleapis.com/region": "us-east1"}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The canonical id for this location. For example: `"us-east1"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>Service-specific metadata. For example the available capacity at the given location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// Resource name for the location, which may vary between implementations. For example:
        /// `"projects/example-project/locations/us-east1"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

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

    /// <summary>
    /// An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.
    /// </summary>
    public class ObjectId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectIdPath")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> ObjectIdPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is `false`, it means the operation is still in progress. If `true`, the operation is completed,
        /// and either `error` or `response` is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

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

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>Output only. The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Output only. Identifies whether the user has requested cancellation of the operation. Operations that have
        /// successfully been cancelled have Operation.error value with a google.rpc.Status.code of 1, corresponding to
        /// `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedCancellation")]
        public virtual System.Nullable<bool> RequestedCancellation { get; set; }

        /// <summary>Output only. Human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>Output only. Server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Output only. Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

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

    /// <summary>A PublicKey describes a public key.</summary>
    public class PublicKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A public key. When this is specified in a request, the padding and encoding can be any of the
        /// options described by the respective 'KeyType' value. When this is generated by the service, it will always
        /// be an RFC 5280 [SubjectPublicKeyInfo](https://tools.ietf.org/html/rfc5280#section-4.1) structure containing
        /// an algorithm identifier and a key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// Optional. The type of public key. If specified, it must match the public key used for the`key` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CertificateAuthorityService.RestoreCertificateAuthority.</summary>
    public class RestoreCertificateAuthorityRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry your request,
        /// the server will know to ignore the request if it has already been completed. The server will guarantee that
        /// for at least 60 minutes since the first request. For example, consider a situation where you make an initial
        /// request and t he request times out. If you make the request again with the same request ID, the server can
        /// check if original operation with the same request ID was received, and if so, will ignore the second
        /// request. This prevents clients from accidentally creating duplicate commitments. The request ID must be a
        /// valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A ReusableConfig refers to a managed ReusableConfigValues. Those, in turn, are used to describe certain fields
    /// of an X.509 certificate, such as the key usage fields, fields specific to CA certificates, certificate policy
    /// extensions and custom extensions.
    /// </summary>
    public class ReusableConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time at which this ReusableConfig was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Optional. A human-readable description of scenarios these ReusableConfigValues may be compatible with.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. Labels with user-defined metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. The resource path for this ReusableConfig in the format
        /// `projects/*/locations/*/reusableConfigs/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The time at which this ReusableConfig was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>Required. The config values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual ReusableConfigValues Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A ReusableConfigValues is used to describe certain fields of an X.509 certificate, such as the key usage fields,
    /// fields specific to CA certificates, certificate policy extensions and custom extensions.
    /// </summary>
    public class ReusableConfigValues : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Describes custom X.509 extensions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalExtensions")]
        public virtual System.Collections.Generic.IList<X509Extension> AdditionalExtensions { get; set; }

        /// <summary>
        /// Optional. Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the
        /// "Authority Information Access" extension in the certificate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aiaOcspServers")]
        public virtual System.Collections.Generic.IList<string> AiaOcspServers { get; set; }

        /// <summary>
        /// Optional. Describes options in this ReusableConfigValues that are relevant in a CA certificate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caOptions")]
        public virtual CaOptions CaOptions { get; set; }

        /// <summary>Optional. Indicates the intended use for keys that correspond to a certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyUsage")]
        public virtual KeyUsage KeyUsage { get; set; }

        /// <summary>
        /// Optional. Describes the X.509 certificate policy object identifiers, per
        /// https://tools.ietf.org/html/rfc5280#section-4.2.1.4.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyIds")]
        public virtual System.Collections.Generic.IList<ObjectId> PolicyIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A ReusableConfigWrapper describes values that may assist in creating an X.509 certificate, or a reference to a
    /// pre-defined set of values.
    /// </summary>
    public class ReusableConfigWrapper : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A resource path to a ReusableConfig in the format `projects/*/locations/*/reusableConfigs/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reusableConfig")]
        public virtual string ReusableConfig { get; set; }

        /// <summary>Required. A user-specified inline ReusableConfigValues.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reusableConfigValues")]
        public virtual ReusableConfigValues ReusableConfigValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes fields that are relavent to the revocation of a Certificate.</summary>
    public class RevocationDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates why a Certificate was revoked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revocationState")]
        public virtual string RevocationState { get; set; }

        /// <summary>The time at which this Certificate was revoked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revocationTime")]
        public virtual object RevocationTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CertificateAuthorityService.RevokeCertificate.</summary>
    public class RevokeCertificateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The RevocationReason for revoking this certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>
        /// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry your request,
        /// the server will know to ignore the request if it has already been completed. The server will guarantee that
        /// for at least 60 minutes since the first request. For example, consider a situation where you make an initial
        /// request and t he request times out. If you make the request again with the same request ID, the server can
        /// check if original operation with the same request ID was received, and if so, will ignore the second
        /// request. This prevents clients from accidentally creating duplicate commitments. The request ID must be a
        /// valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a revoked Certificate.</summary>
    public class RevokedCertificate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource path for the Certificate in the format
        /// `projects/*/locations/*/certificateAuthorities/*/certificates/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificate")]
        public virtual string Certificate { get; set; }

        /// <summary>The serial number of the Certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hexSerialNumber")]
        public virtual string HexSerialNumber { get; set; }

        /// <summary>The reason the Certificate was revoked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revocationReason")]
        public virtual string RevocationReason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CertificateAuthorityService.ScheduleDeleteCertificateAuthority.</summary>
    public class ScheduleDeleteCertificateAuthorityRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. This field allows the CA to be scheduled for deletion even if the CA has active certs. Active
        /// certs include both unrevoked and unexpired certs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreActiveCertificates")]
        public virtual System.Nullable<bool> IgnoreActiveCertificates { get; set; }

        /// <summary>
        /// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry your request,
        /// the server will know to ignore the request if it has already been completed. The server will guarantee that
        /// for at least 60 minutes since the first request. For example, consider a situation where you make an initial
        /// request and t he request times out. If you make the request again with the same request ID, the server can
        /// check if original operation with the same request ID was received, and if so, will ignore the second
        /// request. This prevents clients from accidentally creating duplicate commitments. The request ID must be a
        /// valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

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
        public virtual Policy Policy { get; set; }

        /// <summary>
        /// OPTIONAL: A FieldMask specifying which fields of the policy to modify. Only the fields in the mask will be
        /// modified. If no mask is provided, the following default mask is used: `paths: "bindings, etag"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
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
    /// Subject describes parts of a distinguished name that, in turn, describes the subject of the certificate.
    /// </summary>
    public class Subject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The country code of the subject.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryCode")]
        public virtual string CountryCode { get; set; }

        /// <summary>The locality or city of the subject.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locality")]
        public virtual string Locality { get; set; }

        /// <summary>The organization of the subject.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual string Organization { get; set; }

        /// <summary>The organizational_unit of the subject.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organizationalUnit")]
        public virtual string OrganizationalUnit { get; set; }

        /// <summary>The postal code of the subject.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; }

        /// <summary>The province, territory, or regional state of the subject.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("province")]
        public virtual string Province { get; set; }

        /// <summary>The street address of the subject.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streetAddress")]
        public virtual string StreetAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// SubjectAltNames corresponds to a more modern way of listing what the asserted identity is in a certificate
    /// (i.e., compared to the "common name" in the distinguished name).
    /// </summary>
    public class SubjectAltNames : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contains additional subject alternative name values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customSans")]
        public virtual System.Collections.Generic.IList<X509Extension> CustomSans { get; set; }

        /// <summary>Contains only valid, fully-qualified host names.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsNames")]
        public virtual System.Collections.Generic.IList<string> DnsNames { get; set; }

        /// <summary>Contains only valid RFC 2822 E-mail addresses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddresses")]
        public virtual System.Collections.Generic.IList<string> EmailAddresses { get; set; }

        /// <summary>Contains only valid 32-bit IPv4 addresses or RFC 4291 IPv6 addresses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddresses")]
        public virtual System.Collections.Generic.IList<string> IpAddresses { get; set; }

        /// <summary>Contains only valid RFC 3986 URIs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uris")]
        public virtual System.Collections.Generic.IList<string> Uris { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// These values are used to create the distinguished name and subject alternative name fields in an X.509
    /// certificate.
    /// </summary>
    public class SubjectConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The "common name" of the distinguished name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonName")]
        public virtual string CommonName { get; set; }

        /// <summary>Required. Contains distinguished name fields such as the location and organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subject")]
        public virtual Subject Subject { get; set; }

        /// <summary>Optional. The subject alternative name fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subjectAltName")]
        public virtual SubjectAltNames SubjectAltName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// These values describe fields in an issued X.509 certificate such as the distinguished name, subject alternative
    /// names, serial number, and lifetime.
    /// </summary>
    public class SubjectDescription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The "common name" of the distinguished name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonName")]
        public virtual string CommonName { get; set; }

        /// <summary>The serial number encoded in lowercase hexadecimal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hexSerialNumber")]
        public virtual string HexSerialNumber { get; set; }

        /// <summary>
        /// For convenience, the actual lifetime of an issued certificate. Corresponds to 'not_after_time' -
        /// 'not_before_time'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifetime")]
        public virtual object Lifetime { get; set; }

        /// <summary>The time at which the certificate expires.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notAfterTime")]
        public virtual object NotAfterTime { get; set; }

        /// <summary>The time at which the certificate becomes valid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notBeforeTime")]
        public virtual object NotBeforeTime { get; set; }

        /// <summary>Contains distinguished name fields such as the location and organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subject")]
        public virtual Subject Subject { get; set; }

        /// <summary>The subject alternative name fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subjectAltName")]
        public virtual SubjectAltNames SubjectAltName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes a subordinate CA's issuers. This is either a resource path to a known issuing CertificateAuthority, or
    /// a PEM issuer certificate chain.
    /// </summary>
    public class SubordinateConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. This can refer to a CertificateAuthority in the same project that was used to create a subordinate
        /// CertificateAuthority. This field is used for information and usability purposes only. The resource name is
        /// in the format `projects/*/locations/*/certificateAuthorities/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateAuthority")]
        public virtual string CertificateAuthority { get; set; }

        /// <summary>
        /// Required. Contains the PEM certificate chain for the issuers of this CertificateAuthority, but not pem
        /// certificate for this CA itself.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pemIssuerChain")]
        public virtual SubordinateConfigChain PemIssuerChain { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This message describes a subordinate CA's issuer certificate chain. This wrapper exists for compatibility
    /// reasons.
    /// </summary>
    public class SubordinateConfigChain : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Expected to be in leaf-to-root order according to RFC 5246.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pemCertificates")]
        public virtual System.Collections.Generic.IList<string> PemCertificates { get; set; }

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
    /// An X509Extension specifies an X.509 extension, which may be used in different parts of X.509 objects like
    /// certificates, CSRs, and CRLs.
    /// </summary>
    public class X509Extension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Indicates whether or not this extension is critical (i.e., if the client does not know how to
        /// handle this extension, the client should consider this to be an error).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("critical")]
        public virtual System.Nullable<bool> Critical { get; set; }

        /// <summary>Required. The OID for this X.509 extension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual ObjectId ObjectId { get; set; }

        /// <summary>Required. The value of this X.509 extension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
