// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.DataLabeling.v1beta1
{
    /// <summary>The DataLabeling Service.</summary>
    public class DataLabelingService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DataLabelingService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DataLabelingService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "datalabeling";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://datalabeling.googleapis.com/";
        #else
            "https://datalabeling.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://datalabeling.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Data Labeling API.</summary>
        public class Scope
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Data Labeling API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

        }



        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for DataLabeling requests.</summary>
    public abstract class DataLabelingBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DataLabelingBaseServiceRequest instance.</summary>
        protected DataLabelingBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes DataLabeling parameter list.</summary>
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
            AnnotationSpecSets = new AnnotationSpecSetsResource(service);
            Datasets = new DatasetsResource(service);
            EvaluationJobs = new EvaluationJobsResource(service);
            Evaluations = new EvaluationsResource(service);
            Instructions = new InstructionsResource(service);
            Operations = new OperationsResource(service);

        }

        /// <summary>Gets the AnnotationSpecSets resource.</summary>
        public virtual AnnotationSpecSetsResource AnnotationSpecSets { get; }

        /// <summary>The "annotationSpecSets" collection of methods.</summary>
        public class AnnotationSpecSetsResource
        {
            private const string Resource = "annotationSpecSets";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AnnotationSpecSetsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Creates an annotation spec set by providing a set of labels.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. AnnotationSpecSet resource parent, format: projects/{project_id}</param>
            public virtual CreateRequest Create(Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1CreateAnnotationSpecSetRequest body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates an annotation spec set by providing a set of labels.</summary>
            public class CreateRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1AnnotationSpecSet>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1CreateAnnotationSpecSetRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. AnnotationSpecSet resource parent, format: projects/{project_id}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1CreateAnnotationSpecSetRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/annotationSpecSets";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                }

            }

            /// <summary>Deletes an annotation spec set by resource name.</summary>
            /// <param name="name">Required. AnnotationSpec resource name, format:
            /// `projects/{project_id}/annotationSpecSets/{annotation_spec_set_id}`.</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes an annotation spec set by resource name.</summary>
            public class DeleteRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>Required. AnnotationSpec resource name, format:
                /// `projects/{project_id}/annotationSpecSets/{annotation_spec_set_id}`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

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
                        Pattern = @"^projects/[^/]+/annotationSpecSets/[^/]+$",
                    });
                }

            }

            /// <summary>Gets an annotation spec set by resource name.</summary>
            /// <param name="name">Required. AnnotationSpecSet resource name, format:
            /// projects/{project_id}/annotationSpecSets/{annotation_spec_set_id}</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets an annotation spec set by resource name.</summary>
            public class GetRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1AnnotationSpecSet>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>Required. AnnotationSpecSet resource name, format:
                /// projects/{project_id}/annotationSpecSets/{annotation_spec_set_id}</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

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
                        Pattern = @"^projects/[^/]+/annotationSpecSets/[^/]+$",
                    });
                }

            }

            /// <summary>Lists annotation spec sets for a project. Pagination is supported.</summary>
            /// <param name="parent">Required. Parent of AnnotationSpecSet resource, format: projects/{project_id}</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists annotation spec sets for a project. Pagination is supported.</summary>
            public class ListRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1ListAnnotationSpecSetsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }


                /// <summary>Required. Parent of AnnotationSpecSet resource, format: projects/{project_id}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional. Filter is not supported at this moment.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Optional. Requested page size. Server may return fewer results than requested. Default
                /// value is 100.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Optional. A token identifying a page of results for the server to return. Typically
                /// obtained by ListAnnotationSpecSetsResponse.next_page_token of the previous
                /// [DataLabelingService.ListAnnotationSpecSets] call. Return first page if empty.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/annotationSpecSets";

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
                        Pattern = @"^projects/[^/]+$",
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
        /// <summary>Gets the Datasets resource.</summary>
        public virtual DatasetsResource Datasets { get; }

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
                AnnotatedDatasets = new AnnotatedDatasetsResource(service);
                DataItems = new DataItemsResource(service);
                Evaluations = new EvaluationsResource(service);
                Image = new ImageResource(service);
                Text = new TextResource(service);
                Video = new VideoResource(service);

            }

            /// <summary>Gets the AnnotatedDatasets resource.</summary>
            public virtual AnnotatedDatasetsResource AnnotatedDatasets { get; }

            /// <summary>The "annotatedDatasets" collection of methods.</summary>
            public class AnnotatedDatasetsResource
            {
                private const string Resource = "annotatedDatasets";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AnnotatedDatasetsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    DataItems = new DataItemsResource(service);
                    Examples = new ExamplesResource(service);
                    FeedbackThreads = new FeedbackThreadsResource(service);

                }

                /// <summary>Gets the DataItems resource.</summary>
                public virtual DataItemsResource DataItems { get; }

                /// <summary>The "dataItems" collection of methods.</summary>
                public class DataItemsResource
                {
                    private const string Resource = "dataItems";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public DataItemsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;

                    }


                    /// <summary>Gets a data item in a dataset by resource name. This API can be called after data are
                    /// imported into dataset.</summary>
                    /// <param name="name">Required. The name of the data item to get, format:
                    /// projects/{project_id}/datasets/{dataset_id}/dataItems/{data_item_id}</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets a data item in a dataset by resource name. This API can be called after data are
                    /// imported into dataset.</summary>
                    public class GetRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1DataItem>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }


                        /// <summary>Required. The name of the data item to get, format:
                        /// projects/{project_id}/datasets/{dataset_id}/dataItems/{data_item_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }


                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}";

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
                                Pattern = @"^projects/[^/]+/datasets/[^/]+/annotatedDatasets/[^/]+/dataItems/[^/]+$",
                            });
                        }

                    }

                    /// <summary>Lists data items in a dataset. This API can be called after data are imported into
                    /// dataset. Pagination is supported.</summary>
                    /// <param name="parent">Required. Name of the dataset to list data items, format:
                    /// projects/{project_id}/datasets/{dataset_id}</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists data items in a dataset. This API can be called after data are imported into
                    /// dataset. Pagination is supported.</summary>
                    public class ListRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1ListDataItemsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }


                        /// <summary>Required. Name of the dataset to list data items, format:
                        /// projects/{project_id}/datasets/{dataset_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. Filter is not supported at this moment.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Optional. Requested page size. Server may return fewer results than requested.
                        /// Default value is 100.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Optional. A token identifying a page of results for the server to return. Typically
                        /// obtained by ListDataItemsResponse.next_page_token of the previous
                        /// [DataLabelingService.ListDataItems] call. Return first page if empty.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }


                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/dataItems";

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
                                Pattern = @"^projects/[^/]+/datasets/[^/]+/annotatedDatasets/[^/]+$",
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
                /// <summary>Gets the Examples resource.</summary>
                public virtual ExamplesResource Examples { get; }

                /// <summary>The "examples" collection of methods.</summary>
                public class ExamplesResource
                {
                    private const string Resource = "examples";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ExamplesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;

                    }


                    /// <summary>Gets an example by resource name, including both data and annotation.</summary>
                    /// <param name="name">Required. Name of example, format: projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/
                    /// {annotated_dataset_id}/examples/{example_id}</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets an example by resource name, including both data and annotation.</summary>
                    public class GetRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1Example>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }


                        /// <summary>Required. Name of example, format:
                        /// projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/
                        /// {annotated_dataset_id}/examples/{example_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Optional. An expression for filtering Examples. Filter by
                        /// annotation_spec.display_name is supported. Format "annotation_spec.display_name =
                        /// {display_name}"</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }


                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}";

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
                                Pattern = @"^projects/[^/]+/datasets/[^/]+/annotatedDatasets/[^/]+/examples/[^/]+$",
                            });
                            RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filter",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }

                    }

                    /// <summary>Lists examples in an annotated dataset. Pagination is supported.</summary>
                    /// <param name="parent">Required. Example resource parent.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists examples in an annotated dataset. Pagination is supported.</summary>
                    public class ListRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1ListExamplesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }


                        /// <summary>Required. Example resource parent.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. An expression for filtering Examples. For annotated datasets that have
                        /// annotation spec set, filter by annotation_spec.display_name is supported. Format
                        /// "annotation_spec.display_name = {display_name}"</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Optional. Requested page size. Server may return fewer results than requested.
                        /// Default value is 100.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Optional. A token identifying a page of results for the server to return. Typically
                        /// obtained by ListExamplesResponse.next_page_token of the previous
                        /// [DataLabelingService.ListExamples] call. Return first page if empty.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }


                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/examples";

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
                                Pattern = @"^projects/[^/]+/datasets/[^/]+/annotatedDatasets/[^/]+$",
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
                /// <summary>Gets the FeedbackThreads resource.</summary>
                public virtual FeedbackThreadsResource FeedbackThreads { get; }

                /// <summary>The "feedbackThreads" collection of methods.</summary>
                public class FeedbackThreadsResource
                {
                    private const string Resource = "feedbackThreads";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public FeedbackThreadsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        FeedbackMessages = new FeedbackMessagesResource(service);

                    }

                    /// <summary>Gets the FeedbackMessages resource.</summary>
                    public virtual FeedbackMessagesResource FeedbackMessages { get; }

                    /// <summary>The "feedbackMessages" collection of methods.</summary>
                    public class FeedbackMessagesResource
                    {
                        private const string Resource = "feedbackMessages";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public FeedbackMessagesResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;

                        }


                        /// <summary>Create a FeedbackMessage object.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">Required. FeedbackMessage resource parent, format: projects/{project_id}/datasets/{dataset_id}/
                        /// annotatedDatasets/{annotated_dataset_id}/feedbackThreads/{feedback_thread_id}.</param>
                        public virtual CreateRequest Create(Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1FeedbackMessage body, string parent)
                        {
                            return new CreateRequest(service, body, parent);
                        }

                        /// <summary>Create a FeedbackMessage object.</summary>
                        public class CreateRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleLongrunningOperation>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1FeedbackMessage body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }


                            /// <summary>Required. FeedbackMessage resource parent, format: projects/{project_id}/datase
                            /// ts/{dataset_id}/annotatedDatasets/{annotated_dataset_id}/feedbackThreads/{feedback_threa
                            /// d_id}.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }


                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1FeedbackMessage Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta1/{+parent}/feedbackMessages";

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
                                    Pattern = @"^projects/[^/]+/datasets/[^/]+/annotatedDatasets/[^/]+/feedbackThreads/[^/]+$",
                                });
                            }

                        }

                        /// <summary>Delete a FeedbackMessage.</summary>
                        /// <param name="name">Required. Name of the FeedbackMessage that is going to be deleted. Format: 'projects/{project_id}
                        /// /datasets/{dataset_id}/annotatedDatasets/{annotated_dataset_id}/feedbackThreads/{feedback_thread_id}/feedbackMessage
                        /// s/{feedback_message_id}'.</param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(service, name);
                        }

                        /// <summary>Delete a FeedbackMessage.</summary>
                        public class DeleteRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleProtobufEmpty>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }


                            /// <summary>Required. Name of the FeedbackMessage that is going to be deleted. Format: 'pro
                            /// jects/{project_id}/datasets/{dataset_id}/annotatedDatasets/{annotated_dataset_id}/feedba
                            /// ckThreads/{feedback_thread_id}/feedbackMessages/{feedback_message_id}'.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }


                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "delete";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "DELETE";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/datasets/[^/]+/annotatedDatasets/[^/]+/feedbackThreads/[^/]+/feedbackMessages/[^/]+$",
                                });
                            }

                        }

                        /// <summary>Get a FeedbackMessage object.</summary>
                        /// <param name="name">Required.   Name of the feedback.   Format:   'projects/{project_id}/datasets/{dataset_id}/annota
                        /// tedDatasets/{annotated_dataset_id}/feedbackThreads/{feedback_thread_id}/feedbackMessages/{feedback_message_id}'.</pa
                        /// ram>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Get a FeedbackMessage object.</summary>
                        public class GetRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1FeedbackMessage>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }


                            /// <summary>Required.   Name of the feedback.   Format:   'projects/{project_id}/datasets/{
                            /// dataset_id}/annotatedDatasets/{annotated_dataset_id}/feedbackThreads/{feedback_thread_id
                            /// }/feedbackMessages/{feedback_message_id}'.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }


                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "get";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/datasets/[^/]+/annotatedDatasets/[^/]+/feedbackThreads/[^/]+/feedbackMessages/[^/]+$",
                                });
                            }

                        }

                        /// <summary>List FeedbackMessages with pagination.</summary>
                        /// <param name="parent">Required. FeedbackMessage resource parent. Format: "projects/{project_id}/datasets/{dataset_id}
                        /// /annotatedDatasets/{annotated_dataset_id}/feedbackThreads/{feedback_thread_id}"</param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>List FeedbackMessages with pagination.</summary>
                        public class ListRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1ListFeedbackMessagesResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }


                            /// <summary>Required. FeedbackMessage resource parent. Format: "projects/{project_id}/datas
                            /// ets/{dataset_id}/annotatedDatasets/{annotated_dataset_id}/feedbackThreads/{feedback_thre
                            /// ad_id}"</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Optional. Requested page size. Server may return fewer results than requested.
                            /// Default value is 100.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>Optional. A token identifying a page of results for the server to return.
                            /// Typically obtained by ListFeedbackMessages.next_page_token of the previous
                            /// [DataLabelingService.ListFeedbackMessages] call. Return first page if empty.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }


                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta1/{+parent}/feedbackMessages";

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
                                    Pattern = @"^projects/[^/]+/datasets/[^/]+/annotatedDatasets/[^/]+/feedbackThreads/[^/]+$",
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

                    /// <summary>Delete a FeedbackThread.</summary>
                    /// <param name="name">Required. Name of the FeedbackThread that is going to be deleted. Format: 'projects/{project_id}/
                    /// datasets/{dataset_id}/annotatedDatasets/{annotated_dataset_id}/feedbackThreads/{feedback_thread_id}'.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Delete a FeedbackThread.</summary>
                    public class DeleteRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleProtobufEmpty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }


                        /// <summary>Required. Name of the FeedbackThread that is going to be deleted. Format: 'projects
                        /// /{project_id}/datasets/{dataset_id}/annotatedDatasets/{annotated_dataset_id}/feedbackThreads
                        /// /{feedback_thread_id}'.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }


                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}";

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
                                Pattern = @"^projects/[^/]+/datasets/[^/]+/annotatedDatasets/[^/]+/feedbackThreads/[^/]+$",
                            });
                        }

                    }

                    /// <summary>Get a FeedbackThread object.</summary>
                    /// <param name="name">Required. Name of the feedback. Format: 'projects/{project_id}/datasets/{dataset_id}/annotatedDat
                    /// asets/{annotated_dataset_id}/feedbackThreads/{feedback_thread_id}'.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Get a FeedbackThread object.</summary>
                    public class GetRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1FeedbackThread>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }


                        /// <summary>Required. Name of the feedback. Format: 'projects/{project_id}/datasets/{dataset_id
                        /// }/annotatedDatasets/{annotated_dataset_id}/feedbackThreads/{feedback_thread_id}'.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }


                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}";

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
                                Pattern = @"^projects/[^/]+/datasets/[^/]+/annotatedDatasets/[^/]+/feedbackThreads/[^/]+$",
                            });
                        }

                    }

                    /// <summary>List FeedbackThreads with pagination.</summary>
                    /// <param name="parent">Required. FeedbackThread resource parent. Format:
                    /// "projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/{annotated_dataset_id}"</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>List FeedbackThreads with pagination.</summary>
                    public class ListRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1ListFeedbackThreadsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }


                        /// <summary>Required. FeedbackThread resource parent. Format: "projects/{project_id}/datasets/{
                        /// dataset_id}/annotatedDatasets/{annotated_dataset_id}"</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. Requested page size. Server may return fewer results than requested.
                        /// Default value is 100.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Optional. A token identifying a page of results for the server to return. Typically
                        /// obtained by ListFeedbackThreads.next_page_token of the previous
                        /// [DataLabelingService.ListFeedbackThreads] call. Return first page if empty.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }


                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/feedbackThreads";

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
                                Pattern = @"^projects/[^/]+/datasets/[^/]+/annotatedDatasets/[^/]+$",
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

                /// <summary>Deletes an annotated dataset by resource name.</summary>
                /// <param name="name">Required. Name of the annotated dataset to delete, format:
                /// projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/ {annotated_dataset_id}</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes an annotated dataset by resource name.</summary>
                public class DeleteRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }


                    /// <summary>Required. Name of the annotated dataset to delete, format:
                    /// projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/ {annotated_dataset_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}";

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
                            Pattern = @"^projects/[^/]+/datasets/[^/]+/annotatedDatasets/[^/]+$",
                        });
                    }

                }

                /// <summary>Gets an annotated dataset by resource name.</summary>
                /// <param name="name">Required. Name of the annotated dataset to get, format:
                /// projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/ {annotated_dataset_id}</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets an annotated dataset by resource name.</summary>
                public class GetRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1AnnotatedDataset>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }


                    /// <summary>Required. Name of the annotated dataset to get, format:
                    /// projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/ {annotated_dataset_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}";

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
                            Pattern = @"^projects/[^/]+/datasets/[^/]+/annotatedDatasets/[^/]+$",
                        });
                    }

                }

                /// <summary>Lists annotated datasets for a dataset. Pagination is supported.</summary>
                /// <param name="parent">Required. Name of the dataset to list annotated datasets, format:
                /// projects/{project_id}/datasets/{dataset_id}</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists annotated datasets for a dataset. Pagination is supported.</summary>
                public class ListRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1ListAnnotatedDatasetsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }


                    /// <summary>Required. Name of the dataset to list annotated datasets, format:
                    /// projects/{project_id}/datasets/{dataset_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Filter is not supported at this moment.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Requested page size. Server may return fewer results than requested. Default
                    /// value is 100.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results for the server to return. Typically
                    /// obtained by ListAnnotatedDatasetsResponse.next_page_token of the previous
                    /// [DataLabelingService.ListAnnotatedDatasets] call. Return first page if empty.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/annotatedDatasets";

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
                            Pattern = @"^projects/[^/]+/datasets/[^/]+$",
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
            /// <summary>Gets the DataItems resource.</summary>
            public virtual DataItemsResource DataItems { get; }

            /// <summary>The "dataItems" collection of methods.</summary>
            public class DataItemsResource
            {
                private const string Resource = "dataItems";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DataItemsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;

                }


                /// <summary>Gets a data item in a dataset by resource name. This API can be called after data are
                /// imported into dataset.</summary>
                /// <param name="name">Required. The name of the data item to get, format:
                /// projects/{project_id}/datasets/{dataset_id}/dataItems/{data_item_id}</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets a data item in a dataset by resource name. This API can be called after data are
                /// imported into dataset.</summary>
                public class GetRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1DataItem>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }


                    /// <summary>Required. The name of the data item to get, format:
                    /// projects/{project_id}/datasets/{dataset_id}/dataItems/{data_item_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}";

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
                            Pattern = @"^projects/[^/]+/datasets/[^/]+/dataItems/[^/]+$",
                        });
                    }

                }

                /// <summary>Lists data items in a dataset. This API can be called after data are imported into dataset.
                /// Pagination is supported.</summary>
                /// <param name="parent">Required. Name of the dataset to list data items, format:
                /// projects/{project_id}/datasets/{dataset_id}</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists data items in a dataset. This API can be called after data are imported into dataset.
                /// Pagination is supported.</summary>
                public class ListRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1ListDataItemsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }


                    /// <summary>Required. Name of the dataset to list data items, format:
                    /// projects/{project_id}/datasets/{dataset_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Filter is not supported at this moment.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Requested page size. Server may return fewer results than requested. Default
                    /// value is 100.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results for the server to return. Typically
                    /// obtained by ListDataItemsResponse.next_page_token of the previous
                    /// [DataLabelingService.ListDataItems] call. Return first page if empty.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/dataItems";

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
                            Pattern = @"^projects/[^/]+/datasets/[^/]+$",
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
                    ExampleComparisons = new ExampleComparisonsResource(service);

                }

                /// <summary>Gets the ExampleComparisons resource.</summary>
                public virtual ExampleComparisonsResource ExampleComparisons { get; }

                /// <summary>The "exampleComparisons" collection of methods.</summary>
                public class ExampleComparisonsResource
                {
                    private const string Resource = "exampleComparisons";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ExampleComparisonsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;

                    }


                    /// <summary>Searches example comparisons from an evaluation. The return format is a list of example
                    /// comparisons that show ground truth and prediction(s) for a single input. Search by providing an
                    /// evaluation ID.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. Name of the Evaluation resource to search for example comparisons from. Format:
                    /// "projects/{project_id}/datasets/{dataset_id}/evaluations/ {evaluation_id}"</param>
                    public virtual SearchRequest Search(Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1SearchExampleComparisonsRequest body, string parent)
                    {
                        return new SearchRequest(service, body, parent);
                    }

                    /// <summary>Searches example comparisons from an evaluation. The return format is a list of example
                    /// comparisons that show ground truth and prediction(s) for a single input. Search by providing an
                    /// evaluation ID.</summary>
                    public class SearchRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1SearchExampleComparisonsResponse>
                    {
                        /// <summary>Constructs a new Search request.</summary>
                        public SearchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1SearchExampleComparisonsRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>Required. Name of the Evaluation resource to search for example comparisons from.
                        /// Format: "projects/{project_id}/datasets/{dataset_id}/evaluations/ {evaluation_id}"</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1SearchExampleComparisonsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "search";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/exampleComparisons:search";

                        /// <summary>Initializes Search parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/datasets/[^/]+/evaluations/[^/]+$",
                            });
                        }

                    }
                }

                /// <summary>Gets an evaluation by resource name (to search, use projects.evaluations.search).</summary>
                /// <param name="name">Required. Name of the evaluation. Format: "projects/{project_id}/datasets/
                /// {dataset_id}/evaluations/{evaluation_id}'</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets an evaluation by resource name (to search, use projects.evaluations.search).</summary>
                public class GetRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1Evaluation>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }


                    /// <summary>Required. Name of the evaluation. Format: "projects/{project_id}/datasets/
                    /// {dataset_id}/evaluations/{evaluation_id}'</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}";

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
                            Pattern = @"^projects/[^/]+/datasets/[^/]+/evaluations/[^/]+$",
                        });
                    }

                }
            }
            /// <summary>Gets the Image resource.</summary>
            public virtual ImageResource Image { get; }

            /// <summary>The "image" collection of methods.</summary>
            public class ImageResource
            {
                private const string Resource = "image";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ImageResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;

                }


                /// <summary>Starts a labeling task for image. The type of image labeling task is configured by feature
                /// in the request.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Name of the dataset to request labeling task, format:
                /// projects/{project_id}/datasets/{dataset_id}</param>
                public virtual LabelRequest Label(Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1LabelImageRequest body, string parent)
                {
                    return new LabelRequest(service, body, parent);
                }

                /// <summary>Starts a labeling task for image. The type of image labeling task is configured by feature
                /// in the request.</summary>
                public class LabelRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Label request.</summary>
                    public LabelRequest(Google.Apis.Services.IClientService service, Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1LabelImageRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>Required. Name of the dataset to request labeling task, format:
                    /// projects/{project_id}/datasets/{dataset_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1LabelImageRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "label";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/image:label";

                    /// <summary>Initializes Label parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/datasets/[^/]+$",
                        });
                    }

                }
            }
            /// <summary>Gets the Text resource.</summary>
            public virtual TextResource Text { get; }

            /// <summary>The "text" collection of methods.</summary>
            public class TextResource
            {
                private const string Resource = "text";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public TextResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;

                }


                /// <summary>Starts a labeling task for text. The type of text labeling task is configured by feature in
                /// the request.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Name of the data set to request labeling task, format:
                /// projects/{project_id}/datasets/{dataset_id}</param>
                public virtual LabelRequest Label(Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1LabelTextRequest body, string parent)
                {
                    return new LabelRequest(service, body, parent);
                }

                /// <summary>Starts a labeling task for text. The type of text labeling task is configured by feature in
                /// the request.</summary>
                public class LabelRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Label request.</summary>
                    public LabelRequest(Google.Apis.Services.IClientService service, Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1LabelTextRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>Required. Name of the data set to request labeling task, format:
                    /// projects/{project_id}/datasets/{dataset_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1LabelTextRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "label";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/text:label";

                    /// <summary>Initializes Label parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/datasets/[^/]+$",
                        });
                    }

                }
            }
            /// <summary>Gets the Video resource.</summary>
            public virtual VideoResource Video { get; }

            /// <summary>The "video" collection of methods.</summary>
            public class VideoResource
            {
                private const string Resource = "video";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public VideoResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;

                }


                /// <summary>Starts a labeling task for video. The type of video labeling task is configured by feature
                /// in the request.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Name of the dataset to request labeling task, format:
                /// projects/{project_id}/datasets/{dataset_id}</param>
                public virtual LabelRequest Label(Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1LabelVideoRequest body, string parent)
                {
                    return new LabelRequest(service, body, parent);
                }

                /// <summary>Starts a labeling task for video. The type of video labeling task is configured by feature
                /// in the request.</summary>
                public class LabelRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Label request.</summary>
                    public LabelRequest(Google.Apis.Services.IClientService service, Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1LabelVideoRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>Required. Name of the dataset to request labeling task, format:
                    /// projects/{project_id}/datasets/{dataset_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1LabelVideoRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "label";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/video:label";

                    /// <summary>Initializes Label parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/datasets/[^/]+$",
                        });
                    }

                }
            }

            /// <summary>Creates dataset. If success return a Dataset resource.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. Dataset resource parent, format: projects/{project_id}</param>
            public virtual CreateRequest Create(Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1CreateDatasetRequest body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates dataset. If success return a Dataset resource.</summary>
            public class CreateRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1Dataset>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1CreateDatasetRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. Dataset resource parent, format: projects/{project_id}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1CreateDatasetRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/datasets";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                }

            }

            /// <summary>Deletes a dataset by resource name.</summary>
            /// <param name="name">Required. Dataset resource name, format: projects/{project_id}/datasets/{dataset_id}</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes a dataset by resource name.</summary>
            public class DeleteRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>Required. Dataset resource name, format:
                /// projects/{project_id}/datasets/{dataset_id}</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

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
                        Pattern = @"^projects/[^/]+/datasets/[^/]+$",
                    });
                }

            }

            /// <summary>Exports data and annotations from dataset.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. Dataset resource name, format: projects/{project_id}/datasets/{dataset_id}</param>
            public virtual ExportDataRequest ExportData(Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1ExportDataRequest body, string name)
            {
                return new ExportDataRequest(service, body, name);
            }

            /// <summary>Exports data and annotations from dataset.</summary>
            public class ExportDataRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleLongrunningOperation>
            {
                /// <summary>Constructs a new ExportData request.</summary>
                public ExportDataRequest(Google.Apis.Services.IClientService service, Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1ExportDataRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. Dataset resource name, format:
                /// projects/{project_id}/datasets/{dataset_id}</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1ExportDataRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "exportData";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}:exportData";

                /// <summary>Initializes ExportData parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/datasets/[^/]+$",
                    });
                }

            }

            /// <summary>Gets dataset by resource name.</summary>
            /// <param name="name">Required. Dataset resource name, format: projects/{project_id}/datasets/{dataset_id}</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets dataset by resource name.</summary>
            public class GetRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1Dataset>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>Required. Dataset resource name, format:
                /// projects/{project_id}/datasets/{dataset_id}</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

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
                        Pattern = @"^projects/[^/]+/datasets/[^/]+$",
                    });
                }

            }

            /// <summary>Imports data into dataset based on source locations defined in request. It can be called
            /// multiple times for the same dataset. Each dataset can only have one long running operation running on
            /// it. For example, no labeling task (also long running operation) can be started while importing is still
            /// ongoing. Vice versa.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. Dataset resource name, format: projects/{project_id}/datasets/{dataset_id}</param>
            public virtual ImportDataRequest ImportData(Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1ImportDataRequest body, string name)
            {
                return new ImportDataRequest(service, body, name);
            }

            /// <summary>Imports data into dataset based on source locations defined in request. It can be called
            /// multiple times for the same dataset. Each dataset can only have one long running operation running on
            /// it. For example, no labeling task (also long running operation) can be started while importing is still
            /// ongoing. Vice versa.</summary>
            public class ImportDataRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleLongrunningOperation>
            {
                /// <summary>Constructs a new ImportData request.</summary>
                public ImportDataRequest(Google.Apis.Services.IClientService service, Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1ImportDataRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. Dataset resource name, format:
                /// projects/{project_id}/datasets/{dataset_id}</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1ImportDataRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "importData";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}:importData";

                /// <summary>Initializes ImportData parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/datasets/[^/]+$",
                    });
                }

            }

            /// <summary>Lists datasets under a project. Pagination is supported.</summary>
            /// <param name="parent">Required. Dataset resource parent, format: projects/{project_id}</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists datasets under a project. Pagination is supported.</summary>
            public class ListRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1ListDatasetsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }


                /// <summary>Required. Dataset resource parent, format: projects/{project_id}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional. Filter on dataset is not supported at this moment.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Optional. Requested page size. Server may return fewer results than requested. Default
                /// value is 100.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Optional. A token identifying a page of results for the server to return. Typically
                /// obtained by ListDatasetsResponse.next_page_token of the previous [DataLabelingService.ListDatasets]
                /// call. Returns the first page if empty.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/datasets";

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
                        Pattern = @"^projects/[^/]+$",
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
        /// <summary>Gets the EvaluationJobs resource.</summary>
        public virtual EvaluationJobsResource EvaluationJobs { get; }

        /// <summary>The "evaluationJobs" collection of methods.</summary>
        public class EvaluationJobsResource
        {
            private const string Resource = "evaluationJobs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public EvaluationJobsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Creates an evaluation job.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. Evaluation job resource parent. Format: "projects/{project_id}"</param>
            public virtual CreateRequest Create(Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1CreateEvaluationJobRequest body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates an evaluation job.</summary>
            public class CreateRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1EvaluationJob>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1CreateEvaluationJobRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. Evaluation job resource parent. Format: "projects/{project_id}"</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1CreateEvaluationJobRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/evaluationJobs";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                }

            }

            /// <summary>Stops and deletes an evaluation job.</summary>
            /// <param name="name">Required. Name of the evaluation job that is going to be deleted. Format:
            /// "projects/{project_id}/evaluationJobs/{evaluation_job_id}"</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Stops and deletes an evaluation job.</summary>
            public class DeleteRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>Required. Name of the evaluation job that is going to be deleted. Format:
                /// "projects/{project_id}/evaluationJobs/{evaluation_job_id}"</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

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
                        Pattern = @"^projects/[^/]+/evaluationJobs/[^/]+$",
                    });
                }

            }

            /// <summary>Gets an evaluation job by resource name.</summary>
            /// <param name="name">Required. Name of the evaluation job. Format: "projects/{project_id}
            /// /evaluationJobs/{evaluation_job_id}"</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets an evaluation job by resource name.</summary>
            public class GetRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1EvaluationJob>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>Required. Name of the evaluation job. Format: "projects/{project_id}
                /// /evaluationJobs/{evaluation_job_id}"</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

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
                        Pattern = @"^projects/[^/]+/evaluationJobs/[^/]+$",
                    });
                }

            }

            /// <summary>Lists all evaluation jobs within a project with possible filters. Pagination is
            /// supported.</summary>
            /// <param name="parent">Required. Evaluation job resource parent. Format: "projects/{project_id}"</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists all evaluation jobs within a project with possible filters. Pagination is
            /// supported.</summary>
            public class ListRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1ListEvaluationJobsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }


                /// <summary>Required. Evaluation job resource parent. Format: "projects/{project_id}"</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional. You can filter the jobs to list by model_id (also known as model_name, as
                /// described in EvaluationJob.modelVersion) or by evaluation job state (as described in
                /// EvaluationJob.state). To filter by both criteria, use the `AND` operator or the `OR` operator. For
                /// example, you can use the following string for your filter: "evaluation_job.model_id = {model_name}
                /// AND evaluation_job.state = {evaluation_job_state}"</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Optional. Requested page size. Server may return fewer results than requested. Default
                /// value is 100.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Optional. A token identifying a page of results for the server to return. Typically
                /// obtained by the nextPageToken in the response to the previous request. The request returns the first
                /// page if this is empty.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/evaluationJobs";

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
                        Pattern = @"^projects/[^/]+$",
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

            /// <summary>Updates an evaluation job. You can only update certain fields of the job's EvaluationJobConfig:
            /// `humanAnnotationConfig.instruction`, `exampleCount`, and `exampleSamplePercentage`. If you want to
            /// change any other aspect of the evaluation job, you must delete the job and create a new one.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Output only. After you create a job, Data Labeling Service assigns a name to the job with the
            /// following format: "projects/{project_id}/evaluationJobs/ {evaluation_job_id}"</param>
            public virtual PatchRequest Patch(Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1EvaluationJob body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates an evaluation job. You can only update certain fields of the job's EvaluationJobConfig:
            /// `humanAnnotationConfig.instruction`, `exampleCount`, and `exampleSamplePercentage`. If you want to
            /// change any other aspect of the evaluation job, you must delete the job and create a new one.</summary>
            public class PatchRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1EvaluationJob>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1EvaluationJob body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Output only. After you create a job, Data Labeling Service assigns a name to the job with
                /// the following format: "projects/{project_id}/evaluationJobs/ {evaluation_job_id}"</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Optional. Mask for which fields to update. You can only provide the following fields: *
                /// `evaluationJobConfig.humanAnnotationConfig.instruction` * `evaluationJobConfig.exampleCount` *
                /// `evaluationJobConfig.exampleSamplePercentage` You can provide more than one of these fields by
                /// separating them with commas.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1EvaluationJob Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

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
                        Pattern = @"^projects/[^/]+/evaluationJobs/[^/]+$",
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

            /// <summary>Pauses an evaluation job. Pausing an evaluation job that is already in a `PAUSED` state is a
            /// no-op.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. Name of the evaluation job that is going to be paused. Format:
            /// "projects/{project_id}/evaluationJobs/{evaluation_job_id}"</param>
            public virtual PauseRequest Pause(Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1PauseEvaluationJobRequest body, string name)
            {
                return new PauseRequest(service, body, name);
            }

            /// <summary>Pauses an evaluation job. Pausing an evaluation job that is already in a `PAUSED` state is a
            /// no-op.</summary>
            public class PauseRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Pause request.</summary>
                public PauseRequest(Google.Apis.Services.IClientService service, Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1PauseEvaluationJobRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. Name of the evaluation job that is going to be paused. Format:
                /// "projects/{project_id}/evaluationJobs/{evaluation_job_id}"</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1PauseEvaluationJobRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "pause";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}:pause";

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
                        Pattern = @"^projects/[^/]+/evaluationJobs/[^/]+$",
                    });
                }

            }

            /// <summary>Resumes a paused evaluation job. A deleted evaluation job can't be resumed. Resuming a running
            /// or scheduled evaluation job is a no-op.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. Name of the evaluation job that is going to be resumed. Format:
            /// "projects/{project_id}/evaluationJobs/{evaluation_job_id}"</param>
            public virtual ResumeRequest Resume(Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1ResumeEvaluationJobRequest body, string name)
            {
                return new ResumeRequest(service, body, name);
            }

            /// <summary>Resumes a paused evaluation job. A deleted evaluation job can't be resumed. Resuming a running
            /// or scheduled evaluation job is a no-op.</summary>
            public class ResumeRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Resume request.</summary>
                public ResumeRequest(Google.Apis.Services.IClientService service, Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1ResumeEvaluationJobRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. Name of the evaluation job that is going to be resumed. Format:
                /// "projects/{project_id}/evaluationJobs/{evaluation_job_id}"</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1ResumeEvaluationJobRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "resume";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}:resume";

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
                        Pattern = @"^projects/[^/]+/evaluationJobs/[^/]+$",
                    });
                }

            }
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


            /// <summary>Searches evaluations within a project.</summary>
            /// <param name="parent">Required. Evaluation search parent (project ID). Format: "projects/ {project_id}"</param>
            public virtual SearchRequest Search(string parent)
            {
                return new SearchRequest(service, parent);
            }

            /// <summary>Searches evaluations within a project.</summary>
            public class SearchRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1SearchEvaluationsResponse>
            {
                /// <summary>Constructs a new Search request.</summary>
                public SearchRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }


                /// <summary>Required. Evaluation search parent (project ID). Format: "projects/ {project_id}"</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional. To search evaluations, you can filter by the following: *
                /// evaluation_job.evaluation_job_id (the last part of EvaluationJob.name) * evaluation_job.model_id
                /// (the {model_name} portion of EvaluationJob.modelVersion) *
                /// evaluation_job.evaluation_job_run_time_start (Minimum threshold for the evaluationJobRunTime that
                /// created the evaluation) * evaluation_job.evaluation_job_run_time_end (Maximum threshold for the
                /// evaluationJobRunTime that created the evaluation) * evaluation_job.job_state (EvaluationJob.state) *
                /// annotation_spec.display_name (the Evaluation contains a metric for the annotation spec with this
                /// displayName) To filter by multiple critiera, use the `AND` operator or the `OR` operator. The
                /// following examples shows a string that filters by several critiera:
                /// "evaluation_job.evaluation_job_id = {evaluation_job_id} AND evaluation_job.model_id = {model_name}
                /// AND evaluation_job.evaluation_job_run_time_start = {timestamp_1} AND
                /// evaluation_job.evaluation_job_run_time_end = {timestamp_2} AND annotation_spec.display_name =
                /// {display_name}"</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Optional. Requested page size. Server may return fewer results than requested. Default
                /// value is 100.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Optional. A token identifying a page of results for the server to return. Typically
                /// obtained by the nextPageToken of the response to a previous search request. If you don't specify
                /// this field, the API call requests the first page of the search.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "search";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/evaluations:search";

                /// <summary>Initializes Search parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
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
        /// <summary>Gets the Instructions resource.</summary>
        public virtual InstructionsResource Instructions { get; }

        /// <summary>The "instructions" collection of methods.</summary>
        public class InstructionsResource
        {
            private const string Resource = "instructions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public InstructionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Creates an instruction for how data should be labeled.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. Instruction resource parent, format: projects/{project_id}</param>
            public virtual CreateRequest Create(Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1CreateInstructionRequest body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates an instruction for how data should be labeled.</summary>
            public class CreateRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleLongrunningOperation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1CreateInstructionRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. Instruction resource parent, format: projects/{project_id}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1CreateInstructionRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/instructions";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                }

            }

            /// <summary>Deletes an instruction object by resource name.</summary>
            /// <param name="name">Required. Instruction resource name, format:
            /// projects/{project_id}/instructions/{instruction_id}</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes an instruction object by resource name.</summary>
            public class DeleteRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>Required. Instruction resource name, format:
                /// projects/{project_id}/instructions/{instruction_id}</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

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
                        Pattern = @"^projects/[^/]+/instructions/[^/]+$",
                    });
                }

            }

            /// <summary>Gets an instruction by resource name.</summary>
            /// <param name="name">Required. Instruction resource name, format:
            /// projects/{project_id}/instructions/{instruction_id}</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets an instruction by resource name.</summary>
            public class GetRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1Instruction>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>Required. Instruction resource name, format:
                /// projects/{project_id}/instructions/{instruction_id}</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

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
                        Pattern = @"^projects/[^/]+/instructions/[^/]+$",
                    });
                }

            }

            /// <summary>Lists instructions for a project. Pagination is supported.</summary>
            /// <param name="parent">Required. Instruction resource parent, format: projects/{project_id}</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists instructions for a project. Pagination is supported.</summary>
            public class ListRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleCloudDatalabelingV1beta1ListInstructionsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }


                /// <summary>Required. Instruction resource parent, format: projects/{project_id}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional. Filter is not supported at this moment.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Optional. Requested page size. Server may return fewer results than requested. Default
                /// value is 100.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Optional. A token identifying a page of results for the server to return. Typically
                /// obtained by ListInstructionsResponse.next_page_token of the previous
                /// [DataLabelingService.ListInstructions] call. Return first page if empty.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/instructions";

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
                        Pattern = @"^projects/[^/]+$",
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


            /// <summary>Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
            /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
            /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
            /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
            /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
            /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.</summary>
            /// <param name="name">The name of the operation resource to be cancelled.</param>
            public virtual CancelRequest Cancel(string name)
            {
                return new CancelRequest(service, name);
            }

            /// <summary>Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
            /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
            /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
            /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
            /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
            /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.</summary>
            public class CancelRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleProtobufEmpty>
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
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}:cancel";

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
                        Pattern = @"^projects/[^/]+/operations/[^/]+$",
                    });
                }

            }

            /// <summary>Deletes a long-running operation. This method indicates that the client is no longer interested
            /// in the operation result. It does not cancel the operation. If the server doesn't support this method, it
            /// returns `google.rpc.Code.UNIMPLEMENTED`.</summary>
            /// <param name="name">The name of the operation resource to be deleted.</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes a long-running operation. This method indicates that the client is no longer interested
            /// in the operation result. It does not cancel the operation. If the server doesn't support this method, it
            /// returns `google.rpc.Code.UNIMPLEMENTED`.</summary>
            public class DeleteRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>The name of the operation resource to be deleted.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

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
                        Pattern = @"^projects/[^/]+/operations/[^/]+$",
                    });
                }

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
            public class GetRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleLongrunningOperation>
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
                public override string RestPath => "v1beta1/{+name}";

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
                        Pattern = @"^projects/[^/]+/operations/[^/]+$",
                    });
                }

            }

            /// <summary>Lists operations that match the specified filter in the request. If the server doesn't support
            /// this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the
            /// binding to use different resource name schemes, such as `users/operations`. To override the binding, API
            /// services can add a binding such as `"/v1/{name=users}/operations"` to their service configuration. For
            /// backwards compatibility, the default name includes the operations collection id, however overriding
            /// users must ensure the name binding is the parent resource, without the operations collection
            /// id.</summary>
            /// <param name="name">The name of the operation's parent resource.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(service, name);
            }

            /// <summary>Lists operations that match the specified filter in the request. If the server doesn't support
            /// this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the
            /// binding to use different resource name schemes, such as `users/operations`. To override the binding, API
            /// services can add a binding such as `"/v1/{name=users}/operations"` to their service configuration. For
            /// backwards compatibility, the default name includes the operations collection id, however overriding
            /// users must ensure the name binding is the parent resource, without the operations collection
            /// id.</summary>
            public class ListRequest : DataLabelingBaseServiceRequest<Google.Apis.DataLabeling.v1beta1.Data.GoogleLongrunningListOperationsResponse>
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
                public override string RestPath => "v1beta1/{+name}/operations";

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

