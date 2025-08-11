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

namespace Google.Apis.CloudRun.v1
{
    /// <summary>The CloudRun Service.</summary>
    public class CloudRunService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudRunService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudRunService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Namespaces = new NamespacesResource(this);
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://run.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://run.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "run";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Run Admin API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Run Admin API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Namespaces resource.</summary>
        public virtual NamespacesResource Namespaces { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for CloudRun requests.</summary>
    public abstract class CloudRunBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudRunBaseServiceRequest instance.</summary>
        protected CloudRunBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudRun parameter list.</summary>
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

    /// <summary>The "namespaces" collection of methods.</summary>
    public class NamespacesResource
    {
        private const string Resource = "namespaces";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public NamespacesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Authorizeddomains = new AuthorizeddomainsResource(service);
            Configurations = new ConfigurationsResource(service);
            Domainmappings = new DomainmappingsResource(service);
            Executions = new ExecutionsResource(service);
            Jobs = new JobsResource(service);
            Revisions = new RevisionsResource(service);
            Routes = new RoutesResource(service);
            Services = new ServicesResource(service);
            Tasks = new TasksResource(service);
            Workerpools = new WorkerpoolsResource(service);
        }

        /// <summary>Gets the Authorizeddomains resource.</summary>
        public virtual AuthorizeddomainsResource Authorizeddomains { get; }

        /// <summary>The "authorizeddomains" collection of methods.</summary>
        public class AuthorizeddomainsResource
        {
            private const string Resource = "authorizeddomains";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AuthorizeddomainsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>List authorized domains.</summary>
            /// <param name="parent">Name of the parent Project resource. Example: `projects/myproject`.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>List authorized domains.</summary>
            public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.ListAuthorizedDomainsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Name of the parent Project resource. Example: `projects/myproject`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Maximum results to return per page.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Continuation token for fetching the next page of results.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/domains.cloudrun.com/v1/{+parent}/authorizeddomains";

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
                        Pattern = @"^namespaces/[^/]+$",
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

        /// <summary>Gets the Configurations resource.</summary>
        public virtual ConfigurationsResource Configurations { get; }

        /// <summary>The "configurations" collection of methods.</summary>
        public class ConfigurationsResource
        {
            private const string Resource = "configurations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ConfigurationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Get information about a configuration.</summary>
            /// <param name="name">
            /// The name of the configuration to retrieve. For Cloud Run, replace {namespace_id} with the project ID or
            /// number.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Get information about a configuration.</summary>
            public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Configuration>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The name of the configuration to retrieve. For Cloud Run, replace {namespace_id} with the project ID
                /// or number.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/serving.knative.dev/v1/{+name}";

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
                        Pattern = @"^namespaces/[^/]+/configurations/[^/]+$",
                    });
                }
            }

            /// <summary>List configurations. Results are sorted by creation time, descending.</summary>
            /// <param name="parent">
            /// The namespace from which the configurations should be listed. For Cloud Run, replace {namespace_id} with
            /// the project ID or number.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>List configurations. Results are sorted by creation time, descending.</summary>
            public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.ListConfigurationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// The namespace from which the configurations should be listed. For Cloud Run, replace {namespace_id}
                /// with the project ID or number.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional. Encoded string to continue paging.</summary>
                [Google.Apis.Util.RequestParameterAttribute("continue", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Continue { get; set; }

                /// <summary>Not supported by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("fieldSelector", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string FieldSelector { get; set; }

                /// <summary>Not supported by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("includeUninitialized", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IncludeUninitialized { get; set; }

                /// <summary>
                /// Allows to filter resources based on a label. Supported operations are =, !=, exists, in, and notIn.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("labelSelector", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LabelSelector { get; set; }

                /// <summary>Optional. The maximum number of the records that should be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("limit", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> Limit { get; set; }

                /// <summary>Not supported by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("resourceVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ResourceVersion { get; set; }

                /// <summary>Not supported by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("watch", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> Watch { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/serving.knative.dev/v1/{+parent}/configurations";

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
                        Pattern = @"^namespaces/[^/]+$",
                    });
                    RequestParameters.Add("continue", new Google.Apis.Discovery.Parameter
                    {
                        Name = "continue",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("fieldSelector", new Google.Apis.Discovery.Parameter
                    {
                        Name = "fieldSelector",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("includeUninitialized", new Google.Apis.Discovery.Parameter
                    {
                        Name = "includeUninitialized",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("labelSelector", new Google.Apis.Discovery.Parameter
                    {
                        Name = "labelSelector",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("limit", new Google.Apis.Discovery.Parameter
                    {
                        Name = "limit",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("resourceVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resourceVersion",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("watch", new Google.Apis.Discovery.Parameter
                    {
                        Name = "watch",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Domainmappings resource.</summary>
        public virtual DomainmappingsResource Domainmappings { get; }

        /// <summary>The "domainmappings" collection of methods.</summary>
        public class DomainmappingsResource
        {
            private const string Resource = "domainmappings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DomainmappingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Create a new domain mapping.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The namespace in which the domain mapping should be created. For Cloud Run (fully managed),
            /// replace {namespace} with the project ID or number. It takes the form namespaces/{namespace}. For
            /// example: namespaces/PROJECT_ID
            /// </param>
            public virtual CreateRequest Create(Google.Apis.CloudRun.v1.Data.DomainMapping body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Create a new domain mapping.</summary>
            public class CreateRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.DomainMapping>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v1.Data.DomainMapping body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The namespace in which the domain mapping should be created. For Cloud Run (fully
                /// managed), replace {namespace} with the project ID or number. It takes the form
                /// namespaces/{namespace}. For example: namespaces/PROJECT_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Indicates that the server should validate the request and populate default values without persisting
                /// the request. Supported values: `all`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("dryRun", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string DryRun { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudRun.v1.Data.DomainMapping Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/domains.cloudrun.com/v1/{+parent}/domainmappings";

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
                        Pattern = @"^namespaces/[^/]+$",
                    });
                    RequestParameters.Add("dryRun", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dryRun",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Delete a domain mapping.</summary>
            /// <param name="name">
            /// Required. The name of the domain mapping to delete. For Cloud Run (fully managed), replace {namespace}
            /// with the project ID or number. It takes the form namespaces/{namespace}. For example:
            /// namespaces/PROJECT_ID
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Delete a domain mapping.</summary>
            public class DeleteRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Status>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the domain mapping to delete. For Cloud Run (fully managed), replace
                /// {namespace} with the project ID or number. It takes the form namespaces/{namespace}. For example:
                /// namespaces/PROJECT_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Cloud Run currently ignores this parameter.</summary>
                [Google.Apis.Util.RequestParameterAttribute("apiVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual new string ApiVersion { get; set; }

                /// <summary>
                /// Indicates that the server should validate the request and populate default values without persisting
                /// the request. Supported values: `all`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("dryRun", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string DryRun { get; set; }

                /// <summary>Cloud Run currently ignores this parameter.</summary>
                [Google.Apis.Util.RequestParameterAttribute("kind", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Kind { get; set; }

                /// <summary>
                /// Specifies the propagation policy of delete. Cloud Run currently ignores this setting, and deletes in
                /// the background. Please see kubernetes.io/docs/concepts/architecture/garbage-collection/ for more
                /// information.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("propagationPolicy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PropagationPolicy { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/domains.cloudrun.com/v1/{+name}";

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
                        Pattern = @"^namespaces/[^/]+/domainmappings/[^/]+$",
                    });
                    RequestParameters.Add("apiVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "apiVersion",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("dryRun", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dryRun",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("kind", new Google.Apis.Discovery.Parameter
                    {
                        Name = "kind",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("propagationPolicy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "propagationPolicy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Get information about a domain mapping.</summary>
            /// <param name="name">
            /// Required. The name of the domain mapping to retrieve. For Cloud Run (fully managed), replace {namespace}
            /// with the project ID or number. It takes the form namespaces/{namespace}. For example:
            /// namespaces/PROJECT_ID
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Get information about a domain mapping.</summary>
            public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.DomainMapping>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the domain mapping to retrieve. For Cloud Run (fully managed), replace
                /// {namespace} with the project ID or number. It takes the form namespaces/{namespace}. For example:
                /// namespaces/PROJECT_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/domains.cloudrun.com/v1/{+name}";

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
                        Pattern = @"^namespaces/[^/]+/domainmappings/[^/]+$",
                    });
                }
            }

            /// <summary>List all domain mappings.</summary>
            /// <param name="parent">
            /// Required. The namespace from which the domain mappings should be listed. For Cloud Run (fully managed),
            /// replace {namespace} with the project ID or number. It takes the form namespaces/{namespace}. For
            /// example: namespaces/PROJECT_ID
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>List all domain mappings.</summary>
            public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.ListDomainMappingsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The namespace from which the domain mappings should be listed. For Cloud Run (fully
                /// managed), replace {namespace} with the project ID or number. It takes the form
                /// namespaces/{namespace}. For example: namespaces/PROJECT_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional. Encoded string to continue paging.</summary>
                [Google.Apis.Util.RequestParameterAttribute("continue", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Continue { get; set; }

                /// <summary>
                /// Allows to filter resources based on a specific value for a field name. Send this in a query string
                /// format. i.e. 'metadata.name%3Dlorem'. Not currently used by Cloud Run.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("fieldSelector", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string FieldSelector { get; set; }

                /// <summary>Not currently used by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("includeUninitialized", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IncludeUninitialized { get; set; }

                /// <summary>
                /// Allows to filter resources based on a label. Supported operations are =, !=, exists, in, and notIn.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("labelSelector", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LabelSelector { get; set; }

                /// <summary>Optional. The maximum number of records that should be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("limit", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> Limit { get; set; }

                /// <summary>
                /// The baseline resource version from which the list or watch operation should start. Not currently
                /// used by Cloud Run.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resourceVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ResourceVersion { get; set; }

                /// <summary>
                /// Flag that indicates that the client expects to watch this resource as well. Not currently used by
                /// Cloud Run.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("watch", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> Watch { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/domains.cloudrun.com/v1/{+parent}/domainmappings";

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
                        Pattern = @"^namespaces/[^/]+$",
                    });
                    RequestParameters.Add("continue", new Google.Apis.Discovery.Parameter
                    {
                        Name = "continue",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("fieldSelector", new Google.Apis.Discovery.Parameter
                    {
                        Name = "fieldSelector",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("includeUninitialized", new Google.Apis.Discovery.Parameter
                    {
                        Name = "includeUninitialized",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("labelSelector", new Google.Apis.Discovery.Parameter
                    {
                        Name = "labelSelector",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("limit", new Google.Apis.Discovery.Parameter
                    {
                        Name = "limit",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("resourceVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resourceVersion",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("watch", new Google.Apis.Discovery.Parameter
                    {
                        Name = "watch",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Executions resource.</summary>
        public virtual ExecutionsResource Executions { get; }

        /// <summary>The "executions" collection of methods.</summary>
        public class ExecutionsResource
        {
            private const string Resource = "executions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ExecutionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Cancel an execution.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the execution to cancel. Replace {namespace} with the project ID or number. It
            /// takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
            /// </param>
            public virtual CancelRequest Cancel(Google.Apis.CloudRun.v1.Data.CancelExecutionRequest body, string name)
            {
                return new CancelRequest(this.service, body, name);
            }

            /// <summary>Cancel an execution.</summary>
            public class CancelRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Execution>
            {
                /// <summary>Constructs a new Cancel request.</summary>
                public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v1.Data.CancelExecutionRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the execution to cancel. Replace {namespace} with the project ID or number. It
                /// takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudRun.v1.Data.CancelExecutionRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "cancel";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/run.googleapis.com/v1/{+name}:cancel";

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
                        Pattern = @"^namespaces/[^/]+/executions/[^/]+$",
                    });
                }
            }

            /// <summary>Delete an execution.</summary>
            /// <param name="name">
            /// Required. The name of the execution to delete. Replace {namespace} with the project ID or number. It
            /// takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Delete an execution.</summary>
            public class DeleteRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Status>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the execution to delete. Replace {namespace} with the project ID or number. It
                /// takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Optional. Cloud Run currently ignores this parameter.</summary>
                [Google.Apis.Util.RequestParameterAttribute("apiVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual new string ApiVersion { get; set; }

                /// <summary>Optional. Cloud Run currently ignores this parameter.</summary>
                [Google.Apis.Util.RequestParameterAttribute("kind", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Kind { get; set; }

                /// <summary>
                /// Optional. Specifies the propagation policy of delete. Cloud Run currently ignores this setting.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("propagationPolicy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PropagationPolicy { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/run.googleapis.com/v1/{+name}";

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
                        Pattern = @"^namespaces/[^/]+/executions/[^/]+$",
                    });
                    RequestParameters.Add("apiVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "apiVersion",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("kind", new Google.Apis.Discovery.Parameter
                    {
                        Name = "kind",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("propagationPolicy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "propagationPolicy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Get information about an execution.</summary>
            /// <param name="name">
            /// Required. The name of the execution to retrieve. Replace {namespace} with the project ID or number. It
            /// takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Get information about an execution.</summary>
            public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Execution>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the execution to retrieve. Replace {namespace} with the project ID or number.
                /// It takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/run.googleapis.com/v1/{+name}";

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
                        Pattern = @"^namespaces/[^/]+/executions/[^/]+$",
                    });
                }
            }

            /// <summary>List executions. Results are sorted by creation time, descending.</summary>
            /// <param name="parent">
            /// Required. The namespace from which the executions should be listed. Replace {namespace} with the project
            /// ID or number. It takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>List executions. Results are sorted by creation time, descending.</summary>
            public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.ListExecutionsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The namespace from which the executions should be listed. Replace {namespace} with the
                /// project ID or number. It takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional. Optional encoded string to continue paging.</summary>
                [Google.Apis.Util.RequestParameterAttribute("continue", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Continue { get; set; }

                /// <summary>Optional. Not supported by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("fieldSelector", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string FieldSelector { get; set; }

                /// <summary>Optional. Not supported by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("includeUninitialized", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IncludeUninitialized { get; set; }

                /// <summary>
                /// Optional. Allows to filter resources based on a label. Supported operations are =, !=, exists, in,
                /// and notIn.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("labelSelector", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LabelSelector { get; set; }

                /// <summary>Optional. The maximum number of the records that should be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("limit", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> Limit { get; set; }

                /// <summary>Optional. Not supported by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("resourceVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ResourceVersion { get; set; }

                /// <summary>Optional. Not supported by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("watch", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> Watch { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/run.googleapis.com/v1/{+parent}/executions";

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
                        Pattern = @"^namespaces/[^/]+$",
                    });
                    RequestParameters.Add("continue", new Google.Apis.Discovery.Parameter
                    {
                        Name = "continue",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("fieldSelector", new Google.Apis.Discovery.Parameter
                    {
                        Name = "fieldSelector",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("includeUninitialized", new Google.Apis.Discovery.Parameter
                    {
                        Name = "includeUninitialized",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("labelSelector", new Google.Apis.Discovery.Parameter
                    {
                        Name = "labelSelector",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("limit", new Google.Apis.Discovery.Parameter
                    {
                        Name = "limit",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("resourceVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resourceVersion",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("watch", new Google.Apis.Discovery.Parameter
                    {
                        Name = "watch",
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

            /// <summary>Create a job.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The namespace in which the job should be created. Replace {namespace} with the project ID or
            /// number. It takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
            /// </param>
            public virtual CreateRequest Create(Google.Apis.CloudRun.v1.Data.Job body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Create a job.</summary>
            public class CreateRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Job>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v1.Data.Job body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The namespace in which the job should be created. Replace {namespace} with the project ID
                /// or number. It takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudRun.v1.Data.Job Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/run.googleapis.com/v1/{+parent}/jobs";

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
                        Pattern = @"^namespaces/[^/]+$",
                    });
                }
            }

            /// <summary>Delete a job.</summary>
            /// <param name="name">
            /// Required. The name of the job to delete. Replace {namespace} with the project ID or number. It takes the
            /// form namespaces/{namespace}. For example: namespaces/PROJECT_ID
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Delete a job.</summary>
            public class DeleteRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Status>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the job to delete. Replace {namespace} with the project ID or number. It takes
                /// the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Optional. Cloud Run currently ignores this parameter.</summary>
                [Google.Apis.Util.RequestParameterAttribute("apiVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual new string ApiVersion { get; set; }

                /// <summary>Optional. Cloud Run currently ignores this parameter.</summary>
                [Google.Apis.Util.RequestParameterAttribute("kind", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Kind { get; set; }

                /// <summary>
                /// Optional. Specifies the propagation policy of delete. Cloud Run currently ignores this setting, and
                /// deletes in the background. Please see
                /// kubernetes.io/docs/concepts/workloads/controllers/garbage-collection/ for more information.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("propagationPolicy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PropagationPolicy { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/run.googleapis.com/v1/{+name}";

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
                        Pattern = @"^namespaces/[^/]+/jobs/[^/]+$",
                    });
                    RequestParameters.Add("apiVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "apiVersion",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("kind", new Google.Apis.Discovery.Parameter
                    {
                        Name = "kind",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("propagationPolicy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "propagationPolicy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Get information about a job.</summary>
            /// <param name="name">
            /// Required. The name of the job to retrieve. Replace {namespace} with the project ID or number. It takes
            /// the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Get information about a job.</summary>
            public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Job>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the job to retrieve. Replace {namespace} with the project ID or number. It
                /// takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/run.googleapis.com/v1/{+name}";

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
                        Pattern = @"^namespaces/[^/]+/jobs/[^/]+$",
                    });
                }
            }

            /// <summary>List jobs. Results are sorted by creation time, descending.</summary>
            /// <param name="parent">
            /// Required. The namespace from which the jobs should be listed. Replace {namespace} with the project ID or
            /// number. It takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>List jobs. Results are sorted by creation time, descending.</summary>
            public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.ListJobsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The namespace from which the jobs should be listed. Replace {namespace} with the project
                /// ID or number. It takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional. Optional encoded string to continue paging.</summary>
                [Google.Apis.Util.RequestParameterAttribute("continue", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Continue { get; set; }

                /// <summary>Optional. Not supported by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("fieldSelector", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string FieldSelector { get; set; }

                /// <summary>Optional. Not supported by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("includeUninitialized", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IncludeUninitialized { get; set; }

                /// <summary>
                /// Optional. Allows to filter resources based on a label. Supported operations are =, !=, exists, in,
                /// and notIn.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("labelSelector", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LabelSelector { get; set; }

                /// <summary>Optional. The maximum number of records that should be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("limit", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> Limit { get; set; }

                /// <summary>Optional. Not supported by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("resourceVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ResourceVersion { get; set; }

                /// <summary>Optional. Not supported by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("watch", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> Watch { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/run.googleapis.com/v1/{+parent}/jobs";

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
                        Pattern = @"^namespaces/[^/]+$",
                    });
                    RequestParameters.Add("continue", new Google.Apis.Discovery.Parameter
                    {
                        Name = "continue",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("fieldSelector", new Google.Apis.Discovery.Parameter
                    {
                        Name = "fieldSelector",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("includeUninitialized", new Google.Apis.Discovery.Parameter
                    {
                        Name = "includeUninitialized",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("labelSelector", new Google.Apis.Discovery.Parameter
                    {
                        Name = "labelSelector",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("limit", new Google.Apis.Discovery.Parameter
                    {
                        Name = "limit",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("resourceVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resourceVersion",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("watch", new Google.Apis.Discovery.Parameter
                    {
                        Name = "watch",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Replace a job. Only the spec and metadata labels and annotations are modifiable. After the Replace
            /// request, Cloud Run will work to make the 'status' match the requested 'spec'. May provide
            /// metadata.resourceVersion to enforce update from last read for optimistic concurrency control.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the job being replaced. Replace {namespace} with the project ID or number. It
            /// takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
            /// </param>
            public virtual ReplaceJobRequest ReplaceJob(Google.Apis.CloudRun.v1.Data.Job body, string name)
            {
                return new ReplaceJobRequest(this.service, body, name);
            }

            /// <summary>
            /// Replace a job. Only the spec and metadata labels and annotations are modifiable. After the Replace
            /// request, Cloud Run will work to make the 'status' match the requested 'spec'. May provide
            /// metadata.resourceVersion to enforce update from last read for optimistic concurrency control.
            /// </summary>
            public class ReplaceJobRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Job>
            {
                /// <summary>Constructs a new ReplaceJob request.</summary>
                public ReplaceJobRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v1.Data.Job body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the job being replaced. Replace {namespace} with the project ID or number. It
                /// takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudRun.v1.Data.Job Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "replaceJob";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/run.googleapis.com/v1/{+name}";

                /// <summary>Initializes ReplaceJob parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^namespaces/[^/]+/jobs/[^/]+$",
                    });
                }
            }

            /// <summary>Trigger creation of a new execution of this job.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the job to run. Replace {namespace} with the project ID or number. It takes the
            /// form namespaces/{namespace}. For example: namespaces/PROJECT_ID
            /// </param>
            public virtual RunRequest Run(Google.Apis.CloudRun.v1.Data.RunJobRequest body, string name)
            {
                return new RunRequest(this.service, body, name);
            }

            /// <summary>Trigger creation of a new execution of this job.</summary>
            public class RunRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Execution>
            {
                /// <summary>Constructs a new Run request.</summary>
                public RunRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v1.Data.RunJobRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the job to run. Replace {namespace} with the project ID or number. It takes
                /// the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudRun.v1.Data.RunJobRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "run";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/run.googleapis.com/v1/{+name}:run";

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
                        Pattern = @"^namespaces/[^/]+/jobs/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the Revisions resource.</summary>
        public virtual RevisionsResource Revisions { get; }

        /// <summary>The "revisions" collection of methods.</summary>
        public class RevisionsResource
        {
            private const string Resource = "revisions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public RevisionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Delete a revision.</summary>
            /// <param name="name">
            /// The name of the revision to delete. For Cloud Run (fully managed), replace {namespace} with the project
            /// ID or number. It takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Delete a revision.</summary>
            public class DeleteRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Status>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The name of the revision to delete. For Cloud Run (fully managed), replace {namespace} with the
                /// project ID or number. It takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Cloud Run currently ignores this parameter.</summary>
                [Google.Apis.Util.RequestParameterAttribute("apiVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual new string ApiVersion { get; set; }

                /// <summary>
                /// Indicates that the server should validate the request and populate default values without persisting
                /// the request. Supported values: `all`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("dryRun", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string DryRun { get; set; }

                /// <summary>Cloud Run currently ignores this parameter.</summary>
                [Google.Apis.Util.RequestParameterAttribute("kind", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Kind { get; set; }

                /// <summary>
                /// Specifies the propagation policy of delete. Cloud Run currently ignores this setting, and deletes in
                /// the background.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("propagationPolicy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PropagationPolicy { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/serving.knative.dev/v1/{+name}";

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
                        Pattern = @"^namespaces/[^/]+/revisions/[^/]+$",
                    });
                    RequestParameters.Add("apiVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "apiVersion",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("dryRun", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dryRun",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("kind", new Google.Apis.Discovery.Parameter
                    {
                        Name = "kind",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("propagationPolicy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "propagationPolicy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Get information about a revision.</summary>
            /// <param name="name">
            /// The name of the revision to retrieve. For Cloud Run (fully managed), replace {namespace} with the
            /// project ID or number. It takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Get information about a revision.</summary>
            public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Revision>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The name of the revision to retrieve. For Cloud Run (fully managed), replace {namespace} with the
                /// project ID or number. It takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/serving.knative.dev/v1/{+name}";

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
                        Pattern = @"^namespaces/[^/]+/revisions/[^/]+$",
                    });
                }
            }

            /// <summary>List revisions. Results are sorted by creation time, descending.</summary>
            /// <param name="parent">
            /// The namespace from which the revisions should be listed. For Cloud Run (fully managed), replace
            /// {namespace} with the project ID or number. It takes the form namespaces/{namespace}. For example:
            /// namespaces/PROJECT_ID
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>List revisions. Results are sorted by creation time, descending.</summary>
            public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.ListRevisionsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// The namespace from which the revisions should be listed. For Cloud Run (fully managed), replace
                /// {namespace} with the project ID or number. It takes the form namespaces/{namespace}. For example:
                /// namespaces/PROJECT_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional. Encoded string to continue paging.</summary>
                [Google.Apis.Util.RequestParameterAttribute("continue", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Continue { get; set; }

                /// <summary>
                /// Allows to filter resources based on a specific value for a field name. Send this in a query string
                /// format. i.e. 'metadata.name%3Dlorem'. Not currently used by Cloud Run.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("fieldSelector", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string FieldSelector { get; set; }

                /// <summary>Not currently used by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("includeUninitialized", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IncludeUninitialized { get; set; }

                /// <summary>
                /// Allows to filter resources based on a label. Supported operations are =, !=, exists, in, and notIn.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("labelSelector", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LabelSelector { get; set; }

                /// <summary>Optional. The maximum number of records that should be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("limit", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> Limit { get; set; }

                /// <summary>
                /// The baseline resource version from which the list or watch operation should start. Not currently
                /// used by Cloud Run.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resourceVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ResourceVersion { get; set; }

                /// <summary>
                /// Flag that indicates that the client expects to watch this resource as well. Not currently used by
                /// Cloud Run.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("watch", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> Watch { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/serving.knative.dev/v1/{+parent}/revisions";

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
                        Pattern = @"^namespaces/[^/]+$",
                    });
                    RequestParameters.Add("continue", new Google.Apis.Discovery.Parameter
                    {
                        Name = "continue",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("fieldSelector", new Google.Apis.Discovery.Parameter
                    {
                        Name = "fieldSelector",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("includeUninitialized", new Google.Apis.Discovery.Parameter
                    {
                        Name = "includeUninitialized",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("labelSelector", new Google.Apis.Discovery.Parameter
                    {
                        Name = "labelSelector",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("limit", new Google.Apis.Discovery.Parameter
                    {
                        Name = "limit",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("resourceVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resourceVersion",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("watch", new Google.Apis.Discovery.Parameter
                    {
                        Name = "watch",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Routes resource.</summary>
        public virtual RoutesResource Routes { get; }

        /// <summary>The "routes" collection of methods.</summary>
        public class RoutesResource
        {
            private const string Resource = "routes";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public RoutesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Get information about a route.</summary>
            /// <param name="name">
            /// The name of the route to retrieve. For Cloud Run (fully managed), replace {namespace} with the project
            /// ID or number. It takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Get information about a route.</summary>
            public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Route>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The name of the route to retrieve. For Cloud Run (fully managed), replace {namespace} with the
                /// project ID or number. It takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/serving.knative.dev/v1/{+name}";

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
                        Pattern = @"^namespaces/[^/]+/routes/[^/]+$",
                    });
                }
            }

            /// <summary>List routes. Results are sorted by creation time, descending.</summary>
            /// <param name="parent">
            /// The namespace from which the routes should be listed. For Cloud Run (fully managed), replace {namespace}
            /// with the project ID or number. It takes the form namespaces/{namespace}. For example:
            /// namespaces/PROJECT_ID
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>List routes. Results are sorted by creation time, descending.</summary>
            public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.ListRoutesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// The namespace from which the routes should be listed. For Cloud Run (fully managed), replace
                /// {namespace} with the project ID or number. It takes the form namespaces/{namespace}. For example:
                /// namespaces/PROJECT_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional. Encoded string to continue paging.</summary>
                [Google.Apis.Util.RequestParameterAttribute("continue", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Continue { get; set; }

                /// <summary>
                /// Allows to filter resources based on a specific value for a field name. Send this in a query string
                /// format. i.e. 'metadata.name%3Dlorem'. Not currently used by Cloud Run.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("fieldSelector", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string FieldSelector { get; set; }

                /// <summary>Not currently used by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("includeUninitialized", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IncludeUninitialized { get; set; }

                /// <summary>
                /// Allows to filter resources based on a label. Supported operations are =, !=, exists, in, and notIn.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("labelSelector", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LabelSelector { get; set; }

                /// <summary>Optional. The maximum number of records that should be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("limit", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> Limit { get; set; }

                /// <summary>
                /// The baseline resource version from which the list or watch operation should start. Not currently
                /// used by Cloud Run.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resourceVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ResourceVersion { get; set; }

                /// <summary>
                /// Flag that indicates that the client expects to watch this resource as well. Not currently used by
                /// Cloud Run.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("watch", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> Watch { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/serving.knative.dev/v1/{+parent}/routes";

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
                        Pattern = @"^namespaces/[^/]+$",
                    });
                    RequestParameters.Add("continue", new Google.Apis.Discovery.Parameter
                    {
                        Name = "continue",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("fieldSelector", new Google.Apis.Discovery.Parameter
                    {
                        Name = "fieldSelector",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("includeUninitialized", new Google.Apis.Discovery.Parameter
                    {
                        Name = "includeUninitialized",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("labelSelector", new Google.Apis.Discovery.Parameter
                    {
                        Name = "labelSelector",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("limit", new Google.Apis.Discovery.Parameter
                    {
                        Name = "limit",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("resourceVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resourceVersion",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("watch", new Google.Apis.Discovery.Parameter
                    {
                        Name = "watch",
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
            }

            /// <summary>
            /// Creates a new Service. Service creation will trigger a new deployment. Use GetService, and check
            /// service.status to determine if the Service is ready.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource's parent. In Cloud Run, it may be one of the following: *
            /// `{project_id_or_number}` * `namespaces/{project_id_or_number}` *
            /// `namespaces/{project_id_or_number}/services` * `projects/{project_id_or_number}/locations/{region}` *
            /// `projects/{project_id_or_number}/regions/{region}`
            /// </param>
            public virtual CreateRequest Create(Google.Apis.CloudRun.v1.Data.Service body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates a new Service. Service creation will trigger a new deployment. Use GetService, and check
            /// service.status to determine if the Service is ready.
            /// </summary>
            public class CreateRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Service>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v1.Data.Service body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource's parent. In Cloud Run, it may be one of the following: *
                /// `{project_id_or_number}` * `namespaces/{project_id_or_number}` *
                /// `namespaces/{project_id_or_number}/services` * `projects/{project_id_or_number}/locations/{region}`
                /// * `projects/{project_id_or_number}/regions/{region}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Indicates that the server should validate the request and populate default values without persisting
                /// the request. Supported values: `all`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("dryRun", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string DryRun { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudRun.v1.Data.Service Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/serving.knative.dev/v1/{+parent}/services";

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
                        Pattern = @"^namespaces/[^/]+$",
                    });
                    RequestParameters.Add("dryRun", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dryRun",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes the provided service. This will cause the Service to stop serving traffic and will delete all
            /// associated Revisions.
            /// </summary>
            /// <param name="name">
            /// Required. The fully qualified name of the service to delete. It can be any of the following forms: *
            /// `namespaces/{project_id_or_number}/services/{service_name}` (only when the `endpoint` is regional) *
            /// `projects/{project_id_or_number}/locations/{region}/services/{service_name}` *
            /// `projects/{project_id_or_number}/regions/{region}/services/{service_name}`
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes the provided service. This will cause the Service to stop serving traffic and will delete all
            /// associated Revisions.
            /// </summary>
            public class DeleteRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Status>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The fully qualified name of the service to delete. It can be any of the following forms: *
                /// `namespaces/{project_id_or_number}/services/{service_name}` (only when the `endpoint` is regional) *
                /// `projects/{project_id_or_number}/locations/{region}/services/{service_name}` *
                /// `projects/{project_id_or_number}/regions/{region}/services/{service_name}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Not supported, and ignored by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("apiVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual new string ApiVersion { get; set; }

                /// <summary>
                /// Indicates that the server should validate the request and populate default values without persisting
                /// the request. Supported values: `all`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("dryRun", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string DryRun { get; set; }

                /// <summary>Not supported, and ignored by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("kind", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Kind { get; set; }

                /// <summary>Not supported, and ignored by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("propagationPolicy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PropagationPolicy { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/serving.knative.dev/v1/{+name}";

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
                        Pattern = @"^namespaces/[^/]+/services/[^/]+$",
                    });
                    RequestParameters.Add("apiVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "apiVersion",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("dryRun", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dryRun",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("kind", new Google.Apis.Discovery.Parameter
                    {
                        Name = "kind",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("propagationPolicy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "propagationPolicy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets information about a service.</summary>
            /// <param name="name">
            /// Required. The fully qualified name of the service to retrieve. It can be any of the following forms: *
            /// `namespaces/{project_id_or_number}/services/{service_name}` (only when the `endpoint` is regional) *
            /// `projects/{project_id_or_number}/locations/{region}/services/{service_name}` *
            /// `projects/{project_id_or_number}/regions/{region}/services/{service_name}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a service.</summary>
            public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Service>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The fully qualified name of the service to retrieve. It can be any of the following forms:
                /// * `namespaces/{project_id_or_number}/services/{service_name}` (only when the `endpoint` is regional)
                /// * `projects/{project_id_or_number}/locations/{region}/services/{service_name}` *
                /// `projects/{project_id_or_number}/regions/{region}/services/{service_name}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/serving.knative.dev/v1/{+name}";

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
                        Pattern = @"^namespaces/[^/]+/services/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists services for the given project and region. Results are sorted by creation time, descending.
            /// </summary>
            /// <param name="parent">
            /// Required. The parent from where the resources should be listed. In Cloud Run, it may be one of the
            /// following: * `{project_id_or_number}` * `namespaces/{project_id_or_number}` *
            /// `namespaces/{project_id_or_number}/services` * `projects/{project_id_or_number}/locations/{region}` *
            /// `projects/{project_id_or_number}/regions/{region}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists services for the given project and region. Results are sorted by creation time, descending.
            /// </summary>
            public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.ListServicesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent from where the resources should be listed. In Cloud Run, it may be one of the
                /// following: * `{project_id_or_number}` * `namespaces/{project_id_or_number}` *
                /// `namespaces/{project_id_or_number}/services` * `projects/{project_id_or_number}/locations/{region}`
                /// * `projects/{project_id_or_number}/regions/{region}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Encoded string to continue paging.</summary>
                [Google.Apis.Util.RequestParameterAttribute("continue", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Continue { get; set; }

                /// <summary>Not supported, and ignored by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("fieldSelector", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string FieldSelector { get; set; }

                /// <summary>Not supported, and ignored by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("includeUninitialized", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IncludeUninitialized { get; set; }

                /// <summary>
                /// Allows to filter resources based on a label. Supported operations are =, !=, exists, in, and notIn.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("labelSelector", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LabelSelector { get; set; }

                /// <summary>The maximum number of records that should be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("limit", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> Limit { get; set; }

                /// <summary>Not supported, and ignored by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("resourceVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ResourceVersion { get; set; }

                /// <summary>Not supported, and ignored by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("watch", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> Watch { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/serving.knative.dev/v1/{+parent}/services";

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
                        Pattern = @"^namespaces/[^/]+$",
                    });
                    RequestParameters.Add("continue", new Google.Apis.Discovery.Parameter
                    {
                        Name = "continue",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("fieldSelector", new Google.Apis.Discovery.Parameter
                    {
                        Name = "fieldSelector",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("includeUninitialized", new Google.Apis.Discovery.Parameter
                    {
                        Name = "includeUninitialized",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("labelSelector", new Google.Apis.Discovery.Parameter
                    {
                        Name = "labelSelector",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("limit", new Google.Apis.Discovery.Parameter
                    {
                        Name = "limit",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("resourceVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resourceVersion",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("watch", new Google.Apis.Discovery.Parameter
                    {
                        Name = "watch",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Replaces a service. Only the spec and metadata labels and annotations are modifiable. After the Update
            /// request, Cloud Run will work to make the 'status' match the requested 'spec'. May provide
            /// metadata.resourceVersion to enforce update from last read for optimistic concurrency control.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The fully qualified name of the service to replace. It can be any of the following forms: *
            /// `namespaces/{project_id_or_number}/services/{service_name}` (only when the `endpoint` is regional) *
            /// `projects/{project_id_or_number}/locations/{region}/services/{service_name}` *
            /// `projects/{project_id_or_number}/regions/{region}/services/{service_name}`
            /// </param>
            public virtual ReplaceServiceRequest ReplaceService(Google.Apis.CloudRun.v1.Data.Service body, string name)
            {
                return new ReplaceServiceRequest(this.service, body, name);
            }

            /// <summary>
            /// Replaces a service. Only the spec and metadata labels and annotations are modifiable. After the Update
            /// request, Cloud Run will work to make the 'status' match the requested 'spec'. May provide
            /// metadata.resourceVersion to enforce update from last read for optimistic concurrency control.
            /// </summary>
            public class ReplaceServiceRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Service>
            {
                /// <summary>Constructs a new ReplaceService request.</summary>
                public ReplaceServiceRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v1.Data.Service body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The fully qualified name of the service to replace. It can be any of the following forms:
                /// * `namespaces/{project_id_or_number}/services/{service_name}` (only when the `endpoint` is regional)
                /// * `projects/{project_id_or_number}/locations/{region}/services/{service_name}` *
                /// `projects/{project_id_or_number}/regions/{region}/services/{service_name}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Indicates that the server should validate the request and populate default values without persisting
                /// the request. Supported values: `all`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("dryRun", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string DryRun { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudRun.v1.Data.Service Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "replaceService";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/serving.knative.dev/v1/{+name}";

                /// <summary>Initializes ReplaceService parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^namespaces/[^/]+/services/[^/]+$",
                    });
                    RequestParameters.Add("dryRun", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dryRun",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
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
            }

            /// <summary>Get information about a task.</summary>
            /// <param name="name">
            /// Required. The name of the task to retrieve. Replace {namespace} with the project ID or number. It takes
            /// the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Get information about a task.</summary>
            public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Task>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the task to retrieve. Replace {namespace} with the project ID or number. It
                /// takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/run.googleapis.com/v1/{+name}";

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
                        Pattern = @"^namespaces/[^/]+/tasks/[^/]+$",
                    });
                }
            }

            /// <summary>List tasks.</summary>
            /// <param name="parent">
            /// Required. The namespace from which the tasks should be listed. Replace {namespace} with the project ID
            /// or number. It takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>List tasks.</summary>
            public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.ListTasksResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The namespace from which the tasks should be listed. Replace {namespace} with the project
                /// ID or number. It takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional. Optional encoded string to continue paging.</summary>
                [Google.Apis.Util.RequestParameterAttribute("continue", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Continue { get; set; }

                /// <summary>Optional. Not supported by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("fieldSelector", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string FieldSelector { get; set; }

                /// <summary>Optional. Not supported by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("includeUninitialized", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IncludeUninitialized { get; set; }

                /// <summary>
                /// Optional. Allows to filter resources based on a label. Supported operations are =, !=, exists, in,
                /// and notIn. For example, to list all tasks of execution "foo" in succeeded state:
                /// `run.googleapis.com/execution=foo,run.googleapis.com/runningState=Succeeded`. Supported states are:
                /// * `Pending`: Initial state of all tasks. The task has not yet started but eventually will. *
                /// `Running`: Container instances for this task are running or will be running shortly. * `Succeeded`:
                /// No more container instances to run for the task, and the last attempt succeeded. * `Failed`: No more
                /// container instances to run for the task, and the last attempt failed. This task has run out of retry
                /// attempts. * `Cancelled`: Task was running but got stopped because its parent execution has been
                /// aborted. * `Abandoned`: The task has not yet started and never will because its parent execution has
                /// been aborted.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("labelSelector", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LabelSelector { get; set; }

                /// <summary>Optional. The maximum number of records that should be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("limit", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> Limit { get; set; }

                /// <summary>Optional. Not supported by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("resourceVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ResourceVersion { get; set; }

                /// <summary>Optional. Not supported by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("watch", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> Watch { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/run.googleapis.com/v1/{+parent}/tasks";

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
                        Pattern = @"^namespaces/[^/]+$",
                    });
                    RequestParameters.Add("continue", new Google.Apis.Discovery.Parameter
                    {
                        Name = "continue",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("fieldSelector", new Google.Apis.Discovery.Parameter
                    {
                        Name = "fieldSelector",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("includeUninitialized", new Google.Apis.Discovery.Parameter
                    {
                        Name = "includeUninitialized",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("labelSelector", new Google.Apis.Discovery.Parameter
                    {
                        Name = "labelSelector",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("limit", new Google.Apis.Discovery.Parameter
                    {
                        Name = "limit",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("resourceVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resourceVersion",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("watch", new Google.Apis.Discovery.Parameter
                    {
                        Name = "watch",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Workerpools resource.</summary>
        public virtual WorkerpoolsResource Workerpools { get; }

        /// <summary>The "workerpools" collection of methods.</summary>
        public class WorkerpoolsResource
        {
            private const string Resource = "workerpools";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public WorkerpoolsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a new WorkerPool. WorkerPool creation will trigger a new deployment. Use GetWorkerPool, and
            /// check worker_pool.status to determine if the WorkerPool is ready.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource's parent. In Cloud Run, it may be one of the following: *
            /// `{project_id_or_number}` * `namespaces/{project_id_or_number}` *
            /// `namespaces/{project_id_or_number}/workerpools` * `projects/{project_id_or_number}/locations/{region}` *
            /// `projects/{project_id_or_number}/regions/{region}`
            /// </param>
            public virtual CreateRequest Create(Google.Apis.CloudRun.v1.Data.WorkerPool body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates a new WorkerPool. WorkerPool creation will trigger a new deployment. Use GetWorkerPool, and
            /// check worker_pool.status to determine if the WorkerPool is ready.
            /// </summary>
            public class CreateRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.WorkerPool>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v1.Data.WorkerPool body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource's parent. In Cloud Run, it may be one of the following: *
                /// `{project_id_or_number}` * `namespaces/{project_id_or_number}` *
                /// `namespaces/{project_id_or_number}/workerpools` *
                /// `projects/{project_id_or_number}/locations/{region}` *
                /// `projects/{project_id_or_number}/regions/{region}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Indicates that the server should validate the request and populate default values without persisting
                /// the request. Supported values: `all`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("dryRun", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string DryRun { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudRun.v1.Data.WorkerPool Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/run.googleapis.com/v1/{+parent}/workerpools";

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
                        Pattern = @"^namespaces/[^/]+$",
                    });
                    RequestParameters.Add("dryRun", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dryRun",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes the provided worker pool. This will cause the WorkerPool to stop all instances and will delete
            /// all associated WorkerPoolRevisions.
            /// </summary>
            /// <param name="name">
            /// Required. The fully qualified name of the worker pool to delete. It can be any of the following forms: *
            /// `namespaces/{project_id_or_number}/workerpools/{worker_pool_name}` (only when the `endpoint` is
            /// regional) * `projects/{project_id_or_number}/locations/{region}/workerpools/{worker_pool_name}` *
            /// `projects/{project_id_or_number}/regions/{region}/workerpools/{worker_pool_name}`
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes the provided worker pool. This will cause the WorkerPool to stop all instances and will delete
            /// all associated WorkerPoolRevisions.
            /// </summary>
            public class DeleteRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Status>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The fully qualified name of the worker pool to delete. It can be any of the following
                /// forms: * `namespaces/{project_id_or_number}/workerpools/{worker_pool_name}` (only when the
                /// `endpoint` is regional) *
                /// `projects/{project_id_or_number}/locations/{region}/workerpools/{worker_pool_name}` *
                /// `projects/{project_id_or_number}/regions/{region}/workerpools/{worker_pool_name}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Indicates that the server should validate the request and populate default values without persisting
                /// the request. Supported values: `all`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("dryRun", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string DryRun { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/run.googleapis.com/v1/{+name}";

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
                        Pattern = @"^namespaces/[^/]+/workerpools/[^/]+$",
                    });
                    RequestParameters.Add("dryRun", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dryRun",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets information about a worker pool.</summary>
            /// <param name="name">
            /// Required. The fully qualified name of the worker pool to retrieve. It can be any of the following forms:
            /// * `namespaces/{project_id_or_number}/workerpools/{worker_pool_name}` (only when the `endpoint` is
            /// regional) * `projects/{project_id_or_number}/locations/{region}/workerpools/{worker_pool_name}` *
            /// `projects/{project_id_or_number}/regions/{region}/workerpools/{worker_pool_name}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a worker pool.</summary>
            public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.WorkerPool>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The fully qualified name of the worker pool to retrieve. It can be any of the following
                /// forms: * `namespaces/{project_id_or_number}/workerpools/{worker_pool_name}` (only when the
                /// `endpoint` is regional) *
                /// `projects/{project_id_or_number}/locations/{region}/workerpools/{worker_pool_name}` *
                /// `projects/{project_id_or_number}/regions/{region}/workerpools/{worker_pool_name}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/run.googleapis.com/v1/{+name}";

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
                        Pattern = @"^namespaces/[^/]+/workerpools/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists worker pools for the given project and region. Results are sorted by creation time, descending.
            /// </summary>
            /// <param name="parent">
            /// Required. The parent from where the resources should be listed. In Cloud Run, it may be one of the
            /// following: * `{project_id_or_number}` * `namespaces/{project_id_or_number}` *
            /// `namespaces/{project_id_or_number}/workerpools` * `projects/{project_id_or_number}/locations/{region}` *
            /// `projects/{project_id_or_number}/regions/{region}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists worker pools for the given project and region. Results are sorted by creation time, descending.
            /// </summary>
            public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.ListWorkerPoolsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent from where the resources should be listed. In Cloud Run, it may be one of the
                /// following: * `{project_id_or_number}` * `namespaces/{project_id_or_number}` *
                /// `namespaces/{project_id_or_number}/workerpools` *
                /// `projects/{project_id_or_number}/locations/{region}` *
                /// `projects/{project_id_or_number}/regions/{region}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Encoded string to continue paging.</summary>
                [Google.Apis.Util.RequestParameterAttribute("continue", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Continue { get; set; }

                /// <summary>=, !=, exists, in, and notIn.</summary>
                [Google.Apis.Util.RequestParameterAttribute("labelSelector", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LabelSelector { get; set; }

                /// <summary>The maximum number of records that should be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("limit", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> Limit { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/run.googleapis.com/v1/{+parent}/workerpools";

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
                        Pattern = @"^namespaces/[^/]+$",
                    });
                    RequestParameters.Add("continue", new Google.Apis.Discovery.Parameter
                    {
                        Name = "continue",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("labelSelector", new Google.Apis.Discovery.Parameter
                    {
                        Name = "labelSelector",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("limit", new Google.Apis.Discovery.Parameter
                    {
                        Name = "limit",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Replaces a worker pool. Only the spec and metadata labels and annotations are modifiable. After the
            /// Update request, Cloud Run will work to make the 'status' match the requested 'spec'. May provide
            /// metadata.resourceVersion to enforce update from last read for optimistic concurrency control.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The fully qualified name of the worker pool to replace. It can be any of the following forms:
            /// * `namespaces/{project_id_or_number}/workerpools/{worker_pool_name}` (only when the `endpoint` is
            /// regional) * `projects/{project_id_or_number}/locations/{region}/workerpools/{worker_pool_name}` *
            /// `projects/{project_id_or_number}/regions/{region}/workerpools/{worker_pool_name}`
            /// </param>
            public virtual ReplaceWorkerPoolRequest ReplaceWorkerPool(Google.Apis.CloudRun.v1.Data.WorkerPool body, string name)
            {
                return new ReplaceWorkerPoolRequest(this.service, body, name);
            }

            /// <summary>
            /// Replaces a worker pool. Only the spec and metadata labels and annotations are modifiable. After the
            /// Update request, Cloud Run will work to make the 'status' match the requested 'spec'. May provide
            /// metadata.resourceVersion to enforce update from last read for optimistic concurrency control.
            /// </summary>
            public class ReplaceWorkerPoolRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.WorkerPool>
            {
                /// <summary>Constructs a new ReplaceWorkerPool request.</summary>
                public ReplaceWorkerPoolRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v1.Data.WorkerPool body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The fully qualified name of the worker pool to replace. It can be any of the following
                /// forms: * `namespaces/{project_id_or_number}/workerpools/{worker_pool_name}` (only when the
                /// `endpoint` is regional) *
                /// `projects/{project_id_or_number}/locations/{region}/workerpools/{worker_pool_name}` *
                /// `projects/{project_id_or_number}/regions/{region}/workerpools/{worker_pool_name}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Indicates that the server should validate the request and populate default values without persisting
                /// the request. Supported values: `all`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("dryRun", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string DryRun { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudRun.v1.Data.WorkerPool Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "replaceWorkerPool";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/run.googleapis.com/v1/{+name}";

                /// <summary>Initializes ReplaceWorkerPool parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^namespaces/[^/]+/workerpools/[^/]+$",
                    });
                    RequestParameters.Add("dryRun", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dryRun",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
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
            Authorizeddomains = new AuthorizeddomainsResource(service);
            Locations = new LocationsResource(service);
        }

        /// <summary>Gets the Authorizeddomains resource.</summary>
        public virtual AuthorizeddomainsResource Authorizeddomains { get; }

        /// <summary>The "authorizeddomains" collection of methods.</summary>
        public class AuthorizeddomainsResource
        {
            private const string Resource = "authorizeddomains";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AuthorizeddomainsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>List authorized domains.</summary>
            /// <param name="parent">Name of the parent Project resource. Example: `projects/myproject`.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>List authorized domains.</summary>
            public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.ListAuthorizedDomainsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Name of the parent Project resource. Example: `projects/myproject`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Maximum results to return per page.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Continuation token for fetching the next page of results.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/authorizeddomains";

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
                Authorizeddomains = new AuthorizeddomainsResource(service);
                Configurations = new ConfigurationsResource(service);
                Domainmappings = new DomainmappingsResource(service);
                Jobs = new JobsResource(service);
                Operations = new OperationsResource(service);
                Revisions = new RevisionsResource(service);
                Routes = new RoutesResource(service);
                Services = new ServicesResource(service);
                Workerpools = new WorkerpoolsResource(service);
            }

            /// <summary>Gets the Authorizeddomains resource.</summary>
            public virtual AuthorizeddomainsResource Authorizeddomains { get; }

            /// <summary>The "authorizeddomains" collection of methods.</summary>
            public class AuthorizeddomainsResource
            {
                private const string Resource = "authorizeddomains";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AuthorizeddomainsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>List authorized domains.</summary>
                /// <param name="parent">Name of the parent Project resource. Example: `projects/myproject`.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List authorized domains.</summary>
                public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.ListAuthorizedDomainsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Name of the parent Project resource. Example: `projects/myproject`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum results to return per page.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Continuation token for fetching the next page of results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/authorizeddomains";

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

            /// <summary>Gets the Configurations resource.</summary>
            public virtual ConfigurationsResource Configurations { get; }

            /// <summary>The "configurations" collection of methods.</summary>
            public class ConfigurationsResource
            {
                private const string Resource = "configurations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ConfigurationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Get information about a configuration.</summary>
                /// <param name="name">
                /// The name of the configuration to retrieve. For Cloud Run, replace {namespace_id} with the project ID
                /// or number.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Get information about a configuration.</summary>
                public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Configuration>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the configuration to retrieve. For Cloud Run, replace {namespace_id} with the
                    /// project ID or number.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/configurations/[^/]+$",
                        });
                    }
                }

                /// <summary>List configurations. Results are sorted by creation time, descending.</summary>
                /// <param name="parent">
                /// The namespace from which the configurations should be listed. For Cloud Run, replace {namespace_id}
                /// with the project ID or number.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List configurations. Results are sorted by creation time, descending.</summary>
                public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.ListConfigurationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// The namespace from which the configurations should be listed. For Cloud Run, replace
                    /// {namespace_id} with the project ID or number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Encoded string to continue paging.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("continue", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Continue { get; set; }

                    /// <summary>Not supported by Cloud Run.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("fieldSelector", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string FieldSelector { get; set; }

                    /// <summary>Not supported by Cloud Run.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("includeUninitialized", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> IncludeUninitialized { get; set; }

                    /// <summary>
                    /// Allows to filter resources based on a label. Supported operations are =, !=, exists, in, and
                    /// notIn.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("labelSelector", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string LabelSelector { get; set; }

                    /// <summary>Optional. The maximum number of the records that should be returned.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("limit", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> Limit { get; set; }

                    /// <summary>Not supported by Cloud Run.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("resourceVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ResourceVersion { get; set; }

                    /// <summary>Not supported by Cloud Run.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("watch", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Watch { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/configurations";

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
                        RequestParameters.Add("continue", new Google.Apis.Discovery.Parameter
                        {
                            Name = "continue",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fieldSelector", new Google.Apis.Discovery.Parameter
                        {
                            Name = "fieldSelector",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("includeUninitialized", new Google.Apis.Discovery.Parameter
                        {
                            Name = "includeUninitialized",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("labelSelector", new Google.Apis.Discovery.Parameter
                        {
                            Name = "labelSelector",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("limit", new Google.Apis.Discovery.Parameter
                        {
                            Name = "limit",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("resourceVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resourceVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("watch", new Google.Apis.Discovery.Parameter
                        {
                            Name = "watch",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the Domainmappings resource.</summary>
            public virtual DomainmappingsResource Domainmappings { get; }

            /// <summary>The "domainmappings" collection of methods.</summary>
            public class DomainmappingsResource
            {
                private const string Resource = "domainmappings";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DomainmappingsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Create a new domain mapping.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The namespace in which the domain mapping should be created. For Cloud Run (fully
                /// managed), replace {namespace} with the project ID or number. It takes the form
                /// namespaces/{namespace}. For example: namespaces/PROJECT_ID
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudRun.v1.Data.DomainMapping body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Create a new domain mapping.</summary>
                public class CreateRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.DomainMapping>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v1.Data.DomainMapping body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The namespace in which the domain mapping should be created. For Cloud Run (fully
                    /// managed), replace {namespace} with the project ID or number. It takes the form
                    /// namespaces/{namespace}. For example: namespaces/PROJECT_ID
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Indicates that the server should validate the request and populate default values without
                    /// persisting the request. Supported values: `all`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("dryRun", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string DryRun { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRun.v1.Data.DomainMapping Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/domainmappings";

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
                        RequestParameters.Add("dryRun", new Google.Apis.Discovery.Parameter
                        {
                            Name = "dryRun",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Delete a domain mapping.</summary>
                /// <param name="name">
                /// Required. The name of the domain mapping to delete. For Cloud Run (fully managed), replace
                /// {namespace} with the project ID or number. It takes the form namespaces/{namespace}. For example:
                /// namespaces/PROJECT_ID
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Delete a domain mapping.</summary>
                public class DeleteRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Status>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the domain mapping to delete. For Cloud Run (fully managed), replace
                    /// {namespace} with the project ID or number. It takes the form namespaces/{namespace}. For
                    /// example: namespaces/PROJECT_ID
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Cloud Run currently ignores this parameter.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("apiVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual new string ApiVersion { get; set; }

                    /// <summary>
                    /// Indicates that the server should validate the request and populate default values without
                    /// persisting the request. Supported values: `all`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("dryRun", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string DryRun { get; set; }

                    /// <summary>Cloud Run currently ignores this parameter.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("kind", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Kind { get; set; }

                    /// <summary>
                    /// Specifies the propagation policy of delete. Cloud Run currently ignores this setting, and
                    /// deletes in the background. Please see
                    /// kubernetes.io/docs/concepts/architecture/garbage-collection/ for more information.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("propagationPolicy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PropagationPolicy { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/domainmappings/[^/]+$",
                        });
                        RequestParameters.Add("apiVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "apiVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("dryRun", new Google.Apis.Discovery.Parameter
                        {
                            Name = "dryRun",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("kind", new Google.Apis.Discovery.Parameter
                        {
                            Name = "kind",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("propagationPolicy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "propagationPolicy",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Get information about a domain mapping.</summary>
                /// <param name="name">
                /// Required. The name of the domain mapping to retrieve. For Cloud Run (fully managed), replace
                /// {namespace} with the project ID or number. It takes the form namespaces/{namespace}. For example:
                /// namespaces/PROJECT_ID
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Get information about a domain mapping.</summary>
                public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.DomainMapping>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the domain mapping to retrieve. For Cloud Run (fully managed), replace
                    /// {namespace} with the project ID or number. It takes the form namespaces/{namespace}. For
                    /// example: namespaces/PROJECT_ID
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/domainmappings/[^/]+$",
                        });
                    }
                }

                /// <summary>List all domain mappings.</summary>
                /// <param name="parent">
                /// Required. The namespace from which the domain mappings should be listed. For Cloud Run (fully
                /// managed), replace {namespace} with the project ID or number. It takes the form
                /// namespaces/{namespace}. For example: namespaces/PROJECT_ID
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List all domain mappings.</summary>
                public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.ListDomainMappingsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The namespace from which the domain mappings should be listed. For Cloud Run (fully
                    /// managed), replace {namespace} with the project ID or number. It takes the form
                    /// namespaces/{namespace}. For example: namespaces/PROJECT_ID
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Encoded string to continue paging.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("continue", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Continue { get; set; }

                    /// <summary>
                    /// Allows to filter resources based on a specific value for a field name. Send this in a query
                    /// string format. i.e. 'metadata.name%3Dlorem'. Not currently used by Cloud Run.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("fieldSelector", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string FieldSelector { get; set; }

                    /// <summary>Not currently used by Cloud Run.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("includeUninitialized", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> IncludeUninitialized { get; set; }

                    /// <summary>
                    /// Allows to filter resources based on a label. Supported operations are =, !=, exists, in, and
                    /// notIn.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("labelSelector", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string LabelSelector { get; set; }

                    /// <summary>Optional. The maximum number of records that should be returned.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("limit", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> Limit { get; set; }

                    /// <summary>
                    /// The baseline resource version from which the list or watch operation should start. Not currently
                    /// used by Cloud Run.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resourceVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ResourceVersion { get; set; }

                    /// <summary>
                    /// Flag that indicates that the client expects to watch this resource as well. Not currently used
                    /// by Cloud Run.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("watch", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Watch { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/domainmappings";

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
                        RequestParameters.Add("continue", new Google.Apis.Discovery.Parameter
                        {
                            Name = "continue",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fieldSelector", new Google.Apis.Discovery.Parameter
                        {
                            Name = "fieldSelector",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("includeUninitialized", new Google.Apis.Discovery.Parameter
                        {
                            Name = "includeUninitialized",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("labelSelector", new Google.Apis.Discovery.Parameter
                        {
                            Name = "labelSelector",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("limit", new Google.Apis.Discovery.Parameter
                        {
                            Name = "limit",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("resourceVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resourceVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("watch", new Google.Apis.Discovery.Parameter
                        {
                            Name = "watch",
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

                /// <summary>
                /// Get the IAM Access Control policy currently in effect for the given job. This result does not
                /// include any inherited policies.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(this.service, resource);
                }

                /// <summary>
                /// Get the IAM Access Control policy currently in effect for the given job. This result does not
                /// include any inherited policies.
                /// </summary>
                public class GetIamPolicyRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Policy>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
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
                /// Sets the IAM Access control policy for the specified job. Overwrites any existing policy.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudRun.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the IAM Access control policy for the specified job. Overwrites any existing policy.
                /// </summary>
                public class SetIamPolicyRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.CloudRun.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified job. There are no permissions required for
                /// making this API call.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudRun.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified job. There are no permissions required for
                /// making this API call.
                /// </summary>
                public class TestIamPermissionsRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.CloudRun.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
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
                public class DeleteRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Empty>
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
                public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.GoogleLongrunningOperation>
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
                /// <param name="name">Required. To query for all of the operations for a project.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(this.service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`.
                /// </summary>
                public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.GoogleLongrunningListOperationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. To query for all of the operations for a project.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A filter for matching the completed or in-progress operations. The supported formats
                    /// of *filter* are: To query for only completed operations: done:true To query for only ongoing
                    /// operations: done:false Must be empty to query for all of the latest operations for the given
                    /// parent project.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// The maximum number of records that should be returned. Requested page size cannot exceed 100. If
                    /// not set or set to less than or equal to 0, the default page size is 100. .
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Token identifying which result to start with, which is returned by a previous list call.
                    /// </summary>
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

                /// <summary>
                /// Waits until the specified long-running operation is done or reaches at most a specified timeout,
                /// returning the latest state. If the operation is already done, the latest state is immediately
                /// returned. If the timeout specified is greater than the default HTTP/RPC timeout, the HTTP/RPC
                /// timeout is used. If the server does not support this method, it returns
                /// `google.rpc.Code.UNIMPLEMENTED`. Note that this method is on a best-effort basis. It may return the
                /// latest state before the specified timeout (including immediately), meaning even an immediate
                /// response is no guarantee that the operation is done.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to wait on.</param>
                public virtual WaitRequest Wait(Google.Apis.CloudRun.v1.Data.GoogleLongrunningWaitOperationRequest body, string name)
                {
                    return new WaitRequest(this.service, body, name);
                }

                /// <summary>
                /// Waits until the specified long-running operation is done or reaches at most a specified timeout,
                /// returning the latest state. If the operation is already done, the latest state is immediately
                /// returned. If the timeout specified is greater than the default HTTP/RPC timeout, the HTTP/RPC
                /// timeout is used. If the server does not support this method, it returns
                /// `google.rpc.Code.UNIMPLEMENTED`. Note that this method is on a best-effort basis. It may return the
                /// latest state before the specified timeout (including immediately), meaning even an immediate
                /// response is no guarantee that the operation is done.
                /// </summary>
                public class WaitRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Wait request.</summary>
                    public WaitRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v1.Data.GoogleLongrunningWaitOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to wait on.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRun.v1.Data.GoogleLongrunningWaitOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "wait";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:wait";

                    /// <summary>Initializes Wait parameter list.</summary>
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

            /// <summary>Gets the Revisions resource.</summary>
            public virtual RevisionsResource Revisions { get; }

            /// <summary>The "revisions" collection of methods.</summary>
            public class RevisionsResource
            {
                private const string Resource = "revisions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RevisionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Delete a revision.</summary>
                /// <param name="name">
                /// The name of the revision to delete. For Cloud Run (fully managed), replace {namespace} with the
                /// project ID or number. It takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Delete a revision.</summary>
                public class DeleteRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Status>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the revision to delete. For Cloud Run (fully managed), replace {namespace} with the
                    /// project ID or number. It takes the form namespaces/{namespace}. For example:
                    /// namespaces/PROJECT_ID
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Cloud Run currently ignores this parameter.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("apiVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual new string ApiVersion { get; set; }

                    /// <summary>
                    /// Indicates that the server should validate the request and populate default values without
                    /// persisting the request. Supported values: `all`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("dryRun", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string DryRun { get; set; }

                    /// <summary>Cloud Run currently ignores this parameter.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("kind", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Kind { get; set; }

                    /// <summary>
                    /// Specifies the propagation policy of delete. Cloud Run currently ignores this setting, and
                    /// deletes in the background.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("propagationPolicy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PropagationPolicy { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/revisions/[^/]+$",
                        });
                        RequestParameters.Add("apiVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "apiVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("dryRun", new Google.Apis.Discovery.Parameter
                        {
                            Name = "dryRun",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("kind", new Google.Apis.Discovery.Parameter
                        {
                            Name = "kind",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("propagationPolicy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "propagationPolicy",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Get information about a revision.</summary>
                /// <param name="name">
                /// The name of the revision to retrieve. For Cloud Run (fully managed), replace {namespace} with the
                /// project ID or number. It takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Get information about a revision.</summary>
                public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Revision>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the revision to retrieve. For Cloud Run (fully managed), replace {namespace} with
                    /// the project ID or number. It takes the form namespaces/{namespace}. For example:
                    /// namespaces/PROJECT_ID
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/revisions/[^/]+$",
                        });
                    }
                }

                /// <summary>List revisions. Results are sorted by creation time, descending.</summary>
                /// <param name="parent">
                /// The namespace from which the revisions should be listed. For Cloud Run (fully managed), replace
                /// {namespace} with the project ID or number. It takes the form namespaces/{namespace}. For example:
                /// namespaces/PROJECT_ID
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List revisions. Results are sorted by creation time, descending.</summary>
                public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.ListRevisionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// The namespace from which the revisions should be listed. For Cloud Run (fully managed), replace
                    /// {namespace} with the project ID or number. It takes the form namespaces/{namespace}. For
                    /// example: namespaces/PROJECT_ID
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Encoded string to continue paging.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("continue", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Continue { get; set; }

                    /// <summary>
                    /// Allows to filter resources based on a specific value for a field name. Send this in a query
                    /// string format. i.e. 'metadata.name%3Dlorem'. Not currently used by Cloud Run.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("fieldSelector", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string FieldSelector { get; set; }

                    /// <summary>Not currently used by Cloud Run.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("includeUninitialized", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> IncludeUninitialized { get; set; }

                    /// <summary>
                    /// Allows to filter resources based on a label. Supported operations are =, !=, exists, in, and
                    /// notIn.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("labelSelector", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string LabelSelector { get; set; }

                    /// <summary>Optional. The maximum number of records that should be returned.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("limit", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> Limit { get; set; }

                    /// <summary>
                    /// The baseline resource version from which the list or watch operation should start. Not currently
                    /// used by Cloud Run.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resourceVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ResourceVersion { get; set; }

                    /// <summary>
                    /// Flag that indicates that the client expects to watch this resource as well. Not currently used
                    /// by Cloud Run.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("watch", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Watch { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/revisions";

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
                        RequestParameters.Add("continue", new Google.Apis.Discovery.Parameter
                        {
                            Name = "continue",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fieldSelector", new Google.Apis.Discovery.Parameter
                        {
                            Name = "fieldSelector",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("includeUninitialized", new Google.Apis.Discovery.Parameter
                        {
                            Name = "includeUninitialized",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("labelSelector", new Google.Apis.Discovery.Parameter
                        {
                            Name = "labelSelector",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("limit", new Google.Apis.Discovery.Parameter
                        {
                            Name = "limit",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("resourceVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resourceVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("watch", new Google.Apis.Discovery.Parameter
                        {
                            Name = "watch",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the Routes resource.</summary>
            public virtual RoutesResource Routes { get; }

            /// <summary>The "routes" collection of methods.</summary>
            public class RoutesResource
            {
                private const string Resource = "routes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RoutesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Get information about a route.</summary>
                /// <param name="name">
                /// The name of the route to retrieve. For Cloud Run (fully managed), replace {namespace} with the
                /// project ID or number. It takes the form namespaces/{namespace}. For example: namespaces/PROJECT_ID
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Get information about a route.</summary>
                public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Route>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the route to retrieve. For Cloud Run (fully managed), replace {namespace} with the
                    /// project ID or number. It takes the form namespaces/{namespace}. For example:
                    /// namespaces/PROJECT_ID
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/routes/[^/]+$",
                        });
                    }
                }

                /// <summary>List routes. Results are sorted by creation time, descending.</summary>
                /// <param name="parent">
                /// The namespace from which the routes should be listed. For Cloud Run (fully managed), replace
                /// {namespace} with the project ID or number. It takes the form namespaces/{namespace}. For example:
                /// namespaces/PROJECT_ID
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List routes. Results are sorted by creation time, descending.</summary>
                public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.ListRoutesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// The namespace from which the routes should be listed. For Cloud Run (fully managed), replace
                    /// {namespace} with the project ID or number. It takes the form namespaces/{namespace}. For
                    /// example: namespaces/PROJECT_ID
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Encoded string to continue paging.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("continue", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Continue { get; set; }

                    /// <summary>
                    /// Allows to filter resources based on a specific value for a field name. Send this in a query
                    /// string format. i.e. 'metadata.name%3Dlorem'. Not currently used by Cloud Run.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("fieldSelector", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string FieldSelector { get; set; }

                    /// <summary>Not currently used by Cloud Run.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("includeUninitialized", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> IncludeUninitialized { get; set; }

                    /// <summary>
                    /// Allows to filter resources based on a label. Supported operations are =, !=, exists, in, and
                    /// notIn.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("labelSelector", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string LabelSelector { get; set; }

                    /// <summary>Optional. The maximum number of records that should be returned.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("limit", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> Limit { get; set; }

                    /// <summary>
                    /// The baseline resource version from which the list or watch operation should start. Not currently
                    /// used by Cloud Run.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resourceVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ResourceVersion { get; set; }

                    /// <summary>
                    /// Flag that indicates that the client expects to watch this resource as well. Not currently used
                    /// by Cloud Run.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("watch", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Watch { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/routes";

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
                        RequestParameters.Add("continue", new Google.Apis.Discovery.Parameter
                        {
                            Name = "continue",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fieldSelector", new Google.Apis.Discovery.Parameter
                        {
                            Name = "fieldSelector",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("includeUninitialized", new Google.Apis.Discovery.Parameter
                        {
                            Name = "includeUninitialized",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("labelSelector", new Google.Apis.Discovery.Parameter
                        {
                            Name = "labelSelector",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("limit", new Google.Apis.Discovery.Parameter
                        {
                            Name = "limit",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("resourceVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resourceVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("watch", new Google.Apis.Discovery.Parameter
                        {
                            Name = "watch",
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
                }

                /// <summary>
                /// Creates a new Service. Service creation will trigger a new deployment. Use GetService, and check
                /// service.status to determine if the Service is ready.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource's parent. In Cloud Run, it may be one of the following: *
                /// `{project_id_or_number}` * `namespaces/{project_id_or_number}` *
                /// `namespaces/{project_id_or_number}/services` * `projects/{project_id_or_number}/locations/{region}`
                /// * `projects/{project_id_or_number}/regions/{region}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudRun.v1.Data.Service body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a new Service. Service creation will trigger a new deployment. Use GetService, and check
                /// service.status to determine if the Service is ready.
                /// </summary>
                public class CreateRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Service>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v1.Data.Service body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource's parent. In Cloud Run, it may be one of the following: *
                    /// `{project_id_or_number}` * `namespaces/{project_id_or_number}` *
                    /// `namespaces/{project_id_or_number}/services` *
                    /// `projects/{project_id_or_number}/locations/{region}` *
                    /// `projects/{project_id_or_number}/regions/{region}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Indicates that the server should validate the request and populate default values without
                    /// persisting the request. Supported values: `all`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("dryRun", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string DryRun { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRun.v1.Data.Service Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/services";

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
                        RequestParameters.Add("dryRun", new Google.Apis.Discovery.Parameter
                        {
                            Name = "dryRun",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes the provided service. This will cause the Service to stop serving traffic and will delete
                /// all associated Revisions.
                /// </summary>
                /// <param name="name">
                /// Required. The fully qualified name of the service to delete. It can be any of the following forms: *
                /// `namespaces/{project_id_or_number}/services/{service_name}` (only when the `endpoint` is regional) *
                /// `projects/{project_id_or_number}/locations/{region}/services/{service_name}` *
                /// `projects/{project_id_or_number}/regions/{region}/services/{service_name}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes the provided service. This will cause the Service to stop serving traffic and will delete
                /// all associated Revisions.
                /// </summary>
                public class DeleteRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Status>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The fully qualified name of the service to delete. It can be any of the following
                    /// forms: * `namespaces/{project_id_or_number}/services/{service_name}` (only when the `endpoint`
                    /// is regional) * `projects/{project_id_or_number}/locations/{region}/services/{service_name}` *
                    /// `projects/{project_id_or_number}/regions/{region}/services/{service_name}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Not supported, and ignored by Cloud Run.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("apiVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual new string ApiVersion { get; set; }

                    /// <summary>
                    /// Indicates that the server should validate the request and populate default values without
                    /// persisting the request. Supported values: `all`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("dryRun", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string DryRun { get; set; }

                    /// <summary>Not supported, and ignored by Cloud Run.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("kind", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Kind { get; set; }

                    /// <summary>Not supported, and ignored by Cloud Run.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("propagationPolicy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PropagationPolicy { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                        RequestParameters.Add("apiVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "apiVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("dryRun", new Google.Apis.Discovery.Parameter
                        {
                            Name = "dryRun",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("kind", new Google.Apis.Discovery.Parameter
                        {
                            Name = "kind",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("propagationPolicy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "propagationPolicy",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets information about a service.</summary>
                /// <param name="name">
                /// Required. The fully qualified name of the service to retrieve. It can be any of the following forms:
                /// * `namespaces/{project_id_or_number}/services/{service_name}` (only when the `endpoint` is regional)
                /// * `projects/{project_id_or_number}/locations/{region}/services/{service_name}` *
                /// `projects/{project_id_or_number}/regions/{region}/services/{service_name}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets information about a service.</summary>
                public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Service>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The fully qualified name of the service to retrieve. It can be any of the following
                    /// forms: * `namespaces/{project_id_or_number}/services/{service_name}` (only when the `endpoint`
                    /// is regional) * `projects/{project_id_or_number}/locations/{region}/services/{service_name}` *
                    /// `projects/{project_id_or_number}/regions/{region}/services/{service_name}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the IAM Access Control policy currently in effect for the given Cloud Run service. This result
                /// does not include any inherited policies.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(this.service, resource);
                }

                /// <summary>
                /// Gets the IAM Access Control policy currently in effect for the given Cloud Run service. This result
                /// does not include any inherited policies.
                /// </summary>
                public class GetIamPolicyRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Policy>
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

                /// <summary>
                /// Lists services for the given project and region. Results are sorted by creation time, descending.
                /// </summary>
                /// <param name="parent">
                /// Required. The parent from where the resources should be listed. In Cloud Run, it may be one of the
                /// following: * `{project_id_or_number}` * `namespaces/{project_id_or_number}` *
                /// `namespaces/{project_id_or_number}/services` * `projects/{project_id_or_number}/locations/{region}`
                /// * `projects/{project_id_or_number}/regions/{region}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists services for the given project and region. Results are sorted by creation time, descending.
                /// </summary>
                public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.ListServicesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent from where the resources should be listed. In Cloud Run, it may be one of
                    /// the following: * `{project_id_or_number}` * `namespaces/{project_id_or_number}` *
                    /// `namespaces/{project_id_or_number}/services` *
                    /// `projects/{project_id_or_number}/locations/{region}` *
                    /// `projects/{project_id_or_number}/regions/{region}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Encoded string to continue paging.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("continue", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Continue { get; set; }

                    /// <summary>Not supported, and ignored by Cloud Run.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("fieldSelector", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string FieldSelector { get; set; }

                    /// <summary>Not supported, and ignored by Cloud Run.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("includeUninitialized", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> IncludeUninitialized { get; set; }

                    /// <summary>
                    /// Allows to filter resources based on a label. Supported operations are =, !=, exists, in, and
                    /// notIn.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("labelSelector", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string LabelSelector { get; set; }

                    /// <summary>The maximum number of records that should be returned.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("limit", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> Limit { get; set; }

                    /// <summary>Not supported, and ignored by Cloud Run.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("resourceVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ResourceVersion { get; set; }

                    /// <summary>Not supported, and ignored by Cloud Run.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("watch", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Watch { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/services";

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
                        RequestParameters.Add("continue", new Google.Apis.Discovery.Parameter
                        {
                            Name = "continue",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fieldSelector", new Google.Apis.Discovery.Parameter
                        {
                            Name = "fieldSelector",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("includeUninitialized", new Google.Apis.Discovery.Parameter
                        {
                            Name = "includeUninitialized",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("labelSelector", new Google.Apis.Discovery.Parameter
                        {
                            Name = "labelSelector",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("limit", new Google.Apis.Discovery.Parameter
                        {
                            Name = "limit",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("resourceVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resourceVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("watch", new Google.Apis.Discovery.Parameter
                        {
                            Name = "watch",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Replaces a service. Only the spec and metadata labels and annotations are modifiable. After the
                /// Update request, Cloud Run will work to make the 'status' match the requested 'spec'. May provide
                /// metadata.resourceVersion to enforce update from last read for optimistic concurrency control.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The fully qualified name of the service to replace. It can be any of the following forms:
                /// * `namespaces/{project_id_or_number}/services/{service_name}` (only when the `endpoint` is regional)
                /// * `projects/{project_id_or_number}/locations/{region}/services/{service_name}` *
                /// `projects/{project_id_or_number}/regions/{region}/services/{service_name}`
                /// </param>
                public virtual ReplaceServiceRequest ReplaceService(Google.Apis.CloudRun.v1.Data.Service body, string name)
                {
                    return new ReplaceServiceRequest(this.service, body, name);
                }

                /// <summary>
                /// Replaces a service. Only the spec and metadata labels and annotations are modifiable. After the
                /// Update request, Cloud Run will work to make the 'status' match the requested 'spec'. May provide
                /// metadata.resourceVersion to enforce update from last read for optimistic concurrency control.
                /// </summary>
                public class ReplaceServiceRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Service>
                {
                    /// <summary>Constructs a new ReplaceService request.</summary>
                    public ReplaceServiceRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v1.Data.Service body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The fully qualified name of the service to replace. It can be any of the following
                    /// forms: * `namespaces/{project_id_or_number}/services/{service_name}` (only when the `endpoint`
                    /// is regional) * `projects/{project_id_or_number}/locations/{region}/services/{service_name}` *
                    /// `projects/{project_id_or_number}/regions/{region}/services/{service_name}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Indicates that the server should validate the request and populate default values without
                    /// persisting the request. Supported values: `all`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("dryRun", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string DryRun { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRun.v1.Data.Service Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "replaceService";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes ReplaceService parameter list.</summary>
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
                        RequestParameters.Add("dryRun", new Google.Apis.Discovery.Parameter
                        {
                            Name = "dryRun",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Sets the IAM Access control policy for the specified Service. Overwrites any existing policy.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudRun.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the IAM Access control policy for the specified Service. Overwrites any existing policy.
                /// </summary>
                public class SetIamPolicyRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.CloudRun.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified Project. There are no permissions required
                /// for making this API call.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudRun.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified Project. There are no permissions required
                /// for making this API call.
                /// </summary>
                public class TestIamPermissionsRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.CloudRun.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Workerpools resource.</summary>
            public virtual WorkerpoolsResource Workerpools { get; }

            /// <summary>The "workerpools" collection of methods.</summary>
            public class WorkerpoolsResource
            {
                private const string Resource = "workerpools";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public WorkerpoolsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Get the IAM Access Control policy currently in effect for the given worker pool. This result does
                /// not include any inherited policies.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(this.service, resource);
                }

                /// <summary>
                /// Get the IAM Access Control policy currently in effect for the given worker pool. This result does
                /// not include any inherited policies.
                /// </summary>
                public class GetIamPolicyRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Policy>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workerpools/[^/]+$",
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
                /// Sets the IAM Access control policy for the specified worker pool. Overwrites any existing policy.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudRun.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the IAM Access control policy for the specified worker pool. Overwrites any existing policy.
                /// </summary>
                public class SetIamPolicyRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.CloudRun.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workerpools/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified worker pool. There are no permissions
                /// required for making this API call.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudRun.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified worker pool. There are no permissions
                /// required for making this API call.
                /// </summary>
                public class TestIamPermissionsRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.CloudRun.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workerpools/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.ListLocationsResponse>
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
namespace Google.Apis.CloudRun.v1.Data
{
    /// <summary>Information for connecting over HTTP(s).</summary>
    public class Addressable : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

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

    /// <summary>
    /// A domain that a user has been authorized to administer. To authorize use of a domain, verify ownership via
    /// [Search Console](https://search.google.com/search-console/welcome).
    /// </summary>
    public class AuthorizedDomain : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Relative name of the domain authorized for use. Example: `example.com`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Deprecated Read only. Full path to the `AuthorizedDomain` resource in the API. Example:
        /// `projects/myproject/authorizedDomains/example.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

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
        /// represents a Google group. For example, `admins@example.com`. * `domain:{domain}`: The G Suite domain
        /// (primary) that represents all the users of that domain. For example, `google.com` or `example.com`. *
        /// `principal://iam.googleapis.com/locations/global/workforcePools/{pool_id}/subject/{subject_attribute_value}`:
        /// A single identity in a workforce identity pool. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/group/{group_id}`: All
        /// workforce identities in a group. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/attribute.{attribute_name}/{attribute_value}`:
        /// All workforce identities with a specific attribute value. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/*`: All identities in a
        /// workforce identity pool. *
        /// `principal://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/subject/{subject_attribute_value}`:
        /// A single identity in a workload identity pool. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/group/{group_id}`:
        /// A workload identity pool group. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/attribute.{attribute_name}/{attribute_value}`:
        /// All identities in a workload identity pool with a certain attribute. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/*`:
        /// All identities in a workload identity pool. * `deleted:user:{emailid}?uid={uniqueid}`: An email address
        /// (plus unique identifier) representing a user that has been recently deleted. For example,
        /// `alice@example.com?uid=123456789012345678901`. If the user is recovered, this value reverts to
        /// `user:{emailid}` and the recovered user retains the role in the binding. *
        /// `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a
        /// service account that has been recently deleted. For example,
        /// `my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted,
        /// this value reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the
        /// binding. * `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing
        /// a Google group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`.
        /// If the group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role
        /// in the binding. *
        /// `deleted:principal://iam.googleapis.com/locations/global/workforcePools/{pool_id}/subject/{subject_attribute_value}`:
        /// Deleted single identity in a workforce identity pool. For example,
        /// `deleted:principal://iam.googleapis.com/locations/global/workforcePools/my-pool-id/subject/my-subject-attribute-value`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Role that is assigned to the list of `members`, or principals. For example, `roles/viewer`, `roles/editor`,
        /// or `roles/owner`. For an overview of the IAM roles and permissions, see the [IAM
        /// documentation](https://cloud.google.com/iam/docs/roles-overview). For a list of the available pre-defined
        /// roles, see [here](https://cloud.google.com/iam/docs/understanding-roles).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Storage volume source using the Container Storage Interface.</summary>
    public class CSIVolumeSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// name of the CSI driver for the requested storage system. Cloud Run supports the following drivers: *
        /// gcsfuse.run.googleapis.com : Mount a Cloud Storage Bucket as a volume.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driver")]
        public virtual string Driver { get; set; }

        /// <summary>If true, mount the volume as read only. Defaults to false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readOnly")]
        public virtual System.Nullable<bool> ReadOnly__ { get; set; }

        /// <summary>
        /// stores driver specific attributes. For Google Cloud Storage volumes, the following attributes are supported:
        /// * bucketName: the name of the Cloud Storage bucket to mount. The Cloud Run Service identity must have access
        /// to this bucket.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeAttributes")]
        public virtual System.Collections.Generic.IDictionary<string, string> VolumeAttributes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for cancelling an execution.</summary>
    public class CancelExecutionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Not supported by Cloud Run. ConfigMapEnvSource selects a ConfigMap to populate the environment variables with.
    /// The contents of the target ConfigMap's Data field will represent the key-value pairs as environment variables.
    /// </summary>
    public class ConfigMapEnvSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This field should not be used directly as it is meant to be inlined directly into the message. Use the
        /// "name" field instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localObjectReference")]
        public virtual LocalObjectReference LocalObjectReference { get; set; }

        /// <summary>The ConfigMap to select from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Specify whether the ConfigMap must be defined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optional")]
        public virtual System.Nullable<bool> Optional { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Not supported by Cloud Run.</summary>
    public class ConfigMapKeySelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Not supported by Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Not supported by Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localObjectReference")]
        public virtual LocalObjectReference LocalObjectReference { get; set; }

        /// <summary>Required. Not supported by Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Not supported by Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optional")]
        public virtual System.Nullable<bool> Optional { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Not supported by Cloud Run. Adapts a ConfigMap into a volume. The contents of the target ConfigMap's Data field
    /// will be presented in a volume as files using the keys in the Data field as the file names, unless the items
    /// element is populated with specific mappings of keys to paths.
    /// </summary>
    public class ConfigMapVolumeSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// (Optional) Integer representation of mode bits to use on created files by default. Must be a value between
        /// 01 and 0777 (octal). If 0 or not set, it will default to 0644. Directories within the path are not affected
        /// by this setting. Notes * Internally, a umask of 0222 will be applied to any non-zero value. * This is an
        /// integer representation of the mode bits. So, the octal integer value should look exactly as the chmod
        /// numeric notation with a leading zero. Some examples: for chmod 777 (a=rwx), set to 0777 (octal) or 511
        /// (base-10). For chmod 640 (u=rw,g=r), set to 0640 (octal) or 416 (base-10). For chmod 755 (u=rwx,g=rx,o=rx),
        /// set to 0755 (octal) or 493 (base-10). * This might be in conflict with other options that affect the file
        /// mode, like fsGroup, and the result can be other mode bits set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultMode")]
        public virtual System.Nullable<int> DefaultMode { get; set; }

        /// <summary>
        /// (Optional) If unspecified, each key-value pair in the Data field of the referenced Secret will be projected
        /// into the volume as a file whose name is the key and content is the value. If specified, the listed keys will
        /// be projected into the specified paths, and unlisted keys will not be present. If a key is specified that is
        /// not present in the Secret, the volume setup will error unless it is marked optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<KeyToPath> Items { get; set; }

        /// <summary>Name of the config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>(Optional) Specify whether the Secret or its keys must be defined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optional")]
        public virtual System.Nullable<bool> Optional { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration represents the "floating HEAD" of a linear history of Revisions, and optionally how the containers
    /// those revisions reference are built. Users create new Revisions by updating the Configuration's spec. The
    /// "latest created" revision's name is available under status, as is the "latest ready" revision's name.
    /// </summary>
    public class Configuration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API version for this call such as "serving.knative.dev/v1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>The kind of resource, in this case always "Configuration".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Metadata associated with this Configuration, including name, namespace, labels, and annotations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ObjectMeta Metadata { get; set; }

        /// <summary>Spec holds the desired state of the Configuration (from the client).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual ConfigurationSpec Spec { get; set; }

        /// <summary>Status communicates the observed state of the Configuration (from the controller).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ConfigurationStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ConfigurationSpec holds the desired state of the Configuration (from the client).</summary>
    public class ConfigurationSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Template holds the latest specification for the Revision to be stamped out.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("template")]
        public virtual RevisionTemplate Template { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ConfigurationStatus communicates the observed state of the Configuration (from the controller).
    /// </summary>
    public class ConfigurationStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Conditions communicate information about ongoing/complete reconciliation processes that bring the "spec"
        /// inline with the observed state of the world.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV1Condition> Conditions { get; set; }

        /// <summary>
        /// LatestCreatedRevisionName is the last revision that was created from this Configuration. It might not be
        /// ready yet, so for the latest ready revision, use LatestReadyRevisionName.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestCreatedRevisionName")]
        public virtual string LatestCreatedRevisionName { get; set; }

        /// <summary>
        /// LatestReadyRevisionName holds the name of the latest Revision stamped out from this Configuration that has
        /// had its "Ready" condition become "True".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestReadyRevisionName")]
        public virtual string LatestReadyRevisionName { get; set; }

        /// <summary>
        /// ObservedGeneration is the 'Generation' of the Configuration that was last processed by the controller. The
        /// observed generation is updated even if the controller failed to process the spec and create the Revision.
        /// Clients polling for completed reconciliation should poll until observedGeneration = metadata.generation, and
        /// the Ready condition's status is True or False.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observedGeneration")]
        public virtual System.Nullable<int> ObservedGeneration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A single application container. This specifies both the container to run, the command to run in the container
    /// and the arguments to supply to it. Note that additional arguments may be supplied by the system to the container
    /// at runtime.
    /// </summary>
    public class Container : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Arguments to the entrypoint. The docker image's CMD is used if this is not provided. Variable references are
        /// not supported in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>
        /// Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not
        /// provided. Variable references are not supported in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("command")]
        public virtual System.Collections.Generic.IList<string> Command { get; set; }

        /// <summary>
        /// List of environment variables to set in the container. EnvVar with duplicate names are generally allowed; if
        /// referencing a secret, the name must be unique for the container. For non-secret EnvVar names, the Container
        /// will only get the last-declared one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual System.Collections.Generic.IList<EnvVar> Env { get; set; }

        /// <summary>Not supported by Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("envFrom")]
        public virtual System.Collections.Generic.IList<EnvFromSource> EnvFrom { get; set; }

        /// <summary>
        /// Required. Name of the container image in Dockerhub, Google Artifact Registry, or Google Container Registry.
        /// If the host is not provided, Dockerhub is assumed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual string Image { get; set; }

        /// <summary>
        /// Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is specified, or
        /// IfNotPresent otherwise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imagePullPolicy")]
        public virtual string ImagePullPolicy { get; set; }

        /// <summary>Periodic probe of container liveness. Container will be restarted if the probe fails.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("livenessProbe")]
        public virtual Probe LivenessProbe { get; set; }

        /// <summary>Name of the container specified as a DNS_LABEL (RFC 1123).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// List of ports to expose from the container. Only a single port can be specified. The specified ports must be
        /// listening on all interfaces (0.0.0.0) within the container to be accessible. If omitted, a port number will
        /// be chosen and passed to the container through the PORT environment variable for the container to listen on.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ports")]
        public virtual System.Collections.Generic.IList<ContainerPort> Ports { get; set; }

        /// <summary>Readiness probe to be used for health checks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readinessProbe")]
        public virtual Probe ReadinessProbe { get; set; }

        /// <summary>Compute Resources required by this container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual ResourceRequirements Resources { get; set; }

        /// <summary>Not supported by Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityContext")]
        public virtual SecurityContext SecurityContext { get; set; }

        /// <summary>
        /// Startup probe of application within the container. All other probes are disabled if a startup probe is
        /// provided, until it succeeds. Container will not receive traffic if the probe fails. If not provided, a
        /// default startup probe with TCP socket action is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startupProbe")]
        public virtual Probe StartupProbe { get; set; }

        /// <summary>
        /// Path at which the file to which the container's termination message will be written is mounted into the
        /// container's filesystem. Message written is intended to be brief final status, such as an assertion failure
        /// message. Will be truncated by the node if greater than 4096 bytes. The total message length across all
        /// containers will be limited to 12kb. Defaults to /dev/termination-log.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terminationMessagePath")]
        public virtual string TerminationMessagePath { get; set; }

        /// <summary>
        /// Indicate how the termination message should be populated. File will use the contents of
        /// terminationMessagePath to populate the container status message on both success and failure.
        /// FallbackToLogsOnError will use the last chunk of container log output if the termination message file is
        /// empty and the container exited with an error. The log output is limited to 2048 bytes or 80 lines, whichever
        /// is smaller. Defaults to File. Cannot be updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terminationMessagePolicy")]
        public virtual string TerminationMessagePolicy { get; set; }

        /// <summary>
        /// Volume to mount into the container's filesystem. Only supports SecretVolumeSources. Pod volumes to mount
        /// into the container's filesystem.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeMounts")]
        public virtual System.Collections.Generic.IList<VolumeMount> VolumeMounts { get; set; }

        /// <summary>
        /// Container's working directory. If not specified, the container runtime's default will be used, which might
        /// be configured in the container image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workingDir")]
        public virtual string WorkingDir { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Per container override specification.</summary>
    public class ContainerOverride : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Arguments to the entrypoint. The specified arguments replace and override any existing entrypoint arguments.
        /// Must be empty if `clear_args` is set to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>Optional. Set to True to clear all existing arguments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clearArgs")]
        public virtual System.Nullable<bool> ClearArgs { get; set; }

        /// <summary>
        /// List of environment variables to set in the container. All specified environment variables are merged with
        /// existing environment variables. When the specified environment variables exist, these values override any
        /// existing values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual System.Collections.Generic.IList<EnvVar> Env { get; set; }

        /// <summary>The name of the container specified as a DNS_LABEL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ContainerPort represents a network port in a single container.</summary>
    public class ContainerPort : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Port number the container listens on. If present, this must be a valid port number, 0 &amp;lt; x &amp;lt;
        /// 65536. If not present, it will default to port 8080. For more information, see
        /// https://cloud.google.com/run/docs/container-contract#port
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerPort")]
        public virtual System.Nullable<int> ContainerPortValue { get; set; }

        /// <summary>
        /// If specified, used to specify which protocol to use. Allowed values are "http1" and "h2c".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Protocol for port. Must be "TCP". Defaults to "TCP".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Resource to hold the state and status of a user's domain mapping. NOTE: This resource is currently in Beta.
    /// </summary>
    public class DomainMapping : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API version for this call such as "domains.cloudrun.com/v1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>The kind of resource, in this case "DomainMapping".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Metadata associated with this BuildTemplate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ObjectMeta Metadata { get; set; }

        /// <summary>The spec for this DomainMapping.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual DomainMappingSpec Spec { get; set; }

        /// <summary>The current status of the DomainMapping.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual DomainMappingStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The desired state of the Domain Mapping.</summary>
    public class DomainMappingSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The mode of the certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateMode")]
        public virtual string CertificateMode { get; set; }

        /// <summary>
        /// If set, the mapping will override any mapping set before this spec was set. It is recommended that the user
        /// leaves this empty to receive an error warning about a potential conflict and only set it once the respective
        /// UI has given such a warning.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forceOverride")]
        public virtual System.Nullable<bool> ForceOverride { get; set; }

        /// <summary>The name of the Knative Route that this DomainMapping applies to. The route must exist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routeName")]
        public virtual string RouteName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The current state of the Domain Mapping.</summary>
    public class DomainMappingStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Array of observed DomainMappingConditions, indicating the current state of the DomainMapping.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV1Condition> Conditions { get; set; }

        /// <summary>The name of the route that the mapping currently points to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mappedRouteName")]
        public virtual string MappedRouteName { get; set; }

        /// <summary>
        /// ObservedGeneration is the 'Generation' of the DomainMapping that was last processed by the controller.
        /// Clients polling for completed reconciliation should poll until observedGeneration = metadata.generation and
        /// the Ready condition's status is True or False.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observedGeneration")]
        public virtual System.Nullable<int> ObservedGeneration { get; set; }

        /// <summary>
        /// The resource records required to configure this domain mapping. These records must be added to the domain's
        /// DNS configuration in order to serve the application via this domain mapping.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceRecords")]
        public virtual System.Collections.Generic.IList<ResourceRecord> ResourceRecords { get; set; }

        /// <summary>Optional. Not supported by Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

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
    /// In memory (tmpfs) ephemeral storage. It is ephemeral in the sense that when the sandbox is taken down, the data
    /// is destroyed with it (it does not persist across sandbox runs).
    /// </summary>
    public class EmptyDirVolumeSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The medium on which the data is stored. The default is "" which means to use the node's default medium. Must
        /// be an empty string (default) or Memory. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#emptydir
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("medium")]
        public virtual string Medium { get; set; }

        /// <summary>
        /// Limit on the storage usable by this EmptyDir volume. The size limit is also applicable for memory medium.
        /// The maximum usage on memory medium EmptyDir would be the minimum value between the SizeLimit specified here
        /// and the sum of memory limits of all containers. The default is nil which means that the limit is undefined.
        /// More info: https://cloud.google.com/run/docs/configuring/in-memory-volumes#configure-volume. Info in
        /// Kubernetes: https://kubernetes.io/docs/concepts/storage/volumes/#emptydir
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeLimit")]
        public virtual string SizeLimit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Not supported by Cloud Run. EnvFromSource represents the source of a set of ConfigMaps</summary>
    public class EnvFromSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ConfigMap to select from</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configMapRef")]
        public virtual ConfigMapEnvSource ConfigMapRef { get; set; }

        /// <summary>An optional identifier to prepend to each key in the ConfigMap. Must be a C_IDENTIFIER.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prefix")]
        public virtual string Prefix { get; set; }

        /// <summary>The Secret to select from</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretRef")]
        public virtual SecretEnvSource SecretRef { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>EnvVar represents an environment variable present in a Container.</summary>
    public class EnvVar : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Name of the environment variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Value of the environment variable. Defaults to "". Variable references are not supported in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>
        /// Source for the environment variable's value. Only supports secret_key_ref. Cannot be used if value is not
        /// empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueFrom")]
        public virtual EnvVarSource ValueFrom { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>EnvVarSource represents a source for the value of an EnvVar.</summary>
    public class EnvVarSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Not supported by Cloud Run. Not supported in Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configMapKeyRef")]
        public virtual ConfigMapKeySelector ConfigMapKeyRef { get; set; }

        /// <summary>Selects a key (version) of a secret in Secret Manager.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretKeyRef")]
        public virtual SecretKeySelector SecretKeyRef { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Not supported by Cloud Run. ExecAction describes a "run in container" action.</summary>
    public class ExecAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Command is the command line to execute inside the container, the working directory for the command is root
        /// ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so
        /// traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to
        /// that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("command")]
        public virtual System.Collections.Generic.IList<string> Command { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Execution represents the configuration of a single execution. An execution is an immutable resource that
    /// references a container image which is run to completion.
    /// </summary>
    public class Execution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. APIVersion defines the versioned schema of this representation of an object. Servers should
        /// convert recognized schemas to the latest internal value, and may reject unrecognized values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>
        /// Optional. Kind is a string value representing the REST resource this object represents. Servers may infer
        /// this from the endpoint the client submits requests to. Cannot be updated. In CamelCase.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Optional. Standard object's metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ObjectMeta Metadata { get; set; }

        /// <summary>Optional. Specification of the desired behavior of an execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual ExecutionSpec Spec { get; set; }

        /// <summary>Output only. Current status of an execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ExecutionStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Reference to an Execution. Use /Executions.GetExecution with the given name to get full execution including the
    /// latest status.
    /// </summary>
    public class ExecutionReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Status for the execution completion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionStatus")]
        public virtual string CompletionStatus { get; set; }

        private string _completionTimestampRaw;

        private object _completionTimestamp;

        /// <summary>Optional. Completion timestamp of the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionTimestamp")]
        public virtual string CompletionTimestampRaw
        {
            get => _completionTimestampRaw;
            set
            {
                _completionTimestamp = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _completionTimestampRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CompletionTimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CompletionTimestampDateTimeOffset instead.")]
        public virtual object CompletionTimestamp
        {
            get => _completionTimestamp;
            set
            {
                _completionTimestampRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _completionTimestamp = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="CompletionTimestampRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CompletionTimestampDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CompletionTimestampRaw);
            set => CompletionTimestampRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _creationTimestampRaw;

        private object _creationTimestamp;

        /// <summary>Optional. Creation timestamp of the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTimestamp")]
        public virtual string CreationTimestampRaw
        {
            get => _creationTimestampRaw;
            set
            {
                _creationTimestamp = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _creationTimestampRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreationTimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreationTimestampDateTimeOffset instead.")]
        public virtual object CreationTimestamp
        {
            get => _creationTimestamp;
            set
            {
                _creationTimestampRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _creationTimestamp = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="CreationTimestampRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreationTimestampDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreationTimestampRaw);
            set => CreationTimestampRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _deletionTimestampRaw;

        private object _deletionTimestamp;

        /// <summary>Optional. The read-only soft deletion timestamp of the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionTimestamp")]
        public virtual string DeletionTimestampRaw
        {
            get => _deletionTimestampRaw;
            set
            {
                _deletionTimestamp = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deletionTimestampRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeletionTimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeletionTimestampDateTimeOffset instead.")]
        public virtual object DeletionTimestamp
        {
            get => _deletionTimestamp;
            set
            {
                _deletionTimestampRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deletionTimestamp = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="DeletionTimestampRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeletionTimestampDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeletionTimestampRaw);
            set => DeletionTimestampRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. Name of the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ExecutionSpec describes how the execution will look.</summary>
    public class ExecutionSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specifies the maximum desired number of tasks the execution should run at given time. When the job
        /// is run, if this field is 0 or unset, the maximum possible value will be used for that execution. The actual
        /// number of tasks running in steady state will be less than this number when there are fewer tasks waiting to
        /// be completed, i.e. when the work left to do is less than max parallelism.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parallelism")]
        public virtual System.Nullable<int> Parallelism { get; set; }

        /// <summary>
        /// Optional. Specifies the desired number of tasks the execution should run. Setting to 1 means that
        /// parallelism is limited to 1 and the success of that task signals the success of the execution. Defaults to
        /// 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskCount")]
        public virtual System.Nullable<int> TaskCount { get; set; }

        /// <summary>Optional. The template used to create tasks for this execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("template")]
        public virtual TaskTemplateSpec Template { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ExecutionStatus represents the current state of an Execution.</summary>
    public class ExecutionStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The number of tasks which reached phase Cancelled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelledCount")]
        public virtual System.Nullable<int> CancelledCount { get; set; }

        private string _completionTimeRaw;

        private object _completionTime;

        /// <summary>
        /// Optional. Represents the time that the execution was completed. It is not guaranteed to be set in
        /// happens-before order across separate operations. It is represented in RFC3339 form and is in UTC. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionTime")]
        public virtual string CompletionTimeRaw
        {
            get => _completionTimeRaw;
            set
            {
                _completionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _completionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CompletionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CompletionTimeDateTimeOffset instead.")]
        public virtual object CompletionTime
        {
            get => _completionTime;
            set
            {
                _completionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _completionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="CompletionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CompletionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CompletionTimeRaw);
            set => CompletionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. Conditions communicate information about ongoing/complete reconciliation processes that bring the
        /// "spec" inline with the observed state of the world. Execution-specific conditions include: *
        /// `ResourcesAvailable`: `True` when underlying resources have been provisioned. * `Started`: `True` when the
        /// execution has started to execute. * `Completed`: `True` when the execution has succeeded. `False` when the
        /// execution has failed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV1Condition> Conditions { get; set; }

        /// <summary>Optional. The number of tasks which reached phase Failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedCount")]
        public virtual System.Nullable<int> FailedCount { get; set; }

        /// <summary>Optional. URI where logs for this execution can be found in Cloud Console.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logUri")]
        public virtual string LogUri { get; set; }

        /// <summary>Optional. The 'generation' of the execution that was last processed by the controller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observedGeneration")]
        public virtual System.Nullable<int> ObservedGeneration { get; set; }

        /// <summary>Optional. The number of tasks which have retried at least once.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retriedCount")]
        public virtual System.Nullable<int> RetriedCount { get; set; }

        /// <summary>Optional. The number of actively running tasks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runningCount")]
        public virtual System.Nullable<int> RunningCount { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>
        /// Optional. Represents the time that the execution started to run. It is not guaranteed to be set in
        /// happens-before order across separate operations. It is represented in RFC3339 form and is in UTC.
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

        /// <summary>Optional. The number of tasks which reached phase Succeeded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("succeededCount")]
        public virtual System.Nullable<int> SucceededCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ExecutionTemplateSpec describes the metadata and spec an Execution should have when created from a job.
    /// </summary>
    public class ExecutionTemplateSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Optional metadata for this Execution, including labels and annotations. The following annotation
        /// keys set properties of the created execution: * `run.googleapis.com/cloudsql-instances` sets Cloud SQL
        /// connections. Multiple values should be comma separated. * `run.googleapis.com/vpc-access-connector` sets a
        /// Serverless VPC Access connector. * `run.googleapis.com/vpc-access-egress` sets VPC egress. Supported values
        /// are `all-traffic`, `all` (deprecated), and `private-ranges-only`. `all-traffic` and `all` provide the same
        /// functionality. `all` is deprecated but will continue to be supported. Prefer `all-traffic`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ObjectMeta Metadata { get; set; }

        /// <summary>Required. ExecutionSpec holds the desired configuration for executions of this job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual ExecutionSpec Spec { get; set; }

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

    /// <summary>GRPCAction describes an action involving a GRPC port.</summary>
    public class GRPCAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Port number of the gRPC service. Number must be in the range 1 to 65535.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>
        /// Service is the name of the service to place in the gRPC HealthCheckRequest. If this is not specified, the
        /// default behavior is defined by gRPC.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Conditions show the status of reconciliation progress on a given resource. Most resource use a top-level
    /// condition type "Ready" or "Completed" to show overall status with other conditions to checkpoint each stage of
    /// reconciliation. Note that if metadata.Generation does not equal status.ObservedGeneration, the conditions shown
    /// may not be relevant for the current spec.
    /// </summary>
    public class GoogleCloudRunV1Condition : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _lastTransitionTimeRaw;

        private object _lastTransitionTime;

        /// <summary>Optional. Last time the condition transitioned from one status to another.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastTransitionTime")]
        public virtual string LastTransitionTimeRaw
        {
            get => _lastTransitionTimeRaw;
            set
            {
                _lastTransitionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastTransitionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastTransitionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastTransitionTimeDateTimeOffset instead.")]
        public virtual object LastTransitionTime
        {
            get => _lastTransitionTime;
            set
            {
                _lastTransitionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastTransitionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastTransitionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastTransitionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastTransitionTimeRaw);
            set => LastTransitionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. Human readable message indicating details about the current status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>
        /// Optional. One-word CamelCase reason for the condition's last transition. These are intended to be stable,
        /// unique values which the client may use to trigger error handling logic, whereas messages which may be
        /// changed later by the server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>
        /// Optional. How to interpret this condition. One of Error, Warning, or Info. Conditions of severity Info do
        /// not contribute to resource readiness.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>Status of the condition, one of True, False, Unknown.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// type is used to communicate the status of the reconciliation process. Types common to all resources include:
        /// * "Ready" or "Completed": True when the Resource is ready.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ApprovalConfig describes configuration for manual approval of a build.</summary>
    public class GoogleDevtoolsCloudbuildV1ApprovalConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether or not approval is needed. If this is set on a build, it will become pending when created, and will
        /// need to be explicitly approved to start.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approvalRequired")]
        public virtual System.Nullable<bool> ApprovalRequired { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ApprovalResult describes the decision and associated metadata of a manual approval of a build.
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1ApprovalResult : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _approvalTimeRaw;

        private object _approvalTime;

        /// <summary>Output only. The time when the approval decision was made.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approvalTime")]
        public virtual string ApprovalTimeRaw
        {
            get => _approvalTimeRaw;
            set
            {
                _approvalTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _approvalTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ApprovalTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ApprovalTimeDateTimeOffset instead.")]
        public virtual object ApprovalTime
        {
            get => _approvalTime;
            set
            {
                _approvalTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _approvalTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ApprovalTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ApprovalTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ApprovalTimeRaw);
            set => ApprovalTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. Email of the user that called the ApproveBuild API to approve or reject a build at the time
        /// that the API was called.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approverAccount")]
        public virtual string ApproverAccount { get; set; }

        /// <summary>Optional. An optional comment for this manual approval result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comment")]
        public virtual string Comment { get; set; }

        /// <summary>Required. The decision of this manual approval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("decision")]
        public virtual string Decision { get; set; }

        /// <summary>
        /// Optional. An optional URL tied to this manual approval result. This field is essentially the same as
        /// comment, except that it will be rendered by the UI differently. An example use case is a link to an external
        /// job that approved this Build.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Files in the workspace to upload to Cloud Storage upon successful completion of all build steps.
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1ArtifactObjects : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Cloud Storage bucket and optional object path, in the form "gs://bucket/path/to/somewhere/". (see [Bucket
        /// Name Requirements](https://cloud.google.com/storage/docs/bucket-naming#requirements)). Files in the
        /// workspace matching any path pattern will be uploaded to Cloud Storage with this location as a prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Path globs used to match files in the build's workspace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paths")]
        public virtual System.Collections.Generic.IList<string> Paths { get; set; }

        /// <summary>Output only. Stores timing information for pushing all artifact objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timing")]
        public virtual GoogleDevtoolsCloudbuildV1TimeSpan Timing { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Artifacts produced by a build that should be uploaded upon successful completion of all build steps.
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1Artifacts : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A list of Go modules to be uploaded to Artifact Registry upon successful completion of all build
        /// steps. If any objects fail to be pushed, the build is marked FAILURE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goModules")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1GoModule> GoModules { get; set; }

        /// <summary>
        /// A list of images to be pushed upon the successful completion of all build steps. The images will be pushed
        /// using the builder service account's credentials. The digests of the pushed images will be stored in the
        /// Build resource's results field. If any of the images fail to be pushed, the build is marked FAILURE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("images")]
        public virtual System.Collections.Generic.IList<string> Images { get; set; }

        /// <summary>
        /// A list of Maven artifacts to be uploaded to Artifact Registry upon successful completion of all build steps.
        /// Artifacts in the workspace matching specified paths globs will be uploaded to the specified Artifact
        /// Registry repository using the builder service account's credentials. If any artifacts fail to be pushed, the
        /// build is marked FAILURE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mavenArtifacts")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1MavenArtifact> MavenArtifacts { get; set; }

        /// <summary>
        /// A list of npm packages to be uploaded to Artifact Registry upon successful completion of all build steps.
        /// Npm packages in the specified paths will be uploaded to the specified Artifact Registry repository using the
        /// builder service account's credentials. If any packages fail to be pushed, the build is marked FAILURE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("npmPackages")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1NpmPackage> NpmPackages { get; set; }

        /// <summary>
        /// A list of objects to be uploaded to Cloud Storage upon successful completion of all build steps. Files in
        /// the workspace matching specified paths globs will be uploaded to the specified Cloud Storage location using
        /// the builder service account's credentials. The location and generation of the uploaded objects will be
        /// stored in the Build resource's results field. If any objects fail to be pushed, the build is marked FAILURE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objects")]
        public virtual GoogleDevtoolsCloudbuildV1ArtifactObjects Objects { get; set; }

        /// <summary>
        /// A list of Python packages to be uploaded to Artifact Registry upon successful completion of all build steps.
        /// The build service account credentials will be used to perform the upload. If any objects fail to be pushed,
        /// the build is marked FAILURE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pythonPackages")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1PythonPackage> PythonPackages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A build resource in the Cloud Build API. At a high level, a `Build` describes where to find source code, how to
    /// build it (for example, the builder image to run on the source), and where to store the built artifacts. Fields
    /// can include the following variables, which will be expanded when the build is created: - $PROJECT_ID: the
    /// project ID of the build. - $PROJECT_NUMBER: the project number of the build. - $LOCATION: the location/region of
    /// the build. - $BUILD_ID: the autogenerated ID of the build. - $REPO_NAME: the source repository name specified by
    /// RepoSource. - $BRANCH_NAME: the branch name specified by RepoSource. - $TAG_NAME: the tag name specified by
    /// RepoSource. - $REVISION_ID or $COMMIT_SHA: the commit SHA specified by RepoSource or resolved from the specified
    /// branch or tag. - $SHORT_SHA: first 7 characters of $REVISION_ID or $COMMIT_SHA.
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1Build : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Describes this build's approval configuration, status, and result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approval")]
        public virtual GoogleDevtoolsCloudbuildV1BuildApproval Approval { get; set; }

        /// <summary>
        /// Artifacts produced by the build that should be uploaded upon successful completion of all build steps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifacts")]
        public virtual GoogleDevtoolsCloudbuildV1Artifacts Artifacts { get; set; }

        /// <summary>Secrets and secret environment variables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableSecrets")]
        public virtual GoogleDevtoolsCloudbuildV1Secrets AvailableSecrets { get; set; }

        /// <summary>
        /// Output only. The ID of the `BuildTrigger` that triggered this build, if it was triggered automatically.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildTriggerId")]
        public virtual string BuildTriggerId { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time at which the request to create the build was received.</summary>
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

        /// <summary>
        /// Optional. Dependencies that the Cloud Build worker will fetch before executing user steps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dependencies")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1Dependency> Dependencies { get; set; }

        /// <summary>Output only. Contains information about the build when status=FAILURE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureInfo")]
        public virtual GoogleDevtoolsCloudbuildV1FailureInfo FailureInfo { get; set; }

        private string _finishTimeRaw;

        private object _finishTime;

        /// <summary>
        /// Output only. Time at which execution of the build was finished. The difference between finish_time and
        /// start_time is the duration of the build's execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishTime")]
        public virtual string FinishTimeRaw
        {
            get => _finishTimeRaw;
            set
            {
                _finishTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _finishTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FinishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FinishTimeDateTimeOffset instead.")]
        public virtual object FinishTime
        {
            get => _finishTime;
            set
            {
                _finishTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _finishTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="FinishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FinishTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FinishTimeRaw);
            set => FinishTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. Configuration for git operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitConfig")]
        public virtual GoogleDevtoolsCloudbuildV1GitConfig GitConfig { get; set; }

        /// <summary>Output only. Unique identifier of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// A list of images to be pushed upon the successful completion of all build steps. The images are pushed using
        /// the builder service account's credentials. The digests of the pushed images will be stored in the `Build`
        /// resource's results field. If any of the images fail to be pushed, the build status is marked `FAILURE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("images")]
        public virtual System.Collections.Generic.IList<string> Images { get; set; }

        /// <summary>Output only. URL to logs for this build in Google Cloud Console.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logUrl")]
        public virtual string LogUrl { get; set; }

        /// <summary>
        /// Cloud Storage bucket where logs should be written (see [Bucket Name
        /// Requirements](https://cloud.google.com/storage/docs/bucket-naming#requirements)). Logs file names will be of
        /// the format `${logs_bucket}/log-${build_id}.txt`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logsBucket")]
        public virtual string LogsBucket { get; set; }

        /// <summary>
        /// Output only. The 'Build' name with format: `projects/{project}/locations/{location}/builds/{build}`, where
        /// {build} is a unique identifier generated by the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Special options for this build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual GoogleDevtoolsCloudbuildV1BuildOptions Options { get; set; }

        /// <summary>Output only. ID of the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// TTL in queue for this build. If provided and the build is enqueued longer than this value, the build will
        /// expire and the build status will be `EXPIRED`. The TTL starts ticking from create_time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queueTtl")]
        public virtual object QueueTtl { get; set; }

        /// <summary>Output only. Results of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual GoogleDevtoolsCloudbuildV1Results Results { get; set; }

        /// <summary>
        /// Secrets to decrypt using Cloud Key Management Service. Note: Secret Manager is the recommended technique for
        /// managing sensitive data with Cloud Build. Use `available_secrets` to configure builds to access secrets from
        /// Secret Manager. For instructions, see: https://cloud.google.com/cloud-build/docs/securing-builds/use-secrets
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secrets")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1Secret> Secrets { get; set; }

        /// <summary>
        /// IAM service account whose credentials will be used at build runtime. Must be of the format
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. ACCOUNT can be email address or uniqueId of the service
        /// account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Optional. The location of the source files to build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual GoogleDevtoolsCloudbuildV1Source Source { get; set; }

        /// <summary>Output only. A permanent fixed identifier for source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceProvenance")]
        public virtual GoogleDevtoolsCloudbuildV1SourceProvenance SourceProvenance { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. Time at which execution of the build was started.</summary>
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

        /// <summary>Output only. Status of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Output only. Customer-readable message about the current status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusDetail")]
        public virtual string StatusDetail { get; set; }

        /// <summary>Required. The operations to be performed on the workspace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1BuildStep> Steps { get; set; }

        /// <summary>Substitutions data for `Build` resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("substitutions")]
        public virtual System.Collections.Generic.IDictionary<string, string> Substitutions { get; set; }

        /// <summary>Tags for annotation of a `Build`. These are not docker tags.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Amount of time that this build should be allowed to run, to second granularity. If this amount of time
        /// elapses, work on the build will cease and the build status will be `TIMEOUT`. `timeout` starts ticking from
        /// `startTime`. Default time is 60 minutes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>
        /// Output only. Stores timing information for phases of the build. Valid keys are: * BUILD: time to execute all
        /// build steps. * PUSH: time to push all artifacts including docker images and non docker artifacts. *
        /// FETCHSOURCE: time to fetch source. * SETUPBUILD: time to set up build. If the build does not specify source
        /// or images, these keys will not be included.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timing")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleDevtoolsCloudbuildV1TimeSpan> Timing { get; set; }

        /// <summary>Output only. Non-fatal problems encountered during the execution of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1Warning> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BuildApproval describes a build's approval configuration, state, and result.</summary>
    public class GoogleDevtoolsCloudbuildV1BuildApproval : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Configuration for manual approval of this build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual GoogleDevtoolsCloudbuildV1ApprovalConfig Config { get; set; }

        /// <summary>Output only. Result of manual approval for this Build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual GoogleDevtoolsCloudbuildV1ApprovalResult Result { get; set; }

        /// <summary>Output only. The state of this build's approval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for build operations.</summary>
    public class GoogleDevtoolsCloudbuildV1BuildOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The build that the operation is tracking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("build")]
        public virtual GoogleDevtoolsCloudbuildV1Build Build { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Optional arguments to enable specific features of builds.</summary>
    public class GoogleDevtoolsCloudbuildV1BuildOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Option to include built-in and custom substitutions as env variables for all build steps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automapSubstitutions")]
        public virtual System.Nullable<bool> AutomapSubstitutions { get; set; }

        /// <summary>Optional. Option to specify how default logs buckets are setup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultLogsBucketBehavior")]
        public virtual string DefaultLogsBucketBehavior { get; set; }

        /// <summary>
        /// Requested disk size for the VM that runs the build. Note that this is *NOT* "disk free"; some of the space
        /// will be used by the operating system and build utilities. Also note that this is the minimum disk size that
        /// will be allocated for the build -- the build may run with a larger disk than requested. At present, the
        /// maximum disk size is 4000GB; builds that request more than the maximum are rejected with an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskSizeGb")]
        public virtual System.Nullable<long> DiskSizeGb { get; set; }

        /// <summary>
        /// Option to specify whether or not to apply bash style string operations to the substitutions. NOTE: this is
        /// always enabled for triggered builds and cannot be overridden in the build configuration file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicSubstitutions")]
        public virtual System.Nullable<bool> DynamicSubstitutions { get; set; }

        /// <summary>
        /// Optional. Option to specify whether structured logging is enabled. If true, JSON-formatted logs are parsed
        /// as structured logs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableStructuredLogging")]
        public virtual System.Nullable<bool> EnableStructuredLogging { get; set; }

        /// <summary>
        /// A list of global environment variable definitions that will exist for all build steps in this build. If a
        /// variable is defined in both globally and in a build step, the variable will use the build step value. The
        /// elements are of the form "KEY=VALUE" for the environment variable "KEY" being given the value "VALUE".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual System.Collections.Generic.IList<string> Env { get; set; }

        /// <summary>Option to define build log streaming behavior to Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logStreamingOption")]
        public virtual string LogStreamingOption { get; set; }

        /// <summary>Option to specify the logging mode, which determines if and where build logs are stored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logging")]
        public virtual string Logging { get; set; }

        /// <summary>Compute Engine machine type on which to run the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>
        /// Optional. Specification for execution on a `WorkerPool`. See [running builds in a private
        /// pool](https://cloud.google.com/build/docs/private-pools/run-builds-in-private-pool) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pool")]
        public virtual GoogleDevtoolsCloudbuildV1PoolOption Pool { get; set; }

        /// <summary>Optional. Option to specify the Pub/Sub topic to receive build status updates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubTopic")]
        public virtual string PubsubTopic { get; set; }

        /// <summary>Requested verifiability options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedVerifyOption")]
        public virtual string RequestedVerifyOption { get; set; }

        /// <summary>
        /// A list of global environment variables, which are encrypted using a Cloud Key Management Service crypto key.
        /// These values must be specified in the build's `Secret`. These variables will be available to all build steps
        /// in this build.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretEnv")]
        public virtual System.Collections.Generic.IList<string> SecretEnv { get; set; }

        /// <summary>Requested hash for SourceProvenance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceProvenanceHash")]
        public virtual System.Collections.Generic.IList<string> SourceProvenanceHash { get; set; }

        /// <summary>
        /// Option to specify behavior when there is an error in the substitution checks. NOTE: this is always set to
        /// ALLOW_LOOSE for triggered builds and cannot be overridden in the build configuration file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("substitutionOption")]
        public virtual string SubstitutionOption { get; set; }

        /// <summary>
        /// Global list of volumes to mount for ALL build steps Each volume is created as an empty volume prior to
        /// starting the build process. Upon completion of the build, volumes and their contents are discarded. Global
        /// volume names and paths cannot conflict with the volumes defined a build step. Using a global volume in a
        /// build with only one step is not valid as it is indicative of a build request with an incorrect
        /// configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1Volume> Volumes { get; set; }

        /// <summary>This field deprecated; please use `pool.name` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerPool")]
        public virtual string WorkerPool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A step in the build pipeline.</summary>
    public class GoogleDevtoolsCloudbuildV1BuildStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Allow this build step to fail without failing the entire build if and only if the exit code is one of the
        /// specified codes. If allow_failure is also specified, this field will take precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowExitCodes")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> AllowExitCodes { get; set; }

        /// <summary>
        /// Allow this build step to fail without failing the entire build. If false, the entire build will fail if this
        /// step fails. Otherwise, the build will succeed, but this step will still have a failure status. Error
        /// information will be reported in the failure_detail field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowFailure")]
        public virtual System.Nullable<bool> AllowFailure { get; set; }

        /// <summary>
        /// A list of arguments that will be presented to the step when it is started. If the image used to run the
        /// step's container has an entrypoint, the `args` are used as arguments to that entrypoint. If the image does
        /// not define an entrypoint, the first element in args is used as the entrypoint, and the remainder will be
        /// used as arguments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>
        /// Option to include built-in and custom substitutions as env variables for this build step. This option will
        /// override the global option in BuildOption.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automapSubstitutions")]
        public virtual System.Nullable<bool> AutomapSubstitutions { get; set; }

        /// <summary>
        /// Working directory to use when running this step's container. If this value is a relative path, it is
        /// relative to the build's working directory. If this value is absolute, it may be outside the build's working
        /// directory, in which case the contents of the path may not be persisted across build step executions, unless
        /// a `volume` for that path is specified. If the build specifies a `RepoSource` with `dir` and a step with a
        /// `dir`, which specifies an absolute path, the `RepoSource` `dir` is ignored for the step's execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dir")]
        public virtual string Dir { get; set; }

        /// <summary>
        /// Entrypoint to be used instead of the build step image's default entrypoint. If unset, the image's default
        /// entrypoint is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entrypoint")]
        public virtual string Entrypoint { get; set; }

        /// <summary>
        /// A list of environment variable definitions to be used when running a step. The elements are of the form
        /// "KEY=VALUE" for the environment variable "KEY" being given the value "VALUE".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual System.Collections.Generic.IList<string> Env { get; set; }

        /// <summary>Output only. Return code from running the step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitCode")]
        public virtual System.Nullable<int> ExitCode { get; set; }

        /// <summary>
        /// Unique identifier for this build step, used in `wait_for` to reference this build step as a dependency.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Required. The name of the container image that will run this particular build step. If the image is
        /// available in the host's Docker daemon's cache, it will be run directly. If not, the host will attempt to
        /// pull the image first, using the builder service account's credentials if necessary. The Docker daemon's
        /// cache will already have the latest versions of all of the officially supported build steps
        /// ([https://github.com/GoogleCloudPlatform/cloud-builders](https://github.com/GoogleCloudPlatform/cloud-builders)).
        /// The Docker daemon will also have cached many of the layers for some popular images, like "ubuntu", "debian",
        /// but they will be refreshed at the time you attempt to use them. If you built an image in a previous build
        /// step, it will be stored in the host's Docker daemon's cache and is available to use as the name for a later
        /// build step.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Stores timing information for pulling this build step's builder image only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pullTiming")]
        public virtual GoogleDevtoolsCloudbuildV1TimeSpan PullTiming { get; set; }

        /// <summary>
        /// A shell script to be executed in the step. When script is provided, the user cannot specify the entrypoint
        /// or args.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("script")]
        public virtual string Script { get; set; }

        /// <summary>
        /// A list of environment variables which are encrypted using a Cloud Key Management Service crypto key. These
        /// values must be specified in the build's `Secret`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretEnv")]
        public virtual System.Collections.Generic.IList<string> SecretEnv { get; set; }

        /// <summary>
        /// Output only. Status of the build step. At this time, build step status is only updated on build completion;
        /// step status is not updated in real-time as the build progresses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// Time limit for executing this build step. If not defined, the step has no time limit and will be allowed to
        /// continue to run until either it completes or the build itself times out.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>Output only. Stores timing information for executing this build step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timing")]
        public virtual GoogleDevtoolsCloudbuildV1TimeSpan Timing { get; set; }

        /// <summary>
        /// List of volumes to mount into the build step. Each volume is created as an empty volume prior to execution
        /// of the build step. Upon completion of the build, volumes and their contents are discarded. Using a named
        /// volume in only one step is not valid as it is indicative of a build request with an incorrect configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1Volume> Volumes { get; set; }

        /// <summary>
        /// The ID(s) of the step(s) that this build step depends on. This build step will not start until all the build
        /// steps in `wait_for` have completed successfully. If `wait_for` is empty, this build step will start when all
        /// previous build steps in the `Build.Steps` list have completed successfully.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waitFor")]
        public virtual System.Collections.Generic.IList<string> WaitFor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An image built by the pipeline.</summary>
    public class GoogleDevtoolsCloudbuildV1BuiltImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Docker Registry 2.0 digest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digest")]
        public virtual string Digest { get; set; }

        /// <summary>
        /// Name used to push the container image to Google Container Registry, as presented to `docker push`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Stores timing information for pushing the specified image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushTiming")]
        public virtual GoogleDevtoolsCloudbuildV1TimeSpan PushTiming { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location of the source in a 2nd-gen Google Cloud Build repository resource.</summary>
    public class GoogleDevtoolsCloudbuildV1ConnectedRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Directory, relative to the source root, in which to run the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dir")]
        public virtual string Dir { get; set; }

        /// <summary>
        /// Required. Name of the Google Cloud Build repository, formatted as
        /// `projects/*/locations/*/connections/*/repositories/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual string Repository { get; set; }

        /// <summary>
        /// Required. The revision to fetch from the Git repository such as a branch, a tag, a commit SHA, or any Git
        /// ref.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A dependency that the Cloud Build worker will fetch before executing user steps.</summary>
    public class GoogleDevtoolsCloudbuildV1Dependency : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If set to true disable all dependency fetching (ignoring the default source as well).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("empty")]
        public virtual System.Nullable<bool> Empty { get; set; }

        /// <summary>Represents a git repository as a build dependency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitSource")]
        public virtual GoogleDevtoolsCloudbuildV1GitSourceDependency GitSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This config defines the location of a source through Developer Connect.</summary>
    public class GoogleDevtoolsCloudbuildV1DeveloperConnectConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Directory, relative to the source root, in which to run the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dir")]
        public virtual string Dir { get; set; }

        /// <summary>
        /// Required. The Developer Connect Git repository link, formatted as
        /// `projects/*/locations/*/connections/*/gitRepositoryLink/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitRepositoryLink")]
        public virtual string GitRepositoryLink { get; set; }

        /// <summary>
        /// Required. The revision to fetch from the Git repository such as a branch, a tag, a commit SHA, or any Git
        /// ref.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A fatal problem encountered during the execution of the build.</summary>
    public class GoogleDevtoolsCloudbuildV1FailureInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Explains the failure issue in more detail using hard-coded text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual string Detail { get; set; }

        /// <summary>The name of the failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Container message for hashes of byte content of files, used in SourceProvenance messages to verify integrity of
    /// source input to the build.
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1FileHashes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Collection of file hashes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHash")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1Hash> FileHash { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>GitConfig is a configuration for git operations.</summary>
    public class GoogleDevtoolsCloudbuildV1GitConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration for HTTP related git operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("http")]
        public virtual GoogleDevtoolsCloudbuildV1HttpConfig Http { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location of the source in any accessible Git repository.</summary>
    public class GoogleDevtoolsCloudbuildV1GitSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Directory, relative to the source root, in which to run the build. This must be a relative path.
        /// If a step's `dir` is specified and is an absolute path, this value is ignored for that step's execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dir")]
        public virtual string Dir { get; set; }

        /// <summary>
        /// Optional. The revision to fetch from the Git repository such as a branch, a tag, a commit SHA, or any Git
        /// ref. Cloud Build uses `git fetch` to fetch the revision from the Git repository; therefore make sure that
        /// the string you provide for `revision` is parsable by the command. For information on string values accepted
        /// by `git fetch`, see https://git-scm.com/docs/gitrevisions#_specifying_revisions. For information on `git
        /// fetch`, see https://git-scm.com/docs/git-fetch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

        /// <summary>
        /// Required. Location of the Git repo to build. This will be used as a `git remote`, see
        /// https://git-scm.com/docs/git-remote.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a git repository as a build dependency.</summary>
    public class GoogleDevtoolsCloudbuildV1GitSourceDependency : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. How much history should be fetched for the build (default 1, -1 for all history).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("depth")]
        public virtual System.Nullable<long> Depth { get; set; }

        /// <summary>Required. Where should the files be placed on the worker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destPath")]
        public virtual string DestPath { get; set; }

        /// <summary>Optional. True if submodules should be fetched too (default false).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recurseSubmodules")]
        public virtual System.Nullable<bool> RecurseSubmodules { get; set; }

        /// <summary>Required. The kind of repo (url or dev connect).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual GoogleDevtoolsCloudbuildV1GitSourceRepository Repository { get; set; }

        /// <summary>Required. The revision that we will fetch the repo at.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A repository for a git source.</summary>
    public class GoogleDevtoolsCloudbuildV1GitSourceRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Developer Connect Git repository link formatted as
        /// `projects/*/locations/*/connections/*/gitRepositoryLink/*`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerConnect")]
        public virtual string DeveloperConnect { get; set; }

        /// <summary>Location of the Git repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Go module to upload to Artifact Registry upon successful completion of all build steps. A module refers to all
    /// dependencies in a go.mod file.
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1GoModule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The Go module's "module path". e.g. example.com/foo/v2</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modulePath")]
        public virtual string ModulePath { get; set; }

        /// <summary>
        /// Optional. The Go module's semantic version in the form vX.Y.Z. e.g. v0.1.1 Pre-release identifiers can also
        /// be added by appending a dash and dot separated ASCII alphanumeric characters and hyphens. e.g.
        /// v0.2.3-alpha.x.12m.5
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moduleVersion")]
        public virtual string ModuleVersion { get; set; }

        /// <summary>
        /// Optional. Location of the Artifact Registry repository. i.e. us-east1 Defaults to the build’s location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repositoryLocation")]
        public virtual string RepositoryLocation { get; set; }

        /// <summary>
        /// Optional. Artifact Registry repository name. Specified Go modules will be zipped and uploaded to Artifact
        /// Registry with this location as a prefix. e.g. my-go-repo
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repositoryName")]
        public virtual string RepositoryName { get; set; }

        /// <summary>Optional. Project ID of the Artifact Registry repository. Defaults to the build project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repositoryProjectId")]
        public virtual string RepositoryProjectId { get; set; }

        /// <summary>
        /// Optional. Source path of the go.mod file in the build's workspace. If not specified, this will default to
        /// the current directory. e.g. ~/code/go/mypackage
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourcePath")]
        public virtual string SourcePath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Container message for hash values.</summary>
    public class GoogleDevtoolsCloudbuildV1Hash : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of hash that was performed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The hash value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>HttpConfig is a configuration for HTTP related git operations.</summary>
    public class GoogleDevtoolsCloudbuildV1HttpConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// SecretVersion resource of the HTTP proxy URL. The Service Account used in the build (either the default
        /// Service Account or user-specified Service Account) should have `secretmanager.versions.access` permissions
        /// on this secret. The proxy URL should be in format `protocol://@]proxyhost[:port]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proxySecretVersionName")]
        public virtual string ProxySecretVersionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Pairs a set of secret environment variables mapped to encrypted values with the Cloud KMS key to use to decrypt
    /// the value.
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1InlineSecret : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Map of environment variable name to its encrypted value. Secret environment variables must be unique across
        /// all of a build's secrets, and must be used by at least one build step. Values can be at most 64 KB in size.
        /// There can be at most 100 secret values across all of a build's secrets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("envMap")]
        public virtual System.Collections.Generic.IDictionary<string, string> EnvMap { get; set; }

        /// <summary>
        /// Resource name of Cloud KMS crypto key to decrypt the encrypted value. In format:
        /// projects/*/locations/*/keyRings/*/cryptoKeys/*
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Maven artifact to upload to Artifact Registry upon successful completion of all build steps.
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1MavenArtifact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Maven `artifactId` value used when uploading the artifact to Artifact Registry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactId")]
        public virtual string ArtifactId { get; set; }

        /// <summary>Maven `groupId` value used when uploading the artifact to Artifact Registry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupId")]
        public virtual string GroupId { get; set; }

        /// <summary>
        /// Optional. Path to an artifact in the build's workspace to be uploaded to Artifact Registry. This can be
        /// either an absolute path, e.g. /workspace/my-app/target/my-app-1.0.SNAPSHOT.jar or a relative path from
        /// /workspace, e.g. my-app/target/my-app-1.0.SNAPSHOT.jar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>
        /// Artifact Registry repository, in the form "https://$REGION-maven.pkg.dev/$PROJECT/$REPOSITORY" Artifact in
        /// the workspace specified by path will be uploaded to Artifact Registry with this location as a prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual string Repository { get; set; }

        /// <summary>Maven `version` value used when uploading the artifact to Artifact Registry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Npm package to upload to Artifact Registry upon successful completion of all build steps.</summary>
    public class GoogleDevtoolsCloudbuildV1NpmPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Path to the package.json. e.g. workspace/path/to/package</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packagePath")]
        public virtual string PackagePath { get; set; }

        /// <summary>
        /// Artifact Registry repository, in the form "https://$REGION-npm.pkg.dev/$PROJECT/$REPOSITORY" Npm package in
        /// the workspace specified by path will be zipped and uploaded to Artifact Registry with this location as a
        /// prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual string Repository { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details about how a build should be executed on a `WorkerPool`. See [running builds in a private
    /// pool](https://cloud.google.com/build/docs/private-pools/run-builds-in-private-pool) for more information.
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1PoolOption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The `WorkerPool` resource to execute the build on. You must have `cloudbuild.workerpools.use` on the project
        /// hosting the WorkerPool. Format projects/{project}/locations/{location}/workerPools/{workerPoolId}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Python package to upload to Artifact Registry upon successful completion of all build steps. A package can
    /// encapsulate multiple objects to be uploaded to a single repository.
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1PythonPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Path globs used to match files in the build's workspace. For Python/ Twine, this is usually `dist/*`, and
        /// sometimes additionally an `.asc` file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paths")]
        public virtual System.Collections.Generic.IList<string> Paths { get; set; }

        /// <summary>
        /// Artifact Registry repository, in the form "https://$REGION-python.pkg.dev/$PROJECT/$REPOSITORY" Files in the
        /// workspace matching any path pattern will be uploaded to Artifact Registry with this location as a prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual string Repository { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location of the source in a Google Cloud Source Repository.</summary>
    public class GoogleDevtoolsCloudbuildV1RepoSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Regex matching branches to build. The syntax of the regular expressions accepted is the syntax accepted by
        /// RE2 and described at https://github.com/google/re2/wiki/Syntax
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("branchName")]
        public virtual string BranchName { get; set; }

        /// <summary>Explicit commit SHA to build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitSha")]
        public virtual string CommitSha { get; set; }

        /// <summary>
        /// Optional. Directory, relative to the source root, in which to run the build. This must be a relative path.
        /// If a step's `dir` is specified and is an absolute path, this value is ignored for that step's execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dir")]
        public virtual string Dir { get; set; }

        /// <summary>Optional. Only trigger a build if the revision regex does NOT match the revision regex.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invertRegex")]
        public virtual System.Nullable<bool> InvertRegex { get; set; }

        /// <summary>
        /// Optional. ID of the project that owns the Cloud Source Repository. If omitted, the project ID requesting the
        /// build is assumed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Required. Name of the Cloud Source Repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repoName")]
        public virtual string RepoName { get; set; }

        /// <summary>
        /// Optional. Substitutions to use in a triggered build. Should only be used with RunBuildTrigger
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("substitutions")]
        public virtual System.Collections.Generic.IDictionary<string, string> Substitutions { get; set; }

        /// <summary>
        /// Regex matching tags to build. The syntax of the regular expressions accepted is the syntax accepted by RE2
        /// and described at https://github.com/google/re2/wiki/Syntax
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagName")]
        public virtual string TagName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Artifacts created by the build pipeline.</summary>
    public class GoogleDevtoolsCloudbuildV1Results : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Path to the artifact manifest for non-container artifacts uploaded to Cloud Storage. Only populated when
        /// artifacts are uploaded to Cloud Storage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactManifest")]
        public virtual string ArtifactManifest { get; set; }

        /// <summary>Time to push all non-container artifacts to Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactTiming")]
        public virtual GoogleDevtoolsCloudbuildV1TimeSpan ArtifactTiming { get; set; }

        /// <summary>List of build step digests, in the order corresponding to build step indices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildStepImages")]
        public virtual System.Collections.Generic.IList<string> BuildStepImages { get; set; }

        /// <summary>
        /// List of build step outputs, produced by builder images, in the order corresponding to build step indices.
        /// [Cloud Builders](https://cloud.google.com/cloud-build/docs/cloud-builders) can produce this output by
        /// writing to `$BUILDER_OUTPUT/output`. Only the first 50KB of data is stored. Note that the `$BUILDER_OUTPUT`
        /// variable is read-only and can't be substituted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildStepOutputs")]
        public virtual System.Collections.Generic.IList<string> BuildStepOutputs { get; set; }

        /// <summary>Optional. Go module artifacts uploaded to Artifact Registry at the end of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goModules")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1UploadedGoModule> GoModules { get; set; }

        /// <summary>Container images that were built as a part of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("images")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1BuiltImage> Images { get; set; }

        /// <summary>Maven artifacts uploaded to Artifact Registry at the end of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mavenArtifacts")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1UploadedMavenArtifact> MavenArtifacts { get; set; }

        /// <summary>Npm packages uploaded to Artifact Registry at the end of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("npmPackages")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1UploadedNpmPackage> NpmPackages { get; set; }

        /// <summary>
        /// Number of non-container artifacts uploaded to Cloud Storage. Only populated when artifacts are uploaded to
        /// Cloud Storage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numArtifacts")]
        public virtual System.Nullable<long> NumArtifacts { get; set; }

        /// <summary>Python artifacts uploaded to Artifact Registry at the end of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pythonPackages")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1UploadedPythonPackage> PythonPackages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Pairs a set of secret environment variables containing encrypted values with the Cloud KMS key to use to decrypt
    /// the value. Note: Use `kmsKeyName` with `available_secrets` instead of using `kmsKeyName` with `secret`. For
    /// instructions see: https://cloud.google.com/cloud-build/docs/securing-builds/use-encrypted-credentials.
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1Secret : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cloud KMS key name to use to decrypt these envs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>
        /// Map of environment variable name to its encrypted value. Secret environment variables must be unique across
        /// all of a build's secrets, and must be used by at least one build step. Values can be at most 64 KB in size.
        /// There can be at most 100 secret values across all of a build's secrets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretEnv")]
        public virtual System.Collections.Generic.IDictionary<string, string> SecretEnv { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Pairs a secret environment variable with a SecretVersion in Secret Manager.</summary>
    public class GoogleDevtoolsCloudbuildV1SecretManagerSecret : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Environment variable name to associate with the secret. Secret environment variables must be unique across
        /// all of a build's secrets, and must be used by at least one build step.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual string Env { get; set; }

        /// <summary>Resource name of the SecretVersion. In format: projects/*/secrets/*/versions/*</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionName")]
        public virtual string VersionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Secrets and secret environment variables.</summary>
    public class GoogleDevtoolsCloudbuildV1Secrets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Secrets encrypted with KMS key and the associated secret environment variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inline")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1InlineSecret> Inline { get; set; }

        /// <summary>Secrets in Secret Manager and associated secret environment variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretManager")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1SecretManagerSecret> SecretManager { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location of the source in a supported storage service.</summary>
    public class GoogleDevtoolsCloudbuildV1Source : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If provided, get the source from this 2nd-gen Google Cloud Build repository resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectedRepository")]
        public virtual GoogleDevtoolsCloudbuildV1ConnectedRepository ConnectedRepository { get; set; }

        /// <summary>If provided, get the source from this Developer Connect config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerConnectConfig")]
        public virtual GoogleDevtoolsCloudbuildV1DeveloperConnectConfig DeveloperConnectConfig { get; set; }

        /// <summary>If provided, get the source from this Git repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitSource")]
        public virtual GoogleDevtoolsCloudbuildV1GitSource GitSource { get; set; }

        /// <summary>If provided, get the source from this location in a Cloud Source Repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repoSource")]
        public virtual GoogleDevtoolsCloudbuildV1RepoSource RepoSource { get; set; }

        /// <summary>If provided, get the source from this location in Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageSource")]
        public virtual GoogleDevtoolsCloudbuildV1StorageSource StorageSource { get; set; }

        /// <summary>
        /// If provided, get the source from this manifest in Cloud Storage. This feature is in Preview; see description
        /// [here](https://github.com/GoogleCloudPlatform/cloud-builders/tree/master/gcs-fetcher).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageSourceManifest")]
        public virtual GoogleDevtoolsCloudbuildV1StorageSourceManifest StorageSourceManifest { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provenance of the source. Ways to find the original source, or verify that some source was used for this build.
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1SourceProvenance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Hash(es) of the build source, which can be used to verify that the original source integrity
        /// was maintained in the build. Note that `FileHashes` will only be populated if `BuildOptions` has requested a
        /// `SourceProvenanceHash`. The keys to this map are file paths used as build source and the values contain the
        /// hash values for those files. If the build source came in a single package such as a gzipped tarfile
        /// (`.tar.gz`), the `FileHash` will be for the single path to that file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHashes")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleDevtoolsCloudbuildV1FileHashes> FileHashes { get; set; }

        /// <summary>
        /// Output only. A copy of the build's `source.connected_repository`, if exists, with any revisions resolved.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedConnectedRepository")]
        public virtual GoogleDevtoolsCloudbuildV1ConnectedRepository ResolvedConnectedRepository { get; set; }

        /// <summary>
        /// Output only. A copy of the build's `source.git_source`, if exists, with any revisions resolved.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedGitSource")]
        public virtual GoogleDevtoolsCloudbuildV1GitSource ResolvedGitSource { get; set; }

        /// <summary>A copy of the build's `source.repo_source`, if exists, with any revisions resolved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedRepoSource")]
        public virtual GoogleDevtoolsCloudbuildV1RepoSource ResolvedRepoSource { get; set; }

        /// <summary>A copy of the build's `source.storage_source`, if exists, with any generations resolved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedStorageSource")]
        public virtual GoogleDevtoolsCloudbuildV1StorageSource ResolvedStorageSource { get; set; }

        /// <summary>
        /// A copy of the build's `source.storage_source_manifest`, if exists, with any revisions resolved. This feature
        /// is in Preview.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedStorageSourceManifest")]
        public virtual GoogleDevtoolsCloudbuildV1StorageSourceManifest ResolvedStorageSourceManifest { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location of the source in an archive file in Cloud Storage.</summary>
    public class GoogleDevtoolsCloudbuildV1StorageSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Cloud Storage bucket containing the source (see [Bucket Name
        /// Requirements](https://cloud.google.com/storage/docs/bucket-naming#requirements)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>
        /// Optional. Cloud Storage generation for the object. If the generation is omitted, the latest generation will
        /// be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>
        /// Required. Cloud Storage object containing the source. This object must be a zipped (`.zip`) or gzipped
        /// archive file (`.tar.gz`) containing source to build.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("object")]
        public virtual string Object__ { get; set; }

        /// <summary>Optional. Option to specify the tool to fetch the source file for the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceFetcher")]
        public virtual string SourceFetcher { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Location of the source manifest in Cloud Storage. This feature is in Preview; see description
    /// [here](https://github.com/GoogleCloudPlatform/cloud-builders/tree/master/gcs-fetcher).
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1StorageSourceManifest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Cloud Storage bucket containing the source manifest (see [Bucket Name
        /// Requirements](https://cloud.google.com/storage/docs/bucket-naming#requirements)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>
        /// Cloud Storage generation for the object. If the generation is omitted, the latest generation will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>
        /// Required. Cloud Storage object containing the source manifest. This object must be a JSON file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("object")]
        public virtual string Object__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Start and end times for a build execution phase.</summary>
    public class GoogleDevtoolsCloudbuildV1TimeSpan : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>End of time span.</summary>
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

        /// <summary>Start of time span.</summary>
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Go module artifact uploaded to Artifact Registry using the GoModule directive.</summary>
    public class GoogleDevtoolsCloudbuildV1UploadedGoModule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hash types and values of the Go Module Artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHashes")]
        public virtual GoogleDevtoolsCloudbuildV1FileHashes FileHashes { get; set; }

        /// <summary>Output only. Stores timing information for pushing the specified artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushTiming")]
        public virtual GoogleDevtoolsCloudbuildV1TimeSpan PushTiming { get; set; }

        /// <summary>URI of the uploaded artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Maven artifact uploaded using the MavenArtifact directive.</summary>
    public class GoogleDevtoolsCloudbuildV1UploadedMavenArtifact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hash types and values of the Maven Artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHashes")]
        public virtual GoogleDevtoolsCloudbuildV1FileHashes FileHashes { get; set; }

        /// <summary>Output only. Stores timing information for pushing the specified artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushTiming")]
        public virtual GoogleDevtoolsCloudbuildV1TimeSpan PushTiming { get; set; }

        /// <summary>URI of the uploaded artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An npm package uploaded to Artifact Registry using the NpmPackage directive.</summary>
    public class GoogleDevtoolsCloudbuildV1UploadedNpmPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hash types and values of the npm package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHashes")]
        public virtual GoogleDevtoolsCloudbuildV1FileHashes FileHashes { get; set; }

        /// <summary>Output only. Stores timing information for pushing the specified artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushTiming")]
        public virtual GoogleDevtoolsCloudbuildV1TimeSpan PushTiming { get; set; }

        /// <summary>URI of the uploaded npm package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Artifact uploaded using the PythonPackage directive.</summary>
    public class GoogleDevtoolsCloudbuildV1UploadedPythonPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hash types and values of the Python Artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHashes")]
        public virtual GoogleDevtoolsCloudbuildV1FileHashes FileHashes { get; set; }

        /// <summary>Output only. Stores timing information for pushing the specified artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushTiming")]
        public virtual GoogleDevtoolsCloudbuildV1TimeSpan PushTiming { get; set; }

        /// <summary>URI of the uploaded artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Volume describes a Docker container volume which is mounted into build steps in order to persist files across
    /// build step execution.
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1Volume : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Name of the volume to mount. Volume names must be unique per build step and must be valid names for Docker
        /// volumes. Each named volume must be used by at least two build steps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Path at which to mount the volume. Paths must be absolute and cannot conflict with other volume paths on the
        /// same build step or with certain reserved volume paths.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A non-fatal problem encountered during the execution of the build.</summary>
    public class GoogleDevtoolsCloudbuildV1Warning : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The priority for this warning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual string Priority { get; set; }

        /// <summary>Explanation of the warning generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

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

    /// <summary>The request message for Operations.WaitOperation.</summary>
    public class GoogleLongrunningWaitOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The maximum duration to wait before timing out. If left blank, the wait will be at most the time permitted
        /// by the underlying HTTP/RPC protocol. If RPC context deadline is also specified, the shorter one will be
        /// used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

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

    /// <summary>HTTPGetAction describes an action based on HTTP Get requests.</summary>
    public class HTTPGetAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Not supported by Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpHeaders")]
        public virtual System.Collections.Generic.IList<HTTPHeader> HttpHeaders { get; set; }

        /// <summary>Path to access on the HTTP server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>Port number to access on the container. Number must be in the range 1 to 65535.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>Not supported by Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheme")]
        public virtual string Scheme { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>HTTPHeader describes a custom header to be used in HTTP probes</summary>
    public class HTTPHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The header field name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The header field value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Holds a single instance split entry for the Worker. Allocations can be done to a specific Revision name, or
    /// pointing to the latest Ready Revision.
    /// </summary>
    public class InstanceSplit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Uses the "status.latestReadyRevisionName" to determine the instance split target. When it changes, workloads
        /// will automatically migrate from the prior "latest ready" revision to the new one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestRevision")]
        public virtual System.Nullable<bool> LatestRevision { get; set; }

        /// <summary>
        /// Optional. Specifies percent of the instance split to this Revision. This defaults to zero if unspecified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percent")]
        public virtual System.Nullable<int> Percent { get; set; }

        /// <summary>Revision to which to assign this portion of instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionName")]
        public virtual string RevisionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Job represents the configuration of a single job, which references a container image which is run to completion.
    /// </summary>
    public class Job : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. APIVersion defines the versioned schema of this representation of an object. Servers should
        /// convert recognized schemas to the latest internal value, and may reject unrecognized values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>
        /// Optional. Kind is a string value representing the REST resource this object represents. Servers may infer
        /// this from the endpoint the client submits requests to. Cannot be updated. In CamelCase.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Optional. Standard object's metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ObjectMeta Metadata { get; set; }

        /// <summary>Optional. Specification of the desired behavior of a job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual JobSpec Spec { get; set; }

        /// <summary>Output only. Current status of a job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual JobStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JobSpec describes how the job will look.</summary>
    public class JobSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A unique string used as a suffix for creating a new execution. The Job will become ready when the execution
        /// is successfully completed. The sum of job name and token length must be fewer than 63 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runExecutionToken")]
        public virtual string RunExecutionToken { get; set; }

        /// <summary>
        /// A unique string used as a suffix for creating a new execution. The Job will become ready when the execution
        /// is successfully started. The sum of job name and token length must be fewer than 63 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startExecutionToken")]
        public virtual string StartExecutionToken { get; set; }

        /// <summary>Optional. Describes the execution that will be created when running a job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("template")]
        public virtual ExecutionTemplateSpec Template { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JobStatus represents the current state of a Job.</summary>
    public class JobStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Conditions communicate information about ongoing/complete reconciliation processes that bring the "spec"
        /// inline with the observed state of the world. Job-specific conditions include: * `Ready`: `True` when the job
        /// is ready to be executed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV1Condition> Conditions { get; set; }

        /// <summary>Number of executions created for this job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionCount")]
        public virtual System.Nullable<int> ExecutionCount { get; set; }

        /// <summary>
        /// A pointer to the most recently created execution for this job. This is set regardless of the eventual state
        /// of the execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestCreatedExecution")]
        public virtual ExecutionReference LatestCreatedExecution { get; set; }

        /// <summary>The 'generation' of the job that was last processed by the controller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observedGeneration")]
        public virtual System.Nullable<int> ObservedGeneration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Maps a string key to a path within a volume.</summary>
    public class KeyToPath : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Cloud Secret Manager secret version. Can be 'latest' for the latest value, or an integer or a secret
        /// alias for a specific version. The key to project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// (Optional) Mode bits to use on this file, must be a value between 01 and 0777 (octal). If 0 or not set, the
        /// Volume's default mode will be used. Notes * Internally, a umask of 0222 will be applied to any non-zero
        /// value. * This is an integer representation of the mode bits. So, the octal integer value should look exactly
        /// as the chmod numeric notation with a leading zero. Some examples: for chmod 777 (a=rwx), set to 0777 (octal)
        /// or 511 (base-10). For chmod 640 (u=rw,g=r), set to 0640 (octal) or 416 (base-10). For chmod 755
        /// (u=rwx,g=rx,o=rx), set to 0755 (octal) or 493 (base-10). * This might be in conflict with other options that
        /// affect the file mode, like fsGroup, and the result can be other mode bits set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual System.Nullable<int> Mode { get; set; }

        /// <summary>
        /// The relative path of the file to map the key to. May not be an absolute path. May not contain the path
        /// element '..'. May not start with the string '..'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of Authorized Domains.</summary>
    public class ListAuthorizedDomainsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The authorized domains belonging to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domains")]
        public virtual System.Collections.Generic.IList<AuthorizedDomain> Domains { get; set; }

        /// <summary>Continuation token for fetching the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListConfigurationsResponse is a list of Configuration resources.</summary>
    public class ListConfigurationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API version for this call such as "serving.knative.dev/v1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>List of Configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Configuration> Items { get; set; }

        /// <summary>The kind of this resource, in this case "ConfigurationList".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Metadata associated with this Configuration list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ListMeta Metadata { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListDomainMappingsResponse is a list of DomainMapping resources.</summary>
    public class ListDomainMappingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API version for this call such as "domains.cloudrun.com/v1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>List of DomainMappings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<DomainMapping> Items { get; set; }

        /// <summary>The kind of this resource, in this case "DomainMappingList".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Metadata associated with this DomainMapping list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ListMeta Metadata { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListExecutionsResponse is a list of Executions resources.</summary>
    public class ListExecutionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API version for this call such as "run.googleapis.com/v1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>List of Executions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Execution> Items { get; set; }

        /// <summary>The kind of this resource, in this case "ExecutionsList".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Metadata associated with this executions list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ListMeta Metadata { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListJobsResponse is a list of Jobs resources.</summary>
    public class ListJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API version for this call such as "run.googleapis.com/v1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>List of Jobs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Job> Items { get; set; }

        /// <summary>The kind of this resource, in this case "JobsList".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Metadata associated with this jobs list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ListMeta Metadata { get; set; }

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

    /// <summary>
    /// Metadata for synthetic resources like List. In Cloud Run, all List Resources Responses will have a ListMeta
    /// instead of ObjectMeta.
    /// </summary>
    public class ListMeta : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Continuation token is a value emitted when the count of items is larger than the user/system limit. To
        /// retrieve the next page of items, pass the value of `continue` as the next request's `page_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("continue")]
        public virtual string Continue__ { get; set; }

        /// <summary>
        /// Opaque string that identifies the server's internal version of this object. It can be used by clients to
        /// determine when objects have changed. If the message is passed back to the server, it must be left
        /// unmodified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceVersion")]
        public virtual string ResourceVersion { get; set; }

        /// <summary>URL representing this object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListRevisionsResponse is a list of Revision resources.</summary>
    public class ListRevisionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API version for this call such as "serving.knative.dev/v1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>List of Revisions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Revision> Items { get; set; }

        /// <summary>The kind of this resource, in this case "RevisionList".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Metadata associated with this revision list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ListMeta Metadata { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListRoutesResponse is a list of Route resources.</summary>
    public class ListRoutesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API version for this call such as "serving.knative.dev/v1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>List of Routes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Route> Items { get; set; }

        /// <summary>The kind of this resource, in this case always "RouteList".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Metadata associated with this Route list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ListMeta Metadata { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of Service resources.</summary>
    public class ListServicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API version for this call; returns "serving.knative.dev/v1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>List of Services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Service> Items { get; set; }

        /// <summary>The kind of this resource; returns "ServiceList".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Metadata associated with this Service list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ListMeta Metadata { get; set; }

        /// <summary>
        /// For calls against the global endpoint, returns the list of Cloud locations that could not be reached. For
        /// regional calls, this field is not used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListTasksResponse is a list of Tasks resources.</summary>
    public class ListTasksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API version for this call such as "run.googleapis.com/v1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>List of Tasks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Task> Items { get; set; }

        /// <summary>The kind of this resource, in this case "TasksList".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Metadata associated with this tasks list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ListMeta Metadata { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of WorkerPool resources.</summary>
    public class ListWorkerPoolsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API version for this call; returns "run.googleapis.com/v1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>List of WorkerPools.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<WorkerPool> Items { get; set; }

        /// <summary>The kind of this resource; returns "WorkerPoolList".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Metadata associated with this WorkerPool list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ListMeta Metadata { get; set; }

        /// <summary>
        /// For calls against the global endpoint, returns the list of Cloud locations that could not be reached. For
        /// regional calls, this field is not used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Not supported by Cloud Run. LocalObjectReference contains enough information to let you locate the referenced
    /// object inside the same namespace.
    /// </summary>
    public class LocalObjectReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the referent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

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
    /// Represents a persistent volume that will be mounted using NFS. This volume will be shared between all instances
    /// of the resource and data will not be deleted when the instance is shut down.
    /// </summary>
    public class NFSVolumeSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Path that is exported by the NFS server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>If true, mount the NFS volume as read only. Defaults to false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readOnly")]
        public virtual System.Nullable<bool> ReadOnly__ { get; set; }

        /// <summary>Hostname or IP address of the NFS server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("server")]
        public virtual string Server { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// google.cloud.run.meta.v1.ObjectMeta is metadata that all persisted resources must have, which includes all
    /// objects users must create.
    /// </summary>
    public class ObjectMeta : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Unstructured key value map stored with a resource that may be set by external tools to store and retrieve
        /// arbitrary metadata. They are not queryable and should be preserved when modifying objects. In Cloud Run,
        /// annotations with 'run.googleapis.com/' and 'autoscaling.knative.dev' are restricted, and the accepted
        /// annotations will be different depending on the resource type. * `autoscaling.knative.dev/maxScale`:
        /// Revision. * `autoscaling.knative.dev/minScale`: Revision. * `run.googleapis.com/base-images`: Service,
        /// Revision. * `run.googleapis.com/binary-authorization-breakglass`: Service, Job, *
        /// `run.googleapis.com/binary-authorization`: Service, Job, Execution. * `run.googleapis.com/build-base-image`:
        /// Service. * `run.googleapis.com/build-enable-automatic-updates`: Service. *
        /// `run.googleapis.com/build-environment-variables`: Service. * `run.googleapis.com/build-function-target`:
        /// Service. * `run.googleapis.com/build-id`: Service. * `run.googleapis.com/build-image-uri`: Service. *
        /// `run.googleapis.com/build-name`: Service. * `run.googleapis.com/build-service-account`: Service. *
        /// `run.googleapis.com/build-source-location`: Service. * `run.googleapis.com/build-worker-pool`: Service. *
        /// `run.googleapis.com/client-name`: All resources. * `run.googleapis.com/cloudsql-instances`: Revision,
        /// Execution. * `run.googleapis.com/container-dependencies`: Revision . * `run.googleapis.com/cpu-throttling`:
        /// Revision. * `run.googleapis.com/custom-audiences`: Service. * `run.googleapis.com/default-url-disabled`:
        /// Service. * `run.googleapis.com/description`: Service. * `run.googleapis.com/encryption-key-shutdown-hours`:
        /// Revision * `run.googleapis.com/encryption-key`: Revision, Execution. *
        /// `run.googleapis.com/execution-environment`: Revision, Execution. * `run.googleapis.com/gc-traffic-tags`:
        /// Service. * `run.googleapis.com/gpu-zonal-redundancy-disabled`: Revision. *
        /// `run.googleapis.com/health-check-disabled`: Revision. * `run.googleapis.com/ingress`: Service. *
        /// `run.googleapis.com/launch-stage`: Service, Job. * `run.googleapis.com/minScale`: Service *
        /// `run.googleapis.com/network-interfaces`: Revision, Execution. *
        /// `run.googleapis.com/post-key-revocation-action-type`: Revision. * `run.googleapis.com/secrets`: Revision,
        /// Execution. * `run.googleapis.com/secure-session-agent`: Revision. * `run.googleapis.com/sessionAffinity`:
        /// Revision. * `run.googleapis.com/startup-cpu-boost`: Revision. * `run.googleapis.com/vpc-access-connector`:
        /// Revision, Execution. * `run.googleapis.com/vpc-access-egress`: Revision, Execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>Not supported by Cloud Run</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterName")]
        public virtual string ClusterName { get; set; }

        private string _creationTimestampRaw;

        private object _creationTimestamp;

        /// <summary>UTC timestamp representing the server time when this object was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTimestamp")]
        public virtual string CreationTimestampRaw
        {
            get => _creationTimestampRaw;
            set
            {
                _creationTimestamp = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _creationTimestampRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreationTimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreationTimestampDateTimeOffset instead.")]
        public virtual object CreationTimestamp
        {
            get => _creationTimestamp;
            set
            {
                _creationTimestampRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _creationTimestamp = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="CreationTimestampRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreationTimestampDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreationTimestampRaw);
            set => CreationTimestampRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Not supported by Cloud Run</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionGracePeriodSeconds")]
        public virtual System.Nullable<int> DeletionGracePeriodSeconds { get; set; }

        private string _deletionTimestampRaw;

        private object _deletionTimestamp;

        /// <summary>
        /// The read-only soft deletion timestamp for this resource. In Cloud Run, users are not able to set this field.
        /// Instead, they must call the corresponding Delete API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionTimestamp")]
        public virtual string DeletionTimestampRaw
        {
            get => _deletionTimestampRaw;
            set
            {
                _deletionTimestamp = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deletionTimestampRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeletionTimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeletionTimestampDateTimeOffset instead.")]
        public virtual object DeletionTimestamp
        {
            get => _deletionTimestamp;
            set
            {
                _deletionTimestampRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deletionTimestamp = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="DeletionTimestampRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeletionTimestampDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeletionTimestampRaw);
            set => DeletionTimestampRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Not supported by Cloud Run</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalizers")]
        public virtual System.Collections.Generic.IList<string> Finalizers { get; set; }

        /// <summary>Not supported by Cloud Run</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generateName")]
        public virtual string GenerateName { get; set; }

        /// <summary>
        /// A system-provided sequence number representing a specific generation of the desired state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<int> Generation { get; set; }

        /// <summary>
        /// Map of string keys and values that can be used to organize and categorize (scope and select) objects. May
        /// match selectors of replication controllers and routes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. The name of the resource. Name is required when creating top-level resources (Service, Job), must
        /// be unique within a Cloud Run project/region, and cannot be changed once created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Defines the space within each name must be unique within a Cloud Run region. In Cloud Run, it must
        /// be project ID or number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespace")]
        public virtual string Namespace__ { get; set; }

        /// <summary>Not supported by Cloud Run</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerReferences")]
        public virtual System.Collections.Generic.IList<OwnerReference> OwnerReferences { get; set; }

        /// <summary>
        /// Opaque, system-generated value that represents the internal version of this object that can be used by
        /// clients to determine when objects have changed. May be used for optimistic concurrency, change detection,
        /// and the watch operation on a resource or set of resources. Clients must treat these values as opaque and
        /// passed unmodified back to the server or omit the value to disable conflict-detection.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceVersion")]
        public virtual string ResourceVersion { get; set; }

        /// <summary>URL representing this object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Unique, system-generated identifier for this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RunJob Overrides that contains Execution fields to be overridden on the go.</summary>
    public class Overrides : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Per container override specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerOverrides")]
        public virtual System.Collections.Generic.IList<ContainerOverride> ContainerOverrides { get; set; }

        /// <summary>
        /// The desired number of tasks the execution should run. Will replace existing task_count value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskCount")]
        public virtual System.Nullable<int> TaskCount { get; set; }

        /// <summary>
        /// Duration in seconds the task may be active before the system will actively try to mark it failed and kill
        /// associated containers. Will replace existing timeout_seconds value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeoutSeconds")]
        public virtual System.Nullable<int> TimeoutSeconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This is not supported or used by Cloud Run.</summary>
    public class OwnerReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This is not supported or used by Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>This is not supported or used by Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockOwnerDeletion")]
        public virtual System.Nullable<bool> BlockOwnerDeletion { get; set; }

        /// <summary>This is not supported or used by Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controller")]
        public virtual System.Nullable<bool> Controller { get; set; }

        /// <summary>This is not supported or used by Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>This is not supported or used by Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>This is not supported or used by Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

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
    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:**
    /// ```
    /// {
    /// "bindings": [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 }
    /// ```
    /// **YAML
    /// example:**
    /// ```
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') etag: BwWWja0YfJA= version: 3
    /// ```
    /// For a description of IAM and its
    /// features, see the [IAM documentation](https://cloud.google.com/iam/docs/).
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
    /// Probe describes a health check to be performed against a container to determine whether it is alive or ready to
    /// receive traffic.
    /// </summary>
    public class Probe : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Not supported by Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exec")]
        public virtual ExecAction Exec { get; set; }

        /// <summary>
        /// Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3.
        /// Minimum value is 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureThreshold")]
        public virtual System.Nullable<int> FailureThreshold { get; set; }

        /// <summary>GRPCAction specifies an action involving a GRPC port.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grpc")]
        public virtual GRPCAction Grpc { get; set; }

        /// <summary>HTTPGet specifies the http request to perform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpGet")]
        public virtual HTTPGetAction HttpGet { get; set; }

        /// <summary>
        /// Number of seconds after the container has started before the probe is initiated. Defaults to 0 seconds.
        /// Minimum value is 0. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialDelaySeconds")]
        public virtual System.Nullable<int> InitialDelaySeconds { get; set; }

        /// <summary>
        /// How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value for
        /// liveness probe is 3600. Maximum value for startup probe is 240. Must be greater or equal than
        /// timeout_seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("periodSeconds")]
        public virtual System.Nullable<int> PeriodSeconds { get; set; }

        /// <summary>
        /// Minimum consecutive successes for the probe to be considered successful after having failed. Must be 1 if
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successThreshold")]
        public virtual System.Nullable<int> SuccessThreshold { get; set; }

        /// <summary>TCPSocket specifies an action involving a TCP port.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tcpSocket")]
        public virtual TCPSocketAction TcpSocket { get; set; }

        /// <summary>
        /// Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value
        /// is 3600. Must be smaller than period_seconds; if period_seconds is not set, must be less or equal than 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeoutSeconds")]
        public virtual System.Nullable<int> TimeoutSeconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A DNS resource record.</summary>
    public class ResourceRecord : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Relative name of the object affected by this record. Only applicable for `CNAME` records. Example: 'www'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Data for this record. Values vary by record type, as defined in RFC 1035 (section 5) and RFC 1034 (section
        /// 3.6.1).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rrdata")]
        public virtual string Rrdata { get; set; }

        /// <summary>Resource record type. Example: `AAAA`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ResourceRequirements describes the compute resource requirements.</summary>
    public class ResourceRequirements : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Limits describes the maximum amount of compute resources allowed. Only 'cpu' and 'memory' keys are
        /// supported. * For supported 'cpu' values, go to https://cloud.google.com/run/docs/configuring/cpu. * For
        /// supported 'memory' values and syntax, go to https://cloud.google.com/run/docs/configuring/memory-limits
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limits")]
        public virtual System.Collections.Generic.IDictionary<string, string> Limits { get; set; }

        /// <summary>
        /// Requests describes the minimum amount of compute resources required. Only `cpu` and `memory` are supported.
        /// If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to
        /// an implementation-defined value. * For supported 'cpu' values, go to
        /// https://cloud.google.com/run/docs/configuring/cpu. * For supported 'memory' values and syntax, go to
        /// https://cloud.google.com/run/docs/configuring/memory-limits
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IDictionary<string, string> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Revision is an immutable snapshot of code and configuration. A revision references a container image. Revisions
    /// are created by updates to a Configuration. See also:
    /// https://github.com/knative/specs/blob/main/specs/serving/overview.md#revision
    /// </summary>
    public class Revision : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API version for this call such as "serving.knative.dev/v1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>The kind of this resource, in this case "Revision".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Metadata associated with this Revision, including name, namespace, labels, and annotations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ObjectMeta Metadata { get; set; }

        /// <summary>Spec holds the desired state of the Revision (from the client).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual RevisionSpec Spec { get; set; }

        /// <summary>Status communicates the observed state of the Revision (from the controller).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual RevisionStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RevisionSpec holds the desired state of the Revision (from the client).</summary>
    public class RevisionSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// ContainerConcurrency specifies the maximum allowed in-flight (concurrent) requests per container instance of
        /// the Revision. If not specified or 0, defaults to 80 when requested CPU &amp;gt;= 1 and defaults to 1 when
        /// requested CPU &amp;lt; 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerConcurrency")]
        public virtual System.Nullable<int> ContainerConcurrency { get; set; }

        /// <summary>
        /// Required. Containers holds the list which define the units of execution for this Revision. In the context of
        /// a Revision, we disallow a number of fields on this Container, including: name and lifecycle.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<Container> Containers { get; set; }

        /// <summary>Not supported by Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableServiceLinks")]
        public virtual System.Nullable<bool> EnableServiceLinks { get; set; }

        /// <summary>Not supported by Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imagePullSecrets")]
        public virtual System.Collections.Generic.IList<LocalObjectReference> ImagePullSecrets { get; set; }

        /// <summary>
        /// Optional. The Node Selector configuration. Map of selector key to a value which matches a node.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeSelector")]
        public virtual System.Collections.Generic.IDictionary<string, string> NodeSelector { get; set; }

        /// <summary>Runtime. Leave unset for default.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeClassName")]
        public virtual string RuntimeClassName { get; set; }

        /// <summary>
        /// Email address of the IAM service account associated with the revision of the service. The service account
        /// represents the identity of the running revision, and determines what permissions the revision has. If not
        /// provided, the revision will use the project's default service account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountName")]
        public virtual string ServiceAccountName { get; set; }

        /// <summary>
        /// Optional. TimeoutSeconds holds the max duration the instance is allowed for responding to a request. Cloud
        /// Run: defaults to 300 seconds (5 minutes). Maximum allowed value is 3600 seconds (1 hour).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeoutSeconds")]
        public virtual System.Nullable<int> TimeoutSeconds { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<Volume> Volumes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RevisionStatus communicates the observed state of the Revision (from the controller).</summary>
    public class RevisionStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Conditions communicate information about ongoing/complete reconciliation processes that bring the "spec"
        /// inline with the observed state of the world. As a Revision is being prepared, it will incrementally update
        /// conditions. Revision-specific conditions include: * `ResourcesAvailable`: `True` when underlying resources
        /// have been provisioned. * `ContainerHealthy`: `True` when the Revision readiness check completes. * `Active`:
        /// `True` when the Revision may receive traffic.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV1Condition> Conditions { get; set; }

        /// <summary>
        /// Output only. The configured number of instances running this revision. For Cloud Run, this only includes
        /// instances provisioned using the minScale annotation. It does not include instances created by autoscaling.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredReplicas")]
        public virtual System.Nullable<int> DesiredReplicas { get; set; }

        /// <summary>
        /// ImageDigest holds the resolved digest for the image specified within .Spec.Container.Image. The digest is
        /// resolved during the creation of Revision. This field holds the digest value regardless of whether a tag or
        /// digest was originally specified in the Container object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageDigest")]
        public virtual string ImageDigest { get; set; }

        /// <summary>
        /// Optional. Specifies the generated logging url for this particular revision based on the revision url
        /// template specified in the controller's config.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logUrl")]
        public virtual string LogUrl { get; set; }

        /// <summary>
        /// ObservedGeneration is the 'Generation' of the Revision that was last processed by the controller. Clients
        /// polling for completed reconciliation should poll until observedGeneration = metadata.generation, and the
        /// Ready condition's status is True or False.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observedGeneration")]
        public virtual System.Nullable<int> ObservedGeneration { get; set; }

        /// <summary>Not currently used by Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RevisionTemplateSpec describes the data a revision should have when created from a template.</summary>
    public class RevisionTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional metadata for this Revision, including labels and annotations. Name will be generated by the
        /// Configuration. The following annotation keys set properties of the created revision: *
        /// `autoscaling.knative.dev/minScale` sets the minimum number of instances. *
        /// `autoscaling.knative.dev/maxScale` sets the maximum number of instances. *
        /// `run.googleapis.com/cloudsql-instances` sets Cloud SQL connections. Multiple values should be comma
        /// separated. * `run.googleapis.com/health-check-disabled`: if true, deploy-time startup probes will not run
        /// for this revision. * `run.googleapis.com/vpc-access-connector` sets a Serverless VPC Access connector. *
        /// `run.googleapis.com/vpc-access-egress` sets VPC egress. Supported values are `all-traffic`, `all`
        /// (deprecated), and `private-ranges-only`. `all-traffic` and `all` provide the same functionality. `all` is
        /// deprecated but will continue to be supported. Prefer `all-traffic`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ObjectMeta Metadata { get; set; }

        /// <summary>RevisionSpec holds the desired state of the Revision (from the client).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual RevisionSpec Spec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Route is responsible for configuring ingress over a collection of Revisions. Some of the Revisions a Route
    /// distributes traffic over may be specified by referencing the Configuration responsible for creating them; in
    /// these cases the Route is additionally responsible for monitoring the Configuration for "latest ready" revision
    /// changes, and smoothly rolling out latest revisions. Cloud Run currently supports referencing a single
    /// Configuration to automatically deploy the "latest ready" Revision from that Configuration.
    /// </summary>
    public class Route : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API version for this call such as "serving.knative.dev/v1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>The kind of this resource, in this case always "Route".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Metadata associated with this Route, including name, namespace, labels, and annotations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ObjectMeta Metadata { get; set; }

        /// <summary>Spec holds the desired state of the Route (from the client).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual RouteSpec Spec { get; set; }

        /// <summary>Status communicates the observed state of the Route (from the controller).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual RouteStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RouteSpec holds the desired state of the Route (from the client).</summary>
    public class RouteSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Traffic specifies how to distribute traffic over a collection of Knative Revisions and Configurations. Cloud
        /// Run currently supports a single configurationName.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traffic")]
        public virtual System.Collections.Generic.IList<TrafficTarget> Traffic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RouteStatus communicates the observed state of the Route (from the controller).</summary>
    public class RouteStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Similar to url, information on where the service is available on HTTP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual Addressable Address { get; set; }

        /// <summary>
        /// Conditions communicates information about ongoing/complete reconciliation processes that bring the "spec"
        /// inline with the observed state of the world.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV1Condition> Conditions { get; set; }

        /// <summary>
        /// ObservedGeneration is the 'Generation' of the Route that was last processed by the controller. Clients
        /// polling for completed reconciliation should poll until observedGeneration = metadata.generation and the
        /// Ready condition's status is True or False. Note that providing a TrafficTarget that has latest_revision=True
        /// will result in a Route that does not increment either its metadata.generation or its observedGeneration, as
        /// new "latest ready" revisions from the Configuration are processed without an update to the Route's spec.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observedGeneration")]
        public virtual System.Nullable<int> ObservedGeneration { get; set; }

        /// <summary>
        /// Traffic holds the configured traffic distribution. These entries will always contain RevisionName
        /// references. When ConfigurationName appears in the spec, this will hold the LatestReadyRevisionName that was
        /// last observed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traffic")]
        public virtual System.Collections.Generic.IList<TrafficTarget> Traffic { get; set; }

        /// <summary>
        /// URL holds the url that will distribute traffic over the provided traffic targets. It generally has the form:
        /// `https://{route-hash}-{project-hash}-{cluster-level-suffix}.a.run.app`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for creating a new execution of a job.</summary>
    public class RunJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Overrides existing job configuration for one specific new job execution only, using the specified
        /// values to update the job configuration for the new execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overrides")]
        public virtual Overrides Overrides { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Not supported by Cloud Run. SecretEnvSource selects a Secret to populate the environment variables with. The
    /// contents of the target Secret's Data field will represent the key-value pairs as environment variables.
    /// </summary>
    public class SecretEnvSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This field should not be used directly as it is meant to be inlined directly into the message. Use the
        /// "name" field instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localObjectReference")]
        public virtual LocalObjectReference LocalObjectReference { get; set; }

        /// <summary>The Secret to select from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Specify whether the Secret must be defined</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optional")]
        public virtual System.Nullable<bool> Optional { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SecretKeySelector selects a key of a Secret.</summary>
    public class SecretKeySelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A Cloud Secret Manager secret version. Must be 'latest' for the latest version, an integer for a
        /// specific version, or a version alias. The key of the secret to select from. Must be a valid secret key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// This field should not be used directly as it is meant to be inlined directly into the message. Use the
        /// "name" field instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localObjectReference")]
        public virtual LocalObjectReference LocalObjectReference { get; set; }

        /// <summary>
        /// The name of the secret in Cloud Secret Manager. By default, the secret is assumed to be in the same project.
        /// If the secret is in another project, you must define an alias. An alias definition has the form:
        /// :projects//secrets/. If multiple alias definitions are needed, they must be separated by commas. The alias
        /// definitions must be set on the run.googleapis.com/secrets annotation. The name of the secret in the pod's
        /// namespace to select from.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Specify whether the Secret or its key must be defined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optional")]
        public virtual System.Nullable<bool> Optional { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A volume representing a secret stored in Google Secret Manager. The secret's value will be presented as the
    /// content of a file whose name is defined in the item path. If no items are defined, the name of the file is the
    /// secret_name. The contents of the target Secret's Data field will be presented in a volume as files using the
    /// keys in the Data field as the file names.
    /// </summary>
    public class SecretVolumeSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Integer representation of mode bits to use on created files by default. Must be a value between 01 and 0777
        /// (octal). If 0 or not set, it will default to 0444. Directories within the path are not affected by this
        /// setting. Notes * Internally, a umask of 0222 will be applied to any non-zero value. * This is an integer
        /// representation of the mode bits. So, the octal integer value should look exactly as the chmod numeric
        /// notation with a leading zero. Some examples: for chmod 777 (a=rwx), set to 0777 (octal) or 511 (base-10).
        /// For chmod 640 (u=rw,g=r), set to 0640 (octal) or 416 (base-10). For chmod 755 (u=rwx,g=rx,o=rx), set to 0755
        /// (octal) or 493 (base-10). * This might be in conflict with other options that affect the file mode, like
        /// fsGroup, and the result can be other mode bits set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultMode")]
        public virtual System.Nullable<int> DefaultMode { get; set; }

        /// <summary>
        /// A list of secret versions to mount in the volume. If no items are specified, the volume will expose a file
        /// with the same name as the secret name. The contents of the file will be the data in the latest version of
        /// the secret. If items are specified, the key will be used as the version to fetch from Cloud Secret Manager
        /// and the path will be the name of the file exposed in the volume. When items are defined, they must specify
        /// both a key and a path.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<KeyToPath> Items { get; set; }

        /// <summary>Not supported by Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optional")]
        public virtual System.Nullable<bool> Optional { get; set; }

        /// <summary>
        /// The name of the secret in Cloud Secret Manager. By default, the secret is assumed to be in the same project.
        /// If the secret is in another project, you must define an alias. An alias definition has the form:
        /// :projects//secrets/. If multiple alias definitions are needed, they must be separated by commas. The alias
        /// definitions must be set on the run.googleapis.com/secrets annotation. Name of the secret in the container's
        /// namespace to use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretName")]
        public virtual string SecretName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Not supported by Cloud Run. SecurityContext holds security configuration that will be applied to a container.
    /// Some fields are present in both SecurityContext and PodSecurityContext. When both are set, the values in
    /// SecurityContext take precedence.
    /// </summary>
    public class SecurityContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The UID to run the entrypoint of the container process. Defaults to user specified in image metadata if
        /// unspecified. May also be set in PodSecurityContext. If set in both SecurityContext and PodSecurityContext,
        /// the value specified in SecurityContext takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runAsUser")]
        public virtual System.Nullable<int> RunAsUser { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Service acts as a top-level container that manages a set of Routes and Configurations which implement a network
    /// service. Service exists to provide a singular abstraction which can be access controlled, reasoned about, and
    /// which encapsulates software lifecycle decisions such as rollout policy and team resource ownership. Service acts
    /// only as an orchestrator of the underlying Routes and Configurations (much as a kubernetes Deployment
    /// orchestrates ReplicaSets). The Service's controller will track the statuses of its owned Configuration and
    /// Route, reflecting their statuses and conditions as its own.
    /// </summary>
    public class Service : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API version for this call. It must be "serving.knative.dev/v1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>The kind of resource. It must be "Service".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Metadata associated with this Service, including name, namespace, labels, and annotations. In Cloud Run,
        /// annotations with 'run.googleapis.com/' and 'autoscaling.knative.dev' are restricted, and the accepted
        /// annotations will be different depending on the resource type. The following Cloud Run-specific annotations
        /// are accepted in Service.metadata.annotations. * `run.googleapis.com/binary-authorization-breakglass` *
        /// `run.googleapis.com/binary-authorization` * `run.googleapis.com/client-name` *
        /// `run.googleapis.com/custom-audiences` * `run.googleapis.com/default-url-disabled` *
        /// `run.googleapis.com/description` * `run.googleapis.com/gc-traffic-tags` * `run.googleapis.com/ingress` *
        /// `run.googleapis.com/ingress` sets the ingress settings for the Service. See [the ingress settings
        /// documentation](/run/docs/securing/ingress) for details on configuring ingress settings. *
        /// `run.googleapis.com/ingress-status` is output-only and contains the currently active ingress settings for
        /// the Service. `run.googleapis.com/ingress-status` may differ from `run.googleapis.com/ingress` while the
        /// system is processing a change to `run.googleapis.com/ingress` or if the system failed to process a change to
        /// `run.googleapis.com/ingress`. When the system has processed all changes successfully
        /// `run.googleapis.com/ingress-status` and `run.googleapis.com/ingress` are equal.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ObjectMeta Metadata { get; set; }

        /// <summary>Holds the desired state of the Service (from the client).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual ServiceSpec Spec { get; set; }

        /// <summary>Communicates the system-controlled state of the Service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ServiceStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ServiceSpec holds the desired state of the Route (from the client), which is used to manipulate the underlying
    /// Route and Configuration(s).
    /// </summary>
    public class ServiceSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Holds the latest specification for the Revision to be stamped out.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("template")]
        public virtual RevisionTemplate Template { get; set; }

        /// <summary>
        /// Specifies how to distribute traffic over a collection of Knative Revisions and Configurations to the
        /// Service's main URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traffic")]
        public virtual System.Collections.Generic.IList<TrafficTarget> Traffic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The current state of the Service. Output only.</summary>
    public class ServiceStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Similar to url, information on where the service is available on HTTP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual Addressable Address { get; set; }

        /// <summary>
        /// Conditions communicate information about ongoing/complete reconciliation processes that bring the `spec`
        /// inline with the observed state of the world. Service-specific conditions include: * `ConfigurationsReady`:
        /// `True` when the underlying Configuration is ready. * `RoutesReady`: `True` when the underlying Route is
        /// ready. * `Ready`: `True` when all underlying resources are ready.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV1Condition> Conditions { get; set; }

        /// <summary>
        /// Name of the last revision that was created from this Service's Configuration. It might not be ready yet, for
        /// that use LatestReadyRevisionName.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestCreatedRevisionName")]
        public virtual string LatestCreatedRevisionName { get; set; }

        /// <summary>
        /// Name of the latest Revision from this Service's Configuration that has had its `Ready` condition become
        /// `True`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestReadyRevisionName")]
        public virtual string LatestReadyRevisionName { get; set; }

        /// <summary>
        /// Returns the generation last seen by the system. Clients polling for completed reconciliation should poll
        /// until observedGeneration = metadata.generation and the Ready condition's status is True or False.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observedGeneration")]
        public virtual System.Nullable<int> ObservedGeneration { get; set; }

        /// <summary>
        /// Holds the configured traffic distribution. These entries will always contain RevisionName references. When
        /// ConfigurationName appears in the spec, this will hold the LatestReadyRevisionName that we last observed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traffic")]
        public virtual System.Collections.Generic.IList<TrafficTarget> Traffic { get; set; }

        /// <summary>
        /// URL that will distribute traffic over the provided traffic targets. It generally has the form
        /// `https://{route-hash}-{project-hash}-{cluster-level-suffix}.a.run.app`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

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

    /// <summary>Status is a return value for calls that don't return other objects.</summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Suggested HTTP return code for this status, 0 if not set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// Extended data associated with the reason. Each reason may define its own extended details. This field is
        /// optional and the data returned is not guaranteed to conform to any schema except that defined by the reason
        /// type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual StatusDetails Details { get; set; }

        /// <summary>A human-readable description of the status of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Standard list metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ListMeta Metadata { get; set; }

        /// <summary>
        /// A machine-readable description of why this operation is in the "Failure" status. If this value is empty
        /// there is no information available. A Reason clarifies an HTTP status code but does not override it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>Status of the operation. One of: "Success" or "Failure".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string StatusValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// StatusCause provides more information about an api.Status failure, including cases when multiple errors are
    /// encountered.
    /// </summary>
    public class StatusCause : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The field of the resource that has caused this error, as named by its JSON serialization. May include dot
        /// and postfix notation for nested attributes. Arrays are zero-indexed. Fields may appear more than once in an
        /// array of causes due to fields having multiple errors. Examples: "name" - the field "name" on the current
        /// resource "items[0].name" - the field "name" on the first array entry in "items"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        /// <summary>
        /// A human-readable description of the cause of the error. This field may be presented as-is to a reader.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>
        /// A machine-readable description of the cause of the error. If this value is empty there is no information
        /// available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// StatusDetails is a set of additional properties that MAY be set by the server to provide additional information
    /// about a response. The Reason field of a Status object defines what attributes will be set. Clients must ignore
    /// fields that do not match the defined type of each attribute, and should assume that any attribute may be empty,
    /// invalid, or under defined.
    /// </summary>
    public class StatusDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Causes array includes more details associated with the StatusReason failure. Not all StatusReasons may
        /// provide detailed causes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("causes")]
        public virtual System.Collections.Generic.IList<StatusCause> Causes { get; set; }

        /// <summary>The group attribute of the resource associated with the status StatusReason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual string Group { get; set; }

        /// <summary>
        /// The kind attribute of the resource associated with the status StatusReason. On some operations may differ
        /// from the requested resource Kind.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The name attribute of the resource associated with the status StatusReason (when there is a single name
        /// which can be described).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// If specified, the time in seconds before the operation should be retried. Some errors may indicate the
        /// client must take an alternate action - for those errors this field may indicate how long to wait before
        /// taking the alternate action.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retryAfterSeconds")]
        public virtual System.Nullable<int> RetryAfterSeconds { get; set; }

        /// <summary>UID of the resource. (when there is a single resource which can be described).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>TCPSocketAction describes an action based on opening a socket</summary>
    public class TCPSocketAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Not supported by Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>Port number to access on the container. Number must be in the range 1 to 65535.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Task represents a single run of a container to completion.</summary>
    public class Task : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. APIVersion defines the versioned schema of this representation of an object. Servers should
        /// convert recognized schemas to the latest internal value, and may reject unrecognized values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>
        /// Optional. Kind is a string value representing the REST resource this object represents. Servers may infer
        /// this from the endpoint the client submits requests to. Cannot be updated. In CamelCase.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Optional. Standard object's metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ObjectMeta Metadata { get; set; }

        /// <summary>Optional. Specification of the desired behavior of a task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual TaskSpec Spec { get; set; }

        /// <summary>Output only. Current status of a task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual TaskStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result of a task attempt.</summary>
    public class TaskAttemptResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The exit code of this attempt. This may be unset if the container was unable to exit cleanly with
        /// a code due to some other failure. See status field for possible failure details. At most one of exit_code or
        /// term_signal will be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitCode")]
        public virtual System.Nullable<int> ExitCode { get; set; }

        /// <summary>
        /// Optional. The status of this attempt. If the status code is OK, then the attempt succeeded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>
        /// Optional. Termination signal of the container. This is set to non-zero if the container is terminated by the
        /// system. At most one of exit_code or term_signal will be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("termSignal")]
        public virtual System.Nullable<int> TermSignal { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>TaskSpec is a description of a task.</summary>
    public class TaskSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. List of containers belonging to the task. We disallow a number of fields on this Container.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<Container> Containers { get; set; }

        /// <summary>
        /// Optional. Number of retries allowed per task, before marking this job failed. Defaults to 3.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxRetries")]
        public virtual System.Nullable<int> MaxRetries { get; set; }

        /// <summary>
        /// Optional. The Node Selector configuration. Map of selector key to a value which matches a node.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeSelector")]
        public virtual System.Collections.Generic.IDictionary<string, string> NodeSelector { get; set; }

        /// <summary>
        /// Optional. Email address of the IAM service account associated with the task of a job execution. The service
        /// account represents the identity of the running task, and determines what permissions the task has. If not
        /// provided, the task will use the project's default service account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountName")]
        public virtual string ServiceAccountName { get; set; }

        /// <summary>
        /// Optional. Duration in seconds the task may be active before the system will actively try to mark it failed
        /// and kill associated containers. This applies per attempt of a task, meaning each retry can run for the full
        /// timeout. Defaults to 600 seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeoutSeconds")]
        public virtual System.Nullable<long> TimeoutSeconds { get; set; }

        /// <summary>Optional. List of volumes that can be mounted by containers belonging to the task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<Volume> Volumes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>TaskStatus represents the status of a task.</summary>
    public class TaskStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _completionTimeRaw;

        private object _completionTime;

        /// <summary>
        /// Optional. Represents time when the task was completed. It is not guaranteed to be set in happens-before
        /// order across separate operations. It is represented in RFC3339 form and is in UTC.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionTime")]
        public virtual string CompletionTimeRaw
        {
            get => _completionTimeRaw;
            set
            {
                _completionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _completionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CompletionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CompletionTimeDateTimeOffset instead.")]
        public virtual object CompletionTime
        {
            get => _completionTime;
            set
            {
                _completionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _completionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="CompletionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CompletionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CompletionTimeRaw);
            set => CompletionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. Conditions communicate information about ongoing/complete reconciliation processes that bring the
        /// "spec" inline with the observed state of the world. Task-specific conditions include: * `Started`: `True`
        /// when the task has started to execute. * `Completed`: `True` when the task has succeeded. `False` when the
        /// task has failed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV1Condition> Conditions { get; set; }

        /// <summary>Required. Index of the task, unique per execution, and beginning at 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>Optional. Result of the last attempt of this task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastAttemptResult")]
        public virtual TaskAttemptResult LastAttemptResult { get; set; }

        /// <summary>Optional. URI where logs for this task can be found in Cloud Console.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logUri")]
        public virtual string LogUri { get; set; }

        /// <summary>Optional. The 'generation' of the task that was last processed by the controller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observedGeneration")]
        public virtual System.Nullable<int> ObservedGeneration { get; set; }

        /// <summary>
        /// Optional. The number of times this task was retried. Instances are retried when they fail up to the
        /// maxRetries limit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retried")]
        public virtual System.Nullable<int> Retried { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>
        /// Optional. Represents time when the task started to run. It is not guaranteed to be set in happens-before
        /// order across separate operations. It is represented in RFC3339 form and is in UTC.
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>TaskTemplateSpec describes the data a task should have when created from a template.</summary>
    public class TaskTemplateSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Specification of the desired behavior of the task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual TaskSpec Spec { get; set; }

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

    /// <summary>TrafficTarget holds a single entry of the routing table for a Route.</summary>
    public class TrafficTarget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Deprecated] Not supported in Cloud Run. It must be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configurationName")]
        public virtual string ConfigurationName { get; set; }

        /// <summary>
        /// Uses the "status.latestReadyRevisionName" of the Service to determine the traffic target. When it changes,
        /// traffic will automatically migrate from the prior "latest ready" revision to the new one. This field must be
        /// false if RevisionName is set. This field defaults to true otherwise. If the field is set to true on Status,
        /// this means that the Revision was resolved from the Service's latest ready revision.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestRevision")]
        public virtual System.Nullable<bool> LatestRevision { get; set; }

        /// <summary>
        /// Percent specifies percent of the traffic to this Revision or Configuration. This defaults to zero if
        /// unspecified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percent")]
        public virtual System.Nullable<int> Percent { get; set; }

        /// <summary>
        /// Points this traffic target to a specific Revision. This field is mutually exclusive with latest_revision.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionName")]
        public virtual string RevisionName { get; set; }

        /// <summary>Tag is used to expose a dedicated url for referencing this target exclusively.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>
        /// Output only. URL displays the URL for accessing tagged traffic targets. URL is displayed in status, and is
        /// disallowed on spec. URL must contain a scheme (e.g. https://) and a hostname, but may not contain anything
        /// else (e.g. basic auth, url path, etc.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Volume represents a named volume in a container.</summary>
    public class Volume : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Not supported in Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configMap")]
        public virtual ConfigMapVolumeSource ConfigMap { get; set; }

        /// <summary>Volume specified by the Container Storage Interface driver</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("csi")]
        public virtual CSIVolumeSource Csi { get; set; }

        /// <summary>Ephemeral storage used as a shared volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emptyDir")]
        public virtual EmptyDirVolumeSource EmptyDir { get; set; }

        /// <summary>Volume's name. In Cloud Run Fully Managed, the name 'cloudsql' is reserved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("nfs")]
        public virtual NFSVolumeSource Nfs { get; set; }

        /// <summary>
        /// The secret's value will be presented as the content of a file whose name is defined in the item path. If no
        /// items are defined, the name of the file is the secretName.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secret")]
        public virtual SecretVolumeSource Secret { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VolumeMount describes a mounting of a Volume within a container.</summary>
    public class VolumeMount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Path within the container at which the volume should be mounted. Must not contain ':'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mountPath")]
        public virtual string MountPath { get; set; }

        /// <summary>
        /// Required. The name of the volume. There must be a corresponding Volume with the same name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Sets the mount to be read-only or read-write. Not used by Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readOnly")]
        public virtual System.Nullable<bool> ReadOnly__ { get; set; }

        /// <summary>
        /// Path within the volume from which the container's volume should be mounted. Defaults to "" (volume's root).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subPath")]
        public virtual string SubPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// WorkerPool acts as a top-level container that manages a set instance splits among a set of Revisions and a
    /// template for creating new Revisions.
    /// </summary>
    public class WorkerPool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API version for this call. It must be "run.googleapis.com/v1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>The kind of resource. It must be "WorkerPool".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Metadata associated with this WorkerPool, including name, namespace, labels, and annotations. In Cloud Run,
        /// annotations with 'run.googleapis.com/' and 'autoscaling.knative.dev' are restricted, and the accepted
        /// annotations will be different depending on the resource type. The following Cloud Run-specific annotations
        /// are accepted in WorkerPool.metadata.annotations. * `run.googleapis.com/binary-authorization-breakglass` *
        /// `run.googleapis.com/binary-authorization` * `run.googleapis.com/client-name` *
        /// `run.googleapis.com/description`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ObjectMeta Metadata { get; set; }

        /// <summary>Holds the desired state of the WorkerPool (from the client).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual WorkerPoolSpec Spec { get; set; }

        /// <summary>Communicates the system-controlled state of the WorkerPool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual WorkerPoolStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>WorkerPoolSpec holds the desired state of the WorkerPool's template and instance splits.</summary>
    public class WorkerPoolSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies how to distribute instances over a collection of Revisions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceSplits")]
        public virtual System.Collections.Generic.IList<InstanceSplit> InstanceSplits { get; set; }

        /// <summary>Holds the latest specification for the Revision to be stamped out.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("template")]
        public virtual RevisionTemplate Template { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The current state of the WorkerPool. Output only.</summary>
    public class WorkerPoolStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Conditions communicate information about ongoing/complete reconciliation processes that bring the `spec`
        /// inline with the observed state of the world. * `Ready`: `True` when all underlying resources are ready.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV1Condition> Conditions { get; set; }

        /// <summary>
        /// Holds the configured workload distribution. These entries will always contain RevisionName references. When
        /// ConfigurationName appears in the spec, this will hold the LatestReadyRevisionName that we last observed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceSplits")]
        public virtual System.Collections.Generic.IList<InstanceSplit> InstanceSplits { get; set; }

        /// <summary>
        /// Name of the last revision that was created from this WorkerPool's template. It might not be ready yet, for
        /// that use LatestReadyRevisionName.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestCreatedRevisionName")]
        public virtual string LatestCreatedRevisionName { get; set; }

        /// <summary>
        /// Name of the latest Revision from this WorkerPool's template that has had its `Ready` condition become
        /// `True`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestReadyRevisionName")]
        public virtual string LatestReadyRevisionName { get; set; }

        /// <summary>
        /// Returns the generation last seen by the system. Clients polling for completed reconciliation should poll
        /// until observedGeneration = metadata.generation and the Ready condition's status is True or False.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observedGeneration")]
        public virtual System.Nullable<int> ObservedGeneration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
