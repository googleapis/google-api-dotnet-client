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

namespace Google.Apis.Bigquery.v2
{
    /// <summary>The Bigquery Service.</summary>
    public class BigqueryService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public BigqueryService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public BigqueryService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Datasets = new DatasetsResource(this);
            Jobs = new JobsResource(this);
            Models = new ModelsResource(this);
            Projects = new ProjectsResource(this);
            Routines = new RoutinesResource(this);
            RowAccessPolicies = new RowAccessPoliciesResource(this);
            Tabledata = new TabledataResource(this);
            Tables = new TablesResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://bigquery.googleapis.com/bigquery/v2/");
            BatchUri = GetEffectiveUri(null, "https://bigquery.googleapis.com/batch/bigquery/v2");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "bigquery";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "bigquery/v2/";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch/bigquery/v2";

        /// <summary>Available OAuth 2.0 scopes for use with the BigQuery API.</summary>
        public class Scope
        {
            /// <summary>
            /// View and manage your data in Google BigQuery and see the email address for your Google Account
            /// </summary>
            public static string Bigquery = "https://www.googleapis.com/auth/bigquery";

            /// <summary>Insert data into Google BigQuery</summary>
            public static string BigqueryInsertdata = "https://www.googleapis.com/auth/bigquery.insertdata";

            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>
            /// View your data across Google Cloud services and see the email address of your Google Account
            /// </summary>
            public static string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";

            /// <summary>
            /// Manage your data and permissions in Cloud Storage and see the email address for your Google Account
            /// </summary>
            public static string DevstorageFullControl = "https://www.googleapis.com/auth/devstorage.full_control";

            /// <summary>View your data in Google Cloud Storage</summary>
            public static string DevstorageReadOnly = "https://www.googleapis.com/auth/devstorage.read_only";

            /// <summary>Manage your data in Cloud Storage and see the email address of your Google Account</summary>
            public static string DevstorageReadWrite = "https://www.googleapis.com/auth/devstorage.read_write";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the BigQuery API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// View and manage your data in Google BigQuery and see the email address for your Google Account
            /// </summary>
            public const string Bigquery = "https://www.googleapis.com/auth/bigquery";

            /// <summary>Insert data into Google BigQuery</summary>
            public const string BigqueryInsertdata = "https://www.googleapis.com/auth/bigquery.insertdata";

            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>
            /// View your data across Google Cloud services and see the email address of your Google Account
            /// </summary>
            public const string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";

            /// <summary>
            /// Manage your data and permissions in Cloud Storage and see the email address for your Google Account
            /// </summary>
            public const string DevstorageFullControl = "https://www.googleapis.com/auth/devstorage.full_control";

            /// <summary>View your data in Google Cloud Storage</summary>
            public const string DevstorageReadOnly = "https://www.googleapis.com/auth/devstorage.read_only";

            /// <summary>Manage your data in Cloud Storage and see the email address of your Google Account</summary>
            public const string DevstorageReadWrite = "https://www.googleapis.com/auth/devstorage.read_write";
        }

        /// <summary>Gets the Datasets resource.</summary>
        public virtual DatasetsResource Datasets { get; }

        /// <summary>Gets the Jobs resource.</summary>
        public virtual JobsResource Jobs { get; }

        /// <summary>Gets the Models resource.</summary>
        public virtual ModelsResource Models { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }

        /// <summary>Gets the Routines resource.</summary>
        public virtual RoutinesResource Routines { get; }

        /// <summary>Gets the RowAccessPolicies resource.</summary>
        public virtual RowAccessPoliciesResource RowAccessPolicies { get; }

        /// <summary>Gets the Tabledata resource.</summary>
        public virtual TabledataResource Tabledata { get; }

        /// <summary>Gets the Tables resource.</summary>
        public virtual TablesResource Tables { get; }
    }

    /// <summary>A base abstract class for Bigquery requests.</summary>
    public abstract class BigqueryBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new BigqueryBaseServiceRequest instance.</summary>
        protected BigqueryBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Bigquery parameter list.</summary>
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

    /// <summary>The "datasets" collection of methods.</summary>
    public class DatasetsResource
    {
        private const string Resource = "datasets";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DatasetsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Deletes the dataset specified by the datasetId value. Before you can delete a dataset, you must delete all
        /// its tables, either manually or by specifying deleteContents. Immediately after deletion, you can create
        /// another dataset with the same name.
        /// </summary>
        /// <param name="projectId">Required. Project ID of the dataset being deleted</param>
        /// <param name="datasetId">Required. Dataset ID of dataset being deleted</param>
        public virtual DeleteRequest Delete(string projectId, string datasetId)
        {
            return new DeleteRequest(this.service, projectId, datasetId);
        }

        /// <summary>
        /// Deletes the dataset specified by the datasetId value. Before you can delete a dataset, you must delete all
        /// its tables, either manually or by specifying deleteContents. Immediately after deletion, you can create
        /// another dataset with the same name.
        /// </summary>
        public class DeleteRequest : BigqueryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string projectId, string datasetId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                InitParameters();
            }

            /// <summary>Required. Project ID of the dataset being deleted</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of dataset being deleted</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>
            /// If True, delete all the tables in the dataset. If False and the dataset contains tables, the request
            /// will fail. Default is False
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("deleteContents", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> DeleteContents { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("deleteContents", new Google.Apis.Discovery.Parameter
                {
                    Name = "deleteContents",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns the dataset specified by datasetID.</summary>
        /// <param name="projectId">Required. Project ID of the requested dataset</param>
        /// <param name="datasetId">Required. Dataset ID of the requested dataset</param>
        public virtual GetRequest Get(string projectId, string datasetId)
        {
            return new GetRequest(this.service, projectId, datasetId);
        }

        /// <summary>Returns the dataset specified by datasetID.</summary>
        public class GetRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.Dataset>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string projectId, string datasetId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                InitParameters();
            }

            /// <summary>Required. Project ID of the requested dataset</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of the requested dataset</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>
            /// Optional. The version of the access policy schema to fetch. Valid values are 0, 1, and 3. Requests
            /// specifying an invalid value will be rejected. Requests for conditional access policy binding in datasets
            /// must specify version 3. Dataset with no conditional role bindings in access policy may specify any valid
            /// value or leave the field unset. This field will be mapped to [IAM Policy version]
            /// (https://cloud.google.com/iam/docs/policies#versions) and will be used to fetch policy from IAM. If
            /// unset or if 0 or 1 value is used for dataset with conditional bindings, access entry with condition will
            /// have role string appended by 'withcond' string followed by a hash value. For example : { "access": [ {
            /// "role": "roles/bigquery.dataViewer_with_conditionalbinding_7a34awqsda", "userByEmail":
            /// "user@example.com", } ] } Please refer https://cloud.google.com/iam/docs/troubleshooting-withcond for
            /// more details.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("accessPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> AccessPolicyVersion { get; set; }

            /// <summary>
            /// Optional. Specifies the view that determines which dataset information is returned. By default, metadata
            /// and ACL information are returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetView", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<DatasetViewEnum> DatasetView { get; set; }

            /// <summary>
            /// Optional. Specifies the view that determines which dataset information is returned. By default, metadata
            /// and ACL information are returned.
            /// </summary>
            public enum DatasetViewEnum
            {
                /// <summary>The default value. Default to the FULL view.</summary>
                [Google.Apis.Util.StringValueAttribute("DATASET_VIEW_UNSPECIFIED")]
                DATASETVIEWUNSPECIFIED = 0,

                /// <summary>
                /// Updates metadata information for the dataset, such as friendlyName, description, labels, etc.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("METADATA")]
                METADATA = 1,

                /// <summary>
                /// Updates ACL information for the dataset, which defines dataset access for one or more entities.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("ACL")]
                ACL = 2,

                /// <summary>Updates both dataset metadata and ACL information.</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL = 3,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("accessPolicyVersion", new Google.Apis.Discovery.Parameter
                {
                    Name = "accessPolicyVersion",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("datasetView", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetView",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Creates a new empty dataset.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. Project ID of the new dataset</param>
        public virtual InsertRequest Insert(Google.Apis.Bigquery.v2.Data.Dataset body, string projectId)
        {
            return new InsertRequest(this.service, body, projectId);
        }

        /// <summary>Creates a new empty dataset.</summary>
        public class InsertRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.Dataset>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Bigquery.v2.Data.Dataset body, string projectId) : base(service)
            {
                ProjectId = projectId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Project ID of the new dataset</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>
            /// Optional. The version of the provided access policy schema. Valid values are 0, 1, and 3. Requests
            /// specifying an invalid value will be rejected. This version refers to the schema version of the access
            /// policy and not the version of access policy. This field's value can be equal or more than the access
            /// policy schema provided in the request. For example, * Requests with conditional access policy binding in
            /// datasets must specify version 3. * But dataset with no conditional role bindings in access policy may
            /// specify any valid value or leave the field unset. If unset or if 0 or 1 value is used for dataset with
            /// conditional bindings, request will be rejected. This field will be mapped to IAM Policy version
            /// (https://cloud.google.com/iam/docs/policies#versions) and will be used to set policy in IAM.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("accessPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> AccessPolicyVersion { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.Dataset Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("accessPolicyVersion", new Google.Apis.Discovery.Parameter
                {
                    Name = "accessPolicyVersion",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Lists all datasets in the specified project to which the user has been granted the READER dataset role.
        /// </summary>
        /// <param name="projectId">Required. Project ID of the datasets to be listed</param>
        public virtual ListRequest List(string projectId)
        {
            return new ListRequest(this.service, projectId);
        }

        /// <summary>
        /// Lists all datasets in the specified project to which the user has been granted the READER dataset role.
        /// </summary>
        public class ListRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.DatasetList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string projectId) : base(service)
            {
                ProjectId = projectId;
                InitParameters();
            }

            /// <summary>Required. Project ID of the datasets to be listed</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Whether to list all datasets, including hidden ones</summary>
            [Google.Apis.Util.RequestParameterAttribute("all", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> All { get; set; }

            /// <summary>
            /// An expression for filtering the results of the request by label. The syntax is `labels.[:]`. Multiple
            /// filters can be AND-ed together by connecting with a space. Example: `labels.department:receiving
            /// labels.active`. See [Filtering datasets using
            /// labels](https://cloud.google.com/bigquery/docs/filtering-labels#filtering_datasets_using_labels) for
            /// details.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// The maximum number of results to return in a single response page. Leverage the page tokens to iterate
            /// through the entire collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Page token, returned by a previous call, to request the next page of results</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("all", new Google.Apis.Discovery.Parameter
                {
                    Name = "all",
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
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
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
        /// Updates information in an existing dataset. The update method replaces the entire dataset resource, whereas
        /// the patch method only replaces fields that are provided in the submitted dataset resource. This method
        /// supports RFC5789 patch semantics.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. Project ID of the dataset being updated</param>
        /// <param name="datasetId">Required. Dataset ID of the dataset being updated</param>
        public virtual PatchRequest Patch(Google.Apis.Bigquery.v2.Data.Dataset body, string projectId, string datasetId)
        {
            return new PatchRequest(this.service, body, projectId, datasetId);
        }

        /// <summary>
        /// Updates information in an existing dataset. The update method replaces the entire dataset resource, whereas
        /// the patch method only replaces fields that are provided in the submitted dataset resource. This method
        /// supports RFC5789 patch semantics.
        /// </summary>
        public class PatchRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.Dataset>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Bigquery.v2.Data.Dataset body, string projectId, string datasetId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Project ID of the dataset being updated</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of the dataset being updated</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>
            /// Optional. The version of the provided access policy schema. Valid values are 0, 1, and 3. Requests
            /// specifying an invalid value will be rejected. This version refers to the schema version of the access
            /// policy and not the version of access policy. This field's value can be equal or more than the access
            /// policy schema provided in the request. For example, * Operations updating conditional access policy
            /// binding in datasets must specify version 3. Some of the operations are : - Adding a new access policy
            /// entry with condition. - Removing an access policy entry with condition. - Updating an access policy
            /// entry with condition. * But dataset with no conditional role bindings in access policy may specify any
            /// valid value or leave the field unset. If unset or if 0 or 1 value is used for dataset with conditional
            /// bindings, request will be rejected. This field will be mapped to IAM Policy version
            /// (https://cloud.google.com/iam/docs/policies#versions) and will be used to set policy in IAM.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("accessPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> AccessPolicyVersion { get; set; }

            /// <summary>
            /// Optional. Specifies the fields of dataset that update/patch operation is targeting By default, both
            /// metadata and ACL fields are updated.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<UpdateModeEnum> UpdateMode { get; set; }

            /// <summary>
            /// Optional. Specifies the fields of dataset that update/patch operation is targeting By default, both
            /// metadata and ACL fields are updated.
            /// </summary>
            public enum UpdateModeEnum
            {
                /// <summary>The default value. Default to the UPDATE_FULL.</summary>
                [Google.Apis.Util.StringValueAttribute("UPDATE_MODE_UNSPECIFIED")]
                UPDATEMODEUNSPECIFIED = 0,

                /// <summary>
                /// Includes metadata information for the dataset, such as friendlyName, description, labels, etc.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("UPDATE_METADATA")]
                UPDATEMETADATA = 1,

                /// <summary>
                /// Includes ACL information for the dataset, which defines dataset access for one or more entities.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("UPDATE_ACL")]
                UPDATEACL = 2,

                /// <summary>Includes both dataset metadata and ACL information.</summary>
                [Google.Apis.Util.StringValueAttribute("UPDATE_FULL")]
                UPDATEFULL = 3,
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.Dataset Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("accessPolicyVersion", new Google.Apis.Discovery.Parameter
                {
                    Name = "accessPolicyVersion",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("updateMode", new Google.Apis.Discovery.Parameter
                {
                    Name = "updateMode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Undeletes a dataset which is within time travel window based on datasetId. If a time is specified, the
        /// dataset version deleted at that time is undeleted, else the last live version is undeleted.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. Project ID of the dataset to be undeleted</param>
        /// <param name="datasetId">Required. Dataset ID of dataset being deleted</param>
        public virtual UndeleteRequest Undelete(Google.Apis.Bigquery.v2.Data.UndeleteDatasetRequest body, string projectId, string datasetId)
        {
            return new UndeleteRequest(this.service, body, projectId, datasetId);
        }

        /// <summary>
        /// Undeletes a dataset which is within time travel window based on datasetId. If a time is specified, the
        /// dataset version deleted at that time is undeleted, else the last live version is undeleted.
        /// </summary>
        public class UndeleteRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.Dataset>
        {
            /// <summary>Constructs a new Undelete request.</summary>
            public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Bigquery.v2.Data.UndeleteDatasetRequest body, string projectId, string datasetId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Project ID of the dataset to be undeleted</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of dataset being deleted</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.UndeleteDatasetRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "undelete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}:undelete";

            /// <summary>Initializes Undelete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }
        }

        /// <summary>
        /// Updates information in an existing dataset. The update method replaces the entire dataset resource, whereas
        /// the patch method only replaces fields that are provided in the submitted dataset resource.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. Project ID of the dataset being updated</param>
        /// <param name="datasetId">Required. Dataset ID of the dataset being updated</param>
        public virtual UpdateRequest Update(Google.Apis.Bigquery.v2.Data.Dataset body, string projectId, string datasetId)
        {
            return new UpdateRequest(this.service, body, projectId, datasetId);
        }

        /// <summary>
        /// Updates information in an existing dataset. The update method replaces the entire dataset resource, whereas
        /// the patch method only replaces fields that are provided in the submitted dataset resource.
        /// </summary>
        public class UpdateRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.Dataset>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Bigquery.v2.Data.Dataset body, string projectId, string datasetId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Project ID of the dataset being updated</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of the dataset being updated</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>
            /// Optional. The version of the provided access policy schema. Valid values are 0, 1, and 3. Requests
            /// specifying an invalid value will be rejected. This version refers to the schema version of the access
            /// policy and not the version of access policy. This field's value can be equal or more than the access
            /// policy schema provided in the request. For example, * Operations updating conditional access policy
            /// binding in datasets must specify version 3. Some of the operations are : - Adding a new access policy
            /// entry with condition. - Removing an access policy entry with condition. - Updating an access policy
            /// entry with condition. * But dataset with no conditional role bindings in access policy may specify any
            /// valid value or leave the field unset. If unset or if 0 or 1 value is used for dataset with conditional
            /// bindings, request will be rejected. This field will be mapped to IAM Policy version
            /// (https://cloud.google.com/iam/docs/policies#versions) and will be used to set policy in IAM.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("accessPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> AccessPolicyVersion { get; set; }

            /// <summary>
            /// Optional. Specifies the fields of dataset that update/patch operation is targeting By default, both
            /// metadata and ACL fields are updated.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<UpdateModeEnum> UpdateMode { get; set; }

            /// <summary>
            /// Optional. Specifies the fields of dataset that update/patch operation is targeting By default, both
            /// metadata and ACL fields are updated.
            /// </summary>
            public enum UpdateModeEnum
            {
                /// <summary>The default value. Default to the UPDATE_FULL.</summary>
                [Google.Apis.Util.StringValueAttribute("UPDATE_MODE_UNSPECIFIED")]
                UPDATEMODEUNSPECIFIED = 0,

                /// <summary>
                /// Includes metadata information for the dataset, such as friendlyName, description, labels, etc.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("UPDATE_METADATA")]
                UPDATEMETADATA = 1,

                /// <summary>
                /// Includes ACL information for the dataset, which defines dataset access for one or more entities.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("UPDATE_ACL")]
                UPDATEACL = 2,

                /// <summary>Includes both dataset metadata and ACL information.</summary>
                [Google.Apis.Util.StringValueAttribute("UPDATE_FULL")]
                UPDATEFULL = 3,
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.Dataset Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("accessPolicyVersion", new Google.Apis.Discovery.Parameter
                {
                    Name = "accessPolicyVersion",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("updateMode", new Google.Apis.Discovery.Parameter
                {
                    Name = "updateMode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "jobs" collection of methods.</summary>
    public class JobsResource
    {
        private const string Resource = "jobs";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public JobsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Requests that a job be cancelled. This call will return immediately, and the client will need to poll for
        /// the job status to see if the cancel completed successfully. Cancelled jobs may still incur costs.
        /// </summary>
        /// <param name="projectId">Required. Project ID of the job to cancel</param>
        /// <param name="jobId">Required. Job ID of the job to cancel</param>
        public virtual CancelRequest Cancel(string projectId, string jobId)
        {
            return new CancelRequest(this.service, projectId, jobId);
        }

        /// <summary>
        /// Requests that a job be cancelled. This call will return immediately, and the client will need to poll for
        /// the job status to see if the cancel completed successfully. Cancelled jobs may still incur costs.
        /// </summary>
        public class CancelRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.JobCancelResponse>
        {
            /// <summary>Constructs a new Cancel request.</summary>
            public CancelRequest(Google.Apis.Services.IClientService service, string projectId, string jobId) : base(service)
            {
                ProjectId = projectId;
                JobId = jobId;
                InitParameters();
            }

            /// <summary>Required. Project ID of the job to cancel</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Job ID of the job to cancel</summary>
            [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string JobId { get; private set; }

            /// <summary>
            /// The geographic location of the job. You must [specify the
            /// location](https://cloud.google.com/bigquery/docs/locations#specify_locations) to run the job for the
            /// following scenarios: * If the location to run a job is not in the `us` or the `eu` multi-regional
            /// location * If the job's location is in a single region (for example, `us-central1`)
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Location { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "cancel";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/jobs/{+jobId}/cancel";

            /// <summary>Initializes Cancel parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                {
                    Name = "jobId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                {
                    Name = "location",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Requests the deletion of the metadata of a job. This call returns when the job's metadata is deleted.
        /// </summary>
        /// <param name="projectId">Required. Project ID of the job for which metadata is to be deleted.</param>
        /// <param name="jobId">
        /// Required. Job ID of the job for which metadata is to be deleted. If this is a parent job which has child
        /// jobs, the metadata from all child jobs will be deleted as well. Direct deletion of the metadata of child
        /// jobs is not allowed.
        /// </param>
        public virtual DeleteRequest Delete(string projectId, string jobId)
        {
            return new DeleteRequest(this.service, projectId, jobId);
        }

        /// <summary>
        /// Requests the deletion of the metadata of a job. This call returns when the job's metadata is deleted.
        /// </summary>
        public class DeleteRequest : BigqueryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string projectId, string jobId) : base(service)
            {
                ProjectId = projectId;
                JobId = jobId;
                InitParameters();
            }

            /// <summary>Required. Project ID of the job for which metadata is to be deleted.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>
            /// Required. Job ID of the job for which metadata is to be deleted. If this is a parent job which has child
            /// jobs, the metadata from all child jobs will be deleted as well. Direct deletion of the metadata of child
            /// jobs is not allowed.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string JobId { get; private set; }

            /// <summary>
            /// The geographic location of the job. Required. For more information, see how to [specify
            /// locations](https://cloud.google.com/bigquery/docs/locations#specify_locations).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Location { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/jobs/{+jobId}/delete";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                {
                    Name = "jobId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                {
                    Name = "location",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Returns information about a specific job. Job information is available for a six month period after
        /// creation. Requires that you're the person who ran the job, or have the Is Owner project role.
        /// </summary>
        /// <param name="projectId">Required. Project ID of the requested job.</param>
        /// <param name="jobId">Required. Job ID of the requested job.</param>
        public virtual GetRequest Get(string projectId, string jobId)
        {
            return new GetRequest(this.service, projectId, jobId);
        }

        /// <summary>
        /// Returns information about a specific job. Job information is available for a six month period after
        /// creation. Requires that you're the person who ran the job, or have the Is Owner project role.
        /// </summary>
        public class GetRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.Job>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string projectId, string jobId) : base(service)
            {
                ProjectId = projectId;
                JobId = jobId;
                InitParameters();
            }

            /// <summary>Required. Project ID of the requested job.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Job ID of the requested job.</summary>
            [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string JobId { get; private set; }

            /// <summary>
            /// The geographic location of the job. You must specify the location to run the job for the following
            /// scenarios: * If the location to run a job is not in the `us` or the `eu` multi-regional location * If
            /// the job's location is in a single region (for example, `us-central1`) For more information, see how to
            /// [specify locations](https://cloud.google.com/bigquery/docs/locations#specify_locations).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Location { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/jobs/{+jobId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                {
                    Name = "jobId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                {
                    Name = "location",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>RPC to get the results of a query job.</summary>
        /// <param name="projectId">Required. Project ID of the query job.</param>
        /// <param name="jobId">Required. Job ID of the query job.</param>
        public virtual GetQueryResultsRequest GetQueryResults(string projectId, string jobId)
        {
            return new GetQueryResultsRequest(this.service, projectId, jobId);
        }

        /// <summary>RPC to get the results of a query job.</summary>
        public class GetQueryResultsRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.GetQueryResultsResponse>
        {
            /// <summary>Constructs a new GetQueryResults request.</summary>
            public GetQueryResultsRequest(Google.Apis.Services.IClientService service, string projectId, string jobId) : base(service)
            {
                ProjectId = projectId;
                JobId = jobId;
                InitParameters();
            }

            /// <summary>Required. Project ID of the query job.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Job ID of the query job.</summary>
            [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string JobId { get; private set; }

            /// <summary>Optional. Output timestamp as usec int64. Default is false.</summary>
            [Google.Apis.Util.RequestParameterAttribute("formatOptions.useInt64Timestamp", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> FormatOptionsUseInt64Timestamp { get; set; }

            /// <summary>
            /// The geographic location of the job. You must specify the location to run the job for the following
            /// scenarios: * If the location to run a job is not in the `us` or the `eu` multi-regional location * If
            /// the job's location is in a single region (for example, `us-central1`) For more information, see how to
            /// [specify locations](https://cloud.google.com/bigquery/docs/locations#specify_locations).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Location { get; set; }

            /// <summary>Maximum number of results to read.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Page token, returned by a previous call, to request the next page of results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Zero-based index of the starting row.</summary>
            [Google.Apis.Util.RequestParameterAttribute("startIndex", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ulong> StartIndex { get; set; }

            /// <summary>
            /// Optional: Specifies the maximum amount of time, in milliseconds, that the client is willing to wait for
            /// the query to complete. By default, this limit is 10 seconds (10,000 milliseconds). If the query is
            /// complete, the jobComplete field in the response is true. If the query has not yet completed, jobComplete
            /// is false. You can request a longer timeout period in the timeoutMs field. However, the call is not
            /// guaranteed to wait for the specified timeout; it typically returns after around 200 seconds (200,000
            /// milliseconds), even if the query is not complete. If jobComplete is false, you can continue to wait for
            /// the query to complete by calling the getQueryResults method until the jobComplete field in the
            /// getQueryResults response is true.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("timeoutMs", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> TimeoutMs { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getQueryResults";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/queries/{+jobId}";

            /// <summary>Initializes GetQueryResults parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                {
                    Name = "jobId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("formatOptions.useInt64Timestamp", new Google.Apis.Discovery.Parameter
                {
                    Name = "formatOptions.useInt64Timestamp",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                {
                    Name = "location",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
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
                RequestParameters.Add("startIndex", new Google.Apis.Discovery.Parameter
                {
                    Name = "startIndex",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("timeoutMs", new Google.Apis.Discovery.Parameter
                {
                    Name = "timeoutMs",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Starts a new asynchronous job. This API has two different kinds of endpoint URIs, as this method supports a
        /// variety of use cases. * The *Metadata* URI is used for most interactions, as it accepts the job
        /// configuration directly. * The *Upload* URI is ONLY for the case when you're sending both a load job
        /// configuration and a data stream together. In this case, the Upload URI accepts the job configuration and the
        /// data as two distinct multipart MIME parts.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Project ID of project that will be billed for the job.</param>
        public virtual InsertRequest Insert(Google.Apis.Bigquery.v2.Data.Job body, string projectId)
        {
            return new InsertRequest(this.service, body, projectId);
        }

        /// <summary>
        /// Starts a new asynchronous job. This API has two different kinds of endpoint URIs, as this method supports a
        /// variety of use cases. * The *Metadata* URI is used for most interactions, as it accepts the job
        /// configuration directly. * The *Upload* URI is ONLY for the case when you're sending both a load job
        /// configuration and a data stream together. In this case, the Upload URI accepts the job configuration and the
        /// data as two distinct multipart MIME parts.
        /// </summary>
        public class InsertRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.Job>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Bigquery.v2.Data.Job body, string projectId) : base(service)
            {
                ProjectId = projectId;
                Body = body;
                InitParameters();
            }

            /// <summary>Project ID of project that will be billed for the job.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.Job Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/jobs";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }
        }

        /// <summary>
        /// Starts a new asynchronous job. This API has two different kinds of endpoint URIs, as this method supports a
        /// variety of use cases. * The *Metadata* URI is used for most interactions, as it accepts the job
        /// configuration directly. * The *Upload* URI is ONLY for the case when you're sending both a load job
        /// configuration and a data stream together. In this case, the Upload URI accepts the job configuration and the
        /// data as two distinct multipart MIME parts.
        /// </summary>
        /// <remarks>
        /// Considerations regarding <paramref name="stream"/>:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before reading
        /// commences. If <paramref name="stream"/> is not seekable, then it will be read from its current position
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
        /// </description>
        /// </item>
        /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
        /// </list>
        /// </remarks>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Project ID of project that will be billed for the job.</param>
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual InsertMediaUpload Insert(Google.Apis.Bigquery.v2.Data.Job body, string projectId, System.IO.Stream stream, string contentType)
        {
            return new InsertMediaUpload(service, body, projectId, stream, contentType);
        }

        /// <summary>Insert media upload which supports resumable upload.</summary>
        public class InsertMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.Bigquery.v2.Data.Job, Google.Apis.Bigquery.v2.Data.Job>
        {
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
            /// API key. Your API key identifies your project and provides you with API access, quota, and reports.
            /// Required unless you provide an OAuth 2.0 token.
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
            /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned
            /// to a user, but should not exceed 40 characters.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser { get; set; }

            /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
            [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UploadType { get; set; }

            /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
            [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UploadProtocol { get; set; }

            /// <summary>Project ID of project that will be billed for the job.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Constructs a new Insert media upload instance.</summary>
            /// <remarks>
            /// Considerations regarding <paramref name="stream"/>:
            /// <list type="bullet">
            /// <item>
            /// <description>
            /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
            /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its current
            /// position
            /// </description>
            /// </item>
            /// <item>
            /// <description>
            /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
            /// </description>
            /// </item>
            /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
            /// </list>
            /// </remarks>
            public InsertMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.Bigquery.v2.Data.Job body, string projectId, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "projects/{+projectId}/jobs"), "POST", stream, contentType)
            {
                ProjectId = projectId;
                Body = body;
            }
        }

        /// <summary>
        /// Lists all jobs that you started in the specified project. Job information is available for a six month
        /// period after creation. The job list is sorted in reverse chronological order, by job creation time. Requires
        /// the Can View project role, or the Is Owner project role if you set the allUsers property.
        /// </summary>
        /// <param name="projectId">Project ID of the jobs to list.</param>
        public virtual ListRequest List(string projectId)
        {
            return new ListRequest(this.service, projectId);
        }

        /// <summary>
        /// Lists all jobs that you started in the specified project. Job information is available for a six month
        /// period after creation. The job list is sorted in reverse chronological order, by job creation time. Requires
        /// the Can View project role, or the Is Owner project role if you set the allUsers property.
        /// </summary>
        public class ListRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.JobList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string projectId) : base(service)
            {
                ProjectId = projectId;
                InitParameters();
            }

            /// <summary>Project ID of the jobs to list.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Whether to display jobs owned by all users in the project. Default False.</summary>
            [Google.Apis.Util.RequestParameterAttribute("allUsers", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AllUsers { get; set; }

            /// <summary>
            /// Max value for job creation time, in milliseconds since the POSIX epoch. If set, only jobs created before
            /// or at this timestamp are returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxCreationTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ulong> MaxCreationTime { get; set; }

            /// <summary>
            /// The maximum number of results to return in a single response page. Leverage the page tokens to iterate
            /// through the entire collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// Min value for job creation time, in milliseconds since the POSIX epoch. If set, only jobs created after
            /// or at this timestamp are returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("minCreationTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ulong> MinCreationTime { get; set; }

            /// <summary>Page token, returned by a previous call, to request the next page of results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// If set, show only child jobs of the specified parent. Otherwise, show all top-level jobs.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parentJobId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ParentJobId { get; set; }

            /// <summary>Restrict information returned to a set of selected fields</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Restrict information returned to a set of selected fields</summary>
            public enum ProjectionEnum
            {
                /// <summary>Includes all job data</summary>
                [Google.Apis.Util.StringValueAttribute("full")]
                Full = 0,

                /// <summary>Does not include the job configuration</summary>
                [Google.Apis.Util.StringValueAttribute("minimal")]
                Minimal = 1,
            }

            /// <summary>Filter for job state</summary>
            /// <remarks>
            /// Use this property to set a single value for the parameter, or <see cref="StateFilterList"/> to set
            /// multiple values. Do not set both properties.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("stateFilter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<StateFilterEnum> StateFilter { get; set; }

            /// <summary>Filter for job state</summary>
            /// <remarks>
            /// Use this property to set one or more values for the parameter. Do not set both this property and
            /// <see cref="StateFilter"/>.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("stateFilter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<StateFilterEnum> StateFilterList { get; set; }

            /// <summary>Filter for job state</summary>
            public enum StateFilterEnum
            {
                /// <summary>Finished jobs</summary>
                [Google.Apis.Util.StringValueAttribute("done")]
                Done = 0,

                /// <summary>Pending jobs</summary>
                [Google.Apis.Util.StringValueAttribute("pending")]
                Pending = 1,

                /// <summary>Running jobs</summary>
                [Google.Apis.Util.StringValueAttribute("running")]
                Running = 2,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/jobs";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("allUsers", new Google.Apis.Discovery.Parameter
                {
                    Name = "allUsers",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxCreationTime", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxCreationTime",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("minCreationTime", new Google.Apis.Discovery.Parameter
                {
                    Name = "minCreationTime",
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
                RequestParameters.Add("parentJobId", new Google.Apis.Discovery.Parameter
                {
                    Name = "parentJobId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("stateFilter", new Google.Apis.Discovery.Parameter
                {
                    Name = "stateFilter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Runs a BigQuery SQL query synchronously and returns query results if the query completes within a specified
        /// timeout.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. Project ID of the query request.</param>
        public virtual QueryRequest Query(Google.Apis.Bigquery.v2.Data.QueryRequest body, string projectId)
        {
            return new QueryRequest(this.service, body, projectId);
        }

        /// <summary>
        /// Runs a BigQuery SQL query synchronously and returns query results if the query completes within a specified
        /// timeout.
        /// </summary>
        public class QueryRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.QueryResponse>
        {
            /// <summary>Constructs a new Query request.</summary>
            public QueryRequest(Google.Apis.Services.IClientService service, Google.Apis.Bigquery.v2.Data.QueryRequest body, string projectId) : base(service)
            {
                ProjectId = projectId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Project ID of the query request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.QueryRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "query";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/queries";

            /// <summary>Initializes Query parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }
        }
    }

    /// <summary>The "models" collection of methods.</summary>
    public class ModelsResource
    {
        private const string Resource = "models";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ModelsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes the model specified by modelId from the dataset.</summary>
        /// <param name="projectId">Required. Project ID of the model to delete.</param>
        /// <param name="datasetId">Required. Dataset ID of the model to delete.</param>
        /// <param name="modelId">Required. Model ID of the model to delete.</param>
        public virtual DeleteRequest Delete(string projectId, string datasetId, string modelId)
        {
            return new DeleteRequest(this.service, projectId, datasetId, modelId);
        }

        /// <summary>Deletes the model specified by modelId from the dataset.</summary>
        public class DeleteRequest : BigqueryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string projectId, string datasetId, string modelId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                ModelId = modelId;
                InitParameters();
            }

            /// <summary>Required. Project ID of the model to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of the model to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Required. Model ID of the model to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("modelId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ModelId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}/models/{+modelId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("modelId", new Google.Apis.Discovery.Parameter
                {
                    Name = "modelId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }
        }

        /// <summary>Gets the specified model resource by model ID.</summary>
        /// <param name="projectId">Required. Project ID of the requested model.</param>
        /// <param name="datasetId">Required. Dataset ID of the requested model.</param>
        /// <param name="modelId">Required. Model ID of the requested model.</param>
        public virtual GetRequest Get(string projectId, string datasetId, string modelId)
        {
            return new GetRequest(this.service, projectId, datasetId, modelId);
        }

        /// <summary>Gets the specified model resource by model ID.</summary>
        public class GetRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.Model>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string projectId, string datasetId, string modelId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                ModelId = modelId;
                InitParameters();
            }

            /// <summary>Required. Project ID of the requested model.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of the requested model.</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Required. Model ID of the requested model.</summary>
            [Google.Apis.Util.RequestParameterAttribute("modelId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ModelId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}/models/{+modelId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("modelId", new Google.Apis.Discovery.Parameter
                {
                    Name = "modelId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }
        }

        /// <summary>
        /// Lists all models in the specified dataset. Requires the READER dataset role. After retrieving the list of
        /// models, you can get information about a particular model by calling the models.get method.
        /// </summary>
        /// <param name="projectId">Required. Project ID of the models to list.</param>
        /// <param name="datasetId">Required. Dataset ID of the models to list.</param>
        public virtual ListRequest List(string projectId, string datasetId)
        {
            return new ListRequest(this.service, projectId, datasetId);
        }

        /// <summary>
        /// Lists all models in the specified dataset. Requires the READER dataset role. After retrieving the list of
        /// models, you can get information about a particular model by calling the models.get method.
        /// </summary>
        public class ListRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.ListModelsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string projectId, string datasetId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                InitParameters();
            }

            /// <summary>Required. Project ID of the models to list.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of the models to list.</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>
            /// The maximum number of results to return in a single response page. Leverage the page tokens to iterate
            /// through the entire collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Page token, returned by a previous call to request the next page of results</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}/models";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
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

        /// <summary>Patch specific fields in the specified model.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. Project ID of the model to patch.</param>
        /// <param name="datasetId">Required. Dataset ID of the model to patch.</param>
        /// <param name="modelId">Required. Model ID of the model to patch.</param>
        public virtual PatchRequest Patch(Google.Apis.Bigquery.v2.Data.Model body, string projectId, string datasetId, string modelId)
        {
            return new PatchRequest(this.service, body, projectId, datasetId, modelId);
        }

        /// <summary>Patch specific fields in the specified model.</summary>
        public class PatchRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.Model>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Bigquery.v2.Data.Model body, string projectId, string datasetId, string modelId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                ModelId = modelId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Project ID of the model to patch.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of the model to patch.</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Required. Model ID of the model to patch.</summary>
            [Google.Apis.Util.RequestParameterAttribute("modelId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ModelId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.Model Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}/models/{+modelId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("modelId", new Google.Apis.Discovery.Parameter
                {
                    Name = "modelId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }
        }
    }

    /// <summary>The "projects" collection of methods.</summary>
    public class ProjectsResource
    {
        private const string Resource = "projects";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProjectsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>RPC to get the service account for a project used for interactions with Google Cloud KMS</summary>
        /// <param name="projectId">Required. ID of the project.</param>
        public virtual GetServiceAccountRequest GetServiceAccount(string projectId)
        {
            return new GetServiceAccountRequest(this.service, projectId);
        }

        /// <summary>RPC to get the service account for a project used for interactions with Google Cloud KMS</summary>
        public class GetServiceAccountRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.GetServiceAccountResponse>
        {
            /// <summary>Constructs a new GetServiceAccount request.</summary>
            public GetServiceAccountRequest(Google.Apis.Services.IClientService service, string projectId) : base(service)
            {
                ProjectId = projectId;
                InitParameters();
            }

            /// <summary>Required. ID of the project.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getServiceAccount";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/serviceAccount";

            /// <summary>Initializes GetServiceAccount parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }
        }

        /// <summary>
        /// RPC to list projects to which the user has been granted any project role. Users of this method are
        /// encouraged to consider the [Resource Manager](https://cloud.google.com/resource-manager/docs/) API, which
        /// provides the underlying data for this method and has more capabilities.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        /// RPC to list projects to which the user has been granted any project role. Users of this method are
        /// encouraged to consider the [Resource Manager](https://cloud.google.com/resource-manager/docs/) API, which
        /// provides the underlying data for this method and has more capabilities.
        /// </summary>
        public class ListRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.ProjectList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// `maxResults` unset returns all results, up to 50 per page. Additionally, the number of projects in a
            /// page may be fewer than `maxResults` because projects are retrieved and then filtered to only projects
            /// with the BigQuery API enabled.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// Page token, returned by a previous call, to request the next page of results. If not present, no further
            /// pages are present.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
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

    /// <summary>The "routines" collection of methods.</summary>
    public class RoutinesResource
    {
        private const string Resource = "routines";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public RoutinesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes the routine specified by routineId from the dataset.</summary>
        /// <param name="projectId">Required. Project ID of the routine to delete</param>
        /// <param name="datasetId">Required. Dataset ID of the routine to delete</param>
        /// <param name="routineId">Required. Routine ID of the routine to delete</param>
        public virtual DeleteRequest Delete(string projectId, string datasetId, string routineId)
        {
            return new DeleteRequest(this.service, projectId, datasetId, routineId);
        }

        /// <summary>Deletes the routine specified by routineId from the dataset.</summary>
        public class DeleteRequest : BigqueryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string projectId, string datasetId, string routineId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                RoutineId = routineId;
                InitParameters();
            }

            /// <summary>Required. Project ID of the routine to delete</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of the routine to delete</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Required. Routine ID of the routine to delete</summary>
            [Google.Apis.Util.RequestParameterAttribute("routineId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string RoutineId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}/routines/{+routineId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("routineId", new Google.Apis.Discovery.Parameter
                {
                    Name = "routineId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }
        }

        /// <summary>Gets the specified routine resource by routine ID.</summary>
        /// <param name="projectId">Required. Project ID of the requested routine</param>
        /// <param name="datasetId">Required. Dataset ID of the requested routine</param>
        /// <param name="routineId">Required. Routine ID of the requested routine</param>
        public virtual GetRequest Get(string projectId, string datasetId, string routineId)
        {
            return new GetRequest(this.service, projectId, datasetId, routineId);
        }

        /// <summary>Gets the specified routine resource by routine ID.</summary>
        public class GetRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.Routine>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string projectId, string datasetId, string routineId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                RoutineId = routineId;
                InitParameters();
            }

            /// <summary>Required. Project ID of the requested routine</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of the requested routine</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Required. Routine ID of the requested routine</summary>
            [Google.Apis.Util.RequestParameterAttribute("routineId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string RoutineId { get; private set; }

            /// <summary>
            /// If set, only the Routine fields in the field mask are returned in the response. If unset, all Routine
            /// fields are returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object ReadMask { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}/routines/{+routineId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("routineId", new Google.Apis.Discovery.Parameter
                {
                    Name = "routineId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
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

        /// <summary>
        /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does not
        /// have a policy set.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested. See [Resource
        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
        /// </param>
        public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.Bigquery.v2.Data.GetIamPolicyRequest body, string resource)
        {
            return new GetIamPolicyRequest(this.service, body, resource);
        }

        /// <summary>
        /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does not
        /// have a policy set.
        /// </summary>
        public class GetIamPolicyRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.Policy>
        {
            /// <summary>Constructs a new GetIamPolicy request.</summary>
            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Bigquery.v2.Data.GetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.GetIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{+resource}:getIamPolicy";

            /// <summary>Initializes GetIamPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/datasets/[^/]+/routines/[^/]+$",
                });
            }
        }

        /// <summary>Creates a new routine in the dataset.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. Project ID of the new routine</param>
        /// <param name="datasetId">Required. Dataset ID of the new routine</param>
        public virtual InsertRequest Insert(Google.Apis.Bigquery.v2.Data.Routine body, string projectId, string datasetId)
        {
            return new InsertRequest(this.service, body, projectId, datasetId);
        }

        /// <summary>Creates a new routine in the dataset.</summary>
        public class InsertRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.Routine>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Bigquery.v2.Data.Routine body, string projectId, string datasetId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Project ID of the new routine</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of the new routine</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.Routine Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}/routines";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }
        }

        /// <summary>Lists all routines in the specified dataset. Requires the READER dataset role.</summary>
        /// <param name="projectId">Required. Project ID of the routines to list</param>
        /// <param name="datasetId">Required. Dataset ID of the routines to list</param>
        public virtual ListRequest List(string projectId, string datasetId)
        {
            return new ListRequest(this.service, projectId, datasetId);
        }

        /// <summary>Lists all routines in the specified dataset. Requires the READER dataset role.</summary>
        public class ListRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.ListRoutinesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string projectId, string datasetId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                InitParameters();
            }

            /// <summary>Required. Project ID of the routines to list</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of the routines to list</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>
            /// If set, then only the Routines matching this filter are returned. The supported format is
            /// `routineType:{RoutineType}`, where `{RoutineType}` is a RoutineType enum. For example:
            /// `routineType:SCALAR_FUNCTION`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// The maximum number of results to return in a single response page. Leverage the page tokens to iterate
            /// through the entire collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Page token, returned by a previous call, to request the next page of results</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// If set, then only the Routine fields in the field mask, as well as project_id, dataset_id and
            /// routine_id, are returned in the response. If unset, then the following Routine fields are returned:
            /// etag, project_id, dataset_id, routine_id, routine_type, creation_time, last_modified_time, and language.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object ReadMask { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}/routines";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
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

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
        /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified. See [Resource
        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
        /// </param>
        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Bigquery.v2.Data.SetIamPolicyRequest body, string resource)
        {
            return new SetIamPolicyRequest(this.service, body, resource);
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
        /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
        /// </summary>
        public class SetIamPolicyRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.Policy>
        {
            /// <summary>Constructs a new SetIamPolicy request.</summary>
            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Bigquery.v2.Data.SetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being specified. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.SetIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{+resource}:setIamPolicy";

            /// <summary>Initializes SetIamPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/datasets/[^/]+/routines/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Updates information in an existing routine. The update method replaces the entire Routine resource.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. Project ID of the routine to update</param>
        /// <param name="datasetId">Required. Dataset ID of the routine to update</param>
        /// <param name="routineId">Required. Routine ID of the routine to update</param>
        public virtual UpdateRequest Update(Google.Apis.Bigquery.v2.Data.Routine body, string projectId, string datasetId, string routineId)
        {
            return new UpdateRequest(this.service, body, projectId, datasetId, routineId);
        }

        /// <summary>
        /// Updates information in an existing routine. The update method replaces the entire Routine resource.
        /// </summary>
        public class UpdateRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.Routine>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Bigquery.v2.Data.Routine body, string projectId, string datasetId, string routineId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                RoutineId = routineId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Project ID of the routine to update</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of the routine to update</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Required. Routine ID of the routine to update</summary>
            [Google.Apis.Util.RequestParameterAttribute("routineId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string RoutineId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.Routine Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}/routines/{+routineId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("routineId", new Google.Apis.Discovery.Parameter
                {
                    Name = "routineId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }
        }
    }

    /// <summary>The "rowAccessPolicies" collection of methods.</summary>
    public class RowAccessPoliciesResource
    {
        private const string Resource = "rowAccessPolicies";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public RowAccessPoliciesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes provided row access policies.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. Project ID of the table to delete the row access policies.</param>
        /// <param name="datasetId">Required. Dataset ID of the table to delete the row access policies.</param>
        /// <param name="tableId">Required. Table ID of the table to delete the row access policies.</param>
        public virtual BatchDeleteRequest BatchDelete(Google.Apis.Bigquery.v2.Data.BatchDeleteRowAccessPoliciesRequest body, string projectId, string datasetId, string tableId)
        {
            return new BatchDeleteRequest(this.service, body, projectId, datasetId, tableId);
        }

        /// <summary>Deletes provided row access policies.</summary>
        public class BatchDeleteRequest : BigqueryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new BatchDelete request.</summary>
            public BatchDeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Bigquery.v2.Data.BatchDeleteRowAccessPoliciesRequest body, string projectId, string datasetId, string tableId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                TableId = tableId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Project ID of the table to delete the row access policies.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of the table to delete the row access policies.</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Required. Table ID of the table to delete the row access policies.</summary>
            [Google.Apis.Util.RequestParameterAttribute("tableId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string TableId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.BatchDeleteRowAccessPoliciesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "batchDelete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}/tables/{+tableId}/rowAccessPolicies:batchDelete";

            /// <summary>Initializes BatchDelete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("tableId", new Google.Apis.Discovery.Parameter
                {
                    Name = "tableId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }
        }

        /// <summary>Deletes a row access policy.</summary>
        /// <param name="projectId">Required. Project ID of the table to delete the row access policy.</param>
        /// <param name="datasetId">Required. Dataset ID of the table to delete the row access policy.</param>
        /// <param name="tableId">Required. Table ID of the table to delete the row access policy.</param>
        /// <param name="policyId">Required. Policy ID of the row access policy.</param>
        public virtual DeleteRequest Delete(string projectId, string datasetId, string tableId, string policyId)
        {
            return new DeleteRequest(this.service, projectId, datasetId, tableId, policyId);
        }

        /// <summary>Deletes a row access policy.</summary>
        public class DeleteRequest : BigqueryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string projectId, string datasetId, string tableId, string policyId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                TableId = tableId;
                PolicyId = policyId;
                InitParameters();
            }

            /// <summary>Required. Project ID of the table to delete the row access policy.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of the table to delete the row access policy.</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Required. Table ID of the table to delete the row access policy.</summary>
            [Google.Apis.Util.RequestParameterAttribute("tableId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string TableId { get; private set; }

            /// <summary>Required. Policy ID of the row access policy.</summary>
            [Google.Apis.Util.RequestParameterAttribute("policyId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PolicyId { get; private set; }

            /// <summary>
            /// If set to true, it deletes the row access policy even if it's the last row access policy on the table
            /// and the deletion will widen the access rather narrowing it.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Force { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}/tables/{+tableId}/rowAccessPolicies/{+policyId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("tableId", new Google.Apis.Discovery.Parameter
                {
                    Name = "tableId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("policyId", new Google.Apis.Discovery.Parameter
                {
                    Name = "policyId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                {
                    Name = "force",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets the specified row access policy by policy ID.</summary>
        /// <param name="projectId">Required. Project ID of the table to get the row access policy.</param>
        /// <param name="datasetId">Required. Dataset ID of the table to get the row access policy.</param>
        /// <param name="tableId">Required. Table ID of the table to get the row access policy.</param>
        /// <param name="policyId">Required. Policy ID of the row access policy.</param>
        public virtual GetRequest Get(string projectId, string datasetId, string tableId, string policyId)
        {
            return new GetRequest(this.service, projectId, datasetId, tableId, policyId);
        }

        /// <summary>Gets the specified row access policy by policy ID.</summary>
        public class GetRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.RowAccessPolicy>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string projectId, string datasetId, string tableId, string policyId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                TableId = tableId;
                PolicyId = policyId;
                InitParameters();
            }

            /// <summary>Required. Project ID of the table to get the row access policy.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of the table to get the row access policy.</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Required. Table ID of the table to get the row access policy.</summary>
            [Google.Apis.Util.RequestParameterAttribute("tableId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string TableId { get; private set; }

            /// <summary>Required. Policy ID of the row access policy.</summary>
            [Google.Apis.Util.RequestParameterAttribute("policyId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PolicyId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}/tables/{+tableId}/rowAccessPolicies/{+policyId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("tableId", new Google.Apis.Discovery.Parameter
                {
                    Name = "tableId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("policyId", new Google.Apis.Discovery.Parameter
                {
                    Name = "policyId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }
        }

        /// <summary>
        /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does not
        /// have a policy set.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested. See [Resource
        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
        /// </param>
        public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.Bigquery.v2.Data.GetIamPolicyRequest body, string resource)
        {
            return new GetIamPolicyRequest(this.service, body, resource);
        }

        /// <summary>
        /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does not
        /// have a policy set.
        /// </summary>
        public class GetIamPolicyRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.Policy>
        {
            /// <summary>Constructs a new GetIamPolicy request.</summary>
            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Bigquery.v2.Data.GetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.GetIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{+resource}:getIamPolicy";

            /// <summary>Initializes GetIamPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/datasets/[^/]+/tables/[^/]+/rowAccessPolicies/[^/]+$",
                });
            }
        }

        /// <summary>Creates a row access policy.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. Project ID of the table to get the row access policy.</param>
        /// <param name="datasetId">Required. Dataset ID of the table to get the row access policy.</param>
        /// <param name="tableId">Required. Table ID of the table to get the row access policy.</param>
        public virtual InsertRequest Insert(Google.Apis.Bigquery.v2.Data.RowAccessPolicy body, string projectId, string datasetId, string tableId)
        {
            return new InsertRequest(this.service, body, projectId, datasetId, tableId);
        }

        /// <summary>Creates a row access policy.</summary>
        public class InsertRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.RowAccessPolicy>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Bigquery.v2.Data.RowAccessPolicy body, string projectId, string datasetId, string tableId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                TableId = tableId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Project ID of the table to get the row access policy.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of the table to get the row access policy.</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Required. Table ID of the table to get the row access policy.</summary>
            [Google.Apis.Util.RequestParameterAttribute("tableId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string TableId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.RowAccessPolicy Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}/tables/{+tableId}/rowAccessPolicies";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("tableId", new Google.Apis.Discovery.Parameter
                {
                    Name = "tableId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }
        }

        /// <summary>Lists all row access policies on the specified table.</summary>
        /// <param name="projectId">Required. Project ID of the row access policies to list.</param>
        /// <param name="datasetId">Required. Dataset ID of row access policies to list.</param>
        /// <param name="tableId">Required. Table ID of the table to list row access policies.</param>
        public virtual ListRequest List(string projectId, string datasetId, string tableId)
        {
            return new ListRequest(this.service, projectId, datasetId, tableId);
        }

        /// <summary>Lists all row access policies on the specified table.</summary>
        public class ListRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.ListRowAccessPoliciesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string projectId, string datasetId, string tableId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                TableId = tableId;
                InitParameters();
            }

            /// <summary>Required. Project ID of the row access policies to list.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of row access policies to list.</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Required. Table ID of the table to list row access policies.</summary>
            [Google.Apis.Util.RequestParameterAttribute("tableId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string TableId { get; private set; }

            /// <summary>
            /// The maximum number of results to return in a single response page. Leverage the page tokens to iterate
            /// through the entire collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>Page token, returned by a previous call, to request the next page of results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}/tables/{+tableId}/rowAccessPolicies";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("tableId", new Google.Apis.Discovery.Parameter
                {
                    Name = "tableId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
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
        /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this will
        /// return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be used for
        /// building permission-aware UIs and command-line tools, not for authorization checking. This operation may
        /// "fail open" without warning.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
        /// </param>
        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Bigquery.v2.Data.TestIamPermissionsRequest body, string resource)
        {
            return new TestIamPermissionsRequest(this.service, body, resource);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this will
        /// return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be used for
        /// building permission-aware UIs and command-line tools, not for authorization checking. This operation may
        /// "fail open" without warning.
        /// </summary>
        public class TestIamPermissionsRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.TestIamPermissionsResponse>
        {
            /// <summary>Constructs a new TestIamPermissions request.</summary>
            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Bigquery.v2.Data.TestIamPermissionsRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.TestIamPermissionsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "testIamPermissions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{+resource}:testIamPermissions";

            /// <summary>Initializes TestIamPermissions parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/datasets/[^/]+/tables/[^/]+/rowAccessPolicies/[^/]+$",
                });
            }
        }

        /// <summary>Updates a row access policy.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. Project ID of the table to get the row access policy.</param>
        /// <param name="datasetId">Required. Dataset ID of the table to get the row access policy.</param>
        /// <param name="tableId">Required. Table ID of the table to get the row access policy.</param>
        /// <param name="policyId">Required. Policy ID of the row access policy.</param>
        public virtual UpdateRequest Update(Google.Apis.Bigquery.v2.Data.RowAccessPolicy body, string projectId, string datasetId, string tableId, string policyId)
        {
            return new UpdateRequest(this.service, body, projectId, datasetId, tableId, policyId);
        }

        /// <summary>Updates a row access policy.</summary>
        public class UpdateRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.RowAccessPolicy>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Bigquery.v2.Data.RowAccessPolicy body, string projectId, string datasetId, string tableId, string policyId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                TableId = tableId;
                PolicyId = policyId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Project ID of the table to get the row access policy.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of the table to get the row access policy.</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Required. Table ID of the table to get the row access policy.</summary>
            [Google.Apis.Util.RequestParameterAttribute("tableId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string TableId { get; private set; }

            /// <summary>Required. Policy ID of the row access policy.</summary>
            [Google.Apis.Util.RequestParameterAttribute("policyId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PolicyId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.RowAccessPolicy Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}/tables/{+tableId}/rowAccessPolicies/{+policyId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("tableId", new Google.Apis.Discovery.Parameter
                {
                    Name = "tableId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("policyId", new Google.Apis.Discovery.Parameter
                {
                    Name = "policyId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }
        }
    }

    /// <summary>The "tabledata" collection of methods.</summary>
    public class TabledataResource
    {
        private const string Resource = "tabledata";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TabledataResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Streams data into BigQuery one record at a time without needing to run a load job.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. Project ID of the destination.</param>
        /// <param name="datasetId">Required. Dataset ID of the destination.</param>
        /// <param name="tableId">Required. Table ID of the destination.</param>
        public virtual InsertAllRequest InsertAll(Google.Apis.Bigquery.v2.Data.TableDataInsertAllRequest body, string projectId, string datasetId, string tableId)
        {
            return new InsertAllRequest(this.service, body, projectId, datasetId, tableId);
        }

        /// <summary>Streams data into BigQuery one record at a time without needing to run a load job.</summary>
        public class InsertAllRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.TableDataInsertAllResponse>
        {
            /// <summary>Constructs a new InsertAll request.</summary>
            public InsertAllRequest(Google.Apis.Services.IClientService service, Google.Apis.Bigquery.v2.Data.TableDataInsertAllRequest body, string projectId, string datasetId, string tableId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                TableId = tableId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Project ID of the destination.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of the destination.</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Required. Table ID of the destination.</summary>
            [Google.Apis.Util.RequestParameterAttribute("tableId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string TableId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.TableDataInsertAllRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insertAll";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}/tables/{+tableId}/insertAll";

            /// <summary>Initializes InsertAll parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("tableId", new Google.Apis.Discovery.Parameter
                {
                    Name = "tableId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }
        }

        /// <summary>List the content of a table in rows.</summary>
        /// <param name="projectId">Required. Project id of the table to list.</param>
        /// <param name="datasetId">Required. Dataset id of the table to list.</param>
        /// <param name="tableId">Required. Table id of the table to list.</param>
        public virtual ListRequest List(string projectId, string datasetId, string tableId)
        {
            return new ListRequest(this.service, projectId, datasetId, tableId);
        }

        /// <summary>List the content of a table in rows.</summary>
        public class ListRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.TableDataList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string projectId, string datasetId, string tableId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                TableId = tableId;
                InitParameters();
            }

            /// <summary>Required. Project id of the table to list.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset id of the table to list.</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Required. Table id of the table to list.</summary>
            [Google.Apis.Util.RequestParameterAttribute("tableId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string TableId { get; private set; }

            /// <summary>Optional. Output timestamp as usec int64. Default is false.</summary>
            [Google.Apis.Util.RequestParameterAttribute("formatOptions.useInt64Timestamp", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> FormatOptionsUseInt64Timestamp { get; set; }

            /// <summary>Row limit of the table.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// To retrieve the next page of table data, set this field to the string provided in the pageToken field of
            /// the response body from your previous call to tabledata.list.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Subset of fields to return, supports select into sub fields. Example: selected_fields = "a,e.d.f";
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("selectedFields", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string SelectedFields { get; set; }

            /// <summary>Start row index of the table.</summary>
            [Google.Apis.Util.RequestParameterAttribute("startIndex", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ulong> StartIndex { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}/tables/{+tableId}/data";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("tableId", new Google.Apis.Discovery.Parameter
                {
                    Name = "tableId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("formatOptions.useInt64Timestamp", new Google.Apis.Discovery.Parameter
                {
                    Name = "formatOptions.useInt64Timestamp",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
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
                RequestParameters.Add("selectedFields", new Google.Apis.Discovery.Parameter
                {
                    Name = "selectedFields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("startIndex", new Google.Apis.Discovery.Parameter
                {
                    Name = "startIndex",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "tables" collection of methods.</summary>
    public class TablesResource
    {
        private const string Resource = "tables";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TablesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Deletes the table specified by tableId from the dataset. If the table contains data, all the data will be
        /// deleted.
        /// </summary>
        /// <param name="projectId">Required. Project ID of the table to delete</param>
        /// <param name="datasetId">Required. Dataset ID of the table to delete</param>
        /// <param name="tableId">Required. Table ID of the table to delete</param>
        public virtual DeleteRequest Delete(string projectId, string datasetId, string tableId)
        {
            return new DeleteRequest(this.service, projectId, datasetId, tableId);
        }

        /// <summary>
        /// Deletes the table specified by tableId from the dataset. If the table contains data, all the data will be
        /// deleted.
        /// </summary>
        public class DeleteRequest : BigqueryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string projectId, string datasetId, string tableId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                TableId = tableId;
                InitParameters();
            }

            /// <summary>Required. Project ID of the table to delete</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of the table to delete</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Required. Table ID of the table to delete</summary>
            [Google.Apis.Util.RequestParameterAttribute("tableId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string TableId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}/tables/{+tableId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("tableId", new Google.Apis.Discovery.Parameter
                {
                    Name = "tableId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }
        }

        /// <summary>
        /// Gets the specified table resource by table ID. This method does not return the data in the table, it only
        /// returns the table resource, which describes the structure of this table.
        /// </summary>
        /// <param name="projectId">Required. Project ID of the requested table</param>
        /// <param name="datasetId">Required. Dataset ID of the requested table</param>
        /// <param name="tableId">Required. Table ID of the requested table</param>
        public virtual GetRequest Get(string projectId, string datasetId, string tableId)
        {
            return new GetRequest(this.service, projectId, datasetId, tableId);
        }

        /// <summary>
        /// Gets the specified table resource by table ID. This method does not return the data in the table, it only
        /// returns the table resource, which describes the structure of this table.
        /// </summary>
        public class GetRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.Table>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string projectId, string datasetId, string tableId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                TableId = tableId;
                InitParameters();
            }

            /// <summary>Required. Project ID of the requested table</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of the requested table</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Required. Table ID of the requested table</summary>
            [Google.Apis.Util.RequestParameterAttribute("tableId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string TableId { get; private set; }

            /// <summary>
            /// List of table schema fields to return (comma-separated). If unspecified, all fields are returned. A
            /// fieldMask cannot be used here because the fields will automatically be converted from camelCase to
            /// snake_case and the conversion will fail if there are underscores. Since these are fields in BigQuery
            /// table schemas, underscores are allowed.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("selectedFields", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string SelectedFields { get; set; }

            /// <summary>
            /// Optional. Specifies the view that determines which table information is returned. By default, basic
            /// table information and storage statistics (STORAGE_STATS) are returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            /// <summary>
            /// Optional. Specifies the view that determines which table information is returned. By default, basic
            /// table information and storage statistics (STORAGE_STATS) are returned.
            /// </summary>
            public enum ViewEnum
            {
                /// <summary>The default value. Default to the STORAGE_STATS view.</summary>
                [Google.Apis.Util.StringValueAttribute("TABLE_METADATA_VIEW_UNSPECIFIED")]
                TABLEMETADATAVIEWUNSPECIFIED = 3,

                /// <summary>
                /// Includes basic table information including schema and partitioning specification. This view does not
                /// include storage statistics such as numRows or numBytes. This view is significantly more efficient
                /// and should be used to support high query rates.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC = 0,

                /// <summary>
                /// Includes all information in the BASIC view as well as storage statistics (numBytes,
                /// numLongTermBytes, numRows and lastModifiedTime).
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("STORAGE_STATS")]
                STORAGESTATS = 2,

                /// <summary>
                /// Includes all table information, including storage statistics. It returns same information as
                /// STORAGE_STATS view, but may contain additional information in the future.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL = 1,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}/tables/{+tableId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("tableId", new Google.Apis.Discovery.Parameter
                {
                    Name = "tableId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("selectedFields", new Google.Apis.Discovery.Parameter
                {
                    Name = "selectedFields",
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
        /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does not
        /// have a policy set.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested. See [Resource
        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
        /// </param>
        public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.Bigquery.v2.Data.GetIamPolicyRequest body, string resource)
        {
            return new GetIamPolicyRequest(this.service, body, resource);
        }

        /// <summary>
        /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does not
        /// have a policy set.
        /// </summary>
        public class GetIamPolicyRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.Policy>
        {
            /// <summary>Constructs a new GetIamPolicy request.</summary>
            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Bigquery.v2.Data.GetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.GetIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{+resource}:getIamPolicy";

            /// <summary>Initializes GetIamPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/datasets/[^/]+/tables/[^/]+$",
                });
            }
        }

        /// <summary>Creates a new, empty table in the dataset.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. Project ID of the new table</param>
        /// <param name="datasetId">Required. Dataset ID of the new table</param>
        public virtual InsertRequest Insert(Google.Apis.Bigquery.v2.Data.Table body, string projectId, string datasetId)
        {
            return new InsertRequest(this.service, body, projectId, datasetId);
        }

        /// <summary>Creates a new, empty table in the dataset.</summary>
        public class InsertRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.Table>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Bigquery.v2.Data.Table body, string projectId, string datasetId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Project ID of the new table</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of the new table</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.Table Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}/tables";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }
        }

        /// <summary>Lists all tables in the specified dataset. Requires the READER dataset role.</summary>
        /// <param name="projectId">Required. Project ID of the tables to list</param>
        /// <param name="datasetId">Required. Dataset ID of the tables to list</param>
        public virtual ListRequest List(string projectId, string datasetId)
        {
            return new ListRequest(this.service, projectId, datasetId);
        }

        /// <summary>Lists all tables in the specified dataset. Requires the READER dataset role.</summary>
        public class ListRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.TableList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string projectId, string datasetId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                InitParameters();
            }

            /// <summary>Required. Project ID of the tables to list</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of the tables to list</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>
            /// The maximum number of results to return in a single response page. Leverage the page tokens to iterate
            /// through the entire collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Page token, returned by a previous call, to request the next page of results</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}/tables";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
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
        /// Updates information in an existing table. The update method replaces the entire table resource, whereas the
        /// patch method only replaces fields that are provided in the submitted table resource. This method supports
        /// RFC5789 patch semantics.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. Project ID of the table to update</param>
        /// <param name="datasetId">Required. Dataset ID of the table to update</param>
        /// <param name="tableId">Required. Table ID of the table to update</param>
        public virtual PatchRequest Patch(Google.Apis.Bigquery.v2.Data.Table body, string projectId, string datasetId, string tableId)
        {
            return new PatchRequest(this.service, body, projectId, datasetId, tableId);
        }

        /// <summary>
        /// Updates information in an existing table. The update method replaces the entire table resource, whereas the
        /// patch method only replaces fields that are provided in the submitted table resource. This method supports
        /// RFC5789 patch semantics.
        /// </summary>
        public class PatchRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.Table>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Bigquery.v2.Data.Table body, string projectId, string datasetId, string tableId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                TableId = tableId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Project ID of the table to update</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of the table to update</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Required. Table ID of the table to update</summary>
            [Google.Apis.Util.RequestParameterAttribute("tableId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string TableId { get; private set; }

            /// <summary>Optional.  When true will autodetect schema, else will keep original schema</summary>
            [Google.Apis.Util.RequestParameterAttribute("autodetect_schema", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AutodetectSchema { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.Table Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}/tables/{+tableId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("tableId", new Google.Apis.Discovery.Parameter
                {
                    Name = "tableId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("autodetect_schema", new Google.Apis.Discovery.Parameter
                {
                    Name = "autodetect_schema",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
        /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified. See [Resource
        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
        /// </param>
        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Bigquery.v2.Data.SetIamPolicyRequest body, string resource)
        {
            return new SetIamPolicyRequest(this.service, body, resource);
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
        /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
        /// </summary>
        public class SetIamPolicyRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.Policy>
        {
            /// <summary>Constructs a new SetIamPolicy request.</summary>
            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Bigquery.v2.Data.SetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being specified. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.SetIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{+resource}:setIamPolicy";

            /// <summary>Initializes SetIamPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/datasets/[^/]+/tables/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this will
        /// return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be used for
        /// building permission-aware UIs and command-line tools, not for authorization checking. This operation may
        /// "fail open" without warning.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
        /// </param>
        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Bigquery.v2.Data.TestIamPermissionsRequest body, string resource)
        {
            return new TestIamPermissionsRequest(this.service, body, resource);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this will
        /// return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be used for
        /// building permission-aware UIs and command-line tools, not for authorization checking. This operation may
        /// "fail open" without warning.
        /// </summary>
        public class TestIamPermissionsRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.TestIamPermissionsResponse>
        {
            /// <summary>Constructs a new TestIamPermissions request.</summary>
            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Bigquery.v2.Data.TestIamPermissionsRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.TestIamPermissionsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "testIamPermissions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{+resource}:testIamPermissions";

            /// <summary>Initializes TestIamPermissions parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/datasets/[^/]+/tables/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Updates information in an existing table. The update method replaces the entire Table resource, whereas the
        /// patch method only replaces fields that are provided in the submitted Table resource.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. Project ID of the table to update</param>
        /// <param name="datasetId">Required. Dataset ID of the table to update</param>
        /// <param name="tableId">Required. Table ID of the table to update</param>
        public virtual UpdateRequest Update(Google.Apis.Bigquery.v2.Data.Table body, string projectId, string datasetId, string tableId)
        {
            return new UpdateRequest(this.service, body, projectId, datasetId, tableId);
        }

        /// <summary>
        /// Updates information in an existing table. The update method replaces the entire Table resource, whereas the
        /// patch method only replaces fields that are provided in the submitted Table resource.
        /// </summary>
        public class UpdateRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.Table>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Bigquery.v2.Data.Table body, string projectId, string datasetId, string tableId) : base(service)
            {
                ProjectId = projectId;
                DatasetId = datasetId;
                TableId = tableId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Project ID of the table to update</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Required. Dataset ID of the table to update</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Required. Table ID of the table to update</summary>
            [Google.Apis.Util.RequestParameterAttribute("tableId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string TableId { get; private set; }

            /// <summary>Optional.  When true will autodetect schema, else will keep original schema</summary>
            [Google.Apis.Util.RequestParameterAttribute("autodetect_schema", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AutodetectSchema { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.Table Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{+projectId}/datasets/{+datasetId}/tables/{+tableId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("tableId", new Google.Apis.Discovery.Parameter
                {
                    Name = "tableId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("autodetect_schema", new Google.Apis.Discovery.Parameter
                {
                    Name = "autodetect_schema",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Bigquery.v2.Data
{
    /// <summary>
    /// Aggregate metrics for classification/classifier models. For multi-class models, the metrics are either
    /// macro-averaged or micro-averaged. When macro-averaged, the metrics are calculated for each label and then an
    /// unweighted average is taken of those values. When micro-averaged, the metric is calculated globally by counting
    /// the total number of correctly predicted rows.
    /// </summary>
    public class AggregateClassificationMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Accuracy is the fraction of predictions given the correct label. For multiclass this is a micro-averaged
        /// metric.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accuracy")]
        public virtual System.Nullable<double> Accuracy { get; set; }

        /// <summary>
        /// The F1 score is an average of recall and precision. For multiclass this is a macro-averaged metric.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("f1Score")]
        public virtual System.Nullable<double> F1Score { get; set; }

        /// <summary>Logarithmic Loss. For multiclass this is a macro-averaged metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logLoss")]
        public virtual System.Nullable<double> LogLoss { get; set; }

        /// <summary>
        /// Precision is the fraction of actual positive predictions that had positive actual labels. For multiclass
        /// this is a macro-averaged metric treating each class as a binary classifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precision")]
        public virtual System.Nullable<double> Precision { get; set; }

        /// <summary>
        /// Recall is the fraction of actual positive labels that were given a positive prediction. For multiclass this
        /// is a macro-averaged metric.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recall")]
        public virtual System.Nullable<double> Recall { get; set; }

        /// <summary>Area Under a ROC Curve. For multiclass this is a macro-averaged metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rocAuc")]
        public virtual System.Nullable<double> RocAuc { get; set; }

        /// <summary>
        /// Threshold at which the metrics are computed. For binary classification models this is the positive class
        /// threshold. For multi-class classification models this is the confidence threshold.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threshold")]
        public virtual System.Nullable<double> Threshold { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents privacy policy associated with "aggregation threshold" method.</summary>
    public class AggregationThresholdPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The privacy unit column(s) associated with this policy. For now, only one column per data source
        /// object (table, view) is allowed as a privacy unit column. Representing as a repeated field in metadata for
        /// extensibility to multiple columns in future. Duplicates and Repeated struct fields are not allowed. For
        /// nested fields, use dot notation ("outer.inner")
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privacyUnitColumns")]
        public virtual System.Collections.Generic.IList<string> PrivacyUnitColumns { get; set; }

        /// <summary>Optional. The threshold for the "aggregation threshold" policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threshold")]
        public virtual System.Nullable<long> Threshold { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Input/output argument of a function or a stored procedure.</summary>
    public class Argument : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Defaults to FIXED_TYPE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("argumentKind")]
        public virtual string ArgumentKind { get; set; }

        /// <summary>Set if argument_kind == FIXED_TYPE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual StandardSqlDataType DataType { get; set; }

        /// <summary>
        /// Optional. Whether the argument is an aggregate function parameter. Must be Unset for routine types other
        /// than AGGREGATE_FUNCTION. For AGGREGATE_FUNCTION, if set to false, it is equivalent to adding "NOT AGGREGATE"
        /// clause in DDL; Otherwise, it is equivalent to omitting "NOT AGGREGATE" clause in DDL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isAggregate")]
        public virtual System.Nullable<bool> IsAggregate { get; set; }

        /// <summary>
        /// Optional. Specifies whether the argument is input or output. Can be set for procedures only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>Optional. The name of this argument. Can be absent for function return argument.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Arima coefficients.</summary>
    public class ArimaCoefficients : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Auto-regressive coefficients, an array of double.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoRegressiveCoefficients")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> AutoRegressiveCoefficients { get; set; }

        /// <summary>Intercept coefficient, just a double not an array.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interceptCoefficient")]
        public virtual System.Nullable<double> InterceptCoefficient { get; set; }

        /// <summary>Moving-average coefficients, an array of double.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("movingAverageCoefficients")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> MovingAverageCoefficients { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ARIMA model fitting metrics.</summary>
    public class ArimaFittingMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>AIC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aic")]
        public virtual System.Nullable<double> Aic { get; set; }

        /// <summary>Log-likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logLikelihood")]
        public virtual System.Nullable<double> LogLikelihood { get; set; }

        /// <summary>Variance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variance")]
        public virtual System.Nullable<double> Variance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Model evaluation metrics for ARIMA forecasting models.</summary>
    public class ArimaForecastingMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Arima model fitting metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arimaFittingMetrics")]
        public virtual System.Collections.Generic.IList<ArimaFittingMetrics> ArimaFittingMetrics { get; set; }

        /// <summary>
        /// Repeated as there can be many metric sets (one for each model) in auto-arima and the large-scale case.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arimaSingleModelForecastingMetrics")]
        public virtual System.Collections.Generic.IList<ArimaSingleModelForecastingMetrics> ArimaSingleModelForecastingMetrics { get; set; }

        /// <summary>Whether Arima model fitted with drift or not. It is always false when d is not 1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasDrift")]
        public virtual System.Collections.Generic.IList<System.Nullable<bool>> HasDrift { get; set; }

        /// <summary>Non-seasonal order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonSeasonalOrder")]
        public virtual System.Collections.Generic.IList<ArimaOrder> NonSeasonalOrder { get; set; }

        /// <summary>Seasonal periods. Repeated because multiple periods are supported for one time series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seasonalPeriods")]
        public virtual System.Collections.Generic.IList<string> SeasonalPeriods { get; set; }

        /// <summary>Id to differentiate different time series for the large-scale case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeriesId")]
        public virtual System.Collections.Generic.IList<string> TimeSeriesId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Arima model information.</summary>
    public class ArimaModelInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Arima coefficients.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arimaCoefficients")]
        public virtual ArimaCoefficients ArimaCoefficients { get; set; }

        /// <summary>Arima fitting metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arimaFittingMetrics")]
        public virtual ArimaFittingMetrics ArimaFittingMetrics { get; set; }

        /// <summary>Whether Arima model fitted with drift or not. It is always false when d is not 1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasDrift")]
        public virtual System.Nullable<bool> HasDrift { get; set; }

        /// <summary>If true, holiday_effect is a part of time series decomposition result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasHolidayEffect")]
        public virtual System.Nullable<bool> HasHolidayEffect { get; set; }

        /// <summary>If true, spikes_and_dips is a part of time series decomposition result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasSpikesAndDips")]
        public virtual System.Nullable<bool> HasSpikesAndDips { get; set; }

        /// <summary>If true, step_changes is a part of time series decomposition result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasStepChanges")]
        public virtual System.Nullable<bool> HasStepChanges { get; set; }

        /// <summary>Non-seasonal order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonSeasonalOrder")]
        public virtual ArimaOrder NonSeasonalOrder { get; set; }

        /// <summary>Seasonal periods. Repeated because multiple periods are supported for one time series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seasonalPeriods")]
        public virtual System.Collections.Generic.IList<string> SeasonalPeriods { get; set; }

        /// <summary>
        /// The time_series_id value for this time series. It will be one of the unique values from the
        /// time_series_id_column specified during ARIMA model training. Only present when time_series_id_column
        /// training option was used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeriesId")]
        public virtual string TimeSeriesId { get; set; }

        /// <summary>
        /// The tuple of time_series_ids identifying this time series. It will be one of the unique tuples of values
        /// present in the time_series_id_columns specified during ARIMA model training. Only present when
        /// time_series_id_columns training option was used and the order of values here are same as the order of
        /// time_series_id_columns.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeriesIds")]
        public virtual System.Collections.Generic.IList<string> TimeSeriesIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Arima order, can be used for both non-seasonal and seasonal parts.</summary>
    public class ArimaOrder : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Order of the differencing part.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("d")]
        public virtual System.Nullable<long> D { get; set; }

        /// <summary>Order of the autoregressive part.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("p")]
        public virtual System.Nullable<long> P { get; set; }

        /// <summary>Order of the moving-average part.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("q")]
        public virtual System.Nullable<long> Q { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// (Auto-)arima fitting result. Wrap everything in ArimaResult for easier refactoring if we want to use
    /// model-specific iteration results.
    /// </summary>
    public class ArimaResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This message is repeated because there are multiple arima models fitted in auto-arima. For non-auto-arima
        /// model, its size is one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arimaModelInfo")]
        public virtual System.Collections.Generic.IList<ArimaModelInfo> ArimaModelInfo { get; set; }

        /// <summary>Seasonal periods. Repeated because multiple periods are supported for one time series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seasonalPeriods")]
        public virtual System.Collections.Generic.IList<string> SeasonalPeriods { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Model evaluation metrics for a single ARIMA forecasting model.</summary>
    public class ArimaSingleModelForecastingMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Arima fitting metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arimaFittingMetrics")]
        public virtual ArimaFittingMetrics ArimaFittingMetrics { get; set; }

        /// <summary>Is arima model fitted with drift or not. It is always false when d is not 1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasDrift")]
        public virtual System.Nullable<bool> HasDrift { get; set; }

        /// <summary>If true, holiday_effect is a part of time series decomposition result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasHolidayEffect")]
        public virtual System.Nullable<bool> HasHolidayEffect { get; set; }

        /// <summary>If true, spikes_and_dips is a part of time series decomposition result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasSpikesAndDips")]
        public virtual System.Nullable<bool> HasSpikesAndDips { get; set; }

        /// <summary>If true, step_changes is a part of time series decomposition result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasStepChanges")]
        public virtual System.Nullable<bool> HasStepChanges { get; set; }

        /// <summary>Non-seasonal order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonSeasonalOrder")]
        public virtual ArimaOrder NonSeasonalOrder { get; set; }

        /// <summary>Seasonal periods. Repeated because multiple periods are supported for one time series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seasonalPeriods")]
        public virtual System.Collections.Generic.IList<string> SeasonalPeriods { get; set; }

        /// <summary>
        /// The time_series_id value for this time series. It will be one of the unique values from the
        /// time_series_id_column specified during ARIMA model training. Only present when time_series_id_column
        /// training option was used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeriesId")]
        public virtual string TimeSeriesId { get; set; }

        /// <summary>
        /// The tuple of time_series_ids identifying this time series. It will be one of the unique tuples of values
        /// present in the time_series_id_columns specified during ARIMA model training. Only present when
        /// time_series_id_columns training option was used and the order of values here are same as the order of
        /// time_series_id_columns.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeriesIds")]
        public virtual System.Collections.Generic.IList<string> TimeSeriesIds { get; set; }

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

    /// <summary>Options for external data sources.</summary>
    public class AvroOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If sourceFormat is set to "AVRO", indicates whether to interpret logical types as the
        /// corresponding BigQuery data type (for example, TIMESTAMP), instead of using the raw type (for example,
        /// INTEGER).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useAvroLogicalTypes")]
        public virtual System.Nullable<bool> UseAvroLogicalTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the BatchDeleteRowAccessPoliciesRequest method.</summary>
    public class BatchDeleteRowAccessPoliciesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set to true, it deletes the row access policy even if it's the last row access policy on the table and
        /// the deletion will widen the access rather narrowing it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("force")]
        public virtual System.Nullable<bool> Force { get; set; }

        /// <summary>Required. Policy IDs of the row access policies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyIds")]
        public virtual System.Collections.Generic.IList<string> PolicyIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Reason why BI Engine didn't accelerate the query (or sub-query).</summary>
    public class BiEngineReason : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. High-level BI Engine reason for partial or disabled acceleration</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Output only. Free form human-readable reason for partial or disabled acceleration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Statistics for a BI Engine specific query. Populated as part of JobStatistics2</summary>
    public class BiEngineStatistics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Specifies which mode of BI Engine acceleration was performed (if any).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accelerationMode")]
        public virtual string AccelerationMode { get; set; }

        /// <summary>Output only. Specifies which mode of BI Engine acceleration was performed (if any).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("biEngineMode")]
        public virtual string BiEngineMode { get; set; }

        /// <summary>
        /// In case of DISABLED or PARTIAL bi_engine_mode, these contain the explanatory reasons as to why BI Engine
        /// could not accelerate. In case the full query was accelerated, this field is not populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("biEngineReasons")]
        public virtual System.Collections.Generic.IList<BiEngineReason> BiEngineReasons { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for BigQuery tables for Apache Iceberg (formerly BigLake managed tables.)</summary>
    public class BigLakeConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The connection specifying the credentials to be used to read and write to external storage, such
        /// as Cloud Storage. The connection_id can have the form `{project}.{location}.{connection_id}` or
        /// `projects/{project}/locations/{location}/connections/{connection_id}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionId")]
        public virtual string ConnectionId { get; set; }

        /// <summary>Optional. The file format the table data is stored in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileFormat")]
        public virtual string FileFormat { get; set; }

        /// <summary>
        /// Optional. The fully qualified location prefix of the external folder where table data is stored. The '*'
        /// wildcard character is not allowed. The URI should be in the format `gs://bucket/path_to_table/`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageUri")]
        public virtual string StorageUri { get; set; }

        /// <summary>Optional. The table format the metadata only snapshots are stored in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableFormat")]
        public virtual string TableFormat { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BigQueryModelTraining : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentIteration")]
        public virtual System.Nullable<int> CurrentIteration { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedTotalIterations")]
        public virtual System.Nullable<long> ExpectedTotalIterations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information related to a Bigtable column.</summary>
    public class BigtableColumn : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The encoding of the values when the type is not STRING. Acceptable encoding values are: TEXT -
        /// indicates values are alphanumeric text strings. BINARY - indicates values are encoded using HBase
        /// Bytes.toBytes family of functions. 'encoding' can also be set at the column family level. However, the
        /// setting at this level takes precedence if 'encoding' is set at both levels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        /// <summary>
        /// Optional. If the qualifier is not a valid BigQuery field identifier i.e. does not match a-zA-Z*, a valid
        /// identifier must be provided as the column field name and is used as field name in queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldName")]
        public virtual string FieldName { get; set; }

        /// <summary>
        /// Optional. If this is set, only the latest version of value in this column are exposed. 'onlyReadLatest' can
        /// also be set at the column family level. However, the setting at this level takes precedence if
        /// 'onlyReadLatest' is set at both levels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onlyReadLatest")]
        public virtual System.Nullable<bool> OnlyReadLatest { get; set; }

        /// <summary>
        /// [Required] Qualifier of the column. Columns in the parent column family that has this exact qualifier are
        /// exposed as `.` field. If the qualifier is valid UTF-8 string, it can be specified in the qualifier_string
        /// field. Otherwise, a base-64 encoded value must be set to qualifier_encoded. The column field name is the
        /// same as the column qualifier. However, if the qualifier is not a valid BigQuery field identifier i.e. does
        /// not match a-zA-Z*, a valid identifier must be provided as field_name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("qualifierEncoded")]
        public virtual string QualifierEncoded { get; set; }

        /// <summary>Qualifier string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("qualifierString")]
        public virtual string QualifierString { get; set; }

        /// <summary>
        /// Optional. The type to convert the value in cells of this column. The values are expected to be encoded using
        /// HBase Bytes.toBytes function when using the BINARY encoding value. Following BigQuery types are allowed
        /// (case-sensitive): * BYTES * STRING * INTEGER * FLOAT * BOOLEAN * JSON Default type is BYTES. 'type' can also
        /// be set at the column family level. However, the setting at this level takes precedence if 'type' is set at
        /// both levels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information related to a Bigtable column family.</summary>
    public class BigtableColumnFamily : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Lists of columns that should be exposed as individual fields as opposed to a list of (column name,
        /// value) pairs. All columns whose qualifier matches a qualifier in this list can be accessed as `.`. Other
        /// columns can be accessed as a list through the `.Column` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual System.Collections.Generic.IList<BigtableColumn> Columns { get; set; }

        /// <summary>
        /// Optional. The encoding of the values when the type is not STRING. Acceptable encoding values are: TEXT -
        /// indicates values are alphanumeric text strings. BINARY - indicates values are encoded using HBase
        /// Bytes.toBytes family of functions. This can be overridden for a specific column by listing that column in
        /// 'columns' and specifying an encoding for it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        /// <summary>Identifier of the column family.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("familyId")]
        public virtual string FamilyId { get; set; }

        /// <summary>
        /// Optional. If this is set only the latest version of value are exposed for all columns in this column family.
        /// This can be overridden for a specific column by listing that column in 'columns' and specifying a different
        /// setting for that column.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onlyReadLatest")]
        public virtual System.Nullable<bool> OnlyReadLatest { get; set; }

        /// <summary>
        /// Optional. The type to convert the value in cells of this column family. The values are expected to be
        /// encoded using HBase Bytes.toBytes function when using the BINARY encoding value. Following BigQuery types
        /// are allowed (case-sensitive): * BYTES * STRING * INTEGER * FLOAT * BOOLEAN * JSON Default type is BYTES.
        /// This can be overridden for a specific column by listing that column in 'columns' and specifying a type for
        /// it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options specific to Google Cloud Bigtable data sources.</summary>
    public class BigtableOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. List of column families to expose in the table schema along with their types. This list restricts
        /// the column families that can be referenced in queries and specifies their value types. You can use this list
        /// to do type conversions - see the 'type' field for more details. If you leave this list empty, all column
        /// families are present in the table schema and their values are read as BYTES. During a query only the column
        /// families referenced in that query are read from Bigtable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnFamilies")]
        public virtual System.Collections.Generic.IList<BigtableColumnFamily> ColumnFamilies { get; set; }

        /// <summary>
        /// Optional. If field is true, then the column families that are not specified in columnFamilies list are not
        /// exposed in the table schema. Otherwise, they are read with BYTES type values. The default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreUnspecifiedColumnFamilies")]
        public virtual System.Nullable<bool> IgnoreUnspecifiedColumnFamilies { get; set; }

        /// <summary>
        /// Optional. If field is true, then each column family will be read as a single JSON column. Otherwise they are
        /// read as a repeated cell structure containing timestamp/value tuples. The default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputColumnFamiliesAsJson")]
        public virtual System.Nullable<bool> OutputColumnFamiliesAsJson { get; set; }

        /// <summary>
        /// Optional. If field is true, then the rowkey column families will be read and converted to string. Otherwise
        /// they are read with BYTES type values and users need to manually cast them with CAST if necessary. The
        /// default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readRowkeyAsString")]
        public virtual System.Nullable<bool> ReadRowkeyAsString { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evaluation metrics for binary classification/classifier models.</summary>
    public class BinaryClassificationMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Aggregate classification metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregateClassificationMetrics")]
        public virtual AggregateClassificationMetrics AggregateClassificationMetrics { get; set; }

        /// <summary>Binary confusion matrix at multiple thresholds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryConfusionMatrixList")]
        public virtual System.Collections.Generic.IList<BinaryConfusionMatrix> BinaryConfusionMatrixList { get; set; }

        /// <summary>Label representing the negative class.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negativeLabel")]
        public virtual string NegativeLabel { get; set; }

        /// <summary>Label representing the positive class.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("positiveLabel")]
        public virtual string PositiveLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Confusion matrix for binary classification models.</summary>
    public class BinaryConfusionMatrix : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The fraction of predictions given the correct label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accuracy")]
        public virtual System.Nullable<double> Accuracy { get; set; }

        /// <summary>The equally weighted average of recall and precision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("f1Score")]
        public virtual System.Nullable<double> F1Score { get; set; }

        /// <summary>Number of false samples predicted as false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("falseNegatives")]
        public virtual System.Nullable<long> FalseNegatives { get; set; }

        /// <summary>Number of false samples predicted as true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("falsePositives")]
        public virtual System.Nullable<long> FalsePositives { get; set; }

        /// <summary>Threshold value used when computing each of the following metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("positiveClassThreshold")]
        public virtual System.Nullable<double> PositiveClassThreshold { get; set; }

        /// <summary>The fraction of actual positive predictions that had positive actual labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precision")]
        public virtual System.Nullable<double> Precision { get; set; }

        /// <summary>The fraction of actual positive labels that were given a positive prediction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recall")]
        public virtual System.Nullable<double> Recall { get; set; }

        /// <summary>Number of true samples predicted as false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trueNegatives")]
        public virtual System.Nullable<long> TrueNegatives { get; set; }

        /// <summary>Number of true samples predicted as true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("truePositives")]
        public virtual System.Nullable<long> TruePositives { get; set; }

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

    public class BqmlIterationResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("durationMs")]
        public virtual System.Nullable<long> DurationMs { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evalLoss")]
        public virtual System.Nullable<double> EvalLoss { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("learnRate")]
        public virtual System.Nullable<double> LearnRate { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingLoss")]
        public virtual System.Nullable<double> TrainingLoss { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BqmlTrainingRun : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iterationResults")]
        public virtual System.Collections.Generic.IList<BqmlIterationResult> IterationResults { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? StartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(StartTimeRaw);
            set => StartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StartTimeDateTimeOffset instead.")]
        public virtual System.DateTime? StartTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(StartTimeRaw);
            set => StartTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingOptions")]
        public virtual TrainingOptionsData TrainingOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>Deprecated.</summary>
        public class TrainingOptionsData
        {
            [Newtonsoft.Json.JsonPropertyAttribute("earlyStop")]
            public virtual System.Nullable<bool> EarlyStop { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("l1Reg")]
            public virtual System.Nullable<double> L1Reg { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("l2Reg")]
            public virtual System.Nullable<double> L2Reg { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("learnRate")]
            public virtual System.Nullable<double> LearnRate { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("learnRateStrategy")]
            public virtual string LearnRateStrategy { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("lineSearchInitLearnRate")]
            public virtual System.Nullable<double> LineSearchInitLearnRate { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("maxIteration")]
            public virtual System.Nullable<long> MaxIteration { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("minRelProgress")]
            public virtual System.Nullable<double> MinRelProgress { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("warmStart")]
            public virtual System.Nullable<bool> WarmStart { get; set; }
        }
    }

    /// <summary>Representative value of a categorical feature.</summary>
    public class CategoricalValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Counts of all categories for the categorical feature. If there are more than ten categories, we return top
        /// ten (by count) and return one more CategoryCount with category "_OTHER_" and count as aggregate counts of
        /// remaining categories.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryCounts")]
        public virtual System.Collections.Generic.IList<CategoryCount> CategoryCounts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the count of a single category within the cluster.</summary>
    public class CategoryCount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>The count of training samples matching the category within the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about base table and clone time of a table clone.</summary>
    public class CloneDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Reference describing the ID of the table that was cloned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseTableReference")]
        public virtual TableReference BaseTableReference { get; set; }

        /// <summary>
        /// Required. The time at which the base table was cloned. This value is reported in the JSON response using
        /// RFC3339 format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloneTime")]
        public virtual string CloneTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CloneTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CloneTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(CloneTimeRaw);
            set => CloneTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CloneTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CloneTimeDateTimeOffset instead.")]
        public virtual System.DateTime? CloneTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CloneTimeRaw);
            set => CloneTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message containing the information about one cluster.</summary>
    public class Cluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Centroid id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("centroidId")]
        public virtual System.Nullable<long> CentroidId { get; set; }

        /// <summary>Count of training data rows that were assigned to this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>Values of highly variant features for this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("featureValues")]
        public virtual System.Collections.Generic.IList<FeatureValue> FeatureValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a single cluster for clustering model.</summary>
    public class ClusterInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Centroid id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("centroidId")]
        public virtual System.Nullable<long> CentroidId { get; set; }

        /// <summary>Cluster radius, the average distance from centroid to each point assigned to the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterRadius")]
        public virtual System.Nullable<double> ClusterRadius { get; set; }

        /// <summary>Cluster size, the total number of points assigned to the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterSize")]
        public virtual System.Nullable<long> ClusterSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configures table clustering.</summary>
    public class Clustering : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// One or more fields on which data should be clustered. Only top-level, non-repeated, simple-type fields are
        /// supported. The ordering of the clustering fields should be prioritized from most to least important for
        /// filtering purposes. For additional information, see [Introduction to clustered
        /// tables](https://cloud.google.com/bigquery/docs/clustered-tables#limitations).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<string> Fields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evaluation metrics for clustering models.</summary>
    public class ClusteringMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information for all clusters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusters")]
        public virtual System.Collections.Generic.IList<Cluster> Clusters { get; set; }

        /// <summary>Davies-Bouldin index.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("daviesBouldinIndex")]
        public virtual System.Nullable<double> DaviesBouldinIndex { get; set; }

        /// <summary>Mean of squared distances between each sample to its cluster centroid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meanSquaredDistance")]
        public virtual System.Nullable<double> MeanSquaredDistance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Confusion matrix for multi-class classification models.</summary>
    public class ConfusionMatrix : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Confidence threshold used when computing the entries of the confusion matrix.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidenceThreshold")]
        public virtual System.Nullable<double> ConfidenceThreshold { get; set; }

        /// <summary>One row per actual label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<Row> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A connection-level property to customize query behavior. Under JDBC, these correspond directly to connection
    /// properties passed to the DriverManager. Under ODBC, these correspond to properties in the connection string.
    /// Currently supported connection properties: * **dataset_project_id**: represents the default project for datasets
    /// that are used in the query. Setting the system variable `@@dataset_project_id` achieves the same behavior. For
    /// more information about system variables, see: https://cloud.google.com/bigquery/docs/reference/system-variables
    /// * **time_zone**: represents the default timezone used to run the query. * **session_id**: associates the query
    /// with a given session. * **query_label**: associates the query with a given job label. If set, all subsequent
    /// queries in a script or session will have this label. For the format in which a you can specify a query label,
    /// see labels in the JobConfiguration resource type:
    /// https://cloud.google.com/bigquery/docs/reference/rest/v2/Job#jobconfiguration * **service_account**: indicates
    /// the service account to use to run a continuous query. If set, the query job uses the service account to access
    /// Google Cloud resources. Service account access is bounded by the IAM permissions that you have granted to the
    /// service account. Additional properties are allowed, but ignored. Specifying multiple connection properties with
    /// the same key returns an error.
    /// </summary>
    public class ConnectionProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The key of the property to set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The value of the property to set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information related to a CSV data source.</summary>
    public class CsvOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Indicates if BigQuery should accept rows that are missing trailing optional columns. If true,
        /// BigQuery treats missing trailing columns as null values. If false, records with missing trailing columns are
        /// treated as bad records, and if there are too many bad records, an invalid error is returned in the job
        /// result. The default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowJaggedRows")]
        public virtual System.Nullable<bool> AllowJaggedRows { get; set; }

        /// <summary>
        /// Optional. Indicates if BigQuery should allow quoted data sections that contain newline characters in a CSV
        /// file. The default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowQuotedNewlines")]
        public virtual System.Nullable<bool> AllowQuotedNewlines { get; set; }

        /// <summary>
        /// Optional. The character encoding of the data. The supported values are UTF-8, ISO-8859-1, UTF-16BE,
        /// UTF-16LE, UTF-32BE, and UTF-32LE. The default value is UTF-8. BigQuery decodes the data after the raw,
        /// binary data has been split using the values of the quote and fieldDelimiter properties.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        /// <summary>
        /// Optional. The separator character for fields in a CSV file. The separator is interpreted as a single byte.
        /// For files encoded in ISO-8859-1, any single character can be used as a separator. For files encoded in
        /// UTF-8, characters represented in decimal range 1-127 (U+0001-U+007F) can be used without any modification.
        /// UTF-8 characters encoded with multiple bytes (i.e. U+0080 and above) will have only the first byte used for
        /// separating fields. The remaining bytes will be treated as a part of the field. BigQuery also supports the
        /// escape sequence "\t" (U+0009) to specify a tab separator. The default value is comma (",", U+002C).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldDelimiter")]
        public virtual string FieldDelimiter { get; set; }

        /// <summary>
        /// Optional. Specifies a string that represents a null value in a CSV file. For example, if you specify "\N",
        /// BigQuery interprets "\N" as a null value when querying a CSV file. The default value is the empty string. If
        /// you set this property to a custom value, BigQuery throws an error if an empty string is present for all data
        /// types except for STRING and BYTE. For STRING and BYTE columns, BigQuery interprets the empty string as an
        /// empty value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullMarker")]
        public virtual string NullMarker { get; set; }

        /// <summary>
        /// Optional. A list of strings represented as SQL NULL value in a CSV file. null_marker and null_markers can't
        /// be set at the same time. If null_marker is set, null_markers has to be not set. If null_markers is set,
        /// null_marker has to be not set. If both null_marker and null_markers are set at the same time, a user error
        /// would be thrown. Any strings listed in null_markers, including empty string would be interpreted as SQL
        /// NULL. This applies to all column types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullMarkers")]
        public virtual System.Collections.Generic.IList<string> NullMarkers { get; set; }

        /// <summary>
        /// Optional. Indicates if the embedded ASCII control characters (the first 32 characters in the ASCII-table,
        /// from '\x00' to '\x1F') are preserved.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preserveAsciiControlCharacters")]
        public virtual System.Nullable<bool> PreserveAsciiControlCharacters { get; set; }

        /// <summary>
        /// Optional. The value that is used to quote data sections in a CSV file. BigQuery converts the string to
        /// ISO-8859-1 encoding, and then uses the first byte of the encoded string to split the data in its raw, binary
        /// state. The default value is a double-quote ("). If your data does not contain quoted sections, set the
        /// property value to an empty string. If your data contains quoted newline characters, you must also set the
        /// allowQuotedNewlines property to true. To include the specific quote character within a quoted value, precede
        /// it with an additional matching quote character. For example, if you want to escape the default character ' "
        /// ', use ' "" '.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quote")]
        public virtual string Quote { get; set; }

        /// <summary>
        /// Optional. The number of rows at the top of a CSV file that BigQuery will skip when reading the data. The
        /// default value is 0. This property is useful if you have header rows in the file that should be skipped. When
        /// autodetect is on, the behavior is the following: * skipLeadingRows unspecified - Autodetect tries to detect
        /// headers in the first row. If they are not detected, the row is read as data. Otherwise data is read starting
        /// from the second row. * skipLeadingRows is 0 - Instructs autodetect that there are no headers and data should
        /// be read starting from the first row. * skipLeadingRows = N &amp;gt; 0 - Autodetect skips N-1 rows and tries
        /// to detect headers in row N. If headers are not detected, row N is just skipped. Otherwise row N is used to
        /// extract column names for the detected schema.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipLeadingRows")]
        public virtual System.Nullable<long> SkipLeadingRows { get; set; }

        /// <summary>
        /// Optional. Controls the strategy used to match loaded columns to the schema. If not set, a sensible default
        /// is chosen based on how the schema is provided. If autodetect is used, then columns are matched by name.
        /// Otherwise, columns are matched by position. This is done to keep the behavior backward-compatible.
        /// Acceptable values are: POSITION - matches by position. This assumes that the columns are ordered the same
        /// way as the schema. NAME - matches by name. This reads the header row as column names and reorders columns to
        /// match the field names in the schema.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceColumnMatch")]
        public virtual string SourceColumnMatch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for data format adjustments.</summary>
    public class DataFormatOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Output timestamp as usec int64. Default is false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useInt64Timestamp")]
        public virtual System.Nullable<bool> UseInt64Timestamp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Statistics for data-masking.</summary>
    public class DataMaskingStatistics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether any accessed data was protected by the data masking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataMaskingApplied")]
        public virtual System.Nullable<bool> DataMaskingApplied { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data policy option proto, it currently supports name only, will support precedence later.</summary>
    public class DataPolicyOption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Data policy resource name in the form of
        /// projects/project_id/locations/location_id/dataPolicies/data_policy_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Data split result. This contains references to the training and evaluation data tables that were used to train
    /// the model.
    /// </summary>
    public class DataSplitResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Table reference of the evaluation data after split.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationTable")]
        public virtual TableReference EvaluationTable { get; set; }

        /// <summary>Table reference of the test data after split.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testTable")]
        public virtual TableReference TestTable { get; set; }

        /// <summary>Table reference of the training data after split.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingTable")]
        public virtual TableReference TrainingTable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a BigQuery dataset.</summary>
    public class Dataset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An array of objects that define dataset access for one or more entities. You can set this property
        /// when inserting or updating a dataset in order to control who is allowed to access the data. If unspecified
        /// at dataset creation time, BigQuery adds default dataset access for the following entities:
        /// access.specialGroup: projectReaders; access.role: READER; access.specialGroup: projectWriters; access.role:
        /// WRITER; access.specialGroup: projectOwners; access.role: OWNER; access.userByEmail: [dataset creator email];
        /// access.role: OWNER; If you patch a dataset, then this field is overwritten by the patched dataset's access
        /// field. To add entities, you must supply the entire existing access array in addition to any new entities
        /// that you want to add.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("access")]
        public virtual System.Collections.Generic.IList<AccessData> Access { get; set; }

        /// <summary>Output only. The time when this dataset was created, in milliseconds since the epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual System.Nullable<long> CreationTime { get; set; }

        /// <summary>Required. A reference that identifies the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetReference")]
        public virtual DatasetReference DatasetReference { get; set; }

        /// <summary>
        /// Optional. Defines the default collation specification of future tables created in the dataset. If a table is
        /// created in this dataset without table-level default collation, then the table inherits the dataset default
        /// collation, which is applied to the string fields that do not have explicit collation specified. A change to
        /// this field affects only tables created afterwards, and does not alter the existing tables. The following
        /// values are supported: * 'und:ci': undetermined locale, case insensitive. * '': empty string. Default to
        /// case-sensitive behavior.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultCollation")]
        public virtual string DefaultCollation { get; set; }

        /// <summary>
        /// The default encryption key for all tables in the dataset. After this property is set, the encryption key of
        /// all newly-created tables in the dataset is set to this value unless the table creation request or query
        /// explicitly overrides the key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultEncryptionConfiguration")]
        public virtual EncryptionConfiguration DefaultEncryptionConfiguration { get; set; }

        /// <summary>
        /// This default partition expiration, expressed in milliseconds. When new time-partitioned tables are created
        /// in a dataset where this property is set, the table will inherit this value, propagated as the
        /// `TimePartitioning.expirationMs` property on the new table. If you set `TimePartitioning.expirationMs`
        /// explicitly when creating a table, the `defaultPartitionExpirationMs` of the containing dataset is ignored.
        /// When creating a partitioned table, if `defaultPartitionExpirationMs` is set, the `defaultTableExpirationMs`
        /// value is ignored and the table will not be inherit a table expiration deadline.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultPartitionExpirationMs")]
        public virtual System.Nullable<long> DefaultPartitionExpirationMs { get; set; }

        /// <summary>
        /// Optional. Defines the default rounding mode specification of new tables created within this dataset. During
        /// table creation, if this field is specified, the table within this dataset will inherit the default rounding
        /// mode of the dataset. Setting the default rounding mode on a table overrides this option. Existing tables in
        /// the dataset are unaffected. If columns are defined during that table creation, they will immediately inherit
        /// the table's default rounding mode, unless otherwise specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultRoundingMode")]
        public virtual string DefaultRoundingMode { get; set; }

        /// <summary>
        /// Optional. The default lifetime of all tables in the dataset, in milliseconds. The minimum lifetime value is
        /// 3600000 milliseconds (one hour). To clear an existing default expiration with a PATCH request, set to 0.
        /// Once this property is set, all newly-created tables in the dataset will have an expirationTime property set
        /// to the creation time plus the value in this property, and changing the value will only affect new tables,
        /// not existing ones. When the expirationTime for a given table is reached, that table will be deleted
        /// automatically. If a table's expirationTime is modified or removed before the table expires, or if you
        /// provide an explicit expirationTime when creating a table, that value takes precedence over the default
        /// expiration time indicated by this property.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultTableExpirationMs")]
        public virtual System.Nullable<long> DefaultTableExpirationMs { get; set; }

        /// <summary>Optional. A user-friendly description of the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. A hash of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. Options defining open source compatible datasets living in the BigQuery catalog. Contains metadata
        /// of open source database, schema or namespace represented by the current dataset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalCatalogDatasetOptions")]
        public virtual ExternalCatalogDatasetOptions ExternalCatalogDatasetOptions { get; set; }

        /// <summary>
        /// Optional. Reference to a read-only external dataset defined in data catalogs outside of BigQuery. Filled out
        /// when the dataset type is EXTERNAL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalDatasetReference")]
        public virtual ExternalDatasetReference ExternalDatasetReference { get; set; }

        /// <summary>Optional. A descriptive name for the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("friendlyName")]
        public virtual string FriendlyName { get; set; }

        /// <summary>
        /// Output only. The fully-qualified unique name of the dataset in the format projectId:datasetId. The dataset
        /// name without the project name is given in the datasetId field. When creating a new dataset, leave this field
        /// blank, and instead specify the datasetId field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Optional. TRUE if the dataset and its table names are case-insensitive, otherwise FALSE. By default, this is
        /// FALSE, which means the dataset and its table names are case-sensitive. This field does not affect routine
        /// references.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isCaseInsensitive")]
        public virtual System.Nullable<bool> IsCaseInsensitive { get; set; }

        /// <summary>Output only. The resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The labels associated with this dataset. You can use these to organize and group your datasets. You can set
        /// this property when inserting or updating a dataset. See [Creating and Updating Dataset
        /// Labels](https://cloud.google.com/bigquery/docs/creating-managing-labels#creating_and_updating_dataset_labels)
        /// for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. The date when this dataset was last modified, in milliseconds since the epoch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifiedTime")]
        public virtual System.Nullable<long> LastModifiedTime { get; set; }

        /// <summary>
        /// Output only. Metadata about the LinkedDataset. Filled out when the dataset type is LINKED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedDatasetMetadata")]
        public virtual LinkedDatasetMetadata LinkedDatasetMetadata { get; set; }

        /// <summary>
        /// Optional. The source dataset reference when the dataset is of type LINKED. For all other dataset types it is
        /// not set. This field cannot be updated once it is set. Any attempt to update this field using Update and
        /// Patch API Operations will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedDatasetSource")]
        public virtual LinkedDatasetSource LinkedDatasetSource { get; set; }

        /// <summary>
        /// The geographic location where the dataset should reside. See
        /// https://cloud.google.com/bigquery/docs/locations for supported locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// Optional. Defines the time travel window in hours. The value can be from 48 to 168 hours (2 to 7 days). The
        /// default value is 168 hours if this is not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxTimeTravelHours")]
        public virtual System.Nullable<long> MaxTimeTravelHours { get; set; }

        /// <summary>
        /// Optional. The [tags](https://cloud.google.com/bigquery/docs/tags) attached to this dataset. Tag keys are
        /// globally unique. Tag key is expected to be in the namespaced format, for example "123456789012/environment"
        /// where 123456789012 is the ID of the parent organization or project resource for this tag key. Tag value is
        /// expected to be the short name, for example "Production". See [Tag
        /// definitions](https://cloud.google.com/iam/docs/tags-access-control#definitions) for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceTags")]
        public virtual System.Collections.Generic.IDictionary<string, string> ResourceTags { get; set; }

        /// <summary>
        /// Optional. Output only. Restriction config for all tables and dataset. If set, restrict certain accesses on
        /// the dataset and all its tables based on the config. See [Data
        /// egress](https://cloud.google.com/bigquery/docs/analytics-hub-introduction#data_egress) for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictions")]
        public virtual RestrictionConfig Restrictions { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>
        /// Output only. A URL that can be used to access the resource again. You can use this URL in Get or Update
        /// requests to the resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Optional. Updates storage_billing_model for the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageBillingModel")]
        public virtual string StorageBillingModel { get; set; }

        /// <summary>
        /// Output only. Tags for the dataset. To provide tags as inputs, use the `resourceTags` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<TagsData> Tags { get; set; }

        /// <summary>
        /// Output only. Same as `type` in `ListFormatDataset`. The type of the dataset, one of: * DEFAULT - only
        /// accessible by owner and authorized accounts, * PUBLIC - accessible by everyone, * LINKED - linked dataset, *
        /// EXTERNAL - dataset with definition in external metadata catalog.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// Optional. An array of objects that define dataset access for one or more entities. You can set this property
        /// when inserting or updating a dataset in order to control who is allowed to access the data. If unspecified
        /// at dataset creation time, BigQuery adds default dataset access for the following entities:
        /// access.specialGroup: projectReaders; access.role: READER; access.specialGroup: projectWriters; access.role:
        /// WRITER; access.specialGroup: projectOwners; access.role: OWNER; access.userByEmail: [dataset creator email];
        /// access.role: OWNER; If you patch a dataset, then this field is overwritten by the patched dataset's access
        /// field. To add entities, you must supply the entire existing access array in addition to any new entities
        /// that you want to add.
        /// </summary>
        public class AccessData
        {
            /// <summary>
            /// Optional. condition for the binding. If CEL expression in this field is true, this access binding will
            /// be considered
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("condition")]
            public virtual Expr Condition { get; set; }

            /// <summary>
            /// [Pick one] A grant authorizing all resources of a particular type in a particular dataset access to this
            /// dataset. Only views are supported for now. The role field is not required when this field is set. If
            /// that dataset is deleted and re-created, its access needs to be granted again via an update operation.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
            public virtual DatasetAccessEntry Dataset { get; set; }

            /// <summary>
            /// [Pick one] A domain to grant access to. Any users signed in with the domain specified will be granted
            /// the specified access. Example: "example.com". Maps to IAM policy member "domain:DOMAIN".
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("domain")]
            public virtual string Domain { get; set; }

            /// <summary>
            /// [Pick one] An email address of a Google Group to grant access to. Maps to IAM policy member
            /// "group:GROUP".
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("groupByEmail")]
            public virtual string GroupByEmail { get; set; }

            /// <summary>
            /// [Pick one] Some other type of member that appears in the IAM Policy but isn't a user, group, domain, or
            /// special group.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("iamMember")]
            public virtual string IamMember { get; set; }

            /// <summary>
            /// An IAM role ID that should be granted to the user, group, or domain specified in this access entry. The
            /// following legacy mappings will be applied: * `OWNER`: `roles/bigquery.dataOwner` * `WRITER`:
            /// `roles/bigquery.dataEditor` * `READER`: `roles/bigquery.dataViewer` This field will accept any of the
            /// above formats, but will return only the legacy format. For example, if you set this field to
            /// "roles/bigquery.dataOwner", it will be returned back as "OWNER".
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("role")]
            public virtual string Role { get; set; }

            /// <summary>
            /// [Pick one] A routine from a different dataset to grant access to. Queries executed against that routine
            /// will have read access to views/tables/routines in this dataset. Only UDF is supported for now. The role
            /// field is not required when this field is set. If that routine is updated by any user, access to the
            /// routine needs to be granted again via an update operation.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("routine")]
            public virtual RoutineReference Routine { get; set; }

            /// <summary>
            /// [Pick one] A special group to grant access to. Possible values include: * projectOwners: Owners of the
            /// enclosing project. * projectReaders: Readers of the enclosing project. * projectWriters: Writers of the
            /// enclosing project. * allAuthenticatedUsers: All authenticated BigQuery users. Maps to similarly-named
            /// IAM members.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("specialGroup")]
            public virtual string SpecialGroup { get; set; }

            /// <summary>
            /// [Pick one] An email address of a user to grant access to. For example: fred@example.com. Maps to IAM
            /// policy member "user:EMAIL" or "serviceAccount:EMAIL".
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("userByEmail")]
            public virtual string UserByEmail { get; set; }

            /// <summary>
            /// [Pick one] A view from a different dataset to grant access to. Queries executed against that view will
            /// have read access to views/tables/routines in this dataset. The role field is not required when this
            /// field is set. If that view is updated by any user, access to the view needs to be granted again via an
            /// update operation.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("view")]
            public virtual TableReference View { get; set; }
        }

        /// <summary>
        /// Output only. Tags for the dataset. To provide tags as inputs, use the `resourceTags` field.
        /// </summary>
        public class TagsData
        {
            /// <summary>
            /// Required. The namespaced friendly name of the tag key, e.g. "12345/environment" where 12345 is org id.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("tagKey")]
            public virtual string TagKey { get; set; }

            /// <summary>Required. The friendly short name of the tag value, e.g. "production".</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("tagValue")]
            public virtual string TagValue { get; set; }
        }
    }

    /// <summary>
    /// Grants all resources of particular types in a particular dataset read access to the current dataset. Similar to
    /// how individually authorized views work, updates to any resource granted through its dataset (including creation
    /// of new resources) requires read permission to referenced resources, plus write permission to the authorizing
    /// dataset.
    /// </summary>
    public class DatasetAccessEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The dataset this entry applies to</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual DatasetReference Dataset { get; set; }

        /// <summary>
        /// Which resources in the dataset this entry applies to. Currently, only views are supported, but additional
        /// target types may be added in the future.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetTypes")]
        public virtual System.Collections.Generic.IList<string> TargetTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response format for a page of results when listing datasets.</summary>
    public class DatasetList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An array of the dataset resources in the project. Each resource contains basic information. For full
        /// information about a particular dataset resource, use the Datasets: get method. This property is omitted when
        /// there are no datasets in the project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasets")]
        public virtual System.Collections.Generic.IList<DatasetsData> Datasets { get; set; }

        /// <summary>
        /// Output only. A hash value of the results page. You can use this property to determine if the page has
        /// changed since the last request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. The resource type. This property always returns the value "bigquery#datasetList"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// A token that can be used to request the next results page. This property is omitted on the final results
        /// page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// A list of skipped locations that were unreachable. For more information about BigQuery locations, see:
        /// https://cloud.google.com/bigquery/docs/locations. Example: "europe-west5"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>
        /// An array of the dataset resources in the project. Each resource contains basic information. For full
        /// information about a particular dataset resource, use the Datasets: get method. This property is omitted when
        /// there are no datasets in the project.
        /// </summary>
        public class DatasetsData
        {
            /// <summary>
            /// The dataset reference. Use this property to access specific parts of the dataset's ID, such as project
            /// ID or dataset ID.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("datasetReference")]
            public virtual DatasetReference DatasetReference { get; set; }

            /// <summary>
            /// Output only. Reference to a read-only external dataset defined in data catalogs outside of BigQuery.
            /// Filled out when the dataset type is EXTERNAL.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("externalDatasetReference")]
            public virtual ExternalDatasetReference ExternalDatasetReference { get; set; }

            /// <summary>An alternate name for the dataset. The friendly name is purely decorative in nature.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("friendlyName")]
            public virtual string FriendlyName { get; set; }

            /// <summary>The fully-qualified, unique, opaque ID of the dataset.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("id")]
            public virtual string Id { get; set; }

            /// <summary>The resource type. This property always returns the value "bigquery#dataset"</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("kind")]
            public virtual string Kind { get; set; }

            /// <summary>
            /// The labels associated with this dataset. You can use these to organize and group your datasets.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("labels")]
            public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

            /// <summary>The geographic location where the dataset resides.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("location")]
            public virtual string Location { get; set; }
        }
    }

    /// <summary>Identifier for a dataset.</summary>
    public class DatasetReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A unique ID for this dataset, without the project name. The ID must contain only letters (a-z,
        /// A-Z), numbers (0-9), or underscores (_). The maximum length is 1,024 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetId")]
        public virtual string DatasetId { get; set; }

        /// <summary>Optional. The ID of the project containing this dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Properties for the destination table.</summary>
    public class DestinationTableProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The description for the destination table. This will only be used if the destination table is
        /// newly created. If the table already exists and a value different than the current description is provided,
        /// the job will fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Internal use only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTime")]
        public virtual string ExpirationTimeRaw { get; set; }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpirationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpirationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(ExpirationTimeRaw);
            set => ExpirationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="ExpirationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpirationTimeDateTimeOffset instead.")]
        public virtual System.DateTime? ExpirationTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(ExpirationTimeRaw);
            set => ExpirationTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// Optional. Friendly name for the destination table. If the table already exists, it should be same as the
        /// existing friendly name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("friendlyName")]
        public virtual string FriendlyName { get; set; }

        /// <summary>
        /// Optional. The labels associated with this table. You can use these to organize and group your tables. This
        /// will only be used if the destination table is newly created. If the table already exists and labels are
        /// different than the current labels are provided, the job will fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents privacy policy associated with "differential privacy" method.</summary>
    public class DifferentialPrivacyPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The total delta budget for all queries against the privacy-protected view. Each subscriber query
        /// against this view charges the amount of delta that is pre-defined by the contributor through the privacy
        /// policy delta_per_query field. If there is sufficient budget, then the subscriber query attempts to complete.
        /// It might still fail due to other reasons, in which case the charge is refunded. If there is insufficient
        /// budget the query is rejected. There might be multiple charge attempts if a single query references multiple
        /// views. In this case there must be sufficient budget for all charges or the query is rejected and charges are
        /// refunded in best effort. The budget does not have a refresh policy and can only be updated via ALTER VIEW or
        /// circumvented by creating a new view that can be queried with a fresh budget.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deltaBudget")]
        public virtual System.Nullable<double> DeltaBudget { get; set; }

        /// <summary>
        /// Output only. The delta budget remaining. If budget is exhausted, no more queries are allowed. Note that the
        /// budget for queries that are in progress is deducted before the query executes. If the query fails or is
        /// cancelled then the budget is refunded. In this case the amount of budget remaining can increase.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deltaBudgetRemaining")]
        public virtual System.Nullable<double> DeltaBudgetRemaining { get; set; }

        /// <summary>
        /// Optional. The delta value that is used per query. Delta represents the probability that any row will fail to
        /// be epsilon differentially private. Indicates the risk associated with exposing aggregate rows in the result
        /// of a query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deltaPerQuery")]
        public virtual System.Nullable<double> DeltaPerQuery { get; set; }

        /// <summary>
        /// Optional. The total epsilon budget for all queries against the privacy-protected view. Each subscriber query
        /// against this view charges the amount of epsilon they request in their query. If there is sufficient budget,
        /// then the subscriber query attempts to complete. It might still fail due to other reasons, in which case the
        /// charge is refunded. If there is insufficient budget the query is rejected. There might be multiple charge
        /// attempts if a single query references multiple views. In this case there must be sufficient budget for all
        /// charges or the query is rejected and charges are refunded in best effort. The budget does not have a refresh
        /// policy and can only be updated via ALTER VIEW or circumvented by creating a new view that can be queried
        /// with a fresh budget.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("epsilonBudget")]
        public virtual System.Nullable<double> EpsilonBudget { get; set; }

        /// <summary>
        /// Output only. The epsilon budget remaining. If budget is exhausted, no more queries are allowed. Note that
        /// the budget for queries that are in progress is deducted before the query executes. If the query fails or is
        /// cancelled then the budget is refunded. In this case the amount of budget remaining can increase.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("epsilonBudgetRemaining")]
        public virtual System.Nullable<double> EpsilonBudgetRemaining { get; set; }

        /// <summary>
        /// Optional. The maximum epsilon value that a query can consume. If the subscriber specifies epsilon as a
        /// parameter in a SELECT query, it must be less than or equal to this value. The epsilon parameter controls the
        /// amount of noise that is added to the groups — a higher epsilon means less noise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxEpsilonPerQuery")]
        public virtual System.Nullable<double> MaxEpsilonPerQuery { get; set; }

        /// <summary>
        /// Optional. The maximum groups contributed value that is used per query. Represents the maximum number of
        /// groups to which each protected entity can contribute. Changing this value does not improve or worsen
        /// privacy. The best value for accuracy and utility depends on the query and data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxGroupsContributed")]
        public virtual System.Nullable<long> MaxGroupsContributed { get; set; }

        /// <summary>
        /// Optional. The privacy unit column associated with this policy. Differential privacy policies can only have
        /// one privacy unit column per data source object (table, view).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privacyUnitColumn")]
        public virtual string PrivacyUnitColumn { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Model evaluation metrics for dimensionality reduction models.</summary>
    public class DimensionalityReductionMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Total percentage of variance explained by the selected principal components.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalExplainedVarianceRatio")]
        public virtual System.Nullable<double> TotalExplainedVarianceRatio { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detailed statistics for DML statements</summary>
    public class DmlStatistics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Number of deleted Rows. populated by DML DELETE, MERGE and TRUNCATE statements.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletedRowCount")]
        public virtual System.Nullable<long> DeletedRowCount { get; set; }

        /// <summary>Output only. Number of inserted Rows. Populated by DML INSERT and MERGE statements</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertedRowCount")]
        public virtual System.Nullable<long> InsertedRowCount { get; set; }

        /// <summary>Output only. Number of updated Rows. Populated by DML UPDATE and MERGE statements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatedRowCount")]
        public virtual System.Nullable<long> UpdatedRowCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Discrete candidates of a double hyperparameter.</summary>
    public class DoubleCandidates : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Candidates for the double parameter in increasing order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("candidates")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> Candidates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Search space for a double hyperparameter.</summary>
    public class DoubleHparamSearchSpace : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Candidates of the double hyperparameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("candidates")]
        public virtual DoubleCandidates Candidates { get; set; }

        /// <summary>Range of the double hyperparameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual DoubleRange Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Range of a double hyperparameter.</summary>
    public class DoubleRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Max value of the double parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("max")]
        public virtual System.Nullable<double> Max { get; set; }

        /// <summary>Min value of the double parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("min")]
        public virtual System.Nullable<double> Min { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for Cloud KMS encryption settings.</summary>
    public class EncryptionConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table.
        /// The BigQuery Service Account associated with your project requires access to this encryption key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single entry in the confusion matrix.</summary>
    public class Entry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of items being predicted as this label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemCount")]
        public virtual System.Nullable<long> ItemCount { get; set; }

        /// <summary>
        /// The predicted label. For confidence_threshold &amp;gt; 0, we will also add an entry indicating the number of
        /// items under the confidence threshold.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predictedLabel")]
        public virtual string PredictedLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Error details.</summary>
    public class ErrorProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Debugging information. This property is internal to Google and should not be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugInfo")]
        public virtual string DebugInfo { get; set; }

        /// <summary>Specifies where the error occurred, if present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>A human-readable description of the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>A short error code that summarizes the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Evaluation metrics of a model. These are either computed on all training data or just the eval data based on
    /// whether eval data was used during training. These are not present for imported models.
    /// </summary>
    public class EvaluationMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Populated for ARIMA models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arimaForecastingMetrics")]
        public virtual ArimaForecastingMetrics ArimaForecastingMetrics { get; set; }

        /// <summary>Populated for binary classification/classifier models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryClassificationMetrics")]
        public virtual BinaryClassificationMetrics BinaryClassificationMetrics { get; set; }

        /// <summary>Populated for clustering models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusteringMetrics")]
        public virtual ClusteringMetrics ClusteringMetrics { get; set; }

        /// <summary>
        /// Evaluation metrics when the model is a dimensionality reduction model, which currently includes PCA.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionalityReductionMetrics")]
        public virtual DimensionalityReductionMetrics DimensionalityReductionMetrics { get; set; }

        /// <summary>Populated for multi-class classification/classifier models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiClassClassificationMetrics")]
        public virtual MultiClassClassificationMetrics MultiClassClassificationMetrics { get; set; }

        /// <summary>Populated for implicit feedback type matrix factorization models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rankingMetrics")]
        public virtual RankingMetrics RankingMetrics { get; set; }

        /// <summary>Populated for regression models and explicit feedback type matrix factorization models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regressionMetrics")]
        public virtual RegressionMetrics RegressionMetrics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single stage of query execution.</summary>
    public class ExplainQueryStage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of parallel input segments completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completedParallelInputs")]
        public virtual System.Nullable<long> CompletedParallelInputs { get; set; }

        /// <summary>Output only. Compute mode for this stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeMode")]
        public virtual string ComputeMode { get; set; }

        /// <summary>Milliseconds the average shard spent on CPU-bound tasks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeMsAvg")]
        public virtual System.Nullable<long> ComputeMsAvg { get; set; }

        /// <summary>Milliseconds the slowest shard spent on CPU-bound tasks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeMsMax")]
        public virtual System.Nullable<long> ComputeMsMax { get; set; }

        /// <summary>Relative amount of time the average shard spent on CPU-bound tasks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeRatioAvg")]
        public virtual System.Nullable<double> ComputeRatioAvg { get; set; }

        /// <summary>Relative amount of time the slowest shard spent on CPU-bound tasks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeRatioMax")]
        public virtual System.Nullable<double> ComputeRatioMax { get; set; }

        /// <summary>Stage end time represented as milliseconds since the epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endMs")]
        public virtual System.Nullable<long> EndMs { get; set; }

        /// <summary>Unique ID for the stage within the plan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>IDs for stages that are inputs to this stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputStages")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> InputStages { get; set; }

        /// <summary>Human-readable name for the stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Number of parallel input segments to be processed</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parallelInputs")]
        public virtual System.Nullable<long> ParallelInputs { get; set; }

        /// <summary>Milliseconds the average shard spent reading input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readMsAvg")]
        public virtual System.Nullable<long> ReadMsAvg { get; set; }

        /// <summary>Milliseconds the slowest shard spent reading input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readMsMax")]
        public virtual System.Nullable<long> ReadMsMax { get; set; }

        /// <summary>Relative amount of time the average shard spent reading input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readRatioAvg")]
        public virtual System.Nullable<double> ReadRatioAvg { get; set; }

        /// <summary>Relative amount of time the slowest shard spent reading input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readRatioMax")]
        public virtual System.Nullable<double> ReadRatioMax { get; set; }

        /// <summary>Number of records read into the stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordsRead")]
        public virtual System.Nullable<long> RecordsRead { get; set; }

        /// <summary>Number of records written by the stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordsWritten")]
        public virtual System.Nullable<long> RecordsWritten { get; set; }

        /// <summary>Total number of bytes written to shuffle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shuffleOutputBytes")]
        public virtual System.Nullable<long> ShuffleOutputBytes { get; set; }

        /// <summary>Total number of bytes written to shuffle and spilled to disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shuffleOutputBytesSpilled")]
        public virtual System.Nullable<long> ShuffleOutputBytesSpilled { get; set; }

        /// <summary>Slot-milliseconds used by the stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slotMs")]
        public virtual System.Nullable<long> SlotMs { get; set; }

        /// <summary>Stage start time represented as milliseconds since the epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startMs")]
        public virtual System.Nullable<long> StartMs { get; set; }

        /// <summary>Current status for this stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>List of operations within the stage in dependency order (approximately chronological).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual System.Collections.Generic.IList<ExplainQueryStep> Steps { get; set; }

        /// <summary>Milliseconds the average shard spent waiting to be scheduled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waitMsAvg")]
        public virtual System.Nullable<long> WaitMsAvg { get; set; }

        /// <summary>Milliseconds the slowest shard spent waiting to be scheduled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waitMsMax")]
        public virtual System.Nullable<long> WaitMsMax { get; set; }

        /// <summary>Relative amount of time the average shard spent waiting to be scheduled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waitRatioAvg")]
        public virtual System.Nullable<double> WaitRatioAvg { get; set; }

        /// <summary>Relative amount of time the slowest shard spent waiting to be scheduled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waitRatioMax")]
        public virtual System.Nullable<double> WaitRatioMax { get; set; }

        /// <summary>Milliseconds the average shard spent on writing output.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeMsAvg")]
        public virtual System.Nullable<long> WriteMsAvg { get; set; }

        /// <summary>Milliseconds the slowest shard spent on writing output.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeMsMax")]
        public virtual System.Nullable<long> WriteMsMax { get; set; }

        /// <summary>Relative amount of time the average shard spent on writing output.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeRatioAvg")]
        public virtual System.Nullable<double> WriteRatioAvg { get; set; }

        /// <summary>Relative amount of time the slowest shard spent on writing output.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeRatioMax")]
        public virtual System.Nullable<double> WriteRatioMax { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An operation within a stage.</summary>
    public class ExplainQueryStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Machine-readable operation type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Human-readable description of the step(s).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("substeps")]
        public virtual System.Collections.Generic.IList<string> Substeps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Explanation for a single feature.</summary>
    public class Explanation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Attribution of feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attribution")]
        public virtual System.Nullable<double> Attribution { get; set; }

        /// <summary>
        /// The full feature name. For non-numerical features, will be formatted like `.`. Overall size of feature name
        /// will always be truncated to first 120 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("featureName")]
        public virtual string FeatureName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Statistics for the EXPORT DATA statement as part of Query Job. EXTRACT JOB statistics are populated in
    /// JobStatistics4.
    /// </summary>
    public class ExportDataStatistics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of destination files generated in case of EXPORT DATA statement only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileCount")]
        public virtual System.Nullable<long> FileCount { get; set; }

        /// <summary>[Alpha] Number of destination rows generated in case of EXPORT DATA statement only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowCount")]
        public virtual System.Nullable<long> RowCount { get; set; }

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
    /// Options defining open source compatible datasets living in the BigQuery catalog. Contains metadata of open
    /// source database, schema, or namespace represented by the current dataset.
    /// </summary>
    public class ExternalCatalogDatasetOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The storage location URI for all tables in the dataset. Equivalent to hive metastore's database
        /// locationUri. Maximum length of 1024 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultStorageLocationUri")]
        public virtual string DefaultStorageLocationUri { get; set; }

        /// <summary>
        /// Optional. A map of key value pairs defining the parameters and properties of the open source schema. Maximum
        /// size of 2MiB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string, string> Parameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata about open source compatible table. The fields contained in these options correspond to Hive
    /// metastore's table-level properties.
    /// </summary>
    public class ExternalCatalogTableOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A connection ID that specifies the credentials to be used to read external storage, such as Azure
        /// Blob, Cloud Storage, or Amazon S3. This connection is needed to read the open source table from BigQuery.
        /// The connection_id format must be either `..` or `projects//locations//connections/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionId")]
        public virtual string ConnectionId { get; set; }

        /// <summary>
        /// Optional. A map of the key-value pairs defining the parameters and properties of the open source table.
        /// Corresponds with Hive metastore table parameters. Maximum size of 4MiB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Optional. A storage descriptor containing information about the physical storage of this table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageDescriptor")]
        public virtual StorageDescriptor StorageDescriptor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ExternalDataConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Try to detect schema and format options automatically. Any option specified explicitly will be honored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autodetect")]
        public virtual System.Nullable<bool> Autodetect { get; set; }

        /// <summary>Optional. Additional properties to set if sourceFormat is set to AVRO.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avroOptions")]
        public virtual AvroOptions AvroOptions { get; set; }

        /// <summary>Optional. Additional options if sourceFormat is set to BIGTABLE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigtableOptions")]
        public virtual BigtableOptions BigtableOptions { get; set; }

        /// <summary>
        /// Optional. The compression type of the data source. Possible values include GZIP and NONE. The default value
        /// is NONE. This setting is ignored for Google Cloud Bigtable, Google Cloud Datastore backups, Avro, ORC and
        /// Parquet formats. An empty string is an invalid value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compression")]
        public virtual string Compression { get; set; }

        /// <summary>
        /// Optional. The connection specifying the credentials to be used to read external storage, such as Azure Blob,
        /// Cloud Storage, or S3. The connection_id can have the form `{project_id}.{location_id};{connection_id}` or
        /// `projects/{project_id}/locations/{location_id}/connections/{connection_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionId")]
        public virtual string ConnectionId { get; set; }

        /// <summary>Optional. Additional properties to set if sourceFormat is set to CSV.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("csvOptions")]
        public virtual CsvOptions CsvOptions { get; set; }

        /// <summary>Optional. Format used to parse DATE values. Supports C-style and SQL-style values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateFormat")]
        public virtual string DateFormat { get; set; }

        /// <summary>Optional. Format used to parse DATETIME values. Supports C-style and SQL-style values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datetimeFormat")]
        public virtual string DatetimeFormat { get; set; }

        /// <summary>
        /// Defines the list of possible SQL data types to which the source decimal values are converted. This list and
        /// the precision and the scale parameters of the decimal field determine the target type. In the order of
        /// NUMERIC, BIGNUMERIC, and STRING, a type is picked if it is in the specified list and if it supports the
        /// precision and the scale. STRING supports all precision and scale values. If none of the listed types
        /// supports the precision and the scale, the type supporting the widest range in the specified list is picked,
        /// and if a value exceeds the supported range when reading the data, an error will be thrown. Example: Suppose
        /// the value of this field is ["NUMERIC", "BIGNUMERIC"]. If (precision,scale) is: * (38,9) -&amp;gt; NUMERIC; *
        /// (39,9) -&amp;gt; BIGNUMERIC (NUMERIC cannot hold 30 integer digits); * (38,10) -&amp;gt; BIGNUMERIC (NUMERIC
        /// cannot hold 10 fractional digits); * (76,38) -&amp;gt; BIGNUMERIC; * (77,38) -&amp;gt; BIGNUMERIC (error if
        /// value exceeds supported range). This field cannot contain duplicate types. The order of the types in this
        /// field is ignored. For example, ["BIGNUMERIC", "NUMERIC"] is the same as ["NUMERIC", "BIGNUMERIC"] and
        /// NUMERIC always takes precedence over BIGNUMERIC. Defaults to ["NUMERIC", "STRING"] for ORC and ["NUMERIC"]
        /// for the other file formats.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("decimalTargetTypes")]
        public virtual System.Collections.Generic.IList<string> DecimalTargetTypes { get; set; }

        /// <summary>
        /// Optional. Specifies how source URIs are interpreted for constructing the file set to load. By default source
        /// URIs are expanded against the underlying storage. Other options include specifying manifest files. Only
        /// applicable to object storage systems.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileSetSpecType")]
        public virtual string FileSetSpecType { get; set; }

        /// <summary>Optional. Additional options if sourceFormat is set to GOOGLE_SHEETS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleSheetsOptions")]
        public virtual GoogleSheetsOptions GoogleSheetsOptions { get; set; }

        /// <summary>
        /// Optional. When set, configures hive partitioning support. Not all storage formats support hive partitioning
        /// -- requesting hive partitioning on an unsupported format will lead to an error, as will providing an invalid
        /// specification.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hivePartitioningOptions")]
        public virtual HivePartitioningOptions HivePartitioningOptions { get; set; }

        /// <summary>
        /// Optional. Indicates if BigQuery should allow extra values that are not represented in the table schema. If
        /// true, the extra values are ignored. If false, records with extra columns are treated as bad records, and if
        /// there are too many bad records, an invalid error is returned in the job result. The default value is false.
        /// The sourceFormat property determines what BigQuery treats as an extra value: CSV: Trailing columns JSON:
        /// Named values that don't match any column names Google Cloud Bigtable: This setting is ignored. Google Cloud
        /// Datastore backups: This setting is ignored. Avro: This setting is ignored. ORC: This setting is ignored.
        /// Parquet: This setting is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreUnknownValues")]
        public virtual System.Nullable<bool> IgnoreUnknownValues { get; set; }

        /// <summary>
        /// Optional. Load option to be used together with source_format newline-delimited JSON to indicate that a
        /// variant of JSON is being loaded. To load newline-delimited GeoJSON, specify GEOJSON (and source_format must
        /// be set to NEWLINE_DELIMITED_JSON).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonExtension")]
        public virtual string JsonExtension { get; set; }

        /// <summary>Optional. Additional properties to set if sourceFormat is set to JSON.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonOptions")]
        public virtual JsonOptions JsonOptions { get; set; }

        /// <summary>
        /// Optional. The maximum number of bad records that BigQuery can ignore when reading data. If the number of bad
        /// records exceeds this value, an invalid error is returned in the job result. The default value is 0, which
        /// requires that all records are valid. This setting is ignored for Google Cloud Bigtable, Google Cloud
        /// Datastore backups, Avro, ORC and Parquet formats.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxBadRecords")]
        public virtual System.Nullable<int> MaxBadRecords { get; set; }

        /// <summary>
        /// Optional. Metadata Cache Mode for the table. Set this to enable caching of metadata from external data
        /// source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadataCacheMode")]
        public virtual string MetadataCacheMode { get; set; }

        /// <summary>
        /// Optional. ObjectMetadata is used to create Object Tables. Object Tables contain a listing of objects (with
        /// their metadata) found at the source_uris. If ObjectMetadata is set, source_format should be omitted.
        /// Currently SIMPLE is the only supported Object Metadata type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectMetadata")]
        public virtual string ObjectMetadata { get; set; }

        /// <summary>Optional. Additional properties to set if sourceFormat is set to PARQUET.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parquetOptions")]
        public virtual ParquetOptions ParquetOptions { get; set; }

        /// <summary>
        /// Optional. When creating an external table, the user can provide a reference file with the table schema. This
        /// is enabled for the following formats: AVRO, PARQUET, ORC.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceFileSchemaUri")]
        public virtual string ReferenceFileSchemaUri { get; set; }

        /// <summary>
        /// Optional. The schema for the data. Schema is required for CSV and JSON formats if autodetect is not on.
        /// Schema is disallowed for Google Cloud Bigtable, Cloud Datastore backups, Avro, ORC and Parquet formats.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual TableSchema Schema { get; set; }

        /// <summary>
        /// [Required] The data format. For CSV files, specify "CSV". For Google sheets, specify "GOOGLE_SHEETS". For
        /// newline-delimited JSON, specify "NEWLINE_DELIMITED_JSON". For Avro files, specify "AVRO". For Google Cloud
        /// Datastore backups, specify "DATASTORE_BACKUP". For Apache Iceberg tables, specify "ICEBERG". For ORC files,
        /// specify "ORC". For Parquet files, specify "PARQUET". [Beta] For Google Cloud Bigtable, specify "BIGTABLE".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceFormat")]
        public virtual string SourceFormat { get; set; }

        /// <summary>
        /// [Required] The fully-qualified URIs that point to your data in Google Cloud. For Google Cloud Storage URIs:
        /// Each URI can contain one '*' wildcard character and it must come after the 'bucket' name. Size limits
        /// related to load jobs apply to external data sources. For Google Cloud Bigtable URIs: Exactly one URI can be
        /// specified and it has be a fully specified and valid HTTPS URL for a Google Cloud Bigtable table. For Google
        /// Cloud Datastore backups, exactly one URI can be specified. Also, the '*' wildcard character is not allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceUris")]
        public virtual System.Collections.Generic.IList<string> SourceUris { get; set; }

        /// <summary>Optional. Format used to parse TIME values. Supports C-style and SQL-style values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeFormat")]
        public virtual string TimeFormat { get; set; }

        /// <summary>
        /// Optional. Time zone used when parsing timestamp values that do not have specific time zone information (e.g.
        /// 2024-04-20 12:34:56). The expected format is a IANA timezone string (e.g. America/Los_Angeles).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>Optional. Format used to parse TIMESTAMP values. Supports C-style and SQL-style values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampFormat")]
        public virtual string TimestampFormat { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configures the access a dataset defined in an external metadata storage.</summary>
    public class ExternalDatasetReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The connection id that is used to access the external_source. Format:
        /// projects/{project_id}/locations/{location_id}/connections/{connection_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connection")]
        public virtual string Connection { get; set; }

        /// <summary>Required. External source that backs this dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalSource")]
        public virtual string ExternalSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The external service cost is a portion of the total cost, these costs are not additive with total_bytes_billed.
    /// Moreover, this field only track external service costs that will show up as BigQuery costs (e.g. training
    /// BigQuery ML job with google cloud CAIP or Automl Tables services), not other costs which may be accrued by
    /// running the query (e.g. reading from Bigtable or Cloud Storage). The external service costs with different
    /// billing sku (e.g. CAIP job is charged based on VM usage) are converted to BigQuery billed_bytes and slot_ms with
    /// equivalent amount of US dollars. Services may not directly correlate to these metrics, but these are the
    /// equivalents for billing purposes. Output only.
    /// </summary>
    public class ExternalServiceCost : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>External service cost in terms of bigquery bytes billed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bytesBilled")]
        public virtual System.Nullable<long> BytesBilled { get; set; }

        /// <summary>External service cost in terms of bigquery bytes processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bytesProcessed")]
        public virtual System.Nullable<long> BytesProcessed { get; set; }

        /// <summary>External service name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalService")]
        public virtual string ExternalService { get; set; }

        /// <summary>
        /// Non-preemptable reserved slots used for external job. For example, reserved slots for Cloua AI Platform job
        /// are the VM usages converted to BigQuery slot with equivalent mount of price.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservedSlotCount")]
        public virtual System.Nullable<long> ReservedSlotCount { get; set; }

        /// <summary>External service cost in terms of bigquery slot milliseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slotMs")]
        public virtual System.Nullable<long> SlotMs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representative value of a single feature within the cluster.</summary>
    public class FeatureValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The categorical feature value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoricalValue")]
        public virtual CategoricalValue CategoricalValue { get; set; }

        /// <summary>The feature column name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("featureColumn")]
        public virtual string FeatureColumn { get; set; }

        /// <summary>The numerical feature value. This is the centroid value for this feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numericalValue")]
        public virtual System.Nullable<double> NumericalValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata about the foreign data type definition such as the system in which the type is defined.
    /// </summary>
    public class ForeignTypeInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Specifies the system which defines the foreign data type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("typeSystem")]
        public virtual string TypeSystem { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A view can be represented in multiple ways. Each representation has its own dialect. This message stores the
    /// metadata required for these representations.
    /// </summary>
    public class ForeignViewDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Represents the dialect of the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dialect")]
        public virtual string Dialect { get; set; }

        /// <summary>Required. The query that defines the view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `GetIamPolicy` method.</summary>
    public class GetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>OPTIONAL: A `GetPolicyOptions` object for specifying options to `GetIamPolicy`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual GetPolicyOptions Options { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates settings provided to GetIamPolicy.</summary>
    public class GetPolicyOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0, 1, and 3.
        /// Requests specifying an invalid value will be rejected. Requests for policies with any conditional role
        /// bindings must specify version 3. Policies with no conditional role bindings may specify any valid value or
        /// leave the field unset. The policy in the response might use the policy version that you specified, or it
        /// might use a lower policy version. For example, if you specify version 3, but the policy has no conditional
        /// role bindings, the response uses version 1. To learn which resources support conditions in their IAM
        /// policies, see the [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedPolicyVersion")]
        public virtual System.Nullable<int> RequestedPolicyVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response object of GetQueryResults.</summary>
    public class GetQueryResultsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the query result was fetched from the query cache.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheHit")]
        public virtual System.Nullable<bool> CacheHit { get; set; }

        /// <summary>
        /// Output only. The first errors or warnings encountered during the running of the job. The final message
        /// includes the number of errors that caused the process to stop. Errors here do not necessarily mean that the
        /// job has completed or was unsuccessful. For more information about error messages, see [Error
        /// messages](https://cloud.google.com/bigquery/docs/error-messages).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<ErrorProto> Errors { get; set; }

        /// <summary>A hash of this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Whether the query has completed or not. If rows or totalRows are present, this will always be true. If this
        /// is false, totalRows will not be available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobComplete")]
        public virtual System.Nullable<bool> JobComplete { get; set; }

        /// <summary>
        /// Reference to the BigQuery Job that was created to run the query. This field will be present even if the
        /// original request timed out, in which case GetQueryResults can be used to read the results once the query has
        /// completed. Since this API only returns the first page of results, subsequent pages can be fetched via the
        /// same mechanism (GetQueryResults).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobReference")]
        public virtual JobReference JobReference { get; set; }

        /// <summary>The resource type of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Output only. The number of rows affected by a DML statement. Present only for DML statements INSERT, UPDATE
        /// or DELETE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numDmlAffectedRows")]
        public virtual System.Nullable<long> NumDmlAffectedRows { get; set; }

        /// <summary>
        /// A token used for paging results. When this token is non-empty, it indicates additional results are
        /// available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// An object with as many results as can be contained within the maximum permitted reply size. To get any
        /// additional rows, you can call GetQueryResults and specify the jobReference returned above. Present only when
        /// the query completes successfully. The REST-based representation of this data leverages a series of JSON f,v
        /// objects for indicating fields and values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<TableRow> Rows { get; set; }

        /// <summary>The schema of the results. Present only when the query completes successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual TableSchema Schema { get; set; }

        /// <summary>The total number of bytes processed for this query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalBytesProcessed")]
        public virtual System.Nullable<long> TotalBytesProcessed { get; set; }

        /// <summary>
        /// The total number of rows in the complete query result set, which can be more than the number of rows in this
        /// single page of results. Present only when the query completes successfully.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalRows")]
        public virtual System.Nullable<ulong> TotalRows { get; set; }
    }

    /// <summary>Response object of GetServiceAccount</summary>
    public class GetServiceAccountResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The service account email address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The resource type of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Global explanations containing the top most important features after training.</summary>
    public class GlobalExplanation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Class label for this set of global explanations. Will be empty/null for binary logistic and linear
        /// regression models. Sorted alphabetically in descending order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classLabel")]
        public virtual string ClassLabel { get; set; }

        /// <summary>
        /// A list of the top global explanations. Sorted by absolute value of attribution in descending order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explanations")]
        public virtual System.Collections.Generic.IList<Explanation> Explanations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options specific to Google Sheets data sources.</summary>
    public class GoogleSheetsOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Range of a sheet to query from. Only used when non-empty. Typical format:
        /// sheet_name!top_left_cell_id:bottom_right_cell_id For example: sheet1!A1:B20
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual string Range { get; set; }

        /// <summary>
        /// Optional. The number of rows at the top of a sheet that BigQuery will skip when reading the data. The
        /// default value is 0. This property is useful if you have header rows that should be skipped. When autodetect
        /// is on, the behavior is the following: * skipLeadingRows unspecified - Autodetect tries to detect headers in
        /// the first row. If they are not detected, the row is read as data. Otherwise data is read starting from the
        /// second row. * skipLeadingRows is 0 - Instructs autodetect that there are no headers and data should be read
        /// starting from the first row. * skipLeadingRows = N &amp;gt; 0 - Autodetect skips N-1 rows and tries to
        /// detect headers in row N. If headers are not detected, row N is just skipped. Otherwise row N is used to
        /// extract column names for the detected schema.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipLeadingRows")]
        public virtual System.Nullable<long> SkipLeadingRows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>High cardinality join detailed information.</summary>
    public class HighCardinalityJoin : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Count of left input rows.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leftRows")]
        public virtual System.Nullable<long> LeftRows { get; set; }

        /// <summary>Output only. Count of the output rows.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputRows")]
        public virtual System.Nullable<long> OutputRows { get; set; }

        /// <summary>Output only. Count of right input rows.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rightRows")]
        public virtual System.Nullable<long> RightRows { get; set; }

        /// <summary>Output only. The index of the join operator in the ExplainQueryStep lists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stepIndex")]
        public virtual System.Nullable<int> StepIndex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for configuring hive partitioning detect.</summary>
    public class HivePartitioningOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. For permanent external tables, this field is populated with the hive partition keys in the
        /// order they were inferred. The types of the partition keys can be deduced by checking the table schema (which
        /// will include the partition keys). Not every API will populate this field in the output. For example,
        /// Tables.Get will populate it, but Tables.List will not contain this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<string> Fields { get; set; }

        /// <summary>
        /// Optional. When set, what mode of hive partitioning to use when reading data. The following modes are
        /// supported: * AUTO: automatically infer partition key name(s) and type(s). * STRINGS: automatically infer
        /// partition key name(s). All types are strings. * CUSTOM: partition key schema is encoded in the source URI
        /// prefix. Not all storage formats support hive partitioning. Requesting hive partitioning on an unsupported
        /// format will lead to an error. Currently supported formats are: JSON, CSV, ORC, Avro and Parquet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>
        /// Optional. If set to true, queries over this table require a partition filter that can be used for partition
        /// elimination to be specified. Note that this field should only be true when creating a permanent external
        /// table or querying a temporary external table. Hive-partitioned loads with require_partition_filter
        /// explicitly set to true will fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requirePartitionFilter")]
        public virtual System.Nullable<bool> RequirePartitionFilter { get; set; }

        /// <summary>
        /// Optional. When hive partition detection is requested, a common prefix for all source uris must be required.
        /// The prefix must end immediately before the partition key encoding begins. For example, consider files
        /// following this data layout: gs://bucket/path_to_table/dt=2019-06-01/country=USA/id=7/file.avro
        /// gs://bucket/path_to_table/dt=2019-05-31/country=CA/id=3/file.avro When hive partitioning is requested with
        /// either AUTO or STRINGS detection, the common prefix can be either of gs://bucket/path_to_table or
        /// gs://bucket/path_to_table/. CUSTOM detection requires encoding the partitioning schema immediately after the
        /// common prefix. For CUSTOM, any of * gs://bucket/path_to_table/{dt:DATE}/{country:STRING}/{id:INTEGER} *
        /// gs://bucket/path_to_table/{dt:STRING}/{country:STRING}/{id:INTEGER} *
        /// gs://bucket/path_to_table/{dt:DATE}/{country:STRING}/{id:STRING} would all be valid source URI prefixes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceUriPrefix")]
        public virtual string SourceUriPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Hyperparameter search spaces. These should be a subset of training_options.</summary>
    public class HparamSearchSpaces : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Activation functions of neural network models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activationFn")]
        public virtual StringHparamSearchSpace ActivationFn { get; set; }

        /// <summary>Mini batch sample size.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchSize")]
        public virtual IntHparamSearchSpace BatchSize { get; set; }

        /// <summary>Booster type for boosted tree models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boosterType")]
        public virtual StringHparamSearchSpace BoosterType { get; set; }

        /// <summary>Subsample ratio of columns for each level for boosted tree models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colsampleBylevel")]
        public virtual DoubleHparamSearchSpace ColsampleBylevel { get; set; }

        /// <summary>Subsample ratio of columns for each node(split) for boosted tree models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colsampleBynode")]
        public virtual DoubleHparamSearchSpace ColsampleBynode { get; set; }

        /// <summary>Subsample ratio of columns when constructing each tree for boosted tree models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colsampleBytree")]
        public virtual DoubleHparamSearchSpace ColsampleBytree { get; set; }

        /// <summary>Dart normalization type for boosted tree models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dartNormalizeType")]
        public virtual StringHparamSearchSpace DartNormalizeType { get; set; }

        /// <summary>Dropout probability for dnn model training and boosted tree models using dart booster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dropout")]
        public virtual DoubleHparamSearchSpace Dropout { get; set; }

        /// <summary>Hidden units for neural network models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hiddenUnits")]
        public virtual IntArrayHparamSearchSpace HiddenUnits { get; set; }

        /// <summary>L1 regularization coefficient.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("l1Reg")]
        public virtual DoubleHparamSearchSpace L1Reg { get; set; }

        /// <summary>L2 regularization coefficient.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("l2Reg")]
        public virtual DoubleHparamSearchSpace L2Reg { get; set; }

        /// <summary>Learning rate of training jobs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("learnRate")]
        public virtual DoubleHparamSearchSpace LearnRate { get; set; }

        /// <summary>Maximum depth of a tree for boosted tree models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxTreeDepth")]
        public virtual IntHparamSearchSpace MaxTreeDepth { get; set; }

        /// <summary>Minimum split loss for boosted tree models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minSplitLoss")]
        public virtual DoubleHparamSearchSpace MinSplitLoss { get; set; }

        /// <summary>Minimum sum of instance weight needed in a child for boosted tree models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minTreeChildWeight")]
        public virtual IntHparamSearchSpace MinTreeChildWeight { get; set; }

        /// <summary>Number of clusters for k-means.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numClusters")]
        public virtual IntHparamSearchSpace NumClusters { get; set; }

        /// <summary>Number of latent factors to train on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numFactors")]
        public virtual IntHparamSearchSpace NumFactors { get; set; }

        /// <summary>Number of parallel trees for boosted tree models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numParallelTree")]
        public virtual IntHparamSearchSpace NumParallelTree { get; set; }

        /// <summary>Optimizer of TF models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optimizer")]
        public virtual StringHparamSearchSpace Optimizer { get; set; }

        /// <summary>Subsample the training data to grow tree to prevent overfitting for boosted tree models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subsample")]
        public virtual DoubleHparamSearchSpace Subsample { get; set; }

        /// <summary>Tree construction algorithm for boosted tree models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("treeMethod")]
        public virtual StringHparamSearchSpace TreeMethod { get; set; }

        /// <summary>Hyperparameter for matrix factoration when implicit feedback type is specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("walsAlpha")]
        public virtual DoubleHparamSearchSpace WalsAlpha { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Training info of a trial in [hyperparameter
    /// tuning](https://cloud.google.com/bigquery-ml/docs/reference/standard-sql/bigqueryml-syntax-hp-tuning-overview)
    /// models.
    /// </summary>
    public class HparamTuningTrial : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Ending time of the trial.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTimeMs")]
        public virtual System.Nullable<long> EndTimeMs { get; set; }

        /// <summary>Error message for FAILED and INFEASIBLE trial.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>Loss computed on the eval data at the end of trial.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evalLoss")]
        public virtual System.Nullable<double> EvalLoss { get; set; }

        /// <summary>Evaluation metrics of this trial calculated on the test data. Empty in Job API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationMetrics")]
        public virtual EvaluationMetrics EvaluationMetrics { get; set; }

        /// <summary>
        /// Hyperparameter tuning evaluation metrics of this trial calculated on the eval data. Unlike
        /// evaluation_metrics, only the fields corresponding to the hparam_tuning_objectives are set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hparamTuningEvaluationMetrics")]
        public virtual EvaluationMetrics HparamTuningEvaluationMetrics { get; set; }

        /// <summary>The hyperprameters selected for this trial.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hparams")]
        public virtual TrainingOptions Hparams { get; set; }

        /// <summary>Starting time of the trial.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeMs")]
        public virtual System.Nullable<long> StartTimeMs { get; set; }

        /// <summary>The status of the trial.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Loss computed on the training data at the end of trial.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingLoss")]
        public virtual System.Nullable<double> TrainingLoss { get; set; }

        /// <summary>1-based index of the trial.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trialId")]
        public virtual System.Nullable<long> TrialId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Reason about why no search index was used in the search query (or sub-query).</summary>
    public class IndexUnusedReason : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies the base table involved in the reason that no search index was used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseTable")]
        public virtual TableReference BaseTable { get; set; }

        /// <summary>Specifies the high-level reason for the scenario when no search index was used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Specifies the name of the unused search index, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexName")]
        public virtual string IndexName { get; set; }

        /// <summary>Free form human-readable reason for the scenario when no search index was used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about the input data change insight.</summary>
    public class InputDataChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Records read difference percentage compared to a previous run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordsReadDiffPercentage")]
        public virtual System.Nullable<float> RecordsReadDiffPercentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An array of int.</summary>
    public class IntArray : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Elements in the int array.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elements")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> Elements { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Search space for int array.</summary>
    public class IntArrayHparamSearchSpace : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Candidates for the int array parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("candidates")]
        public virtual System.Collections.Generic.IList<IntArray> Candidates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Discrete candidates of an int hyperparameter.</summary>
    public class IntCandidates : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Candidates for the int parameter in increasing order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("candidates")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> Candidates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Search space for an int hyperparameter.</summary>
    public class IntHparamSearchSpace : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Candidates of the int hyperparameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("candidates")]
        public virtual IntCandidates Candidates { get; set; }

        /// <summary>Range of the int hyperparameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual IntRange Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Range of an int hyperparameter.</summary>
    public class IntRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Max value of the int parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("max")]
        public virtual System.Nullable<long> Max { get; set; }

        /// <summary>Min value of the int parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("min")]
        public virtual System.Nullable<long> Min { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a single iteration of the training run.</summary>
    public class IterationResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Arima result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arimaResult")]
        public virtual ArimaResult ArimaResult { get; set; }

        /// <summary>Information about top clusters for clustering models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterInfos")]
        public virtual System.Collections.Generic.IList<ClusterInfo> ClusterInfos { get; set; }

        /// <summary>Time taken to run the iteration in milliseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("durationMs")]
        public virtual System.Nullable<long> DurationMs { get; set; }

        /// <summary>Loss computed on the eval data at the end of iteration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evalLoss")]
        public virtual System.Nullable<double> EvalLoss { get; set; }

        /// <summary>Index of the iteration, 0 based.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>Learn rate used for this iteration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("learnRate")]
        public virtual System.Nullable<double> LearnRate { get; set; }

        /// <summary>The information of the principal components.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalComponentInfos")]
        public virtual System.Collections.Generic.IList<PrincipalComponentInfo> PrincipalComponentInfos { get; set; }

        /// <summary>Loss computed on the training data at the end of iteration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingLoss")]
        public virtual System.Nullable<double> TrainingLoss { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Job : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Describes the job configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configuration")]
        public virtual JobConfiguration Configuration { get; set; }

        /// <summary>Output only. A hash of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Output only. Opaque ID field of the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Output only. The reason why a Job was created.
        /// [Preview](https://cloud.google.com/products/#product-launch-stages)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobCreationReason")]
        public virtual JobCreationReason JobCreationReason { get; set; }

        /// <summary>Optional. Reference describing the unique-per-user name of the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobReference")]
        public virtual JobReference JobReference { get; set; }

        /// <summary>Output only. The type of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Output only. [Full-projection-only] String representation of identity of requesting party. Populated for
        /// both first- and third-party identities. Only present for APIs that support third-party identities.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principal_subject")]
        public virtual string PrincipalSubject { get; set; }

        /// <summary>Output only. A URL that can be used to access the resource again.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>
        /// Output only. Information about the job, including starting time and ending time of the job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statistics")]
        public virtual JobStatistics Statistics { get; set; }

        /// <summary>
        /// Output only. The status of this job. Examine this value when polling an asynchronous job to see if the job
        /// is complete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual JobStatus Status { get; set; }

        /// <summary>Output only. Email address of the user who ran the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user_email")]
        public virtual string UserEmail { get; set; }
    }

    /// <summary>Describes format of a jobs cancellation response.</summary>
    public class JobCancelResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The final state of the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("job")]
        public virtual Job Job { get; set; }

        /// <summary>The resource type of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class JobConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Pick one] Copies a table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("copy")]
        public virtual JobConfigurationTableCopy Copy { get; set; }

        /// <summary>
        /// Optional. If set, don't actually run this job. A valid query will return a mostly empty response with some
        /// processing statistics, while an invalid query will return the same error it would if it wasn't a dry run.
        /// Behavior of non-query jobs is undefined.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dryRun")]
        public virtual System.Nullable<bool> DryRun { get; set; }

        /// <summary>[Pick one] Configures an extract job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extract")]
        public virtual JobConfigurationExtract Extract { get; set; }

        /// <summary>
        /// Optional. Job timeout in milliseconds. If this time limit is exceeded, BigQuery will attempt to stop a
        /// longer job, but may not always succeed in canceling it before the job completes. For example, a job that
        /// takes more than 60 seconds to complete has a better chance of being stopped than a job that takes 10 seconds
        /// to complete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobTimeoutMs")]
        public virtual System.Nullable<long> JobTimeoutMs { get; set; }

        /// <summary>Output only. The type of the job. Can be QUERY, LOAD, EXTRACT, COPY or UNKNOWN.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobType")]
        public virtual string JobType { get; set; }

        /// <summary>
        /// The labels associated with this job. You can use these to organize and group your jobs. Label keys and
        /// values can be no longer than 63 characters, can only contain lowercase letters, numeric characters,
        /// underscores and dashes. International characters are allowed. Label values are optional. Label keys must
        /// start with a letter and each label in the list must have a different key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>[Pick one] Configures a load job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("load")]
        public virtual JobConfigurationLoad Load { get; set; }

        /// <summary>[Pick one] Configures a query job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual JobConfigurationQuery Query { get; set; }

        /// <summary>
        /// Optional. The reservation that job would use. User can specify a reservation to execute the job. If
        /// reservation is not set, reservation is determined based on the rules defined by the reservation assignments.
        /// The expected format is `projects/{project}/locations/{location}/reservations/{reservation}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservation")]
        public virtual string Reservation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// JobConfigurationExtract configures a job that exports data from a BigQuery table into Google Cloud Storage.
    /// </summary>
    public class JobConfigurationExtract : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The compression type to use for exported files. Possible values include DEFLATE, GZIP, NONE,
        /// SNAPPY, and ZSTD. The default value is NONE. Not all compression formats are support for all file formats.
        /// DEFLATE is only supported for Avro. ZSTD is only supported for Parquet. Not applicable when extracting
        /// models.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compression")]
        public virtual string Compression { get; set; }

        /// <summary>
        /// Optional. The exported file format. Possible values include CSV, NEWLINE_DELIMITED_JSON, PARQUET, or AVRO
        /// for tables and ML_TF_SAVED_MODEL or ML_XGBOOST_BOOSTER for models. The default value for tables is CSV.
        /// Tables with nested or repeated fields cannot be exported as CSV. The default value for models is
        /// ML_TF_SAVED_MODEL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationFormat")]
        public virtual string DestinationFormat { get; set; }

        /// <summary>
        /// [Pick one] DEPRECATED: Use destinationUris instead, passing only one URI as necessary. The fully-qualified
        /// Google Cloud Storage URI where the extracted table should be written.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationUri")]
        public virtual string DestinationUri { get; set; }

        /// <summary>
        /// [Pick one] A list of fully-qualified Google Cloud Storage URIs where the extracted table should be written.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationUris")]
        public virtual System.Collections.Generic.IList<string> DestinationUris { get; set; }

        /// <summary>
        /// Optional. When extracting data in CSV format, this defines the delimiter to use between fields in the
        /// exported data. Default is ','. Not applicable when extracting models.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldDelimiter")]
        public virtual string FieldDelimiter { get; set; }

        /// <summary>Optional. Model extract options only applicable when extracting models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelExtractOptions")]
        public virtual ModelExtractOptions ModelExtractOptions { get; set; }

        /// <summary>
        /// Optional. Whether to print out a header row in the results. Default is true. Not applicable when extracting
        /// models.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("printHeader")]
        public virtual System.Nullable<bool> PrintHeader { get; set; }

        /// <summary>A reference to the model being exported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceModel")]
        public virtual ModelReference SourceModel { get; set; }

        /// <summary>A reference to the table being exported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceTable")]
        public virtual TableReference SourceTable { get; set; }

        /// <summary>
        /// Whether to use logical types when extracting to AVRO format. Not applicable when extracting models.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useAvroLogicalTypes")]
        public virtual System.Nullable<bool> UseAvroLogicalTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// JobConfigurationLoad contains the configuration properties for loading data into a destination table.
    /// </summary>
    public class JobConfigurationLoad : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Accept rows that are missing trailing optional columns. The missing values are treated as nulls.
        /// If false, records with missing trailing columns are treated as bad records, and if there are too many bad
        /// records, an invalid error is returned in the job result. The default value is false. Only applicable to CSV,
        /// ignored for other formats.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowJaggedRows")]
        public virtual System.Nullable<bool> AllowJaggedRows { get; set; }

        /// <summary>
        /// Indicates if BigQuery should allow quoted data sections that contain newline characters in a CSV file. The
        /// default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowQuotedNewlines")]
        public virtual System.Nullable<bool> AllowQuotedNewlines { get; set; }

        /// <summary>
        /// Optional. Indicates if we should automatically infer the options and schema for CSV and JSON sources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autodetect")]
        public virtual System.Nullable<bool> Autodetect { get; set; }

        /// <summary>Clustering specification for the destination table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clustering")]
        public virtual Clustering Clustering { get; set; }

        /// <summary>
        /// Optional. Character map supported for column names in CSV/Parquet loads. Defaults to STRICT and can be
        /// overridden by Project Config Service. Using this option with unsupporting load formats will result in an
        /// error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnNameCharacterMap")]
        public virtual string ColumnNameCharacterMap { get; set; }

        /// <summary>
        /// Optional. Connection properties which can modify the load job behavior. Currently, only the 'session_id'
        /// connection property is supported, and is used to resolve _SESSION appearing as the dataset id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionProperties")]
        public virtual System.Collections.Generic.IList<ConnectionProperty> ConnectionProperties { get; set; }

        /// <summary>
        /// Optional. [Experimental] Configures the load job to copy files directly to the destination BigLake managed
        /// table, bypassing file content reading and rewriting. Copying files only is supported when all the following
        /// are true: * `source_uris` are located in the same Cloud Storage location as the destination table's
        /// `storage_uri` location. * `source_format` is `PARQUET`. * `destination_table` is an existing BigLake managed
        /// table. The table's schema does not have flexible column names. The table's columns do not have type
        /// parameters other than precision and scale. * No options other than the above are specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("copyFilesOnly")]
        public virtual System.Nullable<bool> CopyFilesOnly { get; set; }

        /// <summary>
        /// Optional. Specifies whether the job is allowed to create new tables. The following values are supported: *
        /// CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table. * CREATE_NEVER: The table must
        /// already exist. If it does not, a 'notFound' error is returned in the job result. The default value is
        /// CREATE_IF_NEEDED. Creation, truncation and append actions occur as one atomic update upon job completion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createDisposition")]
        public virtual string CreateDisposition { get; set; }

        /// <summary>
        /// Optional. If this property is true, the job creates a new session using a randomly generated session_id. To
        /// continue using a created session with subsequent queries, pass the existing session identifier as a
        /// `ConnectionProperty` value. The session identifier is returned as part of the `SessionInfo` message within
        /// the query statistics. The new session's location will be set to `Job.JobReference.location` if it is
        /// present, otherwise it's set to the default location based on existing routing logic.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createSession")]
        public virtual System.Nullable<bool> CreateSession { get; set; }

        /// <summary>Optional. Date format used for parsing DATE values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateFormat")]
        public virtual string DateFormat { get; set; }

        /// <summary>Optional. Date format used for parsing DATETIME values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datetimeFormat")]
        public virtual string DatetimeFormat { get; set; }

        /// <summary>
        /// Defines the list of possible SQL data types to which the source decimal values are converted. This list and
        /// the precision and the scale parameters of the decimal field determine the target type. In the order of
        /// NUMERIC, BIGNUMERIC, and STRING, a type is picked if it is in the specified list and if it supports the
        /// precision and the scale. STRING supports all precision and scale values. If none of the listed types
        /// supports the precision and the scale, the type supporting the widest range in the specified list is picked,
        /// and if a value exceeds the supported range when reading the data, an error will be thrown. Example: Suppose
        /// the value of this field is ["NUMERIC", "BIGNUMERIC"]. If (precision,scale) is: * (38,9) -&amp;gt; NUMERIC; *
        /// (39,9) -&amp;gt; BIGNUMERIC (NUMERIC cannot hold 30 integer digits); * (38,10) -&amp;gt; BIGNUMERIC (NUMERIC
        /// cannot hold 10 fractional digits); * (76,38) -&amp;gt; BIGNUMERIC; * (77,38) -&amp;gt; BIGNUMERIC (error if
        /// value exceeds supported range). This field cannot contain duplicate types. The order of the types in this
        /// field is ignored. For example, ["BIGNUMERIC", "NUMERIC"] is the same as ["NUMERIC", "BIGNUMERIC"] and
        /// NUMERIC always takes precedence over BIGNUMERIC. Defaults to ["NUMERIC", "STRING"] for ORC and ["NUMERIC"]
        /// for the other file formats.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("decimalTargetTypes")]
        public virtual System.Collections.Generic.IList<string> DecimalTargetTypes { get; set; }

        /// <summary>Custom encryption configuration (e.g., Cloud KMS keys)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationEncryptionConfiguration")]
        public virtual EncryptionConfiguration DestinationEncryptionConfiguration { get; set; }

        /// <summary>[Required] The destination table to load the data into.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationTable")]
        public virtual TableReference DestinationTable { get; set; }

        /// <summary>
        /// Optional. [Experimental] Properties with which to create the destination table if it is new.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationTableProperties")]
        public virtual DestinationTableProperties DestinationTableProperties { get; set; }

        /// <summary>
        /// Optional. The character encoding of the data. The supported values are UTF-8, ISO-8859-1, UTF-16BE,
        /// UTF-16LE, UTF-32BE, and UTF-32LE. The default value is UTF-8. BigQuery decodes the data after the raw,
        /// binary data has been split using the values of the `quote` and `fieldDelimiter` properties. If you don't
        /// specify an encoding, or if you specify a UTF-8 encoding when the CSV file is not UTF-8 encoded, BigQuery
        /// attempts to convert the data to UTF-8. Generally, your data loads successfully, but it may not match
        /// byte-for-byte what you expect. To avoid this, specify the correct encoding by using the `--encoding` flag.
        /// If BigQuery can't convert a character other than the ASCII `0` character, BigQuery converts the character to
        /// the standard Unicode replacement character: �.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        /// <summary>
        /// Optional. The separator character for fields in a CSV file. The separator is interpreted as a single byte.
        /// For files encoded in ISO-8859-1, any single character can be used as a separator. For files encoded in
        /// UTF-8, characters represented in decimal range 1-127 (U+0001-U+007F) can be used without any modification.
        /// UTF-8 characters encoded with multiple bytes (i.e. U+0080 and above) will have only the first byte used for
        /// separating fields. The remaining bytes will be treated as a part of the field. BigQuery also supports the
        /// escape sequence "\t" (U+0009) to specify a tab separator. The default value is comma (",", U+002C).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldDelimiter")]
        public virtual string FieldDelimiter { get; set; }

        /// <summary>
        /// Optional. Specifies how source URIs are interpreted for constructing the file set to load. By default,
        /// source URIs are expanded against the underlying storage. You can also specify manifest files to control how
        /// the file set is constructed. This option is only applicable to object storage systems.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileSetSpecType")]
        public virtual string FileSetSpecType { get; set; }

        /// <summary>
        /// Optional. When set, configures hive partitioning support. Not all storage formats support hive partitioning
        /// -- requesting hive partitioning on an unsupported format will lead to an error, as will providing an invalid
        /// specification.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hivePartitioningOptions")]
        public virtual HivePartitioningOptions HivePartitioningOptions { get; set; }

        /// <summary>
        /// Optional. Indicates if BigQuery should allow extra values that are not represented in the table schema. If
        /// true, the extra values are ignored. If false, records with extra columns are treated as bad records, and if
        /// there are too many bad records, an invalid error is returned in the job result. The default value is false.
        /// The sourceFormat property determines what BigQuery treats as an extra value: CSV: Trailing columns JSON:
        /// Named values that don't match any column names in the table schema Avro, Parquet, ORC: Fields in the file
        /// schema that don't exist in the table schema.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreUnknownValues")]
        public virtual System.Nullable<bool> IgnoreUnknownValues { get; set; }

        /// <summary>
        /// Optional. Load option to be used together with source_format newline-delimited JSON to indicate that a
        /// variant of JSON is being loaded. To load newline-delimited GeoJSON, specify GEOJSON (and source_format must
        /// be set to NEWLINE_DELIMITED_JSON).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonExtension")]
        public virtual string JsonExtension { get; set; }

        /// <summary>
        /// Optional. The maximum number of bad records that BigQuery can ignore when running the job. If the number of
        /// bad records exceeds this value, an invalid error is returned in the job result. The default value is 0,
        /// which requires that all records are valid. This is only supported for CSV and NEWLINE_DELIMITED_JSON file
        /// formats.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxBadRecords")]
        public virtual System.Nullable<int> MaxBadRecords { get; set; }

        /// <summary>
        /// Optional. Specifies a string that represents a null value in a CSV file. For example, if you specify "\N",
        /// BigQuery interprets "\N" as a null value when loading a CSV file. The default value is the empty string. If
        /// you set this property to a custom value, BigQuery throws an error if an empty string is present for all data
        /// types except for STRING and BYTE. For STRING and BYTE columns, BigQuery interprets the empty string as an
        /// empty value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullMarker")]
        public virtual string NullMarker { get; set; }

        /// <summary>
        /// Optional. A list of strings represented as SQL NULL value in a CSV file. null_marker and null_markers can't
        /// be set at the same time. If null_marker is set, null_markers has to be not set. If null_markers is set,
        /// null_marker has to be not set. If both null_marker and null_markers are set at the same time, a user error
        /// would be thrown. Any strings listed in null_markers, including empty string would be interpreted as SQL
        /// NULL. This applies to all column types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullMarkers")]
        public virtual System.Collections.Generic.IList<string> NullMarkers { get; set; }

        /// <summary>Optional. Additional properties to set if sourceFormat is set to PARQUET.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parquetOptions")]
        public virtual ParquetOptions ParquetOptions { get; set; }

        /// <summary>
        /// Optional. When sourceFormat is set to "CSV", this indicates whether the embedded ASCII control characters
        /// (the first 32 characters in the ASCII-table, from '\x00' to '\x1F') are preserved.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preserveAsciiControlCharacters")]
        public virtual System.Nullable<bool> PreserveAsciiControlCharacters { get; set; }

        /// <summary>
        /// If sourceFormat is set to "DATASTORE_BACKUP", indicates which entity properties to load into BigQuery from a
        /// Cloud Datastore backup. Property names are case sensitive and must be top-level properties. If no properties
        /// are specified, BigQuery loads all properties. If any named property isn't found in the Cloud Datastore
        /// backup, an invalid error is returned in the job result.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectionFields")]
        public virtual System.Collections.Generic.IList<string> ProjectionFields { get; set; }

        /// <summary>
        /// Optional. The value that is used to quote data sections in a CSV file. BigQuery converts the string to
        /// ISO-8859-1 encoding, and then uses the first byte of the encoded string to split the data in its raw, binary
        /// state. The default value is a double-quote ('"'). If your data does not contain quoted sections, set the
        /// property value to an empty string. If your data contains quoted newline characters, you must also set the
        /// allowQuotedNewlines property to true. To include the specific quote character within a quoted value, precede
        /// it with an additional matching quote character. For example, if you want to escape the default character ' "
        /// ', use ' "" '. @default "
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quote")]
        public virtual string Quote { get; set; }

        /// <summary>
        /// Range partitioning specification for the destination table. Only one of timePartitioning and
        /// rangePartitioning should be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rangePartitioning")]
        public virtual RangePartitioning RangePartitioning { get; set; }

        /// <summary>
        /// Optional. The user can provide a reference file with the reader schema. This file is only loaded if it is
        /// part of source URIs, but is not loaded otherwise. It is enabled for the following formats: AVRO, PARQUET,
        /// ORC.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceFileSchemaUri")]
        public virtual string ReferenceFileSchemaUri { get; set; }

        /// <summary>
        /// Optional. The schema for the destination table. The schema can be omitted if the destination table already
        /// exists, or if you're loading data from Google Cloud Datastore.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual TableSchema Schema { get; set; }

        /// <summary>
        /// [Deprecated] The inline schema. For CSV schemas, specify as "Field1:Type1[,Field2:Type2]*". For example,
        /// "foo:STRING, bar:INTEGER, baz:FLOAT".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaInline")]
        public virtual string SchemaInline { get; set; }

        /// <summary>[Deprecated] The format of the schemaInline property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaInlineFormat")]
        public virtual string SchemaInlineFormat { get; set; }

        /// <summary>
        /// Allows the schema of the destination table to be updated as a side effect of the load job if a schema is
        /// autodetected or supplied in the job configuration. Schema update options are supported in two cases: when
        /// writeDisposition is WRITE_APPEND; when writeDisposition is WRITE_TRUNCATE and the destination table is a
        /// partition of a table, specified by partition decorators. For normal tables, WRITE_TRUNCATE will always
        /// overwrite the schema. One or more of the following values are specified: * ALLOW_FIELD_ADDITION: allow
        /// adding a nullable field to the schema. * ALLOW_FIELD_RELAXATION: allow relaxing a required field in the
        /// original schema to nullable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaUpdateOptions")]
        public virtual System.Collections.Generic.IList<string> SchemaUpdateOptions { get; set; }

        /// <summary>
        /// Optional. The number of rows at the top of a CSV file that BigQuery will skip when loading the data. The
        /// default value is 0. This property is useful if you have header rows in the file that should be skipped. When
        /// autodetect is on, the behavior is the following: * skipLeadingRows unspecified - Autodetect tries to detect
        /// headers in the first row. If they are not detected, the row is read as data. Otherwise data is read starting
        /// from the second row. * skipLeadingRows is 0 - Instructs autodetect that there are no headers and data should
        /// be read starting from the first row. * skipLeadingRows = N &amp;gt; 0 - Autodetect skips N-1 rows and tries
        /// to detect headers in row N. If headers are not detected, row N is just skipped. Otherwise row N is used to
        /// extract column names for the detected schema.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipLeadingRows")]
        public virtual System.Nullable<int> SkipLeadingRows { get; set; }

        /// <summary>
        /// Optional. Controls the strategy used to match loaded columns to the schema. If not set, a sensible default
        /// is chosen based on how the schema is provided. If autodetect is used, then columns are matched by name.
        /// Otherwise, columns are matched by position. This is done to keep the behavior backward-compatible.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceColumnMatch")]
        public virtual string SourceColumnMatch { get; set; }

        /// <summary>
        /// Optional. The format of the data files. For CSV files, specify "CSV". For datastore backups, specify
        /// "DATASTORE_BACKUP". For newline-delimited JSON, specify "NEWLINE_DELIMITED_JSON". For Avro, specify "AVRO".
        /// For parquet, specify "PARQUET". For orc, specify "ORC". The default value is CSV.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceFormat")]
        public virtual string SourceFormat { get; set; }

        /// <summary>
        /// [Required] The fully-qualified URIs that point to your data in Google Cloud. For Google Cloud Storage URIs:
        /// Each URI can contain one '*' wildcard character and it must come after the 'bucket' name. Size limits
        /// related to load jobs apply to external data sources. For Google Cloud Bigtable URIs: Exactly one URI can be
        /// specified and it has be a fully specified and valid HTTPS URL for a Google Cloud Bigtable table. For Google
        /// Cloud Datastore backups: Exactly one URI can be specified. Also, the '*' wildcard character is not allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceUris")]
        public virtual System.Collections.Generic.IList<string> SourceUris { get; set; }

        /// <summary>Optional. Date format used for parsing TIME values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeFormat")]
        public virtual string TimeFormat { get; set; }

        /// <summary>
        /// Time-based partitioning specification for the destination table. Only one of timePartitioning and
        /// rangePartitioning should be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timePartitioning")]
        public virtual TimePartitioning TimePartitioning { get; set; }

        /// <summary>
        /// Optional. Default time zone that will apply when parsing timestamp values that have no specific time zone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>Optional. Date format used for parsing TIMESTAMP values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampFormat")]
        public virtual string TimestampFormat { get; set; }

        /// <summary>
        /// Optional. If sourceFormat is set to "AVRO", indicates whether to interpret logical types as the
        /// corresponding BigQuery data type (for example, TIMESTAMP), instead of using the raw type (for example,
        /// INTEGER).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useAvroLogicalTypes")]
        public virtual System.Nullable<bool> UseAvroLogicalTypes { get; set; }

        /// <summary>
        /// Optional. Specifies the action that occurs if the destination table already exists. The following values are
        /// supported: * WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the data, removes the
        /// constraints and uses the schema from the load job. * WRITE_TRUNCATE_DATA: If the table already exists,
        /// BigQuery overwrites the data, but keeps the constraints and schema of the existing table. * WRITE_APPEND: If
        /// the table already exists, BigQuery appends the data to the table. * WRITE_EMPTY: If the table already exists
        /// and contains data, a 'duplicate' error is returned in the job result. The default value is WRITE_APPEND.
        /// Each action is atomic and only occurs if BigQuery is able to complete the job successfully. Creation,
        /// truncation and append actions occur as one atomic update upon job completion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeDisposition")]
        public virtual string WriteDisposition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JobConfigurationQuery configures a BigQuery query job.</summary>
    public class JobConfigurationQuery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If true and query uses legacy SQL dialect, allows the query to produce arbitrarily large result
        /// tables at a slight cost in performance. Requires destinationTable to be set. For GoogleSQL queries, this
        /// flag is ignored and large results are always allowed. However, you must still set destinationTable when
        /// result size exceeds the allowed maximum response size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowLargeResults")]
        public virtual System.Nullable<bool> AllowLargeResults { get; set; }

        /// <summary>Clustering specification for the destination table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clustering")]
        public virtual Clustering Clustering { get; set; }

        /// <summary>Connection properties which can modify the query behavior.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionProperties")]
        public virtual System.Collections.Generic.IList<ConnectionProperty> ConnectionProperties { get; set; }

        /// <summary>
        /// [Optional] Specifies whether the query should be executed as a continuous query. The default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("continuous")]
        public virtual System.Nullable<bool> Continuous { get; set; }

        /// <summary>
        /// Optional. Specifies whether the job is allowed to create new tables. The following values are supported: *
        /// CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table. * CREATE_NEVER: The table must
        /// already exist. If it does not, a 'notFound' error is returned in the job result. The default value is
        /// CREATE_IF_NEEDED. Creation, truncation and append actions occur as one atomic update upon job completion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createDisposition")]
        public virtual string CreateDisposition { get; set; }

        /// <summary>
        /// If this property is true, the job creates a new session using a randomly generated session_id. To continue
        /// using a created session with subsequent queries, pass the existing session identifier as a
        /// `ConnectionProperty` value. The session identifier is returned as part of the `SessionInfo` message within
        /// the query statistics. The new session's location will be set to `Job.JobReference.location` if it is
        /// present, otherwise it's set to the default location based on existing routing logic.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createSession")]
        public virtual System.Nullable<bool> CreateSession { get; set; }

        /// <summary>
        /// Optional. Specifies the default dataset to use for unqualified table names in the query. This setting does
        /// not alter behavior of unqualified dataset names. Setting the system variable `@@dataset_id` achieves the
        /// same behavior. See https://cloud.google.com/bigquery/docs/reference/system-variables for more information on
        /// system variables.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultDataset")]
        public virtual DatasetReference DefaultDataset { get; set; }

        /// <summary>Custom encryption configuration (e.g., Cloud KMS keys)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationEncryptionConfiguration")]
        public virtual EncryptionConfiguration DestinationEncryptionConfiguration { get; set; }

        /// <summary>
        /// Optional. Describes the table where the query results should be stored. This property must be set for large
        /// results that exceed the maximum response size. For queries that produce anonymous (cached) results, this
        /// field will be populated by BigQuery.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationTable")]
        public virtual TableReference DestinationTable { get; set; }

        /// <summary>
        /// Optional. If true and query uses legacy SQL dialect, flattens all nested and repeated fields in the query
        /// results. allowLargeResults must be true if this is set to false. For GoogleSQL queries, this flag is ignored
        /// and results are never flattened.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flattenResults")]
        public virtual System.Nullable<bool> FlattenResults { get; set; }

        /// <summary>
        /// Optional. [Deprecated] Maximum billing tier allowed for this query. The billing tier controls the amount of
        /// compute resources allotted to the query, and multiplies the on-demand cost of the query accordingly. A query
        /// that runs within its allotted resources will succeed and indicate its billing tier in
        /// statistics.query.billingTier, but if the query exceeds its allotted resources, it will fail with
        /// billingTierLimitExceeded. WARNING: The billed byte amount can be multiplied by an amount up to this number!
        /// Most users should not need to alter this setting, and we recommend that you avoid introducing new uses of
        /// it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumBillingTier")]
        public virtual System.Nullable<int> MaximumBillingTier { get; set; }

        /// <summary>
        /// Limits the bytes billed for this job. Queries that will have bytes billed beyond this limit will fail
        /// (without incurring a charge). If unspecified, this will be set to your project default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumBytesBilled")]
        public virtual System.Nullable<long> MaximumBytesBilled { get; set; }

        /// <summary>
        /// GoogleSQL only. Set to POSITIONAL to use positional (?) query parameters or to NAMED to use named (@myparam)
        /// query parameters in this query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterMode")]
        public virtual string ParameterMode { get; set; }

        /// <summary>[Deprecated] This property is deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preserveNulls")]
        public virtual System.Nullable<bool> PreserveNulls { get; set; }

        /// <summary>
        /// Optional. Specifies a priority for the query. Possible values include INTERACTIVE and BATCH. The default
        /// value is INTERACTIVE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual string Priority { get; set; }

        /// <summary>
        /// [Required] SQL query text to execute. The useLegacySql field can be used to indicate whether the query uses
        /// legacy SQL or GoogleSQL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>Query parameters for GoogleSQL queries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryParameters")]
        public virtual System.Collections.Generic.IList<QueryParameter> QueryParameters { get; set; }

        /// <summary>
        /// Range partitioning specification for the destination table. Only one of timePartitioning and
        /// rangePartitioning should be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rangePartitioning")]
        public virtual RangePartitioning RangePartitioning { get; set; }

        /// <summary>
        /// Allows the schema of the destination table to be updated as a side effect of the query job. Schema update
        /// options are supported in two cases: when writeDisposition is WRITE_APPEND; when writeDisposition is
        /// WRITE_TRUNCATE and the destination table is a partition of a table, specified by partition decorators. For
        /// normal tables, WRITE_TRUNCATE will always overwrite the schema. One or more of the following values are
        /// specified: * ALLOW_FIELD_ADDITION: allow adding a nullable field to the schema. * ALLOW_FIELD_RELAXATION:
        /// allow relaxing a required field in the original schema to nullable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaUpdateOptions")]
        public virtual System.Collections.Generic.IList<string> SchemaUpdateOptions { get; set; }

        /// <summary>Options controlling the execution of scripts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scriptOptions")]
        public virtual ScriptOptions ScriptOptions { get; set; }

        /// <summary>
        /// Output only. System variables for GoogleSQL queries. A system variable is output if the variable is settable
        /// and its value differs from the system default. "@@" prefix is not included in the name of the System
        /// variables.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemVariables")]
        public virtual SystemVariables SystemVariables { get; set; }

        /// <summary>
        /// Optional. You can specify external table definitions, which operate as ephemeral tables that can be queried.
        /// These definitions are configured using a JSON map, where the string key represents the table identifier, and
        /// the value is the corresponding external data configuration object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableDefinitions")]
        public virtual System.Collections.Generic.IDictionary<string, ExternalDataConfiguration> TableDefinitions { get; set; }

        /// <summary>
        /// Time-based partitioning specification for the destination table. Only one of timePartitioning and
        /// rangePartitioning should be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timePartitioning")]
        public virtual TimePartitioning TimePartitioning { get; set; }

        /// <summary>
        /// Optional. Specifies whether to use BigQuery's legacy SQL dialect for this query. The default value is true.
        /// If set to false, the query will use BigQuery's GoogleSQL: https://cloud.google.com/bigquery/sql-reference/
        /// When useLegacySql is set to false, the value of flattenResults is ignored; query will be run as if
        /// flattenResults is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useLegacySql")]
        public virtual System.Nullable<bool> UseLegacySql { get; set; }

        /// <summary>
        /// Optional. Whether to look for the result in the query cache. The query cache is a best-effort cache that
        /// will be flushed whenever tables in the query are modified. Moreover, the query cache is only available when
        /// a query does not have a destination table specified. The default value is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useQueryCache")]
        public virtual System.Nullable<bool> UseQueryCache { get; set; }

        /// <summary>Describes user-defined function resources used in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userDefinedFunctionResources")]
        public virtual System.Collections.Generic.IList<UserDefinedFunctionResource> UserDefinedFunctionResources { get; set; }

        /// <summary>
        /// Optional. Specifies the action that occurs if the destination table already exists. The following values are
        /// supported: * WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the data, removes the
        /// constraints, and uses the schema from the query result. * WRITE_TRUNCATE_DATA: If the table already exists,
        /// BigQuery overwrites the data, but keeps the constraints and schema of the existing table. * WRITE_APPEND: If
        /// the table already exists, BigQuery appends the data to the table. * WRITE_EMPTY: If the table already exists
        /// and contains data, a 'duplicate' error is returned in the job result. The default value is WRITE_EMPTY. Each
        /// action is atomic and only occurs if BigQuery is able to complete the job successfully. Creation, truncation
        /// and append actions occur as one atomic update upon job completion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeDisposition")]
        public virtual string WriteDisposition { get; set; }

        /// <summary>
        /// Optional. This is only supported for a SELECT query using a temporary table. If set, the query is allowed to
        /// write results incrementally to the temporary result table. This may incur a performance penalty. This option
        /// cannot be used with Legacy SQL. This feature is not yet available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeIncrementalResults")]
        public virtual System.Nullable<bool> WriteIncrementalResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// JobConfigurationTableCopy configures a job that copies data from one table to another. For more information on
    /// copying tables, see [Copy a table](https://cloud.google.com/bigquery/docs/managing-tables#copy-table).
    /// </summary>
    public class JobConfigurationTableCopy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specifies whether the job is allowed to create new tables. The following values are supported: *
        /// CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table. * CREATE_NEVER: The table must
        /// already exist. If it does not, a 'notFound' error is returned in the job result. The default value is
        /// CREATE_IF_NEEDED. Creation, truncation and append actions occur as one atomic update upon job completion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createDisposition")]
        public virtual string CreateDisposition { get; set; }

        /// <summary>Custom encryption configuration (e.g., Cloud KMS keys).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationEncryptionConfiguration")]
        public virtual EncryptionConfiguration DestinationEncryptionConfiguration { get; set; }

        private string _destinationExpirationTimeRaw;

        private object _destinationExpirationTime;

        /// <summary>
        /// Optional. The time when the destination table expires. Expired tables will be deleted and their storage
        /// reclaimed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationExpirationTime")]
        public virtual string DestinationExpirationTimeRaw
        {
            get => _destinationExpirationTimeRaw;
            set
            {
                _destinationExpirationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _destinationExpirationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DestinationExpirationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DestinationExpirationTimeDateTimeOffset instead.")]
        public virtual object DestinationExpirationTime
        {
            get => _destinationExpirationTime;
            set
            {
                _destinationExpirationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _destinationExpirationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="DestinationExpirationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DestinationExpirationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DestinationExpirationTimeRaw);
            set => DestinationExpirationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>[Required] The destination table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationTable")]
        public virtual TableReference DestinationTable { get; set; }

        /// <summary>Optional. Supported operation types in table copy job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationType")]
        public virtual string OperationType { get; set; }

        /// <summary>[Pick one] Source table to copy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceTable")]
        public virtual TableReference SourceTable { get; set; }

        /// <summary>[Pick one] Source tables to copy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceTables")]
        public virtual System.Collections.Generic.IList<TableReference> SourceTables { get; set; }

        /// <summary>
        /// Optional. Specifies the action that occurs if the destination table already exists. The following values are
        /// supported: * WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the
        /// schema and table constraints from the source table. * WRITE_APPEND: If the table already exists, BigQuery
        /// appends the data to the table. * WRITE_EMPTY: If the table already exists and contains data, a 'duplicate'
        /// error is returned in the job result. The default value is WRITE_EMPTY. Each action is atomic and only occurs
        /// if BigQuery is able to complete the job successfully. Creation, truncation and append actions occur as one
        /// atomic update upon job completion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeDisposition")]
        public virtual string WriteDisposition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Reason about why a Job was created from a
    /// [`jobs.query`](https://cloud.google.com/bigquery/docs/reference/rest/v2/jobs/query) method when used with
    /// `JOB_CREATION_OPTIONAL` Job creation mode. For
    /// [`jobs.insert`](https://cloud.google.com/bigquery/docs/reference/rest/v2/jobs/insert) method calls it will
    /// always be `REQUESTED`. [Preview](https://cloud.google.com/products/#product-launch-stages)
    /// </summary>
    public class JobCreationReason : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Specifies the high level reason why a Job was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JobList is the response format for a jobs.list call.</summary>
    public class JobList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A hash of this page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>List of jobs that were requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobs")]
        public virtual System.Collections.Generic.IList<JobsData> Jobs { get; set; }

        /// <summary>The resource type of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>A token to request the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// A list of skipped locations that were unreachable. For more information about BigQuery locations, see:
        /// https://cloud.google.com/bigquery/docs/locations. Example: "europe-west5"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>List of jobs that were requested.</summary>
        public class JobsData
        {
            /// <summary>Required. Describes the job configuration.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("configuration")]
            public virtual JobConfiguration Configuration { get; set; }

            /// <summary>A result object that will be present only if the job has failed.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("errorResult")]
            public virtual ErrorProto ErrorResult { get; set; }

            /// <summary>Unique opaque ID of the job.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("id")]
            public virtual string Id { get; set; }

            /// <summary>Unique opaque ID of the job.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("jobReference")]
            public virtual JobReference JobReference { get; set; }

            /// <summary>The resource type.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("kind")]
            public virtual string Kind { get; set; }

            /// <summary>
            /// [Full-projection-only] String representation of identity of requesting party. Populated for both first-
            /// and third-party identities. Only present for APIs that support third-party identities.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("principal_subject")]
            public virtual string PrincipalSubject { get; set; }

            /// <summary>
            /// Running state of the job. When the state is DONE, errorResult can be checked to determine whether the
            /// job succeeded or failed.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("state")]
            public virtual string State { get; set; }

            /// <summary>
            /// Output only. Information about the job, including starting time and ending time of the job.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("statistics")]
            public virtual JobStatistics Statistics { get; set; }

            /// <summary>[Full-projection-only] Describes the status of this job.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("status")]
            public virtual JobStatus Status { get; set; }

            /// <summary>[Full-projection-only] Email address of the user who ran the job.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("user_email")]
            public virtual string UserEmail { get; set; }
        }
    }

    /// <summary>A job reference is a fully qualified identifier for referring to a job.</summary>
    public class JobReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The ID of the job. The ID must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), or
        /// dashes (-). The maximum length is 1,024 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobId")]
        public virtual string JobId { get; set; }

        /// <summary>
        /// Optional. The geographic location of the job. The default value is US. For more information about BigQuery
        /// locations, see: https://cloud.google.com/bigquery/docs/locations
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Required. The ID of the project containing this job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Statistics for a single job execution.</summary>
    public class JobStatistics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. [TrustedTester] Job progress (0.0 -&gt; 1.0) for LOAD and EXTRACT jobs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionRatio")]
        public virtual System.Nullable<double> CompletionRatio { get; set; }

        /// <summary>Output only. Statistics for a copy job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("copy")]
        public virtual JobStatistics5 Copy { get; set; }

        /// <summary>
        /// Output only. Creation time of this job, in milliseconds since the epoch. This field will be present on all
        /// jobs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual System.Nullable<long> CreationTime { get; set; }

        /// <summary>Output only. Statistics for data-masking. Present only for query and extract jobs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataMaskingStatistics")]
        public virtual DataMaskingStatistics DataMaskingStatistics { get; set; }

        /// <summary>
        /// Output only. Name of edition corresponding to the reservation for this job at the time of this update.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("edition")]
        public virtual string Edition { get; set; }

        /// <summary>
        /// Output only. End time of this job, in milliseconds since the epoch. This field will be present whenever a
        /// job is in the DONE state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual System.Nullable<long> EndTime { get; set; }

        /// <summary>Output only. Statistics for an extract job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extract")]
        public virtual JobStatistics4 Extract { get; set; }

        /// <summary>
        /// Output only. The duration in milliseconds of the execution of the final attempt of this job, as BigQuery may
        /// internally re-attempt to execute the job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalExecutionDurationMs")]
        public virtual System.Nullable<long> FinalExecutionDurationMs { get; set; }

        /// <summary>Output only. Statistics for a load job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("load")]
        public virtual JobStatistics3 Load { get; set; }

        /// <summary>Output only. Number of child jobs executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numChildJobs")]
        public virtual System.Nullable<long> NumChildJobs { get; set; }

        /// <summary>Output only. If this is a child job, specifies the job ID of the parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentJobId")]
        public virtual string ParentJobId { get; set; }

        /// <summary>Output only. Statistics for a query job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual JobStatistics2 Query { get; set; }

        /// <summary>Output only. Quotas which delayed this job's start time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaDeferments")]
        public virtual System.Collections.Generic.IList<string> QuotaDeferments { get; set; }

        /// <summary>
        /// Output only. Job resource usage breakdown by reservation. This field reported misleading information and
        /// will no longer be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservationUsage")]
        public virtual System.Collections.Generic.IList<ReservationUsageData> ReservationUsage { get; set; }

        /// <summary>
        /// Output only. Name of the primary reservation assigned to this job. Note that this could be different than
        /// reservations reported in the reservation usage field if parent reservations were used to execute this job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservation_id")]
        public virtual string ReservationId { get; set; }

        /// <summary>Output only. Statistics for row-level security. Present only for query and extract jobs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowLevelSecurityStatistics")]
        public virtual RowLevelSecurityStatistics RowLevelSecurityStatistics { get; set; }

        /// <summary>
        /// Output only. If this a child job of a script, specifies information about the context of this job within the
        /// script.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scriptStatistics")]
        public virtual ScriptStatistics ScriptStatistics { get; set; }

        /// <summary>Output only. Information of the session if this job is part of one.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionInfo")]
        public virtual SessionInfo SessionInfo { get; set; }

        /// <summary>
        /// Output only. Start time of this job, in milliseconds since the epoch. This field will be present when the
        /// job transitions from the PENDING state to either RUNNING or DONE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual System.Nullable<long> StartTime { get; set; }

        /// <summary>Output only. Total bytes processed for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalBytesProcessed")]
        public virtual System.Nullable<long> TotalBytesProcessed { get; set; }

        /// <summary>Output only. Slot-milliseconds for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSlotMs")]
        public virtual System.Nullable<long> TotalSlotMs { get; set; }

        /// <summary>
        /// Output only. [Alpha] Information of the multi-statement transaction if this job is part of one. This
        /// property is only expected on a child job or a job that is in a session. A script parent job is not part of
        /// the transaction started in the script.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionInfo")]
        public virtual TransactionInfo TransactionInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. Job resource usage breakdown by reservation. This field reported misleading information and
        /// will no longer be populated.
        /// </summary>
        public class ReservationUsageData
        {
            /// <summary>
            /// Reservation name or "unreserved" for on-demand resource usage and multi-statement queries.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name { get; set; }

            /// <summary>Total slot milliseconds used by the reservation for a particular job.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("slotMs")]
            public virtual System.Nullable<long> SlotMs { get; set; }
        }
    }

    /// <summary>Statistics for a query job.</summary>
    public class JobStatistics2 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. BI Engine specific Statistics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("biEngineStatistics")]
        public virtual BiEngineStatistics BiEngineStatistics { get; set; }

        /// <summary>
        /// Output only. Billing tier for the job. This is a BigQuery-specific concept which is not related to the
        /// Google Cloud notion of "free tier". The value here is a measure of the query's resource consumption relative
        /// to the amount of data scanned. For on-demand queries, the limit is 100, and all queries within this limit
        /// are billed at the standard on-demand rates. On-demand queries that exceed this limit will fail with a
        /// billingTierLimitExceeded error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingTier")]
        public virtual System.Nullable<int> BillingTier { get; set; }

        /// <summary>Output only. Whether the query result was fetched from the query cache.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheHit")]
        public virtual System.Nullable<bool> CacheHit { get; set; }

        /// <summary>Output only. Referenced dataset for DCL statement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dclTargetDataset")]
        public virtual DatasetReference DclTargetDataset { get; set; }

        /// <summary>Output only. Referenced table for DCL statement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dclTargetTable")]
        public virtual TableReference DclTargetTable { get; set; }

        /// <summary>Output only. Referenced view for DCL statement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dclTargetView")]
        public virtual TableReference DclTargetView { get; set; }

        /// <summary>
        /// Output only. The number of row access policies affected by a DDL statement. Present only for DROP ALL ROW
        /// ACCESS POLICIES queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ddlAffectedRowAccessPolicyCount")]
        public virtual System.Nullable<long> DdlAffectedRowAccessPolicyCount { get; set; }

        /// <summary>Output only. The table after rename. Present only for ALTER TABLE RENAME TO query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ddlDestinationTable")]
        public virtual TableReference DdlDestinationTable { get; set; }

        /// <summary>
        /// Output only. The DDL operation performed, possibly dependent on the pre-existence of the DDL target.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ddlOperationPerformed")]
        public virtual string DdlOperationPerformed { get; set; }

        /// <summary>
        /// Output only. The DDL target dataset. Present only for CREATE/ALTER/DROP SCHEMA(dataset) queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ddlTargetDataset")]
        public virtual DatasetReference DdlTargetDataset { get; set; }

        /// <summary>
        /// Output only. [Beta] The DDL target routine. Present only for CREATE/DROP FUNCTION/PROCEDURE queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ddlTargetRoutine")]
        public virtual RoutineReference DdlTargetRoutine { get; set; }

        /// <summary>
        /// Output only. The DDL target row access policy. Present only for CREATE/DROP ROW ACCESS POLICY queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ddlTargetRowAccessPolicy")]
        public virtual RowAccessPolicyReference DdlTargetRowAccessPolicy { get; set; }

        /// <summary>
        /// Output only. The DDL target table. Present only for CREATE/DROP TABLE/VIEW and DROP ALL ROW ACCESS POLICIES
        /// queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ddlTargetTable")]
        public virtual TableReference DdlTargetTable { get; set; }

        /// <summary>
        /// Output only. Detailed statistics for DML statements INSERT, UPDATE, DELETE, MERGE or TRUNCATE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dmlStats")]
        public virtual DmlStatistics DmlStats { get; set; }

        /// <summary>Output only. The original estimate of bytes processed for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedBytesProcessed")]
        public virtual System.Nullable<long> EstimatedBytesProcessed { get; set; }

        /// <summary>Output only. Stats for EXPORT DATA statement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportDataStatistics")]
        public virtual ExportDataStatistics ExportDataStatistics { get; set; }

        /// <summary>Output only. Job cost breakdown as bigquery internal cost and external service costs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalServiceCosts")]
        public virtual System.Collections.Generic.IList<ExternalServiceCost> ExternalServiceCosts { get; set; }

        /// <summary>Output only. Statistics for a LOAD query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadQueryStatistics")]
        public virtual LoadQueryStatistics LoadQueryStatistics { get; set; }

        /// <summary>Output only. Statistics of materialized views of a query job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("materializedViewStatistics")]
        public virtual MaterializedViewStatistics MaterializedViewStatistics { get; set; }

        /// <summary>Output only. Statistics of metadata cache usage in a query for BigLake tables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadataCacheStatistics")]
        public virtual MetadataCacheStatistics MetadataCacheStatistics { get; set; }

        /// <summary>Output only. Statistics of a BigQuery ML training job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mlStatistics")]
        public virtual MlStatistics MlStatistics { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelTraining")]
        public virtual BigQueryModelTraining ModelTraining { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelTrainingCurrentIteration")]
        public virtual System.Nullable<int> ModelTrainingCurrentIteration { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelTrainingExpectedTotalIteration")]
        public virtual System.Nullable<long> ModelTrainingExpectedTotalIteration { get; set; }

        /// <summary>
        /// Output only. The number of rows affected by a DML statement. Present only for DML statements INSERT, UPDATE
        /// or DELETE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numDmlAffectedRows")]
        public virtual System.Nullable<long> NumDmlAffectedRows { get; set; }

        /// <summary>Output only. Performance insights.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("performanceInsights")]
        public virtual PerformanceInsights PerformanceInsights { get; set; }

        /// <summary>Output only. Query optimization information for a QUERY job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryInfo")]
        public virtual QueryInfo QueryInfo { get; set; }

        /// <summary>Output only. Describes execution plan for the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryPlan")]
        public virtual System.Collections.Generic.IList<ExplainQueryStage> QueryPlan { get; set; }

        /// <summary>Output only. Referenced routines for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referencedRoutines")]
        public virtual System.Collections.Generic.IList<RoutineReference> ReferencedRoutines { get; set; }

        /// <summary>Output only. Referenced tables for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referencedTables")]
        public virtual System.Collections.Generic.IList<TableReference> ReferencedTables { get; set; }

        /// <summary>
        /// Output only. Job resource usage breakdown by reservation. This field reported misleading information and
        /// will no longer be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservationUsage")]
        public virtual System.Collections.Generic.IList<ReservationUsageData> ReservationUsage { get; set; }

        /// <summary>
        /// Output only. The schema of the results. Present only for successful dry run of non-legacy SQL queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual TableSchema Schema { get; set; }

        /// <summary>Output only. Search query specific statistics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchStatistics")]
        public virtual SearchStatistics SearchStatistics { get; set; }

        /// <summary>Output only. Statistics of a Spark procedure job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sparkStatistics")]
        public virtual SparkStatistics SparkStatistics { get; set; }

        /// <summary>
        /// Output only. The type of query statement, if valid. Possible values: * `SELECT`:
        /// [`SELECT`](https://cloud.google.com/bigquery/docs/reference/standard-sql/query-syntax#select_list)
        /// statement. * `ASSERT`:
        /// [`ASSERT`](https://cloud.google.com/bigquery/docs/reference/standard-sql/debugging-statements#assert)
        /// statement. * `INSERT`:
        /// [`INSERT`](https://cloud.google.com/bigquery/docs/reference/standard-sql/dml-syntax#insert_statement)
        /// statement. * `UPDATE`:
        /// [`UPDATE`](https://cloud.google.com/bigquery/docs/reference/standard-sql/dml-syntax#update_statement)
        /// statement. * `DELETE`:
        /// [`DELETE`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-manipulation-language)
        /// statement. * `MERGE`:
        /// [`MERGE`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-manipulation-language)
        /// statement. * `CREATE_TABLE`: [`CREATE
        /// TABLE`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#create_table_statement)
        /// statement, without `AS SELECT`. * `CREATE_TABLE_AS_SELECT`: [`CREATE TABLE AS
        /// SELECT`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#create_table_statement)
        /// statement. * `CREATE_VIEW`: [`CREATE
        /// VIEW`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#create_view_statement)
        /// statement. * `CREATE_MODEL`: [`CREATE
        /// MODEL`](https://cloud.google.com/bigquery-ml/docs/reference/standard-sql/bigqueryml-syntax-create#create_model_statement)
        /// statement. * `CREATE_MATERIALIZED_VIEW`: [`CREATE MATERIALIZED
        /// VIEW`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#create_materialized_view_statement)
        /// statement. * `CREATE_FUNCTION`: [`CREATE
        /// FUNCTION`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#create_function_statement)
        /// statement. * `CREATE_TABLE_FUNCTION`: [`CREATE TABLE
        /// FUNCTION`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#create_table_function_statement)
        /// statement. * `CREATE_PROCEDURE`: [`CREATE
        /// PROCEDURE`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#create_procedure)
        /// statement. * `CREATE_ROW_ACCESS_POLICY`: [`CREATE ROW ACCESS
        /// POLICY`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#create_row_access_policy_statement)
        /// statement. * `CREATE_SCHEMA`: [`CREATE
        /// SCHEMA`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#create_schema_statement)
        /// statement. * `CREATE_SNAPSHOT_TABLE`: [`CREATE SNAPSHOT
        /// TABLE`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#create_snapshot_table_statement)
        /// statement. * `CREATE_SEARCH_INDEX`: [`CREATE SEARCH
        /// INDEX`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#create_search_index_statement)
        /// statement. * `DROP_TABLE`: [`DROP
        /// TABLE`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#drop_table_statement)
        /// statement. * `DROP_EXTERNAL_TABLE`: [`DROP EXTERNAL
        /// TABLE`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#drop_external_table_statement)
        /// statement. * `DROP_VIEW`: [`DROP
        /// VIEW`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#drop_view_statement)
        /// statement. * `DROP_MODEL`: [`DROP
        /// MODEL`](https://cloud.google.com/bigquery-ml/docs/reference/standard-sql/bigqueryml-syntax-drop-model)
        /// statement. * `DROP_MATERIALIZED_VIEW`: [`DROP MATERIALIZED
        /// VIEW`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#drop_materialized_view_statement)
        /// statement. * `DROP_FUNCTION` : [`DROP
        /// FUNCTION`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#drop_function_statement)
        /// statement. * `DROP_TABLE_FUNCTION` : [`DROP TABLE
        /// FUNCTION`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#drop_table_function)
        /// statement. * `DROP_PROCEDURE`: [`DROP
        /// PROCEDURE`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#drop_procedure_statement)
        /// statement. * `DROP_SEARCH_INDEX`: [`DROP SEARCH
        /// INDEX`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#drop_search_index)
        /// statement. * `DROP_SCHEMA`: [`DROP
        /// SCHEMA`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#drop_schema_statement)
        /// statement. * `DROP_SNAPSHOT_TABLE`: [`DROP SNAPSHOT
        /// TABLE`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#drop_snapshot_table_statement)
        /// statement. * `DROP_ROW_ACCESS_POLICY`: [`DROP [ALL] ROW ACCESS
        /// POLICY|POLICIES`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#drop_row_access_policy_statement)
        /// statement. * `ALTER_TABLE`: [`ALTER
        /// TABLE`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#alter_table_set_options_statement)
        /// statement. * `ALTER_VIEW`: [`ALTER
        /// VIEW`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#alter_view_set_options_statement)
        /// statement. * `ALTER_MATERIALIZED_VIEW`: [`ALTER MATERIALIZED
        /// VIEW`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#alter_materialized_view_set_options_statement)
        /// statement. * `ALTER_SCHEMA`: [`ALTER
        /// SCHEMA`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#alter_schema_set_options_statement)
        /// statement. * `SCRIPT`:
        /// [`SCRIPT`](https://cloud.google.com/bigquery/docs/reference/standard-sql/procedural-language). *
        /// `TRUNCATE_TABLE`: [`TRUNCATE
        /// TABLE`](https://cloud.google.com/bigquery/docs/reference/standard-sql/dml-syntax#truncate_table_statement)
        /// statement. * `CREATE_EXTERNAL_TABLE`: [`CREATE EXTERNAL
        /// TABLE`](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#create_external_table_statement)
        /// statement. * `EXPORT_DATA`: [`EXPORT
        /// DATA`](https://cloud.google.com/bigquery/docs/reference/standard-sql/other-statements#export_data_statement)
        /// statement. * `EXPORT_MODEL`: [`EXPORT
        /// MODEL`](https://cloud.google.com/bigquery-ml/docs/reference/standard-sql/bigqueryml-syntax-export-model)
        /// statement. * `LOAD_DATA`: [`LOAD
        /// DATA`](https://cloud.google.com/bigquery/docs/reference/standard-sql/other-statements#load_data_statement)
        /// statement. * `CALL`:
        /// [`CALL`](https://cloud.google.com/bigquery/docs/reference/standard-sql/procedural-language#call) statement.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statementType")]
        public virtual string StatementType { get; set; }

        /// <summary>Output only. Describes a timeline of job execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeline")]
        public virtual System.Collections.Generic.IList<QueryTimelineSample> Timeline { get; set; }

        /// <summary>
        /// Output only. If the project is configured to use on-demand pricing, then this field contains the total bytes
        /// billed for the job. If the project is configured to use flat-rate pricing, then you are not billed for bytes
        /// and this field is informational only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalBytesBilled")]
        public virtual System.Nullable<long> TotalBytesBilled { get; set; }

        /// <summary>Output only. Total bytes processed for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalBytesProcessed")]
        public virtual System.Nullable<long> TotalBytesProcessed { get; set; }

        /// <summary>
        /// Output only. For dry-run jobs, totalBytesProcessed is an estimate and this field specifies the accuracy of
        /// the estimate. Possible values can be: UNKNOWN: accuracy of the estimate is unknown. PRECISE: estimate is
        /// precise. LOWER_BOUND: estimate is lower bound of what the query would cost. UPPER_BOUND: estimate is upper
        /// bound of what the query would cost.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalBytesProcessedAccuracy")]
        public virtual string TotalBytesProcessedAccuracy { get; set; }

        /// <summary>
        /// Output only. Total number of partitions processed from all partitioned tables referenced in the job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalPartitionsProcessed")]
        public virtual System.Nullable<long> TotalPartitionsProcessed { get; set; }

        /// <summary>Output only. Slot-milliseconds for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSlotMs")]
        public virtual System.Nullable<long> TotalSlotMs { get; set; }

        /// <summary>
        /// Output only. Total bytes transferred for cross-cloud queries such as Cross Cloud Transfer and CREATE TABLE
        /// AS SELECT (CTAS).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferredBytes")]
        public virtual System.Nullable<long> TransferredBytes { get; set; }

        /// <summary>
        /// Output only. GoogleSQL only: list of undeclared query parameters detected during a dry run validation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("undeclaredQueryParameters")]
        public virtual System.Collections.Generic.IList<QueryParameter> UndeclaredQueryParameters { get; set; }

        /// <summary>Output only. Vector Search query specific statistics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vectorSearchStatistics")]
        public virtual VectorSearchStatistics VectorSearchStatistics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. Job resource usage breakdown by reservation. This field reported misleading information and
        /// will no longer be populated.
        /// </summary>
        public class ReservationUsageData
        {
            /// <summary>
            /// Reservation name or "unreserved" for on-demand resource usage and multi-statement queries.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name { get; set; }

            /// <summary>Total slot milliseconds used by the reservation for a particular job.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("slotMs")]
            public virtual System.Nullable<long> SlotMs { get; set; }
        }
    }

    /// <summary>Statistics for a load job.</summary>
    public class JobStatistics3 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The number of bad records encountered. Note that if the job has failed because of more bad
        /// records encountered than the maximum allowed in the load job configuration, then this number can be less
        /// than the total number of bad records present in the input data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("badRecords")]
        public virtual System.Nullable<long> BadRecords { get; set; }

        /// <summary>Output only. Number of bytes of source data in a load job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputFileBytes")]
        public virtual System.Nullable<long> InputFileBytes { get; set; }

        /// <summary>Output only. Number of source files in a load job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputFiles")]
        public virtual System.Nullable<long> InputFiles { get; set; }

        /// <summary>
        /// Output only. Size of the loaded data in bytes. Note that while a load job is in the running state, this
        /// value may change.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputBytes")]
        public virtual System.Nullable<long> OutputBytes { get; set; }

        /// <summary>
        /// Output only. Number of rows imported in a load job. Note that while an import job is in the running state,
        /// this value may change.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputRows")]
        public virtual System.Nullable<long> OutputRows { get; set; }

        /// <summary>Output only. Describes a timeline of job execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeline")]
        public virtual System.Collections.Generic.IList<QueryTimelineSample> Timeline { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Statistics for an extract job.</summary>
    public class JobStatistics4 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Number of files per destination URI or URI pattern specified in the extract configuration.
        /// These values will be in the same order as the URIs specified in the 'destinationUris' field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationUriFileCounts")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> DestinationUriFileCounts { get; set; }

        /// <summary>
        /// Output only. Number of user bytes extracted into the result. This is the byte count as computed by BigQuery
        /// for billing purposes and doesn't have any relationship with the number of actual result bytes extracted in
        /// the desired format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputBytes")]
        public virtual System.Nullable<long> InputBytes { get; set; }

        /// <summary>Output only. Describes a timeline of job execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeline")]
        public virtual System.Collections.Generic.IList<QueryTimelineSample> Timeline { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Statistics for a copy job.</summary>
    public class JobStatistics5 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Number of logical bytes copied to the destination table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("copiedLogicalBytes")]
        public virtual System.Nullable<long> CopiedLogicalBytes { get; set; }

        /// <summary>Output only. Number of rows copied to the destination table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("copiedRows")]
        public virtual System.Nullable<long> CopiedRows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class JobStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Final error result of the job. If present, indicates that the job has completed and was
        /// unsuccessful.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorResult")]
        public virtual ErrorProto ErrorResult { get; set; }

        /// <summary>
        /// Output only. The first errors encountered during the running of the job. The final message includes the
        /// number of errors that caused the process to stop. Errors here do not necessarily mean that the job has not
        /// completed or was unsuccessful.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<ErrorProto> Errors { get; set; }

        /// <summary>
        /// Output only. Running state of the job. Valid states include 'PENDING', 'RUNNING', and 'DONE'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents privacy policy associated with "join restrictions". Join restriction gives data providers the ability
    /// to enforce joins on the 'join_allowed_columns' when data is queried from a privacy protected view.
    /// </summary>
    public class JoinRestrictionPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The only columns that joins are allowed on. This field is must be specified for join_conditions
        /// JOIN_ANY and JOIN_ALL and it cannot be set for JOIN_BLOCKED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("joinAllowedColumns")]
        public virtual System.Collections.Generic.IList<string> JoinAllowedColumns { get; set; }

        /// <summary>
        /// Optional. Specifies if a join is required or not on queries for the view. Default is
        /// JOIN_CONDITION_UNSPECIFIED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("joinCondition")]
        public virtual string JoinCondition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Json Options for load and make external tables.</summary>
    public class JsonOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The character encoding of the data. The supported values are UTF-8, UTF-16BE, UTF-16LE, UTF-32BE,
        /// and UTF-32LE. The default value is UTF-8.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about the Linked Dataset.</summary>
    public class LinkedDatasetMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Specifies whether Linked Dataset is currently in a linked state or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkState")]
        public virtual string LinkState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A dataset source type which refers to another BigQuery dataset.</summary>
    public class LinkedDatasetSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The source dataset reference contains project numbers and not project ids.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceDataset")]
        public virtual DatasetReference SourceDataset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response format for a single page when listing BigQuery ML models.</summary>
    public class ListModelsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Models in the requested dataset. Only the following fields are populated: model_reference, model_type,
        /// creation_time, last_modified_time and labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("models")]
        public virtual System.Collections.Generic.IList<Model> Models { get; set; }

        /// <summary>A token to request the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the format of a single result page when listing routines.</summary>
    public class ListRoutinesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token to request the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Routines in the requested dataset. Unless read_mask is set in the request, only the following fields are
        /// populated: etag, project_id, dataset_id, routine_id, routine_type, creation_time, last_modified_time,
        /// language, and remote_function_options.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routines")]
        public virtual System.Collections.Generic.IList<Routine> Routines { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the ListRowAccessPolicies method.</summary>
    public class ListRowAccessPoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token to request the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Row access policies on the requested table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowAccessPolicies")]
        public virtual System.Collections.Generic.IList<RowAccessPolicy> RowAccessPolicies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Statistics for a LOAD query.</summary>
    public class LoadQueryStatistics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The number of bad records encountered while processing a LOAD query. Note that if the job has
        /// failed because of more bad records encountered than the maximum allowed in the load job configuration, then
        /// this number can be less than the total number of bad records present in the input data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("badRecords")]
        public virtual System.Nullable<long> BadRecords { get; set; }

        /// <summary>
        /// Output only. This field is deprecated. The number of bytes of source data copied over the network for a
        /// `LOAD` query. `transferred_bytes` has the canonical value for physical transferred bytes, which is used for
        /// BigQuery Omni billing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bytesTransferred")]
        public virtual System.Nullable<long> BytesTransferred { get; set; }

        /// <summary>Output only. Number of bytes of source data in a LOAD query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputFileBytes")]
        public virtual System.Nullable<long> InputFileBytes { get; set; }

        /// <summary>Output only. Number of source files in a LOAD query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputFiles")]
        public virtual System.Nullable<long> InputFiles { get; set; }

        /// <summary>
        /// Output only. Size of the loaded data in bytes. Note that while a LOAD query is in the running state, this
        /// value may change.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputBytes")]
        public virtual System.Nullable<long> OutputBytes { get; set; }

        /// <summary>
        /// Output only. Number of rows imported in a LOAD query. Note that while a LOAD query is in the running state,
        /// this value may change.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputRows")]
        public virtual System.Nullable<long> OutputRows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// BigQuery-specific metadata about a location. This will be set on google.cloud.location.Location.metadata in
    /// Cloud Location API responses.
    /// </summary>
    public class LocationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The legacy BigQuery location ID, e.g. “EU” for the “europe” location. This is for any API consumers that
        /// need the legacy “US” and “EU” locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("legacyLocationId")]
        public virtual string LegacyLocationId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A materialized view considered for a query job.</summary>
    public class MaterializedView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the materialized view is chosen for the query. A materialized view can be chosen to rewrite multiple
        /// parts of the same query. If a materialized view is chosen to rewrite any part of the query, then this field
        /// is true, even if the materialized view was not chosen to rewrite others parts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chosen")]
        public virtual System.Nullable<bool> Chosen { get; set; }

        /// <summary>
        /// If present, specifies a best-effort estimation of the bytes saved by using the materialized view rather than
        /// its base tables.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedBytesSaved")]
        public virtual System.Nullable<long> EstimatedBytesSaved { get; set; }

        /// <summary>If present, specifies the reason why the materialized view was not chosen for the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rejectedReason")]
        public virtual string RejectedReason { get; set; }

        /// <summary>The candidate materialized view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableReference")]
        public virtual TableReference TableReference { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Definition and configuration of a materialized view.</summary>
    public class MaterializedViewDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. This option declares the intention to construct a materialized view that isn't refreshed
        /// incrementally. Non-incremental materialized views support an expanded range of SQL queries. The
        /// `allow_non_incremental_definition` option can't be changed after the materialized view is created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowNonIncrementalDefinition")]
        public virtual System.Nullable<bool> AllowNonIncrementalDefinition { get; set; }

        /// <summary>
        /// Optional. Enable automatic refresh of the materialized view when the base table is updated. The default
        /// value is "true".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableRefresh")]
        public virtual System.Nullable<bool> EnableRefresh { get; set; }

        /// <summary>
        /// Output only. The time when this materialized view was last refreshed, in milliseconds since the epoch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastRefreshTime")]
        public virtual System.Nullable<long> LastRefreshTime { get; set; }

        /// <summary>
        /// [Optional] Max staleness of data that could be returned when materizlized view is queried (formatted as
        /// Google SQL Interval type).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxStaleness")]
        public virtual string MaxStaleness { get; set; }

        /// <summary>Required. A query whose results are persisted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>
        /// Optional. The maximum frequency at which this materialized view will be refreshed. The default value is
        /// "1800000" (30 minutes).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refreshIntervalMs")]
        public virtual System.Nullable<long> RefreshIntervalMs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Statistics of materialized views considered in a query job.</summary>
    public class MaterializedViewStatistics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Materialized views considered for the query job. Only certain materialized views are used. For a detailed
        /// list, see the child message. If many materialized views are considered, then the list might be incomplete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("materializedView")]
        public virtual System.Collections.Generic.IList<MaterializedView> MaterializedView { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Status of a materialized view. The last refresh timestamp status is omitted here, but is present in the
    /// MaterializedViewDefinition message.
    /// </summary>
    public class MaterializedViewStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Error result of the last automatic refresh. If present, indicates that the last automatic
        /// refresh was unsuccessful.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastRefreshStatus")]
        public virtual ErrorProto LastRefreshStatus { get; set; }

        private string _refreshWatermarkRaw;

        private object _refreshWatermark;

        /// <summary>
        /// Output only. Refresh watermark of materialized view. The base tables' data were collected into the
        /// materialized view cache until this time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refreshWatermark")]
        public virtual string RefreshWatermarkRaw
        {
            get => _refreshWatermarkRaw;
            set
            {
                _refreshWatermark = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _refreshWatermarkRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RefreshWatermarkRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RefreshWatermarkDateTimeOffset instead.")]
        public virtual object RefreshWatermark
        {
            get => _refreshWatermark;
            set
            {
                _refreshWatermarkRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _refreshWatermark = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="RefreshWatermarkRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RefreshWatermarkDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RefreshWatermarkRaw);
            set => RefreshWatermarkRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Statistics for metadata caching in queried tables.</summary>
    public class MetadataCacheStatistics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Set for the Metadata caching eligible tables referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableMetadataCacheUsage")]
        public virtual System.Collections.Generic.IList<TableMetadataCacheUsage> TableMetadataCacheUsage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Job statistics specific to a BigQuery ML training job.</summary>
    public class MlStatistics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Trials of a [hyperparameter tuning
        /// job](https://cloud.google.com/bigquery-ml/docs/reference/standard-sql/bigqueryml-syntax-hp-tuning-overview)
        /// sorted by trial_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hparamTrials")]
        public virtual System.Collections.Generic.IList<HparamTuningTrial> HparamTrials { get; set; }

        /// <summary>
        /// Results for all completed iterations. Empty for [hyperparameter tuning
        /// jobs](https://cloud.google.com/bigquery-ml/docs/reference/standard-sql/bigqueryml-syntax-hp-tuning-overview).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iterationResults")]
        public virtual System.Collections.Generic.IList<IterationResult> IterationResults { get; set; }

        /// <summary>
        /// Output only. Maximum number of iterations specified as max_iterations in the 'CREATE MODEL' query. The
        /// actual number of iterations may be less than this number due to early stop.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxIterations")]
        public virtual System.Nullable<long> MaxIterations { get; set; }

        /// <summary>Output only. The type of the model that is being trained.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelType")]
        public virtual string ModelType { get; set; }

        /// <summary>Output only. Training type of the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingType")]
        public virtual string TrainingType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Model : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The best trial_id across all training runs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bestTrialId")]
        public virtual System.Nullable<long> BestTrialId { get; set; }

        /// <summary>Output only. The time when this model was created, in millisecs since the epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual System.Nullable<long> CreationTime { get; set; }

        /// <summary>
        /// Output only. The default trial_id to use in TVFs when the trial_id is not passed in. For single-objective
        /// [hyperparameter
        /// tuning](https://cloud.google.com/bigquery-ml/docs/reference/standard-sql/bigqueryml-syntax-hp-tuning-overview)
        /// models, this is the best trial ID. For multi-objective [hyperparameter
        /// tuning](https://cloud.google.com/bigquery-ml/docs/reference/standard-sql/bigqueryml-syntax-hp-tuning-overview)
        /// models, this is the smallest trial ID among all Pareto optimal trials.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultTrialId")]
        public virtual System.Nullable<long> DefaultTrialId { get; set; }

        /// <summary>Optional. A user-friendly description of this model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Custom encryption configuration (e.g., Cloud KMS keys). This shows the encryption configuration of the model
        /// data while stored in BigQuery storage. This field can be used with PatchModel to update encryption key for
        /// an already encrypted model.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionConfiguration")]
        public virtual EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>Output only. A hash of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. The time when this model expires, in milliseconds since the epoch. If not present, the model will
        /// persist indefinitely. Expired models will be deleted and their storage reclaimed. The
        /// defaultTableExpirationMs property of the encapsulating dataset can be used to set a default expirationTime
        /// on newly created models.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTime")]
        public virtual System.Nullable<long> ExpirationTime { get; set; }

        /// <summary>
        /// Output only. Input feature columns for the model inference. If the model is trained with TRANSFORM clause,
        /// these are the input of the TRANSFORM clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("featureColumns")]
        public virtual System.Collections.Generic.IList<StandardSqlField> FeatureColumns { get; set; }

        /// <summary>Optional. A descriptive name for this model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("friendlyName")]
        public virtual string FriendlyName { get; set; }

        /// <summary>Output only. All hyperparameter search spaces in this model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hparamSearchSpaces")]
        public virtual HparamSearchSpaces HparamSearchSpaces { get; set; }

        /// <summary>
        /// Output only. Trials of a [hyperparameter
        /// tuning](https://cloud.google.com/bigquery-ml/docs/reference/standard-sql/bigqueryml-syntax-hp-tuning-overview)
        /// model sorted by trial_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hparamTrials")]
        public virtual System.Collections.Generic.IList<HparamTuningTrial> HparamTrials { get; set; }

        /// <summary>
        /// Output only. Label columns that were used to train this model. The output of the model will have a
        /// "predicted_" prefix to these columns.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelColumns")]
        public virtual System.Collections.Generic.IList<StandardSqlField> LabelColumns { get; set; }

        /// <summary>
        /// The labels associated with this model. You can use these to organize and group your models. Label keys and
        /// values can be no longer than 63 characters, can only contain lowercase letters, numeric characters,
        /// underscores and dashes. International characters are allowed. Label values are optional. Label keys must
        /// start with a letter and each label in the list must have a different key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. The time when this model was last modified, in millisecs since the epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifiedTime")]
        public virtual System.Nullable<long> LastModifiedTime { get; set; }

        /// <summary>
        /// Output only. The geographic location where the model resides. This value is inherited from the dataset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Required. Unique identifier for this model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelReference")]
        public virtual ModelReference ModelReference { get; set; }

        /// <summary>Output only. Type of the model resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelType")]
        public virtual string ModelType { get; set; }

        /// <summary>
        /// Output only. For single-objective [hyperparameter
        /// tuning](https://cloud.google.com/bigquery-ml/docs/reference/standard-sql/bigqueryml-syntax-hp-tuning-overview)
        /// models, it only contains the best trial. For multi-objective [hyperparameter
        /// tuning](https://cloud.google.com/bigquery-ml/docs/reference/standard-sql/bigqueryml-syntax-hp-tuning-overview)
        /// models, it contains all Pareto optimal trials sorted by trial_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optimalTrialIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> OptimalTrialIds { get; set; }

        /// <summary>Output only. Remote model info</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remoteModelInfo")]
        public virtual RemoteModelInfo RemoteModelInfo { get; set; }

        /// <summary>Information for all training runs in increasing order of start_time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingRuns")]
        public virtual System.Collections.Generic.IList<TrainingRun> TrainingRuns { get; set; }

        /// <summary>
        /// Output only. This field will be populated if a TRANSFORM clause was used to train a model. TRANSFORM clause
        /// (if used) takes feature_columns as input and outputs transform_columns. transform_columns then are used to
        /// train the model.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transformColumns")]
        public virtual System.Collections.Generic.IList<TransformColumn> TransformColumns { get; set; }
    }

    public class ModelDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelOptions")]
        public virtual ModelOptionsData ModelOptions { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingRuns")]
        public virtual System.Collections.Generic.IList<BqmlTrainingRun> TrainingRuns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>Deprecated.</summary>
        public class ModelOptionsData
        {
            [Newtonsoft.Json.JsonPropertyAttribute("labels")]
            public virtual System.Collections.Generic.IList<string> Labels { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("lossType")]
            public virtual string LossType { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("modelType")]
            public virtual string ModelType { get; set; }
        }
    }

    /// <summary>Options related to model extraction.</summary>
    public class ModelExtractOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The 1-based ID of the trial to be exported from a hyperparameter tuning model. If not specified, the trial
        /// with id =
        /// [Model](https://cloud.google.com/bigquery/docs/reference/rest/v2/models#resource:-model).defaultTrialId is
        /// exported. This field is ignored for models not trained with hyperparameter tuning.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trialId")]
        public virtual System.Nullable<long> TrialId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Id path of a model.</summary>
    public class ModelReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The ID of the dataset containing this model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetId")]
        public virtual string DatasetId { get; set; }

        /// <summary>
        /// Required. The ID of the model. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores
        /// (_). The maximum length is 1,024 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelId")]
        public virtual string ModelId { get; set; }

        /// <summary>Required. The ID of the project containing this model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evaluation metrics for multi-class classification/classifier models.</summary>
    public class MultiClassClassificationMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Aggregate classification metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregateClassificationMetrics")]
        public virtual AggregateClassificationMetrics AggregateClassificationMetrics { get; set; }

        /// <summary>Confusion matrix at different thresholds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confusionMatrixList")]
        public virtual System.Collections.Generic.IList<ConfusionMatrix> ConfusionMatrixList { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parquet Options for load and make external tables.</summary>
    public class ParquetOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Indicates whether to use schema inference specifically for Parquet LIST logical type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableListInference")]
        public virtual System.Nullable<bool> EnableListInference { get; set; }

        /// <summary>
        /// Optional. Indicates whether to infer Parquet ENUM logical type as STRING instead of BYTES by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enumAsString")]
        public virtual System.Nullable<bool> EnumAsString { get; set; }

        /// <summary>Optional. Indicates how to represent a Parquet map if present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mapTargetType")]
        public virtual string MapTargetType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Partition skew detailed information.</summary>
    public class PartitionSkew : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Source stages which produce skewed data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skewSources")]
        public virtual System.Collections.Generic.IList<SkewSource> SkewSources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The partitioning column information.</summary>
    public class PartitionedColumn : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the partition column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The partitioning information, which includes managed table, external table and metastore partitioned table
    /// partition information.
    /// </summary>
    public class PartitioningDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Details about each partitioning column. This field is output only for all partitioning types other
        /// than metastore partitioned tables. BigQuery native tables only support 1 partitioning column. Other table
        /// types may support 0, 1 or more partitioning columns. For metastore partitioned tables, the order must match
        /// the definition order in the Hive Metastore, where it must match the physical layout of the table. For
        /// example, CREATE TABLE a_table(id BIGINT, name STRING) PARTITIONED BY (city STRING, state STRING). In this
        /// case the values must be ['city', 'state'] in that order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionedColumn")]
        public virtual System.Collections.Generic.IList<PartitionedColumn> PartitionedColumn { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Performance insights for the job.</summary>
    public class PerformanceInsights : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Average execution ms of previous runs. Indicates the job ran slow compared to previous
        /// executions. To find previous executions, use INFORMATION_SCHEMA tables and filter jobs with same query hash.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avgPreviousExecutionMs")]
        public virtual System.Nullable<long> AvgPreviousExecutionMs { get; set; }

        /// <summary>
        /// Output only. Query stage performance insights compared to previous runs, for diagnosing performance
        /// regression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stagePerformanceChangeInsights")]
        public virtual System.Collections.Generic.IList<StagePerformanceChangeInsight> StagePerformanceChangeInsights { get; set; }

        /// <summary>
        /// Output only. Standalone query stage performance insights, for exploring potential improvements.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stagePerformanceStandaloneInsights")]
        public virtual System.Collections.Generic.IList<StagePerformanceStandaloneInsight> StagePerformanceStandaloneInsights { get; set; }

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

    /// <summary>
    /// Principal component infos, used only for eigen decomposition based models, e.g., PCA. Ordered by
    /// explained_variance in the descending order.
    /// </summary>
    public class PrincipalComponentInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The explained_variance is pre-ordered in the descending order to compute the cumulative explained variance
        /// ratio.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cumulativeExplainedVarianceRatio")]
        public virtual System.Nullable<double> CumulativeExplainedVarianceRatio { get; set; }

        /// <summary>Explained variance by this principal component, which is simply the eigenvalue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explainedVariance")]
        public virtual System.Nullable<double> ExplainedVariance { get; set; }

        /// <summary>Explained_variance over the total explained variance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explainedVarianceRatio")]
        public virtual System.Nullable<double> ExplainedVarianceRatio { get; set; }

        /// <summary>Id of the principal component.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalComponentId")]
        public virtual System.Nullable<long> PrincipalComponentId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents privacy policy that contains the privacy requirements specified by the data owner. Currently, this is
    /// only supported on views.
    /// </summary>
    public class PrivacyPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Policy used for aggregation thresholds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregationThresholdPolicy")]
        public virtual AggregationThresholdPolicy AggregationThresholdPolicy { get; set; }

        /// <summary>Optional. Policy used for differential privacy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("differentialPrivacyPolicy")]
        public virtual DifferentialPrivacyPolicy DifferentialPrivacyPolicy { get; set; }

        /// <summary>
        /// Optional. Join restriction policy is outside of the one of policies, since this policy can be set along with
        /// other policies. This policy gives data providers the ability to enforce joins on the 'join_allowed_columns'
        /// when data is queried from a privacy protected view.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("joinRestrictionPolicy")]
        public virtual JoinRestrictionPolicy JoinRestrictionPolicy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response object of ListProjects</summary>
    public class ProjectList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A hash of the page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The resource type of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Use this token to request the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Projects to which the user has at least READ access.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projects")]
        public virtual System.Collections.Generic.IList<ProjectsData> Projects { get; set; }

        /// <summary>
        /// The total number of projects in the page. A wrapper is used here because the field should still be in the
        /// response when the value is 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalItems")]
        public virtual System.Nullable<int> TotalItems { get; set; }

        /// <summary>Projects to which the user has at least READ access.</summary>
        public class ProjectsData
        {
            /// <summary>
            /// A descriptive name for this project. A wrapper is used here because friendlyName can be set to the empty
            /// string.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("friendlyName")]
            public virtual string FriendlyName { get; set; }

            /// <summary>An opaque ID of this project.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("id")]
            public virtual string Id { get; set; }

            /// <summary>The resource type.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("kind")]
            public virtual string Kind { get; set; }

            /// <summary>The numeric ID of this project.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("numericId")]
            public virtual System.Nullable<ulong> NumericId { get; set; }

            /// <summary>A unique reference to this project.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("projectReference")]
            public virtual ProjectReference ProjectReference { get; set; }
        }
    }

    /// <summary>A unique reference to a project.</summary>
    public class ProjectReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. ID of the project. Can be either the numeric ID or the assigned ID of the project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Query optimization information for a QUERY job.</summary>
    public class QueryInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Information about query optimizations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optimizationDetails")]
        public virtual System.Collections.Generic.IDictionary<string, object> OptimizationDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A parameter given to a query.</summary>
    public class QueryParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If unset, this is a positional parameter. Otherwise, should be unique within a query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The type of this parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterType")]
        public virtual QueryParameterType ParameterType { get; set; }

        /// <summary>Required. The value of this parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterValue")]
        public virtual QueryParameterValue ParameterValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The type of a query parameter.</summary>
    public class QueryParameterType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The type of the array's elements, if this is an array.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arrayType")]
        public virtual QueryParameterType ArrayType { get; set; }

        /// <summary>Optional. The element type of the range, if this is a range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rangeElementType")]
        public virtual QueryParameterType RangeElementType { get; set; }

        /// <summary>Optional. The types of the fields of this struct, in order, if this is a struct.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structTypes")]
        public virtual System.Collections.Generic.IList<StructTypesData> StructTypes { get; set; }

        /// <summary>Required. The top level type of this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>Optional. The types of the fields of this struct, in order, if this is a struct.</summary>
        public class StructTypesData
        {
            /// <summary>Optional. Human-oriented description of the field.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("description")]
            public virtual string Description { get; set; }

            /// <summary>Optional. The name of this field.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name { get; set; }

            /// <summary>Required. The type of this field.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual QueryParameterType Type { get; set; }
        }
    }

    /// <summary>The value of a query parameter.</summary>
    public class QueryParameterValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The array values, if this is an array type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arrayValues")]
        public virtual System.Collections.Generic.IList<QueryParameterValue> ArrayValues { get; set; }

        /// <summary>Optional. The range value, if this is a range type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rangeValue")]
        public virtual RangeValue RangeValue { get; set; }

        /// <summary>The struct field values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structValues")]
        public virtual System.Collections.Generic.IDictionary<string, QueryParameterValue> StructValues { get; set; }

        /// <summary>Optional. The value of this value, if a simple scalar type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the format of the jobs.query request.</summary>
    public class QueryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Connection properties which can modify the query behavior.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionProperties")]
        public virtual System.Collections.Generic.IList<ConnectionProperty> ConnectionProperties { get; set; }

        /// <summary>
        /// [Optional] Specifies whether the query should be executed as a continuous query. The default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("continuous")]
        public virtual System.Nullable<bool> Continuous { get; set; }

        /// <summary>
        /// Optional. If true, creates a new session using a randomly generated session_id. If false, runs query with an
        /// existing session_id passed in ConnectionProperty, otherwise runs query in non-session mode. The session
        /// location will be set to QueryRequest.location if it is present, otherwise it's set to the default location
        /// based on existing routing logic.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createSession")]
        public virtual System.Nullable<bool> CreateSession { get; set; }

        /// <summary>
        /// Optional. Specifies the default datasetId and projectId to assume for any unqualified table names in the
        /// query. If not set, all table names in the query string must be qualified in the format 'datasetId.tableId'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultDataset")]
        public virtual DatasetReference DefaultDataset { get; set; }

        /// <summary>Optional. Custom encryption configuration (e.g., Cloud KMS keys)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationEncryptionConfiguration")]
        public virtual EncryptionConfiguration DestinationEncryptionConfiguration { get; set; }

        /// <summary>
        /// Optional. If set to true, BigQuery doesn't run the job. Instead, if the query is valid, BigQuery returns
        /// statistics about the job such as how many bytes would be processed. If the query is invalid, an error
        /// returns. The default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dryRun")]
        public virtual System.Nullable<bool> DryRun { get; set; }

        /// <summary>Optional. Output format adjustments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formatOptions")]
        public virtual DataFormatOptions FormatOptions { get; set; }

        /// <summary>
        /// Optional. If not set, jobs are always required. If set, the query request will follow the behavior described
        /// JobCreationMode. [Preview](https://cloud.google.com/products/#product-launch-stages)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobCreationMode")]
        public virtual string JobCreationMode { get; set; }

        /// <summary>
        /// Optional. Job timeout in milliseconds. If this time limit is exceeded, BigQuery will attempt to stop a
        /// longer job, but may not always succeed in canceling it before the job completes. For example, a job that
        /// takes more than 60 seconds to complete has a better chance of being stopped than a job that takes 10 seconds
        /// to complete. This timeout applies to the query even if a job does not need to be created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobTimeoutMs")]
        public virtual System.Nullable<long> JobTimeoutMs { get; set; }

        /// <summary>The resource type of the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Optional. The labels associated with this query. Labels can be used to organize and group query jobs. Label
        /// keys and values can be no longer than 63 characters, can only contain lowercase letters, numeric characters,
        /// underscores and dashes. International characters are allowed. Label keys must start with a letter and each
        /// label in the list must have a different key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The geographic location where the job should run. For more information, see how to [specify
        /// locations](https://cloud.google.com/bigquery/docs/locations#specify_locations).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// Optional. The maximum number of rows of data to return per page of results. Setting this flag to a small
        /// value such as 1000 and then paging through results might improve reliability when the query result set is
        /// large. In addition to this limit, responses are also limited to 10 MB. By default, there is no maximum row
        /// count, and only the byte limit applies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxResults")]
        public virtual System.Nullable<long> MaxResults { get; set; }

        /// <summary>
        /// Optional. Limits the bytes billed for this query. Queries with bytes billed above this limit will fail
        /// (without incurring a charge). If unspecified, the project default is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumBytesBilled")]
        public virtual System.Nullable<long> MaximumBytesBilled { get; set; }

        /// <summary>
        /// GoogleSQL only. Set to POSITIONAL to use positional (?) query parameters or to NAMED to use named (@myparam)
        /// query parameters in this query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterMode")]
        public virtual string ParameterMode { get; set; }

        /// <summary>This property is deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preserveNulls")]
        public virtual System.Nullable<bool> PreserveNulls { get; set; }

        /// <summary>
        /// Required. A query string to execute, using Google Standard SQL or legacy SQL syntax. Example: "SELECT
        /// COUNT(f1) FROM myProjectId.myDatasetId.myTableId".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>Query parameters for GoogleSQL queries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryParameters")]
        public virtual System.Collections.Generic.IList<QueryParameter> QueryParameters { get; set; }

        /// <summary>
        /// Optional. A unique user provided identifier to ensure idempotent behavior for queries. Note that this is
        /// different from the job_id. It has the following properties: 1. It is case-sensitive, limited to up to 36
        /// ASCII characters. A UUID is recommended. 2. Read only queries can ignore this token since they are
        /// nullipotent by definition. 3. For the purposes of idempotency ensured by the request_id, a request is
        /// considered duplicate of another only if they have the same request_id and are actually duplicates. When
        /// determining whether a request is a duplicate of another request, all parameters in the request that may
        /// affect the result are considered. For example, query, connection_properties, query_parameters,
        /// use_legacy_sql are parameters that affect the result and are considered when determining whether a request
        /// is a duplicate, but properties like timeout_ms don't affect the result and are thus not considered. Dry run
        /// query requests are never considered duplicate of another request. 4. When a duplicate mutating query request
        /// is detected, it returns: a. the results of the mutation if it completes successfully within the timeout. b.
        /// the running operation if it is still in progress at the end of the timeout. 5. Its lifetime is limited to 15
        /// minutes. In other words, if two requests are sent with the same request_id, but more than 15 minutes apart,
        /// idempotency is not guaranteed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>
        /// Optional. The reservation that jobs.query request would use. User can specify a reservation to execute the
        /// job.query. The expected format is `projects/{project}/locations/{location}/reservations/{reservation}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservation")]
        public virtual string Reservation { get; set; }

        /// <summary>
        /// Optional. Optional: Specifies the maximum amount of time, in milliseconds, that the client is willing to
        /// wait for the query to complete. By default, this limit is 10 seconds (10,000 milliseconds). If the query is
        /// complete, the jobComplete field in the response is true. If the query has not yet completed, jobComplete is
        /// false. You can request a longer timeout period in the timeoutMs field. However, the call is not guaranteed
        /// to wait for the specified timeout; it typically returns after around 200 seconds (200,000 milliseconds),
        /// even if the query is not complete. If jobComplete is false, you can continue to wait for the query to
        /// complete by calling the getQueryResults method until the jobComplete field in the getQueryResults response
        /// is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeoutMs")]
        public virtual System.Nullable<long> TimeoutMs { get; set; }

        /// <summary>
        /// Specifies whether to use BigQuery's legacy SQL dialect for this query. The default value is true. If set to
        /// false, the query will use BigQuery's GoogleSQL: https://cloud.google.com/bigquery/sql-reference/ When
        /// useLegacySql is set to false, the value of flattenResults is ignored; query will be run as if flattenResults
        /// is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useLegacySql")]
        public virtual System.Nullable<bool> UseLegacySql { get; set; }

        /// <summary>
        /// Optional. Whether to look for the result in the query cache. The query cache is a best-effort cache that
        /// will be flushed whenever tables in the query are modified. The default value is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useQueryCache")]
        public virtual System.Nullable<bool> UseQueryCache { get; set; }

        /// <summary>
        /// Optional. This is only supported for SELECT query. If set, the query is allowed to write results
        /// incrementally to the temporary result table. This may incur a performance penalty. This option cannot be
        /// used with Legacy SQL. This feature is not yet available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeIncrementalResults")]
        public virtual System.Nullable<bool> WriteIncrementalResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class QueryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the query result was fetched from the query cache.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheHit")]
        public virtual System.Nullable<bool> CacheHit { get; set; }

        /// <summary>
        /// Output only. Creation time of this query, in milliseconds since the epoch. This field will be present on all
        /// queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual System.Nullable<long> CreationTime { get; set; }

        /// <summary>
        /// Output only. Detailed statistics for DML statements INSERT, UPDATE, DELETE, MERGE or TRUNCATE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dmlStats")]
        public virtual DmlStatistics DmlStats { get; set; }

        /// <summary>
        /// Output only. End time of this query, in milliseconds since the epoch. This field will be present whenever a
        /// query job is in the DONE state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual System.Nullable<long> EndTime { get; set; }

        /// <summary>
        /// Output only. The first errors or warnings encountered during the running of the job. The final message
        /// includes the number of errors that caused the process to stop. Errors here do not necessarily mean that the
        /// job has completed or was unsuccessful. For more information about error messages, see [Error
        /// messages](https://cloud.google.com/bigquery/docs/error-messages).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<ErrorProto> Errors { get; set; }

        /// <summary>
        /// Whether the query has completed or not. If rows or totalRows are present, this will always be true. If this
        /// is false, totalRows will not be available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobComplete")]
        public virtual System.Nullable<bool> JobComplete { get; set; }

        /// <summary>
        /// Optional. The reason why a Job was created. Only relevant when a job_reference is present in the response.
        /// If job_reference is not present it will always be unset.
        /// [Preview](https://cloud.google.com/products/#product-launch-stages)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobCreationReason")]
        public virtual JobCreationReason JobCreationReason { get; set; }

        /// <summary>
        /// Reference to the Job that was created to run the query. This field will be present even if the original
        /// request timed out, in which case GetQueryResults can be used to read the results once the query has
        /// completed. Since this API only returns the first page of results, subsequent pages can be fetched via the
        /// same mechanism (GetQueryResults). If job_creation_mode was set to `JOB_CREATION_OPTIONAL` and the query
        /// completes without creating a job, this field will be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobReference")]
        public virtual JobReference JobReference { get; set; }

        /// <summary>The resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Output only. The geographic location of the query. For more information about BigQuery locations, see:
        /// https://cloud.google.com/bigquery/docs/locations
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// Output only. The number of rows affected by a DML statement. Present only for DML statements INSERT, UPDATE
        /// or DELETE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numDmlAffectedRows")]
        public virtual System.Nullable<long> NumDmlAffectedRows { get; set; }

        /// <summary>
        /// A token used for paging results. A non-empty token indicates that additional results are available. To see
        /// additional results, query the
        /// [`jobs.getQueryResults`](https://cloud.google.com/bigquery/docs/reference/rest/v2/jobs/getQueryResults)
        /// method. For more information, see [Paging through table
        /// data](https://cloud.google.com/bigquery/docs/paging-results).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Auto-generated ID for the query. [Preview](https://cloud.google.com/products/#product-launch-stages)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryId")]
        public virtual string QueryId { get; set; }

        /// <summary>
        /// An object with as many results as can be contained within the maximum permitted reply size. To get any
        /// additional rows, you can call GetQueryResults and specify the jobReference returned above.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<TableRow> Rows { get; set; }

        /// <summary>The schema of the results. Present only when the query completes successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual TableSchema Schema { get; set; }

        /// <summary>Output only. Information of the session if this job is part of one.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionInfo")]
        public virtual SessionInfo SessionInfo { get; set; }

        /// <summary>
        /// Output only. Start time of this query, in milliseconds since the epoch. This field will be present when the
        /// query job transitions from the PENDING state to either RUNNING or DONE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual System.Nullable<long> StartTime { get; set; }

        /// <summary>
        /// Output only. If the project is configured to use on-demand pricing, then this field contains the total bytes
        /// billed for the job. If the project is configured to use flat-rate pricing, then you are not billed for bytes
        /// and this field is informational only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalBytesBilled")]
        public virtual System.Nullable<long> TotalBytesBilled { get; set; }

        /// <summary>
        /// The total number of bytes processed for this query. If this query was a dry run, this is the number of bytes
        /// that would be processed if the query were run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalBytesProcessed")]
        public virtual System.Nullable<long> TotalBytesProcessed { get; set; }

        /// <summary>
        /// The total number of rows in the complete query result set, which can be more than the number of rows in this
        /// single page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalRows")]
        public virtual System.Nullable<ulong> TotalRows { get; set; }

        /// <summary>Output only. Number of slot ms the user is actually billed for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSlotMs")]
        public virtual System.Nullable<long> TotalSlotMs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Summary of the state of query execution at a given time.</summary>
    public class QueryTimelineSample : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Total number of active workers. This does not correspond directly to slot usage. This is the largest value
        /// observed since the last sample.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeUnits")]
        public virtual System.Nullable<long> ActiveUnits { get; set; }

        /// <summary>Total parallel units of work completed by this query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completedUnits")]
        public virtual System.Nullable<long> CompletedUnits { get; set; }

        /// <summary>Milliseconds elapsed since the start of query execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elapsedMs")]
        public virtual System.Nullable<long> ElapsedMs { get; set; }

        /// <summary>
        /// Units of work that can be scheduled immediately. Providing additional slots for these units of work will
        /// accelerate the query, if no other query in the reservation needs additional slots.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedRunnableUnits")]
        public virtual System.Nullable<long> EstimatedRunnableUnits { get; set; }

        /// <summary>
        /// Total units of work remaining for the query. This number can be revised (increased or decreased) while the
        /// query is running.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingUnits")]
        public virtual System.Nullable<long> PendingUnits { get; set; }

        /// <summary>
        /// Total shuffle usage ratio in shuffle RAM per reservation of this query. This will be provided for
        /// reservation customers only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shuffleRamUsageRatio")]
        public virtual System.Nullable<double> ShuffleRamUsageRatio { get; set; }

        /// <summary>Cumulative slot-ms consumed by the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSlotMs")]
        public virtual System.Nullable<long> TotalSlotMs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RangePartitioning : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of the column to partition the table on. It must be a top-level, INT64 column whose mode
        /// is NULLABLE or REQUIRED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        /// <summary>[Experimental] Defines the ranges for range partitioning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual RangeData Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>[Experimental] Defines the ranges for range partitioning.</summary>
        public class RangeData
        {
            /// <summary>[Experimental] The end of range partitioning, exclusive.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("end")]
            public virtual System.Nullable<long> End { get; set; }

            /// <summary>[Experimental] The width of each interval.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("interval")]
            public virtual System.Nullable<long> Interval { get; set; }

            /// <summary>[Experimental] The start of range partitioning, inclusive.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("start")]
            public virtual System.Nullable<long> Start { get; set; }
        }
    }

    /// <summary>Represents the value of a range.</summary>
    public class RangeValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The end value of the range. A missing value represents an unbounded end.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("end")]
        public virtual QueryParameterValue End { get; set; }

        /// <summary>Optional. The start value of the range. A missing value represents an unbounded start.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("start")]
        public virtual QueryParameterValue Start { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evaluation metrics used by weighted-ALS models specified by feedback_type=implicit.</summary>
    public class RankingMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Determines the goodness of a ranking by computing the percentile rank from the predicted confidence and
        /// dividing it by the original rank.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageRank")]
        public virtual System.Nullable<double> AverageRank { get; set; }

        /// <summary>
        /// Calculates a precision per user for all the items by ranking them and then averages all the precisions
        /// across all the users.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meanAveragePrecision")]
        public virtual System.Nullable<double> MeanAveragePrecision { get; set; }

        /// <summary>
        /// Similar to the mean squared error computed in regression and explicit recommendation models except instead
        /// of computing the rating directly, the output from evaluate is computed against a preference which is 1 or 0
        /// depending on if the rating exists or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meanSquaredError")]
        public virtual System.Nullable<double> MeanSquaredError { get; set; }

        /// <summary>
        /// A metric to determine the goodness of a ranking calculated from the predicted confidence by comparing it to
        /// an ideal rank measured by the original ratings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedDiscountedCumulativeGain")]
        public virtual System.Nullable<double> NormalizedDiscountedCumulativeGain { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evaluation metrics for regression and explicit feedback type matrix factorization models.</summary>
    public class RegressionMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Mean absolute error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meanAbsoluteError")]
        public virtual System.Nullable<double> MeanAbsoluteError { get; set; }

        /// <summary>Mean squared error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meanSquaredError")]
        public virtual System.Nullable<double> MeanSquaredError { get; set; }

        /// <summary>Mean squared log error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meanSquaredLogError")]
        public virtual System.Nullable<double> MeanSquaredLogError { get; set; }

        /// <summary>Median absolute error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("medianAbsoluteError")]
        public virtual System.Nullable<double> MedianAbsoluteError { get; set; }

        /// <summary>R^2 score. This corresponds to r2_score in ML.EVALUATE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rSquared")]
        public virtual System.Nullable<double> RSquared { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for a remote user-defined function.</summary>
    public class RemoteFunctionOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Fully qualified name of the user-provided connection object which holds the authentication information to
        /// send requests to the remote service. Format:
        /// ```
        /// "projects/{projectId}/locations/{locationId}/connections/{connectionId}"
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connection")]
        public virtual string Connection { get; set; }

        /// <summary>
        /// Endpoint of the user-provided remote service, e.g.
        /// ```
        /// https://us-east1-my_gcf_project.cloudfunctions.net/remote_add
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual string Endpoint { get; set; }

        /// <summary>
        /// Max number of rows in each batch sent to the remote service. If absent or if 0, BigQuery dynamically decides
        /// the number of rows in a batch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxBatchingRows")]
        public virtual System.Nullable<long> MaxBatchingRows { get; set; }

        /// <summary>
        /// User-defined context as a set of key/value pairs, which will be sent as function invocation context together
        /// with batched arguments in the requests to the remote service. The total number of bytes of keys and values
        /// must be less than 8KB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userDefinedContext")]
        public virtual System.Collections.Generic.IDictionary<string, string> UserDefinedContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Remote Model Info</summary>
    public class RemoteModelInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Fully qualified name of the user-provided connection object of the remote model. Format:
        /// ```
        /// "projects/{project_id}/locations/{location_id}/connections/{connection_id}"
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connection")]
        public virtual string Connection { get; set; }

        /// <summary>Output only. The endpoint for remote model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual string Endpoint { get; set; }

        /// <summary>
        /// Output only. Max number of rows in each batch sent to the remote service. If unset, the number of rows in
        /// each batch is set dynamically.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxBatchingRows")]
        public virtual System.Nullable<long> MaxBatchingRows { get; set; }

        /// <summary>Output only. The model version for LLM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remoteModelVersion")]
        public virtual string RemoteModelVersion { get; set; }

        /// <summary>Output only. The remote service type for remote model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remoteServiceType")]
        public virtual string RemoteServiceType { get; set; }

        /// <summary>
        /// Output only. The name of the speech recognizer to use for speech recognition. The expected format is
        /// `projects/{project}/locations/{location}/recognizers/{recognizer}`. Customers can specify this field at
        /// model creation. If not specified, a default recognizer `projects/{model
        /// project}/locations/global/recognizers/_` will be used. See more details at
        /// [recognizers](https://cloud.google.com/speech-to-text/v2/docs/reference/rest/v2/projects.locations.recognizers)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speechRecognizer")]
        public virtual string SpeechRecognizer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RestrictionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Specifies the type of dataset/table restriction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A user-defined function or a stored procedure.</summary>
    public class Routine : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arguments")]
        public virtual System.Collections.Generic.IList<Argument> Arguments { get; set; }

        /// <summary>Output only. The time when this routine was created, in milliseconds since the epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual System.Nullable<long> CreationTime { get; set; }

        /// <summary>
        /// Optional. If set to `DATA_MASKING`, the function is validated and made available as a masking function. For
        /// more information, see [Create custom masking
        /// routines](https://cloud.google.com/bigquery/docs/user-defined-functions#custom-mask).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataGovernanceType")]
        public virtual string DataGovernanceType { get; set; }

        /// <summary>
        /// Required. The body of the routine. For functions, this is the expression in the AS clause. If language=SQL,
        /// it is the substring inside (but excluding) the parentheses. For example, for the function created with the
        /// following statement: `CREATE FUNCTION JoinLines(x string, y string) as (concat(x, "\n", y))` The
        /// definition_body is `concat(x, "\n", y)` (\n is not replaced with linebreak). If language=JAVASCRIPT, it is
        /// the evaluated string in the AS clause. For example, for the function created with the following statement:
        /// `CREATE FUNCTION f() RETURNS STRING LANGUAGE js AS 'return "\n";\n'` The definition_body is `return "\n";\n`
        /// Note that both \n are replaced with linebreaks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("definitionBody")]
        public virtual string DefinitionBody { get; set; }

        /// <summary>Optional. The description of the routine, if defined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. The determinism level of the JavaScript UDF, if defined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("determinismLevel")]
        public virtual string DeterminismLevel { get; set; }

        /// <summary>Output only. A hash of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. If language = "JAVASCRIPT", this field stores the path of the imported JAVASCRIPT libraries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importedLibraries")]
        public virtual System.Collections.Generic.IList<string> ImportedLibraries { get; set; }

        /// <summary>
        /// Optional. Defaults to "SQL" if remote_function_options field is absent, not set otherwise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; }

        /// <summary>
        /// Output only. The time when this routine was last modified, in milliseconds since the epoch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifiedTime")]
        public virtual System.Nullable<long> LastModifiedTime { get; set; }

        /// <summary>Optional. Remote function specific options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remoteFunctionOptions")]
        public virtual RemoteFunctionOptions RemoteFunctionOptions { get; set; }

        /// <summary>
        /// Optional. Can be set only if routine_type = "TABLE_VALUED_FUNCTION". If absent, the return table type is
        /// inferred from definition_body at query time in each query that references this routine. If present, then the
        /// columns in the evaluated table result will be cast to match the column types specified in return table type,
        /// at query time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnTableType")]
        public virtual StandardSqlTableType ReturnTableType { get; set; }

        /// <summary>
        /// Optional if language = "SQL"; required otherwise. Cannot be set if routine_type = "TABLE_VALUED_FUNCTION".
        /// If absent, the return type is inferred from definition_body at query time in each query that references this
        /// routine. If present, then the evaluated result will be cast to the specified returned type at query time.
        /// For example, for the functions created with the following statements: * `CREATE FUNCTION Add(x FLOAT64, y
        /// FLOAT64) RETURNS FLOAT64 AS (x + y);` * `CREATE FUNCTION Increment(x FLOAT64) AS (Add(x, 1));` * `CREATE
        /// FUNCTION Decrement(x FLOAT64) RETURNS FLOAT64 AS (Add(x, -1));` The return_type is `{type_kind: "FLOAT64"}`
        /// for `Add` and `Decrement`, and is absent for `Increment` (inferred as FLOAT64 at query time). Suppose the
        /// function `Add` is replaced by `CREATE OR REPLACE FUNCTION Add(x INT64, y INT64) AS (x + y);` Then the
        /// inferred return type of `Increment` is automatically changed to INT64 at query time, while the return type
        /// of `Decrement` remains FLOAT64.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnType")]
        public virtual StandardSqlDataType ReturnType { get; set; }

        /// <summary>Required. Reference describing the ID of this routine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routineReference")]
        public virtual RoutineReference RoutineReference { get; set; }

        /// <summary>Required. The type of routine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routineType")]
        public virtual string RoutineType { get; set; }

        /// <summary>
        /// Optional. The security mode of the routine, if defined. If not defined, the security mode is automatically
        /// determined from the routine's configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityMode")]
        public virtual string SecurityMode { get; set; }

        /// <summary>Optional. Spark specific options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sparkOptions")]
        public virtual SparkOptions SparkOptions { get; set; }

        /// <summary>
        /// Optional. Use this option to catch many common errors. Error checking is not exhaustive, and successfully
        /// creating a procedure doesn't guarantee that the procedure will successfully execute at runtime. If
        /// `strictMode` is set to `TRUE`, the procedure body is further checked for errors such as non-existent tables
        /// or columns. The `CREATE PROCEDURE` statement fails if the body fails any of these checks. If `strictMode` is
        /// set to `FALSE`, the procedure body is checked only for syntax. For procedures that invoke themselves
        /// recursively, specify `strictMode=FALSE` to avoid non-existent procedure errors during validation. Default
        /// value is `TRUE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("strictMode")]
        public virtual System.Nullable<bool> StrictMode { get; set; }
    }

    /// <summary>Id path of a routine.</summary>
    public class RoutineReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The ID of the dataset containing this routine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetId")]
        public virtual string DatasetId { get; set; }

        /// <summary>Required. The ID of the project containing this routine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Required. The ID of the routine. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores
        /// (_). The maximum length is 256 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routineId")]
        public virtual string RoutineId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single row in the confusion matrix.</summary>
    public class Row : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The original label of this row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actualLabel")]
        public virtual string ActualLabel { get; set; }

        /// <summary>Info describing predicted label distribution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<Entry> Entries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents access on a subset of rows on the specified table, defined by its filter predicate. Access to the
    /// subset of rows is controlled by its IAM policy.
    /// </summary>
    public class RowAccessPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _creationTimeRaw;

        private object _creationTime;

        /// <summary>
        /// Output only. The time when this row access policy was created, in milliseconds since the epoch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual string CreationTimeRaw
        {
            get => _creationTimeRaw;
            set
            {
                _creationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _creationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreationTimeDateTimeOffset instead.")]
        public virtual object CreationTime
        {
            get => _creationTime;
            set
            {
                _creationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _creationTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreationTimeRaw);
            set => CreationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. A hash of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Required. A SQL boolean expression that represents the rows defined by this row access policy, similar to
        /// the boolean expression in a WHERE clause of a SELECT query on a table. References to other tables, routines,
        /// and temporary functions are not supported. Examples: region="EU" date_field = CAST('2019-9-27' as DATE)
        /// nullable_field is not NULL numeric_field BETWEEN 1.0 AND 5.0
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterPredicate")]
        public virtual string FilterPredicate { get; set; }

        /// <summary>
        /// Optional. Input only. The optional list of iam_member users or groups that specifies the initial members
        /// that the row-level access policy should be created with. grantees types: - "user:alice@example.com": An
        /// email address that represents a specific Google account. -
        /// "serviceAccount:my-other-app@appspot.gserviceaccount.com": An email address that represents a service
        /// account. - "group:admins@example.com": An email address that represents a Google group. -
        /// "domain:example.com":The Google Workspace domain (primary) that represents all the users of that domain. -
        /// "allAuthenticatedUsers": A special identifier that represents all service accounts and all users on the
        /// internet who have authenticated with a Google Account. This identifier includes accounts that aren't
        /// connected to a Google Workspace or Cloud Identity domain, such as personal Gmail accounts. Users who aren't
        /// authenticated, such as anonymous visitors, aren't included. - "allUsers":A special identifier that
        /// represents anyone who is on the internet, including authenticated and unauthenticated users. Because
        /// BigQuery requires authentication before a user can access the service, allUsers includes only authenticated
        /// users.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grantees")]
        public virtual System.Collections.Generic.IList<string> Grantees { get; set; }

        private string _lastModifiedTimeRaw;

        private object _lastModifiedTime;

        /// <summary>
        /// Output only. The time when this row access policy was last modified, in milliseconds since the epoch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifiedTime")]
        public virtual string LastModifiedTimeRaw
        {
            get => _lastModifiedTimeRaw;
            set
            {
                _lastModifiedTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastModifiedTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastModifiedTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastModifiedTimeDateTimeOffset instead.")]
        public virtual object LastModifiedTime
        {
            get => _lastModifiedTime;
            set
            {
                _lastModifiedTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastModifiedTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastModifiedTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastModifiedTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastModifiedTimeRaw);
            set => LastModifiedTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Required. Reference describing the ID of this row access policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowAccessPolicyReference")]
        public virtual RowAccessPolicyReference RowAccessPolicyReference { get; set; }
    }

    /// <summary>Id path of a row access policy.</summary>
    public class RowAccessPolicyReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The ID of the dataset containing this row access policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetId")]
        public virtual string DatasetId { get; set; }

        /// <summary>
        /// Required. The ID of the row access policy. The ID must contain only letters (a-z, A-Z), numbers (0-9), or
        /// underscores (_). The maximum length is 256 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyId")]
        public virtual string PolicyId { get; set; }

        /// <summary>Required. The ID of the project containing this row access policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Required. The ID of the table containing this row access policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableId")]
        public virtual string TableId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Statistics for row-level security.</summary>
    public class RowLevelSecurityStatistics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether any accessed data was protected by row access policies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowLevelSecurityApplied")]
        public virtual System.Nullable<bool> RowLevelSecurityApplied { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options related to script execution.</summary>
    public class ScriptOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Determines which statement in the script represents the "key result", used to populate the schema and query
        /// results of the script job. Default is LAST.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyResultStatement")]
        public virtual string KeyResultStatement { get; set; }

        /// <summary>
        /// Limit on the number of bytes billed per statement. Exceeding this budget results in an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statementByteBudget")]
        public virtual System.Nullable<long> StatementByteBudget { get; set; }

        /// <summary>Timeout period for each statement in a script.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statementTimeoutMs")]
        public virtual System.Nullable<long> StatementTimeoutMs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the location of the statement/expression being evaluated. Line and column numbers are defined as
    /// follows: - Line and column numbers start with one. That is, line 1 column 1 denotes the start of the script. -
    /// When inside a stored procedure, all line/column numbers are relative to the procedure body, not the script in
    /// which the procedure was defined. - Start/end positions exclude leading/trailing comments and whitespace. The end
    /// position always ends with a ";", when present. - Multi-byte Unicode characters are treated as just one column. -
    /// If the original script (or procedure definition) contains TAB characters, a tab "snaps" the indentation forward
    /// to the nearest multiple of 8 characters, plus 1. For example, a TAB on column 1, 2, 3, 4, 5, 6 , or 8 will
    /// advance the next character to column 9. A TAB on column 9, 10, 11, 12, 13, 14, 15, or 16 will advance the next
    /// character to column 17.
    /// </summary>
    public class ScriptStackFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. One-based end column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endColumn")]
        public virtual System.Nullable<int> EndColumn { get; set; }

        /// <summary>Output only. One-based end line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endLine")]
        public virtual System.Nullable<int> EndLine { get; set; }

        /// <summary>Output only. Name of the active procedure, empty if in a top-level script.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("procedureId")]
        public virtual string ProcedureId { get; set; }

        /// <summary>Output only. One-based start column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startColumn")]
        public virtual System.Nullable<int> StartColumn { get; set; }

        /// <summary>Output only. One-based start line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startLine")]
        public virtual System.Nullable<int> StartLine { get; set; }

        /// <summary>Output only. Text of the current statement/expression.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Job statistics specific to the child job of a script.</summary>
    public class ScriptStatistics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether this child job was a statement or expression.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationKind")]
        public virtual string EvaluationKind { get; set; }

        /// <summary>
        /// Stack trace showing the line/column/procedure name of each frame on the stack at the point where the current
        /// evaluation happened. The leaf frame is first, the primary script is last. Never empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackFrames")]
        public virtual System.Collections.Generic.IList<ScriptStackFrame> StackFrames { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Statistics for a search query. Populated as part of JobStatistics2.</summary>
    public class SearchStatistics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When `indexUsageMode` is `UNUSED` or `PARTIALLY_USED`, this field explains why indexes were not used in all
        /// or part of the search query. If `indexUsageMode` is `FULLY_USED`, this field is not populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexUnusedReasons")]
        public virtual System.Collections.Generic.IList<IndexUnusedReason> IndexUnusedReasons { get; set; }

        /// <summary>Specifies the index usage mode for the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexUsageMode")]
        public virtual string IndexUsageMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Serializer and deserializer information.</summary>
    public class SerDeInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Name of the SerDe. The maximum length is 256 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Key-value pairs that define the initialization parameters for the serialization library. Maximum
        /// size 10 Kib.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Required. Specifies a fully-qualified class name of the serialization library that is responsible for the
        /// translation of data between table representation and the underlying low-level input and output format
        /// structures. The maximum length is 256 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serializationLibrary")]
        public virtual string SerializationLibrary { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>[Preview] Information related to sessions.</summary>
    public class SessionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The id of the session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionId")]
        public virtual string SessionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Google Cloud services (such as Projects) might
        /// reject them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>
        /// OPTIONAL: A FieldMask specifying which fields of the policy to modify. Only the fields in the mask will be
        /// modified. If no mask is provided, the following default mask is used: `paths: "bindings, etag"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about source stages which produce skewed data.</summary>
    public class SkewSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Stage id of the skew source stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stageId")]
        public virtual System.Nullable<long> StageId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about base table and snapshot time of the snapshot.</summary>
    public class SnapshotDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Reference describing the ID of the table that was snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseTableReference")]
        public virtual TableReference BaseTableReference { get; set; }

        /// <summary>
        /// Required. The time at which the base table was snapshot. This value is reported in the JSON response using
        /// RFC3339 format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotTime")]
        public virtual string SnapshotTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="SnapshotTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? SnapshotTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(SnapshotTimeRaw);
            set => SnapshotTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="SnapshotTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use SnapshotTimeDateTimeOffset instead.")]
        public virtual System.DateTime? SnapshotTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(SnapshotTimeRaw);
            set => SnapshotTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Spark job logs can be filtered by these fields in Cloud Logging.</summary>
    public class SparkLoggingInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Project ID where the Spark logs were written.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Output only. Resource type used for logging.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for a user-defined Spark routine.</summary>
    public class SparkOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Archive files to be extracted into the working directory of each executor. For more information about Apache
        /// Spark, see [Apache Spark](https://spark.apache.org/docs/latest/index.html).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("archiveUris")]
        public virtual System.Collections.Generic.IList<string> ArchiveUris { get; set; }

        /// <summary>
        /// Fully qualified name of the user-provided Spark connection object. Format:
        /// ```
        /// "projects/{project_id}/locations/{location_id}/connections/{connection_id}"
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connection")]
        public virtual string Connection { get; set; }

        /// <summary>Custom container image for the runtime environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerImage")]
        public virtual string ContainerImage { get; set; }

        /// <summary>
        /// Files to be placed in the working directory of each executor. For more information about Apache Spark, see
        /// [Apache Spark](https://spark.apache.org/docs/latest/index.html).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileUris")]
        public virtual System.Collections.Generic.IList<string> FileUris { get; set; }

        /// <summary>
        /// JARs to include on the driver and executor CLASSPATH. For more information about Apache Spark, see [Apache
        /// Spark](https://spark.apache.org/docs/latest/index.html).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jarUris")]
        public virtual System.Collections.Generic.IList<string> JarUris { get; set; }

        /// <summary>
        /// The fully qualified name of a class in jar_uris, for example, com.example.wordcount. Exactly one of
        /// main_class and main_jar_uri field should be set for Java/Scala language type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mainClass")]
        public virtual string MainClass { get; set; }

        /// <summary>
        /// The main file/jar URI of the Spark application. Exactly one of the definition_body field and the
        /// main_file_uri field must be set for Python. Exactly one of main_class and main_file_uri field should be set
        /// for Java/Scala language type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mainFileUri")]
        public virtual string MainFileUri { get; set; }

        /// <summary>
        /// Configuration properties as a set of key/value pairs, which will be passed on to the Spark application. For
        /// more information, see [Apache Spark](https://spark.apache.org/docs/latest/index.html) and the [procedure
        /// option
        /// list](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language#procedure_option_list).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Python files to be placed on the PYTHONPATH for PySpark application. Supported file types: `.py`, `.egg`,
        /// and `.zip`. For more information about Apache Spark, see [Apache
        /// Spark](https://spark.apache.org/docs/latest/index.html).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pyFileUris")]
        public virtual System.Collections.Generic.IList<string> PyFileUris { get; set; }

        /// <summary>Runtime version. If not specified, the default runtime version is used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeVersion")]
        public virtual string RuntimeVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Statistics for a BigSpark query. Populated as part of JobStatistics2</summary>
    public class SparkStatistics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Endpoints returned from Dataproc. Key list: - history_server_endpoint: A link to Spark job UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoints")]
        public virtual System.Collections.Generic.IDictionary<string, string> Endpoints { get; set; }

        /// <summary>
        /// Output only. The Google Cloud Storage bucket that is used as the default file system by the Spark
        /// application. This field is only filled when the Spark procedure uses the invoker security mode. The
        /// `gcsStagingBucket` bucket is inferred from the `@@spark_proc_properties.staging_bucket` system variable (if
        /// it is provided). Otherwise, BigQuery creates a default staging bucket for the job and returns the bucket
        /// name in this field. Example: * `gs://[bucket_name]`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsStagingBucket")]
        public virtual string GcsStagingBucket { get; set; }

        /// <summary>
        /// Output only. The Cloud KMS encryption key that is used to protect the resources created by the Spark job. If
        /// the Spark procedure uses the invoker security mode, the Cloud KMS encryption key is either inferred from the
        /// provided system variable, `@@spark_proc_properties.kms_key_name`, or the default key of the BigQuery job's
        /// project (if the CMEK organization policy is enforced). Otherwise, the Cloud KMS key is either inferred from
        /// the Spark connection associated with the procedure (if it is provided), or from the default key of the Spark
        /// connection's project if the CMEK organization policy is enforced. Example: *
        /// `projects/[kms_project_id]/locations/[region]/keyRings/[key_region]/cryptoKeys/[key]`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>Output only. Logging info is used to generate a link to Cloud Logging.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loggingInfo")]
        public virtual SparkLoggingInfo LoggingInfo { get; set; }

        /// <summary>Output only. Spark job ID if a Spark job is created successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sparkJobId")]
        public virtual string SparkJobId { get; set; }

        /// <summary>
        /// Output only. Location where the Spark job is executed. A location is selected by BigQueury for jobs
        /// configured to run in a multi-region.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sparkJobLocation")]
        public virtual string SparkJobLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Performance insights compared to the previous executions for a specific stage.</summary>
    public class StagePerformanceChangeInsight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Input data change insight of the query stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputDataChange")]
        public virtual InputDataChange InputDataChange { get; set; }

        /// <summary>Output only. The stage id that the insight mapped to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stageId")]
        public virtual System.Nullable<long> StageId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Standalone performance insights for a specific stage.</summary>
    public class StagePerformanceStandaloneInsight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. If present, the stage had the following reasons for being disqualified from BI Engine
        /// execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("biEngineReasons")]
        public virtual System.Collections.Generic.IList<BiEngineReason> BiEngineReasons { get; set; }

        /// <summary>Output only. High cardinality joins in the stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("highCardinalityJoins")]
        public virtual System.Collections.Generic.IList<HighCardinalityJoin> HighCardinalityJoins { get; set; }

        /// <summary>Output only. True if the stage has insufficient shuffle quota.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insufficientShuffleQuota")]
        public virtual System.Nullable<bool> InsufficientShuffleQuota { get; set; }

        /// <summary>Output only. Partition skew in the stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionSkew")]
        public virtual PartitionSkew PartitionSkew { get; set; }

        /// <summary>Output only. True if the stage has a slot contention issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slotContention")]
        public virtual System.Nullable<bool> SlotContention { get; set; }

        /// <summary>Output only. The stage id that the insight mapped to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stageId")]
        public virtual System.Nullable<long> StageId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The data type of a variable such as a function argument. Examples include: * INT64: `{"typeKind": "INT64"}` *
    /// ARRAY: { "typeKind": "ARRAY", "arrayElementType": {"typeKind": "STRING"} } * STRUCT&amp;gt;: { "typeKind":
    /// "STRUCT", "structType": { "fields": [ { "name": "x", "type": {"typeKind": "STRING"} }, { "name": "y", "type": {
    /// "typeKind": "ARRAY", "arrayElementType": {"typeKind": "DATE"} } } ] } } * RANGE: { "typeKind": "RANGE",
    /// "rangeElementType": {"typeKind": "DATE"} }
    /// </summary>
    public class StandardSqlDataType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of the array's elements, if type_kind = "ARRAY".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arrayElementType")]
        public virtual StandardSqlDataType ArrayElementType { get; set; }

        /// <summary>The type of the range's elements, if type_kind = "RANGE".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rangeElementType")]
        public virtual StandardSqlDataType RangeElementType { get; set; }

        /// <summary>The fields of this struct, in order, if type_kind = "STRUCT".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structType")]
        public virtual StandardSqlStructType StructType { get; set; }

        /// <summary>
        /// Required. The top level type of this field. Can be any GoogleSQL data type (e.g., "INT64", "DATE", "ARRAY").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("typeKind")]
        public virtual string TypeKind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A field or a column.</summary>
    public class StandardSqlField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The name of this field. Can be absent for struct fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. The type of this parameter. Absent if not explicitly specified (e.g., CREATE FUNCTION statement
        /// can omit the return type; in this case the output parameter does not have this "type" field).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual StandardSqlDataType Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The representation of a SQL STRUCT type.</summary>
    public class StandardSqlStructType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Fields within the struct.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<StandardSqlField> Fields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A table type</summary>
    public class StandardSqlTableType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The columns in this table type</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual System.Collections.Generic.IList<StandardSqlField> Columns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains information about how a table's data is stored and accessed by open source query engines.
    /// </summary>
    public class StorageDescriptor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specifies the fully qualified class name of the InputFormat (e.g.
        /// "org.apache.hadoop.hive.ql.io.orc.OrcInputFormat"). The maximum length is 128 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputFormat")]
        public virtual string InputFormat { get; set; }

        /// <summary>
        /// Optional. The physical location of the table (e.g. `gs://spark-dataproc-data/pangea-data/case_sensitive/` or
        /// `gs://spark-dataproc-data/pangea-data/*`). The maximum length is 2056 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationUri")]
        public virtual string LocationUri { get; set; }

        /// <summary>
        /// Optional. Specifies the fully qualified class name of the OutputFormat (e.g.
        /// "org.apache.hadoop.hive.ql.io.orc.OrcOutputFormat"). The maximum length is 128 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputFormat")]
        public virtual string OutputFormat { get; set; }

        /// <summary>Optional. Serializer and deserializer information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serdeInfo")]
        public virtual SerDeInfo SerdeInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>If the stored column was not used, explain why.</summary>
    public class StoredColumnsUnusedReason : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the high-level reason for the unused scenario, each reason must have a code associated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Specifies the detailed description for the scenario.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>
        /// Specifies which columns were not covered by the stored columns for the specified code up to 20 columns. This
        /// is populated when the code is STORED_COLUMNS_COVER_INSUFFICIENT and BASE_TABLE_HAS_CLS.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uncoveredColumns")]
        public virtual System.Collections.Generic.IList<string> UncoveredColumns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Indicates the stored columns usage in the query.</summary>
    public class StoredColumnsUsage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies the base table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseTable")]
        public virtual TableReference BaseTable { get; set; }

        /// <summary>Specifies whether the query was accelerated with stored columns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isQueryAccelerated")]
        public virtual System.Nullable<bool> IsQueryAccelerated { get; set; }

        /// <summary>If stored columns were not used, explain why.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storedColumnsUnusedReasons")]
        public virtual System.Collections.Generic.IList<StoredColumnsUnusedReason> StoredColumnsUnusedReasons { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Streamingbuffer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. A lower-bound estimate of the number of bytes currently in the streaming buffer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedBytes")]
        public virtual System.Nullable<ulong> EstimatedBytes { get; set; }

        /// <summary>
        /// Output only. A lower-bound estimate of the number of rows currently in the streaming buffer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedRows")]
        public virtual System.Nullable<ulong> EstimatedRows { get; set; }

        /// <summary>
        /// Output only. Contains the timestamp of the oldest entry in the streaming buffer, in milliseconds since the
        /// epoch, if the streaming buffer is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldestEntryTime")]
        public virtual System.Nullable<ulong> OldestEntryTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Search space for string and enum.</summary>
    public class StringHparamSearchSpace : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Canididates for the string or enum parameter in lower case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("candidates")]
        public virtual System.Collections.Generic.IList<string> Candidates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>System variables given to a query.</summary>
    public class SystemVariables : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Data type for each system variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("types")]
        public virtual System.Collections.Generic.IDictionary<string, StandardSqlDataType> Types { get; set; }

        /// <summary>Output only. Value for each system variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IDictionary<string, object> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Table : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Specifies the configuration of a BigQuery table for Apache Iceberg.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("biglakeConfiguration")]
        public virtual BigLakeConfiguration BiglakeConfiguration { get; set; }

        /// <summary>
        /// Output only. Contains information about the clone. This value is set via the clone operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloneDefinition")]
        public virtual CloneDefinition CloneDefinition { get; set; }

        /// <summary>
        /// Clustering specification for the table. Must be specified with time-based partitioning, data in the table
        /// will be first partitioned and subsequently clustered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clustering")]
        public virtual Clustering Clustering { get; set; }

        /// <summary>Output only. The time when this table was created, in milliseconds since the epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual System.Nullable<long> CreationTime { get; set; }

        /// <summary>
        /// Optional. Defines the default collation specification of new STRING fields in the table. During table
        /// creation or update, if a STRING field is added to this table without explicit collation specified, then the
        /// table inherits the table default collation. A change to this field affects only fields added afterwards, and
        /// does not alter the existing fields. The following values are supported: * 'und:ci': undetermined locale,
        /// case insensitive. * '': empty string. Default to case-sensitive behavior.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultCollation")]
        public virtual string DefaultCollation { get; set; }

        /// <summary>
        /// Optional. Defines the default rounding mode specification of new decimal fields (NUMERIC OR BIGNUMERIC) in
        /// the table. During table creation or update, if a decimal field is added to this table without an explicit
        /// rounding mode specified, then the field inherits the table default rounding mode. Changing this field
        /// doesn't affect existing fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultRoundingMode")]
        public virtual string DefaultRoundingMode { get; set; }

        /// <summary>Optional. A user-friendly description of this table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Custom encryption configuration (e.g., Cloud KMS keys).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionConfiguration")]
        public virtual EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>Output only. A hash of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. The time when this table expires, in milliseconds since the epoch. If not present, the table will
        /// persist indefinitely. Expired tables will be deleted and their storage reclaimed. The
        /// defaultTableExpirationMs property of the encapsulating dataset can be used to set a default expirationTime
        /// on newly created tables.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTime")]
        public virtual System.Nullable<long> ExpirationTime { get; set; }

        /// <summary>Optional. Options defining open source compatible table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalCatalogTableOptions")]
        public virtual ExternalCatalogTableOptions ExternalCatalogTableOptions { get; set; }

        /// <summary>
        /// Optional. Describes the data format, location, and other properties of a table stored outside of BigQuery.
        /// By defining these properties, the data source can then be queried as if it were a standard BigQuery table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalDataConfiguration")]
        public virtual ExternalDataConfiguration ExternalDataConfiguration { get; set; }

        /// <summary>Optional. A descriptive name for this table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("friendlyName")]
        public virtual string FriendlyName { get; set; }

        /// <summary>Output only. An opaque ID uniquely identifying the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The type of resource ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The labels associated with this table. You can use these to organize and group your tables. Label keys and
        /// values can be no longer than 63 characters, can only contain lowercase letters, numeric characters,
        /// underscores and dashes. International characters are allowed. Label values are optional. Label keys must
        /// start with a letter and each label in the list must have a different key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. The time when this table was last modified, in milliseconds since the epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifiedTime")]
        public virtual System.Nullable<ulong> LastModifiedTime { get; set; }

        /// <summary>
        /// Output only. The geographic location where the table resides. This value is inherited from the dataset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Optional. If set, overrides the default managed table type configured in the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedTableType")]
        public virtual string ManagedTableType { get; set; }

        /// <summary>Optional. The materialized view definition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("materializedView")]
        public virtual MaterializedViewDefinition MaterializedView { get; set; }

        /// <summary>Output only. The materialized view status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("materializedViewStatus")]
        public virtual MaterializedViewStatus MaterializedViewStatus { get; set; }

        /// <summary>
        /// Optional. The maximum staleness of data that could be returned when the table (or stale MV) is queried.
        /// Staleness encoded as a string encoding of sql IntervalValue type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxStaleness")]
        public virtual string MaxStaleness { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual ModelDefinition Model { get; set; }

        /// <summary>Output only. Number of logical bytes that are less than 90 days old.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numActiveLogicalBytes")]
        public virtual System.Nullable<long> NumActiveLogicalBytes { get; set; }

        /// <summary>
        /// Output only. Number of physical bytes less than 90 days old. This data is not kept in real time, and might
        /// be delayed by a few seconds to a few minutes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numActivePhysicalBytes")]
        public virtual System.Nullable<long> NumActivePhysicalBytes { get; set; }

        /// <summary>
        /// Output only. The size of this table in logical bytes, excluding any data in the streaming buffer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numBytes")]
        public virtual System.Nullable<long> NumBytes { get; set; }

        /// <summary>
        /// Output only. Number of physical bytes used by current live data storage. This data is not kept in real time,
        /// and might be delayed by a few seconds to a few minutes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numCurrentPhysicalBytes")]
        public virtual System.Nullable<long> NumCurrentPhysicalBytes { get; set; }

        /// <summary>
        /// Output only. The number of logical bytes in the table that are considered "long-term storage".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numLongTermBytes")]
        public virtual System.Nullable<long> NumLongTermBytes { get; set; }

        /// <summary>Output only. Number of logical bytes that are more than 90 days old.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numLongTermLogicalBytes")]
        public virtual System.Nullable<long> NumLongTermLogicalBytes { get; set; }

        /// <summary>
        /// Output only. Number of physical bytes more than 90 days old. This data is not kept in real time, and might
        /// be delayed by a few seconds to a few minutes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numLongTermPhysicalBytes")]
        public virtual System.Nullable<long> NumLongTermPhysicalBytes { get; set; }

        /// <summary>
        /// Output only. The number of partitions present in the table or materialized view. This data is not kept in
        /// real time, and might be delayed by a few seconds to a few minutes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numPartitions")]
        public virtual System.Nullable<long> NumPartitions { get; set; }

        /// <summary>
        /// Output only. The physical size of this table in bytes. This includes storage used for time travel.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numPhysicalBytes")]
        public virtual System.Nullable<long> NumPhysicalBytes { get; set; }

        /// <summary>
        /// Output only. The number of rows of data in this table, excluding any data in the streaming buffer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numRows")]
        public virtual System.Nullable<ulong> NumRows { get; set; }

        /// <summary>
        /// Output only. Number of physical bytes used by time travel storage (deleted or changed data). This data is
        /// not kept in real time, and might be delayed by a few seconds to a few minutes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numTimeTravelPhysicalBytes")]
        public virtual System.Nullable<long> NumTimeTravelPhysicalBytes { get; set; }

        /// <summary>Output only. Total number of logical bytes in the table or materialized view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numTotalLogicalBytes")]
        public virtual System.Nullable<long> NumTotalLogicalBytes { get; set; }

        /// <summary>
        /// Output only. The physical size of this table in bytes. This also includes storage used for time travel. This
        /// data is not kept in real time, and might be delayed by a few seconds to a few minutes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numTotalPhysicalBytes")]
        public virtual System.Nullable<long> NumTotalPhysicalBytes { get; set; }

        /// <summary>
        /// Optional. The partition information for all table formats, including managed partitioned tables, hive
        /// partitioned tables, iceberg partitioned, and metastore partitioned tables. This field is only populated for
        /// metastore partitioned tables. For other table formats, this is an output only field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionDefinition")]
        public virtual PartitioningDefinition PartitionDefinition { get; set; }

        /// <summary>If specified, configures range partitioning for this table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rangePartitioning")]
        public virtual RangePartitioning RangePartitioning { get; set; }

        /// <summary>Optional. Output only. Table references of all replicas currently active on the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicas")]
        public virtual System.Collections.Generic.IList<TableReference> Replicas { get; set; }

        /// <summary>
        /// Optional. If set to true, queries over this table require a partition filter that can be used for partition
        /// elimination to be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requirePartitionFilter")]
        public virtual System.Nullable<bool> RequirePartitionFilter { get; set; }

        /// <summary>
        /// [Optional] The tags associated with this table. Tag keys are globally unique. See additional information on
        /// [tags](https://cloud.google.com/iam/docs/tags-access-control#definitions). An object containing a list of
        /// "key": value pairs. The key is the namespaced friendly name of the tag key, e.g. "12345/environment" where
        /// 12345 is parent id. The value is the friendly short name of the tag value, e.g. "production".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceTags")]
        public virtual System.Collections.Generic.IDictionary<string, string> ResourceTags { get; set; }

        /// <summary>
        /// Optional. Output only. Restriction config for table. If set, restrict certain accesses on the table based on
        /// the config. See [Data egress](https://cloud.google.com/bigquery/docs/analytics-hub-introduction#data_egress)
        /// for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictions")]
        public virtual RestrictionConfig Restrictions { get; set; }

        /// <summary>Optional. Describes the schema of this table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual TableSchema Schema { get; set; }

        /// <summary>Output only. A URL that can be used to access this resource again.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>
        /// Output only. Contains information about the snapshot. This value is set via snapshot creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotDefinition")]
        public virtual SnapshotDefinition SnapshotDefinition { get; set; }

        /// <summary>
        /// Output only. Contains information regarding this table's streaming buffer, if one is present. This field
        /// will be absent if the table is not being streamed to or if there is no data in the streaming buffer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamingBuffer")]
        public virtual Streamingbuffer StreamingBuffer { get; set; }

        /// <summary>Optional. Tables Primary Key and Foreign Key information</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableConstraints")]
        public virtual TableConstraints TableConstraints { get; set; }

        /// <summary>Required. Reference describing the ID of this table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableReference")]
        public virtual TableReference TableReference { get; set; }

        /// <summary>
        /// Optional. Table replication info for table created `AS REPLICA` DDL like: `CREATE MATERIALIZED VIEW mv1 AS
        /// REPLICA OF src_mv`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableReplicationInfo")]
        public virtual TableReplicationInfo TableReplicationInfo { get; set; }

        /// <summary>If specified, configures time-based partitioning for this table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timePartitioning")]
        public virtual TimePartitioning TimePartitioning { get; set; }

        /// <summary>
        /// Output only. Describes the table type. The following values are supported: * `TABLE`: A normal BigQuery
        /// table. * `VIEW`: A virtual table defined by a SQL query. * `EXTERNAL`: A table that references data stored
        /// in an external storage system, such as Google Cloud Storage. * `MATERIALIZED_VIEW`: A precomputed view
        /// defined by a SQL query. * `SNAPSHOT`: An immutable BigQuery table that preserves the contents of a base
        /// table at a particular time. See additional information on [table
        /// snapshots](https://cloud.google.com/bigquery/docs/table-snapshots-intro). The default value is `TABLE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Optional. The view definition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("view")]
        public virtual ViewDefinition View { get; set; }
    }

    public class TableCell : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("v")]
        public virtual object V { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The TableConstraints defines the primary key and foreign key.</summary>
    public class TableConstraints : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Present only if the table has a foreign key. The foreign key is not enforced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("foreignKeys")]
        public virtual System.Collections.Generic.IList<ForeignKeysData> ForeignKeys { get; set; }

        /// <summary>Represents the primary key constraint on a table's columns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryKey")]
        public virtual PrimaryKeyData PrimaryKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>Optional. Present only if the table has a foreign key. The foreign key is not enforced.</summary>
        public class ForeignKeysData
        {
            /// <summary>Required. The columns that compose the foreign key.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("columnReferences")]
            public virtual System.Collections.Generic.IList<ColumnReferencesData> ColumnReferences { get; set; }

            /// <summary>Optional. Set only if the foreign key constraint is named.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("referencedTable")]
            public virtual ReferencedTableData ReferencedTable { get; set; }

            /// <summary>Required. The columns that compose the foreign key.</summary>
            public class ColumnReferencesData
            {
                /// <summary>
                /// Required. The column in the primary key that are referenced by the referencing_column.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("referencedColumn")]
                public virtual string ReferencedColumn { get; set; }

                /// <summary>Required. The column that composes the foreign key.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("referencingColumn")]
                public virtual string ReferencingColumn { get; set; }
            }

            public class ReferencedTableData
            {
                [Newtonsoft.Json.JsonPropertyAttribute("datasetId")]
                public virtual string DatasetId { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
                public virtual string ProjectId { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("tableId")]
                public virtual string TableId { get; set; }
            }
        }

        /// <summary>Represents the primary key constraint on a table's columns.</summary>
        public class PrimaryKeyData
        {
            /// <summary>Required. The columns that are composed of the primary key constraint.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("columns")]
            public virtual System.Collections.Generic.IList<string> Columns { get; set; }
        }
    }

    /// <summary>Request for sending a single streaming insert.</summary>
    public class TableDataInsertAllRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Accept rows that contain values that do not match the schema. The unknown values are ignored.
        /// Default is false, which treats unknown values as errors.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreUnknownValues")]
        public virtual System.Nullable<bool> IgnoreUnknownValues { get; set; }

        /// <summary>
        /// Optional. The resource type of the response. The value is not checked at the backend. Historically, it has
        /// been set to "bigquery#tableDataInsertAllRequest" but you are not required to set it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<RowsData> Rows { get; set; }

        /// <summary>
        /// Optional. Insert all valid rows of a request, even if invalid rows exist. The default value is false, which
        /// causes the entire request to fail if any invalid rows exist.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipInvalidRows")]
        public virtual System.Nullable<bool> SkipInvalidRows { get; set; }

        /// <summary>
        /// Optional. If specified, treats the destination table as a base template, and inserts the rows into an
        /// instance table named "{destination}{templateSuffix}". BigQuery will manage creation of the instance table,
        /// using the schema of the base template table. See
        /// https://cloud.google.com/bigquery/streaming-data-into-bigquery#template-tables for considerations when
        /// working with templates tables.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("templateSuffix")]
        public virtual string TemplateSuffix { get; set; }

        /// <summary>
        /// Optional. Unique request trace id. Used for debugging purposes only. It is case-sensitive, limited to up to
        /// 36 ASCII characters. A UUID is recommended.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traceId")]
        public virtual string TraceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        public class RowsData
        {
            /// <summary>
            /// Insertion ID for best-effort deduplication. This feature is not recommended, and users seeking stronger
            /// insertion semantics are encouraged to use other mechanisms such as the BigQuery Write API.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("insertId")]
            public virtual string InsertId { get; set; }

            /// <summary>Data for a single row.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("json")]
            public virtual System.Collections.Generic.IDictionary<string, object> Json { get; set; }
        }
    }

    /// <summary>Describes the format of a streaming insert response.</summary>
    public class TableDataInsertAllResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Describes specific errors encountered while processing the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertErrors")]
        public virtual System.Collections.Generic.IList<InsertErrorsData> InsertErrors { get; set; }

        /// <summary>Returns "bigquery#tableDataInsertAllResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>Describes specific errors encountered while processing the request.</summary>
        public class InsertErrorsData
        {
            /// <summary>Error information for the row indicated by the index property.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("errors")]
            public virtual System.Collections.Generic.IList<ErrorProto> Errors { get; set; }

            /// <summary>The index of the row that error applies to.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("index")]
            public virtual System.Nullable<long> Index { get; set; }
        }
    }

    public class TableDataList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A hash of this page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The resource type of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// A token used for paging results. Providing this token instead of the startIndex parameter can help you
        /// retrieve stable results when an underlying table is changing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>Rows of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<TableRow> Rows { get; set; }

        /// <summary>
        /// Total rows of the entire table. In order to show default value 0 we have to present it as string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalRows")]
        public virtual System.Nullable<long> TotalRows { get; set; }
    }

    /// <summary>A field in TableSchema</summary>
    public class TableFieldSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual CategoriesData Categories { get; set; }

        /// <summary>
        /// Optional. Field collation can be set only when the type of field is STRING. The following values are
        /// supported: * 'und:ci': undetermined locale, case insensitive. * '': empty string. Default to case-sensitive
        /// behavior.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collation")]
        public virtual string Collation { get; set; }

        /// <summary>Optional. Data policy options, will replace the data_policies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataPolicies")]
        public virtual System.Collections.Generic.IList<DataPolicyOption> DataPolicies { get; set; }

        /// <summary>
        /// Optional. A SQL expression to specify the [default value]
        /// (https://cloud.google.com/bigquery/docs/default-values) for this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValueExpression")]
        public virtual string DefaultValueExpression { get; set; }

        /// <summary>Optional. The field description. The maximum length is 1,024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. Describes the nested schema fields if the type property is set to RECORD.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<TableFieldSchema> Fields { get; set; }

        /// <summary>
        /// Optional. Definition of the foreign data type. Only valid for top-level schema fields (not nested fields).
        /// If the type is FOREIGN, this field is required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("foreignTypeDefinition")]
        public virtual string ForeignTypeDefinition { get; set; }

        /// <summary>
        /// Optional. Maximum length of values of this field for STRINGS or BYTES. If max_length is not specified, no
        /// maximum length constraint is imposed on this field. If type = "STRING", then max_length represents the
        /// maximum UTF-8 length of strings in this field. If type = "BYTES", then max_length represents the maximum
        /// number of bytes in this field. It is invalid to set this field if type ≠ "STRING" and ≠ "BYTES".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxLength")]
        public virtual System.Nullable<long> MaxLength { get; set; }

        /// <summary>
        /// Optional. The field mode. Possible values include NULLABLE, REQUIRED and REPEATED. The default value is
        /// NULLABLE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>
        /// Required. The field name. The name must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_),
        /// and must start with a letter or underscore. The maximum length is 300 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. The policy tags attached to this field, used for field-level access control. If not set, defaults
        /// to empty policy_tags.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyTags")]
        public virtual PolicyTagsData PolicyTags { get; set; }

        /// <summary>
        /// Optional. Precision (maximum number of total digits in base 10) and scale (maximum number of digits in the
        /// fractional part in base 10) constraints for values of this field for NUMERIC or BIGNUMERIC. It is invalid to
        /// set precision or scale if type ≠ "NUMERIC" and ≠ "BIGNUMERIC". If precision and scale are not specified, no
        /// value range constraint is imposed on this field insofar as values are permitted by the type. Values of this
        /// NUMERIC or BIGNUMERIC field must be in this range when: * Precision (P) and scale (S) are specified: [-10P-S
        /// + 10-S, 10P-S - 10-S] * Precision (P) is specified but not scale (and thus scale is interpreted to be equal
        /// to zero): [-10P + 1, 10P - 1]. Acceptable values for precision and scale if both are specified: * If type =
        /// "NUMERIC": 1 ≤ precision - scale ≤ 29 and 0 ≤ scale ≤ 9. * If type = "BIGNUMERIC": 1 ≤ precision - scale ≤
        /// 38 and 0 ≤ scale ≤ 38. Acceptable values for precision if only precision is specified but not scale (and
        /// thus scale is interpreted to be equal to zero): * If type = "NUMERIC": 1 ≤ precision ≤ 29. * If type =
        /// "BIGNUMERIC": 1 ≤ precision ≤ 38. If scale is specified but not precision, then it is invalid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precision")]
        public virtual System.Nullable<long> Precision { get; set; }

        /// <summary>Represents the type of a field element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rangeElementType")]
        public virtual RangeElementTypeData RangeElementType { get; set; }

        /// <summary>
        /// Optional. Specifies the rounding mode to be used when storing values of NUMERIC and BIGNUMERIC type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roundingMode")]
        public virtual string RoundingMode { get; set; }

        /// <summary>Optional. See documentation for precision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scale")]
        public virtual System.Nullable<long> Scale { get; set; }

        /// <summary>
        /// Required. The field data type. Possible values include: * STRING * BYTES * INTEGER (or INT64) * FLOAT (or
        /// FLOAT64) * BOOLEAN (or BOOL) * TIMESTAMP * DATE * TIME * DATETIME * GEOGRAPHY * NUMERIC * BIGNUMERIC * JSON
        /// * RECORD (or STRUCT) * RANGE Use of RECORD/STRUCT indicates that the field contains a nested schema.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>Deprecated.</summary>
        public class CategoriesData
        {
            /// <summary>Deprecated.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("names")]
            public virtual System.Collections.Generic.IList<string> Names { get; set; }
        }

        /// <summary>
        /// Optional. The policy tags attached to this field, used for field-level access control. If not set, defaults
        /// to empty policy_tags.
        /// </summary>
        public class PolicyTagsData
        {
            /// <summary>
            /// A list of policy tag resource names. For example, "projects/1/locations/eu/taxonomies/2/policyTags/3".
            /// At most 1 policy tag is currently allowed.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("names")]
            public virtual System.Collections.Generic.IList<string> Names { get; set; }
        }

        /// <summary>Represents the type of a field element.</summary>
        public class RangeElementTypeData
        {
            /// <summary>
            /// Required. The type of a field element. For more information, see TableFieldSchema.type.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }
        }
    }

    /// <summary>Partial projection of the metadata for a given table in a list response.</summary>
    public class TableList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A hash of this page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The type of list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>A token to request the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Tables in the requested dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tables")]
        public virtual System.Collections.Generic.IList<TablesData> Tables { get; set; }

        /// <summary>The total number of tables in the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalItems")]
        public virtual System.Nullable<int> TotalItems { get; set; }

        /// <summary>Tables in the requested dataset.</summary>
        public class TablesData
        {
            /// <summary>Clustering specification for this table, if configured.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("clustering")]
            public virtual Clustering Clustering { get; set; }

            /// <summary>Output only. The time when this table was created, in milliseconds since the epoch.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
            public virtual System.Nullable<long> CreationTime { get; set; }

            /// <summary>
            /// The time when this table expires, in milliseconds since the epoch. If not present, the table will
            /// persist indefinitely. Expired tables will be deleted and their storage reclaimed.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("expirationTime")]
            public virtual System.Nullable<long> ExpirationTime { get; set; }

            /// <summary>The user-friendly name for this table.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("friendlyName")]
            public virtual string FriendlyName { get; set; }

            /// <summary>An opaque ID of the table.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("id")]
            public virtual string Id { get; set; }

            /// <summary>The resource type.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("kind")]
            public virtual string Kind { get; set; }

            /// <summary>
            /// The labels associated with this table. You can use these to organize and group your tables.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("labels")]
            public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

            /// <summary>The range partitioning for this table.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("rangePartitioning")]
            public virtual RangePartitioning RangePartitioning { get; set; }

            /// <summary>
            /// Optional. If set to true, queries including this table must specify a partition filter. This filter is
            /// used for partition elimination.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("requirePartitionFilter")]
            public virtual System.Nullable<bool> RequirePartitionFilter { get; set; }

            /// <summary>A reference uniquely identifying table.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("tableReference")]
            public virtual TableReference TableReference { get; set; }

            /// <summary>The time-based partitioning for this table.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("timePartitioning")]
            public virtual TimePartitioning TimePartitioning { get; set; }

            /// <summary>The type of table.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }

            /// <summary>Information about a logical view.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("view")]
            public virtual ViewData View { get; set; }

            /// <summary>Information about a logical view.</summary>
            public class ViewData
            {
                /// <summary>Specifies the privacy policy for the view.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("privacyPolicy")]
                public virtual PrivacyPolicy PrivacyPolicy { get; set; }

                /// <summary>True if view is defined in legacy SQL dialect, false if in GoogleSQL.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("useLegacySql")]
                public virtual System.Nullable<bool> UseLegacySql { get; set; }
            }
        }
    }

    /// <summary>
    /// Table level detail on the usage of metadata caching. Only set for Metadata caching eligible tables referenced in
    /// the query.
    /// </summary>
    public class TableMetadataCacheUsage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Free form human-readable reason metadata caching was unused for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explanation")]
        public virtual string Explanation { get; set; }

        /// <summary>
        /// Duration since last refresh as of this job for managed tables (indicates metadata cache staleness as seen by
        /// this job).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("staleness")]
        public virtual object Staleness { get; set; }

        /// <summary>Metadata caching eligible table referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableReference")]
        public virtual TableReference TableReference { get; set; }

        /// <summary>
        /// [Table type](https://cloud.google.com/bigquery/docs/reference/rest/v2/tables#Table.FIELDS.type).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableType")]
        public virtual string TableType { get; set; }

        /// <summary>Reason for not using metadata caching for the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unusedReason")]
        public virtual string UnusedReason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TableReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The ID of the dataset containing this table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetId")]
        public virtual string DatasetId { get; set; }

        /// <summary>Required. The ID of the project containing this table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Required. The ID of the table. The ID can contain Unicode characters in category L (letter), M (mark), N
        /// (number), Pc (connector, including underscore), Pd (dash), and Zs (space). For more information, see
        /// [General Category](https://wikipedia.org/wiki/Unicode_character_property#General_Category). The maximum
        /// length is 1,024 characters. Certain operations allow suffixing of the table ID with a partition decorator,
        /// such as `sample_table$20190123`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableId")]
        public virtual string TableId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Replication info of a table created using `AS REPLICA` DDL like: `CREATE MATERIALIZED VIEW mv1 AS REPLICA OF
    /// src_mv`
    /// </summary>
    public class TableReplicationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Output only. If source is a materialized view, this field signifies the last refresh time of the
        /// source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicatedSourceLastRefreshTime")]
        public virtual System.Nullable<long> ReplicatedSourceLastRefreshTime { get; set; }

        /// <summary>Optional. Output only. Replication error that will permanently stopped table replication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicationError")]
        public virtual ErrorProto ReplicationError { get; set; }

        /// <summary>
        /// Optional. Specifies the interval at which the source table is polled for updates. It's Optional. If not
        /// specified, default replication interval would be applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicationIntervalMs")]
        public virtual System.Nullable<long> ReplicationIntervalMs { get; set; }

        /// <summary>Optional. Output only. Replication status of configured replication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicationStatus")]
        public virtual string ReplicationStatus { get; set; }

        /// <summary>Required. Source table reference that is replicated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceTable")]
        public virtual TableReference SourceTable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TableRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Represents a single row in the result set, consisting of one or more fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("f")]
        public virtual System.Collections.Generic.IList<TableCell> F { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Schema of a table</summary>
    public class TableSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Describes the fields in a table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<TableFieldSchema> Fields { get; set; }

        /// <summary>
        /// Optional. Specifies metadata of the foreign data type definition in field schema
        /// (TableFieldSchema.foreign_type_definition).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("foreignTypeInfo")]
        public virtual ForeignTypeInfo ForeignTypeInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of permissions to check for the `resource`. Permissions with wildcards (such as `*` or `storage.*`)
        /// are not allowed. For more information see [IAM
        /// Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A subset of `TestPermissionsRequest.permissions` that the caller is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TimePartitioning : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Number of milliseconds for which to keep the storage for a partition. A wrapper is used here
        /// because 0 is an invalid value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationMs")]
        public virtual System.Nullable<long> ExpirationMs { get; set; }

        /// <summary>
        /// Optional. If not set, the table is partitioned by pseudo column '_PARTITIONTIME'; if set, the table is
        /// partitioned by this field. The field must be a top-level TIMESTAMP or DATE field. Its mode must be NULLABLE
        /// or REQUIRED. A wrapper is used here because an empty string is an invalid value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        /// <summary>
        /// If set to true, queries over this table require a partition filter that can be used for partition
        /// elimination to be specified. This field is deprecated; please set the field with the same name on the table
        /// itself instead. This field needs a wrapper because we want to output the default value, false, if the user
        /// explicitly set it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requirePartitionFilter")]
        public virtual System.Nullable<bool> RequirePartitionFilter { get; set; }

        /// <summary>
        /// Required. The supported types are DAY, HOUR, MONTH, and YEAR, which will generate one partition per day,
        /// hour, month, and year, respectively.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options used in model training.</summary>
    public class TrainingOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Activation function of the neural nets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activationFn")]
        public virtual string ActivationFn { get; set; }

        /// <summary>If true, detect step changes and make data adjustment in the input time series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adjustStepChanges")]
        public virtual System.Nullable<bool> AdjustStepChanges { get; set; }

        /// <summary>
        /// Whether to use approximate feature contribution method in XGBoost model explanation for global explain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approxGlobalFeatureContrib")]
        public virtual System.Nullable<bool> ApproxGlobalFeatureContrib { get; set; }

        /// <summary>Whether to enable auto ARIMA or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoArima")]
        public virtual System.Nullable<bool> AutoArima { get; set; }

        /// <summary>The max value of the sum of non-seasonal p and q.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoArimaMaxOrder")]
        public virtual System.Nullable<long> AutoArimaMaxOrder { get; set; }

        /// <summary>The min value of the sum of non-seasonal p and q.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoArimaMinOrder")]
        public virtual System.Nullable<long> AutoArimaMinOrder { get; set; }

        /// <summary>Whether to calculate class weights automatically based on the popularity of each label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoClassWeights")]
        public virtual System.Nullable<bool> AutoClassWeights { get; set; }

        /// <summary>Batch size for dnn models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchSize")]
        public virtual System.Nullable<long> BatchSize { get; set; }

        /// <summary>Booster type for boosted tree models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boosterType")]
        public virtual string BoosterType { get; set; }

        /// <summary>Budget in hours for AutoML training.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("budgetHours")]
        public virtual System.Nullable<double> BudgetHours { get; set; }

        /// <summary>
        /// Whether or not p-value test should be computed for this model. Only available for linear and logistic
        /// regression models.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("calculatePValues")]
        public virtual System.Nullable<bool> CalculatePValues { get; set; }

        /// <summary>Categorical feature encoding method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryEncodingMethod")]
        public virtual string CategoryEncodingMethod { get; set; }

        /// <summary>If true, clean spikes and dips in the input time series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cleanSpikesAndDips")]
        public virtual System.Nullable<bool> CleanSpikesAndDips { get; set; }

        /// <summary>
        /// Enums for color space, used for processing images in Object Table. See more details at
        /// https://www.tensorflow.org/io/tutorials/colorspace.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colorSpace")]
        public virtual string ColorSpace { get; set; }

        /// <summary>Subsample ratio of columns for each level for boosted tree models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colsampleBylevel")]
        public virtual System.Nullable<double> ColsampleBylevel { get; set; }

        /// <summary>Subsample ratio of columns for each node(split) for boosted tree models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colsampleBynode")]
        public virtual System.Nullable<double> ColsampleBynode { get; set; }

        /// <summary>Subsample ratio of columns when constructing each tree for boosted tree models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colsampleBytree")]
        public virtual System.Nullable<double> ColsampleBytree { get; set; }

        /// <summary>
        /// The contribution metric. Applies to contribution analysis models. Allowed formats supported are for summable
        /// and summable ratio contribution metrics. These include expressions such as `SUM(x)` or `SUM(x)/SUM(y)`,
        /// where x and y are column names from the base table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contributionMetric")]
        public virtual string ContributionMetric { get; set; }

        /// <summary>Type of normalization algorithm for boosted tree models using dart booster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dartNormalizeType")]
        public virtual string DartNormalizeType { get; set; }

        /// <summary>The data frequency of a time series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataFrequency")]
        public virtual string DataFrequency { get; set; }

        /// <summary>
        /// The column to split data with. This column won't be used as a feature. 1. When data_split_method is CUSTOM,
        /// the corresponding column should be boolean. The rows with true value tag are eval data, and the false are
        /// training data. 2. When data_split_method is SEQ, the first DATA_SPLIT_EVAL_FRACTION rows (from smallest to
        /// largest) in the corresponding column are used as training data, and the rest are eval data. It respects the
        /// order in Orderable data types:
        /// https://cloud.google.com/bigquery/docs/reference/standard-sql/data-types#data_type_properties
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSplitColumn")]
        public virtual string DataSplitColumn { get; set; }

        /// <summary>
        /// The fraction of evaluation data over the whole input data. The rest of data will be used as training data.
        /// The format should be double. Accurate to two decimal places. Default value is 0.2.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSplitEvalFraction")]
        public virtual System.Nullable<double> DataSplitEvalFraction { get; set; }

        /// <summary>The data split type for training and evaluation, e.g. RANDOM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSplitMethod")]
        public virtual string DataSplitMethod { get; set; }

        /// <summary>If true, perform decompose time series and save the results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("decomposeTimeSeries")]
        public virtual System.Nullable<bool> DecomposeTimeSeries { get; set; }

        /// <summary>Optional. Names of the columns to slice on. Applies to contribution analysis models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionIdColumns")]
        public virtual System.Collections.Generic.IList<string> DimensionIdColumns { get; set; }

        /// <summary>Distance type for clustering models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distanceType")]
        public virtual string DistanceType { get; set; }

        /// <summary>Dropout probability for dnn models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dropout")]
        public virtual System.Nullable<double> Dropout { get; set; }

        /// <summary>
        /// Whether to stop early when the loss doesn't improve significantly any more (compared to
        /// min_relative_progress). Used only for iterative training algorithms.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("earlyStop")]
        public virtual System.Nullable<bool> EarlyStop { get; set; }

        /// <summary>If true, enable global explanation during training.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableGlobalExplain")]
        public virtual System.Nullable<bool> EnableGlobalExplain { get; set; }

        /// <summary>Feedback type that specifies which algorithm to run for matrix factorization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedbackType")]
        public virtual string FeedbackType { get; set; }

        /// <summary>Whether the model should include intercept during model training.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fitIntercept")]
        public virtual System.Nullable<bool> FitIntercept { get; set; }

        /// <summary>
        /// The forecast limit lower bound that was used during ARIMA model training with limits. To see more details of
        /// the algorithm: https://otexts.com/fpp2/limits.html
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forecastLimitLowerBound")]
        public virtual System.Nullable<double> ForecastLimitLowerBound { get; set; }

        /// <summary>The forecast limit upper bound that was used during ARIMA model training with limits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forecastLimitUpperBound")]
        public virtual System.Nullable<double> ForecastLimitUpperBound { get; set; }

        /// <summary>Hidden units for dnn models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hiddenUnits")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> HiddenUnits { get; set; }

        /// <summary>
        /// The geographical region based on which the holidays are considered in time series modeling. If a valid value
        /// is specified, then holiday effects modeling is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("holidayRegion")]
        public virtual string HolidayRegion { get; set; }

        /// <summary>A list of geographical regions that are used for time series modeling.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("holidayRegions")]
        public virtual System.Collections.Generic.IList<string> HolidayRegions { get; set; }

        /// <summary>The number of periods ahead that need to be forecasted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("horizon")]
        public virtual System.Nullable<long> Horizon { get; set; }

        /// <summary>The target evaluation metrics to optimize the hyperparameters for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hparamTuningObjectives")]
        public virtual System.Collections.Generic.IList<string> HparamTuningObjectives { get; set; }

        /// <summary>Include drift when fitting an ARIMA model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeDrift")]
        public virtual System.Nullable<bool> IncludeDrift { get; set; }

        /// <summary>Specifies the initial learning rate for the line search learn rate strategy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialLearnRate")]
        public virtual System.Nullable<double> InitialLearnRate { get; set; }

        /// <summary>Name of input label columns in training data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputLabelColumns")]
        public virtual System.Collections.Generic.IList<string> InputLabelColumns { get; set; }

        /// <summary>
        /// Name of the instance weight column for training data. This column isn't be used as a feature.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceWeightColumn")]
        public virtual string InstanceWeightColumn { get; set; }

        /// <summary>Number of integral steps for the integrated gradients explain method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integratedGradientsNumSteps")]
        public virtual System.Nullable<long> IntegratedGradientsNumSteps { get; set; }

        /// <summary>
        /// Name of the column used to determine the rows corresponding to control and test. Applies to contribution
        /// analysis models.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isTestColumn")]
        public virtual string IsTestColumn { get; set; }

        /// <summary>Item column specified for matrix factorization models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemColumn")]
        public virtual string ItemColumn { get; set; }

        /// <summary>
        /// The column used to provide the initial centroids for kmeans algorithm when kmeans_initialization_method is
        /// CUSTOM.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmeansInitializationColumn")]
        public virtual string KmeansInitializationColumn { get; set; }

        /// <summary>The method used to initialize the centroids for kmeans algorithm.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmeansInitializationMethod")]
        public virtual string KmeansInitializationMethod { get; set; }

        /// <summary>L1 regularization coefficient to activations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("l1RegActivation")]
        public virtual System.Nullable<double> L1RegActivation { get; set; }

        /// <summary>L1 regularization coefficient.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("l1Regularization")]
        public virtual System.Nullable<double> L1Regularization { get; set; }

        /// <summary>L2 regularization coefficient.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("l2Regularization")]
        public virtual System.Nullable<double> L2Regularization { get; set; }

        /// <summary>
        /// Weights associated with each label class, for rebalancing the training data. Only applicable for
        /// classification models.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelClassWeights")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<double>> LabelClassWeights { get; set; }

        /// <summary>Learning rate in training. Used only for iterative training algorithms.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("learnRate")]
        public virtual System.Nullable<double> LearnRate { get; set; }

        /// <summary>The strategy to determine learn rate for the current iteration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("learnRateStrategy")]
        public virtual string LearnRateStrategy { get; set; }

        /// <summary>Type of loss function used during training run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lossType")]
        public virtual string LossType { get; set; }

        /// <summary>
        /// The maximum number of iterations in training. Used only for iterative training algorithms.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxIterations")]
        public virtual System.Nullable<long> MaxIterations { get; set; }

        /// <summary>Maximum number of trials to run in parallel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxParallelTrials")]
        public virtual System.Nullable<long> MaxParallelTrials { get; set; }

        /// <summary>
        /// The maximum number of time points in a time series that can be used in modeling the trend component of the
        /// time series. Don't use this option with the `timeSeriesLengthFraction` or `minTimeSeriesLength` options.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxTimeSeriesLength")]
        public virtual System.Nullable<long> MaxTimeSeriesLength { get; set; }

        /// <summary>Maximum depth of a tree for boosted tree models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxTreeDepth")]
        public virtual System.Nullable<long> MaxTreeDepth { get; set; }

        /// <summary>The apriori support minimum. Applies to contribution analysis models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minAprioriSupport")]
        public virtual System.Nullable<double> MinAprioriSupport { get; set; }

        /// <summary>
        /// When early_stop is true, stops training when accuracy improvement is less than 'min_relative_progress'. Used
        /// only for iterative training algorithms.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minRelativeProgress")]
        public virtual System.Nullable<double> MinRelativeProgress { get; set; }

        /// <summary>Minimum split loss for boosted tree models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minSplitLoss")]
        public virtual System.Nullable<double> MinSplitLoss { get; set; }

        /// <summary>
        /// The minimum number of time points in a time series that are used in modeling the trend component of the time
        /// series. If you use this option you must also set the `timeSeriesLengthFraction` option. This training option
        /// ensures that enough time points are available when you use `timeSeriesLengthFraction` in trend modeling.
        /// This is particularly important when forecasting multiple time series in a single query using
        /// `timeSeriesIdColumn`. If the total number of time points is less than the `minTimeSeriesLength` value, then
        /// the query uses all available time points.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minTimeSeriesLength")]
        public virtual System.Nullable<long> MinTimeSeriesLength { get; set; }

        /// <summary>Minimum sum of instance weight needed in a child for boosted tree models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minTreeChildWeight")]
        public virtual System.Nullable<long> MinTreeChildWeight { get; set; }

        /// <summary>The model registry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelRegistry")]
        public virtual string ModelRegistry { get; set; }

        /// <summary>
        /// Google Cloud Storage URI from which the model was imported. Only applicable for imported models.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelUri")]
        public virtual string ModelUri { get; set; }

        /// <summary>
        /// A specification of the non-seasonal part of the ARIMA model: the three components (p, d, q) are the AR
        /// order, the degree of differencing, and the MA order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonSeasonalOrder")]
        public virtual ArimaOrder NonSeasonalOrder { get; set; }

        /// <summary>Number of clusters for clustering models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numClusters")]
        public virtual System.Nullable<long> NumClusters { get; set; }

        /// <summary>Num factors specified for matrix factorization models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numFactors")]
        public virtual System.Nullable<long> NumFactors { get; set; }

        /// <summary>Number of parallel trees constructed during each iteration for boosted tree models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numParallelTree")]
        public virtual System.Nullable<long> NumParallelTree { get; set; }

        /// <summary>
        /// Number of principal components to keep in the PCA model. Must be &amp;lt;= the number of features.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numPrincipalComponents")]
        public virtual System.Nullable<long> NumPrincipalComponents { get; set; }

        /// <summary>Number of trials to run this hyperparameter tuning job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numTrials")]
        public virtual System.Nullable<long> NumTrials { get; set; }

        /// <summary>Optimization strategy for training linear regression models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optimizationStrategy")]
        public virtual string OptimizationStrategy { get; set; }

        /// <summary>Optimizer used for training the neural nets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optimizer")]
        public virtual string Optimizer { get; set; }

        /// <summary>
        /// The minimum ratio of cumulative explained variance that needs to be given by the PCA model.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pcaExplainedVarianceRatio")]
        public virtual System.Nullable<double> PcaExplainedVarianceRatio { get; set; }

        /// <summary>The solver for PCA.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pcaSolver")]
        public virtual string PcaSolver { get; set; }

        /// <summary>Number of paths for the sampled Shapley explain method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampledShapleyNumPaths")]
        public virtual System.Nullable<long> SampledShapleyNumPaths { get; set; }

        /// <summary>
        /// If true, scale the feature values by dividing the feature standard deviation. Currently only apply to PCA.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scaleFeatures")]
        public virtual System.Nullable<bool> ScaleFeatures { get; set; }

        /// <summary>Whether to standardize numerical features. Default to true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standardizeFeatures")]
        public virtual System.Nullable<bool> StandardizeFeatures { get; set; }

        /// <summary>
        /// Subsample fraction of the training data to grow tree to prevent overfitting for boosted tree models.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subsample")]
        public virtual System.Nullable<double> Subsample { get; set; }

        /// <summary>
        /// Based on the selected TF version, the corresponding docker image is used to train external models.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tfVersion")]
        public virtual string TfVersion { get; set; }

        /// <summary>Column to be designated as time series data for ARIMA model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeriesDataColumn")]
        public virtual string TimeSeriesDataColumn { get; set; }

        /// <summary>The time series id column that was used during ARIMA model training.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeriesIdColumn")]
        public virtual string TimeSeriesIdColumn { get; set; }

        /// <summary>The time series id columns that were used during ARIMA model training.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeriesIdColumns")]
        public virtual System.Collections.Generic.IList<string> TimeSeriesIdColumns { get; set; }

        /// <summary>
        /// The fraction of the interpolated length of the time series that's used to model the time series trend
        /// component. All of the time points of the time series are used to model the non-trend component. This
        /// training option accelerates modeling training without sacrificing much forecasting accuracy. You can use
        /// this option with `minTimeSeriesLength` but not with `maxTimeSeriesLength`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeriesLengthFraction")]
        public virtual System.Nullable<double> TimeSeriesLengthFraction { get; set; }

        /// <summary>Column to be designated as time series timestamp for ARIMA model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeriesTimestampColumn")]
        public virtual string TimeSeriesTimestampColumn { get; set; }

        /// <summary>Tree construction algorithm for boosted tree models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("treeMethod")]
        public virtual string TreeMethod { get; set; }

        /// <summary>
        /// Smoothing window size for the trend component. When a positive value is specified, a center moving average
        /// smoothing is applied on the history trend. When the smoothing window is out of the boundary at the beginning
        /// or the end of the trend, the first element or the last element is padded to fill the smoothing window before
        /// the average is applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trendSmoothingWindowSize")]
        public virtual System.Nullable<long> TrendSmoothingWindowSize { get; set; }

        /// <summary>User column specified for matrix factorization models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userColumn")]
        public virtual string UserColumn { get; set; }

        /// <summary>
        /// The version aliases to apply in Vertex AI model registry. Always overwrite if the version aliases exists in
        /// a existing model.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertexAiModelVersionAliases")]
        public virtual System.Collections.Generic.IList<string> VertexAiModelVersionAliases { get; set; }

        /// <summary>Hyperparameter for matrix factoration when implicit feedback type is specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("walsAlpha")]
        public virtual System.Nullable<double> WalsAlpha { get; set; }

        /// <summary>Whether to train a model from the last checkpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warmStart")]
        public virtual System.Nullable<bool> WarmStart { get; set; }

        /// <summary>User-selected XGBoost versions for training of XGBoost models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("xgboostVersion")]
        public virtual string XgboostVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a single training query run for the model.</summary>
    public class TrainingRun : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Global explanation contains the explanation of top features on the class level. Applies to
        /// classification models only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classLevelGlobalExplanations")]
        public virtual System.Collections.Generic.IList<GlobalExplanation> ClassLevelGlobalExplanations { get; set; }

        /// <summary>
        /// Output only. Data split result of the training run. Only set when the input data is actually split.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSplitResult")]
        public virtual DataSplitResult DataSplitResult { get; set; }

        /// <summary>
        /// Output only. The evaluation metrics over training/eval data that were computed at the end of training.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationMetrics")]
        public virtual EvaluationMetrics EvaluationMetrics { get; set; }

        /// <summary>
        /// Output only. Global explanation contains the explanation of top features on the model level. Applies to both
        /// regression and classification models.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelLevelGlobalExplanation")]
        public virtual GlobalExplanation ModelLevelGlobalExplanation { get; set; }

        /// <summary>Output only. Output of each iteration run, results.size() &lt;= max_iterations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<IterationResult> Results { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. The start time of this training run.</summary>
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

        /// <summary>
        /// Output only. Options that were used for this training run, includes user specified and default options that
        /// were used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingOptions")]
        public virtual TrainingOptions TrainingOptions { get; set; }

        /// <summary>Output only. The start time of this training run, in milliseconds since epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingStartTime")]
        public virtual System.Nullable<long> TrainingStartTime { get; set; }

        /// <summary>
        /// The model id in the [Vertex AI Model
        /// Registry](https://cloud.google.com/vertex-ai/docs/model-registry/introduction) for this training run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertexAiModelId")]
        public virtual string VertexAiModelId { get; set; }

        /// <summary>
        /// Output only. The model version in the [Vertex AI Model
        /// Registry](https://cloud.google.com/vertex-ai/docs/model-registry/introduction) for this training run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertexAiModelVersion")]
        public virtual string VertexAiModelVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>[Alpha] Information of a multi-statement transaction.</summary>
    public class TransactionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. [Alpha] Id of the transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionId")]
        public virtual string TransactionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a single transform column.</summary>
    public class TransformColumn : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Name of the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The SQL expression used in the column transform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transformSql")]
        public virtual string TransformSql { get; set; }

        /// <summary>Output only. Data type of the column after the transform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual StandardSqlDataType Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request format for undeleting a dataset.</summary>
    public class UndeleteDatasetRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _deletionTimeRaw;

        private object _deletionTime;

        /// <summary>
        /// Optional. The exact time when the dataset was deleted. If not specified, the most recently deleted version
        /// is undeleted. Undeleting a dataset using deletion time is not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionTime")]
        public virtual string DeletionTimeRaw
        {
            get => _deletionTimeRaw;
            set
            {
                _deletionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deletionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeletionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeletionTimeDateTimeOffset instead.")]
        public virtual object DeletionTime
        {
            get => _deletionTime;
            set
            {
                _deletionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deletionTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeletionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeletionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeletionTimeRaw);
            set => DeletionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    ///  This is used for defining User Defined Function (UDF) resources only when using legacy SQL. Users of GoogleSQL
    /// should leverage either DDL (e.g. CREATE [TEMPORARY] FUNCTION ... ) or the Routines API to define UDF resources.
    /// For additional information on migrating, see:
    /// https://cloud.google.com/bigquery/docs/reference/standard-sql/migrating-from-legacy-sql#differences_in_user-defined_javascript_functions
    /// </summary>
    public class UserDefinedFunctionResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Pick one] An inline resource that contains code for a user-defined function (UDF). Providing a inline code
        /// resource is equivalent to providing a URI for a file containing the same code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inlineCode")]
        public virtual string InlineCode { get; set; }

        /// <summary>[Pick one] A code resource to load from a Google Cloud Storage URI (gs://bucket/path).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual string ResourceUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Statistics for a vector search query. Populated as part of JobStatistics2.</summary>
    public class VectorSearchStatistics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When `indexUsageMode` is `UNUSED` or `PARTIALLY_USED`, this field explains why indexes were not used in all
        /// or part of the vector search query. If `indexUsageMode` is `FULLY_USED`, this field is not populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexUnusedReasons")]
        public virtual System.Collections.Generic.IList<IndexUnusedReason> IndexUnusedReasons { get; set; }

        /// <summary>Specifies the index usage mode for the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexUsageMode")]
        public virtual string IndexUsageMode { get; set; }

        /// <summary>
        /// Specifies the usage of stored columns in the query when stored columns are used in the query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storedColumnsUsages")]
        public virtual System.Collections.Generic.IList<StoredColumnsUsage> StoredColumnsUsages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the definition of a logical view.</summary>
    public class ViewDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Foreign view representations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("foreignDefinitions")]
        public virtual System.Collections.Generic.IList<ForeignViewDefinition> ForeignDefinitions { get; set; }

        /// <summary>Optional. Specifies the privacy policy for the view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privacyPolicy")]
        public virtual PrivacyPolicy PrivacyPolicy { get; set; }

        /// <summary>Required. A query that BigQuery executes when the view is referenced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>
        /// True if the column names are explicitly specified. For example by using the 'CREATE VIEW v(c1, c2) AS ...'
        /// syntax. Can only be set for GoogleSQL views.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useExplicitColumnNames")]
        public virtual System.Nullable<bool> UseExplicitColumnNames { get; set; }

        /// <summary>
        /// Specifies whether to use BigQuery's legacy SQL for this view. The default value is true. If set to false,
        /// the view will use BigQuery's GoogleSQL: https://cloud.google.com/bigquery/sql-reference/ Queries and views
        /// that reference this view must use the same flag value. A wrapper is used here because the default value is
        /// True.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useLegacySql")]
        public virtual System.Nullable<bool> UseLegacySql { get; set; }

        /// <summary>Describes user-defined function resources used in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userDefinedFunctionResources")]
        public virtual System.Collections.Generic.IList<UserDefinedFunctionResource> UserDefinedFunctionResources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
