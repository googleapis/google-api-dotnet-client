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

namespace Google.Apis.CertificateAuthorityService.v1
{
    /// <summary>The CertificateAuthorityService Service.</summary>
    public class CertificateAuthorityServiceService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

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
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://privateca.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://privateca.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "privateca";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Certificate Authority API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Certificate Authority API.</summary>
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
                CaPools = new CaPoolsResource(service);
                CertificateTemplates = new CertificateTemplatesResource(service);
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the CaPools resource.</summary>
            public virtual CaPoolsResource CaPools { get; }

            /// <summary>The "caPools" collection of methods.</summary>
            public class CaPoolsResource
            {
                private const string Resource = "caPools";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public CaPoolsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    CertificateAuthorities = new CertificateAuthoritiesResource(service);
                    Certificates = new CertificatesResource(service);
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
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>Returns a CertificateRevocationList.</summary>
                        public class GetRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.CertificateRevocationList>
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+/certificateAuthorities/[^/]+/certificateRevocationLists/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Gets the access control policy for a resource. Returns an empty policy if the resource
                        /// exists and does not have a policy set.
                        /// </summary>
                        /// <param name="resource">
                        /// REQUIRED: The resource for which the policy is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </param>
                        public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                        {
                            return new GetIamPolicyRequest(this.service, resource);
                        }

                        /// <summary>
                        /// Gets the access control policy for a resource. Returns an empty policy if the resource
                        /// exists and does not have a policy set.
                        /// </summary>
                        public class GetIamPolicyRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Policy>
                        {
                            /// <summary>Constructs a new GetIamPolicy request.</summary>
                            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                            {
                                Resource = resource;
                                InitParameters();
                            }

                            /// <summary>
                            /// REQUIRED: The resource for which the policy is being requested. See [Resource
                            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value
                            /// for this field.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Resource { get; private set; }

                            /// <summary>
                            /// Optional. The maximum policy version that will be used to format the policy. Valid
                            /// values are 0, 1, and 3. Requests specifying an invalid value will be rejected. Requests
                            /// for policies with any conditional role bindings must specify version 3. Policies with no
                            /// conditional role bindings may specify any valid value or leave the field unset. The
                            /// policy in the response might use the policy version that you specified, or it might use
                            /// a lower policy version. For example, if you specify version 3, but the policy has no
                            /// conditional role bindings, the response uses version 1. To learn which resources support
                            /// conditions in their IAM policies, see the [IAM
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+/certificateAuthorities/[^/]+/certificateRevocationLists/[^/]+$",
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
                        /// Required. The resource name of the location associated with the CertificateRevocationLists,
                        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>Lists CertificateRevocationLists.</summary>
                        public class ListRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.ListCertificateRevocationListsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the location associated with the
                            /// CertificateRevocationLists, in the format
                            /// `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. Only include resources that match the filter in the response.
                            /// </summary>
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
                            public override string RestPath => "v1/{+parent}/certificateRevocationLists";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+/certificateAuthorities/[^/]+$",
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
                        /// Identifier. The resource name for this CertificateRevocationList in the format
                        /// `projects/*/locations/*/caPools/*certificateAuthorities/*/ certificateRevocationLists/*`.
                        /// </param>
                        public virtual PatchRequest Patch(Google.Apis.CertificateAuthorityService.v1.Data.CertificateRevocationList body, string name)
                        {
                            return new PatchRequest(this.service, body, name);
                        }

                        /// <summary>Update a CertificateRevocationList.</summary>
                        public class PatchRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Operation>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1.Data.CertificateRevocationList body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Identifier. The resource name for this CertificateRevocationList in the format
                            /// `projects/*/locations/*/caPools/*certificateAuthorities/*/
                            /// certificateRevocationLists/*`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// Optional. An ID to identify requests. Specify a unique request ID so that if you must
                            /// retry your request, the server will know to ignore the request if it has already been
                            /// completed. The server will guarantee that for at least 60 minutes since the first
                            /// request. For example, consider a situation where you make an initial request and the
                            /// request times out. If you make the request again with the same request ID, the server
                            /// can check if original operation with the same request ID was received, and if so, will
                            /// ignore the second request. This prevents clients from accidentally creating duplicate
                            /// commitments. The request ID must be a valid UUID with the exception that zero UUID is
                            /// not supported (00000000-0000-0000-0000-000000000000).
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string RequestId { get; set; }

                            /// <summary>Required. A list of fields to be updated in this request.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CertificateAuthorityService.v1.Data.CertificateRevocationList Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "patch";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "PATCH";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+/certificateAuthorities/[^/]+/certificateRevocationLists/[^/]+$",
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
                        /// REQUIRED: The resource for which the policy is being specified. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </param>
                        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CertificateAuthorityService.v1.Data.SetIamPolicyRequest body, string resource)
                        {
                            return new SetIamPolicyRequest(this.service, body, resource);
                        }

                        /// <summary>
                        /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                        /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                        /// </summary>
                        public class SetIamPolicyRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Policy>
                        {
                            /// <summary>Constructs a new SetIamPolicy request.</summary>
                            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                            {
                                Resource = resource;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// REQUIRED: The resource for which the policy is being specified. See [Resource
                            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value
                            /// for this field.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Resource { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CertificateAuthorityService.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+/certificateAuthorities/[^/]+/certificateRevocationLists/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Returns permissions that a caller has on the specified resource. If the resource does not
                        /// exist, this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This
                        /// operation is designed to be used for building permission-aware UIs and command-line tools,
                        /// not for authorization checking. This operation may "fail open" without warning.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="resource">
                        /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </param>
                        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CertificateAuthorityService.v1.Data.TestIamPermissionsRequest body, string resource)
                        {
                            return new TestIamPermissionsRequest(this.service, body, resource);
                        }

