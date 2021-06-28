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

namespace Google.Apis.Dataproc.v1beta2
{
    /// <summary>The Dataproc Service.</summary>
    public class DataprocService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DataprocService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DataprocService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "dataproc";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://dataproc.googleapis.com/";
        #else
            "https://dataproc.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://dataproc.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Dataproc API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Dataproc API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for Dataproc requests.</summary>
    public abstract class DataprocBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DataprocBaseServiceRequest instance.</summary>
        protected DataprocBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Dataproc parameter list.</summary>
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
            Regions = new RegionsResource(service);
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
                AutoscalingPolicies = new AutoscalingPoliciesResource(service);
                WorkflowTemplates = new WorkflowTemplatesResource(service);
            }

            /// <summary>Gets the AutoscalingPolicies resource.</summary>
            public virtual AutoscalingPoliciesResource AutoscalingPolicies { get; }

            /// <summary>The "autoscalingPolicies" collection of methods.</summary>
            public class AutoscalingPoliciesResource
            {
                private const string Resource = "autoscalingPolicies";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AutoscalingPoliciesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates new autoscaling policy.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The "resource name" of the region or location, as described in
                /// https://cloud.google.com/apis/design/resource_names. For
                /// projects.regions.autoscalingPolicies.create, the resource name has the following format:
                /// projects/{project_id}/regions/{region} For projects.locations.autoscalingPolicies.create, the
                /// resource name has the following format: projects/{project_id}/locations/{location}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Dataproc.v1beta2.Data.AutoscalingPolicy body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates new autoscaling policy.</summary>
                public class CreateRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.AutoscalingPolicy>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.AutoscalingPolicy body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The "resource name" of the region or location, as described in
                    /// https://cloud.google.com/apis/design/resource_names. For
                    /// projects.regions.autoscalingPolicies.create, the resource name has the following format:
                    /// projects/{project_id}/regions/{region} For projects.locations.autoscalingPolicies.create, the
                    /// resource name has the following format: projects/{project_id}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataproc.v1beta2.Data.AutoscalingPolicy Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+parent}/autoscalingPolicies";

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
                    }
                }

                /// <summary>
                /// Deletes an autoscaling policy. It is an error to delete an autoscaling policy that is in use by one
                /// or more clusters.
                /// </summary>
                /// <param name="name">
                /// Required. The "resource name" of the autoscaling policy, as described in
                /// https://cloud.google.com/apis/design/resource_names. For
                /// projects.regions.autoscalingPolicies.delete, the resource name of the policy has the following
                /// format: projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id} For
                /// projects.locations.autoscalingPolicies.delete, the resource name of the policy has the following
                /// format: projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes an autoscaling policy. It is an error to delete an autoscaling policy that is in use by one
                /// or more clusters.
                /// </summary>
                public class DeleteRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The "resource name" of the autoscaling policy, as described in
                    /// https://cloud.google.com/apis/design/resource_names. For
                    /// projects.regions.autoscalingPolicies.delete, the resource name of the policy has the following
                    /// format: projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id} For
                    /// projects.locations.autoscalingPolicies.delete, the resource name of the policy has the following
                    /// format: projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/autoscalingPolicies/[^/]+$",
                        });
                    }
                }

                /// <summary>Retrieves autoscaling policy.</summary>
                /// <param name="name">
                /// Required. The "resource name" of the autoscaling policy, as described in
                /// https://cloud.google.com/apis/design/resource_names. For projects.regions.autoscalingPolicies.get,
                /// the resource name of the policy has the following format:
                /// projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id} For
                /// projects.locations.autoscalingPolicies.get, the resource name of the policy has the following
                /// format: projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Retrieves autoscaling policy.</summary>
                public class GetRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.AutoscalingPolicy>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The "resource name" of the autoscaling policy, as described in
                    /// https://cloud.google.com/apis/design/resource_names. For
                    /// projects.regions.autoscalingPolicies.get, the resource name of the policy has the following
                    /// format: projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id} For
                    /// projects.locations.autoscalingPolicies.get, the resource name of the policy has the following
                    /// format: projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/autoscalingPolicies/[^/]+$",
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
                public class GetIamPolicyRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Policy>
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
                    /// Optional. The policy format version to be returned.Valid values are 0, 1, and 3. Requests
                    /// specifying an invalid value will be rejected.Requests for policies with any conditional bindings
                    /// must specify version 3. Policies without any conditional bindings may specify any valid value or
                    /// leave the field unset.To learn which resources support conditions in their IAM policies, see the
                    /// IAM documentation (https://cloud.google.com/iam/help/conditions/resource-policies).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+resource}:getIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/autoscalingPolicies/[^/]+$",
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

                /// <summary>Lists autoscaling policies in the project.</summary>
                /// <param name="parent">
                /// Required. The "resource name" of the region or location, as described in
                /// https://cloud.google.com/apis/design/resource_names. For projects.regions.autoscalingPolicies.list,
                /// the resource name of the region has the following format: projects/{project_id}/regions/{region} For
                /// projects.locations.autoscalingPolicies.list, the resource name of the location has the following
                /// format: projects/{project_id}/locations/{location}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists autoscaling policies in the project.</summary>
                public class ListRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.ListAutoscalingPoliciesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The "resource name" of the region or location, as described in
                    /// https://cloud.google.com/apis/design/resource_names. For
                    /// projects.regions.autoscalingPolicies.list, the resource name of the region has the following
                    /// format: projects/{project_id}/regions/{region} For projects.locations.autoscalingPolicies.list,
                    /// the resource name of the location has the following format:
                    /// projects/{project_id}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of results to return in each response. Must be less than or equal
                    /// to 1000. Defaults to 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. The page token, returned by a previous call, to request the next page of results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+parent}/autoscalingPolicies";

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
                /// Sets the access control policy on the specified resource. Replaces any existing policy.Can return
                /// NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Dataproc.v1beta2.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy.Can return
                /// NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                /// </summary>
                public class SetIamPolicyRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.Dataproc.v1beta2.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+resource}:setIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/autoscalingPolicies/[^/]+$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a NOT_FOUND error.Note: This operation is designed
                /// to be used for building permission-aware UIs and command-line tools, not for authorization checking.
                /// This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+resource}:testIamPermissions";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/autoscalingPolicies/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Updates (replaces) autoscaling policy.Disabled check for update_mask, because all updates will be
                /// full replacements.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. The "resource name" of the autoscaling policy, as described in
                /// https://cloud.google.com/apis/design/resource_names. For projects.regions.autoscalingPolicies, the
                /// resource name of the policy has the following format:
                /// projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id} For
                /// projects.locations.autoscalingPolicies, the resource name of the policy has the following format:
                /// projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}
                /// </param>
                public virtual UpdateRequest Update(Google.Apis.Dataproc.v1beta2.Data.AutoscalingPolicy body, string name)
                {
                    return new UpdateRequest(service, body, name);
                }

                /// <summary>
                /// Updates (replaces) autoscaling policy.Disabled check for update_mask, because all updates will be
                /// full replacements.
                /// </summary>
                public class UpdateRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.AutoscalingPolicy>
                {
                    /// <summary>Constructs a new Update request.</summary>
                    public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.AutoscalingPolicy body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. The "resource name" of the autoscaling policy, as described in
                    /// https://cloud.google.com/apis/design/resource_names. For projects.regions.autoscalingPolicies,
                    /// the resource name of the policy has the following format:
                    /// projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id} For
                    /// projects.locations.autoscalingPolicies, the resource name of the policy has the following
                    /// format: projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataproc.v1beta2.Data.AutoscalingPolicy Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "update";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/autoscalingPolicies/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the WorkflowTemplates resource.</summary>
            public virtual WorkflowTemplatesResource WorkflowTemplates { get; }

            /// <summary>The "workflowTemplates" collection of methods.</summary>
            public class WorkflowTemplatesResource
            {
                private const string Resource = "workflowTemplates";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public WorkflowTemplatesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates new workflow template.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource name of the region or location, as described in
                /// https://cloud.google.com/apis/design/resource_names. For projects.regions.workflowTemplates,create,
                /// the resource name of the region has the following format: projects/{project_id}/regions/{region} For
                /// projects.locations.workflowTemplates.create, the resource name of the location has the following
                /// format: projects/{project_id}/locations/{location}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Dataproc.v1beta2.Data.WorkflowTemplate body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates new workflow template.</summary>
                public class CreateRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.WorkflowTemplate>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.WorkflowTemplate body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the region or location, as described in
                    /// https://cloud.google.com/apis/design/resource_names. For
                    /// projects.regions.workflowTemplates,create, the resource name of the region has the following
                    /// format: projects/{project_id}/regions/{region} For projects.locations.workflowTemplates.create,
                    /// the resource name of the location has the following format:
                    /// projects/{project_id}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataproc.v1beta2.Data.WorkflowTemplate Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+parent}/workflowTemplates";

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
                    }
                }

                /// <summary>Deletes a workflow template. It does not cancel in-progress workflows.</summary>
                /// <param name="name">
                /// Required. The resource name of the workflow template, as described in
                /// https://cloud.google.com/apis/design/resource_names. For projects.regions.workflowTemplates.delete,
                /// the resource name of the template has the following format:
                /// projects/{project_id}/regions/{region}/workflowTemplates/{template_id} For
                /// projects.locations.workflowTemplates.instantiate, the resource name of the template has the
                /// following format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a workflow template. It does not cancel in-progress workflows.</summary>
                public class DeleteRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the workflow template, as described in
                    /// https://cloud.google.com/apis/design/resource_names. For
                    /// projects.regions.workflowTemplates.delete, the resource name of the template has the following
                    /// format: projects/{project_id}/regions/{region}/workflowTemplates/{template_id} For
                    /// projects.locations.workflowTemplates.instantiate, the resource name of the template has the
                    /// following format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The version of workflow template to delete. If specified, will only delete the
                    /// template if the current server version matches specified version.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("version", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> Version { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workflowTemplates/[^/]+$",
                        });
                        RequestParameters.Add("version", new Google.Apis.Discovery.Parameter
                        {
                            Name = "version",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Retrieves the latest workflow template.Can retrieve previously instantiated template by specifying
                /// optional version parameter.
                /// </summary>
                /// <param name="name">
                /// Required. The resource name of the workflow template, as described in
                /// https://cloud.google.com/apis/design/resource_names. For projects.regions.workflowTemplates.get, the
                /// resource name of the template has the following format:
                /// projects/{project_id}/regions/{region}/workflowTemplates/{template_id} For
                /// projects.locations.workflowTemplates.get, the resource name of the template has the following
                /// format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Retrieves the latest workflow template.Can retrieve previously instantiated template by specifying
                /// optional version parameter.
                /// </summary>
                public class GetRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.WorkflowTemplate>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the workflow template, as described in
                    /// https://cloud.google.com/apis/design/resource_names. For projects.regions.workflowTemplates.get,
                    /// the resource name of the template has the following format:
                    /// projects/{project_id}/regions/{region}/workflowTemplates/{template_id} For
                    /// projects.locations.workflowTemplates.get, the resource name of the template has the following
                    /// format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The version of workflow template to retrieve. Only previously instantiated versions
                    /// can be retrieved.If unspecified, retrieves the current version.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("version", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> Version { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workflowTemplates/[^/]+$",
                        });
                        RequestParameters.Add("version", new Google.Apis.Discovery.Parameter
                        {
                            Name = "version",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
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
                public class GetIamPolicyRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Policy>
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
                    /// Optional. The policy format version to be returned.Valid values are 0, 1, and 3. Requests
                    /// specifying an invalid value will be rejected.Requests for policies with any conditional bindings
                    /// must specify version 3. Policies without any conditional bindings may specify any valid value or
                    /// leave the field unset.To learn which resources support conditions in their IAM policies, see the
                    /// IAM documentation (https://cloud.google.com/iam/help/conditions/resource-policies).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+resource}:getIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workflowTemplates/[^/]+$",
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
                /// Instantiates a template and begins execution.The returned Operation can be used to track execution
                /// of workflow by polling operations.get. The Operation will complete when entire workflow is
                /// finished.The running workflow can be aborted via operations.cancel. This will cause any inflight
                /// jobs to be cancelled and workflow-owned clusters to be deleted.The Operation.metadata will be
                /// WorkflowMetadata
                /// (https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1beta2#workflowmetadata).
                /// Also see Using WorkflowMetadata
                /// (https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).On
                /// successful completion, Operation.response will be Empty.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name of the workflow template, as described in
                /// https://cloud.google.com/apis/design/resource_names. For
                /// projects.regions.workflowTemplates.instantiate, the resource name of the template has the following
                /// format: projects/{project_id}/regions/{region}/workflowTemplates/{template_id} For
                /// projects.locations.workflowTemplates.instantiate, the resource name of the template has the
                /// following format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}
                /// </param>
                public virtual InstantiateRequest Instantiate(Google.Apis.Dataproc.v1beta2.Data.InstantiateWorkflowTemplateRequest body, string name)
                {
                    return new InstantiateRequest(service, body, name);
                }

                /// <summary>
                /// Instantiates a template and begins execution.The returned Operation can be used to track execution
                /// of workflow by polling operations.get. The Operation will complete when entire workflow is
                /// finished.The running workflow can be aborted via operations.cancel. This will cause any inflight
                /// jobs to be cancelled and workflow-owned clusters to be deleted.The Operation.metadata will be
                /// WorkflowMetadata
                /// (https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1beta2#workflowmetadata).
                /// Also see Using WorkflowMetadata
                /// (https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).On
                /// successful completion, Operation.response will be Empty.
                /// </summary>
                public class InstantiateRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Operation>
                {
                    /// <summary>Constructs a new Instantiate request.</summary>
                    public InstantiateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.InstantiateWorkflowTemplateRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the workflow template, as described in
                    /// https://cloud.google.com/apis/design/resource_names. For
                    /// projects.regions.workflowTemplates.instantiate, the resource name of the template has the
                    /// following format: projects/{project_id}/regions/{region}/workflowTemplates/{template_id} For
                    /// projects.locations.workflowTemplates.instantiate, the resource name of the template has the
                    /// following format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataproc.v1beta2.Data.InstantiateWorkflowTemplateRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "instantiate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+name}:instantiate";

                    /// <summary>Initializes Instantiate parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workflowTemplates/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Instantiates a template and begins execution.This method is equivalent to executing the sequence
                /// CreateWorkflowTemplate, InstantiateWorkflowTemplate, DeleteWorkflowTemplate.The returned Operation
                /// can be used to track execution of workflow by polling operations.get. The Operation will complete
                /// when entire workflow is finished.The running workflow can be aborted via operations.cancel. This
                /// will cause any inflight jobs to be cancelled and workflow-owned clusters to be deleted.The
                /// Operation.metadata will be WorkflowMetadata
                /// (https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
                /// Also see Using WorkflowMetadata
                /// (https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).On
                /// successful completion, Operation.response will be Empty.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource name of the region or location, as described in
                /// https://cloud.google.com/apis/design/resource_names. For
                /// projects.regions.workflowTemplates,instantiateinline, the resource name of the region has the
                /// following format: projects/{project_id}/regions/{region} For
                /// projects.locations.workflowTemplates.instantiateinline, the resource name of the location has the
                /// following format: projects/{project_id}/locations/{location}
                /// </param>
                public virtual InstantiateInlineRequest InstantiateInline(Google.Apis.Dataproc.v1beta2.Data.WorkflowTemplate body, string parent)
                {
                    return new InstantiateInlineRequest(service, body, parent);
                }

                /// <summary>
                /// Instantiates a template and begins execution.This method is equivalent to executing the sequence
                /// CreateWorkflowTemplate, InstantiateWorkflowTemplate, DeleteWorkflowTemplate.The returned Operation
                /// can be used to track execution of workflow by polling operations.get. The Operation will complete
                /// when entire workflow is finished.The running workflow can be aborted via operations.cancel. This
                /// will cause any inflight jobs to be cancelled and workflow-owned clusters to be deleted.The
                /// Operation.metadata will be WorkflowMetadata
                /// (https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
                /// Also see Using WorkflowMetadata
                /// (https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).On
                /// successful completion, Operation.response will be Empty.
                /// </summary>
                public class InstantiateInlineRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Operation>
                {
                    /// <summary>Constructs a new InstantiateInline request.</summary>
                    public InstantiateInlineRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.WorkflowTemplate body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the region or location, as described in
                    /// https://cloud.google.com/apis/design/resource_names. For
                    /// projects.regions.workflowTemplates,instantiateinline, the resource name of the region has the
                    /// following format: projects/{project_id}/regions/{region} For
                    /// projects.locations.workflowTemplates.instantiateinline, the resource name of the location has
                    /// the following format: projects/{project_id}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Deprecated. Please use request_id field instead.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("instanceId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string InstanceId { get; set; }

                    /// <summary>
                    /// Optional. A tag that prevents multiple concurrent workflow instances with the same tag from
                    /// running. This mitigates risk of concurrent instances started due to retries.It is recommended to
                    /// always set this value to a UUID
                    /// (https://en.wikipedia.org/wiki/Universally_unique_identifier).The tag must contain only letters
                    /// (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). The maximum length is 40
                    /// characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataproc.v1beta2.Data.WorkflowTemplate Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "instantiateInline";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+parent}/workflowTemplates:instantiateInline";

                    /// <summary>Initializes InstantiateInline parameter list.</summary>
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

                /// <summary>Lists workflows that match the specified filter in the request.</summary>
                /// <param name="parent">
                /// Required. The resource name of the region or location, as described in
                /// https://cloud.google.com/apis/design/resource_names. For projects.regions.workflowTemplates,list,
                /// the resource name of the region has the following format: projects/{project_id}/regions/{region} For
                /// projects.locations.workflowTemplates.list, the resource name of the location has the following
                /// format: projects/{project_id}/locations/{location}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists workflows that match the specified filter in the request.</summary>
                public class ListRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.ListWorkflowTemplatesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the region or location, as described in
                    /// https://cloud.google.com/apis/design/resource_names. For
                    /// projects.regions.workflowTemplates,list, the resource name of the region has the following
                    /// format: projects/{project_id}/regions/{region} For projects.locations.workflowTemplates.list,
                    /// the resource name of the location has the following format:
                    /// projects/{project_id}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. The maximum number of results to return in each response.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. The page token, returned by a previous call, to request the next page of results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+parent}/workflowTemplates";

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
                /// Sets the access control policy on the specified resource. Replaces any existing policy.Can return
                /// NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Dataproc.v1beta2.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy.Can return
                /// NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                /// </summary>
                public class SetIamPolicyRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.Dataproc.v1beta2.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+resource}:setIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workflowTemplates/[^/]+$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a NOT_FOUND error.Note: This operation is designed
                /// to be used for building permission-aware UIs and command-line tools, not for authorization checking.
                /// This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+resource}:testIamPermissions";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workflowTemplates/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Updates (replaces) workflow template. The updated template must contain version that matches the
                /// current server version.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. The resource name of the workflow template, as described in
                /// https://cloud.google.com/apis/design/resource_names. For projects.regions.workflowTemplates, the
                /// resource name of the template has the following format:
                /// projects/{project_id}/regions/{region}/workflowTemplates/{template_id} For
                /// projects.locations.workflowTemplates, the resource name of the template has the following format:
                /// projects/{project_id}/locations/{location}/workflowTemplates/{template_id}
                /// </param>
                public virtual UpdateRequest Update(Google.Apis.Dataproc.v1beta2.Data.WorkflowTemplate body, string name)
                {
                    return new UpdateRequest(service, body, name);
                }

                /// <summary>
                /// Updates (replaces) workflow template. The updated template must contain version that matches the
                /// current server version.
                /// </summary>
                public class UpdateRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.WorkflowTemplate>
                {
                    /// <summary>Constructs a new Update request.</summary>
                    public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.WorkflowTemplate body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. The resource name of the workflow template, as described in
                    /// https://cloud.google.com/apis/design/resource_names. For projects.regions.workflowTemplates, the
                    /// resource name of the template has the following format:
                    /// projects/{project_id}/regions/{region}/workflowTemplates/{template_id} For
                    /// projects.locations.workflowTemplates, the resource name of the template has the following
                    /// format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataproc.v1beta2.Data.WorkflowTemplate Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "update";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workflowTemplates/[^/]+$",
                        });
                    }
                }
            }
        }

        /// <summary>Gets the Regions resource.</summary>
        public virtual RegionsResource Regions { get; }

        /// <summary>The "regions" collection of methods.</summary>
        public class RegionsResource
        {
            private const string Resource = "regions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public RegionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                AutoscalingPolicies = new AutoscalingPoliciesResource(service);
                Clusters = new ClustersResource(service);
                Jobs = new JobsResource(service);
                Operations = new OperationsResource(service);
                WorkflowTemplates = new WorkflowTemplatesResource(service);
            }

            /// <summary>Gets the AutoscalingPolicies resource.</summary>
            public virtual AutoscalingPoliciesResource AutoscalingPolicies { get; }

            /// <summary>The "autoscalingPolicies" collection of methods.</summary>
            public class AutoscalingPoliciesResource
            {
                private const string Resource = "autoscalingPolicies";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AutoscalingPoliciesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates new autoscaling policy.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The "resource name" of the region or location, as described in
                /// https://cloud.google.com/apis/design/resource_names. For
                /// projects.regions.autoscalingPolicies.create, the resource name has the following format:
                /// projects/{project_id}/regions/{region} For projects.locations.autoscalingPolicies.create, the
                /// resource name has the following format: projects/{project_id}/locations/{location}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Dataproc.v1beta2.Data.AutoscalingPolicy body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates new autoscaling policy.</summary>
                public class CreateRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.AutoscalingPolicy>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.AutoscalingPolicy body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The "resource name" of the region or location, as described in
                    /// https://cloud.google.com/apis/design/resource_names. For
                    /// projects.regions.autoscalingPolicies.create, the resource name has the following format:
                    /// projects/{project_id}/regions/{region} For projects.locations.autoscalingPolicies.create, the
                    /// resource name has the following format: projects/{project_id}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataproc.v1beta2.Data.AutoscalingPolicy Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+parent}/autoscalingPolicies";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes an autoscaling policy. It is an error to delete an autoscaling policy that is in use by one
                /// or more clusters.
                /// </summary>
                /// <param name="name">
                /// Required. The "resource name" of the autoscaling policy, as described in
                /// https://cloud.google.com/apis/design/resource_names. For
                /// projects.regions.autoscalingPolicies.delete, the resource name of the policy has the following
                /// format: projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id} For
                /// projects.locations.autoscalingPolicies.delete, the resource name of the policy has the following
                /// format: projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes an autoscaling policy. It is an error to delete an autoscaling policy that is in use by one
                /// or more clusters.
                /// </summary>
                public class DeleteRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The "resource name" of the autoscaling policy, as described in
                    /// https://cloud.google.com/apis/design/resource_names. For
                    /// projects.regions.autoscalingPolicies.delete, the resource name of the policy has the following
                    /// format: projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id} For
                    /// projects.locations.autoscalingPolicies.delete, the resource name of the policy has the following
                    /// format: projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+name}";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+/autoscalingPolicies/[^/]+$",
                        });
                    }
                }

                /// <summary>Retrieves autoscaling policy.</summary>
                /// <param name="name">
                /// Required. The "resource name" of the autoscaling policy, as described in
                /// https://cloud.google.com/apis/design/resource_names. For projects.regions.autoscalingPolicies.get,
                /// the resource name of the policy has the following format:
                /// projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id} For
                /// projects.locations.autoscalingPolicies.get, the resource name of the policy has the following
                /// format: projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Retrieves autoscaling policy.</summary>
                public class GetRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.AutoscalingPolicy>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The "resource name" of the autoscaling policy, as described in
                    /// https://cloud.google.com/apis/design/resource_names. For
                    /// projects.regions.autoscalingPolicies.get, the resource name of the policy has the following
                    /// format: projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id} For
                    /// projects.locations.autoscalingPolicies.get, the resource name of the policy has the following
                    /// format: projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+name}";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+/autoscalingPolicies/[^/]+$",
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
                public class GetIamPolicyRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Policy>
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
                    /// Optional. The policy format version to be returned.Valid values are 0, 1, and 3. Requests
                    /// specifying an invalid value will be rejected.Requests for policies with any conditional bindings
                    /// must specify version 3. Policies without any conditional bindings may specify any valid value or
                    /// leave the field unset.To learn which resources support conditions in their IAM policies, see the
                    /// IAM documentation (https://cloud.google.com/iam/help/conditions/resource-policies).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+resource}:getIamPolicy";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+/autoscalingPolicies/[^/]+$",
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

                /// <summary>Lists autoscaling policies in the project.</summary>
                /// <param name="parent">
                /// Required. The "resource name" of the region or location, as described in
                /// https://cloud.google.com/apis/design/resource_names. For projects.regions.autoscalingPolicies.list,
                /// the resource name of the region has the following format: projects/{project_id}/regions/{region} For
                /// projects.locations.autoscalingPolicies.list, the resource name of the location has the following
                /// format: projects/{project_id}/locations/{location}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists autoscaling policies in the project.</summary>
                public class ListRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.ListAutoscalingPoliciesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The "resource name" of the region or location, as described in
                    /// https://cloud.google.com/apis/design/resource_names. For
                    /// projects.regions.autoscalingPolicies.list, the resource name of the region has the following
                    /// format: projects/{project_id}/regions/{region} For projects.locations.autoscalingPolicies.list,
                    /// the resource name of the location has the following format:
                    /// projects/{project_id}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of results to return in each response. Must be less than or equal
                    /// to 1000. Defaults to 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. The page token, returned by a previous call, to request the next page of results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+parent}/autoscalingPolicies";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+$",
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
                /// Sets the access control policy on the specified resource. Replaces any existing policy.Can return
                /// NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Dataproc.v1beta2.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy.Can return
                /// NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                /// </summary>
                public class SetIamPolicyRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.Dataproc.v1beta2.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+resource}:setIamPolicy";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+/autoscalingPolicies/[^/]+$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a NOT_FOUND error.Note: This operation is designed
                /// to be used for building permission-aware UIs and command-line tools, not for authorization checking.
                /// This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+resource}:testIamPermissions";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+/autoscalingPolicies/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Updates (replaces) autoscaling policy.Disabled check for update_mask, because all updates will be
                /// full replacements.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. The "resource name" of the autoscaling policy, as described in
                /// https://cloud.google.com/apis/design/resource_names. For projects.regions.autoscalingPolicies, the
                /// resource name of the policy has the following format:
                /// projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id} For
                /// projects.locations.autoscalingPolicies, the resource name of the policy has the following format:
                /// projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}
                /// </param>
                public virtual UpdateRequest Update(Google.Apis.Dataproc.v1beta2.Data.AutoscalingPolicy body, string name)
                {
                    return new UpdateRequest(service, body, name);
                }

                /// <summary>
                /// Updates (replaces) autoscaling policy.Disabled check for update_mask, because all updates will be
                /// full replacements.
                /// </summary>
                public class UpdateRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.AutoscalingPolicy>
                {
                    /// <summary>Constructs a new Update request.</summary>
                    public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.AutoscalingPolicy body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. The "resource name" of the autoscaling policy, as described in
                    /// https://cloud.google.com/apis/design/resource_names. For projects.regions.autoscalingPolicies,
                    /// the resource name of the policy has the following format:
                    /// projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id} For
                    /// projects.locations.autoscalingPolicies, the resource name of the policy has the following
                    /// format: projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataproc.v1beta2.Data.AutoscalingPolicy Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "update";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+name}";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+/autoscalingPolicies/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Clusters resource.</summary>
            public virtual ClustersResource Clusters { get; }

            /// <summary>The "clusters" collection of methods.</summary>
            public class ClustersResource
            {
                private const string Resource = "clusters";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ClustersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a cluster in a project. The returned Operation.metadata will be ClusterOperationMetadata
                /// (https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1beta2#clusteroperationmetadata).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Required. The ID of the Google Cloud Platform project that the cluster belongs to.
                /// </param>
                /// <param name="region">Required. The Dataproc region in which to handle the request.</param>
                public virtual CreateRequest Create(Google.Apis.Dataproc.v1beta2.Data.Cluster body, string projectId, string region)
                {
                    return new CreateRequest(service, body, projectId, region);
                }

                /// <summary>
                /// Creates a cluster in a project. The returned Operation.metadata will be ClusterOperationMetadata
                /// (https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1beta2#clusteroperationmetadata).
                /// </summary>
                public class CreateRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.Cluster body, string projectId, string region) : base(service)
                    {
                        ProjectId = projectId;
                        Region = region;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The ID of the Google Cloud Platform project that the cluster belongs to.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>Required. The Dataproc region in which to handle the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("region", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Region { get; private set; }

                    /// <summary>
                    /// Optional. A unique id used to identify the request. If the server receives two
                    /// CreateClusterRequest
                    /// (https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1beta2#google.cloud.dataproc.v1beta2.CreateClusterRequest)s
                    /// with the same id, then the second request will be ignored and the first
                    /// google.longrunning.Operation created and stored in the backend is returned.It is recommended to
                    /// always set this value to a UUID
                    /// (https://en.wikipedia.org/wiki/Universally_unique_identifier).The id must contain only letters
                    /// (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). The maximum length is 40
                    /// characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataproc.v1beta2.Data.Cluster Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/projects/{projectId}/regions/{region}/clusters";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("region", new Google.Apis.Discovery.Parameter
                        {
                            Name = "region",
                            IsRequired = true,
                            ParameterType = "path",
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
                /// Deletes a cluster in a project. The returned Operation.metadata will be ClusterOperationMetadata
                /// (https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1beta2#clusteroperationmetadata).
                /// </summary>
                /// <param name="projectId">
                /// Required. The ID of the Google Cloud Platform project that the cluster belongs to.
                /// </param>
                /// <param name="region">Required. The Dataproc region in which to handle the request.</param>
                /// <param name="clusterName">Required. The cluster name.</param>
                public virtual DeleteRequest Delete(string projectId, string region, string clusterName)
                {
                    return new DeleteRequest(service, projectId, region, clusterName);
                }

                /// <summary>
                /// Deletes a cluster in a project. The returned Operation.metadata will be ClusterOperationMetadata
                /// (https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1beta2#clusteroperationmetadata).
                /// </summary>
                public class DeleteRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string projectId, string region, string clusterName) : base(service)
                    {
                        ProjectId = projectId;
                        Region = region;
                        ClusterName = clusterName;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The ID of the Google Cloud Platform project that the cluster belongs to.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>Required. The Dataproc region in which to handle the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("region", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Region { get; private set; }

                    /// <summary>Required. The cluster name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ClusterName { get; private set; }

                    /// <summary>
                    /// Optional. Specifying the cluster_uuid means the RPC should fail (with error NOT_FOUND) if
                    /// cluster with specified UUID does not exist.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterUuid", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ClusterUuid { get; set; }

                    /// <summary>
                    /// Optional. A unique id used to identify the request. If the server receives two
                    /// DeleteClusterRequest
                    /// (https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1beta2#google.cloud.dataproc.v1beta2.DeleteClusterRequest)s
                    /// with the same id, then the second request will be ignored and the first
                    /// google.longrunning.Operation created and stored in the backend is returned.It is recommended to
                    /// always set this value to a UUID
                    /// (https://en.wikipedia.org/wiki/Universally_unique_identifier).The id must contain only letters
                    /// (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). The maximum length is 40
                    /// characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/projects/{projectId}/regions/{region}/clusters/{clusterName}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("region", new Google.Apis.Discovery.Parameter
                        {
                            Name = "region",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clusterName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clusterUuid", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterUuid",
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
                /// Gets cluster diagnostic information. The returned Operation.metadata will be
                /// ClusterOperationMetadata
                /// (https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1beta2#clusteroperationmetadata).
                /// After the operation completes, Operation.response contains Empty.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Required. The ID of the Google Cloud Platform project that the cluster belongs to.
                /// </param>
                /// <param name="region">Required. The Dataproc region in which to handle the request.</param>
                /// <param name="clusterName">Required. The cluster name.</param>
                public virtual DiagnoseRequest Diagnose(Google.Apis.Dataproc.v1beta2.Data.DiagnoseClusterRequest body, string projectId, string region, string clusterName)
                {
                    return new DiagnoseRequest(service, body, projectId, region, clusterName);
                }

                /// <summary>
                /// Gets cluster diagnostic information. The returned Operation.metadata will be
                /// ClusterOperationMetadata
                /// (https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1beta2#clusteroperationmetadata).
                /// After the operation completes, Operation.response contains Empty.
                /// </summary>
                public class DiagnoseRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Operation>
                {
                    /// <summary>Constructs a new Diagnose request.</summary>
                    public DiagnoseRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.DiagnoseClusterRequest body, string projectId, string region, string clusterName) : base(service)
                    {
                        ProjectId = projectId;
                        Region = region;
                        ClusterName = clusterName;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The ID of the Google Cloud Platform project that the cluster belongs to.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>Required. The Dataproc region in which to handle the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("region", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Region { get; private set; }

                    /// <summary>Required. The cluster name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ClusterName { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataproc.v1beta2.Data.DiagnoseClusterRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "diagnose";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/projects/{projectId}/regions/{region}/clusters/{clusterName}:diagnose";

                    /// <summary>Initializes Diagnose parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("region", new Google.Apis.Discovery.Parameter
                        {
                            Name = "region",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clusterName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets the resource representation for a cluster in a project.</summary>
                /// <param name="projectId">
                /// Required. The ID of the Google Cloud Platform project that the cluster belongs to.
                /// </param>
                /// <param name="region">Required. The Dataproc region in which to handle the request.</param>
                /// <param name="clusterName">Required. The cluster name.</param>
                public virtual GetRequest Get(string projectId, string region, string clusterName)
                {
                    return new GetRequest(service, projectId, region, clusterName);
                }

                /// <summary>Gets the resource representation for a cluster in a project.</summary>
                public class GetRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Cluster>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string projectId, string region, string clusterName) : base(service)
                    {
                        ProjectId = projectId;
                        Region = region;
                        ClusterName = clusterName;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The ID of the Google Cloud Platform project that the cluster belongs to.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>Required. The Dataproc region in which to handle the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("region", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Region { get; private set; }

                    /// <summary>Required. The cluster name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ClusterName { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/projects/{projectId}/regions/{region}/clusters/{clusterName}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("region", new Google.Apis.Discovery.Parameter
                        {
                            Name = "region",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clusterName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
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
                public class GetIamPolicyRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Policy>
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
                    /// Optional. The policy format version to be returned.Valid values are 0, 1, and 3. Requests
                    /// specifying an invalid value will be rejected.Requests for policies with any conditional bindings
                    /// must specify version 3. Policies without any conditional bindings may specify any valid value or
                    /// leave the field unset.To learn which resources support conditions in their IAM policies, see the
                    /// IAM documentation (https://cloud.google.com/iam/help/conditions/resource-policies).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+resource}:getIamPolicy";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+/clusters/[^/]+$",
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
                /// Inject encrypted credentials into all of the VMs in a cluster.The target cluster must be a personal
                /// auth cluster assigned to the user who is issuing the RPC.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="project">
                /// Required. The ID of the Google Cloud Platform project the cluster belongs to, of the form projects/.
                /// </param>
                /// <param name="region">Required. The region containing the cluster, of the form regions/.</param>
                /// <param name="cluster">Required. The cluster, in the form clusters/.</param>
                public virtual InjectCredentialsRequest InjectCredentials(Google.Apis.Dataproc.v1beta2.Data.InjectCredentialsRequest body, string project, string region, string cluster)
                {
                    return new InjectCredentialsRequest(service, body, project, region, cluster);
                }

                /// <summary>
                /// Inject encrypted credentials into all of the VMs in a cluster.The target cluster must be a personal
                /// auth cluster assigned to the user who is issuing the RPC.
                /// </summary>
                public class InjectCredentialsRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Operation>
                {
                    /// <summary>Constructs a new InjectCredentials request.</summary>
                    public InjectCredentialsRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.InjectCredentialsRequest body, string project, string region, string cluster) : base(service)
                    {
                        Project = project;
                        Region = region;
                        Cluster = cluster;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The ID of the Google Cloud Platform project the cluster belongs to, of the form
                    /// projects/.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Project { get; private set; }

                    /// <summary>Required. The region containing the cluster, of the form regions/.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("region", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Region { get; private set; }

                    /// <summary>Required. The cluster, in the form clusters/.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("cluster", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Cluster { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataproc.v1beta2.Data.InjectCredentialsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "injectCredentials";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+project}/{+region}/{+cluster}:injectCredentials";

                    /// <summary>Initializes InjectCredentials parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                        {
                            Name = "project",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+$",
                        });
                        RequestParameters.Add("region", new Google.Apis.Discovery.Parameter
                        {
                            Name = "region",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^regions/[^/]+$",
                        });
                        RequestParameters.Add("cluster", new Google.Apis.Discovery.Parameter
                        {
                            Name = "cluster",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^clusters/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all regions/{region}/clusters in a project alphabetically.</summary>
                /// <param name="projectId">
                /// Required. The ID of the Google Cloud Platform project that the cluster belongs to.
                /// </param>
                /// <param name="region">Required. The Dataproc region in which to handle the request.</param>
                public virtual ListRequest List(string projectId, string region)
                {
                    return new ListRequest(service, projectId, region);
                }

                /// <summary>Lists all regions/{region}/clusters in a project alphabetically.</summary>
                public class ListRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.ListClustersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string projectId, string region) : base(service)
                    {
                        ProjectId = projectId;
                        Region = region;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The ID of the Google Cloud Platform project that the cluster belongs to.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>Required. The Dataproc region in which to handle the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("region", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Region { get; private set; }

                    /// <summary>
                    /// Optional. A filter constraining the clusters to list. Filters are case-sensitive and have the
                    /// following syntax:field = value AND field = value ...where field is one of status.state,
                    /// clusterName, or labels.[KEY], and [KEY] is a label key. value can be * to match all values.
                    /// status.state can be one of the following: ACTIVE, INACTIVE, CREATING, RUNNING, ERROR, DELETING,
                    /// or UPDATING. ACTIVE contains the CREATING, UPDATING, and RUNNING states. INACTIVE contains the
                    /// DELETING and ERROR states. clusterName is the name of the cluster provided at creation time.
                    /// Only the logical AND operator is supported; space-separated items are treated as having an
                    /// implicit AND operator.Example filter:status.state = ACTIVE AND clusterName = mycluster AND
                    /// labels.env = staging AND labels.starred = *
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. The standard List page size.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. The standard List page token.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/projects/{projectId}/regions/{region}/clusters";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("region", new Google.Apis.Discovery.Parameter
                        {
                            Name = "region",
                            IsRequired = true,
                            ParameterType = "path",
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

                /// <summary>
                /// Updates a cluster in a project. The returned Operation.metadata will be ClusterOperationMetadata
                /// (https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1beta2#clusteroperationmetadata).
                /// The cluster must be in a RUNNING state or an error is returned.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Required. The ID of the Google Cloud Platform project the cluster belongs to.
                /// </param>
                /// <param name="region">Required. The Dataproc region in which to handle the request.</param>
                /// <param name="clusterName">Required. The cluster name.</param>
                public virtual PatchRequest Patch(Google.Apis.Dataproc.v1beta2.Data.Cluster body, string projectId, string region, string clusterName)
                {
                    return new PatchRequest(service, body, projectId, region, clusterName);
                }

                /// <summary>
                /// Updates a cluster in a project. The returned Operation.metadata will be ClusterOperationMetadata
                /// (https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1beta2#clusteroperationmetadata).
                /// The cluster must be in a RUNNING state or an error is returned.
                /// </summary>
                public class PatchRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.Cluster body, string projectId, string region, string clusterName) : base(service)
                    {
                        ProjectId = projectId;
                        Region = region;
                        ClusterName = clusterName;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The ID of the Google Cloud Platform project the cluster belongs to.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>Required. The Dataproc region in which to handle the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("region", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Region { get; private set; }

                    /// <summary>Required. The cluster name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ClusterName { get; private set; }

                    /// <summary>
                    /// Optional. Timeout for graceful YARN decomissioning. Graceful decommissioning allows removing
                    /// nodes from the cluster without interrupting jobs in progress. Timeout specifies how long to wait
                    /// for jobs in progress to finish before forcefully removing nodes (and potentially interrupting
                    /// jobs). Default timeout is 0 (for forceful decommission), and the maximum allowed timeout is 1
                    /// day (see JSON representation of Duration
                    /// (https://developers.google.com/protocol-buffers/docs/proto3#json)).Only supported on Dataproc
                    /// image versions 1.2 and higher.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("gracefulDecommissionTimeout", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object GracefulDecommissionTimeout { get; set; }

                    /// <summary>
                    /// Optional. A unique id used to identify the request. If the server receives two
                    /// UpdateClusterRequest
                    /// (https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1beta2#google.cloud.dataproc.v1beta2.UpdateClusterRequest)s
                    /// with the same id, then the second request will be ignored and the first
                    /// google.longrunning.Operation created and stored in the backend is returned.It is recommended to
                    /// always set this value to a UUID
                    /// (https://en.wikipedia.org/wiki/Universally_unique_identifier).The id must contain only letters
                    /// (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). The maximum length is 40
                    /// characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. Specifies the path, relative to Cluster, of the field to update. For example, to
                    /// change the number of workers in a cluster to 5, the update_mask parameter would be specified as
                    /// config.worker_config.num_instances, and the PATCH request body would specify the new value, as
                    /// follows: { "config":{ "workerConfig":{ "numInstances":"5" } } } Similarly, to change the number
                    /// of preemptible workers in a cluster to 5, the update_mask parameter would be
                    /// config.secondary_worker_config.num_instances, and the PATCH request body would be set as
                    /// follows: { "config":{ "secondaryWorkerConfig":{ "numInstances":"5" } } } *Note:* currently only
                    /// the following fields can be updated: *Mask* *Purpose* labels Updates labels
                    /// config.worker_config.num_instances Resize primary worker group
                    /// config.secondary_worker_config.num_instances Resize secondary worker group
                    /// config.lifecycle_config.auto_delete_ttl Reset MAX TTL duration
                    /// config.lifecycle_config.auto_delete_time Update MAX TTL deletion timestamp
                    /// config.lifecycle_config.idle_delete_ttl Update Idle TTL duration
                    /// config.autoscaling_config.policy_uri Use, stop using, or change autoscaling policies
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataproc.v1beta2.Data.Cluster Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/projects/{projectId}/regions/{region}/clusters/{clusterName}";

                    /// <summary>Initializes Patch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("region", new Google.Apis.Discovery.Parameter
                        {
                            Name = "region",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clusterName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("gracefulDecommissionTimeout", new Google.Apis.Discovery.Parameter
                        {
                            Name = "gracefulDecommissionTimeout",
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
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Dataproc.v1beta2.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy.Can return
                /// NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                /// </summary>
                public class SetIamPolicyRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.Dataproc.v1beta2.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+resource}:setIamPolicy";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+/clusters/[^/]+$",
                        });
                    }
                }

                /// <summary>Starts a cluster in a project.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Required. The ID of the Google Cloud Platform project the cluster belongs to.
                /// </param>
                /// <param name="region">Required. The Dataproc region in which to handle the request.</param>
                /// <param name="clusterName">Required. The cluster name.</param>
                public virtual StartRequest Start(Google.Apis.Dataproc.v1beta2.Data.StartClusterRequest body, string projectId, string region, string clusterName)
                {
                    return new StartRequest(service, body, projectId, region, clusterName);
                }

                /// <summary>Starts a cluster in a project.</summary>
                public class StartRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Operation>
                {
                    /// <summary>Constructs a new Start request.</summary>
                    public StartRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.StartClusterRequest body, string projectId, string region, string clusterName) : base(service)
                    {
                        ProjectId = projectId;
                        Region = region;
                        ClusterName = clusterName;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The ID of the Google Cloud Platform project the cluster belongs to.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>Required. The Dataproc region in which to handle the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("region", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Region { get; private set; }

                    /// <summary>Required. The cluster name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ClusterName { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataproc.v1beta2.Data.StartClusterRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "start";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/projects/{projectId}/regions/{region}/clusters/{clusterName}:start";

                    /// <summary>Initializes Start parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("region", new Google.Apis.Discovery.Parameter
                        {
                            Name = "region",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clusterName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Stops a cluster in a project.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Required. The ID of the Google Cloud Platform project the cluster belongs to.
                /// </param>
                /// <param name="region">Required. The Dataproc region in which to handle the request.</param>
                /// <param name="clusterName">Required. The cluster name.</param>
                public virtual StopRequest Stop(Google.Apis.Dataproc.v1beta2.Data.StopClusterRequest body, string projectId, string region, string clusterName)
                {
                    return new StopRequest(service, body, projectId, region, clusterName);
                }

                /// <summary>Stops a cluster in a project.</summary>
                public class StopRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Operation>
                {
                    /// <summary>Constructs a new Stop request.</summary>
                    public StopRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.StopClusterRequest body, string projectId, string region, string clusterName) : base(service)
                    {
                        ProjectId = projectId;
                        Region = region;
                        ClusterName = clusterName;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The ID of the Google Cloud Platform project the cluster belongs to.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>Required. The Dataproc region in which to handle the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("region", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Region { get; private set; }

                    /// <summary>Required. The cluster name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ClusterName { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataproc.v1beta2.Data.StopClusterRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "stop";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/projects/{projectId}/regions/{region}/clusters/{clusterName}:stop";

                    /// <summary>Initializes Stop parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("region", new Google.Apis.Discovery.Parameter
                        {
                            Name = "region",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clusterName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a NOT_FOUND error.Note: This operation is designed
                /// to be used for building permission-aware UIs and command-line tools, not for authorization checking.
                /// This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+resource}:testIamPermissions";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+/clusters/[^/]+$",
                        });
                    }
                }
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

                /// <summary>
                /// Starts a job cancellation request. To access the job resource after cancellation, call
                /// regions/{region}/jobs.list
                /// (https://cloud.google.com/dataproc/docs/reference/rest/v1beta2/projects.regions.jobs/list) or
                /// regions/{region}/jobs.get
                /// (https://cloud.google.com/dataproc/docs/reference/rest/v1beta2/projects.regions.jobs/get).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Required. The ID of the Google Cloud Platform project that the job belongs to.
                /// </param>
                /// <param name="region">Required. The Dataproc region in which to handle the request.</param>
                /// <param name="jobId">Required. The job ID.</param>
                public virtual CancelRequest Cancel(Google.Apis.Dataproc.v1beta2.Data.CancelJobRequest body, string projectId, string region, string jobId)
                {
                    return new CancelRequest(service, body, projectId, region, jobId);
                }

                /// <summary>
                /// Starts a job cancellation request. To access the job resource after cancellation, call
                /// regions/{region}/jobs.list
                /// (https://cloud.google.com/dataproc/docs/reference/rest/v1beta2/projects.regions.jobs/list) or
                /// regions/{region}/jobs.get
                /// (https://cloud.google.com/dataproc/docs/reference/rest/v1beta2/projects.regions.jobs/get).
                /// </summary>
                public class CancelRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Job>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.CancelJobRequest body, string projectId, string region, string jobId) : base(service)
                    {
                        ProjectId = projectId;
                        Region = region;
                        JobId = jobId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The ID of the Google Cloud Platform project that the job belongs to.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>Required. The Dataproc region in which to handle the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("region", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Region { get; private set; }

                    /// <summary>Required. The job ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string JobId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataproc.v1beta2.Data.CancelJobRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/projects/{projectId}/regions/{region}/jobs/{jobId}:cancel";

                    /// <summary>Initializes Cancel parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("region", new Google.Apis.Discovery.Parameter
                        {
                            Name = "region",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "jobId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes the job from the project. If the job is active, the delete fails, and the response returns
                /// FAILED_PRECONDITION.
                /// </summary>
                /// <param name="projectId">
                /// Required. The ID of the Google Cloud Platform project that the job belongs to.
                /// </param>
                /// <param name="region">Required. The Dataproc region in which to handle the request.</param>
                /// <param name="jobId">Required. The job ID.</param>
                public virtual DeleteRequest Delete(string projectId, string region, string jobId)
                {
                    return new DeleteRequest(service, projectId, region, jobId);
                }

                /// <summary>
                /// Deletes the job from the project. If the job is active, the delete fails, and the response returns
                /// FAILED_PRECONDITION.
                /// </summary>
                public class DeleteRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string projectId, string region, string jobId) : base(service)
                    {
                        ProjectId = projectId;
                        Region = region;
                        JobId = jobId;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The ID of the Google Cloud Platform project that the job belongs to.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>Required. The Dataproc region in which to handle the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("region", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Region { get; private set; }

                    /// <summary>Required. The job ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string JobId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/projects/{projectId}/regions/{region}/jobs/{jobId}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("region", new Google.Apis.Discovery.Parameter
                        {
                            Name = "region",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "jobId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets the resource representation for a job in a project.</summary>
                /// <param name="projectId">
                /// Required. The ID of the Google Cloud Platform project that the job belongs to.
                /// </param>
                /// <param name="region">Required. The Dataproc region in which to handle the request.</param>
                /// <param name="jobId">Required. The job ID.</param>
                public virtual GetRequest Get(string projectId, string region, string jobId)
                {
                    return new GetRequest(service, projectId, region, jobId);
                }

                /// <summary>Gets the resource representation for a job in a project.</summary>
                public class GetRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Job>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string projectId, string region, string jobId) : base(service)
                    {
                        ProjectId = projectId;
                        Region = region;
                        JobId = jobId;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The ID of the Google Cloud Platform project that the job belongs to.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>Required. The Dataproc region in which to handle the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("region", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Region { get; private set; }

                    /// <summary>Required. The job ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string JobId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/projects/{projectId}/regions/{region}/jobs/{jobId}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("region", new Google.Apis.Discovery.Parameter
                        {
                            Name = "region",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "jobId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
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
                public class GetIamPolicyRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Policy>
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
                    /// Optional. The policy format version to be returned.Valid values are 0, 1, and 3. Requests
                    /// specifying an invalid value will be rejected.Requests for policies with any conditional bindings
                    /// must specify version 3. Policies without any conditional bindings may specify any valid value or
                    /// leave the field unset.To learn which resources support conditions in their IAM policies, see the
                    /// IAM documentation (https://cloud.google.com/iam/help/conditions/resource-policies).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+resource}:getIamPolicy";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+/jobs/[^/]+$",
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

                /// <summary>Lists regions/{region}/jobs in a project.</summary>
                /// <param name="projectId">
                /// Required. The ID of the Google Cloud Platform project that the job belongs to.
                /// </param>
                /// <param name="region">Required. The Dataproc region in which to handle the request.</param>
                public virtual ListRequest List(string projectId, string region)
                {
                    return new ListRequest(service, projectId, region);
                }

                /// <summary>Lists regions/{region}/jobs in a project.</summary>
                public class ListRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.ListJobsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string projectId, string region) : base(service)
                    {
                        ProjectId = projectId;
                        Region = region;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The ID of the Google Cloud Platform project that the job belongs to.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>Required. The Dataproc region in which to handle the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("region", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Region { get; private set; }

                    /// <summary>
                    /// Optional. If set, the returned jobs list includes only jobs that were submitted to the named
                    /// cluster.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterName", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ClusterName { get; set; }

                    /// <summary>
                    /// Optional. A filter constraining the jobs to list. Filters are case-sensitive and have the
                    /// following syntax:field = value AND field = value ...where field is status.state or labels.[KEY],
                    /// and [KEY] is a label key. value can be * to match all values. status.state can be either ACTIVE
                    /// or NON_ACTIVE. Only the logical AND operator is supported; space-separated items are treated as
                    /// having an implicit AND operator.Example filter:status.state = ACTIVE AND labels.env = staging
                    /// AND labels.starred = *
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. Specifies enumerated categories of jobs to list. (default = match ALL jobs).If filter
                    /// is provided, jobStateMatcher will be ignored.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("jobStateMatcher", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<JobStateMatcherEnum> JobStateMatcher { get; set; }

                    /// <summary>
                    /// Optional. Specifies enumerated categories of jobs to list. (default = match ALL jobs).If filter
                    /// is provided, jobStateMatcher will be ignored.
                    /// </summary>
                    public enum JobStateMatcherEnum
                    {
                        /// <summary>Match all jobs, regardless of state.</summary>
                        [Google.Apis.Util.StringValueAttribute("ALL")]
                        ALL = 0,

                        /// <summary>
                        /// Only match jobs in non-terminal states: PENDING, RUNNING, or CANCEL_PENDING.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("ACTIVE")]
                        ACTIVE = 1,

                        /// <summary>Only match jobs in terminal states: CANCELLED, DONE, or ERROR.</summary>
                        [Google.Apis.Util.StringValueAttribute("NON_ACTIVE")]
                        NONACTIVE = 2,
                    }

                    /// <summary>Optional. The number of results to return in each response.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. The page token, returned by a previous call, to request the next page of results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/projects/{projectId}/regions/{region}/jobs";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("region", new Google.Apis.Discovery.Parameter
                        {
                            Name = "region",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clusterName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterName",
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
                        RequestParameters.Add("jobStateMatcher", new Google.Apis.Discovery.Parameter
                        {
                            Name = "jobStateMatcher",
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

                /// <summary>Updates a job in a project.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Required. The ID of the Google Cloud Platform project that the job belongs to.
                /// </param>
                /// <param name="region">Required. The Dataproc region in which to handle the request.</param>
                /// <param name="jobId">Required. The job ID.</param>
                public virtual PatchRequest Patch(Google.Apis.Dataproc.v1beta2.Data.Job body, string projectId, string region, string jobId)
                {
                    return new PatchRequest(service, body, projectId, region, jobId);
                }

                /// <summary>Updates a job in a project.</summary>
                public class PatchRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Job>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.Job body, string projectId, string region, string jobId) : base(service)
                    {
                        ProjectId = projectId;
                        Region = region;
                        JobId = jobId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The ID of the Google Cloud Platform project that the job belongs to.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>Required. The Dataproc region in which to handle the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("region", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Region { get; private set; }

                    /// <summary>Required. The job ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string JobId { get; private set; }

                    /// <summary>
                    /// Required. Specifies the path, relative to Job, of the field to update. For example, to update
                    /// the labels of a Job the update_mask parameter would be specified as labels, and the PATCH
                    /// request body would specify the new value. *Note:* Currently, labels is the only field that can
                    /// be updated.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataproc.v1beta2.Data.Job Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/projects/{projectId}/regions/{region}/jobs/{jobId}";

                    /// <summary>Initializes Patch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("region", new Google.Apis.Discovery.Parameter
                        {
                            Name = "region",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "jobId",
                            IsRequired = true,
                            ParameterType = "path",
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
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Dataproc.v1beta2.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy.Can return
                /// NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                /// </summary>
                public class SetIamPolicyRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.Dataproc.v1beta2.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+resource}:setIamPolicy";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+/jobs/[^/]+$",
                        });
                    }
                }

                /// <summary>Submits a job to a cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Required. The ID of the Google Cloud Platform project that the job belongs to.
                /// </param>
                /// <param name="region">Required. The Dataproc region in which to handle the request.</param>
                public virtual SubmitRequest Submit(Google.Apis.Dataproc.v1beta2.Data.SubmitJobRequest body, string projectId, string region)
                {
                    return new SubmitRequest(service, body, projectId, region);
                }

                /// <summary>Submits a job to a cluster.</summary>
                public class SubmitRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Job>
                {
                    /// <summary>Constructs a new Submit request.</summary>
                    public SubmitRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.SubmitJobRequest body, string projectId, string region) : base(service)
                    {
                        ProjectId = projectId;
                        Region = region;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The ID of the Google Cloud Platform project that the job belongs to.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>Required. The Dataproc region in which to handle the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("region", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Region { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataproc.v1beta2.Data.SubmitJobRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "submit";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/projects/{projectId}/regions/{region}/jobs:submit";

                    /// <summary>Initializes Submit parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("region", new Google.Apis.Discovery.Parameter
                        {
                            Name = "region",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Submits job to a cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Required. The ID of the Google Cloud Platform project that the job belongs to.
                /// </param>
                /// <param name="region">Required. The Dataproc region in which to handle the request.</param>
                public virtual SubmitAsOperationRequest SubmitAsOperation(Google.Apis.Dataproc.v1beta2.Data.SubmitJobRequest body, string projectId, string region)
                {
                    return new SubmitAsOperationRequest(service, body, projectId, region);
                }

                /// <summary>Submits job to a cluster.</summary>
                public class SubmitAsOperationRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Operation>
                {
                    /// <summary>Constructs a new SubmitAsOperation request.</summary>
                    public SubmitAsOperationRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.SubmitJobRequest body, string projectId, string region) : base(service)
                    {
                        ProjectId = projectId;
                        Region = region;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The ID of the Google Cloud Platform project that the job belongs to.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>Required. The Dataproc region in which to handle the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("region", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Region { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataproc.v1beta2.Data.SubmitJobRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "submitAsOperation";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/projects/{projectId}/regions/{region}/jobs:submitAsOperation";

                    /// <summary>Initializes SubmitAsOperation parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("region", new Google.Apis.Discovery.Parameter
                        {
                            Name = "region",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a NOT_FOUND error.Note: This operation is designed
                /// to be used for building permission-aware UIs and command-line tools, not for authorization checking.
                /// This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+resource}:testIamPermissions";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+/jobs/[^/]+$",
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
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(string name)
                {
                    return new CancelRequest(service, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns google.rpc.Code.UNIMPLEMENTED. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to Code.CANCELLED.
                /// </summary>
                public class CancelRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+name}:cancel";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+/operations/[^/]+$",
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
                public class DeleteRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Empty>
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
                    public override string RestPath => "v1beta2/{+name}";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+/operations/[^/]+$",
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
                public class GetRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Operation>
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
                    public override string RestPath => "v1beta2/{+name}";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+/operations/[^/]+$",
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
                public class GetIamPolicyRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Policy>
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
                    /// Optional. The policy format version to be returned.Valid values are 0, 1, and 3. Requests
                    /// specifying an invalid value will be rejected.Requests for policies with any conditional bindings
                    /// must specify version 3. Policies without any conditional bindings may specify any valid value or
                    /// leave the field unset.To learn which resources support conditions in their IAM policies, see the
                    /// IAM documentation (https://cloud.google.com/iam/help/conditions/resource-policies).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+resource}:getIamPolicy";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+/operations/[^/]+$",
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
                public class ListRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.ListOperationsResponse>
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
                    public override string RestPath => "v1beta2/{+name}";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+/operations$",
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

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy.Can return
                /// NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Dataproc.v1beta2.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy.Can return
                /// NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                /// </summary>
                public class SetIamPolicyRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.Dataproc.v1beta2.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+resource}:setIamPolicy";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+/operations/[^/]+$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a NOT_FOUND error.Note: This operation is designed
                /// to be used for building permission-aware UIs and command-line tools, not for authorization checking.
                /// This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+resource}:testIamPermissions";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+/operations/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the WorkflowTemplates resource.</summary>
            public virtual WorkflowTemplatesResource WorkflowTemplates { get; }

            /// <summary>The "workflowTemplates" collection of methods.</summary>
            public class WorkflowTemplatesResource
            {
                private const string Resource = "workflowTemplates";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public WorkflowTemplatesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates new workflow template.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource name of the region or location, as described in
                /// https://cloud.google.com/apis/design/resource_names. For projects.regions.workflowTemplates,create,
                /// the resource name of the region has the following format: projects/{project_id}/regions/{region} For
                /// projects.locations.workflowTemplates.create, the resource name of the location has the following
                /// format: projects/{project_id}/locations/{location}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Dataproc.v1beta2.Data.WorkflowTemplate body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates new workflow template.</summary>
                public class CreateRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.WorkflowTemplate>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.WorkflowTemplate body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the region or location, as described in
                    /// https://cloud.google.com/apis/design/resource_names. For
                    /// projects.regions.workflowTemplates,create, the resource name of the region has the following
                    /// format: projects/{project_id}/regions/{region} For projects.locations.workflowTemplates.create,
                    /// the resource name of the location has the following format:
                    /// projects/{project_id}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataproc.v1beta2.Data.WorkflowTemplate Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+parent}/workflowTemplates";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+$",
                        });
                    }
                }

                /// <summary>Deletes a workflow template. It does not cancel in-progress workflows.</summary>
                /// <param name="name">
                /// Required. The resource name of the workflow template, as described in
                /// https://cloud.google.com/apis/design/resource_names. For projects.regions.workflowTemplates.delete,
                /// the resource name of the template has the following format:
                /// projects/{project_id}/regions/{region}/workflowTemplates/{template_id} For
                /// projects.locations.workflowTemplates.instantiate, the resource name of the template has the
                /// following format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a workflow template. It does not cancel in-progress workflows.</summary>
                public class DeleteRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the workflow template, as described in
                    /// https://cloud.google.com/apis/design/resource_names. For
                    /// projects.regions.workflowTemplates.delete, the resource name of the template has the following
                    /// format: projects/{project_id}/regions/{region}/workflowTemplates/{template_id} For
                    /// projects.locations.workflowTemplates.instantiate, the resource name of the template has the
                    /// following format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The version of workflow template to delete. If specified, will only delete the
                    /// template if the current server version matches specified version.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("version", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> Version { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+name}";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+/workflowTemplates/[^/]+$",
                        });
                        RequestParameters.Add("version", new Google.Apis.Discovery.Parameter
                        {
                            Name = "version",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Retrieves the latest workflow template.Can retrieve previously instantiated template by specifying
                /// optional version parameter.
                /// </summary>
                /// <param name="name">
                /// Required. The resource name of the workflow template, as described in
                /// https://cloud.google.com/apis/design/resource_names. For projects.regions.workflowTemplates.get, the
                /// resource name of the template has the following format:
                /// projects/{project_id}/regions/{region}/workflowTemplates/{template_id} For
                /// projects.locations.workflowTemplates.get, the resource name of the template has the following
                /// format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Retrieves the latest workflow template.Can retrieve previously instantiated template by specifying
                /// optional version parameter.
                /// </summary>
                public class GetRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.WorkflowTemplate>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the workflow template, as described in
                    /// https://cloud.google.com/apis/design/resource_names. For projects.regions.workflowTemplates.get,
                    /// the resource name of the template has the following format:
                    /// projects/{project_id}/regions/{region}/workflowTemplates/{template_id} For
                    /// projects.locations.workflowTemplates.get, the resource name of the template has the following
                    /// format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The version of workflow template to retrieve. Only previously instantiated versions
                    /// can be retrieved.If unspecified, retrieves the current version.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("version", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> Version { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+name}";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+/workflowTemplates/[^/]+$",
                        });
                        RequestParameters.Add("version", new Google.Apis.Discovery.Parameter
                        {
                            Name = "version",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
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
                public class GetIamPolicyRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Policy>
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
                    /// Optional. The policy format version to be returned.Valid values are 0, 1, and 3. Requests
                    /// specifying an invalid value will be rejected.Requests for policies with any conditional bindings
                    /// must specify version 3. Policies without any conditional bindings may specify any valid value or
                    /// leave the field unset.To learn which resources support conditions in their IAM policies, see the
                    /// IAM documentation (https://cloud.google.com/iam/help/conditions/resource-policies).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+resource}:getIamPolicy";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+/workflowTemplates/[^/]+$",
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
                /// Instantiates a template and begins execution.The returned Operation can be used to track execution
                /// of workflow by polling operations.get. The Operation will complete when entire workflow is
                /// finished.The running workflow can be aborted via operations.cancel. This will cause any inflight
                /// jobs to be cancelled and workflow-owned clusters to be deleted.The Operation.metadata will be
                /// WorkflowMetadata
                /// (https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1beta2#workflowmetadata).
                /// Also see Using WorkflowMetadata
                /// (https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).On
                /// successful completion, Operation.response will be Empty.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name of the workflow template, as described in
                /// https://cloud.google.com/apis/design/resource_names. For
                /// projects.regions.workflowTemplates.instantiate, the resource name of the template has the following
                /// format: projects/{project_id}/regions/{region}/workflowTemplates/{template_id} For
                /// projects.locations.workflowTemplates.instantiate, the resource name of the template has the
                /// following format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}
                /// </param>
                public virtual InstantiateRequest Instantiate(Google.Apis.Dataproc.v1beta2.Data.InstantiateWorkflowTemplateRequest body, string name)
                {
                    return new InstantiateRequest(service, body, name);
                }

                /// <summary>
                /// Instantiates a template and begins execution.The returned Operation can be used to track execution
                /// of workflow by polling operations.get. The Operation will complete when entire workflow is
                /// finished.The running workflow can be aborted via operations.cancel. This will cause any inflight
                /// jobs to be cancelled and workflow-owned clusters to be deleted.The Operation.metadata will be
                /// WorkflowMetadata
                /// (https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1beta2#workflowmetadata).
                /// Also see Using WorkflowMetadata
                /// (https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).On
                /// successful completion, Operation.response will be Empty.
                /// </summary>
                public class InstantiateRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Operation>
                {
                    /// <summary>Constructs a new Instantiate request.</summary>
                    public InstantiateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.InstantiateWorkflowTemplateRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the workflow template, as described in
                    /// https://cloud.google.com/apis/design/resource_names. For
                    /// projects.regions.workflowTemplates.instantiate, the resource name of the template has the
                    /// following format: projects/{project_id}/regions/{region}/workflowTemplates/{template_id} For
                    /// projects.locations.workflowTemplates.instantiate, the resource name of the template has the
                    /// following format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataproc.v1beta2.Data.InstantiateWorkflowTemplateRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "instantiate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+name}:instantiate";

                    /// <summary>Initializes Instantiate parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/regions/[^/]+/workflowTemplates/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Instantiates a template and begins execution.This method is equivalent to executing the sequence
                /// CreateWorkflowTemplate, InstantiateWorkflowTemplate, DeleteWorkflowTemplate.The returned Operation
                /// can be used to track execution of workflow by polling operations.get. The Operation will complete
                /// when entire workflow is finished.The running workflow can be aborted via operations.cancel. This
                /// will cause any inflight jobs to be cancelled and workflow-owned clusters to be deleted.The
                /// Operation.metadata will be WorkflowMetadata
                /// (https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
                /// Also see Using WorkflowMetadata
                /// (https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).On
                /// successful completion, Operation.response will be Empty.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource name of the region or location, as described in
                /// https://cloud.google.com/apis/design/resource_names. For
                /// projects.regions.workflowTemplates,instantiateinline, the resource name of the region has the
                /// following format: projects/{project_id}/regions/{region} For
                /// projects.locations.workflowTemplates.instantiateinline, the resource name of the location has the
                /// following format: projects/{project_id}/locations/{location}
                /// </param>
                public virtual InstantiateInlineRequest InstantiateInline(Google.Apis.Dataproc.v1beta2.Data.WorkflowTemplate body, string parent)
                {
                    return new InstantiateInlineRequest(service, body, parent);
                }

                /// <summary>
                /// Instantiates a template and begins execution.This method is equivalent to executing the sequence
                /// CreateWorkflowTemplate, InstantiateWorkflowTemplate, DeleteWorkflowTemplate.The returned Operation
                /// can be used to track execution of workflow by polling operations.get. The Operation will complete
                /// when entire workflow is finished.The running workflow can be aborted via operations.cancel. This
                /// will cause any inflight jobs to be cancelled and workflow-owned clusters to be deleted.The
                /// Operation.metadata will be WorkflowMetadata
                /// (https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
                /// Also see Using WorkflowMetadata
                /// (https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).On
                /// successful completion, Operation.response will be Empty.
                /// </summary>
                public class InstantiateInlineRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Operation>
                {
                    /// <summary>Constructs a new InstantiateInline request.</summary>
                    public InstantiateInlineRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.WorkflowTemplate body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the region or location, as described in
                    /// https://cloud.google.com/apis/design/resource_names. For
                    /// projects.regions.workflowTemplates,instantiateinline, the resource name of the region has the
                    /// following format: projects/{project_id}/regions/{region} For
                    /// projects.locations.workflowTemplates.instantiateinline, the resource name of the location has
                    /// the following format: projects/{project_id}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Deprecated. Please use request_id field instead.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("instanceId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string InstanceId { get; set; }

                    /// <summary>
                    /// Optional. A tag that prevents multiple concurrent workflow instances with the same tag from
                    /// running. This mitigates risk of concurrent instances started due to retries.It is recommended to
                    /// always set this value to a UUID
                    /// (https://en.wikipedia.org/wiki/Universally_unique_identifier).The tag must contain only letters
                    /// (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). The maximum length is 40
                    /// characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataproc.v1beta2.Data.WorkflowTemplate Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "instantiateInline";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+parent}/workflowTemplates:instantiateInline";

                    /// <summary>Initializes InstantiateInline parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/regions/[^/]+$",
                        });
                        RequestParameters.Add("instanceId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "instanceId",
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

                /// <summary>Lists workflows that match the specified filter in the request.</summary>
                /// <param name="parent">
                /// Required. The resource name of the region or location, as described in
                /// https://cloud.google.com/apis/design/resource_names. For projects.regions.workflowTemplates,list,
                /// the resource name of the region has the following format: projects/{project_id}/regions/{region} For
                /// projects.locations.workflowTemplates.list, the resource name of the location has the following
                /// format: projects/{project_id}/locations/{location}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists workflows that match the specified filter in the request.</summary>
                public class ListRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.ListWorkflowTemplatesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the region or location, as described in
                    /// https://cloud.google.com/apis/design/resource_names. For
                    /// projects.regions.workflowTemplates,list, the resource name of the region has the following
                    /// format: projects/{project_id}/regions/{region} For projects.locations.workflowTemplates.list,
                    /// the resource name of the location has the following format:
                    /// projects/{project_id}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. The maximum number of results to return in each response.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. The page token, returned by a previous call, to request the next page of results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+parent}/workflowTemplates";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+$",
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
                /// Sets the access control policy on the specified resource. Replaces any existing policy.Can return
                /// NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Dataproc.v1beta2.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy.Can return
                /// NOT_FOUND, INVALID_ARGUMENT, and PERMISSION_DENIED errors.
                /// </summary>
                public class SetIamPolicyRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.Dataproc.v1beta2.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+resource}:setIamPolicy";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+/workflowTemplates/[^/]+$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a NOT_FOUND error.Note: This operation is designed
                /// to be used for building permission-aware UIs and command-line tools, not for authorization checking.
                /// This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.Dataproc.v1beta2.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+resource}:testIamPermissions";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+/workflowTemplates/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Updates (replaces) workflow template. The updated template must contain version that matches the
                /// current server version.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. The resource name of the workflow template, as described in
                /// https://cloud.google.com/apis/design/resource_names. For projects.regions.workflowTemplates, the
                /// resource name of the template has the following format:
                /// projects/{project_id}/regions/{region}/workflowTemplates/{template_id} For
                /// projects.locations.workflowTemplates, the resource name of the template has the following format:
                /// projects/{project_id}/locations/{location}/workflowTemplates/{template_id}
                /// </param>
                public virtual UpdateRequest Update(Google.Apis.Dataproc.v1beta2.Data.WorkflowTemplate body, string name)
                {
                    return new UpdateRequest(service, body, name);
                }

                /// <summary>
                /// Updates (replaces) workflow template. The updated template must contain version that matches the
                /// current server version.
                /// </summary>
                public class UpdateRequest : DataprocBaseServiceRequest<Google.Apis.Dataproc.v1beta2.Data.WorkflowTemplate>
                {
                    /// <summary>Constructs a new Update request.</summary>
                    public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataproc.v1beta2.Data.WorkflowTemplate body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. The resource name of the workflow template, as described in
                    /// https://cloud.google.com/apis/design/resource_names. For projects.regions.workflowTemplates, the
                    /// resource name of the template has the following format:
                    /// projects/{project_id}/regions/{region}/workflowTemplates/{template_id} For
                    /// projects.locations.workflowTemplates, the resource name of the template has the following
                    /// format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataproc.v1beta2.Data.WorkflowTemplate Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "update";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+name}";

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
                            Pattern = @"^projects/[^/]+/regions/[^/]+/workflowTemplates/[^/]+$",
                        });
                    }
                }
            }
        }
    }
}
namespace Google.Apis.Dataproc.v1beta2.Data
{
    /// <summary>
    /// Specifies the type and number of accelerator cards attached to the instances of an instance group (see GPUs on
    /// Compute Engine (https://cloud.google.com/compute/docs/gpus/)).
    /// </summary>
    public class AcceleratorConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of the accelerator cards of this type exposed to this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceleratorCount")]
        public virtual System.Nullable<int> AcceleratorCount { get; set; }

        /// <summary>
        /// Full URL, partial URI, or short name of the accelerator type resource to expose to this instance. See
        /// Compute Engine AcceleratorTypes
        /// (https://cloud.google.com/compute/docs/reference/beta/acceleratorTypes)Examples *
        /// https://www.googleapis.com/compute/beta/projects/[project_id]/zones/us-east1-a/acceleratorTypes/nvidia-tesla-k80
        /// * projects/[project_id]/zones/us-east1-a/acceleratorTypes/nvidia-tesla-k80 * nvidia-tesla-k80Auto Zone
        /// Exception: If you are using the Dataproc Auto Zone Placement
        /// (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement)
        /// feature, you must use the short name of the accelerator type resource, for example, nvidia-tesla-k80.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceleratorTypeUri")]
        public virtual string AcceleratorTypeUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Autoscaling Policy config associated with the cluster.</summary>
    public class AutoscalingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The autoscaling policy used by the cluster.Only resource names including projectid and location
        /// (region) are valid. Examples:
        /// https://www.googleapis.com/compute/v1/projects/[project_id]/locations/[dataproc_region]/autoscalingPolicies/[policy_id]
        /// projects/[project_id]/locations/[dataproc_region]/autoscalingPolicies/[policy_id]Note that the policy must
        /// be in the same project and Dataproc region.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyUri")]
        public virtual string PolicyUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes an autoscaling policy for Dataproc cluster autoscaler.</summary>
    public class AutoscalingPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("basicAlgorithm")]
        public virtual BasicAutoscalingAlgorithm BasicAlgorithm { get; set; }

        /// <summary>
        /// Required. The policy id.The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and
        /// hyphens (-). Cannot begin or end with underscore or hyphen. Must consist of between 3 and 50 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Output only. The "resource name" of the autoscaling policy, as described in
        /// https://cloud.google.com/apis/design/resource_names. For projects.regions.autoscalingPolicies, the resource
        /// name of the policy has the following format:
        /// projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id} For
        /// projects.locations.autoscalingPolicies, the resource name of the policy has the following format:
        /// projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Describes how the autoscaler will operate for secondary workers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryWorkerConfig")]
        public virtual InstanceGroupAutoscalingPolicyConfig SecondaryWorkerConfig { get; set; }

        /// <summary>Required. Describes how the autoscaler will operate for primary workers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerConfig")]
        public virtual InstanceGroupAutoscalingPolicyConfig WorkerConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Basic algorithm for autoscaling.</summary>
    public class BasicAutoscalingAlgorithm : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Duration between scaling events. A scaling period starts after the update operation from the
        /// previous event has completed.Bounds: 2m, 1d. Default: 2m.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cooldownPeriod")]
        public virtual object CooldownPeriod { get; set; }

        /// <summary>Optional. YARN autoscaling configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yarnConfig")]
        public virtual BasicYarnAutoscalingConfig YarnConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Basic autoscaling configurations for YARN.</summary>
    public class BasicYarnAutoscalingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Timeout for YARN graceful decommissioning of Node Managers. Specifies the duration to wait for
        /// jobs to complete before forcefully removing workers (and potentially interrupting jobs). Only applicable to
        /// downscaling operations.Bounds: 0s, 1d.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gracefulDecommissionTimeout")]
        public virtual object GracefulDecommissionTimeout { get; set; }

        /// <summary>
        /// Required. Fraction of average YARN pending memory in the last cooldown period for which to remove workers. A
        /// scale-down factor of 1 will result in scaling down so that there is no available memory remaining after the
        /// update (more aggressive scaling). A scale-down factor of 0 disables removing workers, which can be
        /// beneficial for autoscaling a single job. See How autoscaling works for more information.Bounds: 0.0, 1.0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scaleDownFactor")]
        public virtual System.Nullable<double> ScaleDownFactor { get; set; }

        /// <summary>
        /// Optional. Minimum scale-down threshold as a fraction of total cluster size before scaling occurs. For
        /// example, in a 20-worker cluster, a threshold of 0.1 means the autoscaler must recommend at least a 2 worker
        /// scale-down for the cluster to scale. A threshold of 0 means the autoscaler will scale down on any
        /// recommended change.Bounds: 0.0, 1.0. Default: 0.0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scaleDownMinWorkerFraction")]
        public virtual System.Nullable<double> ScaleDownMinWorkerFraction { get; set; }

        /// <summary>
        /// Required. Fraction of average YARN pending memory in the last cooldown period for which to add workers. A
        /// scale-up factor of 1.0 will result in scaling up so that there is no pending memory remaining after the
        /// update (more aggressive scaling). A scale-up factor closer to 0 will result in a smaller magnitude of
        /// scaling up (less aggressive scaling). See How autoscaling works for more information.Bounds: 0.0, 1.0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scaleUpFactor")]
        public virtual System.Nullable<double> ScaleUpFactor { get; set; }

        /// <summary>
        /// Optional. Minimum scale-up threshold as a fraction of total cluster size before scaling occurs. For example,
        /// in a 20-worker cluster, a threshold of 0.1 means the autoscaler must recommend at least a 2-worker scale-up
        /// for the cluster to scale. A threshold of 0 means the autoscaler will scale up on any recommended
        /// change.Bounds: 0.0, 1.0. Default: 0.0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scaleUpMinWorkerFraction")]
        public virtual System.Nullable<double> ScaleUpMinWorkerFraction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Associates members with a role.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding.If the condition evaluates to true, then this binding
        /// applies to the current request.If the condition evaluates to false, then this binding does not apply to the
        /// current request. However, a different role binding might grant the same role to one or more of the members
        /// in this binding.To learn which resources support conditions in their IAM policies, see the IAM documentation
        /// (https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// Specifies the identities requesting access for a Cloud Platform resource. members can have the following
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
        /// Role that is assigned to members. For example, roles/viewer, roles/editor, or roles/owner.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to cancel a job.</summary>
    public class CancelJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes the identifying information, config, and status of a cluster of Compute Engine instances.
    /// </summary>
    public class Cluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The cluster name. Cluster names within a project must be unique. Names of deleted clusters can be
        /// reused.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterName")]
        public virtual string ClusterName { get; set; }

        /// <summary>
        /// Output only. A cluster UUID (Unique Universal Identifier). Dataproc generates this value when it creates the
        /// cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterUuid")]
        public virtual string ClusterUuid { get; set; }

        /// <summary>
        /// Required. The cluster config. Note that Dataproc may set default values, and values may change when clusters
        /// are updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual ClusterConfig Config { get; set; }

        /// <summary>
        /// Optional. The labels to associate with this cluster. Label keys must contain 1 to 63 characters, and must
        /// conform to RFC 1035 (https://www.ietf.org/rfc/rfc1035.txt). Label values may be empty, but, if present, must
        /// contain 1 to 63 characters, and must conform to RFC 1035 (https://www.ietf.org/rfc/rfc1035.txt). No more
        /// than 32 labels can be associated with a cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. Contains cluster daemon metrics such as HDFS and YARN stats.Beta Feature: This report is
        /// available for testing purposes only. It may be changed before final release.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual ClusterMetrics Metrics { get; set; }

        /// <summary>Required. The Google Cloud Platform project ID that the cluster belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Output only. Cluster status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ClusterStatus Status { get; set; }

        /// <summary>Output only. The previous cluster status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusHistory")]
        public virtual System.Collections.Generic.IList<ClusterStatus> StatusHistory { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The cluster config.</summary>
    public class ClusterConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Autoscaling config for the policy associated with the cluster. Cluster does not autoscale if this
        /// field is unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoscalingConfig")]
        public virtual AutoscalingConfig AutoscalingConfig { get; set; }

        /// <summary>
        /// Optional. A Cloud Storage bucket used to stage job dependencies, config files, and job driver console
        /// output. If you do not specify a staging bucket, Cloud Dataproc will determine a Cloud Storage location (US,
        /// ASIA, or EU) for your cluster's staging bucket according to the Compute Engine zone where your cluster is
        /// deployed, and then create and manage this project-level, per-location bucket (see Dataproc staging bucket
        /// (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/staging-bucket)). This field requires
        /// a Cloud Storage bucket name, not a URI to a Cloud Storage bucket.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configBucket")]
        public virtual string ConfigBucket { get; set; }

        /// <summary>Optional. Encryption settings for the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionConfig")]
        public virtual EncryptionConfig EncryptionConfig { get; set; }

        /// <summary>Optional. Port/endpoint configuration for this cluster</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointConfig")]
        public virtual EndpointConfig EndpointConfig { get; set; }

        /// <summary>Optional. The shared Compute Engine config settings for all instances in a cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gceClusterConfig")]
        public virtual GceClusterConfig GceClusterConfig { get; set; }

        /// <summary>
        /// Optional. The Kubernetes Engine config for Dataproc clusters deployed to Kubernetes. Setting this is
        /// considered mutually exclusive with Compute Engine-based options such as gce_cluster_config, master_config,
        /// worker_config, secondary_worker_config, and autoscaling_config.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gkeClusterConfig")]
        public virtual GkeClusterConfig GkeClusterConfig { get; set; }

        /// <summary>
        /// Optional. Commands to execute on each node after config is completed. By default, executables are run on
        /// master and all worker nodes. You can test a node's role metadata to run an executable on a master or worker
        /// node, as shown below using curl (you can also use wget): ROLE=$(curl -H Metadata-Flavor:Google
        /// http://metadata/computeMetadata/v1beta2/instance/attributes/dataproc-role) if [[ "${ROLE}" == 'Master' ]];
        /// then ... master specific actions ... else ... worker specific actions ... fi
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initializationActions")]
        public virtual System.Collections.Generic.IList<NodeInitializationAction> InitializationActions { get; set; }

        /// <summary>Optional. The config setting for auto delete cluster schedule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycleConfig")]
        public virtual LifecycleConfig LifecycleConfig { get; set; }

        /// <summary>Optional. The Compute Engine config settings for the master instance in a cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("masterConfig")]
        public virtual InstanceGroupConfig MasterConfig { get; set; }

        /// <summary>Optional. Metastore configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metastoreConfig")]
        public virtual MetastoreConfig MetastoreConfig { get; set; }

        /// <summary>
        /// Optional. The Compute Engine config settings for additional worker instances in a cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryWorkerConfig")]
        public virtual InstanceGroupConfig SecondaryWorkerConfig { get; set; }

        /// <summary>Optional. Security related configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityConfig")]
        public virtual SecurityConfig SecurityConfig { get; set; }

        /// <summary>Optional. The config settings for software inside the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("softwareConfig")]
        public virtual SoftwareConfig SoftwareConfig { get; set; }

        /// <summary>
        /// Optional. A Cloud Storage bucket used to store ephemeral cluster and jobs data, such as Spark and MapReduce
        /// history files. If you do not specify a temp bucket, Dataproc will determine a Cloud Storage location (US,
        /// ASIA, or EU) for your cluster's temp bucket according to the Compute Engine zone where your cluster is
        /// deployed, and then create and manage this project-level, per-location bucket. The default bucket has a TTL
        /// of 90 days, but you can use any TTL (or none) if you specify a bucket. This field requires a Cloud Storage
        /// bucket name, not a URI to a Cloud Storage bucket.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tempBucket")]
        public virtual string TempBucket { get; set; }

        /// <summary>Optional. The Compute Engine config settings for worker instances in a cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerConfig")]
        public virtual InstanceGroupConfig WorkerConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains cluster daemon metrics, such as HDFS and YARN stats.Beta Feature: This report is available for testing
    /// purposes only. It may be changed before final release.
    /// </summary>
    public class ClusterMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The HDFS metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hdfsMetrics")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<long>> HdfsMetrics { get; set; }

        /// <summary>The YARN metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yarnMetrics")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<long>> YarnMetrics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The cluster operation triggered by a workflow.</summary>
    public class ClusterOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Indicates the operation is done.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>Output only. Error, if operation failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual string Error { get; set; }

        /// <summary>Output only. The id of the cluster operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata describing the operation.</summary>
    public class ClusterOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Name of the cluster for the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterName")]
        public virtual string ClusterName { get; set; }

        /// <summary>Output only. Cluster UUID for the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterUuid")]
        public virtual string ClusterUuid { get; set; }

        /// <summary>Output only. Short description of operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. Labels associated with the operation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. The operation type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationType")]
        public virtual string OperationType { get; set; }

        /// <summary>Output only. Current operation status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ClusterOperationStatus Status { get; set; }

        /// <summary>Output only. The previous operation status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusHistory")]
        public virtual System.Collections.Generic.IList<ClusterOperationStatus> StatusHistory { get; set; }

        /// <summary>Output only. Errors encountered during operation execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<string> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of the operation.</summary>
    public class ClusterOperationStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. A message containing any operation metadata details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual string Details { get; set; }

        /// <summary>Output only. A message containing the detailed operation state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("innerState")]
        public virtual string InnerState { get; set; }

        /// <summary>Output only. A message containing the operation state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. The time this state was entered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateStartTime")]
        public virtual object StateStartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A selector that chooses target cluster for jobs based on metadata.</summary>
    public class ClusterSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The cluster labels. Cluster must have all labels to match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> ClusterLabels { get; set; }

        /// <summary>
        /// Optional. The zone where workflow process executes. This parameter does not affect the selection of the
        /// cluster.If unspecified, the zone of the first cluster matching the selector is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of a cluster and its instances.</summary>
    public class ClusterStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Optional details of cluster's state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual string Detail { get; set; }

        /// <summary>Output only. The cluster's state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. Time when this state was entered (see JSON representation of Timestamp
        /// (https://developers.google.com/protocol-buffers/docs/proto3#json)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateStartTime")]
        public virtual object StateStartTime { get; set; }

        /// <summary>Output only. Additional state information that includes status reported by the agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("substate")]
        public virtual string Substate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to collect cluster diagnostic information.</summary>
    public class DiagnoseClusterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The location of diagnostic output.</summary>
    public class DiagnoseClusterResults : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The Cloud Storage URI of the diagnostic output. The output report is a plain text file with a
        /// summary of collected diagnostics.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputUri")]
        public virtual string OutputUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the config of disk options for a group of VM instances.</summary>
    public class DiskConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Size in GB of the boot disk (default is 500GB).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootDiskSizeGb")]
        public virtual System.Nullable<int> BootDiskSizeGb { get; set; }

        /// <summary>
        /// Optional. Type of the boot disk (default is "pd-standard"). Valid values: "pd-balanced" (Persistent Disk
        /// Balanced Solid State Drive), "pd-ssd" (Persistent Disk Solid State Drive), or "pd-standard" (Persistent Disk
        /// Hard Disk Drive). See Disk types (https://cloud.google.com/compute/docs/disks#disk-types).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootDiskType")]
        public virtual string BootDiskType { get; set; }

        /// <summary>
        /// Number of attached SSDs, from 0 to 4 (default is 0). If SSDs are not attached, the boot disk is used to
        /// store runtime logs and HDFS (https://hadoop.apache.org/docs/r1.2.1/hdfs_user_guide.html) data. If one or
        /// more SSDs are attached, this runtime bulk data is spread across them, and the boot disk contains only basic
        /// config and installed binaries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numLocalSsds")]
        public virtual System.Nullable<int> NumLocalSsds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

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

    /// <summary>Encryption settings for the cluster.</summary>
    public class EncryptionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The Cloud KMS key name to use for PD disk encryption for all instances in the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcePdKmsKeyName")]
        public virtual string GcePdKmsKeyName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Endpoint config for this cluster</summary>
    public class EndpointConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If true, enable http access to specific ports on the cluster from external sources. Defaults to
        /// false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableHttpPortAccess")]
        public virtual System.Nullable<bool> EnableHttpPortAccess { get; set; }

        /// <summary>
        /// Output only. The map of port descriptions to URLs. Will only be populated if enable_http_port_access is
        /// true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpPorts")]
        public virtual System.Collections.Generic.IDictionary<string, string> HttpPorts { get; set; }

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

    /// <summary>
    /// Common config settings for resources of Compute Engine cluster instances, applicable to all instances in the
    /// cluster.
    /// </summary>
    public class GceClusterConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If true, all instances in the cluster will only have internal IP addresses. By default, clusters
        /// are not restricted to internal IP addresses, and will have ephemeral external IP addresses assigned to each
        /// instance. This internal_ip_only restriction can only be enabled for subnetwork enabled networks, and all
        /// off-cluster dependencies must be configured to be accessible without external IP addresses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalIpOnly")]
        public virtual System.Nullable<bool> InternalIpOnly { get; set; }

        /// <summary>
        /// The Compute Engine metadata entries to add to all instances (see Project and instance metadata
        /// (https://cloud.google.com/compute/docs/storing-retrieving-metadata#project_and_instance_metadata)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Optional. The Compute Engine network to be used for machine communications. Cannot be specified with
        /// subnetwork_uri. If neither network_uri nor subnetwork_uri is specified, the "default" network of the project
        /// is used, if it exists. Cannot be a "Custom Subnet Network" (see Using Subnetworks
        /// (https://cloud.google.com/compute/docs/subnetworks) for more information).A full URL, partial URI, or short
        /// name are valid. Examples: https://www.googleapis.com/compute/v1/projects/[project_id]/regions/global/default
        /// projects/[project_id]/regions/global/default default
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUri")]
        public virtual string NetworkUri { get; set; }

        /// <summary>Optional. Node Group Affinity for sole-tenant clusters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeGroupAffinity")]
        public virtual NodeGroupAffinity NodeGroupAffinity { get; set; }

        /// <summary>Optional. The type of IPv6 access for a cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateIpv6GoogleAccess")]
        public virtual string PrivateIpv6GoogleAccess { get; set; }

        /// <summary>Optional. Reservation Affinity for consuming Zonal reservation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservationAffinity")]
        public virtual ReservationAffinity ReservationAffinity { get; set; }

        /// <summary>
        /// Optional. The Dataproc service account
        /// (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/service-accounts#service_accounts_in_dataproc)
        /// (also see VM Data Plane identity
        /// (https://cloud.google.com/dataproc/docs/concepts/iam/dataproc-principals#vm_service_account_data_plane_identity))
        /// used by Dataproc cluster VM instances to access Google Cloud Platform services.If not specified, the Compute
        /// Engine default service account
        /// (https://cloud.google.com/compute/docs/access/service-accounts#default_service_account) is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>
        /// Optional. The URIs of service account scopes to be included in Compute Engine instances. The following base
        /// set of scopes is always included: https://www.googleapis.com/auth/cloud.useraccounts.readonly
        /// https://www.googleapis.com/auth/devstorage.read_write https://www.googleapis.com/auth/logging.writeIf no
        /// scopes are specified, the following defaults are also provided: https://www.googleapis.com/auth/bigquery
        /// https://www.googleapis.com/auth/bigtable.admin.table https://www.googleapis.com/auth/bigtable.data
        /// https://www.googleapis.com/auth/devstorage.full_control
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountScopes")]
        public virtual System.Collections.Generic.IList<string> ServiceAccountScopes { get; set; }

        /// <summary>
        /// Optional. Shielded Instance Config for clusters using Compute Engine Shielded VMs
        /// (https://cloud.google.com/security/shielded-cloud/shielded-vm).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shieldedInstanceConfig")]
        public virtual ShieldedInstanceConfig ShieldedInstanceConfig { get; set; }

        /// <summary>
        /// Optional. The Compute Engine subnetwork to be used for machine communications. Cannot be specified with
        /// network_uri.A full URL, partial URI, or short name are valid. Examples:
        /// https://www.googleapis.com/compute/v1/projects/[project_id]/regions/us-east1/subnetworks/sub0
        /// projects/[project_id]/regions/us-east1/subnetworks/sub0 sub0
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetworkUri")]
        public virtual string SubnetworkUri { get; set; }

        /// <summary>
        /// The Compute Engine tags to add to all instances (see Tagging instances
        /// (https://cloud.google.com/compute/docs/label-or-tag-resources#tags)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Optional. The zone where the Compute Engine cluster will be located. On a create request, it is required in
        /// the "global" region. If omitted in a non-global Dataproc region, the service will pick a zone in the
        /// corresponding Compute Engine region. On a get request, zone will always be present.A full URL, partial URI,
        /// or short name are valid. Examples: https://www.googleapis.com/compute/v1/projects/[project_id]/zones/[zone]
        /// projects/[project_id]/zones/[zone] us-central1-f
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zoneUri")]
        public virtual string ZoneUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for GetIamPolicy method.</summary>
    public class GetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>OPTIONAL: A GetPolicyOptions object for specifying options to GetIamPolicy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual GetPolicyOptions Options { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates settings provided to GetIamPolicy.</summary>
    public class GetPolicyOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The policy format version to be returned.Valid values are 0, 1, and 3. Requests specifying an
        /// invalid value will be rejected.Requests for policies with any conditional bindings must specify version 3.
        /// Policies without any conditional bindings may specify any valid value or leave the field unset.To learn
        /// which resources support conditions in their IAM policies, see the IAM documentation
        /// (https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedPolicyVersion")]
        public virtual System.Nullable<int> RequestedPolicyVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The GKE config for this cluster.</summary>
    public class GkeClusterConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A target for the deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespacedGkeDeploymentTarget")]
        public virtual NamespacedGkeDeploymentTarget NamespacedGkeDeploymentTarget { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Dataproc job for running Apache Hadoop MapReduce
    /// (https://hadoop.apache.org/docs/current/hadoop-mapreduce-client/hadoop-mapreduce-client-core/MapReduceTutorial.html)
    /// jobs on Apache Hadoop YARN (https://hadoop.apache.org/docs/r2.7.1/hadoop-yarn/hadoop-yarn-site/YARN.html).
    /// </summary>
    public class HadoopJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. HCFS URIs of archives to be extracted in the working directory of Hadoop drivers and tasks.
        /// Supported file types: .jar, .tar, .tar.gz, .tgz, or .zip.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("archiveUris")]
        public virtual System.Collections.Generic.IList<string> ArchiveUris { get; set; }

        /// <summary>
        /// Optional. The arguments to pass to the driver. Do not include arguments, such as -libjars or -Dfoo=bar, that
        /// can be set as job properties, since a collision may occur that causes an incorrect job submission.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>
        /// Optional. HCFS (Hadoop Compatible Filesystem) URIs of files to be copied to the working directory of Hadoop
        /// drivers and distributed tasks. Useful for naively parallel tasks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileUris")]
        public virtual System.Collections.Generic.IList<string> FileUris { get; set; }

        /// <summary>Optional. Jar file URIs to add to the CLASSPATHs of the Hadoop driver and tasks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jarFileUris")]
        public virtual System.Collections.Generic.IList<string> JarFileUris { get; set; }

        /// <summary>Optional. The runtime log config for job execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loggingConfig")]
        public virtual LoggingConfig LoggingConfig { get; set; }

        /// <summary>
        /// The name of the driver's main class. The jar file containing the class must be in the default CLASSPATH or
        /// specified in jar_file_uris.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mainClass")]
        public virtual string MainClass { get; set; }

        /// <summary>
        /// The HCFS URI of the jar file containing the main class. Examples:
        /// 'gs://foo-bucket/analytics-binaries/extract-useful-metrics-mr.jar'
        /// 'hdfs:/tmp/test-samples/custom-wordcount.jar'
        /// 'file:///home/usr/lib/hadoop-mapreduce/hadoop-mapreduce-examples.jar'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mainJarFileUri")]
        public virtual string MainJarFileUri { get; set; }

        /// <summary>
        /// Optional. A mapping of property names to values, used to configure Hadoop. Properties that conflict with
        /// values set by the Dataproc API may be overwritten. Can include properties set in /etc/hadoop/conf/*-site and
        /// classes in user code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, string> Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Dataproc job for running Apache Hive (https://hive.apache.org/) queries on YARN.</summary>
    public class HiveJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Whether to continue executing queries if a query fails. The default value is false. Setting to
        /// true can be useful when executing independent parallel queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("continueOnFailure")]
        public virtual System.Nullable<bool> ContinueOnFailure { get; set; }

        /// <summary>
        /// Optional. HCFS URIs of jar files to add to the CLASSPATH of the Hive server and Hadoop MapReduce (MR) tasks.
        /// Can contain Hive SerDes and UDFs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jarFileUris")]
        public virtual System.Collections.Generic.IList<string> JarFileUris { get; set; }

        /// <summary>
        /// Optional. A mapping of property names and values, used to configure Hive. Properties that conflict with
        /// values set by the Dataproc API may be overwritten. Can include properties set in
        /// /etc/hadoop/conf/*-site.xml, /etc/hive/conf/hive-site.xml, and classes in user code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, string> Properties { get; set; }

        /// <summary>The HCFS URI of the script that contains Hive queries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryFileUri")]
        public virtual string QueryFileUri { get; set; }

        /// <summary>A list of queries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryList")]
        public virtual QueryList QueryList { get; set; }

        /// <summary>
        /// Optional. Mapping of query variable names to values (equivalent to the Hive command: SET name="value";).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scriptVariables")]
        public virtual System.Collections.Generic.IDictionary<string, string> ScriptVariables { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to inject credentials into a cluster.</summary>
    public class InjectCredentialsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The cluster UUID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterUuid")]
        public virtual string ClusterUuid { get; set; }

        /// <summary>
        /// Required. The encrypted credentials being injected in to the cluster.The client is responsible for
        /// encrypting the credentials in a way that is supported by the cluster.A wrapped value is used here so that
        /// the actual contents of the encrypted credentials are not written to audit logs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("credentialsCiphertext")]
        public virtual string CredentialsCiphertext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for the size bounds of an instance group, including its proportional size to other groups.
    /// </summary>
    public class InstanceGroupAutoscalingPolicyConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Maximum number of instances for this group. Required for primary workers. Note that by default,
        /// clusters will not use secondary workers. Required for secondary workers if the minimum secondary instances
        /// is set.Primary workers - Bounds: [min_instances, ). Required. Secondary workers - Bounds: [min_instances, ).
        /// Default: 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxInstances")]
        public virtual System.Nullable<int> MaxInstances { get; set; }

        /// <summary>
        /// Optional. Minimum number of instances for this group.Primary workers - Bounds: 2, max_instances. Default: 2.
        /// Secondary workers - Bounds: 0, max_instances. Default: 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minInstances")]
        public virtual System.Nullable<int> MinInstances { get; set; }

        /// <summary>
        /// Optional. Weight for the instance group, which is used to determine the fraction of total workers in the
        /// cluster from this instance group. For example, if primary workers have weight 2, and secondary workers have
        /// weight 1, the cluster will have approximately 2 primary workers for each secondary worker.The cluster may
        /// not reach the specified balance if constrained by min/max bounds or other autoscaling settings. For example,
        /// if max_instances for secondary workers is 0, then only primary workers will be added. The cluster can also
        /// be out of balance when created.If weight is not set on any instance group, the cluster will default to equal
        /// weight for all groups: the cluster will attempt to maintain an equal number of workers in each group within
        /// the configured size bounds for each group. If weight is set for one group only, the cluster will default to
        /// zero weight on the unset group. For example if weight is set only on primary workers, the cluster will use
        /// primary workers only and no secondary workers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weight")]
        public virtual System.Nullable<int> Weight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The config settings for Compute Engine resources in an instance group, such as a master or worker group.
    /// </summary>
    public class InstanceGroupConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The Compute Engine accelerator configuration for these instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accelerators")]
        public virtual System.Collections.Generic.IList<AcceleratorConfig> Accelerators { get; set; }

        /// <summary>Optional. Disk option config settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskConfig")]
        public virtual DiskConfig DiskConfig { get; set; }

        /// <summary>
        /// Optional. The Compute Engine image resource used for cluster instances.The URI can represent an image or
        /// image family.Image examples:
        /// https://www.googleapis.com/compute/beta/projects/[project_id]/global/images/[image-id]
        /// projects/[project_id]/global/images/[image-id] image-idImage family examples. Dataproc will use the most
        /// recent image from the family:
        /// https://www.googleapis.com/compute/beta/projects/[project_id]/global/images/family/[custom-image-family-name]
        /// projects/[project_id]/global/images/family/[custom-image-family-name]If the URI is unspecified, it will be
        /// inferred from SoftwareConfig.image_version or the system default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; }

        /// <summary>
        /// Output only. The list of instance names. Dataproc derives the names from cluster_name, num_instances, and
        /// the instance group.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceNames")]
        public virtual System.Collections.Generic.IList<string> InstanceNames { get; set; }

        /// <summary>Output only. List of references to Compute Engine instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceReferences")]
        public virtual System.Collections.Generic.IList<InstanceReference> InstanceReferences { get; set; }

        /// <summary>Output only. Specifies that this instance group contains preemptible instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPreemptible")]
        public virtual System.Nullable<bool> IsPreemptible { get; set; }

        /// <summary>
        /// Optional. The Compute Engine machine type used for cluster instances.A full URL, partial URI, or short name
        /// are valid. Examples:
        /// https://www.googleapis.com/compute/v1/projects/[project_id]/zones/us-east1-a/machineTypes/n1-standard-2
        /// projects/[project_id]/zones/us-east1-a/machineTypes/n1-standard-2 n1-standard-2Auto Zone Exception: If you
        /// are using the Dataproc Auto Zone Placement
        /// (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement)
        /// feature, you must use the short name of the machine type resource, for example, n1-standard-2.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineTypeUri")]
        public virtual string MachineTypeUri { get; set; }

        /// <summary>
        /// Output only. The config for Compute Engine Instance Group Manager that manages this group. This is only used
        /// for preemptible instance groups.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedGroupConfig")]
        public virtual ManagedGroupConfig ManagedGroupConfig { get; set; }

        /// <summary>
        /// Specifies the minimum cpu platform for the Instance Group. See Dataproc -&amp;gt; Minimum CPU Platform
        /// (https://cloud.google.com/dataproc/docs/concepts/compute/dataproc-min-cpu).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minCpuPlatform")]
        public virtual string MinCpuPlatform { get; set; }

        /// <summary>
        /// Optional. The number of VM instances in the instance group. For HA cluster master_config groups, must be set
        /// to 3. For standard cluster master_config groups, must be set to 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numInstances")]
        public virtual System.Nullable<int> NumInstances { get; set; }

        /// <summary>
        /// Optional. Specifies the preemptibility of the instance group.The default value for master and worker groups
        /// is NON_PREEMPTIBLE. This default cannot be changed.The default value for secondary instances is PREEMPTIBLE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preemptibility")]
        public virtual string Preemptibility { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reference to a Compute Engine instance.</summary>
    public class InstanceReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unique identifier of the Compute Engine instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceId")]
        public virtual string InstanceId { get; set; }

        /// <summary>The user-friendly name of the Compute Engine instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceName")]
        public virtual string InstanceName { get; set; }

        /// <summary>The public key used for sharing data with this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKey")]
        public virtual string PublicKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to instantiate a workflow template.</summary>
    public class InstantiateWorkflowTemplateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deprecated. Please use request_id field instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceId")]
        public virtual string InstanceId { get; set; }

        /// <summary>
        /// Optional. Map from parameter names to values that should be used for those parameters. Values may not exceed
        /// 1000 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Optional. A tag that prevents multiple concurrent workflow instances with the same tag from running. This
        /// mitigates risk of concurrent instances started due to retries.It is recommended to always set this value to
        /// a UUID (https://en.wikipedia.org/wiki/Universally_unique_identifier).The tag must contain only letters (a-z,
        /// A-Z), numbers (0-9), underscores (_), and hyphens (-). The maximum length is 40 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>
        /// Optional. The version of workflow template to instantiate. If specified, the workflow will be instantiated
        /// only if the current version of the workflow template has the supplied version.This option cannot be used to
        /// instantiate a previous version of workflow template.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Dataproc job resource.</summary>
    public class Job : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Indicates whether the job is completed. If the value is false, the job is still in progress. If
        /// true, the job is completed, and status.state field will indicate if it was successful, failed, or cancelled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>
        /// Output only. If present, the location of miscellaneous control files which may be used as part of job setup
        /// and handling. If not present, control files may be placed in the same location as driver_output_uri.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driverControlFilesUri")]
        public virtual string DriverControlFilesUri { get; set; }

        /// <summary>Output only. A URI pointing to the location of the stdout of the job's driver program.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driverOutputResourceUri")]
        public virtual string DriverOutputResourceUri { get; set; }

        /// <summary>Optional. Job is a Hadoop job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hadoopJob")]
        public virtual HadoopJob HadoopJob { get; set; }

        /// <summary>Optional. Job is a Hive job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hiveJob")]
        public virtual HiveJob HiveJob { get; set; }

        /// <summary>
        /// Output only. A UUID that uniquely identifies a job within the project over time. This is in contrast to a
        /// user-settable reference.job_id that may be reused over time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobUuid")]
        public virtual string JobUuid { get; set; }

        /// <summary>
        /// Optional. The labels to associate with this job. Label keys must contain 1 to 63 characters, and must
        /// conform to RFC 1035 (https://www.ietf.org/rfc/rfc1035.txt). Label values may be empty, but, if present, must
        /// contain 1 to 63 characters, and must conform to RFC 1035 (https://www.ietf.org/rfc/rfc1035.txt). No more
        /// than 32 labels can be associated with a job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Optional. Job is a Pig job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pigJob")]
        public virtual PigJob PigJob { get; set; }

        /// <summary>Required. Job information, including how, when, and where to run the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placement")]
        public virtual JobPlacement Placement { get; set; }

        /// <summary>Optional. Job is a Presto job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prestoJob")]
        public virtual PrestoJob PrestoJob { get; set; }

        /// <summary>Optional. Job is a PySpark job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pysparkJob")]
        public virtual PySparkJob PysparkJob { get; set; }

        /// <summary>
        /// Optional. The fully qualified reference to the job, which can be used to obtain the equivalent REST path of
        /// the job resource. If this property is not specified when a job is created, the server generates a job_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reference")]
        public virtual JobReference Reference { get; set; }

        /// <summary>Optional. Job scheduling configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduling")]
        public virtual JobScheduling Scheduling { get; set; }

        /// <summary>Optional. Job is a Spark job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sparkJob")]
        public virtual SparkJob SparkJob { get; set; }

        /// <summary>Optional. Job is a SparkR job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sparkRJob")]
        public virtual SparkRJob SparkRJob { get; set; }

        /// <summary>Optional. Job is a SparkSql job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sparkSqlJob")]
        public virtual SparkSqlJob SparkSqlJob { get; set; }

        /// <summary>
        /// Output only. The job status. Additional application-specific status information may be contained in the
        /// type_job and yarn_applications fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual JobStatus Status { get; set; }

        /// <summary>Output only. The previous job status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusHistory")]
        public virtual System.Collections.Generic.IList<JobStatus> StatusHistory { get; set; }

        /// <summary>
        /// Output only. The email address of the user submitting the job. For jobs submitted on the cluster, the
        /// address is username@hostname.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("submittedBy")]
        public virtual string SubmittedBy { get; set; }

        /// <summary>
        /// Output only. The collection of YARN applications spun up by this job.Beta Feature: This report is available
        /// for testing purposes only. It may be changed before final release.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yarnApplications")]
        public virtual System.Collections.Generic.IList<YarnApplication> YarnApplications { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Job Operation metadata.</summary>
    public class JobMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The job id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobId")]
        public virtual string JobId { get; set; }

        /// <summary>Output only. Operation type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationType")]
        public virtual string OperationType { get; set; }

        /// <summary>Output only. Job submission time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>Output only. Most recent job status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual JobStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Dataproc job config.</summary>
    public class JobPlacement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Cluster labels to identify a cluster where the job will be submitted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> ClusterLabels { get; set; }

        /// <summary>Required. The name of the cluster where the job will be submitted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterName")]
        public virtual string ClusterName { get; set; }

        /// <summary>Output only. A cluster UUID generated by the Dataproc service when the job is submitted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterUuid")]
        public virtual string ClusterUuid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates the full scoping used to reference a job.</summary>
    public class JobReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The job ID, which must be unique within the project. The ID must contain only letters (a-z, A-Z),
        /// numbers (0-9), underscores (_), or hyphens (-). The maximum length is 100 characters.If not specified by the
        /// caller, the job ID will be provided by the server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobId")]
        public virtual string JobId { get; set; }

        /// <summary>
        /// Optional. The ID of the Google Cloud Platform project that the job belongs to. If specified, must match the
        /// request project ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Job scheduling options.</summary>
    public class JobScheduling : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Maximum number of times per hour a driver may be restarted as a result of driver terminating with
        /// non-zero code before job is reported failed.A job may be reported as thrashing if driver exits with non-zero
        /// code 4 times within 10 minute window.Maximum value is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxFailuresPerHour")]
        public virtual System.Nullable<int> MaxFailuresPerHour { get; set; }

        /// <summary>
        /// Optional. Maximum number of times in total a driver may be restarted as a result of driver exiting with
        /// non-zero code before job is reported failed. Maximum value is 240.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxFailuresTotal")]
        public virtual System.Nullable<int> MaxFailuresTotal { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Dataproc job status.</summary>
    public class JobStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Optional Job state details, such as an error description if the state is ERROR.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual string Details { get; set; }

        /// <summary>Output only. A state message specifying the overall job state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. The time when this state was entered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateStartTime")]
        public virtual object StateStartTime { get; set; }

        /// <summary>Output only. Additional state information, which includes status reported by the agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("substate")]
        public virtual string Substate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies Kerberos related configuration.</summary>
    public class KerberosConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The admin server (IP or hostname) for the remote trusted realm in a cross realm trust
        /// relationship.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crossRealmTrustAdminServer")]
        public virtual string CrossRealmTrustAdminServer { get; set; }

        /// <summary>
        /// Optional. The KDC (IP or hostname) for the remote trusted realm in a cross realm trust relationship.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crossRealmTrustKdc")]
        public virtual string CrossRealmTrustKdc { get; set; }

        /// <summary>
        /// Optional. The remote realm the Dataproc on-cluster KDC will trust, should the user enable cross realm trust.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crossRealmTrustRealm")]
        public virtual string CrossRealmTrustRealm { get; set; }

        /// <summary>
        /// Optional. The Cloud Storage URI of a KMS encrypted file containing the shared password between the
        /// on-cluster Kerberos realm and the remote trusted realm, in a cross realm trust relationship.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crossRealmTrustSharedPasswordUri")]
        public virtual string CrossRealmTrustSharedPasswordUri { get; set; }

        /// <summary>
        /// Optional. Flag to indicate whether to Kerberize the cluster (default: false). Set this field to true to
        /// enable Kerberos on a cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableKerberos")]
        public virtual System.Nullable<bool> EnableKerberos { get; set; }

        /// <summary>
        /// Optional. The Cloud Storage URI of a KMS encrypted file containing the master key of the KDC database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kdcDbKeyUri")]
        public virtual string KdcDbKeyUri { get; set; }

        /// <summary>
        /// Optional. The Cloud Storage URI of a KMS encrypted file containing the password to the user provided key.
        /// For the self-signed certificate, this password is generated by Dataproc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyPasswordUri")]
        public virtual string KeyPasswordUri { get; set; }

        /// <summary>
        /// Optional. The Cloud Storage URI of a KMS encrypted file containing the password to the user provided
        /// keystore. For the self-signed certificate, this password is generated by Dataproc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keystorePasswordUri")]
        public virtual string KeystorePasswordUri { get; set; }

        /// <summary>
        /// Optional. The Cloud Storage URI of the keystore file used for SSL encryption. If not provided, Dataproc will
        /// provide a self-signed certificate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keystoreUri")]
        public virtual string KeystoreUri { get; set; }

        /// <summary>Optional. The uri of the KMS key used to encrypt various sensitive files.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyUri")]
        public virtual string KmsKeyUri { get; set; }

        /// <summary>
        /// Optional. The name of the on-cluster Kerberos realm. If not specified, the uppercased domain of hostnames
        /// will be the realm.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("realm")]
        public virtual string Realm { get; set; }

        /// <summary>
        /// Optional. The Cloud Storage URI of a KMS encrypted file containing the root principal password.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootPrincipalPasswordUri")]
        public virtual string RootPrincipalPasswordUri { get; set; }

        /// <summary>
        /// Optional. The lifetime of the ticket granting ticket, in hours. If not specified, or user specifies 0, then
        /// default value 10 will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tgtLifetimeHours")]
        public virtual System.Nullable<int> TgtLifetimeHours { get; set; }

        /// <summary>
        /// Optional. The Cloud Storage URI of a KMS encrypted file containing the password to the user provided
        /// truststore. For the self-signed certificate, this password is generated by Dataproc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("truststorePasswordUri")]
        public virtual string TruststorePasswordUri { get; set; }

        /// <summary>
        /// Optional. The Cloud Storage URI of the truststore file used for SSL encryption. If not provided, Dataproc
        /// will provide a self-signed certificate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("truststoreUri")]
        public virtual string TruststoreUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the cluster auto-delete schedule configuration.</summary>
    public class LifecycleConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The time when cluster will be auto-deleted. (see JSON representation of Timestamp
        /// (https://developers.google.com/protocol-buffers/docs/proto3#json)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoDeleteTime")]
        public virtual object AutoDeleteTime { get; set; }

        /// <summary>
        /// Optional. The lifetime duration of cluster. The cluster will be auto-deleted at the end of this period.
        /// Minimum value is 10 minutes; maximum value is 14 days (see JSON representation of Duration
        /// (https://developers.google.com/protocol-buffers/docs/proto3#json)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoDeleteTtl")]
        public virtual object AutoDeleteTtl { get; set; }

        /// <summary>
        /// Optional. The duration to keep the cluster alive while idling (when no jobs are running). Passing this
        /// threshold will cause the cluster to be deleted. Minimum value is 5 minutes; maximum value is 14 days (see
        /// JSON representation of Duration (https://developers.google.com/protocol-buffers/docs/proto3#json)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idleDeleteTtl")]
        public virtual object IdleDeleteTtl { get; set; }

        /// <summary>
        /// Output only. The time when cluster became idle (most recent job finished) and became eligible for deletion
        /// due to idleness (see JSON representation of Timestamp
        /// (https://developers.google.com/protocol-buffers/docs/proto3#json)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idleStartTime")]
        public virtual object IdleStartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response to a request to list autoscaling policies in a project.</summary>
    public class ListAutoscalingPoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. This token is included in the response if there are more results to fetch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Output only. Autoscaling policies list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policies")]
        public virtual System.Collections.Generic.IList<AutoscalingPolicy> Policies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The list of all clusters in a project.</summary>
    public class ListClustersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The clusters in the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusters")]
        public virtual System.Collections.Generic.IList<Cluster> Clusters { get; set; }

        /// <summary>
        /// Output only. This token is included in the response if there are more results to fetch. To fetch additional
        /// results, provide this value as the page_token in a subsequent ListClustersRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of jobs in a project.</summary>
    public class ListJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Jobs list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobs")]
        public virtual System.Collections.Generic.IList<Job> Jobs { get; set; }

        /// <summary>
        /// Optional. This token is included in the response if there are more results to fetch. To fetch additional
        /// results, provide this value as the page_token in a subsequent ListJobsRequest.
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

    /// <summary>A response to a request to list workflow templates in a project.</summary>
    public class ListWorkflowTemplatesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. This token is included in the response if there are more results to fetch. To fetch additional
        /// results, provide this value as the page_token in a subsequent ListWorkflowTemplatesRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Output only. WorkflowTemplates list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("templates")]
        public virtual System.Collections.Generic.IList<WorkflowTemplate> Templates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The runtime logging config of the job.</summary>
    public class LoggingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The per-package log levels for the driver. This may include "root" package name to configure rootLogger.
        /// Examples: 'com.google = FATAL', 'root = INFO', 'org.apache = DEBUG'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driverLogLevels")]
        public virtual System.Collections.Generic.IDictionary<string, string> DriverLogLevels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cluster that is managed by the workflow.</summary>
    public class ManagedCluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The cluster name prefix. A unique cluster name will be formed by appending a random suffix.The
        /// name must contain only lower-case letters (a-z), numbers (0-9), and hyphens (-). Must begin with a letter.
        /// Cannot begin or end with hyphen. Must consist of between 2 and 35 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterName")]
        public virtual string ClusterName { get; set; }

        /// <summary>Required. The cluster configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual ClusterConfig Config { get; set; }

        /// <summary>
        /// Optional. The labels to associate with this cluster.Label keys must be between 1 and 63 characters long, and
        /// must conform to the following PCRE regular expression: \p{Ll}\p{Lo}{0,62}Label values must be between 1 and
        /// 63 characters long, and must conform to the following PCRE regular expression: \p{Ll}\p{Lo}\p{N}_-{0,63}No
        /// more than 32 labels can be associated with a given cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the resources used to actively manage an instance group.</summary>
    public class ManagedGroupConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The name of the Instance Group Manager for this group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceGroupManagerName")]
        public virtual string InstanceGroupManagerName { get; set; }

        /// <summary>Output only. The name of the Instance Template used for the Managed Instance Group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceTemplateName")]
        public virtual string InstanceTemplateName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies a Metastore configuration.</summary>
    public class MetastoreConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Resource name of an existing Dataproc Metastore service.Example:
        /// projects/[project_id]/locations/[dataproc_region]/services/[service-name]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataprocMetastoreService")]
        public virtual string DataprocMetastoreService { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A full, namespace-isolated deployment target for an existing GKE cluster.</summary>
    public class NamespacedGkeDeploymentTarget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A namespace within the GKE cluster to deploy into.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterNamespace")]
        public virtual string ClusterNamespace { get; set; }

        /// <summary>
        /// Optional. The target GKE cluster to deploy to. Format:
        /// 'projects/{project}/locations/{location}/clusters/{cluster_id}'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetGkeCluster")]
        public virtual string TargetGkeCluster { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Node Group Affinity for clusters using sole-tenant node groups.</summary>
    public class NodeGroupAffinity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The URI of a sole-tenant node group resource
        /// (https://cloud.google.com/compute/docs/reference/rest/v1/nodeGroups) that the cluster will be created on.A
        /// full URL, partial URI, or node group name are valid. Examples:
        /// https://www.googleapis.com/compute/v1/projects/[project_id]/zones/us-central1-a/nodeGroups/node-group-1
        /// projects/[project_id]/zones/us-central1-a/nodeGroups/node-group-1 node-group-1
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeGroupUri")]
        public virtual string NodeGroupUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies an executable to run on a fully configured node and a timeout period for executable completion.
    /// </summary>
    public class NodeInitializationAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Cloud Storage URI of executable file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executableFile")]
        public virtual string ExecutableFile { get; set; }

        /// <summary>
        /// Optional. Amount of time executable has to complete. Default is 10 minutes (see JSON representation of
        /// Duration (https://developers.google.com/protocol-buffers/docs/proto3#json)).Cluster creation fails with an
        /// explanatory error message (the name of the executable that caused the error and the exceeded timeout period)
        /// if the executable is not completed at end of the timeout period.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionTimeout")]
        public virtual object ExecutionTimeout { get; set; }

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

    /// <summary>A job executed by the workflow.</summary>
    public class OrderedJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Job is a Hadoop job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hadoopJob")]
        public virtual HadoopJob HadoopJob { get; set; }

        /// <summary>Optional. Job is a Hive job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hiveJob")]
        public virtual HiveJob HiveJob { get; set; }

        /// <summary>
        /// Optional. The labels to associate with this job.Label keys must be between 1 and 63 characters long, and
        /// must conform to the following regular expression: \p{Ll}\p{Lo}{0,62}Label values must be between 1 and 63
        /// characters long, and must conform to the following regular expression: \p{Ll}\p{Lo}\p{N}_-{0,63}No more than
        /// 32 labels can be associated with a given job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Optional. Job is a Pig job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pigJob")]
        public virtual PigJob PigJob { get; set; }

        /// <summary>
        /// Optional. The optional list of prerequisite job step_ids. If not specified, the job will start at the
        /// beginning of workflow.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prerequisiteStepIds")]
        public virtual System.Collections.Generic.IList<string> PrerequisiteStepIds { get; set; }

        /// <summary>Optional. Job is a Presto job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prestoJob")]
        public virtual PrestoJob PrestoJob { get; set; }

        /// <summary>Optional. Job is a PySpark job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pysparkJob")]
        public virtual PySparkJob PysparkJob { get; set; }

        /// <summary>Optional. Job scheduling configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduling")]
        public virtual JobScheduling Scheduling { get; set; }

        /// <summary>Optional. Job is a Spark job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sparkJob")]
        public virtual SparkJob SparkJob { get; set; }

        /// <summary>Optional. Job is a SparkR job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sparkRJob")]
        public virtual SparkRJob SparkRJob { get; set; }

        /// <summary>Optional. Job is a SparkSql job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sparkSqlJob")]
        public virtual SparkSqlJob SparkSqlJob { get; set; }

        /// <summary>
        /// Required. The step id. The id must be unique among all jobs within the template.The step id is used as
        /// prefix for job id, as job goog-dataproc-workflow-step-id label, and in prerequisiteStepIds field from other
        /// steps.The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). Cannot
        /// begin or end with underscore or hyphen. Must consist of between 3 and 50 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stepId")]
        public virtual string StepId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for parameter validation.</summary>
    public class ParameterValidation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Validation based on regular expressions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regex")]
        public virtual RegexValidation Regex { get; set; }

        /// <summary>Validation based on a list of allowed values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual ValueValidation Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Dataproc job for running Apache Pig (https://pig.apache.org/) queries on YARN.</summary>
    public class PigJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Whether to continue executing queries if a query fails. The default value is false. Setting to
        /// true can be useful when executing independent parallel queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("continueOnFailure")]
        public virtual System.Nullable<bool> ContinueOnFailure { get; set; }

        /// <summary>
        /// Optional. HCFS URIs of jar files to add to the CLASSPATH of the Pig Client and Hadoop MapReduce (MR) tasks.
        /// Can contain Pig UDFs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jarFileUris")]
        public virtual System.Collections.Generic.IList<string> JarFileUris { get; set; }

        /// <summary>Optional. The runtime log config for job execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loggingConfig")]
        public virtual LoggingConfig LoggingConfig { get; set; }

        /// <summary>
        /// Optional. A mapping of property names to values, used to configure Pig. Properties that conflict with values
        /// set by the Dataproc API may be overwritten. Can include properties set in /etc/hadoop/conf/*-site.xml,
        /// /etc/pig/conf/pig.properties, and classes in user code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, string> Properties { get; set; }

        /// <summary>The HCFS URI of the script that contains the Pig queries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryFileUri")]
        public virtual string QueryFileUri { get; set; }

        /// <summary>A list of queries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryList")]
        public virtual QueryList QueryList { get; set; }

        /// <summary>
        /// Optional. Mapping of query variable names to values (equivalent to the Pig command: name=[value]).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scriptVariables")]
        public virtual System.Collections.Generic.IDictionary<string, string> ScriptVariables { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Identity and Access Management (IAM) policy, which specifies access controls for Google Cloud resources.A
    /// Policy is a collection of bindings. A binding binds one or more members to a single role. Members can be user
    /// accounts, service accounts, Google groups, and domains (such as G Suite). A role is a named list of permissions;
    /// each role can be an IAM predefined role or a user-created custom role.For some types of Google Cloud resources,
    /// a binding can also specify a condition, which is a logical expression that allows access to a resource only if
    /// the expression evaluates to true. A condition can add constraints based on attributes of the request, the
    /// resource, or both. To learn which resources support conditions in their IAM policies, see the IAM documentation
    /// (https://cloud.google.com/iam/help/conditions/resource-policies).JSON example: { "bindings": [ { "role":
    /// "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com", "group:admins@example.com",
    /// "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] }, { "role":
    /// "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": { "title":
    /// "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 } YAML example: bindings: -
    /// members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') - etag: BwWWja0YfJA= - version: 3 For a description of IAM and its
    /// features, see the IAM documentation (https://cloud.google.com/iam/docs/).
    /// </summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Associates a list of members to a role. Optionally, may specify a condition that determines how and when the
        /// bindings are applied. Each of the bindings must contain at least one member.
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

    /// <summary>
    /// A Dataproc job for running Presto (https://prestosql.io/) queries. IMPORTANT: The Dataproc Presto Optional
    /// Component (https://cloud.google.com/dataproc/docs/concepts/components/presto) must be enabled when the cluster
    /// is created to submit a Presto job to the cluster.
    /// </summary>
    public class PrestoJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Presto client tags to attach to this query</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientTags")]
        public virtual System.Collections.Generic.IList<string> ClientTags { get; set; }

        /// <summary>
        /// Optional. Whether to continue executing queries if a query fails. The default value is false. Setting to
        /// true can be useful when executing independent parallel queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("continueOnFailure")]
        public virtual System.Nullable<bool> ContinueOnFailure { get; set; }

        /// <summary>Optional. The runtime log config for job execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loggingConfig")]
        public virtual LoggingConfig LoggingConfig { get; set; }

        /// <summary>
        /// Optional. The format in which query output will be displayed. See the Presto documentation for supported
        /// output formats
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputFormat")]
        public virtual string OutputFormat { get; set; }

        /// <summary>
        /// Optional. A mapping of property names to values. Used to set Presto session properties
        /// (https://prestodb.io/docs/current/sql/set-session.html) Equivalent to using the --session flag in the Presto
        /// CLI
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, string> Properties { get; set; }

        /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryFileUri")]
        public virtual string QueryFileUri { get; set; }

        /// <summary>A list of queries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryList")]
        public virtual QueryList QueryList { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Dataproc job for running Apache PySpark (https://spark.apache.org/docs/0.9.0/python-programming-guide.html)
    /// applications on YARN.
    /// </summary>
    public class PySparkJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. HCFS URIs of archives to be extracted into the working directory of each executor. Supported file
        /// types: .jar, .tar, .tar.gz, .tgz, and .zip.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("archiveUris")]
        public virtual System.Collections.Generic.IList<string> ArchiveUris { get; set; }

        /// <summary>
        /// Optional. The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as
        /// job properties, since a collision may occur that causes an incorrect job submission.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>
        /// Optional. HCFS URIs of files to be placed in the working directory of each executor. Useful for naively
        /// parallel tasks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileUris")]
        public virtual System.Collections.Generic.IList<string> FileUris { get; set; }

        /// <summary>Optional. HCFS URIs of jar files to add to the CLASSPATHs of the Python driver and tasks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jarFileUris")]
        public virtual System.Collections.Generic.IList<string> JarFileUris { get; set; }

        /// <summary>Optional. The runtime log config for job execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loggingConfig")]
        public virtual LoggingConfig LoggingConfig { get; set; }

        /// <summary>Required. The HCFS URI of the main Python file to use as the driver. Must be a .py file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mainPythonFileUri")]
        public virtual string MainPythonFileUri { get; set; }

        /// <summary>
        /// Optional. A mapping of property names to values, used to configure PySpark. Properties that conflict with
        /// values set by the Dataproc API may be overwritten. Can include properties set in
        /// /etc/spark/conf/spark-defaults.conf and classes in user code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Optional. HCFS file URIs of Python files to pass to the PySpark framework. Supported file types: .py, .egg,
        /// and .zip.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pythonFileUris")]
        public virtual System.Collections.Generic.IList<string> PythonFileUris { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of queries to run on a cluster.</summary>
    public class QueryList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple
        /// queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc
        /// API snippet that uses a QueryList to specify a HiveJob: "hiveJob": { "queryList": { "queries": [ "query1",
        /// "query2", "query3;query4", ] } }
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queries")]
        public virtual System.Collections.Generic.IList<string> Queries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Validation based on regular expressions.</summary>
    public class RegexValidation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. RE2 regular expressions used to validate the parameter's value. The value must match the regex in
        /// its entirety (substring matches are not sufficient).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regexes")]
        public virtual System.Collections.Generic.IList<string> Regexes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Reservation Affinity for consuming Zonal reservation.</summary>
    public class ReservationAffinity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Type of reservation to consume</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumeReservationType")]
        public virtual string ConsumeReservationType { get; set; }

        /// <summary>Optional. Corresponds to the label key of reservation resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Optional. Corresponds to the label values of reservation resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Security related configuration, including encryption, Kerberos, etc.</summary>
    public class SecurityConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Kerberos related configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kerberosConfig")]
        public virtual KerberosConfig KerberosConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for SetIamPolicy method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the resource. The size of the policy is limited to a few 10s
        /// of KB. An empty policy is a valid policy but certain Cloud Platform services (such as Projects) might reject
        /// them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Shielded Instance Config for clusters using Compute Engine Shielded VMs
    /// (https://cloud.google.com/security/shielded-cloud/shielded-vm).
    /// </summary>
    public class ShieldedInstanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Defines whether instances have integrity monitoring enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableIntegrityMonitoring")]
        public virtual System.Nullable<bool> EnableIntegrityMonitoring { get; set; }

        /// <summary>Optional. Defines whether instances have Secure Boot enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSecureBoot")]
        public virtual System.Nullable<bool> EnableSecureBoot { get; set; }

        /// <summary>Optional. Defines whether instances have the vTPM enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableVtpm")]
        public virtual System.Nullable<bool> EnableVtpm { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the selection and config of software inside the cluster.</summary>
    public class SoftwareConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The version of software inside the cluster. It must be one of the supported Dataproc Versions
        /// (https://cloud.google.com/dataproc/docs/concepts/versioning/dataproc-versions#supported_dataproc_versions),
        /// such as "1.2" (including a subminor version, such as "1.2.29"), or the "preview" version
        /// (https://cloud.google.com/dataproc/docs/concepts/versioning/dataproc-versions#other_versions). If
        /// unspecified, it defaults to the latest Debian version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageVersion")]
        public virtual string ImageVersion { get; set; }

        /// <summary>The set of optional components to activate on the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optionalComponents")]
        public virtual System.Collections.Generic.IList<string> OptionalComponents { get; set; }

        /// <summary>
        /// Optional. The properties to set on daemon config files.Property keys are specified in prefix:property
        /// format, for example core:hadoop.tmp.dir. The following are supported prefixes and their mappings:
        /// capacity-scheduler: capacity-scheduler.xml core: core-site.xml distcp: distcp-default.xml hdfs:
        /// hdfs-site.xml hive: hive-site.xml mapred: mapred-site.xml pig: pig.properties spark: spark-defaults.conf
        /// yarn: yarn-site.xmlFor more information, see Cluster properties
        /// (https://cloud.google.com/dataproc/docs/concepts/cluster-properties).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, string> Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Dataproc job for running Apache Spark (http://spark.apache.org/) applications on YARN. The specification of
    /// the main method to call to drive the job. Specify either the jar file that contains the main class or the main
    /// class name. To pass both a main jar and a main class in that jar, add the jar to CommonJob.jar_file_uris, and
    /// then specify the main class name in main_class.
    /// </summary>
    public class SparkJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. HCFS URIs of archives to be extracted into the working directory of each executor. Supported file
        /// types: .jar, .tar, .tar.gz, .tgz, and .zip.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("archiveUris")]
        public virtual System.Collections.Generic.IList<string> ArchiveUris { get; set; }

        /// <summary>
        /// Optional. The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as
        /// job properties, since a collision may occur that causes an incorrect job submission.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>
        /// Optional. HCFS URIs of files to be placed in the working directory of each executor. Useful for naively
        /// parallel tasks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileUris")]
        public virtual System.Collections.Generic.IList<string> FileUris { get; set; }

        /// <summary>Optional. HCFS URIs of jar files to add to the CLASSPATHs of the Spark driver and tasks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jarFileUris")]
        public virtual System.Collections.Generic.IList<string> JarFileUris { get; set; }

        /// <summary>Optional. The runtime log config for job execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loggingConfig")]
        public virtual LoggingConfig LoggingConfig { get; set; }

        /// <summary>
        /// The name of the driver's main class. The jar file that contains the class must be in the default CLASSPATH
        /// or specified in jar_file_uris.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mainClass")]
        public virtual string MainClass { get; set; }

        /// <summary>The HCFS URI of the jar file that contains the main class.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mainJarFileUri")]
        public virtual string MainJarFileUri { get; set; }

        /// <summary>
        /// Optional. A mapping of property names to values, used to configure Spark. Properties that conflict with
        /// values set by the Dataproc API may be overwritten. Can include properties set in
        /// /etc/spark/conf/spark-defaults.conf and classes in user code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, string> Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Dataproc job for running Apache SparkR (https://spark.apache.org/docs/latest/sparkr.html) applications on
    /// YARN.
    /// </summary>
    public class SparkRJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. HCFS URIs of archives to be extracted into the working directory of each executor. Supported file
        /// types: .jar, .tar, .tar.gz, .tgz, and .zip.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("archiveUris")]
        public virtual System.Collections.Generic.IList<string> ArchiveUris { get; set; }

        /// <summary>
        /// Optional. The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as
        /// job properties, since a collision may occur that causes an incorrect job submission.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>
        /// Optional. HCFS URIs of files to be placed in the working directory of each executor. Useful for naively
        /// parallel tasks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileUris")]
        public virtual System.Collections.Generic.IList<string> FileUris { get; set; }

        /// <summary>Optional. The runtime log config for job execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loggingConfig")]
        public virtual LoggingConfig LoggingConfig { get; set; }

        /// <summary>Required. The HCFS URI of the main R file to use as the driver. Must be a .R file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mainRFileUri")]
        public virtual string MainRFileUri { get; set; }

        /// <summary>
        /// Optional. A mapping of property names to values, used to configure SparkR. Properties that conflict with
        /// values set by the Dataproc API may be overwritten. Can include properties set in
        /// /etc/spark/conf/spark-defaults.conf and classes in user code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, string> Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Dataproc job for running Apache Spark SQL (http://spark.apache.org/sql/) queries.</summary>
    public class SparkSqlJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jarFileUris")]
        public virtual System.Collections.Generic.IList<string> JarFileUris { get; set; }

        /// <summary>Optional. The runtime log config for job execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loggingConfig")]
        public virtual LoggingConfig LoggingConfig { get; set; }

        /// <summary>
        /// Optional. A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that
        /// conflict with values set by the Dataproc API may be overwritten.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, string> Properties { get; set; }

        /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryFileUri")]
        public virtual string QueryFileUri { get; set; }

        /// <summary>A list of queries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryList")]
        public virtual QueryList QueryList { get; set; }

        /// <summary>
        /// Optional. Mapping of query variable names to values (equivalent to the Spark SQL command: SET
        /// name="value";).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scriptVariables")]
        public virtual System.Collections.Generic.IDictionary<string, string> ScriptVariables { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to start a cluster.</summary>
    public class StartClusterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specifying the cluster_uuid means the RPC will fail (with error NOT_FOUND) if a cluster with the
        /// specified UUID does not exist.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterUuid")]
        public virtual string ClusterUuid { get; set; }

        /// <summary>
        /// Optional. A unique id used to identify the request. If the server receives two StartClusterRequest
        /// (https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1beta2#google.cloud.dataproc.v1beta2.StartClusterRequest)s
        /// with the same id, then the second request will be ignored and the first google.longrunning.Operation created
        /// and stored in the backend is returned.Recommendation: Set this value to a UUID
        /// (https://en.wikipedia.org/wiki/Universally_unique_identifier).The id must contain only letters (a-z, A-Z),
        /// numbers (0-9), underscores (_), and hyphens (-). The maximum length is 40 characters.
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

    /// <summary>A request to stop a cluster.</summary>
    public class StopClusterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specifying the cluster_uuid means the RPC will fail (with error NOT_FOUND) if a cluster with the
        /// specified UUID does not exist.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterUuid")]
        public virtual string ClusterUuid { get; set; }

        /// <summary>
        /// Optional. A unique id used to identify the request. If the server receives two StopClusterRequest
        /// (https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1beta2#google.cloud.dataproc.v1beta2.StopClusterRequest)s
        /// with the same id, then the second request will be ignored and the first google.longrunning.Operation created
        /// and stored in the backend is returned.Recommendation: Set this value to a UUID
        /// (https://en.wikipedia.org/wiki/Universally_unique_identifier).The id must contain only letters (a-z, A-Z),
        /// numbers (0-9), underscores (_), and hyphens (-). The maximum length is 40 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to submit a job.</summary>
    public class SubmitJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The job resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("job")]
        public virtual Job Job { get; set; }

        /// <summary>
        /// Optional. A unique id used to identify the request. If the server receives two SubmitJobRequest
        /// (https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1beta2#google.cloud.dataproc.v1.SubmitJobRequest)s
        /// with the same id, then the second request will be ignored and the first Job created and stored in the
        /// backend is returned.It is recommended to always set this value to a UUID
        /// (https://en.wikipedia.org/wiki/Universally_unique_identifier).The id must contain only letters (a-z, A-Z),
        /// numbers (0-9), underscores (_), and hyphens (-). The maximum length is 40 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A configurable parameter that replaces one or more fields in the template. Parameterizable fields: - Labels -
    /// File uris - Job properties - Job arguments - Script variables - Main class (in HadoopJob and SparkJob) - Zone
    /// (in ClusterSelector)
    /// </summary>
    public class TemplateParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Brief description of the parameter. Must not exceed 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. Paths to all fields that the parameter replaces. A field is allowed to appear in at most one
        /// parameter's list of field paths.A field path is similar in syntax to a google.protobuf.FieldMask. For
        /// example, a field path that references the zone field of a workflow template's cluster selector would be
        /// specified as placement.clusterSelector.zone.Also, field paths can reference fields using the following
        /// syntax: Values in maps can be referenced by key: labels'key' placement.clusterSelector.clusterLabels'key'
        /// placement.managedCluster.labels'key' placement.clusterSelector.clusterLabels'key' jobs'step-id'.labels'key'
        /// Jobs in the jobs list can be referenced by step-id: jobs'step-id'.hadoopJob.mainJarFileUri
        /// jobs'step-id'.hiveJob.queryFileUri jobs'step-id'.pySparkJob.mainPythonFileUri
        /// jobs'step-id'.hadoopJob.jarFileUris0 jobs'step-id'.hadoopJob.archiveUris0 jobs'step-id'.hadoopJob.fileUris0
        /// jobs'step-id'.pySparkJob.pythonFileUris0 Items in repeated fields can be referenced by a zero-based index:
        /// jobs'step-id'.sparkJob.args0 Other examples: jobs'step-id'.hadoopJob.properties'key'
        /// jobs'step-id'.hadoopJob.args0 jobs'step-id'.hiveJob.scriptVariables'key'
        /// jobs'step-id'.hadoopJob.mainJarFileUri placement.clusterSelector.zoneIt may not be possible to parameterize
        /// maps and repeated fields in their entirety since only individual map values and individual items in repeated
        /// fields can be referenced. For example, the following field paths are invalid:
        /// placement.clusterSelector.clusterLabels jobs'step-id'.sparkJob.args
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<string> Fields { get; set; }

        /// <summary>
        /// Required. Parameter name. The parameter name is used as the key, and paired with the parameter value, which
        /// are passed to the template when the template is instantiated. The name must contain only capital letters
        /// (A-Z), numbers (0-9), and underscores (_), and must not start with a number. The maximum length is 40
        /// characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Validation rules to be applied to this parameter's value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validation")]
        public virtual ParameterValidation Validation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for TestIamPermissions method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
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
    public class TestIamPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A subset of TestPermissionsRequest.permissions that the caller is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Validation based on a list of allowed values.</summary>
    public class ValueValidation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. List of allowed values for the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The workflow graph.</summary>
    public class WorkflowGraph : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The workflow nodes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<WorkflowNode> Nodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Dataproc workflow template resource.</summary>
    public class WorkflowMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The name of the target cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterName")]
        public virtual string ClusterName { get; set; }

        /// <summary>Output only. The UUID of target cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterUuid")]
        public virtual string ClusterUuid { get; set; }

        /// <summary>Output only. The create cluster operation metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createCluster")]
        public virtual ClusterOperation CreateCluster { get; set; }

        /// <summary>
        /// Output only. DAG end time, which is only set for workflows with dag_timeout when the DAG ends.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dagEndTime")]
        public virtual object DagEndTime { get; set; }

        /// <summary>
        /// Output only. DAG start time, which is only set for workflows with dag_timeout when the DAG begins.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dagStartTime")]
        public virtual object DagStartTime { get; set; }

        /// <summary>
        /// Output only. The timeout duration for the DAG of jobs, expressed in seconds (see JSON representation of
        /// duration (https://developers.google.com/protocol-buffers/docs/proto3#json)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dagTimeout")]
        public virtual object DagTimeout { get; set; }

        /// <summary>Output only. The delete cluster operation metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteCluster")]
        public virtual ClusterOperation DeleteCluster { get; set; }

        /// <summary>Output only. Workflow end time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Output only. The workflow graph.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("graph")]
        public virtual WorkflowGraph Graph { get; set; }

        /// <summary>Map from parameter names to values that were used for those parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string, string> Parameters { get; set; }

        /// <summary>Output only. Workflow start time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>Output only. The workflow state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. The resource name of the workflow template as described in
        /// https://cloud.google.com/apis/design/resource_names. For projects.regions.workflowTemplates, the resource
        /// name of the template has the following format:
        /// projects/{project_id}/regions/{region}/workflowTemplates/{template_id} For
        /// projects.locations.workflowTemplates, the resource name of the template has the following format:
        /// projects/{project_id}/locations/{location}/workflowTemplates/{template_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("template")]
        public virtual string Template { get; set; }

        /// <summary>Output only. The version of template at the time of workflow instantiation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The workflow node.</summary>
    public class WorkflowNode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The error detail.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual string Error { get; set; }

        /// <summary>Output only. The job id; populated after the node enters RUNNING state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobId")]
        public virtual string JobId { get; set; }

        /// <summary>Output only. Node's prerequisite nodes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prerequisiteStepIds")]
        public virtual System.Collections.Generic.IList<string> PrerequisiteStepIds { get; set; }

        /// <summary>Output only. The node state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. The name of the node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stepId")]
        public virtual string StepId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Dataproc workflow template resource.</summary>
    public class WorkflowTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time template was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Optional. Timeout duration for the DAG of jobs, expressed in seconds (see JSON representation of duration
        /// (https://developers.google.com/protocol-buffers/docs/proto3#json)). The timeout duration must be from 10
        /// minutes ("600s") to 24 hours ("86400s"). The timer begins when the first job is submitted. If the workflow
        /// is running at the end of the timeout period, any remaining jobs are cancelled, the workflow is ended, and if
        /// the workflow was running on a managed cluster, the cluster is deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dagTimeout")]
        public virtual object DagTimeout { get; set; }

        /// <summary>
        /// Required. The template id.The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and
        /// hyphens (-). Cannot begin or end with underscore or hyphen. Must consist of between 3 and 50 characters..
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Required. The Directed Acyclic Graph of Jobs to submit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobs")]
        public virtual System.Collections.Generic.IList<OrderedJob> Jobs { get; set; }

        /// <summary>
        /// Optional. The labels to associate with this template. These labels will be propagated to all jobs and
        /// clusters created by the workflow instance.Label keys must contain 1 to 63 characters, and must conform to
        /// RFC 1035 (https://www.ietf.org/rfc/rfc1035.txt).Label values may be empty, but, if present, must contain 1
        /// to 63 characters, and must conform to RFC 1035 (https://www.ietf.org/rfc/rfc1035.txt).No more than 32 labels
        /// can be associated with a template.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. The resource name of the workflow template, as described in
        /// https://cloud.google.com/apis/design/resource_names. For projects.regions.workflowTemplates, the resource
        /// name of the template has the following format:
        /// projects/{project_id}/regions/{region}/workflowTemplates/{template_id} For
        /// projects.locations.workflowTemplates, the resource name of the template has the following format:
        /// projects/{project_id}/locations/{location}/workflowTemplates/{template_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Template parameters whose values are substituted into the template. Values for parameters must be
        /// provided when the template is instantiated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<TemplateParameter> Parameters { get; set; }

        /// <summary>Required. WorkflowTemplate scheduling information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placement")]
        public virtual WorkflowTemplatePlacement Placement { get; set; }

        /// <summary>Output only. The time template was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>
        /// Optional. Used to perform a consistent read-modify-write.This field should be left blank for a
        /// CreateWorkflowTemplate request. It is required for an UpdateWorkflowTemplate request, and must match the
        /// current server version. A typical update template flow would fetch the current template with a
        /// GetWorkflowTemplate request, which will return the current template with the version field filled in with
        /// the current server version. The user updates other fields in the template, then returns it as part of the
        /// UpdateWorkflowTemplate request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies workflow execution target.Either managed_cluster or cluster_selector is required.</summary>
    public class WorkflowTemplatePlacement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A selector that chooses target cluster for jobs based on metadata.The selector is evaluated at the
        /// time each job is submitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterSelector")]
        public virtual ClusterSelector ClusterSelector { get; set; }

        /// <summary>Optional. A cluster that is managed by the workflow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedCluster")]
        public virtual ManagedCluster ManagedCluster { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A YARN application created by a job. Application information is a subset of
    /// org.apache.hadoop.yarn.proto.YarnProtos.ApplicationReportProto.Beta Feature: This report is available for
    /// testing purposes only. It may be changed before final release.
    /// </summary>
    public class YarnApplication : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The application name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The numerical progress of the application, from 1 to 100.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progress")]
        public virtual System.Nullable<float> Progress { get; set; }

        /// <summary>Output only. The application state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. The HTTP URL of the ApplicationMaster, HistoryServer, or TimelineServer that provides
        /// application-specific information. The URL uses the internal hostname, and requires a proxy server for
        /// resolution and, possibly, access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackingUrl")]
        public virtual string TrackingUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
