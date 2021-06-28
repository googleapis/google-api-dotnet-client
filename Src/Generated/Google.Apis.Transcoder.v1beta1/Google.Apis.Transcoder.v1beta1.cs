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

namespace Google.Apis.Transcoder.v1beta1
{
    /// <summary>The Transcoder Service.</summary>
    public class TranscoderService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public TranscoderService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public TranscoderService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "transcoder";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://transcoder.googleapis.com/";
        #else
            "https://transcoder.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://transcoder.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Transcoder API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Transcoder API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for Transcoder requests.</summary>
    public abstract class TranscoderBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new TranscoderBaseServiceRequest instance.</summary>
        protected TranscoderBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Transcoder parameter list.</summary>
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
                JobTemplates = new JobTemplatesResource(service);
                Jobs = new JobsResource(service);
            }

            /// <summary>Gets the JobTemplates resource.</summary>
            public virtual JobTemplatesResource JobTemplates { get; }

            /// <summary>The "jobTemplates" collection of methods.</summary>
            public class JobTemplatesResource
            {
                private const string Resource = "jobTemplates";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public JobTemplatesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a job template in the specified region.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent location to create this job template. Format:
                /// `projects/{project}/locations/{location}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Transcoder.v1beta1.Data.JobTemplate body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a job template in the specified region.</summary>
                public class CreateRequest : TranscoderBaseServiceRequest<Google.Apis.Transcoder.v1beta1.Data.JobTemplate>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Transcoder.v1beta1.Data.JobTemplate body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent location to create this job template. Format:
                    /// `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID to use for the job template, which will become the final component of the job
                    /// template's resource name. This value should be 4-63 characters, and valid characters must match
                    /// the regular expression `a-zA-Z*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("jobTemplateId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string JobTemplateId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Transcoder.v1beta1.Data.JobTemplate Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/jobTemplates";

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
                        RequestParameters.Add("jobTemplateId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "jobTemplateId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a job template.</summary>
                /// <param name="name">
                /// Required. The name of the job template to delete.
                /// `projects/{project}/locations/{location}/jobTemplates/{job_template}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a job template.</summary>
                public class DeleteRequest : TranscoderBaseServiceRequest<Google.Apis.Transcoder.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the job template to delete.
                    /// `projects/{project}/locations/{location}/jobTemplates/{job_template}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobTemplates/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns the job template data.</summary>
                /// <param name="name">
                /// Required. The name of the job template to retrieve. Format:
                /// `projects/{project}/locations/{location}/jobTemplates/{job_template}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Returns the job template data.</summary>
                public class GetRequest : TranscoderBaseServiceRequest<Google.Apis.Transcoder.v1beta1.Data.JobTemplate>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the job template to retrieve. Format:
                    /// `projects/{project}/locations/{location}/jobTemplates/{job_template}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobTemplates/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists job templates in the specified region.</summary>
                /// <param name="parent">
                /// Required. The parent location from which to retrieve the collection of job templates. Format:
                /// `projects/{project}/locations/{location}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists job templates in the specified region.</summary>
                public class ListRequest : TranscoderBaseServiceRequest<Google.Apis.Transcoder.v1beta1.Data.ListJobTemplatesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent location from which to retrieve the collection of job templates. Format:
                    /// `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>The maximum number of items to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The `next_page_token` value returned from a previous List request, if any.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/jobTemplates";

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

                /// <summary>Creates a job in the specified region.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent location to create and process this job. Format:
                /// `projects/{project}/locations/{location}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Transcoder.v1beta1.Data.Job body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a job in the specified region.</summary>
                public class CreateRequest : TranscoderBaseServiceRequest<Google.Apis.Transcoder.v1beta1.Data.Job>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Transcoder.v1beta1.Data.Job body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent location to create and process this job. Format:
                    /// `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Transcoder.v1beta1.Data.Job Body { get; set; }

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
                /// Required. The name of the job to delete. Format:
                /// `projects/{project}/locations/{location}/jobs/{job}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a job.</summary>
                public class DeleteRequest : TranscoderBaseServiceRequest<Google.Apis.Transcoder.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the job to delete. Format:
                    /// `projects/{project}/locations/{location}/jobs/{job}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns the job data.</summary>
                /// <param name="name">
                /// Required. The name of the job to retrieve. Format:
                /// `projects/{project}/locations/{location}/jobs/{job}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Returns the job data.</summary>
                public class GetRequest : TranscoderBaseServiceRequest<Google.Apis.Transcoder.v1beta1.Data.Job>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the job to retrieve. Format:
                    /// `projects/{project}/locations/{location}/jobs/{job}`
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

                /// <summary>Lists jobs in the specified region.</summary>
                /// <param name="parent">Required. Format: `projects/{project}/locations/{location}`</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists jobs in the specified region.</summary>
                public class ListRequest : TranscoderBaseServiceRequest<Google.Apis.Transcoder.v1beta1.Data.ListJobsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Format: `projects/{project}/locations/{location}`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>The maximum number of items to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The `next_page_token` value returned from a previous List request, if any.</summary>
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
}
namespace Google.Apis.Transcoder.v1beta1.Data
{
    /// <summary>Ad break.</summary>
    public class AdBreak : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Start time in seconds for the ad break, relative to the output file timeline. The default is `0s`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeOffset")]
        public virtual object StartTimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for AES-128 encryption.</summary>
    public class Aes128Encryption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. URI of the key delivery service. This URI is inserted into the M3U8 header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyUri")]
        public virtual string KeyUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Animation types.</summary>
    public class Animation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>End previous animation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("animationEnd")]
        public virtual AnimationEnd AnimationEnd { get; set; }

        /// <summary>Display overlay object with fade animation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("animationFade")]
        public virtual AnimationFade AnimationFade { get; set; }

        /// <summary>Display static overlay object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("animationStatic")]
        public virtual AnimationStatic AnimationStatic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// End previous overlay animation from the video. Without AnimationEnd, the overlay object will keep the state of
    /// previous animation until the end of the video.
    /// </summary>
    public class AnimationEnd : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time to end overlay object, in seconds. Default: 0</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeOffset")]
        public virtual object StartTimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Display overlay object with fade animation.</summary>
    public class AnimationFade : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time to end the fade animation, in seconds. Default: `start_time_offset` + 1s</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTimeOffset")]
        public virtual object EndTimeOffset { get; set; }

        /// <summary>Required. Type of fade animation: `FADE_IN` or `FADE_OUT`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fadeType")]
        public virtual string FadeType { get; set; }

        /// <summary>The time to start the fade animation, in seconds. Default: 0</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeOffset")]
        public virtual object StartTimeOffset { get; set; }

        /// <summary>
        /// Normalized coordinates based on output video resolution. Valid values: `0.0`–`1.0`. `xy` is the upper-left
        /// coordinate of the overlay object. For example, use the x and y coordinates {0,0} to position the top-left
        /// corner of the overlay animation in the top-left corner of the output video.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("xy")]
        public virtual NormalizedCoordinate Xy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Display static overlay object.</summary>
    public class AnimationStatic : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time to start displaying the overlay object, in seconds. Default: 0</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeOffset")]
        public virtual object StartTimeOffset { get; set; }

        /// <summary>
        /// Normalized coordinates based on output video resolution. Valid values: `0.0`–`1.0`. `xy` is the upper-left
        /// coordinate of the overlay object. For example, use the x and y coordinates {0,0} to position the top-left
        /// corner of the overlay animation in the top-left corner of the output video.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("xy")]
        public virtual NormalizedCoordinate Xy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Audio preprocessing configuration.</summary>
    public class Audio : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Enable boosting high frequency components. The default is `false`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("highBoost")]
        public virtual System.Nullable<bool> HighBoost { get; set; }

        /// <summary>Enable boosting low frequency components. The default is `false`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lowBoost")]
        public virtual System.Nullable<bool> LowBoost { get; set; }

        /// <summary>
        /// Specify audio loudness normalization in loudness units relative to full scale (LUFS). Enter a value between
        /// -24 and 0 (the default), where: * -24 is the Advanced Television Systems Committee (ATSC A/85) standard *
        /// -23 is the EU R128 broadcast standard * -19 is the prior standard for online mono audio * -18 is the
        /// ReplayGain standard * -16 is the prior standard for stereo audio * -14 is the new online audio standard
        /// recommended by Spotify, as well as Amazon Echo * 0 disables normalization
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lufs")]
        public virtual System.Nullable<double> Lufs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The mapping for the `Job.edit_list` atoms with audio `EditAtom.inputs`.</summary>
    public class AudioAtom : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of `Channel`s for this audio stream. for in-depth explanation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channels")]
        public virtual System.Collections.Generic.IList<AudioChannel> Channels { get; set; }

        /// <summary>
        /// Required. The `EditAtom.key` that references the atom with audio inputs in the `Job.edit_list`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The audio channel.</summary>
    public class AudioChannel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of `Job.inputs` for this audio channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputs")]
        public virtual System.Collections.Generic.IList<AudioChannelInput> Inputs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identifies which input file, track, and channel should be used.</summary>
    public class AudioChannelInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The zero-based index of the channel in the input file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channel")]
        public virtual System.Nullable<int> Channel { get; set; }

        /// <summary>
        /// Audio volume control in dB. Negative values decrease volume, positive values increase. The default is 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gainDb")]
        public virtual System.Nullable<double> GainDb { get; set; }

        /// <summary>Required. The `Input.key` that identifies the input file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Required. The zero-based index of the track in the input file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("track")]
        public virtual System.Nullable<int> Track { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Audio stream resource.</summary>
    public class AudioStream : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Audio bitrate in bits per second. Must be between 1 and 10,000,000.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bitrateBps")]
        public virtual System.Nullable<int> BitrateBps { get; set; }

        /// <summary>Number of audio channels. Must be between 1 and 6. The default is 2.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelCount")]
        public virtual System.Nullable<int> ChannelCount { get; set; }

        /// <summary>
        /// A list of channel names specifying layout of the audio channels. This only affects the metadata embedded in
        /// the container headers, if supported by the specified format. The default is `["fl", "fr"]`. Supported
        /// channel names: - 'fl' - Front left channel - 'fr' - Front right channel - 'sl' - Side left channel - 'sr' -
        /// Side right channel - 'fc' - Front center channel - 'lfe' - Low frequency
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelLayout")]
        public virtual System.Collections.Generic.IList<string> ChannelLayout { get; set; }

        /// <summary>
        /// The codec for this audio stream. The default is `"aac"`. Supported audio codecs: - 'aac' - 'aac-he' -
        /// 'aac-he-v2' - 'mp3' - 'ac3' - 'eac3'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codec")]
        public virtual string Codec { get; set; }

        /// <summary>The mapping for the `Job.edit_list` atoms with audio `EditAtom.inputs`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mapping")]
        public virtual System.Collections.Generic.IList<AudioAtom> Mapping { get; set; }

        /// <summary>The audio sample rate in Hertz. The default is 48000 Hertz.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleRateHertz")]
        public virtual System.Nullable<int> SampleRateHertz { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Color preprocessing configuration.</summary>
    public class Color : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Control brightness of the video. Enter a value between -1 and 1, where -1 is minimum brightness and 1 is
        /// maximum brightness. 0 is no change. The default is 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brightness")]
        public virtual System.Nullable<double> Brightness { get; set; }

        /// <summary>
        /// Control black and white contrast of the video. Enter a value between -1 and 1, where -1 is minimum contrast
        /// and 1 is maximum contrast. 0 is no change. The default is 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contrast")]
        public virtual System.Nullable<double> Contrast { get; set; }

        /// <summary>
        /// Control color saturation of the video. Enter a value between -1 and 1, where -1 is fully desaturated and 1
        /// is maximum saturation. 0 is no change. The default is 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("saturation")]
        public virtual System.Nullable<double> Saturation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Video cropping configuration for the input video. The cropped input video is scaled to match the output
    /// resolution.
    /// </summary>
    public class Crop : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of pixels to crop from the bottom. The default is 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bottomPixels")]
        public virtual System.Nullable<int> BottomPixels { get; set; }

        /// <summary>The number of pixels to crop from the left. The default is 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leftPixels")]
        public virtual System.Nullable<int> LeftPixels { get; set; }

        /// <summary>The number of pixels to crop from the right. The default is 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rightPixels")]
        public virtual System.Nullable<int> RightPixels { get; set; }

        /// <summary>The number of pixels to crop from the top. The default is 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topPixels")]
        public virtual System.Nullable<int> TopPixels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deblock preprocessing configuration.</summary>
    public class Deblock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Enable deblocker. The default is `false`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>
        /// Set strength of the deblocker. Enter a value between 0 and 1. The higher the value, the stronger the block
        /// removal. 0 is no deblocking. The default is 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("strength")]
        public virtual System.Nullable<double> Strength { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Denoise preprocessing configuration.</summary>
    public class Denoise : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Set strength of the denoise. Enter a value between 0 and 1. The higher the value, the smoother the image. 0
        /// is no denoising. The default is 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("strength")]
        public virtual System.Nullable<double> Strength { get; set; }

        /// <summary>
        /// Set the denoiser mode. The default is `"standard"`. Supported denoiser modes: - 'standard' - 'grain'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tune")]
        public virtual string Tune { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Edit atom.</summary>
    public class EditAtom : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// End time in seconds for the atom, relative to the input file timeline. When `end_time_offset` is not
        /// specified, the `inputs` are used until the end of the atom.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTimeOffset")]
        public virtual object EndTimeOffset { get; set; }

        /// <summary>
        /// List of `Input.key`s identifying files that should be used in this atom. The listed `inputs` must have the
        /// same timeline.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputs")]
        public virtual System.Collections.Generic.IList<string> Inputs { get; set; }

        /// <summary>A unique key for this atom. Must be specified when using advanced mapping.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// Start time in seconds for the atom, relative to the input file timeline. The default is `0s`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeOffset")]
        public virtual object StartTimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Encoding of an input file such as an audio, video, or text track. Elementary streams must be packaged before
    /// mapping and sharing between different output formats.
    /// </summary>
    public class ElementaryStream : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Encoding of an audio stream.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioStream")]
        public virtual AudioStream AudioStream { get; set; }

        /// <summary>A unique key for this elementary stream.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Encoding of a text stream. For example, closed captions or subtitles.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStream")]
        public virtual TextStream TextStream { get; set; }

        /// <summary>Encoding of a video stream.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoStream")]
        public virtual VideoStream VideoStream { get; set; }

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

    /// <summary>Encryption settings.</summary>
    public class Encryption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration for AES-128 encryption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aes128")]
        public virtual Aes128Encryption Aes128 { get; set; }

        /// <summary>Required. 128 bit Initialization Vector (IV) represented as lowercase hexadecimal digits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iv")]
        public virtual string Iv { get; set; }

        /// <summary>Required. 128 bit encryption key represented as lowercase hexadecimal digits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Configuration for MPEG Common Encryption (MPEG-CENC).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mpegCenc")]
        public virtual MpegCommonEncryption MpegCenc { get; set; }

        /// <summary>Configuration for SAMPLE-AES encryption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleAes")]
        public virtual SampleAesEncryption SampleAes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional information about the reasons for the failure.</summary>
    public class FailureDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A description of the failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Overlaid jpeg image.</summary>
    public class Image : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Target image opacity. Valid values are from `1.0` (solid, default) to `0.0` (transparent), exclusive. Set
        /// this to a value greater than `0.0`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alpha")]
        public virtual System.Nullable<double> Alpha { get; set; }

        /// <summary>
        /// Normalized image resolution, based on output video resolution. Valid values: `0.0`–`1.0`. To respect the
        /// original image aspect ratio, set either `x` or `y` to `0.0`. To use the original image resolution, set both
        /// `x` and `y` to `0.0`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolution")]
        public virtual NormalizedCoordinate Resolution { get; set; }

        /// <summary>
        /// Required. URI of the JPEG image in Cloud Storage. For example, `gs://bucket/inputs/image.jpeg`. JPEG is the
        /// only supported image type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Input asset.</summary>
    public class Input : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A unique key for this input. Must be specified when using advanced mapping and edit lists.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Preprocessing configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preprocessingConfig")]
        public virtual PreprocessingConfig PreprocessingConfig { get; set; }

        /// <summary>
        /// URI of the media. Input files must be at least 5 seconds in duration and stored in Cloud Storage (for
        /// example, `gs://bucket/inputs/file.mp4`). If empty, the value will be populated from `Job.input_uri`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Transcoding job resource.</summary>
    public class Job : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for this job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual JobConfig Config { get; set; }

        /// <summary>Output only. The time the job was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time the transcoding finished.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Output only. List of failure details. This property may contain additional information about the failure
        /// when `failure_reason` is present. *Note*: This feature is not yet available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureDetails")]
        public virtual System.Collections.Generic.IList<FailureDetail> FailureDetails { get; set; }

        /// <summary>
        /// Output only. A description of the reason for the failure. This property is always present when `state` is
        /// `FAILED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureReason")]
        public virtual string FailureReason { get; set; }

        /// <summary>
        /// Input only. Specify the `input_uri` to populate empty `uri` fields in each element of `Job.config.inputs` or
        /// `JobTemplate.config.inputs` when using template. URI of the media. Input files must be at least 5 seconds in
        /// duration and stored in Cloud Storage (for example, `gs://bucket/inputs/file.mp4`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUri")]
        public virtual string InputUri { get; set; }

        /// <summary>
        /// The resource name of the job. Format: `projects/{project}/locations/{location}/jobs/{job}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The origin URI. *Note*: This feature is not yet available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originUri")]
        public virtual OriginUri OriginUri { get; set; }

        /// <summary>
        /// Input only. Specify the `output_uri` to populate an empty `Job.config.output.uri` or
        /// `JobTemplate.config.output.uri` when using template. URI for the output file(s). For example,
        /// `gs://my-bucket/outputs/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputUri")]
        public virtual string OutputUri { get; set; }

        /// <summary>
        /// Specify the priority of the job. Enter a value between 0 and 100, where 0 is the lowest priority and 100 is
        /// the highest priority. The default is 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual System.Nullable<int> Priority { get; set; }

        /// <summary>
        /// Output only. Estimated fractional progress, from `0` to `1` for each step. *Note*: This feature is not yet
        /// available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progress")]
        public virtual Progress Progress { get; set; }

        /// <summary>Output only. The time the transcoding started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>Output only. The current state of the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Input only. Specify the `template_id` to use for populating `Job.config`. The default is `preset/web-hd`.
        /// Preset Transcoder templates: - `preset/{preset_id}` - User defined JobTemplate: `{job_template_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("templateId")]
        public virtual string TemplateId { get; set; }

        /// <summary>
        /// Job time to live value in days, which will be effective after job completion. Job should be deleted
        /// automatically after the given TTL. Enter a value between 1 and 90. The default is 30.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttlAfterCompletionDays")]
        public virtual System.Nullable<int> TtlAfterCompletionDays { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Job configuration</summary>
    public class JobConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of ad breaks. Specifies where to insert ad break tags in the output manifests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adBreaks")]
        public virtual System.Collections.Generic.IList<AdBreak> AdBreaks { get; set; }

        /// <summary>List of `Edit atom`s. Defines the ultimate timeline of the resulting file or manifest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("editList")]
        public virtual System.Collections.Generic.IList<EditAtom> EditList { get; set; }

        /// <summary>List of elementary streams.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elementaryStreams")]
        public virtual System.Collections.Generic.IList<ElementaryStream> ElementaryStreams { get; set; }

        /// <summary>List of input assets stored in Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputs")]
        public virtual System.Collections.Generic.IList<Input> Inputs { get; set; }

        /// <summary>List of output manifests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manifests")]
        public virtual System.Collections.Generic.IList<Manifest> Manifests { get; set; }

        /// <summary>List of multiplexing settings for output streams.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("muxStreams")]
        public virtual System.Collections.Generic.IList<MuxStream> MuxStreams { get; set; }

        /// <summary>Output configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("output")]
        public virtual Output Output { get; set; }

        /// <summary>List of overlays on the output video, in descending Z-order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overlays")]
        public virtual System.Collections.Generic.IList<Overlay> Overlays { get; set; }

        /// <summary>Destination on Pub/Sub.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubDestination")]
        public virtual PubsubDestination PubsubDestination { get; set; }

        /// <summary>List of output sprite sheets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spriteSheets")]
        public virtual System.Collections.Generic.IList<SpriteSheet> SpriteSheets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Transcoding job template resource.</summary>
    public class JobTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for this template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual JobConfig Config { get; set; }

        /// <summary>
        /// The resource name of the job template. Format:
        /// `projects/{project}/locations/{location}/jobTemplates/{job_template}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `TranscoderService.ListJobTemplates`.</summary>
    public class ListJobTemplatesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of job templates in the specified region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobTemplates")]
        public virtual System.Collections.Generic.IList<JobTemplate> JobTemplates { get; set; }

        /// <summary>The pagination token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `TranscoderService.ListJobs`.</summary>
    public class ListJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of jobs in the specified region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobs")]
        public virtual System.Collections.Generic.IList<Job> Jobs { get; set; }

        /// <summary>The pagination token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Manifest configuration.</summary>
    public class Manifest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the generated file. The default is `"manifest"` with the extension suffix corresponding to the
        /// `Manifest.type`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileName")]
        public virtual string FileName { get; set; }

        /// <summary>
        /// Required. List of user given `MuxStream.key`s that should appear in this manifest. When `Manifest.type` is
        /// `HLS`, a media manifest with name `MuxStream.key` and `.m3u8` extension is generated for each element of the
        /// `Manifest.mux_streams`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("muxStreams")]
        public virtual System.Collections.Generic.IList<string> MuxStreams { get; set; }

        /// <summary>Required. Type of the manifest, can be "HLS" or "DASH".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for MPEG Common Encryption (MPEG-CENC).</summary>
    public class MpegCommonEncryption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. 128 bit Key ID represented as lowercase hexadecimal digits for use with common encryption.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyId")]
        public virtual string KeyId { get; set; }

        /// <summary>Required. Specify the encryption scheme. Supported encryption schemes: - 'cenc' - 'cbcs'</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheme")]
        public virtual string Scheme { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Multiplexing settings for output stream.</summary>
    public class MuxStream : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The container format. The default is `"mp4"` Supported container formats: - 'ts' - 'fmp4'- the corresponding
        /// file extension is `".m4s"` - 'mp4' - 'vtt'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("container")]
        public virtual string Container { get; set; }

        /// <summary>List of `ElementaryStream.key`s multiplexed in this stream.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elementaryStreams")]
        public virtual System.Collections.Generic.IList<string> ElementaryStreams { get; set; }

        /// <summary>Encryption settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryption")]
        public virtual Encryption Encryption { get; set; }

        /// <summary>
        /// The name of the generated file. The default is `MuxStream.key` with the extension suffix corresponding to
        /// the `MuxStream.container`. Individual segments also have an incremental 10-digit zero-padded suffix starting
        /// from 0 before the extension, such as `"mux_stream0000000123.ts"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileName")]
        public virtual string FileName { get; set; }

        /// <summary>
        /// A unique key for this multiplexed stream. HLS media manifests will be named `MuxStream.key` with the
        /// `".m3u8"` extension suffix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Segment settings for `"ts"`, `"fmp4"` and `"vtt"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentSettings")]
        public virtual SegmentSettings SegmentSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>2D normalized coordinates. Default: `{0.0, 0.0}`</summary>
    public class NormalizedCoordinate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Normalized x coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual System.Nullable<double> X { get; set; }

        /// <summary>Normalized y coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual System.Nullable<double> Y { get; set; }

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
        /// successfully been cancelled have Operation.error value with a google.rpc.Status.code of 1, corresponding to
        /// `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelRequested")]
        public virtual System.Nullable<bool> CancelRequested { get; set; }

        /// <summary>Output only. The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

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

    /// <summary>The origin URI.</summary>
    public class OriginUri : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Dash manifest URI. If multiple Dash manifests are created, only the first one is listed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dash")]
        public virtual string Dash { get; set; }

        /// <summary>
        /// HLS manifest URI per https://tools.ietf.org/html/rfc8216#section-4.3.4. If multiple HLS manifests are
        /// created, only the first one is listed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hls")]
        public virtual string Hls { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location of output file(s) in a Cloud Storage bucket.</summary>
    public class Output : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// URI for the output file(s). For example, `gs://my-bucket/outputs/`. If empty the value is populated from
        /// `Job.output_uri`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Overlay configuration.</summary>
    public class Overlay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of Animations. The list should be chronological, without any time overlap.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("animations")]
        public virtual System.Collections.Generic.IList<Animation> Animations { get; set; }

        /// <summary>Image overlay.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual Image Image { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Pad filter configuration for the input video. The padded input video is scaled after padding with black to match
    /// the output resolution.
    /// </summary>
    public class Pad : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of pixels to add to the bottom. The default is 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bottomPixels")]
        public virtual System.Nullable<int> BottomPixels { get; set; }

        /// <summary>The number of pixels to add to the left. The default is 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leftPixels")]
        public virtual System.Nullable<int> LeftPixels { get; set; }

        /// <summary>The number of pixels to add to the right. The default is 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rightPixels")]
        public virtual System.Nullable<int> RightPixels { get; set; }

        /// <summary>The number of pixels to add to the top. The default is 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topPixels")]
        public virtual System.Nullable<int> TopPixels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Preprocessing configurations.</summary>
    public class PreprocessingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Audio preprocessing configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audio")]
        public virtual Audio Audio { get; set; }

        /// <summary>Color preprocessing configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual Color Color { get; set; }

        /// <summary>Specify the video cropping configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crop")]
        public virtual Crop Crop { get; set; }

        /// <summary>Deblock preprocessing configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deblock")]
        public virtual Deblock Deblock { get; set; }

        /// <summary>Denoise preprocessing configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denoise")]
        public virtual Denoise Denoise { get; set; }

        /// <summary>Specify the video pad filter configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pad")]
        public virtual Pad Pad { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Estimated fractional progress for each step, from `0` to `1`.</summary>
    public class Progress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Estimated fractional progress for `analyzing` step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyzed")]
        public virtual System.Nullable<double> Analyzed { get; set; }

        /// <summary>Estimated fractional progress for `encoding` step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoded")]
        public virtual System.Nullable<double> Encoded { get; set; }

        /// <summary>Estimated fractional progress for `notifying` step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notified")]
        public virtual System.Nullable<double> Notified { get; set; }

        /// <summary>Estimated fractional progress for `uploading` step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploaded")]
        public virtual System.Nullable<double> Uploaded { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Pub/Sub destination.</summary>
    public class PubsubDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the Pub/Sub topic to publish job completion notification to. For example:
        /// `projects/{project}/topics/{topic}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for SAMPLE-AES encryption.</summary>
    public class SampleAesEncryption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. URI of the key delivery service. This URI is inserted into the M3U8 header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyUri")]
        public virtual string KeyUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Segment settings for `"ts"`, `"fmp4"` and `"vtt"`.</summary>
    public class SegmentSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Create an individual segment file. The default is `false`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualSegments")]
        public virtual System.Nullable<bool> IndividualSegments { get; set; }

        /// <summary>
        /// Duration of the segments in seconds. The default is `"6.0s"`. Note that `segmentDuration` must be greater
        /// than or equal to [`gopDuration`](#videostream), and `segmentDuration` must be divisible by
        /// [`gopDuration`](#videostream).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentDuration")]
        public virtual object SegmentDuration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sprite sheet configuration.</summary>
    public class SpriteSheet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The maximum number of sprites per row in a sprite sheet. The default is 0, which indicates no maximum limit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnCount")]
        public virtual System.Nullable<int> ColumnCount { get; set; }

        /// <summary>
        /// End time in seconds, relative to the output file timeline. When `end_time_offset` is not specified, the
        /// sprites are generated until the end of the output file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTimeOffset")]
        public virtual object EndTimeOffset { get; set; }

        /// <summary>
        /// Required. File name prefix for the generated sprite sheets. Each sprite sheet has an incremental 10-digit
        /// zero-padded suffix starting from 0 before the extension, such as `"sprite_sheet0000000123.jpeg"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filePrefix")]
        public virtual string FilePrefix { get; set; }

        /// <summary>Format type. The default is `"jpeg"`. Supported formats: - 'jpeg'</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>
        /// Starting from `0s`, create sprites at regular intervals. Specify the interval value in seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interval")]
        public virtual object Interval { get; set; }

        /// <summary>
        /// The quality of the generated sprite sheet. Enter a value between 1 and 100, where 1 is the lowest quality
        /// and 100 is the highest quality. The default is 100. A high quality value corresponds to a low image data
        /// compression ratio.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quality")]
        public virtual System.Nullable<int> Quality { get; set; }

        /// <summary>
        /// The maximum number of rows per sprite sheet. When the sprite sheet is full, a new sprite sheet is created.
        /// The default is 0, which indicates no maximum limit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowCount")]
        public virtual System.Nullable<int> RowCount { get; set; }

        /// <summary>
        /// Required. The height of sprite in pixels. Must be an even integer. To preserve the source aspect ratio, set
        /// the SpriteSheet.sprite_height_pixels field or the SpriteSheet.sprite_width_pixels field, but not both (the
        /// API will automatically calculate the missing field).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spriteHeightPixels")]
        public virtual System.Nullable<int> SpriteHeightPixels { get; set; }

        /// <summary>
        /// Required. The width of sprite in pixels. Must be an even integer. To preserve the source aspect ratio, set
        /// the SpriteSheet.sprite_width_pixels field or the SpriteSheet.sprite_height_pixels field, but not both (the
        /// API will automatically calculate the missing field).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spriteWidthPixels")]
        public virtual System.Nullable<int> SpriteWidthPixels { get; set; }

        /// <summary>
        /// Start time in seconds, relative to the output file timeline. Determines the first sprite to pick. The
        /// default is `0s`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeOffset")]
        public virtual object StartTimeOffset { get; set; }

        /// <summary>
        /// Total number of sprites. Create the specified number of sprites distributed evenly across the timeline of
        /// the output media. The default is 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalCount")]
        public virtual System.Nullable<int> TotalCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The mapping for the `Job.edit_list` atoms with text `EditAtom.inputs`.</summary>
    public class TextAtom : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of `Job.inputs` that should be embedded in this atom. Only one input is supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputs")]
        public virtual System.Collections.Generic.IList<TextInput> Inputs { get; set; }

        /// <summary>
        /// Required. The `EditAtom.key` that references atom with text inputs in the `Job.edit_list`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identifies which input file and track should be used.</summary>
    public class TextInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The `Input.key` that identifies the input file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Required. The zero-based index of the track in the input file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("track")]
        public virtual System.Nullable<int> Track { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encoding of a text stream. For example, closed captions or subtitles.</summary>
    public class TextStream : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The codec for this text stream. The default is `"webvtt"`. Supported text codecs: - 'srt' - 'ttml' -
        /// 'cea608' - 'cea708' - 'webvtt'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codec")]
        public virtual string Codec { get; set; }

        /// <summary>
        /// Required. The BCP-47 language code, such as `"en-US"` or `"sr-Latn"`. For more information, see
        /// https://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The mapping for the `Job.edit_list` atoms with text `EditAtom.inputs`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mapping")]
        public virtual System.Collections.Generic.IList<TextAtom> Mapping { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video stream resource.</summary>
    public class VideoStream : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies whether an open Group of Pictures (GOP) structure should be allowed or not. The default is
        /// `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowOpenGop")]
        public virtual System.Nullable<bool> AllowOpenGop { get; set; }

        /// <summary>
        /// Specify the intensity of the adaptive quantizer (AQ). Must be between 0 and 1, where 0 disables the
        /// quantizer and 1 maximizes the quantizer. A higher value equals a lower bitrate but smoother image. The
        /// default is 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aqStrength")]
        public virtual System.Nullable<double> AqStrength { get; set; }

        /// <summary>
        /// The number of consecutive B-frames. Must be greater than or equal to zero. Must be less than
        /// `VideoStream.gop_frame_count` if set. The default is 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bFrameCount")]
        public virtual System.Nullable<int> BFrameCount { get; set; }

        /// <summary>
        /// Allow B-pyramid for reference frame selection. This may not be supported on all decoders. The default is
        /// `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bPyramid")]
        public virtual System.Nullable<bool> BPyramid { get; set; }

        /// <summary>Required. The video bitrate in bits per second. Must be between 1 and 1,000,000,000.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bitrateBps")]
        public virtual System.Nullable<int> BitrateBps { get; set; }

        /// <summary>Codec type. The following codecs are supported: * `h264` (default) * `h265` * `vp9`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codec")]
        public virtual string Codec { get; set; }

        /// <summary>
        /// Target CRF level. Must be between 10 and 36, where 10 is the highest quality and 36 is the most efficient
        /// compression. The default is 21.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crfLevel")]
        public virtual System.Nullable<int> CrfLevel { get; set; }

        /// <summary>
        /// Use two-pass encoding strategy to achieve better video quality. `VideoStream.rate_control_mode` must be
        /// `"vbr"`. The default is `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableTwoPass")]
        public virtual System.Nullable<bool> EnableTwoPass { get; set; }

        /// <summary>
        /// The entropy coder to use. The default is `"cabac"`. Supported entropy coders: - 'cavlc' - 'cabac'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entropyCoder")]
        public virtual string EntropyCoder { get; set; }

        /// <summary>
        /// Required. The target video frame rate in frames per second (FPS). Must be less than or equal to 120. Will
        /// default to the input frame rate if larger than the input frame rate. The API will generate an output FPS
        /// that is divisible by the input FPS, and smaller or equal to the target FPS. See [Calculate frame
        /// rate](https://cloud.google.com/transcoder/docs/concepts/frame-rate) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frameRate")]
        public virtual System.Nullable<double> FrameRate { get; set; }

        /// <summary>
        /// Select the GOP size based on the specified duration. The default is `"3s"`. Note that `gopDuration` must be
        /// less than or equal to [`segmentDuration`](#SegmentSettings), and [`segmentDuration`](#SegmentSettings) must
        /// be divisible by `gopDuration`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gopDuration")]
        public virtual object GopDuration { get; set; }

        /// <summary>Select the GOP size based on the specified frame count. Must be greater than zero.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gopFrameCount")]
        public virtual System.Nullable<int> GopFrameCount { get; set; }

        /// <summary>
        /// The height of the video in pixels. Must be an even integer. When not specified, the height is adjusted to
        /// match the specified width and input aspect ratio. If both are omitted, the input height is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heightPixels")]
        public virtual System.Nullable<int> HeightPixels { get; set; }

        /// <summary>
        /// Pixel format to use. The default is `"yuv420p"`. Supported pixel formats: - 'yuv420p' pixel format. -
        /// 'yuv422p' pixel format. - 'yuv444p' pixel format. - 'yuv420p10' 10-bit HDR pixel format. - 'yuv422p10'
        /// 10-bit HDR pixel format. - 'yuv444p10' 10-bit HDR pixel format. - 'yuv420p12' 12-bit HDR pixel format. -
        /// 'yuv422p12' 12-bit HDR pixel format. - 'yuv444p12' 12-bit HDR pixel format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pixelFormat")]
        public virtual string PixelFormat { get; set; }

        /// <summary>
        /// Enforces the specified codec preset. The default is `veryfast`. The available options are FFmpeg-compatible.
        /// Note that certain values for this field may cause the transcoder to override other fields you set in the
        /// `VideoStream` message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preset")]
        public virtual string Preset { get; set; }

        /// <summary>
        /// Enforces the specified codec profile. The following profiles are supported: * `baseline` * `main` * `high`
        /// (default) The available options are FFmpeg-compatible. Note that certain values for this field may cause the
        /// transcoder to override other fields you set in the `VideoStream` message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profile")]
        public virtual string Profile { get; set; }

        /// <summary>
        /// Specify the `rate_control_mode`. The default is `"vbr"`. Supported rate control modes: - 'vbr' - variable
        /// bitrate - 'crf' - constant rate factor
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rateControlMode")]
        public virtual string RateControlMode { get; set; }

        /// <summary>
        /// Enforces the specified codec tune. The available options are FFmpeg-compatible. Note that certain values for
        /// this field may cause the transcoder to override other fields you set in the `VideoStream` message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tune")]
        public virtual string Tune { get; set; }

        /// <summary>
        /// Initial fullness of the Video Buffering Verifier (VBV) buffer in bits. Must be greater than zero. The
        /// default is equal to 90% of `VideoStream.vbv_size_bits`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vbvFullnessBits")]
        public virtual System.Nullable<int> VbvFullnessBits { get; set; }

        /// <summary>
        /// Size of the Video Buffering Verifier (VBV) buffer in bits. Must be greater than zero. The default is equal
        /// to `VideoStream.bitrate_bps`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vbvSizeBits")]
        public virtual System.Nullable<int> VbvSizeBits { get; set; }

        /// <summary>
        /// The width of the video in pixels. Must be an even integer. When not specified, the width is adjusted to
        /// match the specified height and input aspect ratio. If both are omitted, the input width is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widthPixels")]
        public virtual System.Nullable<int> WidthPixels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
