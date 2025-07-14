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

namespace Google.Apis.Merchant.datasources_v1beta
{
    /// <summary>The Merchant Service.</summary>
    public class MerchantService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "datasources_v1beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public MerchantService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public MerchantService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Accounts = new AccountsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://merchantapi.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://merchantapi.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "merchantapi";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Merchant API.</summary>
        public class Scope
        {
            /// <summary>Manage your product listings and accounts for Google Shopping</summary>
            public static string Content = "https://www.googleapis.com/auth/content";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Merchant API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Manage your product listings and accounts for Google Shopping</summary>
            public const string Content = "https://www.googleapis.com/auth/content";
        }

        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }
    }

    /// <summary>A base abstract class for Merchant requests.</summary>
    public abstract class MerchantBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new MerchantBaseServiceRequest instance.</summary>
        protected MerchantBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Merchant parameter list.</summary>
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
            DataSources = new DataSourcesResource(service);
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
                FileUploads = new FileUploadsResource(service);
            }

            /// <summary>Gets the FileUploads resource.</summary>
            public virtual FileUploadsResource FileUploads { get; }

            /// <summary>The "fileUploads" collection of methods.</summary>
            public class FileUploadsResource
            {
                private const string Resource = "fileUploads";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public FileUploadsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Gets the latest data source file upload. Only the `latest` alias is accepted for a file upload.
                /// </summary>
                /// <param name="name">
                /// Required. The name of the data source file upload to retrieve. Format:
                /// `accounts/{account}/dataSources/{datasource}/fileUploads/latest`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>
                /// Gets the latest data source file upload. Only the `latest` alias is accepted for a file upload.
                /// </summary>
                public class GetRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.datasources_v1beta.Data.FileUpload>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the data source file upload to retrieve. Format:
                    /// `accounts/{account}/dataSources/{datasource}/fileUploads/latest`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "datasources/v1beta/{+name}";

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
                            Pattern = @"^accounts/[^/]+/dataSources/[^/]+/fileUploads/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>
            /// Creates the new data source configuration for the given account. This method always creates a new data
            /// source.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The account where this data source will be created. Format: `accounts/{account}`
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Merchant.datasources_v1beta.Data.DataSource body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates the new data source configuration for the given account. This method always creates a new data
            /// source.
            /// </summary>
            public class CreateRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.datasources_v1beta.Data.DataSource>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.datasources_v1beta.Data.DataSource body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account where this data source will be created. Format: `accounts/{account}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.datasources_v1beta.Data.DataSource Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "datasources/v1beta/{+parent}/dataSources";

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

            /// <summary>Deletes a data source from your Merchant Center account.</summary>
            /// <param name="name">
            /// Required. The name of the data source to delete. Format: `accounts/{account}/dataSources/{datasource}`
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes a data source from your Merchant Center account.</summary>
            public class DeleteRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.datasources_v1beta.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the data source to delete. Format:
                /// `accounts/{account}/dataSources/{datasource}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "datasources/v1beta/{+name}";

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
                        Pattern = @"^accounts/[^/]+/dataSources/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Performs the data fetch immediately (even outside fetch schedule) on a data source from your Merchant
            /// Center Account. If you need to call this method more than once per day, you should use the Products
            /// service to update your product data instead. This method only works on data sources with a file input
            /// set.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the data source resource to fetch. Format:
            /// `accounts/{account}/dataSources/{datasource}`
            /// </param>
            public virtual FetchRequest Fetch(Google.Apis.Merchant.datasources_v1beta.Data.FetchDataSourceRequest body, string name)
            {
                return new FetchRequest(this.service, body, name);
            }

            /// <summary>
            /// Performs the data fetch immediately (even outside fetch schedule) on a data source from your Merchant
            /// Center Account. If you need to call this method more than once per day, you should use the Products
            /// service to update your product data instead. This method only works on data sources with a file input
            /// set.
            /// </summary>
            public class FetchRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.datasources_v1beta.Data.Empty>
            {
                /// <summary>Constructs a new Fetch request.</summary>
                public FetchRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.datasources_v1beta.Data.FetchDataSourceRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the data source resource to fetch. Format:
                /// `accounts/{account}/dataSources/{datasource}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.datasources_v1beta.Data.FetchDataSourceRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "fetch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "datasources/v1beta/{+name}:fetch";

                /// <summary>Initializes Fetch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/dataSources/[^/]+$",
                    });
                }
            }

            /// <summary>Retrieves the data source configuration for the given account.</summary>
            /// <param name="name">
            /// Required. The name of the data source to retrieve. Format: `accounts/{account}/dataSources/{datasource}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Retrieves the data source configuration for the given account.</summary>
            public class GetRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.datasources_v1beta.Data.DataSource>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the data source to retrieve. Format:
                /// `accounts/{account}/dataSources/{datasource}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "datasources/v1beta/{+name}";

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
                        Pattern = @"^accounts/[^/]+/dataSources/[^/]+$",
                    });
                }
            }

            /// <summary>Lists the configurations for data sources for the given account.</summary>
            /// <param name="parent">
            /// Required. The account to list data sources for. Format: `accounts/{account}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists the configurations for data sources for the given account.</summary>
            public class ListRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.datasources_v1beta.Data.ListDataSourcesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The account to list data sources for. Format: `accounts/{account}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of data sources to return. The service may return fewer than this
                /// value. The maximum value is 1000; values above 1000 will be coerced to 1000. If unspecified, the
                /// maximum number of data sources will be returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListDataSources` call. Provide this to retrieve
                /// the subsequent page. When paginating, all other parameters provided to `ListDataSources` must match
                /// the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "datasources/v1beta/{+parent}/dataSources";

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

            /// <summary>
            /// Updates the existing data source configuration. The fields that are set in the update mask but not
            /// provided in the resource will be deleted.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Identifier. The name of the data source. Format: `accounts/{account}/dataSources/{datasource}`
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Merchant.datasources_v1beta.Data.DataSource body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates the existing data source configuration. The fields that are set in the update mask but not
            /// provided in the resource will be deleted.
            /// </summary>
            public class PatchRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.datasources_v1beta.Data.DataSource>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.datasources_v1beta.Data.DataSource body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Identifier. The name of the data source. Format:
                /// `accounts/{account}/dataSources/{datasource}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. The list of data source fields to be updated. Fields specified in the update mask without
                /// a value specified in the body will be deleted from the data source. Providing special "*" value for
                /// full data source replacement is not supported. For example, If you insert `updateMask=displayName`
                /// in the request, it will only update the `displayName` leaving all other fields untouched.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.datasources_v1beta.Data.DataSource Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "datasources/v1beta/{+name}";

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
                        Pattern = @"^accounts/[^/]+/dataSources/[^/]+$",
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
namespace Google.Apis.Merchant.datasources_v1beta.Data
{
    /// <summary>
    /// The [data source](/merchant/api/guides/data-sources/overview) for the Merchant Center account.
    /// </summary>
    public class DataSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The data source id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceId")]
        public virtual System.Nullable<long> DataSourceId { get; set; }

