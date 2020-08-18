// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.CloudAsset.v1
{
    /// <summary>The CloudAsset Service.</summary>
    public class CloudAssetService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudAssetService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudAssetService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
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
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Asset API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

        }



        /// <summary>Gets the Feeds resource.</summary>
        public virtual FeedsResource Feeds { get; }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the V1 resource.</summary>
        public virtual V1Resource V1 { get; }
    }

    ///<summary>A base abstract class for CloudAsset requests.</summary>
    public abstract class CloudAssetBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new CloudAssetBaseServiceRequest instance.</summary>
        protected CloudAssetBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
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
            Value1,
            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,
            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters.</summary>
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

            RequestParameters.Add(
                "$.xgafv", new Google.Apis.Discovery.Parameter
                {
                    Name = "$.xgafv",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "access_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "access_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "callback", new Google.Apis.Discovery.Parameter
                {
                    Name = "callback",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "uploadType", new Google.Apis.Discovery.Parameter
                {
                    Name = "uploadType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "upload_protocol", new Google.Apis.Discovery.Parameter
                {
                    Name = "upload_protocol",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
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
        /// <param name="parent">Required. The name of the project/folder/organization where this feed should be created in. It
        /// can only be an organization number (such as "organizations/123"), a folder number (such as "folders/123"), a project
        /// ID (such as "projects/my-project-id")", or a project number (such as "projects/12345").</param>
        public virtual CreateRequest Create(Google.Apis.CloudAsset.v1.Data.CreateFeedRequest body, string parent)
        {
            return new CreateRequest(service, body, parent);
        }

        /// <summary>Creates a feed in a parent project/folder/organization to listen to its asset updates.</summary>
        public class CreateRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.Feed>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAsset.v1.Data.CreateFeedRequest body, string parent)
                : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }


            /// <summary>Required. The name of the project/folder/organization where this feed should be created in. It
            /// can only be an organization number (such as "organizations/123"), a folder number (such as
            /// "folders/123"), a project ID (such as "projects/my-project-id")", or a project number (such as
            /// "projects/12345").</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudAsset.v1.Data.CreateFeedRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "create";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}/feeds";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "parent", new Google.Apis.Discovery.Parameter
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
        /// <param name="name">Required. The name of the feed and it must be in the format of:
        /// projects/project_number/feeds/feed_id folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id</param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>Deletes an asset feed.</summary>
        public class DeleteRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name)
                : base(service)
            {
                Name = name;
                InitParameters();
            }


            /// <summary>Required. The name of the feed and it must be in the format of:
            /// projects/project_number/feeds/feed_id folders/folder_number/feeds/feed_id
            /// organizations/organization_number/feeds/feed_id</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "name", new Google.Apis.Discovery.Parameter
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
        /// <param name="name">Required. The name of the Feed and it must be in the format of:
        /// projects/project_number/feeds/feed_id folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Gets details about an asset feed.</summary>
        public class GetRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.Feed>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name)
                : base(service)
            {
                Name = name;
                InitParameters();
            }


            /// <summary>Required. The name of the Feed and it must be in the format of:
            /// projects/project_number/feeds/feed_id folders/folder_number/feeds/feed_id
            /// organizations/organization_number/feeds/feed_id</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "name", new Google.Apis.Discovery.Parameter
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
        /// <param name="parent">Required. The parent project/folder/organization whose feeds are to be listed. It can only be
        /// using project/folder/organization number (such as "folders/12345")", or a project ID (such as "projects/my-project-
        /// id").</param>
        public virtual ListRequest List(string parent)
        {
            return new ListRequest(service, parent);
        }

        /// <summary>Lists all asset feeds in a parent project/folder/organization.</summary>
        public class ListRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.ListFeedsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string parent)
                : base(service)
            {
                Parent = parent;
                InitParameters();
            }


            /// <summary>Required. The parent project/folder/organization whose feeds are to be listed. It can only be
            /// using project/folder/organization number (such as "folders/12345")", or a project ID (such as "projects
            /// /my-project-id").</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}/feeds";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "parent", new Google.Apis.Discovery.Parameter
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
        /// <param name="name">Required. The format will be projects/{project_number}/feeds/{client-assigned_feed_identifier} or
        /// folders/{folder_number}/feeds/{client-assigned_feed_identifier} or organizations/{organization_number}/feeds
        /// /{client-assigned_feed_identifier} The client-assigned feed identifier must be unique within the parent
        /// project/folder/organization.</param>
        public virtual PatchRequest Patch(Google.Apis.CloudAsset.v1.Data.UpdateFeedRequest body, string name)
        {
            return new PatchRequest(service, body, name);
        }

        /// <summary>Updates an asset feed configuration.</summary>
        public class PatchRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.Feed>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAsset.v1.Data.UpdateFeedRequest body, string name)
                : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }


            /// <summary>Required. The format will be projects/{project_number}/feeds/{client-assigned_feed_identifier}
            /// or folders/{folder_number}/feeds/{client-assigned_feed_identifier} or
            /// organizations/{organization_number}/feeds/{client-assigned_feed_identifier} The client-assigned feed
            /// identifier must be unique within the parent project/folder/organization.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudAsset.v1.Data.UpdateFeedRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "name", new Google.Apis.Discovery.Parameter
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


        /// <summary>Gets the latest state of a long-running operation. Clients can use this method to poll the
        /// operation result at intervals as recommended by the API service.</summary>
        /// <param name="name">The name of the operation resource.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Gets the latest state of a long-running operation. Clients can use this method to poll the
        /// operation result at intervals as recommended by the API service.</summary>
        public class GetRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.Operation>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name)
                : base(service)
            {
                Name = name;
                InitParameters();
            }


            /// <summary>The name of the operation resource.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "name", new Google.Apis.Discovery.Parameter
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


        /// <summary>Batch gets the update history of assets that overlap a time window. For IAM_POLICY content, this
        /// API outputs history when the asset and its attached IAM POLICY both exist. This can create gaps in the
        /// output history. Otherwise, this API outputs history with asset in both non-delete or deleted status. If a
        /// specified asset does not exist, this API returns an INVALID_ARGUMENT error.</summary>
        /// <param name="parent">Required. The relative name of the root asset. It can only be an organization number (such as
        /// "organizations/123"), a project ID (such as "projects/my-project-id")", or a project number (such as
        /// "projects/12345").</param>
        public virtual BatchGetAssetsHistoryRequest BatchGetAssetsHistory(string parent)
        {
            return new BatchGetAssetsHistoryRequest(service, parent);
        }

        /// <summary>Batch gets the update history of assets that overlap a time window. For IAM_POLICY content, this
        /// API outputs history when the asset and its attached IAM POLICY both exist. This can create gaps in the
        /// output history. Otherwise, this API outputs history with asset in both non-delete or deleted status. If a
        /// specified asset does not exist, this API returns an INVALID_ARGUMENT error.</summary>
        public class BatchGetAssetsHistoryRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.BatchGetAssetsHistoryResponse>
        {
            /// <summary>Constructs a new BatchGetAssetsHistory request.</summary>
            public BatchGetAssetsHistoryRequest(Google.Apis.Services.IClientService service, string parent)
                : base(service)
            {
                Parent = parent;
                InitParameters();
            }


            /// <summary>Required. The relative name of the root asset. It can only be an organization number (such as
            /// "organizations/123"), a project ID (such as "projects/my-project-id")", or a project number (such as
            /// "projects/12345").</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>A list of the full names of the assets. See: https://cloud.google.com/asset-inventory/docs
            /// /resource-name-format Example:
            /// `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1`. The request becomes
            /// a no-op if the asset name list is empty, and the max size of the asset name list is 100 in one
            /// request.</summary>
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
                CONTENTTYPEUNSPECIFIED,
                /// <summary>Resource metadata.</summary>
                [Google.Apis.Util.StringValueAttribute("RESOURCE")]
                RESOURCE,
                /// <summary>The actual IAM policy set on a resource.</summary>
                [Google.Apis.Util.StringValueAttribute("IAM_POLICY")]
                IAMPOLICY,
                /// <summary>The Cloud Organization Policy set on an asset.</summary>
                [Google.Apis.Util.StringValueAttribute("ORG_POLICY")]
                ORGPOLICY,
                /// <summary>The Cloud Access context manager Policy set on an asset.</summary>
                [Google.Apis.Util.StringValueAttribute("ACCESS_POLICY")]
                ACCESSPOLICY,
            }

            /// <summary>End time of the time window (inclusive). If not specified, the current timestamp is used
            /// instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("readTimeWindow.endTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object ReadTimeWindowEndTime { get; set; }

            /// <summary>Start time of the time window (exclusive).</summary>
            [Google.Apis.Util.RequestParameterAttribute("readTimeWindow.startTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object ReadTimeWindowStartTime { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "batchGetAssetsHistory";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}:batchGetAssetsHistory";

            /// <summary>Initializes BatchGetAssetsHistory parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+/[^/]+$",
                    });
                RequestParameters.Add(
                    "assetNames", new Google.Apis.Discovery.Parameter
                    {
                        Name = "assetNames",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "contentType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "contentType",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "readTimeWindow.endTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "readTimeWindow.endTime",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "readTimeWindow.startTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "readTimeWindow.startTime",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Exports assets with time and resource types to a given Cloud Storage location/BigQuery table. For
        /// Cloud Storage location destinations, the output format is newline-delimited JSON. Each line represents a
        /// google.cloud.asset.v1.Asset in the JSON format; for BigQuery table destinations, the output table stores the
        /// fields in asset proto as columns. This API implements the google.longrunning.Operation API , which allows
        /// you to keep track of the export. We recommend intervals of at least 2 seconds with exponential retry to poll
        /// the export operation result. For regular-size resource parent, the export operation usually finishes within
        /// 5 minutes.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">Required. The relative name of the root asset. This can only be an organization number (such as
        /// "organizations/123"), a project ID (such as "projects/my-project-id"), or a project number (such as
        /// "projects/12345"), or a folder number (such as "folders/123").</param>
        public virtual ExportAssetsRequest ExportAssets(Google.Apis.CloudAsset.v1.Data.ExportAssetsRequest body, string parent)
        {
            return new ExportAssetsRequest(service, body, parent);
        }

        /// <summary>Exports assets with time and resource types to a given Cloud Storage location/BigQuery table. For
        /// Cloud Storage location destinations, the output format is newline-delimited JSON. Each line represents a
        /// google.cloud.asset.v1.Asset in the JSON format; for BigQuery table destinations, the output table stores the
        /// fields in asset proto as columns. This API implements the google.longrunning.Operation API , which allows
        /// you to keep track of the export. We recommend intervals of at least 2 seconds with exponential retry to poll
        /// the export operation result. For regular-size resource parent, the export operation usually finishes within
        /// 5 minutes.</summary>
        public class ExportAssetsRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.Operation>
        {
            /// <summary>Constructs a new ExportAssets request.</summary>
            public ExportAssetsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAsset.v1.Data.ExportAssetsRequest body, string parent)
                : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }


            /// <summary>Required. The relative name of the root asset. This can only be an organization number (such as
            /// "organizations/123"), a project ID (such as "projects/my-project-id"), or a project number (such as
            /// "projects/12345"), or a folder number (such as "folders/123").</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudAsset.v1.Data.ExportAssetsRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "exportAssets";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}:exportAssets";

            /// <summary>Initializes ExportAssets parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+/[^/]+$",
                    });
            }

        }

        /// <summary>Searches all IAM policies within the specified scope, such as a project, folder, or organization.
        /// The caller must be granted the `cloudasset.assets.searchAllIamPolicies` permission on the desired scope,
        /// otherwise the request will be rejected.</summary>
        /// <param name="scope">Required. A scope can be a project, a folder, or an organization. The search is limited to the
        /// IAM policies within the `scope`. The caller must be granted the
        /// [`cloudasset.assets.searchAllIamPolicies`](http://cloud.google.com/asset-inventory/docs/access-
        /// control#required_permissions) permission on the desired scope. The allowed values are: * projects/{PROJECT_ID}
        /// (e.g., "projects/foo-bar") * projects/{PROJECT_NUMBER} (e.g., "projects/12345678") * folders/{FOLDER_NUMBER} (e.g.,
        /// "folders/1234567") * organizations/{ORGANIZATION_NUMBER} (e.g., "organizations/123456")</param>
        public virtual SearchAllIamPoliciesRequest SearchAllIamPolicies(string scope)
        {
            return new SearchAllIamPoliciesRequest(service, scope);
        }

        /// <summary>Searches all IAM policies within the specified scope, such as a project, folder, or organization.
        /// The caller must be granted the `cloudasset.assets.searchAllIamPolicies` permission on the desired scope,
        /// otherwise the request will be rejected.</summary>
        public class SearchAllIamPoliciesRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.SearchAllIamPoliciesResponse>
        {
            /// <summary>Constructs a new SearchAllIamPolicies request.</summary>
            public SearchAllIamPoliciesRequest(Google.Apis.Services.IClientService service, string scope)
                : base(service)
            {
                Scope = scope;
                InitParameters();
            }


            /// <summary>Required. A scope can be a project, a folder, or an organization. The search is limited to the
            /// IAM policies within the `scope`. The caller must be granted the
            /// [`cloudasset.assets.searchAllIamPolicies`](http://cloud.google.com/asset-inventory/docs/access-
            /// control#required_permissions) permission on the desired scope. The allowed values are: *
            /// projects/{PROJECT_ID} (e.g., "projects/foo-bar") * projects/{PROJECT_NUMBER} (e.g., "projects/12345678")
            /// * folders/{FOLDER_NUMBER} (e.g., "folders/1234567") * organizations/{ORGANIZATION_NUMBER} (e.g.,
            /// "organizations/123456")</summary>
            [Google.Apis.Util.RequestParameterAttribute("scope", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Scope { get; private set; }

            /// <summary>Optional. The page size for search result pagination. Page size is capped at 500 even if a
            /// larger value is given. If set to zero, server will pick an appropriate default. Returned results may be
            /// fewer than requested. When this happens, there could be more results as long as `next_page_token` is
            /// returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>Optional. If present, retrieve the next batch of results from the preceding call to this
            /// method. `page_token` must be the value of `next_page_token` from the previous response. The values of
            /// all other method parameters must be identical to those in the previous call.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Optional. The query statement. See [how to construct a query](https://cloud.google.com/asset-
            /// inventory/docs/searching-iam-policies#how_to_construct_a_query) for more information. If not specified
            /// or empty, it will search all the IAM policies within the specified `scope`. Examples: *
            /// `policy:amy@gmail.com` to find IAM policy bindings that specify user "amy@gmail.com". *
            /// `policy:roles/compute.admin` to find IAM policy bindings that specify the Compute Admin role. *
            /// `policy.role.permissions:storage.buckets.update` to find IAM policy bindings that specify a role
            /// containing "storage.buckets.update" permission. Note that if callers don't have `iam.roles.get` access
            /// to a role's included permissions, policy bindings that specify this role will be dropped from the search
            /// results. * `resource:organizations/123456` to find IAM policy bindings that are set on
            /// "organizations/123456". * `Important` to find IAM policy bindings that contain "Important" as a word in
            /// any of the searchable fields (except for the included permissions). * `*por*` to find IAM policy
            /// bindings that contain "por" as a substring in any of the searchable fields (except for the included
            /// permissions). * `resource:(instance1 OR instance2) policy:amy` to find IAM policy bindings that are set
            /// on resources "instance1" or "instance2" and also specify user "amy".</summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "searchAllIamPolicies";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+scope}:searchAllIamPolicies";

            /// <summary>Initializes SearchAllIamPolicies parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "scope", new Google.Apis.Discovery.Parameter
                    {
                        Name = "scope",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+/[^/]+$",
                    });
                RequestParameters.Add(
                    "pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "query", new Google.Apis.Discovery.Parameter
                    {
                        Name = "query",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Searches all Cloud resources within the specified scope, such as a project, folder, or
        /// organization. The caller must be granted the `cloudasset.assets.searchAllResources` permission on the
        /// desired scope, otherwise the request will be rejected.</summary>
        /// <param name="scope">Required. A scope can be a project, a folder, or an organization. The search is limited to the
        /// resources within the `scope`. The caller must be granted the
        /// [`cloudasset.assets.searchAllResources`](http://cloud.google.com/asset-inventory/docs/access-
        /// control#required_permissions) permission on the desired scope. The allowed values are: * projects/{PROJECT_ID}
        /// (e.g., "projects/foo-bar") * projects/{PROJECT_NUMBER} (e.g., "projects/12345678") * folders/{FOLDER_NUMBER} (e.g.,
        /// "folders/1234567") * organizations/{ORGANIZATION_NUMBER} (e.g., "organizations/123456")</param>
        public virtual SearchAllResourcesRequest SearchAllResources(string scope)
        {
            return new SearchAllResourcesRequest(service, scope);
        }

        /// <summary>Searches all Cloud resources within the specified scope, such as a project, folder, or
        /// organization. The caller must be granted the `cloudasset.assets.searchAllResources` permission on the
        /// desired scope, otherwise the request will be rejected.</summary>
        public class SearchAllResourcesRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1.Data.SearchAllResourcesResponse>
        {
            /// <summary>Constructs a new SearchAllResources request.</summary>
            public SearchAllResourcesRequest(Google.Apis.Services.IClientService service, string scope)
                : base(service)
            {
                Scope = scope;
                InitParameters();
            }


            /// <summary>Required. A scope can be a project, a folder, or an organization. The search is limited to the
            /// resources within the `scope`. The caller must be granted the
            /// [`cloudasset.assets.searchAllResources`](http://cloud.google.com/asset-inventory/docs/access-
            /// control#required_permissions) permission on the desired scope. The allowed values are: *
            /// projects/{PROJECT_ID} (e.g., "projects/foo-bar") * projects/{PROJECT_NUMBER} (e.g., "projects/12345678")
            /// * folders/{FOLDER_NUMBER} (e.g., "folders/1234567") * organizations/{ORGANIZATION_NUMBER} (e.g.,
            /// "organizations/123456")</summary>
            [Google.Apis.Util.RequestParameterAttribute("scope", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Scope { get; private set; }

            /// <summary>Optional. A list of asset types that this request searches for. If empty, it will search all
            /// the [searchable asset types](https://cloud.google.com/asset-inventory/docs/supported-asset-
            /// types#searchable_asset_types).</summary>
            [Google.Apis.Util.RequestParameterAttribute("assetTypes", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> AssetTypes { get; set; }

            /// <summary>Optional. A comma separated list of fields specifying the sorting order of the results. The
            /// default order is ascending. Add " DESC" after the field name to indicate descending order. Redundant
            /// space characters are ignored. Example: "location DESC, name". Only string fields in the response are
            /// sortable, including `name`, `displayName`, `description`, `location`. All the other fields such as
            /// repeated fields (e.g., `networkTags`), map fields (e.g., `labels`) and struct fields (e.g.,
            /// `additionalAttributes`) are not supported.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>Optional. The page size for search result pagination. Page size is capped at 500 even if a
            /// larger value is given. If set to zero, server will pick an appropriate default. Returned results may be
            /// fewer than requested. When this happens, there could be more results as long as `next_page_token` is
            /// returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>Optional. If present, then retrieve the next batch of results from the preceding call to this
            /// method. `page_token` must be the value of `next_page_token` from the previous response. The values of
            /// all other method parameters, must be identical to those in the previous call.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Optional. The query statement. See [how to construct a query](http://cloud.google.com/asset-
            /// inventory/docs/searching-resources#how_to_construct_a_query) for more information. If not specified or
            /// empty, it will search all the resources within the specified `scope`. Note that the query string is
            /// compared against each Cloud IAM policy binding, including its members, roles, and Cloud IAM conditions.
            /// The returned Cloud IAM policies will only contain the bindings that match your query. To learn more
            /// about the IAM policy structure, see [IAM policy
            /// doc](https://cloud.google.com/iam/docs/policies#structure). Examples: * `name:Important` to find Cloud
            /// resources whose name contains "Important" as a word. * `displayName:Impor*` to find Cloud resources
            /// whose display name contains "Impor" as a prefix. * `description:*por*` to find Cloud resources whose
            /// description contains "por" as a substring. * `location:us-west*` to find Cloud resources whose location
            /// is prefixed with "us-west". * `labels:prod` to find Cloud resources whose labels contain "prod" as a key
            /// or value. * `labels.env:prod` to find Cloud resources that have a label "env" and its value is "prod". *
            /// `labels.env:*` to find Cloud resources that have a label "env". * `Important` to find Cloud resources
            /// that contain "Important" as a word in any of the searchable fields. * `Impor*` to find Cloud resources
            /// that contain "Impor" as a prefix in any of the searchable fields. * `*por*` to find Cloud resources that
            /// contain "por" as a substring in any of the searchable fields. * `Important location:(us-west1 OR
            /// global)` to find Cloud resources that contain "Important" as a word in any of the searchable fields and
            /// are also located in the "us-west1" region or the "global" location.</summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "searchAllResources";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+scope}:searchAllResources";

            /// <summary>Initializes SearchAllResources parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "scope", new Google.Apis.Discovery.Parameter
                    {
                        Name = "scope",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+/[^/]+$",
                    });
                RequestParameters.Add(
                    "assetTypes", new Google.Apis.Discovery.Parameter
                    {
                        Name = "assetTypes",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "query", new Google.Apis.Discovery.Parameter
                    {
                        Name = "query",
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

    /// <summary>An asset in Google Cloud. An asset can be any resource in the Google Cloud [resource
    /// hierarchy](https://cloud.google.com/resource-manager/docs/cloud-platform-resource-hierarchy), a resource outside
    /// the Google Cloud resource hierarchy (such as Google Kubernetes Engine clusters and objects), or a policy (e.g.
    /// Cloud IAM policy). See [Supported asset types](https://cloud.google.com/asset-inventory/docs/supported-asset-
    /// types) for more information.</summary>
    public class Asset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Please also refer to the [access level user guide](https://cloud.google.com/access-context-
        /// manager/docs/overview#access-levels).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLevel")]
        public virtual GoogleIdentityAccesscontextmanagerV1AccessLevel AccessLevel { get; set; } 

        /// <summary>Please also refer to the [access policy user guide](https://cloud.google.com/access-context-
        /// manager/docs/overview#access-policies).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessPolicy")]
        public virtual GoogleIdentityAccesscontextmanagerV1AccessPolicy AccessPolicy { get; set; } 

        /// <summary>The ancestry path of an asset in Google Cloud [resource hierarchy](https://cloud.google.com
        /// /resource-manager/docs/cloud-platform-resource-hierarchy), represented as a list of relative resource names.
        /// An ancestry path starts with the closest ancestor in the hierarchy and ends at root. If the asset is a
        /// project, folder, or organization, the ancestry path starts from the asset itself. Example:
        /// `["projects/123456789", "folders/5432", "organizations/1234"]`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ancestors")]
        public virtual System.Collections.Generic.IList<string> Ancestors { get; set; } 

        /// <summary>The type of the asset. Example: `compute.googleapis.com/Disk` See [Supported asset
        /// types](https://cloud.google.com/asset-inventory/docs/supported-asset-types) for more information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetType")]
        public virtual string AssetType { get; set; } 

        /// <summary>A representation of the Cloud IAM policy set on a Google Cloud resource. There can be a maximum of
        /// one Cloud IAM policy set on any given resource. In addition, Cloud IAM policies inherit their granted access
        /// scope from any policies set on parent resources in the resource hierarchy. Therefore, the effectively policy
        /// is the union of both the policy set on this resource and each policy set on all of the resource's ancestry
        /// resource levels in the hierarchy. See [this topic](https://cloud.google.com/iam/docs/policies#inheritance)
        /// for more information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iamPolicy")]
        public virtual Policy IamPolicy { get; set; } 

        /// <summary>The full name of the asset. Example:
        /// `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1` See [Resource
        /// names](https://cloud.google.com/apis/design/resource_names#full_resource_name) for more
        /// information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>A representation of an [organization policy](https://cloud.google.com/resource-manager/docs
        /// /organization-policy/overview#organization_policy). There can be more than one organization policy with
        /// different constraints set on a given resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgPolicy")]
        public virtual System.Collections.Generic.IList<GoogleCloudOrgpolicyV1Policy> OrgPolicy { get; set; } 

        /// <summary>A representation of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual Resource Resource { get; set; } 

        /// <summary>Please also refer to the [service perimeter user guide](https://cloud.google.com/vpc-service-
        /// controls/docs/overview).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicePerimeter")]
        public virtual GoogleIdentityAccesscontextmanagerV1ServicePerimeter ServicePerimeter { get; set; } 

        /// <summary>The last update timestamp of an asset. update_time is updated when create/update/delete operation
        /// is performed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Specifies the audit configuration for a service. The configuration determines which permission types
    /// are logged, and what identities, if any, are exempted from logging. An AuditConfig must have one or more
    /// AuditLogConfigs. If there are AuditConfigs for both `allServices` and a specific service, the union of the two
    /// AuditConfigs is used for that service: the log_types specified in each AuditConfig are enabled, and the
    /// exempted_members in each AuditLogConfig are exempted. Example Policy with multiple AuditConfigs: {
    /// "audit_configs": [ { "service": "allServices", "audit_log_configs": [ { "log_type": "DATA_READ",
    /// "exempted_members": [ "user:jose@example.com" ] }, { "log_type": "DATA_WRITE" }, { "log_type": "ADMIN_READ" } ]
    /// }, { "service": "sampleservice.googleapis.com", "audit_log_configs": [ { "log_type": "DATA_READ" }, {
    /// "log_type": "DATA_WRITE", "exempted_members": [ "user:aliya@example.com" ] } ] } ] } For sampleservice, this
    /// policy enables DATA_READ, DATA_WRITE and ADMIN_READ logging. It also exempts jose@example.com from DATA_READ
    /// logging, and aliya@example.com from DATA_WRITE logging.</summary>
    public class AuditConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for logging of each type of permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLogConfigs")]
        public virtual System.Collections.Generic.IList<AuditLogConfig> AuditLogConfigs { get; set; } 

        /// <summary>Specifies a service that will be enabled for audit logging. For example, `storage.googleapis.com`,
        /// `cloudsql.googleapis.com`. `allServices` is a special value that covers all services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Provides the configuration for logging a type of permissions. Example: { "audit_log_configs": [ {
    /// "log_type": "DATA_READ", "exempted_members": [ "user:jose@example.com" ] }, { "log_type": "DATA_WRITE" } ] }
    /// This enables 'DATA_READ' and 'DATA_WRITE' logging, while exempting jose@example.com from DATA_READ
    /// logging.</summary>
    public class AuditLogConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies the identities that do not cause logging for this type of permission. Follows the same
        /// format of Binding.members.</summary>
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
        /// <summary>Required. The BigQuery dataset in format "projects/projectId/datasets/datasetId", to which the
        /// snapshot result should be exported. If this dataset does not exist, the export call returns an
        /// INVALID_ARGUMENT error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; } 

        /// <summary>If the destination table already exists and this flag is `TRUE`, the table will be overwritten by
        /// the contents of assets snapshot. If the flag is `FALSE` or unset and the destination table already exists,
        /// the export call returns an INVALID_ARGUMEMT error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("force")]
        public virtual System.Nullable<bool> Force { get; set; } 

        /// <summary>Required. The BigQuery table to which the snapshot result should be written. If this table does not
        /// exist, a new table with the given name will be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual string Table { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Associates `members` with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The condition that is associated with this binding. If the condition evaluates to `true`, then this
        /// binding applies to the current request. If the condition evaluates to `false`, then this binding does not
        /// apply to the current request. However, a different role binding might grant the same role to one or more of
        /// the members in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; } 

        /// <summary>Specifies the identities requesting access for a Cloud Platform resource. `members` can have the
        /// following values: * `allUsers`: A special identifier that represents anyone who is on the internet; with or
        /// without a Google account. * `allAuthenticatedUsers`: A special identifier that represents anyone who is
        /// authenticated with a Google account or a service account. * `user:{emailid}`: An email address that
        /// represents a specific Google account. For example, `alice@example.com` . * `serviceAccount:{emailid}`: An
        /// email address that represents a service account. For example, `my-other-app@appspot.gserviceaccount.com`. *
        /// `group:{emailid}`: An email address that represents a Google group. For example, `admins@example.com`. *
        /// `deleted:user:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a user that
        /// has been recently deleted. For example, `alice@example.com?uid=123456789012345678901`. If the user is
        /// recovered, this value reverts to `user:{emailid}` and the recovered user retains the role in the binding. *
        /// `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a
        /// service account that has been recently deleted. For example, `my-other-
        /// app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted, this value
        /// reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the binding. *
        /// `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a Google
        /// group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`. If the
        /// group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role in the
        /// binding. * `domain:{domain}`: The G Suite domain (primary) that represents all the users of that domain. For
        /// example, `google.com` or `example.com`. </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; } 

        /// <summary>Role that is assigned to `members`. For example, `roles/viewer`, `roles/editor`, or
        /// `roles/owner`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Create asset feed request.</summary>
    public class CreateFeedRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The feed details. The field `name` must be empty and it will be generated in the format
        /// of: projects/project_number/feeds/feed_id folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feed")]
        public virtual Feed Feed { get; set; } 

        /// <summary>Required. This is the client-assigned asset feed identifier and it needs to be unique under a
        /// specific parent project/folder/organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedId")]
        public virtual string FeedId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A
    /// typical example is to use it as the request or the response type of an API method. For instance: service Foo {
    /// rpc Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty
    /// JSON object `{}`.</summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Explanation about the IAM policy search result.</summary>
    public class Explanation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The map from roles to their included permissions that match the permission query (i.e., a query
        /// containing `policy.role.permissions:`). Example: if query `policy.role.permissions:compute.disk.get` matches
        /// a policy binding that contains owner role, the matched_permissions will be `{"roles/owner":
        /// ["compute.disk.get"]}`. The roles can also be found in the returned `policy` bindings. Note that the map is
        /// populated only for requests with permission queries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchedPermissions")]
        public virtual System.Collections.Generic.IDictionary<string,Permissions> MatchedPermissions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Export asset request.</summary>
    public class ExportAssetsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of asset types to take a snapshot for. For example: "compute.googleapis.com/Disk". Regular
        /// expressions are also supported. For example: * "compute.googleapis.com.*" snapshots resources whose asset
        /// type starts with "compute.googleapis.com". * ".*Instance" snapshots resources whose asset type ends with
        /// "Instance". * ".*Instance.*" snapshots resources whose asset type contains "Instance". See
        /// [RE2](https://github.com/google/re2/wiki/Syntax) for all supported regular expression syntax. If the regular
        /// expression does not match any supported asset type, an INVALID_ARGUMENT error will be returned. If
        /// specified, only matching assets will be returned, otherwise, it will snapshot all asset types. See
        /// [Introduction to Cloud Asset Inventory](https://cloud.google.com/asset-inventory/docs/overview) for all
        /// supported asset types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetTypes")]
        public virtual System.Collections.Generic.IList<string> AssetTypes { get; set; } 

        /// <summary>Asset content type. If not specified, no content but the asset name will be returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; } 

        /// <summary>Required. Output configuration indicating where the results will be output to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual OutputConfig OutputConfig { get; set; } 

        /// <summary>Timestamp to take an asset snapshot. This can only be set to a timestamp between the current time
        /// and the current time minus 35 days (inclusive). If not specified, the current time will be used. Due to
        /// delays in resource data collection and indexing, there is a volatile window during which running the same
        /// query may get different results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual object ReadTime { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like
    /// expression language. The syntax and semantics of CEL are documented at https://github.com/google/cel-spec.
    /// Example (Comparison): title: "Summary size limit" description: "Determines if a summary is less than 100 chars"
    /// expression: "document.summary.size() < 100" Example (Equality): title: "Requestor is owner" description:
    /// "Determines if requestor is the document owner" expression: "document.owner == request.auth.claims.email"
    /// Example (Logic): title: "Public documents" description: "Determine whether the document should be publicly
    /// visible" expression: "document.type != 'private' && document.type != 'internal'" Example (Data Manipulation):
    /// title: "Notification string" description: "Create a notification string with a timestamp." expression: "'New
    /// message received at ' + string(document.create_time)" The exact variables and functions that may be referenced
    /// within an expression are determined by the service that evaluates it. See the service documentation for
    /// additional information.</summary>
    public class Expr : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Description of the expression. This is a longer text which describes the expression, e.g.
        /// when hovered over it in a UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; } 

        /// <summary>Optional. String indicating the location of the expression for error reporting, e.g. a file name
        /// and a position in the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; } 

        /// <summary>Optional. Title for the expression, i.e. a short string describing its purpose. This can be used
        /// e.g. in UIs which allow to enter the expression.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An asset feed used to export asset updates to a destinations. An asset feed filter controls what
    /// updates are exported. The asset feed must be created within a project, organization, or folder. Supported
    /// destinations are: Pub/Sub topics.</summary>
    public class Feed : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of the full names of the assets to receive updates. You must specify either or both of
        /// asset_names and asset_types. Only asset updates matching specified asset_names or asset_types are exported
        /// to the feed. Example: `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1`.
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names#full_resource_name) for more
        /// info.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetNames")]
        public virtual System.Collections.Generic.IList<string> AssetNames { get; set; } 

        /// <summary>A list of types of the assets to receive updates. You must specify either or both of asset_names
        /// and asset_types. Only asset updates matching specified asset_names or asset_types are exported to the feed.
        /// Example: `"compute.googleapis.com/Disk"` See [this topic](https://cloud.google.com/asset-inventory/docs
        /// /supported-asset-types) for a list of all supported asset types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetTypes")]
        public virtual System.Collections.Generic.IList<string> AssetTypes { get; set; } 

        /// <summary>A condition which determines whether an asset update should be published. If specified, an asset
        /// will be returned only when the expression evaluates to true. When set, `expression` field in the `Expr` must
        /// be a valid [CEL expression] (https://github.com/google/cel-spec) on a TemporalAsset with name
        /// `temporal_asset`. Example: a Feed with expression ("temporal_asset.deleted == true") will only publish Asset
        /// deletions. Other fields of `Expr` are optional. See our [user guide](https://cloud.google.com/asset-
        /// inventory/docs/monitoring-asset-changes#feed_with_condition) for detailed instructions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; } 

        /// <summary>Asset content type. If not specified, no content but the asset name and type will be
        /// returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; } 

        /// <summary>Required. Feed output configuration defining where the asset updates are published to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedOutputConfig")]
        public virtual FeedOutputConfig FeedOutputConfig { get; set; } 

        /// <summary>Required. The format will be projects/{project_number}/feeds/{client-assigned_feed_identifier} or
        /// folders/{folder_number}/feeds/{client-assigned_feed_identifier} or organizations/{organization_number}/feeds
        /// /{client-assigned_feed_identifier} The client-assigned feed identifier must be unique within the parent
        /// project/folder/organization.</summary>
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
        /// <summary>The uri of the Cloud Storage object. It's the same uri that is used by gsutil. Example:
        /// "gs://bucket_name/object_name". See [Viewing and Editing Object
        /// Metadata](https://cloud.google.com/storage/docs/viewing-editing-metadata) for more information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; } 

        /// <summary>The uri prefix of all generated Cloud Storage objects. Example:
        /// "gs://bucket_name/object_name_prefix". Each object uri is in format: "gs://bucket_name/object_name_prefix//
        /// and only contains assets for that type. starts from 0. Example:
        /// "gs://bucket_name/object_name_prefix/compute.googleapis.com/Disk/0" is the first shard of output objects
        /// containing all compute.googleapis.com/Disk assets. An INVALID_ARGUMENT error will be returned if file with
        /// the same name "gs://bucket_name/object_name_prefix" already exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uriPrefix")]
        public virtual string UriPrefix { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Used in `policy_type` to specify how `boolean_policy` will behave at this resource.</summary>
    public class GoogleCloudOrgpolicyV1BooleanPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If `true`, then the `Policy` is enforced. If `false`, then any configuration is acceptable. Suppose
        /// you have a `Constraint` `constraints/compute.disableSerialPortAccess` with `constraint_default` set to
        /// `ALLOW`. A `Policy` for that `Constraint` exhibits the following behavior: - If the `Policy` at this
        /// resource has enforced set to `false`, serial port connection attempts will be allowed. - If the `Policy` at
        /// this resource has enforced set to `true`, serial port connection attempts will be refused. - If the `Policy`
        /// at this resource is `RestoreDefault`, serial port connection attempts will be allowed. - If no `Policy` is
        /// set at this resource or anywhere higher in the resource hierarchy, serial port connection attempts will be
        /// allowed. - If no `Policy` is set at this resource, but one exists higher in the resource hierarchy, the
        /// behavior is as if the`Policy` were set at this resource. The following examples demonstrate the different
        /// possible layerings: Example 1 (nearest `Constraint` wins): `organizations/foo` has a `Policy` with:
        /// {enforced: false} `projects/bar` has no `Policy` set. The constraint at `projects/bar` and
        /// `organizations/foo` will not be enforced. Example 2 (enforcement gets replaced): `organizations/foo` has a
        /// `Policy` with: {enforced: false} `projects/bar` has a `Policy` with: {enforced: true} The constraint at
        /// `organizations/foo` is not enforced. The constraint at `projects/bar` is enforced. Example 3
        /// (RestoreDefault): `organizations/foo` has a `Policy` with: {enforced: true} `projects/bar` has a `Policy`
        /// with: {RestoreDefault: {}} The constraint at `organizations/foo` is enforced. The constraint at
        /// `projects/bar` is not enforced, because `constraint_default` for the `Constraint` is `ALLOW`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enforced")]
        public virtual System.Nullable<bool> Enforced { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Used in `policy_type` to specify how `list_policy` behaves at this resource. `ListPolicy` can define
    /// specific values and subtrees of Cloud Resource Manager resource hierarchy (`Organizations`, `Folders`,
    /// `Projects`) that are allowed or denied by setting the `allowed_values` and `denied_values` fields. This is
    /// achieved by using the `under:` and optional `is:` prefixes. The `under:` prefix is used to denote resource
    /// subtree values. The `is:` prefix is used to denote specific values, and is required only if the value contains a
    /// ":". Values prefixed with "is:" are treated the same as values with no prefix. Ancestry subtrees must be in one
    /// of the following formats: - "projects/", e.g. "projects/tokyo-rain-123" - "folders/", e.g. "folders/1234" -
    /// "organizations/", e.g. "organizations/1234" The `supports_under` field of the associated `Constraint` defines
    /// whether ancestry prefixes can be used. You can set `allowed_values` and `denied_values` in the same `Policy` if
    /// `all_values` is `ALL_VALUES_UNSPECIFIED`. `ALLOW` or `DENY` are used to allow or deny all values. If
    /// `all_values` is set to either `ALLOW` or `DENY`, `allowed_values` and `denied_values` must be unset.</summary>
    public class GoogleCloudOrgpolicyV1ListPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The policy all_values state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allValues")]
        public virtual string AllValues { get; set; } 

        /// <summary>List of values allowed at this resource. Can only be set if `all_values` is set to
        /// `ALL_VALUES_UNSPECIFIED`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedValues")]
        public virtual System.Collections.Generic.IList<string> AllowedValues { get; set; } 

        /// <summary>List of values denied at this resource. Can only be set if `all_values` is set to
        /// `ALL_VALUES_UNSPECIFIED`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deniedValues")]
        public virtual System.Collections.Generic.IList<string> DeniedValues { get; set; } 

        /// <summary>Determines the inheritance behavior for this `Policy`. By default, a `ListPolicy` set at a resource
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
        /// subtrees of Resource Manager hierarchy): Given the following resource hierarchy O1->{F1, F2}; F1->{P1};
        /// F2->{P2, P3}, `organizations/foo` has a `Policy` with values: {allowed_values: "under:organizations/O1"}
        /// `projects/bar` has a `Policy` with: {allowed_values: "under:projects/P3"} {denied_values:
        /// "under:folders/F2"} The accepted values at `organizations/foo` are `organizations/O1`, `folders/F1`,
        /// `folders/F2`, `projects/P1`, `projects/P2`, `projects/P3`. The accepted values at `projects/bar` are
        /// `organizations/O1`, `folders/F1`, `projects/P1`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inheritFromParent")]
        public virtual System.Nullable<bool> InheritFromParent { get; set; } 

        /// <summary>Optional. The Google Cloud Console will try to default to a configuration that matches the value
        /// specified in this `Policy`. If `suggested_value` is not set, it will inherit the value specified higher in
        /// the hierarchy, unless `inherit_from_parent` is `false`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedValue")]
        public virtual string SuggestedValue { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Defines a Cloud Organization `Policy` which is used to specify `Constraints` for configurations of
    /// Cloud Platform resources.</summary>
    public class GoogleCloudOrgpolicyV1Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>For boolean `Constraints`, whether to enforce the `Constraint` or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("booleanPolicy")]
        public virtual GoogleCloudOrgpolicyV1BooleanPolicy BooleanPolicy { get; set; } 

        /// <summary>The name of the `Constraint` the `Policy` is configuring, for example,
        /// `constraints/serviceuser.services`. A [list of available constraints](/resource-manager/docs/organization-
        /// policy/org-policy-constraints) is available. Immutable after creation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraint")]
        public virtual string Constraint { get; set; } 

        /// <summary>An opaque tag indicating the current version of the `Policy`, used for concurrency control. When
        /// the `Policy` is returned from either a `GetPolicy` or a `ListOrgPolicy` request, this `etag` indicates the
        /// version of the current `Policy` to use when executing a read-modify-write loop. When the `Policy` is
        /// returned from a `GetEffectivePolicy` request, the `etag` will be unset. When the `Policy` is used in a
        /// `SetOrgPolicy` method, use the `etag` value that was returned from a `GetOrgPolicy` request as part of a
        /// read-modify-write loop for concurrency control. Not setting the `etag`in a `SetOrgPolicy` request will
        /// result in an unconditional write of the `Policy`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>List of values either allowed or disallowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listPolicy")]
        public virtual GoogleCloudOrgpolicyV1ListPolicy ListPolicy { get; set; } 

        /// <summary>Restores the default behavior of the constraint; independent of `Constraint` type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restoreDefault")]
        public virtual GoogleCloudOrgpolicyV1RestoreDefault RestoreDefault { get; set; } 

        /// <summary>The time stamp the `Policy` was previously updated. This is set by the server, not specified by the
        /// caller, and represents the last time a call to `SetOrgPolicy` was made for that `Policy`. Any value set by
        /// the client will be ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; } 

        /// <summary>Version of the `Policy`. Default version is 0;</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; } 

    }    

    /// <summary>Ignores policies set above this resource and restores the `constraint_default` enforcement behavior of
    /// the specific `Constraint` at this resource. Suppose that `constraint_default` is set to `ALLOW` for the
    /// `Constraint` `constraints/serviceuser.services`. Suppose that organization foo.com sets a `Policy` at their
    /// Organization resource node that restricts the allowed service activations to deny all service activations. They
    /// could then set a `Policy` with the `policy_type` `restore_default` on several experimental projects, restoring
    /// the `constraint_default` enforcement of the `Constraint` for only those projects, allowing those projects to
    /// have all services activated.</summary>
    public class GoogleCloudOrgpolicyV1RestoreDefault : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An `AccessLevel` is a label that can be applied to requests to Google Cloud services, along with a list
    /// of requirements necessary for the label to be applied.</summary>
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

        /// <summary>Required. Resource name for the Access Level. The `short_name` component must begin with a letter
        /// and only include alphanumeric and '_'. Format: `accessPolicies/{policy_id}/accessLevels/{short_name}`. The
        /// maximum length of the `short_name` component is 50 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Human readable title. Must be unique within the Policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>`AccessPolicy` is a container for `AccessLevels` (which define the necessary attributes to use Google
    /// Cloud services) and `ServicePerimeters` (which define regions of services able to freely pass data within a
    /// perimeter). An access policy is globally visible within an organization, and the restrictions it specifies apply
    /// to all projects within an organization.</summary>
    public class GoogleIdentityAccesscontextmanagerV1AccessPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. An opaque identifier for the current version of the `AccessPolicy`. This will always
        /// be a strongly validated etag, meaning that two Access Polices will be identical if and only if their etags
        /// are identical. Clients should not expect this to be in any specific format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>Output only. Resource name of the `AccessPolicy`. Format: `accessPolicies/{policy_id}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Required. The parent of this `AccessPolicy` in the Cloud Resource Hierarchy. Currently immutable
        /// once created. Format: `organizations/{organization_id}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; } 

        /// <summary>Required. Human readable title. Does not affect behavior.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

    }    

    /// <summary>`BasicLevel` is an `AccessLevel` using a set of recommended features.</summary>
    public class GoogleIdentityAccesscontextmanagerV1BasicLevel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>How the `conditions` list should be combined to determine if a request is granted this
        /// `AccessLevel`. If AND is used, each `Condition` in `conditions` must be satisfied for the `AccessLevel` to
        /// be applied. If OR is used, at least one `Condition` in `conditions` must be satisfied for the `AccessLevel`
        /// to be applied. Default behavior is AND.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("combiningFunction")]
        public virtual string CombiningFunction { get; set; } 

        /// <summary>Required. A list of requirements for the `AccessLevel` to be granted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleIdentityAccesscontextmanagerV1Condition> Conditions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A condition necessary for an `AccessLevel` to be granted. The Condition is an AND over its fields. So a
    /// Condition is true if: 1) the request IP is from one of the listed subnetworks AND 2) the originating device
    /// complies with the listed device policy AND 3) all listed access levels are granted AND 4) the request was sent
    /// at a time allowed by the DateTimeRestriction.</summary>
    public class GoogleIdentityAccesscontextmanagerV1Condition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Device specific restrictions, all restrictions must hold for the Condition to be true. If not
        /// specified, all devices are allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devicePolicy")]
        public virtual GoogleIdentityAccesscontextmanagerV1DevicePolicy DevicePolicy { get; set; } 

        /// <summary>CIDR block IP subnetwork specification. May be IPv4 or IPv6. Note that for a CIDR IP address block,
        /// the specified IP address portion must be properly truncated (i.e. all the host bits must be zero) or the
        /// input is considered malformed. For example, "192.0.2.0/24" is accepted but "192.0.2.1/24" is not. Similarly,
        /// for IPv6, "2001:db8::/32" is accepted whereas "2001:db8::1/32" is not. The originating IP of a request must
        /// be in one of the listed subnets in order for this Condition to be true. If empty, all IP addresses are
        /// allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipSubnetworks")]
        public virtual System.Collections.Generic.IList<string> IpSubnetworks { get; set; } 

        /// <summary>The request must be made by one of the provided user or service accounts. Groups are not supported.
        /// Syntax: `user:{emailid}` `serviceAccount:{emailid}` If not specified, a request may come from any
        /// user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; } 

        /// <summary>Whether to negate the Condition. If true, the Condition becomes a NAND over its non-empty fields,
        /// each field must be false for the Condition overall to be satisfied. Defaults to false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negate")]
        public virtual System.Nullable<bool> Negate { get; set; } 

        /// <summary>The request must originate from one of the provided countries/regions. Must be valid ISO 3166-1
        /// alpha-2 codes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regions")]
        public virtual System.Collections.Generic.IList<string> Regions { get; set; } 

        /// <summary>A list of other access levels defined in the same `Policy`, referenced by resource name.
        /// Referencing an `AccessLevel` which does not exist is an error. All access levels listed must be granted for
        /// the Condition to be true. Example: "`accessPolicies/MY_POLICY/accessLevels/LEVEL_NAME"`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiredAccessLevels")]
        public virtual System.Collections.Generic.IList<string> RequiredAccessLevels { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>`CustomLevel` is an `AccessLevel` using the Cloud Common Expression Language to represent the necessary
    /// conditions for the level to apply to a request. See CEL spec at: https://github.com/google/cel-spec</summary>
    public class GoogleIdentityAccesscontextmanagerV1CustomLevel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A Cloud CEL expression evaluating to a boolean.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expr")]
        public virtual Expr Expr { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>`DevicePolicy` specifies device specific restrictions necessary to acquire a given access level. A
    /// `DevicePolicy` specifies requirements for requests from devices to be granted access levels, it does not do any
    /// enforcement on the device. `DevicePolicy` acts as an AND over all specified fields, and each repeated field is
    /// an OR over its elements. Any unset fields are ignored. For example, if the proto is { os_type : DESKTOP_WINDOWS,
    /// os_type : DESKTOP_LINUX, encryption_status: ENCRYPTED}, then the DevicePolicy will be true for requests
    /// originating from encrypted Linux desktops and encrypted Windows desktops.</summary>
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

        /// <summary>Whether or not screenlock is required for the DevicePolicy to be true. Defaults to
        /// `false`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireScreenlock")]
        public virtual System.Nullable<bool> RequireScreenlock { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A restriction on the OS type and version of devices making requests.</summary>
    public class GoogleIdentityAccesscontextmanagerV1OsConstraint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The minimum allowed OS version. If not set, any version of this OS satisfies the constraint.
        /// Format: `"major.minor.patch"`. Examples: `"10.5.301"`, `"9.2.1"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumVersion")]
        public virtual string MinimumVersion { get; set; } 

        /// <summary>Required. The allowed OS type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osType")]
        public virtual string OsType { get; set; } 

        /// <summary>Only allows requests from devices with a verified Chrome OS. Verifications includes requirements
        /// that the device is enterprise-managed, conformant to domain policies, and the caller has permission to call
        /// the API targeted by the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireVerifiedChromeOs")]
        public virtual System.Nullable<bool> RequireVerifiedChromeOs { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>`ServicePerimeter` describes a set of Google Cloud resources which can freely import and export data
    /// amongst themselves, but not export outside of the `ServicePerimeter`. If a request with a source within this
    /// `ServicePerimeter` has a target outside of the `ServicePerimeter`, the request will be blocked. Otherwise the
    /// request is allowed. There are two types of Service Perimeter - Regular and Bridge. Regular Service Perimeters
    /// cannot overlap, a single Google Cloud project can only belong to a single regular Service Perimeter. Service
    /// Perimeter Bridges can contain only Google Cloud projects as members, a single Google Cloud project may belong to
    /// multiple Service Perimeter Bridges.</summary>
    public class GoogleIdentityAccesscontextmanagerV1ServicePerimeter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the `ServicePerimeter` and its use. Does not affect behavior.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Required. Resource name for the ServicePerimeter. The `short_name` component must begin with a
        /// letter and only include alphanumeric and '_'. Format:
        /// `accessPolicies/{policy_id}/servicePerimeters/{short_name}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Perimeter type indicator. A single project is allowed to be a member of single regular perimeter,
        /// but multiple service perimeter bridges. A project cannot be a included in a perimeter bridge without being
        /// included in regular perimeter. For perimeter bridges, the restricted service list as well as access level
        /// lists must be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("perimeterType")]
        public virtual string PerimeterType { get; set; } 

        /// <summary>Proposed (or dry run) ServicePerimeter configuration. This configuration allows to specify and test
        /// ServicePerimeter configuration without enforcing actual access restrictions. Only allowed to be set when the
        /// "use_explicit_dry_run_spec" flag is set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual GoogleIdentityAccesscontextmanagerV1ServicePerimeterConfig Spec { get; set; } 

        /// <summary>Current ServicePerimeter configuration. Specifies sets of resources, restricted services and access
        /// levels that determine perimeter content and boundaries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleIdentityAccesscontextmanagerV1ServicePerimeterConfig Status { get; set; } 

        /// <summary>Human readable title. Must be unique within the Policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>Use explicit dry run spec flag. Ordinarily, a dry-run spec implicitly exists for all Service
        /// Perimeters, and that spec is identical to the status for those Service Perimeters. When this flag is set, it
        /// inhibits the generation of the implicit spec, thereby allowing the user to explicitly provide a
        /// configuration ("spec") to use in a dry-run version of the Service Perimeter. This allows the user to test
        /// changes to the enforced config ("status") without actually enforcing them. This testing is done through
        /// analyzing the differences between currently enforced and suggested restrictions. use_explicit_dry_run_spec
        /// must bet set to True if any of the fields in the spec are set to non-default values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useExplicitDryRunSpec")]
        public virtual System.Nullable<bool> UseExplicitDryRunSpec { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>`ServicePerimeterConfig` specifies a set of Google Cloud resources that describe specific Service
    /// Perimeter configuration.</summary>
    public class GoogleIdentityAccesscontextmanagerV1ServicePerimeterConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of `AccessLevel` resource names that allow resources within the `ServicePerimeter` to be
        /// accessed from the internet. `AccessLevels` listed must be in the same policy as this `ServicePerimeter`.
        /// Referencing a nonexistent `AccessLevel` is a syntax error. If no `AccessLevel` names are listed, resources
        /// within the perimeter can only be accessed via Google Cloud calls with request origins within the perimeter.
        /// Example: `"accessPolicies/MY_POLICY/accessLevels/MY_LEVEL"`. For Service Perimeter Bridge, must be
        /// empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLevels")]
        public virtual System.Collections.Generic.IList<string> AccessLevels { get; set; } 

        /// <summary>A list of Google Cloud resources that are inside of the service perimeter. Currently only projects
        /// are allowed. Format: `projects/{project_number}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<string> Resources { get; set; } 

        /// <summary>Google Cloud services that are subject to the Service Perimeter restrictions. For example, if
        /// `storage.googleapis.com` is specified, access to the storage buckets inside the perimeter must meet the
        /// perimeter's access restrictions.</summary>
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
        /// <summary>The list of APIs usable within the Service Perimeter. Must be empty unless 'enable_restriction' is
        /// True. You can specify a list of individual services, as well as include the 'RESTRICTED-SERVICES' value,
        /// which automatically includes all of the services protected by the perimeter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedServices")]
        public virtual System.Collections.Generic.IList<string> AllowedServices { get; set; } 

        /// <summary>Whether to restrict API calls within the Service Perimeter to the list of APIs specified in
        /// 'allowed_services'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableRestriction")]
        public virtual System.Nullable<bool> EnableRestriction { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A result of IAM Policy search, containing information of an IAM policy.</summary>
    public class IamPolicySearchResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Explanation about the IAM policy search result. It contains additional information to explain why
        /// the search result matches the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explanation")]
        public virtual Explanation Explanation { get; set; } 

        /// <summary>The IAM policy directly set on the given resource. Note that the original IAM policy can contain
        /// multiple bindings. This only contains the bindings that match the given query. For queries that don't
        /// contain a constrain on policies (e.g., an empty query), this contains all the bindings. To search against
        /// the `policy` bindings: * use a field query: - query by the policy contained members. Example:
        /// `policy:amy@gmail.com` - query by the policy contained roles. Example: `policy:roles/compute.admin` - query
        /// by the policy contained roles' included permissions. Example:
        /// `policy.role.permissions:compute.instances.create`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; } 

        /// <summary>The project that the associated GCP resource belongs to, in the form of projects/{PROJECT_NUMBER}.
        /// If an IAM policy is set on a resource (like VM instance, Cloud Storage bucket), the project field will
        /// indicate the project that contains the resource. If an IAM policy is set on a folder or orgnization, the
        /// project field will be empty. To search against the `project`: * specify the `scope` field as this project in
        /// your search request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; } 

        /// <summary>The full resource name of the resource associated with this IAM policy. Example:
        /// `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1`. See [Cloud Asset
        /// Inventory Resource Name Format](https://cloud.google.com/asset-inventory/docs/resource-name-format) for more
        /// information. To search against the `resource`: * use a field query. Example:
        /// `resource:organizations/123`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; } 

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

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If the value is `false`, it means the operation is still in progress. If `true`, the operation is
        /// completed, and either `error` or `response` is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; } 

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; } 

        /// <summary>Service-specific metadata associated with the operation. It typically contains progress information
        /// and common metadata such as create time. Some services might not provide such metadata. Any method that
        /// returns a long-running operation should document the metadata type, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string,object> Metadata { get; set; } 

        /// <summary>The server-assigned name, which is only unique within the same service that originally returns it.
        /// If you use the default HTTP mapping, the `name` should be a resource name ending with
        /// `operations/{unique_id}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The normal response of the operation in case of success. If the original method returns no data on
        /// success, such as `Delete`, the response is `google.protobuf.Empty`. If the original method is standard
        /// `Get`/`Create`/`Update`, the response should be the resource. For other methods, the response should have
        /// the type `XxxResponse`, where `Xxx` is the original method name. For example, if the original method name is
        /// `TakeSnapshot()`, the inferred response type is `TakeSnapshotResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string,object> Response { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Output configuration for export assets destination.</summary>
    public class OutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Destination on BigQuery. The output table stores the fields in asset proto as columns in
        /// BigQuery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryDestination")]
        public virtual BigQueryDestination BigqueryDestination { get; set; } 

        /// <summary>Destination on Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual GcsDestination GcsDestination { get; set; } 

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

    /// <summary>An Identity and Access Management (IAM) policy, which specifies access controls for Google Cloud
    /// resources. A `Policy` is a collection of `bindings`. A `binding` binds one or more `members` to a single `role`.
    /// Members can be user accounts, service accounts, Google groups, and domains (such as G Suite). A `role` is a
    /// named list of permissions; each `role` can be an IAM predefined role or a user-created custom role. For some
    /// types of Google Cloud resources, a `binding` can also specify a `condition`, which is a logical expression that
    /// allows access to a resource only if the expression evaluates to `true`. A condition can add constraints based on
    /// attributes of the request, the resource, or both. To learn which resources support conditions in their IAM
    /// policies, see the [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON
    /// example:** { "bindings": [ { "role": "roles/resourcemanager.organizationAdmin", "members": [
    /// "user:mike@example.com", "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-
    /// id@appspot.gserviceaccount.com" ] }, { "role": "roles/resourcemanager.organizationViewer", "members": [
    /// "user:eve@example.com" ], "condition": { "title": "expirable access", "description": "Does not grant access
    /// after Sep 2020", "expression": "request.time < timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag":
    /// "BwWWja0YfJA=", "version": 3 } **YAML example:** bindings: - members: - user:mike@example.com -
    /// group:admins@example.com - domain:google.com - serviceAccount:my-project-id@appspot.gserviceaccount.com role:
    /// roles/resourcemanager.organizationAdmin - members: - user:eve@example.com role:
    /// roles/resourcemanager.organizationViewer condition: title: expirable access description: Does not grant access
    /// after Sep 2020 expression: request.time < timestamp('2020-10-01T00:00:00.000Z') - etag: BwWWja0YfJA= - version:
    /// 3 For a description of IAM and its features, see the [IAM
    /// documentation](https://cloud.google.com/iam/docs/).</summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<AuditConfig> AuditConfigs { get; set; } 

        /// <summary>Associates a list of `members` to a `role`. Optionally, may specify a `condition` that determines
        /// how and when the `bindings` are applied. Each of the `bindings` must contain at least one member.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<Binding> Bindings { get; set; } 

        /// <summary>`etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of
        /// a policy from overwriting each other. It is strongly suggested that systems make use of the `etag` in the
        /// read-modify-write cycle to perform policy updates in order to avoid race conditions: An `etag` is returned
        /// in the response to `getIamPolicy`, and systems are expected to put that etag in the request to
        /// `setIamPolicy` to ensure that their change will be applied to the same version of the policy. **Important:**
        /// If you use IAM Conditions, you must include the `etag` field whenever you call `setIamPolicy`. If you omit
        /// this field, then IAM allows you to overwrite a version `3` policy with a version `1` policy, and all of the
        /// conditions in the version `3` policy are lost.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>Specifies the format of the policy. Valid values are `0`, `1`, and `3`. Requests that specify an
        /// invalid value are rejected. Any operation that affects conditional role bindings must specify version `3`.
        /// This requirement applies to the following operations: * Getting a policy that includes a conditional role
        /// binding * Adding a conditional role binding to a policy * Changing a conditional role binding in a policy *
        /// Removing any role binding, with or without a condition, from a policy that includes conditions
        /// **Important:** If you use IAM Conditions, you must include the `etag` field whenever you call
        /// `setIamPolicy`. If you omit this field, then IAM allows you to overwrite a version `3` policy with a version
        /// `1` policy, and all of the conditions in the version `3` policy are lost. If a policy does not include any
        /// conditions, operations on that policy may specify any valid version or leave the field unset. To learn which
        /// resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; } 

    }    

    /// <summary>A Pub/Sub destination.</summary>
    public class PubsubDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the Pub/Sub topic to publish to. Example:
        /// `projects/PROJECT_ID/topics/TOPIC_ID`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A representation of a Google Cloud resource.</summary>
    public class Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The content of the resource, in which some sensitive fields are removed and may not be
        /// present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual System.Collections.Generic.IDictionary<string,object> Data { get; set; } 

        /// <summary>The URL of the discovery document containing the resource's JSON schema. Example:
        /// `https://www.googleapis.com/discovery/v1/apis/compute/v1/rest` This value is unspecified for resources that
        /// do not have an API based on a discovery document, such as Cloud Bigtable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discoveryDocumentUri")]
        public virtual string DiscoveryDocumentUri { get; set; } 

        /// <summary>The JSON schema name listed in the discovery document. Example: `Project` This value is unspecified
        /// for resources that do not have an API based on a discovery document, such as Cloud Bigtable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discoveryName")]
        public virtual string DiscoveryName { get; set; } 

        /// <summary>The location of the resource in Google Cloud, such as its zone and region. For more information,
        /// see https://cloud.google.com/about/locations/.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; } 

        /// <summary>The full name of the immediate parent of this resource. See [Resource
        /// Names](https://cloud.google.com/apis/design/resource_names#full_resource_name) for more information. For
        /// Google Cloud assets, this value is the parent resource defined in the [Cloud IAM policy
        /// hierarchy](https://cloud.google.com/iam/docs/overview#policy_hierarchy). Example:
        /// `//cloudresourcemanager.googleapis.com/projects/my_project_123` For third-party assets, this field may be
        /// set differently.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; } 

        /// <summary>The REST URL for accessing the resource. An HTTP `GET` request using this URL returns the resource
        /// itself. Example: `https://cloudresourcemanager.googleapis.com/v1/projects/my-project-123` This value is
        /// unspecified for resources without a REST API.</summary>
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
        /// <summary>The additional searchable attributes of this resource. The attributes may vary from one resource
        /// type to another. Examples: `projectId` for Project, `dnsName` for DNS ManagedZone. This field contains a
        /// subset of the resource metadata fields that are returned by the List or Get APIs provided by the
        /// corresponding GCP service (e.g., Compute Engine). see [API references and supported searchable
        /// attributes](https://cloud.google.com/asset-inventory/docs/supported-asset-types#searchable_asset_types) for
        /// more information. You can search values of these fields through free text search. However, you should not
        /// consume the field programically as the field names and values may change as the GCP service updates to a new
        /// incompatible API version. To search against the `additional_attributes`: * use a free text query to match
        /// the attributes values. Example: to search `additional_attributes = { dnsName: "foobar" }`, you can issue a
        /// query `foobar`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalAttributes")]
        public virtual System.Collections.Generic.IDictionary<string,object> AdditionalAttributes { get; set; } 

        /// <summary>The type of this resource. Example: `compute.googleapis.com/Disk`. To search against the
        /// `asset_type`: * specify the `asset_type` field in your search request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetType")]
        public virtual string AssetType { get; set; } 

        /// <summary>One or more paragraphs of text description of this resource. Maximum length could be up to 1M
        /// bytes. To search against the `description`: * use a field query. Example: `description:"*important
        /// instance*"` * use a free text query. Example: `"*important instance*"`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>The display name of this resource. To search against the `display_name`: * use a field query.
        /// Example: `displayName:"My Instance"` * use a free text query. Example: `"My Instance"`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Labels associated with this resource. See [Labelling and grouping GCP
        /// resources](https://cloud.google.com/blog/products/gcp/labelling-and-grouping-your-google-cloud-platform-
        /// resources) for more information. To search against the `labels`: * use a field query: - query on any label's
        /// key or value. Example: `labels:prod` - query by a given label. Example: `labels.env:prod` - query by a given
        /// label's existence. Example: `labels.env:*` * use a free text query. Example: `prod`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string,string> Labels { get; set; } 

        /// <summary>Location can be `global`, regional like `us-east1`, or zonal like `us-west1-b`. To search against
        /// the `location`: * use a field query. Example: `location:us-west*` * use a free text query. Example: `us-
        /// west*`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; } 

        /// <summary>The full resource name of this resource. Example:
        /// `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1`. See [Cloud Asset
        /// Inventory Resource Name Format](https://cloud.google.com/asset-inventory/docs/resource-name-format) for more
        /// information. To search against the `name`: * use a field query. Example: `name:instance1` * use a free text
        /// query. Example: `instance1`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Network tags associated with this resource. Like labels, network tags are a type of annotations
        /// used to group GCP resources. See [Labelling GCP resources](https://cloud.google.com/blog/products/gcp
        /// /labelling-and-grouping-your-google-cloud-platform-resources) for more information. To search against the
        /// `network_tags`: * use a field query. Example: `networkTags:internal` * use a free text query. Example:
        /// `internal`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkTags")]
        public virtual System.Collections.Generic.IList<string> NetworkTags { get; set; } 

        /// <summary>The project that this resource belongs to, in the form of projects/{PROJECT_NUMBER}. To search
        /// against the `project`: * specify the `scope` field as this project in your search request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Search all IAM policies response.</summary>
    public class SearchAllIamPoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Set if there are more results than those appearing in this response; to get the next set of
        /// results, call this method again, using this value as the `page_token`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>A list of IamPolicy that match the search query. Related information such as the associated
        /// resource is returned along with the policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<IamPolicySearchResult> Results { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Search all resources response.</summary>
    public class SearchAllResourcesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If there are more results than those appearing in this response, then `next_page_token` is
        /// included. To get the next set of results, call this method again using the value of `next_page_token` as
        /// `page_token`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>A list of Resources that match the search query. It contains the resource standard metadata
        /// information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<ResourceSearchResult> Results { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The `Status` type defines a logical error model that is suitable for different programming
    /// environments, including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status`
    /// message contains three pieces of data: error code, error message, and error details. You can find out more about
    /// this error model and how to work with it in the [API Design
    /// Guide](https://cloud.google.com/apis/design/errors).</summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; } 

        /// <summary>A list of messages that carry the error details. There is a common set of message types for APIs to
        /// use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string,object>> Details { get; set; } 

        /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should
        /// be localized and sent in the google.rpc.Status.details field, or localized by the client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An asset in Google Cloud and its temporal metadata, including the time window when it was observed and
    /// its status during that window.</summary>
    public class TemporalAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An asset in Google Cloud.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public virtual Asset Asset { get; set; } 

        /// <summary>Whether the asset has been deleted or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleted")]
        public virtual System.Nullable<bool> Deleted { get; set; } 

        /// <summary>Prior copy of the asset. Populated if prior_asset_state is PRESENT. Currently this is only set for
        /// responses in Real-Time Feed.</summary>
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
        /// <summary>End time of the time window (inclusive). If not specified, the current timestamp is used
        /// instead.</summary>
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
        /// <summary>Required. The new values of feed details. It must match an existing feed and the field `name` must
        /// be in the format of: projects/project_number/feeds/feed_id or folders/folder_number/feeds/feed_id or
        /// organizations/organization_number/feeds/feed_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feed")]
        public virtual Feed Feed { get; set; } 

        /// <summary>Required. Only updates the `feed` fields indicated by this mask. The field mask must not be empty,
        /// and it must not contain fields that are immutable or only set by the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
