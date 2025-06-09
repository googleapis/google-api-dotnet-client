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

namespace Google.Apis.CloudScheduler.v1beta1
{
    /// <summary>The CloudScheduler Service.</summary>
    public class CloudSchedulerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudSchedulerService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudSchedulerService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://cloudscheduler.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://cloudscheduler.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudscheduler";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Scheduler API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Scheduler API.</summary>
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

    /// <summary>A base abstract class for CloudScheduler requests.</summary>
    public abstract class CloudSchedulerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudSchedulerBaseServiceRequest instance.</summary>
        protected CloudSchedulerBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudScheduler parameter list.</summary>
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

                /// <summary>Creates a job.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The location name. For example: `projects/PROJECT_ID/locations/LOCATION_ID`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudScheduler.v1beta1.Data.Job body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a job.</summary>
                public class CreateRequest : CloudSchedulerBaseServiceRequest<Google.Apis.CloudScheduler.v1beta1.Data.Job>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudScheduler.v1beta1.Data.Job body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location name. For example: `projects/PROJECT_ID/locations/LOCATION_ID`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudScheduler.v1beta1.Data.Job Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/jobs";

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

                /// <summary>Deletes a job.</summary>
                /// <param name="name">
                /// Required. The job name. For example: `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a job.</summary>
                public class DeleteRequest : CloudSchedulerBaseServiceRequest<Google.Apis.CloudScheduler.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The job name. For example: `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// This field is used to manage the legacy App Engine Cron jobs using the Cloud Scheduler API. If
                    /// the field is set to true, the job in the __cron queue with the corresponding name will be
                    /// deleted instead.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("legacyAppEngineCron", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> LegacyAppEngineCron { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
                        });
                        RequestParameters.Add("legacyAppEngineCron", new Google.Apis.Discovery.Parameter
                        {
                            Name = "legacyAppEngineCron",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets a job.</summary>
                /// <param name="name">
                /// Required. The job name. For example: `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a job.</summary>
                public class GetRequest : CloudSchedulerBaseServiceRequest<Google.Apis.CloudScheduler.v1beta1.Data.Job>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The job name. For example: `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists jobs.</summary>
                /// <param name="parent">
                /// Required. The location name. For example: `projects/PROJECT_ID/locations/LOCATION_ID`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists jobs.</summary>
                public class ListRequest : CloudSchedulerBaseServiceRequest<Google.Apis.CloudScheduler.v1beta1.Data.ListJobsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location name. For example: `projects/PROJECT_ID/locations/LOCATION_ID`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// `filter` can be used to specify a subset of jobs. If `filter` equals
                    /// `target_config="HttpConfig"`, then the http target jobs are retrieved. If `filter` equals
                    /// `target_config="PubSubConfig"`, then the Pub/Sub target jobs are retrieved. If `filter` equals
                    /// `labels.foo=value1 labels.foo=value2` then only jobs which are labeled with foo=value1 AND
                    /// foo=value2 will be returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// This field is used to manage the legacy App Engine Cron jobs using the Cloud Scheduler API. If
                    /// the field is set to true, the jobs in the __cron queue will be listed instead.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("legacyAppEngineCron", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> LegacyAppEngineCron { get; set; }

                    /// <summary>
                    /// Requested page size. The maximum page size is 500. If unspecified, the page size will be the
                    /// maximum. Fewer jobs than requested might be returned, even if more jobs exist; use
                    /// next_page_token to determine if more jobs exist.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A token identifying a page of results the server will return. To request the first page results,
                    /// page_token must be empty. To request the next page of results, page_token must be the value of
                    /// next_page_token returned from the previous call to ListJobs. It is an error to switch the value
                    /// of filter or order_by while iterating through pages.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/jobs";

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
                        RequestParameters.Add("legacyAppEngineCron", new Google.Apis.Discovery.Parameter
                        {
                            Name = "legacyAppEngineCron",
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
                /// Updates a job. If successful, the updated Job is returned. If the job does not exist, `NOT_FOUND` is
                /// returned. If UpdateJob does not successfully return, it is possible for the job to be in an
                /// Job.State.UPDATE_FAILED state. A job in this state may not be executed. If this happens, retry the
                /// UpdateJob request until a successful response is received.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Optionally caller-specified in CreateJob, after which it becomes output only. The job name. For
                /// example: `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`. * `PROJECT_ID` can contain letters
                /// ([A-Za-z]), numbers ([0-9]), hyphens (-), colons (:), or periods (.). For more information, see
                /// [Identifying
                /// projects](https://cloud.google.com/resource-manager/docs/creating-managing-projects#identifying_projects)
                /// * `LOCATION_ID` is the canonical ID for the job's location. The list of available locations can be
                /// obtained by calling ListLocations. For more information, see
                /// https://cloud.google.com/about/locations/. * `JOB_ID` can contain only letters ([A-Za-z]), numbers
                /// ([0-9]), hyphens (-), or underscores (_). The maximum length is 500 characters.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudScheduler.v1beta1.Data.Job body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates a job. If successful, the updated Job is returned. If the job does not exist, `NOT_FOUND` is
                /// returned. If UpdateJob does not successfully return, it is possible for the job to be in an
                /// Job.State.UPDATE_FAILED state. A job in this state may not be executed. If this happens, retry the
                /// UpdateJob request until a successful response is received.
                /// </summary>
                public class PatchRequest : CloudSchedulerBaseServiceRequest<Google.Apis.CloudScheduler.v1beta1.Data.Job>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudScheduler.v1beta1.Data.Job body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Optionally caller-specified in CreateJob, after which it becomes output only. The job name. For
                    /// example: `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`. * `PROJECT_ID` can contain
                    /// letters ([A-Za-z]), numbers ([0-9]), hyphens (-), colons (:), or periods (.). For more
                    /// information, see [Identifying
                    /// projects](https://cloud.google.com/resource-manager/docs/creating-managing-projects#identifying_projects)
                    /// * `LOCATION_ID` is the canonical ID for the job's location. The list of available locations can
                    /// be obtained by calling ListLocations. For more information, see
                    /// https://cloud.google.com/about/locations/. * `JOB_ID` can contain only letters ([A-Za-z]),
                    /// numbers ([0-9]), hyphens (-), or underscores (_). The maximum length is 500 characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>A mask used to specify which fields of the job are being updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudScheduler.v1beta1.Data.Job Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
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
                /// Pauses a job. If a job is paused then the system will stop executing the job until it is re-enabled
                /// via ResumeJob. The state of the job is stored in state; if paused it will be set to
                /// Job.State.PAUSED. A job must be in Job.State.ENABLED to be paused.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The job name. For example: `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
                /// </param>
                public virtual PauseRequest Pause(Google.Apis.CloudScheduler.v1beta1.Data.PauseJobRequest body, string name)
                {
                    return new PauseRequest(this.service, body, name);
                }

