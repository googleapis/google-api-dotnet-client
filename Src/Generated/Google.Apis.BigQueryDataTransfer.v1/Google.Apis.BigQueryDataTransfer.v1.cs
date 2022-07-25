// Copyright 2022 Google LLC
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

namespace Google.Apis.BigQueryDataTransfer.v1
{
    /// <summary>The BigQueryDataTransfer Service.</summary>
    public class BigQueryDataTransferService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public BigQueryDataTransferService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public BigQueryDataTransferService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "bigquerydatatransfer";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://bigquerydatatransfer.googleapis.com/";
        #else
            "https://bigquerydatatransfer.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://bigquerydatatransfer.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the BigQuery Data Transfer API.</summary>
        public class Scope
        {
            /// <summary>
            /// View and manage your data in Google BigQuery and see the email address for your Google Account
            /// </summary>
            public static string Bigquery = "https://www.googleapis.com/auth/bigquery";

            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>
            /// View your data across Google Cloud services and see the email address of your Google Account
            /// </summary>
            public static string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the BigQuery Data Transfer API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// View and manage your data in Google BigQuery and see the email address for your Google Account
            /// </summary>
            public const string Bigquery = "https://www.googleapis.com/auth/bigquery";

            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>
            /// View your data across Google Cloud services and see the email address of your Google Account
            /// </summary>
            public const string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for BigQueryDataTransfer requests.</summary>
    public abstract class BigQueryDataTransferBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new BigQueryDataTransferBaseServiceRequest instance.</summary>
        protected BigQueryDataTransferBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes BigQueryDataTransfer parameter list.</summary>
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
            DataSources = new DataSourcesResource(service);
            Locations = new LocationsResource(service);
            TransferConfigs = new TransferConfigsResource(service);
        }

        /// <summary>Gets the DataSources resource.</summary>
        public virtual DataSourcesResource DataSources { get; }

        /// <summary>The "dataSources" collection of methods.</summary>
        public class DataSourcesResource
        {
            private const string Resource = "dataSources";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DataSourcesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Returns true if valid credentials exist for the given data source and requesting user.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The data source in the form: `projects/{project_id}/dataSources/{data_source_id}` or
            /// `projects/{project_id}/locations/{location_id}/dataSources/{data_source_id}`.
            /// </param>
            public virtual CheckValidCredsRequest CheckValidCreds(Google.Apis.BigQueryDataTransfer.v1.Data.CheckValidCredsRequest body, string name)
            {
                return new CheckValidCredsRequest(service, body, name);
            }

            /// <summary>
            /// Returns true if valid credentials exist for the given data source and requesting user.
            /// </summary>
            public class CheckValidCredsRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.CheckValidCredsResponse>
            {
                /// <summary>Constructs a new CheckValidCreds request.</summary>
                public CheckValidCredsRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryDataTransfer.v1.Data.CheckValidCredsRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The data source in the form: `projects/{project_id}/dataSources/{data_source_id}` or
                /// `projects/{project_id}/locations/{location_id}/dataSources/{data_source_id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.BigQueryDataTransfer.v1.Data.CheckValidCredsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "checkValidCreds";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:checkValidCreds";

