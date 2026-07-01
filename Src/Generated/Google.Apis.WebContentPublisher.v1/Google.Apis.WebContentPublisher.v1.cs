// Copyright 2026 Google LLC
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

namespace Google.Apis.WebContentPublisher.v1
{
    /// <summary>The WebContentPublisher Service.</summary>
    public class WebContentPublisherService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public WebContentPublisherService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public WebContentPublisherService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Organizations = new OrganizationsResource(this);
            Publications = new PublicationsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://webcontentpublisher.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://webcontentpublisher.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "webcontentpublisher";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Web Content Publisher API.</summary>
        public class Scope
        {
            /// <summary>
            /// Private Service: https://www.googleapis.com/auth/subscribewithgoogle.publications.entitlements.manage
            /// </summary>
            public static string SubscribewithgooglePublicationsEntitlementsManage = "https://www.googleapis.com/auth/subscribewithgoogle.publications.entitlements.manage";

            /// <summary>See and review your subscription information</summary>
            public static string SubscribewithgooglePublicationsEntitlementsReadonly = "https://www.googleapis.com/auth/subscribewithgoogle.publications.entitlements.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Web Content Publisher API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// Private Service: https://www.googleapis.com/auth/subscribewithgoogle.publications.entitlements.manage
            /// </summary>
            public const string SubscribewithgooglePublicationsEntitlementsManage = "https://www.googleapis.com/auth/subscribewithgoogle.publications.entitlements.manage";

