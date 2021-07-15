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

namespace Google.Apis.Storagetransfer.v1
{
    /// <summary>The Storagetransfer Service.</summary>
    public class StoragetransferService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public StoragetransferService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public StoragetransferService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            GoogleServiceAccounts = new GoogleServiceAccountsResource(this);
            TransferJobs = new TransferJobsResource(this);
            TransferOperations = new TransferOperationsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "storagetransfer";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://storagetransfer.googleapis.com/";
        #else
            "https://storagetransfer.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://storagetransfer.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Storage Transfer API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Storage Transfer API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the GoogleServiceAccounts resource.</summary>
        public virtual GoogleServiceAccountsResource GoogleServiceAccounts { get; }

        /// <summary>Gets the TransferJobs resource.</summary>
        public virtual TransferJobsResource TransferJobs { get; }

        /// <summary>Gets the TransferOperations resource.</summary>
        public virtual TransferOperationsResource TransferOperations { get; }
    }

    /// <summary>A base abstract class for Storagetransfer requests.</summary>
    public abstract class StoragetransferBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new StoragetransferBaseServiceRequest instance.</summary>
        protected StoragetransferBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Storagetransfer parameter list.</summary>
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

    /// <summary>The "googleServiceAccounts" collection of methods.</summary>
    public class GoogleServiceAccountsResource
    {
        private const string Resource = "googleServiceAccounts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public GoogleServiceAccountsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Returns the Google service account that is used by Storage Transfer Service to access buckets in the project
        /// where transfers run or in other projects. Each Google service account is associated with one Google Cloud
        /// Platform Console project. Users should add this service account to the Google Cloud Storage bucket ACLs to
        /// grant access to Storage Transfer Service. This service account is created and owned by Storage Transfer
        /// Service and can only be used by Storage Transfer Service.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform Console project that the Google service account is associated
        /// with.
        /// </param>
        public virtual GetRequest Get(string projectId)
        {
            return new GetRequest(service, projectId);
        }

        /// <summary>
        /// Returns the Google service account that is used by Storage Transfer Service to access buckets in the project
        /// where transfers run or in other projects. Each Google service account is associated with one Google Cloud
        /// Platform Console project. Users should add this service account to the Google Cloud Storage bucket ACLs to
        /// grant access to Storage Transfer Service. This service account is created and owned by Storage Transfer
        /// Service and can only be used by Storage Transfer Service.
        /// </summary>
        public class GetRequest : StoragetransferBaseServiceRequest<Google.Apis.Storagetransfer.v1.Data.GoogleServiceAccount>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string projectId) : base(service)
            {
                ProjectId = projectId;
                InitParameters();
            }

            /// <summary>
            /// Required. The ID of the Google Cloud Platform Console project that the Google service account is
            /// associated with.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/googleServiceAccounts/{projectId}";

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
            }
        }
    }

    /// <summary>The "transferJobs" collection of methods.</summary>
    public class TransferJobsResource
    {
        private const string Resource = "transferJobs";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TransferJobsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Creates a transfer job that runs periodically.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.Storagetransfer.v1.Data.TransferJob body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>Creates a transfer job that runs periodically.</summary>
        public class CreateRequest : StoragetransferBaseServiceRequest<Google.Apis.Storagetransfer.v1.Data.TransferJob>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Storagetransfer.v1.Data.TransferJob body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storagetransfer.v1.Data.TransferJob Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/transferJobs";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Gets a transfer job.</summary>
        /// <param name="jobName">Required. " The job to get.</param>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform Console project that owns the job.
        /// </param>
        public virtual GetRequest Get(string jobName, string projectId)
        {
            return new GetRequest(service, jobName, projectId);
        }

        /// <summary>Gets a transfer job.</summary>
        public class GetRequest : StoragetransferBaseServiceRequest<Google.Apis.Storagetransfer.v1.Data.TransferJob>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string jobName, string projectId) : base(service)
            {
                JobName = jobName;
                ProjectId = projectId;
                InitParameters();
            }

            /// <summary>Required. " The job to get.</summary>
            [Google.Apis.Util.RequestParameterAttribute("jobName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string JobName { get; private set; }

            /// <summary>Required. The ID of the Google Cloud Platform Console project that owns the job.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+jobName}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("jobName", new Google.Apis.Discovery.Parameter
                {
                    Name = "jobName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^transferJobs/.*$",
                });
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists transfer jobs.</summary>
        /// <param name="filter">
        /// Required. A list of query parameters specified as JSON text in the form of: `{"projectId":"my_project_id",
        /// "jobNames":["jobid1","jobid2",...], "jobStatuses":["status1","status2",...]}` Since `jobNames` and
        /// `jobStatuses` support multiple values, their values must be specified with array notation. `projectId` is
        /// required. `jobNames` and `jobStatuses` are optional. The valid values for `jobStatuses` are
        /// case-insensitive: ENABLED, DISABLED, and DELETED.
        /// </param>
        public virtual ListRequest List(string filter)
        {
            return new ListRequest(service, filter);
        }

        /// <summary>Lists transfer jobs.</summary>
        public class ListRequest : StoragetransferBaseServiceRequest<Google.Apis.Storagetransfer.v1.Data.ListTransferJobsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string filter) : base(service)
            {
                Filter = filter;
                InitParameters();
            }

            /// <summary>
            /// Required. A list of query parameters specified as JSON text in the form of:
            /// `{"projectId":"my_project_id", "jobNames":["jobid1","jobid2",...],
            /// "jobStatuses":["status1","status2",...]}` Since `jobNames` and `jobStatuses` support multiple values,
            /// their values must be specified with array notation. `projectId` is required. `jobNames` and
            /// `jobStatuses` are optional. The valid values for `jobStatuses` are case-insensitive: ENABLED, DISABLED,
            /// and DELETED.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; private set; }

            /// <summary>The list page size. The max allowed value is 256.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>The list page token.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/transferJobs";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = true,
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
        /// Updates a transfer job. Updating a job's transfer spec does not affect transfer operations that are running
        /// already. **Note:** The job's status field can be modified using this RPC (for example, to set a job's status
        /// to DELETED, DISABLED, or ENABLED).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="jobName">Required. The name of job to update.</param>
        public virtual PatchRequest Patch(Google.Apis.Storagetransfer.v1.Data.UpdateTransferJobRequest body, string jobName)
        {
            return new PatchRequest(service, body, jobName);
        }

        /// <summary>
        /// Updates a transfer job. Updating a job's transfer spec does not affect transfer operations that are running
        /// already. **Note:** The job's status field can be modified using this RPC (for example, to set a job's status
        /// to DELETED, DISABLED, or ENABLED).
        /// </summary>
        public class PatchRequest : StoragetransferBaseServiceRequest<Google.Apis.Storagetransfer.v1.Data.TransferJob>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Storagetransfer.v1.Data.UpdateTransferJobRequest body, string jobName) : base(service)
            {
                JobName = jobName;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The name of job to update.</summary>
            [Google.Apis.Util.RequestParameterAttribute("jobName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string JobName { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storagetransfer.v1.Data.UpdateTransferJobRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+jobName}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("jobName", new Google.Apis.Discovery.Parameter
                {
                    Name = "jobName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^transferJobs/.*$",
                });
            }
        }

        /// <summary>
        /// Attempts to start a new TransferOperation for the current TransferJob. A TransferJob has a maximum of one
        /// active TransferOperation. If this method is called while a TransferOperation is active, an error wil be
        /// returned.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="jobName">Required. The name of the transfer job.</param>
        public virtual RunRequest Run(Google.Apis.Storagetransfer.v1.Data.RunTransferJobRequest body, string jobName)
        {
            return new RunRequest(service, body, jobName);
        }

        /// <summary>
        /// Attempts to start a new TransferOperation for the current TransferJob. A TransferJob has a maximum of one
        /// active TransferOperation. If this method is called while a TransferOperation is active, an error wil be
        /// returned.
        /// </summary>
        public class RunRequest : StoragetransferBaseServiceRequest<Google.Apis.Storagetransfer.v1.Data.Operation>
        {
            /// <summary>Constructs a new Run request.</summary>
            public RunRequest(Google.Apis.Services.IClientService service, Google.Apis.Storagetransfer.v1.Data.RunTransferJobRequest body, string jobName) : base(service)
            {
                JobName = jobName;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The name of the transfer job.</summary>
            [Google.Apis.Util.RequestParameterAttribute("jobName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string JobName { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storagetransfer.v1.Data.RunTransferJobRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "run";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+jobName}:run";

            /// <summary>Initializes Run parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("jobName", new Google.Apis.Discovery.Parameter
                {
                    Name = "jobName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^transferJobs/.*$",
                });
            }
        }
    }

    /// <summary>The "transferOperations" collection of methods.</summary>
    public class TransferOperationsResource
    {
        private const string Resource = "transferOperations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TransferOperationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Cancels a transfer. Use the transferOperations.get method to check if the cancellation succeeded or if the
        /// operation completed despite the `cancel` request. When you cancel an operation, the currently running
        /// transfer is interrupted. For recurring transfer jobs, the next instance of the transfer job will still run.
        /// For example, if your job is configured to run every day at 1pm and you cancel Monday's operation at 1:05pm,
        /// Monday's transfer will stop. However, a transfer job will still be attempted on Tuesday. This applies only
        /// to currently running operations. If an operation is not currently running, `cancel` does nothing. *Caution:*
        /// Canceling a transfer job can leave your data in an unknown state. We recommend that you restore the state at
        /// both the destination and the source after the `cancel` request completes so that your data is in a
        /// consistent state. When you cancel a job, the next job computes a delta of files and may repair any
        /// inconsistent state. For instance, if you run a job every day, and today's job found 10 new files and
        /// transferred five files before you canceled the job, tomorrow's transfer operation will compute a new delta
        /// with the five files that were not copied today plus any new files discovered tomorrow.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">The name of the operation resource to be cancelled.</param>
        public virtual CancelRequest Cancel(Google.Apis.Storagetransfer.v1.Data.CancelOperationRequest body, string name)
        {
            return new CancelRequest(service, body, name);
        }

        /// <summary>
        /// Cancels a transfer. Use the transferOperations.get method to check if the cancellation succeeded or if the
        /// operation completed despite the `cancel` request. When you cancel an operation, the currently running
        /// transfer is interrupted. For recurring transfer jobs, the next instance of the transfer job will still run.
        /// For example, if your job is configured to run every day at 1pm and you cancel Monday's operation at 1:05pm,
        /// Monday's transfer will stop. However, a transfer job will still be attempted on Tuesday. This applies only
        /// to currently running operations. If an operation is not currently running, `cancel` does nothing. *Caution:*
        /// Canceling a transfer job can leave your data in an unknown state. We recommend that you restore the state at
        /// both the destination and the source after the `cancel` request completes so that your data is in a
        /// consistent state. When you cancel a job, the next job computes a delta of files and may repair any
        /// inconsistent state. For instance, if you run a job every day, and today's job found 10 new files and
        /// transferred five files before you canceled the job, tomorrow's transfer operation will compute a new delta
        /// with the five files that were not copied today plus any new files discovered tomorrow.
        /// </summary>
        public class CancelRequest : StoragetransferBaseServiceRequest<Google.Apis.Storagetransfer.v1.Data.Empty>
        {
            /// <summary>Constructs a new Cancel request.</summary>
            public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.Storagetransfer.v1.Data.CancelOperationRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>The name of the operation resource to be cancelled.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storagetransfer.v1.Data.CancelOperationRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "cancel";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:cancel";

            /// <summary>Initializes Cancel parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^transferOperations/.*$",
                });
            }
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
        public class GetRequest : StoragetransferBaseServiceRequest<Google.Apis.Storagetransfer.v1.Data.Operation>
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
                    Pattern = @"^transferOperations/.*$",
                });
            }
        }

        /// <summary>
        /// Lists transfer operations. Operations are ordered by their creation time in reverse chronological order.
        /// </summary>
        /// <param name="name">Not used.</param>
        /// <param name="filter">
        /// Required. A list of query parameters specified as JSON text in the form of: `{"projectId":"my_project_id",
        /// "jobNames":["jobid1","jobid2",...], "operationNames":["opid1","opid2",...],
        /// "transferStatuses":["status1","status2",...]}` Since `jobNames`, `operationNames`, and `transferStatuses`
        /// support multiple values, they must be specified with array notation. `projectId` is required. `jobNames`,
        /// `operationNames`, and `transferStatuses` are optional. The valid values for `transferStatuses` are
        /// case-insensitive: IN_PROGRESS, PAUSED, SUCCESS, FAILED, and ABORTED.
        /// </param>
        public virtual ListRequest List(string name, string filter)
        {
            return new ListRequest(service, name, filter);
        }

        /// <summary>
        /// Lists transfer operations. Operations are ordered by their creation time in reverse chronological order.
        /// </summary>
        public class ListRequest : StoragetransferBaseServiceRequest<Google.Apis.Storagetransfer.v1.Data.ListOperationsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string name, string filter) : base(service)
            {
                Name = name;
                Filter = filter;
                InitParameters();
            }

            /// <summary>Not used.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Required. A list of query parameters specified as JSON text in the form of:
            /// `{"projectId":"my_project_id", "jobNames":["jobid1","jobid2",...],
            /// "operationNames":["opid1","opid2",...], "transferStatuses":["status1","status2",...]}` Since `jobNames`,
            /// `operationNames`, and `transferStatuses` support multiple values, they must be specified with array
            /// notation. `projectId` is required. `jobNames`, `operationNames`, and `transferStatuses` are optional.
            /// The valid values for `transferStatuses` are case-insensitive: IN_PROGRESS, PAUSED, SUCCESS, FAILED, and
            /// ABORTED.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; private set; }

            /// <summary>The list page size. The max allowed value is 256.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>The list page token.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^transferOperations$",
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = true,
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

        /// <summary>Pauses a transfer operation.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Required. The name of the transfer operation.</param>
        public virtual PauseRequest Pause(Google.Apis.Storagetransfer.v1.Data.PauseTransferOperationRequest body, string name)
        {
            return new PauseRequest(service, body, name);
        }

        /// <summary>Pauses a transfer operation.</summary>
        public class PauseRequest : StoragetransferBaseServiceRequest<Google.Apis.Storagetransfer.v1.Data.Empty>
        {
            /// <summary>Constructs a new Pause request.</summary>
            public PauseRequest(Google.Apis.Services.IClientService service, Google.Apis.Storagetransfer.v1.Data.PauseTransferOperationRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The name of the transfer operation.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storagetransfer.v1.Data.PauseTransferOperationRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "pause";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:pause";

            /// <summary>Initializes Pause parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^transferOperations/.*$",
                });
            }
        }

        /// <summary>Resumes a transfer operation that is paused.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Required. The name of the transfer operation.</param>
        public virtual ResumeRequest Resume(Google.Apis.Storagetransfer.v1.Data.ResumeTransferOperationRequest body, string name)
        {
            return new ResumeRequest(service, body, name);
        }

        /// <summary>Resumes a transfer operation that is paused.</summary>
        public class ResumeRequest : StoragetransferBaseServiceRequest<Google.Apis.Storagetransfer.v1.Data.Empty>
        {
            /// <summary>Constructs a new Resume request.</summary>
            public ResumeRequest(Google.Apis.Services.IClientService service, Google.Apis.Storagetransfer.v1.Data.ResumeTransferOperationRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The name of the transfer operation.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storagetransfer.v1.Data.ResumeTransferOperationRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "resume";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:resume";

            /// <summary>Initializes Resume parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^transferOperations/.*$",
                });
            }
        }
    }
}
namespace Google.Apis.Storagetransfer.v1.Data
{
    /// <summary>
    /// AWS access key (see [AWS Security
    /// Credentials](https://docs.aws.amazon.com/general/latest/gr/aws-security-credentials.html)). For information on
    /// our data retention policy for user credentials, see [User
    /// credentials](/storage-transfer/docs/data-retention#user-credentials).
    /// </summary>
    public class AwsAccessKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. AWS access key ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessKeyId")]
        public virtual string AccessKeyId { get; set; }