        /// <summary>Required. The displayed data source name in the Merchant Center UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. The field is used only when data is managed through a file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileInput")]
        public virtual FileInput FileInput { get; set; }

        /// <summary>
        /// Output only. Determines the type of input to the data source. Based on the input some settings might not
        /// work. Only generic data sources can be created through the API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("input")]
        public virtual string Input { get; set; }

        /// <summary>The [local inventory](https://support.google.com/merchants/answer/7023001) data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localInventoryDataSource")]
        public virtual LocalInventoryDataSource LocalInventoryDataSource { get; set; }

        /// <summary>The [merchant review](https://support.google.com/merchants/answer/7045996) data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantReviewDataSource")]
        public virtual MerchantReviewDataSource MerchantReviewDataSource { get; set; }

        /// <summary>
        /// Required. Identifier. The name of the data source. Format: `accounts/{account}/dataSources/{datasource}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The [primary data source](https://support.google.com/merchants/answer/7439058) for local and online
        /// products.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryProductDataSource")]
        public virtual PrimaryProductDataSource PrimaryProductDataSource { get; set; }

        /// <summary>The [product review](https://support.google.com/merchants/answer/7045996) data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productReviewDataSource")]
        public virtual ProductReviewDataSource ProductReviewDataSource { get; set; }

