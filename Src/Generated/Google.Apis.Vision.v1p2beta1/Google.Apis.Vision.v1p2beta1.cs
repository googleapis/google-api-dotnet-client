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

namespace Google.Apis.Vision.v1p2beta1
{
    /// <summary>The Vision Service.</summary>
    public class VisionService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1p2beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public VisionService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public VisionService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Files = new FilesResource(this);
            Images = new ImagesResource(this);
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "vision";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://vision.googleapis.com/";
        #else
            "https://vision.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://vision.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Vision API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Apply machine learning models to understand and label images</summary>
            public static string CloudVision = "https://www.googleapis.com/auth/cloud-vision";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Vision API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Apply machine learning models to understand and label images</summary>
            public const string CloudVision = "https://www.googleapis.com/auth/cloud-vision";
        }

        /// <summary>Gets the Files resource.</summary>
        public virtual FilesResource Files { get; }

        /// <summary>Gets the Images resource.</summary>
        public virtual ImagesResource Images { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for Vision requests.</summary>
    public abstract class VisionBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new VisionBaseServiceRequest instance.</summary>
        protected VisionBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Vision parameter list.</summary>
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

    /// <summary>The "files" collection of methods.</summary>
    public class FilesResource
    {
        private const string Resource = "files";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public FilesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Service that performs image detection and annotation for a batch of files. Now only "application/pdf",
        /// "image/tiff" and "image/gif" are supported. This service will extract at most 5 (customers can specify which
        /// 5 in AnnotateFileRequest.pages) frames (gif) or pages (pdf or tiff) from each file provided and perform
        /// detection and annotation for each image extracted.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual AnnotateRequest Annotate(Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1BatchAnnotateFilesRequest body)
        {
            return new AnnotateRequest(service, body);
        }

        /// <summary>
        /// Service that performs image detection and annotation for a batch of files. Now only "application/pdf",
        /// "image/tiff" and "image/gif" are supported. This service will extract at most 5 (customers can specify which
        /// 5 in AnnotateFileRequest.pages) frames (gif) or pages (pdf or tiff) from each file provided and perform
        /// detection and annotation for each image extracted.
        /// </summary>
        public class AnnotateRequest : VisionBaseServiceRequest<Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1BatchAnnotateFilesResponse>
        {
            /// <summary>Constructs a new Annotate request.</summary>
            public AnnotateRequest(Google.Apis.Services.IClientService service, Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1BatchAnnotateFilesRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1BatchAnnotateFilesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "annotate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1p2beta1/files:annotate";

            /// <summary>Initializes Annotate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Run asynchronous image detection and annotation for a list of generic files, such as PDF files, which may
        /// contain multiple pages and multiple images per page. Progress and results can be retrieved through the
        /// `google.longrunning.Operations` interface. `Operation.metadata` contains `OperationMetadata` (metadata).
        /// `Operation.response` contains `AsyncBatchAnnotateFilesResponse` (results).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual AsyncBatchAnnotateRequest AsyncBatchAnnotate(Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1AsyncBatchAnnotateFilesRequest body)
        {
            return new AsyncBatchAnnotateRequest(service, body);
        }

        /// <summary>
        /// Run asynchronous image detection and annotation for a list of generic files, such as PDF files, which may
        /// contain multiple pages and multiple images per page. Progress and results can be retrieved through the
        /// `google.longrunning.Operations` interface. `Operation.metadata` contains `OperationMetadata` (metadata).
        /// `Operation.response` contains `AsyncBatchAnnotateFilesResponse` (results).
        /// </summary>
        public class AsyncBatchAnnotateRequest : VisionBaseServiceRequest<Google.Apis.Vision.v1p2beta1.Data.Operation>
        {
            /// <summary>Constructs a new AsyncBatchAnnotate request.</summary>
            public AsyncBatchAnnotateRequest(Google.Apis.Services.IClientService service, Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1AsyncBatchAnnotateFilesRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1AsyncBatchAnnotateFilesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "asyncBatchAnnotate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1p2beta1/files:asyncBatchAnnotate";

            /// <summary>Initializes AsyncBatchAnnotate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "images" collection of methods.</summary>
    public class ImagesResource
    {
        private const string Resource = "images";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ImagesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Run image detection and annotation for a batch of images.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual AnnotateRequest Annotate(Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1BatchAnnotateImagesRequest body)
        {
            return new AnnotateRequest(service, body);
        }

        /// <summary>Run image detection and annotation for a batch of images.</summary>
        public class AnnotateRequest : VisionBaseServiceRequest<Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1BatchAnnotateImagesResponse>
        {
            /// <summary>Constructs a new Annotate request.</summary>
            public AnnotateRequest(Google.Apis.Services.IClientService service, Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1BatchAnnotateImagesRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1BatchAnnotateImagesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "annotate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1p2beta1/images:annotate";

            /// <summary>Initializes Annotate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Run asynchronous image detection and annotation for a list of images. Progress and results can be retrieved
        /// through the `google.longrunning.Operations` interface. `Operation.metadata` contains `OperationMetadata`
        /// (metadata). `Operation.response` contains `AsyncBatchAnnotateImagesResponse` (results). This service will
        /// write image annotation outputs to json files in customer GCS bucket, each json file containing
        /// BatchAnnotateImagesResponse proto.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual AsyncBatchAnnotateRequest AsyncBatchAnnotate(Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1AsyncBatchAnnotateImagesRequest body)
        {
            return new AsyncBatchAnnotateRequest(service, body);
        }

        /// <summary>
        /// Run asynchronous image detection and annotation for a list of images. Progress and results can be retrieved
        /// through the `google.longrunning.Operations` interface. `Operation.metadata` contains `OperationMetadata`
        /// (metadata). `Operation.response` contains `AsyncBatchAnnotateImagesResponse` (results). This service will
        /// write image annotation outputs to json files in customer GCS bucket, each json file containing
        /// BatchAnnotateImagesResponse proto.
        /// </summary>
        public class AsyncBatchAnnotateRequest : VisionBaseServiceRequest<Google.Apis.Vision.v1p2beta1.Data.Operation>
        {
            /// <summary>Constructs a new AsyncBatchAnnotate request.</summary>
            public AsyncBatchAnnotateRequest(Google.Apis.Services.IClientService service, Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1AsyncBatchAnnotateImagesRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1AsyncBatchAnnotateImagesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "asyncBatchAnnotate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1p2beta1/images:asyncBatchAnnotate";

            /// <summary>Initializes AsyncBatchAnnotate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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
            Files = new FilesResource(service);
            Images = new ImagesResource(service);
            Locations = new LocationsResource(service);
        }

        /// <summary>Gets the Files resource.</summary>
        public virtual FilesResource Files { get; }

        /// <summary>The "files" collection of methods.</summary>
        public class FilesResource
        {
            private const string Resource = "files";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public FilesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Service that performs image detection and annotation for a batch of files. Now only "application/pdf",
            /// "image/tiff" and "image/gif" are supported. This service will extract at most 5 (customers can specify
            /// which 5 in AnnotateFileRequest.pages) frames (gif) or pages (pdf or tiff) from each file provided and
            /// perform detection and annotation for each image extracted.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Optional. Target project and location to make a call. Format:
            /// `projects/{project-id}/locations/{location-id}`. If no parent is specified, a region will be chosen
            /// automatically. Supported location-ids: `us`: USA country only, `asia`: East asia areas, like Japan,
            /// Taiwan, `eu`: The European Union. Example: `projects/project-A/locations/eu`.
            /// </param>
            public virtual AnnotateRequest Annotate(Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1BatchAnnotateFilesRequest body, string parent)
            {
                return new AnnotateRequest(service, body, parent);
            }

            /// <summary>
            /// Service that performs image detection and annotation for a batch of files. Now only "application/pdf",
            /// "image/tiff" and "image/gif" are supported. This service will extract at most 5 (customers can specify
            /// which 5 in AnnotateFileRequest.pages) frames (gif) or pages (pdf or tiff) from each file provided and
            /// perform detection and annotation for each image extracted.
            /// </summary>
            public class AnnotateRequest : VisionBaseServiceRequest<Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1BatchAnnotateFilesResponse>
            {
                /// <summary>Constructs a new Annotate request.</summary>
                public AnnotateRequest(Google.Apis.Services.IClientService service, Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1BatchAnnotateFilesRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Optional. Target project and location to make a call. Format:
                /// `projects/{project-id}/locations/{location-id}`. If no parent is specified, a region will be chosen
                /// automatically. Supported location-ids: `us`: USA country only, `asia`: East asia areas, like Japan,
                /// Taiwan, `eu`: The European Union. Example: `projects/project-A/locations/eu`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1BatchAnnotateFilesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "annotate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1p2beta1/{+parent}/files:annotate";

                /// <summary>Initializes Annotate parameter list.</summary>
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

            /// <summary>
            /// Run asynchronous image detection and annotation for a list of generic files, such as PDF files, which
            /// may contain multiple pages and multiple images per page. Progress and results can be retrieved through
            /// the `google.longrunning.Operations` interface. `Operation.metadata` contains `OperationMetadata`
            /// (metadata). `Operation.response` contains `AsyncBatchAnnotateFilesResponse` (results).
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Optional. Target project and location to make a call. Format:
            /// `projects/{project-id}/locations/{location-id}`. If no parent is specified, a region will be chosen
            /// automatically. Supported location-ids: `us`: USA country only, `asia`: East asia areas, like Japan,
            /// Taiwan, `eu`: The European Union. Example: `projects/project-A/locations/eu`.
            /// </param>
            public virtual AsyncBatchAnnotateRequest AsyncBatchAnnotate(Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1AsyncBatchAnnotateFilesRequest body, string parent)
            {
                return new AsyncBatchAnnotateRequest(service, body, parent);
            }

            /// <summary>
            /// Run asynchronous image detection and annotation for a list of generic files, such as PDF files, which
            /// may contain multiple pages and multiple images per page. Progress and results can be retrieved through
            /// the `google.longrunning.Operations` interface. `Operation.metadata` contains `OperationMetadata`
            /// (metadata). `Operation.response` contains `AsyncBatchAnnotateFilesResponse` (results).
            /// </summary>
            public class AsyncBatchAnnotateRequest : VisionBaseServiceRequest<Google.Apis.Vision.v1p2beta1.Data.Operation>
            {
                /// <summary>Constructs a new AsyncBatchAnnotate request.</summary>
                public AsyncBatchAnnotateRequest(Google.Apis.Services.IClientService service, Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1AsyncBatchAnnotateFilesRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Optional. Target project and location to make a call. Format:
                /// `projects/{project-id}/locations/{location-id}`. If no parent is specified, a region will be chosen
                /// automatically. Supported location-ids: `us`: USA country only, `asia`: East asia areas, like Japan,
                /// Taiwan, `eu`: The European Union. Example: `projects/project-A/locations/eu`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1AsyncBatchAnnotateFilesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "asyncBatchAnnotate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1p2beta1/{+parent}/files:asyncBatchAnnotate";

                /// <summary>Initializes AsyncBatchAnnotate parameter list.</summary>
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

        /// <summary>Gets the Images resource.</summary>
        public virtual ImagesResource Images { get; }

        /// <summary>The "images" collection of methods.</summary>
        public class ImagesResource
        {
            private const string Resource = "images";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ImagesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Run image detection and annotation for a batch of images.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Optional. Target project and location to make a call. Format:
            /// `projects/{project-id}/locations/{location-id}`. If no parent is specified, a region will be chosen
            /// automatically. Supported location-ids: `us`: USA country only, `asia`: East asia areas, like Japan,
            /// Taiwan, `eu`: The European Union. Example: `projects/project-A/locations/eu`.
            /// </param>
            public virtual AnnotateRequest Annotate(Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1BatchAnnotateImagesRequest body, string parent)
            {
                return new AnnotateRequest(service, body, parent);
            }

            /// <summary>Run image detection and annotation for a batch of images.</summary>
            public class AnnotateRequest : VisionBaseServiceRequest<Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1BatchAnnotateImagesResponse>
            {
                /// <summary>Constructs a new Annotate request.</summary>
                public AnnotateRequest(Google.Apis.Services.IClientService service, Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1BatchAnnotateImagesRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Optional. Target project and location to make a call. Format:
                /// `projects/{project-id}/locations/{location-id}`. If no parent is specified, a region will be chosen
                /// automatically. Supported location-ids: `us`: USA country only, `asia`: East asia areas, like Japan,
                /// Taiwan, `eu`: The European Union. Example: `projects/project-A/locations/eu`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1BatchAnnotateImagesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "annotate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1p2beta1/{+parent}/images:annotate";

                /// <summary>Initializes Annotate parameter list.</summary>
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

            /// <summary>
            /// Run asynchronous image detection and annotation for a list of images. Progress and results can be
            /// retrieved through the `google.longrunning.Operations` interface. `Operation.metadata` contains
            /// `OperationMetadata` (metadata). `Operation.response` contains `AsyncBatchAnnotateImagesResponse`
            /// (results). This service will write image annotation outputs to json files in customer GCS bucket, each
            /// json file containing BatchAnnotateImagesResponse proto.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Optional. Target project and location to make a call. Format:
            /// `projects/{project-id}/locations/{location-id}`. If no parent is specified, a region will be chosen
            /// automatically. Supported location-ids: `us`: USA country only, `asia`: East asia areas, like Japan,
            /// Taiwan, `eu`: The European Union. Example: `projects/project-A/locations/eu`.
            /// </param>
            public virtual AsyncBatchAnnotateRequest AsyncBatchAnnotate(Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1AsyncBatchAnnotateImagesRequest body, string parent)
            {
                return new AsyncBatchAnnotateRequest(service, body, parent);
            }

            /// <summary>
            /// Run asynchronous image detection and annotation for a list of images. Progress and results can be
            /// retrieved through the `google.longrunning.Operations` interface. `Operation.metadata` contains
            /// `OperationMetadata` (metadata). `Operation.response` contains `AsyncBatchAnnotateImagesResponse`
            /// (results). This service will write image annotation outputs to json files in customer GCS bucket, each
            /// json file containing BatchAnnotateImagesResponse proto.
            /// </summary>
            public class AsyncBatchAnnotateRequest : VisionBaseServiceRequest<Google.Apis.Vision.v1p2beta1.Data.Operation>
            {
                /// <summary>Constructs a new AsyncBatchAnnotate request.</summary>
                public AsyncBatchAnnotateRequest(Google.Apis.Services.IClientService service, Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1AsyncBatchAnnotateImagesRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Optional. Target project and location to make a call. Format:
                /// `projects/{project-id}/locations/{location-id}`. If no parent is specified, a region will be chosen
                /// automatically. Supported location-ids: `us`: USA country only, `asia`: East asia areas, like Japan,
                /// Taiwan, `eu`: The European Union. Example: `projects/project-A/locations/eu`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1AsyncBatchAnnotateImagesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "asyncBatchAnnotate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1p2beta1/{+parent}/images:asyncBatchAnnotate";

                /// <summary>Initializes AsyncBatchAnnotate parameter list.</summary>
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
                Files = new FilesResource(service);
                Images = new ImagesResource(service);
            }

            /// <summary>Gets the Files resource.</summary>
            public virtual FilesResource Files { get; }

            /// <summary>The "files" collection of methods.</summary>
            public class FilesResource
            {
                private const string Resource = "files";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public FilesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Service that performs image detection and annotation for a batch of files. Now only
                /// "application/pdf", "image/tiff" and "image/gif" are supported. This service will extract at most 5
                /// (customers can specify which 5 in AnnotateFileRequest.pages) frames (gif) or pages (pdf or tiff)
                /// from each file provided and perform detection and annotation for each image extracted.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Optional. Target project and location to make a call. Format:
                /// `projects/{project-id}/locations/{location-id}`. If no parent is specified, a region will be chosen
                /// automatically. Supported location-ids: `us`: USA country only, `asia`: East asia areas, like Japan,
                /// Taiwan, `eu`: The European Union. Example: `projects/project-A/locations/eu`.
                /// </param>
                public virtual AnnotateRequest Annotate(Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1BatchAnnotateFilesRequest body, string parent)
                {
                    return new AnnotateRequest(service, body, parent);
                }

                /// <summary>
                /// Service that performs image detection and annotation for a batch of files. Now only
                /// "application/pdf", "image/tiff" and "image/gif" are supported. This service will extract at most 5
                /// (customers can specify which 5 in AnnotateFileRequest.pages) frames (gif) or pages (pdf or tiff)
                /// from each file provided and perform detection and annotation for each image extracted.
                /// </summary>
                public class AnnotateRequest : VisionBaseServiceRequest<Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1BatchAnnotateFilesResponse>
                {
                    /// <summary>Constructs a new Annotate request.</summary>
                    public AnnotateRequest(Google.Apis.Services.IClientService service, Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1BatchAnnotateFilesRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Optional. Target project and location to make a call. Format:
                    /// `projects/{project-id}/locations/{location-id}`. If no parent is specified, a region will be
                    /// chosen automatically. Supported location-ids: `us`: USA country only, `asia`: East asia areas,
                    /// like Japan, Taiwan, `eu`: The European Union. Example: `projects/project-A/locations/eu`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1BatchAnnotateFilesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "annotate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1p2beta1/{+parent}/files:annotate";

                    /// <summary>Initializes Annotate parameter list.</summary>
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
                /// Run asynchronous image detection and annotation for a list of generic files, such as PDF files,
                /// which may contain multiple pages and multiple images per page. Progress and results can be retrieved
                /// through the `google.longrunning.Operations` interface. `Operation.metadata` contains
                /// `OperationMetadata` (metadata). `Operation.response` contains `AsyncBatchAnnotateFilesResponse`
                /// (results).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Optional. Target project and location to make a call. Format:
                /// `projects/{project-id}/locations/{location-id}`. If no parent is specified, a region will be chosen
                /// automatically. Supported location-ids: `us`: USA country only, `asia`: East asia areas, like Japan,
                /// Taiwan, `eu`: The European Union. Example: `projects/project-A/locations/eu`.
                /// </param>
                public virtual AsyncBatchAnnotateRequest AsyncBatchAnnotate(Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1AsyncBatchAnnotateFilesRequest body, string parent)
                {
                    return new AsyncBatchAnnotateRequest(service, body, parent);
                }

                /// <summary>
                /// Run asynchronous image detection and annotation for a list of generic files, such as PDF files,
                /// which may contain multiple pages and multiple images per page. Progress and results can be retrieved
                /// through the `google.longrunning.Operations` interface. `Operation.metadata` contains
                /// `OperationMetadata` (metadata). `Operation.response` contains `AsyncBatchAnnotateFilesResponse`
                /// (results).
                /// </summary>
                public class AsyncBatchAnnotateRequest : VisionBaseServiceRequest<Google.Apis.Vision.v1p2beta1.Data.Operation>
                {
                    /// <summary>Constructs a new AsyncBatchAnnotate request.</summary>
                    public AsyncBatchAnnotateRequest(Google.Apis.Services.IClientService service, Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1AsyncBatchAnnotateFilesRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Optional. Target project and location to make a call. Format:
                    /// `projects/{project-id}/locations/{location-id}`. If no parent is specified, a region will be
                    /// chosen automatically. Supported location-ids: `us`: USA country only, `asia`: East asia areas,
                    /// like Japan, Taiwan, `eu`: The European Union. Example: `projects/project-A/locations/eu`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1AsyncBatchAnnotateFilesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "asyncBatchAnnotate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1p2beta1/{+parent}/files:asyncBatchAnnotate";

                    /// <summary>Initializes AsyncBatchAnnotate parameter list.</summary>
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

            /// <summary>Gets the Images resource.</summary>
            public virtual ImagesResource Images { get; }

            /// <summary>The "images" collection of methods.</summary>
            public class ImagesResource
            {
                private const string Resource = "images";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ImagesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Run image detection and annotation for a batch of images.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Optional. Target project and location to make a call. Format:
                /// `projects/{project-id}/locations/{location-id}`. If no parent is specified, a region will be chosen
                /// automatically. Supported location-ids: `us`: USA country only, `asia`: East asia areas, like Japan,
                /// Taiwan, `eu`: The European Union. Example: `projects/project-A/locations/eu`.
                /// </param>
                public virtual AnnotateRequest Annotate(Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1BatchAnnotateImagesRequest body, string parent)
                {
                    return new AnnotateRequest(service, body, parent);
                }

                /// <summary>Run image detection and annotation for a batch of images.</summary>
                public class AnnotateRequest : VisionBaseServiceRequest<Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1BatchAnnotateImagesResponse>
                {
                    /// <summary>Constructs a new Annotate request.</summary>
                    public AnnotateRequest(Google.Apis.Services.IClientService service, Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1BatchAnnotateImagesRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Optional. Target project and location to make a call. Format:
                    /// `projects/{project-id}/locations/{location-id}`. If no parent is specified, a region will be
                    /// chosen automatically. Supported location-ids: `us`: USA country only, `asia`: East asia areas,
                    /// like Japan, Taiwan, `eu`: The European Union. Example: `projects/project-A/locations/eu`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1BatchAnnotateImagesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "annotate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1p2beta1/{+parent}/images:annotate";

                    /// <summary>Initializes Annotate parameter list.</summary>
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
                /// Run asynchronous image detection and annotation for a list of images. Progress and results can be
                /// retrieved through the `google.longrunning.Operations` interface. `Operation.metadata` contains
                /// `OperationMetadata` (metadata). `Operation.response` contains `AsyncBatchAnnotateImagesResponse`
                /// (results). This service will write image annotation outputs to json files in customer GCS bucket,
                /// each json file containing BatchAnnotateImagesResponse proto.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Optional. Target project and location to make a call. Format:
                /// `projects/{project-id}/locations/{location-id}`. If no parent is specified, a region will be chosen
                /// automatically. Supported location-ids: `us`: USA country only, `asia`: East asia areas, like Japan,
                /// Taiwan, `eu`: The European Union. Example: `projects/project-A/locations/eu`.
                /// </param>
                public virtual AsyncBatchAnnotateRequest AsyncBatchAnnotate(Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1AsyncBatchAnnotateImagesRequest body, string parent)
                {
                    return new AsyncBatchAnnotateRequest(service, body, parent);
                }

                /// <summary>
                /// Run asynchronous image detection and annotation for a list of images. Progress and results can be
                /// retrieved through the `google.longrunning.Operations` interface. `Operation.metadata` contains
                /// `OperationMetadata` (metadata). `Operation.response` contains `AsyncBatchAnnotateImagesResponse`
                /// (results). This service will write image annotation outputs to json files in customer GCS bucket,
                /// each json file containing BatchAnnotateImagesResponse proto.
                /// </summary>
                public class AsyncBatchAnnotateRequest : VisionBaseServiceRequest<Google.Apis.Vision.v1p2beta1.Data.Operation>
                {
                    /// <summary>Constructs a new AsyncBatchAnnotate request.</summary>
                    public AsyncBatchAnnotateRequest(Google.Apis.Services.IClientService service, Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1AsyncBatchAnnotateImagesRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Optional. Target project and location to make a call. Format:
                    /// `projects/{project-id}/locations/{location-id}`. If no parent is specified, a region will be
                    /// chosen automatically. Supported location-ids: `us`: USA country only, `asia`: East asia areas,
                    /// like Japan, Taiwan, `eu`: The European Union. Example: `projects/project-A/locations/eu`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Vision.v1p2beta1.Data.GoogleCloudVisionV1p2beta1AsyncBatchAnnotateImagesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "asyncBatchAnnotate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1p2beta1/{+parent}/images:asyncBatchAnnotate";

                    /// <summary>Initializes AsyncBatchAnnotate parameter list.</summary>
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
        }
    }
}
namespace Google.Apis.Vision.v1p2beta1.Data
{
    /// <summary>
    /// Response to a single file annotation request. A file may contain one or more images, which individually have
    /// their own responses.
    /// </summary>
    public class AnnotateFileResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set, represents the error message for the failed request. The `responses` field will not be set in this
        /// case.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>Information about the file for which this response is generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfig")]
        public virtual InputConfig InputConfig { get; set; }

        /// <summary>
        /// Individual responses to images found within the file. This field will be empty if the `error` field is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responses")]
        public virtual System.Collections.Generic.IList<AnnotateImageResponse> Responses { get; set; }

        /// <summary>This field gives the total number of pages in the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalPages")]
        public virtual System.Nullable<int> TotalPages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to an image annotation request.</summary>
    public class AnnotateImageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If present, contextual information is needed to understand where this image comes from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual ImageAnnotationContext Context { get; set; }

        /// <summary>If present, crop hints have completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cropHintsAnnotation")]
        public virtual CropHintsAnnotation CropHintsAnnotation { get; set; }

        /// <summary>
        /// If set, represents the error message for the operation. Note that filled-in image annotations are guaranteed
        /// to be correct, even when `error` is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>If present, face detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faceAnnotations")]
        public virtual System.Collections.Generic.IList<FaceAnnotation> FaceAnnotations { get; set; }

        /// <summary>
        /// If present, text (OCR) detection or document (OCR) text detection has completed successfully. This
        /// annotation provides the structural hierarchy for the OCR detected text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullTextAnnotation")]
        public virtual TextAnnotation FullTextAnnotation { get; set; }

        /// <summary>If present, image properties were extracted successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imagePropertiesAnnotation")]
        public virtual ImageProperties ImagePropertiesAnnotation { get; set; }

        /// <summary>If present, label detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelAnnotations")]
        public virtual System.Collections.Generic.IList<EntityAnnotation> LabelAnnotations { get; set; }

        /// <summary>If present, landmark detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landmarkAnnotations")]
        public virtual System.Collections.Generic.IList<EntityAnnotation> LandmarkAnnotations { get; set; }

        /// <summary>
        /// If present, localized object detection has completed successfully. This will be sorted descending by
        /// confidence score.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedObjectAnnotations")]
        public virtual System.Collections.Generic.IList<LocalizedObjectAnnotation> LocalizedObjectAnnotations { get; set; }

        /// <summary>If present, logo detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logoAnnotations")]
        public virtual System.Collections.Generic.IList<EntityAnnotation> LogoAnnotations { get; set; }

        /// <summary>If present, product search has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSearchResults")]
        public virtual ProductSearchResults ProductSearchResults { get; set; }

        /// <summary>If present, safe-search annotation has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safeSearchAnnotation")]
        public virtual SafeSearchAnnotation SafeSearchAnnotation { get; set; }

        /// <summary>If present, text (OCR) detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnnotations")]
        public virtual System.Collections.Generic.IList<EntityAnnotation> TextAnnotations { get; set; }

        /// <summary>If present, web detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webDetection")]
        public virtual WebDetection WebDetection { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for a single offline file annotation request.</summary>
    public class AsyncAnnotateFileResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The output location and metadata from AsyncAnnotateFileRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual OutputConfig OutputConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to an async batch file annotation request.</summary>
    public class AsyncBatchAnnotateFilesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of file annotation responses, one for each request in AsyncBatchAnnotateFilesRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responses")]
        public virtual System.Collections.Generic.IList<AsyncAnnotateFileResponse> Responses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to an async batch image annotation request.</summary>
    public class AsyncBatchAnnotateImagesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The output location and metadata from AsyncBatchAnnotateImagesRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual OutputConfig OutputConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of file annotation responses.</summary>
    public class BatchAnnotateFilesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of file annotation responses, each response corresponding to each AnnotateFileRequest in
        /// BatchAnnotateFilesRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responses")]
        public virtual System.Collections.Generic.IList<AnnotateFileResponse> Responses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata for the batch operations such as the current state. This is included in the `metadata` field of the
    /// `Operation` returned by the `GetOperation` call of the `google::longrunning::Operations` service.
    /// </summary>
    public class BatchOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The time when the batch request is finished and google.longrunning.Operation.done is set to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The current state of the batch operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The time when the batch request was submitted to the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("submitTime")]
        public virtual object SubmitTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Logical element on the page.</summary>
    public class Block : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detected block type (text, image etc) for this block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockType")]
        public virtual string BlockType { get; set; }

        /// <summary>
        /// The bounding box for the block. The vertices are in the order of top-left, top-right, bottom-right,
        /// bottom-left. When a rotation of the bounding box is detected the rotation is represented as around the
        /// top-left corner as defined when the text is read in the 'natural' orientation. For example: * when the text
        /// is horizontal it might look like: 0----1 | | 3----2 * when it's rotated 180 degrees around the top-left
        /// corner it becomes: 2----3 | | 1----0 and the vertex order will still be (0, 1, 2, 3).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBox")]
        public virtual BoundingPoly BoundingBox { get; set; }

        /// <summary>Confidence of the OCR results on the block. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>List of paragraphs in this block (if this blocks is of type text).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paragraphs")]
        public virtual System.Collections.Generic.IList<Paragraph> Paragraphs { get; set; }

        /// <summary>Additional information detected for the block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual TextProperty Property { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A bounding polygon for the detected image annotation.</summary>
    public class BoundingPoly : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bounding polygon normalized vertices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedVertices")]
        public virtual System.Collections.Generic.IList<NormalizedVertex> NormalizedVertices { get; set; }

        /// <summary>The bounding polygon vertices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertices")]
        public virtual System.Collections.Generic.IList<Vertex> Vertices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a color in the RGBA color space. This representation is designed for simplicity of conversion to/from
    /// color representations in various languages over compactness. For example, the fields of this representation can
    /// be trivially provided to the constructor of `java.awt.Color` in Java; it can also be trivially provided to
    /// UIColor's `+colorWithRed:green:blue:alpha` method in iOS; and, with just a little work, it can be easily
    /// formatted into a CSS `rgba()` string in JavaScript. This reference page doesn't carry information about the
    /// absolute color space that should be used to interpret the RGB value (e.g. sRGB, Adobe RGB, DCI-P3, BT.2020,
    /// etc.). By default, applications should assume the sRGB color space. When color equality needs to be decided,
    /// implementations, unless documented otherwise, treat two colors as equal if all their red, green, blue, and alpha
    /// values each differ by at most 1e-5. Example (Java): import com.google.type.Color; // ... public static
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
    public class Color : Google.Apis.Requests.IDirectResponseSchema
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
    /// Color information consists of RGB channels, score, and the fraction of the image that the color occupies in the
    /// image.
    /// </summary>
    public class ColorInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>RGB components of the color.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual Color Color { get; set; }

        /// <summary>The fraction of pixels the color occupies in the image. Value in range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pixelFraction")]
        public virtual System.Nullable<float> PixelFraction { get; set; }

        /// <summary>Image-specific score for this color. Value in range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Single crop hint that is used to generate a new crop when serving an image.</summary>
    public class CropHint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The bounding polygon for the crop region. The coordinates of the bounding box are in the original image's
        /// scale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual BoundingPoly BoundingPoly { get; set; }

        /// <summary>Confidence of this being a salient region. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Fraction of importance of this salient region with respect to the original image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importanceFraction")]
        public virtual System.Nullable<float> ImportanceFraction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set of crop hints that are used to generate new crops when serving images.</summary>
    public class CropHintsAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Crop hint results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cropHints")]
        public virtual System.Collections.Generic.IList<CropHint> CropHints { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected start or end of a structural component.</summary>
    public class DetectedBreak : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>True if break prepends the element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPrefix")]
        public virtual System.Nullable<bool> IsPrefix { get; set; }

        /// <summary>Detected break type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected language for a structural component.</summary>
    public class DetectedLanguage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Confidence of detected language. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// The BCP-47 language code, such as "en-US" or "sr-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set of dominant colors and their corresponding scores.</summary>
    public class DominantColorsAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>RGB color values with their score and pixel fraction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colors")]
        public virtual System.Collections.Generic.IList<ColorInfo> Colors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set of detected entity features.</summary>
    public class EntityAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Image region to which this entity belongs. Not produced for `LABEL_DETECTION` features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual BoundingPoly BoundingPoly { get; set; }

        /// <summary>
        /// **Deprecated. Use `score` instead.** The accuracy of the entity detection in an image. For example, for an
        /// image in which the "Eiffel Tower" entity is detected, this field represents the confidence that there is a
        /// tower in the query image. Range [0, 1].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Entity textual description, expressed in its `locale` language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The language code for the locale in which the entity textual `description` is expressed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual string Locale { get; set; }

        /// <summary>
        /// The location information for the detected entity. Multiple `LocationInfo` elements can be present because
        /// one location may indicate the location of the scene in the image, and another location may indicate the
        /// location of the place where the image was taken. Location information is usually present for landmarks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<LocationInfo> Locations { get; set; }

        /// <summary>
        /// Opaque entity ID. Some IDs may be available in [Google Knowledge Graph Search
        /// API](https://developers.google.com/knowledge-graph/).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mid")]
        public virtual string Mid { get; set; }

        /// <summary>
        /// Some entities may have optional user-supplied `Property` (name/value) fields, such a score or string that
        /// qualifies the entity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<Property> Properties { get; set; }

        /// <summary>Overall score of the result. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>
        /// The relevancy of the ICA (Image Content Annotation) label to the image. For example, the relevancy of
        /// "tower" is likely higher to an image containing the detected "Eiffel Tower" than to an image containing a
        /// detected distant towering building, even though the confidence that there is a tower in each image may be
        /// the same. Range [0, 1].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicality")]
        public virtual System.Nullable<float> Topicality { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A face annotation object contains the results of face detection.</summary>
    public class FaceAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Anger likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("angerLikelihood")]
        public virtual string AngerLikelihood { get; set; }

        /// <summary>Blurred likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blurredLikelihood")]
        public virtual string BlurredLikelihood { get; set; }

        /// <summary>
        /// The bounding polygon around the face. The coordinates of the bounding box are in the original image's scale.
        /// The bounding box is computed to "frame" the face in accordance with human expectations. It is based on the
        /// landmarker results. Note that one or more x and/or y coordinates may not be generated in the `BoundingPoly`
        /// (the polygon will be unbounded) if only a partial face appears in the image to be annotated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual BoundingPoly BoundingPoly { get; set; }

        /// <summary>Detection confidence. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectionConfidence")]
        public virtual System.Nullable<float> DetectionConfidence { get; set; }

        /// <summary>
        /// The `fd_bounding_poly` bounding polygon is tighter than the `boundingPoly`, and encloses only the skin part
        /// of the face. Typically, it is used to eliminate the face from any image analysis that detects the "amount of
        /// skin" visible in an image. It is not based on the landmarker results, only on the initial face detection,
        /// hence the fd (face detection) prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fdBoundingPoly")]
        public virtual BoundingPoly FdBoundingPoly { get; set; }

        /// <summary>Headwear likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headwearLikelihood")]
        public virtual string HeadwearLikelihood { get; set; }

        /// <summary>Joy likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("joyLikelihood")]
        public virtual string JoyLikelihood { get; set; }

        /// <summary>Face landmarking confidence. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landmarkingConfidence")]
        public virtual System.Nullable<float> LandmarkingConfidence { get; set; }

        /// <summary>Detected face landmarks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landmarks")]
        public virtual System.Collections.Generic.IList<Landmark> Landmarks { get; set; }

        /// <summary>
        /// Yaw angle, which indicates the leftward/rightward angle that the face is pointing relative to the vertical
        /// plane perpendicular to the image. Range [-180,180].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("panAngle")]
        public virtual System.Nullable<float> PanAngle { get; set; }

        /// <summary>
        /// Roll angle, which indicates the amount of clockwise/anti-clockwise rotation of the face relative to the
        /// image vertical about the axis perpendicular to the face. Range [-180,180].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollAngle")]
        public virtual System.Nullable<float> RollAngle { get; set; }

        /// <summary>Sorrow likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sorrowLikelihood")]
        public virtual string SorrowLikelihood { get; set; }

        /// <summary>Surprise likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("surpriseLikelihood")]
        public virtual string SurpriseLikelihood { get; set; }

        /// <summary>
        /// Pitch angle, which indicates the upwards/downwards angle that the face is pointing relative to the image's
        /// horizontal plane. Range [-180,180].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tiltAngle")]
        public virtual System.Nullable<float> TiltAngle { get; set; }

        /// <summary>Under-exposed likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("underExposedLikelihood")]
        public virtual string UnderExposedLikelihood { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Google Cloud Storage location where the output will be written to.</summary>
    public class GcsDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Storage URI prefix where the results will be stored. Results will be in JSON format and
        /// preceded by its corresponding input URI prefix. This field can either represent a gcs file prefix or gcs
        /// directory. In either case, the uri should be unique because in order to get all of the output files, you
        /// will need to do a wildcard gcs search on the uri prefix you provide. Examples: * File Prefix:
        /// gs://bucket-name/here/filenameprefix The output files will be created in gs://bucket-name/here/ and the
        /// names of the output files will begin with "filenameprefix". * Directory Prefix:
        /// gs://bucket-name/some/location/ The output files will be created in gs://bucket-name/some/location/ and the
        /// names of the output files could be anything because there was no filename prefix specified. If multiple
        /// outputs, each response is still AnnotateFileResponse, each of which contains some subset of the full list of
        /// AnnotateImageResponse. Multiple outputs can happen if, for example, the output JSON is too large and
        /// overflows into multiple sharded files.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Google Cloud Storage location where the input will be read from.</summary>
    public class GcsSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Storage URI for the input file. This must only be a Google Cloud Storage object. Wildcards are
        /// not currently supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response to a single file annotation request. A file may contain one or more images, which individually have
    /// their own responses.
    /// </summary>
    public class GoogleCloudVisionV1p1beta1AnnotateFileResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set, represents the error message for the failed request. The `responses` field will not be set in this
        /// case.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>Information about the file for which this response is generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfig")]
        public virtual GoogleCloudVisionV1p1beta1InputConfig InputConfig { get; set; }

        /// <summary>
        /// Individual responses to images found within the file. This field will be empty if the `error` field is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responses")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1AnnotateImageResponse> Responses { get; set; }

        /// <summary>This field gives the total number of pages in the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalPages")]
        public virtual System.Nullable<int> TotalPages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to an image annotation request.</summary>
    public class GoogleCloudVisionV1p1beta1AnnotateImageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If present, contextual information is needed to understand where this image comes from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual GoogleCloudVisionV1p1beta1ImageAnnotationContext Context { get; set; }

        /// <summary>If present, crop hints have completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cropHintsAnnotation")]
        public virtual GoogleCloudVisionV1p1beta1CropHintsAnnotation CropHintsAnnotation { get; set; }

        /// <summary>
        /// If set, represents the error message for the operation. Note that filled-in image annotations are guaranteed
        /// to be correct, even when `error` is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>If present, face detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faceAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1FaceAnnotation> FaceAnnotations { get; set; }

        /// <summary>
        /// If present, text (OCR) detection or document (OCR) text detection has completed successfully. This
        /// annotation provides the structural hierarchy for the OCR detected text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullTextAnnotation")]
        public virtual GoogleCloudVisionV1p1beta1TextAnnotation FullTextAnnotation { get; set; }

        /// <summary>If present, image properties were extracted successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imagePropertiesAnnotation")]
        public virtual GoogleCloudVisionV1p1beta1ImageProperties ImagePropertiesAnnotation { get; set; }

        /// <summary>If present, label detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1EntityAnnotation> LabelAnnotations { get; set; }

        /// <summary>If present, landmark detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landmarkAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1EntityAnnotation> LandmarkAnnotations { get; set; }

        /// <summary>
        /// If present, localized object detection has completed successfully. This will be sorted descending by
        /// confidence score.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedObjectAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1LocalizedObjectAnnotation> LocalizedObjectAnnotations { get; set; }

        /// <summary>If present, logo detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logoAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1EntityAnnotation> LogoAnnotations { get; set; }

        /// <summary>If present, product search has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSearchResults")]
        public virtual GoogleCloudVisionV1p1beta1ProductSearchResults ProductSearchResults { get; set; }

        /// <summary>If present, safe-search annotation has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safeSearchAnnotation")]
        public virtual GoogleCloudVisionV1p1beta1SafeSearchAnnotation SafeSearchAnnotation { get; set; }

        /// <summary>If present, text (OCR) detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1EntityAnnotation> TextAnnotations { get; set; }

        /// <summary>If present, web detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webDetection")]
        public virtual GoogleCloudVisionV1p1beta1WebDetection WebDetection { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for a single offline file annotation request.</summary>
    public class GoogleCloudVisionV1p1beta1AsyncAnnotateFileResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The output location and metadata from AsyncAnnotateFileRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual GoogleCloudVisionV1p1beta1OutputConfig OutputConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to an async batch file annotation request.</summary>
    public class GoogleCloudVisionV1p1beta1AsyncBatchAnnotateFilesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of file annotation responses, one for each request in AsyncBatchAnnotateFilesRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responses")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1AsyncAnnotateFileResponse> Responses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Logical element on the page.</summary>
    public class GoogleCloudVisionV1p1beta1Block : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detected block type (text, image etc) for this block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockType")]
        public virtual string BlockType { get; set; }

        /// <summary>
        /// The bounding box for the block. The vertices are in the order of top-left, top-right, bottom-right,
        /// bottom-left. When a rotation of the bounding box is detected the rotation is represented as around the
        /// top-left corner as defined when the text is read in the 'natural' orientation. For example: * when the text
        /// is horizontal it might look like: 0----1 | | 3----2 * when it's rotated 180 degrees around the top-left
        /// corner it becomes: 2----3 | | 1----0 and the vertex order will still be (0, 1, 2, 3).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBox")]
        public virtual GoogleCloudVisionV1p1beta1BoundingPoly BoundingBox { get; set; }

        /// <summary>Confidence of the OCR results on the block. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>List of paragraphs in this block (if this blocks is of type text).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paragraphs")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1Paragraph> Paragraphs { get; set; }

        /// <summary>Additional information detected for the block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual GoogleCloudVisionV1p1beta1TextAnnotationTextProperty Property { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A bounding polygon for the detected image annotation.</summary>
    public class GoogleCloudVisionV1p1beta1BoundingPoly : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bounding polygon normalized vertices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedVertices")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1NormalizedVertex> NormalizedVertices { get; set; }

        /// <summary>The bounding polygon vertices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertices")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1Vertex> Vertices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Color information consists of RGB channels, score, and the fraction of the image that the color occupies in the
    /// image.
    /// </summary>
    public class GoogleCloudVisionV1p1beta1ColorInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>RGB components of the color.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual Color Color { get; set; }

        /// <summary>The fraction of pixels the color occupies in the image. Value in range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pixelFraction")]
        public virtual System.Nullable<float> PixelFraction { get; set; }

        /// <summary>Image-specific score for this color. Value in range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Single crop hint that is used to generate a new crop when serving an image.</summary>
    public class GoogleCloudVisionV1p1beta1CropHint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The bounding polygon for the crop region. The coordinates of the bounding box are in the original image's
        /// scale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudVisionV1p1beta1BoundingPoly BoundingPoly { get; set; }

        /// <summary>Confidence of this being a salient region. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Fraction of importance of this salient region with respect to the original image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importanceFraction")]
        public virtual System.Nullable<float> ImportanceFraction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set of crop hints that are used to generate new crops when serving images.</summary>
    public class GoogleCloudVisionV1p1beta1CropHintsAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Crop hint results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cropHints")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1CropHint> CropHints { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set of dominant colors and their corresponding scores.</summary>
    public class GoogleCloudVisionV1p1beta1DominantColorsAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>RGB color values with their score and pixel fraction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colors")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1ColorInfo> Colors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set of detected entity features.</summary>
    public class GoogleCloudVisionV1p1beta1EntityAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Image region to which this entity belongs. Not produced for `LABEL_DETECTION` features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudVisionV1p1beta1BoundingPoly BoundingPoly { get; set; }

        /// <summary>
        /// **Deprecated. Use `score` instead.** The accuracy of the entity detection in an image. For example, for an
        /// image in which the "Eiffel Tower" entity is detected, this field represents the confidence that there is a
        /// tower in the query image. Range [0, 1].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Entity textual description, expressed in its `locale` language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The language code for the locale in which the entity textual `description` is expressed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual string Locale { get; set; }

        /// <summary>
        /// The location information for the detected entity. Multiple `LocationInfo` elements can be present because
        /// one location may indicate the location of the scene in the image, and another location may indicate the
        /// location of the place where the image was taken. Location information is usually present for landmarks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1LocationInfo> Locations { get; set; }

        /// <summary>
        /// Opaque entity ID. Some IDs may be available in [Google Knowledge Graph Search
        /// API](https://developers.google.com/knowledge-graph/).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mid")]
        public virtual string Mid { get; set; }

        /// <summary>
        /// Some entities may have optional user-supplied `Property` (name/value) fields, such a score or string that
        /// qualifies the entity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1Property> Properties { get; set; }

        /// <summary>Overall score of the result. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>
        /// The relevancy of the ICA (Image Content Annotation) label to the image. For example, the relevancy of
        /// "tower" is likely higher to an image containing the detected "Eiffel Tower" than to an image containing a
        /// detected distant towering building, even though the confidence that there is a tower in each image may be
        /// the same. Range [0, 1].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicality")]
        public virtual System.Nullable<float> Topicality { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A face annotation object contains the results of face detection.</summary>
    public class GoogleCloudVisionV1p1beta1FaceAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Anger likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("angerLikelihood")]
        public virtual string AngerLikelihood { get; set; }

        /// <summary>Blurred likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blurredLikelihood")]
        public virtual string BlurredLikelihood { get; set; }

        /// <summary>
        /// The bounding polygon around the face. The coordinates of the bounding box are in the original image's scale.
        /// The bounding box is computed to "frame" the face in accordance with human expectations. It is based on the
        /// landmarker results. Note that one or more x and/or y coordinates may not be generated in the `BoundingPoly`
        /// (the polygon will be unbounded) if only a partial face appears in the image to be annotated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudVisionV1p1beta1BoundingPoly BoundingPoly { get; set; }

        /// <summary>Detection confidence. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectionConfidence")]
        public virtual System.Nullable<float> DetectionConfidence { get; set; }

        /// <summary>
        /// The `fd_bounding_poly` bounding polygon is tighter than the `boundingPoly`, and encloses only the skin part
        /// of the face. Typically, it is used to eliminate the face from any image analysis that detects the "amount of
        /// skin" visible in an image. It is not based on the landmarker results, only on the initial face detection,
        /// hence the fd (face detection) prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fdBoundingPoly")]
        public virtual GoogleCloudVisionV1p1beta1BoundingPoly FdBoundingPoly { get; set; }

        /// <summary>Headwear likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headwearLikelihood")]
        public virtual string HeadwearLikelihood { get; set; }

        /// <summary>Joy likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("joyLikelihood")]
        public virtual string JoyLikelihood { get; set; }

        /// <summary>Face landmarking confidence. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landmarkingConfidence")]
        public virtual System.Nullable<float> LandmarkingConfidence { get; set; }

        /// <summary>Detected face landmarks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landmarks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1FaceAnnotationLandmark> Landmarks { get; set; }

        /// <summary>
        /// Yaw angle, which indicates the leftward/rightward angle that the face is pointing relative to the vertical
        /// plane perpendicular to the image. Range [-180,180].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("panAngle")]
        public virtual System.Nullable<float> PanAngle { get; set; }

        /// <summary>
        /// Roll angle, which indicates the amount of clockwise/anti-clockwise rotation of the face relative to the
        /// image vertical about the axis perpendicular to the face. Range [-180,180].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollAngle")]
        public virtual System.Nullable<float> RollAngle { get; set; }

        /// <summary>Sorrow likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sorrowLikelihood")]
        public virtual string SorrowLikelihood { get; set; }

        /// <summary>Surprise likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("surpriseLikelihood")]
        public virtual string SurpriseLikelihood { get; set; }

        /// <summary>
        /// Pitch angle, which indicates the upwards/downwards angle that the face is pointing relative to the image's
        /// horizontal plane. Range [-180,180].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tiltAngle")]
        public virtual System.Nullable<float> TiltAngle { get; set; }

        /// <summary>Under-exposed likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("underExposedLikelihood")]
        public virtual string UnderExposedLikelihood { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A face-specific landmark (for example, a face feature).</summary>
    public class GoogleCloudVisionV1p1beta1FaceAnnotationLandmark : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Face landmark position.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual GoogleCloudVisionV1p1beta1Position Position { get; set; }

        /// <summary>Face landmark type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Google Cloud Storage location where the output will be written to.</summary>
    public class GoogleCloudVisionV1p1beta1GcsDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Storage URI prefix where the results will be stored. Results will be in JSON format and
        /// preceded by its corresponding input URI prefix. This field can either represent a gcs file prefix or gcs
        /// directory. In either case, the uri should be unique because in order to get all of the output files, you
        /// will need to do a wildcard gcs search on the uri prefix you provide. Examples: * File Prefix:
        /// gs://bucket-name/here/filenameprefix The output files will be created in gs://bucket-name/here/ and the
        /// names of the output files will begin with "filenameprefix". * Directory Prefix:
        /// gs://bucket-name/some/location/ The output files will be created in gs://bucket-name/some/location/ and the
        /// names of the output files could be anything because there was no filename prefix specified. If multiple
        /// outputs, each response is still AnnotateFileResponse, each of which contains some subset of the full list of
        /// AnnotateImageResponse. Multiple outputs can happen if, for example, the output JSON is too large and
        /// overflows into multiple sharded files.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Google Cloud Storage location where the input will be read from.</summary>
    public class GoogleCloudVisionV1p1beta1GcsSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Storage URI for the input file. This must only be a Google Cloud Storage object. Wildcards are
        /// not currently supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// If an image was produced from a file (e.g. a PDF), this message gives information about the source of that
    /// image.
    /// </summary>
    public class GoogleCloudVisionV1p1beta1ImageAnnotationContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the file was a PDF or TIFF, this field gives the page number within the file used to produce the image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageNumber")]
        public virtual System.Nullable<int> PageNumber { get; set; }

        /// <summary>The URI of the file used to produce the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Stores image properties, such as dominant colors.</summary>
    public class GoogleCloudVisionV1p1beta1ImageProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If present, dominant colors completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dominantColors")]
        public virtual GoogleCloudVisionV1p1beta1DominantColorsAnnotation DominantColors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The desired input location and metadata.</summary>
    public class GoogleCloudVisionV1p1beta1InputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// File content, represented as a stream of bytes. Note: As with all `bytes` fields, protobuffers use a pure
        /// binary representation, whereas JSON representations use base64. Currently, this field only works for
        /// BatchAnnotateFiles requests. It does not work for AsyncBatchAnnotateFiles requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>The Google Cloud Storage location to read the input from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GoogleCloudVisionV1p1beta1GcsSource GcsSource { get; set; }

        /// <summary>
        /// The type of the file. Currently only "application/pdf", "image/tiff" and "image/gif" are supported.
        /// Wildcards are not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set of detected objects with bounding boxes.</summary>
    public class GoogleCloudVisionV1p1beta1LocalizedObjectAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Image region to which this object belongs. This must be populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudVisionV1p1beta1BoundingPoly BoundingPoly { get; set; }

        /// <summary>
        /// The BCP-47 language code, such as "en-US" or "sr-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Object ID that should align with EntityAnnotation mid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mid")]
        public virtual string Mid { get; set; }

        /// <summary>Object name, expressed in its `language_code` language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Score of the result. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected entity location information.</summary>
    public class GoogleCloudVisionV1p1beta1LocationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>lat/long location coordinates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latLng")]
        public virtual LatLng LatLng { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A vertex represents a 2D point in the image. NOTE: the normalized vertex coordinates are relative to the
    /// original image and range from 0 to 1.
    /// </summary>
    public class GoogleCloudVisionV1p1beta1NormalizedVertex : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Contains metadata for the BatchAnnotateImages operation.</summary>
    public class GoogleCloudVisionV1p1beta1OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time when the batch request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Current state of the batch operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The time when the operation result was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The desired output location and metadata.</summary>
    public class GoogleCloudVisionV1p1beta1OutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The max number of response protos to put into each output JSON file on Google Cloud Storage. The valid range
        /// is [1, 100]. If not specified, the default value is 20. For example, for one pdf file with 100 pages, 100
        /// response protos will be generated. If `batch_size` = 20, then 5 json files each containing 20 response
        /// protos will be written under the prefix `gcs_destination`.`uri`. Currently, batch_size only applies to
        /// GcsDestination, with potential future support for other output configurations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchSize")]
        public virtual System.Nullable<int> BatchSize { get; set; }

        /// <summary>The Google Cloud Storage location to write the output(s) to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual GoogleCloudVisionV1p1beta1GcsDestination GcsDestination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected page from OCR.</summary>
    public class GoogleCloudVisionV1p1beta1Page : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of blocks of text, images etc on this page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1Block> Blocks { get; set; }

        /// <summary>Confidence of the OCR results on the page. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// Page height. For PDFs the unit is points. For images (including TIFFs) the unit is pixels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; }

        /// <summary>Additional information detected on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual GoogleCloudVisionV1p1beta1TextAnnotationTextProperty Property { get; set; }

        /// <summary>Page width. For PDFs the unit is points. For images (including TIFFs) the unit is pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Structural unit of text representing a number of words in certain order.</summary>
    public class GoogleCloudVisionV1p1beta1Paragraph : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The bounding box for the paragraph. The vertices are in the order of top-left, top-right, bottom-right,
        /// bottom-left. When a rotation of the bounding box is detected the rotation is represented as around the
        /// top-left corner as defined when the text is read in the 'natural' orientation. For example: * when the text
        /// is horizontal it might look like: 0----1 | | 3----2 * when it's rotated 180 degrees around the top-left
        /// corner it becomes: 2----3 | | 1----0 and the vertex order will still be (0, 1, 2, 3).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBox")]
        public virtual GoogleCloudVisionV1p1beta1BoundingPoly BoundingBox { get; set; }

        /// <summary>Confidence of the OCR results for the paragraph. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Additional information detected for the paragraph.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual GoogleCloudVisionV1p1beta1TextAnnotationTextProperty Property { get; set; }

        /// <summary>List of all words in this paragraph.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("words")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1Word> Words { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A 3D position in the image, used primarily for Face detection landmarks. A valid Position must have both x and y
    /// coordinates. The position coordinates are in the same scale as the original image.
    /// </summary>
    public class GoogleCloudVisionV1p1beta1Position : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual System.Nullable<float> X { get; set; }

        /// <summary>Y coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual System.Nullable<float> Y { get; set; }

        /// <summary>Z coordinate (or depth).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("z")]
        public virtual System.Nullable<float> Z { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Product contains ReferenceImages.</summary>
    public class GoogleCloudVisionV1p1beta1Product : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// User-provided metadata to be stored with this product. Must be at most 4096 characters long.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The user-provided name for this Product. Must not be empty. Must be at most 4096 characters long.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The resource name of the product. Format is: `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`.
        /// This field is ignored when creating a product.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. The category for the product identified by the reference image. This should be one of
        /// "homegoods-v2", "apparel-v2", "toys-v2", "packagedgoods-v1" or "general-v1". The legacy categories
        /// "homegoods", "apparel", and "toys" are still supported, but these should not be used for new products.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productCategory")]
        public virtual string ProductCategory { get; set; }

        /// <summary>
        /// Key-value pairs that can be attached to a product. At query time, constraints can be specified based on the
        /// product_labels. Note that integer values can be provided as strings, e.g. "1199". Only strings with integer
        /// values can match a range-based restriction which is to be supported soon. Multiple values can be assigned to
        /// the same key. One product may have up to 500 product_labels. Notice that the total number of distinct
        /// product_labels over all products in one ProductSet cannot exceed 1M, otherwise the product search pipeline
        /// will refuse to work for that ProductSet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productLabels")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1ProductKeyValue> ProductLabels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A product label represented as a key-value pair.</summary>
    public class GoogleCloudVisionV1p1beta1ProductKeyValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The key of the label attached to the product. Cannot be empty and cannot exceed 128 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// The value of the label attached to the product. Cannot be empty and cannot exceed 128 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Results for a product search request.</summary>
    public class GoogleCloudVisionV1p1beta1ProductSearchResults : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Timestamp of the index which provided these results. Products added to the product set and products removed
        /// from the product set after this time are not reflected in the current results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexTime")]
        public virtual object IndexTime { get; set; }

        /// <summary>
        /// List of results grouped by products detected in the query image. Each entry corresponds to one bounding
        /// polygon in the query image, and contains the matching products specific to that region. There may be
        /// duplicate product matches in the union of all the per-product results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productGroupedResults")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1ProductSearchResultsGroupedResult> ProductGroupedResults { get; set; }

        /// <summary>List of results, one for each product match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1ProductSearchResultsResult> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the products similar to a single product in a query image.</summary>
    public class GoogleCloudVisionV1p1beta1ProductSearchResultsGroupedResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bounding polygon around the product detected in the query image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudVisionV1p1beta1BoundingPoly BoundingPoly { get; set; }

        /// <summary>List of generic predictions for the object in the bounding box.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1ProductSearchResultsObjectAnnotation> ObjectAnnotations { get; set; }

        /// <summary>List of results, one for each product match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1ProductSearchResultsResult> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Prediction for what the object in the bounding box is.</summary>
    public class GoogleCloudVisionV1p1beta1ProductSearchResultsObjectAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The BCP-47 language code, such as "en-US" or "sr-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Object ID that should align with EntityAnnotation mid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mid")]
        public virtual string Mid { get; set; }

        /// <summary>Object name, expressed in its `language_code` language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Score of the result. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a product.</summary>
    public class GoogleCloudVisionV1p1beta1ProductSearchResultsResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name of the image from the product that is the closest match to the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual string Image { get; set; }

        /// <summary>The Product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual GoogleCloudVisionV1p1beta1Product Product { get; set; }

        /// <summary>A confidence level on the match, ranging from 0 (no confidence) to 1 (full confidence).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A `Property` consists of a user-supplied name/value pair.</summary>
    public class GoogleCloudVisionV1p1beta1Property : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Value of numeric properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uint64Value")]
        public virtual System.Nullable<ulong> Uint64Value { get; set; }

        /// <summary>Value of the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Set of features pertaining to the image, computed by computer vision methods over safe-search verticals (for
    /// example, adult, spoof, medical, violence).
    /// </summary>
    public class GoogleCloudVisionV1p1beta1SafeSearchAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Represents the adult content likelihood for the image. Adult content may contain elements such as nudity,
        /// pornographic images or cartoons, or sexual activities.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adult")]
        public virtual string Adult { get; set; }

        /// <summary>Likelihood that this is a medical image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("medical")]
        public virtual string Medical { get; set; }

        /// <summary>
        /// Likelihood that the request image contains racy content. Racy content may include (but is not limited to)
        /// skimpy or sheer clothing, strategically covered nudity, lewd or provocative poses, or close-ups of sensitive
        /// body areas.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("racy")]
        public virtual string Racy { get; set; }

        /// <summary>
        /// Spoof likelihood. The likelihood that an modification was made to the image's canonical version to make it
        /// appear funny or offensive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spoof")]
        public virtual string Spoof { get; set; }

        /// <summary>Likelihood that this image contains violent content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("violence")]
        public virtual string Violence { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single symbol representation.</summary>
    public class GoogleCloudVisionV1p1beta1Symbol : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The bounding box for the symbol. The vertices are in the order of top-left, top-right, bottom-right,
        /// bottom-left. When a rotation of the bounding box is detected the rotation is represented as around the
        /// top-left corner as defined when the text is read in the 'natural' orientation. For example: * when the text
        /// is horizontal it might look like: 0----1 | | 3----2 * when it's rotated 180 degrees around the top-left
        /// corner it becomes: 2----3 | | 1----0 and the vertex order will still be (0, 1, 2, 3).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBox")]
        public virtual GoogleCloudVisionV1p1beta1BoundingPoly BoundingBox { get; set; }

        /// <summary>Confidence of the OCR results for the symbol. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Additional information detected for the symbol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual GoogleCloudVisionV1p1beta1TextAnnotationTextProperty Property { get; set; }

        /// <summary>The actual UTF-8 representation of the symbol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// TextAnnotation contains a structured representation of OCR extracted text. The hierarchy of an OCR extracted
    /// text structure is like this: TextAnnotation -&amp;gt; Page -&amp;gt; Block -&amp;gt; Paragraph -&amp;gt; Word
    /// -&amp;gt; Symbol Each structural component, starting from Page, may further have their own properties.
    /// Properties describe detected languages, breaks etc.. Please refer to the TextAnnotation.TextProperty message
    /// definition below for more detail.
    /// </summary>
    public class GoogleCloudVisionV1p1beta1TextAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of pages detected by OCR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1Page> Pages { get; set; }

        /// <summary>UTF-8 text detected on the pages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected start or end of a structural component.</summary>
    public class GoogleCloudVisionV1p1beta1TextAnnotationDetectedBreak : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>True if break prepends the element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPrefix")]
        public virtual System.Nullable<bool> IsPrefix { get; set; }

        /// <summary>Detected break type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected language for a structural component.</summary>
    public class GoogleCloudVisionV1p1beta1TextAnnotationDetectedLanguage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Confidence of detected language. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// The BCP-47 language code, such as "en-US" or "sr-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional information detected on the structural component.</summary>
    public class GoogleCloudVisionV1p1beta1TextAnnotationTextProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detected start or end of a text segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedBreak")]
        public virtual GoogleCloudVisionV1p1beta1TextAnnotationDetectedBreak DetectedBreak { get; set; }

        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1TextAnnotationDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A vertex represents a 2D point in the image. NOTE: the vertex coordinates are in the same scale as the original
    /// image.
    /// </summary>
    public class GoogleCloudVisionV1p1beta1Vertex : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Relevant information for the image from the Internet.</summary>
    public class GoogleCloudVisionV1p1beta1WebDetection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The service's best guess as to the topic of the request image. Inferred from similar images on the open web.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bestGuessLabels")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1WebDetectionWebLabel> BestGuessLabels { get; set; }

        /// <summary>Fully matching images from the Internet. Can include resized copies of the query image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullMatchingImages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1WebDetectionWebImage> FullMatchingImages { get; set; }

        /// <summary>Web pages containing the matching images from the Internet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pagesWithMatchingImages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1WebDetectionWebPage> PagesWithMatchingImages { get; set; }

        /// <summary>
        /// Partial matching images from the Internet. Those images are similar enough to share some key-point features.
        /// For example an original image will likely have partial matching for its crops.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialMatchingImages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1WebDetectionWebImage> PartialMatchingImages { get; set; }

        /// <summary>The visually similar image results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visuallySimilarImages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1WebDetectionWebImage> VisuallySimilarImages { get; set; }

        /// <summary>Deduced entities from similar images on the Internet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webEntities")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1WebDetectionWebEntity> WebEntities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Entity deduced from similar images on the Internet.</summary>
    public class GoogleCloudVisionV1p1beta1WebDetectionWebEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Canonical description of the entity, in English.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Opaque entity ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityId")]
        public virtual string EntityId { get; set; }

        /// <summary>
        /// Overall relevancy score for the entity. Not normalized and not comparable across different image queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for online images.</summary>
    public class GoogleCloudVisionV1p1beta1WebDetectionWebImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>(Deprecated) Overall relevancy score for the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The result image URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Label to provide extra metadata for the web detection.</summary>
    public class GoogleCloudVisionV1p1beta1WebDetectionWebLabel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label for extra metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>
        /// The BCP-47 language code for `label`, such as "en-US" or "sr-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for web pages.</summary>
    public class GoogleCloudVisionV1p1beta1WebDetectionWebPage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Fully matching images on the page. Can include resized copies of the query image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullMatchingImages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1WebDetectionWebImage> FullMatchingImages { get; set; }

        /// <summary>Title for the web page, may contain HTML markups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageTitle")]
        public virtual string PageTitle { get; set; }

        /// <summary>
        /// Partial matching images on the page. Those images are similar enough to share some key-point features. For
        /// example an original image will likely have partial matching for its crops.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialMatchingImages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1WebDetectionWebImage> PartialMatchingImages { get; set; }

        /// <summary>(Deprecated) Overall relevancy score for the web page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The result web page URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A word representation.</summary>
    public class GoogleCloudVisionV1p1beta1Word : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The bounding box for the word. The vertices are in the order of top-left, top-right, bottom-right,
        /// bottom-left. When a rotation of the bounding box is detected the rotation is represented as around the
        /// top-left corner as defined when the text is read in the 'natural' orientation. For example: * when the text
        /// is horizontal it might look like: 0----1 | | 3----2 * when it's rotated 180 degrees around the top-left
        /// corner it becomes: 2----3 | | 1----0 and the vertex order will still be (0, 1, 2, 3).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBox")]
        public virtual GoogleCloudVisionV1p1beta1BoundingPoly BoundingBox { get; set; }

        /// <summary>Confidence of the OCR results for the word. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Additional information detected for the word.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual GoogleCloudVisionV1p1beta1TextAnnotationTextProperty Property { get; set; }

        /// <summary>List of symbols in the word. The order of the symbols follows the natural reading order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("symbols")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p1beta1Symbol> Symbols { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to annotate one single file, e.g. a PDF, TIFF or GIF file.</summary>
    public class GoogleCloudVisionV1p2beta1AnnotateFileRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Requested features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("features")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1Feature> Features { get; set; }

        /// <summary>Additional context that may accompany the image(s) in the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageContext")]
        public virtual GoogleCloudVisionV1p2beta1ImageContext ImageContext { get; set; }

        /// <summary>Required. Information about the input file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfig")]
        public virtual GoogleCloudVisionV1p2beta1InputConfig InputConfig { get; set; }

        /// <summary>
        /// Pages of the file to perform image annotation. Pages starts from 1, we assume the first page of the file is
        /// page 1. At most 5 pages are supported per request. Pages can be negative. Page 1 means the first page. Page
        /// 2 means the second page. Page -1 means the last page. Page -2 means the second to the last page. If the file
        /// is GIF instead of PDF or TIFF, page refers to GIF frames. If this field is empty, by default the service
        /// performs image annotation for the first 5 pages of the file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pages")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> Pages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response to a single file annotation request. A file may contain one or more images, which individually have
    /// their own responses.
    /// </summary>
    public class GoogleCloudVisionV1p2beta1AnnotateFileResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set, represents the error message for the failed request. The `responses` field will not be set in this
        /// case.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>Information about the file for which this response is generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfig")]
        public virtual GoogleCloudVisionV1p2beta1InputConfig InputConfig { get; set; }

        /// <summary>
        /// Individual responses to images found within the file. This field will be empty if the `error` field is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responses")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1AnnotateImageResponse> Responses { get; set; }

        /// <summary>This field gives the total number of pages in the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalPages")]
        public virtual System.Nullable<int> TotalPages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request for performing Google Cloud Vision API tasks over a user-provided image, with user-requested features,
    /// and with context information.
    /// </summary>
    public class GoogleCloudVisionV1p2beta1AnnotateImageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Requested features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("features")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1Feature> Features { get; set; }

        /// <summary>The image to be processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual GoogleCloudVisionV1p2beta1Image Image { get; set; }

        /// <summary>Additional context that may accompany the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageContext")]
        public virtual GoogleCloudVisionV1p2beta1ImageContext ImageContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to an image annotation request.</summary>
    public class GoogleCloudVisionV1p2beta1AnnotateImageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If present, contextual information is needed to understand where this image comes from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual GoogleCloudVisionV1p2beta1ImageAnnotationContext Context { get; set; }

        /// <summary>If present, crop hints have completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cropHintsAnnotation")]
        public virtual GoogleCloudVisionV1p2beta1CropHintsAnnotation CropHintsAnnotation { get; set; }

        /// <summary>
        /// If set, represents the error message for the operation. Note that filled-in image annotations are guaranteed
        /// to be correct, even when `error` is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>If present, face detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faceAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1FaceAnnotation> FaceAnnotations { get; set; }

        /// <summary>
        /// If present, text (OCR) detection or document (OCR) text detection has completed successfully. This
        /// annotation provides the structural hierarchy for the OCR detected text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullTextAnnotation")]
        public virtual GoogleCloudVisionV1p2beta1TextAnnotation FullTextAnnotation { get; set; }

        /// <summary>If present, image properties were extracted successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imagePropertiesAnnotation")]
        public virtual GoogleCloudVisionV1p2beta1ImageProperties ImagePropertiesAnnotation { get; set; }

        /// <summary>If present, label detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1EntityAnnotation> LabelAnnotations { get; set; }

        /// <summary>If present, landmark detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landmarkAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1EntityAnnotation> LandmarkAnnotations { get; set; }

        /// <summary>
        /// If present, localized object detection has completed successfully. This will be sorted descending by
        /// confidence score.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedObjectAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1LocalizedObjectAnnotation> LocalizedObjectAnnotations { get; set; }

        /// <summary>If present, logo detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logoAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1EntityAnnotation> LogoAnnotations { get; set; }

        /// <summary>If present, product search has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSearchResults")]
        public virtual GoogleCloudVisionV1p2beta1ProductSearchResults ProductSearchResults { get; set; }

        /// <summary>If present, safe-search annotation has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safeSearchAnnotation")]
        public virtual GoogleCloudVisionV1p2beta1SafeSearchAnnotation SafeSearchAnnotation { get; set; }

        /// <summary>If present, text (OCR) detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1EntityAnnotation> TextAnnotations { get; set; }

        /// <summary>If present, web detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webDetection")]
        public virtual GoogleCloudVisionV1p2beta1WebDetection WebDetection { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An offline file annotation request.</summary>
    public class GoogleCloudVisionV1p2beta1AsyncAnnotateFileRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Requested features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("features")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1Feature> Features { get; set; }

        /// <summary>Additional context that may accompany the image(s) in the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageContext")]
        public virtual GoogleCloudVisionV1p2beta1ImageContext ImageContext { get; set; }

        /// <summary>Required. Information about the input file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfig")]
        public virtual GoogleCloudVisionV1p2beta1InputConfig InputConfig { get; set; }

        /// <summary>Required. The desired output location and metadata (e.g. format).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual GoogleCloudVisionV1p2beta1OutputConfig OutputConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for a single offline file annotation request.</summary>
    public class GoogleCloudVisionV1p2beta1AsyncAnnotateFileResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The output location and metadata from AsyncAnnotateFileRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual GoogleCloudVisionV1p2beta1OutputConfig OutputConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Multiple async file annotation requests are batched into a single service call.</summary>
    public class GoogleCloudVisionV1p2beta1AsyncBatchAnnotateFilesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Target project and location to make a call. Format:
        /// `projects/{project-id}/locations/{location-id}`. If no parent is specified, a region will be chosen
        /// automatically. Supported location-ids: `us`: USA country only, `asia`: East asia areas, like Japan, Taiwan,
        /// `eu`: The European Union. Example: `projects/project-A/locations/eu`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>Required. Individual async file annotation requests for this batch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1AsyncAnnotateFileRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to an async batch file annotation request.</summary>
    public class GoogleCloudVisionV1p2beta1AsyncBatchAnnotateFilesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of file annotation responses, one for each request in AsyncBatchAnnotateFilesRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responses")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1AsyncAnnotateFileResponse> Responses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for async image annotation for a list of images.</summary>
    public class GoogleCloudVisionV1p2beta1AsyncBatchAnnotateImagesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The desired output location and metadata (e.g. format).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual GoogleCloudVisionV1p2beta1OutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Optional. Target project and location to make a call. Format:
        /// `projects/{project-id}/locations/{location-id}`. If no parent is specified, a region will be chosen
        /// automatically. Supported location-ids: `us`: USA country only, `asia`: East asia areas, like Japan, Taiwan,
        /// `eu`: The European Union. Example: `projects/project-A/locations/eu`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>Required. Individual image annotation requests for this batch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1AnnotateImageRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of requests to annotate files using the BatchAnnotateFiles API.</summary>
    public class GoogleCloudVisionV1p2beta1BatchAnnotateFilesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Target project and location to make a call. Format:
        /// `projects/{project-id}/locations/{location-id}`. If no parent is specified, a region will be chosen
        /// automatically. Supported location-ids: `us`: USA country only, `asia`: East asia areas, like Japan, Taiwan,
        /// `eu`: The European Union. Example: `projects/project-A/locations/eu`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Required. The list of file annotation requests. Right now we support only one AnnotateFileRequest in
        /// BatchAnnotateFilesRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1AnnotateFileRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of file annotation responses.</summary>
    public class GoogleCloudVisionV1p2beta1BatchAnnotateFilesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of file annotation responses, each response corresponding to each AnnotateFileRequest in
        /// BatchAnnotateFilesRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responses")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1AnnotateFileResponse> Responses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Multiple image annotation requests are batched into a single service call.</summary>
    public class GoogleCloudVisionV1p2beta1BatchAnnotateImagesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Target project and location to make a call. Format:
        /// `projects/{project-id}/locations/{location-id}`. If no parent is specified, a region will be chosen
        /// automatically. Supported location-ids: `us`: USA country only, `asia`: East asia areas, like Japan, Taiwan,
        /// `eu`: The European Union. Example: `projects/project-A/locations/eu`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>Required. Individual image annotation requests for this batch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1AnnotateImageRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to a batch image annotation request.</summary>
    public class GoogleCloudVisionV1p2beta1BatchAnnotateImagesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Individual responses to image annotation requests within the batch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responses")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1AnnotateImageResponse> Responses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Logical element on the page.</summary>
    public class GoogleCloudVisionV1p2beta1Block : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detected block type (text, image etc) for this block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockType")]
        public virtual string BlockType { get; set; }

        /// <summary>
        /// The bounding box for the block. The vertices are in the order of top-left, top-right, bottom-right,
        /// bottom-left. When a rotation of the bounding box is detected the rotation is represented as around the
        /// top-left corner as defined when the text is read in the 'natural' orientation. For example: * when the text
        /// is horizontal it might look like: 0----1 | | 3----2 * when it's rotated 180 degrees around the top-left
        /// corner it becomes: 2----3 | | 1----0 and the vertex order will still be (0, 1, 2, 3).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBox")]
        public virtual GoogleCloudVisionV1p2beta1BoundingPoly BoundingBox { get; set; }

        /// <summary>Confidence of the OCR results on the block. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>List of paragraphs in this block (if this blocks is of type text).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paragraphs")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1Paragraph> Paragraphs { get; set; }

        /// <summary>Additional information detected for the block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual GoogleCloudVisionV1p2beta1TextAnnotationTextProperty Property { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A bounding polygon for the detected image annotation.</summary>
    public class GoogleCloudVisionV1p2beta1BoundingPoly : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bounding polygon normalized vertices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedVertices")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1NormalizedVertex> NormalizedVertices { get; set; }

        /// <summary>The bounding polygon vertices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertices")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1Vertex> Vertices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Color information consists of RGB channels, score, and the fraction of the image that the color occupies in the
    /// image.
    /// </summary>
    public class GoogleCloudVisionV1p2beta1ColorInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>RGB components of the color.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual Color Color { get; set; }

        /// <summary>The fraction of pixels the color occupies in the image. Value in range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pixelFraction")]
        public virtual System.Nullable<float> PixelFraction { get; set; }

        /// <summary>Image-specific score for this color. Value in range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Single crop hint that is used to generate a new crop when serving an image.</summary>
    public class GoogleCloudVisionV1p2beta1CropHint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The bounding polygon for the crop region. The coordinates of the bounding box are in the original image's
        /// scale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudVisionV1p2beta1BoundingPoly BoundingPoly { get; set; }

        /// <summary>Confidence of this being a salient region. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Fraction of importance of this salient region with respect to the original image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importanceFraction")]
        public virtual System.Nullable<float> ImportanceFraction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set of crop hints that are used to generate new crops when serving images.</summary>
    public class GoogleCloudVisionV1p2beta1CropHintsAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Crop hint results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cropHints")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1CropHint> CropHints { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters for crop hints annotation request.</summary>
    public class GoogleCloudVisionV1p2beta1CropHintsParams : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Aspect ratios in floats, representing the ratio of the width to the height of the image. For example, if the
        /// desired aspect ratio is 4/3, the corresponding float value should be 1.33333. If not specified, the best
        /// possible crop is returned. The number of provided aspect ratios is limited to a maximum of 16; any aspect
        /// ratios provided after the 16th are ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aspectRatios")]
        public virtual System.Collections.Generic.IList<System.Nullable<float>> AspectRatios { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set of dominant colors and their corresponding scores.</summary>
    public class GoogleCloudVisionV1p2beta1DominantColorsAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>RGB color values with their score and pixel fraction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colors")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1ColorInfo> Colors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set of detected entity features.</summary>
    public class GoogleCloudVisionV1p2beta1EntityAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Image region to which this entity belongs. Not produced for `LABEL_DETECTION` features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudVisionV1p2beta1BoundingPoly BoundingPoly { get; set; }

        /// <summary>
        /// **Deprecated. Use `score` instead.** The accuracy of the entity detection in an image. For example, for an
        /// image in which the "Eiffel Tower" entity is detected, this field represents the confidence that there is a
        /// tower in the query image. Range [0, 1].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Entity textual description, expressed in its `locale` language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The language code for the locale in which the entity textual `description` is expressed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual string Locale { get; set; }

        /// <summary>
        /// The location information for the detected entity. Multiple `LocationInfo` elements can be present because
        /// one location may indicate the location of the scene in the image, and another location may indicate the
        /// location of the place where the image was taken. Location information is usually present for landmarks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1LocationInfo> Locations { get; set; }

        /// <summary>
        /// Opaque entity ID. Some IDs may be available in [Google Knowledge Graph Search
        /// API](https://developers.google.com/knowledge-graph/).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mid")]
        public virtual string Mid { get; set; }

        /// <summary>
        /// Some entities may have optional user-supplied `Property` (name/value) fields, such a score or string that
        /// qualifies the entity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1Property> Properties { get; set; }

        /// <summary>Overall score of the result. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>
        /// The relevancy of the ICA (Image Content Annotation) label to the image. For example, the relevancy of
        /// "tower" is likely higher to an image containing the detected "Eiffel Tower" than to an image containing a
        /// detected distant towering building, even though the confidence that there is a tower in each image may be
        /// the same. Range [0, 1].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicality")]
        public virtual System.Nullable<float> Topicality { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A face annotation object contains the results of face detection.</summary>
    public class GoogleCloudVisionV1p2beta1FaceAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Anger likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("angerLikelihood")]
        public virtual string AngerLikelihood { get; set; }

        /// <summary>Blurred likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blurredLikelihood")]
        public virtual string BlurredLikelihood { get; set; }

        /// <summary>
        /// The bounding polygon around the face. The coordinates of the bounding box are in the original image's scale.
        /// The bounding box is computed to "frame" the face in accordance with human expectations. It is based on the
        /// landmarker results. Note that one or more x and/or y coordinates may not be generated in the `BoundingPoly`
        /// (the polygon will be unbounded) if only a partial face appears in the image to be annotated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudVisionV1p2beta1BoundingPoly BoundingPoly { get; set; }

        /// <summary>Detection confidence. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectionConfidence")]
        public virtual System.Nullable<float> DetectionConfidence { get; set; }

        /// <summary>
        /// The `fd_bounding_poly` bounding polygon is tighter than the `boundingPoly`, and encloses only the skin part
        /// of the face. Typically, it is used to eliminate the face from any image analysis that detects the "amount of
        /// skin" visible in an image. It is not based on the landmarker results, only on the initial face detection,
        /// hence the fd (face detection) prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fdBoundingPoly")]
        public virtual GoogleCloudVisionV1p2beta1BoundingPoly FdBoundingPoly { get; set; }

        /// <summary>Headwear likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headwearLikelihood")]
        public virtual string HeadwearLikelihood { get; set; }

        /// <summary>Joy likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("joyLikelihood")]
        public virtual string JoyLikelihood { get; set; }

        /// <summary>Face landmarking confidence. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landmarkingConfidence")]
        public virtual System.Nullable<float> LandmarkingConfidence { get; set; }

        /// <summary>Detected face landmarks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landmarks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1FaceAnnotationLandmark> Landmarks { get; set; }

        /// <summary>
        /// Yaw angle, which indicates the leftward/rightward angle that the face is pointing relative to the vertical
        /// plane perpendicular to the image. Range [-180,180].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("panAngle")]
        public virtual System.Nullable<float> PanAngle { get; set; }

        /// <summary>
        /// Roll angle, which indicates the amount of clockwise/anti-clockwise rotation of the face relative to the
        /// image vertical about the axis perpendicular to the face. Range [-180,180].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollAngle")]
        public virtual System.Nullable<float> RollAngle { get; set; }

        /// <summary>Sorrow likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sorrowLikelihood")]
        public virtual string SorrowLikelihood { get; set; }

        /// <summary>Surprise likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("surpriseLikelihood")]
        public virtual string SurpriseLikelihood { get; set; }

        /// <summary>
        /// Pitch angle, which indicates the upwards/downwards angle that the face is pointing relative to the image's
        /// horizontal plane. Range [-180,180].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tiltAngle")]
        public virtual System.Nullable<float> TiltAngle { get; set; }

        /// <summary>Under-exposed likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("underExposedLikelihood")]
        public virtual string UnderExposedLikelihood { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A face-specific landmark (for example, a face feature).</summary>
    public class GoogleCloudVisionV1p2beta1FaceAnnotationLandmark : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Face landmark position.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual GoogleCloudVisionV1p2beta1Position Position { get; set; }

        /// <summary>Face landmark type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The type of Google Cloud Vision API detection to perform, and the maximum number of results to return for that
    /// type. Multiple `Feature` objects can be specified in the `features` list.
    /// </summary>
    public class GoogleCloudVisionV1p2beta1Feature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Maximum number of results of this type. Does not apply to `TEXT_DETECTION`, `DOCUMENT_TEXT_DETECTION`, or
        /// `CROP_HINTS`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxResults")]
        public virtual System.Nullable<int> MaxResults { get; set; }

        /// <summary>
        /// Model to use for the feature. Supported values: "builtin/stable" (the default if unset) and
        /// "builtin/latest".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>The feature type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Google Cloud Storage location where the output will be written to.</summary>
    public class GoogleCloudVisionV1p2beta1GcsDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Storage URI prefix where the results will be stored. Results will be in JSON format and
        /// preceded by its corresponding input URI prefix. This field can either represent a gcs file prefix or gcs
        /// directory. In either case, the uri should be unique because in order to get all of the output files, you
        /// will need to do a wildcard gcs search on the uri prefix you provide. Examples: * File Prefix:
        /// gs://bucket-name/here/filenameprefix The output files will be created in gs://bucket-name/here/ and the
        /// names of the output files will begin with "filenameprefix". * Directory Prefix:
        /// gs://bucket-name/some/location/ The output files will be created in gs://bucket-name/some/location/ and the
        /// names of the output files could be anything because there was no filename prefix specified. If multiple
        /// outputs, each response is still AnnotateFileResponse, each of which contains some subset of the full list of
        /// AnnotateImageResponse. Multiple outputs can happen if, for example, the output JSON is too large and
        /// overflows into multiple sharded files.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Google Cloud Storage location where the input will be read from.</summary>
    public class GoogleCloudVisionV1p2beta1GcsSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Storage URI for the input file. This must only be a Google Cloud Storage object. Wildcards are
        /// not currently supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Client image to perform Google Cloud Vision API tasks over.</summary>
    public class GoogleCloudVisionV1p2beta1Image : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Image content, represented as a stream of bytes. Note: As with all `bytes` fields, protobuffers use a pure
        /// binary representation, whereas JSON representations use base64. Currently, this field only works for
        /// BatchAnnotateImages requests. It does not work for AsyncBatchAnnotateImages requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>
        /// Google Cloud Storage image location, or publicly-accessible image URL. If both `content` and `source` are
        /// provided for an image, `content` takes precedence and is used to perform the image annotation request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual GoogleCloudVisionV1p2beta1ImageSource Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// If an image was produced from a file (e.g. a PDF), this message gives information about the source of that
    /// image.
    /// </summary>
    public class GoogleCloudVisionV1p2beta1ImageAnnotationContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the file was a PDF or TIFF, this field gives the page number within the file used to produce the image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageNumber")]
        public virtual System.Nullable<int> PageNumber { get; set; }

        /// <summary>The URI of the file used to produce the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Image context and/or feature-specific parameters.</summary>
    public class GoogleCloudVisionV1p2beta1ImageContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Parameters for crop hints annotation request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cropHintsParams")]
        public virtual GoogleCloudVisionV1p2beta1CropHintsParams CropHintsParams { get; set; }

        /// <summary>
        /// List of languages to use for TEXT_DETECTION. In most cases, an empty value yields the best results since it
        /// enables automatic language detection. For languages based on the Latin alphabet, setting `language_hints` is
        /// not needed. In rare cases, when the language of the text in the image is known, setting a hint will help get
        /// better results (although it will be a significant hindrance if the hint is wrong). Text detection returns an
        /// error if one or more of the specified languages is not one of the [supported
        /// languages](https://cloud.google.com/vision/docs/languages).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageHints")]
        public virtual System.Collections.Generic.IList<string> LanguageHints { get; set; }

        /// <summary>Not used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latLongRect")]
        public virtual GoogleCloudVisionV1p2beta1LatLongRect LatLongRect { get; set; }

        /// <summary>Parameters for product search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSearchParams")]
        public virtual GoogleCloudVisionV1p2beta1ProductSearchParams ProductSearchParams { get; set; }

        /// <summary>Parameters for text detection and document text detection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textDetectionParams")]
        public virtual GoogleCloudVisionV1p2beta1TextDetectionParams TextDetectionParams { get; set; }

        /// <summary>Parameters for web detection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webDetectionParams")]
        public virtual GoogleCloudVisionV1p2beta1WebDetectionParams WebDetectionParams { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Stores image properties, such as dominant colors.</summary>
    public class GoogleCloudVisionV1p2beta1ImageProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If present, dominant colors completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dominantColors")]
        public virtual GoogleCloudVisionV1p2beta1DominantColorsAnnotation DominantColors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>External image source (Google Cloud Storage or web URL image location).</summary>
    public class GoogleCloudVisionV1p2beta1ImageSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// **Use `image_uri` instead.** The Google Cloud Storage URI of the form `gs://bucket_name/object_name`. Object
        /// versioning is not supported. See [Google Cloud Storage Request
        /// URIs](https://cloud.google.com/storage/docs/reference-uris) for more info.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsImageUri")]
        public virtual string GcsImageUri { get; set; }

        /// <summary>
        /// The URI of the source image. Can be either: 1. A Google Cloud Storage URI of the form
        /// `gs://bucket_name/object_name`. Object versioning is not supported. See [Google Cloud Storage Request
        /// URIs](https://cloud.google.com/storage/docs/reference-uris) for more info. 2. A publicly-accessible image
        /// HTTP/HTTPS URL. When fetching images from HTTP/HTTPS URLs, Google cannot guarantee that the request will be
        /// completed. Your request may fail if the specified host denies the request (e.g. due to request throttling or
        /// DOS prevention), or if Google throttles requests to the site for abuse prevention. You should not depend on
        /// externally-hosted images for production applications. When both `gcs_image_uri` and `image_uri` are
        /// specified, `image_uri` takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The desired input location and metadata.</summary>
    public class GoogleCloudVisionV1p2beta1InputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// File content, represented as a stream of bytes. Note: As with all `bytes` fields, protobuffers use a pure
        /// binary representation, whereas JSON representations use base64. Currently, this field only works for
        /// BatchAnnotateFiles requests. It does not work for AsyncBatchAnnotateFiles requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>The Google Cloud Storage location to read the input from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GoogleCloudVisionV1p2beta1GcsSource GcsSource { get; set; }

        /// <summary>
        /// The type of the file. Currently only "application/pdf", "image/tiff" and "image/gif" are supported.
        /// Wildcards are not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Rectangle determined by min and max `LatLng` pairs.</summary>
    public class GoogleCloudVisionV1p2beta1LatLongRect : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Max lat/long pair.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxLatLng")]
        public virtual LatLng MaxLatLng { get; set; }

        /// <summary>Min lat/long pair.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minLatLng")]
        public virtual LatLng MinLatLng { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set of detected objects with bounding boxes.</summary>
    public class GoogleCloudVisionV1p2beta1LocalizedObjectAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Image region to which this object belongs. This must be populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudVisionV1p2beta1BoundingPoly BoundingPoly { get; set; }

        /// <summary>
        /// The BCP-47 language code, such as "en-US" or "sr-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Object ID that should align with EntityAnnotation mid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mid")]
        public virtual string Mid { get; set; }

        /// <summary>Object name, expressed in its `language_code` language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Score of the result. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected entity location information.</summary>
    public class GoogleCloudVisionV1p2beta1LocationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>lat/long location coordinates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latLng")]
        public virtual LatLng LatLng { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A vertex represents a 2D point in the image. NOTE: the normalized vertex coordinates are relative to the
    /// original image and range from 0 to 1.
    /// </summary>
    public class GoogleCloudVisionV1p2beta1NormalizedVertex : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Contains metadata for the BatchAnnotateImages operation.</summary>
    public class GoogleCloudVisionV1p2beta1OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time when the batch request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Current state of the batch operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The time when the operation result was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The desired output location and metadata.</summary>
    public class GoogleCloudVisionV1p2beta1OutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The max number of response protos to put into each output JSON file on Google Cloud Storage. The valid range
        /// is [1, 100]. If not specified, the default value is 20. For example, for one pdf file with 100 pages, 100
        /// response protos will be generated. If `batch_size` = 20, then 5 json files each containing 20 response
        /// protos will be written under the prefix `gcs_destination`.`uri`. Currently, batch_size only applies to
        /// GcsDestination, with potential future support for other output configurations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchSize")]
        public virtual System.Nullable<int> BatchSize { get; set; }

        /// <summary>The Google Cloud Storage location to write the output(s) to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual GoogleCloudVisionV1p2beta1GcsDestination GcsDestination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected page from OCR.</summary>
    public class GoogleCloudVisionV1p2beta1Page : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of blocks of text, images etc on this page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1Block> Blocks { get; set; }

        /// <summary>Confidence of the OCR results on the page. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// Page height. For PDFs the unit is points. For images (including TIFFs) the unit is pixels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; }

        /// <summary>Additional information detected on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual GoogleCloudVisionV1p2beta1TextAnnotationTextProperty Property { get; set; }

        /// <summary>Page width. For PDFs the unit is points. For images (including TIFFs) the unit is pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Structural unit of text representing a number of words in certain order.</summary>
    public class GoogleCloudVisionV1p2beta1Paragraph : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The bounding box for the paragraph. The vertices are in the order of top-left, top-right, bottom-right,
        /// bottom-left. When a rotation of the bounding box is detected the rotation is represented as around the
        /// top-left corner as defined when the text is read in the 'natural' orientation. For example: * when the text
        /// is horizontal it might look like: 0----1 | | 3----2 * when it's rotated 180 degrees around the top-left
        /// corner it becomes: 2----3 | | 1----0 and the vertex order will still be (0, 1, 2, 3).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBox")]
        public virtual GoogleCloudVisionV1p2beta1BoundingPoly BoundingBox { get; set; }

        /// <summary>Confidence of the OCR results for the paragraph. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Additional information detected for the paragraph.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual GoogleCloudVisionV1p2beta1TextAnnotationTextProperty Property { get; set; }

        /// <summary>List of all words in this paragraph.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("words")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1Word> Words { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A 3D position in the image, used primarily for Face detection landmarks. A valid Position must have both x and y
    /// coordinates. The position coordinates are in the same scale as the original image.
    /// </summary>
    public class GoogleCloudVisionV1p2beta1Position : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual System.Nullable<float> X { get; set; }

        /// <summary>Y coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual System.Nullable<float> Y { get; set; }

        /// <summary>Z coordinate (or depth).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("z")]
        public virtual System.Nullable<float> Z { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Product contains ReferenceImages.</summary>
    public class GoogleCloudVisionV1p2beta1Product : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// User-provided metadata to be stored with this product. Must be at most 4096 characters long.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The user-provided name for this Product. Must not be empty. Must be at most 4096 characters long.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The resource name of the product. Format is: `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`.
        /// This field is ignored when creating a product.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. The category for the product identified by the reference image. This should be one of
        /// "homegoods-v2", "apparel-v2", "toys-v2", "packagedgoods-v1" or "general-v1". The legacy categories
        /// "homegoods", "apparel", and "toys" are still supported, but these should not be used for new products.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productCategory")]
        public virtual string ProductCategory { get; set; }

        /// <summary>
        /// Key-value pairs that can be attached to a product. At query time, constraints can be specified based on the
        /// product_labels. Note that integer values can be provided as strings, e.g. "1199". Only strings with integer
        /// values can match a range-based restriction which is to be supported soon. Multiple values can be assigned to
        /// the same key. One product may have up to 500 product_labels. Notice that the total number of distinct
        /// product_labels over all products in one ProductSet cannot exceed 1M, otherwise the product search pipeline
        /// will refuse to work for that ProductSet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productLabels")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1ProductKeyValue> ProductLabels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A product label represented as a key-value pair.</summary>
    public class GoogleCloudVisionV1p2beta1ProductKeyValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The key of the label attached to the product. Cannot be empty and cannot exceed 128 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// The value of the label attached to the product. Cannot be empty and cannot exceed 128 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters for a product search request.</summary>
    public class GoogleCloudVisionV1p2beta1ProductSearchParams : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The bounding polygon around the area of interest in the image. If it is not specified, system discretion
        /// will be applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudVisionV1p2beta1BoundingPoly BoundingPoly { get; set; }

        /// <summary>
        /// The filtering expression. This can be used to restrict search results based on Product labels. We currently
        /// support an AND of OR of key-value expressions, where each expression within an OR must have the same key. An
        /// '=' should be used to connect the key and value. For example, "(color = red OR color = blue) AND brand =
        /// Google" is acceptable, but "(color = red OR brand = Google)" is not acceptable. "color: red" is not
        /// acceptable because it uses a ':' instead of an '='.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// The list of product categories to search in. Currently, we only consider the first category, and either
        /// "homegoods-v2", "apparel-v2", "toys-v2", "packagedgoods-v1", or "general-v1" should be specified. The legacy
        /// categories "homegoods", "apparel", and "toys" are still supported but will be deprecated. For new products,
        /// please use "homegoods-v2", "apparel-v2", or "toys-v2" for better product search accuracy. It is recommended
        /// to migrate existing products to these categories as well.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productCategories")]
        public virtual System.Collections.Generic.IList<string> ProductCategories { get; set; }

        /// <summary>
        /// The resource name of a ProductSet to be searched for similar images. Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSet")]
        public virtual string ProductSet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Results for a product search request.</summary>
    public class GoogleCloudVisionV1p2beta1ProductSearchResults : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Timestamp of the index which provided these results. Products added to the product set and products removed
        /// from the product set after this time are not reflected in the current results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexTime")]
        public virtual object IndexTime { get; set; }

        /// <summary>
        /// List of results grouped by products detected in the query image. Each entry corresponds to one bounding
        /// polygon in the query image, and contains the matching products specific to that region. There may be
        /// duplicate product matches in the union of all the per-product results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productGroupedResults")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1ProductSearchResultsGroupedResult> ProductGroupedResults { get; set; }

        /// <summary>List of results, one for each product match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1ProductSearchResultsResult> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the products similar to a single product in a query image.</summary>
    public class GoogleCloudVisionV1p2beta1ProductSearchResultsGroupedResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bounding polygon around the product detected in the query image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudVisionV1p2beta1BoundingPoly BoundingPoly { get; set; }

        /// <summary>List of generic predictions for the object in the bounding box.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1ProductSearchResultsObjectAnnotation> ObjectAnnotations { get; set; }

        /// <summary>List of results, one for each product match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1ProductSearchResultsResult> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Prediction for what the object in the bounding box is.</summary>
    public class GoogleCloudVisionV1p2beta1ProductSearchResultsObjectAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The BCP-47 language code, such as "en-US" or "sr-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Object ID that should align with EntityAnnotation mid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mid")]
        public virtual string Mid { get; set; }

        /// <summary>Object name, expressed in its `language_code` language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Score of the result. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a product.</summary>
    public class GoogleCloudVisionV1p2beta1ProductSearchResultsResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name of the image from the product that is the closest match to the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual string Image { get; set; }

        /// <summary>The Product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual GoogleCloudVisionV1p2beta1Product Product { get; set; }

        /// <summary>A confidence level on the match, ranging from 0 (no confidence) to 1 (full confidence).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A `Property` consists of a user-supplied name/value pair.</summary>
    public class GoogleCloudVisionV1p2beta1Property : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Value of numeric properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uint64Value")]
        public virtual System.Nullable<ulong> Uint64Value { get; set; }

        /// <summary>Value of the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Set of features pertaining to the image, computed by computer vision methods over safe-search verticals (for
    /// example, adult, spoof, medical, violence).
    /// </summary>
    public class GoogleCloudVisionV1p2beta1SafeSearchAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Represents the adult content likelihood for the image. Adult content may contain elements such as nudity,
        /// pornographic images or cartoons, or sexual activities.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adult")]
        public virtual string Adult { get; set; }

        /// <summary>Likelihood that this is a medical image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("medical")]
        public virtual string Medical { get; set; }

        /// <summary>
        /// Likelihood that the request image contains racy content. Racy content may include (but is not limited to)
        /// skimpy or sheer clothing, strategically covered nudity, lewd or provocative poses, or close-ups of sensitive
        /// body areas.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("racy")]
        public virtual string Racy { get; set; }

        /// <summary>
        /// Spoof likelihood. The likelihood that an modification was made to the image's canonical version to make it
        /// appear funny or offensive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spoof")]
        public virtual string Spoof { get; set; }

        /// <summary>Likelihood that this image contains violent content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("violence")]
        public virtual string Violence { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single symbol representation.</summary>
    public class GoogleCloudVisionV1p2beta1Symbol : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The bounding box for the symbol. The vertices are in the order of top-left, top-right, bottom-right,
        /// bottom-left. When a rotation of the bounding box is detected the rotation is represented as around the
        /// top-left corner as defined when the text is read in the 'natural' orientation. For example: * when the text
        /// is horizontal it might look like: 0----1 | | 3----2 * when it's rotated 180 degrees around the top-left
        /// corner it becomes: 2----3 | | 1----0 and the vertex order will still be (0, 1, 2, 3).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBox")]
        public virtual GoogleCloudVisionV1p2beta1BoundingPoly BoundingBox { get; set; }

        /// <summary>Confidence of the OCR results for the symbol. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Additional information detected for the symbol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual GoogleCloudVisionV1p2beta1TextAnnotationTextProperty Property { get; set; }

        /// <summary>The actual UTF-8 representation of the symbol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// TextAnnotation contains a structured representation of OCR extracted text. The hierarchy of an OCR extracted
    /// text structure is like this: TextAnnotation -&amp;gt; Page -&amp;gt; Block -&amp;gt; Paragraph -&amp;gt; Word
    /// -&amp;gt; Symbol Each structural component, starting from Page, may further have their own properties.
    /// Properties describe detected languages, breaks etc.. Please refer to the TextAnnotation.TextProperty message
    /// definition below for more detail.
    /// </summary>
    public class GoogleCloudVisionV1p2beta1TextAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of pages detected by OCR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1Page> Pages { get; set; }

        /// <summary>UTF-8 text detected on the pages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected start or end of a structural component.</summary>
    public class GoogleCloudVisionV1p2beta1TextAnnotationDetectedBreak : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>True if break prepends the element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPrefix")]
        public virtual System.Nullable<bool> IsPrefix { get; set; }

        /// <summary>Detected break type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected language for a structural component.</summary>
    public class GoogleCloudVisionV1p2beta1TextAnnotationDetectedLanguage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Confidence of detected language. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// The BCP-47 language code, such as "en-US" or "sr-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional information detected on the structural component.</summary>
    public class GoogleCloudVisionV1p2beta1TextAnnotationTextProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detected start or end of a text segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedBreak")]
        public virtual GoogleCloudVisionV1p2beta1TextAnnotationDetectedBreak DetectedBreak { get; set; }

        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1TextAnnotationDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Parameters for text detections. This is used to control TEXT_DETECTION and DOCUMENT_TEXT_DETECTION features.
    /// </summary>
    public class GoogleCloudVisionV1p2beta1TextDetectionParams : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// By default, Cloud Vision API only includes confidence score for DOCUMENT_TEXT_DETECTION result. Set the flag
        /// to true to include confidence score for TEXT_DETECTION as well.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableTextDetectionConfidenceScore")]
        public virtual System.Nullable<bool> EnableTextDetectionConfidenceScore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A vertex represents a 2D point in the image. NOTE: the vertex coordinates are in the same scale as the original
    /// image.
    /// </summary>
    public class GoogleCloudVisionV1p2beta1Vertex : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Relevant information for the image from the Internet.</summary>
    public class GoogleCloudVisionV1p2beta1WebDetection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The service's best guess as to the topic of the request image. Inferred from similar images on the open web.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bestGuessLabels")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1WebDetectionWebLabel> BestGuessLabels { get; set; }

        /// <summary>Fully matching images from the Internet. Can include resized copies of the query image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullMatchingImages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1WebDetectionWebImage> FullMatchingImages { get; set; }

        /// <summary>Web pages containing the matching images from the Internet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pagesWithMatchingImages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1WebDetectionWebPage> PagesWithMatchingImages { get; set; }

        /// <summary>
        /// Partial matching images from the Internet. Those images are similar enough to share some key-point features.
        /// For example an original image will likely have partial matching for its crops.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialMatchingImages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1WebDetectionWebImage> PartialMatchingImages { get; set; }

        /// <summary>The visually similar image results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visuallySimilarImages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1WebDetectionWebImage> VisuallySimilarImages { get; set; }

        /// <summary>Deduced entities from similar images on the Internet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webEntities")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1WebDetectionWebEntity> WebEntities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters for web detection request.</summary>
    public class GoogleCloudVisionV1p2beta1WebDetectionParams : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether to include results derived from the geo information in the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeGeoResults")]
        public virtual System.Nullable<bool> IncludeGeoResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Entity deduced from similar images on the Internet.</summary>
    public class GoogleCloudVisionV1p2beta1WebDetectionWebEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Canonical description of the entity, in English.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Opaque entity ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityId")]
        public virtual string EntityId { get; set; }

        /// <summary>
        /// Overall relevancy score for the entity. Not normalized and not comparable across different image queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for online images.</summary>
    public class GoogleCloudVisionV1p2beta1WebDetectionWebImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>(Deprecated) Overall relevancy score for the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The result image URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Label to provide extra metadata for the web detection.</summary>
    public class GoogleCloudVisionV1p2beta1WebDetectionWebLabel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label for extra metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>
        /// The BCP-47 language code for `label`, such as "en-US" or "sr-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for web pages.</summary>
    public class GoogleCloudVisionV1p2beta1WebDetectionWebPage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Fully matching images on the page. Can include resized copies of the query image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullMatchingImages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1WebDetectionWebImage> FullMatchingImages { get; set; }

        /// <summary>Title for the web page, may contain HTML markups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageTitle")]
        public virtual string PageTitle { get; set; }

        /// <summary>
        /// Partial matching images on the page. Those images are similar enough to share some key-point features. For
        /// example an original image will likely have partial matching for its crops.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialMatchingImages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1WebDetectionWebImage> PartialMatchingImages { get; set; }

        /// <summary>(Deprecated) Overall relevancy score for the web page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The result web page URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A word representation.</summary>
    public class GoogleCloudVisionV1p2beta1Word : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The bounding box for the word. The vertices are in the order of top-left, top-right, bottom-right,
        /// bottom-left. When a rotation of the bounding box is detected the rotation is represented as around the
        /// top-left corner as defined when the text is read in the 'natural' orientation. For example: * when the text
        /// is horizontal it might look like: 0----1 | | 3----2 * when it's rotated 180 degrees around the top-left
        /// corner it becomes: 2----3 | | 1----0 and the vertex order will still be (0, 1, 2, 3).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBox")]
        public virtual GoogleCloudVisionV1p2beta1BoundingPoly BoundingBox { get; set; }

        /// <summary>Confidence of the OCR results for the word. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Additional information detected for the word.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual GoogleCloudVisionV1p2beta1TextAnnotationTextProperty Property { get; set; }

        /// <summary>List of symbols in the word. The order of the symbols follows the natural reading order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("symbols")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p2beta1Symbol> Symbols { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response to a single file annotation request. A file may contain one or more images, which individually have
    /// their own responses.
    /// </summary>
    public class GoogleCloudVisionV1p3beta1AnnotateFileResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set, represents the error message for the failed request. The `responses` field will not be set in this
        /// case.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>Information about the file for which this response is generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfig")]
        public virtual GoogleCloudVisionV1p3beta1InputConfig InputConfig { get; set; }

        /// <summary>
        /// Individual responses to images found within the file. This field will be empty if the `error` field is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responses")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1AnnotateImageResponse> Responses { get; set; }

        /// <summary>This field gives the total number of pages in the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalPages")]
        public virtual System.Nullable<int> TotalPages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to an image annotation request.</summary>
    public class GoogleCloudVisionV1p3beta1AnnotateImageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If present, contextual information is needed to understand where this image comes from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual GoogleCloudVisionV1p3beta1ImageAnnotationContext Context { get; set; }

        /// <summary>If present, crop hints have completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cropHintsAnnotation")]
        public virtual GoogleCloudVisionV1p3beta1CropHintsAnnotation CropHintsAnnotation { get; set; }

        /// <summary>
        /// If set, represents the error message for the operation. Note that filled-in image annotations are guaranteed
        /// to be correct, even when `error` is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>If present, face detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faceAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1FaceAnnotation> FaceAnnotations { get; set; }

        /// <summary>
        /// If present, text (OCR) detection or document (OCR) text detection has completed successfully. This
        /// annotation provides the structural hierarchy for the OCR detected text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullTextAnnotation")]
        public virtual GoogleCloudVisionV1p3beta1TextAnnotation FullTextAnnotation { get; set; }

        /// <summary>If present, image properties were extracted successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imagePropertiesAnnotation")]
        public virtual GoogleCloudVisionV1p3beta1ImageProperties ImagePropertiesAnnotation { get; set; }

        /// <summary>If present, label detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1EntityAnnotation> LabelAnnotations { get; set; }

        /// <summary>If present, landmark detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landmarkAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1EntityAnnotation> LandmarkAnnotations { get; set; }

        /// <summary>
        /// If present, localized object detection has completed successfully. This will be sorted descending by
        /// confidence score.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedObjectAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1LocalizedObjectAnnotation> LocalizedObjectAnnotations { get; set; }

        /// <summary>If present, logo detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logoAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1EntityAnnotation> LogoAnnotations { get; set; }

        /// <summary>If present, product search has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSearchResults")]
        public virtual GoogleCloudVisionV1p3beta1ProductSearchResults ProductSearchResults { get; set; }

        /// <summary>If present, safe-search annotation has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safeSearchAnnotation")]
        public virtual GoogleCloudVisionV1p3beta1SafeSearchAnnotation SafeSearchAnnotation { get; set; }

        /// <summary>If present, text (OCR) detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1EntityAnnotation> TextAnnotations { get; set; }

        /// <summary>If present, web detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webDetection")]
        public virtual GoogleCloudVisionV1p3beta1WebDetection WebDetection { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for a single offline file annotation request.</summary>
    public class GoogleCloudVisionV1p3beta1AsyncAnnotateFileResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The output location and metadata from AsyncAnnotateFileRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual GoogleCloudVisionV1p3beta1OutputConfig OutputConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to an async batch file annotation request.</summary>
    public class GoogleCloudVisionV1p3beta1AsyncBatchAnnotateFilesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of file annotation responses, one for each request in AsyncBatchAnnotateFilesRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responses")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1AsyncAnnotateFileResponse> Responses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata for the batch operations such as the current state. This is included in the `metadata` field of the
    /// `Operation` returned by the `GetOperation` call of the `google::longrunning::Operations` service.
    /// </summary>
    public class GoogleCloudVisionV1p3beta1BatchOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The time when the batch request is finished and google.longrunning.Operation.done is set to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The current state of the batch operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The time when the batch request was submitted to the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("submitTime")]
        public virtual object SubmitTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Logical element on the page.</summary>
    public class GoogleCloudVisionV1p3beta1Block : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detected block type (text, image etc) for this block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockType")]
        public virtual string BlockType { get; set; }

        /// <summary>
        /// The bounding box for the block. The vertices are in the order of top-left, top-right, bottom-right,
        /// bottom-left. When a rotation of the bounding box is detected the rotation is represented as around the
        /// top-left corner as defined when the text is read in the 'natural' orientation. For example: * when the text
        /// is horizontal it might look like: 0----1 | | 3----2 * when it's rotated 180 degrees around the top-left
        /// corner it becomes: 2----3 | | 1----0 and the vertex order will still be (0, 1, 2, 3).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBox")]
        public virtual GoogleCloudVisionV1p3beta1BoundingPoly BoundingBox { get; set; }

        /// <summary>Confidence of the OCR results on the block. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>List of paragraphs in this block (if this blocks is of type text).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paragraphs")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1Paragraph> Paragraphs { get; set; }

        /// <summary>Additional information detected for the block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual GoogleCloudVisionV1p3beta1TextAnnotationTextProperty Property { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A bounding polygon for the detected image annotation.</summary>
    public class GoogleCloudVisionV1p3beta1BoundingPoly : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bounding polygon normalized vertices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedVertices")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1NormalizedVertex> NormalizedVertices { get; set; }

        /// <summary>The bounding polygon vertices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertices")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1Vertex> Vertices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Color information consists of RGB channels, score, and the fraction of the image that the color occupies in the
    /// image.
    /// </summary>
    public class GoogleCloudVisionV1p3beta1ColorInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>RGB components of the color.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual Color Color { get; set; }

        /// <summary>The fraction of pixels the color occupies in the image. Value in range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pixelFraction")]
        public virtual System.Nullable<float> PixelFraction { get; set; }

        /// <summary>Image-specific score for this color. Value in range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Single crop hint that is used to generate a new crop when serving an image.</summary>
    public class GoogleCloudVisionV1p3beta1CropHint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The bounding polygon for the crop region. The coordinates of the bounding box are in the original image's
        /// scale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudVisionV1p3beta1BoundingPoly BoundingPoly { get; set; }

        /// <summary>Confidence of this being a salient region. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Fraction of importance of this salient region with respect to the original image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importanceFraction")]
        public virtual System.Nullable<float> ImportanceFraction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set of crop hints that are used to generate new crops when serving images.</summary>
    public class GoogleCloudVisionV1p3beta1CropHintsAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Crop hint results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cropHints")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1CropHint> CropHints { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set of dominant colors and their corresponding scores.</summary>
    public class GoogleCloudVisionV1p3beta1DominantColorsAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>RGB color values with their score and pixel fraction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colors")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1ColorInfo> Colors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set of detected entity features.</summary>
    public class GoogleCloudVisionV1p3beta1EntityAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Image region to which this entity belongs. Not produced for `LABEL_DETECTION` features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudVisionV1p3beta1BoundingPoly BoundingPoly { get; set; }

        /// <summary>
        /// **Deprecated. Use `score` instead.** The accuracy of the entity detection in an image. For example, for an
        /// image in which the "Eiffel Tower" entity is detected, this field represents the confidence that there is a
        /// tower in the query image. Range [0, 1].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Entity textual description, expressed in its `locale` language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The language code for the locale in which the entity textual `description` is expressed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual string Locale { get; set; }

        /// <summary>
        /// The location information for the detected entity. Multiple `LocationInfo` elements can be present because
        /// one location may indicate the location of the scene in the image, and another location may indicate the
        /// location of the place where the image was taken. Location information is usually present for landmarks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1LocationInfo> Locations { get; set; }

        /// <summary>
        /// Opaque entity ID. Some IDs may be available in [Google Knowledge Graph Search
        /// API](https://developers.google.com/knowledge-graph/).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mid")]
        public virtual string Mid { get; set; }

        /// <summary>
        /// Some entities may have optional user-supplied `Property` (name/value) fields, such a score or string that
        /// qualifies the entity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1Property> Properties { get; set; }

        /// <summary>Overall score of the result. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>
        /// The relevancy of the ICA (Image Content Annotation) label to the image. For example, the relevancy of
        /// "tower" is likely higher to an image containing the detected "Eiffel Tower" than to an image containing a
        /// detected distant towering building, even though the confidence that there is a tower in each image may be
        /// the same. Range [0, 1].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicality")]
        public virtual System.Nullable<float> Topicality { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A face annotation object contains the results of face detection.</summary>
    public class GoogleCloudVisionV1p3beta1FaceAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Anger likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("angerLikelihood")]
        public virtual string AngerLikelihood { get; set; }

        /// <summary>Blurred likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blurredLikelihood")]
        public virtual string BlurredLikelihood { get; set; }

        /// <summary>
        /// The bounding polygon around the face. The coordinates of the bounding box are in the original image's scale.
        /// The bounding box is computed to "frame" the face in accordance with human expectations. It is based on the
        /// landmarker results. Note that one or more x and/or y coordinates may not be generated in the `BoundingPoly`
        /// (the polygon will be unbounded) if only a partial face appears in the image to be annotated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudVisionV1p3beta1BoundingPoly BoundingPoly { get; set; }

        /// <summary>Detection confidence. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectionConfidence")]
        public virtual System.Nullable<float> DetectionConfidence { get; set; }

        /// <summary>
        /// The `fd_bounding_poly` bounding polygon is tighter than the `boundingPoly`, and encloses only the skin part
        /// of the face. Typically, it is used to eliminate the face from any image analysis that detects the "amount of
        /// skin" visible in an image. It is not based on the landmarker results, only on the initial face detection,
        /// hence the fd (face detection) prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fdBoundingPoly")]
        public virtual GoogleCloudVisionV1p3beta1BoundingPoly FdBoundingPoly { get; set; }

        /// <summary>Headwear likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headwearLikelihood")]
        public virtual string HeadwearLikelihood { get; set; }

        /// <summary>Joy likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("joyLikelihood")]
        public virtual string JoyLikelihood { get; set; }

        /// <summary>Face landmarking confidence. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landmarkingConfidence")]
        public virtual System.Nullable<float> LandmarkingConfidence { get; set; }

        /// <summary>Detected face landmarks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landmarks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1FaceAnnotationLandmark> Landmarks { get; set; }

        /// <summary>
        /// Yaw angle, which indicates the leftward/rightward angle that the face is pointing relative to the vertical
        /// plane perpendicular to the image. Range [-180,180].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("panAngle")]
        public virtual System.Nullable<float> PanAngle { get; set; }

        /// <summary>
        /// Roll angle, which indicates the amount of clockwise/anti-clockwise rotation of the face relative to the
        /// image vertical about the axis perpendicular to the face. Range [-180,180].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollAngle")]
        public virtual System.Nullable<float> RollAngle { get; set; }

        /// <summary>Sorrow likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sorrowLikelihood")]
        public virtual string SorrowLikelihood { get; set; }

        /// <summary>Surprise likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("surpriseLikelihood")]
        public virtual string SurpriseLikelihood { get; set; }

        /// <summary>
        /// Pitch angle, which indicates the upwards/downwards angle that the face is pointing relative to the image's
        /// horizontal plane. Range [-180,180].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tiltAngle")]
        public virtual System.Nullable<float> TiltAngle { get; set; }

        /// <summary>Under-exposed likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("underExposedLikelihood")]
        public virtual string UnderExposedLikelihood { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A face-specific landmark (for example, a face feature).</summary>
    public class GoogleCloudVisionV1p3beta1FaceAnnotationLandmark : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Face landmark position.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual GoogleCloudVisionV1p3beta1Position Position { get; set; }

        /// <summary>Face landmark type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Google Cloud Storage location where the output will be written to.</summary>
    public class GoogleCloudVisionV1p3beta1GcsDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Storage URI prefix where the results will be stored. Results will be in JSON format and
        /// preceded by its corresponding input URI prefix. This field can either represent a gcs file prefix or gcs
        /// directory. In either case, the uri should be unique because in order to get all of the output files, you
        /// will need to do a wildcard gcs search on the uri prefix you provide. Examples: * File Prefix:
        /// gs://bucket-name/here/filenameprefix The output files will be created in gs://bucket-name/here/ and the
        /// names of the output files will begin with "filenameprefix". * Directory Prefix:
        /// gs://bucket-name/some/location/ The output files will be created in gs://bucket-name/some/location/ and the
        /// names of the output files could be anything because there was no filename prefix specified. If multiple
        /// outputs, each response is still AnnotateFileResponse, each of which contains some subset of the full list of
        /// AnnotateImageResponse. Multiple outputs can happen if, for example, the output JSON is too large and
        /// overflows into multiple sharded files.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Google Cloud Storage location where the input will be read from.</summary>
    public class GoogleCloudVisionV1p3beta1GcsSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Storage URI for the input file. This must only be a Google Cloud Storage object. Wildcards are
        /// not currently supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// If an image was produced from a file (e.g. a PDF), this message gives information about the source of that
    /// image.
    /// </summary>
    public class GoogleCloudVisionV1p3beta1ImageAnnotationContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the file was a PDF or TIFF, this field gives the page number within the file used to produce the image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageNumber")]
        public virtual System.Nullable<int> PageNumber { get; set; }

        /// <summary>The URI of the file used to produce the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Stores image properties, such as dominant colors.</summary>
    public class GoogleCloudVisionV1p3beta1ImageProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If present, dominant colors completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dominantColors")]
        public virtual GoogleCloudVisionV1p3beta1DominantColorsAnnotation DominantColors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for the `ImportProductSets` method. This message is returned by the
    /// google.longrunning.Operations.GetOperation method in the returned google.longrunning.Operation.response field.
    /// </summary>
    public class GoogleCloudVisionV1p3beta1ImportProductSetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of reference_images that are imported successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceImages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1ReferenceImage> ReferenceImages { get; set; }

        /// <summary>
        /// The rpc status for each ImportProductSet request, including both successes and errors. The number of
        /// statuses here matches the number of lines in the csv file, and statuses[i] stores the success or failure
        /// status of processing the i-th line of the csv, starting from line 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statuses")]
        public virtual System.Collections.Generic.IList<Status> Statuses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The desired input location and metadata.</summary>
    public class GoogleCloudVisionV1p3beta1InputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// File content, represented as a stream of bytes. Note: As with all `bytes` fields, protobuffers use a pure
        /// binary representation, whereas JSON representations use base64. Currently, this field only works for
        /// BatchAnnotateFiles requests. It does not work for AsyncBatchAnnotateFiles requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>The Google Cloud Storage location to read the input from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GoogleCloudVisionV1p3beta1GcsSource GcsSource { get; set; }

        /// <summary>
        /// The type of the file. Currently only "application/pdf", "image/tiff" and "image/gif" are supported.
        /// Wildcards are not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set of detected objects with bounding boxes.</summary>
    public class GoogleCloudVisionV1p3beta1LocalizedObjectAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Image region to which this object belongs. This must be populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudVisionV1p3beta1BoundingPoly BoundingPoly { get; set; }

        /// <summary>
        /// The BCP-47 language code, such as "en-US" or "sr-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Object ID that should align with EntityAnnotation mid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mid")]
        public virtual string Mid { get; set; }

        /// <summary>Object name, expressed in its `language_code` language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Score of the result. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected entity location information.</summary>
    public class GoogleCloudVisionV1p3beta1LocationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>lat/long location coordinates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latLng")]
        public virtual LatLng LatLng { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A vertex represents a 2D point in the image. NOTE: the normalized vertex coordinates are relative to the
    /// original image and range from 0 to 1.
    /// </summary>
    public class GoogleCloudVisionV1p3beta1NormalizedVertex : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Contains metadata for the BatchAnnotateImages operation.</summary>
    public class GoogleCloudVisionV1p3beta1OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time when the batch request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Current state of the batch operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The time when the operation result was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The desired output location and metadata.</summary>
    public class GoogleCloudVisionV1p3beta1OutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The max number of response protos to put into each output JSON file on Google Cloud Storage. The valid range
        /// is [1, 100]. If not specified, the default value is 20. For example, for one pdf file with 100 pages, 100
        /// response protos will be generated. If `batch_size` = 20, then 5 json files each containing 20 response
        /// protos will be written under the prefix `gcs_destination`.`uri`. Currently, batch_size only applies to
        /// GcsDestination, with potential future support for other output configurations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchSize")]
        public virtual System.Nullable<int> BatchSize { get; set; }

        /// <summary>The Google Cloud Storage location to write the output(s) to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual GoogleCloudVisionV1p3beta1GcsDestination GcsDestination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected page from OCR.</summary>
    public class GoogleCloudVisionV1p3beta1Page : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of blocks of text, images etc on this page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1Block> Blocks { get; set; }

        /// <summary>Confidence of the OCR results on the page. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// Page height. For PDFs the unit is points. For images (including TIFFs) the unit is pixels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; }

        /// <summary>Additional information detected on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual GoogleCloudVisionV1p3beta1TextAnnotationTextProperty Property { get; set; }

        /// <summary>Page width. For PDFs the unit is points. For images (including TIFFs) the unit is pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Structural unit of text representing a number of words in certain order.</summary>
    public class GoogleCloudVisionV1p3beta1Paragraph : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The bounding box for the paragraph. The vertices are in the order of top-left, top-right, bottom-right,
        /// bottom-left. When a rotation of the bounding box is detected the rotation is represented as around the
        /// top-left corner as defined when the text is read in the 'natural' orientation. For example: * when the text
        /// is horizontal it might look like: 0----1 | | 3----2 * when it's rotated 180 degrees around the top-left
        /// corner it becomes: 2----3 | | 1----0 and the vertex order will still be (0, 1, 2, 3).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBox")]
        public virtual GoogleCloudVisionV1p3beta1BoundingPoly BoundingBox { get; set; }

        /// <summary>Confidence of the OCR results for the paragraph. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Additional information detected for the paragraph.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual GoogleCloudVisionV1p3beta1TextAnnotationTextProperty Property { get; set; }

        /// <summary>List of all words in this paragraph.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("words")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1Word> Words { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A 3D position in the image, used primarily for Face detection landmarks. A valid Position must have both x and y
    /// coordinates. The position coordinates are in the same scale as the original image.
    /// </summary>
    public class GoogleCloudVisionV1p3beta1Position : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual System.Nullable<float> X { get; set; }

        /// <summary>Y coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual System.Nullable<float> Y { get; set; }

        /// <summary>Z coordinate (or depth).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("z")]
        public virtual System.Nullable<float> Z { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Product contains ReferenceImages.</summary>
    public class GoogleCloudVisionV1p3beta1Product : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// User-provided metadata to be stored with this product. Must be at most 4096 characters long.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The user-provided name for this Product. Must not be empty. Must be at most 4096 characters long.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The resource name of the product. Format is: `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`.
        /// This field is ignored when creating a product.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. The category for the product identified by the reference image. This should be one of
        /// "homegoods-v2", "apparel-v2", "toys-v2", "packagedgoods-v1" or "general-v1". The legacy categories
        /// "homegoods", "apparel", and "toys" are still supported, but these should not be used for new products.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productCategory")]
        public virtual string ProductCategory { get; set; }

        /// <summary>
        /// Key-value pairs that can be attached to a product. At query time, constraints can be specified based on the
        /// product_labels. Note that integer values can be provided as strings, e.g. "1199". Only strings with integer
        /// values can match a range-based restriction which is to be supported soon. Multiple values can be assigned to
        /// the same key. One product may have up to 500 product_labels. Notice that the total number of distinct
        /// product_labels over all products in one ProductSet cannot exceed 1M, otherwise the product search pipeline
        /// will refuse to work for that ProductSet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productLabels")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1ProductKeyValue> ProductLabels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A product label represented as a key-value pair.</summary>
    public class GoogleCloudVisionV1p3beta1ProductKeyValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The key of the label attached to the product. Cannot be empty and cannot exceed 128 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// The value of the label attached to the product. Cannot be empty and cannot exceed 128 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Results for a product search request.</summary>
    public class GoogleCloudVisionV1p3beta1ProductSearchResults : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Timestamp of the index which provided these results. Products added to the product set and products removed
        /// from the product set after this time are not reflected in the current results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexTime")]
        public virtual object IndexTime { get; set; }

        /// <summary>
        /// List of results grouped by products detected in the query image. Each entry corresponds to one bounding
        /// polygon in the query image, and contains the matching products specific to that region. There may be
        /// duplicate product matches in the union of all the per-product results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productGroupedResults")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1ProductSearchResultsGroupedResult> ProductGroupedResults { get; set; }

        /// <summary>List of results, one for each product match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1ProductSearchResultsResult> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the products similar to a single product in a query image.</summary>
    public class GoogleCloudVisionV1p3beta1ProductSearchResultsGroupedResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bounding polygon around the product detected in the query image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudVisionV1p3beta1BoundingPoly BoundingPoly { get; set; }

        /// <summary>List of generic predictions for the object in the bounding box.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1ProductSearchResultsObjectAnnotation> ObjectAnnotations { get; set; }

        /// <summary>List of results, one for each product match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1ProductSearchResultsResult> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Prediction for what the object in the bounding box is.</summary>
    public class GoogleCloudVisionV1p3beta1ProductSearchResultsObjectAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The BCP-47 language code, such as "en-US" or "sr-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Object ID that should align with EntityAnnotation mid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mid")]
        public virtual string Mid { get; set; }

        /// <summary>Object name, expressed in its `language_code` language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Score of the result. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a product.</summary>
    public class GoogleCloudVisionV1p3beta1ProductSearchResultsResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name of the image from the product that is the closest match to the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual string Image { get; set; }

        /// <summary>The Product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual GoogleCloudVisionV1p3beta1Product Product { get; set; }

        /// <summary>A confidence level on the match, ranging from 0 (no confidence) to 1 (full confidence).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A `Property` consists of a user-supplied name/value pair.</summary>
    public class GoogleCloudVisionV1p3beta1Property : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Value of numeric properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uint64Value")]
        public virtual System.Nullable<ulong> Uint64Value { get; set; }

        /// <summary>Value of the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `ReferenceImage` represents a product image and its associated metadata, such as bounding boxes.
    /// </summary>
    public class GoogleCloudVisionV1p3beta1ReferenceImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Bounding polygons around the areas of interest in the reference image. If this field is empty, the
        /// system will try to detect regions of interest. At most 10 bounding polygons will be used. The provided shape
        /// is converted into a non-rotated rectangle. Once converted, the small edge of the rectangle must be greater
        /// than or equal to 300 pixels. The aspect ratio must be 1:4 or less (i.e. 1:3 is ok; 1:5 is not).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPolys")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1BoundingPoly> BoundingPolys { get; set; }

        /// <summary>
        /// The resource name of the reference image. Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID/referenceImages/IMAGE_ID`. This field is ignored
        /// when creating a reference image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The Google Cloud Storage URI of the reference image. The URI must start with `gs://`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Set of features pertaining to the image, computed by computer vision methods over safe-search verticals (for
    /// example, adult, spoof, medical, violence).
    /// </summary>
    public class GoogleCloudVisionV1p3beta1SafeSearchAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Represents the adult content likelihood for the image. Adult content may contain elements such as nudity,
        /// pornographic images or cartoons, or sexual activities.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adult")]
        public virtual string Adult { get; set; }

        /// <summary>Likelihood that this is a medical image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("medical")]
        public virtual string Medical { get; set; }

        /// <summary>
        /// Likelihood that the request image contains racy content. Racy content may include (but is not limited to)
        /// skimpy or sheer clothing, strategically covered nudity, lewd or provocative poses, or close-ups of sensitive
        /// body areas.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("racy")]
        public virtual string Racy { get; set; }

        /// <summary>
        /// Spoof likelihood. The likelihood that an modification was made to the image's canonical version to make it
        /// appear funny or offensive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spoof")]
        public virtual string Spoof { get; set; }

        /// <summary>Likelihood that this image contains violent content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("violence")]
        public virtual string Violence { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single symbol representation.</summary>
    public class GoogleCloudVisionV1p3beta1Symbol : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The bounding box for the symbol. The vertices are in the order of top-left, top-right, bottom-right,
        /// bottom-left. When a rotation of the bounding box is detected the rotation is represented as around the
        /// top-left corner as defined when the text is read in the 'natural' orientation. For example: * when the text
        /// is horizontal it might look like: 0----1 | | 3----2 * when it's rotated 180 degrees around the top-left
        /// corner it becomes: 2----3 | | 1----0 and the vertex order will still be (0, 1, 2, 3).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBox")]
        public virtual GoogleCloudVisionV1p3beta1BoundingPoly BoundingBox { get; set; }

        /// <summary>Confidence of the OCR results for the symbol. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Additional information detected for the symbol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual GoogleCloudVisionV1p3beta1TextAnnotationTextProperty Property { get; set; }

        /// <summary>The actual UTF-8 representation of the symbol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// TextAnnotation contains a structured representation of OCR extracted text. The hierarchy of an OCR extracted
    /// text structure is like this: TextAnnotation -&amp;gt; Page -&amp;gt; Block -&amp;gt; Paragraph -&amp;gt; Word
    /// -&amp;gt; Symbol Each structural component, starting from Page, may further have their own properties.
    /// Properties describe detected languages, breaks etc.. Please refer to the TextAnnotation.TextProperty message
    /// definition below for more detail.
    /// </summary>
    public class GoogleCloudVisionV1p3beta1TextAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of pages detected by OCR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1Page> Pages { get; set; }

        /// <summary>UTF-8 text detected on the pages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected start or end of a structural component.</summary>
    public class GoogleCloudVisionV1p3beta1TextAnnotationDetectedBreak : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>True if break prepends the element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPrefix")]
        public virtual System.Nullable<bool> IsPrefix { get; set; }

        /// <summary>Detected break type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected language for a structural component.</summary>
    public class GoogleCloudVisionV1p3beta1TextAnnotationDetectedLanguage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Confidence of detected language. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// The BCP-47 language code, such as "en-US" or "sr-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional information detected on the structural component.</summary>
    public class GoogleCloudVisionV1p3beta1TextAnnotationTextProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detected start or end of a text segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedBreak")]
        public virtual GoogleCloudVisionV1p3beta1TextAnnotationDetectedBreak DetectedBreak { get; set; }

        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1TextAnnotationDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A vertex represents a 2D point in the image. NOTE: the vertex coordinates are in the same scale as the original
    /// image.
    /// </summary>
    public class GoogleCloudVisionV1p3beta1Vertex : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Relevant information for the image from the Internet.</summary>
    public class GoogleCloudVisionV1p3beta1WebDetection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The service's best guess as to the topic of the request image. Inferred from similar images on the open web.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bestGuessLabels")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1WebDetectionWebLabel> BestGuessLabels { get; set; }

        /// <summary>Fully matching images from the Internet. Can include resized copies of the query image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullMatchingImages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1WebDetectionWebImage> FullMatchingImages { get; set; }

        /// <summary>Web pages containing the matching images from the Internet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pagesWithMatchingImages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1WebDetectionWebPage> PagesWithMatchingImages { get; set; }

        /// <summary>
        /// Partial matching images from the Internet. Those images are similar enough to share some key-point features.
        /// For example an original image will likely have partial matching for its crops.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialMatchingImages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1WebDetectionWebImage> PartialMatchingImages { get; set; }

        /// <summary>The visually similar image results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visuallySimilarImages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1WebDetectionWebImage> VisuallySimilarImages { get; set; }

        /// <summary>Deduced entities from similar images on the Internet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webEntities")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1WebDetectionWebEntity> WebEntities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Entity deduced from similar images on the Internet.</summary>
    public class GoogleCloudVisionV1p3beta1WebDetectionWebEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Canonical description of the entity, in English.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Opaque entity ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityId")]
        public virtual string EntityId { get; set; }

        /// <summary>
        /// Overall relevancy score for the entity. Not normalized and not comparable across different image queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for online images.</summary>
    public class GoogleCloudVisionV1p3beta1WebDetectionWebImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>(Deprecated) Overall relevancy score for the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The result image URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Label to provide extra metadata for the web detection.</summary>
    public class GoogleCloudVisionV1p3beta1WebDetectionWebLabel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label for extra metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>
        /// The BCP-47 language code for `label`, such as "en-US" or "sr-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for web pages.</summary>
    public class GoogleCloudVisionV1p3beta1WebDetectionWebPage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Fully matching images on the page. Can include resized copies of the query image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullMatchingImages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1WebDetectionWebImage> FullMatchingImages { get; set; }

        /// <summary>Title for the web page, may contain HTML markups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageTitle")]
        public virtual string PageTitle { get; set; }

        /// <summary>
        /// Partial matching images on the page. Those images are similar enough to share some key-point features. For
        /// example an original image will likely have partial matching for its crops.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialMatchingImages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1WebDetectionWebImage> PartialMatchingImages { get; set; }

        /// <summary>(Deprecated) Overall relevancy score for the web page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The result web page URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A word representation.</summary>
    public class GoogleCloudVisionV1p3beta1Word : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The bounding box for the word. The vertices are in the order of top-left, top-right, bottom-right,
        /// bottom-left. When a rotation of the bounding box is detected the rotation is represented as around the
        /// top-left corner as defined when the text is read in the 'natural' orientation. For example: * when the text
        /// is horizontal it might look like: 0----1 | | 3----2 * when it's rotated 180 degrees around the top-left
        /// corner it becomes: 2----3 | | 1----0 and the vertex order will still be (0, 1, 2, 3).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBox")]
        public virtual GoogleCloudVisionV1p3beta1BoundingPoly BoundingBox { get; set; }

        /// <summary>Confidence of the OCR results for the word. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Additional information detected for the word.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual GoogleCloudVisionV1p3beta1TextAnnotationTextProperty Property { get; set; }

        /// <summary>List of symbols in the word. The order of the symbols follows the natural reading order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("symbols")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p3beta1Symbol> Symbols { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response to a single file annotation request. A file may contain one or more images, which individually have
    /// their own responses.
    /// </summary>
    public class GoogleCloudVisionV1p4beta1AnnotateFileResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set, represents the error message for the failed request. The `responses` field will not be set in this
        /// case.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>Information about the file for which this response is generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfig")]
        public virtual GoogleCloudVisionV1p4beta1InputConfig InputConfig { get; set; }

        /// <summary>
        /// Individual responses to images found within the file. This field will be empty if the `error` field is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responses")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1AnnotateImageResponse> Responses { get; set; }

        /// <summary>This field gives the total number of pages in the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalPages")]
        public virtual System.Nullable<int> TotalPages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to an image annotation request.</summary>
    public class GoogleCloudVisionV1p4beta1AnnotateImageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If present, contextual information is needed to understand where this image comes from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual GoogleCloudVisionV1p4beta1ImageAnnotationContext Context { get; set; }

        /// <summary>If present, crop hints have completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cropHintsAnnotation")]
        public virtual GoogleCloudVisionV1p4beta1CropHintsAnnotation CropHintsAnnotation { get; set; }

        /// <summary>
        /// If set, represents the error message for the operation. Note that filled-in image annotations are guaranteed
        /// to be correct, even when `error` is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>If present, face detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faceAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1FaceAnnotation> FaceAnnotations { get; set; }

        /// <summary>
        /// If present, text (OCR) detection or document (OCR) text detection has completed successfully. This
        /// annotation provides the structural hierarchy for the OCR detected text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullTextAnnotation")]
        public virtual GoogleCloudVisionV1p4beta1TextAnnotation FullTextAnnotation { get; set; }

        /// <summary>If present, image properties were extracted successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imagePropertiesAnnotation")]
        public virtual GoogleCloudVisionV1p4beta1ImageProperties ImagePropertiesAnnotation { get; set; }

        /// <summary>If present, label detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1EntityAnnotation> LabelAnnotations { get; set; }

        /// <summary>If present, landmark detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landmarkAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1EntityAnnotation> LandmarkAnnotations { get; set; }

        /// <summary>
        /// If present, localized object detection has completed successfully. This will be sorted descending by
        /// confidence score.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedObjectAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1LocalizedObjectAnnotation> LocalizedObjectAnnotations { get; set; }

        /// <summary>If present, logo detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logoAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1EntityAnnotation> LogoAnnotations { get; set; }

        /// <summary>If present, product search has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSearchResults")]
        public virtual GoogleCloudVisionV1p4beta1ProductSearchResults ProductSearchResults { get; set; }

        /// <summary>If present, safe-search annotation has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safeSearchAnnotation")]
        public virtual GoogleCloudVisionV1p4beta1SafeSearchAnnotation SafeSearchAnnotation { get; set; }

        /// <summary>If present, text (OCR) detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1EntityAnnotation> TextAnnotations { get; set; }

        /// <summary>If present, web detection has completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webDetection")]
        public virtual GoogleCloudVisionV1p4beta1WebDetection WebDetection { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for a single offline file annotation request.</summary>
    public class GoogleCloudVisionV1p4beta1AsyncAnnotateFileResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The output location and metadata from AsyncAnnotateFileRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual GoogleCloudVisionV1p4beta1OutputConfig OutputConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to an async batch file annotation request.</summary>
    public class GoogleCloudVisionV1p4beta1AsyncBatchAnnotateFilesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of file annotation responses, one for each request in AsyncBatchAnnotateFilesRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responses")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1AsyncAnnotateFileResponse> Responses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to an async batch image annotation request.</summary>
    public class GoogleCloudVisionV1p4beta1AsyncBatchAnnotateImagesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The output location and metadata from AsyncBatchAnnotateImagesRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual GoogleCloudVisionV1p4beta1OutputConfig OutputConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of file annotation responses.</summary>
    public class GoogleCloudVisionV1p4beta1BatchAnnotateFilesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of file annotation responses, each response corresponding to each AnnotateFileRequest in
        /// BatchAnnotateFilesRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responses")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1AnnotateFileResponse> Responses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata for the batch operations such as the current state. This is included in the `metadata` field of the
    /// `Operation` returned by the `GetOperation` call of the `google::longrunning::Operations` service.
    /// </summary>
    public class GoogleCloudVisionV1p4beta1BatchOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The time when the batch request is finished and google.longrunning.Operation.done is set to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The current state of the batch operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The time when the batch request was submitted to the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("submitTime")]
        public virtual object SubmitTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Logical element on the page.</summary>
    public class GoogleCloudVisionV1p4beta1Block : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detected block type (text, image etc) for this block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockType")]
        public virtual string BlockType { get; set; }

        /// <summary>
        /// The bounding box for the block. The vertices are in the order of top-left, top-right, bottom-right,
        /// bottom-left. When a rotation of the bounding box is detected the rotation is represented as around the
        /// top-left corner as defined when the text is read in the 'natural' orientation. For example: * when the text
        /// is horizontal it might look like: 0----1 | | 3----2 * when it's rotated 180 degrees around the top-left
        /// corner it becomes: 2----3 | | 1----0 and the vertex order will still be (0, 1, 2, 3).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBox")]
        public virtual GoogleCloudVisionV1p4beta1BoundingPoly BoundingBox { get; set; }

        /// <summary>Confidence of the OCR results on the block. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>List of paragraphs in this block (if this blocks is of type text).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paragraphs")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1Paragraph> Paragraphs { get; set; }

        /// <summary>Additional information detected for the block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual GoogleCloudVisionV1p4beta1TextAnnotationTextProperty Property { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A bounding polygon for the detected image annotation.</summary>
    public class GoogleCloudVisionV1p4beta1BoundingPoly : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bounding polygon normalized vertices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedVertices")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1NormalizedVertex> NormalizedVertices { get; set; }

        /// <summary>The bounding polygon vertices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertices")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1Vertex> Vertices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Celebrity is a group of Faces with an identity.</summary>
    public class GoogleCloudVisionV1p4beta1Celebrity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Celebrity's description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The Celebrity's display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The resource name of the preloaded Celebrity. Has the format `builtin/{mid}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Color information consists of RGB channels, score, and the fraction of the image that the color occupies in the
    /// image.
    /// </summary>
    public class GoogleCloudVisionV1p4beta1ColorInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>RGB components of the color.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual Color Color { get; set; }

        /// <summary>The fraction of pixels the color occupies in the image. Value in range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pixelFraction")]
        public virtual System.Nullable<float> PixelFraction { get; set; }

        /// <summary>Image-specific score for this color. Value in range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Single crop hint that is used to generate a new crop when serving an image.</summary>
    public class GoogleCloudVisionV1p4beta1CropHint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The bounding polygon for the crop region. The coordinates of the bounding box are in the original image's
        /// scale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudVisionV1p4beta1BoundingPoly BoundingPoly { get; set; }

        /// <summary>Confidence of this being a salient region. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Fraction of importance of this salient region with respect to the original image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importanceFraction")]
        public virtual System.Nullable<float> ImportanceFraction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set of crop hints that are used to generate new crops when serving images.</summary>
    public class GoogleCloudVisionV1p4beta1CropHintsAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Crop hint results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cropHints")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1CropHint> CropHints { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set of dominant colors and their corresponding scores.</summary>
    public class GoogleCloudVisionV1p4beta1DominantColorsAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>RGB color values with their score and pixel fraction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colors")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1ColorInfo> Colors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set of detected entity features.</summary>
    public class GoogleCloudVisionV1p4beta1EntityAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Image region to which this entity belongs. Not produced for `LABEL_DETECTION` features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudVisionV1p4beta1BoundingPoly BoundingPoly { get; set; }

        /// <summary>
        /// **Deprecated. Use `score` instead.** The accuracy of the entity detection in an image. For example, for an
        /// image in which the "Eiffel Tower" entity is detected, this field represents the confidence that there is a
        /// tower in the query image. Range [0, 1].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Entity textual description, expressed in its `locale` language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The language code for the locale in which the entity textual `description` is expressed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual string Locale { get; set; }

        /// <summary>
        /// The location information for the detected entity. Multiple `LocationInfo` elements can be present because
        /// one location may indicate the location of the scene in the image, and another location may indicate the
        /// location of the place where the image was taken. Location information is usually present for landmarks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1LocationInfo> Locations { get; set; }

        /// <summary>
        /// Opaque entity ID. Some IDs may be available in [Google Knowledge Graph Search
        /// API](https://developers.google.com/knowledge-graph/).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mid")]
        public virtual string Mid { get; set; }

        /// <summary>
        /// Some entities may have optional user-supplied `Property` (name/value) fields, such a score or string that
        /// qualifies the entity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1Property> Properties { get; set; }

        /// <summary>Overall score of the result. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>
        /// The relevancy of the ICA (Image Content Annotation) label to the image. For example, the relevancy of
        /// "tower" is likely higher to an image containing the detected "Eiffel Tower" than to an image containing a
        /// detected distant towering building, even though the confidence that there is a tower in each image may be
        /// the same. Range [0, 1].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicality")]
        public virtual System.Nullable<float> Topicality { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A face annotation object contains the results of face detection.</summary>
    public class GoogleCloudVisionV1p4beta1FaceAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Anger likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("angerLikelihood")]
        public virtual string AngerLikelihood { get; set; }

        /// <summary>Blurred likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blurredLikelihood")]
        public virtual string BlurredLikelihood { get; set; }

        /// <summary>
        /// The bounding polygon around the face. The coordinates of the bounding box are in the original image's scale.
        /// The bounding box is computed to "frame" the face in accordance with human expectations. It is based on the
        /// landmarker results. Note that one or more x and/or y coordinates may not be generated in the `BoundingPoly`
        /// (the polygon will be unbounded) if only a partial face appears in the image to be annotated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudVisionV1p4beta1BoundingPoly BoundingPoly { get; set; }

        /// <summary>Detection confidence. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectionConfidence")]
        public virtual System.Nullable<float> DetectionConfidence { get; set; }

        /// <summary>
        /// The `fd_bounding_poly` bounding polygon is tighter than the `boundingPoly`, and encloses only the skin part
        /// of the face. Typically, it is used to eliminate the face from any image analysis that detects the "amount of
        /// skin" visible in an image. It is not based on the landmarker results, only on the initial face detection,
        /// hence the fd (face detection) prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fdBoundingPoly")]
        public virtual GoogleCloudVisionV1p4beta1BoundingPoly FdBoundingPoly { get; set; }

        /// <summary>Headwear likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headwearLikelihood")]
        public virtual string HeadwearLikelihood { get; set; }

        /// <summary>Joy likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("joyLikelihood")]
        public virtual string JoyLikelihood { get; set; }

        /// <summary>Face landmarking confidence. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landmarkingConfidence")]
        public virtual System.Nullable<float> LandmarkingConfidence { get; set; }

        /// <summary>Detected face landmarks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landmarks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1FaceAnnotationLandmark> Landmarks { get; set; }

        /// <summary>
        /// Yaw angle, which indicates the leftward/rightward angle that the face is pointing relative to the vertical
        /// plane perpendicular to the image. Range [-180,180].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("panAngle")]
        public virtual System.Nullable<float> PanAngle { get; set; }

        /// <summary>
        /// Additional recognition information. Only computed if image_context.face_recognition_params is provided,
        /// **and** a match is found to a Celebrity in the input CelebritySet. This field is sorted in order of
        /// decreasing confidence values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recognitionResult")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1FaceRecognitionResult> RecognitionResult { get; set; }

        /// <summary>
        /// Roll angle, which indicates the amount of clockwise/anti-clockwise rotation of the face relative to the
        /// image vertical about the axis perpendicular to the face. Range [-180,180].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollAngle")]
        public virtual System.Nullable<float> RollAngle { get; set; }

        /// <summary>Sorrow likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sorrowLikelihood")]
        public virtual string SorrowLikelihood { get; set; }

        /// <summary>Surprise likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("surpriseLikelihood")]
        public virtual string SurpriseLikelihood { get; set; }

        /// <summary>
        /// Pitch angle, which indicates the upwards/downwards angle that the face is pointing relative to the image's
        /// horizontal plane. Range [-180,180].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tiltAngle")]
        public virtual System.Nullable<float> TiltAngle { get; set; }

        /// <summary>Under-exposed likelihood.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("underExposedLikelihood")]
        public virtual string UnderExposedLikelihood { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A face-specific landmark (for example, a face feature).</summary>
    public class GoogleCloudVisionV1p4beta1FaceAnnotationLandmark : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Face landmark position.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual GoogleCloudVisionV1p4beta1Position Position { get; set; }

        /// <summary>Face landmark type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a face's identity.</summary>
    public class GoogleCloudVisionV1p4beta1FaceRecognitionResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Celebrity that this face was matched to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("celebrity")]
        public virtual GoogleCloudVisionV1p4beta1Celebrity Celebrity { get; set; }

        /// <summary>Recognition confidence. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Google Cloud Storage location where the output will be written to.</summary>
    public class GoogleCloudVisionV1p4beta1GcsDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Storage URI prefix where the results will be stored. Results will be in JSON format and
        /// preceded by its corresponding input URI prefix. This field can either represent a gcs file prefix or gcs
        /// directory. In either case, the uri should be unique because in order to get all of the output files, you
        /// will need to do a wildcard gcs search on the uri prefix you provide. Examples: * File Prefix:
        /// gs://bucket-name/here/filenameprefix The output files will be created in gs://bucket-name/here/ and the
        /// names of the output files will begin with "filenameprefix". * Directory Prefix:
        /// gs://bucket-name/some/location/ The output files will be created in gs://bucket-name/some/location/ and the
        /// names of the output files could be anything because there was no filename prefix specified. If multiple
        /// outputs, each response is still AnnotateFileResponse, each of which contains some subset of the full list of
        /// AnnotateImageResponse. Multiple outputs can happen if, for example, the output JSON is too large and
        /// overflows into multiple sharded files.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Google Cloud Storage location where the input will be read from.</summary>
    public class GoogleCloudVisionV1p4beta1GcsSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Storage URI for the input file. This must only be a Google Cloud Storage object. Wildcards are
        /// not currently supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// If an image was produced from a file (e.g. a PDF), this message gives information about the source of that
    /// image.
    /// </summary>
    public class GoogleCloudVisionV1p4beta1ImageAnnotationContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the file was a PDF or TIFF, this field gives the page number within the file used to produce the image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageNumber")]
        public virtual System.Nullable<int> PageNumber { get; set; }

        /// <summary>The URI of the file used to produce the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Stores image properties, such as dominant colors.</summary>
    public class GoogleCloudVisionV1p4beta1ImageProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If present, dominant colors completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dominantColors")]
        public virtual GoogleCloudVisionV1p4beta1DominantColorsAnnotation DominantColors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for the `ImportProductSets` method. This message is returned by the
    /// google.longrunning.Operations.GetOperation method in the returned google.longrunning.Operation.response field.
    /// </summary>
    public class GoogleCloudVisionV1p4beta1ImportProductSetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of reference_images that are imported successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceImages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1ReferenceImage> ReferenceImages { get; set; }

        /// <summary>
        /// The rpc status for each ImportProductSet request, including both successes and errors. The number of
        /// statuses here matches the number of lines in the csv file, and statuses[i] stores the success or failure
        /// status of processing the i-th line of the csv, starting from line 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statuses")]
        public virtual System.Collections.Generic.IList<Status> Statuses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The desired input location and metadata.</summary>
    public class GoogleCloudVisionV1p4beta1InputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// File content, represented as a stream of bytes. Note: As with all `bytes` fields, protobuffers use a pure
        /// binary representation, whereas JSON representations use base64. Currently, this field only works for
        /// BatchAnnotateFiles requests. It does not work for AsyncBatchAnnotateFiles requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>The Google Cloud Storage location to read the input from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GoogleCloudVisionV1p4beta1GcsSource GcsSource { get; set; }

        /// <summary>
        /// The type of the file. Currently only "application/pdf", "image/tiff" and "image/gif" are supported.
        /// Wildcards are not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set of detected objects with bounding boxes.</summary>
    public class GoogleCloudVisionV1p4beta1LocalizedObjectAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Image region to which this object belongs. This must be populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudVisionV1p4beta1BoundingPoly BoundingPoly { get; set; }

        /// <summary>
        /// The BCP-47 language code, such as "en-US" or "sr-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Object ID that should align with EntityAnnotation mid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mid")]
        public virtual string Mid { get; set; }

        /// <summary>Object name, expressed in its `language_code` language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Score of the result. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected entity location information.</summary>
    public class GoogleCloudVisionV1p4beta1LocationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>lat/long location coordinates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latLng")]
        public virtual LatLng LatLng { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A vertex represents a 2D point in the image. NOTE: the normalized vertex coordinates are relative to the
    /// original image and range from 0 to 1.
    /// </summary>
    public class GoogleCloudVisionV1p4beta1NormalizedVertex : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Contains metadata for the BatchAnnotateImages operation.</summary>
    public class GoogleCloudVisionV1p4beta1OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time when the batch request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Current state of the batch operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The time when the operation result was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The desired output location and metadata.</summary>
    public class GoogleCloudVisionV1p4beta1OutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The max number of response protos to put into each output JSON file on Google Cloud Storage. The valid range
        /// is [1, 100]. If not specified, the default value is 20. For example, for one pdf file with 100 pages, 100
        /// response protos will be generated. If `batch_size` = 20, then 5 json files each containing 20 response
        /// protos will be written under the prefix `gcs_destination`.`uri`. Currently, batch_size only applies to
        /// GcsDestination, with potential future support for other output configurations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchSize")]
        public virtual System.Nullable<int> BatchSize { get; set; }

        /// <summary>The Google Cloud Storage location to write the output(s) to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual GoogleCloudVisionV1p4beta1GcsDestination GcsDestination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected page from OCR.</summary>
    public class GoogleCloudVisionV1p4beta1Page : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of blocks of text, images etc on this page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1Block> Blocks { get; set; }

        /// <summary>Confidence of the OCR results on the page. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// Page height. For PDFs the unit is points. For images (including TIFFs) the unit is pixels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; }

        /// <summary>Additional information detected on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual GoogleCloudVisionV1p4beta1TextAnnotationTextProperty Property { get; set; }

        /// <summary>Page width. For PDFs the unit is points. For images (including TIFFs) the unit is pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Structural unit of text representing a number of words in certain order.</summary>
    public class GoogleCloudVisionV1p4beta1Paragraph : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The bounding box for the paragraph. The vertices are in the order of top-left, top-right, bottom-right,
        /// bottom-left. When a rotation of the bounding box is detected the rotation is represented as around the
        /// top-left corner as defined when the text is read in the 'natural' orientation. For example: * when the text
        /// is horizontal it might look like: 0----1 | | 3----2 * when it's rotated 180 degrees around the top-left
        /// corner it becomes: 2----3 | | 1----0 and the vertex order will still be (0, 1, 2, 3).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBox")]
        public virtual GoogleCloudVisionV1p4beta1BoundingPoly BoundingBox { get; set; }

        /// <summary>Confidence of the OCR results for the paragraph. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Additional information detected for the paragraph.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual GoogleCloudVisionV1p4beta1TextAnnotationTextProperty Property { get; set; }

        /// <summary>List of all words in this paragraph.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("words")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1Word> Words { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A 3D position in the image, used primarily for Face detection landmarks. A valid Position must have both x and y
    /// coordinates. The position coordinates are in the same scale as the original image.
    /// </summary>
    public class GoogleCloudVisionV1p4beta1Position : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual System.Nullable<float> X { get; set; }

        /// <summary>Y coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual System.Nullable<float> Y { get; set; }

        /// <summary>Z coordinate (or depth).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("z")]
        public virtual System.Nullable<float> Z { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Product contains ReferenceImages.</summary>
    public class GoogleCloudVisionV1p4beta1Product : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// User-provided metadata to be stored with this product. Must be at most 4096 characters long.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The user-provided name for this Product. Must not be empty. Must be at most 4096 characters long.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The resource name of the product. Format is: `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`.
        /// This field is ignored when creating a product.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. The category for the product identified by the reference image. This should be one of
        /// "homegoods-v2", "apparel-v2", "toys-v2", "packagedgoods-v1" or "general-v1". The legacy categories
        /// "homegoods", "apparel", and "toys" are still supported, but these should not be used for new products.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productCategory")]
        public virtual string ProductCategory { get; set; }

        /// <summary>
        /// Key-value pairs that can be attached to a product. At query time, constraints can be specified based on the
        /// product_labels. Note that integer values can be provided as strings, e.g. "1199". Only strings with integer
        /// values can match a range-based restriction which is to be supported soon. Multiple values can be assigned to
        /// the same key. One product may have up to 500 product_labels. Notice that the total number of distinct
        /// product_labels over all products in one ProductSet cannot exceed 1M, otherwise the product search pipeline
        /// will refuse to work for that ProductSet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productLabels")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1ProductKeyValue> ProductLabels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A product label represented as a key-value pair.</summary>
    public class GoogleCloudVisionV1p4beta1ProductKeyValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The key of the label attached to the product. Cannot be empty and cannot exceed 128 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// The value of the label attached to the product. Cannot be empty and cannot exceed 128 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Results for a product search request.</summary>
    public class GoogleCloudVisionV1p4beta1ProductSearchResults : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Timestamp of the index which provided these results. Products added to the product set and products removed
        /// from the product set after this time are not reflected in the current results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexTime")]
        public virtual object IndexTime { get; set; }

        /// <summary>
        /// List of results grouped by products detected in the query image. Each entry corresponds to one bounding
        /// polygon in the query image, and contains the matching products specific to that region. There may be
        /// duplicate product matches in the union of all the per-product results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productGroupedResults")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1ProductSearchResultsGroupedResult> ProductGroupedResults { get; set; }

        /// <summary>List of results, one for each product match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1ProductSearchResultsResult> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the products similar to a single product in a query image.</summary>
    public class GoogleCloudVisionV1p4beta1ProductSearchResultsGroupedResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bounding polygon around the product detected in the query image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudVisionV1p4beta1BoundingPoly BoundingPoly { get; set; }

        /// <summary>List of generic predictions for the object in the bounding box.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1ProductSearchResultsObjectAnnotation> ObjectAnnotations { get; set; }

        /// <summary>List of results, one for each product match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1ProductSearchResultsResult> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Prediction for what the object in the bounding box is.</summary>
    public class GoogleCloudVisionV1p4beta1ProductSearchResultsObjectAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The BCP-47 language code, such as "en-US" or "sr-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Object ID that should align with EntityAnnotation mid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mid")]
        public virtual string Mid { get; set; }

        /// <summary>Object name, expressed in its `language_code` language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Score of the result. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a product.</summary>
    public class GoogleCloudVisionV1p4beta1ProductSearchResultsResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name of the image from the product that is the closest match to the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual string Image { get; set; }

        /// <summary>The Product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual GoogleCloudVisionV1p4beta1Product Product { get; set; }

        /// <summary>A confidence level on the match, ranging from 0 (no confidence) to 1 (full confidence).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A `Property` consists of a user-supplied name/value pair.</summary>
    public class GoogleCloudVisionV1p4beta1Property : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Value of numeric properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uint64Value")]
        public virtual System.Nullable<ulong> Uint64Value { get; set; }

        /// <summary>Value of the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `ReferenceImage` represents a product image and its associated metadata, such as bounding boxes.
    /// </summary>
    public class GoogleCloudVisionV1p4beta1ReferenceImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Bounding polygons around the areas of interest in the reference image. If this field is empty, the
        /// system will try to detect regions of interest. At most 10 bounding polygons will be used. The provided shape
        /// is converted into a non-rotated rectangle. Once converted, the small edge of the rectangle must be greater
        /// than or equal to 300 pixels. The aspect ratio must be 1:4 or less (i.e. 1:3 is ok; 1:5 is not).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPolys")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1BoundingPoly> BoundingPolys { get; set; }

        /// <summary>
        /// The resource name of the reference image. Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID/referenceImages/IMAGE_ID`. This field is ignored
        /// when creating a reference image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The Google Cloud Storage URI of the reference image. The URI must start with `gs://`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Set of features pertaining to the image, computed by computer vision methods over safe-search verticals (for
    /// example, adult, spoof, medical, violence).
    /// </summary>
    public class GoogleCloudVisionV1p4beta1SafeSearchAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Represents the adult content likelihood for the image. Adult content may contain elements such as nudity,
        /// pornographic images or cartoons, or sexual activities.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adult")]
        public virtual string Adult { get; set; }

        /// <summary>Likelihood that this is a medical image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("medical")]
        public virtual string Medical { get; set; }

        /// <summary>
        /// Likelihood that the request image contains racy content. Racy content may include (but is not limited to)
        /// skimpy or sheer clothing, strategically covered nudity, lewd or provocative poses, or close-ups of sensitive
        /// body areas.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("racy")]
        public virtual string Racy { get; set; }

        /// <summary>
        /// Spoof likelihood. The likelihood that an modification was made to the image's canonical version to make it
        /// appear funny or offensive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spoof")]
        public virtual string Spoof { get; set; }

        /// <summary>Likelihood that this image contains violent content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("violence")]
        public virtual string Violence { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single symbol representation.</summary>
    public class GoogleCloudVisionV1p4beta1Symbol : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The bounding box for the symbol. The vertices are in the order of top-left, top-right, bottom-right,
        /// bottom-left. When a rotation of the bounding box is detected the rotation is represented as around the
        /// top-left corner as defined when the text is read in the 'natural' orientation. For example: * when the text
        /// is horizontal it might look like: 0----1 | | 3----2 * when it's rotated 180 degrees around the top-left
        /// corner it becomes: 2----3 | | 1----0 and the vertex order will still be (0, 1, 2, 3).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBox")]
        public virtual GoogleCloudVisionV1p4beta1BoundingPoly BoundingBox { get; set; }

        /// <summary>Confidence of the OCR results for the symbol. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Additional information detected for the symbol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual GoogleCloudVisionV1p4beta1TextAnnotationTextProperty Property { get; set; }

        /// <summary>The actual UTF-8 representation of the symbol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// TextAnnotation contains a structured representation of OCR extracted text. The hierarchy of an OCR extracted
    /// text structure is like this: TextAnnotation -&amp;gt; Page -&amp;gt; Block -&amp;gt; Paragraph -&amp;gt; Word
    /// -&amp;gt; Symbol Each structural component, starting from Page, may further have their own properties.
    /// Properties describe detected languages, breaks etc.. Please refer to the TextAnnotation.TextProperty message
    /// definition below for more detail.
    /// </summary>
    public class GoogleCloudVisionV1p4beta1TextAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of pages detected by OCR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1Page> Pages { get; set; }

        /// <summary>UTF-8 text detected on the pages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected start or end of a structural component.</summary>
    public class GoogleCloudVisionV1p4beta1TextAnnotationDetectedBreak : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>True if break prepends the element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPrefix")]
        public virtual System.Nullable<bool> IsPrefix { get; set; }

        /// <summary>Detected break type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected language for a structural component.</summary>
    public class GoogleCloudVisionV1p4beta1TextAnnotationDetectedLanguage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Confidence of detected language. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// The BCP-47 language code, such as "en-US" or "sr-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional information detected on the structural component.</summary>
    public class GoogleCloudVisionV1p4beta1TextAnnotationTextProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detected start or end of a text segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedBreak")]
        public virtual GoogleCloudVisionV1p4beta1TextAnnotationDetectedBreak DetectedBreak { get; set; }

        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1TextAnnotationDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A vertex represents a 2D point in the image. NOTE: the vertex coordinates are in the same scale as the original
    /// image.
    /// </summary>
    public class GoogleCloudVisionV1p4beta1Vertex : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Relevant information for the image from the Internet.</summary>
    public class GoogleCloudVisionV1p4beta1WebDetection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The service's best guess as to the topic of the request image. Inferred from similar images on the open web.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bestGuessLabels")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1WebDetectionWebLabel> BestGuessLabels { get; set; }

        /// <summary>Fully matching images from the Internet. Can include resized copies of the query image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullMatchingImages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1WebDetectionWebImage> FullMatchingImages { get; set; }

        /// <summary>Web pages containing the matching images from the Internet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pagesWithMatchingImages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1WebDetectionWebPage> PagesWithMatchingImages { get; set; }

        /// <summary>
        /// Partial matching images from the Internet. Those images are similar enough to share some key-point features.
        /// For example an original image will likely have partial matching for its crops.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialMatchingImages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1WebDetectionWebImage> PartialMatchingImages { get; set; }

        /// <summary>The visually similar image results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visuallySimilarImages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1WebDetectionWebImage> VisuallySimilarImages { get; set; }

        /// <summary>Deduced entities from similar images on the Internet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webEntities")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1WebDetectionWebEntity> WebEntities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Entity deduced from similar images on the Internet.</summary>
    public class GoogleCloudVisionV1p4beta1WebDetectionWebEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Canonical description of the entity, in English.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Opaque entity ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityId")]
        public virtual string EntityId { get; set; }

        /// <summary>
        /// Overall relevancy score for the entity. Not normalized and not comparable across different image queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for online images.</summary>
    public class GoogleCloudVisionV1p4beta1WebDetectionWebImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>(Deprecated) Overall relevancy score for the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The result image URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Label to provide extra metadata for the web detection.</summary>
    public class GoogleCloudVisionV1p4beta1WebDetectionWebLabel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label for extra metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>
        /// The BCP-47 language code for `label`, such as "en-US" or "sr-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for web pages.</summary>
    public class GoogleCloudVisionV1p4beta1WebDetectionWebPage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Fully matching images on the page. Can include resized copies of the query image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullMatchingImages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1WebDetectionWebImage> FullMatchingImages { get; set; }

        /// <summary>Title for the web page, may contain HTML markups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageTitle")]
        public virtual string PageTitle { get; set; }

        /// <summary>
        /// Partial matching images on the page. Those images are similar enough to share some key-point features. For
        /// example an original image will likely have partial matching for its crops.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialMatchingImages")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1WebDetectionWebImage> PartialMatchingImages { get; set; }

        /// <summary>(Deprecated) Overall relevancy score for the web page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The result web page URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A word representation.</summary>
    public class GoogleCloudVisionV1p4beta1Word : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The bounding box for the word. The vertices are in the order of top-left, top-right, bottom-right,
        /// bottom-left. When a rotation of the bounding box is detected the rotation is represented as around the
        /// top-left corner as defined when the text is read in the 'natural' orientation. For example: * when the text
        /// is horizontal it might look like: 0----1 | | 3----2 * when it's rotated 180 degrees around the top-left
        /// corner it becomes: 2----3 | | 1----0 and the vertex order will still be (0, 1, 2, 3).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBox")]
        public virtual GoogleCloudVisionV1p4beta1BoundingPoly BoundingBox { get; set; }

        /// <summary>Confidence of the OCR results for the word. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Additional information detected for the word.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual GoogleCloudVisionV1p4beta1TextAnnotationTextProperty Property { get; set; }

        /// <summary>List of symbols in the word. The order of the symbols follows the natural reading order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("symbols")]
        public virtual System.Collections.Generic.IList<GoogleCloudVisionV1p4beta1Symbol> Symbols { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the products similar to a single product in a query image.</summary>
    public class GroupedResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bounding polygon around the product detected in the query image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual BoundingPoly BoundingPoly { get; set; }

        /// <summary>List of generic predictions for the object in the bounding box.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectAnnotations")]
        public virtual System.Collections.Generic.IList<ObjectAnnotation> ObjectAnnotations { get; set; }

        /// <summary>List of results, one for each product match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<Result> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// If an image was produced from a file (e.g. a PDF), this message gives information about the source of that
    /// image.
    /// </summary>
    public class ImageAnnotationContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the file was a PDF or TIFF, this field gives the page number within the file used to produce the image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageNumber")]
        public virtual System.Nullable<int> PageNumber { get; set; }

        /// <summary>The URI of the file used to produce the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Stores image properties, such as dominant colors.</summary>
    public class ImageProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If present, dominant colors completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dominantColors")]
        public virtual DominantColorsAnnotation DominantColors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for the `ImportProductSets` method. This message is returned by the
    /// google.longrunning.Operations.GetOperation method in the returned google.longrunning.Operation.response field.
    /// </summary>
    public class ImportProductSetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of reference_images that are imported successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceImages")]
        public virtual System.Collections.Generic.IList<ReferenceImage> ReferenceImages { get; set; }

        /// <summary>
        /// The rpc status for each ImportProductSet request, including both successes and errors. The number of
        /// statuses here matches the number of lines in the csv file, and statuses[i] stores the success or failure
        /// status of processing the i-th line of the csv, starting from line 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statuses")]
        public virtual System.Collections.Generic.IList<Status> Statuses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The desired input location and metadata.</summary>
    public class InputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// File content, represented as a stream of bytes. Note: As with all `bytes` fields, protobuffers use a pure
        /// binary representation, whereas JSON representations use base64. Currently, this field only works for
        /// BatchAnnotateFiles requests. It does not work for AsyncBatchAnnotateFiles requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>The Google Cloud Storage location to read the input from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GcsSource GcsSource { get; set; }

        /// <summary>
        /// The type of the file. Currently only "application/pdf", "image/tiff" and "image/gif" are supported.
        /// Wildcards are not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A product label represented as a key-value pair.</summary>
    public class KeyValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The key of the label attached to the product. Cannot be empty and cannot exceed 128 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// The value of the label attached to the product. Cannot be empty and cannot exceed 128 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A face-specific landmark (for example, a face feature).</summary>
    public class Landmark : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Face landmark position.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual Position Position { get; set; }

        /// <summary>Face landmark type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An object that represents a latitude/longitude pair. This is expressed as a pair of doubles to represent degrees
    /// latitude and degrees longitude. Unless specified otherwise, this object must conform to the WGS84 standard.
    /// Values must be within normalized ranges.
    /// </summary>
    public class LatLng : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The latitude in degrees. It must be in the range [-90.0, +90.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latitude")]
        public virtual System.Nullable<double> Latitude { get; set; }

        /// <summary>The longitude in degrees. It must be in the range [-180.0, +180.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longitude")]
        public virtual System.Nullable<double> Longitude { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set of detected objects with bounding boxes.</summary>
    public class LocalizedObjectAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Image region to which this object belongs. This must be populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual BoundingPoly BoundingPoly { get; set; }

        /// <summary>
        /// The BCP-47 language code, such as "en-US" or "sr-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Object ID that should align with EntityAnnotation mid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mid")]
        public virtual string Mid { get; set; }

        /// <summary>Object name, expressed in its `language_code` language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Score of the result. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected entity location information.</summary>
    public class LocationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>lat/long location coordinates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latLng")]
        public virtual LatLng LatLng { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A vertex represents a 2D point in the image. NOTE: the normalized vertex coordinates are relative to the
    /// original image and range from 0 to 1.
    /// </summary>
    public class NormalizedVertex : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Prediction for what the object in the bounding box is.</summary>
    public class ObjectAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The BCP-47 language code, such as "en-US" or "sr-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Object ID that should align with EntityAnnotation mid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mid")]
        public virtual string Mid { get; set; }

        /// <summary>Object name, expressed in its `language_code` language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Score of the result. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

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

    /// <summary>Contains metadata for the BatchAnnotateImages operation.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time when the batch request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Current state of the batch operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The time when the operation result was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The desired output location and metadata.</summary>
    public class OutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The max number of response protos to put into each output JSON file on Google Cloud Storage. The valid range
        /// is [1, 100]. If not specified, the default value is 20. For example, for one pdf file with 100 pages, 100
        /// response protos will be generated. If `batch_size` = 20, then 5 json files each containing 20 response
        /// protos will be written under the prefix `gcs_destination`.`uri`. Currently, batch_size only applies to
        /// GcsDestination, with potential future support for other output configurations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchSize")]
        public virtual System.Nullable<int> BatchSize { get; set; }

        /// <summary>The Google Cloud Storage location to write the output(s) to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual GcsDestination GcsDestination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected page from OCR.</summary>
    public class Page : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of blocks of text, images etc on this page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocks")]
        public virtual System.Collections.Generic.IList<Block> Blocks { get; set; }

        /// <summary>Confidence of the OCR results on the page. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// Page height. For PDFs the unit is points. For images (including TIFFs) the unit is pixels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; }

        /// <summary>Additional information detected on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual TextProperty Property { get; set; }

        /// <summary>Page width. For PDFs the unit is points. For images (including TIFFs) the unit is pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Structural unit of text representing a number of words in certain order.</summary>
    public class Paragraph : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The bounding box for the paragraph. The vertices are in the order of top-left, top-right, bottom-right,
        /// bottom-left. When a rotation of the bounding box is detected the rotation is represented as around the
        /// top-left corner as defined when the text is read in the 'natural' orientation. For example: * when the text
        /// is horizontal it might look like: 0----1 | | 3----2 * when it's rotated 180 degrees around the top-left
        /// corner it becomes: 2----3 | | 1----0 and the vertex order will still be (0, 1, 2, 3).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBox")]
        public virtual BoundingPoly BoundingBox { get; set; }

        /// <summary>Confidence of the OCR results for the paragraph. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Additional information detected for the paragraph.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual TextProperty Property { get; set; }

        /// <summary>List of all words in this paragraph.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("words")]
        public virtual System.Collections.Generic.IList<Word> Words { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A 3D position in the image, used primarily for Face detection landmarks. A valid Position must have both x and y
    /// coordinates. The position coordinates are in the same scale as the original image.
    /// </summary>
    public class Position : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual System.Nullable<float> X { get; set; }

        /// <summary>Y coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual System.Nullable<float> Y { get; set; }

        /// <summary>Z coordinate (or depth).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("z")]
        public virtual System.Nullable<float> Z { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Product contains ReferenceImages.</summary>
    public class Product : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// User-provided metadata to be stored with this product. Must be at most 4096 characters long.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The user-provided name for this Product. Must not be empty. Must be at most 4096 characters long.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The resource name of the product. Format is: `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`.
        /// This field is ignored when creating a product.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. The category for the product identified by the reference image. This should be one of
        /// "homegoods-v2", "apparel-v2", "toys-v2", "packagedgoods-v1" or "general-v1". The legacy categories
        /// "homegoods", "apparel", and "toys" are still supported, but these should not be used for new products.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productCategory")]
        public virtual string ProductCategory { get; set; }

        /// <summary>
        /// Key-value pairs that can be attached to a product. At query time, constraints can be specified based on the
        /// product_labels. Note that integer values can be provided as strings, e.g. "1199". Only strings with integer
        /// values can match a range-based restriction which is to be supported soon. Multiple values can be assigned to
        /// the same key. One product may have up to 500 product_labels. Notice that the total number of distinct
        /// product_labels over all products in one ProductSet cannot exceed 1M, otherwise the product search pipeline
        /// will refuse to work for that ProductSet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productLabels")]
        public virtual System.Collections.Generic.IList<KeyValue> ProductLabels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Results for a product search request.</summary>
    public class ProductSearchResults : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Timestamp of the index which provided these results. Products added to the product set and products removed
        /// from the product set after this time are not reflected in the current results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexTime")]
        public virtual object IndexTime { get; set; }

        /// <summary>
        /// List of results grouped by products detected in the query image. Each entry corresponds to one bounding
        /// polygon in the query image, and contains the matching products specific to that region. There may be
        /// duplicate product matches in the union of all the per-product results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productGroupedResults")]
        public virtual System.Collections.Generic.IList<GroupedResult> ProductGroupedResults { get; set; }

        /// <summary>List of results, one for each product match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<Result> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A `Property` consists of a user-supplied name/value pair.</summary>
    public class Property : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Value of numeric properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uint64Value")]
        public virtual System.Nullable<ulong> Uint64Value { get; set; }

        /// <summary>Value of the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `ReferenceImage` represents a product image and its associated metadata, such as bounding boxes.
    /// </summary>
    public class ReferenceImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Bounding polygons around the areas of interest in the reference image. If this field is empty, the
        /// system will try to detect regions of interest. At most 10 bounding polygons will be used. The provided shape
        /// is converted into a non-rotated rectangle. Once converted, the small edge of the rectangle must be greater
        /// than or equal to 300 pixels. The aspect ratio must be 1:4 or less (i.e. 1:3 is ok; 1:5 is not).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPolys")]
        public virtual System.Collections.Generic.IList<BoundingPoly> BoundingPolys { get; set; }

        /// <summary>
        /// The resource name of the reference image. Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID/referenceImages/IMAGE_ID`. This field is ignored
        /// when creating a reference image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The Google Cloud Storage URI of the reference image. The URI must start with `gs://`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a product.</summary>
    public class Result : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name of the image from the product that is the closest match to the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual string Image { get; set; }

        /// <summary>The Product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual Product Product { get; set; }

        /// <summary>A confidence level on the match, ranging from 0 (no confidence) to 1 (full confidence).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Set of features pertaining to the image, computed by computer vision methods over safe-search verticals (for
    /// example, adult, spoof, medical, violence).
    /// </summary>
    public class SafeSearchAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Represents the adult content likelihood for the image. Adult content may contain elements such as nudity,
        /// pornographic images or cartoons, or sexual activities.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adult")]
        public virtual string Adult { get; set; }

        /// <summary>Likelihood that this is a medical image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("medical")]
        public virtual string Medical { get; set; }

        /// <summary>
        /// Likelihood that the request image contains racy content. Racy content may include (but is not limited to)
        /// skimpy or sheer clothing, strategically covered nudity, lewd or provocative poses, or close-ups of sensitive
        /// body areas.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("racy")]
        public virtual string Racy { get; set; }

        /// <summary>
        /// Spoof likelihood. The likelihood that an modification was made to the image's canonical version to make it
        /// appear funny or offensive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spoof")]
        public virtual string Spoof { get; set; }

        /// <summary>Likelihood that this image contains violent content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("violence")]
        public virtual string Violence { get; set; }

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

    /// <summary>A single symbol representation.</summary>
    public class Symbol : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The bounding box for the symbol. The vertices are in the order of top-left, top-right, bottom-right,
        /// bottom-left. When a rotation of the bounding box is detected the rotation is represented as around the
        /// top-left corner as defined when the text is read in the 'natural' orientation. For example: * when the text
        /// is horizontal it might look like: 0----1 | | 3----2 * when it's rotated 180 degrees around the top-left
        /// corner it becomes: 2----3 | | 1----0 and the vertex order will still be (0, 1, 2, 3).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBox")]
        public virtual BoundingPoly BoundingBox { get; set; }

        /// <summary>Confidence of the OCR results for the symbol. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Additional information detected for the symbol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual TextProperty Property { get; set; }

        /// <summary>The actual UTF-8 representation of the symbol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// TextAnnotation contains a structured representation of OCR extracted text. The hierarchy of an OCR extracted
    /// text structure is like this: TextAnnotation -&amp;gt; Page -&amp;gt; Block -&amp;gt; Paragraph -&amp;gt; Word
    /// -&amp;gt; Symbol Each structural component, starting from Page, may further have their own properties.
    /// Properties describe detected languages, breaks etc.. Please refer to the TextAnnotation.TextProperty message
    /// definition below for more detail.
    /// </summary>
    public class TextAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of pages detected by OCR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pages")]
        public virtual System.Collections.Generic.IList<Page> Pages { get; set; }

        /// <summary>UTF-8 text detected on the pages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional information detected on the structural component.</summary>
    public class TextProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detected start or end of a text segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedBreak")]
        public virtual DetectedBreak DetectedBreak { get; set; }

        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<DetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A vertex represents a 2D point in the image. NOTE: the vertex coordinates are in the same scale as the original
    /// image.
    /// </summary>
    public class Vertex : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Relevant information for the image from the Internet.</summary>
    public class WebDetection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The service's best guess as to the topic of the request image. Inferred from similar images on the open web.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bestGuessLabels")]
        public virtual System.Collections.Generic.IList<WebLabel> BestGuessLabels { get; set; }

        /// <summary>Fully matching images from the Internet. Can include resized copies of the query image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullMatchingImages")]
        public virtual System.Collections.Generic.IList<WebImage> FullMatchingImages { get; set; }

        /// <summary>Web pages containing the matching images from the Internet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pagesWithMatchingImages")]
        public virtual System.Collections.Generic.IList<WebPage> PagesWithMatchingImages { get; set; }

        /// <summary>
        /// Partial matching images from the Internet. Those images are similar enough to share some key-point features.
        /// For example an original image will likely have partial matching for its crops.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialMatchingImages")]
        public virtual System.Collections.Generic.IList<WebImage> PartialMatchingImages { get; set; }

        /// <summary>The visually similar image results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visuallySimilarImages")]
        public virtual System.Collections.Generic.IList<WebImage> VisuallySimilarImages { get; set; }

        /// <summary>Deduced entities from similar images on the Internet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webEntities")]
        public virtual System.Collections.Generic.IList<WebEntity> WebEntities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Entity deduced from similar images on the Internet.</summary>
    public class WebEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Canonical description of the entity, in English.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Opaque entity ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityId")]
        public virtual string EntityId { get; set; }

        /// <summary>
        /// Overall relevancy score for the entity. Not normalized and not comparable across different image queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for online images.</summary>
    public class WebImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>(Deprecated) Overall relevancy score for the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The result image URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Label to provide extra metadata for the web detection.</summary>
    public class WebLabel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label for extra metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>
        /// The BCP-47 language code for `label`, such as "en-US" or "sr-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for web pages.</summary>
    public class WebPage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Fully matching images on the page. Can include resized copies of the query image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullMatchingImages")]
        public virtual System.Collections.Generic.IList<WebImage> FullMatchingImages { get; set; }

        /// <summary>Title for the web page, may contain HTML markups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageTitle")]
        public virtual string PageTitle { get; set; }

        /// <summary>
        /// Partial matching images on the page. Those images are similar enough to share some key-point features. For
        /// example an original image will likely have partial matching for its crops.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialMatchingImages")]
        public virtual System.Collections.Generic.IList<WebImage> PartialMatchingImages { get; set; }

        /// <summary>(Deprecated) Overall relevancy score for the web page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The result web page URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A word representation.</summary>
    public class Word : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The bounding box for the word. The vertices are in the order of top-left, top-right, bottom-right,
        /// bottom-left. When a rotation of the bounding box is detected the rotation is represented as around the
        /// top-left corner as defined when the text is read in the 'natural' orientation. For example: * when the text
        /// is horizontal it might look like: 0----1 | | 3----2 * when it's rotated 180 degrees around the top-left
        /// corner it becomes: 2----3 | | 1----0 and the vertex order will still be (0, 1, 2, 3).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBox")]
        public virtual BoundingPoly BoundingBox { get; set; }

        /// <summary>Confidence of the OCR results for the word. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Additional information detected for the word.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual TextProperty Property { get; set; }

        /// <summary>List of symbols in the word. The order of the symbols follows the natural reading order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("symbols")]
        public virtual System.Collections.Generic.IList<Symbol> Symbols { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
