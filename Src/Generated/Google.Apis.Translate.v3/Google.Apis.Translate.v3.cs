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

namespace Google.Apis.Translate.v3
{
    /// <summary>The Translate Service.</summary>
    public class TranslateService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v3";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public TranslateService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public TranslateService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://translation.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://translation.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "translate";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Translation API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Translate text from one language to another using Google Translate</summary>
            public static string CloudTranslation = "https://www.googleapis.com/auth/cloud-translation";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Translation API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Translate text from one language to another using Google Translate</summary>
            public const string CloudTranslation = "https://www.googleapis.com/auth/cloud-translation";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for Translate requests.</summary>
    public abstract class TranslateBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new TranslateBaseServiceRequest instance.</summary>
        protected TranslateBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Translate parameter list.</summary>
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
                AdaptiveMtDatasets = new AdaptiveMtDatasetsResource(service);
                Datasets = new DatasetsResource(service);
                Glossaries = new GlossariesResource(service);
                Models = new ModelsResource(service);
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the AdaptiveMtDatasets resource.</summary>
            public virtual AdaptiveMtDatasetsResource AdaptiveMtDatasets { get; }

            /// <summary>The "adaptiveMtDatasets" collection of methods.</summary>
            public class AdaptiveMtDatasetsResource
            {
                private const string Resource = "adaptiveMtDatasets";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AdaptiveMtDatasetsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    AdaptiveMtFiles = new AdaptiveMtFilesResource(service);
                    AdaptiveMtSentences = new AdaptiveMtSentencesResource(service);
                }

                /// <summary>Gets the AdaptiveMtFiles resource.</summary>
                public virtual AdaptiveMtFilesResource AdaptiveMtFiles { get; }

                /// <summary>The "adaptiveMtFiles" collection of methods.</summary>
                public class AdaptiveMtFilesResource
                {
                    private const string Resource = "adaptiveMtFiles";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public AdaptiveMtFilesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        AdaptiveMtSentences = new AdaptiveMtSentencesResource(service);
                    }

                    /// <summary>Gets the AdaptiveMtSentences resource.</summary>
                    public virtual AdaptiveMtSentencesResource AdaptiveMtSentences { get; }

                    /// <summary>The "adaptiveMtSentences" collection of methods.</summary>
                    public class AdaptiveMtSentencesResource
                    {
                        private const string Resource = "adaptiveMtSentences";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public AdaptiveMtSentencesResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Lists all AdaptiveMtSentences under a given file/dataset.</summary>
                        /// <param name="parent">
                        /// Required. The resource name of the project from which to list the Adaptive MT files. The
                        /// following format lists all sentences under a file.
                        /// `projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}`
                        /// The following format lists all sentences within a dataset.
                        /// `projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}`
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>Lists all AdaptiveMtSentences under a given file/dataset.</summary>
                        public class ListRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.ListAdaptiveMtSentencesResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the project from which to list the Adaptive MT files. The
                            /// following format lists all sentences under a file.
                            /// `projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}`
                            /// The following format lists all sentences within a dataset.
                            /// `projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// A token identifying a page of results the server should return. Typically, this is the
                            /// value of ListAdaptiveMtSentencesRequest.next_page_token returned from the previous call
                            /// to `ListTranslationMemories` method. The first page is returned if `page_token` is empty
                            /// or missing.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v3/{+parent}/adaptiveMtSentences";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/adaptiveMtDatasets/[^/]+/adaptiveMtFiles/[^/]+$",
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

                    /// <summary>Deletes an AdaptiveMtFile along with its sentences.</summary>
                    /// <param name="name">
                    /// Required. The resource name of the file to delete, in form of
                    /// `projects/{project-number-or-id}/locations/{location_id}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes an AdaptiveMtFile along with its sentences.</summary>
                    public class DeleteRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the file to delete, in form of
                        /// `projects/{project-number-or-id}/locations/{location_id}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v3/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/adaptiveMtDatasets/[^/]+/adaptiveMtFiles/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets and AdaptiveMtFile</summary>
                    /// <param name="name">
                    /// Required. The resource name of the file, in form of
                    /// `projects/{project-number-or-id}/locations/{location_id}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets and AdaptiveMtFile</summary>
                    public class GetRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.AdaptiveMtFile>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the file, in form of
                        /// `projects/{project-number-or-id}/locations/{location_id}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v3/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/adaptiveMtDatasets/[^/]+/adaptiveMtFiles/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists all AdaptiveMtFiles associated to an AdaptiveMtDataset.</summary>
                    /// <param name="parent">
                    /// Required. The resource name of the project from which to list the Adaptive MT files.
                    /// `projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists all AdaptiveMtFiles associated to an AdaptiveMtDataset.</summary>
                    public class ListRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.ListAdaptiveMtFilesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the project from which to list the Adaptive MT files.
                        /// `projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A token identifying a page of results the server should return. Typically, this is
                        /// the value of ListAdaptiveMtFilesResponse.next_page_token returned from the previous call to
                        /// `ListAdaptiveMtFiles` method. The first page is returned if `page_token`is empty or missing.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v3/{+parent}/adaptiveMtFiles";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/adaptiveMtDatasets/[^/]+$",
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

                /// <summary>Gets the AdaptiveMtSentences resource.</summary>
                public virtual AdaptiveMtSentencesResource AdaptiveMtSentences { get; }

                /// <summary>The "adaptiveMtSentences" collection of methods.</summary>
                public class AdaptiveMtSentencesResource
                {
                    private const string Resource = "adaptiveMtSentences";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public AdaptiveMtSentencesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Lists all AdaptiveMtSentences under a given file/dataset.</summary>
                    /// <param name="parent">
                    /// Required. The resource name of the project from which to list the Adaptive MT files. The
                    /// following format lists all sentences under a file.
                    /// `projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}`
                    /// The following format lists all sentences within a dataset.
                    /// `projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists all AdaptiveMtSentences under a given file/dataset.</summary>
                    public class ListRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.ListAdaptiveMtSentencesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the project from which to list the Adaptive MT files. The
                        /// following format lists all sentences under a file.
                        /// `projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}`
                        /// The following format lists all sentences within a dataset.
                        /// `projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A token identifying a page of results the server should return. Typically, this is the value
                        /// of ListAdaptiveMtSentencesRequest.next_page_token returned from the previous call to
                        /// `ListTranslationMemories` method. The first page is returned if `page_token` is empty or
                        /// missing.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v3/{+parent}/adaptiveMtSentences";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/adaptiveMtDatasets/[^/]+$",
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

                /// <summary>Creates an Adaptive MT dataset.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Name of the parent project. In form of
                /// `projects/{project-number-or-id}/locations/{location-id}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Translate.v3.Data.AdaptiveMtDataset body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates an Adaptive MT dataset.</summary>
                public class CreateRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.AdaptiveMtDataset>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Translate.v3.Data.AdaptiveMtDataset body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the parent project. In form of
                    /// `projects/{project-number-or-id}/locations/{location-id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Translate.v3.Data.AdaptiveMtDataset Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v3/{+parent}/adaptiveMtDatasets";

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
                /// Deletes an Adaptive MT dataset, including all its entries and associated metadata.
                /// </summary>
                /// <param name="name">
                /// Required. Name of the dataset. In the form of
                /// `projects/{project-number-or-id}/locations/{location-id}/adaptiveMtDatasets/{adaptive-mt-dataset-id}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes an Adaptive MT dataset, including all its entries and associated metadata.
                /// </summary>
                public class DeleteRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the dataset. In the form of
                    /// `projects/{project-number-or-id}/locations/{location-id}/adaptiveMtDatasets/{adaptive-mt-dataset-id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v3/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/adaptiveMtDatasets/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets the Adaptive MT dataset.</summary>
                /// <param name="name">
                /// Required. Name of the dataset. In the form of
                /// `projects/{project-number-or-id}/locations/{location-id}/adaptiveMtDatasets/{adaptive-mt-dataset-id}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets the Adaptive MT dataset.</summary>
                public class GetRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.AdaptiveMtDataset>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the dataset. In the form of
                    /// `projects/{project-number-or-id}/locations/{location-id}/adaptiveMtDatasets/{adaptive-mt-dataset-id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v3/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/adaptiveMtDatasets/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Imports an AdaptiveMtFile and adds all of its sentences into the AdaptiveMtDataset.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource name of the file, in form of
                /// `projects/{project-number-or-id}/locations/{location_id}/adaptiveMtDatasets/{dataset}`
                /// </param>
                public virtual ImportAdaptiveMtFileRequest ImportAdaptiveMtFile(Google.Apis.Translate.v3.Data.ImportAdaptiveMtFileRequest body, string parent)
                {
                    return new ImportAdaptiveMtFileRequest(this.service, body, parent);
                }

                /// <summary>
                /// Imports an AdaptiveMtFile and adds all of its sentences into the AdaptiveMtDataset.
                /// </summary>
                public class ImportAdaptiveMtFileRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.ImportAdaptiveMtFileResponse>
                {
                    /// <summary>Constructs a new ImportAdaptiveMtFile request.</summary>
                    public ImportAdaptiveMtFileRequest(Google.Apis.Services.IClientService service, Google.Apis.Translate.v3.Data.ImportAdaptiveMtFileRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the file, in form of
                    /// `projects/{project-number-or-id}/locations/{location_id}/adaptiveMtDatasets/{dataset}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Translate.v3.Data.ImportAdaptiveMtFileRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "importAdaptiveMtFile";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v3/{+parent}:importAdaptiveMtFile";

                    /// <summary>Initializes ImportAdaptiveMtFile parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/adaptiveMtDatasets/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all Adaptive MT datasets for which the caller has read permission.</summary>
                /// <param name="parent">
                /// Required. The resource name of the project from which to list the Adaptive MT datasets.
                /// `projects/{project-number-or-id}/locations/{location-id}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all Adaptive MT datasets for which the caller has read permission.</summary>
                public class ListRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.ListAdaptiveMtDatasetsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the project from which to list the Adaptive MT datasets.
                    /// `projects/{project-number-or-id}/locations/{location-id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An expression for filtering the results of the request. Filter is not supported yet.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. Requested page size. The server may return fewer results than requested. If
                    /// unspecified, the server picks an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A token identifying a page of results the server should return. Typically, this is the
                    /// value of ListAdaptiveMtDatasetsResponse.next_page_token returned from the previous call to
                    /// `ListAdaptiveMtDatasets` method. The first page is returned if `page_token`is empty or missing.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v3/{+parent}/adaptiveMtDatasets";

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
                    Examples = new ExamplesResource(service);
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

                    /// <summary>Lists sentence pairs in the dataset.</summary>
                    /// <param name="parent">
                    /// Required. Name of the parent dataset. In form of
                    /// `projects/{project-number-or-id}/locations/{location-id}/datasets/{dataset-id}`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists sentence pairs in the dataset.</summary>
                    public class ListRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.ListExamplesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Name of the parent dataset. In form of
                        /// `projects/{project-number-or-id}/locations/{location-id}/datasets/{dataset-id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. An expression for filtering the examples that will be returned. Example filter: *
                        /// `usage=TRAIN`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Requested page size. The server can return fewer results than requested.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A token identifying a page of results for the server to return. Typically obtained
                        /// from next_page_token field in the response of a ListExamples call.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v3/{+parent}/examples";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+$",
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

                /// <summary>Creates a Dataset.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The project name.</param>
                public virtual CreateRequest Create(Google.Apis.Translate.v3.Data.Dataset body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a Dataset.</summary>
                public class CreateRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Translate.v3.Data.Dataset body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The project name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Translate.v3.Data.Dataset Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v3/{+parent}/datasets";

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

                /// <summary>Deletes a dataset and all of its contents.</summary>
                /// <param name="name">Required. The name of the dataset to delete.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a dataset and all of its contents.</summary>
                public class DeleteRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the dataset to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v3/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+$",
                        });
                    }
                }