                /// <summary>Initializes CheckValidCreds parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/dataSources/[^/]+$",
                    });
                }
            }

            /// <summary>Retrieves a supported data source and returns its settings.</summary>
            /// <param name="name">
            /// Required. The field will contain name of the resource requested, for example:
            /// `projects/{project_id}/dataSources/{data_source_id}` or
            /// `projects/{project_id}/locations/{location_id}/dataSources/{data_source_id}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Retrieves a supported data source and returns its settings.</summary>
            public class GetRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.DataSource>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The field will contain name of the resource requested, for example:
                /// `projects/{project_id}/dataSources/{data_source_id}` or
                /// `projects/{project_id}/locations/{location_id}/dataSources/{data_source_id}`
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
                        Pattern = @"^projects/[^/]+/dataSources/[^/]+$",
                    });
                }
            }

            /// <summary>Lists supported data sources and returns their settings.</summary>
            /// <param name="parent">
            /// Required. The BigQuery project id for which data sources should be returned. Must be in the form:
            /// `projects/{project_id}` or `projects/{project_id}/locations/{location_id}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists supported data sources and returns their settings.</summary>
            public class ListRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.ListDataSourcesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The BigQuery project id for which data sources should be returned. Must be in the form:
                /// `projects/{project_id}` or `projects/{project_id}/locations/{location_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Page size. The default page size is the maximum value of 1000 results.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Pagination token, which can be used to request a specific page of `ListDataSourcesRequest` list
                /// results. For multiple-page results, `ListDataSourcesResponse` outputs a `next_page` token, which can
                /// be used as the `page_token` value to request the next page of list results.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/dataSources";

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
                DataSources = new DataSourcesResource(service);
                TransferConfigs = new TransferConfigsResource(service);
            }

            /// <summary>Gets the DataSources resource.</summary>
            public virtual DataSourcesResource DataSources { get; }

            /// <summary>The "dataSources" collection of methods.</summary>
            public class DataSourcesResource
            {
                private const string Resource = "dataSources";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DataSourcesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Returns true if valid credentials exist for the given data source and requesting user.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The data source in the form: `projects/{project_id}/dataSources/{data_source_id}` or
                /// `projects/{project_id}/locations/{location_id}/dataSources/{data_source_id}`.
                /// </param>
                public virtual CheckValidCredsRequest CheckValidCreds(Google.Apis.BigQueryDataTransfer.v1.Data.CheckValidCredsRequest body, string name)
                {
                    return new CheckValidCredsRequest(service, body, name);
                }

                /// <summary>
                /// Returns true if valid credentials exist for the given data source and requesting user.
                /// </summary>
                public class CheckValidCredsRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.CheckValidCredsResponse>
                {
                    /// <summary>Constructs a new CheckValidCreds request.</summary>
                    public CheckValidCredsRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryDataTransfer.v1.Data.CheckValidCredsRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The data source in the form: `projects/{project_id}/dataSources/{data_source_id}` or
                    /// `projects/{project_id}/locations/{location_id}/dataSources/{data_source_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigQueryDataTransfer.v1.Data.CheckValidCredsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "checkValidCreds";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:checkValidCreds";

                    /// <summary>Initializes CheckValidCreds parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/dataSources/[^/]+$",
                        });
                    }
                }

                /// <summary>Retrieves a supported data source and returns its settings.</summary>
                /// <param name="name">
                /// Required. The field will contain name of the resource requested, for example:
                /// `projects/{project_id}/dataSources/{data_source_id}` or
                /// `projects/{project_id}/locations/{location_id}/dataSources/{data_source_id}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Retrieves a supported data source and returns its settings.</summary>
                public class GetRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.DataSource>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The field will contain name of the resource requested, for example:
                    /// `projects/{project_id}/dataSources/{data_source_id}` or
                    /// `projects/{project_id}/locations/{location_id}/dataSources/{data_source_id}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/dataSources/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists supported data sources and returns their settings.</summary>
                /// <param name="parent">
                /// Required. The BigQuery project id for which data sources should be returned. Must be in the form:
                /// `projects/{project_id}` or `projects/{project_id}/locations/{location_id}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists supported data sources and returns their settings.</summary>
                public class ListRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.ListDataSourcesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The BigQuery project id for which data sources should be returned. Must be in the
                    /// form: `projects/{project_id}` or `projects/{project_id}/locations/{location_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Page size. The default page size is the maximum value of 1000 results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Pagination token, which can be used to request a specific page of `ListDataSourcesRequest` list
                    /// results. For multiple-page results, `ListDataSourcesResponse` outputs a `next_page` token, which
                    /// can be used as the `page_token` value to request the next page of list results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/dataSources";

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

            /// <summary>Gets the TransferConfigs resource.</summary>
            public virtual TransferConfigsResource TransferConfigs { get; }

            /// <summary>The "transferConfigs" collection of methods.</summary>
            public class TransferConfigsResource
            {
                private const string Resource = "transferConfigs";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public TransferConfigsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Runs = new RunsResource(service);
                }

                /// <summary>Gets the Runs resource.</summary>
                public virtual RunsResource Runs { get; }

                /// <summary>The "runs" collection of methods.</summary>
                public class RunsResource
                {
                    private const string Resource = "runs";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public RunsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        TransferLogs = new TransferLogsResource(service);
                    }

                    /// <summary>Gets the TransferLogs resource.</summary>
                    public virtual TransferLogsResource TransferLogs { get; }

                    /// <summary>The "transferLogs" collection of methods.</summary>
                    public class TransferLogsResource
                    {
                        private const string Resource = "transferLogs";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public TransferLogsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Returns log messages for the transfer run.</summary>
                        /// <param name="parent">
                        /// Required. Transfer run name in the form:
                        /// `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}` or
                        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>Returns log messages for the transfer run.</summary>
                        public class ListRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.ListTransferLogsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Transfer run name in the form:
                            /// `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}` or
                            /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Message types to return. If not populated - INFO, WARNING and ERROR messages are
                            /// returned.
                            /// </summary>
                            /// <remarks>
                            /// Use this property to set a single value for the parameter, or
                            /// <see cref="MessageTypesList"/> to set multiple values. Do not set both properties.
                            /// </remarks>
                            [Google.Apis.Util.RequestParameterAttribute("messageTypes", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<MessageTypesEnum> MessageTypes { get; set; }

                            /// <summary>
                            /// Message types to return. If not populated - INFO, WARNING and ERROR messages are
                            /// returned.
                            /// </summary>
                            /// <remarks>
                            /// Use this property to set one or more values for the parameter. Do not set both this
                            /// property and <see cref="MessageTypes"/>.
                            /// </remarks>
                            [Google.Apis.Util.RequestParameterAttribute("messageTypes", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual Google.Apis.Util.Repeatable<MessageTypesEnum> MessageTypesList { get; set; }

                            /// <summary>
                            /// Message types to return. If not populated - INFO, WARNING and ERROR messages are
                            /// returned.
                            /// </summary>
                            public enum MessageTypesEnum
                            {
                                /// <summary>No severity specified.</summary>
                                [Google.Apis.Util.StringValueAttribute("MESSAGE_SEVERITY_UNSPECIFIED")]
                                MESSAGESEVERITYUNSPECIFIED = 0,

                                /// <summary>Informational message.</summary>
                                [Google.Apis.Util.StringValueAttribute("INFO")]
                                INFO = 1,

                                /// <summary>Warning message.</summary>
                                [Google.Apis.Util.StringValueAttribute("WARNING")]
                                WARNING = 2,

                                /// <summary>Error message.</summary>
                                [Google.Apis.Util.StringValueAttribute("ERROR")]
                                ERROR = 3,
                            }

                            /// <summary>
                            /// Page size. The default page size is the maximum value of 1000 results.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Pagination token, which can be used to request a specific page of
                            /// `ListTransferLogsRequest` list results. For multiple-page results,
                            /// `ListTransferLogsResponse` outputs a `next_page` token, which can be used as the
                            /// `page_token` value to request the next page of list results.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/transferLogs";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/transferConfigs/[^/]+/runs/[^/]+$",
                                });
                                RequestParameters.Add("messageTypes", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "messageTypes",
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

                    /// <summary>Deletes the specified transfer run.</summary>
                    /// <param name="name">
                    /// Required. The field will contain name of the resource requested, for example:
                    /// `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}` or
                    /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes the specified transfer run.</summary>
                    public class DeleteRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The field will contain name of the resource requested, for example:
                        /// `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}` or
                        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/transferConfigs/[^/]+/runs/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns information about the particular transfer run.</summary>
                    /// <param name="name">
                    /// Required. The field will contain name of the resource requested, for example:
                    /// `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}` or
                    /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Returns information about the particular transfer run.</summary>
                    public class GetRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.TransferRun>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The field will contain name of the resource requested, for example:
                        /// `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}` or
                        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/transferConfigs/[^/]+/runs/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns information about running and completed transfer runs.</summary>
                    /// <param name="parent">
                    /// Required. Name of transfer configuration for which transfer runs should be retrieved. Format of
                    /// transfer configuration resource name is: `projects/{project_id}/transferConfigs/{config_id}` or
                    /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Returns information about running and completed transfer runs.</summary>
                    public class ListRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.ListTransferRunsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Name of transfer configuration for which transfer runs should be retrieved. Format
                        /// of transfer configuration resource name is:
                        /// `projects/{project_id}/transferConfigs/{config_id}` or
                        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Page size. The default page size is the maximum value of 1000 results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Pagination token, which can be used to request a specific page of `ListTransferRunsRequest`
                        /// list results. For multiple-page results, `ListTransferRunsResponse` outputs a `next_page`
                        /// token, which can be used as the `page_token` value to request the next page of list results.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Indicates how run attempts are to be pulled.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("runAttempt", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<RunAttemptEnum> RunAttempt { get; set; }

                        /// <summary>Indicates how run attempts are to be pulled.</summary>
                        public enum RunAttemptEnum
                        {
                            /// <summary>All runs should be returned.</summary>
                            [Google.Apis.Util.StringValueAttribute("RUN_ATTEMPT_UNSPECIFIED")]
                            RUNATTEMPTUNSPECIFIED = 0,

                            /// <summary>Only latest run per day should be returned.</summary>
                            [Google.Apis.Util.StringValueAttribute("LATEST")]
                            LATEST = 1,
                        }

                        /// <summary>When specified, only transfer runs with requested states are returned.</summary>
                        /// <remarks>
                        /// Use this property to set a single value for the parameter, or <see cref="StatesList"/> to
                        /// set multiple values. Do not set both properties.
                        /// </remarks>
                        [Google.Apis.Util.RequestParameterAttribute("states", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<StatesEnum> States { get; set; }

                        /// <summary>When specified, only transfer runs with requested states are returned.</summary>
                        /// <remarks>
                        /// Use this property to set one or more values for the parameter. Do not set both this property
                        /// and <see cref="States"/>.
                        /// </remarks>
                        [Google.Apis.Util.RequestParameterAttribute("states", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual Google.Apis.Util.Repeatable<StatesEnum> StatesList { get; set; }

                        /// <summary>When specified, only transfer runs with requested states are returned.</summary>
                        public enum StatesEnum
                        {
                            /// <summary>State placeholder (0).</summary>
                            [Google.Apis.Util.StringValueAttribute("TRANSFER_STATE_UNSPECIFIED")]
                            TRANSFERSTATEUNSPECIFIED = 0,

                            /// <summary>
                            /// Data transfer is scheduled and is waiting to be picked up by data transfer backend (2).
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("PENDING")]
                            PENDING = 1,

                            /// <summary>Data transfer is in progress (3).</summary>
                            [Google.Apis.Util.StringValueAttribute("RUNNING")]
                            RUNNING = 2,

                            /// <summary>Data transfer completed successfully (4).</summary>
                            [Google.Apis.Util.StringValueAttribute("SUCCEEDED")]
                            SUCCEEDED = 3,

                            /// <summary>Data transfer failed (5).</summary>
                            [Google.Apis.Util.StringValueAttribute("FAILED")]
                            FAILED = 4,

                            /// <summary>Data transfer is cancelled (6).</summary>
                            [Google.Apis.Util.StringValueAttribute("CANCELLED")]
                            CANCELLED = 5,
                        }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/runs";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/transferConfigs/[^/]+$",
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
                            RequestParameters.Add("runAttempt", new Google.Apis.Discovery.Parameter
                            {
                                Name = "runAttempt",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("states", new Google.Apis.Discovery.Parameter
                            {
                                Name = "states",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>Creates a new data transfer configuration.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The BigQuery project id where the transfer configuration should be created. Must be in the
                /// format projects/{project_id}/locations/{location_id} or projects/{project_id}. If specified location
                /// and location of the destination bigquery dataset do not match - the request will fail.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.BigQueryDataTransfer.v1.Data.TransferConfig body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new data transfer configuration.</summary>
                public class CreateRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.TransferConfig>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryDataTransfer.v1.Data.TransferConfig body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The BigQuery project id where the transfer configuration should be created. Must be in
                    /// the format projects/{project_id}/locations/{location_id} or projects/{project_id}. If specified
                    /// location and location of the destination bigquery dataset do not match - the request will fail.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional OAuth2 authorization code to use with this transfer configuration. This is required
                    /// only if `transferConfig.dataSourceId` is 'youtube_channel' and new credentials are needed, as
                    /// indicated by `CheckValidCreds`. In order to obtain authorization_code, make a request to the
                    /// following URL: https://www.gstatic.com/bigquerydatatransfer/oauthz/auth?
                    /// client_id=client_id&amp;amp;scope=data_source_scopes
                    /// &amp;amp;redirect_uri=urn:ietf:wg:oauth:2.0:oob&amp;amp;response_type=authorization_code * The
                    /// client_id is the OAuth client_id of the a data source as returned by ListDataSources method. *
                    /// data_source_scopes are the scopes returned by ListDataSources method. Note that this should not
                    /// be set when `service_account_name` is used to create the transfer config.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("authorizationCode", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string AuthorizationCode { get; set; }

                    /// <summary>
                    /// Optional service account name. If this field is set, the transfer config will be created with
                    /// this service account's credentials. It requires that the requesting user calling this API has
                    /// permissions to act as this service account. Note that not all data sources support service
                    /// account credentials when creating a transfer config. For the latest list of data sources, read
                    /// about [using service
                    /// accounts](https://cloud.google.com/bigquery-transfer/docs/use-service-accounts).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("serviceAccountName", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ServiceAccountName { get; set; }

                    /// <summary>
                    /// Optional version info. This is required only if `transferConfig.dataSourceId` is not
                    /// 'youtube_channel' and new credentials are needed, as indicated by `CheckValidCreds`. In order to
                    /// obtain version info, make a request to the following URL:
                    /// https://www.gstatic.com/bigquerydatatransfer/oauthz/auth?
                    /// client_id=client_id&amp;amp;scope=data_source_scopes
                    /// &amp;amp;redirect_uri=urn:ietf:wg:oauth:2.0:oob&amp;amp;response_type=version_info * The
                    /// client_id is the OAuth client_id of the a data source as returned by ListDataSources method. *
                    /// data_source_scopes are the scopes returned by ListDataSources method. Note that this should not
                    /// be set when `service_account_name` is used to create the transfer config.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("versionInfo", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string VersionInfo { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigQueryDataTransfer.v1.Data.TransferConfig Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/transferConfigs";

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
                        RequestParameters.Add("authorizationCode", new Google.Apis.Discovery.Parameter
                        {
                            Name = "authorizationCode",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("serviceAccountName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "serviceAccountName",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("versionInfo", new Google.Apis.Discovery.Parameter
                        {
                            Name = "versionInfo",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes a data transfer configuration, including any associated transfer runs and logs.
                /// </summary>
                /// <param name="name">
                /// Required. The field will contain name of the resource requested, for example:
                /// `projects/{project_id}/transferConfigs/{config_id}` or
                /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a data transfer configuration, including any associated transfer runs and logs.
                /// </summary>
                public class DeleteRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The field will contain name of the resource requested, for example:
                    /// `projects/{project_id}/transferConfigs/{config_id}` or
                    /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/transferConfigs/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns information about a data transfer config.</summary>
                /// <param name="name">
                /// Required. The field will contain name of the resource requested, for example:
                /// `projects/{project_id}/transferConfigs/{config_id}` or
                /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Returns information about a data transfer config.</summary>
                public class GetRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.TransferConfig>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The field will contain name of the resource requested, for example:
                    /// `projects/{project_id}/transferConfigs/{config_id}` or
                    /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/transferConfigs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns information about all transfer configs owned by a project in the specified location.
                /// </summary>
                /// <param name="parent">
                /// Required. The BigQuery project id for which transfer configs should be returned:
                /// `projects/{project_id}` or `projects/{project_id}/locations/{location_id}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Returns information about all transfer configs owned by a project in the specified location.
                /// </summary>
                public class ListRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.ListTransferConfigsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The BigQuery project id for which transfer configs should be returned:
                    /// `projects/{project_id}` or `projects/{project_id}/locations/{location_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>When specified, only configurations of requested data sources are returned.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("dataSourceIds", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> DataSourceIds { get; set; }

                    /// <summary>Page size. The default page size is the maximum value of 1000 results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Pagination token, which can be used to request a specific page of `ListTransfersRequest` list
                    /// results. For multiple-page results, `ListTransfersResponse` outputs a `next_page` token, which
                    /// can be used as the `page_token` value to request the next page of list results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/transferConfigs";

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
                        RequestParameters.Add("dataSourceIds", new Google.Apis.Discovery.Parameter
                        {
                            Name = "dataSourceIds",
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
                /// Updates a data transfer configuration. All fields must be set, even if they are not updated.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The resource name of the transfer config. Transfer config names have the form
                /// `projects/{project_id}/locations/{region}/transferConfigs/{config_id}`. Where `config_id` is usually
                /// a uuid, even though it is not guaranteed or required. The name is ignored when creating a transfer
                /// config.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.BigQueryDataTransfer.v1.Data.TransferConfig body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates a data transfer configuration. All fields must be set, even if they are not updated.
                /// </summary>
                public class PatchRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.TransferConfig>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryDataTransfer.v1.Data.TransferConfig body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name of the transfer config. Transfer config names have the form
                    /// `projects/{project_id}/locations/{region}/transferConfigs/{config_id}`. Where `config_id` is
                    /// usually a uuid, even though it is not guaranteed or required. The name is ignored when creating
                    /// a transfer config.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional OAuth2 authorization code to use with this transfer configuration. This is required
                    /// only if `transferConfig.dataSourceId` is 'youtube_channel' and new credentials are needed, as
                    /// indicated by `CheckValidCreds`. In order to obtain authorization_code, make a request to the
                    /// following URL: https://www.gstatic.com/bigquerydatatransfer/oauthz/auth?
                    /// client_id=client_id&amp;amp;scope=data_source_scopes
                    /// &amp;amp;redirect_uri=urn:ietf:wg:oauth:2.0:oob&amp;amp;response_type=authorization_code * The
                    /// client_id is the OAuth client_id of the a data source as returned by ListDataSources method. *
                    /// data_source_scopes are the scopes returned by ListDataSources method. Note that this should not
                    /// be set when `service_account_name` is used to update the transfer config.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("authorizationCode", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string AuthorizationCode { get; set; }

                    /// <summary>
                    /// Optional service account name. If this field is set, the transfer config will be created with
                    /// this service account's credentials. It requires that the requesting user calling this API has
                    /// permissions to act as this service account. Note that not all data sources support service
                    /// account credentials when creating a transfer config. For the latest list of data sources, read
                    /// about [using service
                    /// accounts](https://cloud.google.com/bigquery-transfer/docs/use-service-accounts).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("serviceAccountName", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ServiceAccountName { get; set; }

                    /// <summary>Required. Required list of fields to be updated in this request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// Optional version info. This is required only if `transferConfig.dataSourceId` is not
                    /// 'youtube_channel' and new credentials are needed, as indicated by `CheckValidCreds`. In order to
                    /// obtain version info, make a request to the following URL:
                    /// https://www.gstatic.com/bigquerydatatransfer/oauthz/auth?
                    /// client_id=client_id&amp;amp;scope=data_source_scopes
                    /// &amp;amp;redirect_uri=urn:ietf:wg:oauth:2.0:oob&amp;amp;response_type=version_info * The
                    /// client_id is the OAuth client_id of the a data source as returned by ListDataSources method. *
                    /// data_source_scopes are the scopes returned by ListDataSources method. Note that this should not
                    /// be set when `service_account_name` is used to update the transfer config.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("versionInfo", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string VersionInfo { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigQueryDataTransfer.v1.Data.TransferConfig Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/transferConfigs/[^/]+$",
                        });
                        RequestParameters.Add("authorizationCode", new Google.Apis.Discovery.Parameter
                        {
                            Name = "authorizationCode",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("serviceAccountName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "serviceAccountName",
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
                        RequestParameters.Add("versionInfo", new Google.Apis.Discovery.Parameter
                        {
                            Name = "versionInfo",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Creates transfer runs for a time range [start_time, end_time]. For each date - or whatever
                /// granularity the data source supports - in the range, one transfer run is created. Note that runs are
                /// created per UTC time in the time range. DEPRECATED: use StartManualTransferRuns instead.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Transfer configuration name in the form:
                /// `projects/{project_id}/transferConfigs/{config_id}` or
                /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`.
                /// </param>
                public virtual ScheduleRunsRequest ScheduleRuns(Google.Apis.BigQueryDataTransfer.v1.Data.ScheduleTransferRunsRequest body, string parent)
                {
                    return new ScheduleRunsRequest(service, body, parent);
                }

                /// <summary>
                /// Creates transfer runs for a time range [start_time, end_time]. For each date - or whatever
                /// granularity the data source supports - in the range, one transfer run is created. Note that runs are
                /// created per UTC time in the time range. DEPRECATED: use StartManualTransferRuns instead.
                /// </summary>
                public class ScheduleRunsRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.ScheduleTransferRunsResponse>
                {
                    /// <summary>Constructs a new ScheduleRuns request.</summary>
                    public ScheduleRunsRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryDataTransfer.v1.Data.ScheduleTransferRunsRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Transfer configuration name in the form:
                    /// `projects/{project_id}/transferConfigs/{config_id}` or
                    /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigQueryDataTransfer.v1.Data.ScheduleTransferRunsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "scheduleRuns";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}:scheduleRuns";

                    /// <summary>Initializes ScheduleRuns parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/transferConfigs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Start manual transfer runs to be executed now with schedule_time equal to current time. The transfer
                /// runs can be created for a time range where the run_time is between start_time (inclusive) and
                /// end_time (exclusive), or for a specific run_time.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Transfer configuration name in the form: `projects/{project_id}/transferConfigs/{config_id}` or
                /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`.
                /// </param>
                public virtual StartManualRunsRequest StartManualRuns(Google.Apis.BigQueryDataTransfer.v1.Data.StartManualTransferRunsRequest body, string parent)
                {
                    return new StartManualRunsRequest(service, body, parent);
                }

                /// <summary>
                /// Start manual transfer runs to be executed now with schedule_time equal to current time. The transfer
                /// runs can be created for a time range where the run_time is between start_time (inclusive) and
                /// end_time (exclusive), or for a specific run_time.
                /// </summary>
                public class StartManualRunsRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.StartManualTransferRunsResponse>
                {
                    /// <summary>Constructs a new StartManualRuns request.</summary>
                    public StartManualRunsRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryDataTransfer.v1.Data.StartManualTransferRunsRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Transfer configuration name in the form: `projects/{project_id}/transferConfigs/{config_id}` or
                    /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigQueryDataTransfer.v1.Data.StartManualTransferRunsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "startManualRuns";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}:startManualRuns";

                    /// <summary>Initializes StartManualRuns parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/transferConfigs/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>
            /// Enroll data sources in a user project. This allows users to create transfer configurations for these
            /// data sources. They will also appear in the ListDataSources RPC and as such, will appear in the [BigQuery
            /// UI](https://console.cloud.google.com/bigquery), and the documents can be found in the public guide for
            /// [BigQuery Web UI](https://cloud.google.com/bigquery/bigquery-web-ui) and [Data Transfer
            /// Service](https://cloud.google.com/bigquery/docs/working-with-transfers).
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">The name of the project resource in the form: `projects/{project_id}`</param>
            public virtual EnrollDataSourcesRequest EnrollDataSources(Google.Apis.BigQueryDataTransfer.v1.Data.EnrollDataSourcesRequest body, string name)
            {
                return new EnrollDataSourcesRequest(service, body, name);
            }

            /// <summary>
            /// Enroll data sources in a user project. This allows users to create transfer configurations for these
            /// data sources. They will also appear in the ListDataSources RPC and as such, will appear in the [BigQuery
            /// UI](https://console.cloud.google.com/bigquery), and the documents can be found in the public guide for
            /// [BigQuery Web UI](https://cloud.google.com/bigquery/bigquery-web-ui) and [Data Transfer
            /// Service](https://cloud.google.com/bigquery/docs/working-with-transfers).
            /// </summary>
            public class EnrollDataSourcesRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.Empty>
            {
                /// <summary>Constructs a new EnrollDataSources request.</summary>
                public EnrollDataSourcesRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryDataTransfer.v1.Data.EnrollDataSourcesRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The name of the project resource in the form: `projects/{project_id}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.BigQueryDataTransfer.v1.Data.EnrollDataSourcesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "enrollDataSources";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:enrollDataSources";

                /// <summary>Initializes EnrollDataSources parameter list.</summary>
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

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.Location>
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
                return new ListRequest(service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.ListLocationsResponse>
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

        /// <summary>Gets the TransferConfigs resource.</summary>
        public virtual TransferConfigsResource TransferConfigs { get; }

        /// <summary>The "transferConfigs" collection of methods.</summary>
        public class TransferConfigsResource
        {
            private const string Resource = "transferConfigs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public TransferConfigsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Runs = new RunsResource(service);
            }

            /// <summary>Gets the Runs resource.</summary>
            public virtual RunsResource Runs { get; }

            /// <summary>The "runs" collection of methods.</summary>
            public class RunsResource
            {
                private const string Resource = "runs";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RunsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    TransferLogs = new TransferLogsResource(service);
                }

                /// <summary>Gets the TransferLogs resource.</summary>
                public virtual TransferLogsResource TransferLogs { get; }

                /// <summary>The "transferLogs" collection of methods.</summary>
                public class TransferLogsResource
                {
                    private const string Resource = "transferLogs";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public TransferLogsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Returns log messages for the transfer run.</summary>
                    /// <param name="parent">
                    /// Required. Transfer run name in the form:
                    /// `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}` or
                    /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Returns log messages for the transfer run.</summary>
                    public class ListRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.ListTransferLogsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Transfer run name in the form:
                        /// `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}` or
                        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Message types to return. If not populated - INFO, WARNING and ERROR messages are returned.
                        /// </summary>
                        /// <remarks>
                        /// Use this property to set a single value for the parameter, or <see cref="MessageTypesList"/>
                        /// to set multiple values. Do not set both properties.
                        /// </remarks>
                        [Google.Apis.Util.RequestParameterAttribute("messageTypes", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<MessageTypesEnum> MessageTypes { get; set; }

                        /// <summary>
                        /// Message types to return. If not populated - INFO, WARNING and ERROR messages are returned.
                        /// </summary>
                        /// <remarks>
                        /// Use this property to set one or more values for the parameter. Do not set both this property
                        /// and <see cref="MessageTypes"/>.
                        /// </remarks>
                        [Google.Apis.Util.RequestParameterAttribute("messageTypes", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual Google.Apis.Util.Repeatable<MessageTypesEnum> MessageTypesList { get; set; }

                        /// <summary>
                        /// Message types to return. If not populated - INFO, WARNING and ERROR messages are returned.
                        /// </summary>
                        public enum MessageTypesEnum
                        {
                            /// <summary>No severity specified.</summary>
                            [Google.Apis.Util.StringValueAttribute("MESSAGE_SEVERITY_UNSPECIFIED")]
                            MESSAGESEVERITYUNSPECIFIED = 0,

                            /// <summary>Informational message.</summary>
                            [Google.Apis.Util.StringValueAttribute("INFO")]
                            INFO = 1,

                            /// <summary>Warning message.</summary>
                            [Google.Apis.Util.StringValueAttribute("WARNING")]
                            WARNING = 2,

                            /// <summary>Error message.</summary>
                            [Google.Apis.Util.StringValueAttribute("ERROR")]
                            ERROR = 3,
                        }

                        /// <summary>Page size. The default page size is the maximum value of 1000 results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Pagination token, which can be used to request a specific page of `ListTransferLogsRequest`
                        /// list results. For multiple-page results, `ListTransferLogsResponse` outputs a `next_page`
                        /// token, which can be used as the `page_token` value to request the next page of list results.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/transferLogs";

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
                                Pattern = @"^projects/[^/]+/transferConfigs/[^/]+/runs/[^/]+$",
                            });
                            RequestParameters.Add("messageTypes", new Google.Apis.Discovery.Parameter
                            {
                                Name = "messageTypes",
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

                /// <summary>Deletes the specified transfer run.</summary>
                /// <param name="name">
                /// Required. The field will contain name of the resource requested, for example:
                /// `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}` or
                /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes the specified transfer run.</summary>
                public class DeleteRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The field will contain name of the resource requested, for example:
                    /// `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}` or
                    /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
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
                            Pattern = @"^projects/[^/]+/transferConfigs/[^/]+/runs/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns information about the particular transfer run.</summary>
                /// <param name="name">
                /// Required. The field will contain name of the resource requested, for example:
                /// `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}` or
                /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Returns information about the particular transfer run.</summary>
                public class GetRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.TransferRun>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The field will contain name of the resource requested, for example:
                    /// `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}` or
                    /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
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
                            Pattern = @"^projects/[^/]+/transferConfigs/[^/]+/runs/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns information about running and completed transfer runs.</summary>
                /// <param name="parent">
                /// Required. Name of transfer configuration for which transfer runs should be retrieved. Format of
                /// transfer configuration resource name is: `projects/{project_id}/transferConfigs/{config_id}` or
                /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Returns information about running and completed transfer runs.</summary>
                public class ListRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.ListTransferRunsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of transfer configuration for which transfer runs should be retrieved. Format of
                    /// transfer configuration resource name is: `projects/{project_id}/transferConfigs/{config_id}` or
                    /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Page size. The default page size is the maximum value of 1000 results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Pagination token, which can be used to request a specific page of `ListTransferRunsRequest` list
                    /// results. For multiple-page results, `ListTransferRunsResponse` outputs a `next_page` token,
                    /// which can be used as the `page_token` value to request the next page of list results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Indicates how run attempts are to be pulled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("runAttempt", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<RunAttemptEnum> RunAttempt { get; set; }

                    /// <summary>Indicates how run attempts are to be pulled.</summary>
                    public enum RunAttemptEnum
                    {
                        /// <summary>All runs should be returned.</summary>
                        [Google.Apis.Util.StringValueAttribute("RUN_ATTEMPT_UNSPECIFIED")]
                        RUNATTEMPTUNSPECIFIED = 0,

                        /// <summary>Only latest run per day should be returned.</summary>
                        [Google.Apis.Util.StringValueAttribute("LATEST")]
                        LATEST = 1,
                    }

                    /// <summary>When specified, only transfer runs with requested states are returned.</summary>
                    /// <remarks>
                    /// Use this property to set a single value for the parameter, or <see cref="StatesList"/> to set
                    /// multiple values. Do not set both properties.
                    /// </remarks>
                    [Google.Apis.Util.RequestParameterAttribute("states", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<StatesEnum> States { get; set; }

                    /// <summary>When specified, only transfer runs with requested states are returned.</summary>
                    /// <remarks>
                    /// Use this property to set one or more values for the parameter. Do not set both this property and
                    /// <see cref="States"/>.
                    /// </remarks>
                    [Google.Apis.Util.RequestParameterAttribute("states", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<StatesEnum> StatesList { get; set; }

                    /// <summary>When specified, only transfer runs with requested states are returned.</summary>
                    public enum StatesEnum
                    {
                        /// <summary>State placeholder (0).</summary>
                        [Google.Apis.Util.StringValueAttribute("TRANSFER_STATE_UNSPECIFIED")]
                        TRANSFERSTATEUNSPECIFIED = 0,

                        /// <summary>
                        /// Data transfer is scheduled and is waiting to be picked up by data transfer backend (2).
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("PENDING")]
                        PENDING = 1,

                        /// <summary>Data transfer is in progress (3).</summary>
                        [Google.Apis.Util.StringValueAttribute("RUNNING")]
                        RUNNING = 2,

                        /// <summary>Data transfer completed successfully (4).</summary>
                        [Google.Apis.Util.StringValueAttribute("SUCCEEDED")]
                        SUCCEEDED = 3,

                        /// <summary>Data transfer failed (5).</summary>
                        [Google.Apis.Util.StringValueAttribute("FAILED")]
                        FAILED = 4,

                        /// <summary>Data transfer is cancelled (6).</summary>
                        [Google.Apis.Util.StringValueAttribute("CANCELLED")]
                        CANCELLED = 5,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/runs";

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
                            Pattern = @"^projects/[^/]+/transferConfigs/[^/]+$",
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
                        RequestParameters.Add("runAttempt", new Google.Apis.Discovery.Parameter
                        {
                            Name = "runAttempt",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("states", new Google.Apis.Discovery.Parameter
                        {
                            Name = "states",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Creates a new data transfer configuration.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The BigQuery project id where the transfer configuration should be created. Must be in the
            /// format projects/{project_id}/locations/{location_id} or projects/{project_id}. If specified location and
            /// location of the destination bigquery dataset do not match - the request will fail.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.BigQueryDataTransfer.v1.Data.TransferConfig body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a new data transfer configuration.</summary>
            public class CreateRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.TransferConfig>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryDataTransfer.v1.Data.TransferConfig body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The BigQuery project id where the transfer configuration should be created. Must be in the
                /// format projects/{project_id}/locations/{location_id} or projects/{project_id}. If specified location
                /// and location of the destination bigquery dataset do not match - the request will fail.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional OAuth2 authorization code to use with this transfer configuration. This is required only if
                /// `transferConfig.dataSourceId` is 'youtube_channel' and new credentials are needed, as indicated by
                /// `CheckValidCreds`. In order to obtain authorization_code, make a request to the following URL:
                /// https://www.gstatic.com/bigquerydatatransfer/oauthz/auth?
                /// client_id=client_id&amp;amp;scope=data_source_scopes
                /// &amp;amp;redirect_uri=urn:ietf:wg:oauth:2.0:oob&amp;amp;response_type=authorization_code * The
                /// client_id is the OAuth client_id of the a data source as returned by ListDataSources method. *
                /// data_source_scopes are the scopes returned by ListDataSources method. Note that this should not be
                /// set when `service_account_name` is used to create the transfer config.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("authorizationCode", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string AuthorizationCode { get; set; }

                /// <summary>
                /// Optional service account name. If this field is set, the transfer config will be created with this
                /// service account's credentials. It requires that the requesting user calling this API has permissions
                /// to act as this service account. Note that not all data sources support service account credentials
                /// when creating a transfer config. For the latest list of data sources, read about [using service
                /// accounts](https://cloud.google.com/bigquery-transfer/docs/use-service-accounts).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("serviceAccountName", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ServiceAccountName { get; set; }

                /// <summary>
                /// Optional version info. This is required only if `transferConfig.dataSourceId` is not
                /// 'youtube_channel' and new credentials are needed, as indicated by `CheckValidCreds`. In order to
                /// obtain version info, make a request to the following URL:
                /// https://www.gstatic.com/bigquerydatatransfer/oauthz/auth?
                /// client_id=client_id&amp;amp;scope=data_source_scopes
                /// &amp;amp;redirect_uri=urn:ietf:wg:oauth:2.0:oob&amp;amp;response_type=version_info * The client_id
                /// is the OAuth client_id of the a data source as returned by ListDataSources method. *
                /// data_source_scopes are the scopes returned by ListDataSources method. Note that this should not be
                /// set when `service_account_name` is used to create the transfer config.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("versionInfo", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string VersionInfo { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.BigQueryDataTransfer.v1.Data.TransferConfig Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/transferConfigs";

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
                    RequestParameters.Add("authorizationCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "authorizationCode",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("serviceAccountName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "serviceAccountName",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("versionInfo", new Google.Apis.Discovery.Parameter
                    {
                        Name = "versionInfo",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes a data transfer configuration, including any associated transfer runs and logs.
            /// </summary>
            /// <param name="name">
            /// Required. The field will contain name of the resource requested, for example:
            /// `projects/{project_id}/transferConfigs/{config_id}` or
            /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes a data transfer configuration, including any associated transfer runs and logs.
            /// </summary>
            public class DeleteRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The field will contain name of the resource requested, for example:
                /// `projects/{project_id}/transferConfigs/{config_id}` or
                /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`
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
                        Pattern = @"^projects/[^/]+/transferConfigs/[^/]+$",
                    });
                }
            }

            /// <summary>Returns information about a data transfer config.</summary>
            /// <param name="name">
            /// Required. The field will contain name of the resource requested, for example:
            /// `projects/{project_id}/transferConfigs/{config_id}` or
            /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Returns information about a data transfer config.</summary>
            public class GetRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.TransferConfig>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The field will contain name of the resource requested, for example:
                /// `projects/{project_id}/transferConfigs/{config_id}` or
                /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`
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
                        Pattern = @"^projects/[^/]+/transferConfigs/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns information about all transfer configs owned by a project in the specified location.
            /// </summary>
            /// <param name="parent">
            /// Required. The BigQuery project id for which transfer configs should be returned: `projects/{project_id}`
            /// or `projects/{project_id}/locations/{location_id}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Returns information about all transfer configs owned by a project in the specified location.
            /// </summary>
            public class ListRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.ListTransferConfigsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The BigQuery project id for which transfer configs should be returned:
                /// `projects/{project_id}` or `projects/{project_id}/locations/{location_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>When specified, only configurations of requested data sources are returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("dataSourceIds", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> DataSourceIds { get; set; }

                /// <summary>Page size. The default page size is the maximum value of 1000 results.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Pagination token, which can be used to request a specific page of `ListTransfersRequest` list
                /// results. For multiple-page results, `ListTransfersResponse` outputs a `next_page` token, which can
                /// be used as the `page_token` value to request the next page of list results.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/transferConfigs";

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
                    RequestParameters.Add("dataSourceIds", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dataSourceIds",
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
            /// Updates a data transfer configuration. All fields must be set, even if they are not updated.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The resource name of the transfer config. Transfer config names have the form
            /// `projects/{project_id}/locations/{region}/transferConfigs/{config_id}`. Where `config_id` is usually a
            /// uuid, even though it is not guaranteed or required. The name is ignored when creating a transfer config.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.BigQueryDataTransfer.v1.Data.TransferConfig body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Updates a data transfer configuration. All fields must be set, even if they are not updated.
            /// </summary>
            public class PatchRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.TransferConfig>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryDataTransfer.v1.Data.TransferConfig body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the transfer config. Transfer config names have the form
                /// `projects/{project_id}/locations/{region}/transferConfigs/{config_id}`. Where `config_id` is usually
                /// a uuid, even though it is not guaranteed or required. The name is ignored when creating a transfer
                /// config.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional OAuth2 authorization code to use with this transfer configuration. This is required only if
                /// `transferConfig.dataSourceId` is 'youtube_channel' and new credentials are needed, as indicated by
                /// `CheckValidCreds`. In order to obtain authorization_code, make a request to the following URL:
                /// https://www.gstatic.com/bigquerydatatransfer/oauthz/auth?
                /// client_id=client_id&amp;amp;scope=data_source_scopes
                /// &amp;amp;redirect_uri=urn:ietf:wg:oauth:2.0:oob&amp;amp;response_type=authorization_code * The
                /// client_id is the OAuth client_id of the a data source as returned by ListDataSources method. *
                /// data_source_scopes are the scopes returned by ListDataSources method. Note that this should not be
                /// set when `service_account_name` is used to update the transfer config.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("authorizationCode", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string AuthorizationCode { get; set; }

                /// <summary>
                /// Optional service account name. If this field is set, the transfer config will be created with this
                /// service account's credentials. It requires that the requesting user calling this API has permissions
                /// to act as this service account. Note that not all data sources support service account credentials
                /// when creating a transfer config. For the latest list of data sources, read about [using service
                /// accounts](https://cloud.google.com/bigquery-transfer/docs/use-service-accounts).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("serviceAccountName", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ServiceAccountName { get; set; }

                /// <summary>Required. Required list of fields to be updated in this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>
                /// Optional version info. This is required only if `transferConfig.dataSourceId` is not
                /// 'youtube_channel' and new credentials are needed, as indicated by `CheckValidCreds`. In order to
                /// obtain version info, make a request to the following URL:
                /// https://www.gstatic.com/bigquerydatatransfer/oauthz/auth?
                /// client_id=client_id&amp;amp;scope=data_source_scopes
                /// &amp;amp;redirect_uri=urn:ietf:wg:oauth:2.0:oob&amp;amp;response_type=version_info * The client_id
                /// is the OAuth client_id of the a data source as returned by ListDataSources method. *
                /// data_source_scopes are the scopes returned by ListDataSources method. Note that this should not be
                /// set when `service_account_name` is used to update the transfer config.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("versionInfo", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string VersionInfo { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.BigQueryDataTransfer.v1.Data.TransferConfig Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/transferConfigs/[^/]+$",
                    });
                    RequestParameters.Add("authorizationCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "authorizationCode",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("serviceAccountName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "serviceAccountName",
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
                    RequestParameters.Add("versionInfo", new Google.Apis.Discovery.Parameter
                    {
                        Name = "versionInfo",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Creates transfer runs for a time range [start_time, end_time]. For each date - or whatever granularity
            /// the data source supports - in the range, one transfer run is created. Note that runs are created per UTC
            /// time in the time range. DEPRECATED: use StartManualTransferRuns instead.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Transfer configuration name in the form: `projects/{project_id}/transferConfigs/{config_id}`
            /// or `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`.
            /// </param>
            public virtual ScheduleRunsRequest ScheduleRuns(Google.Apis.BigQueryDataTransfer.v1.Data.ScheduleTransferRunsRequest body, string parent)
            {
                return new ScheduleRunsRequest(service, body, parent);
            }

            /// <summary>
            /// Creates transfer runs for a time range [start_time, end_time]. For each date - or whatever granularity
            /// the data source supports - in the range, one transfer run is created. Note that runs are created per UTC
            /// time in the time range. DEPRECATED: use StartManualTransferRuns instead.
            /// </summary>
            public class ScheduleRunsRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.ScheduleTransferRunsResponse>
            {
                /// <summary>Constructs a new ScheduleRuns request.</summary>
                public ScheduleRunsRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryDataTransfer.v1.Data.ScheduleTransferRunsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Transfer configuration name in the form:
                /// `projects/{project_id}/transferConfigs/{config_id}` or
                /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.BigQueryDataTransfer.v1.Data.ScheduleTransferRunsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "scheduleRuns";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}:scheduleRuns";

                /// <summary>Initializes ScheduleRuns parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/transferConfigs/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Start manual transfer runs to be executed now with schedule_time equal to current time. The transfer
            /// runs can be created for a time range where the run_time is between start_time (inclusive) and end_time
            /// (exclusive), or for a specific run_time.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Transfer configuration name in the form: `projects/{project_id}/transferConfigs/{config_id}` or
            /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`.
            /// </param>
            public virtual StartManualRunsRequest StartManualRuns(Google.Apis.BigQueryDataTransfer.v1.Data.StartManualTransferRunsRequest body, string parent)
            {
                return new StartManualRunsRequest(service, body, parent);
            }

            /// <summary>
            /// Start manual transfer runs to be executed now with schedule_time equal to current time. The transfer
            /// runs can be created for a time range where the run_time is between start_time (inclusive) and end_time
            /// (exclusive), or for a specific run_time.
            /// </summary>
            public class StartManualRunsRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.StartManualTransferRunsResponse>
            {
                /// <summary>Constructs a new StartManualRuns request.</summary>
                public StartManualRunsRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryDataTransfer.v1.Data.StartManualTransferRunsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Transfer configuration name in the form: `projects/{project_id}/transferConfigs/{config_id}` or
                /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.BigQueryDataTransfer.v1.Data.StartManualTransferRunsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "startManualRuns";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}:startManualRuns";

                /// <summary>Initializes StartManualRuns parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/transferConfigs/[^/]+$",
                    });
                }
            }
        }

        /// <summary>
        /// Enroll data sources in a user project. This allows users to create transfer configurations for these data
        /// sources. They will also appear in the ListDataSources RPC and as such, will appear in the [BigQuery
        /// UI](https://console.cloud.google.com/bigquery), and the documents can be found in the public guide for
        /// [BigQuery Web UI](https://cloud.google.com/bigquery/bigquery-web-ui) and [Data Transfer
        /// Service](https://cloud.google.com/bigquery/docs/working-with-transfers).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">The name of the project resource in the form: `projects/{project_id}`</param>
        public virtual EnrollDataSourcesRequest EnrollDataSources(Google.Apis.BigQueryDataTransfer.v1.Data.EnrollDataSourcesRequest body, string name)
        {
            return new EnrollDataSourcesRequest(service, body, name);
        }

        /// <summary>
        /// Enroll data sources in a user project. This allows users to create transfer configurations for these data
        /// sources. They will also appear in the ListDataSources RPC and as such, will appear in the [BigQuery
        /// UI](https://console.cloud.google.com/bigquery), and the documents can be found in the public guide for
        /// [BigQuery Web UI](https://cloud.google.com/bigquery/bigquery-web-ui) and [Data Transfer
        /// Service](https://cloud.google.com/bigquery/docs/working-with-transfers).
        /// </summary>
        public class EnrollDataSourcesRequest : BigQueryDataTransferBaseServiceRequest<Google.Apis.BigQueryDataTransfer.v1.Data.Empty>
        {
            /// <summary>Constructs a new EnrollDataSources request.</summary>
            public EnrollDataSourcesRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryDataTransfer.v1.Data.EnrollDataSourcesRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>The name of the project resource in the form: `projects/{project_id}`</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.BigQueryDataTransfer.v1.Data.EnrollDataSourcesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "enrollDataSources";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:enrollDataSources";

            /// <summary>Initializes EnrollDataSources parameter list.</summary>
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
    }
}
namespace Google.Apis.BigQueryDataTransfer.v1.Data
{
    /// <summary>
    /// A request to determine whether the user has valid credentials. This method is used to limit the number of OAuth
    /// popups in the user interface. The user id is inferred from the API call context. If the data source has the
    /// Google+ authorization type, this method returns false, as it cannot be determined whether the credentials are
    /// already valid merely based on the user id.
    /// </summary>
    public class CheckValidCredsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response indicating whether the credentials exist and are valid.</summary>
    public class CheckValidCredsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If set to `true`, the credentials exist and are valid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasValidCreds")]
        public virtual System.Nullable<bool> HasValidCreds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines the properties and custom parameters for a data source.</summary>
    public class DataSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates the type of authorization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizationType")]
        public virtual string AuthorizationType { get; set; }

        /// <summary>Data source client id which should be used to receive refresh token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>
        /// Specifies whether the data source supports automatic data refresh for the past few days, and how it's
        /// supported. For some data sources, data might not be complete until a few days later, so it's useful to
        /// refresh data automatically.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataRefreshType")]
        public virtual string DataRefreshType { get; set; }

        /// <summary>Data source id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceId")]
        public virtual string DataSourceId { get; set; }

        /// <summary>
        /// Default data refresh window on days. Only meaningful when `data_refresh_type` = `SLIDING_WINDOW`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultDataRefreshWindowDays")]
        public virtual System.Nullable<int> DefaultDataRefreshWindowDays { get; set; }

        /// <summary>
        /// Default data transfer schedule. Examples of valid schedules include: `1st,3rd monday of month 15:30`, `every
        /// wed,fri of jan,jun 13:15`, and `first sunday of quarter 00:00`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultSchedule")]
        public virtual string DefaultSchedule { get; set; }

        /// <summary>User friendly data source description string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>User friendly data source name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Url for the help document for this data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("helpUrl")]
        public virtual string HelpUrl { get; set; }

        /// <summary>Disables backfilling and manual run scheduling for the data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualRunsDisabled")]
        public virtual System.Nullable<bool> ManualRunsDisabled { get; set; }

        /// <summary>The minimum interval for scheduler to schedule runs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumScheduleInterval")]
        public virtual object MinimumScheduleInterval { get; set; }

        /// <summary>Output only. Data source resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Data source parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<DataSourceParameter> Parameters { get; set; }

        /// <summary>
        /// Api auth scopes for which refresh token needs to be obtained. These are scopes needed by a data source to
        /// prepare data and ingest them into BigQuery, e.g., https://www.googleapis.com/auth/bigquery
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>
        /// Specifies whether the data source supports a user defined schedule, or operates on the default schedule.
        /// When set to `true`, user can override default schedule.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportsCustomSchedule")]
        public virtual System.Nullable<bool> SupportsCustomSchedule { get; set; }

        /// <summary>Deprecated. This field has no effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportsMultipleTransfers")]
        public virtual System.Nullable<bool> SupportsMultipleTransfers { get; set; }

        /// <summary>Deprecated. This field has no effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferType")]
        public virtual string TransferType { get; set; }

        /// <summary>
        /// The number of seconds to wait for an update from the data source before the Data Transfer Service marks the
        /// transfer as FAILED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateDeadlineSeconds")]
        public virtual System.Nullable<int> UpdateDeadlineSeconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A parameter used to define custom fields in a data source definition.</summary>
    public class DataSourceParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All possible values for the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedValues")]
        public virtual System.Collections.Generic.IList<string> AllowedValues { get; set; }

        /// <summary>If true, it should not be used in new transfers, and it should not be visible to users.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deprecated")]
        public virtual System.Nullable<bool> Deprecated { get; set; }

        /// <summary>Parameter description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Parameter display name in the user interface.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Deprecated. This field has no effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<DataSourceParameter> Fields { get; set; }

        /// <summary>Cannot be changed after initial creation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("immutable")]
        public virtual System.Nullable<bool> Immutable { get; set; }

        /// <summary>For integer and double values specifies maxminum allowed value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxValue")]
        public virtual System.Nullable<double> MaxValue { get; set; }

        /// <summary>For integer and double values specifies minimum allowed value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minValue")]
        public virtual System.Nullable<double> MinValue { get; set; }

        /// <summary>Parameter identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paramId")]
        public virtual string ParamId { get; set; }

        /// <summary>Deprecated. This field has no effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recurse")]
        public virtual System.Nullable<bool> Recurse { get; set; }

        /// <summary>Deprecated. This field has no effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repeated")]
        public virtual System.Nullable<bool> Repeated { get; set; }

        /// <summary>Is parameter required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("required")]
        public virtual System.Nullable<bool> Required { get; set; }

        /// <summary>Parameter type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// Description of the requirements for this field, in case the user input does not fulfill the regex pattern or
        /// min/max values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validationDescription")]
        public virtual string ValidationDescription { get; set; }

        /// <summary>URL to a help document to further explain the naming requirements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validationHelpUrl")]
        public virtual string ValidationHelpUrl { get; set; }

        /// <summary>Regular expression which can be used for parameter validation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validationRegex")]
        public virtual string ValidationRegex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents preferences for sending email notifications for transfer run events.</summary>
    public class EmailPreferences : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If true, email notifications will be sent on transfer run failures.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableFailureEmail")]
        public virtual System.Nullable<bool> EnableFailureEmail { get; set; }

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
    /// A request to enroll a set of data sources so they are visible in the BigQuery UI's `Transfer` tab.
    /// </summary>
    public class EnrollDataSourcesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Data sources that are enrolled. It is required to provide at least one data source id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceIds")]
        public virtual System.Collections.Generic.IList<string> DataSourceIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Returns list of supported data sources and their metadata.</summary>
    public class ListDataSourcesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of supported data sources and their transfer settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSources")]
        public virtual System.Collections.Generic.IList<DataSource> DataSources { get; set; }

        /// <summary>
        /// Output only. The next-pagination token. For multiple-page list results, this token can be used as the
        /// `ListDataSourcesRequest.page_token` to request the next page of list results.
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

    /// <summary>The returned list of pipelines in the project.</summary>
    public class ListTransferConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The next-pagination token. For multiple-page list results, this token can be used as the
        /// `ListTransferConfigsRequest.page_token` to request the next page of list results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Output only. The stored pipeline transfer configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferConfigs")]
        public virtual System.Collections.Generic.IList<TransferConfig> TransferConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The returned list transfer run messages.</summary>
    public class ListTransferLogsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The next-pagination token. For multiple-page list results, this token can be used as the
        /// `GetTransferRunLogRequest.page_token` to request the next page of list results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Output only. The stored pipeline transfer messages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferMessages")]
        public virtual System.Collections.Generic.IList<TransferMessage> TransferMessages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The returned list of pipelines in the project.</summary>
    public class ListTransferRunsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The next-pagination token. For multiple-page list results, this token can be used as the
        /// `ListTransferRunsRequest.page_token` to request the next page of list results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Output only. The stored pipeline transfer runs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferRuns")]
        public virtual System.Collections.Generic.IList<TransferRun> TransferRuns { get; set; }

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

    /// <summary>Options customizing the data transfer schedule.</summary>
    public class ScheduleOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If true, automatic scheduling of data transfer runs for this configuration will be disabled. The runs can be
        /// started on ad-hoc basis using StartManualTransferRuns API. When automatic scheduling is disabled, the
        /// TransferConfig.schedule field will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableAutoScheduling")]
        public virtual System.Nullable<bool> DisableAutoScheduling { get; set; }

        /// <summary>
        /// Defines time to stop scheduling transfer runs. A transfer run cannot be scheduled at or after the end time.
        /// The end time can be changed at any moment. The time when a data transfer can be trigerred manually is not
        /// limited by this option.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Specifies time to start scheduling transfer runs. The first run will be scheduled at or after the start time
        /// according to a recurrence pattern defined in the schedule string. The start time can be changed at any
        /// moment. The time when a data transfer can be trigerred manually is not limited by this option.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to schedule transfer runs for a time range.</summary>
    public class ScheduleTransferRunsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. End time of the range of transfer runs. For example, `"2017-05-30T00:00:00+00:00"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Required. Start time of the range of transfer runs. For example, `"2017-05-25T00:00:00+00:00"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response to schedule transfer runs for a time range.</summary>
    public class ScheduleTransferRunsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The transfer runs that were scheduled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runs")]
        public virtual System.Collections.Generic.IList<TransferRun> Runs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to start manual transfer runs.</summary>
    public class StartManualTransferRunsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specific run_time for a transfer run to be started. The requested_run_time must not be in the future.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedRunTime")]
        public virtual object RequestedRunTime { get; set; }

        /// <summary>Time range for the transfer runs that should be started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedTimeRange")]
        public virtual TimeRange RequestedTimeRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response to start manual transfer runs.</summary>
    public class StartManualTransferRunsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The transfer runs that were created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runs")]
        public virtual System.Collections.Generic.IList<TransferRun> Runs { get; set; }

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
    /// A specification for a time range, this will request transfer runs with run_time between start_time (inclusive)
    /// and end_time (exclusive).
    /// </summary>
    public class TimeRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// End time of the range of transfer runs. For example, `"2017-05-30T00:00:00+00:00"`. The end_time must not be
        /// in the future. Creates transfer runs where run_time is in the range between start_time (inclusive) and
        /// end_time (exclusive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Start time of the range of transfer runs. For example, `"2017-05-25T00:00:00+00:00"`. The start_time must be
        /// strictly less than the end_time. Creates transfer runs where run_time is in the range between start_time
        /// (inclusive) and end_time (exclusive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a data transfer configuration. A transfer configuration contains all metadata needed to perform a
    /// data transfer. For example, `destination_dataset_id` specifies where data should be stored. When a new transfer
    /// configuration is created, the specified `destination_dataset_id` is created when needed and shared with the
    /// appropriate data source service account.
    /// </summary>
    public class TransferConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of days to look back to automatically refresh the data. For example, if `data_refresh_window_days
        /// = 10`, then every day BigQuery reingests data for [today-10, today-1], rather than ingesting data for just
        /// [today-1]. Only valid if the data source supports the feature. Set the value to 0 to use the default value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataRefreshWindowDays")]
        public virtual System.Nullable<int> DataRefreshWindowDays { get; set; }

        /// <summary>
        /// Data source ID. This cannot be changed once data transfer is created. The full list of available data source
        /// IDs can be returned through an API call:
        /// https://cloud.google.com/bigquery-transfer/docs/reference/datatransfer/rest/v1/projects.locations.dataSources/list
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceId")]
        public virtual string DataSourceId { get; set; }

        /// <summary>Output only. Region in which BigQuery dataset is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetRegion")]
        public virtual string DatasetRegion { get; set; }

        /// <summary>The BigQuery target dataset id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationDatasetId")]
        public virtual string DestinationDatasetId { get; set; }

        /// <summary>Is this config disabled. When set to true, no runs are scheduled for a given transfer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>User specified display name for the data transfer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Email notifications will be sent according to these preferences to the email address of the user who owns
        /// this transfer config.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailPreferences")]
        public virtual EmailPreferences EmailPreferences { get; set; }

        /// <summary>
        /// The resource name of the transfer config. Transfer config names have the form
        /// `projects/{project_id}/locations/{region}/transferConfigs/{config_id}`. Where `config_id` is usually a uuid,
        /// even though it is not guaranteed or required. The name is ignored when creating a transfer config.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Next time when data transfer will run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextRunTime")]
        public virtual object NextRunTime { get; set; }

        /// <summary>
        /// Pub/Sub topic where notifications will be sent after transfer runs associated with this transfer config
        /// finish. The format for specifying a pubsub topic is: `projects/{project}/topics/{topic}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationPubsubTopic")]
        public virtual string NotificationPubsubTopic { get; set; }

        /// <summary>
        /// Output only. Information about the user whose credentials are used to transfer data. Populated only for
        /// `transferConfigs.get` requests. In case the user information is not available, this field will not be
        /// populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerInfo")]
        public virtual UserInfo OwnerInfo { get; set; }

        /// <summary>
        /// Parameters specific to each data source. For more information see the bq tab in the 'Setting up a data
        /// transfer' section for each data source. For example the parameters for Cloud Storage transfers are listed
        /// here: https://cloud.google.com/bigquery-transfer/docs/cloud-storage-transfer#bq
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("params")]
        public virtual System.Collections.Generic.IDictionary<string, object> Params__ { get; set; }

        /// <summary>
        /// Data transfer schedule. If the data source does not support a custom schedule, this should be empty. If it
        /// is empty, the default value for the data source will be used. The specified times are in UTC. Examples of
        /// valid format: `1st,3rd monday of month 15:30`, `every wed,fri of jan,jun 13:15`, and `first sunday of
        /// quarter 00:00`. See more explanation about the format here:
        /// https://cloud.google.com/appengine/docs/flexible/python/scheduling-jobs-with-cron-yaml#the_schedule_format
        /// NOTE: The minimum interval time between recurring transfers depends on the data source; refer to the
        /// documentation for your data source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedule")]
        public virtual string Schedule { get; set; }

        /// <summary>Options customizing the data transfer schedule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleOptions")]
        public virtual ScheduleOptions ScheduleOptions { get; set; }

        /// <summary>Output only. State of the most recently updated transfer run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Data transfer modification time. Ignored by server on input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>Deprecated. Unique ID of the user on whose behalf transfer is done.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual System.Nullable<long> UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a user facing message for a particular data transfer run.</summary>
    public class TransferMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Message text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageText")]
        public virtual string MessageText { get; set; }

        /// <summary>Time when message was logged.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageTime")]
        public virtual object MessageTime { get; set; }

        /// <summary>Message severity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a data transfer run.</summary>
    public class TransferRun : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Data source id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceId")]
        public virtual string DataSourceId { get; set; }

        /// <summary>Output only. The BigQuery target dataset id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationDatasetId")]
        public virtual string DestinationDatasetId { get; set; }

        /// <summary>
        /// Output only. Email notifications will be sent according to these preferences to the email address of the
        /// user who owns the transfer config this run was derived from.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailPreferences")]
        public virtual EmailPreferences EmailPreferences { get; set; }

        /// <summary>
        /// Output only. Time when transfer run ended. Parameter ignored by server for input requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Status of the transfer run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorStatus")]
        public virtual Status ErrorStatus { get; set; }

        /// <summary>
        /// The resource name of the transfer run. Transfer run names have the form
        /// `projects/{project_id}/locations/{location}/transferConfigs/{config_id}/runs/{run_id}`. The name is ignored
        /// when creating a transfer run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Pub/Sub topic where a notification will be sent after this transfer run finishes. The format
        /// for specifying a pubsub topic is: `projects/{project}/topics/{topic}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationPubsubTopic")]
        public virtual string NotificationPubsubTopic { get; set; }

        /// <summary>
        /// Output only. Parameters specific to each data source. For more information see the bq tab in the 'Setting up
        /// a data transfer' section for each data source. For example the parameters for Cloud Storage transfers are
        /// listed here: https://cloud.google.com/bigquery-transfer/docs/cloud-storage-transfer#bq
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("params")]
        public virtual System.Collections.Generic.IDictionary<string, object> Params__ { get; set; }

        /// <summary>For batch transfer runs, specifies the date and time of the data should be ingested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runTime")]
        public virtual object RunTime { get; set; }

        /// <summary>
        /// Output only. Describes the schedule of this transfer run if it was created as part of a regular schedule.
        /// For batch transfer runs that are scheduled manually, this is empty. NOTE: the system might choose to delay
        /// the schedule depending on the current load, so `schedule_time` doesn't always match this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedule")]
        public virtual string Schedule { get; set; }

        /// <summary>Minimum time after which a transfer run can be started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleTime")]
        public virtual object ScheduleTime { get; set; }

        /// <summary>
        /// Output only. Time when transfer run was started. Parameter ignored by server for input requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>Data transfer run state. Ignored for input requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Last time the data transfer run state was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>Deprecated. Unique ID of the user on whose behalf transfer is done.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual System.Nullable<long> UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a user.</summary>
    public class UserInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>E-mail address of the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
