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

namespace Google.Apis.CloudTalentSolution.v3p1beta1
{
    /// <summary>The CloudTalentSolution Service.</summary>
    public class CloudTalentSolutionService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v3p1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudTalentSolutionService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudTalentSolutionService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "jobs";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://jobs.googleapis.com/";
        #else
            "https://jobs.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://jobs.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Talent Solution API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Manage job postings</summary>
            public static string Jobs = "https://www.googleapis.com/auth/jobs";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Talent Solution API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Manage job postings</summary>
            public const string Jobs = "https://www.googleapis.com/auth/jobs";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for CloudTalentSolution requests.</summary>
    public abstract class CloudTalentSolutionBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudTalentSolutionBaseServiceRequest instance.</summary>
        protected CloudTalentSolutionBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudTalentSolution parameter list.</summary>
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
            ClientEvents = new ClientEventsResource(service);
            Companies = new CompaniesResource(service);
            Jobs = new JobsResource(service);
            Operations = new OperationsResource(service);
        }

        /// <summary>Gets the ClientEvents resource.</summary>
        public virtual ClientEventsResource ClientEvents { get; }

        /// <summary>The "clientEvents" collection of methods.</summary>
        public class ClientEventsResource
        {
            private const string Resource = "clientEvents";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ClientEventsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Report events issued when end user interacts with customer's application that uses Cloud Talent
            /// Solution. You may inspect the created events in [self service
            /// tools](https://console.cloud.google.com/talent-solution/overview). [Learn
            /// more](https://cloud.google.com/talent-solution/docs/management-tools) about self service tools.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Parent project name.</param>
            public virtual CreateRequest Create(Google.Apis.CloudTalentSolution.v3p1beta1.Data.CreateClientEventRequest body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Report events issued when end user interacts with customer's application that uses Cloud Talent
            /// Solution. You may inspect the created events in [self service
            /// tools](https://console.cloud.google.com/talent-solution/overview). [Learn
            /// more](https://cloud.google.com/talent-solution/docs/management-tools) about self service tools.
            /// </summary>
            public class CreateRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v3p1beta1.Data.ClientEvent>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTalentSolution.v3p1beta1.Data.CreateClientEventRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Parent project name.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudTalentSolution.v3p1beta1.Data.CreateClientEventRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3p1beta1/{+parent}/clientEvents";

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
        }

        /// <summary>Gets the Companies resource.</summary>
        public virtual CompaniesResource Companies { get; }

        /// <summary>The "companies" collection of methods.</summary>
        public class CompaniesResource
        {
            private const string Resource = "companies";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CompaniesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a new company entity.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Resource name of the project under which the company is created. The format is
            /// "projects/{project_id}", for example, "projects/api-test-project".
            /// </param>
            public virtual CreateRequest Create(Google.Apis.CloudTalentSolution.v3p1beta1.Data.CreateCompanyRequest body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a new company entity.</summary>
            public class CreateRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v3p1beta1.Data.Company>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTalentSolution.v3p1beta1.Data.CreateCompanyRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the project under which the company is created. The format is
                /// "projects/{project_id}", for example, "projects/api-test-project".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudTalentSolution.v3p1beta1.Data.CreateCompanyRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3p1beta1/{+parent}/companies";

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

            /// <summary>Deletes specified company. Prerequisite: The company has no jobs associated with it.</summary>
            /// <param name="name">
            /// Required. The resource name of the company to be deleted. The format is
            /// "projects/{project_id}/companies/{company_id}", for example, "projects/api-test-project/companies/foo".
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes specified company. Prerequisite: The company has no jobs associated with it.</summary>
            public class DeleteRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v3p1beta1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the company to be deleted. The format is
                /// "projects/{project_id}/companies/{company_id}", for example,
                /// "projects/api-test-project/companies/foo".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3p1beta1/{+name}";

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
                        Pattern = @"^projects/[^/]+/companies/[^/]+$",
                    });
                }
            }

            /// <summary>Retrieves specified company.</summary>
            /// <param name="name">
            /// Required. The resource name of the company to be retrieved. The format is
            /// "projects/{project_id}/companies/{company_id}", for example, "projects/api-test-project/companies/foo".
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Retrieves specified company.</summary>
            public class GetRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v3p1beta1.Data.Company>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the company to be retrieved. The format is
                /// "projects/{project_id}/companies/{company_id}", for example,
                /// "projects/api-test-project/companies/foo".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3p1beta1/{+name}";

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
                        Pattern = @"^projects/[^/]+/companies/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all companies associated with the service account.</summary>
            /// <param name="parent">
            /// Required. Resource name of the project under which the company is created. The format is
            /// "projects/{project_id}", for example, "projects/api-test-project".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists all companies associated with the service account.</summary>
            public class ListRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v3p1beta1.Data.ListCompaniesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the project under which the company is created. The format is
                /// "projects/{project_id}", for example, "projects/api-test-project".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of companies to be returned, at most 100. Default is 100 if a
                /// non-positive number is provided.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Optional. The starting indicator from which to return results.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Optional. Set to true if the companies requested must have open jobs. Defaults to false. If true, at
                /// most page_size of companies are fetched, among which only those with open jobs are returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("requireOpenJobs", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> RequireOpenJobs { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3p1beta1/{+parent}/companies";

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
                    RequestParameters.Add("requireOpenJobs", new Google.Apis.Discovery.Parameter
                    {
                        Name = "requireOpenJobs",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Updates specified company. Company names can't be updated. To update a company name, delete the company
            /// and all jobs associated with it, and only then re-create them.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required during company update. The resource name for a company. This is generated by the service when a
            /// company is created. The format is "projects/{project_id}/companies/{company_id}", for example,
            /// "projects/api-test-project/companies/foo".
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.CloudTalentSolution.v3p1beta1.Data.UpdateCompanyRequest body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Updates specified company. Company names can't be updated. To update a company name, delete the company
            /// and all jobs associated with it, and only then re-create them.
            /// </summary>
            public class PatchRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v3p1beta1.Data.Company>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTalentSolution.v3p1beta1.Data.UpdateCompanyRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required during company update. The resource name for a company. This is generated by the service
                /// when a company is created. The format is "projects/{project_id}/companies/{company_id}", for
                /// example, "projects/api-test-project/companies/foo".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudTalentSolution.v3p1beta1.Data.UpdateCompanyRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3p1beta1/{+name}";

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
                        Pattern = @"^projects/[^/]+/companies/[^/]+$",
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

            /// <summary>Deletes a list of Jobs by filter.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource name of the project under which the job is created. The format is
            /// "projects/{project_id}", for example, "projects/api-test-project".
            /// </param>
            public virtual BatchDeleteRequest BatchDelete(Google.Apis.CloudTalentSolution.v3p1beta1.Data.BatchDeleteJobsRequest body, string parent)
            {
                return new BatchDeleteRequest(service, body, parent);
            }

            /// <summary>Deletes a list of Jobs by filter.</summary>
            public class BatchDeleteRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v3p1beta1.Data.Empty>
            {
                /// <summary>Constructs a new BatchDelete request.</summary>
                public BatchDeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTalentSolution.v3p1beta1.Data.BatchDeleteJobsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the project under which the job is created. The format is
                /// "projects/{project_id}", for example, "projects/api-test-project".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudTalentSolution.v3p1beta1.Data.BatchDeleteJobsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchDelete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3p1beta1/{+parent}/jobs:batchDelete";

                /// <summary>Initializes BatchDelete parameter list.</summary>
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
            /// Creates a new job. Typically, the job becomes searchable within 10 seconds, but it may take up to 5
            /// minutes.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource name of the project under which the job is created. The format is
            /// "projects/{project_id}", for example, "projects/api-test-project".
            /// </param>
            public virtual CreateRequest Create(Google.Apis.CloudTalentSolution.v3p1beta1.Data.CreateJobRequest body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a new job. Typically, the job becomes searchable within 10 seconds, but it may take up to 5
            /// minutes.
            /// </summary>
            public class CreateRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v3p1beta1.Data.Job>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTalentSolution.v3p1beta1.Data.CreateJobRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the project under which the job is created. The format is
                /// "projects/{project_id}", for example, "projects/api-test-project".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudTalentSolution.v3p1beta1.Data.CreateJobRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3p1beta1/{+parent}/jobs";

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
            /// Deletes the specified job. Typically, the job becomes unsearchable within 10 seconds, but it may take up
            /// to 5 minutes.
            /// </summary>
            /// <param name="name">
            /// Required. The resource name of the job to be deleted. The format is
            /// "projects/{project_id}/jobs/{job_id}", for example, "projects/api-test-project/jobs/1234".
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes the specified job. Typically, the job becomes unsearchable within 10 seconds, but it may take up
            /// to 5 minutes.
            /// </summary>
            public class DeleteRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v3p1beta1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the job to be deleted. The format is
                /// "projects/{project_id}/jobs/{job_id}", for example, "projects/api-test-project/jobs/1234".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3p1beta1/{+name}";

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
                        Pattern = @"^projects/[^/]+/jobs/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Retrieves the specified job, whose status is OPEN or recently EXPIRED within the last 90 days.
            /// </summary>
            /// <param name="name">
            /// Required. The resource name of the job to retrieve. The format is "projects/{project_id}/jobs/{job_id}",
            /// for example, "projects/api-test-project/jobs/1234".
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Retrieves the specified job, whose status is OPEN or recently EXPIRED within the last 90 days.
            /// </summary>
            public class GetRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v3p1beta1.Data.Job>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the job to retrieve. The format is
                /// "projects/{project_id}/jobs/{job_id}", for example, "projects/api-test-project/jobs/1234".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3p1beta1/{+name}";

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

            /// <summary>Lists jobs by filter.</summary>
            /// <param name="parent">
            /// Required. The resource name of the project under which the job is created. The format is
            /// "projects/{project_id}", for example, "projects/api-test-project".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists jobs by filter.</summary>
            public class ListRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v3p1beta1.Data.ListJobsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the project under which the job is created. The format is
                /// "projects/{project_id}", for example, "projects/api-test-project".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. The filter string specifies the jobs to be enumerated. Supported operator: =, AND The
                /// fields eligible for filtering are: * `companyName` (Required) * `requisitionId` (Optional) Sample
                /// Query: * companyName = "projects/api-test-project/companies/123" * companyName =
                /// "projects/api-test-project/companies/123" AND requisitionId = "req-1"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. The desired job attributes returned for jobs in the search response. Defaults to
                /// JobView.JOB_VIEW_FULL if no value is specified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("jobView", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<JobViewEnum> JobView { get; set; }

                /// <summary>
                /// Optional. The desired job attributes returned for jobs in the search response. Defaults to
                /// JobView.JOB_VIEW_FULL if no value is specified.
                /// </summary>
                public enum JobViewEnum
                {
                    /// <summary>Default value.</summary>
                    [Google.Apis.Util.StringValueAttribute("JOB_VIEW_UNSPECIFIED")]
                    JOBVIEWUNSPECIFIED = 0,

                    /// <summary>
                    /// A ID only view of job, with following attributes: Job.name, Job.requisition_id,
                    /// Job.language_code.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("JOB_VIEW_ID_ONLY")]
                    JOBVIEWIDONLY = 1,

                    /// <summary>
                    /// A minimal view of the job, with the following attributes: Job.name, Job.requisition_id,
                    /// Job.title, Job.company_name, Job.DerivedInfo.locations, Job.language_code.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("JOB_VIEW_MINIMAL")]
                    JOBVIEWMINIMAL = 2,

                    /// <summary>
                    /// A small view of the job, with the following attributes in the search results: Job.name,
                    /// Job.requisition_id, Job.title, Job.company_name, Job.DerivedInfo.locations, Job.visibility,
                    /// Job.language_code, Job.description.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("JOB_VIEW_SMALL")]
                    JOBVIEWSMALL = 3,

                    /// <summary>All available attributes are included in the search results.</summary>
                    [Google.Apis.Util.StringValueAttribute("JOB_VIEW_FULL")]
                    JOBVIEWFULL = 4,
                }

                /// <summary>
                /// Optional. The maximum number of jobs to be returned per page of results. If job_view is set to
                /// JobView.JOB_VIEW_ID_ONLY, the maximum allowed page size is 1000. Otherwise, the maximum allowed page
                /// size is 100. Default is 100 if empty or a number &amp;lt; 1 is specified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Optional. The starting point of a query result.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3p1beta1/{+parent}/jobs";

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
                    RequestParameters.Add("jobView", new Google.Apis.Discovery.Parameter
                    {
                        Name = "jobView",
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
            /// Updates specified job. Typically, updated contents become visible in search results within 10 seconds,
            /// but it may take up to 5 minutes.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required during job update. The resource name for the job. This is generated by the service when a job
            /// is created. The format is "projects/{project_id}/jobs/{job_id}", for example,
            /// "projects/api-test-project/jobs/1234". Use of this field in job queries and API calls is preferred over
            /// the use of requisition_id since this value is unique.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.CloudTalentSolution.v3p1beta1.Data.UpdateJobRequest body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Updates specified job. Typically, updated contents become visible in search results within 10 seconds,
            /// but it may take up to 5 minutes.
            /// </summary>
            public class PatchRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v3p1beta1.Data.Job>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTalentSolution.v3p1beta1.Data.UpdateJobRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required during job update. The resource name for the job. This is generated by the service when a
                /// job is created. The format is "projects/{project_id}/jobs/{job_id}", for example,
                /// "projects/api-test-project/jobs/1234". Use of this field in job queries and API calls is preferred
                /// over the use of requisition_id since this value is unique.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudTalentSolution.v3p1beta1.Data.UpdateJobRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3p1beta1/{+name}";

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
                }
            }

            /// <summary>
            /// Searches for jobs using the provided SearchJobsRequest. This call constrains the visibility of jobs
            /// present in the database, and only returns jobs that the caller has permission to search against.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource name of the project to search within. The format is "projects/{project_id}", for
            /// example, "projects/api-test-project".
            /// </param>
            public virtual SearchRequest Search(Google.Apis.CloudTalentSolution.v3p1beta1.Data.SearchJobsRequest body, string parent)
            {
                return new SearchRequest(service, body, parent);
            }

            /// <summary>
            /// Searches for jobs using the provided SearchJobsRequest. This call constrains the visibility of jobs
            /// present in the database, and only returns jobs that the caller has permission to search against.
            /// </summary>
            public class SearchRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v3p1beta1.Data.SearchJobsResponse>
            {
                /// <summary>Constructs a new Search request.</summary>
                public SearchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTalentSolution.v3p1beta1.Data.SearchJobsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the project to search within. The format is "projects/{project_id}",
                /// for example, "projects/api-test-project".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudTalentSolution.v3p1beta1.Data.SearchJobsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "search";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3p1beta1/{+parent}/jobs:search";

                /// <summary>Initializes Search parameter list.</summary>
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
            /// Searches for jobs using the provided SearchJobsRequest. This API call is intended for the use case of
            /// targeting passive job seekers (for example, job seekers who have signed up to receive email alerts about
            /// potential job opportunities), and has different algorithmic adjustments that are targeted to passive job
            /// seekers. This call constrains the visibility of jobs present in the database, and only returns jobs the
            /// caller has permission to search against.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource name of the project to search within. The format is "projects/{project_id}", for
            /// example, "projects/api-test-project".
            /// </param>
            public virtual SearchForAlertRequest SearchForAlert(Google.Apis.CloudTalentSolution.v3p1beta1.Data.SearchJobsRequest body, string parent)
            {
                return new SearchForAlertRequest(service, body, parent);
            }

            /// <summary>
            /// Searches for jobs using the provided SearchJobsRequest. This API call is intended for the use case of
            /// targeting passive job seekers (for example, job seekers who have signed up to receive email alerts about
            /// potential job opportunities), and has different algorithmic adjustments that are targeted to passive job
            /// seekers. This call constrains the visibility of jobs present in the database, and only returns jobs the
            /// caller has permission to search against.
            /// </summary>
            public class SearchForAlertRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v3p1beta1.Data.SearchJobsResponse>
            {
                /// <summary>Constructs a new SearchForAlert request.</summary>
                public SearchForAlertRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTalentSolution.v3p1beta1.Data.SearchJobsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the project to search within. The format is "projects/{project_id}",
                /// for example, "projects/api-test-project".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudTalentSolution.v3p1beta1.Data.SearchJobsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "searchForAlert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3p1beta1/{+parent}/jobs:searchForAlert";

                /// <summary>Initializes SearchForAlert parameter list.</summary>
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
            public class GetRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v3p1beta1.Data.Operation>
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
                public override string RestPath => "v3p1beta1/{+name}";

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
        }

        /// <summary>
        /// Completes the specified prefix with keyword suggestions. Intended for use by a job search auto-complete
        /// search box.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of project the completion is performed within. The format is
        /// "projects/{project_id}", for example, "projects/api-test-project".
        /// </param>
        public virtual CompleteRequest Complete(string name)
        {
            return new CompleteRequest(service, name);
        }

        /// <summary>
        /// Completes the specified prefix with keyword suggestions. Intended for use by a job search auto-complete
        /// search box.
        /// </summary>
        public class CompleteRequest : CloudTalentSolutionBaseServiceRequest<Google.Apis.CloudTalentSolution.v3p1beta1.Data.CompleteQueryResponse>
        {
            /// <summary>Constructs a new Complete request.</summary>
            public CompleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. Resource name of project the completion is performed within. The format is
            /// "projects/{project_id}", for example, "projects/api-test-project".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Optional. If provided, restricts completion to specified company. The format is
            /// "projects/{project_id}/companies/{company_id}", for example, "projects/api-test-project/companies/foo".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("companyName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CompanyName { get; set; }

            /// <summary>
            /// Deprecated. Use language_codes instead. Optional. The language of the query. This is the BCP-47 language
            /// code, such as "en-US" or "sr-Latn". For more information, see [Tags for Identifying
            /// Languages](https://tools.ietf.org/html/bcp47). For CompletionType.JOB_TITLE type, only open jobs with
            /// the same language_code are returned. For CompletionType.COMPANY_NAME type, only companies having open
            /// jobs with the same language_code are returned. For CompletionType.COMBINED type, only open jobs with the
            /// same language_code or companies having open jobs with the same language_code are returned. The maximum
            /// number of allowed characters is 255.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LanguageCode { get; set; }

            /// <summary>
            /// Optional. The list of languages of the query. This is the BCP-47 language code, such as "en-US" or
            /// "sr-Latn". For more information, see [Tags for Identifying
            /// Languages](https://tools.ietf.org/html/bcp47). For CompletionType.JOB_TITLE type, only open jobs with
            /// the same language_codes are returned. For CompletionType.COMPANY_NAME type, only companies having open
            /// jobs with the same language_codes are returned. For CompletionType.COMBINED type, only open jobs with
            /// the same language_codes or companies having open jobs with the same language_codes are returned. The
            /// maximum number of allowed characters is 255.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCodes", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> LanguageCodes { get; set; }

            /// <summary>Required. Completion result count. The maximum allowed page size is 10.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Required. The query used to generate suggestions. The maximum number of allowed characters is 255.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>Optional. The scope of the completion. The defaults is CompletionScope.PUBLIC.</summary>
            [Google.Apis.Util.RequestParameterAttribute("scope", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ScopeEnum> Scope { get; set; }

            /// <summary>Optional. The scope of the completion. The defaults is CompletionScope.PUBLIC.</summary>
            public enum ScopeEnum
            {
                /// <summary>Default value.</summary>
                [Google.Apis.Util.StringValueAttribute("COMPLETION_SCOPE_UNSPECIFIED")]
                COMPLETIONSCOPEUNSPECIFIED = 0,

                /// <summary>Suggestions are based only on the data provided by the client.</summary>
                [Google.Apis.Util.StringValueAttribute("TENANT")]
                TENANT = 1,

                /// <summary>Suggestions are based on all jobs data in the system that's visible to the client</summary>
                [Google.Apis.Util.StringValueAttribute("PUBLIC")]
                PUBLIC__ = 2,
            }

            /// <summary>Optional. The completion topic. The default is CompletionType.COMBINED.</summary>
            [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<TypeEnum> Type { get; set; }

            /// <summary>Optional. The completion topic. The default is CompletionType.COMBINED.</summary>
            public enum TypeEnum
            {
                /// <summary>Default value.</summary>
                [Google.Apis.Util.StringValueAttribute("COMPLETION_TYPE_UNSPECIFIED")]
                COMPLETIONTYPEUNSPECIFIED = 0,

                /// <summary>Only suggest job titles.</summary>
                [Google.Apis.Util.StringValueAttribute("JOB_TITLE")]
                JOBTITLE = 1,

                /// <summary>Only suggest company names.</summary>
                [Google.Apis.Util.StringValueAttribute("COMPANY_NAME")]
                COMPANYNAME = 2,

                /// <summary>Suggest both job titles and company names.</summary>
                [Google.Apis.Util.StringValueAttribute("COMBINED")]
                COMBINED = 3,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "complete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3p1beta1/{+name}:complete";

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
                    Pattern = @"^projects/[^/]+$",
                });
                RequestParameters.Add("companyName", new Google.Apis.Discovery.Parameter
                {
                    Name = "companyName",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "languageCode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("languageCodes", new Google.Apis.Discovery.Parameter
                {
                    Name = "languageCodes",
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
                RequestParameters.Add("query", new Google.Apis.Discovery.Parameter
                {
                    Name = "query",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("scope", new Google.Apis.Discovery.Parameter
                {
                    Name = "scope",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("type", new Google.Apis.Discovery.Parameter
                {
                    Name = "type",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.CloudTalentSolution.v3p1beta1.Data
{
    /// <summary>Application related details of a job posting.</summary>
    public class ApplicationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional but at least one of uris, emails or instruction must be specified. Use this field to specify email
        /// address(es) to which resumes or applications can be sent. The maximum number of allowed characters for each
        /// entry is 255.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emails")]
        public virtual System.Collections.Generic.IList<string> Emails { get; set; }

        /// <summary>
        /// Optional but at least one of uris, emails or instruction must be specified. Use this field to provide
        /// instructions, such as "Mail your application to ...", that a candidate can follow to apply for the job. This
        /// field accepts and sanitizes HTML input, and also accepts bold, italic, ordered list, and unordered list
        /// markup tags. The maximum number of allowed characters is 3,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instruction")]
        public virtual string Instruction { get; set; }

        /// <summary>
        /// Optional but at least one of uris, emails or instruction must be specified. Use this URI field to direct an
        /// applicant to a website, for example to link to an online application form. The maximum number of allowed
        /// characters for each entry is 2,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uris")]
        public virtual System.Collections.Generic.IList<string> Uris { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Input only. Batch delete jobs request.</summary>
    public class BatchDeleteJobsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The filter string specifies the jobs to be deleted. Supported operator: =, AND The fields eligible
        /// for filtering are: * `companyName` (Required) * `requisitionId` (Required) Sample Query: companyName =
        /// "projects/api-test-project/companies/123" AND requisitionId = "req-1"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents starting and ending value of a range in double.</summary>
    public class BucketRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Starting value of the bucket range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("from")]
        public virtual System.Nullable<double> From { get; set; }

        /// <summary>Ending value of the bucket range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("to")]
        public virtual System.Nullable<double> To { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents count of jobs within one bucket.</summary>
    public class BucketizedCount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of jobs whose numeric field value fall into `range`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<int> Count { get; set; }

        /// <summary>
        /// Bucket range on which histogram was performed for the numeric field, that is, the count represents number of
        /// jobs in this range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual BucketRange Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An event issued when an end user interacts with the application that implements Cloud Talent Solution. Providing
    /// this information improves the quality of search and recommendation for the API clients, enabling the service to
    /// perform optimally. The number of events sent must be consistent with other calls, such as job searches, issued
    /// to the service by the client.
    /// </summary>
    public class ClientEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The timestamp of the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Required. A unique identifier, generated by the client application. This `event_id` is used to establish the
        /// relationship between different events (see parent_event_id).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>
        /// Optional. Extra information about this event. Used for storing information with no matching field in event
        /// payload, for example, user application specific context or details. At most 20 keys are supported. The
        /// maximum total size of all keys and values is 2 KB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extraInfo")]
        public virtual System.Collections.Generic.IDictionary<string, string> ExtraInfo { get; set; }

        /// <summary>
        /// A event issued when a job seeker interacts with the application that implements Cloud Talent Solution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobEvent")]
        public virtual JobEvent JobEvent { get; set; }

        /// <summary>
        /// Optional. The event_id of an event that resulted in the current event. For example, a Job view event usually
        /// follows a parent impression event: A job seeker first does a search where a list of jobs appears
        /// (impression). The job seeker then selects a result and views the description of a particular job (Job view).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentEventId")]
        public virtual string ParentEventId { get; set; }

        /// <summary>
        /// Required. A unique ID generated in the API responses. It can be found in ResponseMetadata.request_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Input only. Parameters needed for commute search.</summary>
    public class CommuteFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If true, jobs without "precise" addresses (street level addresses or GPS coordinates) might also
        /// be returned. For city and coarser level addresses, text matching is used. If this field is set to false or
        /// is not specified, only jobs that include precise addresses are returned by Commute Search. Note: If
        /// `allow_imprecise_addresses` is set to true, Commute Search is not able to calculate accurate commute times
        /// to jobs with city level and coarser address information. Jobs with imprecise addresses will return a
        /// `travel_duration` time of 0 regardless of distance from the job seeker.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowImpreciseAddresses")]
        public virtual System.Nullable<bool> AllowImpreciseAddresses { get; set; }

        /// <summary>Required. The method of transportation for which to calculate the commute time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commuteMethod")]
        public virtual string CommuteMethod { get; set; }

        /// <summary>
        /// Optional. The departure time used to calculate traffic impact, represented as google.type.TimeOfDay in local
        /// time zone. Currently traffic model is restricted to hour level resolution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("departureTime")]
        public virtual TimeOfDay DepartureTime { get; set; }

        /// <summary>Optional. Specifies the traffic density to use when calculating commute time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roadTraffic")]
        public virtual string RoadTraffic { get; set; }

        /// <summary>
        /// Required. The latitude and longitude of the location from which to calculate the commute time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startCoordinates")]
        public virtual LatLng StartCoordinates { get; set; }

        /// <summary>
        /// Required. The maximum travel time in seconds. The maximum allowed value is `3600s` (one hour). Format is
        /// `123s`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("travelDuration")]
        public virtual object TravelDuration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output only. Commute details related to this job.</summary>
    public class CommuteInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Location used as the destination in the commute calculation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobLocation")]
        public virtual Location JobLocation { get; set; }

        /// <summary>
        /// The number of seconds required to travel to the job location from the query location. A duration of 0
        /// seconds indicates that the job is not reachable within the requested duration, but was returned as part of
        /// an expanded query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("travelDuration")]
        public virtual object TravelDuration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Company resource represents a company in the service. A company is the entity that owns job postings, that is,
    /// the hiring entity responsible for employing applicants for the job position.
    /// </summary>
    public class Company : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The URI to employer's career site or careers page on the employer's web site, for example,
        /// "https://careers.google.com".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("careerSiteUri")]
        public virtual string CareerSiteUri { get; set; }

        /// <summary>Output only. Derived details about the company.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("derivedInfo")]
        public virtual CompanyDerivedInfo DerivedInfo { get; set; }

        /// <summary>Required. The display name of the company, for example, "Google LLC".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Optional. Equal Employment Opportunity legal disclaimer text to be associated with all jobs, and typically
        /// to be displayed in all roles. The maximum number of allowed characters is 500.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eeoText")]
        public virtual string EeoText { get; set; }

        /// <summary>
        /// Required. Client side company identifier, used to uniquely identify the company. The maximum number of
        /// allowed characters is 255.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalId")]
        public virtual string ExternalId { get; set; }

        /// <summary>
        /// Optional. The street address of the company's main headquarters, which may be different from the job
        /// location. The service attempts to geolocate the provided address, and populates a more specific location
        /// wherever possible in DerivedInfo.headquarters_location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headquartersAddress")]
        public virtual string HeadquartersAddress { get; set; }

        /// <summary>
        /// Optional. Set to true if it is the hiring agency that post jobs for other employers. Defaults to false if
        /// not provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hiringAgency")]
        public virtual System.Nullable<bool> HiringAgency { get; set; }

        /// <summary>Optional. A URI that hosts the employer's company logo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; }

        /// <summary>
        /// Optional. A list of keys of filterable Job.custom_attributes, whose corresponding `string_values` are used
        /// in keyword search. Jobs with `string_values` under these specified field keys are returned if any of the
        /// values matches the search keyword. Custom field values with parenthesis, brackets and special symbols won't
        /// be properly searchable, and those keyword queries need to be surrounded by quotes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keywordSearchableJobCustomAttributes")]
        public virtual System.Collections.Generic.IList<string> KeywordSearchableJobCustomAttributes { get; set; }

        /// <summary>
        /// Required during company update. The resource name for a company. This is generated by the service when a
        /// company is created. The format is "projects/{project_id}/companies/{company_id}", for example,
        /// "projects/api-test-project/companies/foo".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. The employer's company size.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual string Size { get; set; }

        /// <summary>
        /// Output only. Indicates whether a company is flagged to be suspended from public availability by the service
        /// when job content appears suspicious, abusive, or spammy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspended")]
        public virtual System.Nullable<bool> Suspended { get; set; }

        /// <summary>
        /// Optional. The URI representing the company's primary web site or home page, for example,
        /// "https://www.google.com". The maximum number of allowed characters is 255.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("websiteUri")]
        public virtual string WebsiteUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Derived details about the company.</summary>
    public class CompanyDerivedInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A structured headquarters location of the company, resolved from Company.hq_location if provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headquartersLocation")]
        public virtual Location HeadquartersLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A compensation entry that represents one component of compensation, such as base pay, bonus, or other
    /// compensation type. Annualization: One compensation entry can be annualized if - it contains valid amount or
    /// range. - and its expected_units_per_year is set or can be derived. Its annualized range is determined as (amount
    /// or range) times expected_units_per_year.
    /// </summary>
    public class CompensationEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Compensation amount.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amount")]
        public virtual Money Amount { get; set; }

        /// <summary>
        /// Optional. Compensation description. For example, could indicate equity terms or provide additional context
        /// to an estimated bonus.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Expected number of units paid each year. If not specified, when Job.employment_types is FULLTIME,
        /// a default value is inferred based on unit. Default values: - HOURLY: 2080 - DAILY: 260 - WEEKLY: 52 -
        /// MONTHLY: 12 - ANNUAL: 1
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedUnitsPerYear")]
        public virtual System.Nullable<double> ExpectedUnitsPerYear { get; set; }

        /// <summary>Optional. Compensation range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual CompensationRange Range { get; set; }

        /// <summary>Optional. Compensation type. Default is CompensationUnit.COMPENSATION_TYPE_UNSPECIFIED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// Optional. Frequency of the specified amount. Default is CompensationUnit.COMPENSATION_UNIT_UNSPECIFIED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Input only. Filter on job compensation type and amount.</summary>
    public class CompensationFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If set to true, jobs with unspecified compensation range fields are included.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeJobsWithUnspecifiedCompensationRange")]
        public virtual System.Nullable<bool> IncludeJobsWithUnspecifiedCompensationRange { get; set; }

        /// <summary>Optional. Compensation range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual CompensationRange Range { get; set; }

        /// <summary>Required. Type of filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Required. Specify desired `base compensation entry's` CompensationInfo.CompensationUnit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("units")]
        public virtual System.Collections.Generic.IList<string> Units { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Input only. Compensation based histogram request.</summary>
    public class CompensationHistogramRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Numeric histogram options, like buckets, whether include min or max value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketingOption")]
        public virtual NumericBucketingOption BucketingOption { get; set; }

        /// <summary>
        /// Required. Type of the request, representing which field the histogramming should be performed over. A single
        /// request can only specify one histogram of each `CompensationHistogramRequestType`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output only. Compensation based histogram result.</summary>
    public class CompensationHistogramResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Histogram result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual NumericBucketingResult Result { get; set; }

        /// <summary>Type of the request, corresponding to CompensationHistogramRequest.type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Job compensation details.</summary>
    public class CompensationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Annualized base compensation range. Computed as base compensation entry's
        /// CompensationEntry.compensation times CompensationEntry.expected_units_per_year. See CompensationEntry for
        /// explanation on compensation annualization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annualizedBaseCompensationRange")]
        public virtual CompensationRange AnnualizedBaseCompensationRange { get; set; }

        /// <summary>
        /// Output only. Annualized total compensation range. Computed as all compensation entries'
        /// CompensationEntry.compensation times CompensationEntry.expected_units_per_year. See CompensationEntry for
        /// explanation on compensation annualization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annualizedTotalCompensationRange")]
        public virtual CompensationRange AnnualizedTotalCompensationRange { get; set; }

        /// <summary>
        /// Optional. Job compensation information. At most one entry can be of type
        /// CompensationInfo.CompensationType.BASE, which is referred as ** base compensation entry ** for the job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<CompensationEntry> Entries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Compensation range.</summary>
    public class CompensationRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The maximum amount of compensation. If left empty, the value is set to a maximal compensation
        /// value and the currency code is set to match the currency code of min_compensation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxCompensation")]
        public virtual Money MaxCompensation { get; set; }

        /// <summary>
        /// Optional. The minimum amount of compensation. If left empty, the value is set to zero and the currency code
        /// is set to match the currency code of max_compensation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minCompensation")]
        public virtual Money MinCompensation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output only. Response of auto-complete query.</summary>
    public class CompleteQueryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Results of the matching job/company candidates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionResults")]
        public virtual System.Collections.Generic.IList<CompletionResult> CompletionResults { get; set; }

        /// <summary>Additional information for the API invocation, such as the request tracking id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ResponseMetadata Metadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output only. Resource that represents completion results.</summary>
    public class CompletionResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URI of the company image for CompletionType.COMPANY_NAME.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; }

        /// <summary>The suggestion for the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestion")]
        public virtual string Suggestion { get; set; }

        /// <summary>The completion topic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The report event request.</summary>
    public class CreateClientEventRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Events issued when end user interacts with customer's application that uses Cloud Talent Solution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientEvent")]
        public virtual ClientEvent ClientEvent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Input only. The Request of the CreateCompany method.</summary>
    public class CreateCompanyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The company to be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("company")]
        public virtual Company Company { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Input only. Create job request.</summary>
    public class CreateJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Job to be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("job")]
        public virtual Job Job { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Custom attribute values that are either filterable or non-filterable.</summary>
    public class CustomAttribute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If the `filterable` flag is true, the custom field values may be used for custom attribute filters
        /// JobQuery.custom_attribute_filter. If false, these values may not be used for custom attribute filters.
        /// Default is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterable")]
        public virtual System.Nullable<bool> Filterable { get; set; }

        /// <summary>
        /// Optional but exactly one of string_values or long_values must be specified. This field is used to perform
        /// number range search. (`EQ`, `GT`, `GE`, `LE`, `LT`) over filterable `long_value`. Currently at most 1
        /// long_values is supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longValues")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> LongValues { get; set; }

        /// <summary>
        /// Optional but exactly one of string_values or long_values must be specified. This field is used to perform a
        /// string match (`CASE_SENSITIVE_MATCH` or `CASE_INSENSITIVE_MATCH`) search. For filterable `string_value`s, a
        /// maximum total number of 200 values is allowed, with each `string_value` has a byte size of no more than
        /// 500B. For unfilterable `string_values`, the maximum total byte size of unfilterable `string_values` is 50KB.
        /// Empty string is not allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValues")]
        public virtual System.Collections.Generic.IList<string> StringValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Custom attributes histogram request. An error is thrown if neither string_value_histogram or
    /// long_value_histogram_bucketing_option has been defined.
    /// </summary>
    public class CustomAttributeHistogramRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Specifies the custom field key to perform a histogram on. If specified without
        /// `long_value_histogram_bucketing_option`, histogram on string values of the given `key` is triggered,
        /// otherwise histogram is performed on long values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// Optional. Specifies buckets used to perform a range histogram on Job's filterable long custom field values,
        /// or min/max value requirements.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longValueHistogramBucketingOption")]
        public virtual NumericBucketingOption LongValueHistogramBucketingOption { get; set; }

        /// <summary>
        /// Optional. If set to true, the response includes the histogram value for each key as a string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValueHistogram")]
        public virtual System.Nullable<bool> StringValueHistogram { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output only. Custom attribute histogram result.</summary>
    public class CustomAttributeHistogramResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Stores the key of custom attribute the histogram is performed on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// Stores bucketed histogram counting result or min/max values for custom attribute long values associated with
        /// `key`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longValueHistogramResult")]
        public virtual NumericBucketingResult LongValueHistogramResult { get; set; }

        /// <summary>
        /// Stores a map from the values of string custom field associated with `key` to the number of jobs with that
        /// value in this histogram result.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValueHistogramResult")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<int>> StringValueHistogramResult { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Input only. Custom ranking information for SearchJobsRequest.</summary>
    public class CustomRankingInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Controls over how important the score of CustomRankingInfo.ranking_expression gets applied to
        /// job's final ranking position. An error is thrown if not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importanceLevel")]
        public virtual string ImportanceLevel { get; set; }

        /// <summary>
        /// Required. Controls over how job documents get ranked on top of existing relevance score (determined by API
        /// algorithm). A combination of the ranking expression and relevance score is used to determine job's final
        /// ranking position. The syntax for this expression is a subset of Google SQL syntax. Supported operators are:
        /// +, -, *, /, where the left and right side of the operator is either a numeric Job.custom_attributes key,
        /// integer/double value or an expression that can be evaluated to a number. Parenthesis are supported to adjust
        /// calculation precedence. The expression must be &amp;lt; 100 characters in length. The expression is
        /// considered invalid for a job if the expression references custom attributes that are not populated on the
        /// job or if the expression results in a divide by zero. If an expression is invalid for a job, that job is
        /// demoted to the end of the results. Sample ranking expression (year + 25) * 0.25 - (freshness / 0.5)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rankingExpression")]
        public virtual string RankingExpression { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Device information collected from the job seeker, candidate, or other entity conducting the job search.
    /// Providing this information improves the quality of the search results across devices.
    /// </summary>
    public class DeviceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Type of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceType")]
        public virtual string DeviceType { get; set; }

        /// <summary>
        /// Optional. A device-specific ID. The ID must be a unique identifier that distinguishes the device from other
        /// devices.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

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

    /// <summary>Input only. Histogram facets to be specified in SearchJobsRequest.</summary>
    public class HistogramFacets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specifies compensation field-based histogram requests. Duplicate values of
        /// CompensationHistogramRequest.type are not allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compensationHistogramFacets")]
        public virtual System.Collections.Generic.IList<CompensationHistogramRequest> CompensationHistogramFacets { get; set; }

        /// <summary>
        /// Optional. Specifies the custom attributes histogram requests. Duplicate values of
        /// CustomAttributeHistogramRequest.key are not allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customAttributeHistogramFacets")]
        public virtual System.Collections.Generic.IList<CustomAttributeHistogramRequest> CustomAttributeHistogramFacets { get; set; }

        /// <summary>
        /// Optional. Specifies the simple type of histogram facets, for example, `COMPANY_SIZE`, `EMPLOYMENT_TYPE` etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("simpleHistogramFacets")]
        public virtual System.Collections.Generic.IList<string> SimpleHistogramFacets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Input Only. The histogram request.</summary>
    public class HistogramQuery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An expression specifies a histogram request against matching resources (for example, jobs) for searches.
        /// Expression syntax is a aggregation function call with histogram facets and other options. Available
        /// aggregation function calls are: * `count(string_histogram_facet)`: Count the number of matching entity, for
        /// each distinct attribute value. * `count(numeric_histogram_facet, list of buckets)`: Count the number of
        /// matching entity within each bucket. Data types: * Histogram facet: facet names with format a-zA-Z+. *
        /// String: string like "any string with backslash escape for quote(\")." * Number: whole number and floating
        /// point number like 10, -1 and -0.01. * List: list of elements with comma(,) separator surrounded by square
        /// brackets. For example, [1, 2, 3] and ["one", "two", "three"]. Built-in constants: * MIN (minimum number
        /// similar to java Double.MIN_VALUE) * MAX (maximum number similar to java Double.MAX_VALUE) Built-in
        /// functions: * bucket(start, end[, label]): bucket built-in function creates a bucket with range of start,
        /// end). Note that the end is exclusive. For example, bucket(1, MAX, "positive number") or bucket(1, 10). Job
        /// histogram facets: * company_id: histogram by [Job.distributor_company_id. * company_display_name: histogram
        /// by Job.company_display_name. * employment_type: histogram by Job.employment_types. For example, "FULL_TIME",
        /// "PART_TIME". * company_size: histogram by CompanySize, for example, "SMALL", "MEDIUM", "BIG". *
        /// publish_time_in_day: histogram by the Job.publish_time in days. Must specify list of numeric buckets in
        /// spec. * publish_time_in_month: histogram by the Job.publish_time in months. Must specify list of numeric
        /// buckets in spec. * publish_time_in_year: histogram by the Job.publish_time in years. Must specify list of
        /// numeric buckets in spec. * degree_type: histogram by the Job.degree_type. For example, "Bachelors",
        /// "Masters". * job_level: histogram by the Job.job_level. For example, "Entry Level". * country: histogram by
        /// the country code of jobs. For example, "US", "FR". * admin1: histogram by the admin1 code of jobs, which is
        /// a global placeholder referring to the state, province, or the particular term a country uses to define the
        /// geographic structure below the country level. For example, "CA", "IL". * city: histogram by a combination of
        /// the "city name, admin1 code". For example, "Mountain View, CA", "New York, NY". * admin1_country: histogram
        /// by a combination of the "admin1 code, country". For example, "CA, US", "IL, US". * city_coordinate:
        /// histogram by the city center's GPS coordinates (latitude and longitude). For example,
        /// 37.4038522,-122.0987765. Since the coordinates of a city center can change, customers may need to refresh
        /// them periodically. * locale: histogram by the Job.language_code. For example, "en-US", "fr-FR". * language:
        /// histogram by the language subtag of the Job.language_code. For example, "en", "fr". * category: histogram by
        /// the JobCategory. For example, "COMPUTER_AND_IT", "HEALTHCARE". * base_compensation_unit: histogram by the
        /// CompensationUnit of base salary. For example, "WEEKLY", "MONTHLY". * base_compensation: histogram by the
        /// base salary. Must specify list of numeric buckets to group results by. * annualized_base_compensation:
        /// histogram by the base annualized salary. Must specify list of numeric buckets to group results by. *
        /// annualized_total_compensation: histogram by the total annualized salary. Must specify list of numeric
        /// buckets to group results by. * string_custom_attribute: histogram by string Job.custom_attributes. Values
        /// can be accessed via square bracket notations like string_custom_attribute["key1"]. *
        /// numeric_custom_attribute: histogram by numeric Job.custom_attributes. Values can be accessed via square
        /// bracket notations like numeric_custom_attribute["key1"]. Must specify list of numeric buckets to group
        /// results by. Example expressions: * count(admin1) * count(base_compensation, [bucket(1000, 10000),
        /// bucket(10000, 100000), bucket(100000, MAX)]) *
        /// count(string_custom_attribute["some-string-custom-attribute"]) *
        /// count(numeric_custom_attribute["some-numeric-custom-attribute"], [bucket(MIN, 0, "negative"), bucket(0, MAX,
        /// "non-negative")])
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("histogramQuery")]
        public virtual string HistogramQueryValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output only. Histogram result that matches HistogramSpec specified in searches.</summary>
    public class HistogramQueryResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A map from the values of the facet associated with distinct values to the number of matching entries with
        /// corresponding value. The key format is: * (for string histogram) string values stored in the field. * (for
        /// named numeric bucket) name specified in `bucket()` function, like for `bucket(0, MAX, "non-negative")`, the
        /// key will be `non-negative`. * (for anonymous numeric bucket) range formatted as `-`, for example, `0-1000`,
        /// `MIN-0`, and `0-MAX`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("histogram")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<long>> Histogram { get; set; }

        /// <summary>Requested histogram expression.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("histogramQuery")]
        public virtual string HistogramQuery { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Output only. Result of a histogram call. The response contains the histogram map for the search type specified
    /// by HistogramResult.field. The response is a map of each filter value to the corresponding count of jobs for that
    /// filter.
    /// </summary>
    public class HistogramResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Histogram search filters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchType")]
        public virtual string SearchType { get; set; }

        /// <summary>
        /// A map from the values of field to the number of jobs with that value in this search result. Key: search type
        /// (filter names, such as the companyName). Values: the count of jobs that match the filter for this search.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<int>> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output only. Histogram results that match HistogramFacets specified in SearchJobsRequest.</summary>
    public class HistogramResults : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies compensation field-based histogram results that match
        /// HistogramFacets.compensation_histogram_requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compensationHistogramResults")]
        public virtual System.Collections.Generic.IList<CompensationHistogramResult> CompensationHistogramResults { get; set; }

        /// <summary>
        /// Specifies histogram results for custom attributes that match
        /// HistogramFacets.custom_attribute_histogram_facets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customAttributeHistogramResults")]
        public virtual System.Collections.Generic.IList<CustomAttributeHistogramResult> CustomAttributeHistogramResults { get; set; }

        /// <summary>Specifies histogram results that matches HistogramFacets.simple_histogram_facets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("simpleHistogramResults")]
        public virtual System.Collections.Generic.IList<HistogramResult> SimpleHistogramResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Job resource represents a job posting (also referred to as a "job listing" or "job requisition"). A job
    /// belongs to a Company, which is the hiring entity responsible for the job.
    /// </summary>
    public class Job : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional but strongly recommended for the best service experience. Location(s) where the employer is looking
        /// to hire for this job posting. Specifying the full street address(es) of the hiring location enables better
        /// API results, especially job searches by commute time. At most 50 locations are allowed for best search
        /// performance. If a job has more locations, it is suggested to split it into multiple jobs with unique
        /// requisition_ids (e.g. 'ReqA' becomes 'ReqA-1', 'ReqA-2', etc.) as multiple jobs with the same company_name,
        /// language_code and requisition_id are not allowed. If the original requisition_id must be preserved, a custom
        /// field should be used for storage. It is also suggested to group the locations that close to each other in
        /// the same job for better search experience. Jobs with multiple addresses must have their addresses with the
        /// same LocationType to allow location filtering to work properly. (For example, a Job with addresses "1600
        /// Amphitheatre Parkway, Mountain View, CA, USA" and "London, UK" may not have location filters applied
        /// correctly at search time since the first is a LocationType.STREET_ADDRESS and the second is a
        /// LocationType.LOCALITY.) If a job needs to have multiple addresses, it is suggested to split it into multiple
        /// jobs with same LocationTypes. The maximum number of allowed characters is 500.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addresses")]
        public virtual System.Collections.Generic.IList<string> Addresses { get; set; }

        /// <summary>
        /// Required. At least one field within ApplicationInfo must be specified. Job application information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationInfo")]
        public virtual ApplicationInfo ApplicationInfo { get; set; }

        /// <summary>Output only. Display name of the company listing the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("companyDisplayName")]
        public virtual string CompanyDisplayName { get; set; }

        /// <summary>
        /// Required. The resource name of the company listing the job, such as
        /// "projects/api-test-project/companies/foo".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("companyName")]
        public virtual string CompanyName { get; set; }

        /// <summary>Optional. Job compensation information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compensationInfo")]
        public virtual CompensationInfo CompensationInfo { get; set; }

        /// <summary>
        /// Optional. A map of fields to hold both filterable and non-filterable custom job attributes that are not
        /// covered by the provided structured fields. The keys of the map are strings up to 64 bytes and must match the
        /// pattern: a-zA-Z*. For example, key0LikeThis or KEY_1_LIKE_THIS. At most 100 filterable and at most 100
        /// unfilterable keys are supported. For filterable `string_values`, across all keys at most 200 values are
        /// allowed, with each string no more than 255 characters. For unfilterable `string_values`, the maximum total
        /// size of `string_values` across all keys is 50KB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customAttributes")]
        public virtual System.Collections.Generic.IDictionary<string, CustomAttribute> CustomAttributes { get; set; }

        /// <summary>Optional. The desired education degrees for the job, such as Bachelors, Masters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("degreeTypes")]
        public virtual System.Collections.Generic.IList<string> DegreeTypes { get; set; }

        /// <summary>
        /// Optional. The department or functional area within the company with the open position. The maximum number of
        /// allowed characters is 255.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("department")]
        public virtual string Department { get; set; }

        /// <summary>Output only. Derived details about the job posting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("derivedInfo")]
        public virtual JobDerivedInfo DerivedInfo { get; set; }

        /// <summary>
        /// Required. The description of the job, which typically includes a multi-paragraph description of the company
        /// and related information. Separate fields are provided on the job object for responsibilities,
        /// qualifications, and other job characteristics. Use of these separate job fields is recommended. This field
        /// accepts and sanitizes HTML input, and also accepts bold, italic, ordered list, and unordered list markup
        /// tags. The maximum number of allowed characters is 100,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. The employment type(s) of a job, for example, full time or part time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("employmentTypes")]
        public virtual System.Collections.Generic.IList<string> EmploymentTypes { get; set; }

        /// <summary>
        /// Optional. A description of bonus, commission, and other compensation incentives associated with the job not
        /// including salary or pay. The maximum number of allowed characters is 10,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("incentives")]
        public virtual string Incentives { get; set; }

        /// <summary>Optional. The benefits included with the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobBenefits")]
        public virtual System.Collections.Generic.IList<string> JobBenefits { get; set; }

        /// <summary>
        /// Optional. The end timestamp of the job. Typically this field is used for contracting engagements. Invalid
        /// timestamps are ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobEndTime")]
        public virtual object JobEndTime { get; set; }

        /// <summary>Optional. The experience level associated with the job, such as "Entry Level".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobLevel")]
        public virtual string JobLevel { get; set; }

        /// <summary>
        /// Optional. The start timestamp of the job in UTC time zone. Typically this field is used for contracting
        /// engagements. Invalid timestamps are ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobStartTime")]
        public virtual object JobStartTime { get; set; }

        /// <summary>
        /// Optional. The language of the posting. This field is distinct from any requirements for fluency that are
        /// associated with the job. Language codes must be in BCP-47 format, such as "en-US" or "sr-Latn". For more
        /// information, see [Tags for Identifying Languages](https://tools.ietf.org/html/bcp47){: class="external"
        /// target="_blank" }. If this field is unspecified and Job.description is present, detected language code based
        /// on Job.description is assigned, otherwise defaults to 'en_US'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Required during job update. The resource name for the job. This is generated by the service when a job is
        /// created. The format is "projects/{project_id}/jobs/{job_id}", for example,
        /// "projects/api-test-project/jobs/1234". Use of this field in job queries and API calls is preferred over the
        /// use of requisition_id since this value is unique.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The timestamp when this job posting was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postingCreateTime")]
        public virtual object PostingCreateTime { get; set; }

        /// <summary>
        /// Optional but strongly recommended for the best service experience. The expiration timestamp of the job.
        /// After this timestamp, the job is marked as expired, and it no longer appears in search results. The expired
        /// job can't be deleted or listed by the DeleteJob and ListJobs APIs, but it can be retrieved with the GetJob
        /// API or updated with the UpdateJob API. An expired job can be updated and opened again by using a future
        /// expiration timestamp. Updating an expired job fails if there is another existing open job with same
        /// company_name, language_code and requisition_id. The expired jobs are retained in our system for 90 days.
        /// However, the overall expired job count cannot exceed 3 times the maximum of open jobs count over the past
        /// week, otherwise jobs with earlier expire time are cleaned first. Expired jobs are no longer accessible after
        /// they are cleaned out. Invalid timestamps are ignored, and treated as expire time not provided. Timestamp
        /// before the instant request is made is considered valid, the job will be treated as expired immediately. If
        /// this value is not provided at the time of job creation or is invalid, the job posting expires after 30 days
        /// from the job's creation time. For example, if the job was created on 2017/01/01 13:00AM UTC with an
        /// unspecified expiration date, the job expires after 2017/01/31 13:00AM UTC. If this value is not provided on
        /// job update, it depends on the field masks set by UpdateJobRequest.update_mask. If the field masks include
        /// expiry_time, or the masks are empty meaning that every field is updated, the job posting expires after 30
        /// days from the job's last update time. Otherwise the expiration date isn't updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postingExpireTime")]
        public virtual object PostingExpireTime { get; set; }

        /// <summary>
        /// Optional. The timestamp this job posting was most recently published. The default value is the time the
        /// request arrives at the server. Invalid timestamps are ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postingPublishTime")]
        public virtual object PostingPublishTime { get; set; }

        /// <summary>
        /// Optional. The job PostingRegion (for example, state, country) throughout which the job is available. If this
        /// field is set, a LocationFilter in a search query within the job region finds this job posting if an exact
        /// location match isn't specified. If this field is set to PostingRegion.NATION or
        /// PostingRegion.ADMINISTRATIVE_AREA, setting job Job.addresses to the same location level as this field is
        /// strongly recommended.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postingRegion")]
        public virtual string PostingRegion { get; set; }

        /// <summary>Output only. The timestamp when this job posting was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postingUpdateTime")]
        public virtual object PostingUpdateTime { get; set; }

        /// <summary>Optional. Options for job processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processingOptions")]
        public virtual ProcessingOptions ProcessingOptions { get; set; }

        /// <summary>
        /// Optional. A promotion value of the job, as determined by the client. The value determines the sort order of
        /// the jobs returned when searching for jobs using the featured jobs search call, with higher promotional
        /// values being returned first and ties being resolved by relevance sort. Only the jobs with a promotionValue
        /// &amp;gt;0 are returned in a FEATURED_JOB_SEARCH. Default value is 0, and negative values are treated as 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotionValue")]
        public virtual System.Nullable<int> PromotionValue { get; set; }

        /// <summary>
        /// Optional. A description of the qualifications required to perform the job. The use of this field is
        /// recommended as an alternative to using the more general description field. This field accepts and sanitizes
        /// HTML input, and also accepts bold, italic, ordered list, and unordered list markup tags. The maximum number
        /// of allowed characters is 10,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("qualifications")]
        public virtual string Qualifications { get; set; }

        /// <summary>
        /// Required. The requisition ID, also referred to as the posting ID, assigned by the client to identify a job.
        /// This field is intended to be used by clients for client identification and tracking of postings. A job is
        /// not allowed to be created if there is another job with the same [company_name], language_code and
        /// requisition_id. The maximum number of allowed characters is 255.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requisitionId")]
        public virtual string RequisitionId { get; set; }

        /// <summary>
        /// Optional. A description of job responsibilities. The use of this field is recommended as an alternative to
        /// using the more general description field. This field accepts and sanitizes HTML input, and also accepts
        /// bold, italic, ordered list, and unordered list markup tags. The maximum number of allowed characters is
        /// 10,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responsibilities")]
        public virtual string Responsibilities { get; set; }

        /// <summary>
        /// Required. The title of the job, such as "Software Engineer" The maximum number of allowed characters is 500.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// Deprecated. The job is only visible to the owner. The visibility of the job. Defaults to
        /// Visibility.ACCOUNT_ONLY if not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visibility")]
        public virtual string Visibility { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output only. Derived details about the job posting.</summary>
    public class JobDerivedInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Job categories derived from Job.title and Job.description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobCategories")]
        public virtual System.Collections.Generic.IList<string> JobCategories { get; set; }

        /// <summary>
        /// Structured locations of the job, resolved from Job.addresses. locations are exactly matched to Job.addresses
        /// in the same order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<Location> Locations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An event issued when a job seeker interacts with the application that implements Cloud Talent Solution.
    /// </summary>
    public class JobEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The job name(s) associated with this event. For example, if this is an impression event, this
        /// field contains the identifiers of all jobs shown to the job seeker. If this was a view event, this field
        /// contains the identifier of the viewed job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobs")]
        public virtual System.Collections.Generic.IList<string> Jobs { get; set; }

        /// <summary>Required. The type of the event (see JobEventType).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Input only. The query required to perform a search query.</summary>
    public class JobQuery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Allows filtering jobs by commute time with different travel methods (for example, driving or
        /// public transit). Note: This only works with COMMUTE MODE. When specified, [JobQuery.location_filters] is
        /// ignored. Currently we don't support sorting by commute time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commuteFilter")]
        public virtual CommuteFilter CommuteFilter { get; set; }

        /// <summary>
        /// Optional. This filter specifies the exact company display name of the jobs to search against. If a value
        /// isn't specified, jobs within the search results are associated with any company. If multiple values are
        /// specified, jobs within the search results may be associated with any of the specified companies. At most 20
        /// company display name filters are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("companyDisplayNames")]
        public virtual System.Collections.Generic.IList<string> CompanyDisplayNames { get; set; }

        /// <summary>
        /// Optional. This filter specifies the company entities to search against. If a value isn't specified, jobs are
        /// searched for against all companies. If multiple values are specified, jobs are searched against the
        /// companies specified. The format is "projects/{project_id}/companies/{company_id}", for example,
        /// "projects/api-test-project/companies/foo". At most 20 company filters are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("companyNames")]
        public virtual System.Collections.Generic.IList<string> CompanyNames { get; set; }

        /// <summary>
        /// Optional. This search filter is applied only to Job.compensation_info. For example, if the filter is
        /// specified as "Hourly job with per-hour compensation &amp;gt; $15", only jobs meeting these criteria are
        /// searched. If a filter isn't defined, all open jobs are searched.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compensationFilter")]
        public virtual CompensationFilter CompensationFilter { get; set; }

        /// <summary>
        /// Optional. This filter specifies a structured syntax to match against the Job.custom_attributes marked as
        /// `filterable`. The syntax for this expression is a subset of SQL syntax. Supported operators are: `=`, `!=`,
        /// `&amp;lt;`, `&amp;lt;=`, `&amp;gt;`, and `&amp;gt;=` where the left of the operator is a custom field key
        /// and the right of the operator is a number or a quoted string. You must escape backslash (\\) and quote (\")
        /// characters. Supported functions are `LOWER([field_name])` to perform a case insensitive match and
        /// `EMPTY([field_name])` to filter on the existence of a key. Boolean expressions (AND/OR/NOT) are supported up
        /// to 3 levels of nesting (for example, "((A AND B AND C) OR NOT D) AND E"), a maximum of 100 comparisons or
        /// functions are allowed in the expression. The expression must be &amp;lt; 10000 bytes in length. Sample
        /// Query: `(LOWER(driving_license)="class \"a\"" OR EMPTY(driving_license)) AND driving_years &amp;gt; 10`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customAttributeFilter")]
        public virtual string CustomAttributeFilter { get; set; }

        /// <summary>
        /// Optional. This flag controls the spell-check feature. If false, the service attempts to correct a misspelled
        /// query, for example, "enginee" is corrected to "engineer". Defaults to false: a spell check is performed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableSpellCheck")]
        public virtual System.Nullable<bool> DisableSpellCheck { get; set; }

        /// <summary>
        /// Optional. The employment type filter specifies the employment type of jobs to search against, such as
        /// EmploymentType.FULL_TIME. If a value is not specified, jobs in the search results includes any employment
        /// type. If multiple values are specified, jobs in the search results include any of the specified employment
        /// types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("employmentTypes")]
        public virtual System.Collections.Generic.IList<string> EmploymentTypes { get; set; }

        /// <summary>
        /// Optional. This filter specifies a list of job names to be excluded during search. At most 400 excluded job
        /// names are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedJobs")]
        public virtual System.Collections.Generic.IList<string> ExcludedJobs { get; set; }

        /// <summary>
        /// Optional. The category filter specifies the categories of jobs to search against. See Category for more
        /// information. If a value is not specified, jobs from any category are searched against. If multiple values
        /// are specified, jobs from any of the specified categories are searched against.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobCategories")]
        public virtual System.Collections.Generic.IList<string> JobCategories { get; set; }

        /// <summary>
        /// Optional. This filter specifies the locale of jobs to search against, for example, "en-US". If a value isn't
        /// specified, the search results can contain jobs in any locale. Language codes should be in BCP-47 format,
        /// such as "en-US" or "sr-Latn". For more information, see [Tags for Identifying
        /// Languages](https://tools.ietf.org/html/bcp47). At most 10 language code filters are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCodes")]
        public virtual System.Collections.Generic.IList<string> LanguageCodes { get; set; }

        /// <summary>
        /// Optional. The location filter specifies geo-regions containing the jobs to search against. See
        /// LocationFilter for more information. If a location value isn't specified, jobs fitting the other search
        /// criteria are retrieved regardless of where they're located. If multiple values are specified, jobs are
        /// retrieved from any of the specified locations. If different values are specified for the
        /// LocationFilter.distance_in_miles parameter, the maximum provided distance is used for all locations. At most
        /// 5 location filters are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationFilters")]
        public virtual System.Collections.Generic.IList<LocationFilter> LocationFilters { get; set; }

        /// <summary>Optional. Jobs published within a range specified by this filter are searched against.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishTimeRange")]
        public virtual TimestampRange PublishTimeRange { get; set; }

        /// <summary>
        /// Optional. The query string that matches against the job title, description, and location fields. The maximum
        /// number of allowed characters is 255.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>
        /// The language code of query. For example, "en-US". This field helps to better interpret the query. If a value
        /// isn't specified, the query language code is automatically detected, which may not be accurate. Language code
        /// should be in BCP-47 format, such as "en-US" or "sr-Latn". For more information, see [Tags for Identifying
        /// Languages](https://tools.ietf.org/html/bcp47).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryLanguageCode")]
        public virtual string QueryLanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An object that represents a latitude/longitude pair. This is expressed as a pair of doubles to represent degrees
    /// latitude and degrees longitude. Unless specified otherwise, this object must conform to the WGS84 standard.
    /// Values must be within normalized ranges.
    /// </summary>
    public class LatLng : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The latitude in degrees. It must be in the range [-90.0, +90.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latitude")]
        public virtual System.Nullable<double> Latitude { get; set; }

        /// <summary>The longitude in degrees. It must be in the range [-180.0, +180.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longitude")]
        public virtual System.Nullable<double> Longitude { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output only. The List companies response object.</summary>
    public class ListCompaniesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Companies for the current client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("companies")]
        public virtual System.Collections.Generic.IList<Company> Companies { get; set; }

        /// <summary>Additional information for the API invocation, such as the request tracking id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ResponseMetadata Metadata { get; set; }

        /// <summary>A token to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output only. List jobs response.</summary>
    public class ListJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Jobs for a given company. The maximum number of items returned is based on the limit field provided in
        /// the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobs")]
        public virtual System.Collections.Generic.IList<Job> Jobs { get; set; }

        /// <summary>Additional information for the API invocation, such as the request tracking id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ResponseMetadata Metadata { get; set; }

        /// <summary>A token to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output only. A resource that represents a location with full geographic information.</summary>
    public class Location : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An object representing a latitude/longitude pair.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latLng")]
        public virtual LatLng LatLng { get; set; }

        /// <summary>
        /// The type of a location, which corresponds to the address lines field of PostalAddress. For example,
        /// "Downtown, Atlanta, GA, USA" has a type of LocationType#NEIGHBORHOOD, and "Kansas City, KS, USA" has a type
        /// of LocationType#LOCALITY.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationType")]
        public virtual string LocationType { get; set; }

        /// <summary>
        /// Postal address of the location that includes human readable information, such as postal delivery and
        /// payments addresses. Given a postal address, a postal service can deliver items to a premises, P.O. Box, or
        /// other delivery location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalAddress")]
        public virtual PostalAddress PostalAddress { get; set; }

        /// <summary>
        /// Radius in miles of the job location. This value is derived from the location bounding box in which a circle
        /// with the specified radius centered from LatLng covers the area associated with the job location. For
        /// example, currently, "Mountain View, CA, USA" has a radius of 6.17 miles.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("radiusInMiles")]
        public virtual System.Nullable<double> RadiusInMiles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Input only. Geographic region of the search.</summary>
    public class LocationFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The address name, such as "Mountain View" or "Bay Area".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; }

        /// <summary>
        /// Optional. The distance_in_miles is applied when the location being searched for is identified as a city or
        /// smaller. When the location being searched for is a state or larger, this field is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distanceInMiles")]
        public virtual System.Nullable<double> DistanceInMiles { get; set; }

        /// <summary>
        /// Optional. The latitude and longitude of the geographic center from which to search. This field's ignored if
        /// `address` is provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latLng")]
        public virtual LatLng LatLng { get; set; }

        /// <summary>
        /// Optional. CLDR region code of the country/region. This field may be used in two ways: 1) If telecommute
        /// preference is not set, this field is used address ambiguity of the user-input address. For example,
        /// "Liverpool" may refer to "Liverpool, NY, US" or "Liverpool, UK". This region code biases the address
        /// resolution toward a specific country or territory. If this field is not set, address resolution is biased
        /// toward the United States by default. 2) If telecommute preference is set to TELECOMMUTE_ALLOWED, the
        /// telecommute location filter will be limited to the region specified in this field. If this field is not set,
        /// the telecommute job locations will not be limited. See
        /// https://unicode-org.github.io/cldr-staging/charts/latest/supplemental/territory_information.html for
        /// details. Example: "CH" for Switzerland.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>
        /// Optional. Allows the client to return jobs without a set location, specifically, telecommuting jobs
        /// (telecommuting is considered by the service as a special location. Job.posting_region indicates if a job
        /// permits telecommuting. If this field is set to TelecommutePreference.TELECOMMUTE_ALLOWED, telecommuting jobs
        /// are searched, and address and lat_lng are ignored. If not set or set to
        /// TelecommutePreference.TELECOMMUTE_EXCLUDED, telecommute job are not searched. This filter can be used by
        /// itself to search exclusively for telecommuting jobs, or it can be combined with another location filter to
        /// search for a combination of job locations, such as "Mountain View" or "telecommuting" jobs. However, when
        /// used in combination with other location filters, telecommuting jobs can be treated as less relevant than
        /// other jobs in the search response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("telecommutePreference")]
        public virtual string TelecommutePreference { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output only. Job entry with metadata inside SearchJobsResponse.</summary>
    public class MatchingJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Commute information which is generated based on specified CommuteFilter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commuteInfo")]
        public virtual CommuteInfo CommuteInfo { get; set; }

        /// <summary>Job resource that matches the specified SearchJobsRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("job")]
        public virtual Job Job { get; set; }

        /// <summary>
        /// A summary of the job with core information that's displayed on the search results listing page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobSummary")]
        public virtual string JobSummary { get; set; }

        /// <summary>
        /// Contains snippets of text from the Job.job_title field most closely matching a search query's keywords, if
        /// available. The matching query keywords are enclosed in HTML bold tags.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobTitleSnippet")]
        public virtual string JobTitleSnippet { get; set; }

        /// <summary>
        /// Contains snippets of text from the Job.description and similar fields that most closely match a search
        /// query's keywords, if available. All HTML tags in the original fields are stripped when returned in this
        /// field, and matching query keywords are enclosed in HTML bold tags.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchTextSnippet")]
        public virtual string SearchTextSnippet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message representing input to a Mendel server for debug forcing. See go/mendel-debug-forcing for more details.
    /// Next ID: 2
    /// </summary>
    public class MendelDebugInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When a request spans multiple servers, a MendelDebugInput may travel with the request and take effect in all
        /// the servers. This field is a map of namespaces to NamespacedMendelDebugInput protos. In a single server, up
        /// to two NamespacedMendelDebugInput protos are applied: 1. NamespacedMendelDebugInput with the global
        /// namespace (key == ""). 2. NamespacedMendelDebugInput with the server's namespace. When both
        /// NamespacedMendelDebugInput protos are present, they are merged. See go/mendel-debug-forcing for more
        /// details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespacedDebugInput")]
        public virtual System.Collections.Generic.IDictionary<string, NamespacedDebugInput> NamespacedDebugInput { get; set; }

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

    /// <summary>Next ID: 15</summary>
    public class NamespacedDebugInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Set of experiment names to be absolutely forced. These experiments will be forced without evaluating the
        /// conditions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("absolutelyForcedExpNames")]
        public virtual System.Collections.Generic.IList<string> AbsolutelyForcedExpNames { get; set; }

        /// <summary>
        /// Set of experiment tags to be absolutely forced. The experiments with these tags will be forced without
        /// evaluating the conditions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("absolutelyForcedExpTags")]
        public virtual System.Collections.Generic.IList<string> AbsolutelyForcedExpTags { get; set; }

        /// <summary>
        /// Set of experiment ids to be absolutely forced. These ids will be forced without evaluating the conditions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("absolutelyForcedExps")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> AbsolutelyForcedExps { get; set; }

        /// <summary>
        /// Set of experiment names to be conditionally forced. These experiments will be forced only if their
        /// conditions and their parent domain's conditions are true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionallyForcedExpNames")]
        public virtual System.Collections.Generic.IList<string> ConditionallyForcedExpNames { get; set; }

        /// <summary>
        /// Set of experiment tags to be conditionally forced. The experiments with these tags will be forced only if
        /// their conditions and their parent domain's conditions are true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionallyForcedExpTags")]
        public virtual System.Collections.Generic.IList<string> ConditionallyForcedExpTags { get; set; }

        /// <summary>
        /// Set of experiment ids to be conditionally forced. These ids will be forced only if their conditions and
        /// their parent domain's conditions are true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionallyForcedExps")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> ConditionallyForcedExps { get; set; }

        /// <summary>
        /// If true, disable automatic enrollment selection (at all diversion points). Automatic enrollment selection
        /// means experiment selection process based on the experiment's automatic enrollment condition. This does not
        /// disable selection of forced experiments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableAutomaticEnrollmentSelection")]
        public virtual System.Nullable<bool> DisableAutomaticEnrollmentSelection { get; set; }

        /// <summary>
        /// Set of experiment names to be disabled. If an experiment is disabled, it is never selected nor forced. If an
        /// aggregate experiment is disabled, its partitions are disabled together. If an experiment with an enrollment
        /// is disabled, the enrollment is disabled together. If a name corresponds to a domain, the domain itself and
        /// all descendant experiments and domains are disabled together.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableExpNames")]
        public virtual System.Collections.Generic.IList<string> DisableExpNames { get; set; }

        /// <summary>
        /// Set of experiment tags to be disabled. All experiments that are tagged with one or more of these tags are
        /// disabled. If an experiment is disabled, it is never selected nor forced. If an aggregate experiment is
        /// disabled, its partitions are disabled together. If an experiment with an enrollment is disabled, the
        /// enrollment is disabled together.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableExpTags")]
        public virtual System.Collections.Generic.IList<string> DisableExpTags { get; set; }

        /// <summary>
        /// Set of experiment ids to be disabled. If an experiment is disabled, it is never selected nor forced. If an
        /// aggregate experiment is disabled, its partitions are disabled together. If an experiment with an enrollment
        /// is disabled, the enrollment is disabled together. If an ID corresponds to a domain, the domain itself and
        /// all descendant experiments and domains are disabled together.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableExps")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> DisableExps { get; set; }

        /// <summary>
        /// If true, disable manual enrollment selection (at all diversion points). Manual enrollment selection means
        /// experiment selection process based on the request's manual enrollment states (a.k.a. opt-in experiments).
        /// This does not disable selection of forced experiments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableManualEnrollmentSelection")]
        public virtual System.Nullable<bool> DisableManualEnrollmentSelection { get; set; }

        /// <summary>
        /// If true, disable organic experiment selection (at all diversion points). Organic selection means experiment
        /// selection process based on traffic allocation and diversion condition evaluation. This does not disable
        /// selection of forced experiments. This is useful in cases when it is not known whether experiment selection
        /// behavior is responsible for a error or breakage. Disabling organic selection may help to isolate the cause
        /// of a given problem.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableOrganicSelection")]
        public virtual System.Nullable<bool> DisableOrganicSelection { get; set; }

        /// <summary>Flags to force in a particular experiment state. Map from flag name to flag value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forcedFlags")]
        public virtual System.Collections.Generic.IDictionary<string, string> ForcedFlags { get; set; }

        /// <summary>
        /// Rollouts to force in a particular experiment state. Map from rollout name to rollout value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forcedRollouts")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<bool>> ForcedRollouts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Input only. Use this field to specify bucketing option for the histogram search response.</summary>
    public class NumericBucketingOption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Two adjacent values form a histogram bucket. Values should be in ascending order. For example, if
        /// [5, 10, 15] are provided, four buckets are created: (-inf, 5), 5, 10), [10, 15), [15, inf). At most 20
        /// [buckets_bound is supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketBounds")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> BucketBounds { get; set; }

        /// <summary>
        /// Optional. If set to true, the histogram result includes minimum/maximum value of the numeric field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiresMinMax")]
        public virtual System.Nullable<bool> RequiresMinMax { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output only. Custom numeric bucketing result.</summary>
    public class NumericBucketingResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Count within each bucket. Its size is the length of NumericBucketingOption.bucket_bounds plus 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("counts")]
        public virtual System.Collections.Generic.IList<BucketizedCount> Counts { get; set; }

        /// <summary>
        /// Stores the maximum value of the numeric field. Is populated only if
        /// [NumericBucketingOption.requires_min_max] is set to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxValue")]
        public virtual System.Nullable<double> MaxValue { get; set; }

        /// <summary>
        /// Stores the minimum value of the numeric field. Will be populated only if
        /// [NumericBucketingOption.requires_min_max] is set to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minValue")]
        public virtual System.Nullable<double> MinValue { get; set; }

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

    /// <summary>
    /// Represents a postal address, e.g. for postal delivery or payments addresses. Given a postal address, a postal
    /// service can deliver items to a premise, P.O. Box or similar. It is not intended to model geographical locations
    /// (roads, towns, mountains). In typical usage an address would be created via user input or from importing
    /// existing data, depending on the type of process. Advice on address input / editing: - Use an i18n-ready address
    /// widget such as https://github.com/google/libaddressinput) - Users should not be presented with UI elements for
    /// input or editing of fields outside countries where that field is used. For more guidance on how to use this
    /// schema, please see: https://support.google.com/business/answer/6397478
    /// </summary>
    public class PostalAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Unstructured address lines describing the lower levels of an address. Because values in address_lines do not
        /// have type information and may sometimes contain multiple values in a single field (e.g. "Austin, TX"), it is
        /// important that the line order is clear. The order of address lines should be "envelope order" for the
        /// country/region of the address. In places where this can vary (e.g. Japan), address_language is used to make
        /// it explicit (e.g. "ja" for large-to-small ordering and "ja-Latn" or "en" for small-to-large). This way, the
        /// most specific line of an address can be selected based on the language. The minimum permitted structural
        /// representation of an address consists of a region_code with all remaining information placed in the
        /// address_lines. It would be possible to format such an address very approximately without geocoding, but no
        /// semantic reasoning could be made about any of the address components until it was at least partially
        /// resolved. Creating an address only containing a region_code and address_lines, and then geocoding is the
        /// recommended way to handle completely unstructured addresses (as opposed to guessing which parts of the
        /// address should be localities or administrative areas).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressLines")]
        public virtual System.Collections.Generic.IList<string> AddressLines { get; set; }

        /// <summary>
        /// Optional. Highest administrative subdivision which is used for postal addresses of a country or region. For
        /// example, this can be a state, a province, an oblast, or a prefecture. Specifically, for Spain this is the
        /// province and not the autonomous community (e.g. "Barcelona" and not "Catalonia"). Many countries don't use
        /// an administrative area in postal addresses. E.g. in Switzerland this should be left unpopulated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("administrativeArea")]
        public virtual string AdministrativeArea { get; set; }

        /// <summary>
        /// Optional. BCP-47 language code of the contents of this address (if known). This is often the UI language of
        /// the input form or is expected to match one of the languages used in the address' country/region, or their
        /// transliterated equivalents. This can affect formatting in certain countries, but is not critical to the
        /// correctness of the data and will never affect any validation or other non-formatting related operations. If
        /// this value is not known, it should be omitted (rather than specifying a possibly incorrect default).
        /// Examples: "zh-Hant", "ja", "ja-Latn", "en".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Optional. Generally refers to the city/town portion of the address. Examples: US city, IT comune, UK post
        /// town. In regions of the world where localities are not well defined or do not fit into this structure well,
        /// leave locality empty and use address_lines.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locality")]
        public virtual string Locality { get; set; }

        /// <summary>Optional. The name of the organization at the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual string Organization { get; set; }

        /// <summary>
        /// Optional. Postal code of the address. Not all countries use or require postal codes to be present, but where
        /// they are used, they may trigger additional validation with other parts of the address (e.g. state/zip
        /// validation in the U.S.A.).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; }

        /// <summary>
        /// Optional. The recipient at the address. This field may, under certain circumstances, contain multiline
        /// information. For example, it might contain "care of" information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recipients")]
        public virtual System.Collections.Generic.IList<string> Recipients { get; set; }

        /// <summary>
        /// Required. CLDR region code of the country/region of the address. This is never inferred and it is up to the
        /// user to ensure the value is correct. See http://cldr.unicode.org/ and
        /// http://www.unicode.org/cldr/charts/30/supplemental/territory_information.html for details. Example: "CH" for
        /// Switzerland.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>
        /// The schema revision of the `PostalAddress`. This must be set to 0, which is the latest revision. All new
        /// revisions **must** be backward compatible with old revisions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual System.Nullable<int> Revision { get; set; }

        /// <summary>
        /// Optional. Additional, country-specific, sorting code. This is not used in most regions. Where it is used,
        /// the value is either a string like "CEDEX", optionally followed by a number (e.g. "CEDEX 7"), or just a
        /// number alone, representing the "sector code" (Jamaica), "delivery area indicator" (Malawi) or "post office
        /// indicator" (e.g. Côte d'Ivoire).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortingCode")]
        public virtual string SortingCode { get; set; }

        /// <summary>
        /// Optional. Sublocality of the address. For example, this can be neighborhoods, boroughs, districts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sublocality")]
        public virtual string Sublocality { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Input only. Options for job processing.</summary>
    public class ProcessingOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If set to `true`, the service does not attempt to resolve a more precise address for the job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableStreetAddressResolution")]
        public virtual System.Nullable<bool> DisableStreetAddressResolution { get; set; }

        /// <summary>
        /// Optional. Option for job HTML content sanitization. Applied fields are: * description *
        /// applicationInfo.instruction * incentives * qualifications * responsibilities HTML tags in these fields may
        /// be stripped if sanitiazation is not disabled. Defaults to HtmlSanitization.SIMPLE_FORMATTING_ONLY.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("htmlSanitization")]
        public virtual string HtmlSanitization { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Input only. Meta information related to the job searcher or entity conducting the job search. This information
    /// is used to improve the performance of the service.
    /// </summary>
    public class RequestMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The type of device used by the job seeker at the time of the call to the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceInfo")]
        public virtual DeviceInfo DeviceInfo { get; set; }

        /// <summary>
        /// Required. The client-defined scope or source of the service call, which typically is the domain on which the
        /// service has been implemented and is currently being run. For example, if the service is being run by client
        /// *Foo, Inc.*, on job board www.foo.com and career site www.bar.com, then this field is set to "foo.com" for
        /// use on the job board, and "bar.com" for use on the career site. If this field isn't available for some
        /// reason, send "UNKNOWN". Any improvements to the model for a particular tenant site rely on this field being
        /// set correctly to a domain. The maximum number of allowed characters is 255.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>
        /// Required. A unique session identification string. A session is defined as the duration of an end user's
        /// interaction with the service over a certain period. Obfuscate this field for privacy concerns before
        /// providing it to the service. If this field is not available for some reason, send "UNKNOWN". Note that any
        /// improvements to the model for a particular tenant site, rely on this field being set correctly to some
        /// unique session_id. The maximum number of allowed characters is 255.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionId")]
        public virtual string SessionId { get; set; }

        /// <summary>
        /// Required. A unique user identification string, as determined by the client. To have the strongest positive
        /// impact on search quality make sure the client-level is unique. Obfuscate this field for privacy concerns
        /// before providing it to the service. If this field is not available for some reason, send "UNKNOWN". Note
        /// that any improvements to the model for a particular tenant site, rely on this field being set correctly to a
        /// unique user_id. The maximum number of allowed characters is 255.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output only. Additional information returned to client, such as debugging information.</summary>
    public class ResponseMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A unique id associated with this call. This id is logged for tracking purposes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Input only. The Request body of the `SearchJobs` call.</summary>
    public class SearchJobsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Controls over how job documents get ranked on top of existing relevance score (determined by API
        /// algorithm).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customRankingInfo")]
        public virtual CustomRankingInfo CustomRankingInfo { get; set; }

        /// <summary>
        /// Optional. Controls whether to disable exact keyword match on Job.job_title, Job.description,
        /// Job.company_display_name, Job.locations, Job.qualifications. When disable keyword match is turned off, a
        /// keyword match returns jobs that do not match given category filters when there are matching keywords. For
        /// example, the query "program manager," a result is returned even if the job posting has the title "software
        /// developer," which does not fall into "program manager" ontology, but does have "program manager" appearing
        /// in its description. For queries like "cloud" that does not contain title or location specific ontology, jobs
        /// with "cloud" keyword matches are returned regardless of this flag's value. Please use
        /// Company.keyword_searchable_custom_fields or Company.keyword_searchable_custom_attributes if company specific
        /// globally matched custom field/attribute string values is needed. Enabling keyword match improves recall of
        /// subsequent search requests. Defaults to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableKeywordMatch")]
        public virtual System.Nullable<bool> DisableKeywordMatch { get; set; }

        /// <summary>
        /// Optional. Controls whether highly similar jobs are returned next to each other in the search results. Jobs
        /// are identified as highly similar based on their titles, job categories, and locations. Highly similar
        /// results are clustered so that only one representative job of the cluster is displayed to the job seeker
        /// higher up in the results, with the other jobs being displayed lower down in the results. Defaults to
        /// DiversificationLevel.SIMPLE if no value is specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diversificationLevel")]
        public virtual string DiversificationLevel { get; set; }

        /// <summary>
        /// Optional. Controls whether to broaden the search when it produces sparse results. Broadened queries append
        /// results to the end of the matching results list. Defaults to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableBroadening")]
        public virtual System.Nullable<bool> EnableBroadening { get; set; }

        /// <summary>Optional. Histogram requests for jobs matching JobQuery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("histogramFacets")]
        public virtual HistogramFacets HistogramFacets { get; set; }

        /// <summary>Optional. Expression based histogram requests for jobs matching JobQuery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("histogramQueries")]
        public virtual System.Collections.Generic.IList<HistogramQuery> HistogramQueries { get; set; }

        /// <summary>Optional. Query used to search against jobs, such as keyword, location filters, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobQuery")]
        public virtual JobQuery JobQuery { get; set; }

        /// <summary>
        /// Optional. The desired job attributes returned for jobs in the search response. Defaults to JobView.SMALL if
        /// no value is specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobView")]
        public virtual string JobView { get; set; }

        /// <summary>
        /// Optional. An integer that specifies the current offset (that is, starting result location, amongst the jobs
        /// deemed by the API as relevant) in search results. This field is only considered if page_token is unset. The
        /// maximum allowed value is 5000. Otherwise an error is thrown. For example, 0 means to return results starting
        /// from the first matching job, and 10 means to return from the 11th job. This can be used for pagination, (for
        /// example, pageSize = 10 and offset = 10 means to return from the second page).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offset")]
        public virtual System.Nullable<int> Offset { get; set; }

        /// <summary>
        /// Optional. The criteria determining how search results are sorted. Default is "relevance desc". Supported
        /// options are: * `"relevance desc"`: By relevance descending, as determined by the API algorithms. Relevance
        /// thresholding of query results is only available with this ordering. * `"posting_publish_time desc"`: By
        /// Job.posting_publish_time descending. * `"posting_update_time desc"`: By Job.posting_update_time descending.
        /// * `"title"`: By Job.title ascending. * `"title desc"`: By Job.title descending. *
        /// `"annualized_base_compensation"`: By job's CompensationInfo.annualized_base_compensation_range ascending.
        /// Jobs whose annualized base compensation is unspecified are put at the end of search results. *
        /// `"annualized_base_compensation desc"`: By job's CompensationInfo.annualized_base_compensation_range
        /// descending. Jobs whose annualized base compensation is unspecified are put at the end of search results. *
        /// `"annualized_total_compensation"`: By job's CompensationInfo.annualized_total_compensation_range ascending.
        /// Jobs whose annualized base compensation is unspecified are put at the end of search results. *
        /// `"annualized_total_compensation desc"`: By job's CompensationInfo.annualized_total_compensation_range
        /// descending. Jobs whose annualized base compensation is unspecified are put at the end of search results. *
        /// `"custom_ranking desc"`: By the relevance score adjusted to the
        /// SearchJobsRequest.custom_ranking_info.ranking_expression with weight factor assigned by
        /// SearchJobsRequest.custom_ranking_info.importance_level in descending order. * Location sorting: Use the
        /// special syntax to order jobs by distance: "`distance_from('Hawaii')`": Order by distance from Hawaii.
        /// "`distance_from(19.89, 155.5)`": Order by distance from a coordinate. "`distance_from('Hawaii'),
        /// distance_from('Puerto Rico')`": Order by multiple locations. See details below. "`distance_from('Hawaii'),
        /// distance_from(19.89, 155.5)`": Order by multiple locations. See details below. The string can have a maximum
        /// of 256 characters. When multiple distance centers are provided, a job that is close to any of the distance
        /// centers would have a high rank. When a job has multiple locations, the job location closest to one of the
        /// distance centers will be used. Jobs that don't have locations will be ranked at the bottom. Distance is
        /// calculated with a precision of 11.3 meters (37.4 feet). Diversification strategy is still applied unless
        /// explicitly disabled in diversification_level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderBy")]
        public virtual string OrderBy { get; set; }

        /// <summary>
        /// Optional. A limit on the number of jobs returned in the search results. Increasing this value above the
        /// default value of 10 can increase search response time. The value can be between 1 and 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// Optional. The token specifying the current offset within search results. See
        /// SearchJobsResponse.next_page_token for an explanation of how to obtain the next set of query results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Required. The meta information collected about the job searcher, used to improve the search quality of the
        /// service. The identifiers (such as `user_id`) are provided by users, and must be unique and consistent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestMetadata")]
        public virtual RequestMetadata RequestMetadata { get; set; }

        /// <summary>This field is deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requirePreciseResultSize")]
        public virtual System.Nullable<bool> RequirePreciseResultSize { get; set; }

        /// <summary>Optional. Mode of a search. Defaults to SearchMode.JOB_SEARCH.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchMode")]
        public virtual string SearchMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output only. Response for SearchJob method.</summary>
    public class SearchJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If query broadening is enabled, we may append additional results from the broadened query. This number
        /// indicates how many of the jobs returned in the jobs field are from the broadened query. These results are
        /// always at the end of the jobs list. In particular, a value of 0, or if the field isn't set, all the jobs in
        /// the jobs list are from the original (without broadening) query. If this field is non-zero, subsequent
        /// requests with offset after this result set should contain all broadened results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("broadenedQueryJobsCount")]
        public virtual System.Nullable<int> BroadenedQueryJobsCount { get; set; }

        /// <summary>
        /// An estimation of the number of jobs that match the specified query. This number is not guaranteed to be
        /// accurate. For accurate results, see SearchJobsResponse.total_size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedTotalSize")]
        public virtual System.Nullable<int> EstimatedTotalSize { get; set; }

        /// <summary>The histogram results that match with specified SearchJobsRequest.histogram_queries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("histogramQueryResults")]
        public virtual System.Collections.Generic.IList<HistogramQueryResult> HistogramQueryResults { get; set; }

        /// <summary>The histogram results that match specified SearchJobsRequest.histogram_facets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("histogramResults")]
        public virtual HistogramResults HistogramResults { get; set; }

        /// <summary>
        /// The location filters that the service applied to the specified query. If any filters are lat-lng based, the
        /// JobLocation.location_type is JobLocation.LocationType#LOCATION_TYPE_UNSPECIFIED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationFilters")]
        public virtual System.Collections.Generic.IList<Location> LocationFilters { get; set; }

        /// <summary>The Job entities that match the specified SearchJobsRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchingJobs")]
        public virtual System.Collections.Generic.IList<MatchingJob> MatchingJobs { get; set; }

        /// <summary>Additional information for the API invocation, such as the request tracking id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ResponseMetadata Metadata { get; set; }

        /// <summary>
        /// The token that specifies the starting position of the next page of results. This field is empty if there are
        /// no more results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The spell checking result, and correction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spellCorrection")]
        public virtual SpellingCorrection SpellCorrection { get; set; }

        /// <summary>The precise result count with limit 100,000.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output only. Spell check result.</summary>
    public class SpellingCorrection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates if the query was corrected by the spell checker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("corrected")]
        public virtual System.Nullable<bool> Corrected { get; set; }

        /// <summary>Correction output consisting of the corrected keyword string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("correctedText")]
        public virtual string CorrectedText { get; set; }

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
    /// Represents a time of day. The date and time zone are either not significant or are specified elsewhere. An API
    /// may choose to allow leap seconds. Related types are google.type.Date and `google.protobuf.Timestamp`.
    /// </summary>
    public class TimeOfDay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for
        /// scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows
        /// leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message representing a period of time between two timestamps.</summary>
    public class TimestampRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>End of the period.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Begin of the period.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Input only. Request for updating a specified company.</summary>
    public class UpdateCompanyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The company resource to replace the current resource in the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("company")]
        public virtual Company Company { get; set; }

        /// <summary>
        /// Optional but strongly recommended for the best service experience. If update_mask is provided, only the
        /// specified fields in company are updated. Otherwise all the fields are updated. A field mask to specify the
        /// company fields to be updated. Only top level fields of Company are supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Input only. Update job request.</summary>
    public class UpdateJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Job to be updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("job")]
        public virtual Job Job { get; set; }

        /// <summary>
        /// Optional but strongly recommended to be provided for the best service experience. If update_mask is
        /// provided, only the specified fields in job are updated. Otherwise all the fields are updated. A field mask
        /// to restrict the fields that are updated. Only top level fields of Job are supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
