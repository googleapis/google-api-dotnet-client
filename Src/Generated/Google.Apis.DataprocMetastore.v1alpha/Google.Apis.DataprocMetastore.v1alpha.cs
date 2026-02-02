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

namespace Google.Apis.DataprocMetastore.v1alpha
{
    /// <summary>The DataprocMetastore Service.</summary>
    public class DataprocMetastoreService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DataprocMetastoreService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DataprocMetastoreService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://metastore.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://metastore.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "metastore";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Dataproc Metastore API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Dataproc Metastore API.</summary>
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

    /// <summary>A base abstract class for DataprocMetastore requests.</summary>
    public abstract class DataprocMetastoreBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DataprocMetastoreBaseServiceRequest instance.</summary>
        protected DataprocMetastoreBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes DataprocMetastore parameter list.</summary>
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
                Federations = new FederationsResource(service);
                Operations = new OperationsResource(service);
                Services = new ServicesResource(service);
            }

            /// <summary>Gets the Federations resource.</summary>
            public virtual FederationsResource Federations { get; }

            /// <summary>The "federations" collection of methods.</summary>
            public class FederationsResource
            {
                private const string Resource = "federations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public FederationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a metastore federation in a project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The relative resource name of the location in which to create a federation service, in the
                /// following form:projects/{project_number}/locations/{location_id}.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DataprocMetastore.v1alpha.Data.Federation body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a metastore federation in a project and location.</summary>
                public class CreateRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.Federation body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the location in which to create a federation service, in
                    /// the following form:projects/{project_number}/locations/{location_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID of the metastore federation, which is used as the final component of the
                    /// metastore federation's name.This value must be between 2 and 63 characters long inclusive, begin
                    /// with a letter, end with a letter or number, and consist of alpha-numeric ASCII characters or
                    /// hyphens.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("federationId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string FederationId { get; set; }

                    /// <summary>
                    /// Optional. A request ID. Specify a unique request ID to allow the server to ignore the request if
                    /// it has completed. The server will ignore subsequent requests that provide a duplicate request ID
                    /// for at least 60 minutes after the first request.For example, if an initial request times out,
                    /// followed by another request with the same request ID, the server ignores the second request to
                    /// prevent the creation of duplicate commitments.The request ID must be a valid UUID
                    /// (https://en.wikipedia.org/wiki/Universally_unique_identifier#Format) A zero UUID
                    /// (00000000-0000-0000-0000-000000000000) is not supported.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v1alpha.Data.Federation Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/federations";

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
                        RequestParameters.Add("federationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "federationId",
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

                /// <summary>Deletes a single federation.</summary>
                /// <param name="name">
                /// Required. The relative resource name of the metastore federation to delete, in the following
                /// form:projects/{project_number}/locations/{location_id}/federations/{federation_id}.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single federation.</summary>
                public class DeleteRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the metastore federation to delete, in the following
                    /// form:projects/{project_number}/locations/{location_id}/federations/{federation_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A request ID. Specify a unique request ID to allow the server to ignore the request if
                    /// it has completed. The server will ignore subsequent requests that provide a duplicate request ID
                    /// for at least 60 minutes after the first request.For example, if an initial request times out,
                    /// followed by another request with the same request ID, the server ignores the second request to
                    /// prevent the creation of duplicate commitments.The request ID must be a valid UUID
                    /// (https://en.wikipedia.org/wiki/Universally_unique_identifier#Format) A zero UUID
                    /// (00000000-0000-0000-0000-000000000000) is not supported.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/federations/[^/]+$",
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

                /// <summary>Gets the details of a single federation.</summary>
                /// <param name="name">
                /// Required. The relative resource name of the metastore federation to retrieve, in the following
                /// form:projects/{project_number}/locations/{location_id}/federations/{federation_id}.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets the details of a single federation.</summary>
                public class GetRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Federation>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the metastore federation to retrieve, in the following
                    /// form:projects/{project_number}/locations/{location_id}/federations/{federation_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/federations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See Resource names
                /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(this.service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                    {
                        Resource = resource;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See Resource names
                    /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>
                    /// Optional. The maximum policy version that will be used to format the policy.Valid values are 0,
                    /// 1, and 3. Requests specifying an invalid value will be rejected.Requests for policies with any
                    /// conditional role bindings must specify version 3. Policies with no conditional role bindings may
                    /// specify any valid value or leave the field unset.The policy in the response might use the policy
                    /// version that you specified, or it might use a lower policy version. For example, if you specify
                    /// version 3, but the policy has no conditional role bindings, the response uses version 1.To learn
                    /// which resources support conditions in their IAM policies, see the IAM documentation
                    /// (https://cloud.google.com/iam/help/conditions/resource-policies).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+resource}:getIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/federations/[^/]+$",
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

                /// <summary>Lists federations in a project and location.</summary>
                /// <param name="parent">
                /// Required. The relative resource name of the location of metastore federations to list, in the
                /// following form: projects/{project_number}/locations/{location_id}.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists federations in a project and location.</summary>
                public class ListRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.ListFederationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the location of metastore federations to list, in the
                    /// following form: projects/{project_number}/locations/{location_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. The filter to apply to list results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. Specify the ordering of results as described in Sorting Order
                    /// (https://cloud.google.com/apis/design/design_patterns#sorting_order). If not specified, the
                    /// results will be sorted in the default order.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of federations to return. The response may contain less than the
                    /// maximum number. If unspecified, no more than 500 services are returned. The maximum value is
                    /// 1000; values above 1000 are changed to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous ListFederationServices call. Provide this token
                    /// to retrieve the subsequent page.To retrieve the first page, supply an empty page token.When
                    /// paginating, other parameters provided to ListFederationServices must match the call that
                    /// provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/federations";

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

                /// <summary>Updates the fields of a federation.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Immutable. The relative resource name of the federation, of the form:
                /// projects/{project_number}/locations/{location_id}/federations/{federation_id}`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.DataprocMetastore.v1alpha.Data.Federation body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the fields of a federation.</summary>
                public class PatchRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.Federation body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Immutable. The relative resource name of the federation, of the form:
                    /// projects/{project_number}/locations/{location_id}/federations/{federation_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A request ID. Specify a unique request ID to allow the server to ignore the request if
                    /// it has completed. The server will ignore subsequent requests that provide a duplicate request ID
                    /// for at least 60 minutes after the first request.For example, if an initial request times out,
                    /// followed by another request with the same request ID, the server ignores the second request to
                    /// prevent the creation of duplicate commitments.The request ID must be a valid UUID
                    /// (https://en.wikipedia.org/wiki/Universally_unique_identifier#Format) A zero UUID
                    /// (00000000-0000-0000-0000-000000000000) is not supported.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. A field mask used to specify the fields to be overwritten in the metastore federation
                    /// resource by the update. Fields specified in the update_mask are relative to the resource (not to
                    /// the full request). A field is overwritten if it is in the mask.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v1alpha.Data.Federation Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/federations/[^/]+$",
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
                /// Sets the access control policy on the specified resource. Replaces any existing policy.Can return
                /// NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See Resource names
                /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.DataprocMetastore.v1alpha.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy.Can return
                /// NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                /// </summary>
                public class SetIamPolicyRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.SetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being specified. See Resource names
                    /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v1alpha.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+resource}:setIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/federations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a NOT_FOUND error.Note: This operation is designed
                /// to be used for building permission-aware UIs and command-line tools, not for authorization checking.
                /// This operation may "fail open" without warning.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See Resource names
                /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.DataprocMetastore.v1alpha.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a NOT_FOUND error.Note: This operation is designed
                /// to be used for building permission-aware UIs and command-line tools, not for authorization checking.
                /// This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.TestIamPermissionsRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy detail is being requested. See Resource names
                    /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v1alpha.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+resource}:testIamPermissions";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/federations/[^/]+$",
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
                /// returns google.rpc.Code.UNIMPLEMENTED. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to Code.CANCELLED.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(Google.Apis.DataprocMetastore.v1alpha.Data.CancelOperationRequest body, string name)
                {
                    return new CancelRequest(this.service, body, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns google.rpc.Code.UNIMPLEMENTED. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to Code.CANCELLED.
                /// </summary>
                public class CancelRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v1alpha.Data.CancelOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}:cancel";

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
                /// it returns google.rpc.Code.UNIMPLEMENTED.
                /// </summary>
                /// <param name="name">The name of the operation resource to be deleted.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a long-running operation. This method indicates that the client is no longer interested in
                /// the operation result. It does not cancel the operation. If the server doesn't support this method,
                /// it returns google.rpc.Code.UNIMPLEMENTED.
                /// </summary>
                public class DeleteRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Empty>
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
                    public override string RestPath => "v1alpha/{+name}";

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
                public class GetRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Operation>
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
                    public override string RestPath => "v1alpha/{+name}";

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
                /// method, it returns UNIMPLEMENTED.
                /// </summary>
                /// <param name="name">The name of the operation's parent resource.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(this.service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns UNIMPLEMENTED.
                /// </summary>
                public class ListRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.ListOperationsResponse>
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

                    /// <summary>
                    /// When set to true, operations that are reachable are returned as normal, and those that are
                    /// unreachable are returned in the ListOperationsResponse.unreachable field.This can only be true
                    /// when reading across collections. For example, when parent is set to
                    /// "projects/example/locations/-".This field is not supported by default and will result in an
                    /// UNIMPLEMENTED error if set unless explicitly documented otherwise in service or product specific
                    /// documentation.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("returnPartialSuccess", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ReturnPartialSuccess { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}/operations";

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
                        RequestParameters.Add("returnPartialSuccess", new Google.Apis.Discovery.Parameter
                        {
                            Name = "returnPartialSuccess",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the Services resource.</summary>
            public virtual ServicesResource Services { get; }

            /// <summary>The "services" collection of methods.</summary>
            public class ServicesResource
            {
                private const string Resource = "services";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ServicesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Backups = new BackupsResource(service);
                    Databases = new DatabasesResource(service);
                    MetadataImports = new MetadataImportsResource(service);
                    MigrationExecutions = new MigrationExecutionsResource(service);
                }

                /// <summary>Gets the Backups resource.</summary>
                public virtual BackupsResource Backups { get; }

                /// <summary>The "backups" collection of methods.</summary>
                public class BackupsResource
                {
                    private const string Resource = "backups";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public BackupsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new backup in a given project and location.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The relative resource name of the service in which to create a backup of the following
                    /// form:projects/{project_number}/locations/{location_id}/services/{service_id}.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.DataprocMetastore.v1alpha.Data.Backup body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new backup in a given project and location.</summary>
                    public class CreateRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.Backup body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The relative resource name of the service in which to create a backup of the
                        /// following form:projects/{project_number}/locations/{location_id}/services/{service_id}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID of the backup, which is used as the final component of the backup's
                        /// name.This value must be between 1 and 64 characters long, begin with a letter, end with a
                        /// letter or number, and consist of alpha-numeric ASCII characters or hyphens.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("backupId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string BackupId { get; set; }

                        /// <summary>
                        /// Optional. A request ID. Specify a unique request ID to allow the server to ignore the
                        /// request if it has completed. The server will ignore subsequent requests that provide a
                        /// duplicate request ID for at least 60 minutes after the first request.For example, if an
                        /// initial request times out, followed by another request with the same request ID, the server
                        /// ignores the second request to prevent the creation of duplicate commitments.The request ID
                        /// must be a valid UUID (https://en.wikipedia.org/wiki/Universally_unique_identifier#Format) A
                        /// zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataprocMetastore.v1alpha.Data.Backup Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/backups";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                            });
                            RequestParameters.Add("backupId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "backupId",
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

                    /// <summary>Deletes a single backup.</summary>
                    /// <param name="name">
                    /// Required. The relative resource name of the backup to delete, in the following
                    /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a single backup.</summary>
                    public class DeleteRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The relative resource name of the backup to delete, in the following
                        /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. A request ID. Specify a unique request ID to allow the server to ignore the
                        /// request if it has completed. The server will ignore subsequent requests that provide a
                        /// duplicate request ID for at least 60 minutes after the first request.For example, if an
                        /// initial request times out, followed by another request with the same request ID, the server
                        /// ignores the second request to prevent the creation of duplicate commitments.The request ID
                        /// must be a valid UUID (https://en.wikipedia.org/wiki/Universally_unique_identifier#Format) A
                        /// zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+/backups/[^/]+$",
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

                    /// <summary>Gets details of a single backup.</summary>
                    /// <param name="name">
                    /// Required. The relative resource name of the backup to retrieve, in the following
                    /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a single backup.</summary>
                    public class GetRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Backup>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The relative resource name of the backup to retrieve, in the following
                        /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+/backups/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See Resource names
                    /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                    {
                        return new GetIamPolicyRequest(this.service, resource);
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    public class GetIamPolicyRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                        {
                            Resource = resource;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See Resource names
                        /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                        /// field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>
                        /// Optional. The maximum policy version that will be used to format the policy.Valid values are
                        /// 0, 1, and 3. Requests specifying an invalid value will be rejected.Requests for policies
                        /// with any conditional role bindings must specify version 3. Policies with no conditional role
                        /// bindings may specify any valid value or leave the field unset.The policy in the response
                        /// might use the policy version that you specified, or it might use a lower policy version. For
                        /// example, if you specify version 3, but the policy has no conditional role bindings, the
                        /// response uses version 1.To learn which resources support conditions in their IAM policies,
                        /// see the IAM documentation (https://cloud.google.com/iam/help/conditions/resource-policies).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+resource}:getIamPolicy";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+/backups/[^/]+$",
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

                    /// <summary>Lists backups in a service.</summary>
                    /// <param name="parent">
                    /// Required. The relative resource name of the service whose backups to list, in the following
                    /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/backups.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists backups in a service.</summary>
                    public class ListRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.ListBackupsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The relative resource name of the service whose backups to list, in the following
                        /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/backups.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. The filter to apply to list results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Specify the ordering of results as described in Sorting Order
                        /// (https://cloud.google.com/apis/design/design_patterns#sorting_order). If not specified, the
                        /// results will be sorted in the default order.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of backups to return. The response may contain less than the
                        /// maximum number. If unspecified, no more than 500 backups are returned. The maximum value is
                        /// 1000; values above 1000 are changed to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous DataprocMetastore.ListBackups call. Provide
                        /// this token to retrieve the subsequent page.To retrieve the first page, supply an empty page
                        /// token.When paginating, other parameters provided to DataprocMetastore.ListBackups must match
                        /// the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/backups";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
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
                    /// Sets the access control policy on the specified resource. Replaces any existing policy.Can
                    /// return NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See Resource names
                    /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.DataprocMetastore.v1alpha.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy.Can
                    /// return NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                    /// </summary>
                    public class SetIamPolicyRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.SetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being specified. See Resource names
                        /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                        /// field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataprocMetastore.v1alpha.Data.SetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+resource}:setIamPolicy";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+/backups/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a NOT_FOUND error.Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See Resource names
                    /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.DataprocMetastore.v1alpha.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a NOT_FOUND error.Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.TestIamPermissionsRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy detail is being requested. See Resource names
                        /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                        /// field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataprocMetastore.v1alpha.Data.TestIamPermissionsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "testIamPermissions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+resource}:testIamPermissions";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+/backups/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the Databases resource.</summary>
                public virtual DatabasesResource Databases { get; }

                /// <summary>The "databases" collection of methods.</summary>
                public class DatabasesResource
                {
                    private const string Resource = "databases";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public DatabasesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Tables = new TablesResource(service);
                    }

                    /// <summary>Gets the Tables resource.</summary>
                    public virtual TablesResource Tables { get; }

                    /// <summary>The "tables" collection of methods.</summary>
                    public class TablesResource
                    {
                        private const string Resource = "tables";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public TablesResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>
                        /// Gets the access control policy for a resource. Returns an empty policy if the resource
                        /// exists and does not have a policy set.
                        /// </summary>
                        /// <param name="resource">
                        /// REQUIRED: The resource for which the policy is being requested. See Resource names
                        /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                        /// field.
                        /// </param>
                        public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                        {
                            return new GetIamPolicyRequest(this.service, resource);
                        }

                        /// <summary>
                        /// Gets the access control policy for a resource. Returns an empty policy if the resource
                        /// exists and does not have a policy set.
                        /// </summary>
                        public class GetIamPolicyRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Policy>
                        {
                            /// <summary>Constructs a new GetIamPolicy request.</summary>
                            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                            {
                                Resource = resource;
                                InitParameters();
                            }

                            /// <summary>
                            /// REQUIRED: The resource for which the policy is being requested. See Resource names
                            /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                            /// field.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Resource { get; private set; }

                            /// <summary>
                            /// Optional. The maximum policy version that will be used to format the policy.Valid values
                            /// are 0, 1, and 3. Requests specifying an invalid value will be rejected.Requests for
                            /// policies with any conditional role bindings must specify version 3. Policies with no
                            /// conditional role bindings may specify any valid value or leave the field unset.The
                            /// policy in the response might use the policy version that you specified, or it might use
                            /// a lower policy version. For example, if you specify version 3, but the policy has no
                            /// conditional role bindings, the response uses version 1.To learn which resources support
                            /// conditions in their IAM policies, see the IAM documentation
                            /// (https://cloud.google.com/iam/help/conditions/resource-policies).
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "getIamPolicy";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+resource}:getIamPolicy";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+/databases/[^/]+/tables/[^/]+$",
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
                        /// Sets the access control policy on the specified resource. Replaces any existing policy.Can
                        /// return NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="resource">
                        /// REQUIRED: The resource for which the policy is being specified. See Resource names
                        /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                        /// field.
                        /// </param>
                        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.DataprocMetastore.v1alpha.Data.SetIamPolicyRequest body, string resource)
                        {
                            return new SetIamPolicyRequest(this.service, body, resource);
                        }

                        /// <summary>
                        /// Sets the access control policy on the specified resource. Replaces any existing policy.Can
                        /// return NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                        /// </summary>
                        public class SetIamPolicyRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Policy>
                        {
                            /// <summary>Constructs a new SetIamPolicy request.</summary>
                            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.SetIamPolicyRequest body, string resource) : base(service)
                            {
                                Resource = resource;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// REQUIRED: The resource for which the policy is being specified. See Resource names
                            /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                            /// field.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Resource { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.DataprocMetastore.v1alpha.Data.SetIamPolicyRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "setIamPolicy";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+resource}:setIamPolicy";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+/databases/[^/]+/tables/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Returns permissions that a caller has on the specified resource. If the resource does not
                        /// exist, this will return an empty set of permissions, not a NOT_FOUND error.Note: This
                        /// operation is designed to be used for building permission-aware UIs and command-line tools,
                        /// not for authorization checking. This operation may "fail open" without warning.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="resource">
                        /// REQUIRED: The resource for which the policy detail is being requested. See Resource names
                        /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                        /// field.
                        /// </param>
                        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.DataprocMetastore.v1alpha.Data.TestIamPermissionsRequest body, string resource)
                        {
                            return new TestIamPermissionsRequest(this.service, body, resource);
                        }

                        /// <summary>
                        /// Returns permissions that a caller has on the specified resource. If the resource does not
                        /// exist, this will return an empty set of permissions, not a NOT_FOUND error.Note: This
                        /// operation is designed to be used for building permission-aware UIs and command-line tools,
                        /// not for authorization checking. This operation may "fail open" without warning.
                        /// </summary>
                        public class TestIamPermissionsRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.TestIamPermissionsResponse>
                        {
                            /// <summary>Constructs a new TestIamPermissions request.</summary>
                            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.TestIamPermissionsRequest body, string resource) : base(service)
                            {
                                Resource = resource;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// REQUIRED: The resource for which the policy detail is being requested. See Resource
                            /// names (https://cloud.google.com/apis/design/resource_names) for the appropriate value
                            /// for this field.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Resource { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.DataprocMetastore.v1alpha.Data.TestIamPermissionsRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "testIamPermissions";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+resource}:testIamPermissions";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+/databases/[^/]+/tables/[^/]+$",
                                });
                            }
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See Resource names
                    /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                    {
                        return new GetIamPolicyRequest(this.service, resource);
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    public class GetIamPolicyRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                        {
                            Resource = resource;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See Resource names
                        /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                        /// field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>
                        /// Optional. The maximum policy version that will be used to format the policy.Valid values are
                        /// 0, 1, and 3. Requests specifying an invalid value will be rejected.Requests for policies
                        /// with any conditional role bindings must specify version 3. Policies with no conditional role
                        /// bindings may specify any valid value or leave the field unset.The policy in the response
                        /// might use the policy version that you specified, or it might use a lower policy version. For
                        /// example, if you specify version 3, but the policy has no conditional role bindings, the
                        /// response uses version 1.To learn which resources support conditions in their IAM policies,
                        /// see the IAM documentation (https://cloud.google.com/iam/help/conditions/resource-policies).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+resource}:getIamPolicy";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+/databases/[^/]+$",
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
                    /// Sets the access control policy on the specified resource. Replaces any existing policy.Can
                    /// return NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See Resource names
                    /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.DataprocMetastore.v1alpha.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy.Can
                    /// return NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                    /// </summary>
                    public class SetIamPolicyRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.SetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being specified. See Resource names
                        /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                        /// field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataprocMetastore.v1alpha.Data.SetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+resource}:setIamPolicy";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+/databases/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a NOT_FOUND error.Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See Resource names
                    /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.DataprocMetastore.v1alpha.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a NOT_FOUND error.Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.TestIamPermissionsRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy detail is being requested. See Resource names
                        /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                        /// field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataprocMetastore.v1alpha.Data.TestIamPermissionsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "testIamPermissions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+resource}:testIamPermissions";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+/databases/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the MetadataImports resource.</summary>
                public virtual MetadataImportsResource MetadataImports { get; }

                /// <summary>The "metadataImports" collection of methods.</summary>
                public class MetadataImportsResource
                {
                    private const string Resource = "metadataImports";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public MetadataImportsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new MetadataImport in a given project and location.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The relative resource name of the service in which to create a metastore import, in
                    /// the following form:projects/{project_number}/locations/{location_id}/services/{service_id}.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.DataprocMetastore.v1alpha.Data.MetadataImport body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new MetadataImport in a given project and location.</summary>
                    public class CreateRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.MetadataImport body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The relative resource name of the service in which to create a metastore import,
                        /// in the following
                        /// form:projects/{project_number}/locations/{location_id}/services/{service_id}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID of the metadata import, which is used as the final component of the
                        /// metadata import's name.This value must be between 1 and 64 characters long, begin with a
                        /// letter, end with a letter or number, and consist of alpha-numeric ASCII characters or
                        /// hyphens.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("metadataImportId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string MetadataImportId { get; set; }

                        /// <summary>
                        /// Optional. A request ID. Specify a unique request ID to allow the server to ignore the
                        /// request if it has completed. The server will ignore subsequent requests that provide a
                        /// duplicate request ID for at least 60 minutes after the first request.For example, if an
                        /// initial request times out, followed by another request with the same request ID, the server
                        /// ignores the second request to prevent the creation of duplicate commitments.The request ID
                        /// must be a valid UUID (https://en.wikipedia.org/wiki/Universally_unique_identifier#Format) A
                        /// zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataprocMetastore.v1alpha.Data.MetadataImport Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/metadataImports";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                            });
                            RequestParameters.Add("metadataImportId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "metadataImportId",
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

                    /// <summary>Gets details of a single import.</summary>
                    /// <param name="name">
                    /// Required. The relative resource name of the metadata import to retrieve, in the following
                    /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/metadataImports/{import_id}.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a single import.</summary>
                    public class GetRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.MetadataImport>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The relative resource name of the metadata import to retrieve, in the following
                        /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/metadataImports/{import_id}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+/metadataImports/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists imports in a service.</summary>
                    /// <param name="parent">
                    /// Required. The relative resource name of the service whose metadata imports to list, in the
                    /// following
                    /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/metadataImports.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists imports in a service.</summary>
                    public class ListRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.ListMetadataImportsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The relative resource name of the service whose metadata imports to list, in the
                        /// following
                        /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/metadataImports.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. The filter to apply to list results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Specify the ordering of results as described in Sorting Order
                        /// (https://cloud.google.com/apis/design/design_patterns#sorting_order). If not specified, the
                        /// results will be sorted in the default order.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of imports to return. The response may contain less than the
                        /// maximum number. If unspecified, no more than 500 imports are returned. The maximum value is
                        /// 1000; values above 1000 are changed to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous DataprocMetastore.ListServices call.
                        /// Provide this token to retrieve the subsequent page.To retrieve the first page, supply an
                        /// empty page token.When paginating, other parameters provided to
                        /// DataprocMetastore.ListServices must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/metadataImports";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
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
                    /// Updates a single import. Only the description field of MetadataImport is supported to be
                    /// updated.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Immutable. Identifier. The relative resource name of the metadata import, of the
                    /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/metadataImports/{metadata_import_id}.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.DataprocMetastore.v1alpha.Data.MetadataImport body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Updates a single import. Only the description field of MetadataImport is supported to be
                    /// updated.
                    /// </summary>
                    public class PatchRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.MetadataImport body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Immutable. Identifier. The relative resource name of the metadata import, of the
                        /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/metadataImports/{metadata_import_id}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. A request ID. Specify a unique request ID to allow the server to ignore the
                        /// request if it has completed. The server will ignore subsequent requests that provide a
                        /// duplicate request ID for at least 60 minutes after the first request.For example, if an
                        /// initial request times out, followed by another request with the same request ID, the server
                        /// ignores the second request to prevent the creation of duplicate commitments.The request ID
                        /// must be a valid UUID (https://en.wikipedia.org/wiki/Universally_unique_identifier#Format) A
                        /// zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>
                        /// Required. A field mask used to specify the fields to be overwritten in the metadata import
                        /// resource by the update. Fields specified in the update_mask are relative to the resource
                        /// (not to the full request). A field is overwritten if it is in the mask.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataprocMetastore.v1alpha.Data.MetadataImport Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+/metadataImports/[^/]+$",
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
                }

                /// <summary>Gets the MigrationExecutions resource.</summary>
                public virtual MigrationExecutionsResource MigrationExecutions { get; }

                /// <summary>The "migrationExecutions" collection of methods.</summary>
                public class MigrationExecutionsResource
                {
                    private const string Resource = "migrationExecutions";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public MigrationExecutionsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Deletes a single migration execution.</summary>
                    /// <param name="name">
                    /// Required. The relative resource name of the migrationExecution to delete, in the following
                    /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/migrationExecutions/{migration_execution_id}.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a single migration execution.</summary>
                    public class DeleteRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The relative resource name of the migrationExecution to delete, in the following
                        /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/migrationExecutions/{migration_execution_id}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. A request ID. Specify a unique request ID to allow the server to ignore the
                        /// request if it has completed. The server will ignore subsequent requests that provide a
                        /// duplicate request ID for at least 60 minutes after the first request.For example, if an
                        /// initial request times out, followed by another request with the same request ID, the server
                        /// ignores the second request to prevent the creation of duplicate commitments.The request ID
                        /// must be a valid UUID (https://en.wikipedia.org/wiki/Universally_unique_identifier#Format) A
                        /// zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+/migrationExecutions/[^/]+$",
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

                    /// <summary>Gets details of a single migration execution.</summary>
                    /// <param name="name">
                    /// Required. The relative resource name of the migration execution to retrieve, in the following
                    /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/migrationExecutions/{migration_execution_id}.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a single migration execution.</summary>
                    public class GetRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.MigrationExecution>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The relative resource name of the migration execution to retrieve, in the
                        /// following
                        /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/migrationExecutions/{migration_execution_id}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+/migrationExecutions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists migration executions on a service.</summary>
                    /// <param name="parent">
                    /// Required. The relative resource name of the service whose migration executions to list, in the
                    /// following
                    /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/migrationExecutions.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists migration executions on a service.</summary>
                    public class ListRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.ListMigrationExecutionsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The relative resource name of the service whose migration executions to list, in
                        /// the following
                        /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/migrationExecutions.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. The filter to apply to list results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Specify the ordering of results as described in Sorting Order
                        /// (https://cloud.google.com/apis/design/design_patterns#sorting_order). If not specified, the
                        /// results will be sorted in the default order.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of migration executions to return. The response may contain
                        /// less than the maximum number. If unspecified, no more than 500 migration executions are
                        /// returned. The maximum value is 1000; values above 1000 are changed to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous DataprocMetastore.ListMigrationExecutions
                        /// call. Provide this token to retrieve the subsequent page.To retrieve the first page, supply
                        /// an empty page token.When paginating, other parameters provided to
                        /// DataprocMetastore.ListMigrationExecutions must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/migrationExecutions";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
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
                }

                /// <summary>
                /// Alter metadata resource location. The metadata resource can be a database, table, or partition. This
                /// functionality only updates the parent directory for the respective metadata resource and does not
                /// transfer any existing data to the new location.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="service">
                /// Required. The relative resource name of the metastore service to mutate metadata, in the following
                /// format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                /// </param>
                public virtual AlterLocationRequest AlterLocation(Google.Apis.DataprocMetastore.v1alpha.Data.AlterMetadataResourceLocationRequest body, string service)
                {
                    return new AlterLocationRequest(this.service, body, service);
                }

                /// <summary>
                /// Alter metadata resource location. The metadata resource can be a database, table, or partition. This
                /// functionality only updates the parent directory for the respective metadata resource and does not
                /// transfer any existing data to the new location.
                /// </summary>
                public class AlterLocationRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new AlterLocation request.</summary>
                    public AlterLocationRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.AlterMetadataResourceLocationRequest body, string service_) : base(service)
                    {
                        Service_ = service_;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the metastore service to mutate metadata, in the
                    /// following format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("service", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Service_ { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v1alpha.Data.AlterMetadataResourceLocationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "alterLocation";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+service}:alterLocation";

                    /// <summary>Initializes AlterLocation parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("service", new Google.Apis.Discovery.Parameter
                        {
                            Name = "service",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>Alter metadata table properties.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="service">
                /// Required. The relative resource name of the Dataproc Metastore service that's being used to mutate
                /// metadata table properties, in the following
                /// format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                /// </param>
                public virtual AlterTablePropertiesRequest AlterTableProperties(Google.Apis.DataprocMetastore.v1alpha.Data.AlterTablePropertiesRequest body, string service)
                {
                    return new AlterTablePropertiesRequest(this.service, body, service);
                }

                /// <summary>Alter metadata table properties.</summary>
                public class AlterTablePropertiesRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new AlterTableProperties request.</summary>
                    public AlterTablePropertiesRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.AlterTablePropertiesRequest body, string service_) : base(service)
                    {
                        Service_ = service_;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the Dataproc Metastore service that's being used to
                    /// mutate metadata table properties, in the following
                    /// format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("service", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Service_ { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v1alpha.Data.AlterTablePropertiesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "alterTableProperties";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+service}:alterTableProperties";

                    /// <summary>Initializes AlterTableProperties parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("service", new Google.Apis.Discovery.Parameter
                        {
                            Name = "service",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>Cancels the ongoing Managed Migration process.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="service">
                /// Required. The relative resource name of the metastore service to cancel the ongoing migration to, in
                /// the following format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                /// </param>
                public virtual CancelMigrationRequest CancelMigration(Google.Apis.DataprocMetastore.v1alpha.Data.CancelMigrationRequest body, string service)
                {
                    return new CancelMigrationRequest(this.service, body, service);
                }

                /// <summary>Cancels the ongoing Managed Migration process.</summary>
                public class CancelMigrationRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new CancelMigration request.</summary>
                    public CancelMigrationRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.CancelMigrationRequest body, string service_) : base(service)
                    {
                        Service_ = service_;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the metastore service to cancel the ongoing migration
                    /// to, in the following format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("service", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Service_ { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v1alpha.Data.CancelMigrationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancelMigration";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+service}:cancelMigration";

                    /// <summary>Initializes CancelMigration parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("service", new Google.Apis.Discovery.Parameter
                        {
                            Name = "service",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Completes the managed migration process. The Dataproc Metastore service will switch to using its own
                /// backend database after successful migration.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="service">
                /// Required. The relative resource name of the metastore service to complete the migration to, in the
                /// following format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                /// </param>
                public virtual CompleteMigrationRequest CompleteMigration(Google.Apis.DataprocMetastore.v1alpha.Data.CompleteMigrationRequest body, string service)
                {
                    return new CompleteMigrationRequest(this.service, body, service);
                }

                /// <summary>
                /// Completes the managed migration process. The Dataproc Metastore service will switch to using its own
                /// backend database after successful migration.
                /// </summary>
                public class CompleteMigrationRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new CompleteMigration request.</summary>
                    public CompleteMigrationRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.CompleteMigrationRequest body, string service_) : base(service)
                    {
                        Service_ = service_;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the metastore service to complete the migration to, in
                    /// the following format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("service", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Service_ { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v1alpha.Data.CompleteMigrationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "completeMigration";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+service}:completeMigration";

                    /// <summary>Initializes CompleteMigration parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("service", new Google.Apis.Discovery.Parameter
                        {
                            Name = "service",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>Creates a metastore service in a project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The relative resource name of the location in which to create a metastore service, in the
                /// following form:projects/{project_number}/locations/{location_id}.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DataprocMetastore.v1alpha.Data.Service body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a metastore service in a project and location.</summary>
                public class CreateRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.Service body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the location in which to create a metastore service, in
                    /// the following form:projects/{project_number}/locations/{location_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. A request ID. Specify a unique request ID to allow the server to ignore the request if
                    /// it has completed. The server will ignore subsequent requests that provide a duplicate request ID
                    /// for at least 60 minutes after the first request.For example, if an initial request times out,
                    /// followed by another request with the same request ID, the server ignores the second request to
                    /// prevent the creation of duplicate commitments.The request ID must be a valid UUID
                    /// (https://en.wikipedia.org/wiki/Universally_unique_identifier#Format) A zero UUID
                    /// (00000000-0000-0000-0000-000000000000) is not supported.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. The ID of the metastore service, which is used as the final component of the metastore
                    /// service's name.This value must be between 2 and 63 characters long inclusive, begin with a
                    /// letter, end with a letter or number, and consist of alpha-numeric ASCII characters or hyphens.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("serviceId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ServiceId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v1alpha.Data.Service Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/services";

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
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("serviceId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "serviceId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single service.</summary>
                /// <param name="name">
                /// Required. The relative resource name of the metastore service to delete, in the following
                /// form:projects/{project_number}/locations/{location_id}/services/{service_id}.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single service.</summary>
                public class DeleteRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the metastore service to delete, in the following
                    /// form:projects/{project_number}/locations/{location_id}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A request ID. Specify a unique request ID to allow the server to ignore the request if
                    /// it has completed. The server will ignore subsequent requests that provide a duplicate request ID
                    /// for at least 60 minutes after the first request.For example, if an initial request times out,
                    /// followed by another request with the same request ID, the server ignores the second request to
                    /// prevent the creation of duplicate commitments.The request ID must be a valid UUID
                    /// (https://en.wikipedia.org/wiki/Universally_unique_identifier#Format) A zero UUID
                    /// (00000000-0000-0000-0000-000000000000) is not supported.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
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

                /// <summary>Exports metadata from a service.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="service">
                /// Required. The relative resource name of the metastore service to run export, in the following
                /// form:projects/{project_id}/locations/{location_id}/services/{service_id}.
                /// </param>
                public virtual ExportMetadataRequest ExportMetadata(Google.Apis.DataprocMetastore.v1alpha.Data.ExportMetadataRequest body, string service)
                {
                    return new ExportMetadataRequest(this.service, body, service);
                }

                /// <summary>Exports metadata from a service.</summary>
                public class ExportMetadataRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new ExportMetadata request.</summary>
                    public ExportMetadataRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.ExportMetadataRequest body, string service_) : base(service)
                    {
                        Service_ = service_;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the metastore service to run export, in the following
                    /// form:projects/{project_id}/locations/{location_id}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("service", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Service_ { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v1alpha.Data.ExportMetadataRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "exportMetadata";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+service}:exportMetadata";

                    /// <summary>Initializes ExportMetadata parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("service", new Google.Apis.Discovery.Parameter
                        {
                            Name = "service",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets the details of a single service.</summary>
                /// <param name="name">
                /// Required. The relative resource name of the metastore service to retrieve, in the following
                /// form:projects/{project_number}/locations/{location_id}/services/{service_id}.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets the details of a single service.</summary>
                public class GetRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Service>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the metastore service to retrieve, in the following
                    /// form:projects/{project_number}/locations/{location_id}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See Resource names
                /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(this.service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                    {
                        Resource = resource;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See Resource names
                    /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>
                    /// Optional. The maximum policy version that will be used to format the policy.Valid values are 0,
                    /// 1, and 3. Requests specifying an invalid value will be rejected.Requests for policies with any
                    /// conditional role bindings must specify version 3. Policies with no conditional role bindings may
                    /// specify any valid value or leave the field unset.The policy in the response might use the policy
                    /// version that you specified, or it might use a lower policy version. For example, if you specify
                    /// version 3, but the policy has no conditional role bindings, the response uses version 1.To learn
                    /// which resources support conditions in their IAM policies, see the IAM documentation
                    /// (https://cloud.google.com/iam/help/conditions/resource-policies).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+resource}:getIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
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

                /// <summary>Lists services in a project and location.</summary>
                /// <param name="parent">
                /// Required. The relative resource name of the location of metastore services to list, in the following
                /// form:projects/{project_number}/locations/{location_id}.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists services in a project and location.</summary>
                public class ListRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.ListServicesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the location of metastore services to list, in the
                    /// following form:projects/{project_number}/locations/{location_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. The filter to apply to list results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. Specify the ordering of results as described in Sorting Order
                    /// (https://cloud.google.com/apis/design/design_patterns#sorting_order). If not specified, the
                    /// results will be sorted in the default order.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of services to return. The response may contain less than the
                    /// maximum number. If unspecified, no more than 500 services are returned. The maximum value is
                    /// 1000; values above 1000 are changed to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous DataprocMetastore.ListServices call. Provide
                    /// this token to retrieve the subsequent page.To retrieve the first page, supply an empty page
                    /// token.When paginating, other parameters provided to DataprocMetastore.ListServices must match
                    /// the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/services";

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

                /// <summary>Move a table to another database.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="service">
                /// Required. The relative resource name of the metastore service to mutate metadata, in the following
                /// format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                /// </param>
                public virtual MoveTableToDatabaseRequest MoveTableToDatabase(Google.Apis.DataprocMetastore.v1alpha.Data.MoveTableToDatabaseRequest body, string service)
                {
                    return new MoveTableToDatabaseRequest(this.service, body, service);
                }

                /// <summary>Move a table to another database.</summary>
                public class MoveTableToDatabaseRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new MoveTableToDatabase request.</summary>
                    public MoveTableToDatabaseRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.MoveTableToDatabaseRequest body, string service_) : base(service)
                    {
                        Service_ = service_;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the metastore service to mutate metadata, in the
                    /// following format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("service", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Service_ { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v1alpha.Data.MoveTableToDatabaseRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "moveTableToDatabase";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+service}:moveTableToDatabase";

                    /// <summary>Initializes MoveTableToDatabase parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("service", new Google.Apis.Discovery.Parameter
                        {
                            Name = "service",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>Updates the parameters of a single service.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Immutable. Identifier. The relative resource name of the metastore service, in the following
                /// format:projects/{project_number}/locations/{location_id}/services/{service_id}.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.DataprocMetastore.v1alpha.Data.Service body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single service.</summary>
                public class PatchRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.Service body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Immutable. Identifier. The relative resource name of the metastore service, in the following
                    /// format:projects/{project_number}/locations/{location_id}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A request ID. Specify a unique request ID to allow the server to ignore the request if
                    /// it has completed. The server will ignore subsequent requests that provide a duplicate request ID
                    /// for at least 60 minutes after the first request.For example, if an initial request times out,
                    /// followed by another request with the same request ID, the server ignores the second request to
                    /// prevent the creation of duplicate commitments.The request ID must be a valid UUID
                    /// (https://en.wikipedia.org/wiki/Universally_unique_identifier#Format) A zero UUID
                    /// (00000000-0000-0000-0000-000000000000) is not supported.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. A field mask used to specify the fields to be overwritten in the metastore service
                    /// resource by the update. Fields specified in the update_mask are relative to the resource (not to
                    /// the full request). A field is overwritten if it is in the mask.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v1alpha.Data.Service Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
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

                /// <summary>Query Dataproc Metastore metadata.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="service">
                /// Required. The relative resource name of the metastore service to query metadata, in the following
                /// format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                /// </param>
                public virtual QueryMetadataRequest QueryMetadata(Google.Apis.DataprocMetastore.v1alpha.Data.QueryMetadataRequest body, string service)
                {
                    return new QueryMetadataRequest(this.service, body, service);
                }

                /// <summary>Query Dataproc Metastore metadata.</summary>
                public class QueryMetadataRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new QueryMetadata request.</summary>
                    public QueryMetadataRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.QueryMetadataRequest body, string service_) : base(service)
                    {
                        Service_ = service_;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the metastore service to query metadata, in the
                    /// following format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("service", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Service_ { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v1alpha.Data.QueryMetadataRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "queryMetadata";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+service}:queryMetadata";

                    /// <summary>Initializes QueryMetadata parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("service", new Google.Apis.Discovery.Parameter
                        {
                            Name = "service",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>Removes the attached IAM policies for a resource</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// Required. The relative resource name of the dataplane resource to remove IAM policy, in the
                /// following
                /// form:projects/{project_id}/locations/{location_id}/services/{service_id}/databases/{database_id} or
                /// projects/{project_id}/locations/{location_id}/services/{service_id}/databases/{database_id}/tables/{table_id}.
                /// </param>
                public virtual RemoveIamPolicyRequest RemoveIamPolicy(Google.Apis.DataprocMetastore.v1alpha.Data.RemoveIamPolicyRequest body, string resource)
                {
                    return new RemoveIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>Removes the attached IAM policies for a resource</summary>
                public class RemoveIamPolicyRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.RemoveIamPolicyResponse>
                {
                    /// <summary>Constructs a new RemoveIamPolicy request.</summary>
                    public RemoveIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.RemoveIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the dataplane resource to remove IAM policy, in the
                    /// following
                    /// form:projects/{project_id}/locations/{location_id}/services/{service_id}/databases/{database_id}
                    /// or
                    /// projects/{project_id}/locations/{location_id}/services/{service_id}/databases/{database_id}/tables/{table_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v1alpha.Data.RemoveIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "removeIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+resource}:removeIamPolicy";

                    /// <summary>Initializes RemoveIamPolicy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+/.*$",
                        });
                    }
                }

                /// <summary>Restores a service from a backup.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="service">
                /// Required. The relative resource name of the metastore service to run restore, in the following
                /// form:projects/{project_id}/locations/{location_id}/services/{service_id}.
                /// </param>
                public virtual RestoreRequest Restore(Google.Apis.DataprocMetastore.v1alpha.Data.RestoreServiceRequest body, string service)
                {
                    return new RestoreRequest(this.service, body, service);
                }

                /// <summary>Restores a service from a backup.</summary>
                public class RestoreRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Restore request.</summary>
                    public RestoreRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.RestoreServiceRequest body, string service_) : base(service)
                    {
                        Service_ = service_;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the metastore service to run restore, in the following
                    /// form:projects/{project_id}/locations/{location_id}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("service", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Service_ { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v1alpha.Data.RestoreServiceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "restore";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+service}:restore";

                    /// <summary>Initializes Restore parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("service", new Google.Apis.Discovery.Parameter
                        {
                            Name = "service",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy.Can return
                /// NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See Resource names
                /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.DataprocMetastore.v1alpha.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy.Can return
                /// NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                /// </summary>
                public class SetIamPolicyRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.SetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being specified. See Resource names
                    /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v1alpha.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+resource}:setIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>Starts the Managed Migration process.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="service">
                /// Required. The relative resource name of the metastore service to start migrating to, in the
                /// following format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                /// </param>
                public virtual StartMigrationRequest StartMigration(Google.Apis.DataprocMetastore.v1alpha.Data.StartMigrationRequest body, string service)
                {
                    return new StartMigrationRequest(this.service, body, service);
                }

                /// <summary>Starts the Managed Migration process.</summary>
                public class StartMigrationRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new StartMigration request.</summary>
                    public StartMigrationRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.StartMigrationRequest body, string service_) : base(service)
                    {
                        Service_ = service_;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the metastore service to start migrating to, in the
                    /// following format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("service", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Service_ { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v1alpha.Data.StartMigrationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "startMigration";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+service}:startMigration";

                    /// <summary>Initializes StartMigration parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("service", new Google.Apis.Discovery.Parameter
                        {
                            Name = "service",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a NOT_FOUND error.Note: This operation is designed
                /// to be used for building permission-aware UIs and command-line tools, not for authorization checking.
                /// This operation may "fail open" without warning.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See Resource names
                /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.DataprocMetastore.v1alpha.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a NOT_FOUND error.Note: This operation is designed
                /// to be used for building permission-aware UIs and command-line tools, not for authorization checking.
                /// This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v1alpha.Data.TestIamPermissionsRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy detail is being requested. See Resource names
                    /// (https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v1alpha.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+resource}:testIamPermissions";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
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
            public class GetRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.Location>
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
                public override string RestPath => "v1alpha/{+name}";

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
            public class ListRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v1alpha.Data.ListLocationsResponse>
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
                /// Optional. Do not use this field. It is unsupported and is ignored unless explicitly documented
                /// otherwise. This is primarily for internal usage.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("extraLocationTypes", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> ExtraLocationTypes { get; set; }

                /// <summary>
                /// A filter to narrow down results to a preferred subset. The filtering language accepts strings like
                /// "displayName=tokyo", and is documented in more detail in AIP-160 (https://google.aip.dev/160).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// The maximum number of results to return. If not set, the service selects a default.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token received from the next_page_token field in the response. Send that page token to
                /// receive the subsequent page.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}/locations";

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
                    RequestParameters.Add("extraLocationTypes", new Google.Apis.Discovery.Parameter
                    {
                        Name = "extraLocationTypes",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
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
namespace Google.Apis.DataprocMetastore.v1alpha.Data
{
    /// <summary>Request message for DataprocMetastore.AlterMetadataResourceLocation.</summary>
    public class AlterMetadataResourceLocationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The new location URI for the metadata resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationUri")]
        public virtual string LocationUri { get; set; }

        /// <summary>
        /// Required. The relative metadata resource name in the following format.databases/{database_id} or
        /// databases/{database_id}/tables/{table_id} or
        /// databases/{database_id}/tables/{table_id}/partitions/{partition_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DataprocMetastore.AlterMetadataResourceLocation.</summary>
    public class AlterMetadataResourceLocationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DataprocMetastore.AlterTableProperties.</summary>
    public class AlterTablePropertiesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A map that describes the desired values to mutate. If update_mask is empty, the properties will not update.
        /// Otherwise, the properties only alters the value whose associated paths exist in the update mask
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Required. The name of the table containing the properties you're altering in the following
        /// format.databases/{database_id}/tables/{table_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableName")]
        public virtual string TableName { get; set; }

        /// <summary>
        /// A field mask that specifies the metadata table properties that are overwritten by the update. Fields
        /// specified in the update_mask are relative to the resource (not to the full request). A field is overwritten
        /// if it is in the mask.For example, given the target properties: properties { a: 1 b: 2 } And an update
        /// properties: properties { a: 2 b: 3 c: 4 } then if the field mask is:paths: "properties.b",
        /// "properties.c"then the result will be: properties { a: 1 b: 3 c: 4 }
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies the audit configuration for a service. The configuration determines which permission types are logged,
    /// and what identities, if any, are exempted from logging. An AuditConfig must have one or more AuditLogConfigs.If
    /// there are AuditConfigs for both allServices and a specific service, the union of the two AuditConfigs is used
    /// for that service: the log_types specified in each AuditConfig are enabled, and the exempted_members in each
    /// AuditLogConfig are exempted.Example Policy with multiple AuditConfigs: { "audit_configs": [ { "service":
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
        /// Specifies a service that will be enabled for audit logging. For example, storage.googleapis.com,
        /// cloudsql.googleapis.com. allServices is a special value that covers all services.
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

    /// <summary>Represents the autoscaling configuration of a metastore service.</summary>
    public class AutoscalingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Whether or not autoscaling is enabled for this service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoscalingEnabled")]
        public virtual System.Nullable<bool> AutoscalingEnabled { get; set; }

        /// <summary>Output only. The scaling factor of a service with autoscaling enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoscalingFactor")]
        public virtual System.Nullable<float> AutoscalingFactor { get; set; }

        /// <summary>Optional. The LimitConfig of the service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limitConfig")]
        public virtual LimitConfig LimitConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration information for the auxiliary service versions.</summary>
    public class AuxiliaryVersionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A mapping of Hive metastore configuration key-value pairs to apply to the auxiliary Hive metastore
        /// (configured in hive-site.xml) in addition to the primary version's overrides. If keys are present in both
        /// the auxiliary version's overrides and the primary version's overrides, the value from the auxiliary
        /// version's overrides takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configOverrides")]
        public virtual System.Collections.Generic.IDictionary<string, string> ConfigOverrides { get; set; }

        /// <summary>
        /// Output only. The network configuration contains the endpoint URI(s) of the auxiliary Hive metastore service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkConfig")]
        public virtual NetworkConfig NetworkConfig { get; set; }

        /// <summary>
        /// Optional. The Hive metastore version of the auxiliary service. It must be less than the primary Hive
        /// metastore service's version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a backend metastore for the federation.</summary>
    public class BackendMetastore : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of the backend metastore.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metastoreType")]
        public virtual string MetastoreType { get; set; }

        /// <summary>
        /// The relative resource name of the metastore that is being federated. The formats of the relative resource
        /// names for the currently supported metastores are listed below: BigQuery projects/{project_id} Dataproc
        /// Metastore projects/{project_id}/locations/{location}/services/{service_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The details of a backup resource.</summary>
    public class Backup : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the backup was started.</summary>
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

        /// <summary>Optional. The description of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. The time when the backup finished creating.</summary>
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
        /// Immutable. Identifier. The relative resource name of the backup, in the following
        /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Services that are restoring from the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restoringServices")]
        public virtual System.Collections.Generic.IList<string> RestoringServices { get; set; }

        /// <summary>Output only. The revision of the service at the time of backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceRevision")]
        public virtual Service ServiceRevision { get; set; }

        /// <summary>Output only. The current state of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Associates members, or principals, with a role.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding.If the condition evaluates to true, then this binding
        /// applies to the current request.If the condition evaluates to false, then this binding does not apply to the
        /// current request. However, a different role binding might grant the same role to one or more of the
        /// principals in this binding.To learn which resources support conditions in their IAM policies, see the IAM
        /// documentation (https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// Specifies the principals requesting access for a Google Cloud resource. members can have the following
        /// values: allUsers: A special identifier that represents anyone who is on the internet; with or without a
        /// Google account. allAuthenticatedUsers: A special identifier that represents anyone who is authenticated with
        /// a Google account or a service account. Does not include identities that come from external identity
        /// providers (IdPs) through identity federation. user:{emailid}: An email address that represents a specific
        /// Google account. For example, alice@example.com . serviceAccount:{emailid}: An email address that represents
        /// a Google service account. For example, my-other-app@appspot.gserviceaccount.com.
        /// serviceAccount:{projectid}.svc.id.goog[{namespace}/{kubernetes-sa}]: An identifier for a Kubernetes service
        /// account (https://cloud.google.com/kubernetes-engine/docs/how-to/kubernetes-service-accounts). For example,
        /// my-project.svc.id.goog[my-namespace/my-kubernetes-sa]. group:{emailid}: An email address that represents a
        /// Google group. For example, admins@example.com. domain:{domain}: The G Suite domain (primary) that represents
        /// all the users of that domain. For example, google.com or example.com.
        /// principal://iam.googleapis.com/locations/global/workforcePools/{pool_id}/subject/{subject_attribute_value}:
        /// A single identity in a workforce identity pool.
        /// principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/group/{group_id}: All workforce
        /// identities in a group.
        /// principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/attribute.{attribute_name}/{attribute_value}:
        /// All workforce identities with a specific attribute value.
        /// principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/*: All identities in a workforce
        /// identity pool.
        /// principal://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/subject/{subject_attribute_value}:
        /// A single identity in a workload identity pool.
        /// principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/group/{group_id}:
        /// A workload identity pool group.
        /// principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/attribute.{attribute_name}/{attribute_value}:
        /// All identities in a workload identity pool with a certain attribute.
        /// principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/*:
        /// All identities in a workload identity pool. deleted:user:{emailid}?uid={uniqueid}: An email address (plus
        /// unique identifier) representing a user that has been recently deleted. For example,
        /// alice@example.com?uid=123456789012345678901. If the user is recovered, this value reverts to user:{emailid}
        /// and the recovered user retains the role in the binding. deleted:serviceAccount:{emailid}?uid={uniqueid}: An
        /// email address (plus unique identifier) representing a service account that has been recently deleted. For
        /// example, my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901. If the service account is
        /// undeleted, this value reverts to serviceAccount:{emailid} and the undeleted service account retains the role
        /// in the binding. deleted:group:{emailid}?uid={uniqueid}: An email address (plus unique identifier)
        /// representing a Google group that has been recently deleted. For example,
        /// admins@example.com?uid=123456789012345678901. If the group is recovered, this value reverts to
        /// group:{emailid} and the recovered group retains the role in the binding.
        /// deleted:principal://iam.googleapis.com/locations/global/workforcePools/{pool_id}/subject/{subject_attribute_value}:
        /// Deleted single identity in a workforce identity pool. For example,
        /// deleted:principal://iam.googleapis.com/locations/global/workforcePools/my-pool-id/subject/my-subject-attribute-value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Role that is assigned to the list of members, or principals. For example, roles/viewer, roles/editor, or
        /// roles/owner.For an overview of the IAM roles and permissions, see the IAM documentation
        /// (https://cloud.google.com/iam/docs/roles-overview). For a list of the available pre-defined roles, see here
        /// (https://cloud.google.com/iam/docs/understanding-roles).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DataprocMetastore.CancelMigration.</summary>
    public class CancelMigrationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DataprocMetastore.CancelMigration.</summary>
    public class CancelMigrationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The relative resource name of the migration execution, in the following
        /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/migrationExecutions/{migration_execution_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migrationExecution")]
        public virtual string MigrationExecution { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration information to start the Change Data Capture (CDC) streams from customer database to backend
    /// database of Dataproc Metastore.
    /// </summary>
    public class CdcConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The bucket to write the intermediate stream event data in. The bucket name must be without any
        /// prefix like "gs://". See the bucket naming requirements
        /// (https://cloud.google.com/storage/docs/buckets#naming). This field is optional. If not set, the Artifacts
        /// Cloud Storage bucket will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>
        /// Required. Input only. The password for the user that Datastream service should use for the MySQL connection.
        /// This field is not returned on request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>
        /// Required. The URL of the subnetwork resource to create the VM instance hosting the reverse proxy in. More
        /// context in https://cloud.google.com/datastream/docs/private-connectivity#reverse-csql-proxy The subnetwork
        /// should reside in the network provided in the request that Datastream will peer to and should be in the same
        /// region as Datastream, in the following format.
        /// projects/{project_id}/regions/{region_id}/subnetworks/{subnetwork_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reverseProxySubnet")]
        public virtual string ReverseProxySubnet { get; set; }

        /// <summary>
        /// Optional. The root path inside the Cloud Storage bucket. The stream event data will be written to this path.
        /// The default value is /migration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootPath")]
        public virtual string RootPath { get; set; }

        /// <summary>Required. A /29 CIDR IP range for peering with datastream.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetIpRange")]
        public virtual string SubnetIpRange { get; set; }

        /// <summary>Required. The username that the Datastream service should use for the MySQL connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>
        /// Required. Fully qualified name of the Cloud SQL instance's VPC network or the shared VPC network that
        /// Datastream will peer to, in the following format:
        /// projects/{project_id}/locations/global/networks/{network_id}. More context in
        /// https://cloud.google.com/datastream/docs/network-connectivity-options#privateconnectivity
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcNetwork")]
        public virtual string VpcNetwork { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration information to establish customer database connection before the cutover phase of migration
    /// </summary>
    public class CloudSQLConnectionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The hive database name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hiveDatabaseName")]
        public virtual string HiveDatabaseName { get; set; }

        /// <summary>Required. Cloud SQL database connection name (project_id:region:instance_name)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceConnectionName")]
        public virtual string InstanceConnectionName { get; set; }

        /// <summary>Required. The private IP address of the Cloud SQL instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>
        /// Required. The relative resource name of the subnetwork to be used for Private Service Connect. Note that
        /// this cannot be a regular subnet and is used only for NAT.
        /// (https://cloud.google.com/vpc/docs/about-vpc-hosted-services#psc-subnets) This subnet is used to publish the
        /// SOCKS5 proxy service. The subnet size must be at least /29 and it should reside in a network through which
        /// the Cloud SQL instance is accessible. The resource name should be in the format,
        /// projects/{project_id}/regions/{region_id}/subnetworks/{subnetwork_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("natSubnet")]
        public virtual string NatSubnet { get; set; }

        /// <summary>
        /// Required. Input only. The password for the user that Dataproc Metastore service will be using to connect to
        /// the database. This field is not returned on request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>Required. The network port of the database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>
        /// Required. The relative resource name of the subnetwork to deploy the SOCKS5 proxy service in. The subnetwork
        /// should reside in a network through which the Cloud SQL instance is accessible. The resource name should be
        /// in the format, projects/{project_id}/regions/{region_id}/subnetworks/{subnetwork_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proxySubnet")]
        public virtual string ProxySubnet { get; set; }

        /// <summary>
        /// Required. The username that Dataproc Metastore service will use to connect to the database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration information for migrating from self-managed hive metastore on Google Cloud using Cloud SQL as the
    /// backend database to Dataproc Metastore.
    /// </summary>
    public class CloudSQLMigrationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Configuration information to start the Change Data Capture (CDC) streams from customer database to
        /// backend database of Dataproc Metastore. Dataproc Metastore switches to using its backend database after the
        /// cutover phase of migration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cdcConfig")]
        public virtual CdcConfig CdcConfig { get; set; }

        /// <summary>
        /// Required. Configuration information to establish customer database connection before the cutover phase of
        /// migration
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudSqlConnectionConfig")]
        public virtual CloudSQLConnectionConfig CloudSqlConnectionConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DataprocMetastore.CompleteMigration.</summary>
    public class CompleteMigrationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DataprocMetastore.CompleteMigration.</summary>
    public class CompleteMigrationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The relative resource name of the migration execution, in the following
        /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/migrationExecutions/{migration_execution_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migrationExecution")]
        public virtual string MigrationExecution { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains information of the customer's network configurations.</summary>
    public class Consumer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The location of the endpoint URI. Format: projects/{project}/locations/{location}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointLocation")]
        public virtual string EndpointLocation { get; set; }

        /// <summary>Output only. The URI of the endpoint used to access the metastore service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointUri")]
        public virtual string EndpointUri { get; set; }

        /// <summary>
        /// Immutable. The subnetwork of the customer project from which an IP address is reserved and used as the
        /// Dataproc Metastore service's endpoint. It is accessible to hosts in the subnet and to all hosts in a subnet
        /// in the same region and same network. There must be at least one IP address available in the subnet's primary
        /// range. The subnet is specified in the following
        /// form:projects/{project_number}/regions/{region_id}/subnetworks/{subnetwork_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetwork")]
        public virtual string Subnetwork { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Deprecated: Use a single region service instead. Custom configuration used to specify regions that the metastore
    /// service runs in. Currently only supported in the us multi-region.
    /// </summary>
    public class CustomRegionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The list of read-only regions where the metastore service runs in. These regions should be part
        /// (or subset) of the multi-region.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readOnlyRegions")]
        public virtual System.Collections.Generic.IList<string> ReadOnlyRegions { get; set; }

        /// <summary>
        /// Required. The list of read-write regions where the metastore service runs in. These regions should be part
        /// (or subset) of the multi-region.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readWriteRegions")]
        public virtual System.Collections.Generic.IList<string> ReadWriteRegions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Deprecated: Use a single region service instead. Metadata about a custom region. This is only populated if the
    /// region is a custom region. For single/multi regions, it will be empty.
    /// </summary>
    public class CustomRegionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The read-only regions for this custom region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optionalReadOnlyRegions")]
        public virtual System.Collections.Generic.IList<string> OptionalReadOnlyRegions { get; set; }

        /// <summary>The read-write regions for this custom region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiredReadWriteRegions")]
        public virtual System.Collections.Generic.IList<string> RequiredReadWriteRegions { get; set; }

        /// <summary>The Spanner witness region for this custom region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("witnessRegion")]
        public virtual string WitnessRegion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies how metastore metadata should be integrated with the Data Catalog service.</summary>
    public class DataCatalogConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Defines whether the metastore metadata should be synced to Data Catalog. The default value is to
        /// disable syncing metastore metadata to Data Catalog.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A specification of the location of and metadata about a database dump from a relational database management
    /// system.
    /// </summary>
    public class DatabaseDump : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of the database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseType")]
        public virtual string DatabaseType { get; set; }

        /// <summary>
        /// Optional. A Cloud Storage object or folder URI that specifies the source from which to import metadata. It
        /// must begin with gs://.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsUri")]
        public virtual string GcsUri { get; set; }

        /// <summary>Optional. The name of the source database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceDatabase")]
        public virtual string SourceDatabase { get; set; }

        /// <summary>Optional. The type of the database dump. If unspecified, defaults to MYSQL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies how metastore metadata should be integrated with the Dataplex service.</summary>
    public class DataplexConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A reference to the Lake resources that this metastore service is attached to. The key is the lake
        /// resource name. Example: projects/{project_number}/locations/{location_id}/lakes/{lake_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lakeResources")]
        public virtual System.Collections.Generic.IDictionary<string, Lake> LakeResources { get; set; }

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

    /// <summary>Encryption settings for the service.</summary>
    public class EncryptionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The fully qualified customer provided Cloud KMS key name to use for customer data encryption, in
        /// the following
        /// format:projects/{project_number}/locations/{location_id}/keyRings/{key_ring_id}/cryptoKeys/{crypto_key_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKey")]
        public virtual string KmsKey { get; set; }

        /// <summary>
        /// Optional. The list of fully qualified customer provided Cloud KMS key names for the multi-regional service.
        /// Each key must be in the following
        /// format:projects/{project_number}/locations/{location_id}/keyRings/{key_ring_id}/cryptoKeys/{crypto_key_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeys")]
        public virtual System.Collections.Generic.IList<string> KmsKeys { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Error details in public error message for DataprocMetastore.QueryMetadata.</summary>
    public class ErrorDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Additional structured details about this error.Keys define the failure items. Value describes the exception
        /// or details of the item.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IDictionary<string, string> Details { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DataprocMetastore.ExportMetadata.</summary>
    public class ExportMetadataRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The type of the database dump. If unspecified, defaults to MYSQL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseDumpType")]
        public virtual string DatabaseDumpType { get; set; }

        /// <summary>
        /// A Cloud Storage URI of a folder, in the format gs:///. A sub-folder containing exported files will be
        /// created below it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationGcsFolder")]
        public virtual string DestinationGcsFolder { get; set; }

        /// <summary>
        /// Optional. A request ID. Specify a unique request ID to allow the server to ignore the request if it has
        /// completed. The server will ignore subsequent requests that provide a duplicate request ID for at least 60
        /// minutes after the first request.For example, if an initial request times out, followed by another request
        /// with the same request ID, the server ignores the second request to prevent the creation of duplicate
        /// commitments.The request ID must be a valid UUID
        /// (https://en.wikipedia.org/wiki/Universally_unique_identifier#Format). A zero UUID
        /// (00000000-0000-0000-0000-000000000000) is not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression
    /// language. The syntax and semantics of CEL are documented at https://github.com/google/cel-spec.Example
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

    /// <summary>Represents a federation of multiple backend metastores.</summary>
    public class Federation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A map from BackendMetastore rank to BackendMetastores from which the federation service serves metadata at
        /// query time. The map key represents the order in which BackendMetastores should be evaluated to resolve
        /// database names at query time and should be greater than or equal to zero. A BackendMetastore with a lower
        /// number will be evaluated before a BackendMetastore with a higher number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backendMetastores")]
        public virtual System.Collections.Generic.IDictionary<string, BackendMetastore> BackendMetastores { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the metastore federation was created.</summary>
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

        /// <summary>Output only. The federation endpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointUri")]
        public virtual string EndpointUri { get; set; }

        /// <summary>User-defined labels for the metastore federation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Immutable. The relative resource name of the federation, of the form:
        /// projects/{project_number}/locations/{location_id}/federations/{federation_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The current state of the federation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. Additional information about the current state of the metastore federation, if available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        /// <summary>
        /// Optional. Input only. Immutable. Tag keys/values directly bound to this resource. For example:
        /// "123/environment": "production", "123/costCenter": "marketing"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

        /// <summary>Output only. The globally unique resource identifier of the metastore federation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when the metastore federation was last updated.</summary>
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
        /// Immutable. The Apache Hive metastore version of the federation. All backend metastore versions must be
        /// compatible with the federation version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies configuration information specific to running Hive metastore software as the metastore service.
    /// </summary>
    public class HiveMetastoreConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A mapping of Hive metastore version to the auxiliary version configuration. When specified, a
        /// secondary Hive metastore service is created along with the primary service. All auxiliary versions must be
        /// less than the service's primary version. The key is the auxiliary service name and it must match the regular
        /// expression a-z?. This means that the first character must be a lowercase letter, and all the following
        /// characters must be hyphens, lowercase letters, or digits, except the last character, which cannot be a
        /// hyphen.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auxiliaryVersions")]
        public virtual System.Collections.Generic.IDictionary<string, AuxiliaryVersionConfig> AuxiliaryVersions { get; set; }

        /// <summary>
        /// Optional. A mapping of Hive metastore configuration key-value pairs to apply to the Hive metastore
        /// (configured in hive-site.xml). The mappings override system defaults (some keys cannot be overridden). These
        /// overrides are also applied to auxiliary versions and can be further customized in the auxiliary version's
        /// AuxiliaryVersionConfig.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configOverrides")]
        public virtual System.Collections.Generic.IDictionary<string, string> ConfigOverrides { get; set; }

        /// <summary>
        /// Optional. The protocol to use for the metastore service endpoint. If unspecified, defaults to THRIFT.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointProtocol")]
        public virtual string EndpointProtocol { get; set; }

        /// <summary>
        /// Optional. Information used to configure the Hive metastore service as a service principal in a Kerberos
        /// realm. To disable Kerberos, use the UpdateService method and specify this field's path
        /// (hive_metastore_config.kerberos_config) in the request's update_mask while omitting this field from the
        /// request's service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kerberosConfig")]
        public virtual KerberosConfig KerberosConfig { get; set; }

        /// <summary>Immutable. The Hive metastore schema version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A specification of a supported version of the Hive Metastore software.</summary>
    public class HiveMetastoreVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether version will be chosen by the server if a metastore service is created with a HiveMetastoreConfig
        /// that omits the version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDefault")]
        public virtual System.Nullable<bool> IsDefault { get; set; }

        /// <summary>The semantic version of the Hive Metastore software.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration information for a Kerberos principal.</summary>
    public class KerberosConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A Kerberos keytab file that can be used to authenticate a service principal with a Kerberos Key
        /// Distribution Center (KDC).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keytab")]
        public virtual Secret Keytab { get; set; }

        /// <summary>
        /// Optional. A Cloud Storage URI that specifies the path to a krb5.conf file. It is of the form
        /// gs://{bucket_name}/path/to/krb5.conf, although the file does not need to be named krb5.conf explicitly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("krb5ConfigGcsUri")]
        public virtual string Krb5ConfigGcsUri { get; set; }

        /// <summary>
        /// Optional. A Kerberos principal that exists in the both the keytab the KDC to authenticate as. A typical
        /// principal is of the form primary/instance@REALM, but there is no exact format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principal")]
        public virtual string Principal { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Lake resource</summary>
    public class Lake : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Lake resource name. Example: projects/{project_number}/locations/{location_id}/lakes/{lake_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The details of the latest scheduled backup.</summary>
    public class LatestBackup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The ID of an in-progress scheduled backup. Empty if no backup is in progress.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupId")]
        public virtual string BackupId { get; set; }

        /// <summary>Output only. The duration of the backup completion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. The time when the backup was started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTimeRaw
        {
            get => _startTimeRaw;
            set
            {
                _startTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _startTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StartTimeDateTimeOffset instead.")]
        public virtual object StartTime
        {
            get => _startTime;
            set
            {
                _startTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _startTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? StartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StartTimeRaw);
            set => StartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The current state of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the autoscaling limit configuration of a metastore service.</summary>
    public class LimitConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The highest scaling factor that the service should be autoscaled to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxScalingFactor")]
        public virtual System.Nullable<float> MaxScalingFactor { get; set; }

        /// <summary>Optional. The lowest scaling factor that the service should be autoscaled to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minScalingFactor")]
        public virtual System.Nullable<float> MinScalingFactor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DataprocMetastore.ListBackups.</summary>
    public class ListBackupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The backups of the specified service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backups")]
        public virtual System.Collections.Generic.IList<Backup> Backups { get; set; }

        /// <summary>
        /// A token that can be sent as page_token to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListFederations</summary>
    public class ListFederationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The services in the specified location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("federations")]
        public virtual System.Collections.Generic.IList<Federation> Federations { get; set; }

        /// <summary>
        /// A token that can be sent as page_token to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
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

    /// <summary>Response message for DataprocMetastore.ListMetadataImports.</summary>
    public class ListMetadataImportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The imports in the specified service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadataImports")]
        public virtual System.Collections.Generic.IList<MetadataImport> MetadataImports { get; set; }

        /// <summary>
        /// A token that can be sent as page_token to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DataprocMetastore.ListMigrationExecutions.</summary>
    public class ListMigrationExecutionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The migration executions on the specified service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migrationExecutions")]
        public virtual System.Collections.Generic.IList<MigrationExecution> MigrationExecutions { get; set; }

        /// <summary>
        /// A token that can be sent as page_token to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

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

        /// <summary>
        /// Unordered list. Unreachable resources. Populated when the request sets
        /// ListOperationsRequest.return_partial_success and reads across collections. For example, when attempting to
        /// list all resources across all supported locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DataprocMetastore.ListServices.</summary>
    public class ListServicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that can be sent as page_token to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The services in the specified location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("services")]
        public virtual System.Collections.Generic.IList<Service> Services { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

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

        /// <summary>The canonical id for this location. For example: "us-east1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>Service-specific metadata. For example the available capacity at the given location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// Resource name for the location, which may vary between implementations. For example:
        /// "projects/example-project/locations/us-east1"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about the service in a location.</summary>
    public class LocationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecated: Use a single region service instead. Possible configurations supported if the current region is
        /// a custom region.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customRegionMetadata")]
        public virtual System.Collections.Generic.IList<CustomRegionMetadata> CustomRegionMetadata { get; set; }

        /// <summary>
        /// Deprecated: Use a single region service instead. The multi-region metadata if the current region is a
        /// multi-region.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiRegionMetadata")]
        public virtual MultiRegionMetadata MultiRegionMetadata { get; set; }

        /// <summary>
        /// The versions of Hive Metastore that can be used when creating a new metastore service in this location. The
        /// server guarantees that exactly one HiveMetastoreVersion in the list will set is_default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedHiveMetastoreVersions")]
        public virtual System.Collections.Generic.IList<HiveMetastoreVersion> SupportedHiveMetastoreVersions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Maintenance window. This specifies when Dataproc Metastore may perform system maintenance operation to the
    /// service.
    /// </summary>
    public class MaintenanceWindow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The day of week, when the window starts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dayOfWeek")]
        public virtual string DayOfWeek { get; set; }

        /// <summary>Optional. The hour of day (0-23) when the window starts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hourOfDay")]
        public virtual System.Nullable<int> HourOfDay { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This is proto2's version of MessageSet.DEPRECATED: DO NOT USE FOR NEW FIELDS.If you are using editions or
    /// proto2, please make your own extendable messages for your use case. If you are using proto3, please use Any
    /// instead.MessageSet was the implementation of extensions for proto1. When proto2 was introduced, extensions were
    /// implemented as a first-class feature. This schema for MessageSet was meant to be a "bridge" solution to migrate
    /// MessageSet-bearing messages from proto1 to proto2.This schema has been open-sourced only to facilitate the
    /// migration of Google products with MessageSet-bearing messages to open-source environments.
    /// </summary>
    public class MessageSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The details of a metadata export operation.</summary>
    public class MetadataExport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The type of the database dump.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseDumpType")]
        public virtual string DatabaseDumpType { get; set; }

        /// <summary>
        /// Output only. A Cloud Storage URI of a folder that metadata are exported to, in the form of gs:////, where is
        /// automatically generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationGcsUri")]
        public virtual string DestinationGcsUri { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. The time when the export ended.</summary>
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

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. The time when the export started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTimeRaw
        {
            get => _startTimeRaw;
            set
            {
                _startTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _startTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StartTimeDateTimeOffset instead.")]
        public virtual object StartTime
        {
            get => _startTime;
            set
            {
                _startTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _startTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? StartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StartTimeRaw);
            set => StartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The current state of the export.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A metastore resource that imports metadata.</summary>
    public class MetadataImport : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the metadata import was started.</summary>
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

        /// <summary>Immutable. A database dump from a pre-existing metastore's database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseDump")]
        public virtual DatabaseDump DatabaseDump { get; set; }

        /// <summary>Optional. The description of the metadata import.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. The time when the metadata import finished.</summary>
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
        /// Immutable. Identifier. The relative resource name of the metadata import, of the
        /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/metadataImports/{metadata_import_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The current state of the metadata import.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when the metadata import was last updated.</summary>
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

    /// <summary>Specifies how metastore metadata should be integrated with external services.</summary>
    public class MetadataIntegration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The integration config for the Data Catalog service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataCatalogConfig")]
        public virtual DataCatalogConfig DataCatalogConfig { get; set; }

        /// <summary>Optional. The integration config for the Dataplex service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataplexConfig")]
        public virtual DataplexConfig DataplexConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata management activities of the metastore service.</summary>
    public class MetadataManagementActivity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The latest metadata exports of the metastore service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadataExports")]
        public virtual System.Collections.Generic.IList<MetadataExport> MetadataExports { get; set; }

        /// <summary>Output only. The latest restores of the metastore service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restores")]
        public virtual System.Collections.Generic.IList<Restore> Restores { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The details of a migration execution resource.</summary>
    public class MigrationExecution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Configuration information specific to migrating from self-managed hive metastore on Google Cloud using Cloud
        /// SQL as the backend database to Dataproc Metastore.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudSqlMigrationConfig")]
        public virtual CloudSQLMigrationConfig CloudSqlMigrationConfig { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the migration execution was started.</summary>
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

        /// <summary>Output only. The time when the migration execution finished.</summary>
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
        /// Output only. The relative resource name of the migration execution, in the following form:
        /// projects/{project_number}/locations/{location_id}/services/{service_id}/migrationExecutions/{migration_execution_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The current phase of the migration execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phase")]
        public virtual string Phase { get; set; }

        /// <summary>Output only. The current state of the migration execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Additional information about the current state of the migration execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DataprocMetastore.MoveTableToDatabase.</summary>
    public class MoveTableToDatabaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the database where the table resides.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbName")]
        public virtual string DbName { get; set; }

        /// <summary>Required. The name of the database where the table should be moved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationDbName")]
        public virtual string DestinationDbName { get; set; }

        /// <summary>Required. The name of the table to be moved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableName")]
        public virtual string TableName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DataprocMetastore.MoveTableToDatabase.</summary>
    public class MoveTableToDatabaseResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Deprecated: Use a single region service instead. The multi-region config for the Dataproc Metastore service.
    /// </summary>
    public class MultiRegionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Deprecated: Use a single region service instead. The list of root CA certificates that a gRPC
        /// client uses to connect to a multi-regional Dataproc Metastore service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificates")]
        public virtual System.Collections.Generic.IList<RootCACertificate> Certificates { get; set; }

        /// <summary>Immutable. Deprecated: Use a single region service instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customRegionConfig")]
        public virtual CustomRegionConfig CustomRegionConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Deprecated: Use a single region service instead. The metadata for the multi-region that includes the constituent
    /// regions. The metadata is only populated if the region is multi-region. For single region or custom dual region,
    /// it will be empty.
    /// </summary>
    public class MultiRegionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The regions constituting the multi-region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constituentRegions")]
        public virtual System.Collections.Generic.IList<string> ConstituentRegions { get; set; }

        /// <summary>The continent for this multi-region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("continent")]
        public virtual string Continent { get; set; }

        /// <summary>The Spanner witness region for this multi-region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("witnessRegion")]
        public virtual string WitnessRegion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Network configuration for the Dataproc Metastore service.</summary>
    public class NetworkConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. The consumer-side network configuration for the Dataproc Metastore instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumers")]
        public virtual System.Collections.Generic.IList<Consumer> Consumers { get; set; }

        /// <summary>
        /// Optional. Enables custom routes to be imported and exported for the Dataproc Metastore service's peered VPC
        /// network.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customRoutesEnabled")]
        public virtual System.Nullable<bool> CustomRoutesEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is false, it means the operation is still in progress. If true, the operation is completed, and
        /// either error or response is available.
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
        /// use the default HTTP mapping, the name should be a resource name ending with operations/{unique_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The normal, successful response of the operation. If the original method returns no data on success, such as
        /// Delete, the response is google.protobuf.Empty. If the original method is standard Get/Create/Update, the
        /// response should be the resource. For other methods, the response should have the type XxxResponse, where Xxx
        /// is the original method name. For example, if the original method name is TakeSnapshot(), the inferred
        /// response type is TakeSnapshotResponse.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the metadata of a long-running operation.</summary>
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
        /// Output only. Identifies whether the caller has requested cancellation of the operation. Operations that have
        /// successfully been cancelled have google.longrunning.Operation.error value with a google.rpc.Status.code of
        /// 1, corresponding to Code.CANCELLED.
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
    /// An Identity and Access Management (IAM) policy, which specifies access controls for Google Cloud resources.A
    /// Policy is a collection of bindings. A binding binds one or more members, or principals, to a single role.
    /// Principals can be user accounts, service accounts, Google groups, and domains (such as G Suite). A role is a
    /// named list of permissions; each role can be an IAM predefined role or a user-created custom role.For some types
    /// of Google Cloud resources, a binding can also specify a condition, which is a logical expression that allows
    /// access to a resource only if the expression evaluates to true. A condition can add constraints based on
    /// attributes of the request, the resource, or both. To learn which resources support conditions in their IAM
    /// policies, see the IAM documentation (https://cloud.google.com/iam/help/conditions/resource-policies).JSON
    /// example: { "bindings": [ { "role": "roles/resourcemanager.organizationAdmin", "members": [
    /// "user:mike@example.com", "group:admins@example.com", "domain:google.com",
    /// "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] }, { "role":
    /// "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": { "title":
    /// "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 } YAML example: bindings: -
    /// members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') etag: BwWWja0YfJA= version: 3 For a description of IAM and its features,
    /// see the IAM documentation (https://cloud.google.com/iam/docs/).
    /// </summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<AuditConfig> AuditConfigs { get; set; }

        /// <summary>
        /// Associates a list of members, or principals, with a role. Optionally, may specify a condition that
        /// determines how and when the bindings are applied. Each of the bindings must contain at least one
        /// principal.The bindings in a Policy can refer to up to 1,500 principals; up to 250 of these principals can be
        /// Google groups. Each occurrence of a principal counts towards these limits. For example, if the bindings
        /// grant 50 different roles to user:alice@example.com, and not to any other principal, then you can add another
        /// 1,450 principals to the bindings in the Policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<Binding> Bindings { get; set; }

        /// <summary>
        /// etag is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy
        /// from overwriting each other. It is strongly suggested that systems make use of the etag in the
        /// read-modify-write cycle to perform policy updates in order to avoid race conditions: An etag is returned in
        /// the response to getIamPolicy, and systems are expected to put that etag in the request to setIamPolicy to
        /// ensure that their change will be applied to the same version of the policy.Important: If you use IAM
        /// Conditions, you must include the etag field whenever you call setIamPolicy. If you omit this field, then IAM
        /// allows you to overwrite a version 3 policy with a version 1 policy, and all of the conditions in the version
        /// 3 policy are lost.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Specifies the format of the policy.Valid values are 0, 1, and 3. Requests that specify an invalid value are
        /// rejected.Any operation that affects conditional role bindings must specify version 3. This requirement
        /// applies to the following operations: Getting a policy that includes a conditional role binding Adding a
        /// conditional role binding to a policy Changing a conditional role binding in a policy Removing any role
        /// binding, with or without a condition, from a policy that includes conditionsImportant: If you use IAM
        /// Conditions, you must include the etag field whenever you call setIamPolicy. If you omit this field, then IAM
        /// allows you to overwrite a version 3 policy with a version 1 policy, and all of the conditions in the version
        /// 3 policy are lost.If a policy does not include any conditions, operations on that policy may specify any
        /// valid version or leave the field unset.To learn which resources support conditions in their IAM policies,
        /// see the IAM documentation (https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; }
    }

    /// <summary>Request message for DataprocMetastore.QueryMetadata.</summary>
    public class QueryMetadataRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A read-only SQL query to execute against the metadata database. The query cannot change or mutate
        /// the data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DataprocMetastore.QueryMetadata.</summary>
    public class QueryMetadataResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The manifest URI is link to a JSON instance in Cloud Storage. This instance manifests immediately along with
        /// QueryMetadataResponse. The content of the URI is not retriable until the long-running operation query
        /// against the metadata finishes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultManifestUri")]
        public virtual string ResultManifestUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DataprocMetastore.RemoveIamPolicy.</summary>
    public class RemoveIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Removes IAM policy attached to database or table asynchronously when it is set. The default is
        /// false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asynchronous")]
        public virtual System.Nullable<bool> Asynchronous { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DataprocMetastore.RemoveIamPolicy.</summary>
    public class RemoveIamPolicyResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>True if the policy is successfully removed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("success")]
        public virtual System.Nullable<bool> Success { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The details of a metadata restore operation.</summary>
    public class Restore : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The relative resource name of the metastore service backup to restore from, in the following
        /// form:projects/{project_id}/locations/{location_id}/services/{service_id}/backups/{backup_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backup")]
        public virtual string Backup { get; set; }

        /// <summary>
        /// Optional. A Cloud Storage URI specifying where the backup artifacts are stored, in the format gs:///.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupLocation")]
        public virtual string BackupLocation { get; set; }

        /// <summary>
        /// Output only. The restore details containing the revision of the service to be restored to, in format of
        /// JSON.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual string Details { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. The time when the restore ended.</summary>
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

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. The time when the restore started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTimeRaw
        {
            get => _startTimeRaw;
            set
            {
                _startTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _startTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StartTimeDateTimeOffset instead.")]
        public virtual object StartTime
        {
            get => _startTime;
            set
            {
                _startTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _startTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? StartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StartTimeRaw);
            set => StartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The current state of the restore.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. The type of restore.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DataprocMetastore.RestoreService.</summary>
    public class RestoreServiceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The relative resource name of the metastore service backup to restore from, in the following
        /// form:projects/{project_id}/locations/{location_id}/services/{service_id}/backups/{backup_id}. Mutually
        /// exclusive with backup_location, and exactly one of the two must be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backup")]
        public virtual string Backup { get; set; }

        /// <summary>
        /// Optional. A Cloud Storage URI specifying the location of the backup artifacts, namely - backup avro files
        /// under "avro/", backup_metastore.json and service.json, in the following form:gs://. Mutually exclusive with
        /// backup, and exactly one of the two must be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupLocation")]
        public virtual string BackupLocation { get; set; }

        /// <summary>
        /// Optional. A request ID. Specify a unique request ID to allow the server to ignore the request if it has
        /// completed. The server will ignore subsequent requests that provide a duplicate request ID for at least 60
        /// minutes after the first request.For example, if an initial request times out, followed by another request
        /// with the same request ID, the server ignores the second request to prevent the creation of duplicate
        /// commitments.The request ID must be a valid UUID
        /// (https://en.wikipedia.org/wiki/Universally_unique_identifier#Format). A zero UUID
        /// (00000000-0000-0000-0000-000000000000) is not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>Optional. The type of restore. If unspecified, defaults to METADATA_ONLY.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restoreType")]
        public virtual string RestoreType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Deprecated: Use a single region service instead. A gRPC client must install all root CA certificates to connect
    /// to a multi-regional Dataproc Metastore service and achieve failover.
    /// </summary>
    public class RootCACertificate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecated: Use a single region service instead. The root CA certificate in PEM format. The maximum length
        /// is 65536 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificate")]
        public virtual string Certificate { get; set; }

        private string _expirationTimeRaw;

        private object _expirationTime;

        /// <summary>
        /// Deprecated: Use a single region service instead. The certificate expiration time in timestamp format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTime")]
        public virtual string ExpirationTimeRaw
        {
            get => _expirationTimeRaw;
            set
            {
                _expirationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expirationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpirationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpirationTimeDateTimeOffset instead.")]
        public virtual object ExpirationTime
        {
            get => _expirationTime;
            set
            {
                _expirationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expirationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpirationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpirationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpirationTimeRaw);
            set => ExpirationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the scaling configuration of a metastore service.</summary>
    public class ScalingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The autoscaling configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoscalingConfig")]
        public virtual AutoscalingConfig AutoscalingConfig { get; set; }

        /// <summary>
        /// An enum of readable instance sizes, with each instance size mapping to a float value (e.g.
        /// InstanceSize.EXTRA_SMALL = scaling_factor(0.1))
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceSize")]
        public virtual string InstanceSize { get; set; }

        /// <summary>
        /// Scaling factor, increments of 0.1 for values less than 1.0, and increments of 1.0 for values greater than
        /// 1.0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scalingFactor")]
        public virtual System.Nullable<float> ScalingFactor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This specifies the configuration of scheduled backup.</summary>
    public class ScheduledBackup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A Cloud Storage URI of a folder, in the format gs:///. A sub-folder containing backup files will
        /// be stored below it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupLocation")]
        public virtual string BackupLocation { get; set; }

        /// <summary>
        /// Optional. The scheduled interval in Cron format, see https://en.wikipedia.org/wiki/Cron The default is
        /// empty: scheduled backup is not enabled. Must be specified to enable scheduled backups.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cronSchedule")]
        public virtual string CronSchedule { get; set; }

        /// <summary>Optional. Defines whether the scheduled backup is enabled. The default value is false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>Output only. The details of the latest scheduled backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestBackup")]
        public virtual LatestBackup LatestBackup { get; set; }

        private string _nextScheduledTimeRaw;

        private object _nextScheduledTime;

        /// <summary>Output only. The time when the next backups execution is scheduled to start.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextScheduledTime")]
        public virtual string NextScheduledTimeRaw
        {
            get => _nextScheduledTimeRaw;
            set
            {
                _nextScheduledTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _nextScheduledTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="NextScheduledTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NextScheduledTimeDateTimeOffset instead.")]
        public virtual object NextScheduledTime
        {
            get => _nextScheduledTime;
            set
            {
                _nextScheduledTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _nextScheduledTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="NextScheduledTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NextScheduledTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NextScheduledTimeRaw);
            set => NextScheduledTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. Specifies the time zone to be used when interpreting cron_schedule. Must be a time zone name from
        /// the time zone database (https://en.wikipedia.org/wiki/List_of_tz_database_time_zones), e.g.
        /// America/Los_Angeles or Africa/Abidjan. If left unspecified, the default is UTC.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A securely stored value.</summary>
    public class Secret : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The relative resource name of a Secret Manager secret version, in the following
        /// form:projects/{project_number}/secrets/{secret_id}/versions/{version_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudSecret")]
        public virtual string CloudSecret { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A managed metastore service that serves metadata queries.</summary>
    public class Service : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. A Cloud Storage URI (starting with gs://) that specifies where artifacts related to the
        /// metastore service are stored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactGcsUri")]
        public virtual string ArtifactGcsUri { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the metastore service was created.</summary>
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

        /// <summary>Immutable. The database type that the Metastore service stores its data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseType")]
        public virtual string DatabaseType { get; set; }

        /// <summary>
        /// Optional. Indicates if the dataproc metastore should be protected against accidental deletions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionProtection")]
        public virtual System.Nullable<bool> DeletionProtection { get; set; }

        /// <summary>
        /// Immutable. Information used to configure the Dataproc Metastore service to encrypt customer data at rest.
        /// Cannot be updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionConfig")]
        public virtual EncryptionConfig EncryptionConfig { get; set; }

        /// <summary>Output only. The URI of the endpoint used to access the metastore service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointUri")]
        public virtual string EndpointUri { get; set; }

        /// <summary>
        /// Configuration information specific to running Hive metastore software as the metastore service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hiveMetastoreConfig")]
        public virtual HiveMetastoreConfig HiveMetastoreConfig { get; set; }

        /// <summary>User-defined labels for the metastore service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. The one hour maintenance window of the metastore service. This specifies when the service can be
        /// restarted for maintenance purposes in UTC time. Maintenance window is not needed for services with the
        /// SPANNER database type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceWindow")]
        public virtual MaintenanceWindow MaintenanceWindow { get; set; }

        /// <summary>
        /// Optional. The setting that defines how metastore metadata should be integrated with external services and
        /// systems.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadataIntegration")]
        public virtual MetadataIntegration MetadataIntegration { get; set; }

        /// <summary>Output only. The metadata management activities of the metastore service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadataManagementActivity")]
        public virtual MetadataManagementActivity MetadataManagementActivity { get; set; }

        /// <summary>
        /// Optional. Deprecated: Use a single region service instead. Specifies the multi-region configuration
        /// information for the Hive metastore service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiRegionConfig")]
        public virtual MultiRegionConfig MultiRegionConfig { get; set; }

        /// <summary>
        /// Immutable. Identifier. The relative resource name of the metastore service, in the following
        /// format:projects/{project_number}/locations/{location_id}/services/{service_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. The relative resource name of the VPC network on which the instance can be accessed. It is
        /// specified in the following form:projects/{project_number}/global/networks/{network_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>
        /// Optional. The configuration specifying the network settings for the Dataproc Metastore service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkConfig")]
        public virtual NetworkConfig NetworkConfig { get; set; }

        /// <summary>Optional. The TCP port at which the metastore service is reached. Default: 9083.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>Immutable. The release channel of the service. If unspecified, defaults to STABLE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseChannel")]
        public virtual string ReleaseChannel { get; set; }

        /// <summary>Optional. Scaling configuration of the metastore service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scalingConfig")]
        public virtual ScalingConfig ScalingConfig { get; set; }

        /// <summary>Optional. The configuration of scheduled backup for the metastore service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduledBackup")]
        public virtual ScheduledBackup ScheduledBackup { get; set; }

        /// <summary>Output only. The current state of the metastore service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. Additional information about the current state of the metastore service, if available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        /// <summary>
        /// Optional. Input only. Immutable. Tag keys/values directly bound to this resource. For example:
        /// "123/environment": "production", "123/costCenter": "marketing"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Optional. The configuration specifying telemetry settings for the Dataproc Metastore service. If unspecified
        /// defaults to JSON.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("telemetryConfig")]
        public virtual TelemetryConfig TelemetryConfig { get; set; }

        /// <summary>Optional. The tier of the service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tier")]
        public virtual string Tier { get; set; }

        /// <summary>Output only. The globally unique resource identifier of the metastore service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when the metastore service was last updated.</summary>
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

    /// <summary>Request message for SetIamPolicy method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the resource. The size of the policy is limited to a few 10s
        /// of KB. An empty policy is a valid policy but certain Google Cloud services (such as Projects) might reject
        /// them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>
        /// OPTIONAL: A FieldMask specifying which fields of the policy to modify. Only the fields in the mask will be
        /// modified. If no mask is provided, the following default mask is used:paths: "bindings, etag"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DataprocMetastore.StartMigration.</summary>
    public class StartMigrationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The configuration details for the migration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migrationExecution")]
        public virtual MigrationExecution MigrationExecution { get; set; }

        /// <summary>
        /// Optional. A request ID. Specify a unique request ID to allow the server to ignore the request if it has
        /// completed. The server will ignore subsequent requests that provide a duplicate request ID for at least 60
        /// minutes after the first request.For example, if an initial request times out, followed by another request
        /// with the same request ID, the server ignores the second request to prevent the creation of duplicate
        /// commitments.The request ID must be a valid UUID
        /// (https://en.wikipedia.org/wiki/Universally_unique_identifier#Format) A zero UUID
        /// (00000000-0000-0000-0000-000000000000) is not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The Status type defines a logical error model that is suitable for different programming environments, including
    /// REST APIs and RPC APIs. It is used by gRPC (https://github.com/grpc). Each Status message contains three pieces
    /// of data: error code, error message, and error details.You can find out more about this error model and how to
    /// work with it in the API Design Guide (https://cloud.google.com/apis/design/errors).
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

    /// <summary>Wire-format for a Status object</summary>
    public class StatusProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// copybara:strip_begin(b/383363683) copybara:strip_end_and_replace optional int32 canonical_code = 6;
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalCode")]
        public virtual System.Nullable<int> CanonicalCode { get; set; }

        /// <summary>
        /// Numeric code drawn from the space specified below. Often, this is the canonical error space, and code is
        /// drawn from google3/util/task/codes.proto copybara:strip_begin(b/383363683) copybara:strip_end_and_replace
        /// optional int32 code = 1;
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// Detail message copybara:strip_begin(b/383363683) copybara:strip_end_and_replace optional string message = 3;
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>
        /// message_set associates an arbitrary proto message with the status. copybara:strip_begin(b/383363683)
        /// copybara:strip_end_and_replace optional proto2.bridge.MessageSet message_set = 5;
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageSet")]
        public virtual MessageSet MessageSet { get; set; }

        /// <summary>
        /// copybara:strip_begin(b/383363683) Space to which this status belongs copybara:strip_end_and_replace optional
        /// string space = 2; // Space to which this status belongs
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("space")]
        public virtual string Space { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Telemetry Configuration for the Dataproc Metastore service.</summary>
    public class TelemetryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The output format of the Dataproc Metastore service's logs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logFormat")]
        public virtual string LogFormat { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for TestIamPermissions method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of permissions to check for the resource. Permissions with wildcards (such as * or storage.*) are
        /// not allowed. For more information see IAM Overview (https://cloud.google.com/iam/docs/overview#permissions).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for TestIamPermissions method.</summary>
    public class TestIamPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A subset of TestPermissionsRequest.permissions that the caller is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