namespace Google.Apis.DataLabeling.v1beta1.Data
{    

    /// <summary>Metadata of a CreateInstruction operation.</summary>
    public class GoogleCloudDatalabelingV1alpha1CreateInstructionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Timestamp when create instruction request was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The name of the created Instruction. projects/{project_id}/instructions/{instruction_id}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instruction")]
        public virtual string Instruction { get; set; }

        /// <summary>Partial failures encountered. E.g. single files that couldn't be read. Status details field will
        /// contain standard GCP error details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialFailures")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> PartialFailures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata of an ExportData operation.</summary>
    public class GoogleCloudDatalabelingV1alpha1ExportDataOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The name of annotated dataset in format
        /// "projects/datasets/annotatedDatasets".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedDataset")]
        public virtual string AnnotatedDataset { get; set; }

        /// <summary>Output only. Timestamp when export dataset request was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The name of dataset to be exported. "projects/datasets"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>Output only. Partial failures encountered. E.g. single files that couldn't be read. Status details
        /// field will contain standard GCP error details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialFailures")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> PartialFailures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response used for ExportDataset longrunning operation.</summary>
    public class GoogleCloudDatalabelingV1alpha1ExportDataOperationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The name of annotated dataset in format
        /// "projects/datasets/annotatedDatasets".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedDataset")]
        public virtual string AnnotatedDataset { get; set; }