                /// <summary>
                /// Pauses a job. If a job is paused then the system will stop executing the job until it is re-enabled
                /// via ResumeJob. The state of the job is stored in state; if paused it will be set to
                /// Job.State.PAUSED. A job must be in Job.State.ENABLED to be paused.
                /// </summary>
                public class PauseRequest : CloudSchedulerBaseServiceRequest<Google.Apis.CloudScheduler.v1beta1.Data.Job>
                {
                    /// <summary>Constructs a new Pause request.</summary>
                    public PauseRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudScheduler.v1beta1.Data.PauseJobRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The job name. For example: `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudScheduler.v1beta1.Data.PauseJobRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "pause";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}:pause";

                    /// <summary>Initializes Pause parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Resume a job. This method reenables a job after it has been Job.State.PAUSED. The state of a job is
                /// stored in Job.state; after calling this method it will be set to Job.State.ENABLED. A job must be in
                /// Job.State.PAUSED to be resumed.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The job name. For example: `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
                /// </param>
                public virtual ResumeRequest Resume(Google.Apis.CloudScheduler.v1beta1.Data.ResumeJobRequest body, string name)
                {
                    return new ResumeRequest(this.service, body, name);
                }

                /// <summary>
                /// Resume a job. This method reenables a job after it has been Job.State.PAUSED. The state of a job is
                /// stored in Job.state; after calling this method it will be set to Job.State.ENABLED. A job must be in
                /// Job.State.PAUSED to be resumed.
                /// </summary>
                public class ResumeRequest : CloudSchedulerBaseServiceRequest<Google.Apis.CloudScheduler.v1beta1.Data.Job>
                {
                    /// <summary>Constructs a new Resume request.</summary>
                    public ResumeRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudScheduler.v1beta1.Data.ResumeJobRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The job name. For example: `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudScheduler.v1beta1.Data.ResumeJobRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "resume";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}:resume";

                    /// <summary>Initializes Resume parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Forces a job to run now. When this method is called, Cloud Scheduler will dispatch the job, even if
                /// the job is already running.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The job name. For example: `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
                /// </param>
                public virtual RunRequest Run(Google.Apis.CloudScheduler.v1beta1.Data.RunJobRequest body, string name)
                {
                    return new RunRequest(this.service, body, name);
                }

