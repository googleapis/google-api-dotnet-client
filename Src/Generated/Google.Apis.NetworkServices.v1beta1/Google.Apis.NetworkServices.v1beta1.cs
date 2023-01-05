// Copyright 2023 Google LLC
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

namespace Google.Apis.NetworkServices.v1beta1
{
    /// <summary>The NetworkServices Service.</summary>
    public class NetworkServicesService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public NetworkServicesService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public NetworkServicesService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "networkservices";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://networkservices.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://networkservices.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Network Services API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Network Services API.</summary>
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

    /// <summary>A base abstract class for NetworkServices requests.</summary>
    public abstract class NetworkServicesBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new NetworkServicesBaseServiceRequest instance.</summary>
        protected NetworkServicesBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes NetworkServices parameter list.</summary>
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
                EndpointPolicies = new EndpointPoliciesResource(service);
                Gateways = new GatewaysResource(service);
                GrpcRoutes = new GrpcRoutesResource(service);
                HttpRoutes = new HttpRoutesResource(service);
                Meshes = new MeshesResource(service);
                Operations = new OperationsResource(service);
                ServiceBindings = new ServiceBindingsResource(service);
                TcpRoutes = new TcpRoutesResource(service);
                TlsRoutes = new TlsRoutesResource(service);
            }

            /// <summary>Gets the EndpointPolicies resource.</summary>
            public virtual EndpointPoliciesResource EndpointPolicies { get; }

            /// <summary>The "endpointPolicies" collection of methods.</summary>
            public class EndpointPoliciesResource
            {
                private const string Resource = "endpointPolicies";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public EndpointPoliciesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new EndpointPolicy in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the EndpointPolicy. Must be in the format
                /// `projects/*/locations/global`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.NetworkServices.v1beta1.Data.EndpointPolicy body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new EndpointPolicy in a given project and location.</summary>
                public class CreateRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1beta1.Data.EndpointPolicy body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the EndpointPolicy. Must be in the format
                    /// `projects/*/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. Short name of the EndpointPolicy resource to be created. E.g. "CustomECS".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("endpointPolicyId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string EndpointPolicyId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1beta1.Data.EndpointPolicy Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/endpointPolicies";

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
                        RequestParameters.Add("endpointPolicyId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "endpointPolicyId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single EndpointPolicy.</summary>
                /// <param name="name">
                /// Required. A name of the EndpointPolicy to delete. Must be in the format
                /// `projects/*/locations/global/endpointPolicies/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a single EndpointPolicy.</summary>
                public class DeleteRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the EndpointPolicy to delete. Must be in the format
                    /// `projects/*/locations/global/endpointPolicies/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/endpointPolicies/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single EndpointPolicy.</summary>
                /// <param name="name">
                /// Required. A name of the EndpointPolicy to get. Must be in the format
                /// `projects/*/locations/global/endpointPolicies/*`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets details of a single EndpointPolicy.</summary>
                public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.EndpointPolicy>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the EndpointPolicy to get. Must be in the format
                    /// `projects/*/locations/global/endpointPolicies/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/endpointPolicies/[^/]+$",
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
                    return new GetIamPolicyRequest(service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Policy>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/endpointPolicies/[^/]+$",
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

                /// <summary>Lists EndpointPolicies in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The project and location from which the EndpointPolicies should be listed, specified in
                /// the format `projects/*/locations/global`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists EndpointPolicies in a given project and location.</summary>
                public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.ListEndpointPoliciesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location from which the EndpointPolicies should be listed, specified
                    /// in the format `projects/*/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum number of EndpointPolicies to return per call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListEndpointPoliciesResponse` Indicates that this is a
                    /// continuation of a prior `ListEndpointPolicies` call, and that the system should return the next
                    /// page of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/endpointPolicies";

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

                /// <summary>Updates the parameters of a single EndpointPolicy.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Name of the EndpointPolicy resource. It matches pattern
                /// `projects/{project}/locations/global/endpointPolicies/{endpoint_policy}`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.NetworkServices.v1beta1.Data.EndpointPolicy body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates the parameters of a single EndpointPolicy.</summary>
                public class PatchRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1beta1.Data.EndpointPolicy body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the EndpointPolicy resource. It matches pattern
                    /// `projects/{project}/locations/global/endpointPolicies/{endpoint_policy}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Field mask is used to specify the fields to be overwritten in the EndpointPolicy
                    /// resource by the update. The fields specified in the update_mask are relative to the resource,
                    /// not the full request. A field will be overwritten if it is in the mask. If the user does not
                    /// provide a mask then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1beta1.Data.EndpointPolicy Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/endpointPolicies/[^/]+$",
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
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.NetworkServices.v1beta1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1beta1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.NetworkServices.v1beta1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/endpointPolicies/[^/]+$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.NetworkServices.v1beta1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.NetworkServices.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/endpointPolicies/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Gateways resource.</summary>
            public virtual GatewaysResource Gateways { get; }

            /// <summary>The "gateways" collection of methods.</summary>
            public class GatewaysResource
            {
                private const string Resource = "gateways";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public GatewaysResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new Gateway in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the Gateway. Must be in the format `projects/*/locations/*`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.NetworkServices.v1beta1.Data.Gateway body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new Gateway in a given project and location.</summary>
                public class CreateRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1beta1.Data.Gateway body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the Gateway. Must be in the format `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. Short name of the Gateway resource to be created.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("gatewayId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string GatewayId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1beta1.Data.Gateway Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/gateways";

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
                        RequestParameters.Add("gatewayId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "gatewayId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single Gateway.</summary>
                /// <param name="name">
                /// Required. A name of the Gateway to delete. Must be in the format
                /// `projects/*/locations/*/gateways/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a single Gateway.</summary>
                public class DeleteRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the Gateway to delete. Must be in the format
                    /// `projects/*/locations/*/gateways/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/gateways/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single Gateway.</summary>
                /// <param name="name">
                /// Required. A name of the Gateway to get. Must be in the format `projects/*/locations/*/gateways/*`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets details of a single Gateway.</summary>
                public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Gateway>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the Gateway to get. Must be in the format
                    /// `projects/*/locations/*/gateways/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/gateways/[^/]+$",
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
                    return new GetIamPolicyRequest(service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Policy>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/gateways/[^/]+$",
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

                /// <summary>Lists Gateways in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The project and location from which the Gateways should be listed, specified in the format
                /// `projects/*/locations/*`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists Gateways in a given project and location.</summary>
                public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.ListGatewaysResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location from which the Gateways should be listed, specified in the
                    /// format `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum number of Gateways to return per call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListGatewaysResponse` Indicates that this is a continuation of a
                    /// prior `ListGateways` call, and that the system should return the next page of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/gateways";

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

                /// <summary>Updates the parameters of a single Gateway.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Name of the Gateway resource. It matches pattern `projects/*/locations/*/gateways/`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.NetworkServices.v1beta1.Data.Gateway body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates the parameters of a single Gateway.</summary>
                public class PatchRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1beta1.Data.Gateway body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the Gateway resource. It matches pattern `projects/*/locations/*/gateways/`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Field mask is used to specify the fields to be overwritten in the Gateway resource by
                    /// the update. The fields specified in the update_mask are relative to the resource, not the full
                    /// request. A field will be overwritten if it is in the mask. If the user does not provide a mask
                    /// then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1beta1.Data.Gateway Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/gateways/[^/]+$",
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
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.NetworkServices.v1beta1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1beta1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.NetworkServices.v1beta1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/gateways/[^/]+$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.NetworkServices.v1beta1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.NetworkServices.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/gateways/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the GrpcRoutes resource.</summary>
            public virtual GrpcRoutesResource GrpcRoutes { get; }

            /// <summary>The "grpcRoutes" collection of methods.</summary>
            public class GrpcRoutesResource
            {
                private const string Resource = "grpcRoutes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public GrpcRoutesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new GrpcRoute in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the GrpcRoute. Must be in the format `projects/*/locations/global`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.NetworkServices.v1beta1.Data.GrpcRoute body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new GrpcRoute in a given project and location.</summary>
                public class CreateRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1beta1.Data.GrpcRoute body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the GrpcRoute. Must be in the format
                    /// `projects/*/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. Short name of the GrpcRoute resource to be created.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("grpcRouteId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string GrpcRouteId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1beta1.Data.GrpcRoute Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/grpcRoutes";

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
                        RequestParameters.Add("grpcRouteId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "grpcRouteId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single GrpcRoute.</summary>
                /// <param name="name">
                /// Required. A name of the GrpcRoute to delete. Must be in the format
                /// `projects/*/locations/global/grpcRoutes/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a single GrpcRoute.</summary>
                public class DeleteRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the GrpcRoute to delete. Must be in the format
                    /// `projects/*/locations/global/grpcRoutes/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/grpcRoutes/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single GrpcRoute.</summary>
                /// <param name="name">
                /// Required. A name of the GrpcRoute to get. Must be in the format
                /// `projects/*/locations/global/grpcRoutes/*`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets details of a single GrpcRoute.</summary>
                public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.GrpcRoute>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the GrpcRoute to get. Must be in the format
                    /// `projects/*/locations/global/grpcRoutes/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/grpcRoutes/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists GrpcRoutes in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The project and location from which the GrpcRoutes should be listed, specified in the
                /// format `projects/*/locations/global`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists GrpcRoutes in a given project and location.</summary>
                public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.ListGrpcRoutesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location from which the GrpcRoutes should be listed, specified in the
                    /// format `projects/*/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum number of GrpcRoutes to return per call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListGrpcRoutesResponse` Indicates that this is a continuation of
                    /// a prior `ListGrpcRoutes` call, and that the system should return the next page of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/grpcRoutes";

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

                /// <summary>Updates the parameters of a single GrpcRoute.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Name of the GrpcRoute resource. It matches pattern
                /// `projects/*/locations/global/grpcRoutes/`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.NetworkServices.v1beta1.Data.GrpcRoute body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates the parameters of a single GrpcRoute.</summary>
                public class PatchRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1beta1.Data.GrpcRoute body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the GrpcRoute resource. It matches pattern
                    /// `projects/*/locations/global/grpcRoutes/`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Field mask is used to specify the fields to be overwritten in the GrpcRoute resource
                    /// by the update. The fields specified in the update_mask are relative to the resource, not the
                    /// full request. A field will be overwritten if it is in the mask. If the user does not provide a
                    /// mask then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1beta1.Data.GrpcRoute Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/grpcRoutes/[^/]+$",
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

            /// <summary>Gets the HttpRoutes resource.</summary>
            public virtual HttpRoutesResource HttpRoutes { get; }

            /// <summary>The "httpRoutes" collection of methods.</summary>
            public class HttpRoutesResource
            {
                private const string Resource = "httpRoutes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public HttpRoutesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new HttpRoute in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the HttpRoute. Must be in the format `projects/*/locations/global`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.NetworkServices.v1beta1.Data.HttpRoute body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new HttpRoute in a given project and location.</summary>
                public class CreateRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1beta1.Data.HttpRoute body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the HttpRoute. Must be in the format
                    /// `projects/*/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. Short name of the HttpRoute resource to be created.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("httpRouteId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string HttpRouteId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1beta1.Data.HttpRoute Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/httpRoutes";

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
                        RequestParameters.Add("httpRouteId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "httpRouteId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single HttpRoute.</summary>
                /// <param name="name">
                /// Required. A name of the HttpRoute to delete. Must be in the format
                /// `projects/*/locations/global/httpRoutes/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a single HttpRoute.</summary>
                public class DeleteRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the HttpRoute to delete. Must be in the format
                    /// `projects/*/locations/global/httpRoutes/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/httpRoutes/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single HttpRoute.</summary>
                /// <param name="name">
                /// Required. A name of the HttpRoute to get. Must be in the format
                /// `projects/*/locations/global/httpRoutes/*`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets details of a single HttpRoute.</summary>
                public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.HttpRoute>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the HttpRoute to get. Must be in the format
                    /// `projects/*/locations/global/httpRoutes/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/httpRoutes/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists HttpRoute in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The project and location from which the HttpRoutes should be listed, specified in the
                /// format `projects/*/locations/global`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists HttpRoute in a given project and location.</summary>
                public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.ListHttpRoutesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location from which the HttpRoutes should be listed, specified in the
                    /// format `projects/*/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum number of HttpRoutes to return per call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListHttpRoutesResponse` Indicates that this is a continuation of
                    /// a prior `ListHttpRoutes` call, and that the system should return the next page of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/httpRoutes";

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

                /// <summary>Updates the parameters of a single HttpRoute.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Name of the HttpRoute resource. It matches pattern
                /// `projects/*/locations/global/httpRoutes/http_route_name&amp;gt;`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.NetworkServices.v1beta1.Data.HttpRoute body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates the parameters of a single HttpRoute.</summary>
                public class PatchRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1beta1.Data.HttpRoute body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the HttpRoute resource. It matches pattern
                    /// `projects/*/locations/global/httpRoutes/http_route_name&amp;gt;`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Field mask is used to specify the fields to be overwritten in the HttpRoute resource
                    /// by the update. The fields specified in the update_mask are relative to the resource, not the
                    /// full request. A field will be overwritten if it is in the mask. If the user does not provide a
                    /// mask then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1beta1.Data.HttpRoute Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/httpRoutes/[^/]+$",
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

            /// <summary>Gets the Meshes resource.</summary>
            public virtual MeshesResource Meshes { get; }

            /// <summary>The "meshes" collection of methods.</summary>
            public class MeshesResource
            {
                private const string Resource = "meshes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public MeshesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new Mesh in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the Mesh. Must be in the format `projects/*/locations/global`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.NetworkServices.v1beta1.Data.Mesh body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new Mesh in a given project and location.</summary>
                public class CreateRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1beta1.Data.Mesh body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the Mesh. Must be in the format `projects/*/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. Short name of the Mesh resource to be created.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("meshId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string MeshId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1beta1.Data.Mesh Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/meshes";

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
                        RequestParameters.Add("meshId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "meshId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single Mesh.</summary>
                /// <param name="name">
                /// Required. A name of the Mesh to delete. Must be in the format
                /// `projects/*/locations/global/meshes/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a single Mesh.</summary>
                public class DeleteRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the Mesh to delete. Must be in the format
                    /// `projects/*/locations/global/meshes/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/meshes/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single Mesh.</summary>
                /// <param name="name">
                /// Required. A name of the Mesh to get. Must be in the format `projects/*/locations/global/meshes/*`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets details of a single Mesh.</summary>
                public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Mesh>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the Mesh to get. Must be in the format
                    /// `projects/*/locations/global/meshes/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/meshes/[^/]+$",
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
                    return new GetIamPolicyRequest(service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Policy>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/meshes/[^/]+$",
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

                /// <summary>Lists Meshes in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The project and location from which the Meshes should be listed, specified in the format
                /// `projects/*/locations/global`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists Meshes in a given project and location.</summary>
                public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.ListMeshesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location from which the Meshes should be listed, specified in the
                    /// format `projects/*/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum number of Meshes to return per call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListMeshesResponse` Indicates that this is a continuation of a
                    /// prior `ListMeshes` call, and that the system should return the next page of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/meshes";

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

                /// <summary>Updates the parameters of a single Mesh.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Name of the Mesh resource. It matches pattern `projects/*/locations/global/meshes/`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.NetworkServices.v1beta1.Data.Mesh body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates the parameters of a single Mesh.</summary>
                public class PatchRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1beta1.Data.Mesh body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the Mesh resource. It matches pattern `projects/*/locations/global/meshes/`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Field mask is used to specify the fields to be overwritten in the Mesh resource by the
                    /// update. The fields specified in the update_mask are relative to the resource, not the full
                    /// request. A field will be overwritten if it is in the mask. If the user does not provide a mask
                    /// then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1beta1.Data.Mesh Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/meshes/[^/]+$",
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
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.NetworkServices.v1beta1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1beta1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.NetworkServices.v1beta1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/meshes/[^/]+$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.NetworkServices.v1beta1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.NetworkServices.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/meshes/[^/]+$",
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
                public virtual CancelRequest Cancel(Google.Apis.NetworkServices.v1beta1.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1beta1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1beta1.Data.CancelOperationRequest Body { get; set; }

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
                public class DeleteRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Empty>
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
                public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Operation>
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
                public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.ListOperationsResponse>
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

            /// <summary>Gets the ServiceBindings resource.</summary>
            public virtual ServiceBindingsResource ServiceBindings { get; }

            /// <summary>The "serviceBindings" collection of methods.</summary>
            public class ServiceBindingsResource
            {
                private const string Resource = "serviceBindings";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ServiceBindingsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new ServiceBinding in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the ServiceBinding. Must be in the format
                /// `projects/*/locations/global`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.NetworkServices.v1beta1.Data.ServiceBinding body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new ServiceBinding in a given project and location.</summary>
                public class CreateRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1beta1.Data.ServiceBinding body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the ServiceBinding. Must be in the format
                    /// `projects/*/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. Short name of the ServiceBinding resource to be created.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("serviceBindingId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ServiceBindingId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1beta1.Data.ServiceBinding Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/serviceBindings";

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
                        RequestParameters.Add("serviceBindingId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "serviceBindingId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single ServiceBinding.</summary>
                /// <param name="name">
                /// Required. A name of the ServiceBinding to delete. Must be in the format
                /// `projects/*/locations/global/serviceBindings/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a single ServiceBinding.</summary>
                public class DeleteRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the ServiceBinding to delete. Must be in the format
                    /// `projects/*/locations/global/serviceBindings/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/serviceBindings/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single ServiceBinding.</summary>
                /// <param name="name">
                /// Required. A name of the ServiceBinding to get. Must be in the format
                /// `projects/*/locations/global/serviceBindings/*`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets details of a single ServiceBinding.</summary>
                public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.ServiceBinding>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the ServiceBinding to get. Must be in the format
                    /// `projects/*/locations/global/serviceBindings/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/serviceBindings/[^/]+$",
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
                    return new GetIamPolicyRequest(service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Policy>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/serviceBindings/[^/]+$",
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

                /// <summary>Lists ServiceBinding in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The project and location from which the ServiceBindings should be listed, specified in the
                /// format `projects/*/locations/global`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists ServiceBinding in a given project and location.</summary>
                public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.ListServiceBindingsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location from which the ServiceBindings should be listed, specified in
                    /// the format `projects/*/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum number of ServiceBindings to return per call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListServiceBindingsResponse` Indicates that this is a
                    /// continuation of a prior `ListRouters` call, and that the system should return the next page of
                    /// data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/serviceBindings";

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
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.NetworkServices.v1beta1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1beta1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.NetworkServices.v1beta1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/serviceBindings/[^/]+$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.NetworkServices.v1beta1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.NetworkServices.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/serviceBindings/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the TcpRoutes resource.</summary>
            public virtual TcpRoutesResource TcpRoutes { get; }

            /// <summary>The "tcpRoutes" collection of methods.</summary>
            public class TcpRoutesResource
            {
                private const string Resource = "tcpRoutes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public TcpRoutesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new TcpRoute in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the TcpRoute. Must be in the format `projects/*/locations/global`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.NetworkServices.v1beta1.Data.TcpRoute body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new TcpRoute in a given project and location.</summary>
                public class CreateRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1beta1.Data.TcpRoute body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the TcpRoute. Must be in the format
                    /// `projects/*/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. Short name of the TcpRoute resource to be created. E.g. TODO(Add an example).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("tcpRouteId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string TcpRouteId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1beta1.Data.TcpRoute Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/tcpRoutes";

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
                        RequestParameters.Add("tcpRouteId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "tcpRouteId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single TcpRoute.</summary>
                /// <param name="name">
                /// Required. A name of the TcpRoute to delete. Must be in the format
                /// `projects/*/locations/global/tcpRoutes/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a single TcpRoute.</summary>
                public class DeleteRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the TcpRoute to delete. Must be in the format
                    /// `projects/*/locations/global/tcpRoutes/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/tcpRoutes/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single TcpRoute.</summary>
                /// <param name="name">
                /// Required. A name of the TcpRoute to get. Must be in the format
                /// `projects/*/locations/global/tcpRoutes/*`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets details of a single TcpRoute.</summary>
                public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.TcpRoute>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the TcpRoute to get. Must be in the format
                    /// `projects/*/locations/global/tcpRoutes/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/tcpRoutes/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists TcpRoute in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The project and location from which the TcpRoutes should be listed, specified in the
                /// format `projects/*/locations/global`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists TcpRoute in a given project and location.</summary>
                public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.ListTcpRoutesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location from which the TcpRoutes should be listed, specified in the
                    /// format `projects/*/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum number of TcpRoutes to return per call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListTcpRoutesResponse` Indicates that this is a continuation of
                    /// a prior `ListTcpRoutes` call, and that the system should return the next page of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/tcpRoutes";

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

                /// <summary>Updates the parameters of a single TcpRoute.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Name of the TcpRoute resource. It matches pattern
                /// `projects/*/locations/global/tcpRoutes/tcp_route_name&amp;gt;`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.NetworkServices.v1beta1.Data.TcpRoute body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates the parameters of a single TcpRoute.</summary>
                public class PatchRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1beta1.Data.TcpRoute body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the TcpRoute resource. It matches pattern
                    /// `projects/*/locations/global/tcpRoutes/tcp_route_name&amp;gt;`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Field mask is used to specify the fields to be overwritten in the TcpRoute resource by
                    /// the update. The fields specified in the update_mask are relative to the resource, not the full
                    /// request. A field will be overwritten if it is in the mask. If the user does not provide a mask
                    /// then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1beta1.Data.TcpRoute Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/tcpRoutes/[^/]+$",
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

            /// <summary>Gets the TlsRoutes resource.</summary>
            public virtual TlsRoutesResource TlsRoutes { get; }

            /// <summary>The "tlsRoutes" collection of methods.</summary>
            public class TlsRoutesResource
            {
                private const string Resource = "tlsRoutes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public TlsRoutesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new TlsRoute in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the TlsRoute. Must be in the format `projects/*/locations/global`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.NetworkServices.v1beta1.Data.TlsRoute body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new TlsRoute in a given project and location.</summary>
                public class CreateRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1beta1.Data.TlsRoute body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the TlsRoute. Must be in the format
                    /// `projects/*/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. Short name of the TlsRoute resource to be created. E.g. TODO(Add an example).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("tlsRouteId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string TlsRouteId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1beta1.Data.TlsRoute Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/tlsRoutes";

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
                        RequestParameters.Add("tlsRouteId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "tlsRouteId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single TlsRoute.</summary>
                /// <param name="name">
                /// Required. A name of the TlsRoute to delete. Must be in the format
                /// `projects/*/locations/global/tlsRoutes/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a single TlsRoute.</summary>
                public class DeleteRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the TlsRoute to delete. Must be in the format
                    /// `projects/*/locations/global/tlsRoutes/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/tlsRoutes/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single TlsRoute.</summary>
                /// <param name="name">
                /// Required. A name of the TlsRoute to get. Must be in the format
                /// `projects/*/locations/global/tlsRoutes/*`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets details of a single TlsRoute.</summary>
                public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.TlsRoute>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the TlsRoute to get. Must be in the format
                    /// `projects/*/locations/global/tlsRoutes/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/tlsRoutes/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists TlsRoute in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The project and location from which the TlsRoutes should be listed, specified in the
                /// format `projects/*/locations/global`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists TlsRoute in a given project and location.</summary>
                public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.ListTlsRoutesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location from which the TlsRoutes should be listed, specified in the
                    /// format `projects/*/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum number of TlsRoutes to return per call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListTlsRoutesResponse` Indicates that this is a continuation of
                    /// a prior `ListTlsRoutes` call, and that the system should return the next page of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/tlsRoutes";

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

                /// <summary>Updates the parameters of a single TlsRoute.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Name of the TlsRoute resource. It matches pattern
                /// `projects/*/locations/global/tlsRoutes/tls_route_name&amp;gt;`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.NetworkServices.v1beta1.Data.TlsRoute body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates the parameters of a single TlsRoute.</summary>
                public class PatchRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1beta1.Data.TlsRoute body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the TlsRoute resource. It matches pattern
                    /// `projects/*/locations/global/tlsRoutes/tls_route_name&amp;gt;`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Field mask is used to specify the fields to be overwritten in the TlsRoute resource by
                    /// the update. The fields specified in the update_mask are relative to the resource, not the full
                    /// request. A field will be overwritten if it is in the mask. If the user does not provide a mask
                    /// then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1beta1.Data.TlsRoute Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/tlsRoutes/[^/]+$",
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

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.Location>
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
            public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1beta1.Data.ListLocationsResponse>
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
namespace Google.Apis.NetworkServices.v1beta1.Data
{
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
        /// represents a Google group. For example, `admins@example.com`. * `deleted:user:{emailid}?uid={uniqueid}`: An
        /// email address (plus unique identifier) representing a user that has been recently deleted. For example,
        /// `alice@example.com?uid=123456789012345678901`. If the user is recovered, this value reverts to
        /// `user:{emailid}` and the recovered user retains the role in the binding. *
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
        /// Role that is assigned to the list of `members`, or principals. For example, `roles/viewer`, `roles/editor`,
        /// or `roles/owner`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

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
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A definition of a matcher that selects endpoints to which the policies should be applied.</summary>
    public class EndpointMatcher : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The matcher is based on node metadata presented by xDS clients.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadataLabelMatcher")]
        public virtual MetadataLabelMatcher MetadataLabelMatcher { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// EndpointPolicy is a resource that helps apply desired configuration on the endpoints that match specific
    /// criteria. For example, this resource can be used to apply "authentication config" an all endpoints that serve on
    /// port 8080.
    /// </summary>
    public class EndpointPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. This field specifies the URL of AuthorizationPolicy resource that applies authorization policies
        /// to the inbound traffic at the matched endpoints. Refer to Authorization. If this field is not specified,
        /// authorization is disabled(no authz checks) for this endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizationPolicy")]
        public virtual string AuthorizationPolicy { get; set; }

        /// <summary>
        /// Optional. A URL referring to a ClientTlsPolicy resource. ClientTlsPolicy can be set to specify the
        /// authentication for traffic from the proxy to the actual endpoints. More specifically, it is applied to the
        /// outgoing traffic from the proxy to the endpoint. This is typically used for sidecar model where the proxy
        /// identifies itself as endpoint to the control plane, with the connection between sidecar and endpoint
        /// requiring authentication. If this field is not set, authentication is disabled(open). Applicable only when
        /// EndpointPolicyType is SIDECAR_PROXY.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientTlsPolicy")]
        public virtual string ClientTlsPolicy { get; set; }

        /// <summary>Output only. The timestamp when the resource was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Optional. A free-text description of the resource. Max length 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. A matcher that selects endpoints to which the policies should be applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointMatcher")]
        public virtual EndpointMatcher EndpointMatcher { get; set; }

        /// <summary>Optional. Set of label tags associated with the EndpointPolicy resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. Name of the EndpointPolicy resource. It matches pattern
        /// `projects/{project}/locations/global/endpointPolicies/{endpoint_policy}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. A URL referring to ServerTlsPolicy resource. ServerTlsPolicy is used to determine the
        /// authentication policy to be applied to terminate the inbound traffic at the identified backends. If this
        /// field is not set, authentication is disabled(open) for this endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverTlsPolicy")]
        public virtual string ServerTlsPolicy { get; set; }

        /// <summary>
        /// Optional. Port selector for the (matched) endpoints. If no port selector is provided, the matched config is
        /// applied to all ports.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trafficPortSelector")]
        public virtual TrafficPortSelector TrafficPortSelector { get; set; }

        /// <summary>
        /// Required. The type of endpoint policy. This is primarily used to validate the configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Output only. The timestamp when the resource was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

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
    /// Gateway represents the configuration for a proxy, typically a load balancer. It captures the ip:port over which
    /// the services are exposed by the proxy, along with any policy configurations. Routes have reference to to
    /// Gateways to dictate how requests should be routed by this Gateway.
    /// </summary>
    public class Gateway : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The timestamp when the resource was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Optional. A free-text description of the resource. Max length 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. Set of label tags associated with the Gateway resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. Name of the Gateway resource. It matches pattern `projects/*/locations/*/gateways/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. One or more port numbers (1-65535), on which the Gateway will receive traffic. The proxy binds to
        /// the specified ports. Gateways of type 'SECURE_WEB_GATEWAY' are limited to 1 port. Gateways of type
        /// 'OPEN_MESH' listen on 0.0.0.0 and support multiple ports.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ports")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> Ports { get; set; }

        /// <summary>
        /// Required. Immutable. Scope determines how configuration across multiple Gateway instances are merged. The
        /// configuration for multiple Gateway instances with the same scope will be merged as presented as a single
        /// coniguration to the proxy/load balancer. Max length 64 characters. Scope should start with a letter and can
        /// only have letters, numbers, hyphens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>Output only. Server-defined URL of this resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>
        /// Optional. A fully-qualified ServerTLSPolicy URL reference. Specifies how TLS traffic is terminated. If
        /// empty, TLS termination is disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverTlsPolicy")]
        public virtual string ServerTlsPolicy { get; set; }

        /// <summary>
        /// Immutable. The type of the customer managed gateway. This field is required. If unspecified, an error is
        /// returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Output only. The timestamp when the resource was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// GrpcRoute is the resource defining how gRPC traffic routed by a Mesh or Gateway resource is routed.
    /// </summary>
    public class GrpcRoute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The timestamp when the resource was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Optional. A free-text description of the resource. Max length 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Gateways defines a list of gateways this GrpcRoute is attached to, as one of the routing rules to
        /// route the requests served by the gateway. Each gateway reference should match the pattern:
        /// `projects/*/locations/global/gateways/`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gateways")]
        public virtual System.Collections.Generic.IList<string> Gateways { get; set; }

        /// <summary>
        /// Required. Service hostnames with an optional port for which this route describes traffic. Format: [:]
        /// Hostname is the fully qualified domain name of a network host. This matches the RFC 1123 definition of a
        /// hostname with 2 notable exceptions: - IPs are not allowed. - A hostname may be prefixed with a wildcard
        /// label (*.). The wildcard label must appear by itself as the first label. Hostname can be "precise" which is
        /// a domain name without the terminating dot of a network host (e.g. "foo.example.com") or "wildcard", which is
        /// a domain name prefixed with a single wildcard label (e.g. *.example.com). Note that as per RFC1035 and
        /// RFC1123, a label must consist of lower case alphanumeric characters or '-', and must start and end with an
        /// alphanumeric character. No other punctuation is allowed. The routes associated with a Mesh or Gateway must
        /// have unique hostnames. If you attempt to attach multiple routes with conflicting hostnames, the
        /// configuration will be rejected. For example, while it is acceptable for routes for the hostnames
        /// "*.foo.bar.com" and "*.bar.com" to be associated with the same route, it is not possible to associate two
        /// routes both with "*.bar.com" or both with "bar.com". If a port is specified, then gRPC clients must use the
        /// channel URI with the port to match this rule (i.e. "xds:///service:123"), otherwise they must supply the URI
        /// without a port (i.e. "xds:///service").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostnames")]
        public virtual System.Collections.Generic.IList<string> Hostnames { get; set; }

        /// <summary>Optional. Set of label tags associated with the GrpcRoute resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. Meshes defines a list of meshes this GrpcRoute is attached to, as one of the routing rules to
        /// route the requests served by the mesh. Each mesh reference should match the pattern:
        /// `projects/*/locations/global/meshes/`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meshes")]
        public virtual System.Collections.Generic.IList<string> Meshes { get; set; }

        /// <summary>
        /// Required. Name of the GrpcRoute resource. It matches pattern `projects/*/locations/global/grpcRoutes/`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. A list of detailed rules defining how to route traffic. Within a single GrpcRoute, the
        /// GrpcRoute.RouteAction associated with the first matching GrpcRoute.RouteRule will be executed. At least one
        /// rule must be supplied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<GrpcRouteRouteRule> Rules { get; set; }

        /// <summary>Output only. Server-defined URL of this resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Output only. The timestamp when the resource was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The destination to which traffic will be routed.</summary>
    public class GrpcRouteDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The URL of a destination service to which to route traffic. Must refer to either a BackendService
        /// or ServiceDirectoryService.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>
        /// Optional. Specifies the proportion of requests forwarded to the backend referenced by the serviceName field.
        /// This is computed as: weight/Sum(weights in this destination list). For non-zero values, there may be some
        /// epsilon from the exact proportion defined here depending on the precision an implementation supports. If
        /// only one serviceName is specified and it has a weight greater than 0, 100% of the traffic is forwarded to
        /// that backend. If weights are specified for any one service name, they need to be specified for all of them.
        /// If weights are unspecified for all services, then, traffic is distributed in equal proportions to all of
        /// them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weight")]
        public virtual System.Nullable<int> Weight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The specification for fault injection introduced into traffic to test the resiliency of clients to destination
    /// service failure. As part of fault injection, when clients send requests to a destination, delays can be
    /// introduced on a percentage of requests before sending those requests to the destination service. Similarly
    /// requests from clients can be aborted by for a percentage of requests.
    /// </summary>
    public class GrpcRouteFaultInjectionPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The specification for aborting to client requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("abort")]
        public virtual GrpcRouteFaultInjectionPolicyAbort Abort { get; set; }

        /// <summary>The specification for injecting delay to client requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delay")]
        public virtual GrpcRouteFaultInjectionPolicyDelay Delay { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specification of how client requests are aborted as part of fault injection before being sent to a destination.
    /// </summary>
    public class GrpcRouteFaultInjectionPolicyAbort : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The HTTP status code used to abort the request. The value must be between 200 and 599 inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpStatus")]
        public virtual System.Nullable<int> HttpStatus { get; set; }

        /// <summary>The percentage of traffic which will be aborted. The value must be between [0, 100]</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentage")]
        public virtual System.Nullable<int> Percentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specification of how client requests are delayed as part of fault injection before being sent to a destination.
    /// </summary>
    public class GrpcRouteFaultInjectionPolicyDelay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specify a fixed delay before forwarding the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedDelay")]
        public virtual object FixedDelay { get; set; }

        /// <summary>
        /// The percentage of traffic on which delay will be injected. The value must be between [0, 100]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentage")]
        public virtual System.Nullable<int> Percentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A match against a collection of headers.</summary>
    public class GrpcRouteHeaderMatch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The key of the header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// Optional. Specifies how to match against the value of the header. If not specified, a default value of EXACT
        /// is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Required. The value of the header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies a match against a method.</summary>
    public class GrpcRouteMethodMatch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specifies that matches are case sensitive. The default value is true. case_sensitive must not be
        /// used with a type of REGULAR_EXPRESSION.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseSensitive")]
        public virtual System.Nullable<bool> CaseSensitive { get; set; }

        /// <summary>Required. Name of the method to match against. If unspecified, will match all methods.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grpcMethod")]
        public virtual string GrpcMethod { get; set; }

        /// <summary>Required. Name of the service to match against. If unspecified, will match all services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grpcService")]
        public virtual string GrpcService { get; set; }

        /// <summary>
        /// Optional. Specifies how to match against the name. If not specified, a default value of "EXACT" is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The specifications for retries.</summary>
    public class GrpcRouteRetryPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the allowed number of retries. This number must be &amp;gt; 0. If not specified, default to 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numRetries")]
        public virtual System.Nullable<long> NumRetries { get; set; }

        /// <summary>
        /// - connect-failure: Router will retry on failures connecting to Backend Services, for example due to
        /// connection timeouts. - refused-stream: Router will retry if the backend service resets the stream with a
        /// REFUSED_STREAM error code. This reset type indicates that it is safe to retry. - cancelled: Router will
        /// retry if the gRPC status code in the response header is set to cancelled - deadline-exceeded: Router will
        /// retry if the gRPC status code in the response header is set to deadline-exceeded - resource-exhausted:
        /// Router will retry if the gRPC status code in the response header is set to resource-exhausted - unavailable:
        /// Router will retry if the gRPC status code in the response header is set to unavailable
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retryConditions")]
        public virtual System.Collections.Generic.IList<string> RetryConditions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies how to route matched traffic.</summary>
    public class GrpcRouteRouteAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The destination services to which traffic should be forwarded. If multiple destinations are
        /// specified, traffic will be split between Backend Service(s) according to the weight field of these
        /// destinations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual System.Collections.Generic.IList<GrpcRouteDestination> Destinations { get; set; }

        /// <summary>
        /// Optional. The specification for fault injection introduced into traffic to test the resiliency of clients to
        /// destination service failure. As part of fault injection, when clients send requests to a destination, delays
        /// can be introduced on a percentage of requests before sending those requests to the destination service.
        /// Similarly requests from clients can be aborted by for a percentage of requests. timeout and retry_policy
        /// will be ignored by clients that are configured with a fault_injection_policy
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faultInjectionPolicy")]
        public virtual GrpcRouteFaultInjectionPolicy FaultInjectionPolicy { get; set; }

        /// <summary>Optional. Specifies the retry policy associated with this route.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retryPolicy")]
        public virtual GrpcRouteRetryPolicy RetryPolicy { get; set; }

        /// <summary>
        /// Optional. Specifies the timeout for selected route. Timeout is computed from the time the request has been
        /// fully processed (i.e. end of stream) up until the response has been completely processed. Timeout includes
        /// all retries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Criteria for matching traffic. A RouteMatch will be considered to match when all supplied fields match.
    /// </summary>
    public class GrpcRouteRouteMatch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Specifies a collection of headers to match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IList<GrpcRouteHeaderMatch> Headers { get; set; }

        /// <summary>
        /// Optional. A gRPC method to match against. If this field is empty or omitted, will match all methods.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual GrpcRouteMethodMatch Method { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes how to route traffic.</summary>
    public class GrpcRouteRouteRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A detailed rule defining how to route traffic. This field is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual GrpcRouteRouteAction Action { get; set; }

        /// <summary>
        /// Optional. Matches define conditions used for matching the rule against incoming gRPC requests. Each match is
        /// independent, i.e. this rule will be matched if ANY one of the matches is satisfied. If no matches field is
        /// specified, this rule will unconditionally match traffic.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matches")]
        public virtual System.Collections.Generic.IList<GrpcRouteRouteMatch> Matches { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// HttpRoute is the resource defining how HTTP traffic should be routed by a Mesh or Gateway resource.
    /// </summary>
    public class HttpRoute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The timestamp when the resource was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Optional. A free-text description of the resource. Max length 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Gateways defines a list of gateways this HttpRoute is attached to, as one of the routing rules to
        /// route the requests served by the gateway. Each gateway reference should match the pattern:
        /// `projects/*/locations/global/gateways/`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gateways")]
        public virtual System.Collections.Generic.IList<string> Gateways { get; set; }

        /// <summary>
        /// Required. Hostnames define a set of hosts that should match against the HTTP host header to select a
        /// HttpRoute to process the request. Hostname is the fully qualified domain name of a network host, as defined
        /// by RFC 1123 with the exception that: - IPs are not allowed. - A hostname may be prefixed with a wildcard
        /// label (*.). The wildcard label must appear by itself as the first label. Hostname can be "precise" which is
        /// a domain name without the terminating dot of a network host (e.g. "foo.example.com") or "wildcard", which is
        /// a domain name prefixed with a single wildcard label (e.g. *.example.com). Note that as per RFC1035 and
        /// RFC1123, a label must consist of lower case alphanumeric characters or '-', and must start and end with an
        /// alphanumeric character. No other punctuation is allowed. The routes associated with a Mesh or Gateways must
        /// have unique hostnames. If you attempt to attach multiple routes with conflicting hostnames, the
        /// configuration will be rejected. For example, while it is acceptable for routes for the hostnames
        /// "*.foo.bar.com" and "*.bar.com" to be associated with the same Mesh (or Gateways under the same scope), it
        /// is not possible to associate two routes both with "*.bar.com" or both with "bar.com".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostnames")]
        public virtual System.Collections.Generic.IList<string> Hostnames { get; set; }

        /// <summary>Optional. Set of label tags associated with the HttpRoute resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. Meshes defines a list of meshes this HttpRoute is attached to, as one of the routing rules to
        /// route the requests served by the mesh. Each mesh reference should match the pattern:
        /// `projects/*/locations/global/meshes/` The attached Mesh should be of a type SIDECAR
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meshes")]
        public virtual System.Collections.Generic.IList<string> Meshes { get; set; }

        /// <summary>
        /// Required. Name of the HttpRoute resource. It matches pattern
        /// `projects/*/locations/global/httpRoutes/http_route_name&amp;gt;`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Rules that define how traffic is routed and handled. Rules will be matched sequentially based on
        /// the RouteMatch specified for the rule.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<HttpRouteRouteRule> Rules { get; set; }

        /// <summary>Output only. Server-defined URL of this resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Output only. The timestamp when the resource was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Specification for allowing client side cross-origin requests.</summary>
    public class HttpRouteCorsPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// In response to a preflight request, setting this to true indicates that the actual request can include user
        /// credentials. This translates to the Access-Control-Allow-Credentials header. Default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowCredentials")]
        public virtual System.Nullable<bool> AllowCredentials { get; set; }

        /// <summary>Specifies the content for Access-Control-Allow-Headers header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowHeaders")]
        public virtual System.Collections.Generic.IList<string> AllowHeaders { get; set; }

        /// <summary>Specifies the content for Access-Control-Allow-Methods header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowMethods")]
        public virtual System.Collections.Generic.IList<string> AllowMethods { get; set; }

        /// <summary>
        /// Specifies the regular expression patterns that match allowed origins. For regular expression grammar, please
        /// see https://github.com/google/re2/wiki/Syntax.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowOriginRegexes")]
        public virtual System.Collections.Generic.IList<string> AllowOriginRegexes { get; set; }

        /// <summary>
        /// Specifies the list of origins that will be allowed to do CORS requests. An origin is allowed if it matches
        /// either an item in allow_origins or an item in allow_origin_regexes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowOrigins")]
        public virtual System.Collections.Generic.IList<string> AllowOrigins { get; set; }

        /// <summary>
        /// If true, the CORS policy is disabled. The default value is false, which indicates that the CORS policy is in
        /// effect.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>Specifies the content for Access-Control-Expose-Headers header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exposeHeaders")]
        public virtual System.Collections.Generic.IList<string> ExposeHeaders { get; set; }

        /// <summary>
        /// Specifies how long result of a preflight request can be cached in seconds. This translates to the
        /// Access-Control-Max-Age header.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxAge")]
        public virtual string MaxAge { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifications of a destination to which the request should be routed to.</summary>
    public class HttpRouteDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URL of a BackendService to route traffic to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>
        /// Specifies the proportion of requests forwarded to the backend referenced by the serviceName field. This is
        /// computed as: weight/Sum(weights in this destination list). For non-zero values, there may be some epsilon
        /// from the exact proportion defined here depending on the precision an implementation supports. If only one
        /// serviceName is specified and it has a weight greater than 0, 100% of the traffic is forwarded to that
        /// backend. If weights are specified for any one service name, they need to be specified for all of them. If
        /// weights are unspecified for all services, then, traffic is distributed in equal proportions to all of them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weight")]
        public virtual System.Nullable<int> Weight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The specification for fault injection introduced into traffic to test the resiliency of clients to destination
    /// service failure. As part of fault injection, when clients send requests to a destination, delays can be
    /// introduced by client proxy on a percentage of requests before sending those requests to the destination service.
    /// Similarly requests can be aborted by client proxy for a percentage of requests.
    /// </summary>
    public class HttpRouteFaultInjectionPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The specification for aborting to client requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("abort")]
        public virtual HttpRouteFaultInjectionPolicyAbort Abort { get; set; }

        /// <summary>The specification for injecting delay to client requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delay")]
        public virtual HttpRouteFaultInjectionPolicyDelay Delay { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specification of how client requests are aborted as part of fault injection before being sent to a destination.
    /// </summary>
    public class HttpRouteFaultInjectionPolicyAbort : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The HTTP status code used to abort the request. The value must be between 200 and 599 inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpStatus")]
        public virtual System.Nullable<int> HttpStatus { get; set; }

        /// <summary>The percentage of traffic which will be aborted. The value must be between [0, 100]</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentage")]
        public virtual System.Nullable<int> Percentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specification of how client requests are delayed as part of fault injection before being sent to a destination.
    /// </summary>
    public class HttpRouteFaultInjectionPolicyDelay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specify a fixed delay before forwarding the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedDelay")]
        public virtual object FixedDelay { get; set; }

        /// <summary>
        /// The percentage of traffic on which delay will be injected. The value must be between [0, 100]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentage")]
        public virtual System.Nullable<int> Percentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies how to select a route rule based on HTTP request headers.</summary>
    public class HttpRouteHeaderMatch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The value of the header should match exactly the content of exact_match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exactMatch")]
        public virtual string ExactMatch { get; set; }

        /// <summary>The name of the HTTP header to match against.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual string Header { get; set; }

        /// <summary>
        /// If specified, the match result will be inverted before checking. Default value is set to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invertMatch")]
        public virtual System.Nullable<bool> InvertMatch { get; set; }

        /// <summary>The value of the header must start with the contents of prefix_match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prefixMatch")]
        public virtual string PrefixMatch { get; set; }

        /// <summary>
        /// A header with header_name must exist. The match takes place whether or not the header has a value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("presentMatch")]
        public virtual System.Nullable<bool> PresentMatch { get; set; }

        /// <summary>If specified, the rule will match if the request header value is within the range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rangeMatch")]
        public virtual HttpRouteHeaderMatchIntegerRange RangeMatch { get; set; }

        /// <summary>
        /// The value of the header must match the regular expression specified in regex_match. For regular expression
        /// grammar, please see: https://github.com/google/re2/wiki/Syntax
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regexMatch")]
        public virtual string RegexMatch { get; set; }

        /// <summary>The value of the header must end with the contents of suffix_match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suffixMatch")]
        public virtual string SuffixMatch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an integer value range.</summary>
    public class HttpRouteHeaderMatchIntegerRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>End of the range (exclusive)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("end")]
        public virtual System.Nullable<int> End { get; set; }

        /// <summary>Start of the range (inclusive)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("start")]
        public virtual System.Nullable<int> Start { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The specification for modifying HTTP header in HTTP request and HTTP response.</summary>
    public class HttpRouteHeaderModifier : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Add the headers with given map where key is the name of the header, value is the value of the header.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("add")]
        public virtual System.Collections.Generic.IDictionary<string, string> Add { get; set; }

        /// <summary>Remove headers (matching by header names) specified in the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remove")]
        public virtual System.Collections.Generic.IList<string> Remove { get; set; }

        /// <summary>
        /// Completely overwrite/replace the headers with given map where key is the name of the header, value is the
        /// value of the header.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("set")]
        public virtual System.Collections.Generic.IDictionary<string, string> Set { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifications to match a query parameter in the request.</summary>
    public class HttpRouteQueryParameterMatch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The value of the query parameter must exactly match the contents of exact_match. Only one of exact_match,
        /// regex_match, or present_match must be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exactMatch")]
        public virtual string ExactMatch { get; set; }

        /// <summary>
        /// Specifies that the QueryParameterMatcher matches if request contains query parameter, irrespective of
        /// whether the parameter has a value or not. Only one of exact_match, regex_match, or present_match must be
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("presentMatch")]
        public virtual System.Nullable<bool> PresentMatch { get; set; }

        /// <summary>The name of the query parameter to match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryParameter")]
        public virtual string QueryParameter { get; set; }

        /// <summary>
        /// The value of the query parameter must match the regular expression specified by regex_match. For regular
        /// expression grammar, please see https://github.com/google/re2/wiki/Syntax Only one of exact_match,
        /// regex_match, or present_match must be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regexMatch")]
        public virtual string RegexMatch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The specification for redirecting traffic.</summary>
    public class HttpRouteRedirect : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The host that will be used in the redirect response instead of the one that was supplied in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostRedirect")]
        public virtual string HostRedirect { get; set; }

        /// <summary>
        /// If set to true, the URL scheme in the redirected request is set to https. If set to false, the URL scheme of
        /// the redirected request will remain the same as that of the request. The default is set to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpsRedirect")]
        public virtual System.Nullable<bool> HttpsRedirect { get; set; }

        /// <summary>
        /// The path that will be used in the redirect response instead of the one that was supplied in the request.
        /// path_redirect can not be supplied together with prefix_redirect. Supply one alone or neither. If neither is
        /// supplied, the path of the original request will be used for the redirect.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pathRedirect")]
        public virtual string PathRedirect { get; set; }

        /// <summary>
        /// The port that will be used in the redirected request instead of the one that was supplied in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("portRedirect")]
        public virtual System.Nullable<int> PortRedirect { get; set; }

        /// <summary>
        /// Indicates that during redirection, the matched prefix (or path) should be swapped with this value. This
        /// option allows URLs be dynamically created based on the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prefixRewrite")]
        public virtual string PrefixRewrite { get; set; }

        /// <summary>The HTTP Status code to use for the redirect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseCode")]
        public virtual string ResponseCode { get; set; }

        /// <summary>
        /// if set to true, any accompanying query portion of the original URL is removed prior to redirecting the
        /// request. If set to false, the query portion of the original URL is retained. The default is set to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stripQuery")]
        public virtual System.Nullable<bool> StripQuery { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies the policy on how requests are shadowed to a separate mirrored destination service. The proxy does not
    /// wait for responses from the shadow service. Prior to sending traffic to the shadow service, the host/authority
    /// header is suffixed with -shadow.
    /// </summary>
    public class HttpRouteRequestMirrorPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The destination the requests will be mirrored to. The weight of the destination will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual HttpRouteDestination Destination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The specifications for retries.</summary>
    public class HttpRouteRetryPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the allowed number of retries. This number must be &amp;gt; 0. If not specified, default to 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numRetries")]
        public virtual System.Nullable<int> NumRetries { get; set; }

        /// <summary>Specifies a non-zero timeout per retry attempt.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("perTryTimeout")]
        public virtual object PerTryTimeout { get; set; }

        /// <summary>
        /// Specifies one or more conditions when this retry policy applies. Valid values are: 5xx: Proxy will attempt a
        /// retry if the destination service responds with any 5xx response code, of if the destination service does not
        /// respond at all, example: disconnect, reset, read timeout, connection failure and refused streams.
        /// gateway-error: Similar to 5xx, but only applies to response codes 502, 503, 504. reset: Proxy will attempt a
        /// retry if the destination service does not respond at all (disconnect/reset/read timeout) connect-failure:
        /// Proxy will retry on failures connecting to destination for example due to connection timeouts.
        /// retriable-4xx: Proxy will retry fro retriable 4xx response codes. Currently the only retriable error
        /// supported is 409. refused-stream: Proxy will retry if the destination resets the stream with a
        /// REFUSED_STREAM error code. This reset type indicates that it is safe to retry.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retryConditions")]
        public virtual System.Collections.Generic.IList<string> RetryConditions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The specifications for routing traffic and applying associated policies.</summary>
    public class HttpRouteRouteAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The specification for allowing client side cross-origin requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("corsPolicy")]
        public virtual HttpRouteCorsPolicy CorsPolicy { get; set; }

        /// <summary>The destination to which traffic should be forwarded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual System.Collections.Generic.IList<HttpRouteDestination> Destinations { get; set; }

        /// <summary>
        /// The specification for fault injection introduced into traffic to test the resiliency of clients to backend
        /// service failure. As part of fault injection, when clients send requests to a backend service, delays can be
        /// introduced on a percentage of requests before sending those requests to the backend service. Similarly
        /// requests from clients can be aborted for a percentage of requests. timeout and retry_policy will be ignored
        /// by clients that are configured with a fault_injection_policy
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faultInjectionPolicy")]
        public virtual HttpRouteFaultInjectionPolicy FaultInjectionPolicy { get; set; }

        /// <summary>If set, the request is directed as configured by this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redirect")]
        public virtual HttpRouteRedirect Redirect { get; set; }

        /// <summary>
        /// The specification for modifying the headers of a matching request prior to delivery of the request to the
        /// destination.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestHeaderModifier")]
        public virtual HttpRouteHeaderModifier RequestHeaderModifier { get; set; }

        /// <summary>
        /// Specifies the policy on how requests intended for the routes destination are shadowed to a separate mirrored
        /// destination. Proxy will not wait for the shadow destination to respond before returning the response. Prior
        /// to sending traffic to the shadow service, the host/authority header is suffixed with -shadow.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestMirrorPolicy")]
        public virtual HttpRouteRequestMirrorPolicy RequestMirrorPolicy { get; set; }

        /// <summary>
        /// The specification for modifying the headers of a response prior to sending the response back to the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseHeaderModifier")]
        public virtual HttpRouteHeaderModifier ResponseHeaderModifier { get; set; }

        /// <summary>Specifies the retry policy associated with this route.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retryPolicy")]
        public virtual HttpRouteRetryPolicy RetryPolicy { get; set; }

        /// <summary>
        /// Specifies the timeout for selected route. Timeout is computed from the time the request has been fully
        /// processed (i.e. end of stream) up until the response has been completely processed. Timeout includes all
        /// retries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>The specification for rewrite URL before forwarding requests to the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlRewrite")]
        public virtual HttpRouteURLRewrite UrlRewrite { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// RouteMatch defines specifications used to match requests. If multiple match types are set, this RouteMatch will
    /// match if ALL type of matches are matched.
    /// </summary>
    public class HttpRouteRouteMatch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The HTTP request path value should exactly match this value. Only one of full_path_match, prefix_match, or
        /// regex_match should be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullPathMatch")]
        public virtual string FullPathMatch { get; set; }

        /// <summary>
        /// Specifies a list of HTTP request headers to match against. ALL of the supplied headers must be matched.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IList<HttpRouteHeaderMatch> Headers { get; set; }

        /// <summary>
        /// Specifies if prefix_match and full_path_match matches are case sensitive. The default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreCase")]
        public virtual System.Nullable<bool> IgnoreCase { get; set; }

        /// <summary>
        /// The HTTP request path value must begin with specified prefix_match. prefix_match must begin with a /. Only
        /// one of full_path_match, prefix_match, or regex_match should be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prefixMatch")]
        public virtual string PrefixMatch { get; set; }

        /// <summary>
        /// Specifies a list of query parameters to match against. ALL of the query parameters must be matched.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryParameters")]
        public virtual System.Collections.Generic.IList<HttpRouteQueryParameterMatch> QueryParameters { get; set; }

        /// <summary>
        /// The HTTP request path value must satisfy the regular expression specified by regex_match after removing any
        /// query parameters and anchor supplied with the original URL. For regular expression grammar, please see
        /// https://github.com/google/re2/wiki/Syntax Only one of full_path_match, prefix_match, or regex_match should
        /// be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regexMatch")]
        public virtual string RegexMatch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies how to match traffic and how to route traffic when traffic is matched.</summary>
    public class HttpRouteRouteRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The detailed rule defining how to route matched traffic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual HttpRouteRouteAction Action { get; set; }

        /// <summary>
        /// A list of matches define conditions used for matching the rule against incoming HTTP requests. Each match is
        /// independent, i.e. this rule will be matched if ANY one of the matches is satisfied. If no matches field is
        /// specified, this rule will unconditionally match traffic. If a default rule is desired to be configured, add
        /// a rule with no matches specified to the end of the rules list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matches")]
        public virtual System.Collections.Generic.IList<HttpRouteRouteMatch> Matches { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The specification for modifying the URL of the request, prior to forwarding the request to the destination.
    /// </summary>
    public class HttpRouteURLRewrite : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Prior to forwarding the request to the selected destination, the requests host header is replaced by this
        /// value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostRewrite")]
        public virtual string HostRewrite { get; set; }

        /// <summary>
        /// Prior to forwarding the request to the selected destination, the matching portion of the requests path is
        /// replaced by this value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pathPrefixRewrite")]
        public virtual string PathPrefixRewrite { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response returned by the ListEndpointPolicies method.</summary>
    public class ListEndpointPoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of EndpointPolicy resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointPolicies")]
        public virtual System.Collections.Generic.IList<EndpointPolicy> EndpointPolicies { get; set; }

        /// <summary>
        /// If there might be more results than those appearing in this response, then `next_page_token` is included. To
        /// get the next set of results, call this method again using the value of `next_page_token` as `page_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response returned by the ListGateways method.</summary>
    public class ListGatewaysResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of Gateway resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gateways")]
        public virtual System.Collections.Generic.IList<Gateway> Gateways { get; set; }

        /// <summary>
        /// If there might be more results than those appearing in this response, then `next_page_token` is included. To
        /// get the next set of results, call this method again using the value of `next_page_token` as `page_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response returned by the ListGrpcRoutes method.</summary>
    public class ListGrpcRoutesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of GrpcRoute resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grpcRoutes")]
        public virtual System.Collections.Generic.IList<GrpcRoute> GrpcRoutes { get; set; }

        /// <summary>
        /// If there might be more results than those appearing in this response, then `next_page_token` is included. To
        /// get the next set of results, call this method again using the value of `next_page_token` as `page_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response returned by the ListHttpRoutes method.</summary>
    public class ListHttpRoutesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of HttpRoute resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpRoutes")]
        public virtual System.Collections.Generic.IList<HttpRoute> HttpRoutes { get; set; }

        /// <summary>
        /// If there might be more results than those appearing in this response, then `next_page_token` is included. To
        /// get the next set of results, call this method again using the value of `next_page_token` as `page_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

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

    /// <summary>Response returned by the ListMeshes method.</summary>
    public class ListMeshesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of Mesh resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meshes")]
        public virtual System.Collections.Generic.IList<Mesh> Meshes { get; set; }

        /// <summary>
        /// If there might be more results than those appearing in this response, then `next_page_token` is included. To
        /// get the next set of results, call this method again using the value of `next_page_token` as `page_token`.
        /// </summary>
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

    /// <summary>Response returned by the ListServiceBindings method.</summary>
    public class ListServiceBindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If there might be more results than those appearing in this response, then `next_page_token` is included. To
        /// get the next set of results, call this method again using the value of `next_page_token` as `page_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of ServiceBinding resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceBindings")]
        public virtual System.Collections.Generic.IList<ServiceBinding> ServiceBindings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response returned by the ListTcpRoutes method.</summary>
    public class ListTcpRoutesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If there might be more results than those appearing in this response, then `next_page_token` is included. To
        /// get the next set of results, call this method again using the value of `next_page_token` as `page_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of TcpRoute resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tcpRoutes")]
        public virtual System.Collections.Generic.IList<TcpRoute> TcpRoutes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response returned by the ListTlsRoutes method.</summary>
    public class ListTlsRoutesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If there might be more results than those appearing in this response, then `next_page_token` is included. To
        /// get the next set of results, call this method again using the value of `next_page_token` as `page_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of TlsRoute resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tlsRoutes")]
        public virtual System.Collections.Generic.IList<TlsRoute> TlsRoutes { get; set; }

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

    /// <summary>
    /// Mesh represents a logical configuration grouping for workload to workload communication within a service mesh.
    /// Routes that point to mesh dictate how requests are routed within this logical mesh boundary.
    /// </summary>
    public class Mesh : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The timestamp when the resource was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Optional. A free-text description of the resource. Max length 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. If set to a valid TCP port (1-65535), instructs the SIDECAR proxy to listen on the specified port
        /// of localhost (127.0.0.1) address. The SIDECAR proxy will expect all traffic to be redirected to this port
        /// regardless of its actual ip:port destination. If unset, a port '15001' is used as the interception port.
        /// This will is applicable only for sidecar proxy deployments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interceptionPort")]
        public virtual System.Nullable<int> InterceptionPort { get; set; }

        /// <summary>Optional. Set of label tags associated with the Mesh resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. Name of the Mesh resource. It matches pattern `projects/*/locations/global/meshes/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Server-defined URL of this resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Output only. The timestamp when the resource was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The matcher that is based on node metadata presented by xDS clients.</summary>
    public class MetadataLabelMatcher : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies how matching should be done. Supported values are: MATCH_ANY: At least one of the Labels specified
        /// in the matcher should match the metadata presented by xDS client. MATCH_ALL: The metadata presented by the
        /// xDS client should contain all of the labels specified here. The selection is determined based on the best
        /// match. For example, suppose there are three EndpointPolicy resources P1, P2 and P3 and if P1 has a the
        /// matcher as MATCH_ANY , P2 has MATCH_ALL , and P3 has MATCH_ALL . If a client with label connects, the config
        /// from P1 will be selected. If a client with label connects, the config from P2 will be selected. If a client
        /// with label connects, the config from P3 will be selected. If there is more than one best match, (for
        /// example, if a config P4 with selector exists and if a client with label connects), an error will be thrown.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadataLabelMatchCriteria")]
        public virtual string MetadataLabelMatchCriteria { get; set; }

        /// <summary>
        /// The list of label value pairs that must match labels in the provided metadata based on filterMatchCriteria
        /// This list can have at most 64 entries. The list can be empty if the match criteria is MATCH_ANY, to specify
        /// a wildcard match (i.e this matches any client).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadataLabels")]
        public virtual System.Collections.Generic.IList<MetadataLabels> MetadataLabels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines a name-pair value for a single label.</summary>
    public class MetadataLabels : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Label name presented as key in xDS Node Metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelName")]
        public virtual string LabelName { get; set; }

        /// <summary>
        /// Required. Label value presented as value corresponding to the above key, in xDS Node Metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelValue")]
        public virtual string LabelValue { get; set; }

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
    /// `Policy` is a collection of `bindings`. A `binding` binds one or more `members`, or principals, to a single
    /// `role`. Principals can be user accounts, service accounts, Google groups, and domains (such as G Suite). A
    /// `role` is a named list of permissions; each `role` can be an IAM predefined role or a user-created custom role.
    /// For some types of Google Cloud resources, a `binding` can also specify a `condition`, which is a logical
    /// expression that allows access to a resource only if the expression evaluates to `true`. A condition can add
    /// constraints based on attributes of the request, the resource, or both. To learn which resources support
    /// conditions in their IAM policies, see the [IAM
    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:** { "bindings":
    /// [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 } **YAML example:**
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') etag: BwWWja0YfJA= version: 3 For a description of IAM and its features,
    /// see the [IAM documentation](https://cloud.google.com/iam/docs/).
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

    /// <summary>
    /// ServiceBinding is the resource that defines a Service Directory Service to be used in a BackendService resource.
    /// </summary>
    public class ServiceBinding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The timestamp when the resource was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Optional. A free-text description of the resource. Max length 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. Set of label tags associated with the ServiceBinding resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. Name of the ServiceBinding resource. It matches pattern
        /// `projects/*/locations/global/serviceBindings/service_binding_name`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The full Service Directory Service name of the format
        /// projects/*/locations/*/namespaces/*/services/*
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>Output only. The timestamp when the resource was updated.</summary>
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
    /// TcpRoute is the resource defining how TCP traffic should be routed by a Mesh/Gateway resource.
    /// </summary>
    public class TcpRoute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The timestamp when the resource was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Optional. A free-text description of the resource. Max length 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Gateways defines a list of gateways this TcpRoute is attached to, as one of the routing rules to
        /// route the requests served by the gateway. Each gateway reference should match the pattern:
        /// `projects/*/locations/global/gateways/`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gateways")]
        public virtual System.Collections.Generic.IList<string> Gateways { get; set; }

        /// <summary>Optional. Set of label tags associated with the TcpRoute resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. Meshes defines a list of meshes this TcpRoute is attached to, as one of the routing rules to route
        /// the requests served by the mesh. Each mesh reference should match the pattern:
        /// `projects/*/locations/global/meshes/` The attached Mesh should be of a type SIDECAR
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meshes")]
        public virtual System.Collections.Generic.IList<string> Meshes { get; set; }

        /// <summary>
        /// Required. Name of the TcpRoute resource. It matches pattern
        /// `projects/*/locations/global/tcpRoutes/tcp_route_name&amp;gt;`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Rules that define how traffic is routed and handled. At least one RouteRule must be supplied. If
        /// there are multiple rules then the action taken will be the first rule to match.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<TcpRouteRouteRule> Rules { get; set; }

        /// <summary>Output only. Server-defined URL of this resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Output only. The timestamp when the resource was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The specifications for routing traffic and applying associated policies.</summary>
    public class TcpRouteRouteAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The destination services to which traffic should be forwarded. At least one destination service is
        /// required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual System.Collections.Generic.IList<TcpRouteRouteDestination> Destinations { get; set; }

        /// <summary>
        /// Optional. If true, Router will use the destination IP and port of the original connection as the destination
        /// of the request. Default is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalDestination")]
        public virtual System.Nullable<bool> OriginalDestination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describe the destination for traffic to be routed to.</summary>
    public class TcpRouteRouteDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The URL of a BackendService to route traffic to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>
        /// Optional. Specifies the proportion of requests forwarded to the backend referenced by the serviceName field.
        /// This is computed as: weight/Sum(weights in this destination list). For non-zero values, there may be some
        /// epsilon from the exact proportion defined here depending on the precision an implementation supports. If
        /// only one serviceName is specified and it has a weight greater than 0, 100% of the traffic is forwarded to
        /// that backend. If weights are specified for any one service name, they need to be specified for all of them.
        /// If weights are unspecified for all services, then, traffic is distributed in equal proportions to all of
        /// them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weight")]
        public virtual System.Nullable<int> Weight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// RouteMatch defines the predicate used to match requests to a given action. Multiple match types are "OR"ed for
    /// evaluation. If no routeMatch field is specified, this rule will unconditionally match traffic.
    /// </summary>
    public class TcpRouteRouteMatch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Must be specified in the CIDR range format. A CIDR range consists of an IP Address and a prefix
        /// length to construct the subnet mask. By default, the prefix length is 32 (i.e. matches a single IP address).
        /// Only IPV4 addresses are supported. Examples: "10.0.0.1" - matches against this exact IP address.
        /// "10.0.0.0/8" - matches against any IP address within the 10.0.0.0 subnet and 255.255.255.0 mask. "0.0.0.0/0"
        /// - matches against any IP address'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; }

        /// <summary>Required. Specifies the destination port to match against.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual string Port { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies how to match traffic and how to route traffic when traffic is matched.</summary>
    public class TcpRouteRouteRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The detailed rule defining how to route matched traffic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual TcpRouteRouteAction Action { get; set; }

        /// <summary>
        /// Optional. RouteMatch defines the predicate used to match requests to a given action. Multiple match types
        /// are "OR"ed for evaluation. If no routeMatch field is specified, this rule will unconditionally match
        /// traffic.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matches")]
        public virtual System.Collections.Generic.IList<TcpRouteRouteMatch> Matches { get; set; }

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

    /// <summary>TlsRoute defines how traffic should be routed based on SNI and other matching L3 attributes.</summary>
    public class TlsRoute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The timestamp when the resource was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Optional. A free-text description of the resource. Max length 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Gateways defines a list of gateways this TlsRoute is attached to, as one of the routing rules to
        /// route the requests served by the gateway. Each gateway reference should match the pattern:
        /// `projects/*/locations/global/gateways/`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gateways")]
        public virtual System.Collections.Generic.IList<string> Gateways { get; set; }

        /// <summary>
        /// Optional. Meshes defines a list of meshes this TlsRoute is attached to, as one of the routing rules to route
        /// the requests served by the mesh. Each mesh reference should match the pattern:
        /// `projects/*/locations/global/meshes/` The attached Mesh should be of a type SIDECAR
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meshes")]
        public virtual System.Collections.Generic.IList<string> Meshes { get; set; }

        /// <summary>
        /// Required. Name of the TlsRoute resource. It matches pattern
        /// `projects/*/locations/global/tlsRoutes/tls_route_name&amp;gt;`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Rules that define how traffic is routed and handled. At least one RouteRule must be supplied. If
        /// there are multiple rules then the action taken will be the first rule to match.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<TlsRouteRouteRule> Rules { get; set; }

        /// <summary>Output only. Server-defined URL of this resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Output only. The timestamp when the resource was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The specifications for routing traffic and applying associated policies.</summary>
    public class TlsRouteRouteAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The destination services to which traffic should be forwarded. At least one destination service is
        /// required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual System.Collections.Generic.IList<TlsRouteRouteDestination> Destinations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describe the destination for traffic to be routed to.</summary>
    public class TlsRouteRouteDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The URL of a BackendService to route traffic to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>
        /// Optional. Specifies the proportion of requests forwareded to the backend referenced by the service_name
        /// field. This is computed as: weight/Sum(weights in destinations) Weights in all destinations does not need to
        /// sum up to 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weight")]
        public virtual System.Nullable<int> Weight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// RouteMatch defines the predicate used to match requests to a given action. Multiple match types are "AND"ed for
    /// evaluation. If no routeMatch field is specified, this rule will unconditionally match traffic.
    /// </summary>
    public class TlsRouteRouteMatch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. ALPN (Application-Layer Protocol Negotiation) to match against. Examples: "http/1.1", "h2". At
        /// least one of sni_host and alpn is required. Up to 5 alpns across all matches can be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alpn")]
        public virtual System.Collections.Generic.IList<string> Alpn { get; set; }

        /// <summary>
        /// Optional. SNI (server name indicator) to match against. SNI will be matched against all wildcard domains,
        /// i.e. www.example.com will be first matched against www.example.com, then *.example.com, then *.com. Partial
        /// wildcards are not supported, and values like *w.example.com are invalid. At least one of sni_host and alpn
        /// is required. Up to 5 sni hosts across all matches can be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sniHost")]
        public virtual System.Collections.Generic.IList<string> SniHost { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies how to match traffic and how to route traffic when traffic is matched.</summary>
    public class TlsRouteRouteRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The detailed rule defining how to route matched traffic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual TlsRouteRouteAction Action { get; set; }

        /// <summary>
        /// Required. RouteMatch defines the predicate used to match requests to a given action. Multiple match types
        /// are "OR"ed for evaluation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matches")]
        public virtual System.Collections.Generic.IList<TlsRouteRouteMatch> Matches { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specification of a port-based selector.</summary>
    public class TrafficPortSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A list of ports. Can be port numbers or port range (example, [80-90] specifies all ports from 80
        /// to 90, including 80 and 90) or named ports or * to specify all ports. If the list is empty, all ports are
        /// selected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ports")]
        public virtual System.Collections.Generic.IList<string> Ports { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