        /// <summary>Required. AWS secret access key. This field is not returned in RPC responses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretAccessKey")]
        public virtual string SecretAccessKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An AwsS3Data resource can be a data source, but not a data sink. In an AwsS3Data resource, an object's name is
    /// the S3 object's key name.
    /// </summary>
    public class AwsS3Data : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Input only. AWS access key used to sign the API requests to the AWS S3 bucket. Permissions on the bucket
        /// must be granted to the access ID of the AWS access key. This field is required. For information on our data
        /// retention policy for user credentials, see [User
        /// credentials](/storage-transfer/docs/data-retention#user-credentials).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("awsAccessKey")]
        public virtual AwsAccessKey AwsAccessKey { get; set; }

        /// <summary>
        /// Required. S3 Bucket name (see [Creating a
        /// bucket](https://docs.aws.amazon.com/AmazonS3/latest/dev/create-bucket-get-location-example.html)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketName")]
        public virtual string BucketName { get; set; }

        /// <summary>
        /// Root path to transfer objects. Must be an empty string or full path name that ends with a '/'. This field is
        /// treated as an object prefix. As such, it should generally not begin with a '/'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>
        /// Input only. The Amazon Resource Name (ARN) of the role to support temporary credentials via
        /// `AssumeRoleWithWebIdentity`. For more information about ARNs, see [IAM
        /// ARNs](https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html#identifiers-arns). When a
        /// role ARN is provided, Transfer Service fetches temporary credentials for the session using a
        /// `AssumeRoleWithWebIdentity` call for the provided role using the GoogleServiceAccount for this project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roleArn")]
        public virtual string RoleArn { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An AzureBlobStorageData resource can be a data source, but not a data sink. An AzureBlobStorageData resource
    /// represents one Azure container. The storage account determines the [Azure
    /// endpoint](https://docs.microsoft.com/en-us/azure/storage/common/storage-create-storage-account#storage-account-endpoints).
    /// In an AzureBlobStorageData resource, a blobs's name is the [Azure Blob Storage blob's key
    /// name](https://docs.microsoft.com/en-us/rest/api/storageservices/naming-and-referencing-containers--blobs--and-metadata#blob-names).
    /// </summary>
    public class AzureBlobStorageData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Input only. Credentials used to authenticate API requests to Azure. For information on our data
        /// retention policy for user credentials, see [User
        /// credentials](/storage-transfer/docs/data-retention#user-credentials).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("azureCredentials")]
        public virtual AzureCredentials AzureCredentials { get; set; }

        /// <summary>Required. The container to transfer from the Azure Storage account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("container")]
        public virtual string Container { get; set; }

        /// <summary>
        /// Root path to transfer objects. Must be an empty string or full path name that ends with a '/'. This field is
        /// treated as an object prefix. As such, it should generally not begin with a '/'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>Required. The name of the Azure Storage account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageAccount")]
        public virtual string StorageAccount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Azure credentials For information on our data retention policy for user credentials, see [User
    /// credentials](/storage-transfer/docs/data-retention#user-credentials).
    /// </summary>
    public class AzureCredentials : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Azure shared access signature (SAS). *Note:*Copying data from Azure Data Lake Storage (ADLS) Gen 2
        /// is in [Preview](/products/#product-launch-stages). During Preview, if you are copying data from ADLS Gen 2,
        /// you must use an account SAS. For more information about SAS, see [Grant limited access to Azure Storage
        /// resources using shared access signatures
        /// (SAS)](https://docs.microsoft.com/en-us/azure/storage/common/storage-sas-overview).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sasToken")]
        public virtual string SasToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a whole or partial calendar date, such as a birthday. The time of day and time zone are either
    /// specified elsewhere or are insignificant. The date is relative to the Gregorian Calendar. This can represent one
    /// of the following: * A full date, with non-zero year, month, and day values * A month and day value, with a zero
    /// year, such as an anniversary * A year on its own, with zero month and day values * A year and month value, with
    /// a zero day, such as a credit card expiration date Related types are google.type.TimeOfDay and
    /// `google.protobuf.Timestamp`.
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

    /// <summary>An entry describing an error that has occurred.</summary>
    public class ErrorLogEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of messages that carry the error details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorDetails")]
        public virtual System.Collections.Generic.IList<string> ErrorDetails { get; set; }

        /// <summary>
        /// Required. A URL that refers to the target (a data source, a data sink, or an object) with which the error is
        /// associated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A summary of errors by error code, plus a count and sample error log entries.</summary>
    public class ErrorSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCode")]
        public virtual string ErrorCode { get; set; }

        /// <summary>Required. Count of this type of error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCount")]
        public virtual System.Nullable<long> ErrorCount { get; set; }

        /// <summary>
        /// Error samples. At most 5 error log entries are recorded for a given error code for a single transfer
        /// operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorLogEntries")]
        public virtual System.Collections.Generic.IList<ErrorLogEntry> ErrorLogEntries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// In a GcsData resource, an object's name is the Cloud Storage object's name and its "last modification time"
    /// refers to the object's `updated` property of Cloud Storage objects, which changes when the content or the
    /// metadata of the object is updated.
    /// </summary>
    public class GcsData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Cloud Storage bucket name. Must meet [Bucket Name
        /// Requirements](/storage/docs/naming#requirements).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketName")]
        public virtual string BucketName { get; set; }

        /// <summary>
        /// Root path to transfer objects. Must be an empty string or full path name that ends with a '/'. This field is
        /// treated as an object prefix. As such, it should generally not begin with a '/'. The root path value must
        /// meet [Object Name Requirements](/storage/docs/naming#objectnames).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Google service account</summary>
    public class GoogleServiceAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Email address of the service account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountEmail")]
        public virtual string AccountEmail { get; set; }

        /// <summary>Unique identifier for the service account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subjectId")]
        public virtual string SubjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An HttpData resource specifies a list of objects on the web to be transferred over HTTP. The information of the
    /// objects to be transferred is contained in a file referenced by a URL. The first line in the file must be
    /// `"TsvHttpData-1.0"`, which specifies the format of the file. Subsequent lines specify the information of the
    /// list of objects, one object per list entry. Each entry has the following tab-delimited fields: * **HTTP URL** —
    /// The location of the object. * **Length** — The size of the object in bytes. * **MD5** — The base64-encoded MD5
    /// hash of the object. For an example of a valid TSV file, see [Transferring data from
    /// URLs](https://cloud.google.com/storage-transfer/docs/create-url-list). When transferring data based on a URL
    /// list, keep the following in mind: * When an object located at `http(s)://hostname:port/` is transferred to a
    /// data sink, the name of the object at the data sink is `/`. * If the specified size of an object does not match
    /// the actual size of the object fetched, the object is not transferred. * If the specified MD5 does not match the
    /// MD5 computed from the transferred bytes, the object transfer fails. * Ensure that each URL you specify is
    /// publicly accessible. For example, in Cloud Storage you can [share an object publicly]
    /// (/storage/docs/cloud-console#_sharingdata) and get a link to it. * Storage Transfer Service obeys `robots.txt`
    /// rules and requires the source HTTP server to support `Range` requests and to return a `Content-Length` header in
    /// each response. * ObjectConditions have no effect when filtering objects to transfer.
    /// </summary>
    public class HttpData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The URL that points to the file that stores the object list entries. This file must allow public
        /// access. Currently, only URLs with HTTP and HTTPS schemes are supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listUrl")]
        public virtual string ListUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Operations.ListOperations.</summary>
    public class ListOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of operations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<Operation> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response from ListTransferJobs.</summary>
    public class ListTransferJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list next page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of transfer jobs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferJobs")]
        public virtual System.Collections.Generic.IList<TransferJob> TransferJobs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specification to configure notifications published to Pub/Sub. Notifications are published to the
    /// customer-provided topic using the following `PubsubMessage.attributes`: * `"eventType"`: one of the EventType
    /// values * `"payloadFormat"`: one of the PayloadFormat values * `"projectId"`: the project_id of the
    /// `TransferOperation` * `"transferJobName"`: the transfer_job_name of the `TransferOperation` *
    /// `"transferOperationName"`: the name of the `TransferOperation` The `PubsubMessage.data` contains a
    /// TransferOperation resource formatted according to the specified `PayloadFormat`.
    /// </summary>
    public class NotificationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Event types for which a notification is desired. If empty, send notifications for all event types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTypes")]
        public virtual System.Collections.Generic.IList<string> EventTypes { get; set; }

        /// <summary>Required. The desired format of the notification message payloads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payloadFormat")]
        public virtual string PayloadFormat { get; set; }

        /// <summary>
        /// Required. The `Topic.name` of the Pub/Sub topic to which to publish notifications. Must be of the format:
        /// `projects/{project}/topics/{topic}`. Not matching this format results in an INVALID_ARGUMENT error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubTopic")]
        public virtual string PubsubTopic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Conditions that determine which objects are transferred. Applies only to Cloud Data Sources such as S3, Azure,
    /// and Cloud Storage. The "last modification time" refers to the time of the last change to the object's content or
    /// metadata — specifically, this is the `updated` property of Cloud Storage objects, the `LastModified` field of S3
    /// objects, and the `Last-Modified` header of Azure blobs. This is not supported for transfers involving
    /// PosixFilesystem.
    /// </summary>
    public class ObjectConditions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If you specify `exclude_prefixes`, Storage Transfer Service uses the items in the `exclude_prefixes` array
        /// to determine which objects to exclude from a transfer. Objects must not start with one of the matching
        /// `exclude_prefixes` for inclusion in a transfer. The following are requirements of `exclude_prefixes`: * Each
        /// exclude-prefix can contain any sequence of Unicode characters, to a max length of 1024 bytes when
        /// UTF8-encoded, and must not contain Carriage Return or Line Feed characters. Wildcard matching and regular
        /// expression matching are not supported. * Each exclude-prefix must omit the leading slash. For example, to
        /// exclude the object `s3://my-aws-bucket/logs/y=2015/requests.gz`, specify the exclude-prefix as
        /// `logs/y=2015/requests.gz`. * None of the exclude-prefix values can be empty, if specified. * Each
        /// exclude-prefix must exclude a distinct portion of the object namespace. No exclude-prefix may be a prefix of
        /// another exclude-prefix. * If include_prefixes is specified, then each exclude-prefix must start with the
        /// value of a path explicitly included by `include_prefixes`. The max size of `exclude_prefixes` is 1000. For
        /// more information, see [Filtering objects from
        /// transfers](/storage-transfer/docs/filtering-objects-from-transfers).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludePrefixes")]
        public virtual System.Collections.Generic.IList<string> ExcludePrefixes { get; set; }

        /// <summary>
        /// If you specify `include_prefixes`, Storage Transfer Service uses the items in the `include_prefixes` array
        /// to determine which objects to include in a transfer. Objects must start with one of the matching
        /// `include_prefixes` for inclusion in the transfer. If exclude_prefixes is specified, objects must not start
        /// with any of the `exclude_prefixes` specified for inclusion in the transfer. The following are requirements
        /// of `include_prefixes`: * Each include-prefix can contain any sequence of Unicode characters, to a max length
        /// of 1024 bytes when UTF8-encoded, and must not contain Carriage Return or Line Feed characters. Wildcard
        /// matching and regular expression matching are not supported. * Each include-prefix must omit the leading
        /// slash. For example, to include the object `s3://my-aws-bucket/logs/y=2015/requests.gz`, specify the
        /// include-prefix as `logs/y=2015/requests.gz`. * None of the include-prefix values can be empty, if specified.
        /// * Each include-prefix must include a distinct portion of the object namespace. No include-prefix may be a
        /// prefix of another include-prefix. The max size of `include_prefixes` is 1000. For more information, see
        /// [Filtering objects from transfers](/storage-transfer/docs/filtering-objects-from-transfers).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includePrefixes")]
        public virtual System.Collections.Generic.IList<string> IncludePrefixes { get; set; }

        /// <summary>
        /// If specified, only objects with a "last modification time" before this timestamp and objects that don't have
        /// a "last modification time" are transferred.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifiedBefore")]
        public virtual object LastModifiedBefore { get; set; }

        /// <summary>
        /// If specified, only objects with a "last modification time" on or after this timestamp and objects that don't
        /// have a "last modification time" are transferred. The `last_modified_since` and `last_modified_before` fields
        /// can be used together for chunked data processing. For example, consider a script that processes each day's
        /// worth of data at a time. For that you'd set each of the fields as follows: * `last_modified_since` to the
        /// start of the day * `last_modified_before` to the end of the day
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifiedSince")]
        public virtual object LastModifiedSince { get; set; }

        /// <summary>
        /// If specified, only objects with a "last modification time" on or after `NOW` -
        /// `max_time_elapsed_since_last_modification` and objects that don't have a "last modification time" are
        /// transferred. For each TransferOperation started by this TransferJob, `NOW` refers to the start_time of the
        /// `TransferOperation`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxTimeElapsedSinceLastModification")]
        public virtual object MaxTimeElapsedSinceLastModification { get; set; }

        /// <summary>
        /// If specified, only objects with a "last modification time" before `NOW` -
        /// `min_time_elapsed_since_last_modification` and objects that don't have a "last modification time" are
        /// transferred. For each TransferOperation started by this TransferJob, `NOW` refers to the start_time of the
        /// `TransferOperation`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minTimeElapsedSinceLastModification")]
        public virtual object MinTimeElapsedSinceLastModification { get; set; }

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
        /// Represents the transfer operation object. To request a TransferOperation object, use transferOperations.get.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// The server-assigned unique name. The format of `name` is `transferOperations/some/unique/name`.
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

    /// <summary>Request passed to PauseTransferOperation.</summary>
    public class PauseTransferOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request passed to ResumeTransferOperation.</summary>
    public class ResumeTransferOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request passed to RunTransferJob.</summary>
    public class RunTransferJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The ID of the Google Cloud Platform Console project that owns the transfer job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Transfers can be scheduled to recur or to run just once.</summary>
    public class Schedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The time in UTC that no further transfer operations are scheduled. Combined with schedule_end_date,
        /// `end_time_of_day` specifies the end date and time for starting new transfer operations. This field must be
        /// greater than or equal to the timestamp corresponding to the combintation of schedule_start_date and
        /// start_time_of_day, and is subject to the following: * If `end_time_of_day` is not set and
        /// `schedule_end_date` is set, then a default value of `23:59:59` is used for `end_time_of_day`. * If
        /// `end_time_of_day` is set and `schedule_end_date` is not set, then INVALID_ARGUMENT is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTimeOfDay")]
        public virtual TimeOfDay EndTimeOfDay { get; set; }

        /// <summary>
        /// Interval between the start of each scheduled TransferOperation. If unspecified, the default value is 24
        /// hours. This value may not be less than 1 hour.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repeatInterval")]
        public virtual object RepeatInterval { get; set; }

        /// <summary>
        /// The last day a transfer runs. Date boundaries are determined relative to UTC time. A job runs once per 24
        /// hours within the following guidelines: * If `schedule_end_date` and schedule_start_date are the same and in
        /// the future relative to UTC, the transfer is executed only one time. * If `schedule_end_date` is later than
        /// `schedule_start_date` and `schedule_end_date` is in the future relative to UTC, the job runs each day at
        /// start_time_of_day through `schedule_end_date`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleEndDate")]
        public virtual Date ScheduleEndDate { get; set; }

        /// <summary>
        /// Required. The start date of a transfer. Date boundaries are determined relative to UTC time. If
        /// `schedule_start_date` and start_time_of_day are in the past relative to the job's creation time, the
        /// transfer starts the day after you schedule the transfer request. **Note:** When starting jobs at or near
        /// midnight UTC it is possible that a job starts later than expected. For example, if you send an outbound
        /// request on June 1 one millisecond prior to midnight UTC and the Storage Transfer Service server receives the
        /// request on June 2, then it creates a TransferJob with `schedule_start_date` set to June 2 and a
        /// `start_time_of_day` set to midnight UTC. The first scheduled TransferOperation takes place on June 3 at
        /// midnight UTC.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleStartDate")]
        public virtual Date ScheduleStartDate { get; set; }

        /// <summary>
        /// The time in UTC that a transfer job is scheduled to run. Transfers may start later than this time. If
        /// `start_time_of_day` is not specified: * One-time transfers run immediately. * Recurring transfers run
        /// immediately, and each day at midnight UTC, through schedule_end_date. If `start_time_of_day` is specified: *
        /// One-time transfers run at the specified time. * Recurring transfers run at the specified time each day,
        /// through `schedule_end_date`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeOfDay")]
        public virtual TimeOfDay StartTimeOfDay { get; set; }

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
    /// Represents a time of day. The date and time zone are either not significant or are specified elsewhere. An API
    /// may choose to allow leap seconds. Related types are google.type.Date and `google.protobuf.Timestamp`.
    /// </summary>
    public class TimeOfDay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for
        /// scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows
        /// leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A collection of counters that report the progress of a transfer operation.</summary>
    public class TransferCounters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Bytes that are copied to the data sink.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bytesCopiedToSink")]
        public virtual System.Nullable<long> BytesCopiedToSink { get; set; }

        /// <summary>Bytes that are deleted from the data sink.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bytesDeletedFromSink")]
        public virtual System.Nullable<long> BytesDeletedFromSink { get; set; }

        /// <summary>Bytes that are deleted from the data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bytesDeletedFromSource")]
        public virtual System.Nullable<long> BytesDeletedFromSource { get; set; }

        /// <summary>Bytes that failed to be deleted from the data sink.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bytesFailedToDeleteFromSink")]
        public virtual System.Nullable<long> BytesFailedToDeleteFromSink { get; set; }

        /// <summary>
        /// Bytes found in the data source that are scheduled to be transferred, excluding any that are filtered based
        /// on object conditions or skipped due to sync.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bytesFoundFromSource")]
        public virtual System.Nullable<long> BytesFoundFromSource { get; set; }

        /// <summary>Bytes found only in the data sink that are scheduled to be deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bytesFoundOnlyFromSink")]
        public virtual System.Nullable<long> BytesFoundOnlyFromSink { get; set; }

        /// <summary>
        /// Bytes in the data source that failed to be transferred or that failed to be deleted after being transferred.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bytesFromSourceFailed")]
        public virtual System.Nullable<long> BytesFromSourceFailed { get; set; }

        /// <summary>
        /// Bytes in the data source that are not transferred because they already exist in the data sink.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bytesFromSourceSkippedBySync")]
        public virtual System.Nullable<long> BytesFromSourceSkippedBySync { get; set; }

        /// <summary>Objects that are copied to the data sink.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectsCopiedToSink")]
        public virtual System.Nullable<long> ObjectsCopiedToSink { get; set; }

        /// <summary>Objects that are deleted from the data sink.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectsDeletedFromSink")]
        public virtual System.Nullable<long> ObjectsDeletedFromSink { get; set; }

        /// <summary>Objects that are deleted from the data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectsDeletedFromSource")]
        public virtual System.Nullable<long> ObjectsDeletedFromSource { get; set; }

        /// <summary>Objects that failed to be deleted from the data sink.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectsFailedToDeleteFromSink")]
        public virtual System.Nullable<long> ObjectsFailedToDeleteFromSink { get; set; }

        /// <summary>
        /// Objects found in the data source that are scheduled to be transferred, excluding any that are filtered based
        /// on object conditions or skipped due to sync.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectsFoundFromSource")]
        public virtual System.Nullable<long> ObjectsFoundFromSource { get; set; }

        /// <summary>Objects found only in the data sink that are scheduled to be deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectsFoundOnlyFromSink")]
        public virtual System.Nullable<long> ObjectsFoundOnlyFromSink { get; set; }

        /// <summary>
        /// Objects in the data source that failed to be transferred or that failed to be deleted after being
        /// transferred.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectsFromSourceFailed")]
        public virtual System.Nullable<long> ObjectsFromSourceFailed { get; set; }

        /// <summary>
        /// Objects in the data source that are not transferred because they already exist in the data sink.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectsFromSourceSkippedBySync")]
        public virtual System.Nullable<long> ObjectsFromSourceSkippedBySync { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents the configuration of a transfer job that runs periodically.</summary>
    public class TransferJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time that the transfer job was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual object CreationTime { get; set; }

        /// <summary>Output only. The time that the transfer job was deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionTime")]
        public virtual object DeletionTime { get; set; }

        /// <summary>
        /// A description provided by the user for the job. Its max length is 1024 bytes when Unicode-encoded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. The time that the transfer job was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModificationTime")]
        public virtual object LastModificationTime { get; set; }

        /// <summary>
        /// The name of the most recently started TransferOperation of this JobConfig. Present if a TransferOperation
        /// has been created for this JobConfig.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestOperationName")]
        public virtual string LatestOperationName { get; set; }

        /// <summary>
        /// A unique name (within the transfer project) assigned when the job is created. If this field is empty in a
        /// CreateTransferJobRequest, Storage Transfer Service assigns a unique name. Otherwise, the specified name is
        /// used as the unique name for this job. If the specified name is in use by a job, the creation request fails
        /// with an ALREADY_EXISTS error. This name must start with `"transferJobs/"` prefix and end with a letter or a
        /// number, and should be no more than 128 characters. For transfers involving PosixFilesystem, this name must
        /// start with 'transferJobs/OPI' specifically. For all other transfer types, this name must not start with
        /// 'transferJobs/OPI'. 'transferJobs/OPI' is a reserved prefix for PosixFilesystem transfers.
        /// Non-PosixFilesystem example: `"transferJobs/^(?!OPI)[A-Za-z0-9-._~]*[A-Za-z0-9]$"` PosixFilesystem example:
        /// `"transferJobs/OPI^[A-Za-z0-9-._~]*[A-Za-z0-9]$"` Applications must not rely on the enforcement of naming
        /// requirements involving OPI. Invalid job names fail with an INVALID_ARGUMENT error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Notification configuration. This is not supported for transfers involving PosixFilesystem.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationConfig")]
        public virtual NotificationConfig NotificationConfig { get; set; }

        /// <summary>The ID of the Google Cloud Platform Project that owns the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Specifies schedule for the transfer job. This is an optional field. When the field is not set, the job never
        /// executes a transfer, unless you invoke RunTransferJob or update the job to have a non-empty schedule.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedule")]
        public virtual Schedule Schedule { get; set; }

        /// <summary>
        /// Status of the job. This value MUST be specified for `CreateTransferJobRequests`. **Note:** The effect of the
        /// new job status takes place during a subsequent job run. For example, if you change the job status from
        /// ENABLED to DISABLED, and an operation spawned by the transfer is running, the status change would not affect
        /// the current operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Transfer specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferSpec")]
        public virtual TransferSpec TransferSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A description of the execution of a transfer.</summary>
    public class TransferOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information about the progress of the transfer operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("counters")]
        public virtual TransferCounters Counters { get; set; }

        /// <summary>End time of this transfer execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Summarizes errors encountered with sample error log entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorBreakdowns")]
        public virtual System.Collections.Generic.IList<ErrorSummary> ErrorBreakdowns { get; set; }

        /// <summary>A globally unique ID assigned by the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Notification configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationConfig")]
        public virtual NotificationConfig NotificationConfig { get; set; }

        /// <summary>The ID of the Google Cloud Platform Project that owns the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Start time of this transfer execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>Status of the transfer operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The name of the transfer job that triggers this transfer operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferJobName")]
        public virtual string TransferJobName { get; set; }

        /// <summary>Transfer specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferSpec")]
        public virtual TransferSpec TransferSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>TransferOptions define the actions to be performed on objects in a transfer.</summary>
    public class TransferOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether objects should be deleted from the source after they are transferred to the sink. **Note:** This
        /// option and delete_objects_unique_in_sink are mutually exclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteObjectsFromSourceAfterTransfer")]
        public virtual System.Nullable<bool> DeleteObjectsFromSourceAfterTransfer { get; set; }

        /// <summary>
        /// Whether objects that exist only in the sink should be deleted. **Note:** This option and
        /// delete_objects_from_source_after_transfer are mutually exclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteObjectsUniqueInSink")]
        public virtual System.Nullable<bool> DeleteObjectsUniqueInSink { get; set; }

        /// <summary>
        /// When to overwrite objects that already exist in the sink. The default is that only objects that are
        /// different from the source are ovewritten. If true, all objects in the sink whose name matches an object in
        /// the source are overwritten with the source object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overwriteObjectsAlreadyExistingInSink")]
        public virtual System.Nullable<bool> OverwriteObjectsAlreadyExistingInSink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for running a transfer.</summary>
    public class TransferSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An AWS S3 data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("awsS3DataSource")]
        public virtual AwsS3Data AwsS3DataSource { get; set; }

        /// <summary>An Azure Blob Storage data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("azureBlobStorageDataSource")]
        public virtual AzureBlobStorageData AzureBlobStorageDataSource { get; set; }

        /// <summary>A Cloud Storage data sink.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDataSink")]
        public virtual GcsData GcsDataSink { get; set; }

        /// <summary>A Cloud Storage data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDataSource")]
        public virtual GcsData GcsDataSource { get; set; }

        /// <summary>An HTTP URL data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpDataSource")]
        public virtual HttpData HttpDataSource { get; set; }

        /// <summary>
        /// Only objects that satisfy these object conditions are included in the set of data source and data sink
        /// objects. Object conditions based on objects' "last modification time" do not exclude objects in a data sink.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectConditions")]
        public virtual ObjectConditions ObjectConditions { get; set; }

        /// <summary>
        /// If the option delete_objects_unique_in_sink is `true` and time-based object conditions such as 'last
        /// modification time' are specified, the request fails with an INVALID_ARGUMENT error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferOptions")]
        public virtual TransferOptions TransferOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request passed to UpdateTransferJob.</summary>
    public class UpdateTransferJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The ID of the Google Cloud Platform Console project that owns the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Required. The job to update. `transferJob` is expected to specify only four fields: description,
        /// transfer_spec, notification_config, and status. An `UpdateTransferJobRequest` that specifies other fields
        /// are rejected with the error INVALID_ARGUMENT. Updating a job status to DELETED requires
        /// `storagetransfer.jobs.delete` permissions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferJob")]
        public virtual TransferJob TransferJob { get; set; }

        /// <summary>
        /// The field mask of the fields in `transferJob` that are to be updated in this request. Fields in
        /// `transferJob` that can be updated are: description, transfer_spec, notification_config, and status. To
        /// update the `transfer_spec` of the job, a complete transfer specification must be provided. An incomplete
        /// specification missing any required fields is rejected with the error INVALID_ARGUMENT.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTransferJobFieldMask")]
        public virtual object UpdateTransferJobFieldMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
