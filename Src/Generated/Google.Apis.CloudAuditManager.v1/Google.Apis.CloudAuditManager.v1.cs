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

namespace Google.Apis.CloudAuditManager.v1
{
    /// <summary>The CloudAuditManager Service.</summary>
    public class CloudAuditManagerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudAuditManagerService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudAuditManagerService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Folders = new FoldersResource(this);
            Organizations = new OrganizationsResource(this);
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://auditmanager.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://auditmanager.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "auditmanager";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Audit Manager API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud Auditmanager data and see the email address for your
            /// Google Account
            /// </summary>
            public static string CloudAuditmanager = "https://www.googleapis.com/auth/cloud-auditmanager";

            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Audit Manager API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud Auditmanager data and see the email address for your
            /// Google Account
            /// </summary>
            public const string CloudAuditmanager = "https://www.googleapis.com/auth/cloud-auditmanager";

            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Folders resource.</summary>
        public virtual FoldersResource Folders { get; }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for CloudAuditManager requests.</summary>
    public abstract class CloudAuditManagerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudAuditManagerBaseServiceRequest instance.</summary>
        protected CloudAuditManagerBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudAuditManager parameter list.</summary>
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

    /// <summary>The "folders" collection of methods.</summary>
    public class FoldersResource
    {
        private const string Resource = "folders";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public FoldersResource(Google.Apis.Services.IClientService service)
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
                AuditReports = new AuditReportsResource(service);
                AuditSchedules = new AuditSchedulesResource(service);
                AuditScopeReports = new AuditScopeReportsResource(service);
                OperationDetails = new OperationDetailsResource(service);
                OperationIds = new OperationIdsResource(service);
                ResourceEnrollmentStatuses = new ResourceEnrollmentStatusesResource(service);
                Standards = new StandardsResource(service);
            }

            /// <summary>Gets the AuditReports resource.</summary>
            public virtual AuditReportsResource AuditReports { get; }

            /// <summary>The "auditReports" collection of methods.</summary>
            public class AuditReportsResource
            {
                private const string Resource = "auditReports";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AuditReportsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Registers audit report generation requests. This method returns the operation identifier that you
                /// can use to track the report generation progress.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="scope">
                /// Required. Organization, folder, or project that the audit applies to, in one of the following
                /// formats: * `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
                /// `organizations/{organization}/locations/{location}`
                /// </param>
                public virtual GenerateRequest Generate(Google.Apis.CloudAuditManager.v1.Data.GenerateAuditReportRequest body, string scope)
                {
                    return new GenerateRequest(this.service, body, scope);
                }

