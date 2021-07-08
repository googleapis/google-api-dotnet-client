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

namespace Google.Apis.Keep.v1
{
    /// <summary>The Keep Service.</summary>
    public class KeepService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public KeepService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public KeepService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Media = new MediaResource(this);
            Notes = new NotesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "keep";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://keep.googleapis.com/";
        #else
            "https://keep.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://keep.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Google Keep API.</summary>
        public class Scope
        {
            /// <summary>See, edit, create and permanently delete all your Google Keep data</summary>
            public static string Keep = "https://www.googleapis.com/auth/keep";

            /// <summary>View all your Google Keep data</summary>
            public static string KeepReadonly = "https://www.googleapis.com/auth/keep.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Keep API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, create and permanently delete all your Google Keep data</summary>
            public const string Keep = "https://www.googleapis.com/auth/keep";

            /// <summary>View all your Google Keep data</summary>
            public const string KeepReadonly = "https://www.googleapis.com/auth/keep.readonly";
        }

        /// <summary>Gets the Media resource.</summary>
        public virtual MediaResource Media { get; }

        /// <summary>Gets the Notes resource.</summary>
        public virtual NotesResource Notes { get; }
    }

    /// <summary>A base abstract class for Keep requests.</summary>
    public abstract class KeepBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new KeepBaseServiceRequest instance.</summary>
        protected KeepBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Keep parameter list.</summary>
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

        /// <summary>
        /// Gets an attachment. To download attachment media via REST requires the alt=media query parameter. Returns a
        /// 400 bad request error if attachment media is not available in the requested MIME type.
        /// </summary>
        /// <param name="name">Required. The name of the attachment.</param>
        public virtual DownloadRequest Download(string name)
        {
            return new DownloadRequest(service, name);
        }

        /// <summary>
        /// Gets an attachment. To download attachment media via REST requires the alt=media query parameter. Returns a
        /// 400 bad request error if attachment media is not available in the requested MIME type.
        /// </summary>
        public class DownloadRequest : KeepBaseServiceRequest<Google.Apis.Keep.v1.Data.Attachment>
        {
            /// <summary>Constructs a new Download request.</summary>
            public DownloadRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                MediaDownloader = new Google.Apis.Download.MediaDownloader(service);
                InitParameters();
            }

            /// <summary>Required. The name of the attachment.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// The IANA MIME type format requested. The requested MIME type must be one specified in the
            /// attachment.mime_type. Required when downloading attachment media and ignored otherwise.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("mimeType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string MimeType { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "download";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes Download parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^notes/[^/]+/attachments/[^/]+$",
                });
                RequestParameters.Add("mimeType", new Google.Apis.Discovery.Parameter
                {
                    Name = "mimeType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
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
    }

    /// <summary>The "notes" collection of methods.</summary>
    public class NotesResource
    {
        private const string Resource = "notes";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public NotesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Permissions = new PermissionsResource(service);
        }

        /// <summary>Gets the Permissions resource.</summary>
        public virtual PermissionsResource Permissions { get; }

        /// <summary>The "permissions" collection of methods.</summary>
        public class PermissionsResource
        {
            private const string Resource = "permissions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public PermissionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates one or more permissions on the note. Only permissions with the `WRITER` role may be created. If
            /// adding any permission fails, then the entire request fails and no changes are made.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// The parent resource shared by all Permissions being created. Format: `notes/{note}` If this is set, the
            /// parent field in the CreatePermission messages must either be empty or match this field.
            /// </param>
            public virtual BatchCreateRequest BatchCreate(Google.Apis.Keep.v1.Data.BatchCreatePermissionsRequest body, string parent)
            {
                return new BatchCreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates one or more permissions on the note. Only permissions with the `WRITER` role may be created. If
            /// adding any permission fails, then the entire request fails and no changes are made.
            /// </summary>
            public class BatchCreateRequest : KeepBaseServiceRequest<Google.Apis.Keep.v1.Data.BatchCreatePermissionsResponse>
            {
                /// <summary>Constructs a new BatchCreate request.</summary>
                public BatchCreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Keep.v1.Data.BatchCreatePermissionsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The parent resource shared by all Permissions being created. Format: `notes/{note}` If this is set,
                /// the parent field in the CreatePermission messages must either be empty or match this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Keep.v1.Data.BatchCreatePermissionsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchCreate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/permissions:batchCreate";

                /// <summary>Initializes BatchCreate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^notes/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes one or more permissions on the note. The specified entities will immediately lose access. A
            /// permission with the `OWNER` role can't be removed. If removing a permission fails, then the entire
            /// request fails and no changes are made. Returns a 400 bad request error if a specified permission does
            /// not exist on the note.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// The parent resource shared by all permissions being deleted. Format: `notes/{note}` If this is set, the
            /// parent of all of the permissions specified in the DeletePermissionRequest messages must match this
            /// field.
            /// </param>
            public virtual BatchDeleteRequest BatchDelete(Google.Apis.Keep.v1.Data.BatchDeletePermissionsRequest body, string parent)
            {
                return new BatchDeleteRequest(service, body, parent);
            }

            /// <summary>
            /// Deletes one or more permissions on the note. The specified entities will immediately lose access. A
            /// permission with the `OWNER` role can't be removed. If removing a permission fails, then the entire
            /// request fails and no changes are made. Returns a 400 bad request error if a specified permission does
            /// not exist on the note.
            /// </summary>
            public class BatchDeleteRequest : KeepBaseServiceRequest<Google.Apis.Keep.v1.Data.Empty>
            {
                /// <summary>Constructs a new BatchDelete request.</summary>
                public BatchDeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Keep.v1.Data.BatchDeletePermissionsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The parent resource shared by all permissions being deleted. Format: `notes/{note}` If this is set,
                /// the parent of all of the permissions specified in the DeletePermissionRequest messages must match
                /// this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Keep.v1.Data.BatchDeletePermissionsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchDelete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/permissions:batchDelete";

                /// <summary>Initializes BatchDelete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^notes/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Creates a new note.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.Keep.v1.Data.Note body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>Creates a new note.</summary>
        public class CreateRequest : KeepBaseServiceRequest<Google.Apis.Keep.v1.Data.Note>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Keep.v1.Data.Note body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Keep.v1.Data.Note Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/notes";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Deletes a note. Caller must have the `OWNER` role on the note to delete. Deleting a note removes the
        /// resource immediately and cannot be undone. Any collaborators will lose access to the note.
        /// </summary>
        /// <param name="name">Required. Name of the note to delete.</param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>
        /// Deletes a note. Caller must have the `OWNER` role on the note to delete. Deleting a note removes the
        /// resource immediately and cannot be undone. Any collaborators will lose access to the note.
        /// </summary>
        public class DeleteRequest : KeepBaseServiceRequest<Google.Apis.Keep.v1.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. Name of the note to delete.</summary>
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
                    Pattern = @"^notes/[^/]+$",
                });
            }
        }

        /// <summary>Gets a note.</summary>
        /// <param name="name">Required. Name of the resource.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Gets a note.</summary>
        public class GetRequest : KeepBaseServiceRequest<Google.Apis.Keep.v1.Data.Note>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. Name of the resource.</summary>
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
                    Pattern = @"^notes/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Lists notes. Every list call returns a page of results with `page_size` as the upper bound of returned
        /// items. A `page_size` of zero allows the server to choose the upper bound. The ListNotesResponse contains at
        /// most `page_size` entries. If there are more things left to list, it provides a `next_page_token` value.
        /// (Page tokens are opaque values.) To get the next page of results, copy the result's `next_page_token` into
        /// the next request's `page_token`. Repeat until the `next_page_token` returned with a page of results is
        /// empty. ListNotes return consistent results in the face of concurrent changes, or signals that it cannot with
        /// an ABORTED error.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>
        /// Lists notes. Every list call returns a page of results with `page_size` as the upper bound of returned
        /// items. A `page_size` of zero allows the server to choose the upper bound. The ListNotesResponse contains at
        /// most `page_size` entries. If there are more things left to list, it provides a `next_page_token` value.
        /// (Page tokens are opaque values.) To get the next page of results, copy the result's `next_page_token` into
        /// the next request's `page_token`. Repeat until the `next_page_token` returned with a page of results is
        /// empty. ListNotes return consistent results in the face of concurrent changes, or signals that it cannot with
        /// an ABORTED error.
        /// </summary>
        public class ListRequest : KeepBaseServiceRequest<Google.Apis.Keep.v1.Data.ListNotesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Filter for list results. If no filter is supplied, the `trashed` filter is applied by default. Valid
            /// fields to filter by are: `create_time`, `update_time`, `trash_time`, and `trashed`. Filter syntax
            /// follows the [Google AIP filtering spec](https://aip.dev/160).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>The maximum number of results to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>The previous page's `next_page_token` field.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/notes";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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
namespace Google.Apis.Keep.v1.Data
{
    /// <summary>An attachment to a note.</summary>
    public class Attachment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The MIME types (IANA media types) in which the attachment is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual System.Collections.Generic.IList<string> MimeType { get; set; }

        /// <summary>The resource name;</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The request to add one or more permissions on the note. Currently, only the `WRITER` role may be specified. If
    /// adding a permission fails, then the entire request fails and no changes are made.
    /// </summary>
    public class BatchCreatePermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The request message specifying the resources to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<CreatePermissionRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for creating permissions on a note.</summary>
    public class BatchCreatePermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Permissions created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<Permission> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The request to remove one or more permissions from a note. A permission with the `OWNER` role can't be removed.
    /// If removing a permission fails, then the entire request fails and no changes are made. Returns a 400 bad request
    /// error if a specified permission does not exist on the note.
    /// </summary>
    public class BatchDeletePermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The names of the permissions to delete. Format: `notes/{note}/permissions/{permission}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("names")]
        public virtual System.Collections.Generic.IList<string> Names { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to add a single permission on the note.</summary>
    public class CreatePermissionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The parent note where this permission will be created. Format: `notes/{note}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Required. The permission to create. One of Permission.email, User.email or Group.email must be supplied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permission")]
        public virtual Permission Permission { get; set; }

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

    /// <summary>Describes a single Google Family.</summary>
    public class Family : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a single Group.</summary>
    public class Group : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The group email.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The list of items for a single list note.</summary>
    public class ListContent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The items in the list. The number of items must be less than 1,000.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listItems")]
        public virtual System.Collections.Generic.IList<ListItem> ListItems { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single list item in a note's list.</summary>
    public class ListItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether this item has been checked off or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checked")]
        public virtual System.Nullable<bool> Checked__ { get; set; }

        /// <summary>
        /// If set, list of list items nested under this list item. Only one level of nesting is allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childListItems")]
        public virtual System.Collections.Generic.IList<ListItem> ChildListItems { get; set; }

        /// <summary>The text of this item. Length must be less than 1,000 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual TextContent Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response when listing a page of notes.</summary>
    public class ListNotesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Next page's `page_token` field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A page of notes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual System.Collections.Generic.IList<Note> Notes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single note.</summary>
    public class Note : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The attachments attached to this note.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachments")]
        public virtual System.Collections.Generic.IList<Attachment> Attachments { get; set; }

        /// <summary>The body of the note.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual Section Body { get; set; }

        /// <summary>Output only. When this note was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Output only. The resource name of this note. See general note on identifiers in KeepService.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The list of permissions set on the note. Contains at least one entry for the note owner.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<Permission> Permissions { get; set; }

        /// <summary>The title of the note. Length must be less than 1,000 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// Output only. When this note was trashed. If `trashed`, the note is eventually deleted. If the note is not
        /// trashed, this field is not set (and the trashed field is `false`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trashTime")]
        public virtual object TrashTime { get; set; }

        /// <summary>
        /// Output only. `true` if this note has been trashed. If trashed, the note is eventually deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trashed")]
        public virtual System.Nullable<bool> Trashed { get; set; }

        /// <summary>Output only. When this note was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single permission on the note. Associates a `member` with a `role`.</summary>
    public class Permission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Whether this member has been deleted. If the member is recovered, this value is set to false
        /// and the recovered member retains the role on the note.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleted")]
        public virtual System.Nullable<bool> Deleted { get; set; }

        /// <summary>
        /// The email associated with the member. If set on create, the `email` field in the `User` or `Group` message
        /// must either be empty or match this field. On read, may be unset if the member does not have an associated
        /// email.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>Output only. The Google Family to which this role applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("family")]
        public virtual Family Family { get; set; }

        /// <summary>Output only. The group to which this role applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual Group Group { get; set; }

        /// <summary>Output only. The resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The role granted by this permission. The role determines the entity’s ability to read, write, and share
        /// notes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>Output only. The user to whom this role applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual User User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The content of the note.</summary>
    public class Section : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Used if this section's content is a list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("list")]
        public virtual ListContent List { get; set; }

        /// <summary>
        /// Used if this section's content is a block of text. The length of the text content must be less than 20,000
        /// characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual TextContent Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The block of text for a single text section or list item.</summary>
    public class TextContent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The text of the note. The limits on this vary with the specific field using this type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a single user.</summary>
    public class User : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The user's email.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