                        /// <summary>
                        /// Returns permissions that a caller has on the specified resource. If the resource does not
                        /// exist, this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This
                        /// operation is designed to be used for building permission-aware UIs and command-line tools,
                        /// not for authorization checking. This operation may "fail open" without warning.
                        /// </summary>
                        public class TestIamPermissionsRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.TestIamPermissionsResponse>
                        {
                            /// <summary>Constructs a new TestIamPermissions request.</summary>
                            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                            {
                                Resource = resource;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value
                            /// for this field.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Resource { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CertificateAuthorityService.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+/certificateAuthorities/[^/]+/certificateRevocationLists/[^/]+$",
                                });
                            }
                        }
                    }

                    /// <summary>
                    /// Activate a CertificateAuthority that is in state AWAITING_USER_ACTIVATION and is of type
                    /// SUBORDINATE. After the parent Certificate Authority signs a certificate signing request from
                    /// FetchCertificateAuthorityCsr, this method can complete the activation process.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource name for this CertificateAuthority in the format
                    /// `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
                    /// </param>
                    public virtual ActivateRequest Activate(Google.Apis.CertificateAuthorityService.v1.Data.ActivateCertificateAuthorityRequest body, string name)
                    {
                        return new ActivateRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Activate a CertificateAuthority that is in state AWAITING_USER_ACTIVATION and is of type
                    /// SUBORDINATE. After the parent Certificate Authority signs a certificate signing request from
                    /// FetchCertificateAuthorityCsr, this method can complete the activation process.
                    /// </summary>
                    public class ActivateRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Activate request.</summary>
                        public ActivateRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1.Data.ActivateCertificateAuthorityRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name for this CertificateAuthority in the format
                        /// `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CertificateAuthorityService.v1.Data.ActivateCertificateAuthorityRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "activate";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:activate";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+/certificateAuthorities/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Create a new CertificateAuthority in a given Project and Location.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The resource name of the CaPool associated with the CertificateAuthorities, in the
                    /// format `projects/*/locations/*/caPools/*`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.CertificateAuthorityService.v1.Data.CertificateAuthority body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Create a new CertificateAuthority in a given Project and Location.</summary>
                    public class CreateRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1.Data.CertificateAuthority body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the CaPool associated with the CertificateAuthorities, in the
                        /// format `projects/*/locations/*/caPools/*`.
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
                        /// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry
                        /// your request, the server will know to ignore the request if it has already been completed.
                        /// The server will guarantee that for at least 60 minutes since the first request. For example,
                        /// consider a situation where you make an initial request and the request times out. If you
                        /// make the request again with the same request ID, the server can check if original operation
                        /// with the same request ID was received, and if so, will ignore the second request. This
                        /// prevents clients from accidentally creating duplicate commitments. The request ID must be a
                        /// valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CertificateAuthorityService.v1.Data.CertificateAuthority Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/certificateAuthorities";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+$",
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

                    /// <summary>Delete a CertificateAuthority.</summary>
                    /// <param name="name">
                    /// Required. The resource name for this CertificateAuthority in the format
                    /// `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Delete a CertificateAuthority.</summary>
                    public class DeleteRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name for this CertificateAuthority in the format
                        /// `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. This field allows the CA to be deleted even if the CA has active certs. Active
                        /// certs include both unrevoked and unexpired certs.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("ignoreActiveCertificates", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> IgnoreActiveCertificates { get; set; }

                        /// <summary>
                        /// Optional. This field allows this CA to be deleted even if it's being depended on by another
                        /// resource. However, doing so may result in unintended and unrecoverable effects on any
                        /// dependent resources since the CA will no longer be able to issue certificates.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("ignoreDependentResources", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> IgnoreDependentResources { get; set; }

                        /// <summary>
                        /// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry
                        /// your request, the server will know to ignore the request if it has already been completed.
                        /// The server will guarantee that for at least 60 minutes since the first request. For example,
                        /// consider a situation where you make an initial request and the request times out. If you
                        /// make the request again with the same request ID, the server can check if original operation
                        /// with the same request ID was received, and if so, will ignore the second request. This
                        /// prevents clients from accidentally creating duplicate commitments. The request ID must be a
                        /// valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>
                        /// Optional. If this flag is set, the Certificate Authority will be deleted as soon as possible
                        /// without a 30-day grace period where undeletion would have been allowed. If you proceed,
                        /// there will be no way to recover this CA.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("skipGracePeriod", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> SkipGracePeriod { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+/certificateAuthorities/[^/]+$",
                            });
                            RequestParameters.Add("ignoreActiveCertificates", new Google.Apis.Discovery.Parameter
                            {
                                Name = "ignoreActiveCertificates",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("ignoreDependentResources", new Google.Apis.Discovery.Parameter
                            {
                                Name = "ignoreDependentResources",
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
                            RequestParameters.Add("skipGracePeriod", new Google.Apis.Discovery.Parameter
                            {
                                Name = "skipGracePeriod",
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
                    /// `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
                    /// </param>
                    public virtual DisableRequest Disable(Google.Apis.CertificateAuthorityService.v1.Data.DisableCertificateAuthorityRequest body, string name)
                    {
                        return new DisableRequest(this.service, body, name);
                    }

                    /// <summary>Disable a CertificateAuthority.</summary>
                    public class DisableRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Disable request.</summary>
                        public DisableRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1.Data.DisableCertificateAuthorityRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name for this CertificateAuthority in the format
                        /// `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CertificateAuthorityService.v1.Data.DisableCertificateAuthorityRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "disable";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:disable";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+/certificateAuthorities/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Enable a CertificateAuthority.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource name for this CertificateAuthority in the format
                    /// `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
                    /// </param>
                    public virtual EnableRequest Enable(Google.Apis.CertificateAuthorityService.v1.Data.EnableCertificateAuthorityRequest body, string name)
                    {
                        return new EnableRequest(this.service, body, name);
                    }

                    /// <summary>Enable a CertificateAuthority.</summary>
                    public class EnableRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Enable request.</summary>
                        public EnableRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1.Data.EnableCertificateAuthorityRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name for this CertificateAuthority in the format
                        /// `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CertificateAuthorityService.v1.Data.EnableCertificateAuthorityRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "enable";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:enable";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+/certificateAuthorities/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Fetch a certificate signing request (CSR) from a CertificateAuthority that is in state
                    /// AWAITING_USER_ACTIVATION and is of type SUBORDINATE. The CSR must then be signed by the desired
                    /// parent Certificate Authority, which could be another CertificateAuthority resource, or could be
                    /// an on-prem certificate authority. See also ActivateCertificateAuthority.
                    /// </summary>
                    /// <param name="name">
                    /// Required. The resource name for this CertificateAuthority in the format
                    /// `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
                    /// </param>
                    public virtual FetchRequest Fetch(string name)
                    {
                        return new FetchRequest(this.service, name);
                    }

                    /// <summary>
                    /// Fetch a certificate signing request (CSR) from a CertificateAuthority that is in state
                    /// AWAITING_USER_ACTIVATION and is of type SUBORDINATE. The CSR must then be signed by the desired
                    /// parent Certificate Authority, which could be another CertificateAuthority resource, or could be
                    /// an on-prem certificate authority. See also ActivateCertificateAuthority.
                    /// </summary>
                    public class FetchRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.FetchCertificateAuthorityCsrResponse>
                    {
                        /// <summary>Constructs a new Fetch request.</summary>
                        public FetchRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name for this CertificateAuthority in the format
                        /// `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "fetch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:fetch";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+/certificateAuthorities/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns a CertificateAuthority.</summary>
                    /// <param name="name">Required. The name of the CertificateAuthority to get.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Returns a CertificateAuthority.</summary>
                    public class GetRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.CertificateAuthority>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+/certificateAuthorities/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists CertificateAuthorities.</summary>
                    /// <param name="parent">
                    /// Required. The resource name of the CaPool associated with the CertificateAuthorities, in the
                    /// format `projects/*/locations/*/caPools/*`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists CertificateAuthorities.</summary>
                    public class ListRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.ListCertificateAuthoritiesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the CaPool associated with the CertificateAuthorities, in the
                        /// format `projects/*/locations/*/caPools/*`.
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
                        /// ListCertificateAuthoritiesResponse.next_page_token in a subsequent request. If unspecified,
                        /// the server will pick an appropriate default.
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
                        public override string RestPath => "v1/{+parent}/certificateAuthorities";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+$",
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
                    /// Identifier. The resource name for this CertificateAuthority in the format
                    /// `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CertificateAuthorityService.v1.Data.CertificateAuthority body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Update a CertificateAuthority.</summary>
                    public class PatchRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1.Data.CertificateAuthority body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. The resource name for this CertificateAuthority in the format
                        /// `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry
                        /// your request, the server will know to ignore the request if it has already been completed.
                        /// The server will guarantee that for at least 60 minutes since the first request. For example,
                        /// consider a situation where you make an initial request and the request times out. If you
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
                        Google.Apis.CertificateAuthorityService.v1.Data.CertificateAuthority Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+/certificateAuthorities/[^/]+$",
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

                    /// <summary>Undelete a CertificateAuthority that has been deleted.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource name for this CertificateAuthority in the format
                    /// `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
                    /// </param>
                    public virtual UndeleteRequest Undelete(Google.Apis.CertificateAuthorityService.v1.Data.UndeleteCertificateAuthorityRequest body, string name)
                    {
                        return new UndeleteRequest(this.service, body, name);
                    }

                    /// <summary>Undelete a CertificateAuthority that has been deleted.</summary>
                    public class UndeleteRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Undelete request.</summary>
                        public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1.Data.UndeleteCertificateAuthorityRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name for this CertificateAuthority in the format
                        /// `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CertificateAuthorityService.v1.Data.UndeleteCertificateAuthorityRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "undelete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:undelete";

                        /// <summary>Initializes Undelete parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+/certificateAuthorities/[^/]+$",
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
                    /// Create a new Certificate in a given Project, Location from a particular CaPool.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The resource name of the CaPool associated with the Certificate, in the format
                    /// `projects/*/locations/*/caPools/*`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.CertificateAuthorityService.v1.Data.Certificate body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Create a new Certificate in a given Project, Location from a particular CaPool.
                    /// </summary>
                    public class CreateRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Certificate>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1.Data.Certificate body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the CaPool associated with the Certificate, in the format
                        /// `projects/*/locations/*/caPools/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. It must be unique within a location and match the regular expression
                        /// `[a-zA-Z0-9_-]{1,63}`. This field is required when using a CertificateAuthority in the
                        /// Enterprise CertificateAuthority.tier, but is optional and its value is ignored otherwise.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("certificateId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string CertificateId { get; set; }

                        /// <summary>
                        /// Optional. The resource ID of the CertificateAuthority that should issue the certificate.
                        /// This optional field will ignore the load-balancing scheme of the Pool and directly issue the
                        /// certificate from the CA with the specified ID, contained in the same CaPool referenced by
                        /// `parent`. Per-CA quota rules apply. If left empty, a CertificateAuthority will be chosen
                        /// from the CaPool by the service. For example, to issue a Certificate from a Certificate
                        /// Authority with resource name
                        /// "projects/my-project/locations/us-central1/caPools/my-pool/certificateAuthorities/my-ca",
                        /// you can set the parent to "projects/my-project/locations/us-central1/caPools/my-pool" and
                        /// the issuing_certificate_authority_id to "my-ca".
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("issuingCertificateAuthorityId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string IssuingCertificateAuthorityId { get; set; }

                        /// <summary>
                        /// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry
                        /// your request, the server will know to ignore the request if it has already been completed.
                        /// The server will guarantee that for at least 60 minutes since the first request. For example,
                        /// consider a situation where you make an initial request and the request times out. If you
                        /// make the request again with the same request ID, the server can check if original operation
                        /// with the same request ID was received, and if so, will ignore the second request. This
                        /// prevents clients from accidentally creating duplicate commitments. The request ID must be a
                        /// valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>
                        /// Optional. If this is true, no Certificate resource will be persisted regardless of the
                        /// CaPool's tier, and the returned Certificate will not contain the pem_certificate field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CertificateAuthorityService.v1.Data.Certificate Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/certificates";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+$",
                            });
                            RequestParameters.Add("certificateId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "certificateId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("issuingCertificateAuthorityId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "issuingCertificateAuthorityId",
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
                            RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                            {
                                Name = "validateOnly",
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
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Returns a Certificate.</summary>
                    public class GetRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Certificate>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+/certificates/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists Certificates.</summary>
                    /// <param name="parent">
                    /// Required. The resource name of the location associated with the Certificates, in the format
                    /// `projects/*/locations/*/caPools/*`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists Certificates.</summary>
                    public class ListRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.ListCertificatesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the location associated with the Certificates, in the format
                        /// `projects/*/locations/*/caPools/*`.
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
                        public override string RestPath => "v1/{+parent}/certificates";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+$",
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
                    /// Identifier. The resource name for this Certificate in the format
                    /// `projects/*/locations/*/caPools/*/certificates/*`.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CertificateAuthorityService.v1.Data.Certificate body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Update a Certificate. Currently, the only field you can update is the labels field.
                    /// </summary>
                    public class PatchRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Certificate>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1.Data.Certificate body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. The resource name for this Certificate in the format
                        /// `projects/*/locations/*/caPools/*/certificates/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry
                        /// your request, the server will know to ignore the request if it has already been completed.
                        /// The server will guarantee that for at least 60 minutes since the first request. For example,
                        /// consider a situation where you make an initial request and the request times out. If you
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
                        Google.Apis.CertificateAuthorityService.v1.Data.Certificate Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+/certificates/[^/]+$",
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
                    /// `projects/*/locations/*/caPools/*/certificates/*`.
                    /// </param>
                    public virtual RevokeRequest Revoke(Google.Apis.CertificateAuthorityService.v1.Data.RevokeCertificateRequest body, string name)
                    {
                        return new RevokeRequest(this.service, body, name);
                    }

                    /// <summary>Revoke a Certificate.</summary>
                    public class RevokeRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Certificate>
                    {
                        /// <summary>Constructs a new Revoke request.</summary>
                        public RevokeRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1.Data.RevokeCertificateRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name for this Certificate in the format
                        /// `projects/*/locations/*/caPools/*/certificates/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CertificateAuthorityService.v1.Data.RevokeCertificateRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "revoke";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:revoke";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+/certificates/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Create a CaPool.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource name of the location associated with the CaPool, in the format
                /// `projects/*/locations/*`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CertificateAuthorityService.v1.Data.CaPool body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Create a CaPool.</summary>
                public class CreateRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1.Data.CaPool body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the location associated with the CaPool, in the format
                    /// `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. It must be unique within a location and match the regular expression
                    /// `[a-zA-Z0-9_-]{1,63}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("caPoolId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string CaPoolId { get; set; }

                    /// <summary>
                    /// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry your
                    /// request, the server will know to ignore the request if it has already been completed. The server
                    /// will guarantee that for at least 60 minutes since the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server can check if original operation with the same request
                    /// ID was received, and if so, will ignore the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CertificateAuthorityService.v1.Data.CaPool Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/caPools";

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
                        RequestParameters.Add("caPoolId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "caPoolId",
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

                /// <summary>Delete a CaPool.</summary>
                /// <param name="name">
                /// Required. The resource name for this CaPool in the format `projects/*/locations/*/caPools/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Delete a CaPool.</summary>
                public class DeleteRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name for this CaPool in the format `projects/*/locations/*/caPools/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. This field allows this pool to be deleted even if it's being depended on by another
                    /// resource. However, doing so may result in unintended and unrecoverable effects on any dependent
                    /// resources since the pool will no longer be able to issue certificates.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("ignoreDependentResources", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> IgnoreDependentResources { get; set; }

                    /// <summary>
                    /// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry your
                    /// request, the server will know to ignore the request if it has already been completed. The server
                    /// will guarantee that for at least 60 minutes since the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server can check if original operation with the same request
                    /// ID was received, and if so, will ignore the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+$",
                        });
                        RequestParameters.Add("ignoreDependentResources", new Google.Apis.Discovery.Parameter
                        {
                            Name = "ignoreDependentResources",
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

                /// <summary>
                /// FetchCaCerts returns the current trust anchor for the CaPool. This will include CA certificate
                /// chains for all certificate authorities in the ENABLED, DISABLED, or STAGED states.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="caPool">
                /// Required. The resource name for the CaPool in the format `projects/*/locations/*/caPools/*`.
                /// </param>
                public virtual FetchCaCertsRequest FetchCaCerts(Google.Apis.CertificateAuthorityService.v1.Data.FetchCaCertsRequest body, string caPool)
                {
                    return new FetchCaCertsRequest(this.service, body, caPool);
                }

                /// <summary>
                /// FetchCaCerts returns the current trust anchor for the CaPool. This will include CA certificate
                /// chains for all certificate authorities in the ENABLED, DISABLED, or STAGED states.
                /// </summary>
                public class FetchCaCertsRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.FetchCaCertsResponse>
                {
                    /// <summary>Constructs a new FetchCaCerts request.</summary>
                    public FetchCaCertsRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1.Data.FetchCaCertsRequest body, string caPool) : base(service)
                    {
                        CaPool = caPool;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name for the CaPool in the format `projects/*/locations/*/caPools/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("caPool", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string CaPool { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CertificateAuthorityService.v1.Data.FetchCaCertsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "fetchCaCerts";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+caPool}:fetchCaCerts";

                    /// <summary>Initializes FetchCaCerts parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("caPool", new Google.Apis.Discovery.Parameter
                        {
                            Name = "caPool",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns a CaPool.</summary>
                /// <param name="name">Required. The name of the CaPool to get.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Returns a CaPool.</summary>
                public class GetRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.CaPool>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the CaPool to get.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(this.service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Policy>
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
                    /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0,
                    /// 1, and 3. Requests specifying an invalid value will be rejected. Requests for policies with any
                    /// conditional role bindings must specify version 3. Policies with no conditional role bindings may
                    /// specify any valid value or leave the field unset. The policy in the response might use the
                    /// policy version that you specified, or it might use a lower policy version. For example, if you
                    /// specify version 3, but the policy has no conditional role bindings, the response uses version 1.
                    /// To learn which resources support conditions in their IAM policies, see the [IAM
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+$",
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

                /// <summary>Lists CaPools.</summary>
                /// <param name="parent">
                /// Required. The resource name of the location associated with the CaPools, in the format
                /// `projects/*/locations/*`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists CaPools.</summary>
                public class ListRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.ListCaPoolsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the location associated with the CaPools, in the format
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
                    /// Optional. Limit on the number of CaPools to include in the response. Further CaPools can
                    /// subsequently be obtained by including the ListCaPoolsResponse.next_page_token in a subsequent
                    /// request. If unspecified, the server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. Pagination token, returned earlier via ListCaPoolsResponse.next_page_token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/caPools";

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

                /// <summary>Update a CaPool.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The resource name for this CaPool in the format `projects/*/locations/*/caPools/*`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CertificateAuthorityService.v1.Data.CaPool body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Update a CaPool.</summary>
                public class PatchRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1.Data.CaPool body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The resource name for this CaPool in the format `projects/*/locations/*/caPools/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry your
                    /// request, the server will know to ignore the request if it has already been completed. The server
                    /// will guarantee that for at least 60 minutes since the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
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
                    Google.Apis.CertificateAuthorityService.v1.Data.CaPool Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+$",
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
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CertificateAuthorityService.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.CertificateAuthorityService.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+$",
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
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CertificateAuthorityService.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.CertificateAuthorityService.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/caPools/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the CertificateTemplates resource.</summary>
            public virtual CertificateTemplatesResource CertificateTemplates { get; }

            /// <summary>The "certificateTemplates" collection of methods.</summary>
            public class CertificateTemplatesResource
            {
                private const string Resource = "certificateTemplates";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public CertificateTemplatesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Create a new CertificateTemplate in a given Project and Location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource name of the location associated with the CertificateTemplate, in the format
                /// `projects/*/locations/*`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CertificateAuthorityService.v1.Data.CertificateTemplate body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Create a new CertificateTemplate in a given Project and Location.</summary>
                public class CreateRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1.Data.CertificateTemplate body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the location associated with the CertificateTemplate, in the
                    /// format `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. It must be unique within a location and match the regular expression
                    /// `[a-zA-Z0-9_-]{1,63}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("certificateTemplateId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string CertificateTemplateId { get; set; }

                    /// <summary>
                    /// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry your
                    /// request, the server will know to ignore the request if it has already been completed. The server
                    /// will guarantee that for at least 60 minutes since the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server can check if original operation with the same request
                    /// ID was received, and if so, will ignore the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CertificateAuthorityService.v1.Data.CertificateTemplate Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/certificateTemplates";

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
                        RequestParameters.Add("certificateTemplateId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "certificateTemplateId",
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

                /// <summary>DeleteCertificateTemplate deletes a CertificateTemplate.</summary>
                /// <param name="name">
                /// Required. The resource name for this CertificateTemplate in the format
                /// `projects/*/locations/*/certificateTemplates/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>DeleteCertificateTemplate deletes a CertificateTemplate.</summary>
                public class DeleteRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name for this CertificateTemplate in the format
                    /// `projects/*/locations/*/certificateTemplates/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry your
                    /// request, the server will know to ignore the request if it has already been completed. The server
                    /// will guarantee that for at least 60 minutes since the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server can check if original operation with the same request
                    /// ID was received, and if so, will ignore the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/certificateTemplates/[^/]+$",
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

                /// <summary>Returns a CertificateTemplate.</summary>
                /// <param name="name">Required. The name of the CertificateTemplate to get.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Returns a CertificateTemplate.</summary>
                public class GetRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.CertificateTemplate>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the CertificateTemplate to get.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/certificateTemplates/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(this.service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Policy>
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
                    /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0,
                    /// 1, and 3. Requests specifying an invalid value will be rejected. Requests for policies with any
                    /// conditional role bindings must specify version 3. Policies with no conditional role bindings may
                    /// specify any valid value or leave the field unset. The policy in the response might use the
                    /// policy version that you specified, or it might use a lower policy version. For example, if you
                    /// specify version 3, but the policy has no conditional role bindings, the response uses version 1.
                    /// To learn which resources support conditions in their IAM policies, see the [IAM
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/certificateTemplates/[^/]+$",
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

                /// <summary>Lists CertificateTemplates.</summary>
                /// <param name="parent">
                /// Required. The resource name of the location associated with the CertificateTemplates, in the format
                /// `projects/*/locations/*`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists CertificateTemplates.</summary>
                public class ListRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.ListCertificateTemplatesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the location associated with the CertificateTemplates, in the
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
                    /// Optional. Limit on the number of CertificateTemplates to include in the response. Further
                    /// CertificateTemplates can subsequently be obtained by including the
                    /// ListCertificateTemplatesResponse.next_page_token in a subsequent request. If unspecified, the
                    /// server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. Pagination token, returned earlier via
                    /// ListCertificateTemplatesResponse.next_page_token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/certificateTemplates";

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

                /// <summary>Update a CertificateTemplate.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The resource name for this CertificateTemplate in the format
                /// `projects/*/locations/*/certificateTemplates/*`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CertificateAuthorityService.v1.Data.CertificateTemplate body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Update a CertificateTemplate.</summary>
                public class PatchRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1.Data.CertificateTemplate body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The resource name for this CertificateTemplate in the format
                    /// `projects/*/locations/*/certificateTemplates/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry your
                    /// request, the server will know to ignore the request if it has already been completed. The server
                    /// will guarantee that for at least 60 minutes since the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
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
                    Google.Apis.CertificateAuthorityService.v1.Data.CertificateTemplate Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/certificateTemplates/[^/]+$",
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
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CertificateAuthorityService.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.CertificateAuthorityService.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/certificateTemplates/[^/]+$",
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
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CertificateAuthorityService.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.CertificateAuthorityService.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/certificateTemplates/[^/]+$",
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
                /// Operation.error value with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(Google.Apis.CertificateAuthorityService.v1.Data.CancelOperationRequest body, string name)
                {
                    return new CancelRequest(this.service, body, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
                /// </summary>
                public class CancelRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.CertificateAuthorityService.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CertificateAuthorityService.v1.Data.CancelOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:cancel";

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
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a long-running operation. This method indicates that the client is no longer interested in
                /// the operation result. It does not cancel the operation. If the server doesn't support this method,
                /// it returns `google.rpc.Code.UNIMPLEMENTED`.
                /// </summary>
                public class DeleteRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Empty>
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
                    return new GetRequest(this.service, name);
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                public class GetRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Operation>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`.
                /// </summary>
                /// <param name="name">The name of the operation's parent resource.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(this.service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`.
                /// </summary>
                public class ListRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.ListOperationsResponse>
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
                    public override string RestPath => "v1/{+name}/operations";

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

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.Location>
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
                        Pattern = @"^projects/[^/]+/locations/[^/]+$",
                    });
                }
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : CertificateAuthorityServiceBaseServiceRequest<Google.Apis.CertificateAuthorityService.v1.Data.ListLocationsResponse>
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

                /// <summary>
                /// A filter to narrow down results to a preferred subset. The filtering language accepts strings like
                /// `"displayName=tokyo"`, and is documented in more detail in [AIP-160](https://google.aip.dev/160).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// The maximum number of results to return. If not set, the service selects a default.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token received from the `next_page_token` field in the response. Send that page token to
                /// receive the subsequent page.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}/locations";

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
namespace Google.Apis.CertificateAuthorityService.v1.Data
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
        /// The URLs where this CertificateAuthority's CRLs are published. This will only be set for CAs that have been
        /// activated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crlAccessUrls")]
        public virtual System.Collections.Generic.IList<string> CrlAccessUrls { get; set; }

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
        /// request and the request times out. If you make the request again with the same request ID, the server can
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

    /// <summary>
    /// Describes a "type" of key that may be used in a Certificate issued from a CaPool. Note that a single
    /// AllowedKeyType may refer to either a fully-qualified key algorithm, such as RSA 4096, or a family of key
    /// algorithms, such as any RSA key.
    /// </summary>
    public class AllowedKeyType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Represents an allowed Elliptic Curve key type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ellipticCurve")]
        public virtual EcKeyType EllipticCurve { get; set; }

        /// <summary>Represents an allowed RSA key type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rsa")]
        public virtual RsaKeyType Rsa { get; set; }

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
    /// Describes the X.509 basic constraints extension, per [RFC 5280 section
    /// 4.2.1.9](https://tools.ietf.org/html/rfc5280#section-4.2.1.9)
    /// </summary>
    public class CaOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Refers to the "CA" boolean field in the X.509 extension. When this value is missing, the basic
        /// constraints extension will be omitted from the certificate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isCa")]
        public virtual System.Nullable<bool> IsCa { get; set; }

        /// <summary>
        /// Optional. Refers to the path length constraint field in the X.509 extension. For a CA certificate, this
        /// value describes the depth of subordinate CA certificates that are allowed. If this value is less than 0, the
        /// request will fail. If this value is missing, the max path length will be omitted from the certificate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxIssuerPathLength")]
        public virtual System.Nullable<int> MaxIssuerPathLength { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A CaPool represents a group of CertificateAuthorities that form a trust anchor. A CaPool can be used to manage
    /// issuance policies for one or more CertificateAuthority resources and to rotate CA certificates in and out of the
    /// trust anchor.
    /// </summary>
    public class CaPool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The IssuancePolicy to control how Certificates will be issued from this CaPool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuancePolicy")]
        public virtual IssuancePolicy IssuancePolicy { get; set; }

        /// <summary>Optional. Labels with user-defined metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The resource name for this CaPool in the format `projects/*/locations/*/caPools/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. The PublishingOptions to follow when issuing Certificates from any CertificateAuthority in this
        /// CaPool.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishingOptions")]
        public virtual PublishingOptions PublishingOptions { get; set; }

        /// <summary>Required. Immutable. The Tier of this CaPool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tier")]
        public virtual string Tier { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CertChain : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The certificates that form the CA chain, from leaf to root order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificates")]
        public virtual System.Collections.Generic.IList<string> Certificates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Certificate corresponds to a signed X.509 certificate issued by a CertificateAuthority.</summary>
    public class Certificate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. A structured description of the issued X.509 certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateDescription")]
        public virtual CertificateDescription CertificateDescription { get; set; }

        /// <summary>
        /// Immutable. The resource name for a CertificateTemplate used to issue this certificate, in the format
        /// `projects/*/locations/*/certificateTemplates/*`. If this is specified, the caller must have the necessary
        /// permission to use this template. If this is omitted, no template will be used. This template must be in the
        /// same location as the Certificate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateTemplate")]
        public virtual string CertificateTemplate { get; set; }

        /// <summary>Immutable. A description of the certificate and key that does not require X.509 or ASN.1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual CertificateConfig Config { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which this Certificate was created.</summary>
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

        /// <summary>
        /// Output only. The resource name of the issuing CertificateAuthority in the format
        /// `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuerCertificateAuthority")]
        public virtual string IssuerCertificateAuthority { get; set; }

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
        /// Identifier. The resource name for this Certificate in the format
        /// `projects/*/locations/*/caPools/*/certificates/*`.
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

        /// <summary>
        /// Immutable. Specifies how the Certificate's identity fields are to be decided. If this is omitted, the
        /// `DEFAULT` subject mode will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subjectMode")]
        public virtual string SubjectMode { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which this Certificate was updated.</summary>
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

        /// <summary>Required. Immutable. The config used to create a self-signed X.509 certificate or CSR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual CertificateConfig Config { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which this CertificateAuthority was created.</summary>
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

        /// <summary>
        /// Output only. The time at which this CertificateAuthority was soft deleted, if it is in the DELETED state.
        /// </summary>
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

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. The time at which this CertificateAuthority will be permanently purged, if it is in the DELETED
        /// state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual string ExpireTimeRaw
        {
            get => _expireTimeRaw;
            set
            {
                _expireTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expireTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpireTimeDateTimeOffset instead.")]
        public virtual object ExpireTime
        {
            get => _expireTime;
            set
            {
                _expireTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expireTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpireTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpireTimeRaw);
            set => ExpireTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Immutable. The name of a Cloud Storage bucket where this CertificateAuthority will publish content, such as
        /// the CA certificate and CRLs. This must be a bucket name, without any prefixes (such as `gs://`) or suffixes
        /// (such as `.googleapis.com`). For example, to use a bucket named `my-bucket`, you would simply specify
        /// `my-bucket`. If not specified, a managed bucket will be created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsBucket")]
        public virtual string GcsBucket { get; set; }

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
        /// Required. Immutable. The desired lifetime of the CA certificate. Used to create the "not_before_time" and
        /// "not_after_time" fields inside an X.509 certificate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifetime")]
        public virtual object Lifetime { get; set; }

        /// <summary>
        /// Identifier. The resource name for this CertificateAuthority in the format
        /// `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
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

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

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

        /// <summary>Output only. The CaPool.Tier of the CaPool that includes this CertificateAuthority.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tier")]
        public virtual string Tier { get; set; }

        /// <summary>Required. Immutable. The Type of this CertificateAuthority.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which this CertificateAuthority was last updated.</summary>
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
        /// Optional. User-defined URLs for CA certificate and CRLs. The service does not publish content to these URLs.
        /// It is up to the user to mirror content to these URLs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userDefinedAccessUrls")]
        public virtual UserDefinedAccessUrls UserDefinedAccessUrls { get; set; }

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

        /// <summary>Required. Specifies some of the values in a certificate that are related to the subject.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subjectConfig")]
        public virtual SubjectConfig SubjectConfig { get; set; }

        /// <summary>
        /// Optional. When specified this provides a custom SKI to be used in the certificate. This should only be used
        /// to maintain a SKI of an existing CA originally created outside CA service, which was not generated using
        /// method (1) described in RFC 5280 section 4.2.1.2.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subjectKeyId")]
        public virtual CertificateConfigKeyId SubjectKeyId { get; set; }

        /// <summary>
        /// Required. Describes how some of the technical X.509 fields in a certificate should be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x509Config")]
        public virtual X509Parameters X509Config { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A KeyId identifies a specific public key, usually by hashing the public key.</summary>
    public class CertificateConfigKeyId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The value of this KeyId encoded in lowercase hexadecimal. This is most likely the 160 bit SHA-1
        /// hash of the public key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyId")]
        public virtual string KeyId { get; set; }

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

        /// <summary>
        /// The hash of the pre-signed certificate, which will be signed by the CA. Corresponds to the TBS Certificate
        /// in https://tools.ietf.org/html/rfc5280#section-4.1.2. The field will always be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tbsCertificateDigest")]
        public virtual string TbsCertificateDigest { get; set; }

        /// <summary>Describes some of the technical X.509 fields in a certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x509Description")]
        public virtual X509Parameters X509Description { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a set of X.509 extensions that may be part of some certificate issuance controls.</summary>
    public class CertificateExtensionConstraints : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A set of ObjectIds identifying custom X.509 extensions. Will be combined with known_extensions to
        /// determine the full set of X.509 extensions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalExtensions")]
        public virtual System.Collections.Generic.IList<ObjectId> AdditionalExtensions { get; set; }

        /// <summary>
        /// Optional. A set of named X.509 extensions. Will be combined with additional_extensions to determine the full
        /// set of X.509 extensions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("knownExtensions")]
        public virtual System.Collections.Generic.IList<string> KnownExtensions { get; set; }

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

    /// <summary>Describes constraints on a Certificate's Subject and SubjectAltNames.</summary>
    public class CertificateIdentityConstraints : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. If this is true, the SubjectAltNames extension may be copied from a certificate request into the
        /// signed certificate. Otherwise, the requested SubjectAltNames will be discarded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowSubjectAltNamesPassthrough")]
        public virtual System.Nullable<bool> AllowSubjectAltNamesPassthrough { get; set; }

        /// <summary>
        /// Required. If this is true, the Subject field may be copied from a certificate request into the signed
        /// certificate. Otherwise, the requested Subject will be discarded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowSubjectPassthrough")]
        public virtual System.Nullable<bool> AllowSubjectPassthrough { get; set; }

        /// <summary>
        /// Optional. A CEL expression that may be used to validate the resolved X.509 Subject and/or Subject
        /// Alternative Name before a certificate is signed. To see the full allowed syntax and some examples, see
        /// https://cloud.google.com/certificate-authority-service/docs/using-cel
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("celExpression")]
        public virtual Expr CelExpression { get; set; }

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

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which this CertificateRevocationList was created.</summary>
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

        /// <summary>Optional. Labels with user-defined metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The resource name for this CertificateRevocationList in the format
        /// `projects/*/locations/*/caPools/*certificateAuthorities/*/ certificateRevocationLists/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The PEM-encoded X.509 CRL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pemCrl")]
        public virtual string PemCrl { get; set; }

        /// <summary>
        /// Output only. The revision ID of this CertificateRevocationList. A new revision is committed whenever a new
        /// CRL is published. The format is an 8-character hexadecimal string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>Output only. The revoked serial numbers that appear in pem_crl.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revokedCertificates")]
        public virtual System.Collections.Generic.IList<RevokedCertificate> RevokedCertificates { get; set; }

        /// <summary>Output only. The CRL sequence number that appears in pem_crl.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sequenceNumber")]
        public virtual System.Nullable<long> SequenceNumber { get; set; }

        /// <summary>Output only. The State for this CertificateRevocationList.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which this CertificateRevocationList was updated.</summary>
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

    /// <summary>A CertificateTemplate refers to a managed template for certificate issuance.</summary>
    public class CertificateTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which this CertificateTemplate was created.</summary>
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

        /// <summary>Optional. A human-readable description of scenarios this template is intended for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Describes constraints on identities that may be appear in Certificates issued using this template.
        /// If this is omitted, then this template will not add restrictions on a certificate's identity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityConstraints")]
        public virtual CertificateIdentityConstraints IdentityConstraints { get; set; }

        /// <summary>Optional. Labels with user-defined metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. The maximum lifetime allowed for issued Certificates that use this template. If the issuing CaPool
        /// resource's IssuancePolicy specifies a maximum_lifetime the minimum of the two durations will be the maximum
        /// lifetime for issued Certificates. Note that if the issuing CertificateAuthority expires before a
        /// Certificate's requested maximum_lifetime, the effective lifetime will be explicitly truncated to match it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumLifetime")]
        public virtual object MaximumLifetime { get; set; }

        /// <summary>
        /// Identifier. The resource name for this CertificateTemplate in the format
        /// `projects/*/locations/*/certificateTemplates/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Describes the set of X.509 extensions that may appear in a Certificate issued using this
        /// CertificateTemplate. If a certificate request sets extensions that don't appear in the
        /// passthrough_extensions, those extensions will be dropped. If the issuing CaPool's IssuancePolicy defines
        /// baseline_values that don't appear here, the certificate issuance request will fail. If this is omitted, then
        /// this template will not add restrictions on a certificate's X.509 extensions. These constraints do not apply
        /// to X.509 extensions set in this CertificateTemplate's predefined_values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passthroughExtensions")]
        public virtual CertificateExtensionConstraints PassthroughExtensions { get; set; }

        /// <summary>
        /// Optional. A set of X.509 values that will be applied to all issued certificates that use this template. If
        /// the certificate request includes conflicting values for the same properties, they will be overwritten by the
        /// values defined here. If the issuing CaPool's IssuancePolicy defines conflicting baseline_values for the same
        /// properties, the certificate issuance request will fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predefinedValues")]
        public virtual X509Parameters PredefinedValues { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which this CertificateTemplate was updated.</summary>
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

    /// <summary>Request message for CertificateAuthorityService.DisableCertificateAuthority.</summary>
    public class DisableCertificateAuthorityRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. This field allows this CA to be disabled even if it's being depended on by another resource.
        /// However, doing so may result in unintended and unrecoverable effects on any dependent resources since the CA
        /// will no longer be able to issue certificates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreDependentResources")]
        public virtual System.Nullable<bool> IgnoreDependentResources { get; set; }

        /// <summary>
        /// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry your request,
        /// the server will know to ignore the request if it has already been completed. The server will guarantee that
        /// for at least 60 minutes since the first request. For example, consider a situation where you make an initial
        /// request and the request times out. If you make the request again with the same request ID, the server can
        /// check if original operation with the same request ID was received, and if so, will ignore the second
        /// request. This prevents clients from accidentally creating duplicate commitments. The request ID must be a
        /// valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes an Elliptic Curve key that may be used in a Certificate issued from a CaPool.</summary>
    public class EcKeyType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A signature algorithm that must be used. If this is omitted, any EC-based signature algorithm will
        /// be allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signatureAlgorithm")]
        public virtual string SignatureAlgorithm { get; set; }

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

    /// <summary>Request message for CertificateAuthorityService.EnableCertificateAuthority.</summary>
    public class EnableCertificateAuthorityRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry your request,
        /// the server will know to ignore the request if it has already been completed. The server will guarantee that
        /// for at least 60 minutes since the first request. For example, consider a situation where you make an initial
        /// request and the request times out. If you make the request again with the same request ID, the server can
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

    /// <summary>Request message for CertificateAuthorityService.FetchCaCerts.</summary>
    public class FetchCaCertsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry your request,
        /// the server will know to ignore the request if it has already been completed. The server will guarantee that
        /// for at least 60 minutes since the first request. For example, consider a situation where you make an initial
        /// request and the request times out. If you make the request again with the same request ID, the server can
        /// check if original operation with the same request ID was received, and if so, will ignore the second
        /// request. This prevents clients from accidentally creating duplicate commitments. The request ID must be a
        /// valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for CertificateAuthorityService.FetchCaCerts.</summary>
    public class FetchCaCertsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The PEM encoded CA certificate chains of all certificate authorities in this CaPool in the ENABLED,
        /// DISABLED, or STAGED states.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caCerts")]
        public virtual System.Collections.Generic.IList<CertChain> CaCerts { get; set; }

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

    /// <summary>
    /// IssuanceModes specifies the allowed ways in which Certificates may be requested from this CaPool.
    /// </summary>
    public class IssuanceModes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. When true, allows callers to create Certificates by specifying a CertificateConfig.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowConfigBasedIssuance")]
        public virtual System.Nullable<bool> AllowConfigBasedIssuance { get; set; }

        /// <summary>Optional. When true, allows callers to create Certificates by specifying a CSR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowCsrBasedIssuance")]
        public virtual System.Nullable<bool> AllowCsrBasedIssuance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines controls over all certificate issuance within a CaPool.</summary>
    public class IssuancePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If specified, then only methods allowed in the IssuanceModes may be used to issue Certificates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedIssuanceModes")]
        public virtual IssuanceModes AllowedIssuanceModes { get; set; }

        /// <summary>
        /// Optional. If any AllowedKeyType is specified, then the certificate request's public key must match one of
        /// the key types listed here. Otherwise, any key may be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedKeyTypes")]
        public virtual System.Collections.Generic.IList<AllowedKeyType> AllowedKeyTypes { get; set; }

        /// <summary>
        /// Optional. A set of X.509 values that will be applied to all certificates issued through this CaPool. If a
        /// certificate request includes conflicting values for the same properties, they will be overwritten by the
        /// values defined here. If a certificate request uses a CertificateTemplate that defines conflicting
        /// predefined_values for the same properties, the certificate issuance request will fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baselineValues")]
        public virtual X509Parameters BaselineValues { get; set; }

        /// <summary>
        /// Optional. Describes constraints on identities that may appear in Certificates issued through this CaPool. If
        /// this is omitted, then this CaPool will not add restrictions on a certificate's identity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityConstraints")]
        public virtual CertificateIdentityConstraints IdentityConstraints { get; set; }

        /// <summary>
        /// Optional. The maximum lifetime allowed for issued Certificates. Note that if the issuing
        /// CertificateAuthority expires before a Certificate resource's requested maximum_lifetime, the effective
        /// lifetime will be explicitly truncated to match it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumLifetime")]
        public virtual object MaximumLifetime { get; set; }

        /// <summary>
        /// Optional. Describes the set of X.509 extensions that may appear in a Certificate issued through this CaPool.
        /// If a certificate request sets extensions that don't appear in the passthrough_extensions, those extensions
        /// will be dropped. If a certificate request uses a CertificateTemplate with predefined_values that don't
        /// appear here, the certificate issuance request will fail. If this is omitted, then this CaPool will not add
        /// restrictions on a certificate's X.509 extensions. These constraints do not apply to X.509 extensions set in
        /// this CaPool's baseline_values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passthroughExtensions")]
        public virtual CertificateExtensionConstraints PassthroughExtensions { get; set; }

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
        /// The algorithm to use for creating a managed Cloud KMS key for a for a simplified experience. All managed
        /// keys will be have their ProtectionLevel as `HSM`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("algorithm")]
        public virtual string Algorithm { get; set; }

        /// <summary>
        /// The resource name for an existing Cloud KMS CryptoKeyVersion in the format
        /// `projects/*/locations/*/keyRings/*/cryptoKeys/*/cryptoKeyVersions/*`. This option enables full flexibility
        /// in the key's capabilities and properties.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudKmsKeyVersion")]
        public virtual string CloudKmsKeyVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for CertificateAuthorityService.ListCaPools.</summary>
    public class ListCaPoolsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of CaPools.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caPools")]
        public virtual System.Collections.Generic.IList<CaPool> CaPools { get; set; }

        /// <summary>
        /// A token to retrieve next page of results. Pass this value in ListCertificateAuthoritiesRequest.page_token to
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

    /// <summary>Response message for CertificateAuthorityService.ListCertificateAuthorities.</summary>
    public class ListCertificateAuthoritiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of CertificateAuthorities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateAuthorities")]
        public virtual System.Collections.Generic.IList<CertificateAuthority> CertificateAuthorities { get; set; }

        /// <summary>
        /// A token to retrieve next page of results. Pass this value in ListCertificateAuthoritiesRequest.page_token to
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

    /// <summary>Response message for CertificateAuthorityService.ListCertificateRevocationLists.</summary>
    public class ListCertificateRevocationListsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of CertificateRevocationLists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateRevocationLists")]
        public virtual System.Collections.Generic.IList<CertificateRevocationList> CertificateRevocationLists { get; set; }

        /// <summary>
        /// A token to retrieve next page of results. Pass this value in
        /// ListCertificateRevocationListsRequest.page_token to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of locations (e.g. "us-west1") that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for CertificateAuthorityService.ListCertificateTemplates.</summary>
    public class ListCertificateTemplatesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of CertificateTemplates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateTemplates")]
        public virtual System.Collections.Generic.IList<CertificateTemplate> CertificateTemplates { get; set; }

        /// <summary>
        /// A token to retrieve next page of results. Pass this value in ListCertificateTemplatesRequest.page_token to
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

    /// <summary>Response message for CertificateAuthorityService.ListCertificates.</summary>
    public class ListCertificatesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Certificates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificates")]
        public virtual System.Collections.Generic.IList<Certificate> Certificates { get; set; }

        /// <summary>
        /// A token to retrieve next page of results. Pass this value in ListCertificatesRequest.page_token to retrieve
        /// the next page of results.
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

    /// <summary>A resource that represents a Google Cloud location.</summary>
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

    /// <summary>
    /// Describes the X.509 name constraints extension, per https://tools.ietf.org/html/rfc5280#section-4.2.1.10
    /// </summary>
    public class NameConstraints : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates whether or not the name constraints are marked critical.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("critical")]
        public virtual System.Nullable<bool> Critical { get; set; }

        /// <summary>
        /// Contains excluded DNS names. Any DNS name that can be constructed by simply adding zero or more labels to
        /// the left-hand side of the name satisfies the name constraint. For example, `example.com`, `www.example.com`,
        /// `www.sub.example.com` would satisfy `example.com` while `example1.com` does not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedDnsNames")]
        public virtual System.Collections.Generic.IList<string> ExcludedDnsNames { get; set; }

        /// <summary>
        /// Contains the excluded email addresses. The value can be a particular email address, a hostname to indicate
        /// all email addresses on that host or a domain with a leading period (e.g. `.example.com`) to indicate all
        /// email addresses in that domain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedEmailAddresses")]
        public virtual System.Collections.Generic.IList<string> ExcludedEmailAddresses { get; set; }

        /// <summary>
        /// Contains the excluded IP ranges. For IPv4 addresses, the ranges are expressed using CIDR notation as
        /// specified in RFC 4632. For IPv6 addresses, the ranges are expressed in similar encoding as IPv4 addresses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedIpRanges")]
        public virtual System.Collections.Generic.IList<string> ExcludedIpRanges { get; set; }

        /// <summary>
        /// Contains the excluded URIs that apply to the host part of the name. The value can be a hostname or a domain
        /// with a leading period (like `.example.com`)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedUris")]
        public virtual System.Collections.Generic.IList<string> ExcludedUris { get; set; }

        /// <summary>
        /// Contains permitted DNS names. Any DNS name that can be constructed by simply adding zero or more labels to
        /// the left-hand side of the name satisfies the name constraint. For example, `example.com`, `www.example.com`,
        /// `www.sub.example.com` would satisfy `example.com` while `example1.com` does not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permittedDnsNames")]
        public virtual System.Collections.Generic.IList<string> PermittedDnsNames { get; set; }

        /// <summary>
        /// Contains the permitted email addresses. The value can be a particular email address, a hostname to indicate
        /// all email addresses on that host or a domain with a leading period (e.g. `.example.com`) to indicate all
        /// email addresses in that domain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permittedEmailAddresses")]
        public virtual System.Collections.Generic.IList<string> PermittedEmailAddresses { get; set; }

        /// <summary>
        /// Contains the permitted IP ranges. For IPv4 addresses, the ranges are expressed using CIDR notation as
        /// specified in RFC 4632. For IPv6 addresses, the ranges are expressed in similar encoding as IPv4 addresses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permittedIpRanges")]
        public virtual System.Collections.Generic.IList<string> PermittedIpRanges { get; set; }

        /// <summary>
        /// Contains the permitted URIs that apply to the host part of the name. The value can be a hostname or a domain
        /// with a leading period (like `.example.com`)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permittedUris")]
        public virtual System.Collections.Generic.IList<string> PermittedUris { get; set; }

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
        /// The normal, successful response of the operation. If the original method returns no data on success, such as
        /// `Delete`, the response is `google.protobuf.Empty`. If the original method is standard
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

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time the operation was created.</summary>
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

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual string EndTimeRaw
        {
            get => _endTimeRaw;
            set
            {
                _endTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _endTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EndTimeDateTimeOffset instead.")]
        public virtual object EndTime
        {
            get => _endTime;
            set
            {
                _endTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _endTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EndTimeRaw);
            set => EndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. Identifies whether the user has requested cancellation of the operation. Operations that have
        /// successfully been cancelled have google.longrunning.Operation.error value with a google.rpc.Status.code of
        /// 1, corresponding to `Code.CANCELLED`.
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
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<AuditConfig> AuditConfigs { get; set; }

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

    /// <summary>A PublicKey describes a public key.</summary>
    public class PublicKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The format of the public key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>
        /// Required. A public key. The padding and encoding must match with the `KeyFormat` value specified for the
        /// `format` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Options relating to the publication of each CertificateAuthority's CA certificate and CRLs and their inclusion
    /// as extensions in issued Certificates. The options set here apply to certificates issued by any
    /// CertificateAuthority in the CaPool.
    /// </summary>
    public class PublishingOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specifies the encoding format of each CertificateAuthority resource's CA certificate and CRLs. If
        /// this is omitted, CA certificates and CRLs will be published in PEM.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encodingFormat")]
        public virtual string EncodingFormat { get; set; }

        /// <summary>
        /// Optional. When true, publishes each CertificateAuthority's CA certificate and includes its URL in the
        /// "Authority Information Access" X.509 extension in all issued Certificates. If this is false, the CA
        /// certificate will not be published and the corresponding X.509 extension will not be written in issued
        /// certificates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishCaCert")]
        public virtual System.Nullable<bool> PublishCaCert { get; set; }

        /// <summary>
        /// Optional. When true, publishes each CertificateAuthority's CRL and includes its URL in the "CRL Distribution
        /// Points" X.509 extension in all issued Certificates. If this is false, CRLs will not be published and the
        /// corresponding X.509 extension will not be written in issued certificates. CRLs will expire 7 days from their
        /// creation. However, we will rebuild daily. CRLs are also rebuilt shortly after a certificate is revoked.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishCrl")]
        public virtual System.Nullable<bool> PublishCrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Operation metadata returned by the CLH during resource state reconciliation.</summary>
    public class ReconciliationOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>DEPRECATED. Use exclusive_action instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteResource")]
        public virtual System.Nullable<bool> DeleteResource { get; set; }

        /// <summary>Excluisive action returned by the CLH.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusiveAction")]
        public virtual string ExclusiveAction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes fields that are relavent to the revocation of a Certificate.</summary>
    public class RevocationDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates why a Certificate was revoked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revocationState")]
        public virtual string RevocationState { get; set; }

        private string _revocationTimeRaw;

        private object _revocationTime;

        /// <summary>The time at which this Certificate was revoked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revocationTime")]
        public virtual string RevocationTimeRaw
        {
            get => _revocationTimeRaw;
            set
            {
                _revocationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _revocationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RevocationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RevocationTimeDateTimeOffset instead.")]
        public virtual object RevocationTime
        {
            get => _revocationTime;
            set
            {
                _revocationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _revocationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="RevocationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RevocationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RevocationTimeRaw);
            set => RevocationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

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
        /// request and the request times out. If you make the request again with the same request ID, the server can
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
        /// The resource name for the Certificate in the format `projects/*/locations/*/caPools/*/certificates/*`.
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

    /// <summary>Describes an RSA key that may be used in a Certificate issued from a CaPool.</summary>
    public class RsaKeyType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The maximum allowed RSA modulus size (inclusive), in bits. If this is not set, or if set to zero,
        /// the service will not enforce an explicit upper bound on RSA modulus sizes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxModulusSize")]
        public virtual System.Nullable<long> MaxModulusSize { get; set; }

        /// <summary>
        /// Optional. The minimum allowed RSA modulus size (inclusive), in bits. If this is not set, or if set to zero,
        /// the service-level min RSA modulus size will continue to apply.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minModulusSize")]
        public virtual System.Nullable<long> MinModulusSize { get; set; }

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
        /// <summary>The "common name" of the subject.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonName")]
        public virtual string CommonName { get; set; }

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
        /// <summary>
        /// Contains additional subject alternative name values. For each custom_san, the `value` field must contain an
        /// ASN.1 encoded UTF8String.
        /// </summary>
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
        /// <summary>
        /// Optional. Contains distinguished name fields such as the common name, location and organization.
        /// </summary>
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
        /// <summary>The serial number encoded in lowercase hexadecimal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hexSerialNumber")]
        public virtual string HexSerialNumber { get; set; }

        /// <summary>For convenience, the actual lifetime of an issued certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifetime")]
        public virtual object Lifetime { get; set; }

        private string _notAfterTimeRaw;

        private object _notAfterTime;

        /// <summary>
        /// The time after which the certificate is expired. Per RFC 5280, the validity period for a certificate is the
        /// period of time from not_before_time through not_after_time, inclusive. Corresponds to 'not_before_time' +
        /// 'lifetime' - 1 second.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notAfterTime")]
        public virtual string NotAfterTimeRaw
        {
            get => _notAfterTimeRaw;
            set
            {
                _notAfterTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _notAfterTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="NotAfterTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NotAfterTimeDateTimeOffset instead.")]
        public virtual object NotAfterTime
        {
            get => _notAfterTime;
            set
            {
                _notAfterTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _notAfterTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="NotAfterTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NotAfterTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NotAfterTimeRaw);
            set => NotAfterTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _notBeforeTimeRaw;

        private object _notBeforeTime;

        /// <summary>The time at which the certificate becomes valid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notBeforeTime")]
        public virtual string NotBeforeTimeRaw
        {
            get => _notBeforeTimeRaw;
            set
            {
                _notBeforeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _notBeforeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="NotBeforeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NotBeforeTimeDateTimeOffset instead.")]
        public virtual object NotBeforeTime
        {
            get => _notBeforeTime;
            set
            {
                _notBeforeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _notBeforeTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="NotBeforeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NotBeforeTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NotBeforeTimeRaw);
            set => NotBeforeTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Contains distinguished name fields such as the common name, location and / organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subject")]
        public virtual Subject Subject { get; set; }

        /// <summary>The subject alternative name fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subjectAltName")]
        public virtual SubjectAltNames SubjectAltName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes a subordinate CA's issuers. This is either a resource name to a known issuing CertificateAuthority, or
    /// a PEM issuer certificate chain.
    /// </summary>
    public class SubordinateConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. This can refer to a CertificateAuthority that was used to create a subordinate
        /// CertificateAuthority. This field is used for information and usability purposes only. The resource name is
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
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

    /// <summary>Request message for CertificateAuthorityService.UndeleteCertificateAuthority.</summary>
    public class UndeleteCertificateAuthorityRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry your request,
        /// the server will know to ignore the request if it has already been completed. The server will guarantee that
        /// for at least 60 minutes since the first request. For example, consider a situation where you make an initial
        /// request and the request times out. If you make the request again with the same request ID, the server can
        /// check if original operation with the same request ID was received, and if so, will ignore the second
        /// request. This prevents clients from accidentally creating duplicate commitments. The request ID must be a
        /// valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>User-defined URLs for accessing content published by this CertificateAuthority.</summary>
    public class UserDefinedAccessUrls : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A list of URLs where the issuer CA certificate may be downloaded, which appears in the "Authority
        /// Information Access" extension in the certificate. If specified, the default GCS URLs will be omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aiaIssuingCertificateUrls")]
        public virtual System.Collections.Generic.IList<string> AiaIssuingCertificateUrls { get; set; }

        /// <summary>
        /// Optional. A list of URLs where to obtain CRL information, i.e. the DistributionPoint.fullName described by
        /// https://tools.ietf.org/html/rfc5280#section-4.2.1.13. If specified, the default GCS URLs will be omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crlAccessUrls")]
        public virtual System.Collections.Generic.IList<string> CrlAccessUrls { get; set; }

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
        /// Optional. Indicates whether or not this extension is critical (i.e., if the client does not know how to
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

    /// <summary>
    /// An X509Parameters is used to describe certain fields of an X.509 certificate, such as the key usage fields,
    /// fields specific to CA certificates, certificate policy extensions and custom extensions.
    /// </summary>
    public class X509Parameters : Google.Apis.Requests.IDirectResponseSchema
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
        /// Optional. Describes options in this X509Parameters that are relevant in a CA certificate. If not specified,
        /// a default basic constraints extension with `is_ca=false` will be added for leaf certificates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caOptions")]
        public virtual CaOptions CaOptions { get; set; }

        /// <summary>Optional. Indicates the intended use for keys that correspond to a certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyUsage")]
        public virtual KeyUsage KeyUsage { get; set; }

        /// <summary>Optional. Describes the X.509 name constraints extension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nameConstraints")]
        public virtual NameConstraints NameConstraints { get; set; }

        /// <summary>
        /// Optional. Describes the X.509 certificate policy object identifiers, per
        /// https://tools.ietf.org/html/rfc5280#section-4.2.1.4.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyIds")]
        public virtual System.Collections.Generic.IList<ObjectId> PolicyIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
