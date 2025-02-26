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

namespace Google.Apis.MigrationCenterAPI.v1
{
    /// <summary>The MigrationCenterAPI Service.</summary>
    public class MigrationCenterAPIService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public MigrationCenterAPIService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public MigrationCenterAPIService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://migrationcenter.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://migrationcenter.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "migrationcenter";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Migration Center API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Migration Center API.</summary>
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

    /// <summary>A base abstract class for MigrationCenterAPI requests.</summary>
    public abstract class MigrationCenterAPIBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new MigrationCenterAPIBaseServiceRequest instance.</summary>
        protected MigrationCenterAPIBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes MigrationCenterAPI parameter list.</summary>
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
                Assets = new AssetsResource(service);
                DiscoveryClients = new DiscoveryClientsResource(service);
                Groups = new GroupsResource(service);
                ImportJobs = new ImportJobsResource(service);
                Operations = new OperationsResource(service);
                PreferenceSets = new PreferenceSetsResource(service);
                Relations = new RelationsResource(service);
                ReportConfigs = new ReportConfigsResource(service);
                Sources = new SourcesResource(service);
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
                }

                /// <summary>Aggregates the requested fields based on provided function.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Parent value for `AggregateAssetsValuesRequest`.</param>
                public virtual AggregateValuesRequest AggregateValues(Google.Apis.MigrationCenterAPI.v1.Data.AggregateAssetsValuesRequest body, string parent)
                {
                    return new AggregateValuesRequest(this.service, body, parent);
                }

                /// <summary>Aggregates the requested fields based on provided function.</summary>
                public class AggregateValuesRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.AggregateAssetsValuesResponse>
                {
                    /// <summary>Constructs a new AggregateValues request.</summary>
                    public AggregateValuesRequest(Google.Apis.Services.IClientService service, Google.Apis.MigrationCenterAPI.v1.Data.AggregateAssetsValuesRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value for `AggregateAssetsValuesRequest`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.MigrationCenterAPI.v1.Data.AggregateAssetsValuesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "aggregateValues";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/assets:aggregateValues";

                    /// <summary>Initializes AggregateValues parameter list.</summary>
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

                /// <summary>Deletes list of Assets.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Parent value for batch asset delete.</param>
                public virtual BatchDeleteRequest BatchDelete(Google.Apis.MigrationCenterAPI.v1.Data.BatchDeleteAssetsRequest body, string parent)
                {
                    return new BatchDeleteRequest(this.service, body, parent);
                }

                /// <summary>Deletes list of Assets.</summary>
                public class BatchDeleteRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Empty>
                {
                    /// <summary>Constructs a new BatchDelete request.</summary>
                    public BatchDeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.MigrationCenterAPI.v1.Data.BatchDeleteAssetsRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value for batch asset delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.MigrationCenterAPI.v1.Data.BatchDeleteAssetsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchDelete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/assets:batchDelete";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                    }
                }

                /// <summary>Updates the parameters of a list of assets.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Parent value for batch asset update.</param>
                public virtual BatchUpdateRequest BatchUpdate(Google.Apis.MigrationCenterAPI.v1.Data.BatchUpdateAssetsRequest body, string parent)
                {
                    return new BatchUpdateRequest(this.service, body, parent);
                }

                /// <summary>Updates the parameters of a list of assets.</summary>
                public class BatchUpdateRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.BatchUpdateAssetsResponse>
                {
                    /// <summary>Constructs a new BatchUpdate request.</summary>
                    public BatchUpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.MigrationCenterAPI.v1.Data.BatchUpdateAssetsRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value for batch asset update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.MigrationCenterAPI.v1.Data.BatchUpdateAssetsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchUpdate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/assets:batchUpdate";

                    /// <summary>Initializes BatchUpdate parameter list.</summary>
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

                /// <summary>Deletes an asset.</summary>
                /// <param name="name">Required. Name of the resource.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes an asset.</summary>
                public class DeleteRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/assets/[^/]+$",
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

                /// <summary>Gets the details of an asset.</summary>
                /// <param name="name">Required. Name of the resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets the details of an asset.</summary>
                public class GetRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Asset>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>View of the assets. Defaults to BASIC.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>View of the assets. Defaults to BASIC.</summary>
                    public enum ViewEnum
                    {
                        /// <summary>
                        /// The asset view is not specified. The API displays the basic view by default.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("ASSET_VIEW_UNSPECIFIED")]
                        ASSETVIEWUNSPECIFIED = 0,

                        /// <summary>The asset view includes only basic metadata of the asset.</summary>
                        [Google.Apis.Util.StringValueAttribute("ASSET_VIEW_BASIC")]
                        ASSETVIEWBASIC = 1,

                        /// <summary>
                        /// The asset view includes all the metadata of an asset and performance data.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("ASSET_VIEW_FULL")]
                        ASSETVIEWFULL = 2,
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/assets/[^/]+$",
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

                /// <summary>Lists all the assets in a given project and location.</summary>
                /// <param name="parent">Required. Parent value for `ListAssetsRequest`.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all the assets in a given project and location.</summary>
                public class ListRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.ListAssetsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value for `ListAssetsRequest`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Filtering results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Field to sort by. See https://google.aip.dev/132#ordering for more details.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Requested page size. Server may return fewer items than requested. If unspecified, server will
                    /// pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>View of the assets. Defaults to BASIC.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>View of the assets. Defaults to BASIC.</summary>
                    public enum ViewEnum
                    {
                        /// <summary>
                        /// The asset view is not specified. The API displays the basic view by default.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("ASSET_VIEW_UNSPECIFIED")]
                        ASSETVIEWUNSPECIFIED = 0,

                        /// <summary>The asset view includes only basic metadata of the asset.</summary>
                        [Google.Apis.Util.StringValueAttribute("ASSET_VIEW_BASIC")]
                        ASSETVIEWBASIC = 1,

                        /// <summary>
                        /// The asset view includes all the metadata of an asset and performance data.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("ASSET_VIEW_FULL")]
                        ASSETVIEWFULL = 2,
                    }

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

                /// <summary>Updates the parameters of an asset.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Output only. The full name of the asset.</param>
                public virtual PatchRequest Patch(Google.Apis.MigrationCenterAPI.v1.Data.Asset body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of an asset.</summary>
                public class PatchRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Asset>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.MigrationCenterAPI.v1.Data.Asset body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Output only. The full name of the asset.</summary>
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
                    /// Required. Field mask is used to specify the fields to be overwritten in the `Asset` resource by
                    /// the update. The values specified in the `update_mask` field are relative to the resource, not
                    /// the full request. A field will be overwritten if it is in the mask. A single * value in the mask
                    /// lets you to overwrite all fields.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.MigrationCenterAPI.v1.Data.Asset Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/assets/[^/]+$",
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

                /// <summary>Reports a set of frames.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Parent of the resource.</param>
                public virtual ReportAssetFramesRequest ReportAssetFrames(Google.Apis.MigrationCenterAPI.v1.Data.Frames body, string parent)
                {
                    return new ReportAssetFramesRequest(this.service, body, parent);
                }

                /// <summary>Reports a set of frames.</summary>
                public class ReportAssetFramesRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.ReportAssetFramesResponse>
                {
                    /// <summary>Constructs a new ReportAssetFrames request.</summary>
                    public ReportAssetFramesRequest(Google.Apis.Services.IClientService service, Google.Apis.MigrationCenterAPI.v1.Data.Frames body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Parent of the resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. Reference to a source.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Source { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.MigrationCenterAPI.v1.Data.Frames Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "reportAssetFrames";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/assets:reportAssetFrames";

                    /// <summary>Initializes ReportAssetFrames parameter list.</summary>
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
                        RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                        {
                            Name = "source",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the DiscoveryClients resource.</summary>
            public virtual DiscoveryClientsResource DiscoveryClients { get; }

            /// <summary>The "discoveryClients" collection of methods.</summary>
            public class DiscoveryClientsResource
            {
                private const string Resource = "discoveryClients";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DiscoveryClientsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new discovery client.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Parent resource.</param>
                public virtual CreateRequest Create(Google.Apis.MigrationCenterAPI.v1.Data.DiscoveryClient body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new discovery client.</summary>
                public class CreateRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.MigrationCenterAPI.v1.Data.DiscoveryClient body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Parent resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. User specified ID for the discovery client. It will become the last component of the
                    /// discovery client name. The ID must be unique within the project, is restricted to lower-cased
                    /// letters and has a maximum length of 63 characters. The ID must match the regular expression:
                    /// `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("discoveryClientId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string DiscoveryClientId { get; set; }

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
                    Google.Apis.MigrationCenterAPI.v1.Data.DiscoveryClient Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/discoveryClients";

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
                        RequestParameters.Add("discoveryClientId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "discoveryClientId",
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

                /// <summary>Deletes a discovery client.</summary>
                /// <param name="name">Required. The discovery client name.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a discovery client.</summary>
                public class DeleteRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The discovery client name.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/discoveryClients/[^/]+$",
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

                /// <summary>Gets the details of a discovery client.</summary>
                /// <param name="name">Required. The discovery client name.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets the details of a discovery client.</summary>
                public class GetRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.DiscoveryClient>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The discovery client name.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/discoveryClients/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all the discovery clients in a given project and location.</summary>
                /// <param name="parent">Required. Parent resource.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all the discovery clients in a given project and location.</summary>
                public class ListRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.ListDiscoveryClientsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Parent resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Filter expression to filter results by.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Field to sort by.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of items to return. The server may return fewer items than
                    /// requested. If unspecified, the server will pick an appropriate default value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListDiscoveryClients` call. Provide this to
                    /// retrieve the subsequent page. When paginating, all other parameters provided to
                    /// `ListDiscoveryClients` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/discoveryClients";

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

                /// <summary>Updates a discovery client.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Output only. Identifier. Full name of this discovery client.</param>
                public virtual PatchRequest Patch(Google.Apis.MigrationCenterAPI.v1.Data.DiscoveryClient body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates a discovery client.</summary>
                public class PatchRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.MigrationCenterAPI.v1.Data.DiscoveryClient body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Output only. Identifier. Full name of this discovery client.</summary>
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
                    /// Required. Update mask is used to specify the fields to be overwritten in the `DiscoveryClient`
                    /// resource by the update. The values specified in the `update_mask` field are relative to the
                    /// resource, not the full request. A field will be overwritten if it is in the mask. A single *
                    /// value in the mask lets you to overwrite all fields.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.MigrationCenterAPI.v1.Data.DiscoveryClient Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/discoveryClients/[^/]+$",
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
                /// Sends a discovery client heartbeat. Healthy clients are expected to send heartbeats regularly
                /// (normally every few minutes).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. The discovery client name.</param>
                public virtual SendHeartbeatRequest SendHeartbeat(Google.Apis.MigrationCenterAPI.v1.Data.SendDiscoveryClientHeartbeatRequest body, string name)
                {
                    return new SendHeartbeatRequest(this.service, body, name);
                }

                /// <summary>
                /// Sends a discovery client heartbeat. Healthy clients are expected to send heartbeats regularly
                /// (normally every few minutes).
                /// </summary>
                public class SendHeartbeatRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
                {
                    /// <summary>Constructs a new SendHeartbeat request.</summary>
                    public SendHeartbeatRequest(Google.Apis.Services.IClientService service, Google.Apis.MigrationCenterAPI.v1.Data.SendDiscoveryClientHeartbeatRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The discovery client name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.MigrationCenterAPI.v1.Data.SendDiscoveryClientHeartbeatRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "sendHeartbeat";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:sendHeartbeat";

                    /// <summary>Initializes SendHeartbeat parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/discoveryClients/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Groups resource.</summary>
            public virtual GroupsResource Groups { get; }

            /// <summary>The "groups" collection of methods.</summary>
            public class GroupsResource
            {
                private const string Resource = "groups";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public GroupsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Adds assets to a group.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="group">Required. Group reference.</param>
                public virtual AddAssetsRequest AddAssets(Google.Apis.MigrationCenterAPI.v1.Data.AddAssetsToGroupRequest body, string group)
                {
                    return new AddAssetsRequest(this.service, body, group);
                }

                /// <summary>Adds assets to a group.</summary>
                public class AddAssetsRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
                {
                    /// <summary>Constructs a new AddAssets request.</summary>
                    public AddAssetsRequest(Google.Apis.Services.IClientService service, Google.Apis.MigrationCenterAPI.v1.Data.AddAssetsToGroupRequest body, string group) : base(service)
                    {
                        Group = group;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Group reference.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("group", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Group { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.MigrationCenterAPI.v1.Data.AddAssetsToGroupRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "addAssets";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+group}:addAssets";

                    /// <summary>Initializes AddAssets parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("group", new Google.Apis.Discovery.Parameter
                        {
                            Name = "group",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/groups/[^/]+$",
                        });
                    }
                }

                /// <summary>Creates a new group in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Value for parent.</param>
                public virtual CreateRequest Create(Google.Apis.MigrationCenterAPI.v1.Data.Group body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new group in a given project and location.</summary>
                public class CreateRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.MigrationCenterAPI.v1.Data.Group body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Value for parent.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. User specified ID for the group. It will become the last component of the group name.
                    /// The ID must be unique within the project, must conform with RFC-1034, is restricted to
                    /// lower-cased letters, and has a maximum length of 63 characters. The ID must match the regular
                    /// expression: `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("groupId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string GroupId { get; set; }

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
                    Google.Apis.MigrationCenterAPI.v1.Data.Group Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/groups";

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
                        RequestParameters.Add("groupId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "groupId",
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

                /// <summary>Deletes a group.</summary>
                /// <param name="name">Required. Name of the group resource.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a group.</summary>
                public class DeleteRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the group resource.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/groups/[^/]+$",
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

                /// <summary>Gets the details of a group.</summary>
                /// <param name="name">Required. Name of the resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets the details of a group.</summary>
                public class GetRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Group>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/groups/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all groups in a given project and location.</summary>
                /// <param name="parent">Required. Parent value for `ListGroupsRequest`.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all groups in a given project and location.</summary>
                public class ListRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.ListGroupsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value for `ListGroupsRequest`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Filtering results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Field to sort by. See https://google.aip.dev/132#ordering for more details.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Requested page size. Server may return fewer items than requested. If unspecified, server will
                    /// pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/groups";

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

                /// <summary>Updates the parameters of a group.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Output only. The name of the group.</param>
                public virtual PatchRequest Patch(Google.Apis.MigrationCenterAPI.v1.Data.Group body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a group.</summary>
                public class PatchRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.MigrationCenterAPI.v1.Data.Group body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Output only. The name of the group.</summary>
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
                    /// Required. Field mask is used to specify the fields to be overwritten in the `Group` resource by
                    /// the update. The values specified in the `update_mask` are relative to the resource, not the full
                    /// request. A field will be overwritten if it is in the mask. A single * value in the mask lets you
                    /// to overwrite all fields.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.MigrationCenterAPI.v1.Data.Group Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/groups/[^/]+$",
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

                /// <summary>Removes assets from a group.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="group">Required. Group reference.</param>
                public virtual RemoveAssetsRequest RemoveAssets(Google.Apis.MigrationCenterAPI.v1.Data.RemoveAssetsFromGroupRequest body, string group)
                {
                    return new RemoveAssetsRequest(this.service, body, group);
                }

                /// <summary>Removes assets from a group.</summary>
                public class RemoveAssetsRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
                {
                    /// <summary>Constructs a new RemoveAssets request.</summary>
                    public RemoveAssetsRequest(Google.Apis.Services.IClientService service, Google.Apis.MigrationCenterAPI.v1.Data.RemoveAssetsFromGroupRequest body, string group) : base(service)
                    {
                        Group = group;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Group reference.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("group", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Group { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.MigrationCenterAPI.v1.Data.RemoveAssetsFromGroupRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "removeAssets";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+group}:removeAssets";

                    /// <summary>Initializes RemoveAssets parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("group", new Google.Apis.Discovery.Parameter
                        {
                            Name = "group",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/groups/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the ImportJobs resource.</summary>
            public virtual ImportJobsResource ImportJobs { get; }

            /// <summary>The "importJobs" collection of methods.</summary>
            public class ImportJobsResource
            {
                private const string Resource = "importJobs";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ImportJobsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    ImportDataFiles = new ImportDataFilesResource(service);
                }

                /// <summary>Gets the ImportDataFiles resource.</summary>
                public virtual ImportDataFilesResource ImportDataFiles { get; }

                /// <summary>The "importDataFiles" collection of methods.</summary>
                public class ImportDataFilesResource
                {
                    private const string Resource = "importDataFiles";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ImportDataFilesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates an import data file.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. Name of the parent of the ImportDataFile.</param>
                    public virtual CreateRequest Create(Google.Apis.MigrationCenterAPI.v1.Data.ImportDataFile body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates an import data file.</summary>
                    public class CreateRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.MigrationCenterAPI.v1.Data.ImportDataFile body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the parent of the ImportDataFile.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Required. The ID of the new data file.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("importDataFileId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ImportDataFileId { get; set; }

                        /// <summary>
                        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that
                        /// if you must retry your request, the server will know to ignore the request if it has already
                        /// been completed. The server will guarantee that for at least 60 minutes since the first
                        /// request. For example, consider a situation where you make an initial request and the request
                        /// times out. If you make the request again with the same request ID, the server can check if
                        /// original operation with the same request ID was received, and if so, will ignore the second
                        /// request. This prevents clients from accidentally creating duplicate commitments. The request
                        /// ID must be a valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.MigrationCenterAPI.v1.Data.ImportDataFile Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/importDataFiles";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/importJobs/[^/]+$",
                            });
                            RequestParameters.Add("importDataFileId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "importDataFileId",
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

                    /// <summary>Delete an import data file.</summary>
                    /// <param name="name">Required. Name of the ImportDataFile to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Delete an import data file.</summary>
                    public class DeleteRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the ImportDataFile to delete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that
                        /// if you must retry your request, the server will know to ignore the request if it has already
                        /// been completed. The server will guarantee that for at least 60 minutes after the first
                        /// request. For example, consider a situation where you make an initial request and the request
                        /// times out. If you make the request again with the same request ID, the server can check if
                        /// original operation with the same request ID was received, and if so, will ignore the second
                        /// request. This prevents clients from accidentally creating duplicate commitments. The request
                        /// ID must be a valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/importJobs/[^/]+/importDataFiles/[^/]+$",
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

                    /// <summary>Gets an import data file.</summary>
                    /// <param name="name">Required. Name of the ImportDataFile.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets an import data file.</summary>
                    public class GetRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.ImportDataFile>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the ImportDataFile.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/importJobs/[^/]+/importDataFiles/[^/]+$",
                            });
                        }
                    }

                    /// <summary>List import data files.</summary>
                    /// <param name="parent">Required. Name of the parent of the `ImportDataFiles` resource.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>List import data files.</summary>
                    public class ListRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.ListImportDataFilesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the parent of the `ImportDataFiles` resource.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Filtering results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Field to sort by. See https://google.aip.dev/132#ordering for more details.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// The maximum number of data files to return. The service may return fewer than this value. If
                        /// unspecified, at most 500 data files will be returned. The maximum value is 1000; values
                        /// above 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListImportDataFiles` call. Provide this to retrieve
                        /// the subsequent page. When paginating, all other parameters provided to `ListImportDataFiles`
                        /// must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/importDataFiles";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/importJobs/[^/]+$",
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

                /// <summary>Creates an import job.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Value for parent.</param>
                public virtual CreateRequest Create(Google.Apis.MigrationCenterAPI.v1.Data.ImportJob body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates an import job.</summary>
                public class CreateRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.MigrationCenterAPI.v1.Data.ImportJob body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Value for parent.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. ID of the import job.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("importJobId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ImportJobId { get; set; }

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
                    Google.Apis.MigrationCenterAPI.v1.Data.ImportJob Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/importJobs";

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
                        RequestParameters.Add("importJobId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "importJobId",
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

                /// <summary>Deletes an import job.</summary>
                /// <param name="name">Required. Name of the resource.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes an import job.</summary>
                public class DeleteRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If set to `true`, any `ImportDataFiles` of this job will also be deleted If set to
                    /// `false`, the request only works if the job has no data files.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/importJobs/[^/]+$",
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

                /// <summary>Gets the details of an import job.</summary>
                /// <param name="name">Required. Name of the resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets the details of an import job.</summary>
                public class GetRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.ImportJob>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Optional. The level of details of the import job. Default value is FULL.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>Optional. The level of details of the import job. Default value is FULL.</summary>
                    public enum ViewEnum
                    {
                        /// <summary>
                        /// The import job view is not specified. The API displays the basic view by default.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("IMPORT_JOB_VIEW_UNSPECIFIED")]
                        IMPORTJOBVIEWUNSPECIFIED = 0,

                        /// <summary>
                        /// The import job view includes basic metadata of an import job. This view does not include
                        /// payload information.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("IMPORT_JOB_VIEW_BASIC")]
                        IMPORTJOBVIEWBASIC = 1,

                        /// <summary>The import job view includes all metadata of an import job.</summary>
                        [Google.Apis.Util.StringValueAttribute("IMPORT_JOB_VIEW_FULL")]
                        IMPORTJOBVIEWFULL = 2,
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/importJobs/[^/]+$",
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

                /// <summary>Lists all import jobs.</summary>
                /// <param name="parent">Required. Parent value for `ListImportJobsRequest`.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all import jobs.</summary>
                public class ListRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.ListImportJobsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value for `ListImportJobsRequest`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Filtering results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Field to sort by. See https://google.aip.dev/132#ordering for more details.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Requested page size. Server may return fewer items than requested. If unspecified, server will
                    /// pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Optional. The level of details of each import job. Default value is BASIC.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>Optional. The level of details of each import job. Default value is BASIC.</summary>
                    public enum ViewEnum
                    {
                        /// <summary>
                        /// The import job view is not specified. The API displays the basic view by default.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("IMPORT_JOB_VIEW_UNSPECIFIED")]
                        IMPORTJOBVIEWUNSPECIFIED = 0,

                        /// <summary>
                        /// The import job view includes basic metadata of an import job. This view does not include
                        /// payload information.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("IMPORT_JOB_VIEW_BASIC")]
                        IMPORTJOBVIEWBASIC = 1,

                        /// <summary>The import job view includes all metadata of an import job.</summary>
                        [Google.Apis.Util.StringValueAttribute("IMPORT_JOB_VIEW_FULL")]
                        IMPORTJOBVIEWFULL = 2,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/importJobs";

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

                /// <summary>Updates an import job.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Output only. The full name of the import job.</param>
                public virtual PatchRequest Patch(Google.Apis.MigrationCenterAPI.v1.Data.ImportJob body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates an import job.</summary>
                public class PatchRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.MigrationCenterAPI.v1.Data.ImportJob body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Output only. The full name of the import job.</summary>
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
                    /// Required. Field mask is used to specify the fields to be overwritten in the `Asset` resource by
                    /// the update. The values specified in the `update_mask` field are relative to the resource, not
                    /// the full request. A field will be overwritten if it is in the mask. A single * value in the mask
                    /// lets you to overwrite all fields.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.MigrationCenterAPI.v1.Data.ImportJob Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/importJobs/[^/]+$",
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

                /// <summary>Runs an import job.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. The name of the import job to run.</param>
                public virtual RunRequest Run(Google.Apis.MigrationCenterAPI.v1.Data.RunImportJobRequest body, string name)
                {
                    return new RunRequest(this.service, body, name);
                }

                /// <summary>Runs an import job.</summary>
                public class RunRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Run request.</summary>
                    public RunRequest(Google.Apis.Services.IClientService service, Google.Apis.MigrationCenterAPI.v1.Data.RunImportJobRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the import job to run.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.MigrationCenterAPI.v1.Data.RunImportJobRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "run";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:run";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/importJobs/[^/]+$",
                        });
                    }
                }

                /// <summary>Validates an import job.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. The name of the import job to validate.</param>
                public virtual ValidateRequest Validate(Google.Apis.MigrationCenterAPI.v1.Data.ValidateImportJobRequest body, string name)
                {
                    return new ValidateRequest(this.service, body, name);
                }

                /// <summary>Validates an import job.</summary>
                public class ValidateRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Validate request.</summary>
                    public ValidateRequest(Google.Apis.Services.IClientService service, Google.Apis.MigrationCenterAPI.v1.Data.ValidateImportJobRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the import job to validate.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.MigrationCenterAPI.v1.Data.ValidateImportJobRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "validate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:validate";

                    /// <summary>Initializes Validate parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/importJobs/[^/]+$",
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
                public virtual CancelRequest Cancel(Google.Apis.MigrationCenterAPI.v1.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.MigrationCenterAPI.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.MigrationCenterAPI.v1.Data.CancelOperationRequest Body { get; set; }

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
                public class DeleteRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Empty>
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
                public class GetRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
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
                public class ListRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.ListOperationsResponse>
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

            /// <summary>Gets the PreferenceSets resource.</summary>
            public virtual PreferenceSetsResource PreferenceSets { get; }

            /// <summary>The "preferenceSets" collection of methods.</summary>
            public class PreferenceSetsResource
            {
                private const string Resource = "preferenceSets";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public PreferenceSetsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new preference set in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Value for parent.</param>
                public virtual CreateRequest Create(Google.Apis.MigrationCenterAPI.v1.Data.PreferenceSet body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new preference set in a given project and location.</summary>
                public class CreateRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.MigrationCenterAPI.v1.Data.PreferenceSet body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Value for parent.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. User specified ID for the preference set. It will become the last component of the
                    /// preference set name. The ID must be unique within the project, must conform with RFC-1034, is
                    /// restricted to lower-cased letters, and has a maximum length of 63 characters. The ID must match
                    /// the regular expression `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("preferenceSetId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PreferenceSetId { get; set; }

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
                    Google.Apis.MigrationCenterAPI.v1.Data.PreferenceSet Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/preferenceSets";

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
                        RequestParameters.Add("preferenceSetId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "preferenceSetId",
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

                /// <summary>Deletes a preference set.</summary>
                /// <param name="name">Required. Name of the group resource.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a preference set.</summary>
                public class DeleteRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the group resource.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/preferenceSets/[^/]+$",
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

                /// <summary>Gets the details of a preference set.</summary>
                /// <param name="name">Required. Name of the resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets the details of a preference set.</summary>
                public class GetRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.PreferenceSet>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/preferenceSets/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all the preference sets in a given project and location.</summary>
                /// <param name="parent">Required. Parent value for `ListPreferenceSetsRequest`.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all the preference sets in a given project and location.</summary>
                public class ListRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.ListPreferenceSetsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value for `ListPreferenceSetsRequest`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Field to sort by. See https://google.aip.dev/132#ordering for more details.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Requested page size. Server may return fewer items than requested. If unspecified, at most 500
                    /// preference sets will be returned. The maximum value is 1000; values above 1000 will be coerced
                    /// to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/preferenceSets";

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

                /// <summary>Updates the parameters of a preference set.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Output only. Name of the preference set.</param>
                public virtual PatchRequest Patch(Google.Apis.MigrationCenterAPI.v1.Data.PreferenceSet body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a preference set.</summary>
                public class PatchRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.MigrationCenterAPI.v1.Data.PreferenceSet body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Output only. Name of the preference set.</summary>
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
                    /// Required. Field mask is used to specify the fields to be overwritten in the `PreferenceSet`
                    /// resource by the update. The values specified in the `update_mask` field are relative to the
                    /// resource, not the full request. A field will be overwritten if it is in the mask. A single *
                    /// value in the mask lets you to overwrite all fields.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.MigrationCenterAPI.v1.Data.PreferenceSet Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/preferenceSets/[^/]+$",
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
            }

            /// <summary>Gets the Relations resource.</summary>
            public virtual RelationsResource Relations { get; }

            /// <summary>The "relations" collection of methods.</summary>
            public class RelationsResource
            {
                private const string Resource = "relations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RelationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets the details of an relation.</summary>
                /// <param name="name">Required. Name of the resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets the details of an relation.</summary>
                public class GetRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Relation>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/relations/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all the relations in a given project and location.</summary>
                /// <param name="parent">Required. Parent value for `ListRelationsRequest`.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all the relations in a given project and location.</summary>
                public class ListRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.ListRelationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value for `ListRelationsRequest`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Filtering results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. Field to sort by. See https://google.aip.dev/132#ordering for more details.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                    /// server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/relations";

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

            /// <summary>Gets the ReportConfigs resource.</summary>
            public virtual ReportConfigsResource ReportConfigs { get; }

            /// <summary>The "reportConfigs" collection of methods.</summary>
            public class ReportConfigsResource
            {
                private const string Resource = "reportConfigs";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ReportConfigsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Reports = new ReportsResource(service);
                }

                /// <summary>Gets the Reports resource.</summary>
                public virtual ReportsResource Reports { get; }

                /// <summary>The "reports" collection of methods.</summary>
                public class ReportsResource
                {
                    private const string Resource = "reports";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ReportsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a report.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. Value for parent.</param>
                    public virtual CreateRequest Create(Google.Apis.MigrationCenterAPI.v1.Data.Report body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a report.</summary>
                    public class CreateRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.MigrationCenterAPI.v1.Data.Report body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Value for parent.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. User specified id for the report. It will become the last component of the report
                        /// name. The id must be unique within the project, must conform with RFC-1034, is restricted to
                        /// lower-cased letters, and has a maximum length of 63 characters. The id must match the
                        /// regular expression: [a-z]([a-z0-9-]{0,61}[a-z0-9])?.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("reportId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ReportId { get; set; }

                        /// <summary>
                        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that
                        /// if you must retry your request, the server will know to ignore the request if it has already
                        /// been completed. The server will guarantee that for at least 60 minutes since the first
                        /// request. For example, consider a situation where you make an initial request and the request
                        /// times out. If you make the request again with the same request ID, the server can check if
                        /// original operation with the same request ID was received, and if so, will ignore the second
                        /// request. This prevents clients from accidentally creating duplicate commitments. The request
                        /// ID must be a valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.MigrationCenterAPI.v1.Data.Report Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/reports";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/reportConfigs/[^/]+$",
                            });
                            RequestParameters.Add("reportId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "reportId",
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

                    /// <summary>Deletes a Report.</summary>
                    /// <param name="name">Required. Name of the resource.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a Report.</summary>
                    public class DeleteRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the resource.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that
                        /// if you must retry your request, the server will know to ignore the request if it has already
                        /// been completed. The server will guarantee that for at least 60 minutes after the first
                        /// request. For example, consider a situation where you make an initial request and the request
                        /// times out. If you make the request again with the same request ID, the server can check if
                        /// original operation with the same request ID was received, and if so, will ignore the second
                        /// request. This prevents clients from accidentally creating duplicate commitments. The request
                        /// ID must be a valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/reportConfigs/[^/]+/reports/[^/]+$",
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

                    /// <summary>Gets details of a single Report.</summary>
                    /// <param name="name">Required. Name of the resource.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a single Report.</summary>
                    public class GetRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Report>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the resource.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Determines what information to retrieve for the Report.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>Determines what information to retrieve for the Report.</summary>
                        public enum ViewEnum
                        {
                            /// <summary>
                            /// The report view is not specified. The API displays the basic view by default.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("REPORT_VIEW_UNSPECIFIED")]
                            REPORTVIEWUNSPECIFIED = 0,

                            /// <summary>
                            /// The report view includes only basic metadata of the Report. Useful for list views.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("REPORT_VIEW_BASIC")]
                            REPORTVIEWBASIC = 1,

                            /// <summary>
                            /// The report view includes all the metadata of the Report. Useful for preview.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("REPORT_VIEW_FULL")]
                            REPORTVIEWFULL = 2,

                            /// <summary>
                            /// The report view includes the standard metadata of an report. Useful for detail view.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("REPORT_VIEW_STANDARD")]
                            REPORTVIEWSTANDARD = 3,
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/reportConfigs/[^/]+/reports/[^/]+$",
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

                    /// <summary>Lists Reports in a given ReportConfig.</summary>
                    /// <param name="parent">Required. Parent value for `ListReportsRequest`.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists Reports in a given ReportConfig.</summary>
                    public class ListRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.ListReportsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. Parent value for `ListReportsRequest`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Filtering results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Field to sort by. See https://google.aip.dev/132#ordering for more details.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Requested page size. The server may return fewer items than requested. If unspecified, the
                        /// server will pick an appropriate default value.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>A token identifying a page of results that the server should return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Determines what information to retrieve for each Report.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>Determines what information to retrieve for each Report.</summary>
                        public enum ViewEnum
                        {
                            /// <summary>
                            /// The report view is not specified. The API displays the basic view by default.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("REPORT_VIEW_UNSPECIFIED")]
                            REPORTVIEWUNSPECIFIED = 0,

                            /// <summary>
                            /// The report view includes only basic metadata of the Report. Useful for list views.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("REPORT_VIEW_BASIC")]
                            REPORTVIEWBASIC = 1,

                            /// <summary>
                            /// The report view includes all the metadata of the Report. Useful for preview.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("REPORT_VIEW_FULL")]
                            REPORTVIEWFULL = 2,

                            /// <summary>
                            /// The report view includes the standard metadata of an report. Useful for detail view.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("REPORT_VIEW_STANDARD")]
                            REPORTVIEWSTANDARD = 3,
                        }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/reports";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/reportConfigs/[^/]+$",
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
                }

                /// <summary>Creates a report configuration.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Value for parent.</param>
                public virtual CreateRequest Create(Google.Apis.MigrationCenterAPI.v1.Data.ReportConfig body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a report configuration.</summary>
                public class CreateRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.MigrationCenterAPI.v1.Data.ReportConfig body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Value for parent.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. User specified ID for the report config. It will become the last component of the
                    /// report config name. The ID must be unique within the project, must conform with RFC-1034, is
                    /// restricted to lower-cased letters, and has a maximum length of 63 characters. The ID must match
                    /// the regular expression: [a-z]([a-z0-9-]{0,61}[a-z0-9])?.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("reportConfigId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ReportConfigId { get; set; }

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
                    Google.Apis.MigrationCenterAPI.v1.Data.ReportConfig Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/reportConfigs";

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
                        RequestParameters.Add("reportConfigId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "reportConfigId",
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

                /// <summary>Deletes a ReportConfig.</summary>
                /// <param name="name">Required. Name of the resource.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a ReportConfig.</summary>
                public class DeleteRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If set to `true`, any child `Reports` of this entity will also be deleted. If set to
                    /// `false`, the request only works if the resource has no children.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/reportConfigs/[^/]+$",
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

                /// <summary>Gets details of a single ReportConfig.</summary>
                /// <param name="name">Required. Name of the resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single ReportConfig.</summary>
                public class GetRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.ReportConfig>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/reportConfigs/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists ReportConfigs in a given project and location.</summary>
                /// <param name="parent">Required. Parent value for `ListReportConfigsRequest`.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists ReportConfigs in a given project and location.</summary>
                public class ListRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.ListReportConfigsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value for `ListReportConfigsRequest`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Filtering results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Field to sort by. See https://google.aip.dev/132#ordering for more details.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Requested page size. Server may return fewer items than requested. If unspecified, server will
                    /// pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/reportConfigs";

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

            /// <summary>Gets the Sources resource.</summary>
            public virtual SourcesResource Sources { get; }

            /// <summary>The "sources" collection of methods.</summary>
            public class SourcesResource
            {
                private const string Resource = "sources";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SourcesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    ErrorFrames = new ErrorFramesResource(service);
                }

                /// <summary>Gets the ErrorFrames resource.</summary>
                public virtual ErrorFramesResource ErrorFrames { get; }

                /// <summary>The "errorFrames" collection of methods.</summary>
                public class ErrorFramesResource
                {
                    private const string Resource = "errorFrames";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ErrorFramesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Gets the details of an error frame.</summary>
                    /// <param name="name">
                    /// Required. The name of the frame to retrieve. Format:
                    /// projects/{project}/locations/{location}/sources/{source}/errorFrames/{error_frame}
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets the details of an error frame.</summary>
                    public class GetRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.ErrorFrame>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the frame to retrieve. Format:
                        /// projects/{project}/locations/{location}/sources/{source}/errorFrames/{error_frame}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. An optional view mode to control the level of details for the frame. The default
                        /// is a basic frame view.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>
                        /// Optional. An optional view mode to control the level of details for the frame. The default
                        /// is a basic frame view.
                        /// </summary>
                        public enum ViewEnum
                        {
                            /// <summary>Value is unset. The system will fallback to the default value.</summary>
                            [Google.Apis.Util.StringValueAttribute("ERROR_FRAME_VIEW_UNSPECIFIED")]
                            ERRORFRAMEVIEWUNSPECIFIED = 0,

                            /// <summary>Include basic frame data, but not the full contents.</summary>
                            [Google.Apis.Util.StringValueAttribute("ERROR_FRAME_VIEW_BASIC")]
                            ERRORFRAMEVIEWBASIC = 1,

                            /// <summary>Include everything.</summary>
                            [Google.Apis.Util.StringValueAttribute("ERROR_FRAME_VIEW_FULL")]
                            ERRORFRAMEVIEWFULL = 2,
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+/errorFrames/[^/]+$",
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

                    /// <summary>Lists all error frames in a given source and location.</summary>
                    /// <param name="parent">Required. Parent value (the source) for `ListErrorFramesRequest`.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists all error frames in a given source and location.</summary>
                    public class ListRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.ListErrorFramesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. Parent value (the source) for `ListErrorFramesRequest`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Requested page size. Server may return fewer items than requested. If unspecified, server
                        /// will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>A token identifying a page of results the server should return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// Optional. An optional view mode to control the level of details of each error frame. The
                        /// default is a BASIC frame view.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>
                        /// Optional. An optional view mode to control the level of details of each error frame. The
                        /// default is a BASIC frame view.
                        /// </summary>
                        public enum ViewEnum
                        {
                            /// <summary>Value is unset. The system will fallback to the default value.</summary>
                            [Google.Apis.Util.StringValueAttribute("ERROR_FRAME_VIEW_UNSPECIFIED")]
                            ERRORFRAMEVIEWUNSPECIFIED = 0,

                            /// <summary>Include basic frame data, but not the full contents.</summary>
                            [Google.Apis.Util.StringValueAttribute("ERROR_FRAME_VIEW_BASIC")]
                            ERRORFRAMEVIEWBASIC = 1,

                            /// <summary>Include everything.</summary>
                            [Google.Apis.Util.StringValueAttribute("ERROR_FRAME_VIEW_FULL")]
                            ERRORFRAMEVIEWFULL = 2,
                        }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/errorFrames";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+$",
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
                }

                /// <summary>Creates a new source in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Value for parent.</param>
                public virtual CreateRequest Create(Google.Apis.MigrationCenterAPI.v1.Data.Source body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new source in a given project and location.</summary>
                public class CreateRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.MigrationCenterAPI.v1.Data.Source body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Value for parent.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

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
                    /// Required. User specified ID for the source. It will become the last component of the source
                    /// name. The ID must be unique within the project, must conform with RFC-1034, is restricted to
                    /// lower-cased letters, and has a maximum length of 63 characters. The ID must match the regular
                    /// expression: `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("sourceId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string SourceId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.MigrationCenterAPI.v1.Data.Source Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/sources";

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
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("sourceId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "sourceId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a source.</summary>
                /// <param name="name">Required. Name of the resource.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a source.</summary>
                public class DeleteRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+$",
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

                /// <summary>Gets the details of a source.</summary>
                /// <param name="name">Required. Name of the resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets the details of a source.</summary>
                public class GetRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Source>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all the sources in a given project and location.</summary>
                /// <param name="parent">Required. Parent value for `ListSourcesRequest`.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all the sources in a given project and location.</summary>
                public class ListRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.ListSourcesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value for `ListSourcesRequest`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Filtering results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Field to sort by. See https://google.aip.dev/132#ordering for more details.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Requested page size. The server may return fewer items than requested. If unspecified, the
                    /// server will pick an appropriate default value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results that the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/sources";

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

                /// <summary>Updates the parameters of a source.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Output only. The full name of the source.</param>
                public virtual PatchRequest Patch(Google.Apis.MigrationCenterAPI.v1.Data.Source body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a source.</summary>
                public class PatchRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.MigrationCenterAPI.v1.Data.Source body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Output only. The full name of the source.</summary>
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
                    /// Required. Field mask is used to specify the fields to be overwritten in the `Source` resource by
                    /// the update. The values specified in the `update_mask` field are relative to the resource, not
                    /// the full request. A field will be overwritten if it is in the mask. A single * value in the mask
                    /// lets you to overwrite all fields.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.MigrationCenterAPI.v1.Data.Source Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+$",
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
            }

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Location>
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

            /// <summary>Gets the details of regional settings.</summary>
            /// <param name="name">Required. Name of the resource.</param>
            public virtual GetSettingsRequest GetSettings(string name)
            {
                return new GetSettingsRequest(this.service, name);
            }

            /// <summary>Gets the details of regional settings.</summary>
            public class GetSettingsRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Settings>
            {
                /// <summary>Constructs a new GetSettings request.</summary>
                public GetSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Name of the resource.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getSettings";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes GetSettings parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+/settings$",
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
            public class ListRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.ListLocationsResponse>
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

            /// <summary>Updates the regional-level project settings.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Output only. The name of the resource.</param>
            public virtual UpdateSettingsRequest UpdateSettings(Google.Apis.MigrationCenterAPI.v1.Data.Settings body, string name)
            {
                return new UpdateSettingsRequest(this.service, body, name);
            }

            /// <summary>Updates the regional-level project settings.</summary>
            public class UpdateSettingsRequest : MigrationCenterAPIBaseServiceRequest<Google.Apis.MigrationCenterAPI.v1.Data.Operation>
            {
                /// <summary>Constructs a new UpdateSettings request.</summary>
                public UpdateSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.MigrationCenterAPI.v1.Data.Settings body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Output only. The name of the resource.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if you
                /// must retry your request, the server will know to ignore the request if it has already been
                /// completed. The server will guarantee that for at least 60 minutes since the first request. For
                /// example, consider a situation where you make an initial request and the request times out. If you
                /// make the request again with the same request ID, the server can check if original operation with the
                /// same request ID was received, and if so, will ignore the second request. This prevents clients from
                /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the exception
                /// that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string RequestId { get; set; }

                /// <summary>
                /// Required. Field mask is used to specify the fields to be overwritten in the `Settings` resource by
                /// the update. The values specified in the `update_mask` field are relative to the resource, not the
                /// full request. A field will be overwritten if it is in the mask. A single * value in the mask lets
                /// you to overwrite all fields.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.MigrationCenterAPI.v1.Data.Settings Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateSettings";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes UpdateSettings parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+/settings$",
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
        }
    }
}
namespace Google.Apis.MigrationCenterAPI.v1.Data
{
    /// <summary>A request to add assets to a group.</summary>
    public class AddAssetsToGroupRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. When this value is set to `false` and one of the given assets is already an existing member of the
        /// group, the operation fails with an `Already Exists` error. When set to `true` this situation is silently
        /// ignored by the server. Default value is `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowExisting")]
        public virtual System.Nullable<bool> AllowExisting { get; set; }

        /// <summary>
        /// Required. List of assets to be added. The maximum number of assets that can be added in a single request is
        /// 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assets")]
        public virtual AssetList Assets { get; set; }

        /// <summary>
        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if you must retry
        /// your request, the server will know to ignore the request if it has already been completed. The server will
        /// guarantee that for at least 60 minutes after the first request. For example, consider a situation where you
        /// make an initial request and the request times out. If you make the request again with the same request ID,
        /// the server can check if original operation with the same request ID was received, and if so, will ignore the
        /// second request. This prevents clients from accidentally creating duplicate commitments. The request ID must
        /// be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to aggregate one or more values.</summary>
    public class AggregateAssetsValuesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Array of aggregations to perform. Up to 25 aggregations can be defined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregations")]
        public virtual System.Collections.Generic.IList<Aggregation> Aggregations { get; set; }

        /// <summary>Optional. The aggregation will be performed on assets that match the provided filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response to a request to aggregated assets values.</summary>
    public class AggregateAssetsValuesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The aggregation results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<AggregationResult> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message describing an aggregation. The message includes the aggregation type, parameters, and the field on which
    /// to perform the aggregation.
    /// </summary>
    public class Aggregation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Count the number of matching objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual AggregationCount Count { get; set; }

        /// <summary>The name of the field on which to aggregate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        /// <summary>Creates a frequency distribution of all field values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frequency")]
        public virtual AggregationFrequency Frequency { get; set; }

        /// <summary>Creates a bucketed histogram of field values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("histogram")]
        public virtual AggregationHistogram Histogram { get; set; }

        /// <summary>Sum over a numeric field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sum")]
        public virtual AggregationSum Sum { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Object count.</summary>
    public class AggregationCount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Frequency distribution of all field values.</summary>
    public class AggregationFrequency : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Histogram of bucketed assets counts by field value.</summary>
    public class AggregationHistogram : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Lower bounds of buckets. The response will contain `n+1` buckets for `n` bounds. The first bucket will count
        /// all assets for which the field value is smaller than the first bound. Subsequent buckets will count assets
        /// for which the field value is greater or equal to a lower bound and smaller than the next one. The last
        /// bucket will count assets for which the field value is greater or equal to the final lower bound. You can
        /// define up to 20 lower bounds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lowerBounds")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> LowerBounds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message describing a result of an aggregation.</summary>
    public class AggregationResult : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual AggregationResultCount Count { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("frequency")]
        public virtual AggregationResultFrequency Frequency { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("histogram")]
        public virtual AggregationResultHistogram Histogram { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sum")]
        public virtual AggregationResultSum Sum { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of a count aggregation.</summary>
    public class AggregationResultCount : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<long> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of a frequency distribution aggregation.</summary>
    public class AggregationResultFrequency : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<long>> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of a bucketed histogram aggregation.</summary>
    public class AggregationResultHistogram : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Buckets in the histogram. There will be `n+1` buckets matching `n` lower bounds in the request. The first
        /// bucket will be from -infinity to the first bound. Subsequent buckets will be between one bound and the next.
        /// The final bucket will be from the final bound to infinity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buckets")]
        public virtual System.Collections.Generic.IList<AggregationResultHistogramBucket> Buckets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A histogram bucket with a lower and upper bound, and a count of items with a field value between those bounds.
    /// The lower bound is inclusive and the upper bound is exclusive. Lower bound may be -infinity and upper bound may
    /// be infinity.
    /// </summary>
    public class AggregationResultHistogramBucket : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Count of items in the bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>Lower bound - inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lowerBound")]
        public virtual System.Nullable<double> LowerBound { get; set; }

        /// <summary>Upper bound - exclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upperBound")]
        public virtual System.Nullable<double> UpperBound { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of a sum aggregation.</summary>
    public class AggregationResultSum : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sum of field values.</summary>
    public class AggregationSum : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An asset represents a resource in your environment. Asset types include virtual machines and databases.
    /// </summary>
    public class Asset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The list of groups that the asset is assigned to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignedGroups")]
        public virtual System.Collections.Generic.IList<string> AssignedGroups { get; set; }

        /// <summary>Generic asset attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, string> Attributes { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The timestamp when the asset was created.</summary>
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

        /// <summary>Output only. Asset information specific for database deployments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseDeploymentDetails")]
        public virtual DatabaseDeploymentDetails DatabaseDeploymentDetails { get; set; }

        /// <summary>Output only. Asset information specific for logical databases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseDetails")]
        public virtual DatabaseDetails DatabaseDetails { get; set; }

        /// <summary>Output only. The list of insights associated with the asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insightList")]
        public virtual InsightList InsightList { get; set; }

        /// <summary>Labels as key value pairs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. Asset information specific for virtual and physical machines.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineDetails")]
        public virtual MachineDetails MachineDetails { get; set; }

        /// <summary>Output only. The full name of the asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Performance data for the asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("performanceData")]
        public virtual AssetPerformanceData PerformanceData { get; set; }

        /// <summary>Output only. The list of sources contributing to the asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<string> Sources { get; set; }

        /// <summary>Output only. Server generated human readable name of the asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The timestamp when the asset was last updated.</summary>
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

    /// <summary>Contains data reported from an inventory source on an asset.</summary>
    public class AssetFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Generic asset attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// Optional. Frame collection type, if not specified the collection type will be based on the source type of
        /// the source the frame was reported on.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionType")]
        public virtual string CollectionType { get; set; }

        /// <summary>Asset information specific for database deployments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseDeploymentDetails")]
        public virtual DatabaseDeploymentDetails DatabaseDeploymentDetails { get; set; }

        /// <summary>Asset information specific for logical databases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseDetails")]
        public virtual DatabaseDetails DatabaseDetails { get; set; }

        /// <summary>Labels as key value pairs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Asset information specific for virtual machines.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineDetails")]
        public virtual MachineDetails MachineDetails { get; set; }

        /// <summary>
        /// Asset performance data samples. Samples that are from more than 40 days ago or after tomorrow are ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("performanceSamples")]
        public virtual System.Collections.Generic.IList<PerformanceSample> PerformanceSamples { get; set; }

        private string _reportTimeRaw;

        private object _reportTime;

        /// <summary>The time the data was reported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportTime")]
        public virtual string ReportTimeRaw
        {
            get => _reportTimeRaw;
            set
            {
                _reportTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _reportTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReportTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReportTimeDateTimeOffset instead.")]
        public virtual object ReportTime
        {
            get => _reportTime;
            set
            {
                _reportTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _reportTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReportTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReportTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReportTimeRaw);
            set => ReportTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. Trace token is optionally provided to assist with debugging and traceability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traceToken")]
        public virtual string TraceToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Lists the asset IDs of all assets.</summary>
    public class AssetList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A list of asset IDs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetIds")]
        public virtual System.Collections.Generic.IList<string> AssetIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Performance data for an asset.</summary>
    public class AssetPerformanceData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Daily resource usage aggregations. Contains all of the data available for an asset, up to the last 420 days.
        /// Aggregations are sorted from oldest to most recent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyResourceUsageAggregations")]
        public virtual System.Collections.Generic.IList<DailyResourceUsageAggregation> DailyResourceUsageAggregations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AWS EC2 specific details.</summary>
    public class AwsEc2PlatformDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Whether the machine is hyperthreaded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hyperthreading")]
        public virtual string Hyperthreading { get; set; }

        /// <summary>The location of the machine in the AWS format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>AWS platform's machine type label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineTypeLabel")]
        public virtual string MachineTypeLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specific details for an AWS RDS database deployment.</summary>
    public class AwsRds : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Azure VM specific details.</summary>
    public class AzureVmPlatformDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the machine is hyperthreaded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hyperthreading")]
        public virtual string Hyperthreading { get; set; }

        /// <summary>The location of the machine in the Azure format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Azure platform's machine type label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineTypeLabel")]
        public virtual string MachineTypeLabel { get; set; }

        /// <summary>Azure platform's provisioning state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisioningState")]
        public virtual string ProvisioningState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to delete a list of asset.</summary>
    public class BatchDeleteAssetsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. When this value is set to `true` the request is a no-op for non-existing assets. See
        /// https://google.aip.dev/135#delete-if-existing for additional details. Default value is `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowMissing")]
        public virtual System.Nullable<bool> AllowMissing { get; set; }

        /// <summary>
        /// Required. The IDs of the assets to delete. A maximum of 1000 assets can be deleted in a batch. Format:
        /// projects/{project}/locations/{location}/assets/{name}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("names")]
        public virtual System.Collections.Generic.IList<string> Names { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to update a list of assets.</summary>
    public class BatchUpdateAssetsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The request message specifying the resources to update. A maximum of 1000 assets can be modified
        /// in a batch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<UpdateAssetRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for updating a list of assets.</summary>
    public class BatchUpdateAssetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Update asset content. The content only includes values after field mask being applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assets")]
        public virtual System.Collections.Generic.IList<Asset> Assets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about the BIOS.</summary>
    public class BiosDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>BIOS name. This fields is deprecated. Please use the `id` field instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("biosName")]
        public virtual string BiosName { get; set; }

        /// <summary>BIOS ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>BIOS manufacturer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manufacturer")]
        public virtual string Manufacturer { get; set; }

        /// <summary>BIOS release date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseDate")]
        public virtual Date ReleaseDate { get; set; }

        /// <summary>SMBIOS UUID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smbiosUuid")]
        public virtual string SmbiosUuid { get; set; }

        /// <summary>BIOS version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Compute engine migration target.</summary>
    public class ComputeEngineMigrationTarget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the suggested shape for the migration target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shape")]
        public virtual ComputeEngineShapeDescriptor Shape { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The user preferences relating to Compute Engine target platform.</summary>
    public class ComputeEnginePreferences : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// License type to consider when calculating costs for virtual machine insights and recommendations. If
        /// unspecified, costs are calculated based on the default licensing plan.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("licenseType")]
        public virtual string LicenseType { get; set; }

        /// <summary>Preferences concerning the machine types to consider on Compute Engine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machinePreferences")]
        public virtual MachinePreferences MachinePreferences { get; set; }

        /// <summary>
        /// Persistent disk type to use. If unspecified (default), all types are considered, based on available usage
        /// data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("persistentDiskType")]
        public virtual string PersistentDiskType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Compute Engine target shape descriptor.</summary>
    public class ComputeEngineShapeDescriptor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Number of logical cores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logicalCoreCount")]
        public virtual System.Nullable<int> LogicalCoreCount { get; set; }

        /// <summary>Output only. Compute Engine machine type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>Memory in mebibytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryMb")]
        public virtual System.Nullable<int> MemoryMb { get; set; }

        /// <summary>Number of physical cores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("physicalCoreCount")]
        public virtual System.Nullable<int> PhysicalCoreCount { get; set; }

        /// <summary>Output only. Compute Engine machine series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("series")]
        public virtual string Series { get; set; }

        /// <summary>Output only. Compute Engine storage. Never empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storage")]
        public virtual System.Collections.Generic.IList<ComputeStorageDescriptor> Storage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Compute Engine storage option descriptor.</summary>
    public class ComputeStorageDescriptor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Disk size in GiB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeGb")]
        public virtual System.Nullable<int> SizeGb { get; set; }

        /// <summary>Output only. Disk type backing the storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CPU usage sample.</summary>
    public class CpuUsageSample : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Percentage of total CPU capacity utilized. Must be in the interval [0, 100]. On most systems can be
        /// calculated using 100 - idle percentage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utilizedPercentage")]
        public virtual System.Nullable<float> UtilizedPercentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Usage data aggregation for a single day.</summary>
    public class DailyResourceUsageAggregation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>CPU usage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpu")]
        public virtual DailyResourceUsageAggregationCPU Cpu { get; set; }

        /// <summary>Aggregation date. Day boundaries are at midnight UTC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>Disk usage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disk")]
        public virtual DailyResourceUsageAggregationDisk Disk { get; set; }

        /// <summary>Memory usage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memory")]
        public virtual DailyResourceUsageAggregationMemory Memory { get; set; }

        /// <summary>Network usage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual DailyResourceUsageAggregationNetwork Network { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Statistical aggregation of CPU usage.</summary>
    public class DailyResourceUsageAggregationCPU : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>CPU utilization percentage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utilizationPercentage")]
        public virtual DailyResourceUsageAggregationStats UtilizationPercentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Statistical aggregation of disk usage.</summary>
    public class DailyResourceUsageAggregationDisk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Disk I/O operations per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iops")]
        public virtual DailyResourceUsageAggregationStats Iops { get; set; }

        /// <summary>Optional. Disk read I/O operations per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readIops")]
        public virtual DailyResourceUsageAggregationStats ReadIops { get; set; }

        /// <summary>Optional. Disk write I/O operations per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeIops")]
        public virtual DailyResourceUsageAggregationStats WriteIops { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Statistical aggregation of memory usage.</summary>
    public class DailyResourceUsageAggregationMemory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Memory utilization percentage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utilizationPercentage")]
        public virtual DailyResourceUsageAggregationStats UtilizationPercentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Statistical aggregation of network usage.</summary>
    public class DailyResourceUsageAggregationNetwork : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Network egress in B/s.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("egressBps")]
        public virtual DailyResourceUsageAggregationStats EgressBps { get; set; }

        /// <summary>Network ingress in B/s.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressBps")]
        public virtual DailyResourceUsageAggregationStats IngressBps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Statistical aggregation of samples for a single resource usage.</summary>
    public class DailyResourceUsageAggregationStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Average usage value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("average")]
        public virtual System.Nullable<float> Average { get; set; }

        /// <summary>Median usage value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("median")]
        public virtual System.Nullable<float> Median { get; set; }

        /// <summary>95th percentile usage value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ninteyFifthPercentile")]
        public virtual System.Nullable<float> NinteyFifthPercentile { get; set; }

        /// <summary>Peak usage value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peak")]
        public virtual System.Nullable<float> Peak { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The details of a database deployment asset.</summary>
    public class DatabaseDeploymentDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Aggregated stats for the database deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregatedStats")]
        public virtual DatabaseDeploymentDetailsAggregatedStats AggregatedStats { get; set; }

        /// <summary>Optional. Details of an AWS RDS instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("awsRds")]
        public virtual AwsRds AwsRds { get; set; }

        /// <summary>Optional. The database deployment edition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("edition")]
        public virtual string Edition { get; set; }

        /// <summary>Optional. The database deployment generated ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generatedId")]
        public virtual string GeneratedId { get; set; }

        /// <summary>Optional. A manual unique ID set by the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualUniqueId")]
        public virtual string ManualUniqueId { get; set; }

        /// <summary>Optional. Details of a MYSQL database deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mysql")]
        public virtual MysqlDatabaseDeployment Mysql { get; set; }

        /// <summary>Optional. Details of a PostgreSQL database deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postgresql")]
        public virtual PostgreSqlDatabaseDeployment Postgresql { get; set; }

        /// <summary>Optional. Details of a Microsoft SQL Server database deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlServer")]
        public virtual SqlServerDatabaseDeployment SqlServer { get; set; }

        /// <summary>Optional. Details of the database deployment topology.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topology")]
        public virtual DatabaseDeploymentTopology Topology { get; set; }

        /// <summary>Optional. The database deployment version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Aggregated stats for the database deployment.</summary>
    public class DatabaseDeploymentDetailsAggregatedStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The number of databases in the deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseCount")]
        public virtual System.Nullable<int> DatabaseCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of database deployment's topology.</summary>
    public class DatabaseDeploymentTopology : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Number of total logical cores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coreCount")]
        public virtual System.Nullable<int> CoreCount { get; set; }

        /// <summary>Optional. Number of total logical cores limited by db deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coreLimit")]
        public virtual System.Nullable<int> CoreLimit { get; set; }

        /// <summary>Optional. Disk allocated in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskAllocatedBytes")]
        public virtual System.Nullable<long> DiskAllocatedBytes { get; set; }

        /// <summary>Optional. Disk used in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskUsedBytes")]
        public virtual System.Nullable<long> DiskUsedBytes { get; set; }

        /// <summary>Optional. List of database instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<DatabaseInstance> Instances { get; set; }

        /// <summary>Optional. Total memory in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryBytes")]
        public virtual System.Nullable<long> MemoryBytes { get; set; }

        /// <summary>Optional. Total memory in bytes limited by db deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryLimitBytes")]
        public virtual System.Nullable<long> MemoryLimitBytes { get; set; }

        /// <summary>Optional. Number of total physical cores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("physicalCoreCount")]
        public virtual System.Nullable<int> PhysicalCoreCount { get; set; }

        /// <summary>Optional. Number of total physical cores limited by db deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("physicalCoreLimit")]
        public virtual System.Nullable<int> PhysicalCoreLimit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of a logical database.</summary>
    public class DatabaseDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The allocated storage for the database in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allocatedStorageBytes")]
        public virtual System.Nullable<long> AllocatedStorageBytes { get; set; }

        /// <summary>Required. The name of the database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseName")]
        public virtual string DatabaseName { get; set; }

        /// <summary>Required. The parent database deployment that contains the logical database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentDatabaseDeployment")]
        public virtual DatabaseDetailsParentDatabaseDeployment ParentDatabaseDeployment { get; set; }

        /// <summary>Optional. The database schemas.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemas")]
        public virtual System.Collections.Generic.IList<DatabaseSchema> Schemas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The identifiers of the parent database deployment.</summary>
    public class DatabaseDetailsParentDatabaseDeployment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The parent database deployment generated ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generatedId")]
        public virtual string GeneratedId { get; set; }

        /// <summary>Optional. The parent database deployment optional manual unique ID set by the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualUniqueId")]
        public virtual string ManualUniqueId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of a database instance.</summary>
    public class DatabaseInstance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The instance's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceName")]
        public virtual string InstanceName { get; set; }

        /// <summary>Optional. Networking details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual DatabaseInstanceNetwork Network { get; set; }

        /// <summary>Optional. The instance role in the database engine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Network details of a database instance.</summary>
    public class DatabaseInstanceNetwork : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The instance's host names.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostNames")]
        public virtual System.Collections.Generic.IList<string> HostNames { get; set; }

        /// <summary>Optional. The instance's IP addresses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddresses")]
        public virtual System.Collections.Generic.IList<string> IpAddresses { get; set; }

        /// <summary>Optional. The instance's primary MAC address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryMacAddress")]
        public virtual string PrimaryMacAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of a group of database objects.</summary>
    public class DatabaseObjects : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The category of the objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>Optional. The number of objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of a database schema.</summary>
    public class DatabaseSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Details of a Mysql schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mysql")]
        public virtual MySqlSchemaDetails Mysql { get; set; }

        /// <summary>Optional. List of details of objects by category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objects")]
        public virtual System.Collections.Generic.IList<DatabaseObjects> Objects { get; set; }

        /// <summary>Optional. Details of a PostgreSql schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postgresql")]
        public virtual PostgreSqlSchemaDetails Postgresql { get; set; }

        /// <summary>Required. The name of the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaName")]
        public virtual string SchemaName { get; set; }

        /// <summary>Optional. Details of a SqlServer schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlServer")]
        public virtual SqlServerSchemaDetails SqlServer { get; set; }

        /// <summary>Optional. The total size of tables in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tablesSizeBytes")]
        public virtual System.Nullable<long> TablesSizeBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a whole or partial calendar date, such as a birthday. The time of day and time zone are either
    /// specified elsewhere or are insignificant. The date is relative to the Gregorian Calendar. This can represent one
    /// of the following: * A full date, with non-zero year, month, and day values. * A month and day, with a zero year
    /// (for example, an anniversary). * A year on its own, with a zero month and a zero day. * A year and month, with a
    /// zero day (for example, a credit card expiration date). Related types: * google.type.TimeOfDay *
    /// google.type.DateTime * google.protobuf.Timestamp
    /// </summary>
    public class Date : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a
        /// year and month where the day isn't significant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual System.Nullable<int> Month { get; set; }

        /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("year")]
        public virtual System.Nullable<int> Year { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an installed Migration Center Discovery Client instance.</summary>
    public class DiscoveryClient : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time when the discovery client was first created.</summary>
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

        /// <summary>Optional. Free text description. Maximum length is 1000 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. Free text display name. Maximum length is 63 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. Errors affecting client functionality.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<Status> Errors { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Optional. Client expiration time in UTC. If specified, the backend will not accept new frames after this
        /// time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual string ExpireTimeRaw
        {
            get => _expireTimeRaw;
            set
            {
                _expireTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expireTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpireTimeDateTimeOffset instead.")]
        public virtual object ExpireTime
        {
            get => _expireTime;
            set
            {
                _expireTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expireTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpireTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpireTimeRaw);
            set => ExpireTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _heartbeatTimeRaw;

        private object _heartbeatTime;

        /// <summary>
        /// Output only. Last heartbeat time. Healthy clients are expected to send heartbeats regularly (normally every
        /// few minutes).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heartbeatTime")]
        public virtual string HeartbeatTimeRaw
        {
            get => _heartbeatTimeRaw;
            set
            {
                _heartbeatTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _heartbeatTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="HeartbeatTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use HeartbeatTimeDateTimeOffset instead.")]
        public virtual object HeartbeatTime
        {
            get => _heartbeatTime;
            set
            {
                _heartbeatTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _heartbeatTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="HeartbeatTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? HeartbeatTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(HeartbeatTimeRaw);
            set => HeartbeatTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. Labels as key value pairs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. Identifier. Full name of this discovery client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Service account used by the discovery client for various operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Output only. This field is intended for internal use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalsEndpoint")]
        public virtual string SignalsEndpoint { get; set; }

        /// <summary>
        /// Required. Immutable. Full name of the source object associated with this discovery client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>Output only. Current state of the discovery client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Optional. Input only. Client time-to-live. If specified, the backend will not accept new frames after this
        /// time. This field is input only. The derived expiration time is provided as output through the `expire_time`
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttl")]
        public virtual object Ttl { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. Time when the discovery client was last updated. This value is not updated by heartbeats, to
        /// view the last heartbeat time please refer to the `heartbeat_time` field.
        /// </summary>
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

        /// <summary>Output only. Client version, as reported in recent heartbeat.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Single disk entry.</summary>
    public class DiskEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Disk capacity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capacityBytes")]
        public virtual System.Nullable<long> CapacityBytes { get; set; }

        /// <summary>Disk label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskLabel")]
        public virtual string DiskLabel { get; set; }

        /// <summary>Disk label type (e.g. BIOS/GPT)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskLabelType")]
        public virtual string DiskLabelType { get; set; }

        /// <summary>Disk free space.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeBytes")]
        public virtual System.Nullable<long> FreeBytes { get; set; }

        /// <summary>Disk hardware address (e.g. 0:1 for SCSI).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hwAddress")]
        public virtual string HwAddress { get; set; }

        /// <summary>Disks interface type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interfaceType")]
        public virtual string InterfaceType { get; set; }

        /// <summary>Partition layout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitions")]
        public virtual DiskPartitionList Partitions { get; set; }

        /// <summary>VMware disk details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmware")]
        public virtual VmwareDiskConfig Vmware { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VM disks.</summary>
    public class DiskEntryList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Disk entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<DiskEntry> Entries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Disk Partition details.</summary>
    public class DiskPartition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Partition capacity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capacityBytes")]
        public virtual System.Nullable<long> CapacityBytes { get; set; }

        /// <summary>Partition file system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileSystem")]
        public virtual string FileSystem { get; set; }

        /// <summary>Partition free space.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeBytes")]
        public virtual System.Nullable<long> FreeBytes { get; set; }

        /// <summary>Mount point (Linux/Windows) or drive letter (Windows).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mountPoint")]
        public virtual string MountPoint { get; set; }

        /// <summary>Sub-partitions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subPartitions")]
        public virtual DiskPartitionList SubPartitions { get; set; }

        /// <summary>Partition type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Partition UUID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uuid")]
        public virtual string Uuid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Disk partition details.</summary>
    public class DiskPartitionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Total free space of all partitions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeSpaceBytes")]
        public virtual System.Nullable<long> FreeSpaceBytes { get; set; }

        /// <summary>Optional. List of partitions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitions")]
        public virtual DiskPartitionList Partitions { get; set; }

        /// <summary>Output only. Total capacity of all partitions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalCapacityBytes")]
        public virtual System.Nullable<long> TotalCapacityBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Disk partition list.</summary>
    public class DiskPartitionList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Partition entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<DiskPartition> Entries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Disk usage sample. Values are across all disks.</summary>
    public class DiskUsageSample : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Average IOPS sampled over a short window. Must be non-negative. If read or write are set, the sum
        /// of read and write will override the value of the average_iops.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageIops")]
        public virtual System.Nullable<float> AverageIops { get; set; }

        /// <summary>
        /// Optional. Average read IOPS sampled over a short window. Must be non-negative. If both read and write are
        /// zero they are ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageReadIops")]
        public virtual System.Nullable<float> AverageReadIops { get; set; }

        /// <summary>
        /// Optional. Average write IOPS sampled over a short window. Must be non-negative. If both read and write are
        /// zero they are ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageWriteIops")]
        public virtual System.Nullable<float> AverageWriteIops { get; set; }

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

    /// <summary>Message representing a frame which failed to be processed due to an error.</summary>
    public class ErrorFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _ingestionTimeRaw;

        private object _ingestionTime;

        /// <summary>Output only. Frame ingestion time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingestionTime")]
        public virtual string IngestionTimeRaw
        {
            get => _ingestionTimeRaw;
            set
            {
                _ingestionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _ingestionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="IngestionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use IngestionTimeDateTimeOffset instead.")]
        public virtual object IngestionTime
        {
            get => _ingestionTime;
            set
            {
                _ingestionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _ingestionTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="IngestionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? IngestionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(IngestionTimeRaw);
            set => IngestionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The identifier of the ErrorFrame.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The frame that was originally reported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalFrame")]
        public virtual AssetFrame OriginalFrame { get; set; }

        /// <summary>Output only. All the violations that were detected for the frame.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("violations")]
        public virtual System.Collections.Generic.IList<FrameViolationEntry> Violations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that reports result of the import job execution.</summary>
    public class ExecutionReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Validation errors encountered during the execution of the import job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionErrors")]
        public virtual ValidationReport ExecutionErrors { get; set; }

        /// <summary>Total number of asset frames reported for the import job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("framesReported")]
        public virtual System.Nullable<int> FramesReported { get; set; }

        /// <summary>Output only. Total number of rows in the import job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalRowsCount")]
        public virtual System.Nullable<int> TotalRowsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that aggregates the validation errors found in an import job file.</summary>
    public class FileValidationReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of file level errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileErrors")]
        public virtual System.Collections.Generic.IList<ImportError> FileErrors { get; set; }

        /// <summary>The name of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileName")]
        public virtual string FileName { get; set; }

        /// <summary>Flag indicating that processing was aborted due to maximum number of errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialReport")]
        public virtual System.Nullable<bool> PartialReport { get; set; }

        /// <summary>Partial list of rows that encountered validation error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowErrors")]
        public virtual System.Collections.Generic.IList<ImportRowError> RowErrors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the fit level of an asset for migration to a specific target.</summary>
    public class FitDescriptor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Fit level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fitLevel")]
        public virtual string FitLevel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that contains a single violation of a reported `AssetFrame` resource.</summary>
    public class FrameViolationEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The field of the original frame where the violation occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        /// <summary>A message describing the violation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("violation")]
        public virtual string Violation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Collection of frame data.</summary>
    public class Frames : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A repeated field of asset data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("framesData")]
        public virtual System.Collections.Generic.IList<AssetFrame> FramesData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Single fstab entry.</summary>
    public class FstabEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The mount point for the filesystem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("file")]
        public virtual string File { get; set; }

        /// <summary>Used by dump to determine which filesystems need to be dumped.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freq")]
        public virtual System.Nullable<int> Freq { get; set; }

        /// <summary>Mount options associated with the filesystem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mntops")]
        public virtual string Mntops { get; set; }

        /// <summary>
        /// Used by the fsck(8) program to determine the order in which filesystem checks are done at reboot time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passno")]
        public virtual System.Nullable<int> Passno { get; set; }

        /// <summary>The block special device or remote filesystem to be mounted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual string Spec { get; set; }

        /// <summary>The type of the filesystem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vfstype")]
        public virtual string Vfstype { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Fstab content.</summary>
    public class FstabEntryList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Fstab entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<FstabEntry> Entries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A generic insight about an asset.</summary>
    public class GenericInsight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Additional information about the insight, each entry can be a logical entry and must make sense
        /// if it is displayed with line breaks between each entry. Text can contain md style links.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalInformation")]
        public virtual System.Collections.Generic.IList<string> AdditionalInformation { get; set; }

        /// <summary>
        /// Output only. In case message_code is not yet known by the client default_message will be the message to be
        /// used instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultMessage")]
        public virtual string DefaultMessage { get; set; }

        /// <summary>
        /// Output only. Represents a globally unique message id for this insight, can be used for localization
        /// purposes, in case message_code is not yet known by the client use default_message instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageId")]
        public virtual System.Nullable<long> MessageId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Generic platform details.</summary>
    public class GenericPlatformDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the machine is hyperthreaded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hyperthreading")]
        public virtual string Hyperthreading { get; set; }

        /// <summary>
        /// Free text representation of the machine location. The format of this field should not be relied on.
        /// Different VMs in the same location may have different string values for this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A resource that represents an asset group. The purpose of an asset group is to bundle a set of assets that have
    /// something in common, while allowing users to add annotations to the group. An asset can belong to multiple
    /// groups.
    /// </summary>
    public class Group : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The timestamp when the group was created.</summary>
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

        /// <summary>Optional. The description of the group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. User-friendly display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Labels as key value pairs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. The name of the group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The timestamp when the group was last updated.</summary>
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

    /// <summary>Guest OS config information.</summary>
    public class GuestConfigDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Mount list (Linux fstab).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fstab")]
        public virtual FstabEntryList Fstab { get; set; }

        /// <summary>Hosts file (/etc/hosts).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hosts")]
        public virtual HostsEntryList Hosts { get; set; }

        /// <summary>OS issue (typically /etc/issue in Linux).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issue")]
        public virtual string Issue { get; set; }

        /// <summary>NFS exports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nfsExports")]
        public virtual NfsExportList NfsExports { get; set; }

        /// <summary>Security-Enhanced Linux (SELinux) mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selinuxMode")]
        public virtual string SelinuxMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Guest installed application information.</summary>
    public class GuestInstalledApplication : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Installed application name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationName")]
        public virtual string ApplicationName { get; set; }

        private string _installTimeRaw;

        private object _installTime;

        /// <summary>The time when the application was installed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installTime")]
        public virtual string InstallTimeRaw
        {
            get => _installTimeRaw;
            set
            {
                _installTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _installTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="InstallTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use InstallTimeDateTimeOffset instead.")]
        public virtual object InstallTime
        {
            get => _installTime;
            set
            {
                _installTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _installTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="InstallTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? InstallTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(InstallTimeRaw);
            set => InstallTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>License strings associated with the installed application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("licenses")]
        public virtual System.Collections.Generic.IList<string> Licenses { get; set; }

        /// <summary>Source path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>Installed application vendor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vendor")]
        public virtual string Vendor { get; set; }

        /// <summary>Installed application version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Guest installed application list.</summary>
    public class GuestInstalledApplicationList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Application entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<GuestInstalledApplication> Entries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information from Guest-level collections.</summary>
    public class GuestOsDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>OS and app configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual GuestConfigDetails Config { get; set; }

        /// <summary>What family the OS belong to, if known.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("family")]
        public virtual string Family { get; set; }

        /// <summary>The name of the operating system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osName")]
        public virtual string OsName { get; set; }

        /// <summary>Runtime information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtime")]
        public virtual GuestRuntimeDetails Runtime { get; set; }

        /// <summary>The version of the operating system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Guest OS runtime information.</summary>
    public class GuestRuntimeDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Domain, e.g. c.stratozone-development.internal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>Installed applications information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installedApps")]
        public virtual GuestInstalledApplicationList InstalledApps { get; set; }

        private string _lastBootTimeRaw;

        private object _lastBootTime;

        /// <summary>Last time the OS was booted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastBootTime")]
        public virtual string LastBootTimeRaw
        {
            get => _lastBootTimeRaw;
            set
            {
                _lastBootTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastBootTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastBootTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastBootTimeDateTimeOffset instead.")]
        public virtual object LastBootTime
        {
            get => _lastBootTime;
            set
            {
                _lastBootTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastBootTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="LastBootTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastBootTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastBootTimeRaw);
            set => LastBootTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Machine name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineName")]
        public virtual string MachineName { get; set; }

        /// <summary>Runtime network information (connections, ports).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual RuntimeNetworkInfo Network { get; set; }

        /// <summary>Open files information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openFileList")]
        public virtual OpenFileList OpenFileList { get; set; }

        /// <summary>Running processes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processes")]
        public virtual RunningProcessList Processes { get; set; }

        /// <summary>Running background services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("services")]
        public virtual RunningServiceList Services { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Single /etc/hosts entry.</summary>
    public class HostsEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of host names / aliases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostNames")]
        public virtual System.Collections.Generic.IList<string> HostNames { get; set; }

        /// <summary>IP (raw, IPv4/6 agnostic).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ip")]
        public virtual string Ip { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Hosts content.</summary>
    public class HostsEntryList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hosts entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<HostsEntry> Entries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that represents a payload file in an import job.</summary>
    public class ImportDataFile : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The timestamp when the file was created.</summary>
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

        /// <summary>User-friendly display name. Maximum length is 63 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Required. The payload format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>Output only. The name of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The state of the import data file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Information about a file that is uploaded to a storage service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadFileInfo")]
        public virtual UploadFileInfo UploadFileInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that reports the errors encountered while processing an import job.</summary>
    public class ImportError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The error information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorDetails")]
        public virtual string ErrorDetails { get; set; }

        /// <summary>The severity of the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that represents the background job that imports asset frames.</summary>
    public class ImportJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Reference to a source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetSource")]
        public virtual string AssetSource { get; set; }

        private string _completeTimeRaw;

        private object _completeTime;

        /// <summary>Output only. The timestamp when the import job was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completeTime")]
        public virtual string CompleteTimeRaw
        {
            get => _completeTimeRaw;
            set
            {
                _completeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _completeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CompleteTimeDateTimeOffset instead.")]
        public virtual object CompleteTime
        {
            get => _completeTime;
            set
            {
                _completeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _completeTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CompleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CompleteTimeRaw);
            set => CompleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The timestamp when the import job was created.</summary>
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

        /// <summary>Optional. User-friendly display name. Maximum length is 256 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. The report with the results of running the import job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionReport")]
        public virtual ExecutionReport ExecutionReport { get; set; }

        /// <summary>Labels as key value pairs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. The full name of the import job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The state of the import job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The timestamp when the import job was last updated.</summary>
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

        /// <summary>Output only. The report with the validation results of the import job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validationReport")]
        public virtual ValidationReport ValidationReport { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that reports the import job errors at row level.</summary>
    public class ImportRowError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Error details for an archive file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("archiveError")]
        public virtual ImportRowErrorArchiveErrorDetails ArchiveError { get; set; }

        /// <summary>Output only. The asset title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetTitle")]
        public virtual string AssetTitle { get; set; }

        /// <summary>Error details for a CSV file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("csvError")]
        public virtual ImportRowErrorCsvErrorDetails CsvError { get; set; }

        /// <summary>The list of errors detected in the row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<ImportError> Errors { get; set; }

        /// <summary>The row number where the error was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowNumber")]
        public virtual System.Nullable<int> RowNumber { get; set; }

        /// <summary>The name of the VM in the row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmName")]
        public virtual string VmName { get; set; }

        /// <summary>The VM UUID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmUuid")]
        public virtual string VmUuid { get; set; }

        /// <summary>Error details for an XLSX file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("xlsxError")]
        public virtual ImportRowErrorXlsxErrorDetails XlsxError { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Error details for an archive file.</summary>
    public class ImportRowErrorArchiveErrorDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Error details for a CSV file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("csvError")]
        public virtual ImportRowErrorCsvErrorDetails CsvError { get; set; }

        /// <summary>Output only. The file path inside the archive where the error was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filePath")]
        public virtual string FilePath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Error details for a CSV file.</summary>
    public class ImportRowErrorCsvErrorDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The row number where the error was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowNumber")]
        public virtual System.Nullable<int> RowNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Error details for an XLSX file.</summary>
    public class ImportRowErrorXlsxErrorDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The row number where the error was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowNumber")]
        public virtual System.Nullable<int> RowNumber { get; set; }

        /// <summary>The name of the sheet where the error was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sheet")]
        public virtual string Sheet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An insight about an asset.</summary>
    public class Insight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. A generic insight about an asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("genericInsight")]
        public virtual GenericInsight GenericInsight { get; set; }

        /// <summary>Output only. An insight about potential migrations for an asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migrationInsight")]
        public virtual MigrationInsight MigrationInsight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message containing insights list.</summary>
    public class InsightList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Insights of the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insights")]
        public virtual System.Collections.Generic.IList<Insight> Insights { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Update timestamp.</summary>
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

    /// <summary>Response message for listing assets.</summary>
    public class ListAssetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of assets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assets")]
        public virtual System.Collections.Generic.IList<Asset> Assets { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing discovery clients.</summary>
    public class ListDiscoveryClientsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of discovery clients.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discoveryClients")]
        public virtual System.Collections.Generic.IList<DiscoveryClient> DiscoveryClients { get; set; }

        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response for listing error frames.</summary>
    public class ListErrorFramesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of error frames.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorFrames")]
        public virtual System.Collections.Generic.IList<ErrorFrame> ErrorFrames { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response for listing groups.</summary>
    public class ListGroupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Group</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groups")]
        public virtual System.Collections.Generic.IList<Group> Groups { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for listing payload files of an import job.</summary>
    public class ListImportDataFilesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of import data files.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importDataFiles")]
        public virtual System.Collections.Generic.IList<ImportDataFile> ImportDataFiles { get; set; }

        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response for listing import jobs.</summary>
    public class ListImportJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of import jobs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importJobs")]
        public virtual System.Collections.Generic.IList<ImportJob> ImportJobs { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
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

    /// <summary>Response message for listing preference sets.</summary>
    public class ListPreferenceSetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of PreferenceSets</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preferenceSets")]
        public virtual System.Collections.Generic.IList<PreferenceSet> PreferenceSets { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing relations.</summary>
    public class ListRelationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of relations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relations")]
        public virtual System.Collections.Generic.IList<Relation> Relations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing report configs.</summary>
    public class ListReportConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of report configs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportConfigs")]
        public virtual System.Collections.Generic.IList<ReportConfig> ReportConfigs { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing Reports.</summary>
    public class ListReportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of Reports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reports")]
        public virtual System.Collections.Generic.IList<Report> Reports { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing sources.</summary>
    public class ListSourcesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of sources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<Source> Sources { get; set; }

        /// <summary>Locations that could not be reached.</summary>
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

    /// <summary>Details of the machine architecture.</summary>
    public class MachineArchitectureDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>BIOS Details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bios")]
        public virtual BiosDetails Bios { get; set; }

        /// <summary>CPU architecture, e.g., "x64-based PC", "x86_64", "i686" etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuArchitecture")]
        public virtual string CpuArchitecture { get; set; }

        /// <summary>Optional. CPU manufacturer, e.g., "Intel", "AMD".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuManufacturer")]
        public virtual string CpuManufacturer { get; set; }

        /// <summary>CPU name, e.g., "Intel Xeon E5-2690", "AMD EPYC 7571" etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuName")]
        public virtual string CpuName { get; set; }

        /// <summary>Number of processor sockets allocated to the machine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuSocketCount")]
        public virtual System.Nullable<int> CpuSocketCount { get; set; }

        /// <summary>
        /// Deprecated: use MachineDetails.core_count instead. Number of CPU threads allocated to the machine.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuThreadCount")]
        public virtual System.Nullable<int> CpuThreadCount { get; set; }

        /// <summary>Firmware type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firmwareType")]
        public virtual string FirmwareType { get; set; }

        /// <summary>CPU hyper-threading support.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hyperthreading")]
        public virtual string Hyperthreading { get; set; }

        /// <summary>Hardware vendor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vendor")]
        public virtual string Vendor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of a machine.</summary>
    public class MachineDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Architecture details (vendor, CPU architecture).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("architecture")]
        public virtual MachineArchitectureDetails Architecture { get; set; }

        /// <summary>Number of logical CPU cores in the machine. Must be non-negative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coreCount")]
        public virtual System.Nullable<int> CoreCount { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Machine creation time.</summary>
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
        /// Optional. Disk partitions details. Note: Partitions are not necessarily mounted on local disks and therefore
        /// might not have a one-to-one correspondence with local disks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskPartitions")]
        public virtual DiskPartitionDetails DiskPartitions { get; set; }

        /// <summary>Disk details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disks")]
        public virtual MachineDiskDetails Disks { get; set; }

        /// <summary>Guest OS information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guestOs")]
        public virtual GuestOsDetails GuestOs { get; set; }

        /// <summary>Machine name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineName")]
        public virtual string MachineName { get; set; }

        /// <summary>The amount of memory in the machine. Must be non-negative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryMb")]
        public virtual System.Nullable<int> MemoryMb { get; set; }

        /// <summary>Network details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual MachineNetworkDetails Network { get; set; }

        /// <summary>Platform specific information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual PlatformDetails Platform { get; set; }

        /// <summary>Power state of the machine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("powerState")]
        public virtual string PowerState { get; set; }

        /// <summary>Machine unique identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uuid")]
        public virtual string Uuid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of machine disks.</summary>
    public class MachineDiskDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of disks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disks")]
        public virtual DiskEntryList Disks { get; set; }

        /// <summary>Disk total Capacity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalCapacityBytes")]
        public virtual System.Nullable<long> TotalCapacityBytes { get; set; }

        /// <summary>Total disk free space.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalFreeBytes")]
        public virtual System.Nullable<long> TotalFreeBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of network adapters and settings.</summary>
    public class MachineNetworkDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of network adapters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adapters")]
        public virtual NetworkAdapterList Adapters { get; set; }

        /// <summary>The primary IP address of the machine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryIpAddress")]
        public virtual string PrimaryIpAddress { get; set; }

        /// <summary>MAC address of the machine. This property is used to uniqly identify the machine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryMacAddress")]
        public virtual string PrimaryMacAddress { get; set; }

        /// <summary>The public IP address of the machine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicIpAddress")]
        public virtual string PublicIpAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The type of machines to consider when calculating virtual machine migration insights and recommendations. Not
    /// all machine types are available in all zones and regions.
    /// </summary>
    public class MachinePreferences : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Compute Engine machine series to consider for insights and recommendations. If empty, no restriction is
        /// applied on the machine series.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedMachineSeries")]
        public virtual System.Collections.Generic.IList<MachineSeries> AllowedMachineSeries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A machine series, for a target product (e.g. Compute Engine, Google Cloud VMware Engine).</summary>
    public class MachineSeries : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Code to identify a machine series. Consult this for more details on the available series for Compute Engine:
        /// https://cloud.google.com/compute/docs/machine-resource#machine_type_comparison Consult this for more details
        /// on the available series for Google Cloud VMware Engine: https://cloud.google.com/vmware-engine/pricing
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Memory usage sample.</summary>
    public class MemoryUsageSample : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Percentage of system memory utilized. Must be in the interval [0, 100].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utilizedPercentage")]
        public virtual System.Nullable<float> UtilizedPercentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An insight about potential migrations for an asset.</summary>
    public class MigrationInsight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. A Google Compute Engine target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeEngineTarget")]
        public virtual ComputeEngineMigrationTarget ComputeEngineTarget { get; set; }

        /// <summary>
        /// Output only. Description of how well the asset this insight is associated with fits the proposed migration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fit")]
        public virtual FitDescriptor Fit { get; set; }

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

    /// <summary>MySql plugin.</summary>
    public class MySqlPlugin : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The plugin is active.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>Required. The plugin name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plugin")]
        public virtual string Plugin { get; set; }

        /// <summary>Required. The plugin version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MySql property.</summary>
    public class MySqlProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The property is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>Required. The property numeric value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numericValue")]
        public virtual System.Nullable<long> NumericValue { get; set; }

        /// <summary>Required. The property name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual string Property { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specific details for a Mysql database.</summary>
    public class MySqlSchemaDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Mysql storage engine tables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageEngines")]
        public virtual System.Collections.Generic.IList<MySqlStorageEngineDetails> StorageEngines { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Mysql storage engine tables.</summary>
    public class MySqlStorageEngineDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The number of encrypted tables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedTableCount")]
        public virtual System.Nullable<int> EncryptedTableCount { get; set; }

        /// <summary>Required. The storage engine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("engine")]
        public virtual string Engine { get; set; }

        /// <summary>Optional. The number of tables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableCount")]
        public virtual System.Nullable<int> TableCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MySql variable.</summary>
    public class MySqlVariable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The variable category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>Required. The variable value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>Required. The variable name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variable")]
        public virtual string Variable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specific details for a Mysql database deployment.</summary>
    public class MysqlDatabaseDeployment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. List of MySql plugins.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plugins")]
        public virtual System.Collections.Generic.IList<MySqlPlugin> Plugins { get; set; }

        /// <summary>Optional. List of MySql properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<MySqlProperty> Properties { get; set; }

        /// <summary>Optional. Number of resource groups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceGroupsCount")]
        public virtual System.Nullable<int> ResourceGroupsCount { get; set; }

        /// <summary>Optional. List of MySql variables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variables")]
        public virtual System.Collections.Generic.IList<MySqlVariable> Variables { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of network adapter.</summary>
    public class NetworkAdapterDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Network adapter type (e.g. VMXNET3).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adapterType")]
        public virtual string AdapterType { get; set; }

        /// <summary>NetworkAddressList</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addresses")]
        public virtual NetworkAddressList Addresses { get; set; }

        /// <summary>MAC address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("macAddress")]
        public virtual string MacAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of network adapters.</summary>
    public class NetworkAdapterList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Network adapter entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<NetworkAdapterDetails> Entries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of network address.</summary>
    public class NetworkAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether DHCP is used to assign addresses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignment")]
        public virtual string Assignment { get; set; }

        /// <summary>Broadcast address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bcast")]
        public virtual string Bcast { get; set; }

        /// <summary>Fully qualified domain name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fqdn")]
        public virtual string Fqdn { get; set; }

        /// <summary>Assigned or configured IP Address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>Subnet mask.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetMask")]
        public virtual string SubnetMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of allocated/assigned network addresses.</summary>
    public class NetworkAddressList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Network address entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<NetworkAddress> Entries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class NetworkConnection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Local IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localIpAddress")]
        public virtual string LocalIpAddress { get; set; }

        /// <summary>Local port.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localPort")]
        public virtual System.Nullable<int> LocalPort { get; set; }

        /// <summary>Process ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pid")]
        public virtual System.Nullable<long> Pid { get; set; }

        /// <summary>Process or service name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processName")]
        public virtual string ProcessName { get; set; }

        /// <summary>Connection protocol (e.g. TCP/UDP).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>Remote IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remoteIpAddress")]
        public virtual string RemoteIpAddress { get; set; }

        /// <summary>Remote port.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remotePort")]
        public virtual System.Nullable<int> RemotePort { get; set; }

        /// <summary>Network connection state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Network connection list.</summary>
    public class NetworkConnectionList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Network connection entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<NetworkConnection> Entries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Network usage sample. Values are across all network interfaces.</summary>
    public class NetworkUsageSample : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Average network egress in B/s sampled over a short window. Must be non-negative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageEgressBps")]
        public virtual System.Nullable<float> AverageEgressBps { get; set; }

        /// <summary>Average network ingress in B/s sampled over a short window. Must be non-negative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageIngressBps")]
        public virtual System.Nullable<float> AverageIngressBps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>NFS export.</summary>
    public class NfsExport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The directory being exported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportDirectory")]
        public virtual string ExportDirectory { get; set; }

        /// <summary>The hosts or networks to which the export is being shared.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hosts")]
        public virtual System.Collections.Generic.IList<string> Hosts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>NFS exports.</summary>
    public class NfsExportList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>NFS export entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<NfsExport> Entries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Open file Information.</summary>
    public class OpenFileDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Opened file command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("command")]
        public virtual string Command { get; set; }

        /// <summary>Opened file file path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filePath")]
        public virtual string FilePath { get; set; }

        /// <summary>Opened file file type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileType")]
        public virtual string FileType { get; set; }

        /// <summary>Opened file user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual string User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Open file list.</summary>
    public class OpenFileList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Open file details entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<OpenFileDetails> Entries { get; set; }

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

        /// <summary>
        /// Output only. Identifies whether the user has requested cancellation of the operation. Operations that have
        /// been cancelled successfully have Operation.error value with a google.rpc.Status.code of 1, corresponding to
        /// `Code.CANCELLED`.
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

    /// <summary>Performance data sample.</summary>
    public class PerformanceSample : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>CPU usage sample.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpu")]
        public virtual CpuUsageSample Cpu { get; set; }

        /// <summary>Disk usage sample.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disk")]
        public virtual DiskUsageSample Disk { get; set; }

        /// <summary>Memory usage sample.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memory")]
        public virtual MemoryUsageSample Memory { get; set; }

        /// <summary>Network usage sample.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual NetworkUsageSample Network { get; set; }

        private string _sampleTimeRaw;

        private object _sampleTime;

        /// <summary>Time the sample was collected. If omitted, the frame report time will be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleTime")]
        public virtual string SampleTimeRaw
        {
            get => _sampleTimeRaw;
            set
            {
                _sampleTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _sampleTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="SampleTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use SampleTimeDateTimeOffset instead.")]
        public virtual object SampleTime
        {
            get => _sampleTime;
            set
            {
                _sampleTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _sampleTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="SampleTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? SampleTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(SampleTimeRaw);
            set => SampleTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Platform specific details for Physical Machines.</summary>
    public class PhysicalPlatformDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the machine is hyperthreaded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hyperthreading")]
        public virtual string Hyperthreading { get; set; }

        /// <summary>
        /// Free text representation of the machine location. The format of this field should not be relied on.
        /// Different machines in the same location may have different string values for this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the platform.</summary>
    public class PlatformDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>AWS EC2 specific details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("awsEc2Details")]
        public virtual AwsEc2PlatformDetails AwsEc2Details { get; set; }

        /// <summary>Azure VM specific details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("azureVmDetails")]
        public virtual AzureVmPlatformDetails AzureVmDetails { get; set; }

        /// <summary>Generic platform details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("genericDetails")]
        public virtual GenericPlatformDetails GenericDetails { get; set; }

        /// <summary>Physical machines platform details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("physicalDetails")]
        public virtual PhysicalPlatformDetails PhysicalDetails { get; set; }

        /// <summary>VMware specific details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmwareDetails")]
        public virtual VmwarePlatformDetails VmwareDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specific details for a PostgreSQL database deployment.</summary>
    public class PostgreSqlDatabaseDeployment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. List of PostgreSql properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<PostgreSqlProperty> Properties { get; set; }

        /// <summary>Optional. List of PostgreSql settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settings")]
        public virtual System.Collections.Generic.IList<PostgreSqlSetting> Settings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>PostgreSql extension.</summary>
    public class PostgreSqlExtension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The extension name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extension")]
        public virtual string Extension { get; set; }

        /// <summary>Required. The extension version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>PostgreSql property.</summary>
    public class PostgreSqlProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The property is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>Required. The property numeric value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numericValue")]
        public virtual System.Nullable<long> NumericValue { get; set; }

        /// <summary>Required. The property name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual string Property { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specific details for a PostgreSql schema.</summary>
    public class PostgreSqlSchemaDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. PostgreSql foreign tables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("foreignTablesCount")]
        public virtual System.Nullable<int> ForeignTablesCount { get; set; }

        /// <summary>Optional. PostgreSql extensions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postgresqlExtensions")]
        public virtual System.Collections.Generic.IList<PostgreSqlExtension> PostgresqlExtensions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>PostgreSql setting.</summary>
    public class PostgreSqlSetting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The setting boolean value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; }

        /// <summary>Required. The setting int value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intValue")]
        public virtual System.Nullable<long> IntValue { get; set; }

        /// <summary>Required. The setting real value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("realValue")]
        public virtual System.Nullable<float> RealValue { get; set; }

        /// <summary>Required. The setting name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setting")]
        public virtual string Setting { get; set; }

        /// <summary>Required. The setting source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>Required. The setting string value. Notice that enum values are stored as strings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>Optional. The setting unit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The preferences that apply to all assets in a given context.</summary>
    public class PreferenceSet : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The timestamp when the preference set was created.</summary>
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

        /// <summary>A description of the preference set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>User-friendly display name. Maximum length is 63 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. Name of the preference set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The timestamp when the preference set was last updated.</summary>
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

        /// <summary>Optional. A set of preferences that applies to all virtual machines in the context.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("virtualMachinePreferences")]
        public virtual VirtualMachinePreferences VirtualMachinePreferences { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The user preferences relating to target regions.</summary>
    public class RegionPreferences : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of preferred regions, ordered by the most preferred region first. Set only valid Google Cloud region
        /// names. See https://cloud.google.com/compute/docs/regions-zones for available regions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preferredRegions")]
        public virtual System.Collections.Generic.IList<string> PreferredRegions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message representing a relation between 2 resource.</summary>
    public class Relation : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The timestamp when the relation was created.</summary>
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

        /// <summary>Output only. The destination asset name in the relation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dstAsset")]
        public virtual string DstAsset { get; set; }

        /// <summary>Output only. Identifier. The identifier of the relation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The source asset name in the relation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("srcAsset")]
        public virtual string SrcAsset { get; set; }

        /// <summary>Optional. The type of the relation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to remove assets from a group.</summary>
    public class RemoveAssetsFromGroupRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. When this value is set to `false` and one of the given assets is not an existing member of the
        /// group, the operation fails with a `Not Found` error. When set to `true` this situation is silently ignored
        /// by the server. Default value is `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowMissing")]
        public virtual System.Nullable<bool> AllowMissing { get; set; }

        /// <summary>
        /// Required. List of assets to be removed. The maximum number of assets that can be removed in a single request
        /// is 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assets")]
        public virtual AssetList Assets { get; set; }

        /// <summary>
        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if you must retry
        /// your request, the server will know to ignore the request if it has already been completed. The server will
        /// guarantee that for at least 60 minutes after the first request. For example, consider a situation where you
        /// make an initial request and the request times out. If you make the request again with the same request ID,
        /// the server can check if original operation with the same request ID was received, and if so, will ignore the
        /// second request. This prevents clients from accidentally creating duplicate commitments. The request ID must
        /// be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Report represents a point-in-time rendering of the ReportConfig results.</summary>
    public class Report : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Creation timestamp.</summary>
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

        /// <summary>Free-text description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>User-friendly display name. Maximum length is 63 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. Name of resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Report creation state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Summary view of the Report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summary")]
        public virtual ReportSummary Summary { get; set; }

        /// <summary>Report type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Last update timestamp.</summary>
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

    /// <summary>A response to a call to `ReportAssetFrame`.</summary>
    public class ReportAssetFramesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The groups and associated preference sets on which we can generate reports.</summary>
    public class ReportConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The timestamp when the resource was created.</summary>
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

        /// <summary>Free-text description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>User-friendly display name. Maximum length is 63 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Required. Collection of combinations of groups and preference sets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupPreferencesetAssignments")]
        public virtual System.Collections.Generic.IList<ReportConfigGroupPreferenceSetAssignment> GroupPreferencesetAssignments { get; set; }

        /// <summary>Output only. Name of resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The timestamp when the resource was last updated.</summary>
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

    /// <summary>Represents a combination of a group with a preference set.</summary>
    public class ReportConfigGroupPreferenceSetAssignment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Name of the group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual string Group { get; set; }

        /// <summary>Required. Name of the Preference Set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preferenceSet")]
        public virtual string PreferenceSet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes the Summary view of a Report, which contains aggregated values for all the groups and preference sets
    /// included in this Report.
    /// </summary>
    public class ReportSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Aggregate statistics for all the assets across all the groups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allAssetsStats")]
        public virtual ReportSummaryAssetAggregateStats AllAssetsStats { get; set; }

        /// <summary>Findings for each Group included in this report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupFindings")]
        public virtual System.Collections.Generic.IList<ReportSummaryGroupFinding> GroupFindings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Aggregate statistics for a collection of assets.</summary>
    public class ReportSummaryAssetAggregateStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Histogram showing a distribution of logical CPU core counts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coreCountHistogram")]
        public virtual ReportSummaryHistogramChartData CoreCountHistogram { get; set; }

        /// <summary>Histogram showing a distribution of memory sizes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryBytesHistogram")]
        public virtual ReportSummaryHistogramChartData MemoryBytesHistogram { get; set; }

        /// <summary>Total memory split into Used/Free buckets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryUtilizationChart")]
        public virtual ReportSummaryUtilizationChartData MemoryUtilizationChart { get; set; }

        /// <summary>Count of assets grouped by Operating System families.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatingSystem")]
        public virtual ReportSummaryChartData OperatingSystem { get; set; }

        /// <summary>Histogram showing a distribution of storage sizes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageBytesHistogram")]
        public virtual ReportSummaryHistogramChartData StorageBytesHistogram { get; set; }

        /// <summary>Total memory split into Used/Free buckets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageUtilizationChart")]
        public virtual ReportSummaryUtilizationChartData StorageUtilizationChart { get; set; }

        /// <summary>Count of the number of unique assets in this collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalAssets")]
        public virtual System.Nullable<long> TotalAssets { get; set; }

        /// <summary>Sum of the CPU core count of all the assets in this collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalCores")]
        public virtual System.Nullable<long> TotalCores { get; set; }

        /// <summary>Sum of the memory in bytes of all the assets in this collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalMemoryBytes")]
        public virtual System.Nullable<long> TotalMemoryBytes { get; set; }

        /// <summary>Sum of persistent storage in bytes of all the assets in this collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalStorageBytes")]
        public virtual System.Nullable<long> TotalStorageBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a collection of data points rendered as a Chart.</summary>
    public class ReportSummaryChartData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Each data point in the chart is represented as a name-value pair with the name being the x-axis label, and
        /// the value being the y-axis value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataPoints")]
        public virtual System.Collections.Generic.IList<ReportSummaryChartDataDataPoint> DataPoints { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a single data point in the Chart.</summary>
    public class ReportSummaryChartDataDataPoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The X-axis label for this data point.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>The Y-axis value for this data point.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A set of findings that applies to assets destined for Compute Engine.</summary>
    public class ReportSummaryComputeEngineFinding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Count of assets which were allocated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allocatedAssetCount")]
        public virtual System.Nullable<long> AllocatedAssetCount { get; set; }

        /// <summary>Set of disk types allocated to assets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allocatedDiskTypes")]
        public virtual System.Collections.Generic.IList<string> AllocatedDiskTypes { get; set; }

        /// <summary>Set of regions in which the assets were allocated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allocatedRegions")]
        public virtual System.Collections.Generic.IList<string> AllocatedRegions { get; set; }

        /// <summary>Distribution of assets based on the Machine Series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineSeriesAllocations")]
        public virtual System.Collections.Generic.IList<ReportSummaryMachineSeriesAllocation> MachineSeriesAllocations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Summary Findings for a specific Group.</summary>
    public class ReportSummaryGroupFinding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Summary statistics for all the assets in this group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetAggregateStats")]
        public virtual ReportSummaryAssetAggregateStats AssetAggregateStats { get; set; }

        /// <summary>Description for the Group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Display Name for the Group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>This field is deprecated, do not rely on it having a value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overlappingAssetCount")]
        public virtual System.Nullable<long> OverlappingAssetCount { get; set; }

        /// <summary>Findings for each of the PreferenceSets for this group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preferenceSetFindings")]
        public virtual System.Collections.Generic.IList<ReportSummaryGroupPreferenceSetFinding> PreferenceSetFindings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Summary Findings for a specific Group/PreferenceSet combination.</summary>
    public class ReportSummaryGroupPreferenceSetFinding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A set of findings that applies to Compute Engine machines in the input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeEngineFinding")]
        public virtual ReportSummaryComputeEngineFinding ComputeEngineFinding { get; set; }

        /// <summary>Description for the Preference Set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Display Name of the Preference Set</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>A set of preferences that applies to all machines in the context.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machinePreferences")]
        public virtual VirtualMachinePreferences MachinePreferences { get; set; }

        /// <summary>Compute monthly cost for this preference set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monthlyCostCompute")]
        public virtual Money MonthlyCostCompute { get; set; }

        /// <summary>Network Egress monthly cost for this preference set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monthlyCostNetworkEgress")]
        public virtual Money MonthlyCostNetworkEgress { get; set; }

        /// <summary>Licensing monthly cost for this preference set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monthlyCostOsLicense")]
        public virtual Money MonthlyCostOsLicense { get; set; }

        /// <summary>Miscellaneous monthly cost for this preference set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monthlyCostOther")]
        public virtual Money MonthlyCostOther { get; set; }

        /// <summary>Storage monthly cost for this preference set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monthlyCostStorage")]
        public virtual Money MonthlyCostStorage { get; set; }

        /// <summary>Total monthly cost for this preference set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monthlyCostTotal")]
        public virtual Money MonthlyCostTotal { get; set; }

        /// <summary>A set of findings that applies to Sole-Tenant machines in the input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("soleTenantFinding")]
        public virtual ReportSummarySoleTenantFinding SoleTenantFinding { get; set; }

        /// <summary>A set of findings that applies to VMWare machines in the input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmwareEngineFinding")]
        public virtual ReportSummaryVmwareEngineFinding VmwareEngineFinding { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Histogram Chart shows a distribution of values into buckets, showing a count of values which fall into a
    /// bucket.
    /// </summary>
    public class ReportSummaryHistogramChartData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Buckets in the histogram. There will be `n+1` buckets matching `n` lower bounds in the request. The first
        /// bucket will be from -infinity to the first bound. Subsequent buckets will be between one bound and the next.
        /// The final bucket will be from the final bound to infinity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buckets")]
        public virtual System.Collections.Generic.IList<ReportSummaryHistogramChartDataBucket> Buckets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A histogram bucket with a lower and upper bound, and a count of items with a field value between those bounds.
    /// The lower bound is inclusive and the upper bound is exclusive. Lower bound may be -infinity and upper bound may
    /// be infinity.
    /// </summary>
    public class ReportSummaryHistogramChartDataBucket : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Count of items in the bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>Lower bound - inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lowerBound")]
        public virtual System.Nullable<long> LowerBound { get; set; }

        /// <summary>Upper bound - exclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upperBound")]
        public virtual System.Nullable<long> UpperBound { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a data point tracking the count of assets allocated for a specific Machine Series.</summary>
    public class ReportSummaryMachineSeriesAllocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Count of assets allocated to this machine series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allocatedAssetCount")]
        public virtual System.Nullable<long> AllocatedAssetCount { get; set; }

        /// <summary>The Machine Series (e.g. "E2", "N2")</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineSeries")]
        public virtual MachineSeries MachineSeries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A set of findings that applies to assets destined for Sole-Tenant nodes.</summary>
    public class ReportSummarySoleTenantFinding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Count of assets which are allocated</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allocatedAssetCount")]
        public virtual System.Nullable<long> AllocatedAssetCount { get; set; }

        /// <summary>Set of regions in which the assets are allocated</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allocatedRegions")]
        public virtual System.Collections.Generic.IList<string> AllocatedRegions { get; set; }

        /// <summary>Set of per-nodetype allocation records</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeAllocations")]
        public virtual System.Collections.Generic.IList<ReportSummarySoleTenantNodeAllocation> NodeAllocations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the assets allocated to a specific Sole-Tenant node type.</summary>
    public class ReportSummarySoleTenantNodeAllocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Count of assets allocated to these nodes</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allocatedAssetCount")]
        public virtual System.Nullable<long> AllocatedAssetCount { get; set; }

        /// <summary>Sole Tenant node type, e.g. "m3-node-128-3904"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("node")]
        public virtual SoleTenantNodeType Node { get; set; }

        /// <summary>Count of this node type to be provisioned</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeCount")]
        public virtual System.Nullable<long> NodeCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Utilization Chart is a specific type of visualization which displays a metric classified into "Used" and "Free"
    /// buckets.
    /// </summary>
    public class ReportSummaryUtilizationChartData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Aggregate value which falls into the "Free" bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("free")]
        public virtual System.Nullable<long> Free { get; set; }

        /// <summary>Aggregate value which falls into the "Used" bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("used")]
        public virtual System.Nullable<long> Used { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A set of findings that applies to assets destined for VMWare Engine.</summary>
    public class ReportSummaryVmwareEngineFinding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Count of assets which are allocated</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allocatedAssetCount")]
        public virtual System.Nullable<long> AllocatedAssetCount { get; set; }

        /// <summary>Set of regions in which the assets were allocated</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allocatedRegions")]
        public virtual System.Collections.Generic.IList<string> AllocatedRegions { get; set; }

        /// <summary>Set of per-nodetype allocation records</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeAllocations")]
        public virtual System.Collections.Generic.IList<ReportSummaryVmwareNodeAllocation> NodeAllocations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A VMWare Engine Node</summary>
    public class ReportSummaryVmwareNode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Code to identify VMware Engine node series, e.g. "ve1-standard-72". Based on the displayName of
        /// cloud.google.com/vmware-engine/docs/reference/rest/v1/projects.locations.nodeTypes
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents assets allocated to a specific VMWare Node type.</summary>
    public class ReportSummaryVmwareNodeAllocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Count of assets allocated to these nodes</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allocatedAssetCount")]
        public virtual System.Nullable<long> AllocatedAssetCount { get; set; }

        /// <summary>Count of this node type to be provisioned</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeCount")]
        public virtual System.Nullable<long> NodeCount { get; set; }

        /// <summary>VMWare node type, e.g. "ve1-standard-72"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmwareNode")]
        public virtual ReportSummaryVmwareNode VmwareNode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to run an import job.</summary>
    public class RunImportJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if you must retry
        /// your request, the server will know to ignore the request if it has already been completed. The server will
        /// guarantee that for at least 60 minutes after the first request. For example, consider a situation where you
        /// make an initial request and the request times out. If you make the request again with the same request ID,
        /// the server can check if original operation with the same request ID was received, and if so, will ignore the
        /// second request. This prevents clients from accidentally creating duplicate commitments. The request ID must
        /// be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Guest OS running process details.</summary>
    public class RunningProcess : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Process extended attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, string> Attributes { get; set; }

        /// <summary>Process full command line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cmdline")]
        public virtual string Cmdline { get; set; }

        /// <summary>Process binary path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exePath")]
        public virtual string ExePath { get; set; }

        /// <summary>Process ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pid")]
        public virtual System.Nullable<long> Pid { get; set; }

        /// <summary>User running the process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual string User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of running guest OS processes.</summary>
    public class RunningProcessList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Running process entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<RunningProcess> Entries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Guest OS running service details.</summary>
    public class RunningService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Service command line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cmdline")]
        public virtual string Cmdline { get; set; }

        /// <summary>Service binary path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exePath")]
        public virtual string ExePath { get; set; }

        /// <summary>Service pid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pid")]
        public virtual System.Nullable<long> Pid { get; set; }

        /// <summary>Service name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>Service start mode (OS-agnostic).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startMode")]
        public virtual string StartMode { get; set; }

        /// <summary>Service state (OS-agnostic).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of running guest OS services.</summary>
    public class RunningServiceList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Running service entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<RunningService> Entries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Runtime networking information.</summary>
    public class RuntimeNetworkInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Network connections.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connections")]
        public virtual NetworkConnectionList Connections { get; set; }

        private string _scanTimeRaw;

        private object _scanTime;

        /// <summary>Time of the last network scan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scanTime")]
        public virtual string ScanTimeRaw
        {
            get => _scanTimeRaw;
            set
            {
                _scanTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _scanTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ScanTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ScanTimeDateTimeOffset instead.")]
        public virtual object ScanTime
        {
            get => _scanTime;
            set
            {
                _scanTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _scanTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ScanTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ScanTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ScanTimeRaw);
            set => ScanTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to send a discovery client heartbeat.</summary>
    public class SendDiscoveryClientHeartbeatRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Errors affecting client functionality.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<Status> Errors { get; set; }

        /// <summary>Optional. Client application version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the Migration Center settings related to the project.</summary>
    public class Settings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Disable Cloud Logging for the Migration Center API. Users are billed for the logs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableCloudLogging")]
        public virtual System.Nullable<bool> DisableCloudLogging { get; set; }

        /// <summary>Output only. The name of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The preference set used by default for a project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preferenceSet")]
        public virtual string PreferenceSet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Preferences concerning Sole Tenancy nodes and VMs.</summary>
    public class SoleTenancyPreferences : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Commitment plan to consider when calculating costs for virtual machine insights and recommendations. If you
        /// are unsure which value to set, a 3 year commitment plan is often a good value to start with.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitmentPlan")]
        public virtual string CommitmentPlan { get; set; }

        /// <summary>CPU overcommit ratio. Acceptable values are between 1.0 and 2.0 inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuOvercommitRatio")]
        public virtual System.Nullable<double> CpuOvercommitRatio { get; set; }

        /// <summary>Sole Tenancy nodes maintenance policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostMaintenancePolicy")]
        public virtual string HostMaintenancePolicy { get; set; }

        /// <summary>
        /// A list of sole tenant node types. An empty list means that all possible node types will be considered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeTypes")]
        public virtual System.Collections.Generic.IList<SoleTenantNodeType> NodeTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Sole Tenant node type.</summary>
    public class SoleTenantNodeType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Name of the Sole Tenant node. Consult https://cloud.google.com/compute/docs/nodes/sole-tenant-nodes
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeName")]
        public virtual string NodeName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Source represents an object from which asset information is streamed to Migration Center.</summary>
    public class Source : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The timestamp when the source was created.</summary>
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

        /// <summary>Free-text description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>User-friendly display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. The number of frames that were reported by the source and contained errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorFrameCount")]
        public virtual System.Nullable<int> ErrorFrameCount { get; set; }

        /// <summary>If `true`, the source is managed by other service(s).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managed")]
        public virtual System.Nullable<bool> Managed { get; set; }

        /// <summary>Output only. The full name of the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Number of frames that are still being processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingFrameCount")]
        public virtual System.Nullable<int> PendingFrameCount { get; set; }

        /// <summary>
        /// The information confidence of the source. The higher the value, the higher the confidence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual System.Nullable<int> Priority { get; set; }

        /// <summary>Output only. The state of the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Data source type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The timestamp when the source was last updated.</summary>
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

    /// <summary>Specific details for a Microsoft SQL Server database deployment.</summary>
    public class SqlServerDatabaseDeployment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. List of SQL Server features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("features")]
        public virtual System.Collections.Generic.IList<SqlServerFeature> Features { get; set; }

        /// <summary>Optional. List of SQL Server server flags.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverFlags")]
        public virtual System.Collections.Generic.IList<SqlServerServerFlag> ServerFlags { get; set; }

        /// <summary>Optional. List of SQL Server trace flags.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traceFlags")]
        public virtual System.Collections.Generic.IList<SqlServerTraceFlag> TraceFlags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SQL Server feature details.</summary>
    public class SqlServerFeature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Field enabled is set when a feature is used on the source deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>Required. The feature name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("featureName")]
        public virtual string FeatureName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specific details for a SqlServer database.</summary>
    public class SqlServerSchemaDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. SqlServer number of CLR objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clrObjectCount")]
        public virtual System.Nullable<int> ClrObjectCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SQL Server server flag details.</summary>
    public class SqlServerServerFlag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The server flag name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverFlagName")]
        public virtual string ServerFlagName { get; set; }

        /// <summary>Required. The server flag value set by the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>
        /// Required. The server flag actual value. If `value_in_use` is different from `value` it means that either the
        /// configuration change was not applied or it is an expected behavior. See SQL Server documentation for more
        /// details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueInUse")]
        public virtual string ValueInUse { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SQL Server trace flag details.</summary>
    public class SqlServerTraceFlag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The trace flag scope.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>Required. The trace flag name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traceFlagName")]
        public virtual string TraceFlagName { get; set; }

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

    /// <summary>A request to update an asset.</summary>
    public class UpdateAssetRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The resource being updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public virtual Asset Asset { get; set; }

        /// <summary>
        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if you must retry
        /// your request, the server will know to ignore the request if it has already been completed. The server will
        /// guarantee that for at least 60 minutes since the first request. For example, consider a situation where you
        /// make an initial request and the request times out. If you make the request again with the same request ID,
        /// the server can check if original operation with the same request ID was received, and if so, will ignore the
        /// second request. This prevents clients from accidentally creating duplicate commitments. The request ID must
        /// be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>
        /// Required. Field mask is used to specify the fields to be overwritten in the `Asset` resource by the update.
        /// The values specified in the `update_mask` field are relative to the resource, not the full request. A field
        /// will be overwritten if it is in the mask. A single * value in the mask lets you to overwrite all fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that contains a URI to which a data file can be uploaded.</summary>
    public class UploadFileInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The headers that were used to sign the URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IDictionary<string, string> Headers { get; set; }

        /// <summary>Output only. Upload URI for the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signedUri")]
        public virtual string SignedUri { get; set; }

        private string _uriExpirationTimeRaw;

        private object _uriExpirationTime;

        /// <summary>Output only. Expiration time of the upload URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uriExpirationTime")]
        public virtual string UriExpirationTimeRaw
        {
            get => _uriExpirationTimeRaw;
            set
            {
                _uriExpirationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _uriExpirationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UriExpirationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UriExpirationTimeDateTimeOffset instead.")]
        public virtual object UriExpirationTime
        {
            get => _uriExpirationTime;
            set
            {
                _uriExpirationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _uriExpirationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="UriExpirationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UriExpirationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UriExpirationTimeRaw);
            set => UriExpirationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to validate an import job.</summary>
    public class ValidateImportJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if you must retry
        /// your request, the server will know to ignore the request if it has already been completed. The server will
        /// guarantee that for at least 60 minutes after the first request. For example, consider a situation where you
        /// make an initial request and the request times out. If you make the request again with the same request ID,
        /// the server can check if original operation with the same request ID was received, and if so, will ignore the
        /// second request. This prevents clients from accidentally creating duplicate commitments. The request ID must
        /// be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that aggregates errors across import job files.</summary>
    public class ValidationReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of errors found in files.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileValidations")]
        public virtual System.Collections.Generic.IList<FileValidationReport> FileValidations { get; set; }

        /// <summary>List of job level errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobErrors")]
        public virtual System.Collections.Generic.IList<ImportError> JobErrors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// VirtualMachinePreferences enables you to create sets of assumptions, for example, a geographical location and
    /// pricing track, for your migrated virtual machines. The set of preferences influence recommendations for
    /// migrating virtual machine assets.
    /// </summary>
    public class VirtualMachinePreferences : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Commitment plan to consider when calculating costs for virtual machine insights and recommendations. If you
        /// are unsure which value to set, a 3 year commitment plan is often a good value to start with.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitmentPlan")]
        public virtual string CommitmentPlan { get; set; }

        /// <summary>
        /// Compute Engine preferences concern insights and recommendations for Compute Engine target.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeEnginePreferences")]
        public virtual ComputeEnginePreferences ComputeEnginePreferences { get; set; }

        /// <summary>
        /// Region preferences for assets using this preference set. If you are unsure which value to set, the migration
        /// service API region is often a good value to start with.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionPreferences")]
        public virtual RegionPreferences RegionPreferences { get; set; }

        /// <summary>
        /// Sizing optimization strategy specifies the preferred strategy used when extrapolating usage data to
        /// calculate insights and recommendations for a virtual machine. If you are unsure which value to set, a
        /// moderate sizing optimization strategy is often a good value to start with.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizingOptimizationStrategy")]
        public virtual string SizingOptimizationStrategy { get; set; }

        /// <summary>Preferences concerning Sole Tenant nodes and virtual machines.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("soleTenancyPreferences")]
        public virtual SoleTenancyPreferences SoleTenancyPreferences { get; set; }

        /// <summary>
        /// Target product for assets using this preference set. Specify either target product or business goal, but not
        /// both.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetProduct")]
        public virtual string TargetProduct { get; set; }

        /// <summary>Preferences concerning insights and recommendations for Google Cloud VMware Engine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmwareEnginePreferences")]
        public virtual VmwareEnginePreferences VmwareEnginePreferences { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VMware disk config details.</summary>
    public class VmwareDiskConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>VMDK backing type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backingType")]
        public virtual string BackingType { get; set; }

        /// <summary>RDM compatibility mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rdmCompatibility")]
        public virtual string RdmCompatibility { get; set; }

        /// <summary>Is VMDK shared with other VMs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shared")]
        public virtual System.Nullable<bool> Shared { get; set; }

        /// <summary>VMDK disk mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmdkMode")]
        public virtual string VmdkMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The user preferences relating to Google Cloud VMware Engine target platform.</summary>
    public class VmwareEnginePreferences : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Commitment plan to consider when calculating costs for virtual machine insights and recommendations. If you
        /// are unsure which value to set, a 3 year commitment plan is often a good value to start with.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitmentPlan")]
        public virtual string CommitmentPlan { get; set; }

        /// <summary>CPU overcommit ratio. Acceptable values are between 1.0 and 8.0, with 0.1 increment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuOvercommitRatio")]
        public virtual System.Nullable<double> CpuOvercommitRatio { get; set; }

        /// <summary>Memory overcommit ratio. Acceptable values are 1.0, 1.25, 1.5, 1.75 and 2.0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryOvercommitRatio")]
        public virtual System.Nullable<double> MemoryOvercommitRatio { get; set; }

        /// <summary>
        /// The Deduplication and Compression ratio is based on the logical (Used Before) space required to store data
        /// before applying deduplication and compression, in relation to the physical (Used After) space required after
        /// applying deduplication and compression. Specifically, the ratio is the Used Before space divided by the Used
        /// After space. For example, if the Used Before space is 3 GB, but the physical Used After space is 1 GB, the
        /// deduplication and compression ratio is 3x. Acceptable values are between 1.0 and 4.0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageDeduplicationCompressionRatio")]
        public virtual System.Nullable<double> StorageDeduplicationCompressionRatio { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VMware specific details.</summary>
    public class VmwarePlatformDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the ESX is hyperthreaded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("esxHyperthreading")]
        public virtual string EsxHyperthreading { get; set; }

        /// <summary>ESX version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("esxVersion")]
        public virtual string EsxVersion { get; set; }

        /// <summary>
        /// VMware os enum -
        /// https://vdc-repo.vmware.com/vmwb-repository/dcr-public/da47f910-60ac-438b-8b9b-6122f4d14524/16b7274a-bf8b-4b4c-a05e-746f2aa93c8c/doc/vim.vm.GuestOsDescriptor.GuestOsIdentifier.html.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osid")]
        public virtual string Osid { get; set; }

        /// <summary>Folder name in vCenter where asset resides.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vcenterFolder")]
        public virtual string VcenterFolder { get; set; }

        /// <summary>vCenter URI used in collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vcenterUri")]
        public virtual string VcenterUri { get; set; }

        /// <summary>vCenter version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vcenterVersion")]
        public virtual string VcenterVersion { get; set; }

        /// <summary>vCenter VM ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vcenterVmId")]
        public virtual string VcenterVmId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
