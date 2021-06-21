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
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "run";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://run.googleapis.com/";
        #else
            "https://run.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://run.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Run Admin API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Run Admin API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
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
            Revisions = new RevisionsResource(service);
            Routes = new RoutesResource(service);
            Services = new ServicesResource(service);
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
                return new ListRequest(service, parent);
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
            /// The name of the configuration to retrieve. For Cloud Run (fully managed), replace {namespace_id} with
            /// the project ID or number.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
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
                /// The name of the configuration to retrieve. For Cloud Run (fully managed), replace {namespace_id}
                /// with the project ID or number.
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

            /// <summary>List configurations.</summary>
            /// <param name="parent">
            /// The namespace from which the configurations should be listed. For Cloud Run (fully managed), replace
            /// {namespace_id} with the project ID or number.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>List configurations.</summary>
            public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.ListConfigurationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// The namespace from which the configurations should be listed. For Cloud Run (fully managed), replace
                /// {namespace_id} with the project ID or number.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional encoded string to continue paging.</summary>
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

                /// <summary>The maximum number of records that should be returned.</summary>
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
            /// The namespace in which the domain mapping should be created. For Cloud Run (fully managed), replace
            /// {namespace_id} with the project ID or number.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.CloudRun.v1.Data.DomainMapping body, string parent)
            {
                return new CreateRequest(service, body, parent);
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
                /// The namespace in which the domain mapping should be created. For Cloud Run (fully managed), replace
                /// {namespace_id} with the project ID or number.
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
            /// The name of the domain mapping to delete. For Cloud Run (fully managed), replace {namespace_id} with the
            /// project ID or number.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
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
                /// The name of the domain mapping to delete. For Cloud Run (fully managed), replace {namespace_id} with
                /// the project ID or number.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Cloud Run currently ignores this parameter.</summary>
                [Google.Apis.Util.RequestParameterAttribute("apiVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ApiVersion { get; set; }

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
                /// the background. Please see kubernetes.io/docs/concepts/workloads/controllers/garbage-collection/ for
                /// more information.
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
            /// The name of the domain mapping to retrieve. For Cloud Run (fully managed), replace {namespace_id} with
            /// the project ID or number.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
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
                /// The name of the domain mapping to retrieve. For Cloud Run (fully managed), replace {namespace_id}
                /// with the project ID or number.
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

            /// <summary>List domain mappings.</summary>
            /// <param name="parent">
            /// The namespace from which the domain mappings should be listed. For Cloud Run (fully managed), replace
            /// {namespace_id} with the project ID or number.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>List domain mappings.</summary>
            public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.ListDomainMappingsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// The namespace from which the domain mappings should be listed. For Cloud Run (fully managed),
                /// replace {namespace_id} with the project ID or number.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional encoded string to continue paging.</summary>
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

                /// <summary>The maximum number of records that should be returned.</summary>
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
            /// The name of the revision to delete. For Cloud Run (fully managed), replace {namespace_id} with the
            /// project ID or number.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
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
                /// The name of the revision to delete. For Cloud Run (fully managed), replace {namespace_id} with the
                /// project ID or number.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Cloud Run currently ignores this parameter.</summary>
                [Google.Apis.Util.RequestParameterAttribute("apiVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ApiVersion { get; set; }

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
                /// the background. Please see kubernetes.io/docs/concepts/workloads/controllers/garbage-collection/ for
                /// more information.
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
            /// The name of the revision to retrieve. For Cloud Run (fully managed), replace {namespace_id} with the
            /// project ID or number.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
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
                /// The name of the revision to retrieve. For Cloud Run (fully managed), replace {namespace_id} with the
                /// project ID or number.
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

            /// <summary>List revisions.</summary>
            /// <param name="parent">
            /// The namespace from which the revisions should be listed. For Cloud Run (fully managed), replace
            /// {namespace_id} with the project ID or number.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>List revisions.</summary>
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
                /// {namespace_id} with the project ID or number.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional encoded string to continue paging.</summary>
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

                /// <summary>The maximum number of records that should be returned.</summary>
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
            /// The name of the route to retrieve. For Cloud Run (fully managed), replace {namespace_id} with the
            /// project ID or number.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
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
                /// The name of the route to retrieve. For Cloud Run (fully managed), replace {namespace_id} with the
                /// project ID or number.
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

            /// <summary>List routes.</summary>
            /// <param name="parent">
            /// The namespace from which the routes should be listed. For Cloud Run (fully managed), replace
            /// {namespace_id} with the project ID or number.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>List routes.</summary>
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
                /// {namespace_id} with the project ID or number.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional encoded string to continue paging.</summary>
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

                /// <summary>The maximum number of records that should be returned.</summary>
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

            /// <summary>Create a service.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// The namespace in which the service should be created. For Cloud Run (fully managed), replace
            /// {namespace_id} with the project ID or number.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.CloudRun.v1.Data.Service body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Create a service.</summary>
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
                /// The namespace in which the service should be created. For Cloud Run (fully managed), replace
                /// {namespace_id} with the project ID or number.
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
            /// Delete a service. This will cause the Service to stop serving traffic and will delete the child entities
            /// like Routes, Configurations and Revisions.
            /// </summary>
            /// <param name="name">
            /// The name of the service to delete. For Cloud Run (fully managed), replace {namespace_id} with the
            /// project ID or number.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Delete a service. This will cause the Service to stop serving traffic and will delete the child entities
            /// like Routes, Configurations and Revisions.
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
                /// The name of the service to delete. For Cloud Run (fully managed), replace {namespace_id} with the
                /// project ID or number.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Cloud Run currently ignores this parameter.</summary>
                [Google.Apis.Util.RequestParameterAttribute("apiVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ApiVersion { get; set; }

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
                /// the background. Please see kubernetes.io/docs/concepts/workloads/controllers/garbage-collection/ for
                /// more information.
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

            /// <summary>Get information about a service.</summary>
            /// <param name="name">
            /// The name of the service to retrieve. For Cloud Run (fully managed), replace {namespace_id} with the
            /// project ID or number.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Get information about a service.</summary>
            public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Service>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The name of the service to retrieve. For Cloud Run (fully managed), replace {namespace_id} with the
                /// project ID or number.
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

            /// <summary>List services.</summary>
            /// <param name="parent">
            /// The namespace from which the services should be listed. For Cloud Run (fully managed), replace
            /// {namespace_id} with the project ID or number.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>List services.</summary>
            public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.ListServicesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// The namespace from which the services should be listed. For Cloud Run (fully managed), replace
                /// {namespace_id} with the project ID or number.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional encoded string to continue paging.</summary>
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

                /// <summary>The maximum number of records that should be returned.</summary>
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
            /// Replace a service. Only the spec and metadata labels and annotations are modifiable. After the Update
            /// request, Cloud Run will work to make the 'status' match the requested 'spec'. May provide
            /// metadata.resourceVersion to enforce update from last read for optimistic concurrency control.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The name of the service being replaced. For Cloud Run (fully managed), replace {namespace_id} with the
            /// project ID or number.
            /// </param>
            public virtual ReplaceServiceRequest ReplaceService(Google.Apis.CloudRun.v1.Data.Service body, string name)
            {
                return new ReplaceServiceRequest(service, body, name);
            }

            /// <summary>
            /// Replace a service. Only the spec and metadata labels and annotations are modifiable. After the Update
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
                /// The name of the service being replaced. For Cloud Run (fully managed), replace {namespace_id} with
                /// the project ID or number.
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
                return new ListRequest(service, parent);
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
                Revisions = new RevisionsResource(service);
                Routes = new RoutesResource(service);
                Services = new ServicesResource(service);
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
                    return new ListRequest(service, parent);
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
                /// The name of the configuration to retrieve. For Cloud Run (fully managed), replace {namespace_id}
                /// with the project ID or number.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
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
                    /// The name of the configuration to retrieve. For Cloud Run (fully managed), replace {namespace_id}
                    /// with the project ID or number.
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

                /// <summary>List configurations.</summary>
                /// <param name="parent">
                /// The namespace from which the configurations should be listed. For Cloud Run (fully managed), replace
                /// {namespace_id} with the project ID or number.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>List configurations.</summary>
                public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.ListConfigurationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// The namespace from which the configurations should be listed. For Cloud Run (fully managed),
                    /// replace {namespace_id} with the project ID or number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional encoded string to continue paging.</summary>
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

                    /// <summary>The maximum number of records that should be returned.</summary>
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
                /// The namespace in which the domain mapping should be created. For Cloud Run (fully managed), replace
                /// {namespace_id} with the project ID or number.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudRun.v1.Data.DomainMapping body, string parent)
                {
                    return new CreateRequest(service, body, parent);
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
                    /// The namespace in which the domain mapping should be created. For Cloud Run (fully managed),
                    /// replace {namespace_id} with the project ID or number.
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
                /// The name of the domain mapping to delete. For Cloud Run (fully managed), replace {namespace_id} with
                /// the project ID or number.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
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
                    /// The name of the domain mapping to delete. For Cloud Run (fully managed), replace {namespace_id}
                    /// with the project ID or number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Cloud Run currently ignores this parameter.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("apiVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ApiVersion { get; set; }

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
                    /// kubernetes.io/docs/concepts/workloads/controllers/garbage-collection/ for more information.
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
                /// The name of the domain mapping to retrieve. For Cloud Run (fully managed), replace {namespace_id}
                /// with the project ID or number.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
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
                    /// The name of the domain mapping to retrieve. For Cloud Run (fully managed), replace
                    /// {namespace_id} with the project ID or number.
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

                /// <summary>List domain mappings.</summary>
                /// <param name="parent">
                /// The namespace from which the domain mappings should be listed. For Cloud Run (fully managed),
                /// replace {namespace_id} with the project ID or number.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>List domain mappings.</summary>
                public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.ListDomainMappingsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// The namespace from which the domain mappings should be listed. For Cloud Run (fully managed),
                    /// replace {namespace_id} with the project ID or number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional encoded string to continue paging.</summary>
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

                    /// <summary>The maximum number of records that should be returned.</summary>
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
                /// The name of the revision to delete. For Cloud Run (fully managed), replace {namespace_id} with the
                /// project ID or number.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
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
                    /// The name of the revision to delete. For Cloud Run (fully managed), replace {namespace_id} with
                    /// the project ID or number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Cloud Run currently ignores this parameter.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("apiVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ApiVersion { get; set; }

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
                    /// kubernetes.io/docs/concepts/workloads/controllers/garbage-collection/ for more information.
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
                /// The name of the revision to retrieve. For Cloud Run (fully managed), replace {namespace_id} with the
                /// project ID or number.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
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
                    /// The name of the revision to retrieve. For Cloud Run (fully managed), replace {namespace_id} with
                    /// the project ID or number.
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

                /// <summary>List revisions.</summary>
                /// <param name="parent">
                /// The namespace from which the revisions should be listed. For Cloud Run (fully managed), replace
                /// {namespace_id} with the project ID or number.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>List revisions.</summary>
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
                    /// {namespace_id} with the project ID or number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional encoded string to continue paging.</summary>
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

                    /// <summary>The maximum number of records that should be returned.</summary>
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
                /// The name of the route to retrieve. For Cloud Run (fully managed), replace {namespace_id} with the
                /// project ID or number.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
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
                    /// The name of the route to retrieve. For Cloud Run (fully managed), replace {namespace_id} with
                    /// the project ID or number.
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

                /// <summary>List routes.</summary>
                /// <param name="parent">
                /// The namespace from which the routes should be listed. For Cloud Run (fully managed), replace
                /// {namespace_id} with the project ID or number.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>List routes.</summary>
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
                    /// {namespace_id} with the project ID or number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional encoded string to continue paging.</summary>
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

                    /// <summary>The maximum number of records that should be returned.</summary>
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

                /// <summary>Create a service.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// The namespace in which the service should be created. For Cloud Run (fully managed), replace
                /// {namespace_id} with the project ID or number.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudRun.v1.Data.Service body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Create a service.</summary>
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
                    /// The namespace in which the service should be created. For Cloud Run (fully managed), replace
                    /// {namespace_id} with the project ID or number.
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
                /// Delete a service. This will cause the Service to stop serving traffic and will delete the child
                /// entities like Routes, Configurations and Revisions.
                /// </summary>
                /// <param name="name">
                /// The name of the service to delete. For Cloud Run (fully managed), replace {namespace_id} with the
                /// project ID or number.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Delete a service. This will cause the Service to stop serving traffic and will delete the child
                /// entities like Routes, Configurations and Revisions.
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
                    /// The name of the service to delete. For Cloud Run (fully managed), replace {namespace_id} with
                    /// the project ID or number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Cloud Run currently ignores this parameter.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("apiVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ApiVersion { get; set; }

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
                    /// kubernetes.io/docs/concepts/workloads/controllers/garbage-collection/ for more information.
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

                /// <summary>Get information about a service.</summary>
                /// <param name="name">
                /// The name of the service to retrieve. For Cloud Run (fully managed), replace {namespace_id} with the
                /// project ID or number.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Get information about a service.</summary>
                public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.Service>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the service to retrieve. For Cloud Run (fully managed), replace {namespace_id} with
                    /// the project ID or number.
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
                /// Get the IAM Access Control policy currently in effect for the given Cloud Run service. This result
                /// does not include any inherited policies.
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
                /// Get the IAM Access Control policy currently in effect for the given Cloud Run service. This result
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
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>
                    /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests
                    /// specifying an invalid value will be rejected. Requests for policies with any conditional
                    /// bindings must specify version 3. Policies without any conditional bindings may specify any valid
                    /// value or leave the field unset. To learn which resources support conditions in their IAM
                    /// policies, see the [IAM
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

                /// <summary>List services.</summary>
                /// <param name="parent">
                /// The namespace from which the services should be listed. For Cloud Run (fully managed), replace
                /// {namespace_id} with the project ID or number.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>List services.</summary>
                public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1.Data.ListServicesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// The namespace from which the services should be listed. For Cloud Run (fully managed), replace
                    /// {namespace_id} with the project ID or number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional encoded string to continue paging.</summary>
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

                    /// <summary>The maximum number of records that should be returned.</summary>
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
                /// Replace a service. Only the spec and metadata labels and annotations are modifiable. After the
                /// Update request, Cloud Run will work to make the 'status' match the requested 'spec'. May provide
                /// metadata.resourceVersion to enforce update from last read for optimistic concurrency control.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name of the service being replaced. For Cloud Run (fully managed), replace {namespace_id} with
                /// the project ID or number.
                /// </param>
                public virtual ReplaceServiceRequest ReplaceService(Google.Apis.CloudRun.v1.Data.Service body, string name)
                {
                    return new ReplaceServiceRequest(service, body, name);
                }

                /// <summary>
                /// Replace a service. Only the spec and metadata labels and annotations are modifiable. After the
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
                    /// The name of the service being replaced. For Cloud Run (fully managed), replace {namespace_id}
                    /// with the project ID or number.
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
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudRun.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
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
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
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
                /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                /// documentation for the appropriate value for this field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudRun.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
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
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
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

            /// <summary>Lists information about the supported locations for this service.</summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(service, name);
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
                /// A filter to narrow down results to a preferred subset. The filtering language accepts strings like
                /// "displayName=tokyo", and is documented in more detail in [AIP-160](https://google.aip.dev/160).
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
    /// logging. It also exempts jose@example.com from DATA_READ logging, and aliya@example.com from DATA_WRITE logging.
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
    /// [Webmaster Central](https://www.google.com/webmasters/verification/home).
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

    /// <summary>Associates `members` with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// members in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

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
    /// Not supported by Cloud Run ConfigMapEnvSource selects a ConfigMap to populate the environment variables with.
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

        /// <summary>(Optional) Specify whether the ConfigMap must be defined</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optional")]
        public virtual System.Nullable<bool> Optional { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Not supported by Cloud Run Selects a key from a ConfigMap.</summary>
    public class ConfigMapKeySelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The key to select.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// This field should not be used directly as it is meant to be inlined directly into the message. Use the
        /// "name" field instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localObjectReference")]
        public virtual LocalObjectReference LocalObjectReference { get; set; }

        /// <summary>The ConfigMap to select from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>(Optional) Specify whether the ConfigMap or its key must be defined</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optional")]
        public virtual System.Nullable<bool> Optional { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Not supported by Cloud Run Adapts a ConfigMap into a volume. The contents of the target ConfigMap's Data field
    /// will be presented in a volume as files using the keys in the Data field as the file names, unless the items
    /// element is populated with specific mappings of keys to paths.
    /// </summary>
    public class ConfigMapVolumeSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// (Optional) Mode bits to use on created files by default. Must be a value between 0 and 0777. Defaults to
        /// 0644. Directories within the path are not affected by this setting. This might be in conflict with other
        /// options that affect the file mode, like fsGroup, and the result can be other mode bits set.
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
    /// "latest created" revision's name is available under status, as is the "latest ready" revision's name. See also:
    /// https://github.com/knative/serving/blob/master/docs/spec/overview.md#configuration
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
        /// Conditions communicates information about ongoing/complete reconciliation processes that bring the "spec"
        /// inline with the observed state of the world.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV1Condition> Conditions { get; set; }

        /// <summary>
        /// LatestCreatedRevisionName is the last revision that was created from this Configuration. It might not be
        /// ready yet, for that use LatestReadyRevisionName.
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
        /// (Optional) Arguments to the entrypoint. The docker image's CMD is used if this is not provided. Variable
        /// references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the
        /// reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie:
        /// $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not.
        /// More info:
        /// https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("command")]
        public virtual System.Collections.Generic.IList<string> Command { get; set; }

        /// <summary>(Optional) List of environment variables to set in the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual System.Collections.Generic.IList<EnvVar> Env { get; set; }

        /// <summary>
        /// (Optional) List of sources to populate environment variables in the container. The keys defined within a
        /// source must be a C_IDENTIFIER. All invalid keys will be reported as an event when the container is starting.
        /// When a key exists in multiple sources, the value associated with the last source will take precedence.
        /// Values defined by an Env with a duplicate key will take precedence. Cannot be updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("envFrom")]
        public virtual System.Collections.Generic.IList<EnvFromSource> EnvFrom { get; set; }

        /// <summary>
        /// Only supports containers from Google Container Registry or Artifact Registry URL of the Container image.
        /// More info: https://kubernetes.io/docs/concepts/containers/images
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual string Image { get; set; }

        /// <summary>
        /// (Optional) Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is
        /// specified, or IfNotPresent otherwise. More info:
        /// https://kubernetes.io/docs/concepts/containers/images#updating-images
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imagePullPolicy")]
        public virtual string ImagePullPolicy { get; set; }

        /// <summary>
        /// (Optional) Periodic probe of container liveness. Container will be restarted if the probe fails. More info:
        /// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("livenessProbe")]
        public virtual Probe LivenessProbe { get; set; }

        /// <summary>
        /// (Optional) Name of the container specified as a DNS_LABEL. Currently unused in Cloud Run. More info:
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#dns-label-names
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// (Optional) List of ports to expose from the container. Only a single port can be specified. The specified
        /// ports must be listening on all interfaces (0.0.0.0) within the container to be accessible. If omitted, a
        /// port number will be chosen and passed to the container through the PORT environment variable for the
        /// container to listen on.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ports")]
        public virtual System.Collections.Generic.IList<ContainerPort> Ports { get; set; }

        /// <summary>
        /// (Optional) Periodic probe of container service readiness. Container will be removed from service endpoints
        /// if the probe fails. More info:
        /// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readinessProbe")]
        public virtual Probe ReadinessProbe { get; set; }

        /// <summary>
        /// (Optional) Compute Resources required by this container. More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual ResourceRequirements Resources { get; set; }

        /// <summary>
        /// (Optional) Security options the pod should run with. More info:
        /// https://kubernetes.io/docs/concepts/policy/security-context/ More info:
        /// https://kubernetes.io/docs/tasks/configure-pod-container/security-context/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityContext")]
        public virtual SecurityContext SecurityContext { get; set; }

        /// <summary>
        /// (Optional) Startup probe of application within the container. All other probes are disabled if a startup
        /// probe is provided, until it succeeds. Container will not be added to service endpoints if the probe fails.
        /// More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startupProbe")]
        public virtual Probe StartupProbe { get; set; }

        /// <summary>
        /// (Optional) Path at which the file to which the container's termination message will be written is mounted
        /// into the container's filesystem. Message written is intended to be brief final status, such as an assertion
        /// failure message. Will be truncated by the node if greater than 4096 bytes. The total message length across
        /// all containers will be limited to 12kb. Defaults to /dev/termination-log.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terminationMessagePath")]
        public virtual string TerminationMessagePath { get; set; }

        /// <summary>
        /// (Optional) Indicate how the termination message should be populated. File will use the contents of
        /// terminationMessagePath to populate the container status message on both success and failure.
        /// FallbackToLogsOnError will use the last chunk of container log output if the termination message file is
        /// empty and the container exited with an error. The log output is limited to 2048 bytes or 80 lines, whichever
        /// is smaller. Defaults to File. Cannot be updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terminationMessagePolicy")]
        public virtual string TerminationMessagePolicy { get; set; }

        /// <summary>
        /// (Optional) Volume to mount into the container's filesystem. Only supports SecretVolumeSources. Pod volumes
        /// to mount into the container's filesystem.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeMounts")]
        public virtual System.Collections.Generic.IList<VolumeMount> VolumeMounts { get; set; }

        /// <summary>
        /// (Optional) Container's working directory. If not specified, the container runtime's default will be used,
        /// which might be configured in the container image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workingDir")]
        public virtual string WorkingDir { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ContainerPort represents a network port in a single container.</summary>
    public class ContainerPort : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// (Optional) Port number the container listens on. This must be a valid port number, 0 &amp;lt; x &amp;lt;
        /// 65536.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerPort")]
        public virtual System.Nullable<int> ContainerPortValue { get; set; }

        /// <summary>
        /// (Optional) If specified, used to specify which protocol to use. Allowed values are "http1" and "h2c".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>(Optional) Protocol for port. Must be "TCP". Defaults to "TCP".</summary>
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

        /// <summary>
        /// Cloud Run fully managed: not supported Cloud Run on GKE: supported Holds the URL that will serve the traffic
        /// of the DomainMapping. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Not supported by Cloud Run EnvFromSource represents the source of a set of ConfigMaps</summary>
    public class EnvFromSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>(Optional) The ConfigMap to select from</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configMapRef")]
        public virtual ConfigMapEnvSource ConfigMapRef { get; set; }

        /// <summary>
        /// (Optional) An optional identifier to prepend to each key in the ConfigMap. Must be a C_IDENTIFIER.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prefix")]
        public virtual string Prefix { get; set; }

        /// <summary>(Optional) The Secret to select from</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretRef")]
        public virtual SecretEnvSource SecretRef { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>EnvVar represents an environment variable present in a Container.</summary>
    public class EnvVar : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the environment variable. Must be a C_IDENTIFIER.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// (Optional) Variable references $(VAR_NAME) are expanded using the previous defined environment variables in
        /// the container and any route environment variables. If a variable cannot be resolved, the reference in the
        /// input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME).
        /// Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to "".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>
        /// (Optional) Source for the environment variable's value. Only supports secret_key_ref. Source for the
        /// environment variable's value. Cannot be used if value is not empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueFrom")]
        public virtual EnvVarSource ValueFrom { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>EnvVarSource represents a source for the value of an EnvVar.</summary>
    public class EnvVarSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>(Optional) Not supported by Cloud Run Selects a key of a ConfigMap.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configMapKeyRef")]
        public virtual ConfigMapKeySelector ConfigMapKeyRef { get; set; }

        /// <summary>(Optional) Selects a key (version) of a secret in Secret Manager.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretKeyRef")]
        public virtual SecretKeySelector SecretKeyRef { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Not supported by Cloud Run ExecAction describes a "run in container" action.</summary>
    public class ExecAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// (Optional) Command is the command line to execute inside the container, the working directory for the
        /// command is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a
        /// shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call
        /// out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("command")]
        public virtual System.Collections.Generic.IList<string> Command { get; set; }

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

    /// <summary>Condition defines a generic condition for a Resource</summary>
    public class GoogleCloudRunV1Condition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Last time the condition transitioned from one status to another.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastTransitionTime")]
        public virtual object LastTransitionTime { get; set; }

        /// <summary>Optional. Human readable message indicating details about the current status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Optional. One-word CamelCase reason for the condition's last transition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>Optional. How to interpret failures of this condition, one of Error, Warning, Info</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>Status of the condition, one of True, False, Unknown.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// type is used to communicate the status of the reconciliation process. See also:
        /// https://github.com/knative/serving/blob/master/docs/spec/errors.md#error-conditions-and-reporting Types
        /// common to all resources include: * "Ready": True when the Resource is ready.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Not supported by Cloud Run HTTPGetAction describes an action based on HTTP Get requests.</summary>
    public class HTTPGetAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// (Optional) Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders
        /// instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>(Optional) Custom headers to set in the request. HTTP allows repeated headers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpHeaders")]
        public virtual System.Collections.Generic.IList<HTTPHeader> HttpHeaders { get; set; }

        /// <summary>(Optional) Path to access on the HTTP server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>(Optional) Scheme to use for connecting to the host. Defaults to HTTP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheme")]
        public virtual string Scheme { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Not supported by Cloud Run HTTPHeader describes a custom header to be used in HTTP probes</summary>
    public class HTTPHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The header field name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The header field value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Maps a string key to a path within a volume.</summary>
    public class KeyToPath : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Cloud Secret Manager secret version. Can be 'latest' for the latest value or an integer for a specific
        /// version. The key to project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// (Optional) Mode bits to use on this file, must be a value between 0000 and 0777. If not specified, the
        /// volume defaultMode will be used. This might be in conflict with other options that affect the file mode,
        /// like fsGroup, and the result can be other mode bits set.
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
    /// ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A
    /// resource may have only one of {ObjectMeta, ListMeta}.
    /// </summary>
    public class ListMeta : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// continue may be set if the user set a limit on the number of items returned, and indicates that the server
        /// has more data available. The value is opaque and may be used to issue another request to the endpoint that
        /// served this list to retrieve the next set of available objects. Continuing a list may not be possible if the
        /// server configuration has changed or more than a few minutes have passed. The resourceVersion field returned
        /// when using this continue value will be identical to the value in the first response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("continue")]
        public virtual string Continue__ { get; set; }

        /// <summary>
        /// String that identifies the server's internal version of this object that can be used by clients to determine
        /// when objects have changed. Value must be treated as opaque by clients and passed unmodified back to the
        /// server. Populated by the system. Read-only. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#concurrency-control-and-consistency
        /// +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceVersion")]
        public virtual string ResourceVersion { get; set; }

        /// <summary>SelfLink is a URL representing this object. Populated by the system. Read-only. +optional</summary>
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
        /// <summary>The API version for this call such as "serving.knative.dev/v1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>List of Services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Service> Items { get; set; }

        /// <summary>The kind of this resource, in this case "ServiceList".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Metadata associated with this Service list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ListMeta Metadata { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Not supported by Cloud Run LocalObjectReference contains enough information to let you locate the referenced
    /// object inside the same namespace.
    /// </summary>
    public class LocalObjectReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// (Optional) Name of the referent. More info:
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

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
    /// k8s.io.apimachinery.pkg.apis.meta.v1.ObjectMeta is metadata that all persisted resources must have, which
    /// includes all objects users must create.
    /// </summary>
    public class ObjectMeta : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// (Optional) Annotations is an unstructured key value map stored with a resource that may be set by external
        /// tools to store and retrieve arbitrary metadata. They are not queryable and should be preserved when
        /// modifying objects. More info: http://kubernetes.io/docs/user-guide/annotations
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// (Optional) Not supported by Cloud Run The name of the cluster which the object belongs to. This is used to
        /// distinguish resources with same name and namespace in different clusters. This field is not set anywhere
        /// right now and apiserver is going to ignore it if set in create or update request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterName")]
        public virtual string ClusterName { get; set; }

        /// <summary>
        /// (Optional) CreationTimestamp is a timestamp representing the server time when this object was created. It is
        /// not guaranteed to be set in happens-before order across separate operations. Clients may not set this value.
        /// It is represented in RFC3339 form and is in UTC. Populated by the system. Read-only. Null for lists. More
        /// info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTimestamp")]
        public virtual object CreationTimestamp { get; set; }

        /// <summary>
        /// (Optional) Not supported by Cloud Run Number of seconds allowed for this object to gracefully terminate
        /// before it will be removed from the system. Only set when deletionTimestamp is also set. May only be
        /// shortened. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionGracePeriodSeconds")]
        public virtual System.Nullable<int> DeletionGracePeriodSeconds { get; set; }

        /// <summary>
        /// (Optional) Not supported by Cloud Run DeletionTimestamp is RFC 3339 date and time at which this resource
        /// will be deleted. This field is set by the server when a graceful deletion is requested by the user, and is
        /// not directly settable by a client. The resource is expected to be deleted (no longer visible from resource
        /// lists, and not reachable by name) after the time in this field, once the finalizers list is empty. As long
        /// as the finalizers list contains items, deletion is blocked. Once the deletionTimestamp is set, this value
        /// may not be unset or be set further into the future, although it may be shortened or the resource may be
        /// deleted prior to this time. For example, a user may request that a pod is deleted in 30 seconds. The Kubelet
        /// will react by sending a graceful termination signal to the containers in the pod. After that 30 seconds, the
        /// Kubelet will send a hard termination signal (SIGKILL) to the container and after cleanup, remove the pod
        /// from the API. In the presence of network partitions, this object may still exist after this timestamp, until
        /// an administrator or automated process can determine the resource is fully terminated. If not set, graceful
        /// deletion of the object has not been requested. Populated by the system when a graceful deletion is
        /// requested. Read-only. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionTimestamp")]
        public virtual object DeletionTimestamp { get; set; }

        /// <summary>
        /// (Optional) Not supported by Cloud Run Must be empty before the object is deleted from the registry. Each
        /// entry is an identifier for the responsible component that will remove the entry from the list. If the
        /// deletionTimestamp of the object is non-nil, entries in this list can only be removed. +patchStrategy=merge
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalizers")]
        public virtual System.Collections.Generic.IList<string> Finalizers { get; set; }

        /// <summary>
        /// (Optional) Not supported by Cloud Run GenerateName is an optional prefix, used by the server, to generate a
        /// unique name ONLY IF the Name field has not been provided. If this field is used, the name returned to the
        /// client will be different than the name passed. This value will also be combined with a unique suffix. The
        /// provided value has the same validation rules as the Name field, and may be truncated by the length of the
        /// suffix required to make the value unique on the server. If this field is specified and the generated name
        /// exists, the server will NOT return a 409 - instead, it will either return 201 Created or 500 with Reason
        /// ServerTimeout indicating a unique name could not be found in the time allotted, and the client should retry
        /// (optionally after the time indicated in the Retry-After header). Applied only if Name is not specified. More
        /// info: https://git.k8s.io/community/contributors/devel/api-conventions.md#idempotency string generateName =
        /// 2;
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generateName")]
        public virtual string GenerateName { get; set; }

        /// <summary>
        /// (Optional) A sequence number representing a specific generation of the desired state. Populated by the
        /// system. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<int> Generation { get; set; }

        /// <summary>
        /// (Optional) Map of string keys and values that can be used to organize and categorize (scope and select)
        /// objects. May match selectors of replication controllers and routes. More info:
        /// http://kubernetes.io/docs/user-guide/labels
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Name must be unique within a namespace, within a Cloud Run region. Is required when creating resources,
        /// although some resources may allow a client to request the generation of an appropriate name automatically.
        /// Name is primarily intended for creation idempotence and configuration definition. Cannot be updated. More
        /// info: http://kubernetes.io/docs/user-guide/identifiers#names +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Namespace defines the space within each name must be unique, within a Cloud Run region. In Cloud Run the
        /// namespace must be equal to either the project ID or project number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespace")]
        public virtual string Namespace__ { get; set; }

        /// <summary>
        /// (Optional) Not supported by Cloud Run List of objects that own this object. If ALL objects in the list have
        /// been deleted, this object will be garbage collected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerReferences")]
        public virtual System.Collections.Generic.IList<OwnerReference> OwnerReferences { get; set; }

        /// <summary>
        /// Optional. An opaque value that represents the internal version of this object that can be used by clients to
        /// determine when objects have changed. May be used for optimistic concurrency, change detection, and the watch
        /// operation on a resource or set of resources. Clients must treat these values as opaque and passed unmodified
        /// back to the server or omit the value to disable conflict-detection. They may only be valid for a particular
        /// resource or set of resources. Populated by the system. Read-only. Value must be treated as opaque by clients
        /// or omitted. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceVersion")]
        public virtual string ResourceVersion { get; set; }

        /// <summary>
        /// (Optional) SelfLink is a URL representing this object. Populated by the system. Read-only. string selfLink =
        /// 4;
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>
        /// (Optional) UID is the unique in time and space value for this object. It is typically generated by the
        /// server on successful creation of a resource and is not allowed to change on PUT operations. Populated by the
        /// system. Read-only. More info: http://kubernetes.io/docs/user-guide/identifiers#uids
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// OwnerReference contains enough information to let you identify an owning object. Currently, an owning object
    /// must be in the same namespace, so there is no namespace field.
    /// </summary>
    public class OwnerReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>API version of the referent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>
        /// If true, AND if the owner has the "foregroundDeletion" finalizer, then the owner cannot be deleted from the
        /// key-value store until this reference is removed. Defaults to false. To set this field, a user needs "delete"
        /// permission of the owner, otherwise 422 (Unprocessable Entity) will be returned. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockOwnerDeletion")]
        public virtual System.Nullable<bool> BlockOwnerDeletion { get; set; }

        /// <summary>If true, this reference points to the managing controller. +optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controller")]
        public virtual System.Nullable<bool> Controller { get; set; }

        /// <summary>
        /// Kind of the referent. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Name of the referent. More info: http://kubernetes.io/docs/user-guide/identifiers#names</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>UID of the referent. More info: http://kubernetes.io/docs/user-guide/identifiers#uids</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

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
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<AuditConfig> AuditConfigs { get; set; }

        /// <summary>
        /// Associates a list of `members` to a `role`. Optionally, may specify a `condition` that determines how and
        /// when the `bindings` are applied. Each of the `bindings` must contain at least one member.
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
    /// Not supported by Cloud Run Probe describes a health check to be performed against a container to determine
    /// whether it is alive or ready to receive traffic.
    /// </summary>
    public class Probe : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// (Optional) One and only one of the following should be specified. Exec specifies the action to take. A field
        /// inlined from the Handler message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exec")]
        public virtual ExecAction Exec { get; set; }

        /// <summary>
        /// (Optional) Minimum consecutive failures for the probe to be considered failed after having succeeded.
        /// Defaults to 3. Minimum value is 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureThreshold")]
        public virtual System.Nullable<int> FailureThreshold { get; set; }

        /// <summary>
        /// (Optional) HTTPGet specifies the http request to perform. A field inlined from the Handler message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpGet")]
        public virtual HTTPGetAction HttpGet { get; set; }

        /// <summary>
        /// (Optional) Number of seconds after the container has started before liveness probes are initiated. More
        /// info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialDelaySeconds")]
        public virtual System.Nullable<int> InitialDelaySeconds { get; set; }

        /// <summary>
        /// (Optional) How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("periodSeconds")]
        public virtual System.Nullable<int> PeriodSeconds { get; set; }

        /// <summary>
        /// (Optional) Minimum consecutive successes for the probe to be considered successful after having failed.
        /// Defaults to 1. Must be 1 for liveness. Minimum value is 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successThreshold")]
        public virtual System.Nullable<int> SuccessThreshold { get; set; }

        /// <summary>
        /// (Optional) TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported A field inlined
        /// from the Handler message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tcpSocket")]
        public virtual TCPSocketAction TcpSocket { get; set; }

        /// <summary>
        /// (Optional) Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More
        /// info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
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
        /// (Optional) Only memory and CPU are supported. Note: The only supported values for CPU are '1', '2', and '4'.
        /// Setting 4 CPU requires at least 2Gi of memory. Limits describes the maximum amount of compute resources
        /// allowed. The values of the map is string form of the 'quantity' k8s type:
        /// https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limits")]
        public virtual System.Collections.Generic.IDictionary<string, string> Limits { get; set; }

        /// <summary>
        /// (Optional) Only memory and CPU are supported. Note: The only supported values for CPU are '1' and '2'.
        /// Requests describes the minimum amount of compute resources required. If Requests is omitted for a container,
        /// it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. The
        /// values of the map is string form of the 'quantity' k8s type:
        /// https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IDictionary<string, string> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Revision is an immutable snapshot of code and configuration. A revision references a container image. Revisions
    /// are created by updates to a Configuration. See also:
    /// https://github.com/knative/serving/blob/master/docs/spec/overview.md#revision
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
        /// (Optional) ContainerConcurrency specifies the maximum allowed in-flight (concurrent) requests per container
        /// instance of the Revision. Cloud Run fully managed: supported, defaults to 80 Cloud Run for Anthos:
        /// supported, defaults to 0, which means concurrency to the application is not limited, and the system decides
        /// the target concurrency for the autoscaler.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerConcurrency")]
        public virtual System.Nullable<int> ContainerConcurrency { get; set; }

        /// <summary>
        /// Containers holds the single container that defines the unit of execution for this Revision. In the context
        /// of a Revision, we disallow a number of fields on this Container, including: name and lifecycle. In Cloud
        /// Run, only a single container may be provided. The runtime contract is documented here:
        /// https://github.com/knative/serving/blob/master/docs/runtime-contract.md
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<Container> Containers { get; set; }

        /// <summary>
        /// Email address of the IAM service account associated with the revision of the service. The service account
        /// represents the identity of the running revision, and determines what permissions the revision has. If not
        /// provided, the revision will use the project's default service account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountName")]
        public virtual string ServiceAccountName { get; set; }

        /// <summary>
        /// TimeoutSeconds holds the max duration the instance is allowed for responding to a request. Cloud Run fully
        /// managed: defaults to 300 seconds (5 minutes). Maximum allowed value is 900 seconds (15 minutes). Cloud Run
        /// for Anthos: defaults to 300 seconds (5 minutes). Maximum allowed value is configurable by the cluster
        /// operator.
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
        /// Conditions communicates information about ongoing/complete reconciliation processes that bring the "spec"
        /// inline with the observed state of the world. As a Revision is being prepared, it will incrementally update
        /// conditions. Revision-specific conditions include: * "ResourcesAvailable": True when underlying resources
        /// have been provisioned. * "ContainerHealthy": True when the Revision readiness check completes. * "Active":
        /// True when the Revision may receive traffic.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV1Condition> Conditions { get; set; }

        /// <summary>
        /// ImageDigest holds the resolved digest for the image specified within .Spec.Container.Image. The digest is
        /// resolved during the creation of Revision. This field holds the digest value regardless of whether a tag or
        /// digest was originally specified in the Container object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageDigest")]
        public virtual string ImageDigest { get; set; }

        /// <summary>
        /// Specifies the generated logging url for this particular revision based on the revision url template
        /// specified in the controller's config. +optional
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

    /// <summary>
    /// RevisionTemplateSpec describes the data a revision should have when created from a template. Based on:
    /// https://github.com/kubernetes/api/blob/e771f807/core/v1/types.go#L3179-L3190
    /// </summary>
    public class RevisionTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional metadata for this Revision, including labels and annotations. Name will be generated by the
        /// Configuration. The following annotation keys set properties of the created revision: *
        /// `autoscaling.knative.dev/minScale` sets the minimum number of instances. *
        /// `autoscaling.knative.dev/maxScale` sets the maximum number of instances. *
        /// `run.googleapis.com/cloudsql-instances` sets Cloud SQL connections. Multiple values should be comma
        /// separated. * `run.googleapis.com/vpc-access-connector` sets a Serverless VPC Access connector. *
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
    /// changes, and smoothly rolling out latest revisions. See also:
    /// https://github.com/knative/serving/blob/master/docs/spec/overview.md#route Cloud Run currently supports
    /// referencing a single Configuration to automatically deploy the "latest ready" Revision from that Configuration.
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
        /// Ready condition's status is True or False. Note that providing a trafficTarget that only has a
        /// configurationName will result in a Route that does not increment either its metadata.generation or its
        /// observedGeneration, as new "latest ready" revisions from the Configuration are processed without an update
        /// to the Route's spec.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observedGeneration")]
        public virtual System.Nullable<int> ObservedGeneration { get; set; }

        /// <summary>
        /// Traffic holds the configured traffic distribution. These entries will always contain RevisionName
        /// references. When ConfigurationName appears in the spec, this will hold the LatestReadyRevisionName that we
        /// last observed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traffic")]
        public virtual System.Collections.Generic.IList<TrafficTarget> Traffic { get; set; }

        /// <summary>
        /// URL holds the url that will distribute traffic over the provided traffic targets. It generally has the form:
        /// https://{route-hash}-{project-hash}-{cluster-level-suffix}.a.run.app
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Not supported by Cloud Run SecretEnvSource selects a Secret to populate the environment variables with. The
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

        /// <summary>(Optional) Specify whether the Secret must be defined</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optional")]
        public virtual System.Nullable<bool> Optional { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SecretKeySelector selects a key of a Secret.</summary>
    public class SecretKeySelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A Cloud Secret Manager secret version. Must be 'latest' for the latest version or an integer for a specific
        /// version. The key of the secret to select from. Must be a valid secret key.
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

        /// <summary>(Optional) Specify whether the Secret or its key must be defined</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optional")]
        public virtual System.Nullable<bool> Optional { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The secret's value will be presented as the content of a file whose name is defined in the item path. If no
    /// items are defined, the name of the file is the secret_name. The contents of the target Secret's Data field will
    /// be presented in a volume as files using the keys in the Data field as the file names.
    /// </summary>
    public class SecretVolumeSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// (Optional) Mode bits to use on created files by default. Must be a value between 0000 and 0777. Defaults to
        /// 0644. Directories within the path are not affected by this setting. This might be in conflict with other
        /// options that affect the file mode, like fsGroup, and the result can be other mode bits set. NOTE: This is an
        /// integer representation of the mode bits. So, the integer value should look exactly as the chmod numeric
        /// notation, i.e. Unix chmod "777" (a=rwx) should have the integer value 777.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultMode")]
        public virtual System.Nullable<int> DefaultMode { get; set; }

        /// <summary>
        /// (Optional) If unspecified, the volume will expose a file whose name is the secret_name. If specified, the
        /// key will be used as the version to fetch from Cloud Secret Manager and the path will be the name of the file
        /// exposed in the volume. When items are defined, they must specify a key and a path. If unspecified, each
        /// key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose
        /// name is the key and content is the value. If specified, the listed keys will be projected into the specified
        /// paths, and unlisted keys will not be present. If a key is specified that is not present in the Secret, the
        /// volume setup will error unless it is marked optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<KeyToPath> Items { get; set; }

        /// <summary>(Optional) Specify whether the Secret or its keys must be defined.</summary>
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
    /// Not supported by Cloud Run SecurityContext holds security configuration that will be applied to a container.
    /// Some fields are present in both SecurityContext and PodSecurityContext. When both are set, the values in
    /// SecurityContext take precedence.
    /// </summary>
    public class SecurityContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// (Optional) The UID to run the entrypoint of the container process. Defaults to user specified in image
        /// metadata if unspecified. May also be set in PodSecurityContext. If set in both SecurityContext and
        /// PodSecurityContext, the value specified in SecurityContext takes precedence.
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
    /// Route, reflecting their statuses and conditions as its own. See also:
    /// https://github.com/knative/serving/blob/master/docs/spec/overview.md#service
    /// </summary>
    public class Service : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API version for this call such as "serving.knative.dev/v1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>The kind of resource, in this case "Service".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Metadata associated with this Service, including name, namespace, labels, and annotations. Cloud Run (fully
        /// managed) uses the following annotation keys to configure features on a Service: *
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

        /// <summary>Spec holds the desired state of the Service (from the client).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual ServiceSpec Spec { get; set; }

        /// <summary>Status communicates the observed state of the Service (from the controller).</summary>
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
        /// <summary>Template holds the latest specification for the Revision to be stamped out.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("template")]
        public virtual RevisionTemplate Template { get; set; }

        /// <summary>
        /// Traffic specifies how to distribute traffic over a collection of Knative Revisions and Configurations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traffic")]
        public virtual System.Collections.Generic.IList<TrafficTarget> Traffic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The current state of the Service. Output only.</summary>
    public class ServiceStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>From RouteStatus. Similar to url, information on where the service is available on HTTP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual Addressable Address { get; set; }

        /// <summary>
        /// Conditions communicates information about ongoing/complete reconciliation processes that bring the "spec"
        /// inline with the observed state of the world. Service-specific conditions include: * "ConfigurationsReady":
        /// true when the underlying Configuration is ready. * "RoutesReady": true when the underlying Route is ready. *
        /// "Ready": true when both the underlying Route and Configuration are ready.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV1Condition> Conditions { get; set; }

        /// <summary>
        /// From ConfigurationStatus. LatestCreatedRevisionName is the last revision that was created from this
        /// Service's Configuration. It might not be ready yet, for that use LatestReadyRevisionName.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestCreatedRevisionName")]
        public virtual string LatestCreatedRevisionName { get; set; }

        /// <summary>
        /// From ConfigurationStatus. LatestReadyRevisionName holds the name of the latest Revision stamped out from
        /// this Service's Configuration that has had its "Ready" condition become "True".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestReadyRevisionName")]
        public virtual string LatestReadyRevisionName { get; set; }

        /// <summary>
        /// ObservedGeneration is the 'Generation' of the Route that was last processed by the controller. Clients
        /// polling for completed reconciliation should poll until observedGeneration = metadata.generation and the
        /// Ready condition's status is True or False.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observedGeneration")]
        public virtual System.Nullable<int> ObservedGeneration { get; set; }

        /// <summary>
        /// From RouteStatus. Traffic holds the configured traffic distribution. These entries will always contain
        /// RevisionName references. When ConfigurationName appears in the spec, this will hold the
        /// LatestReadyRevisionName that we last observed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traffic")]
        public virtual System.Collections.Generic.IList<TrafficTarget> Traffic { get; set; }

        /// <summary>
        /// From RouteStatus. URL holds the url that will distribute traffic over the provided traffic targets. It
        /// generally has the form https://{route-hash}-{project-hash}-{cluster-level-suffix}.a.run.app
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
        /// 10s of KB. An empty policy is a valid policy but certain Cloud Platform services (such as Projects) might
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

    /// <summary>Status is a return value for calls that don't return other objects</summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Suggested HTTP return code for this status, 0 if not set. +optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// Extended data associated with the reason. Each reason may define its own extended details. This field is
        /// optional and the data returned is not guaranteed to conform to any schema except that defined by the reason
        /// type. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual StatusDetails Details { get; set; }

        /// <summary>A human-readable description of the status of this operation. +optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>
        /// Standard list metadata. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ListMeta Metadata { get; set; }

        /// <summary>
        /// A machine-readable description of why this operation is in the "Failure" status. If this value is empty
        /// there is no information available. A Reason clarifies an HTTP status code but does not override it.
        /// +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>
        /// Status of the operation. One of: "Success" or "Failure". More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        /// +optional
        /// </summary>
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
        /// array of causes due to fields having multiple errors. Optional. Examples: "name" - the field "name" on the
        /// current resource "items[0].name" - the field "name" on the first array entry in "items" +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        /// <summary>
        /// A human-readable description of the cause of the error. This field may be presented as-is to a reader.
        /// +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>
        /// A machine-readable description of the cause of the error. If this value is empty there is no information
        /// available. +optional
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
        /// provide detailed causes. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("causes")]
        public virtual System.Collections.Generic.IList<StatusCause> Causes { get; set; }

        /// <summary>The group attribute of the resource associated with the status StatusReason. +optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual string Group { get; set; }

        /// <summary>
        /// The kind attribute of the resource associated with the status StatusReason. On some operations may differ
        /// from the requested resource Kind. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The name attribute of the resource associated with the status StatusReason (when there is a single name
        /// which can be described). +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// If specified, the time in seconds before the operation should be retried. Some errors may indicate the
        /// client must take an alternate action - for those errors this field may indicate how long to wait before
        /// taking the alternate action. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retryAfterSeconds")]
        public virtual System.Nullable<int> RetryAfterSeconds { get; set; }

        /// <summary>
        /// UID of the resource. (when there is a single resource which can be described). More info:
        /// http://kubernetes.io/docs/user-guide/identifiers#uids +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Not supported by Cloud Run TCPSocketAction describes an action based on opening a socket</summary>
    public class TCPSocketAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>(Optional) Optional: Host name to connect to, defaults to the pod IP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>
        /// Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be
        /// an IANA_SVC_NAME. This field is currently limited to integer types only because of proto's inability to
        /// properly support the IntOrString golang type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
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
        /// <summary>
        /// ConfigurationName of a configuration to whose latest revision we will send this portion of traffic. When the
        /// "status.latestReadyRevisionName" of the referenced configuration changes, we will automatically migrate
        /// traffic from the prior "latest ready" revision to the new one. This field is never set in Route's status,
        /// only its spec. This is mutually exclusive with RevisionName. Cloud Run currently supports a single
        /// ConfigurationName.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configurationName")]
        public virtual string ConfigurationName { get; set; }

        /// <summary>
        /// LatestRevision may be optionally provided to indicate that the latest ready Revision of the Configuration
        /// should be used for this traffic target. When provided LatestRevision must be true if RevisionName is empty;
        /// it must be false when RevisionName is non-empty. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestRevision")]
        public virtual System.Nullable<bool> LatestRevision { get; set; }

        /// <summary>
        /// Percent specifies percent of the traffic to this Revision or Configuration. This defaults to zero if
        /// unspecified. Cloud Run currently requires 100 percent for a single ConfigurationName TrafficTarget entry.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percent")]
        public virtual System.Nullable<int> Percent { get; set; }

        /// <summary>
        /// RevisionName of a specific revision to which to send this portion of traffic. This is mutually exclusive
        /// with ConfigurationName. Providing RevisionName in spec is not currently supported by Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionName")]
        public virtual string RevisionName { get; set; }

        /// <summary>
        /// Tag is optionally used to expose a dedicated url for referencing this target exclusively. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>
        /// Output only. URL displays the URL for accessing tagged traffic targets. URL is displayed in status, and is
        /// disallowed on spec. URL must contain a scheme (e.g. http://) and a hostname, but may not contain anything
        /// else (e.g. basic auth, url path, etc.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Not supported by Cloud Run Volume represents a named volume in a container.</summary>
    public class Volume : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("configMap")]
        public virtual ConfigMapVolumeSource ConfigMap { get; set; }

        /// <summary>Volume's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("secret")]
        public virtual SecretVolumeSource Secret { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Not supported by Cloud Run VolumeMount describes a mounting of a Volume within a container.</summary>
    public class VolumeMount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Path within the container at which the volume should be mounted. Must not contain ':'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mountPath")]
        public virtual string MountPath { get; set; }

        /// <summary>This must match the Name of a Volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>(Optional) Only true is accepted. Defaults to true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readOnly")]
        public virtual System.Nullable<bool> ReadOnly__ { get; set; }

        /// <summary>
        /// (Optional) Path within the volume from which the container's volume should be mounted. Defaults to ""
        /// (volume's root).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subPath")]
        public virtual string SubPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
