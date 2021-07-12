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

namespace Google.Apis.Ideahub.v1alpha
{
    /// <summary>The Ideahub Service.</summary>
    public class IdeahubService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public IdeahubService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public IdeahubService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Ideas = new IdeasResource(this);
            Platforms = new PlatformsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "ideahub";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://ideahub.googleapis.com/";
        #else
            "https://ideahub.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://ideahub.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Gets the Ideas resource.</summary>
        public virtual IdeasResource Ideas { get; }

        /// <summary>Gets the Platforms resource.</summary>
        public virtual PlatformsResource Platforms { get; }
    }

    /// <summary>A base abstract class for Ideahub requests.</summary>
    public abstract class IdeahubBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new IdeahubBaseServiceRequest instance.</summary>
        protected IdeahubBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Ideahub parameter list.</summary>
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

    /// <summary>The "ideas" collection of methods.</summary>
    public class IdeasResource
    {
        private const string Resource = "ideas";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public IdeasResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>List ideas for a given Creator and filter and sort options.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>List ideas for a given Creator and filter and sort options.</summary>
        public class ListRequest : IdeahubBaseServiceRequest<Google.Apis.Ideahub.v1alpha.Data.GoogleSearchIdeahubV1alphaListIdeasResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Identifies the platform from which this user is accessing Idea Hub.</summary>
            [Google.Apis.Util.RequestParameterAttribute("creator.platform", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<CreatorPlatformEnum> CreatorPlatform { get; set; }

            /// <summary>Identifies the platform from which this user is accessing Idea Hub.</summary>
            public enum CreatorPlatformEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("UNKNOWN")]
                UNKNOWN = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("BLOGGER")]
                BLOGGER = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("SITEKIT")]
                SITEKIT = 2,
            }

            /// <summary>Identifies the platform account (blog/site/etc.) for which to fetch Ideas.</summary>
            [Google.Apis.Util.RequestParameterAttribute("creator.platformId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CreatorPlatformId { get; set; }

            /// <summary>
            /// Allows filtering. Supported syntax: * Filter expressions are made up of one or more restrictions. *
            /// Restrictions are implicitly combined, as if the `AND` operator was always used. The `OR` operator is
            /// currently unsupported. * Supported functions: - `saved(bool)`: If set to true, fetches only saved ideas.
            /// If set to false, fetches all except saved ideas. Can't be simultaneously used with `dismissed(bool)`. -
            /// `dismissed(bool)`: If set to true, fetches only dismissed ideas. Can't be simultaneously used with
            /// `saved(bool)`. The `false` value is currently unsupported. Examples: * `saved(true)` * `saved(false)` *
            /// `dismissed(true)` The length of this field should be no more than 500 characters.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>Order semantics described below.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>
            /// The maximum number of ideas per page. If unspecified, at most 10 ideas will be returned. The maximum
            /// value is 2000; values above 2000 will be coerced to 2000.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>Used to fetch next page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// If defined, specifies the creator for which to filter by. Format:
            /// publishers/{publisher}/properties/{property}
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parent { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/ideas";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("creator.platform", new Google.Apis.Discovery.Parameter
                {
                    Name = "creator.platform",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("creator.platformId", new Google.Apis.Discovery.Parameter
                {
                    Name = "creator.platformId",
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
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
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
            Properties = new PropertiesResource(service);
        }

        /// <summary>Gets the Properties resource.</summary>
        public virtual PropertiesResource Properties { get; }

        /// <summary>The "properties" collection of methods.</summary>
        public class PropertiesResource
        {
            private const string Resource = "properties";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public PropertiesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                IdeaActivities = new IdeaActivitiesResource(service);
                IdeaStates = new IdeaStatesResource(service);
                Ideas = new IdeasResource(service);
                Locales = new LocalesResource(service);
                TopicStates = new TopicStatesResource(service);
            }

            /// <summary>Gets the IdeaActivities resource.</summary>
            public virtual IdeaActivitiesResource IdeaActivities { get; }

            /// <summary>The "ideaActivities" collection of methods.</summary>
            public class IdeaActivitiesResource
            {
                private const string Resource = "ideaActivities";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public IdeaActivitiesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates an idea activity entry.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource where this idea activity will be created. Format:
                /// platforms/{platform}/property/{property}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Ideahub.v1alpha.Data.GoogleSearchIdeahubV1alphaIdeaActivity body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates an idea activity entry.</summary>
                public class CreateRequest : IdeahubBaseServiceRequest<Google.Apis.Ideahub.v1alpha.Data.GoogleSearchIdeahubV1alphaIdeaActivity>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Ideahub.v1alpha.Data.GoogleSearchIdeahubV1alphaIdeaActivity body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource where this idea activity will be created. Format:
                    /// platforms/{platform}/property/{property}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Ideahub.v1alpha.Data.GoogleSearchIdeahubV1alphaIdeaActivity Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/ideaActivities";

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
                            Pattern = @"^platforms/[^/]+/properties/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the IdeaStates resource.</summary>
            public virtual IdeaStatesResource IdeaStates { get; }

            /// <summary>The "ideaStates" collection of methods.</summary>
            public class IdeaStatesResource
            {
                private const string Resource = "ideaStates";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public IdeaStatesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Update an idea state resource.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Unique identifier for the idea state. Format:
                /// platforms/{platform}/properties/{property}/ideaStates/{idea_state}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Ideahub.v1alpha.Data.GoogleSearchIdeahubV1alphaIdeaState body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Update an idea state resource.</summary>
                public class PatchRequest : IdeahubBaseServiceRequest<Google.Apis.Ideahub.v1alpha.Data.GoogleSearchIdeahubV1alphaIdeaState>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Ideahub.v1alpha.Data.GoogleSearchIdeahubV1alphaIdeaState body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Unique identifier for the idea state. Format:
                    /// platforms/{platform}/properties/{property}/ideaStates/{idea_state}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The list of fields to be updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Ideahub.v1alpha.Data.GoogleSearchIdeahubV1alphaIdeaState Body { get; set; }

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
                            Pattern = @"^platforms/[^/]+/properties/[^/]+/ideaStates/[^/]+$",
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

            /// <summary>Gets the Ideas resource.</summary>
            public virtual IdeasResource Ideas { get; }

            /// <summary>The "ideas" collection of methods.</summary>
            public class IdeasResource
            {
                private const string Resource = "ideas";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public IdeasResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>List ideas for a given Creator and filter and sort options.</summary>
                /// <param name="parent">
                /// If defined, specifies the creator for which to filter by. Format:
                /// publishers/{publisher}/properties/{property}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>List ideas for a given Creator and filter and sort options.</summary>
                public class ListRequest : IdeahubBaseServiceRequest<Google.Apis.Ideahub.v1alpha.Data.GoogleSearchIdeahubV1alphaListIdeasResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// If defined, specifies the creator for which to filter by. Format:
                    /// publishers/{publisher}/properties/{property}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Identifies the platform from which this user is accessing Idea Hub.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("creator.platform", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<CreatorPlatformEnum> CreatorPlatform { get; set; }

                    /// <summary>Identifies the platform from which this user is accessing Idea Hub.</summary>
                    public enum CreatorPlatformEnum
                    {
                        /// <summary></summary>
                        [Google.Apis.Util.StringValueAttribute("UNKNOWN")]
                        UNKNOWN = 0,

                        /// <summary></summary>
                        [Google.Apis.Util.StringValueAttribute("BLOGGER")]
                        BLOGGER = 1,

                        /// <summary></summary>
                        [Google.Apis.Util.StringValueAttribute("SITEKIT")]
                        SITEKIT = 2,
                    }

                    /// <summary>Identifies the platform account (blog/site/etc.) for which to fetch Ideas.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("creator.platformId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string CreatorPlatformId { get; set; }

                    /// <summary>
                    /// Allows filtering. Supported syntax: * Filter expressions are made up of one or more
                    /// restrictions. * Restrictions are implicitly combined, as if the `AND` operator was always used.
                    /// The `OR` operator is currently unsupported. * Supported functions: - `saved(bool)`: If set to
                    /// true, fetches only saved ideas. If set to false, fetches all except saved ideas. Can't be
                    /// simultaneously used with `dismissed(bool)`. - `dismissed(bool)`: If set to true, fetches only
                    /// dismissed ideas. Can't be simultaneously used with `saved(bool)`. The `false` value is currently
                    /// unsupported. Examples: * `saved(true)` * `saved(false)` * `dismissed(true)` The length of this
                    /// field should be no more than 500 characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Order semantics described below.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// The maximum number of ideas per page. If unspecified, at most 10 ideas will be returned. The
                    /// maximum value is 2000; values above 2000 will be coerced to 2000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Used to fetch next page.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/ideas";

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
                            Pattern = @"^platforms/[^/]+/properties/[^/]+$",
                        });
                        RequestParameters.Add("creator.platform", new Google.Apis.Discovery.Parameter
                        {
                            Name = "creator.platform",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("creator.platformId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "creator.platformId",
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

            /// <summary>Gets the Locales resource.</summary>
            public virtual LocalesResource Locales { get; }

            /// <summary>The "locales" collection of methods.</summary>
            public class LocalesResource
            {
                private const string Resource = "locales";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public LocalesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Returns which locales ideas are available in for a given Creator.</summary>
                /// <param name="parent">
                /// Required. The web property to check idea availability for Format:
                /// platforms/{platform}/property/{property}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Returns which locales ideas are available in for a given Creator.</summary>
                public class ListRequest : IdeahubBaseServiceRequest<Google.Apis.Ideahub.v1alpha.Data.GoogleSearchIdeahubV1alphaListAvailableLocalesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The web property to check idea availability for Format:
                    /// platforms/{platform}/property/{property}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of locales to return. The service may return fewer than this value. If
                    /// unspecified, at most 100 locales will be returned. The maximum value is 100; values above 100
                    /// will be coerced to 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListAvailableLocales` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `ListAvailableLocales` must
                    /// match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/locales";

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
                            Pattern = @"^platforms/[^/]+/properties/[^/]+$",
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

            /// <summary>Gets the TopicStates resource.</summary>
            public virtual TopicStatesResource TopicStates { get; }

            /// <summary>The "topicStates" collection of methods.</summary>
            public class TopicStatesResource
            {
                private const string Resource = "topicStates";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public TopicStatesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Update a topic state resource.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Unique identifier for the topic state. Format:
                /// platforms/{platform}/properties/{property}/topicStates/{topic_state}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Ideahub.v1alpha.Data.GoogleSearchIdeahubV1alphaTopicState body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Update a topic state resource.</summary>
                public class PatchRequest : IdeahubBaseServiceRequest<Google.Apis.Ideahub.v1alpha.Data.GoogleSearchIdeahubV1alphaTopicState>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Ideahub.v1alpha.Data.GoogleSearchIdeahubV1alphaTopicState body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Unique identifier for the topic state. Format:
                    /// platforms/{platform}/properties/{property}/topicStates/{topic_state}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The list of fields to be updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Ideahub.v1alpha.Data.GoogleSearchIdeahubV1alphaTopicState Body { get; set; }

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
                            Pattern = @"^platforms/[^/]+/properties/[^/]+/topicStates/[^/]+$",
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
}
namespace Google.Apis.Ideahub.v1alpha.Data
{
    /// <summary>Represents locales that are available for a web property.</summary>
    public class GoogleSearchIdeahubV1alphaAvailableLocale : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A string in BCP 47 format, without a resource prefix.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual string Locale { get; set; }

        /// <summary>
        /// A string in BCP 47 format, prefixed with the platform and property name, and "locales/". Format:
        /// platforms/{platform}/properties/{property}/locales/{locale}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single Idea that we want to show the end user.</summary>
    public class GoogleSearchIdeahubV1alphaIdea : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unique identifier for the idea. Format: ideas/{ideaId}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The idea’s text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The Topics that match the idea.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topics")]
        public virtual System.Collections.Generic.IList<GoogleSearchIdeahubV1alphaTopic> Topics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An idea activity entry.</summary>
    public class GoogleSearchIdeahubV1alphaIdeaActivity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Idea IDs for this entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ideaIds")]
        public virtual System.Collections.Generic.IList<string> IdeaIds { get; set; }

        /// <summary>
        /// Unique identifier for the idea activity. Format:
        /// platforms/{platform}/properties/{property}/ideaActivities/{idea_activity}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The Topic IDs for this entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicIds")]
        public virtual System.Collections.Generic.IList<string> TopicIds { get; set; }

        /// <summary>The type of activity performed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The uri the activity relates to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents idea state specific to a web property.</summary>
    public class GoogleSearchIdeahubV1alphaIdeaState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the idea is dismissed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dismissed")]
        public virtual System.Nullable<bool> Dismissed { get; set; }

        /// <summary>
        /// Unique identifier for the idea state. Format:
        /// platforms/{platform}/properties/{property}/ideaStates/{idea_state}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Whether the idea is saved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("saved")]
        public virtual System.Nullable<bool> Saved { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response for whether ideas are available for a given web property on a platform, for the currently logged-in
    /// user.
    /// </summary>
    public class GoogleSearchIdeahubV1alphaListAvailableLocalesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Locales for which ideas are available for the given Creator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableLocales")]
        public virtual System.Collections.Generic.IList<GoogleSearchIdeahubV1alphaAvailableLocale> AvailableLocales { get; set; }

        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleSearchIdeahubV1alphaListIdeasResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Results for the ListIdeasRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ideas")]
        public virtual System.Collections.Generic.IList<GoogleSearchIdeahubV1alphaIdea> Ideas { get; set; }

        /// <summary>Used to fetch the next page in a subsequent request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Topic umbrella for a list of questions that a Creator may want to respond to.</summary>
    public class GoogleSearchIdeahubV1alphaTopic : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>String displayed to the creator indicating the name of the Topic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The mID of the topic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mid")]
        public virtual string Mid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents topic state specific to a web property.</summary>
    public class GoogleSearchIdeahubV1alphaTopicState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the topic is dismissed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dismissed")]
        public virtual System.Nullable<bool> Dismissed { get; set; }

        /// <summary>
        /// Unique identifier for the topic state. Format:
        /// platforms/{platform}/properties/{property}/topicStates/{topic_state}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Whether the topic is saved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("saved")]
        public virtual System.Nullable<bool> Saved { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
