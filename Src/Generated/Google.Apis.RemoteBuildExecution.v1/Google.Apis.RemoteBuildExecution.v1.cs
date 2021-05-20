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

namespace Google.Apis.RemoteBuildExecution.v1
{
    /// <summary>The RemoteBuildExecution Service.</summary>
    public class RemoteBuildExecutionService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public RemoteBuildExecutionService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public RemoteBuildExecutionService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Media = new MediaResource(this);
            Operations = new OperationsResource(this);
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "remotebuildexecution";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://remotebuildexecution.googleapis.com/";
        #else
            "https://remotebuildexecution.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://remotebuildexecution.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Remote Build Execution API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Remote Build Execution API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Media resource.</summary>
        public virtual MediaResource Media { get; }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for RemoteBuildExecution requests.</summary>
    public abstract class RemoteBuildExecutionBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new RemoteBuildExecutionBaseServiceRequest instance.</summary>
        protected RemoteBuildExecutionBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes RemoteBuildExecution parameter list.</summary>
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

    /// <summary>The "media" collection of methods.</summary>
    public class MediaResource
    {
        private const string Resource = "media";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MediaResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Downloads media. Download is supported on the URI `/v1/media/{+name}?alt=media`.</summary>
        /// <param name="resourceName">
        /// Name of the media that is being downloaded. See ReadRequest.resource_name.
        /// </param>
        public virtual DownloadRequest Download(string resourceName)
        {
            return new DownloadRequest(service, resourceName);
        }

        /// <summary>Downloads media. Download is supported on the URI `/v1/media/{+name}?alt=media`.</summary>
        public class DownloadRequest : RemoteBuildExecutionBaseServiceRequest<Google.Apis.RemoteBuildExecution.v1.Data.GoogleBytestreamMedia>
        {
            /// <summary>Constructs a new Download request.</summary>
            public DownloadRequest(Google.Apis.Services.IClientService service, string resourceName) : base(service)
            {
                ResourceName = resourceName;
                MediaDownloader = new Google.Apis.Download.MediaDownloader(service);
                InitParameters();
            }

            /// <summary>Name of the media that is being downloaded. See ReadRequest.resource_name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceName { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "download";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/media/{+resourceName}";

            /// <summary>Initializes Download parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceName", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^.*$",
                });
            }

            /// <summary>Gets the media downloader.</summary>
            public Google.Apis.Download.IMediaDownloader MediaDownloader { get; private set; }

            /// <summary>
            /// <para>Synchronously download the media into the given stream.</para>
            /// <para>
            /// Warning: This method hides download errors; use <see cref="DownloadWithStatus(System.IO.Stream)"/>
            /// instead.
            /// </para>
            /// </summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual void Download(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                #if !NET40
                mediaDownloader.Range = null;
                #endif
                mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Synchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            /// <returns>The final status of the download; including whether the download succeeded or failed.</returns>
            public virtual Google.Apis.Download.IDownloadProgress DownloadWithStatus(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                #if !NET40
                mediaDownloader.Range = null;
                #endif
                return mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                #if !NET40
                mediaDownloader.Range = null;
                #endif
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream,
                System.Threading.CancellationToken cancellationToken)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                #if !NET40
                mediaDownloader.Range = null;
                #endif
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }

            #if !NET40
            /// <summary>Synchronously download a range of the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual Google.Apis.Download.IDownloadProgress DownloadRange(System.IO.Stream stream, System.Net.Http.Headers.RangeHeaderValue range)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = range;
                return mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download a range of the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadRangeAsync(System.IO.Stream stream,
                System.Net.Http.Headers.RangeHeaderValue range,
                System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = range;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }
            #endif
        }

        /// <summary>Uploads media. Upload is supported on the URI `/upload/v1/media/{+name}`.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceName">
        /// Name of the media that is being downloaded. See ReadRequest.resource_name.
        /// </param>
        public virtual UploadRequest Upload(Google.Apis.RemoteBuildExecution.v1.Data.GoogleBytestreamMedia body, string resourceName)
        {
            return new UploadRequest(service, body, resourceName);
        }

        /// <summary>Uploads media. Upload is supported on the URI `/upload/v1/media/{+name}`.</summary>
        public class UploadRequest : RemoteBuildExecutionBaseServiceRequest<Google.Apis.RemoteBuildExecution.v1.Data.GoogleBytestreamMedia>
        {
            /// <summary>Constructs a new Upload request.</summary>
            public UploadRequest(Google.Apis.Services.IClientService service, Google.Apis.RemoteBuildExecution.v1.Data.GoogleBytestreamMedia body, string resourceName) : base(service)
            {
                ResourceName = resourceName;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the media that is being downloaded. See ReadRequest.resource_name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceName { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.RemoteBuildExecution.v1.Data.GoogleBytestreamMedia Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "upload";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/media/{+resourceName}";

            /// <summary>Initializes Upload parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceName", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^.*$",
                });
            }
        }

        /// <summary>Uploads media. Upload is supported on the URI `/upload/v1/media/{+name}`.</summary>
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
        /// <param name="resourceName">
        /// Name of the media that is being downloaded. See ReadRequest.resource_name.
        /// </param>
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual UploadMediaUpload Upload(Google.Apis.RemoteBuildExecution.v1.Data.GoogleBytestreamMedia body, string resourceName, System.IO.Stream stream, string contentType)
        {
            return new UploadMediaUpload(service, body, resourceName, stream, contentType);
        }

        /// <summary>Upload media upload which supports resumable upload.</summary>
        public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.RemoteBuildExecution.v1.Data.GoogleBytestreamMedia, Google.Apis.RemoteBuildExecution.v1.Data.GoogleBytestreamMedia>
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

            /// <summary>Name of the media that is being downloaded. See ReadRequest.resource_name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceName { get; private set; }

            /// <summary>Constructs a new Upload media upload instance.</summary>
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
            public UploadMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.RemoteBuildExecution.v1.Data.GoogleBytestreamMedia body, string resourceName, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "v1/media/{+resourceName}"), "POST", stream, contentType)
            {
                ResourceName = resourceName;
                Body = body;
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

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the
        /// operation, but success is not guaranteed. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to check whether
        /// the cancellation succeeded or whether the operation completed despite cancellation. On successful
        /// cancellation, the operation is not deleted; instead, it becomes an operation with an Operation.error value
        /// with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">The name of the operation resource to be cancelled.</param>
        public virtual CancelRequest Cancel(Google.Apis.RemoteBuildExecution.v1.Data.GoogleLongrunningCancelOperationRequest body, string name)
        {
            return new CancelRequest(service, body, name);
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the
        /// operation, but success is not guaranteed. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to check whether
        /// the cancellation succeeded or whether the operation completed despite cancellation. On successful
        /// cancellation, the operation is not deleted; instead, it becomes an operation with an Operation.error value
        /// with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
        /// </summary>
        public class CancelRequest : RemoteBuildExecutionBaseServiceRequest<Google.Apis.RemoteBuildExecution.v1.Data.GoogleProtobufEmpty>
        {
            /// <summary>Constructs a new Cancel request.</summary>
            public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.RemoteBuildExecution.v1.Data.GoogleLongrunningCancelOperationRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>The name of the operation resource to be cancelled.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.RemoteBuildExecution.v1.Data.GoogleLongrunningCancelOperationRequest Body { get; set; }

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
                    Pattern = @"^operations/.*$",
                });
            }
        }

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is no longer interested in the
        /// operation result. It does not cancel the operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="name">The name of the operation resource to be deleted.</param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is no longer interested in the
        /// operation result. It does not cancel the operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        public class DeleteRequest : RemoteBuildExecutionBaseServiceRequest<Google.Apis.RemoteBuildExecution.v1.Data.GoogleProtobufEmpty>
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
            public override string RestPath => "v1/{+name}";

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
                    Pattern = @"^operations/.*$",
                });
            }
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the server doesn't support this method,
        /// it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the binding to use
        /// different resource name schemes, such as `users/*/operations`. To override the binding, API services can add
        /// a binding such as `"/v1/{name=users/*}/operations"` to their service configuration. For backwards
        /// compatibility, the default name includes the operations collection id, however overriding users must ensure
        /// the name binding is the parent resource, without the operations collection id.
        /// </summary>
        /// <param name="name">The name of the operation's parent resource.</param>
        public virtual ListRequest List(string name)
        {
            return new ListRequest(service, name);
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the server doesn't support this method,
        /// it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the binding to use
        /// different resource name schemes, such as `users/*/operations`. To override the binding, API services can add
        /// a binding such as `"/v1/{name=users/*}/operations"` to their service configuration. For backwards
        /// compatibility, the default name includes the operations collection id, however overriding users must ensure
        /// the name binding is the parent resource, without the operations collection id.
        /// </summary>
        public class ListRequest : RemoteBuildExecutionBaseServiceRequest<Google.Apis.RemoteBuildExecution.v1.Data.GoogleLongrunningListOperationsResponse>
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
                    Pattern = @"^operations$",
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
            Operations = new OperationsResource(service);
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
            /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
            /// result at intervals as recommended by the API service.
            /// </summary>
            /// <param name="name">The name of the operation resource.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
            /// result at intervals as recommended by the API service.
            /// </summary>
            public class GetRequest : RemoteBuildExecutionBaseServiceRequest<Google.Apis.RemoteBuildExecution.v1.Data.GoogleLongrunningOperation>
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
                        Pattern = @"^projects/[^/]+/operations/[^/]+$",
                    });
                }
            }
        }
    }
}
namespace Google.Apis.RemoteBuildExecution.v1.Data
{
    /// <summary>
    /// An `Action` captures all the information about an execution which is required to reproduce it. `Action`s are the
    /// core component of the [Execution] service. A single `Action` represents a repeatable action that can be
    /// performed by the execution service. `Action`s can be succinctly identified by the digest of their wire format
    /// encoding and, once an `Action` has been executed, will be cached in the action cache. Future requests can then
    /// use the cached result rather than needing to run afresh. When a server completes execution of an Action, it MAY
    /// choose to cache the result in the ActionCache unless `do_not_cache` is `true`. Clients SHOULD expect the server
    /// to do so. By default, future calls to Execute the same `Action` will also serve their results from the cache.
    /// Clients must take care to understand the caching behaviour. Ideally, all `Action`s will be reproducible so that
    /// serving a result from cache is always desirable and correct.
    /// </summary>
    public class BuildBazelRemoteExecutionV2Action : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The digest of the Command to run, which MUST be present in the ContentAddressableStorage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commandDigest")]
        public virtual BuildBazelRemoteExecutionV2Digest CommandDigest { get; set; }

