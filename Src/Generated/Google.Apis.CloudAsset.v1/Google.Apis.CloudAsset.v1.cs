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
            EffectiveIamPolicies = new EffectiveIamPoliciesResource(this);
            Feeds = new FeedsResource(this);
            Operations = new OperationsResource(this);
            SavedQueries = new SavedQueriesResource(this);
            V1 = new V1Resource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://cloudasset.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://cloudasset.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudasset";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Asset API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Asset API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Assets resource.</summary>
        public virtual AssetsResource Assets { get; }

        /// <summary>Gets the EffectiveIamPolicies resource.</summary>
        public virtual EffectiveIamPoliciesResource EffectiveIamPolicies { get; }

        /// <summary>Gets the Feeds resource.</summary>
        public virtual FeedsResource Feeds { get; }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the SavedQueries resource.</summary>
        public virtual SavedQueriesResource SavedQueries { get; }

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
        /// Required. Name of the organization, folder, or project the assets belong to. Format:
        /// "organizations/[organization-number]" (such as "organizations/123"), "projects/[project-id]" (such as
        /// "projects/my-project-id"), "projects/[project-number]" (such as "projects/12345"), or
        /// "folders/[folder-number]" (such as "folders/12345").
        /// </param>
        public virtual ListRequest List(string parent)
        {
            return new ListRequest(this.service, parent);
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
            /// Required. Name of the organization, folder, or project the assets belong to. Format:
            /// "organizations/[organization-number]" (such as "organizations/123"), "projects/[project-id]" (such as
            /// "projects/my-project-id"), "projects/[project-number]" (such as "projects/12345"), or
            /// "folders/[folder-number]" (such as "folders/12345").
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

                /// <summary>The organization policy set on an asset.</summary>
                [Google.Apis.Util.StringValueAttribute("ORG_POLICY")]
                ORGPOLICY = 3,

                /// <summary>The Access Context Manager policy set on an asset.</summary>
                [Google.Apis.Util.StringValueAttribute("ACCESS_POLICY")]
                ACCESSPOLICY = 4,

                /// <summary>The runtime OS Inventory information.</summary>
                [Google.Apis.Util.StringValueAttribute("OS_INVENTORY")]
                OSINVENTORY = 5,

                /// <summary>The related resources.</summary>
                [Google.Apis.Util.StringValueAttribute("RELATIONSHIP")]
                RELATIONSHIP = 6,
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

            private object _readTime;

            /// <summary>
            /// String representation of <see cref="ReadTimeDateTimeOffset"/>, formatted for inclusion in the HTTP
            /// request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("readTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ReadTimeRaw { get; private set; }

            /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeRaw"/>.</summary>
            [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeDateTimeOffset instead.")]
            public virtual object ReadTime
            {
                get => _readTime;
                set
                {
                    ReadTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                    _readTime = value;
                }
            }

            public virtual System.DateTimeOffset? ReadTimeDateTimeOffset
            {
                get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReadTimeRaw);
                set
                {
                    ReadTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                    _readTime = value;
                }
            }

            /// <summary>
            /// A list of relationship types to output, for example: `INSTANCE_TO_INSTANCEGROUP`. This field should only
            /// be specified if content_type=RELATIONSHIP. * If specified: it snapshots specified relationships. It
            /// returns an error if any of the [relationship_types] doesn't belong to the supported relationship types
            /// of the [asset_types] or if any of the [asset_types] doesn't belong to the source types of the
            /// [relationship_types]. * Otherwise: it snapshots the supported relationships for all [asset_types] or
            /// returns an error if any of the [asset_types] has no relationship support. An unspecified asset types
            /// field means all supported asset_types. See [Introduction to Cloud Asset
            /// Inventory](https://cloud.google.com/asset-inventory/docs/overview) for all supported asset types and
            /// relationship types.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("relationshipTypes", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> RelationshipTypes { get; set; }

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
                RequestParameters.Add("relationshipTypes", new Google.Apis.Discovery.Parameter
                {
                    Name = "relationshipTypes",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "effectiveIamPolicies" collection of methods.</summary>
    public class EffectiveIamPoliciesResource
    {
        private const string Resource = "effectiveIamPolicies";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public EffectiveIamPoliciesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets effective IAM policies for a batch of resources.</summary>
        /// <param name="scope">
        /// Required. Only IAM policies on or below the scope will be returned. This can only be an organization number
        /// (such as "organizations/123"), a folder number (such as "folders/123"), a project ID (such as
        /// "projects/my-project-id"), or a project number (such as "projects/12345"). To know how to get organization
        /// ID, visit [here
        /// ](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).
        /// To know how to get folder or project ID, visit [here
        /// ](https://cloud.google.com/resource-manager/docs/creating-managing-folders#viewing_or_listing_folders_and_projects).
        /// </param>
        public virtual BatchGetRequest BatchGet(string scope)
        {
            return new BatchGetRequest(this.service, scope);
        }

        /// <summary>Gets effective IAM policies for a batch of resources.</summary>
        public class BatchGetRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.BatchGetEffectiveIamPoliciesResponse>
        {
            /// <summary>Constructs a new BatchGet request.</summary>
            public BatchGetRequest(Google.Apis.Services.IClientService service, string scope) : base(service)
            {
                Scope = scope;
                InitParameters();
            }

            /// <summary>
            /// Required. Only IAM policies on or below the scope will be returned. This can only be an organization
            /// number (such as "organizations/123"), a folder number (such as "folders/123"), a project ID (such as
            /// "projects/my-project-id"), or a project number (such as "projects/12345"). To know how to get
            /// organization ID, visit [here
            /// ](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).
            /// To know how to get folder or project ID, visit [here
            /// ](https://cloud.google.com/resource-manager/docs/creating-managing-folders#viewing_or_listing_folders_and_projects).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("scope", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Scope { get; private set; }

            /// <summary>
            /// Required. The names refer to the [full_resource_names]
            /// (https://cloud.google.com/asset-inventory/docs/resource-name-format) of the asset types [supported by
            /// search APIs](https://cloud.google.com/asset-inventory/docs/supported-asset-types). A maximum of 20
            /// resources' effective policies can be retrieved in a batch.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("names", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Names { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "batchGet";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+scope}/effectiveIamPolicies:batchGet";

            /// <summary>Initializes BatchGet parameter list.</summary>
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
                RequestParameters.Add("names", new Google.Apis.Discovery.Parameter
                {
                    Name = "names",
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
        /// (such as "projects/my-project-id"), or a project number (such as "projects/12345").
        /// </param>
        public virtual CreateRequest Create(Google.Apis.CloudAsset.v1.Data.CreateFeedRequest body, string parent)
        {
            return new CreateRequest(this.service, body, parent);
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
            /// project ID (such as "projects/my-project-id"), or a project number (such as "projects/12345").
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
            return new DeleteRequest(this.service, name);
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
            return new GetRequest(this.service, name);
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
            return new ListRequest(this.service, parent);
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
            return new PatchRequest(this.service, body, name);
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
            return new GetRequest(this.service, name);
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

    /// <summary>The "savedQueries" collection of methods.</summary>
    public class SavedQueriesResource
    {
        private const string Resource = "savedQueries";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SavedQueriesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Creates a saved query in a parent project/folder/organization.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. The name of the project/folder/organization where this saved_query should be created in. It can
        /// only be an organization number (such as "organizations/123"), a folder number (such as "folders/123"), a
        /// project ID (such as "projects/my-project-id"), or a project number (such as "projects/12345").
        /// </param>
        public virtual CreateRequest Create(Google.Apis.CloudAsset.v1.Data.SavedQuery body, string parent)
        {
            return new CreateRequest(this.service, body, parent);
        }

        /// <summary>Creates a saved query in a parent project/folder/organization.</summary>
        public class CreateRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.SavedQuery>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAsset.v1.Data.SavedQuery body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the project/folder/organization where this saved_query should be created in. It
            /// can only be an organization number (such as "organizations/123"), a folder number (such as
            /// "folders/123"), a project ID (such as "projects/my-project-id"), or a project number (such as
            /// "projects/12345").
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// Required. The ID to use for the saved query, which must be unique in the specified parent. It will
            /// become the final component of the saved query's resource name. This value should be 4-63 characters, and
            /// valid characters are `a-z-`. Notice that this field is required in the saved query creation, and the
            /// `name` field of the `saved_query` will be ignored.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("savedQueryId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string SavedQueryId { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudAsset.v1.Data.SavedQuery Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}/savedQueries";

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
                RequestParameters.Add("savedQueryId", new Google.Apis.Discovery.Parameter
                {
                    Name = "savedQueryId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Deletes a saved query.</summary>
        /// <param name="name">
        /// Required. The name of the saved query to delete. It must be in the format of: *
        /// projects/project_number/savedQueries/saved_query_id * folders/folder_number/savedQueries/saved_query_id *
        /// organizations/organization_number/savedQueries/saved_query_id
        /// </param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(this.service, name);
        }

        /// <summary>Deletes a saved query.</summary>
        public class DeleteRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the saved query to delete. It must be in the format of: *
            /// projects/project_number/savedQueries/saved_query_id * folders/folder_number/savedQueries/saved_query_id
            /// * organizations/organization_number/savedQueries/saved_query_id
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
                    Pattern = @"^[^/]+/[^/]+/savedQueries/[^/]+$",
                });
            }
        }

        /// <summary>Gets details about a saved query.</summary>
        /// <param name="name">
        /// Required. The name of the saved query and it must be in the format of: *
        /// projects/project_number/savedQueries/saved_query_id * folders/folder_number/savedQueries/saved_query_id *
        /// organizations/organization_number/savedQueries/saved_query_id
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>Gets details about a saved query.</summary>
        public class GetRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.SavedQuery>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the saved query and it must be in the format of: *
            /// projects/project_number/savedQueries/saved_query_id * folders/folder_number/savedQueries/saved_query_id
            /// * organizations/organization_number/savedQueries/saved_query_id
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
                    Pattern = @"^[^/]+/[^/]+/savedQueries/[^/]+$",
                });
            }
        }

        /// <summary>Lists all saved queries in a parent project/folder/organization.</summary>
        /// <param name="parent">
        /// Required. The parent project/folder/organization whose savedQueries are to be listed. It can only be using
        /// project/folder/organization number (such as "folders/12345")", or a project ID (such as
        /// "projects/my-project-id").
        /// </param>
        public virtual ListRequest List(string parent)
        {
            return new ListRequest(this.service, parent);
        }

        /// <summary>Lists all saved queries in a parent project/folder/organization.</summary>
        public class ListRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.ListSavedQueriesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
            {
                Parent = parent;
                InitParameters();
            }

            /// <summary>
            /// Required. The parent project/folder/organization whose savedQueries are to be listed. It can only be
            /// using project/folder/organization number (such as "folders/12345")", or a project ID (such as
            /// "projects/my-project-id").
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// Optional. The expression to filter resources. The expression is a list of zero or more restrictions
            /// combined via logical operators `AND` and `OR`. When `AND` and `OR` are both used in the expression,
            /// parentheses must be appropriately used to group the combinations. The expression may also contain
            /// regular expressions. See https://google.aip.dev/160 for more information on the grammar.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// Optional. The maximum number of saved queries to return per page. The service may return fewer than this
            /// value. If unspecified, at most 50 will be returned. The maximum value is 1000; values above 1000 will be
            /// coerced to 1000.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A page token, received from a previous `ListSavedQueries` call. Provide this to retrieve the
            /// subsequent page. When paginating, all other parameters provided to `ListSavedQueries` must match the
            /// call that provided the page token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}/savedQueries";

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

        /// <summary>Updates a saved query.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the saved query. The format must be: *
        /// projects/project_number/savedQueries/saved_query_id * folders/folder_number/savedQueries/saved_query_id *
        /// organizations/organization_number/savedQueries/saved_query_id
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.CloudAsset.v1.Data.SavedQuery body, string name)
        {
            return new PatchRequest(this.service, body, name);
        }

        /// <summary>Updates a saved query.</summary>
        public class PatchRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.SavedQuery>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAsset.v1.Data.SavedQuery body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the saved query. The format must be: *
            /// projects/project_number/savedQueries/saved_query_id * folders/folder_number/savedQueries/saved_query_id
            /// * organizations/organization_number/savedQueries/saved_query_id
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Required. The list of fields to update.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudAsset.v1.Data.SavedQuery Body { get; set; }

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
                    Pattern = @"^[^/]+/[^/]+/savedQueries/[^/]+$",
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
        /// "projects/12345"). To know how to get organization ID, visit [here
        /// ](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).
        /// To know how to get folder or project ID, visit [here
        /// ](https://cloud.google.com/resource-manager/docs/creating-managing-folders#viewing_or_listing_folders_and_projects).
        /// </param>
        public virtual AnalyzeIamPolicyRequest AnalyzeIamPolicy(string scope)
        {
            return new AnalyzeIamPolicyRequest(this.service, scope);
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
            /// "projects/12345"). To know how to get organization ID, visit [here
            /// ](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).
            /// To know how to get folder or project ID, visit [here
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

            private object _analysisQueryConditionContextAccessTime;

            /// <summary>
            /// String representation of <see cref="AnalysisQueryConditionContextAccessTimeDateTimeOffset"/>, formatted
            /// for inclusion in the HTTP request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("analysisQuery.conditionContext.accessTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string AnalysisQueryConditionContextAccessTimeRaw { get; private set; }

            /// <summary>
            /// <seealso cref="object"/> representation of <see cref="AnalysisQueryConditionContextAccessTimeRaw"/>.
            /// </summary>
            [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use AnalysisQueryConditionContextAccessTimeDateTimeOffset instead.")]
            public virtual object AnalysisQueryConditionContextAccessTime
            {
                get => _analysisQueryConditionContextAccessTime;
                set
                {
                    AnalysisQueryConditionContextAccessTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                    _analysisQueryConditionContextAccessTime = value;
                }
            }

            public virtual System.DateTimeOffset? AnalysisQueryConditionContextAccessTimeDateTimeOffset
            {
                get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(AnalysisQueryConditionContextAccessTimeRaw);
                set
                {
                    AnalysisQueryConditionContextAccessTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                    _analysisQueryConditionContextAccessTime = value;
                }
            }

            /// <summary>
            /// Required. The identity appear in the form of principals in [IAM policy
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
            /// executed. We highly recommend you use AssetService.AnalyzeIamPolicyLongrunning RPC instead. For example,
            /// if the request analyzes for which resources user A has permission P, and there's an IAM policy states
            /// user A has iam.serviceAccounts.getAccessToken permission to a service account SA, and there's another
            /// IAM policy states service account SA has permission P to a Google Cloud folder F, then user A
            /// potentially has access to the Google Cloud folder F. And those advanced analysis results will be
            /// included in AnalyzeIamPolicyResponse.service_account_impersonation_analysis. Another example, if the
            /// request analyzes for who has permission P to a Google Cloud folder F, and there's an IAM policy states
            /// user A has iam.serviceAccounts.actAs permission to a service account SA, and there's another IAM policy
            /// states service account SA has permission P to the Google Cloud folder F, then user A potentially has
            /// access to the Google Cloud folder F. And those advanced analysis results will be included in
            /// AnalyzeIamPolicyResponse.service_account_impersonation_analysis. Only the following permissions are
            /// considered in this analysis: * `iam.serviceAccounts.actAs` * `iam.serviceAccounts.signBlob` *
            /// `iam.serviceAccounts.signJwt` * `iam.serviceAccounts.getAccessToken` *
            /// `iam.serviceAccounts.getOpenIdToken` * `iam.serviceAccounts.implicitDelegation` Default is false.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("analysisQuery.options.analyzeServiceAccountImpersonation", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AnalysisQueryOptionsAnalyzeServiceAccountImpersonation { get; set; }

            /// <summary>
            /// Optional. If true, the identities section of the result will expand any Google groups appearing in an
            /// IAM policy binding. If IamPolicyAnalysisQuery.identity_selector is specified, the identity in the result
            /// will be determined by the selector, and this flag is not allowed to set. If true, the default max
            /// expansion per group is 1000 for AssetService.AnalyzeIamPolicy][]. Default is false.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("analysisQuery.options.expandGroups", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AnalysisQueryOptionsExpandGroups { get; set; }

            /// <summary>
            /// Optional. If true and IamPolicyAnalysisQuery.resource_selector is not specified, the resource section of
            /// the result will expand any resource attached to an IAM policy to include resources lower in the resource
            /// hierarchy. For example, if the request analyzes for which resources user A has permission P, and the
            /// results include an IAM policy with P on a Google Cloud folder, the results will also include resources
            /// in that folder with permission P. If true and IamPolicyAnalysisQuery.resource_selector is specified, the
            /// resource section of the result will expand the specified resource to include resources lower in the
            /// resource hierarchy. Only project or lower resources are supported. Folder and organization resources
            /// cannot be used together with this option. For example, if the request analyzes for which users have
            /// permission P on a Google Cloud project with this option enabled, the results will include all users who
            /// have permission P on that project or any lower resource. If true, the default max expansion per resource
            /// is 1000 for AssetService.AnalyzeIamPolicy][] and 100000 for AssetService.AnalyzeIamPolicyLongrunning][].
            /// Default is false.
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
            /// Optional. If true, the result will output the relevant membership relationships between groups and other
            /// groups, and between groups and principals. Default is false.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("analysisQuery.options.outputGroupEdges", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AnalysisQueryOptionsOutputGroupEdges { get; set; }

            /// <summary>
            /// Optional. If true, the result will output the relevant parent/child relationships between resources.
            /// Default is false.
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

            /// <summary>
            /// Optional. The name of a saved query, which must be in the format of: *
            /// projects/project_number/savedQueries/saved_query_id * folders/folder_number/savedQueries/saved_query_id
            /// * organizations/organization_number/savedQueries/saved_query_id If both `analysis_query` and
            /// `saved_analysis_query` are provided, they will be merged together with the `saved_analysis_query` as
            /// base and the `analysis_query` as overrides. For more details of the merge behavior, refer to the
            /// [MergeFrom](https://developers.google.com/protocol-buffers/docs/reference/cpp/google.protobuf.message#Message.MergeFrom.details)
            /// page. Note that you cannot override primitive fields with default value, such as 0 or empty string,
            /// etc., because we use proto3, which doesn't support field presence yet.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("savedAnalysisQuery", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string SavedAnalysisQuery { get; set; }

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
                RequestParameters.Add("savedAnalysisQuery", new Google.Apis.Discovery.Parameter
                {
                    Name = "savedAnalysisQuery",
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
        /// contains the metadata for the long-running operation.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="scope">
        /// Required. The relative name of the root asset. Only resources and IAM policies within the scope will be
        /// analyzed. This can only be an organization number (such as "organizations/123"), a folder number (such as
        /// "folders/123"), a project ID (such as "projects/my-project-id"), or a project number (such as
        /// "projects/12345"). To know how to get organization ID, visit [here
        /// ](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).
        /// To know how to get folder or project ID, visit [here
        /// ](https://cloud.google.com/resource-manager/docs/creating-managing-folders#viewing_or_listing_folders_and_projects).
        /// </param>
        public virtual AnalyzeIamPolicyLongrunningRequest AnalyzeIamPolicyLongrunning(Google.Apis.CloudAsset.v1.Data.AnalyzeIamPolicyLongrunningRequest body, string scope)
        {
            return new AnalyzeIamPolicyLongrunningRequest(this.service, body, scope);
        }

        /// <summary>
        /// Analyzes IAM policies asynchronously to answer which identities have what accesses on which resources, and
        /// writes the analysis results to a Google Cloud Storage or a BigQuery destination. For Cloud Storage
        /// destination, the output format is the JSON format that represents a AnalyzeIamPolicyResponse. This method
        /// implements the google.longrunning.Operation, which allows you to track the operation status. We recommend
        /// intervals of at least 2 seconds with exponential backoff retry to poll the operation result. The metadata
        /// contains the metadata for the long-running operation.
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
            /// "projects/12345"). To know how to get organization ID, visit [here
            /// ](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).
            /// To know how to get folder or project ID, visit [here
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
        /// Required. Name of the resource to perform the analysis against. Only Google Cloud projects are supported as
        /// of today. Hence, this can only be a project ID (such as "projects/my-project-id") or a project number (such
        /// as "projects/12345").
        /// </param>
        public virtual AnalyzeMoveRequest AnalyzeMove(string resource)
        {
            return new AnalyzeMoveRequest(this.service, resource);
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
            /// Required. Name of the resource to perform the analysis against. Only Google Cloud projects are supported
            /// as of today. Hence, this can only be a project ID (such as "projects/my-project-id") or a project number
            /// (such as "projects/12345").
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>
            /// Required. Name of the Google Cloud folder or organization to reparent the target resource. The analysis
            /// will be performed against hypothetically moving the resource to this specified destination parent. This
            /// can only be a folder number (such as "folders/123") or an organization number (such as
            /// "organizations/123").
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

        /// <summary>Analyzes organization policies under a scope.</summary>
        /// <param name="scope">
        /// Required. The organization to scope the request. Only organization policies within the scope will be
        /// analyzed. * organizations/{ORGANIZATION_NUMBER} (e.g., "organizations/123456")
        /// </param>
        public virtual AnalyzeOrgPoliciesRequest AnalyzeOrgPolicies(string scope)
        {
            return new AnalyzeOrgPoliciesRequest(this.service, scope);
        }

        /// <summary>Analyzes organization policies under a scope.</summary>
        public class AnalyzeOrgPoliciesRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.AnalyzeOrgPoliciesResponse>
        {
            /// <summary>Constructs a new AnalyzeOrgPolicies request.</summary>
            public AnalyzeOrgPoliciesRequest(Google.Apis.Services.IClientService service, string scope) : base(service)
            {
                Scope = scope;
                InitParameters();
            }

            /// <summary>
            /// Required. The organization to scope the request. Only organization policies within the scope will be
            /// analyzed. * organizations/{ORGANIZATION_NUMBER} (e.g., "organizations/123456")
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("scope", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Scope { get; private set; }

            /// <summary>
            /// Required. The name of the constraint to analyze organization policies for. The response only contains
            /// analyzed organization policies for the provided constraint.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("constraint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Constraint { get; set; }

            /// <summary>
            /// The expression to filter AnalyzeOrgPoliciesResponse.org_policy_results. Filtering is currently available
            /// for bare literal values and the following fields: * consolidated_policy.attached_resource *
            /// consolidated_policy.rules.enforce When filtering by a specific field, the only supported operator is
            /// `=`. For example, filtering by
            /// consolidated_policy.attached_resource="//cloudresourcemanager.googleapis.com/folders/001" will return
            /// all the Organization Policy results attached to "folders/001".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// The maximum number of items to return per page. If unspecified,
            /// AnalyzeOrgPoliciesResponse.org_policy_results will contain 20 items with a maximum of 200.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>The pagination token to retrieve the next page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "analyzeOrgPolicies";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+scope}:analyzeOrgPolicies";

            /// <summary>Initializes AnalyzeOrgPolicies parameter list.</summary>
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
                RequestParameters.Add("constraint", new Google.Apis.Discovery.Parameter
                {
                    Name = "constraint",
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
        /// Analyzes organization policies governed assets (Google Cloud resources or policies) under a scope. This RPC
        /// supports custom constraints and the following canned constraints: * constraints/ainotebooks.accessMode *
        /// constraints/ainotebooks.disableFileDownloads * constraints/ainotebooks.disableRootAccess *
        /// constraints/ainotebooks.disableTerminal * constraints/ainotebooks.environmentOptions *
        /// constraints/ainotebooks.requireAutoUpgradeSchedule * constraints/ainotebooks.restrictVpcNetworks *
        /// constraints/compute.disableGuestAttributesAccess * constraints/compute.disableInstanceDataAccessApis *
        /// constraints/compute.disableNestedVirtualization * constraints/compute.disableSerialPortAccess *
        /// constraints/compute.disableSerialPortLogging * constraints/compute.disableVpcExternalIpv6 *
        /// constraints/compute.requireOsLogin * constraints/compute.requireShieldedVm *
        /// constraints/compute.restrictLoadBalancerCreationForTypes *
        /// constraints/compute.restrictProtocolForwardingCreationForTypes *
        /// constraints/compute.restrictXpnProjectLienRemoval * constraints/compute.setNewProjectDefaultToZonalDNSOnly *
        /// constraints/compute.skipDefaultNetworkCreation * constraints/compute.trustedImageProjects *
        /// constraints/compute.vmCanIpForward * constraints/compute.vmExternalIpAccess *
        /// constraints/gcp.detailedAuditLoggingMode * constraints/gcp.resourceLocations *
        /// constraints/iam.allowedPolicyMemberDomains * constraints/iam.automaticIamGrantsForDefaultServiceAccounts *
        /// constraints/iam.disableServiceAccountCreation * constraints/iam.disableServiceAccountKeyCreation *
        /// constraints/iam.disableServiceAccountKeyUpload *
        /// constraints/iam.restrictCrossProjectServiceAccountLienRemoval * constraints/iam.serviceAccountKeyExpiryHours
        /// * constraints/resourcemanager.accessBoundaries * constraints/resourcemanager.allowedExportDestinations *
        /// constraints/sql.restrictAuthorizedNetworks * constraints/sql.restrictNoncompliantDiagnosticDataAccess *
        /// constraints/sql.restrictNoncompliantResourceCreation * constraints/sql.restrictPublicIp *
        /// constraints/storage.publicAccessPrevention * constraints/storage.restrictAuthTypes *
        /// constraints/storage.uniformBucketLevelAccess This RPC only returns either resources of types [supported by
        /// search APIs](https://cloud.google.com/asset-inventory/docs/supported-asset-types) or IAM policies.
        /// </summary>
        /// <param name="scope">
        /// Required. The organization to scope the request. Only organization policies within the scope will be
        /// analyzed. The output assets will also be limited to the ones governed by those in-scope organization
        /// policies. * organizations/{ORGANIZATION_NUMBER} (e.g., "organizations/123456")
        /// </param>
        public virtual AnalyzeOrgPolicyGovernedAssetsRequest AnalyzeOrgPolicyGovernedAssets(string scope)
        {
            return new AnalyzeOrgPolicyGovernedAssetsRequest(this.service, scope);
        }

        /// <summary>
        /// Analyzes organization policies governed assets (Google Cloud resources or policies) under a scope. This RPC
        /// supports custom constraints and the following canned constraints: * constraints/ainotebooks.accessMode *
        /// constraints/ainotebooks.disableFileDownloads * constraints/ainotebooks.disableRootAccess *
        /// constraints/ainotebooks.disableTerminal * constraints/ainotebooks.environmentOptions *
        /// constraints/ainotebooks.requireAutoUpgradeSchedule * constraints/ainotebooks.restrictVpcNetworks *
        /// constraints/compute.disableGuestAttributesAccess * constraints/compute.disableInstanceDataAccessApis *
        /// constraints/compute.disableNestedVirtualization * constraints/compute.disableSerialPortAccess *
        /// constraints/compute.disableSerialPortLogging * constraints/compute.disableVpcExternalIpv6 *
        /// constraints/compute.requireOsLogin * constraints/compute.requireShieldedVm *
        /// constraints/compute.restrictLoadBalancerCreationForTypes *
        /// constraints/compute.restrictProtocolForwardingCreationForTypes *
        /// constraints/compute.restrictXpnProjectLienRemoval * constraints/compute.setNewProjectDefaultToZonalDNSOnly *
        /// constraints/compute.skipDefaultNetworkCreation * constraints/compute.trustedImageProjects *
        /// constraints/compute.vmCanIpForward * constraints/compute.vmExternalIpAccess *
        /// constraints/gcp.detailedAuditLoggingMode * constraints/gcp.resourceLocations *
        /// constraints/iam.allowedPolicyMemberDomains * constraints/iam.automaticIamGrantsForDefaultServiceAccounts *
        /// constraints/iam.disableServiceAccountCreation * constraints/iam.disableServiceAccountKeyCreation *
        /// constraints/iam.disableServiceAccountKeyUpload *
        /// constraints/iam.restrictCrossProjectServiceAccountLienRemoval * constraints/iam.serviceAccountKeyExpiryHours
        /// * constraints/resourcemanager.accessBoundaries * constraints/resourcemanager.allowedExportDestinations *
        /// constraints/sql.restrictAuthorizedNetworks * constraints/sql.restrictNoncompliantDiagnosticDataAccess *
        /// constraints/sql.restrictNoncompliantResourceCreation * constraints/sql.restrictPublicIp *
        /// constraints/storage.publicAccessPrevention * constraints/storage.restrictAuthTypes *
        /// constraints/storage.uniformBucketLevelAccess This RPC only returns either resources of types [supported by
        /// search APIs](https://cloud.google.com/asset-inventory/docs/supported-asset-types) or IAM policies.
        /// </summary>
        public class AnalyzeOrgPolicyGovernedAssetsRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.AnalyzeOrgPolicyGovernedAssetsResponse>
        {
            /// <summary>Constructs a new AnalyzeOrgPolicyGovernedAssets request.</summary>
            public AnalyzeOrgPolicyGovernedAssetsRequest(Google.Apis.Services.IClientService service, string scope) : base(service)
            {
                Scope = scope;
                InitParameters();
            }

            /// <summary>
            /// Required. The organization to scope the request. Only organization policies within the scope will be
            /// analyzed. The output assets will also be limited to the ones governed by those in-scope organization
            /// policies. * organizations/{ORGANIZATION_NUMBER} (e.g., "organizations/123456")
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("scope", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Scope { get; private set; }

            /// <summary>
            /// Required. The name of the constraint to analyze governed assets for. The analysis only contains analyzed
            /// organization policies for the provided constraint.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("constraint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Constraint { get; set; }

            /// <summary>
            /// The expression to filter AnalyzeOrgPolicyGovernedAssetsResponse.governed_assets. For governed resources,
            /// filtering is currently available for bare literal values and the following fields: *
            /// governed_resource.project * governed_resource.folders * consolidated_policy.rules.enforce When filtering
            /// by `governed_resource.project` or `consolidated_policy.rules.enforce`, the only supported operator is
            /// `=`. When filtering by `governed_resource.folders`, the supported operators are `=` and `:`. For
            /// example, filtering by `governed_resource.project="projects/12345678"` will return all the governed
            /// resources under "projects/12345678", including the project itself if applicable. For governed IAM
            /// policies, filtering is currently available for bare literal values and the following fields: *
            /// governed_iam_policy.project * governed_iam_policy.folders * consolidated_policy.rules.enforce When
            /// filtering by `governed_iam_policy.project` or `consolidated_policy.rules.enforce`, the only supported
            /// operator is `=`. When filtering by `governed_iam_policy.folders`, the supported operators are `=` and
            /// `:`. For example, filtering by `governed_iam_policy.folders:"folders/12345678"` will return all the
            /// governed IAM policies under "folders/001".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// The maximum number of items to return per page. If unspecified,
            /// AnalyzeOrgPolicyGovernedAssetsResponse.governed_assets will contain 100 items with a maximum of 200.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>The pagination token to retrieve the next page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "analyzeOrgPolicyGovernedAssets";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+scope}:analyzeOrgPolicyGovernedAssets";

            /// <summary>Initializes AnalyzeOrgPolicyGovernedAssets parameter list.</summary>
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
                RequestParameters.Add("constraint", new Google.Apis.Discovery.Parameter
                {
                    Name = "constraint",
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
        /// Analyzes organization policies governed containers (projects, folders or organization) under a scope.
        /// </summary>
        /// <param name="scope">
        /// Required. The organization to scope the request. Only organization policies within the scope will be
        /// analyzed. The output containers will also be limited to the ones governed by those in-scope organization
        /// policies. * organizations/{ORGANIZATION_NUMBER} (e.g., "organizations/123456")
        /// </param>
        public virtual AnalyzeOrgPolicyGovernedContainersRequest AnalyzeOrgPolicyGovernedContainers(string scope)
        {
            return new AnalyzeOrgPolicyGovernedContainersRequest(this.service, scope);
        }

        /// <summary>
        /// Analyzes organization policies governed containers (projects, folders or organization) under a scope.
        /// </summary>
        public class AnalyzeOrgPolicyGovernedContainersRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.AnalyzeOrgPolicyGovernedContainersResponse>
        {
            /// <summary>Constructs a new AnalyzeOrgPolicyGovernedContainers request.</summary>
            public AnalyzeOrgPolicyGovernedContainersRequest(Google.Apis.Services.IClientService service, string scope) : base(service)
            {
                Scope = scope;
                InitParameters();
            }

            /// <summary>
            /// Required. The organization to scope the request. Only organization policies within the scope will be
            /// analyzed. The output containers will also be limited to the ones governed by those in-scope organization
            /// policies. * organizations/{ORGANIZATION_NUMBER} (e.g., "organizations/123456")
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("scope", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Scope { get; private set; }

            /// <summary>
            /// Required. The name of the constraint to analyze governed containers for. The analysis only contains
            /// organization policies for the provided constraint.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("constraint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Constraint { get; set; }

            /// <summary>
            /// The expression to filter AnalyzeOrgPolicyGovernedContainersResponse.governed_containers. Filtering is
            /// currently available for bare literal values and the following fields: * parent *
            /// consolidated_policy.rules.enforce When filtering by a specific field, the only supported operator is
            /// `=`. For example, filtering by parent="//cloudresourcemanager.googleapis.com/folders/001" will return
            /// all the containers under "folders/001".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// The maximum number of items to return per page. If unspecified,
            /// AnalyzeOrgPolicyGovernedContainersResponse.governed_containers will contain 100 items with a maximum of
            /// 200.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>The pagination token to retrieve the next page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "analyzeOrgPolicyGovernedContainers";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+scope}:analyzeOrgPolicyGovernedContainers";

            /// <summary>Initializes AnalyzeOrgPolicyGovernedContainers parameter list.</summary>
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
                RequestParameters.Add("constraint", new Google.Apis.Discovery.Parameter
                {
                    Name = "constraint",
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
            return new BatchGetAssetsHistoryRequest(this.service, parent);
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

                /// <summary>The organization policy set on an asset.</summary>
                [Google.Apis.Util.StringValueAttribute("ORG_POLICY")]
                ORGPOLICY = 3,

                /// <summary>The Access Context Manager policy set on an asset.</summary>
                [Google.Apis.Util.StringValueAttribute("ACCESS_POLICY")]
                ACCESSPOLICY = 4,

                /// <summary>The runtime OS Inventory information.</summary>
                [Google.Apis.Util.StringValueAttribute("OS_INVENTORY")]
                OSINVENTORY = 5,

                /// <summary>The related resources.</summary>
                [Google.Apis.Util.StringValueAttribute("RELATIONSHIP")]
                RELATIONSHIP = 6,
            }

            private object _readTimeWindowEndTime;

            /// <summary>
            /// String representation of <see cref="ReadTimeWindowEndTimeDateTimeOffset"/>, formatted for inclusion in
            /// the HTTP request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("readTimeWindow.endTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ReadTimeWindowEndTimeRaw { get; private set; }

            /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeWindowEndTimeRaw"/>.</summary>
            [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeWindowEndTimeDateTimeOffset instead.")]
            public virtual object ReadTimeWindowEndTime
            {
                get => _readTimeWindowEndTime;
                set
                {
                    ReadTimeWindowEndTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                    _readTimeWindowEndTime = value;
                }
            }

            public virtual System.DateTimeOffset? ReadTimeWindowEndTimeDateTimeOffset
            {
                get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReadTimeWindowEndTimeRaw);
                set
                {
                    ReadTimeWindowEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                    _readTimeWindowEndTime = value;
                }
            }

            private object _readTimeWindowStartTime;

            /// <summary>
            /// String representation of <see cref="ReadTimeWindowStartTimeDateTimeOffset"/>, formatted for inclusion in
            /// the HTTP request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("readTimeWindow.startTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ReadTimeWindowStartTimeRaw { get; private set; }

            /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeWindowStartTimeRaw"/>.</summary>
            [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeWindowStartTimeDateTimeOffset instead.")]
            public virtual object ReadTimeWindowStartTime
            {
                get => _readTimeWindowStartTime;
                set
                {
                    ReadTimeWindowStartTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                    _readTimeWindowStartTime = value;
                }
            }

            public virtual System.DateTimeOffset? ReadTimeWindowStartTimeDateTimeOffset
            {
                get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReadTimeWindowStartTimeRaw);
                set
                {
                    ReadTimeWindowStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                    _readTimeWindowStartTime = value;
                }
            }

            /// <summary>
            /// Optional. A list of relationship types to output, for example: `INSTANCE_TO_INSTANCEGROUP`. This field
            /// should only be specified if content_type=RELATIONSHIP. * If specified: it outputs specified
            /// relationships' history on the [asset_names]. It returns an error if any of the [relationship_types]
            /// doesn't belong to the supported relationship types of the [asset_names] or if any of the [asset_names]'s
            /// types doesn't belong to the source types of the [relationship_types]. * Otherwise: it outputs the
            /// supported relationships' history on the [asset_names] or returns an error if any of the [asset_names]'s
            /// types has no relationship support. See [Introduction to Cloud Asset
            /// Inventory](https://cloud.google.com/asset-inventory/docs/overview) for all supported asset types and
            /// relationship types.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("relationshipTypes", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> RelationshipTypes { get; set; }

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
                RequestParameters.Add("relationshipTypes", new Google.Apis.Discovery.Parameter
                {
                    Name = "relationshipTypes",
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
        /// fields in asset Protobuf as columns. This API implements the google.longrunning.Operation API, which allows
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
            return new ExportAssetsRequest(this.service, body, parent);
        }

        /// <summary>
        /// Exports assets with time and resource types to a given Cloud Storage location/BigQuery table. For Cloud
        /// Storage location destinations, the output format is newline-delimited JSON. Each line represents a
        /// google.cloud.asset.v1.Asset in the JSON format; for BigQuery table destinations, the output table stores the
        /// fields in asset Protobuf as columns. This API implements the google.longrunning.Operation API, which allows
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
        /// Issue a job that queries assets using a SQL statement compatible with [BigQuery
        /// SQL](https://cloud.google.com/bigquery/docs/introduction-sql). If the query execution finishes within
        /// timeout and there's no pagination, the full query results will be returned in the `QueryAssetsResponse`.
        /// Otherwise, full query results can be obtained by issuing extra requests with the `job_reference` from the a
        /// previous `QueryAssets` call. Note, the query result has approximately 10 GB limitation enforced by
        /// [BigQuery](https://cloud.google.com/bigquery/docs/best-practices-performance-output). Queries return larger
        /// results will result in errors.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. The relative name of the root asset. This can only be an organization number (such as
        /// "organizations/123"), a project ID (such as "projects/my-project-id"), or a project number (such as
        /// "projects/12345"), or a folder number (such as "folders/123"). Only assets belonging to the `parent` will be
        /// returned.
        /// </param>
        public virtual QueryAssetsRequest QueryAssets(Google.Apis.CloudAsset.v1.Data.QueryAssetsRequest body, string parent)
        {
            return new QueryAssetsRequest(this.service, body, parent);
        }

        /// <summary>
        /// Issue a job that queries assets using a SQL statement compatible with [BigQuery
        /// SQL](https://cloud.google.com/bigquery/docs/introduction-sql). If the query execution finishes within
        /// timeout and there's no pagination, the full query results will be returned in the `QueryAssetsResponse`.
        /// Otherwise, full query results can be obtained by issuing extra requests with the `job_reference` from the a
        /// previous `QueryAssets` call. Note, the query result has approximately 10 GB limitation enforced by
        /// [BigQuery](https://cloud.google.com/bigquery/docs/best-practices-performance-output). Queries return larger
        /// results will result in errors.
        /// </summary>
        public class QueryAssetsRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.QueryAssetsResponse>
        {
            /// <summary>Constructs a new QueryAssets request.</summary>
            public QueryAssetsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAsset.v1.Data.QueryAssetsRequest body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The relative name of the root asset. This can only be an organization number (such as
            /// "organizations/123"), a project ID (such as "projects/my-project-id"), or a project number (such as
            /// "projects/12345"), or a folder number (such as "folders/123"). Only assets belonging to the `parent`
            /// will be returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudAsset.v1.Data.QueryAssetsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "queryAssets";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}:queryAssets";

            /// <summary>Initializes QueryAssets parameter list.</summary>
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
            return new SearchAllIamPoliciesRequest(this.service, scope);
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
            /// policies that are attached to all the asset types [supported by search
            /// APIs](https://cloud.google.com/asset-inventory/docs/supported-asset-types) Regular expressions are also
            /// supported. For example: * "compute.googleapis.com.*" snapshots IAM policies attached to asset type
            /// starts with "compute.googleapis.com". * ".*Instance" snapshots IAM policies attached to asset type ends
            /// with "Instance". * ".*Instance.*" snapshots IAM policies attached to asset type contains "Instance". See
            /// [RE2](https://github.com/google/re2/wiki/Syntax) for all supported regular expression syntax. If the
            /// regular expression does not match any supported asset type, an INVALID_ARGUMENT error will be returned.
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
            /// is given. If set to zero or a negative value, server will pick an appropriate default. Returned results
            /// may be fewer than requested. When this happens, there could be more results as long as `next_page_token`
            /// is returned.
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
            /// specified `scope`. Note that the query string is compared against each IAM policy binding, including its
            /// principals, roles, and IAM conditions. The returned IAM policies will only contain the bindings that
            /// match your query. To learn more about the IAM policy structure, see the [IAM policy
            /// documentation](https://cloud.google.com/iam/help/allow-policies/structure). Examples: *
            /// `policy:amy@gmail.com` to find IAM policy bindings that specify user "amy@gmail.com". *
            /// `policy:roles/compute.admin` to find IAM policy bindings that specify the Compute Admin role. *
            /// `policy:comp*` to find IAM policy bindings that contain "comp" as a prefix of any word in the binding. *
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
            /// bindings that contain the principal type "user".
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
        /// Searches all Google Cloud resources within the specified scope, such as a project, folder, or organization.
        /// The caller must be granted the `cloudasset.assets.searchAllResources` permission on the desired scope,
        /// otherwise the request will be rejected.
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
            return new SearchAllResourcesRequest(this.service, scope);
        }

        /// <summary>
        /// Searches all Google Cloud resources within the specified scope, such as a project, folder, or organization.
        /// The caller must be granted the `cloudasset.assets.searchAllResources` permission on the desired scope,
        /// otherwise the request will be rejected.
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
            /// Optional. A list of asset types that this request searches for. If empty, it will search all the asset
            /// types [supported by search APIs](https://cloud.google.com/asset-inventory/docs/supported-asset-types).
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
            /// characters are ignored. Example: "location DESC, name". Only the following fields in the response are
            /// sortable: * name * assetType * project * displayName * description * location * createTime * updateTime
            /// * state * parentFullResourceName * parentAssetType
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>
            /// Optional. The page size for search result pagination. Page size is capped at 500 even if a larger value
            /// is given. If set to zero or a negative value, server will pick an appropriate default. Returned results
            /// may be fewer than requested. When this happens, there could be more results as long as `next_page_token`
            /// is returned.
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
            /// `scope`. Examples: * `name:Important` to find Google Cloud resources whose name contains `Important` as
            /// a word. * `name=Important` to find the Google Cloud resource whose name is exactly `Important`. *
            /// `displayName:Impor*` to find Google Cloud resources whose display name contains `Impor` as a prefix of
            /// any word in the field. * `location:us-west*` to find Google Cloud resources whose location contains both
            /// `us` and `west` as prefixes. * `labels:prod` to find Google Cloud resources whose labels contain `prod`
            /// as a key or value. * `labels.env:prod` to find Google Cloud resources that have a label `env` and its
            /// value is `prod`. * `labels.env:*` to find Google Cloud resources that have a label `env`. *
            /// `tagKeys:env` to find Google Cloud resources that have directly attached tags where the
            /// [`TagKey.namespacedName`](https://cloud.google.com/resource-manager/reference/rest/v3/tagKeys#resource:-tagkey)
            /// contains `env`. * `tagValues:prod*` to find Google Cloud resources that have directly attached tags
            /// where the
            /// [`TagValue.namespacedName`](https://cloud.google.com/resource-manager/reference/rest/v3/tagValues#resource:-tagvalue)
            /// contains a word prefixed by `prod`. * `tagValueIds=tagValues/123` to find Google Cloud resources that
            /// have directly attached tags where the
            /// [`TagValue.name`](https://cloud.google.com/resource-manager/reference/rest/v3/tagValues#resource:-tagvalue)
            /// is exactly `tagValues/123`. * `effectiveTagKeys:env` to find Google Cloud resources that have directly
            /// attached or inherited tags where the
            /// [`TagKey.namespacedName`](https://cloud.google.com/resource-manager/reference/rest/v3/tagKeys#resource:-tagkey)
            /// contains `env`. * `effectiveTagValues:prod*` to find Google Cloud resources that have directly attached
            /// or inherited tags where the
            /// [`TagValue.namespacedName`](https://cloud.google.com/resource-manager/reference/rest/v3/tagValues#resource:-tagvalue)
            /// contains a word prefixed by `prod`. * `effectiveTagValueIds=tagValues/123` to find Google Cloud
            /// resources that have directly attached or inherited tags where the
            /// [`TagValue.name`](https://cloud.google.com/resource-manager/reference/rest/v3/tagValues#resource:-tagvalue)
            /// is exactly `tagValues/123`. * `kmsKey:key` to find Google Cloud resources encrypted with a
            /// customer-managed encryption key whose name contains `key` as a word. This field is deprecated. Use the
            /// `kmsKeys` field to retrieve Cloud KMS key information. * `kmsKeys:key` to find Google Cloud resources
            /// encrypted with customer-managed encryption keys whose name contains the word `key`. *
            /// `relationships:instance-group-1` to find Google Cloud resources that have relationships with
            /// `instance-group-1` in the related resource name. * `relationships:INSTANCE_TO_INSTANCEGROUP` to find
            /// Compute Engine instances that have relationships of type `INSTANCE_TO_INSTANCEGROUP`. *
            /// `relationships.INSTANCE_TO_INSTANCEGROUP:instance-group-1` to find Compute Engine instances that have
            /// relationships with `instance-group-1` in the Compute Engine instance group resource name, for
            /// relationship type `INSTANCE_TO_INSTANCEGROUP`. * `sccSecurityMarks.key=value` to find Cloud resources
            /// that are attached with security marks whose key is `key` and value is `value`. *
            /// `sccSecurityMarks.key:*` to find Cloud resources that are attached with security marks whose key is
            /// `key`. * `state:ACTIVE` to find Google Cloud resources whose state contains `ACTIVE` as a word. * `NOT
            /// state:ACTIVE` to find Google Cloud resources whose state doesn't contain `ACTIVE` as a word. *
            /// `createTime&amp;lt;1609459200` to find Google Cloud resources that were created before `2021-01-01
            /// 00:00:00 UTC`. `1609459200` is the epoch timestamp of `2021-01-01 00:00:00 UTC` in seconds. *
            /// `updateTime&amp;gt;1609459200` to find Google Cloud resources that were updated after `2021-01-01
            /// 00:00:00 UTC`. `1609459200` is the epoch timestamp of `2021-01-01 00:00:00 UTC` in seconds. *
            /// `Important` to find Google Cloud resources that contain `Important` as a word in any of the searchable
            /// fields. * `Impor*` to find Google Cloud resources that contain `Impor` as a prefix of any word in any of
            /// the searchable fields. * `Important location:(us-west1 OR global)` to find Google Cloud resources that
            /// contain `Important` as a word in any of the searchable fields and are also located in the `us-west1`
            /// region or the `global` location.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>
            /// Optional. A comma-separated list of fields that you want returned in the results. The following fields
            /// are returned by default if not specified: * `name` * `assetType` * `project` * `folders` *
            /// `organization` * `displayName` * `description` * `location` * `labels` * `tags` * `effectiveTags` *
            /// `networkTags` * `kmsKeys` * `createTime` * `updateTime` * `state` * `additionalAttributes` *
            /// `parentFullResourceName` * `parentAssetType` Some fields of large size, such as `versionedResources`,
            /// `attachedResources`, `effectiveTags` etc., are not returned by default, but you can specify them in the
            /// `read_mask` parameter if you want to include them. If `"*"` is specified, all [available
            /// fields](https://cloud.google.com/asset-inventory/docs/reference/rest/v1/TopLevel/searchAllResources#resourcesearchresult)
            /// are returned. Examples: `"name,location"`, `"name,versionedResources"`, `"*"`. Any invalid field path
            /// will trigger INVALID_ARGUMENT error.
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

    /// <summary>Represents the metadata of the longrunning operation for the AnalyzeIamPolicyLongrunning RPC.</summary>
    public class AnalyzeIamPolicyLongrunningMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time the operation was created.</summary>
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

        /// <summary>
        /// Optional. The name of a saved query, which must be in the format of: *
        /// projects/project_number/savedQueries/saved_query_id * folders/folder_number/savedQueries/saved_query_id *
        /// organizations/organization_number/savedQueries/saved_query_id If both `analysis_query` and
        /// `saved_analysis_query` are provided, they will be merged together with the `saved_analysis_query` as base
        /// and the `analysis_query` as overrides. For more details of the merge behavior, refer to the
        /// [MergeFrom](https://developers.google.com/protocol-buffers/docs/reference/cpp/google.protobuf.message#Message.MergeFrom.details)
        /// doc. Note that you cannot override primitive fields with default value, such as 0 or empty string, etc.,
        /// because we use proto3, which doesn't support field presence yet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("savedAnalysisQuery")]
        public virtual string SavedAnalysisQuery { get; set; }

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
        /// The service account impersonation analysis if
        /// IamPolicyAnalysisQuery.Options.analyze_service_account_impersonation is enabled.
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
        /// by different Google Cloud services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moveAnalysis")]
        public virtual System.Collections.Generic.IList<MoveAnalysis> MoveAnalysis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for AssetService.AnalyzeOrgPolicies.</summary>
    public class AnalyzeOrgPoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The definition of the constraint in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraint")]
        public virtual AnalyzerOrgPolicyConstraint Constraint { get; set; }

        /// <summary>The page token to fetch the next page for AnalyzeOrgPoliciesResponse.org_policy_results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The organization policies under the AnalyzeOrgPoliciesRequest.scope with the
        /// AnalyzeOrgPoliciesRequest.constraint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgPolicyResults")]
        public virtual System.Collections.Generic.IList<OrgPolicyResult> OrgPolicyResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for AssetService.AnalyzeOrgPolicyGovernedAssets.</summary>
    public class AnalyzeOrgPolicyGovernedAssetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The definition of the constraint in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraint")]
        public virtual AnalyzerOrgPolicyConstraint Constraint { get; set; }

        /// <summary>The list of the analyzed governed assets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("governedAssets")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssetV1AnalyzeOrgPolicyGovernedAssetsResponseGovernedAsset> GovernedAssets { get; set; }

        /// <summary>
        /// The page token to fetch the next page for AnalyzeOrgPolicyGovernedAssetsResponse.governed_assets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for AssetService.AnalyzeOrgPolicyGovernedContainers.</summary>
    public class AnalyzeOrgPolicyGovernedContainersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The definition of the constraint in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraint")]
        public virtual AnalyzerOrgPolicyConstraint Constraint { get; set; }

        /// <summary>The list of the analyzed governed containers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("governedContainers")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssetV1GovernedContainer> GovernedContainers { get; set; }

        /// <summary>
        /// The page token to fetch the next page for AnalyzeOrgPolicyGovernedContainersResponse.governed_containers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This organization policy message is a modified version of the one defined in the Organization Policy system.
    /// This message contains several fields defined in the original organization policy with some new fields for
    /// analysis purpose.
    /// </summary>
    public class AnalyzerOrgPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The [full resource name] (https://cloud.google.com/asset-inventory/docs/resource-name-format) of an
        /// organization/folder/project resource where this organization policy applies to. For any user defined org
        /// policies, this field has the same value as the [attached_resource] field. Only for default policy, this
        /// field has the different value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appliedResource")]
        public virtual string AppliedResource { get; set; }

        /// <summary>
        /// The [full resource name] (https://cloud.google.com/asset-inventory/docs/resource-name-format) of an
        /// organization/folder/project resource where this organization policy is set. Notice that some type of
        /// constraints are defined with default policy. This field will be empty for them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachedResource")]
        public virtual string AttachedResource { get; set; }

        /// <summary>
        /// If `inherit_from_parent` is true, Rules set higher up in the hierarchy (up to the closest root) are
        /// inherited and present in the effective policy. If it is false, then no rules are inherited, and this policy
        /// becomes the effective root for evaluation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inheritFromParent")]
        public virtual System.Nullable<bool> InheritFromParent { get; set; }

        /// <summary>
        /// Ignores policies set above this resource and restores the default behavior of the constraint at this
        /// resource. This field can be set in policies for either list or boolean constraints. If set, `rules` must be
        /// empty and `inherit_from_parent` must be set to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reset")]
        public virtual System.Nullable<bool> Reset { get; set; }

        /// <summary>List of rules for this organization policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssetV1Rule> Rules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The organization policy constraint definition.</summary>
    public class AnalyzerOrgPolicyConstraint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The definition of the custom constraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customConstraint")]
        public virtual GoogleCloudAssetV1CustomConstraint CustomConstraint { get; set; }

        /// <summary>The definition of the canned constraint defined by Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleDefinedConstraint")]
        public virtual GoogleCloudAssetV1Constraint GoogleDefinedConstraint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An asset in Google Cloud. An asset can be any resource in the Google Cloud [resource
    /// hierarchy](https://cloud.google.com/resource-manager/docs/cloud-platform-resource-hierarchy), a resource outside
    /// the Google Cloud resource hierarchy (such as Google Kubernetes Engine clusters and objects), or a policy (e.g.
    /// IAM policy), or a relationship (e.g. an INSTANCE_TO_INSTANCEGROUP relationship). See [Supported asset
    /// types](https://cloud.google.com/asset-inventory/docs/supported-asset-types) for more information.
    /// </summary>
    public class Asset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Also refer to the [access level user
        /// guide](https://cloud.google.com/access-context-manager/docs/overview#access-levels).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLevel")]
        public virtual GoogleIdentityAccesscontextmanagerV1AccessLevel AccessLevel { get; set; }

        /// <summary>
        /// Also refer to the [access policy user
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
        /// A representation of the IAM policy set on a Google Cloud resource. There can be a maximum of one IAM policy
        /// set on any given resource. In addition, IAM policies inherit their granted access scope from any policies
        /// set on parent resources in the resource hierarchy. Therefore, the effectively policy is the union of both
        /// the policy set on this resource and each policy set on all of the resource's ancestry resource levels in the
        /// hierarchy. See [this topic](https://cloud.google.com/iam/help/allow-policies/inheritance) for more
        /// information.
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

        /// <summary>One related asset of the current asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedAsset")]
        public virtual RelatedAsset RelatedAsset { get; set; }

        /// <summary>
        /// DEPRECATED. This field only presents for the purpose of backward-compatibility. The server will never
        /// generate responses with this field. The related assets of the asset of one relationship type. One asset only
        /// represents one type of relationship.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedAssets")]
        public virtual RelatedAssets RelatedAssets { get; set; }

        /// <summary>A representation of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual Resource Resource { get; set; }

        /// <summary>
        /// Also refer to the [service perimeter user
        /// guide](https://cloud.google.com/vpc-service-controls/docs/overview).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicePerimeter")]
        public virtual GoogleIdentityAccesscontextmanagerV1ServicePerimeter ServicePerimeter { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// The last update timestamp of an asset. update_time is updated when create/update/delete operation is
        /// performed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The enhanced metadata information for a resource.</summary>
    public class AssetEnrichment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource owners for a resource. Note that this field only contains the members that have "roles/owner"
        /// role in the resource's IAM Policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceOwners")]
        public virtual ResourceOwners ResourceOwners { get; set; }

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
        /// `https://cloud.google.com/asset-inventory/docs/supported-asset-types`
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
    /// logging. It also exempts `jose@example.com` from DATA_READ logging, and `aliya@example.com` from DATA_WRITE
    /// logging.
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

    /// <summary>A response message for AssetService.BatchGetEffectiveIamPolicies.</summary>
    public class BatchGetEffectiveIamPoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The effective policies for a batch of resources. Note that the results order is the same as the order of
        /// BatchGetEffectiveIamPoliciesRequest.names. When a resource does not have any effective IAM policies, its
        /// corresponding policy_result will contain empty EffectiveIamPolicy.policies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyResults")]
        public virtual System.Collections.Generic.IList<EffectiveIamPolicy> PolicyResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A BigQuery destination for exporting assets to.</summary>
    public class BigQueryDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The BigQuery dataset in format "projects/projectId/datasets/datasetId", to which the snapshot
        /// result should be exported. If this dataset does not exist, the export call returns an INVALID_ARGUMENT
        /// error. Setting the `contentType` for `exportAssets` determines the
        /// [schema](/asset-inventory/docs/exporting-to-bigquery#bigquery-schema) of the BigQuery table. Setting
        /// `separateTablesPerAssetType` to `TRUE` also influences the schema.
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

    /// <summary>Associates `members`, or principals, with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// principals in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// Specifies the principals requesting access for a Google Cloud resource. `members` can have the following
        /// values: * `allUsers`: A special identifier that represents anyone who is on the internet; with or without a
        /// Google account. * `allAuthenticatedUsers`: A special identifier that represents anyone who is authenticated
        /// with a Google account or a service account. Does not include identities that come from external identity
        /// providers (IdPs) through identity federation. * `user:{emailid}`: An email address that represents a
        /// specific Google account. For example, `alice@example.com` . * `serviceAccount:{emailid}`: An email address
        /// that represents a Google service account. For example, `my-other-app@appspot.gserviceaccount.com`. *
        /// `serviceAccount:{projectid}.svc.id.goog[{namespace}/{kubernetes-sa}]`: An identifier for a [Kubernetes
        /// service account](https://cloud.google.com/kubernetes-engine/docs/how-to/kubernetes-service-accounts). For
        /// example, `my-project.svc.id.goog[my-namespace/my-kubernetes-sa]`. * `group:{emailid}`: An email address that
        /// represents a Google group. For example, `admins@example.com`. * `domain:{domain}`: The G Suite domain
        /// (primary) that represents all the users of that domain. For example, `google.com` or `example.com`. *
        /// `principal://iam.googleapis.com/locations/global/workforcePools/{pool_id}/subject/{subject_attribute_value}`:
        /// A single identity in a workforce identity pool. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/group/{group_id}`: All
        /// workforce identities in a group. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/attribute.{attribute_name}/{attribute_value}`:
        /// All workforce identities with a specific attribute value. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/*`: All identities in a
        /// workforce identity pool. *
        /// `principal://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/subject/{subject_attribute_value}`:
        /// A single identity in a workload identity pool. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/group/{group_id}`:
        /// A workload identity pool group. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/attribute.{attribute_name}/{attribute_value}`:
        /// All identities in a workload identity pool with a certain attribute. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/*`:
        /// All identities in a workload identity pool. * `deleted:user:{emailid}?uid={uniqueid}`: An email address
        /// (plus unique identifier) representing a user that has been recently deleted. For example,
        /// `alice@example.com?uid=123456789012345678901`. If the user is recovered, this value reverts to
        /// `user:{emailid}` and the recovered user retains the role in the binding. *
        /// `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a
        /// service account that has been recently deleted. For example,
        /// `my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted,
        /// this value reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the
        /// binding. * `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing
        /// a Google group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`.
        /// If the group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role
        /// in the binding. *
        /// `deleted:principal://iam.googleapis.com/locations/global/workforcePools/{pool_id}/subject/{subject_attribute_value}`:
        /// Deleted single identity in a workforce identity pool. For example,
        /// `deleted:principal://iam.googleapis.com/locations/global/workforcePools/my-pool-id/subject/my-subject-attribute-value`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Role that is assigned to the list of `members`, or principals. For example, `roles/viewer`, `roles/editor`,
        /// or `roles/owner`. For an overview of the IAM roles and permissions, see the [IAM
        /// documentation](https://cloud.google.com/iam/docs/roles-overview). For a list of the available pre-defined
        /// roles, see [here](https://cloud.google.com/iam/docs/understanding-roles).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The IAM conditions context.</summary>
    public class ConditionContext : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _accessTimeRaw;

        private object _accessTime;

        /// <summary>
        /// The hypothetical access timestamp to evaluate IAM conditions. Note that this value must not be earlier than
        /// the current time; otherwise, an INVALID_ARGUMENT error will be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessTime")]
        public virtual string AccessTimeRaw
        {
            get => _accessTimeRaw;
            set
            {
                _accessTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _accessTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="AccessTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use AccessTimeDateTimeOffset instead.")]
        public virtual object AccessTime
        {
            get => _accessTime;
            set
            {
                _accessTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _accessTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="AccessTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? AccessTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(AccessTimeRaw);
            set => AccessTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The condition evaluation.</summary>
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

    /// <summary>The effective IAM policies on one resource.</summary>
    public class EffectiveIamPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The [full_resource_name] (https://cloud.google.com/asset-inventory/docs/resource-name-format) for which the
        /// policies are computed. This is one of the BatchGetEffectiveIamPoliciesRequest.names the caller provides in
        /// the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; }

        /// <summary>
        /// The effective policies for the full_resource_name. These policies include the policy set on the
        /// full_resource_name and those set on its parents and ancestors up to the
        /// BatchGetEffectiveIamPoliciesRequest.scope. Note that these policies are not filtered according to the
        /// resource type of the full_resource_name. These policies are hierarchically ordered by
        /// PolicyInfo.attached_resource starting from full_resource_name itself to its parents and ancestors, such that
        /// policies[i]'s PolicyInfo.attached_resource is the child of policies[i+1]'s PolicyInfo.attached_resource, if
        /// policies[i+1] exists.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policies")]
        public virtual System.Collections.Generic.IList<PolicyInfo> Policies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The effective tags and the ancestor resources from which they were inherited.</summary>
    public class EffectiveTagDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The [full resource name](https://cloud.google.com/asset-inventory/docs/resource-name-format) of the ancestor
        /// from which effective_tags are inherited, according to [tag
        /// inheritance](https://cloud.google.com/resource-manager/docs/tags/tags-overview#inheritance).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachedResource")]
        public virtual string AttachedResource { get; set; }

        /// <summary>
        /// The effective tags inherited from the attached_resource. Note that tags with the same key but different
        /// values may attach to resources at a different hierarchy levels. The lower hierarchy tag value will overwrite
        /// the higher hierarchy tag value of the same tag key. In this case, the tag value at the higher hierarchy
        /// level will be removed. For more information, see [tag
        /// inheritance](https://cloud.google.com/resource-manager/docs/tags/tags-overview#inheritance).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveTags")]
        public virtual System.Collections.Generic.IList<Tag> EffectiveTags { get; set; }

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

        private string _readTimeRaw;

        private object _readTime;

        /// <summary>
        /// Timestamp to take an asset snapshot. This can only be set to a timestamp between the current time and the
        /// current time minus 35 days (inclusive). If not specified, the current time will be used. Due to delays in
        /// resource data collection and indexing, there is a volatile window during which running the same query may
        /// get different results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual string ReadTimeRaw
        {
            get => _readTimeRaw;
            set
            {
                _readTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _readTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeDateTimeOffset instead.")]
        public virtual object ReadTime
        {
            get => _readTime;
            set
            {
                _readTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _readTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReadTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReadTimeRaw);
            set => ReadTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// A list of relationship types to export, for example: `INSTANCE_TO_INSTANCEGROUP`. This field should only be
        /// specified if content_type=RELATIONSHIP. * If specified: it snapshots specified relationships. It returns an
        /// error if any of the [relationship_types] doesn't belong to the supported relationship types of the
        /// [asset_types] or if any of the [asset_types] doesn't belong to the source types of the [relationship_types].
        /// * Otherwise: it snapshots the supported relationships for all [asset_types] or returns an error if any of
        /// the [asset_types] has no relationship support. An unspecified asset types field means all supported
        /// asset_types. See [Introduction to Cloud Asset
        /// Inventory](https://cloud.google.com/asset-inventory/docs/overview) for all supported asset types and
        /// relationship types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relationshipTypes")]
        public virtual System.Collections.Generic.IList<string> RelationshipTypes { get; set; }

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
        /// Example: `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1`. For a list of
        /// the full names for supported asset types, see [Resource name
        /// format](/asset-inventory/docs/resource-name-format).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetNames")]
        public virtual System.Collections.Generic.IList<string> AssetNames { get; set; }

        /// <summary>
        /// A list of types of the assets to receive updates. You must specify either or both of asset_names and
        /// asset_types. Only asset updates matching specified asset_names or asset_types are exported to the feed.
        /// Example: `"compute.googleapis.com/Disk"` For a list of all supported asset types, see [Supported asset
        /// types](/asset-inventory/docs/supported-asset-types).
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

        /// <summary>
        /// A list of relationship types to output, for example: `INSTANCE_TO_INSTANCEGROUP`. This field should only be
        /// specified if content_type=RELATIONSHIP. * If specified: it outputs specified relationship updates on the
        /// [asset_names] or the [asset_types]. It returns an error if any of the [relationship_types] doesn't belong to
        /// the supported relationship types of the [asset_names] or [asset_types], or any of the [asset_names] or the
        /// [asset_types] doesn't belong to the source types of the [relationship_types]. * Otherwise: it outputs the
        /// supported relationships of the types of [asset_names] and [asset_types] or returns an error if any of the
        /// [asset_names] or the [asset_types] has no replationship support. See [Introduction to Cloud Asset
        /// Inventory](https://cloud.google.com/asset-inventory/docs/overview) for all supported asset types and
        /// relationship types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relationshipTypes")]
        public virtual System.Collections.Generic.IList<string> RelationshipTypes { get; set; }

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
        /// The URI of the Cloud Storage object. It's the same URI that is used by gsutil. Example:
        /// "gs://bucket_name/object_name". See [Viewing and Editing Object
        /// Metadata](https://cloud.google.com/storage/docs/viewing-editing-metadata) for more information. If the
        /// specified Cloud Storage object already exists and there is no
        /// [hold](https://cloud.google.com/storage/docs/object-holds), it will be overwritten with the exported result.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>
        /// The URI prefix of all generated Cloud Storage objects. Example: "gs://bucket_name/object_name_prefix". Each
        /// object URI is in format: "gs://bucket_name/object_name_prefix// and only contains assets for that type.
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

    /// <summary>
    /// Represents a Google Cloud asset(resource or IAM policy) governed by the organization policies of the
    /// AnalyzeOrgPolicyGovernedAssetsRequest.constraint.
    /// </summary>
    public class GoogleCloudAssetV1AnalyzeOrgPolicyGovernedAssetsResponseGovernedAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The consolidated policy for the analyzed asset. The consolidated policy is computed by merging and
        /// evaluating AnalyzeOrgPolicyGovernedAssetsResponse.GovernedAsset.policy_bundle. The evaluation will respect
        /// the organization policy [hierarchy
        /// rules](https://cloud.google.com/resource-manager/docs/organization-policy/understanding-hierarchy).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consolidatedPolicy")]
        public virtual AnalyzerOrgPolicy ConsolidatedPolicy { get; set; }

        /// <summary>
        /// An IAM policy governed by the organization policies of the AnalyzeOrgPolicyGovernedAssetsRequest.constraint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("governedIamPolicy")]
        public virtual GoogleCloudAssetV1AnalyzeOrgPolicyGovernedAssetsResponseGovernedIamPolicy GovernedIamPolicy { get; set; }

        /// <summary>
        /// A Google Cloud resource governed by the organization policies of the
        /// AnalyzeOrgPolicyGovernedAssetsRequest.constraint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("governedResource")]
        public virtual GoogleCloudAssetV1AnalyzeOrgPolicyGovernedAssetsResponseGovernedResource GovernedResource { get; set; }

        /// <summary>
        /// The ordered list of all organization policies from the consolidated_policy.attached_resource to the scope
        /// specified in the request. If the constraint is defined with default policy, it will also appear in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyBundle")]
        public virtual System.Collections.Generic.IList<AnalyzerOrgPolicy> PolicyBundle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The IAM policies governed by the organization policies of the AnalyzeOrgPolicyGovernedAssetsRequest.constraint.
    /// </summary>
    public class GoogleCloudAssetV1AnalyzeOrgPolicyGovernedAssetsResponseGovernedIamPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The asset type of the AnalyzeOrgPolicyGovernedAssetsResponse.GovernedIamPolicy.attached_resource. Example:
        /// `cloudresourcemanager.googleapis.com/Project` See [Cloud Asset Inventory Supported Asset
        /// Types](https://cloud.google.com/asset-inventory/docs/supported-asset-types) for all supported asset types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetType")]
        public virtual string AssetType { get; set; }

        /// <summary>
        /// The full resource name of the resource on which this IAM policy is set. Example:
        /// `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1`. See [Cloud Asset
        /// Inventory Resource Name Format](https://cloud.google.com/asset-inventory/docs/resource-name-format) for more
        /// information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachedResource")]
        public virtual string AttachedResource { get; set; }

        /// <summary>
        /// The folder(s) that this IAM policy belongs to, in the format of folders/{FOLDER_NUMBER}. This field is
        /// available when the IAM policy belongs (directly or cascadingly) to one or more folders.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folders")]
        public virtual System.Collections.Generic.IList<string> Folders { get; set; }

        /// <summary>
        /// The organization that this IAM policy belongs to, in the format of organizations/{ORGANIZATION_NUMBER}. This
        /// field is available when the IAM policy belongs (directly or cascadingly) to an organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual string Organization { get; set; }

        /// <summary>The IAM policy directly set on the given resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>
        /// The project that this IAM policy belongs to, in the format of projects/{PROJECT_NUMBER}. This field is
        /// available when the IAM policy belongs to a project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The Google Cloud resources governed by the organization policies of the
    /// AnalyzeOrgPolicyGovernedAssetsRequest.constraint.
    /// </summary>
    public class GoogleCloudAssetV1AnalyzeOrgPolicyGovernedAssetsResponseGovernedResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The asset type of the AnalyzeOrgPolicyGovernedAssetsResponse.GovernedResource.full_resource_name Example:
        /// `cloudresourcemanager.googleapis.com/Project` See [Cloud Asset Inventory Supported Asset
        /// Types](https://cloud.google.com/asset-inventory/docs/supported-asset-types) for all supported asset types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetType")]
        public virtual string AssetType { get; set; }

        /// <summary>The effective tags on this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveTags")]
        public virtual System.Collections.Generic.IList<EffectiveTagDetails> EffectiveTags { get; set; }

        /// <summary>
        /// The folder(s) that this resource belongs to, in the format of folders/{FOLDER_NUMBER}. This field is
        /// available when the resource belongs (directly or cascadingly) to one or more folders.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folders")]
        public virtual System.Collections.Generic.IList<string> Folders { get; set; }

        /// <summary>
        /// The [full resource name] (https://cloud.google.com/asset-inventory/docs/resource-name-format) of the Google
        /// Cloud resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; }

        /// <summary>
        /// The organization that this resource belongs to, in the format of organizations/{ORGANIZATION_NUMBER}. This
        /// field is available when the resource belongs (directly or cascadingly) to an organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual string Organization { get; set; }

        /// <summary>
        /// The [full resource name] (https://cloud.google.com/asset-inventory/docs/resource-name-format) of the parent
        /// of AnalyzeOrgPolicyGovernedAssetsResponse.GovernedResource.full_resource_name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// The project that this resource belongs to, in the format of projects/{PROJECT_NUMBER}. This field is
        /// available when the resource belongs to a project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

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

    /// <summary>
    /// A `Constraint` that is either enforced or not. For example a constraint
    /// `constraints/compute.disableSerialPortAccess`. If it is enforced on a VM instance, serial port connections will
    /// not be opened to that instance.
    /// </summary>
    public class GoogleCloudAssetV1BooleanConstraint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The definition of a constraint.</summary>
    public class GoogleCloudAssetV1Constraint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Defines this constraint as being a BooleanConstraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("booleanConstraint")]
        public virtual GoogleCloudAssetV1BooleanConstraint BooleanConstraint { get; set; }

        /// <summary>The evaluation behavior of this constraint in the absence of 'Policy'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraintDefault")]
        public virtual string ConstraintDefault { get; set; }

        /// <summary>
        /// Detailed description of what this `Constraint` controls as well as how and where it is enforced.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The human readable name of the constraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Defines this constraint as being a ListConstraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listConstraint")]
        public virtual GoogleCloudAssetV1ListConstraint ListConstraint { get; set; }

        /// <summary>
        /// The unique name of the constraint. Format of the name should be * `constraints/{constraint_name}` For
        /// example, `constraints/compute.disableSerialPortAccess`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The definition of a custom constraint.</summary>
    public class GoogleCloudAssetV1CustomConstraint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Allow or deny type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionType")]
        public virtual string ActionType { get; set; }

        /// <summary>
        /// Organization Policy condition/expression. For example:
        /// `resource.instanceName.matches("[production|test]_.*_(\d)+")'` or, `resource.management.auto_upgrade ==
        /// true`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; }

        /// <summary>Detailed information about this custom policy constraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>One line display name for the UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>All the operations being applied for this constraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("methodTypes")]
        public virtual System.Collections.Generic.IList<string> MethodTypes { get; set; }

        /// <summary>
        /// Name of the constraint. This is unique within the organization. Format of the name should be *
        /// `organizations/{organization_id}/customConstraints/{custom_constraint_id}` Example :
        /// "organizations/123/customConstraints/custom.createOnlyE2TypeVms"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The Resource Instance type on which this policy applies to. Format will be of the form : "/" Example: *
        /// `compute.googleapis.com/Instance`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceTypes")]
        public virtual System.Collections.Generic.IList<string> ResourceTypes { get; set; }

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
        /// Required. The URI of the Cloud Storage object. It's the same URI that is used by gsutil. Example:
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

    /// <summary>
    /// The organization/folder/project resource governed by organization policies of
    /// AnalyzeOrgPolicyGovernedContainersRequest.constraint.
    /// </summary>
    public class GoogleCloudAssetV1GovernedContainer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The consolidated organization policy for the analyzed resource. The consolidated organization policy is
        /// computed by merging and evaluating
        /// AnalyzeOrgPolicyGovernedContainersResponse.GovernedContainer.policy_bundle. The evaluation will respect the
        /// organization policy [hierarchy
        /// rules](https://cloud.google.com/resource-manager/docs/organization-policy/understanding-hierarchy).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consolidatedPolicy")]
        public virtual AnalyzerOrgPolicy ConsolidatedPolicy { get; set; }

        /// <summary>The effective tags on this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveTags")]
        public virtual System.Collections.Generic.IList<EffectiveTagDetails> EffectiveTags { get; set; }

        /// <summary>
        /// The folder(s) that this resource belongs to, in the format of folders/{FOLDER_NUMBER}. This field is
        /// available when the resource belongs (directly or cascadingly) to one or more folders.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folders")]
        public virtual System.Collections.Generic.IList<string> Folders { get; set; }

        /// <summary>
        /// The [full resource name] (https://cloud.google.com/asset-inventory/docs/resource-name-format) of an
        /// organization/folder/project resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; }

        /// <summary>
        /// The organization that this resource belongs to, in the format of organizations/{ORGANIZATION_NUMBER}. This
        /// field is available when the resource belongs (directly or cascadingly) to an organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual string Organization { get; set; }

        /// <summary>
        /// The [full resource name] (https://cloud.google.com/asset-inventory/docs/resource-name-format) of the parent
        /// of AnalyzeOrgPolicyGovernedContainersResponse.GovernedContainer.full_resource_name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// The ordered list of all organization policies from the consolidated_policy.attached_resource. to the scope
        /// specified in the request. If the constraint is defined with default policy, it will also appear in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyBundle")]
        public virtual System.Collections.Generic.IList<AnalyzerOrgPolicy> PolicyBundle { get; set; }

        /// <summary>
        /// The project that this resource belongs to, in the format of projects/{PROJECT_NUMBER}. This field is
        /// available when the resource belongs to a project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

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
        /// The identity of members, formatted as appear in an [IAM policy
        /// binding](https://cloud.google.com/iam/reference/rest/v1/Binding). For example, they might be formatted like
        /// the following: - user:foo@google.com - group:group1@google.com -
        /// serviceAccount:s1@prj1.iam.gserviceaccount.com - projectOwner:some_project_id - domain:google.com - allUsers
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

    /// <summary>
    /// A `Constraint` that allows or disallows a list of string values, which are configured by an organization's
    /// policy administrator with a `Policy`.
    /// </summary>
    public class GoogleCloudAssetV1ListConstraint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates whether values grouped into categories can be used in `Policy.allowed_values` and
        /// `Policy.denied_values`. For example, `"in:Python"` would match any value in the 'Python' group.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportsIn")]
        public virtual System.Nullable<bool> SupportsIn { get; set; }

        /// <summary>
        /// Indicates whether subtrees of Cloud Resource Manager resource hierarchy can be used in
        /// `Policy.allowed_values` and `Policy.denied_values`. For example, `"under:folders/123"` would match any
        /// resource under the 'folders/123' folder.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportsUnder")]
        public virtual System.Nullable<bool> SupportsUnder { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BigQuery destination.</summary>
    public class GoogleCloudAssetV1QueryAssetsOutputConfigBigQueryDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The BigQuery dataset where the query results will be saved. It has the format of
        /// "projects/{projectId}/datasets/{datasetId}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>
        /// Required. The BigQuery table where the query results will be saved. If this table does not exist, a new
        /// table with the given name will be created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual string Table { get; set; }

        /// <summary>
        /// Specifies the action that occurs if the destination table or partition already exists. The following values
        /// are supported: * WRITE_TRUNCATE: If the table or partition already exists, BigQuery overwrites the entire
        /// table or all the partitions data. * WRITE_APPEND: If the table or partition already exists, BigQuery appends
        /// the data to the table or the latest partition. * WRITE_EMPTY: If the table already exists and contains data,
        /// a 'duplicate' error is returned in the job result. The default value is WRITE_EMPTY.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeDisposition")]
        public virtual string WriteDisposition { get; set; }

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
    /// This rule message is a customized version of the one defined in the Organization Policy system. In addition to
    /// the fields defined in the original organization policy, it contains additional field(s) under specific
    /// circumstances to support analysis results.
    /// </summary>
    public class GoogleCloudAssetV1Rule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Setting this to true means that all values are allowed. This field can be set only in Policies for list
        /// constraints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowAll")]
        public virtual System.Nullable<bool> AllowAll { get; set; }

        /// <summary>The evaluating condition for this rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// The condition evaluation result for this rule. Only populated if it meets all the following criteria: *
        /// There is a condition defined for this rule. * This rule is within
        /// AnalyzeOrgPolicyGovernedContainersResponse.GovernedContainer.consolidated_policy, or
        /// AnalyzeOrgPolicyGovernedAssetsResponse.GovernedAsset.consolidated_policy when the
        /// AnalyzeOrgPolicyGovernedAssetsResponse.GovernedAsset has
        /// AnalyzeOrgPolicyGovernedAssetsResponse.GovernedAsset.governed_resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionEvaluation")]
        public virtual ConditionEvaluation ConditionEvaluation { get; set; }

        /// <summary>
        /// Setting this to true means that all values are denied. This field can be set only in Policies for list
        /// constraints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denyAll")]
        public virtual System.Nullable<bool> DenyAll { get; set; }

        /// <summary>
        /// If `true`, then the `Policy` is enforced. If `false`, then any configuration is acceptable. This field can
        /// be set only in Policies for boolean constraints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enforce")]
        public virtual System.Nullable<bool> Enforce { get; set; }

        /// <summary>
        /// List of values to be used for this policy rule. This field can be set only in policies for list constraints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual GoogleCloudAssetV1StringValues Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The string values for the list constraints.</summary>
    public class GoogleCloudAssetV1StringValues : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of values allowed at this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedValues")]
        public virtual System.Collections.Generic.IList<string> AllowedValues { get; set; }

        /// <summary>List of values denied at this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deniedValues")]
        public virtual System.Collections.Generic.IList<string> DeniedValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An asset in Google Cloud. An asset can be any resource in the Google Cloud [resource
    /// hierarchy](https://cloud.google.com/resource-manager/docs/cloud-platform-resource-hierarchy), a resource outside
    /// the Google Cloud resource hierarchy (such as Google Kubernetes Engine clusters and objects), or a policy (e.g.
    /// IAM policy). See [Supported asset types](https://cloud.google.com/asset-inventory/docs/supported-asset-types)
    /// for more information.
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
        /// A representation of the IAM policy set on a Google Cloud resource. There can be a maximum of one IAM policy
        /// set on any given resource. In addition, IAM policies inherit their granted access scope from any policies
        /// set on parent resources in the resource hierarchy. Therefore, the effectively policy is the union of both
        /// the policy set on this resource and each policy set on all of the resource's ancestry resource levels in the
        /// hierarchy. See [this topic](https://cloud.google.com/iam/help/allow-policies/inheritance) for more
        /// information.
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

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// The last update timestamp of an asset. update_time is updated when create/update/delete operation is
        /// performed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An asset identify in Google Cloud which contains its name, type and ancestors. An asset can be any resource in
    /// the Google Cloud [resource
    /// hierarchy](https://cloud.google.com/resource-manager/docs/cloud-platform-resource-hierarchy), a resource outside
    /// the Google Cloud resource hierarchy (such as Google Kubernetes Engine clusters and objects), or a policy (e.g.
    /// IAM policy). See [Supported asset types](https://cloud.google.com/asset-inventory/docs/supported-asset-types)
    /// for more information.
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
        /// Google Cloud assets, this value is the parent resource defined in the [IAM policy
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

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// The time stamp the `Policy` was previously updated. This is set by the server, not specified by the caller,
        /// and represents the last time a call to `SetOrgPolicy` was made for that `Policy`. Any value set by the
        /// client will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

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
        /// Identifier. Resource name for the `AccessLevel`. Format:
        /// `accessPolicies/{access_policy}/accessLevels/{access_level}`. The `access_level` component must begin with a
        /// letter, followed by alphanumeric characters or `_`. Its maximum length is 50 characters. After you create an
        /// `AccessLevel`, you cannot change its `name`.
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
        /// strongly validated etag, meaning that two Access Policies will be identical if and only if their etags are
        /// identical. Clients should not expect this to be in any specific format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. Identifier. Resource name of the `AccessPolicy`. Format: `accessPolicies/{access_policy}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The parent of this `AccessPolicy` in the Cloud Resource Hierarchy. Currently immutable once
        /// created. Format: `organizations/{organization_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// The scopes of the AccessPolicy. Scopes define which resources a policy can restrict and where its resources
        /// can be referenced. For example, policy A with `scopes=["folders/123"]` has the following behavior: -
        /// ServicePerimeter can only restrict projects within `folders/123`. - ServicePerimeter within policy A can
        /// only reference access levels defined within policy A. - Only one policy can include a given scope; thus,
        /// attempting to create a second policy which includes `folders/123` will result in an error. If no scopes are
        /// provided, then any resource within the organization can be restricted. Scopes cannot be modified after a
        /// policy is created. Policies can only have a single scope. Format: list of `folders/{folder_number}` or
        /// `projects/{project_number}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<string> Scopes { get; set; }

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
        /// Whether to negate the Condition. If true, the Condition becomes a NAND over its non-empty fields. Any
        /// non-empty field criteria evaluating to false will result in the Condition to be satisfied. Defaults to
        /// false.
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

        /// <summary>
        /// The request must originate from one of the provided VPC networks in Google Cloud. Cannot specify this field
        /// together with `ip_subnetworks`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcNetworkSources")]
        public virtual System.Collections.Generic.IList<GoogleIdentityAccesscontextmanagerV1VpcNetworkSource> VpcNetworkSources { get; set; }

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
        /// A list of identities that are allowed access through [EgressPolicy]. Identities can be an individual user,
        /// service account, Google group, or third-party identity. For third-party identity, only single identities are
        /// supported and other identity types are not supported. The `v1` identities that have the prefix `user`,
        /// `group`, `serviceAccount`, and `principal` in https://cloud.google.com/iam/docs/principal-identifiers#v1 are
        /// supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identities")]
        public virtual System.Collections.Generic.IList<string> Identities { get; set; }

        /// <summary>
        /// Specifies the type of identities that are allowed access to outside the perimeter. If left unspecified, then
        /// members of `identities` field will be allowed access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityType")]
        public virtual string IdentityType { get; set; }

        /// <summary>
        /// Whether to enforce traffic restrictions based on `sources` field. If the `sources` fields is non-empty, then
        /// this field must be set to `SOURCE_RESTRICTION_ENABLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceRestriction")]
        public virtual string SourceRestriction { get; set; }

        /// <summary>
        /// Sources that this EgressPolicy authorizes access from. If this field is not empty, then `source_restriction`
        /// must be set to `SOURCE_RESTRICTION_ENABLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<GoogleIdentityAccesscontextmanagerV1EgressSource> Sources { get; set; }

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

        /// <summary>
        /// Optional. Human-readable title for the egress rule. The title must be unique within the perimeter and can
        /// not exceed 100 characters. Within the access policy, the combined length of all rule titles must not exceed
        /// 240,000 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The source that EgressPolicy authorizes access from inside the ServicePerimeter to somewhere outside the
    /// ServicePerimeter boundaries.
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1EgressSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An AccessLevel resource name that allows protected resources inside the ServicePerimeters to access outside
        /// the ServicePerimeter boundaries. AccessLevels listed must be in the same policy as this ServicePerimeter.
        /// Referencing a nonexistent AccessLevel will cause an error. If an AccessLevel name is not specified, only
        /// resources within the perimeter can be accessed through Google Cloud calls with request origins within the
        /// perimeter. Example: `accessPolicies/MY_POLICY/accessLevels/MY_LEVEL`. If a single `*` is specified for
        /// `access_level`, then all EgressSources will be allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLevel")]
        public virtual string AccessLevel { get; set; }

        /// <summary>
        /// A Google Cloud resource from the service perimeter that you want to allow to access data outside the
        /// perimeter. This field supports only projects. The project format is `projects/{project_number}`. You can't
        /// use `*` in this field to allow all Google Cloud resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

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
        /// A list of external resources that are allowed to be accessed. Only AWS and Azure resources are supported.
        /// For Amazon S3, the supported formats are s3://BUCKET_NAME, s3a://BUCKET_NAME, and s3n://BUCKET_NAME. For
        /// Azure Storage, the supported format is azure://myaccount.blob.core.windows.net/CONTAINER_NAME. A request
        /// matches if it contains an external resource in this list (Example: s3://bucket/path). Currently '*' is not
        /// allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalResources")]
        public virtual System.Collections.Generic.IList<string> ExternalResources { get; set; }

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

        /// <summary>
        /// IAM roles that represent the set of operations that the sources specified in the corresponding EgressFrom.
        /// are allowed to perform in this ServicePerimeter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roles")]
        public virtual System.Collections.Generic.IList<string> Roles { get; set; }

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
        /// A list of identities that are allowed access through [IngressPolicy]. Identities can be an individual user,
        /// service account, Google group, or third-party identity. For third-party identity, only single identities are
        /// supported and other identity types are not supported. The `v1` identities that have the prefix `user`,
        /// `group`, `serviceAccount`, and `principal` in https://cloud.google.com/iam/docs/principal-identifiers#v1 are
        /// supported.
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

        /// <summary>
        /// Optional. Human-readable title for the ingress rule. The title must be unique within the perimeter and can
        /// not exceed 100 characters. Within the access policy, the combined length of all rule titles must not exceed
        /// 240,000 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

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
        /// allowed to access perimeter data. Currently only projects and VPCs are allowed. Project format:
        /// `projects/{project_number}` VPC network format:
        /// `//compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}`. The project may be in any Google
        /// Cloud organization, not just the organization that the perimeter is defined in. `*` is not allowed, the case
        /// of allowing all Google Cloud resources only is not supported.
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

        /// <summary>
        /// IAM roles that represent the set of operations that the sources specified in the corresponding IngressFrom
        /// are allowed to perform in this ServicePerimeter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roles")]
        public virtual System.Collections.Generic.IList<string> Roles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An allowed method or permission of a service specified in ApiOperation.</summary>
    public class GoogleIdentityAccesscontextmanagerV1MethodSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A valid method name for the corresponding `service_name` in ApiOperation. If `*` is used as the value for
        /// the `method`, then ALL methods and permissions are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; }

        /// <summary>A valid Cloud IAM permission for the corresponding `service_name` in ApiOperation.</summary>
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
    /// cannot overlap, a single Google Cloud project or VPC network can only belong to a single regular Service
    /// Perimeter. Service Perimeter Bridges can contain only Google Cloud projects as members, a single Google Cloud
    /// project may belong to multiple Service Perimeter Bridges.
    /// </summary>
    public class GoogleIdentityAccesscontextmanagerV1ServicePerimeter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the `ServicePerimeter` and its use. Does not affect behavior.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. An opaque identifier for the current version of the `ServicePerimeter`. This identifier does not
        /// follow any specific format. If an etag is not provided, the operation will be performed as if a valid etag
        /// is provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Identifier. Resource name for the `ServicePerimeter`. Format:
        /// `accessPolicies/{access_policy}/servicePerimeters/{service_perimeter}`. The `service_perimeter` component
        /// must begin with a letter, followed by alphanumeric characters or `_`. After you create a `ServicePerimeter`,
        /// you cannot change its `name`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Perimeter type indicator. A single project or VPC network is allowed to be a member of single regular
        /// perimeter, but multiple service perimeter bridges. A project cannot be a included in a perimeter bridge
        /// without being included in regular perimeter. For perimeter bridges, the restricted service list as well as
        /// access level lists must be empty.
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
        /// A list of Google Cloud resources that are inside of the service perimeter. Currently only projects and VPCs
        /// are allowed. Project format: `projects/{project_number}` VPC network format:
        /// `//compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}`.
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

    /// <summary>The originating network source in Google Cloud.</summary>
    public class GoogleIdentityAccesscontextmanagerV1VpcNetworkSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Sub-segment ranges of a VPC network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcSubnetwork")]
        public virtual GoogleIdentityAccesscontextmanagerV1VpcSubNetwork VpcSubnetwork { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sub-segment ranges inside of a VPC Network.</summary>
    public class GoogleIdentityAccesscontextmanagerV1VpcSubNetwork : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Network name. If the network is not part of the organization, the `compute.network.get` permission
        /// must be granted to the caller. Format:
        /// `//compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NETWORK_NAME}` Example:
        /// `//compute.googleapis.com/projects/my-project/global/networks/network-1`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>
        /// CIDR block IP subnetwork specification. The IP address must be an IPv4 address and can be a public or
        /// private IP address. Note that for a CIDR IP address block, the specified IP address portion must be properly
        /// truncated (i.e. all the host bits must be zero) or the input is considered malformed. For example,
        /// "192.0.2.0/24" is accepted but "192.0.2.1/24" is not. If empty, all IP addresses are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcIpSubnetworks")]
        public virtual System.Collections.Generic.IList<string> VpcIpSubnetworks { get; set; }

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

    /// <summary>IAM policy analysis query message.</summary>
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
        /// "projects/12345"). To know how to get organization ID, visit [here
        /// ](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).
        /// To know how to get folder or project ID, visit [here
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

        /// <summary>The IAM policy binding under analysis.</summary>
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
        /// The project that the associated Google Cloud resource belongs to, in the form of projects/{PROJECT_NUMBER}.
        /// If an IAM policy is set on a resource (like VM instance, Cloud Storage bucket), the project field will
        /// indicate the project that contains the resource. If an IAM policy is set on a folder or organization, this
        /// field will be empty. To search against the `project`: * specify the `scope` field as this project in your
        /// search request.
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
        /// Required. The identity appear in the form of principals in [IAM policy
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

    /// <summary>
    /// This API resource represents the available inventory data for a Compute Engine virtual machine (VM) instance at
    /// a given point in time. You can use this API resource to determine the inventory data of your VM. For more
    /// information, see [Information provided by OS inventory
    /// management](https://cloud.google.com/compute/docs/instances/os-inventory-management#data-collected).
    /// </summary>
    public class Inventory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Inventory items related to the VM keyed by an opaque unique identifier for each inventory item. The
        /// identifier is unique to each distinct and addressable inventory item and will change, when there is a new
        /// package version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IDictionary<string, Item> Items { get; set; }

        /// <summary>
        /// Output only. The `Inventory` API resource name. Format:
        /// `projects/{project_number}/locations/{location}/instances/{instance_id}/inventory`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Base level operating system information for the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osInfo")]
        public virtual OsInfo OsInfo { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Timestamp of the last reported inventory for the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single piece of inventory on a VM.</summary>
    public class Item : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Software package available to be installed on the VM instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availablePackage")]
        public virtual SoftwarePackage AvailablePackage { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>When this inventory item was first detected.</summary>
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

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>When this inventory item was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

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

        private string _readTimeRaw;

        private object _readTime;

        /// <summary>Time the snapshot was taken.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual string ReadTimeRaw
        {
            get => _readTimeRaw;
            set
            {
                _readTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _readTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeDateTimeOffset instead.")]
        public virtual object ReadTime
        {
            get => _readTime;
            set
            {
                _readTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _readTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReadTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReadTimeRaw);
            set => ReadTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

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

    /// <summary>Response of listing saved queries.</summary>
    public class ListSavedQueriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of savedQueries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("savedQueries")]
        public virtual System.Collections.Generic.IList<SavedQuery> SavedQueries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message to group the analysis information.</summary>
    public class MoveAnalysis : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Analysis result of moving the target resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysis")]
        public virtual MoveAnalysisResult Analysis { get; set; }

        /// <summary>The user friendly display name of the analysis. E.g. IAM, organization policy etc.</summary>
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
        /// The normal, successful response of the operation. If the original method returns no data on success, such as
        /// `Delete`, the response is `google.protobuf.Empty`. If the original method is standard
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
        /// highly recommend you use AssetService.AnalyzeIamPolicyLongrunning RPC instead. For example, if the request
        /// analyzes for which resources user A has permission P, and there's an IAM policy states user A has
        /// iam.serviceAccounts.getAccessToken permission to a service account SA, and there's another IAM policy states
        /// service account SA has permission P to a Google Cloud folder F, then user A potentially has access to the
        /// Google Cloud folder F. And those advanced analysis results will be included in
        /// AnalyzeIamPolicyResponse.service_account_impersonation_analysis. Another example, if the request analyzes
        /// for who has permission P to a Google Cloud folder F, and there's an IAM policy states user A has
        /// iam.serviceAccounts.actAs permission to a service account SA, and there's another IAM policy states service
        /// account SA has permission P to the Google Cloud folder F, then user A potentially has access to the Google
        /// Cloud folder F. And those advanced analysis results will be included in
        /// AnalyzeIamPolicyResponse.service_account_impersonation_analysis. Only the following permissions are
        /// considered in this analysis: * `iam.serviceAccounts.actAs` * `iam.serviceAccounts.signBlob` *
        /// `iam.serviceAccounts.signJwt` * `iam.serviceAccounts.getAccessToken` * `iam.serviceAccounts.getOpenIdToken`
        /// * `iam.serviceAccounts.implicitDelegation` Default is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyzeServiceAccountImpersonation")]
        public virtual System.Nullable<bool> AnalyzeServiceAccountImpersonation { get; set; }

        /// <summary>
        /// Optional. If true, the identities section of the result will expand any Google groups appearing in an IAM
        /// policy binding. If IamPolicyAnalysisQuery.identity_selector is specified, the identity in the result will be
        /// determined by the selector, and this flag is not allowed to set. If true, the default max expansion per
        /// group is 1000 for AssetService.AnalyzeIamPolicy][]. Default is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expandGroups")]
        public virtual System.Nullable<bool> ExpandGroups { get; set; }

        /// <summary>
        /// Optional. If true and IamPolicyAnalysisQuery.resource_selector is not specified, the resource section of the
        /// result will expand any resource attached to an IAM policy to include resources lower in the resource
        /// hierarchy. For example, if the request analyzes for which resources user A has permission P, and the results
        /// include an IAM policy with P on a Google Cloud folder, the results will also include resources in that
        /// folder with permission P. If true and IamPolicyAnalysisQuery.resource_selector is specified, the resource
        /// section of the result will expand the specified resource to include resources lower in the resource
        /// hierarchy. Only project or lower resources are supported. Folder and organization resources cannot be used
        /// together with this option. For example, if the request analyzes for which users have permission P on a
        /// Google Cloud project with this option enabled, the results will include all users who have permission P on
        /// that project or any lower resource. If true, the default max expansion per resource is 1000 for
        /// AssetService.AnalyzeIamPolicy][] and 100000 for AssetService.AnalyzeIamPolicyLongrunning][]. Default is
        /// false.
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
        /// Optional. If true, the result will output the relevant membership relationships between groups and other
        /// groups, and between groups and principals. Default is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputGroupEdges")]
        public virtual System.Nullable<bool> OutputGroupEdges { get; set; }

        /// <summary>
        /// Optional. If true, the result will output the relevant parent/child relationships between resources. Default
        /// is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputResourceEdges")]
        public virtual System.Nullable<bool> OutputResourceEdges { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The organization policy result to the query.</summary>
    public class OrgPolicyResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The consolidated organization policy for the analyzed resource. The consolidated organization policy is
        /// computed by merging and evaluating policy_bundle. The evaluation will respect the organization policy
        /// [hierarchy
        /// rules](https://cloud.google.com/resource-manager/docs/organization-policy/understanding-hierarchy).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consolidatedPolicy")]
        public virtual AnalyzerOrgPolicy ConsolidatedPolicy { get; set; }

        /// <summary>
        /// The folder(s) that this consolidated policy belongs to, in the format of folders/{FOLDER_NUMBER}. This field
        /// is available when the consolidated policy belongs (directly or cascadingly) to one or more folders.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folders")]
        public virtual System.Collections.Generic.IList<string> Folders { get; set; }

        /// <summary>
        /// The organization that this consolidated policy belongs to, in the format of
        /// organizations/{ORGANIZATION_NUMBER}. This field is available when the consolidated policy belongs (directly
        /// or cascadingly) to an organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual string Organization { get; set; }

        /// <summary>
        /// The ordered list of all organization policies from the consolidated_policy.attached_resource. to the scope
        /// specified in the request. If the constraint is defined with default policy, it will also appear in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyBundle")]
        public virtual System.Collections.Generic.IList<AnalyzerOrgPolicy> PolicyBundle { get; set; }

        /// <summary>
        /// The project that this consolidated policy belongs to, in the format of projects/{PROJECT_NUMBER}. This field
        /// is available when the consolidated policy belongs to a project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

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
        /// Destination on BigQuery. The output table stores the fields in asset Protobuf as columns in BigQuery.
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
    /// `Policy` is a collection of `bindings`. A `binding` binds one or more `members`, or principals, to a single
    /// `role`. Principals can be user accounts, service accounts, Google groups, and domains (such as G Suite). A
    /// `role` is a named list of permissions; each `role` can be an IAM predefined role or a user-created custom role.
    /// For some types of Google Cloud resources, a `binding` can also specify a `condition`, which is a logical
    /// expression that allows access to a resource only if the expression evaluates to `true`. A condition can add
    /// constraints based on attributes of the request, the resource, or both. To learn which resources support
    /// conditions in their IAM policies, see the [IAM
    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:**
    /// ```
    /// {
    /// "bindings": [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 }
    /// ```
    /// **YAML
    /// example:**
    /// ```
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') etag: BwWWja0YfJA= version: 3
    /// ```
    /// For a description of IAM and its
    /// features, see the [IAM documentation](https://cloud.google.com/iam/docs/).
    /// </summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<AuditConfig> AuditConfigs { get; set; }

        /// <summary>
        /// Associates a list of `members`, or principals, with a `role`. Optionally, may specify a `condition` that
        /// determines how and when the `bindings` are applied. Each of the `bindings` must contain at least one
        /// principal. The `bindings` in a `Policy` can refer to up to 1,500 principals; up to 250 of these principals
        /// can be Google groups. Each occurrence of a principal counts towards these limits. For example, if the
        /// `bindings` grant 50 different roles to `user:alice@example.com`, and not to any other principal, then you
        /// can add another 1,450 principals to the `bindings` in the `Policy`.
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

    /// <summary>The IAM policy and its attached resource.</summary>
    public class PolicyInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The full resource name the policy is directly attached to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachedResource")]
        public virtual string AttachedResource { get; set; }

        /// <summary>The IAM policy that's directly attached to the attached_resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
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

    /// <summary>Output configuration query assets.</summary>
    public class QueryAssetsOutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>BigQuery destination where the query results will be saved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryDestination")]
        public virtual GoogleCloudAssetV1QueryAssetsOutputConfigBigQueryDestination BigqueryDestination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>QueryAssets request.</summary>
    public class QueryAssetsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Reference to the query job, which is from the `QueryAssetsResponse` of previous `QueryAssets`
        /// call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobReference")]
        public virtual string JobReference { get; set; }

        /// <summary>
        /// Optional. Destination where the query results will be saved. When this field is specified, the query results
        /// won't be saved in the [QueryAssetsResponse.query_result]. Instead [QueryAssetsResponse.output_config] will
        /// be set. Meanwhile, [QueryAssetsResponse.job_reference] will be set and can be used to check the status of
        /// the query job when passed to a following [QueryAssets] API call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual QueryAssetsOutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Optional. The maximum number of rows to return in the results. Responses are limited to 10 MB and 1000 rows.
        /// By default, the maximum row count is 1000. When the byte or row count limit is reached, the rest of the
        /// query results will be paginated. The field will be ignored when [output_config] is specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// Optional. A page token received from previous `QueryAssets`. The field will be ignored when [output_config]
        /// is specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        private string _readTimeRaw;

        private object _readTime;

        /// <summary>Optional. Queries cloud assets as they appeared at the specified point in time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual string ReadTimeRaw
        {
            get => _readTimeRaw;
            set
            {
                _readTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _readTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeDateTimeOffset instead.")]
        public virtual object ReadTime
        {
            get => _readTime;
            set
            {
                _readTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _readTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReadTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReadTimeRaw);
            set => ReadTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. [start_time] is required. [start_time] must be less than [end_time] Defaults [end_time] to now if
        /// [start_time] is set and [end_time] isn't. Maximum permitted time range is 7 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTimeWindow")]
        public virtual TimeWindow ReadTimeWindow { get; set; }

        /// <summary>
        /// Optional. A SQL statement that's compatible with [BigQuery
        /// SQL](https://cloud.google.com/bigquery/docs/introduction-sql).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statement")]
        public virtual string Statement { get; set; }

        /// <summary>
        /// Optional. Specifies the maximum amount of time that the client is willing to wait for the query to complete.
        /// By default, this limit is 5 min for the first query, and 1 minute for the following queries. If the query is
        /// complete, the `done` field in the `QueryAssetsResponse` is true, otherwise false. Like BigQuery [jobs.query
        /// API](https://cloud.google.com/bigquery/docs/reference/rest/v2/jobs/query#queryrequest) The call is not
        /// guaranteed to wait for the specified timeout; it typically returns after around 200 seconds (200,000
        /// milliseconds), even if the query is not complete. The field will be ignored when [output_config] is
        /// specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>QueryAssets response.</summary>
    public class QueryAssetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The query response, which can be either an `error` or a valid `response`. If `done` == `false` and the query
        /// result is being saved in an output, the output_config field will be set. If `done` == `true`, exactly one of
        /// `error`, `query_result` or `output_config` will be set. [done] is unset unless the [QueryAssetsResponse]
        /// contains a [QueryAssetsResponse.job_reference].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>Error status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>Reference to a query job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobReference")]
        public virtual string JobReference { get; set; }

        /// <summary>
        /// Output configuration, which indicates that instead of being returned in an API response on the fly, the
        /// query result will be saved in a specific output.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual QueryAssetsOutputConfig OutputConfig { get; set; }

        /// <summary>Result of the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryResult")]
        public virtual QueryResult QueryResult { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The query content.</summary>
    public class QueryContent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An IAM Policy Analysis query, which could be used in the AssetService.AnalyzeIamPolicy RPC or the
        /// AssetService.AnalyzeIamPolicyLongrunning RPC.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iamPolicyAnalysisQuery")]
        public virtual IamPolicyAnalysisQuery IamPolicyAnalysisQuery { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Execution results of the query. The result is formatted as rows represented by BigQuery compatible [schema].
    /// When pagination is necessary, it will contains the page token to retrieve the results of following pages.
    /// </summary>
    public class QueryResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Token to retrieve the next page of the results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Each row hold a query result in the format of `Struct`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Rows { get; set; }

        /// <summary>Describes the format of the [rows].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual TableSchema Schema { get; set; }

        /// <summary>Total rows of the whole query results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalRows")]
        public virtual System.Nullable<long> TotalRows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An asset identifier in Google Cloud which contains its name, type and ancestors. An asset can be any resource in
    /// the Google Cloud [resource
    /// hierarchy](https://cloud.google.com/resource-manager/docs/cloud-platform-resource-hierarchy), a resource outside
    /// the Google Cloud resource hierarchy (such as Google Kubernetes Engine clusters and objects), or a policy (e.g.
    /// IAM policy). See [Supported asset types](https://cloud.google.com/asset-inventory/docs/supported-asset-types)
    /// for more information.
    /// </summary>
    public class RelatedAsset : Google.Apis.Requests.IDirectResponseSchema
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

        /// <summary>The unique identifier of the relationship type. Example: `INSTANCE_TO_INSTANCEGROUP`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relationshipType")]
        public virtual string RelationshipType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// DEPRECATED. This message only presents for the purpose of backward-compatibility. The server will never populate
    /// this message in responses. The detailed related assets with the `relationship_type`.
    /// </summary>
    public class RelatedAssets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The peer resources of the relationship.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assets")]
        public virtual System.Collections.Generic.IList<RelatedAsset> Assets { get; set; }

        /// <summary>The detailed relationship attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relationshipAttributes")]
        public virtual RelationshipAttributes RelationshipAttributes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The detailed related resource.</summary>
    public class RelatedResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of the asset. Example: `compute.googleapis.com/Instance`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetType")]
        public virtual string AssetType { get; set; }

        /// <summary>
        /// The full resource name of the related resource. Example:
        /// `//compute.googleapis.com/projects/my_proj_123/zones/instance/instance123`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The related resources of the primary resource.</summary>
    public class RelatedResources : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The detailed related resources of the primary resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedResources")]
        public virtual System.Collections.Generic.IList<RelatedResource> RelatedResourcesValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// DEPRECATED. This message only presents for the purpose of backward-compatibility. The server will never populate
    /// this message in responses. The relationship attributes which include `type`, `source_resource_type`,
    /// `target_resource_type` and `action`.
    /// </summary>
    public class RelationshipAttributes : Google.Apis.Requests.IDirectResponseSchema
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
        /// Google Cloud assets, this value is the parent resource defined in the [IAM policy
        /// hierarchy](https://cloud.google.com/iam/docs/overview#policy_hierarchy). Example:
        /// `//cloudresourcemanager.googleapis.com/projects/my_project_123`
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

    /// <summary>The resource owners information.</summary>
    public class ResourceOwners : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of resource owners.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceOwners")]
        public virtual System.Collections.Generic.IList<string> ResourceOwnersValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A result of Resource Search, containing information of a cloud resource.</summary>
    public class ResourceSearchResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The additional searchable attributes of this resource. The attributes may vary from one resource type to
        /// another. Examples: `projectId` for Project, `dnsName` for DNS ManagedZone. This field contains a subset of
        /// the resource metadata fields that are returned by the List or Get APIs provided by the corresponding Google
        /// Cloud service (e.g., Compute Engine). see [API references and supported searchable
        /// attributes](https://cloud.google.com/asset-inventory/docs/supported-asset-types) to see which fields are
        /// included. You can search values of these fields through free text search. However, you should not consume
        /// the field programically as the field names and values may change as the Google Cloud service updates to a
        /// new incompatible API version. To search against the `additional_attributes`: * Use a free text query to
        /// match the attributes values. Example: to search `additional_attributes = { dnsName: "foobar" }`, you can
        /// issue a query `foobar`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalAttributes")]
        public virtual System.Collections.Generic.IDictionary<string, object> AdditionalAttributes { get; set; }

        /// <summary>
        /// The type of this resource. Example: `compute.googleapis.com/Disk`. To search against the `asset_type`: *
        /// Specify the `asset_type` field in your search request.
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

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// The create timestamp of this resource, at which the resource was created. The granularity is in seconds.
        /// Timestamp.nanos will always be 0. This field is available only when the resource's Protobuf contains it. To
        /// search against `create_time`: * Use a field query. - value in seconds since unix epoch. Example: `createTime
        /// &amp;gt; 1609459200` - value in date string. Example: `createTime &amp;gt; 2021-01-01` - value in date-time
        /// string (must be quoted). Example: `createTime &amp;gt; "2021-01-01T00:00:00"`
        /// </summary>
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
        /// One or more paragraphs of text description of this resource. Maximum length could be up to 1M bytes. This
        /// field is available only when the resource's Protobuf contains it. To search against the `description`: * Use
        /// a field query. Example: `description:"important instance"` * Use a free text query. Example: `"important
        /// instance"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The display name of this resource. This field is available only when the resource's Protobuf contains it. To
        /// search against the `display_name`: * Use a field query. Example: `displayName:"My Instance"` * Use a free
        /// text query. Example: `"My Instance"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The effective tags on this resource. All of the tags that are both attached to and inherited by a resource
        /// are collectively called the effective tags. For more information, see [tag
        /// inheritance](https://cloud.google.com/resource-manager/docs/tags/tags-overview#inheritance). To search
        /// against the `effective_tags`: * Use a field query. Example: - `effectiveTagKeys:"123456789/env*"` -
        /// `effectiveTagKeys="123456789/env"` - `effectiveTagKeys:"env"` - `effectiveTagKeyIds="tagKeys/123"` -
        /// `effectiveTagValues:"env"` - `effectiveTagValues:"env/prod"` - `effectiveTagValues:"123456789/env/prod*"` -
        /// `effectiveTagValues="123456789/env/prod"` - `effectiveTagValueIds="tagValues/456"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveTags")]
        public virtual System.Collections.Generic.IList<EffectiveTagDetails> EffectiveTags { get; set; }

        /// <summary>
        /// Enrichments of the asset. Currently supported enrichment types with SearchAllResources API: *
        /// RESOURCE_OWNERS The corresponding read masks in order to get the enrichment: * enrichments.resource_owners
        /// The corresponding required permissions: * cloudasset.assets.searchEnrichmentResourceOwners Example query to
        /// get resource owner enrichment:
        /// ```
        /// scope: "projects/my-project" query: "name: my-project" assetTypes:
        /// "cloudresourcemanager.googleapis.com/Project" readMask: { paths: "asset_type" paths: "name" paths:
        /// "enrichments.resource_owners" }
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enrichments")]
        public virtual System.Collections.Generic.IList<AssetEnrichment> Enrichments { get; set; }

        /// <summary>
        /// The folder(s) that this resource belongs to, in the form of folders/{FOLDER_NUMBER}. This field is available
        /// when the resource belongs to one or more folders. To search against `folders`: * Use a field query. Example:
        /// `folders:(123 OR 456)` * Use a free text query. Example: `123` * Specify the `scope` field as this folder in
        /// your search request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folders")]
        public virtual System.Collections.Generic.IList<string> Folders { get; set; }

        /// <summary>
        /// The Cloud KMS
        /// [CryptoKey](https://cloud.google.com/kms/docs/reference/rest/v1/projects.locations.keyRings.cryptoKeys) name
        /// or
        /// [CryptoKeyVersion](https://cloud.google.com/kms/docs/reference/rest/v1/projects.locations.keyRings.cryptoKeys.cryptoKeyVersions)
        /// name. This field only presents for the purpose of backward compatibility. Use the `kms_keys` field to
        /// retrieve Cloud KMS key information. This field is available only when the resource's Protobuf contains it
        /// and will only be populated for [these resource
        /// types](https://cloud.google.com/asset-inventory/docs/legacy-field-names#resource_types_with_the_to_be_deprecated_kmskey_field)
        /// for backward compatible purposes. To search against the `kms_key`: * Use a field query. Example:
        /// `kmsKey:key` * Use a free text query. Example: `key`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKey")]
        public virtual string KmsKey { get; set; }

        /// <summary>
        /// The Cloud KMS
        /// [CryptoKey](https://cloud.google.com/kms/docs/reference/rest/v1/projects.locations.keyRings.cryptoKeys)
        /// names or
        /// [CryptoKeyVersion](https://cloud.google.com/kms/docs/reference/rest/v1/projects.locations.keyRings.cryptoKeys.cryptoKeyVersions)
        /// names. This field is available only when the resource's Protobuf contains it. To search against the
        /// `kms_keys`: * Use a field query. Example: `kmsKeys:key` * Use a free text query. Example: `key`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeys")]
        public virtual System.Collections.Generic.IList<string> KmsKeys { get; set; }

        /// <summary>
        /// User labels associated with this resource. See [Labelling and grouping Google Cloud
        /// resources](https://cloud.google.com/blog/products/gcp/labelling-and-grouping-your-google-cloud-platform-resources)
        /// for more information. This field is available only when the resource's Protobuf contains it. To search
        /// against the `labels`: * Use a field query: - query on any label's key or value. Example: `labels:prod` -
        /// query by a given label. Example: `labels.env:prod` - query by a given label's existence. Example:
        /// `labels.env:*` * Use a free text query. Example: `prod`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Location can be `global`, regional like `us-east1`, or zonal like `us-west1-b`. This field is available only
        /// when the resource's Protobuf contains it. To search against the `location`: * Use a field query. Example:
        /// `location:us-west*` * Use a free text query. Example: `us-west*`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// The full resource name of this resource. Example:
        /// `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1`. See [Cloud Asset
        /// Inventory Resource Name Format](https://cloud.google.com/asset-inventory/docs/resource-name-format) for more
        /// information. To search against the `name`: * Use a field query. Example: `name:instance1` * Use a free text
        /// query. Example: `instance1`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Network tags associated with this resource. Like labels, network tags are a type of annotations used to
        /// group Google Cloud resources. See [Labelling Google Cloud
        /// resources](https://cloud.google.com/blog/products/gcp/labelling-and-grouping-your-google-cloud-platform-resources)
        /// for more information. This field is available only when the resource's Protobuf contains it. To search
        /// against the `network_tags`: * Use a field query. Example: `networkTags:internal` * Use a free text query.
        /// Example: `internal`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkTags")]
        public virtual System.Collections.Generic.IList<string> NetworkTags { get; set; }

        /// <summary>
        /// The organization that this resource belongs to, in the form of organizations/{ORGANIZATION_NUMBER}. This
        /// field is available when the resource belongs to an organization. To search against `organization`: * Use a
        /// field query. Example: `organization:123` * Use a free text query. Example: `123` * Specify the `scope` field
        /// as this organization in your search request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual string Organization { get; set; }

        /// <summary>
        /// The type of this resource's immediate parent, if there is one. To search against the `parent_asset_type`: *
        /// Use a field query. Example: `parentAssetType:"cloudresourcemanager.googleapis.com/Project"` * Use a free
        /// text query. Example: `cloudresourcemanager.googleapis.com/Project`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentAssetType")]
        public virtual string ParentAssetType { get; set; }

        /// <summary>
        /// The full resource name of this resource's parent, if it has one. To search against the
        /// `parent_full_resource_name`: * Use a field query. Example: `parentFullResourceName:"project-name"` * Use a
        /// free text query. Example: `project-name`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentFullResourceName")]
        public virtual string ParentFullResourceName { get; set; }

        /// <summary>
        /// The project that this resource belongs to, in the form of projects/{PROJECT_NUMBER}. This field is available
        /// when the resource belongs to a project. To search against `project`: * Use a field query. Example:
        /// `project:12345` * Use a free text query. Example: `12345` * Specify the `scope` field as this project in
        /// your search request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>
        /// A map of related resources of this resource, keyed by the relationship type. A relationship type is in the
        /// format of {SourceType}_{ACTION}_{DestType}. Example: `DISK_TO_INSTANCE`, `DISK_TO_NETWORK`,
        /// `INSTANCE_TO_INSTANCEGROUP`. See [supported relationship
        /// types](https://cloud.google.com/asset-inventory/docs/supported-asset-types#supported_relationship_types).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relationships")]
        public virtual System.Collections.Generic.IDictionary<string, RelatedResources> Relationships { get; set; }

        /// <summary>
        /// The actual content of Security Command Center security marks associated with the asset. To search against
        /// SCC SecurityMarks field: * Use a field query: - query by a given key value pair. Example:
        /// `sccSecurityMarks.foo=bar` - query by a given key's existence. Example: `sccSecurityMarks.foo:*`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sccSecurityMarks")]
        public virtual System.Collections.Generic.IDictionary<string, string> SccSecurityMarks { get; set; }

        /// <summary>
        /// The state of this resource. Different resources types have different state definitions that are mapped from
        /// various fields of different resource types. This field is available only when the resource's Protobuf
        /// contains it. Example: If the resource is an instance provided by Compute Engine, its state will include
        /// PROVISIONING, STAGING, RUNNING, STOPPING, SUSPENDING, SUSPENDED, REPAIRING, and TERMINATED. See `status`
        /// definition in [API Reference](https://cloud.google.com/compute/docs/reference/rest/v1/instances). If the
        /// resource is a project provided by Resource Manager, its state will include LIFECYCLE_STATE_UNSPECIFIED,
        /// ACTIVE, DELETE_REQUESTED and DELETE_IN_PROGRESS. See `lifecycleState` definition in [API
        /// Reference](https://cloud.google.com/resource-manager/reference/rest/v1/projects). To search against the
        /// `state`: * Use a field query. Example: `state:RUNNING` * Use a free text query. Example: `RUNNING`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// This field is only present for the purpose of backward compatibility. Use the `tags` field instead. TagKey
        /// namespaced names, in the format of {ORG_ID}/{TAG_KEY_SHORT_NAME}. To search against the `tagKeys`: * Use a
        /// field query. Example: - `tagKeys:"123456789/env*"` - `tagKeys="123456789/env"` - `tagKeys:"env"` * Use a
        /// free text query. Example: - `env`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagKeys")]
        public virtual System.Collections.Generic.IList<string> TagKeys { get; set; }

        /// <summary>
        /// This field is only present for the purpose of backward compatibility. Use the `tags` field instead. TagValue
        /// IDs, in the format of tagValues/{TAG_VALUE_ID}. To search against the `tagValueIds`: * Use a field query.
        /// Example: - `tagValueIds="tagValues/456"` * Use a free text query. Example: - `456`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagValueIds")]
        public virtual System.Collections.Generic.IList<string> TagValueIds { get; set; }

        /// <summary>
        /// This field is only present for the purpose of backward compatibility. Use the `tags` field instead. TagValue
        /// namespaced names, in the format of {ORG_ID}/{TAG_KEY_SHORT_NAME}/{TAG_VALUE_SHORT_NAME}. To search against
        /// the `tagValues`: * Use a field query. Example: - `tagValues:"env"` - `tagValues:"env/prod"` -
        /// `tagValues:"123456789/env/prod*"` - `tagValues="123456789/env/prod"` * Use a free text query. Example: -
        /// `prod`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagValues")]
        public virtual System.Collections.Generic.IList<string> TagValues { get; set; }

        /// <summary>
        /// The tags directly attached to this resource. To search against the `tags`: * Use a field query. Example: -
        /// `tagKeys:"123456789/env*"` - `tagKeys="123456789/env"` - `tagKeys:"env"` - `tagKeyIds="tagKeys/123"` -
        /// `tagValues:"env"` - `tagValues:"env/prod"` - `tagValues:"123456789/env/prod*"` -
        /// `tagValues="123456789/env/prod"` - `tagValueIds="tagValues/456"` * Use a free text query. Example: -
        /// `env/prod`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<Tag> Tags { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// The last update timestamp of this resource, at which the resource was last modified or deleted. The
        /// granularity is in seconds. Timestamp.nanos will always be 0. This field is available only when the
        /// resource's Protobuf contains it. To search against `update_time`: * Use a field query. - value in seconds
        /// since unix epoch. Example: `updateTime &amp;lt; 1609459200` - value in date string. Example: `updateTime
        /// &amp;lt; 2021-01-01` - value in date-time string (must be quoted). Example: `updateTime &amp;lt;
        /// "2021-01-01T00:00:00"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

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

    /// <summary>A saved query which can be shared with others or used later.</summary>
    public class SavedQuery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The query content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual QueryContent Content { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The create time of this saved query.</summary>
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

        /// <summary>Output only. The account's email address who has created this saved query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual string Creator { get; set; }

        /// <summary>The description of this saved query. This value should be fewer than 255 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Labels applied on the resource. This value should not contain more than 10 entries. The key and value of
        /// each entry must be non-empty and fewer than 64 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        private string _lastUpdateTimeRaw;

        private object _lastUpdateTime;

        /// <summary>Output only. The last update time of this saved query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateTime")]
        public virtual string LastUpdateTimeRaw
        {
            get => _lastUpdateTimeRaw;
            set
            {
                _lastUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastUpdateTimeDateTimeOffset instead.")]
        public virtual object LastUpdateTime
        {
            get => _lastUpdateTime;
            set
            {
                _lastUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastUpdateTimeRaw);
            set => LastUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The account's email address who has updated this saved query most recently.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdater")]
        public virtual string LastUpdater { get; set; }

        /// <summary>
        /// The resource name of the saved query. The format must be: *
        /// projects/project_number/savedQueries/saved_query_id * folders/folder_number/savedQueries/saved_query_id *
        /// organizations/organization_number/savedQueries/saved_query_id
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

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
        /// A list of IAM policies that match the search query. Related information such as the associated resource is
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

        /// <summary>Details of Windows Application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("windowsApplication")]
        public virtual WindowsApplication WindowsApplication { get; set; }

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

    /// <summary>A field in TableSchema.</summary>
    public class TableFieldSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The field name. The name must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_), and must
        /// start with a letter or underscore. The maximum length is 128 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        /// <summary>Describes the nested schema fields if the type property is set to RECORD.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<TableFieldSchema> Fields { get; set; }

        /// <summary>
        /// The field mode. Possible values include NULLABLE, REQUIRED and REPEATED. The default value is NULLABLE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>
        /// The field data type. Possible values include * STRING * BYTES * INTEGER * FLOAT * BOOLEAN * TIMESTAMP * DATE
        /// * TIME * DATETIME * GEOGRAPHY, * NUMERIC, * BIGNUMERIC, * RECORD (where RECORD indicates that the field
        /// contains a nested schema).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BigQuery Compatible table schema.</summary>
    public class TableSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Describes the fields in a table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<TableFieldSchema> Fields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The key and value for a [tag](https://cloud.google.com/resource-manager/docs/tags/tags-overview).
    /// </summary>
    public class Tag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>TagKey namespaced name, in the format of {ORG_ID}/{TAG_KEY_SHORT_NAME}.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagKey")]
        public virtual string TagKey { get; set; }

        /// <summary>TagKey ID, in the format of tagKeys/{TAG_KEY_ID}.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagKeyId")]
        public virtual string TagKeyId { get; set; }

        /// <summary>
        /// TagValue namespaced name, in the format of {ORG_ID}/{TAG_KEY_SHORT_NAME}/{TAG_VALUE_SHORT_NAME}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagValue")]
        public virtual string TagValue { get; set; }

        /// <summary>TagValue ID, in the format of tagValues/{TAG_VALUE_ID}.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagValueId")]
        public virtual string TagValueId { get; set; }

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
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>
        /// End time of the time window (inclusive). If not specified, the current timestamp is used instead.
        /// </summary>
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

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Start time of the time window (exclusive).</summary>
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
        /// `https://cloud.google.com/asset-inventory/docs/supported-asset-types`
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
    /// Contains information about a Windows application that is retrieved from the Windows Registry. For more
    /// information about these fields, see: https://docs.microsoft.com/en-us/windows/win32/msi/uninstall-registry-key
    /// </summary>
    public class WindowsApplication : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the application or product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The version of the product or application in string format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayVersion")]
        public virtual string DisplayVersion { get; set; }

        /// <summary>The internet address for technical support.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("helpLink")]
        public virtual string HelpLink { get; set; }

        /// <summary>
        /// The last time this product received service. The value of this property is replaced each time a patch is
        /// applied or removed from the product or the command-line option is used to repair the product.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installDate")]
        public virtual Date InstallDate { get; set; }

        /// <summary>The name of the manufacturer for the product or application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisher")]
        public virtual string Publisher { get; set; }

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

        private string _installTimeRaw;

        private object _installTime;

        /// <summary>Date that the QFE update was installed. Mapped from installed_on field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installTime")]
        public virtual string InstallTimeRaw
        {
            get => _installTimeRaw;
            set
            {
                _installTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _installTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="InstallTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use InstallTimeDateTimeOffset instead.")]
        public virtual object InstallTime
        {
            get => _installTime;
            set
            {
                _installTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _installTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="InstallTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? InstallTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(InstallTimeRaw);
            set => InstallTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

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

        private string _lastDeploymentChangeTimeRaw;

        private object _lastDeploymentChangeTime;

        /// <summary>The last published date of the update, in (UTC) date and time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastDeploymentChangeTime")]
        public virtual string LastDeploymentChangeTimeRaw
        {
            get => _lastDeploymentChangeTimeRaw;
            set
            {
                _lastDeploymentChangeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastDeploymentChangeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastDeploymentChangeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastDeploymentChangeTimeDateTimeOffset instead.")]
        public virtual object LastDeploymentChangeTime
        {
            get => _lastDeploymentChangeTime;
            set
            {
                _lastDeploymentChangeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastDeploymentChangeTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastDeploymentChangeTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastDeploymentChangeTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastDeploymentChangeTimeRaw);
            set => LastDeploymentChangeTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

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