        /// <summary>The [promotion](https://support.google.com/merchants/answer/2906014) data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotionDataSource")]
        public virtual PromotionDataSource PromotionDataSource { get; set; }

        /// <summary>
        /// The [regional inventory](https://support.google.com/merchants/answer/7439058) data source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionalInventoryDataSource")]
        public virtual RegionalInventoryDataSource RegionalInventoryDataSource { get; set; }

        /// <summary>
        /// The [supplemental data source](https://support.google.com/merchants/answer/7439058) for local and online
        /// products.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supplementalProductDataSource")]
        public virtual SupplementalProductDataSource SupplementalProductDataSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Data source reference can be used to manage related data sources within the data source service.
    /// </summary>
    public class DataSourceReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The name of the primary data source. Format: `accounts/{account}/dataSources/{datasource}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryDataSourceName")]
        public virtual string PrimaryDataSourceName { get; set; }

        /// <summary>Self should be used to reference the primary data source itself.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("self")]
        public virtual System.Nullable<bool> Self { get; set; }

        /// <summary>
        /// Optional. The name of the supplemental data source. Format: `accounts/{account}/dataSources/{datasource}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supplementalDataSourceName")]
        public virtual string SupplementalDataSourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Default rule management of the data source.</summary>
    public class DefaultRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The list of data sources linked in the [default
        /// rule](https://support.google.com/merchants/answer/7450276). This list is ordered by the default rule
        /// priority of joining the data. It might include none or multiple references to `self` and supplemental data
        /// sources. The list must not be empty. To link the data source to the default rule, you need to add a new
        /// reference to this list (in sequential order). To unlink the data source from the default rule, you need to
        /// remove the given reference from this list. Changing the order of this list will result in changing the
        /// priority of data sources in the default rule. For example, providing the following list: [`1001`, `self`]
        /// will take attribute values from supplemental data source `1001`, and fallback to `self` if the attribute is
        /// not set in `1001`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("takeFromDataSources")]
        public virtual System.Collections.Generic.IList<DataSourceReference> TakeFromDataSources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Destinations also known as [Marketing methods](https://support.google.com/merchants/answer/15130232) selections.
    /// </summary>
    public class Destination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Marketing methods](https://support.google.com/merchants/answer/15130232) (also known as destination)
        /// selections.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual string DestinationValue { get; set; }

        /// <summary>The state of the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

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

    /// <summary>Request message for the FetchDataSource method.</summary>
    public class FetchDataSourceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Fetch details to deliver the data source.</summary>
    public class FetchSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The day of the month when the data source file should be fetched (1-31). This field can only be
        /// set for monthly frequency.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dayOfMonth")]
        public virtual System.Nullable<int> DayOfMonth { get; set; }

        /// <summary>
        /// Optional. The day of the week when the data source file should be fetched. This field can only be set for
        /// weekly frequency.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dayOfWeek")]
        public virtual string DayOfWeek { get; set; }

        /// <summary>Optional. Enables or pauses the fetch schedule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>
        /// Optional. The URL where the data source file can be fetched. Google Merchant Center supports automatic
        /// scheduled uploads using the HTTP, HTTPS or SFTP protocols, so the value will need to be a valid link using
        /// one of those three protocols. Immutable for Google Sheets files.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fetchUri")]
        public virtual string FetchUri { get; set; }

        /// <summary>Required. The frequency describing fetch schedule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frequency")]
        public virtual string Frequency { get; set; }

        /// <summary>
        /// Optional. An optional password for fetch_uri. Used for [submitting data sources through
        /// SFTP](https://support.google.com/merchants/answer/13813117).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>
        /// Optional. The hour of the day when the data source file should be fetched. Minutes and seconds are not
        /// supported and will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOfDay")]
        public virtual TimeOfDay TimeOfDay { get; set; }

        /// <summary>
        /// Optional. [Time zone](https://cldr.unicode.org) used for schedule. UTC by default. For example,
        /// "America/Los_Angeles".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>
        /// Optional. An optional user name for fetch_uri. Used for [submitting data sources through
        /// SFTP](https://support.google.com/merchants/answer/13813117).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The data specific for file data sources. This field is empty for other data source inputs.</summary>
    public class FileInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Fetch details to deliver the data source. It contains settings for `FETCH` and `GOOGLE_SHEETS`
        /// file input types. The required fields vary based on the frequency of fetching.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fetchSettings")]
        public virtual FetchSettings FetchSettings { get; set; }

        /// <summary>Output only. The type of file input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileInputType")]
        public virtual string FileInputType { get; set; }

        /// <summary>Optional. The file name of the data source. Required for `UPLOAD` file input type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileName")]
        public virtual string FileName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The file upload of a specific data source, that is, the result of the retrieval of the data source at a certain
    /// timestamp computed asynchronously when the data source processing is finished. Only applicable to file data
    /// sources.
    /// </summary>
    public class FileUpload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The data source id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceId")]
        public virtual System.Nullable<long> DataSourceId { get; set; }

        /// <summary>Output only. The list of issues occurring in the data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issues")]
        public virtual System.Collections.Generic.IList<Issue> Issues { get; set; }

        /// <summary>Output only. The number of items in the data source that were created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsCreated")]
        public virtual System.Nullable<long> ItemsCreated { get; set; }

        /// <summary>Output only. The number of items in the data source that were processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsTotal")]
        public virtual System.Nullable<long> ItemsTotal { get; set; }

        /// <summary>Output only. The number of items in the data source that were updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsUpdated")]
        public virtual System.Nullable<long> ItemsUpdated { get; set; }

        /// <summary>
        /// Identifier. The name of the data source file upload. Format:
        /// `{datasource.name=accounts/{account}/dataSources/{datasource}/fileUploads/{fileupload}}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The processing state of the data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processingState")]
        public virtual string ProcessingState { get; set; }

        private string _uploadTimeRaw;

        private object _uploadTime;

        /// <summary>Output only. The date at which the file of the data source was uploaded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadTime")]
        public virtual string UploadTimeRaw
        {
            get => _uploadTimeRaw;
            set
            {
                _uploadTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _uploadTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UploadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UploadTimeDateTimeOffset instead.")]
        public virtual object UploadTime
        {
            get => _uploadTime;
            set
            {
                _uploadTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _uploadTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UploadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UploadTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UploadTimeRaw);
            set => UploadTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An error occurring in the data source, like "invalid price".</summary>
    public class Issue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The code of the error, for example, "validation/invalid_value". Returns "?" if the code is
        /// unknown.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Output only. The number of occurrences of the error in the file upload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>
        /// Output only. The error description, for example, "Your data source contains items which have too many
        /// attributes, or are too big. These items will be dropped".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. Link to the documentation explaining the issue in more details, if available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentationUri")]
        public virtual string DocumentationUri { get; set; }

        /// <summary>Output only. The severity of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>Output only. The title of the issue, for example, "Item too big".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the ListDataSources method.</summary>
    public class ListDataSourcesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The data sources from the specified account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSources")]
        public virtual System.Collections.Generic.IList<DataSource> DataSources { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The local inventory data source type is only available for file inputs and can't be used to create API local
    /// inventory data sources.
    /// </summary>
    public class LocalInventoryDataSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. The two-letter ISO 639-1 language of the items to which the local inventory is
        /// provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentLanguage")]
        public virtual string ContentLanguage { get; set; }

        /// <summary>
        /// Required. Immutable. The feed label of the offers to which the local inventory is provided. Must be less
        /// than or equal to 20 uppercase letters (A-Z), numbers (0-9), and dashes (-). See also [migration to feed
        /// labels](https://developers.google.com/shopping-content/guides/products/feed-labels).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedLabel")]
        public virtual string FeedLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The merchant review data source.</summary>
    public class MerchantReviewDataSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The primary data source for local and online products.</summary>
    public class PrimaryProductDataSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Immutable. Specifies the type of data source channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channel")]
        public virtual string Channel { get; set; }

        /// <summary>
        /// Optional. Immutable. The two-letter ISO 639-1 language of the items in the data source. `feedLabel` and
        /// `contentLanguage` must be either both set or unset. The fields can only be unset for data sources without
        /// file input. If set, the data source will only accept products matching this combination. If unset, the data
        /// source will accept products without that restriction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentLanguage")]
        public virtual string ContentLanguage { get; set; }

        /// <summary>
        /// Optional. The countries where the items may be displayed. Represented as a [CLDR territory
        /// code](https://github.com/unicode-org/cldr/blob/latest/common/main/en.xml).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countries")]
        public virtual System.Collections.Generic.IList<string> Countries { get; set; }

        /// <summary>
        /// Optional. Default rule management of the data source. If set, the linked data sources will be replaced.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultRule")]
        public virtual DefaultRule DefaultRule { get; set; }

        /// <summary>
        /// Optional. A list of destinations describing where products of the data source can be shown. When retrieving
        /// the data source, the list contains all the destinations that can be used for the data source, including the
        /// ones that are disabled for the data source but enabled for the account. Only destinations that are enabled
        /// on the account, for example through program participation, can be enabled on the data source. If unset,
        /// during creation, the destinations will be inherited based on the account level program participation. If
        /// set, during creation or update, the data source will be set only for the specified destinations. Updating
        /// this field requires at least one destination.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual System.Collections.Generic.IList<Destination> Destinations { get; set; }

        /// <summary>
        /// Optional. Immutable. The feed label that is specified on the data source level. Must be less than or equal
        /// to 20 uppercase letters (A-Z), numbers (0-9), and dashes (-). See also [migration to feed
        /// labels](https://developers.google.com/shopping-content/guides/products/feed-labels). `feedLabel` and
        /// `contentLanguage` must be either both set or unset for data sources with product content type. They must be
        /// set for data sources with a file input. If set, the data source will only accept products matching this
        /// combination. If unset, the data source will accept products without that restriction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedLabel")]
        public virtual string FeedLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The change that happened to the product including old value, new value, country code as the region code and
    /// reporting context.
    /// </summary>
    public class ProductChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The new value of the changed resource or attribute. If empty, it means that the product was deleted. Will
        /// have one of these values : (`approved`, `pending`, `disapproved`, ``)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newValue")]
        public virtual string NewValue { get; set; }

        /// <summary>
        /// The old value of the changed resource or attribute. If empty, it means that the product was created. Will
        /// have one of these values : (`approved`, `pending`, `disapproved`, ``)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldValue")]
        public virtual string OldValue { get; set; }

        /// <summary>Countries that have the change (if applicable). Represented in the ISO 3166 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>
        /// Reporting contexts that have the change (if applicable). Currently this field supports only (`SHOPPING_ADS`,
        /// `LOCAL_INVENTORY_ADS`, `YOUTUBE_SHOPPING`, `YOUTUBE_CHECKOUT`, `YOUTUBE_AFFILIATE`) from the enum value
        /// [ReportingContextEnum](/merchant/api/reference/rest/Shared.Types/ReportingContextEnum)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingContext")]
        public virtual string ReportingContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The product review data source.</summary>
    public class ProductReviewDataSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The message that the merchant will receive to notify about product status change event</summary>
    public class ProductStatusChangeMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The target account that owns the entity that changed. Format : `accounts/{merchant_id}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual string Account { get; set; }

        /// <summary>The attribute in the resource that changed, in this case it will be always `Status`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attribute")]
        public virtual string Attribute { get; set; }

        /// <summary>A message to describe the change that happened to the product</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changes")]
        public virtual System.Collections.Generic.IList<ProductChange> Changes { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>
        /// The time at which the event was generated. If you want to order the notification messages you receive you
        /// should rely on this field not on the order of receiving the notifications.
        /// </summary>
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

        private string _expirationTimeRaw;

        private object _expirationTime;

        /// <summary>
        /// Optional. The product expiration time. This field will not be set if the notification is sent for a product
        /// deletion event.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTime")]
        public virtual string ExpirationTimeRaw
        {
            get => _expirationTimeRaw;
            set
            {
                _expirationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expirationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpirationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpirationTimeDateTimeOffset instead.")]
        public virtual object ExpirationTime
        {
            get => _expirationTime;
            set
            {
                _expirationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expirationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpirationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpirationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpirationTimeRaw);
            set => ExpirationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The account that manages the merchant's account. can be the same as merchant id if it is standalone account.
        /// Format : `accounts/{service_provider_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managingAccount")]
        public virtual string ManagingAccount { get; set; }

        /// <summary>The product name. Format: `accounts/{account}/products/{product}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>The product id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual string ResourceId { get; set; }

        /// <summary>The resource that changed, in this case it will always be `Product`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The promotion data source.</summary>
    public class PromotionDataSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Immutable. The two-letter ISO 639-1 language of the items in the data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentLanguage")]
        public virtual string ContentLanguage { get; set; }

        /// <summary>
        /// Required. Immutable. The target country used as part of the unique identifier. Represented as a [CLDR
        /// territory code](https://github.com/unicode-org/cldr/blob/latest/common/main/en.xml). Promotions are only
        /// available in selected [countries](https://support.google.com/merchants/answer/4588460).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetCountry")]
        public virtual string TargetCountry { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RegionalInventoryDataSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. The two-letter ISO 639-1 language of the items to which the regional inventory is
        /// provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentLanguage")]
        public virtual string ContentLanguage { get; set; }

        /// <summary>
        /// Required. Immutable. The feed label of the offers to which the regional inventory is provided. Must be less
        /// than or equal to 20 uppercase letters (A-Z), numbers (0-9), and dashes (-). See also [migration to feed
        /// labels](https://developers.google.com/shopping-content/guides/products/feed-labels).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedLabel")]
        public virtual string FeedLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The supplemental data source for local and online products. After creation, you should make sure to link the
    /// supplemental product data source into one or more primary product data sources.
    /// </summary>
    public class SupplementalProductDataSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Immutable. The two-letter ISO 639-1 language of the items in the data source. `feedLabel` and
        /// `contentLanguage` must be either both set or unset. The fields can only be unset for data sources without
        /// file input. If set, the data source will only accept products matching this combination. If unset, the data
        /// source will accept produts without that restriction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentLanguage")]
        public virtual string ContentLanguage { get; set; }

        /// <summary>
        /// Optional. Immutable. The feed label that is specified on the data source level. Must be less than or equal
        /// to 20 uppercase letters (A-Z), numbers (0-9), and dashes (-). See also [migration to feed
        /// labels](https://developers.google.com/shopping-content/guides/products/feed-labels). `feedLabel` and
        /// `contentLanguage` must be either both set or unset for data sources with product content type. They must be
        /// set for data sources with a file input. The fields must be unset for data sources without file input. If
        /// set, the data source will only accept products matching this combination. If unset, the data source will
        /// accept produts without that restriction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedLabel")]
        public virtual string FeedLabel { get; set; }

        /// <summary>
        /// Output only. The (unordered and deduplicated) list of all primary data sources linked to this data source in
        /// either default or custom rules. Supplemental data source cannot be deleted before all links are removed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referencingPrimaryDataSources")]
        public virtual System.Collections.Generic.IList<DataSourceReference> ReferencingPrimaryDataSources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a time of day. The date and time zone are either not significant or are specified elsewhere. An API
    /// may choose to allow leap seconds. Related types are google.type.Date and `google.protobuf.Timestamp`.
    /// </summary>
    public class TimeOfDay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Hours of a day in 24 hour format. Must be greater than or equal to 0 and typically must be less than or
        /// equal to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Minutes of an hour. Must be greater than or equal to 0 and less than or equal to 59.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>
        /// Fractions of seconds, in nanoseconds. Must be greater than or equal to 0 and less than or equal to
        /// 999,999,999.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Seconds of a minute. Must be greater than or equal to 0 and typically must be less than or equal to 59. An
        /// API may allow the value 60 if it allows leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