        /// <summary>
        /// If true, then the `Action`'s result cannot be cached, and in-flight requests for the same `Action` may not
        /// be merged.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doNotCache")]
        public virtual System.Nullable<bool> DoNotCache { get; set; }

        /// <summary>
        /// The digest of the root Directory for the input files. The files in the directory tree are available in the
        /// correct location on the build machine before the command is executed. The root directory, as well as every
        /// subdirectory and content blob referred to, MUST be in the ContentAddressableStorage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputRootDigest")]
        public virtual BuildBazelRemoteExecutionV2Digest InputRootDigest { get; set; }

        /// <summary>
        /// The optional platform requirements for the execution environment. The server MAY choose to execute the
        /// action on any worker satisfying the requirements, so the client SHOULD ensure that running the action on any
        /// such worker will have the same result. A detailed lexicon for this can be found in the accompanying
        /// platform.md. New in version 2.2: clients SHOULD set these platform properties as well as those in the
        /// Command. Servers SHOULD prefer those set here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual BuildBazelRemoteExecutionV2Platform Platform { get; set; }

        /// <summary>
        /// An optional additional salt value used to place this `Action` into a separate cache namespace from other
        /// instances having the same field contents. This salt typically comes from operational configuration specific
        /// to sources such as repo and service configuration, and allows disowning an entire set of ActionResults that
        /// might have been poisoned by buggy software or tool failures.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("salt")]
        public virtual string Salt { get; set; }

        /// <summary>
        /// A timeout after which the execution should be killed. If the timeout is absent, then the client is
        /// specifying that the execution should continue as long as the server will let it. The server SHOULD impose a
        /// timeout if the client does not specify one, however, if the client does specify a timeout that is longer
        /// than the server's maximum timeout, the server MUST reject the request. The timeout is a part of the Action
        /// message, and therefore two `Actions` with different timeouts are different, even if they are otherwise
        /// identical. This is because, if they were not, running an `Action` with a lower timeout than is required
        /// might result in a cache hit from an execution run with a longer timeout, hiding the fact that the timeout is
        /// too short. By encoding it directly in the `Action`, a lower timeout will result in a cache miss and the
        /// execution timeout will fail immediately, rather than whenever the cache entry gets evicted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An ActionResult represents the result of an Action being run. It is advised that at least one field (for example
    /// `ActionResult.execution_metadata.Worker`) have a non-default value, to ensure that the serialized value is
    /// non-empty, which can then be used as a basic data sanity check.
    /// </summary>
    public class BuildBazelRemoteExecutionV2ActionResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The details of the execution that originally produced this result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionMetadata")]
        public virtual BuildBazelRemoteExecutionV2ExecutedActionMetadata ExecutionMetadata { get; set; }

        /// <summary>The exit code of the command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitCode")]
        public virtual System.Nullable<int> ExitCode { get; set; }

        /// <summary>
        /// The output directories of the action. For each output directory requested in the `output_directories` or
        /// `output_paths` field of the Action, if the corresponding directory existed after the action completed, a
        /// single entry will be present in the output list, which will contain the digest of a Tree message containing
        /// the directory tree, and the path equal exactly to the corresponding Action output_directories member. As an
        /// example, suppose the Action had an output directory `a/b/dir` and the execution produced the following
        /// contents in `a/b/dir`: a file named `bar` and a directory named `foo` with an executable file named `baz`.
        /// Then, output_directory will contain (hashes shortened for readability): ```json // OutputDirectory proto: {
        /// path: "a/b/dir" tree_digest: { hash: "4a73bc9d03...", size: 55 } } // Tree proto with hash "4a73bc9d03..."
        /// and size 55: { root: { files: [ { name: "bar", digest: { hash: "4a73bc9d03...", size: 65534 } } ],
        /// directories: [ { name: "foo", digest: { hash: "4cf2eda940...", size: 43 } } ] } children : { // (Directory
        /// proto with hash "4cf2eda940..." and size 43) files: [ { name: "baz", digest: { hash: "b2c941073e...", size:
        /// 1294, }, is_executable: true } ] } } ``` If an output of the same name as listed in `output_files` of the
        /// Command was found in `output_directories`, but was not a directory, the server will return a
        /// FAILED_PRECONDITION.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputDirectories")]
        public virtual System.Collections.Generic.IList<BuildBazelRemoteExecutionV2OutputDirectory> OutputDirectories { get; set; }

        /// <summary>
        /// The output directories of the action that are symbolic links to other directories. Those may be links to
        /// other output directories, or input directories, or even absolute paths outside of the working directory, if
        /// the server supports SymlinkAbsolutePathStrategy.ALLOWED. For each output directory requested in the
        /// `output_directories` field of the Action, if the directory existed after the action completed, a single
        /// entry will be present either in this field, or in the `output_directories` field, if the directory was not a
        /// symbolic link. If an output of the same name was found, but was a symbolic link to a file instead of a
        /// directory, the server will return a FAILED_PRECONDITION. If the action does not produce the requested
        /// output, then that output will be omitted from the list. The server is free to arrange the output list as
        /// desired; clients MUST NOT assume that the output list is sorted. DEPRECATED as of v2.1. Servers that wish to
        /// be compatible with v2.0 API should still populate this field in addition to `output_symlinks`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputDirectorySymlinks")]
        public virtual System.Collections.Generic.IList<BuildBazelRemoteExecutionV2OutputSymlink> OutputDirectorySymlinks { get; set; }

        /// <summary>
        /// The output files of the action that are symbolic links to other files. Those may be links to other output
        /// files, or input files, or even absolute paths outside of the working directory, if the server supports
        /// SymlinkAbsolutePathStrategy.ALLOWED. For each output file requested in the `output_files` or `output_paths`
        /// field of the Action, if the corresponding file existed after the action completed, a single entry will be
        /// present either in this field, or in the `output_files` field, if the file was not a symbolic link. If an
        /// output symbolic link of the same name as listed in `output_files` of the Command was found, but its target
        /// type was not a regular file, the server will return a FAILED_PRECONDITION. If the action does not produce
        /// the requested output, then that output will be omitted from the list. The server is free to arrange the
        /// output list as desired; clients MUST NOT assume that the output list is sorted. DEPRECATED as of v2.1.
        /// Servers that wish to be compatible with v2.0 API should still populate this field in addition to
        /// `output_symlinks`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputFileSymlinks")]
        public virtual System.Collections.Generic.IList<BuildBazelRemoteExecutionV2OutputSymlink> OutputFileSymlinks { get; set; }

        /// <summary>
        /// The output files of the action. For each output file requested in the `output_files` or `output_paths` field
        /// of the Action, if the corresponding file existed after the action completed, a single entry will be present
        /// either in this field, or the `output_file_symlinks` field if the file was a symbolic link to another file
        /// (`output_symlinks` field after v2.1). If an output listed in `output_files` was found, but was a directory
        /// rather than a regular file, the server will return a FAILED_PRECONDITION. If the action does not produce the
        /// requested output, then that output will be omitted from the list. The server is free to arrange the output
        /// list as desired; clients MUST NOT assume that the output list is sorted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputFiles")]
        public virtual System.Collections.Generic.IList<BuildBazelRemoteExecutionV2OutputFile> OutputFiles { get; set; }

        /// <summary>
        /// New in v2.1: this field will only be populated if the command `output_paths` field was used, and not the pre
        /// v2.1 `output_files` or `output_directories` fields. The output paths of the action that are symbolic links
        /// to other paths. Those may be links to other outputs, or inputs, or even absolute paths outside of the
        /// working directory, if the server supports SymlinkAbsolutePathStrategy.ALLOWED. A single entry for each
        /// output requested in `output_paths` field of the Action, if the corresponding path existed after the action
        /// completed and was a symbolic link. If the action does not produce a requested output, then that output will
        /// be omitted from the list. The server is free to arrange the output list as desired; clients MUST NOT assume
        /// that the output list is sorted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputSymlinks")]
        public virtual System.Collections.Generic.IList<BuildBazelRemoteExecutionV2OutputSymlink> OutputSymlinks { get; set; }

        /// <summary>
        /// The digest for a blob containing the standard error of the action, which can be retrieved from the
        /// ContentAddressableStorage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stderrDigest")]
        public virtual BuildBazelRemoteExecutionV2Digest StderrDigest { get; set; }

