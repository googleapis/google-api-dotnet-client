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

namespace Google.Apis.AdSensePlatform.v1alpha
{
    /// <summary>The AdSensePlatform Service.</summary>
    public class AdSensePlatformService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AdSensePlatformService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AdSensePlatformService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Accounts = new AccountsResource(this);
            Platforms = new PlatformsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://adsenseplatform.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://adsenseplatform.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "adsenseplatform";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the AdSense Platform API.</summary>
        public class Scope
        {
            /// <summary>View and manage your AdSense data</summary>
            public static string Adsense = "https://www.googleapis.com/auth/adsense";

            /// <summary>View your AdSense data</summary>
            public static string AdsenseReadonly = "https://www.googleapis.com/auth/adsense.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the AdSense Platform API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your AdSense data</summary>
            public const string Adsense = "https://www.googleapis.com/auth/adsense";

            /// <summary>View your AdSense data</summary>
            public const string AdsenseReadonly = "https://www.googleapis.com/auth/adsense.readonly";
        }

        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }

        /// <summary>Gets the Platforms resource.</summary>
        public virtual PlatformsResource Platforms { get; }
    }

    /// <summary>A base abstract class for AdSensePlatform requests.</summary>
    public abstract class AdSensePlatformBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AdSensePlatformBaseServiceRequest instance.</summary>
        protected AdSensePlatformBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes AdSensePlatform parameter list.</summary>
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

    /// <summary>The "accounts" collection of methods.</summary>
    public class AccountsResource
    {
        private const string Resource = "accounts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AccountsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Platforms = new PlatformsResource(service);
        }

        /// <summary>Gets the Platforms resource.</summary>
        public virtual PlatformsResource Platforms { get; }

        /// <summary>The "platforms" collection of methods.</summary>
        public class PlatformsResource
        {
            private const string Resource = "platforms";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public PlatformsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                ChildAccounts = new ChildAccountsResource(service);
                Groups = new GroupsResource(service);
            }

            /// <summary>Gets the ChildAccounts resource.</summary>
            public virtual ChildAccountsResource ChildAccounts { get; }

            /// <summary>The "childAccounts" collection of methods.</summary>
            public class ChildAccountsResource
            {
                private const string Resource = "childAccounts";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ChildAccountsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Sites = new SitesResource(service);
                }

                /// <summary>Gets the Sites resource.</summary>
                public virtual SitesResource Sites { get; }

                /// <summary>The "sites" collection of methods.</summary>
                public class SitesResource
                {
                    private const string Resource = "sites";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public SitesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Gets a Platform Child Site for a specified Platform Child Account and site.</summary>
                    /// <param name="name">
                    /// Required. The name of the platform child site to retrieve. Format:
                    /// accounts/{account}/platforms/{platform}/childAccounts/{child_account}/sites/{platform_child_site}
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets a Platform Child Site for a specified Platform Child Account and site.</summary>
                    public class GetRequest : AdSensePlatformBaseServiceRequest<Google.Apis.AdSensePlatform.v1alpha.Data.PlatformChildSite>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the platform child site to retrieve. Format:
                        /// accounts/{account}/platforms/{platform}/childAccounts/{child_account}/sites/{platform_child_site}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

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
                                Pattern = @"^accounts/[^/]+/platforms/[^/]+/childAccounts/[^/]+/sites/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists Platform Child Sites for a specified Platform Child Account.</summary>
                    /// <param name="parent">
                    /// Required. The name of the child account under the given platform which owns the platform child
                    /// sites. Format: accounts/{account}/platforms/{platform}/childAccounts/{child_account}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists Platform Child Sites for a specified Platform Child Account.</summary>
                    public class ListRequest : AdSensePlatformBaseServiceRequest<Google.Apis.AdSensePlatform.v1alpha.Data.ListPlatformChildSitesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the child account under the given platform which owns the platform
                        /// child sites. Format: accounts/{account}/platforms/{platform}/childAccounts/{child_account}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The maximum number of children to include in the response, used for paging. If
                        /// unspecified, at most 10000 platforms will be returned. The maximum value is 10000; values
                        /// above 10000 will be coerced to 10000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous `ListPlatformChildSites` call. Provide this
                        /// to retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListPlatformChildSites` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/sites";

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
                                Pattern = @"^accounts/[^/]+/platforms/[^/]+/childAccounts/[^/]+$",
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

                    /// <summary>Update a Platform Child Site.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. Format:
                    /// accounts/{account}/platforms/{platform}/childAccounts/{child_account}/sites/{platform_child_site}
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.AdSensePlatform.v1alpha.Data.PlatformChildSite body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Update a Platform Child Site.</summary>
                    public class PatchRequest : AdSensePlatformBaseServiceRequest<Google.Apis.AdSensePlatform.v1alpha.Data.PlatformChildSite>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AdSensePlatform.v1alpha.Data.PlatformChildSite body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. Format:
                        /// accounts/{account}/platforms/{platform}/childAccounts/{child_account}/sites/{platform_child_site}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. The list of fields to update - currently only supports updating the
                        /// `platform_group` field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.AdSensePlatform.v1alpha.Data.PlatformChildSite Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

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
                                Pattern = @"^accounts/[^/]+/platforms/[^/]+/childAccounts/[^/]+/sites/[^/]+$",
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

                /// <summary>Gets a Platform Group for a specified Platform and group.</summary>
                /// <param name="name">
                /// Required. The name of the platform group to retrieve. Format:
                /// accounts/{account}/platforms/{platform}/groups/{group}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a Platform Group for a specified Platform and group.</summary>
                public class GetRequest : AdSensePlatformBaseServiceRequest<Google.Apis.AdSensePlatform.v1alpha.Data.PlatformGroup>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the platform group to retrieve. Format:
                    /// accounts/{account}/platforms/{platform}/groups/{group}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                            Pattern = @"^accounts/[^/]+/platforms/[^/]+/groups/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists Platform Groups for a specified Platform.</summary>
                /// <param name="parent">
                /// Required. The name of the platform to retrieve. Format: accounts/{account}/platforms/{platform}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists Platform Groups for a specified Platform.</summary>
                public class ListRequest : AdSensePlatformBaseServiceRequest<Google.Apis.AdSensePlatform.v1alpha.Data.ListPlatformGroupsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the platform to retrieve. Format: accounts/{account}/platforms/{platform}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of groups to include in the response, used for paging. If
                    /// unspecified, at most 10000 groups will be returned. The maximum value is 10000; values above
                    /// 10000 will be coerced to 10000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListPlatformGroups` call. Provide this to
                    /// retrieve the subsequent page. When paginating, all other parameters provided to
                    /// `ListPlatformGroups` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/groups";

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
                            Pattern = @"^accounts/[^/]+/platforms/[^/]+$",
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

                /// <summary>Update a Platform Group.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. Format: accounts/{account}/platforms/{platform}/groups/{platform_group}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.AdSensePlatform.v1alpha.Data.PlatformGroup body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Update a Platform Group.</summary>
                public class PatchRequest : AdSensePlatformBaseServiceRequest<Google.Apis.AdSensePlatform.v1alpha.Data.PlatformGroup>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AdSensePlatform.v1alpha.Data.PlatformGroup body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. Format: accounts/{account}/platforms/{platform}/groups/{platform_group}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The list of fields to update - currently only supports updating the `description`
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AdSensePlatform.v1alpha.Data.PlatformGroup Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                            Pattern = @"^accounts/[^/]+/platforms/[^/]+/groups/[^/]+$",
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

            /// <summary>Gets a platform.</summary>
            /// <param name="name">
            /// Required. The name of the platform to retrieve. Format: accounts/{account}/platforms/{platform}
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a platform.</summary>
            public class GetRequest : AdSensePlatformBaseServiceRequest<Google.Apis.AdSensePlatform.v1alpha.Data.Platform>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the platform to retrieve. Format: accounts/{account}/platforms/{platform}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

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
                        Pattern = @"^accounts/[^/]+/platforms/[^/]+$",
                    });
                }
            }

            /// <summary>Lists platforms for a specified account.</summary>
            /// <param name="parent">Required. The account which owns the platforms. Format: accounts/{account}</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists platforms for a specified account.</summary>
            public class ListRequest : AdSensePlatformBaseServiceRequest<Google.Apis.AdSensePlatform.v1alpha.Data.ListPlatformsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The account which owns the platforms. Format: accounts/{account}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of platforms to include in the response, used for paging. If
                /// unspecified, at most 10000 platforms will be returned. The maximum value is 10000; values above
                /// 10000 will be coerced to 10000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListPlatforms` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListPlatforms` must match the
                /// call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/platforms";

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
                        Pattern = @"^accounts/[^/]+$",
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

    /// <summary>The "platforms" collection of methods.</summary>
    public class PlatformsResource
    {
        private const string Resource = "platforms";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PlatformsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Accounts = new AccountsResource(service);
        }

        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }

        /// <summary>The "accounts" collection of methods.</summary>
        public class AccountsResource
        {
            private const string Resource = "accounts";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AccountsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Events = new EventsResource(service);
                Sites = new SitesResource(service);
            }

            /// <summary>Gets the Events resource.</summary>
            public virtual EventsResource Events { get; }

            /// <summary>The "events" collection of methods.</summary>
            public class EventsResource
            {
                private const string Resource = "events";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public EventsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates an account event.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Account to log events about. Format: platforms/{platform}/accounts/{account}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.AdSensePlatform.v1alpha.Data.Event body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates an account event.</summary>
                public class CreateRequest : AdSensePlatformBaseServiceRequest<Google.Apis.AdSensePlatform.v1alpha.Data.Event>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdSensePlatform.v1alpha.Data.Event body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Account to log events about. Format: platforms/{platform}/accounts/{account}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AdSensePlatform.v1alpha.Data.Event Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/events";

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
                            Pattern = @"^platforms/[^/]+/accounts/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Sites resource.</summary>
            public virtual SitesResource Sites { get; }

            /// <summary>The "sites" collection of methods.</summary>
            public class SitesResource
            {
                private const string Resource = "sites";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SitesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a site for a specified account.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Account to create site. Format: platforms/{platform}/accounts/{account_id}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.AdSensePlatform.v1alpha.Data.Site body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a site for a specified account.</summary>
                public class CreateRequest : AdSensePlatformBaseServiceRequest<Google.Apis.AdSensePlatform.v1alpha.Data.Site>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdSensePlatform.v1alpha.Data.Site body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Account to create site. Format: platforms/{platform}/accounts/{account_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AdSensePlatform.v1alpha.Data.Site Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/sites";

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
                            Pattern = @"^platforms/[^/]+/accounts/[^/]+$",
                        });
                    }
                }

                /// <summary>Deletes a site from a specified account.</summary>
                /// <param name="name">
                /// Required. The name of the site to delete. Format:
                /// platforms/{platform}/accounts/{account}/sites/{site}
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a site from a specified account.</summary>
                public class DeleteRequest : AdSensePlatformBaseServiceRequest<Google.Apis.AdSensePlatform.v1alpha.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the site to delete. Format:
                    /// platforms/{platform}/accounts/{account}/sites/{site}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                            Pattern = @"^platforms/[^/]+/accounts/[^/]+/sites/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets a site from a specified sub-account.</summary>
                /// <param name="name">
                /// Required. The name of the site to retrieve. Format:
                /// platforms/{platform}/accounts/{account}/sites/{site}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a site from a specified sub-account.</summary>
                public class GetRequest : AdSensePlatformBaseServiceRequest<Google.Apis.AdSensePlatform.v1alpha.Data.Site>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the site to retrieve. Format:
                    /// platforms/{platform}/accounts/{account}/sites/{site}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                            Pattern = @"^platforms/[^/]+/accounts/[^/]+/sites/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists sites for a specific account.</summary>
                /// <param name="parent">
                /// Required. The account which owns the sites. Format: platforms/{platform}/accounts/{account}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists sites for a specific account.</summary>
                public class ListRequest : AdSensePlatformBaseServiceRequest<Google.Apis.AdSensePlatform.v1alpha.Data.ListSitesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The account which owns the sites. Format: platforms/{platform}/accounts/{account}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of sites to include in the response, used for paging. If unspecified, at most
                    /// 10000 sites will be returned. The maximum value is 10000; values above 10000 will be coerced to
                    /// 10000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListSites` call. Provide this to retrieve the subsequent
                    /// page. When paginating, all other parameters provided to `ListSites` must match the call that
                    /// provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/sites";

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
                            Pattern = @"^platforms/[^/]+/accounts/[^/]+$",
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
                /// Requests the review of a site. The site should be in REQUIRES_REVIEW or NEEDS_ATTENTION state. Note:
                /// Make sure you place an [ad tag](https://developers.google.com/adsense/platforms/direct/ad-tags) on
                /// your site before requesting a review.
                /// </summary>
                /// <param name="name">
                /// Required. The name of the site to submit for review. Format:
                /// platforms/{platform}/accounts/{account}/sites/{site}
                /// </param>
                public virtual RequestReviewRequest RequestReview(string name)
                {
                    return new RequestReviewRequest(this.service, name);
                }

                /// <summary>
                /// Requests the review of a site. The site should be in REQUIRES_REVIEW or NEEDS_ATTENTION state. Note:
                /// Make sure you place an [ad tag](https://developers.google.com/adsense/platforms/direct/ad-tags) on
                /// your site before requesting a review.
                /// </summary>
                public class RequestReviewRequest : AdSensePlatformBaseServiceRequest<Google.Apis.AdSensePlatform.v1alpha.Data.RequestSiteReviewResponse>
                {
                    /// <summary>Constructs a new RequestReview request.</summary>
                    public RequestReviewRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the site to submit for review. Format:
                    /// platforms/{platform}/accounts/{account}/sites/{site}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "requestReview";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}:requestReview";

                    /// <summary>Initializes RequestReview parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^platforms/[^/]+/accounts/[^/]+/sites/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Closes a sub-account.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Account to close. Format: platforms/{platform}/accounts/{account_id}
            /// </param>
            public virtual CloseRequest Close(Google.Apis.AdSensePlatform.v1alpha.Data.CloseAccountRequest body, string name)
            {
                return new CloseRequest(this.service, body, name);
            }

            /// <summary>Closes a sub-account.</summary>
            public class CloseRequest : AdSensePlatformBaseServiceRequest<Google.Apis.AdSensePlatform.v1alpha.Data.CloseAccountResponse>
            {
                /// <summary>Constructs a new Close request.</summary>
                public CloseRequest(Google.Apis.Services.IClientService service, Google.Apis.AdSensePlatform.v1alpha.Data.CloseAccountRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Account to close. Format: platforms/{platform}/accounts/{account_id}</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdSensePlatform.v1alpha.Data.CloseAccountRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "close";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}:close";

                /// <summary>Initializes Close parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^platforms/[^/]+/accounts/[^/]+$",
                    });
                }
            }

            /// <summary>Creates a sub-account.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. Platform to create an account for. Format: platforms/{platform}</param>
            public virtual CreateRequest Create(Google.Apis.AdSensePlatform.v1alpha.Data.Account body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates a sub-account.</summary>
            public class CreateRequest : AdSensePlatformBaseServiceRequest<Google.Apis.AdSensePlatform.v1alpha.Data.Account>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdSensePlatform.v1alpha.Data.Account body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Platform to create an account for. Format: platforms/{platform}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdSensePlatform.v1alpha.Data.Account Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/accounts";

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
                        Pattern = @"^platforms/[^/]+$",
                    });
                }
            }

            /// <summary>Gets information about the selected sub-account.</summary>
            /// <param name="name">
            /// Required. Account to get information about. Format: platforms/{platform}/accounts/{account_id}
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about the selected sub-account.</summary>
            public class GetRequest : AdSensePlatformBaseServiceRequest<Google.Apis.AdSensePlatform.v1alpha.Data.Account>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Account to get information about. Format: platforms/{platform}/accounts/{account_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

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
                        Pattern = @"^platforms/[^/]+/accounts/[^/]+$",
                    });
                }
            }

            /// <summary>Lists a partial view of sub-accounts for a specific parent account.</summary>
            /// <param name="parent">Required. Platform who parents the accounts. Format: platforms/{platform}</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists a partial view of sub-accounts for a specific parent account.</summary>
            public class ListRequest : AdSensePlatformBaseServiceRequest<Google.Apis.AdSensePlatform.v1alpha.Data.ListAccountsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. Platform who parents the accounts. Format: platforms/{platform}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of accounts to include in the response, used for paging. If
                /// unspecified, at most 10000 accounts will be returned. The maximum value is 10000; values above 10000
                /// will be coerced to 10000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListAccounts` call. Provide this to retrieve the
                /// subsequent page.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/accounts";

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
                        Pattern = @"^platforms/[^/]+$",
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
            /// Looks up information about a sub-account for a specified creation_request_id. If no account exists for
            /// the given creation_request_id, returns 404.
            /// </summary>
            /// <param name="parent">Required. Platform who parents the account. Format: platforms/{platform}</param>
            public virtual LookupRequest Lookup(string parent)
            {
                return new LookupRequest(this.service, parent);
            }

            /// <summary>
            /// Looks up information about a sub-account for a specified creation_request_id. If no account exists for
            /// the given creation_request_id, returns 404.
            /// </summary>
            public class LookupRequest : AdSensePlatformBaseServiceRequest<Google.Apis.AdSensePlatform.v1alpha.Data.LookupAccountResponse>
            {
                /// <summary>Constructs a new Lookup request.</summary>
                public LookupRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. Platform who parents the account. Format: platforms/{platform}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional. The creation_request_id provided when calling createAccount.</summary>
                [Google.Apis.Util.RequestParameterAttribute("creationRequestId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string CreationRequestId { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "lookup";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/accounts:lookup";

                /// <summary>Initializes Lookup parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^platforms/[^/]+$",
                    });
                    RequestParameters.Add("creationRequestId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "creationRequestId",
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
namespace Google.Apis.AdSensePlatform.v1alpha.Data
{
    /// <summary>Representation of an Account.</summary>
    public class Account : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Creation time of the account.</summary>
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
        /// Required. An opaque token that uniquely identifies the account among all the platform's accounts. This
        /// string may contain at most 64 non-whitespace ASCII characters, but otherwise has no predefined structure.
        /// However, it is expected to be a platform-specific identifier for the user creating the account, so that only
        /// a single account can be created for any given user. This field must not contain any information that is
        /// recognizable as personally identifiable information. e.g. it should not be an email address or login name.
        /// Once an account has been created, a second attempt to create an account using the same creation_request_id
        /// will result in an ALREADY_EXISTS error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationRequestId")]
        public virtual string CreationRequestId { get; set; }

        /// <summary>Display name of this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. Resource name of the account. Format: platforms/pub-[0-9]+/accounts/pub-[0-9]+
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Input only. CLDR region code of the country/region of the address. Set this to country code of the
        /// child account if known, otherwise to your own country code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>Output only. Approval state of the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Required. The IANA TZ timezone code of this account. For more information, see
        /// https://en.wikipedia.org/wiki/List_of_tz_database_time_zones. This field is used for reporting. It is
        /// recommended to set it to the same value for all child accounts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual TimeZone TimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Address data.</summary>
    public class Address : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>First line of address. Max length 64 bytes or 30 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address1")]
        public virtual string Address1 { get; set; }

        /// <summary>Second line of address. Max length 64 bytes or 30 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address2")]
        public virtual string Address2 { get; set; }

        /// <summary>City. Max length 60 bytes or 30 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("city")]
        public virtual string City { get; set; }

        /// <summary>Name of the company. Max length 255 bytes or 34 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("company")]
        public virtual string Company { get; set; }

        /// <summary>Contact name of the company. Max length 128 bytes or 34 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contact")]
        public virtual string Contact { get; set; }

        /// <summary>Fax number with international code (i.e. +441234567890).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fax")]
        public virtual string Fax { get; set; }

        /// <summary>Phone number with international code (i.e. +441234567890).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phone")]
        public virtual string Phone { get; set; }

        /// <summary>Country/Region code. The region is specified as a CLDR region code (e.g. "US", "FR").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>State. Max length 60 bytes or 30 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Zip/post code. Max length 10 bytes or 10 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zip")]
        public virtual string Zip { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request definition for the account close rpc.</summary>
    public class CloseAccountRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response definition for the account close rpc.</summary>
    public class CloseAccountResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A representation of a decimal value, such as 2.5. Clients may convert values into language-native decimal
    /// formats, such as Java's
    /// [BigDecimal](https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html) or Python's
    /// [decimal.Decimal](https://docs.python.org/3/library/decimal.html).
    /// </summary>
    public class Decimal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The decimal value, as a string. The string representation consists of an optional sign, `+` (`U+002B`) or
        /// `-` (`U+002D`), followed by a sequence of zero or more decimal digits ("the integer"), optionally followed
        /// by a fraction, optionally followed by an exponent. An empty string **should** be interpreted as `0`. The
        /// fraction consists of a decimal point followed by zero or more decimal digits. The string must contain at
        /// least one digit in either the integer or the fraction. The number formed by the sign, the integer and the
        /// fraction is referred to as the significand. The exponent consists of the character `e` (`U+0065`) or `E`
        /// (`U+0045`) followed by one or more decimal digits. Services **should** normalize decimal values before
        /// storing them by: - Removing an explicitly-provided `+` sign (`+2.5` -&amp;gt; `2.5`). - Replacing a
        /// zero-length integer value with `0` (`.5` -&amp;gt; `0.5`). - Coercing the exponent character to upper-case,
        /// with explicit sign (`2.5e8` -&amp;gt; `2.5E+8`). - Removing an explicitly-provided zero exponent (`2.5E0`
        /// -&amp;gt; `2.5`). Services **may** perform additional normalization based on its own needs and the internal
        /// decimal implementation selected, such as shifting the decimal point and exponent value together (example:
        /// `2.5E-1` &amp;lt;-&amp;gt; `0.25`). Additionally, services **may** preserve trailing zeroes in the fraction
        /// to indicate increased precision, but are not required to do so. Note that only the `.` character is
        /// supported to divide the integer and the fraction; `,` **should not** be supported regardless of locale.
        /// Additionally, thousand separators **should not** be supported. If a service does support them, values
        /// **must** be normalized. The ENBF grammar is: DecimalString = '' | [Sign] Significand [Exponent]; Sign = '+'
        /// | '-'; Significand = Digits '.' | [Digits] '.' Digits; Exponent = ('e' | 'E') [Sign] Digits; Digits = { '0'
        /// | '1' | '2' | '3' | '4' | '5' | '6' | '7' | '8' | '9' }; Services **should** clearly document the range of
        /// supported values, the maximum supported precision (total number of digits), and, if applicable, the scale
        /// (number of digits after the decimal point), as well as how it behaves when receiving out-of-bounds values.
        /// Services **may** choose to accept values passed as input even when the value has a higher precision or scale
        /// than the service supports, and **should** round the value to fit the supported scale. Alternatively, the
        /// service **may** error with `400 Bad Request` (`INVALID_ARGUMENT` in gRPC) if precision would be lost.
        /// Services **should** error with `400 Bad Request` (`INVALID_ARGUMENT` in gRPC) if the service receives a
        /// value outside of the supported range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

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

    /// <summary>A platform sub-account event to record spam signals.</summary>
    public class Event : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Information associated with the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventInfo")]
        public virtual EventInfo EventInfo { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>Required. Event timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual string EventTimeRaw
        {
            get => _eventTimeRaw;
            set
            {
                _eventTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _eventTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EventTimeDateTimeOffset instead.")]
        public virtual object EventTime
        {
            get => _eventTime;
            set
            {
                _eventTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _eventTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EventTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EventTimeRaw);
            set => EventTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Required. Event type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
        public virtual string EventType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Private information for partner recorded events (PII).</summary>
    public class EventInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The billing address of the publisher associated with this event, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingAddress")]
        public virtual Address BillingAddress { get; set; }

        /// <summary>
        /// Required. The email address that is associated with the publisher when performing the event.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response definition for the list accounts rpc.</summary>
    public class ListAccountsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Accounts returned in the list response. Represented by a partial view of the Account resource,
        /// populating `name` and `creation_request_id`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accounts")]
        public virtual System.Collections.Generic.IList<Account> Accounts { get; set; }

        /// <summary>
        /// Continuation token used to page through accounts. To retrieve the next page of the results, set the next
        /// request's "page_token" value to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response definition for the list platform child sites rpc.</summary>
    public class ListPlatformChildSitesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Continuation token used to page through platforms. To retrieve the next page of the results, set the next
        /// request's "page_token" value to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The platform child sites returned in this list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platformChildSites")]
        public virtual System.Collections.Generic.IList<PlatformChildSite> PlatformChildSites { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response definition for the platform groups list rpc.</summary>
    public class ListPlatformGroupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Continuation token used to page through platforms. To retrieve the next page of the results, set the next
        /// request's "page_token" value to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The platform groups returned in this list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platformGroups")]
        public virtual System.Collections.Generic.IList<PlatformGroup> PlatformGroups { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response definition for the platform list rpc.</summary>
    public class ListPlatformsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Continuation token used to page through platforms. To retrieve the next page of the results, set the next
        /// request's "page_token" value to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The platforms returned in this list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platforms")]
        public virtual System.Collections.Generic.IList<Platform> Platforms { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response definition for the site list rpc.</summary>
    public class ListSitesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Continuation token used to page through sites. To retrieve the next page of the results, set the next
        /// request's "page_token" value to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The sites returned in this list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sites")]
        public virtual System.Collections.Generic.IList<Site> Sites { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response definition for the lookup account rpc.</summary>
    public class LookupAccountResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the Account Format: platforms/{platform}/accounts/{account_id}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of a Transparent Platform.</summary>
    public class Platform : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Default platform group for the platform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultPlatformGroup")]
        public virtual string DefaultPlatformGroup { get; set; }

        /// <summary>Output only. Description of the platform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Identifier. Resource name of a platform. Format: accounts/{account}/platforms/{platform}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of a Transparent Platform Child Site.</summary>
    public class PlatformChildSite : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Domain URL of the Platform Child Site. Part of the PlatformChildSite name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>
        /// Identifier. Format:
        /// accounts/{account}/platforms/{platform}/childAccounts/{child_account}/sites/{platform_child_site}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Resource name of the Platform Group of the Platform Child Site.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platformGroup")]
        public virtual string PlatformGroup { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of a Transparent Platform Group.</summary>
    public class PlatformGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Description of the PlatformGroup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Identifier. Format: accounts/{account}/platforms/{platform}/groups/{platform_group}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The revenue share of the PlatformGroup, in millipercent (e.g. 15000 = 15%).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revshareMillipercent")]
        public virtual Decimal RevshareMillipercent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response definition for the site request review rpc.</summary>
    public class RequestSiteReviewResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of a Site.</summary>
    public class Site : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Domain/sub-domain of the site. Must be a valid domain complying with [RFC
        /// 1035](https://www.ietf.org/rfc/rfc1035.txt) and formatted as punycode [RFC
        /// 3492](https://www.ietf.org/rfc/rfc3492.txt) in case the domain contains unicode characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>
        /// Output only. Resource name of a site. Format: platforms/{platform}/accounts/{account}/sites/{site}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. State of a site.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a time zone from the [IANA Time Zone Database](https://www.iana.org/time-zones).</summary>
    public class TimeZone : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>IANA Time Zone Database time zone. For example "America/New_York".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. IANA Time Zone Database version number. For example "2019a".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
