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

namespace Google.Apis.AdMob.v1beta
{
    /// <summary>The AdMob Service.</summary>
    public class AdMobService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AdMobService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AdMobService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Accounts = new AccountsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://admob.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://admob.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "admob";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the AdMob API.</summary>
        public class Scope
        {
            /// <summary>See your AdMob data</summary>
            public static string AdmobReadonly = "https://www.googleapis.com/auth/admob.readonly";

            /// <summary>See your AdMob data</summary>
            public static string AdmobReport = "https://www.googleapis.com/auth/admob.report";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the AdMob API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See your AdMob data</summary>
            public const string AdmobReadonly = "https://www.googleapis.com/auth/admob.readonly";

            /// <summary>See your AdMob data</summary>
            public const string AdmobReport = "https://www.googleapis.com/auth/admob.report";
        }

        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }
    }

    /// <summary>A base abstract class for AdMob requests.</summary>
    public abstract class AdMobBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AdMobBaseServiceRequest instance.</summary>
        protected AdMobBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes AdMob parameter list.</summary>
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
            AdSources = new AdSourcesResource(service);
            AdUnitMappings = new AdUnitMappingsResource(service);
            AdUnits = new AdUnitsResource(service);
            Apps = new AppsResource(service);
            CampaignReport = new CampaignReportResource(service);
            MediationGroups = new MediationGroupsResource(service);
            MediationReport = new MediationReportResource(service);
            NetworkReport = new NetworkReportResource(service);
        }

        /// <summary>Gets the AdSources resource.</summary>
        public virtual AdSourcesResource AdSources { get; }

        /// <summary>The "adSources" collection of methods.</summary>
        public class AdSourcesResource
        {
            private const string Resource = "adSources";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AdSourcesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Adapters = new AdaptersResource(service);
            }

            /// <summary>Gets the Adapters resource.</summary>
            public virtual AdaptersResource Adapters { get; }

            /// <summary>The "adapters" collection of methods.</summary>
            public class AdaptersResource
            {
                private const string Resource = "adapters";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AdaptersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>List the adapters of the ad source.</summary>
                /// <param name="parent">
                /// Required. The parent which owns this collection of adapters. Format:
                /// accounts/{publisher_id}/adSources/{ad_source_id}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List the adapters of the ad source.</summary>
                public class ListRequest : AdMobBaseServiceRequest<Google.Apis.AdMob.v1beta.Data.ListAdaptersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent which owns this collection of adapters. Format:
                    /// accounts/{publisher_id}/adSources/{ad_source_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of adapters to return. If unspecified or 0, at most 10,000 adapters will be
                    /// returned. The maximum value is 20,000; values above 20,000 will be coerced to 20,000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListAdapters` call. Provide this to retrieve the
                    /// subsequent page.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/adapters";

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
                            Pattern = @"^accounts/[^/]+/adSources/[^/]+$",
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

            /// <summary>List the ad sources.</summary>
            /// <param name="parent">
            /// Required. The parent which owns this collection of ad sources. Format: accounts/{publisher_id}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>List the ad sources.</summary>
            public class ListRequest : AdMobBaseServiceRequest<Google.Apis.AdMob.v1beta.Data.ListAdSourcesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent which owns this collection of ad sources. Format: accounts/{publisher_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of ad sources to return. If unspecified or 0, at most 10,000 ad sources will be
                /// returned. The maximum value is 20,000; values above 10,000 will be coerced to 20,000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListAdSources` call. Provide this to retrieve the subsequent
                /// page.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/adSources";

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

        /// <summary>Gets the AdUnitMappings resource.</summary>
        public virtual AdUnitMappingsResource AdUnitMappings { get; }

        /// <summary>The "adUnitMappings" collection of methods.</summary>
        public class AdUnitMappingsResource
        {
            private const string Resource = "adUnitMappings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AdUnitMappingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Batch create the ad unit mappings under the specific AdMob account. The maximum allowed batch size is
            /// 100. This method has limited access. If you see a 403 permission denied error, please reach out to your
            /// account manager for access.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The AdMob account which owns this collection of ad unit mappings. Format:
            /// accounts/{publisher_id} See https://support.google.com/admob/answer/2784578 for instructions on how to
            /// find your AdMob publisher ID.
            /// </param>
            public virtual BatchCreateRequest BatchCreate(Google.Apis.AdMob.v1beta.Data.BatchCreateAdUnitMappingsRequest body, string parent)
            {
                return new BatchCreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Batch create the ad unit mappings under the specific AdMob account. The maximum allowed batch size is
            /// 100. This method has limited access. If you see a 403 permission denied error, please reach out to your
            /// account manager for access.
            /// </summary>
            public class BatchCreateRequest : AdMobBaseServiceRequest<Google.Apis.AdMob.v1beta.Data.BatchCreateAdUnitMappingsResponse>
            {
                /// <summary>Constructs a new BatchCreate request.</summary>
                public BatchCreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdMob.v1beta.Data.BatchCreateAdUnitMappingsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The AdMob account which owns this collection of ad unit mappings. Format:
                /// accounts/{publisher_id} See https://support.google.com/admob/answer/2784578 for instructions on how
                /// to find your AdMob publisher ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdMob.v1beta.Data.BatchCreateAdUnitMappingsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchCreate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/adUnitMappings:batchCreate";

                /// <summary>Initializes BatchCreate parameter list.</summary>
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
                }
            }
        }

        /// <summary>Gets the AdUnits resource.</summary>
        public virtual AdUnitsResource AdUnits { get; }

        /// <summary>The "adUnits" collection of methods.</summary>
        public class AdUnitsResource
        {
            private const string Resource = "adUnits";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AdUnitsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                AdUnitMappings = new AdUnitMappingsResource(service);
            }

            /// <summary>Gets the AdUnitMappings resource.</summary>
            public virtual AdUnitMappingsResource AdUnitMappings { get; }

            /// <summary>The "adUnitMappings" collection of methods.</summary>
            public class AdUnitMappingsResource
            {
                private const string Resource = "adUnitMappings";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AdUnitMappingsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Create an ad unit mapping under the specific AdMob account and ad unit. This method has limited
                /// access. If you see a 403 permission denied error, please reach out to your account manager for
                /// access.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent which owns the ad unit mapping. Format:
                /// accounts/{publisher_id}/adUnits/{ad_unit_id}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.AdMob.v1beta.Data.AdUnitMapping body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Create an ad unit mapping under the specific AdMob account and ad unit. This method has limited
                /// access. If you see a 403 permission denied error, please reach out to your account manager for
                /// access.
                /// </summary>
                public class CreateRequest : AdMobBaseServiceRequest<Google.Apis.AdMob.v1beta.Data.AdUnitMapping>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdMob.v1beta.Data.AdUnitMapping body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent which owns the ad unit mapping. Format:
                    /// accounts/{publisher_id}/adUnits/{ad_unit_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AdMob.v1beta.Data.AdUnitMapping Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/adUnitMappings";

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
                            Pattern = @"^accounts/[^/]+/adUnits/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// List ad unit mappings under the specified AdMob account and ad unit. This method has limited access.
                /// If you see a 403 permission denied error, please reach out to your account manager for access.
                /// </summary>
                /// <param name="parent">
                /// Required. The parent which owns this collection of ad unit mappings. Format:
                /// accounts/{publisher_id}/adUnits/{ad_unit_id}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// List ad unit mappings under the specified AdMob account and ad unit. This method has limited access.
                /// If you see a 403 permission denied error, please reach out to your account manager for access.
                /// </summary>
                public class ListRequest : AdMobBaseServiceRequest<Google.Apis.AdMob.v1beta.Data.ListAdUnitMappingsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent which owns this collection of ad unit mappings. Format:
                    /// accounts/{publisher_id}/adUnits/{ad_unit_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The filter string that uses [EBNF grammar
                    /// syntax](https://google.aip.dev/assets/misc/ebnf-filtering.txt). Possible field to filter by is:
                    /// - "DISPLAY_NAME" Possible filter function is: - `IN`: Used to filter fields that represent a
                    /// singleton including "DISPLAY_NAME". The filter functions can be added together using `AND`. `OR`
                    /// functionality is not supported. Example: filter: IN(DISPLAY_NAME, "Test Ad Unit Mapping 1",
                    /// "Test Ad Unit Mapping 2")
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// The maximum number of ad unit mappings to return. If unspecified or 0, at most 10,000 ad unit
                    /// mappings will be returned. The maximum value is 20,000; values above 20,000 will be coerced to
                    /// 20,000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListAdUnitMappings` call. Provide this to retrieve the
                    /// subsequent page.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/adUnitMappings";

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
                            Pattern = @"^accounts/[^/]+/adUnits/[^/]+$",
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
            /// Creates an ad unit under the specified AdMob account. This method has limited access. If you see a 403
            /// permission denied error, please reach out to your account manager for access.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Resource name of the account to create the specified ad unit for. Example:
            /// accounts/pub-9876543210987654
            /// </param>
            public virtual CreateRequest Create(Google.Apis.AdMob.v1beta.Data.AdUnit body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates an ad unit under the specified AdMob account. This method has limited access. If you see a 403
            /// permission denied error, please reach out to your account manager for access.
            /// </summary>
            public class CreateRequest : AdMobBaseServiceRequest<Google.Apis.AdMob.v1beta.Data.AdUnit>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdMob.v1beta.Data.AdUnit body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the account to create the specified ad unit for. Example:
                /// accounts/pub-9876543210987654
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdMob.v1beta.Data.AdUnit Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/adUnits";

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
                        Pattern = @"^accounts/[^/]+$",
                    });
                }
            }

            /// <summary>List the ad units under the specified AdMob account.</summary>
            /// <param name="parent">
            /// Required. Resource name of the account to list ad units for. Example: accounts/pub-9876543210987654
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>List the ad units under the specified AdMob account.</summary>
            public class ListRequest : AdMobBaseServiceRequest<Google.Apis.AdMob.v1beta.Data.ListAdUnitsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the account to list ad units for. Example: accounts/pub-9876543210987654
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of ad units to return. If unspecified or 0, at most 10,000 ad units will be
                /// returned. The maximum value is 20,000; values above 20,000 will be coerced to 20,000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The value returned by the last `ListAdUnitsResponse`; indicates that this is a continuation of a
                /// prior `ListAdUnits` call, and that the system should return the next page of data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/adUnits";

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

        /// <summary>Gets the Apps resource.</summary>
        public virtual AppsResource Apps { get; }

        /// <summary>The "apps" collection of methods.</summary>
        public class AppsResource
        {
            private const string Resource = "apps";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AppsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates an app under the specified AdMob account. This method has limited access. If you see a 403
            /// permission denied error, please reach out to your account manager for access.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Resource name of the account for which the app is being created. Example:
            /// accounts/pub-9876543210987654
            /// </param>
            public virtual CreateRequest Create(Google.Apis.AdMob.v1beta.Data.App body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates an app under the specified AdMob account. This method has limited access. If you see a 403
            /// permission denied error, please reach out to your account manager for access.
            /// </summary>
            public class CreateRequest : AdMobBaseServiceRequest<Google.Apis.AdMob.v1beta.Data.App>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdMob.v1beta.Data.App body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the account for which the app is being created. Example:
                /// accounts/pub-9876543210987654
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdMob.v1beta.Data.App Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/apps";

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
                        Pattern = @"^accounts/[^/]+$",
                    });
                }
            }

            /// <summary>List the apps under the specified AdMob account.</summary>
            /// <param name="parent">
            /// Required. Resource name of the account to list apps for. Example: accounts/pub-9876543210987654
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>List the apps under the specified AdMob account.</summary>
            public class ListRequest : AdMobBaseServiceRequest<Google.Apis.AdMob.v1beta.Data.ListAppsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the account to list apps for. Example: accounts/pub-9876543210987654
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of apps to return. If unspecified or 0, at most 10,000 apps will be returned. The
                /// maximum value is 20,000; values above 20,000 will be coerced to 20,000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The value returned by the last `ListAppsResponse`; indicates that this is a continuation of a prior
                /// `ListApps` call, and that the system should return the next page of data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/apps";

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

        /// <summary>Gets the CampaignReport resource.</summary>
        public virtual CampaignReportResource CampaignReport { get; }

        /// <summary>The "campaignReport" collection of methods.</summary>
        public class CampaignReportResource
        {
            private const string Resource = "campaignReport";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CampaignReportResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Generates Campaign Report based on provided specifications.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Resource name of the account to generate the report for. Example: accounts/pub-9876543210987654
            /// </param>
            public virtual GenerateRequest Generate(Google.Apis.AdMob.v1beta.Data.GenerateCampaignReportRequest body, string parent)
            {
                return new GenerateRequest(this.service, body, parent);
            }

            /// <summary>Generates Campaign Report based on provided specifications.</summary>
            public class GenerateRequest : AdMobBaseServiceRequest<Google.Apis.AdMob.v1beta.Data.GenerateCampaignReportResponse>
            {
                /// <summary>Constructs a new Generate request.</summary>
                public GenerateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdMob.v1beta.Data.GenerateCampaignReportRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Resource name of the account to generate the report for. Example: accounts/pub-9876543210987654
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdMob.v1beta.Data.GenerateCampaignReportRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "generate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/campaignReport:generate";

                /// <summary>Initializes Generate parameter list.</summary>
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
                }
            }
        }

        /// <summary>Gets the MediationGroups resource.</summary>
        public virtual MediationGroupsResource MediationGroups { get; }

        /// <summary>The "mediationGroups" collection of methods.</summary>
        public class MediationGroupsResource
        {
            private const string Resource = "mediationGroups";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public MediationGroupsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                MediationAbExperiments = new MediationAbExperimentsResource(service);
            }

            /// <summary>Gets the MediationAbExperiments resource.</summary>
            public virtual MediationAbExperimentsResource MediationAbExperiments { get; }

            /// <summary>The "mediationAbExperiments" collection of methods.</summary>
            public class MediationAbExperimentsResource
            {
                private const string Resource = "mediationAbExperiments";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public MediationAbExperimentsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Create an A/B testing experiment for a specified AdMob account and a mediation group. This method
                /// has limited access. If you see a 403 permission denied error, please reach out to your account
                /// manager for access.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent which owns the mediation group. Format:
                /// accounts/{publisher_id}/mediationGroups/{mediation_group_id}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.AdMob.v1beta.Data.MediationAbExperiment body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Create an A/B testing experiment for a specified AdMob account and a mediation group. This method
                /// has limited access. If you see a 403 permission denied error, please reach out to your account
                /// manager for access.
                /// </summary>
                public class CreateRequest : AdMobBaseServiceRequest<Google.Apis.AdMob.v1beta.Data.MediationAbExperiment>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdMob.v1beta.Data.MediationAbExperiment body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent which owns the mediation group. Format:
                    /// accounts/{publisher_id}/mediationGroups/{mediation_group_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AdMob.v1beta.Data.MediationAbExperiment Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/mediationAbExperiments";

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
                            Pattern = @"^accounts/[^/]+/mediationGroups/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Stop the mediation A/B experiment and choose a variant. This method has limited access. If you see a
                /// 403 permission denied error, please reach out to your account manager for access.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Name of the mediation group, the experiment for which to choose a variant for. Example:
                /// accounts/pub-9876543210987654/mediationGroups/0123456789/ mediationAbExperiments
                /// </param>
                public virtual StopRequest Stop(Google.Apis.AdMob.v1beta.Data.StopMediationAbExperimentRequest body, string name)
                {
                    return new StopRequest(this.service, body, name);
                }

                /// <summary>
                /// Stop the mediation A/B experiment and choose a variant. This method has limited access. If you see a
                /// 403 permission denied error, please reach out to your account manager for access.
                /// </summary>
                public class StopRequest : AdMobBaseServiceRequest<Google.Apis.AdMob.v1beta.Data.MediationAbExperiment>
                {
                    /// <summary>Constructs a new Stop request.</summary>
                    public StopRequest(Google.Apis.Services.IClientService service, Google.Apis.AdMob.v1beta.Data.StopMediationAbExperimentRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Name of the mediation group, the experiment for which to choose a variant for. Example:
                    /// accounts/pub-9876543210987654/mediationGroups/0123456789/ mediationAbExperiments
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AdMob.v1beta.Data.StopMediationAbExperimentRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "stop";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}:stop";

                    /// <summary>Initializes Stop parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accounts/[^/]+/mediationGroups/[^/]+/mediationAbExperiments$",
                        });
                    }
                }
            }

            /// <summary>
            /// Create a mediation group under the specific AdMob account. This method has limited access. If you see a
            /// 403 permission denied error, please reach out to your account manager for access.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent which owns the mediation group. Format: accounts/{publisher_id}
            /// </param>
            public virtual CreateRequest Create(Google.Apis.AdMob.v1beta.Data.MediationGroup body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Create a mediation group under the specific AdMob account. This method has limited access. If you see a
            /// 403 permission denied error, please reach out to your account manager for access.
            /// </summary>
            public class CreateRequest : AdMobBaseServiceRequest<Google.Apis.AdMob.v1beta.Data.MediationGroup>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdMob.v1beta.Data.MediationGroup body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent which owns the mediation group. Format: accounts/{publisher_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdMob.v1beta.Data.MediationGroup Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/mediationGroups";

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
                        Pattern = @"^accounts/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// List mediation groups under the specified AdMob account. This method has limited access. If you see a
            /// 403 permission denied error, please reach out to your account manager for access.
            /// </summary>
            /// <param name="parent">
            /// Required. Resource name of the account to list mediation groups for. Example:
            /// accounts/pub-9876543210987654
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// List mediation groups under the specified AdMob account. This method has limited access. If you see a
            /// 403 permission denied error, please reach out to your account manager for access.
            /// </summary>
            public class ListRequest : AdMobBaseServiceRequest<Google.Apis.AdMob.v1beta.Data.ListMediationGroupsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the account to list mediation groups for. Example:
                /// accounts/pub-9876543210987654
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The filter string that uses [EBNF grammar
                /// syntax](https://google.aip.dev/assets/misc/ebnf-filtering.txt). Possible fields to filter by are: -
                /// "AD_SOURCE_IDS" - "AD_UNIT_IDS" - "APP_IDS" - "DISPLAY_NAME" - "FORMAT" - "MEDIATION_GROUP_ID" -
                /// "PLATFORM" - "STATE" - "TARGETED_REGION_CODES" Possible filter functions are: - `IN`: Used to filter
                /// fields that represent a singleton including "MEDIATION_GROUP_ID", "DISPLAY_NAME", "STATE",
                /// "PLATFORM", and "FORMAT". - `CONTAINS_ANY`: Used to filter fields that represent a collection
                /// including "AD_SOURCE_IDS", "AD_UNIT_IDS", "APP_IDS", and "TARGETED_REGION_CODES". The filter
                /// functions can be added together using `AND`. `OR` functionality is not supported. Example: filter:
                /// IN(DISPLAY_NAME, "Test Group 1", "Test Group 2") AND IN(PLATFORM, "ANDROID") AND
                /// CONTAINS_ANY(AD_SOURCE_IDS, "5450213213286189855")
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// The maximum number of mediation groups to return. If unspecified or 0, at most 10,000 mediation
                /// groups will be returned. The maximum value is 20,000; values above 20,000 will be coerced to 20,000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The value returned by the last `ListMediationGroupsResponse`; indicates that this is a continuation
                /// of a prior `ListMediationGroups` call, and that the system should return the next page of data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/mediationGroups";

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
            /// Update the specified mediation group under the specified AdMob account. This method has limited access.
            /// If you see a 403 permission denied error, please reach out to your account manager for access.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Resource name for this mediation group. Format is:
            /// accounts/{publisher_id}/mediationGroups/{mediation_group_id} Example:
            /// accounts/pub-9876543210987654/mediationGroups/0123456789
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.AdMob.v1beta.Data.MediationGroup body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>
            /// Update the specified mediation group under the specified AdMob account. This method has limited access.
            /// If you see a 403 permission denied error, please reach out to your account manager for access.
            /// </summary>
            public class PatchRequest : AdMobBaseServiceRequest<Google.Apis.AdMob.v1beta.Data.MediationGroup>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AdMob.v1beta.Data.MediationGroup body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Resource name for this mediation group. Format is:
                /// accounts/{publisher_id}/mediationGroups/{mediation_group_id} Example:
                /// accounts/pub-9876543210987654/mediationGroups/0123456789
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// List of mediation group fields to be updated. Updates to repeated fields such as items in a list
                /// will fully replace the existing value(s) with the new value(s). Updates to individual values in a
                /// map can be done by indexing by the key. The following field masks are supported for mediation group
                /// updates: - "mediation_group_lines[\"{mediation_group_line_id}\"]" clang-format off -
                /// "mediation_group_lines[\"{mediation_group_line_id}\"].ad_unit_mappings[\"{ad_unit_id}\"]"
                /// clang-format on - "mediation_group_lines[\"{mediation_group_line_id}\"].cpm_micros" -
                /// "mediation_group_lines[\"{mediation_group_line_id}\"].cpm_mode" -
                /// "mediation_group_lines[\"{mediation_group_line_id}\"].state" -
                /// "mediation_group_lines[\"{mediation_group_line_id}\"].display_name" - "targeting.ad_unit_ids" To
                /// update a mediation group with a new mediation group line, use a distinct negative number for the
                /// "mediation_group_line_id". For Example: update_mask { paths:
                /// "mediation_group_lines[\"123456789012345\"].cpm_micros" }
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdMob.v1beta.Data.MediationGroup Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^accounts/[^/]+/mediationGroups/[^/]+$",
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

        /// <summary>Gets the MediationReport resource.</summary>
        public virtual MediationReportResource MediationReport { get; }

        /// <summary>The "mediationReport" collection of methods.</summary>
        public class MediationReportResource
        {
            private const string Resource = "mediationReport";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public MediationReportResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Generates an AdMob Mediation report based on the provided report specification. Returns result of a
            /// server-side streaming RPC. The result is returned in a sequence of responses.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Resource name of the account to generate the report for. Example: accounts/pub-9876543210987654
            /// </param>
            public virtual GenerateRequest Generate(Google.Apis.AdMob.v1beta.Data.GenerateMediationReportRequest body, string parent)
            {
                return new GenerateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Generates an AdMob Mediation report based on the provided report specification. Returns result of a
            /// server-side streaming RPC. The result is returned in a sequence of responses.
            /// </summary>
            public class GenerateRequest : AdMobBaseServiceRequest<Google.Apis.AdMob.v1beta.Data.GenerateMediationReportResponse>
            {
                /// <summary>Constructs a new Generate request.</summary>
                public GenerateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdMob.v1beta.Data.GenerateMediationReportRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Resource name of the account to generate the report for. Example: accounts/pub-9876543210987654
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdMob.v1beta.Data.GenerateMediationReportRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "generate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/mediationReport:generate";

                /// <summary>Initializes Generate parameter list.</summary>
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
                }
            }
        }

        /// <summary>Gets the NetworkReport resource.</summary>
        public virtual NetworkReportResource NetworkReport { get; }

        /// <summary>The "networkReport" collection of methods.</summary>
        public class NetworkReportResource
        {
            private const string Resource = "networkReport";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public NetworkReportResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Generates an AdMob Network report based on the provided report specification. Returns result of a
            /// server-side streaming RPC. The result is returned in a sequence of responses.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Resource name of the account to generate the report for. Example: accounts/pub-9876543210987654
            /// </param>
            public virtual GenerateRequest Generate(Google.Apis.AdMob.v1beta.Data.GenerateNetworkReportRequest body, string parent)
            {
                return new GenerateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Generates an AdMob Network report based on the provided report specification. Returns result of a
            /// server-side streaming RPC. The result is returned in a sequence of responses.
            /// </summary>
            public class GenerateRequest : AdMobBaseServiceRequest<Google.Apis.AdMob.v1beta.Data.GenerateNetworkReportResponse>
            {
                /// <summary>Constructs a new Generate request.</summary>
                public GenerateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdMob.v1beta.Data.GenerateNetworkReportRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Resource name of the account to generate the report for. Example: accounts/pub-9876543210987654
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdMob.v1beta.Data.GenerateNetworkReportRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "generate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/networkReport:generate";

                /// <summary>Initializes Generate parameter list.</summary>
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
                }
            }
        }

        /// <summary>Gets information about the specified AdMob publisher account.</summary>
        /// <param name="name">
        /// Resource name of the publisher account to retrieve. Example: accounts/pub-9876543210987654
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>Gets information about the specified AdMob publisher account.</summary>
        public class GetRequest : AdMobBaseServiceRequest<Google.Apis.AdMob.v1beta.Data.PublisherAccount>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Resource name of the publisher account to retrieve. Example: accounts/pub-9876543210987654
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+name}";

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
                    Pattern = @"^accounts/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Lists the AdMob publisher account that was most recently signed in to from the AdMob UI. For more
        /// information, see https://support.google.com/admob/answer/10243672.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        /// Lists the AdMob publisher account that was most recently signed in to from the AdMob UI. For more
        /// information, see https://support.google.com/admob/answer/10243672.
        /// </summary>
        public class ListRequest : AdMobBaseServiceRequest<Google.Apis.AdMob.v1beta.Data.ListPublisherAccountsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Maximum number of accounts to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// The value returned by the last `ListPublisherAccountsResponse`; indicates that this is a continuation of
            /// a prior `ListPublisherAccounts` call, and that the system should return the next page of data.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/accounts";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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
namespace Google.Apis.AdMob.v1beta.Data
{
    /// <summary>Definition of a mediation ad source.</summary>
    public class AdSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of this ad source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adSourceId")]
        public virtual string AdSourceId { get; set; }

        /// <summary>
        /// Resource name of this ad source. Format is: accounts/{publisher_id}/adSources/{ad_source_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Display name of this ad source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes an AdMob ad unit.</summary>
    public class AdUnit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// AdFormat of the ad unit. Possible values are as follows: "APP_OPEN" - App Open ad format. "BANNER" - Banner
        /// ad format. "BANNER_INTERSTITIAL" - Legacy format that can be used as either banner or interstitial. This
        /// format can no longer be created but can be targeted by mediation groups. "INTERSTITIAL" - A full screen ad.
        /// Supported ad types are "RICH_MEDIA" and "VIDEO". "NATIVE" - Native ad format. "REWARDED" - An ad that, once
        /// viewed, gets a callback verifying the view so that a reward can be given to the user. Supported ad types are
        /// "RICH_MEDIA" (interactive) and video where video can not be excluded. "REWARDED_INTERSTITIAL" - Rewarded
        /// Interstitial ad format. Only supports video ad type. See https://support.google.com/admob/answer/9884467.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adFormat")]
        public virtual string AdFormat { get; set; }

        /// <summary>
        /// Ad media type supported by this ad unit. Possible values as follows: "RICH_MEDIA" - Text, image, and other
        /// non-video media. "VIDEO" - Video media.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adTypes")]
        public virtual System.Collections.Generic.IList<string> AdTypes { get; set; }

        /// <summary>
        /// The externally visible ID of the ad unit which can be used to integrate with the AdMob SDK. This is a read
        /// only property. Example: ca-app-pub-9876543210987654/0123456789
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adUnitId")]
        public virtual string AdUnitId { get; set; }

        /// <summary>
        /// The externally visible ID of the app this ad unit is associated with. Example:
        /// ca-app-pub-9876543210987654~0123456789
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual string AppId { get; set; }

        /// <summary>
        /// The display name of the ad unit as shown in the AdMob UI, which is provided by the user. The maximum length
        /// allowed is 80 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Resource name for this ad unit. Format is accounts/{publisher_id}/adUnits/{ad_unit_id_fragment} Example:
        /// accounts/pub-9876543210987654/adUnits/0123456789
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Settings for a rewarded ad unit. This can be set or unset only when the ad_format is "REWARDED".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rewardSettings")]
        public virtual AdUnitRewardSettings RewardSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings to map an AdMob ad unit to a 3rd party ad unit.</summary>
    public class AdUnitMapping : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Settings for the specified ad unit to make an ad request to 3rd party ad network. Key-value pairs with
        /// values set by the user for the keys requested by the ad network. Please see
        /// https://support.google.com/admob/answer/3245073 for details on how to configure the network settings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adUnitConfigurations")]
        public virtual System.Collections.Generic.IDictionary<string, string> AdUnitConfigurations { get; set; }

        /// <summary>
        /// The ID of mediation ad source adapter used by this ad unit mapping. The adapter determines the information
        /// needed in the ad_network_settings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adapterId")]
        public virtual System.Nullable<long> AdapterId { get; set; }

        /// <summary>Optional. The display name of this ad unit mapping instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Resource name of this ad unit mapping. Format is:
        /// accounts/{publisher_id}/adUnits/{ad_unit_id_fragment}/adUnitMappings/{ad_unit_mapping_id} Example:
        /// accounts/pub-1234567890123456/adUnits/0123456789/adUnitMappings/987654321
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The status of this ad unit mapping.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings for a rewarded ad unit.</summary>
    public class AdUnitRewardSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Reward amount for this ad unit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitAmount")]
        public virtual System.Nullable<long> UnitAmount { get; set; }

        /// <summary>Reward item for this ad unit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitType")]
        public virtual string UnitType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes adapters supported by each mediation ad source. Adapters correspond to a specific SDK implementation
    /// of the ad source, and are each associated with a single platform and a list of supported ad unit formats.
    /// Adapters may also require setting some configurations to perform ad requests. Configurations can be specified in
    /// the AdUnitMapping by setting the [ad_unit_configurations](#AdUnitMapping.ad_unit_configurations) key/value
    /// pairs. For example, the ad_unit_configurations can be used to pass various IDs to the adapter's third-party SDK.
    /// </summary>
    public class Adapter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Configuration metadata associated with this adapter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adapterConfigMetadata")]
        public virtual System.Collections.Generic.IList<AdapterAdapterConfigMetadata> AdapterConfigMetadata { get; set; }

        /// <summary>
        /// Output only. ID of this adapter. It is used to set [adapter_id](#AdUnitMapping.adapter_id).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adapterId")]
        public virtual string AdapterId { get; set; }

        /// <summary>Output only. Indicates the formats of the ad units supported by this adapter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formats")]
        public virtual System.Collections.Generic.IList<string> Formats { get; set; }

        /// <summary>
        /// Output only. Resource name of the adapter. Format is:
        /// accounts/{publisher_id}/adSources/{ad_source_id}/adapters/{adapter_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Mobile application platform supported by this adapter. Supported values are: IOS, ANDROID,
        /// WINDOWS_PHONE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual string Platform { get; set; }

        /// <summary>Output only. The display name of this adapter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration metadata associated with this adapter. They are used to define the ad_unit_configurations
    /// associated with AdUnitMappings for the this adapter.
    /// </summary>
    public class AdapterAdapterConfigMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This is used to fill the key of the [ad_unit_configurations](#AdUnitMapping.ad_unit_configurations).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adapterConfigMetadataId")]
        public virtual string AdapterConfigMetadataId { get; set; }

        /// <summary>Name of the adapter configuration metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adapterConfigMetadataLabel")]
        public virtual string AdapterConfigMetadataLabel { get; set; }

        /// <summary>Whether this metadata is required for configuring the AdUnitMappings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRequired")]
        public virtual System.Nullable<bool> IsRequired { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes an AdMob app for a specific platform (For example: Android or iOS).</summary>
    public class App : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The approval state for the app. The field is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appApprovalState")]
        public virtual string AppApprovalState { get; set; }

        /// <summary>
        /// The externally visible ID of the app which can be used to integrate with the AdMob SDK. This is a read only
        /// property. Example: ca-app-pub-9876543210987654~0123456789
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual string AppId { get; set; }

        /// <summary>
        /// Immutable. The information for an app that is linked to an app store. This field is present if and only if
        /// the app is linked to an app store.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedAppInfo")]
        public virtual AppLinkedAppInfo LinkedAppInfo { get; set; }

        /// <summary>
        /// The information for an app that is not linked to any app store. After an app is linked, this information is
        /// still retrivable. If no name is provided for the app upon creation, a placeholder name will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualAppInfo")]
        public virtual AppManualAppInfo ManualAppInfo { get; set; }

        /// <summary>
        /// Resource name for this app. Format is accounts/{publisher_id}/apps/{app_id_fragment} Example:
        /// accounts/pub-9876543210987654/apps/0123456789
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Describes the platform of the app. Limited to "IOS" and "ANDROID".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual string Platform { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information from the app store if the app is linked to an app store.</summary>
    public class AppLinkedAppInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The app store information for published Android apps. This field is only used for apps on the
        /// Android platform and will be ignored if the PLATFORM is set to iOS. The default value is the Google Play App
        /// store. This field can be updated after app is created. If the app is not published, this field will not be
        /// included in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidAppStores")]
        public virtual System.Collections.Generic.IList<string> AndroidAppStores { get; set; }

        /// <summary>
        /// The app store ID of the app; present if and only if the app is linked to an app store. If the app is added
        /// to the Google Play store, it will be the application ID of the app. For example: "com.example.myapp". See
        /// https://developer.android.com/studio/build/application-id. If the app is added to the Apple App Store, it
        /// will be app store ID. For example "105169111". Note that setting the app store id is considered an
        /// irreversible action. Once an app is linked, it cannot be unlinked.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appStoreId")]
        public virtual string AppStoreId { get; set; }

        /// <summary>
        /// Output only. Display name of the app as it appears in the app store. This is an output-only field, and may
        /// be empty if the app cannot be found in the store.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information provided for manual apps which are not linked to an application store (Example: Google Play, App
    /// Store).
    /// </summary>
    public class AppManualAppInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The display name of the app as shown in the AdMob UI, which is provided by the user. The maximum length
        /// allowed is 80 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to create a batch of ad unit mappings under the specific AdMob account.</summary>
    public class BatchCreateAdUnitMappingsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The request message specifying the ad unit mappings to create. A maximum of 100 ad unit mappings
        /// can be created in a batch. If the number of ad unit mappings in the batch request exceed 100, the entire
        /// request will be rejected and no ad unit mappings will be created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<CreateAdUnitMappingRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing a batch of created ad unit mappings.</summary>
    public class BatchCreateAdUnitMappingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Ad units mappings created under the requested account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adUnitMappings")]
        public virtual System.Collections.Generic.IList<AdUnitMapping> AdUnitMappings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The specification for generating a Campaign report. For example, the specification to get IMPRESSIONS and CLICKS
    /// sliced by CAMPAIGN_ID can look like the following example: { "date_range": { "start_date": {"year": 2021,
    /// "month": 12, "day": 1}, "end_date": {"year": 2021, "month": 12, "day": 30} }, "dimensions": ["CAMPAIGN_ID"],
    /// "metrics": ["IMPRESSIONS", "CLICKS"], }
    /// </summary>
    public class CampaignReportSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The date range for which the report is generated. The max range is 30 days.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateRange")]
        public virtual DateRange DateRange { get; set; }

        /// <summary>
        /// List of dimensions of the report. The value combination of these dimensions determines the row of the
        /// report. If no dimensions are specified, the report returns a single row of requested metrics for the entire
        /// account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<string> Dimensions { get; set; }

        /// <summary>
        /// Language used for any localized text, such as certain applicable dimension values. The language tag is
        /// defined in the IETF BCP47. Defaults to 'en-US' if unspecified or invalid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>List of metrics of the report. A report must specify at least one metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<string> Metrics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to create an ad unit mapping under the specific AdMob account and ad unit.</summary>
    public class CreateAdUnitMappingRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The ad unit mapping to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adUnitMapping")]
        public virtual AdUnitMapping AdUnitMapping { get; set; }

        /// <summary>
        /// Required. The parent which owns the ad unit mapping. Format: accounts/{publisher_id}/adUnits/{ad_unit_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

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

    /// <summary>Specification of a single date range. Both dates are inclusive.</summary>
    public class DateRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>End date of the date range, inclusive. Must be greater than or equal to the start date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual Date EndDate { get; set; }

        /// <summary>Start date of the date range, inclusive. Must be less than or equal to the end date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual Date StartDate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to generate campaign report.</summary>
    public class GenerateCampaignReportRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Campaign report specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportSpec")]
        public virtual CampaignReportSpec ReportSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Campaign Report API response.</summary>
    public class GenerateCampaignReportResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The campaign report data from the specified publisher. At most 100000 rows will be returned from the API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<ReportRow> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to generate an AdMob Mediation report.</summary>
    public class GenerateMediationReportRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Network report specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportSpec")]
        public virtual MediationReportSpec ReportSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The streaming response for the AdMob Mediation report where the first response contains the report header, then
    /// a stream of row responses, and finally a footer as the last response message. For example: [{ "header": {
    /// "date_range": { "start_date": {"year": 2018, "month": 9, "day": 1}, "end_date": {"year": 2018, "month": 9,
    /// "day": 1} }, "localization_settings": { "currency_code": "USD", "language_code": "en-US" } } }, { "row": {
    /// "dimension_values": { "DATE": {"value": "20180918"}, "APP": { "value": "ca-app-pub-8123415297019784~1001342552",
    /// "display_label": "My app name!" } }, "metric_values": { "ESTIMATED_EARNINGS": {"decimal_value": "1324746"} } }
    /// }, { "footer": {"matching_row_count": 1} }]
    /// </summary>
    public class GenerateMediationReportResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional information about the generated report, such as warnings about the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("footer")]
        public virtual ReportFooter Footer { get; set; }

        /// <summary>
        /// Report generation settings that describes the report contents, such as the report date range and
        /// localization settings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual ReportHeader Header { get; set; }

        /// <summary>Actual report data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("row")]
        public virtual ReportRow Row { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to generate an AdMob Network report.</summary>
    public class GenerateNetworkReportRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Network report specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportSpec")]
        public virtual NetworkReportSpec ReportSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The streaming response for the AdMob Network report where the first response contains the report header, then a
    /// stream of row responses, and finally a footer as the last response message. For example: [{ "header": {
    /// "dateRange": { "startDate": {"year": 2018, "month": 9, "day": 1}, "endDate": {"year": 2018, "month": 9, "day":
    /// 1} }, "localizationSettings": { "currencyCode": "USD", "languageCode": "en-US" } } }, { "row": {
    /// "dimensionValues": { "DATE": {"value": "20180918"}, "APP": { "value": "ca-app-pub-8123415297019784~1001342552",
    /// displayLabel: "My app name!" } }, "metricValues": { "ESTIMATED_EARNINGS": {"microsValue": 6500000} } } }, {
    /// "footer": {"matchingRowCount": 1} }]
    /// </summary>
    public class GenerateNetworkReportResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional information about the generated report, such as warnings about the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("footer")]
        public virtual ReportFooter Footer { get; set; }

        /// <summary>
        /// Report generation settings that describes the report contents, such as the report date range and
        /// localization settings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual ReportHeader Header { get; set; }

        /// <summary>Actual report data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("row")]
        public virtual ReportRow Row { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the ListAdSourcesRequest.</summary>
    public class ListAdSourcesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ad sources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adSources")]
        public virtual System.Collections.Generic.IList<AdSource> AdSources { get; set; }

        /// <summary>
        /// Used to set the `page_token` in the `ListAdSourcesRequest` to retrieve the next page. If this field is
        /// omitted, there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the ListAdUnitMappingsRequest.</summary>
    public class ListAdUnitMappingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ad unit mappings from the specified account and ad unit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adUnitMappings")]
        public virtual System.Collections.Generic.IList<AdUnitMapping> AdUnitMappings { get; set; }

        /// <summary>
        /// Used to set the `page_token` in the `ListAdUnitMappingsRequest` to retrieve the next page. If this field is
        /// omitted, there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the ad units list request.</summary>
    public class ListAdUnitsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resulting ad units for the requested account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adUnits")]
        public virtual System.Collections.Generic.IList<AdUnit> AdUnits { get; set; }

        /// <summary>
        /// If not empty, indicates that there may be more ad units for the request; this value should be passed in a
        /// new `ListAdUnitsRequest`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the ListAdaptersRequest.</summary>
    public class ListAdaptersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The adapter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adapters")]
        public virtual System.Collections.Generic.IList<Adapter> Adapters { get; set; }

        /// <summary>
        /// Used to set the `page_token` in the `ListAdapterRequest` to retrieve the next page. If this field is
        /// omitted, there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the apps list request.</summary>
    public class ListAppsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resulting apps for the requested account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apps")]
        public virtual System.Collections.Generic.IList<App> Apps { get; set; }

        /// <summary>
        /// If not empty, indicates that there may be more apps for the request; this value should be passed in a new
        /// `ListAppsRequest`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the mediation groups list request.</summary>
    public class ListMediationGroupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resulting mediation groups for the requested account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediationGroups")]
        public virtual System.Collections.Generic.IList<MediationGroup> MediationGroups { get; set; }

        /// <summary>
        /// If not empty, indicates that there may be more mediation groups for the request; this value should be passed
        /// in a new `ListMediationGroupsRequest`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the publisher account list request.</summary>
    public class ListPublisherAccountsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Publisher that the client credentials can access.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual System.Collections.Generic.IList<PublisherAccount> Account { get; set; }

        /// <summary>
        /// If not empty, indicates that there might be more accounts for the request; you must pass this value in a new
        /// `ListPublisherAccountsRequest`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Localization settings for reports, such as currency and language. It affects how metrics are calculated.
    /// </summary>
    public class LocalizationSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Currency code of the earning related metrics, which is the 3-letter code defined in ISO 4217. The daily
        /// average rate is used for the currency conversion. Defaults to the account currency code if unspecified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>
        /// Language used for any localized text, such as some dimension value display labels. The language tag defined
        /// in the IETF BCP47. Defaults to 'en-US' if unspecified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The mediation A/B experiment.</summary>
    public class MediationAbExperiment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The experiment mediation lines for control. They are inherited from the parent mediation group.
        /// It is an output only field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlMediationLines")]
        public virtual System.Collections.Generic.IList<MediationAbExperimentExperimentMediationLine> ControlMediationLines { get; set; }

        /// <summary>The display name for the mediation A/B experiment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. The time at which the experiment was ended or target to end (in UTC).</summary>
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
        /// Output only. Unique identifier for the mediation A/B experiment. It is an output only property.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("experimentId")]
        public virtual string ExperimentId { get; set; }

        /// <summary>
        /// Output only. The mediation group id this experiment belongs to. This can be used for filtering the
        /// experiments in the list experiments API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediationGroupId")]
        public virtual string MediationGroupId { get; set; }

        /// <summary>
        /// Resource name for this experiment. The format is accounts/{publisher_id}/
        /// mediationGroups/{mediation_group_id}/mediationAbExperiment/ {mediation_group_experiment_id}. For example:
        /// accounts/pub-9876543210987654/mediationGroups/0123456789/ mediationAbExperiment/12345
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. The time at which the experiment was started (in UTC).</summary>
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

        /// <summary>Output only. The state of the experiment. It is an output only field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// The experiment mediation lines created for the treatment. They will be used for serving when the experiment
        /// status is RUNNING.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("treatmentMediationLines")]
        public virtual System.Collections.Generic.IList<MediationAbExperimentExperimentMediationLine> TreatmentMediationLines { get; set; }

        /// <summary>
        /// The percentage of the mediation A/B experiment traffic that will be send to the treatment (variant B). The
        /// remainder is sent to the control (variant A). The percentage is expressed as an integer in the inclusive
        /// range of [1,99]. See https://support.google.com/admob/answer/9572326 for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("treatmentTrafficPercentage")]
        public virtual System.Nullable<long> TreatmentTrafficPercentage { get; set; }

        /// <summary>Output only. The variant leader for the experiment according to some key metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variantLeader")]
        public virtual string VariantLeader { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The mediation group line for the experiment. It will be used for serving during the run of the experiment.
    /// </summary>
    public class MediationAbExperimentExperimentMediationLine : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The mediation group line used by the experiment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediationGroupLine")]
        public virtual MediationGroupMediationGroupLine MediationGroupLine { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes an AdMob Mediation group.</summary>
    public class MediationGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>User provided name for the mediation group. The maximum length allowed is 120 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. The state of the mediation a/b experiment that belongs to this mediation group.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediationAbExperimentState")]
        public virtual string MediationAbExperimentState { get; set; }

        /// <summary>The ID of the mediation group. Example: "0123456789". This is a read only property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediationGroupId")]
        public virtual string MediationGroupId { get; set; }

        /// <summary>
        /// The mediation lines used for serving for this mediation group. Key is the ID of the mediation group line.
        /// For creation, use distinct negative values as placeholder.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediationGroupLines")]
        public virtual System.Collections.Generic.IDictionary<string, MediationGroupMediationGroupLine> MediationGroupLines { get; set; }

        /// <summary>
        /// Resource name for this mediation group. Format is:
        /// accounts/{publisher_id}/mediationGroups/{mediation_group_id} Example:
        /// accounts/pub-9876543210987654/mediationGroups/0123456789
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The status of the mediation group. Only enabled mediation groups will be served.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Set of criteria targeted by this mediation group, such as ad units and geo locations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targeting")]
        public virtual MediationGroupTargeting Targeting { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings for an ad network used by a mediation group.</summary>
    public class MediationGroupMediationGroupLine : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the ad source this mediation line is associated with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adSourceId")]
        public virtual string AdSourceId { get; set; }

        /// <summary>
        /// References of the ad unit mappings for each ad unit associated with this mediation line. Key is the ad unit
        /// ID, value is resource name of the ad unit mapping. For mediation lines where the ad source id is the AdMob
        /// Network, ad unit mappings will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adUnitMappings")]
        public virtual System.Collections.Generic.IDictionary<string, string> AdUnitMappings { get; set; }

        /// <summary>
        /// The CPM for this allocation line. $0.01 is the minimum allowed amount. For LIVE CPM modes, the default
        /// amount is $0.01. This value is ignored if `cpm_mode` is `LIVE`. **Warning:** "USD" is the only supported
        /// currency at the moment. The unit is in micros.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpmMicros")]
        public virtual System.Nullable<long> CpmMicros { get; set; }

        /// <summary>
        /// Indicates how the CPM for this mediation line is provided. Note that `MANUAL` and `LIVE` are the only
        /// fully-supported mode at the moment. Please use the AdMob UI (https://admob.google.com) if you wish to create
        /// or update to other cpm modes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpmMode")]
        public virtual string CpmMode { get; set; }

        /// <summary>
        /// User-provided label for this mediation line. The maximum length allowed is 255 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. The Mediation A/B experiment variant to which the mediation group line belongs to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("experimentVariant")]
        public virtual string ExperimentVariant { get; set; }

        /// <summary>
        /// The 16 digit ID for this mediation line e.g. 0123456789012345. When creating a new mediation group line, use
        /// a distinct negative integer as the ID place holder.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The status of the mediation group line. Only enabled mediation group lines will be served.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Set of criteria targeted by this mediation group. For example, a mediation group can target specific ad unit
    /// IDs, platform, format and geo location.
    /// </summary>
    public class MediationGroupTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Ad units targeted by this mediation group. Example: "ca-app-pub-1234/8790".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adUnitIds")]
        public virtual System.Collections.Generic.IList<string> AdUnitIds { get; set; }

        /// <summary>
        /// The Unicode country/region code (CLDR) of a location, such as "US". Unset if this mediation group does not
        /// exclude any region.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedRegionCodes")]
        public virtual System.Collections.Generic.IList<string> ExcludedRegionCodes { get; set; }

        /// <summary>Ad format targeted by this mediation group. Examples: "banner", "native".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>
        /// The parameter can be used to target ad requests based on the availability of the IDFA. If set to ALL, the
        /// mediation group applies to all ad requests (with or without IDFA). If set to AVAILABLE, the mediation group
        /// applies to ad requests with IDFA. If set to NOT_AVAILABLE, the mediation group applies to ad requests
        /// without IDFA. Doesn't need to be specified for an ANDROID device.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idfaTargeting")]
        public virtual string IdfaTargeting { get; set; }

        /// <summary>Describes the platform of the app. Examples: "IOS", "ANDROID".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual string Platform { get; set; }

        /// <summary>
        /// The Unicode country/region code (CLDR) of a location, such as "US". Unset if this mediation group targets
        /// all available regions. For more information, see http://www.unicode.org/reports/tr35/#unicode_region_subtag.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetedRegionCodes")]
        public virtual System.Collections.Generic.IList<string> TargetedRegionCodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The specification for generating an AdMob Mediation report. For example, the specification to get observed ECPM
    /// sliced by ad source and app for the 'US' and 'CN' countries can look like the following example: { "date_range":
    /// { "start_date": {"year": 2021, "month": 9, "day": 1}, "end_date": {"year": 2021, "month": 9, "day": 30} },
    /// "dimensions": ["AD_SOURCE", "APP", "COUNTRY"], "metrics": ["OBSERVED_ECPM"], "dimension_filters": [ {
    /// "dimension": "COUNTRY", "matches_any": {"values": [{"value": "US", "value": "CN"}]} } ], "sort_conditions": [
    /// {"dimension":"APP", order: "ASCENDING"} ], "localization_settings": { "currency_code": "USD", "language_code":
    /// "en-US" } } For a better understanding, you can treat the preceding specification like the following pseudo SQL:
    /// SELECT AD_SOURCE, APP, COUNTRY, OBSERVED_ECPM FROM MEDIATION_REPORT WHERE DATE &amp;gt;= '2021-09-01' AND DATE
    /// &amp;lt;= '2021-09-30' AND COUNTRY IN ('US', 'CN') GROUP BY AD_SOURCE, APP, COUNTRY ORDER BY APP ASC;
    /// </summary>
    public class MediationReportSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The date range for which the report is generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateRange")]
        public virtual DateRange DateRange { get; set; }

        /// <summary>Describes which report rows to match based on their dimension values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionFilters")]
        public virtual System.Collections.Generic.IList<MediationReportSpecDimensionFilter> DimensionFilters { get; set; }

        /// <summary>
        /// List of dimensions of the report. The value combination of these dimensions determines the row of the
        /// report. If no dimensions are specified, the report returns a single row of requested metrics for the entire
        /// account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<string> Dimensions { get; set; }

        /// <summary>Localization settings of the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizationSettings")]
        public virtual LocalizationSettings LocalizationSettings { get; set; }

        /// <summary>
        /// Maximum number of report data rows to return. If the value is not set, the API returns as many rows as
        /// possible, up to 100000. Acceptable values are 1-100000, inclusive. Values larger than 100000 return an
        /// error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxReportRows")]
        public virtual System.Nullable<int> MaxReportRows { get; set; }

        /// <summary>List of metrics of the report. A report must specify at least one metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<string> Metrics { get; set; }

        /// <summary>
        /// Describes the sorting of report rows. The order of the condition in the list defines its precedence; the
        /// earlier the condition, the higher its precedence. If no sort conditions are specified, the row ordering is
        /// undefined.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortConditions")]
        public virtual System.Collections.Generic.IList<MediationReportSpecSortCondition> SortConditions { get; set; }

        /// <summary>
        /// A report time zone. Accepts an IANA TZ name values, such as "America/Los_Angeles." If no time zone is
        /// defined, the account default takes effect. Check default value by the get account action. **Warning:** The
        /// "America/Los_Angeles" is the only supported value at the moment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes which report rows to match based on their dimension values.</summary>
    public class MediationReportSpecDimensionFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Applies the filter criterion to the specified dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual string Dimension { get; set; }

        /// <summary>
        /// Matches a row if its value for the specified dimension is in one of the values specified in this condition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchesAny")]
        public virtual StringList MatchesAny { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sorting direction to be applied on a dimension or a metric.</summary>
    public class MediationReportSpecSortCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Sort by the specified dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual string Dimension { get; set; }

        /// <summary>Sort by the specified metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metric")]
        public virtual string Metric { get; set; }

        /// <summary>Sorting order of the dimension or metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("order")]
        public virtual string Order { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The specification for generating an AdMob Network report. For example, the specification to get clicks and
    /// estimated earnings for only the 'US' and 'CN' countries can look like the following example: { 'date_range': {
    /// 'start_date': {'year': 2021, 'month': 9, 'day': 1}, 'end_date': {'year': 2021, 'month': 9, 'day': 30} },
    /// 'dimensions': ['DATE', 'APP', 'COUNTRY'], 'metrics': ['CLICKS', 'ESTIMATED_EARNINGS'], 'dimension_filters': [ {
    /// 'dimension': 'COUNTRY', 'matches_any': {'values': [{'value': 'US', 'value': 'CN'}]} } ], 'sort_conditions': [
    /// {'dimension':'APP', order: 'ASCENDING'}, {'metric':'CLICKS', order: 'DESCENDING'} ], 'localization_settings': {
    /// 'currency_code': 'USD', 'language_code': 'en-US' } } For a better understanding, you can treat the preceding
    /// specification like the following pseudo SQL: SELECT DATE, APP, COUNTRY, CLICKS, ESTIMATED_EARNINGS FROM
    /// NETWORK_REPORT WHERE DATE &amp;gt;= '2021-09-01' AND DATE &amp;lt;= '2021-09-30' AND COUNTRY IN ('US', 'CN')
    /// GROUP BY DATE, APP, COUNTRY ORDER BY APP ASC, CLICKS DESC;
    /// </summary>
    public class NetworkReportSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The date range for which the report is generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateRange")]
        public virtual DateRange DateRange { get; set; }

        /// <summary>Describes which report rows to match based on their dimension values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionFilters")]
        public virtual System.Collections.Generic.IList<NetworkReportSpecDimensionFilter> DimensionFilters { get; set; }

        /// <summary>
        /// List of dimensions of the report. The value combination of these dimensions determines the row of the
        /// report. If no dimensions are specified, the report returns a single row of requested metrics for the entire
        /// account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<string> Dimensions { get; set; }

        /// <summary>Localization settings of the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizationSettings")]
        public virtual LocalizationSettings LocalizationSettings { get; set; }

        /// <summary>
        /// Maximum number of report data rows to return. If the value is not set, the API returns as many rows as
        /// possible, up to 100000. Acceptable values are 1-100000, inclusive. Values larger than 100000 return an
        /// error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxReportRows")]
        public virtual System.Nullable<int> MaxReportRows { get; set; }

        /// <summary>List of metrics of the report. A report must specify at least one metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<string> Metrics { get; set; }

        /// <summary>
        /// Describes the sorting of report rows. The order of the condition in the list defines its precedence; the
        /// earlier the condition, the higher its precedence. If no sort conditions are specified, the row ordering is
        /// undefined.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortConditions")]
        public virtual System.Collections.Generic.IList<NetworkReportSpecSortCondition> SortConditions { get; set; }

        /// <summary>
        /// A report time zone. Accepts an IANA TZ name values, such as "America/Los_Angeles." If no time zone is
        /// defined, the account default takes effect. Check default value by the get account action. **Warning:** The
        /// "America/Los_Angeles" is the only supported value at the moment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes which report rows to match based on their dimension values.</summary>
    public class NetworkReportSpecDimensionFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Applies the filter criterion to the specified dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual string Dimension { get; set; }

        /// <summary>
        /// Matches a row if its value for the specified dimension is in one of the values specified in this condition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchesAny")]
        public virtual StringList MatchesAny { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sorting direction to be applied on a dimension or a metric.</summary>
    public class NetworkReportSpecSortCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Sort by the specified dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual string Dimension { get; set; }

        /// <summary>Sort by the specified metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metric")]
        public virtual string Metric { get; set; }

        /// <summary>Sorting order of the dimension or metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("order")]
        public virtual string Order { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A publisher account contains information relevant to the use of this API, such as the time zone used for the
    /// reports.
    /// </summary>
    public class PublisherAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Currency code of the earning-related metrics, which is the 3-letter code defined in ISO 4217. The daily
        /// average rate is used for the currency conversion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>Resource name of this account. Format is accounts/{publisher_id}.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The unique ID by which this publisher account can be identified in the API requests (for example,
        /// pub-1234567890).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherId")]
        public virtual string PublisherId { get; set; }

        /// <summary>
        /// The time zone that is used in reports that are generated for this account. The value is a time-zone ID as
        /// specified by the CLDR project, for example, "America/Los_Angeles".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingTimeZone")]
        public virtual string ReportingTimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Groups data available after report generation, for example, warnings and row counts. Always sent as the last
    /// message in the stream response.
    /// </summary>
    public class ReportFooter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Total number of rows that matched the request. Warning: This count does NOT always match the number of rows
        /// in the response. Do not make that assumption when processing the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchingRowCount")]
        public virtual System.Nullable<long> MatchingRowCount { get; set; }

        /// <summary>Warnings associated with generation of the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<ReportWarning> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Groups data helps to treat the generated report. Always sent as a first message in the stream response.
    /// </summary>
    public class ReportHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The date range for which the report is generated. This is identical to the range specified in the report
        /// request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateRange")]
        public virtual DateRange DateRange { get; set; }

        /// <summary>
        /// Localization settings of the report. This is identical to the settings in the report request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizationSettings")]
        public virtual LocalizationSettings LocalizationSettings { get; set; }

        /// <summary>
        /// The report time zone. The value is a time-zone ID as specified by the CLDR project, for example,
        /// "America/Los_Angeles".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingTimeZone")]
        public virtual string ReportingTimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A row of the returning report.</summary>
    public class ReportRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Map of dimension values in a row, with keys as enum name of the dimensions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionValues")]
        public virtual System.Collections.Generic.IDictionary<string, ReportRowDimensionValue> DimensionValues { get; set; }

        /// <summary>
        /// Map of metric values in a row, with keys as enum name of the metrics. If a metric being requested has no
        /// value returned, the map will not include it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricValues")]
        public virtual System.Collections.Generic.IDictionary<string, ReportRowMetricValue> MetricValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of a dimension value.</summary>
    public class ReportRowDimensionValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The localized string representation of the value. If unspecified, the display label should be derived from
        /// the value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayLabel")]
        public virtual string DisplayLabel { get; set; }

        /// <summary>Dimension value in the format specified in the report's spec Dimension enum.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of a metric value.</summary>
    public class ReportRowMetricValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Double precision (approximate) decimal values. Rates are from 0 to 1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        /// <summary>Metric integer value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integerValue")]
        public virtual System.Nullable<long> IntegerValue { get; set; }

        /// <summary>
        /// Amount in micros. One million is equivalent to one unit. Currency value is in the unit (USD, EUR or other)
        /// specified by the request. For example, $6.50 whould be represented as 6500000 micros.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("microsValue")]
        public virtual System.Nullable<long> MicrosValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Warnings associated with generation of the report.</summary>
    public class ReportWarning : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Describes the details of the warning message, in English.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Type of the warning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to end the mediation A/B experiment and choose a winning variant.</summary>
    public class StopMediationAbExperimentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The choice for the winning variant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variantChoice")]
        public virtual string VariantChoice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of string values.</summary>
    public class StringList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The string values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
