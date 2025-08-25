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

namespace Google.Apis.Document.v1beta3
{
    /// <summary>The Document Service.</summary>
    public class DocumentService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta3";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DocumentService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DocumentService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://documentai.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://documentai.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "documentai";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Document AI API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Document AI API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for Document requests.</summary>
    public abstract class DocumentBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DocumentBaseServiceRequest instance.</summary>
        protected DocumentBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Document parameter list.</summary>
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
            Locations = new LocationsResource(service);
        }

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }

        /// <summary>The "locations" collection of methods.</summary>
        public class LocationsResource
        {
            private const string Resource = "locations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LocationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Operations = new OperationsResource(service);
                ProcessorTypes = new ProcessorTypesResource(service);
                Processors = new ProcessorsResource(service);
            }

            /// <summary>Gets the Operations resource.</summary>
            public virtual OperationsResource Operations { get; }

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
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
                /// </summary>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(string name)
                {
                    return new CancelRequest(this.service, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
                /// </summary>
                public class CancelRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta3/{+name}:cancel";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                /// <param name="name">The name of the operation resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                public class GetRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleLongrunningOperation>
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
                    public override string RestPath => "v1beta3/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`.
                /// </summary>
                /// <param name="name">The name of the operation's parent resource.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(this.service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`.
                /// </summary>
                public class ListRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleLongrunningListOperationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>The name of the operation's parent resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The standard list filter.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>The standard list page size.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The standard list page token.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta3/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations$",
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
            }

            /// <summary>Gets the ProcessorTypes resource.</summary>
            public virtual ProcessorTypesResource ProcessorTypes { get; }

            /// <summary>The "processorTypes" collection of methods.</summary>
            public class ProcessorTypesResource
            {
                private const string Resource = "processorTypes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ProcessorTypesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets a processor type detail.</summary>
                /// <param name="name">Required. The processor type resource name.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a processor type detail.</summary>
                public class GetRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ProcessorType>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The processor type resource name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta3/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/processorTypes/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists the processor types that exist.</summary>
                /// <param name="parent">
                /// Required. The location of processor types to list. Format:
                /// `projects/{project}/locations/{location}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists the processor types that exist.</summary>
                public class ListRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ListProcessorTypesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location of processor types to list. Format:
                    /// `projects/{project}/locations/{location}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of processor types to return. If unspecified, at most `100` processor types
                    /// will be returned. The maximum value is `500`. Values above `500` will be coerced to `500`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Used to retrieve the next page of results, empty if at the end of the list.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta3/{+parent}/processorTypes";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
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

            /// <summary>Gets the Processors resource.</summary>
            public virtual ProcessorsResource Processors { get; }

            /// <summary>The "processors" collection of methods.</summary>
            public class ProcessorsResource
            {
                private const string Resource = "processors";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ProcessorsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Dataset = new DatasetResource(service);
                    HumanReviewConfig = new HumanReviewConfigResource(service);
                    ProcessorVersions = new ProcessorVersionsResource(service);
                }

                /// <summary>Gets the Dataset resource.</summary>
                public virtual DatasetResource Dataset { get; }

                /// <summary>The "dataset" collection of methods.</summary>
                public class DatasetResource
                {
                    private const string Resource = "dataset";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public DatasetResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Deletes a set of documents.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="dataset">
                    /// Required. The dataset resource name. Format:
                    /// projects/{project}/locations/{location}/processors/{processor}/dataset
                    /// </param>
                    public virtual BatchDeleteDocumentsRequest BatchDeleteDocuments(Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3BatchDeleteDocumentsRequest body, string dataset)
                    {
                        return new BatchDeleteDocumentsRequest(this.service, body, dataset);
                    }

                    /// <summary>Deletes a set of documents.</summary>
                    public class BatchDeleteDocumentsRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new BatchDeleteDocuments request.</summary>
                        public BatchDeleteDocumentsRequest(Google.Apis.Services.IClientService service, Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3BatchDeleteDocumentsRequest body, string dataset) : base(service)
                        {
                            Dataset = dataset;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The dataset resource name. Format:
                        /// projects/{project}/locations/{location}/processors/{processor}/dataset
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("dataset", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Dataset { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3BatchDeleteDocumentsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "batchDeleteDocuments";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta3/{+dataset}:batchDeleteDocuments";

                        /// <summary>Initializes BatchDeleteDocuments parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("dataset", new Google.Apis.Discovery.Parameter
                            {
                                Name = "dataset",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+/dataset$",
                            });
                        }
                    }

                    /// <summary>Gets the `DatasetSchema` of a `Dataset`.</summary>
                    /// <param name="name">
                    /// Required. The dataset schema resource name. Format:
                    /// projects/{project}/locations/{location}/processors/{processor}/dataset/datasetSchema
                    /// </param>
                    public virtual GetDatasetSchemaRequest GetDatasetSchema(string name)
                    {
                        return new GetDatasetSchemaRequest(this.service, name);
                    }

                    /// <summary>Gets the `DatasetSchema` of a `Dataset`.</summary>
                    public class GetDatasetSchemaRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3DatasetSchema>
                    {
                        /// <summary>Constructs a new GetDatasetSchema request.</summary>
                        public GetDatasetSchemaRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The dataset schema resource name. Format:
                        /// projects/{project}/locations/{location}/processors/{processor}/dataset/datasetSchema
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>If set, only returns the visible fields of the schema.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("visibleFieldsOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> VisibleFieldsOnly { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getDatasetSchema";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta3/{+name}";

                        /// <summary>Initializes GetDatasetSchema parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+/dataset/datasetSchema$",
                            });
                            RequestParameters.Add("visibleFieldsOnly", new Google.Apis.Discovery.Parameter
                            {
                                Name = "visibleFieldsOnly",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Returns relevant fields present in the requested document.</summary>
                    /// <param name="dataset">
                    /// Required. The resource name of the dataset that the document belongs to . Format:
                    /// projects/{project}/locations/{location}/processors/{processor}/dataset
                    /// </param>
                    public virtual GetDocumentRequest GetDocument(string dataset)
                    {
                        return new GetDocumentRequest(this.service, dataset);
                    }

                    /// <summary>Returns relevant fields present in the requested document.</summary>
                    public class GetDocumentRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3GetDocumentResponse>
                    {
                        /// <summary>Constructs a new GetDocument request.</summary>
                        public GetDocumentRequest(Google.Apis.Services.IClientService service, string dataset) : base(service)
                        {
                            Dataset = dataset;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the dataset that the document belongs to . Format:
                        /// projects/{project}/locations/{location}/processors/{processor}/dataset
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("dataset", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Dataset { get; private set; }

                        /// <summary>Id of the document (indexed) managed by Content Warehouse.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("documentId.gcsManagedDocId.cwDocId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string DocumentIdGcsManagedDocIdCwDocId { get; set; }

                        /// <summary>Required. The Cloud Storage URI where the actual document is stored.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("documentId.gcsManagedDocId.gcsUri", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string DocumentIdGcsManagedDocIdGcsUri { get; set; }

                        /// <summary>
                        /// Reads the revision generated by the processor version. The format takes the full resource
                        /// name of processor version.
                        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("documentId.revisionRef.latestProcessorVersion", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string DocumentIdRevisionRefLatestProcessorVersion { get; set; }

                        /// <summary>Reads the revision by the predefined case.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("documentId.revisionRef.revisionCase", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<DocumentIdRevisionRefRevisionCaseEnum> DocumentIdRevisionRefRevisionCase { get; set; }

                        /// <summary>Reads the revision by the predefined case.</summary>
                        public enum DocumentIdRevisionRefRevisionCaseEnum
                        {
                            /// <summary>Unspecified case, fall back to read the `LATEST_HUMAN_REVIEW`.</summary>
                            [Google.Apis.Util.StringValueAttribute("REVISION_CASE_UNSPECIFIED")]
                            REVISIONCASEUNSPECIFIED = 0,

                            /// <summary>The latest revision made by a human.</summary>
                            [Google.Apis.Util.StringValueAttribute("LATEST_HUMAN_REVIEW")]
                            LATESTHUMANREVIEW = 1,

                            /// <summary>The latest revision based on timestamp.</summary>
                            [Google.Apis.Util.StringValueAttribute("LATEST_TIMESTAMP")]
                            LATESTTIMESTAMP = 2,

                            /// <summary>The first (OCR) revision.</summary>
                            [Google.Apis.Util.StringValueAttribute("BASE_OCR_REVISION")]
                            BASEOCRREVISION = 3,
                        }

                        /// <summary>Reads the revision given by the id.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("documentId.revisionRef.revisionId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string DocumentIdRevisionRefRevisionId { get; set; }

                        /// <summary>Required. The id of the document.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("documentId.unmanagedDocId.docId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string DocumentIdUnmanagedDocIdDocId { get; set; }

                        /// <summary>Last page number (one-based index) to be returned.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageRange.end", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageRangeEnd { get; set; }

                        /// <summary>First page number (one-based index) to be returned.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageRange.start", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageRangeStart { get; set; }

                        /// <summary>
                        /// If set, only fields listed here will be returned. Otherwise, all fields will be returned by
                        /// default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object ReadMask { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getDocument";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta3/{+dataset}:getDocument";

                        /// <summary>Initializes GetDocument parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("dataset", new Google.Apis.Discovery.Parameter
                            {
                                Name = "dataset",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+/dataset$",
                            });
                            RequestParameters.Add("documentId.gcsManagedDocId.cwDocId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "documentId.gcsManagedDocId.cwDocId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("documentId.gcsManagedDocId.gcsUri", new Google.Apis.Discovery.Parameter
                            {
                                Name = "documentId.gcsManagedDocId.gcsUri",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("documentId.revisionRef.latestProcessorVersion", new Google.Apis.Discovery.Parameter
                            {
                                Name = "documentId.revisionRef.latestProcessorVersion",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("documentId.revisionRef.revisionCase", new Google.Apis.Discovery.Parameter
                            {
                                Name = "documentId.revisionRef.revisionCase",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("documentId.revisionRef.revisionId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "documentId.revisionRef.revisionId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("documentId.unmanagedDocId.docId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "documentId.unmanagedDocId.docId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("pageRange.end", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageRange.end",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("pageRange.start", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageRange.start",
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

                    /// <summary>Import documents into a dataset.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="dataset">
                    /// Required. The dataset resource name. Format:
                    /// projects/{project}/locations/{location}/processors/{processor}/dataset
                    /// </param>
                    public virtual ImportDocumentsRequest ImportDocuments(Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ImportDocumentsRequest body, string dataset)
                    {
                        return new ImportDocumentsRequest(this.service, body, dataset);
                    }

                    /// <summary>Import documents into a dataset.</summary>
                    public class ImportDocumentsRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new ImportDocuments request.</summary>
                        public ImportDocumentsRequest(Google.Apis.Services.IClientService service, Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ImportDocumentsRequest body, string dataset) : base(service)
                        {
                            Dataset = dataset;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The dataset resource name. Format:
                        /// projects/{project}/locations/{location}/processors/{processor}/dataset
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("dataset", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Dataset { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ImportDocumentsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "importDocuments";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta3/{+dataset}:importDocuments";

                        /// <summary>Initializes ImportDocuments parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("dataset", new Google.Apis.Discovery.Parameter
                            {
                                Name = "dataset",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+/dataset$",
                            });
                        }
                    }

                    /// <summary>Returns a list of documents present in the dataset.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="dataset">
                    /// Required. The resource name of the dataset to be listed. Format:
                    /// projects/{project}/locations/{location}/processors/{processor}/dataset
                    /// </param>
                    public virtual ListDocumentsRequest ListDocuments(Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ListDocumentsRequest body, string dataset)
                    {
                        return new ListDocumentsRequest(this.service, body, dataset);
                    }

                    /// <summary>Returns a list of documents present in the dataset.</summary>
                    public class ListDocumentsRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ListDocumentsResponse>
                    {
                        /// <summary>Constructs a new ListDocuments request.</summary>
                        public ListDocumentsRequest(Google.Apis.Services.IClientService service, Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ListDocumentsRequest body, string dataset) : base(service)
                        {
                            Dataset = dataset;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the dataset to be listed. Format:
                        /// projects/{project}/locations/{location}/processors/{processor}/dataset
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("dataset", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Dataset { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ListDocumentsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "listDocuments";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta3/{+dataset}:listDocuments";

                        /// <summary>Initializes ListDocuments parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("dataset", new Google.Apis.Discovery.Parameter
                            {
                                Name = "dataset",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+/dataset$",
                            });
                        }
                    }

                    /// <summary>Updates a `DatasetSchema`.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Dataset schema resource name. Format:
                    /// `projects/{project}/locations/{location}/processors/{processor}/dataset/datasetSchema`
                    /// </param>
                    public virtual UpdateDatasetSchemaRequest UpdateDatasetSchema(Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3DatasetSchema body, string name)
                    {
                        return new UpdateDatasetSchemaRequest(this.service, body, name);
                    }

                    /// <summary>Updates a `DatasetSchema`.</summary>
                    public class UpdateDatasetSchemaRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3DatasetSchema>
                    {
                        /// <summary>Constructs a new UpdateDatasetSchema request.</summary>
                        public UpdateDatasetSchemaRequest(Google.Apis.Services.IClientService service, Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3DatasetSchema body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Dataset schema resource name. Format:
                        /// `projects/{project}/locations/{location}/processors/{processor}/dataset/datasetSchema`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>The update mask applies to the resource.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3DatasetSchema Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "updateDatasetSchema";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta3/{+name}";

                        /// <summary>Initializes UpdateDatasetSchema parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+/dataset/datasetSchema$",
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

                /// <summary>Gets the HumanReviewConfig resource.</summary>
                public virtual HumanReviewConfigResource HumanReviewConfig { get; }

                /// <summary>The "humanReviewConfig" collection of methods.</summary>
                public class HumanReviewConfigResource
                {
                    private const string Resource = "humanReviewConfig";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public HumanReviewConfigResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Send a document for Human Review. The input document should be processed by the specified
                    /// processor.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="humanReviewConfig">
                    /// Required. The resource name of the HumanReviewConfig that the document will be reviewed with.
                    /// </param>
                    public virtual ReviewDocumentRequest ReviewDocument(Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ReviewDocumentRequest body, string humanReviewConfig)
                    {
                        return new ReviewDocumentRequest(this.service, body, humanReviewConfig);
                    }

                    /// <summary>
                    /// Send a document for Human Review. The input document should be processed by the specified
                    /// processor.
                    /// </summary>
                    public class ReviewDocumentRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new ReviewDocument request.</summary>
                        public ReviewDocumentRequest(Google.Apis.Services.IClientService service, Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ReviewDocumentRequest body, string humanReviewConfig) : base(service)
                        {
                            HumanReviewConfig = humanReviewConfig;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the HumanReviewConfig that the document will be reviewed
                        /// with.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("humanReviewConfig", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string HumanReviewConfig { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ReviewDocumentRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "reviewDocument";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta3/{+humanReviewConfig}:reviewDocument";

                        /// <summary>Initializes ReviewDocument parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("humanReviewConfig", new Google.Apis.Discovery.Parameter
                            {
                                Name = "humanReviewConfig",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+/humanReviewConfig$",
                            });
                        }
                    }
                }

                /// <summary>Gets the ProcessorVersions resource.</summary>
                public virtual ProcessorVersionsResource ProcessorVersions { get; }

                /// <summary>The "processorVersions" collection of methods.</summary>
                public class ProcessorVersionsResource
                {
                    private const string Resource = "processorVersions";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ProcessorVersionsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Evaluations = new EvaluationsResource(service);
                    }

                    /// <summary>Gets the Evaluations resource.</summary>
                    public virtual EvaluationsResource Evaluations { get; }

                    /// <summary>The "evaluations" collection of methods.</summary>
                    public class EvaluationsResource
                    {
                        private const string Resource = "evaluations";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public EvaluationsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Retrieves a specific evaluation.</summary>
                        /// <param name="name">
                        /// Required. The resource name of the Evaluation to get.
                        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}/evaluations/{evaluation}`
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>Retrieves a specific evaluation.</summary>
                        public class GetRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3Evaluation>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the Evaluation to get.
                            /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}/evaluations/{evaluation}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "get";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta3/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+/processorVersions/[^/]+/evaluations/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Retrieves a set of evaluations for a given processor version.</summary>
                        /// <param name="parent">
                        /// Required. The resource name of the ProcessorVersion to list evaluations for.
                        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>Retrieves a set of evaluations for a given processor version.</summary>
                        public class ListRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ListEvaluationsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the ProcessorVersion to list evaluations for.
                            /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// The standard list page size. If unspecified, at most `5` evaluations are returned. The
                            /// maximum value is `100`. Values above `100` are coerced to `100`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// A page token, received from a previous `ListEvaluations` call. Provide this to retrieve
                            /// the subsequent page.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta3/{+parent}/evaluations";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+/processorVersions/[^/]+$",
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

                    /// <summary>
                    /// LRO endpoint to batch process many documents. The output is written to Cloud Storage as JSON in
                    /// the [Document] format.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource name of Processor or ProcessorVersion. Format:
                    /// `projects/{project}/locations/{location}/processors/{processor}`, or
                    /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
                    /// </param>
                    public virtual BatchProcessRequest BatchProcess(Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3BatchProcessRequest body, string name)
                    {
                        return new BatchProcessRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// LRO endpoint to batch process many documents. The output is written to Cloud Storage as JSON in
                    /// the [Document] format.
                    /// </summary>
                    public class BatchProcessRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new BatchProcess request.</summary>
                        public BatchProcessRequest(Google.Apis.Services.IClientService service, Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3BatchProcessRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of Processor or ProcessorVersion. Format:
                        /// `projects/{project}/locations/{location}/processors/{processor}`, or
                        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3BatchProcessRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "batchProcess";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta3/{+name}:batchProcess";

                        /// <summary>Initializes BatchProcess parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+/processorVersions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes the processor version, all artifacts under the processor version will be deleted.
                    /// </summary>
                    /// <param name="name">Required. The processor version resource name to be deleted.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>
                    /// Deletes the processor version, all artifacts under the processor version will be deleted.
                    /// </summary>
                    public class DeleteRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The processor version resource name to be deleted.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta3/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+/processorVersions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Deploys the processor version.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. The processor version resource name to be deployed.</param>
                    public virtual DeployRequest Deploy(Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3DeployProcessorVersionRequest body, string name)
                    {
                        return new DeployRequest(this.service, body, name);
                    }

                    /// <summary>Deploys the processor version.</summary>
                    public class DeployRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Deploy request.</summary>
                        public DeployRequest(Google.Apis.Services.IClientService service, Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3DeployProcessorVersionRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The processor version resource name to be deployed.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3DeployProcessorVersionRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "deploy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta3/{+name}:deploy";

                        /// <summary>Initializes Deploy parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+/processorVersions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Evaluates a ProcessorVersion against annotated documents, producing an Evaluation.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="processorVersion">
                    /// Required. The resource name of the ProcessorVersion to evaluate.
                    /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
                    /// </param>
                    public virtual EvaluateProcessorVersionRequest EvaluateProcessorVersion(Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3EvaluateProcessorVersionRequest body, string processorVersion)
                    {
                        return new EvaluateProcessorVersionRequest(this.service, body, processorVersion);
                    }

                    /// <summary>
                    /// Evaluates a ProcessorVersion against annotated documents, producing an Evaluation.
                    /// </summary>
                    public class EvaluateProcessorVersionRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new EvaluateProcessorVersion request.</summary>
                        public EvaluateProcessorVersionRequest(Google.Apis.Services.IClientService service, Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3EvaluateProcessorVersionRequest body, string processorVersion) : base(service)
                        {
                            ProcessorVersion = processorVersion;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the ProcessorVersion to evaluate.
                        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("processorVersion", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProcessorVersion { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3EvaluateProcessorVersionRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "evaluateProcessorVersion";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta3/{+processorVersion}:evaluateProcessorVersion";

                        /// <summary>Initializes EvaluateProcessorVersion parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("processorVersion", new Google.Apis.Discovery.Parameter
                            {
                                Name = "processorVersion",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+/processorVersions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets a processor version detail.</summary>
                    /// <param name="name">Required. The processor resource name.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets a processor version detail.</summary>
                    public class GetRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ProcessorVersion>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The processor resource name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta3/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+/processorVersions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Imports a processor version from source processor version.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The destination processor name to create the processor version in. Format:
                    /// `projects/{project}/locations/{location}/processors/{processor}`
                    /// </param>
                    public virtual ImportProcessorVersionRequest ImportProcessorVersion(Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ImportProcessorVersionRequest body, string parent)
                    {
                        return new ImportProcessorVersionRequest(this.service, body, parent);
                    }

                    /// <summary>Imports a processor version from source processor version.</summary>
                    public class ImportProcessorVersionRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new ImportProcessorVersion request.</summary>
                        public ImportProcessorVersionRequest(Google.Apis.Services.IClientService service, Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ImportProcessorVersionRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The destination processor name to create the processor version in. Format:
                        /// `projects/{project}/locations/{location}/processors/{processor}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ImportProcessorVersionRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "importProcessorVersion";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta3/{+parent}/processorVersions:importProcessorVersion";

                        /// <summary>Initializes ImportProcessorVersion parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists all versions of a processor.</summary>
                    /// <param name="parent">
                    /// Required. The parent (project, location and processor) to list all versions. Format:
                    /// `projects/{project}/locations/{location}/processors/{processor}`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists all versions of a processor.</summary>
                    public class ListRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ListProcessorVersionsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent (project, location and processor) to list all versions. Format:
                        /// `projects/{project}/locations/{location}/processors/{processor}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of processor versions to return. If unspecified, at most `10` processor
                        /// versions will be returned. The maximum value is `20`. Values above `20` will be coerced to
                        /// `20`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// We will return the processor versions sorted by creation time. The page token will point to
                        /// the next processor version.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta3/{+parent}/processorVersions";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+$",
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

                    /// <summary>Processes a single document.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource name of the Processor or ProcessorVersion to use for processing. If a
                    /// Processor is specified, the server will use its default version. Format:
                    /// `projects/{project}/locations/{location}/processors/{processor}`, or
                    /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
                    /// </param>
                    public virtual ProcessRequest Process(Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ProcessRequest body, string name)
                    {
                        return new ProcessRequest(this.service, body, name);
                    }

                    /// <summary>Processes a single document.</summary>
                    public class ProcessRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ProcessResponse>
                    {
                        /// <summary>Constructs a new Process request.</summary>
                        public ProcessRequest(Google.Apis.Services.IClientService service, Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ProcessRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the Processor or ProcessorVersion to use for processing. If a
                        /// Processor is specified, the server will use its default version. Format:
                        /// `projects/{project}/locations/{location}/processors/{processor}`, or
                        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ProcessRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "process";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta3/{+name}:process";

                        /// <summary>Initializes Process parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+/processorVersions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Trains a new processor version. Operation metadata is returned as TrainProcessorVersionMetadata.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent (project, location and processor) to create the new version for. Format:
                    /// `projects/{project}/locations/{location}/processors/{processor}`.
                    /// </param>
                    public virtual TrainRequest Train(Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3TrainProcessorVersionRequest body, string parent)
                    {
                        return new TrainRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Trains a new processor version. Operation metadata is returned as TrainProcessorVersionMetadata.
                    /// </summary>
                    public class TrainRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Train request.</summary>
                        public TrainRequest(Google.Apis.Services.IClientService service, Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3TrainProcessorVersionRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent (project, location and processor) to create the new version for.
                        /// Format: `projects/{project}/locations/{location}/processors/{processor}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3TrainProcessorVersionRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "train";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta3/{+parent}/processorVersions:train";

                        /// <summary>Initializes Train parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Undeploys the processor version.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. The processor version resource name to be undeployed.</param>
                    public virtual UndeployRequest Undeploy(Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3UndeployProcessorVersionRequest body, string name)
                    {
                        return new UndeployRequest(this.service, body, name);
                    }

                    /// <summary>Undeploys the processor version.</summary>
                    public class UndeployRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Undeploy request.</summary>
                        public UndeployRequest(Google.Apis.Services.IClientService service, Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3UndeployProcessorVersionRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The processor version resource name to be undeployed.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3UndeployProcessorVersionRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "undeploy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta3/{+name}:undeploy";

                        /// <summary>Initializes Undeploy parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+/processorVersions/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>
                /// LRO endpoint to batch process many documents. The output is written to Cloud Storage as JSON in the
                /// [Document] format.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name of Processor or ProcessorVersion. Format:
                /// `projects/{project}/locations/{location}/processors/{processor}`, or
                /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
                /// </param>
                public virtual BatchProcessRequest BatchProcess(Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3BatchProcessRequest body, string name)
                {
                    return new BatchProcessRequest(this.service, body, name);
                }

                /// <summary>
                /// LRO endpoint to batch process many documents. The output is written to Cloud Storage as JSON in the
                /// [Document] format.
                /// </summary>
                public class BatchProcessRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new BatchProcess request.</summary>
                    public BatchProcessRequest(Google.Apis.Services.IClientService service, Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3BatchProcessRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of Processor or ProcessorVersion. Format:
                    /// `projects/{project}/locations/{location}/processors/{processor}`, or
                    /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3BatchProcessRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchProcess";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta3/{+name}:batchProcess";

                    /// <summary>Initializes BatchProcess parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Creates a processor from the ProcessorType provided. The processor will be at `ENABLED` state by
                /// default after its creation. Note that this method requires the `documentai.processors.create`
                /// permission on the project, which is highly privileged. A user or service account with this
                /// permission can create new processors that can interact with any gcs bucket in your project.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent (project and location) under which to create the processor. Format:
                /// `projects/{project}/locations/{location}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3Processor body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a processor from the ProcessorType provided. The processor will be at `ENABLED` state by
                /// default after its creation. Note that this method requires the `documentai.processors.create`
                /// permission on the project, which is highly privileged. A user or service account with this
                /// permission can create new processors that can interact with any gcs bucket in your project.
                /// </summary>
                public class CreateRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3Processor>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3Processor body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent (project and location) under which to create the processor. Format:
                    /// `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3Processor Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta3/{+parent}/processors";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes the processor, unloads all deployed model artifacts if it was enabled and then deletes all
                /// artifacts associated with this processor.
                /// </summary>
                /// <param name="name">Required. The processor resource name to be deleted.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes the processor, unloads all deployed model artifacts if it was enabled and then deletes all
                /// artifacts associated with this processor.
                /// </summary>
                public class DeleteRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The processor resource name to be deleted.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta3/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+$",
                        });
                    }
                }

                /// <summary>Disables a processor</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. The processor resource name to be disabled.</param>
                public virtual DisableRequest Disable(Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3DisableProcessorRequest body, string name)
                {
                    return new DisableRequest(this.service, body, name);
                }

                /// <summary>Disables a processor</summary>
                public class DisableRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Disable request.</summary>
                    public DisableRequest(Google.Apis.Services.IClientService service, Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3DisableProcessorRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The processor resource name to be disabled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3DisableProcessorRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "disable";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta3/{+name}:disable";

                    /// <summary>Initializes Disable parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+$",
                        });
                    }
                }

                /// <summary>Enables a processor</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. The processor resource name to be enabled.</param>
                public virtual EnableRequest Enable(Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3EnableProcessorRequest body, string name)
                {
                    return new EnableRequest(this.service, body, name);
                }

                /// <summary>Enables a processor</summary>
                public class EnableRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Enable request.</summary>
                    public EnableRequest(Google.Apis.Services.IClientService service, Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3EnableProcessorRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The processor resource name to be enabled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3EnableProcessorRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "enable";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta3/{+name}:enable";

                    /// <summary>Initializes Enable parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets a processor detail.</summary>
                /// <param name="name">Required. The processor resource name.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a processor detail.</summary>
                public class GetRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3Processor>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The processor resource name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta3/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all processors which belong to this project.</summary>
                /// <param name="parent">
                /// Required. The parent (project and location) which owns this collection of Processors. Format:
                /// `projects/{project}/locations/{location}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all processors which belong to this project.</summary>
                public class ListRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ListProcessorsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent (project and location) which owns this collection of Processors. Format:
                    /// `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of processors to return. If unspecified, at most `50` processors will be
                    /// returned. The maximum value is `100`. Values above `100` will be coerced to `100`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// We will return the processors sorted by creation time. The page token will point to the next
                    /// processor.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta3/{+parent}/processors";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
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

                /// <summary>Processes a single document.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name of the Processor or ProcessorVersion to use for processing. If a
                /// Processor is specified, the server will use its default version. Format:
                /// `projects/{project}/locations/{location}/processors/{processor}`, or
                /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
                /// </param>
                public virtual ProcessRequest Process(Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ProcessRequest body, string name)
                {
                    return new ProcessRequest(this.service, body, name);
                }

                /// <summary>Processes a single document.</summary>
                public class ProcessRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ProcessResponse>
                {
                    /// <summary>Constructs a new Process request.</summary>
                    public ProcessRequest(Google.Apis.Services.IClientService service, Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ProcessRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the Processor or ProcessorVersion to use for processing. If a
                    /// Processor is specified, the server will use its default version. Format:
                    /// `projects/{project}/locations/{location}/processors/{processor}`, or
                    /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3ProcessRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "process";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta3/{+name}:process";

                    /// <summary>Initializes Process parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Set the default (active) version of a Processor that will be used in ProcessDocument and
                /// BatchProcessDocuments.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="processor">
                /// Required. The resource name of the Processor to change default version.
                /// </param>
                public virtual SetDefaultProcessorVersionRequest SetDefaultProcessorVersion(Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3SetDefaultProcessorVersionRequest body, string processor)
                {
                    return new SetDefaultProcessorVersionRequest(this.service, body, processor);
                }

                /// <summary>
                /// Set the default (active) version of a Processor that will be used in ProcessDocument and
                /// BatchProcessDocuments.
                /// </summary>
                public class SetDefaultProcessorVersionRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new SetDefaultProcessorVersion request.</summary>
                    public SetDefaultProcessorVersionRequest(Google.Apis.Services.IClientService service, Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3SetDefaultProcessorVersionRequest body, string processor) : base(service)
                    {
                        Processor = processor;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the Processor to change default version.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("processor", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Processor { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3SetDefaultProcessorVersionRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setDefaultProcessorVersion";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta3/{+processor}:setDefaultProcessorVersion";

                    /// <summary>Initializes SetDefaultProcessorVersion parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("processor", new Google.Apis.Discovery.Parameter
                        {
                            Name = "processor",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Updates metadata associated with a dataset. Note that this method requires the
                /// `documentai.googleapis.com/datasets.update` permission on the project, which is highly privileged. A
                /// user or service account with this permission can create new processors that can interact with any
                /// gcs bucket in your project.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Dataset resource name. Format:
                /// `projects/{project}/locations/{location}/processors/{processor}/dataset`
                /// </param>
                public virtual UpdateDatasetRequest UpdateDataset(Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3Dataset body, string name)
                {
                    return new UpdateDatasetRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates metadata associated with a dataset. Note that this method requires the
                /// `documentai.googleapis.com/datasets.update` permission on the project, which is highly privileged. A
                /// user or service account with this permission can create new processors that can interact with any
                /// gcs bucket in your project.
                /// </summary>
                public class UpdateDatasetRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new UpdateDataset request.</summary>
                    public UpdateDatasetRequest(Google.Apis.Services.IClientService service, Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3Dataset body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Dataset resource name. Format:
                    /// `projects/{project}/locations/{location}/processors/{processor}/dataset`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The update mask applies to the resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3Dataset Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "updateDataset";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta3/{+name}";

                    /// <summary>Initializes UpdateDataset parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/processors/[^/]+/dataset$",
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

            /// <summary>
            /// Fetches processor types. Note that we don't use ListProcessorTypes here, because it isn't paginated.
            /// </summary>
            /// <param name="parent">
            /// Required. The location of processor types to list. Format: `projects/{project}/locations/{location}`.
            /// </param>
            public virtual FetchProcessorTypesRequest FetchProcessorTypes(string parent)
            {
                return new FetchProcessorTypesRequest(this.service, parent);
            }

            /// <summary>
            /// Fetches processor types. Note that we don't use ListProcessorTypes here, because it isn't paginated.
            /// </summary>
            public class FetchProcessorTypesRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleCloudDocumentaiV1beta3FetchProcessorTypesResponse>
            {
                /// <summary>Constructs a new FetchProcessorTypes request.</summary>
                public FetchProcessorTypesRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The location of processor types to list. Format:
                /// `projects/{project}/locations/{location}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "fetchProcessorTypes";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta3/{+parent}:fetchProcessorTypes";

                /// <summary>Initializes FetchProcessorTypes parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+$",
                    });
                }
            }

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleCloudLocationLocation>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Resource name for the location.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta3/{+name}";

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
                        Pattern = @"^projects/[^/]+/locations/[^/]+$",
                    });
                }
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta3.Data.GoogleCloudLocationListLocationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>The resource that owns the locations collection, if applicable.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. Do not use this field. It is unsupported and is ignored unless explicitly documented
                /// otherwise. This is primarily for internal usage.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("extraLocationTypes", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> ExtraLocationTypes { get; set; }

                /// <summary>
                /// A filter to narrow down results to a preferred subset. The filtering language accepts strings like
                /// `"displayName=tokyo"`, and is documented in more detail in [AIP-160](https://google.aip.dev/160).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// The maximum number of results to return. If not set, the service selects a default.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token received from the `next_page_token` field in the response. Send that page token to
                /// receive the subsequent page.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta3/{+name}/locations";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("extraLocationTypes", new Google.Apis.Discovery.Parameter
                    {
                        Name = "extraLocationTypes",
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
        }
    }
}
namespace Google.Apis.Document.v1beta3.Data
{
    /// <summary>
    /// Definition of the validation rules. Those are the input to the validator logic and they are used to validate a
    /// document.
    /// </summary>
    public class CloudAiDocumentaiLabHifiaToolsValidationValidatorInput : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("validationRules")]
        public virtual System.Collections.Generic.IList<CloudAiDocumentaiLabHifiaToolsValidationValidatorInputValidationRule> ValidationRules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CloudAiDocumentaiLabHifiaToolsValidationValidatorInputValidationRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the validation rule. This has no use but for documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("fieldOccurrences")]
        public virtual CloudAiDocumentaiLabHifiaToolsValidationValidatorInputValidationRuleFieldOccurrences FieldOccurrences { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("fieldRegex")]
        public virtual CloudAiDocumentaiLabHifiaToolsValidationValidatorInputValidationRuleFieldRegex FieldRegex { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("formValidation")]
        public virtual CloudAiDocumentaiLabHifiaToolsValidationValidatorInputValidationRuleFormValidation FormValidation { get; set; }

        /// <summary>Name of the validation rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The constant value used in the validation rules.</summary>
    public class CloudAiDocumentaiLabHifiaToolsValidationValidatorInputValidationRuleConstant : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("floatValue")]
        public virtual System.Nullable<float> FloatValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CloudAiDocumentaiLabHifiaToolsValidationValidatorInputValidationRuleField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Default value to use if the field is not present. If the field is missing and the default value is not set,
        /// the validation run as if the field is not present in the validation logic.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual CloudAiDocumentaiLabHifiaToolsValidationValidatorInputValidationRuleConstant DefaultValue { get; set; }

        /// <summary>
        /// The field name to validate. This can be a simple field name or a nested field one using the ':' (meant as an
        /// aggregator) or '*' (meant as foreach) operators.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldName")]
        public virtual string FieldName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CloudAiDocumentaiLabHifiaToolsValidationValidatorInputValidationRuleFieldOccurrences : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual CloudAiDocumentaiLabHifiaToolsValidationValidatorInputValidationRuleField Field { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("maxOccurrences")]
        public virtual System.Nullable<long> MaxOccurrences { get; set; }

        /// <summary>
        /// Min and max occurrences of the field. If not set, there is limit set. The defined interval is a
        /// closed-closed interval, i.e. [min, max].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minOccurrences")]
        public virtual System.Nullable<long> MinOccurrences { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CloudAiDocumentaiLabHifiaToolsValidationValidatorInputValidationRuleFieldRegex : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual CloudAiDocumentaiLabHifiaToolsValidationValidatorInputValidationRuleField Field { get; set; }

        /// <summary>Python regex to validate the field values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pattern")]
        public virtual string Pattern { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CloudAiDocumentaiLabHifiaToolsValidationValidatorInputValidationRuleFormValidation : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("leftOperand")]
        public virtual CloudAiDocumentaiLabHifiaToolsValidationValidatorInputValidationRuleFormValidationOperation LeftOperand { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("rightOperand")]
        public virtual CloudAiDocumentaiLabHifiaToolsValidationValidatorInputValidationRuleFormValidationOperation RightOperand { get; set; }

        /// <summary>The relational operator to be applied to the operands.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validationOperator")]
        public virtual string ValidationOperator { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CloudAiDocumentaiLabHifiaToolsValidationValidatorInputValidationRuleFormValidationOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of constants to be used as operands.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constants")]
        public virtual System.Collections.Generic.IList<CloudAiDocumentaiLabHifiaToolsValidationValidatorInputValidationRuleConstant> Constants { get; set; }

        /// <summary>A list of fields to be used as operands.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<CloudAiDocumentaiLabHifiaToolsValidationValidatorInputValidationRuleField> Fields { get; set; }

        /// <summary>The operation type to be applied to all the operands.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationType")]
        public virtual string OperationType { get; set; }

        /// <summary>A list of recursive operations to be used as operands.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<CloudAiDocumentaiLabHifiaToolsValidationValidatorInputValidationRuleFormValidationOperation> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of the auto-labeling documents operation.</summary>
    public class GoogleCloudDocumentaiUiv1beta3AutoLabelDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The list of individual auto-labeling statuses of the dataset documents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualAutoLabelStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiUiv1beta3AutoLabelDocumentsMetadataIndividualAutoLabelStatus> IndividualAutoLabelStatuses { get; set; }

        /// <summary>Total number of the auto-labeling documents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalDocumentCount")]
        public virtual System.Nullable<int> TotalDocumentCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of individual documents in the auto-labeling process.</summary>
    public class GoogleCloudDocumentaiUiv1beta3AutoLabelDocumentsMetadataIndividualAutoLabelStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The document id of the auto-labeled document. This will replace the gcs_uri.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
        public virtual GoogleCloudDocumentaiUiv1beta3DocumentId DocumentId { get; set; }

        /// <summary>The status of the document auto-labeling.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response proto of AutoLabelDocuments method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3AutoLabelDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDocumentaiUiv1beta3BatchDeleteDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>Total number of documents that failed to be deleted in storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorDocumentCount")]
        public virtual System.Nullable<int> ErrorDocumentCount { get; set; }

        /// <summary>The list of response details of each document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualBatchDeleteStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiUiv1beta3BatchDeleteDocumentsMetadataIndividualBatchDeleteStatus> IndividualBatchDeleteStatuses { get; set; }

        /// <summary>Total number of documents deleting from dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalDocumentCount")]
        public virtual System.Nullable<int> TotalDocumentCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of each individual document in the batch delete process.</summary>
    public class GoogleCloudDocumentaiUiv1beta3BatchDeleteDocumentsMetadataIndividualBatchDeleteStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The document id of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
        public virtual GoogleCloudDocumentaiUiv1beta3DocumentId DocumentId { get; set; }

        /// <summary>The status of deleting the document in storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of the delete documents operation.</summary>
    public class GoogleCloudDocumentaiUiv1beta3BatchDeleteDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDocumentaiUiv1beta3BatchMoveDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The destination dataset split type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destDatasetType")]
        public virtual string DestDatasetType { get; set; }

        /// <summary>The destination dataset split type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destSplitType")]
        public virtual string DestSplitType { get; set; }

        /// <summary>The list of response details of each document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualBatchMoveStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiUiv1beta3BatchMoveDocumentsMetadataIndividualBatchMoveStatus> IndividualBatchMoveStatuses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of each individual document in the batch move process.</summary>
    public class GoogleCloudDocumentaiUiv1beta3BatchMoveDocumentsMetadataIndividualBatchMoveStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The document id of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
        public virtual GoogleCloudDocumentaiUiv1beta3DocumentId DocumentId { get; set; }

        /// <summary>The status of moving the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of the batch move documents operation.</summary>
    public class GoogleCloudDocumentaiUiv1beta3BatchMoveDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDocumentaiUiv1beta3BatchUpdateDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The list of response details of each document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualBatchUpdateStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiUiv1beta3BatchUpdateDocumentsMetadataIndividualBatchUpdateStatus> IndividualBatchUpdateStatuses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of each individual document in the batch update process.</summary>
    public class GoogleCloudDocumentaiUiv1beta3BatchUpdateDocumentsMetadataIndividualBatchUpdateStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The document id of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
        public virtual GoogleCloudDocumentaiUiv1beta3DocumentId DocumentId { get; set; }

        /// <summary>The status of updating the document in storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of the batch update documents operation.</summary>
    public class GoogleCloudDocumentaiUiv1beta3BatchUpdateDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The common metadata for long running operations.</summary>
    public class GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The creation time of the operation.</summary>
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

        /// <summary>A related resource to this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>The state of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>A message providing more details about the current state of processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The last update time of the operation.</summary>
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

    /// <summary>The long-running operation metadata for the CreateLabelerPool method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3CreateLabelerPoolOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for DeleteLabelerPool.</summary>
    public class GoogleCloudDocumentaiUiv1beta3DeleteLabelerPoolOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the DeleteProcessor method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3DeleteProcessorMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the DeleteProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3DeleteProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the DeployProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3DeployProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the DeployProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3DeployProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the DisableProcessor method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3DisableProcessorMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for the DisableProcessor method. Intentionally empty proto for adding fields in future.
    /// </summary>
    public class GoogleCloudDocumentaiUiv1beta3DisableProcessorResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Document Identifier.</summary>
    public class GoogleCloudDocumentaiUiv1beta3DocumentId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A document id within user-managed Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsManagedDocId")]
        public virtual GoogleCloudDocumentaiUiv1beta3DocumentIdGCSManagedDocumentId GcsManagedDocId { get; set; }

        /// <summary>Points to a specific revision of the document if set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionRef")]
        public virtual GoogleCloudDocumentaiUiv1beta3RevisionRef RevisionRef { get; set; }

        /// <summary>A document id within unmanaged dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unmanagedDocId")]
        public virtual GoogleCloudDocumentaiUiv1beta3DocumentIdUnmanagedDocumentId UnmanagedDocId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Identifies a document uniquely within the scope of a dataset in the user-managed Cloud Storage option.
    /// </summary>
    public class GoogleCloudDocumentaiUiv1beta3DocumentIdGCSManagedDocumentId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Id of the document (indexed) managed by Content Warehouse.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cwDocId")]
        public virtual string CwDocId { get; set; }

        /// <summary>Required. The Cloud Storage URI where the actual document is stored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsUri")]
        public virtual string GcsUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identifies a document uniquely within the scope of a dataset in unmanaged option.</summary>
    public class GoogleCloudDocumentaiUiv1beta3DocumentIdUnmanagedDocumentId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The id of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("docId")]
        public virtual string DocId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the EnableProcessor method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3EnableProcessorMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for the EnableProcessor method. Intentionally empty proto for adding fields in future.
    /// </summary>
    public class GoogleCloudDocumentaiUiv1beta3EnableProcessorResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of the EvaluateProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3EvaluateProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of the EvaluateProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3EvaluateProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name of the created evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluation")]
        public virtual string Evaluation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of the batch export documents operation.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ExportDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The list of response details of each document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualExportStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiUiv1beta3ExportDocumentsMetadataIndividualExportStatus> IndividualExportStatuses { get; set; }

        /// <summary>The list of statistics for each dataset split type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("splitExportStats")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiUiv1beta3ExportDocumentsMetadataSplitExportStat> SplitExportStats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of each individual document in the export process.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ExportDocumentsMetadataIndividualExportStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The path to source docproto of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
        public virtual GoogleCloudDocumentaiUiv1beta3DocumentId DocumentId { get; set; }

        /// <summary>
        /// The output_gcs_destination of the exported document if it was successful, otherwise empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputGcsDestination")]
        public virtual string OutputGcsDestination { get; set; }

        /// <summary>The status of the exporting of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The statistic representing a dataset split type for this export.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ExportDocumentsMetadataSplitExportStat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The dataset split type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("splitType")]
        public virtual string SplitType { get; set; }

        /// <summary>Total number of documents with the given dataset split type to be exported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalDocumentCount")]
        public virtual System.Nullable<int> TotalDocumentCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response proto of ExportDocuments method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ExportDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata message associated with the ExportProcessorVersion operation.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ExportProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The common metadata about the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message associated with the ExportProcessorVersion operation.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ExportProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Cloud Storage URI containing the output artifacts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsUri")]
        public virtual string GcsUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of the import document operation.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ImportDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>Validation statuses of the batch documents import config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importConfigValidationResults")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiUiv1beta3ImportDocumentsMetadataImportConfigValidationResult> ImportConfigValidationResults { get; set; }

        /// <summary>The list of response details of each document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualImportStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiUiv1beta3ImportDocumentsMetadataIndividualImportStatus> IndividualImportStatuses { get; set; }

        /// <summary>Total number of the documents that are qualified for importing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalDocumentCount")]
        public virtual System.Nullable<int> TotalDocumentCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The validation status of each import config. Status is set to an error if there are no documents to import in
    /// the `import_config`, or `OK` if the operation will try to proceed with at least one document.
    /// </summary>
    public class GoogleCloudDocumentaiUiv1beta3ImportDocumentsMetadataImportConfigValidationResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The source Cloud Storage URI specified in the import config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputGcsSource")]
        public virtual string InputGcsSource { get; set; }

        /// <summary>The validation status of import config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of each individual document in the import process.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ImportDocumentsMetadataIndividualImportStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The source Cloud Storage URI of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputGcsSource")]
        public virtual string InputGcsSource { get; set; }

        /// <summary>The document id of imported document if it was successful, otherwise empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputDocumentId")]
        public virtual GoogleCloudDocumentaiUiv1beta3DocumentId OutputDocumentId { get; set; }

        /// <summary>
        /// The output_gcs_destination of the processed document if it was successful, otherwise empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputGcsDestination")]
        public virtual string OutputGcsDestination { get; set; }

        /// <summary>The status of the importing of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of the import document operation.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ImportDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the ImportProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ImportProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata for the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for the ImportProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ImportProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The destination processor version name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processorVersion")]
        public virtual string ProcessorVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata proto of `ResyncDataset` method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ResyncDatasetMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>
        /// The list of dataset resync statuses. Not checked when ResyncDatasetRequest.dataset_documents is specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetResyncStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiUiv1beta3ResyncDatasetMetadataDatasetResyncStatus> DatasetResyncStatuses { get; set; }

        /// <summary>
        /// The list of document resync statuses. The same document could have multiple
        /// `individual_document_resync_statuses` if it has multiple inconsistencies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualDocumentResyncStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiUiv1beta3ResyncDatasetMetadataIndividualDocumentResyncStatus> IndividualDocumentResyncStatuses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resync status against inconsistency types on the dataset level.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ResyncDatasetMetadataDatasetResyncStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of the inconsistency of the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetInconsistencyType")]
        public virtual string DatasetInconsistencyType { get; set; }

        /// <summary>
        /// The status of resyncing the dataset with regards to the detected inconsistency. Empty if
        /// ResyncDatasetRequest.validate_only is `true`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resync status for each document per inconsistency type.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ResyncDatasetMetadataIndividualDocumentResyncStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The document identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
        public virtual GoogleCloudDocumentaiUiv1beta3DocumentId DocumentId { get; set; }

        /// <summary>The type of document inconsistency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentInconsistencyType")]
        public virtual string DocumentInconsistencyType { get; set; }

        /// <summary>
        /// The status of resyncing the document with regards to the detected inconsistency. Empty if
        /// ResyncDatasetRequest.validate_only is `true`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response proto of ResyncDataset method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ResyncDatasetResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The revision reference specifies which revision on the document to read.</summary>
    public class GoogleCloudDocumentaiUiv1beta3RevisionRef : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Reads the revision generated by the processor version. The format takes the full resource name of processor
        /// version.
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestProcessorVersion")]
        public virtual string LatestProcessorVersion { get; set; }

        /// <summary>Reads the revision by the predefined case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionCase")]
        public virtual string RevisionCase { get; set; }

        /// <summary>Reads the revision given by the id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of the sample documents operation.</summary>
    public class GoogleCloudDocumentaiUiv1beta3SampleDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of the sample documents operation.</summary>
    public class GoogleCloudDocumentaiUiv1beta3SampleDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of sampling documents in test split.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleTestStatus")]
        public virtual GoogleRpcStatus SampleTestStatus { get; set; }

        /// <summary>The status of sampling documents in training split.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleTrainingStatus")]
        public virtual GoogleRpcStatus SampleTrainingStatus { get; set; }

        /// <summary>The result of the sampling process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectedDocuments")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiUiv1beta3SampleDocumentsResponseSelectedDocument> SelectedDocuments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDocumentaiUiv1beta3SampleDocumentsResponseSelectedDocument : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An internal identifier for document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
        public virtual string DocumentId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the SetDefaultProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3SetDefaultProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the SetDefaultProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3SetDefaultProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata that represents a processor version being created.</summary>
    public class GoogleCloudDocumentaiUiv1beta3TrainProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The test dataset validation information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testDatasetValidation")]
        public virtual GoogleCloudDocumentaiUiv1beta3TrainProcessorVersionMetadataDatasetValidation TestDatasetValidation { get; set; }

        /// <summary>The training dataset validation information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingDatasetValidation")]
        public virtual GoogleCloudDocumentaiUiv1beta3TrainProcessorVersionMetadataDatasetValidation TrainingDatasetValidation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The dataset validation information. This includes any and all errors with documents and the dataset.
    /// </summary>
    public class GoogleCloudDocumentaiUiv1beta3TrainProcessorVersionMetadataDatasetValidation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total number of dataset errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetErrorCount")]
        public virtual System.Nullable<int> DatasetErrorCount { get; set; }

        /// <summary>
        /// Error information for the dataset as a whole. A maximum of 10 dataset errors will be returned. A single
        /// dataset error is terminal for training.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetErrors")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> DatasetErrors { get; set; }

        /// <summary>The total number of document errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentErrorCount")]
        public virtual System.Nullable<int> DocumentErrorCount { get; set; }

        /// <summary>
        /// Error information pertaining to specific documents. A maximum of 10 document errors will be returned. Any
        /// document with errors will not be used throughout training.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentErrors")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> DocumentErrors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for TrainProcessorVersion.</summary>
    public class GoogleCloudDocumentaiUiv1beta3TrainProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name of the processor version produced by training.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processorVersion")]
        public virtual string ProcessorVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the UndeployProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3UndeployProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the UndeployProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3UndeployProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDocumentaiUiv1beta3UpdateDatasetOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for updating the human review configuration.</summary>
    public class GoogleCloudDocumentaiUiv1beta3UpdateHumanReviewConfigMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for UpdateLabelerPool.</summary>
    public class GoogleCloudDocumentaiUiv1beta3UpdateLabelerPoolOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for BatchProcessDocuments.</summary>
    public class GoogleCloudDocumentaiV1BatchProcessMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The creation time of the operation.</summary>
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

        /// <summary>The list of response details of each document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualProcessStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1BatchProcessMetadataIndividualProcessStatus> IndividualProcessStatuses { get; set; }

        /// <summary>The state of the current batch processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// A message providing more details about the current state of processing. For example, the error message if
        /// the operation is failed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The last update time of the operation.</summary>
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

    /// <summary>The status of a each individual document in the batch process.</summary>
    public class GoogleCloudDocumentaiV1BatchProcessMetadataIndividualProcessStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of human review on the processed document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("humanReviewStatus")]
        public virtual GoogleCloudDocumentaiV1HumanReviewStatus HumanReviewStatus { get; set; }

        /// <summary>
        /// The source of the document, same as the input_gcs_source field in the request when the batch process
        /// started.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputGcsSource")]
        public virtual string InputGcsSource { get; set; }

        /// <summary>
        /// The Cloud Storage output destination (in the request as DocumentOutputConfig.GcsOutputConfig.gcs_uri) of the
        /// processed document if it was successful, otherwise empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputGcsDestination")]
        public virtual string OutputGcsDestination { get; set; }

        /// <summary>The status processing the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BatchProcessDocuments.</summary>
    public class GoogleCloudDocumentaiV1BatchProcessResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The common metadata for long running operations.</summary>
    public class GoogleCloudDocumentaiV1CommonOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The creation time of the operation.</summary>
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

        /// <summary>A related resource to this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>The state of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>A message providing more details about the current state of processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The last update time of the operation.</summary>
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

    /// <summary>The long-running operation metadata for the DeleteProcessor method.</summary>
    public class GoogleCloudDocumentaiV1DeleteProcessorMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the DeleteProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1DeleteProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the DeployProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1DeployProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the DeployProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1DeployProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the DisableProcessor method.</summary>
    public class GoogleCloudDocumentaiV1DisableProcessorMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for the DisableProcessor method. Intentionally empty proto for adding fields in future.
    /// </summary>
    public class GoogleCloudDocumentaiV1DisableProcessorResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the EnableProcessor method.</summary>
    public class GoogleCloudDocumentaiV1EnableProcessorMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for the EnableProcessor method. Intentionally empty proto for adding fields in future.
    /// </summary>
    public class GoogleCloudDocumentaiV1EnableProcessorResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of the EvaluateProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1EvaluateProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of the EvaluateProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1EvaluateProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name of the created evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluation")]
        public virtual string Evaluation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of human review on a processed document.</summary>
    public class GoogleCloudDocumentaiV1HumanReviewStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the operation triggered by the processed document. This field is populated only when the state
        /// is `HUMAN_REVIEW_IN_PROGRESS`. It has the same response type and metadata as the long-running operation
        /// returned by ReviewDocument.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("humanReviewOperation")]
        public virtual string HumanReviewOperation { get; set; }

        /// <summary>The state of human review on the processing request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>A message providing more details about the human review state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the ReviewDocument method.</summary>
    public class GoogleCloudDocumentaiV1ReviewDocumentOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The Crowd Compute question ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("questionId")]
        public virtual string QuestionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the ReviewDocument method.</summary>
    public class GoogleCloudDocumentaiV1ReviewDocumentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Cloud Storage uri for the human reviewed document if the review is succeeded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual string GcsDestination { get; set; }

        /// <summary>The reason why the review is rejected by reviewer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rejectionReason")]
        public virtual string RejectionReason { get; set; }

        /// <summary>The state of the review operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the SetDefaultProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1SetDefaultProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the SetDefaultProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1SetDefaultProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata that represents a processor version being created.</summary>
    public class GoogleCloudDocumentaiV1TrainProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The test dataset validation information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testDatasetValidation")]
        public virtual GoogleCloudDocumentaiV1TrainProcessorVersionMetadataDatasetValidation TestDatasetValidation { get; set; }

        /// <summary>The training dataset validation information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingDatasetValidation")]
        public virtual GoogleCloudDocumentaiV1TrainProcessorVersionMetadataDatasetValidation TrainingDatasetValidation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The dataset validation information. This includes any and all errors with documents and the dataset.
    /// </summary>
    public class GoogleCloudDocumentaiV1TrainProcessorVersionMetadataDatasetValidation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total number of dataset errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetErrorCount")]
        public virtual System.Nullable<int> DatasetErrorCount { get; set; }

        /// <summary>
        /// Error information for the dataset as a whole. A maximum of 10 dataset errors will be returned. A single
        /// dataset error is terminal for training.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetErrors")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> DatasetErrors { get; set; }

        /// <summary>The total number of document errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentErrorCount")]
        public virtual System.Nullable<int> DocumentErrorCount { get; set; }

        /// <summary>
        /// Error information pertaining to specific documents. A maximum of 10 document errors will be returned. Any
        /// document with errors will not be used throughout training.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentErrors")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> DocumentErrors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for TrainProcessorVersion.</summary>
    public class GoogleCloudDocumentaiV1TrainProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name of the processor version produced by training.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processorVersion")]
        public virtual string ProcessorVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the UndeployProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1UndeployProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the UndeployProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1UndeployProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encodes the detailed information of a barcode.</summary>
    public class GoogleCloudDocumentaiV1beta3Barcode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Format of a barcode. The supported formats are: - `CODE_128`: Code 128 type. - `CODE_39`: Code 39 type. -
        /// `CODE_93`: Code 93 type. - `CODABAR`: Codabar type. - `DATA_MATRIX`: 2D Data Matrix type. - `ITF`: ITF type.
        /// - `EAN_13`: EAN-13 type. - `EAN_8`: EAN-8 type. - `QR_CODE`: 2D QR code type. - `UPC_A`: UPC-A type. -
        /// `UPC_E`: UPC-E type. - `PDF417`: PDF417 type. - `AZTEC`: 2D Aztec code type. - `DATABAR`: GS1 DataBar code
        /// type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>
        /// Raw value encoded in the barcode. For example: `'MEBKM:TITLE:Google;URL:https://www.google.com;;'`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawValue")]
        public virtual string RawValue { get; set; }

        /// <summary>
        /// Value format describes the format of the value that a barcode encodes. The supported formats are: -
        /// `CONTACT_INFO`: Contact information. - `EMAIL`: Email address. - `ISBN`: ISBN identifier. - `PHONE`: Phone
        /// number. - `PRODUCT`: Product. - `SMS`: SMS message. - `TEXT`: Text string. - `URL`: URL address. - `WIFI`:
        /// Wifi information. - `GEO`: Geo-localization. - `CALENDAR_EVENT`: Calendar event. - `DRIVER_LICENSE`:
        /// Driver's license.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueFormat")]
        public virtual string ValueFormat { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Dataset documents that the batch operation will be applied to.</summary>
    public class GoogleCloudDocumentaiV1beta3BatchDatasetDocuments : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A filter matching the documents. Follows the same format and restriction as
        /// [google.cloud.documentai.master.ListDocumentsRequest.filter].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>Document identifiers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualDocumentIds")]
        public virtual GoogleCloudDocumentaiV1beta3BatchDatasetDocumentsIndividualDocumentIds IndividualDocumentIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of individual DocumentIds.</summary>
    public class GoogleCloudDocumentaiV1beta3BatchDatasetDocumentsIndividualDocumentIds : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. List of Document IDs indicating where the actual documents are stored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentIds")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentId> DocumentIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDocumentaiV1beta3BatchDeleteDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>Total number of documents that failed to be deleted in storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorDocumentCount")]
        public virtual System.Nullable<int> ErrorDocumentCount { get; set; }

        /// <summary>The list of response details of each document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualBatchDeleteStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3BatchDeleteDocumentsMetadataIndividualBatchDeleteStatus> IndividualBatchDeleteStatuses { get; set; }

        /// <summary>Total number of documents deleting from dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalDocumentCount")]
        public virtual System.Nullable<int> TotalDocumentCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of each individual document in the batch delete process.</summary>
    public class GoogleCloudDocumentaiV1beta3BatchDeleteDocumentsMetadataIndividualBatchDeleteStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The document id of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentId DocumentId { get; set; }

        /// <summary>The status of deleting the document in storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDocumentaiV1beta3BatchDeleteDocumentsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Dataset documents input. If given `filter`, all documents satisfying the filter will be deleted.
        /// If given documentIds, a maximum of 50 documents can be deleted in a batch. The request will be rejected if
        /// more than 50 document_ids are provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetDocuments")]
        public virtual GoogleCloudDocumentaiV1beta3BatchDatasetDocuments DatasetDocuments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of the delete documents operation.</summary>
    public class GoogleCloudDocumentaiV1beta3BatchDeleteDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The common config to specify a set of documents used as input.</summary>
    public class GoogleCloudDocumentaiV1beta3BatchDocumentsInputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The set of documents individually specified on Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDocuments")]
        public virtual GoogleCloudDocumentaiV1beta3GcsDocuments GcsDocuments { get; set; }

        /// <summary>The set of documents that match the specified Cloud Storage `gcs_prefix`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsPrefix")]
        public virtual GoogleCloudDocumentaiV1beta3GcsPrefix GcsPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for BatchProcessDocuments.</summary>
    public class GoogleCloudDocumentaiV1beta3BatchProcessMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The creation time of the operation.</summary>
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

        /// <summary>The list of response details of each document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualProcessStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3BatchProcessMetadataIndividualProcessStatus> IndividualProcessStatuses { get; set; }

        /// <summary>The state of the current batch processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// A message providing more details about the current state of processing. For example, the error message if
        /// the operation is failed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The last update time of the operation.</summary>
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

    /// <summary>The status of a each individual document in the batch process.</summary>
    public class GoogleCloudDocumentaiV1beta3BatchProcessMetadataIndividualProcessStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the operation triggered by the processed document. If the human review process isn't triggered,
        /// this field will be empty. It has the same response type and metadata as the long-running operation returned
        /// by the ReviewDocument method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("humanReviewOperation")]
        public virtual string HumanReviewOperation { get; set; }

        /// <summary>The status of human review on the processed document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("humanReviewStatus")]
        public virtual GoogleCloudDocumentaiV1beta3HumanReviewStatus HumanReviewStatus { get; set; }

        /// <summary>
        /// The source of the document, same as the input_gcs_source field in the request when the batch process
        /// started.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputGcsSource")]
        public virtual string InputGcsSource { get; set; }

        /// <summary>
        /// The Cloud Storage output destination (in the request as DocumentOutputConfig.GcsOutputConfig.gcs_uri) of the
        /// processed document if it was successful, otherwise empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputGcsDestination")]
        public virtual string OutputGcsDestination { get; set; }

        /// <summary>The status processing the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for BatchProcessDocuments.</summary>
    public class GoogleCloudDocumentaiV1beta3BatchProcessRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The output configuration for the BatchProcessDocuments method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentOutputConfig")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentOutputConfig DocumentOutputConfig { get; set; }

        /// <summary>The input config for each single document in the batch process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfigs")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3BatchProcessRequestBatchInputConfig> InputConfigs { get; set; }

        /// <summary>The input documents for the BatchProcessDocuments method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputDocuments")]
        public virtual GoogleCloudDocumentaiV1beta3BatchDocumentsInputConfig InputDocuments { get; set; }

        /// <summary>
        /// Optional. The labels with user-defined metadata for the request. Label keys and values can be no longer than
        /// 63 characters (Unicode codepoints) and can only contain lowercase letters, numeric characters, underscores,
        /// and dashes. International characters are allowed. Label values are optional. Label keys must start with a
        /// letter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The overall output config for batch process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual GoogleCloudDocumentaiV1beta3BatchProcessRequestBatchOutputConfig OutputConfig { get; set; }

        /// <summary>Inference-time options for the process API</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processOptions")]
        public virtual GoogleCloudDocumentaiV1beta3ProcessOptions ProcessOptions { get; set; }

        /// <summary>Whether human review should be skipped for this request. Default to `false`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipHumanReview")]
        public virtual System.Nullable<bool> SkipHumanReview { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The message for input config in batch process.</summary>
    public class GoogleCloudDocumentaiV1beta3BatchProcessRequestBatchInputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Cloud Storage location as the source of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual string GcsSource { get; set; }

        /// <summary>
        /// An IANA published [media type (MIME type)](https://www.iana.org/assignments/media-types/media-types.xhtml)
        /// of the input. If the input is a raw document, refer to [supported file
        /// types](https://cloud.google.com/document-ai/docs/file-types) for the list of media types. If the input is a
        /// Document, the type should be `application/json`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The output configuration in the BatchProcessDocuments method.</summary>
    public class GoogleCloudDocumentaiV1beta3BatchProcessRequestBatchOutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The output Cloud Storage directory to put the processed documents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual string GcsDestination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BatchProcessDocuments.</summary>
    public class GoogleCloudDocumentaiV1beta3BatchProcessResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A bounding polygon for the detected image annotation.</summary>
    public class GoogleCloudDocumentaiV1beta3BoundingPoly : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bounding polygon normalized vertices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedVertices")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3NormalizedVertex> NormalizedVertices { get; set; }

        /// <summary>The bounding polygon vertices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertices")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3Vertex> Vertices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The common metadata for long running operations.</summary>
    public class GoogleCloudDocumentaiV1beta3CommonOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The creation time of the operation.</summary>
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

        /// <summary>A related resource to this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>The state of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>A message providing more details about the current state of processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The last update time of the operation.</summary>
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

    /// <summary>A singleton resource under a Processor which configures a collection of documents.</summary>
    public class GoogleCloudDocumentaiV1beta3Dataset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Deprecated. Warehouse-based dataset configuration is not supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentWarehouseConfig")]
        public virtual GoogleCloudDocumentaiV1beta3DatasetDocumentWarehouseConfig DocumentWarehouseConfig { get; set; }

        /// <summary>
        /// Optional. User-managed Cloud Storage dataset configuration. Use this configuration if the dataset documents
        /// are stored under a user-managed Cloud Storage location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsManagedConfig")]
        public virtual GoogleCloudDocumentaiV1beta3DatasetGCSManagedConfig GcsManagedConfig { get; set; }

        /// <summary>
        /// Dataset resource name. Format: `projects/{project}/locations/{location}/processors/{processor}/dataset`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>
        /// Optional. A lightweight indexing source with low latency and high reliability, but lacking advanced features
        /// like CMEK and content-based search.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spannerIndexingConfig")]
        public virtual GoogleCloudDocumentaiV1beta3DatasetSpannerIndexingConfig SpannerIndexingConfig { get; set; }

        /// <summary>Required. State of the dataset. Ignored when updating dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Optional. Unmanaged dataset configuration. Use this configuration if the dataset documents are managed by
        /// the document service internally (not user-managed).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unmanagedDatasetConfig")]
        public virtual GoogleCloudDocumentaiV1beta3DatasetUnmanagedDatasetConfig UnmanagedDatasetConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration specific to the Document AI Warehouse-based implementation.</summary>
    public class GoogleCloudDocumentaiV1beta3DatasetDocumentWarehouseConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The collection in Document AI Warehouse associated with the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collection")]
        public virtual string Collection { get; set; }

        /// <summary>Output only. The schema in Document AI Warehouse associated with the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual string Schema { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration specific to the Cloud Storage-based implementation.</summary>
    public class GoogleCloudDocumentaiV1beta3DatasetGCSManagedConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The Cloud Storage URI (a directory) where the documents belonging to the dataset must be stored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsPrefix")]
        public virtual GoogleCloudDocumentaiV1beta3GcsPrefix GcsPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Dataset Schema.</summary>
    public class GoogleCloudDocumentaiV1beta3DatasetSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Schema of the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentSchema")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentSchema DocumentSchema { get; set; }

        /// <summary>
        /// Dataset schema resource name. Format:
        /// `projects/{project}/locations/{location}/processors/{processor}/dataset/datasetSchema`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration specific to spanner-based indexing.</summary>
    public class GoogleCloudDocumentaiV1beta3DatasetSpannerIndexingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration specific to an unmanaged dataset.</summary>
    public class GoogleCloudDocumentaiV1beta3DatasetUnmanagedDatasetConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the DeleteProcessor method.</summary>
    public class GoogleCloudDocumentaiV1beta3DeleteProcessorMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the DeleteProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1beta3DeleteProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the DeployProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1beta3DeployProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the DeployProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1beta3DeployProcessorVersionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the DeployProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1beta3DeployProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the DisableProcessor method.</summary>
    public class GoogleCloudDocumentaiV1beta3DisableProcessorMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the DisableProcessor method.</summary>
    public class GoogleCloudDocumentaiV1beta3DisableProcessorRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for the DisableProcessor method. Intentionally empty proto for adding fields in future.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3DisableProcessorResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Document represents the canonical document resource in Document AI. It is an interchange format that provides
    /// insights into documents and allows for collaboration between users and Document AI to iterate and optimize for
    /// quality.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3Document : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The blob assets in this document. This is used to store the content of the inline blobs in this
        /// document, e.g. image bytes, such that it can be referenced by other fields in the document via asset id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobAssets")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentBlobAsset> BlobAssets { get; set; }

        /// <summary>Document chunked based on chunking config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chunkedDocument")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentChunkedDocument ChunkedDocument { get; set; }

        /// <summary>
        /// Optional. Inline document content, represented as a stream of bytes. Note: As with all `bytes` fields,
        /// protobuffers use a pure binary representation, whereas JSON representations use base64.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>Optional. An internal identifier for document. Should be loggable (no PII).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("docid")]
        public virtual string Docid { get; set; }

        /// <summary>Parsed layout of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentLayout")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentDocumentLayout DocumentLayout { get; set; }

        /// <summary>
        /// A list of entities detected on Document.text. For document shards, entities in this list may cross shard
        /// boundaries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entities")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentEntity> Entities { get; set; }

        /// <summary>Placeholder. Relationship among Document.entities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityRelations")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentEntityRelation> EntityRelations { get; set; }

        /// <summary>Any error that occurred while processing this document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual GoogleRpcStatus Error { get; set; }

        /// <summary>
        /// An IANA published [media type (MIME type)](https://www.iana.org/assignments/media-types/media-types.xhtml).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>Visual page layout for the Document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPage> Pages { get; set; }

        /// <summary>Placeholder. Revision history of this document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisions")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentRevision> Revisions { get; set; }

        /// <summary>
        /// Information about the sharding if this document is sharded part of a larger document. If the document is not
        /// sharded, this message is not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shardInfo")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentShardInfo ShardInfo { get; set; }

        /// <summary>Optional. UTF-8 encoded text in reading order from the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>
        /// Placeholder. A list of text corrections made to Document.text. This is usually used for annotating
        /// corrections to OCR mistakes. Text changes for a given revision may not overlap with each other.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textChanges")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentTextChange> TextChanges { get; set; }

        /// <summary>Styles for the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStyles")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentStyle> TextStyles { get; set; }

        /// <summary>
        /// Optional. Currently supports Google Cloud Storage URI of the form `gs://bucket_name/object_name`. Object
        /// versioning is not supported. For more information, refer to [Google Cloud Storage Request
        /// URIs](https://cloud.google.com/storage/docs/reference-uris).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the annotation of a block or a chunk.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentAnnotations : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description of the content with this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a blob asset. It's used to store the content of the inline blob in this document, e.g. image bytes,
    /// such that it can be referenced by other fields in the document via asset id.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3DocumentBlobAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The id of the blob asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetId")]
        public virtual string AssetId { get; set; }

        /// <summary>Optional. The content of the blob asset, e.g. image bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>
        /// The mime type of the blob asset. An IANA published [media type (MIME
        /// type)](https://www.iana.org/assignments/media-types/media-types.xhtml).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the chunks that the document is divided into.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentChunkedDocument : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of chunks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chunks")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentChunkedDocumentChunk> Chunks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a chunk.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentChunkedDocumentChunk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Chunk fields inside this chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chunkFields")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentChunkedDocumentChunkChunkField> ChunkFields { get; set; }

        /// <summary>ID of the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chunkId")]
        public virtual string ChunkId { get; set; }

        /// <summary>Text content of the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>Page footers associated with the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageFooters")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentChunkedDocumentChunkChunkPageFooter> PageFooters { get; set; }

        /// <summary>Page headers associated with the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageHeaders")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentChunkedDocumentChunkChunkPageHeader> PageHeaders { get; set; }

        /// <summary>Page span of the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSpan")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentChunkedDocumentChunkChunkPageSpan PageSpan { get; set; }

        /// <summary>Unused.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceBlockIds")]
        public virtual System.Collections.Generic.IList<string> SourceBlockIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The chunk field in the chunk. A chunk field could be one of the various types (e.g. image, table) supported.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3DocumentChunkedDocumentChunkChunkField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The image chunk field in the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageChunkField")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentChunkedDocumentChunkImageChunkField ImageChunkField { get; set; }

        /// <summary>The table chunk field in the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableChunkField")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentChunkedDocumentChunkTableChunkField TableChunkField { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the page footer associated with the chunk.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentChunkedDocumentChunkChunkPageFooter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page span of the footer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSpan")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentChunkedDocumentChunkChunkPageSpan PageSpan { get; set; }

        /// <summary>Footer in text format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the page header associated with the chunk.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentChunkedDocumentChunkChunkPageHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page span of the header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSpan")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentChunkedDocumentChunkChunkPageSpan PageSpan { get; set; }

        /// <summary>Header in text format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents where the chunk starts and ends in the document.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentChunkedDocumentChunkChunkPageSpan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page where chunk ends in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageEnd")]
        public virtual System.Nullable<int> PageEnd { get; set; }

        /// <summary>Page where chunk starts in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageStart")]
        public virtual System.Nullable<int> PageStart { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The image chunk field in the chunk.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentChunkedDocumentChunkImageChunkField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Annotation of the image chunk field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentAnnotations Annotations { get; set; }

        /// <summary>
        /// Optional. Asset id of the inline image. If set, find the image content in the blob_assets field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobAssetId")]
        public virtual string BlobAssetId { get; set; }

        /// <summary>
        /// Optional. Data uri of the image. It is composed of four parts: a prefix (data:), a MIME type indicating the
        /// type of data, an optional base64 token if non-textual, and the data itself: data:,
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataUri")]
        public virtual string DataUri { get; set; }

        /// <summary>Optional. Google Cloud Storage uri of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsUri")]
        public virtual string GcsUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The table chunk field in the chunk.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentChunkedDocumentChunkTableChunkField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Annotation of the table chunk field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentAnnotations Annotations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the parsed layout of a document as a collection of blocks that the document is divided into.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3DocumentDocumentLayout : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of blocks in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocks")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentDocumentLayoutDocumentLayoutBlock> Blocks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a block. A block could be one of the various types (text, table, list) supported.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentDocumentLayoutDocumentLayoutBlock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockId")]
        public virtual string BlockId { get; set; }

        /// <summary>Identifies the bounding box for the block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBox")]
        public virtual GoogleCloudDocumentaiV1beta3BoundingPoly BoundingBox { get; set; }

        /// <summary>Block consisting of image content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageBlock")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentDocumentLayoutDocumentLayoutBlockLayoutImageBlock ImageBlock { get; set; }

        /// <summary>Block consisting of list content/structure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listBlock")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentDocumentLayoutDocumentLayoutBlockLayoutListBlock ListBlock { get; set; }

        /// <summary>Page span of the block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSpan")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentDocumentLayoutDocumentLayoutBlockLayoutPageSpan PageSpan { get; set; }

        /// <summary>Block consisting of table content/structure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableBlock")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentDocumentLayoutDocumentLayoutBlockLayoutTableBlock TableBlock { get; set; }

        /// <summary>Block consisting of text content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textBlock")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentDocumentLayoutDocumentLayoutBlockLayoutTextBlock TextBlock { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an image type block.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentDocumentLayoutDocumentLayoutBlockLayoutImageBlock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Annotation of the image block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentAnnotations Annotations { get; set; }

        /// <summary>
        /// Optional. Asset id of the inline image. If set, find the image content in the blob_assets field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobAssetId")]
        public virtual string BlobAssetId { get; set; }

        /// <summary>
        /// Optional. Data uri of the image. It is composed of four parts: a prefix (data:), a MIME type indicating the
        /// type of data, an optional base64 token if non-textual, and the data itself: data:,
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataUri")]
        public virtual string DataUri { get; set; }

        /// <summary>Optional. Google Cloud Storage uri of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsUri")]
        public virtual string GcsUri { get; set; }

        /// <summary>Text extracted from the image using OCR or alt text describing the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageText")]
        public virtual string ImageText { get; set; }

        /// <summary>
        /// Mime type of the image. An IANA published [media type (MIME type)]
        /// (https://www.iana.org/assignments/media-types/media-types.xhtml).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a list type block.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentDocumentLayoutDocumentLayoutBlockLayoutListBlock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List entries that constitute a list block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listEntries")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentDocumentLayoutDocumentLayoutBlockLayoutListEntry> ListEntries { get; set; }

        /// <summary>Type of the list_entries (if exist). Available options are `ordered` and `unordered`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an entry in the list.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentDocumentLayoutDocumentLayoutBlockLayoutListEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list entry is a list of blocks. Repeated blocks support further hierarchies and nested blocks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocks")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentDocumentLayoutDocumentLayoutBlock> Blocks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents where the block starts and ends in the document.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentDocumentLayoutDocumentLayoutBlockLayoutPageSpan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page where block ends in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageEnd")]
        public virtual System.Nullable<int> PageEnd { get; set; }

        /// <summary>Page where block starts in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageStart")]
        public virtual System.Nullable<int> PageStart { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a table type block.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentDocumentLayoutDocumentLayoutBlockLayoutTableBlock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Annotation of the table block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentAnnotations Annotations { get; set; }

        /// <summary>Body rows containing main table content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bodyRows")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentDocumentLayoutDocumentLayoutBlockLayoutTableRow> BodyRows { get; set; }

        /// <summary>Table caption/title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caption")]
        public virtual string Caption { get; set; }

        /// <summary>Header rows at the top of the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headerRows")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentDocumentLayoutDocumentLayoutBlockLayoutTableRow> HeaderRows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a cell in a table row.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentDocumentLayoutDocumentLayoutBlockLayoutTableCell : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A table cell is a list of blocks. Repeated blocks support further hierarchies and nested blocks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocks")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentDocumentLayoutDocumentLayoutBlock> Blocks { get; set; }

        /// <summary>How many columns this cell spans.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colSpan")]
        public virtual System.Nullable<int> ColSpan { get; set; }

        /// <summary>How many rows this cell spans.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowSpan")]
        public virtual System.Nullable<int> RowSpan { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a row in a table.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentDocumentLayoutDocumentLayoutBlockLayoutTableRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A table row is a list of table cells.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cells")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentDocumentLayoutDocumentLayoutBlockLayoutTableCell> Cells { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a text type block.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentDocumentLayoutDocumentLayoutBlockLayoutTextBlock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A text block could further have child blocks. Repeated blocks support further hierarchies and nested blocks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocks")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentDocumentLayoutDocumentLayoutBlock> Blocks { get; set; }

        /// <summary>Text content stored in the block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>
        /// Type of the text in the block. Available options are: `paragraph`, `subtitle`, `heading-1`, `heading-2`,
        /// `heading-3`, `heading-4`, `heading-5`, `header`, `footer`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An entity that could be a phrase in the text or a property that belongs to the document. It is a known entity
    /// type, such as a person, an organization, or location.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3DocumentEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Confidence of detected Schema entity. Range `[0, 1]`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Optional. Canonical id. This will be a unique value in the entity list for this document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. Deprecated. Use `id` field instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mentionId")]
        public virtual string MentionId { get; set; }

        /// <summary>Optional. Text value of the entity e.g. `1600 Amphitheatre Pkwy`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mentionText")]
        public virtual string MentionText { get; set; }

        /// <summary>Optional. Specifies how the entity's value is obtained.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; }

        /// <summary>
        /// Optional. Normalized entity value. Absent if the extracted value could not be converted or the type (e.g.
        /// address) is not supported for certain parsers. This field is also only populated for certain supported
        /// document types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedValue")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentEntityNormalizedValue NormalizedValue { get; set; }

        /// <summary>
        /// Optional. Represents the provenance of this entity wrt. the location on the page where it was found.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageAnchor")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentPageAnchor PageAnchor { get; set; }

        /// <summary>
        /// Optional. Entities can be nested to form a hierarchical data structure representing the content in the
        /// document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentEntity> Properties { get; set; }

        /// <summary>Optional. The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentProvenance Provenance { get; set; }

        /// <summary>Optional. Whether the entity will be redacted for de-identification purposes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redacted")]
        public virtual System.Nullable<bool> Redacted { get; set; }

        /// <summary>Optional. Provenance of the entity. Text anchor indexing into the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnchor")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentTextAnchor TextAnchor { get; set; }

        /// <summary>Required. Entity type from a schema e.g. `Address`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parsed and normalized entity value.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentEntityNormalizedValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Postal address. See also:
        /// https://github.com/googleapis/googleapis/blob/master/google/type/postal_address.proto
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressValue")]
        public virtual GoogleTypePostalAddress AddressValue { get; set; }

        /// <summary>Boolean value. Can be used for entities with binary values, or for checkboxes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("booleanValue")]
        public virtual System.Nullable<bool> BooleanValue { get; set; }

        /// <summary>
        /// Date value. Includes year, month, day. See also:
        /// https://github.com/googleapis/googleapis/blob/master/google/type/date.proto
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateValue")]
        public virtual GoogleTypeDate DateValue { get; set; }

        /// <summary>
        /// DateTime value. Includes date, time, and timezone. See also:
        /// https://github.com/googleapis/googleapis/blob/master/google/type/datetime.proto
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datetimeValue")]
        public virtual GoogleTypeDateTime DatetimeValue { get; set; }

        /// <summary>Float value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floatValue")]
        public virtual System.Nullable<float> FloatValue { get; set; }

        /// <summary>Integer value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integerValue")]
        public virtual System.Nullable<int> IntegerValue { get; set; }

        /// <summary>
        /// Money value. See also: https://github.com/googleapis/googleapis/blob/master/google/type/money.proto
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moneyValue")]
        public virtual GoogleTypeMoney MoneyValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("signatureValue")]
        public virtual System.Nullable<bool> SignatureValue { get; set; }

        /// <summary>
        /// Optional. An optional field to store a normalized string. For some entity types, one of respective
        /// `structured_value` fields may also be populated. Also not all the types of `structured_value` will be
        /// normalized. For example, some processors may not generate `float` or `integer` normalized text by default.
        /// Below are sample formats mapped to structured values. - Money/Currency type (`money_value`) is in the ISO
        /// 4217 text format. - Date type (`date_value`) is in the ISO 8601 text format. - Datetime type
        /// (`datetime_value`) is in the ISO 8601 text format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Relationship between Entities.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentEntityRelation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Object entity id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>Relationship description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relation")]
        public virtual string Relation { get; set; }

        /// <summary>Subject entity id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subjectId")]
        public virtual string SubjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Document Identifier.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A document id within user-managed Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsManagedDocId")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentIdGCSManagedDocumentId GcsManagedDocId { get; set; }

        /// <summary>Points to a specific revision of the document if set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionRef")]
        public virtual GoogleCloudDocumentaiV1beta3RevisionRef RevisionRef { get; set; }

        /// <summary>A document id within unmanaged dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unmanagedDocId")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentIdUnmanagedDocumentId UnmanagedDocId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Identifies a document uniquely within the scope of a dataset in the user-managed Cloud Storage option.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3DocumentIdGCSManagedDocumentId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Id of the document (indexed) managed by Content Warehouse.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cwDocId")]
        public virtual string CwDocId { get; set; }

        /// <summary>Required. The Cloud Storage URI where the actual document is stored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsUri")]
        public virtual string GcsUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identifies a document uniquely within the scope of a dataset in unmanaged option.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentIdUnmanagedDocumentId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The id of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("docId")]
        public virtual string DocId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about a document.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type of the dataset split to which the document belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetType")]
        public virtual string DatasetType { get; set; }

        /// <summary>The display name of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Document identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentId DocumentId { get; set; }

        /// <summary>Labeling state of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelingState")]
        public virtual string LabelingState { get; set; }

        /// <summary>Number of pages in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageCount")]
        public virtual System.Nullable<int> PageCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config that controls the output of documents. All documents will be written as a JSON file.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentOutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output config to write the results to Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsOutputConfig")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentOutputConfigGcsOutputConfig GcsOutputConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration used when outputting documents.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentOutputConfigGcsOutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies which fields to include in the output documents. Only supports top level document and pages field
        /// so it must be in the form of `{document_field_name}` or `pages.{page_field_name}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldMask")]
        public virtual object FieldMask { get; set; }

        /// <summary>The Cloud Storage uri (a directory) of the output.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsUri")]
        public virtual string GcsUri { get; set; }

        /// <summary>Specifies the sharding config for the output document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shardingConfig")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentOutputConfigGcsOutputConfigShardingConfig ShardingConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The sharding config for the output document.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentOutputConfigGcsOutputConfigShardingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of overlapping pages between consecutive shards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pagesOverlap")]
        public virtual System.Nullable<int> PagesOverlap { get; set; }

        /// <summary>The number of pages per shard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pagesPerShard")]
        public virtual System.Nullable<int> PagesPerShard { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A page in a Document.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentPage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of visually detected text blocks on the page. A block has a set of lines (collected into paragraphs)
        /// that have a common line-spacing and orientation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocks")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPageBlock> Blocks { get; set; }

        /// <summary>A list of detected barcodes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedBarcodes")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPageDetectedBarcode> DetectedBarcodes { get; set; }

        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Physical dimension of the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentPageDimension Dimension { get; set; }

        /// <summary>A list of visually detected form fields on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formFields")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPageFormField> FormFields { get; set; }

        /// <summary>
        /// Rendered image for this page. This image is preprocessed to remove any skew, rotation, and distortions such
        /// that the annotation bounding boxes can be upright and axis-aligned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentPageImage Image { get; set; }

        /// <summary>Image quality scores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageQualityScores")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentPageImageQualityScores ImageQualityScores { get; set; }

        /// <summary>Layout for the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentPageLayout Layout { get; set; }

        /// <summary>
        /// A list of visually detected text lines on the page. A collection of tokens that a human would perceive as a
        /// line.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lines")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPageLine> Lines { get; set; }

        /// <summary>
        /// 1-based index for current Page in a parent Document. Useful when a page is taken out of a Document for
        /// individual processing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageNumber")]
        public virtual System.Nullable<int> PageNumber { get; set; }

        /// <summary>
        /// A list of visually detected text paragraphs on the page. A collection of lines that a human would perceive
        /// as a paragraph.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paragraphs")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPageParagraph> Paragraphs { get; set; }

        /// <summary>The history of this page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentProvenance Provenance { get; set; }

        /// <summary>A list of visually detected symbols on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("symbols")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPageSymbol> Symbols { get; set; }

        /// <summary>A list of visually detected tables on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tables")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPageTable> Tables { get; set; }

        /// <summary>A list of visually detected tokens on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokens")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPageToken> Tokens { get; set; }

        /// <summary>
        /// Transformation matrices that were applied to the original document image to produce Page.image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transforms")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPageMatrix> Transforms { get; set; }

        /// <summary>A list of detected non-text visual elements e.g. checkbox, signature etc. on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visualElements")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPageVisualElement> VisualElements { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Referencing the visual context of the entity in the Document.pages. Page anchors can be cross-page, consist of
    /// multiple bounding polygons and optionally reference specific layout element types.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3DocumentPageAnchor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>One or more references to visual page elements</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageRefs")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPageAnchorPageRef> PageRefs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a weak reference to a page element within a document.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentPageAnchorPageRef : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Identifies the bounding polygon of a layout element on the page. If `layout_type` is set, the
        /// bounding polygon must be exactly the same to the layout element it's referring to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudDocumentaiV1beta3BoundingPoly BoundingPoly { get; set; }

        /// <summary>Optional. Confidence of detected page element, if applicable. Range `[0, 1]`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Optional. Deprecated. Use PageRef.bounding_poly instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layoutId")]
        public virtual string LayoutId { get; set; }

        /// <summary>Optional. The type of the layout element that is being referenced if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layoutType")]
        public virtual string LayoutType { get; set; }

        /// <summary>
        /// Required. Index into the Document.pages element, for example using `Document.pages` to locate the related
        /// page element. This field is skipped when its value is the default `0`. See
        /// https://developers.google.com/protocol-buffers/docs/proto3#json.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("page")]
        public virtual System.Nullable<long> Page { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A block has a set of lines (collected into paragraphs) that have a common line-spacing and orientation.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3DocumentPageBlock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for Block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentPageLayout Layout { get; set; }

        /// <summary>The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentProvenance Provenance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A detected barcode.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentPageDetectedBarcode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detailed barcode information of the DetectedBarcode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("barcode")]
        public virtual GoogleCloudDocumentaiV1beta3Barcode Barcode { get; set; }

        /// <summary>Layout for DetectedBarcode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentPageLayout Layout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected language for a structural component.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentPageDetectedLanguage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Confidence of detected language. Range `[0, 1]`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// The [BCP-47 language code](https://www.unicode.org/reports/tr35/#Unicode_locale_identifier), such as `en-US`
        /// or `sr-Latn`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Dimension for the page.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentPageDimension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page height.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<float> Height { get; set; }

        /// <summary>Dimension unit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>Page width.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<float> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A form field detected on the page.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentPageFormField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Created for Labeling UI to export key text. If corrections were made to the text identified by the
        /// `field_name.text_anchor`, this field will contain the correction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("correctedKeyText")]
        public virtual string CorrectedKeyText { get; set; }

        /// <summary>
        /// Created for Labeling UI to export value text. If corrections were made to the text identified by the
        /// `field_value.text_anchor`, this field will contain the correction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("correctedValueText")]
        public virtual string CorrectedValueText { get; set; }

        /// <summary>
        /// Layout for the FormField name. e.g. `Address`, `Email`, `Grand total`, `Phone number`, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldName")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentPageLayout FieldName { get; set; }

        /// <summary>Layout for the FormField value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldValue")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentPageLayout FieldValue { get; set; }

        /// <summary>A list of detected languages for name together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nameDetectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPageDetectedLanguage> NameDetectedLanguages { get; set; }

        /// <summary>The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentProvenance Provenance { get; set; }

        /// <summary>A list of detected languages for value together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueDetectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPageDetectedLanguage> ValueDetectedLanguages { get; set; }

        /// <summary>
        /// If the value is non-textual, this field represents the type. Current valid values are: - blank (this
        /// indicates the `field_value` is normal text) - `unfilled_checkbox` - `filled_checkbox`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual string ValueType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Rendered image contents for this page.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentPageImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Raw byte content of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>Height of the image in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; }

        /// <summary>
        /// Encoding [media type (MIME type)](https://www.iana.org/assignments/media-types/media-types.xhtml) for the
        /// image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>Width of the image in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Image quality scores for the page image.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentPageImageQualityScores : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of detected defects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedDefects")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPageImageQualityScoresDetectedDefect> DetectedDefects { get; set; }

        /// <summary>The overall quality score. Range `[0, 1]` where `1` is perfect quality.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("qualityScore")]
        public virtual System.Nullable<float> QualityScore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Image Quality Defects</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentPageImageQualityScoresDetectedDefect : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Confidence of detected defect. Range `[0, 1]` where `1` indicates strong confidence that the defect exists.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// Name of the defect type. Supported values are: - `quality/defect_blurry` - `quality/defect_noisy` -
        /// `quality/defect_dark` - `quality/defect_faint` - `quality/defect_text_too_small` -
        /// `quality/defect_document_cutoff` - `quality/defect_text_cutoff` - `quality/defect_glare`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Visual element describing a layout unit on a page.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentPageLayout : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bounding polygon for the Layout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudDocumentaiV1beta3BoundingPoly BoundingPoly { get; set; }

        /// <summary>
        /// Confidence of the current Layout within context of the object this layout is for. e.g. confidence can be for
        /// a single token, a table, a visual element, etc. depending on context. Range `[0, 1]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Detected orientation for the Layout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orientation")]
        public virtual string Orientation { get; set; }

        /// <summary>Text anchor indexing into the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnchor")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentTextAnchor TextAnchor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A collection of tokens that a human would perceive as a line. Does not cross column boundaries, can be
    /// horizontal, vertical, etc.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3DocumentPageLine : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for Line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentPageLayout Layout { get; set; }

        /// <summary>The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentProvenance Provenance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Representation for transformation matrix, intended to be compatible and used with OpenCV format for image
    /// manipulation.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3DocumentPageMatrix : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of columns in the matrix.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cols")]
        public virtual System.Nullable<int> Cols { get; set; }

        /// <summary>The matrix data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>Number of rows in the matrix.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Nullable<int> Rows { get; set; }

        /// <summary>
        /// This encodes information about what data type the matrix uses. For example, 0 (CV_8U) is an unsigned 8-bit
        /// image. For the full list of OpenCV primitive data types, please refer to
        /// https://docs.opencv.org/4.3.0/d1/d1b/group__core__hal__interface.html
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual System.Nullable<int> Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A collection of lines that a human would perceive as a paragraph.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentPageParagraph : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for Paragraph.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentPageLayout Layout { get; set; }

        /// <summary>The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentProvenance Provenance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A detected symbol.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentPageSymbol : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for Symbol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentPageLayout Layout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A table representation similar to HTML table structure.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentPageTable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Body rows of the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bodyRows")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPageTableTableRow> BodyRows { get; set; }

        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Header rows of the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headerRows")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPageTableTableRow> HeaderRows { get; set; }

        /// <summary>Layout for Table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentPageLayout Layout { get; set; }

        /// <summary>The history of this table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentProvenance Provenance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A cell representation inside the table.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentPageTableTableCell : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>How many columns this cell spans.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colSpan")]
        public virtual System.Nullable<int> ColSpan { get; set; }

        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for TableCell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentPageLayout Layout { get; set; }

        /// <summary>How many rows this cell spans.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowSpan")]
        public virtual System.Nullable<int> RowSpan { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A row of table cells.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentPageTableTableRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cells that make up this row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cells")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPageTableTableCell> Cells { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A detected token.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentPageToken : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detected break at the end of a Token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedBreak")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentPageTokenDetectedBreak DetectedBreak { get; set; }

        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for Token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentPageLayout Layout { get; set; }

        /// <summary>The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentProvenance Provenance { get; set; }

        /// <summary>Text style attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("styleInfo")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentPageTokenStyleInfo StyleInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected break at the end of a Token.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentPageTokenDetectedBreak : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detected break type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Font and other text style attributes.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentPageTokenStyleInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Color of the background.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColor")]
        public virtual GoogleTypeColor BackgroundColor { get; set; }

        /// <summary>Whether the text is bold (equivalent to font_weight is at least `700`).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bold")]
        public virtual System.Nullable<bool> Bold { get; set; }

        /// <summary>Font size in points (`1` point is `¹⁄₇₂` inches).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontSize")]
        public virtual System.Nullable<int> FontSize { get; set; }

        /// <summary>Name or style of the font.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontType")]
        public virtual string FontType { get; set; }

        /// <summary>
        /// TrueType weight on a scale `100` (thin) to `1000` (ultra-heavy). Normal is `400`, bold is `700`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontWeight")]
        public virtual System.Nullable<int> FontWeight { get; set; }

        /// <summary>Whether the text is handwritten.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("handwritten")]
        public virtual System.Nullable<bool> Handwritten { get; set; }

        /// <summary>Whether the text is italic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("italic")]
        public virtual System.Nullable<bool> Italic { get; set; }

        /// <summary>Letter spacing in points.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("letterSpacing")]
        public virtual System.Nullable<double> LetterSpacing { get; set; }

        /// <summary>Font size in pixels, equal to _unrounded font_size_ * _resolution_ ÷ `72.0`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pixelFontSize")]
        public virtual System.Nullable<double> PixelFontSize { get; set; }

        /// <summary>Whether the text is in small caps. This feature is not supported yet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smallcaps")]
        public virtual System.Nullable<bool> Smallcaps { get; set; }

        /// <summary>Whether the text is strikethrough. This feature is not supported yet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("strikeout")]
        public virtual System.Nullable<bool> Strikeout { get; set; }

        /// <summary>Whether the text is a subscript. This feature is not supported yet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscript")]
        public virtual System.Nullable<bool> Subscript { get; set; }

        /// <summary>Whether the text is a superscript. This feature is not supported yet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("superscript")]
        public virtual System.Nullable<bool> Superscript { get; set; }

        /// <summary>Color of the text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textColor")]
        public virtual GoogleTypeColor TextColor { get; set; }

        /// <summary>Whether the text is underlined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("underlined")]
        public virtual System.Nullable<bool> Underlined { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected non-text visual elements e.g. checkbox, signature etc. on the page.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentPageVisualElement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for VisualElement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentPageLayout Layout { get; set; }

        /// <summary>Type of the VisualElement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Structure to identify provenance relationships between annotations in different revisions.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentProvenance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Id of this operation. Needs to be unique within the scope of the revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<int> Id { get; set; }

        /// <summary>References to the original elements that are replaced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parents")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentProvenanceParent> Parents { get; set; }

        /// <summary>The index of the revision that produced this element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual System.Nullable<int> Revision { get; set; }

        /// <summary>The type of provenance operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The parent element the current element is based on. Used for referencing/aligning, removal and replacement
    /// operations.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3DocumentProvenanceParent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The id of the parent provenance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<int> Id { get; set; }

        /// <summary>
        /// The index of the parent item in the corresponding item list (eg. list of entities, properties within
        /// entities, etc.) in the parent revision.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>The index of the index into current revision's parent_ids list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual System.Nullable<int> Revision { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains past or forward revisions of this document.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentRevision : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If the change was made by a person specify the name or id of that person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agent")]
        public virtual string Agent { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// The time that the revision was created, internally generated by doc proto storage at the time of create.
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

        /// <summary>Human Review information of this revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("humanReview")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentRevisionHumanReview HumanReview { get; set; }

        /// <summary>
        /// Id of the revision, internally generated by doc proto storage. Unique within the context of the document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The revisions that this revision is based on. This can include one or more parent (when documents are
        /// merged.) This field represents the index into the `revisions` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> Parent { get; set; }

        /// <summary>
        /// The revisions that this revision is based on. Must include all the ids that have anything to do with this
        /// revision - eg. there are `provenance.parent.revision` fields that index into this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentIds")]
        public virtual System.Collections.Generic.IList<string> ParentIds { get; set; }

        /// <summary>If the annotation was made by processor identify the processor by its resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processor")]
        public virtual string Processor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Human Review information of the document.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentRevisionHumanReview : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Human review state. e.g. `requested`, `succeeded`, `rejected`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// A message providing more details about the current state of processing. For example, the rejection reason
        /// when the state is `rejected`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The schema defines the output of the processed document by a processor.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Display name to show to users.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Entity types of the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityTypes")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentSchemaEntityType> EntityTypes { get; set; }

        /// <summary>Metadata of the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentSchemaMetadata Metadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// EntityType is the wrapper of a label of the corresponding model with detailed attributes and limitations for
    /// entity-based processors. Multiple types can also compose a dependency tree to represent nested types.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3DocumentSchemaEntityType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The entity type that this type is derived from. For now, one and only one should be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseTypes")]
        public virtual System.Collections.Generic.IList<string> BaseTypes { get; set; }

        /// <summary>
        /// The description of the entity type. Could be used to provide more information about the entity type for
        /// model calls.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>User defined name for the type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Metadata for the entity type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityTypeMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3EntityTypeMetadata EntityTypeMetadata { get; set; }

        /// <summary>
        /// If specified, lists all the possible values for this entity. This should not be more than a handful of
        /// values. If the number of values is &amp;gt;10 or could change frequently use the `EntityType.value_ontology`
        /// field and specify a list of all possible values in a value ontology file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enumValues")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentSchemaEntityTypeEnumValues EnumValues { get; set; }

        /// <summary>
        /// Name of the type. It must be unique within the schema file and cannot be a "Common Type". The following
        /// naming conventions are used: - Use `snake_casing`. - Name matching is case-sensitive. - Maximum 64
        /// characters. - Must start with a letter. - Allowed characters: ASCII letters `[a-z0-9_-]`. (For backward
        /// compatibility internal infrastructure and tooling can handle any ascii character.) - The `/` is sometimes
        /// used to denote a property of a type. For example `line_item/amount`. This convention is deprecated, but will
        /// still be honored for backward compatibility.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Description the nested structure, or composition of an entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentSchemaEntityTypeProperty> Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines the a list of enum values.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentSchemaEntityTypeEnumValues : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The individual values that this enum values type can include.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines properties that can be part of the entity type.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentSchemaEntityTypeProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The description of the property. Could be used to provide more information about the property for model
        /// calls.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>User defined name for the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Specifies how the entity's value is obtained.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; }

        /// <summary>The name of the property. Follows the same guidelines as the EntityType name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Occurrence type limits the number of instances an entity type appears in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("occurrenceType")]
        public virtual string OccurrenceType { get; set; }

        /// <summary>Any additional metadata about the property can be added here.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3PropertyMetadata PropertyMetadata { get; set; }

        /// <summary>
        /// A reference to the value type of the property. This type is subject to the same conventions as the
        /// `Entity.base_types` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual string ValueType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for global schema behavior.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentSchemaMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If true, on a given page, there can be multiple `document` annotations covering it.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentAllowMultipleLabels")]
        public virtual System.Nullable<bool> DocumentAllowMultipleLabels { get; set; }

        /// <summary>
        /// If true, a `document` entity type can be applied to subdocument (splitting). Otherwise, it can only be
        /// applied to the entire document (classification).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentSplitter")]
        public virtual System.Nullable<bool> DocumentSplitter { get; set; }

        /// <summary>If set, all the nested entities must be prefixed with the parents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prefixedNamingOnProperties")]
        public virtual System.Nullable<bool> PrefixedNamingOnProperties { get; set; }

        /// <summary>
        /// If set, we will skip the naming format validation in the schema. So the string values in
        /// `DocumentSchema.EntityType.name` and `DocumentSchema.EntityType.Property.name` will not be checked.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipNamingValidation")]
        public virtual System.Nullable<bool> SkipNamingValidation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// For a large document, sharding may be performed to produce several document shards. Each document shard contains
    /// this field to detail which shard it is.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3DocumentShardInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Total number of shards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shardCount")]
        public virtual System.Nullable<long> ShardCount { get; set; }

        /// <summary>The 0-based index of this shard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shardIndex")]
        public virtual System.Nullable<long> ShardIndex { get; set; }

        /// <summary>The index of the first character in Document.text in the overall document global text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textOffset")]
        public virtual System.Nullable<long> TextOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Annotation for common text style attributes. This adheres to CSS conventions as much as possible.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3DocumentStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Text background color.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColor")]
        public virtual GoogleTypeColor BackgroundColor { get; set; }

        /// <summary>Text color.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual GoogleTypeColor Color { get; set; }

        /// <summary>
        /// Font family such as `Arial`, `Times New Roman`. https://www.w3schools.com/cssref/pr_font_font-family.asp
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontFamily")]
        public virtual string FontFamily { get; set; }

        /// <summary>Font size.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontSize")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentStyleFontSize FontSize { get; set; }

        /// <summary>
        /// [Font weight](https://www.w3schools.com/cssref/pr_font_weight.asp). Possible values are `normal`, `bold`,
        /// `bolder`, and `lighter`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontWeight")]
        public virtual string FontWeight { get; set; }

        /// <summary>Text anchor indexing into the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnchor")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentTextAnchor TextAnchor { get; set; }

        /// <summary>
        /// [Text decoration](https://www.w3schools.com/cssref/pr_text_text-decoration.asp). Follows CSS standard.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textDecoration")]
        public virtual string TextDecoration { get; set; }

        /// <summary>
        /// [Text style](https://www.w3schools.com/cssref/pr_font_font-style.asp). Possible values are `normal`,
        /// `italic`, and `oblique`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStyle")]
        public virtual string TextStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Font size with unit.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentStyleFontSize : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Font size for the text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual System.Nullable<float> Size { get; set; }

        /// <summary>Unit for the font size. Follows CSS naming (such as `in`, `px`, and `pt`).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Text reference indexing into the Document.text.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentTextAnchor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Contains the content of the text span so that users do not have to look it up in the text_segments. It is
        /// always populated for formFields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>The text segments from the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textSegments")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentTextAnchorTextSegment> TextSegments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A text segment in the Document.text. The indices may be out of bounds which indicate that the text extends into
    /// another document shard for large sharded documents. See ShardInfo.text_offset
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3DocumentTextAnchorTextSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>TextSegment half open end UTF-8 char index in the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endIndex")]
        public virtual System.Nullable<long> EndIndex { get; set; }

        /// <summary>TextSegment start UTF-8 char index in the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<long> StartIndex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This message is used for text changes aka. OCR corrections.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentTextChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The text that replaces the text identified in the `text_anchor`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changedText")]
        public virtual string ChangedText { get; set; }

        /// <summary>The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentProvenance> Provenance { get; set; }

        /// <summary>
        /// Provenance of the correction. Text anchor indexing into the Document.text. There can only be a single
        /// `TextAnchor.text_segments` element. If the start and end index of the text segment are the same, the text
        /// change is inserted before that index.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnchor")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentTextAnchor TextAnchor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the EnableProcessor method.</summary>
    public class GoogleCloudDocumentaiV1beta3EnableProcessorMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the EnableProcessor method.</summary>
    public class GoogleCloudDocumentaiV1beta3EnableProcessorRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for the EnableProcessor method. Intentionally empty proto for adding fields in future.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3EnableProcessorResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about an entity type.</summary>
    public class GoogleCloudDocumentaiV1beta3EntityTypeMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the entity type should be considered inactive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inactive")]
        public virtual System.Nullable<bool> Inactive { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of the EvaluateProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1beta3EvaluateProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evaluates the given ProcessorVersion against the supplied documents.</summary>
    public class GoogleCloudDocumentaiV1beta3EvaluateProcessorVersionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The documents used in the evaluation. If unspecified, use the processor's dataset as evaluation
        /// input.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationDocuments")]
        public virtual GoogleCloudDocumentaiV1beta3BatchDocumentsInputConfig EvaluationDocuments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of the EvaluateProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1beta3EvaluateProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name of the created evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluation")]
        public virtual string Evaluation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An evaluation of a ProcessorVersion's performance.</summary>
    public class GoogleCloudDocumentaiV1beta3Evaluation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metrics for all the entities in aggregate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allEntitiesMetrics")]
        public virtual GoogleCloudDocumentaiV1beta3EvaluationMultiConfidenceMetrics AllEntitiesMetrics { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The time that the evaluation was created.</summary>
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

        /// <summary>Counters for the documents used in the evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentCounters")]
        public virtual GoogleCloudDocumentaiV1beta3EvaluationCounters DocumentCounters { get; set; }

        /// <summary>Metrics across confidence levels, for different entities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityMetrics")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudDocumentaiV1beta3EvaluationMultiConfidenceMetrics> EntityMetrics { get; set; }

        /// <summary>The KMS key name used for encryption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>The KMS key version with which data is encrypted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyVersionName")]
        public virtual string KmsKeyVersionName { get; set; }

        /// <summary>
        /// The resource name of the evaluation. Format:
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processor_version}/evaluations/{evaluation}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evaluations metrics, at a specific confidence level.</summary>
    public class GoogleCloudDocumentaiV1beta3EvaluationConfidenceLevelMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The confidence level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidenceLevel")]
        public virtual System.Nullable<float> ConfidenceLevel { get; set; }

        /// <summary>The metrics at the specific confidence level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual GoogleCloudDocumentaiV1beta3EvaluationMetrics Metrics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evaluation counters for the documents that were used.</summary>
    public class GoogleCloudDocumentaiV1beta3EvaluationCounters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>How many documents were used in the evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluatedDocumentsCount")]
        public virtual System.Nullable<int> EvaluatedDocumentsCount { get; set; }

        /// <summary>
        /// How many documents were not included in the evaluation as Document AI failed to process them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedDocumentsCount")]
        public virtual System.Nullable<int> FailedDocumentsCount { get; set; }

        /// <summary>How many documents were sent for evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputDocumentsCount")]
        public virtual System.Nullable<int> InputDocumentsCount { get; set; }

        /// <summary>How many documents were not included in the evaluation as they didn't pass validation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invalidDocumentsCount")]
        public virtual System.Nullable<int> InvalidDocumentsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evaluation metrics, either in aggregate or about a specific entity.</summary>
    public class GoogleCloudDocumentaiV1beta3EvaluationMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The calculated f1 score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("f1Score")]
        public virtual System.Nullable<float> F1Score { get; set; }

        /// <summary>The amount of false negatives.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("falseNegativesCount")]
        public virtual System.Nullable<int> FalseNegativesCount { get; set; }

        /// <summary>The amount of false positives.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("falsePositivesCount")]
        public virtual System.Nullable<int> FalsePositivesCount { get; set; }

        /// <summary>The amount of documents with a ground truth occurrence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groundTruthDocumentCount")]
        public virtual System.Nullable<int> GroundTruthDocumentCount { get; set; }

        /// <summary>The amount of occurrences in ground truth documents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groundTruthOccurrencesCount")]
        public virtual System.Nullable<int> GroundTruthOccurrencesCount { get; set; }

        /// <summary>The calculated precision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precision")]
        public virtual System.Nullable<float> Precision { get; set; }

        /// <summary>The amount of documents with a predicted occurrence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predictedDocumentCount")]
        public virtual System.Nullable<int> PredictedDocumentCount { get; set; }

        /// <summary>The amount of occurrences in predicted documents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predictedOccurrencesCount")]
        public virtual System.Nullable<int> PredictedOccurrencesCount { get; set; }

        /// <summary>The calculated recall.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recall")]
        public virtual System.Nullable<float> Recall { get; set; }

        /// <summary>The amount of documents that had an occurrence of this label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalDocumentsCount")]
        public virtual System.Nullable<int> TotalDocumentsCount { get; set; }

        /// <summary>The amount of true positives.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("truePositivesCount")]
        public virtual System.Nullable<int> TruePositivesCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metrics across multiple confidence levels.</summary>
    public class GoogleCloudDocumentaiV1beta3EvaluationMultiConfidenceMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The calculated area under the precision recall curve (AUPRC), computed by integrating over all confidence
        /// thresholds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auprc")]
        public virtual System.Nullable<float> Auprc { get; set; }

        /// <summary>The AUPRC for metrics with fuzzy matching disabled, i.e., exact matching only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auprcExact")]
        public virtual System.Nullable<float> AuprcExact { get; set; }

        /// <summary>Metrics across confidence levels with fuzzy matching enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidenceLevelMetrics")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3EvaluationConfidenceLevelMetrics> ConfidenceLevelMetrics { get; set; }

        /// <summary>Metrics across confidence levels with only exact matching.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidenceLevelMetricsExact")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3EvaluationConfidenceLevelMetrics> ConfidenceLevelMetricsExact { get; set; }

        /// <summary>The Estimated Calibration Error (ECE) of the confidence of the predicted entities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedCalibrationError")]
        public virtual System.Nullable<float> EstimatedCalibrationError { get; set; }

        /// <summary>
        /// The ECE for the predicted entities with fuzzy matching disabled, i.e., exact matching only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedCalibrationErrorExact")]
        public virtual System.Nullable<float> EstimatedCalibrationErrorExact { get; set; }

        /// <summary>The metrics type for the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricsType")]
        public virtual string MetricsType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Gives a short summary of an evaluation, and links to the evaluation itself.</summary>
    public class GoogleCloudDocumentaiV1beta3EvaluationReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An aggregate of the statistics for the evaluation with fuzzy matching on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregateMetrics")]
        public virtual GoogleCloudDocumentaiV1beta3EvaluationMetrics AggregateMetrics { get; set; }

        /// <summary>An aggregate of the statistics for the evaluation with fuzzy matching off.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregateMetricsExact")]
        public virtual GoogleCloudDocumentaiV1beta3EvaluationMetrics AggregateMetricsExact { get; set; }

        /// <summary>The resource name of the evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluation")]
        public virtual string Evaluation { get; set; }

        /// <summary>The resource name of the Long Running Operation for the evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the FetchProcessorTypes method.</summary>
    public class GoogleCloudDocumentaiV1beta3FetchProcessorTypesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of processor types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processorTypes")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3ProcessorType> ProcessorTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for how this field value is extracted.</summary>
    public class GoogleCloudDocumentaiV1beta3FieldExtractionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Summary options config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summaryOptions")]
        public virtual GoogleCloudDocumentaiV1beta3SummaryOptions SummaryOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies a document stored on Cloud Storage.</summary>
    public class GoogleCloudDocumentaiV1beta3GcsDocument : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Cloud Storage object uri.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsUri")]
        public virtual string GcsUri { get; set; }

        /// <summary>An IANA MIME type (RFC6838) of the content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies a set of documents on Cloud Storage.</summary>
    public class GoogleCloudDocumentaiV1beta3GcsDocuments : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of documents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documents")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3GcsDocument> Documents { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies all documents on Cloud Storage with a common prefix.</summary>
    public class GoogleCloudDocumentaiV1beta3GcsPrefix : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URI prefix.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsUriPrefix")]
        public virtual string GcsUriPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDocumentaiV1beta3GetDocumentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual GoogleCloudDocumentaiV1beta3Document Document { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of human review on a processed document.</summary>
    public class GoogleCloudDocumentaiV1beta3HumanReviewStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the operation triggered by the processed document. This field is populated only when the state
        /// is `HUMAN_REVIEW_IN_PROGRESS`. It has the same response type and metadata as the long-running operation
        /// returned by ReviewDocument.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("humanReviewOperation")]
        public virtual string HumanReviewOperation { get; set; }

        /// <summary>The state of human review on the processing request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>A message providing more details about the human review state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of the import document operation.</summary>
    public class GoogleCloudDocumentaiV1beta3ImportDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>Validation statuses of the batch documents import config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importConfigValidationResults")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3ImportDocumentsMetadataImportConfigValidationResult> ImportConfigValidationResults { get; set; }

        /// <summary>The list of response details of each document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualImportStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3ImportDocumentsMetadataIndividualImportStatus> IndividualImportStatuses { get; set; }

        /// <summary>Total number of the documents that are qualified for importing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalDocumentCount")]
        public virtual System.Nullable<int> TotalDocumentCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The validation status of each import config. Status is set to an error if there are no documents to import in
    /// the `import_config`, or `OK` if the operation will try to proceed with at least one document.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3ImportDocumentsMetadataImportConfigValidationResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The source Cloud Storage URI specified in the import config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputGcsSource")]
        public virtual string InputGcsSource { get; set; }

        /// <summary>The validation status of import config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of each individual document in the import process.</summary>
    public class GoogleCloudDocumentaiV1beta3ImportDocumentsMetadataIndividualImportStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The source Cloud Storage URI of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputGcsSource")]
        public virtual string InputGcsSource { get; set; }

        /// <summary>The document id of imported document if it was successful, otherwise empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputDocumentId")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentId OutputDocumentId { get; set; }

        /// <summary>The status of the importing of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDocumentaiV1beta3ImportDocumentsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Cloud Storage uri containing raw documents that must be imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchDocumentsImportConfigs")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3ImportDocumentsRequestBatchDocumentsImportConfig> BatchDocumentsImportConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config for importing documents. Each batch can have its own dataset split type.</summary>
    public class GoogleCloudDocumentaiV1beta3ImportDocumentsRequestBatchDocumentsImportConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set, documents will be automatically split into training and test split category with the specified
        /// ratio.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoSplitConfig")]
        public virtual GoogleCloudDocumentaiV1beta3ImportDocumentsRequestBatchDocumentsImportConfigAutoSplitConfig AutoSplitConfig { get; set; }

        /// <summary>The common config to specify a set of documents used as input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchInputConfig")]
        public virtual GoogleCloudDocumentaiV1beta3BatchDocumentsInputConfig BatchInputConfig { get; set; }

        /// <summary>Target dataset split where the documents must be stored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetSplit")]
        public virtual string DatasetSplit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The config for auto-split.</summary>
    public class GoogleCloudDocumentaiV1beta3ImportDocumentsRequestBatchDocumentsImportConfigAutoSplitConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Ratio of training dataset split.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingSplitRatio")]
        public virtual System.Nullable<float> TrainingSplitRatio { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of the import document operation.</summary>
    public class GoogleCloudDocumentaiV1beta3ImportDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the ImportProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1beta3ImportProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata for the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The request message for the ImportProcessorVersion method. The Document AI [Service
    /// Agent](https://cloud.google.com/iam/docs/service-agents) of the destination project must have [Document AI
    /// Editor role](https://cloud.google.com/document-ai/docs/access-control/iam-roles) on the source project. The
    /// destination project is specified as part of the parent field. The source project is specified as part of the
    /// source or external_processor_version_source field.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3ImportProcessorVersionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The source processor version to import from. It can be from a different environment and region than the
        /// destination processor.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalProcessorVersionSource")]
        public virtual GoogleCloudDocumentaiV1beta3ImportProcessorVersionRequestExternalProcessorVersionSource ExternalProcessorVersionSource { get; set; }

        /// <summary>
        /// The source processor version to import from. The source processor version and destination processor need to
        /// be in the same environment and region. Note that ProcessorVersions with `model_type` `MODEL_TYPE_LLM` are
        /// not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processorVersionSource")]
        public virtual string ProcessorVersionSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The external source processor version.</summary>
    public class GoogleCloudDocumentaiV1beta3ImportProcessorVersionRequestExternalProcessorVersionSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The processor version name. Format:
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processorVersion")]
        public virtual string ProcessorVersion { get; set; }

        /// <summary>
        /// Optional. The Document AI service endpoint. For example, 'https://us-documentai.googleapis.com'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceEndpoint")]
        public virtual string ServiceEndpoint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for the ImportProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1beta3ImportProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The destination processor version name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processorVersion")]
        public virtual string ProcessorVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDocumentaiV1beta3ListDocumentsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Query to filter the documents based on https://google.aip.dev/160. ## Currently support query
        /// strings are: `SplitType=DATASET_SPLIT_TEST|DATASET_SPLIT_TRAIN|DATASET_SPLIT_UNASSIGNED` -
        /// `LabelingState=DOCUMENT_LABELED|DOCUMENT_UNLABELED|DOCUMENT_AUTO_LABELED` - `DisplayName=\"file_name.pdf\"`
        /// - `EntityType=abc/def` - `TagName=\"auto-labeling-running\"|\"sampled\"` Note: - Only `AND`, `=` and `!=`
        /// are supported. e.g. `DisplayName=file_name AND EntityType!=abc` IS supported. - Wildcard `*` is supported
        /// only in `DisplayName` filter - No duplicate filter keys are allowed, e.g. `EntityType=a AND EntityType=b` is
        /// NOT supported. - String match is case sensitive (for filter `DisplayName` &amp;amp; `EntityType`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// The maximum number of documents to return. The service may return fewer than this value. If unspecified, at
        /// most 20 documents will be returned. The maximum value is 100; values above 100 will be coerced to 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// A page token, received from a previous `ListDocuments` call. Provide this to retrieve the subsequent page.
        /// When paginating, all other parameters provided to `ListDocuments` must match the call that provided the page
        /// token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Optional. Controls if the request requires a total size of matched documents. See
        /// ListDocumentsResponse.total_size. Enabling this flag may adversely impact performance. Defaults to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnTotalSize")]
        public virtual System.Nullable<bool> ReturnTotalSize { get; set; }

        /// <summary>
        /// Optional. Number of results to skip beginning from the `page_token` if provided.
        /// https://google.aip.dev/158#skipping-results. It must be a non-negative integer. Negative values will be
        /// rejected. Note that this is not the number of pages to skip. If this value causes the cursor to move past
        /// the end of results, ListDocumentsResponse.document_metadata and ListDocumentsResponse.next_page_token will
        /// be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skip")]
        public virtual System.Nullable<int> Skip { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDocumentaiV1beta3ListDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Document metadata corresponding to the listed documents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentMetadata")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3DocumentMetadata> DocumentMetadata { get; set; }

        /// <summary>
        /// A token, which can be sent as ListDocumentsRequest.page_token to retrieve the next page. If this field is
        /// omitted, there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Total count of documents queried.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response from `ListEvaluations`.</summary>
    public class GoogleCloudDocumentaiV1beta3ListEvaluationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The evaluations requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluations")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3Evaluation> Evaluations { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the ListProcessorTypes method.</summary>
    public class GoogleCloudDocumentaiV1beta3ListProcessorTypesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Points to the next page, otherwise empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The processor types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processorTypes")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3ProcessorType> ProcessorTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the ListProcessorVersions method.</summary>
    public class GoogleCloudDocumentaiV1beta3ListProcessorVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Points to the next processor, otherwise empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of processors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processorVersions")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3ProcessorVersion> ProcessorVersions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the ListProcessors method.</summary>
    public class GoogleCloudDocumentaiV1beta3ListProcessorsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Points to the next processor, otherwise empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of processors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processors")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3Processor> Processors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A vertex represents a 2D point in the image. NOTE: the normalized vertex coordinates are relative to the
    /// original image and range from 0 to 1.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3NormalizedVertex : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual System.Nullable<float> X { get; set; }

        /// <summary>Y coordinate (starts from the top of the image).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual System.Nullable<float> Y { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config for Document OCR.</summary>
    public class GoogleCloudDocumentaiV1beta3OcrConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of advanced OCR options to further fine-tune OCR behavior. Current valid values are: -
        /// `legacy_layout`: a heuristics layout detection algorithm, which serves as an alternative to the current
        /// ML-based layout detection algorithm. Customers can choose the best suitable layout algorithm based on their
        /// situation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advancedOcrOptions")]
        public virtual System.Collections.Generic.IList<string> AdvancedOcrOptions { get; set; }

        /// <summary>
        /// Turn on font identification model and return font style information. Deprecated, use
        /// PremiumFeatures.compute_style_info instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeStyleInfo")]
        public virtual System.Nullable<bool> ComputeStyleInfo { get; set; }

        /// <summary>
        /// Turn off character box detector in OCR engine. Character box detection is enabled by default in OCR 2.0 (and
        /// later) processors.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableCharacterBoxesDetection")]
        public virtual System.Nullable<bool> DisableCharacterBoxesDetection { get; set; }

        /// <summary>
        /// Enables intelligent document quality scores after OCR. Can help with diagnosing why OCR responses are of
        /// poor quality for a given input. Adds additional latency comparable to regular OCR to the process call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableImageQualityScores")]
        public virtual System.Nullable<bool> EnableImageQualityScores { get; set; }

        /// <summary>
        /// Enables special handling for PDFs with existing text information. Results in better text extraction quality
        /// in such PDF inputs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableNativePdfParsing")]
        public virtual System.Nullable<bool> EnableNativePdfParsing { get; set; }

        /// <summary>Includes symbol level OCR information if set to true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSymbol")]
        public virtual System.Nullable<bool> EnableSymbol { get; set; }

        /// <summary>Hints for the OCR model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hints")]
        public virtual GoogleCloudDocumentaiV1beta3OcrConfigHints Hints { get; set; }

        /// <summary>Configurations for premium OCR features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("premiumFeatures")]
        public virtual GoogleCloudDocumentaiV1beta3OcrConfigPremiumFeatures PremiumFeatures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Hints for OCR Engine</summary>
    public class GoogleCloudDocumentaiV1beta3OcrConfigHints : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of BCP-47 language codes to use for OCR. In most cases, not specifying it yields the best results since
        /// it enables automatic language detection. For languages based on the Latin alphabet, setting hints is not
        /// needed. In rare cases, when the language of the text in the image is known, setting a hint will help get
        /// better results (although it will be a significant hindrance if the hint is wrong).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageHints")]
        public virtual System.Collections.Generic.IList<string> LanguageHints { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configurations for premium OCR features.</summary>
    public class GoogleCloudDocumentaiV1beta3OcrConfigPremiumFeatures : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Turn on font identification model and return font style information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeStyleInfo")]
        public virtual System.Nullable<bool> ComputeStyleInfo { get; set; }

        /// <summary>Turn on the model that can extract LaTeX math formulas.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableMathOcr")]
        public virtual System.Nullable<bool> EnableMathOcr { get; set; }

        /// <summary>
        /// Turn on selection mark detector in OCR engine. Only available in OCR 2.0 (and later) processors.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSelectionMarkDetection")]
        public virtual System.Nullable<bool> EnableSelectionMarkDetection { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for Process API</summary>
    public class GoogleCloudDocumentaiV1beta3ProcessOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Only process certain pages from the end, same as above.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromEnd")]
        public virtual System.Nullable<int> FromEnd { get; set; }

        /// <summary>Only process certain pages from the start. Process all if the document has fewer pages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromStart")]
        public virtual System.Nullable<int> FromStart { get; set; }

        /// <summary>Which pages to process (1-indexed).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualPageSelector")]
        public virtual GoogleCloudDocumentaiV1beta3ProcessOptionsIndividualPageSelector IndividualPageSelector { get; set; }

        /// <summary>
        /// Optional. Only applicable to `LAYOUT_PARSER_PROCESSOR`. Returns error if set on other processor types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layoutConfig")]
        public virtual GoogleCloudDocumentaiV1beta3ProcessOptionsLayoutConfig LayoutConfig { get; set; }

        /// <summary>
        /// Only applicable to `OCR_PROCESSOR` and `FORM_PARSER_PROCESSOR`. Returns error if set on other processor
        /// types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ocrConfig")]
        public virtual GoogleCloudDocumentaiV1beta3OcrConfig OcrConfig { get; set; }

        /// <summary>
        /// Optional. Override the schema of the ProcessorVersion. Will return an Invalid Argument error if this field
        /// is set when the underlying ProcessorVersion doesn't support schema override.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaOverride")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentSchema SchemaOverride { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of individual page numbers.</summary>
    public class GoogleCloudDocumentaiV1beta3ProcessOptionsIndividualPageSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Indices of the pages (starting from 1).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pages")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> Pages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Serving config for layout parser processor.</summary>
    public class GoogleCloudDocumentaiV1beta3ProcessOptionsLayoutConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Config for chunking in layout parser processor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chunkingConfig")]
        public virtual GoogleCloudDocumentaiV1beta3ProcessOptionsLayoutConfigChunkingConfig ChunkingConfig { get; set; }

        /// <summary>Optional. Whether to include image annotations in layout parser response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableImageAnnotation")]
        public virtual System.Nullable<bool> EnableImageAnnotation { get; set; }

        /// <summary>Optional. Whether to extract images in layout parser response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableImageExtraction")]
        public virtual System.Nullable<bool> EnableImageExtraction { get; set; }

        /// <summary>Optional. Whether to refine PDF layout using LLM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableLlmLayoutParsing")]
        public virtual System.Nullable<bool> EnableLlmLayoutParsing { get; set; }

        /// <summary>Optional. Whether to include table annotations in layout parser response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableTableAnnotation")]
        public virtual System.Nullable<bool> EnableTableAnnotation { get; set; }

        /// <summary>Optional. Whether to include bounding boxes in layout parser processor response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnBoundingBoxes")]
        public virtual System.Nullable<bool> ReturnBoundingBoxes { get; set; }

        /// <summary>Optional. Whether to include images in layout parser processor response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnImages")]
        public virtual System.Nullable<bool> ReturnImages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Serving config for chunking.</summary>
    public class GoogleCloudDocumentaiV1beta3ProcessOptionsLayoutConfigChunkingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The percentile of cosine dissimilarity that must be exceeded between a group of tokens and the
        /// next. The smaller this number is, the more chunks will be generated. THIS FIELD IS NOT YET USED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("breakpointPercentileThreshold")]
        public virtual System.Nullable<int> BreakpointPercentileThreshold { get; set; }

        /// <summary>Optional. The chunk sizes to use when splitting documents, in order of level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chunkSize")]
        public virtual System.Nullable<int> ChunkSize { get; set; }

        /// <summary>Optional. Whether or not to include ancestor headings when splitting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeAncestorHeadings")]
        public virtual System.Nullable<bool> IncludeAncestorHeadings { get; set; }

        /// <summary>
        /// Optional. The number of tokens to group together when evaluating semantic similarity. THIS FIELD IS NOT YET
        /// USED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("semanticChunkingGroupSize")]
        public virtual System.Nullable<bool> SemanticChunkingGroupSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the ProcessDocument method.</summary>
    public class GoogleCloudDocumentaiV1beta3ProcessRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The document payload, the content and mime_type fields must be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual GoogleCloudDocumentaiV1beta3Document Document { get; set; }

        /// <summary>
        /// Specifies which fields to include in the ProcessResponse.document output. Only supports top-level document
        /// and pages field, so it must be in the form of `{document_field_name}` or `pages.{page_field_name}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldMask")]
        public virtual object FieldMask { get; set; }

        /// <summary>A raw document on Google Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDocument")]
        public virtual GoogleCloudDocumentaiV1beta3GcsDocument GcsDocument { get; set; }

        /// <summary>Optional. Option to remove images from the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imagelessMode")]
        public virtual System.Nullable<bool> ImagelessMode { get; set; }

        /// <summary>An inline document proto.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inlineDocument")]
        public virtual GoogleCloudDocumentaiV1beta3Document InlineDocument { get; set; }

        /// <summary>
        /// Optional. The labels with user-defined metadata for the request. Label keys and values can be no longer than
        /// 63 characters (Unicode codepoints) and can only contain lowercase letters, numeric characters, underscores,
        /// and dashes. International characters are allowed. Label values are optional. Label keys must start with a
        /// letter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Inference-time options for the process API</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processOptions")]
        public virtual GoogleCloudDocumentaiV1beta3ProcessOptions ProcessOptions { get; set; }

        /// <summary>A raw document content (bytes).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawDocument")]
        public virtual GoogleCloudDocumentaiV1beta3RawDocument RawDocument { get; set; }

        /// <summary>Whether human review should be skipped for this request. Default to `false`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipHumanReview")]
        public virtual System.Nullable<bool> SkipHumanReview { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the ProcessDocument method.</summary>
    public class GoogleCloudDocumentaiV1beta3ProcessResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The document payload, will populate fields based on the processor's behavior.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual GoogleCloudDocumentaiV1beta3Document Document { get; set; }

        /// <summary>
        /// The name of the operation triggered by the processed document. If the human review process isn't triggered,
        /// this field is empty. It has the same response type and metadata as the long-running operation returned by
        /// ReviewDocument.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("humanReviewOperation")]
        public virtual string HumanReviewOperation { get; set; }

        /// <summary>The status of human review on the processed document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("humanReviewStatus")]
        public virtual GoogleCloudDocumentaiV1beta3HumanReviewStatus HumanReviewStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The first-class citizen for Document AI. Each processor defines how to extract structural information from a
    /// document.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3Processor : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time the processor was created.</summary>
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

        /// <summary>The default processor version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultProcessorVersion")]
        public virtual string DefaultProcessorVersion { get; set; }

        /// <summary>The display name of the processor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The [KMS key](https://cloud.google.com/security-key-management) used for encryption and decryption in CMEK
        /// scenarios.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>
        /// Output only. Immutable. The resource name of the processor. Format:
        /// `projects/{project}/locations/{location}/processors/{processor}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Immutable. The http endpoint that can be called to invoke processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processEndpoint")]
        public virtual string ProcessEndpoint { get; set; }

        /// <summary>Output only. The processor version aliases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processorVersionAliases")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3ProcessorVersionAlias> ProcessorVersionAliases { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>Output only. The state of the processor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// The processor type, such as: `OCR_PROCESSOR`, `INVOICE_PROCESSOR`. To get a list of processor types, see
        /// FetchProcessorTypes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A processor type is responsible for performing a certain document understanding task on a certain type of
    /// document.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3ProcessorType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the processor type allows creation. If true, users can create a processor of this processor type.
        /// Otherwise, users need to request access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowCreation")]
        public virtual System.Nullable<bool> AllowCreation { get; set; }

        /// <summary>The locations in which this processor is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableLocations")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3ProcessorTypeLocationInfo> AvailableLocations { get; set; }

        /// <summary>The processor category, used by UI to group processor types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>Launch stage of the processor type</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchStage")]
        public virtual string LaunchStage { get; set; }

        /// <summary>
        /// The resource name of the processor type. Format: `projects/{project}/processorTypes/{processor_type}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>A set of Cloud Storage URIs of sample documents for this processor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleDocumentUris")]
        public virtual System.Collections.Generic.IList<string> SampleDocumentUris { get; set; }

        /// <summary>The processor type, such as: `OCR_PROCESSOR`, `INVOICE_PROCESSOR`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The location information about where the processor is available.</summary>
    public class GoogleCloudDocumentaiV1beta3ProcessorTypeLocationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The location ID. For supported locations, refer to [regional and multi-regional
        /// support](/document-ai/docs/regions).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A processor version is an implementation of a processor. Each processor can have multiple versions, pretrained
    /// by Google internally or uptrained by the customer. A processor can only have one default version at a time. Its
    /// document-processing behavior is defined by that version.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3ProcessorVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time the processor version was created.</summary>
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

        /// <summary>Output only. If set, information about the eventual deprecation of this version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deprecationInfo")]
        public virtual GoogleCloudDocumentaiV1beta3ProcessorVersionDeprecationInfo DeprecationInfo { get; set; }

        /// <summary>The display name of the processor version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. The schema of the processor version. Describes the output.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentSchema")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentSchema DocumentSchema { get; set; }

        /// <summary>Output only. Information about Generative AI model-based processor versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("genAiModelInfo")]
        public virtual GoogleCloudDocumentaiV1beta3ProcessorVersionGenAiModelInfo GenAiModelInfo { get; set; }

        /// <summary>Output only. Denotes that this `ProcessorVersion` is managed by Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleManaged")]
        public virtual System.Nullable<bool> GoogleManaged { get; set; }

        /// <summary>Output only. The KMS key name used for encryption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>Output only. The KMS key version with which data is encrypted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyVersionName")]
        public virtual string KmsKeyVersionName { get; set; }

        /// <summary>Output only. The most recently invoked evaluation for the processor version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestEvaluation")]
        public virtual GoogleCloudDocumentaiV1beta3EvaluationReference LatestEvaluation { get; set; }

        /// <summary>Output only. The model type of this processor version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelType")]
        public virtual string ModelType { get; set; }

        /// <summary>
        /// Identifier. The resource name of the processor version. Format:
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processor_version}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>Output only. The state of the processor version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the alias and the aliased resource name of processor version.</summary>
    public class GoogleCloudDocumentaiV1beta3ProcessorVersionAlias : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The alias in the form of `processor_version` resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alias")]
        public virtual string Alias { get; set; }

        /// <summary>The resource name of aliased processor version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processorVersion")]
        public virtual string ProcessorVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the upcoming deprecation of this processor version.</summary>
    public class GoogleCloudDocumentaiV1beta3ProcessorVersionDeprecationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _deprecationTimeRaw;

        private object _deprecationTime;

        /// <summary>The time at which this processor version will be deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deprecationTime")]
        public virtual string DeprecationTimeRaw
        {
            get => _deprecationTimeRaw;
            set
            {
                _deprecationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deprecationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeprecationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeprecationTimeDateTimeOffset instead.")]
        public virtual object DeprecationTime
        {
            get => _deprecationTime;
            set
            {
                _deprecationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deprecationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="DeprecationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeprecationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeprecationTimeRaw);
            set => DeprecationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>If set, the processor version that will be used as a replacement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replacementProcessorVersion")]
        public virtual string ReplacementProcessorVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about Generative AI model-based processor versions.</summary>
    public class GoogleCloudDocumentaiV1beta3ProcessorVersionGenAiModelInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information for a custom Generative AI model created by the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customGenAiModelInfo")]
        public virtual GoogleCloudDocumentaiV1beta3ProcessorVersionGenAiModelInfoCustomGenAiModelInfo CustomGenAiModelInfo { get; set; }

        /// <summary>Information for a pretrained Google-managed foundation model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("foundationGenAiModelInfo")]
        public virtual GoogleCloudDocumentaiV1beta3ProcessorVersionGenAiModelInfoFoundationGenAiModelInfo FoundationGenAiModelInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information for a custom Generative AI model created by the user. These are created with `Create New Version` in
    /// either the `Call foundation model` or `Fine tuning` tabs.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3ProcessorVersionGenAiModelInfoCustomGenAiModelInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The base processor version ID for the custom model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseProcessorVersionId")]
        public virtual string BaseProcessorVersionId { get; set; }

        /// <summary>The type of custom model created by the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customModelType")]
        public virtual string CustomModelType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information for a pretrained Google-managed foundation model.</summary>
    public class GoogleCloudDocumentaiV1beta3ProcessorVersionGenAiModelInfoFoundationGenAiModelInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether finetuning is allowed for this base processor version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finetuningAllowed")]
        public virtual System.Nullable<bool> FinetuningAllowed { get; set; }

        /// <summary>The minimum number of labeled documents in the training dataset required for finetuning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minTrainLabeledDocuments")]
        public virtual System.Nullable<int> MinTrainLabeledDocuments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about a property.</summary>
    public class GoogleCloudDocumentaiV1beta3PropertyMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Field extraction metadata on the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldExtractionMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3FieldExtractionMetadata FieldExtractionMetadata { get; set; }

        /// <summary>Whether the property should be considered as "inactive".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inactive")]
        public virtual System.Nullable<bool> Inactive { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Payload message of raw document content (bytes).</summary>
    public class GoogleCloudDocumentaiV1beta3RawDocument : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Inline document content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>
        /// The display name of the document, it supports all Unicode characters except the following: `*`, `?`, `[`,
        /// `]`, `%`, `{`, `}`,`'`, `\"`, `,` `~`, `=` and `:` are reserved. If not specified, a default ID is
        /// generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>An IANA MIME type (RFC6838) indicating the nature and format of the content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the ReviewDocument method.</summary>
    public class GoogleCloudDocumentaiV1beta3ReviewDocumentOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The creation time of the operation.</summary>
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

        /// <summary>The Crowd Compute question ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("questionId")]
        public virtual string QuestionId { get; set; }

        /// <summary>Used only when Operation.done is false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// A message providing more details about the current state of processing. For example, the error message if
        /// the operation is failed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The last update time of the operation.</summary>
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

    /// <summary>Request message for the ReviewDocument method.</summary>
    public class GoogleCloudDocumentaiV1beta3ReviewDocumentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The document that needs human review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual GoogleCloudDocumentaiV1beta3Document Document { get; set; }

        /// <summary>The document schema of the human review task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentSchema")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentSchema DocumentSchema { get; set; }

        /// <summary>Whether the validation should be performed on the ad-hoc review request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSchemaValidation")]
        public virtual System.Nullable<bool> EnableSchemaValidation { get; set; }

        /// <summary>An inline document proto.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inlineDocument")]
        public virtual GoogleCloudDocumentaiV1beta3Document InlineDocument { get; set; }

        /// <summary>The priority of the human review task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual string Priority { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the ReviewDocument method.</summary>
    public class GoogleCloudDocumentaiV1beta3ReviewDocumentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Cloud Storage uri for the human reviewed document if the review is succeeded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual string GcsDestination { get; set; }

        /// <summary>The reason why the review is rejected by reviewer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rejectionReason")]
        public virtual string RejectionReason { get; set; }

        /// <summary>The state of the review operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The revision reference specifies which revision on the document to read.</summary>
    public class GoogleCloudDocumentaiV1beta3RevisionRef : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Reads the revision generated by the processor version. The format takes the full resource name of processor
        /// version.
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestProcessorVersion")]
        public virtual string LatestProcessorVersion { get; set; }

        /// <summary>Reads the revision by the predefined case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionCase")]
        public virtual string RevisionCase { get; set; }

        /// <summary>Reads the revision given by the id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the SetDefaultProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1beta3SetDefaultProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the SetDefaultProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1beta3SetDefaultProcessorVersionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The resource name of child ProcessorVersion to use as default. Format:
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{version}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultProcessorVersion")]
        public virtual string DefaultProcessorVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the SetDefaultProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1beta3SetDefaultProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for document summarization.</summary>
    public class GoogleCloudDocumentaiV1beta3SummaryOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The format the summary should be in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>How long the summary should be.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("length")]
        public virtual string Length { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata that represents a processor version being created.</summary>
    public class GoogleCloudDocumentaiV1beta3TrainProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The test dataset validation information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testDatasetValidation")]
        public virtual GoogleCloudDocumentaiV1beta3TrainProcessorVersionMetadataDatasetValidation TestDatasetValidation { get; set; }

        /// <summary>The training dataset validation information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingDatasetValidation")]
        public virtual GoogleCloudDocumentaiV1beta3TrainProcessorVersionMetadataDatasetValidation TrainingDatasetValidation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The dataset validation information. This includes any and all errors with documents and the dataset.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3TrainProcessorVersionMetadataDatasetValidation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total number of dataset errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetErrorCount")]
        public virtual System.Nullable<int> DatasetErrorCount { get; set; }

        /// <summary>
        /// Error information for the dataset as a whole. A maximum of 10 dataset errors will be returned. A single
        /// dataset error is terminal for training.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetErrors")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> DatasetErrors { get; set; }

        /// <summary>The total number of document errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentErrorCount")]
        public virtual System.Nullable<int> DocumentErrorCount { get; set; }

        /// <summary>
        /// Error information pertaining to specific documents. A maximum of 10 document errors will be returned. Any
        /// document with errors will not be used throughout training.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentErrors")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> DocumentErrors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the TrainProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1beta3TrainProcessorVersionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The processor version to use as a base for training. This processor version must be a child of
        /// `parent`. Format:
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseProcessorVersion")]
        public virtual string BaseProcessorVersion { get; set; }

        /// <summary>Options to control Custom Document Extraction (CDE) Processor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customDocumentExtractionOptions")]
        public virtual GoogleCloudDocumentaiV1beta3TrainProcessorVersionRequestCustomDocumentExtractionOptions CustomDocumentExtractionOptions { get; set; }

        /// <summary>Optional. The schema the processor version will be trained with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentSchema")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentSchema DocumentSchema { get; set; }

        /// <summary>Options to control foundation model tuning of a processor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("foundationModelTuningOptions")]
        public virtual GoogleCloudDocumentaiV1beta3TrainProcessorVersionRequestFoundationModelTuningOptions FoundationModelTuningOptions { get; set; }

        /// <summary>Optional. The input data used to train the ProcessorVersion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputData")]
        public virtual GoogleCloudDocumentaiV1beta3TrainProcessorVersionRequestInputData InputData { get; set; }

        /// <summary>Required. The processor version to be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processorVersion")]
        public virtual GoogleCloudDocumentaiV1beta3ProcessorVersion ProcessorVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options to control the training of the Custom Document Extraction (CDE) Processor.</summary>
    public class GoogleCloudDocumentaiV1beta3TrainProcessorVersionRequestCustomDocumentExtractionOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Training method to use for CDE training.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingMethod")]
        public virtual string TrainingMethod { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options to control foundation model tuning of the processor.</summary>
    public class GoogleCloudDocumentaiV1beta3TrainProcessorVersionRequestFoundationModelTuningOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The multiplier to apply to the recommended learning rate. Valid values are between 0.1 and 10. If
        /// not provided, recommended learning rate will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("learningRateMultiplier")]
        public virtual System.Nullable<float> LearningRateMultiplier { get; set; }

        /// <summary>
        /// Optional. The number of steps to run for model tuning. Valid values are between 1 and 400. If not provided,
        /// recommended steps will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainSteps")]
        public virtual System.Nullable<int> TrainSteps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The input data used to train a new ProcessorVersion.</summary>
    public class GoogleCloudDocumentaiV1beta3TrainProcessorVersionRequestInputData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The documents used for testing the trained version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testDocuments")]
        public virtual GoogleCloudDocumentaiV1beta3BatchDocumentsInputConfig TestDocuments { get; set; }

        /// <summary>The documents used for training the new version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingDocuments")]
        public virtual GoogleCloudDocumentaiV1beta3BatchDocumentsInputConfig TrainingDocuments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for TrainProcessorVersion.</summary>
    public class GoogleCloudDocumentaiV1beta3TrainProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name of the processor version produced by training.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processorVersion")]
        public virtual string ProcessorVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the UndeployProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1beta3UndeployProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the UndeployProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1beta3UndeployProcessorVersionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the UndeployProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1beta3UndeployProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDocumentaiV1beta3UpdateDatasetOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A vertex represents a 2D point in the image. NOTE: the vertex coordinates are in the same scale as the original
    /// image.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3Vertex : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual System.Nullable<int> X { get; set; }

        /// <summary>Y coordinate (starts from the top of the image).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual System.Nullable<int> Y { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Locations.ListLocations.</summary>
    public class GoogleCloudLocationListLocationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of locations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<GoogleCloudLocationLocation> Locations { get; set; }

        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that represents a Google Cloud location.</summary>
    public class GoogleCloudLocationLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The friendly name for this location, typically a nearby city name. For example, "Tokyo".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Cross-service attributes for the location. For example {"cloud.googleapis.com/region": "us-east1"}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The canonical id for this location. For example: `"us-east1"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>Service-specific metadata. For example the available capacity at the given location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// Resource name for the location, which may vary between implementations. For example:
        /// `"projects/example-project/locations/us-east1"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Operations.ListOperations.</summary>
    public class GoogleLongrunningListOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of operations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<GoogleLongrunningOperation> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class GoogleLongrunningOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is `false`, it means the operation is still in progress. If `true`, the operation is completed,
        /// and either `error` or `response` is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual GoogleRpcStatus Error { get; set; }

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

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    /// </summary>
    public class GoogleProtobufEmpty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class GoogleRpcStatus : Google.Apis.Requests.IDirectResponseSchema
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
    /// Represents a color in the RGBA color space. This representation is designed for simplicity of conversion to and
    /// from color representations in various languages over compactness. For example, the fields of this representation
    /// can be trivially provided to the constructor of `java.awt.Color` in Java; it can also be trivially provided to
    /// UIColor's `+colorWithRed:green:blue:alpha` method in iOS; and, with just a little work, it can be easily
    /// formatted into a CSS `rgba()` string in JavaScript. This reference page doesn't have information about the
    /// absolute color space that should be used to interpret the RGB value—for example, sRGB, Adobe RGB, DCI-P3, and
    /// BT.2020. By default, applications should assume the sRGB color space. When color equality needs to be decided,
    /// implementations, unless documented otherwise, treat two colors as equal if all their red, green, blue, and alpha
    /// values each differ by at most `1e-5`. Example (Java): import com.google.type.Color; // ... public static
    /// java.awt.Color fromProto(Color protocolor) { float alpha = protocolor.hasAlpha() ?
    /// protocolor.getAlpha().getValue() : 1.0; return new java.awt.Color( protocolor.getRed(), protocolor.getGreen(),
    /// protocolor.getBlue(), alpha); } public static Color toProto(java.awt.Color color) { float red = (float)
    /// color.getRed(); float green = (float) color.getGreen(); float blue = (float) color.getBlue(); float denominator
    /// = 255.0; Color.Builder resultBuilder = Color .newBuilder() .setRed(red / denominator) .setGreen(green /
    /// denominator) .setBlue(blue / denominator); int alpha = color.getAlpha(); if (alpha != 255) { result.setAlpha(
    /// FloatValue .newBuilder() .setValue(((float) alpha) / denominator) .build()); } return resultBuilder.build(); }
    /// // ... Example (iOS / Obj-C): // ... static UIColor* fromProto(Color* protocolor) { float red = [protocolor
    /// red]; float green = [protocolor green]; float blue = [protocolor blue]; FloatValue* alpha_wrapper = [protocolor
    /// alpha]; float alpha = 1.0; if (alpha_wrapper != nil) { alpha = [alpha_wrapper value]; } return [UIColor
    /// colorWithRed:red green:green blue:blue alpha:alpha]; } static Color* toProto(UIColor* color) { CGFloat red,
    /// green, blue, alpha; if (![color getRed:&amp;amp;red green:&amp;amp;green blue:&amp;amp;blue
    /// alpha:&amp;amp;alpha]) { return nil; } Color* result = [[Color alloc] init]; [result setRed:red]; [result
    /// setGreen:green]; [result setBlue:blue]; if (alpha &amp;lt;= 0.9999) { [result
    /// setAlpha:floatWrapperWithValue(alpha)]; } [result autorelease]; return result; } // ... Example (JavaScript): //
    /// ... var protoToCssColor = function(rgb_color) { var redFrac = rgb_color.red || 0.0; var greenFrac =
    /// rgb_color.green || 0.0; var blueFrac = rgb_color.blue || 0.0; var red = Math.floor(redFrac * 255); var green =
    /// Math.floor(greenFrac * 255); var blue = Math.floor(blueFrac * 255); if (!('alpha' in rgb_color)) { return
    /// rgbToCssColor(red, green, blue); } var alphaFrac = rgb_color.alpha.value || 0.0; var rgbParams = [red, green,
    /// blue].join(','); return ['rgba(', rgbParams, ',', alphaFrac, ')'].join(''); }; var rgbToCssColor = function(red,
    /// green, blue) { var rgbNumber = new Number((red &amp;lt;&amp;lt; 16) | (green &amp;lt;&amp;lt; 8) | blue); var
    /// hexString = rgbNumber.toString(16); var missingZeros = 6 - hexString.length; var resultBuilder = ['#']; for (var
    /// i = 0; i &amp;lt; missingZeros; i++) { resultBuilder.push('0'); } resultBuilder.push(hexString); return
    /// resultBuilder.join(''); }; // ...
    /// </summary>
    public class GoogleTypeColor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fraction of this color that should be applied to the pixel. That is, the final pixel color is defined by
        /// the equation: `pixel color = alpha * (this color) + (1.0 - alpha) * (background color)` This means that a
        /// value of 1.0 corresponds to a solid color, whereas a value of 0.0 corresponds to a completely transparent
        /// color. This uses a wrapper message rather than a simple float scalar so that it is possible to distinguish
        /// between a default value and the value being unset. If omitted, this color object is rendered as a solid
        /// color (as if the alpha value had been explicitly given a value of 1.0).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alpha")]
        public virtual System.Nullable<float> Alpha { get; set; }

        /// <summary>The amount of blue in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blue")]
        public virtual System.Nullable<float> Blue { get; set; }

        /// <summary>The amount of green in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("green")]
        public virtual System.Nullable<float> Green { get; set; }

        /// <summary>The amount of red in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("red")]
        public virtual System.Nullable<float> Red { get; set; }

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
    public class GoogleTypeDate : Google.Apis.Requests.IDirectResponseSchema
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
    /// Represents civil time (or occasionally physical time). This type can represent a civil time in one of a few
    /// possible ways: * When utc_offset is set and time_zone is unset: a civil time on a calendar day with a particular
    /// offset from UTC. * When time_zone is set and utc_offset is unset: a civil time on a calendar day in a particular
    /// time zone. * When neither time_zone nor utc_offset is set: a civil time on a calendar day in local time. The
    /// date is relative to the Proleptic Gregorian Calendar. If year, month, or day are 0, the DateTime is considered
    /// not to have a specific year, month, or day respectively. This type may also be used to represent a physical time
    /// if all the date and time fields are set and either case of the `time_offset` oneof is set. Consider using
    /// `Timestamp` message for physical time instead. If your use case also would like to store the user's timezone,
    /// that can be done in another field. This type is more flexible than some applications may want. Make sure to
    /// document and validate your application's limitations.
    /// </summary>
    public class GoogleTypeDateTime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a datetime
        /// without a day.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>
        /// Optional. Hours of day in 24 hour format. Should be from 0 to 23, defaults to 0 (midnight). An API may
        /// choose to allow the value "24:00:00" for scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Optional. Minutes of hour of day. Must be from 0 to 59, defaults to 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>
        /// Optional. Month of year. Must be from 1 to 12, or 0 if specifying a datetime without a month.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual System.Nullable<int> Month { get; set; }

        /// <summary>
        /// Optional. Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999, defaults to 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Optional. Seconds of minutes of the time. Must normally be from 0 to 59, defaults to 0. An API may allow the
        /// value 60 if it allows leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>Time zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual GoogleTypeTimeZone TimeZone { get; set; }

        /// <summary>
        /// UTC offset. Must be whole seconds, between -18 hours and +18 hours. For example, a UTC offset of -4:00 would
        /// be represented as { seconds: -14400 }.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utcOffset")]
        public virtual object UtcOffset { get; set; }

        /// <summary>
        /// Optional. Year of date. Must be from 1 to 9999, or 0 if specifying a datetime without a year.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("year")]
        public virtual System.Nullable<int> Year { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an amount of money with its currency type.</summary>
    public class GoogleTypeMoney : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The three-letter currency code defined in ISO 4217.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>
        /// Number of nano (10^-9) units of the amount. The value must be between -999,999,999 and +999,999,999
        /// inclusive. If `units` is positive, `nanos` must be positive or zero. If `units` is zero, `nanos` can be
        /// positive, zero, or negative. If `units` is negative, `nanos` must be negative or zero. For example $-1.75 is
        /// represented as `units`=-1 and `nanos`=-750,000,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// The whole units of the amount. For example if `currencyCode` is `"USD"`, then 1 unit is one US dollar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("units")]
        public virtual System.Nullable<long> Units { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a postal address, such as for postal delivery or payments addresses. With a postal address, a postal
    /// service can deliver items to a premise, P.O. box, or similar. A postal address is not intended to model
    /// geographical locations like roads, towns, or mountains. In typical usage, an address would be created by user
    /// input or from importing existing data, depending on the type of process. Advice on address input or editing: -
    /// Use an internationalization-ready address widget such as https://github.com/google/libaddressinput. - Users
    /// should not be presented with UI elements for input or editing of fields outside countries where that field is
    /// used. For more guidance on how to use this schema, see: https://support.google.com/business/answer/6397478.
    /// </summary>
    public class GoogleTypePostalAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Unstructured address lines describing the lower levels of an address. Because values in `address_lines` do
        /// not have type information and may sometimes contain multiple values in a single field (for example, "Austin,
        /// TX"), it is important that the line order is clear. The order of address lines should be "envelope order"
        /// for the country or region of the address. In places where this can vary (for example, Japan),
        /// `address_language` is used to make it explicit (for example, "ja" for large-to-small ordering and "ja-Latn"
        /// or "en" for small-to-large). In this way, the most specific line of an address can be selected based on the
        /// language. The minimum permitted structural representation of an address consists of a `region_code` with all
        /// remaining information placed in the `address_lines`. It would be possible to format such an address very
        /// approximately without geocoding, but no semantic reasoning could be made about any of the address components
        /// until it was at least partially resolved. Creating an address only containing a `region_code` and
        /// `address_lines` and then geocoding is the recommended way to handle completely unstructured addresses (as
        /// opposed to guessing which parts of the address should be localities or administrative areas).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressLines")]
        public virtual System.Collections.Generic.IList<string> AddressLines { get; set; }

        /// <summary>
        /// Optional. Highest administrative subdivision which is used for postal addresses of a country or region. For
        /// example, this can be a state, a province, an oblast, or a prefecture. For Spain, this is the province and
        /// not the autonomous community (for example, "Barcelona" and not "Catalonia"). Many countries don't use an
        /// administrative area in postal addresses. For example, in Switzerland, this should be left unpopulated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("administrativeArea")]
        public virtual string AdministrativeArea { get; set; }

        /// <summary>
        /// Optional. BCP-47 language code of the contents of this address (if known). This is often the UI language of
        /// the input form or is expected to match one of the languages used in the address' country/region, or their
        /// transliterated equivalents. This can affect formatting in certain countries, but is not critical to the
        /// correctness of the data and will never affect any validation or other non-formatting related operations. If
        /// this value is not known, it should be omitted (rather than specifying a possibly incorrect default).
        /// Examples: "zh-Hant", "ja", "ja-Latn", "en".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Optional. Generally refers to the city or town portion of the address. Examples: US city, IT comune, UK post
        /// town. In regions of the world where localities are not well defined or do not fit into this structure well,
        /// leave `locality` empty and use `address_lines`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locality")]
        public virtual string Locality { get; set; }

        /// <summary>Optional. The name of the organization at the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual string Organization { get; set; }

        /// <summary>
        /// Optional. Postal code of the address. Not all countries use or require postal codes to be present, but where
        /// they are used, they may trigger additional validation with other parts of the address (for example, state or
        /// zip code validation in the United States).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; }

        /// <summary>
        /// Optional. The recipient at the address. This field may, under certain circumstances, contain multiline
        /// information. For example, it might contain "care of" information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recipients")]
        public virtual System.Collections.Generic.IList<string> Recipients { get; set; }

        /// <summary>
        /// Required. CLDR region code of the country/region of the address. This is never inferred and it is up to the
        /// user to ensure the value is correct. See https://cldr.unicode.org/ and
        /// https://www.unicode.org/cldr/charts/30/supplemental/territory_information.html for details. Example: "CH"
        /// for Switzerland.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>
        /// The schema revision of the `PostalAddress`. This must be set to 0, which is the latest revision. All new
        /// revisions **must** be backward compatible with old revisions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual System.Nullable<int> Revision { get; set; }

        /// <summary>
        /// Optional. Additional, country-specific, sorting code. This is not used in most regions. Where it is used,
        /// the value is either a string like "CEDEX", optionally followed by a number (for example, "CEDEX 7"), or just
        /// a number alone, representing the "sector code" (Jamaica), "delivery area indicator" (Malawi) or "post office
        /// indicator" (Côte d'Ivoire).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortingCode")]
        public virtual string SortingCode { get; set; }

        /// <summary>
        /// Optional. Sublocality of the address. For example, this can be a neighborhood, borough, or district.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sublocality")]
        public virtual string Sublocality { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a time zone from the [IANA Time Zone Database](https://www.iana.org/time-zones).</summary>
    public class GoogleTypeTimeZone : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>IANA Time Zone Database time zone. For example "America/New_York".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. IANA Time Zone Database version number. For example "2019a".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
