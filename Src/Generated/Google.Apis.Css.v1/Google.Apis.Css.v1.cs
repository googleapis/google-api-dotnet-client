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

namespace Google.Apis.Css.v1
{
    /// <summary>The Css Service.</summary>
    public class CssService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CssService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CssService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Accounts = new AccountsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://css.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://css.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "css";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the CSS API.</summary>
        public class Scope
        {
            /// <summary>Manage your product listings and accounts for Google Shopping</summary>
            public static string Content = "https://www.googleapis.com/auth/content";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the CSS API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Manage your product listings and accounts for Google Shopping</summary>
            public const string Content = "https://www.googleapis.com/auth/content";
        }

        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }
    }

    /// <summary>A base abstract class for Css requests.</summary>
    public abstract class CssBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CssBaseServiceRequest instance.</summary>
        protected CssBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Css parameter list.</summary>
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
            CssProductInputs = new CssProductInputsResource(service);
            CssProducts = new CssProductsResource(service);
            Labels = new LabelsResource(service);
            Quotas = new QuotasResource(service);
        }

        /// <summary>Gets the CssProductInputs resource.</summary>
        public virtual CssProductInputsResource CssProductInputs { get; }

        /// <summary>The "cssProductInputs" collection of methods.</summary>
        public class CssProductInputsResource
        {
            private const string Resource = "cssProductInputs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CssProductInputsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Deletes a CSS Product input from your CSS Center account. After a delete it may take several minutes
            /// until the input is no longer available.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the CSS product input resource to delete. Format:
            /// accounts/{account}/cssProductInputs/{css_product_input}, where the last section `css_product_input`
            /// consists of 3 parts: contentLanguage~feedLabel~offerId. Example:
            /// accounts/123/cssProductInputs/de~DE~rawProvidedId123
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes a CSS Product input from your CSS Center account. After a delete it may take several minutes
            /// until the input is no longer available.
            /// </summary>
            public class DeleteRequest : CssBaseServiceRequest<Google.Apis.Css.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the CSS product input resource to delete. Format:
                /// accounts/{account}/cssProductInputs/{css_product_input}, where the last section `css_product_input`
                /// consists of 3 parts: contentLanguage~feedLabel~offerId. Example:
                /// accounts/123/cssProductInputs/de~DE~rawProvidedId123
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// The Content API Supplemental Feed ID. The field must not be set if the action applies to a primary
                /// feed. If the field is set, then product action applies to a supplemental feed instead of primary
                /// Content API feed.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("supplementalFeedId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> SupplementalFeedId { get; set; }

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
                        Pattern = @"^accounts/[^/]+/cssProductInputs/[^/]+$",
                    });
                    RequestParameters.Add("supplementalFeedId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "supplementalFeedId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Uploads a CssProductInput to your CSS Center account. If an input with the same contentLanguage,
            /// identity, feedLabel and feedId already exists, this method replaces that entry. After inserting,
            /// updating, or deleting a CSS Product input, it may take several minutes before the processed CSS Product
            /// can be retrieved.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The account where this CSS Product will be inserted. Format: accounts/{account}
            /// </param>
            public virtual InsertRequest Insert(Google.Apis.Css.v1.Data.CssProductInput body, string parent)
            {
                return new InsertRequest(this.service, body, parent);
            }

            /// <summary>
            /// Uploads a CssProductInput to your CSS Center account. If an input with the same contentLanguage,
            /// identity, feedLabel and feedId already exists, this method replaces that entry. After inserting,
            /// updating, or deleting a CSS Product input, it may take several minutes before the processed CSS Product
            /// can be retrieved.
            /// </summary>
            public class InsertRequest : CssBaseServiceRequest<Google.Apis.Css.v1.Data.CssProductInput>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Css.v1.Data.CssProductInput body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account where this CSS Product will be inserted. Format: accounts/{account}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. DEPRECATED. Feed id is not required for CSS Products. The primary or supplemental feed id.
                /// If CSS Product already exists and feed id provided is different, then the CSS Product will be moved
                /// to a new feed. Note: For now, CSSs do not need to provide feed ids as we create feeds on the fly. We
                /// do not have supplemental feed support for CSS Products yet.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("feedId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> FeedId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Css.v1.Data.CssProductInput Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/cssProductInputs:insert";

                /// <summary>Initializes Insert parameter list.</summary>
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
                    RequestParameters.Add("feedId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "feedId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Updates the existing Css Product input in your CSS Center account. After inserting, updating, or
            /// deleting a CSS Product input, it may take several minutes before the processed Css Product can be
            /// retrieved.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The name of the CSS Product input. Format: `accounts/{account}/cssProductInputs/{css_product_input}`,
            /// where the last section `css_product_input` consists of 3 parts: contentLanguage~feedLabel~offerId.
            /// Example: accounts/123/cssProductInputs/de~DE~rawProvidedId123
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Css.v1.Data.CssProductInput body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates the existing Css Product input in your CSS Center account. After inserting, updating, or
            /// deleting a CSS Product input, it may take several minutes before the processed Css Product can be
            /// retrieved.
            /// </summary>
            public class PatchRequest : CssBaseServiceRequest<Google.Apis.Css.v1.Data.CssProductInput>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Css.v1.Data.CssProductInput body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The name of the CSS Product input. Format:
                /// `accounts/{account}/cssProductInputs/{css_product_input}`, where the last section
                /// `css_product_input` consists of 3 parts: contentLanguage~feedLabel~offerId. Example:
                /// accounts/123/cssProductInputs/de~DE~rawProvidedId123
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// The list of CSS product attributes to be updated. If the update mask is omitted, then it is treated
                /// as implied field mask equivalent to all fields that are populated (have a non-empty value).
                /// Attributes specified in the update mask without a value specified in the body will be deleted from
                /// the CSS product. Update mask can only be specified for top level fields in attributes and custom
                /// attributes. To specify the update mask for custom attributes you need to add the `custom_attribute.`
                /// prefix. Providing special "*" value for full CSS product replacement is not supported.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Css.v1.Data.CssProductInput Body { get; set; }

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
                        Pattern = @"^accounts/[^/]+/cssProductInputs/[^/]+$",
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

        /// <summary>Gets the CssProducts resource.</summary>
        public virtual CssProductsResource CssProducts { get; }

        /// <summary>The "cssProducts" collection of methods.</summary>
        public class CssProductsResource
        {
            private const string Resource = "cssProducts";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CssProductsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Retrieves the processed CSS Product from your CSS Center account. After inserting, updating, or deleting
            /// a product input, it may take several minutes before the updated final product can be retrieved.
            /// </summary>
            /// <param name="name">Required. The name of the CSS product to retrieve.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>
            /// Retrieves the processed CSS Product from your CSS Center account. After inserting, updating, or deleting
            /// a product input, it may take several minutes before the updated final product can be retrieved.
            /// </summary>
            public class GetRequest : CssBaseServiceRequest<Google.Apis.Css.v1.Data.CssProduct>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The name of the CSS product to retrieve.</summary>
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
                        Pattern = @"^accounts/[^/]+/cssProducts/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists the processed CSS Products in your CSS Center account. The response might contain fewer items than
            /// specified by pageSize. Rely on pageToken to determine if there are more items to be requested. After
            /// inserting, updating, or deleting a CSS product input, it may take several minutes before the updated
            /// processed CSS product can be retrieved.
            /// </summary>
            /// <param name="parent">
            /// Required. The account/domain to list processed CSS Products for. Format: accounts/{account}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists the processed CSS Products in your CSS Center account. The response might contain fewer items than
            /// specified by pageSize. Rely on pageToken to determine if there are more items to be requested. After
            /// inserting, updating, or deleting a CSS product input, it may take several minutes before the updated
            /// processed CSS product can be retrieved.
            /// </summary>
            public class ListRequest : CssBaseServiceRequest<Google.Apis.Css.v1.Data.ListCssProductsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account/domain to list processed CSS Products for. Format: accounts/{account}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of CSS Products to return. The service may return fewer than this value. The
                /// maximum value is 1000; values above 1000 will be coerced to 1000. If unspecified, the maximum number
                /// of CSS products will be returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListCssProducts` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListCssProducts` must match the
                /// call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/cssProducts";

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

        /// <summary>Gets the Labels resource.</summary>
        public virtual LabelsResource Labels { get; }

        /// <summary>The "labels" collection of methods.</summary>
        public class LabelsResource
        {
            private const string Resource = "labels";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LabelsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a new label, not assigned to any account.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. The parent account. Format: accounts/{account}</param>
            public virtual CreateRequest Create(Google.Apis.Css.v1.Data.AccountLabel body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates a new label, not assigned to any account.</summary>
            public class CreateRequest : CssBaseServiceRequest<Google.Apis.Css.v1.Data.AccountLabel>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Css.v1.Data.AccountLabel body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The parent account. Format: accounts/{account}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Css.v1.Data.AccountLabel Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/labels";

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

            /// <summary>Deletes a label and removes it from all accounts to which it was assigned.</summary>
            /// <param name="name">
            /// Required. The name of the label to delete. Format: accounts/{account}/labels/{label}
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes a label and removes it from all accounts to which it was assigned.</summary>
            public class DeleteRequest : CssBaseServiceRequest<Google.Apis.Css.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the label to delete. Format: accounts/{account}/labels/{label}
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
                        Pattern = @"^accounts/[^/]+/labels/[^/]+$",
                    });
                }
            }

            /// <summary>Lists the labels owned by an account.</summary>
            /// <param name="parent">Required. The parent account. Format: accounts/{account}</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists the labels owned by an account.</summary>
            public class ListRequest : CssBaseServiceRequest<Google.Apis.Css.v1.Data.ListAccountLabelsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The parent account. Format: accounts/{account}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of labels to return. The service may return fewer than this value. If
                /// unspecified, at most 50 labels will be returned. The maximum value is 1000; values above 1000 will
                /// be coerced to 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListAccountLabels` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListAccountLabels` must match
                /// the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/labels";

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

            /// <summary>Updates a label.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">The resource name of the label. Format: accounts/{account}/labels/{label}</param>
            public virtual PatchRequest Patch(Google.Apis.Css.v1.Data.AccountLabel body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates a label.</summary>
            public class PatchRequest : CssBaseServiceRequest<Google.Apis.Css.v1.Data.AccountLabel>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Css.v1.Data.AccountLabel body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The resource name of the label. Format: accounts/{account}/labels/{label}</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Css.v1.Data.AccountLabel Body { get; set; }

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
                        Pattern = @"^accounts/[^/]+/labels/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the Quotas resource.</summary>
        public virtual QuotasResource Quotas { get; }

        /// <summary>The "quotas" collection of methods.</summary>
        public class QuotasResource
        {
            private const string Resource = "quotas";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public QuotasResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Lists the daily call quota and usage per group for your CSS Center account.</summary>
            /// <param name="parent">
            /// Required. The CSS account that owns the collection of method quotas and resources. In most cases, this
            /// is the CSS domain. Format: accounts/{account}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists the daily call quota and usage per group for your CSS Center account.</summary>
            public class ListRequest : CssBaseServiceRequest<Google.Apis.Css.v1.Data.ListQuotaGroupsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The CSS account that owns the collection of method quotas and resources. In most cases,
                /// this is the CSS domain. Format: accounts/{account}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of quotas to return in the response, used for paging. Defaults to 500;
                /// values above 1000 will be coerced to 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. Token (if provided) to retrieve the subsequent page. All other parameters must match the
                /// original call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/quotas";

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

        /// <summary>Retrieves a single CSS/MC account by ID.</summary>
        /// <param name="name">Required. The name of the managed CSS/MC account. Format: accounts/{account}</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>Retrieves a single CSS/MC account by ID.</summary>
        public class GetRequest : CssBaseServiceRequest<Google.Apis.Css.v1.Data.Account>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The name of the managed CSS/MC account. Format: accounts/{account}</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Optional. Only required when retrieving MC account information. The CSS domain that is the parent
            /// resource of the MC account. Format: accounts/{account}
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parent { get; set; }

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
                    Pattern = @"^accounts/[^/]+$",
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

        /// <summary>
        /// Lists all the accounts under the specified CSS account ID, and optionally filters by label ID and account
        /// name.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account. Must be a CSS group or domain. Format: accounts/{account}
        /// </param>
        public virtual ListChildAccountsRequest ListChildAccounts(string parent)
        {
            return new ListChildAccountsRequest(this.service, parent);
        }

        /// <summary>
        /// Lists all the accounts under the specified CSS account ID, and optionally filters by label ID and account
        /// name.
        /// </summary>
        public class ListChildAccountsRequest : CssBaseServiceRequest<Google.Apis.Css.v1.Data.ListChildAccountsResponse>
        {
            /// <summary>Constructs a new ListChildAccounts request.</summary>
            public ListChildAccountsRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
            {
                Parent = parent;
                InitParameters();
            }

            /// <summary>
            /// Required. The parent account. Must be a CSS group or domain. Format: accounts/{account}
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>If set, only the MC accounts with the given name (case sensitive) will be returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fullName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string FullName { get; set; }

            /// <summary>If set, only the MC accounts with the given label ID will be returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("labelId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> LabelId { get; set; }

            /// <summary>
            /// Optional. The maximum number of accounts to return. The service may return fewer than this value. If
            /// unspecified, at most 50 accounts will be returned. The maximum value is 100; values above 100 will be
            /// coerced to 100.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A page token, received from a previous `ListChildAccounts` call. Provide this to retrieve the
            /// subsequent page. When paginating, all other parameters provided to `ListChildAccounts` must match the
            /// call that provided the page token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listChildAccounts";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}:listChildAccounts";

            /// <summary>Initializes ListChildAccounts parameter list.</summary>
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
                RequestParameters.Add("fullName", new Google.Apis.Discovery.Parameter
                {
                    Name = "fullName",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("labelId", new Google.Apis.Discovery.Parameter
                {
                    Name = "labelId",
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

        /// <summary>Updates labels assigned to CSS/MC accounts by a CSS domain.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Required. The label resource name. Format: accounts/{account}</param>
        public virtual UpdateLabelsRequest UpdateLabels(Google.Apis.Css.v1.Data.UpdateAccountLabelsRequest body, string name)
        {
            return new UpdateLabelsRequest(this.service, body, name);
        }

        /// <summary>Updates labels assigned to CSS/MC accounts by a CSS domain.</summary>
        public class UpdateLabelsRequest : CssBaseServiceRequest<Google.Apis.Css.v1.Data.Account>
        {
            /// <summary>Constructs a new UpdateLabels request.</summary>
            public UpdateLabelsRequest(Google.Apis.Services.IClientService service, Google.Apis.Css.v1.Data.UpdateAccountLabelsRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The label resource name. Format: accounts/{account}</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Css.v1.Data.UpdateAccountLabelsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateLabels";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:updateLabels";

            /// <summary>Initializes UpdateLabels parameter list.</summary>
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
    }
}
namespace Google.Apis.Css.v1.Data
{
    /// <summary>Information about CSS/MC account.</summary>
    public class Account : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The type of this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountType")]
        public virtual string AccountType { get; set; }

        /// <summary>Automatically created label IDs assigned to the MC account by CSS Center.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automaticLabelIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> AutomaticLabelIds { get; set; }

        /// <summary>The CSS/MC account's short display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. Immutable. The CSS/MC account's full name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullName")]
        public virtual string FullName { get; set; }

        /// <summary>Output only. Immutable. The CSS/MC account's homepage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("homepageUri")]
        public virtual string HomepageUri { get; set; }

        /// <summary>Manually created label IDs assigned to the CSS/MC account by a CSS parent account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> LabelIds { get; set; }

        /// <summary>The label resource name. Format: accounts/{account}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The CSS/MC account's parent resource. CSS group for CSS domains; CSS domain for MC accounts. Returned only
        /// if the user has access to the parent account. Note: For MC sub-accounts, this is also the CSS domain that is
        /// the parent resource of the MCA account, since we are effectively flattening the hierarchy."
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Label assigned by CSS domain or CSS group to one of its sub-accounts.</summary>
    public class AccountLabel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The ID of account this label belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual System.Nullable<long> AccountId { get; set; }

        /// <summary>The description of this label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The display name of this label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. The ID of the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelId")]
        public virtual System.Nullable<long> LabelId { get; set; }

        /// <summary>Output only. The type of this label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelType")]
        public virtual string LabelType { get; set; }

        /// <summary>The resource name of the label. Format: accounts/{account}/labels/{label}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Attributes for CSS Product.</summary>
    public class Attributes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional URL of images of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalImageLinks")]
        public virtual System.Collections.Generic.IList<string> AdditionalImageLinks { get; set; }

        /// <summary>Set to true if the item is targeted towards adults.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adult")]
        public virtual System.Nullable<bool> Adult { get; set; }

        /// <summary>Target age group of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ageGroup")]
        public virtual string AgeGroup { get; set; }

        /// <summary>Product Related Attributes.[14-36] Brand of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brand")]
        public virtual string Brand { get; set; }

        /// <summary>A list of certificates claimed by the CSS for the given product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certifications")]
        public virtual System.Collections.Generic.IList<Certification> Certifications { get; set; }

        /// <summary>Color of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual string Color { get; set; }

        /// <summary>
        /// Allows advertisers to override the item URL when the product is shown within the context of Product Ads.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cppAdsRedirect")]
        public virtual string CppAdsRedirect { get; set; }

        /// <summary>URL directly linking to your the Product Detail Page of the CSS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cppLink")]
        public virtual string CppLink { get; set; }

        /// <summary>URL for the mobile-optimized version of the Product Detail Page of the CSS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cppMobileLink")]
        public virtual string CppMobileLink { get; set; }

        /// <summary>Custom label 0 for custom grouping of items in a Shopping campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLabel0")]
        public virtual string CustomLabel0 { get; set; }

        /// <summary>Custom label 1 for custom grouping of items in a Shopping campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLabel1")]
        public virtual string CustomLabel1 { get; set; }

        /// <summary>Custom label 2 for custom grouping of items in a Shopping campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLabel2")]
        public virtual string CustomLabel2 { get; set; }

        /// <summary>Custom label 3 for custom grouping of items in a Shopping campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLabel3")]
        public virtual string CustomLabel3 { get; set; }

        /// <summary>Custom label 4 for custom grouping of items in a Shopping campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLabel4")]
        public virtual string CustomLabel4 { get; set; }

        /// <summary>Description of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The list of destinations to exclude for this target (corresponds to unchecked check boxes in Merchant
        /// Center).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedDestinations")]
        public virtual System.Collections.Generic.IList<string> ExcludedDestinations { get; set; }

        private string _expirationDateRaw;

        private object _expirationDate;

        /// <summary>
        /// Date on which the item should expire, as specified upon insertion, in [ISO
        /// 8601](http://en.wikipedia.org/wiki/ISO_8601) format. The actual expiration date is exposed in
        /// `productstatuses` as [googleExpirationDate](https://support.google.com/merchants/answer/6324499) and might
        /// be earlier if `expirationDate` is too far in the future. Note: It may take 2+ days from the expiration date
        /// for the item to actually get deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationDate")]
        public virtual string ExpirationDateRaw
        {
            get => _expirationDateRaw;
            set
            {
                _expirationDate = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expirationDateRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpirationDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpirationDateDateTimeOffset instead.")]
        public virtual object ExpirationDate
        {
            get => _expirationDate;
            set
            {
                _expirationDateRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expirationDate = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpirationDateRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpirationDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpirationDateRaw);
            set => ExpirationDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Target gender of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gender")]
        public virtual string Gender { get; set; }

        /// <summary>
        /// Google's category of the item (see [Google product
        /// taxonomy](https://support.google.com/merchants/answer/1705911)). When querying products, this field will
        /// contain the user provided value. There is currently no way to get back the auto assigned google product
        /// categories through the API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleProductCategory")]
        public virtual string GoogleProductCategory { get; set; }

        /// <summary>
        /// Global Trade Item Number ([GTIN](https://support.google.com/merchants/answer/188494#gtin)) of the item.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gtin")]
        public virtual string Gtin { get; set; }

        /// <summary>Condition of the headline offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headlineOfferCondition")]
        public virtual string HeadlineOfferCondition { get; set; }

        /// <summary>Number and amount of installments to pay for an item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headlineOfferInstallment")]
        public virtual HeadlineOfferInstallment HeadlineOfferInstallment { get; set; }

        /// <summary>Link to the headline offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headlineOfferLink")]
        public virtual string HeadlineOfferLink { get; set; }

        /// <summary>Mobile Link to the headline offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headlineOfferMobileLink")]
        public virtual string HeadlineOfferMobileLink { get; set; }

        /// <summary>Headline Price of the CSS Product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headlineOfferPrice")]
        public virtual Price HeadlineOfferPrice { get; set; }

        /// <summary>Headline Price of the CSS Product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headlineOfferShippingPrice")]
        public virtual Price HeadlineOfferShippingPrice { get; set; }

        /// <summary>
        /// Number of periods (months or years) and amount of payment per period for an item with an associated
        /// subscription contract.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headlineOfferSubscriptionCost")]
        public virtual HeadlineOfferSubscriptionCost HeadlineOfferSubscriptionCost { get; set; }

        /// <summary>High Price of the CSS Product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("highPrice")]
        public virtual Price HighPrice { get; set; }

        /// <summary>URL of an image of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageLink")]
        public virtual string ImageLink { get; set; }

        /// <summary>
        /// The list of destinations to include for this target (corresponds to checked check boxes in Merchant Center).
        /// Default destinations are always included unless provided in `excludedDestinations`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedDestinations")]
        public virtual System.Collections.Generic.IList<string> IncludedDestinations { get; set; }

        /// <summary>
        /// Whether the item is a merchant-defined bundle. A bundle is a custom grouping of different products sold by a
        /// merchant for a single price.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isBundle")]
        public virtual System.Nullable<bool> IsBundle { get; set; }

        /// <summary>Shared identifier for all variants of the same product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemGroupId")]
        public virtual string ItemGroupId { get; set; }

        /// <summary>Low Price of the CSS Product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lowPrice")]
        public virtual Price LowPrice { get; set; }

        /// <summary>The material of which the item is made.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("material")]
        public virtual string Material { get; set; }

        /// <summary>
        /// Manufacturer Part Number ([MPN](https://support.google.com/merchants/answer/188494#mpn)) of the item.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mpn")]
        public virtual string Mpn { get; set; }

        /// <summary>The number of identical products in a merchant-defined multipack.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multipack")]
        public virtual System.Nullable<long> Multipack { get; set; }

        /// <summary>The number of CSS Products.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numberOfOffers")]
        public virtual System.Nullable<long> NumberOfOffers { get; set; }

        /// <summary>The item's pattern (e.g. polka dots).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pattern")]
        public virtual string Pattern { get; set; }

        /// <summary>Publication of this item will be temporarily paused.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pause")]
        public virtual string Pause { get; set; }

        /// <summary>Technical specification or additional product details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productDetails")]
        public virtual System.Collections.Generic.IList<ProductDetail> ProductDetails { get; set; }

        /// <summary>
        /// The height of the product in the units provided. The value must be between 0 (exclusive) and 3000
        /// (inclusive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productHeight")]
        public virtual ProductDimension ProductHeight { get; set; }

        /// <summary>Bullet points describing the most relevant highlights of a product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productHighlights")]
        public virtual System.Collections.Generic.IList<string> ProductHighlights { get; set; }

        /// <summary>
        /// The length of the product in the units provided. The value must be between 0 (exclusive) and 3000
        /// (inclusive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productLength")]
        public virtual ProductDimension ProductLength { get; set; }

        /// <summary>
        /// Categories of the item (formatted as in [products data
        /// specification](https://support.google.com/merchants/answer/6324406)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypes")]
        public virtual System.Collections.Generic.IList<string> ProductTypes { get; set; }

        /// <summary>
        /// The weight of the product in the units provided. The value must be between 0 (exclusive) and 2000
        /// (inclusive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productWeight")]
        public virtual ProductWeight ProductWeight { get; set; }

        /// <summary>
        /// The width of the product in the units provided. The value must be between 0 (exclusive) and 3000
        /// (inclusive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productWidth")]
        public virtual ProductDimension ProductWidth { get; set; }

        /// <summary>
        /// Size of the item. Only one value is allowed. For variants with different sizes, insert a separate product
        /// for each size with the same `itemGroupId` value (see
        /// [https://support.google.com/merchants/answer/6324492](size definition)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual string Size { get; set; }

        /// <summary>System in which the size is specified. Recommended for apparel items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeSystem")]
        public virtual string SizeSystem { get; set; }

        /// <summary>
        /// The cut of the item. It can be used to represent combined size types for apparel items. Maximum two of size
        /// types can be provided (see [https://support.google.com/merchants/answer/6324497](size type)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeTypes")]
        public virtual System.Collections.Generic.IList<string> SizeTypes { get; set; }

        /// <summary>Title of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The certification for the product. Use the this attribute to describe certifications, such as energy efficiency
    /// ratings, associated with a product.
    /// </summary>
    public class Certification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The authority or certification body responsible for issuing the certification. At this time, the most common
        /// value is "EC" or “European_Commission” for energy labels in the EU.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authority")]
        public virtual string Authority { get; set; }

        /// <summary>
        /// The code of the certification. For example, for the EPREL certificate with the link
        /// https://eprel.ec.europa.eu/screen/product/dishwashers2019/123456 the code is 123456. The code is required
        /// for European Energy Labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>
        /// The name of the certification. At this time, the most common value is "EPREL", which represents energy
        /// efficiency certifications in the EU European Registry for Energy Labeling (EPREL) database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The processed CSS Product.</summary>
    public class CssProduct : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. A list of product attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual Attributes Attributes { get; set; }

        /// <summary>
        /// Output only. The two-letter [ISO 639-1](http://en.wikipedia.org/wiki/ISO_639-1) language code for the
        /// product.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentLanguage")]
        public virtual string ContentLanguage { get; set; }

        /// <summary>
        /// Output only. The status of a product, data validation issues, that is, information about a product computed
        /// asynchronously.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cssProductStatus")]
        public virtual CssProductStatus CssProductStatus { get; set; }

        /// <summary>
        /// Output only. A list of custom (CSS-provided) attributes. It can also be used to submit any attribute of the
        /// feed specification in its generic form (for example, `{ "name": "size type", "value": "regular" }`). This is
        /// useful for submitting attributes not explicitly exposed by the API, such as additional attributes used for
        /// Buy on Google.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customAttributes")]
        public virtual System.Collections.Generic.IList<CustomAttribute> CustomAttributes { get; set; }

        /// <summary>Output only. The feed label for the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedLabel")]
        public virtual string FeedLabel { get; set; }

        /// <summary>The name of the CSS Product. Format: `"accounts/{account}/cssProducts/{css_product}"`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Your unique raw identifier for the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawProvidedId")]
        public virtual string RawProvidedId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This resource represents input data you submit for a CSS Product, not the processed CSS Product that you see in
    /// CSS Center, in Shopping Ads, or across Google surfaces.
    /// </summary>
    public class CssProductInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of CSS Product attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual Attributes Attributes { get; set; }

        /// <summary>
        /// Required. The two-letter [ISO 639-1](http://en.wikipedia.org/wiki/ISO_639-1) language code for the CSS
        /// Product.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentLanguage")]
        public virtual string ContentLanguage { get; set; }

        /// <summary>
        /// A list of custom (CSS-provided) attributes. It can also be used for submitting any attribute of the feed
        /// specification in its generic form (for example: `{ "name": "size type", "value": "regular" }`). This is
        /// useful for submitting attributes not explicitly exposed by the API, such as additional attributes used for
        /// Buy on Google.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customAttributes")]
        public virtual System.Collections.Generic.IList<CustomAttribute> CustomAttributes { get; set; }

        /// <summary>
        /// Required. The [feed label](https://developers.google.com/shopping-content/guides/products/feed-labels) for
        /// the CSS Product. Feed Label is synonymous to "target country" and hence should always be a valid region
        /// code. For example: 'DE' for Germany, 'FR' for France.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedLabel")]
        public virtual string FeedLabel { get; set; }

        /// <summary>
        /// Output only. The name of the processed CSS Product. Format: `accounts/{account}/cssProducts/{css_product}` "
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalName")]
        public virtual string FinalName { get; set; }

        private string _freshnessTimeRaw;

        private object _freshnessTime;

        /// <summary>
        /// DEPRECATED. Use expiration_date instead. Represents the existing version (freshness) of the CSS Product,
        /// which can be used to preserve the right order when multiple updates are done at the same time. This field
        /// must not be set to the future time. If set, the update is prevented if a newer version of the item already
        /// exists in our system (that is the last update time of the existing CSS products is later than the freshness
        /// time set in the update). If the update happens, the last update time is then set to this freshness time. If
        /// not set, the update will not be prevented and the last update time will default to when this request was
        /// received by the CSS API. If the operation is prevented, the aborted exception will be thrown.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freshnessTime")]
        public virtual string FreshnessTimeRaw
        {
            get => _freshnessTimeRaw;
            set
            {
                _freshnessTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _freshnessTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FreshnessTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FreshnessTimeDateTimeOffset instead.")]
        public virtual object FreshnessTime
        {
            get => _freshnessTime;
            set
            {
                _freshnessTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _freshnessTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="FreshnessTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FreshnessTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FreshnessTimeRaw);
            set => FreshnessTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The name of the CSS Product input. Format: `accounts/{account}/cssProductInputs/{css_product_input}`, where
        /// the last section `css_product_input` consists of 3 parts: contentLanguage~feedLabel~offerId. Example:
        /// accounts/123/cssProductInputs/de~DE~rawProvidedId123
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Your unique identifier for the CSS Product. This is the same for the CSS Product input and
        /// processed CSS Product. We only allow ids with alphanumerics, underscores and dashes. See the [products feed
        /// specification](https://support.google.com/merchants/answer/188494#id) for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawProvidedId")]
        public virtual string RawProvidedId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The status of the Css Product, data validation issues, that is, information about the Css Product computed
    /// asynchronously.
    /// </summary>
    public class CssProductStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _creationDateRaw;

        private object _creationDate;

        /// <summary>
        /// Date on which the item has been created, in [ISO 8601](http://en.wikipedia.org/wiki/ISO_8601) format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationDate")]
        public virtual string CreationDateRaw
        {
            get => _creationDateRaw;
            set
            {
                _creationDate = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _creationDateRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreationDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreationDateDateTimeOffset instead.")]
        public virtual object CreationDate
        {
            get => _creationDate;
            set
            {
                _creationDateRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _creationDate = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreationDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreationDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreationDateRaw);
            set => CreationDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The intended destinations for the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationStatuses")]
        public virtual System.Collections.Generic.IList<DestinationStatus> DestinationStatuses { get; set; }

        private string _googleExpirationDateRaw;

        private object _googleExpirationDate;

        /// <summary>
        /// Date on which the item expires, in [ISO 8601](http://en.wikipedia.org/wiki/ISO_8601) format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleExpirationDate")]
        public virtual string GoogleExpirationDateRaw
        {
            get => _googleExpirationDateRaw;
            set
            {
                _googleExpirationDate = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _googleExpirationDateRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="GoogleExpirationDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use GoogleExpirationDateDateTimeOffset instead.")]
        public virtual object GoogleExpirationDate
        {
            get => _googleExpirationDate;
            set
            {
                _googleExpirationDateRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _googleExpirationDate = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="GoogleExpirationDateRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? GoogleExpirationDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(GoogleExpirationDateRaw);
            set => GoogleExpirationDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>A list of all issues associated with the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemLevelIssues")]
        public virtual System.Collections.Generic.IList<ItemLevelIssue> ItemLevelIssues { get; set; }

        private string _lastUpdateDateRaw;

        private object _lastUpdateDate;

        /// <summary>
        /// Date on which the item has been last updated, in [ISO 8601](http://en.wikipedia.org/wiki/ISO_8601) format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateDate")]
        public virtual string LastUpdateDateRaw
        {
            get => _lastUpdateDateRaw;
            set
            {
                _lastUpdateDate = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastUpdateDateRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastUpdateDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastUpdateDateDateTimeOffset instead.")]
        public virtual object LastUpdateDate
        {
            get => _lastUpdateDate;
            set
            {
                _lastUpdateDateRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastUpdateDate = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastUpdateDateRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastUpdateDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastUpdateDateRaw);
            set => LastUpdateDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A message that represents custom attributes. Exactly one of `value` or `group_values` must not be empty.
    /// </summary>
    public class CustomAttribute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Subattributes within this attribute group. If `group_values` is not empty, `value` must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupValues")]
        public virtual System.Collections.Generic.IList<CustomAttribute> GroupValues { get; set; }

        /// <summary>The name of the attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The value of the attribute. If `value` is not empty, `group_values` must be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The destination status of the product status.</summary>
    public class DestinationStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of country codes (ISO 3166-1 alpha-2) where the CSS Product is approved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approvedCountries")]
        public virtual System.Collections.Generic.IList<string> ApprovedCountries { get; set; }

        /// <summary>The name of the destination</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual string Destination { get; set; }

        /// <summary>List of country codes (ISO 3166-1 alpha-2) where the CSS Product is disapproved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disapprovedCountries")]
        public virtual System.Collections.Generic.IList<string> DisapprovedCountries { get; set; }

        /// <summary>List of country codes (ISO 3166-1 alpha-2) where the CSS Product is pending approval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingCountries")]
        public virtual System.Collections.Generic.IList<string> PendingCountries { get; set; }

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

    /// <summary>A message that represents installment.</summary>
    public class HeadlineOfferInstallment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The amount the buyer has to pay per month.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amount")]
        public virtual Price Amount { get; set; }

        /// <summary>The up-front down payment amount the buyer has to pay.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downpayment")]
        public virtual Price Downpayment { get; set; }

        /// <summary>The number of installments the buyer has to pay.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("months")]
        public virtual System.Nullable<long> Months { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The SubscriptionCost of the product.</summary>
    public class HeadlineOfferSubscriptionCost : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The amount the buyer has to pay per subscription period.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amount")]
        public virtual Price Amount { get; set; }

        /// <summary>The type of subscription period. Supported values are: * "`month`" * "`year`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("period")]
        public virtual string Period { get; set; }

        /// <summary>The number of subscription periods the buyer has to pay.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("periodLength")]
        public virtual System.Nullable<long> PeriodLength { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ItemLevelIssue of the product status.</summary>
    public class ItemLevelIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of country codes (ISO 3166-1 alpha-2) where issue applies to the CSS Product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicableCountries")]
        public virtual System.Collections.Generic.IList<string> ApplicableCountries { get; set; }

        /// <summary>The attribute's name, if the issue is caused by a single attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attribute")]
        public virtual string Attribute { get; set; }

        /// <summary>The error code of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>A short issue description in English.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The destination the issue applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual string Destination { get; set; }

        /// <summary>A detailed issue description in English.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual string Detail { get; set; }

        /// <summary>The URL of a web page to help with resolving this issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentation")]
        public virtual string Documentation { get; set; }

        /// <summary>Whether the issue can be resolved by the merchant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolution")]
        public virtual string Resolution { get; set; }

        /// <summary>How this issue affects serving of the CSS Product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servability")]
        public virtual string Servability { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the `ListAccountLabels` method.</summary>
    public class ListAccountLabelsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The labels from the specified account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountLabels")]
        public virtual System.Collections.Generic.IList<AccountLabel> AccountLabels { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the `ListChildAccounts` method.</summary>
    public class ListChildAccountsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The CSS/MC accounts returned for the specified CSS parent account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accounts")]
        public virtual System.Collections.Generic.IList<Account> Accounts { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the ListCssProducts method.</summary>
    public class ListCssProductsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The processed CSS products from the specified account. These are your processed CSS products after applying
        /// rules and supplemental feeds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cssProducts")]
        public virtual System.Collections.Generic.IList<CssProduct> CssProducts { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the ListMethodGroups method.</summary>
    public class ListQuotaGroupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The methods, current quota usage and limits per each group. The quota is shared between all methods in the
        /// group. The groups are sorted in descending order based on quota_usage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaGroups")]
        public virtual System.Collections.Generic.IList<QuotaGroup> QuotaGroups { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The method details per method in the CSS API.</summary>
    public class MethodDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The name of the method for example `cssproductsservice.listcssproducts`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; }

        /// <summary>Output only. The path for the method such as `v1/cssproductsservice.listcssproducts`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>
        /// Output only. The sub-API that the method belongs to. In the CSS API, this is always `css`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subapi")]
        public virtual string Subapi { get; set; }

        /// <summary>Output only. The API version that the method belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The price represented as a number and currency.</summary>
    public class Price : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The price represented as a number in micros (1 million micros is an equivalent to one's currency standard
        /// unit, for example, 1 USD = 1000000 micros).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amountMicros")]
        public virtual System.Nullable<long> AmountMicros { get; set; }

        /// <summary>
        /// The currency of the price using three-letter acronyms according to [ISO
        /// 4217](http://en.wikipedia.org/wiki/ISO_4217).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The product details.</summary>
    public class ProductDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the product detail.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeName")]
        public virtual string AttributeName { get; set; }

        /// <summary>The value of the product detail.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeValue")]
        public virtual string AttributeValue { get; set; }

        /// <summary>The section header used to group a set of product details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sectionName")]
        public virtual string SectionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The dimension of the product.</summary>
    public class ProductDimension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The dimension units. Acceptable values are: * "`in`" * "`cm`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>
        /// Required. The dimension value represented as a number. The value can have a maximum precision of four
        /// decimal places.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The weight of the product.</summary>
    public class ProductWeight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The weight unit. Acceptable values are: * "`g`" * "`kg`" * "`oz`" * "`lb`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>
        /// Required. The weight represented as a number. The weight can have a maximum precision of four decimal
        /// places.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The group information for methods in the CSS API. The quota is shared between all methods in the group. Even if
    /// none of the methods within the group have usage the information for the group is returned.
    /// </summary>
    public class QuotaGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. List of all methods group quota applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("methodDetails")]
        public virtual System.Collections.Generic.IList<MethodDetails> MethodDetails { get; set; }

        /// <summary>
        /// Identifier. The resource name of the quota group. Format: accounts/{account}/quotas/{group} Example:
        /// `accounts/12345678/quotas/css-products-insert` Note: The {group} part is not guaranteed to follow a specific
        /// pattern.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The maximum number of calls allowed per day for the group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaLimit")]
        public virtual System.Nullable<long> QuotaLimit { get; set; }

        /// <summary>Output only. The maximum number of calls allowed per minute for the group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaMinuteLimit")]
        public virtual System.Nullable<long> QuotaMinuteLimit { get; set; }

        /// <summary>
        /// Output only. The current quota usage, meaning the number of calls already made on a given day to the methods
        /// in the group. The daily quota limits reset at at 12:00 PM midday UTC.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaUsage")]
        public virtual System.Nullable<long> QuotaUsage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for the `UpdateLabels` method.</summary>
    public class UpdateAccountLabelsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of label IDs to overwrite the existing account label IDs. If the list is empty, all currently
        /// assigned label IDs will be deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> LabelIds { get; set; }

        /// <summary>
        /// Optional. Only required when updating MC account labels. The CSS domain that is the parent resource of the
        /// MC account. Format: accounts/{account}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