        /// <summary>Ouptut only. The name of dataset. "projects/datasets"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>Output only. Number of examples exported successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportCount")]
        public virtual System.Nullable<int> ExportCount { get; set; }

        /// <summary>Output only. Statistic infos of labels in the exported dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelStats")]
        public virtual GoogleCloudDatalabelingV1alpha1LabelStats LabelStats { get; set; }

        /// <summary>Output only. output_config in the ExportData request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual GoogleCloudDatalabelingV1alpha1OutputConfig OutputConfig { get; set; }

        /// <summary>Output only. Total number of examples requested to export</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalCount")]
        public virtual System.Nullable<int> TotalCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Export destination of the data.Only gcs path is allowed in output_uri.</summary>
    public class GoogleCloudDatalabelingV1alpha1GcsDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The format of the gcs destination. Only "text/csv" and "application/json" are
        /// supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>Required. The output uri of destination file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputUri")]
        public virtual string OutputUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Export folder destination of the data.</summary>
    public class GoogleCloudDatalabelingV1alpha1GcsFolderDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Cloud Storage directory to export data to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputFolderUri")]
        public virtual string OutputFolderUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Configuration for how human labeling task should be done.</summary>
    public class GoogleCloudDatalabelingV1alpha1HumanAnnotationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A human-readable description for AnnotatedDataset. The description can be up to 10000
        /// characters long.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedDatasetDescription")]
        public virtual string AnnotatedDatasetDescription { get; set; }

        /// <summary>Required. A human-readable name for AnnotatedDataset defined by users. Maximum of 64 characters
        /// .</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedDatasetDisplayName")]
        public virtual string AnnotatedDatasetDisplayName { get; set; }

        /// <summary>Optional. If you want your own labeling contributors to manage and work on this labeling request,
        /// you can set these contributors here. We will give them access to the question types in crowdcompute. Note
        /// that these emails must be registered in crowdcompute worker UI: https://crowd-compute.appspot.com/</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contributorEmails")]
        public virtual System.Collections.Generic.IList<string> ContributorEmails { get; set; }

        /// <summary>Required. Instruction resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instruction")]
        public virtual string Instruction { get; set; }

        /// <summary>Optional. A human-readable label used to logically group labeling tasks. This string must match the
        /// regular expression `[a-zA-Z\\d_-]{0,128}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelGroup")]
        public virtual string LabelGroup { get; set; }

        /// <summary>Optional. The Language of this question, as a [BCP-47](https://www.rfc-
        /// editor.org/rfc/bcp/bcp47.txt). Default value is en-US. Only need to set this when task is language related.
        /// For example, French text classification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Optional. Maximum duration for contributors to answer a question. Maximum is 3600 seconds. Default
        /// is 3600 seconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("questionDuration")]
        public virtual object QuestionDuration { get; set; }

        /// <summary>Optional. Replication of questions. Each question will be sent to up to this number of contributors
        /// to label. Aggregated answers will be returned. Default is set to 1. For image related labeling, valid values
        /// are 1, 3, 5.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicaCount")]
        public virtual System.Nullable<int> ReplicaCount { get; set; }

        /// <summary>Email of the user who started the labeling task and should be notified by email. If empty no
        /// notification will be sent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEmailAddress")]
        public virtual string UserEmailAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata of an ImportData operation.</summary>
    public class GoogleCloudDatalabelingV1alpha1ImportDataOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Timestamp when import dataset request was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The name of imported dataset. "projects/datasets"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>Output only. Partial failures encountered. E.g. single files that couldn't be read. Status details
        /// field will contain standard GCP error details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialFailures")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> PartialFailures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response used for ImportData longrunning operation.</summary>
    public class GoogleCloudDatalabelingV1alpha1ImportDataOperationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Ouptut only. The name of imported dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>Output only. Number of examples imported successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importCount")]
        public virtual System.Nullable<int> ImportCount { get; set; }

        /// <summary>Output only. Total number of examples requested to import</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalCount")]
        public virtual System.Nullable<int> TotalCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelImageBoundingBox operation metadata.</summary>
    public class GoogleCloudDatalabelingV1alpha1LabelImageBoundingBoxOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of LabelImageBoundingPoly operation metadata.</summary>
    public class GoogleCloudDatalabelingV1alpha1LabelImageBoundingPolyOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata of a LabelImageClassification operation.</summary>
    public class GoogleCloudDatalabelingV1alpha1LabelImageClassificationOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelImageOrientedBoundingBox operation metadata.</summary>
    public class GoogleCloudDatalabelingV1alpha1LabelImageOrientedBoundingBoxOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of LabelImagePolyline operation metadata.</summary>
    public class GoogleCloudDatalabelingV1alpha1LabelImagePolylineOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelImageSegmentation operation metadata.</summary>
    public class GoogleCloudDatalabelingV1alpha1LabelImageSegmentationOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata of a labeling operation, such as LabelImage or LabelVideo. Next tag: 23</summary>
    public class GoogleCloudDatalabelingV1alpha1LabelOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The name of annotated dataset in format
        /// "projects/datasets/annotatedDatasets".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedDataset")]
        public virtual string AnnotatedDataset { get; set; }

        /// <summary>Output only. Timestamp when labeling request was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The name of dataset to be labeled. "projects/datasets"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>Details of label image bounding box operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageBoundingBoxDetails")]
        public virtual GoogleCloudDatalabelingV1alpha1LabelImageBoundingBoxOperationMetadata ImageBoundingBoxDetails { get; set; }

        /// <summary>Details of label image bounding poly operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageBoundingPolyDetails")]
        public virtual GoogleCloudDatalabelingV1alpha1LabelImageBoundingPolyOperationMetadata ImageBoundingPolyDetails { get; set; }

        /// <summary>Details of label image classification operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageClassificationDetails")]
        public virtual GoogleCloudDatalabelingV1alpha1LabelImageClassificationOperationMetadata ImageClassificationDetails { get; set; }

        /// <summary>Details of label image oriented bounding box operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageOrientedBoundingBoxDetails")]
        public virtual GoogleCloudDatalabelingV1alpha1LabelImageOrientedBoundingBoxOperationMetadata ImageOrientedBoundingBoxDetails { get; set; }

        /// <summary>Details of label image polyline operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imagePolylineDetails")]
        public virtual GoogleCloudDatalabelingV1alpha1LabelImagePolylineOperationMetadata ImagePolylineDetails { get; set; }

        /// <summary>Details of label image segmentation operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageSegmentationDetails")]
        public virtual GoogleCloudDatalabelingV1alpha1LabelImageSegmentationOperationMetadata ImageSegmentationDetails { get; set; }

        /// <summary>Output only. Partial failures encountered. E.g. single files that couldn't be read. Status details
        /// field will contain standard GCP error details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialFailures")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> PartialFailures { get; set; }

        /// <summary>Output only. Progress of label operation. Range: [0, 100].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressPercent")]
        public virtual System.Nullable<int> ProgressPercent { get; set; }

        /// <summary>Details of label text classification operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textClassificationDetails")]
        public virtual GoogleCloudDatalabelingV1alpha1LabelTextClassificationOperationMetadata TextClassificationDetails { get; set; }

        /// <summary>Details of label text entity extraction operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textEntityExtractionDetails")]
        public virtual GoogleCloudDatalabelingV1alpha1LabelTextEntityExtractionOperationMetadata TextEntityExtractionDetails { get; set; }

        /// <summary>Details of label video classification operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoClassificationDetails")]
        public virtual GoogleCloudDatalabelingV1alpha1LabelVideoClassificationOperationMetadata VideoClassificationDetails { get; set; }

        /// <summary>Details of label video event operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoEventDetails")]
        public virtual GoogleCloudDatalabelingV1alpha1LabelVideoEventOperationMetadata VideoEventDetails { get; set; }

        /// <summary>Details of label video object detection operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoObjectDetectionDetails")]
        public virtual GoogleCloudDatalabelingV1alpha1LabelVideoObjectDetectionOperationMetadata VideoObjectDetectionDetails { get; set; }

        /// <summary>Details of label video object tracking operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoObjectTrackingDetails")]
        public virtual GoogleCloudDatalabelingV1alpha1LabelVideoObjectTrackingOperationMetadata VideoObjectTrackingDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Statistics about annotation specs.</summary>
    public class GoogleCloudDatalabelingV1alpha1LabelStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Map of each annotation spec's example count. Key is the annotation spec name and value is the
        /// number of examples for that annotation spec. If the annotated dataset does not have annotation spec, the map
        /// will return a pair where the key is empty string and value is the total number of annotations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exampleCount")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<long>> ExampleCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelTextClassification operation metadata.</summary>
    public class GoogleCloudDatalabelingV1alpha1LabelTextClassificationOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelTextEntityExtraction operation metadata.</summary>
    public class GoogleCloudDatalabelingV1alpha1LabelTextEntityExtractionOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelVideoClassification operation metadata.</summary>
    public class GoogleCloudDatalabelingV1alpha1LabelVideoClassificationOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelVideoEvent operation metadata.</summary>
    public class GoogleCloudDatalabelingV1alpha1LabelVideoEventOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelVideoObjectDetection operation metadata.</summary>
    public class GoogleCloudDatalabelingV1alpha1LabelVideoObjectDetectionOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelVideoObjectTracking operation metadata.</summary>
    public class GoogleCloudDatalabelingV1alpha1LabelVideoObjectTrackingOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The configuration of output data.</summary>
    public class GoogleCloudDatalabelingV1alpha1OutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output to a file in Cloud Storage. Should be used for labeling output other than image
        /// segmentation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual GoogleCloudDatalabelingV1alpha1GcsDestination GcsDestination { get; set; }

        /// <summary>Output to a folder in Cloud Storage. Should be used for image segmentation or document de-
        /// identification labeling outputs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsFolderDestination")]
        public virtual GoogleCloudDatalabelingV1alpha1GcsFolderDestination GcsFolderDestination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>AnnotatedDataset is a set holding annotations for data in a Dataset. Each labeling task will generate
    /// an AnnotatedDataset under the Dataset that the task is requested for.</summary>
    public class GoogleCloudDatalabelingV1beta1AnnotatedDataset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Source of the annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSource")]
        public virtual string AnnotationSource { get; set; }

        /// <summary>Output only. Type of the annotation. It is specified when starting labeling task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationType")]
        public virtual string AnnotationType { get; set; }

        /// <summary>Output only. The names of any related resources that are blocking changes to the annotated
        /// dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockingResources")]
        public virtual System.Collections.Generic.IList<string> BlockingResources { get; set; }

        /// <summary>Output only. Number of examples that have annotation in the annotated dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completedExampleCount")]
        public virtual System.Nullable<long> CompletedExampleCount { get; set; }

        /// <summary>Output only. Time the AnnotatedDataset was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The description of the AnnotatedDataset. It is specified in HumanAnnotationConfig when
        /// user starts a labeling task. Maximum of 10000 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. The display name of the AnnotatedDataset. It is specified in HumanAnnotationConfig
        /// when user starts a labeling task. Maximum of 64 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. Number of examples in the annotated dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exampleCount")]
        public virtual System.Nullable<long> ExampleCount { get; set; }