                /// <summary>Exports dataset's data to the provided output location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="dataset">
                /// Required. Name of the dataset. In form of
                /// `projects/{project-number-or-id}/locations/{location-id}/datasets/{dataset-id}`
                /// </param>
                public virtual ExportDataRequest ExportData(Google.Apis.Translate.v3.Data.ExportDataRequest body, string dataset)
                {
                    return new ExportDataRequest(this.service, body, dataset);
                }

                /// <summary>Exports dataset's data to the provided output location.</summary>
                public class ExportDataRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.Operation>
                {
                    /// <summary>Constructs a new ExportData request.</summary>
                    public ExportDataRequest(Google.Apis.Services.IClientService service, Google.Apis.Translate.v3.Data.ExportDataRequest body, string dataset) : base(service)
                    {
                        Dataset = dataset;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the dataset. In form of
                    /// `projects/{project-number-or-id}/locations/{location-id}/datasets/{dataset-id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("dataset", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Dataset { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Translate.v3.Data.ExportDataRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "exportData";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v3/{+dataset}:exportData";

                    /// <summary>Initializes ExportData parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("dataset", new Google.Apis.Discovery.Parameter
                        {
                            Name = "dataset",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets a Dataset.</summary>
                /// <param name="name">Required. The resource name of the dataset to retrieve.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a Dataset.</summary>
                public class GetRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.Dataset>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the dataset to retrieve.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v3/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+$",
                        });
                    }
                }

                /// <summary>Import sentence pairs into translation Dataset.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="dataset">
                /// Required. Name of the dataset. In form of
                /// `projects/{project-number-or-id}/locations/{location-id}/datasets/{dataset-id}`
                /// </param>
                public virtual ImportDataRequest ImportData(Google.Apis.Translate.v3.Data.ImportDataRequest body, string dataset)
                {
                    return new ImportDataRequest(this.service, body, dataset);
                }

                /// <summary>Import sentence pairs into translation Dataset.</summary>
                public class ImportDataRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.Operation>
                {
                    /// <summary>Constructs a new ImportData request.</summary>
                    public ImportDataRequest(Google.Apis.Services.IClientService service, Google.Apis.Translate.v3.Data.ImportDataRequest body, string dataset) : base(service)
                    {
                        Dataset = dataset;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the dataset. In form of
                    /// `projects/{project-number-or-id}/locations/{location-id}/datasets/{dataset-id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("dataset", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Dataset { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Translate.v3.Data.ImportDataRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "importData";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v3/{+dataset}:importData";

                    /// <summary>Initializes ImportData parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("dataset", new Google.Apis.Discovery.Parameter
                        {
                            Name = "dataset",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists datasets.</summary>
                /// <param name="parent">
                /// Required. Name of the parent project. In form of
                /// `projects/{project-number-or-id}/locations/{location-id}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists datasets.</summary>
                public class ListRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.ListDatasetsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the parent project. In form of
                    /// `projects/{project-number-or-id}/locations/{location-id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Requested page size. The server can return fewer results than requested.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A token identifying a page of results for the server to return. Typically obtained
                    /// from next_page_token field in the response of a ListDatasets call.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v3/{+parent}/datasets";

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

            /// <summary>Gets the Glossaries resource.</summary>
            public virtual GlossariesResource Glossaries { get; }

            /// <summary>The "glossaries" collection of methods.</summary>
            public class GlossariesResource
            {
                private const string Resource = "glossaries";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public GlossariesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    GlossaryEntries = new GlossaryEntriesResource(service);
                }

                /// <summary>Gets the GlossaryEntries resource.</summary>
                public virtual GlossaryEntriesResource GlossaryEntries { get; }

                /// <summary>The "glossaryEntries" collection of methods.</summary>
                public class GlossaryEntriesResource
                {
                    private const string Resource = "glossaryEntries";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public GlossaryEntriesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a glossary entry.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The resource name of the glossary to create the entry under.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.Translate.v3.Data.GlossaryEntry body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a glossary entry.</summary>
                    public class CreateRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.GlossaryEntry>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Translate.v3.Data.GlossaryEntry body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the glossary to create the entry under.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Translate.v3.Data.GlossaryEntry Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v3/{+parent}/glossaryEntries";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/glossaries/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Deletes a single entry from the glossary</summary>
                    /// <param name="name">Required. The resource name of the glossary entry to delete</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a single entry from the glossary</summary>
                    public class DeleteRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the glossary entry to delete</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v3/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/glossaries/[^/]+/glossaryEntries/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets a single glossary entry by the given id.</summary>
                    /// <param name="name">Required. The resource name of the glossary entry to get</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets a single glossary entry by the given id.</summary>
                    public class GetRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.GlossaryEntry>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the glossary entry to get</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v3/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/glossaries/[^/]+/glossaryEntries/[^/]+$",
                            });
                        }
                    }

                    /// <summary>List the entries for the glossary.</summary>
                    /// <param name="parent">
                    /// Required. The parent glossary resource name for listing the glossary's entries.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>List the entries for the glossary.</summary>
                    public class ListRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.ListGlossaryEntriesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent glossary resource name for listing the glossary's entries.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Requested page size. The server may return fewer glossary entries than requested.
                        /// If unspecified, the server picks an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A token identifying a page of results the server should return. Typically, this is
                        /// the value of [ListGlossaryEntriesResponse.next_page_token] returned from the previous call.
                        /// The first page is returned if `page_token`is empty or missing.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v3/{+parent}/glossaryEntries";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/glossaries/[^/]+$",
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

