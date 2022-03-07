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

namespace Google.Apis.CloudDataplex.v1
{
    /// <summary>The CloudDataplex Service.</summary>
    public class CloudDataplexService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudDataplexService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudDataplexService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "dataplex";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://dataplex.googleapis.com/";
        #else
            "https://dataplex.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://dataplex.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Dataplex API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Dataplex API.</summary>
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

    /// <summary>A base abstract class for CloudDataplex requests.</summary>
    public abstract class CloudDataplexBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudDataplexBaseServiceRequest instance.</summary>
        protected CloudDataplexBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudDataplex parameter list.</summary>
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
                Lakes = new LakesResource(service);
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the Lakes resource.</summary>
            public virtual LakesResource Lakes { get; }

            /// <summary>The "lakes" collection of methods.</summary>
            public class LakesResource
            {
                private const string Resource = "lakes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public LakesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Actions = new ActionsResource(service);
                    Content = new ContentResource(service);
                    Contentitems = new ContentitemsResource(service);
                    Environments = new EnvironmentsResource(service);
                    Tasks = new TasksResource(service);
                    Zones = new ZonesResource(service);
                }

                /// <summary>Gets the Actions resource.</summary>
                public virtual ActionsResource Actions { get; }

                /// <summary>The "actions" collection of methods.</summary>
                public class ActionsResource
                {
                    private const string Resource = "actions";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ActionsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Lists action resources in a lake.</summary>
                    /// <param name="parent">
                    /// Required. The resource name of the parent lake:
                    /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists action resources in a lake.</summary>
                    public class ListRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1ListActionsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the parent lake:
                        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Maximum number of actions to return. The service may return fewer than this value.
                        /// If unspecified, at most 10 actions will be returned. The maximum value is 1000; values above
                        /// 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. Page token received from a previous ListLakeActions call. Provide this to retrieve
                        /// the subsequent page. When paginating, all other parameters provided to ListLakeActions must
                        /// match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/actions";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+$",
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

                /// <summary>Gets the Content resource.</summary>
                public virtual ContentResource Content { get; }

                /// <summary>The "content" collection of methods.</summary>
                public class ContentResource
                {
                    private const string Resource = "content";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ContentResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
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
                    public class GetIamPolicyRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleIamV1Policy>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/content/[^/]+$",
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
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudDataplex.v1.Data.GoogleIamV1SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy.Can
                    /// return NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                    /// </summary>
                    public class SetIamPolicyRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleIamV1Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleIamV1SetIamPolicyRequest body, string resource) : base(service)
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
                        Google.Apis.CloudDataplex.v1.Data.GoogleIamV1SetIamPolicyRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/content/[^/]+$",
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
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudDataplex.v1.Data.GoogleIamV1TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a NOT_FOUND error.Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleIamV1TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleIamV1TestIamPermissionsRequest body, string resource) : base(service)
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
                        Google.Apis.CloudDataplex.v1.Data.GoogleIamV1TestIamPermissionsRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/content/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the Contentitems resource.</summary>
                public virtual ContentitemsResource Contentitems { get; }

                /// <summary>The "contentitems" collection of methods.</summary>
                public class ContentitemsResource
                {
                    private const string Resource = "contentitems";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ContentitemsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Create a content.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The resource name of the parent lake:
                    /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Content body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Create a content.</summary>
                    public class CreateRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Content>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Content body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the parent lake:
                        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Only validate the request, but do not perform mutations. The default is false.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Content Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/contentitems";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+$",
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