        /// <summary>Output only. Per label statistics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelStats")]
        public virtual GoogleCloudDatalabelingV1beta1LabelStats LabelStats { get; set; }

        /// <summary>Output only. Additional information about AnnotatedDataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual GoogleCloudDatalabelingV1beta1AnnotatedDatasetMetadata Metadata { get; set; }

        /// <summary>Output only. AnnotatedDataset resource name in format of:
        /// projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/ {annotated_dataset_id}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata on AnnotatedDataset.</summary>
    public class GoogleCloudDatalabelingV1beta1AnnotatedDatasetMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration for image bounding box and bounding poly task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPolyConfig")]
        public virtual GoogleCloudDatalabelingV1beta1BoundingPolyConfig BoundingPolyConfig { get; set; }

        /// <summary>Configuration for video event labeling task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventConfig")]
        public virtual GoogleCloudDatalabelingV1beta1EventConfig EventConfig { get; set; }

        /// <summary>HumanAnnotationConfig used when requesting the human labeling task for this
        /// AnnotatedDataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("humanAnnotationConfig")]
        public virtual GoogleCloudDatalabelingV1beta1HumanAnnotationConfig HumanAnnotationConfig { get; set; }

        /// <summary>Configuration for image classification task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageClassificationConfig")]
        public virtual GoogleCloudDatalabelingV1beta1ImageClassificationConfig ImageClassificationConfig { get; set; }

        /// <summary>Configuration for video object detection task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectDetectionConfig")]
        public virtual GoogleCloudDatalabelingV1beta1ObjectDetectionConfig ObjectDetectionConfig { get; set; }

        /// <summary>Configuration for video object tracking task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectTrackingConfig")]
        public virtual GoogleCloudDatalabelingV1beta1ObjectTrackingConfig ObjectTrackingConfig { get; set; }

        /// <summary>Configuration for image polyline task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("polylineConfig")]
        public virtual GoogleCloudDatalabelingV1beta1PolylineConfig PolylineConfig { get; set; }

        /// <summary>Configuration for image segmentation task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentationConfig")]
        public virtual GoogleCloudDatalabelingV1beta1SegmentationConfig SegmentationConfig { get; set; }

        /// <summary>Configuration for text classification task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textClassificationConfig")]
        public virtual GoogleCloudDatalabelingV1beta1TextClassificationConfig TextClassificationConfig { get; set; }

        /// <summary>Configuration for text entity extraction task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textEntityExtractionConfig")]
        public virtual GoogleCloudDatalabelingV1beta1TextEntityExtractionConfig TextEntityExtractionConfig { get; set; }

        /// <summary>Configuration for video classification task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoClassificationConfig")]
        public virtual GoogleCloudDatalabelingV1beta1VideoClassificationConfig VideoClassificationConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Annotation for Example. Each example may have one or more annotations. For example in image
    /// classification problem, each image might have one or more labels. We call labels binded with this image an
    /// Annotation.</summary>
    public class GoogleCloudDatalabelingV1beta1Annotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Annotation metadata, including information like votes for labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationMetadata")]
        public virtual GoogleCloudDatalabelingV1beta1AnnotationMetadata AnnotationMetadata { get; set; }

        /// <summary>Output only. Sentiment for this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSentiment")]
        public virtual string AnnotationSentiment { get; set; }

        /// <summary>Output only. The source of the annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSource")]
        public virtual string AnnotationSource { get; set; }

        /// <summary>Output only. This is the actual annotation value, e.g classification, bounding box values are
        /// stored here.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationValue")]
        public virtual GoogleCloudDatalabelingV1beta1AnnotationValue AnnotationValue { get; set; }

        /// <summary>Output only. Unique name of this annotation, format is: projects/{project_id}/datasets/{dataset_id}
        /// /annotatedDatasets/{annotated_dataset}/examples/{example_id}/annotations/{annotation_id}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Additional information associated with the annotation.</summary>
    public class GoogleCloudDatalabelingV1beta1AnnotationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata related to human labeling.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatorMetadata")]
        public virtual GoogleCloudDatalabelingV1beta1OperatorMetadata OperatorMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Container of information related to one possible annotation that can be used in a labeling task. For
    /// example, an image classification task where images are labeled as `dog` or `cat` must reference an
    /// AnnotationSpec for `dog` and an AnnotationSpec for `cat`.</summary>
    public class GoogleCloudDatalabelingV1beta1AnnotationSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. User-provided description of the annotation specification. The description can be up to
        /// 10,000 characters long.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. The display name of the AnnotationSpec. Maximum of 64 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. This is the integer index of the AnnotationSpec. The index for the whole
        /// AnnotationSpecSet is sequential starting from 0. For example, an AnnotationSpecSet with classes `dog` and
        /// `cat`, might contain one AnnotationSpec with `{ display_name: "dog", index: 0 }` and one AnnotationSpec with
        /// `{ display_name: "cat", index: 1 }`. This is especially useful for model training as it encodes the string
        /// labels into numeric values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An AnnotationSpecSet is a collection of label definitions. For example, in image classification tasks,
    /// you define a set of possible labels for images as an AnnotationSpecSet. An AnnotationSpecSet is immutable upon
    /// creation.</summary>
    public class GoogleCloudDatalabelingV1beta1AnnotationSpecSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The array of AnnotationSpecs that you define when you create the AnnotationSpecSet. These
        /// are the possible labels for the labeling task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpecs")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatalabelingV1beta1AnnotationSpec> AnnotationSpecs { get; set; }

        /// <summary>Output only. The names of any related resources that are blocking changes to the annotation spec
        /// set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockingResources")]
        public virtual System.Collections.Generic.IList<string> BlockingResources { get; set; }

        /// <summary>Optional. User-provided description of the annotation specification set. The description can be up
        /// to 10,000 characters long.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. The display name for AnnotationSpecSet that you define when you create it. Maximum of 64
        /// characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. The AnnotationSpecSet resource name in the following format:
        /// "projects/{project_id}/annotationSpecSets/{annotation_spec_set_id}"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Annotation spec set with the setting of allowing multi labels or not.</summary>
    public class GoogleCloudDatalabelingV1beta1AnnotationSpecSetConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If allow_multi_label is true, contributors are able to choose multiple labels from one
        /// annotation spec set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowMultiLabel")]
        public virtual System.Nullable<bool> AllowMultiLabel { get; set; }

        /// <summary>Required. Annotation spec set resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpecSet")]
        public virtual string AnnotationSpecSet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Annotation value for an example.</summary>
    public class GoogleCloudDatalabelingV1beta1AnnotationValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Annotation value for image bounding box, oriented bounding box and polygon cases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageBoundingPolyAnnotation")]
        public virtual GoogleCloudDatalabelingV1beta1ImageBoundingPolyAnnotation ImageBoundingPolyAnnotation { get; set; }

        /// <summary>Annotation value for image classification case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageClassificationAnnotation")]
        public virtual GoogleCloudDatalabelingV1beta1ImageClassificationAnnotation ImageClassificationAnnotation { get; set; }

        /// <summary>Annotation value for image polyline cases. Polyline here is different from BoundingPoly. It is
        /// formed by line segments connected to each other but not closed form(Bounding Poly). The line segments can
        /// cross each other.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imagePolylineAnnotation")]
        public virtual GoogleCloudDatalabelingV1beta1ImagePolylineAnnotation ImagePolylineAnnotation { get; set; }

        /// <summary>Annotation value for image segmentation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageSegmentationAnnotation")]
        public virtual GoogleCloudDatalabelingV1beta1ImageSegmentationAnnotation ImageSegmentationAnnotation { get; set; }

        /// <summary>Annotation value for text classification case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textClassificationAnnotation")]
        public virtual GoogleCloudDatalabelingV1beta1TextClassificationAnnotation TextClassificationAnnotation { get; set; }

        /// <summary>Annotation value for text entity extraction case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textEntityExtractionAnnotation")]
        public virtual GoogleCloudDatalabelingV1beta1TextEntityExtractionAnnotation TextEntityExtractionAnnotation { get; set; }

        /// <summary>Annotation value for video classification case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoClassificationAnnotation")]
        public virtual GoogleCloudDatalabelingV1beta1VideoClassificationAnnotation VideoClassificationAnnotation { get; set; }

        /// <summary>Annotation value for video event case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoEventAnnotation")]
        public virtual GoogleCloudDatalabelingV1beta1VideoEventAnnotation VideoEventAnnotation { get; set; }

