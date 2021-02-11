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

namespace Google.Apis.CloudAsset.v1p7beta1
{
    /// <summary>The CloudAsset Service.</summary>
    public class CloudAssetService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1p7beta1";

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
            V1p7beta1 = new V1p7beta1Resource(this);
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

        /// <summary>Gets the V1p7beta1 resource.</summary>
        public virtual V1p7beta1Resource V1p7beta1 { get; }
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
            Value1,

            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
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

    /// <summary>The "v1p7beta1" collection of methods.</summary>
    public class V1p7beta1Resource
    {
        private const string Resource = "v1p7beta1";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public V1p7beta1Resource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Exports assets with time and resource types to a given Cloud Storage location/BigQuery table. For Cloud
        /// Storage location destinations, the output format is newline-delimited JSON. Each line represents a
        /// google.cloud.asset.v1p7beta1.Asset in the JSON format; for BigQuery table destinations, the output table
        /// stores the fields in asset proto as columns. This API implements the google.longrunning.Operation API ,
        /// which allows you to keep track of the export. We recommend intervals of at least 2 seconds with exponential
        /// retry to poll the export operation result. For regular-size resource parent, the export operation usually
        /// finishes within 5 minutes.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. The relative name of the root asset. This can only be an organization number (such as
        /// "organizations/123"), a project ID (such as "projects/my-project-id"), or a project number (such as
        /// "projects/12345"), or a folder number (such as "folders/123").
        /// </param>
        public virtual ExportAssetsRequest ExportAssets(Google.Apis.CloudAsset.v1p7beta1.Data.ExportAssetsRequest body, string parent)
        {
            return new ExportAssetsRequest(service, body, parent);
        }

        /// <summary>
        /// Exports assets with time and resource types to a given Cloud Storage location/BigQuery table. For Cloud
        /// Storage location destinations, the output format is newline-delimited JSON. Each line represents a
        /// google.cloud.asset.v1p7beta1.Asset in the JSON format; for BigQuery table destinations, the output table
        /// stores the fields in asset proto as columns. This API implements the google.longrunning.Operation API ,
        /// which allows you to keep track of the export. We recommend intervals of at least 2 seconds with exponential
        /// retry to poll the export operation result. For regular-size resource parent, the export operation usually
        /// finishes within 5 minutes.
        /// </summary>
        public class ExportAssetsRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1p7beta1.Data.Operation>
        {
            /// <summary>Constructs a new ExportAssets request.</summary>
            public ExportAssetsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAsset.v1p7beta1.Data.ExportAssetsRequest body, string parent) : base(service)
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
            Google.Apis.CloudAsset.v1p7beta1.Data.ExportAssetsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "exportAssets";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1p7beta1/{+parent}:exportAssets";

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
    }
}
namespace Google.Apis.CloudAsset.v1p7beta1.Data
{
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

        /// <summary>
        /// A list of relationship types to export, for example: `INSTANCE_TO_INSTANCEGROUP`. This field should only be
        /// specified if content_type=RELATIONSHIP. If specified, it will snapshot [asset_types]' specified
        /// relationships, or give errors if any relationship_types' supported types are not in [asset_types]. If not
        /// specified, it will snapshot all [asset_types]' supported relationships. An unspecified [asset_types] field
        /// means all supported asset_types. See [Introduction to Cloud Asset
        /// Inventory](https://cloud.google.com/asset-inventory/docs/overview) for all supported asset types and
        /// relationship types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relationshipTypes")]
        public virtual System.Collections.Generic.IList<string> RelationshipTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Cloud Storage location.</summary>
    public class GcsDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The uri of the Cloud Storage object. It's the same uri that is used by gsutil. Example:
        /// "gs://bucket_name/object_name". See [Viewing and Editing Object
        /// Metadata](https://cloud.google.com/storage/docs/viewing-editing-metadata) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>
        /// The uri prefix of all generated Cloud Storage objects. Example: "gs://bucket_name/object_name_prefix". Each
        /// object uri is in format: "gs://bucket_name/object_name_prefix/{ASSET_TYPE}/{SHARD_NUMBER} and only contains
        /// assets for that type. starts from 0. Example:
        /// "gs://bucket_name/object_name_prefix/compute.googleapis.com/Disk/0" is the first shard of output objects
        /// containing all compute.googleapis.com/Disk assets. An INVALID_ARGUMENT error will be returned if file with
        /// the same name "gs://bucket_name/object_name_prefix" already exists.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uriPrefix")]
        public virtual string UriPrefix { get; set; }

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
}