                    /// <summary>Delete a content.</summary>
                    /// <param name="name">
                    /// Required. The resource name of the content:
                    /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/content/{content_id}
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Delete a content.</summary>
                    public class DeleteRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the content:
                        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/content/{content_id}
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/contentitems/.*$",
                            });
                        }
                    }

                    /// <summary>Get a content resource.</summary>
                    /// <param name="name">
                    /// Required. The resource name of the content:
                    /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/content/{content_id}
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Get a content resource.</summary>
                    public class GetRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Content>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the content:
                        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/content/{content_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Optional. Specify content view to make a partial request.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>Optional. Specify content view to make a partial request.</summary>
                        public enum ViewEnum
                        {
                            /// <summary>
                            /// Content view not specified. Defaults to BASIC. The API will default to the BASIC view.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("CONTENT_VIEW_UNSPECIFIED")]
                            CONTENTVIEWUNSPECIFIED = 0,

                            /// <summary>Will not return the data_text field.</summary>
                            [Google.Apis.Util.StringValueAttribute("BASIC")]
                            BASIC = 1,

                            /// <summary>Returns the complete proto.</summary>
                            [Google.Apis.Util.StringValueAttribute("FULL")]
                            FULL = 2,
                        }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/contentitems/.*$",
                            });
                            RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                            {
                                Name = "view",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>List content.</summary>
                    /// <param name="parent">
                    /// Required. The resource name of the parent lake:
                    /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>List content.</summary>
                    public class ListRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1ListContentResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the parent lake:
                        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Filter request. Filters are case-sensitive. The following formats are
                        /// supported:labels.key1 = "value1" labels:key1 type = "NOTEBOOK" type = "SQL_SCRIPT"These
                        /// restrictions can be coinjoined with AND, OR and NOT conjunctions.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Maximum number of content to return. The service may return fewer than this value.
                        /// If unspecified, at most 10 content will be returned. The maximum value is 1000; values above
                        /// 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. Page token received from a previous ListContent call. Provide this to retrieve the
                        /// subsequent page. When paginating, all other parameters provided to ListContent must match
                        /// the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/contentitems";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+$",
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

                    /// <summary>Update a content. Only supports full resource update.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. The relative resource name of the content, of the form:
                    /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/content/{content_id}
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Content body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Update a content. Only supports full resource update.</summary>
                    public class PatchRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Content>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Content body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. The relative resource name of the content, of the form:
                        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/content/{content_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Required. Mask of fields to update.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>
                        /// Optional. Only validate the request, but do not perform mutations. The default is false.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Content Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/contentitems/.*$",
                            });
                            RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                            {
                                Name = "updateMask",
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
                }

                /// <summary>Gets the Environments resource.</summary>
                public virtual EnvironmentsResource Environments { get; }

                /// <summary>The "environments" collection of methods.</summary>
                public class EnvironmentsResource
                {
                    private const string Resource = "environments";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public EnvironmentsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Sessions = new SessionsResource(service);
                    }

                    /// <summary>Gets the Sessions resource.</summary>
                    public virtual SessionsResource Sessions { get; }

                    /// <summary>The "sessions" collection of methods.</summary>
                    public class SessionsResource
                    {
                        private const string Resource = "sessions";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public SessionsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Lists session resources in an environment.</summary>
                        /// <param name="parent">
                        /// Required. The resource name of the parent environment:
                        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/environment/{environment_id}
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>Lists session resources in an environment.</summary>
                        public class ListRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1ListSessionsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the parent environment:
                            /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/environment/{environment_id}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. Maximum number of sessions to return. The service may return fewer than this
                            /// value. If unspecified, at most 10 sessions will be returned. The maximum value is 1000;
                            /// values above 1000 will be coerced to 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Optional. Page token received from a previous ListSessions call. Provide this to
                            /// retrieve the subsequent page. When paginating, all other parameters provided to
                            /// ListSessions must match the call that provided the page token.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/sessions";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/environments/[^/]+$",
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

                    /// <summary>Create an environment resource.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The resource name of the parent lake:
                    /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Environment body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Create an environment resource.</summary>
                    public class CreateRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Environment body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the parent lake:
                        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. Environment identifier. * Must contain only lowercase letters, numbers and
                        /// hyphens. * Must start with a letter. * Must be between 1-63 characters. * Must end with a
                        /// number or a letter. * Must be unique within the lake.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("environmentId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string EnvironmentId { get; set; }

                        /// <summary>
                        /// Optional. Only validate the request, but do not perform mutations. The default is false.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Environment Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/environments";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+$",
                            });
                            RequestParameters.Add("environmentId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "environmentId",
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

                    /// <summary>
                    /// Delete the environment resource. All the child resources must have been deleted before
                    /// environment deletion can be initiated.
                    /// </summary>
                    /// <param name="name">
                    /// Required. The resource name of the environment:
                    /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/environments/{environment_id}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>
                    /// Delete the environment resource. All the child resources must have been deleted before
                    /// environment deletion can be initiated.
                    /// </summary>
                    public class DeleteRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the environment:
                        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/environments/{environment_id}`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/environments/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Get environment resource.</summary>
                    /// <param name="name">
                    /// Required. The resource name of the environment:
                    /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/environments/{environment_id}
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Get environment resource.</summary>
                    public class GetRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Environment>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the environment:
                        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/environments/{environment_id}
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/environments/[^/]+$",
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
                    public class GetIamPolicyRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleIamV1Policy>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/environments/[^/]+$",
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

                    /// <summary>Lists environments under the given lake.</summary>
                    /// <param name="parent">
                    /// Required. The resource name of the parent lake:
                    /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists environments under the given lake.</summary>
                    public class ListRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1ListEnvironmentsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the parent lake:
                        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. Filter request.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Optional. Order by fields for the result.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. Maximum number of environments to return. The service may return fewer than this
                        /// value. If unspecified, at most 10 environments will be returned. The maximum value is 1000;
                        /// values above 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. Page token received from a previous ListEnvironments call. Provide this to
                        /// retrieve the subsequent page. When paginating, all other parameters provided to
                        /// ListEnvironments must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/environments";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+$",
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

                    /// <summary>Update the environment resource.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. The relative resource name of the environment, of the form:
                    /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/environment/{environment_id}
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Environment body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Update the environment resource.</summary>
                    public class PatchRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Environment body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. The relative resource name of the environment, of the form:
                        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/environment/{environment_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Required. Mask of fields to update.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>
                        /// Optional. Only validate the request, but do not perform mutations. The default is false.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Environment Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/environments/[^/]+$",
                            });
                            RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                            {
                                Name = "updateMask",
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

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy.Can
                    /// return NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudDataplex.v1.Data.GoogleIamV1SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy.Can
                    /// return NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                    /// </summary>
                    public class SetIamPolicyRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleIamV1Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleIamV1SetIamPolicyRequest body, string resource) : base(service)
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
                        Google.Apis.CloudDataplex.v1.Data.GoogleIamV1SetIamPolicyRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/environments/[^/]+$",
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
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudDataplex.v1.Data.GoogleIamV1TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a NOT_FOUND error.Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleIamV1TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleIamV1TestIamPermissionsRequest body, string resource) : base(service)
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
                        Google.Apis.CloudDataplex.v1.Data.GoogleIamV1TestIamPermissionsRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/environments/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the Tasks resource.</summary>
                public virtual TasksResource Tasks { get; }

                /// <summary>The "tasks" collection of methods.</summary>
                public class TasksResource
                {
                    private const string Resource = "tasks";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public TasksResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Jobs = new JobsResource(service);
                    }

                    /// <summary>Gets the Jobs resource.</summary>
                    public virtual JobsResource Jobs { get; }

                    /// <summary>The "jobs" collection of methods.</summary>
                    public class JobsResource
                    {
                        private const string Resource = "jobs";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public JobsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Cancel jobs running for the task resource.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Required. The resource name of the job:
                        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}
                        /// /task/{task_id}/job/{job_id}`
                        /// </param>
                        public virtual CancelRequest Cancel(Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1CancelJobRequest body, string name)
                        {
                            return new CancelRequest(service, body, name);
                        }

                        /// <summary>Cancel jobs running for the task resource.</summary>
                        public class CancelRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.Empty>
                        {
                            /// <summary>Constructs a new Cancel request.</summary>
                            public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1CancelJobRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the job:
                            /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}
                            /// /task/{task_id}/job/{job_id}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1CancelJobRequest Body { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/tasks/[^/]+/jobs/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Get job resource.</summary>
                        /// <param name="name">
                        /// Required. The resource name of the job:
                        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}
                        /// /tasks/{task_id}/jobs/{job_id}
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Get job resource.</summary>
                        public class GetRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Job>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the job:
                            /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}
                            /// /tasks/{task_id}/jobs/{job_id}
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/tasks/[^/]+/jobs/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Lists Jobs under the given task.</summary>
                        /// <param name="parent">
                        /// Required. The resource name of the parent environment:
                        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/tasks/{task_id}
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>Lists Jobs under the given task.</summary>
                        public class ListRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1ListJobsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the parent environment:
                            /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/tasks/{task_id}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. Maximum number of jobs to return. The service may return fewer than this
                            /// value. If unspecified, at most 10 jobs will be returned. The maximum value is 1000;
                            /// values above 1000 will be coerced to 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Optional. Page token received from a previous ListJobs call. Provide this to retrieve
                            /// the subsequent page. When paginating, all other parameters provided to ListJobs must
                            /// match the call that provided the page token.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/jobs";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/tasks/[^/]+$",
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

                    /// <summary>Creates a task resource within a lake.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The resource name of the parent lake:
                    /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Task body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a task resource within a lake.</summary>
                    public class CreateRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Task body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the parent lake:
                        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Required. Task identifier.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("taskId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string TaskId { get; set; }

                        /// <summary>
                        /// Optional. Only validate the request, but do not perform mutations. The default is false.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Task Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/tasks";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+$",
                            });
                            RequestParameters.Add("taskId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "taskId",
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

                    /// <summary>Delete the task resource.</summary>
                    /// <param name="name">
                    /// Required. The resource name of the task:
                    /// projects/{project_number}/locations/{location_id}/lakes/{lake_id} /task/{task_id}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Delete the task resource.</summary>
                    public class DeleteRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the task:
                        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id} /task/{task_id}`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/tasks/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Get task resource.</summary>
                    /// <param name="name">
                    /// Required. The resource name of the task:
                    /// projects/{project_number}/locations/{location_id}/lakes/{lake_id} /tasks/{tasks_id}
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Get task resource.</summary>
                    public class GetRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Task>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the task:
                        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id} /tasks/{tasks_id}
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/tasks/[^/]+$",
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
                    public class GetIamPolicyRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleIamV1Policy>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/tasks/[^/]+$",
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

                    /// <summary>Lists tasks under the given lake.</summary>
                    /// <param name="parent">
                    /// Required. The resource name of the parent lake:
                    /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists tasks under the given lake.</summary>
                    public class ListRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1ListTasksResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the parent lake:
                        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. Filter request.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Optional. Order by fields for the result.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. Maximum number of tasks to return. The service may return fewer than this value.
                        /// If unspecified, at most 10 tasks will be returned. The maximum value is 1000; values above
                        /// 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. Page token received from a previous ListZones call. Provide this to retrieve the
                        /// subsequent page. When paginating, all other parameters provided to ListZones must match the
                        /// call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/tasks";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+$",
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

                    /// <summary>Update the task resource.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. The relative resource name of the task, of the form:
                    /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/ tasks/{task_id}.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Task body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Update the task resource.</summary>
                    public class PatchRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Task body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. The relative resource name of the task, of the form:
                        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/ tasks/{task_id}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Required. Mask of fields to update.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>
                        /// Optional. Only validate the request, but do not perform mutations. The default is false.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Task Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/tasks/[^/]+$",
                            });
                            RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                            {
                                Name = "updateMask",
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

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy.Can
                    /// return NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudDataplex.v1.Data.GoogleIamV1SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy.Can
                    /// return NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                    /// </summary>
                    public class SetIamPolicyRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleIamV1Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleIamV1SetIamPolicyRequest body, string resource) : base(service)
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
                        Google.Apis.CloudDataplex.v1.Data.GoogleIamV1SetIamPolicyRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/tasks/[^/]+$",
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
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudDataplex.v1.Data.GoogleIamV1TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a NOT_FOUND error.Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleIamV1TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleIamV1TestIamPermissionsRequest body, string resource) : base(service)
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
                        Google.Apis.CloudDataplex.v1.Data.GoogleIamV1TestIamPermissionsRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/tasks/[^/]+$",
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
                        Actions = new ActionsResource(service);
                        Assets = new AssetsResource(service);
                        Entities = new EntitiesResource(service);
                    }

                    /// <summary>Gets the Actions resource.</summary>
                    public virtual ActionsResource Actions { get; }

                    /// <summary>The "actions" collection of methods.</summary>
                    public class ActionsResource
                    {
                        private const string Resource = "actions";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public ActionsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Lists action resources in a zone.</summary>
                        /// <param name="parent">
                        /// Required. The resource name of the parent zone:
                        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>Lists action resources in a zone.</summary>
                        public class ListRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1ListActionsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the parent zone:
                            /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. Maximum number of actions to return. The service may return fewer than this
                            /// value. If unspecified, at most 10 actions will be returned. The maximum value is 1000;
                            /// values above 1000 will be coerced to 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Optional. Page token received from a previous ListZoneActions call. Provide this to
                            /// retrieve the subsequent page. When paginating, all other parameters provided to
                            /// ListZoneActions must match the call that provided the page token.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/actions";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/zones/[^/]+$",
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

                    /// <summary>Gets the Assets resource.</summary>
                    public virtual AssetsResource Assets { get; }

                    /// <summary>The "assets" collection of methods.</summary>
                    public class AssetsResource
                    {
                        private const string Resource = "assets";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public AssetsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                            Actions = new ActionsResource(service);
                        }

                        /// <summary>Gets the Actions resource.</summary>
                        public virtual ActionsResource Actions { get; }

                        /// <summary>The "actions" collection of methods.</summary>
                        public class ActionsResource
                        {
                            private const string Resource = "actions";

                            /// <summary>The service which this resource belongs to.</summary>
                            private readonly Google.Apis.Services.IClientService service;

                            /// <summary>Constructs a new resource.</summary>
                            public ActionsResource(Google.Apis.Services.IClientService service)
                            {
                                this.service = service;
                            }

                            /// <summary>Lists action resources in an asset.</summary>
                            /// <param name="parent">
                            /// Required. The resource name of the parent asset:
                            /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/assets/{asset_id}
                            /// </param>
                            public virtual ListRequest List(string parent)
                            {
                                return new ListRequest(service, parent);
                            }

                            /// <summary>Lists action resources in an asset.</summary>
                            public class ListRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1ListActionsResponse>
                            {
                                /// <summary>Constructs a new List request.</summary>
                                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                                {
                                    Parent = parent;
                                    InitParameters();
                                }

                                /// <summary>
                                /// Required. The resource name of the parent asset:
                                /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/assets/{asset_id}
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Parent { get; private set; }

                                /// <summary>
                                /// Optional. Maximum number of actions to return. The service may return fewer than
                                /// this value. If unspecified, at most 10 actions will be returned. The maximum value
                                /// is 1000; values above 1000 will be coerced to 1000.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual System.Nullable<int> PageSize { get; set; }

                                /// <summary>
                                /// Optional. Page token received from a previous ListAssetActions call. Provide this to
                                /// retrieve the subsequent page. When paginating, all other parameters provided to
                                /// ListAssetActions must match the call that provided the page token.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual string PageToken { get; set; }

                                /// <summary>Gets the method name.</summary>
                                public override string MethodName => "list";

                                /// <summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "GET";

                                /// <summary>Gets the REST path.</summary>
                                public override string RestPath => "v1/{+parent}/actions";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/zones/[^/]+/assets/[^/]+$",
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

                        /// <summary>Creates an asset resource.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The resource name of the parent zone:
                        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id} /zones/{zone_id}`
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Asset body, string parent)
                        {
                            return new CreateRequest(service, body, parent);
                        }

                        /// <summary>Creates an asset resource.</summary>
                        public class CreateRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleLongrunningOperation>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Asset body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the parent zone:
                            /// projects/{project_number}/locations/{location_id}/lakes/{lake_id} /zones/{zone_id}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Required. Asset identifier. This ID will be used to generate names such as table names
                            /// when publishing metadata to Hive Metastore and BigQuery. * Must contain only lowercase
                            /// letters, numbers and hyphens. * Must start with a letter. * Must end with a number or a
                            /// letter. * Must be between 1-63 characters. * Must be unique within the zone.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("assetId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string AssetId { get; set; }

                            /// <summary>
                            /// Optional. Only validate the request, but do not perform mutations. The default is false.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<bool> ValidateOnly { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Asset Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/assets";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/zones/[^/]+$",
                                });
                                RequestParameters.Add("assetId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "assetId",
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

                        /// <summary>
                        /// Deletes an asset resource. The referenced storage resource is detached (default) or deleted
                        /// based on the associated Lifecycle policy.
                        /// </summary>
                        /// <param name="name">
                        /// Required. The resource name of the asset:
                        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}
                        /// /zones/{zone_id}/assets/{asset_id}
                        /// </param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(service, name);
                        }

                        /// <summary>
                        /// Deletes an asset resource. The referenced storage resource is detached (default) or deleted
                        /// based on the associated Lifecycle policy.
                        /// </summary>
                        public class DeleteRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleLongrunningOperation>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the asset:
                            /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}
                            /// /zones/{zone_id}/assets/{asset_id}
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/zones/[^/]+/assets/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Retrieves an asset resource.</summary>
                        /// <param name="name">
                        /// Required. The resource name of the asset:
                        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}
                        /// /zones/{zone_id}/assets/{asset_id}
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Retrieves an asset resource.</summary>
                        public class GetRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Asset>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the asset:
                            /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}
                            /// /zones/{zone_id}/assets/{asset_id}
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/zones/[^/]+/assets/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Gets the access control policy for a resource. Returns an empty policy if the resource
                        /// exists and does not have a policy set.
                        /// </summary>
                        /// <param name="resource">
                        /// REQUIRED: The resource for which the policy is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </param>
                        public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                        {
                            return new GetIamPolicyRequest(service, resource);
                        }

                        /// <summary>
                        /// Gets the access control policy for a resource. Returns an empty policy if the resource
                        /// exists and does not have a policy set.
                        /// </summary>
                        public class GetIamPolicyRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleIamV1Policy>
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/zones/[^/]+/assets/[^/]+$",
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

                        /// <summary>Lists asset resources in a zone.</summary>
                        /// <param name="parent">
                        /// Required. The resource name of the parent zone:
                        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id} /zones/{zone_id}`
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>Lists asset resources in a zone.</summary>
                        public class ListRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1ListAssetsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the parent zone:
                            /// projects/{project_number}/locations/{location_id}/lakes/{lake_id} /zones/{zone_id}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Optional. Filter request.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>Optional. Order by fields for the result.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string OrderBy { get; set; }

                            /// <summary>
                            /// Optional. Maximum number of asset to return. The service may return fewer than this
                            /// value. If unspecified, at most 10 assets will be returned. The maximum value is 1000;
                            /// values above 1000 will be coerced to 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Optional. Page token received from a previous ListAssets call. Provide this to retrieve
                            /// the subsequent page. When paginating, all other parameters provided to ListAssets must
                            /// match the call that provided the page token.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/assets";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/zones/[^/]+$",
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

                        /// <summary>Updates an asset resource.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Output only. The relative resource name of the asset, of the form:
                        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/assets/{asset_id}.
                        /// </param>
                        public virtual PatchRequest Patch(Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Asset body, string name)
                        {
                            return new PatchRequest(service, body, name);
                        }

                        /// <summary>Updates an asset resource.</summary>
                        public class PatchRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleLongrunningOperation>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Asset body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Output only. The relative resource name of the asset, of the form:
                            /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/assets/{asset_id}.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Required. Mask of fields to update.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }

                            /// <summary>
                            /// Optional. Only validate the request, but do not perform mutations. The default is false.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<bool> ValidateOnly { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Asset Body { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/zones/[^/]+/assets/[^/]+$",
                                });
                                RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "updateMask",
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

                        /// <summary>
                        /// Sets the access control policy on the specified resource. Replaces any existing policy.Can
                        /// return NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="resource">
                        /// REQUIRED: The resource for which the policy is being specified. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </param>
                        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudDataplex.v1.Data.GoogleIamV1SetIamPolicyRequest body, string resource)
                        {
                            return new SetIamPolicyRequest(service, body, resource);
                        }

                        /// <summary>
                        /// Sets the access control policy on the specified resource. Replaces any existing policy.Can
                        /// return NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                        /// </summary>
                        public class SetIamPolicyRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleIamV1Policy>
                        {
                            /// <summary>Constructs a new SetIamPolicy request.</summary>
                            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleIamV1SetIamPolicyRequest body, string resource) : base(service)
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
                            Google.Apis.CloudDataplex.v1.Data.GoogleIamV1SetIamPolicyRequest Body { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/zones/[^/]+/assets/[^/]+$",
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
                        /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </param>
                        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudDataplex.v1.Data.GoogleIamV1TestIamPermissionsRequest body, string resource)
                        {
                            return new TestIamPermissionsRequest(service, body, resource);
                        }

                        /// <summary>
                        /// Returns permissions that a caller has on the specified resource. If the resource does not
                        /// exist, this will return an empty set of permissions, not a NOT_FOUND error.Note: This
                        /// operation is designed to be used for building permission-aware UIs and command-line tools,
                        /// not for authorization checking. This operation may "fail open" without warning.
                        /// </summary>
                        public class TestIamPermissionsRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleIamV1TestIamPermissionsResponse>
                        {
                            /// <summary>Constructs a new TestIamPermissions request.</summary>
                            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleIamV1TestIamPermissionsRequest body, string resource) : base(service)
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
                            Google.Apis.CloudDataplex.v1.Data.GoogleIamV1TestIamPermissionsRequest Body { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/zones/[^/]+/assets/[^/]+$",
                                });
                            }
                        }
                    }

                    /// <summary>Gets the Entities resource.</summary>
                    public virtual EntitiesResource Entities { get; }

                    /// <summary>The "entities" collection of methods.</summary>
                    public class EntitiesResource
                    {
                        private const string Resource = "entities";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public EntitiesResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                            Partitions = new PartitionsResource(service);
                        }

                        /// <summary>Gets the Partitions resource.</summary>
                        public virtual PartitionsResource Partitions { get; }

                        /// <summary>The "partitions" collection of methods.</summary>
                        public class PartitionsResource
                        {
                            private const string Resource = "partitions";

                            /// <summary>The service which this resource belongs to.</summary>
                            private readonly Google.Apis.Services.IClientService service;

                            /// <summary>Constructs a new resource.</summary>
                            public PartitionsResource(Google.Apis.Services.IClientService service)
                            {
                                this.service = service;
                            }

                            /// <summary>Create a metadata partition.</summary>
                            /// <param name="body">The body of the request.</param>
                            /// <param name="parent">
                            /// Required. The resource name of the parent zone:
                            /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}.
                            /// </param>
                            public virtual CreateRequest Create(Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Partition body, string parent)
                            {
                                return new CreateRequest(service, body, parent);
                            }

                            /// <summary>Create a metadata partition.</summary>
                            public class CreateRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Partition>
                            {
                                /// <summary>Constructs a new Create request.</summary>
                                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Partition body, string parent) : base(service)
                                {
                                    Parent = parent;
                                    Body = body;
                                    InitParameters();
                                }

                                /// <summary>
                                /// Required. The resource name of the parent zone:
                                /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Parent { get; private set; }

                                /// <summary>
                                /// Optional. Only validate the request, but do not perform mutations. The default is
                                /// false.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual System.Nullable<bool> ValidateOnly { get; set; }

                                /// <summary>Gets or sets the body of this request.</summary>
                                Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Partition Body { get; set; }

                                /// <summary>Returns the body of the request.</summary>
                                protected override object GetBody() => Body;

                                /// <summary>Gets the method name.</summary>
                                public override string MethodName => "create";

                                /// <summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "POST";

                                /// <summary>Gets the REST path.</summary>
                                public override string RestPath => "v1/{+parent}/partitions";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/zones/[^/]+/entities/[^/]+$",
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

                            /// <summary>Delete a metadata partition.</summary>
                            /// <param name="name">
                            /// Required. The resource name of the partition. format:
                            /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}/partitions/{partition_value_path}.
                            /// The {partition_value_path} segment consists of an ordered sequence of partition values
                            /// separated by "/". All values must be provided.
                            /// </param>
                            public virtual DeleteRequest Delete(string name)
                            {
                                return new DeleteRequest(service, name);
                            }

                            /// <summary>Delete a metadata partition.</summary>
                            public class DeleteRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.Empty>
                            {
                                /// <summary>Constructs a new Delete request.</summary>
                                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                                {
                                    Name = name;
                                    InitParameters();
                                }

                                /// <summary>
                                /// Required. The resource name of the partition. format:
                                /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}/partitions/{partition_value_path}.
                                /// The {partition_value_path} segment consists of an ordered sequence of partition
                                /// values separated by "/". All values must be provided.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Name { get; private set; }

                                /// <summary>Optional. The etag associated with the partition.</summary>
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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/zones/[^/]+/entities/[^/]+/partitions/.*$",
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

                            /// <summary>Get a metadata partition of an entity.</summary>
                            /// <param name="name">
                            /// Required. The resource name of the partition:
                            /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}/partitions/{partition_value_path}.
                            /// The {partition_value_path} segment consists of an ordered sequence of partition values
                            /// separated by "/". All values must be provided.
                            /// </param>
                            public virtual GetRequest Get(string name)
                            {
                                return new GetRequest(service, name);
                            }

                            /// <summary>Get a metadata partition of an entity.</summary>
                            public class GetRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Partition>
                            {
                                /// <summary>Constructs a new Get request.</summary>
                                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                                {
                                    Name = name;
                                    InitParameters();
                                }

                                /// <summary>
                                /// Required. The resource name of the partition:
                                /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}/partitions/{partition_value_path}.
                                /// The {partition_value_path} segment consists of an ordered sequence of partition
                                /// values separated by "/". All values must be provided.
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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/zones/[^/]+/entities/[^/]+/partitions/.*$",
                                    });
                                }
                            }

                            /// <summary>List metadata partitions of an entity.</summary>
                            /// <param name="parent">
                            /// Required. The resource name of the parent entity:
                            /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}.
                            /// </param>
                            public virtual ListRequest List(string parent)
                            {
                                return new ListRequest(service, parent);
                            }

                            /// <summary>List metadata partitions of an entity.</summary>
                            public class ListRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1ListPartitionsResponse>
                            {
                                /// <summary>Constructs a new List request.</summary>
                                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                                {
                                    Parent = parent;
                                    InitParameters();
                                }

                                /// <summary>
                                /// Required. The resource name of the parent entity:
                                /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Parent { get; private set; }

                                /// <summary>
                                /// Optional. Filter the partitions returned to the caller using a key value pair
                                /// expression. Supported operators and syntax: logic operators: AND, OR comparison
                                /// operators: &amp;lt;, &amp;gt;, &amp;gt;=, &amp;lt;= ,=, != LIKE operators: The right
                                /// hand of a LIKE operator supports "." and "*" for wildcard searches, for example
                                /// "value1 LIKE ".*oo.*" parenthetical grouping: ( )Sample filter expression:
                                /// `?filter="key1 &amp;lt; value1 OR key2 &amp;gt; value2"Notes: Keys to the left of
                                /// operators are case insensitive. Partition results are sorted first by creation time,
                                /// then by lexicographic order. Up to 20 key value filter pairs are allowed, but due to
                                /// performance considerations, only the first 10 will be used as a filter.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual string Filter { get; set; }

                                /// <summary>
                                /// Optional. Maximum number of partitions to return. The service may return fewer than
                                /// this value. If unspecified, 100 partitions will be returned by default. The maximum
                                /// page size is 500; larger values will will be truncated to 500.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual System.Nullable<int> PageSize { get; set; }

                                /// <summary>
                                /// Optional. Page token received from a previous ListPartitions call. Provide this to
                                /// retrieve the subsequent page. When paginating, all other parameters provided to
                                /// ListPartitions must match the call that provided the page token.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual string PageToken { get; set; }

                                /// <summary>Gets the method name.</summary>
                                public override string MethodName => "list";

                                /// <summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "GET";

                                /// <summary>Gets the REST path.</summary>
                                public override string RestPath => "v1/{+parent}/partitions";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/zones/[^/]+/entities/[^/]+$",
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

                        /// <summary>Create a metadata entity.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The resource name of the parent zone:
                        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}.
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Entity body, string parent)
                        {
                            return new CreateRequest(service, body, parent);
                        }

                        /// <summary>Create a metadata entity.</summary>
                        public class CreateRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Entity>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Entity body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the parent zone:
                            /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. Only validate the request, but do not perform mutations. The default is false.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<bool> ValidateOnly { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Entity Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/entities";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/zones/[^/]+$",
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

                        /// <summary>Delete a metadata entity.</summary>
                        /// <param name="name">
                        /// Required. The resource name of the entity:
                        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}.
                        /// </param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(service, name);
                        }

                        /// <summary>Delete a metadata entity.</summary>
                        public class DeleteRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.Empty>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the entity:
                            /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// Required. The etag associated with the entity, which can be retrieved with a GetEntity
                            /// request.
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/zones/[^/]+/entities/[^/]+$",
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

                        /// <summary>Get a metadata entity.</summary>
                        /// <param name="name">
                        /// Required. The resource name of the entity:
                        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}.
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Get a metadata entity.</summary>
                        public class GetRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Entity>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the entity:
                            /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// Optional. Used to select the subset of entity information to return. Defaults to BASIC.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<ViewEnum> View { get; set; }

                            /// <summary>
                            /// Optional. Used to select the subset of entity information to return. Defaults to BASIC.
                            /// </summary>
                            public enum ViewEnum
                            {
                                /// <summary>The API will default to the BASIC view.</summary>
                                [Google.Apis.Util.StringValueAttribute("ENTITY_VIEW_UNSPECIFIED")]
                                ENTITYVIEWUNSPECIFIED = 0,

                                /// <summary>Minimal view that does not include the schema.</summary>
                                [Google.Apis.Util.StringValueAttribute("BASIC")]
                                BASIC = 1,

                                /// <summary>Include basic information and schema.</summary>
                                [Google.Apis.Util.StringValueAttribute("SCHEMA")]
                                SCHEMA = 2,

                                /// <summary>
                                /// Include everything. Currently, this is the same as the SCHEMA view.
                                /// </summary>
                                [Google.Apis.Util.StringValueAttribute("FULL")]
                                FULL = 3,
                            }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/zones/[^/]+/entities/[^/]+$",
                                });
                                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "view",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>List metadata entities in a zone.</summary>
                        /// <param name="parent">
                        /// Required. The resource name of the parent zone:
                        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}.
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>List metadata entities in a zone.</summary>
                        public class ListRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1ListEntitiesResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the parent zone:
                            /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. The following filter parameters can be added to the URL to limit the entities
                            /// returned by the API: Entity ID: ?filter="id=entityID" Asset ID: ?filter="asset=assetID"
                            /// Data path ?filter="data_path=gs://my-bucket" Is HIVE compatible:
                            /// ?filter="hive_compatible=true" Is BigQuery compatible:
                            /// ?filter="bigquery_compatible=true"
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>
                            /// Optional. Maximum number of entities to return. The service may return fewer than this
                            /// value. If unspecified, 100 entities will be returned by default. The maximum value is
                            /// 500; larger values will will be truncated to 500.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Optional. Page token received from a previous ListEntities call. Provide this to
                            /// retrieve the subsequent page. When paginating, all other parameters provided to
                            /// ListEntities must match the call that provided the page token.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Required. Specify the entity view to make a partial list request.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<ViewEnum> View { get; set; }

                            /// <summary>Required. Specify the entity view to make a partial list request.</summary>
                            public enum ViewEnum
                            {
                                /// <summary>
                                /// The default unset value. Return both table and fileset entities if unspecified.
                                /// </summary>
                                [Google.Apis.Util.StringValueAttribute("ENTITY_VIEW_UNSPECIFIED")]
                                ENTITYVIEWUNSPECIFIED = 0,

                                /// <summary>Only list table entities.</summary>
                                [Google.Apis.Util.StringValueAttribute("TABLES")]
                                TABLES = 1,

                                /// <summary>Only list fileset entities.</summary>
                                [Google.Apis.Util.StringValueAttribute("FILESETS")]
                                FILESETS = 2,
                            }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/entities";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/zones/[^/]+$",
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
                                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "view",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>Update a metadata entity. Only supports full resource update.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Output only. The resource name of the entity, of the form:
                        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{id}.
                        /// </param>
                        public virtual UpdateRequest Update(Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Entity body, string name)
                        {
                            return new UpdateRequest(service, body, name);
                        }

                        /// <summary>Update a metadata entity. Only supports full resource update.</summary>
                        public class UpdateRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Entity>
                        {
                            /// <summary>Constructs a new Update request.</summary>
                            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Entity body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Output only. The resource name of the entity, of the form:
                            /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{id}.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// Optional. Only validate the request, but do not perform mutations. The default is false.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<bool> ValidateOnly { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Entity Body { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/zones/[^/]+/entities/[^/]+$",
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
                    }

                    /// <summary>Creates a zone resource within a lake.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The resource name of the parent lake:
                    /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Zone body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a zone resource within a lake.</summary>
                    public class CreateRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Zone body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the parent lake:
                        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Only validate the request, but do not perform mutations. The default is false.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>
                        /// Required. Zone identifier. This ID will be used to generate names such as database and
                        /// dataset names when publishing metadata to Hive Metastore and BigQuery. * Must contain only
                        /// lowercase letters, numbers and hyphens. * Must start with a letter. * Must end with a number
                        /// or a letter. * Must be between 1-63 characters. * Must be unique across all lakes from all
                        /// locations in a project. * Must not be one of the reserved IDs (i.e. "default",
                        /// "global-temp")
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("zoneId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ZoneId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Zone Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/zones";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+$",
                            });
                            RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                            {
                                Name = "validateOnly",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("zoneId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "zoneId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes a zone resource. All assets within a zone must be deleted before the zone can be
                    /// deleted.
                    /// </summary>
                    /// <param name="name">
                    /// Required. The resource name of the zone:
                    /// projects/{project_number}/locations/{location_id}/lakes/{lake_id} /zones/{zone_id}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>
                    /// Deletes a zone resource. All assets within a zone must be deleted before the zone can be
                    /// deleted.
                    /// </summary>
                    public class DeleteRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the zone:
                        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id} /zones/{zone_id}`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/zones/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Retrieves a zone resource.</summary>
                    /// <param name="name">
                    /// Required. The resource name of the zone:
                    /// projects/{project_number}/locations/{location_id}/lakes/{lake_id} /zones/{zone_id}
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Retrieves a zone resource.</summary>
                    public class GetRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Zone>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the zone:
                        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id} /zones/{zone_id}
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/zones/[^/]+$",
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
                    public class GetIamPolicyRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleIamV1Policy>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/zones/[^/]+$",
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

                    /// <summary>Lists zone resources in a lake.</summary>
                    /// <param name="parent">
                    /// Required. The resource name of the parent lake:
                    /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists zone resources in a lake.</summary>
                    public class ListRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1ListZonesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the parent lake:
                        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. Filter request.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Optional. Order by fields for the result.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. Maximum number of zones to return. The service may return fewer than this value.
                        /// If unspecified, at most 10 zones will be returned. The maximum value is 1000; values above
                        /// 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. Page token received from a previous ListZones call. Provide this to retrieve the
                        /// subsequent page. When paginating, all other parameters provided to ListZones must match the
                        /// call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/zones";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+$",
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

                    /// <summary>Updates a zone resource.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. The relative resource name of the zone, of the form:
                    /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Zone body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates a zone resource.</summary>
                    public class PatchRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Zone body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. The relative resource name of the zone, of the form:
                        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Required. Mask of fields to update.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>
                        /// Optional. Only validate the request, but do not perform mutations. The default is false.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Zone Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/zones/[^/]+$",
                            });
                            RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                            {
                                Name = "updateMask",
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

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy.Can
                    /// return NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudDataplex.v1.Data.GoogleIamV1SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy.Can
                    /// return NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                    /// </summary>
                    public class SetIamPolicyRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleIamV1Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleIamV1SetIamPolicyRequest body, string resource) : base(service)
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
                        Google.Apis.CloudDataplex.v1.Data.GoogleIamV1SetIamPolicyRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/zones/[^/]+$",
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
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudDataplex.v1.Data.GoogleIamV1TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a NOT_FOUND error.Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleIamV1TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleIamV1TestIamPermissionsRequest body, string resource) : base(service)
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
                        Google.Apis.CloudDataplex.v1.Data.GoogleIamV1TestIamPermissionsRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+/zones/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Creates a lake resource.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource name of the lake location, of the form:
                /// projects/{project_number}/locations/{location_id} where location_id refers to a GCP region.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Lake body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a lake resource.</summary>
                public class CreateRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Lake body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the lake location, of the form:
                    /// projects/{project_number}/locations/{location_id} where location_id refers to a GCP region.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. Lake identifier. This ID will be used to generate names such as database and dataset
                    /// names when publishing metadata to Hive Metastore and BigQuery. * Must contain only lowercase
                    /// letters, numbers and hyphens. * Must start with a letter. * Must end with a number or a letter.
                    /// * Must be between 1-63 characters. * Must be unique within the customer project / location.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("lakeId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string LakeId { get; set; }

                    /// <summary>
                    /// Optional. Only validate the request, but do not perform mutations. The default is false.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Lake Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/lakes";

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
                        RequestParameters.Add("lakeId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "lakeId",
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

                /// <summary>
                /// Deletes a lake resource. All zones within the lake must be deleted before the lake can be deleted.
                /// </summary>
                /// <param name="name">
                /// Required. The resource name of the lake:
                /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a lake resource. All zones within the lake must be deleted before the lake can be deleted.
                /// </summary>
                public class DeleteRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the lake:
                    /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+$",
                        });
                    }
                }

                /// <summary>Retrieves a lake resource.</summary>
                /// <param name="name">
                /// Required. The resource name of the lake:
                /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Retrieves a lake resource.</summary>
                public class GetRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Lake>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the lake:
                    /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+$",
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
                public class GetIamPolicyRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleIamV1Policy>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+$",
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

                /// <summary>Lists lake resources in a project and location.</summary>
                /// <param name="parent">
                /// Required. The resource name of the lake location, of the form:
                /// projects/{project_number}/locations/{location_id} where location_id refers to a GCP region.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists lake resources in a project and location.</summary>
                public class ListRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1ListLakesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the lake location, of the form:
                    /// projects/{project_number}/locations/{location_id} where location_id refers to a GCP region.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Filter request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Order by fields for the result.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. Maximum number of Lakes to return. The service may return fewer than this value. If
                    /// unspecified, at most 10 lakes will be returned. The maximum value is 1000; values above 1000
                    /// will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. Page token received from a previous ListLakes call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to ListLakes must match the call
                    /// that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/lakes";

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

                /// <summary>Updates a lake resource.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. The relative resource name of the lake, of the form:
                /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Lake body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates a lake resource.</summary>
                public class PatchRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Lake body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. The relative resource name of the lake, of the form:
                    /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Required. Mask of fields to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// Optional. Only validate the request, but do not perform mutations. The default is false.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudDataplex.v1.Data.GoogleCloudDataplexV1Lake Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+$",
                        });
                        RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "updateMask",
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

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy.Can return
                /// NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudDataplex.v1.Data.GoogleIamV1SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy.Can return
                /// NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                /// </summary>
                public class SetIamPolicyRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleIamV1Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleIamV1SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.CloudDataplex.v1.Data.GoogleIamV1SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+$",
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
                /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                /// documentation for the appropriate value for this field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudDataplex.v1.Data.GoogleIamV1TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a NOT_FOUND error.Note: This operation is designed
                /// to be used for building permission-aware UIs and command-line tools, not for authorization checking.
                /// This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleIamV1TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleIamV1TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.CloudDataplex.v1.Data.GoogleIamV1TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/lakes/[^/]+$",
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
                public virtual CancelRequest Cancel(Google.Apis.CloudDataplex.v1.Data.GoogleLongrunningCancelOperationRequest body, string name)
                {
                    return new CancelRequest(service, body, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns google.rpc.Code.UNIMPLEMENTED. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to Code.CANCELLED.
                /// </summary>
                public class CancelRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDataplex.v1.Data.GoogleLongrunningCancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudDataplex.v1.Data.GoogleLongrunningCancelOperationRequest Body { get; set; }

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
                /// it returns google.rpc.Code.UNIMPLEMENTED.
                /// </summary>
                /// <param name="name">The name of the operation resource to be deleted.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a long-running operation. This method indicates that the client is no longer interested in
                /// the operation result. It does not cancel the operation. If the server doesn't support this method,
                /// it returns google.rpc.Code.UNIMPLEMENTED.
                /// </summary>
                public class DeleteRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.Empty>
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
                public class GetRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleLongrunningOperation>
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
                /// method, it returns UNIMPLEMENTED.NOTE: the name binding allows API services to override the binding
                /// to use different resource name schemes, such as users/*/operations. To override the binding, API
                /// services can add a binding such as "/v1/{name=users/*}/operations" to their service configuration.
                /// For backwards compatibility, the default name includes the operations collection id, however
                /// overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                /// <param name="name">The name of the operation's parent resource.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns UNIMPLEMENTED.NOTE: the name binding allows API services to override the binding
                /// to use different resource name schemes, such as users/*/operations. To override the binding, API
                /// services can add a binding such as "/v1/{name=users/*}/operations" to their service configuration.
                /// For backwards compatibility, the default name includes the operations collection id, however
                /// overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                public class ListRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleLongrunningListOperationsResponse>
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
                return new GetRequest(service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudLocationLocation>
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
            public class ListRequest : CloudDataplexBaseServiceRequest<Google.Apis.CloudDataplex.v1.Data.GoogleCloudLocationListLocationsResponse>
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
namespace Google.Apis.CloudDataplex.v1.Data
{
    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for Empty is empty JSON
    /// object {}.
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Action represents an issue requiring administrator action for resolution.</summary>
    public class GoogleCloudDataplexV1Action : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The relative resource name of the asset, of the form:
        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/assets/{asset_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public virtual string Asset { get; set; }

        /// <summary>The category of issue associated with the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>
        /// The list of data locations associated with this action. Cloud Storage locations are represented as URI
        /// paths(E.g. gs://bucket/table1/year=2020/month=Jan/). BigQuery locations refer to resource names(E.g.
        /// bigquery.googleapis.com/projects/project-id/datasets/dataset-id).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataLocations")]
        public virtual System.Collections.Generic.IList<string> DataLocations { get; set; }

        /// <summary>The time that the issue was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectTime")]
        public virtual object DetectTime { get; set; }

        /// <summary>Details for issues related to applying security policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedSecurityPolicyApply")]
        public virtual GoogleCloudDataplexV1ActionFailedSecurityPolicyApply FailedSecurityPolicyApply { get; set; }

        /// <summary>Details for issues related to incompatible schemas detected within data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("incompatibleDataSchema")]
        public virtual GoogleCloudDataplexV1ActionIncompatibleDataSchema IncompatibleDataSchema { get; set; }

        /// <summary>Details for issues related to invalid or unsupported data formats.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invalidDataFormat")]
        public virtual GoogleCloudDataplexV1ActionInvalidDataFormat InvalidDataFormat { get; set; }

        /// <summary>Details for issues related to invalid data arrangement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invalidDataOrganization")]
        public virtual GoogleCloudDataplexV1ActionInvalidDataOrganization InvalidDataOrganization { get; set; }

        /// <summary>Details for issues related to invalid or unsupported data partition structure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invalidDataPartition")]
        public virtual GoogleCloudDataplexV1ActionInvalidDataPartition InvalidDataPartition { get; set; }

        /// <summary>Detailed description of the issue requiring action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issue")]
        public virtual string Issue { get; set; }

        /// <summary>
        /// Output only. The relative resource name of the lake, of the form:
        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lake")]
        public virtual string Lake { get; set; }

        /// <summary>Details for issues related to absence of data within managed resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("missingData")]
        public virtual GoogleCloudDataplexV1ActionMissingData MissingData { get; set; }

        /// <summary>Details for issues related to absence of a managed resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("missingResource")]
        public virtual GoogleCloudDataplexV1ActionMissingResource MissingResource { get; set; }

        /// <summary>
        /// Output only. The relative resource name of the action, of the form:
        /// projects/{project}/locations/{location}/lakes/{lake}/actions/{action}
        /// projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/actions/{action}
        /// projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/assets/{asset}/actions/{action}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Details for issues related to lack of permissions to access data resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unauthorizedResource")]
        public virtual GoogleCloudDataplexV1ActionUnauthorizedResource UnauthorizedResource { get; set; }

        /// <summary>
        /// Output only. The relative resource name of the zone, of the form:
        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Failed to apply security policy to the managed resource(s) under a lake, zone or an asset. For a lake or zone
    /// resource, one or more underlying assets has a failure applying security policy to the associated managed
    /// resource.
    /// </summary>
    public class GoogleCloudDataplexV1ActionFailedSecurityPolicyApply : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Resource name of one of the assets with failing security policy application. Populated for a lake or zone
        /// resource only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public virtual string Asset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Action details for incompatible schemas detected by discovery.</summary>
    public class GoogleCloudDataplexV1ActionIncompatibleDataSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The existing and expected schema of the table. The schema is provided as a JSON formatted structure listing
        /// columns and data types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("existingSchema")]
        public virtual string ExistingSchema { get; set; }

        /// <summary>
        /// The new and incompatible schema within the table. The schema is provided as a JSON formatted structured
        /// listing columns and data types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newSchema")]
        public virtual string NewSchema { get; set; }

        /// <summary>The list of data locations sampled and used for format/schema inference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampledDataLocations")]
        public virtual System.Collections.Generic.IList<string> SampledDataLocations { get; set; }

        /// <summary>Whether the action relates to a schema that is incompatible or modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaChange")]
        public virtual string SchemaChange { get; set; }

        /// <summary>The name of the table containing invalid data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual string Table { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Action details for invalid or unsupported data files detected by discovery.</summary>
    public class GoogleCloudDataplexV1ActionInvalidDataFormat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The expected data format of the entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedFormat")]
        public virtual string ExpectedFormat { get; set; }

        /// <summary>The new unexpected data format within the entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newFormat")]
        public virtual string NewFormat { get; set; }

        /// <summary>The list of data locations sampled and used for format/schema inference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampledDataLocations")]
        public virtual System.Collections.Generic.IList<string> SampledDataLocations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Action details for invalid data arrangement.</summary>
    public class GoogleCloudDataplexV1ActionInvalidDataOrganization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Action details for invalid or unsupported partitions detected by discovery.</summary>
    public class GoogleCloudDataplexV1ActionInvalidDataPartition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The issue type of InvalidDataPartition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedStructure")]
        public virtual string ExpectedStructure { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Action details for absence of data detected by discovery.</summary>
    public class GoogleCloudDataplexV1ActionMissingData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Action details for resource references in assets that cannot be located.</summary>
    public class GoogleCloudDataplexV1ActionMissingResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Action details for unauthorized resource issues raised to indicate that the service account associated with the
    /// lake instance is not authorized to access or manage the resource associated with an asset.
    /// </summary>
    public class GoogleCloudDataplexV1ActionUnauthorizedResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An asset represents a cloud resource that is being managed within a lake as a member of a zone.
    /// </summary>
    public class GoogleCloudDataplexV1Asset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time when the asset was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Optional. Description of the asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Specification of the discovery feature applied to data referenced by this asset. When this spec is
        /// left unset, the asset will use the spec set on the parent zone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discoverySpec")]
        public virtual GoogleCloudDataplexV1AssetDiscoverySpec DiscoverySpec { get; set; }

        /// <summary>Output only. Status of the discovery feature applied to data referenced by this asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discoveryStatus")]
        public virtual GoogleCloudDataplexV1AssetDiscoveryStatus DiscoveryStatus { get; set; }

        /// <summary>Optional. User friendly display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. User defined labels for the asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. The relative resource name of the asset, of the form:
        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/assets/{asset_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Specification of the resource that is referenced by this asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceSpec")]
        public virtual GoogleCloudDataplexV1AssetResourceSpec ResourceSpec { get; set; }

        /// <summary>Output only. Status of the resource referenced by this asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceStatus")]
        public virtual GoogleCloudDataplexV1AssetResourceStatus ResourceStatus { get; set; }

        /// <summary>Output only. Status of the security policy applied to resource referenced by this asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityStatus")]
        public virtual GoogleCloudDataplexV1AssetSecurityStatus SecurityStatus { get; set; }

        /// <summary>Output only. Current state of the asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. System generated globally unique ID for the asset. This ID will be different if the asset is
        /// deleted and re-created with the same name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>Output only. The time when the asset was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings to manage the metadata discovery and publishing for an asset.</summary>
    public class GoogleCloudDataplexV1AssetDiscoverySpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Configuration for CSV data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("csvOptions")]
        public virtual GoogleCloudDataplexV1AssetDiscoverySpecCsvOptions CsvOptions { get; set; }

        /// <summary>Optional. Whether discovery is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>
        /// Optional. The list of patterns to apply for selecting data to exclude during discovery. For Cloud Storage
        /// bucket assets, these are interpreted as glob patterns used to match object names. For BigQuery dataset
        /// assets, these are interpreted as patterns to match table names.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludePatterns")]
        public virtual System.Collections.Generic.IList<string> ExcludePatterns { get; set; }

        /// <summary>
        /// Optional. The list of patterns to apply for selecting data to include during discovery if only a subset of
        /// the data should considered. For Cloud Storage bucket assets, these are interpreted as glob patterns used to
        /// match object names. For BigQuery dataset assets, these are interpreted as patterns to match table names.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includePatterns")]
        public virtual System.Collections.Generic.IList<string> IncludePatterns { get; set; }

        /// <summary>Optional. Configuration for Json data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonOptions")]
        public virtual GoogleCloudDataplexV1AssetDiscoverySpecJsonOptions JsonOptions { get; set; }

        /// <summary>
        /// Optional. Cron schedule (https://en.wikipedia.org/wiki/Cron) for running discovery periodically. Successive
        /// discovery runs must be scheduled at least 60 minutes apart. The default value is to run discovery every 60
        /// minutes. To explicitly set a timezone to the cron tab, apply a prefix in the cron tab:
        /// "CRON_TZ=${IANA_TIME_ZONE}" or TZ=${IANA_TIME_ZONE}". The ${IANA_TIME_ZONE} may only be a valid string from
        /// IANA time zone database. For example, "CRON_TZ=America/New_York 1 * * * *", or "TZ=America/New_York 1 * * *
        /// *".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedule")]
        public virtual string Schedule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describe CSV and similar semi-structured data formats.</summary>
    public class GoogleCloudDataplexV1AssetDiscoverySpecCsvOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The delimiter being used to separate values. This defaults to ','.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delimiter")]
        public virtual string Delimiter { get; set; }

        /// <summary>
        /// Optional. Whether to disable the inference of data type for CSV data. If true, all columns will be
        /// registered as strings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableTypeInference")]
        public virtual System.Nullable<bool> DisableTypeInference { get; set; }

        /// <summary>Optional. The character encoding of the data. The default is UTF-8.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        /// <summary>
        /// Optional. The number of rows to interpret as header rows that should be skipped when reading data rows.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headerRows")]
        public virtual System.Nullable<int> HeaderRows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describe JSON data format.</summary>
    public class GoogleCloudDataplexV1AssetDiscoverySpecJsonOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Whether to disable the inference of data type for Json data. If true, all columns will be
        /// registered as their primitive types (strings, number or boolean).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableTypeInference")]
        public virtual System.Nullable<bool> DisableTypeInference { get; set; }

        /// <summary>Optional. The character encoding of the data. The default is UTF-8.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Status of discovery for an asset.</summary>
    public class GoogleCloudDataplexV1AssetDiscoveryStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The duration of the last discovery run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastRunDuration")]
        public virtual object LastRunDuration { get; set; }

        /// <summary>The start time of the last discovery run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastRunTime")]
        public virtual object LastRunTime { get; set; }

        /// <summary>Additional information about the current state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The current status of the discovery feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Data Stats of the asset reported by discovery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stats")]
        public virtual GoogleCloudDataplexV1AssetDiscoveryStatusStats Stats { get; set; }

        /// <summary>Last update time of the status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The aggregated data statistics for the asset reported by discovery.</summary>
    public class GoogleCloudDataplexV1AssetDiscoveryStatusStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The count of data items within the referenced resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataItems")]
        public virtual System.Nullable<long> DataItems { get; set; }

        /// <summary>The number of stored data bytes within the referenced resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSize")]
        public virtual System.Nullable<long> DataSize { get; set; }

        /// <summary>The count of fileset entities within the referenced resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filesets")]
        public virtual System.Nullable<long> Filesets { get; set; }

        /// <summary>The count of table entities within the referenced resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tables")]
        public virtual System.Nullable<long> Tables { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identifies the cloud resource that is referenced by this asset.</summary>
    public class GoogleCloudDataplexV1AssetResourceSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Immutable. Relative name of the cloud resource that contains the data that is being managed within a lake.
        /// For example: projects/{project_number}/buckets/{bucket_id} projects/{project_number}/datasets/{dataset_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Immutable. Type of resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Status of the resource referenced by an asset.</summary>
    public class GoogleCloudDataplexV1AssetResourceStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional information about the current state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The current state of the managed resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Last update time of the status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Security policy status of the asset. Data security policy, i.e., readers, writers &amp;amp; owners, should be
    /// specified in the lake/zone/asset IAM policy.
    /// </summary>
    public class GoogleCloudDataplexV1AssetSecurityStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional information about the current state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The current state of the security policy applied to the attached resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Last update time of the status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Aggregated status of the underlying assets of a lake or zone.</summary>
    public class GoogleCloudDataplexV1AssetStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of active assets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeAssets")]
        public virtual System.Nullable<int> ActiveAssets { get; set; }

        /// <summary>
        /// Number of assets that are in process of updating the security policy on attached resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityPolicyApplyingAssets")]
        public virtual System.Nullable<int> SecurityPolicyApplyingAssets { get; set; }

        /// <summary>Last update time of the status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cancel task jobs.</summary>
    public class GoogleCloudDataplexV1CancelJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Content represents a user-visible notebook or a sql script</summary>
    public class GoogleCloudDataplexV1Content : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Content creation time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Required. Content data in string format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataText")]
        public virtual string DataText { get; set; }

        /// <summary>Optional. Description of the content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. User defined labels for the content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. The relative resource name of the content, of the form:
        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/content/{content_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Notebook related configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notebook")]
        public virtual GoogleCloudDataplexV1ContentNotebook Notebook { get; set; }

        /// <summary>
        /// Required. The path for the Content file, represented as directory structure. Unique within a lake. Limited
        /// to alphanumerics, hyphens, underscores, dots and slashes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>Sql Script related configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlScript")]
        public virtual GoogleCloudDataplexV1ContentSqlScript SqlScript { get; set; }

        /// <summary>
        /// Output only. System generated globally unique ID for the content. This ID will be different if the content
        /// is deleted and re-created with the same name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>Output only. The time when the content was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for Notebook content.</summary>
    public class GoogleCloudDataplexV1ContentNotebook : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Kernel Type of the notebook.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kernelType")]
        public virtual string KernelType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for the Sql Script content.</summary>
    public class GoogleCloudDataplexV1ContentSqlScript : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Query Engine to be used for the Sql Query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("engine")]
        public virtual string Engine { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The payload associated with Discovery data processing.</summary>
    public class GoogleCloudDataplexV1DiscoveryEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Details about the action associated with the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual GoogleCloudDataplexV1DiscoveryEventActionDetails Action { get; set; }

        /// <summary>The id of the associated asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetId")]
        public virtual string AssetId { get; set; }

        /// <summary>Details about discovery configuration in effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual GoogleCloudDataplexV1DiscoveryEventConfigDetails Config { get; set; }

        /// <summary>The data location associated with the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataLocation")]
        public virtual string DataLocation { get; set; }

        /// <summary>Details about the entity associated with the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual GoogleCloudDataplexV1DiscoveryEventEntityDetails Entity { get; set; }

        /// <summary>The id of the associated lake.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lakeId")]
        public virtual string LakeId { get; set; }

        /// <summary>The log message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Details about the partition associated with the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partition")]
        public virtual GoogleCloudDataplexV1DiscoveryEventPartitionDetails Partition { get; set; }

        /// <summary>The type of the event being logged.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The id of the associated zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zoneId")]
        public virtual string ZoneId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about the action.</summary>
    public class GoogleCloudDataplexV1DiscoveryEventActionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of action. Eg. IncompatibleDataSchema, InvalidDataFormat</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about configuration events.</summary>
    public class GoogleCloudDataplexV1DiscoveryEventConfigDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of discovery configuration parameters in effect. The keys are the field paths within DiscoverySpec.
        /// Eg. includePatterns, excludePatterns, csvOptions.disableTypeInference, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string, string> Parameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about the entity.</summary>
    public class GoogleCloudDataplexV1DiscoveryEventEntityDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the entity resource. The name is the fully-qualified resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual string Entity { get; set; }

        /// <summary>The type of the entity resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about the partition.</summary>
    public class GoogleCloudDataplexV1DiscoveryEventPartitionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name to the containing entity resource. The name is the fully-qualified resource name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual string Entity { get; set; }

        /// <summary>The name to the partition resource. The name is the fully-qualified resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partition")]
        public virtual string Partition { get; set; }

        /// <summary>The type of the containing entity resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents tables and fileset metadata contained within a zone.</summary>
    public class GoogleCloudDataplexV1Entity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. The ID of the asset associated with the storage location containing the entity data.
        /// The entity must be with in the same zone with the asset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public virtual string Asset { get; set; }

        /// <summary>Output only. The name of the associated Data Catalog entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("catalogEntry")]
        public virtual string CatalogEntry { get; set; }

        /// <summary>Output only. Metadata stores that the entity is compatible with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compatibility")]
        public virtual GoogleCloudDataplexV1EntityCompatibilityStatus Compatibility { get; set; }

        /// <summary>Output only. The time when the entity was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Required. Immutable. The storage path of the entity data. For Cloud Storage data, this is the
        /// fully-qualified path to the entity, such as gs://bucket/path/to/data. For BigQuery data, this is the name of
        /// the table resource, such as projects/project_id/datasets/dataset_id/tables/table_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataPath")]
        public virtual string DataPath { get; set; }

        /// <summary>
        /// Optional. The set of items within the data path constituting the data in the entity, represented as a glob
        /// path. Example: gs://bucket/path/to/data/**/*.csv.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataPathPattern")]
        public virtual string DataPathPattern { get; set; }

        /// <summary>
        /// Optional. User friendly longer description text. Must be shorter than or equal to 1024 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. Display name must be shorter than or equal to 256 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Optional. The etag associated with the entity, which can be retrieved with a GetEntity request. Required for
        /// update and delete requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Required. Identifies the storage format of the entity data. It does not apply to entities with data stored
        /// in BigQuery.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual GoogleCloudDataplexV1StorageFormat Format { get; set; }

        /// <summary>
        /// Required. A user-provided entity ID. It is mutable, and will be used as the published table name. Specifying
        /// a new ID in an update entity request will override the existing value. The ID must contain only letters
        /// (a-z, A-Z), numbers (0-9), and underscores. Must begin with a letter and consist of 256 or fewer characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Output only. The resource name of the entity, of the form:
        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The description of the data structure and layout. The schema is not included in list responses. It
        /// is only included in SCHEMA and FULL entity views of a GetEntity response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual GoogleCloudDataplexV1Schema Schema { get; set; }

        /// <summary>Required. Immutable. Identifies the storage system of the entity data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("system")]
        public virtual string System { get; set; }

        /// <summary>Required. Immutable. The type of entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Output only. The time when the entity was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }
    }

    /// <summary>Provides compatibility information for various metadata stores.</summary>
    public class GoogleCloudDataplexV1EntityCompatibilityStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Whether this entity is compatible with BigQuery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigquery")]
        public virtual GoogleCloudDataplexV1EntityCompatibilityStatusCompatibility Bigquery { get; set; }

        /// <summary>Output only. Whether this entity is compatible with Hive Metastore.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hiveMetastore")]
        public virtual GoogleCloudDataplexV1EntityCompatibilityStatusCompatibility HiveMetastore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Provides compatibility information for a specific metadata store.</summary>
    public class GoogleCloudDataplexV1EntityCompatibilityStatusCompatibility : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Whether the entity is compatible and can be represented in the metadata store.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compatible")]
        public virtual System.Nullable<bool> Compatible { get; set; }

        /// <summary>
        /// Output only. Provides additional detail if the entity is incompatible with the metadata store.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Environment represents a user-visible compute infrastructure for analytics within a lake.</summary>
    public class GoogleCloudDataplexV1Environment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Environment creation time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Optional. Description of the environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. User friendly display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. URI Endpoints to access sessions associated with the Environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoints")]
        public virtual GoogleCloudDataplexV1EnvironmentEndpoints Endpoints { get; set; }

        /// <summary>Required. Infrastructure specification for the Environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infrastructureSpec")]
        public virtual GoogleCloudDataplexV1EnvironmentInfrastructureSpec InfrastructureSpec { get; set; }

        /// <summary>Optional. User defined labels for the environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. The relative resource name of the environment, of the form:
        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/environment/{environment_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Configuration for sessions created for this environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionSpec")]
        public virtual GoogleCloudDataplexV1EnvironmentSessionSpec SessionSpec { get; set; }

        /// <summary>Output only. Status of sessions created for this environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionStatus")]
        public virtual GoogleCloudDataplexV1EnvironmentSessionStatus SessionStatus { get; set; }

        /// <summary>Output only. Current state of the environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. System generated globally unique ID for the environment. This ID will be different if the
        /// environment is deleted and re-created with the same name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>Output only. The time when the environment was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDataplexV1EnvironmentEndpoints : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. URI to serve notebook APIs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notebooks")]
        public virtual string Notebooks { get; set; }

        /// <summary>Output only. URI to serve SQL APIs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sql")]
        public virtual string Sql { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for the underlying infrastructure used to run workloads.</summary>
    public class GoogleCloudDataplexV1EnvironmentInfrastructureSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Compute resources needed for analyze interactive workloads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compute")]
        public virtual GoogleCloudDataplexV1EnvironmentInfrastructureSpecComputeResources Compute { get; set; }

        /// <summary>Required. Software Runtime Configuration for analyze interactive workloads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osImage")]
        public virtual GoogleCloudDataplexV1EnvironmentInfrastructureSpecOsImageRuntime OsImage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Compute resources associated with the analyze interactive workloads.</summary>
    public class GoogleCloudDataplexV1EnvironmentInfrastructureSpecComputeResources : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Size in GB of the disk. Default is 100 GB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskSizeGb")]
        public virtual System.Nullable<int> DiskSizeGb { get; set; }

        /// <summary>
        /// Optional. Max configurable nodes. If max_node_count &amp;gt; node_count, then auto-scaling is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxNodeCount")]
        public virtual System.Nullable<int> MaxNodeCount { get; set; }

        /// <summary>Optional. Total number of nodes in the sessions created for this environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeCount")]
        public virtual System.Nullable<int> NodeCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Software Runtime Configuration to run Analyze.</summary>
    public class GoogleCloudDataplexV1EnvironmentInfrastructureSpecOsImageRuntime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Dataplex Image version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageVersion")]
        public virtual string ImageVersion { get; set; }

        /// <summary>
        /// Optional. List of Java jars to be included in the runtime environment. Valid input includes Cloud Storage
        /// URIs to Jar binaries. For example, gs://bucket-name/my/path/to/file.jar
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("javaLibraries")]
        public virtual System.Collections.Generic.IList<string> JavaLibraries { get; set; }

        /// <summary>
        /// Optional. Spark properties to provide configuration for use in sessions created for this environment. The
        /// properties to set on daemon config files. Property keys are specified in prefix:property format. The prefix
        /// must be "spark".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Optional. A list of python packages to be installed. Valid formats include Cloud Storage URI to a PIP
        /// installable library. For example, gs://bucket-name/my/path/to/lib.tar.gz
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pythonPackages")]
        public virtual System.Collections.Generic.IList<string> PythonPackages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDataplexV1EnvironmentSessionSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If True, this causes sessions to be pre-created and available for faster startup to enable
        /// interactive exploration use-cases. This defaults to False to avoid additional billed charges. These can only
        /// be set to True for the environment with name set to "default", and with default configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableFastStartup")]
        public virtual System.Nullable<bool> EnableFastStartup { get; set; }

        /// <summary>
        /// Optional. The idle time configuration of the session. The session will be auto-terminated at the end of this
        /// period.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxIdleDuration")]
        public virtual object MaxIdleDuration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDataplexV1EnvironmentSessionStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Queries over sessions to mark whether the environment is currently active or not
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("active")]
        public virtual System.Nullable<bool> Active { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A job represents an instance of a task.</summary>
    public class GoogleCloudDataplexV1Job : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time when the job ended.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Output only. Additional information about the current state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>
        /// Output only. The relative resource name of the job, of the form:
        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/ tasks/{task_id}/jobs/{job_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. . The number of times the job has been retried (excluding the initial attempt).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retryCount")]
        public virtual System.Nullable<long> RetryCount { get; set; }

        /// <summary>Output only. The underlying service running a job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>Output only. The full resource name for the job run under a particular service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceJob")]
        public virtual string ServiceJob { get; set; }

        /// <summary>Output only. The time when the job was started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>Output only. Execution state for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. System generated globally unique ID for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The payload associated with Job logs that contains events describing jobs that have run within a Lake.
    /// </summary>
    public class GoogleCloudDataplexV1JobEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time when the job ended running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The unique id identifying the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobId")]
        public virtual string JobId { get; set; }

        /// <summary>The log message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The number of retries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retries")]
        public virtual System.Nullable<int> Retries { get; set; }

        /// <summary>The service used to execute the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The reference to the job within the service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceJob")]
        public virtual string ServiceJob { get; set; }

        /// <summary>The time when the job started running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The job state on completion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The type of the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A lake is a centralized repository for managing enterprise data across the organization distributed across many
    /// cloud projects, and stored in a variety of storage services such as Google Cloud Storage and BigQuery. The
    /// resources attached to a lake are referred to as managed resources. Data within these managed resources can be
    /// structured or unstructured. A lake provides data admins with tools to organize, secure and manage their data at
    /// scale, and provides data scientists and data engineers an integrated experience to easily search, discover,
    /// analyze and transform data and associated metadata.
    /// </summary>
    public class GoogleCloudDataplexV1Lake : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Aggregated status of the underlying assets of the lake.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetStatus")]
        public virtual GoogleCloudDataplexV1AssetStatus AssetStatus { get; set; }

        /// <summary>Output only. The time when the lake was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Optional. Description of the lake.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. User friendly display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. User-defined labels for the lake.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Optional. Settings to manage lake and Dataproc Metastore service instance association.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metastore")]
        public virtual GoogleCloudDataplexV1LakeMetastore Metastore { get; set; }

        /// <summary>Output only. Metastore status of the lake.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metastoreStatus")]
        public virtual GoogleCloudDataplexV1LakeMetastoreStatus MetastoreStatus { get; set; }

        /// <summary>
        /// Output only. The relative resource name of the lake, of the form:
        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Service account associated with this lake. This service account must be authorized to access or
        /// operate on resources managed by the lake.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Output only. Current state of the lake.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. System generated globally unique ID for the lake. This ID will be different if the lake is
        /// deleted and re-created with the same name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>Output only. The time when the lake was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings to manage association of Dataproc Metastore with a lake.</summary>
    public class GoogleCloudDataplexV1LakeMetastore : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A relative reference to the Dataproc Metastore (https://cloud.google.com/dataproc-metastore/docs)
        /// service associated with the lake: projects/{project_id}/locations/{location_id}/services/{service_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Status of Lake and Dataproc Metastore service instance association.</summary>
    public class GoogleCloudDataplexV1LakeMetastoreStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URI of the endpoint used to access the Metastore service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual string Endpoint { get; set; }

        /// <summary>Additional information about the current status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Current state of association.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Last update time of the metastore status of the lake.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List actions response.</summary>
    public class GoogleCloudDataplexV1ListActionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Actions under the given parent lake/zone/asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actions")]
        public virtual System.Collections.Generic.IList<GoogleCloudDataplexV1Action> Actions { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List assets response.</summary>
    public class GoogleCloudDataplexV1ListAssetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Asset under the given parent zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assets")]
        public virtual System.Collections.Generic.IList<GoogleCloudDataplexV1Asset> Assets { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List content response.</summary>
    public class GoogleCloudDataplexV1ListContentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Content under the given parent lake.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual System.Collections.Generic.IList<GoogleCloudDataplexV1Content> Content { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List metadata entities response.</summary>
    public class GoogleCloudDataplexV1ListEntitiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Entities in the specified parent zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entities")]
        public virtual System.Collections.Generic.IList<GoogleCloudDataplexV1Entity> Entities { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no remaining results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List environments response.</summary>
    public class GoogleCloudDataplexV1ListEnvironmentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Environments under the given parent lake.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environments")]
        public virtual System.Collections.Generic.IList<GoogleCloudDataplexV1Environment> Environments { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List jobs response.</summary>
    public class GoogleCloudDataplexV1ListJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Jobs under a given task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobs")]
        public virtual System.Collections.Generic.IList<GoogleCloudDataplexV1Job> Jobs { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List lakes response.</summary>
    public class GoogleCloudDataplexV1ListLakesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Lakes under the given parent location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lakes")]
        public virtual System.Collections.Generic.IList<GoogleCloudDataplexV1Lake> Lakes { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachableLocations")]
        public virtual System.Collections.Generic.IList<string> UnreachableLocations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List metadata partitions response.</summary>
    public class GoogleCloudDataplexV1ListPartitionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no remaining results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Partitions under the specified parent entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitions")]
        public virtual System.Collections.Generic.IList<GoogleCloudDataplexV1Partition> Partitions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List sessions response.</summary>
    public class GoogleCloudDataplexV1ListSessionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Sessions under a given environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessions")]
        public virtual System.Collections.Generic.IList<GoogleCloudDataplexV1Session> Sessions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List tasks response.</summary>
    public class GoogleCloudDataplexV1ListTasksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Tasks under the given parent lake.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tasks")]
        public virtual System.Collections.Generic.IList<GoogleCloudDataplexV1Task> Tasks { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachableLocations")]
        public virtual System.Collections.Generic.IList<string> UnreachableLocations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List zones response.</summary>
    public class GoogleCloudDataplexV1ListZonesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Zones under the given parent lake.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zones")]
        public virtual System.Collections.Generic.IList<GoogleCloudDataplexV1Zone> Zones { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the metadata of a long-running operation.</summary>
    public class GoogleCloudDataplexV1OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
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
        /// Code.CANCELLED.
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

    /// <summary>Represents partition metadata contained within entity instances.</summary>
    public class GoogleCloudDataplexV1Partition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The etag for this partition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Required. Immutable. The location of the entity data within the partition, for example,
        /// gs://bucket/path/to/entity/key1=value1/key2=value2. Or projects//datasets//tables/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// Output only. Partition values used in the HTTP URL must be double encoded. For example,
        /// url_encode(url_encode(value)) can be used to encode "US:CA/CA#Sunnyvale so that the request URL ends with
        /// "/partitions/US%253ACA/CA%2523Sunnyvale". The name field in the response retains the encoded format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Immutable. The set of values representing the partition, which correspond to the partition schema
        /// defined in the parent entity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }
    }

    /// <summary>Schema information describing the structure and layout of the data.</summary>
    public class GoogleCloudDataplexV1Schema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The sequence of fields describing data in table entities. Note: BigQuery SchemaFields are
        /// immutable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<GoogleCloudDataplexV1SchemaSchemaField> Fields { get; set; }

        /// <summary>
        /// Optional. The sequence of fields describing the partition structure in entities. If this field is empty,
        /// there are no partitions within the data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionFields")]
        public virtual System.Collections.Generic.IList<GoogleCloudDataplexV1SchemaPartitionField> PartitionFields { get; set; }

        /// <summary>Optional. The structure of paths containing partition data within the entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionStyle")]
        public virtual string PartitionStyle { get; set; }

        /// <summary>
        /// Required. Set to true if user-managed or false if managed by Dataplex. The default is false (managed by
        /// Dataplex). Set to falseto enable Dataplex discovery to update the schema. including new data discovery,
        /// schema inference, and schema evolution. Users retain the ability to input and edit the schema. Dataplex
        /// treats schema input by the user as though produced by a previous Dataplex discovery operation, and it will
        /// evolve the schema and take action based on that treatment. Set to true to fully manage the entity schema.
        /// This setting guarantees that Dataplex will not change schema fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userManaged")]
        public virtual System.Nullable<bool> UserManaged { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a key field within the entity's partition structure. You could have up to 20 partition fields, but
    /// only the first 10 partitions have the filtering ability due to performance consideration. Note: Partition fields
    /// are immutable.
    /// </summary>
    public class GoogleCloudDataplexV1SchemaPartitionField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Partition field name must consist of letters, numbers, and underscores only, with a maximum of
        /// length of 256 characters, and must begin with a letter or underscore..
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Immutable. The type of field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a column field within a table schema.</summary>
    public class GoogleCloudDataplexV1SchemaSchemaField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. User friendly field description. Must be less than or equal to 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. Any nested field for complex types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<GoogleCloudDataplexV1SchemaSchemaField> Fields { get; set; }

        /// <summary>Required. Additional field semantics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>
        /// Required. The name of the field. Must contain only letters, numbers and underscores, with a maximum length
        /// of 767 characters, and must begin with a letter or underscore.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The type of field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an active analyze session running for a user.</summary>
    public class GoogleCloudDataplexV1Session : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Session start time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Output only. The relative resource name of the content, of the form:
        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/environment/{environment_id}/sessions/{session_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Email of user running the session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// These messages contain information about sessions within an environment. The monitored resource is
    /// 'Environment'.
    /// </summary>
    public class GoogleCloudDataplexV1SessionEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The log message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The execution details of the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual GoogleCloudDataplexV1SessionEventQueryDetail Query { get; set; }

        /// <summary>Unique identifier for the session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionId")]
        public virtual string SessionId { get; set; }

        /// <summary>The type of the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The information about the user that created the session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Execution details of the query.</summary>
    public class GoogleCloudDataplexV1SessionEventQueryDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The data processed by the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataProcessedBytes")]
        public virtual System.Nullable<long> DataProcessedBytes { get; set; }

        /// <summary>Time taken for execution of the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>Query Execution engine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("engine")]
        public virtual string Engine { get; set; }

        /// <summary>The unique Query id identifying the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryId")]
        public virtual string QueryId { get; set; }

        /// <summary>The query text executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryText")]
        public virtual string QueryText { get; set; }

        /// <summary>The size of results the query produced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultSizeBytes")]
        public virtual System.Nullable<long> ResultSizeBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the format of the data within its storage location.</summary>
    public class GoogleCloudDataplexV1StorageFormat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The compression type associated with the stored data. If unspecified, the data is uncompressed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compressionFormat")]
        public virtual string CompressionFormat { get; set; }

        /// <summary>Optional. Additional information about CSV formatted data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("csv")]
        public virtual GoogleCloudDataplexV1StorageFormatCsvOptions Csv { get; set; }

        /// <summary>
        /// Output only. The data format associated with the stored data, which represents content type values. The
        /// value is inferred from mime type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>Optional. Additional information about CSV formatted data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("json")]
        public virtual GoogleCloudDataplexV1StorageFormatJsonOptions Json { get; set; }

        /// <summary>
        /// Required. The mime type descriptor for the data. Must match the pattern {type}/{subtype}. Supported values:
        /// application/x-parquet application/x-avro application/x-orc application/x-tfrecord application/json
        /// application/{subtypes} text/csv text/ image/{image subtype} video/{video subtype} audio/{audio subtype}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes CSV and similar semi-structured data formats.</summary>
    public class GoogleCloudDataplexV1StorageFormatCsvOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The delimiter used to separate values. Defaults to ','.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delimiter")]
        public virtual string Delimiter { get; set; }

        /// <summary>
        /// Optional. The character encoding of the data. Accepts "US-ASCII", "UTF-8", and "ISO-8859-1". Defaults to
        /// UTF-8 if unspecified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        /// <summary>
        /// Optional. The number of rows to interpret as header rows that should be skipped when reading data rows.
        /// Defaults to 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headerRows")]
        public virtual System.Nullable<int> HeaderRows { get; set; }

        /// <summary>
        /// Optional. The character used to quote column values. Accepts '"' (double quotation mark) or ''' (single
        /// quotation mark). Defaults to '"' (double quotation mark) if unspecified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quote")]
        public virtual string Quote { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes JSON data format.</summary>
    public class GoogleCloudDataplexV1StorageFormatJsonOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The character encoding of the data. Accepts "US-ASCII", "UTF-8" and "ISO-8859-1". Defaults to
        /// UTF-8 if not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A task represents a user-visible job.</summary>
    public class GoogleCloudDataplexV1Task : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time when the task was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Optional. Description of the task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. User friendly display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Required. Spec related to how a task is executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionSpec")]
        public virtual GoogleCloudDataplexV1TaskExecutionSpec ExecutionSpec { get; set; }

        /// <summary>Optional. User-defined labels for the task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. The relative resource name of the task, of the form:
        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/ tasks/{task_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Config related to running custom Spark tasks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spark")]
        public virtual GoogleCloudDataplexV1TaskSparkTaskConfig Spark { get; set; }

        /// <summary>Output only. Current state of the task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Required. Spec related to how often and when a task should be triggered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerSpec")]
        public virtual GoogleCloudDataplexV1TaskTriggerSpec TriggerSpec { get; set; }

        /// <summary>
        /// Output only. System generated globally unique ID for the task. This ID will be different if the task is
        /// deleted and re-created with the same name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>Output only. The time when the task was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Execution related settings, like retry and service_account.</summary>
    public class GoogleCloudDataplexV1TaskExecutionSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The arguments to pass to the task. The args can use placeholders of the format ${placeholder} as
        /// part of key/value string. These will be interpolated before passing the args to the driver. Currently
        /// supported placeholders: - ${task_id} - ${job_time} To pass positional args, set the key as TASK_ARGS. The
        /// value should be a comma-separated string of all the positional arguments. To use a delimiter other than
        /// comma, refer to https://cloud.google.com/sdk/gcloud/reference/topic/escaping. In case of other keys being
        /// present in the args, then TASK_ARGS will be passed as the last argument.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IDictionary<string, string> Args { get; set; }

        /// <summary>Optional. The maximum duration after which the job execution is expired.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxJobExecutionLifetime")]
        public virtual object MaxJobExecutionLifetime { get; set; }

        /// <summary>
        /// Required. Service account to use to execute a task. If not provided, the default Compute service account for
        /// the project is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for the underlying infrastructure used to run workloads.</summary>
    public class GoogleCloudDataplexV1TaskInfrastructureSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Compute resources needed for a Task when using Dataproc Serverless.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batch")]
        public virtual GoogleCloudDataplexV1TaskInfrastructureSpecBatchComputeResources Batch { get; set; }

        /// <summary>Container Image Runtime Configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerImage")]
        public virtual GoogleCloudDataplexV1TaskInfrastructureSpecContainerImageRuntime ContainerImage { get; set; }

        /// <summary>Vpc network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcNetwork")]
        public virtual GoogleCloudDataplexV1TaskInfrastructureSpecVpcNetwork VpcNetwork { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Batch compute resources associated with the task.</summary>
    public class GoogleCloudDataplexV1TaskInfrastructureSpecBatchComputeResources : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Total number of job executors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executorsCount")]
        public virtual System.Nullable<int> ExecutorsCount { get; set; }

        /// <summary>
        /// Optional. Max configurable executors. If max_executors_count &amp;gt; executors_count, then auto-scaling is
        /// enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxExecutorsCount")]
        public virtual System.Nullable<int> MaxExecutorsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Container Image Runtime Configuration used with Batch execution.</summary>
    public class GoogleCloudDataplexV1TaskInfrastructureSpecContainerImageRuntime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A list of Java JARS to add to the classpath. Valid input includes Cloud Storage URIs to Jar
        /// binaries. For example, gs://bucket-name/my/path/to/file.jar
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("javaJars")]
        public virtual System.Collections.Generic.IList<string> JavaJars { get; set; }

        /// <summary>
        /// Optional. Override to common configuration of open source components installed on the Dataproc cluster. The
        /// properties to set on daemon config files. Property keys are specified in prefix:property format, for example
        /// core:hadoop.tmp.dir. For more information, see Cluster properties
        /// (https://cloud.google.com/dataproc/docs/concepts/cluster-properties).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Optional. A list of python packages to be installed. Valid formats include Cloud Storage URI to a PIP
        /// installable library. For example, gs://bucket-name/my/path/to/lib.tar.gz
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pythonPackages")]
        public virtual System.Collections.Generic.IList<string> PythonPackages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cloud VPC Network used to run the infrastructure.</summary>
    public class GoogleCloudDataplexV1TaskInfrastructureSpecVpcNetwork : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The Cloud VPC network in which the job is run. By default, the Cloud VPC network named Default
        /// within the project is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>Optional. List of network tags to apply to the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkTags")]
        public virtual System.Collections.Generic.IList<string> NetworkTags { get; set; }

        /// <summary>Optional. The Cloud VPC sub-network in which the job is run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subNetwork")]
        public virtual string SubNetwork { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>User-specified config for running a Spark task.</summary>
    public class GoogleCloudDataplexV1TaskSparkTaskConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Cloud Storage URIs of archives to be extracted into the working directory of each executor.
        /// Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("archiveUris")]
        public virtual System.Collections.Generic.IList<string> ArchiveUris { get; set; }

        /// <summary>
        /// Optional. Cloud Storage URIs of files to be placed in the working directory of each executor.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileUris")]
        public virtual System.Collections.Generic.IList<string> FileUris { get; set; }

        /// <summary>Optional. Infrastructure specification for the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infrastructureSpec")]
        public virtual GoogleCloudDataplexV1TaskInfrastructureSpec InfrastructureSpec { get; set; }

        /// <summary>
        /// The name of the driver's main class. The jar file that contains the class must be in the default CLASSPATH
        /// or specified in jar_file_uris. The execution args are passed in as a sequence of named process arguments
        /// (--key=value).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mainClass")]
        public virtual string MainClass { get; set; }

        /// <summary>
        /// The Cloud Storage URI of the jar file that contains the main class. The execution args are passed in as a
        /// sequence of named process arguments (--key=value).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mainJarFileUri")]
        public virtual string MainJarFileUri { get; set; }

        /// <summary>
        /// The Gcloud Storage URI of the main Python file to use as the driver. Must be a .py file. The execution args
        /// are passed in as a sequence of named process arguments (--key=value).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pythonScriptFile")]
        public virtual string PythonScriptFile { get; set; }

        /// <summary>
        /// The query text. The execution args are used to declare a set of script variables (set key="value";).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlScript")]
        public virtual string SqlScript { get; set; }

        /// <summary>
        /// A reference to a query file. This can be the Cloud Storage URI of the query file or it can the path to a
        /// SqlScript Content. The execution args are used to declare a set of script variables (set key="value";).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlScriptFile")]
        public virtual string SqlScriptFile { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Task scheduling and trigger settings.</summary>
    public class GoogleCloudDataplexV1TaskTriggerSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Prevent the task from executing. This does not cancel already running tasks. It is intended to
        /// temporarily disable RECURRING tasks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>
        /// Optional. Number of retry attempts before aborting. Set to zero to never attempt to retry a failed task.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxRetries")]
        public virtual System.Nullable<int> MaxRetries { get; set; }

        /// <summary>
        /// Optional. Cron schedule (https://en.wikipedia.org/wiki/Cron) for running tasks periodically. To explicitly
        /// set a timezone to the cron tab, apply a prefix in the cron tab: "CRON_TZ=${IANA_TIME_ZONE}" or
        /// "TZ=${IANA_TIME_ZONE}". The ${IANA_TIME_ZONE} may only be a valid string from IANA time zone database. For
        /// example, "CRON_TZ=America/New_York 1 * * * *", or "TZ=America/New_York 1 * * * *". This field is required
        /// for RECURRING tasks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedule")]
        public virtual string Schedule { get; set; }

        /// <summary>
        /// Optional. The first run of the task will be after this time. If not specified, the task will run shortly
        /// after being submitted if ON_DEMAND and based on the schedule if RECURRING.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>Required. Immutable. Trigger type of the user-specified Task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A zone represents a logical group of related assets within a lake. A zone can be used to map to organizational
    /// structure or represent stages of data readiness from raw to curated. It provides managing behavior that is
    /// shared or inherited by all contained assets.
    /// </summary>
    public class GoogleCloudDataplexV1Zone : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Aggregated status of the underlying assets of the zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetStatus")]
        public virtual GoogleCloudDataplexV1AssetStatus AssetStatus { get; set; }

        /// <summary>Output only. The time when the zone was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Optional. Description of the zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. Specification of the discovery feature applied to data in this zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discoverySpec")]
        public virtual GoogleCloudDataplexV1ZoneDiscoverySpec DiscoverySpec { get; set; }

        /// <summary>Optional. User friendly display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. User defined labels for the zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. The relative resource name of the zone, of the form:
        /// projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Specification of the resources that are referenced by the assets within this zone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceSpec")]
        public virtual GoogleCloudDataplexV1ZoneResourceSpec ResourceSpec { get; set; }

        /// <summary>Output only. Current state of the zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Required. Immutable. The type of the zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// Output only. System generated globally unique ID for the zone. This ID will be different if the zone is
        /// deleted and re-created with the same name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>Output only. The time when the zone was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings to manage the metadata discovery and publishing in a zone.</summary>
    public class GoogleCloudDataplexV1ZoneDiscoverySpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Configuration for CSV data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("csvOptions")]
        public virtual GoogleCloudDataplexV1ZoneDiscoverySpecCsvOptions CsvOptions { get; set; }

        /// <summary>Required. Whether discovery is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>
        /// Optional. The list of patterns to apply for selecting data to exclude during discovery. For Cloud Storage
        /// bucket assets, these are interpreted as glob patterns used to match object names. For BigQuery dataset
        /// assets, these are interpreted as patterns to match table names.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludePatterns")]
        public virtual System.Collections.Generic.IList<string> ExcludePatterns { get; set; }

        /// <summary>
        /// Optional. The list of patterns to apply for selecting data to include during discovery if only a subset of
        /// the data should considered. For Cloud Storage bucket assets, these are interpreted as glob patterns used to
        /// match object names. For BigQuery dataset assets, these are interpreted as patterns to match table names.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includePatterns")]
        public virtual System.Collections.Generic.IList<string> IncludePatterns { get; set; }

        /// <summary>Optional. Configuration for Json data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonOptions")]
        public virtual GoogleCloudDataplexV1ZoneDiscoverySpecJsonOptions JsonOptions { get; set; }

        /// <summary>
        /// Optional. Cron schedule (https://en.wikipedia.org/wiki/Cron) for running discovery periodically. Successive
        /// discovery runs must be scheduled at least 60 minutes apart. The default value is to run discovery every 60
        /// minutes. To explicitly set a timezone to the cron tab, apply a prefix in the cron tab:
        /// "CRON_TZ=${IANA_TIME_ZONE}" or TZ=${IANA_TIME_ZONE}". The ${IANA_TIME_ZONE} may only be a valid string from
        /// IANA time zone database. For example, "CRON_TZ=America/New_York 1 * * * *", or "TZ=America/New_York 1 * * *
        /// *".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedule")]
        public virtual string Schedule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describe CSV and similar semi-structured data formats.</summary>
    public class GoogleCloudDataplexV1ZoneDiscoverySpecCsvOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The delimiter being used to separate values. This defaults to ','.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delimiter")]
        public virtual string Delimiter { get; set; }

        /// <summary>
        /// Optional. Whether to disable the inference of data type for CSV data. If true, all columns will be
        /// registered as strings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableTypeInference")]
        public virtual System.Nullable<bool> DisableTypeInference { get; set; }

        /// <summary>Optional. The character encoding of the data. The default is UTF-8.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        /// <summary>
        /// Optional. The number of rows to interpret as header rows that should be skipped when reading data rows.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headerRows")]
        public virtual System.Nullable<int> HeaderRows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describe JSON data format.</summary>
    public class GoogleCloudDataplexV1ZoneDiscoverySpecJsonOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Whether to disable the inference of data type for Json data. If true, all columns will be
        /// registered as their primitive types (strings, number or boolean).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableTypeInference")]
        public virtual System.Nullable<bool> DisableTypeInference { get; set; }

        /// <summary>Optional. The character encoding of the data. The default is UTF-8.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings for resources attached as assets within a zone.</summary>
    public class GoogleCloudDataplexV1ZoneResourceSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. The location type of the resources that are allowed to be attached to the assets within
        /// this zone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationType")]
        public virtual string LocationType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Locations.ListLocations.</summary>
    public class GoogleCloudLocationListLocationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of locations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<GoogleCloudLocationLocation> Locations { get; set; }

        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that represents Google Cloud Platform location.</summary>
    public class GoogleCloudLocationLocation : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleIamV1AuditConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for logging of each type of permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLogConfigs")]
        public virtual System.Collections.Generic.IList<GoogleIamV1AuditLogConfig> AuditLogConfigs { get; set; }

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
    public class GoogleIamV1AuditLogConfig : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Associates members, or principals, with a role.</summary>
    public class GoogleIamV1Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding.If the condition evaluates to true, then this binding
        /// applies to the current request.If the condition evaluates to false, then this binding does not apply to the
        /// current request. However, a different role binding might grant the same role to one or more of the
        /// principals in this binding.To learn which resources support conditions in their IAM policies, see the IAM
        /// documentation (https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual GoogleTypeExpr Condition { get; set; }

        /// <summary>
        /// Specifies the principals requesting access for a Cloud Platform resource. members can have the following
        /// values: allUsers: A special identifier that represents anyone who is on the internet; with or without a
        /// Google account. allAuthenticatedUsers: A special identifier that represents anyone who is authenticated with
        /// a Google account or a service account. user:{emailid}: An email address that represents a specific Google
        /// account. For example, alice@example.com . serviceAccount:{emailid}: An email address that represents a
        /// service account. For example, my-other-app@appspot.gserviceaccount.com. group:{emailid}: An email address
        /// that represents a Google group. For example, admins@example.com. deleted:user:{emailid}?uid={uniqueid}: An
        /// email address (plus unique identifier) representing a user that has been recently deleted. For example,
        /// alice@example.com?uid=123456789012345678901. If the user is recovered, this value reverts to user:{emailid}
        /// and the recovered user retains the role in the binding. deleted:serviceAccount:{emailid}?uid={uniqueid}: An
        /// email address (plus unique identifier) representing a service account that has been recently deleted. For
        /// example, my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901. If the service account is
        /// undeleted, this value reverts to serviceAccount:{emailid} and the undeleted service account retains the role
        /// in the binding. deleted:group:{emailid}?uid={uniqueid}: An email address (plus unique identifier)
        /// representing a Google group that has been recently deleted. For example,
        /// admins@example.com?uid=123456789012345678901. If the group is recovered, this value reverts to
        /// group:{emailid} and the recovered group retains the role in the binding. domain:{domain}: The G Suite domain
        /// (primary) that represents all the users of that domain. For example, google.com or example.com.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Role that is assigned to the list of members, or principals. For example, roles/viewer, roles/editor, or
        /// roles/owner.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

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
    public class GoogleIamV1Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<GoogleIamV1AuditConfig> AuditConfigs { get; set; }

        /// <summary>
        /// Associates a list of members, or principals, with a role. Optionally, may specify a condition that
        /// determines how and when the bindings are applied. Each of the bindings must contain at least one
        /// principal.The bindings in a Policy can refer to up to 1,500 principals; up to 250 of these principals can be
        /// Google groups. Each occurrence of a principal counts towards these limits. For example, if the bindings
        /// grant 50 different roles to user:alice@example.com, and not to any other principal, then you can add another
        /// 1,450 principals to the bindings in the Policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<GoogleIamV1Binding> Bindings { get; set; }

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

    /// <summary>Request message for SetIamPolicy method.</summary>
    public class GoogleIamV1SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the resource. The size of the policy is limited to a few 10s
        /// of KB. An empty policy is a valid policy but certain Cloud Platform services (such as Projects) might reject
        /// them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual GoogleIamV1Policy Policy { get; set; }

        /// <summary>
        /// OPTIONAL: A FieldMask specifying which fields of the policy to modify. Only the fields in the mask will be
        /// modified. If no mask is provided, the following default mask is used:paths: "bindings, etag"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for TestIamPermissions method.</summary>
    public class GoogleIamV1TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of permissions to check for the resource. Permissions with wildcards (such as '*' or 'storage.*')
        /// are not allowed. For more information see IAM Overview
        /// (https://cloud.google.com/iam/docs/overview#permissions).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for TestIamPermissions method.</summary>
    public class GoogleIamV1TestIamPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A subset of TestPermissionsRequest.permissions that the caller is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class GoogleLongrunningCancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Operations.ListOperations.</summary>
    public class GoogleLongrunningListOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of operations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<GoogleLongrunningOperation> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class GoogleLongrunningOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is false, it means the operation is still in progress. If true, the operation is completed, and
        /// either error or response is available.
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
        /// use the default HTTP mapping, the name should be a resource name ending with operations/{unique_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The normal response of the operation in case of success. If the original method returns no data on success,
        /// such as Delete, the response is google.protobuf.Empty. If the original method is standard Get/Create/Update,
        /// the response should be the resource. For other methods, the response should have the type XxxResponse, where
        /// Xxx is the original method name. For example, if the original method name is TakeSnapshot(), the inferred
        /// response type is TakeSnapshotResponse.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The Status type defines a logical error model that is suitable for different programming environments, including
    /// REST APIs and RPC APIs. It is used by gRPC (https://github.com/grpc). Each Status message contains three pieces
    /// of data: error code, error message, and error details.You can find out more about this error model and how to
    /// work with it in the API Design Guide (https://cloud.google.com/apis/design/errors).
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