                /// <summary>
                /// Forces a job to run now. When this method is called, Cloud Scheduler will dispatch the job, even if
                /// the job is already running.
                /// </summary>
                public class RunRequest : CloudSchedulerBaseServiceRequest<Google.Apis.CloudScheduler.v1beta1.Data.Job>
                {
                    /// <summary>Constructs a new Run request.</summary>
                    public RunRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudScheduler.v1beta1.Data.RunJobRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The job name. For example: `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudScheduler.v1beta1.Data.RunJobRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "run";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}:run";

                    /// <summary>Initializes Run parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
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
            public class GetRequest : CloudSchedulerBaseServiceRequest<Google.Apis.CloudScheduler.v1beta1.Data.Location>
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
                return new ListRequest(this.service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : CloudSchedulerBaseServiceRequest<Google.Apis.CloudScheduler.v1beta1.Data.ListLocationsResponse>
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
                /// Optional. A list of extra location types that should be used as conditions for controlling the
                /// visibility of the locations.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("extraLocationTypes", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> ExtraLocationTypes { get; set; }

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
namespace Google.Apis.CloudScheduler.v1beta1.Data
{
    /// <summary>
    /// App Engine target. The job will be pushed to a job handler by means of an HTTP request via an http_method such
    /// as HTTP POST, HTTP GET, etc. The job is acknowledged by means of an HTTP response code in the range [200 - 299].
    /// Error 503 is considered an App Engine system error instead of an application error. Requests returning error 503
    /// will be retried regardless of retry configuration and not counted against retry counts. Any other response code,
    /// or a failure to receive a response before the deadline, constitutes a failed attempt.
    /// </summary>
    public class AppEngineHttpTarget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>App Engine Routing setting for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appEngineRouting")]
        public virtual AppEngineRouting AppEngineRouting { get; set; }

        /// <summary>
        /// Body. HTTP request body. A request body is allowed only if the HTTP method is POST or PUT. It will result in
        /// invalid argument error to set a body on a job with an incompatible HttpMethod.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual string Body { get; set; }

        /// <summary>
        /// HTTP request headers. This map contains the header field names and values. Headers can be set when the job
        /// is created. Cloud Scheduler sets some headers to default values: * `User-Agent`: By default, this header is
        /// `"AppEngine-Google; (+http://code.google.com/appengine)"`. This header can be modified, but Cloud Scheduler
        /// will append `"AppEngine-Google; (+http://code.google.com/appengine)"` to the modified `User-Agent`. *
        /// `X-CloudScheduler`: This header will be set to true. * `X-CloudScheduler-JobName`: This header will contain
        /// the job name. * `X-CloudScheduler-ScheduleTime`: For Cloud Scheduler jobs specified in the unix-cron format,
        /// this header will contain the job schedule as an offset of UTC parsed according to RFC3339. If the job has a
        /// body and the following headers are not set by the user, Cloud Scheduler sets default values: *
        /// `Content-Type`: This will be set to `"application/octet-stream"`. You can override this default by
        /// explicitly setting `Content-Type` to a particular media type when creating the job. For example, you can set
        /// `Content-Type` to `"application/json"`. The headers below are output only. They cannot be set or overridden:
        /// * `Content-Length`: This is computed by Cloud Scheduler. * `X-Google-*`: For Google internal use only. *
        /// `X-AppEngine-*`: For Google internal use only. In addition, some App Engine headers, which contain
        /// job-specific information, are also be sent to the job handler.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IDictionary<string, string> Headers { get; set; }

        /// <summary>The HTTP method to use for the request. PATCH and OPTIONS are not permitted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpMethod")]
        public virtual string HttpMethod { get; set; }

        /// <summary>
        /// The relative URI. The relative URL must begin with "/" and must be a valid HTTP relative URL. It can contain
        /// a path, query string arguments, and `#` fragments. If the relative URL is empty, then the root path "/" will
        /// be used. No spaces are allowed, and the maximum length allowed is 2083 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relativeUri")]
        public virtual string RelativeUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// App Engine Routing. For more information about services, versions, and instances see [An Overview of App
    /// Engine](https://cloud.google.com/appengine/docs/python/an-overview-of-app-engine), [Microservices Architecture
    /// on Google App Engine](https://cloud.google.com/appengine/docs/python/microservices-on-app-engine), [App Engine
    /// Standard request routing](https://cloud.google.com/appengine/docs/standard/python/how-requests-are-routed), and
    /// [App Engine Flex request
    /// routing](https://cloud.google.com/appengine/docs/flexible/python/how-requests-are-routed).
    /// </summary>
    public class AppEngineRouting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The host that the job is sent to. For more information about how App Engine requests are
        /// routed, see [here](https://cloud.google.com/appengine/docs/standard/python/how-requests-are-routed). The
        /// host is constructed as: * `host = [application_domain_name]` `| [service] + '.' + [application_domain_name]`
        /// `| [version] + '.' + [application_domain_name]` `| [version_dot_service]+ '.' + [application_domain_name]`
        /// `| [instance] + '.' + [application_domain_name]` `| [instance_dot_service] + '.' +
        /// [application_domain_name]` `| [instance_dot_version] + '.' + [application_domain_name]` `|
        /// [instance_dot_version_dot_service] + '.' + [application_domain_name]` * `application_domain_name` = The
        /// domain name of the app, for example .appspot.com, which is associated with the job's project ID. * `service
        /// =` service * `version =` version * `version_dot_service =` version `+ '.' +` service * `instance =` instance
        /// * `instance_dot_service =` instance `+ '.' +` service * `instance_dot_version =` instance `+ '.' +` version
        /// * `instance_dot_version_dot_service =` instance `+ '.' +` version `+ '.' +` service If service is empty,
        /// then the job will be sent to the service which is the default service when the job is attempted. If version
        /// is empty, then the job will be sent to the version which is the default version when the job is attempted.
        /// If instance is empty, then the job will be sent to an instance which is available when the job is attempted.
        /// If service, version, or instance is invalid, then the job will be sent to the default version of the default
        /// service when the job is attempted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>
        /// App instance. By default, the job is sent to an instance which is available when the job is attempted.
        /// Requests can only be sent to a specific instance if [manual scaling is used in App Engine
        /// Standard](https://cloud.google.com/appengine/docs/python/an-overview-of-app-engine?#scaling_types_and_instance_classes).
        /// App Engine Flex does not support instances. For more information, see [App Engine Standard request
        /// routing](https://cloud.google.com/appengine/docs/standard/python/how-requests-are-routed) and [App Engine
        /// Flex request routing](https://cloud.google.com/appengine/docs/flexible/python/how-requests-are-routed).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual string Instance { get; set; }