                    /// <summary>Updates a glossary entry.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. The resource name of the entry. Format:
                    /// `projects/*/locations/*/glossaries/*/glossaryEntries/*`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.Translate.v3.Data.GlossaryEntry body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates a glossary entry.</summary>
                    public class PatchRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.GlossaryEntry>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Translate.v3.Data.GlossaryEntry body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. The resource name of the entry. Format:
                        /// `projects/*/locations/*/glossaries/*/glossaryEntries/*`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Translate.v3.Data.GlossaryEntry Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v3/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/glossaries/[^/]+/glossaryEntries/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>
                /// Creates a glossary and returns the long-running operation. Returns NOT_FOUND, if the project doesn't
                /// exist.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The project name.</param>
                public virtual CreateRequest Create(Google.Apis.Translate.v3.Data.Glossary body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a glossary and returns the long-running operation. Returns NOT_FOUND, if the project doesn't
                /// exist.
                /// </summary>
                public class CreateRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Translate.v3.Data.Glossary body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The project name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Translate.v3.Data.Glossary Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v3/{+parent}/glossaries";

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
                /// Deletes a glossary, or cancels glossary construction if the glossary isn't created yet. Returns
                /// NOT_FOUND, if the glossary doesn't exist.
                /// </summary>
                /// <param name="name">Required. The name of the glossary to delete.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a glossary, or cancels glossary construction if the glossary isn't created yet. Returns
                /// NOT_FOUND, if the glossary doesn't exist.
                /// </summary>
                public class DeleteRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the glossary to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v3/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/glossaries/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets a glossary. Returns NOT_FOUND, if the glossary doesn't exist.</summary>
                /// <param name="name">Required. The name of the glossary to retrieve.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a glossary. Returns NOT_FOUND, if the glossary doesn't exist.</summary>
                public class GetRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.Glossary>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the glossary to retrieve.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v3/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/glossaries/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists glossaries in a project. Returns NOT_FOUND, if the project doesn't exist.</summary>
                /// <param name="parent">
                /// Required. The name of the project from which to list all of the glossaries.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists glossaries in a project. Returns NOT_FOUND, if the project doesn't exist.</summary>
                public class ListRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.ListGlossariesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the project from which to list all of the glossaries.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Filter specifying constraints of a list operation. Specify the constraint by the
                    /// format of "key=value", where key must be "src" or "tgt", and the value must be a valid language
                    /// code. For multiple restrictions, concatenate them by "AND" (uppercase only), such as: "src=en-US
                    /// AND tgt=zh-CN". Notice that the exact match is used here, which means using 'en-US' and 'en' can
                    /// lead to different results, which depends on the language code you used when you create the
                    /// glossary. For the unidirectional glossaries, the "src" and "tgt" add restrictions on the source
                    /// and target language code separately. For the equivalent term set glossaries, the "src" and/or
                    /// "tgt" add restrictions on the term set. For example: "src=en-US AND tgt=zh-CN" will only pick
                    /// the unidirectional glossaries which exactly match the source language code as "en-US" and the
                    /// target language code "zh-CN", but all equivalent term set glossaries which contain "en-US" and
                    /// "zh-CN" in their language set will be picked. If missing, no filtering is performed.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. Requested page size. The server may return fewer glossaries than requested. If
                    /// unspecified, the server picks an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A token identifying a page of results the server should return. Typically, this is the
                    /// value of [ListGlossariesResponse.next_page_token] returned from the previous call to
                    /// `ListGlossaries` method. The first page is returned if `page_token`is empty or missing.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v3/{+parent}/glossaries";

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
                /// Updates a glossary. A LRO is used since the update can be async if the glossary's entry file is
                /// updated.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name of the glossary. Glossary names have the form
                /// `projects/{project-number-or-id}/locations/{location-id}/glossaries/{glossary-id}`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Translate.v3.Data.Glossary body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates a glossary. A LRO is used since the update can be async if the glossary's entry file is
                /// updated.
                /// </summary>
                public class PatchRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Translate.v3.Data.Glossary body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the glossary. Glossary names have the form
                    /// `projects/{project-number-or-id}/locations/{location-id}/glossaries/{glossary-id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The list of fields to be updated. Currently only `display_name` and 'input_config'
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Translate.v3.Data.Glossary Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v3/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/glossaries/[^/]+$",
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

            /// <summary>Gets the Models resource.</summary>
            public virtual ModelsResource Models { get; }

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

                /// <summary>Creates a Model.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The project name, in form of `projects/{project}/locations/{location}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Translate.v3.Data.Model body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a Model.</summary>
                public class CreateRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Translate.v3.Data.Model body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project name, in form of `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Translate.v3.Data.Model Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v3/{+parent}/models";

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

                /// <summary>Deletes a model.</summary>
                /// <param name="name">Required. The name of the model to delete.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a model.</summary>
                public class DeleteRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the model to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v3/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/models/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets a model.</summary>
                /// <param name="name">Required. The resource name of the model to retrieve.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a model.</summary>
                public class GetRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.Model>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the model to retrieve.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v3/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/models/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists models.</summary>
                /// <param name="parent">
                /// Required. Name of the parent project. In form of
                /// `projects/{project-number-or-id}/locations/{location-id}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists models.</summary>
                public class ListRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.ListModelsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the parent project. In form of
                    /// `projects/{project-number-or-id}/locations/{location-id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An expression for filtering the models that will be returned. Supported filter:
                    /// `dataset_id=${dataset_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. Requested page size. The server can return fewer results than requested.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A token identifying a page of results for the server to return. Typically obtained
                    /// from next_page_token field in the response of a ListModels call.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v3/{+parent}/models";

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

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(Google.Apis.Translate.v3.Data.CancelOperationRequest body, string name)
                {
                    return new CancelRequest(this.service, body, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
                /// </summary>
                public class CancelRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.Translate.v3.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Translate.v3.Data.CancelOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v3/{+name}:cancel";

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
                /// Deletes a long-running operation. This method indicates that the client is no longer interested in
                /// the operation result. It does not cancel the operation. If the server doesn't support this method,
                /// it returns `google.rpc.Code.UNIMPLEMENTED`.
                /// </summary>
                /// <param name="name">The name of the operation resource to be deleted.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a long-running operation. This method indicates that the client is no longer interested in
                /// the operation result. It does not cancel the operation. If the server doesn't support this method,
                /// it returns `google.rpc.Code.UNIMPLEMENTED`.
                /// </summary>
                public class DeleteRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.Empty>
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
                    public override string RestPath => "v3/{+name}";

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
                public class GetRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.Operation>
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
                    public override string RestPath => "v3/{+name}";

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
                public class ListRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.ListOperationsResponse>
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
                    public override string RestPath => "v3/{+name}/operations";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
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
                /// Waits until the specified long-running operation is done or reaches at most a specified timeout,
                /// returning the latest state. If the operation is already done, the latest state is immediately
                /// returned. If the timeout specified is greater than the default HTTP/RPC timeout, the HTTP/RPC
                /// timeout is used. If the server does not support this method, it returns
                /// `google.rpc.Code.UNIMPLEMENTED`. Note that this method is on a best-effort basis. It may return the
                /// latest state before the specified timeout (including immediately), meaning even an immediate
                /// response is no guarantee that the operation is done.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to wait on.</param>
                public virtual WaitRequest Wait(Google.Apis.Translate.v3.Data.WaitOperationRequest body, string name)
                {
                    return new WaitRequest(this.service, body, name);
                }

                /// <summary>
                /// Waits until the specified long-running operation is done or reaches at most a specified timeout,
                /// returning the latest state. If the operation is already done, the latest state is immediately
                /// returned. If the timeout specified is greater than the default HTTP/RPC timeout, the HTTP/RPC
                /// timeout is used. If the server does not support this method, it returns
                /// `google.rpc.Code.UNIMPLEMENTED`. Note that this method is on a best-effort basis. It may return the
                /// latest state before the specified timeout (including immediately), meaning even an immediate
                /// response is no guarantee that the operation is done.
                /// </summary>
                public class WaitRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.Operation>
                {
                    /// <summary>Constructs a new Wait request.</summary>
                    public WaitRequest(Google.Apis.Services.IClientService service, Google.Apis.Translate.v3.Data.WaitOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to wait on.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Translate.v3.Data.WaitOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "wait";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v3/{+name}:wait";

                    /// <summary>Initializes Wait parameter list.</summary>
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
            }

            /// <summary>Translate text using Adaptive MT.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Location to make a regional call. Format:
            /// `projects/{project-number-or-id}/locations/{location-id}`.
            /// </param>
            public virtual AdaptiveMtTranslateRequest AdaptiveMtTranslate(Google.Apis.Translate.v3.Data.AdaptiveMtTranslateRequest body, string parent)
            {
                return new AdaptiveMtTranslateRequest(this.service, body, parent);
            }

            /// <summary>Translate text using Adaptive MT.</summary>
            public class AdaptiveMtTranslateRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.AdaptiveMtTranslateResponse>
            {
                /// <summary>Constructs a new AdaptiveMtTranslate request.</summary>
                public AdaptiveMtTranslateRequest(Google.Apis.Services.IClientService service, Google.Apis.Translate.v3.Data.AdaptiveMtTranslateRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Location to make a regional call. Format:
                /// `projects/{project-number-or-id}/locations/{location-id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Translate.v3.Data.AdaptiveMtTranslateRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "adaptiveMtTranslate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+parent}:adaptiveMtTranslate";

                /// <summary>Initializes AdaptiveMtTranslate parameter list.</summary>
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
            /// Translates a large volume of document in asynchronous batch mode. This function provides real-time
            /// output as the inputs are being processed. If caller cancels a request, the partial results (for an input
            /// file, it's all or nothing) may still be available on the specified output location. This call returns
            /// immediately and you can use google.longrunning.Operation.name to poll the status of the call.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Location to make a regional call. Format:
            /// `projects/{project-number-or-id}/locations/{location-id}`. The `global` location is not supported for
            /// batch translation. Only AutoML Translation models or glossaries within the same region (have the same
            /// location-id) can be used, otherwise an INVALID_ARGUMENT (400) error is returned.
            /// </param>
            public virtual BatchTranslateDocumentRequest BatchTranslateDocument(Google.Apis.Translate.v3.Data.BatchTranslateDocumentRequest body, string parent)
            {
                return new BatchTranslateDocumentRequest(this.service, body, parent);
            }

            /// <summary>
            /// Translates a large volume of document in asynchronous batch mode. This function provides real-time
            /// output as the inputs are being processed. If caller cancels a request, the partial results (for an input
            /// file, it's all or nothing) may still be available on the specified output location. This call returns
            /// immediately and you can use google.longrunning.Operation.name to poll the status of the call.
            /// </summary>
            public class BatchTranslateDocumentRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.Operation>
            {
                /// <summary>Constructs a new BatchTranslateDocument request.</summary>
                public BatchTranslateDocumentRequest(Google.Apis.Services.IClientService service, Google.Apis.Translate.v3.Data.BatchTranslateDocumentRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Location to make a regional call. Format:
                /// `projects/{project-number-or-id}/locations/{location-id}`. The `global` location is not supported
                /// for batch translation. Only AutoML Translation models or glossaries within the same region (have the
                /// same location-id) can be used, otherwise an INVALID_ARGUMENT (400) error is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Translate.v3.Data.BatchTranslateDocumentRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchTranslateDocument";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+parent}:batchTranslateDocument";

                /// <summary>Initializes BatchTranslateDocument parameter list.</summary>
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
            /// Translates a large volume of text in asynchronous batch mode. This function provides real-time output as
            /// the inputs are being processed. If caller cancels a request, the partial results (for an input file,
            /// it's all or nothing) may still be available on the specified output location. This call returns
            /// immediately and you can use google.longrunning.Operation.name to poll the status of the call.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Location to make a call. Must refer to a caller's project. Format:
            /// `projects/{project-number-or-id}/locations/{location-id}`. The `global` location is not supported for
            /// batch translation. Only AutoML Translation models or glossaries within the same region (have the same
            /// location-id) can be used, otherwise an INVALID_ARGUMENT (400) error is returned.
            /// </param>
            public virtual BatchTranslateTextRequest BatchTranslateText(Google.Apis.Translate.v3.Data.BatchTranslateTextRequest body, string parent)
            {
                return new BatchTranslateTextRequest(this.service, body, parent);
            }

            /// <summary>
            /// Translates a large volume of text in asynchronous batch mode. This function provides real-time output as
            /// the inputs are being processed. If caller cancels a request, the partial results (for an input file,
            /// it's all or nothing) may still be available on the specified output location. This call returns
            /// immediately and you can use google.longrunning.Operation.name to poll the status of the call.
            /// </summary>
            public class BatchTranslateTextRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.Operation>
            {
                /// <summary>Constructs a new BatchTranslateText request.</summary>
                public BatchTranslateTextRequest(Google.Apis.Services.IClientService service, Google.Apis.Translate.v3.Data.BatchTranslateTextRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Location to make a call. Must refer to a caller's project. Format:
                /// `projects/{project-number-or-id}/locations/{location-id}`. The `global` location is not supported
                /// for batch translation. Only AutoML Translation models or glossaries within the same region (have the
                /// same location-id) can be used, otherwise an INVALID_ARGUMENT (400) error is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Translate.v3.Data.BatchTranslateTextRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchTranslateText";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+parent}:batchTranslateText";

                /// <summary>Initializes BatchTranslateText parameter list.</summary>
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

            /// <summary>Detects the language of text within a request.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Project or location to make a call. Must refer to a caller's project. Format:
            /// `projects/{project-number-or-id}/locations/{location-id}` or `projects/{project-number-or-id}`. For
            /// global calls, use `projects/{project-number-or-id}/locations/global` or
            /// `projects/{project-number-or-id}`. Only models within the same region (has same location-id) can be
            /// used. Otherwise an INVALID_ARGUMENT (400) error is returned.
            /// </param>
            public virtual DetectLanguageRequest DetectLanguage(Google.Apis.Translate.v3.Data.DetectLanguageRequest body, string parent)
            {
                return new DetectLanguageRequest(this.service, body, parent);
            }

            /// <summary>Detects the language of text within a request.</summary>
            public class DetectLanguageRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.DetectLanguageResponse>
            {
                /// <summary>Constructs a new DetectLanguage request.</summary>
                public DetectLanguageRequest(Google.Apis.Services.IClientService service, Google.Apis.Translate.v3.Data.DetectLanguageRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Project or location to make a call. Must refer to a caller's project. Format:
                /// `projects/{project-number-or-id}/locations/{location-id}` or `projects/{project-number-or-id}`. For
                /// global calls, use `projects/{project-number-or-id}/locations/global` or
                /// `projects/{project-number-or-id}`. Only models within the same region (has same location-id) can be
                /// used. Otherwise an INVALID_ARGUMENT (400) error is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Translate.v3.Data.DetectLanguageRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "detectLanguage";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+parent}:detectLanguage";

                /// <summary>Initializes DetectLanguage parameter list.</summary>
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
            public class GetRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.Location>
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
                public override string RestPath => "v3/{+name}";

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

            /// <summary>Returns a list of supported languages for translation.</summary>
            /// <param name="parent">
            /// Required. Project or location to make a call. Must refer to a caller's project. Format:
            /// `projects/{project-number-or-id}` or `projects/{project-number-or-id}/locations/{location-id}`. For
            /// global calls, use `projects/{project-number-or-id}/locations/global` or
            /// `projects/{project-number-or-id}`. Non-global location is required for AutoML models. Only models within
            /// the same region (have same location-id) can be used, otherwise an INVALID_ARGUMENT (400) error is
            /// returned.
            /// </param>
            public virtual GetSupportedLanguagesRequest GetSupportedLanguages(string parent)
            {
                return new GetSupportedLanguagesRequest(this.service, parent);
            }

            /// <summary>Returns a list of supported languages for translation.</summary>
            public class GetSupportedLanguagesRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.SupportedLanguages>
            {
                /// <summary>Constructs a new GetSupportedLanguages request.</summary>
                public GetSupportedLanguagesRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Project or location to make a call. Must refer to a caller's project. Format:
                /// `projects/{project-number-or-id}` or `projects/{project-number-or-id}/locations/{location-id}`. For
                /// global calls, use `projects/{project-number-or-id}/locations/global` or
                /// `projects/{project-number-or-id}`. Non-global location is required for AutoML models. Only models
                /// within the same region (have same location-id) can be used, otherwise an INVALID_ARGUMENT (400)
                /// error is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The language to use to return localized, human readable names of supported languages. If
                /// missing, then display names are not returned in a response.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("displayLanguageCode", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string DisplayLanguageCode { get; set; }

                /// <summary>
                /// Optional. Get supported languages of this model. The format depends on model type: - AutoML
                /// Translation models: `projects/{project-number-or-id}/locations/{location-id}/models/{model-id}` -
                /// General (built-in) models:
                /// `projects/{project-number-or-id}/locations/{location-id}/models/general/nmt`, Returns languages
                /// supported by the specified model. If missing, we get supported languages of Google general NMT
                /// model.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("model", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Model { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getSupportedLanguages";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+parent}/supportedLanguages";

                /// <summary>Initializes GetSupportedLanguages parameter list.</summary>
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
                    RequestParameters.Add("displayLanguageCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "displayLanguageCode",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("model", new Google.Apis.Discovery.Parameter
                    {
                        Name = "model",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
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
            public class ListRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.ListLocationsResponse>
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
                /// Optional. A list of extra location types that should be used as conditions for controlling the
                /// visibility of the locations.
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
                public override string RestPath => "v3/{+name}/locations";

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

            /// <summary>Romanize input text written in non-Latin scripts to Latin text.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Project or location to make a call. Must refer to a caller's project. Format:
            /// `projects/{project-number-or-id}/locations/{location-id}` or `projects/{project-number-or-id}`. For
            /// global calls, use `projects/{project-number-or-id}/locations/global` or
            /// `projects/{project-number-or-id}`.
            /// </param>
            public virtual RomanizeTextRequest RomanizeText(Google.Apis.Translate.v3.Data.RomanizeTextRequest body, string parent)
            {
                return new RomanizeTextRequest(this.service, body, parent);
            }

            /// <summary>Romanize input text written in non-Latin scripts to Latin text.</summary>
            public class RomanizeTextRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.RomanizeTextResponse>
            {
                /// <summary>Constructs a new RomanizeText request.</summary>
                public RomanizeTextRequest(Google.Apis.Services.IClientService service, Google.Apis.Translate.v3.Data.RomanizeTextRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Project or location to make a call. Must refer to a caller's project. Format:
                /// `projects/{project-number-or-id}/locations/{location-id}` or `projects/{project-number-or-id}`. For
                /// global calls, use `projects/{project-number-or-id}/locations/global` or
                /// `projects/{project-number-or-id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Translate.v3.Data.RomanizeTextRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "romanizeText";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+parent}:romanizeText";

                /// <summary>Initializes RomanizeText parameter list.</summary>
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

            /// <summary>Translates documents in synchronous mode.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Location to make a regional call. Format:
            /// `projects/{project-number-or-id}/locations/{location-id}`. For global calls, use
            /// `projects/{project-number-or-id}/locations/global` or `projects/{project-number-or-id}`. Non-global
            /// location is required for requests using AutoML models or custom glossaries. Models and glossaries must
            /// be within the same region (have the same location-id), otherwise an INVALID_ARGUMENT (400) error is
            /// returned.
            /// </param>
            public virtual TranslateDocumentRequest TranslateDocument(Google.Apis.Translate.v3.Data.TranslateDocumentRequest body, string parent)
            {
                return new TranslateDocumentRequest(this.service, body, parent);
            }

            /// <summary>Translates documents in synchronous mode.</summary>
            public class TranslateDocumentRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.TranslateDocumentResponse>
            {
                /// <summary>Constructs a new TranslateDocument request.</summary>
                public TranslateDocumentRequest(Google.Apis.Services.IClientService service, Google.Apis.Translate.v3.Data.TranslateDocumentRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Location to make a regional call. Format:
                /// `projects/{project-number-or-id}/locations/{location-id}`. For global calls, use
                /// `projects/{project-number-or-id}/locations/global` or `projects/{project-number-or-id}`. Non-global
                /// location is required for requests using AutoML models or custom glossaries. Models and glossaries
                /// must be within the same region (have the same location-id), otherwise an INVALID_ARGUMENT (400)
                /// error is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Translate.v3.Data.TranslateDocumentRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "translateDocument";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+parent}:translateDocument";

                /// <summary>Initializes TranslateDocument parameter list.</summary>
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

            /// <summary>Translates input text and returns translated text.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Project or location to make a call. Must refer to a caller's project. Format:
            /// `projects/{project-number-or-id}` or `projects/{project-number-or-id}/locations/{location-id}`. For
            /// global calls, use `projects/{project-number-or-id}/locations/global` or
            /// `projects/{project-number-or-id}`. Non-global location is required for requests using AutoML models or
            /// custom glossaries. Models and glossaries must be within the same region (have same location-id),
            /// otherwise an INVALID_ARGUMENT (400) error is returned.
            /// </param>
            public virtual TranslateTextRequest TranslateText(Google.Apis.Translate.v3.Data.TranslateTextRequest body, string parent)
            {
                return new TranslateTextRequest(this.service, body, parent);
            }

            /// <summary>Translates input text and returns translated text.</summary>
            public class TranslateTextRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.TranslateTextResponse>
            {
                /// <summary>Constructs a new TranslateText request.</summary>
                public TranslateTextRequest(Google.Apis.Services.IClientService service, Google.Apis.Translate.v3.Data.TranslateTextRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Project or location to make a call. Must refer to a caller's project. Format:
                /// `projects/{project-number-or-id}` or `projects/{project-number-or-id}/locations/{location-id}`. For
                /// global calls, use `projects/{project-number-or-id}/locations/global` or
                /// `projects/{project-number-or-id}`. Non-global location is required for requests using AutoML models
                /// or custom glossaries. Models and glossaries must be within the same region (have same location-id),
                /// otherwise an INVALID_ARGUMENT (400) error is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Translate.v3.Data.TranslateTextRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "translateText";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+parent}:translateText";

                /// <summary>Initializes TranslateText parameter list.</summary>
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
        }

        /// <summary>Detects the language of text within a request.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's project. Format:
        /// `projects/{project-number-or-id}/locations/{location-id}` or `projects/{project-number-or-id}`. For global
        /// calls, use `projects/{project-number-or-id}/locations/global` or `projects/{project-number-or-id}`. Only
        /// models within the same region (has same location-id) can be used. Otherwise an INVALID_ARGUMENT (400) error
        /// is returned.
        /// </param>
        public virtual DetectLanguageRequest DetectLanguage(Google.Apis.Translate.v3.Data.DetectLanguageRequest body, string parent)
        {
            return new DetectLanguageRequest(this.service, body, parent);
        }

        /// <summary>Detects the language of text within a request.</summary>
        public class DetectLanguageRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.DetectLanguageResponse>
        {
            /// <summary>Constructs a new DetectLanguage request.</summary>
            public DetectLanguageRequest(Google.Apis.Services.IClientService service, Google.Apis.Translate.v3.Data.DetectLanguageRequest body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. Project or location to make a call. Must refer to a caller's project. Format:
            /// `projects/{project-number-or-id}/locations/{location-id}` or `projects/{project-number-or-id}`. For
            /// global calls, use `projects/{project-number-or-id}/locations/global` or
            /// `projects/{project-number-or-id}`. Only models within the same region (has same location-id) can be
            /// used. Otherwise an INVALID_ARGUMENT (400) error is returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Translate.v3.Data.DetectLanguageRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "detectLanguage";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+parent}:detectLanguage";

            /// <summary>Initializes DetectLanguage parameter list.</summary>
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

        /// <summary>Returns a list of supported languages for translation.</summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's project. Format:
        /// `projects/{project-number-or-id}` or `projects/{project-number-or-id}/locations/{location-id}`. For global
        /// calls, use `projects/{project-number-or-id}/locations/global` or `projects/{project-number-or-id}`.
        /// Non-global location is required for AutoML models. Only models within the same region (have same
        /// location-id) can be used, otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        public virtual GetSupportedLanguagesRequest GetSupportedLanguages(string parent)
        {
            return new GetSupportedLanguagesRequest(this.service, parent);
        }

        /// <summary>Returns a list of supported languages for translation.</summary>
        public class GetSupportedLanguagesRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.SupportedLanguages>
        {
            /// <summary>Constructs a new GetSupportedLanguages request.</summary>
            public GetSupportedLanguagesRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
            {
                Parent = parent;
                InitParameters();
            }

            /// <summary>
            /// Required. Project or location to make a call. Must refer to a caller's project. Format:
            /// `projects/{project-number-or-id}` or `projects/{project-number-or-id}/locations/{location-id}`. For
            /// global calls, use `projects/{project-number-or-id}/locations/global` or
            /// `projects/{project-number-or-id}`. Non-global location is required for AutoML models. Only models within
            /// the same region (have same location-id) can be used, otherwise an INVALID_ARGUMENT (400) error is
            /// returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// Optional. The language to use to return localized, human readable names of supported languages. If
            /// missing, then display names are not returned in a response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("displayLanguageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DisplayLanguageCode { get; set; }

            /// <summary>
            /// Optional. Get supported languages of this model. The format depends on model type: - AutoML Translation
            /// models: `projects/{project-number-or-id}/locations/{location-id}/models/{model-id}` - General (built-in)
            /// models: `projects/{project-number-or-id}/locations/{location-id}/models/general/nmt`, Returns languages
            /// supported by the specified model. If missing, we get supported languages of Google general NMT model.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("model", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Model { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getSupportedLanguages";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+parent}/supportedLanguages";

            /// <summary>Initializes GetSupportedLanguages parameter list.</summary>
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
                RequestParameters.Add("displayLanguageCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "displayLanguageCode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("model", new Google.Apis.Discovery.Parameter
                {
                    Name = "model",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Romanize input text written in non-Latin scripts to Latin text.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's project. Format:
        /// `projects/{project-number-or-id}/locations/{location-id}` or `projects/{project-number-or-id}`. For global
        /// calls, use `projects/{project-number-or-id}/locations/global` or `projects/{project-number-or-id}`.
        /// </param>
        public virtual RomanizeTextRequest RomanizeText(Google.Apis.Translate.v3.Data.RomanizeTextRequest body, string parent)
        {
            return new RomanizeTextRequest(this.service, body, parent);
        }

        /// <summary>Romanize input text written in non-Latin scripts to Latin text.</summary>
        public class RomanizeTextRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.RomanizeTextResponse>
        {
            /// <summary>Constructs a new RomanizeText request.</summary>
            public RomanizeTextRequest(Google.Apis.Services.IClientService service, Google.Apis.Translate.v3.Data.RomanizeTextRequest body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. Project or location to make a call. Must refer to a caller's project. Format:
            /// `projects/{project-number-or-id}/locations/{location-id}` or `projects/{project-number-or-id}`. For
            /// global calls, use `projects/{project-number-or-id}/locations/global` or
            /// `projects/{project-number-or-id}`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Translate.v3.Data.RomanizeTextRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "romanizeText";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+parent}:romanizeText";

            /// <summary>Initializes RomanizeText parameter list.</summary>
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

        /// <summary>Translates input text and returns translated text.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's project. Format:
        /// `projects/{project-number-or-id}` or `projects/{project-number-or-id}/locations/{location-id}`. For global
        /// calls, use `projects/{project-number-or-id}/locations/global` or `projects/{project-number-or-id}`.
        /// Non-global location is required for requests using AutoML models or custom glossaries. Models and glossaries
        /// must be within the same region (have same location-id), otherwise an INVALID_ARGUMENT (400) error is
        /// returned.
        /// </param>
        public virtual TranslateTextRequest TranslateText(Google.Apis.Translate.v3.Data.TranslateTextRequest body, string parent)
        {
            return new TranslateTextRequest(this.service, body, parent);
        }

        /// <summary>Translates input text and returns translated text.</summary>
        public class TranslateTextRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v3.Data.TranslateTextResponse>
        {
            /// <summary>Constructs a new TranslateText request.</summary>
            public TranslateTextRequest(Google.Apis.Services.IClientService service, Google.Apis.Translate.v3.Data.TranslateTextRequest body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. Project or location to make a call. Must refer to a caller's project. Format:
            /// `projects/{project-number-or-id}` or `projects/{project-number-or-id}/locations/{location-id}`. For
            /// global calls, use `projects/{project-number-or-id}/locations/global` or
            /// `projects/{project-number-or-id}`. Non-global location is required for requests using AutoML models or
            /// custom glossaries. Models and glossaries must be within the same region (have same location-id),
            /// otherwise an INVALID_ARGUMENT (400) error is returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Translate.v3.Data.TranslateTextRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "translateText";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+parent}:translateText";

            /// <summary>Initializes TranslateText parameter list.</summary>
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
    }
}
namespace Google.Apis.Translate.v3.Data
{
    /// <summary>An Adaptive MT Dataset.</summary>
    public class AdaptiveMtDataset : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp when this dataset was created.</summary>
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
        /// The name of the dataset to show in the interface. The name can be up to 32 characters long and can consist
        /// only of ASCII Latin letters A-Z and a-z, underscores (_), and ASCII digits 0-9.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The number of examples in the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exampleCount")]
        public virtual System.Nullable<int> ExampleCount { get; set; }

        /// <summary>
        /// Required. The resource name of the dataset, in form of
        /// `projects/{project-number-or-id}/locations/{location_id}/adaptiveMtDatasets/{dataset_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The BCP-47 language code of the source language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceLanguageCode")]
        public virtual string SourceLanguageCode { get; set; }

        /// <summary>The BCP-47 language code of the target language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetLanguageCode")]
        public virtual string TargetLanguageCode { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Timestamp when this dataset was last updated.</summary>
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

    /// <summary>An AdaptiveMtFile.</summary>
    public class AdaptiveMtFile : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp when this file was created.</summary>
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

        /// <summary>The file's display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The number of entries that the file contains.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entryCount")]
        public virtual System.Nullable<int> EntryCount { get; set; }

        /// <summary>
        /// Required. The resource name of the file, in form of
        /// `projects/{project-number-or-id}/locations/{location_id}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Timestamp when this file was last updated.</summary>
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

    /// <summary>An AdaptiveMt sentence entry.</summary>
    public class AdaptiveMtSentence : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp when this sentence was created.</summary>
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
        /// Required. The resource name of the file, in form of
        /// `projects/{project-number-or-id}/locations/{location_id}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}/adaptiveMtSentences/{sentence}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The source sentence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceSentence")]
        public virtual string SourceSentence { get; set; }

        /// <summary>Required. The target sentence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetSentence")]
        public virtual string TargetSentence { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Timestamp when this sentence was last updated.</summary>
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

    /// <summary>The request for sending an AdaptiveMt translation query.</summary>
    public class AdaptiveMtTranslateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The content of the input in string format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual System.Collections.Generic.IList<string> Content { get; set; }

        /// <summary>
        /// Required. The resource name for the dataset to use for adaptive MT.
        /// `projects/{project}/locations/{location-id}/adaptiveMtDatasets/{dataset}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>
        /// Optional. Glossary to be applied. The glossary must be within the same region (have the same location-id) as
        /// the model, otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glossaryConfig")]
        public virtual GlossaryConfig GlossaryConfig { get; set; }

        /// <summary>Configuration for caller provided reference sentences.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceSentenceConfig")]
        public virtual ReferenceSentenceConfig ReferenceSentenceConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An AdaptiveMtTranslate response.</summary>
    public class AdaptiveMtTranslateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Text translation response if a glossary is provided in the request. This could be the same as 'translation'
        /// above if no terms apply.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glossaryTranslations")]
        public virtual System.Collections.Generic.IList<AdaptiveMtTranslation> GlossaryTranslations { get; set; }

        /// <summary>Output only. The translation's language code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Output only. The translation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("translations")]
        public virtual System.Collections.Generic.IList<AdaptiveMtTranslation> Translations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An AdaptiveMt translation.</summary>
    public class AdaptiveMtTranslation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The translated text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("translatedText")]
        public virtual string TranslatedText { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Input configuration for BatchTranslateDocument request.</summary>
    public class BatchDocumentInputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Storage location for the source input. This can be a single file (for example,
        /// `gs://translation-test/input.docx`) or a wildcard (for example, `gs://translation-test/*`). File mime type
        /// is determined based on extension. Supported mime type includes: - `pdf`, application/pdf - `docx`,
        /// application/vnd.openxmlformats-officedocument.wordprocessingml.document - `pptx`,
        /// application/vnd.openxmlformats-officedocument.presentationml.presentation - `xlsx`,
        /// application/vnd.openxmlformats-officedocument.spreadsheetml.sheet The max file size to support for `.docx`,
        /// `.pptx` and `.xlsx` is 100MB. The max file size to support for `.pdf` is 1GB and the max page limit is 1000
        /// pages. The max file size to support for all input documents is 1GB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GcsSource GcsSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output configuration for BatchTranslateDocument request.</summary>
    public class BatchDocumentOutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Storage destination for output content. For every single input document (for example,
        /// gs://a/b/c.[extension]), we generate at most 2 * n output files. (n is the # of target_language_codes in the
        /// BatchTranslateDocumentRequest). While the input documents are being processed, we write/update an index file
        /// `index.csv` under `gcs_destination.output_uri_prefix` (for example, gs://translation_output/index.csv) The
        /// index file is generated/updated as new files are being translated. The format is:
        /// input_document,target_language_code,translation_output,error_output,
        /// glossary_translation_output,glossary_error_output `input_document` is one file we matched using
        /// gcs_source.input_uri. `target_language_code` is provided in the request. `translation_output` contains the
        /// translations. (details provided below) `error_output` contains the error message during processing of the
        /// file. Both translations_file and errors_file could be empty strings if we have no content to output.
        /// `glossary_translation_output` and `glossary_error_output` are the translated output/error when we apply
        /// glossaries. They could also be empty if we have no content to output. Once a row is present in index.csv,
        /// the input/output matching never changes. Callers should also expect all the content in input_file are
        /// processed and ready to be consumed (that is, no partial output file is written). Since index.csv will be
        /// keeping updated during the process, please make sure there is no custom retention policy applied on the
        /// output bucket that may avoid file updating.
        /// (https://cloud.google.com/storage/docs/bucket-lock#retention-policy) The naming format of translation output
        /// files follows (for target language code [trg]): `translation_output`:
        /// `gs://translation_output/a_b_c_[trg]_translation.[extension]` `glossary_translation_output`:
        /// `gs://translation_test/a_b_c_[trg]_glossary_translation.[extension]`. The output document will maintain the
        /// same file format as the input document. The naming format of error output files follows (for target language
        /// code [trg]): `error_output`: `gs://translation_test/a_b_c_[trg]_errors.txt` `glossary_error_output`:
        /// `gs://translation_test/a_b_c_[trg]_glossary_translation.txt`. The error output is a txt file containing
        /// error details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual GcsDestination GcsDestination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The BatchTranslateDocument request.</summary>
    public class BatchTranslateDocumentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. This flag is to support user customized attribution. If not provided, the default is `Machine
        /// Translated by Google`. Customized attribution should follow rules in
        /// https://cloud.google.com/translate/attribution#attribution_and_logos
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customizedAttribution")]
        public virtual string CustomizedAttribution { get; set; }

        /// <summary>Optional. If true, enable auto rotation correction in DVS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableRotationCorrection")]
        public virtual System.Nullable<bool> EnableRotationCorrection { get; set; }

        /// <summary>
        /// Optional. If true, use the text removal server to remove the shadow text on background image for native pdf
        /// translation. Shadow removal feature can only be enabled when is_translate_native_pdf_only: false
        /// &amp;amp;&amp;amp; pdf_native_only: false
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableShadowRemovalNativePdf")]
        public virtual System.Nullable<bool> EnableShadowRemovalNativePdf { get; set; }

        /// <summary>
        /// Optional. The file format conversion map that is applied to all input files. The map key is the original
        /// mime_type. The map value is the target mime_type of translated documents. Supported file format conversion
        /// includes: - `application/pdf` to `application/vnd.openxmlformats-officedocument.wordprocessingml.document`
        /// If nothing specified, output files will be in the same format as the original file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formatConversions")]
        public virtual System.Collections.Generic.IDictionary<string, string> FormatConversions { get; set; }

        /// <summary>Optional. Glossaries to be applied. It's keyed by target language code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glossaries")]
        public virtual System.Collections.Generic.IDictionary<string, TranslateTextGlossaryConfig> Glossaries { get; set; }

        /// <summary>
        /// Required. Input configurations. The total number of files matched should be &amp;lt;= 100. The total content
        /// size to translate should be &amp;lt;= 100M Unicode codepoints. The files must use UTF-8 encoding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfigs")]
        public virtual System.Collections.Generic.IList<BatchDocumentInputConfig> InputConfigs { get; set; }

        /// <summary>
        /// Optional. The models to use for translation. Map's key is target language code. Map's value is the model
        /// name. Value can be a built-in general model, or an AutoML Translation model. The value format depends on
        /// model type: - AutoML Translation models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/{model-id}` - General (built-in) models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/general/nmt`, If the map is empty or a
        /// specific model is not requested for a language pair, then default google model (nmt) is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("models")]
        public virtual System.Collections.Generic.IDictionary<string, string> Models { get; set; }

        /// <summary>
        /// Required. Output configuration. If 2 input configs match to the same file (that is, same input path), we
        /// don't generate output for duplicate inputs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual BatchDocumentOutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Required. The ISO-639 language code of the input document if known, for example, "en-US" or "sr-Latn".
        /// Supported language codes are listed in [Language
        /// Support](https://cloud.google.com/translate/docs/languages).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceLanguageCode")]
        public virtual string SourceLanguageCode { get; set; }

        /// <summary>
        /// Required. The ISO-639 language code to use for translation of the input document. Specify up to 10 language
        /// codes here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetLanguageCodes")]
        public virtual System.Collections.Generic.IList<string> TargetLanguageCodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The batch translation request.</summary>
    public class BatchTranslateTextRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Glossaries to be applied for translation. It's keyed by target language code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glossaries")]
        public virtual System.Collections.Generic.IDictionary<string, TranslateTextGlossaryConfig> Glossaries { get; set; }

        /// <summary>
        /// Required. Input configurations. The total number of files matched should be &amp;lt;= 100. The total content
        /// size should be &amp;lt;= 100M Unicode codepoints. The files must use UTF-8 encoding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfigs")]
        public virtual System.Collections.Generic.IList<InputConfig> InputConfigs { get; set; }

        /// <summary>
        /// Optional. The labels with user-defined metadata for the request. Label keys and values can be no longer than
        /// 63 characters (Unicode codepoints), can only contain lowercase letters, numeric characters, underscores and
        /// dashes. International characters are allowed. Label values are optional. Label keys must start with a
        /// letter. See https://cloud.google.com/translate/docs/advanced/labels for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. The models to use for translation. Map's key is target language code. Map's value is model name.
        /// Value can be a built-in general model, or an AutoML Translation model. The value format depends on model
        /// type: - AutoML Translation models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/{model-id}` - General (built-in) models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/general/nmt`, If the map is empty or a
        /// specific model is not requested for a language pair, then default google model (nmt) is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("models")]
        public virtual System.Collections.Generic.IDictionary<string, string> Models { get; set; }

        /// <summary>
        /// Required. Output configuration. If 2 input configs match to the same file (that is, same input path), we
        /// don't generate output for duplicate inputs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual OutputConfig OutputConfig { get; set; }

        /// <summary>Required. Source language code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceLanguageCode")]
        public virtual string SourceLanguageCode { get; set; }

        /// <summary>Required. Specify up to 10 language codes here.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetLanguageCodes")]
        public virtual System.Collections.Generic.IList<string> TargetLanguageCodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A dataset that hosts the examples (sentence pairs) used for translation models.</summary>
    public class Dataset : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp when this dataset was created.</summary>
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
        /// The name of the dataset to show in the interface. The name can be up to 32 characters long and can consist
        /// only of ASCII Latin letters A-Z and a-z, underscores (_), and ASCII digits 0-9.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. The number of examples in the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exampleCount")]
        public virtual System.Nullable<int> ExampleCount { get; set; }

        /// <summary>
        /// The resource name of the dataset, in form of
        /// `projects/{project-number-or-id}/locations/{location_id}/datasets/{dataset_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The BCP-47 language code of the source language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceLanguageCode")]
        public virtual string SourceLanguageCode { get; set; }

        /// <summary>The BCP-47 language code of the target language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetLanguageCode")]
        public virtual string TargetLanguageCode { get; set; }

        /// <summary>Output only. Number of test examples (sentence pairs).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testExampleCount")]
        public virtual System.Nullable<int> TestExampleCount { get; set; }

        /// <summary>Output only. Number of training examples (sentence pairs).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainExampleCount")]
        public virtual System.Nullable<int> TrainExampleCount { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Timestamp when this dataset was last updated.</summary>
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

        /// <summary>Output only. Number of validation examples (sentence pairs).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateExampleCount")]
        public virtual System.Nullable<int> ValidateExampleCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Input configuration for datasets.</summary>
    public class DatasetInputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Files containing the sentence pairs to be imported to the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputFiles")]
        public virtual System.Collections.Generic.IList<InputFile> InputFiles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output configuration for datasets.</summary>
    public class DatasetOutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Google Cloud Storage destination to write the output.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual GcsOutputDestination GcsDestination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for language detection.</summary>
    public class DetectLanguageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The content of the input stored as a string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>
        /// Optional. The labels with user-defined metadata for the request. Label keys and values can be no longer than
        /// 63 characters (Unicode codepoints), can only contain lowercase letters, numeric characters, underscores and
        /// dashes. International characters are allowed. Label values are optional. Label keys must start with a
        /// letter. See https://cloud.google.com/translate/docs/advanced/labels for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. The format of the source text, for example, "text/html", "text/plain". If left blank, the MIME
        /// type defaults to "text/html".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>
        /// Optional. The language detection model to be used. Format:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/language-detection/{model-id}` Only one
        /// language detection model is currently supported:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/language-detection/default`. If not
        /// specified, the default model is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for language detection.</summary>
    public class DetectLanguageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The most probable language detected by the Translation API. For each request, the Translation API will
        /// always return only one result.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languages")]
        public virtual System.Collections.Generic.IList<DetectedLanguage> Languages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for language detection.</summary>
    public class DetectedLanguage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The confidence of the detection result for this language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>The ISO-639 language code of the source content in the request, detected automatically.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A document translation request input config.</summary>
    public class DocumentInputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Document's content represented as a stream of bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>
        /// Google Cloud Storage location. This must be a single file. For example: gs://example_bucket/example_file.pdf
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GcsSource GcsSource { get; set; }

        /// <summary>
        /// Specifies the input document's mime_type. If not specified it will be determined using the file extension
        /// for gcs_source provided files. For a file provided through bytes content the mime_type must be provided.
        /// Currently supported mime types are: - application/pdf -
        /// application/vnd.openxmlformats-officedocument.wordprocessingml.document -
        /// application/vnd.openxmlformats-officedocument.presentationml.presentation -
        /// application/vnd.openxmlformats-officedocument.spreadsheetml.sheet
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A document translation request output config.</summary>
    public class DocumentOutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Google Cloud Storage destination for the translation output, e.g., `gs://my_bucket/my_directory/`.
        /// The destination directory provided does not have to be empty, but the bucket must exist. If a file with the
        /// same name as the output file already exists in the destination an error will be returned. For a
        /// DocumentInputConfig.contents provided document, the output file will have the name
        /// "output_[trg]_translations.[ext]", where - [trg] corresponds to the translated file's language code, - [ext]
        /// corresponds to the translated file's extension according to its mime type. For a DocumentInputConfig.gcs_uri
        /// provided document, the output file will have a name according to its URI. For example: an input file with
        /// URI: `gs://a/b/c.[extension]` stored in a gcs_destination bucket with name "my_bucket" will have an output
        /// URI: `gs://my_bucket/a_b_c_[trg]_translations.[ext]`, where - [trg] corresponds to the translated file's
        /// language code, - [ext] corresponds to the translated file's extension according to its mime type. If the
        /// document was directly provided through the request, then the output document will have the format:
        /// `gs://my_bucket/translated_document_[trg]_translations.[ext]`, where - [trg] corresponds to the translated
        /// file's language code, - [ext] corresponds to the translated file's extension according to its mime type. If
        /// a glossary was provided, then the output URI for the glossary translation will be equal to the default
        /// output URI but have `glossary_translations` instead of `translations`. For the previous example, its
        /// glossary URI would be: `gs://my_bucket/a_b_c_[trg]_glossary_translations.[ext]`. Thus the max number of
        /// output files will be 2 (Translated document, Glossary translated document). Callers should expect no partial
        /// outputs. If there is any error during document translation, no output will be stored in the Cloud Storage
        /// bucket.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual GcsDestination GcsDestination { get; set; }

        /// <summary>
        /// Optional. Specifies the translated document's mime_type. If not specified, the translated file's mime type
        /// will be the same as the input file's mime type. Currently only support the output mime type to be the same
        /// as input mime type. - application/pdf -
        /// application/vnd.openxmlformats-officedocument.wordprocessingml.document -
        /// application/vnd.openxmlformats-officedocument.presentationml.presentation -
        /// application/vnd.openxmlformats-officedocument.spreadsheetml.sheet
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A translated document message.</summary>
    public class DocumentTranslation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The array of translated documents. It is expected to be size 1 for now. We may produce multiple translated
        /// documents in the future for other type of file formats.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("byteStreamOutputs")]
        public virtual System.Collections.Generic.IList<string> ByteStreamOutputs { get; set; }

        /// <summary>
        /// The detected language for the input document. If the user did not provide the source language for the input
        /// document, this field will have the language code automatically detected. If the source language was passed,
        /// auto-detection of the language does not occur and this field is empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguageCode")]
        public virtual string DetectedLanguageCode { get; set; }

        /// <summary>The translated document's mime type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

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

    /// <summary>A sentence pair.</summary>
    public class Example : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The resource name of the example, in form of
        /// `projects/{project-number-or-id}/locations/{location_id}/datasets/{dataset_id}/examples/{example_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Sentence in source language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceText")]
        public virtual string SourceText { get; set; }

        /// <summary>Sentence in target language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetText")]
        public virtual string TargetText { get; set; }

        /// <summary>Output only. Usage of the sentence pair. Options are TRAIN|VALIDATION|TEST.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usage")]
        public virtual string Usage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ExportData.</summary>
    public class ExportDataRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The config for the output content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual DatasetOutputConfig OutputConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An inlined file.</summary>
    public class FileInputSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The file's byte contents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>Required. The file's display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Required. The file's mime type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Google Cloud Storage location for the output content.</summary>
    public class GcsDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The bucket used in 'output_uri_prefix' must exist and there must be no files under
        /// 'output_uri_prefix'. 'output_uri_prefix' must end with "/" and start with "gs://". One 'output_uri_prefix'
        /// can only be used by one batch translation job at a time. Otherwise an INVALID_ARGUMENT (400) error is
        /// returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputUriPrefix")]
        public virtual string OutputUriPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Google Cloud Storage location for the input content.</summary>
    public class GcsInputSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Source data URI. For example, `gs://my_bucket/my_object`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUri")]
        public virtual string InputUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Google Cloud Storage location for the output content.</summary>
    public class GcsOutputDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Google Cloud Storage URI to output directory. For example, `gs://bucket/directory`. The requesting
        /// user must have write permission to the bucket. The directory will be created if it doesn't exist.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputUriPrefix")]
        public virtual string OutputUriPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Google Cloud Storage location for the input content.</summary>
    public class GcsSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Source data URI. For example, `gs://my_bucket/my_object`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUri")]
        public virtual string InputUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a glossary built from user-provided data.</summary>
    public class Glossary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The display name of the glossary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. When the glossary creation was finished.</summary>
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

        /// <summary>Output only. The number of entries defined in the glossary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entryCount")]
        public virtual System.Nullable<int> EntryCount { get; set; }

        /// <summary>
        /// Required. Provides examples to build the glossary from. Total glossary must not exceed 10M Unicode
        /// codepoints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfig")]
        public virtual GlossaryInputConfig InputConfig { get; set; }

        /// <summary>Used with equivalent term set glossaries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCodesSet")]
        public virtual LanguageCodesSet LanguageCodesSet { get; set; }

        /// <summary>Used with unidirectional glossaries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languagePair")]
        public virtual LanguageCodePair LanguagePair { get; set; }

        /// <summary>
        /// Required. The resource name of the glossary. Glossary names have the form
        /// `projects/{project-number-or-id}/locations/{location-id}/glossaries/{glossary-id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _submitTimeRaw;

        private object _submitTime;

        /// <summary>Output only. When CreateGlossary was called.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("submitTime")]
        public virtual string SubmitTimeRaw
        {
            get => _submitTimeRaw;
            set
            {
                _submitTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _submitTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="SubmitTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use SubmitTimeDateTimeOffset instead.")]
        public virtual object SubmitTime
        {
            get => _submitTime;
            set
            {
                _submitTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _submitTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="SubmitTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? SubmitTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(SubmitTimeRaw);
            set => SubmitTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configures which glossary is used for a specific target language and defines options for applying that glossary.
    /// </summary>
    public class GlossaryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If set to true, the glossary will be used for contextual translation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contextualTranslationEnabled")]
        public virtual System.Nullable<bool> ContextualTranslationEnabled { get; set; }

        /// <summary>
        /// Required. The `glossary` to be applied for this translation. The format depends on the glossary: -
        /// User-provided custom glossary:
        /// `projects/{project-number-or-id}/locations/{location-id}/glossaries/{glossary-id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glossary")]
        public virtual string Glossary { get; set; }

        /// <summary>Optional. Indicates match is case insensitive. The default value is `false` if missing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreCase")]
        public virtual System.Nullable<bool> IgnoreCase { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a single entry in a glossary.</summary>
    public class GlossaryEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Describes the glossary entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Identifier. The resource name of the entry. Format: `projects/*/locations/*/glossaries/*/glossaryEntries/*`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Used for an unidirectional glossary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("termsPair")]
        public virtual GlossaryTermsPair TermsPair { get; set; }

        /// <summary>Used for an equivalent term sets glossary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("termsSet")]
        public virtual GlossaryTermsSet TermsSet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Input configuration for glossaries.</summary>
    public class GlossaryInputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Google Cloud Storage location of glossary data. File format is determined based on the filename
        /// extension. API returns [google.rpc.Code.INVALID_ARGUMENT] for unsupported URI-s and file formats. Wildcards
        /// are not allowed. This must be a single file in one of the following formats: For unidirectional glossaries:
        /// - TSV/CSV (`.tsv`/`.csv`): Two column file, tab- or comma-separated. The first column is source text. The
        /// second column is target text. No headers in this file. The first row contains data and not column names. -
        /// TMX (`.tmx`): TMX file with parallel data defining source/target term pairs. For equivalent term sets
        /// glossaries: - CSV (`.csv`): Multi-column CSV file defining equivalent glossary terms in multiple languages.
        /// See documentation for more information -
        /// [glossaries](https://cloud.google.com/translate/docs/advanced/glossary).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GcsSource GcsSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a single glossary term</summary>
    public class GlossaryTerm : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The language for this glossary term.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The text for the glossary term.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a single entry for an unidirectional glossary.</summary>
    public class GlossaryTermsPair : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The source term is the term that will get match in the text,</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceTerm")]
        public virtual GlossaryTerm SourceTerm { get; set; }

        /// <summary>The term that will replace the match source term.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetTerm")]
        public virtual GlossaryTerm TargetTerm { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a single entry for an equivalent term set glossary. This is used for equivalent term sets where each
    /// term can be replaced by the other terms in the set.
    /// </summary>
    public class GlossaryTermsSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Each term in the set represents a term that can be replaced by the other terms.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terms")]
        public virtual System.Collections.Generic.IList<GlossaryTerm> Terms { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for importing an AdaptiveMt file along with its sentences.</summary>
    public class ImportAdaptiveMtFileRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Inline file source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileInputSource")]
        public virtual FileInputSource FileInputSource { get; set; }

        /// <summary>Google Cloud Storage file source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsInputSource")]
        public virtual GcsInputSource GcsInputSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for importing an AdaptiveMtFile</summary>
    public class ImportAdaptiveMtFileResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The Adaptive MT file that was imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adaptiveMtFile")]
        public virtual AdaptiveMtFile AdaptiveMtFile { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ImportData.</summary>
    public class ImportDataRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The config for the input content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfig")]
        public virtual DatasetInputConfig InputConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Input configuration for BatchTranslateText request.</summary>
    public class InputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Google Cloud Storage location for the source input. This can be a single file (for example,
        /// `gs://translation-test/input.tsv`) or a wildcard (for example, `gs://translation-test/*`). If a file
        /// extension is `.tsv`, it can contain either one or two columns. The first column (optional) is the id of the
        /// text request. If the first column is missing, we use the row number (0-based) from the input file as the ID
        /// in the output file. The second column is the actual text to be translated. We recommend each row be
        /// &amp;lt;= 10K Unicode codepoints, otherwise an error might be returned. Note that the input tsv must be RFC
        /// 4180 compliant. You could use https://github.com/Clever/csvlint to check potential formatting errors in your
        /// tsv file. csvlint --delimiter='\t' your_input_file.tsv The other supported file extensions are `.txt` or
        /// `.html`, which is treated as a single large chunk of text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GcsSource GcsSource { get; set; }

        /// <summary>
        /// Optional. Can be "text/plain" or "text/html". For `.tsv`, "text/html" is used if mime_type is missing. For
        /// `.html`, this field must be "text/html" or empty. For `.txt`, this field must be "text/plain" or empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An input file.</summary>
    public class InputFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Google Cloud Storage file source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GcsInputSource GcsSource { get; set; }

        /// <summary>
        /// Optional. Usage of the file contents. Options are TRAIN|VALIDATION|TEST, or UNASSIGNED (by default) for auto
        /// split.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usage")]
        public virtual string Usage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Used with unidirectional glossaries.</summary>
    public class LanguageCodePair : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The ISO-639 language code of the input text, for example, "en-US". Expected to be an exact match
        /// for GlossaryTerm.language_code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceLanguageCode")]
        public virtual string SourceLanguageCode { get; set; }

        /// <summary>
        /// Required. The ISO-639 language code for translation output, for example, "zh-CN". Expected to be an exact
        /// match for GlossaryTerm.language_code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetLanguageCode")]
        public virtual string TargetLanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Used with equivalent term set glossaries.</summary>
    public class LanguageCodesSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ISO-639 language code(s) for terms defined in the glossary. All entries are unique. The list contains at
        /// least two entries. Expected to be an exact match for GlossaryTerm.language_code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCodes")]
        public virtual System.Collections.Generic.IList<string> LanguageCodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of AdaptiveMtDatasets.</summary>
    public class ListAdaptiveMtDatasetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. A list of Adaptive MT datasets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adaptiveMtDatasets")]
        public virtual System.Collections.Generic.IList<AdaptiveMtDataset> AdaptiveMtDatasets { get; set; }

        /// <summary>
        /// Optional. A token to retrieve a page of results. Pass this value in the
        /// [ListAdaptiveMtDatasetsRequest.page_token] field in the subsequent call to `ListAdaptiveMtDatasets` method
        /// to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for listing all AdaptiveMt files under a given dataset.</summary>
    public class ListAdaptiveMtFilesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The Adaptive MT files.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adaptiveMtFiles")]
        public virtual System.Collections.Generic.IList<AdaptiveMtFile> AdaptiveMtFiles { get; set; }

        /// <summary>
        /// Optional. A token to retrieve a page of results. Pass this value in the
        /// ListAdaptiveMtFilesRequest.page_token field in the subsequent call to `ListAdaptiveMtFiles` method to
        /// retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List AdaptiveMt sentences response.</summary>
    public class ListAdaptiveMtSentencesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The list of AdaptiveMtSentences.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adaptiveMtSentences")]
        public virtual System.Collections.Generic.IList<AdaptiveMtSentence> AdaptiveMtSentences { get; set; }

        /// <summary>Optional. </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListDatasets.</summary>
    public class ListDatasetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The datasets read.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasets")]
        public virtual System.Collections.Generic.IList<Dataset> Datasets { get; set; }

        /// <summary>
        /// A token to retrieve next page of results. Pass this token to the page_token field in the ListDatasetsRequest
        /// to obtain the corresponding page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListExamples.</summary>
    public class ListExamplesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The sentence pairs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("examples")]
        public virtual System.Collections.Generic.IList<Example> Examples { get; set; }

        /// <summary>
        /// A token to retrieve next page of results. Pass this token to the page_token field in the ListExamplesRequest
        /// to obtain the corresponding page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListGlossaries.</summary>
    public class ListGlossariesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of glossaries for a project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glossaries")]
        public virtual System.Collections.Generic.IList<Glossary> Glossaries { get; set; }

        /// <summary>
        /// A token to retrieve a page of results. Pass this value in the [ListGlossariesRequest.page_token] field in
        /// the subsequent call to `ListGlossaries` method to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListGlossaryEntries</summary>
    public class ListGlossaryEntriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The Glossary Entries</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glossaryEntries")]
        public virtual System.Collections.Generic.IList<GlossaryEntry> GlossaryEntries { get; set; }

        /// <summary>
        /// Optional. A token to retrieve a page of results. Pass this value in the
        /// [ListGLossaryEntriesRequest.page_token] field in the subsequent calls.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Locations.ListLocations.</summary>
    public class ListLocationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of locations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<Location> Locations { get; set; }

        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListModels.</summary>
    public class ListModelsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The models read.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("models")]
        public virtual System.Collections.Generic.IList<Model> Models { get; set; }

        /// <summary>
        /// A token to retrieve next page of results. Pass this token to the page_token field in the ListModelsRequest
        /// to obtain the corresponding page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

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

    /// <summary>A resource that represents a Google Cloud location.</summary>
    public class Location : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>A trained translation model.</summary>
    public class Model : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. Timestamp when the model resource was created, which is also when the training started.
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
        /// The dataset from which the model is trained, in form of
        /// `projects/{project-number-or-id}/locations/{location_id}/datasets/{dataset_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>
        /// The name of the model to show in the interface. The name can be up to 32 characters long and can consist
        /// only of ASCII Latin letters A-Z and a-z, underscores (_), and ASCII digits 0-9.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The resource name of the model, in form of
        /// `projects/{project-number-or-id}/locations/{location_id}/models/{model_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The BCP-47 language code of the source language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceLanguageCode")]
        public virtual string SourceLanguageCode { get; set; }

        /// <summary>Output only. The BCP-47 language code of the target language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetLanguageCode")]
        public virtual string TargetLanguageCode { get; set; }

        /// <summary>Output only. Number of examples (sentence pairs) used to test the model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testExampleCount")]
        public virtual System.Nullable<int> TestExampleCount { get; set; }

        /// <summary>Output only. Number of examples (sentence pairs) used to train the model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainExampleCount")]
        public virtual System.Nullable<int> TrainExampleCount { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Timestamp when this model was last updated.</summary>
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

        /// <summary>Output only. Number of examples (sentence pairs) used to validate the model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateExampleCount")]
        public virtual System.Nullable<int> ValidateExampleCount { get; set; }

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

    /// <summary>Output configuration for BatchTranslateText request.</summary>
    public class OutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Storage destination for output content. For every single input file (for example,
        /// gs://a/b/c.[extension]), we generate at most 2 * n output files. (n is the # of target_language_codes in the
        /// BatchTranslateTextRequest). Output files (tsv) generated are compliant with RFC 4180 except that record
        /// delimiters are '\n' instead of '\r\n'. We don't provide any way to change record delimiters. While the input
        /// files are being processed, we write/update an index file 'index.csv' under 'output_uri_prefix' (for example,
        /// gs://translation-test/index.csv) The index file is generated/updated as new files are being translated. The
        /// format is: input_file,target_language_code,translations_file,errors_file,
        /// glossary_translations_file,glossary_errors_file input_file is one file we matched using
        /// gcs_source.input_uri. target_language_code is provided in the request. translations_file contains the
        /// translations. (details provided below) errors_file contains the errors during processing of the file.
        /// (details below). Both translations_file and errors_file could be empty strings if we have no content to
        /// output. glossary_translations_file and glossary_errors_file are always empty strings if the input_file is
        /// tsv. They could also be empty if we have no content to output. Once a row is present in index.csv, the
        /// input/output matching never changes. Callers should also expect all the content in input_file are processed
        /// and ready to be consumed (that is, no partial output file is written). Since index.csv will be keeping
        /// updated during the process, please make sure there is no custom retention policy applied on the output
        /// bucket that may avoid file updating. (https://cloud.google.com/storage/docs/bucket-lock#retention-policy)
        /// The format of translations_file (for target language code 'trg') is:
        /// `gs://translation_test/a_b_c_'trg'_translations.[extension]` If the input file extension is tsv, the output
        /// has the following columns: Column 1: ID of the request provided in the input, if it's not provided in the
        /// input, then the input row number is used (0-based). Column 2: source sentence. Column 3: translation without
        /// applying a glossary. Empty string if there is an error. Column 4 (only present if a glossary is provided in
        /// the request): translation after applying the glossary. Empty string if there is an error applying the
        /// glossary. Could be same string as column 3 if there is no glossary applied. If input file extension is a txt
        /// or html, the translation is directly written to the output file. If glossary is requested, a separate
        /// glossary_translations_file has format of
        /// `gs://translation_test/a_b_c_'trg'_glossary_translations.[extension]` The format of errors file (for target
        /// language code 'trg') is: `gs://translation_test/a_b_c_'trg'_errors.[extension]` If the input file extension
        /// is tsv, errors_file contains the following: Column 1: ID of the request provided in the input, if it's not
        /// provided in the input, then the input row number is used (0-based). Column 2: source sentence. Column 3:
        /// Error detail for the translation. Could be empty. Column 4 (only present if a glossary is provided in the
        /// request): Error when applying the glossary. If the input file extension is txt or html, glossary_error_file
        /// will be generated that contains error details. glossary_error_file has format of
        /// `gs://translation_test/a_b_c_'trg'_glossary_errors.[extension]`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual GcsDestination GcsDestination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message of caller-provided reference configuration.</summary>
    public class ReferenceSentenceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Reference sentences pair lists. Each list will be used as the references to translate the sentence under
        /// "content" field at the corresponding index. Length of the list is required to be equal to the length of
        /// "content" field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceSentencePairLists")]
        public virtual System.Collections.Generic.IList<ReferenceSentencePairList> ReferenceSentencePairLists { get; set; }

        /// <summary>Source language code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceLanguageCode")]
        public virtual string SourceLanguageCode { get; set; }

        /// <summary>Target language code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetLanguageCode")]
        public virtual string TargetLanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A pair of sentences used as reference in source and target languages.</summary>
    public class ReferenceSentencePair : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Source sentence in the sentence pair.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceSentence")]
        public virtual string SourceSentence { get; set; }

        /// <summary>Target sentence in the sentence pair.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetSentence")]
        public virtual string TargetSentence { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of reference sentence pairs.</summary>
    public class ReferenceSentencePairList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Reference sentence pairs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceSentencePairs")]
        public virtual System.Collections.Generic.IList<ReferenceSentencePair> ReferenceSentencePairs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single romanization response.</summary>
    public class Romanization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ISO-639 language code of source text in the initial request, detected automatically, if no source
        /// language was passed within the initial request. If the source language was passed, auto-detection of the
        /// language does not occur and this field is empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguageCode")]
        public virtual string DetectedLanguageCode { get; set; }

        /// <summary>
        /// Romanized text. If an error occurs during romanization, this field might be excluded from the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("romanizedText")]
        public virtual string RomanizedText { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for synchronous romanization.</summary>
    public class RomanizeTextRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The content of the input in string format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contents")]
        public virtual System.Collections.Generic.IList<string> Contents { get; set; }

        /// <summary>
        /// Optional. The ISO-639 language code of the input text if known, for example, "hi" or "zh". If the source
        /// language isn't specified, the API attempts to identify the source language automatically and returns the
        /// source language for each content in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceLanguageCode")]
        public virtual string SourceLanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for synchronous romanization.</summary>
    public class RomanizeTextResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Text romanization responses. This field has the same length as `contents`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("romanizations")]
        public virtual System.Collections.Generic.IList<Romanization> Romanizations { get; set; }

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
    /// A single supported language response corresponds to information related to one supported language.
    /// </summary>
    public class SupportedLanguage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Human-readable name of the language localized in the display language specified in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Supported language code, generally consisting of its ISO 639-1 identifier, for example, 'en', 'ja'. In
        /// certain cases, ISO-639 codes including language and region identifiers are returned (for example, 'zh-TW'
        /// and 'zh-CN').
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Can be used as a source language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportSource")]
        public virtual System.Nullable<bool> SupportSource { get; set; }

        /// <summary>Can be used as a target language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportTarget")]
        public virtual System.Nullable<bool> SupportTarget { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for discovering supported languages.</summary>
    public class SupportedLanguages : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of supported language responses. This list contains an entry for each language the Translation API
        /// supports.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languages")]
        public virtual System.Collections.Generic.IList<SupportedLanguage> Languages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A document translation request.</summary>
    public class TranslateDocumentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. This flag is to support user customized attribution. If not provided, the default is `Machine
        /// Translated by Google`. Customized attribution should follow rules in
        /// https://cloud.google.com/translate/attribution#attribution_and_logos
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customizedAttribution")]
        public virtual string CustomizedAttribution { get; set; }

        /// <summary>Required. Input configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentInputConfig")]
        public virtual DocumentInputConfig DocumentInputConfig { get; set; }

        /// <summary>
        /// Optional. Output configurations. Defines if the output file should be stored within Cloud Storage as well as
        /// the desired output format. If not provided the translated file will only be returned through a byte-stream
        /// and its output mime type will be the same as the input file's mime type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentOutputConfig")]
        public virtual DocumentOutputConfig DocumentOutputConfig { get; set; }

        /// <summary>Optional. If true, enable auto rotation correction in DVS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableRotationCorrection")]
        public virtual System.Nullable<bool> EnableRotationCorrection { get; set; }

        /// <summary>
        /// Optional. If true, use the text removal server to remove the shadow text on background image for native pdf
        /// translation. Shadow removal feature can only be enabled when is_translate_native_pdf_only: false
        /// &amp;amp;&amp;amp; pdf_native_only: false
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableShadowRemovalNativePdf")]
        public virtual System.Nullable<bool> EnableShadowRemovalNativePdf { get; set; }

        /// <summary>
        /// Optional. Glossary to be applied. The glossary must be within the same region (have the same location-id) as
        /// the model, otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glossaryConfig")]
        public virtual TranslateTextGlossaryConfig GlossaryConfig { get; set; }

        /// <summary>
        /// Optional. is_translate_native_pdf_only field for external customers. If true, the page limit of online
        /// native pdf translation is 300 and only native pdf pages will be translated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isTranslateNativePdfOnly")]
        public virtual System.Nullable<bool> IsTranslateNativePdfOnly { get; set; }

        /// <summary>
        /// Optional. The labels with user-defined metadata for the request. Label keys and values can be no longer than
        /// 63 characters (Unicode codepoints), can only contain lowercase letters, numeric characters, underscores and
        /// dashes. International characters are allowed. Label values are optional. Label keys must start with a
        /// letter. See https://cloud.google.com/translate/docs/advanced/labels for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. The `model` type requested for this translation. The format depends on model type: - AutoML
        /// Translation models: `projects/{project-number-or-id}/locations/{location-id}/models/{model-id}` - General
        /// (built-in) models: `projects/{project-number-or-id}/locations/{location-id}/models/general/nmt`, If not
        /// provided, the default Google model (NMT) will be used for translation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>
        /// Optional. The ISO-639 language code of the input document if known, for example, "en-US" or "sr-Latn".
        /// Supported language codes are listed in Language Support. If the source language isn't specified, the API
        /// attempts to identify the source language automatically and returns the source language within the response.
        /// Source language must be specified if the request contains a glossary or a custom model.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceLanguageCode")]
        public virtual string SourceLanguageCode { get; set; }

        /// <summary>
        /// Required. The ISO-639 language code to use for translation of the input document, set to one of the language
        /// codes listed in Language Support.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetLanguageCode")]
        public virtual string TargetLanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A translated document response message.</summary>
    public class TranslateDocumentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Translated document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentTranslation")]
        public virtual DocumentTranslation DocumentTranslation { get; set; }

        /// <summary>The `glossary_config` used for this translation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glossaryConfig")]
        public virtual TranslateTextGlossaryConfig GlossaryConfig { get; set; }

        /// <summary>
        /// The document's translation output if a glossary is provided in the request. This can be the same as
        /// [TranslateDocumentResponse.document_translation] if no glossary terms apply.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glossaryDocumentTranslation")]
        public virtual DocumentTranslation GlossaryDocumentTranslation { get; set; }

        /// <summary>
        /// Only present when 'model' is present in the request. 'model' is normalized to have a project number. For
        /// example: If the 'model' field in TranslateDocumentRequest is:
        /// `projects/{project-id}/locations/{location-id}/models/general/nmt` then `model` here would be normalized to
        /// `projects/{project-number}/locations/{location-id}/models/general/nmt`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configures which glossary is used for a specific target language and defines options for applying that glossary.
    /// </summary>
    public class TranslateTextGlossaryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If set to true, the glossary will be used for contextual translation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contextualTranslationEnabled")]
        public virtual System.Nullable<bool> ContextualTranslationEnabled { get; set; }

        /// <summary>
        /// Required. The `glossary` to be applied for this translation. The format depends on the glossary: -
        /// User-provided custom glossary:
        /// `projects/{project-number-or-id}/locations/{location-id}/glossaries/{glossary-id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glossary")]
        public virtual string Glossary { get; set; }

        /// <summary>Optional. Indicates match is case insensitive. The default value is `false` if missing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreCase")]
        public virtual System.Nullable<bool> IgnoreCase { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for synchronous translation.</summary>
    public class TranslateTextRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The content of the input in string format. We recommend the total content be less than 30,000
        /// codepoints. The max length of this field is 1024. Use BatchTranslateText for larger text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contents")]
        public virtual System.Collections.Generic.IList<string> Contents { get; set; }

        /// <summary>
        /// Optional. Glossary to be applied. The glossary must be within the same region (have the same location-id) as
        /// the model, otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glossaryConfig")]
        public virtual TranslateTextGlossaryConfig GlossaryConfig { get; set; }

        /// <summary>
        /// Optional. The labels with user-defined metadata for the request. Label keys and values can be no longer than
        /// 63 characters (Unicode codepoints), can only contain lowercase letters, numeric characters, underscores and
        /// dashes. International characters are allowed. Label values are optional. Label keys must start with a
        /// letter. See https://cloud.google.com/translate/docs/advanced/labels for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. The format of the source text, for example, "text/html", "text/plain". If left blank, the MIME
        /// type defaults to "text/html".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>
        /// Optional. The `model` type requested for this translation. The format depends on model type: - AutoML
        /// Translation models: `projects/{project-number-or-id}/locations/{location-id}/models/{model-id}` - General
        /// (built-in) models: `projects/{project-number-or-id}/locations/{location-id}/models/general/nmt`, -
        /// Translation LLM models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/general/translation-llm`, For global
        /// (non-regionalized) requests, use `location-id` `global`. For example,
        /// `projects/{project-number-or-id}/locations/global/models/general/nmt`. If not provided, the default Google
        /// model (NMT) will be used
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>
        /// Optional. The ISO-639 language code of the input text if known, for example, "en-US" or "sr-Latn". Supported
        /// language codes are listed in Language Support. If the source language isn't specified, the API attempts to
        /// identify the source language automatically and returns the source language within the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceLanguageCode")]
        public virtual string SourceLanguageCode { get; set; }

        /// <summary>
        /// Required. The ISO-639 language code to use for translation of the input text, set to one of the language
        /// codes listed in Language Support.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetLanguageCode")]
        public virtual string TargetLanguageCode { get; set; }

        /// <summary>Optional. Transliteration to be applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transliterationConfig")]
        public virtual TransliterationConfig TransliterationConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TranslateTextResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Text translation responses if a glossary is provided in the request. This can be the same as `translations`
        /// if no terms apply. This field has the same length as `contents`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glossaryTranslations")]
        public virtual System.Collections.Generic.IList<Translation> GlossaryTranslations { get; set; }

        /// <summary>
        /// Text translation responses with no glossary applied. This field has the same length as `contents`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("translations")]
        public virtual System.Collections.Generic.IList<Translation> Translations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single translation response.</summary>
    public class Translation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ISO-639 language code of source text in the initial request, detected automatically, if no source
        /// language was passed within the initial request. If the source language was passed, auto-detection of the
        /// language does not occur and this field is empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguageCode")]
        public virtual string DetectedLanguageCode { get; set; }

        /// <summary>The `glossary_config` used for this translation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glossaryConfig")]
        public virtual TranslateTextGlossaryConfig GlossaryConfig { get; set; }

        /// <summary>
        /// Only present when `model` is present in the request. `model` here is normalized to have project number. For
        /// example: If the `model` requested in TranslationTextRequest is
        /// `projects/{project-id}/locations/{location-id}/models/general/nmt` then `model` here would be normalized to
        /// `projects/{project-number}/locations/{location-id}/models/general/nmt`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>
        /// Text translated into the target language. If an error occurs during translation, this field might be
        /// excluded from the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("translatedText")]
        public virtual string TranslatedText { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configures transliteration feature on top of translation.</summary>
    public class TransliterationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If true, source text in romanized form can be translated to the target language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableTransliteration")]
        public virtual System.Nullable<bool> EnableTransliteration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.WaitOperation.</summary>
    public class WaitOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The maximum duration to wait before timing out. If left blank, the wait will be at most the time permitted
        /// by the underlying HTTP/RPC protocol. If RPC context deadline is also specified, the shorter one will be
        /// used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
