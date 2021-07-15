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

namespace Google.Apis.CloudAsset.v1
{
    /// <summary>The CloudAsset Service.</summary>
    public class CloudAssetService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudAssetService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudAssetService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Assets = new AssetsResource(this);
            Feeds = new FeedsResource(this);
            Operations = new OperationsResource(this);
            V1 = new V1Resource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudasset";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://cloudasset.googleapis.com/";
        #else
            "https://cloudasset.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://cloudasset.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Asset API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Asset API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Assets resource.</summary>
        public virtual AssetsResource Assets { get; }

        /// <summary>Gets the Feeds resource.</summary>
        public virtual FeedsResource Feeds { get; }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the V1 resource.</summary>
        public virtual V1Resource V1 { get; }
    }

    /// <summary>A base abstract class for CloudAsset requests.</summary>
    public abstract class CloudAssetBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudAssetBaseServiceRequest instance.</summary>
        protected CloudAssetBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudAsset parameter list.</summary>
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

        /// <summary>Lists assets with time and resource types and returns paged results in response.</summary>
        /// <param name="parent">
        /// Required. Name of the organization or project the assets belong to. Format:
        /// "organizations/[organization-number]" (such as "organizations/123"), "projects/[project-id]" (such as
        /// "projects/my-project-id"), or "projects/[project-number]" (such as "projects/12345").
        /// </param>
        public virtual ListRequest List(string parent)
        {
            return new ListRequest(service, parent);
        }

        /// <summary>Lists assets with time and resource types and returns paged results in response.</summary>
        public class ListRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.ListAssetsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
            {
                Parent = parent;
                InitParameters();
            }

            /// <summary>
            /// Required. Name of the organization or project the assets belong to. Format:
            /// "organizations/[organization-number]" (such as "organizations/123"), "projects/[project-id]" (such as
            /// "projects/my-project-id"), or "projects/[project-number]" (such as "projects/12345").
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// A list of asset types to take a snapshot for. For example: "compute.googleapis.com/Disk". Regular
            /// expression is also supported. For example: * "compute.googleapis.com.*" snapshots resources whose asset
            /// type starts with "compute.googleapis.com". * ".*Instance" snapshots resources whose asset type ends with
            /// "Instance". * ".*Instance.*" snapshots resources whose asset type contains "Instance". See
            /// [RE2](https://github.com/google/re2/wiki/Syntax) for all supported regular expression syntax. If the
            /// regular expression does not match any supported asset type, an INVALID_ARGUMENT error will be returned.
            /// If specified, only matching assets will be returned, otherwise, it will snapshot all asset types. See
            /// [Introduction to Cloud Asset Inventory](https://cloud.google.com/asset-inventory/docs/overview) for all
            /// supported asset types.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("assetTypes", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> AssetTypes { get; set; }

            /// <summary>Asset content type. If not specified, no content but the asset name will be returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("contentType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ContentTypeEnum> ContentType { get; set; }

            /// <summary>Asset content type. If not specified, no content but the asset name will be returned.</summary>
            public enum ContentTypeEnum
            {
                /// <summary>Unspecified content type.</summary>
                [Google.Apis.Util.StringValueAttribute("CONTENT_TYPE_UNSPECIFIED")]
                CONTENTTYPEUNSPECIFIED = 0,

                /// <summary>Resource metadata.</summary>
                [Google.Apis.Util.StringValueAttribute("RESOURCE")]
                RESOURCE = 1,

                /// <summary>The actual IAM policy set on a resource.</summary>
                [Google.Apis.Util.StringValueAttribute("IAM_POLICY")]
                IAMPOLICY = 2,

                /// <summary>The Cloud Organization Policy set on an asset.</summary>
                [Google.Apis.Util.StringValueAttribute("ORG_POLICY")]
                ORGPOLICY = 3,

                /// <summary>The Cloud Access context manager Policy set on an asset.</summary>
                [Google.Apis.Util.StringValueAttribute("ACCESS_POLICY")]
                ACCESSPOLICY = 4,

                /// <summary>The runtime OS Inventory information.</summary>
                [Google.Apis.Util.StringValueAttribute("OS_INVENTORY")]
                OSINVENTORY = 5,
            }

            /// <summary>
            /// The maximum number of assets to be returned in a single response. Default is 100, minimum is 1, and
            /// maximum is 1000.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// The `next_page_token` returned from the previous `ListAssetsResponse`, or unspecified for the first
            /// `ListAssetsRequest`. It is a continuation of a prior `ListAssets` call, and the API should return the
            /// next page of assets.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Timestamp to take an asset snapshot. This can only be set to a timestamp between the current time and
            /// the current time minus 35 days (inclusive). If not specified, the current time will be used. Due to
            /// delays in resource data collection and indexing, there is a volatile window during which running the
            /// same query may get different results.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("readTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object ReadTime { get; set; }

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
                    Pattern = @"^[^/]+/[^/]+$",
                });
                RequestParameters.Add("assetTypes", new Google.Apis.Discovery.Parameter
                {
                    Name = "assetTypes",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("contentType", new Google.Apis.Discovery.Parameter
                {
                    Name = "contentType",
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
                RequestParameters.Add("readTime", new Google.Apis.Discovery.Parameter
                {
                    Name = "readTime",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "feeds" collection of methods.</summary>
    public class FeedsResource
    {
        private const string Resource = "feeds";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public FeedsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Creates a feed in a parent project/folder/organization to listen to its asset updates.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. The name of the project/folder/organization where this feed should be created in. It can only be
        /// an organization number (such as "organizations/123"), a folder number (such as "folders/123"), a project ID
        /// (such as "projects/my-project-id")", or a project number (such as "projects/12345").
        /// </param>
        public virtual CreateRequest Create(Google.Apis.CloudAsset.v1.Data.CreateFeedRequest body, string parent)
        {
            return new CreateRequest(service, body, parent);
        }

        /// <summary>Creates a feed in a parent project/folder/organization to listen to its asset updates.</summary>
        public class CreateRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.Feed>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAsset.v1.Data.CreateFeedRequest body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the project/folder/organization where this feed should be created in. It can only
            /// be an organization number (such as "organizations/123"), a folder number (such as "folders/123"), a
            /// project ID (such as "projects/my-project-id")", or a project number (such as "projects/12345").
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudAsset.v1.Data.CreateFeedRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}/feeds";

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
                    Pattern = @"^[^/]+/[^/]+$",
                });
            }
        }

        /// <summary>Deletes an asset feed.</summary>
        /// <param name="name">
        /// Required. The name of the feed and it must be in the format of: projects/project_number/feeds/feed_id
        /// folders/folder_number/feeds/feed_id organizations/organization_number/feeds/feed_id
        /// </param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>Deletes an asset feed.</summary>
        public class DeleteRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the feed and it must be in the format of: projects/project_number/feeds/feed_id
            /// folders/folder_number/feeds/feed_id organizations/organization_number/feeds/feed_id
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
                    Pattern = @"^[^/]+/[^/]+/feeds/[^/]+$",
                });
            }
        }

        /// <summary>Gets details about an asset feed.</summary>
        /// <param name="name">
        /// Required. The name of the Feed and it must be in the format of: projects/project_number/feeds/feed_id
        /// folders/folder_number/feeds/feed_id organizations/organization_number/feeds/feed_id
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Gets details about an asset feed.</summary>
        public class GetRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.Feed>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the Feed and it must be in the format of: projects/project_number/feeds/feed_id
            /// folders/folder_number/feeds/feed_id organizations/organization_number/feeds/feed_id
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
                    Pattern = @"^[^/]+/[^/]+/feeds/[^/]+$",
                });
            }
        }

        /// <summary>Lists all asset feeds in a parent project/folder/organization.</summary>
        /// <param name="parent">
        /// Required. The parent project/folder/organization whose feeds are to be listed. It can only be using
        /// project/folder/organization number (such as "folders/12345")", or a project ID (such as
        /// "projects/my-project-id").
        /// </param>
        public virtual ListRequest List(string parent)
        {
            return new ListRequest(service, parent);
        }

        /// <summary>Lists all asset feeds in a parent project/folder/organization.</summary>
        public class ListRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.ListFeedsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
            {
                Parent = parent;
                InitParameters();
            }

            /// <summary>
            /// Required. The parent project/folder/organization whose feeds are to be listed. It can only be using
            /// project/folder/organization number (such as "folders/12345")", or a project ID (such as
            /// "projects/my-project-id").
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}/feeds";

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
                    Pattern = @"^[^/]+/[^/]+$",
                });
            }
        }

        /// <summary>Updates an asset feed configuration.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. The format will be projects/{project_number}/feeds/{client-assigned_feed_identifier} or
        /// folders/{folder_number}/feeds/{client-assigned_feed_identifier} or
        /// organizations/{organization_number}/feeds/{client-assigned_feed_identifier} The client-assigned feed
        /// identifier must be unique within the parent project/folder/organization.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.CloudAsset.v1.Data.UpdateFeedRequest body, string name)
        {
            return new PatchRequest(service, body, name);
        }

        /// <summary>Updates an asset feed configuration.</summary>
        public class PatchRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.Feed>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAsset.v1.Data.UpdateFeedRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The format will be projects/{project_number}/feeds/{client-assigned_feed_identifier} or
            /// folders/{folder_number}/feeds/{client-assigned_feed_identifier} or
            /// organizations/{organization_number}/feeds/{client-assigned_feed_identifier} The client-assigned feed
            /// identifier must be unique within the parent project/folder/organization.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudAsset.v1.Data.UpdateFeedRequest Body { get; set; }

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
                    Pattern = @"^[^/]+/[^/]+/feeds/[^/]+$",
                });
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
        public class GetRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.Operation>
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
                    Pattern = @"^[^/]+/[^/]+/operations/[^/]+/.*$",
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

        /// <summary>Analyzes IAM policies to answer which identities have what accesses on which resources.</summary>
        /// <param name="scope">
        /// Required. The relative name of the root asset. Only resources and IAM policies within the scope will be
        /// analyzed. This can only be an organization number (such as "organizations/123"), a folder number (such as
        /// "folders/123"), a project ID (such as "projects/my-project-id"), or a project number (such as
        /// "projects/12345"). To know how to get organization id, visit [here
        /// ](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).
        /// To know how to get folder or project id, visit [here
        /// ](https://cloud.google.com/resource-manager/docs/creating-managing-folders#viewing_or_listing_folders_and_projects).
        /// </param>
        public virtual AnalyzeIamPolicyRequest AnalyzeIamPolicy(string scope)
        {
            return new AnalyzeIamPolicyRequest(service, scope);
        }

        /// <summary>Analyzes IAM policies to answer which identities have what accesses on which resources.</summary>
        public class AnalyzeIamPolicyRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.AnalyzeIamPolicyResponse>
        {
            /// <summary>Constructs a new AnalyzeIamPolicy request.</summary>
            public AnalyzeIamPolicyRequest(Google.Apis.Services.IClientService service, string scope) : base(service)
            {
                Scope = scope;
                InitParameters();
            }

            /// <summary>
            /// Required. The relative name of the root asset. Only resources and IAM policies within the scope will be
            /// analyzed. This can only be an organization number (such as "organizations/123"), a folder number (such
            /// as "folders/123"), a project ID (such as "projects/my-project-id"), or a project number (such as
            /// "projects/12345"). To know how to get organization id, visit [here
            /// ](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).
            /// To know how to get folder or project id, visit [here
            /// ](https://cloud.google.com/resource-manager/docs/creating-managing-folders#viewing_or_listing_folders_and_projects).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("scope", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Scope { get; private set; }

            /// <summary>Optional. The permissions to appear in result.</summary>
            [Google.Apis.Util.RequestParameterAttribute("analysisQuery.accessSelector.permissions", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> AnalysisQueryAccessSelectorPermissions { get; set; }

            /// <summary>Optional. The roles to appear in result.</summary>
            [Google.Apis.Util.RequestParameterAttribute("analysisQuery.accessSelector.roles", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> AnalysisQueryAccessSelectorRoles { get; set; }

            /// <summary>
            /// The hypothetical access timestamp to evaluate IAM conditions. Note that this value must not be earlier
            /// than the current time; otherwise, an INVALID_ARGUMENT error will be returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("analysisQuery.conditionContext.accessTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object AnalysisQueryConditionContextAccessTime { get; set; }

            /// <summary>
            /// Required. The identity appear in the form of members in [IAM policy
            /// binding](https://cloud.google.com/iam/reference/rest/v1/Binding). The examples of supported forms are:
            /// "user:mike@example.com", "group:admins@example.com", "domain:google.com",
            /// "serviceAccount:my-project-id@appspot.gserviceaccount.com". Notice that wildcard characters (such as *
            /// and ?) are not supported. You must give a specific identity.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("analysisQuery.identitySelector.identity", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string AnalysisQueryIdentitySelectorIdentity { get; set; }

            /// <summary>
            /// Optional. If true, the response will include access analysis from identities to resources via service
            /// account impersonation. This is a very expensive operation, because many derived queries will be
            /// executed. We highly recommend you use AssetService.AnalyzeIamPolicyLongrunning rpc instead. For example,
            /// if the request analyzes for which resources user A has permission P, and there's an IAM policy states
            /// user A has iam.serviceAccounts.getAccessToken permission to a service account SA, and there's another
            /// IAM policy states service account SA has permission P to a GCP folder F, then user A potentially has
            /// access to the GCP folder F. And those advanced analysis results will be included in
            /// AnalyzeIamPolicyResponse.service_account_impersonation_analysis. Another example, if the request
            /// analyzes for who has permission P to a GCP folder F, and there's an IAM policy states user A has
            /// iam.serviceAccounts.actAs permission to a service account SA, and there's another IAM policy states
            /// service account SA has permission P to the GCP folder F, then user A potentially has access to the GCP
            /// folder F. And those advanced analysis results will be included in
            /// AnalyzeIamPolicyResponse.service_account_impersonation_analysis. Default is false.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("analysisQuery.options.analyzeServiceAccountImpersonation", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AnalysisQueryOptionsAnalyzeServiceAccountImpersonation { get; set; }

            /// <summary>
            /// Optional. If true, the identities section of the result will expand any Google groups appearing in an
            /// IAM policy binding. If IamPolicyAnalysisQuery.identity_selector is specified, the identity in the result
            /// will be determined by the selector, and this flag is not allowed to set. Default is false.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("analysisQuery.options.expandGroups", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AnalysisQueryOptionsExpandGroups { get; set; }

            /// <summary>
            /// Optional. If true and IamPolicyAnalysisQuery.resource_selector is not specified, the resource section of
            /// the result will expand any resource attached to an IAM policy to include resources lower in the resource
            /// hierarchy. For example, if the request analyzes for which resources user A has permission P, and the
            /// results include an IAM policy with P on a GCP folder, the results will also include resources in that
            /// folder with permission P. If true and IamPolicyAnalysisQuery.resource_selector is specified, the
            /// resource section of the result will expand the specified resource to include resources lower in the
            /// resource hierarchy. Only project or lower resources are supported. Folder and organization resource
            /// cannot be used together with this option. For example, if the request analyzes for which users have
            /// permission P on a GCP project with this option enabled, the results will include all users who have
            /// permission P on that project or any lower resource. Default is false.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("analysisQuery.options.expandResources", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AnalysisQueryOptionsExpandResources { get; set; }

            /// <summary>
            /// Optional. If true, the access section of result will expand any roles appearing in IAM policy bindings
            /// to include their permissions. If IamPolicyAnalysisQuery.access_selector is specified, the access section
            /// of the result will be determined by the selector, and this flag is not allowed to set. Default is false.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("analysisQuery.options.expandRoles", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AnalysisQueryOptionsExpandRoles { get; set; }

            /// <summary>
            /// Optional. If true, the result will output group identity edges, starting from the binding's group
            /// members, to any expanded identities. Default is false.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("analysisQuery.options.outputGroupEdges", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AnalysisQueryOptionsOutputGroupEdges { get; set; }

            /// <summary>
            /// Optional. If true, the result will output resource edges, starting from the policy attached resource, to
            /// any expanded resources. Default is false.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("analysisQuery.options.outputResourceEdges", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AnalysisQueryOptionsOutputResourceEdges { get; set; }

            /// <summary>
            /// Required. The [full resource name] (https://cloud.google.com/asset-inventory/docs/resource-name-format)
            /// of a resource of [supported resource
            /// types](https://cloud.google.com/asset-inventory/docs/supported-asset-types#analyzable_asset_types).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("analysisQuery.resourceSelector.fullResourceName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string AnalysisQueryResourceSelectorFullResourceName { get; set; }

            /// <summary>
            /// Optional. Amount of time executable has to complete. See JSON representation of
            /// [Duration](https://developers.google.com/protocol-buffers/docs/proto3#json). If this field is set with a
            /// value less than the RPC deadline, and the execution of your query hasn't finished in the specified
            /// execution timeout, you will get a response with partial result. Otherwise, your query's execution will
            /// continue until the RPC deadline. If it's not finished until then, you will get a DEADLINE_EXCEEDED
            /// error. Default is empty.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("executionTimeout", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object ExecutionTimeout { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "analyzeIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+scope}:analyzeIamPolicy";

            /// <summary>Initializes AnalyzeIamPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("scope", new Google.Apis.Discovery.Parameter
                {
                    Name = "scope",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+/[^/]+$",
                });
                RequestParameters.Add("analysisQuery.accessSelector.permissions", new Google.Apis.Discovery.Parameter
                {
                    Name = "analysisQuery.accessSelector.permissions",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("analysisQuery.accessSelector.roles", new Google.Apis.Discovery.Parameter
                {
                    Name = "analysisQuery.accessSelector.roles",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("analysisQuery.conditionContext.accessTime", new Google.Apis.Discovery.Parameter
                {
                    Name = "analysisQuery.conditionContext.accessTime",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("analysisQuery.identitySelector.identity", new Google.Apis.Discovery.Parameter
                {
                    Name = "analysisQuery.identitySelector.identity",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("analysisQuery.options.analyzeServiceAccountImpersonation", new Google.Apis.Discovery.Parameter
                {
                    Name = "analysisQuery.options.analyzeServiceAccountImpersonation",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("analysisQuery.options.expandGroups", new Google.Apis.Discovery.Parameter
                {
                    Name = "analysisQuery.options.expandGroups",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("analysisQuery.options.expandResources", new Google.Apis.Discovery.Parameter
                {
                    Name = "analysisQuery.options.expandResources",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("analysisQuery.options.expandRoles", new Google.Apis.Discovery.Parameter
                {
                    Name = "analysisQuery.options.expandRoles",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("analysisQuery.options.outputGroupEdges", new Google.Apis.Discovery.Parameter
                {
                    Name = "analysisQuery.options.outputGroupEdges",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("analysisQuery.options.outputResourceEdges", new Google.Apis.Discovery.Parameter
                {
                    Name = "analysisQuery.options.outputResourceEdges",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("analysisQuery.resourceSelector.fullResourceName", new Google.Apis.Discovery.Parameter
                {
                    Name = "analysisQuery.resourceSelector.fullResourceName",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("executionTimeout", new Google.Apis.Discovery.Parameter
                {
                    Name = "executionTimeout",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Analyzes IAM policies asynchronously to answer which identities have what accesses on which resources, and
        /// writes the analysis results to a Google Cloud Storage or a BigQuery destination. For Cloud Storage
        /// destination, the output format is the JSON format that represents a AnalyzeIamPolicyResponse. This method
        /// implements the google.longrunning.Operation, which allows you to track the operation status. We recommend
        /// intervals of at least 2 seconds with exponential backoff retry to poll the operation result. The metadata
        /// contains the request to help callers to map responses to requests.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="scope">
        /// Required. The relative name of the root asset. Only resources and IAM policies within the scope will be
        /// analyzed. This can only be an organization number (such as "organizations/123"), a folder number (such as
        /// "folders/123"), a project ID (such as "projects/my-project-id"), or a project number (such as
        /// "projects/12345"). To know how to get organization id, visit [here
        /// ](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).
        /// To know how to get folder or project id, visit [here
        /// ](https://cloud.google.com/resource-manager/docs/creating-managing-folders#viewing_or_listing_folders_and_projects).
        /// </param>
        public virtual AnalyzeIamPolicyLongrunningRequest AnalyzeIamPolicyLongrunning(Google.Apis.CloudAsset.v1.Data.AnalyzeIamPolicyLongrunningRequest body, string scope)
        {
            return new AnalyzeIamPolicyLongrunningRequest(service, body, scope);
        }

        /// <summary>
        /// Analyzes IAM policies asynchronously to answer which identities have what accesses on which resources, and
        /// writes the analysis results to a Google Cloud Storage or a BigQuery destination. For Cloud Storage
        /// destination, the output format is the JSON format that represents a AnalyzeIamPolicyResponse. This method
        /// implements the google.longrunning.Operation, which allows you to track the operation status. We recommend
        /// intervals of at least 2 seconds with exponential backoff retry to poll the operation result. The metadata
        /// contains the request to help callers to map responses to requests.
        /// </summary>
        public class AnalyzeIamPolicyLongrunningRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.Operation>
        {
            /// <summary>Constructs a new AnalyzeIamPolicyLongrunning request.</summary>
            public AnalyzeIamPolicyLongrunningRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAsset.v1.Data.AnalyzeIamPolicyLongrunningRequest body, string scope) : base(service)
            {
                Scope = scope;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The relative name of the root asset. Only resources and IAM policies within the scope will be
            /// analyzed. This can only be an organization number (such as "organizations/123"), a folder number (such
            /// as "folders/123"), a project ID (such as "projects/my-project-id"), or a project number (such as
            /// "projects/12345"). To know how to get organization id, visit [here
            /// ](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).
            /// To know how to get folder or project id, visit [here
            /// ](https://cloud.google.com/resource-manager/docs/creating-managing-folders#viewing_or_listing_folders_and_projects).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("scope", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Scope { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudAsset.v1.Data.AnalyzeIamPolicyLongrunningRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "analyzeIamPolicyLongrunning";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+scope}:analyzeIamPolicyLongrunning";

            /// <summary>Initializes AnalyzeIamPolicyLongrunning parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("scope", new Google.Apis.Discovery.Parameter
                {
                    Name = "scope",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Analyze moving a resource to a specified destination without kicking off the actual move. The analysis is
        /// best effort depending on the user's permissions of viewing different hierarchical policies and
        /// configurations. The policies and configuration are subject to change before the actual resource migration
        /// takes place.
        /// </summary>
        /// <param name="resource">
        /// Required. Name of the resource to perform the analysis against. Only GCP Project are supported as of today.
        /// Hence, this can only be Project ID (such as "projects/my-project-id") or a Project Number (such as
        /// "projects/12345").
        /// </param>
        public virtual AnalyzeMoveRequest AnalyzeMove(string resource)
        {
            return new AnalyzeMoveRequest(service, resource);
        }

        /// <summary>
        /// Analyze moving a resource to a specified destination without kicking off the actual move. The analysis is
        /// best effort depending on the user's permissions of viewing different hierarchical policies and
        /// configurations. The policies and configuration are subject to change before the actual resource migration
        /// takes place.
        /// </summary>
        public class AnalyzeMoveRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.AnalyzeMoveResponse>
        {
            /// <summary>Constructs a new AnalyzeMove request.</summary>
            public AnalyzeMoveRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
            {
                Resource = resource;
                InitParameters();
            }

            /// <summary>
            /// Required. Name of the resource to perform the analysis against. Only GCP Project are supported as of
            /// today. Hence, this can only be Project ID (such as "projects/my-project-id") or a Project Number (such
            /// as "projects/12345").
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>
            /// Required. Name of the GCP Folder or Organization to reparent the target resource. The analysis will be
            /// performed against hypothetically moving the resource to this specified desitination parent. This can
            /// only be a Folder number (such as "folders/123") or an Organization number (such as "organizations/123").
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("destinationParent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DestinationParent { get; set; }

            /// <summary>
            /// Analysis view indicating what information should be included in the analysis response. If unspecified,
            /// the default view is FULL.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            /// <summary>
            /// Analysis view indicating what information should be included in the analysis response. If unspecified,
            /// the default view is FULL.
            /// </summary>
            public enum ViewEnum
            {
                /// <summary>The default/unset value. The API will default to the FULL view.</summary>
                [Google.Apis.Util.StringValueAttribute("ANALYSIS_VIEW_UNSPECIFIED")]
                ANALYSISVIEWUNSPECIFIED = 0,

                /// <summary>Full analysis including all level of impacts of the specified resource move.</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL = 1,

                /// <summary>
                /// Basic analysis only including blockers which will prevent the specified resource move at runtime.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC = 2,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "analyzeMove";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:analyzeMove";

            /// <summary>Initializes AnalyzeMove parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+/[^/]+$",
                });
                RequestParameters.Add("destinationParent", new Google.Apis.Discovery.Parameter
                {
                    Name = "destinationParent",
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

        /// <summary>
        /// Batch gets the update history of assets that overlap a time window. For IAM_POLICY content, this API outputs
        /// history when the asset and its attached IAM POLICY both exist. This can create gaps in the output history.
        /// Otherwise, this API outputs history with asset in both non-delete or deleted status. If a specified asset
        /// does not exist, this API returns an INVALID_ARGUMENT error.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative name of the root asset. It can only be an organization number (such as
        /// "organizations/123"), a project ID (such as "projects/my-project-id")", or a project number (such as
        /// "projects/12345").
        /// </param>
        public virtual BatchGetAssetsHistoryRequest BatchGetAssetsHistory(string parent)
        {
            return new BatchGetAssetsHistoryRequest(service, parent);
        }

        /// <summary>
        /// Batch gets the update history of assets that overlap a time window. For IAM_POLICY content, this API outputs
        /// history when the asset and its attached IAM POLICY both exist. This can create gaps in the output history.
        /// Otherwise, this API outputs history with asset in both non-delete or deleted status. If a specified asset
        /// does not exist, this API returns an INVALID_ARGUMENT error.
        /// </summary>
        public class BatchGetAssetsHistoryRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.BatchGetAssetsHistoryResponse>
        {
            /// <summary>Constructs a new BatchGetAssetsHistory request.</summary>
            public BatchGetAssetsHistoryRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
            {
                Parent = parent;
                InitParameters();
            }

            /// <summary>
            /// Required. The relative name of the root asset. It can only be an organization number (such as
            /// "organizations/123"), a project ID (such as "projects/my-project-id")", or a project number (such as
            /// "projects/12345").
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// A list of the full names of the assets. See:
            /// https://cloud.google.com/asset-inventory/docs/resource-name-format Example:
            /// `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1`. The request becomes
            /// a no-op if the asset name list is empty, and the max size of the asset name list is 100 in one request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("assetNames", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> AssetNames { get; set; }

            /// <summary>Optional. The content type.</summary>
            [Google.Apis.Util.RequestParameterAttribute("contentType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ContentTypeEnum> ContentType { get; set; }

            /// <summary>Optional. The content type.</summary>
            public enum ContentTypeEnum
            {
                /// <summary>Unspecified content type.</summary>
                [Google.Apis.Util.StringValueAttribute("CONTENT_TYPE_UNSPECIFIED")]
                CONTENTTYPEUNSPECIFIED = 0,

                /// <summary>Resource metadata.</summary>
                [Google.Apis.Util.StringValueAttribute("RESOURCE")]
                RESOURCE = 1,

                /// <summary>The actual IAM policy set on a resource.</summary>
                [Google.Apis.Util.StringValueAttribute("IAM_POLICY")]
                IAMPOLICY = 2,

                /// <summary>The Cloud Organization Policy set on an asset.</summary>
                [Google.Apis.Util.StringValueAttribute("ORG_POLICY")]
                ORGPOLICY = 3,

                /// <summary>The Cloud Access context manager Policy set on an asset.</summary>
                [Google.Apis.Util.StringValueAttribute("ACCESS_POLICY")]
                ACCESSPOLICY = 4,

                /// <summary>The runtime OS Inventory information.</summary>
                [Google.Apis.Util.StringValueAttribute("OS_INVENTORY")]
                OSINVENTORY = 5,
            }

            /// <summary>
            /// End time of the time window (inclusive). If not specified, the current timestamp is used instead.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("readTimeWindow.endTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object ReadTimeWindowEndTime { get; set; }

            /// <summary>Start time of the time window (exclusive).</summary>
            [Google.Apis.Util.RequestParameterAttribute("readTimeWindow.startTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object ReadTimeWindowStartTime { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "batchGetAssetsHistory";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}:batchGetAssetsHistory";

            /// <summary>Initializes BatchGetAssetsHistory parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+/[^/]+$",
                });
                RequestParameters.Add("assetNames", new Google.Apis.Discovery.Parameter
                {
                    Name = "assetNames",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("contentType", new Google.Apis.Discovery.Parameter
                {
                    Name = "contentType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("readTimeWindow.endTime", new Google.Apis.Discovery.Parameter
                {
                    Name = "readTimeWindow.endTime",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("readTimeWindow.startTime", new Google.Apis.Discovery.Parameter
                {
                    Name = "readTimeWindow.startTime",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Exports assets with time and resource types to a given Cloud Storage location/BigQuery table. For Cloud
        /// Storage location destinations, the output format is newline-delimited JSON. Each line represents a
        /// google.cloud.asset.v1.Asset in the JSON format; for BigQuery table destinations, the output table stores the
        /// fields in asset proto as columns. This API implements the google.longrunning.Operation API , which allows
        /// you to keep track of the export. We recommend intervals of at least 2 seconds with exponential retry to poll
        /// the export operation result. For regular-size resource parent, the export operation usually finishes within
        /// 5 minutes.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. The relative name of the root asset. This can only be an organization number (such as
        /// "organizations/123"), a project ID (such as "projects/my-project-id"), or a project number (such as
        /// "projects/12345"), or a folder number (such as "folders/123").
        /// </param>
        public virtual ExportAssetsRequest ExportAssets(Google.Apis.CloudAsset.v1.Data.ExportAssetsRequest body, string parent)
        {
            return new ExportAssetsRequest(service, body, parent);
        }

        /// <summary>
        /// Exports assets with time and resource types to a given Cloud Storage location/BigQuery table. For Cloud
        /// Storage location destinations, the output format is newline-delimited JSON. Each line represents a
        /// google.cloud.asset.v1.Asset in the JSON format; for BigQuery table destinations, the output table stores the
        /// fields in asset proto as columns. This API implements the google.longrunning.Operation API , which allows
        /// you to keep track of the export. We recommend intervals of at least 2 seconds with exponential retry to poll
        /// the export operation result. For regular-size resource parent, the export operation usually finishes within
        /// 5 minutes.
        /// </summary>
        public class ExportAssetsRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.Operation>
        {
            /// <summary>Constructs a new ExportAssets request.</summary>
            public ExportAssetsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAsset.v1.Data.ExportAssetsRequest body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The relative name of the root asset. This can only be an organization number (such as
            /// "organizations/123"), a project ID (such as "projects/my-project-id"), or a project number (such as
            /// "projects/12345"), or a folder number (such as "folders/123").
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudAsset.v1.Data.ExportAssetsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "exportAssets";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}:exportAssets";

            /// <summary>Initializes ExportAssets parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Searches all IAM policies within the specified scope, such as a project, folder, or organization. The caller
        /// must be granted the `cloudasset.assets.searchAllIamPolicies` permission on the desired scope, otherwise the
        /// request will be rejected.
        /// </summary>
        /// <param name="scope">
        /// Required. A scope can be a project, a folder, or an organization. The search is limited to the IAM policies
        /// within the `scope`. The caller must be granted the
        /// [`cloudasset.assets.searchAllIamPolicies`](https://cloud.google.com/asset-inventory/docs/access-control#required_permissions)
        /// permission on the desired scope. The allowed values are: * projects/{PROJECT_ID} (e.g., "projects/foo-bar")
        /// * projects/{PROJECT_NUMBER} (e.g., "projects/12345678") * folders/{FOLDER_NUMBER} (e.g., "folders/1234567")
        /// * organizations/{ORGANIZATION_NUMBER} (e.g., "organizations/123456")
        /// </param>
        public virtual SearchAllIamPoliciesRequest SearchAllIamPolicies(string scope)
        {
            return new SearchAllIamPoliciesRequest(service, scope);
        }

        /// <summary>
        /// Searches all IAM policies within the specified scope, such as a project, folder, or organization. The caller
        /// must be granted the `cloudasset.assets.searchAllIamPolicies` permission on the desired scope, otherwise the
        /// request will be rejected.
        /// </summary>
        public class SearchAllIamPoliciesRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.SearchAllIamPoliciesResponse>
        {
            /// <summary>Constructs a new SearchAllIamPolicies request.</summary>
            public SearchAllIamPoliciesRequest(Google.Apis.Services.IClientService service, string scope) : base(service)
            {
                Scope = scope;
                InitParameters();
            }

            /// <summary>
            /// Required. A scope can be a project, a folder, or an organization. The search is limited to the IAM
            /// policies within the `scope`. The caller must be granted the
            /// [`cloudasset.assets.searchAllIamPolicies`](https://cloud.google.com/asset-inventory/docs/access-control#required_permissions)
            /// permission on the desired scope. The allowed values are: * projects/{PROJECT_ID} (e.g.,
            /// "projects/foo-bar") * projects/{PROJECT_NUMBER} (e.g., "projects/12345678") * folders/{FOLDER_NUMBER}
            /// (e.g., "folders/1234567") * organizations/{ORGANIZATION_NUMBER} (e.g., "organizations/123456")
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("scope", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Scope { get; private set; }

            /// <summary>
            /// Optional. A list of asset types that the IAM policies are attached to. If empty, it will search the IAM
            /// policies that are attached to all the [searchable asset
            /// types](https://cloud.google.com/asset-inventory/docs/supported-asset-types#searchable_asset_types).
            /// Regular expressions are also supported. For example: * "compute.googleapis.com.*" snapshots IAM policies
            /// attached to asset type starts with "compute.googleapis.com". * ".*Instance" snapshots IAM policies
            /// attached to asset type ends with "Instance". * ".*Instance.*" snapshots IAM policies attached to asset
            /// type contains "Instance". See [RE2](https://github.com/google/re2/wiki/Syntax) for all supported regular
            /// expression syntax. If the regular expression does not match any supported asset type, an
            /// INVALID_ARGUMENT error will be returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("assetTypes", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> AssetTypes { get; set; }

            /// <summary>
            /// Optional. A comma-separated list of fields specifying the sorting order of the results. The default
            /// order is ascending. Add " DESC" after the field name to indicate descending order. Redundant space
            /// characters are ignored. Example: "assetType DESC, resource". Only singular primitive fields in the
            /// response are sortable: * resource * assetType * project All the other fields such as repeated fields
            /// (e.g., `folders`) and non-primitive fields (e.g., `policy`) are not supported.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>
            /// Optional. The page size for search result pagination. Page size is capped at 500 even if a larger value
            /// is given. If set to zero, server will pick an appropriate default. Returned results may be fewer than
            /// requested. When this happens, there could be more results as long as `next_page_token` is returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. If present, retrieve the next batch of results from the preceding call to this method.
            /// `page_token` must be the value of `next_page_token` from the previous response. The values of all other
            /// method parameters must be identical to those in the previous call.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Optional. The query statement. See [how to construct a
            /// query](https://cloud.google.com/asset-inventory/docs/searching-iam-policies#how_to_construct_a_query)
            /// for more information. If not specified or empty, it will search all the IAM policies within the
            /// specified `scope`. Note that the query string is compared against each Cloud IAM policy binding,
            /// including its members, roles, and Cloud IAM conditions. The returned Cloud IAM policies will only
            /// contain the bindings that match your query. To learn more about the IAM policy structure, see [IAM
            /// policy doc](https://cloud.google.com/iam/docs/policies#structure). Examples: * `policy:amy@gmail.com` to
            /// find IAM policy bindings that specify user "amy@gmail.com". * `policy:roles/compute.admin` to find IAM
            /// policy bindings that specify the Compute Admin role. * `policy:comp*` to find IAM policy bindings that
            /// contain "comp" as a prefix of any word in the binding. *
            /// `policy.role.permissions:storage.buckets.update` to find IAM policy bindings that specify a role
            /// containing "storage.buckets.update" permission. Note that if callers don't have `iam.roles.get` access
            /// to a role's included permissions, policy bindings that specify this role will be dropped from the search
            /// results. * `policy.role.permissions:upd*` to find IAM policy bindings that specify a role containing
            /// "upd" as a prefix of any word in the role permission. Note that if callers don't have `iam.roles.get`
            /// access to a role's included permissions, policy bindings that specify this role will be dropped from the
            /// search results. * `resource:organizations/123456` to find IAM policy bindings that are set on
            /// "organizations/123456". * `resource=//cloudresourcemanager.googleapis.com/projects/myproject` to find
            /// IAM policy bindings that are set on the project named "myproject". * `Important` to find IAM policy
            /// bindings that contain "Important" as a word in any of the searchable fields (except for the included
            /// permissions). * `resource:(instance1 OR instance2) policy:amy` to find IAM policy bindings that are set
            /// on resources "instance1" or "instance2" and also specify user "amy". * `roles:roles/compute.admin` to
            /// find IAM policy bindings that specify the Compute Admin role. * `memberTypes:user` to find IAM policy
            /// bindings that contain the "user" member type.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "searchAllIamPolicies";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+scope}:searchAllIamPolicies";

            /// <summary>Initializes SearchAllIamPolicies parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("scope", new Google.Apis.Discovery.Parameter
                {
                    Name = "scope",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+/[^/]+$",
                });
                RequestParameters.Add("assetTypes", new Google.Apis.Discovery.Parameter
                {
                    Name = "assetTypes",
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
                RequestParameters.Add("query", new Google.Apis.Discovery.Parameter
                {
                    Name = "query",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Searches all Cloud resources within the specified scope, such as a project, folder, or organization. The
        /// caller must be granted the `cloudasset.assets.searchAllResources` permission on the desired scope, otherwise
        /// the request will be rejected.
        /// </summary>
        /// <param name="scope">
        /// Required. A scope can be a project, a folder, or an organization. The search is limited to the resources
        /// within the `scope`. The caller must be granted the
        /// [`cloudasset.assets.searchAllResources`](https://cloud.google.com/asset-inventory/docs/access-control#required_permissions)
        /// permission on the desired scope. The allowed values are: * projects/{PROJECT_ID} (e.g., "projects/foo-bar")
        /// * projects/{PROJECT_NUMBER} (e.g., "projects/12345678") * folders/{FOLDER_NUMBER} (e.g., "folders/1234567")
        /// * organizations/{ORGANIZATION_NUMBER} (e.g., "organizations/123456")
        /// </param>
        public virtual SearchAllResourcesRequest SearchAllResources(string scope)
        {
            return new SearchAllResourcesRequest(service, scope);
        }

        /// <summary>
        /// Searches all Cloud resources within the specified scope, such as a project, folder, or organization. The
        /// caller must be granted the `cloudasset.assets.searchAllResources` permission on the desired scope, otherwise
        /// the request will be rejected.
        /// </summary>
        public class SearchAllResourcesRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.SearchAllResourcesResponse>
        {
            /// <summary>Constructs a new SearchAllResources request.</summary>
            public SearchAllResourcesRequest(Google.Apis.Services.IClientService service, string scope) : base(service)
            {
                Scope = scope;
                InitParameters();
            }

            /// <summary>
            /// Required. A scope can be a project, a folder, or an organization. The search is limited to the resources
            /// within the `scope`. The caller must be granted the
            /// [`cloudasset.assets.searchAllResources`](https://cloud.google.com/asset-inventory/docs/access-control#required_permissions)
            /// permission on the desired scope. The allowed values are: * projects/{PROJECT_ID} (e.g.,
            /// "projects/foo-bar") * projects/{PROJECT_NUMBER} (e.g., "projects/12345678") * folders/{FOLDER_NUMBER}
            /// (e.g., "folders/1234567") * organizations/{ORGANIZATION_NUMBER} (e.g., "organizations/123456")
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("scope", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Scope { get; private set; }

            /// <summary>
            /// Optional. A list of asset types that this request searches for. If empty, it will search all the
            /// [searchable asset
            /// types](https://cloud.google.com/asset-inventory/docs/supported-asset-types#searchable_asset_types).
            /// Regular expressions are also supported. For example: * "compute.googleapis.com.*" snapshots resources
            /// whose asset type starts with "compute.googleapis.com". * ".*Instance" snapshots resources whose asset
            /// type ends with "Instance". * ".*Instance.*" snapshots resources whose asset type contains "Instance".
            /// See [RE2](https://github.com/google/re2/wiki/Syntax) for all supported regular expression syntax. If the
            /// regular expression does not match any supported asset type, an INVALID_ARGUMENT error will be returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("assetTypes", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> AssetTypes { get; set; }

            /// <summary>
            /// Optional. A comma-separated list of fields specifying the sorting order of the results. The default
            /// order is ascending. Add " DESC" after the field name to indicate descending order. Redundant space
            /// characters are ignored. Example: "location DESC, name". Only singular primitive fields in the response
            /// are sortable: * name * assetType * project * displayName * description * location * kmsKey * createTime
            /// * updateTime * state * parentFullResourceName * parentAssetType All the other fields such as repeated
            /// fields (e.g., `networkTags`), map fields (e.g., `labels`) and struct fields (e.g.,
            /// `additionalAttributes`) are not supported.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>
            /// Optional. The page size for search result pagination. Page size is capped at 500 even if a larger value
            /// is given. If set to zero, server will pick an appropriate default. Returned results may be fewer than
            /// requested. When this happens, there could be more results as long as `next_page_token` is returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. If present, then retrieve the next batch of results from the preceding call to this method.
            /// `page_token` must be the value of `next_page_token` from the previous response. The values of all other
            /// method parameters, must be identical to those in the previous call.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Optional. The query statement. See [how to construct a
            /// query](https://cloud.google.com/asset-inventory/docs/searching-resources#how_to_construct_a_query) for
            /// more information. If not specified or empty, it will search all the resources within the specified
            /// `scope`. Examples: * `name:Important` to find Cloud resources whose name contains "Important" as a word.
            /// * `name=Important` to find the Cloud resource whose name is exactly "Important". * `displayName:Impor*`
            /// to find Cloud resources whose display name contains "Impor" as a prefix of any word in the field. *
            /// `location:us-west*` to find Cloud resources whose location contains both "us" and "west" as prefixes. *
            /// `labels:prod` to find Cloud resources whose labels contain "prod" as a key or value. * `labels.env:prod`
            /// to find Cloud resources that have a label "env" and its value is "prod". * `labels.env:*` to find Cloud
            /// resources that have a label "env". * `kmsKey:key` to find Cloud resources encrypted with a
            /// customer-managed encryption key whose name contains the word "key". * `state:ACTIVE` to find Cloud
            /// resources whose state contains "ACTIVE" as a word. * `NOT state:ACTIVE` to find Cloud resources whose
            /// state doesn't contain "ACTIVE" as a word. * `createTime&amp;lt;1609459200` to find Cloud resources that
            /// were created before "2021-01-01 00:00:00 UTC". 1609459200 is the epoch timestamp of "2021-01-01 00:00:00
            /// UTC" in seconds. * `updateTime&amp;gt;1609459200` to find Cloud resources that were updated after
            /// "2021-01-01 00:00:00 UTC". 1609459200 is the epoch timestamp of "2021-01-01 00:00:00 UTC" in seconds. *
            /// `Important` to find Cloud resources that contain "Important" as a word in any of the searchable fields.
            /// * `Impor*` to find Cloud resources that contain "Impor" as a prefix of any word in any of the searchable
            /// fields. * `Important location:(us-west1 OR global)` to find Cloud resources that contain "Important" as
            /// a word in any of the searchable fields and are also located in the "us-west1" region or the "global"
            /// location.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>
            /// Optional. A comma-separated list of fields specifying which fields to be returned in
            /// ResourceSearchResult. Only '*' or combination of top level fields can be specified. Field names of both
            /// snake_case and camelCase are supported. Examples: `"*"`, `"name,location"`, `"name,versionedResources"`.
            /// The read_mask paths must be valid field paths listed but not limited to (both snake_case and camelCase
            /// are supported): * name * assetType * project * displayName * description * location * labels *
            /// networkTags * kmsKey * createTime * updateTime * state * additionalAttributes * versionedResources If
            /// read_mask is not specified, all fields except versionedResources will be returned. If only '*' is
            /// specified, all fields including versionedResources will be returned. Any invalid field path will trigger
            /// INVALID_ARGUMENT error.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object ReadMask { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "searchAllResources";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+scope}:searchAllResources";

            /// <summary>Initializes SearchAllResources parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("scope", new Google.Apis.Discovery.Parameter
                {
                    Name = "scope",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+/[^/]+$",
                });
                RequestParameters.Add("assetTypes", new Google.Apis.Discovery.Parameter
                {
                    Name = "assetTypes",
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
                RequestParameters.Add("query", new Google.Apis.Discovery.Parameter
                {
                    Name = "query",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                {
                    Name = "readMask",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.CloudAsset.v1.Data
{
    /// <summary>
    /// Specifies roles and/or permissions to analyze, to determine both the identities possessing them and the
    /// resources they control. If multiple values are specified, results will include roles or permissions matching any
    /// of them. The total number of roles and permissions should be equal or less than 10.
    /// </summary>
    public class AccessSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The permissions to appear in result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>Optional. The roles to appear in result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roles")]
        public virtual System.Collections.Generic.IList<string> Roles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request message for AssetService.AnalyzeIamPolicyLongrunning.</summary>
    public class AnalyzeIamPolicyLongrunningRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The request query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisQuery")]
        public virtual IamPolicyAnalysisQuery AnalysisQuery { get; set; }

        /// <summary>Required. Output configuration indicating where the results will be output to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual IamPolicyAnalysisOutputConfig OutputConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response message for AssetService.AnalyzeIamPolicyLongrunning.</summary>
    public class AnalyzeIamPolicyLongrunningResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response message for AssetService.AnalyzeIamPolicy.</summary>
    public class AnalyzeIamPolicyResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Represents whether all entries in the main_analysis and service_account_impersonation_analysis have been
        /// fully explored to answer the query in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullyExplored")]
        public virtual System.Nullable<bool> FullyExplored { get; set; }

        /// <summary>The main analysis that matches the original request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mainAnalysis")]
        public virtual IamPolicyAnalysis MainAnalysis { get; set; }

        /// <summary>
        /// The service account impersonation analysis if AnalyzeIamPolicyRequest.analyze_service_account_impersonation
        /// is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountImpersonationAnalysis")]
        public virtual System.Collections.Generic.IList<IamPolicyAnalysis> ServiceAccountImpersonationAnalysis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for resource move analysis.</summary>
    public class AnalyzeMoveResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of analyses returned from performing the intended resource move analysis. The analysis is grouped
        /// by different Cloud services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moveAnalysis")]
        public virtual System.Collections.Generic.IList<MoveAnalysis> MoveAnalysis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An asset in Google Cloud. An asset can be any resource in the Google Cloud [resource
    /// hierarchy](https://cloud.google.com/resource-manager/docs/cloud-platform-resource-hierarchy), a resource outside
    /// the Google Cloud resource hierarchy (such as Google Kubernetes Engine clusters and objects), or a policy (e.g.
    /// Cloud IAM policy), or a relationship (e.g. an INSTANCE_TO_INSTANCEGROUP relationship). See [Supported asset
    /// types](https://cloud.google.com/asset-inventory/docs/supported-asset-types) for more information.
    /// </summary>
    public class Asset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Please also refer to the [access level user
        /// guide](https://cloud.google.com/access-context-manager/docs/overview#access-levels).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLevel")]
        public virtual GoogleIdentityAccesscontextmanagerV1AccessLevel AccessLevel { get; set; }

        /// <summary>
        /// Please also refer to the [access policy user
        /// guide](https://cloud.google.com/access-context-manager/docs/overview#access-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessPolicy")]
        public virtual GoogleIdentityAccesscontextmanagerV1AccessPolicy AccessPolicy { get; set; }

        /// <summary>
        /// The ancestry path of an asset in Google Cloud [resource
        /// hierarchy](https://cloud.google.com/resource-manager/docs/cloud-platform-resource-hierarchy), represented as
        /// a list of relative resource names. An ancestry path starts with the closest ancestor in the hierarchy and
        /// ends at root. If the asset is a project, folder, or organization, the ancestry path starts from the asset
        /// itself. Example: `["projects/123456789", "folders/5432", "organizations/1234"]`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ancestors")]
        public virtual System.Collections.Generic.IList<string> Ancestors { get; set; }

        /// <summary>
        /// The type of the asset. Example: `compute.googleapis.com/Disk` See [Supported asset
        /// types](https://cloud.google.com/asset-inventory/docs/supported-asset-types) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetType")]
        public virtual string AssetType { get; set; }

        /// <summary>
        /// A representation of the Cloud IAM policy set on a Google Cloud resource. There can be a maximum of one Cloud
        /// IAM policy set on any given resource. In addition, Cloud IAM policies inherit their granted access scope
        /// from any policies set on parent resources in the resource hierarchy. Therefore, the effectively policy is
        /// the union of both the policy set on this resource and each policy set on all of the resource's ancestry
        /// resource levels in the hierarchy. See [this topic](https://cloud.google.com/iam/docs/policies#inheritance)
        /// for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iamPolicy")]
        public virtual Policy IamPolicy { get; set; }

        /// <summary>
        /// The full name of the asset. Example:
        /// `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1` See [Resource
        /// names](https://cloud.google.com/apis/design/resource_names#full_resource_name) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// A representation of an [organization
        /// policy](https://cloud.google.com/resource-manager/docs/organization-policy/overview#organization_policy).
        /// There can be more than one organization policy with different constraints set on a given resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgPolicy")]
        public virtual System.Collections.Generic.IList<GoogleCloudOrgpolicyV1Policy> OrgPolicy { get; set; }

        /// <summary>
        /// A representation of runtime OS Inventory information. See [this
        /// topic](https://cloud.google.com/compute/docs/instances/os-inventory-management) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osInventory")]
        public virtual Inventory OsInventory { get; set; }

        /// <summary>A representation of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual Resource Resource { get; set; }

        /// <summary>
        /// Please also refer to the [service perimeter user
        /// guide](https://cloud.google.com/vpc-service-controls/docs/overview).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicePerimeter")]
        public virtual GoogleIdentityAccesscontextmanagerV1ServicePerimeter ServicePerimeter { get; set; }

        /// <summary>
        /// The last update timestamp of an asset. update_time is updated when create/update/delete operation is
        /// performed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Attached resource representation, which is defined by the corresponding service provider. It represents an
    /// attached resource's payload.
    /// </summary>
    public class AttachedResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The type of this attached resource. Example: `osconfig.googleapis.com/Inventory` You can find the supported
        /// attached asset types of each resource in this table:
        /// `https://cloud.google.com/asset-inventory/docs/supported-asset-types#searchable_asset_types`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetType")]
        public virtual string AssetType { get; set; }

        /// <summary>
        /// Versioned resource representations of this attached resource. This is repeated because there could be
        /// multiple versions of the attached resource representations during version migration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionedResources")]
        public virtual System.Collections.Generic.IList<VersionedResource> VersionedResources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies the audit configuration for a service. The configuration determines which permission types are logged,
    /// and what identities, if any, are exempted from logging. An AuditConfig must have one or more AuditLogConfigs. If
    /// there are AuditConfigs for both `allServices` and a specific service, the union of the two AuditConfigs is used
    /// for that service: the log_types specified in each AuditConfig are enabled, and the exempted_members in each
    /// AuditLogConfig are exempted. Example Policy with multiple AuditConfigs: { "audit_configs": [ { "service":
    /// "allServices", "audit_log_configs": [ { "log_type": "DATA_READ", "exempted_members": [ "user:jose@example.com" ]
    /// }, { "log_type": "DATA_WRITE" }, { "log_type": "ADMIN_READ" } ] }, { "service": "sampleservice.googleapis.com",
    /// "audit_log_configs": [ { "log_type": "DATA_READ" }, { "log_type": "DATA_WRITE", "exempted_members": [
    /// "user:aliya@example.com" ] } ] } ] } For sampleservice, this policy enables DATA_READ, DATA_WRITE and ADMIN_READ
    /// logging. It also exempts jose@example.com from DATA_READ logging, and aliya@example.com from DATA_WRITE logging.
    /// </summary>
    public class AuditConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for logging of each type of permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLogConfigs")]
        public virtual System.Collections.Generic.IList<AuditLogConfig> AuditLogConfigs { get; set; }

        /// <summary>
        /// Specifies a service that will be enabled for audit logging. For example, `storage.googleapis.com`,
        /// `cloudsql.googleapis.com`. `allServices` is a special value that covers all services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provides the configuration for logging a type of permissions. Example: { "audit_log_configs": [ { "log_type":
    /// "DATA_READ", "exempted_members": [ "user:jose@example.com" ] }, { "log_type": "DATA_WRITE" } ] } This enables
    /// 'DATA_READ' and 'DATA_WRITE' logging, while exempting jose@example.com from DATA_READ logging.
    /// </summary>
    public class AuditLogConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the identities that do not cause logging for this type of permission. Follows the same format of
        /// Binding.members.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exemptedMembers")]
        public virtual System.Collections.Generic.IList<string> ExemptedMembers { get; set; }

        /// <summary>The log type that this config enables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logType")]
        public virtual string LogType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Batch get assets history response.</summary>
    public class BatchGetAssetsHistoryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of assets with valid time windows.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assets")]
        public virtual System.Collections.Generic.IList<TemporalAsset> Assets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A BigQuery destination for exporting assets to.</summary>
    public class BigQueryDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The BigQuery dataset in format "projects/projectId/datasets/datasetId", to which the snapshot
        /// result should be exported. If this dataset does not exist, the export call returns an INVALID_ARGUMENT
        /// error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>
        /// If the destination table already exists and this flag is `TRUE`, the table will be overwritten by the
        /// contents of assets snapshot. If the flag is `FALSE` or unset and the destination table already exists, the
        /// export call returns an INVALID_ARGUMEMT error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("force")]
        public virtual System.Nullable<bool> Force { get; set; }

        /// <summary>
        /// [partition_spec] determines whether to export to partitioned table(s) and how to partition the data. If
        /// [partition_spec] is unset or [partition_spec.partition_key] is unset or `PARTITION_KEY_UNSPECIFIED`, the
        /// snapshot results will be exported to non-partitioned table(s). [force] will decide whether to overwrite
        /// existing table(s). If [partition_spec] is specified. First, the snapshot results will be written to
        /// partitioned table(s) with two additional timestamp columns, readTime and requestTime, one of which will be
        /// the partition key. Secondly, in the case when any destination table already exists, it will first try to
        /// update existing table's schema as necessary by appending additional columns. Then, if [force] is `TRUE`, the
        /// corresponding partition will be overwritten by the snapshot results (data in different partitions will
        /// remain intact); if [force] is unset or `FALSE`, it will append the data. An error will be returned if the
        /// schema update or data appension fails.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionSpec")]
        public virtual PartitionSpec PartitionSpec { get; set; }

        /// <summary>
        /// If this flag is `TRUE`, the snapshot results will be written to one or multiple tables, each of which
        /// contains results of one asset type. The [force] and [partition_spec] fields will apply to each of them.
        /// Field [table] will be concatenated with "_" and the asset type names (see
        /// https://cloud.google.com/asset-inventory/docs/supported-asset-types for supported asset types) to construct
        /// per-asset-type table names, in which all non-alphanumeric characters like "." and "/" will be substituted by
        /// "_". Example: if field [table] is "mytable" and snapshot results contain "storage.googleapis.com/Bucket"
        /// assets, the corresponding table name will be "mytable_storage_googleapis_com_Bucket". If any of these tables
        /// does not exist, a new table with the concatenated name will be created. When [content_type] in the
        /// ExportAssetsRequest is `RESOURCE`, the schema of each table will include RECORD-type columns mapped to the
        /// nested fields in the Asset.resource.data field of that asset type (up to the 15 nested level BigQuery
        /// supports (https://cloud.google.com/bigquery/docs/nested-repeated#limitations)). The fields in &amp;gt;15
        /// nested levels will be stored in JSON format string as a child column of its parent RECORD column. If error
        /// occurs when exporting to any table, the whole export call will return an error but the export results that
        /// already succeed will persist. Example: if exporting to table_type_A succeeds when exporting to table_type_B
        /// fails during one export call, the results in table_type_A will persist and there will not be partial results
        /// persisting in a table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("separateTablesPerAssetType")]
        public virtual System.Nullable<bool> SeparateTablesPerAssetType { get; set; }

        /// <summary>
        /// Required. The BigQuery table to which the snapshot result should be written. If this table does not exist, a
        /// new table with the given name will be created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual string Table { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Associates `members` with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// members in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// Specifies the identities requesting access for a Cloud Platform resource. `members` can have the following
        /// values: * `allUsers`: A special identifier that represents anyone who is on the internet; with or without a
        /// Google account. * `allAuthenticatedUsers`: A special identifier that represents anyone who is authenticated
        /// with a Google account or a service account. * `user:{emailid}`: An email address that represents a specific
        /// Google account. For example, `alice@example.com` . * `serviceAccount:{emailid}`: An email address that
        /// represents a service account. For example, `my-other-app@appspot.gserviceaccount.com`. * `group:{emailid}`:
        /// An email address that represents a Google group. For example, `admins@example.com`. *
        /// `deleted:user:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a user that
        /// has been recently deleted. For example, `alice@example.com?uid=123456789012345678901`. If the user is
        /// recovered, this value reverts to `user:{emailid}` and the recovered user retains the role in the binding. *
        /// `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a
        /// service account that has been recently deleted. For example,
        /// `my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted,
        /// this value reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the
        /// binding. * `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing
        /// a Google group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`.
        /// If the group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role
        /// in the binding. * `domain:{domain}`: The G Suite domain (primary) that represents all the users of that
        /// domain. For example, `google.com` or `example.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Role that is assigned to `members`. For example, `roles/viewer`, `roles/editor`, or `roles/owner`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The IAM conditions context.</summary>
    public class ConditionContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The hypothetical access timestamp to evaluate IAM conditions. Note that this value must not be earlier than
        /// the current time; otherwise, an INVALID_ARGUMENT error will be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessTime")]
        public virtual object AccessTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Condition evaluation.</summary>
    public class ConditionEvaluation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The evaluation result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationValue")]
        public virtual string EvaluationValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Create asset feed request.</summary>
    public class CreateFeedRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The feed details. The field `name` must be empty and it will be generated in the format of:
        /// projects/project_number/feeds/feed_id folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feed")]
        public virtual Feed Feed { get; set; }

        /// <summary>
        /// Required. This is the client-assigned asset feed identifier and it needs to be unique under a specific
        /// parent project/folder/organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedId")]
        public virtual string FeedId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty JSON
    /// object `{}`.
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Explanation about the IAM policy search result.</summary>
    public class Explanation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The map from roles to their included permissions that match the permission query (i.e., a query containing
        /// `policy.role.permissions:`). Example: if query `policy.role.permissions:compute.disk.get` matches a policy
        /// binding that contains owner role, the matched_permissions will be `{"roles/owner": ["compute.disk.get"]}`.
        /// The roles can also be found in the returned `policy` bindings. Note that the map is populated only for
        /// requests with permission queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchedPermissions")]
        public virtual System.Collections.Generic.IDictionary<string, Permissions> MatchedPermissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Export asset request.</summary>
    public class ExportAssetsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of asset types to take a snapshot for. For example: "compute.googleapis.com/Disk". Regular
        /// expressions are also supported. For example: * "compute.googleapis.com.*" snapshots resources whose asset
        /// type starts with "compute.googleapis.com". * ".*Instance" snapshots resources whose asset type ends with
        /// "Instance". * ".*Instance.*" snapshots resources whose asset type contains "Instance". See
        /// [RE2](https://github.com/google/re2/wiki/Syntax) for all supported regular expression syntax. If the regular
        /// expression does not match any supported asset type, an INVALID_ARGUMENT error will be returned. If
        /// specified, only matching assets will be returned, otherwise, it will snapshot all asset types. See
        /// [Introduction to Cloud Asset Inventory](https://cloud.google.com/asset-inventory/docs/overview) for all
        /// supported asset types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetTypes")]
        public virtual System.Collections.Generic.IList<string> AssetTypes { get; set; }

        /// <summary>Asset content type. If not specified, no content but the asset name will be returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>Required. Output configuration indicating where the results will be output to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual OutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Timestamp to take an asset snapshot. This can only be set to a timestamp between the current time and the
        /// current time minus 35 days (inclusive). If not specified, the current time will be used. Due to delays in
        /// resource data collection and indexing, there is a volatile window during which running the same query may
        /// get different results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual object ReadTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression
    /// language. The syntax and semantics of CEL are documented at https://github.com/google/cel-spec. Example
    /// (Comparison): title: "Summary size limit" description: "Determines if a summary is less than 100 chars"
    /// expression: "document.summary.size() &amp;lt; 100" Example (Equality): title: "Requestor is owner" description:
    /// "Determines if requestor is the document owner" expression: "document.owner == request.auth.claims.email"
    /// Example (Logic): title: "Public documents" description: "Determine whether the document should be publicly
    /// visible" expression: "document.type != 'private' &amp;amp;&amp;amp; document.type != 'internal'" Example (Data
    /// Manipulation): title: "Notification string" description: "Create a notification string with a timestamp."
    /// expression: "'New message received at ' + string(document.create_time)" The exact variables and functions that
    /// may be referenced within an expression are determined by the service that evaluates it. See the service
    /// documentation for additional information.
    /// </summary>
    public class Expr : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Description of the expression. This is a longer text which describes the expression, e.g. when
        /// hovered over it in a UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; }

        /// <summary>
        /// Optional. String indicating the location of the expression for error reporting, e.g. a file name and a
        /// position in the file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs
        /// which allow to enter the expression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An asset feed used to export asset updates to a destinations. An asset feed filter controls what updates are
    /// exported. The asset feed must be created within a project, organization, or folder. Supported destinations are:
    /// Pub/Sub topics.
    /// </summary>
    public class Feed : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of the full names of the assets to receive updates. You must specify either or both of asset_names
        /// and asset_types. Only asset updates matching specified asset_names or asset_types are exported to the feed.
        /// Example: `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1`. See [Resource
        /// Names](https://cloud.google.com/apis/design/resource_names#full_resource_name) for more info.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetNames")]
        public virtual System.Collections.Generic.IList<string> AssetNames { get; set; }

        /// <summary>
        /// A list of types of the assets to receive updates. You must specify either or both of asset_names and
        /// asset_types. Only asset updates matching specified asset_names or asset_types are exported to the feed.
        /// Example: `"compute.googleapis.com/Disk"` See [this
        /// topic](https://cloud.google.com/asset-inventory/docs/supported-asset-types) for a list of all supported
        /// asset types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetTypes")]
        public virtual System.Collections.Generic.IList<string> AssetTypes { get; set; }

        /// <summary>
        /// A condition which determines whether an asset update should be published. If specified, an asset will be
        /// returned only when the expression evaluates to true. When set, `expression` field in the `Expr` must be a
        /// valid [CEL expression] (https://github.com/google/cel-spec) on a TemporalAsset with name `temporal_asset`.
        /// Example: a Feed with expression ("temporal_asset.deleted == true") will only publish Asset deletions. Other
        /// fields of `Expr` are optional. See our [user
        /// guide](https://cloud.google.com/asset-inventory/docs/monitoring-asset-changes-with-condition) for detailed
        /// instructions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// Asset content type. If not specified, no content but the asset name and type will be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>Required. Feed output configuration defining where the asset updates are published to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedOutputConfig")]
        public virtual FeedOutputConfig FeedOutputConfig { get; set; }

        /// <summary>
        /// Required. The format will be projects/{project_number}/feeds/{client-assigned_feed_identifier} or
        /// folders/{folder_number}/feeds/{client-assigned_feed_identifier} or
        /// organizations/{organization_number}/feeds/{client-assigned_feed_identifier} The client-assigned feed
        /// identifier must be unique within the parent project/folder/organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output configuration for asset feed destination.</summary>
    public class FeedOutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Destination on Pub/Sub.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubDestination")]
        public virtual PubsubDestination PubsubDestination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Cloud Storage location.</summary>
    public class GcsDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The uri of the Cloud Storage object. It's the same uri that is used by gsutil. Example:
        /// "gs://bucket_name/object_name". See [Viewing and Editing Object
        /// Metadata](https://cloud.google.com/storage/docs/viewing-editing-metadata) for more information. If the
        /// specified Cloud Storage object already exists and there is no
        /// [hold](https://cloud.google.com/storage/docs/object-holds), it will be overwritten with the exported result.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>
        /// The uri prefix of all generated Cloud Storage objects. Example: "gs://bucket_name/object_name_prefix". Each
        /// object uri is in format: "gs://bucket_name/object_name_prefix// and only contains assets for that type.
        /// starts from 0. Example: "gs://bucket_name/object_name_prefix/compute.googleapis.com/Disk/0" is the first
        /// shard of output objects containing all compute.googleapis.com/Disk assets. An INVALID_ARGUMENT error will be
        /// returned if file with the same name "gs://bucket_name/object_name_prefix" already exists.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uriPrefix")]
        public virtual string UriPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An IAM role or permission under analysis.</summary>
    public class GoogleCloudAssetV1Access : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The analysis state of this access.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisState")]
        public virtual IamPolicyAnalysisState AnalysisState { get; set; }

        /// <summary>The permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permission")]
        public virtual string Permission { get; set; }

        /// <summary>The role.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An access control list, derived from the above IAM policy binding, which contains a set of resources and
    /// accesses. May include one item from each set to compose an access control entry. NOTICE that there could be
    /// multiple access control lists for one IAM policy binding. The access control lists are created based on resource
    /// and access combinations. For example, assume we have the following cases in one IAM policy binding: - Permission
    /// P1 and P2 apply to resource R1 and R2; - Permission P3 applies to resource R2 and R3; This will result in the
    /// following access control lists: - AccessControlList 1: [R1, R2], [P1, P2] - AccessControlList 2: [R2, R3], [P3]
    /// </summary>
    public class GoogleCloudAssetV1AccessControlList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The accesses that match one of the following conditions: - The access_selector, if it is specified in
        /// request; - Otherwise, access specifiers reachable from the policy binding's role.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accesses")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssetV1Access> Accesses { get; set; }

        /// <summary>
        /// Condition evaluation for this AccessControlList, if there is a condition defined in the above IAM policy
        /// binding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionEvaluation")]
        public virtual ConditionEvaluation ConditionEvaluation { get; set; }

        /// <summary>
        /// Resource edges of the graph starting from the policy attached resource to any descendant resources. The
        /// Edge.source_node contains the full resource name of a parent resource and Edge.target_node contains the full
        /// resource name of a child resource. This field is present only if the output_resource_edges option is enabled
        /// in request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceEdges")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssetV1Edge> ResourceEdges { get; set; }

        /// <summary>
        /// The resources that match one of the following conditions: - The resource_selector, if it is specified in
        /// request; - Otherwise, resources reachable from the policy attached resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssetV1Resource> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A BigQuery destination.</summary>
    public class GoogleCloudAssetV1BigQueryDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The BigQuery dataset in format "projects/projectId/datasets/datasetId", to which the analysis
        /// results should be exported. If this dataset does not exist, the export call will return an INVALID_ARGUMENT
        /// error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>The partition key for BigQuery partitioned table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionKey")]
        public virtual string PartitionKey { get; set; }

        /// <summary>
        /// Required. The prefix of the BigQuery tables to which the analysis results will be written. Tables will be
        /// created based on this table_prefix if not exist: * _analysis table will contain export operation's metadata.
        /// * _analysis_result will contain all the IamPolicyAnalysisResult. When [partition_key] is specified, both
        /// tables will be partitioned based on the [partition_key].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tablePrefix")]
        public virtual string TablePrefix { get; set; }

        /// <summary>
        /// Optional. Specifies the action that occurs if the destination table or partition already exists. The
        /// following values are supported: * WRITE_TRUNCATE: If the table or partition already exists, BigQuery
        /// overwrites the entire table or all the partitions data. * WRITE_APPEND: If the table or partition already
        /// exists, BigQuery appends the data to the table or the latest partition. * WRITE_EMPTY: If the table already
        /// exists and contains data, an error is returned. The default value is WRITE_APPEND. Each action is atomic and
        /// only occurs if BigQuery is able to complete the job successfully. Details are at
        /// https://cloud.google.com/bigquery/docs/loading-data-local#appending_to_or_overwriting_a_table_using_a_local_file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeDisposition")]
        public virtual string WriteDisposition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A directional edge.</summary>
    public class GoogleCloudAssetV1Edge : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The source node of the edge. For example, it could be a full resource name for a resource node or an email
        /// of an identity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceNode")]
        public virtual string SourceNode { get; set; }

        /// <summary>
        /// The target node of the edge. For example, it could be a full resource name for a resource node or an email
        /// of an identity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetNode")]
        public virtual string TargetNode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Cloud Storage location.</summary>
    public class GoogleCloudAssetV1GcsDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The uri of the Cloud Storage object. It's the same uri that is used by gsutil. Example:
        /// "gs://bucket_name/object_name". See [Viewing and Editing Object
        /// Metadata](https://cloud.google.com/storage/docs/viewing-editing-metadata) for more information. If the
        /// specified Cloud Storage object already exists and there is no
        /// [hold](https://cloud.google.com/storage/docs/object-holds), it will be overwritten with the analysis result.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An identity under analysis.</summary>
    public class GoogleCloudAssetV1Identity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The analysis state of this identity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisState")]
        public virtual IamPolicyAnalysisState AnalysisState { get; set; }

        /// <summary>
        /// The identity name in any form of members appear in [IAM policy
        /// binding](https://cloud.google.com/iam/reference/rest/v1/Binding), such as: - user:foo@google.com -
        /// group:group1@google.com - serviceAccount:s1@prj1.iam.gserviceaccount.com - projectOwner:some_project_id -
        /// domain:google.com - allUsers - etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The identities and group edges.</summary>
    public class GoogleCloudAssetV1IdentityList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Group identity edges of the graph starting from the binding's group members to any node of the identities.
        /// The Edge.source_node contains a group, such as `group:parent@google.com`. The Edge.target_node contains a
        /// member of the group, such as `group:child@google.com` or `user:foo@google.com`. This field is present only
        /// if the output_group_edges option is enabled in request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupEdges")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssetV1Edge> GroupEdges { get; set; }

        /// <summary>
        /// Only the identities that match one of the following conditions will be presented: - The identity_selector,
        /// if it is specified in request; - Otherwise, identities reachable from the policy binding's members.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identities")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssetV1Identity> Identities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Google Cloud resource under analysis.</summary>
    public class GoogleCloudAssetV1Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The analysis state of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisState")]
        public virtual IamPolicyAnalysisState AnalysisState { get; set; }

        /// <summary>
        /// The [full resource name](https://cloud.google.com/asset-inventory/docs/resource-name-format)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An asset in Google Cloud. An asset can be any resource in the Google Cloud [resource
    /// hierarchy](https://cloud.google.com/resource-manager/docs/cloud-platform-resource-hierarchy), a resource outside
    /// the Google Cloud resource hierarchy (such as Google Kubernetes Engine clusters and objects), or a policy (e.g.
    /// Cloud IAM policy). See [Supported asset
    /// types](https://cloud.google.com/asset-inventory/docs/supported-asset-types) for more information.
    /// </summary>
    public class GoogleCloudAssetV1p7beta1Asset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Please also refer to the [access level user
        /// guide](https://cloud.google.com/access-context-manager/docs/overview#access-levels).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLevel")]
        public virtual GoogleIdentityAccesscontextmanagerV1AccessLevel AccessLevel { get; set; }

        /// <summary>
        /// Please also refer to the [access policy user
        /// guide](https://cloud.google.com/access-context-manager/docs/overview#access-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessPolicy")]
        public virtual GoogleIdentityAccesscontextmanagerV1AccessPolicy AccessPolicy { get; set; }

        /// <summary>
        /// The ancestry path of an asset in Google Cloud [resource
        /// hierarchy](https://cloud.google.com/resource-manager/docs/cloud-platform-resource-hierarchy), represented as
        /// a list of relative resource names. An ancestry path starts with the closest ancestor in the hierarchy and
        /// ends at root. If the asset is a project, folder, or organization, the ancestry path starts from the asset
        /// itself. Example: `["projects/123456789", "folders/5432", "organizations/1234"]`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ancestors")]
        public virtual System.Collections.Generic.IList<string> Ancestors { get; set; }

        /// <summary>
        /// The type of the asset. Example: `compute.googleapis.com/Disk` See [Supported asset
        /// types](https://cloud.google.com/asset-inventory/docs/supported-asset-types) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetType")]
        public virtual string AssetType { get; set; }

        /// <summary>
        /// A representation of the Cloud IAM policy set on a Google Cloud resource. There can be a maximum of one Cloud
        /// IAM policy set on any given resource. In addition, Cloud IAM policies inherit their granted access scope
        /// from any policies set on parent resources in the resource hierarchy. Therefore, the effectively policy is
        /// the union of both the policy set on this resource and each policy set on all of the resource's ancestry
        /// resource levels in the hierarchy. See [this topic](https://cloud.google.com/iam/docs/policies#inheritance)
        /// for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iamPolicy")]
        public virtual Policy IamPolicy { get; set; }

        /// <summary>
        /// The full name of the asset. Example:
        /// `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1` See [Resource
        /// names](https://cloud.google.com/apis/design/resource_names#full_resource_name) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// A representation of an [organization
        /// policy](https://cloud.google.com/resource-manager/docs/organization-policy/overview#organization_policy).
        /// There can be more than one organization policy with different constraints set on a given resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgPolicy")]
        public virtual System.Collections.Generic.IList<GoogleCloudOrgpolicyV1Policy> OrgPolicy { get; set; }

        /// <summary>
        /// The related assets of the asset of one relationship type. One asset only represents one type of
        /// relationship.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedAssets")]
        public virtual GoogleCloudAssetV1p7beta1RelatedAssets RelatedAssets { get; set; }

        /// <summary>A representation of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual GoogleCloudAssetV1p7beta1Resource Resource { get; set; }

        /// <summary>
        /// Please also refer to the [service perimeter user
        /// guide](https://cloud.google.com/vpc-service-controls/docs/overview).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicePerimeter")]
        public virtual GoogleIdentityAccesscontextmanagerV1ServicePerimeter ServicePerimeter { get; set; }

        /// <summary>
        /// The last update timestamp of an asset. update_time is updated when create/update/delete operation is
        /// performed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An asset identify in Google Cloud which contains its name, type and ancestors. An asset can be any resource in
    /// the Google Cloud [resource
    /// hierarchy](https://cloud.google.com/resource-manager/docs/cloud-platform-resource-hierarchy), a resource outside
    /// the Google Cloud resource hierarchy (such as Google Kubernetes Engine clusters and objects), or a policy (e.g.
    /// Cloud IAM policy). See [Supported asset
    /// types](https://cloud.google.com/asset-inventory/docs/supported-asset-types) for more information.
    /// </summary>
    public class GoogleCloudAssetV1p7beta1RelatedAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ancestors of an asset in Google Cloud [resource
        /// hierarchy](https://cloud.google.com/resource-manager/docs/cloud-platform-resource-hierarchy), represented as
        /// a list of relative resource names. An ancestry path starts with the closest ancestor in the hierarchy and
        /// ends at root. Example: `["projects/123456789", "folders/5432", "organizations/1234"]`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ancestors")]
        public virtual System.Collections.Generic.IList<string> Ancestors { get; set; }

        /// <summary>
        /// The full name of the asset. Example:
        /// `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1` See [Resource
        /// names](https://cloud.google.com/apis/design/resource_names#full_resource_name) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public virtual string Asset { get; set; }

        /// <summary>
        /// The type of the asset. Example: `compute.googleapis.com/Disk` See [Supported asset
        /// types](https://cloud.google.com/asset-inventory/docs/supported-asset-types) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetType")]
        public virtual string AssetType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The detailed related assets with the `relationship_type`.</summary>
    public class GoogleCloudAssetV1p7beta1RelatedAssets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The peer resources of the relationship.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assets")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssetV1p7beta1RelatedAsset> Assets { get; set; }

        /// <summary>The detailed relation attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relationshipAttributes")]
        public virtual GoogleCloudAssetV1p7beta1RelationshipAttributes RelationshipAttributes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The relationship attributes which include `type`, `source_resource_type`, `target_resource_type` and `action`.
    /// </summary>
    public class GoogleCloudAssetV1p7beta1RelationshipAttributes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The detail of the relationship, e.g. `contains`, `attaches`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>The source asset type. Example: `compute.googleapis.com/Instance`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceResourceType")]
        public virtual string SourceResourceType { get; set; }

        /// <summary>The target asset type. Example: `compute.googleapis.com/Disk`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetResourceType")]
        public virtual string TargetResourceType { get; set; }

        /// <summary>The unique identifier of the relationship type. Example: `INSTANCE_TO_INSTANCEGROUP`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A representation of a Google Cloud resource.</summary>
    public class GoogleCloudAssetV1p7beta1Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The content of the resource, in which some sensitive fields are removed and may not be present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual System.Collections.Generic.IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// The URL of the discovery document containing the resource's JSON schema. Example:
        /// `https://www.googleapis.com/discovery/v1/apis/compute/v1/rest` This value is unspecified for resources that
        /// do not have an API based on a discovery document, such as Cloud Bigtable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discoveryDocumentUri")]
        public virtual string DiscoveryDocumentUri { get; set; }

        /// <summary>
        /// The JSON schema name listed in the discovery document. Example: `Project` This value is unspecified for
        /// resources that do not have an API based on a discovery document, such as Cloud Bigtable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discoveryName")]
        public virtual string DiscoveryName { get; set; }

        /// <summary>
        /// The location of the resource in Google Cloud, such as its zone and region. For more information, see
        /// https://cloud.google.com/about/locations/.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// The full name of the immediate parent of this resource. See [Resource
        /// Names](https://cloud.google.com/apis/design/resource_names#full_resource_name) for more information. For
        /// Google Cloud assets, this value is the parent resource defined in the [Cloud IAM policy
        /// hierarchy](https://cloud.google.com/iam/docs/overview#policy_hierarchy). Example:
        /// `//cloudresourcemanager.googleapis.com/projects/my_project_123` For third-party assets, this field may be
        /// set differently.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// The REST URL for accessing the resource. An HTTP `GET` request using this URL returns the resource itself.
        /// Example: `https://cloudresourcemanager.googleapis.com/v1/projects/my-project-123` This value is unspecified
        /// for resources without a REST API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUrl")]
        public virtual string ResourceUrl { get; set; }

        /// <summary>The API version. Example: `v1`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Used in `policy_type` to specify how `boolean_policy` will behave at this resource.</summary>
    public class GoogleCloudOrgpolicyV1BooleanPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If `true`, then the `Policy` is enforced. If `false`, then any configuration is acceptable. Suppose you have
        /// a `Constraint` `constraints/compute.disableSerialPortAccess` with `constraint_default` set to `ALLOW`. A
        /// `Policy` for that `Constraint` exhibits the following behavior: - If the `Policy` at this resource has
        /// enforced set to `false`, serial port connection attempts will be allowed. - If the `Policy` at this resource
        /// has enforced set to `true`, serial port connection attempts will be refused. - If the `Policy` at this
        /// resource is `RestoreDefault`, serial port connection attempts will be allowed. - If no `Policy` is set at
        /// this resource or anywhere higher in the resource hierarchy, serial port connection attempts will be allowed.
        /// - If no `Policy` is set at this resource, but one exists higher in the resource hierarchy, the behavior is
        /// as if the`Policy` were set at this resource. The following examples demonstrate the different possible
        /// layerings: Example 1 (nearest `Constraint` wins): `organizations/foo` has a `Policy` with: {enforced: false}
        /// `projects/bar` has no `Policy` set. The constraint at `projects/bar` and `organizations/foo` will not be
        /// enforced. Example 2 (enforcement gets replaced): `organizations/foo` has a `Policy` with: {enforced: false}
        /// `projects/bar` has a `Policy` with: {enforced: true} The constraint at `organizations/foo` is not enforced.
        /// The constraint at `projects/bar` is enforced. Example 3 (RestoreDefault): `organizations/foo` has a `Policy`
        /// with: {enforced: true} `projects/bar` has a `Policy` with: {RestoreDefault: {}} The constraint at
        /// `organizations/foo` is enforced. The constraint at `projects/bar` is not enforced, because
        /// `constraint_default` for the `Constraint` is `ALLOW`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enforced")]
        public virtual System.Nullable<bool> Enforced { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Used in `policy_type` to specify how `list_policy` behaves at this resource. `ListPolicy` can define specific
    /// values and subtrees of Cloud Resource Manager resource hierarchy (`Organizations`, `Folders`, `Projects`) that
    /// are allowed or denied by setting the `allowed_values` and `denied_values` fields. This is achieved by using the
    /// `under:` and optional `is:` prefixes. The `under:` prefix is used to denote resource subtree values. The `is:`
    /// prefix is used to denote specific values, and is required only if the value contains a ":". Values prefixed with
    /// "is:" are treated the same as values with no prefix. Ancestry subtrees must be in one of the following formats:
    /// - "projects/", e.g. "projects/tokyo-rain-123" - "folders/", e.g. "folders/1234" - "organizations/", e.g.
    /// "organizations/1234" The `supports_under` field of the associated `Constraint` defines whether ancestry prefixes
    /// can be used. You can set `allowed_values` and `denied_values` in the same `Policy` if `all_values` is
    /// `ALL_VALUES_UNSPECIFIED`. `ALLOW` or `DENY` are used to allow or deny all values. If `all_values` is set to
    /// either `ALLOW` or `DENY`, `allowed_values` and `denied_values` must be unset.
    /// </summary>
    public class GoogleCloudOrgpolicyV1ListPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The policy all_values state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allValues")]
        public virtual string AllValues { get; set; }

        /// <summary>
        /// List of values allowed at this resource. Can only be set if `all_values` is set to `ALL_VALUES_UNSPECIFIED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedValues")]
        public virtual System.Collections.Generic.IList<string> AllowedValues { get; set; }

        /// <summary>
        /// List of values denied at this resource. Can only be set if `all_values` is set to `ALL_VALUES_UNSPECIFIED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deniedValues")]
        public virtual System.Collections.Generic.IList<string> DeniedValues { get; set; }

        /// <summary>
        /// Determines the inheritance behavior for this `Policy`. By default, a `ListPolicy` set at a resource
        /// supersedes any `Policy` set anywhere up the resource hierarchy. However, if `inherit_from_parent` is set to
        /// `true`, then the values from the effective `Policy` of the parent resource are inherited, meaning the values
        /// set in this `Policy` are added to the values inherited up the hierarchy. Setting `Policy` hierarchies that
        /// inherit both allowed values and denied values isn't recommended in most circumstances to keep the
        /// configuration simple and understandable. However, it is possible to set a `Policy` with `allowed_values` set
        /// that inherits a `Policy` with `denied_values` set. In this case, the values that are allowed must be in
        /// `allowed_values` and not present in `denied_values`. For example, suppose you have a `Constraint`
        /// `constraints/serviceuser.services`, which has a `constraint_type` of `list_constraint`, and with
        /// `constraint_default` set to `ALLOW`. Suppose that at the Organization level, a `Policy` is applied that
        /// restricts the allowed API activations to {`E1`, `E2`}. Then, if a `Policy` is applied to a project below the
        /// Organization that has `inherit_from_parent` set to `false` and field all_values set to DENY, then an attempt
        /// to activate any API will be denied. The following examples demonstrate different possible layerings for
        /// `projects/bar` parented by `organizations/foo`: Example 1 (no inherited values): `organizations/foo` has a
        /// `Policy` with values: {allowed_values: "E1" allowed_values:"E2"} `projects/bar` has `inherit_from_parent`
        /// `false` and values: {allowed_values: "E3" allowed_values: "E4"} The accepted values at `organizations/foo`
        /// are `E1`, `E2`. The accepted values at `projects/bar` are `E3`, and `E4`. Example 2 (inherited values):
        /// `organizations/foo` has a `Policy` with values: {allowed_values: "E1" allowed_values:"E2"} `projects/bar`
        /// has a `Policy` with values: {value: "E3" value: "E4" inherit_from_parent: true} The accepted values at
        /// `organizations/foo` are `E1`, `E2`. The accepted values at `projects/bar` are `E1`, `E2`, `E3`, and `E4`.
        /// Example 3 (inheriting both allowed and denied values): `organizations/foo` has a `Policy` with values:
        /// {allowed_values: "E1" allowed_values: "E2"} `projects/bar` has a `Policy` with: {denied_values: "E1"} The
        /// accepted values at `organizations/foo` are `E1`, `E2`. The value accepted at `projects/bar` is `E2`. Example
        /// 4 (RestoreDefault): `organizations/foo` has a `Policy` with values: {allowed_values: "E1"
        /// allowed_values:"E2"} `projects/bar` has a `Policy` with values: {RestoreDefault: {}} The accepted values at
        /// `organizations/foo` are `E1`, `E2`. The accepted values at `projects/bar` are either all or none depending
        /// on the value of `constraint_default` (if `ALLOW`, all; if `DENY`, none). Example 5 (no policy inherits
        /// parent policy): `organizations/foo` has no `Policy` set. `projects/bar` has no `Policy` set. The accepted
        /// values at both levels are either all or none depending on the value of `constraint_default` (if `ALLOW`,
        /// all; if `DENY`, none). Example 6 (ListConstraint allowing all): `organizations/foo` has a `Policy` with
        /// values: {allowed_values: "E1" allowed_values: "E2"} `projects/bar` has a `Policy` with: {all: ALLOW} The
        /// accepted values at `organizations/foo` are `E1`, E2`. Any value is accepted at `projects/bar`. Example 7
        /// (ListConstraint allowing none): `organizations/foo` has a `Policy` with values: {allowed_values: "E1"
        /// allowed_values: "E2"} `projects/bar` has a `Policy` with: {all: DENY} The accepted values at
        /// `organizations/foo` are `E1`, E2`. No value is accepted at `projects/bar`. Example 10 (allowed and denied
        /// subtrees of Resource Manager hierarchy): Given the following resource hierarchy O1-&amp;gt;{F1, F2};
        /// F1-&amp;gt;{P1}; F2-&amp;gt;{P2, P3}, `organizations/foo` has a `Policy` with values: {allowed_values:
        /// "under:organizations/O1"} `projects/bar` has a `Policy` with: {allowed_values: "under:projects/P3"}
        /// {denied_values: "under:folders/F2"} The accepted values at `organizations/foo` are `organizations/O1`,
        /// `folders/F1`, `folders/F2`, `projects/P1`, `projects/P2`, `projects/P3`. The accepted values at
        /// `projects/bar` are `organizations/O1`, `folders/F1`, `projects/P1`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inheritFromParent")]
        public virtual System.Nullable<bool> InheritFromParent { get; set; }

        /// <summary>
        /// Optional. The Google Cloud Console will try to default to a configuration that matches the value specified
        /// in this `Policy`. If `suggested_value` is not set, it will inherit the value specified higher in the
        /// hierarchy, unless `inherit_from_parent` is `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedValue")]
        public virtual string SuggestedValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines a Cloud Organization `Policy` which is used to specify `Constraints` for configurations of Cloud
    /// Platform resources.
    /// </summary>
    public class GoogleCloudOrgpolicyV1Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>For boolean `Constraints`, whether to enforce the `Constraint` or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("booleanPolicy")]
        public virtual GoogleCloudOrgpolicyV1BooleanPolicy BooleanPolicy { get; set; }

        /// <summary>
        /// The name of the `Constraint` the `Policy` is configuring, for example, `constraints/serviceuser.services`. A
        /// [list of available constraints](/resource-manager/docs/organization-policy/org-policy-constraints) is
        /// available. Immutable after creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraint")]
        public virtual string Constraint { get; set; }

        /// <summary>
        /// An opaque tag indicating the current version of the `Policy`, used for concurrency control. When the
        /// `Policy` is returned from either a `GetPolicy` or a `ListOrgPolicy` request, this `etag` indicates the
        /// version of the current `Policy` to use when executing a read-modify-write loop. When the `Policy` is
        /// returned from a `GetEffectivePolicy` request, the `etag` will be unset. When the `Policy` is used in a
        /// `SetOrgPolicy` method, use the `etag` value that was returned from a `GetOrgPolicy` request as part of a
        /// read-modify-write loop for concurrency control. Not setting the `etag`in a `SetOrgPolicy` request will
        /// result in an unconditional write of the `Policy`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>List of values either allowed or disallowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listPolicy")]
        public virtual GoogleCloudOrgpolicyV1ListPolicy ListPolicy { get; set; }

        /// <summary>Restores the default behavior of the constraint; independent of `Constraint` type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restoreDefault")]
        public virtual GoogleCloudOrgpolicyV1RestoreDefault RestoreDefault { get; set; }

        /// <summary>
        /// The time stamp the `Policy` was previously updated. This is set by the server, not specified by the caller,
        /// and represents the last time a call to `SetOrgPolicy` was made for that `Policy`. Any value set by the
        /// client will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>Version of the `Policy`. Default version is 0;</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; }
    }

    /// <summary>
    /// Ignores policies set above this resource and restores the `constraint_default` enforcement behavior of the
    /// specific `Constraint` at this resource. Suppose that `constraint_default` is set to `ALLOW` for the `Constraint`
    /// `constraints/serviceuser.services`. Suppose that organization foo.com sets a `Policy` at their Organization
    /// resource node that restricts the allowed service activations to deny all service activations. They could then
    /// set a `Policy` with the `policy_type` `restore_default` on several experimental projects, restoring the
    /// `constraint_default` enforcement of the `Constraint` for only those projects, allowing those projects to have
    /// all services activated.
    /// </summary>
    public class GoogleCloudOrgpolicyV1RestoreDefault : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An `AccessLevel` is a label that can be applied to requests to Google Cloud services, along with a list of
    /// requirements necessary for the label to be applied.
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1AccessLevel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A `BasicLevel` composed of `Conditions`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basic")]
        public virtual GoogleIdentityAccesscontextmanagerV1BasicLevel Basic { get; set; }

        /// <summary>A `CustomLevel` written in the Common Expression Language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("custom")]
        public virtual GoogleIdentityAccesscontextmanagerV1CustomLevel Custom { get; set; }

        /// <summary>Description of the `AccessLevel` and its use. Does not affect behavior.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. Resource name for the Access Level. The `short_name` component must begin with a letter and only
        /// include alphanumeric and '_'. Format: `accessPolicies/{policy_id}/accessLevels/{short_name}`. The maximum
        /// length of the `short_name` component is 50 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Human readable title. Must be unique within the Policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `AccessPolicy` is a container for `AccessLevels` (which define the necessary attributes to use Google Cloud
    /// services) and `ServicePerimeters` (which define regions of services able to freely pass data within a
    /// perimeter). An access policy is globally visible within an organization, and the restrictions it specifies apply
    /// to all projects within an organization.
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1AccessPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. An opaque identifier for the current version of the `AccessPolicy`. This will always be a
        /// strongly validated etag, meaning that two Access Polices will be identical if and only if their etags are
        /// identical. Clients should not expect this to be in any specific format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Output only. Resource name of the `AccessPolicy`. Format: `accessPolicies/{policy_id}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The parent of this `AccessPolicy` in the Cloud Resource Hierarchy. Currently immutable once
        /// created. Format: `organizations/{organization_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>Required. Human readable title. Does not affect behavior.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }
    }

    /// <summary>Identification for an API Operation.</summary>
    public class GoogleIdentityAccesscontextmanagerV1ApiOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// API methods or permissions to allow. Method or permission must belong to the service specified by
        /// `service_name` field. A single MethodSelector entry with `*` specified for the `method` field will allow all
        /// methods AND permissions for the service specified in `service_name`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("methodSelectors")]
        public virtual System.Collections.Generic.IList<GoogleIdentityAccesscontextmanagerV1MethodSelector> MethodSelectors { get; set; }

        /// <summary>
        /// The name of the API whose methods or permissions the IngressPolicy or EgressPolicy want to allow. A single
        /// ApiOperation with `service_name` field set to `*` will allow all methods AND permissions for all services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`BasicLevel` is an `AccessLevel` using a set of recommended features.</summary>
    public class GoogleIdentityAccesscontextmanagerV1BasicLevel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// How the `conditions` list should be combined to determine if a request is granted this `AccessLevel`. If AND
        /// is used, each `Condition` in `conditions` must be satisfied for the `AccessLevel` to be applied. If OR is
        /// used, at least one `Condition` in `conditions` must be satisfied for the `AccessLevel` to be applied.
        /// Default behavior is AND.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("combiningFunction")]
        public virtual string CombiningFunction { get; set; }

        /// <summary>Required. A list of requirements for the `AccessLevel` to be granted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleIdentityAccesscontextmanagerV1Condition> Conditions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A condition necessary for an `AccessLevel` to be granted. The Condition is an AND over its fields. So a
    /// Condition is true if: 1) the request IP is from one of the listed subnetworks AND 2) the originating device
    /// complies with the listed device policy AND 3) all listed access levels are granted AND 4) the request was sent
    /// at a time allowed by the DateTimeRestriction.
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1Condition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Device specific restrictions, all restrictions must hold for the Condition to be true. If not specified, all
        /// devices are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devicePolicy")]
        public virtual GoogleIdentityAccesscontextmanagerV1DevicePolicy DevicePolicy { get; set; }

        /// <summary>
        /// CIDR block IP subnetwork specification. May be IPv4 or IPv6. Note that for a CIDR IP address block, the
        /// specified IP address portion must be properly truncated (i.e. all the host bits must be zero) or the input
        /// is considered malformed. For example, "192.0.2.0/24" is accepted but "192.0.2.1/24" is not. Similarly, for
        /// IPv6, "2001:db8::/32" is accepted whereas "2001:db8::1/32" is not. The originating IP of a request must be
        /// in one of the listed subnets in order for this Condition to be true. If empty, all IP addresses are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipSubnetworks")]
        public virtual System.Collections.Generic.IList<string> IpSubnetworks { get; set; }

        /// <summary>
        /// The request must be made by one of the provided user or service accounts. Groups are not supported. Syntax:
        /// `user:{emailid}` `serviceAccount:{emailid}` If not specified, a request may come from any user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Whether to negate the Condition. If true, the Condition becomes a NAND over its non-empty fields, each field
        /// must be false for the Condition overall to be satisfied. Defaults to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negate")]
        public virtual System.Nullable<bool> Negate { get; set; }

        /// <summary>
        /// The request must originate from one of the provided countries/regions. Must be valid ISO 3166-1 alpha-2
        /// codes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regions")]
        public virtual System.Collections.Generic.IList<string> Regions { get; set; }

        /// <summary>
        /// A list of other access levels defined in the same `Policy`, referenced by resource name. Referencing an
        /// `AccessLevel` which does not exist is an error. All access levels listed must be granted for the Condition
        /// to be true. Example: "`accessPolicies/MY_POLICY/accessLevels/LEVEL_NAME"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiredAccessLevels")]
        public virtual System.Collections.Generic.IList<string> RequiredAccessLevels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `CustomLevel` is an `AccessLevel` using the Cloud Common Expression Language to represent the necessary
    /// conditions for the level to apply to a request. See CEL spec at: https://github.com/google/cel-spec
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1CustomLevel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A Cloud CEL expression evaluating to a boolean.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expr")]
        public virtual Expr Expr { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `DevicePolicy` specifies device specific restrictions necessary to acquire a given access level. A
    /// `DevicePolicy` specifies requirements for requests from devices to be granted access levels, it does not do any
    /// enforcement on the device. `DevicePolicy` acts as an AND over all specified fields, and each repeated field is
    /// an OR over its elements. Any unset fields are ignored. For example, if the proto is { os_type : DESKTOP_WINDOWS,
    /// os_type : DESKTOP_LINUX, encryption_status: ENCRYPTED}, then the DevicePolicy will be true for requests
    /// originating from encrypted Linux desktops and encrypted Windows desktops.
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1DevicePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Allowed device management levels, an empty list allows all management levels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedDeviceManagementLevels")]
        public virtual System.Collections.Generic.IList<string> AllowedDeviceManagementLevels { get; set; }

        /// <summary>Allowed encryptions statuses, an empty list allows all statuses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedEncryptionStatuses")]
        public virtual System.Collections.Generic.IList<string> AllowedEncryptionStatuses { get; set; }

        /// <summary>Allowed OS versions, an empty list allows all types and all versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osConstraints")]
        public virtual System.Collections.Generic.IList<GoogleIdentityAccesscontextmanagerV1OsConstraint> OsConstraints { get; set; }

        /// <summary>Whether the device needs to be approved by the customer admin.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireAdminApproval")]
        public virtual System.Nullable<bool> RequireAdminApproval { get; set; }

        /// <summary>Whether the device needs to be corp owned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireCorpOwned")]
        public virtual System.Nullable<bool> RequireCorpOwned { get; set; }

        /// <summary>
        /// Whether or not screenlock is required for the DevicePolicy to be true. Defaults to `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireScreenlock")]
        public virtual System.Nullable<bool> RequireScreenlock { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines the conditions under which an EgressPolicy matches a request. Conditions based on information about the
    /// source of the request. Note that if the destination of the request is also protected by a ServicePerimeter, then
    /// that ServicePerimeter must have an IngressPolicy which allows access in order for this request to succeed.
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1EgressFrom : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of identities that are allowed access through this [EgressPolicy]. Should be in the format of email
        /// address. The email address should represent individual user or service account only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identities")]
        public virtual System.Collections.Generic.IList<string> Identities { get; set; }

        /// <summary>
        /// Specifies the type of identities that are allowed access to outside the perimeter. If left unspecified, then
        /// members of `identities` field will be allowed access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityType")]
        public virtual string IdentityType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Policy for egress from perimeter. EgressPolicies match requests based on `egress_from` and `egress_to` stanzas.
    /// For an EgressPolicy to match, both `egress_from` and `egress_to` stanzas must be matched. If an EgressPolicy
    /// matches a request, the request is allowed to span the ServicePerimeter boundary. For example, an EgressPolicy
    /// can be used to allow VMs on networks within the ServicePerimeter to access a defined set of projects outside the
    /// perimeter in certain contexts (e.g. to read data from a Cloud Storage bucket or query against a BigQuery
    /// dataset). EgressPolicies are concerned with the *resources* that a request relates as well as the API services
    /// and API actions being used. They do not related to the direction of data movement. More detailed documentation
    /// for this concept can be found in the descriptions of EgressFrom and EgressTo.
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1EgressPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Defines conditions on the source of a request causing this EgressPolicy to apply.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("egressFrom")]
        public virtual GoogleIdentityAccesscontextmanagerV1EgressFrom EgressFrom { get; set; }

        /// <summary>
        /// Defines the conditions on the ApiOperation and destination resources that cause this EgressPolicy to apply.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("egressTo")]
        public virtual GoogleIdentityAccesscontextmanagerV1EgressTo EgressTo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines the conditions under which an EgressPolicy matches a request. Conditions are based on information about
    /// the ApiOperation intended to be performed on the `resources` specified. Note that if the destination of the
    /// request is also protected by a ServicePerimeter, then that ServicePerimeter must have an IngressPolicy which
    /// allows access in order for this request to succeed. The request must match `operations` AND `resources` fields
    /// in order to be allowed egress out of the perimeter.
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1EgressTo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of ApiOperations allowed to be performed by the sources specified in the corresponding EgressFrom. A
        /// request matches if it uses an operation/service in this list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<GoogleIdentityAccesscontextmanagerV1ApiOperation> Operations { get; set; }

        /// <summary>
        /// A list of resources, currently only projects in the form `projects/`, that are allowed to be accessed by
        /// sources defined in the corresponding EgressFrom. A request matches if it contains a resource in this list.
        /// If `*` is specified for `resources`, then this EgressTo rule will authorize access to all resources outside
        /// the perimeter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<string> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines the conditions under which an IngressPolicy matches a request. Conditions are based on information about
    /// the source of the request. The request must satisfy what is defined in `sources` AND identity related fields in
    /// order to match.
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1IngressFrom : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of identities that are allowed access through this ingress policy. Should be in the format of email
        /// address. The email address should represent individual user or service account only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identities")]
        public virtual System.Collections.Generic.IList<string> Identities { get; set; }

        /// <summary>
        /// Specifies the type of identities that are allowed access from outside the perimeter. If left unspecified,
        /// then members of `identities` field will be allowed access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityType")]
        public virtual string IdentityType { get; set; }

        /// <summary>Sources that this IngressPolicy authorizes access from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<GoogleIdentityAccesscontextmanagerV1IngressSource> Sources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Policy for ingress into ServicePerimeter. IngressPolicies match requests based on `ingress_from` and
    /// `ingress_to` stanzas. For an ingress policy to match, both the `ingress_from` and `ingress_to` stanzas must be
    /// matched. If an IngressPolicy matches a request, the request is allowed through the perimeter boundary from
    /// outside the perimeter. For example, access from the internet can be allowed either based on an AccessLevel or,
    /// for traffic hosted on Google Cloud, the project of the source network. For access from private networks, using
    /// the project of the hosting network is required. Individual ingress policies can be limited by restricting which
    /// services and/or actions they match using the `ingress_to` field.
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1IngressPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Defines the conditions on the source of a request causing this IngressPolicy to apply.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressFrom")]
        public virtual GoogleIdentityAccesscontextmanagerV1IngressFrom IngressFrom { get; set; }

        /// <summary>
        /// Defines the conditions on the ApiOperation and request destination that cause this IngressPolicy to apply.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressTo")]
        public virtual GoogleIdentityAccesscontextmanagerV1IngressTo IngressTo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The source that IngressPolicy authorizes access from.</summary>
    public class GoogleIdentityAccesscontextmanagerV1IngressSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An AccessLevel resource name that allow resources within the ServicePerimeters to be accessed from the
        /// internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent
        /// AccessLevel will cause an error. If no AccessLevel names are listed, resources within the perimeter can only
        /// be accessed via Google Cloud calls with request origins within the perimeter. Example:
        /// `accessPolicies/MY_POLICY/accessLevels/MY_LEVEL`. If a single `*` is specified for `access_level`, then all
        /// IngressSources will be allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLevel")]
        public virtual string AccessLevel { get; set; }

        /// <summary>
        /// A Google Cloud resource that is allowed to ingress the perimeter. Requests from these resources will be
        /// allowed to access perimeter data. Currently only projects are allowed. Format: `projects/{project_number}`
        /// The project may be in any Google Cloud organization, not just the organization that the perimeter is defined
        /// in. `*` is not allowed, the case of allowing all Google Cloud resources only is not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines the conditions under which an IngressPolicy matches a request. Conditions are based on information about
    /// the ApiOperation intended to be performed on the target resource of the request. The request must satisfy what
    /// is defined in `operations` AND `resources` in order to match.
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1IngressTo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of ApiOperations allowed to be performed by the sources specified in corresponding IngressFrom in
        /// this ServicePerimeter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<GoogleIdentityAccesscontextmanagerV1ApiOperation> Operations { get; set; }

        /// <summary>
        /// A list of resources, currently only projects in the form `projects/`, protected by this ServicePerimeter
        /// that are allowed to be accessed by sources defined in the corresponding IngressFrom. If a single `*` is
        /// specified, then access to all resources inside the perimeter are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<string> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An allowed method or permission of a service specified in ApiOperation.</summary>
    public class GoogleIdentityAccesscontextmanagerV1MethodSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Value for `method` should be a valid method name for the corresponding `service_name` in ApiOperation. If
        /// `*` used as value for `method`, then ALL methods and permissions are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; }

        /// <summary>
        /// Value for `permission` should be a valid Cloud IAM permission for the corresponding `service_name` in
        /// ApiOperation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permission")]
        public virtual string Permission { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A restriction on the OS type and version of devices making requests.</summary>
    public class GoogleIdentityAccesscontextmanagerV1OsConstraint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The minimum allowed OS version. If not set, any version of this OS satisfies the constraint. Format:
        /// `"major.minor.patch"`. Examples: `"10.5.301"`, `"9.2.1"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumVersion")]
        public virtual string MinimumVersion { get; set; }

        /// <summary>Required. The allowed OS type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osType")]
        public virtual string OsType { get; set; }

        /// <summary>
        /// Only allows requests from devices with a verified Chrome OS. Verifications includes requirements that the
        /// device is enterprise-managed, conformant to domain policies, and the caller has permission to call the API
        /// targeted by the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireVerifiedChromeOs")]
        public virtual System.Nullable<bool> RequireVerifiedChromeOs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `ServicePerimeter` describes a set of Google Cloud resources which can freely import and export data amongst
    /// themselves, but not export outside of the `ServicePerimeter`. If a request with a source within this
    /// `ServicePerimeter` has a target outside of the `ServicePerimeter`, the request will be blocked. Otherwise the
    /// request is allowed. There are two types of Service Perimeter - Regular and Bridge. Regular Service Perimeters
    /// cannot overlap, a single Google Cloud project can only belong to a single regular Service Perimeter. Service
    /// Perimeter Bridges can contain only Google Cloud projects as members, a single Google Cloud project may belong to
    /// multiple Service Perimeter Bridges.
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1ServicePerimeter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the `ServicePerimeter` and its use. Does not affect behavior.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. Resource name for the ServicePerimeter. The `short_name` component must begin with a letter and
        /// only include alphanumeric and '_'. Format: `accessPolicies/{policy_id}/servicePerimeters/{short_name}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Perimeter type indicator. A single project is allowed to be a member of single regular perimeter, but
        /// multiple service perimeter bridges. A project cannot be a included in a perimeter bridge without being
        /// included in regular perimeter. For perimeter bridges, the restricted service list as well as access level
        /// lists must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("perimeterType")]
        public virtual string PerimeterType { get; set; }

        /// <summary>
        /// Proposed (or dry run) ServicePerimeter configuration. This configuration allows to specify and test
        /// ServicePerimeter configuration without enforcing actual access restrictions. Only allowed to be set when the
        /// "use_explicit_dry_run_spec" flag is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual GoogleIdentityAccesscontextmanagerV1ServicePerimeterConfig Spec { get; set; }

        /// <summary>
        /// Current ServicePerimeter configuration. Specifies sets of resources, restricted services and access levels
        /// that determine perimeter content and boundaries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleIdentityAccesscontextmanagerV1ServicePerimeterConfig Status { get; set; }

        /// <summary>Human readable title. Must be unique within the Policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// Use explicit dry run spec flag. Ordinarily, a dry-run spec implicitly exists for all Service Perimeters, and
        /// that spec is identical to the status for those Service Perimeters. When this flag is set, it inhibits the
        /// generation of the implicit spec, thereby allowing the user to explicitly provide a configuration ("spec") to
        /// use in a dry-run version of the Service Perimeter. This allows the user to test changes to the enforced
        /// config ("status") without actually enforcing them. This testing is done through analyzing the differences
        /// between currently enforced and suggested restrictions. use_explicit_dry_run_spec must bet set to True if any
        /// of the fields in the spec are set to non-default values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useExplicitDryRunSpec")]
        public virtual System.Nullable<bool> UseExplicitDryRunSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `ServicePerimeterConfig` specifies a set of Google Cloud resources that describe specific Service Perimeter
    /// configuration.
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1ServicePerimeterConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of `AccessLevel` resource names that allow resources within the `ServicePerimeter` to be accessed
        /// from the internet. `AccessLevels` listed must be in the same policy as this `ServicePerimeter`. Referencing
        /// a nonexistent `AccessLevel` is a syntax error. If no `AccessLevel` names are listed, resources within the
        /// perimeter can only be accessed via Google Cloud calls with request origins within the perimeter. Example:
        /// `"accessPolicies/MY_POLICY/accessLevels/MY_LEVEL"`. For Service Perimeter Bridge, must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLevels")]
        public virtual System.Collections.Generic.IList<string> AccessLevels { get; set; }

        /// <summary>
        /// List of EgressPolicies to apply to the perimeter. A perimeter may have multiple EgressPolicies, each of
        /// which is evaluated separately. Access is granted if any EgressPolicy grants it. Must be empty for a
        /// perimeter bridge.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("egressPolicies")]
        public virtual System.Collections.Generic.IList<GoogleIdentityAccesscontextmanagerV1EgressPolicy> EgressPolicies { get; set; }

        /// <summary>
        /// List of IngressPolicies to apply to the perimeter. A perimeter may have multiple IngressPolicies, each of
        /// which is evaluated separately. Access is granted if any Ingress Policy grants it. Must be empty for a
        /// perimeter bridge.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressPolicies")]
        public virtual System.Collections.Generic.IList<GoogleIdentityAccesscontextmanagerV1IngressPolicy> IngressPolicies { get; set; }

        /// <summary>
        /// A list of Google Cloud resources that are inside of the service perimeter. Currently only projects are
        /// allowed. Format: `projects/{project_number}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<string> Resources { get; set; }

        /// <summary>
        /// Google Cloud services that are subject to the Service Perimeter restrictions. For example, if
        /// `storage.googleapis.com` is specified, access to the storage buckets inside the perimeter must meet the
        /// perimeter's access restrictions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictedServices")]
        public virtual System.Collections.Generic.IList<string> RestrictedServices { get; set; }

        /// <summary>Configuration for APIs allowed within Perimeter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcAccessibleServices")]
        public virtual GoogleIdentityAccesscontextmanagerV1VpcAccessibleServices VpcAccessibleServices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies how APIs are allowed to communicate within the Service Perimeter.</summary>
    public class GoogleIdentityAccesscontextmanagerV1VpcAccessibleServices : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of APIs usable within the Service Perimeter. Must be empty unless 'enable_restriction' is True. You
        /// can specify a list of individual services, as well as include the 'RESTRICTED-SERVICES' value, which
        /// automatically includes all of the services protected by the perimeter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedServices")]
        public virtual System.Collections.Generic.IList<string> AllowedServices { get; set; }

        /// <summary>
        /// Whether to restrict API calls within the Service Perimeter to the list of APIs specified in
        /// 'allowed_services'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableRestriction")]
        public virtual System.Nullable<bool> EnableRestriction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An analysis message to group the query and results.</summary>
    public class IamPolicyAnalysis : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The analysis query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisQuery")]
        public virtual IamPolicyAnalysisQuery AnalysisQuery { get; set; }

        /// <summary>
        /// A list of IamPolicyAnalysisResult that matches the analysis query, or empty if no result is found.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisResults")]
        public virtual System.Collections.Generic.IList<IamPolicyAnalysisResult> AnalysisResults { get; set; }

        /// <summary>
        /// Represents whether all entries in the analysis_results have been fully explored to answer the query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullyExplored")]
        public virtual System.Nullable<bool> FullyExplored { get; set; }

        /// <summary>A list of non-critical errors happened during the query handling.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonCriticalErrors")]
        public virtual System.Collections.Generic.IList<IamPolicyAnalysisState> NonCriticalErrors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output configuration for export IAM policy analysis destination.</summary>
    public class IamPolicyAnalysisOutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Destination on BigQuery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryDestination")]
        public virtual GoogleCloudAssetV1BigQueryDestination BigqueryDestination { get; set; }

        /// <summary>Destination on Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual GoogleCloudAssetV1GcsDestination GcsDestination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>## IAM policy analysis query message.</summary>
    public class IamPolicyAnalysisQuery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Specifies roles or permissions for analysis. This is optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessSelector")]
        public virtual AccessSelector AccessSelector { get; set; }

        /// <summary>Optional. The hypothetical context for IAM conditions evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionContext")]
        public virtual ConditionContext ConditionContext { get; set; }

        /// <summary>Optional. Specifies an identity for analysis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identitySelector")]
        public virtual IdentitySelector IdentitySelector { get; set; }

        /// <summary>Optional. The query options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual Options Options { get; set; }

        /// <summary>Optional. Specifies a resource for analysis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceSelector")]
        public virtual ResourceSelector ResourceSelector { get; set; }

        /// <summary>
        /// Required. The relative name of the root asset. Only resources and IAM policies within the scope will be
        /// analyzed. This can only be an organization number (such as "organizations/123"), a folder number (such as
        /// "folders/123"), a project ID (such as "projects/my-project-id"), or a project number (such as
        /// "projects/12345"). To know how to get organization id, visit [here
        /// ](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).
        /// To know how to get folder or project id, visit [here
        /// ](https://cloud.google.com/resource-manager/docs/creating-managing-folders#viewing_or_listing_folders_and_projects).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// IAM Policy analysis result, consisting of one IAM policy binding and derived access control lists.
    /// </summary>
    public class IamPolicyAnalysisResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The access control lists derived from the iam_binding that match or potentially match resource and access
        /// selectors specified in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessControlLists")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssetV1AccessControlList> AccessControlLists { get; set; }

        /// <summary>
        /// The [full resource name](https://cloud.google.com/asset-inventory/docs/resource-name-format) of the resource
        /// to which the iam_binding policy attaches.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachedResourceFullName")]
        public virtual string AttachedResourceFullName { get; set; }

        /// <summary>Represents whether all analyses on the iam_binding have successfully finished.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullyExplored")]
        public virtual System.Nullable<bool> FullyExplored { get; set; }

        /// <summary>The Cloud IAM policy binding under analysis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iamBinding")]
        public virtual Binding IamBinding { get; set; }

        /// <summary>
        /// The identity list derived from members of the iam_binding that match or potentially match identity selector
        /// specified in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityList")]
        public virtual GoogleCloudAssetV1IdentityList IdentityList { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the detailed state of an entity under analysis, such as a resource, an identity or an access.
    /// </summary>
    public class IamPolicyAnalysisState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The human-readable description of the cause of failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cause")]
        public virtual string Cause { get; set; }

        /// <summary>
        /// The Google standard error code that best describes the state. For example: - OK means the analysis on this
        /// entity has been successfully finished; - PERMISSION_DENIED means an access denied error is encountered; -
        /// DEADLINE_EXCEEDED means the analysis on this entity hasn't been started in time;
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A result of IAM Policy search, containing information of an IAM policy.</summary>
    public class IamPolicySearchResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The type of the resource associated with this IAM policy. Example: `compute.googleapis.com/Disk`. To search
        /// against the `asset_type`: * specify the `asset_types` field in your search request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetType")]
        public virtual string AssetType { get; set; }

        /// <summary>
        /// Explanation about the IAM policy search result. It contains additional information to explain why the search
        /// result matches the query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explanation")]
        public virtual Explanation Explanation { get; set; }

        /// <summary>
        /// The folder(s) that the IAM policy belongs to, in the form of folders/{FOLDER_NUMBER}. This field is
        /// available when the IAM policy belongs to one or more folders. To search against `folders`: * use a field
        /// query. Example: `folders:(123 OR 456)` * use a free text query. Example: `123` * specify the `scope` field
        /// as this folder in your search request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folders")]
        public virtual System.Collections.Generic.IList<string> Folders { get; set; }

        /// <summary>
        /// The organization that the IAM policy belongs to, in the form of organizations/{ORGANIZATION_NUMBER}. This
        /// field is available when the IAM policy belongs to an organization. To search against `organization`: * use a
        /// field query. Example: `organization:123` * use a free text query. Example: `123` * specify the `scope` field
        /// as this organization in your search request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual string Organization { get; set; }

        /// <summary>
        /// The IAM policy directly set on the given resource. Note that the original IAM policy can contain multiple
        /// bindings. This only contains the bindings that match the given query. For queries that don't contain a
        /// constrain on policies (e.g., an empty query), this contains all the bindings. To search against the `policy`
        /// bindings: * use a field query: - query by the policy contained members. Example: `policy:amy@gmail.com` -
        /// query by the policy contained roles. Example: `policy:roles/compute.admin` - query by the policy contained
        /// roles' included permissions. Example: `policy.role.permissions:compute.instances.create`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>
        /// The project that the associated GCP resource belongs to, in the form of projects/{PROJECT_NUMBER}. If an IAM
        /// policy is set on a resource (like VM instance, Cloud Storage bucket), the project field will indicate the
        /// project that contains the resource. If an IAM policy is set on a folder or orgnization, this field will be
        /// empty. To search against the `project`: * specify the `scope` field as this project in your search request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>
        /// The full resource name of the resource associated with this IAM policy. Example:
        /// `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1`. See [Cloud Asset
        /// Inventory Resource Name Format](https://cloud.google.com/asset-inventory/docs/resource-name-format) for more
        /// information. To search against the `resource`: * use a field query. Example: `resource:organizations/123`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies an identity for which to determine resource access, based on roles assigned either directly to them or
    /// to the groups they belong to, directly or indirectly.
    /// </summary>
    public class IdentitySelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The identity appear in the form of members in [IAM policy
        /// binding](https://cloud.google.com/iam/reference/rest/v1/Binding). The examples of supported forms are:
        /// "user:mike@example.com", "group:admins@example.com", "domain:google.com",
        /// "serviceAccount:my-project-id@appspot.gserviceaccount.com". Notice that wildcard characters (such as * and
        /// ?) are not supported. You must give a specific identity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identity")]
        public virtual string Identity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The inventory details of a VM.</summary>
    public class Inventory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Inventory items related to the VM keyed by an opaque unique identifier for each inventory item. The
        /// identifier is unique to each distinct and addressable inventory item and will change, when there is a new
        /// package version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IDictionary<string, Item> Items { get; set; }

        /// <summary>Base level operating system information for the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osInfo")]
        public virtual OsInfo OsInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single piece of inventory on a VM.</summary>
    public class Item : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Software package available to be installed on the VM instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availablePackage")]
        public virtual SoftwarePackage AvailablePackage { get; set; }

        /// <summary>When this inventory item was first detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Identifier for this item, unique across items for this VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Software package present on the VM instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installedPackage")]
        public virtual SoftwarePackage InstalledPackage { get; set; }

        /// <summary>The origin of this inventory item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originType")]
        public virtual string OriginType { get; set; }

        /// <summary>The specific type of inventory, correlating to its specific details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>When this inventory item was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListAssets response.</summary>
    public class ListAssetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Assets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assets")]
        public virtual System.Collections.Generic.IList<Asset> Assets { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results. It expires 72 hours after the page token for the first page is
        /// generated. Set to empty if there are no remaining results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Time the snapshot was taken.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual object ReadTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListFeedsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of feeds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feeds")]
        public virtual System.Collections.Generic.IList<Feed> Feeds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message to group the analysis information.</summary>
    public class MoveAnalysis : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Analysis result of moving the target resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysis")]
        public virtual MoveAnalysisResult Analysis { get; set; }

        /// <summary>The user friendly display name of the analysis. E.g. IAM, Organization Policy etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Description of error encountered when performing the analysis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An analysis result including blockers and warnings.</summary>
    public class MoveAnalysisResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Blocking information that would prevent the target resource from moving to the specified destination at
        /// runtime.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockers")]
        public virtual System.Collections.Generic.IList<MoveImpact> Blockers { get; set; }

        /// <summary>
        /// Warning information indicating that moving the target resource to the specified destination might be unsafe.
        /// This can include important policy information and configuration changes, but will not block moves at
        /// runtime.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<MoveImpact> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message to group impacts of moving the target resource.</summary>
    public class MoveImpact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>User friendly impact detail in a free form message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual string Detail { get; set; }

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

    /// <summary>Contains query options.</summary>
    public class Options : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If true, the response will include access analysis from identities to resources via service
        /// account impersonation. This is a very expensive operation, because many derived queries will be executed. We
        /// highly recommend you use AssetService.AnalyzeIamPolicyLongrunning rpc instead. For example, if the request
        /// analyzes for which resources user A has permission P, and there's an IAM policy states user A has
        /// iam.serviceAccounts.getAccessToken permission to a service account SA, and there's another IAM policy states
        /// service account SA has permission P to a GCP folder F, then user A potentially has access to the GCP folder
        /// F. And those advanced analysis results will be included in
        /// AnalyzeIamPolicyResponse.service_account_impersonation_analysis. Another example, if the request analyzes
        /// for who has permission P to a GCP folder F, and there's an IAM policy states user A has
        /// iam.serviceAccounts.actAs permission to a service account SA, and there's another IAM policy states service
        /// account SA has permission P to the GCP folder F, then user A potentially has access to the GCP folder F. And
        /// those advanced analysis results will be included in
        /// AnalyzeIamPolicyResponse.service_account_impersonation_analysis. Default is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyzeServiceAccountImpersonation")]
        public virtual System.Nullable<bool> AnalyzeServiceAccountImpersonation { get; set; }

        /// <summary>
        /// Optional. If true, the identities section of the result will expand any Google groups appearing in an IAM
        /// policy binding. If IamPolicyAnalysisQuery.identity_selector is specified, the identity in the result will be
        /// determined by the selector, and this flag is not allowed to set. Default is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expandGroups")]
        public virtual System.Nullable<bool> ExpandGroups { get; set; }

        /// <summary>
        /// Optional. If true and IamPolicyAnalysisQuery.resource_selector is not specified, the resource section of the
        /// result will expand any resource attached to an IAM policy to include resources lower in the resource
        /// hierarchy. For example, if the request analyzes for which resources user A has permission P, and the results
        /// include an IAM policy with P on a GCP folder, the results will also include resources in that folder with
        /// permission P. If true and IamPolicyAnalysisQuery.resource_selector is specified, the resource section of the
        /// result will expand the specified resource to include resources lower in the resource hierarchy. Only project
        /// or lower resources are supported. Folder and organization resource cannot be used together with this option.
        /// For example, if the request analyzes for which users have permission P on a GCP project with this option
        /// enabled, the results will include all users who have permission P on that project or any lower resource.
        /// Default is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expandResources")]
        public virtual System.Nullable<bool> ExpandResources { get; set; }

        /// <summary>
        /// Optional. If true, the access section of result will expand any roles appearing in IAM policy bindings to
        /// include their permissions. If IamPolicyAnalysisQuery.access_selector is specified, the access section of the
        /// result will be determined by the selector, and this flag is not allowed to set. Default is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expandRoles")]
        public virtual System.Nullable<bool> ExpandRoles { get; set; }

        /// <summary>
        /// Optional. If true, the result will output group identity edges, starting from the binding's group members,
        /// to any expanded identities. Default is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputGroupEdges")]
        public virtual System.Nullable<bool> OutputGroupEdges { get; set; }

        /// <summary>
        /// Optional. If true, the result will output resource edges, starting from the policy attached resource, to any
        /// expanded resources. Default is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputResourceEdges")]
        public virtual System.Nullable<bool> OutputResourceEdges { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Operating system information for the VM.</summary>
    public class OsInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The system architecture of the operating system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("architecture")]
        public virtual string Architecture { get; set; }

        /// <summary>The VM hostname.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostname")]
        public virtual string Hostname { get; set; }

        /// <summary>The kernel release of the operating system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kernelRelease")]
        public virtual string KernelRelease { get; set; }

        /// <summary>The kernel version of the operating system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kernelVersion")]
        public virtual string KernelVersion { get; set; }

        /// <summary>
        /// The operating system long name. For example 'Debian GNU/Linux 9' or 'Microsoft Window Server 2019
        /// Datacenter'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longName")]
        public virtual string LongName { get; set; }

        /// <summary>The current version of the OS Config agent running on the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osconfigAgentVersion")]
        public virtual string OsconfigAgentVersion { get; set; }

        /// <summary>The operating system short name. For example, 'windows' or 'debian'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortName")]
        public virtual string ShortName { get; set; }

        /// <summary>The version of the operating system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output configuration for export assets destination.</summary>
    public class OutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Destination on BigQuery. The output table stores the fields in asset proto as columns in BigQuery.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryDestination")]
        public virtual BigQueryDestination BigqueryDestination { get; set; }

        /// <summary>Destination on Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual GcsDestination GcsDestination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifications of BigQuery partitioned table as export destination.</summary>
    public class PartitionSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The partition key for BigQuery partitioned table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionKey")]
        public virtual string PartitionKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>IAM permissions</summary>
    public class Permissions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of permissions. A sample permission string: `compute.disk.get`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> PermissionsValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Identity and Access Management (IAM) policy, which specifies access controls for Google Cloud resources. A
    /// `Policy` is a collection of `bindings`. A `binding` binds one or more `members` to a single `role`. Members can
    /// be user accounts, service accounts, Google groups, and domains (such as G Suite). A `role` is a named list of
    /// permissions; each `role` can be an IAM predefined role or a user-created custom role. For some types of Google
    /// Cloud resources, a `binding` can also specify a `condition`, which is a logical expression that allows access to
    /// a resource only if the expression evaluates to `true`. A condition can add constraints based on attributes of
    /// the request, the resource, or both. To learn which resources support conditions in their IAM policies, see the
    /// [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:** {
    /// "bindings": [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 } **YAML example:**
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') - etag: BwWWja0YfJA= - version: 3 For a description of IAM and its
    /// features, see the [IAM documentation](https://cloud.google.com/iam/docs/).
    /// </summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<AuditConfig> AuditConfigs { get; set; }

        /// <summary>
        /// Associates a list of `members` to a `role`. Optionally, may specify a `condition` that determines how and
        /// when the `bindings` are applied. Each of the `bindings` must contain at least one member.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<Binding> Bindings { get; set; }

        /// <summary>
        /// `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy
        /// from overwriting each other. It is strongly suggested that systems make use of the `etag` in the
        /// read-modify-write cycle to perform policy updates in order to avoid race conditions: An `etag` is returned
        /// in the response to `getIamPolicy`, and systems are expected to put that etag in the request to
        /// `setIamPolicy` to ensure that their change will be applied to the same version of the policy. **Important:**
        /// If you use IAM Conditions, you must include the `etag` field whenever you call `setIamPolicy`. If you omit
        /// this field, then IAM allows you to overwrite a version `3` policy with a version `1` policy, and all of the
        /// conditions in the version `3` policy are lost.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Specifies the format of the policy. Valid values are `0`, `1`, and `3`. Requests that specify an invalid
        /// value are rejected. Any operation that affects conditional role bindings must specify version `3`. This
        /// requirement applies to the following operations: * Getting a policy that includes a conditional role binding
        /// * Adding a conditional role binding to a policy * Changing a conditional role binding in a policy * Removing
        /// any role binding, with or without a condition, from a policy that includes conditions **Important:** If you
        /// use IAM Conditions, you must include the `etag` field whenever you call `setIamPolicy`. If you omit this
        /// field, then IAM allows you to overwrite a version `3` policy with a version `1` policy, and all of the
        /// conditions in the version `3` policy are lost. If a policy does not include any conditions, operations on
        /// that policy may specify any valid version or leave the field unset. To learn which resources support
        /// conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; }
    }

    /// <summary>A Pub/Sub destination.</summary>
    public class PubsubDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the Pub/Sub topic to publish to. Example: `projects/PROJECT_ID/topics/TOPIC_ID`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A representation of a Google Cloud resource.</summary>
    public class Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The content of the resource, in which some sensitive fields are removed and may not be present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual System.Collections.Generic.IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// The URL of the discovery document containing the resource's JSON schema. Example:
        /// `https://www.googleapis.com/discovery/v1/apis/compute/v1/rest` This value is unspecified for resources that
        /// do not have an API based on a discovery document, such as Cloud Bigtable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discoveryDocumentUri")]
        public virtual string DiscoveryDocumentUri { get; set; }

        /// <summary>
        /// The JSON schema name listed in the discovery document. Example: `Project` This value is unspecified for
        /// resources that do not have an API based on a discovery document, such as Cloud Bigtable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discoveryName")]
        public virtual string DiscoveryName { get; set; }

        /// <summary>
        /// The location of the resource in Google Cloud, such as its zone and region. For more information, see
        /// https://cloud.google.com/about/locations/.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// The full name of the immediate parent of this resource. See [Resource
        /// Names](https://cloud.google.com/apis/design/resource_names#full_resource_name) for more information. For
        /// Google Cloud assets, this value is the parent resource defined in the [Cloud IAM policy
        /// hierarchy](https://cloud.google.com/iam/docs/overview#policy_hierarchy). Example:
        /// `//cloudresourcemanager.googleapis.com/projects/my_project_123` For third-party assets, this field may be
        /// set differently.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// The REST URL for accessing the resource. An HTTP `GET` request using this URL returns the resource itself.
        /// Example: `https://cloudresourcemanager.googleapis.com/v1/projects/my-project-123` This value is unspecified
        /// for resources without a REST API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUrl")]
        public virtual string ResourceUrl { get; set; }

        /// <summary>The API version. Example: `v1`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A result of Resource Search, containing information of a cloud resource.</summary>
    public class ResourceSearchResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The additional searchable attributes of this resource. The attributes may vary from one resource type to
        /// another. Examples: `projectId` for Project, `dnsName` for DNS ManagedZone. This field contains a subset of
        /// the resource metadata fields that are returned by the List or Get APIs provided by the corresponding GCP
        /// service (e.g., Compute Engine). see [API references and supported searchable
        /// attributes](https://cloud.google.com/asset-inventory/docs/supported-asset-types#searchable_asset_types) to
        /// see which fields are included. You can search values of these fields through free text search. However, you
        /// should not consume the field programically as the field names and values may change as the GCP service
        /// updates to a new incompatible API version. To search against the `additional_attributes`: * use a free text
        /// query to match the attributes values. Example: to search `additional_attributes = { dnsName: "foobar" }`,
        /// you can issue a query `foobar`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalAttributes")]
        public virtual System.Collections.Generic.IDictionary<string, object> AdditionalAttributes { get; set; }

        /// <summary>
        /// The type of this resource. Example: `compute.googleapis.com/Disk`. To search against the `asset_type`: *
        /// specify the `asset_type` field in your search request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetType")]
        public virtual string AssetType { get; set; }

        /// <summary>
        /// Attached resources of this resource. For example, an OSConfig Inventory is an attached resource of a Compute
        /// Instance. This field is repeated because a resource could have multiple attached resources. This
        /// `attached_resources` field is not searchable. Some attributes of the attached resources are exposed in
        /// `additional_attributes` field, so as to allow users to search on them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachedResources")]
        public virtual System.Collections.Generic.IList<AttachedResource> AttachedResources { get; set; }

        /// <summary>
        /// The create timestamp of this resource, at which the resource was created. The granularity is in seconds.
        /// Timestamp.nanos will always be 0. This field is available only when the resource's proto contains it. To
        /// search against `create_time`: * use a field query. - value in seconds since unix epoch. Example: `createTime
        /// &amp;gt; 1609459200` - value in date string. Example: `createTime &amp;gt; 2021-01-01` - value in date-time
        /// string (must be quoted). Example: `createTime &amp;gt; "2021-01-01T00:00:00"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// One or more paragraphs of text description of this resource. Maximum length could be up to 1M bytes. This
        /// field is available only when the resource's proto contains it. To search against the `description`: * use a
        /// field query. Example: `description:"important instance"` * use a free text query. Example: `"important
        /// instance"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The display name of this resource. This field is available only when the resource's proto contains it. To
        /// search against the `display_name`: * use a field query. Example: `displayName:"My Instance"` * use a free
        /// text query. Example: `"My Instance"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The folder(s) that this resource belongs to, in the form of folders/{FOLDER_NUMBER}. This field is available
        /// when the resource belongs to one or more folders. To search against `folders`: * use a field query. Example:
        /// `folders:(123 OR 456)` * use a free text query. Example: `123` * specify the `scope` field as this folder in
        /// your search request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folders")]
        public virtual System.Collections.Generic.IList<string> Folders { get; set; }

        /// <summary>
        /// The Cloud KMS
        /// [CryptoKey](https://cloud.google.com/kms/docs/reference/rest/v1/projects.locations.keyRings.cryptoKeys?hl=en)
        /// name or
        /// [CryptoKeyVersion](https://cloud.google.com/kms/docs/reference/rest/v1/projects.locations.keyRings.cryptoKeys.cryptoKeyVersions?hl=en)
        /// name. This field is available only when the resource's proto contains it. To search against the `kms_key`: *
        /// use a field query. Example: `kmsKey:key` * use a free text query. Example: `key`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKey")]
        public virtual string KmsKey { get; set; }

        /// <summary>
        /// Labels associated with this resource. See [Labelling and grouping GCP
        /// resources](https://cloud.google.com/blog/products/gcp/labelling-and-grouping-your-google-cloud-platform-resources)
        /// for more information. This field is available only when the resource's proto contains it. To search against
        /// the `labels`: * use a field query: - query on any label's key or value. Example: `labels:prod` - query by a
        /// given label. Example: `labels.env:prod` - query by a given label's existence. Example: `labels.env:*` * use
        /// a free text query. Example: `prod`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Location can be `global`, regional like `us-east1`, or zonal like `us-west1-b`. This field is available only
        /// when the resource's proto contains it. To search against the `location`: * use a field query. Example:
        /// `location:us-west*` * use a free text query. Example: `us-west*`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// The full resource name of this resource. Example:
        /// `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1`. See [Cloud Asset
        /// Inventory Resource Name Format](https://cloud.google.com/asset-inventory/docs/resource-name-format) for more
        /// information. To search against the `name`: * use a field query. Example: `name:instance1` * use a free text
        /// query. Example: `instance1`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Network tags associated with this resource. Like labels, network tags are a type of annotations used to
        /// group GCP resources. See [Labelling GCP
        /// resources](https://cloud.google.com/blog/products/gcp/labelling-and-grouping-your-google-cloud-platform-resources)
        /// for more information. This field is available only when the resource's proto contains it. To search against
        /// the `network_tags`: * use a field query. Example: `networkTags:internal` * use a free text query. Example:
        /// `internal`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkTags")]
        public virtual System.Collections.Generic.IList<string> NetworkTags { get; set; }

        /// <summary>
        /// The organization that this resource belongs to, in the form of organizations/{ORGANIZATION_NUMBER}. This
        /// field is available when the resource belongs to an organization. To search against `organization`: * use a
        /// field query. Example: `organization:123` * use a free text query. Example: `123` * specify the `scope` field
        /// as this organization in your search request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual string Organization { get; set; }

        /// <summary>
        /// The type of this resource's immediate parent, if there is one. To search against the `parent_asset_type`: *
        /// use a field query. Example: `parentAssetType:"cloudresourcemanager.googleapis.com/Project"` * use a free
        /// text query. Example: `cloudresourcemanager.googleapis.com/Project`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentAssetType")]
        public virtual string ParentAssetType { get; set; }

        /// <summary>
        /// The full resource name of this resource's parent, if it has one. To search against the
        /// `parent_full_resource_name`: * use a field query. Example: `parentFullResourceName:"project-name"` * use a
        /// free text query. Example: `project-name`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentFullResourceName")]
        public virtual string ParentFullResourceName { get; set; }

        /// <summary>
        /// The project that this resource belongs to, in the form of projects/{PROJECT_NUMBER}. This field is available
        /// when the resource belongs to a project. To search against `project`: * use a field query. Example:
        /// `project:12345` * use a free text query. Example: `12345` * specify the `scope` field as this project in
        /// your search request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>
        /// The state of this resource. Different resources types have different state definitions that are mapped from
        /// various fields of different resource types. This field is available only when the resource's proto contains
        /// it. Example: If the resource is an instance provided by Compute Engine, its state will include PROVISIONING,
        /// STAGING, RUNNING, STOPPING, SUSPENDING, SUSPENDED, REPAIRING, and TERMINATED. See `status` definition in
        /// [API Reference](https://cloud.google.com/compute/docs/reference/rest/v1/instances). If the resource is a
        /// project provided by Cloud Resource Manager, its state will include LIFECYCLE_STATE_UNSPECIFIED, ACTIVE,
        /// DELETE_REQUESTED and DELETE_IN_PROGRESS. See `lifecycleState` definition in [API
        /// Reference](https://cloud.google.com/resource-manager/reference/rest/v1/projects). To search against the
        /// `state`: * use a field query. Example: `state:RUNNING` * use a free text query. Example: `RUNNING`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// The last update timestamp of this resource, at which the resource was last modified or deleted. The
        /// granularity is in seconds. Timestamp.nanos will always be 0. This field is available only when the
        /// resource's proto contains it. To search against `update_time`: * use a field query. - value in seconds since
        /// unix epoch. Example: `updateTime &amp;lt; 1609459200` - value in date string. Example: `updateTime &amp;lt;
        /// 2021-01-01` - value in date-time string (must be quoted). Example: `updateTime &amp;lt;
        /// "2021-01-01T00:00:00"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>
        /// Versioned resource representations of this resource. This is repeated because there could be multiple
        /// versions of resource representations during version migration. This `versioned_resources` field is not
        /// searchable. Some attributes of the resource representations are exposed in `additional_attributes` field, so
        /// as to allow users to search on them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionedResources")]
        public virtual System.Collections.Generic.IList<VersionedResource> VersionedResources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies the resource to analyze for access policies, which may be set directly on the resource, or on
    /// ancestors such as organizations, folders or projects.
    /// </summary>
    public class ResourceSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The [full resource name] (https://cloud.google.com/asset-inventory/docs/resource-name-format) of a
        /// resource of [supported resource
        /// types](https://cloud.google.com/asset-inventory/docs/supported-asset-types#analyzable_asset_types).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Search all IAM policies response.</summary>
    public class SearchAllIamPoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Set if there are more results than those appearing in this response; to get the next set of results, call
        /// this method again, using this value as the `page_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// A list of IamPolicy that match the search query. Related information such as the associated resource is
        /// returned along with the policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<IamPolicySearchResult> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Search all resources response.</summary>
    public class SearchAllResourcesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If there are more results than those appearing in this response, then `next_page_token` is included. To get
        /// the next set of results, call this method again using the value of `next_page_token` as `page_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// A list of Resources that match the search query. It contains the resource standard metadata information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<ResourceSearchResult> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Software package information of the operating system.</summary>
    public class SoftwarePackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Details of an APT package. For details about the apt package manager, see https://wiki.debian.org/Apt.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aptPackage")]
        public virtual VersionedPackage AptPackage { get; set; }

        /// <summary>Details of a COS package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cosPackage")]
        public virtual VersionedPackage CosPackage { get; set; }

        /// <summary>
        /// Details of a Googet package. For details about the googet package manager, see
        /// https://github.com/google/googet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googetPackage")]
        public virtual VersionedPackage GoogetPackage { get; set; }

        /// <summary>
        /// Details of a Windows Quick Fix engineering package. See
        /// https://docs.microsoft.com/en-us/windows/win32/cimwin32prov/win32-quickfixengineering for info in Windows
        /// Quick Fix Engineering.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("qfePackage")]
        public virtual WindowsQuickFixEngineeringPackage QfePackage { get; set; }

        /// <summary>
        /// Details of a Windows Update package. See https://docs.microsoft.com/en-us/windows/win32/api/_wua/ for
        /// information about Windows Update.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wuaPackage")]
        public virtual WindowsUpdatePackage WuaPackage { get; set; }

        /// <summary>
        /// Yum package info. For details about the yum package manager, see
        /// https://access.redhat.com/documentation/en-us/red_hat_enterprise_linux/6/html/deployment_guide/ch-yum.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yumPackage")]
        public virtual VersionedPackage YumPackage { get; set; }

        /// <summary>
        /// Details of a Zypper package. For details about the Zypper package manager, see
        /// https://en.opensuse.org/SDB:Zypper_manual.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zypperPackage")]
        public virtual VersionedPackage ZypperPackage { get; set; }

        /// <summary>
        /// Details of a Zypper patch. For details about the Zypper package manager, see
        /// https://en.opensuse.org/SDB:Zypper_manual.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zypperPatch")]
        public virtual ZypperPatch ZypperPatch { get; set; }

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
    /// An asset in Google Cloud and its temporal metadata, including the time window when it was observed and its
    /// status during that window.
    /// </summary>
    public class TemporalAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An asset in Google Cloud.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public virtual Asset Asset { get; set; }

        /// <summary>Whether the asset has been deleted or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleted")]
        public virtual System.Nullable<bool> Deleted { get; set; }

        /// <summary>
        /// Prior copy of the asset. Populated if prior_asset_state is PRESENT. Currently this is only set for responses
        /// in Real-Time Feed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priorAsset")]
        public virtual Asset PriorAsset { get; set; }

        /// <summary>State of prior_asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priorAssetState")]
        public virtual string PriorAssetState { get; set; }

        /// <summary>The time window when the asset data and state was observed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("window")]
        public virtual TimeWindow Window { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A time window specified by its `start_time` and `end_time`.</summary>
    public class TimeWindow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// End time of the time window (inclusive). If not specified, the current timestamp is used instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Start time of the time window (exclusive).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Update asset feed request.</summary>
    public class UpdateFeedRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The new values of feed details. It must match an existing feed and the field `name` must be in the
        /// format of: projects/project_number/feeds/feed_id or folders/folder_number/feeds/feed_id or
        /// organizations/organization_number/feeds/feed_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feed")]
        public virtual Feed Feed { get; set; }

        /// <summary>
        /// Required. Only updates the `feed` fields indicated by this mask. The field mask must not be empty, and it
        /// must not contain fields that are immutable or only set by the server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information related to the a standard versioned package. This includes package info for APT, Yum, Zypper, and
    /// Googet package managers.
    /// </summary>
    public class VersionedPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The system architecture this package is intended for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("architecture")]
        public virtual string Architecture { get; set; }

        /// <summary>The name of the package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>The version of the package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Resource representation as defined by the corresponding service providing the resource for a given API version.
    /// </summary>
    public class VersionedResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// JSON representation of the resource as defined by the corresponding service providing this resource.
        /// Example: If the resource is an instance provided by Compute Engine, this field will contain the JSON
        /// representation of the instance as defined by Compute Engine:
        /// `https://cloud.google.com/compute/docs/reference/rest/v1/instances`. You can find the resource definition
        /// for each supported resource type in this table:
        /// `https://cloud.google.com/asset-inventory/docs/supported-asset-types#searchable_asset_types`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual System.Collections.Generic.IDictionary<string, object> Resource { get; set; }

        /// <summary>
        /// API version of the resource. Example: If the resource is an instance provided by Compute Engine v1 API as
        /// defined in `https://cloud.google.com/compute/docs/reference/rest/v1/instances`, version will be "v1".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information related to a Quick Fix Engineering package. Fields are taken from Windows QuickFixEngineering
    /// Interface and match the source names:
    /// https://docs.microsoft.com/en-us/windows/win32/cimwin32prov/win32-quickfixengineering
    /// </summary>
    public class WindowsQuickFixEngineeringPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A short textual description of the QFE update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caption")]
        public virtual string Caption { get; set; }

        /// <summary>A textual description of the QFE update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Unique identifier associated with a particular QFE update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hotFixId")]
        public virtual string HotFixId { get; set; }

        /// <summary>Date that the QFE update was installed. Mapped from installed_on field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installTime")]
        public virtual object InstallTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Categories specified by the Windows Update.</summary>
    public class WindowsUpdateCategory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The identifier of the windows update category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The name of the windows update category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details related to a Windows Update package. Field data and names are taken from Windows Update API IUpdate
    /// Interface: https://docs.microsoft.com/en-us/windows/win32/api/_wua/ Descriptive fields like title, and
    /// description are localized based on the locale of the VM being updated.
    /// </summary>
    public class WindowsUpdatePackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The categories that are associated with this update package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual System.Collections.Generic.IList<WindowsUpdateCategory> Categories { get; set; }

        /// <summary>The localized description of the update package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// A collection of Microsoft Knowledge Base article IDs that are associated with the update package.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kbArticleIds")]
        public virtual System.Collections.Generic.IList<string> KbArticleIds { get; set; }

        /// <summary>The last published date of the update, in (UTC) date and time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastDeploymentChangeTime")]
        public virtual object LastDeploymentChangeTime { get; set; }

        /// <summary>A collection of URLs that provide more information about the update package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moreInfoUrls")]
        public virtual System.Collections.Generic.IList<string> MoreInfoUrls { get; set; }

        /// <summary>The revision number of this update package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionNumber")]
        public virtual System.Nullable<int> RevisionNumber { get; set; }

        /// <summary>A hyperlink to the language-specific support information for the update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportUrl")]
        public virtual string SupportUrl { get; set; }

        /// <summary>The localized title of the update package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>Gets the identifier of an update package. Stays the same across revisions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateId")]
        public virtual string UpdateId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details related to a Zypper Patch.</summary>
    public class ZypperPatch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The category of the patch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>The name of the patch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("patchName")]
        public virtual string PatchName { get; set; }

        /// <summary>The severity specified for this patch</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>Any summary information provided about this patch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summary")]
        public virtual string Summary { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