        /// <summary>
        /// App service. By default, the job is sent to the service which is the default service when the job is
        /// attempted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>
        /// App version. By default, the job is sent to the version which is the default version when the job is
        /// attempted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

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
    /// Http target. The job will be pushed to the job handler by means of an HTTP request via an http_method such as
    /// HTTP POST, HTTP GET, etc. The job is acknowledged by means of an HTTP response code in the range [200 - 299]. A
    /// failure to receive a response constitutes a failed execution. For a redirected request, the response returned by
    /// the redirected request is considered.
    /// </summary>
    public class HttpTarget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// HTTP request body. A request body is allowed only if the HTTP method is POST, PUT, or PATCH. It is an error
        /// to set body on a job with an incompatible HttpMethod.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual string Body { get; set; }

        /// <summary>
        /// HTTP request headers. This map contains the header field names and values. The user can specify HTTP request
        /// headers to send with the job's HTTP request. Repeated headers are not supported, but a header value can
        /// contain commas. The following headers represent a subset of the headers that accompany the job's HTTP
        /// request. Some HTTP request headers are ignored or replaced. A partial list of headers that are ignored or
        /// replaced is below: * Host: This will be computed by Cloud Scheduler and derived from uri. *
        /// `Content-Length`: This will be computed by Cloud Scheduler. * `User-Agent`: This will be set to
        /// `"Google-Cloud-Scheduler"`. * `X-Google-*`: Google internal use only. * `X-AppEngine-*`: Google internal use
        /// only. * `X-CloudScheduler`: This header will be set to true. * `X-CloudScheduler-JobName`: This header will
        /// contain the job name. * `X-CloudScheduler-ScheduleTime`: For Cloud Scheduler jobs specified in the unix-cron
        /// format, this header will contain the job schedule as an offset of UTC parsed according to RFC3339. If the
        /// job has a body and the following headers are not set by the user, Cloud Scheduler sets default values: *
        /// `Content-Type`: This will be set to `"application/octet-stream"`. You can override this default by
        /// explicitly setting `Content-Type` to a particular media type when creating the job. For example, you can set
        /// `Content-Type` to `"application/json"`. The total size of headers must be less than 80KB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IDictionary<string, string> Headers { get; set; }

