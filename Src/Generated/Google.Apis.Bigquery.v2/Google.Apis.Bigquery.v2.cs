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
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "bigquery";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://bigquery.googleapis.com/bigquery/v2/";
        #else
            "https://bigquery.googleapis.com/bigquery/v2/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "bigquery/v2/";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://bigquery.googleapis.com/batch/bigquery/v2";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch/bigquery/v2";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the BigQuery API.</summary>
        public class Scope
        {
            /// <summary>View and manage your data in Google BigQuery</summary>
            public static string Bigquery = "https://www.googleapis.com/auth/bigquery";

            /// <summary>Insert data into Google BigQuery</summary>
            public static string BigqueryInsertdata = "https://www.googleapis.com/auth/bigquery.insertdata";

            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View your data across Google Cloud Platform services</summary>
            public static string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";

            /// <summary>Manage your data and permissions in Google Cloud Storage</summary>
            public static string DevstorageFullControl = "https://www.googleapis.com/auth/devstorage.full_control";

            /// <summary>View your data in Google Cloud Storage</summary>
            public static string DevstorageReadOnly = "https://www.googleapis.com/auth/devstorage.read_only";

            /// <summary>Manage your data in Google Cloud Storage</summary>
            public static string DevstorageReadWrite = "https://www.googleapis.com/auth/devstorage.read_write";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the BigQuery API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your data in Google BigQuery</summary>
            public const string Bigquery = "https://www.googleapis.com/auth/bigquery";

            /// <summary>Insert data into Google BigQuery</summary>
            public const string BigqueryInsertdata = "https://www.googleapis.com/auth/bigquery.insertdata";

            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View your data across Google Cloud Platform services</summary>
            public const string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";

            /// <summary>Manage your data and permissions in Google Cloud Storage</summary>
            public const string DevstorageFullControl = "https://www.googleapis.com/auth/devstorage.full_control";

            /// <summary>View your data in Google Cloud Storage</summary>
            public const string DevstorageReadOnly = "https://www.googleapis.com/auth/devstorage.read_only";

            /// <summary>Manage your data in Google Cloud Storage</summary>
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

        /// <summary>Data format for the response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for the response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json = 0,
        }

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
        /// An opaque string that represents a user for quota purposes. Must not exceed 40 characters.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Deprecated. Please use quotaUser instead.</summary>
        [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UserIp { get; set; }

        /// <summary>Initializes Bigquery parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();
            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "json",
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
            RequestParameters.Add("userIp", new Google.Apis.Discovery.Parameter
            {
                Name = "userIp",
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
        /// <param name="projectId">Project ID of the dataset being deleted</param>
        /// <param name="datasetId">Dataset ID of dataset being deleted</param>
        public virtual DeleteRequest Delete(string projectId, string datasetId)
        {
            return new DeleteRequest(service, projectId, datasetId);
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

            /// <summary>Project ID of the dataset being deleted</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Dataset ID of dataset being deleted</summary>
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
            public override string RestPath => "projects/{projectId}/datasets/{datasetId}";

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
                    Pattern = null,
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
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
        /// <param name="projectId">Project ID of the requested dataset</param>
        /// <param name="datasetId">Dataset ID of the requested dataset</param>
        public virtual GetRequest Get(string projectId, string datasetId)
        {
            return new GetRequest(service, projectId, datasetId);
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

            /// <summary>Project ID of the requested dataset</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Dataset ID of the requested dataset</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{projectId}/datasets/{datasetId}";

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
                    Pattern = null,
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Creates a new empty dataset.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Project ID of the new dataset</param>
        public virtual InsertRequest Insert(Google.Apis.Bigquery.v2.Data.Dataset body, string projectId)
        {
            return new InsertRequest(service, body, projectId);
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

            /// <summary>Project ID of the new dataset</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.Dataset Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{projectId}/datasets";

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
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Lists all datasets in the specified project to which you have been granted the READER dataset role.
        /// </summary>
        /// <param name="projectId">Project ID of the datasets to be listed</param>
        public virtual ListRequest List(string projectId)
        {
            return new ListRequest(service, projectId);
        }

        /// <summary>
        /// Lists all datasets in the specified project to which you have been granted the READER dataset role.
        /// </summary>
        public class ListRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.DatasetList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string projectId) : base(service)
            {
                ProjectId = projectId;
                InitParameters();
            }

            /// <summary>Project ID of the datasets to be listed</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Whether to list all datasets, including hidden ones</summary>
            [Google.Apis.Util.RequestParameterAttribute("all", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> All { get; set; }

            /// <summary>
            /// An expression for filtering the results of the request by label. The syntax is
            /// "labels.&amp;lt;name&amp;gt;[:&amp;lt;value&amp;gt;]". Multiple filters can be ANDed together by
            /// connecting with a space. Example: "labels.department:receiving labels.active". See Filtering datasets
            /// using labels for details.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>The maximum number of results to return</summary>
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
            public override string RestPath => "projects/{projectId}/datasets";

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
                    Pattern = null,
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
        /// supports patch semantics.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Project ID of the dataset being updated</param>
        /// <param name="datasetId">Dataset ID of the dataset being updated</param>
        public virtual PatchRequest Patch(Google.Apis.Bigquery.v2.Data.Dataset body, string projectId, string datasetId)
        {
            return new PatchRequest(service, body, projectId, datasetId);
        }

        /// <summary>
        /// Updates information in an existing dataset. The update method replaces the entire dataset resource, whereas
        /// the patch method only replaces fields that are provided in the submitted dataset resource. This method
        /// supports patch semantics.
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

            /// <summary>Project ID of the dataset being updated</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Dataset ID of the dataset being updated</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.Dataset Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{projectId}/datasets/{datasetId}";

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
                    Pattern = null,
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates information in an existing dataset. The update method replaces the entire dataset resource, whereas
        /// the patch method only replaces fields that are provided in the submitted dataset resource.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Project ID of the dataset being updated</param>
        /// <param name="datasetId">Dataset ID of the dataset being updated</param>
        public virtual UpdateRequest Update(Google.Apis.Bigquery.v2.Data.Dataset body, string projectId, string datasetId)
        {
            return new UpdateRequest(service, body, projectId, datasetId);
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

            /// <summary>Project ID of the dataset being updated</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Dataset ID of the dataset being updated</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.Dataset Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{projectId}/datasets/{datasetId}";

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
                    Pattern = null,
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
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
        /// <param name="projectId">[Required] Project ID of the job to cancel</param>
        /// <param name="jobId">[Required] Job ID of the job to cancel</param>
        public virtual CancelRequest Cancel(string projectId, string jobId)
        {
            return new CancelRequest(service, projectId, jobId);
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

            /// <summary>[Required] Project ID of the job to cancel</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>[Required] Job ID of the job to cancel</summary>
            [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string JobId { get; private set; }

            /// <summary>
            /// The geographic location of the job. Required except for US and EU. See details at
            /// https://cloud.google.com/bigquery/docs/locations#specifying_your_location.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Location { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "cancel";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{projectId}/jobs/{jobId}/cancel";

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
                    Pattern = null,
                });
                RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                {
                    Name = "jobId",
                    IsRequired = true,
                    ParameterType = "path",
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
            }
        }

        /// <summary>
        /// Requests that a job is deleted. This call will return when the job is deleted. This method is available in
        /// limited preview.
        /// </summary>
        /// <param name="projectId">Required. Project ID of the job to be deleted.</param>
        /// <param name="jobId">
        /// Required. Job ID of the job to be deleted. If this is a parent job which has child jobs, all child jobs will
        /// be deleted as well. Deletion of child jobs directly is not allowed.
        /// </param>
        public virtual DeleteRequest Delete(string projectId, string jobId)
        {
            return new DeleteRequest(service, projectId, jobId);
        }

        /// <summary>
        /// Requests that a job is deleted. This call will return when the job is deleted. This method is available in
        /// limited preview.
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

            /// <summary>Required. Project ID of the job to be deleted.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>
            /// Required. Job ID of the job to be deleted. If this is a parent job which has child jobs, all child jobs
            /// will be deleted as well. Deletion of child jobs directly is not allowed.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string JobId { get; private set; }

            /// <summary>
            /// The geographic location of the job. Required. See details at:
            /// https://cloud.google.com/bigquery/docs/locations#specifying_your_location.
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
        /// <param name="projectId">[Required] Project ID of the requested job</param>
        /// <param name="jobId">[Required] Job ID of the requested job</param>
        public virtual GetRequest Get(string projectId, string jobId)
        {
            return new GetRequest(service, projectId, jobId);
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

            /// <summary>[Required] Project ID of the requested job</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>[Required] Job ID of the requested job</summary>
            [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string JobId { get; private set; }

            /// <summary>
            /// The geographic location of the job. Required except for US and EU. See details at
            /// https://cloud.google.com/bigquery/docs/locations#specifying_your_location.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Location { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{projectId}/jobs/{jobId}";

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
                    Pattern = null,
                });
                RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                {
                    Name = "jobId",
                    IsRequired = true,
                    ParameterType = "path",
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
            }
        }

        /// <summary>Retrieves the results of a query job.</summary>
        /// <param name="projectId">[Required] Project ID of the query job</param>
        /// <param name="jobId">[Required] Job ID of the query job</param>
        public virtual GetQueryResultsRequest GetQueryResults(string projectId, string jobId)
        {
            return new GetQueryResultsRequest(service, projectId, jobId);
        }

        /// <summary>Retrieves the results of a query job.</summary>
        public class GetQueryResultsRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.GetQueryResultsResponse>
        {
            /// <summary>Constructs a new GetQueryResults request.</summary>
            public GetQueryResultsRequest(Google.Apis.Services.IClientService service, string projectId, string jobId) : base(service)
            {
                ProjectId = projectId;
                JobId = jobId;
                InitParameters();
            }

            /// <summary>[Required] Project ID of the query job</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>[Required] Job ID of the query job</summary>
            [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string JobId { get; private set; }

            /// <summary>
            /// The geographic location where the job should run. Required except for US and EU. See details at
            /// https://cloud.google.com/bigquery/docs/locations#specifying_your_location.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Location { get; set; }

            /// <summary>Maximum number of results to read</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Page token, returned by a previous call, to request the next page of results</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Zero-based index of the starting row</summary>
            [Google.Apis.Util.RequestParameterAttribute("startIndex", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ulong> StartIndex { get; set; }

            /// <summary>
            /// How long to wait for the query to complete, in milliseconds, before returning. Default is 10 seconds. If
            /// the timeout passes before the job completes, the 'jobComplete' field in the response will be false
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("timeoutMs", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> TimeoutMs { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getQueryResults";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{projectId}/queries/{jobId}";

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
                    Pattern = null,
                });
                RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                {
                    Name = "jobId",
                    IsRequired = true,
                    ParameterType = "path",
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

        /// <summary>Starts a new asynchronous job. Requires the Can View project role.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Project ID of the project that will be billed for the job</param>
        public virtual InsertRequest Insert(Google.Apis.Bigquery.v2.Data.Job body, string projectId)
        {
            return new InsertRequest(service, body, projectId);
        }

        /// <summary>Starts a new asynchronous job. Requires the Can View project role.</summary>
        public class InsertRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.Job>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Bigquery.v2.Data.Job body, string projectId) : base(service)
            {
                ProjectId = projectId;
                Body = body;
                InitParameters();
            }

            /// <summary>Project ID of the project that will be billed for the job</summary>
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
            public override string RestPath => "projects/{projectId}/jobs";

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
                    Pattern = null,
                });
            }
        }

        /// <summary>Starts a new asynchronous job. Requires the Can View project role.</summary>
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
        /// <param name="projectId">Project ID of the project that will be billed for the job</param>
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual InsertMediaUpload Insert(Google.Apis.Bigquery.v2.Data.Job body, string projectId, System.IO.Stream stream, string contentType)
        {
            return new InsertMediaUpload(service, body, projectId, stream, contentType);
        }

        /// <summary>Insert media upload which supports resumable upload.</summary>
        public class InsertMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.Bigquery.v2.Data.Job, Google.Apis.Bigquery.v2.Data.Job>
        {
            /// <summary>Data format for the response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<AltEnum> Alt { get; set; }

            /// <summary>Data format for the response.</summary>
            public enum AltEnum
            {
                /// <summary>Responses with Content-Type of application/json</summary>
                [Google.Apis.Util.StringValueAttribute("json")]
                Json = 0,
            }

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
            /// An opaque string that represents a user for quota purposes. Must not exceed 40 characters.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser { get; set; }

            /// <summary>Deprecated. Please use quotaUser instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserIp { get; set; }

            /// <summary>Project ID of the project that will be billed for the job</summary>
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
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "projects/{projectId}/jobs"), "POST", stream, contentType)
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
        /// <param name="projectId">Project ID of the jobs to list</param>
        public virtual ListRequest List(string projectId)
        {
            return new ListRequest(service, projectId);
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

            /// <summary>Project ID of the jobs to list</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Whether to display jobs owned by all users in the project. Default false</summary>
            [Google.Apis.Util.RequestParameterAttribute("allUsers", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AllUsers { get; set; }

            /// <summary>
            /// Max value for job creation time, in milliseconds since the POSIX epoch. If set, only jobs created before
            /// or at this timestamp are returned
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxCreationTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ulong> MaxCreationTime { get; set; }

            /// <summary>Maximum number of results to return</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// Min value for job creation time, in milliseconds since the POSIX epoch. If set, only jobs created after
            /// or at this timestamp are returned
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("minCreationTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ulong> MinCreationTime { get; set; }

            /// <summary>Page token, returned by a previous call, to request the next page of results</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// If set, retrieves only jobs whose parent is this job. Otherwise, retrieves only jobs which have no
            /// parent
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
            [Google.Apis.Util.RequestParameterAttribute("stateFilter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<StateFilterEnum> StateFilter { get; set; }

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
            public override string RestPath => "projects/{projectId}/jobs";

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
                    Pattern = null,
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
        /// <param name="projectId">Project ID of the project billed for the query</param>
        public virtual QueryRequest Query(Google.Apis.Bigquery.v2.Data.QueryRequest body, string projectId)
        {
            return new QueryRequest(service, body, projectId);
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

            /// <summary>Project ID of the project billed for the query</summary>
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
            public override string RestPath => "projects/{projectId}/queries";

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
                    Pattern = null,
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
            return new DeleteRequest(service, projectId, datasetId, modelId);
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
            return new GetRequest(service, projectId, datasetId, modelId);
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
            return new ListRequest(service, projectId, datasetId);
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
            return new PatchRequest(service, body, projectId, datasetId, modelId);
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

        /// <summary>
        /// Returns the email address of the service account for your project used for interactions with Google Cloud
        /// KMS.
        /// </summary>
        /// <param name="projectId">Project ID for which the service account is requested.</param>
        public virtual GetServiceAccountRequest GetServiceAccount(string projectId)
        {
            return new GetServiceAccountRequest(service, projectId);
        }

        /// <summary>
        /// Returns the email address of the service account for your project used for interactions with Google Cloud
        /// KMS.
        /// </summary>
        public class GetServiceAccountRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.GetServiceAccountResponse>
        {
            /// <summary>Constructs a new GetServiceAccount request.</summary>
            public GetServiceAccountRequest(Google.Apis.Services.IClientService service, string projectId) : base(service)
            {
                ProjectId = projectId;
                InitParameters();
            }

            /// <summary>Project ID for which the service account is requested.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getServiceAccount";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{projectId}/serviceAccount";

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
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists all projects to which you have been granted any project role.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists all projects to which you have been granted any project role.</summary>
        public class ListRequest : BigqueryBaseServiceRequest<Google.Apis.Bigquery.v2.Data.ProjectList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Maximum number of results to return</summary>
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
            return new DeleteRequest(service, projectId, datasetId, routineId);
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
            return new GetRequest(service, projectId, datasetId, routineId);
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

        /// <summary>Creates a new routine in the dataset.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. Project ID of the new routine</param>
        /// <param name="datasetId">Required. Dataset ID of the new routine</param>
        public virtual InsertRequest Insert(Google.Apis.Bigquery.v2.Data.Routine body, string projectId, string datasetId)
        {
            return new InsertRequest(service, body, projectId, datasetId);
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
            return new ListRequest(service, projectId, datasetId);
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
            /// If set, then only the Routines matching this filter are returned. The current supported form is either
            /// "routine_type:" or "routineType:", where is a RoutineType enum. Example: "routineType:SCALAR_FUNCTION".
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
        /// Updates information in an existing routine. The update method replaces the entire Routine resource.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. Project ID of the routine to update</param>
        /// <param name="datasetId">Required. Dataset ID of the routine to update</param>
        /// <param name="routineId">Required. Routine ID of the routine to update</param>
        public virtual UpdateRequest Update(Google.Apis.Bigquery.v2.Data.Routine body, string projectId, string datasetId, string routineId)
        {
            return new UpdateRequest(service, body, projectId, datasetId, routineId);
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

        /// <summary>
        /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does not
        /// have a policy set.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
        /// appropriate value for this field.
        /// </param>
        public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.Bigquery.v2.Data.GetIamPolicyRequest body, string resource)
        {
            return new GetIamPolicyRequest(service, body, resource);
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
            /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
            /// appropriate value for this field.
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

        /// <summary>Lists all row access policies on the specified table.</summary>
        /// <param name="projectId">Required. Project ID of the row access policies to list.</param>
        /// <param name="datasetId">Required. Dataset ID of row access policies to list.</param>
        /// <param name="tableId">Required. Table ID of the table to list row access policies.</param>
        public virtual ListRequest List(string projectId, string datasetId, string tableId)
        {
            return new ListRequest(service, projectId, datasetId, tableId);
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
        /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
        /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
        /// appropriate value for this field.
        /// </param>
        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Bigquery.v2.Data.SetIamPolicyRequest body, string resource)
        {
            return new SetIamPolicyRequest(service, body, resource);
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
            /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
            /// appropriate value for this field.
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
                    Pattern = @"^projects/[^/]+/datasets/[^/]+/tables/[^/]+/rowAccessPolicies/[^/]+$",
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
        /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation for
        /// the appropriate value for this field.
        /// </param>
        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Bigquery.v2.Data.TestIamPermissionsRequest body, string resource)
        {
            return new TestIamPermissionsRequest(service, body, resource);
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
            /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation
            /// for the appropriate value for this field.
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

        /// <summary>
        /// Streams data into BigQuery one record at a time without needing to run a load job. Requires the WRITER
        /// dataset role.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Project ID of the destination table.</param>
        /// <param name="datasetId">Dataset ID of the destination table.</param>
        /// <param name="tableId">Table ID of the destination table.</param>
        public virtual InsertAllRequest InsertAll(Google.Apis.Bigquery.v2.Data.TableDataInsertAllRequest body, string projectId, string datasetId, string tableId)
        {
            return new InsertAllRequest(service, body, projectId, datasetId, tableId);
        }

        /// <summary>
        /// Streams data into BigQuery one record at a time without needing to run a load job. Requires the WRITER
        /// dataset role.
        /// </summary>
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

            /// <summary>Project ID of the destination table.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Dataset ID of the destination table.</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Table ID of the destination table.</summary>
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
            public override string RestPath => "projects/{projectId}/datasets/{datasetId}/tables/{tableId}/insertAll";

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
                    Pattern = null,
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("tableId", new Google.Apis.Discovery.Parameter
                {
                    Name = "tableId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves table data from a specified set of rows. Requires the READER dataset role.</summary>
        /// <param name="projectId">Project ID of the table to read</param>
        /// <param name="datasetId">Dataset ID of the table to read</param>
        /// <param name="tableId">Table ID of the table to read</param>
        public virtual ListRequest List(string projectId, string datasetId, string tableId)
        {
            return new ListRequest(service, projectId, datasetId, tableId);
        }

        /// <summary>Retrieves table data from a specified set of rows. Requires the READER dataset role.</summary>
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

            /// <summary>Project ID of the table to read</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Dataset ID of the table to read</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Table ID of the table to read</summary>
            [Google.Apis.Util.RequestParameterAttribute("tableId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string TableId { get; private set; }

            /// <summary>Maximum number of results to return</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Page token, returned by a previous call, identifying the result set</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>List of fields to return (comma-separated). If unspecified, all fields are returned</summary>
            [Google.Apis.Util.RequestParameterAttribute("selectedFields", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string SelectedFields { get; set; }

            /// <summary>Zero-based index of the starting row to read</summary>
            [Google.Apis.Util.RequestParameterAttribute("startIndex", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ulong> StartIndex { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{projectId}/datasets/{datasetId}/tables/{tableId}/data";

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
                    Pattern = null,
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("tableId", new Google.Apis.Discovery.Parameter
                {
                    Name = "tableId",
                    IsRequired = true,
                    ParameterType = "path",
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
        /// <param name="projectId">Project ID of the table to delete</param>
        /// <param name="datasetId">Dataset ID of the table to delete</param>
        /// <param name="tableId">Table ID of the table to delete</param>
        public virtual DeleteRequest Delete(string projectId, string datasetId, string tableId)
        {
            return new DeleteRequest(service, projectId, datasetId, tableId);
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

            /// <summary>Project ID of the table to delete</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Dataset ID of the table to delete</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Table ID of the table to delete</summary>
            [Google.Apis.Util.RequestParameterAttribute("tableId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string TableId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{projectId}/datasets/{datasetId}/tables/{tableId}";

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
                    Pattern = null,
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("tableId", new Google.Apis.Discovery.Parameter
                {
                    Name = "tableId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Gets the specified table resource by table ID. This method does not return the data in the table, it only
        /// returns the table resource, which describes the structure of this table.
        /// </summary>
        /// <param name="projectId">Project ID of the requested table</param>
        /// <param name="datasetId">Dataset ID of the requested table</param>
        /// <param name="tableId">Table ID of the requested table</param>
        public virtual GetRequest Get(string projectId, string datasetId, string tableId)
        {
            return new GetRequest(service, projectId, datasetId, tableId);
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

            /// <summary>Project ID of the requested table</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Dataset ID of the requested table</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Table ID of the requested table</summary>
            [Google.Apis.Util.RequestParameterAttribute("tableId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string TableId { get; private set; }

            /// <summary>List of fields to return (comma-separated). If unspecified, all fields are returned</summary>
            [Google.Apis.Util.RequestParameterAttribute("selectedFields", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string SelectedFields { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{projectId}/datasets/{datasetId}/tables/{tableId}";

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
                    Pattern = null,
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("tableId", new Google.Apis.Discovery.Parameter
                {
                    Name = "tableId",
                    IsRequired = true,
                    ParameterType = "path",
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
            }
        }

        /// <summary>
        /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does not
        /// have a policy set.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
        /// appropriate value for this field.
        /// </param>
        public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.Bigquery.v2.Data.GetIamPolicyRequest body, string resource)
        {
            return new GetIamPolicyRequest(service, body, resource);
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
            /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
            /// appropriate value for this field.
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
        /// <param name="projectId">Project ID of the new table</param>
        /// <param name="datasetId">Dataset ID of the new table</param>
        public virtual InsertRequest Insert(Google.Apis.Bigquery.v2.Data.Table body, string projectId, string datasetId)
        {
            return new InsertRequest(service, body, projectId, datasetId);
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

            /// <summary>Project ID of the new table</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Dataset ID of the new table</summary>
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
            public override string RestPath => "projects/{projectId}/datasets/{datasetId}/tables";

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
                    Pattern = null,
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists all tables in the specified dataset. Requires the READER dataset role.</summary>
        /// <param name="projectId">Project ID of the tables to list</param>
        /// <param name="datasetId">Dataset ID of the tables to list</param>
        public virtual ListRequest List(string projectId, string datasetId)
        {
            return new ListRequest(service, projectId, datasetId);
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

            /// <summary>Project ID of the tables to list</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Dataset ID of the tables to list</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Maximum number of results to return</summary>
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
            public override string RestPath => "projects/{projectId}/datasets/{datasetId}/tables";

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
                    Pattern = null,
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
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
        /// Updates information in an existing table. The update method replaces the entire table resource, whereas the
        /// patch method only replaces fields that are provided in the submitted table resource. This method supports
        /// patch semantics.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Project ID of the table to update</param>
        /// <param name="datasetId">Dataset ID of the table to update</param>
        /// <param name="tableId">Table ID of the table to update</param>
        public virtual PatchRequest Patch(Google.Apis.Bigquery.v2.Data.Table body, string projectId, string datasetId, string tableId)
        {
            return new PatchRequest(service, body, projectId, datasetId, tableId);
        }

        /// <summary>
        /// Updates information in an existing table. The update method replaces the entire table resource, whereas the
        /// patch method only replaces fields that are provided in the submitted table resource. This method supports
        /// patch semantics.
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

            /// <summary>Project ID of the table to update</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Dataset ID of the table to update</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Table ID of the table to update</summary>
            [Google.Apis.Util.RequestParameterAttribute("tableId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string TableId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.Table Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{projectId}/datasets/{datasetId}/tables/{tableId}";

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
                    Pattern = null,
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("tableId", new Google.Apis.Discovery.Parameter
                {
                    Name = "tableId",
                    IsRequired = true,
                    ParameterType = "path",
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
        /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
        /// appropriate value for this field.
        /// </param>
        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Bigquery.v2.Data.SetIamPolicyRequest body, string resource)
        {
            return new SetIamPolicyRequest(service, body, resource);
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
            /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
            /// appropriate value for this field.
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
        /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation for
        /// the appropriate value for this field.
        /// </param>
        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Bigquery.v2.Data.TestIamPermissionsRequest body, string resource)
        {
            return new TestIamPermissionsRequest(service, body, resource);
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
            /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation
            /// for the appropriate value for this field.
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
        /// Updates information in an existing table. The update method replaces the entire table resource, whereas the
        /// patch method only replaces fields that are provided in the submitted table resource.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Project ID of the table to update</param>
        /// <param name="datasetId">Dataset ID of the table to update</param>
        /// <param name="tableId">Table ID of the table to update</param>
        public virtual UpdateRequest Update(Google.Apis.Bigquery.v2.Data.Table body, string projectId, string datasetId, string tableId)
        {
            return new UpdateRequest(service, body, projectId, datasetId, tableId);
        }

        /// <summary>
        /// Updates information in an existing table. The update method replaces the entire table resource, whereas the
        /// patch method only replaces fields that are provided in the submitted table resource.
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

            /// <summary>Project ID of the table to update</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Dataset ID of the table to update</summary>
            [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DatasetId { get; private set; }

            /// <summary>Table ID of the table to update</summary>
            [Google.Apis.Util.RequestParameterAttribute("tableId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string TableId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Bigquery.v2.Data.Table Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "projects/{projectId}/datasets/{datasetId}/tables/{tableId}";

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
                    Pattern = null,
                });
                RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "datasetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("tableId", new Google.Apis.Discovery.Parameter
                {
                    Name = "tableId",
                    IsRequired = true,
                    ParameterType = "path",
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
        /// threshold. For multi-class classfication models this is the confidence threshold.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threshold")]
        public virtual System.Nullable<double> Threshold { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Input/output argument of a function or a stored procedure.</summary>
    public class Argument : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Defaults to FIXED_TYPE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("argumentKind")]
        public virtual string ArgumentKind { get; set; }

        /// <summary>Required unless argument_kind = ANY_TYPE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual StandardSqlDataType DataType { get; set; }

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

    public class BiEngineReason : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Output-only] High-level BI Engine reason for partial or disabled acceleration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>[Output-only] Free form human-readable reason for partial or disabled acceleration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BiEngineStatistics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Output-only] Specifies which mode of BI Engine acceleration was performed (if any).</summary>
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

    public class BigQueryModelTraining : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Output-only, Beta] Index of current ML training iteration. Updated during create model query job to show
        /// job progress.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentIteration")]
        public virtual System.Nullable<int> CurrentIteration { get; set; }

        /// <summary>
        /// [Output-only, Beta] Expected number of iterations for the create model query job specified as num_iterations
        /// in the input query. The actual total number of iterations may be less than this number due to early stop.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedTotalIterations")]
        public virtual System.Nullable<long> ExpectedTotalIterations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BigtableColumn : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Optional] The encoding of the values when the type is not STRING. Acceptable encoding values are: TEXT -
        /// indicates values are alphanumeric text strings. BINARY - indicates values are encoded using HBase
        /// Bytes.toBytes family of functions. 'encoding' can also be set at the column family level. However, the
        /// setting at this level takes precedence if 'encoding' is set at both levels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        /// <summary>
        /// [Optional] If the qualifier is not a valid BigQuery field identifier i.e. does not match
        /// [a-zA-Z][a-zA-Z0-9_]*, a valid identifier must be provided as the column field name and is used as field
        /// name in queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldName")]
        public virtual string FieldName { get; set; }

        /// <summary>
        /// [Optional] If this is set, only the latest version of value in this column are exposed. 'onlyReadLatest' can
        /// also be set at the column family level. However, the setting at this level takes precedence if
        /// 'onlyReadLatest' is set at both levels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onlyReadLatest")]
        public virtual System.Nullable<bool> OnlyReadLatest { get; set; }

        /// <summary>
        /// [Required] Qualifier of the column. Columns in the parent column family that has this exact qualifier are
        /// exposed as . field. If the qualifier is valid UTF-8 string, it can be specified in the qualifier_string
        /// field. Otherwise, a base-64 encoded value must be set to qualifier_encoded. The column field name is the
        /// same as the column qualifier. However, if the qualifier is not a valid BigQuery field identifier i.e. does
        /// not match [a-zA-Z][a-zA-Z0-9_]*, a valid identifier must be provided as field_name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("qualifierEncoded")]
        public virtual string QualifierEncoded { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("qualifierString")]
        public virtual string QualifierString { get; set; }

        /// <summary>
        /// [Optional] The type to convert the value in cells of this column. The values are expected to be encoded
        /// using HBase Bytes.toBytes function when using the BINARY encoding value. Following BigQuery types are
        /// allowed (case-sensitive) - BYTES STRING INTEGER FLOAT BOOLEAN Default type is BYTES. 'type' can also be set
        /// at the column family level. However, the setting at this level takes precedence if 'type' is set at both
        /// levels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BigtableColumnFamily : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Optional] Lists of columns that should be exposed as individual fields as opposed to a list of (column
        /// name, value) pairs. All columns whose qualifier matches a qualifier in this list can be accessed as .. Other
        /// columns can be accessed as a list through .Column field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual System.Collections.Generic.IList<BigtableColumn> Columns { get; set; }

        /// <summary>
        /// [Optional] The encoding of the values when the type is not STRING. Acceptable encoding values are: TEXT -
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
        /// [Optional] If this is set only the latest version of value are exposed for all columns in this column
        /// family. This can be overridden for a specific column by listing that column in 'columns' and specifying a
        /// different setting for that column.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onlyReadLatest")]
        public virtual System.Nullable<bool> OnlyReadLatest { get; set; }

        /// <summary>
        /// [Optional] The type to convert the value in cells of this column family. The values are expected to be
        /// encoded using HBase Bytes.toBytes function when using the BINARY encoding value. Following BigQuery types
        /// are allowed (case-sensitive) - BYTES STRING INTEGER FLOAT BOOLEAN Default type is BYTES. This can be
        /// overridden for a specific column by listing that column in 'columns' and specifying a type for it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BigtableOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Optional] List of column families to expose in the table schema along with their types. This list restricts
        /// the column families that can be referenced in queries and specifies their value types. You can use this list
        /// to do type conversions - see the 'type' field for more details. If you leave this list empty, all column
        /// families are present in the table schema and their values are read as BYTES. During a query only the column
        /// families referenced in that query are read from Bigtable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnFamilies")]
        public virtual System.Collections.Generic.IList<BigtableColumnFamily> ColumnFamilies { get; set; }

        /// <summary>
        /// [Optional] If field is true, then the column families that are not specified in columnFamilies list are not
        /// exposed in the table schema. Otherwise, they are read with BYTES type values. The default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreUnspecifiedColumnFamilies")]
        public virtual System.Nullable<bool> IgnoreUnspecifiedColumnFamilies { get; set; }

        /// <summary>
        /// [Optional] If field is true, then the rowkey column families will be read and converted to string. Otherwise
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

    public class BqmlIterationResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Output-only, Beta] Time taken to run the training iteration in milliseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("durationMs")]
        public virtual System.Nullable<long> DurationMs { get; set; }

        /// <summary>
        /// [Output-only, Beta] Eval loss computed on the eval data at the end of the iteration. The eval loss is used
        /// for early stopping to avoid overfitting. No eval loss if eval_split_method option is specified as no_split
        /// or auto_split with input data size less than 500 rows.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evalLoss")]
        public virtual System.Nullable<double> EvalLoss { get; set; }

        /// <summary>
        /// [Output-only, Beta] Index of the ML training iteration, starting from zero for each training run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>
        /// [Output-only, Beta] Learning rate used for this iteration, it varies for different training iterations if
        /// learn_rate_strategy option is not constant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("learnRate")]
        public virtual System.Nullable<double> LearnRate { get; set; }

        /// <summary>
        /// [Output-only, Beta] Training loss computed on the training data at the end of the iteration. The training
        /// loss function is defined by model type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingLoss")]
        public virtual System.Nullable<double> TrainingLoss { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BqmlTrainingRun : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Output-only, Beta] List of each iteration results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iterationResults")]
        public virtual System.Collections.Generic.IList<BqmlIterationResult> IterationResults { get; set; }

        /// <summary>[Output-only, Beta] Training run start time in milliseconds since the epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> StartTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(StartTimeRaw);
            set => StartTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// [Output-only, Beta] Different state applicable for a training run. IN PROGRESS: Training run is in progress.
        /// FAILED: Training run ended due to a non-retryable failure. SUCCEEDED: Training run successfully completed.
        /// CANCELLED: Training run cancelled by the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// [Output-only, Beta] Training options used by this training run. These options are mutable for subsequent
        /// training runs. Default values are explicitly stored for options not specified in the input query of the
        /// first training run. For subsequent training runs, any option not explicitly specified in the input query
        /// will be copied from the previous training run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingOptions")]
        public virtual TrainingOptionsData TrainingOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>
        /// [Output-only, Beta] Training options used by this training run. These options are mutable for subsequent
        /// training runs. Default values are explicitly stored for options not specified in the input query of the
        /// first training run. For subsequent training runs, any option not explicitly specified in the input query
        /// will be copied from the previous training run.
        /// </summary>
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

    public class Clustering : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Repeated] One or more fields on which data should be clustered. Only top-level, non-repeated, simple-type
        /// fields are supported. When you cluster a table using multiple columns, the order of columns you specify is
        /// important. The order of the specified columns determines the sort order of the data.
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

    public class ConnectionProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Required] Name of the connection property to set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>[Required] Value of the connection property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CsvOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Optional] Indicates if BigQuery should accept rows that are missing trailing optional columns. If true,
        /// BigQuery treats missing trailing columns as null values. If false, records with missing trailing columns are
        /// treated as bad records, and if there are too many bad records, an invalid error is returned in the job
        /// result. The default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowJaggedRows")]
        public virtual System.Nullable<bool> AllowJaggedRows { get; set; }

        /// <summary>
        /// [Optional] Indicates if BigQuery should allow quoted data sections that contain newline characters in a CSV
        /// file. The default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowQuotedNewlines")]
        public virtual System.Nullable<bool> AllowQuotedNewlines { get; set; }

        /// <summary>
        /// [Optional] The character encoding of the data. The supported values are UTF-8 or ISO-8859-1. The default
        /// value is UTF-8. BigQuery decodes the data after the raw, binary data has been split using the values of the
        /// quote and fieldDelimiter properties.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        /// <summary>
        /// [Optional] The separator for fields in a CSV file. BigQuery converts the string to ISO-8859-1 encoding, and
        /// then uses the first byte of the encoded string to split the data in its raw, binary state. BigQuery also
        /// supports the escape sequence "\t" to specify a tab separator. The default value is a comma (',').
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldDelimiter")]
        public virtual string FieldDelimiter { get; set; }

        /// <summary>
        /// [Optional] The value that is used to quote data sections in a CSV file. BigQuery converts the string to
        /// ISO-8859-1 encoding, and then uses the first byte of the encoded string to split the data in its raw, binary
        /// state. The default value is a double-quote ('"'). If your data does not contain quoted sections, set the
        /// property value to an empty string. If your data contains quoted newline characters, you must also set the
        /// allowQuotedNewlines property to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quote")]
        public virtual string Quote { get; set; }

        /// <summary>
        /// [Optional] The number of rows at the top of a CSV file that BigQuery will skip when reading the data. The
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

        /// <summary>Table reference of the training data after split.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingTable")]
        public virtual TableReference TrainingTable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Dataset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Optional] An array of objects that define dataset access for one or more entities. You can set this
        /// property when inserting or updating a dataset in order to control who is allowed to access the data. If
        /// unspecified at dataset creation time, BigQuery adds default dataset access for the following entities:
        /// access.specialGroup: projectReaders; access.role: READER; access.specialGroup: projectWriters; access.role:
        /// WRITER; access.specialGroup: projectOwners; access.role: OWNER; access.userByEmail: [dataset creator email];
        /// access.role: OWNER;
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("access")]
        public virtual System.Collections.Generic.IList<AccessData> Access { get; set; }

        /// <summary>[Output-only] The time when this dataset was created, in milliseconds since the epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual System.Nullable<long> CreationTime { get; set; }

        /// <summary>[Required] A reference that identifies the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetReference")]
        public virtual DatasetReference DatasetReference { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("defaultEncryptionConfiguration")]
        public virtual EncryptionConfiguration DefaultEncryptionConfiguration { get; set; }

        /// <summary>
        /// [Optional] The default partition expiration for all partitioned tables in the dataset, in milliseconds. Once
        /// this property is set, all newly-created partitioned tables in the dataset will have an expirationMs property
        /// in the timePartitioning settings set to this value, and changing the value will only affect new tables, not
        /// existing ones. The storage in a partition will have an expiration time of its partition time plus this
        /// value. Setting this property overrides the use of defaultTableExpirationMs for partitioned tables: only one
        /// of defaultTableExpirationMs and defaultPartitionExpirationMs will be used for any new partitioned table. If
        /// you provide an explicit timePartitioning.expirationMs when creating or updating a partitioned table, that
        /// value takes precedence over the default partition expiration time indicated by this property.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultPartitionExpirationMs")]
        public virtual System.Nullable<long> DefaultPartitionExpirationMs { get; set; }

        /// <summary>
        /// [Optional] The default lifetime of all tables in the dataset, in milliseconds. The minimum value is 3600000
        /// milliseconds (one hour). Once this property is set, all newly-created tables in the dataset will have an
        /// expirationTime property set to the creation time plus the value in this property, and changing the value
        /// will only affect new tables, not existing ones. When the expirationTime for a given table is reached, that
        /// table will be deleted automatically. If a table's expirationTime is modified or removed before the table
        /// expires, or if you provide an explicit expirationTime when creating a table, that value takes precedence
        /// over the default expiration time indicated by this property.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultTableExpirationMs")]
        public virtual System.Nullable<long> DefaultTableExpirationMs { get; set; }

        /// <summary>[Optional] A user-friendly description of the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>[Output-only] A hash of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>[Optional] A descriptive name for the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("friendlyName")]
        public virtual string FriendlyName { get; set; }

        /// <summary>
        /// [Output-only] The fully-qualified unique name of the dataset in the format projectId:datasetId. The dataset
        /// name without the project name is given in the datasetId field. When creating a new dataset, leave this field
        /// blank, and instead specify the datasetId field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>[Output-only] The resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The labels associated with this dataset. You can use these to organize and group your datasets. You can set
        /// this property when inserting or updating a dataset. See Creating and Updating Dataset Labels for more
        /// information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// [Output-only] The date when this dataset or any of its tables was last modified, in milliseconds since the
        /// epoch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifiedTime")]
        public virtual System.Nullable<long> LastModifiedTime { get; set; }

        /// <summary>
        /// The geographic location where the dataset should reside. The default value is US. See details at
        /// https://cloud.google.com/bigquery/docs/locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>[Output-only] Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPZS")]
        public virtual System.Nullable<bool> SatisfiesPZS { get; set; }

        /// <summary>
        /// [Output-only] A URL that can be used to access the resource again. You can use this URL in Get or Update
        /// requests to the resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>
        /// [Optional] An array of objects that define dataset access for one or more entities. You can set this
        /// property when inserting or updating a dataset in order to control who is allowed to access the data. If
        /// unspecified at dataset creation time, BigQuery adds default dataset access for the following entities:
        /// access.specialGroup: projectReaders; access.role: READER; access.specialGroup: projectWriters; access.role:
        /// WRITER; access.specialGroup: projectOwners; access.role: OWNER; access.userByEmail: [dataset creator email];
        /// access.role: OWNER;
        /// </summary>
        public class AccessData
        {
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
            /// [Required] An IAM role ID that should be granted to the user, group, or domain specified in this access
            /// entry. The following legacy mappings will be applied: OWNER  roles/bigquery.dataOwner WRITER
            /// roles/bigquery.dataEditor READER  roles/bigquery.dataViewer This field will accept any of the above
            /// formats, but will return only the legacy format. For example, if you set this field to
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
            /// [Pick one] A special group to grant access to. Possible values include: projectOwners: Owners of the
            /// enclosing project. projectReaders: Readers of the enclosing project. projectWriters: Writers of the
            /// enclosing project. allAuthenticatedUsers: All authenticated BigQuery users. Maps to similarly-named IAM
            /// members.
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
            /// have read access to tables in this dataset. The role field is not required when this field is set. If
            /// that view is updated by any user, access to the view needs to be granted again via an update operation.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("view")]
            public virtual TableReference View { get; set; }
        }
    }

    public class DatasetAccessEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Required] The dataset this entry applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual DatasetReference Dataset { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("target_types")]
        public virtual System.Collections.Generic.IList<TargetTypesData> TargetTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        public class TargetTypesData
        {
            /// <summary>
            /// [Required] Which resources in the dataset this entry applies to. Currently, only views are supported,
            /// but additional target types may be added in the future. Possible values: VIEWS: This entry applies to
            /// all views in the dataset.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("targetType")]
            public virtual string TargetType { get; set; }
        }
    }

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
        /// A hash value of the results page. You can use this property to determine if the page has changed since the
        /// last request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The list type. This property always returns the value "bigquery#datasetList".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// A token that can be used to request the next results page. This property is omitted on the final results
        /// page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

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

            /// <summary>A descriptive name for the dataset, if one exists.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("friendlyName")]
            public virtual string FriendlyName { get; set; }

            /// <summary>The fully-qualified, unique, opaque ID of the dataset.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("id")]
            public virtual string Id { get; set; }

            /// <summary>The resource type. This property always returns the value "bigquery#dataset".</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("kind")]
            public virtual string Kind { get; set; }

            /// <summary>
            /// The labels associated with this dataset. You can use these to organize and group your datasets.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("labels")]
            public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

            /// <summary>The geographic location where the data resides.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("location")]
            public virtual string Location { get; set; }
        }
    }

    public class DatasetReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Required] A unique ID for this dataset, without the project name. The ID must contain only letters (a-z,
        /// A-Z), numbers (0-9), or underscores (_). The maximum length is 1,024 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetId")]
        public virtual string DatasetId { get; set; }

        /// <summary>[Optional] The ID of the project containing this dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DestinationTableProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Optional] The description for the destination table. This will only be used if the destination table is
        /// newly created. If the table already exists and a value different than the current description is provided,
        /// the job will fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// [Optional] The friendly name for the destination table. This will only be used if the destination table is
        /// newly created. If the table already exists and a value different than the current friendly name is provided,
        /// the job will fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("friendlyName")]
        public virtual string FriendlyName { get; set; }

        /// <summary>
        /// [Optional] The labels associated with this table. You can use these to organize and group your tables. This
        /// will only be used if the destination table is newly created. If the table already exists and labels are
        /// different than the current labels are provided, the job will fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DmlStatistics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of deleted Rows. populated by DML DELETE, MERGE and TRUNCATE statements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletedRowCount")]
        public virtual System.Nullable<long> DeletedRowCount { get; set; }

        /// <summary>Number of inserted Rows. Populated by DML INSERT and MERGE statements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertedRowCount")]
        public virtual System.Nullable<long> InsertedRowCount { get; set; }

        /// <summary>Number of updated Rows. Populated by DML UPDATE and MERGE statements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatedRowCount")]
        public virtual System.Nullable<long> UpdatedRowCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EncryptionConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Optional] Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table.
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

    public class ExplainQueryStage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of parallel input segments completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completedParallelInputs")]
        public virtual System.Nullable<long> CompletedParallelInputs { get; set; }

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

        /// <summary>Stage end time represented as milliseconds since epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endMs")]
        public virtual System.Nullable<long> EndMs { get; set; }

        /// <summary>Unique ID for stage within plan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>IDs for stages that are inputs to this stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputStages")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> InputStages { get; set; }

        /// <summary>Human-readable name for stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Number of parallel input segments to be processed.</summary>
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

        /// <summary>Stage start time represented as milliseconds since epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startMs")]
        public virtual System.Nullable<long> StartMs { get; set; }

        /// <summary>Current status for the stage.</summary>
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

    public class ExplainQueryStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Machine-readable operation type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Human-readable stage descriptions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("substeps")]
        public virtual System.Collections.Generic.IList<string> Substeps { get; set; }

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

    public class ExternalDataConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Try to detect schema and format options automatically. Any option specified explicitly will be honored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autodetect")]
        public virtual System.Nullable<bool> Autodetect { get; set; }

        /// <summary>[Optional] Additional options if sourceFormat is set to BIGTABLE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigtableOptions")]
        public virtual BigtableOptions BigtableOptions { get; set; }

        /// <summary>
        /// [Optional] The compression type of the data source. Possible values include GZIP and NONE. The default value
        /// is NONE. This setting is ignored for Google Cloud Bigtable, Google Cloud Datastore backups and Avro formats.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compression")]
        public virtual string Compression { get; set; }

        /// <summary>[Optional, Trusted Tester] Connection for external data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionId")]
        public virtual string ConnectionId { get; set; }

        /// <summary>Additional properties to set if sourceFormat is set to CSV.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("csvOptions")]
        public virtual CsvOptions CsvOptions { get; set; }

        /// <summary>
        /// [Optional] Defines the list of possible SQL data types to which the source decimal values are converted.
        /// This list and the precision and the scale parameters of the decimal field determine the target type. In the
        /// order of NUMERIC, BIGNUMERIC, and STRING, a type is picked if it is in the specified list and if it supports
        /// the precision and the scale. STRING supports all precision and scale values. If none of the listed types
        /// supports the precision and the scale, the type supporting the widest range in the specified list is picked,
        /// and if a value exceeds the supported range when reading the data, an error will be thrown. Example: Suppose
        /// the value of this field is ["NUMERIC", "BIGNUMERIC"]. If (precision,scale) is: (38,9) -&amp;gt; NUMERIC;
        /// (39,9) -&amp;gt; BIGNUMERIC (NUMERIC cannot hold 30 integer digits); (38,10) -&amp;gt; BIGNUMERIC (NUMERIC
        /// cannot hold 10 fractional digits); (76,38) -&amp;gt; BIGNUMERIC; (77,38) -&amp;gt; BIGNUMERIC (error if
        /// value exeeds supported range). This field cannot contain duplicate types. The order of the types in this
        /// field is ignored. For example, ["BIGNUMERIC", "NUMERIC"] is the same as ["NUMERIC", "BIGNUMERIC"] and
        /// NUMERIC always takes precedence over BIGNUMERIC. Defaults to ["NUMERIC", "STRING"] for ORC and ["NUMERIC"]
        /// for the other file formats.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("decimalTargetTypes")]
        public virtual System.Collections.Generic.IList<string> DecimalTargetTypes { get; set; }

        /// <summary>[Optional] Additional options if sourceFormat is set to GOOGLE_SHEETS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleSheetsOptions")]
        public virtual GoogleSheetsOptions GoogleSheetsOptions { get; set; }

        /// <summary>[Optional] Options to configure hive partitioning support.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hivePartitioningOptions")]
        public virtual HivePartitioningOptions HivePartitioningOptions { get; set; }

        /// <summary>
        /// [Optional] Indicates if BigQuery should allow extra values that are not represented in the table schema. If
        /// true, the extra values are ignored. If false, records with extra columns are treated as bad records, and if
        /// there are too many bad records, an invalid error is returned in the job result. The default value is false.
        /// The sourceFormat property determines what BigQuery treats as an extra value: CSV: Trailing columns JSON:
        /// Named values that don't match any column names Google Cloud Bigtable: This setting is ignored. Google Cloud
        /// Datastore backups: This setting is ignored. Avro: This setting is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreUnknownValues")]
        public virtual System.Nullable<bool> IgnoreUnknownValues { get; set; }

        /// <summary>
        /// [Optional] The maximum number of bad records that BigQuery can ignore when reading data. If the number of
        /// bad records exceeds this value, an invalid error is returned in the job result. This is only valid for CSV,
        /// JSON, and Google Sheets. The default value is 0, which requires that all records are valid. This setting is
        /// ignored for Google Cloud Bigtable, Google Cloud Datastore backups and Avro formats.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxBadRecords")]
        public virtual System.Nullable<int> MaxBadRecords { get; set; }

        /// <summary>Additional properties to set if sourceFormat is set to Parquet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parquetOptions")]
        public virtual ParquetOptions ParquetOptions { get; set; }

        /// <summary>
        /// [Optional] The schema for the data. Schema is required for CSV and JSON formats. Schema is disallowed for
        /// Google Cloud Bigtable, Cloud Datastore backups, and Avro formats.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual TableSchema Schema { get; set; }

        /// <summary>
        /// [Required] The data format. For CSV files, specify "CSV". For Google sheets, specify "GOOGLE_SHEETS". For
        /// newline-delimited JSON, specify "NEWLINE_DELIMITED_JSON". For Avro files, specify "AVRO". For Google Cloud
        /// Datastore backups, specify "DATASTORE_BACKUP". [Beta] For Google Cloud Bigtable, specify "BIGTABLE".
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
        /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests specifying an
        /// invalid value will be rejected. Requests for policies with any conditional bindings must specify version 3.
        /// Policies without any conditional bindings may specify any valid value or leave the field unset. To learn
        /// which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedPolicyVersion")]
        public virtual System.Nullable<int> RequestedPolicyVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GetQueryResultsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the query result was fetched from the query cache.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheHit")]
        public virtual System.Nullable<bool> CacheHit { get; set; }

        /// <summary>
        /// [Output-only] The first errors or warnings encountered during the running of the job. The final message
        /// includes the number of errors that caused the process to stop. Errors here do not necessarily mean that the
        /// job has completed or was unsuccessful.
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
        /// [Output-only] The number of rows affected by a DML statement. Present only for DML statements INSERT, UPDATE
        /// or DELETE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numDmlAffectedRows")]
        public virtual System.Nullable<long> NumDmlAffectedRows { get; set; }

        /// <summary>A token used for paging results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// An object with as many results as can be contained within the maximum permitted reply size. To get any
        /// additional rows, you can call GetQueryResults and specify the jobReference returned above. Present only when
        /// the query completes successfully.
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

    public class GoogleSheetsOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Optional] Range of a sheet to query from. Only used when non-empty. Typical format:
        /// sheet_name!top_left_cell_id:bottom_right_cell_id For example: sheet1!A1:B20
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual string Range { get; set; }

        /// <summary>
        /// [Optional] The number of rows at the top of a sheet that BigQuery will skip when reading the data. The
        /// default value is 0. This property is useful if you have header rows that should be skipped. When autodetect
        /// is on, behavior is the following: * skipLeadingRows unspecified - Autodetect tries to detect headers in the
        /// first row. If they are not detected, the row is read as data. Otherwise data is read starting from the
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

    public class HivePartitioningOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Optional] When set, what mode of hive partitioning to use when reading data. The following modes are
        /// supported. (1) AUTO: automatically infer partition key name(s) and type(s). (2) STRINGS: automatically infer
        /// partition key name(s). All types are interpreted as strings. (3) CUSTOM: partition key schema is encoded in
        /// the source URI prefix. Not all storage formats support hive partitioning. Requesting hive partitioning on an
        /// unsupported format will lead to an error. Currently supported types include: AVRO, CSV, JSON, ORC and
        /// Parquet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>
        /// [Optional] If set to true, queries over this table require a partition filter that can be used for partition
        /// elimination to be specified. Note that this field should only be true when creating a permanent external
        /// table or querying a temporary external table. Hive-partitioned loads with requirePartitionFilter explicitly
        /// set to true will fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requirePartitionFilter")]
        public virtual System.Nullable<bool> RequirePartitionFilter { get; set; }

        /// <summary>
        /// [Optional] When hive partition detection is requested, a common prefix for all source uris should be
        /// supplied. The prefix must end immediately before the partition key encoding begins. For example, consider
        /// files following this data layout. gs://bucket/path_to_table/dt=2019-01-01/country=BR/id=7/file.avro
        /// gs://bucket/path_to_table/dt=2018-12-31/country=CA/id=3/file.avro When hive partitioning is requested with
        /// either AUTO or STRINGS detection, the common prefix can be either of gs://bucket/path_to_table or
        /// gs://bucket/path_to_table/ (trailing slash does not matter).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceUriPrefix")]
        public virtual string SourceUriPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a single iteration of the training run.</summary>
    public class IterationResult : Google.Apis.Requests.IDirectResponseSchema
    {
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

        /// <summary>Loss computed on the training data at the end of iteration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingLoss")]
        public virtual System.Nullable<double> TrainingLoss { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Job : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Required] Describes the job configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configuration")]
        public virtual JobConfiguration Configuration { get; set; }

        /// <summary>[Output-only] A hash of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>[Output-only] Opaque ID field of the job</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>[Optional] Reference describing the unique-per-user name of the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobReference")]
        public virtual JobReference JobReference { get; set; }

        /// <summary>[Output-only] The type of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>[Output-only] A URL that can be used to access this resource again.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>
        /// [Output-only] Information about the job, including starting time and ending time of the job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statistics")]
        public virtual JobStatistics Statistics { get; set; }

        /// <summary>
        /// [Output-only] The status of this job. Examine this value when polling an asynchronous job to see if the job
        /// is complete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual JobStatus Status { get; set; }

        /// <summary>[Output-only] Email address of the user who ran the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user_email")]
        public virtual string UserEmail { get; set; }
    }

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
        /// [Optional] If set, don't actually run this job. A valid query will return a mostly empty response with some
        /// processing statistics, while an invalid query will return the same error it would if it wasn't a dry run.
        /// Behavior of non-query jobs is undefined.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dryRun")]
        public virtual System.Nullable<bool> DryRun { get; set; }

        /// <summary>[Pick one] Configures an extract job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extract")]
        public virtual JobConfigurationExtract Extract { get; set; }

        /// <summary>
        /// [Optional] Job timeout in milliseconds. If this time limit is exceeded, BigQuery may attempt to terminate
        /// the job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobTimeoutMs")]
        public virtual System.Nullable<long> JobTimeoutMs { get; set; }

        /// <summary>[Output-only] The type of the job. Can be QUERY, LOAD, EXTRACT, COPY or UNKNOWN.</summary>
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class JobConfigurationExtract : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Optional] The compression type to use for exported files. Possible values include GZIP, DEFLATE, SNAPPY,
        /// and NONE. The default value is NONE. DEFLATE and SNAPPY are only supported for Avro. Not applicable when
        /// extracting models.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compression")]
        public virtual string Compression { get; set; }

        /// <summary>
        /// [Optional] The exported file format. Possible values include CSV, NEWLINE_DELIMITED_JSON, PARQUET or AVRO
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
        /// [Optional] Delimiter to use between fields in the exported data. Default is ','. Not applicable when
        /// extracting models.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldDelimiter")]
        public virtual string FieldDelimiter { get; set; }

        /// <summary>
        /// [Optional] Whether to print out a header row in the results. Default is true. Not applicable when extracting
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
        /// [Optional] If destinationFormat is set to "AVRO", this flag indicates whether to enable extracting
        /// applicable column types (such as TIMESTAMP) to their corresponding AVRO logical types (timestamp-micros),
        /// instead of only using their raw types (avro-long). Not applicable when extracting models.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useAvroLogicalTypes")]
        public virtual System.Nullable<bool> UseAvroLogicalTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class JobConfigurationLoad : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Optional] Accept rows that are missing trailing optional columns. The missing values are treated as nulls.
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
        /// [Optional] Indicates if we should automatically infer the options and schema for CSV and JSON sources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autodetect")]
        public virtual System.Nullable<bool> Autodetect { get; set; }

        /// <summary>
        /// [Beta] Clustering specification for the destination table. Must be specified with time-based partitioning,
        /// data in the table will be first partitioned and subsequently clustered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clustering")]
        public virtual Clustering Clustering { get; set; }

        /// <summary>
        /// [Optional] Specifies whether the job is allowed to create new tables. The following values are supported:
        /// CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table. CREATE_NEVER: The table must
        /// already exist. If it does not, a 'notFound' error is returned in the job result. The default value is
        /// CREATE_IF_NEEDED. Creation, truncation and append actions occur as one atomic update upon job completion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createDisposition")]
        public virtual string CreateDisposition { get; set; }

        /// <summary>
        /// [Optional] Defines the list of possible SQL data types to which the source decimal values are converted.
        /// This list and the precision and the scale parameters of the decimal field determine the target type. In the
        /// order of NUMERIC, BIGNUMERIC, and STRING, a type is picked if it is in the specified list and if it supports
        /// the precision and the scale. STRING supports all precision and scale values. If none of the listed types
        /// supports the precision and the scale, the type supporting the widest range in the specified list is picked,
        /// and if a value exceeds the supported range when reading the data, an error will be thrown. Example: Suppose
        /// the value of this field is ["NUMERIC", "BIGNUMERIC"]. If (precision,scale) is: (38,9) -&amp;gt; NUMERIC;
        /// (39,9) -&amp;gt; BIGNUMERIC (NUMERIC cannot hold 30 integer digits); (38,10) -&amp;gt; BIGNUMERIC (NUMERIC
        /// cannot hold 10 fractional digits); (76,38) -&amp;gt; BIGNUMERIC; (77,38) -&amp;gt; BIGNUMERIC (error if
        /// value exeeds supported range). This field cannot contain duplicate types. The order of the types in this
        /// field is ignored. For example, ["BIGNUMERIC", "NUMERIC"] is the same as ["NUMERIC", "BIGNUMERIC"] and
        /// NUMERIC always takes precedence over BIGNUMERIC. Defaults to ["NUMERIC", "STRING"] for ORC and ["NUMERIC"]
        /// for the other file formats.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("decimalTargetTypes")]
        public virtual System.Collections.Generic.IList<string> DecimalTargetTypes { get; set; }

        /// <summary>Custom encryption configuration (e.g., Cloud KMS keys).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationEncryptionConfiguration")]
        public virtual EncryptionConfiguration DestinationEncryptionConfiguration { get; set; }

        /// <summary>[Required] The destination table to load the data into.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationTable")]
        public virtual TableReference DestinationTable { get; set; }

        /// <summary>[Beta] [Optional] Properties with which to create the destination table if it is new.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationTableProperties")]
        public virtual DestinationTableProperties DestinationTableProperties { get; set; }

        /// <summary>
        /// [Optional] The character encoding of the data. The supported values are UTF-8 or ISO-8859-1. The default
        /// value is UTF-8. BigQuery decodes the data after the raw, binary data has been split using the values of the
        /// quote and fieldDelimiter properties.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        /// <summary>
        /// [Optional] The separator for fields in a CSV file. The separator can be any ISO-8859-1 single-byte
        /// character. To use a character in the range 128-255, you must encode the character as UTF8. BigQuery converts
        /// the string to ISO-8859-1 encoding, and then uses the first byte of the encoded string to split the data in
        /// its raw, binary state. BigQuery also supports the escape sequence "\t" to specify a tab separator. The
        /// default value is a comma (',').
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldDelimiter")]
        public virtual string FieldDelimiter { get; set; }

        /// <summary>[Optional] Options to configure hive partitioning support.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hivePartitioningOptions")]
        public virtual HivePartitioningOptions HivePartitioningOptions { get; set; }

        /// <summary>
        /// [Optional] Indicates if BigQuery should allow extra values that are not represented in the table schema. If
        /// true, the extra values are ignored. If false, records with extra columns are treated as bad records, and if
        /// there are too many bad records, an invalid error is returned in the job result. The default value is false.
        /// The sourceFormat property determines what BigQuery treats as an extra value: CSV: Trailing columns JSON:
        /// Named values that don't match any column names
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreUnknownValues")]
        public virtual System.Nullable<bool> IgnoreUnknownValues { get; set; }

        /// <summary>
        /// [Optional] If sourceFormat is set to newline-delimited JSON, indicates whether it should be processed as a
        /// JSON variant such as GeoJSON. For a sourceFormat other than JSON, omit this field. If the sourceFormat is
        /// newline-delimited JSON: - for newline-delimited GeoJSON: set to GEOJSON.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonExtension")]
        public virtual string JsonExtension { get; set; }

        /// <summary>
        /// [Optional] The maximum number of bad records that BigQuery can ignore when running the job. If the number of
        /// bad records exceeds this value, an invalid error is returned in the job result. This is only valid for CSV
        /// and JSON. The default value is 0, which requires that all records are valid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxBadRecords")]
        public virtual System.Nullable<int> MaxBadRecords { get; set; }

        /// <summary>
        /// [Optional] Specifies a string that represents a null value in a CSV file. For example, if you specify "\N",
        /// BigQuery interprets "\N" as a null value when loading a CSV file. The default value is the empty string. If
        /// you set this property to a custom value, BigQuery throws an error if an empty string is present for all data
        /// types except for STRING and BYTE. For STRING and BYTE columns, BigQuery interprets the empty string as an
        /// empty value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullMarker")]
        public virtual string NullMarker { get; set; }

        /// <summary>[Optional] Options to configure parquet support.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parquetOptions")]
        public virtual ParquetOptions ParquetOptions { get; set; }

        /// <summary>
        /// If sourceFormat is set to "DATASTORE_BACKUP", indicates which entity properties to load into BigQuery from a
        /// Cloud Datastore backup. Property names are case sensitive and must be top-level properties. If no properties
        /// are specified, BigQuery loads all properties. If any named property isn't found in the Cloud Datastore
        /// backup, an invalid error is returned in the job result.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectionFields")]
        public virtual System.Collections.Generic.IList<string> ProjectionFields { get; set; }

        /// <summary>
        /// [Optional] The value that is used to quote data sections in a CSV file. BigQuery converts the string to
        /// ISO-8859-1 encoding, and then uses the first byte of the encoded string to split the data in its raw, binary
        /// state. The default value is a double-quote ('"'). If your data does not contain quoted sections, set the
        /// property value to an empty string. If your data contains quoted newline characters, you must also set the
        /// allowQuotedNewlines property to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quote")]
        public virtual string Quote { get; set; }

        /// <summary>
        /// [TrustedTester] Range partitioning specification for this table. Only one of timePartitioning and
        /// rangePartitioning should be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rangePartitioning")]
        public virtual RangePartitioning RangePartitioning { get; set; }

        /// <summary>
        /// [Optional] The schema for the destination table. The schema can be omitted if the destination table already
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
        /// overwrite the schema. One or more of the following values are specified: ALLOW_FIELD_ADDITION: allow adding
        /// a nullable field to the schema. ALLOW_FIELD_RELAXATION: allow relaxing a required field in the original
        /// schema to nullable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaUpdateOptions")]
        public virtual System.Collections.Generic.IList<string> SchemaUpdateOptions { get; set; }

        /// <summary>
        /// [Optional] The number of rows at the top of a CSV file that BigQuery will skip when loading the data. The
        /// default value is 0. This property is useful if you have header rows in the file that should be skipped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipLeadingRows")]
        public virtual System.Nullable<int> SkipLeadingRows { get; set; }

        /// <summary>
        /// [Optional] The format of the data files. For CSV files, specify "CSV". For datastore backups, specify
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

        /// <summary>
        /// Time-based partitioning specification for the destination table. Only one of timePartitioning and
        /// rangePartitioning should be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timePartitioning")]
        public virtual TimePartitioning TimePartitioning { get; set; }

        /// <summary>
        /// [Optional] If sourceFormat is set to "AVRO", indicates whether to enable interpreting logical types into
        /// their corresponding types (ie. TIMESTAMP), instead of only using their raw types (ie. INTEGER).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useAvroLogicalTypes")]
        public virtual System.Nullable<bool> UseAvroLogicalTypes { get; set; }

        /// <summary>
        /// [Optional] Specifies the action that occurs if the destination table already exists. The following values
        /// are supported: WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data.
        /// WRITE_APPEND: If the table already exists, BigQuery appends the data to the table. WRITE_EMPTY: If the table
        /// already exists and contains data, a 'duplicate' error is returned in the job result. The default value is
        /// WRITE_APPEND. Each action is atomic and only occurs if BigQuery is able to complete the job successfully.
        /// Creation, truncation and append actions occur as one atomic update upon job completion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeDisposition")]
        public virtual string WriteDisposition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class JobConfigurationQuery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Optional] If true and query uses legacy SQL dialect, allows the query to produce arbitrarily large result
        /// tables at a slight cost in performance. Requires destinationTable to be set. For standard SQL queries, this
        /// flag is ignored and large results are always allowed. However, you must still set destinationTable when
        /// result size exceeds the allowed maximum response size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowLargeResults")]
        public virtual System.Nullable<bool> AllowLargeResults { get; set; }

        /// <summary>
        /// [Beta] Clustering specification for the destination table. Must be specified with time-based partitioning,
        /// data in the table will be first partitioned and subsequently clustered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clustering")]
        public virtual Clustering Clustering { get; set; }

        /// <summary>Connection properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionProperties")]
        public virtual System.Collections.Generic.IList<ConnectionProperty> ConnectionProperties { get; set; }

        /// <summary>
        /// [Optional] Specifies whether the job is allowed to create new tables. The following values are supported:
        /// CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table. CREATE_NEVER: The table must
        /// already exist. If it does not, a 'notFound' error is returned in the job result. The default value is
        /// CREATE_IF_NEEDED. Creation, truncation and append actions occur as one atomic update upon job completion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createDisposition")]
        public virtual string CreateDisposition { get; set; }

        /// <summary>
        /// If true, creates a new session, where session id will be a server generated random id. If false, runs query
        /// with an existing session_id passed in ConnectionProperty, otherwise runs query in non-session mode.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createSession")]
        public virtual System.Nullable<bool> CreateSession { get; set; }

        /// <summary>
        /// [Optional] Specifies the default dataset to use for unqualified table names in the query. Note that this
        /// does not alter behavior of unqualified dataset names.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultDataset")]
        public virtual DatasetReference DefaultDataset { get; set; }

        /// <summary>Custom encryption configuration (e.g., Cloud KMS keys).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationEncryptionConfiguration")]
        public virtual EncryptionConfiguration DestinationEncryptionConfiguration { get; set; }

        /// <summary>
        /// [Optional] Describes the table where the query results should be stored. If not present, a new table will be
        /// created to store the results. This property must be set for large results that exceed the maximum response
        /// size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationTable")]
        public virtual TableReference DestinationTable { get; set; }

        /// <summary>
        /// [Optional] If true and query uses legacy SQL dialect, flattens all nested and repeated fields in the query
        /// results. allowLargeResults must be true if this is set to false. For standard SQL queries, this flag is
        /// ignored and results are never flattened.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flattenResults")]
        public virtual System.Nullable<bool> FlattenResults { get; set; }

        /// <summary>
        /// [Optional] Limits the billing tier for this job. Queries that have resource usage beyond this tier will fail
        /// (without incurring a charge). If unspecified, this will be set to your project default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumBillingTier")]
        public virtual System.Nullable<int> MaximumBillingTier { get; set; }

        /// <summary>
        /// [Optional] Limits the bytes billed for this job. Queries that will have bytes billed beyond this limit will
        /// fail (without incurring a charge). If unspecified, this will be set to your project default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumBytesBilled")]
        public virtual System.Nullable<long> MaximumBytesBilled { get; set; }

        /// <summary>
        /// Standard SQL only. Set to POSITIONAL to use positional (?) query parameters or to NAMED to use named
        /// (@myparam) query parameters in this query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterMode")]
        public virtual string ParameterMode { get; set; }

        /// <summary>[Deprecated] This property is deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preserveNulls")]
        public virtual System.Nullable<bool> PreserveNulls { get; set; }

        /// <summary>
        /// [Optional] Specifies a priority for the query. Possible values include INTERACTIVE and BATCH. The default
        /// value is INTERACTIVE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual string Priority { get; set; }

        /// <summary>
        /// [Required] SQL query text to execute. The useLegacySql field can be used to indicate whether the query uses
        /// legacy SQL or standard SQL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>Query parameters for standard SQL queries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryParameters")]
        public virtual System.Collections.Generic.IList<QueryParameter> QueryParameters { get; set; }

        /// <summary>
        /// [TrustedTester] Range partitioning specification for this table. Only one of timePartitioning and
        /// rangePartitioning should be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rangePartitioning")]
        public virtual RangePartitioning RangePartitioning { get; set; }

        /// <summary>
        /// Allows the schema of the destination table to be updated as a side effect of the query job. Schema update
        /// options are supported in two cases: when writeDisposition is WRITE_APPEND; when writeDisposition is
        /// WRITE_TRUNCATE and the destination table is a partition of a table, specified by partition decorators. For
        /// normal tables, WRITE_TRUNCATE will always overwrite the schema. One or more of the following values are
        /// specified: ALLOW_FIELD_ADDITION: allow adding a nullable field to the schema. ALLOW_FIELD_RELAXATION: allow
        /// relaxing a required field in the original schema to nullable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaUpdateOptions")]
        public virtual System.Collections.Generic.IList<string> SchemaUpdateOptions { get; set; }

        /// <summary>
        /// [Optional] If querying an external data source outside of BigQuery, describes the data format, location and
        /// other properties of the data source. By defining these properties, the data source can then be queried as if
        /// it were a standard BigQuery table.
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
        /// Specifies whether to use BigQuery's legacy SQL dialect for this query. The default value is true. If set to
        /// false, the query will use BigQuery's standard SQL: https://cloud.google.com/bigquery/sql-reference/ When
        /// useLegacySql is set to false, the value of flattenResults is ignored; query will be run as if flattenResults
        /// is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useLegacySql")]
        public virtual System.Nullable<bool> UseLegacySql { get; set; }

        /// <summary>
        /// [Optional] Whether to look for the result in the query cache. The query cache is a best-effort cache that
        /// will be flushed whenever tables in the query are modified. Moreover, the query cache is only available when
        /// a query does not have a destination table specified. The default value is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useQueryCache")]
        public virtual System.Nullable<bool> UseQueryCache { get; set; }

        /// <summary>Describes user-defined function resources used in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userDefinedFunctionResources")]
        public virtual System.Collections.Generic.IList<UserDefinedFunctionResource> UserDefinedFunctionResources { get; set; }

        /// <summary>
        /// [Optional] Specifies the action that occurs if the destination table already exists. The following values
        /// are supported: WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the
        /// schema from the query result. WRITE_APPEND: If the table already exists, BigQuery appends the data to the
        /// table. WRITE_EMPTY: If the table already exists and contains data, a 'duplicate' error is returned in the
        /// job result. The default value is WRITE_EMPTY. Each action is atomic and only occurs if BigQuery is able to
        /// complete the job successfully. Creation, truncation and append actions occur as one atomic update upon job
        /// completion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeDisposition")]
        public virtual string WriteDisposition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class JobConfigurationTableCopy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Optional] Specifies whether the job is allowed to create new tables. The following values are supported:
        /// CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table. CREATE_NEVER: The table must
        /// already exist. If it does not, a 'notFound' error is returned in the job result. The default value is
        /// CREATE_IF_NEEDED. Creation, truncation and append actions occur as one atomic update upon job completion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createDisposition")]
        public virtual string CreateDisposition { get; set; }

        /// <summary>Custom encryption configuration (e.g., Cloud KMS keys).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationEncryptionConfiguration")]
        public virtual EncryptionConfiguration DestinationEncryptionConfiguration { get; set; }

        /// <summary>
        /// [Optional] The time when the destination table expires. Expired tables will be deleted and their storage
        /// reclaimed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationExpirationTime")]
        public virtual object DestinationExpirationTime { get; set; }

        /// <summary>[Required] The destination table</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationTable")]
        public virtual TableReference DestinationTable { get; set; }

        /// <summary>[Optional] Supported operation types in table copy job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationType")]
        public virtual string OperationType { get; set; }

        /// <summary>[Pick one] Source table to copy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceTable")]
        public virtual TableReference SourceTable { get; set; }

        /// <summary>[Pick one] Source tables to copy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceTables")]
        public virtual System.Collections.Generic.IList<TableReference> SourceTables { get; set; }

        /// <summary>
        /// [Optional] Specifies the action that occurs if the destination table already exists. The following values
        /// are supported: WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data.
        /// WRITE_APPEND: If the table already exists, BigQuery appends the data to the table. WRITE_EMPTY: If the table
        /// already exists and contains data, a 'duplicate' error is returned in the job result. The default value is
        /// WRITE_EMPTY. Each action is atomic and only occurs if BigQuery is able to complete the job successfully.
        /// Creation, truncation and append actions occur as one atomic update upon job completion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeDisposition")]
        public virtual string WriteDisposition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

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

        /// <summary>List of jobs that were requested.</summary>
        public class JobsData
        {
            /// <summary>[Full-projection-only] Specifies the job configuration.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("configuration")]
            public virtual JobConfiguration Configuration { get; set; }

            /// <summary>A result object that will be present only if the job has failed.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("errorResult")]
            public virtual ErrorProto ErrorResult { get; set; }

            /// <summary>Unique opaque ID of the job.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("id")]
            public virtual string Id { get; set; }

            /// <summary>Job reference uniquely identifying the job.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("jobReference")]
            public virtual JobReference JobReference { get; set; }

            /// <summary>The resource type.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("kind")]
            public virtual string Kind { get; set; }

            /// <summary>
            /// Running state of the job. When the state is DONE, errorResult can be checked to determine whether the
            /// job succeeded or failed.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("state")]
            public virtual string State { get; set; }

            /// <summary>
            /// [Output-only] Information about the job, including starting time and ending time of the job.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("statistics")]
            public virtual JobStatistics Statistics { get; set; }

            /// <summary>[Full-projection-only] Describes the state of the job.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("status")]
            public virtual JobStatus Status { get; set; }

            /// <summary>[Full-projection-only] Email address of the user who ran the job.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("user_email")]
            public virtual string UserEmail { get; set; }
        }
    }

    public class JobReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Required] The ID of the job. The ID must contain only letters (a-z, A-Z), numbers (0-9), underscores (_),
        /// or dashes (-). The maximum length is 1,024 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobId")]
        public virtual string JobId { get; set; }

        /// <summary>
        /// The geographic location of the job. See details at
        /// https://cloud.google.com/bigquery/docs/locations#specifying_your_location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>[Required] The ID of the project containing this job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class JobStatistics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[TrustedTester] [Output-only] Job progress (0.0 -&gt; 1.0) for LOAD and EXTRACT jobs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionRatio")]
        public virtual System.Nullable<double> CompletionRatio { get; set; }

        /// <summary>
        /// [Output-only] Creation time of this job, in milliseconds since the epoch. This field will be present on all
        /// jobs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual System.Nullable<long> CreationTime { get; set; }

        /// <summary>
        /// [Output-only] End time of this job, in milliseconds since the epoch. This field will be present whenever a
        /// job is in the DONE state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual System.Nullable<long> EndTime { get; set; }

        /// <summary>[Output-only] Statistics for an extract job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extract")]
        public virtual JobStatistics4 Extract { get; set; }

        /// <summary>[Output-only] Statistics for a load job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("load")]
        public virtual JobStatistics3 Load { get; set; }

        /// <summary>[Output-only] Number of child jobs executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numChildJobs")]
        public virtual System.Nullable<long> NumChildJobs { get; set; }

        /// <summary>[Output-only] If this is a child job, the id of the parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentJobId")]
        public virtual string ParentJobId { get; set; }

        /// <summary>[Output-only] Statistics for a query job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual JobStatistics2 Query { get; set; }

        /// <summary>[Output-only] Quotas which delayed this job's start time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaDeferments")]
        public virtual System.Collections.Generic.IList<string> QuotaDeferments { get; set; }

        /// <summary>[Output-only] Job resource usage breakdown by reservation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservationUsage")]
        public virtual System.Collections.Generic.IList<ReservationUsageData> ReservationUsage { get; set; }

        /// <summary>
        /// [Output-only] Name of the primary reservation assigned to this job. Note that this could be different than
        /// reservations reported in the reservation usage field if parent reservations were used to execute this job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservation_id")]
        public virtual string ReservationId { get; set; }

        /// <summary>
        /// [Output-only] [Preview] Statistics for row-level security. Present only for query and extract jobs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowLevelSecurityStatistics")]
        public virtual RowLevelSecurityStatistics RowLevelSecurityStatistics { get; set; }

        /// <summary>[Output-only] Statistics for a child job of a script.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scriptStatistics")]
        public virtual ScriptStatistics ScriptStatistics { get; set; }

        /// <summary>[Output-only] [Preview] Information of the session if this job is part of one.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionInfo")]
        public virtual SessionInfo SessionInfo { get; set; }

        /// <summary>
        /// [Output-only] Start time of this job, in milliseconds since the epoch. This field will be present when the
        /// job transitions from the PENDING state to either RUNNING or DONE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual System.Nullable<long> StartTime { get; set; }

        /// <summary>[Output-only] [Deprecated] Use the bytes processed in the query statistics instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalBytesProcessed")]
        public virtual System.Nullable<long> TotalBytesProcessed { get; set; }

        /// <summary>[Output-only] Slot-milliseconds for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSlotMs")]
        public virtual System.Nullable<long> TotalSlotMs { get; set; }

        /// <summary>
        /// [Output-only] [Alpha] Information of the multi-statement transaction if this job is part of one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionInfo")]
        public virtual TransactionInfo TransactionInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>[Output-only] Job resource usage breakdown by reservation.</summary>
        public class ReservationUsageData
        {
            /// <summary>[Output-only] Reservation name or "unreserved" for on-demand resources usage.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name { get; set; }

            /// <summary>[Output-only] Slot-milliseconds the job spent in the given reservation.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("slotMs")]
            public virtual System.Nullable<long> SlotMs { get; set; }
        }
    }

    public class JobStatistics2 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>BI Engine specific Statistics. [Output-only] BI Engine specific Statistics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("biEngineStatistics")]
        public virtual BiEngineStatistics BiEngineStatistics { get; set; }

        /// <summary>[Output-only] Billing tier for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingTier")]
        public virtual System.Nullable<int> BillingTier { get; set; }

        /// <summary>[Output-only] Whether the query result was fetched from the query cache.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheHit")]
        public virtual System.Nullable<bool> CacheHit { get; set; }

        /// <summary>
        /// [Output-only] [Preview] The number of row access policies affected by a DDL statement. Present only for DROP
        /// ALL ROW ACCESS POLICIES queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ddlAffectedRowAccessPolicyCount")]
        public virtual System.Nullable<long> DdlAffectedRowAccessPolicyCount { get; set; }

        /// <summary>
        /// [Output-only] The DDL destination table. Present only for ALTER TABLE RENAME TO queries. Note that
        /// ddl_target_table is used just for its type information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ddlDestinationTable")]
        public virtual TableReference DdlDestinationTable { get; set; }

        /// <summary>
        /// The DDL operation performed, possibly dependent on the pre-existence of the DDL target. Possible values (new
        /// values might be added in the future): "CREATE": The query created the DDL target. "SKIP": No-op. Example
        /// cases: the query is CREATE TABLE IF NOT EXISTS while the table already exists, or the query is DROP TABLE IF
        /// EXISTS while the table does not exist. "REPLACE": The query replaced the DDL target. Example case: the query
        /// is CREATE OR REPLACE TABLE, and the table already exists. "DROP": The query deleted the DDL target.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ddlOperationPerformed")]
        public virtual string DdlOperationPerformed { get; set; }

        /// <summary>[Output-only] The DDL target dataset. Present only for CREATE/ALTER/DROP SCHEMA queries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ddlTargetDataset")]
        public virtual DatasetReference DdlTargetDataset { get; set; }

        /// <summary>The DDL target routine. Present only for CREATE/DROP FUNCTION/PROCEDURE queries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ddlTargetRoutine")]
        public virtual RoutineReference DdlTargetRoutine { get; set; }

        /// <summary>
        /// [Output-only] [Preview] The DDL target row access policy. Present only for CREATE/DROP ROW ACCESS POLICY
        /// queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ddlTargetRowAccessPolicy")]
        public virtual RowAccessPolicyReference DdlTargetRowAccessPolicy { get; set; }

        /// <summary>
        /// [Output-only] The DDL target table. Present only for CREATE/DROP TABLE/VIEW and DROP ALL ROW ACCESS POLICIES
        /// queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ddlTargetTable")]
        public virtual TableReference DdlTargetTable { get; set; }

        /// <summary>
        /// [Output-only] Detailed statistics for DML statements Present only for DML statements INSERT, UPDATE, DELETE
        /// or TRUNCATE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dmlStats")]
        public virtual DmlStatistics DmlStats { get; set; }

        /// <summary>[Output-only] The original estimate of bytes processed for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedBytesProcessed")]
        public virtual System.Nullable<long> EstimatedBytesProcessed { get; set; }

        /// <summary>[Output-only, Beta] Information about create model query job progress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelTraining")]
        public virtual BigQueryModelTraining ModelTraining { get; set; }

        /// <summary>[Output-only, Beta] Deprecated; do not use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelTrainingCurrentIteration")]
        public virtual System.Nullable<int> ModelTrainingCurrentIteration { get; set; }

        /// <summary>[Output-only, Beta] Deprecated; do not use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelTrainingExpectedTotalIteration")]
        public virtual System.Nullable<long> ModelTrainingExpectedTotalIteration { get; set; }

        /// <summary>
        /// [Output-only] The number of rows affected by a DML statement. Present only for DML statements INSERT, UPDATE
        /// or DELETE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numDmlAffectedRows")]
        public virtual System.Nullable<long> NumDmlAffectedRows { get; set; }

        /// <summary>[Output-only] Describes execution plan for the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryPlan")]
        public virtual System.Collections.Generic.IList<ExplainQueryStage> QueryPlan { get; set; }

        /// <summary>
        /// [Output-only] Referenced routines (persistent user-defined functions and stored procedures) for the job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referencedRoutines")]
        public virtual System.Collections.Generic.IList<RoutineReference> ReferencedRoutines { get; set; }

        /// <summary>
        /// [Output-only] Referenced tables for the job. Queries that reference more than 50 tables will not have a
        /// complete list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referencedTables")]
        public virtual System.Collections.Generic.IList<TableReference> ReferencedTables { get; set; }

        /// <summary>[Output-only] Job resource usage breakdown by reservation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservationUsage")]
        public virtual System.Collections.Generic.IList<ReservationUsageData> ReservationUsage { get; set; }

        /// <summary>
        /// [Output-only] The schema of the results. Present only for successful dry run of non-legacy SQL queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual TableSchema Schema { get; set; }

        /// <summary>
        /// The type of query statement, if valid. Possible values (new values might be added in the future): "SELECT":
        /// SELECT query. "INSERT": INSERT query; see
        /// https://cloud.google.com/bigquery/docs/reference/standard-sql/data-manipulation-language. "UPDATE": UPDATE
        /// query; see https://cloud.google.com/bigquery/docs/reference/standard-sql/data-manipulation-language.
        /// "DELETE": DELETE query; see
        /// https://cloud.google.com/bigquery/docs/reference/standard-sql/data-manipulation-language. "MERGE": MERGE
        /// query; see https://cloud.google.com/bigquery/docs/reference/standard-sql/data-manipulation-language.
        /// "ALTER_TABLE": ALTER TABLE query. "ALTER_VIEW": ALTER VIEW query. "ASSERT": ASSERT condition AS
        /// 'description'. "CREATE_FUNCTION": CREATE FUNCTION query. "CREATE_MODEL": CREATE [OR REPLACE] MODEL ... AS
        /// SELECT ... . "CREATE_PROCEDURE": CREATE PROCEDURE query. "CREATE_TABLE": CREATE [OR REPLACE] TABLE without
        /// AS SELECT. "CREATE_TABLE_AS_SELECT": CREATE [OR REPLACE] TABLE ... AS SELECT ... . "CREATE_VIEW": CREATE [OR
        /// REPLACE] VIEW ... AS SELECT ... . "DROP_FUNCTION" : DROP FUNCTION query. "DROP_PROCEDURE": DROP PROCEDURE
        /// query. "DROP_TABLE": DROP TABLE query. "DROP_VIEW": DROP VIEW query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statementType")]
        public virtual string StatementType { get; set; }

        /// <summary>[Output-only] [Beta] Describes a timeline of job execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeline")]
        public virtual System.Collections.Generic.IList<QueryTimelineSample> Timeline { get; set; }

        /// <summary>[Output-only] Total bytes billed for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalBytesBilled")]
        public virtual System.Nullable<long> TotalBytesBilled { get; set; }

        /// <summary>[Output-only] Total bytes processed for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalBytesProcessed")]
        public virtual System.Nullable<long> TotalBytesProcessed { get; set; }

        /// <summary>
        /// [Output-only] For dry-run jobs, totalBytesProcessed is an estimate and this field specifies the accuracy of
        /// the estimate. Possible values can be: UNKNOWN: accuracy of the estimate is unknown. PRECISE: estimate is
        /// precise. LOWER_BOUND: estimate is lower bound of what the query would cost. UPPER_BOUND: estimate is upper
        /// bound of what the query would cost.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalBytesProcessedAccuracy")]
        public virtual string TotalBytesProcessedAccuracy { get; set; }

        /// <summary>
        /// [Output-only] Total number of partitions processed from all partitioned tables referenced in the job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalPartitionsProcessed")]
        public virtual System.Nullable<long> TotalPartitionsProcessed { get; set; }

        /// <summary>[Output-only] Slot-milliseconds for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSlotMs")]
        public virtual System.Nullable<long> TotalSlotMs { get; set; }

        /// <summary>
        /// Standard SQL only: list of undeclared query parameters detected during a dry run validation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("undeclaredQueryParameters")]
        public virtual System.Collections.Generic.IList<QueryParameter> UndeclaredQueryParameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>[Output-only] Job resource usage breakdown by reservation.</summary>
        public class ReservationUsageData
        {
            /// <summary>[Output-only] Reservation name or "unreserved" for on-demand resources usage.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name { get; set; }

            /// <summary>[Output-only] Slot-milliseconds the job spent in the given reservation.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("slotMs")]
            public virtual System.Nullable<long> SlotMs { get; set; }
        }
    }

    public class JobStatistics3 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Output-only] The number of bad records encountered. Note that if the job has failed because of more bad
        /// records encountered than the maximum allowed in the load job configuration, then this number can be less
        /// than the total number of bad records present in the input data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("badRecords")]
        public virtual System.Nullable<long> BadRecords { get; set; }

        /// <summary>[Output-only] Number of bytes of source data in a load job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputFileBytes")]
        public virtual System.Nullable<long> InputFileBytes { get; set; }

        /// <summary>[Output-only] Number of source files in a load job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputFiles")]
        public virtual System.Nullable<long> InputFiles { get; set; }

        /// <summary>
        /// [Output-only] Size of the loaded data in bytes. Note that while a load job is in the running state, this
        /// value may change.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputBytes")]
        public virtual System.Nullable<long> OutputBytes { get; set; }

        /// <summary>
        /// [Output-only] Number of rows imported in a load job. Note that while an import job is in the running state,
        /// this value may change.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputRows")]
        public virtual System.Nullable<long> OutputRows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class JobStatistics4 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Output-only] Number of files per destination URI or URI pattern specified in the extract configuration.
        /// These values will be in the same order as the URIs specified in the 'destinationUris' field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationUriFileCounts")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> DestinationUriFileCounts { get; set; }

        /// <summary>
        /// [Output-only] Number of user bytes extracted into the result. This is the byte count as computed by BigQuery
        /// for billing purposes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputBytes")]
        public virtual System.Nullable<long> InputBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class JobStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Output-only] Final error result of the job. If present, indicates that the job has completed and was
        /// unsuccessful.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorResult")]
        public virtual ErrorProto ErrorResult { get; set; }

        /// <summary>
        /// [Output-only] The first errors encountered during the running of the job. The final message includes the
        /// number of errors that caused the process to stop. Errors here do not necessarily mean that the job has
        /// completed or was unsuccessful.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<ErrorProto> Errors { get; set; }

        /// <summary>[Output-only] Running state of the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

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

    public class ListRoutinesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token to request the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Routines in the requested dataset. Unless read_mask is set in the request, only the following fields are
        /// populated: etag, project_id, dataset_id, routine_id, routine_type, creation_time, last_modified_time, and
        /// language.
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

    public class MaterializedViewDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Optional] [TrustedTester] Enable automatic refresh of the materialized view when the base table is updated.
        /// The default value is "true".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableRefresh")]
        public virtual System.Nullable<bool> EnableRefresh { get; set; }

        /// <summary>
        /// [Output-only] [TrustedTester] The time when this materialized view was last modified, in milliseconds since
        /// the epoch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastRefreshTime")]
        public virtual System.Nullable<long> LastRefreshTime { get; set; }

        /// <summary>[Required] A query whose result is persisted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>
        /// [Optional] [TrustedTester] The maximum frequency at which this materialized view will be refreshed. The
        /// default value is "1800000" (30 minutes).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refreshIntervalMs")]
        public virtual System.Nullable<long> RefreshIntervalMs { get; set; }

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

        /// <summary>Output only. Input feature columns that were used to train this model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("featureColumns")]
        public virtual System.Collections.Generic.IList<StandardSqlField> FeatureColumns { get; set; }

        /// <summary>Optional. A descriptive name for this model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("friendlyName")]
        public virtual string FriendlyName { get; set; }

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

        /// <summary>Output only. Information for all training runs in increasing order of start_time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingRuns")]
        public virtual System.Collections.Generic.IList<TrainingRun> TrainingRuns { get; set; }
    }

    public class ModelDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Output-only, Beta] Model options used for the first training run. These options are immutable for
        /// subsequent training runs. Default values are used for any options not specified in the input query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelOptions")]
        public virtual ModelOptionsData ModelOptions { get; set; }

        /// <summary>
        /// [Output-only, Beta] Information about ml training runs, each training run comprises of multiple iterations
        /// and there may be multiple training runs for the model if warm start is used or if a user decides to continue
        /// a previously cancelled query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingRuns")]
        public virtual System.Collections.Generic.IList<BqmlTrainingRun> TrainingRuns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>
        /// [Output-only, Beta] Model options used for the first training run. These options are immutable for
        /// subsequent training runs. Default values are used for any options not specified in the input query.
        /// </summary>
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

    public class ModelReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Required] The ID of the dataset containing this model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetId")]
        public virtual string DatasetId { get; set; }

        /// <summary>
        /// [Required] The ID of the model. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores
        /// (_). The maximum length is 1,024 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelId")]
        public virtual string ModelId { get; set; }

        /// <summary>[Required] The ID of the project containing this model.</summary>
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

    public class ParquetOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Optional] Indicates whether to use schema inference specifically for Parquet LIST logical type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableListInference")]
        public virtual System.Nullable<bool> EnableListInference { get; set; }

        /// <summary>
        /// [Optional] Indicates whether to infer Parquet ENUM logical type as STRING instead of BYTES by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enumAsString")]
        public virtual System.Nullable<bool> EnumAsString { get; set; }

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

    public class ProjectList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A hash of the page of results</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The type of list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>A token to request the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Projects to which you have at least READ access.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projects")]
        public virtual System.Collections.Generic.IList<ProjectsData> Projects { get; set; }

        /// <summary>The total number of projects in the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalItems")]
        public virtual System.Nullable<int> TotalItems { get; set; }

        /// <summary>Projects to which you have at least READ access.</summary>
        public class ProjectsData
        {
            /// <summary>A descriptive name for this project.</summary>
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

    public class ProjectReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Required] ID of the project. Can be either the numeric ID or the assigned ID of the project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class QueryParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Optional] If unset, this is a positional parameter. Otherwise, should be unique within a query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>[Required] The type of this parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterType")]
        public virtual QueryParameterType ParameterType { get; set; }

        /// <summary>[Required] The value of this parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterValue")]
        public virtual QueryParameterValue ParameterValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class QueryParameterType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Optional] The type of the array's elements, if this is an array.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arrayType")]
        public virtual QueryParameterType ArrayType { get; set; }

        /// <summary>[Optional] The types of the fields of this struct, in order, if this is a struct.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structTypes")]
        public virtual System.Collections.Generic.IList<StructTypesData> StructTypes { get; set; }

        /// <summary>[Required] The top level type of this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>[Optional] The types of the fields of this struct, in order, if this is a struct.</summary>
        public class StructTypesData
        {
            /// <summary>[Optional] Human-oriented description of the field.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("description")]
            public virtual string Description { get; set; }

            /// <summary>[Optional] The name of this field.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name { get; set; }

            /// <summary>[Required] The type of this field.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual QueryParameterType Type { get; set; }
        }
    }

    public class QueryParameterValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Optional] The array values, if this is an array type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arrayValues")]
        public virtual System.Collections.Generic.IList<QueryParameterValue> ArrayValues { get; set; }

        /// <summary>[Optional] The struct field values, in order of the struct type's declaration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structValues")]
        public virtual System.Collections.Generic.IDictionary<string, QueryParameterValue> StructValues { get; set; }

        /// <summary>[Optional] The value of this value, if a simple scalar type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class QueryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Connection properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionProperties")]
        public virtual System.Collections.Generic.IList<ConnectionProperty> ConnectionProperties { get; set; }

        /// <summary>
        /// If true, creates a new session, where session id will be a server generated random id. If false, runs query
        /// with an existing session_id passed in ConnectionProperty, otherwise runs query in non-session mode.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createSession")]
        public virtual System.Nullable<bool> CreateSession { get; set; }

        /// <summary>
        /// [Optional] Specifies the default datasetId and projectId to assume for any unqualified table names in the
        /// query. If not set, all table names in the query string must be qualified in the format 'datasetId.tableId'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultDataset")]
        public virtual DatasetReference DefaultDataset { get; set; }

        /// <summary>
        /// [Optional] If set to true, BigQuery doesn't run the job. Instead, if the query is valid, BigQuery returns
        /// statistics about the job such as how many bytes would be processed. If the query is invalid, an error
        /// returns. The default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dryRun")]
        public virtual System.Nullable<bool> DryRun { get; set; }

        /// <summary>The resource type of the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The labels associated with this job. You can use these to organize and group your jobs. Label keys and
        /// values can be no longer than 63 characters, can only contain lowercase letters, numeric characters,
        /// underscores and dashes. International characters are allowed. Label values are optional. Label keys must
        /// start with a letter and each label in the list must have a different key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The geographic location where the job should run. See details at
        /// https://cloud.google.com/bigquery/docs/locations#specifying_your_location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// [Optional] The maximum number of rows of data to return per page of results. Setting this flag to a small
        /// value such as 1000 and then paging through results might improve reliability when the query result set is
        /// large. In addition to this limit, responses are also limited to 10 MB. By default, there is no maximum row
        /// count, and only the byte limit applies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxResults")]
        public virtual System.Nullable<long> MaxResults { get; set; }

        /// <summary>
        /// [Optional] Limits the bytes billed for this job. Queries that will have bytes billed beyond this limit will
        /// fail (without incurring a charge). If unspecified, this will be set to your project default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumBytesBilled")]
        public virtual System.Nullable<long> MaximumBytesBilled { get; set; }

        /// <summary>
        /// Standard SQL only. Set to POSITIONAL to use positional (?) query parameters or to NAMED to use named
        /// (@myparam) query parameters in this query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterMode")]
        public virtual string ParameterMode { get; set; }

        /// <summary>[Deprecated] This property is deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preserveNulls")]
        public virtual System.Nullable<bool> PreserveNulls { get; set; }

        /// <summary>
        /// [Required] A query string, following the BigQuery query syntax, of the query to execute. Example: "SELECT
        /// count(f1) FROM [myProjectId:myDatasetId.myTableId]".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>Query parameters for Standard SQL queries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryParameters")]
        public virtual System.Collections.Generic.IList<QueryParameter> QueryParameters { get; set; }

        /// <summary>
        /// A unique user provided identifier to ensure idempotent behavior for queries. Note that this is different
        /// from the job_id. It has the following properties: 1. It is case-sensitive, limited to up to 36 ASCII
        /// characters. A UUID is recommended. 2. Read only queries can ignore this token since they are nullipotent by
        /// definition. 3. For the purposes of idempotency ensured by the request_id, a request is considered duplicate
        /// of another only if they have the same request_id and are actually duplicates. When determining whether a
        /// request is a duplicate of the previous request, all parameters in the request that may affect the behavior
        /// are considered. For example, query, connection_properties, query_parameters, use_legacy_sql are parameters
        /// that affect the result and are considered when determining whether a request is a duplicate, but properties
        /// like timeout_ms don't affect the result and are thus not considered. Dry run query requests are never
        /// considered duplicate of another request. 4. When a duplicate mutating query request is detected, it returns:
        /// a. the results of the mutation if it completes successfully within the timeout. b. the running operation if
        /// it is still in progress at the end of the timeout. 5. Its lifetime is limited to 15 minutes. In other words,
        /// if two requests are sent with the same request_id, but more than 15 minutes apart, idempotency is not
        /// guaranteed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>
        /// [Optional] How long to wait for the query to complete, in milliseconds, before the request times out and
        /// returns. Note that this is only a timeout for the request, not the query. If the query takes longer to run
        /// than the timeout value, the call returns without any results and with the 'jobComplete' flag set to false.
        /// You can call GetQueryResults() to wait for the query to complete and read the results. The default value is
        /// 10000 milliseconds (10 seconds).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeoutMs")]
        public virtual System.Nullable<long> TimeoutMs { get; set; }

        /// <summary>
        /// Specifies whether to use BigQuery's legacy SQL dialect for this query. The default value is true. If set to
        /// false, the query will use BigQuery's standard SQL: https://cloud.google.com/bigquery/sql-reference/ When
        /// useLegacySql is set to false, the value of flattenResults is ignored; query will be run as if flattenResults
        /// is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useLegacySql")]
        public virtual System.Nullable<bool> UseLegacySql { get; set; }

        /// <summary>
        /// [Optional] Whether to look for the result in the query cache. The query cache is a best-effort cache that
        /// will be flushed whenever tables in the query are modified. The default value is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useQueryCache")]
        public virtual System.Nullable<bool> UseQueryCache { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class QueryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the query result was fetched from the query cache.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheHit")]
        public virtual System.Nullable<bool> CacheHit { get; set; }

        /// <summary>
        /// [Output-only] Detailed statistics for DML statements Present only for DML statements INSERT, UPDATE, DELETE
        /// or TRUNCATE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dmlStats")]
        public virtual DmlStatistics DmlStats { get; set; }

        /// <summary>
        /// [Output-only] The first errors or warnings encountered during the running of the job. The final message
        /// includes the number of errors that caused the process to stop. Errors here do not necessarily mean that the
        /// job has completed or was unsuccessful.
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
        /// Reference to the Job that was created to run the query. This field will be present even if the original
        /// request timed out, in which case GetQueryResults can be used to read the results once the query has
        /// completed. Since this API only returns the first page of results, subsequent pages can be fetched via the
        /// same mechanism (GetQueryResults).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobReference")]
        public virtual JobReference JobReference { get; set; }

        /// <summary>The resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// [Output-only] The number of rows affected by a DML statement. Present only for DML statements INSERT, UPDATE
        /// or DELETE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numDmlAffectedRows")]
        public virtual System.Nullable<long> NumDmlAffectedRows { get; set; }

        /// <summary>A token used for paging results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// An object with as many results as can be contained within the maximum permitted reply size. To get any
        /// additional rows, you can call GetQueryResults and specify the jobReference returned above.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<TableRow> Rows { get; set; }

        /// <summary>The schema of the results. Present only when the query completes successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual TableSchema Schema { get; set; }

        /// <summary>[Output-only] [Preview] Information of the session if this job is part of one.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionInfoTemplate")]
        public virtual SessionInfo SessionInfoTemplate { get; set; }

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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class QueryTimelineSample : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Total number of units currently being processed by workers. This does not correspond directly to slot usage.
        /// This is the largest value observed since the last sample.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeUnits")]
        public virtual System.Nullable<long> ActiveUnits { get; set; }

        /// <summary>Total parallel units of work completed by this query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completedUnits")]
        public virtual System.Nullable<long> CompletedUnits { get; set; }

        /// <summary>Milliseconds elapsed since the start of query execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elapsedMs")]
        public virtual System.Nullable<long> ElapsedMs { get; set; }

        /// <summary>Total parallel units of work remaining for the active stages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingUnits")]
        public virtual System.Nullable<long> PendingUnits { get; set; }

        /// <summary>Cumulative slot-ms consumed by the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSlotMs")]
        public virtual System.Nullable<long> TotalSlotMs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RangePartitioning : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [TrustedTester] [Required] The table is partitioned by this field. The field must be a top-level
        /// NULLABLE/REQUIRED field. The only supported type is INTEGER/INT64.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        /// <summary>[TrustedTester] [Required] Defines the ranges for range partitioning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual RangeData Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>[TrustedTester] [Required] Defines the ranges for range partitioning.</summary>
        public class RangeData
        {
            /// <summary>[TrustedTester] [Required] The end of range partitioning, exclusive.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("end")]
            public virtual System.Nullable<long> End { get; set; }

            /// <summary>[TrustedTester] [Required] The width of each interval.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("interval")]
            public virtual System.Nullable<long> Interval { get; set; }

            /// <summary>[TrustedTester] [Required] The start of range partitioning, inclusive.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("start")]
            public virtual System.Nullable<long> Start { get; set; }
        }
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

        /// <summary>Optional. [Experimental] The description of the routine if defined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. [Experimental] The determinism level of the JavaScript UDF if defined.</summary>
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

        /// <summary>Optional. Defaults to "SQL".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; }

        /// <summary>
        /// Output only. The time when this routine was last modified, in milliseconds since the epoch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifiedTime")]
        public virtual System.Nullable<long> LastModifiedTime { get; set; }

        /// <summary>Optional. Set only if Routine is a "TABLE_VALUED_FUNCTION".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnTableType")]
        public virtual StandardSqlTableType ReturnTableType { get; set; }

        /// <summary>
        /// Optional if language = "SQL"; required otherwise. If absent, the return type is inferred from
        /// definition_body at query time in each query that references this routine. If present, then the evaluated
        /// result will be cast to the specified returned type at query time. For example, for the functions created
        /// with the following statements: * `CREATE FUNCTION Add(x FLOAT64, y FLOAT64) RETURNS FLOAT64 AS (x + y);` *
        /// `CREATE FUNCTION Increment(x FLOAT64) AS (Add(x, 1));` * `CREATE FUNCTION Decrement(x FLOAT64) RETURNS
        /// FLOAT64 AS (Add(x, -1));` The return_type is `{type_kind: "FLOAT64"}` for `Add` and `Decrement`, and is
        /// absent for `Increment` (inferred as FLOAT64 at query time). Suppose the function `Add` is replaced by
        /// `CREATE OR REPLACE FUNCTION Add(x INT64, y INT64) AS (x + y);` Then the inferred return type of `Increment`
        /// is automatically changed to INT64 at query time, while the return type of `Decrement` remains FLOAT64.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnType")]
        public virtual StandardSqlDataType ReturnType { get; set; }

        /// <summary>Required. Reference describing the ID of this routine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routineReference")]
        public virtual RoutineReference RoutineReference { get; set; }

        /// <summary>Required. The type of routine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routineType")]
        public virtual string RoutineType { get; set; }
    }

    public class RoutineReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Required] The ID of the dataset containing this routine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetId")]
        public virtual string DatasetId { get; set; }

        /// <summary>[Required] The ID of the project containing this routine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// [Required] The ID of the routine. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores
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
        /// <summary>
        /// Output only. The time when this row access policy was created, in milliseconds since the epoch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual object CreationTime { get; set; }

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
        /// Output only. The time when this row access policy was last modified, in milliseconds since the epoch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifiedTime")]
        public virtual object LastModifiedTime { get; set; }

        /// <summary>Required. Reference describing the ID of this row access policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowAccessPolicyReference")]
        public virtual RowAccessPolicyReference RowAccessPolicyReference { get; set; }
    }

    public class RowAccessPolicyReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Required] The ID of the dataset containing this row access policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetId")]
        public virtual string DatasetId { get; set; }

        /// <summary>
        /// [Required] The ID of the row access policy. The ID must contain only letters (a-z, A-Z), numbers (0-9), or
        /// underscores (_). The maximum length is 256 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyId")]
        public virtual string PolicyId { get; set; }

        /// <summary>[Required] The ID of the project containing this row access policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>[Required] The ID of the table containing this row access policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableId")]
        public virtual string TableId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RowLevelSecurityStatistics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Output-only] [Preview] Whether any accessed data was protected by row access policies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowLevelSecurityApplied")]
        public virtual System.Nullable<bool> RowLevelSecurityApplied { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ScriptStackFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Output-only] One-based end column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endColumn")]
        public virtual System.Nullable<int> EndColumn { get; set; }

        /// <summary>[Output-only] One-based end line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endLine")]
        public virtual System.Nullable<int> EndLine { get; set; }

        /// <summary>[Output-only] Name of the active procedure, empty if in a top-level script.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("procedureId")]
        public virtual string ProcedureId { get; set; }

        /// <summary>[Output-only] One-based start column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startColumn")]
        public virtual System.Nullable<int> StartColumn { get; set; }

        /// <summary>[Output-only] One-based start line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startLine")]
        public virtual System.Nullable<int> StartLine { get; set; }

        /// <summary>[Output-only] Text of the current statement/expression.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ScriptStatistics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Output-only] Whether this child job was a statement or expression.</summary>
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

    public class SessionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Output-only] // [Preview] Id of the session.</summary>
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
        /// 10s of KB. An empty policy is a valid policy but certain Cloud Platform services (such as Projects) might
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

    public class SnapshotDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Required] Reference describing the ID of the table that was snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseTableReference")]
        public virtual TableReference BaseTableReference { get; set; }

        /// <summary>
        /// [Required] The time at which the base table was snapshot. This value is reported in the JSON response using
        /// RFC3339 format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotTime")]
        public virtual string SnapshotTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="SnapshotTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> SnapshotTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(SnapshotTimeRaw);
            set => SnapshotTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The type of a variable, e.g., a function argument. Examples: INT64: {type_kind="INT64"} ARRAY:
    /// {type_kind="ARRAY", array_element_type="STRING"} STRUCT&amp;gt;: {type_kind="STRUCT", struct_type={fields=[
    /// {name="x", type={type_kind="STRING"}}, {name="y", type={type_kind="ARRAY", array_element_type="DATE"}} ]}}
    /// </summary>
    public class StandardSqlDataType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of the array's elements, if type_kind = "ARRAY".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arrayElementType")]
        public virtual StandardSqlDataType ArrayElementType { get; set; }

        /// <summary>The fields of this struct, in order, if type_kind = "STRUCT".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structType")]
        public virtual StandardSqlStructType StructType { get; set; }

        /// <summary>
        /// Required. The top level type of this field. Can be any standard SQL data type (e.g., "INT64", "DATE",
        /// "ARRAY").
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

    public class StandardSqlStructType : Google.Apis.Requests.IDirectResponseSchema
    {
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

    public class Streamingbuffer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Output-only] A lower-bound estimate of the number of bytes currently in the streaming buffer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedBytes")]
        public virtual System.Nullable<ulong> EstimatedBytes { get; set; }

        /// <summary>
        /// [Output-only] A lower-bound estimate of the number of rows currently in the streaming buffer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedRows")]
        public virtual System.Nullable<ulong> EstimatedRows { get; set; }

        /// <summary>
        /// [Output-only] Contains the timestamp of the oldest entry in the streaming buffer, in milliseconds since the
        /// epoch, if the streaming buffer is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldestEntryTime")]
        public virtual System.Nullable<ulong> OldestEntryTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Table : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Beta] Clustering specification for the table. Must be specified with partitioning, data in the table will
        /// be first partitioned and subsequently clustered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clustering")]
        public virtual Clustering Clustering { get; set; }

        /// <summary>[Output-only] The time when this table was created, in milliseconds since the epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual System.Nullable<long> CreationTime { get; set; }

        /// <summary>[Optional] A user-friendly description of this table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Custom encryption configuration (e.g., Cloud KMS keys).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionConfiguration")]
        public virtual EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// [Output-only] A hash of the table metadata. Used to ensure there were no concurrent modifications to the
        /// resource when attempting an update. Not guaranteed to change when the table contents or the fields numRows,
        /// numBytes, numLongTermBytes or lastModifiedTime change.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// [Optional] The time when this table expires, in milliseconds since the epoch. If not present, the table will
        /// persist indefinitely. Expired tables will be deleted and their storage reclaimed. The
        /// defaultTableExpirationMs property of the encapsulating dataset can be used to set a default expirationTime
        /// on newly created tables.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTime")]
        public virtual System.Nullable<long> ExpirationTime { get; set; }

        /// <summary>
        /// [Optional] Describes the data format, location, and other properties of a table stored outside of BigQuery.
        /// By defining these properties, the data source can then be queried as if it were a standard BigQuery table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalDataConfiguration")]
        public virtual ExternalDataConfiguration ExternalDataConfiguration { get; set; }

        /// <summary>[Optional] A descriptive name for this table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("friendlyName")]
        public virtual string FriendlyName { get; set; }

        /// <summary>[Output-only] An opaque ID uniquely identifying the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>[Output-only] The type of the resource.</summary>
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

        /// <summary>
        /// [Output-only] The time when this table was last modified, in milliseconds since the epoch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifiedTime")]
        public virtual System.Nullable<ulong> LastModifiedTime { get; set; }

        /// <summary>
        /// [Output-only] The geographic location where the table resides. This value is inherited from the dataset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>[Optional] Materialized view definition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("materializedView")]
        public virtual MaterializedViewDefinition MaterializedView { get; set; }

        /// <summary>
        /// [Output-only, Beta] Present iff this table represents a ML model. Describes the training information for the
        /// model, and it is required to run 'PREDICT' queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual ModelDefinition Model { get; set; }

        /// <summary>
        /// [Output-only] The size of this table in bytes, excluding any data in the streaming buffer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numBytes")]
        public virtual System.Nullable<long> NumBytes { get; set; }

        /// <summary>[Output-only] The number of bytes in the table that are considered "long-term storage".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numLongTermBytes")]
        public virtual System.Nullable<long> NumLongTermBytes { get; set; }

        /// <summary>
        /// [Output-only] [TrustedTester] The physical size of this table in bytes, excluding any data in the streaming
        /// buffer. This includes compression and storage used for time travel.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numPhysicalBytes")]
        public virtual System.Nullable<long> NumPhysicalBytes { get; set; }

        /// <summary>
        /// [Output-only] The number of rows of data in this table, excluding any data in the streaming buffer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numRows")]
        public virtual System.Nullable<ulong> NumRows { get; set; }

        /// <summary>
        /// [TrustedTester] Range partitioning specification for this table. Only one of timePartitioning and
        /// rangePartitioning should be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rangePartitioning")]
        public virtual RangePartitioning RangePartitioning { get; set; }

        /// <summary>
        /// [Optional] If set to true, queries over this table require a partition filter that can be used for partition
        /// elimination to be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requirePartitionFilter")]
        public virtual System.Nullable<bool> RequirePartitionFilter { get; set; }

        /// <summary>[Optional] Describes the schema of this table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual TableSchema Schema { get; set; }

        /// <summary>[Output-only] A URL that can be used to access this resource again.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>[Output-only] Snapshot definition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotDefinition")]
        public virtual SnapshotDefinition SnapshotDefinition { get; set; }

        /// <summary>
        /// [Output-only] Contains information regarding this table's streaming buffer, if one is present. This field
        /// will be absent if the table is not being streamed to or if there is no data in the streaming buffer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamingBuffer")]
        public virtual Streamingbuffer StreamingBuffer { get; set; }

        /// <summary>[Required] Reference describing the ID of this table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableReference")]
        public virtual TableReference TableReference { get; set; }

        /// <summary>
        /// Time-based partitioning specification for this table. Only one of timePartitioning and rangePartitioning
        /// should be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timePartitioning")]
        public virtual TimePartitioning TimePartitioning { get; set; }

        /// <summary>
        /// [Output-only] Describes the table type. The following values are supported: TABLE: A normal BigQuery table.
        /// VIEW: A virtual table defined by a SQL query. SNAPSHOT: An immutable, read-only table that is a copy of
        /// another table. [TrustedTester] MATERIALIZED_VIEW: SQL query whose result is persisted. EXTERNAL: A table
        /// that references data stored in an external storage system, such as Google Cloud Storage. The default value
        /// is TABLE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>[Optional] The view definition.</summary>
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

    public class TableDataInsertAllRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Optional] Accept rows that contain values that do not match the schema. The unknown values are ignored.
        /// Default is false, which treats unknown values as errors.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreUnknownValues")]
        public virtual System.Nullable<bool> IgnoreUnknownValues { get; set; }

        /// <summary>The resource type of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The rows to insert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<RowsData> Rows { get; set; }

        /// <summary>
        /// [Optional] Insert all valid rows of a request, even if invalid rows exist. The default value is false, which
        /// causes the entire request to fail if any invalid rows exist.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipInvalidRows")]
        public virtual System.Nullable<bool> SkipInvalidRows { get; set; }

        /// <summary>
        /// If specified, treats the destination table as a base template, and inserts the rows into an instance table
        /// named "{destination}{templateSuffix}". BigQuery will manage creation of the instance table, using the schema
        /// of the base template table. See
        /// https://cloud.google.com/bigquery/streaming-data-into-bigquery#template-tables for considerations when
        /// working with templates tables.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("templateSuffix")]
        public virtual string TemplateSuffix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>The rows to insert.</summary>
        public class RowsData
        {
            /// <summary>
            /// [Optional] A unique ID for each row. BigQuery uses this property to detect duplicate insertion requests
            /// on a best-effort basis.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("insertId")]
            public virtual string InsertId { get; set; }

            /// <summary>
            /// [Required] A JSON object that contains a row of data. The object's properties and values must match the
            /// destination table's schema.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("json")]
            public virtual System.Collections.Generic.IDictionary<string, object> Json { get; set; }
        }
    }

    public class TableDataInsertAllResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An array of errors for rows that were not inserted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertErrors")]
        public virtual System.Collections.Generic.IList<InsertErrorsData> InsertErrors { get; set; }

        /// <summary>The resource type of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>An array of errors for rows that were not inserted.</summary>
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

        /// <summary>The total number of rows in the complete table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalRows")]
        public virtual System.Nullable<long> TotalRows { get; set; }
    }

    public class TableFieldSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Optional] The categories attached to this field, used for field-level access control.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual CategoriesData Categories { get; set; }

        /// <summary>[Optional] The field description. The maximum length is 1,024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>[Optional] Describes the nested schema fields if the type property is set to RECORD.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<TableFieldSchema> Fields { get; set; }

        /// <summary>
        /// [Optional] Maximum length of values of this field for STRINGS or BYTES. If max_length is not specified, no
        /// maximum length constraint is imposed on this field. If type = "STRING", then max_length represents the
        /// maximum UTF-8 length of strings in this field. If type = "BYTES", then max_length represents the maximum
        /// number of bytes in this field. It is invalid to set this field if type ≠ "STRING" and ≠ "BYTES".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxLength")]
        public virtual System.Nullable<long> MaxLength { get; set; }

        /// <summary>
        /// [Optional] The field mode. Possible values include NULLABLE, REQUIRED and REPEATED. The default value is
        /// NULLABLE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>
        /// [Required] The field name. The name must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_),
        /// and must start with a letter or underscore. The maximum length is 300 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("policyTags")]
        public virtual PolicyTagsData PolicyTags { get; set; }

        /// <summary>
        /// [Optional] Precision (maximum number of total digits in base 10) and scale (maximum number of digits in the
        /// fractional part in base 10) constraints for values of this field for NUMERIC or BIGNUMERIC. It is invalid to
        /// set precision or scale if type ≠ "NUMERIC" and ≠ "BIGNUMERIC". If precision and scale are not specified, no
        /// value range constraint is imposed on this field insofar as values are permitted by the type. Values of this
        /// NUMERIC or BIGNUMERIC field must be in this range when: - Precision (P) and scale (S) are specified: [-10P-S
        /// + 10-S, 10P-S - 10-S] - Precision (P) is specified but not scale (and thus scale is interpreted to be equal
        /// to zero): [-10P + 1, 10P - 1]. Acceptable values for precision and scale if both are specified: - If type =
        /// "NUMERIC": 1 ≤ precision - scale ≤ 29 and 0 ≤ scale ≤ 9. - If type = "BIGNUMERIC": 1 ≤ precision - scale ≤
        /// 38 and 0 ≤ scale ≤ 38. Acceptable values for precision if only precision is specified but not scale (and
        /// thus scale is interpreted to be equal to zero): - If type = "NUMERIC": 1 ≤ precision ≤ 29. - If type =
        /// "BIGNUMERIC": 1 ≤ precision ≤ 38. If scale is specified but not precision, then it is invalid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precision")]
        public virtual System.Nullable<long> Precision { get; set; }

        /// <summary>[Optional] See documentation for precision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scale")]
        public virtual System.Nullable<long> Scale { get; set; }

        /// <summary>
        /// [Required] The field data type. Possible values include STRING, BYTES, INTEGER, INT64 (same as INTEGER),
        /// FLOAT, FLOAT64 (same as FLOAT), NUMERIC, BIGNUMERIC, BOOLEAN, BOOL (same as BOOLEAN), TIMESTAMP, DATE, TIME,
        /// DATETIME, INTERVAL, RECORD (where RECORD indicates that the field contains a nested schema) or STRUCT (same
        /// as RECORD).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>[Optional] The categories attached to this field, used for field-level access control.</summary>
        public class CategoriesData
        {
            /// <summary>
            /// A list of category resource names. For example, "projects/1/taxonomies/2/categories/3". At most 5
            /// categories are allowed.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("names")]
            public virtual System.Collections.Generic.IList<string> Names { get; set; }
        }

        public class PolicyTagsData
        {
            /// <summary>
            /// A list of category resource names. For example, "projects/1/location/eu/taxonomies/2/policyTags/3". At
            /// most 1 policy tag is allowed.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("names")]
            public virtual System.Collections.Generic.IList<string> Names { get; set; }
        }
    }

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
            /// <summary>[Beta] Clustering specification for this table, if configured.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("clustering")]
            public virtual Clustering Clustering { get; set; }

            /// <summary>The time when this table was created, in milliseconds since the epoch.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
            public virtual System.Nullable<long> CreationTime { get; set; }

            /// <summary>
            /// [Optional] The time when this table expires, in milliseconds since the epoch. If not present, the table
            /// will persist indefinitely. Expired tables will be deleted and their storage reclaimed.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("expirationTime")]
            public virtual System.Nullable<long> ExpirationTime { get; set; }

            /// <summary>The user-friendly name for this table.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("friendlyName")]
            public virtual string FriendlyName { get; set; }

            /// <summary>An opaque ID of the table</summary>
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

            /// <summary>The range partitioning specification for this table, if configured.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("rangePartitioning")]
            public virtual RangePartitioning RangePartitioning { get; set; }

            /// <summary>A reference uniquely identifying the table.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("tableReference")]
            public virtual TableReference TableReference { get; set; }

            /// <summary>The time-based partitioning specification for this table, if configured.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("timePartitioning")]
            public virtual TimePartitioning TimePartitioning { get; set; }

            /// <summary>The type of table. Possible values are: TABLE, VIEW.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }

            /// <summary>Additional details for a view.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("view")]
            public virtual ViewData View { get; set; }

            /// <summary>Additional details for a view.</summary>
            public class ViewData
            {
                /// <summary>True if view is defined in legacy SQL dialect, false if in standard SQL.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("useLegacySql")]
                public virtual System.Nullable<bool> UseLegacySql { get; set; }
            }
        }
    }

    public class TableReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Required] The ID of the dataset containing this table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetId")]
        public virtual string DatasetId { get; set; }

        /// <summary>[Required] The ID of the project containing this table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// [Required] The ID of the table. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores
        /// (_). The maximum length is 1,024 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableId")]
        public virtual string TableId { get; set; }

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

    public class TableSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Describes the fields in a table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<TableFieldSchema> Fields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of permissions to check for the `resource`. Permissions with wildcards (such as '*' or 'storage.*')
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
        /// [Optional] Number of milliseconds for which to keep the storage for partitions in the table. The storage in
        /// a partition will have an expiration time of its partition time plus this value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationMs")]
        public virtual System.Nullable<long> ExpirationMs { get; set; }

        /// <summary>
        /// [Beta] [Optional] If not set, the table is partitioned by pseudo column, referenced via either
        /// '_PARTITIONTIME' as TIMESTAMP type, or '_PARTITIONDATE' as DATE type. If field is specified, the table is
        /// instead partitioned by this field. The field must be a top-level TIMESTAMP or DATE field. Its mode must be
        /// NULLABLE or REQUIRED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("requirePartitionFilter")]
        public virtual System.Nullable<bool> RequirePartitionFilter { get; set; }

        /// <summary>
        /// [Required] The supported types are DAY, HOUR, MONTH, and YEAR, which will generate one partition per day,
        /// hour, month, and year, respectively. When the type is not specified, the default behavior is DAY.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options used in model training.</summary>
    public class TrainingOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If true, detect step changes and make data adjustment in the input time series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adjustStepChanges")]
        public virtual System.Nullable<bool> AdjustStepChanges { get; set; }

        /// <summary>Whether to enable auto ARIMA or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoArima")]
        public virtual System.Nullable<bool> AutoArima { get; set; }

        /// <summary>The max value of non-seasonal p and q.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoArimaMaxOrder")]
        public virtual System.Nullable<long> AutoArimaMaxOrder { get; set; }

        /// <summary>Batch size for dnn models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchSize")]
        public virtual System.Nullable<long> BatchSize { get; set; }

        /// <summary>If true, clean spikes and dips in the input time series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cleanSpikesAndDips")]
        public virtual System.Nullable<bool> CleanSpikesAndDips { get; set; }

        /// <summary>The data frequency of a time series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataFrequency")]
        public virtual string DataFrequency { get; set; }

        /// <summary>
        /// The column to split data with. This column won't be used as a feature. 1. When data_split_method is CUSTOM,
        /// the corresponding column should be boolean. The rows with true value tag are eval data, and the false are
        /// training data. 2. When data_split_method is SEQ, the first DATA_SPLIT_EVAL_FRACTION rows (from smallest to
        /// largest) in the corresponding column are used as training data, and the rest are eval data. It respects the
        /// order in Orderable data types:
        /// https://cloud.google.com/bigquery/docs/reference/standard-sql/data-types#data-type-properties
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

        /// <summary>Feedback type that specifies which algorithm to run for matrix factorization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedbackType")]
        public virtual string FeedbackType { get; set; }

        /// <summary>Hidden units for dnn models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hiddenUnits")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> HiddenUnits { get; set; }

        /// <summary>
        /// The geographical region based on which the holidays are considered in time series modeling. If a valid value
        /// is specified, then holiday effects modeling is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("holidayRegion")]
        public virtual string HolidayRegion { get; set; }

        /// <summary>The number of periods ahead that need to be forecasted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("horizon")]
        public virtual System.Nullable<long> Horizon { get; set; }

        /// <summary>Include drift when fitting an ARIMA model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeDrift")]
        public virtual System.Nullable<bool> IncludeDrift { get; set; }

        /// <summary>Specifies the initial learning rate for the line search learn rate strategy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialLearnRate")]
        public virtual System.Nullable<double> InitialLearnRate { get; set; }

        /// <summary>Name of input label columns in training data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputLabelColumns")]
        public virtual System.Collections.Generic.IList<string> InputLabelColumns { get; set; }

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

        /// <summary>Maximum depth of a tree for boosted tree models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxTreeDepth")]
        public virtual System.Nullable<long> MaxTreeDepth { get; set; }

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

        /// <summary>Optimization strategy for training linear regression models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optimizationStrategy")]
        public virtual string OptimizationStrategy { get; set; }

        /// <summary>
        /// Whether to preserve the input structs in output feature names. Suppose there is a struct A with field b.
        /// When false (default), the output feature name is A_b. When true, the output feature name is A.b.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preserveInputStructs")]
        public virtual System.Nullable<bool> PreserveInputStructs { get; set; }

        /// <summary>
        /// Subsample fraction of the training data to grow tree to prevent overfitting for boosted tree models.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subsample")]
        public virtual System.Nullable<double> Subsample { get; set; }

        /// <summary>Column to be designated as time series data for ARIMA model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeriesDataColumn")]
        public virtual string TimeSeriesDataColumn { get; set; }

        /// <summary>The time series id column that was used during ARIMA model training.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeriesIdColumn")]
        public virtual string TimeSeriesIdColumn { get; set; }

        /// <summary>The time series id columns that were used during ARIMA model training.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeriesIdColumns")]
        public virtual System.Collections.Generic.IList<string> TimeSeriesIdColumns { get; set; }

        /// <summary>Column to be designated as time series timestamp for ARIMA model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeriesTimestampColumn")]
        public virtual string TimeSeriesTimestampColumn { get; set; }

        /// <summary>User column specified for matrix factorization models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userColumn")]
        public virtual string UserColumn { get; set; }

        /// <summary>Hyperparameter for matrix factoration when implicit feedback type is specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("walsAlpha")]
        public virtual System.Nullable<double> WalsAlpha { get; set; }

        /// <summary>Whether to train a model from the last checkpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warmStart")]
        public virtual System.Nullable<bool> WarmStart { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a single training query run for the model.</summary>
    public class TrainingRun : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Data split result of the training run. Only set when the input data is actually split.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSplitResult")]
        public virtual DataSplitResult DataSplitResult { get; set; }

        /// <summary>The evaluation metrics over training/eval data that were computed at the end of training.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationMetrics")]
        public virtual EvaluationMetrics EvaluationMetrics { get; set; }

        /// <summary>Output of each iteration run, results.size() &lt;= max_iterations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<IterationResult> Results { get; set; }

        /// <summary>The start time of this training run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>
        /// Options that were used for this training run, includes user specified and default options that were used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingOptions")]
        public virtual TrainingOptions TrainingOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TransactionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Output-only] // [Alpha] Id of the transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionId")]
        public virtual string TransactionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This is used for defining User Defined Function (UDF) resources only when using legacy SQL. Users of Standard
    /// SQL should leverage either DDL (e.g. CREATE [TEMPORARY] FUNCTION ... ) or the Routines API to define UDF
    /// resources. For additional information on migrating, see:
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

    public class ViewDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Required] A query that BigQuery executes when the view is referenced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>
        /// True if the column names are explicitly specified. For example by using the 'CREATE VIEW v(c1, c2) AS ...'
        /// syntax. Can only be set using BigQuery's standard SQL: https://cloud.google.com/bigquery/sql-reference/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useExplicitColumnNames")]
        public virtual System.Nullable<bool> UseExplicitColumnNames { get; set; }

        /// <summary>
        /// Specifies whether to use BigQuery's legacy SQL for this view. The default value is true. If set to false,
        /// the view will use BigQuery's standard SQL: https://cloud.google.com/bigquery/sql-reference/ Queries and
        /// views that reference this view must use the same flag value.
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