        /// <summary>Annotation value for video object detection and tracking case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoObjectTrackingAnnotation")]
        public virtual GoogleCloudDatalabelingV1beta1VideoObjectTrackingAnnotation VideoObjectTrackingAnnotation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Records a failed evaluation job run.</summary>
    public class GoogleCloudDatalabelingV1beta1Attempt : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("attemptTime")]
        public virtual object AttemptTime { get; set; }

        /// <summary>Details of errors that occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialFailures")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> PartialFailures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The BigQuery location for input data. If used in an EvaluationJob, this is where the service saves the
    /// prediction input and output sampled from the model version.</summary>
    public class GoogleCloudDatalabelingV1beta1BigQuerySource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. BigQuery URI to a table, up to 2,000 characters long. If you specify the URI of a table
        /// that does not exist, Data Labeling Service creates a table at the URI with the correct schema when you
        /// create your EvaluationJob. If you specify the URI of a table that already exists, it must have the [correct
        /// schema](/ml-engine/docs/continuous-evaluation/create-job#table-schema). Provide the table URI in the
        /// following format: "bq://{your_project_id}/ {your_dataset_name}/{your_table_name}" [Learn more](/ml-
        /// engine/docs/continuous-evaluation/create-job#table-schema).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUri")]
        public virtual string InputUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Options regarding evaluation between bounding boxes.</summary>
    public class GoogleCloudDatalabelingV1beta1BoundingBoxEvaluationOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Minimum [intersection-over-union (IOU)](/vision/automl/object-detection/docs/evaluate#intersection-
        /// over-union) required for 2 bounding boxes to be considered a match. This must be a number between 0 and
        /// 1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iouThreshold")]
        public virtual System.Nullable<float> IouThreshold { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A bounding polygon in the image.</summary>
    public class GoogleCloudDatalabelingV1beta1BoundingPoly : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bounding polygon vertices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertices")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatalabelingV1beta1Vertex> Vertices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Config for image bounding poly (and bounding box) human labeling task.</summary>
    public class GoogleCloudDatalabelingV1beta1BoundingPolyConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Annotation spec set resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpecSet")]
        public virtual string AnnotationSpecSet { get; set; }

        /// <summary>Optional. Instruction message showed on contributors UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instructionMessage")]
        public virtual string InstructionMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata for classification annotations.</summary>
    public class GoogleCloudDatalabelingV1beta1ClassificationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the classification task is multi-label or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isMultiLabel")]
        public virtual System.Nullable<bool> IsMultiLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metrics calculated for a classification model.</summary>
    public class GoogleCloudDatalabelingV1beta1ClassificationMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Confusion matrix of predicted labels vs. ground truth labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confusionMatrix")]
        public virtual GoogleCloudDatalabelingV1beta1ConfusionMatrix ConfusionMatrix { get; set; }

        /// <summary>Precision-recall curve based on ground truth labels, predicted labels, and scores for the predicted
        /// labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prCurve")]
        public virtual GoogleCloudDatalabelingV1beta1PrCurve PrCurve { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class GoogleCloudDatalabelingV1beta1ConfidenceMetricsEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Threshold used for this entry. For classification tasks, this is a classification threshold: a
        /// predicted label is categorized as positive or negative (in the context of this point on the PR curve) based
        /// on whether the label's score meets this threshold. For image object detection (bounding box) tasks, this is
        /// the [intersection-over-union (IOU)](/vision/automl/object-detection/docs/evaluate#intersection-over-union)
        /// threshold for the context of this point on the PR curve.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidenceThreshold")]
        public virtual System.Nullable<float> ConfidenceThreshold { get; set; }

        /// <summary>Harmonic mean of recall and precision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("f1Score")]
        public virtual System.Nullable<float> F1Score { get; set; }

        /// <summary>The harmonic mean of recall_at1 and precision_at1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("f1ScoreAt1")]
        public virtual System.Nullable<float> F1ScoreAt1 { get; set; }

        /// <summary>The harmonic mean of recall_at5 and precision_at5.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("f1ScoreAt5")]
        public virtual System.Nullable<float> F1ScoreAt5 { get; set; }

        /// <summary>Precision value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precision")]
        public virtual System.Nullable<float> Precision { get; set; }

        /// <summary>Precision value for entries with label that has highest score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precisionAt1")]
        public virtual System.Nullable<float> PrecisionAt1 { get; set; }

        /// <summary>Precision value for entries with label that has highest 5 scores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precisionAt5")]
        public virtual System.Nullable<float> PrecisionAt5 { get; set; }

        /// <summary>Recall value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recall")]
        public virtual System.Nullable<float> Recall { get; set; }

        /// <summary>Recall value for entries with label that has highest score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recallAt1")]
        public virtual System.Nullable<float> RecallAt1 { get; set; }

        /// <summary>Recall value for entries with label that has highest 5 scores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recallAt5")]
        public virtual System.Nullable<float> RecallAt5 { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Confusion matrix of the model running the classification. Only applicable when the metrics entry
    /// aggregates multiple labels. Not applicable when the entry is for a single label.</summary>
    public class GoogleCloudDatalabelingV1beta1ConfusionMatrix : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("row")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatalabelingV1beta1Row> Row { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class GoogleCloudDatalabelingV1beta1ConfusionMatrixEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The annotation spec of a predicted label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpec")]
        public virtual GoogleCloudDatalabelingV1beta1AnnotationSpec AnnotationSpec { get; set; }

        /// <summary>Number of items predicted to have this label. (The ground truth label for these items is the
        /// `Row.annotationSpec` of this entry's parent.)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemCount")]
        public virtual System.Nullable<int> ItemCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for CreateAnnotationSpecSet.</summary>
    public class GoogleCloudDatalabelingV1beta1CreateAnnotationSpecSetRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Annotation spec set to create. Annotation specs must be included. Only one annotation
        /// spec will be accepted for annotation specs with same display_name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpecSet")]
        public virtual GoogleCloudDatalabelingV1beta1AnnotationSpecSet AnnotationSpecSet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for CreateDataset.</summary>
    public class GoogleCloudDatalabelingV1beta1CreateDatasetRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The dataset to be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual GoogleCloudDatalabelingV1beta1Dataset Dataset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for CreateEvaluationJob.</summary>
    public class GoogleCloudDatalabelingV1beta1CreateEvaluationJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The evaluation job to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("job")]
        public virtual GoogleCloudDatalabelingV1beta1EvaluationJob Job { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata of a CreateInstruction operation.</summary>
    public class GoogleCloudDatalabelingV1beta1CreateInstructionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Timestamp when create instruction request was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The name of the created Instruction. projects/{project_id}/instructions/{instruction_id}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instruction")]
        public virtual string Instruction { get; set; }

        /// <summary>Partial failures encountered. E.g. single files that couldn't be read. Status details field will
        /// contain standard GCP error details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialFailures")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> PartialFailures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for CreateInstruction.</summary>
    public class GoogleCloudDatalabelingV1beta1CreateInstructionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Instruction of how to perform the labeling task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instruction")]
        public virtual GoogleCloudDatalabelingV1beta1Instruction Instruction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Deprecated: this instruction format is not supported any more. Instruction from a CSV file.</summary>
    public class GoogleCloudDatalabelingV1beta1CsvInstruction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>CSV file for the instruction. Only gcs path is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsFileUri")]
        public virtual string GcsFileUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>DataItem is a piece of data, without annotation. For example, an image.</summary>
    public class GoogleCloudDatalabelingV1beta1DataItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The image payload, a container of the image bytes/uri.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imagePayload")]
        public virtual GoogleCloudDatalabelingV1beta1ImagePayload ImagePayload { get; set; }

        /// <summary>Output only. Name of the data item, in format of:
        /// projects/{project_id}/datasets/{dataset_id}/dataItems/{data_item_id}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The text payload, a container of text content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textPayload")]
        public virtual GoogleCloudDatalabelingV1beta1TextPayload TextPayload { get; set; }

        /// <summary>The video payload, a container of the video uri.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoPayload")]
        public virtual GoogleCloudDatalabelingV1beta1VideoPayload VideoPayload { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Dataset is the resource to hold your data. You can request multiple labeling tasks for a dataset while
    /// each one will generate an AnnotatedDataset.</summary>
    public class GoogleCloudDatalabelingV1beta1Dataset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The names of any related resources that are blocking changes to the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockingResources")]
        public virtual System.Collections.Generic.IList<string> BlockingResources { get; set; }

        /// <summary>Output only. Time the dataset is created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The number of data items in the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataItemCount")]
        public virtual System.Nullable<long> DataItemCount { get; set; }

        /// <summary>Optional. User-provided description of the annotation specification set. The description can be up
        /// to 10000 characters long.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. The display name of the dataset. Maximum of 64 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. This is populated with the original input configs where ImportData is called. It is
        /// available only after the clients import data to this dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfigs")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatalabelingV1beta1InputConfig> InputConfigs { get; set; }

        /// <summary>Last time that the Dataset is migrated to AI Platform V2. If any of the AnnotatedDataset is
        /// migrated, the last_migration_time in Dataset is also updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastMigrateTime")]
        public virtual object LastMigrateTime { get; set; }

        /// <summary>Output only. Dataset resource name, format is:
        /// projects/{project_id}/datasets/{dataset_id}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Describes an evaluation between a machine learning model's predictions and ground truth labels. Created
    /// when an EvaluationJob runs successfully.</summary>
    public class GoogleCloudDatalabelingV1beta1Evaluation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Type of task that the model version being evaluated performs, as defined in the
        /// evaluationJobConfig.inputConfig.annotationType field of the evaluation job that created this
        /// evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationType")]
        public virtual string AnnotationType { get; set; }

        /// <summary>Output only. Options used in the evaluation job that created this evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual GoogleCloudDatalabelingV1beta1EvaluationConfig Config { get; set; }

        /// <summary>Output only. Timestamp for when this evaluation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The number of items in the ground truth dataset that were used for this evaluation.
        /// Only populated when the evaulation is for certain AnnotationTypes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluatedItemCount")]
        public virtual System.Nullable<long> EvaluatedItemCount { get; set; }

        /// <summary>Output only. Timestamp for when the evaluation job that created this evaluation ran.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationJobRunTime")]
        public virtual object EvaluationJobRunTime { get; set; }

        /// <summary>Output only. Metrics comparing predictions to ground truth labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationMetrics")]
        public virtual GoogleCloudDatalabelingV1beta1EvaluationMetrics EvaluationMetrics { get; set; }

        /// <summary>Output only. Resource name of an evaluation. The name has the following format:
        /// "projects/{project_id}/datasets/{dataset_id}/evaluations/ {evaluation_id}'</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Configuration details used for calculating evaluation metrics and creating an Evaluation.</summary>
    public class GoogleCloudDatalabelingV1beta1EvaluationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Only specify this field if the related model performs image object detection
        /// (`IMAGE_BOUNDING_BOX_ANNOTATION`). Describes how to evaluate bounding boxes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBoxEvaluationOptions")]
        public virtual GoogleCloudDatalabelingV1beta1BoundingBoxEvaluationOptions BoundingBoxEvaluationOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Defines an evaluation job that runs periodically to generate Evaluations. [Creating an evaluation job
    /// ](/ml-engine/docs/continuous-evaluation/create-job) is the starting point for using continuous
    /// evaluation.</summary>
    public class GoogleCloudDatalabelingV1beta1EvaluationJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Name of the AnnotationSpecSet describing all the labels that your machine learning model
        /// outputs. You must create this resource before you create an evaluation job and provide its name in the
        /// following format: "projects/{project_id}/annotationSpecSets/{annotation_spec_set_id}"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpecSet")]
        public virtual string AnnotationSpecSet { get; set; }

        /// <summary>Output only. Every time the evaluation job runs and an error occurs, the failed attempt is appended
        /// to this array.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attempts")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatalabelingV1beta1Attempt> Attempts { get; set; }

        /// <summary>Output only. Timestamp of when this evaluation job was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Required. Description of the job. The description can be up to 25,000 characters long.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. Configuration details for the evaluation job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationJobConfig")]
        public virtual GoogleCloudDatalabelingV1beta1EvaluationJobConfig EvaluationJobConfig { get; set; }

        /// <summary>Required. Whether you want Data Labeling Service to provide ground truth labels for prediction
        /// input. If you want the service to assign human labelers to annotate your data, set this to `true`. If you
        /// want to provide your own ground truth labels in the evaluation job's BigQuery table, set this to
        /// `false`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelMissingGroundTruth")]
        public virtual System.Nullable<bool> LabelMissingGroundTruth { get; set; }

        /// <summary>Required. The [AI Platform Prediction model version](/ml-engine/docs/prediction-overview) to be
        /// evaluated. Prediction input and output is sampled from this model version. When creating an evaluation job,
        /// specify the model version in the following format:
        /// "projects/{project_id}/models/{model_name}/versions/{version_name}" There can only be one evaluation job per
        /// model version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelVersion")]
        public virtual string ModelVersion { get; set; }

        /// <summary>Output only. After you create a job, Data Labeling Service assigns a name to the job with the
        /// following format: "projects/{project_id}/evaluationJobs/ {evaluation_job_id}"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Describes the interval at which the job runs. This interval must be at least 1 day, and
        /// it is rounded to the nearest day. For example, if you specify a 50-hour interval, the job runs every 2 days.
        /// You can provide the schedule in [crontab format](/scheduler/docs/configuring/cron-job-schedules) or in an
        /// [English-like format](/appengine/docs/standard/python/config/cronref#schedule_format). Regardless of what
        /// you specify, the job will run at 10:00 AM UTC. Only the interval from this schedule is used, not the
        /// specific time of day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedule")]
        public virtual string Schedule { get; set; }

        /// <summary>Output only. Describes the current state of the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Provides details for how an evaluation job sends email alerts based on the results of a run.</summary>
    public class GoogleCloudDatalabelingV1beta1EvaluationJobAlertConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. An email address to send alerts to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>Required. A number between 0 and 1 that describes a minimum mean average precision threshold. When
        /// the evaluation job runs, if it calculates that your model version's predictions from the recent interval
        /// have meanAveragePrecision below this threshold, then it sends an alert to your specified email.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minAcceptableMeanAveragePrecision")]
        public virtual System.Nullable<double> MinAcceptableMeanAveragePrecision { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Configures specific details of how a continuous evaluation job works. Provide this configuration when
    /// you create an EvaluationJob.</summary>
    public class GoogleCloudDatalabelingV1beta1EvaluationJobConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Prediction keys that tell Data Labeling Service where to find the data for evaluation in
        /// your BigQuery table. When the service samples prediction input and output from your model version and saves
        /// it to BigQuery, the data gets stored as JSON strings in the BigQuery table. These keys tell Data Labeling
        /// Service how to parse the JSON. You can provide the following entries in this field: * `data_json_key`: the
        /// data key for prediction input. You must provide either this key or `reference_json_key`. *
        /// `reference_json_key`: the data reference key for prediction input. You must provide either this key or
        /// `data_json_key`. * `label_json_key`: the label key for prediction output. Required. *
        /// `label_score_json_key`: the score key for prediction output. Required. * `bounding_box_json_key`: the
        /// bounding box key for prediction output. Required if your model version perform image object detection. Learn
        /// [how to configure prediction keys](/ml-engine/docs/continuous-evaluation/create-job#prediction-
        /// keys).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryImportKeys")]
        public virtual System.Collections.Generic.IDictionary<string, string> BigqueryImportKeys { get; set; }

        /// <summary>Specify this field if your model version performs image object detection (bounding box detection).
        /// `annotationSpecSet` in this configuration must match EvaluationJob.annotationSpecSet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPolyConfig")]
        public virtual GoogleCloudDatalabelingV1beta1BoundingPolyConfig BoundingPolyConfig { get; set; }

        /// <summary>Required. Details for calculating evaluation metrics and creating Evaulations. If your model
        /// version performs image object detection, you must specify the `boundingBoxEvaluationOptions` field within
        /// this configuration. Otherwise, provide an empty object for this configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationConfig")]
        public virtual GoogleCloudDatalabelingV1beta1EvaluationConfig EvaluationConfig { get; set; }

        /// <summary>Optional. Configuration details for evaluation job alerts. Specify this field if you want to
        /// receive email alerts if the evaluation job finds that your predictions have low mean average precision
        /// during a run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationJobAlertConfig")]
        public virtual GoogleCloudDatalabelingV1beta1EvaluationJobAlertConfig EvaluationJobAlertConfig { get; set; }

        /// <summary>Required. The maximum number of predictions to sample and save to BigQuery during each evaluation
        /// interval. This limit overrides `example_sample_percentage`: even if the service has not sampled enough
        /// predictions to fulfill `example_sample_perecentage` during an interval, it stops sampling predictions when
        /// it meets this limit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exampleCount")]
        public virtual System.Nullable<int> ExampleCount { get; set; }

        /// <summary>Required. Fraction of predictions to sample and save to BigQuery during each evaluation interval.
        /// For example, 0.1 means 10% of predictions served by your model version get saved to BigQuery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exampleSamplePercentage")]
        public virtual System.Nullable<double> ExampleSamplePercentage { get; set; }

        /// <summary>Optional. Details for human annotation of your data. If you set labelMissingGroundTruth to `true`
        /// for this evaluation job, then you must specify this field. If you plan to provide your own ground truth
        /// labels, then omit this field. Note that you must create an Instruction resource before you can specify this
        /// field. Provide the name of the instruction resource in the `instruction` field within this
        /// configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("humanAnnotationConfig")]
        public virtual GoogleCloudDatalabelingV1beta1HumanAnnotationConfig HumanAnnotationConfig { get; set; }

        /// <summary>Specify this field if your model version performs image classification or general classification.
        /// `annotationSpecSet` in this configuration must match EvaluationJob.annotationSpecSet. `allowMultiLabel` in
        /// this configuration must match `classificationMetadata.isMultiLabel` in input_config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageClassificationConfig")]
        public virtual GoogleCloudDatalabelingV1beta1ImageClassificationConfig ImageClassificationConfig { get; set; }

        /// <summary>Rquired. Details for the sampled prediction input. Within this configuration, there are
        /// requirements for several fields: * `dataType` must be one of `IMAGE`, `TEXT`, or `GENERAL_DATA`. *
        /// `annotationType` must be one of `IMAGE_CLASSIFICATION_ANNOTATION`, `TEXT_CLASSIFICATION_ANNOTATION`,
        /// `GENERAL_CLASSIFICATION_ANNOTATION`, or `IMAGE_BOUNDING_BOX_ANNOTATION` (image object detection). * If your
        /// machine learning model performs classification, you must specify `classificationMetadata.isMultiLabel`. *
        /// You must specify `bigquerySource` (not `gcsSource`).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfig")]
        public virtual GoogleCloudDatalabelingV1beta1InputConfig InputConfig { get; set; }

        /// <summary>Specify this field if your model version performs text classification. `annotationSpecSet` in this
        /// configuration must match EvaluationJob.annotationSpecSet. `allowMultiLabel` in this configuration must match
        /// `classificationMetadata.isMultiLabel` in input_config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textClassificationConfig")]
        public virtual GoogleCloudDatalabelingV1beta1TextClassificationConfig TextClassificationConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class GoogleCloudDatalabelingV1beta1EvaluationMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("classificationMetrics")]
        public virtual GoogleCloudDatalabelingV1beta1ClassificationMetrics ClassificationMetrics { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("objectDetectionMetrics")]
        public virtual GoogleCloudDatalabelingV1beta1ObjectDetectionMetrics ObjectDetectionMetrics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Config for video event human labeling task.</summary>
    public class GoogleCloudDatalabelingV1beta1EventConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The list of annotation spec set resource name. Similar to video classification, we
        /// support selecting event from multiple AnnotationSpecSet at the same time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpecSets")]
        public virtual System.Collections.Generic.IList<string> AnnotationSpecSets { get; set; }

        /// <summary>Videos will be cut to smaller clips to make it easier for labelers to work on. Users can configure
        /// is field in seconds, if not set, default value is 60s.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clipLength")]
        public virtual System.Nullable<int> ClipLength { get; set; }

        /// <summary>The overlap length between different video clips. Users can configure is field in seconds, if not
        /// set, default value is 1s.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overlapLength")]
        public virtual System.Nullable<int> OverlapLength { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An Example is a piece of data and its annotation. For example, an image with label "house".</summary>
    public class GoogleCloudDatalabelingV1beta1Example : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Annotations for the piece of data in Example. One piece of data can have multiple
        /// annotations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatalabelingV1beta1Annotation> Annotations { get; set; }

        /// <summary>The image payload, a container of the image bytes/uri.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imagePayload")]
        public virtual GoogleCloudDatalabelingV1beta1ImagePayload ImagePayload { get; set; }

        /// <summary>Output only. Name of the example, in format of:
        /// projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/
        /// {annotated_dataset_id}/examples/{example_id}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The text payload, a container of the text content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textPayload")]
        public virtual GoogleCloudDatalabelingV1beta1TextPayload TextPayload { get; set; }

        /// <summary>The video payload, a container of the video uri.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoPayload")]
        public virtual GoogleCloudDatalabelingV1beta1VideoPayload VideoPayload { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Example comparisons comparing ground truth output and predictions for a specific input.</summary>
    public class GoogleCloudDatalabelingV1beta1ExampleComparison : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ground truth output for the input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groundTruthExample")]
        public virtual GoogleCloudDatalabelingV1beta1Example GroundTruthExample { get; set; }

        /// <summary>Predictions by the model for the input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelCreatedExamples")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatalabelingV1beta1Example> ModelCreatedExamples { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata of an ExportData operation.</summary>
    public class GoogleCloudDatalabelingV1beta1ExportDataOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The name of annotated dataset in format
        /// "projects/datasets/annotatedDatasets".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedDataset")]
        public virtual string AnnotatedDataset { get; set; }

        /// <summary>Output only. Timestamp when export dataset request was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The name of dataset to be exported. "projects/datasets"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>Output only. Partial failures encountered. E.g. single files that couldn't be read. Status details
        /// field will contain standard GCP error details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialFailures")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> PartialFailures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response used for ExportDataset longrunning operation.</summary>
    public class GoogleCloudDatalabelingV1beta1ExportDataOperationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The name of annotated dataset in format
        /// "projects/datasets/annotatedDatasets".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedDataset")]
        public virtual string AnnotatedDataset { get; set; }

        /// <summary>Ouptut only. The name of dataset. "projects/datasets"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>Output only. Number of examples exported successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportCount")]
        public virtual System.Nullable<int> ExportCount { get; set; }

        /// <summary>Output only. Statistic infos of labels in the exported dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelStats")]
        public virtual GoogleCloudDatalabelingV1beta1LabelStats LabelStats { get; set; }

        /// <summary>Output only. output_config in the ExportData request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual GoogleCloudDatalabelingV1beta1OutputConfig OutputConfig { get; set; }

        /// <summary>Output only. Total number of examples requested to export</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalCount")]
        public virtual System.Nullable<int> TotalCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for ExportData API.</summary>
    public class GoogleCloudDatalabelingV1beta1ExportDataRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Annotated dataset resource name. DataItem in Dataset and their annotations in specified
        /// annotated dataset will be exported. It's in format of
        /// projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/ {annotated_dataset_id}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedDataset")]
        public virtual string AnnotatedDataset { get; set; }

        /// <summary>Optional. Filter is not supported at this moment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>Required. Specify the output destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual GoogleCloudDatalabelingV1beta1OutputConfig OutputConfig { get; set; }

        /// <summary>Email of the user who started the export task and should be notified by email. If empty no
        /// notification will be sent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEmailAddress")]
        public virtual string UserEmailAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A feedback message inside a feedback thread.</summary>
    public class GoogleCloudDatalabelingV1beta1FeedbackMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>String content of the feedback. Maximum of 10000 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual string Body { get; set; }

        /// <summary>Create time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The image storing this feedback if the feedback is an image representing operator's
        /// comments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual string Image { get; set; }

        /// <summary>Name of the feedback message in a feedback thread. Format: 'project/{project_id}/datasets/{dataset_
        /// id}/annotatedDatasets/{annotated_dataset_id}/feedbackThreads/{feedback_thread_id}/feedbackMessage/{feedback_
        /// message_id}'</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("operatorFeedbackMetadata")]
        public virtual GoogleCloudDatalabelingV1beta1OperatorFeedbackMetadata OperatorFeedbackMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("requesterFeedbackMetadata")]
        public virtual GoogleCloudDatalabelingV1beta1RequesterFeedbackMetadata RequesterFeedbackMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A feedback thread of a certain labeling task on a certain annotated dataset.</summary>
    public class GoogleCloudDatalabelingV1beta1FeedbackThread : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata regarding the feedback thread.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedbackThreadMetadata")]
        public virtual GoogleCloudDatalabelingV1beta1FeedbackThreadMetadata FeedbackThreadMetadata { get; set; }

        /// <summary>Name of the feedback thread. Format: 'project/{project_id}/datasets/{dataset_id}/annotatedDatasets/
        /// {annotated_dataset_id}/feedbackThreads/{feedback_thread_id}'</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class GoogleCloudDatalabelingV1beta1FeedbackThreadMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>When the thread is created</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>When the thread is last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateTime")]
        public virtual object LastUpdateTime { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>An image thumbnail of this thread.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnail")]
        public virtual string Thumbnail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Export destination of the data.Only gcs path is allowed in output_uri.</summary>
    public class GoogleCloudDatalabelingV1beta1GcsDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The format of the gcs destination. Only "text/csv" and "application/json" are
        /// supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>Required. The output uri of destination file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputUri")]
        public virtual string OutputUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Export folder destination of the data.</summary>
    public class GoogleCloudDatalabelingV1beta1GcsFolderDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Cloud Storage directory to export data to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputFolderUri")]
        public virtual string OutputFolderUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Source of the Cloud Storage file to be imported.</summary>
    public class GoogleCloudDatalabelingV1beta1GcsSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The input URI of source file. This must be a Cloud Storage path (`gs://...`).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUri")]
        public virtual string InputUri { get; set; }

        /// <summary>Required. The format of the source file. Only "text/csv" is supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Configuration for how human labeling task should be done.</summary>
    public class GoogleCloudDatalabelingV1beta1HumanAnnotationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A human-readable description for AnnotatedDataset. The description can be up to 10000
        /// characters long.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedDatasetDescription")]
        public virtual string AnnotatedDatasetDescription { get; set; }

        /// <summary>Required. A human-readable name for AnnotatedDataset defined by users. Maximum of 64 characters
        /// .</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedDatasetDisplayName")]
        public virtual string AnnotatedDatasetDisplayName { get; set; }

        /// <summary>Optional. If you want your own labeling contributors to manage and work on this labeling request,
        /// you can set these contributors here. We will give them access to the question types in crowdcompute. Note
        /// that these emails must be registered in crowdcompute worker UI: https://crowd-compute.appspot.com/</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contributorEmails")]
        public virtual System.Collections.Generic.IList<string> ContributorEmails { get; set; }

        /// <summary>Required. Instruction resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instruction")]
        public virtual string Instruction { get; set; }

        /// <summary>Optional. A human-readable label used to logically group labeling tasks. This string must match the
        /// regular expression `[a-zA-Z\\d_-]{0,128}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelGroup")]
        public virtual string LabelGroup { get; set; }

        /// <summary>Optional. The Language of this question, as a [BCP-47](https://www.rfc-
        /// editor.org/rfc/bcp/bcp47.txt). Default value is en-US. Only need to set this when task is language related.
        /// For example, French text classification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Optional. Maximum duration for contributors to answer a question. Maximum is 3600 seconds. Default
        /// is 3600 seconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("questionDuration")]
        public virtual object QuestionDuration { get; set; }

        /// <summary>Optional. Replication of questions. Each question will be sent to up to this number of contributors
        /// to label. Aggregated answers will be returned. Default is set to 1. For image related labeling, valid values
        /// are 1, 3, 5.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicaCount")]
        public virtual System.Nullable<int> ReplicaCount { get; set; }

        /// <summary>Email of the user who started the labeling task and should be notified by email. If empty no
        /// notification will be sent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEmailAddress")]
        public virtual string UserEmailAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Image bounding poly annotation. It represents a polygon including bounding box in the image.</summary>
    public class GoogleCloudDatalabelingV1beta1ImageBoundingPolyAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label of object in this bounding polygon.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpec")]
        public virtual GoogleCloudDatalabelingV1beta1AnnotationSpec AnnotationSpec { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudDatalabelingV1beta1BoundingPoly BoundingPoly { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("normalizedBoundingPoly")]
        public virtual GoogleCloudDatalabelingV1beta1NormalizedBoundingPoly NormalizedBoundingPoly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Image classification annotation definition.</summary>
    public class GoogleCloudDatalabelingV1beta1ImageClassificationAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label of image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpec")]
        public virtual GoogleCloudDatalabelingV1beta1AnnotationSpec AnnotationSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Config for image classification human labeling task.</summary>
    public class GoogleCloudDatalabelingV1beta1ImageClassificationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If allow_multi_label is true, contributors are able to choose multiple labels for one
        /// image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowMultiLabel")]
        public virtual System.Nullable<bool> AllowMultiLabel { get; set; }

        /// <summary>Required. Annotation spec set resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpecSet")]
        public virtual string AnnotationSpecSet { get; set; }

        /// <summary>Optional. The type of how to aggregate answers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("answerAggregationType")]
        public virtual string AnswerAggregationType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Container of information about an image.</summary>
    public class GoogleCloudDatalabelingV1beta1ImagePayload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A byte string of a thumbnail image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageThumbnail")]
        public virtual string ImageThumbnail { get; set; }

        /// <summary>Image uri from the user bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; }

        /// <summary>Image format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>Signed uri of the image file in the service bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signedUri")]
        public virtual string SignedUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A polyline for the image annotation.</summary>
    public class GoogleCloudDatalabelingV1beta1ImagePolylineAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label of this polyline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpec")]
        public virtual GoogleCloudDatalabelingV1beta1AnnotationSpec AnnotationSpec { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("normalizedPolyline")]
        public virtual GoogleCloudDatalabelingV1beta1NormalizedPolyline NormalizedPolyline { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("polyline")]
        public virtual GoogleCloudDatalabelingV1beta1Polyline Polyline { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Image segmentation annotation.</summary>
    public class GoogleCloudDatalabelingV1beta1ImageSegmentationAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The mapping between rgb color and annotation spec. The key is the rgb color represented in format
        /// of rgb(0, 0, 0). The value is the AnnotationSpec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationColors")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudDatalabelingV1beta1AnnotationSpec> AnnotationColors { get; set; }

        /// <summary>A byte string of a full image's color map.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageBytes")]
        public virtual string ImageBytes { get; set; }

        /// <summary>Image format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata of an ImportData operation.</summary>
    public class GoogleCloudDatalabelingV1beta1ImportDataOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Timestamp when import dataset request was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The name of imported dataset. "projects/datasets"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>Output only. Partial failures encountered. E.g. single files that couldn't be read. Status details
        /// field will contain standard GCP error details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialFailures")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> PartialFailures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response used for ImportData longrunning operation.</summary>
    public class GoogleCloudDatalabelingV1beta1ImportDataOperationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Ouptut only. The name of imported dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>Output only. Number of examples imported successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importCount")]
        public virtual System.Nullable<int> ImportCount { get; set; }

        /// <summary>Output only. Total number of examples requested to import</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalCount")]
        public virtual System.Nullable<int> TotalCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for ImportData API.</summary>
    public class GoogleCloudDatalabelingV1beta1ImportDataRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Specify the input source of the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfig")]
        public virtual GoogleCloudDatalabelingV1beta1InputConfig InputConfig { get; set; }

        /// <summary>Email of the user who started the import task and should be notified by email. If empty no
        /// notification will be sent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEmailAddress")]
        public virtual string UserEmailAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The configuration of input data, including data type, location, etc.</summary>
    public class GoogleCloudDatalabelingV1beta1InputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The type of annotation to be performed on this data. You must specify this field if you
        /// are using this InputConfig in an EvaluationJob.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationType")]
        public virtual string AnnotationType { get; set; }

        /// <summary>Source located in BigQuery. You must specify this field if you are using this InputConfig in an
        /// EvaluationJob.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigquerySource")]
        public virtual GoogleCloudDatalabelingV1beta1BigQuerySource BigquerySource { get; set; }

        /// <summary>Optional. Metadata about annotations for the input. You must specify this field if you are using
        /// this InputConfig in an EvaluationJob for a model version that performs classification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classificationMetadata")]
        public virtual GoogleCloudDatalabelingV1beta1ClassificationMetadata ClassificationMetadata { get; set; }

        /// <summary>Required. Data type must be specifed when user tries to import data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>Source located in Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GoogleCloudDatalabelingV1beta1GcsSource GcsSource { get; set; }

        /// <summary>Required for text import, as language code must be specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textMetadata")]
        public virtual GoogleCloudDatalabelingV1beta1TextMetadata TextMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Instruction of how to perform the labeling task for human operators. Currently only PDF instruction is
    /// supported.</summary>
    public class GoogleCloudDatalabelingV1beta1Instruction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The names of any related resources that are blocking changes to the
        /// instruction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockingResources")]
        public virtual System.Collections.Generic.IList<string> BlockingResources { get; set; }

        /// <summary>Output only. Creation time of instruction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Deprecated: this instruction format is not supported any more. Instruction from a CSV file, such as
        /// for classification task. The CSV file should have exact two columns, in the following format: * The first
        /// column is labeled data, such as an image reference, text. * The second column is comma separated labels
        /// associated with data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("csvInstruction")]
        public virtual GoogleCloudDatalabelingV1beta1CsvInstruction CsvInstruction { get; set; }

        /// <summary>Required. The data type of this instruction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>Optional. User-provided description of the instruction. The description can be up to 10000
        /// characters long.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. The display name of the instruction. Maximum of 64 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. Instruction resource name, format:
        /// projects/{project_id}/instructions/{instruction_id}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Instruction from a PDF document. The PDF should be in a Cloud Storage bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pdfInstruction")]
        public virtual GoogleCloudDatalabelingV1beta1PdfInstruction PdfInstruction { get; set; }

        /// <summary>Output only. Last update time of instruction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelImageBoundingBox operation metadata.</summary>
    public class GoogleCloudDatalabelingV1beta1LabelImageBoundingBoxOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1beta1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of LabelImageBoundingPoly operation metadata.</summary>
    public class GoogleCloudDatalabelingV1beta1LabelImageBoundingPolyOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1beta1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata of a LabelImageClassification operation.</summary>
    public class GoogleCloudDatalabelingV1beta1LabelImageClassificationOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1beta1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelImageOrientedBoundingBox operation metadata.</summary>
    public class GoogleCloudDatalabelingV1beta1LabelImageOrientedBoundingBoxOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1beta1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of LabelImagePolyline operation metadata.</summary>
    public class GoogleCloudDatalabelingV1beta1LabelImagePolylineOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1beta1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for starting an image labeling task.</summary>
    public class GoogleCloudDatalabelingV1beta1LabelImageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Basic human annotation config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1beta1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>Configuration for bounding box and bounding poly task. One of image_classification_config,
        /// bounding_poly_config, polyline_config and segmentation_config are required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPolyConfig")]
        public virtual GoogleCloudDatalabelingV1beta1BoundingPolyConfig BoundingPolyConfig { get; set; }

        /// <summary>Required. The type of image labeling task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feature")]
        public virtual string Feature { get; set; }

        /// <summary>Configuration for image classification task. One of image_classification_config,
        /// bounding_poly_config, polyline_config and segmentation_config are required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageClassificationConfig")]
        public virtual GoogleCloudDatalabelingV1beta1ImageClassificationConfig ImageClassificationConfig { get; set; }

        /// <summary>Configuration for polyline task. One of image_classification_config, bounding_poly_config,
        /// polyline_config and segmentation_config are required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("polylineConfig")]
        public virtual GoogleCloudDatalabelingV1beta1PolylineConfig PolylineConfig { get; set; }

        /// <summary>Configuration for segmentation task. One of image_classification_config, bounding_poly_config,
        /// polyline_config and segmentation_config are required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentationConfig")]
        public virtual GoogleCloudDatalabelingV1beta1SegmentationConfig SegmentationConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelImageSegmentation operation metadata.</summary>
    public class GoogleCloudDatalabelingV1beta1LabelImageSegmentationOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1beta1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata of a labeling operation, such as LabelImage or LabelVideo. Next tag: 23</summary>
    public class GoogleCloudDatalabelingV1beta1LabelOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The name of annotated dataset in format
        /// "projects/datasets/annotatedDatasets".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedDataset")]
        public virtual string AnnotatedDataset { get; set; }

        /// <summary>Output only. Timestamp when labeling request was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The name of dataset to be labeled. "projects/datasets"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>Details of label image bounding box operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageBoundingBoxDetails")]
        public virtual GoogleCloudDatalabelingV1beta1LabelImageBoundingBoxOperationMetadata ImageBoundingBoxDetails { get; set; }

        /// <summary>Details of label image bounding poly operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageBoundingPolyDetails")]
        public virtual GoogleCloudDatalabelingV1beta1LabelImageBoundingPolyOperationMetadata ImageBoundingPolyDetails { get; set; }

        /// <summary>Details of label image classification operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageClassificationDetails")]
        public virtual GoogleCloudDatalabelingV1beta1LabelImageClassificationOperationMetadata ImageClassificationDetails { get; set; }

        /// <summary>Details of label image oriented bounding box operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageOrientedBoundingBoxDetails")]
        public virtual GoogleCloudDatalabelingV1beta1LabelImageOrientedBoundingBoxOperationMetadata ImageOrientedBoundingBoxDetails { get; set; }

        /// <summary>Details of label image polyline operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imagePolylineDetails")]
        public virtual GoogleCloudDatalabelingV1beta1LabelImagePolylineOperationMetadata ImagePolylineDetails { get; set; }

        /// <summary>Details of label image segmentation operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageSegmentationDetails")]
        public virtual GoogleCloudDatalabelingV1beta1LabelImageSegmentationOperationMetadata ImageSegmentationDetails { get; set; }

        /// <summary>Output only. Partial failures encountered. E.g. single files that couldn't be read. Status details
        /// field will contain standard GCP error details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialFailures")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> PartialFailures { get; set; }

        /// <summary>Output only. Progress of label operation. Range: [0, 100].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressPercent")]
        public virtual System.Nullable<int> ProgressPercent { get; set; }

        /// <summary>Details of label text classification operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textClassificationDetails")]
        public virtual GoogleCloudDatalabelingV1beta1LabelTextClassificationOperationMetadata TextClassificationDetails { get; set; }

        /// <summary>Details of label text entity extraction operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textEntityExtractionDetails")]
        public virtual GoogleCloudDatalabelingV1beta1LabelTextEntityExtractionOperationMetadata TextEntityExtractionDetails { get; set; }

        /// <summary>Details of label video classification operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoClassificationDetails")]
        public virtual GoogleCloudDatalabelingV1beta1LabelVideoClassificationOperationMetadata VideoClassificationDetails { get; set; }

        /// <summary>Details of label video event operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoEventDetails")]
        public virtual GoogleCloudDatalabelingV1beta1LabelVideoEventOperationMetadata VideoEventDetails { get; set; }

        /// <summary>Details of label video object detection operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoObjectDetectionDetails")]
        public virtual GoogleCloudDatalabelingV1beta1LabelVideoObjectDetectionOperationMetadata VideoObjectDetectionDetails { get; set; }

        /// <summary>Details of label video object tracking operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoObjectTrackingDetails")]
        public virtual GoogleCloudDatalabelingV1beta1LabelVideoObjectTrackingOperationMetadata VideoObjectTrackingDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Statistics about annotation specs.</summary>
    public class GoogleCloudDatalabelingV1beta1LabelStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Map of each annotation spec's example count. Key is the annotation spec name and value is the
        /// number of examples for that annotation spec. If the annotated dataset does not have annotation spec, the map
        /// will return a pair where the key is empty string and value is the total number of annotations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exampleCount")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<long>> ExampleCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelTextClassification operation metadata.</summary>
    public class GoogleCloudDatalabelingV1beta1LabelTextClassificationOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1beta1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelTextEntityExtraction operation metadata.</summary>
    public class GoogleCloudDatalabelingV1beta1LabelTextEntityExtractionOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1beta1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for LabelText.</summary>
    public class GoogleCloudDatalabelingV1beta1LabelTextRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Basic human annotation config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1beta1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>Required. The type of text labeling task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feature")]
        public virtual string Feature { get; set; }

        /// <summary>Configuration for text classification task. One of text_classification_config and
        /// text_entity_extraction_config is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textClassificationConfig")]
        public virtual GoogleCloudDatalabelingV1beta1TextClassificationConfig TextClassificationConfig { get; set; }

        /// <summary>Configuration for entity extraction task. One of text_classification_config and
        /// text_entity_extraction_config is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textEntityExtractionConfig")]
        public virtual GoogleCloudDatalabelingV1beta1TextEntityExtractionConfig TextEntityExtractionConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelVideoClassification operation metadata.</summary>
    public class GoogleCloudDatalabelingV1beta1LabelVideoClassificationOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1beta1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelVideoEvent operation metadata.</summary>
    public class GoogleCloudDatalabelingV1beta1LabelVideoEventOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1beta1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelVideoObjectDetection operation metadata.</summary>
    public class GoogleCloudDatalabelingV1beta1LabelVideoObjectDetectionOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1beta1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelVideoObjectTracking operation metadata.</summary>
    public class GoogleCloudDatalabelingV1beta1LabelVideoObjectTrackingOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1beta1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for LabelVideo.</summary>
    public class GoogleCloudDatalabelingV1beta1LabelVideoRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Basic human annotation config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1beta1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>Configuration for video event task. One of video_classification_config, object_detection_config,
        /// object_tracking_config and event_config is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventConfig")]
        public virtual GoogleCloudDatalabelingV1beta1EventConfig EventConfig { get; set; }

        /// <summary>Required. The type of video labeling task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feature")]
        public virtual string Feature { get; set; }

        /// <summary>Configuration for video object detection task. One of video_classification_config,
        /// object_detection_config, object_tracking_config and event_config is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectDetectionConfig")]
        public virtual GoogleCloudDatalabelingV1beta1ObjectDetectionConfig ObjectDetectionConfig { get; set; }

        /// <summary>Configuration for video object tracking task. One of video_classification_config,
        /// object_detection_config, object_tracking_config and event_config is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectTrackingConfig")]
        public virtual GoogleCloudDatalabelingV1beta1ObjectTrackingConfig ObjectTrackingConfig { get; set; }

        /// <summary>Configuration for video classification task. One of video_classification_config,
        /// object_detection_config, object_tracking_config and event_config is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoClassificationConfig")]
        public virtual GoogleCloudDatalabelingV1beta1VideoClassificationConfig VideoClassificationConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Results of listing annotated datasets for a dataset.</summary>
    public class GoogleCloudDatalabelingV1beta1ListAnnotatedDatasetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of annotated datasets to return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedDatasets")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatalabelingV1beta1AnnotatedDataset> AnnotatedDatasets { get; set; }

        /// <summary>A token to retrieve next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Results of listing annotation spec set under a project.</summary>
    public class GoogleCloudDatalabelingV1beta1ListAnnotationSpecSetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of annotation spec sets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpecSets")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatalabelingV1beta1AnnotationSpecSet> AnnotationSpecSets { get; set; }

        /// <summary>A token to retrieve next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Results of listing data items in a dataset.</summary>
    public class GoogleCloudDatalabelingV1beta1ListDataItemsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of data items to return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataItems")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatalabelingV1beta1DataItem> DataItems { get; set; }

        /// <summary>A token to retrieve next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Results of listing datasets within a project.</summary>
    public class GoogleCloudDatalabelingV1beta1ListDatasetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of datasets to return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasets")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatalabelingV1beta1Dataset> Datasets { get; set; }

        /// <summary>A token to retrieve next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Results for listing evaluation jobs.</summary>
    public class GoogleCloudDatalabelingV1beta1ListEvaluationJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of evaluation jobs to return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationJobs")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatalabelingV1beta1EvaluationJob> EvaluationJobs { get; set; }

        /// <summary>A token to retrieve next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Results of listing Examples in and annotated dataset.</summary>
    public class GoogleCloudDatalabelingV1beta1ListExamplesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of examples to return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("examples")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatalabelingV1beta1Example> Examples { get; set; }

        /// <summary>A token to retrieve next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Results for listing FeedbackMessages.</summary>
    public class GoogleCloudDatalabelingV1beta1ListFeedbackMessagesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of feedback messages to return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedbackMessages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatalabelingV1beta1FeedbackMessage> FeedbackMessages { get; set; }

        /// <summary>A token to retrieve next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Results for listing FeedbackThreads.</summary>
    public class GoogleCloudDatalabelingV1beta1ListFeedbackThreadsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of feedback threads to return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedbackThreads")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatalabelingV1beta1FeedbackThread> FeedbackThreads { get; set; }

        /// <summary>A token to retrieve next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Results of listing instructions under a project.</summary>
    public class GoogleCloudDatalabelingV1beta1ListInstructionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Instructions to return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instructions")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatalabelingV1beta1Instruction> Instructions { get; set; }

        /// <summary>A token to retrieve next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Normalized bounding polygon.</summary>
    public class GoogleCloudDatalabelingV1beta1NormalizedBoundingPoly : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bounding polygon normalized vertices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedVertices")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatalabelingV1beta1NormalizedVertex> NormalizedVertices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Normalized polyline.</summary>
    public class GoogleCloudDatalabelingV1beta1NormalizedPolyline : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The normalized polyline vertices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedVertices")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatalabelingV1beta1NormalizedVertex> NormalizedVertices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A vertex represents a 2D point in the image. NOTE: the normalized vertex coordinates are relative to
    /// the original image and range from 0 to 1.</summary>
    public class GoogleCloudDatalabelingV1beta1NormalizedVertex : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual System.Nullable<float> X { get; set; }

        /// <summary>Y coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual System.Nullable<float> Y { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Config for video object detection human labeling task. Object detection will be conducted on the images
    /// extracted from the video, and those objects will be labeled with bounding boxes. User need to specify the number
    /// of images to be extracted per second as the extraction frame rate.</summary>
    public class GoogleCloudDatalabelingV1beta1ObjectDetectionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Annotation spec set resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpecSet")]
        public virtual string AnnotationSpecSet { get; set; }

        /// <summary>Required. Number of frames per second to be extracted from the video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extractionFrameRate")]
        public virtual System.Nullable<double> ExtractionFrameRate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metrics calculated for an image object detection (bounding box) model.</summary>
    public class GoogleCloudDatalabelingV1beta1ObjectDetectionMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Precision-recall curve.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prCurve")]
        public virtual GoogleCloudDatalabelingV1beta1PrCurve PrCurve { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Config for video object tracking human labeling task.</summary>
    public class GoogleCloudDatalabelingV1beta1ObjectTrackingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Annotation spec set resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpecSet")]
        public virtual string AnnotationSpecSet { get; set; }

        /// <summary>Videos will be cut to smaller clips to make it easier for labelers to work on. Users can configure
        /// is field in seconds, if not set, default value is 20s.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clipLength")]
        public virtual System.Nullable<int> ClipLength { get; set; }

        /// <summary>The overlap length between different video clips. Users can configure is field in seconds, if not
        /// set, default value is 0.3s.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overlapLength")]
        public virtual System.Nullable<int> OverlapLength { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Video frame level annotation for object detection and tracking.</summary>
    public class GoogleCloudDatalabelingV1beta1ObjectTrackingFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudDatalabelingV1beta1BoundingPoly BoundingPoly { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("normalizedBoundingPoly")]
        public virtual GoogleCloudDatalabelingV1beta1NormalizedBoundingPoly NormalizedBoundingPoly { get; set; }

        /// <summary>The time offset of this frame relative to the beginning of the video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata describing the feedback from the operator.</summary>
    public class GoogleCloudDatalabelingV1beta1OperatorFeedbackMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>General information useful for labels coming from contributors.</summary>
    public class GoogleCloudDatalabelingV1beta1OperatorMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Comments from contributors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comments")]
        public virtual System.Collections.Generic.IList<string> Comments { get; set; }

        /// <summary>The total number of contributors that choose this label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelVotes")]
        public virtual System.Nullable<int> LabelVotes { get; set; }

        /// <summary>Confidence score corresponding to a label. For examle, if 3 contributors have answered the question
        /// and 2 of them agree on the final label, the confidence score will be 0.67 (2/3).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The total number of contributors that answer this question.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalVotes")]
        public virtual System.Nullable<int> TotalVotes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The configuration of output data.</summary>
    public class GoogleCloudDatalabelingV1beta1OutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output to a file in Cloud Storage. Should be used for labeling output other than image
        /// segmentation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual GoogleCloudDatalabelingV1beta1GcsDestination GcsDestination { get; set; }

        /// <summary>Output to a folder in Cloud Storage. Should be used for image segmentation or document de-
        /// identification labeling outputs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsFolderDestination")]
        public virtual GoogleCloudDatalabelingV1beta1GcsFolderDestination GcsFolderDestination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for PauseEvaluationJob.</summary>
    public class GoogleCloudDatalabelingV1beta1PauseEvaluationJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Instruction from a PDF file.</summary>
    public class GoogleCloudDatalabelingV1beta1PdfInstruction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>PDF file for the instruction. Only gcs path is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsFileUri")]
        public virtual string GcsFileUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A line with multiple line segments.</summary>
    public class GoogleCloudDatalabelingV1beta1Polyline : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The polyline vertices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertices")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatalabelingV1beta1Vertex> Vertices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Config for image polyline human labeling task.</summary>
    public class GoogleCloudDatalabelingV1beta1PolylineConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Annotation spec set resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpecSet")]
        public virtual string AnnotationSpecSet { get; set; }

        /// <summary>Optional. Instruction message showed on contributors UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instructionMessage")]
        public virtual string InstructionMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class GoogleCloudDatalabelingV1beta1PrCurve : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The annotation spec of the label for which the precision-recall curve calculated. If this field is
        /// empty, that means the precision-recall curve is an aggregate curve for all labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpec")]
        public virtual GoogleCloudDatalabelingV1beta1AnnotationSpec AnnotationSpec { get; set; }

        /// <summary>Area under the precision-recall curve. Not to be confused with area under a receiver operating
        /// characteristic (ROC) curve.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("areaUnderCurve")]
        public virtual System.Nullable<float> AreaUnderCurve { get; set; }

        /// <summary>Entries that make up the precision-recall graph. Each entry is a "point" on the graph drawn for a
        /// different `confidence_threshold`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidenceMetricsEntries")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatalabelingV1beta1ConfidenceMetricsEntry> ConfidenceMetricsEntries { get; set; }

        /// <summary>Mean average prcision of this curve.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meanAveragePrecision")]
        public virtual System.Nullable<float> MeanAveragePrecision { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata describing the feedback from the labeling task requester.</summary>
    public class GoogleCloudDatalabelingV1beta1RequesterFeedbackMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message ResumeEvaluationJob.</summary>
    public class GoogleCloudDatalabelingV1beta1ResumeEvaluationJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A row in the confusion matrix. Each entry in this row has the same ground truth label.</summary>
    public class GoogleCloudDatalabelingV1beta1Row : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The annotation spec of the ground truth label for this row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpec")]
        public virtual GoogleCloudDatalabelingV1beta1AnnotationSpec AnnotationSpec { get; set; }

        /// <summary>A list of the confusion matrix entries. One entry for each possible predicted label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatalabelingV1beta1ConfusionMatrixEntry> Entries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Results of searching evaluations.</summary>
    public class GoogleCloudDatalabelingV1beta1SearchEvaluationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of evaluations matching the search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluations")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatalabelingV1beta1Evaluation> Evaluations { get; set; }

        /// <summary>A token to retrieve next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message of SearchExampleComparisons.</summary>
    public class GoogleCloudDatalabelingV1beta1SearchExampleComparisonsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Requested page size. Server may return fewer results than requested. Default value is
        /// 100.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>Optional. A token identifying a page of results for the server to return. Typically obtained by the
        /// nextPageToken of the response to a previous search rquest. If you don't specify this field, the API call
        /// requests the first page of the search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Results of searching example comparisons.</summary>
    public class GoogleCloudDatalabelingV1beta1SearchExampleComparisonsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of example comparisons matching the search criteria.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exampleComparisons")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatalabelingV1beta1ExampleComparison> ExampleComparisons { get; set; }

        /// <summary>A token to retrieve next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Config for image segmentation</summary>
    public class GoogleCloudDatalabelingV1beta1SegmentationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Annotation spec set resource name. format:
        /// projects/{project_id}/annotationSpecSets/{annotation_spec_set_id}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpecSet")]
        public virtual string AnnotationSpecSet { get; set; }

        /// <summary>Instruction message showed on labelers UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instructionMessage")]
        public virtual string InstructionMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Config for setting up sentiments.</summary>
    public class GoogleCloudDatalabelingV1beta1SentimentConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If set to true, contributors will have the option to select sentiment of the label they selected,
        /// to mark it as negative or positive label. Default is false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableLabelSentimentSelection")]
        public virtual System.Nullable<bool> EnableLabelSentimentSelection { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Start and end position in a sequence (e.g. text segment).</summary>
    public class GoogleCloudDatalabelingV1beta1SequentialSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>End position (exclusive).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("end")]
        public virtual System.Nullable<int> End { get; set; }

        /// <summary>Start position (inclusive).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("start")]
        public virtual System.Nullable<int> Start { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Text classification annotation.</summary>
    public class GoogleCloudDatalabelingV1beta1TextClassificationAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label of the text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpec")]
        public virtual GoogleCloudDatalabelingV1beta1AnnotationSpec AnnotationSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Config for text classification human labeling task.</summary>
    public class GoogleCloudDatalabelingV1beta1TextClassificationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If allow_multi_label is true, contributors are able to choose multiple labels for one
        /// text segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowMultiLabel")]
        public virtual System.Nullable<bool> AllowMultiLabel { get; set; }

        /// <summary>Required. Annotation spec set resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpecSet")]
        public virtual string AnnotationSpecSet { get; set; }

        /// <summary>Optional. Configs for sentiment selection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sentimentConfig")]
        public virtual GoogleCloudDatalabelingV1beta1SentimentConfig SentimentConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Text entity extraction annotation.</summary>
    public class GoogleCloudDatalabelingV1beta1TextEntityExtractionAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label of the text entities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpec")]
        public virtual GoogleCloudDatalabelingV1beta1AnnotationSpec AnnotationSpec { get; set; }

        /// <summary>Position of the entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sequentialSegment")]
        public virtual GoogleCloudDatalabelingV1beta1SequentialSegment SequentialSegment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Config for text entity extraction human labeling task.</summary>
    public class GoogleCloudDatalabelingV1beta1TextEntityExtractionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Annotation spec set resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpecSet")]
        public virtual string AnnotationSpecSet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata for the text.</summary>
    public class GoogleCloudDatalabelingV1beta1TextMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The language of this text, as a [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt). Default
        /// value is en-US.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Container of information about a piece of text.</summary>
    public class GoogleCloudDatalabelingV1beta1TextPayload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Text content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textContent")]
        public virtual string TextContent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A time period inside of an example that has a time dimension (e.g. video).</summary>
    public class GoogleCloudDatalabelingV1beta1TimeSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>End of the time segment (exclusive), represented as the duration since the example start.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTimeOffset")]
        public virtual object EndTimeOffset { get; set; }

        /// <summary>Start of the time segment (inclusive), represented as the duration since the example
        /// start.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeOffset")]
        public virtual object StartTimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A vertex represents a 2D point in the image. NOTE: the vertex coordinates are in the same scale as the
    /// original image.</summary>
    public class GoogleCloudDatalabelingV1beta1Vertex : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual System.Nullable<int> X { get; set; }

        /// <summary>Y coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual System.Nullable<int> Y { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Video classification annotation.</summary>
    public class GoogleCloudDatalabelingV1beta1VideoClassificationAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label of the segment specified by time_segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpec")]
        public virtual GoogleCloudDatalabelingV1beta1AnnotationSpec AnnotationSpec { get; set; }

        /// <summary>The time segment of the video to which the annotation applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSegment")]
        public virtual GoogleCloudDatalabelingV1beta1TimeSegment TimeSegment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Config for video classification human labeling task. Currently two types of video classification are
    /// supported: 1. Assign labels on the entire video. 2. Split the video into multiple video clips based on camera
    /// shot, and assign labels on each video clip.</summary>
    public class GoogleCloudDatalabelingV1beta1VideoClassificationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The list of annotation spec set configs. Since watching a video clip takes much longer
        /// time than an image, we support label with multiple AnnotationSpecSet at the same time. Labels in each
        /// AnnotationSpecSet will be shown in a group to contributors. Contributors can select one or more (depending
        /// on whether to allow multi label) from each group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpecSetConfigs")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatalabelingV1beta1AnnotationSpecSetConfig> AnnotationSpecSetConfigs { get; set; }

        /// <summary>Optional. Option to apply shot detection on the video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applyShotDetection")]
        public virtual System.Nullable<bool> ApplyShotDetection { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Video event annotation.</summary>
    public class GoogleCloudDatalabelingV1beta1VideoEventAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label of the event in this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpec")]
        public virtual GoogleCloudDatalabelingV1beta1AnnotationSpec AnnotationSpec { get; set; }

        /// <summary>The time segment of the video to which the annotation applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSegment")]
        public virtual GoogleCloudDatalabelingV1beta1TimeSegment TimeSegment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Video object tracking annotation.</summary>
    public class GoogleCloudDatalabelingV1beta1VideoObjectTrackingAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label of the object tracked in this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpec")]
        public virtual GoogleCloudDatalabelingV1beta1AnnotationSpec AnnotationSpec { get; set; }

        /// <summary>The list of frames where this object track appears.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectTrackingFrames")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatalabelingV1beta1ObjectTrackingFrame> ObjectTrackingFrames { get; set; }

        /// <summary>The time segment of the video to which object tracking applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSegment")]
        public virtual GoogleCloudDatalabelingV1beta1TimeSegment TimeSegment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Container of information of a video.</summary>
    public class GoogleCloudDatalabelingV1beta1VideoPayload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>FPS of the video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frameRate")]
        public virtual System.Nullable<float> FrameRate { get; set; }

        /// <summary>Video format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>Signed uri of the video file in the service bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signedUri")]
        public virtual string SignedUri { get; set; }

        /// <summary>The list of video thumbnails.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoThumbnails")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatalabelingV1beta1VideoThumbnail> VideoThumbnails { get; set; }

        /// <summary>Video uri from the user bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoUri")]
        public virtual string VideoUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Container of information of a video thumbnail.</summary>
    public class GoogleCloudDatalabelingV1beta1VideoThumbnail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A byte string of the video frame.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnail")]
        public virtual string Thumbnail { get; set; }

        /// <summary>Time offset relative to the beginning of the video, corresponding to the video frame where the
        /// thumbnail has been extracted from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata of a CreateInstruction operation.</summary>
    public class GoogleCloudDatalabelingV1p1alpha1CreateInstructionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Timestamp when create instruction request was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The name of the created Instruction. projects/{project_id}/instructions/{instruction_id}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instruction")]
        public virtual string Instruction { get; set; }

        /// <summary>Partial failures encountered. E.g. single files that couldn't be read. Status details field will
        /// contain standard GCP error details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialFailures")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> PartialFailures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata of an ExportData operation.</summary>
    public class GoogleCloudDatalabelingV1p1alpha1ExportDataOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The name of annotated dataset in format
        /// "projects/datasets/annotatedDatasets".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedDataset")]
        public virtual string AnnotatedDataset { get; set; }

        /// <summary>Output only. Timestamp when export dataset request was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The name of dataset to be exported. "projects/datasets"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>Output only. Partial failures encountered. E.g. single files that couldn't be read. Status details
        /// field will contain standard GCP error details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialFailures")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> PartialFailures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response used for ExportDataset longrunning operation.</summary>
    public class GoogleCloudDatalabelingV1p1alpha1ExportDataOperationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The name of annotated dataset in format
        /// "projects/datasets/annotatedDatasets".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedDataset")]
        public virtual string AnnotatedDataset { get; set; }

        /// <summary>Ouptut only. The name of dataset. "projects/datasets"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>Output only. Number of examples exported successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportCount")]
        public virtual System.Nullable<int> ExportCount { get; set; }

        /// <summary>Output only. Statistic infos of labels in the exported dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelStats")]
        public virtual GoogleCloudDatalabelingV1p1alpha1LabelStats LabelStats { get; set; }

        /// <summary>Output only. output_config in the ExportData request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual GoogleCloudDatalabelingV1p1alpha1OutputConfig OutputConfig { get; set; }

        /// <summary>Output only. Total number of examples requested to export</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalCount")]
        public virtual System.Nullable<int> TotalCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Export destination of the data.Only gcs path is allowed in output_uri.</summary>
    public class GoogleCloudDatalabelingV1p1alpha1GcsDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The format of the gcs destination. Only "text/csv" and "application/json" are
        /// supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>Required. The output uri of destination file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputUri")]
        public virtual string OutputUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Export folder destination of the data.</summary>
    public class GoogleCloudDatalabelingV1p1alpha1GcsFolderDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Cloud Storage directory to export data to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputFolderUri")]
        public virtual string OutputFolderUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata of an GenerateAnalysisReport operation.</summary>
    public class GoogleCloudDatalabelingV1p1alpha1GenerateAnalysisReportOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Timestamp when generate report request was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The name of the dataset for which the analysis report is generated. Format:
        /// "projects/datasets"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Configuration for how human labeling task should be done.</summary>
    public class GoogleCloudDatalabelingV1p1alpha1HumanAnnotationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A human-readable description for AnnotatedDataset. The description can be up to 10000
        /// characters long.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedDatasetDescription")]
        public virtual string AnnotatedDatasetDescription { get; set; }

        /// <summary>Required. A human-readable name for AnnotatedDataset defined by users. Maximum of 64 characters
        /// .</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedDatasetDisplayName")]
        public virtual string AnnotatedDatasetDisplayName { get; set; }

        /// <summary>Optional. If you want your own labeling contributors to manage and work on this labeling request,
        /// you can set these contributors here. We will give them access to the question types in crowdcompute. Note
        /// that these emails must be registered in crowdcompute worker UI: https://crowd-compute.appspot.com/</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contributorEmails")]
        public virtual System.Collections.Generic.IList<string> ContributorEmails { get; set; }

        /// <summary>Required. Instruction resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instruction")]
        public virtual string Instruction { get; set; }

        /// <summary>Optional. A human-readable label used to logically group labeling tasks. This string must match the
        /// regular expression `[a-zA-Z\\d_-]{0,128}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelGroup")]
        public virtual string LabelGroup { get; set; }

        /// <summary>Optional. The Language of this question, as a [BCP-47](https://www.rfc-
        /// editor.org/rfc/bcp/bcp47.txt). Default value is en-US. Only need to set this when task is language related.
        /// For example, French text classification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Optional. Maximum duration for contributors to answer a question. Maximum is 3600 seconds. Default
        /// is 3600 seconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("questionDuration")]
        public virtual object QuestionDuration { get; set; }

        /// <summary>Optional. Replication of questions. Each question will be sent to up to this number of contributors
        /// to label. Aggregated answers will be returned. Default is set to 1. For image related labeling, valid values
        /// are 1, 3, 5.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicaCount")]
        public virtual System.Nullable<int> ReplicaCount { get; set; }

        /// <summary>Email of the user who started the labeling task and should be notified by email. If empty no
        /// notification will be sent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEmailAddress")]
        public virtual string UserEmailAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata of an ImportData operation.</summary>
    public class GoogleCloudDatalabelingV1p1alpha1ImportDataOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Timestamp when import dataset request was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The name of imported dataset. "projects/datasets"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>Output only. Partial failures encountered. E.g. single files that couldn't be read. Status details
        /// field will contain standard GCP error details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialFailures")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> PartialFailures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response used for ImportData longrunning operation.</summary>
    public class GoogleCloudDatalabelingV1p1alpha1ImportDataOperationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Ouptut only. The name of imported dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>Output only. Number of examples imported successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importCount")]
        public virtual System.Nullable<int> ImportCount { get; set; }

        /// <summary>Output only. Total number of examples requested to import</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalCount")]
        public virtual System.Nullable<int> TotalCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelImageBoundingBox operation metadata.</summary>
    public class GoogleCloudDatalabelingV1p1alpha1LabelImageBoundingBoxOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1p1alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of LabelImageBoundingPoly operation metadata.</summary>
    public class GoogleCloudDatalabelingV1p1alpha1LabelImageBoundingPolyOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1p1alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata of a LabelImageClassification operation.</summary>
    public class GoogleCloudDatalabelingV1p1alpha1LabelImageClassificationOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1p1alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelImageOrientedBoundingBox operation metadata.</summary>
    public class GoogleCloudDatalabelingV1p1alpha1LabelImageOrientedBoundingBoxOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1p1alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of LabelImagePolyline operation metadata.</summary>
    public class GoogleCloudDatalabelingV1p1alpha1LabelImagePolylineOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1p1alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelImageSegmentation operation metadata.</summary>
    public class GoogleCloudDatalabelingV1p1alpha1LabelImageSegmentationOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1p1alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata of a labeling operation, such as LabelImage or LabelVideo. Next tag: 23</summary>
    public class GoogleCloudDatalabelingV1p1alpha1LabelOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The name of annotated dataset in format
        /// "projects/datasets/annotatedDatasets".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedDataset")]
        public virtual string AnnotatedDataset { get; set; }

        /// <summary>Output only. Timestamp when labeling request was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The name of dataset to be labeled. "projects/datasets"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>Details of label image bounding box operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageBoundingBoxDetails")]
        public virtual GoogleCloudDatalabelingV1p1alpha1LabelImageBoundingBoxOperationMetadata ImageBoundingBoxDetails { get; set; }

        /// <summary>Details of label image bounding poly operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageBoundingPolyDetails")]
        public virtual GoogleCloudDatalabelingV1p1alpha1LabelImageBoundingPolyOperationMetadata ImageBoundingPolyDetails { get; set; }

        /// <summary>Details of label image classification operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageClassificationDetails")]
        public virtual GoogleCloudDatalabelingV1p1alpha1LabelImageClassificationOperationMetadata ImageClassificationDetails { get; set; }

        /// <summary>Details of label image oriented bounding box operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageOrientedBoundingBoxDetails")]
        public virtual GoogleCloudDatalabelingV1p1alpha1LabelImageOrientedBoundingBoxOperationMetadata ImageOrientedBoundingBoxDetails { get; set; }

        /// <summary>Details of label image polyline operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imagePolylineDetails")]
        public virtual GoogleCloudDatalabelingV1p1alpha1LabelImagePolylineOperationMetadata ImagePolylineDetails { get; set; }

        /// <summary>Details of label image segmentation operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageSegmentationDetails")]
        public virtual GoogleCloudDatalabelingV1p1alpha1LabelImageSegmentationOperationMetadata ImageSegmentationDetails { get; set; }

        /// <summary>Output only. Partial failures encountered. E.g. single files that couldn't be read. Status details
        /// field will contain standard GCP error details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialFailures")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> PartialFailures { get; set; }

        /// <summary>Output only. Progress of label operation. Range: [0, 100].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressPercent")]
        public virtual System.Nullable<int> ProgressPercent { get; set; }

        /// <summary>Details of label text classification operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textClassificationDetails")]
        public virtual GoogleCloudDatalabelingV1p1alpha1LabelTextClassificationOperationMetadata TextClassificationDetails { get; set; }

        /// <summary>Details of label text entity extraction operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textEntityExtractionDetails")]
        public virtual GoogleCloudDatalabelingV1p1alpha1LabelTextEntityExtractionOperationMetadata TextEntityExtractionDetails { get; set; }

        /// <summary>Details of label video classification operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoClassificationDetails")]
        public virtual GoogleCloudDatalabelingV1p1alpha1LabelVideoClassificationOperationMetadata VideoClassificationDetails { get; set; }

        /// <summary>Details of label video event operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoEventDetails")]
        public virtual GoogleCloudDatalabelingV1p1alpha1LabelVideoEventOperationMetadata VideoEventDetails { get; set; }

        /// <summary>Details of label video object detection operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoObjectDetectionDetails")]
        public virtual GoogleCloudDatalabelingV1p1alpha1LabelVideoObjectDetectionOperationMetadata VideoObjectDetectionDetails { get; set; }

        /// <summary>Details of label video object tracking operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoObjectTrackingDetails")]
        public virtual GoogleCloudDatalabelingV1p1alpha1LabelVideoObjectTrackingOperationMetadata VideoObjectTrackingDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Statistics about annotation specs.</summary>
    public class GoogleCloudDatalabelingV1p1alpha1LabelStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Map of each annotation spec's example count. Key is the annotation spec name and value is the
        /// number of examples for that annotation spec. If the annotated dataset does not have annotation spec, the map
        /// will return a pair where the key is empty string and value is the total number of annotations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exampleCount")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<long>> ExampleCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelTextClassification operation metadata.</summary>
    public class GoogleCloudDatalabelingV1p1alpha1LabelTextClassificationOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1p1alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelTextEntityExtraction operation metadata.</summary>
    public class GoogleCloudDatalabelingV1p1alpha1LabelTextEntityExtractionOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1p1alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelVideoClassification operation metadata.</summary>
    public class GoogleCloudDatalabelingV1p1alpha1LabelVideoClassificationOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1p1alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelVideoEvent operation metadata.</summary>
    public class GoogleCloudDatalabelingV1p1alpha1LabelVideoEventOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1p1alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelVideoObjectDetection operation metadata.</summary>
    public class GoogleCloudDatalabelingV1p1alpha1LabelVideoObjectDetectionOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1p1alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelVideoObjectTracking operation metadata.</summary>
    public class GoogleCloudDatalabelingV1p1alpha1LabelVideoObjectTrackingOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1p1alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The configuration of output data.</summary>
    public class GoogleCloudDatalabelingV1p1alpha1OutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output to a file in Cloud Storage. Should be used for labeling output other than image
        /// segmentation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual GoogleCloudDatalabelingV1p1alpha1GcsDestination GcsDestination { get; set; }

        /// <summary>Output to a folder in Cloud Storage. Should be used for image segmentation or document de-
        /// identification labeling outputs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsFolderDestination")]
        public virtual GoogleCloudDatalabelingV1p1alpha1GcsFolderDestination GcsFolderDestination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata of a CreateInstruction operation.</summary>
    public class GoogleCloudDatalabelingV1p2alpha1CreateInstructionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Timestamp when create instruction request was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The name of the created Instruction. projects/{project_id}/instructions/{instruction_id}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instruction")]
        public virtual string Instruction { get; set; }

        /// <summary>Partial failures encountered. E.g. single files that couldn't be read. Status details field will
        /// contain standard GCP error details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialFailures")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> PartialFailures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata of an ExportData operation.</summary>
    public class GoogleCloudDatalabelingV1p2alpha1ExportDataOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The name of annotated dataset in format
        /// "projects/datasets/annotatedDatasets".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedDataset")]
        public virtual string AnnotatedDataset { get; set; }

        /// <summary>Output only. Timestamp when export dataset request was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The name of dataset to be exported. "projects/datasets"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>Output only. Partial failures encountered. E.g. single files that couldn't be read. Status details
        /// field will contain standard GCP error details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialFailures")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> PartialFailures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response used for ExportDataset longrunning operation.</summary>
    public class GoogleCloudDatalabelingV1p2alpha1ExportDataOperationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The name of annotated dataset in format
        /// "projects/datasets/annotatedDatasets".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedDataset")]
        public virtual string AnnotatedDataset { get; set; }

        /// <summary>Ouptut only. The name of dataset. "projects/datasets"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>Output only. Number of examples exported successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportCount")]
        public virtual System.Nullable<int> ExportCount { get; set; }

        /// <summary>Output only. Statistic infos of labels in the exported dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelStats")]
        public virtual GoogleCloudDatalabelingV1p2alpha1LabelStats LabelStats { get; set; }

        /// <summary>Output only. output_config in the ExportData request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual GoogleCloudDatalabelingV1p2alpha1OutputConfig OutputConfig { get; set; }

        /// <summary>Output only. Total number of examples requested to export</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalCount")]
        public virtual System.Nullable<int> TotalCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Export destination of the data.Only gcs path is allowed in output_uri.</summary>
    public class GoogleCloudDatalabelingV1p2alpha1GcsDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The format of the gcs destination. Only "text/csv" and "application/json" are
        /// supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>Required. The output uri of destination file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputUri")]
        public virtual string OutputUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Export folder destination of the data.</summary>
    public class GoogleCloudDatalabelingV1p2alpha1GcsFolderDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Cloud Storage directory to export data to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputFolderUri")]
        public virtual string OutputFolderUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Configuration for how human labeling task should be done.</summary>
    public class GoogleCloudDatalabelingV1p2alpha1HumanAnnotationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A human-readable description for AnnotatedDataset. The description can be up to 10000
        /// characters long.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedDatasetDescription")]
        public virtual string AnnotatedDatasetDescription { get; set; }

        /// <summary>Required. A human-readable name for AnnotatedDataset defined by users. Maximum of 64 characters
        /// .</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedDatasetDisplayName")]
        public virtual string AnnotatedDatasetDisplayName { get; set; }

        /// <summary>Optional. If you want your own labeling contributors to manage and work on this labeling request,
        /// you can set these contributors here. We will give them access to the question types in crowdcompute. Note
        /// that these emails must be registered in crowdcompute worker UI: https://crowd-compute.appspot.com/</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contributorEmails")]
        public virtual System.Collections.Generic.IList<string> ContributorEmails { get; set; }

        /// <summary>Required. Instruction resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instruction")]
        public virtual string Instruction { get; set; }

        /// <summary>Optional. A human-readable label used to logically group labeling tasks. This string must match the
        /// regular expression `[a-zA-Z\\d_-]{0,128}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelGroup")]
        public virtual string LabelGroup { get; set; }

        /// <summary>Optional. The Language of this question, as a [BCP-47](https://www.rfc-
        /// editor.org/rfc/bcp/bcp47.txt). Default value is en-US. Only need to set this when task is language related.
        /// For example, French text classification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Optional. Maximum duration for contributors to answer a question. Maximum is 3600 seconds. Default
        /// is 3600 seconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("questionDuration")]
        public virtual object QuestionDuration { get; set; }

        /// <summary>Optional. Replication of questions. Each question will be sent to up to this number of contributors
        /// to label. Aggregated answers will be returned. Default is set to 1. For image related labeling, valid values
        /// are 1, 3, 5.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicaCount")]
        public virtual System.Nullable<int> ReplicaCount { get; set; }

        /// <summary>Email of the user who started the labeling task and should be notified by email. If empty no
        /// notification will be sent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEmailAddress")]
        public virtual string UserEmailAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata of an ImportData operation.</summary>
    public class GoogleCloudDatalabelingV1p2alpha1ImportDataOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Timestamp when import dataset request was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The name of imported dataset. "projects/datasets"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>Output only. Partial failures encountered. E.g. single files that couldn't be read. Status details
        /// field will contain standard GCP error details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialFailures")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> PartialFailures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response used for ImportData longrunning operation.</summary>
    public class GoogleCloudDatalabelingV1p2alpha1ImportDataOperationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Ouptut only. The name of imported dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>Output only. Number of examples imported successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importCount")]
        public virtual System.Nullable<int> ImportCount { get; set; }

        /// <summary>Output only. Total number of examples requested to import</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalCount")]
        public virtual System.Nullable<int> TotalCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelImageBoundingBox operation metadata.</summary>
    public class GoogleCloudDatalabelingV1p2alpha1LabelImageBoundingBoxOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1p2alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of LabelImageBoundingPoly operation metadata.</summary>
    public class GoogleCloudDatalabelingV1p2alpha1LabelImageBoundingPolyOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1p2alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata of a LabelImageClassification operation.</summary>
    public class GoogleCloudDatalabelingV1p2alpha1LabelImageClassificationOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1p2alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelImageOrientedBoundingBox operation metadata.</summary>
    public class GoogleCloudDatalabelingV1p2alpha1LabelImageOrientedBoundingBoxOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1p2alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of LabelImagePolyline operation metadata.</summary>
    public class GoogleCloudDatalabelingV1p2alpha1LabelImagePolylineOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1p2alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelImageSegmentation operation metadata.</summary>
    public class GoogleCloudDatalabelingV1p2alpha1LabelImageSegmentationOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1p2alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata of a labeling operation, such as LabelImage or LabelVideo. Next tag: 23</summary>
    public class GoogleCloudDatalabelingV1p2alpha1LabelOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The name of annotated dataset in format
        /// "projects/datasets/annotatedDatasets".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedDataset")]
        public virtual string AnnotatedDataset { get; set; }

        /// <summary>Output only. Timestamp when labeling request was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The name of dataset to be labeled. "projects/datasets"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>Details of label image bounding box operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageBoundingBoxDetails")]
        public virtual GoogleCloudDatalabelingV1p2alpha1LabelImageBoundingBoxOperationMetadata ImageBoundingBoxDetails { get; set; }

        /// <summary>Details of label image bounding poly operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageBoundingPolyDetails")]
        public virtual GoogleCloudDatalabelingV1p2alpha1LabelImageBoundingPolyOperationMetadata ImageBoundingPolyDetails { get; set; }

        /// <summary>Details of label image classification operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageClassificationDetails")]
        public virtual GoogleCloudDatalabelingV1p2alpha1LabelImageClassificationOperationMetadata ImageClassificationDetails { get; set; }

        /// <summary>Details of label image oriented bounding box operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageOrientedBoundingBoxDetails")]
        public virtual GoogleCloudDatalabelingV1p2alpha1LabelImageOrientedBoundingBoxOperationMetadata ImageOrientedBoundingBoxDetails { get; set; }

        /// <summary>Details of label image polyline operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imagePolylineDetails")]
        public virtual GoogleCloudDatalabelingV1p2alpha1LabelImagePolylineOperationMetadata ImagePolylineDetails { get; set; }

        /// <summary>Details of label image segmentation operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageSegmentationDetails")]
        public virtual GoogleCloudDatalabelingV1p2alpha1LabelImageSegmentationOperationMetadata ImageSegmentationDetails { get; set; }

        /// <summary>Output only. Partial failures encountered. E.g. single files that couldn't be read. Status details
        /// field will contain standard GCP error details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialFailures")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> PartialFailures { get; set; }

        /// <summary>Output only. Progress of label operation. Range: [0, 100].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressPercent")]
        public virtual System.Nullable<int> ProgressPercent { get; set; }

        /// <summary>Details of label text classification operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textClassificationDetails")]
        public virtual GoogleCloudDatalabelingV1p2alpha1LabelTextClassificationOperationMetadata TextClassificationDetails { get; set; }

        /// <summary>Details of label text entity extraction operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textEntityExtractionDetails")]
        public virtual GoogleCloudDatalabelingV1p2alpha1LabelTextEntityExtractionOperationMetadata TextEntityExtractionDetails { get; set; }

        /// <summary>Details of label video classification operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoClassificationDetails")]
        public virtual GoogleCloudDatalabelingV1p2alpha1LabelVideoClassificationOperationMetadata VideoClassificationDetails { get; set; }

        /// <summary>Details of label video event operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoEventDetails")]
        public virtual GoogleCloudDatalabelingV1p2alpha1LabelVideoEventOperationMetadata VideoEventDetails { get; set; }

        /// <summary>Details of label video object detection operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoObjectDetectionDetails")]
        public virtual GoogleCloudDatalabelingV1p2alpha1LabelVideoObjectDetectionOperationMetadata VideoObjectDetectionDetails { get; set; }

        /// <summary>Details of label video object tracking operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoObjectTrackingDetails")]
        public virtual GoogleCloudDatalabelingV1p2alpha1LabelVideoObjectTrackingOperationMetadata VideoObjectTrackingDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Statistics about annotation specs.</summary>
    public class GoogleCloudDatalabelingV1p2alpha1LabelStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Map of each annotation spec's example count. Key is the annotation spec name and value is the
        /// number of examples for that annotation spec. If the annotated dataset does not have annotation spec, the map
        /// will return a pair where the key is empty string and value is the total number of annotations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exampleCount")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<long>> ExampleCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelTextClassification operation metadata.</summary>
    public class GoogleCloudDatalabelingV1p2alpha1LabelTextClassificationOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1p2alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelTextEntityExtraction operation metadata.</summary>
    public class GoogleCloudDatalabelingV1p2alpha1LabelTextEntityExtractionOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1p2alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelVideoClassification operation metadata.</summary>
    public class GoogleCloudDatalabelingV1p2alpha1LabelVideoClassificationOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1p2alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelVideoEvent operation metadata.</summary>
    public class GoogleCloudDatalabelingV1p2alpha1LabelVideoEventOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1p2alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelVideoObjectDetection operation metadata.</summary>
    public class GoogleCloudDatalabelingV1p2alpha1LabelVideoObjectDetectionOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1p2alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a LabelVideoObjectTracking operation metadata.</summary>
    public class GoogleCloudDatalabelingV1p2alpha1LabelVideoObjectTrackingOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic human annotation config used in labeling request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicConfig")]
        public virtual GoogleCloudDatalabelingV1p2alpha1HumanAnnotationConfig BasicConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The configuration of output data.</summary>
    public class GoogleCloudDatalabelingV1p2alpha1OutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output to a file in Cloud Storage. Should be used for labeling output other than image
        /// segmentation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual GoogleCloudDatalabelingV1p2alpha1GcsDestination GcsDestination { get; set; }

        /// <summary>Output to a folder in Cloud Storage. Should be used for image segmentation or document de-
        /// identification labeling outputs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsFolderDestination")]
        public virtual GoogleCloudDatalabelingV1p2alpha1GcsFolderDestination GcsFolderDestination { get; set; }

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
        /// <summary>If the value is `false`, it means the operation is still in progress. If `true`, the operation is
        /// completed, and either `error` or `response` is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual GoogleRpcStatus Error { get; set; }

        /// <summary>Service-specific metadata associated with the operation. It typically contains progress information
        /// and common metadata such as create time. Some services might not provide such metadata. Any method that
        /// returns a long-running operation should document the metadata type, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

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
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A
    /// typical example is to use it as the request or the response type of an API method. For instance: service Foo {
    /// rpc Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty
    /// JSON object `{}`.</summary>
    public class GoogleProtobufEmpty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The `Status` type defines a logical error model that is suitable for different programming
    /// environments, including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status`
    /// message contains three pieces of data: error code, error message, and error details. You can find out more about
    /// this error model and how to work with it in the [API Design
    /// Guide](https://cloud.google.com/apis/design/errors).</summary>
    public class GoogleRpcStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>A list of messages that carry the error details. There is a common set of message types for APIs to
        /// use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Details { get; set; }

        /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should
        /// be localized and sent in the google.rpc.Status.details field, or localized by the client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
