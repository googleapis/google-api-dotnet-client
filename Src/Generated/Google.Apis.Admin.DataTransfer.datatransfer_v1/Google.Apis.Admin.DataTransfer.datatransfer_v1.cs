// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.Admin.DataTransfer.datatransfer_v1
{
    /// <summary>The DataTransfer Service.</summary>
    public class DataTransferService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "datatransfer_v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DataTransferService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DataTransferService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Applications = new ApplicationsResource(this);
            Transfers = new TransfersResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "admin";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://www.googleapis.com/";
        #else
            "https://www.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://www.googleapis.com/batch/admin/datatransfer_v1";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch/admin/datatransfer_v1";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Admin SDK.</summary>
        public class Scope
        {
            /// <summary>View and manage data transfers between users in your organization</summary>
            public static string AdminDatatransfer = "https://www.googleapis.com/auth/admin.datatransfer";

            /// <summary>View data transfers between users in your organization</summary>
            public static string AdminDatatransferReadonly = "https://www.googleapis.com/auth/admin.datatransfer.readonly";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Admin SDK.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage data transfers between users in your organization</summary>
            public const string AdminDatatransfer = "https://www.googleapis.com/auth/admin.datatransfer";

            /// <summary>View data transfers between users in your organization</summary>
            public const string AdminDatatransferReadonly = "https://www.googleapis.com/auth/admin.datatransfer.readonly";

        }



        /// <summary>Gets the Applications resource.</summary>
        public virtual ApplicationsResource Applications { get; }

        /// <summary>Gets the Transfers resource.</summary>
        public virtual TransfersResource Transfers { get; }
    }

    /// <summary>A base abstract class for DataTransfer requests.</summary>
    public abstract class DataTransferBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DataTransferBaseServiceRequest instance.</summary>
        protected DataTransferBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
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

        /// <summary>Initializes DataTransfer parameter list.</summary>
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

    /// <summary>The "applications" collection of methods.</summary>
    public class ApplicationsResource
    {
        private const string Resource = "applications";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ApplicationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Retrieves information about an application for the given application ID.</summary>
        /// <param name="applicationId">ID of the application resource to be retrieved.</param>
        public virtual GetRequest Get(long applicationId)
        {
            return new GetRequest(service, applicationId);
        }

        /// <summary>Retrieves information about an application for the given application ID.</summary>
        public class GetRequest : DataTransferBaseServiceRequest<Google.Apis.Admin.DataTransfer.datatransfer_v1.Data.Application>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, long applicationId) : base(service)
            {
                ApplicationId = applicationId;
                InitParameters();
            }


            /// <summary>ID of the application resource to be retrieved.</summary>
            [Google.Apis.Util.RequestParameterAttribute("applicationId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long ApplicationId { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/datatransfer/v1/applications/{applicationId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("applicationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "applicationId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Lists the applications available for data transfer for a customer.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists the applications available for data transfer for a customer.</summary>
        public class ListRequest : DataTransferBaseServiceRequest<Google.Apis.Admin.DataTransfer.datatransfer_v1.Data.ApplicationsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }


            /// <summary>Immutable ID of the Google Apps account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomerId { get; set; }

            /// <summary>Maximum number of results to return. Default is 100.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>Token to specify next page in the list.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/datatransfer/v1/applications";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
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
    }

    /// <summary>The "transfers" collection of methods.</summary>
    public class TransfersResource
    {
        private const string Resource = "transfers";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TransfersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Retrieves a data transfer request by its resource ID.</summary>
        /// <param name="dataTransferId">ID of the resource to be retrieved. This is returned in the response from the insert
        /// method.</param>
        public virtual GetRequest Get(string dataTransferId)
        {
            return new GetRequest(service, dataTransferId);
        }

        /// <summary>Retrieves a data transfer request by its resource ID.</summary>
        public class GetRequest : DataTransferBaseServiceRequest<Google.Apis.Admin.DataTransfer.datatransfer_v1.Data.DataTransfer>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string dataTransferId) : base(service)
            {
                DataTransferId = dataTransferId;
                InitParameters();
            }


            /// <summary>ID of the resource to be retrieved. This is returned in the response from the insert
            /// method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("dataTransferId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DataTransferId { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/datatransfer/v1/transfers/{dataTransferId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("dataTransferId", new Google.Apis.Discovery.Parameter
                {
                    Name = "dataTransferId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Inserts a data transfer request.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Admin.DataTransfer.datatransfer_v1.Data.DataTransfer body)
        {
            return new InsertRequest(service, body);
        }

        /// <summary>Inserts a data transfer request.</summary>
        public class InsertRequest : DataTransferBaseServiceRequest<Google.Apis.Admin.DataTransfer.datatransfer_v1.Data.DataTransfer>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.DataTransfer.datatransfer_v1.Data.DataTransfer body) : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.DataTransfer.datatransfer_v1.Data.DataTransfer Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/datatransfer/v1/transfers";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Lists the transfers for a customer by source user, destination user, or status.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists the transfers for a customer by source user, destination user, or status.</summary>
        public class ListRequest : DataTransferBaseServiceRequest<Google.Apis.Admin.DataTransfer.datatransfer_v1.Data.DataTransfersListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }


            /// <summary>Immutable ID of the Google Apps account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomerId { get; set; }

            /// <summary>Maximum number of results to return. Default is 100.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>Destination user's profile ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("newOwnerUserId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string NewOwnerUserId { get; set; }

            /// <summary>Source user's profile ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oldOwnerUserId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OldOwnerUserId { get; set; }

            /// <summary>Token to specify the next page in the list.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Status of the transfer.</summary>
            [Google.Apis.Util.RequestParameterAttribute("status", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Status { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/datatransfer/v1/transfers";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
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
                RequestParameters.Add("newOwnerUserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "newOwnerUserId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("oldOwnerUserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "oldOwnerUserId",
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
                RequestParameters.Add("status", new Google.Apis.Discovery.Parameter
                {
                    Name = "status",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }
    }
}

namespace Google.Apis.Admin.DataTransfer.datatransfer_v1.Data
{    

    /// <summary>The JSON template for an Application resource. STEPLADDER: Generated unstable field number for field
    /// 'kind'. (See http://go/stepladder-help#fieldNumber) STEPLADDER: Generated unstable field number for field
    /// 'etag'. (See http://go/stepladder-help#fieldNumber)</summary>
    public class Application : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The application's ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>Identifies the resource as a DataTransfer Application Resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The application's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The list of all possible transfer parameters for this application. These parameters can be used to
        /// select the data of the user in this application to be transferred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferParams")]
        public virtual System.Collections.Generic.IList<ApplicationTransferParam> TransferParams { get; set; }

    }    

    /// <summary>Template to map fields of ApplicationDataTransfer resource.</summary>
    public class ApplicationDataTransfer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The application's ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationId")]
        public virtual System.Nullable<long> ApplicationId { get; set; }

        /// <summary>The transfer parameters for the application. These parameters are used to select the data which
        /// will get transferred in context of this application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationTransferParams")]
        public virtual System.Collections.Generic.IList<ApplicationTransferParam> ApplicationTransferParams { get; set; }

        /// <summary>Current status of transfer for this application. (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationTransferStatus")]
        public virtual string ApplicationTransferStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Template for application transfer parameters.</summary>
    public class ApplicationTransferParam : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of the transfer parameter. eg: 'PRIVACY_LEVEL'</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The value of the corresponding transfer parameter. eg: 'PRIVATE' or 'SHARED'</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Collections.Generic.IList<string> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Template for a collection of Applications. STEPLADDER: Generated unstable field number for field
    /// 'kind'. (See http://go/stepladder-help#fieldNumber) STEPLADDER: Generated unstable field number for field
    /// 'etag'. (See http://go/stepladder-help#fieldNumber)</summary>
    public class ApplicationsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of applications that support data transfer and are also installed for the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applications")]
        public virtual System.Collections.Generic.IList<Application> Applications { get; set; }

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Identifies the resource as a collection of Applications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Continuation token which will be used to specify next page in list API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

    }    

    /// <summary>The JSON template for a DataTransfer resource. STEPLADDER: Generated unstable field number for field
    /// 'kind'. (See http://go/stepladder-help#fieldNumber) STEPLADDER: Generated unstable field number for field
    /// 'etag'. (See http://go/stepladder-help#fieldNumber)</summary>
    public class DataTransfer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of per application data transfer resources. It contains data transfer details of the
        /// applications associated with this transfer resource. Note that this list is also used to specify the
        /// applications for which data transfer has to be done at the time of the transfer resource creation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationDataTransfers")]
        public virtual System.Collections.Generic.IList<ApplicationDataTransfer> ApplicationDataTransfers { get; set; }

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The transfer's ID (Read-only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Identifies the resource as a DataTransfer request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>ID of the user to whom the data is being transferred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newOwnerUserId")]
        public virtual string NewOwnerUserId { get; set; }

        /// <summary>ID of the user whose data is being transferred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldOwnerUserId")]
        public virtual string OldOwnerUserId { get; set; }

        /// <summary>Overall transfer status (Read-only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overallTransferStatusCode")]
        public virtual string OverallTransferStatusCode { get; set; }

        /// <summary>The time at which the data transfer was requested (Read-only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestTime")]
        public virtual string RequestTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="RequestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> RequestTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(RequestTimeRaw);
            set => RequestTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

    }    

    /// <summary>Template for a collection of DataTransfer resources. STEPLADDER: Generated unstable field number for
    /// field 'kind'. (See http://go/stepladder-help#fieldNumber) STEPLADDER: Generated unstable field number for field
    /// 'etag'. (See http://go/stepladder-help#fieldNumber)</summary>
    public class DataTransfersListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of data transfer requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataTransfers")]
        public virtual System.Collections.Generic.IList<DataTransfer> DataTransfers { get; set; }

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Identifies the resource as a collection of data transfer requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Continuation token which will be used to specify next page in list API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

    }
}