            /// <summary>See and review your subscription information</summary>
            public const string SubscribewithgooglePublicationsEntitlementsReadonly = "https://www.googleapis.com/auth/subscribewithgoogle.publications.entitlements.readonly";
        }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }

        /// <summary>Gets the Publications resource.</summary>
        public virtual PublicationsResource Publications { get; }
    }

    /// <summary>A base abstract class for WebContentPublisher requests.</summary>
    public abstract class WebContentPublisherBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new WebContentPublisherBaseServiceRequest instance.</summary>
        protected WebContentPublisherBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes WebContentPublisher parameter list.</summary>
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

    /// <summary>The "organizations" collection of methods.</summary>
    public class OrganizationsResource
    {
        private const string Resource = "organizations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OrganizationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Publications = new PublicationsResource(service);
        }

        /// <summary>Gets the Publications resource.</summary>
        public virtual PublicationsResource Publications { get; }

        /// <summary>The "publications" collection of methods.</summary>
        public class PublicationsResource
        {
            private const string Resource = "publications";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public PublicationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Ctas = new CtasResource(service);
            }

            /// <summary>Gets the Ctas resource.</summary>
            public virtual CtasResource Ctas { get; }

            /// <summary>The "ctas" collection of methods.</summary>
            public class CtasResource
            {
                private const string Resource = "ctas";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public CtasResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a CTA.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent publication resource where this CTA will be created. Format:
                /// `organizations/{organization}/publications/{publication}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.WebContentPublisher.v1.Data.Cta body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a CTA.</summary>
                public class CreateRequest : WebContentPublisherBaseServiceRequest<Google.Apis.WebContentPublisher.v1.Data.Cta>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.WebContentPublisher.v1.Data.Cta body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent publication resource where this CTA will be created. Format:
                    /// `organizations/{organization}/publications/{publication}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The unique identifier of the CTA to create. If not specified, the server will generate
                    /// a random CTA ID.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("ctaId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string CtaId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.WebContentPublisher.v1.Data.Cta Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/ctas";

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
                            Pattern = @"^organizations/[^/]+/publications/[^/]+$",
                        });
                        RequestParameters.Add("ctaId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "ctaId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets a CTA.</summary>
                /// <param name="name">
                /// Required. The resource name of the CTA to retrieve. Format:
                /// `organizations/{organization}/publications/{publication}/ctas/{cta}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a CTA.</summary>
                public class GetRequest : WebContentPublisherBaseServiceRequest<Google.Apis.WebContentPublisher.v1.Data.Cta>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the CTA to retrieve. Format:
                    /// `organizations/{organization}/publications/{publication}/ctas/{cta}`.
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
                            Pattern = @"^organizations/[^/]+/publications/[^/]+/ctas/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists CTAs.</summary>
                /// <param name="parent">
                /// Required. The parent publication resource whose CTAs to list. Format:
                /// `organizations/{organization}/publications/{publication}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists CTAs.</summary>
                public class ListRequest : WebContentPublisherBaseServiceRequest<Google.Apis.WebContentPublisher.v1.Data.ListCtasResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent publication resource whose CTAs to list. Format:
                    /// `organizations/{organization}/publications/{publication}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of CTAs to return. The service may return fewer than this value. If
                    /// unspecified, at most 50 CTAs will be returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListCtas` call, to retrieve the next page.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/ctas";

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
                            Pattern = @"^organizations/[^/]+/publications/[^/]+$",
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

            /// <summary>Creates a publication.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent resource where this publication will be created. Format:
            /// `organizations/{organization}`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.WebContentPublisher.v1.Data.Publication body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates a publication.</summary>
            public class CreateRequest : WebContentPublisherBaseServiceRequest<Google.Apis.WebContentPublisher.v1.Data.Publication>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.WebContentPublisher.v1.Data.Publication body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource where this publication will be created. Format:
                /// `organizations/{organization}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The unique identifier of the publication to create. If not specified, the server will
                /// generate a random publication ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("publicationId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PublicationId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.WebContentPublisher.v1.Data.Publication Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/publications";

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
                        Pattern = @"^organizations/[^/]+$",
                    });
                    RequestParameters.Add("publicationId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "publicationId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets a publication.</summary>
            /// <param name="name">
            /// Required. The resource name of the publication to retrieve. Format:
            /// `organizations/{organization}/publications/{publication}`.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a publication.</summary>
            public class GetRequest : WebContentPublisherBaseServiceRequest<Google.Apis.WebContentPublisher.v1.Data.Publication>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the publication to retrieve. Format:
                /// `organizations/{organization}/publications/{publication}`.
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
                        Pattern = @"^organizations/[^/]+/publications/[^/]+$",
                    });
                }
            }

            /// <summary>Lists publications.</summary>
            /// <param name="parent">
            /// Required. The parent organization whose publications to list. Format: `organizations/{organization}`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists publications.</summary>
            public class ListRequest : WebContentPublisherBaseServiceRequest<Google.Apis.WebContentPublisher.v1.Data.ListPublicationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent organization whose publications to list. Format:
                /// `organizations/{organization}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional. A filter expression to filter the publications returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. The maximum number of publications to return. The service may return fewer than this
                /// value. If unspecified, at most 50 publications will be returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListPublications` call, to retrieve the next page.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/publications";

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
                        Pattern = @"^organizations/[^/]+$",
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

            /// <summary>Updates a publication.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Identifier. The resource name of the publication. Format:
            /// organizations/{organization}/publications/{publication}
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.WebContentPublisher.v1.Data.Publication body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates a publication.</summary>
            public class PatchRequest : WebContentPublisherBaseServiceRequest<Google.Apis.WebContentPublisher.v1.Data.Publication>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.WebContentPublisher.v1.Data.Publication body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier. The resource name of the publication. Format:
                /// organizations/{organization}/publications/{publication}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Optional. The list of fields to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.WebContentPublisher.v1.Data.Publication Body { get; set; }

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
                        Pattern = @"^organizations/[^/]+/publications/[^/]+$",
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

    /// <summary>The "publications" collection of methods.</summary>
    public class PublicationsResource
    {
        private const string Resource = "publications";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PublicationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Checks if a user is eligible for free article access.</summary>
        /// <param name="name">
        /// Required. The resource name of the publication. Format: publications/{publication_id}
        /// </param>
        public virtual CheckFreeAccessRequest CheckFreeAccess(string name)
        {
            return new CheckFreeAccessRequest(this.service, name);
        }

        /// <summary>Checks if a user is eligible for free article access.</summary>
        public class CheckFreeAccessRequest : WebContentPublisherBaseServiceRequest<Google.Apis.WebContentPublisher.v1.Data.CheckFreeAccessResponse>
        {
            /// <summary>Constructs a new CheckFreeAccess request.</summary>
            public CheckFreeAccessRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The resource name of the publication. Format: publications/{publication_id}</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Required. The HTTP referrer.</summary>
            [Google.Apis.Util.RequestParameterAttribute("httpReferrer", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string HttpReferrer { get; set; }

            /// <summary>Required. The URI of the content.</summary>
            [Google.Apis.Util.RequestParameterAttribute("uri", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Uri { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "checkFreeAccess";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:checkFreeAccess";

            /// <summary>Initializes CheckFreeAccess parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^publications/[^/]+$",
                });
                RequestParameters.Add("httpReferrer", new Google.Apis.Discovery.Parameter
                {
                    Name = "httpReferrer",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("uri", new Google.Apis.Discovery.Parameter
                {
                    Name = "uri",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.WebContentPublisher.v1.Data
{
    /// <summary>Response message for CheckFreeAccess</summary>
    public class CheckFreeAccessResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. True if free access should be allowed, false otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isAllowed")]
        public virtual System.Nullable<bool> IsAllowed { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The content policy status of the publication, indicating any violations.</summary>
    public class ContentPolicyStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. URL pointing to more details about the policy violation or status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyInfoUrl")]
        public virtual string PolicyInfoUrl { get; set; }

        /// <summary>Output only. The current policy state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Call-To-Action (CTA) configuration for a publication.</summary>
    public class Cta : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The user-visible display name of the CTA.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Identifier. The resource name of the Cta. Format:
        /// organizations/{organization}/publications/{publication}/ctas/{cta}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Configuration specific to newsletter signup CTAs. Only populated if type is `NEWSLETTER_SIGNUP`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newsletterConfig")]
        public virtual NewsletterConfig NewsletterConfig { get; set; }

        /// <summary>Output only. The current state of this CTA.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Required. The type of this CTA.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a domain property associated with a publication, typically used to verify ownership and scope access.
    /// </summary>
    public class DomainProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Whether the domain ownership has been verified (e.g., via Google Search Console).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownershipVerified")]
        public virtual System.Nullable<bool> OwnershipVerified { get; set; }

        /// <summary>Required. The URL of the domain property (e.g., "https://example.com").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `ListCtas`.</summary>
    public class ListCtasResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The list of CTAs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ctas")]
        public virtual System.Collections.Generic.IList<Cta> Ctas { get; set; }

        /// <summary>
        /// Output only. A token to retrieve the next page of results, or empty if there are no more results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `ListPublications`.</summary>
    public class ListPublicationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. A token to retrieve the next page of results, or empty if there are no more results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Output only. The list of publications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publications")]
        public virtual System.Collections.Generic.IList<Publication> Publications { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for newsletter signup calls-to-action (CTAs).</summary>
    public class NewsletterConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Custom consent or disclosure text shown to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customConsentText")]
        public virtual string CustomConsentText { get; set; }

        /// <summary>Optional. A custom message displayed to the user in the signup prompt.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customMessage")]
        public virtual string CustomMessage { get; set; }

        /// <summary>Optional. Whether the user is required to provide their name to sign up.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nameRequired")]
        public virtual System.Nullable<bool> NameRequired { get; set; }

        /// <summary>Required. The title of the newsletter signup prompt.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a publisher's publication in Reader Revenue Manager.</summary>
    public class Publication : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Additional domain properties verified for the publication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalDomains")]
        public virtual System.Collections.Generic.IList<DomainProperty> AdditionalDomains { get; set; }

        /// <summary>Output only. The content policy compliance status of the publication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentPolicyStatus")]
        public virtual ContentPolicyStatus ContentPolicyStatus { get; set; }

        /// <summary>Required. The user-visible display name of the publication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Required. The primary language of the publication (BCP-47 code, e.g., "en-US").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Identifier. The resource name of the publication. Format:
        /// organizations/{organization}/publications/{publication}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The current onboarding state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onboardingState")]
        public virtual string OnboardingState { get; set; }

        /// <summary>Output only. The unique identifier of the organization that owns this publication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organizationId")]
        public virtual string OrganizationId { get; set; }

        /// <summary>Output only. The configured payment option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paymentOption")]
        public virtual string PaymentOption { get; set; }

        /// <summary>Required. The primary domain property associated with the publication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryDomain")]
        public virtual DomainProperty PrimaryDomain { get; set; }

        /// <summary>Output only. The list of active products/features enabled for this publication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("products")]
        public virtual System.Collections.Generic.IList<string> Products { get; set; }

        /// <summary>Output only. The unique identifier of the publication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicationId")]
        public virtual string PublicationId { get; set; }

        /// <summary>Optional. The URL to the publisher's Privacy Policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicationPrivacyPolicyUrl")]
        public virtual string PublicationPrivacyPolicyUrl { get; set; }

        /// <summary>Optional. The URL to the publisher's own Terms of Service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicationTosUrl")]
        public virtual string PublicationTosUrl { get; set; }

        /// <summary>
        /// Required. The ISO 3166-1 alpha-2 region code where the publication is registered (e.g., "US").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>Optional. Reader Revenue Manager product settings and status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rrmProduct")]
        public virtual RrmProduct RrmProduct { get; set; }

        /// <summary>Optional. Subscription Linking product configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slProduct")]
        public virtual SlProduct SlProduct { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration and status of the Reader Revenue Manager (RRM) product for a publication.</summary>
    public class RrmProduct : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Whether the RRM product is enabled for the publication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>Output only. The URL to the product-specific Terms of Service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTosUrl")]
        public virtual string ProductTosUrl { get; set; }

        /// <summary>Optional. The details of the TOS acceptance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tosAcceptance")]
        public virtual TosAcceptance TosAcceptance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Subscription Linking (SL) product settings and status.</summary>
    public class SlProduct : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Whether the Subscription Linking product is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>Optional. The Google Cloud Project number associated with the publication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpProjectNumber")]
        public virtual System.Nullable<long> GcpProjectNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about the acceptance of the Terms of Service (TOS).</summary>
    public class TosAcceptance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The name of the person who accepted the TOS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signer")]
        public virtual string Signer { get; set; }

        /// <summary>Optional. The job title or role of the signer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signerTitle")]
        public virtual string SignerTitle { get; set; }

        /// <summary>Required. Whether the user has accepted the Terms of Service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAccepted")]
        public virtual System.Nullable<bool> UserAccepted { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
