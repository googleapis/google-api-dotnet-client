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

namespace Google.Apis.Config.v1
{
    /// <summary>The Config Service.</summary>
    public class ConfigService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ConfigService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ConfigService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://config.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://config.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "config";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Infrastructure Manager API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Infrastructure Manager API.</summary>
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

    /// <summary>A base abstract class for Config requests.</summary>
    public abstract class ConfigBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ConfigBaseServiceRequest instance.</summary>
        protected ConfigBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Config parameter list.</summary>
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
                Deployments = new DeploymentsResource(service);
                Operations = new OperationsResource(service);
                Previews = new PreviewsResource(service);
                TerraformVersions = new TerraformVersionsResource(service);
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
                    Revisions = new RevisionsResource(service);
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
                        Resources = new ResourcesResource(service);
                    }

                    /// <summary>Gets the Resources resource.</summary>
                    public virtual ResourcesResource Resources { get; }

                    /// <summary>The "resources" collection of methods.</summary>
                    public class ResourcesResource
                    {
                        private const string Resource = "resources";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public ResourcesResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Gets details about a Resource deployed by Infra Manager.</summary>
                        /// <param name="name">
                        /// Required. The name of the Resource in the format:
                        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}/revisions/{revision}/resource/{resource}'.
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>Gets details about a Resource deployed by Infra Manager.</summary>
                        public class GetRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.Resource>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the Resource in the format:
                            /// 'projects/{project_id}/locations/{location}/deployments/{deployment}/revisions/{revision}/resource/{resource}'.
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/deployments/[^/]+/revisions/[^/]+/resources/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Lists Resources in a given revision.</summary>
                        /// <param name="parent">
                        /// Required. The parent in whose context the Resources are listed. The parent value is in the
                        /// format:
                        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}/revisions/{revision}'.
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>Lists Resources in a given revision.</summary>
                        public class ListRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.ListResourcesResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent in whose context the Resources are listed. The parent value is in
                            /// the format:
                            /// 'projects/{project_id}/locations/{location}/deployments/{deployment}/revisions/{revision}'.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Lists the Resources that match the filter expression. A filter expression filters the
                            /// resources listed in the response. The expression must be of the form '{field} {operator}
                            /// {value}' where operators: '&amp;lt;', '&amp;gt;', '&amp;lt;=', '&amp;gt;=', '!=', '=',
                            /// ':' are supported (colon ':' represents a HAS operator which is roughly synonymous with
                            /// equality). {field} can refer to a proto or JSON field, or a synthetic field. Field names
                            /// can be camelCase or snake_case. Examples: - Filter by name: name =
                            /// "projects/foo/locations/us-central1/deployments/dep/revisions/bar/resources/baz
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>Field to use to sort the list.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string OrderBy { get; set; }

                            /// <summary>
                            /// When requesting a page of resources, 'page_size' specifies number of resources to
                            /// return. If unspecified, at most 500 will be returned. The maximum value is 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Token returned by previous call to 'ListResources' which specifies the position in the
                            /// list from where to continue listing the resources.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/resources";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/deployments/[^/]+/revisions/[^/]+$",
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
                    }

                    /// <summary>Exports Terraform state file from a given revision.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent in whose context the statefile is listed. The parent value is in the
                    /// format:
                    /// 'projects/{project_id}/locations/{location}/deployments/{deployment}/revisions/{revision}'.
                    /// </param>
                    public virtual ExportStateRequest ExportState(Google.Apis.Config.v1.Data.ExportRevisionStatefileRequest body, string parent)
                    {
                        return new ExportStateRequest(this.service, body, parent);
                    }

                    /// <summary>Exports Terraform state file from a given revision.</summary>
                    public class ExportStateRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.Statefile>
                    {
                        /// <summary>Constructs a new ExportState request.</summary>
                        public ExportStateRequest(Google.Apis.Services.IClientService service, Google.Apis.Config.v1.Data.ExportRevisionStatefileRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent in whose context the statefile is listed. The parent value is in the
                        /// format:
                        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}/revisions/{revision}'.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Config.v1.Data.ExportRevisionStatefileRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "exportState";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}:exportState";

                        /// <summary>Initializes ExportState parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/deployments/[^/]+/revisions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets details about a Revision.</summary>
                    /// <param name="name">
                    /// Required. The name of the Revision in the format:
                    /// 'projects/{project_id}/locations/{location}/deployments/{deployment}/revisions/{revision}'.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details about a Revision.</summary>
                    public class GetRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.Revision>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the Revision in the format:
                        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}/revisions/{revision}'.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/deployments/[^/]+/revisions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists Revisions of a deployment.</summary>
                    /// <param name="parent">
                    /// Required. The parent in whose context the Revisions are listed. The parent value is in the
                    /// format: 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists Revisions of a deployment.</summary>
                    public class ListRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.ListRevisionsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent in whose context the Revisions are listed. The parent value is in the
                        /// format: 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Lists the Revisions that match the filter expression. A filter expression filters the
                        /// resources listed in the response. The expression must be of the form '{field} {operator}
                        /// {value}' where operators: '&amp;lt;', '&amp;gt;', '&amp;lt;=', '&amp;gt;=', '!=', '=', ':'
                        /// are supported (colon ':' represents a HAS operator which is roughly synonymous with
                        /// equality). {field} can refer to a proto or JSON field, or a synthetic field. Field names can
                        /// be camelCase or snake_case. Examples: - Filter by name: name =
                        /// "projects/foo/locations/us-central1/deployments/dep/revisions/bar - Filter by labels: -
                        /// Resources that have a key called 'foo' labels.foo:* - Resources that have a key called 'foo'
                        /// whose value is 'bar' labels.foo = bar - Filter by state: - Revisions in CREATING state.
                        /// state=CREATING
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Field to use to sort the list.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// When requesting a page of resources, `page_size` specifies number of resources to return. If
                        /// unspecified, at most 500 will be returned. The maximum value is 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Token returned by previous call to 'ListRevisions' which specifies the position in the list
                        /// from where to continue listing the resources.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/deployments/[^/]+$",
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
                }

                /// <summary>Creates a Deployment.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent in whose context the Deployment is created. The parent value is in the format:
                /// 'projects/{project_id}/locations/{location}'.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Config.v1.Data.Deployment body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a Deployment.</summary>
                public class CreateRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Config.v1.Data.Deployment body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent in whose context the Deployment is created. The parent value is in the
                    /// format: 'projects/{project_id}/locations/{location}'.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. The Deployment ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("deploymentId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string DeploymentId { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes since the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Config.v1.Data.Deployment Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("deploymentId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "deploymentId",
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

                /// <summary>Deletes a Deployment.</summary>
                /// <param name="name">
                /// Required. The name of the Deployment in the format:
                /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a Deployment.</summary>
                public class DeleteRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Deployment in the format:
                    /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Policy on how resources actuated by the deployment should be deleted. If unspecified,
                    /// the default behavior is to delete the underlying resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("deletePolicy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<DeletePolicyEnum> DeletePolicy { get; set; }

                    /// <summary>
                    /// Optional. Policy on how resources actuated by the deployment should be deleted. If unspecified,
                    /// the default behavior is to delete the underlying resources.
                    /// </summary>
                    public enum DeletePolicyEnum
                    {
                        /// <summary>Unspecified policy, resources will be deleted.</summary>
                        [Google.Apis.Util.StringValueAttribute("DELETE_POLICY_UNSPECIFIED")]
                        DELETEPOLICYUNSPECIFIED = 0,

                        /// <summary>Deletes resources actuated by the deployment.</summary>
                        [Google.Apis.Util.StringValueAttribute("DELETE")]
                        DELETE = 1,

                        /// <summary>Abandons resources and only deletes the deployment and its metadata.</summary>
                        [Google.Apis.Util.StringValueAttribute("ABANDON")]
                        ABANDON = 2,
                    }

                    /// <summary>
                    /// Optional. If set to true, any revisions for this deployment will also be deleted. (Otherwise,
                    /// the request will only work if the deployment has no revisions.)
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes after the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deployments/[^/]+$",
                        });
                        RequestParameters.Add("deletePolicy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "deletePolicy",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                        {
                            Name = "force",
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

                /// <summary>Deletes Terraform state file in a given deployment.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the deployment in the format:
                /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
                /// </param>
                public virtual DeleteStateRequest DeleteState(Google.Apis.Config.v1.Data.DeleteStatefileRequest body, string name)
                {
                    return new DeleteStateRequest(this.service, body, name);
                }

                /// <summary>Deletes Terraform state file in a given deployment.</summary>
                public class DeleteStateRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.Empty>
                {
                    /// <summary>Constructs a new DeleteState request.</summary>
                    public DeleteStateRequest(Google.Apis.Services.IClientService service, Google.Apis.Config.v1.Data.DeleteStatefileRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the deployment in the format:
                    /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Config.v1.Data.DeleteStatefileRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "deleteState";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:deleteState";

                    /// <summary>Initializes DeleteState parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deployments/[^/]+$",
                        });
                    }
                }

                /// <summary>Exports the lock info on a locked deployment.</summary>
                /// <param name="name">
                /// Required. The name of the deployment in the format:
                /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
                /// </param>
                public virtual ExportLockRequest ExportLock(string name)
                {
                    return new ExportLockRequest(this.service, name);
                }

                /// <summary>Exports the lock info on a locked deployment.</summary>
                public class ExportLockRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.LockInfo>
                {
                    /// <summary>Constructs a new ExportLock request.</summary>
                    public ExportLockRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the deployment in the format:
                    /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "exportLock";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:exportLock";

                    /// <summary>Initializes ExportLock parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deployments/[^/]+$",
                        });
                    }
                }

                /// <summary>Exports Terraform state file from a given deployment.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent in whose context the statefile is listed. The parent value is in the format:
                /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
                /// </param>
                public virtual ExportStateRequest ExportState(Google.Apis.Config.v1.Data.ExportDeploymentStatefileRequest body, string parent)
                {
                    return new ExportStateRequest(this.service, body, parent);
                }

                /// <summary>Exports Terraform state file from a given deployment.</summary>
                public class ExportStateRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.Statefile>
                {
                    /// <summary>Constructs a new ExportState request.</summary>
                    public ExportStateRequest(Google.Apis.Services.IClientService service, Google.Apis.Config.v1.Data.ExportDeploymentStatefileRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent in whose context the statefile is listed. The parent value is in the
                    /// format: 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Config.v1.Data.ExportDeploymentStatefileRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "exportState";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}:exportState";

                    /// <summary>Initializes ExportState parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deployments/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details about a Deployment.</summary>
                /// <param name="name">
                /// Required. The name of the deployment. Format:
                /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details about a Deployment.</summary>
                public class GetRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.Deployment>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the deployment. Format:
                    /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deployments/[^/]+$",
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
                    return new GetIamPolicyRequest(this.service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.Policy>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deployments/[^/]+$",
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
                /// Imports Terraform state file in a given deployment. The state file does not take effect until the
                /// Deployment has been unlocked.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent in whose context the statefile is listed. The parent value is in the format:
                /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
                /// </param>
                public virtual ImportStateRequest ImportState(Google.Apis.Config.v1.Data.ImportStatefileRequest body, string parent)
                {
                    return new ImportStateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Imports Terraform state file in a given deployment. The state file does not take effect until the
                /// Deployment has been unlocked.
                /// </summary>
                public class ImportStateRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.Statefile>
                {
                    /// <summary>Constructs a new ImportState request.</summary>
                    public ImportStateRequest(Google.Apis.Services.IClientService service, Google.Apis.Config.v1.Data.ImportStatefileRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent in whose context the statefile is listed. The parent value is in the
                    /// format: 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Config.v1.Data.ImportStatefileRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "importState";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}:importState";

                    /// <summary>Initializes ImportState parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deployments/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists Deployments in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent in whose context the Deployments are listed. The parent value is in the format:
                /// 'projects/{project_id}/locations/{location}'.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists Deployments in a given project and location.</summary>
                public class ListRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.ListDeploymentsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent in whose context the Deployments are listed. The parent value is in the
                    /// format: 'projects/{project_id}/locations/{location}'.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Lists the Deployments that match the filter expression. A filter expression filters the
                    /// resources listed in the response. The expression must be of the form '{field} {operator}
                    /// {value}' where operators: '&amp;lt;', '&amp;gt;', '&amp;lt;=', '&amp;gt;=', '!=', '=', ':' are
                    /// supported (colon ':' represents a HAS operator which is roughly synonymous with equality).
                    /// {field} can refer to a proto or JSON field, or a synthetic field. Field names can be camelCase
                    /// or snake_case. Examples: - Filter by name: name =
                    /// "projects/foo/locations/us-central1/deployments/bar - Filter by labels: - Resources that have a
                    /// key called 'foo' labels.foo:* - Resources that have a key called 'foo' whose value is 'bar'
                    /// labels.foo = bar - Filter by state: - Deployments in CREATING state. state=CREATING
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Field to use to sort the list.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// When requesting a page of resources, 'page_size' specifies number of resources to return. If
                    /// unspecified, at most 500 will be returned. The maximum value is 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Token returned by previous call to 'ListDeployments' which specifies the position in the list
                    /// from where to continue listing the resources.
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

                /// <summary>Locks a deployment.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the deployment in the format:
                /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
                /// </param>
                public virtual ConfigLockRequest ConfigLock(Google.Apis.Config.v1.Data.LockDeploymentRequest body, string name)
                {
                    return new ConfigLockRequest(this.service, body, name);
                }

                /// <summary>Locks a deployment.</summary>
                public class ConfigLockRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.Operation>
                {
                    /// <summary>Constructs a new ConfigLock request.</summary>
                    public ConfigLockRequest(Google.Apis.Services.IClientService service, Google.Apis.Config.v1.Data.LockDeploymentRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the deployment in the format:
                    /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Config.v1.Data.LockDeploymentRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "lock";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:lock";

                    /// <summary>Initializes ConfigLock parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deployments/[^/]+$",
                        });
                    }
                }

                /// <summary>Updates a Deployment.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Resource name of the deployment. Format:
                /// `projects/{project}/locations/{location}/deployments/{deployment}`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Config.v1.Data.Deployment body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates a Deployment.</summary>
                public class PatchRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Config.v1.Data.Deployment body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Resource name of the deployment. Format:
                    /// `projects/{project}/locations/{location}/deployments/{deployment}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes since the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Optional. Field mask used to specify the fields to be overwritten in the Deployment resource by
                    /// the update. The fields specified in the update_mask are relative to the resource, not the full
                    /// request. A field will be overwritten if it is in the mask. If the user does not provide a mask
                    /// then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Config.v1.Data.Deployment Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deployments/[^/]+$",
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
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Config.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Config.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.Config.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deployments/[^/]+$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Config.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Config.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.Config.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deployments/[^/]+$",
                        });
                    }
                }

                /// <summary>Unlocks a locked deployment.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the deployment in the format:
                /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
                /// </param>
                public virtual UnlockRequest Unlock(Google.Apis.Config.v1.Data.UnlockDeploymentRequest body, string name)
                {
                    return new UnlockRequest(this.service, body, name);
                }

                /// <summary>Unlocks a locked deployment.</summary>
                public class UnlockRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Unlock request.</summary>
                    public UnlockRequest(Google.Apis.Services.IClientService service, Google.Apis.Config.v1.Data.UnlockDeploymentRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the deployment in the format:
                    /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Config.v1.Data.UnlockDeploymentRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "unlock";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:unlock";

                    /// <summary>Initializes Unlock parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deployments/[^/]+$",
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
                public virtual CancelRequest Cancel(Google.Apis.Config.v1.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.Config.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Config.v1.Data.CancelOperationRequest Body { get; set; }

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
                public class DeleteRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.Empty>
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
                public class GetRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.Operation>
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
                public class ListRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.ListOperationsResponse>
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

            /// <summary>Gets the Previews resource.</summary>
            public virtual PreviewsResource Previews { get; }

            /// <summary>The "previews" collection of methods.</summary>
            public class PreviewsResource
            {
                private const string Resource = "previews";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public PreviewsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a Preview.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent in whose context the Preview is created. The parent value is in the format:
                /// 'projects/{project_id}/locations/{location}'.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Config.v1.Data.Preview body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a Preview.</summary>
                public class CreateRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Config.v1.Data.Preview body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent in whose context the Preview is created. The parent value is in the format:
                    /// 'projects/{project_id}/locations/{location}'.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. The preview ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("previewId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PreviewId { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes since the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Config.v1.Data.Preview Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/previews";

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
                        RequestParameters.Add("previewId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "previewId",
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

                /// <summary>Deletes a Preview.</summary>
                /// <param name="name">
                /// Required. The name of the Preview in the format:
                /// 'projects/{project_id}/locations/{location}/previews/{preview}'.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a Preview.</summary>
                public class DeleteRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Preview in the format:
                    /// 'projects/{project_id}/locations/{location}/previews/{preview}'.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes after the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/previews/[^/]+$",
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

                /// <summary>Export Preview results.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The preview whose results should be exported. The preview value is in the format:
                /// 'projects/{project_id}/locations/{location}/previews/{preview}'.
                /// </param>
                public virtual ExportRequest Export(Google.Apis.Config.v1.Data.ExportPreviewResultRequest body, string parent)
                {
                    return new ExportRequest(this.service, body, parent);
                }

                /// <summary>Export Preview results.</summary>
                public class ExportRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.ExportPreviewResultResponse>
                {
                    /// <summary>Constructs a new Export request.</summary>
                    public ExportRequest(Google.Apis.Services.IClientService service, Google.Apis.Config.v1.Data.ExportPreviewResultRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The preview whose results should be exported. The preview value is in the format:
                    /// 'projects/{project_id}/locations/{location}/previews/{preview}'.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Config.v1.Data.ExportPreviewResultRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "export";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}:export";

                    /// <summary>Initializes Export parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/previews/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details about a Preview.</summary>
                /// <param name="name">
                /// Required. The name of the preview. Format:
                /// 'projects/{project_id}/locations/{location}/previews/{preview}'.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details about a Preview.</summary>
                public class GetRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.Preview>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the preview. Format:
                    /// 'projects/{project_id}/locations/{location}/previews/{preview}'.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/previews/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists Previews in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent in whose context the Previews are listed. The parent value is in the format:
                /// 'projects/{project_id}/locations/{location}'.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists Previews in a given project and location.</summary>
                public class ListRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.ListPreviewsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent in whose context the Previews are listed. The parent value is in the
                    /// format: 'projects/{project_id}/locations/{location}'.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Lists the Deployments that match the filter expression. A filter expression filters
                    /// the resources listed in the response. The expression must be of the form '{field} {operator}
                    /// {value}' where operators: '&amp;lt;', '&amp;gt;', '&amp;lt;=', '&amp;gt;=', '!=', '=', ':' are
                    /// supported (colon ':' represents a HAS operator which is roughly synonymous with equality).
                    /// {field} can refer to a proto or JSON field, or a synthetic field. Field names can be camelCase
                    /// or snake_case. Examples: - Filter by name: name =
                    /// "projects/foo/locations/us-central1/deployments/bar - Filter by labels: - Resources that have a
                    /// key called 'foo' labels.foo:* - Resources that have a key called 'foo' whose value is 'bar'
                    /// labels.foo = bar - Filter by state: - Deployments in CREATING state. state=CREATING
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Field to use to sort the list.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. When requesting a page of resources, 'page_size' specifies number of resources to
                    /// return. If unspecified, at most 500 will be returned. The maximum value is 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. Token returned by previous call to 'ListDeployments' which specifies the position in
                    /// the list from where to continue listing the resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/previews";

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
            }

            /// <summary>Gets the TerraformVersions resource.</summary>
            public virtual TerraformVersionsResource TerraformVersions { get; }

            /// <summary>The "terraformVersions" collection of methods.</summary>
            public class TerraformVersionsResource
            {
                private const string Resource = "terraformVersions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public TerraformVersionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets details about a TerraformVersion.</summary>
                /// <param name="name">
                /// Required. The name of the TerraformVersion. Format:
                /// 'projects/{project_id}/locations/{location}/terraformVersions/{terraform_version}'
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details about a TerraformVersion.</summary>
                public class GetRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.TerraformVersion>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the TerraformVersion. Format:
                    /// 'projects/{project_id}/locations/{location}/terraformVersions/{terraform_version}'
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/terraformVersions/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists TerraformVersions in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent in whose context the TerraformVersions are listed. The parent value is in the
                /// format: 'projects/{project_id}/locations/{location}'.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists TerraformVersions in a given project and location.</summary>
                public class ListRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.ListTerraformVersionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent in whose context the TerraformVersions are listed. The parent value is in
                    /// the format: 'projects/{project_id}/locations/{location}'.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Lists the TerraformVersions that match the filter expression. A filter expression
                    /// filters the resources listed in the response. The expression must be of the form '{field}
                    /// {operator} {value}' where operators: '&amp;lt;', '&amp;gt;', '&amp;lt;=', '&amp;gt;=', '!=',
                    /// '=', ':' are supported (colon ':' represents a HAS operator which is roughly synonymous with
                    /// equality). {field} can refer to a proto or JSON field, or a synthetic field. Field names can be
                    /// camelCase or snake_case.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Field to use to sort the list.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. When requesting a page of terraform versions, 'page_size' specifies number of
                    /// terraform versions to return. If unspecified, at most 500 will be returned. The maximum value is
                    /// 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. Token returned by previous call to 'ListTerraformVersions' which specifies the
                    /// position in the list from where to continue listing the terraform versions.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/terraformVersions";

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
            }

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.Location>
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
                return new ListRequest(this.service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : ConfigBaseServiceRequest<Google.Apis.Config.v1.Data.ListLocationsResponse>
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
namespace Google.Apis.Config.v1.Data
{
    /// <summary>Outputs and artifacts from applying a deployment.</summary>
    public class ApplyResults : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Location of artifacts (e.g. logs) in Google Cloud Storage. Format: `gs://{bucket}/{object}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifacts")]
        public virtual string Artifacts { get; set; }

        /// <summary>
        /// Location of a blueprint copy and other manifests in Google Cloud Storage. Format: `gs://{bucket}/{object}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>Map of output name to output info.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputs")]
        public virtual System.Collections.Generic.IDictionary<string, TerraformOutput> Outputs { get; set; }

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

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to delete a state file passed to a 'DeleteStatefile' call.</summary>
    public class DeleteStatefileRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Lock ID of the lock file to verify that the user who is deleting the state file previously locked
        /// the Deployment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lockId")]
        public virtual System.Nullable<long> LockId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Deployment is a group of resources and configs managed and provisioned by Infra Manager.</summary>
    public class Deployment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Arbitrary key-value metadata storage e.g. to help client tools identify deployments during
        /// automation. See https://google.aip.dev/148#annotations for details on format and size limitations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// Optional. User-defined location of Cloud Build logs and artifacts in Google Cloud Storage. Format:
        /// `gs://{bucket}/{folder}` A default bucket will be bootstrapped if the field is not set or empty. Default
        /// bucket format: `gs://--blueprint-config` Constraints: - The bucket needs to be in the same project as the
        /// deployment - The path cannot be within the path of `gcs_source` - The field cannot be updated, including
        /// changing its presence
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactsGcsBucket")]
        public virtual string ArtifactsGcsBucket { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time when the deployment was created.</summary>
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

        /// <summary>Output only. Cloud Build instance UUID associated with deleting this deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteBuild")]
        public virtual string DeleteBuild { get; set; }

        /// <summary>
        /// Output only. Location of Cloud Build logs in Google Cloud Storage, populated when deleting this deployment.
        /// Format: `gs://{bucket}/{object}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteLogs")]
        public virtual string DeleteLogs { get; set; }

        /// <summary>Output only. Location of artifacts from a DeleteDeployment operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteResults")]
        public virtual ApplyResults DeleteResults { get; set; }

        /// <summary>Output only. Error code describing errors that may have occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCode")]
        public virtual string ErrorCode { get; set; }

        /// <summary>
        /// Output only. Location of Terraform error logs in Google Cloud Storage. Format: `gs://{bucket}/{object}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorLogs")]
        public virtual string ErrorLogs { get; set; }

        /// <summary>
        /// By default, Infra Manager will return a failure when Terraform encounters a 409 code (resource conflict
        /// error) during actuation. If this flag is set to true, Infra Manager will instead attempt to automatically
        /// import the resource into the Terraform state (for supported resource types) and continue actuation. Not all
        /// resource types are supported, refer to documentation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importExistingResources")]
        public virtual System.Nullable<bool> ImportExistingResources { get; set; }

        /// <summary>User-defined metadata for the deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. Revision name that was most recently applied. Format:
        /// `projects/{project}/locations/{location}/deployments/{deployment}/ revisions/{revision}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestRevision")]
        public virtual string LatestRevision { get; set; }

        /// <summary>Output only. Current lock state of the deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lockState")]
        public virtual string LockState { get; set; }

        /// <summary>
        /// Resource name of the deployment. Format: `projects/{project}/locations/{location}/deployments/{deployment}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Input to control quota checks for resources in terraform configuration files. There are limited
        /// resources on which quota validation applies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaValidation")]
        public virtual string QuotaValidation { get; set; }

        /// <summary>
        /// Required. User-specified Service Account (SA) credentials to be used when actuating resources. Format:
        /// `projects/{projectID}/serviceAccounts/{serviceAccount}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Output only. Current state of the deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Additional information regarding the current state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateDetail")]
        public virtual string StateDetail { get; set; }

        /// <summary>
        /// A blueprint described using Terraform's HashiCorp Configuration Language as a root module.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terraformBlueprint")]
        public virtual TerraformBlueprint TerraformBlueprint { get; set; }

        /// <summary>
        /// Output only. Errors encountered when deleting this deployment. Errors are truncated to 10 entries, see
        /// `delete_results` and `error_logs` for full details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tfErrors")]
        public virtual System.Collections.Generic.IList<TerraformError> TfErrors { get; set; }

        /// <summary>
        /// Output only. The current Terraform version set on the deployment. It is in the format of
        /// "Major.Minor.Patch", for example, "1.3.10".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tfVersion")]
        public virtual string TfVersion { get; set; }

        /// <summary>Optional. The user-specified Terraform version constraint. Example: "=1.3.10".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tfVersionConstraint")]
        public virtual string TfVersionConstraint { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Time when the deployment was last modified.</summary>
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

        /// <summary>
        /// Optional. The user-specified Cloud Build worker pool resource in which the Cloud Build job will execute.
        /// Format: `projects/{project}/locations/{location}/workerPools/{workerPoolId}`. If this field is unspecified,
        /// the default Cloud Build worker pool will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerPool")]
        public virtual string WorkerPool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Ephemeral metadata content describing the state of a deployment operation.</summary>
    public class DeploymentOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Outputs and artifacts from applying a deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applyResults")]
        public virtual ApplyResults ApplyResults { get; set; }

        /// <summary>Output only. Cloud Build instance UUID associated with this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("build")]
        public virtual string Build { get; set; }

        /// <summary>Output only. Location of Deployment operations logs in `gs://{bucket}/{object}` format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logs")]
        public virtual string Logs { get; set; }

        /// <summary>The current step the deployment operation is running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("step")]
        public virtual string Step { get; set; }

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

    /// <summary>A request to export a state file passed to a 'ExportDeploymentStatefile' call.</summary>
    public class ExportDeploymentStatefileRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If this flag is set to true, the exported deployment state file will be the draft state. This will
        /// enable the draft file to be validated before copying it over to the working state on unlock.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("draft")]
        public virtual System.Nullable<bool> Draft { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to export preview results.</summary>
    public class ExportPreviewResultRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response to `ExportPreviewResult` call. Contains preview results.</summary>
    public class ExportPreviewResultResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Signed URLs for accessing the plan files.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual PreviewResult Result { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to export a state file passed to a 'ExportRevisionStatefile' call.</summary>
    public class ExportRevisionStatefileRequest : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>A set of files in a Git repository.</summary>
    public class GitSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Subdirectory inside the repository. Example: 'staging/my-package'</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directory")]
        public virtual string Directory { get; set; }

        /// <summary>Optional. Git reference (e.g. branch or tag).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ref")]
        public virtual string Ref__ { get; set; }

        /// <summary>Optional. Repository URL. Example: 'https://github.com/kubernetes/examples.git'</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repo")]
        public virtual string Repo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to import a state file passed to a 'ImportStatefile' call.</summary>
    public class ImportStatefileRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Lock ID of the lock file to verify that the user who is importing the state file previously locked
        /// the Deployment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lockId")]
        public virtual System.Nullable<long> LockId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListDeploymentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of Deployments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployments")]
        public virtual System.Collections.Generic.IList<Deployment> Deployments { get; set; }

        /// <summary>
        /// Token to be supplied to the next ListDeployments request via `page_token` to obtain the next set of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

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

    /// <summary>A response to a `ListPreviews` call. Contains a list of Previews.</summary>
    public class ListPreviewsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to be supplied to the next ListPreviews request via `page_token` to obtain the next set of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of Previews.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previews")]
        public virtual System.Collections.Generic.IList<Preview> Previews { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response to a 'ListResources' call. Contains a list of Resources.</summary>
    public class ListResourcesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token to request the next page of resources from the 'ListResources' method. The value of an empty string
        /// means that there are no more resources to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of Resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<Resource> Resources { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response to a 'ListRevisions' call. Contains a list of Revisions.</summary>
    public class ListRevisionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token to request the next page of resources from the 'ListRevisions' method. The value of an empty string
        /// means that there are no more resources to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of Revisions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisions")]
        public virtual System.Collections.Generic.IList<Revision> Revisions { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for the `ListTerraformVersions` method.</summary>
    public class ListTerraformVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to be supplied to the next ListTerraformVersions request via `page_token` to obtain the next set of
        /// results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of TerraformVersions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terraformVersions")]
        public virtual System.Collections.Generic.IList<TerraformVersion> TerraformVersions { get; set; }

        /// <summary>Unreachable resources, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

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

    /// <summary>A request to lock a deployment passed to a 'LockDeployment' call.</summary>
    public class LockDeploymentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about the lock which locked the deployment.</summary>
    public class LockInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Time that the lock was taken.</summary>
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

        /// <summary>Extra information to store with the lock, provided by the caller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("info")]
        public virtual string Info { get; set; }

        /// <summary>Unique ID for the lock to be overridden with generation ID in the backend.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lockId")]
        public virtual System.Nullable<long> LockId { get; set; }

        /// <summary>Terraform operation, provided by the caller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        /// <summary>Terraform version</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>user@hostname when available</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("who")]
        public virtual string Who { get; set; }

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

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time when the operation was created.</summary>
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

        /// <summary>Output only. Metadata about the deployment operation state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentMetadata")]
        public virtual DeploymentOperationMetadata DeploymentMetadata { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. Time when the operation finished running.</summary>
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

        /// <summary>Output only. Metadata about the preview operation state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previewMetadata")]
        public virtual PreviewOperationMetadata PreviewMetadata { get; set; }

        /// <summary>
        /// Output only. Identifies whether the user has requested cancellation of the operation. Operations that have
        /// successfully been cancelled have google.longrunning.Operation.error value with a google.rpc.Status.code of
        /// `1`, corresponding to `Code.CANCELLED`.
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
    /// A preview represents a set of actions Infra Manager would perform to move the resources towards the desired
    /// state as specified in the configuration.
    /// </summary>
    public class Preview : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Arbitrary key-value metadata storage e.g. to help client tools identify preview during automation.
        /// See https://google.aip.dev/148#annotations for details on format and size limitations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// Optional. User-defined location of Cloud Build logs, artifacts, and in Google Cloud Storage. Format:
        /// `gs://{bucket}/{folder}` A default bucket will be bootstrapped if the field is not set or empty Default
        /// Bucket Format: `gs://--blueprint-config` Constraints: - The bucket needs to be in the same project as the
        /// deployment - The path cannot be within the path of `gcs_source` If omitted and deployment resource ref
        /// provided has artifacts_gcs_bucket defined, that artifact bucket is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactsGcsBucket")]
        public virtual string ArtifactsGcsBucket { get; set; }

        /// <summary>Output only. Cloud Build instance UUID associated with this preview.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("build")]
        public virtual string Build { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time the preview was created.</summary>
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
        /// Optional. Optional deployment reference. If specified, the preview will be performed using the provided
        /// deployment's current state and use any relevant fields from the deployment unless explicitly specified in
        /// the preview create request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployment")]
        public virtual string Deployment { get; set; }

        /// <summary>Output only. Code describing any errors that may have occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCode")]
        public virtual string ErrorCode { get; set; }

        /// <summary>
        /// Output only. Link to tf-error.ndjson file, which contains the full list of the errors encountered during a
        /// Terraform preview. Format: `gs://{bucket}/{object}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorLogs")]
        public virtual string ErrorLogs { get; set; }

        /// <summary>Output only. Additional information regarding the current state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorStatus")]
        public virtual Status ErrorStatus { get; set; }

        /// <summary>Optional. User-defined labels for the preview.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. Location of preview logs in `gs://{bucket}/{object}` format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logs")]
        public virtual string Logs { get; set; }

        /// <summary>
        /// Identifier. Resource name of the preview. Resource name can be user provided or server generated ID if
        /// unspecified. Format: `projects/{project}/locations/{location}/previews/{preview}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Artifacts from preview.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previewArtifacts")]
        public virtual PreviewArtifacts PreviewArtifacts { get; set; }

        /// <summary>Optional. Current mode of preview.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previewMode")]
        public virtual string PreviewMode { get; set; }

        /// <summary>
        /// Required. User-specified Service Account (SA) credentials to be used when previewing resources. Format:
        /// `projects/{projectID}/serviceAccounts/{serviceAccount}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Output only. Current state of the preview.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The terraform blueprint to preview.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terraformBlueprint")]
        public virtual TerraformBlueprint TerraformBlueprint { get; set; }

        /// <summary>
        /// Output only. Summary of errors encountered during Terraform preview. It has a size limit of 10, i.e. only
        /// top 10 errors will be summarized here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tfErrors")]
        public virtual System.Collections.Generic.IList<TerraformError> TfErrors { get; set; }

        /// <summary>
        /// Output only. The current Terraform version set on the preview. It is in the format of "Major.Minor.Patch",
        /// for example, "1.3.10".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tfVersion")]
        public virtual string TfVersion { get; set; }

        /// <summary>Optional. The user-specified Terraform version constraint. Example: "=1.3.10".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tfVersionConstraint")]
        public virtual string TfVersionConstraint { get; set; }

        /// <summary>
        /// Optional. The user-specified Worker Pool resource in which the Cloud Build job will execute. Format
        /// projects/{project}/locations/{location}/workerPools/{workerPoolId} If this field is unspecified, the default
        /// Cloud Build worker pool will be used. If omitted and deployment resource ref provided has worker_pool
        /// defined, that worker pool is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerPool")]
        public virtual string WorkerPool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Artifacts created by preview.</summary>
    public class PreviewArtifacts : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Location of artifacts in Google Cloud Storage. Format: `gs://{bucket}/{object}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifacts")]
        public virtual string Artifacts { get; set; }

        /// <summary>
        /// Output only. Location of a blueprint copy and other content in Google Cloud Storage. Format:
        /// `gs://{bucket}/{object}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Ephemeral metadata content describing the state of a preview operation.</summary>
    public class PreviewOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Cloud Build instance UUID associated with this preview.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("build")]
        public virtual string Build { get; set; }

        /// <summary>Output only. Location of preview logs in `gs://{bucket}/{object}` format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logs")]
        public virtual string Logs { get; set; }

        /// <summary>Artifacts from preview.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previewArtifacts")]
        public virtual PreviewArtifacts PreviewArtifacts { get; set; }

        /// <summary>The current step the preview operation is running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("step")]
        public virtual string Step { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains a signed Cloud Storage URLs.</summary>
    public class PreviewResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Plan binary signed URL</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binarySignedUri")]
        public virtual string BinarySignedUri { get; set; }

        /// <summary>Output only. Plan JSON signed URL</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonSignedUri")]
        public virtual string JsonSignedUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Resource represents a Google Cloud Platform resource actuated by IM. Resources are child resources of Revisions.
    /// </summary>
    public class Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Map of Cloud Asset Inventory (CAI) type to CAI info (e.g. CAI ID). CAI type format follows
        /// https://cloud.google.com/asset-inventory/docs/supported-asset-types
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caiAssets")]
        public virtual System.Collections.Generic.IDictionary<string, ResourceCAIInfo> CaiAssets { get; set; }

        /// <summary>Output only. Intent of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intent")]
        public virtual string Intent { get; set; }

        /// <summary>
        /// Output only. Resource name. Format:
        /// `projects/{project}/locations/{location}/deployments/{deployment}/revisions/{revision}/resources/{resource}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Current state of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Terraform-specific info if this resource was created using Terraform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terraformInfo")]
        public virtual ResourceTerraformInfo TerraformInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CAI info of a Resource.</summary>
    public class ResourceCAIInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// CAI resource name in the format following
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Terraform info of a Resource.</summary>
    public class ResourceTerraformInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>TF resource address that uniquely identifies this resource within this deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; }

        /// <summary>ID attribute of the TF resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>TF resource type</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A child resource of a Deployment generated by a 'CreateDeployment' or 'UpdateDeployment' call. Each Revision
    /// contains metadata pertaining to a snapshot of a particular Deployment.
    /// </summary>
    public class Revision : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The action which created this revision</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>Output only. Outputs and artifacts from applying a deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applyResults")]
        public virtual ApplyResults ApplyResults { get; set; }

        /// <summary>Output only. Cloud Build instance UUID associated with this revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("build")]
        public virtual string Build { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time when the revision was created.</summary>
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

        /// <summary>Output only. Code describing any errors that may have occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCode")]
        public virtual string ErrorCode { get; set; }

        /// <summary>
        /// Output only. Location of Terraform error logs in Google Cloud Storage. Format: `gs://{bucket}/{object}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorLogs")]
        public virtual string ErrorLogs { get; set; }

        /// <summary>
        /// Output only. By default, Infra Manager will return a failure when Terraform encounters a 409 code (resource
        /// conflict error) during actuation. If this flag is set to true, Infra Manager will instead attempt to
        /// automatically import the resource into the Terraform state (for supported resource types) and continue
        /// actuation. Not all resource types are supported, refer to documentation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importExistingResources")]
        public virtual System.Nullable<bool> ImportExistingResources { get; set; }

        /// <summary>Output only. Location of Revision operation logs in `gs://{bucket}/{object}` format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logs")]
        public virtual string Logs { get; set; }

        /// <summary>
        /// Revision name. Format: `projects/{project}/locations/{location}/deployments/{deployment}/
        /// revisions/{revision}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Input to control quota checks for resources in terraform configuration files. There are limited
        /// resources on which quota validation applies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaValidation")]
        public virtual string QuotaValidation { get; set; }

        /// <summary>
        /// Output only. Cloud Storage path containing quota validation results. This field is set when a user sets
        /// Deployment.quota_validation field to ENABLED or ENFORCED. Format: `gs://{bucket}/{object}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaValidationResults")]
        public virtual string QuotaValidationResults { get; set; }

        /// <summary>
        /// Output only. User-specified Service Account (SA) to be used as credential to manage resources. Format:
        /// `projects/{projectID}/serviceAccounts/{serviceAccount}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Output only. Current state of the revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Additional info regarding the current state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateDetail")]
        public virtual string StateDetail { get; set; }

        /// <summary>
        /// Output only. A blueprint described using Terraform's HashiCorp Configuration Language as a root module.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terraformBlueprint")]
        public virtual TerraformBlueprint TerraformBlueprint { get; set; }

        /// <summary>
        /// Output only. Errors encountered when creating or updating this deployment. Errors are truncated to 10
        /// entries, see `delete_results` and `error_logs` for full details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tfErrors")]
        public virtual System.Collections.Generic.IList<TerraformError> TfErrors { get; set; }

        /// <summary>
        /// Output only. The version of Terraform used to create the Revision. It is in the format of
        /// "Major.Minor.Patch", for example, "1.3.10".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tfVersion")]
        public virtual string TfVersion { get; set; }

        /// <summary>Output only. The user-specified Terraform version constraint. Example: "=1.3.10".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tfVersionConstraint")]
        public virtual string TfVersionConstraint { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Time when the revision was last modified.</summary>
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

        /// <summary>
        /// Output only. The user-specified Cloud Build worker pool resource in which the Cloud Build job will execute.
        /// Format: `projects/{project}/locations/{location}/workerPools/{workerPoolId}`. If this field is unspecified,
        /// the default Cloud Build worker pool will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerPool")]
        public virtual string WorkerPool { get; set; }

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

    /// <summary>Contains info about a Terraform state file</summary>
    public class Statefile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Cloud Storage signed URI used for downloading or uploading the state file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signedUri")]
        public virtual string SignedUri { get; set; }

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
    /// TerraformBlueprint describes the source of a Terraform root module which describes the resources and configs to
    /// be deployed.
    /// </summary>
    public class TerraformBlueprint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// URI of an object in Google Cloud Storage. Format: `gs://{bucket}/{object}` URI may also specify an object
        /// version for zipped objects. Format: `gs://{bucket}/{object}#{version}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual string GcsSource { get; set; }

        /// <summary>URI of a public Git repo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitSource")]
        public virtual GitSource GitSource { get; set; }

        /// <summary>Optional. Input variable values for the Terraform blueprint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputValues")]
        public virtual System.Collections.Generic.IDictionary<string, TerraformVariable> InputValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Errors encountered during actuation using Terraform</summary>
    public class TerraformError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Original error response from underlying Google API, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>A human-readable error description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorDescription")]
        public virtual string ErrorDescription { get; set; }

        /// <summary>
        /// HTTP response code returned from Google Cloud Platform APIs when Terraform fails to provision the resource.
        /// If unset or 0, no HTTP response code was returned by Terraform.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpResponseCode")]
        public virtual System.Nullable<int> HttpResponseCode { get; set; }

        /// <summary>
        /// Address of the resource associated with the error, e.g. `google_compute_network.vpc_network`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceAddress")]
        public virtual string ResourceAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a Terraform output.</summary>
    public class TerraformOutput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies whether Terraform has set this output as a potential sensitive value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sensitive")]
        public virtual System.Nullable<bool> Sensitive { get; set; }

        /// <summary>Value of output.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual object Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Terraform input variable.</summary>
    public class TerraformVariable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Input variable value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputValue")]
        public virtual object InputValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A TerraformVersion represents the support state the corresponding Terraform version.</summary>
    public class TerraformVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _deprecateTimeRaw;

        private object _deprecateTime;

        /// <summary>Output only. When the version is deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deprecateTime")]
        public virtual string DeprecateTimeRaw
        {
            get => _deprecateTimeRaw;
            set
            {
                _deprecateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deprecateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeprecateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeprecateTimeDateTimeOffset instead.")]
        public virtual object DeprecateTime
        {
            get => _deprecateTime;
            set
            {
                _deprecateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deprecateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeprecateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeprecateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeprecateTimeRaw);
            set => DeprecateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Identifier. The version name is in the format:
        /// 'projects/{project_id}/locations/{location}/terraformVersions/{terraform_version}'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _obsoleteTimeRaw;

        private object _obsoleteTime;

        /// <summary>Output only. When the version is obsolete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("obsoleteTime")]
        public virtual string ObsoleteTimeRaw
        {
            get => _obsoleteTimeRaw;
            set
            {
                _obsoleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _obsoleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ObsoleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ObsoleteTimeDateTimeOffset instead.")]
        public virtual object ObsoleteTime
        {
            get => _obsoleteTime;
            set
            {
                _obsoleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _obsoleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ObsoleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ObsoleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ObsoleteTimeRaw);
            set => ObsoleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The state of the version, ACTIVE, DEPRECATED or OBSOLETE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _supportTimeRaw;

        private object _supportTime;

        /// <summary>Output only. When the version is supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportTime")]
        public virtual string SupportTimeRaw
        {
            get => _supportTimeRaw;
            set
            {
                _supportTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _supportTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="SupportTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use SupportTimeDateTimeOffset instead.")]
        public virtual object SupportTime
        {
            get => _supportTime;
            set
            {
                _supportTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _supportTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="SupportTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? SupportTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(SupportTimeRaw);
            set => SupportTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

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

    /// <summary>A request to unlock a state file passed to a 'UnlockDeployment' call.</summary>
    public class UnlockDeploymentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Lock ID of the lock file to be unlocked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lockId")]
        public virtual System.Nullable<long> LockId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
