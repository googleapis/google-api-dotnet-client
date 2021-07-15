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

namespace Google.Apis.CloudMachineLearningEngine.v1
{
    /// <summary>The CloudMachineLearningEngine Service.</summary>
    public class CloudMachineLearningEngineService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudMachineLearningEngineService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudMachineLearningEngineService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "ml";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://ml.googleapis.com/";
        #else
            "https://ml.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://ml.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the AI Platform Training &amp; Prediction API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View your data across Google Cloud Platform services</summary>
            public static string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";
        }

        /// <summary>
        /// Available OAuth 2.0 scope constants for use with the AI Platform Training &amp;amp; Prediction API.
        /// </summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View your data across Google Cloud Platform services</summary>
            public const string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for CloudMachineLearningEngine requests.</summary>
    public abstract class CloudMachineLearningEngineBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudMachineLearningEngineBaseServiceRequest instance.</summary>
        protected CloudMachineLearningEngineBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudMachineLearningEngine parameter list.</summary>
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
            Jobs = new JobsResource(service);
            Locations = new LocationsResource(service);
            Models = new ModelsResource(service);
            Operations = new OperationsResource(service);
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

            /// <summary>Cancels a running job.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The name of the job to cancel.</param>
            public virtual CancelRequest Cancel(Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1CancelJobRequest body, string name)
            {
                return new CancelRequest(service, body, name);
            }

            /// <summary>Cancels a running job.</summary>
            public class CancelRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Cancel request.</summary>
                public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1CancelJobRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The name of the job to cancel.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1CancelJobRequest Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/jobs/[^/]+$",
                    });
                }
            }

            /// <summary>Creates a training or a batch prediction job.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. The project name.</param>
            public virtual CreateRequest Create(Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Job body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a training or a batch prediction job.</summary>
            public class CreateRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Job>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Job body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The project name.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Job Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/jobs";

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
                }
            }

            /// <summary>Describes a job.</summary>
            /// <param name="name">Required. The name of the job to get the description of.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Describes a job.</summary>
            public class GetRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Job>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The name of the job to get the description of.</summary>
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
                        Pattern = @"^projects/[^/]+/jobs/[^/]+$",
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
            public class GetIamPolicyRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleIamV1Policy>
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
                        Pattern = @"^projects/[^/]+/jobs/[^/]+$",
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
            /// Lists the jobs in the project. If there are no jobs that match the request parameters, the list request
            /// returns an empty response body: {}.
            /// </summary>
            /// <param name="parent">Required. The name of the project for which to list jobs.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists the jobs in the project. If there are no jobs that match the request parameters, the list request
            /// returns an empty response body: {}.
            /// </summary>
            public class ListRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1ListJobsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The name of the project for which to list jobs.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. Specifies the subset of jobs to retrieve. You can filter on the value of one or more
                /// attributes of the job object. For example, retrieve jobs with a job identifier that starts with
                /// 'census': gcloud ai-platform jobs list --filter='jobId:census*' List all failed jobs with names that
                /// start with 'rnn': gcloud ai-platform jobs list --filter='jobId:rnn* AND state:FAILED' For more
                /// examples, see the guide to monitoring jobs.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. The number of jobs to retrieve per "page" of results. If there are more remaining results
                /// than this number, the response message will contain a valid value in the `next_page_token` field.
                /// The default value is 20, and the maximum page size is 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token to request the next page of results. You get the token from the
                /// `next_page_token` field of the response from the previous call.
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

            /// <summary>
            /// Updates a specific job resource. Currently the only supported fields to update are `labels`.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The job name.</param>
            public virtual PatchRequest Patch(Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Job body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Updates a specific job resource. Currently the only supported fields to update are `labels`.
            /// </summary>
            public class PatchRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Job>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Job body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The job name.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. Specifies the path, relative to `Job`, of the field to update. To adopt etag mechanism,
                /// include `etag` field in the mask, and include the `etag` value in your job resource. For example, to
                /// change the labels of a job, the `update_mask` parameter would be specified as `labels`, `etag`, and
                /// the `PATCH` request body would specify the new value, as follows: { "labels": { "owner": "Google",
                /// "color": "Blue" } "etag": "33a64df551425fcc55e4d42a148795d9f25f89d4" } If `etag` matches the one on
                /// the server, the labels of the job will be replaced with the given ones, and the server end `etag`
                /// will be recalculated. Currently the only supported update masks are `labels` and `etag`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Job Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/jobs/[^/]+$",
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
            /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
            /// appropriate value for this field.
            /// </param>
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleIamV1SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(service, body, resource);
            }

            /// <summary>
            /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
            /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
            /// </summary>
            public class SetIamPolicyRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleIamV1Policy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleIamV1SetIamPolicyRequest body, string resource) : base(service)
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
                Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleIamV1SetIamPolicyRequest Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/jobs/[^/]+$",
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
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleIamV1TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(service, body, resource);
            }

            /// <summary>
            /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this
            /// will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be
            /// used for building permission-aware UIs and command-line tools, not for authorization checking. This
            /// operation may "fail open" without warning.
            /// </summary>
            public class TestIamPermissionsRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleIamV1TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleIamV1TestIamPermissionsRequest body, string resource) : base(service)
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
                Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleIamV1TestIamPermissionsRequest Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/jobs/[^/]+$",
                    });
                }
            }
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
                Operations = new OperationsResource(service);
                Studies = new StudiesResource(service);
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
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(string name)
                {
                    return new CancelRequest(service, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
                /// </summary>
                public class CancelRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleProtobufEmpty>
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
                public class GetRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleLongrunningOperation>
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
            }

            /// <summary>Gets the Studies resource.</summary>
            public virtual StudiesResource Studies { get; }

            /// <summary>The "studies" collection of methods.</summary>
            public class StudiesResource
            {
                private const string Resource = "studies";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public StudiesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Trials = new TrialsResource(service);
                }

                /// <summary>Gets the Trials resource.</summary>
                public virtual TrialsResource Trials { get; }

                /// <summary>The "trials" collection of methods.</summary>
                public class TrialsResource
                {
                    private const string Resource = "trials";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public TrialsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Adds a measurement of the objective metrics to a trial. This measurement is assumed to have been
                    /// taken before the trial is complete.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. The trial name.</param>
                    public virtual AddMeasurementRequest AddMeasurement(Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1AddTrialMeasurementRequest body, string name)
                    {
                        return new AddMeasurementRequest(service, body, name);
                    }

                    /// <summary>
                    /// Adds a measurement of the objective metrics to a trial. This measurement is assumed to have been
                    /// taken before the trial is complete.
                    /// </summary>
                    public class AddMeasurementRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Trial>
                    {
                        /// <summary>Constructs a new AddMeasurement request.</summary>
                        public AddMeasurementRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1AddTrialMeasurementRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The trial name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1AddTrialMeasurementRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "addMeasurement";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:addMeasurement";

                        /// <summary>Initializes AddMeasurement parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/studies/[^/]+/trials/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Checks whether a trial should stop or not. Returns a long-running operation. When the operation
                    /// is successful, it will contain a CheckTrialEarlyStoppingStateResponse.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. The trial name.</param>
                    public virtual CheckEarlyStoppingStateRequest CheckEarlyStoppingState(Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1CheckTrialEarlyStoppingStateRequest body, string name)
                    {
                        return new CheckEarlyStoppingStateRequest(service, body, name);
                    }

                    /// <summary>
                    /// Checks whether a trial should stop or not. Returns a long-running operation. When the operation
                    /// is successful, it will contain a CheckTrialEarlyStoppingStateResponse.
                    /// </summary>
                    public class CheckEarlyStoppingStateRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new CheckEarlyStoppingState request.</summary>
                        public CheckEarlyStoppingStateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1CheckTrialEarlyStoppingStateRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The trial name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1CheckTrialEarlyStoppingStateRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "checkEarlyStoppingState";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:checkEarlyStoppingState";

                        /// <summary>Initializes CheckEarlyStoppingState parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/studies/[^/]+/trials/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Marks a trial as complete.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. The trial name.metat</param>
                    public virtual CompleteRequest Complete(Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1CompleteTrialRequest body, string name)
                    {
                        return new CompleteRequest(service, body, name);
                    }

                    /// <summary>Marks a trial as complete.</summary>
                    public class CompleteRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Trial>
                    {
                        /// <summary>Constructs a new Complete request.</summary>
                        public CompleteRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1CompleteTrialRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The trial name.metat</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1CompleteTrialRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "complete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:complete";

                        /// <summary>Initializes Complete parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/studies/[^/]+/trials/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Adds a user provided trial to a study.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The name of the study that the trial belongs to.</param>
                    public virtual CreateRequest Create(Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Trial body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Adds a user provided trial to a study.</summary>
                    public class CreateRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Trial>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Trial body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the study that the trial belongs to.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Trial Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/trials";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/studies/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Deletes a trial.</summary>
                    /// <param name="name">Required. The trial name.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes a trial.</summary>
                    public class DeleteRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleProtobufEmpty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The trial name.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/studies/[^/]+/trials/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets a trial.</summary>
                    /// <param name="name">Required. The trial name.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets a trial.</summary>
                    public class GetRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Trial>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The trial name.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/studies/[^/]+/trials/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists the trials associated with a study.</summary>
                    /// <param name="parent">Required. The name of the study that the trial belongs to.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists the trials associated with a study.</summary>
                    public class ListRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1ListTrialsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the study that the trial belongs to.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/trials";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/studies/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists the pareto-optimal trials for multi-objective study or the optimal trials for
                    /// single-objective study. The definition of pareto-optimal can be checked in wiki page.
                    /// https://en.wikipedia.org/wiki/Pareto_efficiency
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The name of the study that the pareto-optimal trial belongs to.
                    /// </param>
                    public virtual ListOptimalTrialsRequest ListOptimalTrials(Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1ListOptimalTrialsRequest body, string parent)
                    {
                        return new ListOptimalTrialsRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Lists the pareto-optimal trials for multi-objective study or the optimal trials for
                    /// single-objective study. The definition of pareto-optimal can be checked in wiki page.
                    /// https://en.wikipedia.org/wiki/Pareto_efficiency
                    /// </summary>
                    public class ListOptimalTrialsRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1ListOptimalTrialsResponse>
                    {
                        /// <summary>Constructs a new ListOptimalTrials request.</summary>
                        public ListOptimalTrialsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1ListOptimalTrialsRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the study that the pareto-optimal trial belongs to.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1ListOptimalTrialsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "listOptimalTrials";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/trials:listOptimalTrials";

                        /// <summary>Initializes ListOptimalTrials parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/studies/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Stops a trial.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. The trial name.</param>
                    public virtual StopRequest Stop(Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1StopTrialRequest body, string name)
                    {
                        return new StopRequest(service, body, name);
                    }

                    /// <summary>Stops a trial.</summary>
                    public class StopRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Trial>
                    {
                        /// <summary>Constructs a new Stop request.</summary>
                        public StopRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1StopTrialRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The trial name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1StopTrialRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "stop";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:stop";

                        /// <summary>Initializes Stop parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/studies/[^/]+/trials/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Adds one or more trials to a study, with parameter values suggested by AI Platform Vizier.
                    /// Returns a long-running operation associated with the generation of trial suggestions. When this
                    /// long-running operation succeeds, it will contain a SuggestTrialsResponse.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The name of the study that the trial belongs to.</param>
                    public virtual SuggestRequest Suggest(Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1SuggestTrialsRequest body, string parent)
                    {
                        return new SuggestRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Adds one or more trials to a study, with parameter values suggested by AI Platform Vizier.
                    /// Returns a long-running operation associated with the generation of trial suggestions. When this
                    /// long-running operation succeeds, it will contain a SuggestTrialsResponse.
                    /// </summary>
                    public class SuggestRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Suggest request.</summary>
                        public SuggestRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1SuggestTrialsRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the study that the trial belongs to.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1SuggestTrialsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "suggest";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/trials:suggest";

                        /// <summary>Initializes Suggest parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/studies/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Creates a study.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The project and location that the study belongs to. Format:
                /// projects/{project}/locations/{location}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Study body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a study.</summary>
                public class CreateRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Study>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Study body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location that the study belongs to. Format:
                    /// projects/{project}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID to use for the study, which will become the final component of the study's
                    /// resource name.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("studyId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string StudyId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Study Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/studies";

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
                        RequestParameters.Add("studyId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "studyId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a study.</summary>
                /// <param name="name">Required. The study name.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a study.</summary>
                public class DeleteRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The study name.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/studies/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets a study.</summary>
                /// <param name="name">Required. The study name.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets a study.</summary>
                public class GetRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Study>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The study name.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/studies/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all the studies in a region for an associated project.</summary>
                /// <param name="parent">
                /// Required. The project and location that the study belongs to. Format:
                /// projects/{project}/locations/{location}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists all the studies in a region for an associated project.</summary>
                public class ListRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1ListStudiesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location that the study belongs to. Format:
                    /// projects/{project}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/studies";

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
                    }
                }
            }

            /// <summary>
            /// Get the complete list of CMLE capabilities in a location, along with their location-specific properties.
            /// </summary>
            /// <param name="name">Required. The name of the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Get the complete list of CMLE capabilities in a location, along with their location-specific properties.
            /// </summary>
            public class GetRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Location>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The name of the location.</summary>
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

            /// <summary>List all locations that provides at least one type of CMLE capability.</summary>
            /// <param name="parent">
            /// Required. The name of the project for which available locations are to be listed (since some locations
            /// might be whitelisted for specific projects).
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>List all locations that provides at least one type of CMLE capability.</summary>
            public class ListRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1ListLocationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project for which available locations are to be listed (since some
                /// locations might be whitelisted for specific projects).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The number of locations to retrieve per "page" of results. If there are more remaining
                /// results than this number, the response message will contain a valid value in the `next_page_token`
                /// field. The default value is 20, and the maximum page size is 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token to request the next page of results. You get the token from the
                /// `next_page_token` field of the response from the previous call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/locations";

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

        /// <summary>Gets the Models resource.</summary>
        public virtual ModelsResource Models { get; }

        /// <summary>The "models" collection of methods.</summary>
        public class ModelsResource
        {
            private const string Resource = "models";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ModelsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Versions = new VersionsResource(service);
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
                }

                /// <summary>
                /// Creates a new version of a model from a trained TensorFlow model. If the version created in the
                /// cloud by this call is the first deployed version of the specified model, it will be made the default
                /// version of the model. When you add a version to a model that already has one or more versions, the
                /// default version does not automatically change. If you want a new version to be the default, you must
                /// call projects.models.versions.setDefault.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The name of the model.</param>
                public virtual CreateRequest Create(Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Version body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a new version of a model from a trained TensorFlow model. If the version created in the
                /// cloud by this call is the first deployed version of the specified model, it will be made the default
                /// version of the model. When you add a version to a model that already has one or more versions, the
                /// default version does not automatically change. If you want a new version to be the default, you must
                /// call projects.models.versions.setDefault.
                /// </summary>
                public class CreateRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Version body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the model.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Version Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/models/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes a model version. Each model can have multiple versions deployed and in use at any given
                /// time. Use this method to remove a single version. Note: You cannot delete the version that is set as
                /// the default version of the model unless it is the only remaining version.
                /// </summary>
                /// <param name="name">
                /// Required. The name of the version. You can get the names of all the versions of a model by calling
                /// projects.models.versions.list.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a model version. Each model can have multiple versions deployed and in use at any given
                /// time. Use this method to remove a single version. Note: You cannot delete the version that is set as
                /// the default version of the model unless it is the only remaining version.
                /// </summary>
                public class DeleteRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the version. You can get the names of all the versions of a model by
                    /// calling projects.models.versions.list.
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
                            Pattern = @"^projects/[^/]+/models/[^/]+/versions/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets information about a model version. Models can have multiple versions. You can call
                /// projects.models.versions.list to get the same information that this method returns for all of the
                /// versions of a model.
                /// </summary>
                /// <param name="name">Required. The name of the version.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets information about a model version. Models can have multiple versions. You can call
                /// projects.models.versions.list to get the same information that this method returns for all of the
                /// versions of a model.
                /// </summary>
                public class GetRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Version>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the version.</summary>
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
                            Pattern = @"^projects/[^/]+/models/[^/]+/versions/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets basic information about all the versions of a model. If you expect that a model has many
                /// versions, or if you need to handle only a limited number of results at a time, you can request that
                /// the list be retrieved in batches (called pages). If there are no versions that match the request
                /// parameters, the list request returns an empty response body: {}.
                /// </summary>
                /// <param name="parent">Required. The name of the model for which to list the version.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Gets basic information about all the versions of a model. If you expect that a model has many
                /// versions, or if you need to handle only a limited number of results at a time, you can request that
                /// the list be retrieved in batches (called pages). If there are no versions that match the request
                /// parameters, the list request returns an empty response body: {}.
                /// </summary>
                public class ListRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1ListVersionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the model for which to list the version.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Specifies the subset of versions to retrieve.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The number of versions to retrieve per "page" of results. If there are more remaining
                    /// results than this number, the response message will contain a valid value in the
                    /// `next_page_token` field. The default value is 20, and the maximum page size is 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token to request the next page of results. You get the token from the
                    /// `next_page_token` field of the response from the previous call.
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
                            Pattern = @"^projects/[^/]+/models/[^/]+$",
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
                /// Updates the specified Version resource. Currently the only update-able fields are `description`,
                /// `requestLoggingConfig`, `autoScaling.minNodes`, and `manualScaling.nodes`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. The name of the model.</param>
                public virtual PatchRequest Patch(Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Version body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates the specified Version resource. Currently the only update-able fields are `description`,
                /// `requestLoggingConfig`, `autoScaling.minNodes`, and `manualScaling.nodes`.
                /// </summary>
                public class PatchRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Version body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the model.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. Specifies the path, relative to `Version`, of the field to update. Must be present and
                    /// non-empty. For example, to change the description of a version to "foo", the `update_mask`
                    /// parameter would be specified as `description`, and the `PATCH` request body would specify the
                    /// new value, as follows: ``` { "description": "foo" } ``` Currently the only supported update mask
                    /// fields are `description`, `requestLoggingConfig`, `autoScaling.minNodes`, and
                    /// `manualScaling.nodes`. However, you can only update `manualScaling.nodes` if the version uses a
                    /// [Compute Engine (N1) machine type](/ml-engine/docs/machine-types-online-prediction).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Version Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/models/[^/]+/versions/[^/]+$",
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
                /// Designates a version to be the default for the model. The default version is used for prediction
                /// requests made against the model that don't specify a version. The first version to be created for a
                /// model is automatically set as the default. You must make any subsequent changes to the default
                /// version setting manually using this method.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the version to make the default for the model. You can get the names of all
                /// the versions of a model by calling projects.models.versions.list.
                /// </param>
                public virtual SetDefaultRequest SetDefault(Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1SetDefaultVersionRequest body, string name)
                {
                    return new SetDefaultRequest(service, body, name);
                }

                /// <summary>
                /// Designates a version to be the default for the model. The default version is used for prediction
                /// requests made against the model that don't specify a version. The first version to be created for a
                /// model is automatically set as the default. You must make any subsequent changes to the default
                /// version setting manually using this method.
                /// </summary>
                public class SetDefaultRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Version>
                {
                    /// <summary>Constructs a new SetDefault request.</summary>
                    public SetDefaultRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1SetDefaultVersionRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the version to make the default for the model. You can get the names of
                    /// all the versions of a model by calling projects.models.versions.list.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1SetDefaultVersionRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setDefault";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:setDefault";

                    /// <summary>Initializes SetDefault parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/models/[^/]+/versions/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>
            /// Creates a model which will later contain one or more versions. You must add at least one version before
            /// you can request predictions from the model. Add versions by calling projects.models.versions.create.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. The project name.</param>
            public virtual CreateRequest Create(Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Model body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a model which will later contain one or more versions. You must add at least one version before
            /// you can request predictions from the model. Add versions by calling projects.models.versions.create.
            /// </summary>
            public class CreateRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Model>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Model body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The project name.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Model Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/models";

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
                }
            }

            /// <summary>
            /// Deletes a model. You can only delete a model if there are no versions in it. You can delete versions by
            /// calling projects.models.versions.delete.
            /// </summary>
            /// <param name="name">Required. The name of the model.</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes a model. You can only delete a model if there are no versions in it. You can delete versions by
            /// calling projects.models.versions.delete.
            /// </summary>
            public class DeleteRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleLongrunningOperation>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The name of the model.</summary>
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
                        Pattern = @"^projects/[^/]+/models/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets information about a model, including its name, the description (if set), and the default version
            /// (if at least one version of the model has been deployed).
            /// </summary>
            /// <param name="name">Required. The name of the model.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Gets information about a model, including its name, the description (if set), and the default version
            /// (if at least one version of the model has been deployed).
            /// </summary>
            public class GetRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Model>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The name of the model.</summary>
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
                        Pattern = @"^projects/[^/]+/models/[^/]+$",
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
            public class GetIamPolicyRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleIamV1Policy>
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
                        Pattern = @"^projects/[^/]+/models/[^/]+$",
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
            /// Lists the models in a project. Each project can contain multiple models, and each model can have
            /// multiple versions. If there are no models that match the request parameters, the list request returns an
            /// empty response body: {}.
            /// </summary>
            /// <param name="parent">Required. The name of the project whose models are to be listed.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists the models in a project. Each project can contain multiple models, and each model can have
            /// multiple versions. If there are no models that match the request parameters, the list request returns an
            /// empty response body: {}.
            /// </summary>
            public class ListRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1ListModelsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The name of the project whose models are to be listed.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional. Specifies the subset of models to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. The number of models to retrieve per "page" of results. If there are more remaining
                /// results than this number, the response message will contain a valid value in the `next_page_token`
                /// field. The default value is 20, and the maximum page size is 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token to request the next page of results. You get the token from the
                /// `next_page_token` field of the response from the previous call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/models";

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

            /// <summary>
            /// Updates a specific model resource. Currently the only supported fields to update are `description` and
            /// `default_version.name`.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The project name.</param>
            public virtual PatchRequest Patch(Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Model body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Updates a specific model resource. Currently the only supported fields to update are `description` and
            /// `default_version.name`.
            /// </summary>
            public class PatchRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleLongrunningOperation>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Model body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The project name.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. Specifies the path, relative to `Model`, of the field to update. For example, to change
                /// the description of a model to "foo" and set its default version to "version_1", the `update_mask`
                /// parameter would be specified as `description`, `default_version.name`, and the `PATCH` request body
                /// would specify the new value, as follows: { "description": "foo", "defaultVersion": {
                /// "name":"version_1" } } Currently the supported update masks are `description` and
                /// `default_version.name`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1Model Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/models/[^/]+$",
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
            /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
            /// appropriate value for this field.
            /// </param>
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleIamV1SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(service, body, resource);
            }

            /// <summary>
            /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
            /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
            /// </summary>
            public class SetIamPolicyRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleIamV1Policy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleIamV1SetIamPolicyRequest body, string resource) : base(service)
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
                Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleIamV1SetIamPolicyRequest Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/models/[^/]+$",
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
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleIamV1TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(service, body, resource);
            }

            /// <summary>
            /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this
            /// will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be
            /// used for building permission-aware UIs and command-line tools, not for authorization checking. This
            /// operation may "fail open" without warning.
            /// </summary>
            public class TestIamPermissionsRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleIamV1TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleIamV1TestIamPermissionsRequest body, string resource) : base(service)
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
                Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleIamV1TestIamPermissionsRequest Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/models/[^/]+$",
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
            /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel
            /// the operation, but success is not guaranteed. If the server doesn't support this method, it returns
            /// `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to check
            /// whether the cancellation succeeded or whether the operation completed despite cancellation. On
            /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
            /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
            /// </summary>
            /// <param name="name">The name of the operation resource to be cancelled.</param>
            public virtual CancelRequest Cancel(string name)
            {
                return new CancelRequest(service, name);
            }

            /// <summary>
            /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel
            /// the operation, but success is not guaranteed. If the server doesn't support this method, it returns
            /// `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to check
            /// whether the cancellation succeeded or whether the operation completed despite cancellation. On
            /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
            /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
            /// </summary>
            public class CancelRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleProtobufEmpty>
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
                        Pattern = @"^projects/[^/]+/operations/[^/]+$",
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
            public class GetRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleLongrunningOperation>
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
                        Pattern = @"^projects/[^/]+/operations/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists operations that match the specified filter in the request. If the server doesn't support this
            /// method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the binding
            /// to use different resource name schemes, such as `users/*/operations`. To override the binding, API
            /// services can add a binding such as `"/v1/{name=users/*}/operations"` to their service configuration. For
            /// backwards compatibility, the default name includes the operations collection id, however overriding
            /// users must ensure the name binding is the parent resource, without the operations collection id.
            /// </summary>
            /// <param name="name">The name of the operation's parent resource.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(service, name);
            }

            /// <summary>
            /// Lists operations that match the specified filter in the request. If the server doesn't support this
            /// method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the binding
            /// to use different resource name schemes, such as `users/*/operations`. To override the binding, API
            /// services can add a binding such as `"/v1/{name=users/*}/operations"` to their service configuration. For
            /// backwards compatibility, the default name includes the operations collection id, however overriding
            /// users must ensure the name binding is the parent resource, without the operations collection id.
            /// </summary>
            public class ListRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleLongrunningListOperationsResponse>
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

        /// <summary>
        /// Performs explanation on the data in the request. {% dynamic include
        /// "/ai-platform/includes/___explain-request" %}
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. The resource name of a model or a version. Authorization: requires the `predict` permission on the
        /// specified resource.
        /// </param>
        public virtual ExplainRequest Explain(Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1ExplainRequest body, string name)
        {
            return new ExplainRequest(service, body, name);
        }

        /// <summary>
        /// Performs explanation on the data in the request. {% dynamic include
        /// "/ai-platform/includes/___explain-request" %}
        /// </summary>
        public class ExplainRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleApiHttpBody>
        {
            /// <summary>Constructs a new Explain request.</summary>
            public ExplainRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1ExplainRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of a model or a version. Authorization: requires the `predict` permission on
            /// the specified resource.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1ExplainRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "explain";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:explain";

            /// <summary>Initializes Explain parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/.*$",
                });
            }
        }

        /// <summary>
        /// Get the service account information associated with your project. You need this information in order to
        /// grant the service account permissions for the Google Cloud Storage location where you put your model
        /// training code for training the model with Google Cloud Machine Learning.
        /// </summary>
        /// <param name="name">Required. The project name.</param>
        public virtual GetConfigRequest GetConfig(string name)
        {
            return new GetConfigRequest(service, name);
        }

        /// <summary>
        /// Get the service account information associated with your project. You need this information in order to
        /// grant the service account permissions for the Google Cloud Storage location where you put your model
        /// training code for training the model with Google Cloud Machine Learning.
        /// </summary>
        public class GetConfigRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1GetConfigResponse>
        {
            /// <summary>Constructs a new GetConfig request.</summary>
            public GetConfigRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The project name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getConfig";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:getConfig";

            /// <summary>Initializes GetConfig parameter list.</summary>
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
            }
        }

        /// <summary>
        /// Performs online prediction on the data in the request. {% dynamic include
        /// "/ai-platform/includes/___predict-request" %}
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. The resource name of a model or a version. Authorization: requires the `predict` permission on the
        /// specified resource.
        /// </param>
        public virtual PredictRequest Predict(Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1PredictRequest body, string name)
        {
            return new PredictRequest(service, body, name);
        }

        /// <summary>
        /// Performs online prediction on the data in the request. {% dynamic include
        /// "/ai-platform/includes/___predict-request" %}
        /// </summary>
        public class PredictRequest : CloudMachineLearningEngineBaseServiceRequest<Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleApiHttpBody>
        {
            /// <summary>Constructs a new Predict request.</summary>
            public PredictRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1PredictRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of a model or a version. Authorization: requires the `predict` permission on
            /// the specified resource.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudMachineLearningEngine.v1.Data.GoogleCloudMlV1PredictRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "predict";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:predict";

            /// <summary>Initializes Predict parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/.*$",
                });
            }
        }
    }
}
namespace Google.Apis.CloudMachineLearningEngine.v1.Data
{
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
    public class GoogleApiHttpBody : Google.Apis.Requests.IDirectResponseSchema
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
    /// Represents a hardware accelerator request config. Note that the AcceleratorConfig can be used in both Jobs and
    /// Versions. Learn more about [accelerators for training](/ml-engine/docs/using-gpus) and [accelerators for online
    /// prediction](/ml-engine/docs/machine-types-online-prediction#gpus).
    /// </summary>
    public class GoogleCloudMlV1AcceleratorConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of accelerators to attach to each machine running the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>The type of accelerator to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for the AddTrialMeasurement service method.</summary>
    public class GoogleCloudMlV1AddTrialMeasurementRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The measurement to be added to a trial.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("measurement")]
        public virtual GoogleCloudMlV1Measurement Measurement { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for automatically scaling a model.</summary>
    public class GoogleCloudMlV1AutoScaling : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The maximum number of nodes to scale this model under load. The actual value will depend on resource quota
        /// and availability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxNodes")]
        public virtual System.Nullable<int> MaxNodes { get; set; }

        /// <summary>MetricSpec contains the specifications to use to calculate the desired nodes count.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<GoogleCloudMlV1MetricSpec> Metrics { get; set; }

        /// <summary>
        /// Optional. The minimum number of nodes to allocate for this model. These nodes are always up, starting from
        /// the time the model is deployed. Therefore, the cost of operating this model will be at least `rate` *
        /// `min_nodes` * number of hours since last billing cycle, where `rate` is the cost per node-hour as documented
        /// in the [pricing guide](/ml-engine/docs/pricing), even if no predictions are performed. There is additional
        /// cost for each prediction performed. Unlike manual scaling, if the load gets too heavy for the nodes that are
        /// up, the service will automatically add nodes to handle the increased load as well as scale back as traffic
        /// drops, always maintaining at least `min_nodes`. You will be charged for the time in which additional nodes
        /// are used. If `min_nodes` is not specified and AutoScaling is used with a [legacy (MLS1) machine
        /// type](/ml-engine/docs/machine-types-online-prediction), `min_nodes` defaults to 0, in which case, when
        /// traffic to a model stops (and after a cool-down period), nodes will be shut down and no charges will be
        /// incurred until traffic to the model resumes. If `min_nodes` is not specified and AutoScaling is used with a
        /// [Compute Engine (N1) machine type](/ml-engine/docs/machine-types-online-prediction), `min_nodes` defaults to
        /// 1. `min_nodes` must be at least 1 for use with a Compute Engine machine type. You can set `min_nodes` when
        /// creating the model version, and you can also update `min_nodes` for an existing version: update_body.json: {
        /// 'autoScaling': { 'minNodes': 5 } } HTTP request: PATCH
        /// https://ml.googleapis.com/v1/{name=projects/*/models/*/versions/*}?update_mask=autoScaling.minNodes -d
        /// @./update_body.json
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minNodes")]
        public virtual System.Nullable<int> MinNodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for Automated Early Stopping of Trials. If no implementation_config is set, automated early
    /// stopping will not be run.
    /// </summary>
    public class GoogleCloudMlV1AutomatedStoppingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("decayCurveStoppingConfig")]
        public virtual GoogleCloudMlV1AutomatedStoppingConfigDecayCurveAutomatedStoppingConfig DecayCurveStoppingConfig { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("medianAutomatedStoppingConfig")]
        public virtual GoogleCloudMlV1AutomatedStoppingConfigMedianAutomatedStoppingConfig MedianAutomatedStoppingConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudMlV1AutomatedStoppingConfigDecayCurveAutomatedStoppingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If true, measurement.elapsed_time is used as the x-axis of each Trials Decay Curve. Otherwise,
        /// Measurement.steps will be used as the x-axis.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useElapsedTime")]
        public virtual System.Nullable<bool> UseElapsedTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The median automated stopping rule stops a pending trial if the trial's best objective_value is strictly below
    /// the median 'performance' of all completed trials reported up to the trial's last measurement. Currently,
    /// 'performance' refers to the running average of the objective values reported by the trial in each measurement.
    /// </summary>
    public class GoogleCloudMlV1AutomatedStoppingConfigMedianAutomatedStoppingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If true, the median automated stopping rule applies to measurement.use_elapsed_time, which means the
        /// elapsed_time field of the current trial's latest measurement is used to compute the median objective value
        /// for each completed trial.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useElapsedTime")]
        public virtual System.Nullable<bool> UseElapsedTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents output related to a built-in algorithm Job.</summary>
    public class GoogleCloudMlV1BuiltInAlgorithmOutput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Framework on which the built-in algorithm was trained.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("framework")]
        public virtual string Framework { get; set; }

        /// <summary>
        /// The Cloud Storage path to the `model/` directory where the training job saves the trained model. Only set
        /// for successful jobs that don't use hyperparameter tuning.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelPath")]
        public virtual string ModelPath { get; set; }

        /// <summary>Python version on which the built-in algorithm was trained.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pythonVersion")]
        public virtual string PythonVersion { get; set; }

        /// <summary>AI Platform runtime version on which the built-in algorithm was trained.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeVersion")]
        public virtual string RuntimeVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the CancelJob method.</summary>
    public class GoogleCloudMlV1CancelJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudMlV1Capability : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Available accelerators for the capability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableAccelerators")]
        public virtual System.Collections.Generic.IList<string> AvailableAccelerators { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This message will be placed in the metadata field of a google.longrunning.Operation associated with a
    /// CheckTrialEarlyStoppingState request.
    /// </summary>
    public class GoogleCloudMlV1CheckTrialEarlyStoppingStateMetatdata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time at which the operation was submitted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The name of the study that the trial belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("study")]
        public virtual string Study { get; set; }

        /// <summary>The trial name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trial")]
        public virtual string Trial { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for the CheckTrialEarlyStoppingState service method.</summary>
    public class GoogleCloudMlV1CheckTrialEarlyStoppingStateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The message will be placed in the response field of a completed google.longrunning.Operation associated with a
    /// CheckTrialEarlyStoppingState request.
    /// </summary>
    public class GoogleCloudMlV1CheckTrialEarlyStoppingStateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time at which operation processing completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>True if the Trial should stop.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shouldStop")]
        public virtual System.Nullable<bool> ShouldStop { get; set; }

        /// <summary>The time at which the operation was started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for the CompleteTrial service method.</summary>
    public class GoogleCloudMlV1CompleteTrialRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If provided, it will be used as the completed trial's final_measurement; Otherwise, the service
        /// will auto-select a previously reported measurement as the final-measurement
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalMeasurement")]
        public virtual GoogleCloudMlV1Measurement FinalMeasurement { get; set; }

        /// <summary>
        /// Optional. A human readable reason why the trial was infeasible. This should only be provided if
        /// `trial_infeasible` is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infeasibleReason")]
        public virtual string InfeasibleReason { get; set; }

        /// <summary>
        /// Optional. True if the trial cannot be run with the given Parameter, and final_measurement will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trialInfeasible")]
        public virtual System.Nullable<bool> TrialInfeasible { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudMlV1Config : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The service account Cloud ML uses to run on TPU node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tpuServiceAccount")]
        public virtual string TpuServiceAccount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a network port in a single container. This message is a subset of the [Kubernetes ContainerPort v1
    /// core specification](https://kubernetes.io/docs/reference/generated/kubernetes-api/v1.18/#containerport-v1-core).
    /// </summary>
    public class GoogleCloudMlV1ContainerPort : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Number of the port to expose on the container. This must be a valid port number: 0 &amp;lt; PORT_NUMBER
        /// &amp;lt; 65536.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerPort")]
        public virtual System.Nullable<int> ContainerPort { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specification of a custom container for serving predictions. This message is a subset of the [Kubernetes
    /// Container v1 core
    /// specification](https://kubernetes.io/docs/reference/generated/kubernetes-api/v1.18/#container-v1-core).
    /// </summary>
    public class GoogleCloudMlV1ContainerSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Immutable. Specifies arguments for the command that runs when the container starts. This overrides the
        /// container's [`CMD`](https://docs.docker.com/engine/reference/builder/#cmd). Specify this field as an array
        /// of executable and arguments, similar to a Docker `CMD`'s "default parameters" form. If you don't specify
        /// this field but do specify the command field, then the command from the `command` field runs without any
        /// additional arguments. See the [Kubernetes documentation about how the `command` and `args` fields interact
        /// with a container's `ENTRYPOINT` and
        /// `CMD`](https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#notes).
        /// If you don't specify this field and don't specify the `commmand` field, then the container's
        /// [`ENTRYPOINT`](https://docs.docker.com/engine/reference/builder/#cmd) and `CMD` determine what runs based on
        /// their default behavior. See the [Docker documentation about how `CMD` and `ENTRYPOINT`
        /// interact](https://docs.docker.com/engine/reference/builder/#understand-how-cmd-and-entrypoint-interact). In
        /// this field, you can reference [environment variables set by AI Platform
        /// Prediction](/ai-platform/prediction/docs/custom-container-requirements#aip-variables) and environment
        /// variables set in the env field. You cannot reference environment variables set in the Docker image. In order
        /// for environment variables to be expanded, reference them by using the following syntax: $( VARIABLE_NAME)
        /// Note that this differs from Bash variable expansion, which does not use parentheses. If a variable cannot be
        /// resolved, the reference in the input string is used unchanged. To avoid variable expansion, you can escape
        /// this syntax with `$$`; for example: $$(VARIABLE_NAME) This field corresponds to the `args` field of the
        /// [Kubernetes Containers v1 core
        /// API](https://kubernetes.io/docs/reference/generated/kubernetes-api/v1.18/#container-v1-core).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>
        /// Immutable. Specifies the command that runs when the container starts. This overrides the container's
        /// [`ENTRYPOINT`](https://docs.docker.com/engine/reference/builder/#entrypoint). Specify this field as an array
        /// of executable and arguments, similar to a Docker `ENTRYPOINT`'s "exec" form, not its "shell" form. If you do
        /// not specify this field, then the container's `ENTRYPOINT` runs, in conjunction with the args field or the
        /// container's [`CMD`](https://docs.docker.com/engine/reference/builder/#cmd), if either exists. If this field
        /// is not specified and the container does not have an `ENTRYPOINT`, then refer to the [Docker documentation
        /// about how `CMD` and `ENTRYPOINT`
        /// interact](https://docs.docker.com/engine/reference/builder/#understand-how-cmd-and-entrypoint-interact). If
        /// you specify this field, then you can also specify the `args` field to provide additional arguments for this
        /// command. However, if you specify this field, then the container's `CMD` is ignored. See the [Kubernetes
        /// documentation about how the `command` and `args` fields interact with a container's `ENTRYPOINT` and
        /// `CMD`](https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#notes).
        /// In this field, you can reference [environment variables set by AI Platform
        /// Prediction](/ai-platform/prediction/docs/custom-container-requirements#aip-variables) and environment
        /// variables set in the env field. You cannot reference environment variables set in the Docker image. In order
        /// for environment variables to be expanded, reference them by using the following syntax: $( VARIABLE_NAME)
        /// Note that this differs from Bash variable expansion, which does not use parentheses. If a variable cannot be
        /// resolved, the reference in the input string is used unchanged. To avoid variable expansion, you can escape
        /// this syntax with `$$`; for example: $$(VARIABLE_NAME) This field corresponds to the `command` field of the
        /// [Kubernetes Containers v1 core
        /// API](https://kubernetes.io/docs/reference/generated/kubernetes-api/v1.18/#container-v1-core).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("command")]
        public virtual System.Collections.Generic.IList<string> Command { get; set; }

        /// <summary>
        /// Immutable. List of environment variables to set in the container. After the container starts running, code
        /// running in the container can read these environment variables. Additionally, the command and args fields can
        /// reference these variables. Later entries in this list can also reference earlier entries. For example, the
        /// following example sets the variable `VAR_2` to have the value `foo bar`: ```json [ { "name": "VAR_1",
        /// "value": "foo" }, { "name": "VAR_2", "value": "$(VAR_1) bar" } ] ``` If you switch the order of the
        /// variables in the example, then the expansion does not occur. This field corresponds to the `env` field of
        /// the [Kubernetes Containers v1 core
        /// API](https://kubernetes.io/docs/reference/generated/kubernetes-api/v1.18/#container-v1-core).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual System.Collections.Generic.IList<GoogleCloudMlV1EnvVar> Env { get; set; }

        /// <summary>
        /// URI of the Docker image to be used as the custom container for serving predictions. This URI must identify
        /// [an image in Artifact Registry](/artifact-registry/docs/overview) and begin with the hostname
        /// `{REGION}-docker.pkg.dev`, where `{REGION}` is replaced by the region that matches AI Platform Prediction
        /// [regional endpoint](/ai-platform/prediction/docs/regional-endpoints) that you are using. For example, if you
        /// are using the `us-central1-ml.googleapis.com` endpoint, then this URI must begin with
        /// `us-central1-docker.pkg.dev`. To use a custom container, the [AI Platform Google-managed service
        /// account](/ai-platform/prediction/docs/custom-service-account#default) must have permission to pull (read)
        /// the Docker image at this URI. The AI Platform Google-managed service account has the following format:
        /// `service-{PROJECT_NUMBER}@cloud-ml.google.com.iam.gserviceaccount.com` {PROJECT_NUMBER} is replaced by your
        /// Google Cloud project number. By default, this service account has necessary permissions to pull an Artifact
        /// Registry image in the same Google Cloud project where you are using AI Platform Prediction. In this case, no
        /// configuration is necessary. If you want to use an image from a different Google Cloud project, learn how to
        /// [grant the Artifact Registry Reader (roles/artifactregistry.reader) role for a
        /// repository](/artifact-registry/docs/access-control#grant-repo) to your projet's AI Platform Google-managed
        /// service account. To learn about the requirements for the Docker image itself, read [Custom container
        /// requirements](/ai-platform/prediction/docs/custom-container-requirements).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual string Image { get; set; }

        /// <summary>
        /// Immutable. List of ports to expose from the container. AI Platform Prediction sends any prediction requests
        /// that it receives to the first port on this list. AI Platform Prediction also sends [liveness and health
        /// checks](/ai-platform/prediction/docs/custom-container-requirements#health) to this port. If you do not
        /// specify this field, it defaults to following value: ```json [ { "containerPort": 8080 } ] ``` AI Platform
        /// Prediction does not use ports other than the first one listed. This field corresponds to the `ports` field
        /// of the [Kubernetes Containers v1 core
        /// API](https://kubernetes.io/docs/reference/generated/kubernetes-api/v1.18/#container-v1-core).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ports")]
        public virtual System.Collections.Generic.IList<GoogleCloudMlV1ContainerPort> Ports { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the config of disk options.</summary>
    public class GoogleCloudMlV1DiskConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Size in GB of the boot disk (default is 100GB).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootDiskSizeGb")]
        public virtual System.Nullable<int> BootDiskSizeGb { get; set; }

        /// <summary>
        /// Type of the boot disk (default is "pd-ssd"). Valid values: "pd-ssd" (Persistent Disk Solid State Drive) or
        /// "pd-standard" (Persistent Disk Hard Disk Drive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootDiskType")]
        public virtual string BootDiskType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a custom encryption key configuration that can be applied to a resource.</summary>
    public class GoogleCloudMlV1EncryptionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Cloud KMS resource identifier of the customer-managed encryption key used to protect a resource, such as
        /// a training job. It has the following format:
        /// `projects/{PROJECT_ID}/locations/{REGION}/keyRings/{KEY_RING_NAME}/cryptoKeys/{KEY_NAME}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents an environment variable to be made available in a container. This message is a subset of the
    /// [Kubernetes EnvVar v1 core
    /// specification](https://kubernetes.io/docs/reference/generated/kubernetes-api/v1.18/#envvar-v1-core).
    /// </summary>
    public class GoogleCloudMlV1EnvVar : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Name of the environment variable. Must be a [valid C
        /// identifier](https://github.com/kubernetes/kubernetes/blob/v1.18.8/staging/src/k8s.io/apimachinery/pkg/util/validation/validation.go#L258)
        /// and must not begin with the prefix `AIP_`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Value of the environment variable. Defaults to an empty string. In this field, you can reference
        /// [environment variables set by AI Platform
        /// Prediction](/ai-platform/prediction/docs/custom-container-requirements#aip-variables) and environment
        /// variables set earlier in the same env field as where this message occurs. You cannot reference environment
        /// variables set in the Docker image. In order for environment variables to be expanded, reference them by
        /// using the following syntax: $(VARIABLE_NAME) Note that this differs from Bash variable expansion, which does
        /// not use parentheses. If a variable cannot be resolved, the reference in the input string is used unchanged.
        /// To avoid variable expansion, you can escape this syntax with `$$`; for example: $$(VARIABLE_NAME)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for explanations to be issued against a trained model.</summary>
    public class GoogleCloudMlV1ExplainRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The explanation request body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpBody")]
        public virtual GoogleApiHttpBody HttpBody { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message holding configuration options for explaining model predictions. There are three feature attribution
    /// methods supported for TensorFlow models: integrated gradients, sampled Shapley, and XRAI. [Learn more about
    /// feature attributions.](/ai-platform/prediction/docs/ai-explanations/overview)
    /// </summary>
    public class GoogleCloudMlV1ExplanationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Attributes credit by computing the Aumann-Shapley value taking advantage of the model's fully differentiable
        /// structure. Refer to this paper for more details: https://arxiv.org/abs/1703.01365
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integratedGradientsAttribution")]
        public virtual GoogleCloudMlV1IntegratedGradientsAttribution IntegratedGradientsAttribution { get; set; }

        /// <summary>
        /// An attribution method that approximates Shapley values for features that contribute to the label being
        /// predicted. A sampling strategy is used to approximate the value rather than considering all subsets of
        /// features.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampledShapleyAttribution")]
        public virtual GoogleCloudMlV1SampledShapleyAttribution SampledShapleyAttribution { get; set; }

        /// <summary>
        /// Attributes credit by computing the XRAI taking advantage of the model's fully differentiable structure.
        /// Refer to this paper for more details: https://arxiv.org/abs/1906.02825 Currently only implemented for models
        /// with natural image inputs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("xraiAttribution")]
        public virtual GoogleCloudMlV1XraiAttribution XraiAttribution { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Returns service account information associated with a project.</summary>
    public class GoogleCloudMlV1GetConfigResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual GoogleCloudMlV1Config Config { get; set; }

        /// <summary>The service account Cloud ML uses to access resources in the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>The project number for `service_account`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountProject")]
        public virtual System.Nullable<long> ServiceAccountProject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the result of a single hyperparameter tuning trial from a training job. The TrainingOutput object
    /// that is returned on successful completion of a training job with hyperparameter tuning includes a list of
    /// HyperparameterOutput objects, one for each successful trial.
    /// </summary>
    public class GoogleCloudMlV1HyperparameterOutput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All recorded object metrics for this trial. This field is not currently populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allMetrics")]
        public virtual System.Collections.Generic.IList<GoogleCloudMlV1HyperparameterOutputHyperparameterMetric> AllMetrics { get; set; }

        /// <summary>
        /// Details related to built-in algorithms jobs. Only set for trials of built-in algorithms jobs that have
        /// succeeded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("builtInAlgorithmOutput")]
        public virtual GoogleCloudMlV1BuiltInAlgorithmOutput BuiltInAlgorithmOutput { get; set; }

        /// <summary>Output only. End time for the trial.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The final objective metric seen for this trial.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalMetric")]
        public virtual GoogleCloudMlV1HyperparameterOutputHyperparameterMetric FinalMetric { get; set; }

        /// <summary>The hyperparameters given to this trial.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hyperparameters")]
        public virtual System.Collections.Generic.IDictionary<string, string> Hyperparameters { get; set; }

        /// <summary>True if the trial is stopped early.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isTrialStoppedEarly")]
        public virtual System.Nullable<bool> IsTrialStoppedEarly { get; set; }

        /// <summary>Output only. Start time for the trial.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>Output only. The detailed state of the trial.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The trial id for these results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trialId")]
        public virtual string TrialId { get; set; }

        /// <summary>
        /// The web URIs for the training job. Currently for debug terminal access to the job. Only set for in-progress
        /// hyperparameter tuning trials with web access enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webAccessUris")]
        public virtual System.Collections.Generic.IDictionary<string, string> WebAccessUris { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An observed value of a metric.</summary>
    public class GoogleCloudMlV1HyperparameterOutputHyperparameterMetric : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The objective value at this training step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectiveValue")]
        public virtual System.Nullable<double> ObjectiveValue { get; set; }

        /// <summary>The global training step for this metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingStep")]
        public virtual System.Nullable<long> TrainingStep { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a set of hyperparameters to optimize.</summary>
    public class GoogleCloudMlV1HyperparameterSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The search algorithm specified for the hyperparameter tuning job. Uses the default AI Platform
        /// hyperparameter tuning algorithm if unspecified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("algorithm")]
        public virtual string Algorithm { get; set; }

        /// <summary>Optional. Indicates if the hyperparameter tuning job enables auto trial early stopping.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableTrialEarlyStopping")]
        public virtual System.Nullable<bool> EnableTrialEarlyStopping { get; set; }

        /// <summary>
        /// Required. The type of goal to use for tuning. Available types are `MAXIMIZE` and `MINIMIZE`. Defaults to
        /// `MAXIMIZE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goal")]
        public virtual string Goal { get; set; }

        /// <summary>
        /// Optional. The TensorFlow summary tag name to use for optimizing trials. For current versions of TensorFlow,
        /// this tag name should exactly match what is shown in TensorBoard, including all scopes. For versions of
        /// TensorFlow prior to 0.12, this should be only the tag passed to tf.Summary. By default,
        /// "training/hptuning/metric" will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hyperparameterMetricTag")]
        public virtual string HyperparameterMetricTag { get; set; }

        /// <summary>
        /// Optional. The number of failed trials that need to be seen before failing the hyperparameter tuning job. You
        /// can specify this field to override the default failing criteria for AI Platform hyperparameter tuning jobs.
        /// Defaults to zero, which means the service decides when a hyperparameter job should fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxFailedTrials")]
        public virtual System.Nullable<int> MaxFailedTrials { get; set; }

        /// <summary>
        /// Optional. The number of training trials to run concurrently. You can reduce the time it takes to perform
        /// hyperparameter tuning by adding trials in parallel. However, each trail only benefits from the information
        /// gained in completed trials. That means that a trial does not get access to the results of trials running at
        /// the same time, which could reduce the quality of the overall optimization. Each trial will use the same
        /// scale tier and machine types. Defaults to one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxParallelTrials")]
        public virtual System.Nullable<int> MaxParallelTrials { get; set; }

        /// <summary>
        /// Optional. How many training trials should be attempted to optimize the specified hyperparameters. Defaults
        /// to one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxTrials")]
        public virtual System.Nullable<int> MaxTrials { get; set; }

        /// <summary>Required. The set of parameters to tune.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("params")]
        public virtual System.Collections.Generic.IList<GoogleCloudMlV1ParameterSpec> Params__ { get; set; }

        /// <summary>
        /// Optional. The prior hyperparameter tuning job id that users hope to continue with. The job id will be used
        /// to find the corresponding vizier study guid and resume the study.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resumePreviousJobId")]
        public virtual string ResumePreviousJobId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Attributes credit by computing the Aumann-Shapley value taking advantage of the model's fully differentiable
    /// structure. Refer to this paper for more details: https://arxiv.org/abs/1703.01365
    /// </summary>
    public class GoogleCloudMlV1IntegratedGradientsAttribution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Number of steps for approximating the path integral. A good value to start is 50 and gradually increase
        /// until the sum to diff property is met within the desired error range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numIntegralSteps")]
        public virtual System.Nullable<int> NumIntegralSteps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a training or prediction job.</summary>
    public class GoogleCloudMlV1Job : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. When the job was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. When the job processing was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Output only. The details of a failure or a cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>
        /// `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a job
        /// from overwriting each other. It is strongly suggested that systems make use of the `etag` in the
        /// read-modify-write cycle to perform job updates in order to avoid race conditions: An `etag` is returned in
        /// the response to `GetJob`, and systems are expected to put that etag in the request to `UpdateJob` to ensure
        /// that their change will be applied to the same version of the job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Required. The user-specified id of the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobId")]
        public virtual string JobId { get; set; }

        /// <summary>
        /// Optional. One or more labels that you can add, to organize your jobs. Each label is a key-value pair, where
        /// both the key and the value are arbitrary strings that you supply. For more information, see the
        /// documentation on using labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Input parameters to create a prediction job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predictionInput")]
        public virtual GoogleCloudMlV1PredictionInput PredictionInput { get; set; }

        /// <summary>The current prediction job result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predictionOutput")]
        public virtual GoogleCloudMlV1PredictionOutput PredictionOutput { get; set; }

        /// <summary>Output only. When the job processing was started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>Output only. The detailed state of a job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Input parameters to create a training job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingInput")]
        public virtual GoogleCloudMlV1TrainingInput TrainingInput { get; set; }

        /// <summary>The current training job result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingOutput")]
        public virtual GoogleCloudMlV1TrainingOutput TrainingOutput { get; set; }
    }

    /// <summary>Response message for the ListJobs method.</summary>
    public class GoogleCloudMlV1ListJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of jobs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobs")]
        public virtual System.Collections.Generic.IList<GoogleCloudMlV1Job> Jobs { get; set; }

        /// <summary>Optional. Pass this token as the `page_token` field of the request for a subsequent call.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudMlV1ListLocationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Locations where at least one type of CMLE capability is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<GoogleCloudMlV1Location> Locations { get; set; }

        /// <summary>Optional. Pass this token as the `page_token` field of the request for a subsequent call.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the ListModels method.</summary>
    public class GoogleCloudMlV1ListModelsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("models")]
        public virtual System.Collections.Generic.IList<GoogleCloudMlV1Model> Models { get; set; }

        /// <summary>Optional. Pass this token as the `page_token` field of the request for a subsequent call.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for the ListTrials service method.</summary>
    public class GoogleCloudMlV1ListOptimalTrialsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for the ListOptimalTrials method.</summary>
    public class GoogleCloudMlV1ListOptimalTrialsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The pareto-optimal trials for multiple objective study or the optimal trial for single objective study. The
        /// definition of pareto-optimal can be checked in wiki page. https://en.wikipedia.org/wiki/Pareto_efficiency
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trials")]
        public virtual System.Collections.Generic.IList<GoogleCloudMlV1Trial> Trials { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudMlV1ListStudiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The studies associated with the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("studies")]
        public virtual System.Collections.Generic.IList<GoogleCloudMlV1Study> Studies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for the ListTrials method.</summary>
    public class GoogleCloudMlV1ListTrialsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The trials associated with the study.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trials")]
        public virtual System.Collections.Generic.IList<GoogleCloudMlV1Trial> Trials { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the ListVersions method.</summary>
    public class GoogleCloudMlV1ListVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Pass this token as the `page_token` field of the request for a subsequent call.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versions")]
        public virtual System.Collections.Generic.IList<GoogleCloudMlV1Version> Versions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudMlV1Location : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Capabilities available in the location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capabilities")]
        public virtual System.Collections.Generic.IList<GoogleCloudMlV1Capability> Capabilities { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for manually scaling a model.</summary>
    public class GoogleCloudMlV1ManualScaling : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of nodes to allocate for this model. These nodes are always up, starting from the time the model
        /// is deployed, so the cost of operating this model will be proportional to `nodes` * number of hours since
        /// last billing cycle plus the cost for each prediction performed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Nullable<int> Nodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message representing a measurement.</summary>
    public class GoogleCloudMlV1Measurement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Time that the trial has been running at the point of this measurement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elapsedTime")]
        public virtual object ElapsedTime { get; set; }

        /// <summary>Provides a list of metrics that act as inputs into the objective function.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<GoogleCloudMlV1MeasurementMetric> Metrics { get; set; }

        /// <summary>The number of steps a machine learning model has been trained for. Must be non-negative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stepCount")]
        public virtual System.Nullable<long> StepCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message representing a metric in the measurement.</summary>
    public class GoogleCloudMlV1MeasurementMetric : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Metric name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metric")]
        public virtual string Metric { get; set; }

        /// <summary>Required. The value for this metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// MetricSpec contains the specifications to use to calculate the desired nodes count when autoscaling is enabled.
    /// </summary>
    public class GoogleCloudMlV1MetricSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>metric name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Target specifies the target value for the given metric; once real metric deviates from the threshold by a
        /// certain percentage, the node count changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual System.Nullable<int> Target { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a machine learning solution. A model can have multiple versions, each of which is a deployed, trained
    /// model ready to receive prediction requests. The model itself is just a container.
    /// </summary>
    public class GoogleCloudMlV1Model : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The default version of the model. This version will be used to handle prediction requests that
        /// do not specify a version. You can change the default version by calling projects.models.versions.setDefault.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultVersion")]
        public virtual GoogleCloudMlV1Version DefaultVersion { get; set; }

        /// <summary>Optional. The description specified for the model when it was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a model
        /// from overwriting each other. It is strongly suggested that systems make use of the `etag` in the
        /// read-modify-write cycle to perform model updates in order to avoid race conditions: An `etag` is returned in
        /// the response to `GetModel`, and systems are expected to put that etag in the request to `UpdateModel` to
        /// ensure that their change will be applied to the model as intended.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. One or more labels that you can add, to organize your models. Each label is a key-value pair,
        /// where both the key and the value are arbitrary strings that you supply. For more information, see the
        /// documentation on using labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. The name specified for the model when it was created. The model name must be unique within the
        /// project it is created in.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. If true, online prediction nodes send `stderr` and `stdout` streams to Cloud Logging. These can be
        /// more verbose than the standard access logs (see `onlinePredictionLogging`) and can incur higher cost.
        /// However, they are helpful for debugging. Note that [logs may incur a cost](/stackdriver/pricing), especially
        /// if your project receives prediction requests at a high QPS. Estimate your costs before enabling this option.
        /// Default is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onlinePredictionConsoleLogging")]
        public virtual System.Nullable<bool> OnlinePredictionConsoleLogging { get; set; }

        /// <summary>
        /// Optional. If true, online prediction access logs are sent to Cloud Logging. These logs are like standard
        /// server access logs, containing information like timestamp and latency for each request. Note that [logs may
        /// incur a cost](/stackdriver/pricing), especially if your project receives prediction requests at a high
        /// queries per second rate (QPS). Estimate your costs before enabling this option. Default is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onlinePredictionLogging")]
        public virtual System.Nullable<bool> OnlinePredictionLogging { get; set; }

        /// <summary>
        /// Optional. The list of regions where the model is going to be deployed. Only one region per model is
        /// supported. Defaults to 'us-central1' if nothing is set. See the available regions for AI Platform services.
        /// Note: * No matter where a model is deployed, it can always be accessed by users from anywhere, both for
        /// online and batch prediction. * The region for a batch prediction job is set by the region field when
        /// submitting the batch prediction job and does not take its value from this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regions")]
        public virtual System.Collections.Generic.IList<string> Regions { get; set; }
    }

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class GoogleCloudMlV1OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time the operation was submitted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The time operation processing completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Indicates whether a request to cancel this operation has been made.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isCancellationRequested")]
        public virtual System.Nullable<bool> IsCancellationRequested { get; set; }

        /// <summary>The user labels, inherited from the model or the model version being operated on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Contains the name of the model associated with the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelName")]
        public virtual string ModelName { get; set; }

        /// <summary>The operation type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationType")]
        public virtual string OperationType { get; set; }

        /// <summary>Contains the project number associated with the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectNumber")]
        public virtual System.Nullable<long> ProjectNumber { get; set; }

        /// <summary>The time operation processing started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>Contains the version associated with the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual GoogleCloudMlV1Version Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a single hyperparameter to optimize.</summary>
    public class GoogleCloudMlV1ParameterSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required if type is `CATEGORICAL`. The list of possible categories.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoricalValues")]
        public virtual System.Collections.Generic.IList<string> CategoricalValues { get; set; }

        /// <summary>
        /// Required if type is `DISCRETE`. A list of feasible points. The list should be in strictly increasing order.
        /// For instance, this parameter might have possible settings of 1.5, 2.5, and 4.0. This list should not contain
        /// more than 1,000 values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discreteValues")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> DiscreteValues { get; set; }

        /// <summary>
        /// Required if type is `DOUBLE` or `INTEGER`. This field should be unset if type is `CATEGORICAL`. This value
        /// should be integers if type is `INTEGER`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxValue")]
        public virtual System.Nullable<double> MaxValue { get; set; }

        /// <summary>
        /// Required if type is `DOUBLE` or `INTEGER`. This field should be unset if type is `CATEGORICAL`. This value
        /// should be integers if type is INTEGER.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minValue")]
        public virtual System.Nullable<double> MinValue { get; set; }

        /// <summary>
        /// Required. The parameter name must be unique amongst all ParameterConfigs in a HyperparameterSpec message.
        /// E.g., "learning_rate".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterName")]
        public virtual string ParameterName { get; set; }

        /// <summary>
        /// Optional. How the parameter should be scaled to the hypercube. Leave unset for categorical parameters. Some
        /// kind of scaling is strongly recommended for real or integral parameters (e.g., `UNIT_LINEAR_SCALE`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scaleType")]
        public virtual string ScaleType { get; set; }

        /// <summary>Required. The type of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for predictions to be issued against a trained model.</summary>
    public class GoogleCloudMlV1PredictRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        ///  Required. The prediction request body. Refer to the [request body details section](#request-body-details)
        /// for more information on how to structure your request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpBody")]
        public virtual GoogleApiHttpBody HttpBody { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents input parameters for a prediction job.</summary>
    public class GoogleCloudMlV1PredictionInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Number of records per batch, defaults to 64. The service will buffer batch_size number of records
        /// in memory before invoking one Tensorflow prediction call internally. So take the record size and memory
        /// available into consideration when setting this parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchSize")]
        public virtual System.Nullable<long> BatchSize { get; set; }

        /// <summary>Required. The format of the input data files.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataFormat")]
        public virtual string DataFormat { get; set; }

        /// <summary>Required. The Cloud Storage location of the input data files. May contain wildcards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputPaths")]
        public virtual System.Collections.Generic.IList<string> InputPaths { get; set; }

        /// <summary>
        /// Optional. The maximum number of workers to be used for parallel processing. Defaults to 10 if not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxWorkerCount")]
        public virtual System.Nullable<long> MaxWorkerCount { get; set; }

        /// <summary>
        /// Use this field if you want to use the default version for the specified model. The string must use the
        /// following format: `"projects/YOUR_PROJECT/models/YOUR_MODEL"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelName")]
        public virtual string ModelName { get; set; }

        /// <summary>Optional. Format of the output data files, defaults to JSON.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputDataFormat")]
        public virtual string OutputDataFormat { get; set; }

        /// <summary>Required. The output Google Cloud Storage location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputPath")]
        public virtual string OutputPath { get; set; }

        /// <summary>
        /// Required. The Google Compute Engine region to run the prediction job in. See the available regions for AI
        /// Platform services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>
        /// Optional. The AI Platform runtime version to use for this batch prediction. If not set, AI Platform will
        /// pick the runtime version used during the CreateVersion request for this model version, or choose the latest
        /// stable version when model version information is not available such as when the model is specified by uri.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeVersion")]
        public virtual string RuntimeVersion { get; set; }

        /// <summary>
        /// Optional. The name of the signature defined in the SavedModel to use for this job. Please refer to
        /// [SavedModel](https://tensorflow.github.io/serving/serving_basic.html) for information about how to use
        /// signatures. Defaults to
        /// [DEFAULT_SERVING_SIGNATURE_DEF_KEY](https://www.tensorflow.org/api_docs/python/tf/saved_model/signature_constants)
        /// , which is "serving_default".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signatureName")]
        public virtual string SignatureName { get; set; }

        /// <summary>Use this field if you want to specify a Google Cloud Storage path for the model to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>
        /// Use this field if you want to specify a version of the model to use. The string is formatted the same way as
        /// `model_version`, with the addition of the version information:
        /// `"projects/YOUR_PROJECT/models/YOUR_MODEL/versions/YOUR_VERSION"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionName")]
        public virtual string VersionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents results of a prediction job.</summary>
    public class GoogleCloudMlV1PredictionOutput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of data instances which resulted in errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCount")]
        public virtual System.Nullable<long> ErrorCount { get; set; }

        /// <summary>Node hours used by the batch prediction job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeHours")]
        public virtual System.Nullable<double> NodeHours { get; set; }

        /// <summary>The output Google Cloud Storage location provided at the job creation time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputPath")]
        public virtual string OutputPath { get; set; }

        /// <summary>The number of generated predictions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predictionCount")]
        public virtual System.Nullable<long> PredictionCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the configuration for a replica in a cluster.</summary>
    public class GoogleCloudMlV1ReplicaConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Represents the type and number of accelerators used by the replica. [Learn about restrictions on accelerator
        /// configurations for training.](/ai-platform/training/docs/using-gpus#compute-engine-machine-types-with-gpu)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceleratorConfig")]
        public virtual GoogleCloudMlV1AcceleratorConfig AcceleratorConfig { get; set; }

        /// <summary>
        /// Arguments to the entrypoint command. The following rules apply for container_command and container_args: -
        /// If you do not supply command or args: The defaults defined in the Docker image are used. - If you supply a
        /// command but no args: The default EntryPoint and the default Cmd defined in the Docker image are ignored.
        /// Your command is run without any arguments. - If you supply only args: The default Entrypoint defined in the
        /// Docker image is run with the args that you supplied. - If you supply a command and args: The default
        /// Entrypoint and the default Cmd defined in the Docker image are ignored. Your command is run with your args.
        /// It cannot be set if custom container image is not provided. Note that this field and [TrainingInput.args]
        /// are mutually exclusive, i.e., both cannot be set at the same time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerArgs")]
        public virtual System.Collections.Generic.IList<string> ContainerArgs { get; set; }

        /// <summary>
        /// The command with which the replica's custom container is run. If provided, it will override default
        /// ENTRYPOINT of the docker image. If not provided, the docker image's ENTRYPOINT is used. It cannot be set if
        /// custom container image is not provided. Note that this field and [TrainingInput.args] are mutually
        /// exclusive, i.e., both cannot be set at the same time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerCommand")]
        public virtual System.Collections.Generic.IList<string> ContainerCommand { get; set; }

        /// <summary>Represents the configuration of disk options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskConfig")]
        public virtual GoogleCloudMlV1DiskConfig DiskConfig { get; set; }

        /// <summary>
        /// The Docker image to run on the replica. This image must be in Container Registry. Learn more about
        /// [configuring custom containers](/ai-platform/training/docs/distributed-training-containers).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; }

        /// <summary>
        /// The AI Platform runtime version that includes a TensorFlow version matching the one used in the custom
        /// container. This field is required if the replica is a TPU worker that uses a custom container. Otherwise, do
        /// not specify this field. This must be a [runtime version that currently supports training with
        /// TPUs](/ml-engine/docs/tensorflow/runtime-version-list#tpu-support). Note that the version of TensorFlow
        /// included in a runtime version may differ from the numbering of the runtime version itself, because it may
        /// have a different [patch version](https://www.tensorflow.org/guide/version_compat#semantic_versioning_20). In
        /// this field, you must specify the runtime version (TensorFlow minor version). For example, if your custom
        /// container runs TensorFlow `1.x.y`, specify `1.x`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tpuTfVersion")]
        public virtual string TpuTfVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for logging request-response pairs to a BigQuery table. Online prediction requests to a model
    /// version and the responses to these requests are converted to raw strings and saved to the specified BigQuery
    /// table. Logging is constrained by [BigQuery quotas and limits](/bigquery/quotas). If your project exceeds
    /// BigQuery quotas or limits, AI Platform Prediction does not log request-response pairs, but it continues to serve
    /// predictions. If you are using [continuous evaluation](/ml-engine/docs/continuous-evaluation/), you do not need
    /// to specify this configuration manually. Setting up continuous evaluation automatically enables logging of
    /// request-response pairs.
    /// </summary>
    public class GoogleCloudMlV1RequestLoggingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Fully qualified BigQuery table name in the following format: " project_id.dataset_name.table_name"
        /// The specified table must already exist, and the "Cloud ML Service Agent" for your project must have
        /// permission to write to it. The table must have the following [schema](/bigquery/docs/schemas): Field
        /// nameType Mode model STRING REQUIRED model_version STRING REQUIRED time TIMESTAMP REQUIRED raw_data STRING
        /// REQUIRED raw_prediction STRING NULLABLE groundtruth STRING NULLABLE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryTableName")]
        public virtual string BigqueryTableName { get; set; }

        /// <summary>
        /// Percentage of requests to be logged, expressed as a fraction from 0 to 1. For example, if you want to log
        /// 10% of requests, enter `0.1`. The sampling window is the lifetime of the model version. Defaults to 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("samplingPercentage")]
        public virtual System.Nullable<double> SamplingPercentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies HTTP paths served by a custom container. AI Platform Prediction sends requests to these paths on the
    /// container; the custom container must run an HTTP server that responds to these requests with appropriate
    /// responses. Read [Custom container requirements](/ai-platform/prediction/docs/custom-container-requirements) for
    /// details on how to create your container image to meet these requirements.
    /// </summary>
    public class GoogleCloudMlV1RouteMap : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// HTTP path on the container to send health checkss to. AI Platform Prediction intermittently sends GET
        /// requests to this path on the container's IP address and port to check that the container is healthy. Read
        /// more about [health checks](/ai-platform/prediction/docs/custom-container-requirements#checks). For example,
        /// if you set this field to `/bar`, then AI Platform Prediction intermittently sends a GET request to the
        /// `/bar` path on the port of your container specified by the first value of Version.container.ports. If you
        /// don't specify this field, it defaults to the following value: /v1/models/ MODEL/versions/VERSION The
        /// placeholders in this value are replaced as follows: * MODEL: The name of the parent Model. This does not
        /// include the "projects/PROJECT_ID/models/" prefix that the API returns in output; it is the bare model name,
        /// as provided to projects.models.create. * VERSION: The name of the model version. This does not include the
        /// "projects/PROJECT_ID /models/MODEL/versions/" prefix that the API returns in output; it is the bare version
        /// name, as provided to projects.models.versions.create.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("health")]
        public virtual string Health { get; set; }

        /// <summary>
        /// HTTP path on the container to send prediction requests to. AI Platform Prediction forwards requests sent
        /// using projects.predict to this path on the container's IP address and port. AI Platform Prediction then
        /// returns the container's response in the API response. For example, if you set this field to `/foo`, then
        /// when AI Platform Prediction receives a prediction request, it forwards the request body in a POST request to
        /// the `/foo` path on the port of your container specified by the first value of Version.container.ports. If
        /// you don't specify this field, it defaults to the following value: /v1/models/MODEL/versions/VERSION:predict
        /// The placeholders in this value are replaced as follows: * MODEL: The name of the parent Model. This does not
        /// include the "projects/PROJECT_ID/models/" prefix that the API returns in output; it is the bare model name,
        /// as provided to projects.models.create. * VERSION: The name of the model version. This does not include the
        /// "projects/PROJECT_ID/models/MODEL/versions/" prefix that the API returns in output; it is the bare version
        /// name, as provided to projects.models.versions.create.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predict")]
        public virtual string Predict { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An attribution method that approximates Shapley values for features that contribute to the label being
    /// predicted. A sampling strategy is used to approximate the value rather than considering all subsets of features.
    /// </summary>
    public class GoogleCloudMlV1SampledShapleyAttribution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of feature permutations to consider when approximating the Shapley values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numPaths")]
        public virtual System.Nullable<int> NumPaths { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>All parameters related to scheduling of training jobs.</summary>
    public class GoogleCloudMlV1Scheduling : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The maximum job running time, expressed in seconds. The field can contain up to nine fractional
        /// digits, terminated by `s`. If not specified, this field defaults to `604800s` (seven days). If the training
        /// job is still running after this duration, AI Platform Training cancels it. The duration is measured from
        /// when the job enters the `RUNNING` state; therefore it does not overlap with the duration limited by
        /// Scheduling.max_wait_time. For example, if you want to ensure your job runs for no more than 2 hours, set
        /// this field to `7200s` (2 hours * 60 minutes / hour * 60 seconds / minute). If you submit your training job
        /// using the `gcloud` tool, you can [specify this field in a `config.yaml`
        /// file](/ai-platform/training/docs/training-jobs#formatting_your_configuration_parameters). For example:
        /// ```yaml trainingInput: scheduling: maxRunningTime: 7200s ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxRunningTime")]
        public virtual object MaxRunningTime { get; set; }

        /// <summary>
        /// Optional. The maximum job wait time, expressed in seconds. The field can contain up to nine fractional
        /// digits, terminated by `s`. If not specified, there is no limit to the wait time. The minimum for this field
        /// is `1800s` (30 minutes). If the training job has not entered the `RUNNING` state after this duration, AI
        /// Platform Training cancels it. After the job begins running, it can no longer be cancelled due to the maximum
        /// wait time. Therefore the duration limited by this field does not overlap with the duration limited by
        /// Scheduling.max_running_time. For example, if the job temporarily stops running and retries due to a [VM
        /// restart](/ai-platform/training/docs/overview#restarts), this cannot lead to a maximum wait time
        /// cancellation. However, independently of this constraint, AI Platform Training might stop a job if there are
        /// too many retries due to exhausted resources in a region. The following example describes how you might use
        /// this field: To cancel your job if it doesn't start running within 1 hour, set this field to `3600s` (1 hour
        /// * 60 minutes / hour * 60 seconds / minute). If the job is still in the `QUEUED` or `PREPARING` state after
        /// an hour of waiting, AI Platform Training cancels the job. If you submit your training job using the `gcloud`
        /// tool, you can [specify this field in a `config.yaml`
        /// file](/ai-platform/training/docs/training-jobs#formatting_your_configuration_parameters). For example:
        /// ```yaml trainingInput: scheduling: maxWaitTime: 3600s ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxWaitTime")]
        public virtual object MaxWaitTime { get; set; }

        /// <summary>
        /// Optional. Job scheduling will be based on this priority, which in the range [0, 1000]. The bigger the
        /// number, the higher the priority. Default to 0 if not set. If there are multiple jobs requesting same type of
        /// accelerators, the high priority job will be scheduled prior to ones with low priority.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual System.Nullable<int> Priority { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the SetDefaultVersion request.</summary>
    public class GoogleCloudMlV1SetDefaultVersionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudMlV1StopTrialRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message representing a Study.</summary>
    public class GoogleCloudMlV1Study : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Time at which the study was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Output only. A human readable reason why the Study is inactive. This should be empty if a study is ACTIVE or
        /// COMPLETED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inactiveReason")]
        public virtual string InactiveReason { get; set; }

        /// <summary>Output only. The name of a study.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The detailed state of a study.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Required. Configuration of the study.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("studyConfig")]
        public virtual GoogleCloudMlV1StudyConfig StudyConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents configuration of a study.</summary>
    public class GoogleCloudMlV1StudyConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The search algorithm specified for the study.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("algorithm")]
        public virtual string Algorithm { get; set; }

        /// <summary>Configuration for automated stopping of unpromising Trials.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automatedStoppingConfig")]
        public virtual GoogleCloudMlV1AutomatedStoppingConfig AutomatedStoppingConfig { get; set; }

        /// <summary>Metric specs for the study.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<GoogleCloudMlV1StudyConfigMetricSpec> Metrics { get; set; }

        /// <summary>Required. The set of parameters to tune.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<GoogleCloudMlV1StudyConfigParameterSpec> Parameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a metric to optimize.</summary>
    public class GoogleCloudMlV1StudyConfigMetricSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The optimization goal of the metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goal")]
        public virtual string Goal { get; set; }

        /// <summary>Required. The name of the metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metric")]
        public virtual string Metric { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a single parameter to optimize.</summary>
    public class GoogleCloudMlV1StudyConfigParameterSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The value spec for a 'CATEGORICAL' parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoricalValueSpec")]
        public virtual GoogleCloudMlV1StudyConfigParameterSpecCategoricalValueSpec CategoricalValueSpec { get; set; }

        /// <summary>
        /// A child node is active if the parameter's value matches the child node's matching_parent_values. If two
        /// items in child_parameter_specs have the same name, they must have disjoint matching_parent_values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childParameterSpecs")]
        public virtual System.Collections.Generic.IList<GoogleCloudMlV1StudyConfigParameterSpec> ChildParameterSpecs { get; set; }

        /// <summary>The value spec for a 'DISCRETE' parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discreteValueSpec")]
        public virtual GoogleCloudMlV1StudyConfigParameterSpecDiscreteValueSpec DiscreteValueSpec { get; set; }

        /// <summary>The value spec for a 'DOUBLE' parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValueSpec")]
        public virtual GoogleCloudMlV1StudyConfigParameterSpecDoubleValueSpec DoubleValueSpec { get; set; }

        /// <summary>The value spec for an 'INTEGER' parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integerValueSpec")]
        public virtual GoogleCloudMlV1StudyConfigParameterSpecIntegerValueSpec IntegerValueSpec { get; set; }

        /// <summary>Required. The parameter name must be unique amongst all ParameterSpecs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameter")]
        public virtual string Parameter { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("parentCategoricalValues")]
        public virtual GoogleCloudMlV1StudyConfigParameterSpecMatchingParentCategoricalValueSpec ParentCategoricalValues { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("parentDiscreteValues")]
        public virtual GoogleCloudMlV1StudyConfigParameterSpecMatchingParentDiscreteValueSpec ParentDiscreteValues { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("parentIntValues")]
        public virtual GoogleCloudMlV1StudyConfigParameterSpecMatchingParentIntValueSpec ParentIntValues { get; set; }

        /// <summary>How the parameter should be scaled. Leave unset for categorical parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scaleType")]
        public virtual string ScaleType { get; set; }

        /// <summary>Required. The type of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudMlV1StudyConfigParameterSpecCategoricalValueSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Must be specified if type is `CATEGORICAL`. The list of possible categories.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudMlV1StudyConfigParameterSpecDiscreteValueSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Must be specified if type is `DISCRETE`. A list of feasible points. The list should be in strictly
        /// increasing order. For instance, this parameter might have possible settings of 1.5, 2.5, and 4.0. This list
        /// should not contain more than 1,000 values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudMlV1StudyConfigParameterSpecDoubleValueSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Must be specified if type is `DOUBLE`. Maximum value of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxValue")]
        public virtual System.Nullable<double> MaxValue { get; set; }

        /// <summary>Must be specified if type is `DOUBLE`. Minimum value of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minValue")]
        public virtual System.Nullable<double> MinValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudMlV1StudyConfigParameterSpecIntegerValueSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Must be specified if type is `INTEGER`. Maximum value of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxValue")]
        public virtual System.Nullable<long> MaxValue { get; set; }

        /// <summary>Must be specified if type is `INTEGER`. Minimum value of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minValue")]
        public virtual System.Nullable<long> MinValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the spec to match categorical values from parent parameter.</summary>
    public class GoogleCloudMlV1StudyConfigParameterSpecMatchingParentCategoricalValueSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Matches values of the parent parameter with type 'CATEGORICAL'. All values must exist in
        /// `categorical_value_spec` of parent parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the spec to match discrete values from parent parameter.</summary>
    public class GoogleCloudMlV1StudyConfigParameterSpecMatchingParentDiscreteValueSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Matches values of the parent parameter with type 'DISCRETE'. All values must exist in `discrete_value_spec`
        /// of parent parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the spec to match integer values from parent parameter.</summary>
    public class GoogleCloudMlV1StudyConfigParameterSpecMatchingParentIntValueSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Matches values of the parent parameter with type 'INTEGER'. All values must lie in `integer_value_spec` of
        /// parent parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata field of a google.longrunning.Operation associated with a SuggestTrialsRequest.</summary>
    public class GoogleCloudMlV1SuggestTrialsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The identifier of the client that is requesting the suggestion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>The time operation was submitted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The name of the study that the trial belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("study")]
        public virtual string Study { get; set; }

        /// <summary>The number of suggestions requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestionCount")]
        public virtual System.Nullable<int> SuggestionCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for the SuggestTrial service method.</summary>
    public class GoogleCloudMlV1SuggestTrialsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The identifier of the client that is requesting the suggestion. If multiple SuggestTrialsRequests
        /// have the same `client_id`, the service will return the identical suggested trial if the trial is pending,
        /// and provide a new trial if the last suggested trial was completed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>Required. The number of suggestions requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestionCount")]
        public virtual System.Nullable<int> SuggestionCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This message will be placed in the response field of a completed google.longrunning.Operation associated with a
    /// SuggestTrials request.
    /// </summary>
    public class GoogleCloudMlV1SuggestTrialsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time at which operation processing completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The time at which the operation was started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The state of the study.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("studyState")]
        public virtual string StudyState { get; set; }

        /// <summary>A list of trials.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trials")]
        public virtual System.Collections.Generic.IList<GoogleCloudMlV1Trial> Trials { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents input parameters for a training job. When using the gcloud command to submit your training job, you
    /// can specify the input parameters as command-line arguments and/or in a YAML configuration file referenced from
    /// the --config command-line argument. For details, see the guide to [submitting a training
    /// job](/ai-platform/training/docs/training-jobs).
    /// </summary>
    public class GoogleCloudMlV1TrainingInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Command-line arguments passed to the training application when it starts. If your job uses a
        /// custom container, then the arguments are passed to the container's `ENTRYPOINT` command.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>Optional. Whether to enable web access for the training job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableWebAccess")]
        public virtual System.Nullable<bool> EnableWebAccess { get; set; }

        /// <summary>
        /// Optional. Options for using customer-managed encryption keys (CMEK) to protect resources created by a
        /// training job, instead of using Google's default encryption. If this is set, then all resources created by
        /// the training job will be encrypted with the customer-managed encryption key that you specify. [Learn how and
        /// when to use CMEK with AI Platform Training](/ai-platform/training/docs/cmek).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionConfig")]
        public virtual GoogleCloudMlV1EncryptionConfig EncryptionConfig { get; set; }

        /// <summary>
        /// Optional. The configuration for evaluators. You should only set `evaluatorConfig.acceleratorConfig` if
        /// `evaluatorType` is set to a Compute Engine machine type. [Learn about restrictions on accelerator
        /// configurations for training.](/ai-platform/training/docs/using-gpus#compute-engine-machine-types-with-gpu)
        /// Set `evaluatorConfig.imageUri` only if you build a custom image for your evaluator. If
        /// `evaluatorConfig.imageUri` has not been set, AI Platform uses the value of `masterConfig.imageUri`. Learn
        /// more about [configuring custom containers](/ai-platform/training/docs/distributed-training-containers).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluatorConfig")]
        public virtual GoogleCloudMlV1ReplicaConfig EvaluatorConfig { get; set; }

        /// <summary>
        /// Optional. The number of evaluator replicas to use for the training job. Each replica in the cluster will be
        /// of the type specified in `evaluator_type`. This value can only be used when `scale_tier` is set to `CUSTOM`.
        /// If you set this value, you must also set `evaluator_type`. The default value is zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluatorCount")]
        public virtual System.Nullable<long> EvaluatorCount { get; set; }

        /// <summary>
        /// Optional. Specifies the type of virtual machine to use for your training job's evaluator nodes. The
        /// supported values are the same as those described in the entry for `masterType`. This value must be
        /// consistent with the category of machine type that `masterType` uses. In other words, both must be Compute
        /// Engine machine types or both must be legacy machine types. This value must be present when `scaleTier` is
        /// set to `CUSTOM` and `evaluatorCount` is greater than zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluatorType")]
        public virtual string EvaluatorType { get; set; }

        /// <summary>Optional. The set of Hyperparameters to tune.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hyperparameters")]
        public virtual GoogleCloudMlV1HyperparameterSpec Hyperparameters { get; set; }

        /// <summary>
        /// Optional. A Google Cloud Storage path in which to store training outputs and other data needed for training.
        /// This path is passed to your TensorFlow program as the '--job-dir' command-line argument. The benefit of
        /// specifying this field is that Cloud ML validates the path for use in training.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobDir")]
        public virtual string JobDir { get; set; }

        /// <summary>
        /// Optional. The configuration for your master worker. You should only set `masterConfig.acceleratorConfig` if
        /// `masterType` is set to a Compute Engine machine type. Learn about [restrictions on accelerator
        /// configurations for training.](/ai-platform/training/docs/using-gpus#compute-engine-machine-types-with-gpu)
        /// Set `masterConfig.imageUri` only if you build a custom image. Only one of `masterConfig.imageUri` and
        /// `runtimeVersion` should be set. Learn more about [configuring custom
        /// containers](/ai-platform/training/docs/distributed-training-containers).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("masterConfig")]
        public virtual GoogleCloudMlV1ReplicaConfig MasterConfig { get; set; }

        /// <summary>
        /// Optional. Specifies the type of virtual machine to use for your training job's master worker. You must
        /// specify this field when `scaleTier` is set to `CUSTOM`. You can use certain Compute Engine machine types
        /// directly in this field. See the [list of compatible Compute Engine machine
        /// types](/ai-platform/training/docs/machine-types#compute-engine-machine-types). Alternatively, you can use
        /// the certain legacy machine types in this field. See the [list of legacy machine
        /// types](/ai-platform/training/docs/machine-types#legacy-machine-types). Finally, if you want to use a TPU for
        /// training, specify `cloud_tpu` in this field. Learn more about the [special configuration options for
        /// training with TPUs](/ai-platform/training/docs/using-tpus#configuring_a_custom_tpu_machine).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("masterType")]
        public virtual string MasterType { get; set; }

        /// <summary>
        /// Optional. The full name of the [Compute Engine network](/vpc/docs/vpc) to which the Job is peered. For
        /// example, `projects/12345/global/networks/myVPC`. The format of this field is
        /// `projects/{project}/global/networks/{network}`, where {project} is a project number (like `12345`) and
        /// {network} is network name. Private services access must already be configured for the network. If left
        /// unspecified, the Job is not peered with any network. [Learn about using VPC Network
        /// Peering.](/ai-platform/training/docs/vpc-peering).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>
        /// Required. The Google Cloud Storage location of the packages with the training program and any additional
        /// dependencies. The maximum number of package URIs is 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageUris")]
        public virtual System.Collections.Generic.IList<string> PackageUris { get; set; }

        /// <summary>
        /// Optional. The configuration for parameter servers. You should only set
        /// `parameterServerConfig.acceleratorConfig` if `parameterServerType` is set to a Compute Engine machine type.
        /// [Learn about restrictions on accelerator configurations for
        /// training.](/ai-platform/training/docs/using-gpus#compute-engine-machine-types-with-gpu) Set
        /// `parameterServerConfig.imageUri` only if you build a custom image for your parameter server. If
        /// `parameterServerConfig.imageUri` has not been set, AI Platform uses the value of `masterConfig.imageUri`.
        /// Learn more about [configuring custom
        /// containers](/ai-platform/training/docs/distributed-training-containers).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterServerConfig")]
        public virtual GoogleCloudMlV1ReplicaConfig ParameterServerConfig { get; set; }

        /// <summary>
        /// Optional. The number of parameter server replicas to use for the training job. Each replica in the cluster
        /// will be of the type specified in `parameter_server_type`. This value can only be used when `scale_tier` is
        /// set to `CUSTOM`. If you set this value, you must also set `parameter_server_type`. The default value is
        /// zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterServerCount")]
        public virtual System.Nullable<long> ParameterServerCount { get; set; }

        /// <summary>
        /// Optional. Specifies the type of virtual machine to use for your training job's parameter server. The
        /// supported values are the same as those described in the entry for `master_type`. This value must be
        /// consistent with the category of machine type that `masterType` uses. In other words, both must be Compute
        /// Engine machine types or both must be legacy machine types. This value must be present when `scaleTier` is
        /// set to `CUSTOM` and `parameter_server_count` is greater than zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterServerType")]
        public virtual string ParameterServerType { get; set; }

        /// <summary>Required. The Python module name to run after installing the packages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pythonModule")]
        public virtual string PythonModule { get; set; }

        /// <summary>
        /// Optional. The version of Python used in training. You must either specify this field or specify
        /// `masterConfig.imageUri`. The following Python versions are available: * Python '3.7' is available when
        /// `runtime_version` is set to '1.15' or later. * Python '3.5' is available when `runtime_version` is set to a
        /// version from '1.4' to '1.14'. * Python '2.7' is available when `runtime_version` is set to '1.15' or
        /// earlier. Read more about the Python versions available for [each runtime
        /// version](/ml-engine/docs/runtime-version-list).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pythonVersion")]
        public virtual string PythonVersion { get; set; }

        /// <summary>
        /// Required. The region to run the training job in. See the [available
        /// regions](/ai-platform/training/docs/regions) for AI Platform Training.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>
        /// Optional. The AI Platform runtime version to use for training. You must either specify this field or specify
        /// `masterConfig.imageUri`. For more information, see the [runtime version
        /// list](/ai-platform/training/docs/runtime-version-list) and learn [how to manage runtime
        /// versions](/ai-platform/training/docs/versioning).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeVersion")]
        public virtual string RuntimeVersion { get; set; }

        /// <summary>
        /// Required. Specifies the machine types, the number of replicas for workers and parameter servers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scaleTier")]
        public virtual string ScaleTier { get; set; }

        /// <summary>Optional. Scheduling options for a training job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduling")]
        public virtual GoogleCloudMlV1Scheduling Scheduling { get; set; }

        /// <summary>
        /// Optional. The email address of a service account to use when running the training appplication. You must
        /// have the `iam.serviceAccounts.actAs` permission for the specified service account. In addition, the AI
        /// Platform Training Google-managed service account must have the `roles/iam.serviceAccountAdmin` role for the
        /// specified service account. [Learn more about configuring a service
        /// account.](/ai-platform/training/docs/custom-service-account) If not specified, the AI Platform Training
        /// Google-managed service account is used by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>
        /// Optional. Use `chief` instead of `master` in the `TF_CONFIG` environment variable when training with a
        /// custom container. Defaults to `false`. [Learn more about this
        /// field.](/ai-platform/training/docs/distributed-training-details#chief-versus-master) This field has no
        /// effect for training jobs that don't use a custom container.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useChiefInTfConfig")]
        public virtual System.Nullable<bool> UseChiefInTfConfig { get; set; }

        /// <summary>
        /// Optional. The configuration for workers. You should only set `workerConfig.acceleratorConfig` if
        /// `workerType` is set to a Compute Engine machine type. [Learn about restrictions on accelerator
        /// configurations for training.](/ai-platform/training/docs/using-gpus#compute-engine-machine-types-with-gpu)
        /// Set `workerConfig.imageUri` only if you build a custom image for your worker. If `workerConfig.imageUri` has
        /// not been set, AI Platform uses the value of `masterConfig.imageUri`. Learn more about [configuring custom
        /// containers](/ai-platform/training/docs/distributed-training-containers).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerConfig")]
        public virtual GoogleCloudMlV1ReplicaConfig WorkerConfig { get; set; }

        /// <summary>
        /// Optional. The number of worker replicas to use for the training job. Each replica in the cluster will be of
        /// the type specified in `worker_type`. This value can only be used when `scale_tier` is set to `CUSTOM`. If
        /// you set this value, you must also set `worker_type`. The default value is zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerCount")]
        public virtual System.Nullable<long> WorkerCount { get; set; }

        /// <summary>
        /// Optional. Specifies the type of virtual machine to use for your training job's worker nodes. The supported
        /// values are the same as those described in the entry for `masterType`. This value must be consistent with the
        /// category of machine type that `masterType` uses. In other words, both must be Compute Engine machine types
        /// or both must be legacy machine types. If you use `cloud_tpu` for this value, see special instructions for
        /// [configuring a custom TPU machine](/ml-engine/docs/tensorflow/using-tpus#configuring_a_custom_tpu_machine).
        /// This value must be present when `scaleTier` is set to `CUSTOM` and `workerCount` is greater than zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerType")]
        public virtual string WorkerType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents results of a training job. Output only.</summary>
    public class GoogleCloudMlV1TrainingOutput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Details related to built-in algorithms jobs. Only set for built-in algorithms jobs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("builtInAlgorithmOutput")]
        public virtual GoogleCloudMlV1BuiltInAlgorithmOutput BuiltInAlgorithmOutput { get; set; }

        /// <summary>
        /// The number of hyperparameter tuning trials that completed successfully. Only set for hyperparameter tuning
        /// jobs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completedTrialCount")]
        public virtual System.Nullable<long> CompletedTrialCount { get; set; }

        /// <summary>The amount of ML units consumed by the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumedMLUnits")]
        public virtual System.Nullable<double> ConsumedMLUnits { get; set; }

        /// <summary>
        /// The TensorFlow summary tag name used for optimizing hyperparameter tuning trials. See
        /// [`HyperparameterSpec.hyperparameterMetricTag`](#HyperparameterSpec.FIELDS.hyperparameter_metric_tag) for
        /// more information. Only set for hyperparameter tuning jobs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hyperparameterMetricTag")]
        public virtual string HyperparameterMetricTag { get; set; }

        /// <summary>Whether this job is a built-in Algorithm job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isBuiltInAlgorithmJob")]
        public virtual System.Nullable<bool> IsBuiltInAlgorithmJob { get; set; }

        /// <summary>Whether this job is a hyperparameter tuning job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isHyperparameterTuningJob")]
        public virtual System.Nullable<bool> IsHyperparameterTuningJob { get; set; }

        /// <summary>Results for individual Hyperparameter trials. Only set for hyperparameter tuning jobs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trials")]
        public virtual System.Collections.Generic.IList<GoogleCloudMlV1HyperparameterOutput> Trials { get; set; }

        /// <summary>
        /// Output only. The web URIs for the training job. Currently for debug terminal access to the job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webAccessUris")]
        public virtual System.Collections.Generic.IDictionary<string, string> WebAccessUris { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message representing a trial.</summary>
    public class GoogleCloudMlV1Trial : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The identifier of the client that originally requested this trial.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>Output only. Time at which the trial's status changed to COMPLETED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The final measurement containing the objective value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalMeasurement")]
        public virtual GoogleCloudMlV1Measurement FinalMeasurement { get; set; }

        /// <summary>
        /// Output only. A human readable string describing why the trial is infeasible. This should only be set if
        /// trial_infeasible is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infeasibleReason")]
        public virtual string InfeasibleReason { get; set; }

        /// <summary>
        /// A list of measurements that are strictly lexicographically ordered by their induced tuples (steps,
        /// elapsed_time). These are used for early stopping computations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("measurements")]
        public virtual System.Collections.Generic.IList<GoogleCloudMlV1Measurement> Measurements { get; set; }

        /// <summary>Output only. Name of the trial assigned by the service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The parameters of the trial.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<GoogleCloudMlV1TrialParameter> Parameters { get; set; }

        /// <summary>Output only. Time at which the trial was started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The detailed state of a trial.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. If true, the parameters in this trial are not attempted again.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trialInfeasible")]
        public virtual System.Nullable<bool> TrialInfeasible { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A message representing a parameter to be tuned. Contains the name of the parameter and the suggested value to
    /// use for this trial.
    /// </summary>
    public class GoogleCloudMlV1TrialParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Must be set if ParameterType is DOUBLE or DISCRETE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floatValue")]
        public virtual System.Nullable<double> FloatValue { get; set; }

        /// <summary>Must be set if ParameterType is INTEGER</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intValue")]
        public virtual System.Nullable<long> IntValue { get; set; }

        /// <summary>The name of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameter")]
        public virtual string Parameter { get; set; }

        /// <summary>Must be set if ParameterTypeis CATEGORICAL</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a version of the model. Each version is a trained model deployed in the cloud, ready to handle
    /// prediction requests. A model can have multiple versions. You can get information about all of the versions of a
    /// given model by calling projects.models.versions.list.
    /// </summary>
    public class GoogleCloudMlV1Version : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Accelerator config for using GPUs for online prediction (beta). Only specify this field if you
        /// have specified a Compute Engine (N1) machine type in the `machineType` field. Learn more about [using GPUs
        /// for online prediction](/ml-engine/docs/machine-types-online-prediction#gpus).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceleratorConfig")]
        public virtual GoogleCloudMlV1AcceleratorConfig AcceleratorConfig { get; set; }

        /// <summary>
        /// Automatically scale the number of nodes used to serve the model in response to increases and decreases in
        /// traffic. Care should be taken to ramp up traffic according to the model's ability to scale or you will start
        /// seeing increases in latency and 429 response codes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoScaling")]
        public virtual GoogleCloudMlV1AutoScaling AutoScaling { get; set; }

        /// <summary>
        /// Optional. Specifies a custom container to use for serving predictions. If you specify this field, then
        /// `machineType` is required. If you specify this field, then `deploymentUri` is optional. If you specify this
        /// field, then you must not specify `runtimeVersion`, `packageUris`, `framework`, `pythonVersion`, or
        /// `predictionClass`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("container")]
        public virtual GoogleCloudMlV1ContainerSpec Container { get; set; }

        /// <summary>Output only. The time the version was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// The Cloud Storage URI of a directory containing trained model artifacts to be used to create the model
        /// version. See the [guide to deploying models](/ai-platform/prediction/docs/deploying-models) for more
        /// information. The total number of files under this directory must not exceed 1000. During
        /// projects.models.versions.create, AI Platform Prediction copies all files from the specified directory to a
        /// location managed by the service. From then on, AI Platform Prediction uses these copies of the model
        /// artifacts to serve predictions, not the original files in Cloud Storage, so this location is useful only as
        /// a historical record. If you specify container, then this field is optional. Otherwise, it is required. Learn
        /// [how to use this field with a custom
        /// container](/ai-platform/prediction/docs/custom-container-requirements#artifacts).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentUri")]
        public virtual string DeploymentUri { get; set; }

        /// <summary>Optional. The description specified for the version when it was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. The details of a failure or a cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>
        /// `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a model
        /// from overwriting each other. It is strongly suggested that systems make use of the `etag` in the
        /// read-modify-write cycle to perform model updates in order to avoid race conditions: An `etag` is returned in
        /// the response to `GetVersion`, and systems are expected to put that etag in the request to `UpdateVersion` to
        /// ensure that their change will be applied to the model as intended.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. Configures explainability features on the model's version. Some explanation features require
        /// additional metadata to be loaded as part of the model payload.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explanationConfig")]
        public virtual GoogleCloudMlV1ExplanationConfig ExplanationConfig { get; set; }

        /// <summary>
        /// Optional. The machine learning framework AI Platform uses to train this version of the model. Valid values
        /// are `TENSORFLOW`, `SCIKIT_LEARN`, `XGBOOST`. If you do not specify a framework, AI Platform will analyze
        /// files in the deployment_uri to determine a framework. If you choose `SCIKIT_LEARN` or `XGBOOST`, you must
        /// also set the runtime version of the model to 1.4 or greater. Do **not** specify a framework if you're
        /// deploying a [custom prediction routine](/ai-platform/prediction/docs/custom-prediction-routines) or if
        /// you're using a [custom container](/ai-platform/prediction/docs/use-custom-container).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("framework")]
        public virtual string Framework { get; set; }

        /// <summary>
        /// Output only. If true, this version will be used to handle prediction requests that do not specify a version.
        /// You can change the default version by calling projects.methods.versions.setDefault.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDefault")]
        public virtual System.Nullable<bool> IsDefault { get; set; }

        /// <summary>
        /// Optional. One or more labels that you can add, to organize your model versions. Each label is a key-value
        /// pair, where both the key and the value are arbitrary strings that you supply. For more information, see the
        /// documentation on using labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. The [AI Platform (Unified)
        /// `Model`](https://cloud.google.com/ai-platform-unified/docs/reference/rest/v1beta1/projects.locations.models)
        /// ID for the last [model
        /// migration](https://cloud.google.com/ai-platform-unified/docs/start/migrating-to-ai-platform-unified).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastMigrationModelId")]
        public virtual string LastMigrationModelId { get; set; }

        /// <summary>
        /// Output only. The last time this version was successfully [migrated to AI Platform
        /// (Unified)](https://cloud.google.com/ai-platform-unified/docs/start/migrating-to-ai-platform-unified).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastMigrationTime")]
        public virtual object LastMigrationTime { get; set; }

        /// <summary>Output only. The time the version was last used for prediction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUseTime")]
        public virtual object LastUseTime { get; set; }

        /// <summary>
        /// Optional. The type of machine on which to serve the model. Currently only applies to online prediction
        /// service. To learn about valid values for this field, read [Choosing a machine type for online
        /// prediction](/ai-platform/prediction/docs/machine-types-online-prediction). If this field is not specified
        /// and you are using a [regional endpoint](/ai-platform/prediction/docs/regional-endpoints), then the machine
        /// type defaults to `n1-standard-2`. If this field is not specified and you are using the global endpoint
        /// (`ml.googleapis.com`), then the machine type defaults to `mls1-c1-m2`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>
        /// Manually select the number of nodes to use for serving the model. You should generally use `auto_scaling`
        /// with an appropriate `min_nodes` instead, but this option is available if you want more predictable billing.
        /// Beware that latency and error rates will increase if the traffic exceeds that capability of the system to
        /// serve it based on the selected number of nodes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualScaling")]
        public virtual GoogleCloudMlV1ManualScaling ManualScaling { get; set; }

        /// <summary>
        /// Required. The name specified for the version when it was created. The version name must be unique within the
        /// model it is created in.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Cloud Storage paths (`gs://…`) of packages for [custom prediction
        /// routines](/ml-engine/docs/tensorflow/custom-prediction-routines) or [scikit-learn pipelines with custom
        /// code](/ml-engine/docs/scikit/exporting-for-prediction#custom-pipeline-code). For a custom prediction
        /// routine, one of these packages must contain your Predictor class (see
        /// [`predictionClass`](#Version.FIELDS.prediction_class)). Additionally, include any dependencies used by your
        /// Predictor or scikit-learn pipeline uses that are not already included in your selected [runtime
        /// version](/ml-engine/docs/tensorflow/runtime-version-list). If you specify this field, you must also set
        /// [`runtimeVersion`](#Version.FIELDS.runtime_version) to 1.4 or greater.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageUris")]
        public virtual System.Collections.Generic.IList<string> PackageUris { get; set; }

        /// <summary>
        /// Optional. The fully qualified name (module_name.class_name) of a class that implements the Predictor
        /// interface described in this reference field. The module containing this class should be included in a
        /// package provided to the [`packageUris` field](#Version.FIELDS.package_uris). Specify this field if and only
        /// if you are deploying a [custom prediction routine
        /// (beta)](/ml-engine/docs/tensorflow/custom-prediction-routines). If you specify this field, you must set
        /// [`runtimeVersion`](#Version.FIELDS.runtime_version) to 1.4 or greater and you must set `machineType` to a
        /// [legacy (MLS1) machine type](/ml-engine/docs/machine-types-online-prediction). The following code sample
        /// provides the Predictor interface: class Predictor(object): """Interface for constructing custom
        /// predictors.""" def predict(self, instances, **kwargs): """Performs custom prediction. Instances are the
        /// decoded values from the request. They have already been deserialized from JSON. Args: instances: A list of
        /// prediction input instances. **kwargs: A dictionary of keyword args provided as additional fields on the
        /// predict request body. Returns: A list of outputs containing the prediction results. This list must be JSON
        /// serializable. """ raise NotImplementedError() @classmethod def from_path(cls, model_dir): """Creates an
        /// instance of Predictor using the given path. Loading of the predictor should be done in this method. Args:
        /// model_dir: The local directory that contains the exported model file along with any additional files
        /// uploaded when creating the version resource. Returns: An instance implementing this Predictor class. """
        /// raise NotImplementedError() Learn more about [the Predictor interface and custom prediction
        /// routines](/ml-engine/docs/tensorflow/custom-prediction-routines).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predictionClass")]
        public virtual string PredictionClass { get; set; }

        /// <summary>
        /// Required. The version of Python used in prediction. The following Python versions are available: * Python
        /// '3.7' is available when `runtime_version` is set to '1.15' or later. * Python '3.5' is available when
        /// `runtime_version` is set to a version from '1.4' to '1.14'. * Python '2.7' is available when
        /// `runtime_version` is set to '1.15' or earlier. Read more about the Python versions available for [each
        /// runtime version](/ml-engine/docs/runtime-version-list).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pythonVersion")]
        public virtual string PythonVersion { get; set; }

        /// <summary>
        /// Optional. *Only* specify this field in a projects.models.versions.patch request. Specifying it in a
        /// projects.models.versions.create request has no effect. Configures the request-response pair logging on
        /// predictions from this Version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestLoggingConfig")]
        public virtual GoogleCloudMlV1RequestLoggingConfig RequestLoggingConfig { get; set; }

        /// <summary>
        /// Optional. Specifies paths on a custom container's HTTP server where AI Platform Prediction sends certain
        /// requests. If you specify this field, then you must also specify the `container` field. If you specify the
        /// `container` field and do not specify this field, it defaults to the following: ```json { "predict":
        /// "/v1/models/MODEL/versions/VERSION:predict", "health": "/v1/models/MODEL/versions/VERSION" } ``` See
        /// RouteMap for more details about these default values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routes")]
        public virtual GoogleCloudMlV1RouteMap Routes { get; set; }

        /// <summary>
        /// Required. The AI Platform runtime version to use for this deployment. For more information, see the [runtime
        /// version list](/ml-engine/docs/runtime-version-list) and [how to manage runtime
        /// versions](/ml-engine/docs/versioning).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeVersion")]
        public virtual string RuntimeVersion { get; set; }

        /// <summary>
        /// Optional. Specifies the service account for resource access control. If you specify this field, then you
        /// must also specify either the `containerSpec` or the `predictionClass` field. Learn more about [using a
        /// custom service account](/ai-platform/prediction/docs/custom-service-account).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Output only. The state of a version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }
    }

    /// <summary>
    /// Attributes credit by computing the XRAI taking advantage of the model's fully differentiable structure. Refer to
    /// this paper for more details: https://arxiv.org/abs/1906.02825 Currently only implemented for models with natural
    /// image inputs.
    /// </summary>
    public class GoogleCloudMlV1XraiAttribution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Number of steps for approximating the path integral. A good value to start is 50 and gradually increase
        /// until the sum to diff property is met within the desired error range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numIntegralSteps")]
        public virtual System.Nullable<int> NumIntegralSteps { get; set; }

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
    public class GoogleIamV1AuditConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for logging of each type of permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLogConfigs")]
        public virtual System.Collections.Generic.IList<GoogleIamV1AuditLogConfig> AuditLogConfigs { get; set; }

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

    /// <summary>Associates `members` with a `role`.</summary>
    public class GoogleIamV1Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// members in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual GoogleTypeExpr Condition { get; set; }

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
    public class GoogleIamV1Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<GoogleIamV1AuditConfig> AuditConfigs { get; set; }

        /// <summary>
        /// Associates a list of `members` to a `role`. Optionally, may specify a `condition` that determines how and
        /// when the `bindings` are applied. Each of the `bindings` must contain at least one member.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<GoogleIamV1Binding> Bindings { get; set; }

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

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class GoogleIamV1SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Cloud Platform services (such as Projects) might
        /// reject them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual GoogleIamV1Policy Policy { get; set; }

        /// <summary>
        /// OPTIONAL: A FieldMask specifying which fields of the policy to modify. Only the fields in the mask will be
        /// modified. If no mask is provided, the following default mask is used: `paths: "bindings, etag"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class GoogleIamV1TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleIamV1TestIamPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A subset of `TestPermissionsRequest.permissions` that the caller is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

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
        /// If the value is `false`, it means the operation is still in progress. If `true`, the operation is completed,
        /// and either `error` or `response` is available.
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

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty JSON
    /// object `{}`.
    /// </summary>
    public class GoogleProtobufEmpty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
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