        /// <summary>Which HTTP method to use for the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpMethod")]
        public virtual string HttpMethod { get; set; }

        /// <summary>
        /// If specified, an [OAuth token](https://developers.google.com/identity/protocols/OAuth2) will be generated
        /// and attached as an `Authorization` header in the HTTP request. This type of authorization should generally
        /// only be used when calling Google APIs hosted on *.googleapis.com.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauthToken")]
        public virtual OAuthToken OauthToken { get; set; }

        /// <summary>
        /// If specified, an [OIDC](https://developers.google.com/identity/protocols/OpenIDConnect) token will be
        /// generated and attached as an `Authorization` header in the HTTP request. This type of authorization can be
        /// used for many scenarios, including calling Cloud Run, or endpoints where you intend to validate the token
        /// yourself.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oidcToken")]
        public virtual OidcToken OidcToken { get; set; }

        /// <summary>
        /// Required. The full URI path that the request will be sent to. This string must begin with either "http://"
        /// or "https://". Some examples of valid values for uri are: `http://acme.com` and
        /// `https://acme.com/sales:8080`. Cloud Scheduler will encode some characters for safety and compatibility. The
        /// maximum allowed URL length is 2083 characters after encoding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a job. The maximum allowed size for a job is 1MB.</summary>
    public class Job : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>App Engine HTTP target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appEngineHttpTarget")]
        public virtual AppEngineHttpTarget AppEngineHttpTarget { get; set; }

        /// <summary>
        /// The deadline for job attempts. If the request handler does not respond by this deadline then the request is
        /// cancelled and the attempt is marked as a `DEADLINE_EXCEEDED` failure. The failed attempt can be viewed in
        /// execution logs. Cloud Scheduler will retry the job according to the RetryConfig. The default and the allowed
        /// values depend on the type of target: * For HTTP targets, the default is 3 minutes. The deadline must be in
        /// the interval [15 seconds, 30 minutes]. * For App Engine HTTP targets, 0 indicates that the request has the
        /// default deadline. The default deadline depends on the scaling type of the service: 10 minutes for standard
        /// apps with automatic scaling, 24 hours for standard apps with manual and basic scaling, and 60 minutes for
        /// flex apps. If the request deadline is set, it must be in the interval [15 seconds, 24 hours 15 seconds]. *
        /// For Pub/Sub targets, this field is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attemptDeadline")]
        public virtual object AttemptDeadline { get; set; }

        /// <summary>
        /// Optionally caller-specified in CreateJob or UpdateJob. A human-readable description for the job. This string
        /// must not contain more than 500 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>HTTP target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpTarget")]
        public virtual HttpTarget HttpTarget { get; set; }

        private string _lastAttemptTimeRaw;

        private object _lastAttemptTime;

