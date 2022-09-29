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

namespace Google.Apis.CloudSearch.v1
{
    /// <summary>The CloudSearch Service.</summary>
    public class CloudSearchService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudSearchService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudSearchService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Debug = new DebugResource(this);
            Indexing = new IndexingResource(this);
            Media = new MediaResource(this);
            Operations = new OperationsResource(this);
            Query = new QueryResource(this);
            Settings = new SettingsResource(this);
            Stats = new StatsResource(this);
            V1 = new V1Resource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudsearch";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://cloudsearch.googleapis.com/";
        #else
            "https://cloudsearch.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://cloudsearch.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Search API.</summary>
        public class Scope
        {
            /// <summary>Index and serve your organization's data with Cloud Search</summary>
            public static string CloudSearch = "https://www.googleapis.com/auth/cloud_search";

            /// <summary>Index and serve your organization's data with Cloud Search</summary>
            public static string CloudSearchDebug = "https://www.googleapis.com/auth/cloud_search.debug";

            /// <summary>Index and serve your organization's data with Cloud Search</summary>
            public static string CloudSearchIndexing = "https://www.googleapis.com/auth/cloud_search.indexing";

            /// <summary>Search your organization's data in the Cloud Search index</summary>
            public static string CloudSearchQuery = "https://www.googleapis.com/auth/cloud_search.query";

            /// <summary>Index and serve your organization's data with Cloud Search</summary>
            public static string CloudSearchSettings = "https://www.googleapis.com/auth/cloud_search.settings";

            /// <summary>Index and serve your organization's data with Cloud Search</summary>
            public static string CloudSearchSettingsIndexing = "https://www.googleapis.com/auth/cloud_search.settings.indexing";

            /// <summary>Index and serve your organization's data with Cloud Search</summary>
            public static string CloudSearchSettingsQuery = "https://www.googleapis.com/auth/cloud_search.settings.query";

            /// <summary>Index and serve your organization's data with Cloud Search</summary>
            public static string CloudSearchStats = "https://www.googleapis.com/auth/cloud_search.stats";

            /// <summary>Index and serve your organization's data with Cloud Search</summary>
            public static string CloudSearchStatsIndexing = "https://www.googleapis.com/auth/cloud_search.stats.indexing";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Search API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Index and serve your organization's data with Cloud Search</summary>
            public const string CloudSearch = "https://www.googleapis.com/auth/cloud_search";

            /// <summary>Index and serve your organization's data with Cloud Search</summary>
            public const string CloudSearchDebug = "https://www.googleapis.com/auth/cloud_search.debug";

            /// <summary>Index and serve your organization's data with Cloud Search</summary>
            public const string CloudSearchIndexing = "https://www.googleapis.com/auth/cloud_search.indexing";

            /// <summary>Search your organization's data in the Cloud Search index</summary>
            public const string CloudSearchQuery = "https://www.googleapis.com/auth/cloud_search.query";

            /// <summary>Index and serve your organization's data with Cloud Search</summary>
            public const string CloudSearchSettings = "https://www.googleapis.com/auth/cloud_search.settings";

            /// <summary>Index and serve your organization's data with Cloud Search</summary>
            public const string CloudSearchSettingsIndexing = "https://www.googleapis.com/auth/cloud_search.settings.indexing";

            /// <summary>Index and serve your organization's data with Cloud Search</summary>
            public const string CloudSearchSettingsQuery = "https://www.googleapis.com/auth/cloud_search.settings.query";

            /// <summary>Index and serve your organization's data with Cloud Search</summary>
            public const string CloudSearchStats = "https://www.googleapis.com/auth/cloud_search.stats";

            /// <summary>Index and serve your organization's data with Cloud Search</summary>
            public const string CloudSearchStatsIndexing = "https://www.googleapis.com/auth/cloud_search.stats.indexing";
        }

        /// <summary>Gets the Debug resource.</summary>
        public virtual DebugResource Debug { get; }

        /// <summary>Gets the Indexing resource.</summary>
        public virtual IndexingResource Indexing { get; }

        /// <summary>Gets the Media resource.</summary>
        public virtual MediaResource Media { get; }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the Query resource.</summary>
        public virtual QueryResource Query { get; }

        /// <summary>Gets the Settings resource.</summary>
        public virtual SettingsResource Settings { get; }

        /// <summary>Gets the Stats resource.</summary>
        public virtual StatsResource Stats { get; }

        /// <summary>Gets the V1 resource.</summary>
        public virtual V1Resource V1 { get; }
    }

    /// <summary>A base abstract class for CloudSearch requests.</summary>
    public abstract class CloudSearchBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudSearchBaseServiceRequest instance.</summary>
        protected CloudSearchBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudSearch parameter list.</summary>
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

    /// <summary>The "debug" collection of methods.</summary>
    public class DebugResource
    {
        private const string Resource = "debug";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DebugResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Datasources = new DatasourcesResource(service);
            Identitysources = new IdentitysourcesResource(service);
        }

        /// <summary>Gets the Datasources resource.</summary>
        public virtual DatasourcesResource Datasources { get; }

        /// <summary>The "datasources" collection of methods.</summary>
        public class DatasourcesResource
        {
            private const string Resource = "datasources";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DatasourcesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Items = new ItemsResource(service);
            }

            /// <summary>Gets the Items resource.</summary>
            public virtual ItemsResource Items { get; }

            /// <summary>The "items" collection of methods.</summary>
            public class ItemsResource
            {
                private const string Resource = "items";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ItemsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Unmappedids = new UnmappedidsResource(service);
                }

                /// <summary>Gets the Unmappedids resource.</summary>
                public virtual UnmappedidsResource Unmappedids { get; }

                /// <summary>The "unmappedids" collection of methods.</summary>
                public class UnmappedidsResource
                {
                    private const string Resource = "unmappedids";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public UnmappedidsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// List all unmapped identities for a specific item. **Note:** This API requires an admin account
                    /// to execute.
                    /// </summary>
                    /// <param name="parent">
                    /// The name of the item, in the following format: datasources/{source_id}/items/{ID}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>
                    /// List all unmapped identities for a specific item. **Note:** This API requires an admin account
                    /// to execute.
                    /// </summary>
                    public class ListRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.ListUnmappedIdentitiesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// The name of the item, in the following format: datasources/{source_id}/items/{ID}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// If you are asked by Google to help with debugging, set this field. Otherwise, ignore this
                        /// field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("debugOptions.enableDebugging", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> DebugOptionsEnableDebugging { get; set; }

                        /// <summary>Maximum number of items to fetch in a request. Defaults to 100.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The next_page_token value returned from a previous List request, if any.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/debug/{+parent}/unmappedids";

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
                                Pattern = @"^datasources/[^/]+/items/[^/]+$",
                            });
                            RequestParameters.Add("debugOptions.enableDebugging", new Google.Apis.Discovery.Parameter
                            {
                                Name = "debugOptions.enableDebugging",
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
                /// Checks whether an item is accessible by specified principal. Principal must be a user; groups and
                /// domain values aren't supported. **Note:** This API requires an admin account to execute.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Item name, format: datasources/{source_id}/items/{item_id}</param>
                public virtual CheckAccessRequest CheckAccess(Google.Apis.CloudSearch.v1.Data.Principal body, string name)
                {
                    return new CheckAccessRequest(service, body, name);
                }

                /// <summary>
                /// Checks whether an item is accessible by specified principal. Principal must be a user; groups and
                /// domain values aren't supported. **Note:** This API requires an admin account to execute.
                /// </summary>
                public class CheckAccessRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.CheckAccessResponse>
                {
                    /// <summary>Constructs a new CheckAccess request.</summary>
                    public CheckAccessRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSearch.v1.Data.Principal body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Item name, format: datasources/{source_id}/items/{item_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// If you are asked by Google to help with debugging, set this field. Otherwise, ignore this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("debugOptions.enableDebugging", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> DebugOptionsEnableDebugging { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudSearch.v1.Data.Principal Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "checkAccess";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/debug/{+name}:checkAccess";

                    /// <summary>Initializes CheckAccess parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^datasources/[^/]+/items/[^/]+$",
                        });
                        RequestParameters.Add("debugOptions.enableDebugging", new Google.Apis.Discovery.Parameter
                        {
                            Name = "debugOptions.enableDebugging",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Fetches the item whose viewUrl exactly matches that of the URL provided in the request. **Note:**
                /// This API requires an admin account to execute.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Source name, format: datasources/{source_id}</param>
                public virtual SearchByViewUrlRequest SearchByViewUrl(Google.Apis.CloudSearch.v1.Data.SearchItemsByViewUrlRequest body, string name)
                {
                    return new SearchByViewUrlRequest(service, body, name);
                }

                /// <summary>
                /// Fetches the item whose viewUrl exactly matches that of the URL provided in the request. **Note:**
                /// This API requires an admin account to execute.
                /// </summary>
                public class SearchByViewUrlRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.SearchItemsByViewUrlResponse>
                {
                    /// <summary>Constructs a new SearchByViewUrl request.</summary>
                    public SearchByViewUrlRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSearch.v1.Data.SearchItemsByViewUrlRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Source name, format: datasources/{source_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudSearch.v1.Data.SearchItemsByViewUrlRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "searchByViewUrl";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/debug/{+name}/items:searchByViewUrl";

                    /// <summary>Initializes SearchByViewUrl parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^datasources/[^/]+$",
                        });
                    }
                }
            }
        }

        /// <summary>Gets the Identitysources resource.</summary>
        public virtual IdentitysourcesResource Identitysources { get; }

        /// <summary>The "identitysources" collection of methods.</summary>
        public class IdentitysourcesResource
        {
            private const string Resource = "identitysources";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public IdentitysourcesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Items = new ItemsResource(service);
                Unmappedids = new UnmappedidsResource(service);
            }

            /// <summary>Gets the Items resource.</summary>
            public virtual ItemsResource Items { get; }

            /// <summary>The "items" collection of methods.</summary>
            public class ItemsResource
            {
                private const string Resource = "items";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ItemsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Lists names of items associated with an unmapped identity. **Note:** This API requires an admin
                /// account to execute.
                /// </summary>
                /// <param name="parent">
                /// The name of the identity source, in the following format: identitysources/{source_id}}
                /// </param>
                public virtual ListForunmappedidentityRequest ListForunmappedidentity(string parent)
                {
                    return new ListForunmappedidentityRequest(service, parent);
                }

                /// <summary>
                /// Lists names of items associated with an unmapped identity. **Note:** This API requires an admin
                /// account to execute.
                /// </summary>
                public class ListForunmappedidentityRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.ListItemNamesForUnmappedIdentityResponse>
                {
                    /// <summary>Constructs a new ListForunmappedidentity request.</summary>
                    public ListForunmappedidentityRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the identity source, in the following format: identitysources/{source_id}}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// If you are asked by Google to help with debugging, set this field. Otherwise, ignore this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("debugOptions.enableDebugging", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> DebugOptionsEnableDebugging { get; set; }

                    [Google.Apis.Util.RequestParameterAttribute("groupResourceName", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string GroupResourceName { get; set; }

                    /// <summary>Maximum number of items to fetch in a request. Defaults to 100.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The next_page_token value returned from a previous List request, if any.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    [Google.Apis.Util.RequestParameterAttribute("userResourceName", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string UserResourceName { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "listForunmappedidentity";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/debug/{+parent}/items:forunmappedidentity";

                    /// <summary>Initializes ListForunmappedidentity parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^identitysources/[^/]+$",
                        });
                        RequestParameters.Add("debugOptions.enableDebugging", new Google.Apis.Discovery.Parameter
                        {
                            Name = "debugOptions.enableDebugging",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("groupResourceName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "groupResourceName",
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
                        RequestParameters.Add("userResourceName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userResourceName",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the Unmappedids resource.</summary>
            public virtual UnmappedidsResource Unmappedids { get; }

            /// <summary>The "unmappedids" collection of methods.</summary>
            public class UnmappedidsResource
            {
                private const string Resource = "unmappedids";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public UnmappedidsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Lists unmapped user identities for an identity source. **Note:** This API requires an admin account
                /// to execute.
                /// </summary>
                /// <param name="parent">
                /// The name of the identity source, in the following format: identitysources/{source_id}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists unmapped user identities for an identity source. **Note:** This API requires an admin account
                /// to execute.
                /// </summary>
                public class ListRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.ListUnmappedIdentitiesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the identity source, in the following format: identitysources/{source_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// If you are asked by Google to help with debugging, set this field. Otherwise, ignore this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("debugOptions.enableDebugging", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> DebugOptionsEnableDebugging { get; set; }

                    /// <summary>Maximum number of items to fetch in a request. Defaults to 100.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The next_page_token value returned from a previous List request, if any.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Limit users selection to this status.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("resolutionStatusCode", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ResolutionStatusCodeEnum> ResolutionStatusCode { get; set; }

                    /// <summary>Limit users selection to this status.</summary>
                    public enum ResolutionStatusCodeEnum
                    {
                        /// <summary>
                        /// Input-only value. Used to list all unmapped identities regardless of status.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("CODE_UNSPECIFIED")]
                        CODEUNSPECIFIED = 0,

                        /// <summary>
                        /// The unmapped identity was not found in IDaaS, and needs to be provided by the user.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("NOT_FOUND")]
                        NOTFOUND = 1,

                        /// <summary>
                        /// The identity source associated with the identity was either not found or deleted.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("IDENTITY_SOURCE_NOT_FOUND")]
                        IDENTITYSOURCENOTFOUND = 2,

                        /// <summary>
                        /// IDaaS does not understand the identity source, probably because the schema was modified in a
                        /// non compatible way.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("IDENTITY_SOURCE_MISCONFIGURED")]
                        IDENTITYSOURCEMISCONFIGURED = 3,

                        /// <summary>The number of users associated with the external identity is too large.</summary>
                        [Google.Apis.Util.StringValueAttribute("TOO_MANY_MAPPINGS_FOUND")]
                        TOOMANYMAPPINGSFOUND = 4,

                        /// <summary>Internal error.</summary>
                        [Google.Apis.Util.StringValueAttribute("INTERNAL_ERROR")]
                        INTERNALERROR = 5,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/debug/{+parent}/unmappedids";

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
                            Pattern = @"^identitysources/[^/]+$",
                        });
                        RequestParameters.Add("debugOptions.enableDebugging", new Google.Apis.Discovery.Parameter
                        {
                            Name = "debugOptions.enableDebugging",
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
                        RequestParameters.Add("resolutionStatusCode", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resolutionStatusCode",
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

    /// <summary>The "indexing" collection of methods.</summary>
    public class IndexingResource
    {
        private const string Resource = "indexing";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public IndexingResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Datasources = new DatasourcesResource(service);
        }

        /// <summary>Gets the Datasources resource.</summary>
        public virtual DatasourcesResource Datasources { get; }

        /// <summary>The "datasources" collection of methods.</summary>
        public class DatasourcesResource
        {
            private const string Resource = "datasources";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DatasourcesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Items = new ItemsResource(service);
            }

            /// <summary>Gets the Items resource.</summary>
            public virtual ItemsResource Items { get; }

            /// <summary>The "items" collection of methods.</summary>
            public class ItemsResource
            {
                private const string Resource = "items";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ItemsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Deletes Item resource for the specified resource name. This API requires an admin or service account
                /// to execute. The service account used is the one whitelisted in the corresponding data source.
                /// </summary>
                /// <param name="name">
                /// Required. The name of the item to delete. Format: datasources/{source_id}/items/{item_id}
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes Item resource for the specified resource name. This API requires an admin or service account
                /// to execute. The service account used is the one whitelisted in the corresponding data source.
                /// </summary>
                public class DeleteRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the item to delete. Format: datasources/{source_id}/items/{item_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The name of connector making this call. Format: datasources/{source_id}/connectors/{ID}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("connectorName", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ConnectorName { get; set; }

                    /// <summary>
                    /// If you are asked by Google to help with debugging, set this field. Otherwise, ignore this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("debugOptions.enableDebugging", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> DebugOptionsEnableDebugging { get; set; }

                    /// <summary>Required. The RequestMode for this request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("mode", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ModeEnum> Mode { get; set; }

                    /// <summary>Required. The RequestMode for this request.</summary>
                    public enum ModeEnum
                    {
                        /// <summary>
                        /// The priority is not specified in the update request. Leaving priority unspecified results in
                        /// an update failure.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("UNSPECIFIED")]
                        UNSPECIFIED = 0,

                        /// <summary>For real-time updates.</summary>
                        [Google.Apis.Util.StringValueAttribute("SYNCHRONOUS")]
                        SYNCHRONOUS = 1,

                        /// <summary>
                        /// For changes that are executed after the response is sent back to the caller.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("ASYNCHRONOUS")]
                        ASYNCHRONOUS = 2,
                    }

                    /// <summary>
                    /// Required. The incremented version of the item to delete from the index. The indexing system
                    /// stores the version from the datasource as a byte string and compares the Item version in the
                    /// index to the version of the queued Item using lexical ordering. Cloud Search Indexing won't
                    /// delete any queued item with a version value that is less than or equal to the version of the
                    /// currently indexed item. The maximum length for this field is 1024 bytes. For information on how
                    /// item version affects the deletion process, refer to [Handle revisions after manual
                    /// deletes](https://developers.google.com/cloud-search/docs/guides/operations).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("version", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Version { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/indexing/{+name}";

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
                            Pattern = @"^datasources/[^/]+/items/[^/]+$",
                        });
                        RequestParameters.Add("connectorName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "connectorName",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("debugOptions.enableDebugging", new Google.Apis.Discovery.Parameter
                        {
                            Name = "debugOptions.enableDebugging",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("mode", new Google.Apis.Discovery.Parameter
                        {
                            Name = "mode",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("version", new Google.Apis.Discovery.Parameter
                        {
                            Name = "version",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes all items in a queue. This method is useful for deleting stale items. This API requires an
                /// admin or service account to execute. The service account used is the one whitelisted in the
                /// corresponding data source.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name of the Data Source to delete items in a queue. Format: datasources/{source_id}
                /// </param>
                public virtual DeleteQueueItemsRequest DeleteQueueItems(Google.Apis.CloudSearch.v1.Data.DeleteQueueItemsRequest body, string name)
                {
                    return new DeleteQueueItemsRequest(service, body, name);
                }

                /// <summary>
                /// Deletes all items in a queue. This method is useful for deleting stale items. This API requires an
                /// admin or service account to execute. The service account used is the one whitelisted in the
                /// corresponding data source.
                /// </summary>
                public class DeleteQueueItemsRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.Operation>
                {
                    /// <summary>Constructs a new DeleteQueueItems request.</summary>
                    public DeleteQueueItemsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSearch.v1.Data.DeleteQueueItemsRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the Data Source to delete items in a queue. Format: datasources/{source_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudSearch.v1.Data.DeleteQueueItemsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "deleteQueueItems";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/indexing/{+name}/items:deleteQueueItems";

                    /// <summary>Initializes DeleteQueueItems parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^datasources/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets Item resource by item name. This API requires an admin or service account to execute. The
                /// service account used is the one whitelisted in the corresponding data source.
                /// </summary>
                /// <param name="name">
                /// The name of the item to get info. Format: datasources/{source_id}/items/{item_id}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets Item resource by item name. This API requires an admin or service account to execute. The
                /// service account used is the one whitelisted in the corresponding data source.
                /// </summary>
                public class GetRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.Item>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the item to get info. Format: datasources/{source_id}/items/{item_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The name of connector making this call. Format: datasources/{source_id}/connectors/{ID}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("connectorName", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ConnectorName { get; set; }

                    /// <summary>
                    /// If you are asked by Google to help with debugging, set this field. Otherwise, ignore this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("debugOptions.enableDebugging", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> DebugOptionsEnableDebugging { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/indexing/{+name}";

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
                            Pattern = @"^datasources/[^/]+/items/[^/]+$",
                        });
                        RequestParameters.Add("connectorName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "connectorName",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("debugOptions.enableDebugging", new Google.Apis.Discovery.Parameter
                        {
                            Name = "debugOptions.enableDebugging",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Updates Item ACL, metadata, and content. It will insert the Item if it does not exist. This method
                /// does not support partial updates. Fields with no provided values are cleared out in the Cloud Search
                /// index. This API requires an admin or service account to execute. The service account used is the one
                /// whitelisted in the corresponding data source.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name of the Item. Format: datasources/{source_id}/items/{item_id} This is a required field. The
                /// maximum length is 1536 characters.
                /// </param>
                public virtual IndexRequest Index(Google.Apis.CloudSearch.v1.Data.IndexItemRequest body, string name)
                {
                    return new IndexRequest(service, body, name);
                }

                /// <summary>
                /// Updates Item ACL, metadata, and content. It will insert the Item if it does not exist. This method
                /// does not support partial updates. Fields with no provided values are cleared out in the Cloud Search
                /// index. This API requires an admin or service account to execute. The service account used is the one
                /// whitelisted in the corresponding data source.
                /// </summary>
                public class IndexRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Index request.</summary>
                    public IndexRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSearch.v1.Data.IndexItemRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the Item. Format: datasources/{source_id}/items/{item_id} This is a required field.
                    /// The maximum length is 1536 characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudSearch.v1.Data.IndexItemRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "index";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/indexing/{+name}:index";

                    /// <summary>Initializes Index parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^datasources/[^/]+/items/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists all or a subset of Item resources. This API requires an admin or service account to execute.
                /// The service account used is the one whitelisted in the corresponding data source.
                /// </summary>
                /// <param name="name">
                /// The name of the Data Source to list Items. Format: datasources/{source_id}
                /// </param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(service, name);
                }

                /// <summary>
                /// Lists all or a subset of Item resources. This API requires an admin or service account to execute.
                /// The service account used is the one whitelisted in the corresponding data source.
                /// </summary>
                public class ListRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.ListItemsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>The name of the Data Source to list Items. Format: datasources/{source_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// When set to true, the indexing system only populates the following fields: name, version, queue.
                    /// metadata.hash, metadata.title, metadata.sourceRepositoryURL, metadata.objectType,
                    /// metadata.createTime, metadata.updateTime, metadata.contentLanguage, metadata.mimeType,
                    /// structured_data.hash, content.hash, itemType, itemStatus.code, itemStatus.processingError.code,
                    /// itemStatus.repositoryError.type, If this value is false, then all the fields are populated in
                    /// Item.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("brief", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Brief { get; set; }

                    /// <summary>
                    /// The name of connector making this call. Format: datasources/{source_id}/connectors/{ID}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("connectorName", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ConnectorName { get; set; }

                    /// <summary>
                    /// If you are asked by Google to help with debugging, set this field. Otherwise, ignore this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("debugOptions.enableDebugging", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> DebugOptionsEnableDebugging { get; set; }

                    /// <summary>
                    /// Maximum number of items to fetch in a request. The max value is 1000 when brief is true. The max
                    /// value is 10 if brief is false. The default value is 10
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The next_page_token value returned from a previous List request, if any.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/indexing/{+name}/items";

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
                            Pattern = @"^datasources/[^/]+$",
                        });
                        RequestParameters.Add("brief", new Google.Apis.Discovery.Parameter
                        {
                            Name = "brief",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("connectorName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "connectorName",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("debugOptions.enableDebugging", new Google.Apis.Discovery.Parameter
                        {
                            Name = "debugOptions.enableDebugging",
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
                /// Polls for unreserved items from the indexing queue and marks a set as reserved, starting with items
                /// that have the oldest timestamp from the highest priority ItemStatus. The priority order is as
                /// follows: ERROR MODIFIED NEW_ITEM ACCEPTED Reserving items ensures that polling from other threads
                /// cannot create overlapping sets. After handling the reserved items, the client should put items back
                /// into the unreserved state, either by calling index, or by calling push with the type REQUEUE. Items
                /// automatically become available (unreserved) after 4 hours even if no update or push method is
                /// called. This API requires an admin or service account to execute. The service account used is the
                /// one whitelisted in the corresponding data source.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name of the Data Source to poll items. Format: datasources/{source_id}
                /// </param>
                public virtual PollRequest Poll(Google.Apis.CloudSearch.v1.Data.PollItemsRequest body, string name)
                {
                    return new PollRequest(service, body, name);
                }

                /// <summary>
                /// Polls for unreserved items from the indexing queue and marks a set as reserved, starting with items
                /// that have the oldest timestamp from the highest priority ItemStatus. The priority order is as
                /// follows: ERROR MODIFIED NEW_ITEM ACCEPTED Reserving items ensures that polling from other threads
                /// cannot create overlapping sets. After handling the reserved items, the client should put items back
                /// into the unreserved state, either by calling index, or by calling push with the type REQUEUE. Items
                /// automatically become available (unreserved) after 4 hours even if no update or push method is
                /// called. This API requires an admin or service account to execute. The service account used is the
                /// one whitelisted in the corresponding data source.
                /// </summary>
                public class PollRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.PollItemsResponse>
                {
                    /// <summary>Constructs a new Poll request.</summary>
                    public PollRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSearch.v1.Data.PollItemsRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the Data Source to poll items. Format: datasources/{source_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudSearch.v1.Data.PollItemsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "poll";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/indexing/{+name}/items:poll";

                    /// <summary>Initializes Poll parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^datasources/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Pushes an item onto a queue for later polling and updating. This API requires an admin or service
                /// account to execute. The service account used is the one whitelisted in the corresponding data
                /// source.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name of the item to push into the indexing queue. Format: datasources/{source_id}/items/{ID}
                /// This is a required field. The maximum length is 1536 characters.
                /// </param>
                public virtual PushRequest Push(Google.Apis.CloudSearch.v1.Data.PushItemRequest body, string name)
                {
                    return new PushRequest(service, body, name);
                }

                /// <summary>
                /// Pushes an item onto a queue for later polling and updating. This API requires an admin or service
                /// account to execute. The service account used is the one whitelisted in the corresponding data
                /// source.
                /// </summary>
                public class PushRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.Item>
                {
                    /// <summary>Constructs a new Push request.</summary>
                    public PushRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSearch.v1.Data.PushItemRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the item to push into the indexing queue. Format: datasources/{source_id}/items/{ID}
                    /// This is a required field. The maximum length is 1536 characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudSearch.v1.Data.PushItemRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "push";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/indexing/{+name}:push";

                    /// <summary>Initializes Push parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^datasources/[^/]+/items/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Unreserves all items from a queue, making them all eligible to be polled. This method is useful for
                /// resetting the indexing queue after a connector has been restarted. This API requires an admin or
                /// service account to execute. The service account used is the one whitelisted in the corresponding
                /// data source.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name of the Data Source to unreserve all items. Format: datasources/{source_id}
                /// </param>
                public virtual UnreserveRequest Unreserve(Google.Apis.CloudSearch.v1.Data.UnreserveItemsRequest body, string name)
                {
                    return new UnreserveRequest(service, body, name);
                }

                /// <summary>
                /// Unreserves all items from a queue, making them all eligible to be polled. This method is useful for
                /// resetting the indexing queue after a connector has been restarted. This API requires an admin or
                /// service account to execute. The service account used is the one whitelisted in the corresponding
                /// data source.
                /// </summary>
                public class UnreserveRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Unreserve request.</summary>
                    public UnreserveRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSearch.v1.Data.UnreserveItemsRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the Data Source to unreserve all items. Format: datasources/{source_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudSearch.v1.Data.UnreserveItemsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "unreserve";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/indexing/{+name}/items:unreserve";

                    /// <summary>Initializes Unreserve parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^datasources/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Creates an upload session for uploading item content. For items smaller than 100 KB, it's easier to
                /// embed the content inline within an index request. This API requires an admin or service account to
                /// execute. The service account used is the one whitelisted in the corresponding data source.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name of the Item to start a resumable upload. Format: datasources/{source_id}/items/{item_id}.
                /// The maximum length is 1536 bytes.
                /// </param>
                public virtual UploadRequest Upload(Google.Apis.CloudSearch.v1.Data.StartUploadItemRequest body, string name)
                {
                    return new UploadRequest(service, body, name);
                }

                /// <summary>
                /// Creates an upload session for uploading item content. For items smaller than 100 KB, it's easier to
                /// embed the content inline within an index request. This API requires an admin or service account to
                /// execute. The service account used is the one whitelisted in the corresponding data source.
                /// </summary>
                public class UploadRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.UploadItemRef>
                {
                    /// <summary>Constructs a new Upload request.</summary>
                    public UploadRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSearch.v1.Data.StartUploadItemRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the Item to start a resumable upload. Format:
                    /// datasources/{source_id}/items/{item_id}. The maximum length is 1536 bytes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudSearch.v1.Data.StartUploadItemRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "upload";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/indexing/{+name}:upload";

                    /// <summary>Initializes Upload parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^datasources/[^/]+/items/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>
            /// Deletes the schema of a data source. **Note:** This API requires an admin or service account to execute.
            /// </summary>
            /// <param name="name">The name of the data source to delete Schema. Format: datasources/{source_id}</param>
            public virtual DeleteSchemaRequest DeleteSchema(string name)
            {
                return new DeleteSchemaRequest(service, name);
            }

            /// <summary>
            /// Deletes the schema of a data source. **Note:** This API requires an admin or service account to execute.
            /// </summary>
            public class DeleteSchemaRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.Operation>
            {
                /// <summary>Constructs a new DeleteSchema request.</summary>
                public DeleteSchemaRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>The name of the data source to delete Schema. Format: datasources/{source_id}</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// If you are asked by Google to help with debugging, set this field. Otherwise, ignore this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("debugOptions.enableDebugging", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> DebugOptionsEnableDebugging { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "deleteSchema";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/indexing/{+name}/schema";

                /// <summary>Initializes DeleteSchema parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^datasources/[^/]+$",
                    });
                    RequestParameters.Add("debugOptions.enableDebugging", new Google.Apis.Discovery.Parameter
                    {
                        Name = "debugOptions.enableDebugging",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Gets the schema of a data source. **Note:** This API requires an admin or service account to execute.
            /// </summary>
            /// <param name="name">The name of the data source to get Schema. Format: datasources/{source_id}</param>
            public virtual GetSchemaRequest GetSchema(string name)
            {
                return new GetSchemaRequest(service, name);
            }

            /// <summary>
            /// Gets the schema of a data source. **Note:** This API requires an admin or service account to execute.
            /// </summary>
            public class GetSchemaRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.Schema>
            {
                /// <summary>Constructs a new GetSchema request.</summary>
                public GetSchemaRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>The name of the data source to get Schema. Format: datasources/{source_id}</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// If you are asked by Google to help with debugging, set this field. Otherwise, ignore this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("debugOptions.enableDebugging", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> DebugOptionsEnableDebugging { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getSchema";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/indexing/{+name}/schema";

                /// <summary>Initializes GetSchema parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^datasources/[^/]+$",
                    });
                    RequestParameters.Add("debugOptions.enableDebugging", new Google.Apis.Discovery.Parameter
                    {
                        Name = "debugOptions.enableDebugging",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Updates the schema of a data source. This method does not perform incremental updates to the schema.
            /// Instead, this method updates the schema by overwriting the entire schema. **Note:** This API requires an
            /// admin or service account to execute.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">The name of the data source to update Schema. Format: datasources/{source_id}</param>
            public virtual UpdateSchemaRequest UpdateSchema(Google.Apis.CloudSearch.v1.Data.UpdateSchemaRequest body, string name)
            {
                return new UpdateSchemaRequest(service, body, name);
            }

            /// <summary>
            /// Updates the schema of a data source. This method does not perform incremental updates to the schema.
            /// Instead, this method updates the schema by overwriting the entire schema. **Note:** This API requires an
            /// admin or service account to execute.
            /// </summary>
            public class UpdateSchemaRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.Operation>
            {
                /// <summary>Constructs a new UpdateSchema request.</summary>
                public UpdateSchemaRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSearch.v1.Data.UpdateSchemaRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The name of the data source to update Schema. Format: datasources/{source_id}</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudSearch.v1.Data.UpdateSchemaRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateSchema";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/indexing/{+name}/schema";

                /// <summary>Initializes UpdateSchema parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^datasources/[^/]+$",
                    });
                }
            }
        }
    }

    /// <summary>The "media" collection of methods.</summary>
    public class MediaResource
    {
        private const string Resource = "media";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MediaResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Uploads media for indexing. The upload endpoint supports direct and resumable upload protocols and is
        /// intended for large items that can not be [inlined during index
        /// requests](https://developers.google.com/cloud-search/docs/reference/rest/v1/indexing.datasources.items#itemcontent).
        /// To index large content: 1. Call indexing.datasources.items.upload with the item name to begin an upload
        /// session and retrieve the UploadItemRef. 1. Call media.upload to upload the content, as a streaming request,
        /// using the same resource name from the UploadItemRef from step 1. 1. Call indexing.datasources.items.index to
        /// index the item. Populate the
        /// [ItemContent](/cloud-search/docs/reference/rest/v1/indexing.datasources.items#ItemContent) with the
        /// UploadItemRef from step 1. For additional information, see [Create a content connector using the REST
        /// API](https://developers.google.com/cloud-search/docs/guides/content-connector#rest). **Note:** This API
        /// requires a service account to execute.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceName">
        /// Name of the media that is being downloaded. See ReadRequest.resource_name.
        /// </param>
        public virtual UploadRequest Upload(Google.Apis.CloudSearch.v1.Data.Media body, string resourceName)
        {
            return new UploadRequest(service, body, resourceName);
        }

        /// <summary>
        /// Uploads media for indexing. The upload endpoint supports direct and resumable upload protocols and is
        /// intended for large items that can not be [inlined during index
        /// requests](https://developers.google.com/cloud-search/docs/reference/rest/v1/indexing.datasources.items#itemcontent).
        /// To index large content: 1. Call indexing.datasources.items.upload with the item name to begin an upload
        /// session and retrieve the UploadItemRef. 1. Call media.upload to upload the content, as a streaming request,
        /// using the same resource name from the UploadItemRef from step 1. 1. Call indexing.datasources.items.index to
        /// index the item. Populate the
        /// [ItemContent](/cloud-search/docs/reference/rest/v1/indexing.datasources.items#ItemContent) with the
        /// UploadItemRef from step 1. For additional information, see [Create a content connector using the REST
        /// API](https://developers.google.com/cloud-search/docs/guides/content-connector#rest). **Note:** This API
        /// requires a service account to execute.
        /// </summary>
        public class UploadRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.Media>
        {
            /// <summary>Constructs a new Upload request.</summary>
            public UploadRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSearch.v1.Data.Media body, string resourceName) : base(service)
            {
                ResourceName = resourceName;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the media that is being downloaded. See ReadRequest.resource_name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceName { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudSearch.v1.Data.Media Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "upload";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/media/{+resourceName}";

            /// <summary>Initializes Upload parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceName", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^.*$",
                });
            }
        }

        /// <summary>
        /// Uploads media for indexing. The upload endpoint supports direct and resumable upload protocols and is
        /// intended for large items that can not be [inlined during index
        /// requests](https://developers.google.com/cloud-search/docs/reference/rest/v1/indexing.datasources.items#itemcontent).
        /// To index large content: 1. Call indexing.datasources.items.upload with the item name to begin an upload
        /// session and retrieve the UploadItemRef. 1. Call media.upload to upload the content, as a streaming request,
        /// using the same resource name from the UploadItemRef from step 1. 1. Call indexing.datasources.items.index to
        /// index the item. Populate the
        /// [ItemContent](/cloud-search/docs/reference/rest/v1/indexing.datasources.items#ItemContent) with the
        /// UploadItemRef from step 1. For additional information, see [Create a content connector using the REST
        /// API](https://developers.google.com/cloud-search/docs/guides/content-connector#rest). **Note:** This API
        /// requires a service account to execute.
        /// </summary>
        /// <remarks>
        /// Considerations regarding <paramref name="stream"/>:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before reading
        /// commences. If <paramref name="stream"/> is not seekable, then it will be read from its current position
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
        /// </description>
        /// </item>
        /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
        /// </list>
        /// </remarks>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceName">
        /// Name of the media that is being downloaded. See ReadRequest.resource_name.
        /// </param>
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual UploadMediaUpload Upload(Google.Apis.CloudSearch.v1.Data.Media body, string resourceName, System.IO.Stream stream, string contentType)
        {
            return new UploadMediaUpload(service, body, resourceName, stream, contentType);
        }

        /// <summary>Upload media upload which supports resumable upload.</summary>
        public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.CloudSearch.v1.Data.Media, Google.Apis.CloudSearch.v1.Data.Media>
        {
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
            /// API key. Your API key identifies your project and provides you with API access, quota, and reports.
            /// Required unless you provide an OAuth 2.0 token.
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
            /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned
            /// to a user, but should not exceed 40 characters.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser { get; set; }

            /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
            [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UploadType { get; set; }

            /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
            [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UploadProtocol { get; set; }

            /// <summary>Name of the media that is being downloaded. See ReadRequest.resource_name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceName { get; private set; }

            /// <summary>Constructs a new Upload media upload instance.</summary>
            /// <remarks>
            /// Considerations regarding <paramref name="stream"/>:
            /// <list type="bullet">
            /// <item>
            /// <description>
            /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
            /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its current
            /// position
            /// </description>
            /// </item>
            /// <item>
            /// <description>
            /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
            /// </description>
            /// </item>
            /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
            /// </list>
            /// </remarks>
            public UploadMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.CloudSearch.v1.Data.Media body, string resourceName, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "v1/media/{+resourceName}"), "POST", stream, contentType)
            {
                ResourceName = resourceName;
                Body = body;
            }
        }
    }

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
            Lro = new LroResource(service);
        }

        /// <summary>Gets the Lro resource.</summary>
        public virtual LroResource Lro { get; }

        /// <summary>The "lro" collection of methods.</summary>
        public class LroResource
        {
            private const string Resource = "lro";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LroResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
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
            public class ListRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.ListOperationsResponse>
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
                public override string RestPath => "v1/{+name}/lro";

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
                        Pattern = @"^operations/.*$",
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
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service.
        /// </summary>
        /// <param name="name">The name of the operation resource.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service.
        /// </summary>
        public class GetRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.Operation>
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
                    Pattern = @"^operations/.*$",
                });
            }
        }
    }

    /// <summary>The "query" collection of methods.</summary>
    public class QueryResource
    {
        private const string Resource = "query";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public QueryResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Sources = new SourcesResource(service);
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
            }

            /// <summary>
            /// Returns list of sources that user can use for Search and Suggest APIs. **Note:** This API requires a
            /// standard end user account to execute. A service account can't perform Query API requests directly; to
            /// use a service account to perform queries, set up [Google Workspace domain-wide delegation of
            /// authority](https://developers.google.com/cloud-search/docs/guides/delegation/).
            /// </summary>
            public virtual ListRequest List()
            {
                return new ListRequest(service);
            }

            /// <summary>
            /// Returns list of sources that user can use for Search and Suggest APIs. **Note:** This API requires a
            /// standard end user account to execute. A service account can't perform Query API requests directly; to
            /// use a service account to perform queries, set up [Google Workspace domain-wide delegation of
            /// authority](https://developers.google.com/cloud-search/docs/guides/delegation/).
            /// </summary>
            public class ListRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.ListQuerySourcesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service) : base(service)
                {
                    InitParameters();
                }

                /// <summary>Number of sources to return in the response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// If you are asked by Google to help with debugging, set this field. Otherwise, ignore this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("requestOptions.debugOptions.enableDebugging", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> RequestOptionsDebugOptionsEnableDebugging { get; set; }

                /// <summary>
                /// The BCP-47 language code, such as "en-US" or "sr-Latn". For more information, see
                /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier. For translations. Set this field
                /// using the language set in browser or for the page. In the event that the user's language preference
                /// is known, set this field to the known user language. When specified, the documents in search results
                /// are biased towards the specified language. From Suggest API perspective, for 3p suggest this is used
                /// as a hint while making predictions to add language boosting.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("requestOptions.languageCode", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string RequestOptionsLanguageCode { get; set; }

                /// <summary>
                /// The ID generated when you create a search application using the [admin
                /// console](https://support.google.com/a/answer/9043922).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("requestOptions.searchApplicationId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string RequestOptionsSearchApplicationId { get; set; }

                /// <summary>
                /// Current user's time zone id, such as "America/Los_Angeles" or "Australia/Sydney". These IDs are
                /// defined by [Unicode Common Locale Data Repository (CLDR)](http://cldr.unicode.org/) project, and
                /// currently available in the file
                /// [timezone.xml](http://unicode.org/repos/cldr/trunk/common/bcp47/timezone.xml). This field is used to
                /// correctly interpret date and time queries. If this field is not specified, the default time zone
                /// (UTC) is used.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("requestOptions.timeZone", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string RequestOptionsTimeZone { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/query/sources";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("requestOptions.debugOptions.enableDebugging", new Google.Apis.Discovery.Parameter
                    {
                        Name = "requestOptions.debugOptions.enableDebugging",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("requestOptions.languageCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "requestOptions.languageCode",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("requestOptions.searchApplicationId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "requestOptions.searchApplicationId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("requestOptions.timeZone", new Google.Apis.Discovery.Parameter
                    {
                        Name = "requestOptions.timeZone",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>
        /// The Cloud Search Query API provides the search method, which returns the most relevant results from a user
        /// query. The results can come from Google Workspace apps, such as Gmail or Google Drive, or they can come from
        /// data that you have indexed from a third party. **Note:** This API requires a standard end user account to
        /// execute. A service account can't perform Query API requests directly; to use a service account to perform
        /// queries, set up [Google Workspace domain-wide delegation of
        /// authority](https://developers.google.com/cloud-search/docs/guides/delegation/).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual SearchRequest Search(Google.Apis.CloudSearch.v1.Data.SearchRequest body)
        {
            return new SearchRequest(service, body);
        }

        /// <summary>
        /// The Cloud Search Query API provides the search method, which returns the most relevant results from a user
        /// query. The results can come from Google Workspace apps, such as Gmail or Google Drive, or they can come from
        /// data that you have indexed from a third party. **Note:** This API requires a standard end user account to
        /// execute. A service account can't perform Query API requests directly; to use a service account to perform
        /// queries, set up [Google Workspace domain-wide delegation of
        /// authority](https://developers.google.com/cloud-search/docs/guides/delegation/).
        /// </summary>
        public class SearchRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.SearchResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSearch.v1.Data.SearchRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudSearch.v1.Data.SearchRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/query/search";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Provides suggestions for autocompleting the query. **Note:** This API requires a standard end user account
        /// to execute. A service account can't perform Query API requests directly; to use a service account to perform
        /// queries, set up [Google Workspace domain-wide delegation of
        /// authority](https://developers.google.com/cloud-search/docs/guides/delegation/).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual SuggestRequest Suggest(Google.Apis.CloudSearch.v1.Data.SuggestRequest body)
        {
            return new SuggestRequest(service, body);
        }

        /// <summary>
        /// Provides suggestions for autocompleting the query. **Note:** This API requires a standard end user account
        /// to execute. A service account can't perform Query API requests directly; to use a service account to perform
        /// queries, set up [Google Workspace domain-wide delegation of
        /// authority](https://developers.google.com/cloud-search/docs/guides/delegation/).
        /// </summary>
        public class SuggestRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.SuggestResponse>
        {
            /// <summary>Constructs a new Suggest request.</summary>
            public SuggestRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSearch.v1.Data.SuggestRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudSearch.v1.Data.SuggestRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "suggest";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/query/suggest";

            /// <summary>Initializes Suggest parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "settings" collection of methods.</summary>
    public class SettingsResource
    {
        private const string Resource = "settings";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SettingsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Datasources = new DatasourcesResource(service);
            Searchapplications = new SearchapplicationsResource(service);
        }

        /// <summary>Gets the Datasources resource.</summary>
        public virtual DatasourcesResource Datasources { get; }

        /// <summary>The "datasources" collection of methods.</summary>
        public class DatasourcesResource
        {
            private const string Resource = "datasources";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DatasourcesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a datasource. **Note:** This API requires an admin account to execute.</summary>
            /// <param name="body">The body of the request.</param>
            public virtual CreateRequest Create(Google.Apis.CloudSearch.v1.Data.DataSource body)
            {
                return new CreateRequest(service, body);
            }

            /// <summary>Creates a datasource. **Note:** This API requires an admin account to execute.</summary>
            public class CreateRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.Operation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSearch.v1.Data.DataSource body) : base(service)
                {
                    Body = body;
                    InitParameters();
                }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudSearch.v1.Data.DataSource Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/settings/datasources";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                }
            }

            /// <summary>Deletes a datasource. **Note:** This API requires an admin account to execute.</summary>
            /// <param name="name">The name of the datasource. Format: datasources/{source_id}.</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes a datasource. **Note:** This API requires an admin account to execute.</summary>
            public class DeleteRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.Operation>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>The name of the datasource. Format: datasources/{source_id}.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// If you are asked by Google to help with debugging, set this field. Otherwise, ignore this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("debugOptions.enableDebugging", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> DebugOptionsEnableDebugging { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/settings/{+name}";

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
                        Pattern = @"^datasources/[^/]+$",
                    });
                    RequestParameters.Add("debugOptions.enableDebugging", new Google.Apis.Discovery.Parameter
                    {
                        Name = "debugOptions.enableDebugging",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets a datasource. **Note:** This API requires an admin account to execute.</summary>
            /// <param name="name">The name of the datasource resource. Format: datasources/{source_id}.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a datasource. **Note:** This API requires an admin account to execute.</summary>
            public class GetRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.DataSource>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>The name of the datasource resource. Format: datasources/{source_id}.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// If you are asked by Google to help with debugging, set this field. Otherwise, ignore this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("debugOptions.enableDebugging", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> DebugOptionsEnableDebugging { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/settings/{+name}";

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
                        Pattern = @"^datasources/[^/]+$",
                    });
                    RequestParameters.Add("debugOptions.enableDebugging", new Google.Apis.Discovery.Parameter
                    {
                        Name = "debugOptions.enableDebugging",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists datasources. **Note:** This API requires an admin account to execute.</summary>
            public virtual ListRequest List()
            {
                return new ListRequest(service);
            }

            /// <summary>Lists datasources. **Note:** This API requires an admin account to execute.</summary>
            public class ListRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.ListDataSourceResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service) : base(service)
                {
                    InitParameters();
                }

                /// <summary>
                /// If you are asked by Google to help with debugging, set this field. Otherwise, ignore this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("debugOptions.enableDebugging", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> DebugOptionsEnableDebugging { get; set; }

                /// <summary>
                /// Maximum number of datasources to fetch in a request. The max value is 1000. The default value is
                /// 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Starting index of the results.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/settings/datasources";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("debugOptions.enableDebugging", new Google.Apis.Discovery.Parameter
                    {
                        Name = "debugOptions.enableDebugging",
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

            /// <summary>Updates a datasource. **Note:** This API requires an admin account to execute.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The name of the datasource resource. Format: datasources/{source_id}. The name is ignored when creating
            /// a datasource.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.CloudSearch.v1.Data.DataSource body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates a datasource. **Note:** This API requires an admin account to execute.</summary>
            public class PatchRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.Operation>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSearch.v1.Data.DataSource body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The name of the datasource resource. Format: datasources/{source_id}. The name is ignored when
                /// creating a datasource.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// If you are asked by Google to help with debugging, set this field. Otherwise, ignore this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("debugOptions.enableDebugging", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> DebugOptionsEnableDebugging { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudSearch.v1.Data.DataSource Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/settings/{+name}";

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
                        Pattern = @"^datasources/[^/]+$",
                    });
                    RequestParameters.Add("debugOptions.enableDebugging", new Google.Apis.Discovery.Parameter
                    {
                        Name = "debugOptions.enableDebugging",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates a datasource. **Note:** This API requires an admin account to execute.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The name of the datasource resource. Format: datasources/{source_id}. The name is ignored when creating
            /// a datasource.
            /// </param>
            public virtual UpdateRequest Update(Google.Apis.CloudSearch.v1.Data.UpdateDataSourceRequest body, string name)
            {
                return new UpdateRequest(service, body, name);
            }

            /// <summary>Updates a datasource. **Note:** This API requires an admin account to execute.</summary>
            public class UpdateRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.Operation>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSearch.v1.Data.UpdateDataSourceRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The name of the datasource resource. Format: datasources/{source_id}. The name is ignored when
                /// creating a datasource.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudSearch.v1.Data.UpdateDataSourceRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/settings/{+name}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^datasources/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the Searchapplications resource.</summary>
        public virtual SearchapplicationsResource Searchapplications { get; }

        /// <summary>The "searchapplications" collection of methods.</summary>
        public class SearchapplicationsResource
        {
            private const string Resource = "searchapplications";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SearchapplicationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a search application. **Note:** This API requires an admin account to execute.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            public virtual CreateRequest Create(Google.Apis.CloudSearch.v1.Data.SearchApplication body)
            {
                return new CreateRequest(service, body);
            }

            /// <summary>
            /// Creates a search application. **Note:** This API requires an admin account to execute.
            /// </summary>
            public class CreateRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.Operation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSearch.v1.Data.SearchApplication body) : base(service)
                {
                    Body = body;
                    InitParameters();
                }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudSearch.v1.Data.SearchApplication Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/settings/searchapplications";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                }
            }

            /// <summary>
            /// Deletes a search application. **Note:** This API requires an admin account to execute.
            /// </summary>
            /// <param name="name">
            /// The name of the search application to be deleted. Format: applications/{application_id}.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes a search application. **Note:** This API requires an admin account to execute.
            /// </summary>
            public class DeleteRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.Operation>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The name of the search application to be deleted. Format: applications/{application_id}.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// If you are asked by Google to help with debugging, set this field. Otherwise, ignore this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("debugOptions.enableDebugging", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> DebugOptionsEnableDebugging { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/settings/{+name}";

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
                        Pattern = @"^searchapplications/[^/]+$",
                    });
                    RequestParameters.Add("debugOptions.enableDebugging", new Google.Apis.Discovery.Parameter
                    {
                        Name = "debugOptions.enableDebugging",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Gets the specified search application. **Note:** This API requires an admin account to execute.
            /// </summary>
            /// <param name="name">
            /// The name of the search application. Format: searchapplications/{application_id}.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Gets the specified search application. **Note:** This API requires an admin account to execute.
            /// </summary>
            public class GetRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.SearchApplication>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>The name of the search application. Format: searchapplications/{application_id}.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// If you are asked by Google to help with debugging, set this field. Otherwise, ignore this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("debugOptions.enableDebugging", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> DebugOptionsEnableDebugging { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/settings/{+name}";

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
                        Pattern = @"^searchapplications/[^/]+$",
                    });
                    RequestParameters.Add("debugOptions.enableDebugging", new Google.Apis.Discovery.Parameter
                    {
                        Name = "debugOptions.enableDebugging",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Lists all search applications. **Note:** This API requires an admin account to execute.
            /// </summary>
            public virtual ListRequest List()
            {
                return new ListRequest(service);
            }

            /// <summary>
            /// Lists all search applications. **Note:** This API requires an admin account to execute.
            /// </summary>
            public class ListRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.ListSearchApplicationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service) : base(service)
                {
                    InitParameters();
                }

                /// <summary>
                /// If you are asked by Google to help with debugging, set this field. Otherwise, ignore this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("debugOptions.enableDebugging", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> DebugOptionsEnableDebugging { get; set; }

                /// <summary>The maximum number of items to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The next_page_token value returned from a previous List request, if any. The default value is 10
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/settings/searchapplications";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("debugOptions.enableDebugging", new Google.Apis.Discovery.Parameter
                    {
                        Name = "debugOptions.enableDebugging",
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
            /// Updates a search application. **Note:** This API requires an admin account to execute.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The name of the Search Application. Format: searchapplications/{application_id}.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.CloudSearch.v1.Data.SearchApplication body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Updates a search application. **Note:** This API requires an admin account to execute.
            /// </summary>
            public class PatchRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.Operation>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSearch.v1.Data.SearchApplication body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The name of the Search Application. Format: searchapplications/{application_id}.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudSearch.v1.Data.SearchApplication Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/settings/{+name}";

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
                        Pattern = @"^searchapplications/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Resets a search application to default settings. This will return an empty response. **Note:** This API
            /// requires an admin account to execute.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The name of the search application to be reset. Format: applications/{application_id}.
            /// </param>
            public virtual ResetRequest Reset(Google.Apis.CloudSearch.v1.Data.ResetSearchApplicationRequest body, string name)
            {
                return new ResetRequest(service, body, name);
            }

            /// <summary>
            /// Resets a search application to default settings. This will return an empty response. **Note:** This API
            /// requires an admin account to execute.
            /// </summary>
            public class ResetRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.Operation>
            {
                /// <summary>Constructs a new Reset request.</summary>
                public ResetRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSearch.v1.Data.ResetSearchApplicationRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The name of the search application to be reset. Format: applications/{application_id}.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudSearch.v1.Data.ResetSearchApplicationRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "reset";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/settings/{+name}:reset";

                /// <summary>Initializes Reset parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^searchapplications/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Updates a search application. **Note:** This API requires an admin account to execute.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The name of the Search Application. Format: searchapplications/{application_id}.
            /// </param>
            public virtual UpdateRequest Update(Google.Apis.CloudSearch.v1.Data.SearchApplication body, string name)
            {
                return new UpdateRequest(service, body, name);
            }

            /// <summary>
            /// Updates a search application. **Note:** This API requires an admin account to execute.
            /// </summary>
            public class UpdateRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.Operation>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSearch.v1.Data.SearchApplication body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The name of the Search Application. Format: searchapplications/{application_id}.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudSearch.v1.Data.SearchApplication Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/settings/{+name}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^searchapplications/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Get customer settings. **Note:** This API requires an admin account to execute.</summary>
        public virtual GetCustomerRequest GetCustomer()
        {
            return new GetCustomerRequest(service);
        }

        /// <summary>Get customer settings. **Note:** This API requires an admin account to execute.</summary>
        public class GetCustomerRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.CustomerSettings>
        {
            /// <summary>Constructs a new GetCustomer request.</summary>
            public GetCustomerRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getCustomer";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/settings/customer";

            /// <summary>Initializes GetCustomer parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Update customer settings. **Note:** This API requires an admin account to execute.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual UpdateCustomerRequest UpdateCustomer(Google.Apis.CloudSearch.v1.Data.CustomerSettings body)
        {
            return new UpdateCustomerRequest(service, body);
        }

        /// <summary>Update customer settings. **Note:** This API requires an admin account to execute.</summary>
        public class UpdateCustomerRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.Operation>
        {
            /// <summary>Constructs a new UpdateCustomer request.</summary>
            public UpdateCustomerRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSearch.v1.Data.CustomerSettings body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Update mask to control which fields get updated. If you specify a field in the update_mask but don't
            /// specify its value here, that field will be cleared. If the mask is not present or empty, all fields will
            /// be updated. Currently supported field paths: vpc_settings and audit_logging_settings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudSearch.v1.Data.CustomerSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateCustomer";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/settings/customer";

            /// <summary>Initializes UpdateCustomer parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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

    /// <summary>The "stats" collection of methods.</summary>
    public class StatsResource
    {
        private const string Resource = "stats";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public StatsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Index = new IndexResource(service);
            Query = new QueryResource(service);
            Session = new SessionResource(service);
            User = new UserResource(service);
        }

        /// <summary>Gets the Index resource.</summary>
        public virtual IndexResource Index { get; }

        /// <summary>The "index" collection of methods.</summary>
        public class IndexResource
        {
            private const string Resource = "index";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public IndexResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Datasources = new DatasourcesResource(service);
            }

            /// <summary>Gets the Datasources resource.</summary>
            public virtual DatasourcesResource Datasources { get; }

            /// <summary>The "datasources" collection of methods.</summary>
            public class DatasourcesResource
            {
                private const string Resource = "datasources";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DatasourcesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Gets indexed item statistics for a single data source. **Note:** This API requires a standard end
                /// user account to execute.
                /// </summary>
                /// <param name="name">
                /// The resource id of the data source to retrieve statistics for, in the following format:
                /// "datasources/{source_id}"
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets indexed item statistics for a single data source. **Note:** This API requires a standard end
                /// user account to execute.
                /// </summary>
                public class GetRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.GetDataSourceIndexStatsResponse>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource id of the data source to retrieve statistics for, in the following format:
                    /// "datasources/{source_id}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("fromDate.day", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> FromDateDay { get; set; }

                    /// <summary>Month of date. Must be from 1 to 12.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("fromDate.month", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> FromDateMonth { get; set; }

                    /// <summary>Year of date. Must be from 1 to 9999.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("fromDate.year", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> FromDateYear { get; set; }

                    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("toDate.day", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> ToDateDay { get; set; }

                    /// <summary>Month of date. Must be from 1 to 12.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("toDate.month", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> ToDateMonth { get; set; }

                    /// <summary>Year of date. Must be from 1 to 9999.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("toDate.year", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> ToDateYear { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/stats/index/{+name}";

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
                            Pattern = @"^datasources/[^/]+$",
                        });
                        RequestParameters.Add("fromDate.day", new Google.Apis.Discovery.Parameter
                        {
                            Name = "fromDate.day",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fromDate.month", new Google.Apis.Discovery.Parameter
                        {
                            Name = "fromDate.month",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fromDate.year", new Google.Apis.Discovery.Parameter
                        {
                            Name = "fromDate.year",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("toDate.day", new Google.Apis.Discovery.Parameter
                        {
                            Name = "toDate.day",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("toDate.month", new Google.Apis.Discovery.Parameter
                        {
                            Name = "toDate.month",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("toDate.year", new Google.Apis.Discovery.Parameter
                        {
                            Name = "toDate.year",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }
        }

        /// <summary>Gets the Query resource.</summary>
        public virtual QueryResource Query { get; }

        /// <summary>The "query" collection of methods.</summary>
        public class QueryResource
        {
            private const string Resource = "query";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public QueryResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Searchapplications = new SearchapplicationsResource(service);
            }

            /// <summary>Gets the Searchapplications resource.</summary>
            public virtual SearchapplicationsResource Searchapplications { get; }

            /// <summary>The "searchapplications" collection of methods.</summary>
            public class SearchapplicationsResource
            {
                private const string Resource = "searchapplications";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SearchapplicationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Get the query statistics for search application. **Note:** This API requires a standard end user
                /// account to execute.
                /// </summary>
                /// <param name="name">
                /// The resource id of the search application query stats, in the following format:
                /// searchapplications/{application_id}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Get the query statistics for search application. **Note:** This API requires a standard end user
                /// account to execute.
                /// </summary>
                public class GetRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.GetSearchApplicationQueryStatsResponse>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource id of the search application query stats, in the following format:
                    /// searchapplications/{application_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("fromDate.day", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> FromDateDay { get; set; }

                    /// <summary>Month of date. Must be from 1 to 12.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("fromDate.month", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> FromDateMonth { get; set; }

                    /// <summary>Year of date. Must be from 1 to 9999.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("fromDate.year", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> FromDateYear { get; set; }

                    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("toDate.day", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> ToDateDay { get; set; }

                    /// <summary>Month of date. Must be from 1 to 12.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("toDate.month", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> ToDateMonth { get; set; }

                    /// <summary>Year of date. Must be from 1 to 9999.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("toDate.year", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> ToDateYear { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/stats/query/{+name}";

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
                            Pattern = @"^searchapplications/[^/]+$",
                        });
                        RequestParameters.Add("fromDate.day", new Google.Apis.Discovery.Parameter
                        {
                            Name = "fromDate.day",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fromDate.month", new Google.Apis.Discovery.Parameter
                        {
                            Name = "fromDate.month",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fromDate.year", new Google.Apis.Discovery.Parameter
                        {
                            Name = "fromDate.year",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("toDate.day", new Google.Apis.Discovery.Parameter
                        {
                            Name = "toDate.day",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("toDate.month", new Google.Apis.Discovery.Parameter
                        {
                            Name = "toDate.month",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("toDate.year", new Google.Apis.Discovery.Parameter
                        {
                            Name = "toDate.year",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }
        }

        /// <summary>Gets the Session resource.</summary>
        public virtual SessionResource Session { get; }

        /// <summary>The "session" collection of methods.</summary>
        public class SessionResource
        {
            private const string Resource = "session";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SessionResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Searchapplications = new SearchapplicationsResource(service);
            }

            /// <summary>Gets the Searchapplications resource.</summary>
            public virtual SearchapplicationsResource Searchapplications { get; }

            /// <summary>The "searchapplications" collection of methods.</summary>
            public class SearchapplicationsResource
            {
                private const string Resource = "searchapplications";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SearchapplicationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Get the # of search sessions, % of successful sessions with a click query statistics for search
                /// application. **Note:** This API requires a standard end user account to execute.
                /// </summary>
                /// <param name="name">
                /// The resource id of the search application session stats, in the following format:
                /// searchapplications/{application_id}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Get the # of search sessions, % of successful sessions with a click query statistics for search
                /// application. **Note:** This API requires a standard end user account to execute.
                /// </summary>
                public class GetRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.GetSearchApplicationSessionStatsResponse>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource id of the search application session stats, in the following format:
                    /// searchapplications/{application_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("fromDate.day", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> FromDateDay { get; set; }

                    /// <summary>Month of date. Must be from 1 to 12.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("fromDate.month", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> FromDateMonth { get; set; }

                    /// <summary>Year of date. Must be from 1 to 9999.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("fromDate.year", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> FromDateYear { get; set; }

                    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("toDate.day", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> ToDateDay { get; set; }

                    /// <summary>Month of date. Must be from 1 to 12.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("toDate.month", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> ToDateMonth { get; set; }

                    /// <summary>Year of date. Must be from 1 to 9999.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("toDate.year", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> ToDateYear { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/stats/session/{+name}";

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
                            Pattern = @"^searchapplications/[^/]+$",
                        });
                        RequestParameters.Add("fromDate.day", new Google.Apis.Discovery.Parameter
                        {
                            Name = "fromDate.day",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fromDate.month", new Google.Apis.Discovery.Parameter
                        {
                            Name = "fromDate.month",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fromDate.year", new Google.Apis.Discovery.Parameter
                        {
                            Name = "fromDate.year",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("toDate.day", new Google.Apis.Discovery.Parameter
                        {
                            Name = "toDate.day",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("toDate.month", new Google.Apis.Discovery.Parameter
                        {
                            Name = "toDate.month",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("toDate.year", new Google.Apis.Discovery.Parameter
                        {
                            Name = "toDate.year",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }
        }

        /// <summary>Gets the User resource.</summary>
        public virtual UserResource User { get; }

        /// <summary>The "user" collection of methods.</summary>
        public class UserResource
        {
            private const string Resource = "user";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public UserResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Searchapplications = new SearchapplicationsResource(service);
            }

            /// <summary>Gets the Searchapplications resource.</summary>
            public virtual SearchapplicationsResource Searchapplications { get; }

            /// <summary>The "searchapplications" collection of methods.</summary>
            public class SearchapplicationsResource
            {
                private const string Resource = "searchapplications";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SearchapplicationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Get the users statistics for search application. **Note:** This API requires a standard end user
                /// account to execute.
                /// </summary>
                /// <param name="name">
                /// The resource id of the search application session stats, in the following format:
                /// searchapplications/{application_id}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Get the users statistics for search application. **Note:** This API requires a standard end user
                /// account to execute.
                /// </summary>
                public class GetRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.GetSearchApplicationUserStatsResponse>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource id of the search application session stats, in the following format:
                    /// searchapplications/{application_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("fromDate.day", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> FromDateDay { get; set; }

                    /// <summary>Month of date. Must be from 1 to 12.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("fromDate.month", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> FromDateMonth { get; set; }

                    /// <summary>Year of date. Must be from 1 to 9999.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("fromDate.year", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> FromDateYear { get; set; }

                    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("toDate.day", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> ToDateDay { get; set; }

                    /// <summary>Month of date. Must be from 1 to 12.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("toDate.month", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> ToDateMonth { get; set; }

                    /// <summary>Year of date. Must be from 1 to 9999.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("toDate.year", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> ToDateYear { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/stats/user/{+name}";

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
                            Pattern = @"^searchapplications/[^/]+$",
                        });
                        RequestParameters.Add("fromDate.day", new Google.Apis.Discovery.Parameter
                        {
                            Name = "fromDate.day",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fromDate.month", new Google.Apis.Discovery.Parameter
                        {
                            Name = "fromDate.month",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fromDate.year", new Google.Apis.Discovery.Parameter
                        {
                            Name = "fromDate.year",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("toDate.day", new Google.Apis.Discovery.Parameter
                        {
                            Name = "toDate.day",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("toDate.month", new Google.Apis.Discovery.Parameter
                        {
                            Name = "toDate.month",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("toDate.year", new Google.Apis.Discovery.Parameter
                        {
                            Name = "toDate.year",
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
        /// Gets indexed item statistics aggreggated across all data sources. This API only returns statistics for
        /// previous dates; it doesn't return statistics for the current day. **Note:** This API requires a standard end
        /// user account to execute.
        /// </summary>
        public virtual GetIndexRequest GetIndex()
        {
            return new GetIndexRequest(service);
        }

        /// <summary>
        /// Gets indexed item statistics aggreggated across all data sources. This API only returns statistics for
        /// previous dates; it doesn't return statistics for the current day. **Note:** This API requires a standard end
        /// user account to execute.
        /// </summary>
        public class GetIndexRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.GetCustomerIndexStatsResponse>
        {
            /// <summary>Constructs a new GetIndex request.</summary>
            public GetIndexRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fromDate.day", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> FromDateDay { get; set; }

            /// <summary>Month of date. Must be from 1 to 12.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fromDate.month", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> FromDateMonth { get; set; }

            /// <summary>Year of date. Must be from 1 to 9999.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fromDate.year", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> FromDateYear { get; set; }

            /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
            [Google.Apis.Util.RequestParameterAttribute("toDate.day", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> ToDateDay { get; set; }

            /// <summary>Month of date. Must be from 1 to 12.</summary>
            [Google.Apis.Util.RequestParameterAttribute("toDate.month", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> ToDateMonth { get; set; }

            /// <summary>Year of date. Must be from 1 to 9999.</summary>
            [Google.Apis.Util.RequestParameterAttribute("toDate.year", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> ToDateYear { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getIndex";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/stats/index";

            /// <summary>Initializes GetIndex parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fromDate.day", new Google.Apis.Discovery.Parameter
                {
                    Name = "fromDate.day",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("fromDate.month", new Google.Apis.Discovery.Parameter
                {
                    Name = "fromDate.month",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("fromDate.year", new Google.Apis.Discovery.Parameter
                {
                    Name = "fromDate.year",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("toDate.day", new Google.Apis.Discovery.Parameter
                {
                    Name = "toDate.day",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("toDate.month", new Google.Apis.Discovery.Parameter
                {
                    Name = "toDate.month",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("toDate.year", new Google.Apis.Discovery.Parameter
                {
                    Name = "toDate.year",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Get the query statistics for customer. **Note:** This API requires a standard end user account to execute.
        /// </summary>
        public virtual GetQueryRequest GetQuery()
        {
            return new GetQueryRequest(service);
        }

        /// <summary>
        /// Get the query statistics for customer. **Note:** This API requires a standard end user account to execute.
        /// </summary>
        public class GetQueryRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.GetCustomerQueryStatsResponse>
        {
            /// <summary>Constructs a new GetQuery request.</summary>
            public GetQueryRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fromDate.day", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> FromDateDay { get; set; }

            /// <summary>Month of date. Must be from 1 to 12.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fromDate.month", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> FromDateMonth { get; set; }

            /// <summary>Year of date. Must be from 1 to 9999.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fromDate.year", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> FromDateYear { get; set; }

            /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
            [Google.Apis.Util.RequestParameterAttribute("toDate.day", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> ToDateDay { get; set; }

            /// <summary>Month of date. Must be from 1 to 12.</summary>
            [Google.Apis.Util.RequestParameterAttribute("toDate.month", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> ToDateMonth { get; set; }

            /// <summary>Year of date. Must be from 1 to 9999.</summary>
            [Google.Apis.Util.RequestParameterAttribute("toDate.year", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> ToDateYear { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getQuery";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/stats/query";

            /// <summary>Initializes GetQuery parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fromDate.day", new Google.Apis.Discovery.Parameter
                {
                    Name = "fromDate.day",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("fromDate.month", new Google.Apis.Discovery.Parameter
                {
                    Name = "fromDate.month",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("fromDate.year", new Google.Apis.Discovery.Parameter
                {
                    Name = "fromDate.year",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("toDate.day", new Google.Apis.Discovery.Parameter
                {
                    Name = "toDate.day",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("toDate.month", new Google.Apis.Discovery.Parameter
                {
                    Name = "toDate.month",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("toDate.year", new Google.Apis.Discovery.Parameter
                {
                    Name = "toDate.year",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Get search application stats for customer. **Note:** This API requires a standard end user account to
        /// execute.
        /// </summary>
        public virtual GetSearchapplicationRequest GetSearchapplication()
        {
            return new GetSearchapplicationRequest(service);
        }

        /// <summary>
        /// Get search application stats for customer. **Note:** This API requires a standard end user account to
        /// execute.
        /// </summary>
        public class GetSearchapplicationRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.GetCustomerSearchApplicationStatsResponse>
        {
            /// <summary>Constructs a new GetSearchapplication request.</summary>
            public GetSearchapplicationRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
            [Google.Apis.Util.RequestParameterAttribute("endDate.day", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> EndDateDay { get; set; }

            /// <summary>Month of date. Must be from 1 to 12.</summary>
            [Google.Apis.Util.RequestParameterAttribute("endDate.month", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> EndDateMonth { get; set; }

            /// <summary>Year of date. Must be from 1 to 9999.</summary>
            [Google.Apis.Util.RequestParameterAttribute("endDate.year", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> EndDateYear { get; set; }

            /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
            [Google.Apis.Util.RequestParameterAttribute("startDate.day", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> StartDateDay { get; set; }

            /// <summary>Month of date. Must be from 1 to 12.</summary>
            [Google.Apis.Util.RequestParameterAttribute("startDate.month", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> StartDateMonth { get; set; }

            /// <summary>Year of date. Must be from 1 to 9999.</summary>
            [Google.Apis.Util.RequestParameterAttribute("startDate.year", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> StartDateYear { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getSearchapplication";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/stats/searchapplication";

            /// <summary>Initializes GetSearchapplication parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("endDate.day", new Google.Apis.Discovery.Parameter
                {
                    Name = "endDate.day",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("endDate.month", new Google.Apis.Discovery.Parameter
                {
                    Name = "endDate.month",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("endDate.year", new Google.Apis.Discovery.Parameter
                {
                    Name = "endDate.year",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("startDate.day", new Google.Apis.Discovery.Parameter
                {
                    Name = "startDate.day",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("startDate.month", new Google.Apis.Discovery.Parameter
                {
                    Name = "startDate.month",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("startDate.year", new Google.Apis.Discovery.Parameter
                {
                    Name = "startDate.year",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Get the # of search sessions, % of successful sessions with a click query statistics for customer. **Note:**
        /// This API requires a standard end user account to execute.
        /// </summary>
        public virtual GetSessionRequest GetSession()
        {
            return new GetSessionRequest(service);
        }

        /// <summary>
        /// Get the # of search sessions, % of successful sessions with a click query statistics for customer. **Note:**
        /// This API requires a standard end user account to execute.
        /// </summary>
        public class GetSessionRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.GetCustomerSessionStatsResponse>
        {
            /// <summary>Constructs a new GetSession request.</summary>
            public GetSessionRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fromDate.day", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> FromDateDay { get; set; }

            /// <summary>Month of date. Must be from 1 to 12.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fromDate.month", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> FromDateMonth { get; set; }

            /// <summary>Year of date. Must be from 1 to 9999.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fromDate.year", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> FromDateYear { get; set; }

            /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
            [Google.Apis.Util.RequestParameterAttribute("toDate.day", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> ToDateDay { get; set; }

            /// <summary>Month of date. Must be from 1 to 12.</summary>
            [Google.Apis.Util.RequestParameterAttribute("toDate.month", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> ToDateMonth { get; set; }

            /// <summary>Year of date. Must be from 1 to 9999.</summary>
            [Google.Apis.Util.RequestParameterAttribute("toDate.year", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> ToDateYear { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getSession";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/stats/session";

            /// <summary>Initializes GetSession parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fromDate.day", new Google.Apis.Discovery.Parameter
                {
                    Name = "fromDate.day",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("fromDate.month", new Google.Apis.Discovery.Parameter
                {
                    Name = "fromDate.month",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("fromDate.year", new Google.Apis.Discovery.Parameter
                {
                    Name = "fromDate.year",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("toDate.day", new Google.Apis.Discovery.Parameter
                {
                    Name = "toDate.day",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("toDate.month", new Google.Apis.Discovery.Parameter
                {
                    Name = "toDate.month",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("toDate.year", new Google.Apis.Discovery.Parameter
                {
                    Name = "toDate.year",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Get the users statistics for customer. **Note:** This API requires a standard end user account to execute.
        /// </summary>
        public virtual GetUserRequest GetUser()
        {
            return new GetUserRequest(service);
        }

        /// <summary>
        /// Get the users statistics for customer. **Note:** This API requires a standard end user account to execute.
        /// </summary>
        public class GetUserRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.GetCustomerUserStatsResponse>
        {
            /// <summary>Constructs a new GetUser request.</summary>
            public GetUserRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fromDate.day", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> FromDateDay { get; set; }

            /// <summary>Month of date. Must be from 1 to 12.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fromDate.month", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> FromDateMonth { get; set; }

            /// <summary>Year of date. Must be from 1 to 9999.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fromDate.year", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> FromDateYear { get; set; }

            /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
            [Google.Apis.Util.RequestParameterAttribute("toDate.day", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> ToDateDay { get; set; }

            /// <summary>Month of date. Must be from 1 to 12.</summary>
            [Google.Apis.Util.RequestParameterAttribute("toDate.month", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> ToDateMonth { get; set; }

            /// <summary>Year of date. Must be from 1 to 9999.</summary>
            [Google.Apis.Util.RequestParameterAttribute("toDate.year", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> ToDateYear { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getUser";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/stats/user";

            /// <summary>Initializes GetUser parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fromDate.day", new Google.Apis.Discovery.Parameter
                {
                    Name = "fromDate.day",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("fromDate.month", new Google.Apis.Discovery.Parameter
                {
                    Name = "fromDate.month",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("fromDate.year", new Google.Apis.Discovery.Parameter
                {
                    Name = "fromDate.year",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("toDate.day", new Google.Apis.Discovery.Parameter
                {
                    Name = "toDate.day",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("toDate.month", new Google.Apis.Discovery.Parameter
                {
                    Name = "toDate.month",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("toDate.year", new Google.Apis.Discovery.Parameter
                {
                    Name = "toDate.year",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "v1" collection of methods.</summary>
    public class V1Resource
    {
        private const string Resource = "v1";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public V1Resource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Enables `third party` support in Google Cloud Search. **Note:** This API requires an admin account to
        /// execute.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual InitializeCustomerRequest InitializeCustomer(Google.Apis.CloudSearch.v1.Data.InitializeCustomerRequest body)
        {
            return new InitializeCustomerRequest(service, body);
        }

        /// <summary>
        /// Enables `third party` support in Google Cloud Search. **Note:** This API requires an admin account to
        /// execute.
        /// </summary>
        public class InitializeCustomerRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.Operation>
        {
            /// <summary>Constructs a new InitializeCustomer request.</summary>
            public InitializeCustomerRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSearch.v1.Data.InitializeCustomerRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudSearch.v1.Data.InitializeCustomerRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "initializeCustomer";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1:initializeCustomer";

            /// <summary>Initializes InitializeCustomer parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.CloudSearch.v1.Data
{
    /// <summary>Abuse reporting configuration outlining what is supported in this conference.</summary>
    public class AbuseReportingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the current call may include video recordings in its abuse reports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordingAllowed")]
        public virtual System.Nullable<bool> RecordingAllowed { get; set; }

        /// <summary>
        /// Whether the current call may include user generated content (chat, polls, Q&amp;amp;A...) in its abuse
        /// reports.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writtenUgcAllowed")]
        public virtual System.Nullable<bool> WrittenUgcAllowed { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about how devices in a meeting have acked for a session/operation.</summary>
    public class AckInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Number of meeting devices that have not acked yet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unackedDeviceCount")]
        public virtual System.Nullable<int> UnackedDeviceCount { get; set; }

        /// <summary>Output only. IDs of meeting devices (at most ten are provided) that have not acked yet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unackedDeviceIds")]
        public virtual System.Collections.Generic.IList<string> UnackedDeviceIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The request set by clients to instruct Backend how the user intend to fix the ACL. Technically it's not a
    /// request to ACL Fixer, because Backend uses /DriveService.Share to modify Drive ACLs.
    /// </summary>
    public class AclFixRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// For Spaces messages: This field is ignored. For DMs messages: The list of email addresses that should be
        /// added to the Drive item's ACL. In general, the list should not be empty when the boolean "should_fix" field
        /// is set; otherwise, the list should be empty. During transition - when clients do not specify this field but
        /// the "should_fix" is true, we follow the legacy behavior: share to all users in the DM regardless of emails.
        /// This behavior is being phased out.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recipientEmails")]
        public virtual System.Collections.Generic.IList<string> RecipientEmails { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>
        /// Whether to attempt to fix the ACL by adding the room or DM members to the Drive file's ACL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shouldFix")]
        public virtual System.Nullable<bool> ShouldFix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The message reconstructed based on information in the response of /PermissionFixOptionsService.Query (or the
    /// Apiary API that wraps it). Indicates the ability of the requester to change the access to the Drive file for the
    /// room roster or the DM members. Used in GetMessagePreviewMetadataResponse only.
    /// </summary>
    public class AclFixStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("fixability")]
        public virtual string Fixability { get; set; }

        /// <summary>
        /// List of recipient email addresses for which access can be granted. This field contains the same email
        /// addresses from the GetMessagePreviewMetadata request if all recipients can be successfully added to the ACL
        /// as determined by Drive ACL Fixer. For now, the field is non-empty if and only if the "fixability" value is
        /// "CAN_FIX".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixableEmailAddress")]
        public virtual System.Collections.Generic.IList<string> FixableEmailAddress { get; set; }

        /// <summary>
        /// List of recipient email addresses for which an out-of-domain-sharing warning must be shown, stating that
        /// these email addresses are not in the Google Apps organization that the requested item belong to. Empty if
        /// all recipients are in the same Google Apps organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outOfDomainWarningEmailAddress")]
        public virtual System.Collections.Generic.IList<string> OutOfDomainWarningEmailAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Next tag: 4</summary>
    public class AclInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of groups which have at least read access to the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupsCount")]
        public virtual System.Nullable<int> GroupsCount { get; set; }

        /// <summary>The scope to which the content was shared.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>Number of users which have at least read access to the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usersCount")]
        public virtual System.Nullable<int> UsersCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// List of string parameters that developers can specify when the above action method (in apps script) is invoked.
    /// An example use case is for 3 snooze buttons: snooze now, snooze 1 day, snooze next week. Developers can have
    /// action method = snooze() and pass the snooze type and snooze time in list of string parameters.
    /// </summary>
    public class ActionParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Earlier we used to populate just the affected_members list and inferred the new membership state (roles didn't
    /// exist back then) from the Type. go/dynamite-finra required backend to know the previous membership state to
    /// reconstruct membership history. The proper solution involved cleaning up up Type enum, but it was used in many,
    /// many places. This was added as a stop-gap solution to unblock FINRA without breaking everything. Later role
    /// update and target audience update started relying on this to communicate information to clients about what
    /// transition happened. So this is now required to be populated and should be in sync with affected_members for new
    /// messages.
    /// </summary>
    public class AffectedMembership : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("affectedMember")]
        public virtual MemberId AffectedMember { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("priorMembershipRole")]
        public virtual string PriorMembershipRole { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("priorMembershipState")]
        public virtual string PriorMembershipState { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("targetMembershipRole")]
        public virtual string TargetMembershipRole { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a principal who has authenticated as any kind of user which the application understands. This is
    /// typically used for "wiki-like" security, where anyone is allowed access so long as they can be held accountable
    /// for that access. Since the purpose is knowing whom to blame, it is up to the application to decide what kinds of
    /// users it knows how to blame. For example, an application might choose to include GAIA users in "all
    /// authenticated users", but not include MDB users. Nothing here.
    /// </summary>
    public class AllAuthenticatedUsersProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// NOTE WHEN ADDING NEW PROTO FIELDS: Be sure to add datapol annotations to new fields with potential PII, so they
    /// get scrubbed when logging protos for errors. NEXT TAG: 29
    /// </summary>
    public class Annotation : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("babelPlaceholderMetadata")]
        public virtual BabelPlaceholderMetadata BabelPlaceholderMetadata { get; set; }

        /// <summary>
        /// LINT.ThenChange(//depot/google3/java/com/google/apps/dynamite/v1/backend/action/common/SystemMessageHelper.java)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardCapabilityMetadata")]
        public virtual CardCapabilityMetadata CardCapabilityMetadata { get; set; }

        /// <summary>
        /// Whether the annotation should be rendered as a chip. If this is missing or unspecified, fallback to
        /// should_not_render on the metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chipRenderType")]
        public virtual string ChipRenderType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("consentedAppUnfurlMetadata")]
        public virtual ConsentedAppUnfurlMetadata ConsentedAppUnfurlMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("customEmojiMetadata")]
        public virtual CustomEmojiMetadata CustomEmojiMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("dataLossPreventionMetadata")]
        public virtual DataLossPreventionMetadata DataLossPreventionMetadata { get; set; }

        /// <summary>Chip annotations</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveMetadata")]
        public virtual DriveMetadata DriveMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("formatMetadata")]
        public virtual FormatMetadata FormatMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("groupRetentionSettingsUpdated")]
        public virtual GroupRetentionSettingsUpdatedMetaData GroupRetentionSettingsUpdated { get; set; }

        /// <summary>
        /// Metadata for 1P integrations like tasks, calendar. These are supported only through integration server as 1P
        /// integrations use the integration API (which in turn uses backend API with special permissions) to post
        /// messages. Clients should never set this. LINT.IfChange
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gsuiteIntegrationMetadata")]
        public virtual GsuiteIntegrationMetadata GsuiteIntegrationMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("incomingWebhookChangedMetadata")]
        public virtual IncomingWebhookChangedMetadata IncomingWebhookChangedMetadata { get; set; }

        /// <summary>
        /// LINT.ThenChange(//depot/google3/java/com/google/apps/dynamite/v1/backend/action/common/SystemMessageHelper.java)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrationConfigUpdated")]
        public virtual IntegrationConfigUpdatedMetadata IntegrationConfigUpdated { get; set; }

        /// <summary>
        /// Length of the text_body substring beginning from start_index the Annotation corresponds to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("length")]
        public virtual System.Nullable<int> Length { get; set; }

        /// <summary>
        /// A unique client-assigned ID for this annotation. This is helpful in matching the back-filled annotations to
        /// the original annotations on client side, without having to re-parse the message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localId")]
        public virtual string LocalId { get; set; }

        /// <summary>Metadata for system messages. Clients should never set this. LINT.IfChange</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipChanged")]
        public virtual MembershipChangedMetadata MembershipChanged { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("readReceiptsSettingsMetadata")]
        public virtual ReadReceiptsSettingsUpdatedMetadata ReadReceiptsSettingsMetadata { get; set; }

        /// <summary>
        /// Metadata that defines all of the required features that must be rendered in the message. Clients can use
        /// this to see whether they support the entire message, or show a fallback chip otherwise. See
        /// go/message-quoting-client-to-server for details. LINT.ThenChange(
        /// //depot/google3/java/com/google/apps/dynamite/v1/allshared/parser/AnnotationSanitizer.java,
        /// //depot/google3/java/com/google/apps/dynamite/v1/backend/action/common/SystemMessageHelper.java,
        /// //depot/google3/java/com/google/caribou/eli/mediation/chat/AnnotationTranslator.java )
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiredMessageFeaturesMetadata")]
        public virtual RequiredMessageFeaturesMetadata RequiredMessageFeaturesMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("roomUpdated")]
        public virtual RoomUpdatedMetadata RoomUpdated { get; set; }

        /// <summary>
        /// Whether or not the annotation is invalidated by the server. Example of situations for invalidation include:
        /// when the URL is malformed, or when Drive item ID is rejected by Drive Service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverInvalidated")]
        public virtual System.Nullable<bool> ServerInvalidated { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("slashCommandMetadata")]
        public virtual SlashCommandMetadata SlashCommandMetadata { get; set; }

        /// <summary>Start index (0-indexed) of the Message text the Annotation corresponds to, inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>Type of the Annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// A unique server-assigned ID for this annotation. This is helpful in matching annotation objects when fetched
        /// from service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uniqueId")]
        public virtual string UniqueId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("uploadMetadata")]
        public virtual UploadMetadata UploadMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("urlMetadata")]
        public virtual UrlMetadata UrlMetadata { get; set; }

        /// <summary>Metadata that clients can set for annotations. LINT.IfChange In-text annotations</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userMentionMetadata")]
        public virtual UserMentionMetadata UserMentionMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("videoCallMetadata")]
        public virtual VideoCallMetadata VideoCallMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("youtubeMetadata")]
        public virtual YoutubeMetadata YoutubeMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identifier of an App.</summary>
    public class AppId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Enum indicating the type of App this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appType")]
        public virtual string AppType { get; set; }

        /// <summary>
        /// Enum indicating which 1P App this is when app_type is GSUITE_APP. Determined &amp;amp; set by the 1P API as
        /// a convenience for all users of this identifier(Eg. clients, chime, backend etc.) to map to 1P properties.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gsuiteAppType")]
        public virtual string GsuiteAppType { get; set; }

        /// <summary>
        /// Numeric identifier of the App. Set to Project number for 1/3P Apps. For Webhook, this is WebhookId.
        /// Determined &amp;amp; set by the 1P API from App credentials on the side channel.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An action that describes the behavior when the form is submitted. For example, an Apps Script can be invoked to
    /// handle the form.
    /// </summary>
    public class AppsDynamiteSharedAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Apps Script function to invoke when the containing element is clicked/activated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("function")]
        public virtual string Function { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("interaction")]
        public virtual string Interaction { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("loadIndicator")]
        public virtual string LoadIndicator { get; set; }

        /// <summary>List of action parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<AppsDynamiteSharedActionActionParameter> Parameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// List of string parameters to supply when the action method is invoked. For example, consider three snooze
    /// buttons: snooze now, snooze 1 day, snooze next week. You might use action method = snooze(), passing the snooze
    /// type and snooze time in the list of string parameters.
    /// </summary>
    public class AppsDynamiteSharedActionActionParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the parameter for the action script.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The value of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Next Id: 7</summary>
    public class AppsDynamiteSharedActivityFeedAnnotationData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Timestamp of when the Activity Feed message that contains this annotation was created. This is roughly when
        /// the activity happened, such as when a reaction happened, but will have at least some small delay, since the
        /// Activity Feed message is created asynchronously after. This timestamp should only be used for display when
        /// the activity create time is not available in the Chat UI, like the time of a reaction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityFeedMessageCreateTime")]
        public virtual object ActivityFeedMessageCreateTime { get; set; }

        /// <summary>
        /// Unique id of the Activity Feed message used by clients to implement click-to-source. This is the same
        /// messageId as the top-level id field for the Activity Feed item.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityFeedMessageId")]
        public virtual MessageId ActivityFeedMessageId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("chatItem")]
        public virtual AppsDynamiteSharedChatItem ChatItem { get; set; }

        /// <summary>Only populated on read path and should not be persisted in storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sharedUserInfo")]
        public virtual UserInfo SharedUserInfo { get; set; }

        /// <summary>Use shared_user_info instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userInfo")]
        public virtual AppsDynamiteSharedActivityFeedAnnotationDataUserInfo UserInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>UserId of the AF item updater to show and the updater count to show.</summary>
    public class AppsDynamiteSharedActivityFeedAnnotationDataUserInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Describes how updater_count_to_show should be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updaterCountDisplayType")]
        public virtual string UpdaterCountDisplayType { get; set; }

        /// <summary>
        /// The number of updaters for clients to show, currently set to the total number of updaters minus the one set
        /// in updater_to_show.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updaterCountToShow")]
        public virtual System.Nullable<int> UpdaterCountToShow { get; set; }

        /// <summary>The updater for clients to show.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updaterToShow")]
        public virtual UserId UpdaterToShow { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Optional field for apps overriding display info</summary>
    public class AppsDynamiteSharedAppProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Displayed user avatar emoji.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avatarEmoji")]
        public virtual string AvatarEmoji { get; set; }

        /// <summary>Displayed user avatar url.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avatarUrl")]
        public virtual string AvatarUrl { get; set; }

        /// <summary>Displayed user name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This is the internal version of the API proto at google3/google/chat/v1/gsuite_message_integration.proto Data
    /// used to render Assistant suggestions. See go/bullseye-rendering.
    /// </summary>
    public class AppsDynamiteSharedAssistantAnnotationData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The suggestion to render in the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestion")]
        public virtual AppsDynamiteSharedAssistantSuggestion Suggestion { get; set; }

        /// <summary>
        /// Set when the initial query was unfulfillable. Only an on-demand unfulfillable query will result in a
        /// response (not a proactive query). 1. On-demand: user explicitly invokes the bot 2. Proactive: bot makes
        /// proactive suggestion (when available) by listening to all user messages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unfulfillable")]
        public virtual AppsDynamiteSharedAssistantUnfulfillableRequest Unfulfillable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents info regarding suggestion debug information.</summary>
    public class AppsDynamiteSharedAssistantDebugContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The query that triggered the resulting suggestion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data needed to render feedback on the Assistant card</summary>
    public class AppsDynamiteSharedAssistantFeedbackContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies a list of feedback chips to show</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedbackChips")]
        public virtual System.Collections.Generic.IList<AppsDynamiteSharedAssistantFeedbackContextFeedbackChip> FeedbackChips { get; set; }

        /// <summary>Whether the thumbs feedback is provided</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbsFeedback")]
        public virtual string ThumbsFeedback { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Suggestion chips for users to indicate positive or negative feedback</summary>
    public class AppsDynamiteSharedAssistantFeedbackContextFeedbackChip : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>What type of chip to display</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedbackChipType")]
        public virtual string FeedbackChipType { get; set; }

        /// <summary>Whether the chip has been selected</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Session context specific for Assistant suggestions.</summary>
    public class AppsDynamiteSharedAssistantSessionContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Unique identifier populated by the contextual request handler for each vertical (Ex: File Suggestions, Smart
        /// Scheduling, etc.) that can be used to track sessions end-to-end. May span multiple users (sender-specific).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contextualSessionId")]
        public virtual string ContextualSessionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data for an Assistant suggestion.</summary>
    public class AppsDynamiteSharedAssistantSuggestion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Info regarding suggestion debug information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugContext")]
        public virtual AppsDynamiteSharedAssistantDebugContext DebugContext { get; set; }

        /// <summary>Data for rendering feedback.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedbackContext")]
        public virtual AppsDynamiteSharedAssistantFeedbackContext FeedbackContext { get; set; }

        /// <summary>Suggestion type that suggests documents (docs, slides, sheets).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("findDocumentSuggestion")]
        public virtual AppsDynamiteSharedFindDocumentSuggestion FindDocumentSuggestion { get; set; }

        /// <summary>String representation of the suggestions provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serializedSuggestions")]
        public virtual string SerializedSuggestions { get; set; }

        /// <summary>Session context specific to the Assistant suggestion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionContext")]
        public virtual AppsDynamiteSharedAssistantSessionContext SessionContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data for a response to an unfulfillable request.</summary>
    public class AppsDynamiteSharedAssistantUnfulfillableRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AppsDynamiteSharedAvatarInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("emoji")]
        public virtual AppsDynamiteSharedEmoji Emoji { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata used only in Dynamite backend for uploaded attachments.</summary>
    public class AppsDynamiteSharedBackendUploadMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Blobstore path for the uploaded attachment</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobPath")]
        public virtual string BlobPath { get; set; }

        /// <summary>The original file name for the content, not the full path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentName")]
        public virtual string ContentName { get; set; }

        /// <summary>
        /// Scotty reported content size by default.
        /// http://google3/uploader/agent/scotty_agent.proto?l=101&amp;amp;rcl=140889785
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentSize")]
        public virtual System.Nullable<long> ContentSize { get; set; }

        /// <summary>
        /// Type is from Scotty's best_guess by default:
        /// http://google3/uploader/agent/scotty_agent.proto?l=51&amp;amp;rcl=140889785
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>
        /// The results of the Data Loss Prevention (DLP) scan of the attachment. DEPRECATED: use dlp_scan_summary
        /// instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dlpScanOutcome")]
        public virtual string DlpScanOutcome { get; set; }

        /// <summary>
        /// Summary of a Data Loss Prevention (DLP) scan of the attachment. Attachments are evaluated in the backend
        /// when they are uploaded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dlpScanSummary")]
        public virtual DlpScanSummary DlpScanSummary { get; set; }

        /// <summary>GroupId to which this attachment is uploaded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupId")]
        public virtual GroupId GroupId { get; set; }

        /// <summary>Original dimension of the content. Only set for image attachments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalDimension")]
        public virtual AppsDynamiteSharedDimension OriginalDimension { get; set; }

        /// <summary>
        /// The message id of a quote reply referencing this attachment. When present, this attachment has been quoted
        /// in a reply message. Normally, the attachment is fetched through the message id in the blob_path, but in the
        /// case of a quote reply, the blob_path would contain the quoted message id. Thus this message id field is
        /// needed to fetch the quote reply message instead. This field is conditionally populated at read time for
        /// quotes and never persisted in storage. See go/message-quoting-attachments for more context.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quoteReplyMessageId")]
        public virtual MessageId QuoteReplyMessageId { get; set; }

        /// <summary>The SHA256 hash of the attachment bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256")]
        public virtual string Sha256 { get; set; }

        /// <summary>User IP address at upload time. Ex. "123.1.2.3". Used by Ares abuse scanning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadIp")]
        public virtual string UploadIp { get; set; }

        /// <summary>Timestamp of when user finished uploading the content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadTimestampUsec")]
        public virtual System.Nullable<long> UploadTimestampUsec { get; set; }

        /// <summary>
        /// VideoID of the video attachments. This ID shall meets the Youtube ID format of 16 hex characters. For
        /// example, '4c14b8825af6059b' is a valid ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoId")]
        public virtual string VideoId { get; set; }

        /// <summary>Full Blobstore ID for the video thumbnail.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoThumbnailBlobId")]
        public virtual string VideoThumbnailBlobId { get; set; }

        /// <summary>Result for a virus scan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("virusScanResult")]
        public virtual string VirusScanResult { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the complete border style applied to widgets.</summary>
    public class AppsDynamiteSharedBorderStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The corner radius for the border.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cornerRadius")]
        public virtual System.Nullable<int> CornerRadius { get; set; }

        /// <summary>The colors to use when the type is `BORDER_TYPE_STROKE`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("strokeColor")]
        public virtual Color StrokeColor { get; set; }

        /// <summary>The border type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A button. Can be a text button or an image button.</summary>
    public class AppsDynamiteSharedButton : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The alternative text used for accessibility. Has no effect when an icon is set; use `icon.alt_text` instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altText")]
        public virtual string AltText { get; set; }

        /// <summary>If set, the button is filled with a solid background.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual Color Color { get; set; }

        /// <summary>If true, the button is displayed in a disabled state and doesn't respond to user actions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>The icon image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("icon")]
        public virtual AppsDynamiteSharedIcon Icon { get; set; }

        /// <summary>The action to perform when the button is clicked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual AppsDynamiteSharedOnClick OnClick { get; set; }

        /// <summary>The text of the button.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of buttons layed out horizontally.</summary>
    public class AppsDynamiteSharedButtonList : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("buttons")]
        public virtual System.Collections.Generic.IList<AppsDynamiteSharedButton> Buttons { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AppsDynamiteSharedCalendarEventAnnotationData : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("calendarEvent")]
        public virtual AppsDynamiteSharedCalendarEventAnnotationDataCalendarEvent CalendarEvent { get; set; }

        /// <summary>Notification about the creation of an event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventCreation")]
        public virtual AppsDynamiteSharedCalendarEventAnnotationDataEventCreation EventCreation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AppsDynamiteSharedCalendarEventAnnotationDataCalendarEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The end time of the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual AppsDynamiteSharedCalendarEventAnnotationDataCalendarEventTime EndTime { get; set; }

        /// <summary>ID of the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>The start time of the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual AppsDynamiteSharedCalendarEventAnnotationDataCalendarEventTime StartTime { get; set; }

        /// <summary>Title of the event (at the time the message was generated).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AppsDynamiteSharedCalendarEventAnnotationDataCalendarEventTime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All day event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allDay")]
        public virtual Date AllDay { get; set; }

        /// <summary>Non all day event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timed")]
        public virtual object Timed { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Creation of an event (no extra data for now).</summary>
    public class AppsDynamiteSharedCalendarEventAnnotationDataEventCreation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Data used to render Meet or Google Voice chips in Chat. See go/dynamite-calling-artifacts-in-chat.
    /// </summary>
    public class AppsDynamiteSharedCallAnnotationData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Timestamp when the call ended. Used to render the call ended system message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callEndedTimestamp")]
        public virtual object CallEndedTimestamp { get; set; }

        /// <summary>
        /// Required. Call metadata required to create the call artifacts. For now, the metadata contains only the call
        /// id to identify the call. This field allows additional data (e.g. voice call type) to be added if needed in
        /// the future.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callMetadata")]
        public virtual AppsDynamiteSharedCallMetadata CallMetadata { get; set; }

        /// <summary>Required. Indicates the call status for the space. Used to determine the chip's state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callStatus")]
        public virtual string CallStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata required to generate call artifacts. This can either be the metadata for a Meet or, in the future,
    /// Google Voice call.
    /// </summary>
    public class AppsDynamiteSharedCallMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata specific for the Meet call.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meetMetadata")]
        public virtual AppsDynamiteSharedMeetMetadata MeetMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A card is a UI element that can contain UI widgets such as text and images. For more information, see Cards .
    /// For example, the following JSON creates a card that has a header with the name, position, icons, and link for a
    /// contact, followed by a section with contact information like email and phone number. ``` { "header": { "title":
    /// "Heba Salam", "subtitle": "Software Engineer", "imageStyle": "ImageStyle.AVATAR", "imageUrl":
    /// "https://example.com/heba_salam.png", "imageAltText": "Avatar for Heba Salam" }, "sections" : [ { "header":
    /// "Contact Info", "widgets": [ { "decorated_text": { "icon": { "knownIcon": "EMAIL" }, "content":
    /// "heba.salam@example.com" } }, { "decoratedText": { "icon": { "knownIcon": "PERSON" }, "content": "Online" } }, {
    /// "decoratedText": { "icon": { "knownIcon": "PHONE" }, "content": "+1 (555) 555-1234" } }, { "buttons": [ {
    /// "textButton": { "text": "Share", }, "onClick": { "openLink": { "url": "https://example.com/share" } } }, {
    /// "textButton": { "text": "Edit", }, "onClick": { "action": { "function": "goToView", "parameters": [ { "key":
    /// "viewType", "value": "EDIT" } ], "loadIndicator": "LoadIndicator.SPINNER" } } } ] } ], "collapsible": true,
    /// "uncollapsibleWidgetsCount": 3 } ], "cardActions": [ { "actionLabel": "Send Feedback", "onClick": { "openLink":
    /// { "url": "https://example.com/feedback" } } } ], "name": "contact-card-K3wB6arF2H9L" } ```
    /// </summary>
    public class AppsDynamiteSharedCard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The actions of this card. They are added to a card's generated toolbar menu. For example, the following JSON
        /// constructs a card action menu with Settings and Send Feedback options: ``` "card_actions": [ {
        /// "actionLabel": "Setting", "onClick": { "action": { "functionName": "goToView", "parameters": [ { "key":
        /// "viewType", "value": "SETTING" } ], "loadIndicator": "LoadIndicator.SPINNER" } } }, { "actionLabel": "Send
        /// Feedback", "onClick": { "openLink": { "url": "https://example.com/feedback" } } } ] ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardActions")]
        public virtual System.Collections.Generic.IList<AppsDynamiteSharedCardCardAction> CardActions { get; set; }

        /// <summary>The header of the card. A header usually contains a title and an image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual AppsDynamiteSharedCardCardHeader Header { get; set; }

        /// <summary>Name of the card, which is used as a identifier for the card in card navigation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Sections are separated by a line divider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sections")]
        public virtual System.Collections.Generic.IList<AppsDynamiteSharedCardSection> Sections { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A card action is the action associated with the card. For example, an invoice card might include actions such as
    /// delete invoice, email invoice, or open the invoice in a browser.
    /// </summary>
    public class AppsDynamiteSharedCardCardAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The label that displays as the action menu item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionLabel")]
        public virtual string ActionLabel { get; set; }

        /// <summary>The onclick action for this action item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual AppsDynamiteSharedOnClick OnClick { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AppsDynamiteSharedCardCardHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The alternative text of this image which is used for accessibility.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageAltText")]
        public virtual string ImageAltText { get; set; }

        /// <summary>The image's type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageType")]
        public virtual string ImageType { get; set; }

        /// <summary>The URL of the image in the card header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; }

        /// <summary>The subtitle of the card header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
        public virtual string Subtitle { get; set; }

        /// <summary>
        /// The title of the card header. The title must be specified. The header has a fixed height: if both a title
        /// and subtitle are specified, each takes up one line. If only the title is specified, it takes up both lines.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Card click which identifies one suggestion provided by the app/bot.</summary>
    public class AppsDynamiteSharedCardClickSuggestion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identify the button/action that created the suggestion. A simple example would be a card button within the
        /// stream, or the id which can identify a specific suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual string ActionId { get; set; }

        /// <summary>The message_id for the message that was posted by the app/bot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestionMessageId")]
        public virtual MessageId SuggestionMessageId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A section contains a collection of widgets that are rendered vertically in the order that they are specified.
    /// Across all platforms, cards have a narrow fixed width, so there is currently no need for layout properties, for
    /// example, float.
    /// </summary>
    public class AppsDynamiteSharedCardSection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates whether this section is collapsible. If a section is collapsible, the description must be given.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collapsible")]
        public virtual System.Nullable<bool> Collapsible { get; set; }

        /// <summary>The header of the section. Formatted text is supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual string Header { get; set; }

        /// <summary>
        /// The number of uncollapsible widgets. For example, when a section contains five widgets and the
        /// `numUncollapsibleWidget` is set to `2`, the first two widgets are always shown and the last three are
        /// collapsed as default. The `numUncollapsibleWidget` is taken into account only when collapsible is set to
        /// `true`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uncollapsibleWidgetsCount")]
        public virtual System.Nullable<int> UncollapsibleWidgetsCount { get; set; }

        /// <summary>A section must contain at least 1 widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widgets")]
        public virtual System.Collections.Generic.IList<AppsDynamiteSharedWidget> Widgets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Next Id: 5</summary>
    public class AppsDynamiteSharedChatItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information needed to render the specific type of feed item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityInfo")]
        public virtual System.Collections.Generic.IList<AppsDynamiteSharedChatItemActivityInfo> ActivityInfo { get; set; }

        /// <summary>Only populated on read path and should not be persisted in storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupInfo")]
        public virtual AppsDynamiteSharedChatItemGroupInfo GroupInfo { get; set; }

        /// <summary>
        /// Additional information about the original chat message that isn't captured in the top-level message proto.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageInfo")]
        public virtual AppsDynamiteSharedMessageInfo MessageInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AppsDynamiteSharedChatItemActivityInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("feedItemNudge")]
        public virtual AppsDynamiteSharedChatItemActivityInfoFeedItemNudge FeedItemNudge { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("feedItemReactions")]
        public virtual AppsDynamiteSharedChatItemActivityInfoFeedItemReactions FeedItemReactions { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("feedItemThreadReply")]
        public virtual AppsDynamiteSharedChatItemActivityInfoFeedItemThreadReply FeedItemThreadReply { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("feedItemUserMention")]
        public virtual AppsDynamiteSharedChatItemActivityInfoFeedItemUserMention FeedItemUserMention { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Existence of this attribute indicates that the AF item is for a message nudge item.</summary>
    public class AppsDynamiteSharedChatItemActivityInfoFeedItemNudge : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Nudge type of the nudge feed item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nudgeType")]
        public virtual string NudgeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Existence of this attribute indicates that the AF item is for message reactions, but it is intentionally left
    /// empty since the list of reactions can be found in the top-level Message.Reactions.
    /// </summary>
    public class AppsDynamiteSharedChatItemActivityInfoFeedItemReactions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Existence of this attribute indicates that the AF item is for thread reply.</summary>
    public class AppsDynamiteSharedChatItemActivityInfoFeedItemThreadReply : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Reply type of the thread reply feed item. The field is not persisted in storage. It's populated when
        /// constructing Activity Feed payload.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replyType")]
        public virtual string ReplyType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Existence of this attribute indicates that the AF item is for a user mention item.</summary>
    public class AppsDynamiteSharedChatItemActivityInfoFeedItemUserMention : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>User mention type</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about the space that the item originated from. This will be used to display Activity Feed items from
    /// rooms, and only contain the necessary information, such as the space name and group attributes. NEXT TAG: 6
    /// </summary>
    public class AppsDynamiteSharedChatItemGroupInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This is needed to determine what type of group the source message came from to support click-to-source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeCheckerGroupType")]
        public virtual string AttributeCheckerGroupType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("groupName")]
        public virtual string GroupName { get; set; }

        /// <summary>Timestamp of when the group containing the message has been read by the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupReadTimeUsec")]
        public virtual System.Nullable<long> GroupReadTimeUsec { get; set; }

        /// <summary>
        /// Indicates whether the group has inline replies enabled. If enabled, clients will render the space with
        /// inline replies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inlineThreadingEnabled")]
        public virtual System.Nullable<bool> InlineThreadingEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Columns widget that displays a single row of columns.</summary>
    public class AppsDynamiteSharedColumns : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Each card supports up to 2 columns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnItems")]
        public virtual System.Collections.Generic.IList<AppsDynamiteSharedColumnsColumn> ColumnItems { get; set; }

        /// <summary>Controls how the column resizes based on screen width.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wrapStyle")]
        public virtual string WrapStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Column that consists of widgets stacked vertically.</summary>
    public class AppsDynamiteSharedColumnsColumn : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The horizontal alignment of the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("horizontalAlignment")]
        public virtual string HorizontalAlignment { get; set; }

        /// <summary>Specifies how the column content is sized horizontally.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("horizontalSizeStyle")]
        public virtual string HorizontalSizeStyle { get; set; }

        /// <summary>The vertical alignment of the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verticalAlignment")]
        public virtual string VerticalAlignment { get; set; }

        /// <summary>
        /// LINT.ThenChange(//google/apps/card/v1/card.proto) Array of widgets included in the column.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widgets")]
        public virtual System.Collections.Generic.IList<AppsDynamiteSharedColumnsColumnWidgets> Widgets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>LINT.IfChange The `column` widget can contain these widgets.</summary>
    public class AppsDynamiteSharedColumnsColumnWidgets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ButtonList widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buttonList")]
        public virtual AppsDynamiteSharedButtonList ButtonList { get; set; }

        /// <summary>DateTimePicker widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateTimePicker")]
        public virtual AppsDynamiteSharedDateTimePicker DateTimePicker { get; set; }

        /// <summary>DecoratedText widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("decoratedText")]
        public virtual AppsDynamiteSharedDecoratedText DecoratedText { get; set; }

        /// <summary>Image widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual AppsDynamiteSharedImage Image { get; set; }

        /// <summary>SelectionInput widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectionInput")]
        public virtual AppsDynamiteSharedSelectionInput SelectionInput { get; set; }

        /// <summary>TextInput widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textInput")]
        public virtual AppsDynamiteSharedTextInput TextInput { get; set; }

        /// <summary>Text paragraph widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textParagraph")]
        public virtual AppsDynamiteSharedTextParagraph TextParagraph { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Denotes a type of content report a user can send.</summary>
    public class AppsDynamiteSharedContentReportType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Google-defined system violation, covering the most common violations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemViolation")]
        public virtual string SystemViolation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Proto representation of a custom emoji. May be used in both APIs and in Spanner, but certain fields should be
    /// restricted to one or the other. See the per-field documentation for details. NEXT_TAG: 14
    /// </summary>
    public class AppsDynamiteSharedCustomEmoji : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// ID for the underlying image data in Blobstore. This field should *only* be present in Spanner or within the
        /// server, but should not be exposed in public APIs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobId")]
        public virtual string BlobId { get; set; }

        /// <summary>
        /// Content type of the file used to upload the emoji. Used for takeout. Written to Spanner when the emoji is
        /// created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>
        /// Time when the Emoji was created, in microseconds. This field may be present in Spanner, within the server,
        /// or in public APIs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTimeMicros")]
        public virtual System.Nullable<long> CreateTimeMicros { get; set; }

        /// <summary>This field should *never* be persisted to Spanner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creatorUserId")]
        public virtual UserId CreatorUserId { get; set; }

        /// <summary>
        /// Time when the emoji was deleted, in microseconds. This field may be present in Spanner, within the server,
        /// or in public APIs. Only present if the emoji has been deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTimeMicros")]
        public virtual System.Nullable<long> DeleteTimeMicros { get; set; }

        /// <summary>
        /// Output only. A short-lived URL clients can use for directly accessing a custom emoji image. This field is
        /// intended for API consumption, and should *never* be persisted to Spanner.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ephemeralUrl")]
        public virtual string EphemeralUrl { get; set; }

        /// <summary>This field should *never* be persisted to Spanner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerCustomerId")]
        public virtual CustomerId OwnerCustomerId { get; set; }

        /// <summary>
        /// Opaque token that clients use to construct the URL for accessing the custom emoji’s image data. This field
        /// is intended for API consumption, and should *never* be persisted to Spanner.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readToken")]
        public virtual string ReadToken { get; set; }

        /// <summary>
        /// User-provided, human-readable ID for the custom emoji. Users are expected to observe this field in the UI
        /// instead of the UUID. This shortcode should be unique within an organization, but has no global uniqueness
        /// guarantees, unlike the UUID. This field should *never* be persisted to Spanner.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortcode")]
        public virtual string Shortcode { get; set; }

        /// <summary>
        /// Snapshot of the current state of the emoji, which may differ from the source-of-truth in the CustomEmojis
        /// table. This field should *never* be persisted to Spanner.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("updateTimeMicros")]
        public virtual System.Nullable<long> UpdateTimeMicros { get; set; }

        /// <summary>Unique key for a custom emoji resource. Required. This field is *always* populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uuid")]
        public virtual string Uuid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The widget that lets users to specify a date and time.</summary>
    public class AppsDynamiteSharedDateTimePicker : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The label for the field that displays to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>The name of the text input that's used in formInput, and uniquely identifies this input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Triggered when the user clicks Save or Clear from the date/time picker dialog. This is only triggered if the
        /// value changed as a result of the Save/Clear operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onChangeAction")]
        public virtual AppsDynamiteSharedAction OnChangeAction { get; set; }

        /// <summary>
        /// The number representing the time zone offset from UTC, in minutes. If set, the `value_ms_epoch` is displayed
        /// in the specified time zone. If not set, it uses the user's time zone setting on the client side.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timezoneOffsetDate")]
        public virtual System.Nullable<int> TimezoneOffsetDate { get; set; }

        /// <summary>The type of the date/time picker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// The value to display as the default value before user input or previous user input. It is represented in
        /// milliseconds (Epoch time). For `DATE_AND_TIME` type, the full epoch value is used. For `DATE_ONLY` type,
        /// only date of the epoch time is used. For `TIME_ONLY` type, only time of the epoch time is used. For example,
        /// you can set epoch time to `3 * 60 * 60 * 1000` to represent 3am.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueMsEpoch")]
        public virtual System.Nullable<long> ValueMsEpoch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A widget that displays text with optional decorations such as a label above or below the text, an icon in front
    /// of the text, a selection widget or a button after the text.
    /// </summary>
    public class AppsDynamiteSharedDecoratedText : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The formatted text label that shows below the main text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bottomLabel")]
        public virtual string BottomLabel { get; set; }

        /// <summary>A button that can be clicked to trigger an action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("button")]
        public virtual AppsDynamiteSharedButton Button { get; set; }

        /// <summary>An icon displayed after the text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endIcon")]
        public virtual AppsDynamiteSharedIcon EndIcon { get; set; }

        /// <summary>Deprecated in favor of start_icon.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("icon")]
        public virtual AppsDynamiteSharedIcon Icon { get; set; }

        /// <summary>Only the top and bottom label and content region are clickable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual AppsDynamiteSharedOnClick OnClick { get; set; }

        /// <summary>The icon displayed in front of the text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIcon")]
        public virtual AppsDynamiteSharedIcon StartIcon { get; set; }

        /// <summary>A switch widget can be clicked to change its state or trigger an action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("switchControl")]
        public virtual AppsDynamiteSharedDecoratedTextSwitchControl SwitchControl { get; set; }

        /// <summary>Required. The main widget formatted text. See Text formatting for details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The formatted text label that shows above the main text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topLabel")]
        public virtual string TopLabel { get; set; }

        /// <summary>
        /// The wrap text setting. If `true`, the text is wrapped and displayed in multiline. Otherwise, the text is
        /// truncated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wrapText")]
        public virtual System.Nullable<bool> WrapText { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AppsDynamiteSharedDecoratedTextSwitchControl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The control type, either switch or checkbox.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlType")]
        public virtual string ControlType { get; set; }

        /// <summary>The name of the switch widget that's used in formInput.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The action when the switch state is changed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onChangeAction")]
        public virtual AppsDynamiteSharedAction OnChangeAction { get; set; }

        /// <summary>If the switch is selected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selected")]
        public virtual System.Nullable<bool> Selected { get; set; }

        /// <summary>The value is what is passed back in the callback.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Dimension for the uploaded attachments.</summary>
    public class AppsDynamiteSharedDimension : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A divider that appears in between widgets.</summary>
    public class AppsDynamiteSharedDivider : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>LINT.IfChange</summary>
    public class AppsDynamiteSharedDlpMetricsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[required] Describes the DLP status of message send and attachment upload events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dlpStatus")]
        public virtual string DlpStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data for rendering a document.</summary>
    public class AppsDynamiteSharedDocument : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unique file ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileId")]
        public virtual string FileId { get; set; }

        /// <summary>Justification to explain why this document is being suggested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("justification")]
        public virtual AppsDynamiteSharedJustification Justification { get; set; }

        /// <summary>Time the document was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifiedTime")]
        public virtual object LastModifiedTime { get; set; }

        /// <summary>Used to determine which icon to render (e.g. docs, slides, sheets)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>Title of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>URL of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AppsDynamiteSharedEmoji : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A custom emoji.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customEmoji")]
        public virtual AppsDynamiteSharedCustomEmoji CustomEmoji { get; set; }

        /// <summary>A basic emoji represented by a unicode string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unicode")]
        public virtual string Unicode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data for a FindDocument suggestion type.</summary>
    public class AppsDynamiteSharedFindDocumentSuggestion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of documents to render as suggestions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentSuggestions")]
        public virtual System.Collections.Generic.IList<AppsDynamiteSharedDocument> DocumentSuggestions { get; set; }

        /// <summary>Whether to show the action buttons in the card for the suggestions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("showActionButtons")]
        public virtual System.Nullable<bool> ShowActionButtons { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Grid widget that displays items in a configurable grid layout.</summary>
    public class AppsDynamiteSharedGrid : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The border style to apply to each grid item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borderStyle")]
        public virtual AppsDynamiteSharedBorderStyle BorderStyle { get; set; }

        /// <summary>
        /// The number of columns to display in the grid. A default value is used if this field isn't specified, and
        /// that default value is different depending on where the grid is shown (dialog versus companion).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnCount")]
        public virtual System.Nullable<int> ColumnCount { get; set; }

        /// <summary>The items to display in the grid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<AppsDynamiteSharedGridGridItem> Items { get; set; }

        /// <summary>
        /// This callback is reused by each individual grid item, but with the item's identifier and index in the items
        /// list added to the callback's parameters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual AppsDynamiteSharedOnClick OnClick { get; set; }

        /// <summary>The text that displays in the grid header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a single item in the grid layout.</summary>
    public class AppsDynamiteSharedGridGridItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A user-specified identifier for this grid item. This identifier is returned in the parent Grid's onClick
        /// callback parameters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The image that displays in the grid item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual AppsDynamiteSharedImageComponent Image { get; set; }

        /// <summary>The layout to use for the grid item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual string Layout { get; set; }

        /// <summary>The grid item's subtitle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
        public virtual string Subtitle { get; set; }

        /// <summary>The horizontal alignment of the grid item's text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAlignment")]
        public virtual string TextAlignment { get; set; }

        /// <summary>The grid item's title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>NEXT TAG: 3 A GroupDetails proto will store the information pertaining to single Group.</summary>
    public class AppsDynamiteSharedGroupDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A simple text that describes the purpose of a single Group, the general theme of the topics to be posted
        /// and/or the denominator of the Group participants.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// A simple text describing the rules and expectations from members when participating in conversation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guidelines")]
        public virtual string Guidelines { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AppsDynamiteSharedGroupVisibility : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AppsDynamiteSharedIcon : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The description of the icon, used for accessibility. The default value is provided if you don't specify one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altText")]
        public virtual string AltText { get; set; }

        /// <summary>The icon specified by a URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconUrl")]
        public virtual string IconUrl { get; set; }

        /// <summary>
        /// The crop style applied to the image. In some cases, applying a `CIRCLE` crop causes the image to be drawn
        /// larger than a standard icon.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageType")]
        public virtual string ImageType { get; set; }

        /// <summary>The icon specified by the string name of a list of known icons</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("knownIcon")]
        public virtual string KnownIcon { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An image that is specified by a URL and can have an onClick action.</summary>
    public class AppsDynamiteSharedImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The alternative text of this image, used for accessibility.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altText")]
        public virtual string AltText { get; set; }

        /// <summary>An image URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual AppsDynamiteSharedOnClick OnClick { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AppsDynamiteSharedImageComponent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The accessibility label for the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altText")]
        public virtual string AltText { get; set; }

        /// <summary>The border style to apply to the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borderStyle")]
        public virtual AppsDynamiteSharedBorderStyle BorderStyle { get; set; }

        /// <summary>The crop style to apply to the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cropStyle")]
        public virtual AppsDynamiteSharedImageCropStyle CropStyle { get; set; }

        /// <summary>The image URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the crop style applied to an image.</summary>
    public class AppsDynamiteSharedImageCropStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The aspect ratio to use if the crop type is `RECTANGLE_CUSTOM`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aspectRatio")]
        public virtual System.Nullable<double> AspectRatio { get; set; }

        /// <summary>The crop type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data for rendering a justification for a document.</summary>
    public class AppsDynamiteSharedJustification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Time the action took place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionTime")]
        public virtual object ActionTime { get; set; }

        /// <summary>Type of action performed on the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionType")]
        public virtual string ActionType { get; set; }

        /// <summary>Owner of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentOwner")]
        public virtual AppsDynamiteSharedJustificationPerson DocumentOwner { get; set; }

        /// <summary>
        /// Words or phrases from the user's query that describes the document content. (Ex: Users query is "Can you
        /// share the document about Bullseye?" the extracted topic would be "Bullseye").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topics")]
        public virtual System.Collections.Generic.IList<string> Topics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data for rendering a person associated with a document.</summary>
    public class AppsDynamiteSharedJustificationPerson : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the person is the recipient of the suggestions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRecipient")]
        public virtual System.Nullable<bool> IsRecipient { get; set; }

        /// <summary>Obfuscated user ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual UserId User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata specific for a Meet call that are required to generate call artifacts.</summary>
    public class AppsDynamiteSharedMeetMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A globally unique code (e.g. "cxv-zbgj-wzw") that points to a meeting space. Note: Meeting codes
        /// may be regenerated, which will cause old meeting codes to become invalid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meetingCode")]
        public virtual string MeetingCode { get; set; }

        /// <summary>
        /// Required. A URL, in the format "https://meet.google.com/*" (e.g. https://meet.google.com/cxv-zbgj-wzw), to
        /// identify and access the meeting space.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meetingUrl")]
        public virtual string MeetingUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information that references a Dynamite chat message. This is only used for Activity Feed messages.
    /// </summary>
    public class AppsDynamiteSharedMessageInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Id of the source chat message. This is kept here because the top-level message ID to refers the AF message
        /// ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageId")]
        public virtual MessageId MessageId { get; set; }

        /// <summary>The type of the source chat message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageType")]
        public virtual string MessageType { get; set; }

        /// <summary>
        /// Timestamp of when the topic containing the message has been read by the user. This is populated if the
        /// message references an inline reply, in which case the space may be marked as read but the topic still has
        /// unread messages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicReadTimeUsec")]
        public virtual System.Nullable<long> TopicReadTimeUsec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The payload(restricted to 1P applications) to be stored with a specific message.</summary>
    public class AppsDynamiteSharedMessageIntegrationPayload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pantheon project number used to identify the calling app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectNumber")]
        public virtual System.Nullable<long> ProjectNumber { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tasksMessageIntegrationPayload")]
        public virtual AppsDynamiteSharedTasksMessageIntegrationPayload TasksMessageIntegrationPayload { get; set; }

        /// <summary>
        /// An enum indicating which 1P application's payload this is. This field is required to add 1P payload.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AppsDynamiteSharedOnClick : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If specified, an action is triggered by this onClick.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual AppsDynamiteSharedAction Action { get; set; }

        /// <summary>
        /// An add-on triggers this action when the action needs to open a link. This differs from the open_link above
        /// in that this needs to talk to server to get the link. Thus some preparation work is required for web client
        /// to do before the open link action response comes back.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openDynamicLinkAction")]
        public virtual AppsDynamiteSharedAction OpenDynamicLinkAction { get; set; }

        /// <summary>If specified, this onClick triggers an open link action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openLink")]
        public virtual AppsDynamiteSharedOpenLink OpenLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AppsDynamiteSharedOpenLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Represents the platform specific uri/intent to open on each client. For example: A companion_url will open
        /// in a companion window on the web. An iOS URL and android intent will open in the corresponding hosting apps.
        /// If these platform specific URLs can't be handled correctly, i.e. if the companion isn't supported on web and
        /// the hosting apps aren't available on the mobile platforms then the `uri` will open in a new browser window
        /// on all the platforms.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appUri")]
        public virtual AppsDynamiteSharedOpenLinkAppUri AppUri { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("onClose")]
        public virtual string OnClose { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("openAs")]
        public virtual string OpenAs { get; set; }

        /// <summary>The URL to open.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the platform specific uri/intent to open for each client.</summary>
    public class AppsDynamiteSharedOpenLinkAppUri : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An intent object to be opened in the corresponding android hosting app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidIntent")]
        public virtual AppsDynamiteSharedOpenLinkAppUriIntent AndroidIntent { get; set; }

        /// <summary>A companion uri string to be opened in the chat companion window. on the web.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("companionUri")]
        public virtual string CompanionUri { get; set; }

        /// <summary>A uri string to be opened in the corresponding iOS hosting app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosUri")]
        public virtual string IosUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Android intent.</summary>
    public class AppsDynamiteSharedOpenLinkAppUriIntent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of extra data for the android intent. For example, for a calendar event edit intent, the event title
        /// information can be passed as extra data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extraData")]
        public virtual System.Collections.Generic.IList<AppsDynamiteSharedOpenLinkAppUriIntentExtraData> ExtraData { get; set; }

        /// <summary>
        /// An android intent action string for the {@link android.content.Intent} object. For example: for the view
        /// intent action type, a valid value will be android.content.Intent.ACTION_VIEW.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intentAction")]
        public virtual string IntentAction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Extra data for an android intent. Valid keys are defined in the hosting app contract.</summary>
    public class AppsDynamiteSharedOpenLinkAppUriIntentExtraData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A key for the intent extra data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Value for the given extra data key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains info about the entity that something is, or is owned by.</summary>
    public class AppsDynamiteSharedOrganizationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("consumerInfo")]
        public virtual AppsDynamiteSharedOrganizationInfoConsumerInfo ConsumerInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("customerInfo")]
        public virtual AppsDynamiteSharedOrganizationInfoCustomerInfo CustomerInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Intentionally empty. Used to disambiguate consumer and customer use cases in oneof below.</summary>
    public class AppsDynamiteSharedOrganizationInfoConsumerInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AppsDynamiteSharedOrganizationInfoCustomerInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
        public virtual CustomerId CustomerId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Stores the suggestion provided by apps/bots.</summary>
    public class AppsDynamiteSharedOriginAppSuggestion : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual AppId AppId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("cardClickSuggestion")]
        public virtual AppsDynamiteSharedCardClickSuggestion CardClickSuggestion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AppsDynamiteSharedPhoneNumber : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The phone number type, e.g., work, mobile, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The actual phone number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AppsDynamiteSharedReaction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total number of users who have reacted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<int> Count { get; set; }

        /// <summary>When the first emoji of this type was added.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTimestamp")]
        public virtual System.Nullable<long> CreateTimestamp { get; set; }

        /// <summary>
        /// Whether the current user reacted using this emoji. Note: Unlike most properties of messages, this is
        /// different per-user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentUserParticipated")]
        public virtual System.Nullable<bool> CurrentUserParticipated { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("emoji")]
        public virtual AppsDynamiteSharedEmoji Emoji { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The settings of retention period of a message or topic.</summary>
    public class AppsDynamiteSharedRetentionSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The timestamp after which the message/topic should be removed, in microseconds since the epoch, when state
        /// == EPHEMERAL_ONE_DAY. The value should not be set in other cases.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiryTimestamp")]
        public virtual System.Nullable<long> ExpiryTimestamp { get; set; }

        /// <summary>The retention state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains info on membership count for member types: HUMAN_USER, APP_USER &amp;amp; ROSTER_MEMBER different
    /// states: INVITED, JOINED
    /// </summary>
    public class AppsDynamiteSharedSegmentedMembershipCount : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("memberType")]
        public virtual string MemberType { get; set; }

        /// <summary>count of members with given type and state</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipCount")]
        public virtual System.Nullable<int> MembershipCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("membershipState")]
        public virtual string MembershipState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AppsDynamiteSharedSegmentedMembershipCounts : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Collections.Generic.IList<AppsDynamiteSharedSegmentedMembershipCount> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A widget that creates a UI item (for example, a drop-down list) with options for users to select.
    /// </summary>
    public class AppsDynamiteSharedSelectionInput : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<AppsDynamiteSharedSelectionInputSelectionItem> Items { get; set; }

        /// <summary>The label displayed ahead of the switch control.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>The name of the text input which is used in formInput.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// If specified, the form is submitted when the selection changes. If not specified, you must specify a
        /// separate button.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onChangeAction")]
        public virtual AppsDynamiteSharedAction OnChangeAction { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The item in the switch control. A radio button, at most one of the items is selected.</summary>
    public class AppsDynamiteSharedSelectionInputSelectionItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If more than one item is selected for `RADIO_BUTTON` and `DROPDOWN`, the first selected item is treated as
        /// selected and the ones after are ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selected")]
        public virtual System.Nullable<bool> Selected { get; set; }

        /// <summary>The text to be displayed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The value associated with this item. The client should use this as a form input value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines the representation of a single matching space.</summary>
    public class AppsDynamiteSharedSpaceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("avatarInfo")]
        public virtual AppsDynamiteSharedAvatarInfo AvatarInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("avatarUrl")]
        public virtual string AvatarUrl { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("groupId")]
        public virtual GroupId GroupId { get; set; }

        /// <summary>
        /// The email address of the user that invited the calling user to the room, if available. This field will only
        /// be populated for direct invites, it will be empty if the user was indirectly invited to the group.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inviterEmail")]
        public virtual string InviterEmail { get; set; }

        /// <summary>Whether this is a space that enables guest access</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isExternal")]
        public virtual System.Nullable<bool> IsExternal { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("numMembers")]
        public virtual System.Nullable<int> NumMembers { get; set; }

        /// <summary>searching user's membership state in this space</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userMembershipState")]
        public virtual string UserMembershipState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A container wrapping elements necessary for showing suggestion items used in text input autocomplete.
    /// </summary>
    public class AppsDynamiteSharedSuggestions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of suggestions items which will be used in are used in autocomplete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<AppsDynamiteSharedSuggestionsSuggestionItem> Items { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A suggestion item. Only supports text for now.</summary>
    public class AppsDynamiteSharedSuggestionsSuggestionItem : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This is the internal version of the API proto at google3/google/chat/v1/gsuite_message_integration.proto
    /// </summary>
    public class AppsDynamiteSharedTasksAnnotationData : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("assigneeChange")]
        public virtual AppsDynamiteSharedTasksAnnotationDataAssigneeChange AssigneeChange { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("completionChange")]
        public virtual AppsDynamiteSharedTasksAnnotationDataCompletionChange CompletionChange { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("creation")]
        public virtual AppsDynamiteSharedTasksAnnotationDataCreation Creation { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("deletionChange")]
        public virtual AppsDynamiteSharedTasksAnnotationDataDeletionChange DeletionChange { get; set; }

        /// <summary>ID of task. Will be used to create deep links to Tasks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskId")]
        public virtual string TaskId { get; set; }

        /// <summary>Task properties after the update has been applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskProperties")]
        public virtual AppsDynamiteSharedTasksAnnotationDataTaskProperties TaskProperties { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userDefinedMessage")]
        public virtual AppsDynamiteSharedTasksAnnotationDataUserDefinedMessage UserDefinedMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AppsDynamiteSharedTasksAnnotationDataAssigneeChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Obfuscated user ID of previous assignee. Not set if the task was originally not assigned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldAssignee")]
        public virtual UserId OldAssignee { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AppsDynamiteSharedTasksAnnotationDataCompletionChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AppsDynamiteSharedTasksAnnotationDataCreation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AppsDynamiteSharedTasksAnnotationDataDeletionChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>All relevant task properties for a Chat message.</summary>
    public class AppsDynamiteSharedTasksAnnotationDataTaskProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Obfuscated user ID of new assignee. Not set if the task doesn't have an assignee.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignee")]
        public virtual UserId Assignee { get; set; }

        /// <summary>Whether the task is marked as completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completed")]
        public virtual System.Nullable<bool> Completed { get; set; }

        /// <summary>Whether the task is marked as deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleted")]
        public virtual System.Nullable<bool> Deleted { get; set; }

        /// <summary>
        /// The description of the task. If Task original description's length is greater than 1024, then Task BE sends
        /// the truncated description to Dynamite Integration Server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Set if the task has a date but no time. Source of truth in Tasks BE: http://shortn/_wyT7eB4Ixv
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual Date StartDate { get; set; }

        /// <summary>
        /// Set if the task has both a date and a time. Source of truth in Tasks BE: http://shortn/_u6cr0F5ttE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The title of the task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Used for task card attachments on custom user messages that should be kept as is without generating an i18n
    /// event message, e.g. the user starts a conversation from an existing task. IMPORTANT: please don't populate this
    /// field yet as it could break existing flows until it's implemented. See code at http://shortn/_CM74CdENMx used by
    /// http://shortn/_5o85POJY8Q.
    /// </summary>
    public class AppsDynamiteSharedTasksAnnotationDataUserDefinedMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A payload containing Tasks metadata for rendering a live card. Currently not used by the Tasks integration.
    /// </summary>
    public class AppsDynamiteSharedTasksMessageIntegrationPayload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A text input is a UI item where users can input text. A text input can also have an onChange action and
    /// suggestions.
    /// </summary>
    public class AppsDynamiteSharedTextInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The refresh function that returns suggestions based on the user's input text. If the callback is not
        /// specified, autocomplete is done in client side based on the initial suggestion items.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoCompleteAction")]
        public virtual AppsDynamiteSharedAction AutoCompleteAction { get; set; }

        /// <summary>The hint text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hintText")]
        public virtual string HintText { get; set; }

        /// <summary>The initial suggestions made before any user input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialSuggestions")]
        public virtual AppsDynamiteSharedSuggestions InitialSuggestions { get; set; }

        /// <summary>At least one of label and hintText must be specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>The name of the text input which is used in formInput.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The onChange action, for example, invoke a function.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onChangeAction")]
        public virtual AppsDynamiteSharedAction OnChangeAction { get; set; }

        /// <summary>The style of the text, for example, a single line or multiple lines.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The default value when there is no input from the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A paragraph of text that supports formatting. See [Text
    /// formatting](workspace/add-ons/concepts/widgets#text_formatting") for details.
    /// </summary>
    public class AppsDynamiteSharedTextParagraph : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The text that's shown in the widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>User-block relationship</summary>
    public class AppsDynamiteSharedUserBlockRelationship : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("hasBlockedRequester")]
        public virtual System.Nullable<bool> HasBlockedRequester { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("isBlockedByRequester")]
        public virtual System.Nullable<bool> IsBlockedByRequester { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Reference to a transcoded video attachment.</summary>
    public class AppsDynamiteSharedVideoReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Available transcode format. Value is defined in video/storage/proto/content_header.proto</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> Format { get; set; }

        /// <summary>Transcode status</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A widget is a UI element that presents texts, images, etc.</summary>
    public class AppsDynamiteSharedWidget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of buttons. For example, the following JSON creates two buttons. The first is a filled text button
        /// and the second is an image button that opens a link: ``` "buttonList": { "buttons": [ "button": { "text":
        /// "Edit", "Color": { "Red": 255 "Green": 255 "Blue": 255 } "disabled": true }, "button": { "icon": {
        /// "knownIcon": "INVITE" "altText": "check calendar" }, "onClick": { "openLink": { "url":
        /// "https://example.com/calendar" } } }, ] } ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buttonList")]
        public virtual AppsDynamiteSharedButtonList ButtonList { get; set; }

        /// <summary>
        /// Displays a single row of columns with widgets stacked vertically in each column. For example, the following
        /// JSON creates a 2 column widget each containing a single item. ``` "columns": { "wrapStyle": "WRAP",
        /// "columnItems": [ { "horizontalSizeStyle": "FILL_AVAILABLE_SPACE", "horizontalAlignment": "CENTER",
        /// "verticalAlignment" : "CENTER", "widgets": [ { "textParagraph": { "text": "First column text paragraph", } }
        /// ] }, { "horizontalSizeStyle": "FILL_AVAILABLE_SPACE", "horizontalAlignment": "CENTER", "verticalAlignment" :
        /// "CENTER", "widgets": [ { "textParagraph": { "text": "Second column text paragraph", } } ] }, ] } } ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual AppsDynamiteSharedColumns Columns { get; set; }

        /// <summary>
        /// Displays a selection/input widget for date/time. For example, the following JSON creates a date/time picker
        /// for an appointment time: ``` "date_time_picker": { "name": "appointment_time", "label": "Book your
        /// appointment at:", "type": "DateTimePickerType.DATE_AND_TIME", "valueMsEpoch": "796435200000" } ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateTimePicker")]
        public virtual AppsDynamiteSharedDateTimePicker DateTimePicker { get; set; }

        /// <summary>
        /// Displays a decorated text item in this widget. For example, the following JSON creates a decorated text
        /// widget showing email address: ``` "decoratedText": { "icon": { "knownIcon": "EMAIL" }, "topLabel": "Email
        /// Address", "content": "heba.salam@example.com", "bottomLabel": "This is a new Email address!",
        /// "switchWidget": { "name": "has_send_welcome_email_to_heba_salam", "selected": false, "controlType":
        /// "ControlType.CHECKBOX" } } ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("decoratedText")]
        public virtual AppsDynamiteSharedDecoratedText DecoratedText { get; set; }

        /// <summary>
        /// Displays a divider. For example, the following JSON creates a divider: ``` "divider": { } ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("divider")]
        public virtual AppsDynamiteSharedDivider Divider { get; set; }

        /// <summary>
        /// Displays a grid with a collection of items. For example, the following JSON creates a 2 column grid with a
        /// single item: ``` "grid": { "title": "A fine collection of items", "numColumns": 2, "borderStyle": { "type":
        /// "STROKE", "cornerRadius": 4.0 }, "items": [ "image": { "imageUri": "https://www.example.com/image.png",
        /// "cropStyle": { "type": "SQUARE" }, "borderStyle": { "type": "STROKE" } }, "title": "An item",
        /// "textAlignment": "CENTER" ], "onClick": { "openLink": { "url":"https://www.example.com" } } } ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grid")]
        public virtual AppsDynamiteSharedGrid Grid { get; set; }

        /// <summary>The horizontal alignment of this widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("horizontalAlignment")]
        public virtual string HorizontalAlignment { get; set; }

        /// <summary>
        /// Displays an image in this widget. For example, the following JSON creates an image with alternative text:
        /// ``` "image": { "imageUrl": "https://example.com/heba_salam.png" "altText": "Avatar for Heba Salam" } ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual AppsDynamiteSharedImage Image { get; set; }

        /// <summary>
        /// Displays a switch control in this widget. For example, the following JSON creates a dropdown selection for
        /// size: ``` "switchControl": { "name": "size", "label": "Size" "type": "SelectionType.DROPDOWN", "items": [ {
        /// "text": "S", "value": "small", "selected": false }, { "text": "M", "value": "medium", "selected": true }, {
        /// "text": "L", "value": "large", "selected": false }, { "text": "XL", "value": "extra_large", "selected":
        /// false } ] } ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectionInput")]
        public virtual AppsDynamiteSharedSelectionInput SelectionInput { get; set; }

        /// <summary>
        /// Displays a text input in this widget. For example, the following JSON creates a text input for mail address:
        /// ``` "textInput": { "name": "mailing_address", "label": "Mailing Address" } ``` As another example, the
        /// following JSON creates a text input for programming language with static suggestions: ``` "textInput": {
        /// "name": "preferred_programing_language", "label": "Preferred Language", "initialSuggestions": { "items": [ {
        /// "text": "C++" }, { "text": "Java" }, { "text": "JavaScript" }, { "text": "Python" } ] } } ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textInput")]
        public virtual AppsDynamiteSharedTextInput TextInput { get; set; }

        /// <summary>
        /// Displays a text paragraph in this widget. For example, the following JSON creates a bolded text: ```
        /// "textParagraph": { "text": " *bold text*" } ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textParagraph")]
        public virtual AppsDynamiteSharedTextParagraph TextParagraph { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Interactive objects inside a message. Documentation: - https://api.slack.com/docs/message-buttons
    /// </summary>
    public class AppsDynamiteV1ApiCompatV1Action : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Confirmation dialog config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confirm")]
        public virtual AppsDynamiteV1ApiCompatV1ActionConfirm Confirm { get; set; }

        /// <summary>Unique identifier for this action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Button style ("default", "primary", or "danger").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("style")]
        public virtual string Style { get; set; }

        /// <summary>User-facing label for the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>Action type - currently only "button".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Payload for this action. Will be sent to the action handler along with name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Confirmation dialog config.</summary>
    public class AppsDynamiteV1ApiCompatV1ActionConfirm : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>"Cancel" button label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dismiss_text")]
        public virtual string DismissText { get; set; }

        /// <summary>"OK" button label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ok_text")]
        public virtual string OkText { get; set; }

        /// <summary>Confirmation dialog body text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>Confirmation dialog title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Richly formatted attachments. Documentation: - https://api.slack.com/docs/message-attachments</summary>
    public class AppsDynamiteV1ApiCompatV1Attachment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Array of actions (currently only buttons).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actions")]
        public virtual System.Collections.Generic.IList<AppsDynamiteV1ApiCompatV1Action> Actions { get; set; }

        /// <summary>
        /// Undocumented - used in interactive button examples. The only valid value appears to be "default".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachment_type")]
        public virtual string AttachmentType { get; set; }

        /// <summary>Avatar URL for the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("author_icon")]
        public virtual string AuthorIcon { get; set; }

        /// <summary>URL that the user name should link to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("author_link")]
        public virtual string AuthorLink { get; set; }

        /// <summary>User name to display as the author of the message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("author_name")]
        public virtual string AuthorName { get; set; }

        /// <summary>
        /// Unique identifier for the collection of buttons within this attachment. Will be sent back to the action
        /// handler URL when a button is clicked.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callback_id")]
        public virtual string CallbackId { get; set; }

        /// <summary>A color "bar" to display to the left of the attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual string Color { get; set; }

        /// <summary>Fallback plain-text string for clients that don't support attachments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fallback")]
        public virtual string Fallback { get; set; }

        /// <summary>Columns of text inside the attachment body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<AppsDynamiteV1ApiCompatV1Field> Fields { get; set; }

        /// <summary>A string displayed at the bottom of the attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("footer")]
        public virtual string Footer { get; set; }

        /// <summary>Avatar URL displayed to the left of the footer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("footer_icon")]
        public virtual string FooterIcon { get; set; }

        /// <summary>URL of an image to display in an image chip.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image_url")]
        public virtual string ImageUrl { get; set; }

        /// <summary>List of fields to apply formatting to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mrkdwn_in")]
        public virtual System.Collections.Generic.IList<string> MrkdwnIn { get; set; }

        /// <summary>A string to show above the attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pretext")]
        public virtual string Pretext { get; set; }

        /// <summary>Main text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>URL of a thumbnail image to display to the right of the attachment body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumb_url")]
        public virtual string ThumbUrl { get; set; }

        /// <summary>Title string of this attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>URL that the title string should link to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title_link")]
        public virtual string TitleLink { get; set; }

        /// <summary>UNIX timestamp of the attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ts")]
        public virtual System.Nullable<int> Ts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A column of text in an attachment. Documentation: - https://api.slack.com/docs/message-attachments
    /// </summary>
    public class AppsDynamiteV1ApiCompatV1Field : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the field can be shown side-by-side with another field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("short")]
        public virtual System.Nullable<bool> Short__ { get; set; }

        /// <summary>The heading text, shown in bold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The text value of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Attachments that follow the message text.</summary>
    public class Attachment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Revised version of Gmail AddOn attachment approved by API design review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addOnData")]
        public virtual GoogleChatV1ContextualAddOnMarkup AddOnData { get; set; }

        /// <summary>
        /// The userId for the bot/app that created this data, to be used for attribution of attachments when the
        /// attachment was not created by the message sender.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual UserId AppId { get; set; }

        /// <summary>To identify an attachment within repeated in a message</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachmentId")]
        public virtual string AttachmentId { get; set; }

        /// <summary>Card AddOn attachment with the possibility for specifying editable widgets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardAddOnData")]
        public virtual AppsDynamiteSharedCard CardAddOnData { get; set; }

        /// <summary>Deprecated version of Gmail AddOn attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deprecatedAddOnData")]
        public virtual ContextualAddOnMarkup DeprecatedAddOnData { get; set; }

        /// <summary>Slack attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slackData")]
        public virtual AppsDynamiteV1ApiCompatV1Attachment SlackData { get; set; }

        /// <summary>The height of image url as fetched by fife. This field is asynchronously filled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slackDataImageUrlHeight")]
        public virtual System.Nullable<int> SlackDataImageUrlHeight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the settings for Cloud audit logging</summary>
    public class AuditLoggingSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates whether audit logging is on/off for admin activity read APIs i.e. Get/List DataSources, Get/List
        /// SearchApplications etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logAdminReadActions")]
        public virtual System.Nullable<bool> LogAdminReadActions { get; set; }

        /// <summary>
        /// Indicates whether audit logging is on/off for data access read APIs i.e. ListItems, GetItem etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logDataReadActions")]
        public virtual System.Nullable<bool> LogDataReadActions { get; set; }

        /// <summary>Indicates whether audit logging is on/off for data access write APIs i.e. IndexItem etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logDataWriteActions")]
        public virtual System.Nullable<bool> LogDataWriteActions { get; set; }

        /// <summary>
        /// The resource name of the GCP Project to store audit logs. Cloud audit logging will be enabled after
        /// project_name has been updated through CustomerService. Format: projects/{project_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A combination of an identifier for a Drive resource (e.g. file, folder, or drive) and any secrets needed to
    /// access it. The secrets should never be logged, and this proto annotates those secret fields to ensure that they
    /// are not. Clients are encouraged to use this proto rather than defining their own, to ensure that secrets are
    /// correctly annotated.
    /// </summary>
    public class AuthorizedItemId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Serialized ID of the Drive resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Resource key of the Drive item. This field should be unset if, depending on the context, the item does not
        /// have a resource key, or if none was specified. This must never be logged.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceKey")]
        public virtual string ResourceKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AutoComplete : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<AutoCompleteItem> Items { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AutoCompleteItem : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Container for Babel (Hangouts Classic) only message properties. The properties here will not be consumed by
    /// Dynamite clients. They are relevant only for Hangouts Classic.
    /// </summary>
    public class BabelMessageProps : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Babel clients locally generate this ID to dedupe against the async fanout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientGeneratedId")]
        public virtual System.Nullable<long> ClientGeneratedId { get; set; }

        /// <summary>Stores additional Babel-specific properties (such as event metadata).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentExtension")]
        public virtual ChatContentExtension ContentExtension { get; set; }

        /// <summary>Stores the delivery source of messages (such as phone number for SMS).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryMedium")]
        public virtual DeliveryMedium DeliveryMedium { get; set; }

        /// <summary>Primary identifier used by Hangouts Classic for its events (messages).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>Stores message segments (text content) and attachments (media URLs).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageContent")]
        public virtual ChatConserverMessageContent MessageContent { get; set; }

        /// <summary>Whether or not these message properties were backfilled by go/dinnertrain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wasUpdatedByBackfill")]
        public virtual System.Nullable<bool> WasUpdatedByBackfill { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Annotation metadata for Babel-only items that signals which type of placeholder message should be displayed in
    /// Babel clients.
    /// </summary>
    public class BabelPlaceholderMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("deleteMetadata")]
        public virtual DeleteMetadata DeleteMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("editMetadata")]
        public virtual EditMetadata EditMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("hangoutVideoMetadata")]
        public virtual HangoutVideoEventMetadata HangoutVideoMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Used to provide a search operator for boolean properties. This is optional. Search operators let users restrict
    /// the query to specific fields relevant to the type of item being searched.
    /// </summary>
    public class BooleanOperatorOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates the operator name required in the query in order to isolate the boolean property. For example, if
        /// operatorName is *closed* and the property's name is *isClosed*, then queries like
        /// *closed:&amp;lt;value&amp;gt;* show results only where the value of the property named *isClosed* matches
        /// *&amp;lt;value&amp;gt;*. By contrast, a search that uses the same *&amp;lt;value&amp;gt;* without an
        /// operator returns all items where *&amp;lt;value&amp;gt;* matches the value of any String properties or text
        /// within the content field for the item. The operator name can only contain lowercase letters (a-z). The
        /// maximum length is 32 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatorName")]
        public virtual string OperatorName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The options for boolean properties.</summary>
    public class BooleanPropertyOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If set, describes how the boolean should be used as a search operator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatorOptions")]
        public virtual BooleanOperatorOptions OperatorOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a complete border style that can be applied to widgets.</summary>
    public class BorderStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The corner radius for the border.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cornerRadius")]
        public virtual System.Nullable<int> CornerRadius { get; set; }

        /// <summary>The colors to use when the type is STROKE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("strokeColor")]
        public virtual string StrokeColor { get; set; }

        /// <summary>The border type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Bot-specific profile information.</summary>
    public class BotInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("appAllowlistStatus")]
        public virtual string AppAllowlistStatus { get; set; }

        /// <summary>Identifier of the application associated with the bot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual AppId AppId { get; set; }

        /// <summary>
        /// URL for the avatar picture of the User in dynamite. This field should be populated if the request is
        /// FetchBotCategories/ListBotCatalogEntries
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("botAvatarUrl")]
        public virtual string BotAvatarUrl { get; set; }

        /// <summary>
        /// Non-unique, user-defined display name of the Bot. This field should be populated if the request is
        /// FetchBotCategories/ListBotCatalogEntries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("botName")]
        public virtual string BotName { get; set; }

        /// <summary>Short description for the bot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Name of bot developer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerName")]
        public virtual string DeveloperName { get; set; }

        /// <summary>URL for the banner image in GSuite Market Place. The banner will be 220x140.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marketPlaceBannerUrl")]
        public virtual string MarketPlaceBannerUrl { get; set; }

        /// <summary>Indicates whether bot is enabled/disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>If the app supports a home screen.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportHomeScreen")]
        public virtual System.Nullable<bool> SupportHomeScreen { get; set; }

        /// <summary>
        /// Urls with additional information related to the bot. This field should always be set even if all the fields
        /// within it are empty, so that it is convenient for clients to work with this field in javascript.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportUrls")]
        public virtual SupportUrls SupportUrls { get; set; }

        /// <summary>
        /// The supported uses are limited according to the user that made the request. If the user does not have
        /// permission to use the bot, the list will be empty. This could occur for non whitelisted bots in the catalog.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedUses")]
        public virtual System.Collections.Generic.IList<string> SupportedUses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about a bot response, branched from shared/bot_response.proto without frontend User proto as we
    /// never store it.
    /// </summary>
    public class BotResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("botId")]
        public virtual UserId BotId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("requiredAction")]
        public virtual string RequiredAction { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("responseType")]
        public virtual string ResponseType { get; set; }

        /// <summary>URL for setting up bot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setupUrl")]
        public virtual string SetupUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Broadcast access information of a meeting space.</summary>
    public class BroadcastAccess : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The policy that controls the broadcast's viewer access.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessPolicy")]
        public virtual string AccessPolicy { get; set; }

        /// <summary>
        /// A URL that can be used to access the broadcast of the meeting. This field will be empty if broadcast is not
        /// enabled. It will be populated by the backend. Clients cannot modify the value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewUrl")]
        public virtual string ViewUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a broadcast session.</summary>
    public class BroadcastSessionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A unique server-generated ID for the broadcast session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("broadcastSessionId")]
        public virtual string BroadcastSessionId { get; set; }

        /// <summary>Output only. Current broadcast session's statistics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("broadcastStats")]
        public virtual BroadcastStats BroadcastStats { get; set; }

        /// <summary>Input only. Deprecated field, should not be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingestionId")]
        public virtual string IngestionId { get; set; }

        /// <summary>Broadcast session's state information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionStateInfo")]
        public virtual SessionStateInfo SessionStateInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Statistics of the broadcast session.</summary>
    public class BroadcastStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Estimated concurrent viewer count.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedViewerCount")]
        public virtual System.Nullable<long> EstimatedViewerCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Button : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("imageButton")]
        public virtual ImageButton ImageButton { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("textButton")]
        public virtual TextButton TextButton { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains information regarding an ongoing conference (aka call) for a meeting space.</summary>
    public class CallInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Abuse reporting configuration for the ongoing conference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("abuseReportingConfig")]
        public virtual AbuseReportingConfig AbuseReportingConfig { get; set; }

        /// <summary>
        /// Output only. Display name of the owner of artifacts generated in this conference. The expected use of this
        /// in clients is to present info like "This recording will be sent to John Doe's Drive". This field can be
        /// empty if preferred display name determination fails for any reason.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactOwner")]
        public virtual UserDisplayInfo ArtifactOwner { get; set; }

        /// <summary>Output only. Documents attached to an ongoing conference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachedDocuments")]
        public virtual System.Collections.Generic.IList<DocumentInfo> AttachedDocuments { get; set; }

        /// <summary>
        /// Output only. The set of reactions that clients are allowed to send and can expect to receive. Note that a
        /// device in the conference should have the MAY_SEND_REACTIONS privilege to be able to send reactions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableReactions")]
        public virtual System.Collections.Generic.IList<ReactionInfo> AvailableReactions { get; set; }

        /// <summary>Information about active broadcast session in the ongoing conference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("broadcastSessionInfo")]
        public virtual BroadcastSessionInfo BroadcastSessionInfo { get; set; }

        /// <summary>
        /// Output only. The calendar event ID of a Google Calendar event that the meeting space is associated with. If
        /// the meeting space is not associated with an event in Google Calendar, this field is empty. For recurring
        /// events, it refers to the recurring instance associated with the current call, as determined by the server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("calendarEventId")]
        public virtual string CalendarEventId { get; set; }

        /// <summary>Configuration for the chat for this conference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chatConfig")]
        public virtual ChatConfig ChatConfig { get; set; }

        /// <summary>
        /// The current co-activity session, or unset if there is none in progress. A co-activity session can be
        /// initiated by devices in JOINED state . Initiator of the co-activity is expected to populate this field to
        /// start the session. Once clients detect that the co-activity has finished, any JOINED device can clear this
        /// field to end the co-activity session. In the case of switching activities, the initiator of the new activity
        /// merely needs to override this with the new co-activity data, and all connected clients are expected to
        /// handle the transition gracefully.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coActivity")]
        public virtual CoActivity CoActivity { get; set; }

        /// <summary>The current collaboration session, or unset if no collaboration is in progress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collaboration")]
        public virtual Collaboration Collaboration { get; set; }

        /// <summary>CSE information for the ongoing conference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cseInfo")]
        public virtual CseInfo CseInfo { get; set; }

        /// <summary>
        /// Output only. The maximum number of devices that may be in the joined state simultaneously in this
        /// conference. This can be used by clients to guess whether it will be possible to join, but the only way to
        /// know is to try to join. It can also be used to inform users about the limit that is in effect. This limit is
        /// normally set when the conference is created and not changed during the lifetime of the conference. But there
        /// are some cases where it may change, so clients should be aware that the information may be stale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxJoinedDevices")]
        public virtual System.Nullable<int> MaxJoinedDevices { get; set; }

        /// <summary>
        /// Output only. Information about the media backend for the currently ongoing conference in the meeting space.
        /// The media backend information will only be filled in for clients that are supposed to present the
        /// information. The information should be displayed in a debug panel and is only intended for internal
        /// debugging purposes. If the string is empty nothing should be displayed about the media backend.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaBackendInfo")]
        public virtual string MediaBackendInfo { get; set; }

        /// <summary>
        /// Output only. The name or description of the organization or domain that the organizer belongs to. The
        /// expected use of this in clients is to present messages like "John Doe (outside of Google.com) is trying to
        /// join this call", where "Google.com" is the organization name. The field will be empty if the organization
        /// name could not be determined, possibly because of a backend error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organizationName")]
        public virtual string OrganizationName { get; set; }

        /// <summary>Paygate information to clients.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paygateInfo")]
        public virtual PaygateInfo PaygateInfo { get; set; }

        /// <summary>
        /// The current presenter in the call, or unset if there is no current presenter. Clients can set this to change
        /// the presenter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("presenter")]
        public virtual Presenter Presenter { get; set; }

        /// <summary>
        /// Deprecated, use RecordingSessionInfo instead. Info about recording for this conference. This will always be
        /// set in server responses, with a valid recording status. This is superseded by streaming_sessions field,
        /// which contains the same information about this recording as well as additional information about other
        /// application type at the same time. This will be deprecated and removed at some point.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordingInfo")]
        public virtual RecordingInfo RecordingInfo { get; set; }

        /// <summary>Information about active recording session in the ongoing conference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordingSessionInfo")]
        public virtual RecordingSessionInfo RecordingSessionInfo { get; set; }

        /// <summary>Settings of the ongoing conference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settings")]
        public virtual CallSettings Settings { get; set; }

        /// <summary>
        /// Output only. Info about streaming sessions (recording or broadcast) for this conference. This should contain
        /// all active sessions. Currently, it's guaranteed to have at most one recording and at most one broadcast (at
        /// most two sessions in total). For each application type (recording or broadcast), latest inactive session is
        /// included if there's no active one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamingSessions")]
        public virtual System.Collections.Generic.IList<StreamingSessionInfo> StreamingSessions { get; set; }

        /// <summary>Information about active transcription session in the ongoing conference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transcriptionSessionInfo")]
        public virtual TranscriptionSessionInfo TranscriptionSessionInfo { get; set; }

        /// <summary>
        /// The number of devices viewing the conference - MeetingDevices that are in VIEWER role and JOINED state in
        /// the conference.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewerCount")]
        public virtual System.Nullable<int> ViewerCount { get; set; }

        /// <summary>Information about active YouTube broadcast sessions in the ongoing conference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("youTubeBroadcastSessionInfos")]
        public virtual System.Collections.Generic.IList<YouTubeBroadcastSessionInfo> YouTubeBroadcastSessionInfos { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Effective settings of the ongoing conference.</summary>
    public class CallSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates whether the access lock is currently on or off.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLock")]
        public virtual System.Nullable<bool> AccessLock { get; set; }

        /// <summary>Indicates whether the attendance report is currently enabled or disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attendanceReportEnabled")]
        public virtual System.Nullable<bool> AttendanceReportEnabled { get; set; }

        /// <summary>Indicates whether the audio lock is currently on or off.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioLock")]
        public virtual System.Nullable<bool> AudioLock { get; set; }

        /// <summary>Indicates whether the chat lock is currently on or off.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chatLock")]
        public virtual System.Nullable<bool> ChatLock { get; set; }

        /// <summary>Whether Client-side Encryption is enabled for this conference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cseEnabled")]
        public virtual System.Nullable<bool> CseEnabled { get; set; }

        /// <summary>Indicates whether the current call is moderated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moderationEnabled")]
        public virtual System.Nullable<bool> ModerationEnabled { get; set; }

        /// <summary>Indicates whether the present lock is currently on or off.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("presentLock")]
        public virtual System.Nullable<bool> PresentLock { get; set; }

        /// <summary>
        /// Indicates whether project Dino is currently on or off. WARNING: This is currently an experimental field. It
        /// should not be used without getting an explicit review and approval from the Meet team.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectDinoEnabled")]
        public virtual System.Nullable<bool> ProjectDinoEnabled { get; set; }

        /// <summary>Indicates whether the reactions lock is currently on or off.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reactionsLock")]
        public virtual System.Nullable<bool> ReactionsLock { get; set; }

        /// <summary>Indicates whether the video lock is currently on or off.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoLock")]
        public virtual System.Nullable<bool> VideoLock { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a principal which possesses a particular secret string whose cryptographic hash is specified here.
    /// CapTokens ("Capability Tokens") are used in ACLProto. It's expected that ACLs with CapTokenHolders will strongly
    /// enforce them by Keystore-wrapping crypto keys for the corresponding CapTokens.
    /// </summary>
    public class CapTokenHolderProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The hash of the corresponding capability token. The value is defined to be identical to the one in
        /// acl.proto's CapTokenMetadata: 10-byte prefix of HMAC-SHA1 of the token. The HMAC key is the following fixed
        /// (non-secret) 512-bit value: 79b1c8f4 82baf523 b8a9ab4a e960f438 c45be041 11f1f222 e8a3f64d aeb05e3d c3576acc
        /// ec649194 aede422c 4e48e0d1 ff21234a a6ed6b49 a7fa592e efd7bba3
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenHmacSha1Prefix")]
        public virtual string TokenHmacSha1Prefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Card : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("cardActions")]
        public virtual System.Collections.Generic.IList<CardAction> CardActions { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("displayStyle")]
        public virtual string DisplayStyle { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("fixedFooter")]
        public virtual FixedFooter FixedFooter { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual CardHeader Header { get; set; }

        /// <summary>Name of the card used in CardNavigation.pop_to_card_name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// When displaying contextual content, the peek card header acts as a placeholder so that the user can navigate
        /// forward between the homepage cards and the contextual cards.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peekCardHeader")]
        public virtual CardHeader PeekCardHeader { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sections")]
        public virtual System.Collections.Generic.IList<Section> Sections { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// When an AddOn Card is shown in detailed view, a card action is the action associated with the card. For an
    /// invoice card, a typical action would be: delete invoice, email invoice or open the invoice in browser.
    /// </summary>
    public class CardAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The label used to be displayed in the action menu item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionLabel")]
        public virtual string ActionLabel { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual OnClick OnClick { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CardCapabilityMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>NEXT TAG : 2</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiredCapabilities")]
        public virtual System.Collections.Generic.IList<string> RequiredCapabilities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CardHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The alternative text of this image which will be used for accessibility.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageAltText")]
        public virtual string ImageAltText { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("imageStyle")]
        public virtual string ImageStyle { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
        public virtual string Subtitle { get; set; }

        /// <summary>
        /// The title must be specified. The header has a fixed height: if both a title and subtitle is specified, each
        /// will take up 1 line. If only the title is specified, it will take up both lines. The header is rendered in
        /// collapsed and detailed view.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration of the in meeting chat.</summary>
    public class ChatConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Type of chat this Conference is currently using.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chatType")]
        public virtual string ChatType { get; set; }

        /// <summary>The configuration of Google Chat when selected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleChatConfig")]
        public virtual GoogleChatConfig GoogleChatConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata used as inputs to the localization that is performed on Dynamite-originated messages that are
    /// incompatible with Hangouts clients. See go/localization-of-system-messages for more details.
    /// </summary>
    public class ChatConserverDynamitePlaceholderMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("attachmentMetadata")]
        public virtual ChatConserverDynamitePlaceholderMetadataAttachmentMetadata AttachmentMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("botMessageMetadata")]
        public virtual ChatConserverDynamitePlaceholderMetadataBotMessageMetadata BotMessageMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("calendarEventMetadata")]
        public virtual ChatConserverDynamitePlaceholderMetadataCalendarEventMetadata CalendarEventMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("deleteMetadata")]
        public virtual ChatConserverDynamitePlaceholderMetadataDeleteMetadata DeleteMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("editMetadata")]
        public virtual ChatConserverDynamitePlaceholderMetadataEditMetadata EditMetadata { get; set; }

        /// <summary>The space URL embedded in the localized string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spaceUrl")]
        public virtual string SpaceUrl { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tasksMetadata")]
        public virtual ChatConserverDynamitePlaceholderMetadataTasksMetadata TasksMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("videoCallMetadata")]
        public virtual ChatConserverDynamitePlaceholderMetadataVideoCallMetadata VideoCallMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An attachment uploaded in Dynamite and its filename.</summary>
    public class ChatConserverDynamitePlaceholderMetadataAttachmentMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("filename")]
        public virtual string Filename { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A bot sent a message in Dynamite.</summary>
    public class ChatConserverDynamitePlaceholderMetadataBotMessageMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Calendar event message in Dynamite.</summary>
    public class ChatConserverDynamitePlaceholderMetadataCalendarEventMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message was deleted in Dynamite.</summary>
    public class ChatConserverDynamitePlaceholderMetadataDeleteMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An edit was made in Dynamite.</summary>
    public class ChatConserverDynamitePlaceholderMetadataEditMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Tasks message in Dynamite.</summary>
    public class ChatConserverDynamitePlaceholderMetadataTasksMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Meet initiated in Dynamite and its URL.</summary>
    public class ChatConserverDynamitePlaceholderMetadataVideoCallMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("meetingUrl")]
        public virtual string MeetingUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The content of a chat message, which includes 0 or more segments along with 0 or more embeds, which represent
    /// various attachment types (like photos).
    /// </summary>
    public class ChatConserverMessageContent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Items attached to this message, such as photos. This should *NOT* be set by clients. It will be
        /// automatically set from media uploaded along with this request and using the information provided in
        /// existing_media.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachment")]
        public virtual System.Collections.Generic.IList<SocialCommonAttachmentAttachment> Attachment { get; set; }

        /// <summary>
        /// The text part of the message content. Segments are concatenated together to yield the full message. A
        /// message can have zero or more segments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual System.Collections.Generic.IList<Segment> Segment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>NEXT ID: 12</summary>
    public class ChatContentExtension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Annotations to decorate this event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotation")]
        public virtual System.Collections.Generic.IList<EventAnnotation> Annotation { get; set; }

        /// <summary>
        /// This metadata informs how the placeholder string will be localized dynamically in Hangouts. See
        /// go/localization-of-system-messages. This is only used as part of REGULAR_CHAT_MESSAGE events.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamitePlaceholderMetadata")]
        public virtual ChatConserverDynamitePlaceholderMetadata DynamitePlaceholderMetadata { get; set; }

        /// <summary>
        /// Is this event OnTR or OffTR? Since some events can be ON_THE_RECORD and have an expiration_timestamp (for
        /// example enterprise retention users) we need to store the otr status.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventOtrStatus")]
        public virtual string EventOtrStatus { get; set; }

        /// <summary>Group-link sharing toggle event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupLinkSharingModificationEvent")]
        public virtual GroupLinkSharingModificationEvent GroupLinkSharingModificationEvent { get; set; }

        /// <summary>Audio/video Hangout event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hangoutEvent")]
        public virtual HangoutEvent HangoutEvent { get; set; }

        /// <summary>
        /// Invite accepted events. Note: this is only used ephemerally to sync to Gmail. No actual cent is stored in
        /// Papyrus.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inviteAcceptedEvent")]
        public virtual InviteAcceptedEvent InviteAcceptedEvent { get; set; }

        /// <summary>Join/leave events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipChangeEvent")]
        public virtual MembershipChangeEvent MembershipChangeEvent { get; set; }

        /// <summary>Metadata for off-the-record message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otrChatMessageEvent")]
        public virtual OtrChatMessageEvent OtrChatMessageEvent { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("otrModificationEvent")]
        public virtual OtrModificationEvent OtrModificationEvent { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("renameEvent")]
        public virtual RenameEvent RenameEvent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the invitees or other users associated with a Babel Chat (see http://goto/babel). Corresponds to
    /// GroupType CHAT in //social/graph/storage/proto/data.proto.
    /// </summary>
    public class ChatProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Chat IDs consist of alphanumeric characters and colons. Currently required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chatId")]
        public virtual string ChatId { get; set; }

        /// <summary>
        /// The type of Chat members to consider, e.g. "all members" vs. "invitee" These are defined by
        /// legacy_relation_id values in social.graph.storage.EdgeTypeEnum.EdgeType enum options in
        /// social/graph/storage/proto/id.proto. See chat.pb (defined in
        /// production/config/cdd/socialgraph/mixer_config/prod/node_type_config) for all valid edge types associated
        /// with chat. Currently required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberType")]
        public virtual System.Nullable<int> MemberType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CheckAccessResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Returns true if principal has access. Returns false otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasAccess")]
        public virtual System.Nullable<bool> HasAccess { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a Google+ Circle. Currently (12/2011), a Circle is identical to the ContactGroup with matching
    /// parameters, but Circle must only be used for true Circles and not other Focus groups, and should be preferred
    /// over ContactGroup where applicable. Soon it may become more efficient to check membership in a Circle than in a
    /// ContactGroup (see http://go/superglue). Support for this principal type is currently (12/2011) incomplete --
    /// e.g., Keystore does not support it yet (see b/5703421).
    /// </summary>
    public class CircleProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Circle ID is unique only relative to the owner's Gaia ID. Currently required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("circleId")]
        public virtual System.Nullable<long> CircleId { get; set; }

        /// <summary>The owner of the circle. Currently required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerGaiaId")]
        public virtual System.Nullable<long> OwnerGaiaId { get; set; }

        /// <summary>
        /// If present, then tests for membership in this circle must use data known to be at least as fresh as the
        /// given (FBS-assigned) timestamp. See http://go/fbs-consistent-read-after-important-write Before using this,
        /// be sure that any service checking authorization against this circle supports checking consistency
        /// timestamps. For example, as of 12/2011, Keystore only supports this for the Moonshine configuration, and in
        /// others authorization checks will fail if the timestamp is present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiredConsistencyTimestampUsec")]
        public virtual System.Nullable<long> RequiredConsistencyTimestampUsec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Principal associated with a Cloud Principal representing third party user.</summary>
    public class CloudPrincipalProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Format: "{identity-pool}:{subject}#" Details: go/cloud-principal-identifiers</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about a co-activity session.</summary>
    public class CoActivity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The title of the activity in this co-activity session. For example, this might be the title of the video
        /// being co-watched, or the name of the round of a game being co-played.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityTitle")]
        public virtual string ActivityTitle { get; set; }

        /// <summary>Identifies the app handling this co-activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coActivityApp")]
        public virtual string CoActivityApp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a collaboration session.</summary>
    public class Collaboration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The attachment being collaborated on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachmentId")]
        public virtual string AttachmentId { get; set; }

        /// <summary>Display info of the user who initiated the collaboration session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initiator")]
        public virtual UserDisplayInfo Initiator { get; set; }

        /// <summary>The uri of the artifact being collaborated on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a color in the RGBA color space. This representation is designed for simplicity of conversion to/from
    /// color representations in various languages over compactness. For example, the fields of this representation can
    /// be trivially provided to the constructor of `java.awt.Color` in Java; it can also be trivially provided to
    /// UIColor's `+colorWithRed:green:blue:alpha` method in iOS; and, with just a little work, it can be easily
    /// formatted into a CSS `rgba()` string in JavaScript. This reference page doesn't carry information about the
    /// absolute color space that should be used to interpret the RGB value (e.g. sRGB, Adobe RGB, DCI-P3, BT.2020,
    /// etc.). By default, applications should assume the sRGB color space. When color equality needs to be decided,
    /// implementations, unless documented otherwise, treat two colors as equal if all their red, green, blue, and alpha
    /// values each differ by at most 1e-5. Example (Java): import com.google.type.Color; // ... public static
    /// java.awt.Color fromProto(Color protocolor) { float alpha = protocolor.hasAlpha() ?
    /// protocolor.getAlpha().getValue() : 1.0; return new java.awt.Color( protocolor.getRed(), protocolor.getGreen(),
    /// protocolor.getBlue(), alpha); } public static Color toProto(java.awt.Color color) { float red = (float)
    /// color.getRed(); float green = (float) color.getGreen(); float blue = (float) color.getBlue(); float denominator
    /// = 255.0; Color.Builder resultBuilder = Color .newBuilder() .setRed(red / denominator) .setGreen(green /
    /// denominator) .setBlue(blue / denominator); int alpha = color.getAlpha(); if (alpha != 255) { result.setAlpha(
    /// FloatValue .newBuilder() .setValue(((float) alpha) / denominator) .build()); } return resultBuilder.build(); }
    /// // ... Example (iOS / Obj-C): // ... static UIColor* fromProto(Color* protocolor) { float red = [protocolor
    /// red]; float green = [protocolor green]; float blue = [protocolor blue]; FloatValue* alpha_wrapper = [protocolor
    /// alpha]; float alpha = 1.0; if (alpha_wrapper != nil) { alpha = [alpha_wrapper value]; } return [UIColor
    /// colorWithRed:red green:green blue:blue alpha:alpha]; } static Color* toProto(UIColor* color) { CGFloat red,
    /// green, blue, alpha; if (![color getRed:&amp;amp;red green:&amp;amp;green blue:&amp;amp;blue
    /// alpha:&amp;amp;alpha]) { return nil; } Color* result = [[Color alloc] init]; [result setRed:red]; [result
    /// setGreen:green]; [result setBlue:blue]; if (alpha &amp;lt;= 0.9999) { [result
    /// setAlpha:floatWrapperWithValue(alpha)]; } [result autorelease]; return result; } // ... Example (JavaScript): //
    /// ... var protoToCssColor = function(rgb_color) { var redFrac = rgb_color.red || 0.0; var greenFrac =
    /// rgb_color.green || 0.0; var blueFrac = rgb_color.blue || 0.0; var red = Math.floor(redFrac * 255); var green =
    /// Math.floor(greenFrac * 255); var blue = Math.floor(blueFrac * 255); if (!('alpha' in rgb_color)) { return
    /// rgbToCssColor(red, green, blue); } var alphaFrac = rgb_color.alpha.value || 0.0; var rgbParams = [red, green,
    /// blue].join(','); return ['rgba(', rgbParams, ',', alphaFrac, ')'].join(''); }; var rgbToCssColor = function(red,
    /// green, blue) { var rgbNumber = new Number((red &amp;lt;&amp;lt; 16) | (green &amp;lt;&amp;lt; 8) | blue); var
    /// hexString = rgbNumber.toString(16); var missingZeros = 6 - hexString.length; var resultBuilder = ['#']; for (var
    /// i = 0; i &amp;lt; missingZeros; i++) { resultBuilder.push('0'); } resultBuilder.push(hexString); return
    /// resultBuilder.join(''); }; // ...
    /// </summary>
    public class Color : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fraction of this color that should be applied to the pixel. That is, the final pixel color is defined by
        /// the equation: `pixel color = alpha * (this color) + (1.0 - alpha) * (background color)` This means that a
        /// value of 1.0 corresponds to a solid color, whereas a value of 0.0 corresponds to a completely transparent
        /// color. This uses a wrapper message rather than a simple float scalar so that it is possible to distinguish
        /// between a default value and the value being unset. If omitted, this color object is rendered as a solid
        /// color (as if the alpha value had been explicitly given a value of 1.0).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alpha")]
        public virtual System.Nullable<float> Alpha { get; set; }

        /// <summary>The amount of blue in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blue")]
        public virtual System.Nullable<float> Blue { get; set; }

        /// <summary>The amount of green in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("green")]
        public virtual System.Nullable<float> Green { get; set; }

        /// <summary>The amount of red in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("red")]
        public virtual System.Nullable<float> Red { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An individual instance (or "tag") of a label configured as a communal type that's associated with a message.
    /// </summary>
    public class CommunalLabelTag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Gaia ID of the user who added the tag, if any. Not present for any tags automatically created by server-side
        /// processing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creatorUserId")]
        public virtual System.Nullable<long> CreatorUserId { get; set; }

        /// <summary>
        /// A string ID representing the label. Possible ID values are documented at go/chat-labels-howto:ids. Example:
        /// "^*t_p" for "Pinned".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelId")]
        public virtual string LabelId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CompositeFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The logic operator of the sub filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logicOperator")]
        public virtual string LogicOperator { get; set; }

        /// <summary>Sub filters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subFilters")]
        public virtual System.Collections.Generic.IList<Filter> SubFilters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotation metadata app unfurl consent.</summary>
    public class ConsentedAppUnfurlMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Client specified AppId, which will not be sanitized and is untrusted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientSpecifiedAppId")]
        public virtual UserId ClientSpecifiedAppId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A group of contacts for a given user, as described in http://cs/p#google3/focus/backend/proto/backend.proto
    /// Historically (and in still-existing ACLs), this was used to represent Google+ circles as well as contact groups,
    /// but this use is now deprecated. New code should use the CIRCLE principal type to represent Google+ circles.
    /// </summary>
    public class ContactGroupProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Group ID is unique only relative to the owner's Gaia ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupId")]
        public virtual System.Nullable<long> GroupId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ownerGaiaId")]
        public virtual System.Nullable<long> OwnerGaiaId { get; set; }

        /// <summary>
        /// If present, then tests for membership in this ContactGroup must use data known to be at least as fresh as
        /// the given (FBS-assigned) timestamp. See http://go/fbs-consistent-read-after-important-write Before using
        /// this, be sure that any service checking authorization against this group supports checking consistency
        /// timestamps. For example, as of 12/2011, Keystore only supports this for the Moonshine configuration, and in
        /// others authorization checks will fail if the timestamp is present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiredConsistencyTimestampUsec")]
        public virtual System.Nullable<long> RequiredConsistencyTimestampUsec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ContentReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time at which the report is generated. Always populated when it is in a response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportCreateTimestamp")]
        public virtual object ReportCreateTimestamp { get; set; }

        /// <summary>Additional user-provided justification on the report. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportJustification")]
        public virtual ContentReportJustification ReportJustification { get; set; }

        /// <summary>Type of the report. Always populated when it is in a response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportType")]
        public virtual AppsDynamiteSharedContentReportType ReportType { get; set; }

        /// <summary>User ID of the reporter. Always populated when it is in a response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reporterUserId")]
        public virtual UserId ReporterUserId { get; set; }

        /// <summary>
        /// Create timestamp of the revisions of the message when it's reported. Always populated when it is in a
        /// response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionCreateTimestamp")]
        public virtual object RevisionCreateTimestamp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ContentReportJustification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. User-generated free-text justification for the content report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userJustification")]
        public virtual string UserJustification { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Summarized info of content reports. Usually less expensive to fetch than to fetch all detailed reports. Set only
    /// when the request asks for it.
    /// </summary>
    public class ContentReportSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Total number of reports attached to this (revision of) message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numberReports")]
        public virtual System.Nullable<int> NumberReports { get; set; }

        /// <summary>
        /// Totoal number of reports attached to all revisions of this message (i.e. since creation). Set only when the
        /// request asks for it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numberReportsAllRevisions")]
        public virtual System.Nullable<int> NumberReportsAllRevisions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A named attribute associated with an item which can be used for influencing the ranking of the item based on the
    /// context in the request.
    /// </summary>
    public class ContextAttribute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the attribute. It should not be empty. The maximum length is 32 characters. The name must start
        /// with a letter and can only contain letters (A-Z, a-z) or numbers (0-9). The name will be normalized
        /// (lower-cased) before being matched.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Text values of the attribute. The maximum number of elements is 10. The maximum length of an element in the
        /// array is 32 characters. The value will be normalized (lower-cased) before being matched.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The markup for developers to specify the contents of a contextual AddOn. A contextual AddOn is triggered in
    /// context of an email. For that email, there can be N items that are associated with the email (e.g. contacts,
    /// sales lead, meeting information). Each item is represented as a "card". A card has two views, collapsed and
    /// detailed. If there are more than 1 card, the cards are show as a list of collapsed views. The end user can
    /// expand into the detailed view for each of those cards. In the detailed view, developers have the freedom to use
    /// a variety of "widgets" to construct it. The model here is to restrict (make consistent for end users) the
    /// navigation of the N cards but providing developers the freedom to build the detailed view that can best
    /// represent their use case/content. Go http://go/aoig-widgets1 to see the mocks. Post v1, we plan to support new
    /// AddOn use cases that will require different and separate 'templates'. For example, a compose triggered AddOn
    /// which will support a new set of use cases with different user interaction patterns. As a result, we will likely
    /// need a very different template than this one.
    /// </summary>
    public class ContextualAddOnMarkup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A card must contain a header and at least 1 section.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cards")]
        public virtual System.Collections.Generic.IList<Card> Cards { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolbar")]
        public virtual Toolbar Toolbar { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information needed for Client-side Encryption.</summary>
    public class CseInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// CSE domain name claimed by the meeting owner's company. This field is expected to be used for display
        /// purposes only, i.e., "Extra encryption added by $cse_domain". It can differ from the `cse_domain` as defined
        /// elsewhere on the User, in the case of cross-domain meetings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cseDomain")]
        public virtual string CseDomain { get; set; }

        /// <summary>The wrapped CSE key used by this conference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wrappedKey")]
        public virtual string WrappedKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CustomEmojiMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("customEmoji")]
        public virtual AppsDynamiteSharedCustomEmoji CustomEmoji { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a GSuite customer ID. Obfuscated with CustomerIdObfuscator.</summary>
    public class CustomerId : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
        public virtual string CustomerIdValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Aggregation of items by status code as of the specified date.</summary>
    public class CustomerIndexStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The date for which statistics were calculated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>Number of items aggregrated by status code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemCountByStatus")]
        public virtual System.Collections.Generic.IList<ItemCountByStatus> ItemCountByStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CustomerQueryStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The date for which query stats were calculated. Stats calculated on the next day close to midnight are
        /// returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("queryCountByStatus")]
        public virtual System.Collections.Generic.IList<QueryCountByStatus> QueryCountByStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Search application stats for a customer for the given date.</summary>
    public class CustomerSearchApplicationStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The count of search applications for the date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>The date for which search application stats were calculated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CustomerSessionStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The date for which session stats were calculated. Stats are calculated on the following day, close to
        /// midnight PST, and then returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>The count of search sessions on the day</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchSessionsCount")]
        public virtual System.Nullable<long> SearchSessionsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents settings at a customer level.</summary>
    public class CustomerSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Audit Logging settings for the customer. If update_mask is empty then this field will be updated based on
        /// UpdateCustomerSettings request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLoggingSettings")]
        public virtual AuditLoggingSettings AuditLoggingSettings { get; set; }

        /// <summary>
        /// VPC SC settings for the customer. If update_mask is empty then this field will be updated based on
        /// UpdateCustomerSettings request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcSettings")]
        public virtual VPCSettings VpcSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CustomerUserStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The date for which session stats were calculated. Stats calculated on the next day close to midnight are
        /// returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>The count of unique active users in the past one day</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oneDayActiveUsersCount")]
        public virtual System.Nullable<long> OneDayActiveUsersCount { get; set; }

        /// <summary>The count of unique active users in the past seven days</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sevenDaysActiveUsersCount")]
        public virtual System.Nullable<long> SevenDaysActiveUsersCount { get; set; }

        /// <summary>The count of unique active users in the past thirty days</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thirtyDaysActiveUsersCount")]
        public virtual System.Nullable<long> ThirtyDaysActiveUsersCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Annotation metadata for Data Loss Prevention that pertains to DLP violation on message send or edit events. It
    /// is used for client -&amp;gt; BE communication and other downstream process in BE (e.g. storage and audit
    /// logging), and it should never be returned to the client.
    /// </summary>
    public class DataLossPreventionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The DLP scan summary that should only be set after the message is scanned in the Chat backend.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dlpScanSummary")]
        public virtual DlpScanSummary DlpScanSummary { get; set; }

        /// <summary>Flag set by client on message resend to bypass WARN violation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnAcknowledged")]
        public virtual System.Nullable<bool> WarnAcknowledged { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Datasource is a logical namespace for items to be indexed. All items must belong to a datasource. This is the
    /// prerequisite before items can be indexed into Cloud Search.
    /// </summary>
    public class DataSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If true, sets the datasource to read-only mode. In read-only mode, the Indexing API rejects any requests to
        /// index or delete items in this source. Enabling read-only mode does not stop the processing of previously
        /// accepted data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableModifications")]
        public virtual System.Nullable<bool> DisableModifications { get; set; }

        /// <summary>Disable serving any search or assist results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableServing")]
        public virtual System.Nullable<bool> DisableServing { get; set; }

        /// <summary>Required. Display name of the datasource The maximum length is 300 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>List of service accounts that have indexing access.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexingServiceAccounts")]
        public virtual System.Collections.Generic.IList<string> IndexingServiceAccounts { get; set; }

        /// <summary>
        /// This field restricts visibility to items at the datasource level. Items within the datasource are restricted
        /// to the union of users and groups included in this field. Note that, this does not ensure access to a
        /// specific item, as users need to have ACL permissions on the contained items. This ensures a high level
        /// access on the entire datasource, and that the individual items are not shared outside this visibility.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsVisibility")]
        public virtual System.Collections.Generic.IList<GSuitePrincipal> ItemsVisibility { get; set; }

        /// <summary>
        /// The name of the datasource resource. Format: datasources/{source_id}. The name is ignored when creating a
        /// datasource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>IDs of the Long Running Operations (LROs) currently running for this schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationIds")]
        public virtual System.Collections.Generic.IList<string> OperationIds { get; set; }

        /// <summary>Can a user request to get thumbnail URI for Items indexed in this data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnThumbnailUrls")]
        public virtual System.Nullable<bool> ReturnThumbnailUrls { get; set; }

        /// <summary>
        /// A short name or alias for the source. This value will be used to match the 'source' operator. For example,
        /// if the short name is *&amp;lt;value&amp;gt;* then queries like *source:&amp;lt;value&amp;gt;* will only
        /// return results for this source. The value must be unique across all datasources. The value must only contain
        /// alphanumeric characters (a-zA-Z0-9). The value cannot start with 'google' and cannot be one of the
        /// following: mail, gmail, docs, drive, groups, sites, calendar, hangouts, gplus, keep, people, teams. Its
        /// maximum length is 32 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortName")]
        public virtual string ShortName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Aggregation of items by status code as of the specified date.</summary>
    public class DataSourceIndexStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The date for which index stats were calculated. If the date of request is not the current date then stats
        /// calculated on the next day are returned. Stats are calculated close to mid night in this case. If date of
        /// request is current date, then real time stats are returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>Number of items aggregrated by status code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemCountByStatus")]
        public virtual System.Collections.Generic.IList<ItemCountByStatus> ItemCountByStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Restriction on Datasource.</summary>
    public class DataSourceRestriction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Filter options restricting the results. If multiple filters are present, they are grouped by object type
        /// before joining. Filters with the same object type are joined conjunctively, then the resulting expressions
        /// are joined disjunctively. The maximum number of elements is 20. NOTE: Suggest API supports only few filters
        /// at the moment: "objecttype", "type" and "mimetype". For now, schema specific filters cannot be used to
        /// filter suggestions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterOptions")]
        public virtual System.Collections.Generic.IList<FilterOptions> FilterOptions { get; set; }

        /// <summary>The source of restriction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual Source Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a whole calendar date, for example a date of birth. The time of day and time zone are either
    /// specified elsewhere or are not significant. The date is relative to the [Proleptic Gregorian
    /// Calendar](https://en.wikipedia.org/wiki/Proleptic_Gregorian_calendar). The date must be a valid calendar date
    /// between the year 1 and 9999.
    /// </summary>
    public class Date : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>Month of date. Must be from 1 to 12.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual System.Nullable<int> Month { get; set; }

        /// <summary>Year of date. Must be from 1 to 9999.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("year")]
        public virtual System.Nullable<int> Year { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Optional. Provides a search operator for date properties. Search operators let users restrict the query to
    /// specific fields relevant to the type of item being searched.
    /// </summary>
    public class DateOperatorOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates the operator name required in the query in order to isolate the date property using the
        /// greater-than operator. For example, if greaterThanOperatorName is *closedafter* and the property's name is
        /// *closeDate*, then queries like *closedafter:&amp;lt;value&amp;gt;* show results only where the value of the
        /// property named *closeDate* is later than *&amp;lt;value&amp;gt;*. The operator name can only contain
        /// lowercase letters (a-z). The maximum length is 32 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("greaterThanOperatorName")]
        public virtual string GreaterThanOperatorName { get; set; }

        /// <summary>
        /// Indicates the operator name required in the query in order to isolate the date property using the less-than
        /// operator. For example, if lessThanOperatorName is *closedbefore* and the property's name is *closeDate*,
        /// then queries like *closedbefore:&amp;lt;value&amp;gt;* show results only where the value of the property
        /// named *closeDate* is earlier than *&amp;lt;value&amp;gt;*. The operator name can only contain lowercase
        /// letters (a-z). The maximum length is 32 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lessThanOperatorName")]
        public virtual string LessThanOperatorName { get; set; }

        /// <summary>
        /// Indicates the actual string required in the query in order to isolate the date property. For example,
        /// suppose an issue tracking schema object has a property named *closeDate* that specifies an operator with an
        /// operatorName of *closedon*. For searches on that data, queries like *closedon:&amp;lt;value&amp;gt;* show
        /// results only where the value of the *closeDate* property matches *&amp;lt;value&amp;gt;*. By contrast, a
        /// search that uses the same *&amp;lt;value&amp;gt;* without an operator returns all items where
        /// *&amp;lt;value&amp;gt;* matches the value of any String properties or text within the content field for the
        /// indexed datasource. The operator name can only contain lowercase letters (a-z). The maximum length is 32
        /// characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatorName")]
        public virtual string OperatorName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The options for date properties.</summary>
    public class DatePropertyOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If set, describes how the date should be used as a search operator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatorOptions")]
        public virtual DateOperatorOptions OperatorOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DateTimePicker : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The label for the field, which is displayed to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>
        /// The name of the text field which is used in FormInput, and uniquely identifies this input.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Triggered when the user clicks on the Save, or Clear button from the date / time picker dialog. Will only be
        /// triggered if the value changed as a result of the Save / Clear operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onChange")]
        public virtual FormAction OnChange { get; set; }

        /// <summary>
        /// The number representing the time-zone offset from UTC, in minutes. If set, the value_ms_epoch will be
        /// displayed in the specified time zone. If not set, it will use the user's timezone setting in client side.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timezoneOffsetDate")]
        public virtual System.Nullable<int> TimezoneOffsetDate { get; set; }

        /// <summary>The type of the DateTimePicker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// The value to display which can be the default value before user input or previous user input. It is
        /// represented in milliseconds (Epoch time). - For DATE_AND_TIME type, the full epoch value is used. - For
        /// DATE_ONLY type, only date of the epoch time is used. - For TIME_ONLY type, only time of the epoch time is
        /// used. For example, you can set epoch time to 3 * 60 * 60 * 1000 to represent 3am.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueMsEpoch")]
        public virtual System.Nullable<long> ValueMsEpoch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of date values.</summary>
    public class DateValues : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<Date> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Shared request debug options for all cloudsearch RPC methods.</summary>
    public class DebugOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If you are asked by Google to help with debugging, set this field. Otherwise, ignore this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableDebugging")]
        public virtual System.Nullable<bool> EnableDebugging { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Deep-linking data is used to construct a deep-link URI for an activity or frame's embed, such that on click, the
    /// user is taken to the right place in a mobile app. If the app is not installed, the user is taken to the app
    /// store. If not on mobile, an analogous web uri is used.
    /// </summary>
    public class DeepLinkData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Application ID (or project ID) from Google API Console.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual System.Nullable<long> AppId { get; set; }

        /// <summary>
        /// The data for a Google API Console client is entered by a developer during client registration and is stored
        /// in PackagingService.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("client")]
        public virtual System.Collections.Generic.IList<PackagingServiceClient> Client { get; set; }

        /// <summary>
        /// The ID for non-URL content. Embeds may either have no analogous web presence or prefer a native mobile
        /// experience if supported. In the case of no web presence, instead of setting the "url" field of an embed,
        /// such developers will set this field and other content fields, e.g. thumbnail, title, description. If set,
        /// this field is used to construct the deep-link URI. Note that the native experience is preferred over the web
        /// link and the web link is used as a fallback.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deepLinkId")]
        public virtual string DeepLinkId { get; set; }

        /// <summary>Analogous web presence. Used as desktop fallback or when no native link data is present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A message delete in Dynamite inserts a Babel-only item containing this field. This is only inserted for messages
    /// before the source-of-truth flip. See go/hsc-message-deletions for more details.
    /// </summary>
    public class DeleteMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DeleteQueueItemsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of connector making this call. Format: datasources/{source_id}/connectors/{ID}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectorName")]
        public virtual string ConnectorName { get; set; }

        /// <summary>Common debug options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugOptions")]
        public virtual DebugOptions DebugOptions { get; set; }

        /// <summary>The name of a queue to delete items from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queue")]
        public virtual string Queue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DeliveryMedium : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Describes the medium the cent was sent/received. For example, if I receive an SMS via GV, the medium_type
        /// will be GV.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediumType")]
        public virtual string MediumType { get; set; }

        /// <summary>
        /// In the case of multiple GV/native numbers, this defines the exact number to send from. It is used to
        /// differentiate mediums that have the same type, but different addresses (e.g. two android phones).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfPhone")]
        public virtual VoicePhoneNumber SelfPhone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A reference to a top-level property within the object that should be displayed in search results. The values of
    /// the chosen properties is displayed in the search results along with the display label for that property if one
    /// is specified. If a display label is not specified, only the values is shown.
    /// </summary>
    public class DisplayedProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the top-level property as defined in a property definition for the object. If the name is not a
        /// defined property in the schema, an error is given when attempting to update the schema.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyName")]
        public virtual string PropertyName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Divider : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A summary of a DLP scan event. This is a summary and should contain the minimum amount of data required to
    /// identify and process DLP scans. It is written to Starcast and encoded &amp;amp; returned to the client on
    /// attachment upload.
    /// </summary>
    public class DlpScanSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The scan ID of the corresponding {@link DlpViolationScanRecord} in the {@link EphemeralDlpScans} Spanner
        /// table. This can be used to fetch additional details about the scan, e.g. for audit logging.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scanId")]
        public virtual string ScanId { get; set; }

        /// <summary>
        /// Indicates that was no attempt to scan a message or attachment because it was not applicable in the given
        /// context (e.g. atomic mutuate). If this is true, scan_outcome should not be set. This flag is used to
        /// identify messages that DLP did not attempt to scan for monitoring scan coverage. Contents that DLP attempted
        /// to scan but skipped can be identified by DlpScanOutcome.SCAN_SKIPPED_* reasons.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scanNotApplicableForContext")]
        public virtual System.Nullable<bool> ScanNotApplicableForContext { get; set; }

        /// <summary>
        /// The outcome of a DLP Scan. If this is set, scan_not_applicable_for_context should not be true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scanOutcome")]
        public virtual string ScanOutcome { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DmId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unique server assigned Id, per Direct Message Space.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dmId")]
        public virtual string DmIdValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information on a document attached to an active conference.</summary>
    public class DocumentInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A whiteboard document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whiteboardInfo")]
        public virtual WhiteboardInfo WhiteboardInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Used to provide a search operator for double properties. This is optional. Search operators let users restrict
    /// the query to specific fields relevant to the type of item being searched.
    /// </summary>
    public class DoubleOperatorOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates the operator name required in the query in order to use the double property in sorting or as a
        /// facet. The operator name can only contain lowercase letters (a-z). The maximum length is 32 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatorName")]
        public virtual string OperatorName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The options for double properties.</summary>
    public class DoublePropertyOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If set, describes how the double should be used as a search operator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatorOptions")]
        public virtual DoubleOperatorOptions OperatorOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of double values.</summary>
    public class DoubleValues : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Drive follow-up search restricts (e.g. "followup:suggestions").</summary>
    public class DriveFollowUpRestrict : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Drive location search restricts (e.g. "is:starred").</summary>
    public class DriveLocationRestrict : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotation metadata for Drive artifacts.</summary>
    public class DriveMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("aclFixRequest")]
        public virtual AclFixRequest AclFixRequest { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("aclFixStatus")]
        public virtual AclFixStatus AclFixStatus { get; set; }

        /// <summary>Can the current user edit this resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canEdit")]
        public virtual System.Nullable<bool> CanEdit { get; set; }

        /// <summary>Can the current user share this resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canShare")]
        public virtual System.Nullable<bool> CanShare { get; set; }

        /// <summary>Can the current user view this resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canView")]
        public virtual System.Nullable<bool> CanView { get; set; }

        /// <summary>
        /// DriveAction for organizing this file in Drive. If the user does not have access to the Drive file, the value
        /// will be DriveAction.DRIVE_ACTION_UNSPECIFIED. This field is only set when part of a FileResult in a
        /// ListFilesResponse.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveAction")]
        public virtual string DriveAction { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("driveState")]
        public virtual string DriveState { get; set; }

        /// <summary>Output only. Trusted Resource URL for drive file embedding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("embedUrl")]
        public virtual TrustedResourceUrlProto EmbedUrl { get; set; }

        /// <summary>
        /// Indicates whether the Drive link contains an encrypted doc ID. If true, Dynamite should not attempt to query
        /// the doc ID in Drive Service. See go/docid-encryption for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedDocId")]
        public virtual System.Nullable<bool> EncryptedDocId { get; set; }

        /// <summary>This is deprecated and unneeded. TODO (b/182479059): Remove this.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedResourceKey")]
        public virtual string EncryptedResourceKey { get; set; }

        /// <summary>
        /// External mimetype of the Drive Resource (Useful for creating Drive URL) See: http://b/35219462
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalMimetype")]
        public virtual string ExternalMimetype { get; set; }

        /// <summary>Drive resource ID of the artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Deprecated. Whether the setting to restrict downloads is enabled for this file. This was previously used to
        /// determine whether to hide the download and print buttons in the UI, but is no longer used by clients,
        /// because Projector now independently queries Drive to ensure that we have the most up-to-date value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDownloadRestricted")]
        public virtual System.Nullable<bool> IsDownloadRestricted { get; set; }

        /// <summary>
        /// If the current user is the Drive file's owner. The field is currently only set for Annotations for the
        /// ListFiles action (as opposed to fetching Topics/Messages with Drive annotations).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isOwner")]
        public virtual System.Nullable<bool> IsOwner { get; set; }

        /// <summary>Only present if this DriveMetadata is converted from an UploadMetadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("legacyUploadMetadata")]
        public virtual LegacyUploadMetadata LegacyUploadMetadata { get; set; }

        /// <summary>Mimetype of the Drive Resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimetype")]
        public virtual string Mimetype { get; set; }

        /// <summary>The display name of the organization owning the Drive item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organizationDisplayName")]
        public virtual string OrganizationDisplayName { get; set; }

        /// <summary>
        /// Shortcut ID of this drive file in the shared drive, which is associated with a named room this file was
        /// shared in. Shortcuts will not be created for DMs or unnamed rooms. This is populated after the DriveMetadata
        /// is migrated to shared drive. go/chat-shared-drive-uploads.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortcutAuthorizedItemId")]
        public virtual AuthorizedItemId ShortcutAuthorizedItemId { get; set; }

        /// <summary>
        /// If this field is set to true, server should still contact external backends to get metadata for search but
        /// clients should not render this chip.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shouldNotRender")]
        public virtual System.Nullable<bool> ShouldNotRender { get; set; }

        /// <summary>Thumbnail image of the Drive Resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnailHeight")]
        public virtual System.Nullable<int> ThumbnailHeight { get; set; }

        /// <summary>Thumbnail image of the Drive Resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnailUrl")]
        public virtual string ThumbnailUrl { get; set; }

        /// <summary>Thumbnail image of the Drive Resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnailWidth")]
        public virtual System.Nullable<int> ThumbnailWidth { get; set; }

        /// <summary>Title of the Drive Resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// Url string fragment that generally indicates the specific location in the linked file. Example:
        /// #header=h.123abc456. If the fragment is not present this will not be present and therefore default to an
        /// empty string. The "#" will not be included.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlFragment")]
        public virtual string UrlFragment { get; set; }

        /// <summary>This is considered SPII and should not be logged.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wrappedResourceKey")]
        public virtual WrappedResourceKey WrappedResourceKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Drive mime-type search restricts (e.g. "type:pdf").</summary>
    public class DriveMimeTypeRestrict : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The time span search restrict (e.g. "after:2017-09-11 before:2017-09-12").</summary>
    public class DriveTimeSpanRestrict : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This is the proto for holding space level scoring information. This data is used for logging in query-api server
    /// and for testing purposes.
    /// </summary>
    public class DynamiteSpacesScoringInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("affinityScore")]
        public virtual System.Nullable<double> AffinityScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("commonContactCountAffinityScore")]
        public virtual System.Nullable<double> CommonContactCountAffinityScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("contactsIntersectionCount")]
        public virtual System.Nullable<double> ContactsIntersectionCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("finalScore")]
        public virtual System.Nullable<double> FinalScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("freshnessScore")]
        public virtual System.Nullable<double> FreshnessScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("joinedSpacesAffinityScore")]
        public virtual System.Nullable<double> JoinedSpacesAffinityScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("lastMessagePostedTimestampSecs")]
        public virtual System.Nullable<long> LastMessagePostedTimestampSecs { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("lastReadTimestampSecs")]
        public virtual System.Nullable<long> LastReadTimestampSecs { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("memberMetadataCount")]
        public virtual System.Nullable<double> MemberMetadataCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("messageScore")]
        public virtual System.Nullable<double> MessageScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("numAucContacts")]
        public virtual System.Nullable<long> NumAucContacts { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("smallContactListAffinityScore")]
        public virtual System.Nullable<double> SmallContactListAffinityScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("smallUnjoinedSpacesAffinityScore")]
        public virtual System.Nullable<double> SmallUnjoinedSpacesAffinityScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("spaceAgeInDays")]
        public virtual System.Nullable<double> SpaceAgeInDays { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("spaceCreationTimestampSecs")]
        public virtual System.Nullable<long> SpaceCreationTimestampSecs { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("topicalityScore")]
        public virtual System.Nullable<double> TopicalityScore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message edit in Dynamite inserts a Babel-only item containing this field.</summary>
    public class EditMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A person's email address.</summary>
    public class EmailAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If the value of type is custom, this property contains the custom type string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customType")]
        public virtual string CustomType { get; set; }

        /// <summary>The email address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddressValue { get; set; }

        /// <summary>The URL to send email.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailUrl")]
        public virtual string EmailUrl { get; set; }

        /// <summary>Indicates if this is the user's primary email. Only one entry can be marked as primary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primary")]
        public virtual System.Nullable<bool> Primary { get; set; }

        /// <summary>The type of the email account. Acceptable values are: "custom", "home", "other", "work".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a verified owner of the given email address. Note that a single address may have many owners, and a
    /// single user may own many addresses. (All lower-case, in display form -- see com.google.gaia.client.GaiaEmail)
    /// </summary>
    public class EmailOwnerProto : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents an embedded object in an update. This is a wrapper class that can contain a single specific item
    /// proto in an extension field. Think of it as a base class like `Message` in Java. Each item proto must declare
    /// that it extends this proto: message ExampleObject { option (item_type) = EXAMPLE_OBJECT; extend EmbedClientItem
    /// { optional ExampleObject example_object = ; } } See go/es-embeds for details.
    /// </summary>
    public class EmbedClientItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The canonical ID of the embed. If absent, the canonical ID is equal to the ID; if present, then the
        /// canonical ID represents an "equivalence class" of embeds which really refer to the same object. (For
        /// example, the URLs http://www.foo.com/ and http://foo.com/ refer to the same object) This field may be
        /// updated periodically by background processes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalId")]
        public virtual string CanonicalId { get; set; }

        /// <summary>
        /// Deep-linking data to take the user to the right place in a mobile app. This is only used for preview and
        /// attribution. Links that are specific to a given embed type should live on that specific embed's proto by
        /// using Link. See http://goto.google.com/mariana-design.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deepLinkData")]
        public virtual DeepLinkData DeepLinkData { get; set; }

        /// <summary>
        /// The ID of the embed. This corresponds to the schema.org ID, as represented in the ItemScope.id field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The provenance of the embed, populated when the embed originated from a web fetch. The provenance captures
        /// information about the web page the embed had originated, like the URL that was retrieved and the retrieved
        /// URL's canonical form. This is useful in the case where the URL shared by the URL redirects (e.g., in the
        /// case of a shortened URL).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual Provenance Provenance { get; set; }

        /// <summary>
        /// The ID used to identify the embed during rendering. This field will match ID, if set, otherwise it will be
        /// the ID of the parent activity. This field is only populated on the server for client use and is not
        /// persisted to storage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renderId")]
        public virtual string RenderId { get; set; }

        /// <summary>Signature of the embed, used for verification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signature")]
        public virtual string Signature { get; set; }

        /// <summary>Transient generic data that will not be saved on the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transientData")]
        public virtual TransientData TransientData { get; set; }

        /// <summary>
        /// The first value in `type` determines which extension field will be set. When creating an EmbedClientItem,
        /// you only need to set the first (primary) type in this field. When the server receives the item, it will
        /// populate the full type list using the parent annotations in the ItemType enum.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual System.Collections.Generic.IList<string> Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Used to provide a search operator for enum properties. This is optional. Search operators let users restrict the
    /// query to specific fields relevant to the type of item being searched. For example, if you provide no operator
    /// for a *priority* enum property with possible values *p0* and *p1*, a query that contains the term *p0* returns
    /// items that have *p0* as the value of the *priority* property, as well as any items that contain the string *p0*
    /// in other fields. If you provide an operator name for the enum, such as *priority*, then search users can use
    /// that operator to refine results to only items that have *p0* as this property's value, with the query
    /// *priority:p0*.
    /// </summary>
    public class EnumOperatorOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates the operator name required in the query in order to isolate the enum property. For example, if
        /// operatorName is *priority* and the property's name is *priorityVal*, then queries like
        /// *priority:&amp;lt;value&amp;gt;* show results only where the value of the property named *priorityVal*
        /// matches *&amp;lt;value&amp;gt;*. By contrast, a search that uses the same *&amp;lt;value&amp;gt;* without an
        /// operator returns all items where *&amp;lt;value&amp;gt;* matches the value of any String properties or text
        /// within the content field for the item. The operator name can only contain lowercase letters (a-z). The
        /// maximum length is 32 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatorName")]
        public virtual string OperatorName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The options for enum properties, which allow you to define a restricted set of strings to match user queries,
    /// set rankings for those string values, and define an operator name to be paired with those strings so that users
    /// can narrow results to only items with a specific value. For example, for items in a request tracking system with
    /// priority information, you could define *p0* as an allowable enum value and tie this enum to the operator name
    /// *priority* so that search users could add *priority:p0* to their query to restrict the set of results to only
    /// those items indexed with the value *p0*.
    /// </summary>
    public class EnumPropertyOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If set, describes how the enum should be used as a search operator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatorOptions")]
        public virtual EnumOperatorOptions OperatorOptions { get; set; }

        /// <summary>
        /// Used to specify the ordered ranking for the enumeration that determines how the integer values provided in
        /// the possible EnumValuePairs are used to rank results. If specified, integer values must be provided for all
        /// possible EnumValuePair values given for this property. Can only be used if isRepeatable is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderedRanking")]
        public virtual string OrderedRanking { get; set; }

        /// <summary>
        /// The list of possible values for the enumeration property. All EnumValuePairs must provide a string value. If
        /// you specify an integer value for one EnumValuePair, then all possible EnumValuePairs must provide an integer
        /// value. Both the string value and integer value must be unique over all possible values. Once set, possible
        /// values cannot be removed or modified. If you supply an ordered ranking and think you might insert additional
        /// enum values in the future, leave gaps in the initial integer values to allow adding a value in between
        /// previously registered values. The maximum number of elements is 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("possibleValues")]
        public virtual System.Collections.Generic.IList<EnumValuePair> PossibleValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The enumeration value pair defines two things: a required string value and an optional integer value. The string
    /// value defines the necessary query term required to retrieve that item, such as *p0* for a priority item. The
    /// integer value determines the ranking of that string value relative to other enumerated values for the same
    /// property. For example, you might associate *p0* with *0* and define another enum pair such as *p1* and *1*. You
    /// must use the integer value in combination with ordered ranking to set the ranking of a given value relative to
    /// other enumerated values for the same property name. Here, a ranking order of DESCENDING for *priority*
    /// properties results in a ranking boost for items indexed with a value of *p0* compared to items indexed with a
    /// value of *p1*. Without a specified ranking order, the integer value has no effect on item ranking.
    /// </summary>
    public class EnumValuePair : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The integer value of the EnumValuePair which must be non-negative. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integerValue")]
        public virtual System.Nullable<int> IntegerValue { get; set; }

        /// <summary>The string value of the EnumValuePair. The maximum length is 32 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of enum values.</summary>
    public class EnumValues : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The maximum allowable length for string values is 32 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Error information about the response.</summary>
    public class ErrorInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessages")]
        public virtual System.Collections.Generic.IList<ErrorMessage> ErrorMessages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Error message per source response.</summary>
    public class ErrorMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessageValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual Source Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EventAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual System.Nullable<int> Type { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the invitees or other users associated with a Google+ Event (see http://goto/events-backend-design).
    /// </summary>
    public class EventProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Event IDs consist of alphanumeric characters and colons. Currently required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>
        /// The type of Event members to consider, e.g. "all members" vs. "owners" vs. "admins". These are defined by
        /// legacy_relation_id values in social.graph.storage.EdgeTypeEnum.EdgeType enum options in
        /// social/graph/storage/proto/id.proto. See event.pb (defined in
        /// production/config/cdd/socialgraph/mixer_config/prod/node_type_config) for all valid edge types associated
        /// with event. Currently required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberType")]
        public virtual System.Nullable<int> MemberType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A bucket in a facet is the basic unit of operation. A bucket can comprise either a single value OR a contiguous
    /// range of values, depending on the type of the field bucketed. FacetBucket is currently used only for returning
    /// the response object.
    /// </summary>
    public class FacetBucket : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Number of results that match the bucket value. Counts are only returned for searches when count accuracy is
        /// ensured. Cloud Search does not guarantee facet counts for any query and facet counts might be present only
        /// intermittently, even for identical queries. Do not build dependencies on facet count existence; instead use
        /// facet ount percentages which are always returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<int> Count { get; set; }

        /// <summary>
        /// Percent of results that match the bucket value. The returned value is between (0-100], and is rounded down
        /// to an integer if fractional. If the value is not explicitly returned, it represents a percentage value that
        /// rounds to 0. Percentages are returned for all searches, but are an estimate. Because percentages are always
        /// returned, you should render percentages instead of counts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentage")]
        public virtual System.Nullable<int> Percentage { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual Value Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies operators to return facet results for. There will be one FacetResult for every
    /// source_name/object_type/operator_name combination.
    /// </summary>
    public class FacetOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Maximum number of facet buckets that should be returned for this facet. Defaults to 10. Maximum value is
        /// 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numFacetBuckets")]
        public virtual System.Nullable<int> NumFacetBuckets { get; set; }

        /// <summary>
        /// If object_type is set, only those objects of that type will be used to compute facets. If empty, then all
        /// objects will be used to compute facets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectType")]
        public virtual string ObjectType { get; set; }

        /// <summary>The name of the operator chosen for faceting. @see cloudsearch.SchemaPropertyOptions</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatorName")]
        public virtual string OperatorName { get; set; }

        /// <summary>
        /// Source name to facet on. Format: datasources/{source_id} If empty, all data sources will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceName")]
        public virtual string SourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Source specific facet response</summary>
    public class FacetResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// FacetBuckets for values in response containing at least a single result with the corresponding filter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buckets")]
        public virtual System.Collections.Generic.IList<FacetBucket> Buckets { get; set; }

        /// <summary>Object type for which facet results are returned. Can be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectType")]
        public virtual string ObjectType { get; set; }

        /// <summary>The name of the operator chosen for faceting. @see cloudsearch.SchemaPropertyOptions</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatorName")]
        public virtual string OperatorName { get; set; }

        /// <summary>Source name for which facet results are returned. Will not be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceName")]
        public virtual string SourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class FieldViolation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description of the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Path of field with violation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic way of expressing filters in a query, which supports two approaches: **1. Setting a ValueFilter.** The
    /// name must match an operator_name defined in the schema for your data source. **2. Setting a CompositeFilter.**
    /// The filters are evaluated using the logical operator. The top-level operators can only be either an AND or a
    /// NOT. AND can appear only at the top-most level. OR can appear only under a top-level AND.
    /// </summary>
    public class Filter : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("compositeFilter")]
        public virtual CompositeFilter CompositeFilter { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("valueFilter")]
        public virtual ValueFilter ValueFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Filter options to be applied on query.</summary>
    public class FilterOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Generic filter to restrict the search, such as `lang:en`, `site:xyz`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual Filter Filter { get; set; }

        /// <summary>
        /// If object_type is set, only objects of that type are returned. This should correspond to the name of the
        /// object that was registered within the definition of schema. The maximum length is 256 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectType")]
        public virtual string ObjectType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A persistent (sticky) footer that is added to the bottom of the card.</summary>
    public class FixedFooter : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("buttons")]
        public virtual System.Collections.Generic.IList<Button> Buttons { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("primaryButton")]
        public virtual TextButton PrimaryButton { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("secondaryButton")]
        public virtual TextButton SecondaryButton { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class FormAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Apps script function that should be invoked in the developer's apps script when the containing element is
        /// clicked/activated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionMethodName")]
        public virtual string ActionMethodName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("loadIndicator")]
        public virtual string LoadIndicator { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<ActionParameter> Parameters { get; set; }

        /// <summary>
        /// Indicates whether form values persist after the action. When false, the Apps Script is responsible for
        /// persisting values, by setting any form field values using the formInputs in the event. Disabling this
        /// behavior can be used if the add-on needs the ability to clear form fields, for example, as with persistent
        /// values, there is no means for clearing existing values. When disabling persistent values, it is strongly
        /// recommended that the add-on use LoadIndicator.SPINNER for all events, as this locks the UI to ensure no
        /// changes are made by the user while the action is being processed. When using LoadIndicator.NONE for any of
        /// the actions, persistent values are recommended, as it ensures that any changes made by the user after form /
        /// on change actions are sent to the server are not overwritten by the response. Persistent values disabled by
        /// default. While we recommend persistent values be used in the typical use case, we do not enable by default,
        /// as doing so would change the current behavior of existing add-ons in prod.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("persistValues")]
        public virtual System.Nullable<bool> PersistValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotation metadata for markup formatting</summary>
    public class FormatMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Font color is set if and only if format_type is FONT_COLOR. The components are stored as (alpha
        /// &amp;lt;&amp;lt; 24) | (red &amp;lt;&amp;lt; 16) | (green &amp;lt;&amp;lt; 8) | blue. Clients should always
        /// set the alpha component to 0xFF. NEXT TAG: 3
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontColor")]
        public virtual System.Nullable<long> FontColor { get; set; }

        /// <summary>LINT.ThenChange(//depot/google3/apps/dynamite/v1/web/datakeys/annotated_span.proto)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formatType")]
        public virtual string FormatType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Formatting information for a segment.</summary>
    public class Formatting : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("bold")]
        public virtual System.Nullable<bool> Bold { get; set; }

        /// <summary>This indicates that the segment should be rendered as highlighted or visually emphasized.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("highlight")]
        public virtual System.Nullable<bool> Highlight { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("italics")]
        public virtual System.Nullable<bool> Italics { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("strikethrough")]
        public virtual System.Nullable<bool> Strikethrough { get; set; }

        /// <summary>
        /// If set, this indicates that the segment should be rendered with the specified style. The absence of an
        /// explicit style represents "no style", i.e. the segment can be rendered with the default style chosen by the
        /// application.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("style")]
        public virtual string Style { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("underline")]
        public virtual System.Nullable<bool> Underline { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Indicates which freshness property to use when adjusting search ranking for an item. Fresher, more recent dates
    /// indicate higher quality. Use the freshness option property that best works with your data. For fileshare
    /// documents, last modified time is most relevant. For calendar event data, the time when the event occurs is a
    /// more relevant freshness indicator. In this way, calendar events that occur closer to the time of the search
    /// query are considered higher quality and ranked accordingly.
    /// </summary>
    public class FreshnessOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The duration after which an object should be considered stale. The default value is 180 days (in seconds).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freshnessDuration")]
        public virtual object FreshnessDuration { get; set; }

        /// <summary>
        /// This property indicates the freshness level of the object in the index. If set, this property must be a
        /// top-level property within the property definitions and it must be a timestamp type or date type. Otherwise,
        /// the Indexing API uses updateTime as the freshness indicator. The maximum length is 256 characters. When a
        /// property is used to calculate freshness, the value defaults to 2 years from the current time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freshnessProperty")]
        public virtual string FreshnessProperty { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GSuitePrincipal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This principal represents all users of the Google Workspace domain of the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gsuiteDomain")]
        public virtual System.Nullable<bool> GsuiteDomain { get; set; }

        /// <summary>This principal references a Google Workspace group name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gsuiteGroupEmail")]
        public virtual string GsuiteGroupEmail { get; set; }

        /// <summary>This principal references a Google Workspace user account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gsuiteUserEmail")]
        public virtual string GsuiteUserEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GaiaGroupProto : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("groupId")]
        public virtual System.Nullable<long> GroupId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Gaia account, which may represent a user, device, service account, etc. For prod (@prod.google.com) accounts,
    /// use MdbUserProto instead.
    /// </summary>
    public class GaiaUserProto : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual System.Nullable<long> UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details on the third-party interoperability settings for the meeting space.</summary>
    public class GatewayAccess : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether third-party gateway accesses are enabled for this meeting space. If enabled, the actual access code
        /// can be retrieved by calling the GetGatewayAccess RPC method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details how to join the conference via a SIP gateway.</summary>
    public class GatewaySipAccess : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Permanent numeric code for manual entry on specially configured devices, currently the same as the PSTN
        /// "Universal pin".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sipAccessCode")]
        public virtual string SipAccessCode { get; set; }

        /// <summary>
        /// The SIP URI the conference can be reached through. The string is on one of the formats: "sip:@" "sips:@"
        /// where currently is the 13-digit universal pin (with the future option to support using a Meet meeting code
        /// as well), and is a valid address to be resolved using a DNS SRV lookup, or a dotted quad.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GetCustomerIndexStatsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Average item count for the given date range for which billing is done.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageIndexedItemCount")]
        public virtual System.Nullable<long> AverageIndexedItemCount { get; set; }

        /// <summary>Summary of indexed item counts, one for each day in the requested range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stats")]
        public virtual System.Collections.Generic.IList<CustomerIndexStats> Stats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GetCustomerQueryStatsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("stats")]
        public virtual System.Collections.Generic.IList<CustomerQueryStats> Stats { get; set; }

        /// <summary>Total successful query count (status code 200) for the given date range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalQueryCount")]
        public virtual System.Nullable<long> TotalQueryCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response format for search application stats for a customer.</summary>
    public class GetCustomerSearchApplicationStatsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Average search application count for the given date range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageSearchApplicationCount")]
        public virtual System.Nullable<long> AverageSearchApplicationCount { get; set; }

        /// <summary>Search application stats by date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stats")]
        public virtual System.Collections.Generic.IList<CustomerSearchApplicationStats> Stats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GetCustomerSessionStatsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("stats")]
        public virtual System.Collections.Generic.IList<CustomerSessionStats> Stats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GetCustomerUserStatsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("stats")]
        public virtual System.Collections.Generic.IList<CustomerUserStats> Stats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GetDataSourceIndexStatsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Average item count for the given date range for which billing is done.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageIndexedItemCount")]
        public virtual System.Nullable<long> AverageIndexedItemCount { get; set; }

        /// <summary>Summary of indexed item counts, one for each day in the requested range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stats")]
        public virtual System.Collections.Generic.IList<DataSourceIndexStats> Stats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response format for getting query stats for a search application between given dates.</summary>
    public class GetSearchApplicationQueryStatsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Query stats per date for a search application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stats")]
        public virtual System.Collections.Generic.IList<SearchApplicationQueryStats> Stats { get; set; }

        /// <summary>Total successful query count (status code 200) for the given date range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalQueryCount")]
        public virtual System.Nullable<long> TotalQueryCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GetSearchApplicationSessionStatsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("stats")]
        public virtual System.Collections.Generic.IList<SearchApplicationSessionStats> Stats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GetSearchApplicationUserStatsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("stats")]
        public virtual System.Collections.Generic.IList<SearchApplicationUserStats> Stats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration of the Google Chat in Meet.</summary>
    public class GoogleChatConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the Chat group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chatGroupId")]
        public virtual string ChatGroupId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The markup for developers to specify the contents of a contextual AddOn.</summary>
    public class GoogleChatV1ContextualAddOnMarkup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of cards. A card must contain a header and at least 1 section.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cards")]
        public virtual System.Collections.Generic.IList<GoogleChatV1ContextualAddOnMarkupCard> Cards { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A card is a UI element that can contain UI widgets such as texts, images.</summary>
    public class GoogleChatV1ContextualAddOnMarkupCard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The actions of this card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardActions")]
        public virtual System.Collections.Generic.IList<GoogleChatV1ContextualAddOnMarkupCardCardAction> CardActions { get; set; }

        /// <summary>The header of the card. A header usually contains a title and an image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual GoogleChatV1ContextualAddOnMarkupCardCardHeader Header { get; set; }

        /// <summary>Name of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Sections are separated by a line divider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sections")]
        public virtual System.Collections.Generic.IList<GoogleChatV1ContextualAddOnMarkupCardSection> Sections { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A card action is the action associated with the card. For an invoice card, a typical action would be: delete
    /// invoice, email invoice or open the invoice in browser.
    /// </summary>
    public class GoogleChatV1ContextualAddOnMarkupCardCardAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The label used to be displayed in the action menu item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionLabel")]
        public virtual string ActionLabel { get; set; }

        /// <summary>The onclick action for this action item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual GoogleChatV1WidgetMarkupOnClick OnClick { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleChatV1ContextualAddOnMarkupCardCardHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The image's type (e.g. square border or circular border).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageStyle")]
        public virtual string ImageStyle { get; set; }

        /// <summary>The URL of the image in the card header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; }

        /// <summary>The subtitle of the card header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
        public virtual string Subtitle { get; set; }

        /// <summary>
        /// The title must be specified. The header has a fixed height: if both a title and subtitle is specified, each
        /// will take up 1 line. If only the title is specified, it will take up both lines.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A section contains a collection of widgets that are rendered (vertically) in the order that they are specified.
    /// Across all platforms, cards have a narrow fixed width, so there is currently no need for layout properties (e.g.
    /// float).
    /// </summary>
    public class GoogleChatV1ContextualAddOnMarkupCardSection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The header of the section, text formatted supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual string Header { get; set; }

        /// <summary>A section must contain at least 1 widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widgets")]
        public virtual System.Collections.Generic.IList<GoogleChatV1WidgetMarkup> Widgets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A widget is a UI element that presents texts, images, etc.</summary>
    public class GoogleChatV1WidgetMarkup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of buttons. Buttons is also oneof data and only one of these fields should be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buttons")]
        public virtual System.Collections.Generic.IList<GoogleChatV1WidgetMarkupButton> Buttons { get; set; }

        /// <summary>Display an image in this widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual GoogleChatV1WidgetMarkupImage Image { get; set; }

        /// <summary>Display a key value item in this widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyValue")]
        public virtual GoogleChatV1WidgetMarkupKeyValue KeyValue { get; set; }

        /// <summary>Display a text paragraph in this widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textParagraph")]
        public virtual GoogleChatV1WidgetMarkupTextParagraph TextParagraph { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A button. Can be a text button or an image button.</summary>
    public class GoogleChatV1WidgetMarkupButton : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A button with image and onclick action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageButton")]
        public virtual GoogleChatV1WidgetMarkupImageButton ImageButton { get; set; }

        /// <summary>A button with text and onclick action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textButton")]
        public virtual GoogleChatV1WidgetMarkupTextButton TextButton { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A form action describes the behavior when the form is submitted. For example, an Apps Script can be invoked to
    /// handle the form.
    /// </summary>
    public class GoogleChatV1WidgetMarkupFormAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The method name is used to identify which part of the form triggered the form submission. This information
        /// is echoed back to the Chat app as part of the card click event. The same method name can be used for several
        /// elements that trigger a common behavior if desired.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionMethodName")]
        public virtual string ActionMethodName { get; set; }

        /// <summary>List of action parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<GoogleChatV1WidgetMarkupFormActionActionParameter> Parameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// List of string parameters to supply when the action method is invoked. For example, consider three snooze
    /// buttons: snooze now, snooze 1 day, snooze next week. You might use action method = snooze(), passing the snooze
    /// type and snooze time in the list of string parameters.
    /// </summary>
    public class GoogleChatV1WidgetMarkupFormActionActionParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the parameter for the action script.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The value of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An image that is specified by a URL and can have an onclick action.</summary>
    public class GoogleChatV1WidgetMarkupImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The aspect ratio of this image (width/height). This field allows clients to reserve the right height for the
        /// image while waiting for it to load. It's not meant to override the native aspect ratio of the image. If
        /// unset, the server fills it by prefetching the image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aspectRatio")]
        public virtual System.Nullable<double> AspectRatio { get; set; }

        /// <summary>The URL of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; }

        /// <summary>The onclick action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual GoogleChatV1WidgetMarkupOnClick OnClick { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An image button with an onclick action.</summary>
    public class GoogleChatV1WidgetMarkupImageButton : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The icon specified by an enum that indices to an icon provided by Chat API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("icon")]
        public virtual string Icon { get; set; }

        /// <summary>The icon specified by a URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconUrl")]
        public virtual string IconUrl { get; set; }

        /// <summary>
        /// The name of this image_button which will be used for accessibility. Default value will be provided if
        /// developers don't specify.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The onclick action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual GoogleChatV1WidgetMarkupOnClick OnClick { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A UI element contains a key (label) and a value (content). And this element may also contain some actions such
    /// as onclick button.
    /// </summary>
    public class GoogleChatV1WidgetMarkupKeyValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The text of the bottom label. Formatted text supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bottomLabel")]
        public virtual string BottomLabel { get; set; }

        /// <summary>A button that can be clicked to trigger an action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("button")]
        public virtual GoogleChatV1WidgetMarkupButton Button { get; set; }

        /// <summary>The text of the content. Formatted text supported and always required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>If the content should be multiline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentMultiline")]
        public virtual System.Nullable<bool> ContentMultiline { get; set; }

        /// <summary>An enum value that will be replaced by the Chat API with the corresponding icon image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("icon")]
        public virtual string Icon { get; set; }

        /// <summary>The icon specified by a URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconUrl")]
        public virtual string IconUrl { get; set; }

        /// <summary>The onclick action. Only the top label, bottom label and content region are clickable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual GoogleChatV1WidgetMarkupOnClick OnClick { get; set; }

        /// <summary>The text of the top label. Formatted text supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topLabel")]
        public virtual string TopLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An onclick action (e.g. open a link).</summary>
    public class GoogleChatV1WidgetMarkupOnClick : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A form action will be triggered by this onclick if specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual GoogleChatV1WidgetMarkupFormAction Action { get; set; }

        /// <summary>This onclick triggers an open link action if specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openLink")]
        public virtual GoogleChatV1WidgetMarkupOpenLink OpenLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A link that opens a new window.</summary>
    public class GoogleChatV1WidgetMarkupOpenLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URL to open.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A button with text and onclick action.</summary>
    public class GoogleChatV1WidgetMarkupTextButton : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The onclick action of the button.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual GoogleChatV1WidgetMarkupOnClick OnClick { get; set; }

        /// <summary>The text of the button.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A paragraph of text. Formatted text supported.</summary>
    public class GoogleChatV1WidgetMarkupTextParagraph : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The corpus specific metadata for office-type documents, from Google Docs and other sources. This message is
    /// passed to the scorer and beyond. Next tag: 9
    /// </summary>
    public class GoogleDocsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contains number of users and groups which can access the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aclInfo")]
        public virtual AclInfo AclInfo { get; set; }

        /// <summary>The conceptual type (presentation, document, etc.) of this document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentType")]
        public virtual string DocumentType { get; set; }

        /// <summary>
        /// The file extension of the document. NOTE: As of October 2018 this field is not backfilled for old documents.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileExtension")]
        public virtual string FileExtension { get; set; }

        /// <summary>
        /// The last time this document was modified, in seconds since epoch. Only counts content modifications.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastContentModifiedTimestamp")]
        public virtual System.Nullable<long> LastContentModifiedTimestamp { get; set; }

        /// <summary>Contains number of subscribers for the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numSubscribers")]
        public virtual System.Nullable<int> NumSubscribers { get; set; }

        /// <summary>Size of untruncated viewers list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numViewers")]
        public virtual System.Nullable<int> NumViewers { get; set; }

        /// <summary>
        /// Additional per-result information, akin to Gmail's SingleThreadResponse. Note: GWS no longer seems to use
        /// this field, but there's still one reference to it for Scribe, so we can't remove it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultInfo")]
        public virtual GoogleDocsResultInfo ResultInfo { get; set; }

        /// <summary>Contains additional information about the document depending on its type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("typeInfo")]
        public virtual TypeInfo TypeInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A message containing information about a specific result. This information is passed to the scorer and beyond;
    /// in particular, GWS relies on it to format the result in the UI. Split from GoogleDocsMetadata in case we later
    /// want to reuse the message.
    /// </summary>
    public class GoogleDocsResultInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The SHA1 hash of the object in Drive, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachmentSha1")]
        public virtual string AttachmentSha1 { get; set; }

        /// <summary>
        /// The storage identifier for the object in Cosmo. This field is intended to used by Stratus/Moonshine
        /// integration only. It should not be exposed externally (please refer to encrypted_id for that purpose).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cosmoId")]
        public virtual Id CosmoId { get; set; }

        /// <summary>
        /// For Cosmo objects, the Cosmo namespace the object was in. This allows downstream clients to identify whether
        /// a document was created in Writely or Kix, Presently or Punch, or whether it was uploaded from GDrive. See
        /// storage_cosmo.Id.NAME_SPACE for a list of all Cosmo name spaces.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cosmoNameSpace")]
        public virtual System.Nullable<int> CosmoNameSpace { get; set; }

        /// <summary>
        /// The encrypted (user-visible) id of this object. Knowing the id is sufficient to create a canonical URL for
        /// this document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedId")]
        public virtual string EncryptedId { get; set; }

        /// <summary>The mimetype of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The visibility indicator in the UI will be based upon this.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shareScope")]
        public virtual ShareScope ShareScope { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Grid : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The border style to apply to each grid item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borderStyle")]
        public virtual BorderStyle BorderStyle { get; set; }

        /// <summary>The items to display in the grid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<GridItem> Items { get; set; }

        /// <summary>
        /// The number of columns to display in the grid. Note that a default value will be used if this field is not
        /// specified, and that default value will be different depending on where the grid is shown (dialog vs
        /// companion).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numColumns")]
        public virtual System.Nullable<int> NumColumns { get; set; }

        /// <summary>
        /// This callback will be reused by each individual GridItem, but with the item's identifier and index in the
        /// items list added to the callback's parameters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual OnClick OnClick { get; set; }

        /// <summary>The text to display in the grid header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GridItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A user-specified identifier for this grid item. This identifier will be returned in the parent Grid's
        /// on_click callback's parameters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identifier")]
        public virtual string Identifier { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual ImageComponent Image { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual string Layout { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
        public virtual string Subtitle { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("textAlignment")]
        public virtual string TextAlignment { get; set; }

        /// <summary>Text properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GroupDetailsUpdatedMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("newGroupDetails")]
        public virtual AppsDynamiteSharedGroupDetails NewGroupDetails { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("prevGroupDetails")]
        public virtual AppsDynamiteSharedGroupDetails PrevGroupDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Id representing a group that could be a space, a chat, or a direct message space. Which ID is set here will
    /// determine which group
    /// </summary>
    public class GroupId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unique, immutable ID of the Direct Message Space</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dmId")]
        public virtual DmId DmId { get; set; }

        /// <summary>Unique, immutable ID of the Space</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spaceId")]
        public virtual SpaceId SpaceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GroupLinkSharingModificationEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("newStatus")]
        public virtual string NewStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GroupRetentionSettingsUpdatedMetaData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The user who triggered the retention settings update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initiator")]
        public virtual UserId Initiator { get; set; }

        /// <summary>The updated space retention settings</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retentionSettings")]
        public virtual AppsDynamiteSharedRetentionSettings RetentionSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotation metadata for an GsuiteIntegration artifact.</summary>
    public class GsuiteIntegrationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("activityFeedData")]
        public virtual AppsDynamiteSharedActivityFeedAnnotationData ActivityFeedData { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("assistantData")]
        public virtual AppsDynamiteSharedAssistantAnnotationData AssistantData { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("calendarEventData")]
        public virtual AppsDynamiteSharedCalendarEventAnnotationData CalendarEventData { get; set; }

        /// <summary>Data used to render call artifacts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callData")]
        public virtual AppsDynamiteSharedCallAnnotationData CallData { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("clientType")]
        public virtual string ClientType { get; set; }

        /// <summary>
        /// A list of all strings that are to be indexed for this 1P chip. Each string in this list would be the
        /// contents of a single string field in the 1P chip. Eg. For Tasks[title = “hello world”, description = “good
        /// bye”]. If we want to index only the title, this would be set to [“hello world”]. If both title and
        /// description, then this would be [“hello world”, “good bye”]. Please make sure that the contents of this
        /// field is a subset of strings that are rendered as part of the 1P Chip.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexableTexts")]
        public virtual System.Collections.Generic.IList<string> IndexableTexts { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tasksData")]
        public virtual AppsDynamiteSharedTasksAnnotationData TasksData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class HangoutEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("hangoutDurationSecs")]
        public virtual System.Nullable<long> HangoutDurationSecs { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("mediaType")]
        public virtual string MediaType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("participantId")]
        public virtual System.Collections.Generic.IList<StoredParticipantId> ParticipantId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message representing the Hangout video start/end events in Babel</summary>
    public class HangoutVideoEventMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("hangoutVideoType")]
        public virtual string HangoutVideoType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Hashtag metadata, for HASHTAG segments. For a hashtag, the "text" field should contain the display text, and the
    /// search_text field should represent the topic being referenced, without the hash symbol; for example, we might
    /// have: text = "#Google" hashtag_data.search_text = "Google" Another example: text = "#pikachu"
    /// hashtag_data.search_text = "Pokemon" Both strings should be considered part of the searchable text. In go/sbe,
    /// both are indexed and searchable.
    /// </summary>
    public class HashtagData : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("searchText")]
        public virtual string SearchText { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a single host. Optionally, the MDB owner of the host can be specified.</summary>
    public class HostProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Lower-case, fully qualified hostname.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostName")]
        public virtual string HostName { get; set; }

        /// <summary>
        /// If present, then any checks that compare this Principal to LOAS peer info must confirm the peer's machine
        /// owner is equal to 'host_owner'. If absent, then any peer machine owner is acceptable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostOwner")]
        public virtual string HostOwner { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Used to provide a search operator for html properties. This is optional. Search operators let users restrict the
    /// query to specific fields relevant to the type of item being searched.
    /// </summary>
    public class HtmlOperatorOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates the operator name required in the query in order to isolate the html property. For example, if
        /// operatorName is *subject* and the property's name is *subjectLine*, then queries like
        /// *subject:&amp;lt;value&amp;gt;* show results only where the value of the property named *subjectLine*
        /// matches *&amp;lt;value&amp;gt;*. By contrast, a search that uses the same *&amp;lt;value&amp;gt;* without an
        /// operator return all items where *&amp;lt;value&amp;gt;* matches the value of any html properties or text
        /// within the content field for the item. The operator name can only contain lowercase letters (a-z). The
        /// maximum length is 32 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatorName")]
        public virtual string OperatorName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The options for html properties.</summary>
    public class HtmlPropertyOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If set, describes how the property should be used as a search operator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatorOptions")]
        public virtual HtmlOperatorOptions OperatorOptions { get; set; }

        /// <summary>
        /// Indicates the search quality importance of the tokens within the field when used for retrieval. Can only be
        /// set to DEFAULT or NONE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retrievalImportance")]
        public virtual RetrievalImportance RetrievalImportance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of html values.</summary>
    public class HtmlValues : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The maximum allowable length for html values is 2048 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IconImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The alternative text of this icon_url which will be used for accessibility.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altText")]
        public virtual string AltText { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("icon")]
        public virtual string Icon { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("iconUrl")]
        public virtual string IconUrl { get; set; }

        /// <summary>
        /// The image cropping style. Note that icons with a CIRCLE style are rendered larger than the default icon
        /// size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageStyle")]
        public virtual string ImageStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Identifies a particular object, including both Users and DirEntries. This Id is unique across the entire server
    /// instance, such as the production or qa instance.
    /// </summary>
    public class Id : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The User account in which the DirEntry was originally created. If name_space==GAIA, then it's the gaia_id of
        /// the user this id is referring to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creatorUserId")]
        public virtual System.Nullable<ulong> CreatorUserId { get; set; }

        /// <summary>
        /// The local identifier for the DirEntry (local to the creator's account). local_id + app_name is guaranteed to
        /// be unique within the creator account, but not across all User accounts. The string is case sensitive. Ignore
        /// if name_space==GAIA. NB For name_space==COSMO, all local_id's should be defined in
        /// google3/java/com/google/storage/cosmo/server/api/SpecialObjectIds.java as they have a special predefined
        /// meaning. See cosmo.client.CosmoIdFactory.createObjectId(long,String) for IMPORTANT recommendations when
        /// generating IDs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localId")]
        public virtual string LocalId { get; set; }

        /// <summary>
        /// The name space in which this id is unique (typically the application that created it). Values should be
        /// drawn from the above enum, but for experimentation, use values greater than 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nameSpace")]
        public virtual System.Nullable<int> NameSpace__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Image : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The alternative text of this image which will be used for accessibility.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altText")]
        public virtual string AltText { get; set; }

        /// <summary>The aspect ratio of this image (width/height).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aspectRatio")]
        public virtual System.Nullable<double> AspectRatio { get; set; }

        /// <summary>
        /// Image url specified by developers. Server side, we will wrap with FIFE so client apps can configure
        /// size/cropping/etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual OnClick OnClick { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ImageButton : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("icon")]
        public virtual string Icon { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("iconUrl")]
        public virtual string IconUrl { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual OnClick OnClick { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// NOTE: Through future refactoring work, this image component will eventually be used in the Image widget, and
    /// will likely replace the Icon proto as well.
    /// </summary>
    public class ImageComponent : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("altText")]
        public virtual string AltText { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("borderStyle")]
        public virtual BorderStyle BorderStyle { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("cropStyle")]
        public virtual ImageCropStyle CropStyle { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a crop style that can be applied to an image.</summary>
    public class ImageCropStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The aspect ratio to use if the crop type is RECTANGLE_CUSTOM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aspectRatio")]
        public virtual System.Nullable<double> AspectRatio { get; set; }

        /// <summary>The crop type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This is deprecated and please use KeyValue.</summary>
    public class ImageKeyValue : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("icon")]
        public virtual string Icon { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("iconUrl")]
        public virtual string IconUrl { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual OnClick OnClick { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotation metadata to display system messages for incoming webhook events. Next Tag: 7</summary>
    public class IncomingWebhookChangedMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The webhook name at the time of the change. Used in Spanner storage, BE API responses and FE API responses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("incomingWebhookName")]
        public virtual string IncomingWebhookName { get; set; }

        /// <summary>
        /// The user id of the user whose action triggered this system message. Used in Spanner storage, BE API
        /// responses and FE API responses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initiatorId")]
        public virtual UserId InitiatorId { get; set; }

        /// <summary>
        /// Complete profile when ListTopicsRequest FetchOptions.USER is set. Otherwise, only the id will be filled in.
        /// Used in FE API responses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initiatorProfile")]
        public virtual User InitiatorProfile { get; set; }

        /// <summary>
        /// The webhook id of the incoming webhook in question. This field should not be used to load webhook
        /// information dynamically and is only present for debugging purposes. Used in Spanner storage, BE API
        /// responses and FE API responses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("obfuscatedIncomingWebhookId")]
        public virtual string ObfuscatedIncomingWebhookId { get; set; }

        /// <summary>
        /// Only populated for UPDATED_NAME and UPDATED_NAME_AND_AVATAR events, where the webhook name was changed. Used
        /// in Spanner storage, BE API responses and FE API responses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldIncomingWebhookName")]
        public virtual string OldIncomingWebhookName { get; set; }

        /// <summary>Used in Spanner storage, BE API responses and FE API responses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IndexItemOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies if the index request should allow Google Workspace principals that do not exist or are deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowUnknownGsuitePrincipals")]
        public virtual System.Nullable<bool> AllowUnknownGsuitePrincipals { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IndexItemRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of connector making this call. Format: datasources/{source_id}/connectors/{ID}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectorName")]
        public virtual string ConnectorName { get; set; }

        /// <summary>Common debug options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugOptions")]
        public virtual DebugOptions DebugOptions { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("indexItemOptions")]
        public virtual IndexItemOptions IndexItemOptions { get; set; }

        /// <summary>The name of the item. Format: datasources/{source_id}/items/{item_id}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("item")]
        public virtual Item Item { get; set; }

        /// <summary>Required. The RequestMode for this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `InitializeCustomer` method.</summary>
    public class InitializeCustomerRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Used to provide a search operator for integer properties. This is optional. Search operators let users restrict
    /// the query to specific fields relevant to the type of item being searched.
    /// </summary>
    public class IntegerOperatorOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates the operator name required in the query in order to isolate the integer property using the
        /// greater-than operator. For example, if greaterThanOperatorName is *priorityabove* and the property's name is
        /// *priorityVal*, then queries like *priorityabove:&amp;lt;value&amp;gt;* show results only where the value of
        /// the property named *priorityVal* is greater than *&amp;lt;value&amp;gt;*. The operator name can only contain
        /// lowercase letters (a-z). The maximum length is 32 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("greaterThanOperatorName")]
        public virtual string GreaterThanOperatorName { get; set; }

        /// <summary>
        /// Indicates the operator name required in the query in order to isolate the integer property using the
        /// less-than operator. For example, if lessThanOperatorName is *prioritybelow* and the property's name is
        /// *priorityVal*, then queries like *prioritybelow:&amp;lt;value&amp;gt;* show results only where the value of
        /// the property named *priorityVal* is less than *&amp;lt;value&amp;gt;*. The operator name can only contain
        /// lowercase letters (a-z). The maximum length is 32 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lessThanOperatorName")]
        public virtual string LessThanOperatorName { get; set; }

        /// <summary>
        /// Indicates the operator name required in the query in order to isolate the integer property. For example, if
        /// operatorName is *priority* and the property's name is *priorityVal*, then queries like
        /// *priority:&amp;lt;value&amp;gt;* show results only where the value of the property named *priorityVal*
        /// matches *&amp;lt;value&amp;gt;*. By contrast, a search that uses the same *&amp;lt;value&amp;gt;* without an
        /// operator returns all items where *&amp;lt;value&amp;gt;* matches the value of any String properties or text
        /// within the content field for the item. The operator name can only contain lowercase letters (a-z). The
        /// maximum length is 32 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatorName")]
        public virtual string OperatorName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The options for integer properties.</summary>
    public class IntegerPropertyOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The maximum value of the property. The minimum and maximum values for the property are used to rank results
        /// according to the ordered ranking. Indexing requests with values greater than the maximum are accepted and
        /// ranked with the same weight as items indexed with the maximum value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumValue")]
        public virtual System.Nullable<long> MaximumValue { get; set; }

        /// <summary>
        /// The minimum value of the property. The minimum and maximum values for the property are used to rank results
        /// according to the ordered ranking. Indexing requests with values less than the minimum are accepted and
        /// ranked with the same weight as items indexed with the minimum value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumValue")]
        public virtual System.Nullable<long> MinimumValue { get; set; }

        /// <summary>If set, describes how the integer should be used as a search operator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatorOptions")]
        public virtual IntegerOperatorOptions OperatorOptions { get; set; }

        /// <summary>
        /// Used to specify the ordered ranking for the integer. Can only be used if isRepeatable is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderedRanking")]
        public virtual string OrderedRanking { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of integer values.</summary>
    public class IntegerValues : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IntegrationConfigMutation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Add an app using its identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addApp")]
        public virtual AppId AddApp { get; set; }

        /// <summary>Add a pinned tab using its identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addPinnedItem")]
        public virtual PinnedItemId AddPinnedItem { get; set; }

        /// <summary>Remove an active app using its identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removeApp")]
        public virtual AppId RemoveApp { get; set; }

        /// <summary>Remove an active pinned tab using its identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removePinnedItem")]
        public virtual PinnedItemId RemovePinnedItem { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Annotation metadata to display system message for integration config updated event. This metadata is stored in
    /// spanner, and can be dispatched to clients without any field modification or transformation.
    /// </summary>
    public class IntegrationConfigUpdatedMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The user whose action triggered this system message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initiatorId")]
        public virtual UserId InitiatorId { get; set; }

        /// <summary>A list of updates applied on the integration config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mutations")]
        public virtual System.Collections.Generic.IList<IntegrationConfigMutation> Mutations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an interaction between a user and an item.</summary>
    public class Interaction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The time when the user acted on the item. If multiple actions of the same type exist for a single user, only
        /// the most recent action is recorded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interactionTime")]
        public virtual object InteractionTime { get; set; }

        /// <summary>The user that acted on the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principal")]
        public virtual Principal Principal { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class InviteAcceptedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("participantId")]
        public virtual System.Collections.Generic.IList<StoredParticipantId> ParticipantId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Invitee information from a Dynamite invitation. See go/dynamite-invitee-mgmt.</summary>
    public class InviteeInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Email as typed by the user when invited to Room or DM. This value will be canonicalized and hashed before
        /// retained in storage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>Unique, immutable ID of the User.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual UserId UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a single object that is an item in the search index, such as a file, folder, or a database record.
    /// </summary>
    public class Item : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Access control list for this item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acl")]
        public virtual ItemAcl Acl { get; set; }

        /// <summary>Item content to be indexed and made text searchable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual ItemContent Content { get; set; }

        /// <summary>The type for this item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemType")]
        public virtual string ItemType { get; set; }

        /// <summary>The metadata information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ItemMetadata Metadata { get; set; }

        /// <summary>
        /// The name of the Item. Format: datasources/{source_id}/items/{item_id} This is a required field. The maximum
        /// length is 1536 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Additional state connector can store for this item. The maximum length is 10000 bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual string Payload { get; set; }

        /// <summary>Queue this item belongs to. The maximum length is 100 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queue")]
        public virtual string Queue { get; set; }

        /// <summary>Status of the item. Output only field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ItemStatus Status { get; set; }

        /// <summary>
        /// The structured data for the item that should conform to a registered object definition in the schema for the
        /// data source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structuredData")]
        public virtual ItemStructuredData StructuredData { get; set; }

        /// <summary>
        /// Required. The indexing system stores the version from the datasource as a byte string and compares the Item
        /// version in the index to the version of the queued Item using lexical ordering. Cloud Search Indexing won't
        /// index or delete any queued item with a version value that is less than or equal to the version of the
        /// currently indexed item. The maximum length for this field is 1024 bytes. For information on how item version
        /// affects the deletion process, refer to [Handle revisions after manual
        /// deletes](https://developers.google.com/cloud-search/docs/guides/operations).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Access control list information for the item. For more information see [Map
    /// ACLs](https://developers.google.com/cloud-search/docs/guides/acls).
    /// </summary>
    public class ItemAcl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Sets the type of access rules to apply when an item inherits its ACL from a parent. This should always be
        /// set in tandem with the inheritAclFrom field. Also, when the inheritAclFrom field is set, this field should
        /// be set to a valid AclInheritanceType.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aclInheritanceType")]
        public virtual string AclInheritanceType { get; set; }

        /// <summary>
        /// List of principals who are explicitly denied access to the item in search results. While principals are
        /// denied access by default, use denied readers to handle exceptions and override the list allowed readers. The
        /// maximum number of elements is 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deniedReaders")]
        public virtual System.Collections.Generic.IList<Principal> DeniedReaders { get; set; }

        /// <summary>
        /// The name of the item to inherit the Access Permission List (ACL) from. Note: ACL inheritance *only* provides
        /// access permissions to child items and does not define structural relationships, nor does it provide
        /// convenient ways to delete large groups of items. Deleting an ACL parent from the index only alters the
        /// access permissions of child items that reference the parent in the inheritAclFrom field. The item is still
        /// in the index, but may not visible in search results. By contrast, deletion of a container item also deletes
        /// all items that reference the container via the containerName field. The maximum length for this field is
        /// 1536 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inheritAclFrom")]
        public virtual string InheritAclFrom { get; set; }

        /// <summary>
        /// Optional. List of owners for the item. This field has no bearing on document access permissions. It does,
        /// however, offer a slight ranking boosts items where the querying user is an owner. The maximum number of
        /// elements is 5.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("owners")]
        public virtual System.Collections.Generic.IList<Principal> Owners { get; set; }

        /// <summary>
        /// List of principals who are allowed to see the item in search results. Optional if inheriting permissions
        /// from another item or if the item is not intended to be visible, such as virtual containers. The maximum
        /// number of elements is 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readers")]
        public virtual System.Collections.Generic.IList<Principal> Readers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Content of an item to be indexed and surfaced by Cloud Search. Only UTF-8 encoded strings are allowed as
    /// inlineContent. If the content is uploaded and not binary, it must be UTF-8 encoded.
    /// </summary>
    public class ItemContent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Upload reference ID of a previously uploaded content via write method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentDataRef")]
        public virtual UploadItemRef ContentDataRef { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("contentFormat")]
        public virtual string ContentFormat { get; set; }

        /// <summary>
        /// Hashing info calculated and provided by the API client for content. Can be used with the items.push method
        /// to calculate modified state. The maximum length is 2048 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hash")]
        public virtual string Hash { get; set; }

        /// <summary>
        /// Content that is supplied inlined within the update method. The maximum length is 102400 bytes (100 KiB).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inlineContent")]
        public virtual string InlineContent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ItemCountByStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of items matching the status code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>
        /// Number of items matching the status code for which billing is done. This excludes virtual container items
        /// from the total count. This count would not be applicable for items with ERROR or NEW_ITEM status code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexedItemsCount")]
        public virtual System.Nullable<long> IndexedItemsCount { get; set; }

        /// <summary>Status of the items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusCode")]
        public virtual string StatusCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Available metadata fields for the item.</summary>
    public class ItemMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the container for this item. Deletion of the container item leads to automatic deletion of this
        /// item. Note: ACLs are not inherited from a container item. To provide ACL inheritance for an item, use the
        /// inheritAclFrom field. The maximum length is 1536 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerName")]
        public virtual string ContainerName { get; set; }

        /// <summary>
        /// The BCP-47 language code for the item, such as "en-US" or "sr-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier. The maximum length is 32 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentLanguage")]
        public virtual string ContentLanguage { get; set; }

        /// <summary>
        /// A set of named attributes associated with the item. This can be used for influencing the ranking of the item
        /// based on the context in the request. The maximum number of elements is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contextAttributes")]
        public virtual System.Collections.Generic.IList<ContextAttribute> ContextAttributes { get; set; }

        /// <summary>The time when the item was created in the source repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Hashing value provided by the API caller. This can be used with the items.push method to calculate modified
        /// state. The maximum length is 2048 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hash")]
        public virtual string Hash { get; set; }

        /// <summary>
        /// A list of interactions for the item. Interactions are used to improve Search quality, but are not exposed to
        /// end users. The maximum number of elements is 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interactions")]
        public virtual System.Collections.Generic.IList<Interaction> Interactions { get; set; }

        /// <summary>
        /// Additional keywords or phrases that should match the item. Used internally for user generated content. The
        /// maximum number of elements is 100. The maximum length is 8192 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keywords")]
        public virtual System.Collections.Generic.IList<string> Keywords { get; set; }

        /// <summary>
        /// The original mime-type of ItemContent.content in the source repository. The maximum length is 256
        /// characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>
        /// The type of the item. This should correspond to the name of an object definition in the schema registered
        /// for the data source. For example, if the schema for the data source contains an object definition with name
        /// 'document', then item indexing requests for objects of that type should set objectType to 'document'. The
        /// maximum length is 256 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectType")]
        public virtual string ObjectType { get; set; }

        /// <summary>Additional search quality metadata of the item</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchQualityMetadata")]
        public virtual SearchQualityMetadata SearchQualityMetadata { get; set; }

        /// <summary>
        /// Link to the source repository serving the data. Seach results apply this link to the title. Whitespace or
        /// special characters may cause Cloud Seach result links to trigger a redirect notice; to avoid this, encode
        /// the URL. The maximum length is 2048 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceRepositoryUrl")]
        public virtual string SourceRepositoryUrl { get; set; }

        /// <summary>
        /// The title of the item. If given, this will be the displayed title of the Search result. The maximum length
        /// is 2048 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The time when the item was last modified in the source repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This contains item's status and any errors.</summary>
    public class ItemStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Status code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Error details in case the item is in ERROR state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processingErrors")]
        public virtual System.Collections.Generic.IList<ProcessingError> ProcessingErrors { get; set; }

        /// <summary>Repository error reported by connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repositoryErrors")]
        public virtual System.Collections.Generic.IList<RepositoryError> RepositoryErrors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Available structured data fields for the item.</summary>
    public class ItemStructuredData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Hashing value provided by the API caller. This can be used with the items.push method to calculate modified
        /// state. The maximum length is 2048 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hash")]
        public virtual string Hash { get; set; }

        /// <summary>
        /// The structured data object that should conform to a registered object definition in the schema for the data
        /// source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("object")]
        public virtual StructuredDataObject Object__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class KeyValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Formatted text supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bottomLabel")]
        public virtual string BottomLabel { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("button")]
        public virtual Button Button { get; set; }

        /// <summary>Formatted text supported and always required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("contentMultiline")]
        public virtual System.Nullable<bool> ContentMultiline { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("endIcon")]
        public virtual IconImage EndIcon { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("icon")]
        public virtual string Icon { get; set; }

        /// <summary>The alternative text of this icon_url which will be used for accessibility.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconAltText")]
        public virtual string IconAltText { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("iconUrl")]
        public virtual string IconUrl { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("imageStyle")]
        public virtual string ImageStyle { get; set; }

        /// <summary>Only the top/bottom label + content region is clickable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual OnClick OnClick { get; set; }

        /// <summary>The optional icon to display before the text content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIcon")]
        public virtual IconImage StartIcon { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("switchWidget")]
        public virtual SwitchWidget SwitchWidget { get; set; }

        /// <summary>Formatted text supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topLabel")]
        public virtual string TopLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The language configuration for the session.</summary>
    public class LanguageConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The spoken language(s) in BCP47 language code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spokenLanguages")]
        public virtual System.Collections.Generic.IList<string> SpokenLanguages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LdapGroupProto : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("groupName")]
        public virtual string GroupName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LdapUserProto : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("userName")]
        public virtual string UserName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The original UploadMetadata that this DriveMetadata was converted from.</summary>
    public class LegacyUploadMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A unique ID generated from legacy UploadMetadata. This is used for interopping URLs after uploading blob to
        /// shared drive. Links in Classic might break without this. go/drive-file-attachment-interop-from-dynamite.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("legacyUniqueId")]
        public virtual string LegacyUniqueId { get; set; }

        /// <summary>
        /// The blob in this UploadMetadata has been uploaded to shared drive. This UploadMetadata is no longer attached
        /// to a message. go/shared-drive-data-migration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadMetadata")]
        public virtual UploadMetadata UploadMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Link metadata, for LINK segments. Anchor text should be stored in the "text" field of the Segment, which can
    /// also serve as a fallback.
    /// </summary>
    public class LinkData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An Attachment represents the structured entity to which we are linking. It contains an Embed
        /// (apps/tacotown/proto/embeds/embed_client.proto) with fields specific to the appropriate type of linked
        /// entity. For example, if we are linking to a photo album, the Embed may include the album ID and gaia ID of
        /// the creator. Clients that understand the Embed type within the Attachment may construct and/or decorate
        /// their link appropriately e.g. to make use of type-specific functionality or first-party integrations. The
        /// link_target and (if appropriate) display_url fields must still be set even when an Attachment is present, so
        /// that clients who do not know how to interpret the Attachment can fall back to those fields, and render the
        /// Segment as an ordinary web link. N.B. Even when an Attachment is present, the intention of a "LINK" Segment
        /// is for the Segment to be presented inline with the rest of the text of a post or comment, with a clickable
        /// link or other UI suitable for inlining (though the client may modify the UI based on Attachment data, e.g.
        /// to add appropriate hovers, icons, etc.). When an entity is intended to be rendered separately from the main
        /// body of the post/comment, a separate Attachment proto can be added outside the set of Segments. N.B. Within
        /// the Attachment, fields of EmbedClientItem have their own visibility annotations, which should be enforced
        /// separately from Segment visibility annotations. See: apps/tacotown/proto/embeds/embed_annotations.proto
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachment")]
        public virtual SocialCommonAttachmentAttachment Attachment { get; set; }

        /// <summary>
        /// The hint to use when rendering the associated attachment. Ignored if there is no associated attachment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachmentRenderHint")]
        public virtual string AttachmentRenderHint { get; set; }

        /// <summary>
        /// If we wish to show the user a different (e.g. shortened) version of the URL for display purposes, then that
        /// version should be set here. If this field isn't set, link_target will be used for both purposes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayUrl")]
        public virtual string DisplayUrl { get; set; }

        /// <summary>
        /// link_target is the URL to navigate to when clicked. This could be the original URL, or a URL signed by the
        /// GWS URL signing service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkTarget")]
        public virtual string LinkTarget { get; set; }

        /// <summary>
        /// LinkType is an optional field that provides additional information regarding link target. For example, link
        /// type can be identified as the SELF_LINK when the request was executed from the same link as the link target.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkType")]
        public virtual string LinkType { get; set; }

        /// <summary>
        /// Title is an optional field that provides a short string that describes the link or its destination. User
        /// interfaces often use title as a tooltip or for accessibility purposes. However, they are of course free to
        /// present this data in any form. This field is plain text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListDataSourceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<DataSource> Sources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListItemNamesForUnmappedIdentityResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("itemNames")]
        public virtual System.Collections.Generic.IList<string> ItemNames { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListItemsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Item> Items { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
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

    /// <summary>List sources response.</summary>
    public class ListQuerySourcesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<QuerySource> Sources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListSearchApplicationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("searchApplications")]
        public virtual System.Collections.Generic.IList<SearchApplication> SearchApplications { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListUnmappedIdentitiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("unmappedIdentities")]
        public virtual System.Collections.Generic.IList<UnmappedIdentity> UnmappedIdentities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Matched range of a snippet [start, end).</summary>
    public class MatchRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>End of the match in the snippet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("end")]
        public virtual System.Nullable<int> End { get; set; }

        /// <summary>Starting position of the match in the snippet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("start")]
        public virtual System.Nullable<int> Start { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An entity from the MDB namespace that is to be interpreted as a group. If using this for authorization, you
    /// should do an exact match of the peer role against group_name or any of the names in the Chubby expansion of the
    /// MDB group named group_name.
    /// </summary>
    public class MdbGroupProto : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("groupName")]
        public virtual string GroupName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An entity from the MDB namespace that is to be interpreted as a user. If using this for authorization, you
    /// should only do an exact match on the peer role against user_name.
    /// </summary>
    public class MdbUserProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Do not set this field. Contact credentials-eng@ if you believe you absolutely need to use it. This is the
        /// @prod.google.com Gaia ID that corresponds to the MDB user, see go/authn-merge for details. This field may
        /// always be safely ignored when performing an authorization check.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gaiaId")]
        public virtual System.Nullable<long> GaiaId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userName")]
        public virtual string UserName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Media resource.</summary>
    public class Media : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the media resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    ///  A meeting space is a persistent object that is the context for one or more calls. The meeting space is what
    /// makes users find each other when they want to meet and to find shared resources. With two exceptions, all the
    /// fields in the meeting space resource are visible publicly to any client, even anonymous users. The exceptions
    /// are that * The call_info field is only visible to clients that have a device (as indicated by the meeting token)
    /// in the JOINED or HIDDEN state. * The meeting_alias field will only be set for users who are in the same domain
    /// as the meeting space. The meeting space resource (outside call_info) should only contain information necessary
    /// to join a call in the meeting space, and not any other metadata about the meeting space, such as what
    /// organization it belongs to or things related to ongoing calls.
    /// </summary>
    public class MeetingSpace : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Which number classes are accepted by this meeting at the moment? When there is no ongoing conference, this
        /// field may change independent of the version number of the MeetingSpace. When a conference starts, this field
        /// will be locked to the value at that time, and then will be unlocked again at the end of the conference.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceptedNumberClass")]
        public virtual System.Collections.Generic.IList<string> AcceptedNumberClass { get; set; }

        /// <summary>Broadcast access information for this meeting space.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("broadcastAccess")]
        public virtual BroadcastAccess BroadcastAccess { get; set; }

        /// <summary>
        /// Information relevant to an ongoing conference. This field will be set in responses if the client requesting
        /// the meeting space has a device in one of the JOINED, HIDDEN, or MISSING_PREREQUISITES states. The field will
        /// also be set without a created device if the client requesting the meeting space is eligible to directly
        /// create a device in the JOINED state without knocking, eg a same-domain joiner. Can also only be updated by
        /// clients with a device in the JOINED state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callInfo")]
        public virtual CallInfo CallInfo { get; set; }

        /// <summary>
        /// The interop gateway access information for the meeting space. A gateway access can be used when joining
        /// conferences from non-Google equipment through an interop gateway.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gatewayAccess")]
        public virtual GatewayAccess GatewayAccess { get; set; }

        /// <summary>The SIP based access methods that can be used to join the conference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gatewaySipAccess")]
        public virtual System.Collections.Generic.IList<GatewaySipAccess> GatewaySipAccess { get; set; }

        /// <summary>
        /// An optional alias for the meeting space. The alias can in some cases be resolved to the meeting space,
        /// similar to the meeting code. The limitation is that the user needs to be in the same meeting domain as the
        /// meeting space.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meetingAlias")]
        public virtual string MeetingAlias { get; set; }

        /// <summary>
        /// A meeting code is a globally unique code which points to a meeting space. Note: Meeting codes may be
        /// regenerated, which will cause old meeting codes to become invalid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meetingCode")]
        public virtual string MeetingCode { get; set; }

        /// <summary>
        /// A unique server-generated ID for the meeting space. This is the resource name of the meeting space resource
        /// and has the form `spaces/`, where is a sequence of characters in the [base64url
        /// set](https://tools.ietf.org/html/rfc4648#section-5), without any `=` characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meetingSpaceId")]
        public virtual string MeetingSpaceId { get; set; }

        /// <summary>A URL to identify and access the meeting space. Output only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meetingUrl")]
        public virtual string MeetingUrl { get; set; }

        /// <summary>
        /// Output only. A URL that clients (e.g. Calendar) can use to show the web page with all join methods available
        /// for this meeting space. This link is also used in iOS universal links and Android intents, used for opening
        /// the "More ways to join" view in the Meet mobile apps. Example:
        /// https://tel.meet/mee-ting-cod?pin=1234567891011 Here, "pin" is the universal phone PIN. We include it
        /// explicitly to better support the offline case on the mobile. This is set when the meeting space has either a
        /// universal PIN or an interop PIN and clients who can show a "more ways to join" button should show it
        /// whenever this field is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moreJoinUrl")]
        public virtual string MoreJoinUrl { get; set; }

        /// <summary>All regional phone access methods for this meeting space. Can be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneAccess")]
        public virtual System.Collections.Generic.IList<PhoneAccess> PhoneAccess { get; set; }

        /// <summary>Settings of the meeting space.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settings")]
        public virtual Settings Settings { get; set; }

        /// <summary>A universal phone access method for this meeting space. Can be unset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("universalPhoneAccess")]
        public virtual UniversalPhoneAccess UniversalPhoneAccess { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Member : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("roster")]
        public virtual Roster Roster { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual User User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Eventually this can be updated to a oneOf User, Space (for nested spaces), Bots or Service, as and when these
    /// use cases come up.
    /// </summary>
    public class MemberId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unique, immutable ID of the Roster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rosterId")]
        public virtual RosterId RosterId { get; set; }

        /// <summary>Unique, immutable ID of the User.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual UserId UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class MembershipChangeEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This should only be set when MembershipChange type is LEAVE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leaveReason")]
        public virtual string LeaveReason { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("participantId")]
        public virtual System.Collections.Generic.IList<StoredParticipantId> ParticipantId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotation metadata to display system messages for membership changes.</summary>
    public class MembershipChangedMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("affectedMemberProfiles")]
        public virtual System.Collections.Generic.IList<Member> AffectedMemberProfiles { get; set; }

        /// <summary>List of users and rosters whose membership status changed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("affectedMembers")]
        public virtual System.Collections.Generic.IList<MemberId> AffectedMembers { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("affectedMemberships")]
        public virtual System.Collections.Generic.IList<AffectedMembership> AffectedMemberships { get; set; }

        /// <summary>The user whose action triggered this system message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initiator")]
        public virtual UserId Initiator { get; set; }

        /// <summary>
        /// Complete member profiles, when ListTopicsRequest FetchOptions.USER is set. Otherwise, only the id will be
        /// filled in.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initiatorProfile")]
        public virtual User InitiatorProfile { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This is deprecated and please use SelectionControl by setting type to DROPDOWN.</summary>
    public class Menu : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<MenuItem> Items { get; set; }

        /// <summary>Label used to be displayed ahead of the menu. It is optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>The name of the text field which is will be used in FormInput.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// If specified, form is submitted when selection changed. If not specified, developer will need to specify a
        /// separate button.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onChange")]
        public virtual FormAction OnChange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class MenuItem : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("selected")]
        public virtual System.Nullable<bool> Selected { get; set; }

        /// <summary>The text to be displayed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>
        /// The value associated with this item which will be sent back to app scripts. Client should use as a form
        /// input value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message posted to a Space.</summary>
    public class Message : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Annotations parsed and extracted from the text body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IList<Annotation> Annotations { get; set; }

        /// <summary>Custom display profile info for apps. Leave the field empty for real users.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appProfile")]
        public virtual AppsDynamiteSharedAppProfile AppProfile { get; set; }

        /// <summary>Attachments parsed from incoming webhooks</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachments")]
        public virtual System.Collections.Generic.IList<Attachment> Attachments { get; set; }

        /// <summary>Lightweight message attributes which values are calculated and set in the servers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual MessageAttributes Attributes { get; set; }

        /// <summary>Responses from bots indicating if extra auth/config is needed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("botResponses")]
        public virtual System.Collections.Generic.IList<BotResponse> BotResponses { get; set; }

        /// <summary>
        /// Communal labels associated with a message. These exist on the message itself regardless of which user
        /// fetches them. Order of entries is arbitrary and will not list duplicates of the same label_id. See
        /// go/chat-labels-design for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("communalLabels")]
        public virtual System.Collections.Generic.IList<CommunalLabelTag> CommunalLabels { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("contentReportSummary")]
        public virtual ContentReportSummary ContentReportSummary { get; set; }

        /// <summary>Time when the Message was posted in microseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual System.Nullable<long> CreateTime { get; set; }

        /// <summary>
        /// ID of the User who posted the Message. This includes information to identify if this was posted by an App on
        /// behalf of a user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creatorId")]
        public virtual UserId CreatorId { get; set; }

        /// <summary>
        /// Indicates who can delete the message. This field is set on the read path (e.g. ListTopics) but doesn’t have
        /// any effect on the write path (e.g. CreateMessageRequest).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletableBy")]
        public virtual string DeletableBy { get; set; }

        /// <summary>
        /// Time when the Message was deleted in microseconds. This field is set to nonzero value only for Messages
        /// deleted globally.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual System.Nullable<long> DeleteTime { get; set; }

        /// <summary>
        /// Time when the Message was per-user deleted by the message requester in microseconds. This field is set to
        /// nonzero value only for Message per-user deleted by the requester.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTimeForRequester")]
        public virtual System.Nullable<long> DeleteTimeForRequester { get; set; }

        /// <summary>
        /// Was this message deleted by Vault (Only used for Vault support) This is false if message is live or message
        /// was deleted by user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletedByVault")]
        public virtual System.Nullable<bool> DeletedByVault { get; set; }

        /// <summary>
        /// Data Loss Prevention scan information for this message. Messages are evaluated in the backend on create
        /// message/topic and edit message actions. DEPRECATED: use dlp_scan_summary instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dlpScanOutcome")]
        public virtual string DlpScanOutcome { get; set; }

        /// <summary>
        /// Data Loss Prevention scan information for this message. Messages are evaluated in the backend on create
        /// message/topic and edit message actions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dlpScanSummary")]
        public virtual DlpScanSummary DlpScanSummary { get; set; }

        /// <summary>
        /// Indicates who can edit the message. This field is set on the read path (e.g. ListTopics) but doesn’t have
        /// any effect on the write path (e.g. CreateMessageRequest).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("editableBy")]
        public virtual string EditableBy { get; set; }

        /// <summary>
        /// A plain-text description of the attachment, used when clients cannot display formatted attachment (e.g.
        /// mobile push notifications).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fallbackText")]
        public virtual string FallbackText { get; set; }

        /// <summary>ID of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual MessageId Id { get; set; }

        /// <summary>
        /// Whether the message is content purged. Content purged messages contain only data required for tombstone (see
        /// go/chat-infinite-tombstone). This field is only used by Vault to display tombstone and should only be set to
        /// true if the message is a tombstone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isContentPurged")]
        public virtual System.Nullable<bool> IsContentPurged { get; set; }

        /// <summary>
        /// Output only. Indicates if the message is an inline reply. Set to true only if the message's ParentPath is
        /// non-NULL. Currently, only inline replies have non-NULL ParentPath. See go/chat-be-inline-reply-indicator.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isInlineReply")]
        public virtual System.Nullable<bool> IsInlineReply { get; set; }

        /// <summary>If the message was edited by a user, timestamp of the last edit, in microseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastEditTime")]
        public virtual System.Nullable<long> LastEditTime { get; set; }

        /// <summary>Time when the Message text was last updated in microseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateTime")]
        public virtual System.Nullable<long> LastUpdateTime { get; set; }

        /// <summary>A unique id specified on the client side.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localId")]
        public virtual string LocalId { get; set; }

        /// <summary>
        /// An optional payload (restricted to 1P applications) that will be stored with this message. This can only be
        /// set by the 1P API and should be used to deliver additional data such a 1P sync version, 1P entity ID to the
        /// client for more advanced functionality [Eg. inform Group Tasks tab of new version while linking, fetch
        /// &amp;amp; render a live Task/Meet call tile].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageIntegrationPayload")]
        public virtual AppsDynamiteSharedMessageIntegrationPayload MessageIntegrationPayload { get; set; }

        /// <summary>Where the message was posted from</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageOrigin")]
        public virtual string MessageOrigin { get; set; }

        /// <summary>
        /// State of the message, indicating whether the message is visible to all members in the group or is only
        /// visible to the sender only, or the private_message_viewer if it is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageState")]
        public virtual string MessageState { get; set; }

        /// <summary>Indicates if this message contains any suggestions that were provided by any Apps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originAppSuggestions")]
        public virtual System.Collections.Generic.IList<AppsDynamiteSharedOriginAppSuggestion> OriginAppSuggestions { get; set; }

        /// <summary>
        /// Personal labels associated with a message for the viewing user. Order of entries is arbitrary and will not
        /// list duplicates of the same label_id. See go/chat-labels-design for details. NOTE: This will be unpopulated
        /// in the case of SpaceChangelog events.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personalLabels")]
        public virtual System.Collections.Generic.IList<PersonalLabelTag> PersonalLabels { get; set; }

        /// <summary>
        /// A list of per-user private information. This is deprecated, because we no longer plan to support partially
        /// private messages or private messages for multiple users. The message_state and private_message_viewer fields
        /// should be sufficient for this infrastructure.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateMessageInfos")]
        public virtual System.Collections.Generic.IList<PrivateMessageInfo> PrivateMessageInfos { get; set; }

        /// <summary>
        /// Should only be set if the Message State is PRIVATE. If set, the message content is only visible to this user
        /// (and any apps associated with the message), as well as the message creator. If unset, a private message is
        /// visible to the message creator only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateMessageViewer")]
        public virtual UserId PrivateMessageViewer { get; set; }

        /// <summary>
        /// Contains additional (currently Hangouts Classic only) properties applicable to this message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("props")]
        public virtual MessageProps Props { get; set; }

        /// <summary>
        /// Output only. Whether this message has been quoted by another message or not. Used by clients to handle
        /// message edit flows for messages that have been quoted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotedByState")]
        public virtual string QuotedByState { get; set; }

        /// <summary>Output only. Metadata for a message that is quoted by this message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotedMessageMetadata")]
        public virtual QuotedMessageMetadata QuotedMessageMetadata { get; set; }

        /// <summary>
        /// A list of user reactions to this message. Ordered by the timestamp of the first reaction, ascending (oldest
        /// to newest).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reactions")]
        public virtual System.Collections.Generic.IList<AppsDynamiteSharedReaction> Reactions { get; set; }

        /// <summary>Output only. Details of content reports. Set only when the request asks for it.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reports")]
        public virtual System.Collections.Generic.IList<ContentReport> Reports { get; set; }

        /// <summary>The retention settings of the message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retentionSettings")]
        public virtual AppsDynamiteSharedRetentionSettings RetentionSettings { get; set; }

        /// <summary>
        /// A client-specified string that can be used to uniquely identify a message in a space, in lieu of
        /// `id.message_id`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryMessageKey")]
        public virtual string SecondaryMessageKey { get; set; }

        /// <summary>Plaintext body of the Message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textBody")]
        public virtual string TextBody { get; set; }

        /// <summary>Information for the stoning of a Message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tombstoneMetadata")]
        public virtual TombstoneMetadata TombstoneMetadata { get; set; }

        /// <summary>
        /// ID of the User who last updated (created/edited/deleted) the Message. This includes information to identify
        /// if this was updated by an App on behalf of a user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updaterId")]
        public virtual UserId UpdaterId { get; set; }

        /// <summary>
        /// UploadMetadata b/36864213 is an ongoing effort to move UploadMetadata out of annotations field and save it
        /// to upload_metadata field only. After the migration, UploadMetadata will only be saved in this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadMetadata")]
        public virtual System.Collections.Generic.IList<UploadMetadata> UploadMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Stores tombstone message attributes: go/tombstone-message-attributes-overview</summary>
    public class MessageAttributes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If true: message is a tombstone in the client. Default false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isTombstone")]
        public virtual System.Nullable<bool> IsTombstone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Primary key for Message resource.</summary>
    public class MessageId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Opaque, server-assigned ID of the Message. While this ID is guaranteed to be unique within the Space, it's
        /// not guaranteed to be globally unique.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageId")]
        public virtual string MessageIdValue { get; set; }

        /// <summary>ID of the Message's immediate parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentId")]
        public virtual MessageParentId ParentId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class MessageInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The content of a matching message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual Message Message { get; set; }

        /// <summary>Searcher's membership state in the space where the message is posted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searcherMembershipState")]
        public virtual string SearcherMembershipState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Primary key identifying Message resource's immediate parent. For top-level Messages, either topic_id or chat_id
    /// is populated. For replies, message_id is populated with the topic Message's ID.
    /// </summary>
    public class MessageParentId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the Topic this Message is posted to. NEXT TAG : 5</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicId")]
        public virtual TopicId TopicId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Container for storing properties applicable to messages. For now (until storage consolidation is complete), it
    /// will only be used for babel props. In the future it could be used to house Dynamite properties for
    /// experimenting/rapid prototyping.
    /// </summary>
    public class MessageProps : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("babelProps")]
        public virtual BabelMessageProps BabelProps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of a matched search result.</summary>
    public class Metadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The creation time for this document or object in the search result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Options that specify how to display a structured data search result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayOptions")]
        public virtual ResultDisplayMetadata DisplayOptions { get; set; }

        /// <summary>Indexed fields in structured data, returned as a generic named property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<NamedProperty> Fields { get; set; }

        /// <summary>Mime type of the search result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>Object type of the search result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectType")]
        public virtual string ObjectType { get; set; }

        /// <summary>Owner (usually creator) of the document or object of the search result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("owner")]
        public virtual Person Owner { get; set; }

        /// <summary>The named source for the result, such as Gmail.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual Source Source { get; set; }

        /// <summary>The thumbnail URL of the result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnailUrl")]
        public virtual string ThumbnailUrl { get; set; }

        /// <summary>
        /// The last modified date for the object in the search result. If not set in the item, the value returned here
        /// is empty. When `updateTime` is used for calculating freshness and is not set, this value defaults to 2 years
        /// from the current time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A metaline is a list of properties that are displayed along with the search result to provide context.
    /// </summary>
    public class Metaline : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of displayed properties for the metaline. The maximum number of properties is 5.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<DisplayedProperty> Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A person's name.</summary>
    public class Name : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The read-only display name formatted according to the locale specified by the viewer's account or the
        /// `Accept-Language` HTTP header.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A typed name-value pair for structured data. The type of the value should be the same as the registered type for
    /// the `name` property in the object definition of `objectType`.
    /// </summary>
    public class NamedProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("booleanValue")]
        public virtual System.Nullable<bool> BooleanValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("dateValues")]
        public virtual DateValues DateValues { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("doubleValues")]
        public virtual DoubleValues DoubleValues { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("enumValues")]
        public virtual EnumValues EnumValues { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("htmlValues")]
        public virtual HtmlValues HtmlValues { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("integerValues")]
        public virtual IntegerValues IntegerValues { get; set; }

        /// <summary>
        /// The name of the property. This name should correspond to the name of the property that was registered for
        /// object definition in the schema. The maximum allowable length for this property is 256 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("objectValues")]
        public virtual ObjectValues ObjectValues { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("textValues")]
        public virtual TextValues TextValues { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("timestampValues")]
        public virtual TimestampValues TimestampValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents an OAuth consumer, a/k/a AuthSub target. These principals are identified by domain name (e.g.,
    /// example.com). Historically, Dasher domain GAIA group IDs have been used instead, but that doesn't work:
    /// http://go/tricky-gaia-ids
    /// </summary>
    public class OAuthConsumerProto : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The definition for an object within a data source.</summary>
    public class ObjectDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name for the object, which then defines its type. Item indexing requests should set the objectType field
        /// equal to this value. For example, if *name* is *Document*, then indexing requests for items of type Document
        /// should set objectType equal to *Document*. Each object definition must be uniquely named within a schema.
        /// The name must start with a letter and can only contain letters (A-Z, a-z) or numbers (0-9). The maximum
        /// length is 256 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The optional object-specific options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual ObjectOptions Options { get; set; }

        /// <summary>The property definitions for the object. The maximum number of elements is 1000.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyDefinitions")]
        public virtual System.Collections.Generic.IList<PropertyDefinition> PropertyDefinitions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The display options for an object.</summary>
    public class ObjectDisplayOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Defines the properties that are displayed in the metalines of the search results. The property values are
        /// displayed in the order given here. If a property holds multiple values, all of the values are displayed
        /// before the next properties. For this reason, it is a good practice to specify singular properties before
        /// repeated properties in this list. All of the properties must set is_returnable to true. The maximum number
        /// of metalines is 3.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metalines")]
        public virtual System.Collections.Generic.IList<Metaline> Metalines { get; set; }

        /// <summary>
        /// The user friendly label to display in the search result to indicate the type of the item. This is OPTIONAL;
        /// if not provided, an object label isn't displayed on the context line of the search results. The maximum
        /// length is 64 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectDisplayLabel")]
        public virtual string ObjectDisplayLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The options for an object.</summary>
    public class ObjectOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The options that determine how the object is displayed in the Cloud Search results page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayOptions")]
        public virtual ObjectDisplayOptions DisplayOptions { get; set; }

        /// <summary>The freshness options for an object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freshnessOptions")]
        public virtual FreshnessOptions FreshnessOptions { get; set; }

        /// <summary>
        /// Operators that can be used to filter suggestions. For Suggest API, only operators mentioned here will be
        /// honored in the FilterOptions. Only TEXT and ENUM operators are supported. NOTE: "objecttype", "type" and
        /// "mimetype" are already supported. This property is to configure schema specific operators. Even though this
        /// is an array, only one operator can be specified. This is an array for future extensibility. Operators
        /// mapping to multiple properties within the same object are not supported. If the operator spans across
        /// different object types, this option has to be set once for each object definition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestionFilteringOperators")]
        public virtual System.Collections.Generic.IList<string> SuggestionFilteringOperators { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The options for object properties.</summary>
    public class ObjectPropertyOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The properties of the sub-object. These properties represent a nested object. For example, if this property
        /// represents a postal address, the subobjectProperties might be named *street*, *city*, and *state*. The
        /// maximum number of elements is 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subobjectProperties")]
        public virtual System.Collections.Generic.IList<PropertyDefinition> SubobjectProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of object values.</summary>
    public class ObjectValues : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<StructuredDataObject> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class OnClick : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual FormAction Action { get; set; }

        /// <summary>
        /// This can be used as a short form for OpenLink with the default OpenAs and OnClose. It may be undeprecated if
        /// this proves to be handy for developers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual string Link { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("openLink")]
        public virtual OpenLink OpenLink { get; set; }

        /// <summary>
        /// An add-on triggers this action when the form action needs to open a link. This differs from the open_link
        /// above in that this needs to talk to server to get the link. Thus some preparation work is required for web
        /// client to do before the open link action response comes back.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openLinkAction")]
        public virtual FormAction OpenLinkAction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class OpenLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Next available ID: 5</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadIndicator")]
        public virtual string LoadIndicator { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("onClose")]
        public virtual string OnClose { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("openAs")]
        public virtual string OpenAs { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

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

    public class OtrChatMessageEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTimestampUsec")]
        public virtual System.Nullable<long> ExpirationTimestampUsec { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kansasRowId")]
        public virtual string KansasRowId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kansasVersionInfo")]
        public virtual string KansasVersionInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("messageOtrStatus")]
        public virtual string MessageOtrStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class OtrModificationEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("newOtrStatus")]
        public virtual string NewOtrStatus { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("newOtrToggle")]
        public virtual string NewOtrToggle { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("oldOtrStatus")]
        public virtual string OldOtrStatus { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("oldOtrToggle")]
        public virtual string OldOtrToggle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Developers register a client in Google API Console to get the deep-linking feature on Google+ posts or frames
    /// about their apps. The client data is stored in this proto.
    /// </summary>
    public class PackagingServiceClient : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Android app's package name to generate the deep-link URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidPackageName")]
        public virtual string AndroidPackageName { get; set; }

        /// <summary>iOS app's App Store ID to generate the App Store URL when app is not installed on device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosAppStoreId")]
        public virtual string IosAppStoreId { get; set; }

        /// <summary>iOS app's bundle ID to generate the deep-link URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosBundleId")]
        public virtual string IosBundleId { get; set; }

        /// <summary>Type of Google API Console client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information provided to clients so that they can show upgrade promos and warnings on call ending early (for
    /// non-paying users).
    /// </summary>
    public class PaygateInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Time when client should show message that the call is ending soon.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callEndingSoonWarningTime")]
        public virtual object CallEndingSoonWarningTime { get; set; }

        /// <summary>
        /// Time when the call will end if the user does not upgrade (after in-call upgrade support check has been
        /// implemented).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callEndingTime")]
        public virtual object CallEndingTime { get; set; }

        /// <summary>
        /// This boolean is used by clients to decide whether the user should be shown promos to upgrade.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("showUpgradePromos")]
        public virtual System.Nullable<bool> ShowUpgradePromos { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This field contains information about the person being suggested.</summary>
    public class PeopleSuggestion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Suggested person. All fields of the person object might not be populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("person")]
        public virtual Person Person { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Object to represent a person.</summary>
    public class Person : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The person's email addresses</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddresses")]
        public virtual System.Collections.Generic.IList<EmailAddress> EmailAddresses { get; set; }

        /// <summary>
        /// The resource name of the person to provide information about. See
        /// [`People.get`](https://developers.google.com/people/api/rest/v1/people/get) from the Google People API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Obfuscated ID of a person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("obfuscatedId")]
        public virtual string ObfuscatedId { get; set; }

        /// <summary>The person's name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personNames")]
        public virtual System.Collections.Generic.IList<Name> PersonNames { get; set; }

        /// <summary>The person's phone numbers</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumbers")]
        public virtual System.Collections.Generic.IList<PhoneNumber> PhoneNumbers { get; set; }

        /// <summary>
        /// A person's read-only photo. A picture shown next to the person's name to help others recognize the person in
        /// search results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("photos")]
        public virtual System.Collections.Generic.IList<Photo> Photos { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An individual instance (or "tag") of a label configured as a personal type that's associated with a message.
    /// </summary>
    public class PersonalLabelTag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A string ID representing the label. Possible ID values are documented at go/chat-labels-howto:ids. Examples:
        /// "^t" for "Starred", "^nu" for "Nudged".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelId")]
        public virtual string LabelId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Phone access contains information required to dial into a conference using a regional phone number and a PIN
    /// that is specific to that phone number.
    /// </summary>
    public class PhoneAccess : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The phone number to dial for this meeting space in INTERNATIONAL format. Full phone number with a leading
        /// '+' character and whitespace separations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedPhoneNumber")]
        public virtual string FormattedPhoneNumber { get; set; }

        /// <summary>
        /// The BCP 47/LDML language code for the language associated with this phone access. To be parsed by the i18n
        /// LanguageCode utility. Examples: "es-419" for Latin American Spanish, "fr-CA" for Canadian French.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// The phone number to dial for this meeting space in E.164 format. Full phone number with a leading '+'
        /// character.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; }

        /// <summary>
        /// The PIN that users must enter after dialing the given number. The PIN consists of only decimal digits and
        /// the length may vary.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pin")]
        public virtual string Pin { get; set; }

        /// <summary>
        /// The CLDR/ISO 3166 region code for the country associated with this phone access. To be parsed by the i18n
        /// RegionCode utility. Example: "SE" for Sweden.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A person's Phone Number</summary>
    public class PhoneNumber : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The phone number of the person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumberValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A person's photo.</summary>
    public class Photo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URL of the photo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PinnedItemId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifier for a Drive file (e.g. Docs, Sheets, Slides).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveId")]
        public virtual string DriveId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PollItemsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of connector making this call. Format: datasources/{source_id}/connectors/{ID}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectorName")]
        public virtual string ConnectorName { get; set; }

        /// <summary>Common debug options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugOptions")]
        public virtual DebugOptions DebugOptions { get; set; }

        /// <summary>Maximum number of items to return. The maximum value is 100 and the default value is 20.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limit")]
        public virtual System.Nullable<int> Limit { get; set; }

        /// <summary>
        /// Queue name to fetch items from. If unspecified, PollItems will fetch from 'default' queue. The maximum
        /// length is 100 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queue")]
        public virtual string Queue { get; set; }

        /// <summary>Limit the items polled to the ones with these statuses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusCodes")]
        public virtual System.Collections.Generic.IList<string> StatusCodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PollItemsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Set of items from the queue available for connector to process. These items have the following subset of
        /// fields populated: version metadata.hash structured_data.hash content.hash payload status queue
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Item> Items { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>See http://s/?fileprint=//depot/google3/security/authentication/postini/auth_token.proto</summary>
    public class PostiniUserProto : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("postiniUserId")]
        public virtual System.Nullable<long> PostiniUserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Presenter contains information about which device is currently presenting as well as which device requested the
    /// presenter to be set.
    /// </summary>
    public class Presenter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The device resource name of the device which requested the current presenter to be set. This field can not
        /// be modified by clients.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("byDeviceId")]
        public virtual string ByDeviceId { get; set; }

        /// <summary>The device resource names of other devices which can control the current presentation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("copresenterDeviceIds")]
        public virtual System.Collections.Generic.IList<string> CopresenterDeviceIds { get; set; }

        /// <summary>The device resource name of the currently presenting device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("presenterDeviceId")]
        public virtual string PresenterDeviceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Reference to a user, group, or domain.</summary>
    public class Principal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This principal is a group identified using an external identity. The name field must specify the group
        /// resource name with this format: identitysources/{source_id}/groups/{ID}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupResourceName")]
        public virtual string GroupResourceName { get; set; }

        /// <summary>This principal is a Google Workspace user, group or domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gsuitePrincipal")]
        public virtual GSuitePrincipal GsuitePrincipal { get; set; }

        /// <summary>
        /// This principal is a user identified using an external identity. The name field must specify the user
        /// resource name with this format: identitysources/{source_id}/users/{ID}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userResourceName")]
        public virtual string UserResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Principal represents something to which permissions are assigned, often but not always a user or group of some
    /// kind. It is most appropriate for use in ACLs and authorization checks. Callers should prefer to use the wrapper
    /// classes in google3/security/credentials/public/principal.h
    /// google3/java/com/google/security/credentials/Principal.java google3/security/credentials/go/principal.go unless
    /// direct proto access is essential. If you update this protocol buffer, please update the wrapper classes as well.
    /// </summary>
    public class PrincipalProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>scope = ALL_AUTHENTICATED_USERS</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allAuthenticatedUsers")]
        public virtual AllAuthenticatedUsersProto AllAuthenticatedUsers { get; set; }

        /// <summary>scope = CAP_TOKEN_HOLDER</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capTokenHolder")]
        public virtual CapTokenHolderProto CapTokenHolder { get; set; }

        /// <summary>scope = CHAT</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chat")]
        public virtual ChatProto Chat { get; set; }

        /// <summary>scope = CIRCLE</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("circle")]
        public virtual CircleProto Circle { get; set; }

        /// <summary>scope = CLOUD_PRINCIPAL</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudPrincipal")]
        public virtual CloudPrincipalProto CloudPrincipal { get; set; }

        /// <summary>scope = CONTACT_GROUP</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactGroup")]
        public virtual ContactGroupProto ContactGroup { get; set; }

        /// <summary>scope = EMAIL_OWNER</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailOwner")]
        public virtual EmailOwnerProto EmailOwner { get; set; }

        /// <summary>scope = EVENT</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("event")]
        public virtual EventProto Event__ { get; set; }

        /// <summary>scope = GAIA_GROUP</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gaiaGroup")]
        public virtual GaiaGroupProto GaiaGroup { get; set; }

        /// <summary>scope = GAIA_USER</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gaiaUser")]
        public virtual GaiaUserProto GaiaUser { get; set; }

        /// <summary>scope = HOST</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual HostProto Host { get; set; }

        /// <summary>scope = LDAP_GROUP</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ldapGroup")]
        public virtual LdapGroupProto LdapGroup { get; set; }

        /// <summary>scope = LDAP_USER</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ldapUser")]
        public virtual LdapUserProto LdapUser { get; set; }

        /// <summary>scope = MDB_GROUP</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mdbGroup")]
        public virtual MdbGroupProto MdbGroup { get; set; }

        /// <summary>scope = MDB_USER</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mdbUser")]
        public virtual MdbUserProto MdbUser { get; set; }

        /// <summary>scope = OAUTH_CONSUMER;</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauthConsumer")]
        public virtual OAuthConsumerProto OauthConsumer { get; set; }

        /// <summary>scope = POSTINI_USER</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postiniUser")]
        public virtual PostiniUserProto PostiniUser { get; set; }

        /// <summary>scope = RBAC_ROLE</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rbacRole")]
        public virtual RbacRoleProto RbacRole { get; set; }

        /// <summary>scope = RBAC_SUBJECT</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rbacSubject")]
        public virtual RbacSubjectProto RbacSubject { get; set; }

        /// <summary>scope = RESOURCE_ROLE</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceRole")]
        public virtual ResourceRoleProto ResourceRole { get; set; }

        /// <summary>This is only optional because required enums cannot be extended. Currently required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>scope = SIGNING_KEY_POSSESSOR</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signingKeyPossessor")]
        public virtual SigningKeyPossessorProto SigningKeyPossessor { get; set; }

        /// <summary>scope = SIMPLE_SECRET_HOLDER</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("simpleSecretHolder")]
        public virtual SimpleSecretHolderProto SimpleSecretHolder { get; set; }

        /// <summary>scope = SOCIAL_GRAPH_NODE</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("socialGraphNode")]
        public virtual SocialGraphNodeProto SocialGraphNode { get; set; }

        /// <summary>scope = SQUARE</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("square")]
        public virtual SquareProto Square { get; set; }

        /// <summary>scope = YOUTUBE_USER</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("youtubeUser")]
        public virtual YoutubeUserProto YoutubeUser { get; set; }

        /// <summary>scope = ZWIEBACK_SESSION</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zwiebackSession")]
        public virtual ZwiebackSessionProto ZwiebackSession { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Private message information specific to a given user.</summary>
    public class PrivateMessageInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Annotations private to {@code userId}.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IList<Annotation> Annotations { get; set; }

        /// <summary>Attachments private to {@code userId}.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachments")]
        public virtual System.Collections.Generic.IList<Attachment> Attachments { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("contextualAddOnMarkup")]
        public virtual System.Collections.Generic.IList<GoogleChatV1ContextualAddOnMarkup> ContextualAddOnMarkup { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("gsuiteIntegrationMetadata")]
        public virtual System.Collections.Generic.IList<GsuiteIntegrationMetadata> GsuiteIntegrationMetadata { get; set; }

        /// <summary>
        /// Text private to {@code user_id}. Initial restriction: Only one of public text or private text is rendered on
        /// the client. So if public text is set, private text is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>Required. The elements in this struct are visible to this user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual UserId UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ProcessingError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Error code indicating the nature of the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>The description of the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>
        /// In case the item fields are invalid, this field contains the details about the validation errors.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldViolations")]
        public virtual System.Collections.Generic.IList<FieldViolation> FieldViolations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The definition of a property within an object.</summary>
    public class PropertyDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("booleanPropertyOptions")]
        public virtual BooleanPropertyOptions BooleanPropertyOptions { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("datePropertyOptions")]
        public virtual DatePropertyOptions DatePropertyOptions { get; set; }

        /// <summary>
        /// The options that determine how the property is displayed in the Cloud Search results page if it's specified
        /// to be displayed in the object's display options.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayOptions")]
        public virtual PropertyDisplayOptions DisplayOptions { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("doublePropertyOptions")]
        public virtual DoublePropertyOptions DoublePropertyOptions { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("enumPropertyOptions")]
        public virtual EnumPropertyOptions EnumPropertyOptions { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("htmlPropertyOptions")]
        public virtual HtmlPropertyOptions HtmlPropertyOptions { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("integerPropertyOptions")]
        public virtual IntegerPropertyOptions IntegerPropertyOptions { get; set; }

        /// <summary>
        /// Indicates that the property can be used for generating facets. Cannot be true for properties whose type is
        /// object. IsReturnable must be true to set this option. Only supported for boolean, enum, and text properties.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isFacetable")]
        public virtual System.Nullable<bool> IsFacetable { get; set; }

        /// <summary>
        /// Indicates that multiple values are allowed for the property. For example, a document only has one
        /// description but can have multiple comments. Cannot be true for properties whose type is a boolean. If set to
        /// false, properties that contain more than one value cause the indexing request for that item to be rejected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRepeatable")]
        public virtual System.Nullable<bool> IsRepeatable { get; set; }

        /// <summary>
        /// Indicates that the property identifies data that should be returned in search results via the Query API. If
        /// set to *true*, indicates that Query API users can use matching property fields in results. However, storing
        /// fields requires more space allocation and uses more bandwidth for search queries, which impacts performance
        /// over large datasets. Set to *true* here only if the field is needed for search results. Cannot be true for
        /// properties whose type is an object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isReturnable")]
        public virtual System.Nullable<bool> IsReturnable { get; set; }

        /// <summary>
        /// Indicates that the property can be used for sorting. Cannot be true for properties that are repeatable.
        /// Cannot be true for properties whose type is object. IsReturnable must be true to set this option. Only
        /// supported for boolean, date, double, integer, and timestamp properties.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isSortable")]
        public virtual System.Nullable<bool> IsSortable { get; set; }

        /// <summary>Indicates that the property can be used for generating query suggestions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isSuggestable")]
        public virtual System.Nullable<bool> IsSuggestable { get; set; }

        /// <summary>
        /// Indicates that users can perform wildcard search for this property. Only supported for Text properties.
        /// IsReturnable must be true to set this option. In a given datasource maximum of 5 properties can be marked as
        /// is_wildcard_searchable. For more details, see [Define object
        /// properties](https://developers.google.com/cloud-search/docs/guides/schema-guide#properties)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isWildcardSearchable")]
        public virtual System.Nullable<bool> IsWildcardSearchable { get; set; }

        /// <summary>
        /// The name of the property. Item indexing requests sent to the Indexing API should set the property name equal
        /// to this value. For example, if name is *subject_line*, then indexing requests for document items with
        /// subject fields should set the name for that field equal to *subject_line*. Use the name as the identifier
        /// for the object property. Once registered as a property for an object, you cannot re-use this name for
        /// another property within that object. The name must start with a letter and can only contain letters (A-Z,
        /// a-z) or numbers (0-9). The maximum length is 256 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("objectPropertyOptions")]
        public virtual ObjectPropertyOptions ObjectPropertyOptions { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("textPropertyOptions")]
        public virtual TextPropertyOptions TextPropertyOptions { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("timestampPropertyOptions")]
        public virtual TimestampPropertyOptions TimestampPropertyOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The display options for a property.</summary>
    public class PropertyDisplayOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The user friendly label for the property that is used if the property is specified to be displayed in
        /// ObjectDisplayOptions. If provided, the display label is shown in front of the property values when the
        /// property is part of the object display options. For example, if the property value is '1', the value by
        /// itself may not be useful context for the user. If the display name given was 'priority', then the user sees
        /// 'priority : 1' in the search results which provides clear context to search users. This is OPTIONAL; if not
        /// given, only the property values are displayed. The maximum length is 64 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayLabel")]
        public virtual string DisplayLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This field records where the ItemScope was retrieved, if it was created via a web fetch.</summary>
    public class Provenance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Annotation blob from Annotation Service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationBlob")]
        public virtual string AnnotationBlob { get; set; }

        /// <summary>
        /// Canonical url of the retrieved_url, if one was resolved during retrieval, for example, if a rel="canonical"
        /// link tag was provided in the retrieved web page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalUrl")]
        public virtual string CanonicalUrl { get; set; }

        /// <summary>
        /// The url originally passed in the PRS request, which should be used to re-discover the content. Note that
        /// this URL may be a forwarding service or link shortener (bit.ly), so it should not be assumed to be
        /// canonical, but should be used for navigation back to the original source of the itemscope.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUrl")]
        public virtual string InputUrl { get; set; }

        /// <summary>
        /// Contains exact types as parsed, whether or not we recognized that type at parse time. If an itemscope is
        /// created by merging SchemaOrg markup and open graph markup then the first itemtype would be schemaorg type,
        /// the second would be open graph and so on. example: http://schema.org/VideoObject, og:video.movie Plain text;
        /// usually a URL
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemtype")]
        public virtual System.Collections.Generic.IList<string> Itemtype { get; set; }

        /// <summary>The server retrieved timestamp (in msec).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retrievedTimestampMsec")]
        public virtual System.Nullable<ulong> RetrievedTimestampMsec { get; set; }

        /// <summary>The final URL that was the actual source of the itemscope, after any redirects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retrievedUrl")]
        public virtual string RetrievedUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an item to be pushed to the indexing queue.</summary>
    public class PushItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Content hash of the item according to the repository. If specified, this is used to determine how to modify
        /// this item's status. Setting this field and the type field results in argument error. The maximum length is
        /// 2048 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentHash")]
        public virtual string ContentHash { get; set; }

        /// <summary>
        /// The metadata hash of the item according to the repository. If specified, this is used to determine how to
        /// modify this item's status. Setting this field and the type field results in argument error. The maximum
        /// length is 2048 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadataHash")]
        public virtual string MetadataHash { get; set; }

        /// <summary>
        /// Provides additional document state information for the connector, such as an alternate repository ID and
        /// other metadata. The maximum length is 8192 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual string Payload { get; set; }

        /// <summary>
        /// Queue to which this item belongs. The `default` queue is chosen if this field is not specified. The maximum
        /// length is 512 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queue")]
        public virtual string Queue { get; set; }

        /// <summary>
        /// Populate this field to store Connector or repository error details. This information is displayed in the
        /// Admin Console. This field may only be populated when the Type is REPOSITORY_ERROR.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repositoryError")]
        public virtual RepositoryError RepositoryError { get; set; }

        /// <summary>
        /// Structured data hash of the item according to the repository. If specified, this is used to determine how to
        /// modify this item's status. Setting this field and the type field results in argument error. The maximum
        /// length is 2048 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structuredDataHash")]
        public virtual string StructuredDataHash { get; set; }

        /// <summary>The type of the push operation that defines the push behavior.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PushItemRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of connector making this call. Format: datasources/{source_id}/connectors/{ID}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectorName")]
        public virtual string ConnectorName { get; set; }

        /// <summary>Common debug options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugOptions")]
        public virtual DebugOptions DebugOptions { get; set; }

        /// <summary>Item to push onto the queue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("item")]
        public virtual PushItem Item { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class QueryCountByStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>This represents the http status code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusCode")]
        public virtual System.Nullable<int> StatusCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class QueryInterpretation : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("interpretationType")]
        public virtual string InterpretationType { get; set; }

        /// <summary>
        /// The interpretation of the query used in search. For example, queries with natural language intent like
        /// "email from john" will be interpreted as "from:john source:mail". This field will not be filled when the
        /// reason is NOT_ENOUGH_RESULTS_FOUND_FOR_USER_QUERY.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interpretedQuery")]
        public virtual string InterpretedQuery { get; set; }

        /// <summary>
        /// The reason for interpretation of the query. This field will not be UNSPECIFIED if the interpretation type is
        /// not NONE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Default options to interpret user query.</summary>
    public class QueryInterpretationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Set this flag to disable supplemental results retrieval, setting a flag here will not retrieve supplemental
        /// results for queries associated with a given search application. If this flag is set to True, it will take
        /// precedence over the option set at Query level. For the default value of False, query level flag will set the
        /// correct interpretation for supplemental results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forceDisableSupplementalResults")]
        public virtual System.Nullable<bool> ForceDisableSupplementalResults { get; set; }

        /// <summary>
        /// Enable this flag to turn off all internal optimizations like natural language (NL) interpretation of
        /// queries, supplemental results retrieval, and usage of synonyms including custom ones. If this flag is set to
        /// True, it will take precedence over the option set at Query level. For the default value of False, query
        /// level flag will set the correct interpretation for verbatim mode.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forceVerbatimMode")]
        public virtual System.Nullable<bool> ForceVerbatimMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options to interpret user query.</summary>
    public class QueryInterpretationOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Flag to disable natural language (NL) interpretation of queries. Default is false, Set to true to disable
        /// natural language interpretation. NL interpretation only applies to predefined datasources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableNlInterpretation")]
        public virtual System.Nullable<bool> DisableNlInterpretation { get; set; }

        /// <summary>
        /// Use this flag to disable supplemental results for a query. Supplemental results setting chosen at
        /// SearchApplication level will take precedence if set to True.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableSupplementalResults")]
        public virtual System.Nullable<bool> DisableSupplementalResults { get; set; }

        /// <summary>
        /// Enable this flag to turn off all internal optimizations like natural language (NL) interpretation of
        /// queries, supplemental result retrieval, and usage of synonyms including custom ones. Nl interpretation will
        /// be disabled if either one of the two flags is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableVerbatimMode")]
        public virtual System.Nullable<bool> EnableVerbatimMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information relevant only to a query entry.</summary>
    public class QueryItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>True if the text was generated by means other than a previous user search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isSynthetic")]
        public virtual System.Nullable<bool> IsSynthetic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The definition of a operator that can be used in a Search/Suggest request.</summary>
    public class QueryOperator : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Display name of the operator</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Potential list of values for the opeatror field. This field is only filled when we can safely enumerate all
        /// the possible values of this operator.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enumValues")]
        public virtual System.Collections.Generic.IList<string> EnumValues { get; set; }

        /// <summary>
        /// Indicates the operator name that can be used to isolate the property using the greater-than operator.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("greaterThanOperatorName")]
        public virtual string GreaterThanOperatorName { get; set; }

        /// <summary>Can this operator be used to get facets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isFacetable")]
        public virtual System.Nullable<bool> IsFacetable { get; set; }

        /// <summary>Indicates if multiple values can be set for this property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRepeatable")]
        public virtual System.Nullable<bool> IsRepeatable { get; set; }

        /// <summary>Will the property associated with this facet be returned as part of search results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isReturnable")]
        public virtual System.Nullable<bool> IsReturnable { get; set; }

        /// <summary>Can this operator be used to sort results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isSortable")]
        public virtual System.Nullable<bool> IsSortable { get; set; }

        /// <summary>Can get suggestions for this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isSuggestable")]
        public virtual System.Nullable<bool> IsSuggestable { get; set; }

        /// <summary>
        /// Indicates the operator name that can be used to isolate the property using the less-than operator.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lessThanOperatorName")]
        public virtual string LessThanOperatorName { get; set; }

        /// <summary>
        /// The name of the object corresponding to the operator. This field is only filled for schema-specific
        /// operators, and is unset for common operators.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectType")]
        public virtual string ObjectType { get; set; }

        /// <summary>The name of the operator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatorName")]
        public virtual string OperatorName { get; set; }

        /// <summary>The type of the operator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of sources that the user can search using the query API.</summary>
    public class QuerySource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Display name of the data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>List of all operators applicable for this source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operators")]
        public virtual System.Collections.Generic.IList<QueryOperator> Operators { get; set; }

        /// <summary>A short name or alias for the source. This value can be used with the 'source' operator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortName")]
        public virtual string ShortName { get; set; }

        /// <summary>The name of the source</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual Source Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This field does not contain anything as of now and is just used as an indicator that the suggest result was a
    /// phrase completion.
    /// </summary>
    public class QuerySuggestion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Quote metadata: go/message-quoting-be-dd-v2. This proto is only used on the read path. For the request proto,
    /// refer to `QuotedMessagePayload`. Fields are either derived from storage directly from the Item this metadata
    /// belongs to, or is hydrated at read time from another Item read. Note: QuotedMessageMetadata proto is similar to
    /// Message proto with less field. Reasons to differtiate QuotedMessageMetadata from Message are: 1. Not all fields
    /// for original message is applicable for quoted message. (E.g. reactions, is_inline_reply, etc.), thus separting
    /// out for confusion. 2. We don't support nested message quoting. For more detailed discussion, please see
    /// http://shortn/_VsSXQb2C7P. For future reference: if your new feature/field will be supported in message quoting
    /// feature (go/chat-quoting-prd), you will need to add that field within QuotedMessageMetadata
    /// </summary>
    public class QuotedMessageMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Snapshot of the annotations of the quoted message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IList<Annotation> Annotations { get; set; }

        /// <summary>Output only. Custom display profile info for apps. Will be empty for real users.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appProfile")]
        public virtual AppsDynamiteSharedAppProfile AppProfile { get; set; }

        /// <summary>
        /// Output only. The bot attachment state of the quoted message. Used by clients to display a bot attachment
        /// indicator in the UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("botAttachmentState")]
        public virtual string BotAttachmentState { get; set; }

        /// <summary>
        /// Output only. ID of the User who posted the quoted message. This includes information to identify if the
        /// quoted message was posted by an App on behalf of a user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creatorId")]
        public virtual UserId CreatorId { get; set; }

        /// <summary>
        /// The `last_update_time` of the original message when the client initiated the quote creation. This is derived
        /// from the request payload passed from clients. Used to fetch the quoted message contents at a specific time
        /// on the read path. This field is populated from storage directly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateTimeWhenQuotedMicros")]
        public virtual System.Nullable<long> LastUpdateTimeWhenQuotedMicros { get; set; }

        /// <summary>
        /// MessageId of the original message that is being quoted. This is derived from the request payload passed from
        /// clients. This field is populated from storage directly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageId")]
        public virtual MessageId MessageId { get; set; }

        /// <summary>
        /// Output only. The state of the quoted message. Used by clients to display tombstones for quotes that
        /// reference a deleted message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageState")]
        public virtual string MessageState { get; set; }

        /// <summary>Output only. The retention (OTR) settings of the quoted message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retentionSettings")]
        public virtual AppsDynamiteSharedRetentionSettings RetentionSettings { get; set; }

        /// <summary>Output only. Snapshot of the text body of the quoted message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textBody")]
        public virtual string TextBody { get; set; }

        /// <summary>Output only. Upload metadata of the quoted message. NEXT TAG: 11</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadMetadata")]
        public virtual System.Collections.Generic.IList<UploadMetadata> UploadMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Principal associated with a given RBAC role. This principal is used by Sphinx Provisioning Service for RBAC
    /// (go/cedi-auth) provisionable (go/sphinx-rbacz-design).
    /// </summary>
    public class RbacRoleProto : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>DEPRECATED as of 01.11.2019</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rbacNamespace")]
        public virtual string RbacNamespace { get; set; }

        /// <summary>
        /// Format: "RbacNamespaceName.RbacRoleName(/field=value)*", e.g., "hr.v1.Reader",
        /// "hr.v1.Reader/language=EN_US/country=USA/room=NYC-9th-11A201".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rbacRoleName")]
        public virtual string RbacRoleName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Principal associated with a given RBAC subject. This principal is used by Sphinx Provisioning Service for RBAC
    /// (go/cedi-auth) provisionable (go/sphinx-rbacz-design).
    /// </summary>
    public class RbacSubjectProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Format "username" without "@domain", e.g., "bogdand".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains information about an emoji reaction.</summary>
    public class ReactionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unicode string representing a single emoji.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emoji")]
        public virtual string Emoji { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ReadReceiptsSettingsUpdatedMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The new read receipts state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readReceiptsEnabled")]
        public virtual System.Nullable<bool> ReadReceiptsEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A recording event is something that happens to the recording in a conference.</summary>
    public class RecordingEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The initiator of the latest event of the recording. It will be set for all user events (`type` is 100-199)
        /// and unset for all server events (`type` is 200-299).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual string DeviceId { get; set; }

        /// <summary>The type of event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This message is deprecated, please use RecordingSessionInfo instead. Information about recording in the current
    /// conference.
    /// </summary>
    public class RecordingInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The latest recording event. This can be used by clients to help explain what is going on, why recording
        /// stopped, etc. This will always be set if there is or was an active recording, which means there can be
        /// latest event when recording is INACTIVE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestRecordingEvent")]
        public virtual RecordingEvent LatestRecordingEvent { get; set; }

        /// <summary>
        /// The display name of the owner of the recording output. Email notifications about uploaded recordings will
        /// also be sent to this owner.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerDisplayName")]
        public virtual string OwnerDisplayName { get; set; }

        /// <summary>
        /// The device resource name of the producer device for the currently active recording. Note that, after the
        /// producer drops/leaves the conference, this field will be cleaned up by the server after a delay.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("producerDeviceId")]
        public virtual string ProducerDeviceId { get; set; }

        /// <summary>
        /// The application type of the current active recording. `RECORDING_APPLICATION_TYPE_UNSPECIFIED` if
        /// `recording_status` is inactive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordingApplicationType")]
        public virtual string RecordingApplicationType { get; set; }

        /// <summary>
        /// An identifier for the current recording, if any. This is returned whenever recording_status is either
        /// `RECORDING_STARTING` or `RECORDING_STARTED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordingId")]
        public virtual string RecordingId { get; set; }

        /// <summary>
        /// The current status of the recording. This can be used by clients to show a recording dot or similar to
        /// indicated to the user that a recording is taking place.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordingStatus")]
        public virtual string RecordingStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a recording session.</summary>
    public class RecordingSessionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Input only. Deprecated field, should not be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerEmail")]
        public virtual string OwnerEmail { get; set; }

        /// <summary>A unique server-generated ID for the recording session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordingSessionId")]
        public virtual string RecordingSessionId { get; set; }

        /// <summary>Recording session's state information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionStateInfo")]
        public virtual SessionStateInfo SessionStateInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RenameEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("newName")]
        public virtual string NewName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("originalName")]
        public virtual string OriginalName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Errors when the connector is communicating to the source repository.</summary>
    public class RepositoryError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Message that describes the error. The maximum allowable length of the message is 8192 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>Error codes. Matches the definition of HTTP status codes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpStatusCode")]
        public virtual System.Nullable<int> HttpStatusCode { get; set; }

        /// <summary>The type of error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Shared request options for all RPC methods.</summary>
    public class RequestOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Debug options of the request</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugOptions")]
        public virtual DebugOptions DebugOptions { get; set; }

        /// <summary>
        /// The BCP-47 language code, such as "en-US" or "sr-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier. For translations. Set this field using the
        /// language set in browser or for the page. In the event that the user's language preference is known, set this
        /// field to the known user language. When specified, the documents in search results are biased towards the
        /// specified language. From Suggest API perspective, for 3p suggest this is used as a hint while making
        /// predictions to add language boosting.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// The ID generated when you create a search application using the [admin
        /// console](https://support.google.com/a/answer/9043922).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchApplicationId")]
        public virtual string SearchApplicationId { get; set; }

        /// <summary>
        /// Current user's time zone id, such as "America/Los_Angeles" or "Australia/Sydney". These IDs are defined by
        /// [Unicode Common Locale Data Repository (CLDR)](http://cldr.unicode.org/) project, and currently available in
        /// the file [timezone.xml](http://unicode.org/repos/cldr/trunk/common/bcp47/timezone.xml). This field is used
        /// to correctly interpret date and time queries. If this field is not specified, the default time zone (UTC) is
        /// used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of capabilities that are used in this message.</summary>
    public class RequiredMessageFeaturesMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("requiredFeatures")]
        public virtual System.Collections.Generic.IList<string> RequiredFeatures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ResetSearchApplicationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Common debug options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugOptions")]
        public virtual DebugOptions DebugOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A type of sharing target that points to some resource's ACL. Used to refer to the set of Principals that have
    /// the given privilege ('role_id') for the given resource ('application_id', 'object_id', 'object_part'). The
    /// meaning of 'role_id' is interpreted only by implementations of AclRpcService and is usually dependent on
    /// 'application_id' All fields except object_part are required. If present, object_part must be non-empty.
    /// </summary>
    public class ResourceRoleProto : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("applicationId")]
        public virtual string ApplicationId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("objectPart")]
        public virtual string ObjectPart { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("roleId")]
        public virtual System.Nullable<int> RoleId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Debugging information about the response.</summary>
    public class ResponseDebugInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Experiments enabled in QAPI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabledExperiments")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> EnabledExperiments { get; set; }

        /// <summary>General debug info formatted for display.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedDebugInfo")]
        public virtual string FormattedDebugInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information relevant only to a restrict entry. NextId: 12</summary>
    public class RestrictItem : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("driveFollowUpRestrict")]
        public virtual DriveFollowUpRestrict DriveFollowUpRestrict { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("driveLocationRestrict")]
        public virtual DriveLocationRestrict DriveLocationRestrict { get; set; }

        /// <summary>Drive Types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveMimeTypeRestrict")]
        public virtual DriveMimeTypeRestrict DriveMimeTypeRestrict { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("driveTimeSpanRestrict")]
        public virtual DriveTimeSpanRestrict DriveTimeSpanRestrict { get; set; }

        /// <summary>The search restrict (e.g. "after:2017-09-11 before:2017-09-12").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchOperator")]
        public virtual string SearchOperator { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result count information</summary>
    public class ResultCounts : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Result count information for each source with results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceResultCounts")]
        public virtual System.Collections.Generic.IList<SourceResultCount> SourceResultCounts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Debugging information about the result.</summary>
    public class ResultDebugInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>General debug info formatted for display.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedDebugInfo")]
        public virtual string FormattedDebugInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Display Fields for Search Results</summary>
    public class ResultDisplayField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The display label for the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>The operator name of the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatorName")]
        public virtual string OperatorName { get; set; }

        /// <summary>The name value pair for the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual NamedProperty Property { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The collection of fields that make up a displayed line</summary>
    public class ResultDisplayLine : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<ResultDisplayField> Fields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ResultDisplayMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The metalines content to be displayed with the result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metalines")]
        public virtual System.Collections.Generic.IList<ResultDisplayLine> Metalines { get; set; }

        /// <summary>The display label for the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectTypeLabel")]
        public virtual string ObjectTypeLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RetrievalImportance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates the ranking importance given to property when it is matched during retrieval. Once set, the token
        /// importance of a property cannot be changed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importance")]
        public virtual string Importance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RoomRenameMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("newName")]
        public virtual string NewName { get; set; }

        /// <summary>NEXT_TAG: 3</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prevName")]
        public virtual string PrevName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RoomUpdatedMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("groupDetailsMetadata")]
        public virtual GroupDetailsUpdatedMetadata GroupDetailsMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("groupLinkSharingEnabled")]
        public virtual System.Nullable<bool> GroupLinkSharingEnabled { get; set; }

        /// <summary>
        /// The user who initiated this room update. Complete member profiles, when ListTopicsRequest FetchOptions.USER
        /// is set. Otherwise, only the id will be filled in.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initiator")]
        public virtual User Initiator { get; set; }

        /// <summary>The type of the user who initiated this room update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initiatorType")]
        public virtual string InitiatorType { get; set; }

        /// <summary>What was updated in the room.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("renameMetadata")]
        public virtual RoomRenameMetadata RenameMetadata { get; set; }

        /// <summary>DEPRECATED: See GroupVisibility proto definition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visibility")]
        public virtual AppsDynamiteSharedGroupVisibility Visibility { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Roster profile information.</summary>
    public class Roster : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("avatarUrl")]
        public virtual string AvatarUrl { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual RosterId Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("membershipCount")]
        public virtual System.Nullable<int> MembershipCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Roster gaia key, usually an email address. Set in looking up rosters response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rosterGaiaKey")]
        public virtual string RosterGaiaKey { get; set; }

        /// <summary>Roster deletion state - considered active unless set to deleted</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rosterState")]
        public virtual string RosterState { get; set; }

        /// <summary>Roster membership count. May contain counts based on member type and membership state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentedMembershipCounts")]
        public virtual AppsDynamiteSharedSegmentedMembershipCounts SegmentedMembershipCounts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Primary key for Roster resource.</summary>
    public class RosterId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Opaque, server-assigned ID of the Roster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message containing a string that is safe to use in URL contexts in DOM APIs and HTML documents, where the URL
    /// context does not refer to a resource that loads code.
    /// </summary>
    public class SafeUrlProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// IMPORTANT: Never set or read this field, even from tests, it is private. See documentation at the top of
        /// .proto file for programming language packages with which to create or read this message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateDoNotAccessOrElseSafeUrlWrappedValue")]
        public virtual string PrivateDoNotAccessOrElseSafeUrlWrappedValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The schema definition for a data source.</summary>
    public class Schema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of top-level objects for the data source. The maximum number of elements is 10.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectDefinitions")]
        public virtual System.Collections.Generic.IList<ObjectDefinition> ObjectDefinitions { get; set; }

        /// <summary>
        /// IDs of the Long Running Operations (LROs) currently running for this schema. After modifying the schema,
        /// wait for operations to complete before indexing additional content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationIds")]
        public virtual System.Collections.Generic.IList<string> OperationIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Scoring configurations for a source while processing a Search or Suggest request.</summary>
    public class ScoringConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether to use freshness as a ranking signal. By default, freshness is used as a ranking signal. Note that
        /// this setting is not available in the Admin UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableFreshness")]
        public virtual System.Nullable<bool> DisableFreshness { get; set; }

        /// <summary>
        /// Whether to personalize the results. By default, personal signals will be used to boost results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disablePersonalization")]
        public virtual System.Nullable<bool> DisablePersonalization { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SearchApplication</summary>
    public class SearchApplication : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Retrictions applied to the configurations. The maximum number of elements is 10.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceRestrictions")]
        public virtual System.Collections.Generic.IList<DataSourceRestriction> DataSourceRestrictions { get; set; }

        /// <summary>
        /// The default fields for returning facet results. The sources specified here also have been included in
        /// data_source_restrictions above.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultFacetOptions")]
        public virtual System.Collections.Generic.IList<FacetOptions> DefaultFacetOptions { get; set; }

        /// <summary>The default options for sorting the search results</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultSortOptions")]
        public virtual SortOptions DefaultSortOptions { get; set; }

        /// <summary>Display name of the Search Application. The maximum length is 300 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Indicates whether audit logging is on/off for requests made for the search application in query APIs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableAuditLog")]
        public virtual System.Nullable<bool> EnableAuditLog { get; set; }

        /// <summary>The name of the Search Application. Format: searchapplications/{application_id}.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. IDs of the Long Running Operations (LROs) currently running for this schema. Output only field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationIds")]
        public virtual System.Collections.Generic.IList<string> OperationIds { get; set; }

        /// <summary>The default options for query interpretation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryInterpretationConfig")]
        public virtual QueryInterpretationConfig QueryInterpretationConfig { get; set; }

        /// <summary>With each result we should return the URI for its thumbnail (when applicable)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnResultThumbnailUrls")]
        public virtual System.Nullable<bool> ReturnResultThumbnailUrls { get; set; }

        /// <summary>Configuration for ranking results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scoringConfig")]
        public virtual ScoringConfig ScoringConfig { get; set; }

        /// <summary>Configuration for a sources specified in data_source_restrictions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceConfig")]
        public virtual System.Collections.Generic.IList<SourceConfig> SourceConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Search application level query stats per date</summary>
    public class SearchApplicationQueryStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The date for which query stats were calculated. Stats calculated on the next day close to midnight are
        /// returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("queryCountByStatus")]
        public virtual System.Collections.Generic.IList<QueryCountByStatus> QueryCountByStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SearchApplicationSessionStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The date for which session stats were calculated. Stats are calculated on the following day, close to
        /// midnight PST, and then returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>The count of search sessions on the day</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchSessionsCount")]
        public virtual System.Nullable<long> SearchSessionsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SearchApplicationUserStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The date for which session stats were calculated. Stats calculated on the next day close to midnight are
        /// returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>The count of unique active users in the past one day</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oneDayActiveUsersCount")]
        public virtual System.Nullable<long> OneDayActiveUsersCount { get; set; }

        /// <summary>The count of unique active users in the past seven days</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sevenDaysActiveUsersCount")]
        public virtual System.Nullable<long> SevenDaysActiveUsersCount { get; set; }

        /// <summary>The count of unique active users in the past thirty days</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thirtyDaysActiveUsersCount")]
        public virtual System.Nullable<long> ThirtyDaysActiveUsersCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SearchItemsByViewUrlRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Common debug options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugOptions")]
        public virtual DebugOptions DebugOptions { get; set; }

        /// <summary>The next_page_token value returned from a previous request, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Specify the full view URL to find the corresponding item. The maximum length is 2048 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewUrl")]
        public virtual string ViewUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SearchItemsByViewUrlResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Item> Items { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional search quality metadata of the item.</summary>
    public class SearchQualityMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An indication of the quality of the item, used to influence search quality. Value should be between 0.0
        /// (lowest quality) and 1.0 (highest quality). The default value is 0.0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quality")]
        public virtual System.Nullable<double> Quality { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The search API request.</summary>
    public class SearchRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Context attributes for the request which will be used to adjust ranking of search results. The maximum
        /// number of elements is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contextAttributes")]
        public virtual System.Collections.Generic.IList<ContextAttribute> ContextAttributes { get; set; }

        /// <summary>
        /// The sources to use for querying. If not specified, all data sources from the current search application are
        /// used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceRestrictions")]
        public virtual System.Collections.Generic.IList<DataSourceRestriction> DataSourceRestrictions { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("facetOptions")]
        public virtual System.Collections.Generic.IList<FacetOptions> FacetOptions { get; set; }

        /// <summary>
        /// Maximum number of search results to return in one page. Valid values are between 1 and 100, inclusive.
        /// Default value is 10. Minimum value is 50 when results beyond 2000 are requested.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// The raw query string. See supported search operators in the [Narrow your search with
        /// operators](https://support.google.com/cloudsearch/answer/6172299)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>Options to interpret the user query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryInterpretationOptions")]
        public virtual QueryInterpretationOptions QueryInterpretationOptions { get; set; }

        /// <summary>Request options, such as the search application and user timezone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestOptions")]
        public virtual RequestOptions RequestOptions { get; set; }

        /// <summary>The options for sorting the search results</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortOptions")]
        public virtual SortOptions SortOptions { get; set; }

        /// <summary>Starting index of the results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("start")]
        public virtual System.Nullable<int> Start { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The search API response.</summary>
    public class SearchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Debugging information about the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugInfo")]
        public virtual ResponseDebugInfo DebugInfo { get; set; }

        /// <summary>Error information about the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorInfo")]
        public virtual ErrorInfo ErrorInfo { get; set; }

        /// <summary>Repeated facet results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("facetResults")]
        public virtual System.Collections.Generic.IList<FacetResult> FacetResults { get; set; }

        /// <summary>Whether there are more search results matching the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasMoreResults")]
        public virtual System.Nullable<bool> HasMoreResults { get; set; }

        /// <summary>Query interpretation result for user query. Empty if query interpretation is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryInterpretation")]
        public virtual QueryInterpretation QueryInterpretation { get; set; }

        /// <summary>The estimated result count for this query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultCountEstimate")]
        public virtual System.Nullable<long> ResultCountEstimate { get; set; }

        /// <summary>The exact result count for this query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultCountExact")]
        public virtual System.Nullable<long> ResultCountExact { get; set; }

        /// <summary>Expanded result count information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultCounts")]
        public virtual ResultCounts ResultCounts { get; set; }

        /// <summary>Results from a search query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<SearchResult> Results { get; set; }

        /// <summary>Suggested spelling for the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spellResults")]
        public virtual System.Collections.Generic.IList<SpellResult> SpellResults { get; set; }

        /// <summary>
        /// Structured results for the user query. These results are not counted against the page_size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structuredResults")]
        public virtual System.Collections.Generic.IList<StructuredResult> StructuredResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Results containing indexed information for a document.</summary>
    public class SearchResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If source is clustered, provide list of clustered results. There will only be one level of clustered
        /// results. If current source is not enabled for clustering, this field will be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusteredResults")]
        public virtual System.Collections.Generic.IList<SearchResult> ClusteredResults { get; set; }

        /// <summary>Debugging information about this search result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugInfo")]
        public virtual ResultDebugInfo DebugInfo { get; set; }

        /// <summary>Metadata of the search result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual Metadata Metadata { get; set; }

        /// <summary>The concatenation of all snippets (summaries) available for this result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual Snippet Snippet { get; set; }

        /// <summary>Title of the search result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// The URL of the search result. The URL contains a Google redirect to the actual item. This URL is signed and
        /// shouldn't be changed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Sections are separated by a line divider. They contain a collection of widgets that are rendered (vertically) in
    /// the order that they are specified. Across all platforms, AddOns have a narrow fixed width, so there is currently
    /// no need for layout properties (e.g. float).
    /// </summary>
    public class Section : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicating whether this section is collapsable. If a section is collapsable, the description must be given.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collapsable")]
        public virtual System.Nullable<bool> Collapsable { get; set; }

        /// <summary>The header of the section, text formatted supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The number of uncollapsable widgets. For example, when a section contains 5 widgets and the
        /// num_uncollapsable_widget are set to be 2, The first 2 widgets will always shown and the last 3 is collapsed
        /// as default. Only when collapsable is set to be true, the num_uncollapsable_widget will be taken into
        /// account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numUncollapsableWidgets")]
        public virtual System.Nullable<int> NumUncollapsableWidgets { get; set; }

        /// <summary>A section must contain at least 1 widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widgets")]
        public virtual System.Collections.Generic.IList<WidgetMarkup> Widgets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Segment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Formatting to be applied when rendering the Segment. For all segment types, this is the standard way of
        /// representing that the Segment should be rendered in bold, italics, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formatting")]
        public virtual Formatting Formatting { get; set; }

        /// <summary>For HASHTAG type:</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hashtagData")]
        public virtual HashtagData HashtagData { get; set; }

        /// <summary>
        /// Type-specific metadata. At most one of these should be populated, and the one that is populated should
        /// correspond to the type of the Segment. For LINK type:
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkData")]
        public virtual LinkData LinkData { get; set; }

        /// <summary>
        /// Text content of the Segment. As a general rule, this field should contain the actual text that should be
        /// rendered in the UI. Thus, for a hashtag, it should be "#Foo", and for a link, it should be the display text.
        /// Clients that do not understand a particular segment type may use this text, along with the Formatting info
        /// below, as a fallback for display. The field is not required -- if all relevant information is carried in
        /// other metadata fields and there is no need for a fallback, or it is not practical for a fallback to be
        /// provided for any other reason, the field may be left blank. A standard example would be a user reference
        /// being transmitted between server layers, where a gaia-ID representation may be sufficient and there is no
        /// need for a textual fallback. In such a case, it would be valid and useful - though not required - for
        /// servers to compute and populate a fallback on the serving path.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>Type of Segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>For USER_MENTION type:</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userMentionData")]
        public virtual UserMentionData UserMentionData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SelectionControl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>For radio button, at most one of the items will be selected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<SelectionItem> Items { get; set; }

        /// <summary>Label used to be displayed ahead of the selection control. It is optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>The name of the text field which is will be used in FormInput.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// If specified, form is submitted when selection changed. If not specified, developer will need to specify a
        /// separate button.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onChange")]
        public virtual FormAction OnChange { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SelectionItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If more than one items are selected for RADIO_BUTTON and DROPDOWN, the first selected item is treated as
        /// sElected and the after ones are all ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selected")]
        public virtual System.Nullable<bool> Selected { get; set; }

        /// <summary>The text to be displayed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>
        /// The value associated with this item which will be sent back to app scripts. Client should use as a form
        /// input value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A session event is something that happens to the streaming session in a conference.</summary>
    public class SessionEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The initiator of the latest event of the streaming session. It will be set for all user events (`type` is
        /// 100-199) and unset for all server events(`type` is 200-299).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual string DeviceId { get; set; }

        /// <summary>The type of event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about the state of a (recording, broadcast, transcription...) session in a conference.
    /// </summary>
    public class SessionStateInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The ack info of the session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ackInfo")]
        public virtual AckInfo AckInfo { get; set; }

        /// <summary>
        /// Immutable. The language configuration used by this session. When empty, captions will be disabled. It's a
        /// required field for transcription sessions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageConfig")]
        public virtual LanguageConfig LanguageConfig { get; set; }

        /// <summary>
        /// Output only. The device id of the actor is set if the current state is a result of a user action, is empty
        /// otherwise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastActorDeviceId")]
        public virtual string LastActorDeviceId { get; set; }

        /// <summary>
        /// Output only. The max end time of the session, at this time the session will be force stopped/terminated.
        /// Clients are expected to use this timestamp to warn users about the force stop.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxEndTime")]
        public virtual object MaxEndTime { get; set; }

        /// <summary>State of the session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionState")]
        public virtual string SessionState { get; set; }

        /// <summary>Output only. The reason the session was transitioned to STOPPED state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionStopReason")]
        public virtual string SessionStopReason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Settings of a meeting space that can be viewed and edited by users with permissions. These settings are always
    /// populated for output.
    /// </summary>
    public class Settings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The access lock of the meeting space that lets owner control who can join the meeting. True if the access
        /// lock feature is enabled for the meeting space.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLock")]
        public virtual System.Nullable<bool> AccessLock { get; set; }

        /// <summary>Whether attendance report is enabled for the meeting space.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attendanceReportEnabled")]
        public virtual System.Nullable<bool> AttendanceReportEnabled { get; set; }

        /// <summary>
        /// The chat lock of the meeting space that lets owner control whether the participants can send chat messages.
        /// True if the chat lock feature is enabled for the meeting space.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chatLock")]
        public virtual System.Nullable<bool> ChatLock { get; set; }

        /// <summary>Whether meeting artifacts will be shared with cohosts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cohostArtifactSharingEnabled")]
        public virtual System.Nullable<bool> CohostArtifactSharingEnabled { get; set; }

        /// <summary>Whether Client-side Encryption is enabled for the meeting space.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cseEnabled")]
        public virtual System.Nullable<bool> CseEnabled { get; set; }

        /// <summary>Whether the default role is viewer or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultAsViewer")]
        public virtual System.Nullable<bool> DefaultAsViewer { get; set; }

        /// <summary>Indicates whether the meeting space is moderated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moderationEnabled")]
        public virtual System.Nullable<bool> ModerationEnabled { get; set; }

        /// <summary>
        /// The present lock of the meeting space that lets owner control whether the participants can present their
        /// screen. True if the present lock feature is enabled for the meeting space.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("presentLock")]
        public virtual System.Nullable<bool> PresentLock { get; set; }

        /// <summary>
        /// The reactions lock of the meeting space that lets owner control whether the participants can send reactions.
        /// True if the reactions lock feature is enabled for the meeting space.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reactionsLock")]
        public virtual System.Nullable<bool> ReactionsLock { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ShareScope : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If scope is DOMAIN, this field contains the dasher domain, for example "google.com".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>The scope to which the content was shared.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a principal who possesses a signing key corresponding to the verification key or keyset described
    /// here.
    /// </summary>
    public class SigningKeyPossessorProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This value must be from the KeyMetadata.Type enum in keymaster.proto.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keymasterKeyType")]
        public virtual System.Nullable<int> KeymasterKeyType { get; set; }

        /// <summary>The actual verification key bytes corresponding to the above type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serializedVerificationKey")]
        public virtual string SerializedVerificationKey { get; set; }

        /// <summary>
        /// The binary serialized Keymaster SerializedReader of a public keyset. The keyset must contain exactly one
        /// key. N.B.: If this field is populated, serialized_verification_key should be set to the empty string and
        /// keymaster_key_type should be set to zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serializedVerificationKeyset")]
        public virtual string SerializedVerificationKeyset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a principal which possesses a particular, presumably secret, string. Useful for things like "auth
    /// keys," used for anonymous sharing. Since representing this principal with the actual secret included reveals the
    /// secret, it's best if the requisite condition is enforced in some other way, for example via Keystore wrapping
    /// attributes (Keystore will unwrap only if the specified secret, aka "attribute", is presented). All that's stored
    /// here is an identifying label.
    /// </summary>
    public class SimpleSecretHolderProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A descriptive label to help identify a relevant ACL entry or otherwise disambiguate this instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual SimpleSecretLabelProto Label { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// SimpleSecretProto (in authenticator.proto) and SimpleSecretHolderProto (below) share the notion of a "label",
    /// which identifies a particular secret without (hopefully) revealing the secret. Note that a SimpleSecretLabel
    /// only disambiguates between secrets used to get access to some particular object. Two different secrets that
    /// apply to two different objects could have the same label. For example, in the common sharing model, each object
    /// has no more than one "auth key". Therefore, the label for an auth key simply has type = AUTH_KEY with no
    /// additional information. In theory, we could add some sort of resource ID to SimpleSecretLabel to make it more
    /// explicit. However, in practice, this is never really needed. A SimpleSecret for one object is never used to
    /// authorize a request on some other object, so there is no ambiguity. Also, since SimpleSecrets must obviously be
    /// unguessable, there is no risk that a SimpleSecret intended for one object will accidentally grant access to
    /// another.
    /// </summary>
    public class SimpleSecretLabelProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// ***DEPRECATED (3-Oct-2011) *** This field should be deleted when code stops using CAP_TOKEN labels. Used
        /// when type = CAP_TOKEN. When a CAP_TOKEN label appears in a SimpleSecretHolder Principal, |capability_id|
        /// must be filled in to identify one of the capabilities on the ACL. When a CAP_TOKEN label appears in a
        /// SimpleSecret Authenticator, it is NOT necessary to fill in |capability_id| -- ACL Service will find the ID
        /// by searching all capabilities on the ACL for one associated with the token given by the SimpleSecret's
        /// secret data. If |capability_id| is specified, though, then the Authenticator will only be accepted if it
        /// actually matches that particular token ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capabilityId")]
        public virtual System.Nullable<int> CapabilityId { get; set; }

        /// <summary>Used when type = GENERIC_SECRET</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("genericLabel")]
        public virtual string GenericLabel { get; set; }

        /// <summary>Used when type == INVITE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inviteId")]
        public virtual System.Nullable<long> InviteId { get; set; }

        /// <summary>This is optional because required enums cannot be extended.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotation metadata for slash commands (/).</summary>
    public class SlashCommandMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hint string for the arguments expected by the slash command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("argumentsHint")]
        public virtual string ArgumentsHint { get; set; }

        /// <summary>Unique id for the slash command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commandId")]
        public virtual System.Nullable<long> CommandId { get; set; }

        /// <summary>Name of the slash command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commandName")]
        public virtual string CommandName { get; set; }

        /// <summary>ID of the bot which owns the slash command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual UserId Id { get; set; }

        /// <summary>Whether or not this slash command should trigger a dialog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggersDialog")]
        public virtual System.Nullable<bool> TriggersDialog { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Snippet of the search result, which summarizes the content of the resulting page.</summary>
    public class Snippet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The matched ranges in the snippet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchRanges")]
        public virtual System.Collections.Generic.IList<MatchRange> MatchRanges { get; set; }

        /// <summary>
        /// The snippet of the document. The snippet of the document. May contain escaped HTML character that should be
        /// unescaped prior to rendering.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual string SnippetValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Attachment represents a linked entity associated with a piece of social content. This may be a 1st-party or
    /// 3rd-party entity. In the Papyrus context, an Attachment is part of a Cent, and sits alongside the main content
    /// of the cent, which is represented as a sequence of Segments. Right now an Attachment is just a wrapper around an
    /// Embed, but we provide the extra layer of abstraction since, as Embeds move to separate storage in Briefcase, we
    /// may want to add additional fields that are not part of the Embed proper, but that (for example) relate to the
    /// usage of the linked content within the particular post/cent.
    /// </summary>
    public class SocialCommonAttachmentAttachment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An embed represents an external entity. See go/es-embeds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("embedItem")]
        public virtual EmbedClientItem EmbedItem { get; set; }

        /// <summary>An id to uniquely identify an attachment when several attachments are in a collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a user pseudonym. Pseudonyms are linked accounts on Google and third-party services (e.g. YouTube or
    /// Twitter) and are described by a Social Graph Node.
    /// </summary>
    public class SocialGraphNodeProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fields from ccc/socialgraph/socialgraphnode.proto:SgnNode that uniquely identify a social graph node.
        /// The 'ident' field is not included here because its value can be changed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sgnDomain")]
        public virtual string SgnDomain { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sgnPk")]
        public virtual string SgnPk { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SortOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the operator corresponding to the field to sort on. The corresponding property must be marked as
        /// sortable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatorName")]
        public virtual string OperatorName { get; set; }

        /// <summary>Ascending is the default sort order</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortOrder")]
        public virtual string SortOrder { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines sources for the suggest/search APIs.</summary>
    public class Source : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Source name for content indexed by the Indexing API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Predefined content source for Google Apps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predefinedSource")]
        public virtual string PredefinedSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configurations for a source while processing a Search or Suggest request.</summary>
    public class SourceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The crowding configuration for the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crowdingConfig")]
        public virtual SourceCrowdingConfig CrowdingConfig { get; set; }

        /// <summary>The scoring configuration for the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scoringConfig")]
        public virtual SourceScoringConfig ScoringConfig { get; set; }

        /// <summary>The source for which this configuration is to be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual Source Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Set search results crowding limits. Crowding is a situation in which multiple results from the same source or
    /// host "crowd out" other results, diminishing the quality of search for users. To foster better search quality and
    /// source diversity in search results, you can set a condition to reduce repetitive results by source.
    /// </summary>
    public class SourceCrowdingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Maximum number of results allowed from a datasource in a result page as long as results from other sources
        /// are not exhausted. Value specified must not be negative. A default value is used if this value is equal to
        /// 0. To disable crowding, set the value greater than 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numResults")]
        public virtual System.Nullable<int> NumResults { get; set; }

        /// <summary>
        /// Maximum number of suggestions allowed from a source. No limits will be set on results if this value is less
        /// than or equal to 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numSuggestions")]
        public virtual System.Nullable<int> NumSuggestions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Per source result count information.</summary>
    public class SourceResultCount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether there are more search results for this source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasMoreResults")]
        public virtual System.Nullable<bool> HasMoreResults { get; set; }

        /// <summary>The estimated result count for this source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultCountEstimate")]
        public virtual System.Nullable<long> ResultCountEstimate { get; set; }

        /// <summary>The exact result count for this source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultCountExact")]
        public virtual System.Nullable<long> ResultCountExact { get; set; }

        /// <summary>The source the result count information is associated with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual Source Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set the scoring configuration. This allows modifying the ranking of results for a source.</summary>
    public class SourceScoringConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Importance of the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceImportance")]
        public virtual string SourceImportance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Primary key for Space resource.</summary>
    public class SpaceId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unique, immutable ID of the Space</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spaceId")]
        public virtual string SpaceIdValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SpellResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The suggested spelling of the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedQuery")]
        public virtual string SuggestedQuery { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the set of members (of a given type) in a Google+ Square (see http://go/squares). A Square with
    /// default member_type is currently (1/2012) identical to the GaiaGroup with the same ID, but that is expected to
    /// change soon (see http://go/superglue). Support for this principal type is currently (1/2012) incomplete -- e.g.,
    /// Keystore does not support it yet (see b/5703421).
    /// </summary>
    public class SquareProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The type of Square members to consider, e.g. "all members" vs. "owners" vs. "admins". These are defined by
        /// legacy_relation_id values in social.graph.storage.EdgeTypeEnum.EdgeType enum options in
        /// social/graph/storage/proto/id.proto. See square.pb (defined in
        /// production/config/cdd/socialgraph/mixer_config/prod/node_type_config) for all valid edge types associated
        /// with square. Currently required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberType")]
        public virtual System.Nullable<int> MemberType { get; set; }

        /// <summary>Currently required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("squareId")]
        public virtual System.Nullable<long> SquareId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Start upload file request.</summary>
    public class StartUploadItemRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of connector making this call. Format: datasources/{source_id}/connectors/{ID}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectorName")]
        public virtual string ConnectorName { get; set; }

        /// <summary>Common debug options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugOptions")]
        public virtual DebugOptions DebugOptions { get; set; }

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

    public class StoredParticipantId : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("gaiaId")]
        public virtual System.Nullable<long> GaiaId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about viewers of the stream.</summary>
    public class StreamViewerStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The estimate of the current viewer count.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedViewerCount")]
        public virtual System.Nullable<long> EstimatedViewerCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a streaming session in conference.</summary>
    public class StreamingSessionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The application type of the current streaming session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationType")]
        public virtual string ApplicationType { get; set; }

        /// <summary>
        /// The latest streaming session event. This can be used by clients to help explain what is going on, why
        /// recording stopped, etc. This will always be set to a valid event and consistent with the status. It can be
        /// set when current session is inactive to indicate latest event that makes current session to become inactive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestSessionEvent")]
        public virtual SessionEvent LatestSessionEvent { get; set; }

        /// <summary>
        /// The display name of the owner of the recording output. It's only set when there will be uploaded recordings.
        /// Currently, it's only set when application type is RECORDING or GLIVE_STREAM.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerDisplayName")]
        public virtual string OwnerDisplayName { get; set; }

        /// <summary>
        /// This is the REST name and unique identifier of this streaming session and has the form `spaces//recordings/`
        /// This is returned whenever status is either `STARTING` or `STARTED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionId")]
        public virtual string SessionId { get; set; }

        /// <summary>
        /// The current status of this streaming session. This can be used by clients to show session status indicator
        /// and/or notification.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>When true, this recording may be used for training new transcription models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingEnabled")]
        public virtual System.Nullable<bool> TrainingEnabled { get; set; }

        /// <summary>
        /// The policy that controls who can view the broadcast. This setting applies for broadcast session.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewerAccessPolicy")]
        public virtual string ViewerAccessPolicy { get; set; }

        /// <summary>
        /// Contains information about viewers of the livestream. It is only set when application type is BROADCAST.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewerStats")]
        public virtual StreamViewerStats ViewerStats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A structured data object consisting of named properties.</summary>
    public class StructuredDataObject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The properties for the object. The maximum number of elements is 1000.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<NamedProperty> Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Structured results that are returned as part of search request.</summary>
    public class StructuredResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Representation of a person</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("person")]
        public virtual Person Person { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request of suggest API.</summary>
    public class SuggestRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The sources to use for suggestions. If not specified, the data sources are taken from the current search
        /// application. NOTE: Suggestions are only supported for the following sources: * Third-party data sources *
        /// PredefinedSource.PERSON * PredefinedSource.GOOGLE_DRIVE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceRestrictions")]
        public virtual System.Collections.Generic.IList<DataSourceRestriction> DataSourceRestrictions { get; set; }

        /// <summary>
        /// Partial query for which autocomplete suggestions will be shown. For example, if the query is "sea", then the
        /// server might return "season", "search", "seagull" and so on.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>Request options, such as the search application and user timezone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestOptions")]
        public virtual RequestOptions RequestOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of the suggest API.</summary>
    public class SuggestResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of suggestions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestResults")]
        public virtual System.Collections.Generic.IList<SuggestResult> SuggestResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>One suggestion result.</summary>
    public class SuggestResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This is present when the suggestion indicates a person. It contains more information about the person - like
        /// their email ID, name etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peopleSuggestion")]
        public virtual PeopleSuggestion PeopleSuggestion { get; set; }

        /// <summary>This field will be present if the suggested query is a word/phrase completion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("querySuggestion")]
        public virtual QuerySuggestion QuerySuggestion { get; set; }

        /// <summary>The source of the suggestion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual Source Source { get; set; }

        /// <summary>The suggested query that will be used for search, when the user clicks on the suggestion</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedQuery")]
        public virtual string SuggestedQuery { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Urls with additional bot related information.</summary>
    public class SupportUrls : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Link to the admin configuration webpage for the bot. Configured by Pantheon, may be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminConfigUrl")]
        public virtual string AdminConfigUrl { get; set; }

        /// <summary>Link to the deletion policy webpage for the bot. Configured by Pantheon, may be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionPolicyUrl")]
        public virtual string DeletionPolicyUrl { get; set; }

        /// <summary>Link to the privacy policy webpage for the bot. May be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privacyPolicyUrl")]
        public virtual string PrivacyPolicyUrl { get; set; }

        /// <summary>Link to the setup webpage for the bot. Configured by Pantheon, may be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setupUrl")]
        public virtual string SetupUrl { get; set; }

        /// <summary>Link to the support webpage for the developer of the bot. May be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportUrl")]
        public virtual string SupportUrl { get; set; }

        /// <summary>Link to the terms of service webpage for the bot. May be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tosUrl")]
        public virtual string TosUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SwitchWidget : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("controlType")]
        public virtual string ControlType { get; set; }

        /// <summary>The name of the switch widget which is will be used in FormInput.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("onChange")]
        public virtual FormAction OnChange { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("selected")]
        public virtual System.Nullable<bool> Selected { get; set; }

        /// <summary>The value is what is passed back in apps script callback.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TextButton : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The alternative text used for accessibility Next field number: 7.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altText")]
        public virtual string AltText { get; set; }

        /// <summary>
        /// Optional color of the button's background in RAISE mode. The default is the secondary color from addon's
        /// manifest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColor")]
        public virtual string BackgroundColor { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual OnClick OnClick { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("style")]
        public virtual string Style { get; set; }

        /// <summary>Text color can be set via HTML markup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TextField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The initial set of auto complete items without any user input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoComplete")]
        public virtual AutoComplete AutoComplete { get; set; }

        /// <summary>
        /// The refresh function which returns AutoComplete based on the user's input text. If the callback is not
        /// specified, auto complete will be purely done in client side based on the auto_complete items.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoCompleteCallback")]
        public virtual FormAction AutoCompleteCallback { get; set; }

        /// <summary>When set to true, a user can input multiple auto-complet items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoCompleteMultipleSelections")]
        public virtual System.Nullable<bool> AutoCompleteMultipleSelections { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("hintText")]
        public virtual string HintText { get; set; }

        /// <summary>One of label or hint_text is required to be specified by the developers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("maxLines")]
        public virtual System.Nullable<int> MaxLines { get; set; }

        /// <summary>The name of the text field which is will be used in FormInput.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("onChange")]
        public virtual FormAction OnChange { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The default value when no input from user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This is deprecated and please use KeyValue.</summary>
    public class TextKeyValue : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual OnClick OnClick { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Used to provide a search operator for text properties. This is optional. Search operators let users restrict the
    /// query to specific fields relevant to the type of item being searched.
    /// </summary>
    public class TextOperatorOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If true, the text value is tokenized as one atomic value in operator searches and facet matches. For
        /// example, if the operator name is "genre" and the value is "science-fiction" the query restrictions
        /// "genre:science" and "genre:fiction" doesn't match the item; "genre:science-fiction" does. Text value
        /// matching is case-sensitive and does not remove special characters. If false, the text is tokenized. For
        /// example, if the value is "science-fiction" the queries "genre:science" and "genre:fiction" matches the item.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exactMatchWithOperator")]
        public virtual System.Nullable<bool> ExactMatchWithOperator { get; set; }

        /// <summary>
        /// Indicates the operator name required in the query in order to isolate the text property. For example, if
        /// operatorName is *subject* and the property's name is *subjectLine*, then queries like
        /// *subject:&amp;lt;value&amp;gt;* show results only where the value of the property named *subjectLine*
        /// matches *&amp;lt;value&amp;gt;*. By contrast, a search that uses the same *&amp;lt;value&amp;gt;* without an
        /// operator returns all items where *&amp;lt;value&amp;gt;* matches the value of any text properties or text
        /// within the content field for the item. The operator name can only contain lowercase letters (a-z). The
        /// maximum length is 32 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatorName")]
        public virtual string OperatorName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TextParagraph : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The options for text properties.</summary>
    public class TextPropertyOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If set, describes how the property should be used as a search operator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatorOptions")]
        public virtual TextOperatorOptions OperatorOptions { get; set; }

        /// <summary>
        /// Indicates the search quality importance of the tokens within the field when used for retrieval.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retrievalImportance")]
        public virtual RetrievalImportance RetrievalImportance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of text values.</summary>
    public class TextValues : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The maximum allowable length for text values is 2048 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Used to provide a search operator for timestamp properties. This is optional. Search operators let users
    /// restrict the query to specific fields relevant to the type of item being searched.
    /// </summary>
    public class TimestampOperatorOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates the operator name required in the query in order to isolate the timestamp property using the
        /// greater-than operator. For example, if greaterThanOperatorName is *closedafter* and the property's name is
        /// *closeDate*, then queries like *closedafter:&amp;lt;value&amp;gt;* show results only where the value of the
        /// property named *closeDate* is later than *&amp;lt;value&amp;gt;*. The operator name can only contain
        /// lowercase letters (a-z). The maximum length is 32 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("greaterThanOperatorName")]
        public virtual string GreaterThanOperatorName { get; set; }

        /// <summary>
        /// Indicates the operator name required in the query in order to isolate the timestamp property using the
        /// less-than operator. For example, if lessThanOperatorName is *closedbefore* and the property's name is
        /// *closeDate*, then queries like *closedbefore:&amp;lt;value&amp;gt;* show results only where the value of the
        /// property named *closeDate* is earlier than *&amp;lt;value&amp;gt;*. The operator name can only contain
        /// lowercase letters (a-z). The maximum length is 32 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lessThanOperatorName")]
        public virtual string LessThanOperatorName { get; set; }

        /// <summary>
        /// Indicates the operator name required in the query in order to isolate the timestamp property. For example,
        /// if operatorName is *closedon* and the property's name is *closeDate*, then queries like
        /// *closedon:&amp;lt;value&amp;gt;* show results only where the value of the property named *closeDate* matches
        /// *&amp;lt;value&amp;gt;*. By contrast, a search that uses the same *&amp;lt;value&amp;gt;* without an
        /// operator returns all items where *&amp;lt;value&amp;gt;* matches the value of any String properties or text
        /// within the content field for the item. The operator name can only contain lowercase letters (a-z). The
        /// maximum length is 32 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatorName")]
        public virtual string OperatorName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The options for timestamp properties.</summary>
    public class TimestampPropertyOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If set, describes how the timestamp should be used as a search operator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatorOptions")]
        public virtual TimestampOperatorOptions OperatorOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of timestamp values.</summary>
    public class TimestampValues : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<object> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Tombstoning is the act of leaving a contextual trace when deleting a message. See more: go/tombstone-prd,
    /// go/hub-dynamite-tombstones-server-design-v2.
    /// </summary>
    public class TombstoneMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates the type of Tombstone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tombstoneType")]
        public virtual string TombstoneType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Toolbar markup has been deprecated. The information is now specified in the manifest.</summary>
    public class Toolbar : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Background color of the toolbar in RBG hex representation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual string Color { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("iconUrl")]
        public virtual string IconUrl { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TopicId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Space or DM that the topic belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupId")]
        public virtual GroupId GroupId { get; set; }

        /// <summary>
        /// Opaque, server-assigned ID of the Topic. While this ID is guaranteed to be unique within the Space, it's not
        /// guaranteed to be globally unique. Internal usage: this field can be empty in the following cases: 1. To
        /// create the first message in a topic. 2. To list last N messages of a Space (regardless of topic).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicId")]
        public virtual string TopicIdValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a transcription session.</summary>
    public class TranscriptionSessionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Transcription session's state information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionStateInfo")]
        public virtual SessionStateInfo SessionStateInfo { get; set; }

        /// <summary>A unique server-generated ID for the transcription session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transcriptionSessionId")]
        public virtual string TranscriptionSessionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Transient generic data that will not be saved on the server.</summary>
    public class TransientData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message containing a string that is safe to use in all URL contexts in DOM APIs and HTML documents; even where
    /// the referred-to resource is interpreted as code, e.g., as the src of a script element.
    /// </summary>
    public class TrustedResourceUrlProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// IMPORTANT: Never set or read this field, even from tests, it is private. See documentation at the top of
        /// .proto file for programming language packages with which to create or read this message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateDoNotAccessOrElseTrustedResourceUrlWrappedValue")]
        public virtual string PrivateDoNotAccessOrElseTrustedResourceUrlWrappedValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Next tag: 2</summary>
    public class TypeInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contains additional video information only if document_type is VIDEO.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoInfo")]
        public virtual VideoInfo VideoInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Universal phone access contains information required to dial into a conference using one of a static list of
    /// phone numbers and a universal PIN. The phone number list is distributed separately.
    /// </summary>
    public class UniversalPhoneAccess : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The PIN that users must enter after dialing a universal number. The pin consists of only decimal digits and
        /// the length may vary, though it generally is longer than a PhoneAccess.pin.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pin")]
        public virtual string Pin { get; set; }

        /// <summary>
        /// This field has the same contents as the MeetingSpace.more_join_url field, and is included for compatibility
        /// reasons. Clients should use the other field instead. This field is deprecated and will be removed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pstnInfoUrl")]
        public virtual string PstnInfoUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UnmappedIdentity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name for an external user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalIdentity")]
        public virtual Principal ExternalIdentity { get; set; }

        /// <summary>The resolution status for the external identity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolutionStatusCode")]
        public virtual string ResolutionStatusCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UnreserveItemsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of connector making this call. Format: datasources/{source_id}/connectors/{ID}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectorName")]
        public virtual string ConnectorName { get; set; }

        /// <summary>Common debug options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugOptions")]
        public virtual DebugOptions DebugOptions { get; set; }

        /// <summary>The name of a queue to unreserve items from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queue")]
        public virtual string Queue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UpdateDataSourceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Common debug options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugOptions")]
        public virtual DebugOptions DebugOptions { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual DataSource Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UpdateSchemaRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Common debug options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugOptions")]
        public virtual DebugOptions DebugOptions { get; set; }

        /// <summary>The new schema for the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual Schema Schema { get; set; }

        /// <summary>
        /// If true, the schema will be checked for validity, but will not be registered with the data source, even if
        /// valid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents an upload session reference. This reference is created via upload method. This reference is valid for
    /// 30 days after its creation. Updating of item content may refer to this uploaded content via contentDataRef.
    /// </summary>
    public class UploadItemRef : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the content reference. The maximum length is 2048 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotation metadata for user Upload artifacts.</summary>
    public class UploadMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Opaque token. Clients shall simply pass it back to the Backend. This field will NOT be saved into storage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachmentToken")]
        public virtual string AttachmentToken { get; set; }

        /// <summary>
        /// Information about the uploaded attachment that is only used in Backend. This field will NOT be sent out of
        /// Google.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backendUploadMetadata")]
        public virtual AppsDynamiteSharedBackendUploadMetadata BackendUploadMetadata { get; set; }

        /// <summary>
        /// The "new" secure identifier for Drive files. Should be used instead of the deprecated string drive_id field
        /// above. This should only be set if the upload file has been added to Drive. Note that older Drive files that
        /// do not have a ResourceKey should still use this field, with the resource_key field unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clonedAuthorizedItemId")]
        public virtual AuthorizedItemId ClonedAuthorizedItemId { get; set; }

        /// <summary>
        /// DriveAction for organizing the cloned version of this upload in Drive, if the file has been added to Drive.
        /// This field is not set if the file has not been added to Drive. Additionally, this field is only set when
        /// part of a FileResult in a ListFilesResponse.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clonedDriveAction")]
        public virtual string ClonedDriveAction { get; set; }

        /// <summary>
        /// Reference to a Drive ID, if this upload file has been previously cloned to Drive. Note: this is deprecated
        /// in favor of the AuthorizedItemId below.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clonedDriveId")]
        public virtual string ClonedDriveId { get; set; }

        /// <summary>The original file name for the content, not the full path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentName")]
        public virtual string ContentName { get; set; }

        /// <summary>
        /// Type is from Scotty's best_guess by default:
        /// http://google3/uploader/agent/scotty_agent.proto?l=51&amp;amp;rcl=140889785
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>The metrics metadata of the Data Loss Prevention attachment scan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dlpMetricsMetadata")]
        public virtual AppsDynamiteSharedDlpMetricsMetadata DlpMetricsMetadata { get; set; }

        /// <summary>A copy of the LocalId in Annotation. This field is supposed to be filled by server only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localId")]
        public virtual string LocalId { get; set; }

        /// <summary>Original dimension of the content. Only set for image attachments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalDimension")]
        public virtual AppsDynamiteSharedDimension OriginalDimension { get; set; }

        /// <summary>Reference to a transcoded video attachment. Only set for video attachments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoReference")]
        public virtual AppsDynamiteSharedVideoReference VideoReference { get; set; }

        /// <summary>
        /// Result for a virus scan. It's duplicated in the above field apps.dynamite.shared.BackendUploadMetadata
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("virusScanResult")]
        public virtual string VirusScanResult { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Annotation metadata for a Weblink. In case of pasted link it can qualify to be other types in addition to being
    /// a URL - like DRIVE_DOC/DRIVE_SHEET and so on. The URL metadata will also be present and it's up to the client to
    /// decide which metadata to render it with. These fields are filled in using page render service.
    /// </summary>
    public class UrlMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Domain for this url. If it's an IP address the address is returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>The signed GWS URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gwsUrl")]
        public virtual SafeUrlProto GwsUrl { get; set; }

        /// <summary>The expiration timestamp for GWS URL, only set when gws_url is set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gwsUrlExpirationTimestamp")]
        public virtual System.Nullable<long> GwsUrlExpirationTimestamp { get; set; }

        /// <summary>
        /// Dimensions of the image: height. This field is string to match with page render service response.
        /// Deprecated. Use int_image_height instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageHeight")]
        public virtual string ImageHeight { get; set; }

        /// <summary>Representative image of the website.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; }

        /// <summary>
        /// Dimensions of the image: width. This field is string to match with page render service response. Deprecated.
        /// Use int_image_height instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageWidth")]
        public virtual string ImageWidth { get; set; }

        /// <summary>Dimensions of the image: height.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intImageHeight")]
        public virtual System.Nullable<int> IntImageHeight { get; set; }

        /// <summary>Dimensions of the image: width.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intImageWidth")]
        public virtual System.Nullable<int> IntImageWidth { get; set; }

        /// <summary>
        /// Mime type of the content (Currently mapped from Page Render Service ItemType) Note that this is not
        /// necessarily the mime type of the http resource. For example a text/html from youtube or vimeo may actually
        /// be classified as a video type. Then we shall mark it as video/* since we don't know exactly what type of
        /// video it is.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The stable redirect URL pointing to frontend server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redirectUrl")]
        public virtual SafeUrlProto RedirectUrl { get; set; }

        /// <summary>
        /// If the UrlMetadata is missing data for rendering a chip. Deprecated. Use Annotation.ChipRenderType instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shouldNotRender")]
        public virtual System.Nullable<bool> ShouldNotRender { get; set; }

        /// <summary>Snippet/small description of the weblink.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual string Snippet { get; set; }

        /// <summary>Title of the Weblink.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The original URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual SafeUrlProto Url { get; set; }

        /// <summary>NEXT TAG : 17</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlSource")]
        public virtual string UrlSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>User profile information. This user is not necessarily member of a space.</summary>
    public class User : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URL for the avatar picture of the User in dynamite</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avatarUrl")]
        public virtual string AvatarUrl { get; set; }

        /// <summary>Information about whether the user is blocked by requester and/or has blocked requester.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockRelationship")]
        public virtual AppsDynamiteSharedUserBlockRelationship BlockRelationship { get; set; }

        /// <summary>Bot-specific profile information. Leave it empty for human users.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("botInfo")]
        public virtual BotInfo BotInfo { get; set; }

        /// <summary>
        /// Deleted flag, if true, means User has been soft-deleted/purged Deprecated. Use user_account_state field
        /// instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleted")]
        public virtual System.Nullable<bool> Deleted { get; set; }

        /// <summary>Email ID of the user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>First or given name of the user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstName")]
        public virtual string FirstName { get; set; }

        /// <summary>Gender of the user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gender")]
        public virtual string Gender { get; set; }

        /// <summary>UserId</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual UserId Id { get; set; }

        /// <summary>
        /// Set to true if none of the depending services (Gaia, PeopleApi) returns any info for this user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isAnonymous")]
        public virtual System.Nullable<bool> IsAnonymous { get; set; }

        /// <summary>Last or family name of the user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastName")]
        public virtual string LastName { get; set; }

        /// <summary>Non-unique, user-defined display name of the User</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Information about whether the user is a consumer user, or the GSuite customer that they belong to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organizationInfo")]
        public virtual AppsDynamiteSharedOrganizationInfo OrganizationInfo { get; set; }

        /// <summary>Phone number(s) of the user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual System.Collections.Generic.IList<AppsDynamiteSharedPhoneNumber> PhoneNumber { get; set; }

        /// <summary>State of user's Gaia Account</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAccountState")]
        public virtual string UserAccountState { get; set; }

        /// <summary>Visibility of user's Profile</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userProfileVisibility")]
        public virtual string UserProfileVisibility { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource for displaying user info</summary>
    public class UserDisplayInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The avatar to show for this user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avatarUrl")]
        public virtual string AvatarUrl { get; set; }

        /// <summary>The name to show for this user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Primary key for User resource.</summary>
    public class UserId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Opaque, server-assigned ID of the user profile associated with App/user acting on behalf of the
        /// human user. This is currently only set when a 3P application is acting on the user's behalf.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actingUserId")]
        public virtual string ActingUserId { get; set; }

        /// <summary>Opaque, server-assigned ID of the User.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Optional. Identifier of the App involved (directly or on behalf of a human creator) in creating this
        /// message. This is not set if the user posted a message directly, but is used in the case of, for example, a
        /// message being generated by a 1P integration based on a user action (creating an event, creating a task etc).
        /// This should only be used on the BE. For clients, please use the field in the FE message proto instead
        /// (google3/apps/dynamite/v1/frontend/api/message.proto?q=origin_app_id).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originAppId")]
        public virtual AppId OriginAppId { get; set; }

        /// <summary>
        /// Clients do not need to send UserType to Backend, but Backend will always send this field to clients per the
        /// following rule: 1. For HUMAN Ids, the field is empty but by default .getType() will return HUMAN. 2. For BOT
        /// Ids, the field is ALWAYS set to BOT.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains info regarding the updater of an Activity Feed item. Next Id: 8</summary>
    public class UserInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Avatar url of the user who triggered the Drive Notification email. This field will be populated if we can
        /// extract such information from the Drive Notification email. This should only be used to fetch user avatars
        /// when updater_to_show_email is not populated. This field is not set for non-Drive Notification items. This is
        /// not the actual sender of the email, as the sender is always comments-noreply@docs.google.com.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveNotificationAvatarUrl")]
        public virtual string DriveNotificationAvatarUrl { get; set; }

        /// <summary>Describes how updater_count_to_show should be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updaterCountDisplayType")]
        public virtual string UpdaterCountDisplayType { get; set; }

        /// <summary>The number of updaters for clients to show depending on UpdaterCountDisplayType.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updaterCountToShow")]
        public virtual System.Nullable<int> UpdaterCountToShow { get; set; }

        /// <summary>
        /// The email of the updater for clients to show used for Gmail items. For Drive Notifications, this is the
        /// email of the user who triggered the Drive Notification email. This field will be populated if we can extract
        /// such information from the Drive Notification email. This is not the actual sender of the email, as the
        /// sender is always comments-noreply@docs.google.com.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updaterToShowEmail")]
        public virtual string UpdaterToShowEmail { get; set; }

        /// <summary>
        /// The gaia id of the updater for clients to show used for Gmail items. If the updater is an external user, the
        /// email field below should be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updaterToShowGaiaId")]
        public virtual System.Nullable<long> UpdaterToShowGaiaId { get; set; }

        /// <summary>
        /// The display name of the updater for clients to show used for Gmail items. For non-Drive Notification items,
        /// this field will always be populated. If the display name cannot be found for the user, the fallback string
        /// will be the email address. For Drive Notification items, this is the email of the user who triggered the
        /// Drive notification email. This field will be populated if we can extract such information from the Drive
        /// Notification email. This is not the actual sender of the email, as the sender is always
        /// comments-noreply@docs.google.com.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updaterToShowName")]
        public virtual string UpdaterToShowName { get; set; }

        /// <summary>The updater for clients to show used for Dynamite Chat items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updaterToShowUserId")]
        public virtual UserId UpdaterToShowUserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Person metadata, for USER_MENTION segments. Should always contain at least one of user_gaia_id, user_id, email
    /// or user. The exact set of populated fields may differ depending on the context and the level in the serving
    /// stack; for example, emails will be elided on the viewing path. But as a general rule, a proto having any one of
    /// the four is valid, subject to the standard constraints of the applied annotations -- that is, communication
    /// between servers and clients will ignore jspb.ignore fields, and communication between servers and other servers
    /// (or between servers and storage) will ignore client_only fields. For more on the annotations, see the comments
    /// in social/common/segment_annotations.proto
    /// </summary>
    public class UserMentionData : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>
        /// If the principal is backed by a gaia id, DO NOT use this field. Use user_gaia_id/user_id fields instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual PrincipalProto User { get; set; }

        /// <summary>An unobfuscated gaia ID:</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userGaiaId")]
        public virtual System.Nullable<long> UserGaiaId { get; set; }

        /// <summary>An obfuscated gaia ID:</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotation metadata for user mentions (+/@/-).</summary>
    public class UserMentionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Display name of the mentioned user. This field should remain empty when clients resolve a UserMention
        /// annotation. It will be filled in when a UserMention is generated by the Integration Server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Gender of the mentioned user. One of "female", "male" or "other". Used for choosing accurate translations
        /// for strings that contain the UserMention, when these need to be constructed (e.g. task assignment update
        /// message). This field should remain empty when clients resolve a UserMention. It will be filled in when a
        /// UserMention is generated by the Integration Server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gender")]
        public virtual string Gender { get; set; }

        /// <summary>
        /// To be deprecated. Use invitee_info field instead. ID of the User mentioned. This field should remain empty
        /// when type == MENTION_ALL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual UserId Id { get; set; }

        /// <summary>
        /// Invitee UserId and email used when mentioned. This field should remain empty when type == MENTION_ALL.
        /// Invitee_info.email is only used when a user is @-mentioned with an email address, and it will be empty when
        /// clients get messages from Backend.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inviteeInfo")]
        public virtual InviteeInfo InviteeInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class VPCSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the GCP Project to be used for VPC SC policy check. VPC security settings on this
        /// project will be honored for Cloud Search APIs after project_name has been updated through CustomerService.
        /// Format: projects/{project_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Definition of a single value with generic type.</summary>
    public class Value : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("booleanValue")]
        public virtual System.Nullable<bool> BooleanValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("dateValue")]
        public virtual Date DateValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("integerValue")]
        public virtual System.Nullable<long> IntegerValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("timestampValue")]
        public virtual object TimestampValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ValueFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The `operator_name` applied to the query, such as *price_greater_than*. The filter can work against both
        /// types of filters defined in the schema for your data source: 1. `operator_name`, where the query filters
        /// results by the property that matches the value. 2. `greater_than_operator_name` or `less_than_operator_name`
        /// in your schema. The query filters the results for the property values that are greater than or less than the
        /// supplied value in the query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatorName")]
        public virtual string OperatorName { get; set; }

        /// <summary>The value to be compared with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual Value Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class VideoCallMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Thor meeting space.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meetingSpace")]
        public virtual MeetingSpace MeetingSpace { get; set; }

        /// <summary>
        /// If this field is set to true, server should still contact external backends to get metadata for search but
        /// clients should not render this chip.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shouldNotRender")]
        public virtual System.Nullable<bool> ShouldNotRender { get; set; }

        /// <summary>Whether this meeting space was created via Dynamite in this Dynamite group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wasCreatedInCurrentGroup")]
        public virtual System.Nullable<bool> WasCreatedInCurrentGroup { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Next tag: 2</summary>
    public class VideoInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Duration of the video in milliseconds. This field can be absent for recently uploaded video or inaccurate
        /// sometimes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual System.Nullable<int> Duration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents both long and short phone number that can be called or texted. Short telephone numbers are used to
    /// reach local services. Short numbers and their purpose differ from country to country. These numbers in US are in
    /// the form of N11 which is a three-digit abbreviated dialing telephone number.
    /// </summary>
    public class VoicePhoneNumber : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// E.164 formatted full phone number with leading +. This field also represents encoded form of short telephone
        /// numbers in E.164 format. e.g. "911" is encoded as "+1911".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("e164")]
        public virtual string E164 { get; set; }

        /// <summary>Additional data that could be added using the libphonenumber API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("i18nData")]
        public virtual VoicePhoneNumberI18nData I18nData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class VoicePhoneNumberI18nData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The country calling code for this number, as defined by the ITU. For example, this would be 1 for NANPA
        /// countries, and 33 for France (for more info see i18n.phonenumbers.PhoneNumber.country_code).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryCode")]
        public virtual System.Nullable<int> CountryCode { get; set; }

        /// <summary>Display number formatted using the INTERNATIONAL format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internationalNumber")]
        public virtual string InternationalNumber { get; set; }

        /// <summary>
        /// When present, indicates the number is valid according to the libphonenumber's isValidNumber API (see
        /// https://code.google.com/p/libphonenumber/).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isValid")]
        public virtual System.Nullable<bool> IsValid { get; set; }

        /// <summary>Display number formatted using the NATIONAL format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nationalNumber")]
        public virtual string NationalNumber { get; set; }

        /// <summary>
        /// A region (country, territory, continent, etc), as defined by Unicode's "CLDR", itself based on ISO 3166 (UN
        /// country codes). For details, see
        /// https://www.corp.google.com/~engdocs/java/com/google/i18n/identifiers/RegionCode.html
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>
        /// When set to a non-default value, indicates the validation reason that is set when phone number is invalid
        /// (is_valid is false).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validationResult")]
        public virtual string ValidationResult { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information on a whiteboard attached to an active conference. A whiteboard is a Jam document.</summary>
    public class WhiteboardInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Cosmo Id of the whiteboard document (Jam).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Title of the whiteboard document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The uri for whiteboard document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class WidgetMarkup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>buttons is also oneof data and only one of these fields should be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buttons")]
        public virtual System.Collections.Generic.IList<Button> Buttons { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("dateTimePicker")]
        public virtual DateTimePicker DateTimePicker { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("divider")]
        public virtual Divider Divider { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("grid")]
        public virtual Grid Grid { get; set; }

        /// <summary>The horizontal alignment of this widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("horizontalAlignment")]
        public virtual string HorizontalAlignment { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual Image Image { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("imageKeyValue")]
        public virtual ImageKeyValue ImageKeyValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("keyValue")]
        public virtual KeyValue KeyValue { get; set; }

        /// <summary>Input Widgets</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("menu")]
        public virtual Menu Menu { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("selectionControl")]
        public virtual SelectionControl SelectionControl { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("textField")]
        public virtual TextField TextField { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("textKeyValue")]
        public virtual TextKeyValue TextKeyValue { get; set; }

        /// <summary>Read-only Widgets</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textParagraph")]
        public virtual TextParagraph TextParagraph { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A wrapper around a raw resource key. The secret should never be logged, and this proto annotates those secret
    /// fields to ensure that they are not. Clients are encouraged to use this proto rather than defining their own, to
    /// ensure that secrets are correctly annotated.
    /// </summary>
    public class WrappedResourceKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Resource key of the Drive item. This field should be unset if, depending on the context, the item does not
        /// have a resource key, or if none was specified. This must never be logged.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceKey")]
        public virtual string ResourceKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a YouTube broadcast session.</summary>
    public class YouTubeBroadcastSessionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Current broadcast session's statistics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("broadcastStats")]
        public virtual YouTubeBroadcastStats BroadcastStats { get; set; }

        /// <summary>YouTube broadcast session's state information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionStateInfo")]
        public virtual SessionStateInfo SessionStateInfo { get; set; }

        /// <summary>A unique server-generated ID for the broadcast session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("youTubeBroadcastSessionId")]
        public virtual string YouTubeBroadcastSessionId { get; set; }

        /// <summary>The YouTube Live broadcast event that is being streamed to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("youTubeLiveBroadcastEvent")]
        public virtual YouTubeLiveBroadcastEvent YouTubeLiveBroadcastEvent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Statistics of the YouTube broadcast session.</summary>
    public class YouTubeBroadcastStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Estimated concurrent viewer count.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedViewerCount")]
        public virtual System.Nullable<long> EstimatedViewerCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the broadcast to YouTube.</summary>
    public class YouTubeLiveBroadcastEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Input only. The broadcast id, used to control the lifecycle of the event on YouTube</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("broadcastId")]
        public virtual string BroadcastId { get; set; }

        /// <summary>YouTube channel associated with the broadcast.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelId")]
        public virtual string ChannelId { get; set; }

        /// <summary>
        /// Output only. A URL that can be used to watch the meeting broadcast. Will be populated by the backend.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewUrl")]
        public virtual string ViewUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotation metadata for YouTube artifact.</summary>
    public class YoutubeMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>YouTube resource ID of the artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// If this field is set to true, server should still contact external backends to get metadata for search but
        /// clients should not render this chip.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shouldNotRender")]
        public virtual System.Nullable<bool> ShouldNotRender { get; set; }

        /// <summary>
        /// YouTube query parameter for timestamp. YouTube specific flag that allows users to embed time token when
        /// sharing a link. This property contains parsed time token in seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual System.Nullable<int> StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class YoutubeUserProto : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("youtubeUserId")]
        public virtual System.Nullable<long> YoutubeUserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>See go/zwieback. New uses of Zwieback sessions must be approved via go/zwieback-request.</summary>
    public class ZwiebackSessionProto : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("zwiebackSessionId")]
        public virtual System.Nullable<ulong> ZwiebackSessionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
