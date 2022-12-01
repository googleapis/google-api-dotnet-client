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

namespace Google.Apis.ApigeeRegistry.v1
{
    /// <summary>The ApigeeRegistry Service.</summary>
    public class ApigeeRegistryService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ApigeeRegistryService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ApigeeRegistryService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "apigeeregistry";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://apigeeregistry.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://apigeeregistry.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Apigee Registry API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Apigee Registry API.</summary>
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

    /// <summary>A base abstract class for ApigeeRegistry requests.</summary>
    public abstract class ApigeeRegistryBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ApigeeRegistryBaseServiceRequest instance.</summary>
        protected ApigeeRegistryBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes ApigeeRegistry parameter list.</summary>
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
                Apis = new ApisResource(service);
                Artifacts = new ArtifactsResource(service);
                Instances = new InstancesResource(service);
                Operations = new OperationsResource(service);
                Runtime = new RuntimeResource(service);
            }

            /// <summary>Gets the Apis resource.</summary>
            public virtual ApisResource Apis { get; }

            /// <summary>The "apis" collection of methods.</summary>
            public class ApisResource
            {
                private const string Resource = "apis";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ApisResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Artifacts = new ArtifactsResource(service);
                    Deployments = new DeploymentsResource(service);
                    Versions = new VersionsResource(service);
                }

                /// <summary>Gets the Artifacts resource.</summary>
                public virtual ArtifactsResource Artifacts { get; }

                /// <summary>The "artifacts" collection of methods.</summary>
                public class ArtifactsResource
                {
                    private const string Resource = "artifacts";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ArtifactsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a specified artifact.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent, which owns this collection of artifacts. Format: `{parent}`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.ApigeeRegistry.v1.Data.Artifact body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a specified artifact.</summary>
                    public class CreateRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Artifact>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.Artifact body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent, which owns this collection of artifacts. Format: `{parent}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID to use for the artifact, which will become the final component of the
                        /// artifact's resource name. This value should be 4-63 characters, and valid characters are
                        /// /a-z-/. Following AIP-162, IDs must not have the form of a UUID.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("artifactId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ArtifactId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ApigeeRegistry.v1.Data.Artifact Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/artifacts";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+$",
                            });
                            RequestParameters.Add("artifactId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "artifactId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Removes a specified artifact.</summary>
                    /// <param name="name">
                    /// Required. The name of the artifact to delete. Format: `{parent}/artifacts/*`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Removes a specified artifact.</summary>
                    public class DeleteRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the artifact to delete. Format: `{parent}/artifacts/*`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/artifacts/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns a specified artifact.</summary>
                    /// <param name="name">
                    /// Required. The name of the artifact to retrieve. Format: `{parent}/artifacts/*`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Returns a specified artifact.</summary>
                    public class GetRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Artifact>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the artifact to retrieve. Format: `{parent}/artifacts/*`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/artifacts/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Returns the contents of a specified artifact. If artifacts are stored with GZip compression, the
                    /// default behavior is to return the artifact uncompressed (the mime_type response field indicates
                    /// the exact format returned).
                    /// </summary>
                    /// <param name="name">
                    /// Required. The name of the artifact whose contents should be retrieved. Format:
                    /// `{parent}/artifacts/*`
                    /// </param>
                    public virtual GetContentsRequest GetContents(string name)
                    {
                        return new GetContentsRequest(service, name);
                    }

                    /// <summary>
                    /// Returns the contents of a specified artifact. If artifacts are stored with GZip compression, the
                    /// default behavior is to return the artifact uncompressed (the mime_type response field indicates
                    /// the exact format returned).
                    /// </summary>
                    public class GetContentsRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.HttpBody>
                    {
                        /// <summary>Constructs a new GetContents request.</summary>
                        public GetContentsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the artifact whose contents should be retrieved. Format:
                        /// `{parent}/artifacts/*`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getContents";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:getContents";

                        /// <summary>Initializes GetContents parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/artifacts/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
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
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    public class GetIamPolicyRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                        {
                            Resource = resource;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>
                        /// Optional. The maximum policy version that will be used to format the policy. Valid values
                        /// are 0, 1, and 3. Requests specifying an invalid value will be rejected. Requests for
                        /// policies with any conditional role bindings must specify version 3. Policies with no
                        /// conditional role bindings may specify any valid value or leave the field unset. The policy
                        /// in the response might use the policy version that you specified, or it might use a lower
                        /// policy version. For example, if you specify version 3, but the policy has no conditional
                        /// role bindings, the response uses version 1. To learn which resources support conditions in
                        /// their IAM policies, see the [IAM
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/artifacts/[^/]+$",
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

                    /// <summary>Returns matching artifacts.</summary>
                    /// <param name="parent">
                    /// Required. The parent, which owns this collection of artifacts. Format: `{parent}`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Returns matching artifacts.</summary>
                    public class ListRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ListArtifactsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent, which owns this collection of artifacts. Format: `{parent}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// An expression that can be used to filter the list. Filters use the Common Expression
                        /// Language and can refer to all message fields except contents.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// A comma-separated list of fields, e.g. "foo,bar" Fields can be sorted in descending order
                        /// using the "desc" identifier, e.g. "foo desc,bar"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// The maximum number of artifacts to return. The service may return fewer than this value. If
                        /// unspecified, at most 50 values will be returned. The maximum is 1000; values above 1000 will
                        /// be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListArtifacts` call. Provide this to retrieve the
                        /// subsequent page. When paginating, all other parameters provided to `ListArtifacts` must
                        /// match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/artifacts";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+$",
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

                    /// <summary>Used to replace a specified artifact.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Resource name.</param>
                    public virtual ReplaceArtifactRequest ReplaceArtifact(Google.Apis.ApigeeRegistry.v1.Data.Artifact body, string name)
                    {
                        return new ReplaceArtifactRequest(service, body, name);
                    }

                    /// <summary>Used to replace a specified artifact.</summary>
                    public class ReplaceArtifactRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Artifact>
                    {
                        /// <summary>Constructs a new ReplaceArtifact request.</summary>
                        public ReplaceArtifactRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.Artifact body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Resource name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ApigeeRegistry.v1.Data.Artifact Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "replaceArtifact";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PUT";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

                        /// <summary>Initializes ReplaceArtifact parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/artifacts/[^/]+$",
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
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    public class SetIamPolicyRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being specified. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/artifacts/[^/]+$",
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
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/artifacts/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the Deployments resource.</summary>
                public virtual DeploymentsResource Deployments { get; }

                /// <summary>The "deployments" collection of methods.</summary>
                public class DeploymentsResource
                {
                    private const string Resource = "deployments";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public DeploymentsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Artifacts = new ArtifactsResource(service);
                    }

                    /// <summary>Gets the Artifacts resource.</summary>
                    public virtual ArtifactsResource Artifacts { get; }

                    /// <summary>The "artifacts" collection of methods.</summary>
                    public class ArtifactsResource
                    {
                        private const string Resource = "artifacts";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public ArtifactsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Creates a specified artifact.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The parent, which owns this collection of artifacts. Format: `{parent}`
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.ApigeeRegistry.v1.Data.Artifact body, string parent)
                        {
                            return new CreateRequest(service, body, parent);
                        }

                        /// <summary>Creates a specified artifact.</summary>
                        public class CreateRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Artifact>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.Artifact body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent, which owns this collection of artifacts. Format: `{parent}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Required. The ID to use for the artifact, which will become the final component of the
                            /// artifact's resource name. This value should be 4-63 characters, and valid characters are
                            /// /a-z-/. Following AIP-162, IDs must not have the form of a UUID.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("artifactId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string ArtifactId { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.ApigeeRegistry.v1.Data.Artifact Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/artifacts";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/deployments/[^/]+$",
                                });
                                RequestParameters.Add("artifactId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "artifactId",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>Removes a specified artifact.</summary>
                        /// <param name="name">
                        /// Required. The name of the artifact to delete. Format: `{parent}/artifacts/*`
                        /// </param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(service, name);
                        }

                        /// <summary>Removes a specified artifact.</summary>
                        public class DeleteRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Empty>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the artifact to delete. Format: `{parent}/artifacts/*`
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/deployments/[^/]+/artifacts/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Returns a specified artifact.</summary>
                        /// <param name="name">
                        /// Required. The name of the artifact to retrieve. Format: `{parent}/artifacts/*`
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Returns a specified artifact.</summary>
                        public class GetRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Artifact>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the artifact to retrieve. Format: `{parent}/artifacts/*`
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/deployments/[^/]+/artifacts/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Returns the contents of a specified artifact. If artifacts are stored with GZip compression,
                        /// the default behavior is to return the artifact uncompressed (the mime_type response field
                        /// indicates the exact format returned).
                        /// </summary>
                        /// <param name="name">
                        /// Required. The name of the artifact whose contents should be retrieved. Format:
                        /// `{parent}/artifacts/*`
                        /// </param>
                        public virtual GetContentsRequest GetContents(string name)
                        {
                            return new GetContentsRequest(service, name);
                        }

                        /// <summary>
                        /// Returns the contents of a specified artifact. If artifacts are stored with GZip compression,
                        /// the default behavior is to return the artifact uncompressed (the mime_type response field
                        /// indicates the exact format returned).
                        /// </summary>
                        public class GetContentsRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.HttpBody>
                        {
                            /// <summary>Constructs a new GetContents request.</summary>
                            public GetContentsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the artifact whose contents should be retrieved. Format:
                            /// `{parent}/artifacts/*`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "getContents";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:getContents";

                            /// <summary>Initializes GetContents parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/deployments/[^/]+/artifacts/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Returns matching artifacts.</summary>
                        /// <param name="parent">
                        /// Required. The parent, which owns this collection of artifacts. Format: `{parent}`
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>Returns matching artifacts.</summary>
                        public class ListRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ListArtifactsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent, which owns this collection of artifacts. Format: `{parent}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// An expression that can be used to filter the list. Filters use the Common Expression
                            /// Language and can refer to all message fields except contents.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>
                            /// A comma-separated list of fields, e.g. "foo,bar" Fields can be sorted in descending
                            /// order using the "desc" identifier, e.g. "foo desc,bar"
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string OrderBy { get; set; }

                            /// <summary>
                            /// The maximum number of artifacts to return. The service may return fewer than this value.
                            /// If unspecified, at most 50 values will be returned. The maximum is 1000; values above
                            /// 1000 will be coerced to 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// A page token, received from a previous `ListArtifacts` call. Provide this to retrieve
                            /// the subsequent page. When paginating, all other parameters provided to `ListArtifacts`
                            /// must match the call that provided the page token.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/artifacts";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/deployments/[^/]+$",
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

                        /// <summary>Used to replace a specified artifact.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">Resource name.</param>
                        public virtual ReplaceArtifactRequest ReplaceArtifact(Google.Apis.ApigeeRegistry.v1.Data.Artifact body, string name)
                        {
                            return new ReplaceArtifactRequest(service, body, name);
                        }

                        /// <summary>Used to replace a specified artifact.</summary>
                        public class ReplaceArtifactRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Artifact>
                        {
                            /// <summary>Constructs a new ReplaceArtifact request.</summary>
                            public ReplaceArtifactRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.Artifact body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Resource name.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.ApigeeRegistry.v1.Data.Artifact Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "replaceArtifact";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "PUT";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}";

                            /// <summary>Initializes ReplaceArtifact parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/deployments/[^/]+/artifacts/[^/]+$",
                                });
                            }
                        }
                    }

                    /// <summary>Creates a specified deployment.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent, which owns this collection of deployments. Format:
                    /// `projects/*/locations/*/apis/*`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.ApigeeRegistry.v1.Data.ApiDeployment body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a specified deployment.</summary>
                    public class CreateRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ApiDeployment>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.ApiDeployment body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent, which owns this collection of deployments. Format:
                        /// `projects/*/locations/*/apis/*`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID to use for the deployment, which will become the final component of the
                        /// deployment's resource name. This value should be 4-63 characters, and valid characters are
                        /// /a-z-/. Following AIP-162, IDs must not have the form of a UUID.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("apiDeploymentId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ApiDeploymentId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ApigeeRegistry.v1.Data.ApiDeployment Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/deployments";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+$",
                            });
                            RequestParameters.Add("apiDeploymentId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "apiDeploymentId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Removes a specified deployment, all revisions, and all child resources (e.g., artifacts).
                    /// </summary>
                    /// <param name="name">
                    /// Required. The name of the deployment to delete. Format:
                    /// `projects/*/locations/*/apis/*/deployments/*`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>
                    /// Removes a specified deployment, all revisions, and all child resources (e.g., artifacts).
                    /// </summary>
                    public class DeleteRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the deployment to delete. Format:
                        /// `projects/*/locations/*/apis/*/deployments/*`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// If set to true, any child resources will also be deleted. (Otherwise, the request will only
                        /// work if there are no child resources.)
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> Force { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/deployments/[^/]+$",
                            });
                            RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                            {
                                Name = "force",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a revision of a deployment.</summary>
                    /// <param name="name">
                    /// Required. The name of the deployment revision to be deleted, with a revision ID explicitly
                    /// included. Example: `projects/sample/locations/global/apis/petstore/deployments/prod@c7cfa2a8`
                    /// </param>
                    public virtual DeleteRevisionRequest DeleteRevision(string name)
                    {
                        return new DeleteRevisionRequest(service, name);
                    }

                    /// <summary>Deletes a revision of a deployment.</summary>
                    public class DeleteRevisionRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ApiDeployment>
                    {
                        /// <summary>Constructs a new DeleteRevision request.</summary>
                        public DeleteRevisionRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the deployment revision to be deleted, with a revision ID explicitly
                        /// included. Example:
                        /// `projects/sample/locations/global/apis/petstore/deployments/prod@c7cfa2a8`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "deleteRevision";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:deleteRevision";

                        /// <summary>Initializes DeleteRevision parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/deployments/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns a specified deployment.</summary>
                    /// <param name="name">
                    /// Required. The name of the deployment to retrieve. Format:
                    /// `projects/*/locations/*/apis/*/deployments/*`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Returns a specified deployment.</summary>
                    public class GetRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ApiDeployment>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the deployment to retrieve. Format:
                        /// `projects/*/locations/*/apis/*/deployments/*`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/deployments/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
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
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    public class GetIamPolicyRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                        {
                            Resource = resource;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>
                        /// Optional. The maximum policy version that will be used to format the policy. Valid values
                        /// are 0, 1, and 3. Requests specifying an invalid value will be rejected. Requests for
                        /// policies with any conditional role bindings must specify version 3. Policies with no
                        /// conditional role bindings may specify any valid value or leave the field unset. The policy
                        /// in the response might use the policy version that you specified, or it might use a lower
                        /// policy version. For example, if you specify version 3, but the policy has no conditional
                        /// role bindings, the response uses version 1. To learn which resources support conditions in
                        /// their IAM policies, see the [IAM
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/deployments/[^/]+$",
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

                    /// <summary>Returns matching deployments.</summary>
                    /// <param name="parent">
                    /// Required. The parent, which owns this collection of deployments. Format:
                    /// `projects/*/locations/*/apis/*`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Returns matching deployments.</summary>
                    public class ListRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ListApiDeploymentsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent, which owns this collection of deployments. Format:
                        /// `projects/*/locations/*/apis/*`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// An expression that can be used to filter the list. Filters use the Common Expression
                        /// Language and can refer to all message fields.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// A comma-separated list of fields, e.g. "foo,bar" Fields can be sorted in descending order
                        /// using the "desc" identifier, e.g. "foo desc,bar"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// The maximum number of deployments to return. The service may return fewer than this value.
                        /// If unspecified, at most 50 values will be returned. The maximum is 1000; values above 1000
                        /// will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListApiDeployments` call. Provide this to retrieve
                        /// the subsequent page. When paginating, all other parameters provided to `ListApiDeployments`
                        /// must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/deployments";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+$",
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
                    /// Lists all revisions of a deployment. Revisions are returned in descending order of revision
                    /// creation time.
                    /// </summary>
                    /// <param name="name">Required. The name of the deployment to list revisions for.</param>
                    public virtual ListRevisionsRequest ListRevisions(string name)
                    {
                        return new ListRevisionsRequest(service, name);
                    }

                    /// <summary>
                    /// Lists all revisions of a deployment. Revisions are returned in descending order of revision
                    /// creation time.
                    /// </summary>
                    public class ListRevisionsRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ListApiDeploymentRevisionsResponse>
                    {
                        /// <summary>Constructs a new ListRevisions request.</summary>
                        public ListRevisionsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the deployment to list revisions for.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>The maximum number of revisions to return per page.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// The page token, received from a previous ListApiDeploymentRevisions call. Provide this to
                        /// retrieve the subsequent page.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "listRevisions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:listRevisions";

                        /// <summary>Initializes ListRevisions parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/deployments/[^/]+$",
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

                    /// <summary>Used to modify a specified deployment.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Resource name.</param>
                    public virtual PatchRequest Patch(Google.Apis.ApigeeRegistry.v1.Data.ApiDeployment body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Used to modify a specified deployment.</summary>
                    public class PatchRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ApiDeployment>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.ApiDeployment body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Resource name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// If set to true, and the deployment is not found, a new deployment will be created. In this
                        /// situation, `update_mask` is ignored.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> AllowMissing { get; set; }

                        /// <summary>
                        /// The list of fields to be updated. If omitted, all fields are updated that are set in the
                        /// request message (fields set to default values are ignored). If an asterisk "*" is specified,
                        /// all fields are updated, including fields that are unspecified/default in the request.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ApigeeRegistry.v1.Data.ApiDeployment Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/deployments/[^/]+$",
                            });
                            RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                            {
                                Name = "allowMissing",
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
                    /// Sets the current revision to a specified prior revision. Note that this creates a new revision
                    /// with a new revision ID.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. The deployment being rolled back.</param>
                    public virtual RollbackRequest Rollback(Google.Apis.ApigeeRegistry.v1.Data.RollbackApiDeploymentRequest body, string name)
                    {
                        return new RollbackRequest(service, body, name);
                    }

                    /// <summary>
                    /// Sets the current revision to a specified prior revision. Note that this creates a new revision
                    /// with a new revision ID.
                    /// </summary>
                    public class RollbackRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ApiDeployment>
                    {
                        /// <summary>Constructs a new Rollback request.</summary>
                        public RollbackRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.RollbackApiDeploymentRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The deployment being rolled back.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ApigeeRegistry.v1.Data.RollbackApiDeploymentRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "rollback";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:rollback";

                        /// <summary>Initializes Rollback parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/deployments/[^/]+$",
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
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    public class SetIamPolicyRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being specified. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/deployments/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Adds a tag to a specified revision of a deployment.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The name of the deployment to be tagged, including the revision ID.
                    /// </param>
                    public virtual TagRevisionRequest TagRevision(Google.Apis.ApigeeRegistry.v1.Data.TagApiDeploymentRevisionRequest body, string name)
                    {
                        return new TagRevisionRequest(service, body, name);
                    }

                    /// <summary>Adds a tag to a specified revision of a deployment.</summary>
                    public class TagRevisionRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ApiDeployment>
                    {
                        /// <summary>Constructs a new TagRevision request.</summary>
                        public TagRevisionRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.TagApiDeploymentRevisionRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the deployment to be tagged, including the revision ID.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ApigeeRegistry.v1.Data.TagApiDeploymentRevisionRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "tagRevision";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:tagRevision";

                        /// <summary>Initializes TagRevision parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/deployments/[^/]+$",
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
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/deployments/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the Versions resource.</summary>
                public virtual VersionsResource Versions { get; }

                /// <summary>The "versions" collection of methods.</summary>
                public class VersionsResource
                {
                    private const string Resource = "versions";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public VersionsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Artifacts = new ArtifactsResource(service);
                        Specs = new SpecsResource(service);
                    }

                    /// <summary>Gets the Artifacts resource.</summary>
                    public virtual ArtifactsResource Artifacts { get; }

                    /// <summary>The "artifacts" collection of methods.</summary>
                    public class ArtifactsResource
                    {
                        private const string Resource = "artifacts";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public ArtifactsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Creates a specified artifact.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The parent, which owns this collection of artifacts. Format: `{parent}`
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.ApigeeRegistry.v1.Data.Artifact body, string parent)
                        {
                            return new CreateRequest(service, body, parent);
                        }

                        /// <summary>Creates a specified artifact.</summary>
                        public class CreateRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Artifact>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.Artifact body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent, which owns this collection of artifacts. Format: `{parent}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Required. The ID to use for the artifact, which will become the final component of the
                            /// artifact's resource name. This value should be 4-63 characters, and valid characters are
                            /// /a-z-/. Following AIP-162, IDs must not have the form of a UUID.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("artifactId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string ArtifactId { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.ApigeeRegistry.v1.Data.Artifact Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/artifacts";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+$",
                                });
                                RequestParameters.Add("artifactId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "artifactId",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>Removes a specified artifact.</summary>
                        /// <param name="name">
                        /// Required. The name of the artifact to delete. Format: `{parent}/artifacts/*`
                        /// </param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(service, name);
                        }

                        /// <summary>Removes a specified artifact.</summary>
                        public class DeleteRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Empty>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the artifact to delete. Format: `{parent}/artifacts/*`
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/artifacts/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Returns a specified artifact.</summary>
                        /// <param name="name">
                        /// Required. The name of the artifact to retrieve. Format: `{parent}/artifacts/*`
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Returns a specified artifact.</summary>
                        public class GetRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Artifact>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the artifact to retrieve. Format: `{parent}/artifacts/*`
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/artifacts/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Returns the contents of a specified artifact. If artifacts are stored with GZip compression,
                        /// the default behavior is to return the artifact uncompressed (the mime_type response field
                        /// indicates the exact format returned).
                        /// </summary>
                        /// <param name="name">
                        /// Required. The name of the artifact whose contents should be retrieved. Format:
                        /// `{parent}/artifacts/*`
                        /// </param>
                        public virtual GetContentsRequest GetContents(string name)
                        {
                            return new GetContentsRequest(service, name);
                        }

                        /// <summary>
                        /// Returns the contents of a specified artifact. If artifacts are stored with GZip compression,
                        /// the default behavior is to return the artifact uncompressed (the mime_type response field
                        /// indicates the exact format returned).
                        /// </summary>
                        public class GetContentsRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.HttpBody>
                        {
                            /// <summary>Constructs a new GetContents request.</summary>
                            public GetContentsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the artifact whose contents should be retrieved. Format:
                            /// `{parent}/artifacts/*`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "getContents";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:getContents";

                            /// <summary>Initializes GetContents parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/artifacts/[^/]+$",
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
                            return new GetIamPolicyRequest(service, resource);
                        }

                        /// <summary>
                        /// Gets the access control policy for a resource. Returns an empty policy if the resource
                        /// exists and does not have a policy set.
                        /// </summary>
                        public class GetIamPolicyRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Policy>
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/artifacts/[^/]+$",
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

                        /// <summary>Returns matching artifacts.</summary>
                        /// <param name="parent">
                        /// Required. The parent, which owns this collection of artifacts. Format: `{parent}`
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>Returns matching artifacts.</summary>
                        public class ListRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ListArtifactsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent, which owns this collection of artifacts. Format: `{parent}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// An expression that can be used to filter the list. Filters use the Common Expression
                            /// Language and can refer to all message fields except contents.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>
                            /// A comma-separated list of fields, e.g. "foo,bar" Fields can be sorted in descending
                            /// order using the "desc" identifier, e.g. "foo desc,bar"
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string OrderBy { get; set; }

                            /// <summary>
                            /// The maximum number of artifacts to return. The service may return fewer than this value.
                            /// If unspecified, at most 50 values will be returned. The maximum is 1000; values above
                            /// 1000 will be coerced to 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// A page token, received from a previous `ListArtifacts` call. Provide this to retrieve
                            /// the subsequent page. When paginating, all other parameters provided to `ListArtifacts`
                            /// must match the call that provided the page token.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/artifacts";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+$",
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

                        /// <summary>Used to replace a specified artifact.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">Resource name.</param>
                        public virtual ReplaceArtifactRequest ReplaceArtifact(Google.Apis.ApigeeRegistry.v1.Data.Artifact body, string name)
                        {
                            return new ReplaceArtifactRequest(service, body, name);
                        }

                        /// <summary>Used to replace a specified artifact.</summary>
                        public class ReplaceArtifactRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Artifact>
                        {
                            /// <summary>Constructs a new ReplaceArtifact request.</summary>
                            public ReplaceArtifactRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.Artifact body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Resource name.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.ApigeeRegistry.v1.Data.Artifact Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "replaceArtifact";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "PUT";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}";

                            /// <summary>Initializes ReplaceArtifact parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/artifacts/[^/]+$",
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
                        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest body, string resource)
                        {
                            return new SetIamPolicyRequest(service, body, resource);
                        }

                        /// <summary>
                        /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                        /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                        /// </summary>
                        public class SetIamPolicyRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Policy>
                        {
                            /// <summary>Constructs a new SetIamPolicy request.</summary>
                            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                            Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/artifacts/[^/]+$",
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
                        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest body, string resource)
                        {
                            return new TestIamPermissionsRequest(service, body, resource);
                        }

                        /// <summary>
                        /// Returns permissions that a caller has on the specified resource. If the resource does not
                        /// exist, this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This
                        /// operation is designed to be used for building permission-aware UIs and command-line tools,
                        /// not for authorization checking. This operation may "fail open" without warning.
                        /// </summary>
                        public class TestIamPermissionsRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsResponse>
                        {
                            /// <summary>Constructs a new TestIamPermissions request.</summary>
                            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                            Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/artifacts/[^/]+$",
                                });
                            }
                        }
                    }

                    /// <summary>Gets the Specs resource.</summary>
                    public virtual SpecsResource Specs { get; }

                    /// <summary>The "specs" collection of methods.</summary>
                    public class SpecsResource
                    {
                        private const string Resource = "specs";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public SpecsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                            Artifacts = new ArtifactsResource(service);
                        }

                        /// <summary>Gets the Artifacts resource.</summary>
                        public virtual ArtifactsResource Artifacts { get; }

                        /// <summary>The "artifacts" collection of methods.</summary>
                        public class ArtifactsResource
                        {
                            private const string Resource = "artifacts";

                            /// <summary>The service which this resource belongs to.</summary>
                            private readonly Google.Apis.Services.IClientService service;

                            /// <summary>Constructs a new resource.</summary>
                            public ArtifactsResource(Google.Apis.Services.IClientService service)
                            {
                                this.service = service;
                            }

                            /// <summary>Creates a specified artifact.</summary>
                            /// <param name="body">The body of the request.</param>
                            /// <param name="parent">
                            /// Required. The parent, which owns this collection of artifacts. Format: `{parent}`
                            /// </param>
                            public virtual CreateRequest Create(Google.Apis.ApigeeRegistry.v1.Data.Artifact body, string parent)
                            {
                                return new CreateRequest(service, body, parent);
                            }

                            /// <summary>Creates a specified artifact.</summary>
                            public class CreateRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Artifact>
                            {
                                /// <summary>Constructs a new Create request.</summary>
                                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.Artifact body, string parent) : base(service)
                                {
                                    Parent = parent;
                                    Body = body;
                                    InitParameters();
                                }

                                /// <summary>
                                /// Required. The parent, which owns this collection of artifacts. Format: `{parent}`
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Parent { get; private set; }

                                /// <summary>
                                /// Required. The ID to use for the artifact, which will become the final component of
                                /// the artifact's resource name. This value should be 4-63 characters, and valid
                                /// characters are /a-z-/. Following AIP-162, IDs must not have the form of a UUID.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("artifactId", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual string ArtifactId { get; set; }

                                /// <summary>Gets or sets the body of this request.</summary>
                                Google.Apis.ApigeeRegistry.v1.Data.Artifact Body { get; set; }

                                /// <summary>Returns the body of the request.</summary>
                                protected override object GetBody() => Body;

                                /// <summary>Gets the method name.</summary>
                                public override string MethodName => "create";

                                /// <summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "POST";

                                /// <summary>Gets the REST path.</summary>
                                public override string RestPath => "v1/{+parent}/artifacts";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/specs/[^/]+$",
                                    });
                                    RequestParameters.Add("artifactId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "artifactId",
                                        IsRequired = false,
                                        ParameterType = "query",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                }
                            }

                            /// <summary>Removes a specified artifact.</summary>
                            /// <param name="name">
                            /// Required. The name of the artifact to delete. Format: `{parent}/artifacts/*`
                            /// </param>
                            public virtual DeleteRequest Delete(string name)
                            {
                                return new DeleteRequest(service, name);
                            }

                            /// <summary>Removes a specified artifact.</summary>
                            public class DeleteRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Empty>
                            {
                                /// <summary>Constructs a new Delete request.</summary>
                                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                                {
                                    Name = name;
                                    InitParameters();
                                }

                                /// <summary>
                                /// Required. The name of the artifact to delete. Format: `{parent}/artifacts/*`
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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/specs/[^/]+/artifacts/[^/]+$",
                                    });
                                }
                            }

                            /// <summary>Returns a specified artifact.</summary>
                            /// <param name="name">
                            /// Required. The name of the artifact to retrieve. Format: `{parent}/artifacts/*`
                            /// </param>
                            public virtual GetRequest Get(string name)
                            {
                                return new GetRequest(service, name);
                            }

                            /// <summary>Returns a specified artifact.</summary>
                            public class GetRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Artifact>
                            {
                                /// <summary>Constructs a new Get request.</summary>
                                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                                {
                                    Name = name;
                                    InitParameters();
                                }

                                /// <summary>
                                /// Required. The name of the artifact to retrieve. Format: `{parent}/artifacts/*`
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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/specs/[^/]+/artifacts/[^/]+$",
                                    });
                                }
                            }

                            /// <summary>
                            /// Returns the contents of a specified artifact. If artifacts are stored with GZip
                            /// compression, the default behavior is to return the artifact uncompressed (the mime_type
                            /// response field indicates the exact format returned).
                            /// </summary>
                            /// <param name="name">
                            /// Required. The name of the artifact whose contents should be retrieved. Format:
                            /// `{parent}/artifacts/*`
                            /// </param>
                            public virtual GetContentsRequest GetContents(string name)
                            {
                                return new GetContentsRequest(service, name);
                            }

                            /// <summary>
                            /// Returns the contents of a specified artifact. If artifacts are stored with GZip
                            /// compression, the default behavior is to return the artifact uncompressed (the mime_type
                            /// response field indicates the exact format returned).
                            /// </summary>
                            public class GetContentsRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.HttpBody>
                            {
                                /// <summary>Constructs a new GetContents request.</summary>
                                public GetContentsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                                {
                                    Name = name;
                                    InitParameters();
                                }

                                /// <summary>
                                /// Required. The name of the artifact whose contents should be retrieved. Format:
                                /// `{parent}/artifacts/*`
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Name { get; private set; }

                                /// <summary>Gets the method name.</summary>
                                public override string MethodName => "getContents";

                                /// <summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "GET";

                                /// <summary>Gets the REST path.</summary>
                                public override string RestPath => "v1/{+name}:getContents";

                                /// <summary>Initializes GetContents parameter list.</summary>
                                protected override void InitParameters()
                                {
                                    base.InitParameters();
                                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "name",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/specs/[^/]+/artifacts/[^/]+$",
                                    });
                                }
                            }

                            /// <summary>
                            /// Gets the access control policy for a resource. Returns an empty policy if the resource
                            /// exists and does not have a policy set.
                            /// </summary>
                            /// <param name="resource">
                            /// REQUIRED: The resource for which the policy is being requested. See [Resource
                            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value
                            /// for this field.
                            /// </param>
                            public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                            {
                                return new GetIamPolicyRequest(service, resource);
                            }

                            /// <summary>
                            /// Gets the access control policy for a resource. Returns an empty policy if the resource
                            /// exists and does not have a policy set.
                            /// </summary>
                            public class GetIamPolicyRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Policy>
                            {
                                /// <summary>Constructs a new GetIamPolicy request.</summary>
                                public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                                {
                                    Resource = resource;
                                    InitParameters();
                                }

                                /// <summary>
                                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate
                                /// value for this field.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Resource { get; private set; }

                                /// <summary>
                                /// Optional. The maximum policy version that will be used to format the policy. Valid
                                /// values are 0, 1, and 3. Requests specifying an invalid value will be rejected.
                                /// Requests for policies with any conditional role bindings must specify version 3.
                                /// Policies with no conditional role bindings may specify any valid value or leave the
                                /// field unset. The policy in the response might use the policy version that you
                                /// specified, or it might use a lower policy version. For example, if you specify
                                /// version 3, but the policy has no conditional role bindings, the response uses
                                /// version 1. To learn which resources support conditions in their IAM policies, see
                                /// the [IAM
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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/specs/[^/]+/artifacts/[^/]+$",
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

                            /// <summary>Returns matching artifacts.</summary>
                            /// <param name="parent">
                            /// Required. The parent, which owns this collection of artifacts. Format: `{parent}`
                            /// </param>
                            public virtual ListRequest List(string parent)
                            {
                                return new ListRequest(service, parent);
                            }

                            /// <summary>Returns matching artifacts.</summary>
                            public class ListRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ListArtifactsResponse>
                            {
                                /// <summary>Constructs a new List request.</summary>
                                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                                {
                                    Parent = parent;
                                    InitParameters();
                                }

                                /// <summary>
                                /// Required. The parent, which owns this collection of artifacts. Format: `{parent}`
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Parent { get; private set; }

                                /// <summary>
                                /// An expression that can be used to filter the list. Filters use the Common Expression
                                /// Language and can refer to all message fields except contents.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual string Filter { get; set; }

                                /// <summary>
                                /// A comma-separated list of fields, e.g. "foo,bar" Fields can be sorted in descending
                                /// order using the "desc" identifier, e.g. "foo desc,bar"
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual string OrderBy { get; set; }

                                /// <summary>
                                /// The maximum number of artifacts to return. The service may return fewer than this
                                /// value. If unspecified, at most 50 values will be returned. The maximum is 1000;
                                /// values above 1000 will be coerced to 1000.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual System.Nullable<int> PageSize { get; set; }

                                /// <summary>
                                /// A page token, received from a previous `ListArtifacts` call. Provide this to
                                /// retrieve the subsequent page. When paginating, all other parameters provided to
                                /// `ListArtifacts` must match the call that provided the page token.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual string PageToken { get; set; }

                                /// <summary>Gets the method name.</summary>
                                public override string MethodName => "list";

                                /// <summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "GET";

                                /// <summary>Gets the REST path.</summary>
                                public override string RestPath => "v1/{+parent}/artifacts";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/specs/[^/]+$",
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

                            /// <summary>Used to replace a specified artifact.</summary>
                            /// <param name="body">The body of the request.</param>
                            /// <param name="name">Resource name.</param>
                            public virtual ReplaceArtifactRequest ReplaceArtifact(Google.Apis.ApigeeRegistry.v1.Data.Artifact body, string name)
                            {
                                return new ReplaceArtifactRequest(service, body, name);
                            }

                            /// <summary>Used to replace a specified artifact.</summary>
                            public class ReplaceArtifactRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Artifact>
                            {
                                /// <summary>Constructs a new ReplaceArtifact request.</summary>
                                public ReplaceArtifactRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.Artifact body, string name) : base(service)
                                {
                                    Name = name;
                                    Body = body;
                                    InitParameters();
                                }

                                /// <summary>Resource name.</summary>
                                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Name { get; private set; }

                                /// <summary>Gets or sets the body of this request.</summary>
                                Google.Apis.ApigeeRegistry.v1.Data.Artifact Body { get; set; }

                                /// <summary>Returns the body of the request.</summary>
                                protected override object GetBody() => Body;

                                /// <summary>Gets the method name.</summary>
                                public override string MethodName => "replaceArtifact";

                                /// <summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "PUT";

                                /// <summary>Gets the REST path.</summary>
                                public override string RestPath => "v1/{+name}";

                                /// <summary>Initializes ReplaceArtifact parameter list.</summary>
                                protected override void InitParameters()
                                {
                                    base.InitParameters();
                                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "name",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/specs/[^/]+/artifacts/[^/]+$",
                                    });
                                }
                            }

                            /// <summary>
                            /// Sets the access control policy on the specified resource. Replaces any existing policy.
                            /// Can return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                            /// </summary>
                            /// <param name="body">The body of the request.</param>
                            /// <param name="resource">
                            /// REQUIRED: The resource for which the policy is being specified. See [Resource
                            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value
                            /// for this field.
                            /// </param>
                            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest body, string resource)
                            {
                                return new SetIamPolicyRequest(service, body, resource);
                            }

                            /// <summary>
                            /// Sets the access control policy on the specified resource. Replaces any existing policy.
                            /// Can return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                            /// </summary>
                            public class SetIamPolicyRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Policy>
                            {
                                /// <summary>Constructs a new SetIamPolicy request.</summary>
                                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                                {
                                    Resource = resource;
                                    Body = body;
                                    InitParameters();
                                }

                                /// <summary>
                                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate
                                /// value for this field.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Resource { get; private set; }

                                /// <summary>Gets or sets the body of this request.</summary>
                                Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/specs/[^/]+/artifacts/[^/]+$",
                                    });
                                }
                            }

                            /// <summary>
                            /// Returns permissions that a caller has on the specified resource. If the resource does
                            /// not exist, this will return an empty set of permissions, not a `NOT_FOUND` error. Note:
                            /// This operation is designed to be used for building permission-aware UIs and command-line
                            /// tools, not for authorization checking. This operation may "fail open" without warning.
                            /// </summary>
                            /// <param name="body">The body of the request.</param>
                            /// <param name="resource">
                            /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value
                            /// for this field.
                            /// </param>
                            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest body, string resource)
                            {
                                return new TestIamPermissionsRequest(service, body, resource);
                            }

                            /// <summary>
                            /// Returns permissions that a caller has on the specified resource. If the resource does
                            /// not exist, this will return an empty set of permissions, not a `NOT_FOUND` error. Note:
                            /// This operation is designed to be used for building permission-aware UIs and command-line
                            /// tools, not for authorization checking. This operation may "fail open" without warning.
                            /// </summary>
                            public class TestIamPermissionsRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsResponse>
                            {
                                /// <summary>Constructs a new TestIamPermissions request.</summary>
                                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                                {
                                    Resource = resource;
                                    Body = body;
                                    InitParameters();
                                }

                                /// <summary>
                                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate
                                /// value for this field.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Resource { get; private set; }

                                /// <summary>Gets or sets the body of this request.</summary>
                                Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/specs/[^/]+/artifacts/[^/]+$",
                                    });
                                }
                            }
                        }

                        /// <summary>Creates a specified spec.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The parent, which owns this collection of specs. Format:
                        /// `projects/*/locations/*/apis/*/versions/*`
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.ApigeeRegistry.v1.Data.ApiSpec body, string parent)
                        {
                            return new CreateRequest(service, body, parent);
                        }

                        /// <summary>Creates a specified spec.</summary>
                        public class CreateRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ApiSpec>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.ApiSpec body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent, which owns this collection of specs. Format:
                            /// `projects/*/locations/*/apis/*/versions/*`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Required. The ID to use for the spec, which will become the final component of the
                            /// spec's resource name. This value should be 4-63 characters, and valid characters are
                            /// /a-z-/. Following AIP-162, IDs must not have the form of a UUID.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("apiSpecId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string ApiSpecId { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.ApigeeRegistry.v1.Data.ApiSpec Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/specs";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+$",
                                });
                                RequestParameters.Add("apiSpecId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "apiSpecId",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>
                        /// Removes a specified spec, all revisions, and all child resources (e.g., artifacts).
                        /// </summary>
                        /// <param name="name">
                        /// Required. The name of the spec to delete. Format:
                        /// `projects/*/locations/*/apis/*/versions/*/specs/*`
                        /// </param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(service, name);
                        }

                        /// <summary>
                        /// Removes a specified spec, all revisions, and all child resources (e.g., artifacts).
                        /// </summary>
                        public class DeleteRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Empty>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the spec to delete. Format:
                            /// `projects/*/locations/*/apis/*/versions/*/specs/*`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// If set to true, any child resources will also be deleted. (Otherwise, the request will
                            /// only work if there are no child resources.)
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<bool> Force { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/specs/[^/]+$",
                                });
                                RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "force",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>Deletes a revision of a spec.</summary>
                        /// <param name="name">
                        /// Required. The name of the spec revision to be deleted, with a revision ID explicitly
                        /// included. Example:
                        /// `projects/sample/locations/global/apis/petstore/versions/1.0.0/specs/openapi.yaml@c7cfa2a8`
                        /// </param>
                        public virtual DeleteRevisionRequest DeleteRevision(string name)
                        {
                            return new DeleteRevisionRequest(service, name);
                        }

                        /// <summary>Deletes a revision of a spec.</summary>
                        public class DeleteRevisionRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ApiSpec>
                        {
                            /// <summary>Constructs a new DeleteRevision request.</summary>
                            public DeleteRevisionRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the spec revision to be deleted, with a revision ID explicitly
                            /// included. Example:
                            /// `projects/sample/locations/global/apis/petstore/versions/1.0.0/specs/openapi.yaml@c7cfa2a8`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "deleteRevision";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "DELETE";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:deleteRevision";

                            /// <summary>Initializes DeleteRevision parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/specs/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Returns a specified spec.</summary>
                        /// <param name="name">
                        /// Required. The name of the spec to retrieve. Format:
                        /// `projects/*/locations/*/apis/*/versions/*/specs/*`
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Returns a specified spec.</summary>
                        public class GetRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ApiSpec>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the spec to retrieve. Format:
                            /// `projects/*/locations/*/apis/*/versions/*/specs/*`
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/specs/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Returns the contents of a specified spec. If specs are stored with GZip compression, the
                        /// default behavior is to return the spec uncompressed (the mime_type response field indicates
                        /// the exact format returned).
                        /// </summary>
                        /// <param name="name">
                        /// Required. The name of the spec whose contents should be retrieved. Format:
                        /// `projects/*/locations/*/apis/*/versions/*/specs/*`
                        /// </param>
                        public virtual GetContentsRequest GetContents(string name)
                        {
                            return new GetContentsRequest(service, name);
                        }

                        /// <summary>
                        /// Returns the contents of a specified spec. If specs are stored with GZip compression, the
                        /// default behavior is to return the spec uncompressed (the mime_type response field indicates
                        /// the exact format returned).
                        /// </summary>
                        public class GetContentsRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.HttpBody>
                        {
                            /// <summary>Constructs a new GetContents request.</summary>
                            public GetContentsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the spec whose contents should be retrieved. Format:
                            /// `projects/*/locations/*/apis/*/versions/*/specs/*`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "getContents";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:getContents";

                            /// <summary>Initializes GetContents parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/specs/[^/]+$",
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
                            return new GetIamPolicyRequest(service, resource);
                        }

                        /// <summary>
                        /// Gets the access control policy for a resource. Returns an empty policy if the resource
                        /// exists and does not have a policy set.
                        /// </summary>
                        public class GetIamPolicyRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Policy>
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/specs/[^/]+$",
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

                        /// <summary>Returns matching specs.</summary>
                        /// <param name="parent">
                        /// Required. The parent, which owns this collection of specs. Format:
                        /// `projects/*/locations/*/apis/*/versions/*`
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>Returns matching specs.</summary>
                        public class ListRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ListApiSpecsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent, which owns this collection of specs. Format:
                            /// `projects/*/locations/*/apis/*/versions/*`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// An expression that can be used to filter the list. Filters use the Common Expression
                            /// Language and can refer to all message fields except contents.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>
                            /// A comma-separated list of fields, e.g. "foo,bar" Fields can be sorted in descending
                            /// order using the "desc" identifier, e.g. "foo desc,bar"
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string OrderBy { get; set; }

                            /// <summary>
                            /// The maximum number of specs to return. The service may return fewer than this value. If
                            /// unspecified, at most 50 values will be returned. The maximum is 1000; values above 1000
                            /// will be coerced to 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// A page token, received from a previous `ListApiSpecs` call. Provide this to retrieve the
                            /// subsequent page. When paginating, all other parameters provided to `ListApiSpecs` must
                            /// match the call that provided the page token.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/specs";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+$",
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
                        /// Lists all revisions of a spec. Revisions are returned in descending order of revision
                        /// creation time.
                        /// </summary>
                        /// <param name="name">Required. The name of the spec to list revisions for.</param>
                        public virtual ListRevisionsRequest ListRevisions(string name)
                        {
                            return new ListRevisionsRequest(service, name);
                        }

                        /// <summary>
                        /// Lists all revisions of a spec. Revisions are returned in descending order of revision
                        /// creation time.
                        /// </summary>
                        public class ListRevisionsRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ListApiSpecRevisionsResponse>
                        {
                            /// <summary>Constructs a new ListRevisions request.</summary>
                            public ListRevisionsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>Required. The name of the spec to list revisions for.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>The maximum number of revisions to return per page.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// The page token, received from a previous ListApiSpecRevisions call. Provide this to
                            /// retrieve the subsequent page.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "listRevisions";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:listRevisions";

                            /// <summary>Initializes ListRevisions parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/specs/[^/]+$",
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

                        /// <summary>Used to modify a specified spec.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">Resource name.</param>
                        public virtual PatchRequest Patch(Google.Apis.ApigeeRegistry.v1.Data.ApiSpec body, string name)
                        {
                            return new PatchRequest(service, body, name);
                        }

                        /// <summary>Used to modify a specified spec.</summary>
                        public class PatchRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ApiSpec>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.ApiSpec body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Resource name.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// If set to true, and the spec is not found, a new spec will be created. In this
                            /// situation, `update_mask` is ignored.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<bool> AllowMissing { get; set; }

                            /// <summary>
                            /// The list of fields to be updated. If omitted, all fields are updated that are set in the
                            /// request message (fields set to default values are ignored). If an asterisk "*" is
                            /// specified, all fields are updated, including fields that are unspecified/default in the
                            /// request.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.ApigeeRegistry.v1.Data.ApiSpec Body { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/specs/[^/]+$",
                                });
                                RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "allowMissing",
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
                        /// Sets the current revision to a specified prior revision. Note that this creates a new
                        /// revision with a new revision ID.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">Required. The spec being rolled back.</param>
                        public virtual RollbackRequest Rollback(Google.Apis.ApigeeRegistry.v1.Data.RollbackApiSpecRequest body, string name)
                        {
                            return new RollbackRequest(service, body, name);
                        }

                        /// <summary>
                        /// Sets the current revision to a specified prior revision. Note that this creates a new
                        /// revision with a new revision ID.
                        /// </summary>
                        public class RollbackRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ApiSpec>
                        {
                            /// <summary>Constructs a new Rollback request.</summary>
                            public RollbackRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.RollbackApiSpecRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Required. The spec being rolled back.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.ApigeeRegistry.v1.Data.RollbackApiSpecRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "rollback";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:rollback";

                            /// <summary>Initializes Rollback parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/specs/[^/]+$",
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
                        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest body, string resource)
                        {
                            return new SetIamPolicyRequest(service, body, resource);
                        }

                        /// <summary>
                        /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                        /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                        /// </summary>
                        public class SetIamPolicyRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Policy>
                        {
                            /// <summary>Constructs a new SetIamPolicy request.</summary>
                            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                            Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/specs/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Adds a tag to a specified revision of a spec.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Required. The name of the spec to be tagged, including the revision ID.
                        /// </param>
                        public virtual TagRevisionRequest TagRevision(Google.Apis.ApigeeRegistry.v1.Data.TagApiSpecRevisionRequest body, string name)
                        {
                            return new TagRevisionRequest(service, body, name);
                        }

                        /// <summary>Adds a tag to a specified revision of a spec.</summary>
                        public class TagRevisionRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ApiSpec>
                        {
                            /// <summary>Constructs a new TagRevision request.</summary>
                            public TagRevisionRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.TagApiSpecRevisionRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the spec to be tagged, including the revision ID.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.ApigeeRegistry.v1.Data.TagApiSpecRevisionRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "tagRevision";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:tagRevision";

                            /// <summary>Initializes TagRevision parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/specs/[^/]+$",
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
                        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest body, string resource)
                        {
                            return new TestIamPermissionsRequest(service, body, resource);
                        }

                        /// <summary>
                        /// Returns permissions that a caller has on the specified resource. If the resource does not
                        /// exist, this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This
                        /// operation is designed to be used for building permission-aware UIs and command-line tools,
                        /// not for authorization checking. This operation may "fail open" without warning.
                        /// </summary>
                        public class TestIamPermissionsRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsResponse>
                        {
                            /// <summary>Constructs a new TestIamPermissions request.</summary>
                            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                            Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/specs/[^/]+$",
                                });
                            }
                        }
                    }

                    /// <summary>Creates a specified version.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent, which owns this collection of versions. Format:
                    /// `projects/*/locations/*/apis/*`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.ApigeeRegistry.v1.Data.ApiVersion body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a specified version.</summary>
                    public class CreateRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ApiVersion>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.ApiVersion body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent, which owns this collection of versions. Format:
                        /// `projects/*/locations/*/apis/*`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID to use for the version, which will become the final component of the
                        /// version's resource name. This value should be 1-63 characters, and valid characters are
                        /// /a-z-/. Following AIP-162, IDs must not have the form of a UUID.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("apiVersionId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ApiVersionId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ApigeeRegistry.v1.Data.ApiVersion Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/versions";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+$",
                            });
                            RequestParameters.Add("apiVersionId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "apiVersionId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Removes a specified version and all of the resources that it owns.</summary>
                    /// <param name="name">
                    /// Required. The name of the version to delete. Format: `projects/*/locations/*/apis/*/versions/*`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Removes a specified version and all of the resources that it owns.</summary>
                    public class DeleteRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the version to delete. Format:
                        /// `projects/*/locations/*/apis/*/versions/*`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// If set to true, any child resources will also be deleted. (Otherwise, the request will only
                        /// work if there are no child resources.)
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> Force { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+$",
                            });
                            RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                            {
                                Name = "force",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Returns a specified version.</summary>
                    /// <param name="name">
                    /// Required. The name of the version to retrieve. Format:
                    /// `projects/*/locations/*/apis/*/versions/*`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Returns a specified version.</summary>
                    public class GetRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ApiVersion>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the version to retrieve. Format:
                        /// `projects/*/locations/*/apis/*/versions/*`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
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
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    public class GetIamPolicyRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                        {
                            Resource = resource;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>
                        /// Optional. The maximum policy version that will be used to format the policy. Valid values
                        /// are 0, 1, and 3. Requests specifying an invalid value will be rejected. Requests for
                        /// policies with any conditional role bindings must specify version 3. Policies with no
                        /// conditional role bindings may specify any valid value or leave the field unset. The policy
                        /// in the response might use the policy version that you specified, or it might use a lower
                        /// policy version. For example, if you specify version 3, but the policy has no conditional
                        /// role bindings, the response uses version 1. To learn which resources support conditions in
                        /// their IAM policies, see the [IAM
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+$",
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

                    /// <summary>Returns matching versions.</summary>
                    /// <param name="parent">
                    /// Required. The parent, which owns this collection of versions. Format:
                    /// `projects/*/locations/*/apis/*`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Returns matching versions.</summary>
                    public class ListRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ListApiVersionsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent, which owns this collection of versions. Format:
                        /// `projects/*/locations/*/apis/*`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// An expression that can be used to filter the list. Filters use the Common Expression
                        /// Language and can refer to all message fields.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// A comma-separated list of fields, e.g. "foo,bar" Fields can be sorted in descending order
                        /// using the "desc" identifier, e.g. "foo desc,bar"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// The maximum number of versions to return. The service may return fewer than this value. If
                        /// unspecified, at most 50 values will be returned. The maximum is 1000; values above 1000 will
                        /// be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListApiVersions` call. Provide this to retrieve the
                        /// subsequent page. When paginating, all other parameters provided to `ListApiVersions` must
                        /// match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/versions";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+$",
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

                    /// <summary>Used to modify a specified version.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Resource name.</param>
                    public virtual PatchRequest Patch(Google.Apis.ApigeeRegistry.v1.Data.ApiVersion body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Used to modify a specified version.</summary>
                    public class PatchRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ApiVersion>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.ApiVersion body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Resource name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// If set to true, and the version is not found, a new version will be created. In this
                        /// situation, `update_mask` is ignored.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> AllowMissing { get; set; }

                        /// <summary>
                        /// The list of fields to be updated. If omitted, all fields are updated that are set in the
                        /// request message (fields set to default values are ignored). If an asterisk "*" is specified,
                        /// all fields are updated, including fields that are unspecified/default in the request.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ApigeeRegistry.v1.Data.ApiVersion Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+$",
                            });
                            RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                            {
                                Name = "allowMissing",
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
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    public class SetIamPolicyRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being specified. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+$",
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
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Creates a specified API.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent, which owns this collection of APIs. Format: `projects/*/locations/*`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.ApigeeRegistry.v1.Data.Api body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a specified API.</summary>
                public class CreateRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Api>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.Api body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent, which owns this collection of APIs. Format: `projects/*/locations/*`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID to use for the API, which will become the final component of the API's resource
                    /// name. This value should be 4-63 characters, and valid characters are /a-z-/. Following AIP-162,
                    /// IDs must not have the form of a UUID.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("apiId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ApiId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ApigeeRegistry.v1.Data.Api Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/apis";

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
                        RequestParameters.Add("apiId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "apiId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Removes a specified API and all of the resources that it owns.</summary>
                /// <param name="name">
                /// Required. The name of the API to delete. Format: `projects/*/locations/*/apis/*`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Removes a specified API and all of the resources that it owns.</summary>
                public class DeleteRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the API to delete. Format: `projects/*/locations/*/apis/*`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// If set to true, any child resources will also be deleted. (Otherwise, the request will only work
                    /// if there are no child resources.)
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+$",
                        });
                        RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                        {
                            Name = "force",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Returns a specified API.</summary>
                /// <param name="name">
                /// Required. The name of the API to retrieve. Format: `projects/*/locations/*/apis/*`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Returns a specified API.</summary>
                public class GetRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Api>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the API to retrieve. Format: `projects/*/locations/*/apis/*`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+$",
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
                public class GetIamPolicyRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Policy>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+$",
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

                /// <summary>Returns matching APIs.</summary>
                /// <param name="parent">
                /// Required. The parent, which owns this collection of APIs. Format: `projects/*/locations/*`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Returns matching APIs.</summary>
                public class ListRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ListApisResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent, which owns this collection of APIs. Format: `projects/*/locations/*`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// An expression that can be used to filter the list. Filters use the Common Expression Language
                    /// and can refer to all message fields.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// A comma-separated list of fields, e.g. "foo,bar" Fields can be sorted in descending order using
                    /// the "desc" identifier, e.g. "foo desc,bar"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// The maximum number of APIs to return. The service may return fewer than this value. If
                    /// unspecified, at most 50 values will be returned. The maximum is 1000; values above 1000 will be
                    /// coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListApis` call. Provide this to retrieve the subsequent
                    /// page. When paginating, all other parameters provided to `ListApis` must match the call that
                    /// provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/apis";

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

                /// <summary>Used to modify a specified API.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Resource name.</param>
                public virtual PatchRequest Patch(Google.Apis.ApigeeRegistry.v1.Data.Api body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Used to modify a specified API.</summary>
                public class PatchRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Api>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.Api body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Resource name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// If set to true, and the API is not found, a new API will be created. In this situation,
                    /// `update_mask` is ignored.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// The list of fields to be updated. If omitted, all fields are updated that are set in the request
                    /// message (fields set to default values are ignored). If an asterisk "*" is specified, all fields
                    /// are updated, including fields that are unspecified/default in the request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ApigeeRegistry.v1.Data.Api Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+$",
                        });
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
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
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Artifacts resource.</summary>
            public virtual ArtifactsResource Artifacts { get; }

            /// <summary>The "artifacts" collection of methods.</summary>
            public class ArtifactsResource
            {
                private const string Resource = "artifacts";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ArtifactsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a specified artifact.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent, which owns this collection of artifacts. Format: `{parent}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.ApigeeRegistry.v1.Data.Artifact body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a specified artifact.</summary>
                public class CreateRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Artifact>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.Artifact body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent, which owns this collection of artifacts. Format: `{parent}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID to use for the artifact, which will become the final component of the
                    /// artifact's resource name. This value should be 4-63 characters, and valid characters are /a-z-/.
                    /// Following AIP-162, IDs must not have the form of a UUID.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("artifactId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ArtifactId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ApigeeRegistry.v1.Data.Artifact Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/artifacts";

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
                        RequestParameters.Add("artifactId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "artifactId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Removes a specified artifact.</summary>
                /// <param name="name">
                /// Required. The name of the artifact to delete. Format: `{parent}/artifacts/*`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Removes a specified artifact.</summary>
                public class DeleteRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the artifact to delete. Format: `{parent}/artifacts/*`</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/artifacts/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns a specified artifact.</summary>
                /// <param name="name">
                /// Required. The name of the artifact to retrieve. Format: `{parent}/artifacts/*`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Returns a specified artifact.</summary>
                public class GetRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Artifact>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the artifact to retrieve. Format: `{parent}/artifacts/*`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/artifacts/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns the contents of a specified artifact. If artifacts are stored with GZip compression, the
                /// default behavior is to return the artifact uncompressed (the mime_type response field indicates the
                /// exact format returned).
                /// </summary>
                /// <param name="name">
                /// Required. The name of the artifact whose contents should be retrieved. Format:
                /// `{parent}/artifacts/*`
                /// </param>
                public virtual GetContentsRequest GetContents(string name)
                {
                    return new GetContentsRequest(service, name);
                }

                /// <summary>
                /// Returns the contents of a specified artifact. If artifacts are stored with GZip compression, the
                /// default behavior is to return the artifact uncompressed (the mime_type response field indicates the
                /// exact format returned).
                /// </summary>
                public class GetContentsRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.HttpBody>
                {
                    /// <summary>Constructs a new GetContents request.</summary>
                    public GetContentsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the artifact whose contents should be retrieved. Format:
                    /// `{parent}/artifacts/*`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getContents";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:getContents";

                    /// <summary>Initializes GetContents parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/artifacts/[^/]+$",
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
                public class GetIamPolicyRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Policy>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/artifacts/[^/]+$",
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

                /// <summary>Returns matching artifacts.</summary>
                /// <param name="parent">
                /// Required. The parent, which owns this collection of artifacts. Format: `{parent}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Returns matching artifacts.</summary>
                public class ListRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ListArtifactsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent, which owns this collection of artifacts. Format: `{parent}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// An expression that can be used to filter the list. Filters use the Common Expression Language
                    /// and can refer to all message fields except contents.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// A comma-separated list of fields, e.g. "foo,bar" Fields can be sorted in descending order using
                    /// the "desc" identifier, e.g. "foo desc,bar"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// The maximum number of artifacts to return. The service may return fewer than this value. If
                    /// unspecified, at most 50 values will be returned. The maximum is 1000; values above 1000 will be
                    /// coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListArtifacts` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `ListArtifacts` must match
                    /// the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/artifacts";

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

                /// <summary>Used to replace a specified artifact.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Resource name.</param>
                public virtual ReplaceArtifactRequest ReplaceArtifact(Google.Apis.ApigeeRegistry.v1.Data.Artifact body, string name)
                {
                    return new ReplaceArtifactRequest(service, body, name);
                }

                /// <summary>Used to replace a specified artifact.</summary>
                public class ReplaceArtifactRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Artifact>
                {
                    /// <summary>Constructs a new ReplaceArtifact request.</summary>
                    public ReplaceArtifactRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.Artifact body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Resource name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ApigeeRegistry.v1.Data.Artifact Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "replaceArtifact";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes ReplaceArtifact parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/artifacts/[^/]+$",
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
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/artifacts/[^/]+$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/artifacts/[^/]+$",
                        });
                    }
                }
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

                /// <summary>Provisions instance resources for the Registry.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Parent resource of the Instance, of the form: `projects/*/locations/*`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.ApigeeRegistry.v1.Data.Instance body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Provisions instance resources for the Registry.</summary>
                public class CreateRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.Instance body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource of the Instance, of the form: `projects/*/locations/*`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. Identifier to assign to the Instance. Must be unique within scope of the parent
                    /// resource.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("instanceId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string InstanceId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ApigeeRegistry.v1.Data.Instance Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/instances";

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
                        RequestParameters.Add("instanceId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "instanceId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes the Registry instance.</summary>
                /// <param name="name">
                /// Required. The name of the Instance to delete. Format: `projects/*/locations/*/instances/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes the Registry instance.</summary>
                public class DeleteRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Instance to delete. Format: `projects/*/locations/*/instances/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single Instance.</summary>
                /// <param name="name">
                /// Required. The name of the Instance to retrieve. Format: `projects/*/locations/*/instances/*`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets details of a single Instance.</summary>
                public class GetRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Instance>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Instance to retrieve. Format: `projects/*/locations/*/instances/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
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
                public class GetIamPolicyRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Policy>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
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
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
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
                public virtual CancelRequest Cancel(Google.Apis.ApigeeRegistry.v1.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ApigeeRegistry.v1.Data.CancelOperationRequest Body { get; set; }

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
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a long-running operation. This method indicates that the client is no longer interested in
                /// the operation result. It does not cancel the operation. If the server doesn't support this method,
                /// it returns `google.rpc.Code.UNIMPLEMENTED`.
                /// </summary>
                public class DeleteRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Empty>
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
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                public class GetRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Operation>
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
                public class ListRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ListOperationsResponse>
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

            /// <summary>Gets the Runtime resource.</summary>
            public virtual RuntimeResource Runtime { get; }

            /// <summary>The "runtime" collection of methods.</summary>
            public class RuntimeResource
            {
                private const string Resource = "runtime";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RuntimeResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
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
                public class GetIamPolicyRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Policy>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/runtime$",
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
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.ApigeeRegistry.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/runtime$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.ApigeeRegistry.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/runtime$",
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
            public class GetRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.Location>
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
                return new ListRequest(service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : ApigeeRegistryBaseServiceRequest<Google.Apis.ApigeeRegistry.v1.Data.ListLocationsResponse>
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
namespace Google.Apis.ApigeeRegistry.v1.Data
{
    /// <summary>
    /// A top-level description of an API. Produced by producers and are commitments to provide services.
    /// </summary>
    public class Api : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Annotations attach non-identifying metadata to resources. Annotation keys and values are less restricted
        /// than those of labels, but should be generally used for small values of broad interest. Larger, topic-
        /// specific metadata should be stored in Artifacts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// A user-definable description of the availability of this service. Format: free-form, but we expect single
        /// words that describe availability, e.g., "NONE", "TESTING", "PREVIEW", "GENERAL", "DEPRECATED", "SHUTDOWN".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availability")]
        public virtual string Availability { get; set; }

        /// <summary>Output only. Creation timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>A detailed description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Human-meaningful name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Labels attach identifying metadata to resources. Identifying metadata can be used to filter list operations.
        /// Label keys and values can be no longer than 64 characters (Unicode codepoints), can only contain lowercase
        /// letters, numeric characters, underscores, and dashes. International characters are allowed. No more than 64
        /// user labels can be associated with one resource (System labels are excluded). See https://goo.gl/xmQnxf for
        /// more information and examples of labels. System reserved label keys are prefixed with
        /// `apigeeregistry.googleapis.com/` and cannot be changed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The recommended deployment of the API. Format:
        /// `projects/{project}/locations/{location}/apis/{api}/deployments/{deployment}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommendedDeployment")]
        public virtual string RecommendedDeployment { get; set; }

        /// <summary>
        /// The recommended version of the API. Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommendedVersion")]
        public virtual string RecommendedVersion { get; set; }

        /// <summary>Output only. Last update timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes a service running at particular address that provides a particular version of an API. ApiDeployments
    /// have revisions which correspond to different configurations of a single deployment in time. Revision identifiers
    /// should be updated whenever the served API spec or endpoint address changes.
    /// </summary>
    public class ApiDeployment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Text briefly describing how to access the endpoint. Changes to this value will not affect the revision.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessGuidance")]
        public virtual string AccessGuidance { get; set; }

        /// <summary>
        /// Annotations attach non-identifying metadata to resources. Annotation keys and values are less restricted
        /// than those of labels, but should be generally used for small values of broad interest. Larger, topic-
        /// specific metadata should be stored in Artifacts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// The full resource name (including revision ID) of the spec of the API being served by the deployment.
        /// Changes to this value will update the revision. Format: `apis/{api}/deployments/{deployment}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiSpecRevision")]
        public virtual string ApiSpecRevision { get; set; }

        /// <summary>Output only. Creation timestamp; when the deployment resource was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>A detailed description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Human-meaningful name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The address where the deployment is serving. Changes to this value will update the revision.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointUri")]
        public virtual string EndpointUri { get; set; }

        /// <summary>
        /// The address of the external channel of the API (e.g., the Developer Portal). Changes to this value will not
        /// affect the revision.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalChannelUri")]
        public virtual string ExternalChannelUri { get; set; }

        /// <summary>
        /// Text briefly identifying the intended audience of the API. Changes to this value will not affect the
        /// revision.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intendedAudience")]
        public virtual string IntendedAudience { get; set; }

        /// <summary>
        /// Labels attach identifying metadata to resources. Identifying metadata can be used to filter list operations.
        /// Label keys and values can be no longer than 64 characters (Unicode codepoints), can only contain lowercase
        /// letters, numeric characters, underscores and dashes. International characters are allowed. No more than 64
        /// user labels can be associated with one resource (System labels are excluded). See https://goo.gl/xmQnxf for
        /// more information and examples of labels. System reserved label keys are prefixed with
        /// `apigeeregistry.googleapis.com/` and cannot be changed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Revision creation timestamp; when the represented revision was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionCreateTime")]
        public virtual object RevisionCreateTime { get; set; }

        /// <summary>
        /// Output only. Immutable. The revision ID of the deployment. A new revision is committed whenever the
        /// deployment contents are changed. The format is an 8-character hexadecimal string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>Output only. Last update timestamp: when the represented revision was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionUpdateTime")]
        public virtual object RevisionUpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes a version of an API in a structured way. ApiSpecs provide formal descriptions that consumers can use
    /// to use a version. ApiSpec resources are intended to be fully-resolved descriptions of an ApiVersion. When specs
    /// consist of multiple files, these should be bundled together (e.g., in a zip archive) and stored as a unit.
    /// Multiple specs can exist to provide representations in different API description formats. Synchronization of
    /// these representations would be provided by tooling and background services.
    /// </summary>
    public class ApiSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Annotations attach non-identifying metadata to resources. Annotation keys and values are less restricted
        /// than those of labels, but should be generally used for small values of broad interest. Larger, topic-
        /// specific metadata should be stored in Artifacts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// Input only. The contents of the spec. Provided by API callers when specs are created or updated. To access
        /// the contents of a spec, use GetApiSpecContents.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contents")]
        public virtual string Contents { get; set; }

        /// <summary>Output only. Creation timestamp; when the spec resource was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>A detailed description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>A possibly-hierarchical name used to refer to the spec from other specs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filename")]
        public virtual string Filename { get; set; }

        /// <summary>
        /// Output only. A SHA-256 hash of the spec's contents. If the spec is gzipped, this is the hash of the
        /// uncompressed spec.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hash")]
        public virtual string Hash { get; set; }

        /// <summary>
        /// Labels attach identifying metadata to resources. Identifying metadata can be used to filter list operations.
        /// Label keys and values can be no longer than 64 characters (Unicode codepoints), can only contain lowercase
        /// letters, numeric characters, underscores and dashes. International characters are allowed. No more than 64
        /// user labels can be associated with one resource (System labels are excluded). See https://goo.gl/xmQnxf for
        /// more information and examples of labels. System reserved label keys are prefixed with
        /// `apigeeregistry.googleapis.com/` and cannot be changed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// A style (format) descriptor for this spec that is specified as a Media Type
        /// (https://en.wikipedia.org/wiki/Media_type). Possible values include `application/vnd.apigee.proto`,
        /// `application/vnd.apigee.openapi`, and `application/vnd.apigee.graphql`, with possible suffixes representing
        /// compression types. These hypothetical names are defined in the vendor tree defined in RFC6838
        /// (https://tools.ietf.org/html/rfc6838) and are not final. Content types can specify compression. Currently
        /// only GZip compression is supported (indicated with "+gzip").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>Resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Revision creation timestamp; when the represented revision was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionCreateTime")]
        public virtual object RevisionCreateTime { get; set; }

        /// <summary>
        /// Output only. Immutable. The revision ID of the spec. A new revision is committed whenever the spec contents
        /// are changed. The format is an 8-character hexadecimal string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>Output only. Last update timestamp: when the represented revision was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionUpdateTime")]
        public virtual object RevisionUpdateTime { get; set; }

        /// <summary>
        /// Output only. The size of the spec file in bytes. If the spec is gzipped, this is the size of the
        /// uncompressed spec.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeBytes")]
        public virtual System.Nullable<int> SizeBytes { get; set; }

        /// <summary>
        /// The original source URI of the spec (if one exists). This is an external location that can be used for
        /// reference purposes but which may not be authoritative since this external resource may change after the spec
        /// is retrieved.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceUri")]
        public virtual string SourceUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a particular version of an API. ApiVersions are what consumers actually use.</summary>
    public class ApiVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Annotations attach non-identifying metadata to resources. Annotation keys and values are less restricted
        /// than those of labels, but should be generally used for small values of broad interest. Larger, topic-
        /// specific metadata should be stored in Artifacts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>Output only. Creation timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>A detailed description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Human-meaningful name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Labels attach identifying metadata to resources. Identifying metadata can be used to filter list operations.
        /// Label keys and values can be no longer than 64 characters (Unicode codepoints), can only contain lowercase
        /// letters, numeric characters, underscores and dashes. International characters are allowed. No more than 64
        /// user labels can be associated with one resource (System labels are excluded). See https://goo.gl/xmQnxf for
        /// more information and examples of labels. System reserved label keys are prefixed with
        /// `apigeeregistry.googleapis.com/` and cannot be changed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// A user-definable description of the lifecycle phase of this API version. Format: free-form, but we expect
        /// single words that describe API maturity, e.g., "CONCEPT", "DESIGN", "DEVELOPMENT", "STAGING", "PRODUCTION",
        /// "DEPRECATED", "RETIRED".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Last update timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Artifacts of resources. Artifacts are unique (single-value) per resource and are used to store metadata that is
    /// too large or numerous to be stored directly on the resource. Since artifacts are stored separately from parent
    /// resources, they should generally be used for metadata that is needed infrequently, i.e., not for display in
    /// primary views of the resource but perhaps displayed or downloaded upon request. The `ListArtifacts` method
    /// allows artifacts to be quickly enumerated and checked for presence without downloading their (potentially-large)
    /// contents.
    /// </summary>
    public class Artifact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Input only. The contents of the artifact. Provided by API callers when artifacts are created or replaced. To
        /// access the contents of an artifact, use GetArtifactContents.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contents")]
        public virtual string Contents { get; set; }

        /// <summary>Output only. Creation timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Output only. A SHA-256 hash of the artifact's contents. If the artifact is gzipped, this is the hash of the
        /// uncompressed artifact.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hash")]
        public virtual string Hash { get; set; }

        /// <summary>
        /// A content type specifier for the artifact. Content type specifiers are Media Types
        /// (https://en.wikipedia.org/wiki/Media_type) with a possible "schema" parameter that specifies a schema for
        /// the stored information. Content types can specify compression. Currently only GZip compression is supported
        /// (indicated with "+gzip").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>Resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The size of the artifact in bytes. If the artifact is gzipped, this is the size of the
        /// uncompressed artifact.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeBytes")]
        public virtual System.Nullable<int> SizeBytes { get; set; }

        /// <summary>Output only. Last update timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

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

    /// <summary>Available configurations to provision an Instance.</summary>
    public class Config : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The Customer Managed Encryption Key (CMEK) used for data encryption. The CMEK name should follow
        /// the format of `projects/([^/]+)/locations/([^/]+)/keyRings/([^/]+)/cryptoKeys/([^/]+)`, where the `location`
        /// must match InstanceConfig.location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cmekKeyName")]
        public virtual string CmekKeyName { get; set; }

        /// <summary>Output only. The GCP location where the Instance resides.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

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
    /// Message that represents an arbitrary HTTP body. It should only be used for payload formats that can't be
    /// represented as JSON, such as raw binary or an HTML page. This message can be used both in streaming and
    /// non-streaming API methods in the request as well as the response. It can be used as a top-level request field,
    /// which is convenient if one wants to extract parameters from either the URL or HTTP template into the request
    /// fields and also want access to the raw HTTP body. Example: message GetResourceRequest { // A unique request id.
    /// string request_id = 1; // The raw HTTP body is bound to this field. google.api.HttpBody http_body = 2; } service
    /// ResourceService { rpc GetResource(GetResourceRequest) returns (google.api.HttpBody); rpc
    /// UpdateResource(google.api.HttpBody) returns (google.protobuf.Empty); } Example with streaming methods: service
    /// CaldavService { rpc GetCalendar(stream google.api.HttpBody) returns (stream google.api.HttpBody); rpc
    /// UpdateCalendar(stream google.api.HttpBody) returns (stream google.api.HttpBody); } Use of this type only changes
    /// how the request and response bodies are handled, all other features will continue to work unchanged.
    /// </summary>
    public class HttpBody : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The HTTP Content-Type header value specifying the content type of the body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>The HTTP request/response body as raw binary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>
        /// Application specific response metadata. Must be set in the first response for streaming APIs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extensions")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Extensions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Instance represents the instance resources of the Registry. Currently, only one instance is allowed for each
    /// project.
    /// </summary>
    public class Instance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Config of the Instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual Config Config { get; set; }

        /// <summary>Output only. Creation timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Format: `projects/*/locations/*/instance`. Currently only `locations/global` is supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The current state of the Instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Extra information of Instance.State if the state is `FAILED`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        /// <summary>Output only. Last update timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListApiDeploymentRevisionsResponse.</summary>
    public class ListApiDeploymentRevisionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The revisions of the deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiDeployments")]
        public virtual System.Collections.Generic.IList<ApiDeployment> ApiDeployments { get; set; }

        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListApiDeployments.</summary>
    public class ListApiDeploymentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The deployments from the specified publisher.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiDeployments")]
        public virtual System.Collections.Generic.IList<ApiDeployment> ApiDeployments { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListApiSpecRevisionsResponse.</summary>
    public class ListApiSpecRevisionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The revisions of the spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiSpecs")]
        public virtual System.Collections.Generic.IList<ApiSpec> ApiSpecs { get; set; }

        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListApiSpecs.</summary>
    public class ListApiSpecsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The specs from the specified publisher.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiSpecs")]
        public virtual System.Collections.Generic.IList<ApiSpec> ApiSpecs { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListApiVersions.</summary>
    public class ListApiVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The versions from the specified publisher.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersions")]
        public virtual System.Collections.Generic.IList<ApiVersion> ApiVersions { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListApis.</summary>
    public class ListApisResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The APIs from the specified publisher.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apis")]
        public virtual System.Collections.Generic.IList<Api> Apis { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListArtifacts.</summary>
    public class ListArtifactsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The artifacts from the specified publisher.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifacts")]
        public virtual System.Collections.Generic.IList<Artifact> Artifacts { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
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
        /// <summary>API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>
        /// Identifies whether the user has requested cancellation of the operation. Operations that have successfully
        /// been cancelled have Operation.error value with a google.rpc.Status.code of 1, corresponding to
        /// `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancellationRequested")]
        public virtual System.Nullable<bool> CancellationRequested { get; set; }

        /// <summary>The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>Server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Name of the verb executed by the operation.</summary>
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

    /// <summary>Request message for RollbackApiDeployment.</summary>
    public class RollbackApiDeploymentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The revision ID to roll back to. It must be a revision of the same deployment. Example: `c7cfa2a8`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for RollbackApiSpec.</summary>
    public class RollbackApiSpecRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The revision ID to roll back to. It must be a revision of the same spec. Example: `c7cfa2a8`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

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

    /// <summary>Request message for TagApiDeploymentRevision.</summary>
    public class TagApiDeploymentRevisionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The tag to apply. The tag should be at most 40 characters, and match `a-z{3,39}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for TagApiSpecRevision.</summary>
    public class TagApiSpecRevisionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The tag to apply. The tag should be at most 40 characters, and match `a-z{3,39}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

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
}
