// Copyright 2023 Google LLC
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
        public override string BaseUri => BaseUriOverride ?? "https://cloudsearch.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://cloudsearch.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

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
            /// method, it returns `UNIMPLEMENTED`.
            /// </summary>
            /// <param name="name">The name of the operation's parent resource.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(service, name);
            }

            /// <summary>
            /// Lists operations that match the specified filter in the request. If the server doesn't support this
            /// method, it returns `UNIMPLEMENTED`.
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
        /// Provides functionality to remove logged activity for a user. Currently to be used only for dynamite 1p
        /// clients **Note:** This API requires a standard end user account to execute. A service account can't perform
        /// Remove Activity requests directly; to use a service account to perform queries, set up [Google Workspace
        /// domain-wide delegation of authority](https://developers.google.com/cloud-search/docs/guides/delegation/).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual RemoveActivityRequest RemoveActivity(Google.Apis.CloudSearch.v1.Data.RemoveActivityRequest body)
        {
            return new RemoveActivityRequest(service, body);
        }

        /// <summary>
        /// Provides functionality to remove logged activity for a user. Currently to be used only for dynamite 1p
        /// clients **Note:** This API requires a standard end user account to execute. A service account can't perform
        /// Remove Activity requests directly; to use a service account to perform queries, set up [Google Workspace
        /// domain-wide delegation of authority](https://developers.google.com/cloud-search/docs/guides/delegation/).
        /// </summary>
        public class RemoveActivityRequest : CloudSearchBaseServiceRequest<Google.Apis.CloudSearch.v1.Data.RemoveActivityResponse>
        {
            /// <summary>Constructs a new RemoveActivity request.</summary>
            public RemoveActivityRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSearch.v1.Data.RemoveActivityRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudSearch.v1.Data.RemoveActivityRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "removeActivity";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/query:removeActivity";

            /// <summary>Initializes RemoveActivity parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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

                /// <summary>
                /// Only applies to
                /// [`settings.datasources.patch`](https://developers.google.com/cloud-search/docs/reference/rest/v1/settings.datasources/patch).
                /// Update mask to control which fields to update. Example field paths: `name`, `displayName`. * If
                /// `update_mask` is non-empty, then only the fields specified in the `update_mask` are updated. * If
                /// you specify a field in the `update_mask`, but don't specify its value in the source, that field is
                /// cleared. * If the `update_mask` is not present or empty or has the value `*`, then all fields are
                /// updated.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

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

                /// <summary>
                /// Only applies to
                /// [`settings.searchapplications.patch`](https://developers.google.com/cloud-search/docs/reference/rest/v1/settings.searchapplications/patch).
                /// Update mask to control which fields to update. Example field paths: `search_application.name`,
                /// `search_application.displayName`. * If `update_mask` is non-empty, then only the fields specified in
                /// the `update_mask` are updated. * If you specify a field in the `update_mask`, but don't specify its
                /// value in the `search_application`, then that field is cleared. * If the `update_mask` is not present
                /// or empty or has the value `*`, then all fields are updated.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

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

                /// <summary>
                /// Only applies to
                /// [`settings.searchapplications.patch`](https://developers.google.com/cloud-search/docs/reference/rest/v1/settings.searchapplications/patch).
                /// Update mask to control which fields to update. Example field paths: `search_application.name`,
                /// `search_application.displayName`. * If `update_mask` is non-empty, then only the fields specified in
                /// the `update_mask` are updated. * If you specify a field in the `update_mask`, but don't specify its
                /// value in the `search_application`, then that field is cleared. * If the `update_mask` is not present
                /// or empty or has the value `*`, then all fields are updated.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

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

    public class Action : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Required] Title of the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>[Optional] Url of the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

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

    public class BackgroundColoredText : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Optional] Color of the background. The text color can change depending on the selected background color,
        /// and the client does not have control over this. If missing, the background will be WHITE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColor")]
        public virtual string BackgroundColor { get; set; }

        /// <summary>[Required] The text to display.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

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

    public class CheckAccessResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Returns true if principal has access. Returns false otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasAccess")]
        public virtual System.Nullable<bool> HasAccess { get; set; }

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

    public class Content : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Optional] Actions for this card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actions")]
        public virtual System.Collections.Generic.IList<Action> Actions { get; set; }

        /// <summary>[Optional] Description of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual SafeHtmlProto Description { get; set; }

        /// <summary>[Optional] Subtitle of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
        public virtual BackgroundColoredText Subtitle { get; set; }

        /// <summary>[Optional] Title of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual BackgroundColoredText Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Context : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Optional] App where the card should be shown. If missing, the card will be shown in TOPAZ.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("app")]
        public virtual System.Collections.Generic.IList<string> App { get; set; }

        /// <summary>[Optional] Day of week when the card should be shown, where 0 is Monday.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dayOfWeek")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> DayOfWeek { get; set; }

        /// <summary>
        /// [Optional] Date (in seconds since epoch) when the card should stop being shown. If missing, end_date_sec
        /// will be set to Jan 1st, 2100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDateSec")]
        public virtual System.Nullable<long> EndDateSec { get; set; }

        /// <summary>
        /// [Optional] End time in seconds, within a day, when the card should stop being shown if it's within
        /// [start_date_sec, end_date_sec]. If missing, this is set to 86400 (24 hours x 3600 sec/hour), i.e., midnight
        /// next day.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDayOffsetSec")]
        public virtual System.Nullable<long> EndDayOffsetSec { get; set; }

        /// <summary>
        /// [Optional] The locales for which the card should be triggered (e.g., en_US and en_CA). If missing, the card
        /// is going to show to clients regardless of their locale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual System.Collections.Generic.IList<string> Locale { get; set; }

        /// <summary>
        /// [Optional] Text-free locations where the card should be shown. This is expected to match the user's location
        /// in focus. If no location is specified, the card will be shown for any location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual System.Collections.Generic.IList<string> Location { get; set; }

        /// <summary>
        /// [Required only for Answer and RHS cards - will be ignored for Homepage] cards. It's the exact
        /// case-insensitive queries that will trigger the Answer or RHS card.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual System.Collections.Generic.IList<string> Query { get; set; }

        /// <summary>
        /// [Optional] Date (in seconds since epoch) when the card should start being shown. If missing, start_date_sec
        /// will be Jan 1st, 1970 UTC.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDateSec")]
        public virtual System.Nullable<long> StartDateSec { get; set; }

        /// <summary>
        /// [Optional] Start time in seconds, within a day, when the card should be shown if it's within
        /// [start_date_sec, end_date_sec]. If 0, the card will be shown from 12:00am on.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDayOffsetSec")]
        public virtual System.Nullable<long> StartDayOffsetSec { get; set; }

        /// <summary>
        /// [Optional] Surface where the card should be shown in. If missing, the card will be shown in any surface.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("surface")]
        public virtual System.Collections.Generic.IList<string> Surface { get; set; }

        /// <summary>[Required] Type of the card (homepage, Answer or RHS).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual System.Collections.Generic.IList<string> Type { get; set; }

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

    public class EnterpriseTopazFrontendTeamsLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The identifying link type</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual SafeUrlProto Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseTopazFrontendTeamsPersonCorePhoneNumber : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Phone number in no particular format (as comes from the Focus profile).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; }

        /// <summary>Phone number URL</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneUrl")]
        public virtual SafeUrlProto PhoneUrl { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An AgendaEntry, e.g., a Calendar Event.</summary>
    public class EnterpriseTopazSidekickAgendaEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URL of the agenda item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agendaItemUrl")]
        public virtual string AgendaItemUrl { get; set; }

        /// <summary>The chronology from the present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chronology")]
        public virtual string Chronology { get; set; }

        /// <summary>Person who created the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual EnterpriseTopazSidekickPerson Creator { get; set; }

        /// <summary>
        /// Attendance status for the current user making the request. This is a convenience data member in order to
        /// avoid figuring out the same by iterating the invitee list above on the caller side.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentUserAttendingStatus")]
        public virtual string CurrentUserAttendingStatus { get; set; }

        /// <summary>Description of the agenda item (i.e., typically, summary in calendar event).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Items related to the current AgendaEntry. E.g., related drive/mail/groups documents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual System.Collections.Generic.IList<EnterpriseTopazSidekickCommonDocument> Document { get; set; }

        /// <summary>End date "Friday, August 26" in the user's timezone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual string EndDate { get; set; }

        /// <summary>End time (HH:mm) in the user's timezone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual string EndTime { get; set; }

        /// <summary>End time in milliseconds</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTimeMs")]
        public virtual System.Nullable<long> EndTimeMs { get; set; }

        /// <summary>Event id provided by Calendar API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>Whether the guests can invite other guests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guestsCanInviteOthers")]
        public virtual System.Nullable<bool> GuestsCanInviteOthers { get; set; }

        /// <summary>Whether the guests can modify the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guestsCanModify")]
        public virtual System.Nullable<bool> GuestsCanModify { get; set; }

        /// <summary>
        /// Whether the guests of the event can be seen. If false, the user is going to be reported as the only attendee
        /// to the meeting, even though there may be more attendees.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guestsCanSeeGuests")]
        public virtual System.Nullable<bool> GuestsCanSeeGuests { get; set; }

        /// <summary>Hangout meeting identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hangoutId")]
        public virtual string HangoutId { get; set; }

        /// <summary>Absolute URL for the Hangout meeting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hangoutUrl")]
        public virtual string HangoutUrl { get; set; }

        /// <summary>People attending the meeting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invitee")]
        public virtual System.Collections.Generic.IList<EnterpriseTopazSidekickPerson> Invitee { get; set; }

        /// <summary>Whether the entry lasts all day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isAllDay")]
        public virtual System.Nullable<bool> IsAllDay { get; set; }

        /// <summary>Last time the event was modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModificationTimeMs")]
        public virtual System.Nullable<long> LastModificationTimeMs { get; set; }

        /// <summary>Agenda item location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Whether this should be notified to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notifyToUser")]
        public virtual System.Nullable<bool> NotifyToUser { get; set; }

        /// <summary>Whether guest list is not returned because number of attendees is too large.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otherAttendeesExcluded")]
        public virtual System.Nullable<bool> OtherAttendeesExcluded { get; set; }

        /// <summary>Whether the requester is the owner of the agenda entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requesterIsOwner")]
        public virtual System.Nullable<bool> RequesterIsOwner { get; set; }

        /// <summary>Whether the details of this entry should be displayed to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("showFullEventDetailsToUse")]
        public virtual System.Nullable<bool> ShowFullEventDetailsToUse { get; set; }

        /// <summary>Start date "Friday, August 26" in the user's timezone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual string StartDate { get; set; }

        /// <summary>Start time (HH:mm) in the user's timezone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTime { get; set; }

        /// <summary>Start time in milliseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeMs")]
        public virtual System.Nullable<long> StartTimeMs { get; set; }

        /// <summary>User's calendar timezone;</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>Title of the agenda item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseTopazSidekickAgendaGroupCardProto : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("agendaItem")]
        public virtual System.Collections.Generic.IList<EnterpriseTopazSidekickAgendaItem> AgendaItem { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual EnterpriseTopazSidekickAgendaGroupCardProtoContext Context { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("currentAgendaItem")]
        public virtual EnterpriseTopazSidekickAgendaItem CurrentAgendaItem { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The context that resulted in the generation of the card.</summary>
    public class EnterpriseTopazSidekickAgendaGroupCardProtoContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// User friendly free text that describes the context of the card (e.g. "Next meeting with Bob"). This is
        /// largely only applicable when the card is generated from a query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual string Context { get; set; }

        /// <summary>
        /// Localized free text that describes the dates represented by the card. Currently, the card will only
        /// represent a single day.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual string Date { get; set; }

        /// <summary>Represents restrictions applied to the events requested in the user's query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventsRestrict")]
        public virtual string EventsRestrict { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseTopazSidekickAgendaItem : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("conflictedGroup")]
        public virtual EnterpriseTopazSidekickConflictingEventsCardProto ConflictedGroup { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("gapBefore")]
        public virtual EnterpriseTopazSidekickGap GapBefore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("meeting")]
        public virtual EnterpriseTopazSidekickAgendaEntry Meeting { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of answers represented as free text.</summary>
    public class EnterpriseTopazSidekickAnswerAnswerList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Answers that have a corresponding label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labeledAnswer")]
        public virtual System.Collections.Generic.IList<EnterpriseTopazSidekickAnswerAnswerListLabeledAnswer> LabeledAnswer { get; set; }

        /// <summary>Answer type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An answer with a corresponding label.</summary>
    public class EnterpriseTopazSidekickAnswerAnswerListLabeledAnswer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The free text answer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("answer")]
        public virtual string Answer { get; set; }

        /// <summary>A localized label for the answer (e.g. "Cell phone" vs "Desk phone").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains a list of suggested queries. Allows the user to determine what natural language queries they can ask
    /// Cloud Search (e.g. "what can I search for?").
    /// </summary>
    public class EnterpriseTopazSidekickAnswerSuggestedQueryAnswerCard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of queries to suggest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedQueryCategory")]
        public virtual System.Collections.Generic.IList<EnterpriseTopazSidekickAnswerSuggestedQueryCategory> SuggestedQueryCategory { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains a list of suggested queries for a single category.</summary>
    public class EnterpriseTopazSidekickAnswerSuggestedQueryCategory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The query list category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>Whether this category is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isEnabled")]
        public virtual System.Nullable<bool> IsEnabled { get; set; }

        /// <summary>List of suggested queries to show the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual System.Collections.Generic.IList<string> Query { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Wrapper proto for the Assist cards.</summary>
    public class EnterpriseTopazSidekickAssistCardProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Agenda group card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agendaGroupCardProto")]
        public virtual EnterpriseTopazSidekickAgendaGroupCardProto AgendaGroupCardProto { get; set; }

        /// <summary>Card metadata such as chronology and render mode of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardMetadata")]
        public virtual EnterpriseTopazSidekickCardMetadata CardMetadata { get; set; }

        /// <summary>Card type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardType")]
        public virtual string CardType { get; set; }

        /// <summary>Conflicting events card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conflictingMeetingsCard")]
        public virtual EnterpriseTopazSidekickConflictingEventsCardProto ConflictingMeetingsCard { get; set; }

        /// <summary>Answer card for documents that are applicable to the current query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentListCard")]
        public virtual EnterpriseTopazSidekickDocumentPerCategoryList DocumentListCard { get; set; }

        /// <summary>Documents with mentions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentsWithMentions")]
        public virtual EnterpriseTopazSidekickDocumentPerCategoryList DocumentsWithMentions { get; set; }

        /// <summary>Find meeting time card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("findMeetingTimeCard")]
        public virtual EnterpriseTopazSidekickFindMeetingTimeCardProto FindMeetingTimeCard { get; set; }

        /// <summary>Generic answer card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("genericAnswerCard")]
        public virtual EnterpriseTopazSidekickGenericAnswerCard GenericAnswerCard { get; set; }

        /// <summary>Get and keep ahead card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("getAndKeepAheadCard")]
        public virtual EnterpriseTopazSidekickGetAndKeepAheadCardProto GetAndKeepAheadCard { get; set; }

        /// <summary>Meeting card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meeting")]
        public virtual EnterpriseTopazSidekickAgendaEntry Meeting { get; set; }

        /// <summary>Meeting notes card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meetingNotesCard")]
        public virtual EnterpriseTopazSidekickMeetingNotesCardProto MeetingNotesCard { get; set; }

        /// <summary>Request for meeting notes card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meetingNotesCardRequest")]
        public virtual EnterpriseTopazSidekickMeetingNotesCardRequest MeetingNotesCardRequest { get; set; }

        /// <summary>The people disambiguation card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peopleDisambiguationCard")]
        public virtual EnterpriseTopazSidekickPeopleDisambiguationCard PeopleDisambiguationCard { get; set; }

        /// <summary>People Search promotion card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peoplePromotionCard")]
        public virtual PeoplePromotionCard PeoplePromotionCard { get; set; }

        /// <summary>Answer card that represents a single person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personAnswerCard")]
        public virtual EnterpriseTopazSidekickPeopleAnswerPersonAnswerCard PersonAnswerCard { get; set; }

        /// <summary>Full profile card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personProfileCard")]
        public virtual EnterpriseTopazSidekickPersonProfileCard PersonProfileCard { get; set; }

        /// <summary>Card with recommended documents for the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personalizedDocsCard")]
        public virtual EnterpriseTopazSidekickPersonalizedDocsCardProto PersonalizedDocsCard { get; set; }

        /// <summary>Answer card that represents a list of people related to a person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedPeopleAnswerCard")]
        public virtual EnterpriseTopazSidekickPeopleAnswerRelatedPeopleAnswerCard RelatedPeopleAnswerCard { get; set; }

        /// <summary>Sahre meeting docs card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shareMeetingDocsCard")]
        public virtual EnterpriseTopazSidekickShareMeetingDocsCardProto ShareMeetingDocsCard { get; set; }

        /// <summary>Shared documents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sharedDocuments")]
        public virtual EnterpriseTopazSidekickDocumentPerCategoryList SharedDocuments { get; set; }

        /// <summary>Answer card for what natural language queries the user can ask.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedQueryAnswerCard")]
        public virtual EnterpriseTopazSidekickAnswerSuggestedQueryAnswerCard SuggestedQueryAnswerCard { get; set; }

        /// <summary>Third party answer cards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thirdPartyAnswerCard")]
        public virtual ThirdPartyGenericCard ThirdPartyAnswerCard { get; set; }

        /// <summary>Work In Progress card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workInProgressCardProto")]
        public virtual EnterpriseTopazSidekickRecentDocumentsCardProto WorkInProgressCardProto { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Card metadata.</summary>
    public class EnterpriseTopazSidekickCardMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Declares a preference for how this card should be packed in MSCR. All cards in a response must correspond to
        /// a single category. As a result, cards may be dropped from the response if this field is set. Any card that
        /// does not match the category of the card with the highest priority in the response will be dropped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardCategory")]
        public virtual string CardCategory { get; set; }

        /// <summary>
        /// An ID to identify the card and match actions to it. Be thoughtful of new card IDs since actions will be
        /// associated to that ID. E.g., if two card IDs collide, the system will think that the actions have been
        /// applied to the same card. Similarly, if EAS can return multiple cards of the same type (e.g., Meetings),
        /// ensure that the card_id identifies a given instance of the card so that, e.g., dismissals only affect the
        /// dismissed card as opposed to affecting all meeting cards.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardId")]
        public virtual string CardId { get; set; }

        /// <summary>Chronology.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chronology")]
        public virtual string Chronology { get; set; }

        /// <summary>Debug info (only reported if request's debug_level &gt; 0).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugInfo")]
        public virtual string DebugInfo { get; set; }

        /// <summary>Information about the NLP done to get the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nlpMetadata")]
        public virtual EnterpriseTopazSidekickNlpMetadata NlpMetadata { get; set; }

        /// <summary>Ranking params.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rankingParams")]
        public virtual EnterpriseTopazSidekickRankingParams RankingParams { get; set; }

        /// <summary>Render mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renderMode")]
        public virtual string RenderMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Container of debugging information in all object levels. Extend as needed.</summary>
    public class EnterpriseTopazSidekickCommonDebugInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Debug message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of a document. NEXT_TAG: 15</summary>
    public class EnterpriseTopazSidekickCommonDocument : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Access type, i.e., whether the user has access to the document or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessType")]
        public virtual string AccessType { get; set; }

        /// <summary>Information for debugging.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugInfo")]
        public virtual EnterpriseTopazSidekickCommonDebugInfo DebugInfo { get; set; }

        /// <summary>Document id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
        public virtual string DocumentId { get; set; }

        /// <summary>Drive document metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveDocumentMetadata")]
        public virtual EnterpriseTopazSidekickCommonDocumentDriveDocumentMetadata DriveDocumentMetadata { get; set; }

        /// <summary>Generic Drive-based url in the format of drive.google.com/open to be used for deeplink</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("genericUrl")]
        public virtual string GenericUrl { get; set; }

        /// <summary>Justification on why the document is selected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("justification")]
        public virtual EnterpriseTopazSidekickCommonDocumentJustification Justification { get; set; }

        /// <summary>MIME type</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>Document provenance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual string Provenance { get; set; }

        /// <summary>Justification of why this document is being returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>A sampling of the text from the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual string Snippet { get; set; }

        /// <summary>Thumbnail URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnailUrl")]
        public virtual string ThumbnailUrl { get; set; }

        /// <summary>Title of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>Type of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Absolute URL of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Meta data for drive documents.</summary>
    public class EnterpriseTopazSidekickCommonDocumentDriveDocumentMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The drive document cosmo id. Client could use the id to build a URL to open a document. Please use
        /// Document.document_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
        public virtual string DocumentId { get; set; }

        /// <summary>
        /// Additional field to identify whether a document is private since scope set to LIMITED can mean both that the
        /// doc is private or that it's shared with others. is_private indicates whether the doc is not shared with
        /// anyone except for the owner.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPrivate")]
        public virtual System.Nullable<bool> IsPrivate { get; set; }

        /// <summary>Timestamp of the most recent comment added to the document in milliseconds since epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastCommentTimeMs")]
        public virtual System.Nullable<ulong> LastCommentTimeMs { get; set; }

        /// <summary>Timestamp of the most recent edit from the current user in milliseconds since epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastEditTimeMs")]
        public virtual System.Nullable<ulong> LastEditTimeMs { get; set; }

        /// <summary>Last modification time of the document (independent of the user that modified it).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModificationTimeMillis")]
        public virtual System.Nullable<long> LastModificationTimeMillis { get; set; }

        /// <summary>Timestamp of the last updated time of the document in milliseconds since epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdatedTimeMs")]
        public virtual System.Nullable<ulong> LastUpdatedTimeMs { get; set; }

        /// <summary>Timestamp of the most recent view from the current user in milliseconds since epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastViewTimeMs")]
        public virtual System.Nullable<ulong> LastViewTimeMs { get; set; }

        /// <summary>The owner of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("owner")]
        public virtual EnterpriseTopazSidekickCommonPerson Owner { get; set; }

        /// <summary>
        /// ACL scope of the document which identifies the sharing status of the doc (e.g., limited, shared with link,
        /// team drive, ...).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Justification of why we are reporting the document.</summary>
    public class EnterpriseTopazSidekickCommonDocumentJustification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A locale aware message that explains why this document was selected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("justification")]
        public virtual string Justification { get; set; }

        /// <summary>Reason on why the document is selected. Populate for trending documents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Common representation of a person.</summary>
    public class EnterpriseTopazSidekickCommonPerson : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The birthday.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("birthday")]
        public virtual EnterpriseTopazSidekickCommonPersonBirthday Birthday { get; set; }

        /// <summary>Cell phone number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cellPhone")]
        public virtual string CellPhone { get; set; }

        /// <summary>The department the person works in (e.g. Engineering).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("department")]
        public virtual string Department { get; set; }

        /// <summary>Desk location (e.g. US-MTV-PR55-5-5B1I).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deskLocation")]
        public virtual string DeskLocation { get; set; }

        /// <summary>Work desk phone number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deskPhone")]
        public virtual string DeskPhone { get; set; }

        /// <summary>The full name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Email.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The last name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("familyName")]
        public virtual string FamilyName { get; set; }

        /// <summary>The fully formatted address (e.g. 1255 Pear Avenue, Mountain View 94043, United States).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullAddress")]
        public virtual string FullAddress { get; set; }

        /// <summary>This field is deprecated. The obfuscated_id should be used instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gaiaId")]
        public virtual System.Nullable<long> GaiaId { get; set; }

        /// <summary>The first name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("givenName")]
        public virtual string GivenName { get; set; }

        /// <summary>The person's job title (e.g. Software Engineer).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobTitle")]
        public virtual string JobTitle { get; set; }

        /// <summary>The manager.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manager")]
        public virtual EnterpriseTopazSidekickCommonPerson Manager { get; set; }

        /// <summary>The obfuscated GAIA ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("obfuscatedId")]
        public virtual string ObfuscatedId { get; set; }

        /// <summary>The URL for the Focus profile picture.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("photoUrl")]
        public virtual string PhotoUrl { get; set; }

        /// <summary>The street address (e.g. 1255 Pear Avenue).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streetAddress")]
        public virtual string StreetAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseTopazSidekickCommonPersonBirthday : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unstructured birthday.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Conflicting meetings card proto.</summary>
    public class EnterpriseTopazSidekickConflictingEventsCardProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All the events that conflict with main_event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conflictingEvent")]
        public virtual System.Collections.Generic.IList<EnterpriseTopazSidekickAgendaEntry> ConflictingEvent { get; set; }

        /// <summary>The event identified as being the most important.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mainEvent")]
        public virtual EnterpriseTopazSidekickAgendaEntry MainEvent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a mapping between a document type and its corresponding documents. Use for Work in Progress card in
    /// v1 homepage.
    /// </summary>
    public class EnterpriseTopazSidekickDocumentGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Document group type</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupType")]
        public virtual string GroupType { get; set; }

        /// <summary>The list of corresponding documents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personalizedDocument")]
        public virtual System.Collections.Generic.IList<EnterpriseTopazSidekickCommonDocument> PersonalizedDocument { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseTopazSidekickDocumentPerCategoryList : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("documents")]
        public virtual System.Collections.Generic.IList<EnterpriseTopazSidekickDocumentPerCategoryListDocumentPerCategoryListEntry> Documents { get; set; }

        /// <summary>
        /// Localized message explaining how the documents were derived (e.g. from the last 30 days activity). This
        /// field is optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("helpMessage")]
        public virtual string HelpMessage { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("listType")]
        public virtual string ListType { get; set; }

        /// <summary>Description of the types of documents present in the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listTypeDescription")]
        public virtual string ListTypeDescription { get; set; }

        /// <summary>Response message in case no documents are present in the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseMessage")]
        public virtual string ResponseMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseTopazSidekickDocumentPerCategoryListDocumentPerCategoryListEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual EnterpriseTopazSidekickCommonDocument Document { get; set; }

        /// <summary>Reason this document was selected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rationale")]
        public virtual string Rationale { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to find meeting time among a set of people.</summary>
    public class EnterpriseTopazSidekickFindMeetingTimeCardProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Slots when all attendees have availability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonAvailableTimeSlots")]
        public virtual System.Collections.Generic.IList<EnterpriseTopazSidekickTimeSlot> CommonAvailableTimeSlots { get; set; }

        /// <summary>Invitees to the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invitees")]
        public virtual System.Collections.Generic.IList<EnterpriseTopazSidekickPerson> Invitees { get; set; }

        /// <summary>Requester.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requester")]
        public virtual EnterpriseTopazSidekickPerson Requester { get; set; }

        /// <summary>Details about the scheduled meeting, if one exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduledMeeting")]
        public virtual EnterpriseTopazSidekickScheduledMeeting ScheduledMeeting { get; set; }

        /// <summary>Invitees that have been skipped in the computation, most likely because they are groups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skippedInvitees")]
        public virtual System.Collections.Generic.IList<EnterpriseTopazSidekickPerson> SkippedInvitees { get; set; }

        /// <summary>Min and max timestamp used to find a common available timeslot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeBoundaries")]
        public virtual EnterpriseTopazSidekickTimeSlot TimeBoundaries { get; set; }

        /// <summary>Timezone ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timezoneId")]
        public virtual string TimezoneId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseTopazSidekickGap : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Localized time string in the format: 1 hour 15 minutes</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayRemainingTime")]
        public virtual string DisplayRemainingTime { get; set; }

        /// <summary>Localized time string in the format:(Locale CZ) 8:30 odp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual string EndTime { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("endTimeMs")]
        public virtual System.Nullable<ulong> EndTimeMs { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("remainingTime")]
        public virtual object RemainingTime { get; set; }

        /// <summary>Localized time string in the format:(Locale CZ) 8:30 odp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTime { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("startTimeMs")]
        public virtual System.Nullable<ulong> StartTimeMs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseTopazSidekickGenericAnswerCard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The answer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("answer")]
        public virtual string Answer { get; set; }

        /// <summary>Title or header of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Get and keep ahead card</summary>
    public class EnterpriseTopazSidekickGetAndKeepAheadCardProto : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("declinedEvents")]
        public virtual EnterpriseTopazSidekickGetAndKeepAheadCardProtoDeclinedEvents DeclinedEvents { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("mentionedDocuments")]
        public virtual EnterpriseTopazSidekickDocumentPerCategoryList MentionedDocuments { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sharedDocuments")]
        public virtual EnterpriseTopazSidekickDocumentPerCategoryList SharedDocuments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of events where all guests declined.</summary>
    public class EnterpriseTopazSidekickGetAndKeepAheadCardProtoDeclinedEvents : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("events")]
        public virtual System.Collections.Generic.IList<EnterpriseTopazSidekickAgendaEntry> Events { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Errors in the creation of meeting notes.</summary>
    public class EnterpriseTopazSidekickMeetingNotesCardError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description of the reason why create-meeting-notes failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The event to request meeting notes creation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("event")]
        public virtual EnterpriseTopazSidekickAgendaEntry Event__ { get; set; }

        /// <summary>The reason why create-meeting-notes failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the meeting notes created.</summary>
    public class EnterpriseTopazSidekickMeetingNotesCardProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The event to request meeting notes creation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("event")]
        public virtual EnterpriseTopazSidekickAgendaEntry Event__ { get; set; }

        /// <summary>Google Drive ID (a.k.a. resource ID) of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileId")]
        public virtual string FileId { get; set; }

        /// <summary>Title we want to show for meeting notes in the answer card</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>New URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Meeting notes card request.</summary>
    public class EnterpriseTopazSidekickMeetingNotesCardRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Who are the meeting notes created for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canCreateFor")]
        public virtual System.Collections.Generic.IList<string> CanCreateFor { get; set; }

        /// <summary>The error and reason if known error occured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual EnterpriseTopazSidekickMeetingNotesCardError Error { get; set; }

        /// <summary>The event to request meeting notes creation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("event")]
        public virtual EnterpriseTopazSidekickAgendaEntry Event__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about the NLP interpretation of the query.</summary>
    public class EnterpriseTopazSidekickNlpMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Confidence of the interpretation that generated this card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for disambiguation.</summary>
    public class EnterpriseTopazSidekickPeopleAnswerDisambiguationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of people that also matched the query. This list is not complete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disambiguation")]
        public virtual System.Collections.Generic.IList<EnterpriseTopazSidekickPeopleAnswerDisambiguationInfoDisambiguationPerson> Disambiguation { get; set; }

        /// <summary>
        /// The name that was extracted from the query. This may be in the form of the given name, last name, full name,
        /// LDAP, or email address. This name can be considered suitable for displaying to the user and can largely be
        /// considered to be normalized (e.g. "Bob's" -&amp;gt; "Bob").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A person that also matches the query, but was not selected due to a lower affinity with the requesting user.
    /// </summary>
    public class EnterpriseTopazSidekickPeopleAnswerDisambiguationInfoDisambiguationPerson : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The profile of this person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("person")]
        public virtual EnterpriseTopazSidekickCommonPerson Person { get; set; }

        /// <summary>
        /// The query that can be used to produce an answer card with the same attribute, but for this person.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Recommended header to display for the card.</summary>
    public class EnterpriseTopazSidekickPeopleAnswerPeopleAnswerCardHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The suggested title to display. This defaults to the user's query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An answer card for a single person.</summary>
    public class EnterpriseTopazSidekickPeopleAnswerPersonAnswerCard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of answers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("answer")]
        public virtual System.Collections.Generic.IList<SafeHtmlProto> Answer { get; set; }

        /// <summary>List of answers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("answerText")]
        public virtual EnterpriseTopazSidekickAnswerAnswerList AnswerText { get; set; }

        /// <summary>Disambiguation information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disambiguationInfo")]
        public virtual EnterpriseTopazSidekickPeopleAnswerDisambiguationInfo DisambiguationInfo { get; set; }

        /// <summary>The header to display for the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual EnterpriseTopazSidekickPeopleAnswerPeopleAnswerCardHeader Header { get; set; }

        /// <summary>The response status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseStatus")]
        public virtual string ResponseStatus { get; set; }

        /// <summary>
        /// Localized user friendly message to display to the user in the case of missing data or an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>The profile of the person that was the subject of the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subject")]
        public virtual EnterpriseTopazSidekickCommonPerson Subject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An answer card for a list of people that are related to the subject of the query.</summary>
    public class EnterpriseTopazSidekickPeopleAnswerRelatedPeopleAnswerCard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Disambiguation information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disambiguationInfo")]
        public virtual EnterpriseTopazSidekickPeopleAnswerDisambiguationInfo DisambiguationInfo { get; set; }

        /// <summary>The header to display for the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual EnterpriseTopazSidekickPeopleAnswerPeopleAnswerCardHeader Header { get; set; }

        /// <summary>A list of people that are related to the query subject.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedPeople")]
        public virtual System.Collections.Generic.IList<EnterpriseTopazSidekickCommonPerson> RelatedPeople { get; set; }

        /// <summary>Defines the type of relation the list of people have with the subject of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relationType")]
        public virtual string RelationType { get; set; }

        /// <summary>The response status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseStatus")]
        public virtual string ResponseStatus { get; set; }

        /// <summary>
        /// Localized user friendly message to display to the user in the case of missing data or an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>The profile of the person that was the subject of the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subject")]
        public virtual EnterpriseTopazSidekickCommonPerson Subject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseTopazSidekickPeopleDisambiguationCard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Candidate persons for the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("person")]
        public virtual System.Collections.Generic.IList<EnterpriseTopazSidekickCommonPerson> Person { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Person.</summary>
    public class EnterpriseTopazSidekickPerson : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The level of affinity this person has with the requesting user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("affinityLevel")]
        public virtual string AffinityLevel { get; set; }

        /// <summary>Attendance status of the person when included in a meeting event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attendingStatus")]
        public virtual string AttendingStatus { get; set; }

        /// <summary>Email.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>Gaia id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gaiaId")]
        public virtual System.Nullable<long> GaiaId { get; set; }

        /// <summary>Whether the invitee is a group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isGroup")]
        public virtual System.Nullable<bool> IsGroup { get; set; }

        /// <summary>Name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Obfuscated Gaia id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("obfuscatedGaiaId")]
        public virtual string ObfuscatedGaiaId { get; set; }

        /// <summary>Absolute URL to the profile photo of the person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("photoUrl")]
        public virtual string PhotoUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseTopazSidekickPersonProfileCard : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("relatedPeople")]
        public virtual System.Collections.Generic.IList<EnterpriseTopazSidekickPersonProfileCardRelatedPeople> RelatedPeople { get; set; }

        /// <summary>The subject of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subject")]
        public virtual EnterpriseTopazSidekickCommonPerson Subject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseTopazSidekickPersonProfileCardRelatedPeople : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Related people.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedPerson")]
        public virtual System.Collections.Generic.IList<EnterpriseTopazSidekickCommonPerson> RelatedPerson { get; set; }

        /// <summary>Relation type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relation")]
        public virtual string Relation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Personalized docs card proto.</summary>
    public class EnterpriseTopazSidekickPersonalizedDocsCardProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Document group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentGroup")]
        public virtual System.Collections.Generic.IList<EnterpriseTopazSidekickDocumentGroup> DocumentGroup { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Ranking params.</summary>
    public class EnterpriseTopazSidekickRankingParams : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The end-time that this object will expect to occur. If the type is marked as FIXED, then this end-time will
        /// persist after bidding. If the type is marked as FLEXIBLE, this field is NOT expected to be filled and will
        /// be filled in after it has won a bid. Expected to be set when type is set to FIXED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTimeMs")]
        public virtual System.Nullable<ulong> EndTimeMs { get; set; }

        /// <summary>
        /// The priority to determine between objects that have the same start_time_ms The lower-value of priority ==
        /// ranked higher. Max-priority = 0. Expected to be set for all types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual string Priority { get; set; }

        /// <summary>The score of the card to be used to break priority-ties</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>
        /// The span that this card will take in the stream Expected to be set when type is set to FLEXIBLE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spanMs")]
        public virtual System.Nullable<ulong> SpanMs { get; set; }

        /// <summary>
        /// The start-time that this object will bid-for If the type is marked as FIXED, then this start-time will
        /// persist after bidding. If the type is marked as FLEXIBLE, then it will occur at the given time or sometime
        /// after the requested time. Expected to be set for all types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeMs")]
        public virtual System.Nullable<ulong> StartTimeMs { get; set; }

        /// <summary>The packing type of this object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseTopazSidekickRecentDocumentsCardProto : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual System.Collections.Generic.IList<EnterpriseTopazSidekickCommonDocument> Document { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about scheduled meetings.</summary>
    public class EnterpriseTopazSidekickScheduledMeeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The meeting location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meetingLocation")]
        public virtual string MeetingLocation { get; set; }

        /// <summary>The meeting time slot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meetingTime")]
        public virtual EnterpriseTopazSidekickTimeSlot MeetingTime { get; set; }

        /// <summary>The meeting title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meetingTitle")]
        public virtual string MeetingTitle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Share meeting docs card proto.</summary>
    public class EnterpriseTopazSidekickShareMeetingDocsCardProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Documents to share for the given meeting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual System.Collections.Generic.IList<EnterpriseTopazSidekickCommonDocument> Document { get; set; }

        /// <summary>Event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("event")]
        public virtual EnterpriseTopazSidekickAgendaEntry Event__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Slot of time.</summary>
    public class EnterpriseTopazSidekickTimeSlot : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Day end time at the user's timezone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTimeDay")]
        public virtual string EndTimeDay { get; set; }

        /// <summary>Hour and minute of the end time at the user's timezone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTimeHourAndMinute")]
        public virtual string EndTimeHourAndMinute { get; set; }

        /// <summary>End time in milliseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTimeInMillis")]
        public virtual System.Nullable<long> EndTimeInMillis { get; set; }

        /// <summary>Day start time at user's timezone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeDay")]
        public virtual string StartTimeDay { get; set; }

        /// <summary>Hour and minute of the start time at the user's timezone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeHourAndMinute")]
        public virtual string StartTimeHourAndMinute { get; set; }

        /// <summary>Start time in milliseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeInMillis")]
        public virtual System.Nullable<long> StartTimeInMillis { get; set; }

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

        /// <summary>Filter to be passed in the search request if the corresponding bucket is selected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual Filter Filter { get; set; }

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
        /// If set, describes integer faceting options for the given integer property. The corresponding integer
        /// property in the schema should be marked isFacetable. The number of buckets returned would be minimum of this
        /// and num_facet_buckets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integerFacetingOptions")]
        public virtual IntegerFacetingOptions IntegerFacetingOptions { get; set; }

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

    /// <summary>
    /// Identifies a particular object, including both Users and DirEntries. This Id is unique across the entire server
    /// instance, such as the production or qa instance.
    /// </summary>
    public class Id : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The User account in which the DirEntry was originally created. If name_space==GAIA, then it's the gaia_id of
        /// the user this id is referring to. This field should really be called the "bucket ID", not the creator ID. In
        /// some circumstances, such as copying a Google Docs file, a user can create an item in a different user's
        /// bucket, so it should not be relied upon for anything other than bucket location. To look up the requesting
        /// user who initially created item, use the `creator_id` DirEntry field instead.
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

    /// <summary>Used to specify integer faceting options.</summary>
    public class IntegerFacetingOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Buckets for given integer values should be in strictly ascending order. For example, if values supplied are
        /// (1,5,10,100), the following facet buckets will be formed {&amp;lt;1, [1,5), [5-10), [10-100), &amp;gt;=100}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integerBuckets")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> IntegerBuckets { get; set; }

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
        /// If set, describes integer faceting options for the given integer property. The corresponding integer
        /// property should be marked isFacetable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integerFacetingOptions")]
        public virtual IntegerFacetingOptions IntegerFacetingOptions { get; set; }

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

    /// <summary>Geo information used for rendering a map that shows the user's work location.</summary>
    public class MapInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Latitude in degrees</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lat")]
        public virtual System.Nullable<double> Lat { get; set; }

        /// <summary>
        /// URL to a view of a map centered on the user's work location in Campus Maps (for google.com) or Google Maps
        /// (external).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationUrl")]
        public virtual SafeUrlProto LocationUrl { get; set; }

        /// <summary>Longitude in degrees</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("long")]
        public virtual System.Nullable<double> Long__ { get; set; }

        /// <summary>MapTiles for the area around a user's work location</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mapTile")]
        public virtual System.Collections.Generic.IList<MapTile> MapTile { get; set; }

        /// <summary>
        /// The zoom level of the map. A constant zoom value of 18 is used for now to match the zoom of the map shown on
        /// a Moma Teams Profile page
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zoom")]
        public virtual System.Nullable<int> Zoom { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information used to render a map tile image in the proper location on a map.</summary>
    public class MapTile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// URL to an image file containing an office layout of the user's location for their organization, if one is
        /// available. For google.com, this image is from Corp Campus Maps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual SafeUrlProto ImageUrl { get; set; }

        /// <summary>Map tile x coordinate</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tileX")]
        public virtual System.Nullable<double> TileX { get; set; }

        /// <summary>Map tile y coordinate</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tileY")]
        public virtual System.Nullable<double> TileY { get; set; }

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

    /// <summary>Media resource.</summary>
    public class Media : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the media resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

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

    public class PeoplePromotionCard : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("people")]
        public virtual System.Collections.Generic.IList<PersonCore> People { get; set; }

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

    /// <summary>Information for rendering a person. NEXT ID: 37</summary>
    public class PersonCore : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Instructions for how to address this person (e.g. custom pronouns). For google.com this is a set of pronouns
        /// from a defined list of options.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressMeAs")]
        public virtual string AddressMeAs { get; set; }

        /// <summary>
        /// People the profile owner is an admin to. Note that not all fields of these PersonCores will be set, in
        /// particular, relationships will be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminTo")]
        public virtual System.Collections.Generic.IList<PersonCore> AdminTo { get; set; }

        /// <summary>
        /// The profile owner's admins in no particular order. Note that not all fields of these PersonCores will be
        /// set, in particular, relationships will be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("admins")]
        public virtual System.Collections.Generic.IList<PersonCore> Admins { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("availabilityStatus")]
        public virtual string AvailabilityStatus { get; set; }

        /// <summary>Person birthday.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("birthday")]
        public virtual Date Birthday { get; set; }

        /// <summary>The URL to open the profile owner's primary calendar.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("calendarUrl")]
        public virtual SafeUrlProto CalendarUrl { get; set; }

        /// <summary>
        /// The URL to start a chat conversation with the profile owner. For google.com this is a Hangouts URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chatUrl")]
        public virtual SafeUrlProto ChatUrl { get; set; }

        /// <summary>Person's cost center as a string, e.g. "926: Googler Apps".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("costCenter")]
        public virtual string CostCenter { get; set; }

        /// <summary>
        /// The person's Organization department, e.g. "People Operations". For google.com this is usually called
        /// "area".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("department")]
        public virtual string Department { get; set; }

        /// <summary>
        /// A subset of the profile owner's direct reports. The number of entities here may be less than
        /// total_direct_reports_count, because typically ProfileResponse does not include all the person's reports, if
        /// there are too many to retrieve efficiently. Note that not all fields of these PersonCores will be set, in
        /// particular, relationships will be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directReports")]
        public virtual System.Collections.Generic.IList<PersonCore> DirectReports { get; set; }

        /// <summary>
        /// The profile owner's direct dotted line managers in no particular order. Note that not all fields of these
        /// PersonCores will be set, in particular, relationships will be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dottedLineManagers")]
        public virtual System.Collections.Generic.IList<PersonCore> DottedLineManagers { get; set; }

        /// <summary>
        /// A subset of the profile owner's dotted-line reports. The number of entities here may be less than
        /// total_dlr_count. Note that not all fields of these PersonCores will be set, in particular, relationships
        /// will be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dottedLineReports")]
        public virtual System.Collections.Generic.IList<PersonCore> DottedLineReports { get; set; }

        /// <summary>E-mail addresses of the person. The primary or preferred email should be first.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emails")]
        public virtual System.Collections.Generic.IList<string> Emails { get; set; }

        /// <summary>
        /// Person's employee number (external ID of type "organization") For google.com this is the badge number (e.g.
        /// 2 for Larry Page).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("employeeId")]
        public virtual string EmployeeId { get; set; }

        /// <summary>
        /// A fingerprint used by PAPI to reliably determine if a resource has changed Externally it is used as part of
        /// the etag.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; }

        /// <summary>Full-time equivalent (in ‰) (e.g. 800 for a person who's working 80%).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ftePermille")]
        public virtual System.Nullable<long> FtePermille { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("geoLocation")]
        public virtual MapInfo GeoLocation { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("gmailUrl")]
        public virtual string GmailUrl { get; set; }

        /// <summary>
        /// Profile owner's job title (e.g. "Software Engineer"). For google.com this is the Workday preferred job
        /// title.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobTitle")]
        public virtual string JobTitle { get; set; }

        /// <summary>List of keys to use from the map 'keywords'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keywordTypes")]
        public virtual System.Collections.Generic.IList<string> KeywordTypes { get; set; }

        /// <summary>Custom keywords the domain admin has added.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keywords")]
        public virtual System.Collections.Generic.IDictionary<string, string> Keywords { get; set; }

        /// <summary>Custom links the profile owner has added.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("links")]
        public virtual System.Collections.Generic.IList<EnterpriseTopazFrontendTeamsLink> Links { get; set; }

        /// <summary>
        /// Detailed desk location within the company. For google.com this is the desk location code (e.g.
        /// "DE-MUC-ARP-6T2-6T2C0C") if the person has a desk.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// The profile owner's management chain from top to bottom, where managers[0] is the CEO, manager[N-2] is the
        /// person's manager's manager and managers[N-1] is the person's direct manager. Note that not all fields of
        /// these PersonCores will be set, in particular, relationships will be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managers")]
        public virtual System.Collections.Generic.IList<PersonCore> Managers { get; set; }

        /// <summary>Custom mission statement the profile owner has added.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mission")]
        public virtual string Mission { get; set; }

        /// <summary>Human-readable Unicode display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Office/building identifier within the company. For google.com this is the office code (e.g. "DE-MUC-ARP").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("officeLocation")]
        public virtual string OfficeLocation { get; set; }

        /// <summary>The person's obfuscated Gaia ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personId")]
        public virtual string PersonId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumbers")]
        public virtual System.Collections.Generic.IList<EnterpriseTopazFrontendTeamsPersonCorePhoneNumber> PhoneNumbers { get; set; }

        /// <summary>Person photo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("photoUrl")]
        public virtual SafeUrlProto PhotoUrl { get; set; }

        /// <summary>Postal address of office/building.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalAddress")]
        public virtual string PostalAddress { get; set; }

        /// <summary>Total count of the profile owner's direct reports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalDirectReportsCount")]
        public virtual System.Nullable<int> TotalDirectReportsCount { get; set; }

        /// <summary>Total count of the profile owner's dotted-line reports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalDlrCount")]
        public virtual System.Nullable<int> TotalDlrCount { get; set; }

        /// <summary>
        /// The sum of all profile owner's reports and their own full-time-equivalents in ‰ (e.g. 1800 if one report is
        /// working 80% and profile owner 100%).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalFteCount")]
        public virtual System.Nullable<long> TotalFteCount { get; set; }

        /// <summary>External ID of type "login_id" for the profile. For google.com this is the username/LDAP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("waldoComeBackTime")]
        public virtual object WaldoComeBackTime { get; set; }

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
        /// object. IsReturnable must be true to set this option. Only supported for boolean, enum, integer, and text
        /// properties.
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

    /// <summary>Details about a user's query activity.</summary>
    public class QueryActivity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>User input query to be logged/removed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

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

    /// <summary>Remove Logged Activity Request.</summary>
    public class RemoveActivityRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Request options, such as the search application and clientId.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestOptions")]
        public virtual RequestOptions RequestOptions { get; set; }

        /// <summary>User Activity containing the data to be deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userActivity")]
        public virtual UserActivity UserActivity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Remove Logged Activity Response. will return an empty response for now. Will be revisited in later phases.
    /// </summary>
    public class RemoveActivityResponse : Google.Apis.Requests.IDirectResponseSchema
    {
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

    public class ResetSearchApplicationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Common debug options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugOptions")]
        public virtual DebugOptions DebugOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Debugging information about the response.</summary>
    public class ResponseDebugInfo : Google.Apis.Requests.IDirectResponseSchema
    {
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

    /// <summary>
    /// IMPORTANT: It is unsafe to accept this message from an untrusted source, since it's trivial for an attacker to
    /// forge serialized messages that don't fulfill the type's safety contract -- for example, it could contain
    /// attacker controlled script. A system which receives a SafeHtmlProto implicitly trusts the producer of the
    /// SafeHtmlProto. So, it's generally safe to return this message in RPC responses, but generally unsafe to accept
    /// it in RPC requests.
    /// </summary>
    public class SafeHtmlProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// IMPORTANT: Never set or read this field, even from tests, it is private. See documentation at the top of
        /// .proto file for programming language packages with which to create or read this message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateDoNotAccessOrElseSafeHtmlWrappedValue")]
        public virtual string PrivateDoNotAccessOrElseSafeHtmlWrappedValue { get; set; }

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

    public class SpellResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The suggested spelling of the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedQuery")]
        public virtual string SuggestedQuery { get; set; }

        /// <summary>
        /// The sanitized HTML representing the spell corrected query that can be used in the UI. This usually has
        /// language-specific tags to mark up parts of the query that are spell checked.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedQueryHtml")]
        public virtual SafeHtmlProto SuggestedQueryHtml { get; set; }

        /// <summary>Suggestion triggered for the current query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestionType")]
        public virtual string SuggestionType { get; set; }

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

    public class ThirdPartyGenericCard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unique identifier for the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardId")]
        public virtual string CardId { get; set; }

        /// <summary>Category that the card belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>[Required] Card content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual Content Content { get; set; }

        /// <summary>[Required] Context where the card should be triggered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual Context Context { get; set; }

        /// <summary>Whether the card can be dismissed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDismissible")]
        public virtual System.Nullable<bool> IsDismissible { get; set; }

        /// <summary>Priority of the card, where 0 is the highest priority.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual System.Nullable<int> Priority { get; set; }

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

    /// <summary>Next tag: 2</summary>
    public class TypeInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contains additional video information only if document_type is VIDEO.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoInfo")]
        public virtual VideoInfo VideoInfo { get; set; }

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

        /// <summary>
        /// Only applies to
        /// [`settings.datasources.patch`](https://developers.google.com/cloud-search/docs/reference/rest/v1/settings.datasources/patch).
        /// Update mask to control which fields to update. Example field paths: `name`, `displayName`. * If
        /// `update_mask` is non-empty, then only the fields specified in the `update_mask` are updated. * If you
        /// specify a field in the `update_mask`, but don't specify its value in the source, that field is cleared. * If
        /// the `update_mask` is not present or empty or has the value `*`, then all fields are updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

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

    /// <summary>User's single or bulk query activity. This can be a logging query or deletion query.</summary>
    public class UserActivity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contains data which needs to be logged/removed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryActivity")]
        public virtual QueryActivity QueryActivity { get; set; }

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
}