        /// <summary>
        /// The standard error buffer of the action. The server SHOULD NOT inline stderr unless requested by the client
        /// in the GetActionResultRequest message. The server MAY omit inlining, even if requested, and MUST do so if
        /// inlining would cause the response to exceed message size limits.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stderrRaw")]
        public virtual string StderrRaw { get; set; }

        /// <summary>
        /// The digest for a blob containing the standard output of the action, which can be retrieved from the
        /// ContentAddressableStorage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stdoutDigest")]
        public virtual BuildBazelRemoteExecutionV2Digest StdoutDigest { get; set; }

        /// <summary>
        /// The standard output buffer of the action. The server SHOULD NOT inline stdout unless requested by the client
        /// in the GetActionResultRequest message. The server MAY omit inlining, even if requested, and MUST do so if
        /// inlining would cause the response to exceed message size limits.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stdoutRaw")]
        public virtual string StdoutRaw { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `Command` is the actual command executed by a worker running an Action and specifications of its environment.
    /// Except as otherwise required, the environment (such as which system libraries or binaries are available, and
    /// what filesystems are mounted where) is defined by and specific to the implementation of the remote execution
    /// API.
    /// </summary>
    public class BuildBazelRemoteExecutionV2Command : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The arguments to the command. The first argument must be the path to the executable, which must be either a
        /// relative path, in which case it is evaluated with respect to the input root, or an absolute path.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arguments")]
        public virtual System.Collections.Generic.IList<string> Arguments { get; set; }

        /// <summary>
        /// The environment variables to set when running the program. The worker may provide its own default
        /// environment variables; these defaults can be overridden using this field. Additional variables can also be
        /// specified. In order to ensure that equivalent Commands always hash to the same value, the environment
        /// variables MUST be lexicographically sorted by name. Sorting of strings is done by code point, equivalently,
        /// by the UTF-8 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environmentVariables")]
        public virtual System.Collections.Generic.IList<BuildBazelRemoteExecutionV2CommandEnvironmentVariable> EnvironmentVariables { get; set; }

        /// <summary>
        /// A list of the output directories that the client expects to retrieve from the action. Only the listed
        /// directories will be returned (an entire directory structure will be returned as a Tree message digest, see
        /// OutputDirectory), as well as files listed in `output_files`. Other files or directories that may be created
        /// during command execution are discarded. The paths are relative to the working directory of the action
        /// execution. The paths are specified using a single forward slash (`/`) as a path separator, even if the
        /// execution platform natively uses a different separator. The path MUST NOT include a trailing slash, nor a
        /// leading slash, being a relative path. The special value of empty string is allowed, although not
        /// recommended, and can be used to capture the entire working directory tree, including inputs. In order to
        /// ensure consistent hashing of the same Action, the output paths MUST be sorted lexicographically by code
        /// point (or, equivalently, by UTF-8 bytes). An output directory cannot be duplicated or have the same path as
        /// any of the listed output files. An output directory is allowed to be a parent of another output directory.
        /// Directories leading up to the output directories (but not the output directories themselves) are created by
        /// the worker prior to execution, even if they are not explicitly part of the input root. DEPRECATED since 2.1:
        /// Use `output_paths` instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputDirectories")]
        public virtual System.Collections.Generic.IList<string> OutputDirectories { get; set; }

        /// <summary>
        /// A list of the output files that the client expects to retrieve from the action. Only the listed files, as
        /// well as directories listed in `output_directories`, will be returned to the client as output. Other files or
        /// directories that may be created during command execution are discarded. The paths are relative to the
        /// working directory of the action execution. The paths are specified using a single forward slash (`/`) as a
        /// path separator, even if the execution platform natively uses a different separator. The path MUST NOT
        /// include a trailing slash, nor a leading slash, being a relative path. In order to ensure consistent hashing
        /// of the same Action, the output paths MUST be sorted lexicographically by code point (or, equivalently, by
        /// UTF-8 bytes). An output file cannot be duplicated, be a parent of another output file, or have the same path
        /// as any of the listed output directories. Directories leading up to the output files are created by the
        /// worker prior to execution, even if they are not explicitly part of the input root. DEPRECATED since v2.1:
        /// Use `output_paths` instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputFiles")]
        public virtual System.Collections.Generic.IList<string> OutputFiles { get; set; }

        /// <summary>
        /// A list of keys for node properties the client expects to retrieve for output files and directories. Keys are
        /// either names of string-based NodeProperty or names of fields in NodeProperties. In order to ensure that
        /// equivalent `Action`s always hash to the same value, the node properties MUST be lexicographically sorted by
        /// name. Sorting of strings is done by code point, equivalently, by the UTF-8 bytes. The interpretation of
        /// string-based properties is server-dependent. If a property is not recognized by the server, the server will
        /// return an `INVALID_ARGUMENT`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputNodeProperties")]
        public virtual System.Collections.Generic.IList<string> OutputNodeProperties { get; set; }

        /// <summary>
        /// A list of the output paths that the client expects to retrieve from the action. Only the listed paths will
        /// be returned to the client as output. The type of the output (file or directory) is not specified, and will
        /// be determined by the server after action execution. If the resulting path is a file, it will be returned in
        /// an OutputFile) typed field. If the path is a directory, the entire directory structure will be returned as a
        /// Tree message digest, see OutputDirectory) Other files or directories that may be created during command
        /// execution are discarded. The paths are relative to the working directory of the action execution. The paths
        /// are specified using a single forward slash (`/`) as a path separator, even if the execution platform
        /// natively uses a different separator. The path MUST NOT include a trailing slash, nor a leading slash, being
        /// a relative path. In order to ensure consistent hashing of the same Action, the output paths MUST be
        /// deduplicated and sorted lexicographically by code point (or, equivalently, by UTF-8 bytes). Directories
        /// leading up to the output paths are created by the worker prior to execution, even if they are not explicitly
        /// part of the input root. New in v2.1: this field supersedes the DEPRECATED `output_files` and
        /// `output_directories` fields. If `output_paths` is used, `output_files` and `output_directories` will be
        /// ignored!
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputPaths")]
        public virtual System.Collections.Generic.IList<string> OutputPaths { get; set; }

        /// <summary>
        /// The platform requirements for the execution environment. The server MAY choose to execute the action on any
        /// worker satisfying the requirements, so the client SHOULD ensure that running the action on any such worker
        /// will have the same result. A detailed lexicon for this can be found in the accompanying platform.md.
        /// DEPRECATED as of v2.2: platform properties are now specified directly in the action. See documentation note
        /// in the Action for migration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual BuildBazelRemoteExecutionV2Platform Platform { get; set; }

        /// <summary>
        /// The working directory, relative to the input root, for the command to run in. It must be a directory which
        /// exists in the input tree. If it is left empty, then the action is run in the input root.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workingDirectory")]
        public virtual string WorkingDirectory { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An `EnvironmentVariable` is one variable to set in the running program's environment.</summary>
    public class BuildBazelRemoteExecutionV2CommandEnvironmentVariable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The variable name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The variable value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A content digest. A digest for a given blob consists of the size of the blob and its hash. The hash algorithm to
    /// use is defined by the server. The size is considered to be an integral part of the digest and cannot be
    /// separated. That is, even if the `hash` field is correctly specified but `size_bytes` is not, the server MUST
    /// reject the request. The reason for including the size in the digest is as follows: in a great many cases, the
    /// server needs to know the size of the blob it is about to work with prior to starting an operation with it, such
    /// as flattening Merkle tree structures or streaming it to a worker. Technically, the server could implement a
    /// separate metadata store, but this results in a significantly more complicated implementation as opposed to
    /// having the client specify the size up-front (or storing the size along with the digest in every message where
    /// digests are embedded). This does mean that the API leaks some implementation details of (what we consider to be)
    /// a reasonable server implementation, but we consider this to be a worthwhile tradeoff. When a `Digest` is used to
    /// refer to a proto message, it always refers to the message in binary encoded form. To ensure consistent hashing,
    /// clients and servers MUST ensure that they serialize messages according to the following rules, even if there are
    /// alternate valid encodings for the same message: * Fields are serialized in tag order. * There are no unknown
    /// fields. * There are no duplicate fields. * Fields are serialized according to the default semantics for their
    /// type. Most protocol buffer implementations will always follow these rules when serializing, but care should be
    /// taken to avoid shortcuts. For instance, concatenating two messages to merge them may produce duplicate fields.
    /// </summary>
    public class BuildBazelRemoteExecutionV2Digest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The hash. In the case of SHA-256, it will always be a lowercase hex string exactly 64 characters long.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hash")]
        public virtual string Hash { get; set; }

        /// <summary>The size of the blob, in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeBytes")]
        public virtual System.Nullable<long> SizeBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `Directory` represents a directory node in a file tree, containing zero or more children FileNodes,
    /// DirectoryNodes and SymlinkNodes. Each `Node` contains its name in the directory, either the digest of its
    /// content (either a file blob or a `Directory` proto) or a symlink target, as well as possibly some metadata about
    /// the file or directory. In order to ensure that two equivalent directory trees hash to the same value, the
    /// following restrictions MUST be obeyed when constructing a a `Directory`: * Every child in the directory must
    /// have a path of exactly one segment. Multiple levels of directory hierarchy may not be collapsed. * Each child in
    /// the directory must have a unique path segment (file name). Note that while the API itself is case-sensitive, the
    /// environment where the Action is executed may or may not be case-sensitive. That is, it is legal to call the API
    /// with a Directory that has both "Foo" and "foo" as children, but the Action may be rejected by the remote system
    /// upon execution. * The files, directories and symlinks in the directory must each be sorted in lexicographical
    /// order by path. The path strings must be sorted by code point, equivalently, by UTF-8 bytes. * The NodeProperties
    /// of files, directories, and symlinks must be sorted in lexicographical order by property name. A `Directory` that
    /// obeys the restrictions is said to be in canonical form. As an example, the following could be used for a file
    /// named `bar` and a directory named `foo` with an executable file named `baz` (hashes shortened for readability):
    /// ```json // (Directory proto) { files: [ { name: "bar", digest: { hash: "4a73bc9d03...", size: 65534 },
    /// node_properties: [ { "name": "MTime", "value": "2017-01-15T01:30:15.01Z" } ] } ], directories: [ { name: "foo",
    /// digest: { hash: "4cf2eda940...", size: 43 } } ] } // (Directory proto with hash "4cf2eda940..." and size 43) {
    /// files: [ { name: "baz", digest: { hash: "b2c941073e...", size: 1294, }, is_executable: true } ] } ```
    /// </summary>
    public class BuildBazelRemoteExecutionV2Directory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The subdirectories in the directory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directories")]
        public virtual System.Collections.Generic.IList<BuildBazelRemoteExecutionV2DirectoryNode> Directories { get; set; }

        /// <summary>The files in the directory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("files")]
        public virtual System.Collections.Generic.IList<BuildBazelRemoteExecutionV2FileNode> Files { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("nodeProperties")]
        public virtual BuildBazelRemoteExecutionV2NodeProperties NodeProperties { get; set; }

        /// <summary>The symlinks in the directory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("symlinks")]
        public virtual System.Collections.Generic.IList<BuildBazelRemoteExecutionV2SymlinkNode> Symlinks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `DirectoryNode` represents a child of a Directory which is itself a `Directory` and its associated metadata.
    /// </summary>
    public class BuildBazelRemoteExecutionV2DirectoryNode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The digest of the Directory object represented. See Digest for information about how to take the digest of a
        /// proto message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digest")]
        public virtual BuildBazelRemoteExecutionV2Digest Digest { get; set; }

        /// <summary>The name of the directory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata about an ongoing execution, which will be contained in the metadata field of the Operation.
    /// </summary>
    public class BuildBazelRemoteExecutionV2ExecuteOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The digest of the Action being executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionDigest")]
        public virtual BuildBazelRemoteExecutionV2Digest ActionDigest { get; set; }

        /// <summary>The current stage of execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stage")]
        public virtual string Stage { get; set; }

        /// <summary>
        /// If set, the client can use this resource name with ByteStream.Read to stream the standard error from the
        /// endpoint hosting streamed responses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stderrStreamName")]
        public virtual string StderrStreamName { get; set; }

        /// <summary>
        /// If set, the client can use this resource name with ByteStream.Read to stream the standard output from the
        /// endpoint hosting streamed responses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stdoutStreamName")]
        public virtual string StdoutStreamName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The response message for Execution.Execute, which will be contained in the response field of the Operation.
    /// </summary>
    public class BuildBazelRemoteExecutionV2ExecuteResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>True if the result was served from cache, false if it was executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cachedResult")]
        public virtual System.Nullable<bool> CachedResult { get; set; }

        /// <summary>
        /// Freeform informational message with details on the execution of the action that may be displayed to the user
        /// upon failure or when requested explicitly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The result of the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual BuildBazelRemoteExecutionV2ActionResult Result { get; set; }

        /// <summary>
        /// An optional list of additional log outputs the server wishes to provide. A server can use this to return
        /// execution-specific logs however it wishes. This is intended primarily to make it easier for users to debug
        /// issues that may be outside of the actual job execution, such as by identifying the worker executing the
        /// action or by providing logs from the worker's setup phase. The keys SHOULD be human readable so that a
        /// client can display them to a user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverLogs")]
        public virtual System.Collections.Generic.IDictionary<string, BuildBazelRemoteExecutionV2LogFile> ServerLogs { get; set; }

        /// <summary>
        /// If the status has a code other than `OK`, it indicates that the action did not finish execution. For
        /// example, if the operation times out during execution, the status will have a `DEADLINE_EXCEEDED` code.
        /// Servers MUST use this field for errors in execution, rather than the error field on the `Operation` object.
        /// If the status code is other than `OK`, then the result MUST NOT be cached. For an error status, the `result`
        /// field is optional; the server may populate the output-, stdout-, and stderr-related fields if it has any
        /// information available, such as the stdout and stderr of a timed-out action.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ExecutedActionMetadata contains details about a completed execution.</summary>
    public class BuildBazelRemoteExecutionV2ExecutedActionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Details that are specific to the kind of worker used. For example, on POSIX-like systems this could contain
        /// a message with getrusage(2) statistics.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auxiliaryMetadata")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> AuxiliaryMetadata { get; set; }

        /// <summary>When the worker completed executing the action command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionCompletedTimestamp")]
        public virtual object ExecutionCompletedTimestamp { get; set; }

        /// <summary>When the worker started executing the action command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionStartTimestamp")]
        public virtual object ExecutionStartTimestamp { get; set; }

        /// <summary>When the worker finished fetching action inputs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputFetchCompletedTimestamp")]
        public virtual object InputFetchCompletedTimestamp { get; set; }

        /// <summary>When the worker started fetching action inputs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputFetchStartTimestamp")]
        public virtual object InputFetchStartTimestamp { get; set; }

        /// <summary>When the worker finished uploading action outputs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputUploadCompletedTimestamp")]
        public virtual object OutputUploadCompletedTimestamp { get; set; }

        /// <summary>When the worker started uploading action outputs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputUploadStartTimestamp")]
        public virtual object OutputUploadStartTimestamp { get; set; }

        /// <summary>When was the action added to the queue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queuedTimestamp")]
        public virtual object QueuedTimestamp { get; set; }

        /// <summary>The name of the worker which ran the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("worker")]
        public virtual string Worker { get; set; }

        /// <summary>When the worker completed the action, including all stages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerCompletedTimestamp")]
        public virtual object WorkerCompletedTimestamp { get; set; }

        /// <summary>When the worker received the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerStartTimestamp")]
        public virtual object WorkerStartTimestamp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A `FileNode` represents a single file and associated metadata.</summary>
    public class BuildBazelRemoteExecutionV2FileNode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The digest of the file's content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digest")]
        public virtual BuildBazelRemoteExecutionV2Digest Digest { get; set; }

        /// <summary>True if file is executable, false otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isExecutable")]
        public virtual System.Nullable<bool> IsExecutable { get; set; }

        /// <summary>The name of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("nodeProperties")]
        public virtual BuildBazelRemoteExecutionV2NodeProperties NodeProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A `LogFile` is a log stored in the CAS.</summary>
    public class BuildBazelRemoteExecutionV2LogFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The digest of the log contents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digest")]
        public virtual BuildBazelRemoteExecutionV2Digest Digest { get; set; }

        /// <summary>
        /// This is a hint as to the purpose of the log, and is set to true if the log is human-readable text that can
        /// be usefully displayed to a user, and false otherwise. For instance, if a command-line client wishes to print
        /// the server logs to the terminal for a failed action, this allows it to avoid displaying a binary file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("humanReadable")]
        public virtual System.Nullable<bool> HumanReadable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Node properties for FileNodes, DirectoryNodes, and SymlinkNodes. The server is responsible for specifying the
    /// properties that it accepts.
    /// </summary>
    public class BuildBazelRemoteExecutionV2NodeProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The file's last modification timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mtime")]
        public virtual object Mtime { get; set; }

        /// <summary>A list of string-based NodeProperties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<BuildBazelRemoteExecutionV2NodeProperty> Properties { get; set; }

        /// <summary>The UNIX file mode, e.g., 0755.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unixMode")]
        public virtual System.Nullable<long> UnixMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A single property for FileNodes, DirectoryNodes, and SymlinkNodes. The server is responsible for specifying the
    /// property `name`s that it accepts. If permitted by the server, the same `name` may occur multiple times.
    /// </summary>
    public class BuildBazelRemoteExecutionV2NodeProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The property name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The property value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An `OutputDirectory` is the output in an `ActionResult` corresponding to a directory's full contents rather than
    /// a single file.
    /// </summary>
    public class BuildBazelRemoteExecutionV2OutputDirectory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The full path of the directory relative to the working directory. The path separator is a forward slash `/`.
        /// Since this is a relative path, it MUST NOT begin with a leading forward slash. The empty string value is
        /// allowed, and it denotes the entire working directory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The digest of the encoded Tree proto containing the directory's contents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("treeDigest")]
        public virtual BuildBazelRemoteExecutionV2Digest TreeDigest { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An `OutputFile` is similar to a FileNode, but it is used as an output in an `ActionResult`. It allows a full
    /// file path rather than only a name.
    /// </summary>
    public class BuildBazelRemoteExecutionV2OutputFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The contents of the file if inlining was requested. The server SHOULD NOT inline file contents unless
        /// requested by the client in the GetActionResultRequest message. The server MAY omit inlining, even if
        /// requested, and MUST do so if inlining would cause the response to exceed message size limits.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contents")]
        public virtual string Contents { get; set; }

        /// <summary>The digest of the file's content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digest")]
        public virtual BuildBazelRemoteExecutionV2Digest Digest { get; set; }

        /// <summary>True if file is executable, false otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isExecutable")]
        public virtual System.Nullable<bool> IsExecutable { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("nodeProperties")]
        public virtual BuildBazelRemoteExecutionV2NodeProperties NodeProperties { get; set; }

        /// <summary>
        /// The full path of the file relative to the working directory, including the filename. The path separator is a
        /// forward slash `/`. Since this is a relative path, it MUST NOT begin with a leading forward slash.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An `OutputSymlink` is similar to a Symlink, but it is used as an output in an `ActionResult`. `OutputSymlink` is
    /// binary-compatible with `SymlinkNode`.
    /// </summary>
    public class BuildBazelRemoteExecutionV2OutputSymlink : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("nodeProperties")]
        public virtual BuildBazelRemoteExecutionV2NodeProperties NodeProperties { get; set; }

        /// <summary>
        /// The full path of the symlink relative to the working directory, including the filename. The path separator
        /// is a forward slash `/`. Since this is a relative path, it MUST NOT begin with a leading forward slash.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>
        /// The target path of the symlink. The path separator is a forward slash `/`. The target path can be relative
        /// to the parent directory of the symlink or it can be an absolute path starting with `/`. Support for absolute
        /// paths can be checked using the Capabilities API. `..` components are allowed anywhere in the target path.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `Platform` is a set of requirements, such as hardware, operating system, or compiler toolchain, for an
    /// Action's execution environment. A `Platform` is represented as a series of key-value pairs representing the
    /// properties that are required of the platform.
    /// </summary>
    public class BuildBazelRemoteExecutionV2Platform : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The properties that make up this platform. In order to ensure that equivalent `Platform`s always hash to the
        /// same value, the properties MUST be lexicographically sorted by name, and then by value. Sorting of strings
        /// is done by code point, equivalently, by the UTF-8 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<BuildBazelRemoteExecutionV2PlatformProperty> Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A single property for the environment. The server is responsible for specifying the property `name`s that it
    /// accepts. If an unknown `name` is provided in the requirements for an Action, the server SHOULD reject the
    /// execution request. If permitted by the server, the same `name` may occur multiple times. The server is also
    /// responsible for specifying the interpretation of property `value`s. For instance, a property describing how much
    /// RAM must be available may be interpreted as allowing a worker with 16GB to fulfill a request for 8GB, while a
    /// property describing the OS environment on which the action must be performed may require an exact match with the
    /// worker's OS. The server MAY use the `value` of one or more properties to determine how it sets up the execution
    /// environment, such as by making specific system files available to the worker. Both names and values are
    /// typically case-sensitive. Note that the platform is implicitly part of the action digest, so even tiny changes
    /// in the names or values (like changing case) may result in different action cache entries.
    /// </summary>
    public class BuildBazelRemoteExecutionV2PlatformProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The property name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The property value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An optional Metadata to attach to any RPC request to tell the server about an external context of the request.
    /// The server may use this for logging or other purposes. To use it, the client attaches the header to the call
    /// using the canonical proto serialization: * name: `build.bazel.remote.execution.v2.requestmetadata-bin` *
    /// contents: the base64 encoded binary `RequestMetadata` message. Note: the gRPC library serializes binary headers
    /// encoded in base 64 by default (https://github.com/grpc/grpc/blob/master/doc/PROTOCOL-HTTP2.md#requests).
    /// Therefore, if the gRPC library is used to pass/retrieve this metadata, the user may ignore the base64 encoding
    /// and assume it is simply serialized as a binary message.
    /// </summary>
    public class BuildBazelRemoteExecutionV2RequestMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An identifier that ties multiple requests to the same action. For example, multiple requests to the CAS,
        /// Action Cache, and Execution API are used in order to compile foo.cc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual string ActionId { get; set; }

        /// <summary>
        /// A brief description of the kind of action, for example, CppCompile or GoLink. There is no standard agreed
        /// set of values for this, and they are expected to vary between different client tools.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionMnemonic")]
        public virtual string ActionMnemonic { get; set; }

        /// <summary>
        /// An identifier for the configuration in which the target was built, e.g. for differentiating building host
        /// tools or different target platforms. There is no expectation that this value will have any particular
        /// structure, or equality across invocations, though some client tools may offer these guarantees.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configurationId")]
        public virtual string ConfigurationId { get; set; }

        /// <summary>
        /// An identifier to tie multiple tool invocations together. For example, runs of foo_test, bar_test and
        /// baz_test on a post-submit of a given patch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("correlatedInvocationsId")]
        public virtual string CorrelatedInvocationsId { get; set; }

        /// <summary>
        /// An identifier for the target which produced this action. No guarantees are made around how many actions may
        /// relate to a single target.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetId")]
        public virtual string TargetId { get; set; }

        /// <summary>The details for the tool invoking the requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolDetails")]
        public virtual BuildBazelRemoteExecutionV2ToolDetails ToolDetails { get; set; }

        /// <summary>
        /// An identifier that ties multiple actions together to a final result. For example, multiple actions are
        /// required to build and run foo_test.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolInvocationId")]
        public virtual string ToolInvocationId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A `SymlinkNode` represents a symbolic link.</summary>
    public class BuildBazelRemoteExecutionV2SymlinkNode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the symlink.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("nodeProperties")]
        public virtual BuildBazelRemoteExecutionV2NodeProperties NodeProperties { get; set; }

        /// <summary>
        /// The target path of the symlink. The path separator is a forward slash `/`. The target path can be relative
        /// to the parent directory of the symlink or it can be an absolute path starting with `/`. Support for absolute
        /// paths can be checked using the Capabilities API. `..` components are allowed anywhere in the target path as
        /// logical canonicalization may lead to different behavior in the presence of directory symlinks (e.g.
        /// `foo/../bar` may not be the same as `bar`). To reduce potential cache misses, canonicalization is still
        /// recommended where this is possible without impacting correctness.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details for the tool used to call the API.</summary>
    public class BuildBazelRemoteExecutionV2ToolDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the tool, e.g. bazel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolName")]
        public virtual string ToolName { get; set; }

        /// <summary>Version of the tool used for the request, e.g. 5.0.3.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolVersion")]
        public virtual string ToolVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `Tree` contains all the Directory protos in a single directory Merkle tree, compressed into one message.
    /// </summary>
    public class BuildBazelRemoteExecutionV2Tree : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// All the child directories: the directories referred to by the root and, recursively, all its children. In
        /// order to reconstruct the directory tree, the client must take the digests of each of the child directories
        /// and then build up a tree starting from the `root`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("children")]
        public virtual System.Collections.Generic.IList<BuildBazelRemoteExecutionV2Directory> Children { get; set; }

        /// <summary>The root directory in the tree.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("root")]
        public virtual BuildBazelRemoteExecutionV2Directory Root { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Media resource.</summary>
    public class GoogleBytestreamMedia : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the media resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CommandDuration contains the various duration metrics tracked when a bot performs a command.</summary>
    public class GoogleDevtoolsRemotebuildbotCommandDurations : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time spent to release the CAS blobs used by the task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("casRelease")]
        public virtual object CasRelease { get; set; }

        /// <summary>
        /// The time spent waiting for Container Manager to assign an asynchronous container for execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cmWaitForAssignment")]
        public virtual object CmWaitForAssignment { get; set; }

        /// <summary>
        /// The time spent preparing the command to be run in a Docker container (includes pulling the Docker image, if
        /// necessary).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dockerPrep")]
        public virtual object DockerPrep { get; set; }

        /// <summary>The timestamp when docker preparation begins.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dockerPrepStartTime")]
        public virtual object DockerPrepStartTime { get; set; }

        /// <summary>The time spent downloading the input files and constructing the working directory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("download")]
        public virtual object Download { get; set; }

        /// <summary>The timestamp when downloading the input files begins.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadStartTime")]
        public virtual object DownloadStartTime { get; set; }

        /// <summary>The timestamp when execution begins.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("execStartTime")]
        public virtual object ExecStartTime { get; set; }

        /// <summary>The time spent executing the command (i.e., doing useful work).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("execution")]
        public virtual object Execution { get; set; }

        /// <summary>The timestamp when preparation is done and bot starts downloading files.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isoPrepDone")]
        public virtual object IsoPrepDone { get; set; }

        /// <summary>The time spent completing the command, in total.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overall")]
        public virtual object Overall { get; set; }

        /// <summary>The time spent uploading the stdout logs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stdout")]
        public virtual object Stdout { get; set; }

        /// <summary>The time spent uploading the output files.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upload")]
        public virtual object Upload { get; set; }

        /// <summary>The timestamp when uploading the output files begins.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadStartTime")]
        public virtual object UploadStartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// CommandEvents contains counters for the number of warnings and errors that occurred during the execution of a
    /// command.
    /// </summary>
    public class GoogleDevtoolsRemotebuildbotCommandEvents : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates if and how Container Manager is being used for task execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cmUsage")]
        public virtual string CmUsage { get; set; }

        /// <summary>
        /// Indicates whether we are using a cached Docker image (true) or had to pull the Docker image (false) for this
        /// command.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dockerCacheHit")]
        public virtual System.Nullable<bool> DockerCacheHit { get; set; }

        /// <summary>Docker Image name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dockerImageName")]
        public virtual string DockerImageName { get; set; }

        /// <summary>The input cache miss ratio.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputCacheMiss")]
        public virtual System.Nullable<float> InputCacheMiss { get; set; }

        /// <summary>The number of errors reported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numErrors")]
        public virtual System.Nullable<ulong> NumErrors { get; set; }

        /// <summary>The number of warnings reported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numWarnings")]
        public virtual System.Nullable<ulong> NumWarnings { get; set; }

        /// <summary>
        /// Indicates whether output files and/or output directories were found relative to the execution root or to the
        /// user provided work directory or both or none.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputLocation")]
        public virtual string OutputLocation { get; set; }

        /// <summary>Indicates whether an asynchronous container was used for execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usedAsyncContainer")]
        public virtual System.Nullable<bool> UsedAsyncContainer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The internal status of the command result.</summary>
    public class GoogleDevtoolsRemotebuildbotCommandStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>The error message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ResourceUsage is the system resource usage of the host machine.</summary>
    public class GoogleDevtoolsRemotebuildbotResourceUsage : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("cpuUsedPercent")]
        public virtual System.Nullable<double> CpuUsedPercent { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("diskUsage")]
        public virtual GoogleDevtoolsRemotebuildbotResourceUsageStat DiskUsage { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("memoryUsage")]
        public virtual GoogleDevtoolsRemotebuildbotResourceUsageStat MemoryUsage { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("totalDiskIoStats")]
        public virtual GoogleDevtoolsRemotebuildbotResourceUsageIOStats TotalDiskIoStats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleDevtoolsRemotebuildbotResourceUsageIOStats : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("readBytesCount")]
        public virtual System.Nullable<ulong> ReadBytesCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("readCount")]
        public virtual System.Nullable<ulong> ReadCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("readTimeMs")]
        public virtual System.Nullable<ulong> ReadTimeMs { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("writeBytesCount")]
        public virtual System.Nullable<ulong> WriteBytesCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("writeCount")]
        public virtual System.Nullable<ulong> WriteCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("writeTimeMs")]
        public virtual System.Nullable<ulong> WriteTimeMs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleDevtoolsRemotebuildbotResourceUsageStat : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("total")]
        public virtual System.Nullable<ulong> Total { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("used")]
        public virtual System.Nullable<ulong> Used { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AcceleratorConfig defines the accelerator cards to attach to the VM.</summary>
    public class GoogleDevtoolsRemotebuildexecutionAdminV1alphaAcceleratorConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of guest accelerator cards exposed to each VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceleratorCount")]
        public virtual System.Nullable<long> AcceleratorCount { get; set; }

        /// <summary>
        /// The type of accelerator to attach to each VM, e.g. "nvidia-tesla-k80" for nVidia Tesla K80.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceleratorType")]
        public virtual string AcceleratorType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Autoscale defines the autoscaling policy of a worker pool.</summary>
    public class GoogleDevtoolsRemotebuildexecutionAdminV1alphaAutoscale : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The maximal number of workers. Must be equal to or greater than min_size.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxSize")]
        public virtual System.Nullable<long> MaxSize { get; set; }

        /// <summary>The minimal number of workers. Must be greater than 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minSize")]
        public virtual System.Nullable<long> MinSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request used for `CreateInstance`.</summary>
    public class GoogleDevtoolsRemotebuildexecutionAdminV1alphaCreateInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the instance to create. The name in the instance, if specified in the instance, is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual GoogleDevtoolsRemotebuildexecutionAdminV1alphaInstance Instance { get; set; }

        /// <summary>
        /// ID of the created instance. A valid `instance_id` must: be 6-50 characters long, contain only lowercase
        /// letters, digits, hyphens and underscores, start with a lowercase letter, and end with a lowercase letter or
        /// a digit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceId")]
        public virtual string InstanceId { get; set; }

        /// <summary>Resource name of the project containing the instance. Format: `projects/[PROJECT_ID]`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request used for `CreateWorkerPool`.</summary>
    public class GoogleDevtoolsRemotebuildexecutionAdminV1alphaCreateWorkerPoolRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Resource name of the instance in which to create the new worker pool. Format:
        /// `projects/[PROJECT_ID]/instances/[INSTANCE_ID]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// ID of the created worker pool. A valid pool ID must: be 6-50 characters long, contain only lowercase
        /// letters, digits, hyphens and underscores, start with a lowercase letter, and end with a lowercase letter or
        /// a digit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("poolId")]
        public virtual string PoolId { get; set; }

        /// <summary>
        /// Specifies the worker pool to create. The name in the worker pool, if specified, is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerPool")]
        public virtual GoogleDevtoolsRemotebuildexecutionAdminV1alphaWorkerPool WorkerPool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request used for `DeleteInstance`.</summary>
    public class GoogleDevtoolsRemotebuildexecutionAdminV1alphaDeleteInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the instance to delete. Format: `projects/[PROJECT_ID]/instances/[INSTANCE_ID]`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request used for DeleteWorkerPool.</summary>
    public class GoogleDevtoolsRemotebuildexecutionAdminV1alphaDeleteWorkerPoolRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Name of the worker pool to delete. Format:
        /// `projects/[PROJECT_ID]/instances/[INSTANCE_ID]/workerpools/[POOL_ID]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// FeaturePolicy defines features allowed to be used on RBE instances, as well as instance-wide behavior changes
    /// that take effect without opt-in or opt-out at usage time.
    /// </summary>
    public class GoogleDevtoolsRemotebuildexecutionAdminV1alphaFeaturePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Which container image sources are allowed. Currently only RBE-supported registry (gcr.io) is allowed. One
        /// can allow all repositories under a project or one specific repository only. E.g. container_image_sources {
        /// policy: RESTRICTED allowed_values: [ "gcr.io/project-foo", "gcr.io/project-bar/repo-baz", ] } will allow any
        /// repositories under "gcr.io/project-foo" plus the repository "gcr.io/project-bar/repo-baz". Default
        /// (UNSPECIFIED) is equivalent to any source is allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerImageSources")]
        public virtual GoogleDevtoolsRemotebuildexecutionAdminV1alphaFeaturePolicyFeature ContainerImageSources { get; set; }

        /// <summary>Whether dockerAddCapabilities can be used or what capabilities are allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dockerAddCapabilities")]
        public virtual GoogleDevtoolsRemotebuildexecutionAdminV1alphaFeaturePolicyFeature DockerAddCapabilities { get; set; }

        /// <summary>Whether dockerChrootPath can be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dockerChrootPath")]
        public virtual GoogleDevtoolsRemotebuildexecutionAdminV1alphaFeaturePolicyFeature DockerChrootPath { get; set; }

        /// <summary>
        /// Whether dockerNetwork can be used or what network modes are allowed. E.g. one may allow `off` value only via
        /// `allowed_values`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dockerNetwork")]
        public virtual GoogleDevtoolsRemotebuildexecutionAdminV1alphaFeaturePolicyFeature DockerNetwork { get; set; }

        /// <summary>Whether dockerPrivileged can be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dockerPrivileged")]
        public virtual GoogleDevtoolsRemotebuildexecutionAdminV1alphaFeaturePolicyFeature DockerPrivileged { get; set; }

        /// <summary>Whether dockerRunAsRoot can be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dockerRunAsRoot")]
        public virtual GoogleDevtoolsRemotebuildexecutionAdminV1alphaFeaturePolicyFeature DockerRunAsRoot { get; set; }

        /// <summary>
        /// Whether dockerRuntime is allowed to be set or what runtimes are allowed. Note linux_isolation takes
        /// precedence, and if set, docker_runtime values may be rejected if they are incompatible with the selected
        /// isolation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dockerRuntime")]
        public virtual GoogleDevtoolsRemotebuildexecutionAdminV1alphaFeaturePolicyFeature DockerRuntime { get; set; }

        /// <summary>Whether dockerSiblingContainers can be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dockerSiblingContainers")]
        public virtual GoogleDevtoolsRemotebuildexecutionAdminV1alphaFeaturePolicyFeature DockerSiblingContainers { get; set; }

        /// <summary>
        /// linux_isolation allows overriding the docker runtime used for containers started on Linux.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linuxIsolation")]
        public virtual string LinuxIsolation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines whether a feature can be used or what values are accepted.</summary>
    public class GoogleDevtoolsRemotebuildexecutionAdminV1alphaFeaturePolicyFeature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of acceptable values. Only effective when the policy is `RESTRICTED`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedValues")]
        public virtual System.Collections.Generic.IList<string> AllowedValues { get; set; }

        /// <summary>The policy of the feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual string Policy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request used for `GetInstance`.</summary>
    public class GoogleDevtoolsRemotebuildexecutionAdminV1alphaGetInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Name of the instance to retrieve. Format: `projects/[PROJECT_ID]/instances/[INSTANCE_ID]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request used for GetWorkerPool.</summary>
    public class GoogleDevtoolsRemotebuildexecutionAdminV1alphaGetWorkerPoolRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Name of the worker pool to retrieve. Format:
        /// `projects/[PROJECT_ID]/instances/[INSTANCE_ID]/workerpools/[POOL_ID]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Instance conceptually encapsulates all Remote Build Execution resources for remote builds. An instance consists
    /// of storage and compute resources (for example, `ContentAddressableStorage`, `ActionCache`, `WorkerPools`) used
    /// for running remote builds. All Remote Build Execution API calls are scoped to an instance.
    /// </summary>
    public class GoogleDevtoolsRemotebuildexecutionAdminV1alphaInstance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The policy to define whether or not RBE features can be used or how they can be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("featurePolicy")]
        public virtual GoogleDevtoolsRemotebuildexecutionAdminV1alphaFeaturePolicy FeaturePolicy { get; set; }

        /// <summary>The location is a GCP region. Currently only `us-central1` is supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Output only. Whether stack driver logging is enabled for the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loggingEnabled")]
        public virtual System.Nullable<bool> LoggingEnabled { get; set; }

        /// <summary>
        /// Output only. Instance resource name formatted as: `projects/[PROJECT_ID]/instances/[INSTANCE_ID]`. Name
        /// should not be populated when creating an instance since it is provided in the `instance_id` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. State of the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleDevtoolsRemotebuildexecutionAdminV1alphaListInstancesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resource name of the project. Format: `projects/[PROJECT_ID]`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleDevtoolsRemotebuildexecutionAdminV1alphaListInstancesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of instances in a given project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsRemotebuildexecutionAdminV1alphaInstance> Instances { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleDevtoolsRemotebuildexecutionAdminV1alphaListWorkerPoolsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A filter expression that filters resources listed in the response. The expression must specify the
        /// field name, a comparison operator, and the value that you want to use for filtering. The value must be a
        /// string, a number, or a boolean. String values are case-insensitive. The comparison operator must be either
        /// `:`, `=`, `!=`, `&amp;gt;`, `&amp;gt;=`, `&amp;lt;=` or `&amp;lt;`. The `:` operator can be used with string
        /// fields to match substrings. For non-string fields it is equivalent to the `=` operator. The `:*` comparison
        /// can be used to test whether a key has been defined. You can also filter on nested fields. To filter on
        /// multiple expressions, you can separate expression using `AND` and `OR` operators, using parentheses to
        /// specify precedence. If neither operator is specified, `AND` is assumed. Examples: Include only pools with
        /// more than 100 reserved workers: `(worker_count &amp;gt; 100) (worker_config.reserved = true)` Include only
        /// pools with a certain label or machines of the e2-standard family: `worker_config.labels.key1 : * OR
        /// worker_config.machine_type: e2-standard`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>Resource name of the instance. Format: `projects/[PROJECT_ID]/instances/[INSTANCE_ID]`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleDevtoolsRemotebuildexecutionAdminV1alphaListWorkerPoolsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of worker pools in a given instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerPools")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsRemotebuildexecutionAdminV1alphaWorkerPool> WorkerPools { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request used for `UpdateInstance`.</summary>
    public class GoogleDevtoolsRemotebuildexecutionAdminV1alphaUpdateInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies the instance to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual GoogleDevtoolsRemotebuildexecutionAdminV1alphaInstance Instance { get; set; }

        /// <summary>
        /// Deprecated, use instance.logging_enabled instead. Whether to enable Stackdriver logging for this instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loggingEnabled")]
        public virtual System.Nullable<bool> LoggingEnabled { get; set; }

        /// <summary>
        /// Deprecated, use instance.Name instead. Name of the instance to update. Format:
        /// `projects/[PROJECT_ID]/instances/[INSTANCE_ID]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The update mask applies to instance. For the `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask If an empty
        /// update_mask is provided, only the non-default valued field in the worker pool field will be updated. Note
        /// that in order to update a field to the default value (zero, false, empty string) an explicit update_mask
        /// must be provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request used for UpdateWorkerPool.</summary>
    public class GoogleDevtoolsRemotebuildexecutionAdminV1alphaUpdateWorkerPoolRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The update mask applies to worker_pool. For the `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask If an empty
        /// update_mask is provided, only the non-default valued field in the worker pool field will be updated. Note
        /// that in order to update a field to the default value (zero, false, empty string) an explicit update_mask
        /// must be provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>Specifies the worker pool to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerPool")]
        public virtual GoogleDevtoolsRemotebuildexecutionAdminV1alphaWorkerPool WorkerPool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines the configuration to be used for creating workers in the worker pool.</summary>
    public class GoogleDevtoolsRemotebuildexecutionAdminV1alphaWorkerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The accelerator card attached to each VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accelerator")]
        public virtual GoogleDevtoolsRemotebuildexecutionAdminV1alphaAcceleratorConfig Accelerator { get; set; }

        /// <summary>
        /// Required. Size of the disk attached to the worker, in GB. See https://cloud.google.com/compute/docs/disks/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskSizeGb")]
        public virtual System.Nullable<long> DiskSizeGb { get; set; }

        /// <summary>
        /// Required. Disk Type to use for the worker. See [Storage
        /// options](https://cloud.google.com/compute/docs/disks/#introduction). Currently only `pd-standard` and
        /// `pd-ssd` are supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskType")]
        public virtual string DiskType { get; set; }

        /// <summary>
        /// Labels associated with the workers. Label keys and values can be no longer than 63 characters, can only
        /// contain lowercase letters, numeric characters, underscores and dashes. International letters are permitted.
        /// Label keys must start with a letter. Label values are optional. There can not be more than 64 labels per
        /// resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. Machine type of the worker, such as `e2-standard-2`. See
        /// https://cloud.google.com/compute/docs/machine-types for a list of supported machine types. Note that
        /// `f1-micro` and `g1-small` are not yet supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>The maximum number of actions a worker can execute concurrently.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxConcurrentActions")]
        public virtual System.Nullable<long> MaxConcurrentActions { get; set; }

        /// <summary>
        /// Minimum CPU platform to use when creating the worker. See [CPU
        /// Platforms](https://cloud.google.com/compute/docs/cpu-platforms).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minCpuPlatform")]
        public virtual string MinCpuPlatform { get; set; }

        /// <summary>
        /// Determines the type of network access granted to workers. Possible values: - "public": Workers can connect
        /// to the public internet. - "private": Workers can only connect to Google APIs and services. -
        /// "restricted-private": Workers can only connect to Google APIs that are reachable through
        /// `restricted.googleapis.com` (`199.36.153.4/30`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkAccess")]
        public virtual string NetworkAccess { get; set; }

        /// <summary>
        /// Determines whether the worker is reserved (equivalent to a Compute Engine on-demand VM and therefore won't
        /// be preempted). See [Preemptible VMs](https://cloud.google.com/preemptible-vms/) for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reserved")]
        public virtual System.Nullable<bool> Reserved { get; set; }

        /// <summary>The node type name to be used for sole-tenant nodes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("soleTenantNodeType")]
        public virtual string SoleTenantNodeType { get; set; }

        /// <summary>The name of the image used by each VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmImage")]
        public virtual string VmImage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A worker pool resource in the Remote Build Execution API.</summary>
    public class GoogleDevtoolsRemotebuildexecutionAdminV1alphaWorkerPool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The autoscale policy to apply on a pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoscale")]
        public virtual GoogleDevtoolsRemotebuildexecutionAdminV1alphaAutoscale Autoscale { get; set; }

        /// <summary>Channel specifies the release channel of the pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channel")]
        public virtual string Channel { get; set; }

        /// <summary>
        /// WorkerPool resource name formatted as:
        /// `projects/[PROJECT_ID]/instances/[INSTANCE_ID]/workerpools/[POOL_ID]`. name should not be populated when
        /// creating a worker pool since it is provided in the `poolId` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. State of the worker pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Specifies the properties, such as machine type and disk size, used for creating workers in a worker pool.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerConfig")]
        public virtual GoogleDevtoolsRemotebuildexecutionAdminV1alphaWorkerConfig WorkerConfig { get; set; }

        /// <summary>The desired number of workers in the worker pool. Must be a value between 0 and 15000.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerCount")]
        public virtual System.Nullable<long> WorkerCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// AdminTemp is a prelimiary set of administration tasks. It's called "Temp" because we do not yet know the best
    /// way to represent admin tasks; it's possible that this will be entirely replaced in later versions of this API.
    /// If this message proves to be sufficient, it will be renamed in the alpha or beta release of this API. This
    /// message (suitably marshalled into a protobuf.Any) can be used as the inline_assignment field in a lease; the
    /// lease assignment field should simply be `"admin"` in these cases. This message is heavily based on Swarming
    /// administration tasks from the LUCI project (http://github.com/luci/luci-py/appengine/swarming).
    /// </summary>
    public class GoogleDevtoolsRemoteworkersV1test2AdminTemp : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The argument to the admin action; see `Command` for semantics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arg")]
        public virtual string Arg { get; set; }

        /// <summary>The admin action; see `Command` for legal values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("command")]
        public virtual string Command { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a blob of binary content with its digest.</summary>
    public class GoogleDevtoolsRemoteworkersV1test2Blob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The contents of the blob.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contents")]
        public virtual string Contents { get; set; }

        /// <summary>The digest of the blob. This should be verified by the receiver.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digest")]
        public virtual GoogleDevtoolsRemoteworkersV1test2Digest Digest { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>DEPRECATED - use CommandResult instead. Describes the actual outputs from the task.</summary>
    public class GoogleDevtoolsRemoteworkersV1test2CommandOutputs : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// exit_code is only fully reliable if the status' code is OK. If the task exceeded its deadline or was
        /// cancelled, the process may still produce an exit code as it is cancelled, and this will be populated, but a
        /// successful (zero) is unlikely to be correct unless the status code is OK.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitCode")]
        public virtual System.Nullable<int> ExitCode { get; set; }

        /// <summary>
        /// The output files. The blob referenced by the digest should contain one of the following
        /// (implementation-dependent): * A marshalled DirectoryMetadata of the returned filesystem * A LUCI-style
        /// .isolated file
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputs")]
        public virtual GoogleDevtoolsRemoteworkersV1test2Digest Outputs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// DEPRECATED - use CommandResult instead. Can be used as part of CompleteRequest.metadata, or are part of a more
    /// sophisticated message.
    /// </summary>
    public class GoogleDevtoolsRemoteworkersV1test2CommandOverhead : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The elapsed time between calling Accept and Complete. The server will also have its own idea of what this
        /// should be, but this excludes the overhead of the RPCs and the bot response time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>The amount of time *not* spent executing the command (ie uploading/downloading files).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overhead")]
        public virtual object Overhead { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// All information about the execution of a command, suitable for providing as the Bots interface's `Lease.result`
    /// field.
    /// </summary>
    public class GoogleDevtoolsRemoteworkersV1test2CommandResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The elapsed time between calling Accept and Complete. The server will also have its own idea of what this
        /// should be, but this excludes the overhead of the RPCs and the bot response time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>
        /// The exit code of the process. An exit code of "0" should only be trusted if `status` has a code of OK
        /// (otherwise it may simply be unset).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitCode")]
        public virtual System.Nullable<int> ExitCode { get; set; }

        /// <summary>
        /// Implementation-dependent metadata about the task. Both servers and bots may define messages which can be
        /// encoded here; bots are free to provide metadata in multiple formats, and servers are free to choose one or
        /// more of the values to process and ignore others. In particular, it is *not* considered an error for the bot
        /// to provide the server with a field that it doesn't know about.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Metadata { get; set; }

        /// <summary>
        /// The output files. The blob referenced by the digest should contain one of the following
        /// (implementation-dependent): * A marshalled DirectoryMetadata of the returned filesystem * A LUCI-style
        /// .isolated file
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputs")]
        public virtual GoogleDevtoolsRemoteworkersV1test2Digest Outputs { get; set; }

        /// <summary>The amount of time *not* spent executing the command (ie uploading/downloading files).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overhead")]
        public virtual object Overhead { get; set; }

        /// <summary>
        /// An overall status for the command. For example, if the command timed out, this might have a code of
        /// DEADLINE_EXCEEDED; if it was killed by the OS for memory exhaustion, it might have a code of
        /// RESOURCE_EXHAUSTED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes a shell-style task to execute, suitable for providing as the Bots interface's `Lease.payload` field.
    /// </summary>
    public class GoogleDevtoolsRemoteworkersV1test2CommandTask : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The expected outputs from the task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedOutputs")]
        public virtual GoogleDevtoolsRemoteworkersV1test2CommandTaskOutputs ExpectedOutputs { get; set; }

        /// <summary>The inputs to the task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputs")]
        public virtual GoogleDevtoolsRemoteworkersV1test2CommandTaskInputs Inputs { get; set; }

        /// <summary>The timeouts of this task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeouts")]
        public virtual GoogleDevtoolsRemoteworkersV1test2CommandTaskTimeouts Timeouts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the inputs to a shell-style task.</summary>
    public class GoogleDevtoolsRemoteworkersV1test2CommandTaskInputs : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The command itself to run (e.g., argv). This field should be passed directly to the underlying operating
        /// system, and so it must be sensible to that operating system. For example, on Windows, the first argument
        /// might be "C:\Windows\System32\ping.exe" - that is, using drive letters and backslashes. A command for a *nix
        /// system, on the other hand, would use forward slashes. All other fields in the RWAPI must consistently use
        /// forward slashes, since those fields may be interpretted by both the service and the bot.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arguments")]
        public virtual System.Collections.Generic.IList<string> Arguments { get; set; }

        /// <summary>All environment variables required by the task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environmentVariables")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsRemoteworkersV1test2CommandTaskInputsEnvironmentVariable> EnvironmentVariables { get; set; }

        /// <summary>
        /// The input filesystem to be set up prior to the task beginning. The contents should be a repeated set of
        /// FileMetadata messages though other formats are allowed if better for the implementation (eg, a LUCI-style
        /// .isolated file). This field is repeated since implementations might want to cache the metadata, in which
        /// case it may be useful to break up portions of the filesystem that change frequently (eg, specific input
        /// files) from those that don't (eg, standard header files).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("files")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsRemoteworkersV1test2Digest> Files { get; set; }

        /// <summary>
        /// Inline contents for blobs expected to be needed by the bot to execute the task. For example, contents of
        /// entries in `files` or blobs that are indirectly referenced by an entry there. The bot should check against
        /// this list before downloading required task inputs to reduce the number of communications between itself and
        /// the remote CAS server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inlineBlobs")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsRemoteworkersV1test2Blob> InlineBlobs { get; set; }

        /// <summary>
        /// Directory from which a command is executed. It is a relative directory with respect to the bot's working
        /// directory (i.e., "./"). If it is non-empty, then it must exist under "./". Otherwise, "./" will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workingDirectory")]
        public virtual string WorkingDirectory { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An environment variable required by this task.</summary>
    public class GoogleDevtoolsRemoteworkersV1test2CommandTaskInputsEnvironmentVariable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The envvar name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The envvar value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the expected outputs of the command.</summary>
    public class GoogleDevtoolsRemoteworkersV1test2CommandTaskOutputs : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of expected directories, relative to the execution root. All paths MUST be delimited by forward
        /// slashes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directories")]
        public virtual System.Collections.Generic.IList<string> Directories { get; set; }

        /// <summary>
        /// A list of expected files, relative to the execution root. All paths MUST be delimited by forward slashes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("files")]
        public virtual System.Collections.Generic.IList<string> Files { get; set; }

        /// <summary>
        /// The destination to which any stderr should be sent. The method by which the bot should send the stream
        /// contents to that destination is not defined in this API. As examples, the destination could be a file
        /// referenced in the `files` field in this message, or it could be a URI that must be written via the
        /// ByteStream API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stderrDestination")]
        public virtual string StderrDestination { get; set; }

        /// <summary>
        /// The destination to which any stdout should be sent. The method by which the bot should send the stream
        /// contents to that destination is not defined in this API. As examples, the destination could be a file
        /// referenced in the `files` field in this message, or it could be a URI that must be written via the
        /// ByteStream API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stdoutDestination")]
        public virtual string StdoutDestination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the timeouts associated with this task.</summary>
    public class GoogleDevtoolsRemoteworkersV1test2CommandTaskTimeouts : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This specifies the maximum time that the task can run, excluding the time required to download inputs or
        /// upload outputs. That is, the worker will terminate the task if it runs longer than this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("execution")]
        public virtual object Execution { get; set; }

        /// <summary>
        /// This specifies the maximum amount of time the task can be idle - that is, go without generating some output
        /// in either stdout or stderr. If the process is silent for more than the specified time, the worker will
        /// terminate the task.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idle")]
        public virtual object Idle { get; set; }

        /// <summary>
        /// If the execution or IO timeouts are exceeded, the worker will try to gracefully terminate the task and
        /// return any existing logs. However, tasks may be hard-frozen in which case this process will fail. This
        /// timeout specifies how long to wait for a terminated task to shut down gracefully (e.g. via SIGTERM) before
        /// we bring down the hammer (e.g. SIGKILL on *nix, CTRL_BREAK_EVENT on Windows).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shutdown")]
        public virtual object Shutdown { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The CommandTask and CommandResult messages assume the existence of a service that can serve blobs of content,
    /// identified by a hash and size known as a "digest." The method by which these blobs may be retrieved is not
    /// specified here, but a model implementation is in the Remote Execution API's "ContentAddressibleStorage"
    /// interface. In the context of the RWAPI, a Digest will virtually always refer to the contents of a file or a
    /// directory. The latter is represented by the byte-encoded Directory message.
    /// </summary>
    public class GoogleDevtoolsRemoteworkersV1test2Digest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A string-encoded hash (eg "1a2b3c", not the byte array [0x1a, 0x2b, 0x3c]) using an implementation-defined
        /// hash algorithm (eg SHA-256).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hash")]
        public virtual string Hash { get; set; }

        /// <summary>
        /// The size of the contents. While this is not strictly required as part of an identifier (after all, any given
        /// hash will have exactly one canonical size), it's useful in almost all cases when one might want to send or
        /// retrieve blobs of content and is included here for this reason.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeBytes")]
        public virtual System.Nullable<long> SizeBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The contents of a directory. Similar to the equivalent message in the Remote Execution API.</summary>
    public class GoogleDevtoolsRemoteworkersV1test2Directory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Any subdirectories</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directories")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsRemoteworkersV1test2DirectoryMetadata> Directories { get; set; }

        /// <summary>The files in this directory</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("files")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsRemoteworkersV1test2FileMetadata> Files { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata for a directory. Similar to the equivalent message in the Remote Execution API.</summary>
    public class GoogleDevtoolsRemoteworkersV1test2DirectoryMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A pointer to the contents of the directory, in the form of a marshalled Directory message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digest")]
        public virtual GoogleDevtoolsRemoteworkersV1test2Digest Digest { get; set; }

        /// <summary>The path of the directory, as in FileMetadata.path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata for a file. Similar to the equivalent message in the Remote Execution API.</summary>
    public class GoogleDevtoolsRemoteworkersV1test2FileMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If the file is small enough, its contents may also or alternatively be listed here.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contents")]
        public virtual string Contents { get; set; }

        /// <summary>
        /// A pointer to the contents of the file. The method by which a client retrieves the contents from a CAS system
        /// is not defined here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digest")]
        public virtual GoogleDevtoolsRemoteworkersV1test2Digest Digest { get; set; }

        /// <summary>Properties of the file</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isExecutable")]
        public virtual System.Nullable<bool> IsExecutable { get; set; }

        /// <summary>
        /// The path of this file. If this message is part of the CommandOutputs.outputs fields, the path is relative to
        /// the execution root and must correspond to an entry in CommandTask.outputs.files. If this message is part of
        /// a Directory message, then the path is relative to the root of that directory. All paths MUST be delimited by
        /// forward slashes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class GoogleLongrunningCancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
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

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty JSON
    /// object `{}`.
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
}