        /// <summary>Output only. The time the last job attempt started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastAttemptTime")]
        public virtual string LastAttemptTimeRaw
        {
            get => _lastAttemptTimeRaw;
            set
            {
                _lastAttemptTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastAttemptTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastAttemptTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastAttemptTimeDateTimeOffset instead.")]
        public virtual object LastAttemptTime
        {
            get => _lastAttemptTime;
            set
            {
                _lastAttemptTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastAttemptTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastAttemptTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastAttemptTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastAttemptTimeRaw);
            set => LastAttemptTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Immutable. This field is used to manage the legacy App Engine Cron jobs using the Cloud Scheduler API. If
        /// the field is set to true, the job will be considered a legacy job. Note that App Engine Cron jobs have fewer
        /// features than Cloud Scheduler jobs, e.g., are only limited to App Engine targets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("legacyAppEngineCron")]
        public virtual System.Nullable<bool> LegacyAppEngineCron { get; set; }

        /// <summary>
        /// Optionally caller-specified in CreateJob, after which it becomes output only. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`. * `PROJECT_ID` can contain letters ([A-Za-z]),
        /// numbers ([0-9]), hyphens (-), colons (:), or periods (.). For more information, see [Identifying
        /// projects](https://cloud.google.com/resource-manager/docs/creating-managing-projects#identifying_projects) *
        /// `LOCATION_ID` is the canonical ID for the job's location. The list of available locations can be obtained by
        /// calling ListLocations. For more information, see https://cloud.google.com/about/locations/. * `JOB_ID` can
        /// contain only letters ([A-Za-z]), numbers ([0-9]), hyphens (-), or underscores (_). The maximum length is 500
        /// characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Pub/Sub target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubTarget")]
        public virtual PubsubTarget PubsubTarget { get; set; }

        /// <summary>Settings that determine the retry behavior.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retryConfig")]
        public virtual RetryConfig RetryConfig { get; set; }

        /// <summary>
        /// Output only. Whether or not this Job satisfies the requirements of physical zone separation
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>
        /// Required, except when used with UpdateJob. Describes the schedule on which the job will be executed. The
        /// schedule can be either of the following types: * [Crontab](https://en.wikipedia.org/wiki/Cron#Overview) *
        /// English-like [schedule](https://cloud.google.com/scheduler/docs/configuring/cron-job-schedules) As a general
        /// rule, execution `n + 1` of a job will not begin until execution `n` has finished. Cloud Scheduler will never
        /// allow two simultaneously outstanding executions. For example, this implies that if the `n+1`th execution is
        /// scheduled to run at 16:00 but the `n`th execution takes until 16:15, the `n+1`th execution will not start
        /// until `16:15`. A scheduled start time will be delayed if the previous execution has not ended when its
        /// scheduled time occurs. If retry_count &amp;gt; 0 and a job attempt fails, the job will be tried a total of
        /// retry_count times, with exponential backoff, until the next scheduled start time. If retry_count is 0, a job
        /// attempt will not be retried if it fails. Instead the Cloud Scheduler system will wait for the next scheduled
        /// execution time. Setting retry_count to 0 does not prevent failed jobs from running according to schedule
        /// after the failure.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedule")]
        public virtual string Schedule { get; set; }

        private string _scheduleTimeRaw;

        private object _scheduleTime;

        /// <summary>
        /// Output only. The next time the job is scheduled. Note that this may be a retry of a previously failed
        /// attempt or the next execution time according to the schedule.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleTime")]
        public virtual string ScheduleTimeRaw
        {
            get => _scheduleTimeRaw;
            set
            {
                _scheduleTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _scheduleTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ScheduleTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ScheduleTimeDateTimeOffset instead.")]
        public virtual object ScheduleTime
        {
            get => _scheduleTime;
            set
            {
                _scheduleTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _scheduleTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ScheduleTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ScheduleTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ScheduleTimeRaw);
            set => ScheduleTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. State of the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. The response from the target for the last attempted execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual Status Status { get; set; }

        /// <summary>
        /// Specifies the time zone to be used in interpreting schedule. The value of this field must be a time zone
        /// name from the [tz database](http://en.wikipedia.org/wiki/Tz_database). Note that some time zones include a
        /// provision for daylight savings time. The rules for daylight saving time are determined by the chosen tz. For
        /// UTC use the string "utc". If a time zone is not specified, the default will be in UTC (also known as GMT).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        private string _userUpdateTimeRaw;

        private object _userUpdateTime;

        /// <summary>Output only. The creation time of the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userUpdateTime")]
        public virtual string UserUpdateTimeRaw
        {
            get => _userUpdateTimeRaw;
            set
            {
                _userUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _userUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UserUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UserUpdateTimeDateTimeOffset instead.")]
        public virtual object UserUpdateTime
        {
            get => _userUpdateTime;
            set
            {
                _userUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _userUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="UserUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UserUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UserUpdateTimeRaw);
            set => UserUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing jobs using ListJobs.</summary>
    public class ListJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of jobs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobs")]
        public virtual System.Collections.Generic.IList<Job> Jobs { get; set; }

        /// <summary>
        /// A token to retrieve next page of results. Pass this value in the page_token field in the subsequent call to
        /// ListJobs to retrieve the next page of results. If this is empty it indicates that there are no more results
        /// through which to paginate. The page token is valid for only 2 hours.
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
    /// Contains information needed for generating an [OAuth
    /// token](https://developers.google.com/identity/protocols/OAuth2). This type of authorization should generally
    /// only be used when calling Google APIs hosted on *.googleapis.com.
    /// </summary>
    public class OAuthToken : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// OAuth scope to be used for generating OAuth access token. If not specified,
        /// "https://www.googleapis.com/auth/cloud-platform" will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>
        /// [Service account email](https://cloud.google.com/iam/docs/service-accounts) to be used for generating OAuth
        /// token. The service account must be within the same project as the job. The caller must have
        /// iam.serviceAccounts.actAs permission for the service account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountEmail")]
        public virtual string ServiceAccountEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains information needed for generating an [OpenID Connect
    /// token](https://developers.google.com/identity/protocols/OpenIDConnect). This type of authorization can be used
    /// for many scenarios, including calling Cloud Run, or endpoints where you intend to validate the token yourself.
    /// </summary>
    public class OidcToken : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Audience to be used when generating OIDC token. If not specified, the URI specified in target will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audience")]
        public virtual string Audience { get; set; }

        /// <summary>
        /// [Service account email](https://cloud.google.com/iam/docs/service-accounts) to be used for generating OIDC
        /// token. The service account must be within the same project as the job. The caller must have
        /// iam.serviceAccounts.actAs permission for the service account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountEmail")]
        public virtual string ServiceAccountEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>
        /// Output only. Identifies whether the user has requested cancellation of the operation. Operations that have
        /// been cancelled successfully have google.longrunning.Operation.error value with a google.rpc.Status.code of
        /// `1`, corresponding to `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelRequested")]
        public virtual System.Nullable<bool> CancelRequested { get; set; }

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

        /// <summary>Output only. Human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusDetail")]
        public virtual string StatusDetail { get; set; }

        /// <summary>Output only. Server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Output only. Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for PauseJob.</summary>
    public class PauseJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A message that is published by publishers and consumed by subscribers. The message must contain either a
    /// non-empty data field or at least one attribute. Note that client libraries represent this object differently
    /// depending on the language. See the corresponding [client library
    /// documentation](https://cloud.google.com/pubsub/docs/reference/libraries) for more information. See [quotas and
    /// limits] (https://cloud.google.com/pubsub/quotas) for more information about message limits.
    /// </summary>
    public class PubsubMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Attributes for this message. If this field is empty, the message must contain non-empty data. This
        /// can be used to filter messages on the subscription.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// Optional. The message data field. If this field is empty, the message must contain at least one attribute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>
        /// ID of this message, assigned by the server when the message is published. Guaranteed to be unique within the
        /// topic. This value may be read by a subscriber that receives a `PubsubMessage` via a `Pull` call or a push
        /// delivery. It must not be populated by the publisher in a `Publish` call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageId")]
        public virtual string MessageId { get; set; }

        /// <summary>
        /// Optional. If non-empty, identifies related messages for which publish order should be respected. If a
        /// `Subscription` has `enable_message_ordering` set to `true`, messages published with the same non-empty
        /// `ordering_key` value will be delivered to subscribers in the order in which they are received by the Pub/Sub
        /// system. All `PubsubMessage`s published in a given `PublishRequest` must specify the same `ordering_key`
        /// value. For more information, see [ordering messages](https://cloud.google.com/pubsub/docs/ordering).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderingKey")]
        public virtual string OrderingKey { get; set; }

        private string _publishTimeRaw;

        private object _publishTime;

        /// <summary>
        /// The time at which the message was published, populated by the server when it receives the `Publish` call. It
        /// must not be populated by the publisher in a `Publish` call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishTime")]
        public virtual string PublishTimeRaw
        {
            get => _publishTimeRaw;
            set
            {
                _publishTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _publishTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="PublishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use PublishTimeDateTimeOffset instead.")]
        public virtual object PublishTime
        {
            get => _publishTime;
            set
            {
                _publishTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _publishTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="PublishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? PublishTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(PublishTimeRaw);
            set => PublishTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Pub/Sub target. The job will be delivered by publishing a message to the given Pub/Sub topic.</summary>
    public class PubsubTarget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Attributes for PubsubMessage. Pubsub message must contain either non-empty data, or at least one attribute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// The message payload for PubsubMessage. Pubsub message must contain either non-empty data, or at least one
        /// attribute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>
        /// Required. The name of the Cloud Pub/Sub topic to which messages will be published when a job is delivered.
        /// The topic name must be in the same format as required by Pub/Sub's
        /// [PublishRequest.name](https://cloud.google.com/pubsub/docs/reference/rpc/google.pubsub.v1#publishrequest),
        /// for example `projects/PROJECT_ID/topics/TOPIC_ID`. The topic must be in the same project as the Cloud
        /// Scheduler job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicName")]
        public virtual string TopicName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ResumeJob.</summary>
    public class ResumeJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Settings that determine the retry behavior. For more information, see [Retry
    /// jobs](https://cloud.google.com/scheduler/docs/configuring/retry-jobs). By default, if a job does not complete
    /// successfully (meaning that an acknowledgement is not received from the handler, then it will be retried with
    /// exponential backoff according to the settings in RetryConfig.
    /// </summary>
    public class RetryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The maximum amount of time to wait before retrying a job after it fails. The default value of this field is
        /// 1 hour.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxBackoffDuration")]
        public virtual object MaxBackoffDuration { get; set; }

        /// <summary>
        /// The time between retries will double `max_doublings` times. A job's retry interval starts at
        /// min_backoff_duration, then doubles `max_doublings` times, then increases linearly, and finally retries at
        /// intervals of max_backoff_duration up to retry_count times. For examples, see [Retry
        /// jobs](https://cloud.google.com/scheduler/docs/configuring/retry-jobs#max-doublings). The default value of
        /// this field is 5.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDoublings")]
        public virtual System.Nullable<int> MaxDoublings { get; set; }

        /// <summary>
        /// The time limit for retrying a failed job, measured from the time when an execution was first attempted. If
        /// specified with retry_count, the job will be retried until both limits are reached. The default value for
        /// max_retry_duration is zero, which means retry duration is unlimited. However, if retry_count is also 0, a
        /// job attempt won't be retried if it fails.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxRetryDuration")]
        public virtual object MaxRetryDuration { get; set; }

        /// <summary>
        /// The minimum amount of time to wait before retrying a job after it fails. The default value of this field is
        /// 5 seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minBackoffDuration")]
        public virtual object MinBackoffDuration { get; set; }

        /// <summary>
        /// The number of attempts that the system will make to run a job using the exponential backoff procedure
        /// described by max_doublings. The default value of retry_count is zero. If retry_count is 0 (and if
        /// max_retry_duration is also 0), a job attempt won't be retried if it fails. Instead, Cloud Scheduler system
        /// will wait for the next scheduled execution time. Setting retry_count to 0 doesn't prevent failed jobs from
        /// running according to schedule after the failure. If retry_count is set to a non-zero number, Cloud Scheduler
        /// will retry the failed job, using exponential backoff, for retry_count times until the job succeeds or the
        /// number of retries is exhausted. Note that the next scheduled execution time might be skipped if the retries
        /// continue through that time. Values greater than 5 and negative values are not allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retryCount")]
        public virtual System.Nullable<int> RetryCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for forcing a job to run now using RunJob.</summary>
    public class RunJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This field is used to manage the legacy App Engine Cron jobs using the Cloud Scheduler API. If the field is
        /// set to true, the job in the __cron queue with the corresponding name will be forced to run instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("legacyAppEngineCron")]
        public virtual System.Nullable<bool> LegacyAppEngineCron { get; set; }

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
}