                /// <summary>
                /// Registers audit report generation requests. This method returns the operation identifier that you
                /// can use to track the report generation progress.
                /// </summary>
                public class GenerateRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Generate request.</summary>
                    public GenerateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAuditManager.v1.Data.GenerateAuditReportRequest body, string scope) : base(service)
                    {
                        Scope = scope;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Organization, folder, or project that the audit applies to, in one of the following
                    /// formats: * `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
                    /// `organizations/{organization}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("scope", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Scope { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudAuditManager.v1.Data.GenerateAuditReportRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "generate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+scope}/auditReports:generate";

                    /// <summary>Initializes Generate parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("scope", new Google.Apis.Discovery.Parameter
                        {
                            Name = "scope",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^folders/[^/]+/locations/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets the full metadata and findings for an audit report.</summary>
                /// <param name="name">
                /// Required. Name of the audit report, in one of the following formats: *
                /// `projects/{project}/locations/{location}/auditReports/{audit_report}` *
                /// `folders/{folder}/locations/{location}/auditReports/{audit_report}` *
                /// `organizations/{organization}/locations/{location}/auditReports/{audit_report}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets the full metadata and findings for an audit report.</summary>
                public class GetRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.AuditReport>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the audit report, in one of the following formats: *
                    /// `projects/{project}/locations/{location}/auditReports/{audit_report}` *
                    /// `folders/{folder}/locations/{location}/auditReports/{audit_report}` *
                    /// `organizations/{organization}/locations/{location}/auditReports/{audit_report}`
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
                            Pattern = @"^folders/[^/]+/locations/[^/]+/auditReports/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists the audit reports for the organization, folder, or project that you specify as the parent
                /// scope.
                /// </summary>
                /// <param name="parent">
                /// Required. Parent organization, folder, or project to list reports for, in one of the following
                /// formats: * `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
                /// `organizations/{organization}/locations/{location}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists the audit reports for the organization, folder, or project that you specify as the parent
                /// scope.
                /// </summary>
                public class ListRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.ListAuditReportsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent organization, folder, or project to list reports for, in one of the following
                    /// formats: * `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
                    /// `organizations/{organization}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Maximum number of items to return in a single page. The service might return fewer
                    /// items than this value. If unspecified, the service picks an appropriate default. The maximum
                    /// value is 100; values above 100 are reduced to 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous call, to retrieve the next page of results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/auditReports";

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
                            Pattern = @"^folders/[^/]+/locations/[^/]+$",
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

            /// <summary>Gets the AuditSchedules resource.</summary>
            public virtual AuditSchedulesResource AuditSchedules { get; }

            /// <summary>The "auditSchedules" collection of methods.</summary>
            public class AuditSchedulesResource
            {
                private const string Resource = "auditSchedules";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AuditSchedulesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new audit schedule in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Project or folder that this audit schedule is for, in one of the following formats: *
                /// `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudAuditManager.v1.Data.AuditSchedule body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new audit schedule in a given project and location.</summary>
                public class CreateRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.AuditSchedule>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAuditManager.v1.Data.AuditSchedule body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Project or folder that this audit schedule is for, in one of the following formats: *
                    /// `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. ID to use for the audit schedule, which becomes the final component of the audit
                    /// schedule's resource name.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("auditScheduleId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string AuditScheduleId { get; set; }

                    /// <summary>
                    /// Optional. If `true`, only validates the request and does not create the audit schedule. This
                    /// executes standard request validation (such as schema, framework existence, scope, and IAM
                    /// checks) and skips the apply phase. Use this field for the following purposes: * **Infrastructure
                    /// as Code (IaC)**: Allow tools like Terraform to run dry-run mutations (e.g., `terraform plan`)
                    /// without creating real resources or incurring costs. * **User Interface Validation**: Enable
                    /// real-time form and permission validation in custom UIs before submitting requests. * **CI/CD
                    /// &amp;amp; Automation**: Test your scripts, permissions, and parameters safely without consuming
                    /// resource quotas.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudAuditManager.v1.Data.AuditSchedule Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/auditSchedules";

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
                            Pattern = @"^folders/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("auditScheduleId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "auditScheduleId",
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

                /// <summary>Gets details of a single audit schedule.</summary>
                /// <param name="name">
                /// Required. Name of the audit schedule to retrieve, in one of the following formats: *
                /// `projects/{project}/locations/{location}/auditSchedules/{audit_schedule}` *
                /// `folders/{folder}/locations/{location}/auditSchedules/{audit_schedule}` *
                /// `organizations/{organization}/locations/{location}/auditSchedules/{audit_schedule}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single audit schedule.</summary>
                public class GetRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.AuditSchedule>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the audit schedule to retrieve, in one of the following formats: *
                    /// `projects/{project}/locations/{location}/auditSchedules/{audit_schedule}` *
                    /// `folders/{folder}/locations/{location}/auditSchedules/{audit_schedule}` *
                    /// `organizations/{organization}/locations/{location}/auditSchedules/{audit_schedule}`
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
                            Pattern = @"^folders/[^/]+/locations/[^/]+/auditSchedules/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists audit schedules in a given project and location.</summary>
                /// <param name="parent">
                /// Required. Parent for the audit schedule, in one of the following formats: *
                /// `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
                /// `organizations/{organization}/locations/{location}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists audit schedules in a given project and location.</summary>
                public class ListRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.ListAuditSchedulesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent for the audit schedule, in one of the following formats: *
                    /// `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
                    /// `organizations/{organization}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Maximum number of items to return in a single page. The service might return fewer
                    /// items than this value. If unspecified, the service picks an appropriate default. The maximum
                    /// value is 100; values above 100 are reduced to 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous call, to retrieve the next page of results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/auditSchedules";

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
                            Pattern = @"^folders/[^/]+/locations/[^/]+$",
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

                /// <summary>Updates an existing audit schedule.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. Unique identifier for the audit schedule. Format:
                /// projects/{project}/locations/{location}/auditSchedules/{audit_schedule}
                /// folders/{folder}/locations/{location}/auditSchedules/{audit_schedule}
                /// organizations/{organization}/locations/{location}/auditSchedules/{audit_schedule}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudAuditManager.v1.Data.AuditSchedule body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates an existing audit schedule.</summary>
                public class PatchRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.AuditSchedule>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAuditManager.v1.Data.AuditSchedule body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. Unique identifier for the audit schedule. Format:
                    /// projects/{project}/locations/{location}/auditSchedules/{audit_schedule}
                    /// folders/{folder}/locations/{location}/auditSchedules/{audit_schedule}
                    /// organizations/{organization}/locations/{location}/auditSchedules/{audit_schedule}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Optional. List of fields to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// Optional. If `true`, only validates the request and does not update the audit schedule. This
                    /// executes standard request validation (such as schema, framework existence, scope, and IAM
                    /// checks) and skips the apply phase. Use this field for the following purposes: * **Infrastructure
                    /// as Code (IaC)**: Allow tools like Terraform to run dry-run mutations (e.g., `terraform plan`)
                    /// without creating real resources or incurring costs. * **User Interface Validation**: Enable
                    /// real-time form and permission validation in custom UIs before submitting requests. * **CI/CD
                    /// &amp;amp; Automation**: Test your scripts, permissions, and parameters safely without consuming
                    /// resource quotas.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudAuditManager.v1.Data.AuditSchedule Body { get; set; }

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
                            Pattern = @"^folders/[^/]+/locations/[^/]+/auditSchedules/[^/]+$",
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

            /// <summary>Gets the AuditScopeReports resource.</summary>
            public virtual AuditScopeReportsResource AuditScopeReports { get; }

            /// <summary>The "auditScopeReports" collection of methods.</summary>
            public class AuditScopeReportsResource
            {
                private const string Resource = "auditScopeReports";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AuditScopeReportsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Generates an audit scope report for the given standard. The report includes the following: * The
                /// technical attributes and constraints that Audit Manager uses to verify your compliance with a
                /// framework. * A list of Google Cloud services and resources that are within the scope of the
                /// framework.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="scope">
                /// Required. Project or folder that the audit scope report is generated for, in one of the following
                /// formats: * `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
                /// `organizations/{organization}/locations/{location}`
                /// </param>
                public virtual GenerateRequest Generate(Google.Apis.CloudAuditManager.v1.Data.GenerateAuditScopeReportRequest body, string scope)
                {
                    return new GenerateRequest(this.service, body, scope);
                }

                /// <summary>
                /// Generates an audit scope report for the given standard. The report includes the following: * The
                /// technical attributes and constraints that Audit Manager uses to verify your compliance with a
                /// framework. * A list of Google Cloud services and resources that are within the scope of the
                /// framework.
                /// </summary>
                public class GenerateRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.AuditScopeReport>
                {
                    /// <summary>Constructs a new Generate request.</summary>
                    public GenerateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAuditManager.v1.Data.GenerateAuditScopeReportRequest body, string scope) : base(service)
                    {
                        Scope = scope;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Project or folder that the audit scope report is generated for, in one of the
                    /// following formats: * `projects/{project}/locations/{location}` *
                    /// `folders/{folder}/locations/{location}` * `organizations/{organization}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("scope", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Scope { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudAuditManager.v1.Data.GenerateAuditScopeReportRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "generate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+scope}/auditScopeReports:generate";

                    /// <summary>Initializes Generate parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("scope", new Google.Apis.Discovery.Parameter
                        {
                            Name = "scope",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^folders/[^/]+/locations/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the OperationDetails resource.</summary>
            public virtual OperationDetailsResource OperationDetails { get; }

            /// <summary>The "operationDetails" collection of methods.</summary>
            public class OperationDetailsResource
            {
                private const string Resource = "operationDetails";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public OperationDetailsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets details about the long-running operation to generate audit reports.</summary>
                /// <param name="name">The name of the operation resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details about the long-running operation to generate audit reports.</summary>
                public class GetRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.Operation>
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
                            Pattern = @"^folders/[^/]+/locations/[^/]+/operationDetails/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the OperationIds resource.</summary>
            public virtual OperationIdsResource OperationIds { get; }

            /// <summary>The "operationIds" collection of methods.</summary>
            public class OperationIdsResource
            {
                private const string Resource = "operationIds";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public OperationIdsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets details about the long-running operation to generate audit reports.</summary>
                /// <param name="name">The name of the operation resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details about the long-running operation to generate audit reports.</summary>
                public class GetRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.Operation>
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
                            Pattern = @"^folders/[^/]+/locations/[^/]+/operationIds/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the ResourceEnrollmentStatuses resource.</summary>
            public virtual ResourceEnrollmentStatusesResource ResourceEnrollmentStatuses { get; }

            /// <summary>The "resourceEnrollmentStatuses" collection of methods.</summary>
            public class ResourceEnrollmentStatusesResource
            {
                private const string Resource = "resourceEnrollmentStatuses";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ResourceEnrollmentStatusesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets a resource and its enrollment status.</summary>
                /// <param name="name">
                /// Required. Name of the resource enrollment status, in one of the following formats: *
                /// `folders/{folder}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}` *
                /// `projects/{project}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}` *
                /// `organizations/{organization}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a resource and its enrollment status.</summary>
                public class GetRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.ResourceEnrollmentStatus>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the resource enrollment status, in one of the following formats: *
                    /// `folders/{folder}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}`
                    /// *
                    /// `projects/{project}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}`
                    /// *
                    /// `organizations/{organization}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}`
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
                            Pattern = @"^folders/[^/]+/locations/[^/]+/resourceEnrollmentStatuses/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists all the folders and projects in an organization or folder, along with their enrollments.
                /// </summary>
                /// <param name="parent">
                /// Required. Parent organization or folder to list enrollment statuses for, in one of the following
                /// formats: * `folders/{folder}/locations/{location}` *
                /// `organizations/{organization}/locations/{location}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists all the folders and projects in an organization or folder, along with their enrollments.
                /// </summary>
                public class ListRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.ListResourceEnrollmentStatusesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent organization or folder to list enrollment statuses for, in one of the following
                    /// formats: * `folders/{folder}/locations/{location}` *
                    /// `organizations/{organization}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Maximum number of items to return in a single page. The service might return fewer
                    /// items than this value. If unspecified, the service picks an appropriate default. The maximum
                    /// value is 100; values above 100 are reduced to 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous call, to retrieve the next page of results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/resourceEnrollmentStatuses";

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
                            Pattern = @"^folders/[^/]+/locations/[^/]+$",
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

            /// <summary>Gets the Standards resource.</summary>
            public virtual StandardsResource Standards { get; }

            /// <summary>The "standards" collection of methods.</summary>
            public class StandardsResource
            {
                private const string Resource = "standards";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public StandardsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Controls = new ControlsResource(service);
                }

                /// <summary>Gets the Controls resource.</summary>
                public virtual ControlsResource Controls { get; }

                /// <summary>The "controls" collection of methods.</summary>
                public class ControlsResource
                {
                    private const string Resource = "controls";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ControlsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Lists the controls that you must implement to become compliant to a regulatory standard.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. Standard to list controls for, in one of the following formats: *
                    /// `projects/{project}/locations/{location}/standards/{standard}` *
                    /// `folders/{folder}/locations/{location}/standards/{standard}` *
                    /// `organizations/{organization}/locations/{location}/standards/{standard}`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>
                    /// Lists the controls that you must implement to become compliant to a regulatory standard.
                    /// </summary>
                    public class ListRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.ListControlsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Standard to list controls for, in one of the following formats: *
                        /// `projects/{project}/locations/{location}/standards/{standard}` *
                        /// `folders/{folder}/locations/{location}/standards/{standard}` *
                        /// `organizations/{organization}/locations/{location}/standards/{standard}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Maximum number of items to return in a single page. The service might return fewer
                        /// items than this value. If unspecified, the service picks an appropriate default. The maximum
                        /// value is 100; values above 100 are reduced to 100.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous call, to retrieve the next page of results.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/controls";

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
                                Pattern = @"^folders/[^/]+/locations/[^/]+/standards/[^/]+$",
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

            /// <summary>
            /// Adds your project, folder, or organization to Audit Manager. This method creates the Audit Manager
            /// service agent in your workload and grants required permissions to the service agent. If you make this
            /// request on a workload that's already enrolled, then this method overrides the existing set of
            /// destinations.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="scope">
            /// Required. Organization, folder, or project to enroll in Audit Manager, in one of the following formats:
            /// * `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
            /// `organizations/{organization}/locations/{location}`
            /// </param>
            public virtual EnrollResourceRequest EnrollResource(Google.Apis.CloudAuditManager.v1.Data.EnrollResourceRequest body, string scope)
            {
                return new EnrollResourceRequest(this.service, body, scope);
            }

            /// <summary>
            /// Adds your project, folder, or organization to Audit Manager. This method creates the Audit Manager
            /// service agent in your workload and grants required permissions to the service agent. If you make this
            /// request on a workload that's already enrolled, then this method overrides the existing set of
            /// destinations.
            /// </summary>
            public class EnrollResourceRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.Enrollment>
            {
                /// <summary>Constructs a new EnrollResource request.</summary>
                public EnrollResourceRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAuditManager.v1.Data.EnrollResourceRequest body, string scope) : base(service)
                {
                    Scope = scope;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Organization, folder, or project to enroll in Audit Manager, in one of the following
                /// formats: * `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
                /// `organizations/{organization}/locations/{location}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("scope", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Scope { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudAuditManager.v1.Data.EnrollResourceRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "enrollResource";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+scope}:enrollResource";

                /// <summary>Initializes EnrollResource parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("scope", new Google.Apis.Discovery.Parameter
                    {
                        Name = "scope",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^folders/[^/]+/locations/[^/]+$",
                    });
                }
            }
        }
    }

    /// <summary>The "organizations" collection of methods.</summary>
    public class OrganizationsResource
    {
        private const string Resource = "organizations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OrganizationsResource(Google.Apis.Services.IClientService service)
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
                AuditReports = new AuditReportsResource(service);
                AuditSchedules = new AuditSchedulesResource(service);
                AuditScopeReports = new AuditScopeReportsResource(service);
                OperationDetails = new OperationDetailsResource(service);
                OperationIds = new OperationIdsResource(service);
                Operations = new OperationsResource(service);
                ResourceEnrollmentStatuses = new ResourceEnrollmentStatusesResource(service);
                Standards = new StandardsResource(service);
            }

            /// <summary>Gets the AuditReports resource.</summary>
            public virtual AuditReportsResource AuditReports { get; }

            /// <summary>The "auditReports" collection of methods.</summary>
            public class AuditReportsResource
            {
                private const string Resource = "auditReports";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AuditReportsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Registers audit report generation requests. This method returns the operation identifier that you
                /// can use to track the report generation progress.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="scope">
                /// Required. Organization, folder, or project that the audit applies to, in one of the following
                /// formats: * `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
                /// `organizations/{organization}/locations/{location}`
                /// </param>
                public virtual GenerateRequest Generate(Google.Apis.CloudAuditManager.v1.Data.GenerateAuditReportRequest body, string scope)
                {
                    return new GenerateRequest(this.service, body, scope);
                }

                /// <summary>
                /// Registers audit report generation requests. This method returns the operation identifier that you
                /// can use to track the report generation progress.
                /// </summary>
                public class GenerateRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Generate request.</summary>
                    public GenerateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAuditManager.v1.Data.GenerateAuditReportRequest body, string scope) : base(service)
                    {
                        Scope = scope;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Organization, folder, or project that the audit applies to, in one of the following
                    /// formats: * `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
                    /// `organizations/{organization}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("scope", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Scope { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudAuditManager.v1.Data.GenerateAuditReportRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "generate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+scope}/auditReports:generate";

                    /// <summary>Initializes Generate parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("scope", new Google.Apis.Discovery.Parameter
                        {
                            Name = "scope",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^organizations/[^/]+/locations/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets the full metadata and findings for an audit report.</summary>
                /// <param name="name">
                /// Required. Name of the audit report, in one of the following formats: *
                /// `projects/{project}/locations/{location}/auditReports/{audit_report}` *
                /// `folders/{folder}/locations/{location}/auditReports/{audit_report}` *
                /// `organizations/{organization}/locations/{location}/auditReports/{audit_report}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets the full metadata and findings for an audit report.</summary>
                public class GetRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.AuditReport>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the audit report, in one of the following formats: *
                    /// `projects/{project}/locations/{location}/auditReports/{audit_report}` *
                    /// `folders/{folder}/locations/{location}/auditReports/{audit_report}` *
                    /// `organizations/{organization}/locations/{location}/auditReports/{audit_report}`
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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/auditReports/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists the audit reports for the organization, folder, or project that you specify as the parent
                /// scope.
                /// </summary>
                /// <param name="parent">
                /// Required. Parent organization, folder, or project to list reports for, in one of the following
                /// formats: * `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
                /// `organizations/{organization}/locations/{location}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists the audit reports for the organization, folder, or project that you specify as the parent
                /// scope.
                /// </summary>
                public class ListRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.ListAuditReportsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent organization, folder, or project to list reports for, in one of the following
                    /// formats: * `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
                    /// `organizations/{organization}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Maximum number of items to return in a single page. The service might return fewer
                    /// items than this value. If unspecified, the service picks an appropriate default. The maximum
                    /// value is 100; values above 100 are reduced to 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous call, to retrieve the next page of results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/auditReports";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+$",
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

            /// <summary>Gets the AuditSchedules resource.</summary>
            public virtual AuditSchedulesResource AuditSchedules { get; }

            /// <summary>The "auditSchedules" collection of methods.</summary>
            public class AuditSchedulesResource
            {
                private const string Resource = "auditSchedules";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AuditSchedulesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new audit schedule in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Project or folder that this audit schedule is for, in one of the following formats: *
                /// `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudAuditManager.v1.Data.AuditSchedule body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new audit schedule in a given project and location.</summary>
                public class CreateRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.AuditSchedule>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAuditManager.v1.Data.AuditSchedule body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Project or folder that this audit schedule is for, in one of the following formats: *
                    /// `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. ID to use for the audit schedule, which becomes the final component of the audit
                    /// schedule's resource name.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("auditScheduleId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string AuditScheduleId { get; set; }

                    /// <summary>
                    /// Optional. If `true`, only validates the request and does not create the audit schedule. This
                    /// executes standard request validation (such as schema, framework existence, scope, and IAM
                    /// checks) and skips the apply phase. Use this field for the following purposes: * **Infrastructure
                    /// as Code (IaC)**: Allow tools like Terraform to run dry-run mutations (e.g., `terraform plan`)
                    /// without creating real resources or incurring costs. * **User Interface Validation**: Enable
                    /// real-time form and permission validation in custom UIs before submitting requests. * **CI/CD
                    /// &amp;amp; Automation**: Test your scripts, permissions, and parameters safely without consuming
                    /// resource quotas.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudAuditManager.v1.Data.AuditSchedule Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/auditSchedules";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("auditScheduleId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "auditScheduleId",
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

                /// <summary>Gets details of a single audit schedule.</summary>
                /// <param name="name">
                /// Required. Name of the audit schedule to retrieve, in one of the following formats: *
                /// `projects/{project}/locations/{location}/auditSchedules/{audit_schedule}` *
                /// `folders/{folder}/locations/{location}/auditSchedules/{audit_schedule}` *
                /// `organizations/{organization}/locations/{location}/auditSchedules/{audit_schedule}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single audit schedule.</summary>
                public class GetRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.AuditSchedule>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the audit schedule to retrieve, in one of the following formats: *
                    /// `projects/{project}/locations/{location}/auditSchedules/{audit_schedule}` *
                    /// `folders/{folder}/locations/{location}/auditSchedules/{audit_schedule}` *
                    /// `organizations/{organization}/locations/{location}/auditSchedules/{audit_schedule}`
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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/auditSchedules/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists audit schedules in a given project and location.</summary>
                /// <param name="parent">
                /// Required. Parent for the audit schedule, in one of the following formats: *
                /// `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
                /// `organizations/{organization}/locations/{location}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists audit schedules in a given project and location.</summary>
                public class ListRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.ListAuditSchedulesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent for the audit schedule, in one of the following formats: *
                    /// `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
                    /// `organizations/{organization}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Maximum number of items to return in a single page. The service might return fewer
                    /// items than this value. If unspecified, the service picks an appropriate default. The maximum
                    /// value is 100; values above 100 are reduced to 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous call, to retrieve the next page of results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/auditSchedules";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+$",
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

                /// <summary>Updates an existing audit schedule.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. Unique identifier for the audit schedule. Format:
                /// projects/{project}/locations/{location}/auditSchedules/{audit_schedule}
                /// folders/{folder}/locations/{location}/auditSchedules/{audit_schedule}
                /// organizations/{organization}/locations/{location}/auditSchedules/{audit_schedule}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudAuditManager.v1.Data.AuditSchedule body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates an existing audit schedule.</summary>
                public class PatchRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.AuditSchedule>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAuditManager.v1.Data.AuditSchedule body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. Unique identifier for the audit schedule. Format:
                    /// projects/{project}/locations/{location}/auditSchedules/{audit_schedule}
                    /// folders/{folder}/locations/{location}/auditSchedules/{audit_schedule}
                    /// organizations/{organization}/locations/{location}/auditSchedules/{audit_schedule}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Optional. List of fields to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// Optional. If `true`, only validates the request and does not update the audit schedule. This
                    /// executes standard request validation (such as schema, framework existence, scope, and IAM
                    /// checks) and skips the apply phase. Use this field for the following purposes: * **Infrastructure
                    /// as Code (IaC)**: Allow tools like Terraform to run dry-run mutations (e.g., `terraform plan`)
                    /// without creating real resources or incurring costs. * **User Interface Validation**: Enable
                    /// real-time form and permission validation in custom UIs before submitting requests. * **CI/CD
                    /// &amp;amp; Automation**: Test your scripts, permissions, and parameters safely without consuming
                    /// resource quotas.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudAuditManager.v1.Data.AuditSchedule Body { get; set; }

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/auditSchedules/[^/]+$",
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

            /// <summary>Gets the AuditScopeReports resource.</summary>
            public virtual AuditScopeReportsResource AuditScopeReports { get; }

            /// <summary>The "auditScopeReports" collection of methods.</summary>
            public class AuditScopeReportsResource
            {
                private const string Resource = "auditScopeReports";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AuditScopeReportsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Generates an audit scope report for the given standard. The report includes the following: * The
                /// technical attributes and constraints that Audit Manager uses to verify your compliance with a
                /// framework. * A list of Google Cloud services and resources that are within the scope of the
                /// framework.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="scope">
                /// Required. Project or folder that the audit scope report is generated for, in one of the following
                /// formats: * `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
                /// `organizations/{organization}/locations/{location}`
                /// </param>
                public virtual GenerateRequest Generate(Google.Apis.CloudAuditManager.v1.Data.GenerateAuditScopeReportRequest body, string scope)
                {
                    return new GenerateRequest(this.service, body, scope);
                }

                /// <summary>
                /// Generates an audit scope report for the given standard. The report includes the following: * The
                /// technical attributes and constraints that Audit Manager uses to verify your compliance with a
                /// framework. * A list of Google Cloud services and resources that are within the scope of the
                /// framework.
                /// </summary>
                public class GenerateRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.AuditScopeReport>
                {
                    /// <summary>Constructs a new Generate request.</summary>
                    public GenerateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAuditManager.v1.Data.GenerateAuditScopeReportRequest body, string scope) : base(service)
                    {
                        Scope = scope;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Project or folder that the audit scope report is generated for, in one of the
                    /// following formats: * `projects/{project}/locations/{location}` *
                    /// `folders/{folder}/locations/{location}` * `organizations/{organization}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("scope", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Scope { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudAuditManager.v1.Data.GenerateAuditScopeReportRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "generate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+scope}/auditScopeReports:generate";

                    /// <summary>Initializes Generate parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("scope", new Google.Apis.Discovery.Parameter
                        {
                            Name = "scope",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^organizations/[^/]+/locations/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the OperationDetails resource.</summary>
            public virtual OperationDetailsResource OperationDetails { get; }

            /// <summary>The "operationDetails" collection of methods.</summary>
            public class OperationDetailsResource
            {
                private const string Resource = "operationDetails";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public OperationDetailsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets details about the long-running operation to generate audit reports.</summary>
                /// <param name="name">The name of the operation resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details about the long-running operation to generate audit reports.</summary>
                public class GetRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.Operation>
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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/operationDetails/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the OperationIds resource.</summary>
            public virtual OperationIdsResource OperationIds { get; }

            /// <summary>The "operationIds" collection of methods.</summary>
            public class OperationIdsResource
            {
                private const string Resource = "operationIds";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public OperationIdsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets details about the long-running operation to generate audit reports.</summary>
                /// <param name="name">The name of the operation resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details about the long-running operation to generate audit reports.</summary>
                public class GetRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.Operation>
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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/operationIds/[^/]+$",
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
                public virtual CancelRequest Cancel(Google.Apis.CloudAuditManager.v1.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAuditManager.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudAuditManager.v1.Data.CancelOperationRequest Body { get; set; }

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/operations/[^/]+$",
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
                public class DeleteRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.Empty>
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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/operations/[^/]+$",
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
                public class GetRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.Operation>
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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/operations/[^/]+$",
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
                public class ListRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.ListOperationsResponse>
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
                    /// When set to `true`, operations that are reachable are returned as normal, and those that are
                    /// unreachable are returned in the ListOperationsResponse.unreachable field. This can only be
                    /// `true` when reading across collections. For example, when `parent` is set to
                    /// `"projects/example/locations/-"`. This field is not supported by default and will result in an
                    /// `UNIMPLEMENTED` error if set unless explicitly documented otherwise in service or product
                    /// specific documentation.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("returnPartialSuccess", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ReturnPartialSuccess { get; set; }

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+$",
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

            /// <summary>Gets the ResourceEnrollmentStatuses resource.</summary>
            public virtual ResourceEnrollmentStatusesResource ResourceEnrollmentStatuses { get; }

            /// <summary>The "resourceEnrollmentStatuses" collection of methods.</summary>
            public class ResourceEnrollmentStatusesResource
            {
                private const string Resource = "resourceEnrollmentStatuses";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ResourceEnrollmentStatusesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets a resource and its enrollment status.</summary>
                /// <param name="name">
                /// Required. Name of the resource enrollment status, in one of the following formats: *
                /// `folders/{folder}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}` *
                /// `projects/{project}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}` *
                /// `organizations/{organization}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a resource and its enrollment status.</summary>
                public class GetRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.ResourceEnrollmentStatus>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the resource enrollment status, in one of the following formats: *
                    /// `folders/{folder}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}`
                    /// *
                    /// `projects/{project}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}`
                    /// *
                    /// `organizations/{organization}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}`
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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/resourceEnrollmentStatuses/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists all the folders and projects in an organization or folder, along with their enrollments.
                /// </summary>
                /// <param name="parent">
                /// Required. Parent organization or folder to list enrollment statuses for, in one of the following
                /// formats: * `folders/{folder}/locations/{location}` *
                /// `organizations/{organization}/locations/{location}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists all the folders and projects in an organization or folder, along with their enrollments.
                /// </summary>
                public class ListRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.ListResourceEnrollmentStatusesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent organization or folder to list enrollment statuses for, in one of the following
                    /// formats: * `folders/{folder}/locations/{location}` *
                    /// `organizations/{organization}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Maximum number of items to return in a single page. The service might return fewer
                    /// items than this value. If unspecified, the service picks an appropriate default. The maximum
                    /// value is 100; values above 100 are reduced to 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous call, to retrieve the next page of results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/resourceEnrollmentStatuses";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+$",
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

            /// <summary>Gets the Standards resource.</summary>
            public virtual StandardsResource Standards { get; }

            /// <summary>The "standards" collection of methods.</summary>
            public class StandardsResource
            {
                private const string Resource = "standards";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public StandardsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Controls = new ControlsResource(service);
                }

                /// <summary>Gets the Controls resource.</summary>
                public virtual ControlsResource Controls { get; }

                /// <summary>The "controls" collection of methods.</summary>
                public class ControlsResource
                {
                    private const string Resource = "controls";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ControlsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Lists the controls that you must implement to become compliant to a regulatory standard.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. Standard to list controls for, in one of the following formats: *
                    /// `projects/{project}/locations/{location}/standards/{standard}` *
                    /// `folders/{folder}/locations/{location}/standards/{standard}` *
                    /// `organizations/{organization}/locations/{location}/standards/{standard}`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>
                    /// Lists the controls that you must implement to become compliant to a regulatory standard.
                    /// </summary>
                    public class ListRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.ListControlsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Standard to list controls for, in one of the following formats: *
                        /// `projects/{project}/locations/{location}/standards/{standard}` *
                        /// `folders/{folder}/locations/{location}/standards/{standard}` *
                        /// `organizations/{organization}/locations/{location}/standards/{standard}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Maximum number of items to return in a single page. The service might return fewer
                        /// items than this value. If unspecified, the service picks an appropriate default. The maximum
                        /// value is 100; values above 100 are reduced to 100.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous call, to retrieve the next page of results.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/controls";

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
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/standards/[^/]+$",
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

            /// <summary>
            /// Adds your project, folder, or organization to Audit Manager. This method creates the Audit Manager
            /// service agent in your workload and grants required permissions to the service agent. If you make this
            /// request on a workload that's already enrolled, then this method overrides the existing set of
            /// destinations.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="scope">
            /// Required. Organization, folder, or project to enroll in Audit Manager, in one of the following formats:
            /// * `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
            /// `organizations/{organization}/locations/{location}`
            /// </param>
            public virtual EnrollResourceRequest EnrollResource(Google.Apis.CloudAuditManager.v1.Data.EnrollResourceRequest body, string scope)
            {
                return new EnrollResourceRequest(this.service, body, scope);
            }

            /// <summary>
            /// Adds your project, folder, or organization to Audit Manager. This method creates the Audit Manager
            /// service agent in your workload and grants required permissions to the service agent. If you make this
            /// request on a workload that's already enrolled, then this method overrides the existing set of
            /// destinations.
            /// </summary>
            public class EnrollResourceRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.Enrollment>
            {
                /// <summary>Constructs a new EnrollResource request.</summary>
                public EnrollResourceRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAuditManager.v1.Data.EnrollResourceRequest body, string scope) : base(service)
                {
                    Scope = scope;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Organization, folder, or project to enroll in Audit Manager, in one of the following
                /// formats: * `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
                /// `organizations/{organization}/locations/{location}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("scope", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Scope { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudAuditManager.v1.Data.EnrollResourceRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "enrollResource";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+scope}:enrollResource";

                /// <summary>Initializes EnrollResource parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("scope", new Google.Apis.Discovery.Parameter
                    {
                        Name = "scope",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/locations/[^/]+$",
                    });
                }
            }
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
                AuditReports = new AuditReportsResource(service);
                AuditSchedules = new AuditSchedulesResource(service);
                AuditScopeReports = new AuditScopeReportsResource(service);
                OperationDetails = new OperationDetailsResource(service);
                OperationIds = new OperationIdsResource(service);
                Operations = new OperationsResource(service);
                ResourceEnrollmentStatuses = new ResourceEnrollmentStatusesResource(service);
                Standards = new StandardsResource(service);
            }

            /// <summary>Gets the AuditReports resource.</summary>
            public virtual AuditReportsResource AuditReports { get; }

            /// <summary>The "auditReports" collection of methods.</summary>
            public class AuditReportsResource
            {
                private const string Resource = "auditReports";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AuditReportsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Registers audit report generation requests. This method returns the operation identifier that you
                /// can use to track the report generation progress.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="scope">
                /// Required. Organization, folder, or project that the audit applies to, in one of the following
                /// formats: * `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
                /// `organizations/{organization}/locations/{location}`
                /// </param>
                public virtual GenerateRequest Generate(Google.Apis.CloudAuditManager.v1.Data.GenerateAuditReportRequest body, string scope)
                {
                    return new GenerateRequest(this.service, body, scope);
                }

                /// <summary>
                /// Registers audit report generation requests. This method returns the operation identifier that you
                /// can use to track the report generation progress.
                /// </summary>
                public class GenerateRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Generate request.</summary>
                    public GenerateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAuditManager.v1.Data.GenerateAuditReportRequest body, string scope) : base(service)
                    {
                        Scope = scope;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Organization, folder, or project that the audit applies to, in one of the following
                    /// formats: * `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
                    /// `organizations/{organization}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("scope", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Scope { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudAuditManager.v1.Data.GenerateAuditReportRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "generate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+scope}/auditReports:generate";

                    /// <summary>Initializes Generate parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("scope", new Google.Apis.Discovery.Parameter
                        {
                            Name = "scope",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets the full metadata and findings for an audit report.</summary>
                /// <param name="name">
                /// Required. Name of the audit report, in one of the following formats: *
                /// `projects/{project}/locations/{location}/auditReports/{audit_report}` *
                /// `folders/{folder}/locations/{location}/auditReports/{audit_report}` *
                /// `organizations/{organization}/locations/{location}/auditReports/{audit_report}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets the full metadata and findings for an audit report.</summary>
                public class GetRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.AuditReport>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the audit report, in one of the following formats: *
                    /// `projects/{project}/locations/{location}/auditReports/{audit_report}` *
                    /// `folders/{folder}/locations/{location}/auditReports/{audit_report}` *
                    /// `organizations/{organization}/locations/{location}/auditReports/{audit_report}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/auditReports/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists the audit reports for the organization, folder, or project that you specify as the parent
                /// scope.
                /// </summary>
                /// <param name="parent">
                /// Required. Parent organization, folder, or project to list reports for, in one of the following
                /// formats: * `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
                /// `organizations/{organization}/locations/{location}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists the audit reports for the organization, folder, or project that you specify as the parent
                /// scope.
                /// </summary>
                public class ListRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.ListAuditReportsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent organization, folder, or project to list reports for, in one of the following
                    /// formats: * `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
                    /// `organizations/{organization}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Maximum number of items to return in a single page. The service might return fewer
                    /// items than this value. If unspecified, the service picks an appropriate default. The maximum
                    /// value is 100; values above 100 are reduced to 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous call, to retrieve the next page of results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/auditReports";

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

            /// <summary>Gets the AuditSchedules resource.</summary>
            public virtual AuditSchedulesResource AuditSchedules { get; }

            /// <summary>The "auditSchedules" collection of methods.</summary>
            public class AuditSchedulesResource
            {
                private const string Resource = "auditSchedules";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AuditSchedulesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new audit schedule in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Project or folder that this audit schedule is for, in one of the following formats: *
                /// `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudAuditManager.v1.Data.AuditSchedule body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new audit schedule in a given project and location.</summary>
                public class CreateRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.AuditSchedule>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAuditManager.v1.Data.AuditSchedule body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Project or folder that this audit schedule is for, in one of the following formats: *
                    /// `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. ID to use for the audit schedule, which becomes the final component of the audit
                    /// schedule's resource name.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("auditScheduleId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string AuditScheduleId { get; set; }

                    /// <summary>
                    /// Optional. If `true`, only validates the request and does not create the audit schedule. This
                    /// executes standard request validation (such as schema, framework existence, scope, and IAM
                    /// checks) and skips the apply phase. Use this field for the following purposes: * **Infrastructure
                    /// as Code (IaC)**: Allow tools like Terraform to run dry-run mutations (e.g., `terraform plan`)
                    /// without creating real resources or incurring costs. * **User Interface Validation**: Enable
                    /// real-time form and permission validation in custom UIs before submitting requests. * **CI/CD
                    /// &amp;amp; Automation**: Test your scripts, permissions, and parameters safely without consuming
                    /// resource quotas.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudAuditManager.v1.Data.AuditSchedule Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/auditSchedules";

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
                        RequestParameters.Add("auditScheduleId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "auditScheduleId",
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

                /// <summary>Gets details of a single audit schedule.</summary>
                /// <param name="name">
                /// Required. Name of the audit schedule to retrieve, in one of the following formats: *
                /// `projects/{project}/locations/{location}/auditSchedules/{audit_schedule}` *
                /// `folders/{folder}/locations/{location}/auditSchedules/{audit_schedule}` *
                /// `organizations/{organization}/locations/{location}/auditSchedules/{audit_schedule}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single audit schedule.</summary>
                public class GetRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.AuditSchedule>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the audit schedule to retrieve, in one of the following formats: *
                    /// `projects/{project}/locations/{location}/auditSchedules/{audit_schedule}` *
                    /// `folders/{folder}/locations/{location}/auditSchedules/{audit_schedule}` *
                    /// `organizations/{organization}/locations/{location}/auditSchedules/{audit_schedule}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/auditSchedules/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists audit schedules in a given project and location.</summary>
                /// <param name="parent">
                /// Required. Parent for the audit schedule, in one of the following formats: *
                /// `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
                /// `organizations/{organization}/locations/{location}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists audit schedules in a given project and location.</summary>
                public class ListRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.ListAuditSchedulesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent for the audit schedule, in one of the following formats: *
                    /// `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
                    /// `organizations/{organization}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Maximum number of items to return in a single page. The service might return fewer
                    /// items than this value. If unspecified, the service picks an appropriate default. The maximum
                    /// value is 100; values above 100 are reduced to 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous call, to retrieve the next page of results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/auditSchedules";

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

                /// <summary>Updates an existing audit schedule.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. Unique identifier for the audit schedule. Format:
                /// projects/{project}/locations/{location}/auditSchedules/{audit_schedule}
                /// folders/{folder}/locations/{location}/auditSchedules/{audit_schedule}
                /// organizations/{organization}/locations/{location}/auditSchedules/{audit_schedule}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudAuditManager.v1.Data.AuditSchedule body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates an existing audit schedule.</summary>
                public class PatchRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.AuditSchedule>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAuditManager.v1.Data.AuditSchedule body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. Unique identifier for the audit schedule. Format:
                    /// projects/{project}/locations/{location}/auditSchedules/{audit_schedule}
                    /// folders/{folder}/locations/{location}/auditSchedules/{audit_schedule}
                    /// organizations/{organization}/locations/{location}/auditSchedules/{audit_schedule}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Optional. List of fields to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// Optional. If `true`, only validates the request and does not update the audit schedule. This
                    /// executes standard request validation (such as schema, framework existence, scope, and IAM
                    /// checks) and skips the apply phase. Use this field for the following purposes: * **Infrastructure
                    /// as Code (IaC)**: Allow tools like Terraform to run dry-run mutations (e.g., `terraform plan`)
                    /// without creating real resources or incurring costs. * **User Interface Validation**: Enable
                    /// real-time form and permission validation in custom UIs before submitting requests. * **CI/CD
                    /// &amp;amp; Automation**: Test your scripts, permissions, and parameters safely without consuming
                    /// resource quotas.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudAuditManager.v1.Data.AuditSchedule Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/auditSchedules/[^/]+$",
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

            /// <summary>Gets the AuditScopeReports resource.</summary>
            public virtual AuditScopeReportsResource AuditScopeReports { get; }

            /// <summary>The "auditScopeReports" collection of methods.</summary>
            public class AuditScopeReportsResource
            {
                private const string Resource = "auditScopeReports";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AuditScopeReportsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Generates an audit scope report for the given standard. The report includes the following: * The
                /// technical attributes and constraints that Audit Manager uses to verify your compliance with a
                /// framework. * A list of Google Cloud services and resources that are within the scope of the
                /// framework.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="scope">
                /// Required. Project or folder that the audit scope report is generated for, in one of the following
                /// formats: * `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
                /// `organizations/{organization}/locations/{location}`
                /// </param>
                public virtual GenerateRequest Generate(Google.Apis.CloudAuditManager.v1.Data.GenerateAuditScopeReportRequest body, string scope)
                {
                    return new GenerateRequest(this.service, body, scope);
                }

                /// <summary>
                /// Generates an audit scope report for the given standard. The report includes the following: * The
                /// technical attributes and constraints that Audit Manager uses to verify your compliance with a
                /// framework. * A list of Google Cloud services and resources that are within the scope of the
                /// framework.
                /// </summary>
                public class GenerateRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.AuditScopeReport>
                {
                    /// <summary>Constructs a new Generate request.</summary>
                    public GenerateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAuditManager.v1.Data.GenerateAuditScopeReportRequest body, string scope) : base(service)
                    {
                        Scope = scope;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Project or folder that the audit scope report is generated for, in one of the
                    /// following formats: * `projects/{project}/locations/{location}` *
                    /// `folders/{folder}/locations/{location}` * `organizations/{organization}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("scope", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Scope { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudAuditManager.v1.Data.GenerateAuditScopeReportRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "generate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+scope}/auditScopeReports:generate";

                    /// <summary>Initializes Generate parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("scope", new Google.Apis.Discovery.Parameter
                        {
                            Name = "scope",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the OperationDetails resource.</summary>
            public virtual OperationDetailsResource OperationDetails { get; }

            /// <summary>The "operationDetails" collection of methods.</summary>
            public class OperationDetailsResource
            {
                private const string Resource = "operationDetails";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public OperationDetailsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets details about the long-running operation to generate audit reports.</summary>
                /// <param name="name">The name of the operation resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details about the long-running operation to generate audit reports.</summary>
                public class GetRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.Operation>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operationDetails/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the OperationIds resource.</summary>
            public virtual OperationIdsResource OperationIds { get; }

            /// <summary>The "operationIds" collection of methods.</summary>
            public class OperationIdsResource
            {
                private const string Resource = "operationIds";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public OperationIdsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets details about the long-running operation to generate audit reports.</summary>
                /// <param name="name">The name of the operation resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details about the long-running operation to generate audit reports.</summary>
                public class GetRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.Operation>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operationIds/[^/]+$",
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
                public virtual CancelRequest Cancel(Google.Apis.CloudAuditManager.v1.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAuditManager.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudAuditManager.v1.Data.CancelOperationRequest Body { get; set; }

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
                public class DeleteRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.Empty>
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
                public class GetRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.Operation>
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
                public class ListRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.ListOperationsResponse>
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
                    /// When set to `true`, operations that are reachable are returned as normal, and those that are
                    /// unreachable are returned in the ListOperationsResponse.unreachable field. This can only be
                    /// `true` when reading across collections. For example, when `parent` is set to
                    /// `"projects/example/locations/-"`. This field is not supported by default and will result in an
                    /// `UNIMPLEMENTED` error if set unless explicitly documented otherwise in service or product
                    /// specific documentation.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("returnPartialSuccess", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ReturnPartialSuccess { get; set; }

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

            /// <summary>Gets the ResourceEnrollmentStatuses resource.</summary>
            public virtual ResourceEnrollmentStatusesResource ResourceEnrollmentStatuses { get; }

            /// <summary>The "resourceEnrollmentStatuses" collection of methods.</summary>
            public class ResourceEnrollmentStatusesResource
            {
                private const string Resource = "resourceEnrollmentStatuses";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ResourceEnrollmentStatusesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets a resource and its enrollment status.</summary>
                /// <param name="name">
                /// Required. Name of the resource enrollment status, in one of the following formats: *
                /// `folders/{folder}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}` *
                /// `projects/{project}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}` *
                /// `organizations/{organization}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a resource and its enrollment status.</summary>
                public class GetRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.ResourceEnrollmentStatus>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the resource enrollment status, in one of the following formats: *
                    /// `folders/{folder}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}`
                    /// *
                    /// `projects/{project}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}`
                    /// *
                    /// `organizations/{organization}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/resourceEnrollmentStatuses/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Standards resource.</summary>
            public virtual StandardsResource Standards { get; }

            /// <summary>The "standards" collection of methods.</summary>
            public class StandardsResource
            {
                private const string Resource = "standards";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public StandardsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Controls = new ControlsResource(service);
                }

                /// <summary>Gets the Controls resource.</summary>
                public virtual ControlsResource Controls { get; }

                /// <summary>The "controls" collection of methods.</summary>
                public class ControlsResource
                {
                    private const string Resource = "controls";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ControlsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Lists the controls that you must implement to become compliant to a regulatory standard.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. Standard to list controls for, in one of the following formats: *
                    /// `projects/{project}/locations/{location}/standards/{standard}` *
                    /// `folders/{folder}/locations/{location}/standards/{standard}` *
                    /// `organizations/{organization}/locations/{location}/standards/{standard}`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>
                    /// Lists the controls that you must implement to become compliant to a regulatory standard.
                    /// </summary>
                    public class ListRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.ListControlsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Standard to list controls for, in one of the following formats: *
                        /// `projects/{project}/locations/{location}/standards/{standard}` *
                        /// `folders/{folder}/locations/{location}/standards/{standard}` *
                        /// `organizations/{organization}/locations/{location}/standards/{standard}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Maximum number of items to return in a single page. The service might return fewer
                        /// items than this value. If unspecified, the service picks an appropriate default. The maximum
                        /// value is 100; values above 100 are reduced to 100.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous call, to retrieve the next page of results.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/controls";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/standards/[^/]+$",
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

            /// <summary>
            /// Adds your project, folder, or organization to Audit Manager. This method creates the Audit Manager
            /// service agent in your workload and grants required permissions to the service agent. If you make this
            /// request on a workload that's already enrolled, then this method overrides the existing set of
            /// destinations.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="scope">
            /// Required. Organization, folder, or project to enroll in Audit Manager, in one of the following formats:
            /// * `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
            /// `organizations/{organization}/locations/{location}`
            /// </param>
            public virtual EnrollResourceRequest EnrollResource(Google.Apis.CloudAuditManager.v1.Data.EnrollResourceRequest body, string scope)
            {
                return new EnrollResourceRequest(this.service, body, scope);
            }

            /// <summary>
            /// Adds your project, folder, or organization to Audit Manager. This method creates the Audit Manager
            /// service agent in your workload and grants required permissions to the service agent. If you make this
            /// request on a workload that's already enrolled, then this method overrides the existing set of
            /// destinations.
            /// </summary>
            public class EnrollResourceRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.Enrollment>
            {
                /// <summary>Constructs a new EnrollResource request.</summary>
                public EnrollResourceRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAuditManager.v1.Data.EnrollResourceRequest body, string scope) : base(service)
                {
                    Scope = scope;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Organization, folder, or project to enroll in Audit Manager, in one of the following
                /// formats: * `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
                /// `organizations/{organization}/locations/{location}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("scope", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Scope { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudAuditManager.v1.Data.EnrollResourceRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "enrollResource";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+scope}:enrollResource";

                /// <summary>Initializes EnrollResource parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("scope", new Google.Apis.Discovery.Parameter
                    {
                        Name = "scope",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+$",
                    });
                }
            }

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.Location>
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

            /// <summary>
            /// Lists information about the supported locations for this service. This method lists locations based on
            /// the resource scope provided in the ListLocationsRequest.name field: * **Global locations**: If `name` is
            /// empty, the method lists the public locations available to all projects. * **Project-specific
            /// locations**: If `name` follows the format `projects/{project}`, the method lists locations visible to
            /// that specific project. This includes public, private, or other project-specific locations enabled for
            /// the project. For gRPC and client library implementations, the resource name is passed as the `name`
            /// field. For direct service calls, the resource name is incorporated into the request path based on the
            /// specific service implementation and version.
            /// </summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>
            /// Lists information about the supported locations for this service. This method lists locations based on
            /// the resource scope provided in the ListLocationsRequest.name field: * **Global locations**: If `name` is
            /// empty, the method lists the public locations available to all projects. * **Project-specific
            /// locations**: If `name` follows the format `projects/{project}`, the method lists locations visible to
            /// that specific project. This includes public, private, or other project-specific locations enabled for
            /// the project. For gRPC and client library implementations, the resource name is passed as the `name`
            /// field. For direct service calls, the resource name is incorporated into the request path based on the
            /// specific service implementation and version.
            /// </summary>
            public class ListRequest : CloudAuditManagerBaseServiceRequest<Google.Apis.CloudAuditManager.v1.Data.ListLocationsResponse>
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
                /// Optional. Do not use this field unless explicitly documented otherwise. This is primarily for
                /// internal usage.
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
namespace Google.Apis.CloudAuditManager.v1.Data
{
    /// <summary>An audit report.</summary>
    public class AuditReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Compliance framework to use for the audit report. For example, `CIS_GCP_FOUNDATIONS_V1_2_0`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complianceFramework")]
        public virtual string ComplianceFramework { get; set; }

        /// <summary>
        /// Output only. Deprecated. Compliance standard to be audited against. Use the `compliance_framework` field
        /// instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complianceStandard")]
        public virtual string ComplianceStandard { get; set; }

        /// <summary>Output only. Overall status of the controls.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlDetails")]
        public virtual System.Collections.Generic.IList<ControlDetails> ControlDetails { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Creation time of the audit report.</summary>
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

        /// <summary>Output only. Cloud Storage bucket where the audit report is uploaded to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationDetails")]
        public virtual DestinationDetails DestinationDetails { get; set; }

        /// <summary>
        /// Identifier. Name of the audit report, in one of the following formats: *
        /// `projects/{project}/locations/{location}/auditReports/{audit_report}` *
        /// `folders/{folder}/locations/{location}/auditReports/{audit_report}` *
        /// `organizations/{organization}/locations/{location}/auditReports/{audit_report}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Client operation ID for the audit report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; }

        /// <summary>Output only. State of audit report generation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportGenerationState")]
        public virtual string ReportGenerationState { get; set; }

        /// <summary>
        /// Output only. Report summary that includes information about compliance and violation counts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportSummary")]
        public virtual ReportSummary ReportSummary { get; set; }

        /// <summary>
        /// Output only. Organization, folder, or project that the report is generated for, in one of the following
        /// formats: * `projects/{project}/locations/{location}` * `folders/{folder}/locations/{location}` *
        /// `organizations/{organization}/locations/{location}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>
        /// Output only. Project number, folder ID, or organization ID that the audit report was generated for.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopeId")]
        public virtual string ScopeId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An audit schedule, in one of the following formats: *
    /// `projects/{project}/locations/{location}/auditSchedules/{audit_schedule}` *
    /// `folders/{folder}/locations/{location}/auditSchedules/{audit_schedule}`
    /// </summary>
    public class AuditSchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Framework (set of controls) that the audit scope report is generated against. For example,
        /// `NIST_800_53`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complianceFramework")]
        public virtual string ComplianceFramework { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp when the schedule was created.</summary>
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

        /// <summary>Optional. Display name for the audit schedule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. Describes the error if the schedule is in an error state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>
        /// Required. Cloud Storage bucket where Audit Manager can upload the audit report and evidence. The format is
        /// `gs://{bucket_name}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsUri")]
        public virtual string GcsUri { get; set; }

        private string _lastTriggerTimeRaw;

        private object _lastTriggerTime;

        /// <summary>Output only. Timestamp when the audit run was last triggered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastTriggerTime")]
        public virtual string LastTriggerTimeRaw
        {
            get => _lastTriggerTimeRaw;
            set
            {
                _lastTriggerTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastTriggerTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastTriggerTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastTriggerTimeDateTimeOffset instead.")]
        public virtual object LastTriggerTime
        {
            get => _lastTriggerTime;
            set
            {
                _lastTriggerTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastTriggerTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastTriggerTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastTriggerTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastTriggerTimeRaw);
            set => LastTriggerTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Identifier. Unique identifier for the audit schedule. Format:
        /// projects/{project}/locations/{location}/auditSchedules/{audit_schedule}
        /// folders/{folder}/locations/{location}/auditSchedules/{audit_schedule}
        /// organizations/{organization}/locations/{location}/auditSchedules/{audit_schedule}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _nextRunTimeRaw;

        private object _nextRunTime;

        /// <summary>Output only. Calculated timestamp for the next scheduled run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextRunTime")]
        public virtual string NextRunTimeRaw
        {
            get => _nextRunTimeRaw;
            set
            {
                _nextRunTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _nextRunTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="NextRunTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NextRunTimeDateTimeOffset instead.")]
        public virtual object NextRunTime
        {
            get => _nextRunTime;
            set
            {
                _nextRunTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _nextRunTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="NextRunTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NextRunTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NextRunTimeRaw);
            set => NextRunTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Required. Format for the audit report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportFormat")]
        public virtual string ReportFormat { get; set; }

        /// <summary>
        /// Required. Configuration that defines when and how often audit runs are automatically triggered for this
        /// schedule.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleConfig")]
        public virtual ScheduleConfig ScheduleConfig { get; set; }

        /// <summary>
        /// Optional. State of the audit schedule. While most states are managed by the system, you can use
        /// UpdateAuditSchedule to start, pause, or delete the schedule.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Timestamp when the schedule was last updated.</summary>
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

    /// <summary>Audit scope report.</summary>
    public class AuditScopeReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifier. Name for the audit scope report, in one of the following formats: *
        /// `projects/{project}/locations/{location}/auditScopeReports/{audit_scope_report}` *
        /// `folders/{folder}/locations/{location}/auditScopeReports/{audit_scope_report}` *
        /// `organizations/{organization}/locations/{location}/auditScopeReports/{audit_scope_report}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Audit scope report content in byte format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopeReportContents")]
        public virtual string ScopeReportContents { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A control.</summary>
    public class Control : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Regulatory family of the control.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlFamily")]
        public virtual ControlFamily ControlFamily { get; set; }

        /// <summary>Output only. A description of your responsibility for this control.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerResponsibilityDescription")]
        public virtual string CustomerResponsibilityDescription { get; set; }

        /// <summary>Output only. A description of how you can implement your responsibility for this control.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerResponsibilityImplementation")]
        public virtual string CustomerResponsibilityImplementation { get; set; }

        /// <summary>Output only. Description of the control.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. Display name of the control.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. Category that the control belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("family")]
        public virtual string Family { get; set; }

        /// <summary>Output only. A description of Google's responsibility for this control.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleResponsibilityDescription")]
        public virtual string GoogleResponsibilityDescription { get; set; }

        /// <summary>Output only. A description of how Google implements its responsibility for this control.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleResponsibilityImplementation")]
        public virtual string GoogleResponsibilityImplementation { get; set; }

        /// <summary>
        /// Output only. Control identifier that's used to fetch the findings. The identifier is the same as the control
        /// report name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Output only. Who is responsible for implementing this control. Set to one of the following values: `GOOGLE`,
        /// `CUSTOMER`, or `SHARED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responsibilityType")]
        public virtual string ResponsibilityType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evaluation details for a control.</summary>
    public class ControlDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Overall status of the findings for the control.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complianceState")]
        public virtual string ComplianceState { get; set; }

        /// <summary>Control that the findings are being reported for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("control")]
        public virtual Control Control { get; set; }

        /// <summary>
        /// A control report summary that provides a high-level overview of the compliance controls and the assessment
        /// status.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlReportSummary")]
        public virtual ReportSummary ControlReportSummary { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Regulatory family of the control.</summary>
    public class ControlFamily : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Display name of the regulatory control family.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// ID of the regulatory control family. To find the list of supported control families, use the ListControls
        /// method and review the `control_family` field in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("familyId")]
        public virtual string FamilyId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cloud Storage bucket where the audit report is uploaded to.</summary>
    public class DestinationDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URI for the Cloud Storage bucket, in the format `gs://{bucket_name}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsBucketUri")]
        public virtual string GcsBucketUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about the bucket where you want to upload the audit report.</summary>
    public class EligibleDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The location of the Cloud Storage bucket where you want to upload the audit report and evidence during the
        /// GenerateAuditReport API call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eligibleGcsBucket")]
        public virtual string EligibleGcsBucket { get; set; }

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

    /// <summary>Request message for EnrollResource.</summary>
    public class EnrollResourceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Cloud Storage buckets that you can upload your audit reports to during the audit process. When you
        /// enroll an organization or folder, you can choose a Cloud Storage bucket from any project in the organization
        /// or folder. If you run an audit at the project level using the service agent at the organization or folder
        /// level, all the buckets that are associated with the service agent are available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual System.Collections.Generic.IList<EligibleDestination> Destinations { get; set; }

        /// <summary>
        /// Optional. If `true`, only validates the request and does not enroll the resource. This executes standard
        /// request validation (such as schema, IAM, and destination checks) and skips the apply phase. Use this field
        /// for the following purposes: * **Infrastructure as Code (IaC)**: Allow tools like Terraform to run dry-run
        /// mutations (e.g., `terraform plan`) without creating real resources or incurring costs. * **User Interface
        /// Validation**: Enable real-time form and permission validation in custom UIs before submitting requests. *
        /// **CI/CD &amp;amp; Automation**: Test your scripts, permissions, and parameters safely without consuming
        /// resource quotas.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Organization, folder, or project to enroll for audit reports.</summary>
    public class Enrollment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Cloud Storage buckets where you want to upload the audit reports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationDetails")]
        public virtual System.Collections.Generic.IList<DestinationDetails> DestinationDetails { get; set; }

        /// <summary>
        /// Identifier. Name of the enrollment, in one of the following formats: *
        /// `projects/{project}/locations/{location}/enrollments/{enrollment}` *
        /// `folders/{folder}/locations/{location}/enrollments/{enrollment}` *
        /// `organizations/{organization}/locations/{location}/enrollments/{enrollment}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for GenerateAuditReport.</summary>
    public class GenerateAuditReportRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The framework that's used for the audit report. For example, `NIST_800_53`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complianceFramework")]
        public virtual string ComplianceFramework { get; set; }

        /// <summary>
        /// Optional. Deprecated. Compliance standard for the audit report. Use the `compliance_framework` field
        /// instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complianceStandard")]
        public virtual string ComplianceStandard { get; set; }

        /// <summary>
        /// URL for the Cloud Storage bucket where the report and evidence is uploaded. You must select a bucket that
        /// was provided during the enrollment process.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsUri")]
        public virtual string GcsUri { get; set; }

        /// <summary>Required. Format for the audit report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportFormat")]
        public virtual string ReportFormat { get; set; }

        /// <summary>
        /// Optional. If `true`, only validates the request and does not generate the audit report. This executes
        /// standard request validation (such as schema, framework existence, scope, and IAM checks) and skips the apply
        /// phase. Use this field for the following purposes: * **Infrastructure as Code (IaC)**: Allow tools like
        /// Terraform to run dry-run mutations (e.g., `terraform plan`) without creating real resources or incurring
        /// costs. * **User Interface Validation**: Enable real-time form and permission validation in custom UIs before
        /// submitting requests. * **CI/CD &amp;amp; Automation**: Test your scripts, permissions, and parameters safely
        /// without triggering expensive Long-Running Operations (LROs) or consuming resource quotas.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for GenerateAuditScopeReport.</summary>
    public class GenerateAuditScopeReportRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Framework (set of controls) that the audit scope report is generated against. For example,
        /// `NIST_800_53`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complianceFramework")]
        public virtual string ComplianceFramework { get; set; }

        /// <summary>
        /// Optional. Deprecated. The standard (industry or regulatory requirements) that the audit scope report is run
        /// against. Use the `compliance_framework` field instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complianceStandard")]
        public virtual string ComplianceStandard { get; set; }

        /// <summary>Required. Format for the audit scope report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportFormat")]
        public virtual string ReportFormat { get; set; }

        /// <summary>
        /// Optional. If `true`, only validates the request and does not generate the audit scope report. This executes
        /// standard request validation (such as schema, framework existence, scope, and IAM checks) and skips the apply
        /// phase. Use this field for the following purposes: * **Infrastructure as Code (IaC)**: Allow tools like
        /// Terraform to run dry-run mutations (e.g., `terraform plan`) without creating real resources or incurring
        /// costs. * **User Interface Validation**: Enable real-time form and permission validation in custom UIs before
        /// submitting requests. * **CI/CD &amp;amp; Automation**: Test your scripts, permissions, and parameters safely
        /// without consuming resource quotas.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListAuditReports.</summary>
    public class ListAuditReportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Audit reports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditReports")]
        public virtual System.Collections.Generic.IList<AuditReport> AuditReports { get; set; }

        /// <summary>
        /// Output only. A token that you can send as the `page_token` in a subsequent request to retrieve the next page
        /// of results. If this field is empty, there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListAuditSchedules.</summary>
    public class ListAuditSchedulesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of audit schedules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditSchedules")]
        public virtual System.Collections.Generic.IList<AuditSchedule> AuditSchedules { get; set; }

        /// <summary>
        /// A token that you can send as the `page_token` in a subsequent request to retrieve the next page of results.
        /// If this field is empty, there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that can't be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListControls.</summary>
    public class ListControlsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Controls for a given regulatory standard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controls")]
        public virtual System.Collections.Generic.IList<Control> Controls { get; set; }

        /// <summary>
        /// Output only. A token that you can send as the `page_token` in a subsequent request to retrieve the next page
        /// of results. If this field is empty, there are no subsequent pages.
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

        /// <summary>
        /// Unordered list. Unreachable resources. Populated when the request sets
        /// `ListOperationsRequest.return_partial_success` and reads across collections. For example, when attempting to
        /// list all resources across all supported locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListResourceEnrollmentStatuses.</summary>
    public class ListResourceEnrollmentStatusesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. A token that you can send as the `page_token` in a subsequent request to retrieve the next page
        /// of results. If this field is empty, there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Resources with their enrollment status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceEnrollmentStatuses")]
        public virtual System.Collections.Generic.IList<ResourceEnrollmentStatus> ResourceEnrollmentStatuses { get; set; }

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

    /// <summary>Metadata for the long-running operation.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The API version used to start the operation. For example, `v1`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time that the operation was created.</summary>
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

        /// <summary>Output only. Time that the operation finished running.</summary>
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
        /// Output only. Whether you requested that the operation be cancelled. Operations that were cancelled
        /// successfully have an Operation.error value with a status code Code.CANCELLED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedCancellation")]
        public virtual System.Nullable<bool> RequestedCancellation { get; set; }

        /// <summary>Output only. A human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>Output only. A server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Output only. The name of the verb that was executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about the current status of the report-generation process.</summary>
    public class ReportGenerationProgress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Name of the audit report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditReport")]
        public virtual string AuditReport { get; set; }

        /// <summary>
        /// Output only. Cloud Storage bucket where the audit report is uploaded to after the evaluation process is
        /// completed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationGcsBucket")]
        public virtual string DestinationGcsBucket { get; set; }

        /// <summary>
        /// Progress of the evaluation process. The progress is defined in terms of percentage complete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationPercentComplete")]
        public virtual System.Nullable<double> EvaluationPercentComplete { get; set; }

        /// <summary>
        /// Output only. Reason for failure during the audit report generation process. This field is set only if the
        /// `OperationState` attribute is `OPERATION_STATE_FAILED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureReason")]
        public virtual string FailureReason { get; set; }

        /// <summary>
        /// Report generation progress, defined in terms of percentage complete. Until evaluation is complete, this
        /// value is always `0`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportGenerationPercentComplete")]
        public virtual System.Nullable<double> ReportGenerationPercentComplete { get; set; }

        /// <summary>
        /// Report uploading progress, defined in terms of percentage complete. Until evaluation and report generation
        /// are complete, this value is always `0`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportUploadingPercentComplete")]
        public virtual System.Nullable<double> ReportUploadingPercentComplete { get; set; }

        /// <summary>Output only. Current state of execution for report generation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional information about the number of checks that were made during an audit operation.</summary>
    public class ReportSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of compliant checks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compliantCount")]
        public virtual System.Nullable<int> CompliantCount { get; set; }

        /// <summary>Number of checks that can't be performed due to errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCount")]
        public virtual System.Nullable<int> ErrorCount { get; set; }

        /// <summary>Number of checks that require a manual review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualReviewNeededCount")]
        public virtual System.Nullable<int> ManualReviewNeededCount { get; set; }

        /// <summary>Total number of evaluated checks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalCount")]
        public virtual System.Nullable<int> TotalCount { get; set; }

        /// <summary>Number of checks with violations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("violationCount")]
        public virtual System.Nullable<int> ViolationCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An organization, folder, or project with its enrollment status.</summary>
    public class ResourceEnrollmentStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Display name for the organization, folder, or project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. Deprecated. Whether the organization, folder, or project is enrolled. Use `enrollment_state`
        /// instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enrolled")]
        public virtual System.Nullable<bool> Enrolled { get; set; }

        /// <summary>Output only. Enrolled destination details for the organization, folder, or project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enrollment")]
        public virtual Enrollment Enrollment { get; set; }

        /// <summary>Output only. Enrollment state of the organization, folder, or project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enrollmentState")]
        public virtual string EnrollmentState { get; set; }

        /// <summary>
        /// Identifier. Name of the resource enrollment status, in one of the following formats: *
        /// `folders/{folder}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}` *
        /// `projects/{project}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}` *
        /// `organizations/{organization}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Timing and frequency parameters for recurring audit runs.</summary>
    public class ScheduleConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Optional. Date that the schedule stops. If not specified, the schedule runs indefinitely.</summary>
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

        /// <summary>Required. Frequency of audit runs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frequency")]
        public virtual string Frequency { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>
        /// Required. Date and time when the first audit run is triggered. Subsequent runs are based on this time and
        /// the chosen frequency.
        /// </summary>
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

        /// <summary>
        /// Optional. Time zone for the audit schedule in IANA format (for example, `America/New_York`). The time zone
        /// is used to interpret the `start_time` and the `end_time`, and to calculate subsequent run dates. If not
        /// specified, the time zone default is UTC.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

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
